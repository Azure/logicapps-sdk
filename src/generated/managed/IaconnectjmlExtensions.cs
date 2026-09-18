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
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse> RunActiveDirectoryPowerShellAutomationScript([WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse> OpenActiveDirectoryPowerShellRunspaceWithCredentials([WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsusername, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialspassword, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, [WorkflowExpression] Func<string> openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = null, [WorkflowExpression] Func<bool> openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = null, [WorkflowExpression] Func<int> openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse> CloseActiveDirectoryPowerShellRunspace([WorkflowExpression] Func<string> closeActiveDirectoryPowerShellRunspaceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse> IsActiveDirectoryPowerShellRunspaceOpen([WorkflowExpression] Func<string> isActiveDirectoryPowerShellRunspaceOpenworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse> OpenLocalPassthroughActiveDirectoryPowerShellRunspace([WorkflowExpression] Func<string> openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse> ActiveDirectoryAddADUser([WorkflowExpression] Func<string> activeDirectoryAddADUsername, [WorkflowExpression] Func<string> activeDirectoryAddADUserworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADUseruserPrincipalName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsersamAccountName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsergivenName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUsersurName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserpath = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddADUseraccountPassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUseraccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserenabled = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserchangePasswordAtLogon = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUsercannotChangePassword = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserpasswordNeverExpires = null, [WorkflowExpression] Func<string> activeDirectoryAddADUseraDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse> ActiveDirectoryGetADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityidentity = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityfilterPropertyName = null, [WorkflowExpression] Func<activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput> activeDirectoryGetADUserByIdentityfilterPropertyComparison = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityfilterPropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitysearchOUBase = null, [WorkflowExpression] Func<bool> activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityproperties = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentityaDServer = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse> ActiveDirectoryGetOUFromUserDN([WorkflowExpression] Func<string> activeDirectoryGetOUFromUserDNuserDN, [WorkflowExpression] Func<string> activeDirectoryGetOUFromUserDNworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse> ActiveDirectoryGetDomainFQDNFromDN([WorkflowExpression] Func<string> activeDirectoryGetDomainFQDNFromDNdN, [WorkflowExpression] Func<string> activeDirectoryGetDomainFQDNFromDNworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse> ActiveDirectoryGetADGroupByIdentity([WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityidentity = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityfilterPropertyName = null, [WorkflowExpression] Func<activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput> activeDirectoryGetADGroupByIdentityfilterPropertyComparison = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityfilterPropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentitysearchOUBase = null, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = null, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse> ActiveDirectoryAddADGroupMemberByIdentity([WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentitygroupName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupMemberByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse> ActiveDirectoryAddMultipleADGroupMembersByIdentity([WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = null, [WorkflowExpression] Func<string> activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse> ActiveDirectoryAddADUserToMultipleADGroupsByName([WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = null, [WorkflowExpression] Func<bool> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = null, [WorkflowExpression] Func<string> activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = null, [WorkflowExpression] Func<int> activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse> ActiveDirectoryGetADUserGroupMembership([WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipuserIdentity, [WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipworkflow, [WorkflowExpression] Func<string> activeDirectoryGetADUserGroupMembershipaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse> ActiveDirectoryModifyADUserStringPropertyByIdentity([WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityworkflow, [WorkflowExpression] Func<activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem[]> activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserStringPropertyByIdentityaDServer = null, [WorkflowExpression] Func<bool> activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse> ActiveDirectoryModifyADUserBooleanPropertyByIdentity([WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse> ActiveDirectoryModifyADUserProperties([WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesuserIdentity, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesworkflow, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescity = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescompany = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountry = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountryString = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiescountryISO3166 = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdepartment = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdescription = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesemailAddress = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesgivenName = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertieshomePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesinitials = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesiPPhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesmanager = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesmobilePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesnotes = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesoffice = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesofficePhone = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiespostalCode = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesprofilePath = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesscriptPath = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesstate = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesstreetAddress = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiessurname = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiestitle = null, [WorkflowExpression] Func<string> activeDirectoryModifyADUserPropertiesaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse> ActiveDirectoryMoveADUserToOUByIdentity([WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentitytargetPath, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryMoveADUserToOUByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse> ActiveDirectoryClearADUserAccountExpiration([WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationuserIdentity, [WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationworkflow, [WorkflowExpression] Func<string> activeDirectoryClearADUserAccountExpirationaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse> ActiveDirectoryDirSync([WorkflowExpression] Func<string> activeDirectoryDirSyncworkflow, [WorkflowExpression] Func<activeDirectoryDirSyncpolicyTypeInput> activeDirectoryDirSyncpolicyType = null, [WorkflowExpression] Func<string> activeDirectoryDirSynccomputerName = null, [WorkflowExpression] Func<int> activeDirectoryDirSyncmaxRetryAttempts = null, [WorkflowExpression] Func<int> activeDirectoryDirSyncsecondsBetweenRetries = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse> ActiveDirectoryRemoveADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse> ActiveDirectoryResetADUserPasswordByIdentity([WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentitynewPassword, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityworkflow, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = null, [WorkflowExpression] Func<bool> activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = null, [WorkflowExpression] Func<string> activeDirectoryResetADUserPasswordByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity([WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, [WorkflowExpression] Func<bool> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, [WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse> ActiveDirectoryDisableADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryDisableADUserByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse> ActiveDirectoryEnableADUserByIdentity([WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryEnableADUserByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse> ActiveDirectorySetADUserHomeFolderByIdentity([WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityhomeDrive = null, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = null, [WorkflowExpression] Func<bool> activeDirectorySetADUserHomeFolderByIdentitycreateFolder = null, [WorkflowExpression] Func<string> activeDirectorySetADUserHomeFolderByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse> ActiveDirectoryCloneADUserGroups([WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupssourceUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsdestinationUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsworkflow, [WorkflowExpression] Func<string> activeDirectoryCloneADUserGroupsaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse> ActiveDirectoryCloneADUserProperties([WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiessourceUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesdestinationUserIdentity, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiespropertiesToClone, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesworkflow, [WorkflowExpression] Func<string> activeDirectoryCloneADUserPropertiesaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName([WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse> ActiveDirectoryRemoveADUserFromAllGroups([WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsuserIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADUserFromAllGroupsaDServer = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADUserFromAllGroupsrunAsThread = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse> ActiveDirectoryCheckOUExists([WorkflowExpression] Func<string> activeDirectoryCheckOUExistsoUIdentity, [WorkflowExpression] Func<string> activeDirectoryCheckOUExistsworkflow, [WorkflowExpression] Func<string> activeDirectoryCheckOUExistsaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse> ActiveDirectoryRemoveADGroupMemberByGroupIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity([WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = null, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = null, [WorkflowExpression] Func<string> activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse> ActiveDirectoryUnlockADAccountByIdentity([WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityuserIdentity, [WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityworkflow, [WorkflowExpression] Func<string> activeDirectoryUnlockADAccountByIdentityaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse> ActiveDirectorySetADServer([WorkflowExpression] Func<string> activeDirectorySetADServerworkflow, [WorkflowExpression] Func<activeDirectorySetADServerpredefinedADServerChoiceInput> activeDirectorySetADServerpredefinedADServerChoice = null, [WorkflowExpression] Func<string> activeDirectorySetADServeraDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse> ActiveDirectoryGetDomainInfo([WorkflowExpression] Func<string> activeDirectoryGetDomainInfoworkflow, [WorkflowExpression] Func<string> activeDirectoryGetDomainInfoaDServer = null, [WorkflowExpression] Func<activeDirectoryGetDomainInfopredefinedIdentityInput> activeDirectoryGetDomainInfopredefinedIdentity = null, [WorkflowExpression] Func<string> activeDirectoryGetDomainInfoidentity = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse> ActiveDirectoryAddADGroup([WorkflowExpression] Func<string> activeDirectoryAddADGroupname, [WorkflowExpression] Func<activeDirectoryAddADGroupgroupCategoryInput> activeDirectoryAddADGroupgroupCategory, [WorkflowExpression] Func<activeDirectoryAddADGroupgroupScopeInput> activeDirectoryAddADGroupgroupScope, [WorkflowExpression] Func<string> activeDirectoryAddADGroupworkflow, [WorkflowExpression] Func<string> activeDirectoryAddADGroupsamAccountName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGrouppath = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupnotes = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddADGrouphomePage = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupmanagedBy = null, [WorkflowExpression] Func<bool> activeDirectoryAddADGroupprotectedFromAccidentalDeletion = null, [WorkflowExpression] Func<string> activeDirectoryAddADGroupaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse> ActiveDirectoryDoesADGroupExist([WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistworkflow, [WorkflowExpression] Func<string> activeDirectoryDoesADGroupExistaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse> ActiveDirectoryRemoveADGroup([WorkflowExpression] Func<string> activeDirectoryRemoveADGroupgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveADGroupdeleteEvenIfProtected = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveADGroupaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse> ActiveDirectoryAddOU([WorkflowExpression] Func<string> activeDirectoryAddOUname, [WorkflowExpression] Func<string> activeDirectoryAddOUworkflow, [WorkflowExpression] Func<string> activeDirectoryAddOUpath = null, [WorkflowExpression] Func<string> activeDirectoryAddOUdescription = null, [WorkflowExpression] Func<string> activeDirectoryAddOUdisplayName = null, [WorkflowExpression] Func<string> activeDirectoryAddOUmanagedBy = null, [WorkflowExpression] Func<bool> activeDirectoryAddOUprotectedFromAccidentalDeletion = null, [WorkflowExpression] Func<string> activeDirectoryAddOUstreetAddress = null, [WorkflowExpression] Func<string> activeDirectoryAddOUcity = null, [WorkflowExpression] Func<string> activeDirectoryAddOUstate = null, [WorkflowExpression] Func<string> activeDirectoryAddOUpostalCode = null, [WorkflowExpression] Func<string> activeDirectoryAddOUaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse> ActiveDirectoryRemoveOU([WorkflowExpression] Func<string> activeDirectoryRemoveOUoUIdentity, [WorkflowExpression] Func<string> activeDirectoryRemoveOUworkflow, [WorkflowExpression] Func<bool> activeDirectoryRemoveOUdeleteEvenIfProtected = null, [WorkflowExpression] Func<bool> activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = null, [WorkflowExpression] Func<string> activeDirectoryRemoveOUaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse> ActiveDirectorySetADUserAccountExpirationEndOfDate([WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDateyear, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDatemonth, [WorkflowExpression] Func<int> activeDirectorySetADUserAccountExpirationEndOfDateday, [WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateworkflow, [WorkflowExpression] Func<string> activeDirectorySetADUserAccountExpirationEndOfDateaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse> ActiveDirectoryGetADGroupMembers([WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersgroupIdentity, [WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersworkflow, [WorkflowExpression] Func<bool> activeDirectoryGetADGroupMembersrecursive = null, [WorkflowExpression] Func<string> activeDirectoryGetADGroupMembersaDServer = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse> OpenExchangePowerShellRunspace([WorkflowExpression] Func<string> openExchangePowerShellRunspaceexchangeServerFQDN, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceusername = null, [WorkflowExpression] Func<string> openExchangePowerShellRunspacepassword = null, [WorkflowExpression] Func<bool> openExchangePowerShellRunspaceuseSSL = null, [WorkflowExpression] Func<openExchangePowerShellRunspaceconnectionMethodInput> openExchangePowerShellRunspaceconnectionMethod = null, [WorkflowExpression] Func<openExchangePowerShellRunspaceauthenticationMechanismInput> openExchangePowerShellRunspaceauthenticationMechanism = null, [WorkflowExpression] Func<bool> openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openExchangePowerShellRunspacecommandTypesToImportLocallyInput> openExchangePowerShellRunspacecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse> IsExchangePowerShellRunspaceOpen([WorkflowExpression] Func<string> isExchangePowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isExchangePowerShellRunspaceOpentestCommunications = null, [WorkflowExpression] Func<bool> isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse> RunExchangePowerShellAutomationScript([WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runExchangePowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runExchangePowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runExchangePowerShellAutomationScriptpowerShellCommandParameters = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse> CloseExchangePowerShellRunspace([WorkflowExpression] Func<string> closeExchangePowerShellRunspaceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse> ExchangeGetMailbox([WorkflowExpression] Func<string> exchangeGetMailboxworkflow, [WorkflowExpression] Func<string> exchangeGetMailboxidentity = null, [WorkflowExpression] Func<string> exchangeGetMailboxfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetMailboxfilterPropertyComparisonInput> exchangeGetMailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetMailboxfilterPropertyValue = null, [WorkflowExpression] Func<exchangeGetMailboxrecipientTypeDetailsInput> exchangeGetMailboxrecipientTypeDetails = null, [WorkflowExpression] Func<bool> exchangeGetMailboxnoResultIsAnException = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse> ExchangeDoesMailboxExist([WorkflowExpression] Func<string> exchangeDoesMailboxExistworkflow, [WorkflowExpression] Func<string> exchangeDoesMailboxExistidentity = null, [WorkflowExpression] Func<string> exchangeDoesMailboxExistfilterPropertyName = null, [WorkflowExpression] Func<exchangeDoesMailboxExistfilterPropertyComparisonInput> exchangeDoesMailboxExistfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeDoesMailboxExistfilterPropertyValue = null, [WorkflowExpression] Func<exchangeDoesMailboxExistrecipientTypeDetailsInput> exchangeDoesMailboxExistrecipientTypeDetails = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse> ExchangeAddDistributionGroupMember([WorkflowExpression] Func<string> exchangeAddDistributionGroupMemberidentity, [WorkflowExpression] Func<string> exchangeAddDistributionGroupMembermember, [WorkflowExpression] Func<string> exchangeAddDistributionGroupMemberworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse> ExchangeRemoveDistributionGroupMember([WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMemberidentity, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMembermember, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse> ExchangeGetDistributionGroup([WorkflowExpression] Func<string> exchangeGetDistributionGroupworkflow, [WorkflowExpression] Func<string> exchangeGetDistributionGroupidentity = null, [WorkflowExpression] Func<string> exchangeGetDistributionGroupfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetDistributionGroupfilterPropertyComparisonInput> exchangeGetDistributionGroupfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetDistributionGroupfilterPropertyValue = null, [WorkflowExpression] Func<bool> exchangeGetDistributionGroupnoResultIsAnException = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse> ExchangeGetDistributionGroupMembers([WorkflowExpression] Func<string> exchangeGetDistributionGroupMembersidentity, [WorkflowExpression] Func<string> exchangeGetDistributionGroupMembersworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse> ExchangeGetMailboxDistributionGroupMembership([WorkflowExpression] Func<string> exchangeGetMailboxDistributionGroupMembershipidentity, [WorkflowExpression] Func<string> exchangeGetMailboxDistributionGroupMembershipworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse> ExchangeNewDistributionGroup([WorkflowExpression] Func<string> exchangeNewDistributionGroupname, [WorkflowExpression] Func<string> exchangeNewDistributionGroupworkflow, [WorkflowExpression] Func<string> exchangeNewDistributionGroupalias = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupdisplayName = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupnotes = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupmanagedBy = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupmembers = null, [WorkflowExpression] Func<string> exchangeNewDistributionGrouporganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewDistributionGroupprimarySmtpAddress = null, [WorkflowExpression] Func<exchangeNewDistributionGroupmemberDepartRestrictionInput> exchangeNewDistributionGroupmemberDepartRestriction = null, [WorkflowExpression] Func<exchangeNewDistributionGroupmemberJoinRestrictionInput> exchangeNewDistributionGroupmemberJoinRestriction = null, [WorkflowExpression] Func<bool> exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = null, [WorkflowExpression] Func<exchangeNewDistributionGrouptypeInput> exchangeNewDistributionGrouptype = null, [WorkflowExpression] Func<bool> exchangeNewDistributionGrouperrorIfGroupAlreadyExists = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse> ExchangeRemoveDistributionGroup([WorkflowExpression] Func<string> exchangeRemoveDistributionGroupidentity, [WorkflowExpression] Func<string> exchangeRemoveDistributionGroupworkflow, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse> ExchangeAddMailboxPermission([WorkflowExpression] Func<string> exchangeAddMailboxPermissionidentity, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionuser, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionaccessRights, [WorkflowExpression] Func<string> exchangeAddMailboxPermissionworkflow, [WorkflowExpression] Func<bool> exchangeAddMailboxPermissionautoMapping = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse> ExchangeRemoveMailboxPermission([WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionidentity, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionuser, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionaccessRights, [WorkflowExpression] Func<string> exchangeRemoveMailboxPermissionworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse> ExchangeDisableMailbox([WorkflowExpression] Func<string> exchangeDisableMailboxidentity, [WorkflowExpression] Func<string> exchangeDisableMailboxworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse> ExchangeDisableRemoteMailbox([WorkflowExpression] Func<string> exchangeDisableRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeDisableRemoteMailboxworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse> ExchangeEnableMailbox([WorkflowExpression] Func<string> exchangeEnableMailboxidentity, [WorkflowExpression] Func<string> exchangeEnableMailboxworkflow, [WorkflowExpression] Func<string> exchangeEnableMailboxalias = null, [WorkflowExpression] Func<string> exchangeEnableMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeEnableMailboxlinkedDomainController = null, [WorkflowExpression] Func<string> exchangeEnableMailboxlinkedMasterAccount = null, [WorkflowExpression] Func<string> exchangeEnableMailboxdatabase = null, [WorkflowExpression] Func<string> exchangeEnableMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeEnableMailboxemailAddressPolicyEnabled = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse> ExchangeEnableRemoteMailbox([WorkflowExpression] Func<string> exchangeEnableRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxremoteRoutingAddress = null, [WorkflowExpression] Func<string> exchangeEnableRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeEnableRemoteMailboxarchive = null, [WorkflowExpression] Func<bool> exchangeEnableRemoteMailboxemailAddressPolicyEnabled = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse> ExchangeGetRemoteMailbox([WorkflowExpression] Func<string> exchangeGetRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxidentity = null, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxfilterPropertyName = null, [WorkflowExpression] Func<exchangeGetRemoteMailboxfilterPropertyComparisonInput> exchangeGetRemoteMailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxfilterPropertyValue = null, [WorkflowExpression] Func<bool> exchangeGetRemoteMailboxnoResultIsAnException = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse> ExchangeDoesRemoteMailboxExist([WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistworkflow, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistidentity = null, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistfilterPropertyName = null, [WorkflowExpression] Func<exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput> exchangeDoesRemoteMailboxExistfilterPropertyComparison = null, [WorkflowExpression] Func<string> exchangeDoesRemoteMailboxExistfilterPropertyValue = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse> ExchangeNewMailbox([WorkflowExpression] Func<string> exchangeNewMailboxname, [WorkflowExpression] Func<string> exchangeNewMailboxuserPrincipalName, [WorkflowExpression] Func<string> exchangeNewMailboxworkflow, [WorkflowExpression] Func<string> exchangeNewMailboxfirstName = null, [WorkflowExpression] Func<string> exchangeNewMailboxlastName = null, [WorkflowExpression] Func<string> exchangeNewMailboxorganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeNewMailboxalias = null, [WorkflowExpression] Func<string> exchangeNewMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> exchangeNewMailboxsamAccountName = null, [WorkflowExpression] Func<string> exchangeNewMailboxpassword = null, [WorkflowExpression] Func<bool> exchangeNewMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> exchangeNewMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<string> exchangeNewMailboxdatabase = null, [WorkflowExpression] Func<bool> exchangeNewMailboxsharedMailbox = null, [WorkflowExpression] Func<bool> exchangeNewMailboxemailAddressPolicyEnabled = null, [WorkflowExpression] Func<bool> exchangeNewMailboxarchive = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse> ExchangeNewRemoteMailbox([WorkflowExpression] Func<string> exchangeNewRemoteMailboxname, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxuserPrincipalName, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxfirstName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxlastName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxonPremisesOrganizationalUnit = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxremoteRoutingAddress = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxsamAccountName = null, [WorkflowExpression] Func<string> exchangeNewRemoteMailboxpassword = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxsharedMailbox = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxemailAddressPolicyEnabled = null, [WorkflowExpression] Func<bool> exchangeNewRemoteMailboxarchive = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse> ExchangeSetADServerToViewEntireForest([WorkflowExpression] Func<bool> exchangeSetADServerToViewEntireForestviewEntireForest, [WorkflowExpression] Func<string> exchangeSetADServerToViewEntireForestworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse> ExchangeSetMailbox([WorkflowExpression] Func<string> exchangeSetMailboxidentity, [WorkflowExpression] Func<string> exchangeSetMailboxworkflow, [WorkflowExpression] Func<bool> exchangeSetMailboxaccountDisabled = null, [WorkflowExpression] Func<string> exchangeSetMailboxalias = null, [WorkflowExpression] Func<string> exchangeSetMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeSetMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetMailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute4 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute5 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute6 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute7 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute8 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute9 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute10 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute11 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute12 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute13 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute14 = null, [WorkflowExpression] Func<string> exchangeSetMailboxcustomAttribute15 = null, [WorkflowExpression] Func<bool> exchangeSetMailboxemailAddressPolicyEnabled = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse> ExchangeSetMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesworkflow, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesalias = null, [WorkflowExpression] Func<string> exchangeSetMailboxEmailAddressesprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = null, [WorkflowExpression] Func<string[]> exchangeSetMailboxEmailAddressesemailAddressesToAddList = null, [WorkflowExpression] Func<bool> exchangeSetMailboxEmailAddressesreplaceEmailAddresses = null, [WorkflowExpression] Func<string[]> exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse> ExchangeGetMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeGetMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeGetMailboxEmailAddressesworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse> ExchangeSetRemoteMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesworkflow, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesalias = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = null, [WorkflowExpression] Func<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = null, [WorkflowExpression] Func<string[]> exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse> ExchangeGetRemoteMailboxEmailAddresses([WorkflowExpression] Func<string> exchangeGetRemoteMailboxEmailAddressesidentity, [WorkflowExpression] Func<string> exchangeGetRemoteMailboxEmailAddressesworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse> ExchangeResetMailboxAttributes([WorkflowExpression] Func<string> exchangeResetMailboxAttributesidentity, [WorkflowExpression] Func<string> exchangeResetMailboxAttributesworkflow, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute1 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute2 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute3 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute4 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute5 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute6 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute7 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute8 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute9 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute10 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute11 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute12 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute13 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute14 = null, [WorkflowExpression] Func<bool> exchangeResetMailboxAttributesresetCustomAttribute15 = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse> ExchangeResetRemoteMailboxAttributes([WorkflowExpression] Func<string> exchangeResetRemoteMailboxAttributesidentity, [WorkflowExpression] Func<string> exchangeResetRemoteMailboxAttributesworkflow, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = null, [WorkflowExpression] Func<bool> exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse> ExchangeSetRemoteMailbox([WorkflowExpression] Func<string> exchangeSetRemoteMailboxidentity, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxworkflow, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxalias = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxdisplayName = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<exchangeSetRemoteMailboxtypeInput> exchangeSetRemoteMailboxtype = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute4 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute5 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute6 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute7 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute8 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute9 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute10 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute11 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute12 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute13 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute14 = null, [WorkflowExpression] Func<string> exchangeSetRemoteMailboxcustomAttribute15 = null, [WorkflowExpression] Func<bool> exchangeSetRemoteMailboxemailAddressPolicyEnabled = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse> ExchangeSetMailboxSendOnBehalfOfPermission([WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissionidentity, [WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, [WorkflowExpression] Func<string> exchangeSetMailboxSendOnBehalfOfPermissionworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse> ExchangeAddADPermission([WorkflowExpression] Func<string> exchangeAddADPermissionidentity, [WorkflowExpression] Func<string> exchangeAddADPermissionuser, [WorkflowExpression] Func<string> exchangeAddADPermissionworkflow, [WorkflowExpression] Func<string> exchangeAddADPermissionaccessRights = null, [WorkflowExpression] Func<string> exchangeAddADPermissionextendedRights = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse> ExchangeSetMailboxAutoReplyConfiguration([WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationidentity, [WorkflowExpression] Func<exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput> exchangeSetMailboxAutoReplyConfigurationautoReplyState, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationworkflow, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationinternalMessage = null, [WorkflowExpression] Func<exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput> exchangeSetMailboxAutoReplyConfigurationexternalAudience = null, [WorkflowExpression] Func<string> exchangeSetMailboxAutoReplyConfigurationexternalMessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse> IsAzureADv2PowerShellModuleInstalled([WorkflowExpression] Func<string> isAzureADv2PowerShellModuleInstalledworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse> OpenAzureADv2PowerShellRunspace([WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceusername, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspacepassword, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspacetenantId = null, [WorkflowExpression] Func<openAzureADv2PowerShellRunspaceaPIToUseInput> openAzureADv2PowerShellRunspaceaPIToUse = null, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceauthenticationScope = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse> OpenAzureADv2PowerShellRunspaceWithCertificate([WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificateapplicationId, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificatetenantId, [WorkflowExpression] Func<string> openAzureADv2PowerShellRunspaceWithCertificateworkflow, [WorkflowExpression] Func<openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput> openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse> IsAzureADv2PowerShellRunspaceOpen([WorkflowExpression] Func<string> isAzureADv2PowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse> RunAzureADv2PowerShellAutomationScript([WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runAzureADv2PowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse> CloseAzureADv2PowerShellRunspace([WorkflowExpression] Func<string> closeAzureADv2PowerShellRunspaceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse> AzureADv2GetAzureADUsers([WorkflowExpression] Func<string> azureADv2GetAzureADUsersworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersobjectId = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersfilterPropertyName = null, [WorkflowExpression] Func<azureADv2GetAzureADUsersfilterPropertyComparisonInput> azureADv2GetAzureADUsersfilterPropertyComparison = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUsersfilterPropertyValue = null, [WorkflowExpression] Func<bool> azureADv2GetAzureADUsersnoResultIsAnException = null, [WorkflowExpression] Func<string> azureADv2GetAzureADUserspropertiesToReturn = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse> AzureADv2AddAzureADUser([WorkflowExpression] Func<string> azureADv2AddAzureADUseruserPrincipalName, [WorkflowExpression] Func<bool> azureADv2AddAzureADUseraccountEnabled, [WorkflowExpression] Func<string> azureADv2AddAzureADUseraccountPassword, [WorkflowExpression] Func<string> azureADv2AddAzureADUserdisplayName, [WorkflowExpression] Func<string> azureADv2AddAzureADUsermailNickName, [WorkflowExpression] Func<string> azureADv2AddAzureADUserworkflow, [WorkflowExpression] Func<bool> azureADv2AddAzureADUseraccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserfirstName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserlastName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercity = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercompanyName = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsercountry = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserdepartment = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserfaxNumber = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserjobTitle = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUsermobilePhone = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUseroffice = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserphoneNumber = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserpostalCode = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserpreferredLanguage = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserstate = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserstreetAddress = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUserusageLocation = null, [WorkflowExpression] Func<azureADv2AddAzureADUserageGroupInput> azureADv2AddAzureADUserageGroup = null, [WorkflowExpression] Func<azureADv2AddAzureADUserconsentProvidedForMinorInput> azureADv2AddAzureADUserconsentProvidedForMinor = null, [WorkflowExpression] Func<string> azureADv2AddAzureADUseremployeeId = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserforceChangePasswordNextLogin = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserenforceChangePasswordPolicy = null, [WorkflowExpression] Func<bool> azureADv2AddAzureADUserpasswordNeverExpires = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse> AzureADv2RemoveAzureADUser([WorkflowExpression] Func<string> azureADv2RemoveAzureADUserobjectId, [WorkflowExpression] Func<string> azureADv2RemoveAzureADUserworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse> AzureADv2ResetAzureADUserPassword([WorkflowExpression] Func<string> azureADv2ResetAzureADUserPassworduserPrincipalName, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPasswordnewPassword, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPasswordworkflow, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse> AzureADv2GetAzureADUserGroupMembership([WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershipobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershipworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADUserGroupMembershippropertiesToReturn = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse> AzureADv2IsUserInAzureADUserGroup([WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupobjectId, [WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInAzureADUserGroupworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse> AzureADv2AddUserToGroup([WorkflowExpression] Func<string> azureADv2AddUserToGroupuserObjectId, [WorkflowExpression] Func<string> azureADv2AddUserToGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2AddUserToGroupworkflow, [WorkflowExpression] Func<bool> azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse> AzureADv2RemoveUserFromGroup([WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromGroupworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse> AzureADv2AddADUserToMultipleADGroups([WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsworkflow, [WorkflowExpression] Func<string> azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = null, [WorkflowExpression] Func<bool> azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = null, [WorkflowExpression] Func<int> azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse> AzureADv2RemoveADUserFromMultipleADGroups([WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsworkflow, [WorkflowExpression] Func<string> azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = null, [WorkflowExpression] Func<int> azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse> AzureADv2RemoveUserFromAllGroups([WorkflowExpression] Func<string> azureADv2RemoveUserFromAllGroupsuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromAllGroupsworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<int> azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse> AzureADv2GetAzureADLicenseSKUs([WorkflowExpression] Func<string> azureADv2GetAzureADLicenseSKUsworkflow, [WorkflowExpression] Func<azureADv2GetAzureADLicenseSKUsexpandPropertyInput> azureADv2GetAzureADLicenseSKUsexpandProperty = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse> AzureADv2SetAzureADUserLicense([WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicenseToAdd = null, [WorkflowExpression] Func<azureADv2SetAzureADUserLicenselicensePlansChoiceInput> azureADv2SetAzureADUserLicenselicensePlansChoice = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicensePlansCSV = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenselicensesToRemoveCSV = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserLicenseusageLocation = null, [WorkflowExpression] Func<bool> azureADv2SetAzureADUserLicenselocalScope = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse> AzureADv2GetAzureADUserLicenses([WorkflowExpression] Func<string> azureADv2GetAzureADUserLicensesobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicensesworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse> AzureADv2GetAzureADUserLicenseServicePlans([WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlansobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, [WorkflowExpression] Func<string> azureADv2GetAzureADUserLicenseServicePlansworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse> AzureADv2RemoveAllAzureADUserLicense([WorkflowExpression] Func<string> azureADv2RemoveAllAzureADUserLicenseobjectId, [WorkflowExpression] Func<string> azureADv2RemoveAllAzureADUserLicenseworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse> AzureADv2SetAzureADUser([WorkflowExpression] Func<string> azureADv2SetAzureADUserobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserfirstName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserlastName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserdisplayName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercity = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercompanyName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsercountry = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserdepartment = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserfaxNumber = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserjobTitle = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsermobilePhone = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUseroffice = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserphoneNumber = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserpostalCode = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserpreferredLanguage = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserstate = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserstreetAddress = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUserusageLocation = null, [WorkflowExpression] Func<azureADv2SetAzureADUserageGroupInput> azureADv2SetAzureADUserageGroup = null, [WorkflowExpression] Func<azureADv2SetAzureADUserconsentProvidedForMinorInput> azureADv2SetAzureADUserconsentProvidedForMinor = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUsermailNickName = null, [WorkflowExpression] Func<string> azureADv2SetAzureADUseremployeeId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse> AzureADv2ResetAzureADUserProperties([WorkflowExpression] Func<string> azureADv2ResetAzureADUserPropertiesobjectId, [WorkflowExpression] Func<string> azureADv2ResetAzureADUserPropertiesworkflow, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetFirstName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetLastName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCity = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCompanyName = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetCountry = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetDepartment = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetFaxNumber = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetJobTitle = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetMobilePhone = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetOffice = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPhoneNumber = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPostalCode = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetState = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetStreetAddress = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetUsageLocation = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetAgeGroup = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = null, [WorkflowExpression] Func<bool> azureADv2ResetAzureADUserPropertiesresetEmployeeId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse> AzureADv2SetAzureADUserManager([WorkflowExpression] Func<string> azureADv2SetAzureADUserManagerobjectId, [WorkflowExpression] Func<string> azureADv2SetAzureADUserManagerworkflow, [WorkflowExpression] Func<string> azureADv2SetAzureADUserManagermanager = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse> AzureADv2NewSecurityGroup([WorkflowExpression] Func<string> azureADv2NewSecurityGroupdisplayName, [WorkflowExpression] Func<string> azureADv2NewSecurityGroupworkflow, [WorkflowExpression] Func<string> azureADv2NewSecurityGroupdescription = null, [WorkflowExpression] Func<bool> azureADv2NewSecurityGroupcheckGroupExists = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse> AzureADv2RemoveSecurityGroup([WorkflowExpression] Func<string> azureADv2RemoveSecurityGroupgroupObjectId, [WorkflowExpression] Func<string> azureADv2RemoveSecurityGroupworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse> AzureADv2NewMicrosoft365Group([WorkflowExpression] Func<string> azureADv2NewMicrosoft365GroupdisplayName, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365Groupworkflow, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365Groupdescription = null, [WorkflowExpression] Func<string> azureADv2NewMicrosoft365GroupmailNickname = null, [WorkflowExpression] Func<azureADv2NewMicrosoft365GroupgroupVisibilityInput> azureADv2NewMicrosoft365GroupgroupVisibility = null, [WorkflowExpression] Func<bool> azureADv2NewMicrosoft365GroupcheckGroupExists = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse> AzureADv2GetGroups([WorkflowExpression] Func<string> azureADv2GetGroupsworkflow, [WorkflowExpression] Func<string> azureADv2GetGroupsobjectId = null, [WorkflowExpression] Func<string> azureADv2GetGroupsfilterPropertyName = null, [WorkflowExpression] Func<azureADv2GetGroupsfilterPropertyComparisonInput> azureADv2GetGroupsfilterPropertyComparison = null, [WorkflowExpression] Func<string> azureADv2GetGroupsfilterPropertyValue = null, [WorkflowExpression] Func<bool> azureADv2GetGroupsnoResultIsAnException = null, [WorkflowExpression] Func<string> azureADv2GetGroupspropertiesToReturn = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse> AzureADv2EnableUser([WorkflowExpression] Func<string> azureADv2EnableUseruserObjectId, [WorkflowExpression] Func<string> azureADv2EnableUserworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse> AzureADv2DisableUser([WorkflowExpression] Func<string> azureADv2DisableUseruserObjectId, [WorkflowExpression] Func<string> azureADv2DisableUserworkflow, [WorkflowExpression] Func<bool> azureADv2DisableUserrevokeUserRefreshTokens = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse> AzureADv2AssignUserToRole([WorkflowExpression] Func<string> azureADv2AssignUserToRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToRoleworkflow, [WorkflowExpression] Func<string> azureADv2AssignUserToRoledirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse> AzureADv2AssignUserToMultipleRoles([WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesworkflow, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesrolesJSON = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = null, [WorkflowExpression] Func<string> azureADv2AssignUserToMultipleRolesdirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = null, [WorkflowExpression] Func<bool> azureADv2AssignUserToMultipleRolescheckRoleIdsExist = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse> AzureADv2RemoveUserFromMultipleRoles([WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesworkflow, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesrolesJSON = null, [WorkflowExpression] Func<string> azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse> AzureADv2IsUserInRole([WorkflowExpression] Func<string> azureADv2IsUserInRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2IsUserInRoleworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse> AzureADv2GetAzureADUserRoleAssignments([WorkflowExpression] Func<string> azureADv2GetAzureADUserRoleAssignmentsobjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADUserRoleAssignmentsworkflow, [WorkflowExpression] Func<bool> azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = null, [WorkflowExpression] Func<bool> azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse> AzureADv2RemoveUserFromRole([WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleroleObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoleworkflow, [WorkflowExpression] Func<string> azureADv2RemoveUserFromRoledirectoryScopeId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse> AzureADv2RemoveUserFromAllRoles([WorkflowExpression] Func<string> azureADv2RemoveUserFromAllRolesuserObjectId, [WorkflowExpression] Func<string> azureADv2RemoveUserFromAllRolesworkflow, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = null, [WorkflowExpression] Func<bool> azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse> AzureADv2GetAzureADGroupMembers([WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersgroupObjectId, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersworkflow, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMemberspropertiesToReturn = null, [WorkflowExpression] Func<string> azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse> OpenO365PowerShellRunspace([WorkflowExpression] Func<string> openO365PowerShellRunspaceoffice365Username, [WorkflowExpression] Func<string> openO365PowerShellRunspaceoffice365Password, [WorkflowExpression] Func<string> openO365PowerShellRunspaceworkflow, [WorkflowExpression] Func<string> openO365PowerShellRunspaceexchangeURL = null, [WorkflowExpression] Func<openO365PowerShellRunspaceconnectionMethodInput> openO365PowerShellRunspaceconnectionMethod = null, [WorkflowExpression] Func<bool> openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openO365PowerShellRunspacecommandTypesToImportLocallyInput> openO365PowerShellRunspacecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse> OpenO365PowerShellRunspaceWithCertificate([WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateapplicationId, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificatecertificateThumbprint, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateorganization, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateworkflow, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateexchangeURL = null, [WorkflowExpression] Func<openO365PowerShellRunspaceWithCertificateconnectionMethodInput> openO365PowerShellRunspaceWithCertificateconnectionMethod = null, [WorkflowExpression] Func<bool> openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = null, [WorkflowExpression] Func<openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput> openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = null, [WorkflowExpression] Func<string> openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse> IsO365PowerShellRunspaceOpen([WorkflowExpression] Func<string> isO365PowerShellRunspaceOpenworkflow, [WorkflowExpression] Func<bool> isO365PowerShellRunspaceOpentestCommunications = null, [WorkflowExpression] Func<bool> isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse> RunO365PowerShellAutomationScript([WorkflowExpression] Func<string> runO365PowerShellAutomationScriptworkflow, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpowerShellScriptContents = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptisNoResultAnError = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnComplexTypes = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnBooleanAsBoolean = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnNumericAsDecimal = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptreturnDateAsDate = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptlocalScope = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptrunScriptAsThread = null, [WorkflowExpression] Func<int> runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> runO365PowerShellAutomationScriptsecondsToWaitForThread = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptscriptContainsStoredPassword = null, [WorkflowExpression] Func<bool> runO365PowerShellAutomationScriptlogVerboseOutput = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, [WorkflowExpression] Func<string> runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, [WorkflowExpression] Func<runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem[]> runO365PowerShellAutomationScriptpowerShellCommandParameters = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse> CloseO365PowerShellRunspace([WorkflowExpression] Func<string> closeO365PowerShellRunspaceworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365MailboxResponse> O365GetO365Mailbox([WorkflowExpression] Func<string> o365GetO365Mailboxworkflow, [WorkflowExpression] Func<string> o365GetO365Mailboxidentity = null, [WorkflowExpression] Func<string> o365GetO365MailboxfilterPropertyName = null, [WorkflowExpression] Func<o365GetO365MailboxfilterPropertyComparisonInput> o365GetO365MailboxfilterPropertyComparison = null, [WorkflowExpression] Func<string> o365GetO365MailboxfilterPropertyValue = null, [WorkflowExpression] Func<o365GetO365MailboxrecipientTypeDetailsInput> o365GetO365MailboxrecipientTypeDetails = null, [WorkflowExpression] Func<bool> o365GetO365MailboxnoResultIsAnException = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse> O365AddMailboxPermission([WorkflowExpression] Func<string> o365AddMailboxPermissionidentity, [WorkflowExpression] Func<string> o365AddMailboxPermissionuser, [WorkflowExpression] Func<string> o365AddMailboxPermissionaccessRights, [WorkflowExpression] Func<string> o365AddMailboxPermissionworkflow, [WorkflowExpression] Func<bool> o365AddMailboxPermissionautoMapping = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse> O365RemoveMailboxPermission([WorkflowExpression] Func<string> o365RemoveMailboxPermissionidentity, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionuser, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionaccessRights, [WorkflowExpression] Func<string> o365RemoveMailboxPermissionworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse> O365AddDistributionGroupMember([WorkflowExpression] Func<string> o365AddDistributionGroupMemberidentity, [WorkflowExpression] Func<string> o365AddDistributionGroupMembermember, [WorkflowExpression] Func<string> o365AddDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse> O365GetO365DistributionGroup([WorkflowExpression] Func<string> o365GetO365DistributionGroupworkflow, [WorkflowExpression] Func<string> o365GetO365DistributionGroupidentity = null, [WorkflowExpression] Func<string> o365GetO365DistributionGroupfilterPropertyName = null, [WorkflowExpression] Func<o365GetO365DistributionGroupfilterPropertyComparisonInput> o365GetO365DistributionGroupfilterPropertyComparison = null, [WorkflowExpression] Func<string> o365GetO365DistributionGroupfilterPropertyValue = null, [WorkflowExpression] Func<bool> o365GetO365DistributionGroupnoResultIsAnException = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse> O365NewO365DistributionGroup([WorkflowExpression] Func<string> o365NewO365DistributionGroupname, [WorkflowExpression] Func<string> o365NewO365DistributionGroupworkflow, [WorkflowExpression] Func<string> o365NewO365DistributionGroupalias = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupdisplayName = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupnotes = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupmanagedBy = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupmembers = null, [WorkflowExpression] Func<string> o365NewO365DistributionGrouporganizationalUnit = null, [WorkflowExpression] Func<string> o365NewO365DistributionGroupprimarySmtpAddress = null, [WorkflowExpression] Func<o365NewO365DistributionGroupmemberDepartRestrictionInput> o365NewO365DistributionGroupmemberDepartRestriction = null, [WorkflowExpression] Func<o365NewO365DistributionGroupmemberJoinRestrictionInput> o365NewO365DistributionGroupmemberJoinRestriction = null, [WorkflowExpression] Func<bool> o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = null, [WorkflowExpression] Func<o365NewO365DistributionGrouptypeInput> o365NewO365DistributionGrouptype = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse> O365RemoveDistributionGroup([WorkflowExpression] Func<string> o365RemoveDistributionGroupidentity, [WorkflowExpression] Func<string> o365RemoveDistributionGroupworkflow, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveDistributionGrouperrorIfGroupDoesNotExist = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxResponse> O365SetO365Mailbox([WorkflowExpression] Func<string> o365SetO365Mailboxidentity, [WorkflowExpression] Func<string> o365SetO365Mailboxworkflow, [WorkflowExpression] Func<bool> o365SetO365MailboxaccountDisabled = null, [WorkflowExpression] Func<string> o365SetO365Mailboxalias = null, [WorkflowExpression] Func<string> o365SetO365MailboxdisplayName = null, [WorkflowExpression] Func<bool> o365SetO365MailboxhiddenFromAddressListsEnabled = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute1 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute2 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute3 = null, [WorkflowExpression] Func<string> o365SetO365MailboxcustomAttribute4 = null, [WorkflowExpression] Func<o365SetO365MailboxtypeInput> o365SetO365Mailboxtype = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse> O365WaitForO365Mailbox([WorkflowExpression] Func<string> o365WaitForO365Mailboxidentity, [WorkflowExpression] Func<int> o365WaitForO365MailboxnumberOfTimesToCheck, [WorkflowExpression] Func<int> o365WaitForO365MailboxsecondsBetweenTries, [WorkflowExpression] Func<string> o365WaitForO365Mailboxworkflow, [WorkflowExpression] Func<o365WaitForO365MailboxrecipientTypeDetailsInput> o365WaitForO365MailboxrecipientTypeDetails = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse> O365SetO365MailboxAutoReplyConfiguration([WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationidentity, [WorkflowExpression] Func<o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput> o365SetO365MailboxAutoReplyConfigurationautoReplyState, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationworkflow, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationinternalMessage = null, [WorkflowExpression] Func<o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput> o365SetO365MailboxAutoReplyConfigurationexternalAudience = null, [WorkflowExpression] Func<string> o365SetO365MailboxAutoReplyConfigurationexternalMessage = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse> O365RemoveDistributionGroupMember([WorkflowExpression] Func<string> o365RemoveDistributionGroupMembergroupIdentity, [WorkflowExpression] Func<string> o365RemoveDistributionGroupMembermember, [WorkflowExpression] Func<string> o365RemoveDistributionGroupMemberworkflow, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse> O365GetMailboxDistributionGroupMembership([WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershipmailboxIdentity, [WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershipworkflow, [WorkflowExpression] Func<string> o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse> O365GetDistributionGroupMembers([WorkflowExpression] Func<string> o365GetDistributionGroupMembersgroupIdentity, [WorkflowExpression] Func<string> o365GetDistributionGroupMembersworkflow, [WorkflowExpression] Func<string> o365GetDistributionGroupMemberspropertiesToRetrieveJSON = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse> O365RemoveMailboxFromAllDistributionGroups([WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsworkflow, [WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = null, [WorkflowExpression] Func<string> o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = null, [WorkflowExpression] Func<bool> o365RemoveMailboxFromAllDistributionGroupsrunAsThread = null, [WorkflowExpression] Func<int> o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewMailboxResponse> O365NewMailbox([WorkflowExpression] Func<string> o365NewMailboxmicrosoftOnlineServicesID, [WorkflowExpression] Func<string> o365NewMailboxname, [WorkflowExpression] Func<string> o365NewMailboxworkflow, [WorkflowExpression] Func<string> o365NewMailboxfirstName = null, [WorkflowExpression] Func<string> o365NewMailboxlastName = null, [WorkflowExpression] Func<string> o365NewMailboxinitials = null, [WorkflowExpression] Func<string> o365NewMailboxdisplayName = null, [WorkflowExpression] Func<string> o365NewMailboxalias = null, [WorkflowExpression] Func<string> o365NewMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<string> o365NewMailboxpassword = null, [WorkflowExpression] Func<bool> o365NewMailboxaccountPasswordIsStoredPassword = null, [WorkflowExpression] Func<bool> o365NewMailboxresetPasswordOnNextLogon = null, [WorkflowExpression] Func<bool> o365NewMailboxarchive = null, [WorkflowExpression] Func<string> o365NewMailboxmailboxPlan = null, [WorkflowExpression] Func<string> o365NewMailboxmailboxRegion = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse> O365NewSharedMailbox([WorkflowExpression] Func<string> o365NewSharedMailboxname, [WorkflowExpression] Func<string> o365NewSharedMailboxworkflow, [WorkflowExpression] Func<string> o365NewSharedMailboxfirstName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxlastName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxinitials = null, [WorkflowExpression] Func<string> o365NewSharedMailboxdisplayName = null, [WorkflowExpression] Func<string> o365NewSharedMailboxalias = null, [WorkflowExpression] Func<string> o365NewSharedMailboxprimarySmtpAddress = null, [WorkflowExpression] Func<bool> o365NewSharedMailboxarchive = null, [WorkflowExpression] Func<string> o365NewSharedMailboxmailboxRegion = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse> O365EnableArchiveMailbox([WorkflowExpression] Func<string> o365EnableArchiveMailboxidentity, [WorkflowExpression] Func<string> o365EnableArchiveMailboxworkflow, [WorkflowExpression] Func<bool> o365EnableArchiveMailboxcheckIfArchiveExists = null, [WorkflowExpression] Func<string> o365EnableArchiveMailboxarchiveName = null, [WorkflowExpression] Func<bool> o365EnableArchiveMailboxautoExpandingArchive = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse> O365DoesMailboxHaveAnArchive([WorkflowExpression] Func<string> o365DoesMailboxHaveAnArchiveidentity, [WorkflowExpression] Func<string> o365DoesMailboxHaveAnArchiveworkflow)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse> JMLGetNextAvailableAccountName([WorkflowExpression] Func<string> jMLGetNextAvailableAccountNameworkflow, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefirstName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamemiddleName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamelastName = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldA = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldB = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldC = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamefieldD = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableMStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableNStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamevariableXStartValue = null, [WorkflowExpression] Func<int> jMLGetNextAvailableAccountNamemaxAttempts = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNamefallbackCausesRetest = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamenumbersNotToUse = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = null, [WorkflowExpression] Func<bool> jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = null, [WorkflowExpression] Func<string> jMLGetNextAvailableAccountNamesequenceA1 = null, [WorkflowExpression] Func<jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem[]> jMLGetNextAvailableAccountNamepropertiesToCheckList = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse> JMLConnectToJMLEnvironment([WorkflowExpression] Func<string> jMLConnectToJMLEnvironmentworkflow, [WorkflowExpression] Func<string> jMLConnectToJMLEnvironmentfriendlyName = null, [WorkflowExpression] Func<bool> jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = null)
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