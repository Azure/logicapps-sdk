//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjml
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectjmlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse> RunActiveDirectoryPowerShellAutomationScript([WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/RunActiveDirectoryPowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runActiveDirectoryPowerShellAutomationScript = new JObject();
                var runActiveDirectoryPowerShellAutomationScriptpropCount = 0;
                if (runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PowerShellScriptContents"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError);
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
                        runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes);
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
                        runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean);
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
                        runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal);
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
                        runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate);
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
                    runActiveDirectoryPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread);
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
                    runActiveDirectoryPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread);
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
                        runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword);
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
                        runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput);
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
                    runActiveDirectoryPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                if (runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["PowerShellCommandParameters"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters);
                    runActiveDirectoryPowerShellAutomationScriptpropCount++;
                }

                runActiveDirectoryPowerShellAutomationScriptpropCount++;
                runActiveDirectoryPowerShellAutomationScript["Workflow"] = SourceExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptworkflow);
                if (runActiveDirectoryPowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runActiveDirectoryPowerShellAutomationScript;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse> OpenActiveDirectoryPowerShellRunspaceWithCredentials([WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsusername, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialspassword, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = null, [WorkflowExpression] Func<bool> openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = null, [WorkflowExpression] Func<int> openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/OpenActiveDirectoryPowerShellRunspaceWithCredentials";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openActiveDirectoryPowerShellRunspaceWithCredentials = new JObject();
                var openActiveDirectoryPowerShellRunspaceWithCredentialspropCount = 0;
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Username"] = SourceExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsusername);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Password"] = SourceExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialspassword);
                if (openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer != null)
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["RemoteComputer"] = SourceExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer);
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                if (openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                {
                    if (openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                    {
                        openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = SourceExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL);
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
                    openActiveDirectoryPowerShellRunspaceWithCredentials["AlternativeTCPPort"] = SourceExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort);
                    openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                }

                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
                openActiveDirectoryPowerShellRunspaceWithCredentials["Workflow"] = SourceExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow);
                if (openActiveDirectoryPowerShellRunspaceWithCredentialspropCount > 0)
                {
                    callPayload.Body = openActiveDirectoryPowerShellRunspaceWithCredentials;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse> CloseActiveDirectoryPowerShellRunspace([WorkflowExpression] Func<string> closeActiveDirectoryPowerShellRunspaceworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/CloseActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeActiveDirectoryPowerShellRunspace = new JObject();
                var closeActiveDirectoryPowerShellRunspacepropCount = 0;
                closeActiveDirectoryPowerShellRunspacepropCount++;
                closeActiveDirectoryPowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(closeActiveDirectoryPowerShellRunspaceworkflow);
                if (closeActiveDirectoryPowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeActiveDirectoryPowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseActiveDirectoryPowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse> IsActiveDirectoryPowerShellRunspaceOpen([WorkflowExpression] Func<string> isActiveDirectoryPowerShellRunspaceOpenworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/IsActiveDirectoryPowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isActiveDirectoryPowerShellRunspaceOpen = new JObject();
                var isActiveDirectoryPowerShellRunspaceOpenpropCount = 0;
                isActiveDirectoryPowerShellRunspaceOpenpropCount++;
                isActiveDirectoryPowerShellRunspaceOpen["Workflow"] = SourceExpressionConverter.ConvertToken(isActiveDirectoryPowerShellRunspaceOpenworkflow);
                if (isActiveDirectoryPowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isActiveDirectoryPowerShellRunspaceOpen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse> OpenLocalPassthroughActiveDirectoryPowerShellRunspace([WorkflowExpression] Func<string> openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/OpenLocalPassthroughActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openLocalPassthroughActiveDirectoryPowerShellRunspace = new JObject();
                var openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount = 0;
                openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount++;
                openLocalPassthroughActiveDirectoryPowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow);
                if (openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openLocalPassthroughActiveDirectoryPowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse> ActiveDirectoryAddADUser([WorkflowExpression] Func<string> activeDirectoryAddADUsername, [WorkflowExpression] Func<string> activeDirectoryAddADUserworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADUseruserPrincipalName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsersamAccountName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsergivenName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsersurName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserpath = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUseraccountPassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUseraccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserenabled = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserchangePasswordAtLogon = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUsercannotChangePassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserpasswordNeverExpires = null, [WorkflowExpression] Func<string> activeDirectoryAddADUseraDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADUser = new JObject();
                var activeDirectoryAddADUserpropCount = 0;
                activeDirectoryAddADUserpropCount++;
                activeDirectoryAddADUser["Name"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUsername);
                if (activeDirectoryAddADUseruserPrincipalName != null)
                {
                    activeDirectoryAddADUser["UserPrincipalName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUseruserPrincipalName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsersamAccountName != null)
                {
                    activeDirectoryAddADUser["SamAccountName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUsersamAccountName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsergivenName != null)
                {
                    activeDirectoryAddADUser["GivenName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUsergivenName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUsersurName != null)
                {
                    activeDirectoryAddADUser["SurName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUsersurName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserpath != null)
                {
                    activeDirectoryAddADUser["Path"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserpath);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserdescription != null)
                {
                    activeDirectoryAddADUser["Description"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserdescription);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUserdisplayName != null)
                {
                    activeDirectoryAddADUser["DisplayName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserdisplayName);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUseraccountPassword != null)
                {
                    activeDirectoryAddADUser["AccountPassword"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUseraccountPassword);
                    activeDirectoryAddADUserpropCount++;
                }

                if (activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                {
                    if (activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                    {
                        activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUseraccountPasswordIsStoredPassword);
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
                        activeDirectoryAddADUser["Enabled"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserenabled);
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
                        activeDirectoryAddADUser["ChangePasswordAtLogon"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserchangePasswordAtLogon);
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
                        activeDirectoryAddADUser["CannotChangePassword"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUsercannotChangePassword);
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
                        activeDirectoryAddADUser["PasswordNeverExpires"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserpasswordNeverExpires);
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
                    activeDirectoryAddADUser["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUseraDServer);
                    activeDirectoryAddADUserpropCount++;
                }

                activeDirectoryAddADUserpropCount++;
                activeDirectoryAddADUser["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserworkflow);
                if (activeDirectoryAddADUserpropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADUser;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse> ActiveDirectoryGetADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityidentity = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityfilterPropertyName = null, [WorkflowExpression] Func<activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput> activeDirectoryGetADUserByIdentityfilterPropertyComparison = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityfilterPropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitysearchOUBase = null, [WorkflowExpression] Func<bool> activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityproperties = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityaDServer = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADUserByIdentity = new JObject();
                var activeDirectoryGetADUserByIdentitypropCount = 0;
                if (activeDirectoryGetADUserByIdentityidentity != null)
                {
                    activeDirectoryGetADUserByIdentity["Identity"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityidentity);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityfilterPropertyName != null)
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityfilterPropertyName);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                {
                    if (activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                    {
                        activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = SourceExpressionConverter.Convert(activeDirectoryGetADUserByIdentityfilterPropertyComparison);
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
                    activeDirectoryGetADUserByIdentity["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityfilterPropertyValue);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitysearchOUBase != null)
                {
                    activeDirectoryGetADUserByIdentity["SearchOUBase"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitysearchOUBase);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                {
                    if (activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                    {
                        activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree);
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
                    activeDirectoryGetADUserByIdentity["Properties"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityproperties);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentityaDServer != null)
                {
                    activeDirectoryGetADUserByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityaDServer);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertiesToReturnAsCollectionJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertyNamesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                if (activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON != null)
                {
                    activeDirectoryGetADUserByIdentity["PropertyTypesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON);
                    activeDirectoryGetADUserByIdentitypropCount++;
                }

                activeDirectoryGetADUserByIdentitypropCount++;
                activeDirectoryGetADUserByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityworkflow);
                if (activeDirectoryGetADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADUserByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADUserByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse> ActiveDirectoryGetOUFromUserDN([WorkflowExpression] Func<string> activeDirectoryGetOUFromUserDNuserDN, [WorkflowExpression] Func<string> activeDirectoryGetOUFromUserDNworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetOUFromUserDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetOUFromUserDN = new JObject();
                var activeDirectoryGetOUFromUserDNpropCount = 0;
                activeDirectoryGetOUFromUserDNpropCount++;
                activeDirectoryGetOUFromUserDN["UserDN"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetOUFromUserDNuserDN);
                activeDirectoryGetOUFromUserDNpropCount++;
                activeDirectoryGetOUFromUserDN["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetOUFromUserDNworkflow);
                if (activeDirectoryGetOUFromUserDNpropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetOUFromUserDN;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetOUFromUserDNResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse> ActiveDirectoryGetDomainFQDNFromDN([WorkflowExpression] Func<string> activeDirectoryGetDomainFQDNFromDNdN, [WorkflowExpression] Func<string> activeDirectoryGetDomainFQDNFromDNworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainFQDNFromDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetDomainFQDNFromDN = new JObject();
                var activeDirectoryGetDomainFQDNFromDNpropCount = 0;
                activeDirectoryGetDomainFQDNFromDNpropCount++;
                activeDirectoryGetDomainFQDNFromDN["DN"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetDomainFQDNFromDNdN);
                activeDirectoryGetDomainFQDNFromDNpropCount++;
                activeDirectoryGetDomainFQDNFromDN["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetDomainFQDNFromDNworkflow);
                if (activeDirectoryGetDomainFQDNFromDNpropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetDomainFQDNFromDN;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse> ActiveDirectoryGetADGroupByIdentity([WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityidentity = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityfilterPropertyName = null, [WorkflowExpression] Func<activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput> activeDirectoryGetADGroupByIdentityfilterPropertyComparison = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityfilterPropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentitysearchOUBase = null, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = null, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADGroupByIdentity = new JObject();
                var activeDirectoryGetADGroupByIdentitypropCount = 0;
                if (activeDirectoryGetADGroupByIdentityidentity != null)
                {
                    activeDirectoryGetADGroupByIdentity["Identity"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityidentity);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityfilterPropertyName != null)
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityfilterPropertyName);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                {
                    if (activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                    {
                        activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = SourceExpressionConverter.Convert(activeDirectoryGetADGroupByIdentityfilterPropertyComparison);
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
                    activeDirectoryGetADGroupByIdentity["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityfilterPropertyValue);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentitysearchOUBase != null)
                {
                    activeDirectoryGetADGroupByIdentity["SearchOUBase"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentitysearchOUBase);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                if (activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                {
                    if (activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                    {
                        activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree);
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
                        activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist);
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
                    activeDirectoryGetADGroupByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityaDServer);
                    activeDirectoryGetADGroupByIdentitypropCount++;
                }

                activeDirectoryGetADGroupByIdentitypropCount++;
                activeDirectoryGetADGroupByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityworkflow);
                if (activeDirectoryGetADGroupByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADGroupByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADGroupByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse> ActiveDirectoryAddADGroupMemberByIdentity([WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentitygroupName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroupMemberByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADGroupMemberByIdentity = new JObject();
                var activeDirectoryAddADGroupMemberByIdentitypropCount = 0;
                if (activeDirectoryAddADGroupMemberByIdentitygroupIdentity != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentitygroupIdentity);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                if (activeDirectoryAddADGroupMemberByIdentitygroupName != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["GroupName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentitygroupName);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                activeDirectoryAddADGroupMemberByIdentitypropCount++;
                activeDirectoryAddADGroupMemberByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentityuserIdentity);
                if (activeDirectoryAddADGroupMemberByIdentityaDServer != null)
                {
                    activeDirectoryAddADGroupMemberByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentityaDServer);
                    activeDirectoryAddADGroupMemberByIdentitypropCount++;
                }

                activeDirectoryAddADGroupMemberByIdentitypropCount++;
                activeDirectoryAddADGroupMemberByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentityworkflow);
                if (activeDirectoryAddADGroupMemberByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADGroupMemberByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse> ActiveDirectoryAddMultipleADGroupMembersByIdentity([WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = null, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddMultipleADGroupMembersByIdentity = new JObject();
                var activeDirectoryAddMultipleADGroupMembersByIdentitypropCount = 0;
                if (activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["GroupMembersJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                {
                    if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                    {
                        activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd);
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
                        activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd);
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
                        activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall);
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
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer);
                    activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                }

                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
                activeDirectoryAddMultipleADGroupMembersByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow);
                if (activeDirectoryAddMultipleADGroupMembersByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddMultipleADGroupMembersByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse> ActiveDirectoryAddADUserToMultipleADGroupsByName([WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = null, [WorkflowExpression] Func<int> activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUserToMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADUserToMultipleADGroupsByName = new JObject();
                var activeDirectoryAddADUserToMultipleADGroupsByNamepropCount = 0;
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                activeDirectoryAddADUserToMultipleADGroupsByName["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity);
                if (activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["GroupNamesJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                {
                    if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                    {
                        activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd);
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
                        activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd);
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
                    activeDirectoryAddADUserToMultipleADGroupsByName["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["MaxGroupsPerCall"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall);
                    activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                }

                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
                activeDirectoryAddADUserToMultipleADGroupsByName["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow);
                if (activeDirectoryAddADUserToMultipleADGroupsByNamepropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADUserToMultipleADGroupsByName;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse> ActiveDirectoryGetADUserGroupMembership([WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipuserIdentity, [WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADUserGroupMembership = new JObject();
                var activeDirectoryGetADUserGroupMembershippropCount = 0;
                activeDirectoryGetADUserGroupMembershippropCount++;
                activeDirectoryGetADUserGroupMembership["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserGroupMembershipuserIdentity);
                if (activeDirectoryGetADUserGroupMembershipaDServer != null)
                {
                    activeDirectoryGetADUserGroupMembership["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserGroupMembershipaDServer);
                    activeDirectoryGetADUserGroupMembershippropCount++;
                }

                activeDirectoryGetADUserGroupMembershippropCount++;
                activeDirectoryGetADUserGroupMembership["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADUserGroupMembershipworkflow);
                if (activeDirectoryGetADUserGroupMembershippropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADUserGroupMembership;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADUserGroupMembershipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse> ActiveDirectoryModifyADUserStringPropertyByIdentity([WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityworkflow, [WorkflowExpression] Func<activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem[]> activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityaDServer = null, [WorkflowExpression] Func<bool> activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserStringPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserStringPropertyByIdentity = new JObject();
                var activeDirectoryModifyADUserStringPropertyByIdentitypropCount = 0;
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserStringPropertyByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity);
                if (activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["PropertiesList"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList);
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                if (activeDirectoryModifyADUserStringPropertyByIdentityaDServer != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityaDServer);
                    activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
                }

                if (activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                {
                    if (activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                    {
                        activeDirectoryModifyADUserStringPropertyByIdentity["ReplaceValue"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue);
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
                activeDirectoryModifyADUserStringPropertyByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityworkflow);
                if (activeDirectoryModifyADUserStringPropertyByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserStringPropertyByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse> ActiveDirectoryModifyADUserBooleanPropertyByIdentity([WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserBooleanPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserBooleanPropertyByIdentity = new JObject();
                var activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount = 0;
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity);
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyName"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName);
                if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                {
                    if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                    {
                        activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue);
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
                    activeDirectoryModifyADUserBooleanPropertyByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer);
                    activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                }

                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
                activeDirectoryModifyADUserBooleanPropertyByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow);
                if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserBooleanPropertyByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse> ActiveDirectoryModifyADUserProperties([WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesworkflow, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescity = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescompany = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountry = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountryString = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountryISO3166 = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdepartment = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdescription = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesemailAddress = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesgivenName = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertieshomePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesinitials = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesiPPhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesmanager = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesmobilePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesnotes = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesoffice = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesofficePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiespostalCode = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesprofilePath = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesscriptPath = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesstate = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesstreetAddress = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiessurname = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiestitle = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryModifyADUserProperties = new JObject();
                var activeDirectoryModifyADUserPropertiespropCount = 0;
                activeDirectoryModifyADUserPropertiespropCount++;
                activeDirectoryModifyADUserProperties["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesuserIdentity);
                if (activeDirectoryModifyADUserPropertiescity != null)
                {
                    activeDirectoryModifyADUserProperties["City"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescity);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescompany != null)
                {
                    activeDirectoryModifyADUserProperties["Company"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescompany);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescountry != null)
                {
                    activeDirectoryModifyADUserProperties["Country"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescountry);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescountryString != null)
                {
                    activeDirectoryModifyADUserProperties["CountryString"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescountryString);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiescountryISO3166 != null)
                {
                    activeDirectoryModifyADUserProperties["CountryISO3166"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescountryISO3166);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesdepartment != null)
                {
                    activeDirectoryModifyADUserProperties["Department"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesdepartment);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesdescription != null)
                {
                    activeDirectoryModifyADUserProperties["Description"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesdescription);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesdisplayName != null)
                {
                    activeDirectoryModifyADUserProperties["DisplayName"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesdisplayName);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesemailAddress != null)
                {
                    activeDirectoryModifyADUserProperties["EmailAddress"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesemailAddress);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesgivenName != null)
                {
                    activeDirectoryModifyADUserProperties["GivenName"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesgivenName);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertieshomePhone != null)
                {
                    activeDirectoryModifyADUserProperties["HomePhone"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertieshomePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesinitials != null)
                {
                    activeDirectoryModifyADUserProperties["Initials"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesinitials);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesiPPhone != null)
                {
                    activeDirectoryModifyADUserProperties["IPPhone"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesiPPhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesmanager != null)
                {
                    activeDirectoryModifyADUserProperties["Manager"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesmanager);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesmobilePhone != null)
                {
                    activeDirectoryModifyADUserProperties["MobilePhone"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesmobilePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesnotes != null)
                {
                    activeDirectoryModifyADUserProperties["Notes"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesnotes);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesoffice != null)
                {
                    activeDirectoryModifyADUserProperties["Office"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesoffice);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesofficePhone != null)
                {
                    activeDirectoryModifyADUserProperties["OfficePhone"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesofficePhone);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiespostalCode != null)
                {
                    activeDirectoryModifyADUserProperties["PostalCode"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiespostalCode);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesprofilePath != null)
                {
                    activeDirectoryModifyADUserProperties["ProfilePath"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesprofilePath);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesscriptPath != null)
                {
                    activeDirectoryModifyADUserProperties["ScriptPath"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesscriptPath);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesstate != null)
                {
                    activeDirectoryModifyADUserProperties["State"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesstate);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesstreetAddress != null)
                {
                    activeDirectoryModifyADUserProperties["StreetAddress"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesstreetAddress);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiessurname != null)
                {
                    activeDirectoryModifyADUserProperties["Surname"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiessurname);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiestitle != null)
                {
                    activeDirectoryModifyADUserProperties["Title"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiestitle);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                if (activeDirectoryModifyADUserPropertiesaDServer != null)
                {
                    activeDirectoryModifyADUserProperties["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesaDServer);
                    activeDirectoryModifyADUserPropertiespropCount++;
                }

                activeDirectoryModifyADUserPropertiespropCount++;
                activeDirectoryModifyADUserProperties["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesworkflow);
                if (activeDirectoryModifyADUserPropertiespropCount > 0)
                {
                    callPayload.Body = activeDirectoryModifyADUserProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse> ActiveDirectoryMoveADUserToOUByIdentity([WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentitytargetPath, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryMoveADUserToOUByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryMoveADUserToOUByIdentity = new JObject();
                var activeDirectoryMoveADUserToOUByIdentitypropCount = 0;
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentityuserIdentity);
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["TargetPath"] = SourceExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentitytargetPath);
                if (activeDirectoryMoveADUserToOUByIdentityaDServer != null)
                {
                    activeDirectoryMoveADUserToOUByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentityaDServer);
                    activeDirectoryMoveADUserToOUByIdentitypropCount++;
                }

                activeDirectoryMoveADUserToOUByIdentitypropCount++;
                activeDirectoryMoveADUserToOUByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentityworkflow);
                if (activeDirectoryMoveADUserToOUByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryMoveADUserToOUByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse> ActiveDirectoryClearADUserAccountExpiration([WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationuserIdentity, [WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationworkflow, [WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryClearADUserAccountExpiration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryClearADUserAccountExpiration = new JObject();
                var activeDirectoryClearADUserAccountExpirationpropCount = 0;
                activeDirectoryClearADUserAccountExpirationpropCount++;
                activeDirectoryClearADUserAccountExpiration["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryClearADUserAccountExpirationuserIdentity);
                if (activeDirectoryClearADUserAccountExpirationaDServer != null)
                {
                    activeDirectoryClearADUserAccountExpiration["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryClearADUserAccountExpirationaDServer);
                    activeDirectoryClearADUserAccountExpirationpropCount++;
                }

                activeDirectoryClearADUserAccountExpirationpropCount++;
                activeDirectoryClearADUserAccountExpiration["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryClearADUserAccountExpirationworkflow);
                if (activeDirectoryClearADUserAccountExpirationpropCount > 0)
                {
                    callPayload.Body = activeDirectoryClearADUserAccountExpiration;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryClearADUserAccountExpirationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse> ActiveDirectoryDirSync([WorkflowExpression] Func<string> activeDirectoryDirSyncworkflow, [WorkflowExpression] Func<activeDirectoryDirSyncpolicyTypeInput> activeDirectoryDirSyncpolicyType = null, [WorkflowExpression] Func<string> activeDirectoryDirSynccomputerName = null, [WorkflowExpression] Func<int> activeDirectoryDirSyncmaxRetryAttempts = null, [WorkflowExpression] Func<int> activeDirectoryDirSyncsecondsBetweenRetries = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDirSync";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDirSync = new JObject();
                var activeDirectoryDirSyncpropCount = 0;
                if (activeDirectoryDirSyncpolicyType != null)
                {
                    activeDirectoryDirSync["PolicyType"] = SourceExpressionConverter.Convert(activeDirectoryDirSyncpolicyType);
                    activeDirectoryDirSyncpropCount++;
                }

                if (activeDirectoryDirSynccomputerName != null)
                {
                    activeDirectoryDirSync["ComputerName"] = SourceExpressionConverter.ConvertToken(activeDirectoryDirSynccomputerName);
                    activeDirectoryDirSyncpropCount++;
                }

                if (activeDirectoryDirSyncmaxRetryAttempts != null)
                {
                    if (activeDirectoryDirSyncmaxRetryAttempts != null)
                    {
                        activeDirectoryDirSync["MaxRetryAttempts"] = SourceExpressionConverter.ConvertToken(activeDirectoryDirSyncmaxRetryAttempts);
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
                        activeDirectoryDirSync["SecondsBetweenRetries"] = SourceExpressionConverter.ConvertToken(activeDirectoryDirSyncsecondsBetweenRetries);
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
                activeDirectoryDirSync["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryDirSyncworkflow);
                if (activeDirectoryDirSyncpropCount > 0)
                {
                    callPayload.Body = activeDirectoryDirSync;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryDirSyncResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse> ActiveDirectoryRemoveADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserByIdentity = new JObject();
                var activeDirectoryRemoveADUserByIdentitypropCount = 0;
                activeDirectoryRemoveADUserByIdentitypropCount++;
                activeDirectoryRemoveADUserByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityuserIdentity);
                if (activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                {
                    if (activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                    {
                        activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion);
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
                        activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects);
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
                        activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive);
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
                    activeDirectoryRemoveADUserByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityaDServer);
                    activeDirectoryRemoveADUserByIdentitypropCount++;
                }

                activeDirectoryRemoveADUserByIdentitypropCount++;
                activeDirectoryRemoveADUserByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityworkflow);
                if (activeDirectoryRemoveADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse> ActiveDirectoryResetADUserPasswordByIdentity([WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentitynewPassword, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = null, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryResetADUserPasswordByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryResetADUserPasswordByIdentity = new JObject();
                var activeDirectoryResetADUserPasswordByIdentitypropCount = 0;
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityuserIdentity);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["NewPassword"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitynewPassword);
                if (activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                {
                    if (activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                    {
                        activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword);
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
                        activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties);
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
                        activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon);
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
                        activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword);
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
                        activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires);
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
                        activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice);
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
                    activeDirectoryResetADUserPasswordByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityaDServer);
                    activeDirectoryResetADUserPasswordByIdentitypropCount++;
                }

                activeDirectoryResetADUserPasswordByIdentitypropCount++;
                activeDirectoryResetADUserPasswordByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityworkflow);
                if (activeDirectoryResetADUserPasswordByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryResetADUserPasswordByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity([WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, [WorkflowExpression] Func<bool> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, [WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity = new JObject();
                var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount = 0;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity);
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ProtectedFromAccidentalDeletion"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion);
                if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer != null)
                {
                    activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer);
                    activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                }

                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow);
                if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse> ActiveDirectoryDisableADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDisableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDisableADUserByIdentity = new JObject();
                var activeDirectoryDisableADUserByIdentitypropCount = 0;
                activeDirectoryDisableADUserByIdentitypropCount++;
                activeDirectoryDisableADUserByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryDisableADUserByIdentityuserIdentity);
                if (activeDirectoryDisableADUserByIdentityaDServer != null)
                {
                    activeDirectoryDisableADUserByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryDisableADUserByIdentityaDServer);
                    activeDirectoryDisableADUserByIdentitypropCount++;
                }

                activeDirectoryDisableADUserByIdentitypropCount++;
                activeDirectoryDisableADUserByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryDisableADUserByIdentityworkflow);
                if (activeDirectoryDisableADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryDisableADUserByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryDisableADUserByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse> ActiveDirectoryEnableADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryEnableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryEnableADUserByIdentity = new JObject();
                var activeDirectoryEnableADUserByIdentitypropCount = 0;
                activeDirectoryEnableADUserByIdentitypropCount++;
                activeDirectoryEnableADUserByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryEnableADUserByIdentityuserIdentity);
                if (activeDirectoryEnableADUserByIdentityaDServer != null)
                {
                    activeDirectoryEnableADUserByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryEnableADUserByIdentityaDServer);
                    activeDirectoryEnableADUserByIdentitypropCount++;
                }

                activeDirectoryEnableADUserByIdentitypropCount++;
                activeDirectoryEnableADUserByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryEnableADUserByIdentityworkflow);
                if (activeDirectoryEnableADUserByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryEnableADUserByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryEnableADUserByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse> ActiveDirectorySetADUserHomeFolderByIdentity([WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityhomeDrive = null, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = null, [WorkflowExpression] Func<bool> activeDirectorySetADUserHomeFolderByIdentitycreateFolder = null, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserHomeFolderByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserHomeFolderByIdentity = new JObject();
                var activeDirectorySetADUserHomeFolderByIdentitypropCount = 0;
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                activeDirectorySetADUserHomeFolderByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityuserIdentity);
                if (activeDirectorySetADUserHomeFolderByIdentityhomeDrive != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["HomeDrive"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityhomeDrive);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (activeDirectorySetADUserHomeFolderByIdentityhomeDirectory != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["HomeDirectory"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                if (activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                {
                    if (activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                    {
                        activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentitycreateFolder);
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
                    activeDirectorySetADUserHomeFolderByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityaDServer);
                    activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                }

                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
                activeDirectorySetADUserHomeFolderByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityworkflow);
                if (activeDirectorySetADUserHomeFolderByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserHomeFolderByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse> ActiveDirectoryCloneADUserGroups([WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupssourceUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsdestinationUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsworkflow, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCloneADUserGroups = new JObject();
                var activeDirectoryCloneADUserGroupspropCount = 0;
                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["SourceUserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupssourceUserIdentity);
                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["DestinationUserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupsdestinationUserIdentity);
                if (activeDirectoryCloneADUserGroupsaDServer != null)
                {
                    activeDirectoryCloneADUserGroups["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupsaDServer);
                    activeDirectoryCloneADUserGroupspropCount++;
                }

                activeDirectoryCloneADUserGroupspropCount++;
                activeDirectoryCloneADUserGroups["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupsworkflow);
                if (activeDirectoryCloneADUserGroupspropCount > 0)
                {
                    callPayload.Body = activeDirectoryCloneADUserGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryCloneADUserGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse> ActiveDirectoryCloneADUserProperties([WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiessourceUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesdestinationUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiespropertiesToClone, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesworkflow, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCloneADUserProperties = new JObject();
                var activeDirectoryCloneADUserPropertiespropCount = 0;
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["SourceUserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiessourceUserIdentity);
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["DestinationUserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiesdestinationUserIdentity);
                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["PropertiesToClone"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiespropertiesToClone);
                if (activeDirectoryCloneADUserPropertiesaDServer != null)
                {
                    activeDirectoryCloneADUserProperties["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiesaDServer);
                    activeDirectoryCloneADUserPropertiespropCount++;
                }

                activeDirectoryCloneADUserPropertiespropCount++;
                activeDirectoryCloneADUserProperties["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiesworkflow);
                if (activeDirectoryCloneADUserPropertiespropCount > 0)
                {
                    callPayload.Body = activeDirectoryCloneADUserProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryCloneADUserPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName([WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserFromMultipleADGroupsByName = new JObject();
                var activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount = 0;
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity);
                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["GroupNamesJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                    {
                        activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove);
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
                        activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove);
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
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["MaxGroupsPerCall"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall);
                    activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                }

                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow);
                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserFromMultipleADGroupsByName;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse> ActiveDirectoryRemoveADUserFromAllGroups([WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsuserIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsaDServer = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromAllGroupsrunAsThread = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADUserFromAllGroups = new JObject();
                var activeDirectoryRemoveADUserFromAllGroupspropCount = 0;
                if (activeDirectoryRemoveADUserFromAllGroupsuserIdentity != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsuserIdentity);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["GroupsToExcludeJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                {
                    if (activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist);
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
                    activeDirectoryRemoveADUserFromAllGroups["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsaDServer);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                {
                    if (activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsrunAsThread);
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
                    activeDirectoryRemoveADUserFromAllGroups["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId);
                    activeDirectoryRemoveADUserFromAllGroupspropCount++;
                }

                if (activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                {
                    if (activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                    {
                        activeDirectoryRemoveADUserFromAllGroups["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread);
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
                activeDirectoryRemoveADUserFromAllGroups["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsworkflow);
                if (activeDirectoryRemoveADUserFromAllGroupspropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADUserFromAllGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse> ActiveDirectoryCheckOUExists([WorkflowExpression] Func<string> activeDirectoryCheckOUExistsoUIdentity, [WorkflowExpression] Func<string> activeDirectoryCheckOUExistsworkflow, [WorkflowExpression] Func<string> activeDirectoryCheckOUExistsaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCheckOUExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryCheckOUExists = new JObject();
                var activeDirectoryCheckOUExistspropCount = 0;
                activeDirectoryCheckOUExistspropCount++;
                activeDirectoryCheckOUExists["OUIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryCheckOUExistsoUIdentity);
                if (activeDirectoryCheckOUExistsaDServer != null)
                {
                    activeDirectoryCheckOUExists["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryCheckOUExistsaDServer);
                    activeDirectoryCheckOUExistspropCount++;
                }

                activeDirectoryCheckOUExistspropCount++;
                activeDirectoryCheckOUExists["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryCheckOUExistsworkflow);
                if (activeDirectoryCheckOUExistspropCount > 0)
                {
                    callPayload.Body = activeDirectoryCheckOUExists;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryCheckOUExistsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse> ActiveDirectoryRemoveADGroupMemberByGroupIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroupMemberByGroupIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADGroupMemberByGroupIdentity = new JObject();
                var activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount = 0;
                if (activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                if (activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupName"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                activeDirectoryRemoveADGroupMemberByGroupIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity);
                if (activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer != null)
                {
                    activeDirectoryRemoveADGroupMemberByGroupIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer);
                    activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                }

                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
                activeDirectoryRemoveADGroupMemberByGroupIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow);
                if (activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADGroupMemberByGroupIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = null, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveMultipleADGroupMembersByIdentity = new JObject();
                var activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount = 0;
                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupMembersJSON"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                {
                    if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                    {
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove);
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
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove);
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
                        activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall);
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
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer);
                    activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                }

                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow);
                if (activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveMultipleADGroupMembersByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse> ActiveDirectoryUnlockADAccountByIdentity([WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryUnlockADAccountByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryUnlockADAccountByIdentity = new JObject();
                var activeDirectoryUnlockADAccountByIdentitypropCount = 0;
                activeDirectoryUnlockADAccountByIdentitypropCount++;
                activeDirectoryUnlockADAccountByIdentity["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryUnlockADAccountByIdentityuserIdentity);
                if (activeDirectoryUnlockADAccountByIdentityaDServer != null)
                {
                    activeDirectoryUnlockADAccountByIdentity["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryUnlockADAccountByIdentityaDServer);
                    activeDirectoryUnlockADAccountByIdentitypropCount++;
                }

                activeDirectoryUnlockADAccountByIdentitypropCount++;
                activeDirectoryUnlockADAccountByIdentity["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryUnlockADAccountByIdentityworkflow);
                if (activeDirectoryUnlockADAccountByIdentitypropCount > 0)
                {
                    callPayload.Body = activeDirectoryUnlockADAccountByIdentity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse> ActiveDirectorySetADServer([WorkflowExpression] Func<string> activeDirectorySetADServerworkflow, [WorkflowExpression] Func<activeDirectorySetADServerpredefinedADServerChoiceInput> activeDirectorySetADServerpredefinedADServerChoice = null, [WorkflowExpression] Func<string> activeDirectorySetADServeraDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        activeDirectorySetADServer["PredefinedADServerChoice"] = SourceExpressionConverter.Convert(activeDirectorySetADServerpredefinedADServerChoice);
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
                    activeDirectorySetADServer["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADServeraDServer);
                    activeDirectorySetADServerpropCount++;
                }

                activeDirectorySetADServerpropCount++;
                activeDirectorySetADServer["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADServerworkflow);
                if (activeDirectorySetADServerpropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADServer;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectorySetADServerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse> ActiveDirectoryGetDomainInfo([WorkflowExpression] Func<string> activeDirectoryGetDomainInfoworkflow, [WorkflowExpression] Func<string> activeDirectoryGetDomainInfoaDServer = null, [WorkflowExpression] Func<activeDirectoryGetDomainInfopredefinedIdentityInput> activeDirectoryGetDomainInfopredefinedIdentity = null, [WorkflowExpression] Func<string> activeDirectoryGetDomainInfoidentity = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetDomainInfo = new JObject();
                var activeDirectoryGetDomainInfopropCount = 0;
                if (activeDirectoryGetDomainInfoaDServer != null)
                {
                    activeDirectoryGetDomainInfo["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetDomainInfoaDServer);
                    activeDirectoryGetDomainInfopropCount++;
                }

                if (activeDirectoryGetDomainInfopredefinedIdentity != null)
                {
                    if (activeDirectoryGetDomainInfopredefinedIdentity != null)
                    {
                        activeDirectoryGetDomainInfo["PredefinedIdentity"] = SourceExpressionConverter.Convert(activeDirectoryGetDomainInfopredefinedIdentity);
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
                    activeDirectoryGetDomainInfo["Identity"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetDomainInfoidentity);
                    activeDirectoryGetDomainInfopropCount++;
                }

                activeDirectoryGetDomainInfopropCount++;
                activeDirectoryGetDomainInfo["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetDomainInfoworkflow);
                if (activeDirectoryGetDomainInfopropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetDomainInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetDomainInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse> ActiveDirectoryAddADGroup([WorkflowExpression] Func<string> activeDirectoryAddADGroupname, [WorkflowExpression] Func<activeDirectoryAddADGroupgroupCategoryInput> activeDirectoryAddADGroupgroupCategory, [WorkflowExpression] Func<activeDirectoryAddADGroupgroupScopeInput> activeDirectoryAddADGroupgroupScope, [WorkflowExpression] Func<string> activeDirectoryAddADGroupworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADGroupsamAccountName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGrouppath = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupnotes = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGrouphomePage = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupmanagedBy = null, [WorkflowExpression] Func<bool> activeDirectoryAddADGroupprotectedFromAccidentalDeletion = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddADGroup = new JObject();
                var activeDirectoryAddADGrouppropCount = 0;
                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["Name"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupname);
                if (activeDirectoryAddADGroupsamAccountName != null)
                {
                    activeDirectoryAddADGroup["SamAccountName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupsamAccountName);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGrouppath != null)
                {
                    activeDirectoryAddADGroup["Path"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGrouppath);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupdescription != null)
                {
                    activeDirectoryAddADGroup["Description"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupdescription);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupnotes != null)
                {
                    activeDirectoryAddADGroup["Notes"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupnotes);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupdisplayName != null)
                {
                    activeDirectoryAddADGroup["DisplayName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupdisplayName);
                    activeDirectoryAddADGrouppropCount++;
                }

                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["GroupCategory"] = SourceExpressionConverter.Convert(activeDirectoryAddADGroupgroupCategory);
                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["GroupScope"] = SourceExpressionConverter.Convert(activeDirectoryAddADGroupgroupScope);
                if (activeDirectoryAddADGrouphomePage != null)
                {
                    activeDirectoryAddADGroup["HomePage"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGrouphomePage);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupmanagedBy != null)
                {
                    activeDirectoryAddADGroup["ManagedBy"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupmanagedBy);
                    activeDirectoryAddADGrouppropCount++;
                }

                if (activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                {
                    if (activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                    {
                        activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupprotectedFromAccidentalDeletion);
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
                    activeDirectoryAddADGroup["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupaDServer);
                    activeDirectoryAddADGrouppropCount++;
                }

                activeDirectoryAddADGrouppropCount++;
                activeDirectoryAddADGroup["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddADGroupworkflow);
                if (activeDirectoryAddADGrouppropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddADGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse> ActiveDirectoryDoesADGroupExist([WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistworkflow, [WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDoesADGroupExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryDoesADGroupExist = new JObject();
                var activeDirectoryDoesADGroupExistpropCount = 0;
                activeDirectoryDoesADGroupExistpropCount++;
                activeDirectoryDoesADGroupExist["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryDoesADGroupExistgroupIdentity);
                if (activeDirectoryDoesADGroupExistaDServer != null)
                {
                    activeDirectoryDoesADGroupExist["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryDoesADGroupExistaDServer);
                    activeDirectoryDoesADGroupExistpropCount++;
                }

                activeDirectoryDoesADGroupExistpropCount++;
                activeDirectoryDoesADGroupExist["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryDoesADGroupExistworkflow);
                if (activeDirectoryDoesADGroupExistpropCount > 0)
                {
                    callPayload.Body = activeDirectoryDoesADGroupExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryDoesADGroupExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse> ActiveDirectoryRemoveADGroup([WorkflowExpression] Func<string> activeDirectoryRemoveADGroupgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveADGroupdeleteEvenIfProtected = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveADGroup = new JObject();
                var activeDirectoryRemoveADGrouppropCount = 0;
                activeDirectoryRemoveADGrouppropCount++;
                activeDirectoryRemoveADGroup["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupgroupIdentity);
                if (activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                {
                    if (activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                    {
                        activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupdeleteEvenIfProtected);
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
                        activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist);
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
                    activeDirectoryRemoveADGroup["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupaDServer);
                    activeDirectoryRemoveADGrouppropCount++;
                }

                activeDirectoryRemoveADGrouppropCount++;
                activeDirectoryRemoveADGroup["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupworkflow);
                if (activeDirectoryRemoveADGrouppropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveADGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse> ActiveDirectoryAddOU([WorkflowExpression] Func<string> activeDirectoryAddOUname, [WorkflowExpression] Func<string> activeDirectoryAddOUworkflow, [WorkflowExpression] Func<string> activeDirectoryAddOUpath = null, [WorkflowExpression] Func<string> activeDirectoryAddOUdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddOUdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddOUmanagedBy = null, [WorkflowExpression] Func<bool> activeDirectoryAddOUprotectedFromAccidentalDeletion = null, [WorkflowExpression] Func<string> activeDirectoryAddOUstreetAddress = null, [WorkflowExpression] Func<string> activeDirectoryAddOUcity = null, [WorkflowExpression] Func<string> activeDirectoryAddOUstate = null, [WorkflowExpression] Func<string> activeDirectoryAddOUpostalCode = null, [WorkflowExpression] Func<string> activeDirectoryAddOUaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryAddOU = new JObject();
                var activeDirectoryAddOUpropCount = 0;
                activeDirectoryAddOUpropCount++;
                activeDirectoryAddOU["Name"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUname);
                if (activeDirectoryAddOUpath != null)
                {
                    activeDirectoryAddOU["Path"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUpath);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUdescription != null)
                {
                    activeDirectoryAddOU["Description"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUdescription);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUdisplayName != null)
                {
                    activeDirectoryAddOU["DisplayName"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUdisplayName);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUmanagedBy != null)
                {
                    activeDirectoryAddOU["ManagedBy"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUmanagedBy);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                {
                    if (activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                    {
                        activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUprotectedFromAccidentalDeletion);
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
                    activeDirectoryAddOU["StreetAddress"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUstreetAddress);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUcity != null)
                {
                    activeDirectoryAddOU["City"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUcity);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUstate != null)
                {
                    activeDirectoryAddOU["State"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUstate);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUpostalCode != null)
                {
                    activeDirectoryAddOU["PostalCode"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUpostalCode);
                    activeDirectoryAddOUpropCount++;
                }

                if (activeDirectoryAddOUaDServer != null)
                {
                    activeDirectoryAddOU["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUaDServer);
                    activeDirectoryAddOUpropCount++;
                }

                activeDirectoryAddOUpropCount++;
                activeDirectoryAddOU["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryAddOUworkflow);
                if (activeDirectoryAddOUpropCount > 0)
                {
                    callPayload.Body = activeDirectoryAddOU;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryAddOUResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse> ActiveDirectoryRemoveOU([WorkflowExpression] Func<string> activeDirectoryRemoveOUoUIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveOUworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveOUdeleteEvenIfProtected = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveOUaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryRemoveOU = new JObject();
                var activeDirectoryRemoveOUpropCount = 0;
                activeDirectoryRemoveOUpropCount++;
                activeDirectoryRemoveOU["OUIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveOUoUIdentity);
                if (activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                {
                    if (activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                    {
                        activeDirectoryRemoveOU["DeleteEvenIfProtected"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveOUdeleteEvenIfProtected);
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
                        activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist);
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
                    activeDirectoryRemoveOU["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveOUaDServer);
                    activeDirectoryRemoveOUpropCount++;
                }

                activeDirectoryRemoveOUpropCount++;
                activeDirectoryRemoveOU["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryRemoveOUworkflow);
                if (activeDirectoryRemoveOUpropCount > 0)
                {
                    callPayload.Body = activeDirectoryRemoveOU;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveOUResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse> ActiveDirectorySetADUserAccountExpirationEndOfDate([WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDateyear, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDatemonth, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDateday, [WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserAccountExpirationEndOfDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectorySetADUserAccountExpirationEndOfDate = new JObject();
                var activeDirectorySetADUserAccountExpirationEndOfDatepropCount = 0;
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["UserIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Year"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateyear);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Month"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDatemonth);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Day"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateday);
                if (activeDirectorySetADUserAccountExpirationEndOfDateaDServer != null)
                {
                    activeDirectorySetADUserAccountExpirationEndOfDate["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateaDServer);
                    activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                }

                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
                activeDirectorySetADUserAccountExpirationEndOfDate["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateworkflow);
                if (activeDirectorySetADUserAccountExpirationEndOfDatepropCount > 0)
                {
                    callPayload.Body = activeDirectorySetADUserAccountExpirationEndOfDate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse> ActiveDirectoryGetADGroupMembers([WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersworkflow, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupMembersrecursive = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersaDServer = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activeDirectoryGetADGroupMembers = new JObject();
                var activeDirectoryGetADGroupMemberspropCount = 0;
                activeDirectoryGetADGroupMemberspropCount++;
                activeDirectoryGetADGroupMembers["GroupIdentity"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersgroupIdentity);
                if (activeDirectoryGetADGroupMembersrecursive != null)
                {
                    if (activeDirectoryGetADGroupMembersrecursive != null)
                    {
                        activeDirectoryGetADGroupMembers["Recursive"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersrecursive);
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
                    activeDirectoryGetADGroupMembers["ADServer"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersaDServer);
                    activeDirectoryGetADGroupMemberspropCount++;
                }

                activeDirectoryGetADGroupMemberspropCount++;
                activeDirectoryGetADGroupMembers["Workflow"] = SourceExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersworkflow);
                if (activeDirectoryGetADGroupMemberspropCount > 0)
                {
                    callPayload.Body = activeDirectoryGetADGroupMembers;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse> OpenExchangePowerShellRunspace([WorkflowExpression] Func<string> openExchangePowerShellRunspaceexchangeServerFQDN, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceusername = null, [WorkflowExpression] Func<string> openExchangePowerShellRunspacepassword = null, [WorkflowExpression] Func<bool> openExchangePowerShellRunspaceuseSSL = null, [WorkflowExpression] Func<openExchangePowerShellRunspaceconnectionMethodInput> openExchangePowerShellRunspaceconnectionMethod = null, [WorkflowExpression] Func<openExchangePowerShellRunspaceauthenticationMechanismInput> openExchangePowerShellRunspaceauthenticationMechanism = null, [WorkflowExpression] Func<bool> openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openExchangePowerShellRunspacecommandTypesToImportLocallyInput> openExchangePowerShellRunspacecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/OpenExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openExchangePowerShellRunspace = new JObject();
                var openExchangePowerShellRunspacepropCount = 0;
                if (openExchangePowerShellRunspaceusername != null)
                {
                    openExchangePowerShellRunspace["Username"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspaceusername);
                    openExchangePowerShellRunspacepropCount++;
                }

                if (openExchangePowerShellRunspacepassword != null)
                {
                    openExchangePowerShellRunspace["Password"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspacepassword);
                    openExchangePowerShellRunspacepropCount++;
                }

                openExchangePowerShellRunspacepropCount++;
                openExchangePowerShellRunspace["ExchangeServerFQDN"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspaceexchangeServerFQDN);
                if (openExchangePowerShellRunspaceuseSSL != null)
                {
                    if (openExchangePowerShellRunspaceuseSSL != null)
                    {
                        openExchangePowerShellRunspace["UseSSL"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspaceuseSSL);
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
                        openExchangePowerShellRunspace["ConnectionMethod"] = SourceExpressionConverter.Convert(openExchangePowerShellRunspaceconnectionMethod);
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
                        openExchangePowerShellRunspace["AuthenticationMechanism"] = SourceExpressionConverter.Convert(openExchangePowerShellRunspaceauthenticationMechanism);
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
                        openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected);
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
                        openExchangePowerShellRunspace["CommandTypesToImportLocally"] = SourceExpressionConverter.Convert(openExchangePowerShellRunspacecommandTypesToImportLocally);
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
                    openExchangePowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                    openExchangePowerShellRunspacepropCount++;
                }

                openExchangePowerShellRunspacepropCount++;
                openExchangePowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(openExchangePowerShellRunspaceworkflow);
                if (openExchangePowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openExchangePowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenExchangePowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse> IsExchangePowerShellRunspaceOpen([WorkflowExpression] Func<string> isExchangePowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isExchangePowerShellRunspaceOpentestCommunications = null, [WorkflowExpression] Func<bool> isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        isExchangePowerShellRunspaceOpen["TestCommunications"] = SourceExpressionConverter.ConvertToken(isExchangePowerShellRunspaceOpentestCommunications);
                        isExchangePowerShellRunspaceOpenpropCount++;
                    }

                    isExchangePowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isExchangePowerShellRunspaceOpen["TestCommunications"] = true;
                    isExchangePowerShellRunspaceOpenpropCount++;
                }

                if (isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePId != null)
                {
                    if (isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePId != null)
                    {
                        isExchangePowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = SourceExpressionConverter.ConvertToken(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePId);
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
                isExchangePowerShellRunspaceOpen["Workflow"] = SourceExpressionConverter.ConvertToken(isExchangePowerShellRunspaceOpenworkflow);
                if (isExchangePowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isExchangePowerShellRunspaceOpen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsExchangePowerShellRunspaceOpenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse> RunExchangePowerShellAutomationScript([WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runExchangePowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runExchangePowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/RunExchangePowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runExchangePowerShellAutomationScript = new JObject();
                var runExchangePowerShellAutomationScriptpropCount = 0;
                if (runExchangePowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runExchangePowerShellAutomationScript["PowerShellScriptContents"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpowerShellScriptContents);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runExchangePowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runExchangePowerShellAutomationScript["IsNoResultAnError"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptisNoResultAnError);
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
                        runExchangePowerShellAutomationScript["ReturnComplexTypes"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnComplexTypes);
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
                        runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean);
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
                        runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnNumericAsDecimal);
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
                        runExchangePowerShellAutomationScript["ReturnDateAsDate"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnDateAsDate);
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
                    runExchangePowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runExchangePowerShellAutomationScript["RunScriptAsThread"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptrunScriptAsThread);
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
                    runExchangePowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptsecondsToWaitForThread);
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
                        runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptscriptContainsStoredPassword);
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
                        runExchangePowerShellAutomationScript["LogVerboseOutput"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptlogVerboseOutput);
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
                    runExchangePowerShellAutomationScript["PropertyNamesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runExchangePowerShellAutomationScript["PropertyTypesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                if (runExchangePowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runExchangePowerShellAutomationScript["PowerShellCommandParameters"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpowerShellCommandParameters);
                    runExchangePowerShellAutomationScriptpropCount++;
                }

                runExchangePowerShellAutomationScriptpropCount++;
                runExchangePowerShellAutomationScript["Workflow"] = SourceExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptworkflow);
                if (runExchangePowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runExchangePowerShellAutomationScript;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunExchangePowerShellAutomationScriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse> CloseExchangePowerShellRunspace([WorkflowExpression] Func<string> closeExchangePowerShellRunspaceworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/CloseExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeExchangePowerShellRunspace = new JObject();
                var closeExchangePowerShellRunspacepropCount = 0;
                closeExchangePowerShellRunspacepropCount++;
                closeExchangePowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(closeExchangePowerShellRunspaceworkflow);
                if (closeExchangePowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeExchangePowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseExchangePowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse> ExchangeGetMailbox([WorkflowExpression] Func<string> exchangeGetMailboxworkflow, [WorkflowExpression] Func<string> exchangeGetMailboxidentity = null, [WorkflowExpression] Func<string> exchangeGetMailboxfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetMailboxfilterPropertyComparisonInput> exchangeGetMailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetMailboxfilterPropertyValue = null, [WorkflowExpression] Func<exchangeGetMailboxrecipientTypeDetailsInput> exchangeGetMailboxrecipientTypeDetails = null, [WorkflowExpression] Func<bool> exchangeGetMailboxnoResultIsAnException = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailbox = new JObject();
                var exchangeGetMailboxpropCount = 0;
                if (exchangeGetMailboxidentity != null)
                {
                    exchangeGetMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxidentity);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxfilterPropertyName != null)
                {
                    exchangeGetMailbox["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxfilterPropertyName);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxfilterPropertyComparison != null)
                {
                    if (exchangeGetMailboxfilterPropertyComparison != null)
                    {
                        exchangeGetMailbox["FilterPropertyComparison"] = SourceExpressionConverter.Convert(exchangeGetMailboxfilterPropertyComparison);
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
                    exchangeGetMailbox["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxfilterPropertyValue);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxrecipientTypeDetails != null)
                {
                    exchangeGetMailbox["RecipientTypeDetails"] = SourceExpressionConverter.Convert(exchangeGetMailboxrecipientTypeDetails);
                    exchangeGetMailboxpropCount++;
                }

                if (exchangeGetMailboxnoResultIsAnException != null)
                {
                    if (exchangeGetMailboxnoResultIsAnException != null)
                    {
                        exchangeGetMailbox["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxnoResultIsAnException);
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
                exchangeGetMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxworkflow);
                if (exchangeGetMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeGetMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse> ExchangeDoesMailboxExist([WorkflowExpression] Func<string> exchangeDoesMailboxExistworkflow, [WorkflowExpression] Func<string> exchangeDoesMailboxExistidentity = null, [WorkflowExpression] Func<string> exchangeDoesMailboxExistfilterPropertyName = null, [WorkflowExpression] Func<exchangeDoesMailboxExistfilterPropertyComparisonInput> exchangeDoesMailboxExistfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeDoesMailboxExistfilterPropertyValue = null, [WorkflowExpression] Func<exchangeDoesMailboxExistrecipientTypeDetailsInput> exchangeDoesMailboxExistrecipientTypeDetails = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDoesMailboxExist = new JObject();
                var exchangeDoesMailboxExistpropCount = 0;
                if (exchangeDoesMailboxExistidentity != null)
                {
                    exchangeDoesMailboxExist["Identity"] = SourceExpressionConverter.ConvertToken(exchangeDoesMailboxExistidentity);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistfilterPropertyName != null)
                {
                    exchangeDoesMailboxExist["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(exchangeDoesMailboxExistfilterPropertyName);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistfilterPropertyComparison != null)
                {
                    if (exchangeDoesMailboxExistfilterPropertyComparison != null)
                    {
                        exchangeDoesMailboxExist["FilterPropertyComparison"] = SourceExpressionConverter.Convert(exchangeDoesMailboxExistfilterPropertyComparison);
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
                    exchangeDoesMailboxExist["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(exchangeDoesMailboxExistfilterPropertyValue);
                    exchangeDoesMailboxExistpropCount++;
                }

                if (exchangeDoesMailboxExistrecipientTypeDetails != null)
                {
                    exchangeDoesMailboxExist["RecipientTypeDetails"] = SourceExpressionConverter.Convert(exchangeDoesMailboxExistrecipientTypeDetails);
                    exchangeDoesMailboxExistpropCount++;
                }

                exchangeDoesMailboxExistpropCount++;
                exchangeDoesMailboxExist["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeDoesMailboxExistworkflow);
                if (exchangeDoesMailboxExistpropCount > 0)
                {
                    callPayload.Body = exchangeDoesMailboxExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeDoesMailboxExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse> ExchangeAddDistributionGroupMember([WorkflowExpression] Func<string> exchangeAddDistributionGroupMemberidentity, [WorkflowExpression] Func<string> exchangeAddDistributionGroupMembermember, [WorkflowExpression] Func<string> exchangeAddDistributionGroupMemberworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddDistributionGroupMember = new JObject();
                var exchangeAddDistributionGroupMemberpropCount = 0;
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Identity"] = SourceExpressionConverter.ConvertToken(exchangeAddDistributionGroupMemberidentity);
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Member"] = SourceExpressionConverter.ConvertToken(exchangeAddDistributionGroupMembermember);
                exchangeAddDistributionGroupMemberpropCount++;
                exchangeAddDistributionGroupMember["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeAddDistributionGroupMemberworkflow);
                if (exchangeAddDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = exchangeAddDistributionGroupMember;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeAddDistributionGroupMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse> ExchangeRemoveDistributionGroupMember([WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMemberidentity, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMembermember, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveDistributionGroupMember = new JObject();
                var exchangeRemoveDistributionGroupMemberpropCount = 0;
                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Identity"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMemberidentity);
                exchangeRemoveDistributionGroupMemberpropCount++;
                exchangeRemoveDistributionGroupMember["Member"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMembermember);
                if (exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        exchangeRemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
                exchangeRemoveDistributionGroupMember["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMemberworkflow);
                if (exchangeRemoveDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = exchangeRemoveDistributionGroupMember;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeRemoveDistributionGroupMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse> ExchangeGetDistributionGroup([WorkflowExpression] Func<string> exchangeGetDistributionGroupworkflow, [WorkflowExpression] Func<string> exchangeGetDistributionGroupidentity = null, [WorkflowExpression] Func<string> exchangeGetDistributionGroupfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetDistributionGroupfilterPropertyComparisonInput> exchangeGetDistributionGroupfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetDistributionGroupfilterPropertyValue = null, [WorkflowExpression] Func<bool> exchangeGetDistributionGroupnoResultIsAnException = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetDistributionGroup = new JObject();
                var exchangeGetDistributionGrouppropCount = 0;
                if (exchangeGetDistributionGroupidentity != null)
                {
                    exchangeGetDistributionGroup["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupidentity);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupfilterPropertyName != null)
                {
                    exchangeGetDistributionGroup["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupfilterPropertyName);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupfilterPropertyComparison != null)
                {
                    if (exchangeGetDistributionGroupfilterPropertyComparison != null)
                    {
                        exchangeGetDistributionGroup["FilterPropertyComparison"] = SourceExpressionConverter.Convert(exchangeGetDistributionGroupfilterPropertyComparison);
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
                    exchangeGetDistributionGroup["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupfilterPropertyValue);
                    exchangeGetDistributionGrouppropCount++;
                }

                if (exchangeGetDistributionGroupnoResultIsAnException != null)
                {
                    if (exchangeGetDistributionGroupnoResultIsAnException != null)
                    {
                        exchangeGetDistributionGroup["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupnoResultIsAnException);
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
                exchangeGetDistributionGroup["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupworkflow);
                if (exchangeGetDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeGetDistributionGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetDistributionGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse> ExchangeGetDistributionGroupMembers([WorkflowExpression] Func<string> exchangeGetDistributionGroupMembersidentity, [WorkflowExpression] Func<string> exchangeGetDistributionGroupMembersworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetDistributionGroupMembers = new JObject();
                var exchangeGetDistributionGroupMemberspropCount = 0;
                exchangeGetDistributionGroupMemberspropCount++;
                exchangeGetDistributionGroupMembers["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupMembersidentity);
                exchangeGetDistributionGroupMemberspropCount++;
                exchangeGetDistributionGroupMembers["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetDistributionGroupMembersworkflow);
                if (exchangeGetDistributionGroupMemberspropCount > 0)
                {
                    callPayload.Body = exchangeGetDistributionGroupMembers;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetDistributionGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse> ExchangeGetMailboxDistributionGroupMembership([WorkflowExpression] Func<string> exchangeGetMailboxDistributionGroupMembershipidentity, [WorkflowExpression] Func<string> exchangeGetMailboxDistributionGroupMembershipworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailboxDistributionGroupMembership = new JObject();
                var exchangeGetMailboxDistributionGroupMembershippropCount = 0;
                exchangeGetMailboxDistributionGroupMembershippropCount++;
                exchangeGetMailboxDistributionGroupMembership["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxDistributionGroupMembershipidentity);
                exchangeGetMailboxDistributionGroupMembershippropCount++;
                exchangeGetMailboxDistributionGroupMembership["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxDistributionGroupMembershipworkflow);
                if (exchangeGetMailboxDistributionGroupMembershippropCount > 0)
                {
                    callPayload.Body = exchangeGetMailboxDistributionGroupMembership;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse> ExchangeNewDistributionGroup([WorkflowExpression] Func<string> exchangeNewDistributionGroupname, [WorkflowExpression] Func<string> exchangeNewDistributionGroupworkflow, [WorkflowExpression] Func<string> exchangeNewDistributionGroupalias = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupdisplayName = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupnotes = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupmanagedBy = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupmembers = null, [WorkflowExpression] Func<string> exchangeNewDistributionGrouporganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupprimarySmtpAddress = null, [WorkflowExpression] Func<exchangeNewDistributionGroupmemberDepartRestrictionInput> exchangeNewDistributionGroupmemberDepartRestriction = null, [WorkflowExpression] Func<exchangeNewDistributionGroupmemberJoinRestrictionInput> exchangeNewDistributionGroupmemberJoinRestriction = null, [WorkflowExpression] Func<bool> exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = null, [WorkflowExpression] Func<exchangeNewDistributionGrouptypeInput> exchangeNewDistributionGrouptype = null, [WorkflowExpression] Func<bool> exchangeNewDistributionGrouperrorIfGroupAlreadyExists = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewDistributionGroup = new JObject();
                var exchangeNewDistributionGrouppropCount = 0;
                exchangeNewDistributionGrouppropCount++;
                exchangeNewDistributionGroup["Name"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupname);
                if (exchangeNewDistributionGroupalias != null)
                {
                    exchangeNewDistributionGroup["Alias"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupalias);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupdisplayName != null)
                {
                    exchangeNewDistributionGroup["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupdisplayName);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupnotes != null)
                {
                    exchangeNewDistributionGroup["Notes"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupnotes);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmanagedBy != null)
                {
                    exchangeNewDistributionGroup["ManagedBy"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupmanagedBy);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmembers != null)
                {
                    exchangeNewDistributionGroup["Members"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupmembers);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGrouporganizationalUnit != null)
                {
                    exchangeNewDistributionGroup["OrganizationalUnit"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGrouporganizationalUnit);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupprimarySmtpAddress != null)
                {
                    exchangeNewDistributionGroup["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupprimarySmtpAddress);
                    exchangeNewDistributionGrouppropCount++;
                }

                if (exchangeNewDistributionGroupmemberDepartRestriction != null)
                {
                    if (exchangeNewDistributionGroupmemberDepartRestriction != null)
                    {
                        exchangeNewDistributionGroup["MemberDepartRestriction"] = SourceExpressionConverter.Convert(exchangeNewDistributionGroupmemberDepartRestriction);
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
                        exchangeNewDistributionGroup["MemberJoinRestriction"] = SourceExpressionConverter.Convert(exchangeNewDistributionGroupmemberJoinRestriction);
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
                        exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled);
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
                        exchangeNewDistributionGroup["Type"] = SourceExpressionConverter.Convert(exchangeNewDistributionGrouptype);
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
                        exchangeNewDistributionGroup["ErrorIfGroupAlreadyExists"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGrouperrorIfGroupAlreadyExists);
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
                exchangeNewDistributionGroup["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeNewDistributionGroupworkflow);
                if (exchangeNewDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeNewDistributionGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeNewDistributionGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse> ExchangeRemoveDistributionGroup([WorkflowExpression] Func<string> exchangeRemoveDistributionGroupidentity, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupworkflow, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveDistributionGroup = new JObject();
                var exchangeRemoveDistributionGrouppropCount = 0;
                exchangeRemoveDistributionGrouppropCount++;
                exchangeRemoveDistributionGroup["Identity"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupidentity);
                if (exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    if (exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                    {
                        exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck);
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
                        exchangeRemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist);
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
                exchangeRemoveDistributionGroup["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupworkflow);
                if (exchangeRemoveDistributionGrouppropCount > 0)
                {
                    callPayload.Body = exchangeRemoveDistributionGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeRemoveDistributionGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse> ExchangeAddMailboxPermission([WorkflowExpression] Func<string> exchangeAddMailboxPermissionidentity, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionuser, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionaccessRights, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionworkflow, [WorkflowExpression] Func<bool> exchangeAddMailboxPermissionautoMapping = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddMailboxPermission = new JObject();
                var exchangeAddMailboxPermissionpropCount = 0;
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["Identity"] = SourceExpressionConverter.ConvertToken(exchangeAddMailboxPermissionidentity);
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["User"] = SourceExpressionConverter.ConvertToken(exchangeAddMailboxPermissionuser);
                exchangeAddMailboxPermissionpropCount++;
                exchangeAddMailboxPermission["AccessRights"] = SourceExpressionConverter.ConvertToken(exchangeAddMailboxPermissionaccessRights);
                if (exchangeAddMailboxPermissionautoMapping != null)
                {
                    if (exchangeAddMailboxPermissionautoMapping != null)
                    {
                        exchangeAddMailboxPermission["AutoMapping"] = SourceExpressionConverter.ConvertToken(exchangeAddMailboxPermissionautoMapping);
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
                exchangeAddMailboxPermission["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeAddMailboxPermissionworkflow);
                if (exchangeAddMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeAddMailboxPermission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeAddMailboxPermissionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse> ExchangeRemoveMailboxPermission([WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionidentity, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionuser, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionaccessRights, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeRemoveMailboxPermission = new JObject();
                var exchangeRemoveMailboxPermissionpropCount = 0;
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["Identity"] = SourceExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionidentity);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["User"] = SourceExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionuser);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["AccessRights"] = SourceExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionaccessRights);
                exchangeRemoveMailboxPermissionpropCount++;
                exchangeRemoveMailboxPermission["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionworkflow);
                if (exchangeRemoveMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeRemoveMailboxPermission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeRemoveMailboxPermissionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse> ExchangeDisableMailbox([WorkflowExpression] Func<string> exchangeDisableMailboxidentity, [WorkflowExpression] Func<string> exchangeDisableMailboxworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDisableMailbox = new JObject();
                var exchangeDisableMailboxpropCount = 0;
                exchangeDisableMailboxpropCount++;
                exchangeDisableMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeDisableMailboxidentity);
                exchangeDisableMailboxpropCount++;
                exchangeDisableMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeDisableMailboxworkflow);
                if (exchangeDisableMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeDisableMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeDisableMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse> ExchangeDisableRemoteMailbox([WorkflowExpression] Func<string> exchangeDisableRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeDisableRemoteMailboxworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDisableRemoteMailbox = new JObject();
                var exchangeDisableRemoteMailboxpropCount = 0;
                exchangeDisableRemoteMailboxpropCount++;
                exchangeDisableRemoteMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeDisableRemoteMailboxidentity);
                exchangeDisableRemoteMailboxpropCount++;
                exchangeDisableRemoteMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeDisableRemoteMailboxworkflow);
                if (exchangeDisableRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeDisableRemoteMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeDisableRemoteMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse> ExchangeEnableMailbox([WorkflowExpression] Func<string> exchangeEnableMailboxidentity, [WorkflowExpression] Func<string> exchangeEnableMailboxworkflow, [WorkflowExpression] Func<string> exchangeEnableMailboxalias = null, [WorkflowExpression] Func<string> exchangeEnableMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeEnableMailboxlinkedDomainController = null, [WorkflowExpression] Func<string> exchangeEnableMailboxlinkedMasterAccount = null, [WorkflowExpression] Func<string> exchangeEnableMailboxdatabase = null, [WorkflowExpression] Func<string> exchangeEnableMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeEnableMailboxemailAddressPolicyEnabled = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeEnableMailbox = new JObject();
                var exchangeEnableMailboxpropCount = 0;
                exchangeEnableMailboxpropCount++;
                exchangeEnableMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxidentity);
                if (exchangeEnableMailboxalias != null)
                {
                    exchangeEnableMailbox["Alias"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxalias);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxdisplayName != null)
                {
                    exchangeEnableMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxdisplayName);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxlinkedDomainController != null)
                {
                    exchangeEnableMailbox["LinkedDomainController"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxlinkedDomainController);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxlinkedMasterAccount != null)
                {
                    exchangeEnableMailbox["LinkedMasterAccount"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxlinkedMasterAccount);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxdatabase != null)
                {
                    exchangeEnableMailbox["Database"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxdatabase);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxprimarySmtpAddress != null)
                {
                    exchangeEnableMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxprimarySmtpAddress);
                    exchangeEnableMailboxpropCount++;
                }

                if (exchangeEnableMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeEnableMailbox["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxemailAddressPolicyEnabled);
                    exchangeEnableMailboxpropCount++;
                }

                exchangeEnableMailboxpropCount++;
                exchangeEnableMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeEnableMailboxworkflow);
                if (exchangeEnableMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeEnableMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeEnableMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse> ExchangeEnableRemoteMailbox([WorkflowExpression] Func<string> exchangeEnableRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxremoteRoutingAddress = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeEnableRemoteMailboxarchive = null, [WorkflowExpression] Func<bool> exchangeEnableRemoteMailboxemailAddressPolicyEnabled = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeEnableRemoteMailbox = new JObject();
                var exchangeEnableRemoteMailboxpropCount = 0;
                exchangeEnableRemoteMailboxpropCount++;
                exchangeEnableRemoteMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxidentity);
                if (exchangeEnableRemoteMailboxalias != null)
                {
                    exchangeEnableRemoteMailbox["Alias"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxalias);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxdisplayName != null)
                {
                    exchangeEnableRemoteMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxdisplayName);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxremoteRoutingAddress != null)
                {
                    exchangeEnableRemoteMailbox["RemoteRoutingAddress"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxremoteRoutingAddress);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeEnableRemoteMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxprimarySmtpAddress);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                if (exchangeEnableRemoteMailboxarchive != null)
                {
                    if (exchangeEnableRemoteMailboxarchive != null)
                    {
                        exchangeEnableRemoteMailbox["Archive"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxarchive);
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
                    exchangeEnableRemoteMailbox["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxemailAddressPolicyEnabled);
                    exchangeEnableRemoteMailboxpropCount++;
                }

                exchangeEnableRemoteMailboxpropCount++;
                exchangeEnableRemoteMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxworkflow);
                if (exchangeEnableRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeEnableRemoteMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeEnableRemoteMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse> ExchangeGetRemoteMailbox([WorkflowExpression] Func<string> exchangeGetRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxidentity = null, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetRemoteMailboxfilterPropertyComparisonInput> exchangeGetRemoteMailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxfilterPropertyValue = null, [WorkflowExpression] Func<bool> exchangeGetRemoteMailboxnoResultIsAnException = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetRemoteMailbox = new JObject();
                var exchangeGetRemoteMailboxpropCount = 0;
                if (exchangeGetRemoteMailboxidentity != null)
                {
                    exchangeGetRemoteMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxidentity);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxfilterPropertyName != null)
                {
                    exchangeGetRemoteMailbox["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxfilterPropertyName);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxfilterPropertyComparison != null)
                {
                    if (exchangeGetRemoteMailboxfilterPropertyComparison != null)
                    {
                        exchangeGetRemoteMailbox["FilterPropertyComparison"] = SourceExpressionConverter.Convert(exchangeGetRemoteMailboxfilterPropertyComparison);
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
                    exchangeGetRemoteMailbox["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxfilterPropertyValue);
                    exchangeGetRemoteMailboxpropCount++;
                }

                if (exchangeGetRemoteMailboxnoResultIsAnException != null)
                {
                    if (exchangeGetRemoteMailboxnoResultIsAnException != null)
                    {
                        exchangeGetRemoteMailbox["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxnoResultIsAnException);
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
                exchangeGetRemoteMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxworkflow);
                if (exchangeGetRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeGetRemoteMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetRemoteMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse> ExchangeDoesRemoteMailboxExist([WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistworkflow, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistidentity = null, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistfilterPropertyName = null, [WorkflowExpression] Func<exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput> exchangeDoesRemoteMailboxExistfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistfilterPropertyValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesRemoteMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeDoesRemoteMailboxExist = new JObject();
                var exchangeDoesRemoteMailboxExistpropCount = 0;
                if (exchangeDoesRemoteMailboxExistidentity != null)
                {
                    exchangeDoesRemoteMailboxExist["Identity"] = SourceExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistidentity);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (exchangeDoesRemoteMailboxExistfilterPropertyName != null)
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistfilterPropertyName);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                if (exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                {
                    if (exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                    {
                        exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = SourceExpressionConverter.Convert(exchangeDoesRemoteMailboxExistfilterPropertyComparison);
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
                    exchangeDoesRemoteMailboxExist["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistfilterPropertyValue);
                    exchangeDoesRemoteMailboxExistpropCount++;
                }

                exchangeDoesRemoteMailboxExistpropCount++;
                exchangeDoesRemoteMailboxExist["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistworkflow);
                if (exchangeDoesRemoteMailboxExistpropCount > 0)
                {
                    callPayload.Body = exchangeDoesRemoteMailboxExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeDoesRemoteMailboxExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse> ExchangeNewMailbox([WorkflowExpression] Func<string> exchangeNewMailboxname, [WorkflowExpression] Func<string> exchangeNewMailboxuserPrincipalName, [WorkflowExpression] Func<string> exchangeNewMailboxworkflow, [WorkflowExpression] Func<string> exchangeNewMailboxfirstName = null, [WorkflowExpression] Func<string> exchangeNewMailboxlastName = null, [WorkflowExpression] Func<string> exchangeNewMailboxorganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeNewMailboxalias = null, [WorkflowExpression] Func<string> exchangeNewMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> exchangeNewMailboxsamAccountName = null, [WorkflowExpression] Func<string> exchangeNewMailboxpassword = null, [WorkflowExpression] Func<bool> exchangeNewMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> exchangeNewMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<string> exchangeNewMailboxdatabase = null, [WorkflowExpression] Func<bool> exchangeNewMailboxsharedMailbox = null, [WorkflowExpression] Func<bool> exchangeNewMailboxemailAddressPolicyEnabled = null, [WorkflowExpression] Func<bool> exchangeNewMailboxarchive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewMailbox = new JObject();
                var exchangeNewMailboxpropCount = 0;
                if (exchangeNewMailboxfirstName != null)
                {
                    exchangeNewMailbox["FirstName"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxfirstName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxlastName != null)
                {
                    exchangeNewMailbox["LastName"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxlastName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxorganizationalUnit != null)
                {
                    exchangeNewMailbox["OrganizationalUnit"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxorganizationalUnit);
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["Name"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxname);
                if (exchangeNewMailboxdisplayName != null)
                {
                    exchangeNewMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxdisplayName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxalias != null)
                {
                    exchangeNewMailbox["Alias"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxalias);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxprimarySmtpAddress != null)
                {
                    exchangeNewMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxprimarySmtpAddress);
                    exchangeNewMailboxpropCount++;
                }

                exchangeNewMailboxpropCount++;
                exchangeNewMailbox["UserPrincipalName"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxuserPrincipalName);
                if (exchangeNewMailboxsamAccountName != null)
                {
                    exchangeNewMailbox["SamAccountName"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxsamAccountName);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxpassword != null)
                {
                    exchangeNewMailbox["Password"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxpassword);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                    {
                        exchangeNewMailbox["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxaccountPasswordIsStoredPassword);
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
                        exchangeNewMailbox["ResetPasswordOnNextLogon"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxresetPasswordOnNextLogon);
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
                    exchangeNewMailbox["Database"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxdatabase);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxsharedMailbox != null)
                {
                    if (exchangeNewMailboxsharedMailbox != null)
                    {
                        exchangeNewMailbox["SharedMailbox"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxsharedMailbox);
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
                    exchangeNewMailbox["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxemailAddressPolicyEnabled);
                    exchangeNewMailboxpropCount++;
                }

                if (exchangeNewMailboxarchive != null)
                {
                    if (exchangeNewMailboxarchive != null)
                    {
                        exchangeNewMailbox["Archive"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxarchive);
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
                exchangeNewMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeNewMailboxworkflow);
                if (exchangeNewMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeNewMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeNewMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse> ExchangeNewRemoteMailbox([WorkflowExpression] Func<string> exchangeNewRemoteMailboxname, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxuserPrincipalName, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxfirstName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxlastName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxonPremisesOrganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxremoteRoutingAddress = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxsamAccountName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxpassword = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxsharedMailbox = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxemailAddressPolicyEnabled = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxarchive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeNewRemoteMailbox = new JObject();
                var exchangeNewRemoteMailboxpropCount = 0;
                if (exchangeNewRemoteMailboxfirstName != null)
                {
                    exchangeNewRemoteMailbox["FirstName"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxfirstName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxlastName != null)
                {
                    exchangeNewRemoteMailbox["LastName"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxlastName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxonPremisesOrganizationalUnit != null)
                {
                    exchangeNewRemoteMailbox["OnPremisesOrganizationalUnit"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxonPremisesOrganizationalUnit);
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["Name"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxname);
                if (exchangeNewRemoteMailboxdisplayName != null)
                {
                    exchangeNewRemoteMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxdisplayName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxremoteRoutingAddress != null)
                {
                    exchangeNewRemoteMailbox["RemoteRoutingAddress"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxremoteRoutingAddress);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxalias != null)
                {
                    exchangeNewRemoteMailbox["Alias"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxalias);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeNewRemoteMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxprimarySmtpAddress);
                    exchangeNewRemoteMailboxpropCount++;
                }

                exchangeNewRemoteMailboxpropCount++;
                exchangeNewRemoteMailbox["UserPrincipalName"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxuserPrincipalName);
                if (exchangeNewRemoteMailboxsamAccountName != null)
                {
                    exchangeNewRemoteMailbox["SamAccountName"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxsamAccountName);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxpassword != null)
                {
                    exchangeNewRemoteMailbox["Password"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxpassword);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                    {
                        exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword);
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
                        exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxresetPasswordOnNextLogon);
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
                        exchangeNewRemoteMailbox["SharedMailbox"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxsharedMailbox);
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
                    exchangeNewRemoteMailbox["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxemailAddressPolicyEnabled);
                    exchangeNewRemoteMailboxpropCount++;
                }

                if (exchangeNewRemoteMailboxarchive != null)
                {
                    if (exchangeNewRemoteMailboxarchive != null)
                    {
                        exchangeNewRemoteMailbox["Archive"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxarchive);
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
                exchangeNewRemoteMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeNewRemoteMailboxworkflow);
                if (exchangeNewRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeNewRemoteMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeNewRemoteMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse> ExchangeSetADServerToViewEntireForest([WorkflowExpression] Func<bool> exchangeSetADServerToViewEntireForestviewEntireForest, [WorkflowExpression] Func<string> exchangeSetADServerToViewEntireForestworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetADServerToViewEntireForest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetADServerToViewEntireForest = new JObject();
                var exchangeSetADServerToViewEntireForestpropCount = 0;
                exchangeSetADServerToViewEntireForestpropCount++;
                exchangeSetADServerToViewEntireForest["ViewEntireForest"] = SourceExpressionConverter.ConvertToken(exchangeSetADServerToViewEntireForestviewEntireForest);
                exchangeSetADServerToViewEntireForestpropCount++;
                exchangeSetADServerToViewEntireForest["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetADServerToViewEntireForestworkflow);
                if (exchangeSetADServerToViewEntireForestpropCount > 0)
                {
                    callPayload.Body = exchangeSetADServerToViewEntireForest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetADServerToViewEntireForestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse> ExchangeSetMailbox([WorkflowExpression] Func<string> exchangeSetMailboxidentity, [WorkflowExpression] Func<string> exchangeSetMailboxworkflow, [WorkflowExpression] Func<bool> exchangeSetMailboxaccountDisabled = null, [WorkflowExpression] Func<string> exchangeSetMailboxalias = null, [WorkflowExpression] Func<string> exchangeSetMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeSetMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetMailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute4 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute5 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute6 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute7 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute8 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute9 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute10 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute11 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute12 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute13 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute14 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute15 = null, [WorkflowExpression] Func<bool> exchangeSetMailboxemailAddressPolicyEnabled = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailbox = new JObject();
                var exchangeSetMailboxpropCount = 0;
                exchangeSetMailboxpropCount++;
                exchangeSetMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxidentity);
                if (exchangeSetMailboxaccountDisabled != null)
                {
                    exchangeSetMailbox["AccountDisabled"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxaccountDisabled);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxalias != null)
                {
                    exchangeSetMailbox["Alias"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxalias);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxdisplayName != null)
                {
                    exchangeSetMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxdisplayName);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxprimarySmtpAddress != null)
                {
                    exchangeSetMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxprimarySmtpAddress);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxhiddenFromAddressListsEnabled != null)
                {
                    exchangeSetMailbox["HiddenFromAddressListsEnabled"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxhiddenFromAddressListsEnabled);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute1 != null)
                {
                    exchangeSetMailbox["CustomAttribute1"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute1);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute2 != null)
                {
                    exchangeSetMailbox["CustomAttribute2"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute2);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute3 != null)
                {
                    exchangeSetMailbox["CustomAttribute3"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute3);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute4 != null)
                {
                    exchangeSetMailbox["CustomAttribute4"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute4);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute5 != null)
                {
                    exchangeSetMailbox["CustomAttribute5"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute5);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute6 != null)
                {
                    exchangeSetMailbox["CustomAttribute6"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute6);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute7 != null)
                {
                    exchangeSetMailbox["CustomAttribute7"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute7);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute8 != null)
                {
                    exchangeSetMailbox["CustomAttribute8"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute8);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute9 != null)
                {
                    exchangeSetMailbox["CustomAttribute9"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute9);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute10 != null)
                {
                    exchangeSetMailbox["CustomAttribute10"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute10);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute11 != null)
                {
                    exchangeSetMailbox["CustomAttribute11"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute11);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute12 != null)
                {
                    exchangeSetMailbox["CustomAttribute12"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute12);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute13 != null)
                {
                    exchangeSetMailbox["CustomAttribute13"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute13);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute14 != null)
                {
                    exchangeSetMailbox["CustomAttribute14"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute14);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxcustomAttribute15 != null)
                {
                    exchangeSetMailbox["CustomAttribute15"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute15);
                    exchangeSetMailboxpropCount++;
                }

                if (exchangeSetMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeSetMailbox["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxemailAddressPolicyEnabled);
                    exchangeSetMailboxpropCount++;
                }

                exchangeSetMailboxpropCount++;
                exchangeSetMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxworkflow);
                if (exchangeSetMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse> ExchangeSetMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesworkflow, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesalias = null, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = null, [WorkflowExpression] Func<string[]> exchangeSetMailboxEmailAddressesemailAddressesToAddList = null, [WorkflowExpression] Func<bool> exchangeSetMailboxEmailAddressesreplaceEmailAddresses = null, [WorkflowExpression] Func<string[]> exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxEmailAddresses = new JObject();
                var exchangeSetMailboxEmailAddressespropCount = 0;
                exchangeSetMailboxEmailAddressespropCount++;
                exchangeSetMailboxEmailAddresses["Identity"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesidentity);
                if (exchangeSetMailboxEmailAddressesalias != null)
                {
                    exchangeSetMailboxEmailAddresses["Alias"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesalias);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesprimarySmtpAddress != null)
                {
                    exchangeSetMailboxEmailAddresses["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesprimarySmtpAddress);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesemailAddressesToAddList != null)
                {
                    exchangeSetMailboxEmailAddresses["EmailAddressesToAddList"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesemailAddressesToAddList);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                if (exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    if (exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                    {
                        exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesreplaceEmailAddresses);
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
                    exchangeSetMailboxEmailAddresses["EmailAddressesToRemoveList"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList);
                    exchangeSetMailboxEmailAddressespropCount++;
                }

                exchangeSetMailboxEmailAddressespropCount++;
                exchangeSetMailboxEmailAddresses["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesworkflow);
                if (exchangeSetMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxEmailAddresses;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetMailboxEmailAddressesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse> ExchangeGetMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeGetMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeGetMailboxEmailAddressesworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetMailboxEmailAddresses = new JObject();
                var exchangeGetMailboxEmailAddressespropCount = 0;
                exchangeGetMailboxEmailAddressespropCount++;
                exchangeGetMailboxEmailAddresses["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxEmailAddressesidentity);
                exchangeGetMailboxEmailAddressespropCount++;
                exchangeGetMailboxEmailAddresses["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetMailboxEmailAddressesworkflow);
                if (exchangeGetMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeGetMailboxEmailAddresses;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetMailboxEmailAddressesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse> ExchangeSetRemoteMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesworkflow, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesalias = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = null, [WorkflowExpression] Func<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = null, [WorkflowExpression] Func<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetRemoteMailboxEmailAddresses = new JObject();
                var exchangeSetRemoteMailboxEmailAddressespropCount = 0;
                exchangeSetRemoteMailboxEmailAddressespropCount++;
                exchangeSetRemoteMailboxEmailAddresses["Identity"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesidentity);
                if (exchangeSetRemoteMailboxEmailAddressesalias != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["Alias"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesalias);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToAddList"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                if (exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    if (exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                    {
                        exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses);
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
                    exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToRemoveList"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList);
                    exchangeSetRemoteMailboxEmailAddressespropCount++;
                }

                exchangeSetRemoteMailboxEmailAddressespropCount++;
                exchangeSetRemoteMailboxEmailAddresses["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesworkflow);
                if (exchangeSetRemoteMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeSetRemoteMailboxEmailAddresses;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse> ExchangeGetRemoteMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeGetRemoteMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxEmailAddressesworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeGetRemoteMailboxEmailAddresses = new JObject();
                var exchangeGetRemoteMailboxEmailAddressespropCount = 0;
                exchangeGetRemoteMailboxEmailAddressespropCount++;
                exchangeGetRemoteMailboxEmailAddresses["Identity"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxEmailAddressesidentity);
                exchangeGetRemoteMailboxEmailAddressespropCount++;
                exchangeGetRemoteMailboxEmailAddresses["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeGetRemoteMailboxEmailAddressesworkflow);
                if (exchangeGetRemoteMailboxEmailAddressespropCount > 0)
                {
                    callPayload.Body = exchangeGetRemoteMailboxEmailAddresses;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse> ExchangeResetMailboxAttributes([WorkflowExpression] Func<string> exchangeResetMailboxAttributesidentity, [WorkflowExpression] Func<string> exchangeResetMailboxAttributesworkflow, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute1 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute2 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute3 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute4 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute5 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute6 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute7 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute8 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute9 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute10 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute11 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute12 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute13 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute14 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute15 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeResetMailboxAttributes = new JObject();
                var exchangeResetMailboxAttributespropCount = 0;
                exchangeResetMailboxAttributespropCount++;
                exchangeResetMailboxAttributes["Identity"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesidentity);
                if (exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                {
                    if (exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                    {
                        exchangeResetMailboxAttributes["ResetCustomAttribute1"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute1);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute2"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute2);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute3"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute3);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute4"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute4);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute5"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute5);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute6"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute6);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute7"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute7);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute8"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute8);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute9"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute9);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute10"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute10);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute11"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute11);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute12"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute12);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute13"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute13);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute14"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute14);
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
                        exchangeResetMailboxAttributes["ResetCustomAttribute15"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute15);
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
                exchangeResetMailboxAttributes["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeResetMailboxAttributesworkflow);
                if (exchangeResetMailboxAttributespropCount > 0)
                {
                    callPayload.Body = exchangeResetMailboxAttributes;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeResetMailboxAttributesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse> ExchangeResetRemoteMailboxAttributes([WorkflowExpression] Func<string> exchangeResetRemoteMailboxAttributesidentity, [WorkflowExpression] Func<string> exchangeResetRemoteMailboxAttributesworkflow, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetRemoteMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeResetRemoteMailboxAttributes = new JObject();
                var exchangeResetRemoteMailboxAttributespropCount = 0;
                exchangeResetRemoteMailboxAttributespropCount++;
                exchangeResetRemoteMailboxAttributes["Identity"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesidentity);
                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                {
                    if (exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                    {
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute1);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute2);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute3);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute4);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute5);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute6);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute7);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute8);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute9);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute10);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute11);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute12);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute13);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute14);
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
                        exchangeResetRemoteMailboxAttributes["ResetCustomAttribute15"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute15);
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
                exchangeResetRemoteMailboxAttributes["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesworkflow);
                if (exchangeResetRemoteMailboxAttributespropCount > 0)
                {
                    callPayload.Body = exchangeResetRemoteMailboxAttributes;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeResetRemoteMailboxAttributesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse> ExchangeSetRemoteMailbox([WorkflowExpression] Func<string> exchangeSetRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<exchangeSetRemoteMailboxtypeInput> exchangeSetRemoteMailboxtype = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute4 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute5 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute6 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute7 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute8 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute9 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute10 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute11 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute12 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute13 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute14 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute15 = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxemailAddressPolicyEnabled = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetRemoteMailbox = new JObject();
                var exchangeSetRemoteMailboxpropCount = 0;
                exchangeSetRemoteMailboxpropCount++;
                exchangeSetRemoteMailbox["Identity"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxidentity);
                if (exchangeSetRemoteMailboxalias != null)
                {
                    exchangeSetRemoteMailbox["Alias"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxalias);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxdisplayName != null)
                {
                    exchangeSetRemoteMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxdisplayName);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxprimarySmtpAddress != null)
                {
                    exchangeSetRemoteMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxprimarySmtpAddress);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxtype != null)
                {
                    exchangeSetRemoteMailbox["Type"] = SourceExpressionConverter.Convert(exchangeSetRemoteMailboxtype);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxhiddenFromAddressListsEnabled != null)
                {
                    exchangeSetRemoteMailbox["HiddenFromAddressListsEnabled"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute1 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute1"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute1);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute2 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute2"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute2);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute3 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute3"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute3);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute4 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute4"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute4);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute5 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute5"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute5);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute6 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute6"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute6);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute7 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute7"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute7);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute8 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute8"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute8);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute9 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute9"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute9);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute10 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute10"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute10);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute11 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute11"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute11);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute12 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute12"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute12);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute13 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute13"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute13);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute14 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute14"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute14);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxcustomAttribute15 != null)
                {
                    exchangeSetRemoteMailbox["CustomAttribute15"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute15);
                    exchangeSetRemoteMailboxpropCount++;
                }

                if (exchangeSetRemoteMailboxemailAddressPolicyEnabled != null)
                {
                    exchangeSetRemoteMailbox["EmailAddressPolicyEnabled"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxemailAddressPolicyEnabled);
                    exchangeSetRemoteMailboxpropCount++;
                }

                exchangeSetRemoteMailboxpropCount++;
                exchangeSetRemoteMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetRemoteMailboxworkflow);
                if (exchangeSetRemoteMailboxpropCount > 0)
                {
                    callPayload.Body = exchangeSetRemoteMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetRemoteMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse> ExchangeSetMailboxSendOnBehalfOfPermission([WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissionidentity, [WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, [WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissionworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxSendOnBehalfOfPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxSendOnBehalfOfPermission = new JObject();
                var exchangeSetMailboxSendOnBehalfOfPermissionpropCount = 0;
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["Identity"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxSendOnBehalfOfPermissionidentity);
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["GrantSendOnBehalfTo"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo);
                exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
                exchangeSetMailboxSendOnBehalfOfPermission["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxSendOnBehalfOfPermissionworkflow);
                if (exchangeSetMailboxSendOnBehalfOfPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxSendOnBehalfOfPermission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse> ExchangeAddADPermission([WorkflowExpression] Func<string> exchangeAddADPermissionidentity, [WorkflowExpression] Func<string> exchangeAddADPermissionuser, [WorkflowExpression] Func<string> exchangeAddADPermissionworkflow, [WorkflowExpression] Func<string> exchangeAddADPermissionaccessRights = null, [WorkflowExpression] Func<string> exchangeAddADPermissionextendedRights = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddADPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeAddADPermission = new JObject();
                var exchangeAddADPermissionpropCount = 0;
                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["Identity"] = SourceExpressionConverter.ConvertToken(exchangeAddADPermissionidentity);
                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["User"] = SourceExpressionConverter.ConvertToken(exchangeAddADPermissionuser);
                if (exchangeAddADPermissionaccessRights != null)
                {
                    exchangeAddADPermission["AccessRights"] = SourceExpressionConverter.ConvertToken(exchangeAddADPermissionaccessRights);
                    exchangeAddADPermissionpropCount++;
                }

                if (exchangeAddADPermissionextendedRights != null)
                {
                    exchangeAddADPermission["ExtendedRights"] = SourceExpressionConverter.ConvertToken(exchangeAddADPermissionextendedRights);
                    exchangeAddADPermissionpropCount++;
                }

                exchangeAddADPermissionpropCount++;
                exchangeAddADPermission["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeAddADPermissionworkflow);
                if (exchangeAddADPermissionpropCount > 0)
                {
                    callPayload.Body = exchangeAddADPermission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeAddADPermissionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse> ExchangeSetMailboxAutoReplyConfiguration([WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationidentity, [WorkflowExpression] Func<exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput> exchangeSetMailboxAutoReplyConfigurationautoReplyState, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationworkflow, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationinternalMessage = null, [WorkflowExpression] Func<exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput> exchangeSetMailboxAutoReplyConfigurationexternalAudience = null, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationexternalMessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var exchangeSetMailboxAutoReplyConfiguration = new JObject();
                var exchangeSetMailboxAutoReplyConfigurationpropCount = 0;
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["Identity"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationidentity);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["AutoReplyState"] = SourceExpressionConverter.Convert(exchangeSetMailboxAutoReplyConfigurationautoReplyState);
                if (exchangeSetMailboxAutoReplyConfigurationinternalMessage != null)
                {
                    exchangeSetMailboxAutoReplyConfiguration["InternalMessage"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationinternalMessage);
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                if (exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                {
                    if (exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                    {
                        exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = SourceExpressionConverter.Convert(exchangeSetMailboxAutoReplyConfigurationexternalAudience);
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
                    exchangeSetMailboxAutoReplyConfiguration["ExternalMessage"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationexternalMessage);
                    exchangeSetMailboxAutoReplyConfigurationpropCount++;
                }

                exchangeSetMailboxAutoReplyConfigurationpropCount++;
                exchangeSetMailboxAutoReplyConfiguration["Workflow"] = SourceExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationworkflow);
                if (exchangeSetMailboxAutoReplyConfigurationpropCount > 0)
                {
                    callPayload.Body = exchangeSetMailboxAutoReplyConfiguration;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse> IsAzureADv2PowerShellModuleInstalled([WorkflowExpression] Func<string> isAzureADv2PowerShellModuleInstalledworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isAzureADv2PowerShellModuleInstalled = new JObject();
                var isAzureADv2PowerShellModuleInstalledpropCount = 0;
                isAzureADv2PowerShellModuleInstalledpropCount++;
                isAzureADv2PowerShellModuleInstalled["Workflow"] = SourceExpressionConverter.ConvertToken(isAzureADv2PowerShellModuleInstalledworkflow);
                if (isAzureADv2PowerShellModuleInstalledpropCount > 0)
                {
                    callPayload.Body = isAzureADv2PowerShellModuleInstalled;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsAzureADv2PowerShellModuleInstalledResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse> OpenAzureADv2PowerShellRunspace([WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceusername, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspacepassword, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspacetenantId = null, [WorkflowExpression] Func<openAzureADv2PowerShellRunspaceaPIToUseInput> openAzureADv2PowerShellRunspaceaPIToUse = null, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceauthenticationScope = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openAzureADv2PowerShellRunspace = new JObject();
                var openAzureADv2PowerShellRunspacepropCount = 0;
                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Username"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceusername);
                openAzureADv2PowerShellRunspacepropCount++;
                openAzureADv2PowerShellRunspace["Password"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspacepassword);
                if (openAzureADv2PowerShellRunspacetenantId != null)
                {
                    openAzureADv2PowerShellRunspace["TenantId"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspacetenantId);
                    openAzureADv2PowerShellRunspacepropCount++;
                }

                if (openAzureADv2PowerShellRunspaceaPIToUse != null)
                {
                    if (openAzureADv2PowerShellRunspaceaPIToUse != null)
                    {
                        openAzureADv2PowerShellRunspace["APIToUse"] = SourceExpressionConverter.Convert(openAzureADv2PowerShellRunspaceaPIToUse);
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
                        openAzureADv2PowerShellRunspace["AuthenticationScope"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceauthenticationScope);
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
                openAzureADv2PowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceworkflow);
                if (openAzureADv2PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openAzureADv2PowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse> OpenAzureADv2PowerShellRunspaceWithCertificate([WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificateapplicationId, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificatetenantId, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificateworkflow, [WorkflowExpression] Func<openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput> openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openAzureADv2PowerShellRunspaceWithCertificate = new JObject();
                var openAzureADv2PowerShellRunspaceWithCertificatepropCount = 0;
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["ApplicationId"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificateapplicationId);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["CertificateThumbprint"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
                openAzureADv2PowerShellRunspaceWithCertificate["TenantId"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificatetenantId);
                if (openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                {
                    if (openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                    {
                        openAzureADv2PowerShellRunspaceWithCertificate["APIToUse"] = SourceExpressionConverter.Convert(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse);
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
                openAzureADv2PowerShellRunspaceWithCertificate["Workflow"] = SourceExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificateworkflow);
                if (openAzureADv2PowerShellRunspaceWithCertificatepropCount > 0)
                {
                    callPayload.Body = openAzureADv2PowerShellRunspaceWithCertificate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse> IsAzureADv2PowerShellRunspaceOpen([WorkflowExpression] Func<string> isAzureADv2PowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var isAzureADv2PowerShellRunspaceOpen = new JObject();
                var isAzureADv2PowerShellRunspaceOpenpropCount = 0;
                if (isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePId != null)
                {
                    if (isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePId != null)
                    {
                        isAzureADv2PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = SourceExpressionConverter.ConvertToken(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePId);
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
                isAzureADv2PowerShellRunspaceOpen["Workflow"] = SourceExpressionConverter.ConvertToken(isAzureADv2PowerShellRunspaceOpenworkflow);
                if (isAzureADv2PowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isAzureADv2PowerShellRunspaceOpen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsAzureADv2PowerShellRunspaceOpenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse> RunAzureADv2PowerShellAutomationScript([WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/RunAzureADv2PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runAzureADv2PowerShellAutomationScript = new JObject();
                var runAzureADv2PowerShellAutomationScriptpropCount = 0;
                if (runAzureADv2PowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runAzureADv2PowerShellAutomationScript["PowerShellScriptContents"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptisNoResultAnError);
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
                        runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnComplexTypes);
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
                        runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean);
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
                        runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal);
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
                        runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnDateAsDate);
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
                    runAzureADv2PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptrunScriptAsThread);
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
                    runAzureADv2PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread);
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
                        runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword);
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
                        runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptlogVerboseOutput);
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
                    runAzureADv2PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runAzureADv2PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                if (runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runAzureADv2PowerShellAutomationScript["PowerShellCommandParameters"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters);
                    runAzureADv2PowerShellAutomationScriptpropCount++;
                }

                runAzureADv2PowerShellAutomationScriptpropCount++;
                runAzureADv2PowerShellAutomationScript["Workflow"] = SourceExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptworkflow);
                if (runAzureADv2PowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runAzureADv2PowerShellAutomationScript;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunAzureADv2PowerShellAutomationScriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse> CloseAzureADv2PowerShellRunspace([WorkflowExpression] Func<string> closeAzureADv2PowerShellRunspaceworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/CloseAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeAzureADv2PowerShellRunspace = new JObject();
                var closeAzureADv2PowerShellRunspacepropCount = 0;
                closeAzureADv2PowerShellRunspacepropCount++;
                closeAzureADv2PowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(closeAzureADv2PowerShellRunspaceworkflow);
                if (closeAzureADv2PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeAzureADv2PowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseAzureADv2PowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse> AzureADv2GetAzureADUsers([WorkflowExpression] Func<string> azureADv2GetAzureADUsersworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersobjectId = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersfilterPropertyName = null, [WorkflowExpression] Func<azureADv2GetAzureADUsersfilterPropertyComparisonInput> azureADv2GetAzureADUsersfilterPropertyComparison = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersfilterPropertyValue = null, [WorkflowExpression] Func<bool> azureADv2GetAzureADUsersnoResultIsAnException = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUserspropertiesToReturn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUsers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUsers = new JObject();
                var azureADv2GetAzureADUserspropCount = 0;
                if (azureADv2GetAzureADUsersobjectId != null)
                {
                    azureADv2GetAzureADUsers["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUsersobjectId);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersfilterPropertyName != null)
                {
                    azureADv2GetAzureADUsers["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUsersfilterPropertyName);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersfilterPropertyComparison != null)
                {
                    if (azureADv2GetAzureADUsersfilterPropertyComparison != null)
                    {
                        azureADv2GetAzureADUsers["FilterPropertyComparison"] = SourceExpressionConverter.Convert(azureADv2GetAzureADUsersfilterPropertyComparison);
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
                    azureADv2GetAzureADUsers["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUsersfilterPropertyValue);
                    azureADv2GetAzureADUserspropCount++;
                }

                if (azureADv2GetAzureADUsersnoResultIsAnException != null)
                {
                    if (azureADv2GetAzureADUsersnoResultIsAnException != null)
                    {
                        azureADv2GetAzureADUsers["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUsersnoResultIsAnException);
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
                    azureADv2GetAzureADUsers["PropertiesToReturn"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserspropertiesToReturn);
                    azureADv2GetAzureADUserspropCount++;
                }

                azureADv2GetAzureADUserspropCount++;
                azureADv2GetAzureADUsers["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUsersworkflow);
                if (azureADv2GetAzureADUserspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUsers;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse> AzureADv2AddAzureADUser([WorkflowExpression] Func<string> azureADv2AddAzureADUseruserPrincipalName, [WorkflowExpression] Func<bool> azureADv2AddAzureADUseraccountEnabled, [WorkflowExpression] Func<string> azureADv2AddAzureADUseraccountPassword, [WorkflowExpression] Func<string> azureADv2AddAzureADUserdisplayName, [WorkflowExpression] Func<string> azureADv2AddAzureADUsermailNickName, [WorkflowExpression] Func<string> azureADv2AddAzureADUserworkflow, [WorkflowExpression] Func<bool> azureADv2AddAzureADUseraccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserfirstName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserlastName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercity = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercompanyName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercountry = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserdepartment = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserfaxNumber = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserjobTitle = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsermobilePhone = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUseroffice = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserphoneNumber = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserpostalCode = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserpreferredLanguage = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserstate = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserstreetAddress = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserusageLocation = null, [WorkflowExpression] Func<azureADv2AddAzureADUserageGroupInput> azureADv2AddAzureADUserageGroup = null, [WorkflowExpression] Func<azureADv2AddAzureADUserconsentProvidedForMinorInput> azureADv2AddAzureADUserconsentProvidedForMinor = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUseremployeeId = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserforceChangePasswordNextLogin = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserenforceChangePasswordPolicy = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserpasswordNeverExpires = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddAzureADUser = new JObject();
                var azureADv2AddAzureADUserpropCount = 0;
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["UserPrincipalName"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUseruserPrincipalName);
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["AccountEnabled"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUseraccountEnabled);
                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["AccountPassword"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUseraccountPassword);
                if (azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                {
                    if (azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                    {
                        azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUseraccountPasswordIsStoredPassword);
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
                    azureADv2AddAzureADUser["FirstName"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserfirstName);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserlastName != null)
                {
                    azureADv2AddAzureADUser["LastName"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserlastName);
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["DisplayName"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserdisplayName);
                if (azureADv2AddAzureADUsercity != null)
                {
                    azureADv2AddAzureADUser["City"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUsercity);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUsercompanyName != null)
                {
                    azureADv2AddAzureADUser["CompanyName"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUsercompanyName);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUsercountry != null)
                {
                    azureADv2AddAzureADUser["Country"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUsercountry);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserdepartment != null)
                {
                    azureADv2AddAzureADUser["Department"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserdepartment);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserfaxNumber != null)
                {
                    azureADv2AddAzureADUser["FaxNumber"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserfaxNumber);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserjobTitle != null)
                {
                    azureADv2AddAzureADUser["JobTitle"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserjobTitle);
                    azureADv2AddAzureADUserpropCount++;
                }

                azureADv2AddAzureADUserpropCount++;
                azureADv2AddAzureADUser["MailNickName"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUsermailNickName);
                if (azureADv2AddAzureADUsermobilePhone != null)
                {
                    azureADv2AddAzureADUser["MobilePhone"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUsermobilePhone);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUseroffice != null)
                {
                    azureADv2AddAzureADUser["Office"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUseroffice);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserphoneNumber != null)
                {
                    azureADv2AddAzureADUser["PhoneNumber"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserphoneNumber);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserpostalCode != null)
                {
                    azureADv2AddAzureADUser["PostalCode"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserpostalCode);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserpreferredLanguage != null)
                {
                    azureADv2AddAzureADUser["PreferredLanguage"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserpreferredLanguage);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserstate != null)
                {
                    azureADv2AddAzureADUser["State"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserstate);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserstreetAddress != null)
                {
                    azureADv2AddAzureADUser["StreetAddress"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserstreetAddress);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserusageLocation != null)
                {
                    azureADv2AddAzureADUser["UsageLocation"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserusageLocation);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserageGroup != null)
                {
                    azureADv2AddAzureADUser["AgeGroup"] = SourceExpressionConverter.Convert(azureADv2AddAzureADUserageGroup);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserconsentProvidedForMinor != null)
                {
                    azureADv2AddAzureADUser["ConsentProvidedForMinor"] = SourceExpressionConverter.Convert(azureADv2AddAzureADUserconsentProvidedForMinor);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUseremployeeId != null)
                {
                    azureADv2AddAzureADUser["EmployeeId"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUseremployeeId);
                    azureADv2AddAzureADUserpropCount++;
                }

                if (azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                {
                    if (azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                    {
                        azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserforceChangePasswordNextLogin);
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
                        azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserenforceChangePasswordPolicy);
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
                        azureADv2AddAzureADUser["PasswordNeverExpires"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserpasswordNeverExpires);
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
                azureADv2AddAzureADUser["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2AddAzureADUserworkflow);
                if (azureADv2AddAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2AddAzureADUser;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2AddAzureADUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse> AzureADv2RemoveAzureADUser([WorkflowExpression] Func<string> azureADv2RemoveAzureADUserobjectId, [WorkflowExpression] Func<string> azureADv2RemoveAzureADUserworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveAzureADUser = new JObject();
                var azureADv2RemoveAzureADUserpropCount = 0;
                azureADv2RemoveAzureADUserpropCount++;
                azureADv2RemoveAzureADUser["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveAzureADUserobjectId);
                if (azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                {
                    if (azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                    {
                        azureADv2RemoveAzureADUser["ErrorIfUserDoesNotExist"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist);
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
                azureADv2RemoveAzureADUser["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveAzureADUserworkflow);
                if (azureADv2RemoveAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveAzureADUser;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveAzureADUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse> AzureADv2ResetAzureADUserPassword([WorkflowExpression] Func<string> azureADv2ResetAzureADUserPassworduserPrincipalName, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPasswordnewPassword, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPasswordworkflow, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2ResetAzureADUserPassword = new JObject();
                var azureADv2ResetAzureADUserPasswordpropCount = 0;
                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["UserPrincipalName"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPassworduserPrincipalName);
                azureADv2ResetAzureADUserPasswordpropCount++;
                azureADv2ResetAzureADUserPassword["NewPassword"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordnewPassword);
                if (azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                {
                    if (azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                    {
                        azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword);
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
                        azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin);
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
                        azureADv2ResetAzureADUserPassword["EnforceChangePasswordPolicy"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy);
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
                azureADv2ResetAzureADUserPassword["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordworkflow);
                if (azureADv2ResetAzureADUserPasswordpropCount > 0)
                {
                    callPayload.Body = azureADv2ResetAzureADUserPassword;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2ResetAzureADUserPasswordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse> AzureADv2GetAzureADUserGroupMembership([WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershipobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershipworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershippropertiesToReturn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserGroupMembership = new JObject();
                var azureADv2GetAzureADUserGroupMembershippropCount = 0;
                azureADv2GetAzureADUserGroupMembershippropCount++;
                azureADv2GetAzureADUserGroupMembership["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserGroupMembershipobjectId);
                if (azureADv2GetAzureADUserGroupMembershippropertiesToReturn != null)
                {
                    azureADv2GetAzureADUserGroupMembership["PropertiesToReturn"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserGroupMembershippropertiesToReturn);
                    azureADv2GetAzureADUserGroupMembershippropCount++;
                }

                azureADv2GetAzureADUserGroupMembershippropCount++;
                azureADv2GetAzureADUserGroupMembership["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserGroupMembershipworkflow);
                if (azureADv2GetAzureADUserGroupMembershippropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserGroupMembership;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserGroupMembershipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse> AzureADv2IsUserInAzureADUserGroup([WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupobjectId, [WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInAzureADUserGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2IsUserInAzureADUserGroup = new JObject();
                var azureADv2IsUserInAzureADUserGrouppropCount = 0;
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2IsUserInAzureADUserGroupobjectId);
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["GroupObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2IsUserInAzureADUserGroupgroupObjectId);
                azureADv2IsUserInAzureADUserGrouppropCount++;
                azureADv2IsUserInAzureADUserGroup["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2IsUserInAzureADUserGroupworkflow);
                if (azureADv2IsUserInAzureADUserGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2IsUserInAzureADUserGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2IsUserInAzureADUserGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse> AzureADv2AddUserToGroup([WorkflowExpression] Func<string> azureADv2AddUserToGroupuserObjectId, [WorkflowExpression] Func<string> azureADv2AddUserToGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2AddUserToGroupworkflow, [WorkflowExpression] Func<bool> azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddUserToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddUserToGroup = new JObject();
                var azureADv2AddUserToGrouppropCount = 0;
                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2AddUserToGroupuserObjectId);
                azureADv2AddUserToGrouppropCount++;
                azureADv2AddUserToGroup["GroupObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2AddUserToGroupgroupObjectId);
                if (azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                {
                    if (azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2AddUserToGroup["CheckUserGroupMembershipsFirst"] = SourceExpressionConverter.ConvertToken(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst);
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
                azureADv2AddUserToGroup["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2AddUserToGroupworkflow);
                if (azureADv2AddUserToGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2AddUserToGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2AddUserToGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse> AzureADv2RemoveUserFromGroup([WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromGroup = new JObject();
                var azureADv2RemoveUserFromGrouppropCount = 0;
                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupuserObjectId);
                azureADv2RemoveUserFromGrouppropCount++;
                azureADv2RemoveUserFromGroup["GroupObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupgroupObjectId);
                if (azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                {
                    if (azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                    {
                        azureADv2RemoveUserFromGroup["CheckUserGroupMembershipsFirst"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst);
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
                azureADv2RemoveUserFromGroup["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupworkflow);
                if (azureADv2RemoveUserFromGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse> AzureADv2AddADUserToMultipleADGroups([WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsworkflow, [WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = null, [WorkflowExpression] Func<int> azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddADUserToMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AddADUserToMultipleADGroups = new JObject();
                var azureADv2AddADUserToMultipleADGroupspropCount = 0;
                azureADv2AddADUserToMultipleADGroupspropCount++;
                azureADv2AddADUserToMultipleADGroups["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsuserObjectId);
                if (azureADv2AddADUserToMultipleADGroupsgroupNamesJSON != null)
                {
                    azureADv2AddADUserToMultipleADGroups["GroupNamesJSON"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON);
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                if (azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                {
                    if (azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                    {
                        azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd);
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
                        azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd);
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
                        azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst);
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
                    azureADv2AddADUserToMultipleADGroups["MaxAzureADGroupsPerCall"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall);
                    azureADv2AddADUserToMultipleADGroupspropCount++;
                }

                azureADv2AddADUserToMultipleADGroupspropCount++;
                azureADv2AddADUserToMultipleADGroups["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsworkflow);
                if (azureADv2AddADUserToMultipleADGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2AddADUserToMultipleADGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2AddADUserToMultipleADGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse> AzureADv2RemoveADUserFromMultipleADGroups([WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsworkflow, [WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = null, [WorkflowExpression] Func<int> azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveADUserFromMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveADUserFromMultipleADGroups = new JObject();
                var azureADv2RemoveADUserFromMultipleADGroupspropCount = 0;
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                azureADv2RemoveADUserFromMultipleADGroups["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId);
                if (azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON != null)
                {
                    azureADv2RemoveADUserFromMultipleADGroups["GroupNamesJSON"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON);
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove);
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
                        azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove);
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
                        azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst);
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
                    azureADv2RemoveADUserFromMultipleADGroups["MaxAzureADGroupsPerCall"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall);
                    azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                }

                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
                azureADv2RemoveADUserFromMultipleADGroups["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsworkflow);
                if (azureADv2RemoveADUserFromMultipleADGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveADUserFromMultipleADGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse> AzureADv2RemoveUserFromAllGroups([WorkflowExpression] Func<string> azureADv2RemoveUserFromAllGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromAllGroupsworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<int> azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromAllGroups = new JObject();
                var azureADv2RemoveUserFromAllGroupspropCount = 0;
                azureADv2RemoveUserFromAllGroupspropCount++;
                azureADv2RemoveUserFromAllGroups["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsuserObjectId);
                if (azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove);
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
                        azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove);
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
                    azureADv2RemoveUserFromAllGroups["MaxAzureADGroupsPerCall"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall);
                    azureADv2RemoveUserFromAllGroupspropCount++;
                }

                azureADv2RemoveUserFromAllGroupspropCount++;
                azureADv2RemoveUserFromAllGroups["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsworkflow);
                if (azureADv2RemoveUserFromAllGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromAllGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromAllGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse> AzureADv2GetAzureADLicenseSKUs([WorkflowExpression] Func<string> azureADv2GetAzureADLicenseSKUsworkflow, [WorkflowExpression] Func<azureADv2GetAzureADLicenseSKUsexpandPropertyInput> azureADv2GetAzureADLicenseSKUsexpandProperty = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        azureADv2GetAzureADLicenseSKUs["ExpandProperty"] = SourceExpressionConverter.Convert(azureADv2GetAzureADLicenseSKUsexpandProperty);
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
                azureADv2GetAzureADLicenseSKUs["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADLicenseSKUsworkflow);
                if (azureADv2GetAzureADLicenseSKUspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADLicenseSKUs;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADLicenseSKUsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse> AzureADv2SetAzureADUserLicense([WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicenseToAdd = null, [WorkflowExpression] Func<azureADv2SetAzureADUserLicenselicensePlansChoiceInput> azureADv2SetAzureADUserLicenselicensePlansChoice = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicensePlansCSV = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicensesToRemoveCSV = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseusageLocation = null, [WorkflowExpression] Func<bool> azureADv2SetAzureADUserLicenselocalScope = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUserLicense = new JObject();
                var azureADv2SetAzureADUserLicensepropCount = 0;
                azureADv2SetAzureADUserLicensepropCount++;
                azureADv2SetAzureADUserLicense["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenseobjectId);
                if (azureADv2SetAzureADUserLicenselicenseToAdd != null)
                {
                    azureADv2SetAzureADUserLicense["LicenseToAdd"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselicenseToAdd);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                {
                    if (azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                    {
                        azureADv2SetAzureADUserLicense["LicensePlansChoice"] = SourceExpressionConverter.Convert(azureADv2SetAzureADUserLicenselicensePlansChoice);
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
                    azureADv2SetAzureADUserLicense["LicensePlansCSV"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselicensePlansCSV);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselicensesToRemoveCSV != null)
                {
                    azureADv2SetAzureADUserLicense["LicensesToRemoveCSV"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselicensesToRemoveCSV);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenseusageLocation != null)
                {
                    azureADv2SetAzureADUserLicense["UsageLocation"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenseusageLocation);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                if (azureADv2SetAzureADUserLicenselocalScope != null)
                {
                    azureADv2SetAzureADUserLicense["LocalScope"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselocalScope);
                    azureADv2SetAzureADUserLicensepropCount++;
                }

                azureADv2SetAzureADUserLicensepropCount++;
                azureADv2SetAzureADUserLicense["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenseworkflow);
                if (azureADv2SetAzureADUserLicensepropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUserLicense;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserLicenseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse> AzureADv2GetAzureADUserLicenses([WorkflowExpression] Func<string> azureADv2GetAzureADUserLicensesobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicensesworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserLicenses = new JObject();
                var azureADv2GetAzureADUserLicensespropCount = 0;
                azureADv2GetAzureADUserLicensespropCount++;
                azureADv2GetAzureADUserLicenses["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicensesobjectId);
                azureADv2GetAzureADUserLicensespropCount++;
                azureADv2GetAzureADUserLicenses["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicensesworkflow);
                if (azureADv2GetAzureADUserLicensespropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserLicenses;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserLicensesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse> AzureADv2GetAzureADUserLicenseServicePlans([WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlansobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlansworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenseServicePlans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserLicenseServicePlans = new JObject();
                var azureADv2GetAzureADUserLicenseServicePlanspropCount = 0;
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicenseServicePlansobjectId);
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["LicenseSKUPartNumber"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber);
                azureADv2GetAzureADUserLicenseServicePlanspropCount++;
                azureADv2GetAzureADUserLicenseServicePlans["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicenseServicePlansworkflow);
                if (azureADv2GetAzureADUserLicenseServicePlanspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserLicenseServicePlans;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse> AzureADv2RemoveAllAzureADUserLicense([WorkflowExpression] Func<string> azureADv2RemoveAllAzureADUserLicenseobjectId, [WorkflowExpression] Func<string> azureADv2RemoveAllAzureADUserLicenseworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAllAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveAllAzureADUserLicense = new JObject();
                var azureADv2RemoveAllAzureADUserLicensepropCount = 0;
                azureADv2RemoveAllAzureADUserLicensepropCount++;
                azureADv2RemoveAllAzureADUserLicense["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveAllAzureADUserLicenseobjectId);
                azureADv2RemoveAllAzureADUserLicensepropCount++;
                azureADv2RemoveAllAzureADUserLicense["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveAllAzureADUserLicenseworkflow);
                if (azureADv2RemoveAllAzureADUserLicensepropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveAllAzureADUserLicense;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse> AzureADv2SetAzureADUser([WorkflowExpression] Func<string> azureADv2SetAzureADUserobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserfirstName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserlastName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserdisplayName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercity = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercompanyName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercountry = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserdepartment = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserfaxNumber = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserjobTitle = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsermobilePhone = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUseroffice = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserphoneNumber = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserpostalCode = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserpreferredLanguage = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserstate = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserstreetAddress = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserusageLocation = null, [WorkflowExpression] Func<azureADv2SetAzureADUserageGroupInput> azureADv2SetAzureADUserageGroup = null, [WorkflowExpression] Func<azureADv2SetAzureADUserconsentProvidedForMinorInput> azureADv2SetAzureADUserconsentProvidedForMinor = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsermailNickName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUseremployeeId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUser = new JObject();
                var azureADv2SetAzureADUserpropCount = 0;
                azureADv2SetAzureADUserpropCount++;
                azureADv2SetAzureADUser["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserobjectId);
                if (azureADv2SetAzureADUserfirstName != null)
                {
                    azureADv2SetAzureADUser["FirstName"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserfirstName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserlastName != null)
                {
                    azureADv2SetAzureADUser["LastName"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserlastName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserdisplayName != null)
                {
                    azureADv2SetAzureADUser["DisplayName"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserdisplayName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsercity != null)
                {
                    azureADv2SetAzureADUser["City"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUsercity);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsercompanyName != null)
                {
                    azureADv2SetAzureADUser["CompanyName"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUsercompanyName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsercountry != null)
                {
                    azureADv2SetAzureADUser["Country"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUsercountry);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserdepartment != null)
                {
                    azureADv2SetAzureADUser["Department"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserdepartment);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserfaxNumber != null)
                {
                    azureADv2SetAzureADUser["FaxNumber"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserfaxNumber);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserjobTitle != null)
                {
                    azureADv2SetAzureADUser["JobTitle"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserjobTitle);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsermobilePhone != null)
                {
                    azureADv2SetAzureADUser["MobilePhone"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUsermobilePhone);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUseroffice != null)
                {
                    azureADv2SetAzureADUser["Office"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUseroffice);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserphoneNumber != null)
                {
                    azureADv2SetAzureADUser["PhoneNumber"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserphoneNumber);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserpostalCode != null)
                {
                    azureADv2SetAzureADUser["PostalCode"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserpostalCode);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserpreferredLanguage != null)
                {
                    azureADv2SetAzureADUser["PreferredLanguage"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserpreferredLanguage);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserstate != null)
                {
                    azureADv2SetAzureADUser["State"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserstate);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserstreetAddress != null)
                {
                    azureADv2SetAzureADUser["StreetAddress"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserstreetAddress);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserusageLocation != null)
                {
                    azureADv2SetAzureADUser["UsageLocation"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserusageLocation);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserageGroup != null)
                {
                    azureADv2SetAzureADUser["AgeGroup"] = SourceExpressionConverter.Convert(azureADv2SetAzureADUserageGroup);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUserconsentProvidedForMinor != null)
                {
                    azureADv2SetAzureADUser["ConsentProvidedForMinor"] = SourceExpressionConverter.Convert(azureADv2SetAzureADUserconsentProvidedForMinor);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUsermailNickName != null)
                {
                    azureADv2SetAzureADUser["MailNickName"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUsermailNickName);
                    azureADv2SetAzureADUserpropCount++;
                }

                if (azureADv2SetAzureADUseremployeeId != null)
                {
                    azureADv2SetAzureADUser["EmployeeId"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUseremployeeId);
                    azureADv2SetAzureADUserpropCount++;
                }

                azureADv2SetAzureADUserpropCount++;
                azureADv2SetAzureADUser["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserworkflow);
                if (azureADv2SetAzureADUserpropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUser;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse> AzureADv2ResetAzureADUserProperties([WorkflowExpression] Func<string> azureADv2ResetAzureADUserPropertiesobjectId, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPropertiesworkflow, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetFirstName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetLastName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCity = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCompanyName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCountry = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetDepartment = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetFaxNumber = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetJobTitle = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetMobilePhone = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetOffice = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPhoneNumber = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPostalCode = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetState = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetStreetAddress = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetUsageLocation = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetAgeGroup = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetEmployeeId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2ResetAzureADUserProperties = new JObject();
                var azureADv2ResetAzureADUserPropertiespropCount = 0;
                azureADv2ResetAzureADUserPropertiespropCount++;
                azureADv2ResetAzureADUserProperties["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesobjectId);
                if (azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                {
                    if (azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                    {
                        azureADv2ResetAzureADUserProperties["ResetFirstName"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetFirstName);
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
                        azureADv2ResetAzureADUserProperties["ResetLastName"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetLastName);
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
                        azureADv2ResetAzureADUserProperties["ResetCity"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetCity);
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
                        azureADv2ResetAzureADUserProperties["ResetCompanyName"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetCompanyName);
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
                        azureADv2ResetAzureADUserProperties["ResetCountry"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetCountry);
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
                        azureADv2ResetAzureADUserProperties["ResetDepartment"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetDepartment);
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
                        azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetFaxNumber);
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
                        azureADv2ResetAzureADUserProperties["ResetJobTitle"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetJobTitle);
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
                        azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetMobilePhone);
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
                        azureADv2ResetAzureADUserProperties["ResetOffice"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetOffice);
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
                        azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetPhoneNumber);
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
                        azureADv2ResetAzureADUserProperties["ResetPostalCode"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetPostalCode);
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
                        azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage);
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
                        azureADv2ResetAzureADUserProperties["ResetState"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetState);
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
                        azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetStreetAddress);
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
                        azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetUsageLocation);
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
                        azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetAgeGroup);
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
                        azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor);
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
                        azureADv2ResetAzureADUserProperties["ResetEmployeeId"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetEmployeeId);
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
                azureADv2ResetAzureADUserProperties["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesworkflow);
                if (azureADv2ResetAzureADUserPropertiespropCount > 0)
                {
                    callPayload.Body = azureADv2ResetAzureADUserProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2ResetAzureADUserPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse> AzureADv2SetAzureADUserManager([WorkflowExpression] Func<string> azureADv2SetAzureADUserManagerobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserManagerworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserManagermanager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserManager";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2SetAzureADUserManager = new JObject();
                var azureADv2SetAzureADUserManagerpropCount = 0;
                azureADv2SetAzureADUserManagerpropCount++;
                azureADv2SetAzureADUserManager["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserManagerobjectId);
                if (azureADv2SetAzureADUserManagermanager != null)
                {
                    azureADv2SetAzureADUserManager["Manager"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserManagermanager);
                    azureADv2SetAzureADUserManagerpropCount++;
                }

                azureADv2SetAzureADUserManagerpropCount++;
                azureADv2SetAzureADUserManager["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2SetAzureADUserManagerworkflow);
                if (azureADv2SetAzureADUserManagerpropCount > 0)
                {
                    callPayload.Body = azureADv2SetAzureADUserManager;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserManagerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse> AzureADv2NewSecurityGroup([WorkflowExpression] Func<string> azureADv2NewSecurityGroupdisplayName, [WorkflowExpression] Func<string> azureADv2NewSecurityGroupworkflow, [WorkflowExpression] Func<string> azureADv2NewSecurityGroupdescription = null, [WorkflowExpression] Func<bool> azureADv2NewSecurityGroupcheckGroupExists = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2NewSecurityGroup = new JObject();
                var azureADv2NewSecurityGrouppropCount = 0;
                azureADv2NewSecurityGrouppropCount++;
                azureADv2NewSecurityGroup["DisplayName"] = SourceExpressionConverter.ConvertToken(azureADv2NewSecurityGroupdisplayName);
                if (azureADv2NewSecurityGroupdescription != null)
                {
                    azureADv2NewSecurityGroup["Description"] = SourceExpressionConverter.ConvertToken(azureADv2NewSecurityGroupdescription);
                    azureADv2NewSecurityGrouppropCount++;
                }

                if (azureADv2NewSecurityGroupcheckGroupExists != null)
                {
                    if (azureADv2NewSecurityGroupcheckGroupExists != null)
                    {
                        azureADv2NewSecurityGroup["CheckGroupExists"] = SourceExpressionConverter.ConvertToken(azureADv2NewSecurityGroupcheckGroupExists);
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
                azureADv2NewSecurityGroup["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2NewSecurityGroupworkflow);
                if (azureADv2NewSecurityGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2NewSecurityGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2NewSecurityGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse> AzureADv2RemoveSecurityGroup([WorkflowExpression] Func<string> azureADv2RemoveSecurityGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2RemoveSecurityGroupworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveSecurityGroup = new JObject();
                var azureADv2RemoveSecurityGrouppropCount = 0;
                azureADv2RemoveSecurityGrouppropCount++;
                azureADv2RemoveSecurityGroup["GroupObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveSecurityGroupgroupObjectId);
                if (azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                {
                    if (azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                    {
                        azureADv2RemoveSecurityGroup["ErrorIfGroupDoesNotExist"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist);
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
                azureADv2RemoveSecurityGroup["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveSecurityGroupworkflow);
                if (azureADv2RemoveSecurityGrouppropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveSecurityGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveSecurityGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse> AzureADv2NewMicrosoft365Group([WorkflowExpression] Func<string> azureADv2NewMicrosoft365GroupdisplayName, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365Groupworkflow, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365Groupdescription = null, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365GroupmailNickname = null, [WorkflowExpression] Func<azureADv2NewMicrosoft365GroupgroupVisibilityInput> azureADv2NewMicrosoft365GroupgroupVisibility = null, [WorkflowExpression] Func<bool> azureADv2NewMicrosoft365GroupcheckGroupExists = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewMicrosoft365Group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2NewMicrosoft365Group = new JObject();
                var azureADv2NewMicrosoft365GrouppropCount = 0;
                azureADv2NewMicrosoft365GrouppropCount++;
                azureADv2NewMicrosoft365Group["DisplayName"] = SourceExpressionConverter.ConvertToken(azureADv2NewMicrosoft365GroupdisplayName);
                if (azureADv2NewMicrosoft365Groupdescription != null)
                {
                    azureADv2NewMicrosoft365Group["Description"] = SourceExpressionConverter.ConvertToken(azureADv2NewMicrosoft365Groupdescription);
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (azureADv2NewMicrosoft365GroupmailNickname != null)
                {
                    azureADv2NewMicrosoft365Group["MailNickname"] = SourceExpressionConverter.ConvertToken(azureADv2NewMicrosoft365GroupmailNickname);
                    azureADv2NewMicrosoft365GrouppropCount++;
                }

                if (azureADv2NewMicrosoft365GroupgroupVisibility != null)
                {
                    if (azureADv2NewMicrosoft365GroupgroupVisibility != null)
                    {
                        azureADv2NewMicrosoft365Group["GroupVisibility"] = SourceExpressionConverter.Convert(azureADv2NewMicrosoft365GroupgroupVisibility);
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
                        azureADv2NewMicrosoft365Group["CheckGroupExists"] = SourceExpressionConverter.ConvertToken(azureADv2NewMicrosoft365GroupcheckGroupExists);
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
                azureADv2NewMicrosoft365Group["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2NewMicrosoft365Groupworkflow);
                if (azureADv2NewMicrosoft365GrouppropCount > 0)
                {
                    callPayload.Body = azureADv2NewMicrosoft365Group;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2NewMicrosoft365GroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse> AzureADv2GetGroups([WorkflowExpression] Func<string> azureADv2GetGroupsworkflow, [WorkflowExpression] Func<string> azureADv2GetGroupsobjectId = null, [WorkflowExpression] Func<string> azureADv2GetGroupsfilterPropertyName = null, [WorkflowExpression] Func<azureADv2GetGroupsfilterPropertyComparisonInput> azureADv2GetGroupsfilterPropertyComparison = null, [WorkflowExpression] Func<string> azureADv2GetGroupsfilterPropertyValue = null, [WorkflowExpression] Func<bool> azureADv2GetGroupsnoResultIsAnException = null, [WorkflowExpression] Func<string> azureADv2GetGroupspropertiesToReturn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetGroups = new JObject();
                var azureADv2GetGroupspropCount = 0;
                if (azureADv2GetGroupsobjectId != null)
                {
                    azureADv2GetGroups["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetGroupsobjectId);
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsfilterPropertyName != null)
                {
                    azureADv2GetGroups["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(azureADv2GetGroupsfilterPropertyName);
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsfilterPropertyComparison != null)
                {
                    if (azureADv2GetGroupsfilterPropertyComparison != null)
                    {
                        azureADv2GetGroups["FilterPropertyComparison"] = SourceExpressionConverter.Convert(azureADv2GetGroupsfilterPropertyComparison);
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
                    azureADv2GetGroups["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(azureADv2GetGroupsfilterPropertyValue);
                    azureADv2GetGroupspropCount++;
                }

                if (azureADv2GetGroupsnoResultIsAnException != null)
                {
                    if (azureADv2GetGroupsnoResultIsAnException != null)
                    {
                        azureADv2GetGroups["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(azureADv2GetGroupsnoResultIsAnException);
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
                    azureADv2GetGroups["PropertiesToReturn"] = SourceExpressionConverter.ConvertToken(azureADv2GetGroupspropertiesToReturn);
                    azureADv2GetGroupspropCount++;
                }

                azureADv2GetGroupspropCount++;
                azureADv2GetGroups["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetGroupsworkflow);
                if (azureADv2GetGroupspropCount > 0)
                {
                    callPayload.Body = azureADv2GetGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse> AzureADv2EnableUser([WorkflowExpression] Func<string> azureADv2EnableUseruserObjectId, [WorkflowExpression] Func<string> azureADv2EnableUserworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2EnableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2EnableUser = new JObject();
                var azureADv2EnableUserpropCount = 0;
                azureADv2EnableUserpropCount++;
                azureADv2EnableUser["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2EnableUseruserObjectId);
                azureADv2EnableUserpropCount++;
                azureADv2EnableUser["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2EnableUserworkflow);
                if (azureADv2EnableUserpropCount > 0)
                {
                    callPayload.Body = azureADv2EnableUser;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2EnableUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse> AzureADv2DisableUser([WorkflowExpression] Func<string> azureADv2DisableUseruserObjectId, [WorkflowExpression] Func<string> azureADv2DisableUserworkflow, [WorkflowExpression] Func<bool> azureADv2DisableUserrevokeUserRefreshTokens = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2DisableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2DisableUser = new JObject();
                var azureADv2DisableUserpropCount = 0;
                azureADv2DisableUserpropCount++;
                azureADv2DisableUser["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2DisableUseruserObjectId);
                if (azureADv2DisableUserrevokeUserRefreshTokens != null)
                {
                    if (azureADv2DisableUserrevokeUserRefreshTokens != null)
                    {
                        azureADv2DisableUser["RevokeUserRefreshTokens"] = SourceExpressionConverter.ConvertToken(azureADv2DisableUserrevokeUserRefreshTokens);
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
                azureADv2DisableUser["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2DisableUserworkflow);
                if (azureADv2DisableUserpropCount > 0)
                {
                    callPayload.Body = azureADv2DisableUser;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2DisableUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse> AzureADv2AssignUserToRole([WorkflowExpression] Func<string> azureADv2AssignUserToRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToRoleworkflow, [WorkflowExpression] Func<string> azureADv2AssignUserToRoledirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AssignUserToRole = new JObject();
                var azureADv2AssignUserToRolepropCount = 0;
                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToRoleuserObjectId);
                azureADv2AssignUserToRolepropCount++;
                azureADv2AssignUserToRole["RoleObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToRoleroleObjectId);
                if (azureADv2AssignUserToRoledirectoryScopeId != null)
                {
                    if (azureADv2AssignUserToRoledirectoryScopeId != null)
                    {
                        azureADv2AssignUserToRole["DirectoryScopeId"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToRoledirectoryScopeId);
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
                        azureADv2AssignUserToRole["CheckUserRoleMembershipsFirst"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst);
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
                azureADv2AssignUserToRole["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToRoleworkflow);
                if (azureADv2AssignUserToRolepropCount > 0)
                {
                    callPayload.Body = azureADv2AssignUserToRole;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2AssignUserToRoleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse> AzureADv2AssignUserToMultipleRoles([WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesworkflow, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesrolesJSON = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = null, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesdirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolescheckRoleIdsExist = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2AssignUserToMultipleRoles = new JObject();
                var azureADv2AssignUserToMultipleRolespropCount = 0;
                azureADv2AssignUserToMultipleRolespropCount++;
                azureADv2AssignUserToMultipleRoles["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesuserObjectId);
                if (azureADv2AssignUserToMultipleRolesrolesJSON != null)
                {
                    azureADv2AssignUserToMultipleRoles["RolesJSON"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesrolesJSON);
                    azureADv2AssignUserToMultipleRolespropCount++;
                }

                if (azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                {
                    if (azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                    {
                        azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign);
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
                        azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign);
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
                        azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesdirectoryScopeId);
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
                        azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst);
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
                        azureADv2AssignUserToMultipleRoles["CheckRoleIdsExist"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolescheckRoleIdsExist);
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
                azureADv2AssignUserToMultipleRoles["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesworkflow);
                if (azureADv2AssignUserToMultipleRolespropCount > 0)
                {
                    callPayload.Body = azureADv2AssignUserToMultipleRoles;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2AssignUserToMultipleRolesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse> AzureADv2RemoveUserFromMultipleRoles([WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesworkflow, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesrolesJSON = null, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromMultipleRoles = new JObject();
                var azureADv2RemoveUserFromMultipleRolespropCount = 0;
                azureADv2RemoveUserFromMultipleRolespropCount++;
                azureADv2RemoveUserFromMultipleRoles["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesuserObjectId);
                if (azureADv2RemoveUserFromMultipleRolesrolesJSON != null)
                {
                    azureADv2RemoveUserFromMultipleRoles["RolesJSON"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesrolesJSON);
                    azureADv2RemoveUserFromMultipleRolespropCount++;
                }

                if (azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                {
                    if (azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                    {
                        azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId);
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
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove);
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
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove);
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
                        azureADv2RemoveUserFromMultipleRoles["ExceptionIfRoleDoesNotExist"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist);
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
                azureADv2RemoveUserFromMultipleRoles["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesworkflow);
                if (azureADv2RemoveUserFromMultipleRolespropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromMultipleRoles;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromMultipleRolesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse> AzureADv2IsUserInRole([WorkflowExpression] Func<string> azureADv2IsUserInRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInRoleworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2IsUserInRole = new JObject();
                var azureADv2IsUserInRolepropCount = 0;
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2IsUserInRoleuserObjectId);
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["RoleObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2IsUserInRoleroleObjectId);
                azureADv2IsUserInRolepropCount++;
                azureADv2IsUserInRole["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2IsUserInRoleworkflow);
                if (azureADv2IsUserInRolepropCount > 0)
                {
                    callPayload.Body = azureADv2IsUserInRole;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2IsUserInRoleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse> AzureADv2GetAzureADUserRoleAssignments([WorkflowExpression] Func<string> azureADv2GetAzureADUserRoleAssignmentsobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserRoleAssignmentsworkflow, [WorkflowExpression] Func<bool> azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = null, [WorkflowExpression] Func<bool> azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserRoleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADUserRoleAssignments = new JObject();
                var azureADv2GetAzureADUserRoleAssignmentspropCount = 0;
                azureADv2GetAzureADUserRoleAssignmentspropCount++;
                azureADv2GetAzureADUserRoleAssignments["ObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsobjectId);
                if (azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                {
                    if (azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                    {
                        azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames);
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
                        azureADv2GetAzureADUserRoleAssignments["ReturnAssignmentIds"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds);
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
                azureADv2GetAzureADUserRoleAssignments["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsworkflow);
                if (azureADv2GetAzureADUserRoleAssignmentspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADUserRoleAssignments;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse> AzureADv2RemoveUserFromRole([WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleworkflow, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoledirectoryScopeId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromRole = new JObject();
                var azureADv2RemoveUserFromRolepropCount = 0;
                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoleuserObjectId);
                azureADv2RemoveUserFromRolepropCount++;
                azureADv2RemoveUserFromRole["RoleObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoleroleObjectId);
                if (azureADv2RemoveUserFromRoledirectoryScopeId != null)
                {
                    if (azureADv2RemoveUserFromRoledirectoryScopeId != null)
                    {
                        azureADv2RemoveUserFromRole["DirectoryScopeId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoledirectoryScopeId);
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
                azureADv2RemoveUserFromRole["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoleworkflow);
                if (azureADv2RemoveUserFromRolepropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromRole;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromRoleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse> AzureADv2RemoveUserFromAllRoles([WorkflowExpression] Func<string> azureADv2RemoveUserFromAllRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromAllRolesworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2RemoveUserFromAllRoles = new JObject();
                var azureADv2RemoveUserFromAllRolespropCount = 0;
                azureADv2RemoveUserFromAllRolespropCount++;
                azureADv2RemoveUserFromAllRoles["UserObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesuserObjectId);
                if (azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                {
                    if (azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                    {
                        azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove);
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
                        azureADv2RemoveUserFromAllRoles["ExceptionIfAllRolesFailToRemove"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove);
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
                azureADv2RemoveUserFromAllRoles["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesworkflow);
                if (azureADv2RemoveUserFromAllRolespropCount > 0)
                {
                    callPayload.Body = azureADv2RemoveUserFromAllRoles;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromAllRolesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse> AzureADv2GetAzureADGroupMembers([WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersgroupObjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMemberspropertiesToReturn = null, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var azureADv2GetAzureADGroupMembers = new JObject();
                var azureADv2GetAzureADGroupMemberspropCount = 0;
                azureADv2GetAzureADGroupMemberspropCount++;
                azureADv2GetAzureADGroupMembers["GroupObjectId"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMembersgroupObjectId);
                if (azureADv2GetAzureADGroupMemberspropertiesToReturn != null)
                {
                    azureADv2GetAzureADGroupMembers["PropertiesToReturn"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMemberspropertiesToReturn);
                    azureADv2GetAzureADGroupMemberspropCount++;
                }

                if (azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn != null)
                {
                    azureADv2GetAzureADGroupMembers["MemberObjectTypesToReturn"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn);
                    azureADv2GetAzureADGroupMemberspropCount++;
                }

                azureADv2GetAzureADGroupMemberspropCount++;
                azureADv2GetAzureADGroupMembers["Workflow"] = SourceExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMembersworkflow);
                if (azureADv2GetAzureADGroupMemberspropCount > 0)
                {
                    callPayload.Body = azureADv2GetAzureADGroupMembers;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse> OpenO365PowerShellRunspace([WorkflowExpression] Func<string> openO365PowerShellRunspaceoffice365Username, [WorkflowExpression] Func<string> openO365PowerShellRunspaceoffice365Password, [WorkflowExpression] Func<string> openO365PowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openO365PowerShellRunspaceexchangeURL = null, [WorkflowExpression] Func<openO365PowerShellRunspaceconnectionMethodInput> openO365PowerShellRunspaceconnectionMethod = null, [WorkflowExpression] Func<bool> openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openO365PowerShellRunspacecommandTypesToImportLocallyInput> openO365PowerShellRunspacecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openO365PowerShellRunspace = new JObject();
                var openO365PowerShellRunspacepropCount = 0;
                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Office365Username"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceoffice365Username);
                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Office365Password"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceoffice365Password);
                if (openO365PowerShellRunspaceexchangeURL != null)
                {
                    openO365PowerShellRunspace["ExchangeURL"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceexchangeURL);
                    openO365PowerShellRunspacepropCount++;
                }

                if (openO365PowerShellRunspaceconnectionMethod != null)
                {
                    if (openO365PowerShellRunspaceconnectionMethod != null)
                    {
                        openO365PowerShellRunspace["ConnectionMethod"] = SourceExpressionConverter.Convert(openO365PowerShellRunspaceconnectionMethod);
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
                        openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected);
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
                        openO365PowerShellRunspace["CommandTypesToImportLocally"] = SourceExpressionConverter.Convert(openO365PowerShellRunspacecommandTypesToImportLocally);
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
                    openO365PowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                    openO365PowerShellRunspacepropCount++;
                }

                openO365PowerShellRunspacepropCount++;
                openO365PowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceworkflow);
                if (openO365PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = openO365PowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenO365PowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse> OpenO365PowerShellRunspaceWithCertificate([WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateapplicationId, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificatecertificateThumbprint, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateorganization, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateworkflow, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateexchangeURL = null, [WorkflowExpression] Func<openO365PowerShellRunspaceWithCertificateconnectionMethodInput> openO365PowerShellRunspaceWithCertificateconnectionMethod = null, [WorkflowExpression] Func<bool> openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput> openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var openO365PowerShellRunspaceWithCertificate = new JObject();
                var openO365PowerShellRunspaceWithCertificatepropCount = 0;
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["ApplicationId"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateapplicationId);
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["CertificateThumbprint"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificatecertificateThumbprint);
                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["Organization"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateorganization);
                if (openO365PowerShellRunspaceWithCertificateexchangeURL != null)
                {
                    openO365PowerShellRunspaceWithCertificate["ExchangeURL"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateexchangeURL);
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                if (openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                {
                    if (openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                    {
                        openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = SourceExpressionConverter.Convert(openO365PowerShellRunspaceWithCertificateconnectionMethod);
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
                        openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected);
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
                        openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = SourceExpressionConverter.Convert(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally);
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
                    openO365PowerShellRunspaceWithCertificate["AdditionalCommandsToImportLocallyCSV"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV);
                    openO365PowerShellRunspaceWithCertificatepropCount++;
                }

                openO365PowerShellRunspaceWithCertificatepropCount++;
                openO365PowerShellRunspaceWithCertificate["Workflow"] = SourceExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateworkflow);
                if (openO365PowerShellRunspaceWithCertificatepropCount > 0)
                {
                    callPayload.Body = openO365PowerShellRunspaceWithCertificate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OpenO365PowerShellRunspaceWithCertificateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse> IsO365PowerShellRunspaceOpen([WorkflowExpression] Func<string> isO365PowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isO365PowerShellRunspaceOpentestCommunications = null, [WorkflowExpression] Func<bool> isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        isO365PowerShellRunspaceOpen["TestCommunications"] = SourceExpressionConverter.ConvertToken(isO365PowerShellRunspaceOpentestCommunications);
                        isO365PowerShellRunspaceOpenpropCount++;
                    }

                    isO365PowerShellRunspaceOpenpropCount++;
                }
                else
                {
                    isO365PowerShellRunspaceOpen["TestCommunications"] = true;
                    isO365PowerShellRunspaceOpenpropCount++;
                }

                if (isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePId != null)
                {
                    if (isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePId != null)
                    {
                        isO365PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = SourceExpressionConverter.ConvertToken(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePId);
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
                isO365PowerShellRunspaceOpen["Workflow"] = SourceExpressionConverter.ConvertToken(isO365PowerShellRunspaceOpenworkflow);
                if (isO365PowerShellRunspaceOpenpropCount > 0)
                {
                    callPayload.Body = isO365PowerShellRunspaceOpen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsO365PowerShellRunspaceOpenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse> RunO365PowerShellAutomationScript([WorkflowExpression] Func<string> runO365PowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptlocalScope = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runO365PowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runO365PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/RunO365PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var runO365PowerShellAutomationScript = new JObject();
                var runO365PowerShellAutomationScriptpropCount = 0;
                if (runO365PowerShellAutomationScriptpowerShellScriptContents != null)
                {
                    runO365PowerShellAutomationScript["PowerShellScriptContents"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpowerShellScriptContents);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptisNoResultAnError != null)
                {
                    if (runO365PowerShellAutomationScriptisNoResultAnError != null)
                    {
                        runO365PowerShellAutomationScript["IsNoResultAnError"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptisNoResultAnError);
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
                        runO365PowerShellAutomationScript["ReturnComplexTypes"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnComplexTypes);
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
                        runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnBooleanAsBoolean);
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
                        runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnNumericAsDecimal);
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
                        runO365PowerShellAutomationScript["ReturnDateAsDate"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnDateAsDate);
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
                    runO365PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptlocalScope != null)
                {
                    runO365PowerShellAutomationScript["LocalScope"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptlocalScope);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    if (runO365PowerShellAutomationScriptrunScriptAsThread != null)
                    {
                        runO365PowerShellAutomationScript["RunScriptAsThread"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptrunScriptAsThread);
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
                    runO365PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    if (runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                    {
                        runO365PowerShellAutomationScript["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptsecondsToWaitForThread);
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
                        runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptscriptContainsStoredPassword);
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
                        runO365PowerShellAutomationScript["LogVerboseOutput"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptlogVerboseOutput);
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
                    runO365PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
                {
                    runO365PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                if (runO365PowerShellAutomationScriptpowerShellCommandParameters != null)
                {
                    runO365PowerShellAutomationScript["PowerShellCommandParameters"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpowerShellCommandParameters);
                    runO365PowerShellAutomationScriptpropCount++;
                }

                runO365PowerShellAutomationScriptpropCount++;
                runO365PowerShellAutomationScript["Workflow"] = SourceExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptworkflow);
                if (runO365PowerShellAutomationScriptpropCount > 0)
                {
                    callPayload.Body = runO365PowerShellAutomationScript;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RunO365PowerShellAutomationScriptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse> CloseO365PowerShellRunspace([WorkflowExpression] Func<string> closeO365PowerShellRunspaceworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/CloseO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var closeO365PowerShellRunspace = new JObject();
                var closeO365PowerShellRunspacepropCount = 0;
                closeO365PowerShellRunspacepropCount++;
                closeO365PowerShellRunspace["Workflow"] = SourceExpressionConverter.ConvertToken(closeO365PowerShellRunspaceworkflow);
                if (closeO365PowerShellRunspacepropCount > 0)
                {
                    callPayload.Body = closeO365PowerShellRunspace;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseO365PowerShellRunspaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365MailboxResponse> O365GetO365Mailbox([WorkflowExpression] Func<string> o365GetO365Mailboxworkflow, [WorkflowExpression] Func<string> o365GetO365Mailboxidentity = null, [WorkflowExpression] Func<string> o365GetO365MailboxfilterPropertyName = null, [WorkflowExpression] Func<o365GetO365MailboxfilterPropertyComparisonInput> o365GetO365MailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> o365GetO365MailboxfilterPropertyValue = null, [WorkflowExpression] Func<o365GetO365MailboxrecipientTypeDetailsInput> o365GetO365MailboxrecipientTypeDetails = null, [WorkflowExpression] Func<bool> o365GetO365MailboxnoResultIsAnException = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetO365Mailbox = new JObject();
                var o365GetO365MailboxpropCount = 0;
                if (o365GetO365Mailboxidentity != null)
                {
                    o365GetO365Mailbox["Identity"] = SourceExpressionConverter.ConvertToken(o365GetO365Mailboxidentity);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxfilterPropertyName != null)
                {
                    o365GetO365Mailbox["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(o365GetO365MailboxfilterPropertyName);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxfilterPropertyComparison != null)
                {
                    if (o365GetO365MailboxfilterPropertyComparison != null)
                    {
                        o365GetO365Mailbox["FilterPropertyComparison"] = SourceExpressionConverter.Convert(o365GetO365MailboxfilterPropertyComparison);
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
                    o365GetO365Mailbox["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(o365GetO365MailboxfilterPropertyValue);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxrecipientTypeDetails != null)
                {
                    o365GetO365Mailbox["RecipientTypeDetails"] = SourceExpressionConverter.Convert(o365GetO365MailboxrecipientTypeDetails);
                    o365GetO365MailboxpropCount++;
                }

                if (o365GetO365MailboxnoResultIsAnException != null)
                {
                    if (o365GetO365MailboxnoResultIsAnException != null)
                    {
                        o365GetO365Mailbox["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(o365GetO365MailboxnoResultIsAnException);
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
                o365GetO365Mailbox["Workflow"] = SourceExpressionConverter.ConvertToken(o365GetO365Mailboxworkflow);
                if (o365GetO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365GetO365Mailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365GetO365MailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse> O365AddMailboxPermission([WorkflowExpression] Func<string> o365AddMailboxPermissionidentity, [WorkflowExpression] Func<string> o365AddMailboxPermissionuser, [WorkflowExpression] Func<string> o365AddMailboxPermissionaccessRights, [WorkflowExpression] Func<string> o365AddMailboxPermissionworkflow, [WorkflowExpression] Func<bool> o365AddMailboxPermissionautoMapping = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365AddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365AddMailboxPermission = new JObject();
                var o365AddMailboxPermissionpropCount = 0;
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["Identity"] = SourceExpressionConverter.ConvertToken(o365AddMailboxPermissionidentity);
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["User"] = SourceExpressionConverter.ConvertToken(o365AddMailboxPermissionuser);
                o365AddMailboxPermissionpropCount++;
                o365AddMailboxPermission["AccessRights"] = SourceExpressionConverter.ConvertToken(o365AddMailboxPermissionaccessRights);
                if (o365AddMailboxPermissionautoMapping != null)
                {
                    if (o365AddMailboxPermissionautoMapping != null)
                    {
                        o365AddMailboxPermission["AutoMapping"] = SourceExpressionConverter.ConvertToken(o365AddMailboxPermissionautoMapping);
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
                o365AddMailboxPermission["Workflow"] = SourceExpressionConverter.ConvertToken(o365AddMailboxPermissionworkflow);
                if (o365AddMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = o365AddMailboxPermission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365AddMailboxPermissionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse> O365RemoveMailboxPermission([WorkflowExpression] Func<string> o365RemoveMailboxPermissionidentity, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionuser, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionaccessRights, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveMailboxPermission = new JObject();
                var o365RemoveMailboxPermissionpropCount = 0;
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["Identity"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxPermissionidentity);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["User"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxPermissionuser);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["AccessRights"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxPermissionaccessRights);
                o365RemoveMailboxPermissionpropCount++;
                o365RemoveMailboxPermission["Workflow"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxPermissionworkflow);
                if (o365RemoveMailboxPermissionpropCount > 0)
                {
                    callPayload.Body = o365RemoveMailboxPermission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365RemoveMailboxPermissionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse> O365AddDistributionGroupMember([WorkflowExpression] Func<string> o365AddDistributionGroupMemberidentity, [WorkflowExpression] Func<string> o365AddDistributionGroupMembermember, [WorkflowExpression] Func<string> o365AddDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365AddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365AddDistributionGroupMember = new JObject();
                var o365AddDistributionGroupMemberpropCount = 0;
                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Identity"] = SourceExpressionConverter.ConvertToken(o365AddDistributionGroupMemberidentity);
                o365AddDistributionGroupMemberpropCount++;
                o365AddDistributionGroupMember["Member"] = SourceExpressionConverter.ConvertToken(o365AddDistributionGroupMembermember);
                if (o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        o365AddDistributionGroupMember["BypassSecurityGroupManagerCheck"] = SourceExpressionConverter.ConvertToken(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
                o365AddDistributionGroupMember["Workflow"] = SourceExpressionConverter.ConvertToken(o365AddDistributionGroupMemberworkflow);
                if (o365AddDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = o365AddDistributionGroupMember;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365AddDistributionGroupMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse> O365GetO365DistributionGroup([WorkflowExpression] Func<string> o365GetO365DistributionGroupworkflow, [WorkflowExpression] Func<string> o365GetO365DistributionGroupidentity = null, [WorkflowExpression] Func<string> o365GetO365DistributionGroupfilterPropertyName = null, [WorkflowExpression] Func<o365GetO365DistributionGroupfilterPropertyComparisonInput> o365GetO365DistributionGroupfilterPropertyComparison = null, [WorkflowExpression] Func<string> o365GetO365DistributionGroupfilterPropertyValue = null, [WorkflowExpression] Func<bool> o365GetO365DistributionGroupnoResultIsAnException = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetO365DistributionGroup = new JObject();
                var o365GetO365DistributionGrouppropCount = 0;
                if (o365GetO365DistributionGroupidentity != null)
                {
                    o365GetO365DistributionGroup["Identity"] = SourceExpressionConverter.ConvertToken(o365GetO365DistributionGroupidentity);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupfilterPropertyName != null)
                {
                    o365GetO365DistributionGroup["FilterPropertyName"] = SourceExpressionConverter.ConvertToken(o365GetO365DistributionGroupfilterPropertyName);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupfilterPropertyComparison != null)
                {
                    if (o365GetO365DistributionGroupfilterPropertyComparison != null)
                    {
                        o365GetO365DistributionGroup["FilterPropertyComparison"] = SourceExpressionConverter.Convert(o365GetO365DistributionGroupfilterPropertyComparison);
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
                    o365GetO365DistributionGroup["FilterPropertyValue"] = SourceExpressionConverter.ConvertToken(o365GetO365DistributionGroupfilterPropertyValue);
                    o365GetO365DistributionGrouppropCount++;
                }

                if (o365GetO365DistributionGroupnoResultIsAnException != null)
                {
                    if (o365GetO365DistributionGroupnoResultIsAnException != null)
                    {
                        o365GetO365DistributionGroup["NoResultIsAnException"] = SourceExpressionConverter.ConvertToken(o365GetO365DistributionGroupnoResultIsAnException);
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
                o365GetO365DistributionGroup["Workflow"] = SourceExpressionConverter.ConvertToken(o365GetO365DistributionGroupworkflow);
                if (o365GetO365DistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365GetO365DistributionGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365GetO365DistributionGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse> O365NewO365DistributionGroup([WorkflowExpression] Func<string> o365NewO365DistributionGroupname, [WorkflowExpression] Func<string> o365NewO365DistributionGroupworkflow, [WorkflowExpression] Func<string> o365NewO365DistributionGroupalias = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupdisplayName = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupnotes = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupmanagedBy = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupmembers = null, [WorkflowExpression] Func<string> o365NewO365DistributionGrouporganizationalUnit = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupprimarySmtpAddress = null, [WorkflowExpression] Func<o365NewO365DistributionGroupmemberDepartRestrictionInput> o365NewO365DistributionGroupmemberDepartRestriction = null, [WorkflowExpression] Func<o365NewO365DistributionGroupmemberJoinRestrictionInput> o365NewO365DistributionGroupmemberJoinRestriction = null, [WorkflowExpression] Func<bool> o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = null, [WorkflowExpression] Func<o365NewO365DistributionGrouptypeInput> o365NewO365DistributionGrouptype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365NewO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewO365DistributionGroup = new JObject();
                var o365NewO365DistributionGrouppropCount = 0;
                o365NewO365DistributionGrouppropCount++;
                o365NewO365DistributionGroup["Name"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupname);
                if (o365NewO365DistributionGroupalias != null)
                {
                    o365NewO365DistributionGroup["Alias"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupalias);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupdisplayName != null)
                {
                    o365NewO365DistributionGroup["DisplayName"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupdisplayName);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupnotes != null)
                {
                    o365NewO365DistributionGroup["Notes"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupnotes);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmanagedBy != null)
                {
                    o365NewO365DistributionGroup["ManagedBy"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupmanagedBy);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmembers != null)
                {
                    o365NewO365DistributionGroup["Members"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupmembers);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGrouporganizationalUnit != null)
                {
                    o365NewO365DistributionGroup["OrganizationalUnit"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGrouporganizationalUnit);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupprimarySmtpAddress != null)
                {
                    o365NewO365DistributionGroup["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupprimarySmtpAddress);
                    o365NewO365DistributionGrouppropCount++;
                }

                if (o365NewO365DistributionGroupmemberDepartRestriction != null)
                {
                    if (o365NewO365DistributionGroupmemberDepartRestriction != null)
                    {
                        o365NewO365DistributionGroup["MemberDepartRestriction"] = SourceExpressionConverter.Convert(o365NewO365DistributionGroupmemberDepartRestriction);
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
                        o365NewO365DistributionGroup["MemberJoinRestriction"] = SourceExpressionConverter.Convert(o365NewO365DistributionGroupmemberJoinRestriction);
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
                        o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled);
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
                    o365NewO365DistributionGroup["Type"] = SourceExpressionConverter.Convert(o365NewO365DistributionGrouptype);
                    o365NewO365DistributionGrouppropCount++;
                }

                o365NewO365DistributionGrouppropCount++;
                o365NewO365DistributionGroup["Workflow"] = SourceExpressionConverter.ConvertToken(o365NewO365DistributionGroupworkflow);
                if (o365NewO365DistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365NewO365DistributionGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365NewO365DistributionGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse> O365RemoveDistributionGroup([WorkflowExpression] Func<string> o365RemoveDistributionGroupidentity, [WorkflowExpression] Func<string> o365RemoveDistributionGroupworkflow, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveDistributionGroup = new JObject();
                var o365RemoveDistributionGrouppropCount = 0;
                o365RemoveDistributionGrouppropCount++;
                o365RemoveDistributionGroup["Identity"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupidentity);
                if (o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    if (o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck);
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
                        o365RemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGrouperrorIfGroupDoesNotExist);
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
                o365RemoveDistributionGroup["Workflow"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupworkflow);
                if (o365RemoveDistributionGrouppropCount > 0)
                {
                    callPayload.Body = o365RemoveDistributionGroup;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365RemoveDistributionGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxResponse> O365SetO365Mailbox([WorkflowExpression] Func<string> o365SetO365Mailboxidentity, [WorkflowExpression] Func<string> o365SetO365Mailboxworkflow, [WorkflowExpression] Func<bool> o365SetO365MailboxaccountDisabled = null, [WorkflowExpression] Func<string> o365SetO365Mailboxalias = null, [WorkflowExpression] Func<string> o365SetO365MailboxdisplayName = null, [WorkflowExpression] Func<bool> o365SetO365MailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute4 = null, [WorkflowExpression] Func<o365SetO365MailboxtypeInput> o365SetO365Mailboxtype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365SetO365Mailbox = new JObject();
                var o365SetO365MailboxpropCount = 0;
                o365SetO365MailboxpropCount++;
                o365SetO365Mailbox["Identity"] = SourceExpressionConverter.ConvertToken(o365SetO365Mailboxidentity);
                if (o365SetO365MailboxaccountDisabled != null)
                {
                    o365SetO365Mailbox["AccountDisabled"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxaccountDisabled);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365Mailboxalias != null)
                {
                    o365SetO365Mailbox["Alias"] = SourceExpressionConverter.ConvertToken(o365SetO365Mailboxalias);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxdisplayName != null)
                {
                    o365SetO365Mailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxdisplayName);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxhiddenFromAddressListsEnabled != null)
                {
                    o365SetO365Mailbox["HiddenFromAddressListsEnabled"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxhiddenFromAddressListsEnabled);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute1 != null)
                {
                    o365SetO365Mailbox["CustomAttribute1"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute1);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute2 != null)
                {
                    o365SetO365Mailbox["CustomAttribute2"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute2);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute3 != null)
                {
                    o365SetO365Mailbox["CustomAttribute3"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute3);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365MailboxcustomAttribute4 != null)
                {
                    o365SetO365Mailbox["CustomAttribute4"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute4);
                    o365SetO365MailboxpropCount++;
                }

                if (o365SetO365Mailboxtype != null)
                {
                    o365SetO365Mailbox["Type"] = SourceExpressionConverter.Convert(o365SetO365Mailboxtype);
                    o365SetO365MailboxpropCount++;
                }

                o365SetO365MailboxpropCount++;
                o365SetO365Mailbox["Workflow"] = SourceExpressionConverter.ConvertToken(o365SetO365Mailboxworkflow);
                if (o365SetO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365SetO365Mailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365SetO365MailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse> O365WaitForO365Mailbox([WorkflowExpression] Func<string> o365WaitForO365Mailboxidentity, [WorkflowExpression] Func<int> o365WaitForO365MailboxnumberOfTimesToCheck, [WorkflowExpression] Func<int> o365WaitForO365MailboxsecondsBetweenTries, [WorkflowExpression] Func<string> o365WaitForO365Mailboxworkflow, [WorkflowExpression] Func<o365WaitForO365MailboxrecipientTypeDetailsInput> o365WaitForO365MailboxrecipientTypeDetails = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365WaitForO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365WaitForO365Mailbox = new JObject();
                var o365WaitForO365MailboxpropCount = 0;
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["Identity"] = SourceExpressionConverter.ConvertToken(o365WaitForO365Mailboxidentity);
                if (o365WaitForO365MailboxrecipientTypeDetails != null)
                {
                    o365WaitForO365Mailbox["RecipientTypeDetails"] = SourceExpressionConverter.Convert(o365WaitForO365MailboxrecipientTypeDetails);
                    o365WaitForO365MailboxpropCount++;
                }

                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["NumberOfTimesToCheck"] = SourceExpressionConverter.ConvertToken(o365WaitForO365MailboxnumberOfTimesToCheck);
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["SecondsBetweenTries"] = SourceExpressionConverter.ConvertToken(o365WaitForO365MailboxsecondsBetweenTries);
                o365WaitForO365MailboxpropCount++;
                o365WaitForO365Mailbox["Workflow"] = SourceExpressionConverter.ConvertToken(o365WaitForO365Mailboxworkflow);
                if (o365WaitForO365MailboxpropCount > 0)
                {
                    callPayload.Body = o365WaitForO365Mailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365WaitForO365MailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse> O365SetO365MailboxAutoReplyConfiguration([WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationidentity, [WorkflowExpression] Func<o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput> o365SetO365MailboxAutoReplyConfigurationautoReplyState, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationworkflow, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationinternalMessage = null, [WorkflowExpression] Func<o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput> o365SetO365MailboxAutoReplyConfigurationexternalAudience = null, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationexternalMessage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365MailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365SetO365MailboxAutoReplyConfiguration = new JObject();
                var o365SetO365MailboxAutoReplyConfigurationpropCount = 0;
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["Identity"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationidentity);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["AutoReplyState"] = SourceExpressionConverter.Convert(o365SetO365MailboxAutoReplyConfigurationautoReplyState);
                if (o365SetO365MailboxAutoReplyConfigurationinternalMessage != null)
                {
                    o365SetO365MailboxAutoReplyConfiguration["InternalMessage"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationinternalMessage);
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                if (o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                {
                    if (o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                    {
                        o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = SourceExpressionConverter.Convert(o365SetO365MailboxAutoReplyConfigurationexternalAudience);
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
                    o365SetO365MailboxAutoReplyConfiguration["ExternalMessage"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationexternalMessage);
                    o365SetO365MailboxAutoReplyConfigurationpropCount++;
                }

                o365SetO365MailboxAutoReplyConfigurationpropCount++;
                o365SetO365MailboxAutoReplyConfiguration["Workflow"] = SourceExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationworkflow);
                if (o365SetO365MailboxAutoReplyConfigurationpropCount > 0)
                {
                    callPayload.Body = o365SetO365MailboxAutoReplyConfiguration;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365SetO365MailboxAutoReplyConfigurationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse> O365RemoveDistributionGroupMember([WorkflowExpression] Func<string> o365RemoveDistributionGroupMembergroupIdentity, [WorkflowExpression] Func<string> o365RemoveDistributionGroupMembermember, [WorkflowExpression] Func<string> o365RemoveDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveDistributionGroupMember = new JObject();
                var o365RemoveDistributionGroupMemberpropCount = 0;
                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["GroupIdentity"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupMembergroupIdentity);
                o365RemoveDistributionGroupMemberpropCount++;
                o365RemoveDistributionGroupMember["Member"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupMembermember);
                if (o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    if (o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
                        o365RemoveDistributionGroupMember["ExceptionIfMemberNotInGroup"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup);
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
                o365RemoveDistributionGroupMember["Workflow"] = SourceExpressionConverter.ConvertToken(o365RemoveDistributionGroupMemberworkflow);
                if (o365RemoveDistributionGroupMemberpropCount > 0)
                {
                    callPayload.Body = o365RemoveDistributionGroupMember;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365RemoveDistributionGroupMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse> O365GetMailboxDistributionGroupMembership([WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershipmailboxIdentity, [WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershipworkflow, [WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365GetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetMailboxDistributionGroupMembership = new JObject();
                var o365GetMailboxDistributionGroupMembershippropCount = 0;
                o365GetMailboxDistributionGroupMembershippropCount++;
                o365GetMailboxDistributionGroupMembership["MailboxIdentity"] = SourceExpressionConverter.ConvertToken(o365GetMailboxDistributionGroupMembershipmailboxIdentity);
                if (o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON != null)
                {
                    o365GetMailboxDistributionGroupMembership["PropertiesToRetrieveJSON"] = SourceExpressionConverter.ConvertToken(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON);
                    o365GetMailboxDistributionGroupMembershippropCount++;
                }

                o365GetMailboxDistributionGroupMembershippropCount++;
                o365GetMailboxDistributionGroupMembership["Workflow"] = SourceExpressionConverter.ConvertToken(o365GetMailboxDistributionGroupMembershipworkflow);
                if (o365GetMailboxDistributionGroupMembershippropCount > 0)
                {
                    callPayload.Body = o365GetMailboxDistributionGroupMembership;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365GetMailboxDistributionGroupMembershipResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse> O365GetDistributionGroupMembers([WorkflowExpression] Func<string> o365GetDistributionGroupMembersgroupIdentity, [WorkflowExpression] Func<string> o365GetDistributionGroupMembersworkflow, [WorkflowExpression] Func<string> o365GetDistributionGroupMemberspropertiesToRetrieveJSON = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365GetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365GetDistributionGroupMembers = new JObject();
                var o365GetDistributionGroupMemberspropCount = 0;
                o365GetDistributionGroupMemberspropCount++;
                o365GetDistributionGroupMembers["GroupIdentity"] = SourceExpressionConverter.ConvertToken(o365GetDistributionGroupMembersgroupIdentity);
                if (o365GetDistributionGroupMemberspropertiesToRetrieveJSON != null)
                {
                    o365GetDistributionGroupMembers["PropertiesToRetrieveJSON"] = SourceExpressionConverter.ConvertToken(o365GetDistributionGroupMemberspropertiesToRetrieveJSON);
                    o365GetDistributionGroupMemberspropCount++;
                }

                o365GetDistributionGroupMemberspropCount++;
                o365GetDistributionGroupMembers["Workflow"] = SourceExpressionConverter.ConvertToken(o365GetDistributionGroupMembersworkflow);
                if (o365GetDistributionGroupMemberspropCount > 0)
                {
                    callPayload.Body = o365GetDistributionGroupMembers;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365GetDistributionGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse> O365RemoveMailboxFromAllDistributionGroups([WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsworkflow, [WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsrunAsThread = null, [WorkflowExpression] Func<int> o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxFromAllDistributionGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365RemoveMailboxFromAllDistributionGroups = new JObject();
                var o365RemoveMailboxFromAllDistributionGroupspropCount = 0;
                if (o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["MailboxIdentity"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck);
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
                        o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove);
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
                        o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove);
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
                    o365RemoveMailboxFromAllDistributionGroups["GroupDNsToExcludeJSON"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsrunAsThread);
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
                    o365RemoveMailboxFromAllDistributionGroups["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId);
                    o365RemoveMailboxFromAllDistributionGroupspropCount++;
                }

                if (o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                {
                    if (o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                    {
                        o365RemoveMailboxFromAllDistributionGroups["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread);
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
                o365RemoveMailboxFromAllDistributionGroups["Workflow"] = SourceExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsworkflow);
                if (o365RemoveMailboxFromAllDistributionGroupspropCount > 0)
                {
                    callPayload.Body = o365RemoveMailboxFromAllDistributionGroups;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewMailboxResponse> O365NewMailbox([WorkflowExpression] Func<string> o365NewMailboxmicrosoftOnlineServicesId, [WorkflowExpression] Func<string> o365NewMailboxname, [WorkflowExpression] Func<string> o365NewMailboxworkflow, [WorkflowExpression] Func<string> o365NewMailboxfirstName = null, [WorkflowExpression] Func<string> o365NewMailboxlastName = null, [WorkflowExpression] Func<string> o365NewMailboxinitials = null, [WorkflowExpression] Func<string> o365NewMailboxdisplayName = null, [WorkflowExpression] Func<string> o365NewMailboxalias = null, [WorkflowExpression] Func<string> o365NewMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> o365NewMailboxpassword = null, [WorkflowExpression] Func<bool> o365NewMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> o365NewMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<bool> o365NewMailboxarchive = null, [WorkflowExpression] Func<string> o365NewMailboxmailboxPlan = null, [WorkflowExpression] Func<string> o365NewMailboxmailboxRegion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365NewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewMailbox = new JObject();
                var o365NewMailboxpropCount = 0;
                o365NewMailboxpropCount++;
                o365NewMailbox["MicrosoftOnlineServicesID"] = SourceExpressionConverter.ConvertToken(o365NewMailboxmicrosoftOnlineServicesId);
                o365NewMailboxpropCount++;
                o365NewMailbox["Name"] = SourceExpressionConverter.ConvertToken(o365NewMailboxname);
                if (o365NewMailboxfirstName != null)
                {
                    o365NewMailbox["FirstName"] = SourceExpressionConverter.ConvertToken(o365NewMailboxfirstName);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxlastName != null)
                {
                    o365NewMailbox["LastName"] = SourceExpressionConverter.ConvertToken(o365NewMailboxlastName);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxinitials != null)
                {
                    o365NewMailbox["Initials"] = SourceExpressionConverter.ConvertToken(o365NewMailboxinitials);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxdisplayName != null)
                {
                    o365NewMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(o365NewMailboxdisplayName);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxalias != null)
                {
                    o365NewMailbox["Alias"] = SourceExpressionConverter.ConvertToken(o365NewMailboxalias);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxprimarySmtpAddress != null)
                {
                    o365NewMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(o365NewMailboxprimarySmtpAddress);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxpassword != null)
                {
                    o365NewMailbox["Password"] = SourceExpressionConverter.ConvertToken(o365NewMailboxpassword);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxaccountPasswordIsStoredPassword != null)
                {
                    if (o365NewMailboxaccountPasswordIsStoredPassword != null)
                    {
                        o365NewMailbox["AccountPasswordIsStoredPassword"] = SourceExpressionConverter.ConvertToken(o365NewMailboxaccountPasswordIsStoredPassword);
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
                        o365NewMailbox["ResetPasswordOnNextLogon"] = SourceExpressionConverter.ConvertToken(o365NewMailboxresetPasswordOnNextLogon);
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
                        o365NewMailbox["Archive"] = SourceExpressionConverter.ConvertToken(o365NewMailboxarchive);
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
                    o365NewMailbox["MailboxPlan"] = SourceExpressionConverter.ConvertToken(o365NewMailboxmailboxPlan);
                    o365NewMailboxpropCount++;
                }

                if (o365NewMailboxmailboxRegion != null)
                {
                    o365NewMailbox["MailboxRegion"] = SourceExpressionConverter.ConvertToken(o365NewMailboxmailboxRegion);
                    o365NewMailboxpropCount++;
                }

                o365NewMailboxpropCount++;
                o365NewMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(o365NewMailboxworkflow);
                if (o365NewMailboxpropCount > 0)
                {
                    callPayload.Body = o365NewMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365NewMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse> O365NewSharedMailbox([WorkflowExpression] Func<string> o365NewSharedMailboxname, [WorkflowExpression] Func<string> o365NewSharedMailboxworkflow, [WorkflowExpression] Func<string> o365NewSharedMailboxfirstName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxlastName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxinitials = null, [WorkflowExpression] Func<string> o365NewSharedMailboxdisplayName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxalias = null, [WorkflowExpression] Func<string> o365NewSharedMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> o365NewSharedMailboxarchive = null, [WorkflowExpression] Func<string> o365NewSharedMailboxmailboxRegion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365NewSharedMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365NewSharedMailbox = new JObject();
                var o365NewSharedMailboxpropCount = 0;
                o365NewSharedMailboxpropCount++;
                o365NewSharedMailbox["Name"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxname);
                if (o365NewSharedMailboxfirstName != null)
                {
                    o365NewSharedMailbox["FirstName"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxfirstName);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxlastName != null)
                {
                    o365NewSharedMailbox["LastName"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxlastName);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxinitials != null)
                {
                    o365NewSharedMailbox["Initials"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxinitials);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxdisplayName != null)
                {
                    o365NewSharedMailbox["DisplayName"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxdisplayName);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxalias != null)
                {
                    o365NewSharedMailbox["Alias"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxalias);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxprimarySmtpAddress != null)
                {
                    o365NewSharedMailbox["PrimarySmtpAddress"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxprimarySmtpAddress);
                    o365NewSharedMailboxpropCount++;
                }

                if (o365NewSharedMailboxarchive != null)
                {
                    if (o365NewSharedMailboxarchive != null)
                    {
                        o365NewSharedMailbox["Archive"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxarchive);
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
                    o365NewSharedMailbox["MailboxRegion"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxmailboxRegion);
                    o365NewSharedMailboxpropCount++;
                }

                o365NewSharedMailboxpropCount++;
                o365NewSharedMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(o365NewSharedMailboxworkflow);
                if (o365NewSharedMailboxpropCount > 0)
                {
                    callPayload.Body = o365NewSharedMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365NewSharedMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse> O365EnableArchiveMailbox([WorkflowExpression] Func<string> o365EnableArchiveMailboxidentity, [WorkflowExpression] Func<string> o365EnableArchiveMailboxworkflow, [WorkflowExpression] Func<bool> o365EnableArchiveMailboxcheckIfArchiveExists = null, [WorkflowExpression] Func<string> o365EnableArchiveMailboxarchiveName = null, [WorkflowExpression] Func<bool> o365EnableArchiveMailboxautoExpandingArchive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365EnableArchiveMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365EnableArchiveMailbox = new JObject();
                var o365EnableArchiveMailboxpropCount = 0;
                o365EnableArchiveMailboxpropCount++;
                o365EnableArchiveMailbox["Identity"] = SourceExpressionConverter.ConvertToken(o365EnableArchiveMailboxidentity);
                if (o365EnableArchiveMailboxcheckIfArchiveExists != null)
                {
                    if (o365EnableArchiveMailboxcheckIfArchiveExists != null)
                    {
                        o365EnableArchiveMailbox["CheckIfArchiveExists"] = SourceExpressionConverter.ConvertToken(o365EnableArchiveMailboxcheckIfArchiveExists);
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
                    o365EnableArchiveMailbox["ArchiveName"] = SourceExpressionConverter.ConvertToken(o365EnableArchiveMailboxarchiveName);
                    o365EnableArchiveMailboxpropCount++;
                }

                if (o365EnableArchiveMailboxautoExpandingArchive != null)
                {
                    if (o365EnableArchiveMailboxautoExpandingArchive != null)
                    {
                        o365EnableArchiveMailbox["AutoExpandingArchive"] = SourceExpressionConverter.ConvertToken(o365EnableArchiveMailboxautoExpandingArchive);
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
                o365EnableArchiveMailbox["Workflow"] = SourceExpressionConverter.ConvertToken(o365EnableArchiveMailboxworkflow);
                if (o365EnableArchiveMailboxpropCount > 0)
                {
                    callPayload.Body = o365EnableArchiveMailbox;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365EnableArchiveMailboxResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse> O365DoesMailboxHaveAnArchive([WorkflowExpression] Func<string> o365DoesMailboxHaveAnArchiveidentity, [WorkflowExpression] Func<string> o365DoesMailboxHaveAnArchiveworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/O365DoesMailboxHaveAnArchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var o365DoesMailboxHaveAnArchive = new JObject();
                var o365DoesMailboxHaveAnArchivepropCount = 0;
                o365DoesMailboxHaveAnArchivepropCount++;
                o365DoesMailboxHaveAnArchive["Identity"] = SourceExpressionConverter.ConvertToken(o365DoesMailboxHaveAnArchiveidentity);
                o365DoesMailboxHaveAnArchivepropCount++;
                o365DoesMailboxHaveAnArchive["Workflow"] = SourceExpressionConverter.ConvertToken(o365DoesMailboxHaveAnArchiveworkflow);
                if (o365DoesMailboxHaveAnArchivepropCount > 0)
                {
                    callPayload.Body = o365DoesMailboxHaveAnArchive;
                }
                return callPayload;
            }

            return new ApiConnectionAction<O365DoesMailboxHaveAnArchiveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse> JMLGetNextAvailableAccountName([WorkflowExpression] Func<string> jMLGetNextAvailableAccountNameworkflow, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefirstName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamemiddleName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamelastName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldA = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldB = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldC = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldD = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableMStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableNStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableXStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamemaxAttempts = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNamefallbackCausesRetest = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamenumbersNotToUse = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamesequenceA1 = null, [WorkflowExpression] Func<jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem[]> jMLGetNextAvailableAccountNamepropertiesToCheckList = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/JMLGetNextAvailableAccountName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jMLGetNextAvailableAccountName = new JObject();
                var jMLGetNextAvailableAccountNamepropCount = 0;
                if (jMLGetNextAvailableAccountNamefirstName != null)
                {
                    jMLGetNextAvailableAccountName["FirstName"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefirstName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamemiddleName != null)
                {
                    jMLGetNextAvailableAccountName["MiddleName"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamemiddleName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamelastName != null)
                {
                    jMLGetNextAvailableAccountName["LastName"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamelastName);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldA != null)
                {
                    jMLGetNextAvailableAccountName["FieldA"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldA);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldB != null)
                {
                    jMLGetNextAvailableAccountName["FieldB"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldB);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldC != null)
                {
                    jMLGetNextAvailableAccountName["FieldC"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldC);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamefieldD != null)
                {
                    jMLGetNextAvailableAccountName["FieldD"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldD);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamevariableMStartValue != null)
                {
                    if (jMLGetNextAvailableAccountNamevariableMStartValue != null)
                    {
                        jMLGetNextAvailableAccountName["VariableMStartValue"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamevariableMStartValue);
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
                        jMLGetNextAvailableAccountName["VariableNStartValue"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamevariableNStartValue);
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
                        jMLGetNextAvailableAccountName["VariableXStartValue"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamevariableXStartValue);
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
                        jMLGetNextAvailableAccountName["MaxAttempts"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamemaxAttempts);
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
                        jMLGetNextAvailableAccountName["FallbackCausesRetest"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefallbackCausesRetest);
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
                    jMLGetNextAvailableAccountName["NumbersNotToUse"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamenumbersNotToUse);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs != null)
                {
                    jMLGetNextAvailableAccountName["CharactersToRemoveFromInputs"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                {
                    if (jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                    {
                        jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs);
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
                        jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs);
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
                    jMLGetNextAvailableAccountName["SequenceA1"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamesequenceA1);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                if (jMLGetNextAvailableAccountNamepropertiesToCheckList != null)
                {
                    jMLGetNextAvailableAccountName["PropertiesToCheckList"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamepropertiesToCheckList);
                    jMLGetNextAvailableAccountNamepropCount++;
                }

                jMLGetNextAvailableAccountNamepropCount++;
                jMLGetNextAvailableAccountName["Workflow"] = SourceExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNameworkflow);
                if (jMLGetNextAvailableAccountNamepropCount > 0)
                {
                    callPayload.Body = jMLGetNextAvailableAccountName;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JMLGetNextAvailableAccountNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse> JMLConnectToJMLEnvironment([WorkflowExpression] Func<string> jMLConnectToJMLEnvironmentworkflow, [WorkflowExpression] Func<string> jMLConnectToJMLEnvironmentfriendlyName = null, [WorkflowExpression] Func<bool> jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PowerShellAutomation/JMLConnectToJMLEnvironment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jMLConnectToJMLEnvironment = new JObject();
                var jMLConnectToJMLEnvironmentpropCount = 0;
                if (jMLConnectToJMLEnvironmentfriendlyName != null)
                {
                    jMLConnectToJMLEnvironment["FriendlyName"] = SourceExpressionConverter.ConvertToken(jMLConnectToJMLEnvironmentfriendlyName);
                    jMLConnectToJMLEnvironmentpropCount++;
                }

                if (jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                {
                    if (jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                    {
                        jMLConnectToJMLEnvironment["OnlyConnectIfNotAlreadyConnected"] = SourceExpressionConverter.ConvertToken(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected);
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
                jMLConnectToJMLEnvironment["Workflow"] = SourceExpressionConverter.ConvertToken(jMLConnectToJMLEnvironmentworkflow);
                if (jMLConnectToJMLEnvironmentpropCount > 0)
                {
                    callPayload.Body = jMLConnectToJMLEnvironment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JMLConnectToJMLEnvironmentResponse>(BuildSourceInput);
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