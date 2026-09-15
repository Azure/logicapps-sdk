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
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse> RunActiveDirectoryPowerShellAutomationScript(Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptworkflow, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunActiveDirectoryPowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runActiveDirectoryPowerShellAutomationScript = new JObject();
            var runActiveDirectoryPowerShellAutomationScriptpropCount = 0;
            if (runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PowerShellScriptContents"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpowerShellScriptContents);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
            {
                if (runActiveDirectoryPowerShellAutomationScriptisNoResultAnError != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptisNoResultAnError);
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
                    runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnComplexTypes);
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
                    runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnBooleanAsBoolean);
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
                    runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnNumericAsDecimal);
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
                    runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptreturnDateAsDate);
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
                runActiveDirectoryPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
            {
                if (runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptrunScriptAsThread);
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
                runActiveDirectoryPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptretrieveOutputDataFromThreadId);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
            {
                if (runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptsecondsToWaitForThread);
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
                    runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptscriptContainsStoredPassword);
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
                    runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptlogVerboseOutput);
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
                runActiveDirectoryPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpropertyNamesToSerializeJSON);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpropertyTypesToSerializeJSON);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PowerShellCommandParameters"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptpowerShellCommandParameters);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            runActiveDirectoryPowerShellAutomationScriptpropCount++;
            runActiveDirectoryPowerShellAutomationScript["Workflow"] = CSharpExpressionConverter.ConvertToken(runActiveDirectoryPowerShellAutomationScriptworkflow);
            if (runActiveDirectoryPowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runActiveDirectoryPowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse> OpenActiveDirectoryPowerShellRunspaceWithCredentials(Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsusername, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialspassword, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer = null, Expression<Func<bool>> openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL = null, Expression<Func<int>> openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenActiveDirectoryPowerShellRunspaceWithCredentials";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openActiveDirectoryPowerShellRunspaceWithCredentials = new JObject();
            var openActiveDirectoryPowerShellRunspaceWithCredentialspropCount = 0;
            openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            openActiveDirectoryPowerShellRunspaceWithCredentials["Username"] = CSharpExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsusername);
            openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            openActiveDirectoryPowerShellRunspaceWithCredentials["Password"] = CSharpExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialspassword);
            if (openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer != null)
            {
                openActiveDirectoryPowerShellRunspaceWithCredentials["RemoteComputer"] = CSharpExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsremoteComputer);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            }

            if (openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
            {
                if (openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL != null)
                {
                    openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = CSharpExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsuseSSL);
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
                openActiveDirectoryPowerShellRunspaceWithCredentials["AlternativeTCPPort"] = CSharpExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsalternativeTCPPort);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            }

            openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            openActiveDirectoryPowerShellRunspaceWithCredentials["Workflow"] = CSharpExpressionConverter.ConvertToken(openActiveDirectoryPowerShellRunspaceWithCredentialsworkflow);
            if (openActiveDirectoryPowerShellRunspaceWithCredentialspropCount > 0)
            {
                callPayload.Body = openActiveDirectoryPowerShellRunspaceWithCredentials;
            }

            return new ApiConnectionAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse> CloseActiveDirectoryPowerShellRunspace(Expression<Func<string>> closeActiveDirectoryPowerShellRunspaceworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/CloseActiveDirectoryPowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeActiveDirectoryPowerShellRunspace = new JObject();
            var closeActiveDirectoryPowerShellRunspacepropCount = 0;
            closeActiveDirectoryPowerShellRunspacepropCount++;
            closeActiveDirectoryPowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(closeActiveDirectoryPowerShellRunspaceworkflow);
            if (closeActiveDirectoryPowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeActiveDirectoryPowerShellRunspace;
            }

            return new ApiConnectionAction<CloseActiveDirectoryPowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse> IsActiveDirectoryPowerShellRunspaceOpen(Expression<Func<string>> isActiveDirectoryPowerShellRunspaceOpenworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/IsActiveDirectoryPowerShellRunspaceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isActiveDirectoryPowerShellRunspaceOpen = new JObject();
            var isActiveDirectoryPowerShellRunspaceOpenpropCount = 0;
            isActiveDirectoryPowerShellRunspaceOpenpropCount++;
            isActiveDirectoryPowerShellRunspaceOpen["Workflow"] = CSharpExpressionConverter.ConvertToken(isActiveDirectoryPowerShellRunspaceOpenworkflow);
            if (isActiveDirectoryPowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isActiveDirectoryPowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse> OpenLocalPassthroughActiveDirectoryPowerShellRunspace(Expression<Func<string>> openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/OpenLocalPassthroughActiveDirectoryPowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openLocalPassthroughActiveDirectoryPowerShellRunspace = new JObject();
            var openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount = 0;
            openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount++;
            openLocalPassthroughActiveDirectoryPowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(openLocalPassthroughActiveDirectoryPowerShellRunspaceworkflow);
            if (openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openLocalPassthroughActiveDirectoryPowerShellRunspace;
            }

            return new ApiConnectionAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse> ActiveDirectoryAddADUser(Expression<Func<string>> activeDirectoryAddADUsername, Expression<Func<string>> activeDirectoryAddADUserworkflow, Expression<Func<string>> activeDirectoryAddADUseruserPrincipalName = null, Expression<Func<string>> activeDirectoryAddADUsersamAccountName = null, Expression<Func<string>> activeDirectoryAddADUsergivenName = null, Expression<Func<string>> activeDirectoryAddADUsersurName = null, Expression<Func<string>> activeDirectoryAddADUserpath = null, Expression<Func<string>> activeDirectoryAddADUserdescription = null, Expression<Func<string>> activeDirectoryAddADUserdisplayName = null, Expression<Func<string>> activeDirectoryAddADUseraccountPassword = null, Expression<Func<bool>> activeDirectoryAddADUseraccountPasswordIsStoredPassword = null, Expression<Func<bool>> activeDirectoryAddADUserenabled = null, Expression<Func<bool>> activeDirectoryAddADUserchangePasswordAtLogon = null, Expression<Func<bool>> activeDirectoryAddADUsercannotChangePassword = null, Expression<Func<bool>> activeDirectoryAddADUserpasswordNeverExpires = null, Expression<Func<string>> activeDirectoryAddADUseraDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADUser = new JObject();
            var activeDirectoryAddADUserpropCount = 0;
            activeDirectoryAddADUserpropCount++;
            activeDirectoryAddADUser["Name"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUsername);
            if (activeDirectoryAddADUseruserPrincipalName != null)
            {
                activeDirectoryAddADUser["UserPrincipalName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUseruserPrincipalName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUsersamAccountName != null)
            {
                activeDirectoryAddADUser["SamAccountName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUsersamAccountName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUsergivenName != null)
            {
                activeDirectoryAddADUser["GivenName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUsergivenName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUsersurName != null)
            {
                activeDirectoryAddADUser["SurName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUsersurName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserpath != null)
            {
                activeDirectoryAddADUser["Path"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserpath);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserdescription != null)
            {
                activeDirectoryAddADUser["Description"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserdescription);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserdisplayName != null)
            {
                activeDirectoryAddADUser["DisplayName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserdisplayName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUseraccountPassword != null)
            {
                activeDirectoryAddADUser["AccountPassword"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUseraccountPassword);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
            {
                if (activeDirectoryAddADUseraccountPasswordIsStoredPassword != null)
                {
                    activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUseraccountPasswordIsStoredPassword);
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
                    activeDirectoryAddADUser["Enabled"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserenabled);
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
                    activeDirectoryAddADUser["ChangePasswordAtLogon"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserchangePasswordAtLogon);
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
                    activeDirectoryAddADUser["CannotChangePassword"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUsercannotChangePassword);
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
                    activeDirectoryAddADUser["PasswordNeverExpires"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserpasswordNeverExpires);
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
                activeDirectoryAddADUser["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUseraDServer);
                activeDirectoryAddADUserpropCount++;
            }

            activeDirectoryAddADUserpropCount++;
            activeDirectoryAddADUser["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserworkflow);
            if (activeDirectoryAddADUserpropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADUser;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse> ActiveDirectoryGetADUserByIdentity(Expression<Func<string>> activeDirectoryGetADUserByIdentityworkflow, Expression<Func<string>> activeDirectoryGetADUserByIdentityidentity = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityfilterPropertyName = null, Expression<Func<activeDirectoryGetADUserByIdentityfilterPropertyComparisonInput>> activeDirectoryGetADUserByIdentityfilterPropertyComparison = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityfilterPropertyValue = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitysearchOUBase = null, Expression<Func<bool>> activeDirectoryGetADUserByIdentitysearchOUBaseSubtree = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityproperties = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityaDServer = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADUserByIdentity = new JObject();
            var activeDirectoryGetADUserByIdentitypropCount = 0;
            if (activeDirectoryGetADUserByIdentityidentity != null)
            {
                activeDirectoryGetADUserByIdentity["Identity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityidentity);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityfilterPropertyName != null)
            {
                activeDirectoryGetADUserByIdentity["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityfilterPropertyName);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
            {
                if (activeDirectoryGetADUserByIdentityfilterPropertyComparison != null)
                {
                    activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(activeDirectoryGetADUserByIdentityfilterPropertyComparison);
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
                activeDirectoryGetADUserByIdentity["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityfilterPropertyValue);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitysearchOUBase != null)
            {
                activeDirectoryGetADUserByIdentity["SearchOUBase"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitysearchOUBase);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
            {
                if (activeDirectoryGetADUserByIdentitysearchOUBaseSubtree != null)
                {
                    activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitysearchOUBaseSubtree);
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
                activeDirectoryGetADUserByIdentity["Properties"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityproperties);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityaDServer != null)
            {
                activeDirectoryGetADUserByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityaDServer);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON != null)
            {
                activeDirectoryGetADUserByIdentity["PropertiesToReturnAsCollectionJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitypropertiesToReturnAsCollectionJSON);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON != null)
            {
                activeDirectoryGetADUserByIdentity["PropertyNamesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitypropertyNamesToSerializeJSON);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON != null)
            {
                activeDirectoryGetADUserByIdentity["PropertyTypesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentitypropertyTypesToSerializeJSON);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            activeDirectoryGetADUserByIdentitypropCount++;
            activeDirectoryGetADUserByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserByIdentityworkflow);
            if (activeDirectoryGetADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse> ActiveDirectoryGetOUFromUserDN(Expression<Func<string>> activeDirectoryGetOUFromUserDNuserDN, Expression<Func<string>> activeDirectoryGetOUFromUserDNworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetOUFromUserDN";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetOUFromUserDN = new JObject();
            var activeDirectoryGetOUFromUserDNpropCount = 0;
            activeDirectoryGetOUFromUserDNpropCount++;
            activeDirectoryGetOUFromUserDN["UserDN"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetOUFromUserDNuserDN);
            activeDirectoryGetOUFromUserDNpropCount++;
            activeDirectoryGetOUFromUserDN["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetOUFromUserDNworkflow);
            if (activeDirectoryGetOUFromUserDNpropCount > 0)
            {
                callPayload.Body = activeDirectoryGetOUFromUserDN;
            }

            return new ApiConnectionAction<ActiveDirectoryGetOUFromUserDNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse> ActiveDirectoryGetDomainFQDNFromDN(Expression<Func<string>> activeDirectoryGetDomainFQDNFromDNdN, Expression<Func<string>> activeDirectoryGetDomainFQDNFromDNworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainFQDNFromDN";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetDomainFQDNFromDN = new JObject();
            var activeDirectoryGetDomainFQDNFromDNpropCount = 0;
            activeDirectoryGetDomainFQDNFromDNpropCount++;
            activeDirectoryGetDomainFQDNFromDN["DN"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetDomainFQDNFromDNdN);
            activeDirectoryGetDomainFQDNFromDNpropCount++;
            activeDirectoryGetDomainFQDNFromDN["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetDomainFQDNFromDNworkflow);
            if (activeDirectoryGetDomainFQDNFromDNpropCount > 0)
            {
                callPayload.Body = activeDirectoryGetDomainFQDNFromDN;
            }

            return new ApiConnectionAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse> ActiveDirectoryGetADGroupByIdentity(Expression<Func<string>> activeDirectoryGetADGroupByIdentityworkflow, Expression<Func<string>> activeDirectoryGetADGroupByIdentityidentity = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityfilterPropertyName = null, Expression<Func<activeDirectoryGetADGroupByIdentityfilterPropertyComparisonInput>> activeDirectoryGetADGroupByIdentityfilterPropertyComparison = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityfilterPropertyValue = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentitysearchOUBase = null, Expression<Func<bool>> activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree = null, Expression<Func<bool>> activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADGroupByIdentity = new JObject();
            var activeDirectoryGetADGroupByIdentitypropCount = 0;
            if (activeDirectoryGetADGroupByIdentityidentity != null)
            {
                activeDirectoryGetADGroupByIdentity["Identity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityidentity);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityfilterPropertyName != null)
            {
                activeDirectoryGetADGroupByIdentity["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityfilterPropertyName);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
            {
                if (activeDirectoryGetADGroupByIdentityfilterPropertyComparison != null)
                {
                    activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(activeDirectoryGetADGroupByIdentityfilterPropertyComparison);
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
                activeDirectoryGetADGroupByIdentity["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityfilterPropertyValue);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentitysearchOUBase != null)
            {
                activeDirectoryGetADGroupByIdentity["SearchOUBase"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentitysearchOUBase);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
            {
                if (activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree != null)
                {
                    activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentitysearchOUBaseSubtree);
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
                    activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityraiseExceptionIfGroupDoesNotExist);
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
                activeDirectoryGetADGroupByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityaDServer);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            activeDirectoryGetADGroupByIdentitypropCount++;
            activeDirectoryGetADGroupByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupByIdentityworkflow);
            if (activeDirectoryGetADGroupByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADGroupByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADGroupByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse> ActiveDirectoryAddADGroupMemberByIdentity(Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityuserIdentity, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityworkflow, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentitygroupName = null, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroupMemberByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADGroupMemberByIdentity = new JObject();
            var activeDirectoryAddADGroupMemberByIdentitypropCount = 0;
            if (activeDirectoryAddADGroupMemberByIdentitygroupIdentity != null)
            {
                activeDirectoryAddADGroupMemberByIdentity["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentitygroupIdentity);
                activeDirectoryAddADGroupMemberByIdentitypropCount++;
            }

            if (activeDirectoryAddADGroupMemberByIdentitygroupName != null)
            {
                activeDirectoryAddADGroupMemberByIdentity["GroupName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentitygroupName);
                activeDirectoryAddADGroupMemberByIdentitypropCount++;
            }

            activeDirectoryAddADGroupMemberByIdentitypropCount++;
            activeDirectoryAddADGroupMemberByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentityuserIdentity);
            if (activeDirectoryAddADGroupMemberByIdentityaDServer != null)
            {
                activeDirectoryAddADGroupMemberByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentityaDServer);
                activeDirectoryAddADGroupMemberByIdentitypropCount++;
            }

            activeDirectoryAddADGroupMemberByIdentitypropCount++;
            activeDirectoryAddADGroupMemberByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupMemberByIdentityworkflow);
            if (activeDirectoryAddADGroupMemberByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADGroupMemberByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse> ActiveDirectoryAddMultipleADGroupMembersByIdentity(Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityworkflow, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall = null, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddMultipleADGroupMembersByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddMultipleADGroupMembersByIdentity = new JObject();
            var activeDirectoryAddMultipleADGroupMembersByIdentitypropCount = 0;
            if (activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentitygroupIdentity);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["GroupMembersJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentitygroupMembersJSON);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
            {
                if (activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd != null)
                {
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToAdd);
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
                    activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToAdd);
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
                    activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityaddAllMembersInASingleCall);
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
                activeDirectoryAddMultipleADGroupMembersByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityaDServer);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            activeDirectoryAddMultipleADGroupMembersByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddMultipleADGroupMembersByIdentityworkflow);
            if (activeDirectoryAddMultipleADGroupMembersByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryAddMultipleADGroupMembersByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse> ActiveDirectoryAddADUserToMultipleADGroupsByName(Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameworkflow, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON = null, Expression<Func<bool>> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd = null, Expression<Func<bool>> activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd = null, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameaDServer = null, Expression<Func<int>> activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUserToMultipleADGroupsByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADUserToMultipleADGroupsByName = new JObject();
            var activeDirectoryAddADUserToMultipleADGroupsByNamepropCount = 0;
            activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            activeDirectoryAddADUserToMultipleADGroupsByName["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameuserIdentity);
            if (activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["GroupNamesJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNamegroupNamesJSON);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
            {
                if (activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd != null)
                {
                    activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAnyGroupsFailToAdd);
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
                    activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameexceptionIfAllGroupsFailToAdd);
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
                activeDirectoryAddADUserToMultipleADGroupsByName["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameaDServer);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["MaxGroupsPerCall"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNamemaxGroupsPerCall);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            activeDirectoryAddADUserToMultipleADGroupsByName["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADUserToMultipleADGroupsByNameworkflow);
            if (activeDirectoryAddADUserToMultipleADGroupsByNamepropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADUserToMultipleADGroupsByName;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse> ActiveDirectoryGetADUserGroupMembership(Expression<Func<string>> activeDirectoryGetADUserGroupMembershipuserIdentity, Expression<Func<string>> activeDirectoryGetADUserGroupMembershipworkflow, Expression<Func<string>> activeDirectoryGetADUserGroupMembershipaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADUserGroupMembership = new JObject();
            var activeDirectoryGetADUserGroupMembershippropCount = 0;
            activeDirectoryGetADUserGroupMembershippropCount++;
            activeDirectoryGetADUserGroupMembership["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserGroupMembershipuserIdentity);
            if (activeDirectoryGetADUserGroupMembershipaDServer != null)
            {
                activeDirectoryGetADUserGroupMembership["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserGroupMembershipaDServer);
                activeDirectoryGetADUserGroupMembershippropCount++;
            }

            activeDirectoryGetADUserGroupMembershippropCount++;
            activeDirectoryGetADUserGroupMembership["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADUserGroupMembershipworkflow);
            if (activeDirectoryGetADUserGroupMembershippropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADUserGroupMembership;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADUserGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse> ActiveDirectoryModifyADUserStringPropertyByIdentity(Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity, Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityworkflow, Expression<Func<activeDirectoryModifyADUserStringPropertyByIdentitypropertiesListInputItem[]>> activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList = null, Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityaDServer = null, Expression<Func<bool>> activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserStringPropertyByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryModifyADUserStringPropertyByIdentity = new JObject();
            var activeDirectoryModifyADUserStringPropertyByIdentitypropCount = 0;
            activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserStringPropertyByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityuserIdentity);
            if (activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList != null)
            {
                activeDirectoryModifyADUserStringPropertyByIdentity["PropertiesList"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentitypropertiesList);
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            }

            if (activeDirectoryModifyADUserStringPropertyByIdentityaDServer != null)
            {
                activeDirectoryModifyADUserStringPropertyByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityaDServer);
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            }

            if (activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
            {
                if (activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue != null)
                {
                    activeDirectoryModifyADUserStringPropertyByIdentity["ReplaceValue"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityreplaceValue);
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
            activeDirectoryModifyADUserStringPropertyByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserStringPropertyByIdentityworkflow);
            if (activeDirectoryModifyADUserStringPropertyByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryModifyADUserStringPropertyByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse> ActiveDirectoryModifyADUserBooleanPropertyByIdentity(Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow, Expression<Func<bool>> activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue = null, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserBooleanPropertyByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryModifyADUserBooleanPropertyByIdentity = new JObject();
            var activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount = 0;
            activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserBooleanPropertyByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentityuserIdentity);
            activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyName);
            if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
            {
                if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue != null)
                {
                    activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentitypropertyValue);
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
                activeDirectoryModifyADUserBooleanPropertyByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentityaDServer);
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            }

            activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserBooleanPropertyByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserBooleanPropertyByIdentityworkflow);
            if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryModifyADUserBooleanPropertyByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse> ActiveDirectoryModifyADUserProperties(Expression<Func<string>> activeDirectoryModifyADUserPropertiesuserIdentity, Expression<Func<string>> activeDirectoryModifyADUserPropertiesworkflow, Expression<Func<string>> activeDirectoryModifyADUserPropertiescity = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescompany = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescountry = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescountryString = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiescountryISO3166 = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesdepartment = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesdescription = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesdisplayName = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesemailAddress = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesgivenName = null, Expression<Func<string>> activeDirectoryModifyADUserPropertieshomePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesinitials = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesiPPhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesmanager = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesmobilePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesnotes = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesoffice = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesofficePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiespostalCode = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesprofilePath = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesscriptPath = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesstate = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesstreetAddress = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiessurname = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiestitle = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryModifyADUserProperties = new JObject();
            var activeDirectoryModifyADUserPropertiespropCount = 0;
            activeDirectoryModifyADUserPropertiespropCount++;
            activeDirectoryModifyADUserProperties["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesuserIdentity);
            if (activeDirectoryModifyADUserPropertiescity != null)
            {
                activeDirectoryModifyADUserProperties["City"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescity);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiescompany != null)
            {
                activeDirectoryModifyADUserProperties["Company"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescompany);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiescountry != null)
            {
                activeDirectoryModifyADUserProperties["Country"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescountry);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiescountryString != null)
            {
                activeDirectoryModifyADUserProperties["CountryString"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescountryString);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiescountryISO3166 != null)
            {
                activeDirectoryModifyADUserProperties["CountryISO3166"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiescountryISO3166);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesdepartment != null)
            {
                activeDirectoryModifyADUserProperties["Department"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesdepartment);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesdescription != null)
            {
                activeDirectoryModifyADUserProperties["Description"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesdescription);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesdisplayName != null)
            {
                activeDirectoryModifyADUserProperties["DisplayName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesdisplayName);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesemailAddress != null)
            {
                activeDirectoryModifyADUserProperties["EmailAddress"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesemailAddress);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesgivenName != null)
            {
                activeDirectoryModifyADUserProperties["GivenName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesgivenName);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertieshomePhone != null)
            {
                activeDirectoryModifyADUserProperties["HomePhone"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertieshomePhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesinitials != null)
            {
                activeDirectoryModifyADUserProperties["Initials"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesinitials);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesiPPhone != null)
            {
                activeDirectoryModifyADUserProperties["IPPhone"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesiPPhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesmanager != null)
            {
                activeDirectoryModifyADUserProperties["Manager"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesmanager);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesmobilePhone != null)
            {
                activeDirectoryModifyADUserProperties["MobilePhone"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesmobilePhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesnotes != null)
            {
                activeDirectoryModifyADUserProperties["Notes"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesnotes);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesoffice != null)
            {
                activeDirectoryModifyADUserProperties["Office"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesoffice);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesofficePhone != null)
            {
                activeDirectoryModifyADUserProperties["OfficePhone"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesofficePhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiespostalCode != null)
            {
                activeDirectoryModifyADUserProperties["PostalCode"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiespostalCode);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesprofilePath != null)
            {
                activeDirectoryModifyADUserProperties["ProfilePath"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesprofilePath);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesscriptPath != null)
            {
                activeDirectoryModifyADUserProperties["ScriptPath"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesscriptPath);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesstate != null)
            {
                activeDirectoryModifyADUserProperties["State"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesstate);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesstreetAddress != null)
            {
                activeDirectoryModifyADUserProperties["StreetAddress"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesstreetAddress);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiessurname != null)
            {
                activeDirectoryModifyADUserProperties["Surname"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiessurname);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiestitle != null)
            {
                activeDirectoryModifyADUserProperties["Title"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiestitle);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesaDServer != null)
            {
                activeDirectoryModifyADUserProperties["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesaDServer);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            activeDirectoryModifyADUserPropertiespropCount++;
            activeDirectoryModifyADUserProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryModifyADUserPropertiesworkflow);
            if (activeDirectoryModifyADUserPropertiespropCount > 0)
            {
                callPayload.Body = activeDirectoryModifyADUserProperties;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse> ActiveDirectoryMoveADUserToOUByIdentity(Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityuserIdentity, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentitytargetPath, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityworkflow, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryMoveADUserToOUByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryMoveADUserToOUByIdentity = new JObject();
            var activeDirectoryMoveADUserToOUByIdentitypropCount = 0;
            activeDirectoryMoveADUserToOUByIdentitypropCount++;
            activeDirectoryMoveADUserToOUByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentityuserIdentity);
            activeDirectoryMoveADUserToOUByIdentitypropCount++;
            activeDirectoryMoveADUserToOUByIdentity["TargetPath"] = CSharpExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentitytargetPath);
            if (activeDirectoryMoveADUserToOUByIdentityaDServer != null)
            {
                activeDirectoryMoveADUserToOUByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentityaDServer);
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
            }

            activeDirectoryMoveADUserToOUByIdentitypropCount++;
            activeDirectoryMoveADUserToOUByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryMoveADUserToOUByIdentityworkflow);
            if (activeDirectoryMoveADUserToOUByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryMoveADUserToOUByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse> ActiveDirectoryClearADUserAccountExpiration(Expression<Func<string>> activeDirectoryClearADUserAccountExpirationuserIdentity, Expression<Func<string>> activeDirectoryClearADUserAccountExpirationworkflow, Expression<Func<string>> activeDirectoryClearADUserAccountExpirationaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryClearADUserAccountExpiration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryClearADUserAccountExpiration = new JObject();
            var activeDirectoryClearADUserAccountExpirationpropCount = 0;
            activeDirectoryClearADUserAccountExpirationpropCount++;
            activeDirectoryClearADUserAccountExpiration["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryClearADUserAccountExpirationuserIdentity);
            if (activeDirectoryClearADUserAccountExpirationaDServer != null)
            {
                activeDirectoryClearADUserAccountExpiration["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryClearADUserAccountExpirationaDServer);
                activeDirectoryClearADUserAccountExpirationpropCount++;
            }

            activeDirectoryClearADUserAccountExpirationpropCount++;
            activeDirectoryClearADUserAccountExpiration["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryClearADUserAccountExpirationworkflow);
            if (activeDirectoryClearADUserAccountExpirationpropCount > 0)
            {
                callPayload.Body = activeDirectoryClearADUserAccountExpiration;
            }

            return new ApiConnectionAction<ActiveDirectoryClearADUserAccountExpirationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse> ActiveDirectoryDirSync(Expression<Func<string>> activeDirectoryDirSyncworkflow, Expression<Func<activeDirectoryDirSyncpolicyTypeInput>> activeDirectoryDirSyncpolicyType = null, Expression<Func<string>> activeDirectoryDirSynccomputerName = null, Expression<Func<int>> activeDirectoryDirSyncmaxRetryAttempts = null, Expression<Func<int>> activeDirectoryDirSyncsecondsBetweenRetries = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDirSync";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryDirSync = new JObject();
            var activeDirectoryDirSyncpropCount = 0;
            if (activeDirectoryDirSyncpolicyType != null)
            {
                activeDirectoryDirSync["PolicyType"] = CSharpExpressionConverter.Convert(activeDirectoryDirSyncpolicyType);
                activeDirectoryDirSyncpropCount++;
            }

            if (activeDirectoryDirSynccomputerName != null)
            {
                activeDirectoryDirSync["ComputerName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDirSynccomputerName);
                activeDirectoryDirSyncpropCount++;
            }

            if (activeDirectoryDirSyncmaxRetryAttempts != null)
            {
                if (activeDirectoryDirSyncmaxRetryAttempts != null)
                {
                    activeDirectoryDirSync["MaxRetryAttempts"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDirSyncmaxRetryAttempts);
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
                    activeDirectoryDirSync["SecondsBetweenRetries"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDirSyncsecondsBetweenRetries);
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
            activeDirectoryDirSync["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDirSyncworkflow);
            if (activeDirectoryDirSyncpropCount > 0)
            {
                callPayload.Body = activeDirectoryDirSync;
            }

            return new ApiConnectionAction<ActiveDirectoryDirSyncResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse> ActiveDirectoryRemoveADUserByIdentity(Expression<Func<string>> activeDirectoryRemoveADUserByIdentityuserIdentity, Expression<Func<string>> activeDirectoryRemoveADUserByIdentityworkflow, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion = null, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects = null, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityforceDeleteRecursive = null, Expression<Func<string>> activeDirectoryRemoveADUserByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADUserByIdentity = new JObject();
            var activeDirectoryRemoveADUserByIdentitypropCount = 0;
            activeDirectoryRemoveADUserByIdentitypropCount++;
            activeDirectoryRemoveADUserByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityuserIdentity);
            if (activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
            {
                if (activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion != null)
                {
                    activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityremoveProtectionFromAccidentalDeletion);
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
                    activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentitydeleteEvenIfUserHasSubObjects);
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
                    activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityforceDeleteRecursive);
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
                activeDirectoryRemoveADUserByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityaDServer);
                activeDirectoryRemoveADUserByIdentitypropCount++;
            }

            activeDirectoryRemoveADUserByIdentitypropCount++;
            activeDirectoryRemoveADUserByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserByIdentityworkflow);
            if (activeDirectoryRemoveADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse> ActiveDirectoryResetADUserPasswordByIdentity(Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityuserIdentity, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentitynewPassword, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityworkflow, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitycannotChangePassword = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice = null, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryResetADUserPasswordByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryResetADUserPasswordByIdentity = new JObject();
            var activeDirectoryResetADUserPasswordByIdentitypropCount = 0;
            activeDirectoryResetADUserPasswordByIdentitypropCount++;
            activeDirectoryResetADUserPasswordByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityuserIdentity);
            activeDirectoryResetADUserPasswordByIdentitypropCount++;
            activeDirectoryResetADUserPasswordByIdentity["NewPassword"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitynewPassword);
            if (activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
            {
                if (activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword != null)
                {
                    activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityaccountPasswordIsStoredPassword);
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
                    activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitysetUserPasswordProperties);
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
                    activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitychangePasswordAtLogon);
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
                    activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitycannotChangePassword);
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
                    activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentitypasswordNeverExpires);
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
                    activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityresetPasswordTwice);
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
                activeDirectoryResetADUserPasswordByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityaDServer);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            activeDirectoryResetADUserPasswordByIdentitypropCount++;
            activeDirectoryResetADUserPasswordByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryResetADUserPasswordByIdentityworkflow);
            if (activeDirectoryResetADUserPasswordByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryResetADUserPasswordByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity(Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity, Expression<Func<bool>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion, Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow, Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity = new JObject();
            var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount = 0;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityuserIdentity);
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ProtectedFromAccidentalDeletion"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityprotectedFromAccidentalDeletion);
            if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer != null)
            {
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityaDServer);
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            }

            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityworkflow);
            if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse> ActiveDirectoryDisableADUserByIdentity(Expression<Func<string>> activeDirectoryDisableADUserByIdentityuserIdentity, Expression<Func<string>> activeDirectoryDisableADUserByIdentityworkflow, Expression<Func<string>> activeDirectoryDisableADUserByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDisableADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryDisableADUserByIdentity = new JObject();
            var activeDirectoryDisableADUserByIdentitypropCount = 0;
            activeDirectoryDisableADUserByIdentitypropCount++;
            activeDirectoryDisableADUserByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDisableADUserByIdentityuserIdentity);
            if (activeDirectoryDisableADUserByIdentityaDServer != null)
            {
                activeDirectoryDisableADUserByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDisableADUserByIdentityaDServer);
                activeDirectoryDisableADUserByIdentitypropCount++;
            }

            activeDirectoryDisableADUserByIdentitypropCount++;
            activeDirectoryDisableADUserByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDisableADUserByIdentityworkflow);
            if (activeDirectoryDisableADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryDisableADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryDisableADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse> ActiveDirectoryEnableADUserByIdentity(Expression<Func<string>> activeDirectoryEnableADUserByIdentityuserIdentity, Expression<Func<string>> activeDirectoryEnableADUserByIdentityworkflow, Expression<Func<string>> activeDirectoryEnableADUserByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryEnableADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryEnableADUserByIdentity = new JObject();
            var activeDirectoryEnableADUserByIdentitypropCount = 0;
            activeDirectoryEnableADUserByIdentitypropCount++;
            activeDirectoryEnableADUserByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryEnableADUserByIdentityuserIdentity);
            if (activeDirectoryEnableADUserByIdentityaDServer != null)
            {
                activeDirectoryEnableADUserByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryEnableADUserByIdentityaDServer);
                activeDirectoryEnableADUserByIdentitypropCount++;
            }

            activeDirectoryEnableADUserByIdentitypropCount++;
            activeDirectoryEnableADUserByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryEnableADUserByIdentityworkflow);
            if (activeDirectoryEnableADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryEnableADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryEnableADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse> ActiveDirectorySetADUserHomeFolderByIdentity(Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityuserIdentity, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityworkflow, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityhomeDrive = null, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityhomeDirectory = null, Expression<Func<bool>> activeDirectorySetADUserHomeFolderByIdentitycreateFolder = null, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserHomeFolderByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADUserHomeFolderByIdentity = new JObject();
            var activeDirectorySetADUserHomeFolderByIdentitypropCount = 0;
            activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            activeDirectorySetADUserHomeFolderByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityuserIdentity);
            if (activeDirectorySetADUserHomeFolderByIdentityhomeDrive != null)
            {
                activeDirectorySetADUserHomeFolderByIdentity["HomeDrive"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityhomeDrive);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            if (activeDirectorySetADUserHomeFolderByIdentityhomeDirectory != null)
            {
                activeDirectorySetADUserHomeFolderByIdentity["HomeDirectory"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityhomeDirectory);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            if (activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
            {
                if (activeDirectorySetADUserHomeFolderByIdentitycreateFolder != null)
                {
                    activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentitycreateFolder);
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
                activeDirectorySetADUserHomeFolderByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityaDServer);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            activeDirectorySetADUserHomeFolderByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserHomeFolderByIdentityworkflow);
            if (activeDirectorySetADUserHomeFolderByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectorySetADUserHomeFolderByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse> ActiveDirectoryCloneADUserGroups(Expression<Func<string>> activeDirectoryCloneADUserGroupssourceUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserGroupsdestinationUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserGroupsworkflow, Expression<Func<string>> activeDirectoryCloneADUserGroupsaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryCloneADUserGroups = new JObject();
            var activeDirectoryCloneADUserGroupspropCount = 0;
            activeDirectoryCloneADUserGroupspropCount++;
            activeDirectoryCloneADUserGroups["SourceUserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupssourceUserIdentity);
            activeDirectoryCloneADUserGroupspropCount++;
            activeDirectoryCloneADUserGroups["DestinationUserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupsdestinationUserIdentity);
            if (activeDirectoryCloneADUserGroupsaDServer != null)
            {
                activeDirectoryCloneADUserGroups["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupsaDServer);
                activeDirectoryCloneADUserGroupspropCount++;
            }

            activeDirectoryCloneADUserGroupspropCount++;
            activeDirectoryCloneADUserGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserGroupsworkflow);
            if (activeDirectoryCloneADUserGroupspropCount > 0)
            {
                callPayload.Body = activeDirectoryCloneADUserGroups;
            }

            return new ApiConnectionAction<ActiveDirectoryCloneADUserGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse> ActiveDirectoryCloneADUserProperties(Expression<Func<string>> activeDirectoryCloneADUserPropertiessourceUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserPropertiesdestinationUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserPropertiespropertiesToClone, Expression<Func<string>> activeDirectoryCloneADUserPropertiesworkflow, Expression<Func<string>> activeDirectoryCloneADUserPropertiesaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryCloneADUserProperties = new JObject();
            var activeDirectoryCloneADUserPropertiespropCount = 0;
            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["SourceUserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiessourceUserIdentity);
            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["DestinationUserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiesdestinationUserIdentity);
            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["PropertiesToClone"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiespropertiesToClone);
            if (activeDirectoryCloneADUserPropertiesaDServer != null)
            {
                activeDirectoryCloneADUserProperties["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiesaDServer);
                activeDirectoryCloneADUserPropertiespropCount++;
            }

            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCloneADUserPropertiesworkflow);
            if (activeDirectoryCloneADUserPropertiespropCount > 0)
            {
                callPayload.Body = activeDirectoryCloneADUserProperties;
            }

            return new ApiConnectionAction<ActiveDirectoryCloneADUserPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName(Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove = null, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer = null, Expression<Func<int>> activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromMultipleADGroupsByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADUserFromMultipleADGroupsByName = new JObject();
            var activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount = 0;
            activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            activeDirectoryRemoveADUserFromMultipleADGroupsByName["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameuserIdentity);
            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["GroupNamesJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNamegroupNamesJSON);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
            {
                if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove != null)
                {
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAnyGroupsFailToRemove);
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
                    activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameexceptionIfAllGroupsFailToRemove);
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
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameaDServer);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["MaxGroupsPerCall"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNamemaxGroupsPerCall);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            activeDirectoryRemoveADUserFromMultipleADGroupsByName["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromMultipleADGroupsByNameworkflow);
            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADUserFromMultipleADGroupsByName;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse> ActiveDirectoryRemoveADUserFromAllGroups(Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsworkflow, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsuserIdentity = null, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsaDServer = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromAllGroupsrunAsThread = null, Expression<Func<int>> activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId = null, Expression<Func<int>> activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromAllGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADUserFromAllGroups = new JObject();
            var activeDirectoryRemoveADUserFromAllGroupspropCount = 0;
            if (activeDirectoryRemoveADUserFromAllGroupsuserIdentity != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsuserIdentity);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["GroupsToExcludeJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsgroupsToExcludeJSON);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
            {
                if (activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsexceptionIfExcludedGroupDoesNotExist);
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
                activeDirectoryRemoveADUserFromAllGroups["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsaDServer);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
            {
                if (activeDirectoryRemoveADUserFromAllGroupsrunAsThread != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsrunAsThread);
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
                activeDirectoryRemoveADUserFromAllGroups["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsretrieveOutputDataFromThreadId);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
            {
                if (activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread != null)
                {
                    activeDirectoryRemoveADUserFromAllGroups["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupssecondsToWaitForThread);
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
            activeDirectoryRemoveADUserFromAllGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADUserFromAllGroupsworkflow);
            if (activeDirectoryRemoveADUserFromAllGroupspropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADUserFromAllGroups;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse> ActiveDirectoryCheckOUExists(Expression<Func<string>> activeDirectoryCheckOUExistsoUIdentity, Expression<Func<string>> activeDirectoryCheckOUExistsworkflow, Expression<Func<string>> activeDirectoryCheckOUExistsaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCheckOUExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryCheckOUExists = new JObject();
            var activeDirectoryCheckOUExistspropCount = 0;
            activeDirectoryCheckOUExistspropCount++;
            activeDirectoryCheckOUExists["OUIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCheckOUExistsoUIdentity);
            if (activeDirectoryCheckOUExistsaDServer != null)
            {
                activeDirectoryCheckOUExists["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCheckOUExistsaDServer);
                activeDirectoryCheckOUExistspropCount++;
            }

            activeDirectoryCheckOUExistspropCount++;
            activeDirectoryCheckOUExists["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryCheckOUExistsworkflow);
            if (activeDirectoryCheckOUExistspropCount > 0)
            {
                callPayload.Body = activeDirectoryCheckOUExists;
            }

            return new ApiConnectionAction<ActiveDirectoryCheckOUExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse> ActiveDirectoryRemoveADGroupMemberByGroupIdentity(Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName = null, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroupMemberByGroupIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADGroupMemberByGroupIdentity = new JObject();
            var activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount = 0;
            if (activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity != null)
            {
                activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupIdentity);
                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            }

            if (activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName != null)
            {
                activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentitygroupName);
                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            }

            activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            activeDirectoryRemoveADGroupMemberByGroupIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentityuserIdentity);
            if (activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer != null)
            {
                activeDirectoryRemoveADGroupMemberByGroupIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentityaDServer);
                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            }

            activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            activeDirectoryRemoveADGroupMemberByGroupIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupMemberByGroupIdentityworkflow);
            if (activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADGroupMemberByGroupIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity(Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity = null, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall = null, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveMultipleADGroupMembersByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveMultipleADGroupMembersByIdentity = new JObject();
            var activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount = 0;
            if (activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupIdentity);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupMembersJSON"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentitygroupMembersJSON);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
            {
                if (activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove != null)
                {
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAnyMembersFailToRemove);
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
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityexceptionIfAllMembersFailToRemove);
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
                    activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityremoveAllMembersInASingleCall);
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
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityaDServer);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            activeDirectoryRemoveMultipleADGroupMembersByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveMultipleADGroupMembersByIdentityworkflow);
            if (activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveMultipleADGroupMembersByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse> ActiveDirectoryUnlockADAccountByIdentity(Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityuserIdentity, Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityworkflow, Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryUnlockADAccountByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryUnlockADAccountByIdentity = new JObject();
            var activeDirectoryUnlockADAccountByIdentitypropCount = 0;
            activeDirectoryUnlockADAccountByIdentitypropCount++;
            activeDirectoryUnlockADAccountByIdentity["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryUnlockADAccountByIdentityuserIdentity);
            if (activeDirectoryUnlockADAccountByIdentityaDServer != null)
            {
                activeDirectoryUnlockADAccountByIdentity["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryUnlockADAccountByIdentityaDServer);
                activeDirectoryUnlockADAccountByIdentitypropCount++;
            }

            activeDirectoryUnlockADAccountByIdentitypropCount++;
            activeDirectoryUnlockADAccountByIdentity["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryUnlockADAccountByIdentityworkflow);
            if (activeDirectoryUnlockADAccountByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryUnlockADAccountByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse> ActiveDirectorySetADServer(Expression<Func<string>> activeDirectorySetADServerworkflow, Expression<Func<activeDirectorySetADServerpredefinedADServerChoiceInput>> activeDirectorySetADServerpredefinedADServerChoice = null, Expression<Func<string>> activeDirectorySetADServeraDServer = null)
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
                    activeDirectorySetADServer["PredefinedADServerChoice"] = CSharpExpressionConverter.Convert(activeDirectorySetADServerpredefinedADServerChoice);
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
                activeDirectorySetADServer["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADServeraDServer);
                activeDirectorySetADServerpropCount++;
            }

            activeDirectorySetADServerpropCount++;
            activeDirectorySetADServer["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADServerworkflow);
            if (activeDirectorySetADServerpropCount > 0)
            {
                callPayload.Body = activeDirectorySetADServer;
            }

            return new ApiConnectionAction<ActiveDirectorySetADServerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse> ActiveDirectoryGetDomainInfo(Expression<Func<string>> activeDirectoryGetDomainInfoworkflow, Expression<Func<string>> activeDirectoryGetDomainInfoaDServer = null, Expression<Func<activeDirectoryGetDomainInfopredefinedIdentityInput>> activeDirectoryGetDomainInfopredefinedIdentity = null, Expression<Func<string>> activeDirectoryGetDomainInfoidentity = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetDomainInfo = new JObject();
            var activeDirectoryGetDomainInfopropCount = 0;
            if (activeDirectoryGetDomainInfoaDServer != null)
            {
                activeDirectoryGetDomainInfo["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetDomainInfoaDServer);
                activeDirectoryGetDomainInfopropCount++;
            }

            if (activeDirectoryGetDomainInfopredefinedIdentity != null)
            {
                if (activeDirectoryGetDomainInfopredefinedIdentity != null)
                {
                    activeDirectoryGetDomainInfo["PredefinedIdentity"] = CSharpExpressionConverter.Convert(activeDirectoryGetDomainInfopredefinedIdentity);
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
                activeDirectoryGetDomainInfo["Identity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetDomainInfoidentity);
                activeDirectoryGetDomainInfopropCount++;
            }

            activeDirectoryGetDomainInfopropCount++;
            activeDirectoryGetDomainInfo["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetDomainInfoworkflow);
            if (activeDirectoryGetDomainInfopropCount > 0)
            {
                callPayload.Body = activeDirectoryGetDomainInfo;
            }

            return new ApiConnectionAction<ActiveDirectoryGetDomainInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse> ActiveDirectoryAddADGroup(Expression<Func<string>> activeDirectoryAddADGroupname, Expression<Func<activeDirectoryAddADGroupgroupCategoryInput>> activeDirectoryAddADGroupgroupCategory, Expression<Func<activeDirectoryAddADGroupgroupScopeInput>> activeDirectoryAddADGroupgroupScope, Expression<Func<string>> activeDirectoryAddADGroupworkflow, Expression<Func<string>> activeDirectoryAddADGroupsamAccountName = null, Expression<Func<string>> activeDirectoryAddADGrouppath = null, Expression<Func<string>> activeDirectoryAddADGroupdescription = null, Expression<Func<string>> activeDirectoryAddADGroupnotes = null, Expression<Func<string>> activeDirectoryAddADGroupdisplayName = null, Expression<Func<string>> activeDirectoryAddADGrouphomePage = null, Expression<Func<string>> activeDirectoryAddADGroupmanagedBy = null, Expression<Func<bool>> activeDirectoryAddADGroupprotectedFromAccidentalDeletion = null, Expression<Func<string>> activeDirectoryAddADGroupaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADGroup = new JObject();
            var activeDirectoryAddADGrouppropCount = 0;
            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["Name"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupname);
            if (activeDirectoryAddADGroupsamAccountName != null)
            {
                activeDirectoryAddADGroup["SamAccountName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupsamAccountName);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGrouppath != null)
            {
                activeDirectoryAddADGroup["Path"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGrouppath);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupdescription != null)
            {
                activeDirectoryAddADGroup["Description"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupdescription);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupnotes != null)
            {
                activeDirectoryAddADGroup["Notes"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupnotes);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupdisplayName != null)
            {
                activeDirectoryAddADGroup["DisplayName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupdisplayName);
                activeDirectoryAddADGrouppropCount++;
            }

            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["GroupCategory"] = CSharpExpressionConverter.Convert(activeDirectoryAddADGroupgroupCategory);
            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["GroupScope"] = CSharpExpressionConverter.Convert(activeDirectoryAddADGroupgroupScope);
            if (activeDirectoryAddADGrouphomePage != null)
            {
                activeDirectoryAddADGroup["HomePage"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGrouphomePage);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupmanagedBy != null)
            {
                activeDirectoryAddADGroup["ManagedBy"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupmanagedBy);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
            {
                if (activeDirectoryAddADGroupprotectedFromAccidentalDeletion != null)
                {
                    activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupprotectedFromAccidentalDeletion);
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
                activeDirectoryAddADGroup["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupaDServer);
                activeDirectoryAddADGrouppropCount++;
            }

            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddADGroupworkflow);
            if (activeDirectoryAddADGrouppropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADGroup;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse> ActiveDirectoryDoesADGroupExist(Expression<Func<string>> activeDirectoryDoesADGroupExistgroupIdentity, Expression<Func<string>> activeDirectoryDoesADGroupExistworkflow, Expression<Func<string>> activeDirectoryDoesADGroupExistaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDoesADGroupExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryDoesADGroupExist = new JObject();
            var activeDirectoryDoesADGroupExistpropCount = 0;
            activeDirectoryDoesADGroupExistpropCount++;
            activeDirectoryDoesADGroupExist["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDoesADGroupExistgroupIdentity);
            if (activeDirectoryDoesADGroupExistaDServer != null)
            {
                activeDirectoryDoesADGroupExist["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDoesADGroupExistaDServer);
                activeDirectoryDoesADGroupExistpropCount++;
            }

            activeDirectoryDoesADGroupExistpropCount++;
            activeDirectoryDoesADGroupExist["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryDoesADGroupExistworkflow);
            if (activeDirectoryDoesADGroupExistpropCount > 0)
            {
                callPayload.Body = activeDirectoryDoesADGroupExist;
            }

            return new ApiConnectionAction<ActiveDirectoryDoesADGroupExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse> ActiveDirectoryRemoveADGroup(Expression<Func<string>> activeDirectoryRemoveADGroupgroupIdentity, Expression<Func<string>> activeDirectoryRemoveADGroupworkflow, Expression<Func<bool>> activeDirectoryRemoveADGroupdeleteEvenIfProtected = null, Expression<Func<bool>> activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveADGroupaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADGroup = new JObject();
            var activeDirectoryRemoveADGrouppropCount = 0;
            activeDirectoryRemoveADGrouppropCount++;
            activeDirectoryRemoveADGroup["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupgroupIdentity);
            if (activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
            {
                if (activeDirectoryRemoveADGroupdeleteEvenIfProtected != null)
                {
                    activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupdeleteEvenIfProtected);
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
                    activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupraiseExceptionIfGroupDoesNotExist);
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
                activeDirectoryRemoveADGroup["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupaDServer);
                activeDirectoryRemoveADGrouppropCount++;
            }

            activeDirectoryRemoveADGrouppropCount++;
            activeDirectoryRemoveADGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveADGroupworkflow);
            if (activeDirectoryRemoveADGrouppropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADGroup;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse> ActiveDirectoryAddOU(Expression<Func<string>> activeDirectoryAddOUname, Expression<Func<string>> activeDirectoryAddOUworkflow, Expression<Func<string>> activeDirectoryAddOUpath = null, Expression<Func<string>> activeDirectoryAddOUdescription = null, Expression<Func<string>> activeDirectoryAddOUdisplayName = null, Expression<Func<string>> activeDirectoryAddOUmanagedBy = null, Expression<Func<bool>> activeDirectoryAddOUprotectedFromAccidentalDeletion = null, Expression<Func<string>> activeDirectoryAddOUstreetAddress = null, Expression<Func<string>> activeDirectoryAddOUcity = null, Expression<Func<string>> activeDirectoryAddOUstate = null, Expression<Func<string>> activeDirectoryAddOUpostalCode = null, Expression<Func<string>> activeDirectoryAddOUaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddOU";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddOU = new JObject();
            var activeDirectoryAddOUpropCount = 0;
            activeDirectoryAddOUpropCount++;
            activeDirectoryAddOU["Name"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUname);
            if (activeDirectoryAddOUpath != null)
            {
                activeDirectoryAddOU["Path"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUpath);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUdescription != null)
            {
                activeDirectoryAddOU["Description"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUdescription);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUdisplayName != null)
            {
                activeDirectoryAddOU["DisplayName"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUdisplayName);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUmanagedBy != null)
            {
                activeDirectoryAddOU["ManagedBy"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUmanagedBy);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
            {
                if (activeDirectoryAddOUprotectedFromAccidentalDeletion != null)
                {
                    activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUprotectedFromAccidentalDeletion);
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
                activeDirectoryAddOU["StreetAddress"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUstreetAddress);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUcity != null)
            {
                activeDirectoryAddOU["City"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUcity);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUstate != null)
            {
                activeDirectoryAddOU["State"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUstate);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUpostalCode != null)
            {
                activeDirectoryAddOU["PostalCode"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUpostalCode);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUaDServer != null)
            {
                activeDirectoryAddOU["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUaDServer);
                activeDirectoryAddOUpropCount++;
            }

            activeDirectoryAddOUpropCount++;
            activeDirectoryAddOU["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryAddOUworkflow);
            if (activeDirectoryAddOUpropCount > 0)
            {
                callPayload.Body = activeDirectoryAddOU;
            }

            return new ApiConnectionAction<ActiveDirectoryAddOUResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse> ActiveDirectoryRemoveOU(Expression<Func<string>> activeDirectoryRemoveOUoUIdentity, Expression<Func<string>> activeDirectoryRemoveOUworkflow, Expression<Func<bool>> activeDirectoryRemoveOUdeleteEvenIfProtected = null, Expression<Func<bool>> activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveOUaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveOU";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveOU = new JObject();
            var activeDirectoryRemoveOUpropCount = 0;
            activeDirectoryRemoveOUpropCount++;
            activeDirectoryRemoveOU["OUIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveOUoUIdentity);
            if (activeDirectoryRemoveOUdeleteEvenIfProtected != null)
            {
                if (activeDirectoryRemoveOUdeleteEvenIfProtected != null)
                {
                    activeDirectoryRemoveOU["DeleteEvenIfProtected"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveOUdeleteEvenIfProtected);
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
                    activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveOUraiseExceptionIfOUDoesNotExist);
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
                activeDirectoryRemoveOU["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveOUaDServer);
                activeDirectoryRemoveOUpropCount++;
            }

            activeDirectoryRemoveOUpropCount++;
            activeDirectoryRemoveOU["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryRemoveOUworkflow);
            if (activeDirectoryRemoveOUpropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveOU;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveOUResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse> ActiveDirectorySetADUserAccountExpirationEndOfDate(Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateyear, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDatemonth, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateday, Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateworkflow, Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserAccountExpirationEndOfDate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADUserAccountExpirationEndOfDate = new JObject();
            var activeDirectorySetADUserAccountExpirationEndOfDatepropCount = 0;
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["UserIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateuserIdentity);
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Year"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateyear);
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Month"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDatemonth);
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Day"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateday);
            if (activeDirectorySetADUserAccountExpirationEndOfDateaDServer != null)
            {
                activeDirectorySetADUserAccountExpirationEndOfDate["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateaDServer);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            }

            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectorySetADUserAccountExpirationEndOfDateworkflow);
            if (activeDirectorySetADUserAccountExpirationEndOfDatepropCount > 0)
            {
                callPayload.Body = activeDirectorySetADUserAccountExpirationEndOfDate;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse> ActiveDirectoryGetADGroupMembers(Expression<Func<string>> activeDirectoryGetADGroupMembersgroupIdentity, Expression<Func<string>> activeDirectoryGetADGroupMembersworkflow, Expression<Func<bool>> activeDirectoryGetADGroupMembersrecursive = null, Expression<Func<string>> activeDirectoryGetADGroupMembersaDServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADGroupMembers = new JObject();
            var activeDirectoryGetADGroupMemberspropCount = 0;
            activeDirectoryGetADGroupMemberspropCount++;
            activeDirectoryGetADGroupMembers["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersgroupIdentity);
            if (activeDirectoryGetADGroupMembersrecursive != null)
            {
                if (activeDirectoryGetADGroupMembersrecursive != null)
                {
                    activeDirectoryGetADGroupMembers["Recursive"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersrecursive);
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
                activeDirectoryGetADGroupMembers["ADServer"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersaDServer);
                activeDirectoryGetADGroupMemberspropCount++;
            }

            activeDirectoryGetADGroupMemberspropCount++;
            activeDirectoryGetADGroupMembers["Workflow"] = CSharpExpressionConverter.ConvertToken(activeDirectoryGetADGroupMembersworkflow);
            if (activeDirectoryGetADGroupMemberspropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADGroupMembers;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse> OpenExchangePowerShellRunspace(Expression<Func<string>> openExchangePowerShellRunspaceexchangeServerFQDN, Expression<Func<string>> openExchangePowerShellRunspaceworkflow, Expression<Func<string>> openExchangePowerShellRunspaceusername = null, Expression<Func<string>> openExchangePowerShellRunspacepassword = null, Expression<Func<bool>> openExchangePowerShellRunspaceuseSSL = null, Expression<Func<openExchangePowerShellRunspaceconnectionMethodInput>> openExchangePowerShellRunspaceconnectionMethod = null, Expression<Func<openExchangePowerShellRunspaceauthenticationMechanismInput>> openExchangePowerShellRunspaceauthenticationMechanism = null, Expression<Func<bool>> openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, Expression<Func<openExchangePowerShellRunspacecommandTypesToImportLocallyInput>> openExchangePowerShellRunspacecommandTypesToImportLocally = null, Expression<Func<string>> openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenExchangePowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openExchangePowerShellRunspace = new JObject();
            var openExchangePowerShellRunspacepropCount = 0;
            if (openExchangePowerShellRunspaceusername != null)
            {
                openExchangePowerShellRunspace["Username"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspaceusername);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspacepassword != null)
            {
                openExchangePowerShellRunspace["Password"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspacepassword);
                openExchangePowerShellRunspacepropCount++;
            }

            openExchangePowerShellRunspacepropCount++;
            openExchangePowerShellRunspace["ExchangeServerFQDN"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspaceexchangeServerFQDN);
            if (openExchangePowerShellRunspaceuseSSL != null)
            {
                if (openExchangePowerShellRunspaceuseSSL != null)
                {
                    openExchangePowerShellRunspace["UseSSL"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspaceuseSSL);
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
                    openExchangePowerShellRunspace["ConnectionMethod"] = CSharpExpressionConverter.Convert(openExchangePowerShellRunspaceconnectionMethod);
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
                    openExchangePowerShellRunspace["AuthenticationMechanism"] = CSharpExpressionConverter.Convert(openExchangePowerShellRunspaceauthenticationMechanism);
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
                    openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspaceonlyConnectIfNotAlreadyConnected);
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
                    openExchangePowerShellRunspace["CommandTypesToImportLocally"] = CSharpExpressionConverter.Convert(openExchangePowerShellRunspacecommandTypesToImportLocally);
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
                openExchangePowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                openExchangePowerShellRunspacepropCount++;
            }

            openExchangePowerShellRunspacepropCount++;
            openExchangePowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(openExchangePowerShellRunspaceworkflow);
            if (openExchangePowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openExchangePowerShellRunspace;
            }

            return new ApiConnectionAction<OpenExchangePowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse> IsExchangePowerShellRunspaceOpen(Expression<Func<string>> isExchangePowerShellRunspaceOpenworkflow, Expression<Func<bool>> isExchangePowerShellRunspaceOpentestCommunications = null, Expression<Func<bool>> isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
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
                    isExchangePowerShellRunspaceOpen["TestCommunications"] = CSharpExpressionConverter.ConvertToken(isExchangePowerShellRunspaceOpentestCommunications);
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
                    isExchangePowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = CSharpExpressionConverter.ConvertToken(isExchangePowerShellRunspaceOpenretrievePowerShellRunSpacePID);
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
            isExchangePowerShellRunspaceOpen["Workflow"] = CSharpExpressionConverter.ConvertToken(isExchangePowerShellRunspaceOpenworkflow);
            if (isExchangePowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isExchangePowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsExchangePowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse> RunExchangePowerShellAutomationScript(Expression<Func<string>> runExchangePowerShellAutomationScriptworkflow, Expression<Func<string>> runExchangePowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runExchangePowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runExchangePowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runExchangePowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunExchangePowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runExchangePowerShellAutomationScript = new JObject();
            var runExchangePowerShellAutomationScriptpropCount = 0;
            if (runExchangePowerShellAutomationScriptpowerShellScriptContents != null)
            {
                runExchangePowerShellAutomationScript["PowerShellScriptContents"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpowerShellScriptContents);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptisNoResultAnError != null)
            {
                if (runExchangePowerShellAutomationScriptisNoResultAnError != null)
                {
                    runExchangePowerShellAutomationScript["IsNoResultAnError"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptisNoResultAnError);
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
                    runExchangePowerShellAutomationScript["ReturnComplexTypes"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnComplexTypes);
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
                    runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnBooleanAsBoolean);
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
                    runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnNumericAsDecimal);
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
                    runExchangePowerShellAutomationScript["ReturnDateAsDate"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptreturnDateAsDate);
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
                runExchangePowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptrunScriptAsThread != null)
            {
                if (runExchangePowerShellAutomationScriptrunScriptAsThread != null)
                {
                    runExchangePowerShellAutomationScript["RunScriptAsThread"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptrunScriptAsThread);
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
                runExchangePowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptretrieveOutputDataFromThreadId);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
            {
                if (runExchangePowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptsecondsToWaitForThread);
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
                    runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptscriptContainsStoredPassword);
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
                    runExchangePowerShellAutomationScript["LogVerboseOutput"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptlogVerboseOutput);
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
                runExchangePowerShellAutomationScript["PropertyNamesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpropertyNamesToSerializeJSON);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
            {
                runExchangePowerShellAutomationScript["PropertyTypesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpropertyTypesToSerializeJSON);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptpowerShellCommandParameters != null)
            {
                runExchangePowerShellAutomationScript["PowerShellCommandParameters"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptpowerShellCommandParameters);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            runExchangePowerShellAutomationScriptpropCount++;
            runExchangePowerShellAutomationScript["Workflow"] = CSharpExpressionConverter.ConvertToken(runExchangePowerShellAutomationScriptworkflow);
            if (runExchangePowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runExchangePowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunExchangePowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse> CloseExchangePowerShellRunspace(Expression<Func<string>> closeExchangePowerShellRunspaceworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/CloseExchangePowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeExchangePowerShellRunspace = new JObject();
            var closeExchangePowerShellRunspacepropCount = 0;
            closeExchangePowerShellRunspacepropCount++;
            closeExchangePowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(closeExchangePowerShellRunspaceworkflow);
            if (closeExchangePowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeExchangePowerShellRunspace;
            }

            return new ApiConnectionAction<CloseExchangePowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse> ExchangeGetMailbox(Expression<Func<string>> exchangeGetMailboxworkflow, Expression<Func<string>> exchangeGetMailboxidentity = null, Expression<Func<string>> exchangeGetMailboxfilterPropertyName = null, Expression<Func<exchangeGetMailboxfilterPropertyComparisonInput>> exchangeGetMailboxfilterPropertyComparison = null, Expression<Func<string>> exchangeGetMailboxfilterPropertyValue = null, Expression<Func<exchangeGetMailboxrecipientTypeDetailsInput>> exchangeGetMailboxrecipientTypeDetails = null, Expression<Func<bool>> exchangeGetMailboxnoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetMailbox = new JObject();
            var exchangeGetMailboxpropCount = 0;
            if (exchangeGetMailboxidentity != null)
            {
                exchangeGetMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxidentity);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxfilterPropertyName != null)
            {
                exchangeGetMailbox["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxfilterPropertyName);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxfilterPropertyComparison != null)
            {
                if (exchangeGetMailboxfilterPropertyComparison != null)
                {
                    exchangeGetMailbox["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(exchangeGetMailboxfilterPropertyComparison);
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
                exchangeGetMailbox["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxfilterPropertyValue);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxrecipientTypeDetails != null)
            {
                exchangeGetMailbox["RecipientTypeDetails"] = CSharpExpressionConverter.Convert(exchangeGetMailboxrecipientTypeDetails);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxnoResultIsAnException != null)
            {
                if (exchangeGetMailboxnoResultIsAnException != null)
                {
                    exchangeGetMailbox["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxnoResultIsAnException);
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
            exchangeGetMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxworkflow);
            if (exchangeGetMailboxpropCount > 0)
            {
                callPayload.Body = exchangeGetMailbox;
            }

            return new ApiConnectionAction<ExchangeGetMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse> ExchangeDoesMailboxExist(Expression<Func<string>> exchangeDoesMailboxExistworkflow, Expression<Func<string>> exchangeDoesMailboxExistidentity = null, Expression<Func<string>> exchangeDoesMailboxExistfilterPropertyName = null, Expression<Func<exchangeDoesMailboxExistfilterPropertyComparisonInput>> exchangeDoesMailboxExistfilterPropertyComparison = null, Expression<Func<string>> exchangeDoesMailboxExistfilterPropertyValue = null, Expression<Func<exchangeDoesMailboxExistrecipientTypeDetailsInput>> exchangeDoesMailboxExistrecipientTypeDetails = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDoesMailboxExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDoesMailboxExist = new JObject();
            var exchangeDoesMailboxExistpropCount = 0;
            if (exchangeDoesMailboxExistidentity != null)
            {
                exchangeDoesMailboxExist["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeDoesMailboxExistidentity);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistfilterPropertyName != null)
            {
                exchangeDoesMailboxExist["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(exchangeDoesMailboxExistfilterPropertyName);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistfilterPropertyComparison != null)
            {
                if (exchangeDoesMailboxExistfilterPropertyComparison != null)
                {
                    exchangeDoesMailboxExist["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(exchangeDoesMailboxExistfilterPropertyComparison);
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
                exchangeDoesMailboxExist["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(exchangeDoesMailboxExistfilterPropertyValue);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistrecipientTypeDetails != null)
            {
                exchangeDoesMailboxExist["RecipientTypeDetails"] = CSharpExpressionConverter.Convert(exchangeDoesMailboxExistrecipientTypeDetails);
                exchangeDoesMailboxExistpropCount++;
            }

            exchangeDoesMailboxExistpropCount++;
            exchangeDoesMailboxExist["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeDoesMailboxExistworkflow);
            if (exchangeDoesMailboxExistpropCount > 0)
            {
                callPayload.Body = exchangeDoesMailboxExist;
            }

            return new ApiConnectionAction<ExchangeDoesMailboxExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse> ExchangeAddDistributionGroupMember(Expression<Func<string>> exchangeAddDistributionGroupMemberidentity, Expression<Func<string>> exchangeAddDistributionGroupMembermember, Expression<Func<string>> exchangeAddDistributionGroupMemberworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeAddDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeAddDistributionGroupMember = new JObject();
            var exchangeAddDistributionGroupMemberpropCount = 0;
            exchangeAddDistributionGroupMemberpropCount++;
            exchangeAddDistributionGroupMember["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeAddDistributionGroupMemberidentity);
            exchangeAddDistributionGroupMemberpropCount++;
            exchangeAddDistributionGroupMember["Member"] = CSharpExpressionConverter.ConvertToken(exchangeAddDistributionGroupMembermember);
            exchangeAddDistributionGroupMemberpropCount++;
            exchangeAddDistributionGroupMember["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeAddDistributionGroupMemberworkflow);
            if (exchangeAddDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = exchangeAddDistributionGroupMember;
            }

            return new ApiConnectionAction<ExchangeAddDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse> ExchangeRemoveDistributionGroupMember(Expression<Func<string>> exchangeRemoveDistributionGroupMemberidentity, Expression<Func<string>> exchangeRemoveDistributionGroupMembermember, Expression<Func<string>> exchangeRemoveDistributionGroupMemberworkflow, Expression<Func<bool>> exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeRemoveDistributionGroupMember = new JObject();
            var exchangeRemoveDistributionGroupMemberpropCount = 0;
            exchangeRemoveDistributionGroupMemberpropCount++;
            exchangeRemoveDistributionGroupMember["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMemberidentity);
            exchangeRemoveDistributionGroupMemberpropCount++;
            exchangeRemoveDistributionGroupMember["Member"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMembermember);
            if (exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
            {
                if (exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    exchangeRemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
            exchangeRemoveDistributionGroupMember["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupMemberworkflow);
            if (exchangeRemoveDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = exchangeRemoveDistributionGroupMember;
            }

            return new ApiConnectionAction<ExchangeRemoveDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse> ExchangeGetDistributionGroup(Expression<Func<string>> exchangeGetDistributionGroupworkflow, Expression<Func<string>> exchangeGetDistributionGroupidentity = null, Expression<Func<string>> exchangeGetDistributionGroupfilterPropertyName = null, Expression<Func<exchangeGetDistributionGroupfilterPropertyComparisonInput>> exchangeGetDistributionGroupfilterPropertyComparison = null, Expression<Func<string>> exchangeGetDistributionGroupfilterPropertyValue = null, Expression<Func<bool>> exchangeGetDistributionGroupnoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetDistributionGroup = new JObject();
            var exchangeGetDistributionGrouppropCount = 0;
            if (exchangeGetDistributionGroupidentity != null)
            {
                exchangeGetDistributionGroup["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupidentity);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupfilterPropertyName != null)
            {
                exchangeGetDistributionGroup["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupfilterPropertyName);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupfilterPropertyComparison != null)
            {
                if (exchangeGetDistributionGroupfilterPropertyComparison != null)
                {
                    exchangeGetDistributionGroup["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(exchangeGetDistributionGroupfilterPropertyComparison);
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
                exchangeGetDistributionGroup["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupfilterPropertyValue);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupnoResultIsAnException != null)
            {
                if (exchangeGetDistributionGroupnoResultIsAnException != null)
                {
                    exchangeGetDistributionGroup["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupnoResultIsAnException);
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
            exchangeGetDistributionGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupworkflow);
            if (exchangeGetDistributionGrouppropCount > 0)
            {
                callPayload.Body = exchangeGetDistributionGroup;
            }

            return new ApiConnectionAction<ExchangeGetDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse> ExchangeGetDistributionGroupMembers(Expression<Func<string>> exchangeGetDistributionGroupMembersidentity, Expression<Func<string>> exchangeGetDistributionGroupMembersworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetDistributionGroupMembers = new JObject();
            var exchangeGetDistributionGroupMemberspropCount = 0;
            exchangeGetDistributionGroupMemberspropCount++;
            exchangeGetDistributionGroupMembers["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupMembersidentity);
            exchangeGetDistributionGroupMemberspropCount++;
            exchangeGetDistributionGroupMembers["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetDistributionGroupMembersworkflow);
            if (exchangeGetDistributionGroupMemberspropCount > 0)
            {
                callPayload.Body = exchangeGetDistributionGroupMembers;
            }

            return new ApiConnectionAction<ExchangeGetDistributionGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse> ExchangeGetMailboxDistributionGroupMembership(Expression<Func<string>> exchangeGetMailboxDistributionGroupMembershipidentity, Expression<Func<string>> exchangeGetMailboxDistributionGroupMembershipworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxDistributionGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetMailboxDistributionGroupMembership = new JObject();
            var exchangeGetMailboxDistributionGroupMembershippropCount = 0;
            exchangeGetMailboxDistributionGroupMembershippropCount++;
            exchangeGetMailboxDistributionGroupMembership["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxDistributionGroupMembershipidentity);
            exchangeGetMailboxDistributionGroupMembershippropCount++;
            exchangeGetMailboxDistributionGroupMembership["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxDistributionGroupMembershipworkflow);
            if (exchangeGetMailboxDistributionGroupMembershippropCount > 0)
            {
                callPayload.Body = exchangeGetMailboxDistributionGroupMembership;
            }

            return new ApiConnectionAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse> ExchangeNewDistributionGroup(Expression<Func<string>> exchangeNewDistributionGroupname, Expression<Func<string>> exchangeNewDistributionGroupworkflow, Expression<Func<string>> exchangeNewDistributionGroupalias = null, Expression<Func<string>> exchangeNewDistributionGroupdisplayName = null, Expression<Func<string>> exchangeNewDistributionGroupnotes = null, Expression<Func<string>> exchangeNewDistributionGroupmanagedBy = null, Expression<Func<string>> exchangeNewDistributionGroupmembers = null, Expression<Func<string>> exchangeNewDistributionGrouporganizationalUnit = null, Expression<Func<string>> exchangeNewDistributionGroupprimarySmtpAddress = null, Expression<Func<exchangeNewDistributionGroupmemberDepartRestrictionInput>> exchangeNewDistributionGroupmemberDepartRestriction = null, Expression<Func<exchangeNewDistributionGroupmemberJoinRestrictionInput>> exchangeNewDistributionGroupmemberJoinRestriction = null, Expression<Func<bool>> exchangeNewDistributionGrouprequireSenderAuthenticationEnabled = null, Expression<Func<exchangeNewDistributionGrouptypeInput>> exchangeNewDistributionGrouptype = null, Expression<Func<bool>> exchangeNewDistributionGrouperrorIfGroupAlreadyExists = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeNewDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeNewDistributionGroup = new JObject();
            var exchangeNewDistributionGrouppropCount = 0;
            exchangeNewDistributionGrouppropCount++;
            exchangeNewDistributionGroup["Name"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupname);
            if (exchangeNewDistributionGroupalias != null)
            {
                exchangeNewDistributionGroup["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupalias);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupdisplayName != null)
            {
                exchangeNewDistributionGroup["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupdisplayName);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupnotes != null)
            {
                exchangeNewDistributionGroup["Notes"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupnotes);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupmanagedBy != null)
            {
                exchangeNewDistributionGroup["ManagedBy"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupmanagedBy);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupmembers != null)
            {
                exchangeNewDistributionGroup["Members"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupmembers);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGrouporganizationalUnit != null)
            {
                exchangeNewDistributionGroup["OrganizationalUnit"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGrouporganizationalUnit);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupprimarySmtpAddress != null)
            {
                exchangeNewDistributionGroup["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupprimarySmtpAddress);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupmemberDepartRestriction != null)
            {
                if (exchangeNewDistributionGroupmemberDepartRestriction != null)
                {
                    exchangeNewDistributionGroup["MemberDepartRestriction"] = CSharpExpressionConverter.Convert(exchangeNewDistributionGroupmemberDepartRestriction);
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
                    exchangeNewDistributionGroup["MemberJoinRestriction"] = CSharpExpressionConverter.Convert(exchangeNewDistributionGroupmemberJoinRestriction);
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
                    exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGrouprequireSenderAuthenticationEnabled);
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
                    exchangeNewDistributionGroup["Type"] = CSharpExpressionConverter.Convert(exchangeNewDistributionGrouptype);
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
                    exchangeNewDistributionGroup["ErrorIfGroupAlreadyExists"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGrouperrorIfGroupAlreadyExists);
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
            exchangeNewDistributionGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeNewDistributionGroupworkflow);
            if (exchangeNewDistributionGrouppropCount > 0)
            {
                callPayload.Body = exchangeNewDistributionGroup;
            }

            return new ApiConnectionAction<ExchangeNewDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse> ExchangeRemoveDistributionGroup(Expression<Func<string>> exchangeRemoveDistributionGroupidentity, Expression<Func<string>> exchangeRemoveDistributionGroupworkflow, Expression<Func<bool>> exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeRemoveDistributionGroup = new JObject();
            var exchangeRemoveDistributionGrouppropCount = 0;
            exchangeRemoveDistributionGrouppropCount++;
            exchangeRemoveDistributionGroup["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupidentity);
            if (exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
            {
                if (exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupbypassSecurityGroupManagerCheck);
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
                    exchangeRemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGrouperrorIfGroupDoesNotExist);
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
            exchangeRemoveDistributionGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveDistributionGroupworkflow);
            if (exchangeRemoveDistributionGrouppropCount > 0)
            {
                callPayload.Body = exchangeRemoveDistributionGroup;
            }

            return new ApiConnectionAction<ExchangeRemoveDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse> ExchangeAddMailboxPermission(Expression<Func<string>> exchangeAddMailboxPermissionidentity, Expression<Func<string>> exchangeAddMailboxPermissionuser, Expression<Func<string>> exchangeAddMailboxPermissionaccessRights, Expression<Func<string>> exchangeAddMailboxPermissionworkflow, Expression<Func<bool>> exchangeAddMailboxPermissionautoMapping = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeAddMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeAddMailboxPermission = new JObject();
            var exchangeAddMailboxPermissionpropCount = 0;
            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeAddMailboxPermissionidentity);
            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["User"] = CSharpExpressionConverter.ConvertToken(exchangeAddMailboxPermissionuser);
            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["AccessRights"] = CSharpExpressionConverter.ConvertToken(exchangeAddMailboxPermissionaccessRights);
            if (exchangeAddMailboxPermissionautoMapping != null)
            {
                if (exchangeAddMailboxPermissionautoMapping != null)
                {
                    exchangeAddMailboxPermission["AutoMapping"] = CSharpExpressionConverter.ConvertToken(exchangeAddMailboxPermissionautoMapping);
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
            exchangeAddMailboxPermission["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeAddMailboxPermissionworkflow);
            if (exchangeAddMailboxPermissionpropCount > 0)
            {
                callPayload.Body = exchangeAddMailboxPermission;
            }

            return new ApiConnectionAction<ExchangeAddMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse> ExchangeRemoveMailboxPermission(Expression<Func<string>> exchangeRemoveMailboxPermissionidentity, Expression<Func<string>> exchangeRemoveMailboxPermissionuser, Expression<Func<string>> exchangeRemoveMailboxPermissionaccessRights, Expression<Func<string>> exchangeRemoveMailboxPermissionworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeRemoveMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeRemoveMailboxPermission = new JObject();
            var exchangeRemoveMailboxPermissionpropCount = 0;
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionidentity);
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["User"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionuser);
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["AccessRights"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionaccessRights);
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeRemoveMailboxPermissionworkflow);
            if (exchangeRemoveMailboxPermissionpropCount > 0)
            {
                callPayload.Body = exchangeRemoveMailboxPermission;
            }

            return new ApiConnectionAction<ExchangeRemoveMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse> ExchangeDisableMailbox(Expression<Func<string>> exchangeDisableMailboxidentity, Expression<Func<string>> exchangeDisableMailboxworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDisableMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDisableMailbox = new JObject();
            var exchangeDisableMailboxpropCount = 0;
            exchangeDisableMailboxpropCount++;
            exchangeDisableMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeDisableMailboxidentity);
            exchangeDisableMailboxpropCount++;
            exchangeDisableMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeDisableMailboxworkflow);
            if (exchangeDisableMailboxpropCount > 0)
            {
                callPayload.Body = exchangeDisableMailbox;
            }

            return new ApiConnectionAction<ExchangeDisableMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse> ExchangeDisableRemoteMailbox(Expression<Func<string>> exchangeDisableRemoteMailboxidentity, Expression<Func<string>> exchangeDisableRemoteMailboxworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDisableRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDisableRemoteMailbox = new JObject();
            var exchangeDisableRemoteMailboxpropCount = 0;
            exchangeDisableRemoteMailboxpropCount++;
            exchangeDisableRemoteMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeDisableRemoteMailboxidentity);
            exchangeDisableRemoteMailboxpropCount++;
            exchangeDisableRemoteMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeDisableRemoteMailboxworkflow);
            if (exchangeDisableRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeDisableRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeDisableRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse> ExchangeEnableMailbox(Expression<Func<string>> exchangeEnableMailboxidentity, Expression<Func<string>> exchangeEnableMailboxworkflow, Expression<Func<string>> exchangeEnableMailboxalias = null, Expression<Func<string>> exchangeEnableMailboxdisplayName = null, Expression<Func<string>> exchangeEnableMailboxlinkedDomainController = null, Expression<Func<string>> exchangeEnableMailboxlinkedMasterAccount = null, Expression<Func<string>> exchangeEnableMailboxdatabase = null, Expression<Func<string>> exchangeEnableMailboxprimarySmtpAddress = null, Expression<Func<bool>> exchangeEnableMailboxemailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeEnableMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeEnableMailbox = new JObject();
            var exchangeEnableMailboxpropCount = 0;
            exchangeEnableMailboxpropCount++;
            exchangeEnableMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxidentity);
            if (exchangeEnableMailboxalias != null)
            {
                exchangeEnableMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxalias);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxdisplayName != null)
            {
                exchangeEnableMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxdisplayName);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxlinkedDomainController != null)
            {
                exchangeEnableMailbox["LinkedDomainController"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxlinkedDomainController);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxlinkedMasterAccount != null)
            {
                exchangeEnableMailbox["LinkedMasterAccount"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxlinkedMasterAccount);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxdatabase != null)
            {
                exchangeEnableMailbox["Database"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxdatabase);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxprimarySmtpAddress != null)
            {
                exchangeEnableMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxprimarySmtpAddress);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxemailAddressPolicyEnabled != null)
            {
                exchangeEnableMailbox["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxemailAddressPolicyEnabled);
                exchangeEnableMailboxpropCount++;
            }

            exchangeEnableMailboxpropCount++;
            exchangeEnableMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeEnableMailboxworkflow);
            if (exchangeEnableMailboxpropCount > 0)
            {
                callPayload.Body = exchangeEnableMailbox;
            }

            return new ApiConnectionAction<ExchangeEnableMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse> ExchangeEnableRemoteMailbox(Expression<Func<string>> exchangeEnableRemoteMailboxidentity, Expression<Func<string>> exchangeEnableRemoteMailboxworkflow, Expression<Func<string>> exchangeEnableRemoteMailboxalias = null, Expression<Func<string>> exchangeEnableRemoteMailboxdisplayName = null, Expression<Func<string>> exchangeEnableRemoteMailboxremoteRoutingAddress = null, Expression<Func<string>> exchangeEnableRemoteMailboxprimarySmtpAddress = null, Expression<Func<bool>> exchangeEnableRemoteMailboxarchive = null, Expression<Func<bool>> exchangeEnableRemoteMailboxemailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeEnableRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeEnableRemoteMailbox = new JObject();
            var exchangeEnableRemoteMailboxpropCount = 0;
            exchangeEnableRemoteMailboxpropCount++;
            exchangeEnableRemoteMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxidentity);
            if (exchangeEnableRemoteMailboxalias != null)
            {
                exchangeEnableRemoteMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxalias);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxdisplayName != null)
            {
                exchangeEnableRemoteMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxdisplayName);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxremoteRoutingAddress != null)
            {
                exchangeEnableRemoteMailbox["RemoteRoutingAddress"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxremoteRoutingAddress);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxprimarySmtpAddress != null)
            {
                exchangeEnableRemoteMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxprimarySmtpAddress);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxarchive != null)
            {
                if (exchangeEnableRemoteMailboxarchive != null)
                {
                    exchangeEnableRemoteMailbox["Archive"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxarchive);
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
                exchangeEnableRemoteMailbox["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxemailAddressPolicyEnabled);
                exchangeEnableRemoteMailboxpropCount++;
            }

            exchangeEnableRemoteMailboxpropCount++;
            exchangeEnableRemoteMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeEnableRemoteMailboxworkflow);
            if (exchangeEnableRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeEnableRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeEnableRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse> ExchangeGetRemoteMailbox(Expression<Func<string>> exchangeGetRemoteMailboxworkflow, Expression<Func<string>> exchangeGetRemoteMailboxidentity = null, Expression<Func<string>> exchangeGetRemoteMailboxfilterPropertyName = null, Expression<Func<exchangeGetRemoteMailboxfilterPropertyComparisonInput>> exchangeGetRemoteMailboxfilterPropertyComparison = null, Expression<Func<string>> exchangeGetRemoteMailboxfilterPropertyValue = null, Expression<Func<bool>> exchangeGetRemoteMailboxnoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetRemoteMailbox = new JObject();
            var exchangeGetRemoteMailboxpropCount = 0;
            if (exchangeGetRemoteMailboxidentity != null)
            {
                exchangeGetRemoteMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxidentity);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxfilterPropertyName != null)
            {
                exchangeGetRemoteMailbox["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxfilterPropertyName);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxfilterPropertyComparison != null)
            {
                if (exchangeGetRemoteMailboxfilterPropertyComparison != null)
                {
                    exchangeGetRemoteMailbox["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(exchangeGetRemoteMailboxfilterPropertyComparison);
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
                exchangeGetRemoteMailbox["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxfilterPropertyValue);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxnoResultIsAnException != null)
            {
                if (exchangeGetRemoteMailboxnoResultIsAnException != null)
                {
                    exchangeGetRemoteMailbox["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxnoResultIsAnException);
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
            exchangeGetRemoteMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxworkflow);
            if (exchangeGetRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeGetRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeGetRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse> ExchangeDoesRemoteMailboxExist(Expression<Func<string>> exchangeDoesRemoteMailboxExistworkflow, Expression<Func<string>> exchangeDoesRemoteMailboxExistidentity = null, Expression<Func<string>> exchangeDoesRemoteMailboxExistfilterPropertyName = null, Expression<Func<exchangeDoesRemoteMailboxExistfilterPropertyComparisonInput>> exchangeDoesRemoteMailboxExistfilterPropertyComparison = null, Expression<Func<string>> exchangeDoesRemoteMailboxExistfilterPropertyValue = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDoesRemoteMailboxExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDoesRemoteMailboxExist = new JObject();
            var exchangeDoesRemoteMailboxExistpropCount = 0;
            if (exchangeDoesRemoteMailboxExistidentity != null)
            {
                exchangeDoesRemoteMailboxExist["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistidentity);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            if (exchangeDoesRemoteMailboxExistfilterPropertyName != null)
            {
                exchangeDoesRemoteMailboxExist["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistfilterPropertyName);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            if (exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
            {
                if (exchangeDoesRemoteMailboxExistfilterPropertyComparison != null)
                {
                    exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(exchangeDoesRemoteMailboxExistfilterPropertyComparison);
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
                exchangeDoesRemoteMailboxExist["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistfilterPropertyValue);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            exchangeDoesRemoteMailboxExistpropCount++;
            exchangeDoesRemoteMailboxExist["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeDoesRemoteMailboxExistworkflow);
            if (exchangeDoesRemoteMailboxExistpropCount > 0)
            {
                callPayload.Body = exchangeDoesRemoteMailboxExist;
            }

            return new ApiConnectionAction<ExchangeDoesRemoteMailboxExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse> ExchangeNewMailbox(Expression<Func<string>> exchangeNewMailboxname, Expression<Func<string>> exchangeNewMailboxuserPrincipalName, Expression<Func<string>> exchangeNewMailboxworkflow, Expression<Func<string>> exchangeNewMailboxfirstName = null, Expression<Func<string>> exchangeNewMailboxlastName = null, Expression<Func<string>> exchangeNewMailboxorganizationalUnit = null, Expression<Func<string>> exchangeNewMailboxdisplayName = null, Expression<Func<string>> exchangeNewMailboxalias = null, Expression<Func<string>> exchangeNewMailboxprimarySmtpAddress = null, Expression<Func<string>> exchangeNewMailboxsamAccountName = null, Expression<Func<string>> exchangeNewMailboxpassword = null, Expression<Func<bool>> exchangeNewMailboxaccountPasswordIsStoredPassword = null, Expression<Func<bool>> exchangeNewMailboxresetPasswordOnNextLogon = null, Expression<Func<string>> exchangeNewMailboxdatabase = null, Expression<Func<bool>> exchangeNewMailboxsharedMailbox = null, Expression<Func<bool>> exchangeNewMailboxemailAddressPolicyEnabled = null, Expression<Func<bool>> exchangeNewMailboxarchive = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeNewMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeNewMailbox = new JObject();
            var exchangeNewMailboxpropCount = 0;
            if (exchangeNewMailboxfirstName != null)
            {
                exchangeNewMailbox["FirstName"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxfirstName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxlastName != null)
            {
                exchangeNewMailbox["LastName"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxlastName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxorganizationalUnit != null)
            {
                exchangeNewMailbox["OrganizationalUnit"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxorganizationalUnit);
                exchangeNewMailboxpropCount++;
            }

            exchangeNewMailboxpropCount++;
            exchangeNewMailbox["Name"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxname);
            if (exchangeNewMailboxdisplayName != null)
            {
                exchangeNewMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxdisplayName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxalias != null)
            {
                exchangeNewMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxalias);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxprimarySmtpAddress != null)
            {
                exchangeNewMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxprimarySmtpAddress);
                exchangeNewMailboxpropCount++;
            }

            exchangeNewMailboxpropCount++;
            exchangeNewMailbox["UserPrincipalName"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxuserPrincipalName);
            if (exchangeNewMailboxsamAccountName != null)
            {
                exchangeNewMailbox["SamAccountName"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxsamAccountName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxpassword != null)
            {
                exchangeNewMailbox["Password"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxpassword);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxaccountPasswordIsStoredPassword != null)
            {
                if (exchangeNewMailboxaccountPasswordIsStoredPassword != null)
                {
                    exchangeNewMailbox["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxaccountPasswordIsStoredPassword);
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
                    exchangeNewMailbox["ResetPasswordOnNextLogon"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxresetPasswordOnNextLogon);
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
                exchangeNewMailbox["Database"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxdatabase);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxsharedMailbox != null)
            {
                if (exchangeNewMailboxsharedMailbox != null)
                {
                    exchangeNewMailbox["SharedMailbox"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxsharedMailbox);
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
                exchangeNewMailbox["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxemailAddressPolicyEnabled);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxarchive != null)
            {
                if (exchangeNewMailboxarchive != null)
                {
                    exchangeNewMailbox["Archive"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxarchive);
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
            exchangeNewMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeNewMailboxworkflow);
            if (exchangeNewMailboxpropCount > 0)
            {
                callPayload.Body = exchangeNewMailbox;
            }

            return new ApiConnectionAction<ExchangeNewMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse> ExchangeNewRemoteMailbox(Expression<Func<string>> exchangeNewRemoteMailboxname, Expression<Func<string>> exchangeNewRemoteMailboxuserPrincipalName, Expression<Func<string>> exchangeNewRemoteMailboxworkflow, Expression<Func<string>> exchangeNewRemoteMailboxfirstName = null, Expression<Func<string>> exchangeNewRemoteMailboxlastName = null, Expression<Func<string>> exchangeNewRemoteMailboxonPremisesOrganizationalUnit = null, Expression<Func<string>> exchangeNewRemoteMailboxdisplayName = null, Expression<Func<string>> exchangeNewRemoteMailboxremoteRoutingAddress = null, Expression<Func<string>> exchangeNewRemoteMailboxalias = null, Expression<Func<string>> exchangeNewRemoteMailboxprimarySmtpAddress = null, Expression<Func<string>> exchangeNewRemoteMailboxsamAccountName = null, Expression<Func<string>> exchangeNewRemoteMailboxpassword = null, Expression<Func<bool>> exchangeNewRemoteMailboxaccountPasswordIsStoredPassword = null, Expression<Func<bool>> exchangeNewRemoteMailboxresetPasswordOnNextLogon = null, Expression<Func<bool>> exchangeNewRemoteMailboxsharedMailbox = null, Expression<Func<bool>> exchangeNewRemoteMailboxemailAddressPolicyEnabled = null, Expression<Func<bool>> exchangeNewRemoteMailboxarchive = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeNewRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeNewRemoteMailbox = new JObject();
            var exchangeNewRemoteMailboxpropCount = 0;
            if (exchangeNewRemoteMailboxfirstName != null)
            {
                exchangeNewRemoteMailbox["FirstName"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxfirstName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxlastName != null)
            {
                exchangeNewRemoteMailbox["LastName"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxlastName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxonPremisesOrganizationalUnit != null)
            {
                exchangeNewRemoteMailbox["OnPremisesOrganizationalUnit"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxonPremisesOrganizationalUnit);
                exchangeNewRemoteMailboxpropCount++;
            }

            exchangeNewRemoteMailboxpropCount++;
            exchangeNewRemoteMailbox["Name"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxname);
            if (exchangeNewRemoteMailboxdisplayName != null)
            {
                exchangeNewRemoteMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxdisplayName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxremoteRoutingAddress != null)
            {
                exchangeNewRemoteMailbox["RemoteRoutingAddress"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxremoteRoutingAddress);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxalias != null)
            {
                exchangeNewRemoteMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxalias);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxprimarySmtpAddress != null)
            {
                exchangeNewRemoteMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxprimarySmtpAddress);
                exchangeNewRemoteMailboxpropCount++;
            }

            exchangeNewRemoteMailboxpropCount++;
            exchangeNewRemoteMailbox["UserPrincipalName"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxuserPrincipalName);
            if (exchangeNewRemoteMailboxsamAccountName != null)
            {
                exchangeNewRemoteMailbox["SamAccountName"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxsamAccountName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxpassword != null)
            {
                exchangeNewRemoteMailbox["Password"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxpassword);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
            {
                if (exchangeNewRemoteMailboxaccountPasswordIsStoredPassword != null)
                {
                    exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxaccountPasswordIsStoredPassword);
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
                    exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxresetPasswordOnNextLogon);
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
                    exchangeNewRemoteMailbox["SharedMailbox"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxsharedMailbox);
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
                exchangeNewRemoteMailbox["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxemailAddressPolicyEnabled);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxarchive != null)
            {
                if (exchangeNewRemoteMailboxarchive != null)
                {
                    exchangeNewRemoteMailbox["Archive"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxarchive);
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
            exchangeNewRemoteMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeNewRemoteMailboxworkflow);
            if (exchangeNewRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeNewRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeNewRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse> ExchangeSetADServerToViewEntireForest(Expression<Func<bool>> exchangeSetADServerToViewEntireForestviewEntireForest, Expression<Func<string>> exchangeSetADServerToViewEntireForestworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetADServerToViewEntireForest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetADServerToViewEntireForest = new JObject();
            var exchangeSetADServerToViewEntireForestpropCount = 0;
            exchangeSetADServerToViewEntireForestpropCount++;
            exchangeSetADServerToViewEntireForest["ViewEntireForest"] = CSharpExpressionConverter.ConvertToken(exchangeSetADServerToViewEntireForestviewEntireForest);
            exchangeSetADServerToViewEntireForestpropCount++;
            exchangeSetADServerToViewEntireForest["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetADServerToViewEntireForestworkflow);
            if (exchangeSetADServerToViewEntireForestpropCount > 0)
            {
                callPayload.Body = exchangeSetADServerToViewEntireForest;
            }

            return new ApiConnectionAction<ExchangeSetADServerToViewEntireForestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse> ExchangeSetMailbox(Expression<Func<string>> exchangeSetMailboxidentity, Expression<Func<string>> exchangeSetMailboxworkflow, Expression<Func<bool>> exchangeSetMailboxaccountDisabled = null, Expression<Func<string>> exchangeSetMailboxalias = null, Expression<Func<string>> exchangeSetMailboxdisplayName = null, Expression<Func<string>> exchangeSetMailboxprimarySmtpAddress = null, Expression<Func<bool>> exchangeSetMailboxhiddenFromAddressListsEnabled = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute1 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute2 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute3 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute4 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute5 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute6 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute7 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute8 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute9 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute10 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute11 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute12 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute13 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute14 = null, Expression<Func<string>> exchangeSetMailboxcustomAttribute15 = null, Expression<Func<bool>> exchangeSetMailboxemailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailbox = new JObject();
            var exchangeSetMailboxpropCount = 0;
            exchangeSetMailboxpropCount++;
            exchangeSetMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxidentity);
            if (exchangeSetMailboxaccountDisabled != null)
            {
                exchangeSetMailbox["AccountDisabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxaccountDisabled);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxalias != null)
            {
                exchangeSetMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxalias);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxdisplayName != null)
            {
                exchangeSetMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxdisplayName);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxprimarySmtpAddress != null)
            {
                exchangeSetMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxprimarySmtpAddress);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxhiddenFromAddressListsEnabled != null)
            {
                exchangeSetMailbox["HiddenFromAddressListsEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxhiddenFromAddressListsEnabled);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute1 != null)
            {
                exchangeSetMailbox["CustomAttribute1"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute1);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute2 != null)
            {
                exchangeSetMailbox["CustomAttribute2"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute2);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute3 != null)
            {
                exchangeSetMailbox["CustomAttribute3"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute3);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute4 != null)
            {
                exchangeSetMailbox["CustomAttribute4"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute4);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute5 != null)
            {
                exchangeSetMailbox["CustomAttribute5"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute5);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute6 != null)
            {
                exchangeSetMailbox["CustomAttribute6"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute6);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute7 != null)
            {
                exchangeSetMailbox["CustomAttribute7"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute7);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute8 != null)
            {
                exchangeSetMailbox["CustomAttribute8"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute8);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute9 != null)
            {
                exchangeSetMailbox["CustomAttribute9"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute9);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute10 != null)
            {
                exchangeSetMailbox["CustomAttribute10"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute10);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute11 != null)
            {
                exchangeSetMailbox["CustomAttribute11"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute11);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute12 != null)
            {
                exchangeSetMailbox["CustomAttribute12"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute12);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute13 != null)
            {
                exchangeSetMailbox["CustomAttribute13"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute13);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute14 != null)
            {
                exchangeSetMailbox["CustomAttribute14"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute14);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxcustomAttribute15 != null)
            {
                exchangeSetMailbox["CustomAttribute15"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxcustomAttribute15);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxemailAddressPolicyEnabled != null)
            {
                exchangeSetMailbox["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxemailAddressPolicyEnabled);
                exchangeSetMailboxpropCount++;
            }

            exchangeSetMailboxpropCount++;
            exchangeSetMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxworkflow);
            if (exchangeSetMailboxpropCount > 0)
            {
                callPayload.Body = exchangeSetMailbox;
            }

            return new ApiConnectionAction<ExchangeSetMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse> ExchangeSetMailboxEmailAddresses(Expression<Func<string>> exchangeSetMailboxEmailAddressesidentity, Expression<Func<string>> exchangeSetMailboxEmailAddressesworkflow, Expression<Func<string>> exchangeSetMailboxEmailAddressesalias = null, Expression<Func<string>> exchangeSetMailboxEmailAddressesprimarySmtpAddress = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled = null, Expression<Func<string[]>> exchangeSetMailboxEmailAddressesemailAddressesToAddList = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressesreplaceEmailAddresses = null, Expression<Func<string[]>> exchangeSetMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailboxEmailAddresses = new JObject();
            var exchangeSetMailboxEmailAddressespropCount = 0;
            exchangeSetMailboxEmailAddressespropCount++;
            exchangeSetMailboxEmailAddresses["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesidentity);
            if (exchangeSetMailboxEmailAddressesalias != null)
            {
                exchangeSetMailboxEmailAddresses["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesalias);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesprimarySmtpAddress != null)
            {
                exchangeSetMailboxEmailAddresses["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesprimarySmtpAddress);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled != null)
            {
                exchangeSetMailboxEmailAddresses["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesemailAddressPolicyEnabled);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesemailAddressesToAddList != null)
            {
                exchangeSetMailboxEmailAddresses["EmailAddressesToAddList"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesemailAddressesToAddList);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
            {
                if (exchangeSetMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesreplaceEmailAddresses);
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
                exchangeSetMailboxEmailAddresses["EmailAddressesToRemoveList"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesemailAddressesToRemoveList);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            exchangeSetMailboxEmailAddressespropCount++;
            exchangeSetMailboxEmailAddresses["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxEmailAddressesworkflow);
            if (exchangeSetMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeSetMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeSetMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse> ExchangeGetMailboxEmailAddresses(Expression<Func<string>> exchangeGetMailboxEmailAddressesidentity, Expression<Func<string>> exchangeGetMailboxEmailAddressesworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetMailboxEmailAddresses = new JObject();
            var exchangeGetMailboxEmailAddressespropCount = 0;
            exchangeGetMailboxEmailAddressespropCount++;
            exchangeGetMailboxEmailAddresses["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxEmailAddressesidentity);
            exchangeGetMailboxEmailAddressespropCount++;
            exchangeGetMailboxEmailAddresses["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetMailboxEmailAddressesworkflow);
            if (exchangeGetMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeGetMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeGetMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse> ExchangeSetRemoteMailboxEmailAddresses(Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesidentity, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesworkflow, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesalias = null, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled = null, Expression<Func<string[]>> exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses = null, Expression<Func<string[]>> exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetRemoteMailboxEmailAddresses = new JObject();
            var exchangeSetRemoteMailboxEmailAddressespropCount = 0;
            exchangeSetRemoteMailboxEmailAddressespropCount++;
            exchangeSetRemoteMailboxEmailAddresses["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesidentity);
            if (exchangeSetRemoteMailboxEmailAddressesalias != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesalias);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesprimarySmtpAddress);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesemailAddressPolicyEnabled);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToAddList"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesemailAddressesToAddList);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
            {
                if (exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses != null)
                {
                    exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesreplaceEmailAddresses);
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
                exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToRemoveList"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesemailAddressesToRemoveList);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            exchangeSetRemoteMailboxEmailAddressespropCount++;
            exchangeSetRemoteMailboxEmailAddresses["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxEmailAddressesworkflow);
            if (exchangeSetRemoteMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeSetRemoteMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse> ExchangeGetRemoteMailboxEmailAddresses(Expression<Func<string>> exchangeGetRemoteMailboxEmailAddressesidentity, Expression<Func<string>> exchangeGetRemoteMailboxEmailAddressesworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetRemoteMailboxEmailAddresses = new JObject();
            var exchangeGetRemoteMailboxEmailAddressespropCount = 0;
            exchangeGetRemoteMailboxEmailAddressespropCount++;
            exchangeGetRemoteMailboxEmailAddresses["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxEmailAddressesidentity);
            exchangeGetRemoteMailboxEmailAddressespropCount++;
            exchangeGetRemoteMailboxEmailAddresses["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeGetRemoteMailboxEmailAddressesworkflow);
            if (exchangeGetRemoteMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeGetRemoteMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse> ExchangeResetMailboxAttributes(Expression<Func<string>> exchangeResetMailboxAttributesidentity, Expression<Func<string>> exchangeResetMailboxAttributesworkflow, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute1 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute2 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute3 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute4 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute5 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute6 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute7 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute8 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute9 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute10 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute11 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute12 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute13 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute14 = null, Expression<Func<bool>> exchangeResetMailboxAttributesresetCustomAttribute15 = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeResetMailboxAttributes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeResetMailboxAttributes = new JObject();
            var exchangeResetMailboxAttributespropCount = 0;
            exchangeResetMailboxAttributespropCount++;
            exchangeResetMailboxAttributes["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesidentity);
            if (exchangeResetMailboxAttributesresetCustomAttribute1 != null)
            {
                if (exchangeResetMailboxAttributesresetCustomAttribute1 != null)
                {
                    exchangeResetMailboxAttributes["ResetCustomAttribute1"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute1);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute2"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute2);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute3"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute3);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute4"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute4);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute5"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute5);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute6"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute6);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute7"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute7);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute8"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute8);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute9"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute9);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute10"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute10);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute11"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute11);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute12"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute12);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute13"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute13);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute14"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute14);
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
                    exchangeResetMailboxAttributes["ResetCustomAttribute15"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesresetCustomAttribute15);
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
            exchangeResetMailboxAttributes["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeResetMailboxAttributesworkflow);
            if (exchangeResetMailboxAttributespropCount > 0)
            {
                callPayload.Body = exchangeResetMailboxAttributes;
            }

            return new ApiConnectionAction<ExchangeResetMailboxAttributesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse> ExchangeResetRemoteMailboxAttributes(Expression<Func<string>> exchangeResetRemoteMailboxAttributesidentity, Expression<Func<string>> exchangeResetRemoteMailboxAttributesworkflow, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute1 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute2 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute3 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute4 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute5 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute6 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute7 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute8 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute9 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute10 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute11 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute12 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute13 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute14 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesresetCustomAttribute15 = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeResetRemoteMailboxAttributes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeResetRemoteMailboxAttributes = new JObject();
            var exchangeResetRemoteMailboxAttributespropCount = 0;
            exchangeResetRemoteMailboxAttributespropCount++;
            exchangeResetRemoteMailboxAttributes["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesidentity);
            if (exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
            {
                if (exchangeResetRemoteMailboxAttributesresetCustomAttribute1 != null)
                {
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute1);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute2);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute3);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute4);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute5);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute6);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute7);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute8);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute9);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute10);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute11);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute12);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute13);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute14);
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
                    exchangeResetRemoteMailboxAttributes["ResetCustomAttribute15"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesresetCustomAttribute15);
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
            exchangeResetRemoteMailboxAttributes["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeResetRemoteMailboxAttributesworkflow);
            if (exchangeResetRemoteMailboxAttributespropCount > 0)
            {
                callPayload.Body = exchangeResetRemoteMailboxAttributes;
            }

            return new ApiConnectionAction<ExchangeResetRemoteMailboxAttributesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse> ExchangeSetRemoteMailbox(Expression<Func<string>> exchangeSetRemoteMailboxidentity, Expression<Func<string>> exchangeSetRemoteMailboxworkflow, Expression<Func<string>> exchangeSetRemoteMailboxalias = null, Expression<Func<string>> exchangeSetRemoteMailboxdisplayName = null, Expression<Func<string>> exchangeSetRemoteMailboxprimarySmtpAddress = null, Expression<Func<exchangeSetRemoteMailboxtypeInput>> exchangeSetRemoteMailboxtype = null, Expression<Func<bool>> exchangeSetRemoteMailboxhiddenFromAddressListsEnabled = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute1 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute2 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute3 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute4 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute5 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute6 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute7 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute8 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute9 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute10 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute11 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute12 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute13 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute14 = null, Expression<Func<string>> exchangeSetRemoteMailboxcustomAttribute15 = null, Expression<Func<bool>> exchangeSetRemoteMailboxemailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetRemoteMailbox = new JObject();
            var exchangeSetRemoteMailboxpropCount = 0;
            exchangeSetRemoteMailboxpropCount++;
            exchangeSetRemoteMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxidentity);
            if (exchangeSetRemoteMailboxalias != null)
            {
                exchangeSetRemoteMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxalias);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxdisplayName != null)
            {
                exchangeSetRemoteMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxdisplayName);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxprimarySmtpAddress != null)
            {
                exchangeSetRemoteMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxprimarySmtpAddress);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxtype != null)
            {
                exchangeSetRemoteMailbox["Type"] = CSharpExpressionConverter.Convert(exchangeSetRemoteMailboxtype);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxhiddenFromAddressListsEnabled != null)
            {
                exchangeSetRemoteMailbox["HiddenFromAddressListsEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxhiddenFromAddressListsEnabled);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute1 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute1"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute1);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute2 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute2"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute2);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute3 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute3"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute3);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute4 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute4"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute4);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute5 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute5"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute5);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute6 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute6"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute6);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute7 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute7"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute7);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute8 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute8"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute8);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute9 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute9"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute9);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute10 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute10"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute10);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute11 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute11"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute11);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute12 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute12"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute12);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute13 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute13"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute13);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute14 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute14"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute14);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxcustomAttribute15 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute15"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxcustomAttribute15);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxemailAddressPolicyEnabled != null)
            {
                exchangeSetRemoteMailbox["EmailAddressPolicyEnabled"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxemailAddressPolicyEnabled);
                exchangeSetRemoteMailboxpropCount++;
            }

            exchangeSetRemoteMailboxpropCount++;
            exchangeSetRemoteMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetRemoteMailboxworkflow);
            if (exchangeSetRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeSetRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeSetRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse> ExchangeSetMailboxSendOnBehalfOfPermission(Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionidentity, Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo, Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxSendOnBehalfOfPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailboxSendOnBehalfOfPermission = new JObject();
            var exchangeSetMailboxSendOnBehalfOfPermissionpropCount = 0;
            exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
            exchangeSetMailboxSendOnBehalfOfPermission["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxSendOnBehalfOfPermissionidentity);
            exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
            exchangeSetMailboxSendOnBehalfOfPermission["GrantSendOnBehalfTo"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxSendOnBehalfOfPermissiongrantSendOnBehalfTo);
            exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
            exchangeSetMailboxSendOnBehalfOfPermission["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxSendOnBehalfOfPermissionworkflow);
            if (exchangeSetMailboxSendOnBehalfOfPermissionpropCount > 0)
            {
                callPayload.Body = exchangeSetMailboxSendOnBehalfOfPermission;
            }

            return new ApiConnectionAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse> ExchangeAddADPermission(Expression<Func<string>> exchangeAddADPermissionidentity, Expression<Func<string>> exchangeAddADPermissionuser, Expression<Func<string>> exchangeAddADPermissionworkflow, Expression<Func<string>> exchangeAddADPermissionaccessRights = null, Expression<Func<string>> exchangeAddADPermissionextendedRights = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeAddADPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeAddADPermission = new JObject();
            var exchangeAddADPermissionpropCount = 0;
            exchangeAddADPermissionpropCount++;
            exchangeAddADPermission["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeAddADPermissionidentity);
            exchangeAddADPermissionpropCount++;
            exchangeAddADPermission["User"] = CSharpExpressionConverter.ConvertToken(exchangeAddADPermissionuser);
            if (exchangeAddADPermissionaccessRights != null)
            {
                exchangeAddADPermission["AccessRights"] = CSharpExpressionConverter.ConvertToken(exchangeAddADPermissionaccessRights);
                exchangeAddADPermissionpropCount++;
            }

            if (exchangeAddADPermissionextendedRights != null)
            {
                exchangeAddADPermission["ExtendedRights"] = CSharpExpressionConverter.ConvertToken(exchangeAddADPermissionextendedRights);
                exchangeAddADPermissionpropCount++;
            }

            exchangeAddADPermissionpropCount++;
            exchangeAddADPermission["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeAddADPermissionworkflow);
            if (exchangeAddADPermissionpropCount > 0)
            {
                callPayload.Body = exchangeAddADPermission;
            }

            return new ApiConnectionAction<ExchangeAddADPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse> ExchangeSetMailboxAutoReplyConfiguration(Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationidentity, Expression<Func<exchangeSetMailboxAutoReplyConfigurationautoReplyStateInput>> exchangeSetMailboxAutoReplyConfigurationautoReplyState, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationworkflow, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationinternalMessage = null, Expression<Func<exchangeSetMailboxAutoReplyConfigurationexternalAudienceInput>> exchangeSetMailboxAutoReplyConfigurationexternalAudience = null, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationexternalMessage = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxAutoReplyConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailboxAutoReplyConfiguration = new JObject();
            var exchangeSetMailboxAutoReplyConfigurationpropCount = 0;
            exchangeSetMailboxAutoReplyConfigurationpropCount++;
            exchangeSetMailboxAutoReplyConfiguration["Identity"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationidentity);
            exchangeSetMailboxAutoReplyConfigurationpropCount++;
            exchangeSetMailboxAutoReplyConfiguration["AutoReplyState"] = CSharpExpressionConverter.Convert(exchangeSetMailboxAutoReplyConfigurationautoReplyState);
            if (exchangeSetMailboxAutoReplyConfigurationinternalMessage != null)
            {
                exchangeSetMailboxAutoReplyConfiguration["InternalMessage"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationinternalMessage);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
            }

            if (exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
            {
                if (exchangeSetMailboxAutoReplyConfigurationexternalAudience != null)
                {
                    exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = CSharpExpressionConverter.Convert(exchangeSetMailboxAutoReplyConfigurationexternalAudience);
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
                exchangeSetMailboxAutoReplyConfiguration["ExternalMessage"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationexternalMessage);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
            }

            exchangeSetMailboxAutoReplyConfigurationpropCount++;
            exchangeSetMailboxAutoReplyConfiguration["Workflow"] = CSharpExpressionConverter.ConvertToken(exchangeSetMailboxAutoReplyConfigurationworkflow);
            if (exchangeSetMailboxAutoReplyConfigurationpropCount > 0)
            {
                callPayload.Body = exchangeSetMailboxAutoReplyConfiguration;
            }

            return new ApiConnectionAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse> IsAzureADv2PowerShellModuleInstalled(Expression<Func<string>> isAzureADv2PowerShellModuleInstalledworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellModuleInstalled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isAzureADv2PowerShellModuleInstalled = new JObject();
            var isAzureADv2PowerShellModuleInstalledpropCount = 0;
            isAzureADv2PowerShellModuleInstalledpropCount++;
            isAzureADv2PowerShellModuleInstalled["Workflow"] = CSharpExpressionConverter.ConvertToken(isAzureADv2PowerShellModuleInstalledworkflow);
            if (isAzureADv2PowerShellModuleInstalledpropCount > 0)
            {
                callPayload.Body = isAzureADv2PowerShellModuleInstalled;
            }

            return new ApiConnectionAction<IsAzureADv2PowerShellModuleInstalledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse> OpenAzureADv2PowerShellRunspace(Expression<Func<string>> openAzureADv2PowerShellRunspaceusername, Expression<Func<string>> openAzureADv2PowerShellRunspacepassword, Expression<Func<string>> openAzureADv2PowerShellRunspaceworkflow, Expression<Func<string>> openAzureADv2PowerShellRunspacetenantId = null, Expression<Func<openAzureADv2PowerShellRunspaceaPIToUseInput>> openAzureADv2PowerShellRunspaceaPIToUse = null, Expression<Func<string>> openAzureADv2PowerShellRunspaceauthenticationScope = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openAzureADv2PowerShellRunspace = new JObject();
            var openAzureADv2PowerShellRunspacepropCount = 0;
            openAzureADv2PowerShellRunspacepropCount++;
            openAzureADv2PowerShellRunspace["Username"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceusername);
            openAzureADv2PowerShellRunspacepropCount++;
            openAzureADv2PowerShellRunspace["Password"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspacepassword);
            if (openAzureADv2PowerShellRunspacetenantId != null)
            {
                openAzureADv2PowerShellRunspace["TenantId"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspacetenantId);
                openAzureADv2PowerShellRunspacepropCount++;
            }

            if (openAzureADv2PowerShellRunspaceaPIToUse != null)
            {
                if (openAzureADv2PowerShellRunspaceaPIToUse != null)
                {
                    openAzureADv2PowerShellRunspace["APIToUse"] = CSharpExpressionConverter.Convert(openAzureADv2PowerShellRunspaceaPIToUse);
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
                    openAzureADv2PowerShellRunspace["AuthenticationScope"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceauthenticationScope);
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
            openAzureADv2PowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceworkflow);
            if (openAzureADv2PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openAzureADv2PowerShellRunspace;
            }

            return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse> OpenAzureADv2PowerShellRunspaceWithCertificate(Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateapplicationId, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificatetenantId, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateworkflow, Expression<Func<openAzureADv2PowerShellRunspaceWithCertificateaPIToUseInput>> openAzureADv2PowerShellRunspaceWithCertificateaPIToUse = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspaceWithCertificate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openAzureADv2PowerShellRunspaceWithCertificate = new JObject();
            var openAzureADv2PowerShellRunspaceWithCertificatepropCount = 0;
            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["ApplicationId"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificateapplicationId);
            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["CertificateThumbprint"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificatecertificateThumbprint);
            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["TenantId"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificatetenantId);
            if (openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
            {
                if (openAzureADv2PowerShellRunspaceWithCertificateaPIToUse != null)
                {
                    openAzureADv2PowerShellRunspaceWithCertificate["APIToUse"] = CSharpExpressionConverter.Convert(openAzureADv2PowerShellRunspaceWithCertificateaPIToUse);
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
            openAzureADv2PowerShellRunspaceWithCertificate["Workflow"] = CSharpExpressionConverter.ConvertToken(openAzureADv2PowerShellRunspaceWithCertificateworkflow);
            if (openAzureADv2PowerShellRunspaceWithCertificatepropCount > 0)
            {
                callPayload.Body = openAzureADv2PowerShellRunspaceWithCertificate;
            }

            return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse> IsAzureADv2PowerShellRunspaceOpen(Expression<Func<string>> isAzureADv2PowerShellRunspaceOpenworkflow, Expression<Func<bool>> isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
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
                    isAzureADv2PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = CSharpExpressionConverter.ConvertToken(isAzureADv2PowerShellRunspaceOpenretrievePowerShellRunSpacePID);
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
            isAzureADv2PowerShellRunspaceOpen["Workflow"] = CSharpExpressionConverter.ConvertToken(isAzureADv2PowerShellRunspaceOpenworkflow);
            if (isAzureADv2PowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isAzureADv2PowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsAzureADv2PowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse> RunAzureADv2PowerShellAutomationScript(Expression<Func<string>> runAzureADv2PowerShellAutomationScriptworkflow, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runAzureADv2PowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/RunAzureADv2PowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runAzureADv2PowerShellAutomationScript = new JObject();
            var runAzureADv2PowerShellAutomationScriptpropCount = 0;
            if (runAzureADv2PowerShellAutomationScriptpowerShellScriptContents != null)
            {
                runAzureADv2PowerShellAutomationScript["PowerShellScriptContents"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpowerShellScriptContents);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
            {
                if (runAzureADv2PowerShellAutomationScriptisNoResultAnError != null)
                {
                    runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptisNoResultAnError);
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
                    runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnComplexTypes);
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
                    runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnBooleanAsBoolean);
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
                    runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnNumericAsDecimal);
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
                    runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptreturnDateAsDate);
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
                runAzureADv2PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
            {
                if (runAzureADv2PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptrunScriptAsThread);
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
                runAzureADv2PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
            {
                if (runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptsecondsToWaitForThread);
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
                    runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptscriptContainsStoredPassword);
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
                    runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptlogVerboseOutput);
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
                runAzureADv2PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
            {
                runAzureADv2PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters != null)
            {
                runAzureADv2PowerShellAutomationScript["PowerShellCommandParameters"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptpowerShellCommandParameters);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            runAzureADv2PowerShellAutomationScriptpropCount++;
            runAzureADv2PowerShellAutomationScript["Workflow"] = CSharpExpressionConverter.ConvertToken(runAzureADv2PowerShellAutomationScriptworkflow);
            if (runAzureADv2PowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runAzureADv2PowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunAzureADv2PowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse> CloseAzureADv2PowerShellRunspace(Expression<Func<string>> closeAzureADv2PowerShellRunspaceworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/CloseAzureADv2PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeAzureADv2PowerShellRunspace = new JObject();
            var closeAzureADv2PowerShellRunspacepropCount = 0;
            closeAzureADv2PowerShellRunspacepropCount++;
            closeAzureADv2PowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(closeAzureADv2PowerShellRunspaceworkflow);
            if (closeAzureADv2PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeAzureADv2PowerShellRunspace;
            }

            return new ApiConnectionAction<CloseAzureADv2PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse> AzureADv2GetAzureADUsers(Expression<Func<string>> azureADv2GetAzureADUsersworkflow, Expression<Func<string>> azureADv2GetAzureADUsersobjectId = null, Expression<Func<string>> azureADv2GetAzureADUsersfilterPropertyName = null, Expression<Func<azureADv2GetAzureADUsersfilterPropertyComparisonInput>> azureADv2GetAzureADUsersfilterPropertyComparison = null, Expression<Func<string>> azureADv2GetAzureADUsersfilterPropertyValue = null, Expression<Func<bool>> azureADv2GetAzureADUsersnoResultIsAnException = null, Expression<Func<string>> azureADv2GetAzureADUserspropertiesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUsers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUsers = new JObject();
            var azureADv2GetAzureADUserspropCount = 0;
            if (azureADv2GetAzureADUsersobjectId != null)
            {
                azureADv2GetAzureADUsers["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUsersobjectId);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersfilterPropertyName != null)
            {
                azureADv2GetAzureADUsers["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUsersfilterPropertyName);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersfilterPropertyComparison != null)
            {
                if (azureADv2GetAzureADUsersfilterPropertyComparison != null)
                {
                    azureADv2GetAzureADUsers["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(azureADv2GetAzureADUsersfilterPropertyComparison);
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
                azureADv2GetAzureADUsers["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUsersfilterPropertyValue);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersnoResultIsAnException != null)
            {
                if (azureADv2GetAzureADUsersnoResultIsAnException != null)
                {
                    azureADv2GetAzureADUsers["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUsersnoResultIsAnException);
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
                azureADv2GetAzureADUsers["PropertiesToReturn"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserspropertiesToReturn);
                azureADv2GetAzureADUserspropCount++;
            }

            azureADv2GetAzureADUserspropCount++;
            azureADv2GetAzureADUsers["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUsersworkflow);
            if (azureADv2GetAzureADUserspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUsers;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse> AzureADv2AddAzureADUser(Expression<Func<string>> azureADv2AddAzureADUseruserPrincipalName, Expression<Func<bool>> azureADv2AddAzureADUseraccountEnabled, Expression<Func<string>> azureADv2AddAzureADUseraccountPassword, Expression<Func<string>> azureADv2AddAzureADUserdisplayName, Expression<Func<string>> azureADv2AddAzureADUsermailNickName, Expression<Func<string>> azureADv2AddAzureADUserworkflow, Expression<Func<bool>> azureADv2AddAzureADUseraccountPasswordIsStoredPassword = null, Expression<Func<string>> azureADv2AddAzureADUserfirstName = null, Expression<Func<string>> azureADv2AddAzureADUserlastName = null, Expression<Func<string>> azureADv2AddAzureADUsercity = null, Expression<Func<string>> azureADv2AddAzureADUsercompanyName = null, Expression<Func<string>> azureADv2AddAzureADUsercountry = null, Expression<Func<string>> azureADv2AddAzureADUserdepartment = null, Expression<Func<string>> azureADv2AddAzureADUserfaxNumber = null, Expression<Func<string>> azureADv2AddAzureADUserjobTitle = null, Expression<Func<string>> azureADv2AddAzureADUsermobilePhone = null, Expression<Func<string>> azureADv2AddAzureADUseroffice = null, Expression<Func<string>> azureADv2AddAzureADUserphoneNumber = null, Expression<Func<string>> azureADv2AddAzureADUserpostalCode = null, Expression<Func<string>> azureADv2AddAzureADUserpreferredLanguage = null, Expression<Func<string>> azureADv2AddAzureADUserstate = null, Expression<Func<string>> azureADv2AddAzureADUserstreetAddress = null, Expression<Func<string>> azureADv2AddAzureADUserusageLocation = null, Expression<Func<azureADv2AddAzureADUserageGroupInput>> azureADv2AddAzureADUserageGroup = null, Expression<Func<azureADv2AddAzureADUserconsentProvidedForMinorInput>> azureADv2AddAzureADUserconsentProvidedForMinor = null, Expression<Func<string>> azureADv2AddAzureADUseremployeeId = null, Expression<Func<bool>> azureADv2AddAzureADUserforceChangePasswordNextLogin = null, Expression<Func<bool>> azureADv2AddAzureADUserenforceChangePasswordPolicy = null, Expression<Func<bool>> azureADv2AddAzureADUserpasswordNeverExpires = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddAzureADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AddAzureADUser = new JObject();
            var azureADv2AddAzureADUserpropCount = 0;
            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["UserPrincipalName"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUseruserPrincipalName);
            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["AccountEnabled"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUseraccountEnabled);
            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["AccountPassword"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUseraccountPassword);
            if (azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
            {
                if (azureADv2AddAzureADUseraccountPasswordIsStoredPassword != null)
                {
                    azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUseraccountPasswordIsStoredPassword);
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
                azureADv2AddAzureADUser["FirstName"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserfirstName);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserlastName != null)
            {
                azureADv2AddAzureADUser["LastName"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserlastName);
                azureADv2AddAzureADUserpropCount++;
            }

            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["DisplayName"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserdisplayName);
            if (azureADv2AddAzureADUsercity != null)
            {
                azureADv2AddAzureADUser["City"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUsercity);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUsercompanyName != null)
            {
                azureADv2AddAzureADUser["CompanyName"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUsercompanyName);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUsercountry != null)
            {
                azureADv2AddAzureADUser["Country"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUsercountry);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserdepartment != null)
            {
                azureADv2AddAzureADUser["Department"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserdepartment);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserfaxNumber != null)
            {
                azureADv2AddAzureADUser["FaxNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserfaxNumber);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserjobTitle != null)
            {
                azureADv2AddAzureADUser["JobTitle"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserjobTitle);
                azureADv2AddAzureADUserpropCount++;
            }

            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["MailNickName"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUsermailNickName);
            if (azureADv2AddAzureADUsermobilePhone != null)
            {
                azureADv2AddAzureADUser["MobilePhone"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUsermobilePhone);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUseroffice != null)
            {
                azureADv2AddAzureADUser["Office"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUseroffice);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserphoneNumber != null)
            {
                azureADv2AddAzureADUser["PhoneNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserphoneNumber);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserpostalCode != null)
            {
                azureADv2AddAzureADUser["PostalCode"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserpostalCode);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserpreferredLanguage != null)
            {
                azureADv2AddAzureADUser["PreferredLanguage"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserpreferredLanguage);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserstate != null)
            {
                azureADv2AddAzureADUser["State"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserstate);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserstreetAddress != null)
            {
                azureADv2AddAzureADUser["StreetAddress"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserstreetAddress);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserusageLocation != null)
            {
                azureADv2AddAzureADUser["UsageLocation"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserusageLocation);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserageGroup != null)
            {
                azureADv2AddAzureADUser["AgeGroup"] = CSharpExpressionConverter.Convert(azureADv2AddAzureADUserageGroup);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserconsentProvidedForMinor != null)
            {
                azureADv2AddAzureADUser["ConsentProvidedForMinor"] = CSharpExpressionConverter.Convert(azureADv2AddAzureADUserconsentProvidedForMinor);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUseremployeeId != null)
            {
                azureADv2AddAzureADUser["EmployeeId"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUseremployeeId);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
            {
                if (azureADv2AddAzureADUserforceChangePasswordNextLogin != null)
                {
                    azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserforceChangePasswordNextLogin);
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
                    azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserenforceChangePasswordPolicy);
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
                    azureADv2AddAzureADUser["PasswordNeverExpires"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserpasswordNeverExpires);
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
            azureADv2AddAzureADUser["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2AddAzureADUserworkflow);
            if (azureADv2AddAzureADUserpropCount > 0)
            {
                callPayload.Body = azureADv2AddAzureADUser;
            }

            return new ApiConnectionAction<AzureADv2AddAzureADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse> AzureADv2RemoveAzureADUser(Expression<Func<string>> azureADv2RemoveAzureADUserobjectId, Expression<Func<string>> azureADv2RemoveAzureADUserworkflow, Expression<Func<bool>> azureADv2RemoveAzureADUsererrorIfUserDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAzureADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveAzureADUser = new JObject();
            var azureADv2RemoveAzureADUserpropCount = 0;
            azureADv2RemoveAzureADUserpropCount++;
            azureADv2RemoveAzureADUser["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveAzureADUserobjectId);
            if (azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
            {
                if (azureADv2RemoveAzureADUsererrorIfUserDoesNotExist != null)
                {
                    azureADv2RemoveAzureADUser["ErrorIfUserDoesNotExist"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveAzureADUsererrorIfUserDoesNotExist);
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
            azureADv2RemoveAzureADUser["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveAzureADUserworkflow);
            if (azureADv2RemoveAzureADUserpropCount > 0)
            {
                callPayload.Body = azureADv2RemoveAzureADUser;
            }

            return new ApiConnectionAction<AzureADv2RemoveAzureADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse> AzureADv2ResetAzureADUserPassword(Expression<Func<string>> azureADv2ResetAzureADUserPassworduserPrincipalName, Expression<Func<string>> azureADv2ResetAzureADUserPasswordnewPassword, Expression<Func<string>> azureADv2ResetAzureADUserPasswordworkflow, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword = null, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin = null, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2ResetAzureADUserPassword = new JObject();
            var azureADv2ResetAzureADUserPasswordpropCount = 0;
            azureADv2ResetAzureADUserPasswordpropCount++;
            azureADv2ResetAzureADUserPassword["UserPrincipalName"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPassworduserPrincipalName);
            azureADv2ResetAzureADUserPasswordpropCount++;
            azureADv2ResetAzureADUserPassword["NewPassword"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordnewPassword);
            if (azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
            {
                if (azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword != null)
                {
                    azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordaccountPasswordIsStoredPassword);
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
                    azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordforceChangePasswordNextLogin);
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
                    azureADv2ResetAzureADUserPassword["EnforceChangePasswordPolicy"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordenforceChangePasswordPolicy);
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
            azureADv2ResetAzureADUserPassword["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPasswordworkflow);
            if (azureADv2ResetAzureADUserPasswordpropCount > 0)
            {
                callPayload.Body = azureADv2ResetAzureADUserPassword;
            }

            return new ApiConnectionAction<AzureADv2ResetAzureADUserPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse> AzureADv2GetAzureADUserGroupMembership(Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipobjectId, Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipworkflow, Expression<Func<string>> azureADv2GetAzureADUserGroupMembershippropertiesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserGroupMembership = new JObject();
            var azureADv2GetAzureADUserGroupMembershippropCount = 0;
            azureADv2GetAzureADUserGroupMembershippropCount++;
            azureADv2GetAzureADUserGroupMembership["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserGroupMembershipobjectId);
            if (azureADv2GetAzureADUserGroupMembershippropertiesToReturn != null)
            {
                azureADv2GetAzureADUserGroupMembership["PropertiesToReturn"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserGroupMembershippropertiesToReturn);
                azureADv2GetAzureADUserGroupMembershippropCount++;
            }

            azureADv2GetAzureADUserGroupMembershippropCount++;
            azureADv2GetAzureADUserGroupMembership["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserGroupMembershipworkflow);
            if (azureADv2GetAzureADUserGroupMembershippropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserGroupMembership;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse> AzureADv2IsUserInAzureADUserGroup(Expression<Func<string>> azureADv2IsUserInAzureADUserGroupobjectId, Expression<Func<string>> azureADv2IsUserInAzureADUserGroupgroupObjectId, Expression<Func<string>> azureADv2IsUserInAzureADUserGroupworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInAzureADUserGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2IsUserInAzureADUserGroup = new JObject();
            var azureADv2IsUserInAzureADUserGrouppropCount = 0;
            azureADv2IsUserInAzureADUserGrouppropCount++;
            azureADv2IsUserInAzureADUserGroup["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2IsUserInAzureADUserGroupobjectId);
            azureADv2IsUserInAzureADUserGrouppropCount++;
            azureADv2IsUserInAzureADUserGroup["GroupObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2IsUserInAzureADUserGroupgroupObjectId);
            azureADv2IsUserInAzureADUserGrouppropCount++;
            azureADv2IsUserInAzureADUserGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2IsUserInAzureADUserGroupworkflow);
            if (azureADv2IsUserInAzureADUserGrouppropCount > 0)
            {
                callPayload.Body = azureADv2IsUserInAzureADUserGroup;
            }

            return new ApiConnectionAction<AzureADv2IsUserInAzureADUserGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse> AzureADv2AddUserToGroup(Expression<Func<string>> azureADv2AddUserToGroupuserObjectId, Expression<Func<string>> azureADv2AddUserToGroupgroupObjectId, Expression<Func<string>> azureADv2AddUserToGroupworkflow, Expression<Func<bool>> azureADv2AddUserToGroupcheckUserGroupMembershipsFirst = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddUserToGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AddUserToGroup = new JObject();
            var azureADv2AddUserToGrouppropCount = 0;
            azureADv2AddUserToGrouppropCount++;
            azureADv2AddUserToGroup["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2AddUserToGroupuserObjectId);
            azureADv2AddUserToGrouppropCount++;
            azureADv2AddUserToGroup["GroupObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2AddUserToGroupgroupObjectId);
            if (azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
            {
                if (azureADv2AddUserToGroupcheckUserGroupMembershipsFirst != null)
                {
                    azureADv2AddUserToGroup["CheckUserGroupMembershipsFirst"] = CSharpExpressionConverter.ConvertToken(azureADv2AddUserToGroupcheckUserGroupMembershipsFirst);
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
            azureADv2AddUserToGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2AddUserToGroupworkflow);
            if (azureADv2AddUserToGrouppropCount > 0)
            {
                callPayload.Body = azureADv2AddUserToGroup;
            }

            return new ApiConnectionAction<AzureADv2AddUserToGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse> AzureADv2RemoveUserFromGroup(Expression<Func<string>> azureADv2RemoveUserFromGroupuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromGroupgroupObjectId, Expression<Func<string>> azureADv2RemoveUserFromGroupworkflow, Expression<Func<bool>> azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromGroup = new JObject();
            var azureADv2RemoveUserFromGrouppropCount = 0;
            azureADv2RemoveUserFromGrouppropCount++;
            azureADv2RemoveUserFromGroup["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupuserObjectId);
            azureADv2RemoveUserFromGrouppropCount++;
            azureADv2RemoveUserFromGroup["GroupObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupgroupObjectId);
            if (azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
            {
                if (azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst != null)
                {
                    azureADv2RemoveUserFromGroup["CheckUserGroupMembershipsFirst"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupcheckUserGroupMembershipsFirst);
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
            azureADv2RemoveUserFromGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromGroupworkflow);
            if (azureADv2RemoveUserFromGrouppropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromGroup;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse> AzureADv2AddADUserToMultipleADGroups(Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsuserObjectId, Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsworkflow, Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsgroupNamesJSON = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst = null, Expression<Func<int>> azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddADUserToMultipleADGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AddADUserToMultipleADGroups = new JObject();
            var azureADv2AddADUserToMultipleADGroupspropCount = 0;
            azureADv2AddADUserToMultipleADGroupspropCount++;
            azureADv2AddADUserToMultipleADGroups["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsuserObjectId);
            if (azureADv2AddADUserToMultipleADGroupsgroupNamesJSON != null)
            {
                azureADv2AddADUserToMultipleADGroups["GroupNamesJSON"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsgroupNamesJSON);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            if (azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
            {
                if (azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd != null)
                {
                    azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsexceptionIfAnyGroupsFailToAdd);
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
                    azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsexceptionIfAllGroupsFailToAdd);
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
                    azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupscheckUserGroupMembershipsFirst);
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
                azureADv2AddADUserToMultipleADGroups["MaxAzureADGroupsPerCall"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsmaxAzureADGroupsPerCall);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            azureADv2AddADUserToMultipleADGroupspropCount++;
            azureADv2AddADUserToMultipleADGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2AddADUserToMultipleADGroupsworkflow);
            if (azureADv2AddADUserToMultipleADGroupspropCount > 0)
            {
                callPayload.Body = azureADv2AddADUserToMultipleADGroups;
            }

            return new ApiConnectionAction<AzureADv2AddADUserToMultipleADGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse> AzureADv2RemoveADUserFromMultipleADGroups(Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsuserObjectId, Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsworkflow, Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst = null, Expression<Func<int>> azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveADUserFromMultipleADGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveADUserFromMultipleADGroups = new JObject();
            var azureADv2RemoveADUserFromMultipleADGroupspropCount = 0;
            azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            azureADv2RemoveADUserFromMultipleADGroups["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsuserObjectId);
            if (azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON != null)
            {
                azureADv2RemoveADUserFromMultipleADGroups["GroupNamesJSON"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsgroupNamesJSON);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
            {
                if (azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAnyGroupsFailToRemove);
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
                    azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsexceptionIfAllGroupsFailToRemove);
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
                    azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupscheckUserGroupMembershipsFirst);
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
                azureADv2RemoveADUserFromMultipleADGroups["MaxAzureADGroupsPerCall"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsmaxAzureADGroupsPerCall);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            azureADv2RemoveADUserFromMultipleADGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveADUserFromMultipleADGroupsworkflow);
            if (azureADv2RemoveADUserFromMultipleADGroupspropCount > 0)
            {
                callPayload.Body = azureADv2RemoveADUserFromMultipleADGroups;
            }

            return new ApiConnectionAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse> AzureADv2RemoveUserFromAllGroups(Expression<Func<string>> azureADv2RemoveUserFromAllGroupsuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromAllGroupsworkflow, Expression<Func<bool>> azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove = null, Expression<Func<int>> azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromAllGroups = new JObject();
            var azureADv2RemoveUserFromAllGroupspropCount = 0;
            azureADv2RemoveUserFromAllGroupspropCount++;
            azureADv2RemoveUserFromAllGroups["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsuserObjectId);
            if (azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
            {
                if (azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove != null)
                {
                    azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsexceptionIfAnyGroupsFailToRemove);
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
                    azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsexceptionIfAllGroupsFailToRemove);
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
                azureADv2RemoveUserFromAllGroups["MaxAzureADGroupsPerCall"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsmaxAzureADGroupsPerCall);
                azureADv2RemoveUserFromAllGroupspropCount++;
            }

            azureADv2RemoveUserFromAllGroupspropCount++;
            azureADv2RemoveUserFromAllGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllGroupsworkflow);
            if (azureADv2RemoveUserFromAllGroupspropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromAllGroups;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromAllGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse> AzureADv2GetAzureADLicenseSKUs(Expression<Func<string>> azureADv2GetAzureADLicenseSKUsworkflow, Expression<Func<azureADv2GetAzureADLicenseSKUsexpandPropertyInput>> azureADv2GetAzureADLicenseSKUsexpandProperty = null)
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
                    azureADv2GetAzureADLicenseSKUs["ExpandProperty"] = CSharpExpressionConverter.Convert(azureADv2GetAzureADLicenseSKUsexpandProperty);
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
            azureADv2GetAzureADLicenseSKUs["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADLicenseSKUsworkflow);
            if (azureADv2GetAzureADLicenseSKUspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADLicenseSKUs;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADLicenseSKUsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse> AzureADv2SetAzureADUserLicense(Expression<Func<string>> azureADv2SetAzureADUserLicenseobjectId, Expression<Func<string>> azureADv2SetAzureADUserLicenseworkflow, Expression<Func<string>> azureADv2SetAzureADUserLicenselicenseToAdd = null, Expression<Func<azureADv2SetAzureADUserLicenselicensePlansChoiceInput>> azureADv2SetAzureADUserLicenselicensePlansChoice = null, Expression<Func<string>> azureADv2SetAzureADUserLicenselicensePlansCSV = null, Expression<Func<string>> azureADv2SetAzureADUserLicenselicensesToRemoveCSV = null, Expression<Func<string>> azureADv2SetAzureADUserLicenseusageLocation = null, Expression<Func<bool>> azureADv2SetAzureADUserLicenselocalScope = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserLicense";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2SetAzureADUserLicense = new JObject();
            var azureADv2SetAzureADUserLicensepropCount = 0;
            azureADv2SetAzureADUserLicensepropCount++;
            azureADv2SetAzureADUserLicense["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenseobjectId);
            if (azureADv2SetAzureADUserLicenselicenseToAdd != null)
            {
                azureADv2SetAzureADUserLicense["LicenseToAdd"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselicenseToAdd);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenselicensePlansChoice != null)
            {
                if (azureADv2SetAzureADUserLicenselicensePlansChoice != null)
                {
                    azureADv2SetAzureADUserLicense["LicensePlansChoice"] = CSharpExpressionConverter.Convert(azureADv2SetAzureADUserLicenselicensePlansChoice);
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
                azureADv2SetAzureADUserLicense["LicensePlansCSV"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselicensePlansCSV);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenselicensesToRemoveCSV != null)
            {
                azureADv2SetAzureADUserLicense["LicensesToRemoveCSV"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselicensesToRemoveCSV);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenseusageLocation != null)
            {
                azureADv2SetAzureADUserLicense["UsageLocation"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenseusageLocation);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenselocalScope != null)
            {
                azureADv2SetAzureADUserLicense["LocalScope"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenselocalScope);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            azureADv2SetAzureADUserLicensepropCount++;
            azureADv2SetAzureADUserLicense["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserLicenseworkflow);
            if (azureADv2SetAzureADUserLicensepropCount > 0)
            {
                callPayload.Body = azureADv2SetAzureADUserLicense;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserLicenseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse> AzureADv2GetAzureADUserLicenses(Expression<Func<string>> azureADv2GetAzureADUserLicensesobjectId, Expression<Func<string>> azureADv2GetAzureADUserLicensesworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserLicenses = new JObject();
            var azureADv2GetAzureADUserLicensespropCount = 0;
            azureADv2GetAzureADUserLicensespropCount++;
            azureADv2GetAzureADUserLicenses["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicensesobjectId);
            azureADv2GetAzureADUserLicensespropCount++;
            azureADv2GetAzureADUserLicenses["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicensesworkflow);
            if (azureADv2GetAzureADUserLicensespropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserLicenses;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserLicensesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse> AzureADv2GetAzureADUserLicenseServicePlans(Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansobjectId, Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber, Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenseServicePlans";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserLicenseServicePlans = new JObject();
            var azureADv2GetAzureADUserLicenseServicePlanspropCount = 0;
            azureADv2GetAzureADUserLicenseServicePlanspropCount++;
            azureADv2GetAzureADUserLicenseServicePlans["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicenseServicePlansobjectId);
            azureADv2GetAzureADUserLicenseServicePlanspropCount++;
            azureADv2GetAzureADUserLicenseServicePlans["LicenseSKUPartNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicenseServicePlanslicenseSKUPartNumber);
            azureADv2GetAzureADUserLicenseServicePlanspropCount++;
            azureADv2GetAzureADUserLicenseServicePlans["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserLicenseServicePlansworkflow);
            if (azureADv2GetAzureADUserLicenseServicePlanspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserLicenseServicePlans;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse> AzureADv2RemoveAllAzureADUserLicense(Expression<Func<string>> azureADv2RemoveAllAzureADUserLicenseobjectId, Expression<Func<string>> azureADv2RemoveAllAzureADUserLicenseworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAllAzureADUserLicense";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveAllAzureADUserLicense = new JObject();
            var azureADv2RemoveAllAzureADUserLicensepropCount = 0;
            azureADv2RemoveAllAzureADUserLicensepropCount++;
            azureADv2RemoveAllAzureADUserLicense["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveAllAzureADUserLicenseobjectId);
            azureADv2RemoveAllAzureADUserLicensepropCount++;
            azureADv2RemoveAllAzureADUserLicense["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveAllAzureADUserLicenseworkflow);
            if (azureADv2RemoveAllAzureADUserLicensepropCount > 0)
            {
                callPayload.Body = azureADv2RemoveAllAzureADUserLicense;
            }

            return new ApiConnectionAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse> AzureADv2SetAzureADUser(Expression<Func<string>> azureADv2SetAzureADUserobjectId, Expression<Func<string>> azureADv2SetAzureADUserworkflow, Expression<Func<string>> azureADv2SetAzureADUserfirstName = null, Expression<Func<string>> azureADv2SetAzureADUserlastName = null, Expression<Func<string>> azureADv2SetAzureADUserdisplayName = null, Expression<Func<string>> azureADv2SetAzureADUsercity = null, Expression<Func<string>> azureADv2SetAzureADUsercompanyName = null, Expression<Func<string>> azureADv2SetAzureADUsercountry = null, Expression<Func<string>> azureADv2SetAzureADUserdepartment = null, Expression<Func<string>> azureADv2SetAzureADUserfaxNumber = null, Expression<Func<string>> azureADv2SetAzureADUserjobTitle = null, Expression<Func<string>> azureADv2SetAzureADUsermobilePhone = null, Expression<Func<string>> azureADv2SetAzureADUseroffice = null, Expression<Func<string>> azureADv2SetAzureADUserphoneNumber = null, Expression<Func<string>> azureADv2SetAzureADUserpostalCode = null, Expression<Func<string>> azureADv2SetAzureADUserpreferredLanguage = null, Expression<Func<string>> azureADv2SetAzureADUserstate = null, Expression<Func<string>> azureADv2SetAzureADUserstreetAddress = null, Expression<Func<string>> azureADv2SetAzureADUserusageLocation = null, Expression<Func<azureADv2SetAzureADUserageGroupInput>> azureADv2SetAzureADUserageGroup = null, Expression<Func<azureADv2SetAzureADUserconsentProvidedForMinorInput>> azureADv2SetAzureADUserconsentProvidedForMinor = null, Expression<Func<string>> azureADv2SetAzureADUsermailNickName = null, Expression<Func<string>> azureADv2SetAzureADUseremployeeId = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2SetAzureADUser = new JObject();
            var azureADv2SetAzureADUserpropCount = 0;
            azureADv2SetAzureADUserpropCount++;
            azureADv2SetAzureADUser["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserobjectId);
            if (azureADv2SetAzureADUserfirstName != null)
            {
                azureADv2SetAzureADUser["FirstName"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserfirstName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserlastName != null)
            {
                azureADv2SetAzureADUser["LastName"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserlastName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserdisplayName != null)
            {
                azureADv2SetAzureADUser["DisplayName"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserdisplayName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUsercity != null)
            {
                azureADv2SetAzureADUser["City"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUsercity);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUsercompanyName != null)
            {
                azureADv2SetAzureADUser["CompanyName"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUsercompanyName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUsercountry != null)
            {
                azureADv2SetAzureADUser["Country"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUsercountry);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserdepartment != null)
            {
                azureADv2SetAzureADUser["Department"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserdepartment);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserfaxNumber != null)
            {
                azureADv2SetAzureADUser["FaxNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserfaxNumber);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserjobTitle != null)
            {
                azureADv2SetAzureADUser["JobTitle"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserjobTitle);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUsermobilePhone != null)
            {
                azureADv2SetAzureADUser["MobilePhone"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUsermobilePhone);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUseroffice != null)
            {
                azureADv2SetAzureADUser["Office"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUseroffice);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserphoneNumber != null)
            {
                azureADv2SetAzureADUser["PhoneNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserphoneNumber);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserpostalCode != null)
            {
                azureADv2SetAzureADUser["PostalCode"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserpostalCode);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserpreferredLanguage != null)
            {
                azureADv2SetAzureADUser["PreferredLanguage"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserpreferredLanguage);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserstate != null)
            {
                azureADv2SetAzureADUser["State"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserstate);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserstreetAddress != null)
            {
                azureADv2SetAzureADUser["StreetAddress"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserstreetAddress);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserusageLocation != null)
            {
                azureADv2SetAzureADUser["UsageLocation"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserusageLocation);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserageGroup != null)
            {
                azureADv2SetAzureADUser["AgeGroup"] = CSharpExpressionConverter.Convert(azureADv2SetAzureADUserageGroup);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserconsentProvidedForMinor != null)
            {
                azureADv2SetAzureADUser["ConsentProvidedForMinor"] = CSharpExpressionConverter.Convert(azureADv2SetAzureADUserconsentProvidedForMinor);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUsermailNickName != null)
            {
                azureADv2SetAzureADUser["MailNickName"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUsermailNickName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUseremployeeId != null)
            {
                azureADv2SetAzureADUser["EmployeeId"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUseremployeeId);
                azureADv2SetAzureADUserpropCount++;
            }

            azureADv2SetAzureADUserpropCount++;
            azureADv2SetAzureADUser["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserworkflow);
            if (azureADv2SetAzureADUserpropCount > 0)
            {
                callPayload.Body = azureADv2SetAzureADUser;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse> AzureADv2ResetAzureADUserProperties(Expression<Func<string>> azureADv2ResetAzureADUserPropertiesobjectId, Expression<Func<string>> azureADv2ResetAzureADUserPropertiesworkflow, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetFirstName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetLastName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetCity = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetCompanyName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetCountry = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetDepartment = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetFaxNumber = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetJobTitle = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetMobilePhone = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetOffice = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetPhoneNumber = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetPostalCode = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetPreferredLanguage = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetState = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetStreetAddress = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetUsageLocation = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetAgeGroup = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesresetEmployeeId = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2ResetAzureADUserProperties = new JObject();
            var azureADv2ResetAzureADUserPropertiespropCount = 0;
            azureADv2ResetAzureADUserPropertiespropCount++;
            azureADv2ResetAzureADUserProperties["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesobjectId);
            if (azureADv2ResetAzureADUserPropertiesresetFirstName != null)
            {
                if (azureADv2ResetAzureADUserPropertiesresetFirstName != null)
                {
                    azureADv2ResetAzureADUserProperties["ResetFirstName"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetFirstName);
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
                    azureADv2ResetAzureADUserProperties["ResetLastName"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetLastName);
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
                    azureADv2ResetAzureADUserProperties["ResetCity"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetCity);
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
                    azureADv2ResetAzureADUserProperties["ResetCompanyName"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetCompanyName);
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
                    azureADv2ResetAzureADUserProperties["ResetCountry"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetCountry);
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
                    azureADv2ResetAzureADUserProperties["ResetDepartment"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetDepartment);
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
                    azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetFaxNumber);
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
                    azureADv2ResetAzureADUserProperties["ResetJobTitle"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetJobTitle);
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
                    azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetMobilePhone);
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
                    azureADv2ResetAzureADUserProperties["ResetOffice"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetOffice);
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
                    azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetPhoneNumber);
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
                    azureADv2ResetAzureADUserProperties["ResetPostalCode"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetPostalCode);
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
                    azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetPreferredLanguage);
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
                    azureADv2ResetAzureADUserProperties["ResetState"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetState);
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
                    azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetStreetAddress);
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
                    azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetUsageLocation);
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
                    azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetAgeGroup);
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
                    azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetConsentProvidedForMinor);
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
                    azureADv2ResetAzureADUserProperties["ResetEmployeeId"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesresetEmployeeId);
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
            azureADv2ResetAzureADUserProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2ResetAzureADUserPropertiesworkflow);
            if (azureADv2ResetAzureADUserPropertiespropCount > 0)
            {
                callPayload.Body = azureADv2ResetAzureADUserProperties;
            }

            return new ApiConnectionAction<AzureADv2ResetAzureADUserPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse> AzureADv2SetAzureADUserManager(Expression<Func<string>> azureADv2SetAzureADUserManagerobjectId, Expression<Func<string>> azureADv2SetAzureADUserManagerworkflow, Expression<Func<string>> azureADv2SetAzureADUserManagermanager = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserManager";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2SetAzureADUserManager = new JObject();
            var azureADv2SetAzureADUserManagerpropCount = 0;
            azureADv2SetAzureADUserManagerpropCount++;
            azureADv2SetAzureADUserManager["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserManagerobjectId);
            if (azureADv2SetAzureADUserManagermanager != null)
            {
                azureADv2SetAzureADUserManager["Manager"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserManagermanager);
                azureADv2SetAzureADUserManagerpropCount++;
            }

            azureADv2SetAzureADUserManagerpropCount++;
            azureADv2SetAzureADUserManager["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2SetAzureADUserManagerworkflow);
            if (azureADv2SetAzureADUserManagerpropCount > 0)
            {
                callPayload.Body = azureADv2SetAzureADUserManager;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserManagerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse> AzureADv2NewSecurityGroup(Expression<Func<string>> azureADv2NewSecurityGroupdisplayName, Expression<Func<string>> azureADv2NewSecurityGroupworkflow, Expression<Func<string>> azureADv2NewSecurityGroupdescription = null, Expression<Func<bool>> azureADv2NewSecurityGroupcheckGroupExists = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewSecurityGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2NewSecurityGroup = new JObject();
            var azureADv2NewSecurityGrouppropCount = 0;
            azureADv2NewSecurityGrouppropCount++;
            azureADv2NewSecurityGroup["DisplayName"] = CSharpExpressionConverter.ConvertToken(azureADv2NewSecurityGroupdisplayName);
            if (azureADv2NewSecurityGroupdescription != null)
            {
                azureADv2NewSecurityGroup["Description"] = CSharpExpressionConverter.ConvertToken(azureADv2NewSecurityGroupdescription);
                azureADv2NewSecurityGrouppropCount++;
            }

            if (azureADv2NewSecurityGroupcheckGroupExists != null)
            {
                if (azureADv2NewSecurityGroupcheckGroupExists != null)
                {
                    azureADv2NewSecurityGroup["CheckGroupExists"] = CSharpExpressionConverter.ConvertToken(azureADv2NewSecurityGroupcheckGroupExists);
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
            azureADv2NewSecurityGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2NewSecurityGroupworkflow);
            if (azureADv2NewSecurityGrouppropCount > 0)
            {
                callPayload.Body = azureADv2NewSecurityGroup;
            }

            return new ApiConnectionAction<AzureADv2NewSecurityGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse> AzureADv2RemoveSecurityGroup(Expression<Func<string>> azureADv2RemoveSecurityGroupgroupObjectId, Expression<Func<string>> azureADv2RemoveSecurityGroupworkflow, Expression<Func<bool>> azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveSecurityGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveSecurityGroup = new JObject();
            var azureADv2RemoveSecurityGrouppropCount = 0;
            azureADv2RemoveSecurityGrouppropCount++;
            azureADv2RemoveSecurityGroup["GroupObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveSecurityGroupgroupObjectId);
            if (azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
            {
                if (azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist != null)
                {
                    azureADv2RemoveSecurityGroup["ErrorIfGroupDoesNotExist"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveSecurityGrouperrorIfGroupDoesNotExist);
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
            azureADv2RemoveSecurityGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveSecurityGroupworkflow);
            if (azureADv2RemoveSecurityGrouppropCount > 0)
            {
                callPayload.Body = azureADv2RemoveSecurityGroup;
            }

            return new ApiConnectionAction<AzureADv2RemoveSecurityGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse> AzureADv2NewMicrosoft365Group(Expression<Func<string>> azureADv2NewMicrosoft365GroupdisplayName, Expression<Func<string>> azureADv2NewMicrosoft365Groupworkflow, Expression<Func<string>> azureADv2NewMicrosoft365Groupdescription = null, Expression<Func<string>> azureADv2NewMicrosoft365GroupmailNickname = null, Expression<Func<azureADv2NewMicrosoft365GroupgroupVisibilityInput>> azureADv2NewMicrosoft365GroupgroupVisibility = null, Expression<Func<bool>> azureADv2NewMicrosoft365GroupcheckGroupExists = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewMicrosoft365Group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2NewMicrosoft365Group = new JObject();
            var azureADv2NewMicrosoft365GrouppropCount = 0;
            azureADv2NewMicrosoft365GrouppropCount++;
            azureADv2NewMicrosoft365Group["DisplayName"] = CSharpExpressionConverter.ConvertToken(azureADv2NewMicrosoft365GroupdisplayName);
            if (azureADv2NewMicrosoft365Groupdescription != null)
            {
                azureADv2NewMicrosoft365Group["Description"] = CSharpExpressionConverter.ConvertToken(azureADv2NewMicrosoft365Groupdescription);
                azureADv2NewMicrosoft365GrouppropCount++;
            }

            if (azureADv2NewMicrosoft365GroupmailNickname != null)
            {
                azureADv2NewMicrosoft365Group["MailNickname"] = CSharpExpressionConverter.ConvertToken(azureADv2NewMicrosoft365GroupmailNickname);
                azureADv2NewMicrosoft365GrouppropCount++;
            }

            if (azureADv2NewMicrosoft365GroupgroupVisibility != null)
            {
                if (azureADv2NewMicrosoft365GroupgroupVisibility != null)
                {
                    azureADv2NewMicrosoft365Group["GroupVisibility"] = CSharpExpressionConverter.Convert(azureADv2NewMicrosoft365GroupgroupVisibility);
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
                    azureADv2NewMicrosoft365Group["CheckGroupExists"] = CSharpExpressionConverter.ConvertToken(azureADv2NewMicrosoft365GroupcheckGroupExists);
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
            azureADv2NewMicrosoft365Group["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2NewMicrosoft365Groupworkflow);
            if (azureADv2NewMicrosoft365GrouppropCount > 0)
            {
                callPayload.Body = azureADv2NewMicrosoft365Group;
            }

            return new ApiConnectionAction<AzureADv2NewMicrosoft365GroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse> AzureADv2GetGroups(Expression<Func<string>> azureADv2GetGroupsworkflow, Expression<Func<string>> azureADv2GetGroupsobjectId = null, Expression<Func<string>> azureADv2GetGroupsfilterPropertyName = null, Expression<Func<azureADv2GetGroupsfilterPropertyComparisonInput>> azureADv2GetGroupsfilterPropertyComparison = null, Expression<Func<string>> azureADv2GetGroupsfilterPropertyValue = null, Expression<Func<bool>> azureADv2GetGroupsnoResultIsAnException = null, Expression<Func<string>> azureADv2GetGroupspropertiesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetGroups = new JObject();
            var azureADv2GetGroupspropCount = 0;
            if (azureADv2GetGroupsobjectId != null)
            {
                azureADv2GetGroups["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetGroupsobjectId);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsfilterPropertyName != null)
            {
                azureADv2GetGroups["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(azureADv2GetGroupsfilterPropertyName);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsfilterPropertyComparison != null)
            {
                if (azureADv2GetGroupsfilterPropertyComparison != null)
                {
                    azureADv2GetGroups["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(azureADv2GetGroupsfilterPropertyComparison);
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
                azureADv2GetGroups["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(azureADv2GetGroupsfilterPropertyValue);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsnoResultIsAnException != null)
            {
                if (azureADv2GetGroupsnoResultIsAnException != null)
                {
                    azureADv2GetGroups["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(azureADv2GetGroupsnoResultIsAnException);
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
                azureADv2GetGroups["PropertiesToReturn"] = CSharpExpressionConverter.ConvertToken(azureADv2GetGroupspropertiesToReturn);
                azureADv2GetGroupspropCount++;
            }

            azureADv2GetGroupspropCount++;
            azureADv2GetGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetGroupsworkflow);
            if (azureADv2GetGroupspropCount > 0)
            {
                callPayload.Body = azureADv2GetGroups;
            }

            return new ApiConnectionAction<AzureADv2GetGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse> AzureADv2EnableUser(Expression<Func<string>> azureADv2EnableUseruserObjectId, Expression<Func<string>> azureADv2EnableUserworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2EnableUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2EnableUser = new JObject();
            var azureADv2EnableUserpropCount = 0;
            azureADv2EnableUserpropCount++;
            azureADv2EnableUser["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2EnableUseruserObjectId);
            azureADv2EnableUserpropCount++;
            azureADv2EnableUser["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2EnableUserworkflow);
            if (azureADv2EnableUserpropCount > 0)
            {
                callPayload.Body = azureADv2EnableUser;
            }

            return new ApiConnectionAction<AzureADv2EnableUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse> AzureADv2DisableUser(Expression<Func<string>> azureADv2DisableUseruserObjectId, Expression<Func<string>> azureADv2DisableUserworkflow, Expression<Func<bool>> azureADv2DisableUserrevokeUserRefreshTokens = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2DisableUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2DisableUser = new JObject();
            var azureADv2DisableUserpropCount = 0;
            azureADv2DisableUserpropCount++;
            azureADv2DisableUser["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2DisableUseruserObjectId);
            if (azureADv2DisableUserrevokeUserRefreshTokens != null)
            {
                if (azureADv2DisableUserrevokeUserRefreshTokens != null)
                {
                    azureADv2DisableUser["RevokeUserRefreshTokens"] = CSharpExpressionConverter.ConvertToken(azureADv2DisableUserrevokeUserRefreshTokens);
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
            azureADv2DisableUser["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2DisableUserworkflow);
            if (azureADv2DisableUserpropCount > 0)
            {
                callPayload.Body = azureADv2DisableUser;
            }

            return new ApiConnectionAction<AzureADv2DisableUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse> AzureADv2AssignUserToRole(Expression<Func<string>> azureADv2AssignUserToRoleuserObjectId, Expression<Func<string>> azureADv2AssignUserToRoleroleObjectId, Expression<Func<string>> azureADv2AssignUserToRoleworkflow, Expression<Func<string>> azureADv2AssignUserToRoledirectoryScopeId = null, Expression<Func<bool>> azureADv2AssignUserToRolecheckUserRoleMembershipsFirst = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToRole";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AssignUserToRole = new JObject();
            var azureADv2AssignUserToRolepropCount = 0;
            azureADv2AssignUserToRolepropCount++;
            azureADv2AssignUserToRole["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToRoleuserObjectId);
            azureADv2AssignUserToRolepropCount++;
            azureADv2AssignUserToRole["RoleObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToRoleroleObjectId);
            if (azureADv2AssignUserToRoledirectoryScopeId != null)
            {
                if (azureADv2AssignUserToRoledirectoryScopeId != null)
                {
                    azureADv2AssignUserToRole["DirectoryScopeId"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToRoledirectoryScopeId);
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
                    azureADv2AssignUserToRole["CheckUserRoleMembershipsFirst"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToRolecheckUserRoleMembershipsFirst);
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
            azureADv2AssignUserToRole["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToRoleworkflow);
            if (azureADv2AssignUserToRolepropCount > 0)
            {
                callPayload.Body = azureADv2AssignUserToRole;
            }

            return new ApiConnectionAction<AzureADv2AssignUserToRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse> AzureADv2AssignUserToMultipleRoles(Expression<Func<string>> azureADv2AssignUserToMultipleRolesuserObjectId, Expression<Func<string>> azureADv2AssignUserToMultipleRolesworkflow, Expression<Func<string>> azureADv2AssignUserToMultipleRolesrolesJSON = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign = null, Expression<Func<string>> azureADv2AssignUserToMultipleRolesdirectoryScopeId = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolescheckRoleIdsExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToMultipleRoles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AssignUserToMultipleRoles = new JObject();
            var azureADv2AssignUserToMultipleRolespropCount = 0;
            azureADv2AssignUserToMultipleRolespropCount++;
            azureADv2AssignUserToMultipleRoles["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesuserObjectId);
            if (azureADv2AssignUserToMultipleRolesrolesJSON != null)
            {
                azureADv2AssignUserToMultipleRoles["RolesJSON"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesrolesJSON);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            if (azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
            {
                if (azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign != null)
                {
                    azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesexceptionIfAnyRolesFailToAssign);
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
                    azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesexceptionIfAllRolesFailToAssign);
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
                    azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesdirectoryScopeId);
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
                    azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolescheckUserRoleMembershipsFirst);
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
                    azureADv2AssignUserToMultipleRoles["CheckRoleIdsExist"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolescheckRoleIdsExist);
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
            azureADv2AssignUserToMultipleRoles["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2AssignUserToMultipleRolesworkflow);
            if (azureADv2AssignUserToMultipleRolespropCount > 0)
            {
                callPayload.Body = azureADv2AssignUserToMultipleRoles;
            }

            return new ApiConnectionAction<AzureADv2AssignUserToMultipleRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse> AzureADv2RemoveUserFromMultipleRoles(Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesworkflow, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesrolesJSON = null, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesdirectoryScopeId = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromMultipleRoles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromMultipleRoles = new JObject();
            var azureADv2RemoveUserFromMultipleRolespropCount = 0;
            azureADv2RemoveUserFromMultipleRolespropCount++;
            azureADv2RemoveUserFromMultipleRoles["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesuserObjectId);
            if (azureADv2RemoveUserFromMultipleRolesrolesJSON != null)
            {
                azureADv2RemoveUserFromMultipleRoles["RolesJSON"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesrolesJSON);
                azureADv2RemoveUserFromMultipleRolespropCount++;
            }

            if (azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
            {
                if (azureADv2RemoveUserFromMultipleRolesdirectoryScopeId != null)
                {
                    azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesdirectoryScopeId);
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
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesexceptionIfAnyRolesFailToRemove);
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
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesexceptionIfAllRolesFailToRemove);
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
                    azureADv2RemoveUserFromMultipleRoles["ExceptionIfRoleDoesNotExist"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesexceptionIfRoleDoesNotExist);
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
            azureADv2RemoveUserFromMultipleRoles["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromMultipleRolesworkflow);
            if (azureADv2RemoveUserFromMultipleRolespropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromMultipleRoles;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromMultipleRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse> AzureADv2IsUserInRole(Expression<Func<string>> azureADv2IsUserInRoleuserObjectId, Expression<Func<string>> azureADv2IsUserInRoleroleObjectId, Expression<Func<string>> azureADv2IsUserInRoleworkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInRole";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2IsUserInRole = new JObject();
            var azureADv2IsUserInRolepropCount = 0;
            azureADv2IsUserInRolepropCount++;
            azureADv2IsUserInRole["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2IsUserInRoleuserObjectId);
            azureADv2IsUserInRolepropCount++;
            azureADv2IsUserInRole["RoleObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2IsUserInRoleroleObjectId);
            azureADv2IsUserInRolepropCount++;
            azureADv2IsUserInRole["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2IsUserInRoleworkflow);
            if (azureADv2IsUserInRolepropCount > 0)
            {
                callPayload.Body = azureADv2IsUserInRole;
            }

            return new ApiConnectionAction<AzureADv2IsUserInRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse> AzureADv2GetAzureADUserRoleAssignments(Expression<Func<string>> azureADv2GetAzureADUserRoleAssignmentsobjectId, Expression<Func<string>> azureADv2GetAzureADUserRoleAssignmentsworkflow, Expression<Func<bool>> azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames = null, Expression<Func<bool>> azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserRoleAssignments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserRoleAssignments = new JObject();
            var azureADv2GetAzureADUserRoleAssignmentspropCount = 0;
            azureADv2GetAzureADUserRoleAssignmentspropCount++;
            azureADv2GetAzureADUserRoleAssignments["ObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsobjectId);
            if (azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
            {
                if (azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames != null)
                {
                    azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsretrieveAdminRoleNames);
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
                    azureADv2GetAzureADUserRoleAssignments["ReturnAssignmentIds"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsreturnAssignmentIds);
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
            azureADv2GetAzureADUserRoleAssignments["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADUserRoleAssignmentsworkflow);
            if (azureADv2GetAzureADUserRoleAssignmentspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserRoleAssignments;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse> AzureADv2RemoveUserFromRole(Expression<Func<string>> azureADv2RemoveUserFromRoleuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromRoleroleObjectId, Expression<Func<string>> azureADv2RemoveUserFromRoleworkflow, Expression<Func<string>> azureADv2RemoveUserFromRoledirectoryScopeId = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromRole";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromRole = new JObject();
            var azureADv2RemoveUserFromRolepropCount = 0;
            azureADv2RemoveUserFromRolepropCount++;
            azureADv2RemoveUserFromRole["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoleuserObjectId);
            azureADv2RemoveUserFromRolepropCount++;
            azureADv2RemoveUserFromRole["RoleObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoleroleObjectId);
            if (azureADv2RemoveUserFromRoledirectoryScopeId != null)
            {
                if (azureADv2RemoveUserFromRoledirectoryScopeId != null)
                {
                    azureADv2RemoveUserFromRole["DirectoryScopeId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoledirectoryScopeId);
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
            azureADv2RemoveUserFromRole["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromRoleworkflow);
            if (azureADv2RemoveUserFromRolepropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromRole;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse> AzureADv2RemoveUserFromAllRoles(Expression<Func<string>> azureADv2RemoveUserFromAllRolesuserObjectId, Expression<Func<string>> azureADv2RemoveUserFromAllRolesworkflow, Expression<Func<bool>> azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllRoles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromAllRoles = new JObject();
            var azureADv2RemoveUserFromAllRolespropCount = 0;
            azureADv2RemoveUserFromAllRolespropCount++;
            azureADv2RemoveUserFromAllRoles["UserObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesuserObjectId);
            if (azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
            {
                if (azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove != null)
                {
                    azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesexceptionIfAnyRolesFailToRemove);
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
                    azureADv2RemoveUserFromAllRoles["ExceptionIfAllRolesFailToRemove"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesexceptionIfAllRolesFailToRemove);
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
            azureADv2RemoveUserFromAllRoles["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2RemoveUserFromAllRolesworkflow);
            if (azureADv2RemoveUserFromAllRolespropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromAllRoles;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromAllRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse> AzureADv2GetAzureADGroupMembers(Expression<Func<string>> azureADv2GetAzureADGroupMembersgroupObjectId, Expression<Func<string>> azureADv2GetAzureADGroupMembersworkflow, Expression<Func<string>> azureADv2GetAzureADGroupMemberspropertiesToReturn = null, Expression<Func<string>> azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADGroupMembers = new JObject();
            var azureADv2GetAzureADGroupMemberspropCount = 0;
            azureADv2GetAzureADGroupMemberspropCount++;
            azureADv2GetAzureADGroupMembers["GroupObjectId"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMembersgroupObjectId);
            if (azureADv2GetAzureADGroupMemberspropertiesToReturn != null)
            {
                azureADv2GetAzureADGroupMembers["PropertiesToReturn"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMemberspropertiesToReturn);
                azureADv2GetAzureADGroupMemberspropCount++;
            }

            if (azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn != null)
            {
                azureADv2GetAzureADGroupMembers["MemberObjectTypesToReturn"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMembersmemberObjectTypesToReturn);
                azureADv2GetAzureADGroupMemberspropCount++;
            }

            azureADv2GetAzureADGroupMemberspropCount++;
            azureADv2GetAzureADGroupMembers["Workflow"] = CSharpExpressionConverter.ConvertToken(azureADv2GetAzureADGroupMembersworkflow);
            if (azureADv2GetAzureADGroupMemberspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADGroupMembers;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse> OpenO365PowerShellRunspace(Expression<Func<string>> openO365PowerShellRunspaceoffice365Username, Expression<Func<string>> openO365PowerShellRunspaceoffice365Password, Expression<Func<string>> openO365PowerShellRunspaceworkflow, Expression<Func<string>> openO365PowerShellRunspaceexchangeURL = null, Expression<Func<openO365PowerShellRunspaceconnectionMethodInput>> openO365PowerShellRunspaceconnectionMethod = null, Expression<Func<bool>> openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected = null, Expression<Func<openO365PowerShellRunspacecommandTypesToImportLocallyInput>> openO365PowerShellRunspacecommandTypesToImportLocally = null, Expression<Func<string>> openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openO365PowerShellRunspace = new JObject();
            var openO365PowerShellRunspacepropCount = 0;
            openO365PowerShellRunspacepropCount++;
            openO365PowerShellRunspace["Office365Username"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceoffice365Username);
            openO365PowerShellRunspacepropCount++;
            openO365PowerShellRunspace["Office365Password"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceoffice365Password);
            if (openO365PowerShellRunspaceexchangeURL != null)
            {
                openO365PowerShellRunspace["ExchangeURL"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceexchangeURL);
                openO365PowerShellRunspacepropCount++;
            }

            if (openO365PowerShellRunspaceconnectionMethod != null)
            {
                if (openO365PowerShellRunspaceconnectionMethod != null)
                {
                    openO365PowerShellRunspace["ConnectionMethod"] = CSharpExpressionConverter.Convert(openO365PowerShellRunspaceconnectionMethod);
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
                    openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceonlyConnectIfNotAlreadyConnected);
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
                    openO365PowerShellRunspace["CommandTypesToImportLocally"] = CSharpExpressionConverter.Convert(openO365PowerShellRunspacecommandTypesToImportLocally);
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
                openO365PowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceadditionalCommandsToImportLocallyCSV);
                openO365PowerShellRunspacepropCount++;
            }

            openO365PowerShellRunspacepropCount++;
            openO365PowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceworkflow);
            if (openO365PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openO365PowerShellRunspace;
            }

            return new ApiConnectionAction<OpenO365PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse> OpenO365PowerShellRunspaceWithCertificate(Expression<Func<string>> openO365PowerShellRunspaceWithCertificateapplicationId, Expression<Func<string>> openO365PowerShellRunspaceWithCertificatecertificateThumbprint, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateorganization, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateworkflow, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateexchangeURL = null, Expression<Func<openO365PowerShellRunspaceWithCertificateconnectionMethodInput>> openO365PowerShellRunspaceWithCertificateconnectionMethod = null, Expression<Func<bool>> openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected = null, Expression<Func<openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocallyInput>> openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally = null, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspaceWithCertificate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openO365PowerShellRunspaceWithCertificate = new JObject();
            var openO365PowerShellRunspaceWithCertificatepropCount = 0;
            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["ApplicationId"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateapplicationId);
            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["CertificateThumbprint"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificatecertificateThumbprint);
            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["Organization"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateorganization);
            if (openO365PowerShellRunspaceWithCertificateexchangeURL != null)
            {
                openO365PowerShellRunspaceWithCertificate["ExchangeURL"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateexchangeURL);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            if (openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
            {
                if (openO365PowerShellRunspaceWithCertificateconnectionMethod != null)
                {
                    openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = CSharpExpressionConverter.Convert(openO365PowerShellRunspaceWithCertificateconnectionMethod);
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
                    openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateonlyConnectIfNotAlreadyConnected);
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
                    openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = CSharpExpressionConverter.Convert(openO365PowerShellRunspaceWithCertificatecommandTypesToImportLocally);
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
                openO365PowerShellRunspaceWithCertificate["AdditionalCommandsToImportLocallyCSV"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateadditionalCommandsToImportLocallyCSV);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["Workflow"] = CSharpExpressionConverter.ConvertToken(openO365PowerShellRunspaceWithCertificateworkflow);
            if (openO365PowerShellRunspaceWithCertificatepropCount > 0)
            {
                callPayload.Body = openO365PowerShellRunspaceWithCertificate;
            }

            return new ApiConnectionAction<OpenO365PowerShellRunspaceWithCertificateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse> IsO365PowerShellRunspaceOpen(Expression<Func<string>> isO365PowerShellRunspaceOpenworkflow, Expression<Func<bool>> isO365PowerShellRunspaceOpentestCommunications = null, Expression<Func<bool>> isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID = null)
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
                    isO365PowerShellRunspaceOpen["TestCommunications"] = CSharpExpressionConverter.ConvertToken(isO365PowerShellRunspaceOpentestCommunications);
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
                    isO365PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = CSharpExpressionConverter.ConvertToken(isO365PowerShellRunspaceOpenretrievePowerShellRunSpacePID);
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
            isO365PowerShellRunspaceOpen["Workflow"] = CSharpExpressionConverter.ConvertToken(isO365PowerShellRunspaceOpenworkflow);
            if (isO365PowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isO365PowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsO365PowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse> RunO365PowerShellAutomationScript(Expression<Func<string>> runO365PowerShellAutomationScriptworkflow, Expression<Func<string>> runO365PowerShellAutomationScriptpowerShellScriptContents = null, Expression<Func<bool>> runO365PowerShellAutomationScriptisNoResultAnError = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnComplexTypes = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnBooleanAsBoolean = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnNumericAsDecimal = null, Expression<Func<bool>> runO365PowerShellAutomationScriptreturnDateAsDate = null, Expression<Func<string>> runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runO365PowerShellAutomationScriptlocalScope = null, Expression<Func<bool>> runO365PowerShellAutomationScriptrunScriptAsThread = null, Expression<Func<int>> runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId = null, Expression<Func<int>> runO365PowerShellAutomationScriptsecondsToWaitForThread = null, Expression<Func<bool>> runO365PowerShellAutomationScriptscriptContainsStoredPassword = null, Expression<Func<bool>> runO365PowerShellAutomationScriptlogVerboseOutput = null, Expression<Func<string>> runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON = null, Expression<Func<string>> runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON = null, Expression<Func<runO365PowerShellAutomationScriptpowerShellCommandParametersInputItem[]>> runO365PowerShellAutomationScriptpowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunO365PowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runO365PowerShellAutomationScript = new JObject();
            var runO365PowerShellAutomationScriptpropCount = 0;
            if (runO365PowerShellAutomationScriptpowerShellScriptContents != null)
            {
                runO365PowerShellAutomationScript["PowerShellScriptContents"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpowerShellScriptContents);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptisNoResultAnError != null)
            {
                if (runO365PowerShellAutomationScriptisNoResultAnError != null)
                {
                    runO365PowerShellAutomationScript["IsNoResultAnError"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptisNoResultAnError);
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
                    runO365PowerShellAutomationScript["ReturnComplexTypes"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnComplexTypes);
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
                    runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnBooleanAsBoolean);
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
                    runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnNumericAsDecimal);
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
                    runO365PowerShellAutomationScript["ReturnDateAsDate"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptreturnDateAsDate);
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
                runO365PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpropertiesToReturnAsCollectionJSON);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptlocalScope != null)
            {
                runO365PowerShellAutomationScript["LocalScope"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptlocalScope);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptrunScriptAsThread != null)
            {
                if (runO365PowerShellAutomationScriptrunScriptAsThread != null)
                {
                    runO365PowerShellAutomationScript["RunScriptAsThread"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptrunScriptAsThread);
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
                runO365PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptretrieveOutputDataFromThreadId);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
            {
                if (runO365PowerShellAutomationScriptsecondsToWaitForThread != null)
                {
                    runO365PowerShellAutomationScript["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptsecondsToWaitForThread);
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
                    runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptscriptContainsStoredPassword);
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
                    runO365PowerShellAutomationScript["LogVerboseOutput"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptlogVerboseOutput);
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
                runO365PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpropertyNamesToSerializeJSON);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON != null)
            {
                runO365PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpropertyTypesToSerializeJSON);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptpowerShellCommandParameters != null)
            {
                runO365PowerShellAutomationScript["PowerShellCommandParameters"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptpowerShellCommandParameters);
                runO365PowerShellAutomationScriptpropCount++;
            }

            runO365PowerShellAutomationScriptpropCount++;
            runO365PowerShellAutomationScript["Workflow"] = CSharpExpressionConverter.ConvertToken(runO365PowerShellAutomationScriptworkflow);
            if (runO365PowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runO365PowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunO365PowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse> CloseO365PowerShellRunspace(Expression<Func<string>> closeO365PowerShellRunspaceworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/CloseO365PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeO365PowerShellRunspace = new JObject();
            var closeO365PowerShellRunspacepropCount = 0;
            closeO365PowerShellRunspacepropCount++;
            closeO365PowerShellRunspace["Workflow"] = CSharpExpressionConverter.ConvertToken(closeO365PowerShellRunspaceworkflow);
            if (closeO365PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeO365PowerShellRunspace;
            }

            return new ApiConnectionAction<CloseO365PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365MailboxResponse> O365GetO365Mailbox(Expression<Func<string>> o365GetO365Mailboxworkflow, Expression<Func<string>> o365GetO365Mailboxidentity = null, Expression<Func<string>> o365GetO365MailboxfilterPropertyName = null, Expression<Func<o365GetO365MailboxfilterPropertyComparisonInput>> o365GetO365MailboxfilterPropertyComparison = null, Expression<Func<string>> o365GetO365MailboxfilterPropertyValue = null, Expression<Func<o365GetO365MailboxrecipientTypeDetailsInput>> o365GetO365MailboxrecipientTypeDetails = null, Expression<Func<bool>> o365GetO365MailboxnoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetO365Mailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetO365Mailbox = new JObject();
            var o365GetO365MailboxpropCount = 0;
            if (o365GetO365Mailboxidentity != null)
            {
                o365GetO365Mailbox["Identity"] = CSharpExpressionConverter.ConvertToken(o365GetO365Mailboxidentity);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxfilterPropertyName != null)
            {
                o365GetO365Mailbox["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(o365GetO365MailboxfilterPropertyName);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxfilterPropertyComparison != null)
            {
                if (o365GetO365MailboxfilterPropertyComparison != null)
                {
                    o365GetO365Mailbox["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(o365GetO365MailboxfilterPropertyComparison);
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
                o365GetO365Mailbox["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(o365GetO365MailboxfilterPropertyValue);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxrecipientTypeDetails != null)
            {
                o365GetO365Mailbox["RecipientTypeDetails"] = CSharpExpressionConverter.Convert(o365GetO365MailboxrecipientTypeDetails);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxnoResultIsAnException != null)
            {
                if (o365GetO365MailboxnoResultIsAnException != null)
                {
                    o365GetO365Mailbox["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(o365GetO365MailboxnoResultIsAnException);
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
            o365GetO365Mailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(o365GetO365Mailboxworkflow);
            if (o365GetO365MailboxpropCount > 0)
            {
                callPayload.Body = o365GetO365Mailbox;
            }

            return new ApiConnectionAction<O365GetO365MailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse> O365AddMailboxPermission(Expression<Func<string>> o365AddMailboxPermissionidentity, Expression<Func<string>> o365AddMailboxPermissionuser, Expression<Func<string>> o365AddMailboxPermissionaccessRights, Expression<Func<string>> o365AddMailboxPermissionworkflow, Expression<Func<bool>> o365AddMailboxPermissionautoMapping = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365AddMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365AddMailboxPermission = new JObject();
            var o365AddMailboxPermissionpropCount = 0;
            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["Identity"] = CSharpExpressionConverter.ConvertToken(o365AddMailboxPermissionidentity);
            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["User"] = CSharpExpressionConverter.ConvertToken(o365AddMailboxPermissionuser);
            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["AccessRights"] = CSharpExpressionConverter.ConvertToken(o365AddMailboxPermissionaccessRights);
            if (o365AddMailboxPermissionautoMapping != null)
            {
                if (o365AddMailboxPermissionautoMapping != null)
                {
                    o365AddMailboxPermission["AutoMapping"] = CSharpExpressionConverter.ConvertToken(o365AddMailboxPermissionautoMapping);
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
            o365AddMailboxPermission["Workflow"] = CSharpExpressionConverter.ConvertToken(o365AddMailboxPermissionworkflow);
            if (o365AddMailboxPermissionpropCount > 0)
            {
                callPayload.Body = o365AddMailboxPermission;
            }

            return new ApiConnectionAction<O365AddMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse> O365RemoveMailboxPermission(Expression<Func<string>> o365RemoveMailboxPermissionidentity, Expression<Func<string>> o365RemoveMailboxPermissionuser, Expression<Func<string>> o365RemoveMailboxPermissionaccessRights, Expression<Func<string>> o365RemoveMailboxPermissionworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveMailboxPermission = new JObject();
            var o365RemoveMailboxPermissionpropCount = 0;
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["Identity"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxPermissionidentity);
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["User"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxPermissionuser);
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["AccessRights"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxPermissionaccessRights);
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["Workflow"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxPermissionworkflow);
            if (o365RemoveMailboxPermissionpropCount > 0)
            {
                callPayload.Body = o365RemoveMailboxPermission;
            }

            return new ApiConnectionAction<O365RemoveMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse> O365AddDistributionGroupMember(Expression<Func<string>> o365AddDistributionGroupMemberidentity, Expression<Func<string>> o365AddDistributionGroupMembermember, Expression<Func<string>> o365AddDistributionGroupMemberworkflow, Expression<Func<bool>> o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365AddDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365AddDistributionGroupMember = new JObject();
            var o365AddDistributionGroupMemberpropCount = 0;
            o365AddDistributionGroupMemberpropCount++;
            o365AddDistributionGroupMember["Identity"] = CSharpExpressionConverter.ConvertToken(o365AddDistributionGroupMemberidentity);
            o365AddDistributionGroupMemberpropCount++;
            o365AddDistributionGroupMember["Member"] = CSharpExpressionConverter.ConvertToken(o365AddDistributionGroupMembermember);
            if (o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
            {
                if (o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    o365AddDistributionGroupMember["BypassSecurityGroupManagerCheck"] = CSharpExpressionConverter.ConvertToken(o365AddDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
            o365AddDistributionGroupMember["Workflow"] = CSharpExpressionConverter.ConvertToken(o365AddDistributionGroupMemberworkflow);
            if (o365AddDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = o365AddDistributionGroupMember;
            }

            return new ApiConnectionAction<O365AddDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse> O365GetO365DistributionGroup(Expression<Func<string>> o365GetO365DistributionGroupworkflow, Expression<Func<string>> o365GetO365DistributionGroupidentity = null, Expression<Func<string>> o365GetO365DistributionGroupfilterPropertyName = null, Expression<Func<o365GetO365DistributionGroupfilterPropertyComparisonInput>> o365GetO365DistributionGroupfilterPropertyComparison = null, Expression<Func<string>> o365GetO365DistributionGroupfilterPropertyValue = null, Expression<Func<bool>> o365GetO365DistributionGroupnoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetO365DistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetO365DistributionGroup = new JObject();
            var o365GetO365DistributionGrouppropCount = 0;
            if (o365GetO365DistributionGroupidentity != null)
            {
                o365GetO365DistributionGroup["Identity"] = CSharpExpressionConverter.ConvertToken(o365GetO365DistributionGroupidentity);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupfilterPropertyName != null)
            {
                o365GetO365DistributionGroup["FilterPropertyName"] = CSharpExpressionConverter.ConvertToken(o365GetO365DistributionGroupfilterPropertyName);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupfilterPropertyComparison != null)
            {
                if (o365GetO365DistributionGroupfilterPropertyComparison != null)
                {
                    o365GetO365DistributionGroup["FilterPropertyComparison"] = CSharpExpressionConverter.Convert(o365GetO365DistributionGroupfilterPropertyComparison);
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
                o365GetO365DistributionGroup["FilterPropertyValue"] = CSharpExpressionConverter.ConvertToken(o365GetO365DistributionGroupfilterPropertyValue);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupnoResultIsAnException != null)
            {
                if (o365GetO365DistributionGroupnoResultIsAnException != null)
                {
                    o365GetO365DistributionGroup["NoResultIsAnException"] = CSharpExpressionConverter.ConvertToken(o365GetO365DistributionGroupnoResultIsAnException);
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
            o365GetO365DistributionGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(o365GetO365DistributionGroupworkflow);
            if (o365GetO365DistributionGrouppropCount > 0)
            {
                callPayload.Body = o365GetO365DistributionGroup;
            }

            return new ApiConnectionAction<O365GetO365DistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse> O365NewO365DistributionGroup(Expression<Func<string>> o365NewO365DistributionGroupname, Expression<Func<string>> o365NewO365DistributionGroupworkflow, Expression<Func<string>> o365NewO365DistributionGroupalias = null, Expression<Func<string>> o365NewO365DistributionGroupdisplayName = null, Expression<Func<string>> o365NewO365DistributionGroupnotes = null, Expression<Func<string>> o365NewO365DistributionGroupmanagedBy = null, Expression<Func<string>> o365NewO365DistributionGroupmembers = null, Expression<Func<string>> o365NewO365DistributionGrouporganizationalUnit = null, Expression<Func<string>> o365NewO365DistributionGroupprimarySmtpAddress = null, Expression<Func<o365NewO365DistributionGroupmemberDepartRestrictionInput>> o365NewO365DistributionGroupmemberDepartRestriction = null, Expression<Func<o365NewO365DistributionGroupmemberJoinRestrictionInput>> o365NewO365DistributionGroupmemberJoinRestriction = null, Expression<Func<bool>> o365NewO365DistributionGrouprequireSenderAuthenticationEnabled = null, Expression<Func<o365NewO365DistributionGrouptypeInput>> o365NewO365DistributionGrouptype = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365NewO365DistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365NewO365DistributionGroup = new JObject();
            var o365NewO365DistributionGrouppropCount = 0;
            o365NewO365DistributionGrouppropCount++;
            o365NewO365DistributionGroup["Name"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupname);
            if (o365NewO365DistributionGroupalias != null)
            {
                o365NewO365DistributionGroup["Alias"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupalias);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupdisplayName != null)
            {
                o365NewO365DistributionGroup["DisplayName"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupdisplayName);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupnotes != null)
            {
                o365NewO365DistributionGroup["Notes"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupnotes);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupmanagedBy != null)
            {
                o365NewO365DistributionGroup["ManagedBy"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupmanagedBy);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupmembers != null)
            {
                o365NewO365DistributionGroup["Members"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupmembers);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGrouporganizationalUnit != null)
            {
                o365NewO365DistributionGroup["OrganizationalUnit"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGrouporganizationalUnit);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupprimarySmtpAddress != null)
            {
                o365NewO365DistributionGroup["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupprimarySmtpAddress);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupmemberDepartRestriction != null)
            {
                if (o365NewO365DistributionGroupmemberDepartRestriction != null)
                {
                    o365NewO365DistributionGroup["MemberDepartRestriction"] = CSharpExpressionConverter.Convert(o365NewO365DistributionGroupmemberDepartRestriction);
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
                    o365NewO365DistributionGroup["MemberJoinRestriction"] = CSharpExpressionConverter.Convert(o365NewO365DistributionGroupmemberJoinRestriction);
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
                    o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGrouprequireSenderAuthenticationEnabled);
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
                o365NewO365DistributionGroup["Type"] = CSharpExpressionConverter.Convert(o365NewO365DistributionGrouptype);
                o365NewO365DistributionGrouppropCount++;
            }

            o365NewO365DistributionGrouppropCount++;
            o365NewO365DistributionGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(o365NewO365DistributionGroupworkflow);
            if (o365NewO365DistributionGrouppropCount > 0)
            {
                callPayload.Body = o365NewO365DistributionGroup;
            }

            return new ApiConnectionAction<O365NewO365DistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse> O365RemoveDistributionGroup(Expression<Func<string>> o365RemoveDistributionGroupidentity, Expression<Func<string>> o365RemoveDistributionGroupworkflow, Expression<Func<bool>> o365RemoveDistributionGroupbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveDistributionGrouperrorIfGroupDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveDistributionGroup = new JObject();
            var o365RemoveDistributionGrouppropCount = 0;
            o365RemoveDistributionGrouppropCount++;
            o365RemoveDistributionGroup["Identity"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupidentity);
            if (o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
            {
                if (o365RemoveDistributionGroupbypassSecurityGroupManagerCheck != null)
                {
                    o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupbypassSecurityGroupManagerCheck);
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
                    o365RemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGrouperrorIfGroupDoesNotExist);
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
            o365RemoveDistributionGroup["Workflow"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupworkflow);
            if (o365RemoveDistributionGrouppropCount > 0)
            {
                callPayload.Body = o365RemoveDistributionGroup;
            }

            return new ApiConnectionAction<O365RemoveDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxResponse> O365SetO365Mailbox(Expression<Func<string>> o365SetO365Mailboxidentity, Expression<Func<string>> o365SetO365Mailboxworkflow, Expression<Func<bool>> o365SetO365MailboxaccountDisabled = null, Expression<Func<string>> o365SetO365Mailboxalias = null, Expression<Func<string>> o365SetO365MailboxdisplayName = null, Expression<Func<bool>> o365SetO365MailboxhiddenFromAddressListsEnabled = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute1 = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute2 = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute3 = null, Expression<Func<string>> o365SetO365MailboxcustomAttribute4 = null, Expression<Func<o365SetO365MailboxtypeInput>> o365SetO365Mailboxtype = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365SetO365Mailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365SetO365Mailbox = new JObject();
            var o365SetO365MailboxpropCount = 0;
            o365SetO365MailboxpropCount++;
            o365SetO365Mailbox["Identity"] = CSharpExpressionConverter.ConvertToken(o365SetO365Mailboxidentity);
            if (o365SetO365MailboxaccountDisabled != null)
            {
                o365SetO365Mailbox["AccountDisabled"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxaccountDisabled);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365Mailboxalias != null)
            {
                o365SetO365Mailbox["Alias"] = CSharpExpressionConverter.ConvertToken(o365SetO365Mailboxalias);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxdisplayName != null)
            {
                o365SetO365Mailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxdisplayName);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxhiddenFromAddressListsEnabled != null)
            {
                o365SetO365Mailbox["HiddenFromAddressListsEnabled"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxhiddenFromAddressListsEnabled);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxcustomAttribute1 != null)
            {
                o365SetO365Mailbox["CustomAttribute1"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute1);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxcustomAttribute2 != null)
            {
                o365SetO365Mailbox["CustomAttribute2"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute2);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxcustomAttribute3 != null)
            {
                o365SetO365Mailbox["CustomAttribute3"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute3);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxcustomAttribute4 != null)
            {
                o365SetO365Mailbox["CustomAttribute4"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxcustomAttribute4);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365Mailboxtype != null)
            {
                o365SetO365Mailbox["Type"] = CSharpExpressionConverter.Convert(o365SetO365Mailboxtype);
                o365SetO365MailboxpropCount++;
            }

            o365SetO365MailboxpropCount++;
            o365SetO365Mailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(o365SetO365Mailboxworkflow);
            if (o365SetO365MailboxpropCount > 0)
            {
                callPayload.Body = o365SetO365Mailbox;
            }

            return new ApiConnectionAction<O365SetO365MailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse> O365WaitForO365Mailbox(Expression<Func<string>> o365WaitForO365Mailboxidentity, Expression<Func<int>> o365WaitForO365MailboxnumberOfTimesToCheck, Expression<Func<int>> o365WaitForO365MailboxsecondsBetweenTries, Expression<Func<string>> o365WaitForO365Mailboxworkflow, Expression<Func<o365WaitForO365MailboxrecipientTypeDetailsInput>> o365WaitForO365MailboxrecipientTypeDetails = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365WaitForO365Mailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365WaitForO365Mailbox = new JObject();
            var o365WaitForO365MailboxpropCount = 0;
            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["Identity"] = CSharpExpressionConverter.ConvertToken(o365WaitForO365Mailboxidentity);
            if (o365WaitForO365MailboxrecipientTypeDetails != null)
            {
                o365WaitForO365Mailbox["RecipientTypeDetails"] = CSharpExpressionConverter.Convert(o365WaitForO365MailboxrecipientTypeDetails);
                o365WaitForO365MailboxpropCount++;
            }

            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["NumberOfTimesToCheck"] = CSharpExpressionConverter.ConvertToken(o365WaitForO365MailboxnumberOfTimesToCheck);
            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["SecondsBetweenTries"] = CSharpExpressionConverter.ConvertToken(o365WaitForO365MailboxsecondsBetweenTries);
            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(o365WaitForO365Mailboxworkflow);
            if (o365WaitForO365MailboxpropCount > 0)
            {
                callPayload.Body = o365WaitForO365Mailbox;
            }

            return new ApiConnectionAction<O365WaitForO365MailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse> O365SetO365MailboxAutoReplyConfiguration(Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationidentity, Expression<Func<o365SetO365MailboxAutoReplyConfigurationautoReplyStateInput>> o365SetO365MailboxAutoReplyConfigurationautoReplyState, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationworkflow, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationinternalMessage = null, Expression<Func<o365SetO365MailboxAutoReplyConfigurationexternalAudienceInput>> o365SetO365MailboxAutoReplyConfigurationexternalAudience = null, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationexternalMessage = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365SetO365MailboxAutoReplyConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365SetO365MailboxAutoReplyConfiguration = new JObject();
            var o365SetO365MailboxAutoReplyConfigurationpropCount = 0;
            o365SetO365MailboxAutoReplyConfigurationpropCount++;
            o365SetO365MailboxAutoReplyConfiguration["Identity"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationidentity);
            o365SetO365MailboxAutoReplyConfigurationpropCount++;
            o365SetO365MailboxAutoReplyConfiguration["AutoReplyState"] = CSharpExpressionConverter.Convert(o365SetO365MailboxAutoReplyConfigurationautoReplyState);
            if (o365SetO365MailboxAutoReplyConfigurationinternalMessage != null)
            {
                o365SetO365MailboxAutoReplyConfiguration["InternalMessage"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationinternalMessage);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
            }

            if (o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
            {
                if (o365SetO365MailboxAutoReplyConfigurationexternalAudience != null)
                {
                    o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = CSharpExpressionConverter.Convert(o365SetO365MailboxAutoReplyConfigurationexternalAudience);
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
                o365SetO365MailboxAutoReplyConfiguration["ExternalMessage"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationexternalMessage);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
            }

            o365SetO365MailboxAutoReplyConfigurationpropCount++;
            o365SetO365MailboxAutoReplyConfiguration["Workflow"] = CSharpExpressionConverter.ConvertToken(o365SetO365MailboxAutoReplyConfigurationworkflow);
            if (o365SetO365MailboxAutoReplyConfigurationpropCount > 0)
            {
                callPayload.Body = o365SetO365MailboxAutoReplyConfiguration;
            }

            return new ApiConnectionAction<O365SetO365MailboxAutoReplyConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse> O365RemoveDistributionGroupMember(Expression<Func<string>> o365RemoveDistributionGroupMembergroupIdentity, Expression<Func<string>> o365RemoveDistributionGroupMembermember, Expression<Func<string>> o365RemoveDistributionGroupMemberworkflow, Expression<Func<bool>> o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveDistributionGroupMember = new JObject();
            var o365RemoveDistributionGroupMemberpropCount = 0;
            o365RemoveDistributionGroupMemberpropCount++;
            o365RemoveDistributionGroupMember["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupMembergroupIdentity);
            o365RemoveDistributionGroupMemberpropCount++;
            o365RemoveDistributionGroupMember["Member"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupMembermember);
            if (o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
            {
                if (o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck != null)
                {
                    o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupMemberbypassSecurityGroupManagerCheck);
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
                    o365RemoveDistributionGroupMember["ExceptionIfMemberNotInGroup"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupMemberexceptionIfMemberNotInGroup);
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
            o365RemoveDistributionGroupMember["Workflow"] = CSharpExpressionConverter.ConvertToken(o365RemoveDistributionGroupMemberworkflow);
            if (o365RemoveDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = o365RemoveDistributionGroupMember;
            }

            return new ApiConnectionAction<O365RemoveDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse> O365GetMailboxDistributionGroupMembership(Expression<Func<string>> o365GetMailboxDistributionGroupMembershipmailboxIdentity, Expression<Func<string>> o365GetMailboxDistributionGroupMembershipworkflow, Expression<Func<string>> o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetMailboxDistributionGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetMailboxDistributionGroupMembership = new JObject();
            var o365GetMailboxDistributionGroupMembershippropCount = 0;
            o365GetMailboxDistributionGroupMembershippropCount++;
            o365GetMailboxDistributionGroupMembership["MailboxIdentity"] = CSharpExpressionConverter.ConvertToken(o365GetMailboxDistributionGroupMembershipmailboxIdentity);
            if (o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON != null)
            {
                o365GetMailboxDistributionGroupMembership["PropertiesToRetrieveJSON"] = CSharpExpressionConverter.ConvertToken(o365GetMailboxDistributionGroupMembershippropertiesToRetrieveJSON);
                o365GetMailboxDistributionGroupMembershippropCount++;
            }

            o365GetMailboxDistributionGroupMembershippropCount++;
            o365GetMailboxDistributionGroupMembership["Workflow"] = CSharpExpressionConverter.ConvertToken(o365GetMailboxDistributionGroupMembershipworkflow);
            if (o365GetMailboxDistributionGroupMembershippropCount > 0)
            {
                callPayload.Body = o365GetMailboxDistributionGroupMembership;
            }

            return new ApiConnectionAction<O365GetMailboxDistributionGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse> O365GetDistributionGroupMembers(Expression<Func<string>> o365GetDistributionGroupMembersgroupIdentity, Expression<Func<string>> o365GetDistributionGroupMembersworkflow, Expression<Func<string>> o365GetDistributionGroupMemberspropertiesToRetrieveJSON = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetDistributionGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetDistributionGroupMembers = new JObject();
            var o365GetDistributionGroupMemberspropCount = 0;
            o365GetDistributionGroupMemberspropCount++;
            o365GetDistributionGroupMembers["GroupIdentity"] = CSharpExpressionConverter.ConvertToken(o365GetDistributionGroupMembersgroupIdentity);
            if (o365GetDistributionGroupMemberspropertiesToRetrieveJSON != null)
            {
                o365GetDistributionGroupMembers["PropertiesToRetrieveJSON"] = CSharpExpressionConverter.ConvertToken(o365GetDistributionGroupMemberspropertiesToRetrieveJSON);
                o365GetDistributionGroupMemberspropCount++;
            }

            o365GetDistributionGroupMemberspropCount++;
            o365GetDistributionGroupMembers["Workflow"] = CSharpExpressionConverter.ConvertToken(o365GetDistributionGroupMembersworkflow);
            if (o365GetDistributionGroupMemberspropCount > 0)
            {
                callPayload.Body = o365GetDistributionGroupMembers;
            }

            return new ApiConnectionAction<O365GetDistributionGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse> O365RemoveMailboxFromAllDistributionGroups(Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsworkflow, Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove = null, Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsrunAsThread = null, Expression<Func<int>> o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId = null, Expression<Func<int>> o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxFromAllDistributionGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveMailboxFromAllDistributionGroups = new JObject();
            var o365RemoveMailboxFromAllDistributionGroupspropCount = 0;
            if (o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["MailboxIdentity"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsmailboxIdentity);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
            {
                if (o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsbypassSecurityGroupManagerCheck);
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
                    o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAnyGroupsFailToRemove);
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
                    o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsexceptionIfAllGroupsFailToRemove);
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
                o365RemoveMailboxFromAllDistributionGroups["GroupDNsToExcludeJSON"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsgroupDNsToExcludeJSON);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
            {
                if (o365RemoveMailboxFromAllDistributionGroupsrunAsThread != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsrunAsThread);
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
                o365RemoveMailboxFromAllDistributionGroups["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsretrieveOutputDataFromThreadId);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
            {
                if (o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread != null)
                {
                    o365RemoveMailboxFromAllDistributionGroups["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupssecondsToWaitForThread);
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
            o365RemoveMailboxFromAllDistributionGroups["Workflow"] = CSharpExpressionConverter.ConvertToken(o365RemoveMailboxFromAllDistributionGroupsworkflow);
            if (o365RemoveMailboxFromAllDistributionGroupspropCount > 0)
            {
                callPayload.Body = o365RemoveMailboxFromAllDistributionGroups;
            }

            return new ApiConnectionAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewMailboxResponse> O365NewMailbox(Expression<Func<string>> o365NewMailboxmicrosoftOnlineServicesID, Expression<Func<string>> o365NewMailboxname, Expression<Func<string>> o365NewMailboxworkflow, Expression<Func<string>> o365NewMailboxfirstName = null, Expression<Func<string>> o365NewMailboxlastName = null, Expression<Func<string>> o365NewMailboxinitials = null, Expression<Func<string>> o365NewMailboxdisplayName = null, Expression<Func<string>> o365NewMailboxalias = null, Expression<Func<string>> o365NewMailboxprimarySmtpAddress = null, Expression<Func<string>> o365NewMailboxpassword = null, Expression<Func<bool>> o365NewMailboxaccountPasswordIsStoredPassword = null, Expression<Func<bool>> o365NewMailboxresetPasswordOnNextLogon = null, Expression<Func<bool>> o365NewMailboxarchive = null, Expression<Func<string>> o365NewMailboxmailboxPlan = null, Expression<Func<string>> o365NewMailboxmailboxRegion = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365NewMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365NewMailbox = new JObject();
            var o365NewMailboxpropCount = 0;
            o365NewMailboxpropCount++;
            o365NewMailbox["MicrosoftOnlineServicesID"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxmicrosoftOnlineServicesID);
            o365NewMailboxpropCount++;
            o365NewMailbox["Name"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxname);
            if (o365NewMailboxfirstName != null)
            {
                o365NewMailbox["FirstName"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxfirstName);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxlastName != null)
            {
                o365NewMailbox["LastName"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxlastName);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxinitials != null)
            {
                o365NewMailbox["Initials"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxinitials);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxdisplayName != null)
            {
                o365NewMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxdisplayName);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxalias != null)
            {
                o365NewMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxalias);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxprimarySmtpAddress != null)
            {
                o365NewMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxprimarySmtpAddress);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxpassword != null)
            {
                o365NewMailbox["Password"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxpassword);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxaccountPasswordIsStoredPassword != null)
            {
                if (o365NewMailboxaccountPasswordIsStoredPassword != null)
                {
                    o365NewMailbox["AccountPasswordIsStoredPassword"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxaccountPasswordIsStoredPassword);
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
                    o365NewMailbox["ResetPasswordOnNextLogon"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxresetPasswordOnNextLogon);
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
                    o365NewMailbox["Archive"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxarchive);
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
                o365NewMailbox["MailboxPlan"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxmailboxPlan);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxmailboxRegion != null)
            {
                o365NewMailbox["MailboxRegion"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxmailboxRegion);
                o365NewMailboxpropCount++;
            }

            o365NewMailboxpropCount++;
            o365NewMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(o365NewMailboxworkflow);
            if (o365NewMailboxpropCount > 0)
            {
                callPayload.Body = o365NewMailbox;
            }

            return new ApiConnectionAction<O365NewMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse> O365NewSharedMailbox(Expression<Func<string>> o365NewSharedMailboxname, Expression<Func<string>> o365NewSharedMailboxworkflow, Expression<Func<string>> o365NewSharedMailboxfirstName = null, Expression<Func<string>> o365NewSharedMailboxlastName = null, Expression<Func<string>> o365NewSharedMailboxinitials = null, Expression<Func<string>> o365NewSharedMailboxdisplayName = null, Expression<Func<string>> o365NewSharedMailboxalias = null, Expression<Func<string>> o365NewSharedMailboxprimarySmtpAddress = null, Expression<Func<bool>> o365NewSharedMailboxarchive = null, Expression<Func<string>> o365NewSharedMailboxmailboxRegion = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365NewSharedMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365NewSharedMailbox = new JObject();
            var o365NewSharedMailboxpropCount = 0;
            o365NewSharedMailboxpropCount++;
            o365NewSharedMailbox["Name"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxname);
            if (o365NewSharedMailboxfirstName != null)
            {
                o365NewSharedMailbox["FirstName"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxfirstName);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxlastName != null)
            {
                o365NewSharedMailbox["LastName"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxlastName);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxinitials != null)
            {
                o365NewSharedMailbox["Initials"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxinitials);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxdisplayName != null)
            {
                o365NewSharedMailbox["DisplayName"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxdisplayName);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxalias != null)
            {
                o365NewSharedMailbox["Alias"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxalias);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxprimarySmtpAddress != null)
            {
                o365NewSharedMailbox["PrimarySmtpAddress"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxprimarySmtpAddress);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxarchive != null)
            {
                if (o365NewSharedMailboxarchive != null)
                {
                    o365NewSharedMailbox["Archive"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxarchive);
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
                o365NewSharedMailbox["MailboxRegion"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxmailboxRegion);
                o365NewSharedMailboxpropCount++;
            }

            o365NewSharedMailboxpropCount++;
            o365NewSharedMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(o365NewSharedMailboxworkflow);
            if (o365NewSharedMailboxpropCount > 0)
            {
                callPayload.Body = o365NewSharedMailbox;
            }

            return new ApiConnectionAction<O365NewSharedMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse> O365EnableArchiveMailbox(Expression<Func<string>> o365EnableArchiveMailboxidentity, Expression<Func<string>> o365EnableArchiveMailboxworkflow, Expression<Func<bool>> o365EnableArchiveMailboxcheckIfArchiveExists = null, Expression<Func<string>> o365EnableArchiveMailboxarchiveName = null, Expression<Func<bool>> o365EnableArchiveMailboxautoExpandingArchive = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365EnableArchiveMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365EnableArchiveMailbox = new JObject();
            var o365EnableArchiveMailboxpropCount = 0;
            o365EnableArchiveMailboxpropCount++;
            o365EnableArchiveMailbox["Identity"] = CSharpExpressionConverter.ConvertToken(o365EnableArchiveMailboxidentity);
            if (o365EnableArchiveMailboxcheckIfArchiveExists != null)
            {
                if (o365EnableArchiveMailboxcheckIfArchiveExists != null)
                {
                    o365EnableArchiveMailbox["CheckIfArchiveExists"] = CSharpExpressionConverter.ConvertToken(o365EnableArchiveMailboxcheckIfArchiveExists);
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
                o365EnableArchiveMailbox["ArchiveName"] = CSharpExpressionConverter.ConvertToken(o365EnableArchiveMailboxarchiveName);
                o365EnableArchiveMailboxpropCount++;
            }

            if (o365EnableArchiveMailboxautoExpandingArchive != null)
            {
                if (o365EnableArchiveMailboxautoExpandingArchive != null)
                {
                    o365EnableArchiveMailbox["AutoExpandingArchive"] = CSharpExpressionConverter.ConvertToken(o365EnableArchiveMailboxautoExpandingArchive);
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
            o365EnableArchiveMailbox["Workflow"] = CSharpExpressionConverter.ConvertToken(o365EnableArchiveMailboxworkflow);
            if (o365EnableArchiveMailboxpropCount > 0)
            {
                callPayload.Body = o365EnableArchiveMailbox;
            }

            return new ApiConnectionAction<O365EnableArchiveMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse> O365DoesMailboxHaveAnArchive(Expression<Func<string>> o365DoesMailboxHaveAnArchiveidentity, Expression<Func<string>> o365DoesMailboxHaveAnArchiveworkflow)
        {
            var apiCallPath = "/PowerShellAutomation/O365DoesMailboxHaveAnArchive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365DoesMailboxHaveAnArchive = new JObject();
            var o365DoesMailboxHaveAnArchivepropCount = 0;
            o365DoesMailboxHaveAnArchivepropCount++;
            o365DoesMailboxHaveAnArchive["Identity"] = CSharpExpressionConverter.ConvertToken(o365DoesMailboxHaveAnArchiveidentity);
            o365DoesMailboxHaveAnArchivepropCount++;
            o365DoesMailboxHaveAnArchive["Workflow"] = CSharpExpressionConverter.ConvertToken(o365DoesMailboxHaveAnArchiveworkflow);
            if (o365DoesMailboxHaveAnArchivepropCount > 0)
            {
                callPayload.Body = o365DoesMailboxHaveAnArchive;
            }

            return new ApiConnectionAction<O365DoesMailboxHaveAnArchiveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse> JMLGetNextAvailableAccountName(Expression<Func<string>> jMLGetNextAvailableAccountNameworkflow, Expression<Func<string>> jMLGetNextAvailableAccountNamefirstName = null, Expression<Func<string>> jMLGetNextAvailableAccountNamemiddleName = null, Expression<Func<string>> jMLGetNextAvailableAccountNamelastName = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldA = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldB = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldC = null, Expression<Func<string>> jMLGetNextAvailableAccountNamefieldD = null, Expression<Func<int>> jMLGetNextAvailableAccountNamevariableMStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNamevariableNStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNamevariableXStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNamemaxAttempts = null, Expression<Func<bool>> jMLGetNextAvailableAccountNamefallbackCausesRetest = null, Expression<Func<string>> jMLGetNextAvailableAccountNamenumbersNotToUse = null, Expression<Func<string>> jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs = null, Expression<Func<string>> jMLGetNextAvailableAccountNamesequenceA1 = null, Expression<Func<jMLGetNextAvailableAccountNamepropertiesToCheckListInputItem[]>> jMLGetNextAvailableAccountNamepropertiesToCheckList = null)
        {
            var apiCallPath = "/PowerShellAutomation/JMLGetNextAvailableAccountName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jMLGetNextAvailableAccountName = new JObject();
            var jMLGetNextAvailableAccountNamepropCount = 0;
            if (jMLGetNextAvailableAccountNamefirstName != null)
            {
                jMLGetNextAvailableAccountName["FirstName"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefirstName);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamemiddleName != null)
            {
                jMLGetNextAvailableAccountName["MiddleName"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamemiddleName);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamelastName != null)
            {
                jMLGetNextAvailableAccountName["LastName"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamelastName);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamefieldA != null)
            {
                jMLGetNextAvailableAccountName["FieldA"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldA);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamefieldB != null)
            {
                jMLGetNextAvailableAccountName["FieldB"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldB);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamefieldC != null)
            {
                jMLGetNextAvailableAccountName["FieldC"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldC);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamefieldD != null)
            {
                jMLGetNextAvailableAccountName["FieldD"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefieldD);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamevariableMStartValue != null)
            {
                if (jMLGetNextAvailableAccountNamevariableMStartValue != null)
                {
                    jMLGetNextAvailableAccountName["VariableMStartValue"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamevariableMStartValue);
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
                    jMLGetNextAvailableAccountName["VariableNStartValue"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamevariableNStartValue);
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
                    jMLGetNextAvailableAccountName["VariableXStartValue"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamevariableXStartValue);
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
                    jMLGetNextAvailableAccountName["MaxAttempts"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamemaxAttempts);
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
                    jMLGetNextAvailableAccountName["FallbackCausesRetest"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamefallbackCausesRetest);
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
                jMLGetNextAvailableAccountName["NumbersNotToUse"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamenumbersNotToUse);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs != null)
            {
                jMLGetNextAvailableAccountName["CharactersToRemoveFromInputs"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamecharactersToRemoveFromInputs);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
            {
                if (jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs != null)
                {
                    jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNameremoveDiacriticsFromInputs);
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
                    jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNameremoveNonAlphaNumericFromInputs);
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
                jMLGetNextAvailableAccountName["SequenceA1"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamesequenceA1);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamepropertiesToCheckList != null)
            {
                jMLGetNextAvailableAccountName["PropertiesToCheckList"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNamepropertiesToCheckList);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            jMLGetNextAvailableAccountNamepropCount++;
            jMLGetNextAvailableAccountName["Workflow"] = CSharpExpressionConverter.ConvertToken(jMLGetNextAvailableAccountNameworkflow);
            if (jMLGetNextAvailableAccountNamepropCount > 0)
            {
                callPayload.Body = jMLGetNextAvailableAccountName;
            }

            return new ApiConnectionAction<JMLGetNextAvailableAccountNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse> JMLConnectToJMLEnvironment(Expression<Func<string>> jMLConnectToJMLEnvironmentworkflow, Expression<Func<string>> jMLConnectToJMLEnvironmentfriendlyName = null, Expression<Func<bool>> jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected = null)
        {
            var apiCallPath = "/PowerShellAutomation/JMLConnectToJMLEnvironment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jMLConnectToJMLEnvironment = new JObject();
            var jMLConnectToJMLEnvironmentpropCount = 0;
            if (jMLConnectToJMLEnvironmentfriendlyName != null)
            {
                jMLConnectToJMLEnvironment["FriendlyName"] = CSharpExpressionConverter.ConvertToken(jMLConnectToJMLEnvironmentfriendlyName);
                jMLConnectToJMLEnvironmentpropCount++;
            }

            if (jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
            {
                if (jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected != null)
                {
                    jMLConnectToJMLEnvironment["OnlyConnectIfNotAlreadyConnected"] = CSharpExpressionConverter.ConvertToken(jMLConnectToJMLEnvironmentonlyConnectIfNotAlreadyConnected);
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
            jMLConnectToJMLEnvironment["Workflow"] = CSharpExpressionConverter.ConvertToken(jMLConnectToJMLEnvironmentworkflow);
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