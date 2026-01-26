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
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse> RunActiveDirectoryPowerShellAutomationScript(Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptWorkflow, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptPowerShellScriptContents = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptIsNoResultAnError = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptReturnComplexTypes = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptReturnBooleanAsBoolean = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptReturnNumericAsDecimal = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptReturnDateAsDate = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptPropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptRunScriptAsThread = null, Expression<Func<int>> runActiveDirectoryPowerShellAutomationScriptRetrieveOutputDataFromThreadId = null, Expression<Func<int>> runActiveDirectoryPowerShellAutomationScriptSecondsToWaitForThread = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptScriptContainsStoredPassword = null, Expression<Func<bool>> runActiveDirectoryPowerShellAutomationScriptLogVerboseOutput = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptPropertyNamesToSerializeJSON = null, Expression<Func<string>> runActiveDirectoryPowerShellAutomationScriptPropertyTypesToSerializeJSON = null, Expression<Func<runActiveDirectoryPowerShellAutomationScriptPowerShellCommandParametersInputItem[]>> runActiveDirectoryPowerShellAutomationScriptPowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunActiveDirectoryPowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runActiveDirectoryPowerShellAutomationScript = new JObject();
            var runActiveDirectoryPowerShellAutomationScriptpropCount = 0;
            if (runActiveDirectoryPowerShellAutomationScriptPowerShellScriptContents != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptPowerShellScriptContents);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptIsNoResultAnError != null)
            {
                runActiveDirectoryPowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptIsNoResultAnError);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptReturnComplexTypes != null)
            {
                runActiveDirectoryPowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptReturnComplexTypes);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptReturnBooleanAsBoolean != null)
            {
                runActiveDirectoryPowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptReturnBooleanAsBoolean);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptReturnNumericAsDecimal != null)
            {
                runActiveDirectoryPowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptReturnNumericAsDecimal);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptReturnDateAsDate != null)
            {
                runActiveDirectoryPowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptReturnDateAsDate);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptPropertiesToReturnAsCollectionJSON != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptPropertiesToReturnAsCollectionJSON);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptRunScriptAsThread != null)
            {
                runActiveDirectoryPowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptRunScriptAsThread);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptRetrieveOutputDataFromThreadId != null)
            {
                runActiveDirectoryPowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptRetrieveOutputDataFromThreadId);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptSecondsToWaitForThread != null)
            {
                runActiveDirectoryPowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptSecondsToWaitForThread);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptScriptContainsStoredPassword != null)
            {
                runActiveDirectoryPowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptScriptContainsStoredPassword);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptLogVerboseOutput != null)
            {
                runActiveDirectoryPowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptLogVerboseOutput);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptPropertyNamesToSerializeJSON != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptPropertyNamesToSerializeJSON);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptPropertyTypesToSerializeJSON != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptPropertyTypesToSerializeJSON);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            if (runActiveDirectoryPowerShellAutomationScriptPowerShellCommandParameters != null)
            {
                runActiveDirectoryPowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptPowerShellCommandParameters);
                runActiveDirectoryPowerShellAutomationScriptpropCount++;
            }

            runActiveDirectoryPowerShellAutomationScriptpropCount++;
            runActiveDirectoryPowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runActiveDirectoryPowerShellAutomationScriptWorkflow);
            if (runActiveDirectoryPowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runActiveDirectoryPowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse> OpenActiveDirectoryPowerShellRunspaceWithCredentials(Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsUsername, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsPassword, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsWorkflow, Expression<Func<string>> openActiveDirectoryPowerShellRunspaceWithCredentialsRemoteComputer = null, Expression<Func<bool>> openActiveDirectoryPowerShellRunspaceWithCredentialsUseSSL = null, Expression<Func<int>> openActiveDirectoryPowerShellRunspaceWithCredentialsAlternativeTCPPort = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenActiveDirectoryPowerShellRunspaceWithCredentials";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openActiveDirectoryPowerShellRunspaceWithCredentials = new JObject();
            var openActiveDirectoryPowerShellRunspaceWithCredentialspropCount = 0;
            openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            openActiveDirectoryPowerShellRunspaceWithCredentials["Username"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsUsername);
            openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            openActiveDirectoryPowerShellRunspaceWithCredentials["Password"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsPassword);
            if (openActiveDirectoryPowerShellRunspaceWithCredentialsRemoteComputer != null)
            {
                openActiveDirectoryPowerShellRunspaceWithCredentials["RemoteComputer"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsRemoteComputer);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            }

            if (openActiveDirectoryPowerShellRunspaceWithCredentialsUseSSL != null)
            {
                openActiveDirectoryPowerShellRunspaceWithCredentials["UseSSL"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsUseSSL);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            }

            if (openActiveDirectoryPowerShellRunspaceWithCredentialsAlternativeTCPPort != null)
            {
                openActiveDirectoryPowerShellRunspaceWithCredentials["AlternativeTCPPort"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsAlternativeTCPPort);
                openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            }

            openActiveDirectoryPowerShellRunspaceWithCredentialspropCount++;
            openActiveDirectoryPowerShellRunspaceWithCredentials["Workflow"] = ExpressionConverter.ConvertO(openActiveDirectoryPowerShellRunspaceWithCredentialsWorkflow);
            if (openActiveDirectoryPowerShellRunspaceWithCredentialspropCount > 0)
            {
                callPayload.Body = openActiveDirectoryPowerShellRunspaceWithCredentials;
            }

            return new ApiConnectionAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse> CloseActiveDirectoryPowerShellRunspace(Expression<Func<string>> closeActiveDirectoryPowerShellRunspaceWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/CloseActiveDirectoryPowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeActiveDirectoryPowerShellRunspace = new JObject();
            var closeActiveDirectoryPowerShellRunspacepropCount = 0;
            closeActiveDirectoryPowerShellRunspacepropCount++;
            closeActiveDirectoryPowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeActiveDirectoryPowerShellRunspaceWorkflow);
            if (closeActiveDirectoryPowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeActiveDirectoryPowerShellRunspace;
            }

            return new ApiConnectionAction<CloseActiveDirectoryPowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse> IsActiveDirectoryPowerShellRunspaceOpen(Expression<Func<string>> isActiveDirectoryPowerShellRunspaceOpenWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/IsActiveDirectoryPowerShellRunspaceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isActiveDirectoryPowerShellRunspaceOpen = new JObject();
            var isActiveDirectoryPowerShellRunspaceOpenpropCount = 0;
            isActiveDirectoryPowerShellRunspaceOpenpropCount++;
            isActiveDirectoryPowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isActiveDirectoryPowerShellRunspaceOpenWorkflow);
            if (isActiveDirectoryPowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isActiveDirectoryPowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse> OpenLocalPassthroughActiveDirectoryPowerShellRunspace(Expression<Func<string>> openLocalPassthroughActiveDirectoryPowerShellRunspaceWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/OpenLocalPassthroughActiveDirectoryPowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openLocalPassthroughActiveDirectoryPowerShellRunspace = new JObject();
            var openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount = 0;
            openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount++;
            openLocalPassthroughActiveDirectoryPowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openLocalPassthroughActiveDirectoryPowerShellRunspaceWorkflow);
            if (openLocalPassthroughActiveDirectoryPowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openLocalPassthroughActiveDirectoryPowerShellRunspace;
            }

            return new ApiConnectionAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse> ActiveDirectoryAddADUser(Expression<Func<string>> activeDirectoryAddADUserName, Expression<Func<string>> activeDirectoryAddADUserWorkflow, Expression<Func<string>> activeDirectoryAddADUserUserPrincipalName = null, Expression<Func<string>> activeDirectoryAddADUserSamAccountName = null, Expression<Func<string>> activeDirectoryAddADUserGivenName = null, Expression<Func<string>> activeDirectoryAddADUserSurName = null, Expression<Func<string>> activeDirectoryAddADUserPath = null, Expression<Func<string>> activeDirectoryAddADUserDescription = null, Expression<Func<string>> activeDirectoryAddADUserDisplayName = null, Expression<Func<string>> activeDirectoryAddADUserAccountPassword = null, Expression<Func<bool>> activeDirectoryAddADUserAccountPasswordIsStoredPassword = null, Expression<Func<bool>> activeDirectoryAddADUserEnabled = null, Expression<Func<bool>> activeDirectoryAddADUserChangePasswordAtLogon = null, Expression<Func<bool>> activeDirectoryAddADUserCannotChangePassword = null, Expression<Func<bool>> activeDirectoryAddADUserPasswordNeverExpires = null, Expression<Func<string>> activeDirectoryAddADUserADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADUser = new JObject();
            var activeDirectoryAddADUserpropCount = 0;
            activeDirectoryAddADUserpropCount++;
            activeDirectoryAddADUser["Name"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserName);
            if (activeDirectoryAddADUserUserPrincipalName != null)
            {
                activeDirectoryAddADUser["UserPrincipalName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserUserPrincipalName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserSamAccountName != null)
            {
                activeDirectoryAddADUser["SamAccountName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserSamAccountName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserGivenName != null)
            {
                activeDirectoryAddADUser["GivenName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserGivenName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserSurName != null)
            {
                activeDirectoryAddADUser["SurName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserSurName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserPath != null)
            {
                activeDirectoryAddADUser["Path"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserPath);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserDescription != null)
            {
                activeDirectoryAddADUser["Description"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserDescription);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserDisplayName != null)
            {
                activeDirectoryAddADUser["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserDisplayName);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserAccountPassword != null)
            {
                activeDirectoryAddADUser["AccountPassword"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserAccountPassword);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserAccountPasswordIsStoredPassword != null)
            {
                activeDirectoryAddADUser["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserAccountPasswordIsStoredPassword);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserEnabled != null)
            {
                activeDirectoryAddADUser["Enabled"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserEnabled);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserChangePasswordAtLogon != null)
            {
                activeDirectoryAddADUser["ChangePasswordAtLogon"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserChangePasswordAtLogon);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserCannotChangePassword != null)
            {
                activeDirectoryAddADUser["CannotChangePassword"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserCannotChangePassword);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserPasswordNeverExpires != null)
            {
                activeDirectoryAddADUser["PasswordNeverExpires"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserPasswordNeverExpires);
                activeDirectoryAddADUserpropCount++;
            }

            if (activeDirectoryAddADUserADServer != null)
            {
                activeDirectoryAddADUser["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserADServer);
                activeDirectoryAddADUserpropCount++;
            }

            activeDirectoryAddADUserpropCount++;
            activeDirectoryAddADUser["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserWorkflow);
            if (activeDirectoryAddADUserpropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADUser;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse> ActiveDirectoryGetADUserByIdentity(Expression<Func<string>> activeDirectoryGetADUserByIdentityWorkflow, Expression<Func<string>> activeDirectoryGetADUserByIdentityIdentity = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityFilterPropertyName = null, Expression<Func<activeDirectoryGetADUserByIdentityFilterPropertyComparisonInput>> activeDirectoryGetADUserByIdentityFilterPropertyComparison = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityFilterPropertyValue = null, Expression<Func<string>> activeDirectoryGetADUserByIdentitySearchOUBase = null, Expression<Func<bool>> activeDirectoryGetADUserByIdentitySearchOUBaseSubtree = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityProperties = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityADServer = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityPropertiesToReturnAsCollectionJSON = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityPropertyNamesToSerializeJSON = null, Expression<Func<string>> activeDirectoryGetADUserByIdentityPropertyTypesToSerializeJSON = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADUserByIdentity = new JObject();
            var activeDirectoryGetADUserByIdentitypropCount = 0;
            if (activeDirectoryGetADUserByIdentityIdentity != null)
            {
                activeDirectoryGetADUserByIdentity["Identity"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityIdentity);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityFilterPropertyName != null)
            {
                activeDirectoryGetADUserByIdentity["FilterPropertyName"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityFilterPropertyName);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityFilterPropertyComparison != null)
            {
                activeDirectoryGetADUserByIdentity["FilterPropertyComparison"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityFilterPropertyComparison);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityFilterPropertyValue != null)
            {
                activeDirectoryGetADUserByIdentity["FilterPropertyValue"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityFilterPropertyValue);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitySearchOUBase != null)
            {
                activeDirectoryGetADUserByIdentity["SearchOUBase"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitySearchOUBase);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentitySearchOUBaseSubtree != null)
            {
                activeDirectoryGetADUserByIdentity["SearchOUBaseSubtree"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentitySearchOUBaseSubtree);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityProperties != null)
            {
                activeDirectoryGetADUserByIdentity["Properties"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityProperties);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityADServer != null)
            {
                activeDirectoryGetADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityADServer);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityPropertiesToReturnAsCollectionJSON != null)
            {
                activeDirectoryGetADUserByIdentity["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityPropertiesToReturnAsCollectionJSON);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityPropertyNamesToSerializeJSON != null)
            {
                activeDirectoryGetADUserByIdentity["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityPropertyNamesToSerializeJSON);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            if (activeDirectoryGetADUserByIdentityPropertyTypesToSerializeJSON != null)
            {
                activeDirectoryGetADUserByIdentity["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityPropertyTypesToSerializeJSON);
                activeDirectoryGetADUserByIdentitypropCount++;
            }

            activeDirectoryGetADUserByIdentitypropCount++;
            activeDirectoryGetADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserByIdentityWorkflow);
            if (activeDirectoryGetADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse> ActiveDirectoryGetOUFromUserDN(Expression<Func<string>> activeDirectoryGetOUFromUserDNUserDN, Expression<Func<string>> activeDirectoryGetOUFromUserDNWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetOUFromUserDN";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetOUFromUserDN = new JObject();
            var activeDirectoryGetOUFromUserDNpropCount = 0;
            activeDirectoryGetOUFromUserDNpropCount++;
            activeDirectoryGetOUFromUserDN["UserDN"] = ExpressionConverter.ConvertO(activeDirectoryGetOUFromUserDNUserDN);
            activeDirectoryGetOUFromUserDNpropCount++;
            activeDirectoryGetOUFromUserDN["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetOUFromUserDNWorkflow);
            if (activeDirectoryGetOUFromUserDNpropCount > 0)
            {
                callPayload.Body = activeDirectoryGetOUFromUserDN;
            }

            return new ApiConnectionAction<ActiveDirectoryGetOUFromUserDNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse> ActiveDirectoryGetDomainFQDNFromDN(Expression<Func<string>> activeDirectoryGetDomainFQDNFromDNDN, Expression<Func<string>> activeDirectoryGetDomainFQDNFromDNWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainFQDNFromDN";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetDomainFQDNFromDN = new JObject();
            var activeDirectoryGetDomainFQDNFromDNpropCount = 0;
            activeDirectoryGetDomainFQDNFromDNpropCount++;
            activeDirectoryGetDomainFQDNFromDN["DN"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainFQDNFromDNDN);
            activeDirectoryGetDomainFQDNFromDNpropCount++;
            activeDirectoryGetDomainFQDNFromDN["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainFQDNFromDNWorkflow);
            if (activeDirectoryGetDomainFQDNFromDNpropCount > 0)
            {
                callPayload.Body = activeDirectoryGetDomainFQDNFromDN;
            }

            return new ApiConnectionAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse> ActiveDirectoryGetADGroupByIdentity(Expression<Func<string>> activeDirectoryGetADGroupByIdentityWorkflow, Expression<Func<string>> activeDirectoryGetADGroupByIdentityIdentity = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityFilterPropertyName = null, Expression<Func<activeDirectoryGetADGroupByIdentityFilterPropertyComparisonInput>> activeDirectoryGetADGroupByIdentityFilterPropertyComparison = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityFilterPropertyValue = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentitySearchOUBase = null, Expression<Func<bool>> activeDirectoryGetADGroupByIdentitySearchOUBaseSubtree = null, Expression<Func<bool>> activeDirectoryGetADGroupByIdentityRaiseExceptionIfGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryGetADGroupByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADGroupByIdentity = new JObject();
            var activeDirectoryGetADGroupByIdentitypropCount = 0;
            if (activeDirectoryGetADGroupByIdentityIdentity != null)
            {
                activeDirectoryGetADGroupByIdentity["Identity"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityIdentity);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityFilterPropertyName != null)
            {
                activeDirectoryGetADGroupByIdentity["FilterPropertyName"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityFilterPropertyName);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityFilterPropertyComparison != null)
            {
                activeDirectoryGetADGroupByIdentity["FilterPropertyComparison"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityFilterPropertyComparison);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityFilterPropertyValue != null)
            {
                activeDirectoryGetADGroupByIdentity["FilterPropertyValue"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityFilterPropertyValue);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentitySearchOUBase != null)
            {
                activeDirectoryGetADGroupByIdentity["SearchOUBase"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentitySearchOUBase);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentitySearchOUBaseSubtree != null)
            {
                activeDirectoryGetADGroupByIdentity["SearchOUBaseSubtree"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentitySearchOUBaseSubtree);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityRaiseExceptionIfGroupDoesNotExist != null)
            {
                activeDirectoryGetADGroupByIdentity["RaiseExceptionIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityRaiseExceptionIfGroupDoesNotExist);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            if (activeDirectoryGetADGroupByIdentityADServer != null)
            {
                activeDirectoryGetADGroupByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityADServer);
                activeDirectoryGetADGroupByIdentitypropCount++;
            }

            activeDirectoryGetADGroupByIdentitypropCount++;
            activeDirectoryGetADGroupByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupByIdentityWorkflow);
            if (activeDirectoryGetADGroupByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADGroupByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADGroupByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse> ActiveDirectoryAddADGroupMemberByIdentity(Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityUserIdentity, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityWorkflow, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityGroupIdentity = null, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityGroupName = null, Expression<Func<string>> activeDirectoryAddADGroupMemberByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroupMemberByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADGroupMemberByIdentity = new JObject();
            var activeDirectoryAddADGroupMemberByIdentitypropCount = 0;
            if (activeDirectoryAddADGroupMemberByIdentityGroupIdentity != null)
            {
                activeDirectoryAddADGroupMemberByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityGroupIdentity);
                activeDirectoryAddADGroupMemberByIdentitypropCount++;
            }

            if (activeDirectoryAddADGroupMemberByIdentityGroupName != null)
            {
                activeDirectoryAddADGroupMemberByIdentity["GroupName"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityGroupName);
                activeDirectoryAddADGroupMemberByIdentitypropCount++;
            }

            activeDirectoryAddADGroupMemberByIdentitypropCount++;
            activeDirectoryAddADGroupMemberByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityUserIdentity);
            if (activeDirectoryAddADGroupMemberByIdentityADServer != null)
            {
                activeDirectoryAddADGroupMemberByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityADServer);
                activeDirectoryAddADGroupMemberByIdentitypropCount++;
            }

            activeDirectoryAddADGroupMemberByIdentitypropCount++;
            activeDirectoryAddADGroupMemberByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupMemberByIdentityWorkflow);
            if (activeDirectoryAddADGroupMemberByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADGroupMemberByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse> ActiveDirectoryAddMultipleADGroupMembersByIdentity(Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityWorkflow, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityGroupIdentity = null, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityGroupMembersJSON = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityExceptionIfAnyMembersFailToAdd = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityExceptionIfAllMembersFailToAdd = null, Expression<Func<bool>> activeDirectoryAddMultipleADGroupMembersByIdentityAddAllMembersInASingleCall = null, Expression<Func<string>> activeDirectoryAddMultipleADGroupMembersByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddMultipleADGroupMembersByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddMultipleADGroupMembersByIdentity = new JObject();
            var activeDirectoryAddMultipleADGroupMembersByIdentitypropCount = 0;
            if (activeDirectoryAddMultipleADGroupMembersByIdentityGroupIdentity != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityGroupIdentity);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentityGroupMembersJSON != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["GroupMembersJSON"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityGroupMembersJSON);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentityExceptionIfAnyMembersFailToAdd != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityExceptionIfAnyMembersFailToAdd);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentityExceptionIfAllMembersFailToAdd != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityExceptionIfAllMembersFailToAdd);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentityAddAllMembersInASingleCall != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["AddAllMembersInASingleCall"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityAddAllMembersInASingleCall);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryAddMultipleADGroupMembersByIdentityADServer != null)
            {
                activeDirectoryAddMultipleADGroupMembersByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityADServer);
                activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            }

            activeDirectoryAddMultipleADGroupMembersByIdentitypropCount++;
            activeDirectoryAddMultipleADGroupMembersByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddMultipleADGroupMembersByIdentityWorkflow);
            if (activeDirectoryAddMultipleADGroupMembersByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryAddMultipleADGroupMembersByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse> ActiveDirectoryAddADUserToMultipleADGroupsByName(Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameUserIdentity, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameWorkflow, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameGroupNamesJSON = null, Expression<Func<bool>> activeDirectoryAddADUserToMultipleADGroupsByNameExceptionIfAnyGroupsFailToAdd = null, Expression<Func<bool>> activeDirectoryAddADUserToMultipleADGroupsByNameExceptionIfAllGroupsFailToAdd = null, Expression<Func<string>> activeDirectoryAddADUserToMultipleADGroupsByNameADServer = null, Expression<Func<int>> activeDirectoryAddADUserToMultipleADGroupsByNameMaxGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUserToMultipleADGroupsByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADUserToMultipleADGroupsByName = new JObject();
            var activeDirectoryAddADUserToMultipleADGroupsByNamepropCount = 0;
            activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            activeDirectoryAddADUserToMultipleADGroupsByName["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameUserIdentity);
            if (activeDirectoryAddADUserToMultipleADGroupsByNameGroupNamesJSON != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["GroupNamesJSON"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameGroupNamesJSON);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryAddADUserToMultipleADGroupsByNameExceptionIfAnyGroupsFailToAdd != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAnyGroupsFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameExceptionIfAnyGroupsFailToAdd);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryAddADUserToMultipleADGroupsByNameExceptionIfAllGroupsFailToAdd != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["ExceptionIfAllGroupsFailToAdd"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameExceptionIfAllGroupsFailToAdd);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryAddADUserToMultipleADGroupsByNameADServer != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameADServer);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryAddADUserToMultipleADGroupsByNameMaxGroupsPerCall != null)
            {
                activeDirectoryAddADUserToMultipleADGroupsByName["MaxGroupsPerCall"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameMaxGroupsPerCall);
                activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            }

            activeDirectoryAddADUserToMultipleADGroupsByNamepropCount++;
            activeDirectoryAddADUserToMultipleADGroupsByName["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADUserToMultipleADGroupsByNameWorkflow);
            if (activeDirectoryAddADUserToMultipleADGroupsByNamepropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADUserToMultipleADGroupsByName;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse> ActiveDirectoryGetADUserGroupMembership(Expression<Func<string>> activeDirectoryGetADUserGroupMembershipUserIdentity, Expression<Func<string>> activeDirectoryGetADUserGroupMembershipWorkflow, Expression<Func<string>> activeDirectoryGetADUserGroupMembershipADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADUserGroupMembership = new JObject();
            var activeDirectoryGetADUserGroupMembershippropCount = 0;
            activeDirectoryGetADUserGroupMembershippropCount++;
            activeDirectoryGetADUserGroupMembership["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserGroupMembershipUserIdentity);
            if (activeDirectoryGetADUserGroupMembershipADServer != null)
            {
                activeDirectoryGetADUserGroupMembership["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserGroupMembershipADServer);
                activeDirectoryGetADUserGroupMembershippropCount++;
            }

            activeDirectoryGetADUserGroupMembershippropCount++;
            activeDirectoryGetADUserGroupMembership["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADUserGroupMembershipWorkflow);
            if (activeDirectoryGetADUserGroupMembershippropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADUserGroupMembership;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADUserGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse> ActiveDirectoryModifyADUserStringPropertyByIdentity(Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityUserIdentity, Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityWorkflow, Expression<Func<activeDirectoryModifyADUserStringPropertyByIdentityPropertiesListInputItem[]>> activeDirectoryModifyADUserStringPropertyByIdentityPropertiesList = null, Expression<Func<string>> activeDirectoryModifyADUserStringPropertyByIdentityADServer = null, Expression<Func<bool>> activeDirectoryModifyADUserStringPropertyByIdentityReplaceValue = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserStringPropertyByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryModifyADUserStringPropertyByIdentity = new JObject();
            var activeDirectoryModifyADUserStringPropertyByIdentitypropCount = 0;
            activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserStringPropertyByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityUserIdentity);
            if (activeDirectoryModifyADUserStringPropertyByIdentityPropertiesList != null)
            {
                activeDirectoryModifyADUserStringPropertyByIdentity["PropertiesList"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityPropertiesList);
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            }

            if (activeDirectoryModifyADUserStringPropertyByIdentityADServer != null)
            {
                activeDirectoryModifyADUserStringPropertyByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityADServer);
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            }

            if (activeDirectoryModifyADUserStringPropertyByIdentityReplaceValue != null)
            {
                activeDirectoryModifyADUserStringPropertyByIdentity["ReplaceValue"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityReplaceValue);
                activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            }

            activeDirectoryModifyADUserStringPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserStringPropertyByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserStringPropertyByIdentityWorkflow);
            if (activeDirectoryModifyADUserStringPropertyByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryModifyADUserStringPropertyByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse> ActiveDirectoryModifyADUserBooleanPropertyByIdentity(Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityUserIdentity, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityPropertyName, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityWorkflow, Expression<Func<bool>> activeDirectoryModifyADUserBooleanPropertyByIdentityPropertyValue = null, Expression<Func<string>> activeDirectoryModifyADUserBooleanPropertyByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserBooleanPropertyByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryModifyADUserBooleanPropertyByIdentity = new JObject();
            var activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount = 0;
            activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserBooleanPropertyByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityUserIdentity);
            activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyName"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityPropertyName);
            if (activeDirectoryModifyADUserBooleanPropertyByIdentityPropertyValue != null)
            {
                activeDirectoryModifyADUserBooleanPropertyByIdentity["PropertyValue"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityPropertyValue);
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            }

            if (activeDirectoryModifyADUserBooleanPropertyByIdentityADServer != null)
            {
                activeDirectoryModifyADUserBooleanPropertyByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityADServer);
                activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            }

            activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount++;
            activeDirectoryModifyADUserBooleanPropertyByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserBooleanPropertyByIdentityWorkflow);
            if (activeDirectoryModifyADUserBooleanPropertyByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryModifyADUserBooleanPropertyByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse> ActiveDirectoryModifyADUserProperties(Expression<Func<string>> activeDirectoryModifyADUserPropertiesUserIdentity, Expression<Func<string>> activeDirectoryModifyADUserPropertiesWorkflow, Expression<Func<string>> activeDirectoryModifyADUserPropertiesCity = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesCompany = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesCountry = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesCountryString = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesCountryISO3166 = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesDepartment = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesDescription = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesDisplayName = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesEmailAddress = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesGivenName = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesHomePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesInitials = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesIPPhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesManager = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesMobilePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesNotes = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesOffice = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesOfficePhone = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesPostalCode = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesProfilePath = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesScriptPath = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesState = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesStreetAddress = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesSurname = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesTitle = null, Expression<Func<string>> activeDirectoryModifyADUserPropertiesADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryModifyADUserProperties = new JObject();
            var activeDirectoryModifyADUserPropertiespropCount = 0;
            activeDirectoryModifyADUserPropertiespropCount++;
            activeDirectoryModifyADUserProperties["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesUserIdentity);
            if (activeDirectoryModifyADUserPropertiesCity != null)
            {
                activeDirectoryModifyADUserProperties["City"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesCity);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesCompany != null)
            {
                activeDirectoryModifyADUserProperties["Company"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesCompany);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesCountry != null)
            {
                activeDirectoryModifyADUserProperties["Country"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesCountry);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesCountryString != null)
            {
                activeDirectoryModifyADUserProperties["CountryString"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesCountryString);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesCountryISO3166 != null)
            {
                activeDirectoryModifyADUserProperties["CountryISO3166"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesCountryISO3166);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesDepartment != null)
            {
                activeDirectoryModifyADUserProperties["Department"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesDepartment);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesDescription != null)
            {
                activeDirectoryModifyADUserProperties["Description"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesDescription);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesDisplayName != null)
            {
                activeDirectoryModifyADUserProperties["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesDisplayName);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesEmailAddress != null)
            {
                activeDirectoryModifyADUserProperties["EmailAddress"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesEmailAddress);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesGivenName != null)
            {
                activeDirectoryModifyADUserProperties["GivenName"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesGivenName);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesHomePhone != null)
            {
                activeDirectoryModifyADUserProperties["HomePhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesHomePhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesInitials != null)
            {
                activeDirectoryModifyADUserProperties["Initials"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesInitials);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesIPPhone != null)
            {
                activeDirectoryModifyADUserProperties["IPPhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesIPPhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesManager != null)
            {
                activeDirectoryModifyADUserProperties["Manager"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesManager);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesMobilePhone != null)
            {
                activeDirectoryModifyADUserProperties["MobilePhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesMobilePhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesNotes != null)
            {
                activeDirectoryModifyADUserProperties["Notes"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesNotes);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesOffice != null)
            {
                activeDirectoryModifyADUserProperties["Office"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesOffice);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesOfficePhone != null)
            {
                activeDirectoryModifyADUserProperties["OfficePhone"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesOfficePhone);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesPostalCode != null)
            {
                activeDirectoryModifyADUserProperties["PostalCode"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesPostalCode);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesProfilePath != null)
            {
                activeDirectoryModifyADUserProperties["ProfilePath"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesProfilePath);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesScriptPath != null)
            {
                activeDirectoryModifyADUserProperties["ScriptPath"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesScriptPath);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesState != null)
            {
                activeDirectoryModifyADUserProperties["State"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesState);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesStreetAddress != null)
            {
                activeDirectoryModifyADUserProperties["StreetAddress"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesStreetAddress);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesSurname != null)
            {
                activeDirectoryModifyADUserProperties["Surname"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesSurname);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesTitle != null)
            {
                activeDirectoryModifyADUserProperties["Title"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesTitle);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            if (activeDirectoryModifyADUserPropertiesADServer != null)
            {
                activeDirectoryModifyADUserProperties["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesADServer);
                activeDirectoryModifyADUserPropertiespropCount++;
            }

            activeDirectoryModifyADUserPropertiespropCount++;
            activeDirectoryModifyADUserProperties["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryModifyADUserPropertiesWorkflow);
            if (activeDirectoryModifyADUserPropertiespropCount > 0)
            {
                callPayload.Body = activeDirectoryModifyADUserProperties;
            }

            return new ApiConnectionAction<ActiveDirectoryModifyADUserPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse> ActiveDirectoryMoveADUserToOUByIdentity(Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityUserIdentity, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityTargetPath, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityWorkflow, Expression<Func<string>> activeDirectoryMoveADUserToOUByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryMoveADUserToOUByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryMoveADUserToOUByIdentity = new JObject();
            var activeDirectoryMoveADUserToOUByIdentitypropCount = 0;
            activeDirectoryMoveADUserToOUByIdentitypropCount++;
            activeDirectoryMoveADUserToOUByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityUserIdentity);
            activeDirectoryMoveADUserToOUByIdentitypropCount++;
            activeDirectoryMoveADUserToOUByIdentity["TargetPath"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityTargetPath);
            if (activeDirectoryMoveADUserToOUByIdentityADServer != null)
            {
                activeDirectoryMoveADUserToOUByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityADServer);
                activeDirectoryMoveADUserToOUByIdentitypropCount++;
            }

            activeDirectoryMoveADUserToOUByIdentitypropCount++;
            activeDirectoryMoveADUserToOUByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryMoveADUserToOUByIdentityWorkflow);
            if (activeDirectoryMoveADUserToOUByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryMoveADUserToOUByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse> ActiveDirectoryClearADUserAccountExpiration(Expression<Func<string>> activeDirectoryClearADUserAccountExpirationUserIdentity, Expression<Func<string>> activeDirectoryClearADUserAccountExpirationWorkflow, Expression<Func<string>> activeDirectoryClearADUserAccountExpirationADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryClearADUserAccountExpiration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryClearADUserAccountExpiration = new JObject();
            var activeDirectoryClearADUserAccountExpirationpropCount = 0;
            activeDirectoryClearADUserAccountExpirationpropCount++;
            activeDirectoryClearADUserAccountExpiration["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryClearADUserAccountExpirationUserIdentity);
            if (activeDirectoryClearADUserAccountExpirationADServer != null)
            {
                activeDirectoryClearADUserAccountExpiration["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryClearADUserAccountExpirationADServer);
                activeDirectoryClearADUserAccountExpirationpropCount++;
            }

            activeDirectoryClearADUserAccountExpirationpropCount++;
            activeDirectoryClearADUserAccountExpiration["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryClearADUserAccountExpirationWorkflow);
            if (activeDirectoryClearADUserAccountExpirationpropCount > 0)
            {
                callPayload.Body = activeDirectoryClearADUserAccountExpiration;
            }

            return new ApiConnectionAction<ActiveDirectoryClearADUserAccountExpirationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse> ActiveDirectoryDirSync(Expression<Func<string>> activeDirectoryDirSyncWorkflow, Expression<Func<activeDirectoryDirSyncPolicyTypeInput>> activeDirectoryDirSyncPolicyType = null, Expression<Func<string>> activeDirectoryDirSyncComputerName = null, Expression<Func<int>> activeDirectoryDirSyncMaxRetryAttempts = null, Expression<Func<int>> activeDirectoryDirSyncSecondsBetweenRetries = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDirSync";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryDirSync = new JObject();
            var activeDirectoryDirSyncpropCount = 0;
            if (activeDirectoryDirSyncPolicyType != null)
            {
                activeDirectoryDirSync["PolicyType"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncPolicyType);
                activeDirectoryDirSyncpropCount++;
            }

            if (activeDirectoryDirSyncComputerName != null)
            {
                activeDirectoryDirSync["ComputerName"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncComputerName);
                activeDirectoryDirSyncpropCount++;
            }

            if (activeDirectoryDirSyncMaxRetryAttempts != null)
            {
                activeDirectoryDirSync["MaxRetryAttempts"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncMaxRetryAttempts);
                activeDirectoryDirSyncpropCount++;
            }

            if (activeDirectoryDirSyncSecondsBetweenRetries != null)
            {
                activeDirectoryDirSync["SecondsBetweenRetries"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncSecondsBetweenRetries);
                activeDirectoryDirSyncpropCount++;
            }

            activeDirectoryDirSyncpropCount++;
            activeDirectoryDirSync["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryDirSyncWorkflow);
            if (activeDirectoryDirSyncpropCount > 0)
            {
                callPayload.Body = activeDirectoryDirSync;
            }

            return new ApiConnectionAction<ActiveDirectoryDirSyncResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse> ActiveDirectoryRemoveADUserByIdentity(Expression<Func<string>> activeDirectoryRemoveADUserByIdentityUserIdentity, Expression<Func<string>> activeDirectoryRemoveADUserByIdentityWorkflow, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityRemoveProtectionFromAccidentalDeletion = null, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityDeleteEvenIfUserHasSubObjects = null, Expression<Func<bool>> activeDirectoryRemoveADUserByIdentityForceDeleteRecursive = null, Expression<Func<string>> activeDirectoryRemoveADUserByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADUserByIdentity = new JObject();
            var activeDirectoryRemoveADUserByIdentitypropCount = 0;
            activeDirectoryRemoveADUserByIdentitypropCount++;
            activeDirectoryRemoveADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityUserIdentity);
            if (activeDirectoryRemoveADUserByIdentityRemoveProtectionFromAccidentalDeletion != null)
            {
                activeDirectoryRemoveADUserByIdentity["RemoveProtectionFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityRemoveProtectionFromAccidentalDeletion);
                activeDirectoryRemoveADUserByIdentitypropCount++;
            }

            if (activeDirectoryRemoveADUserByIdentityDeleteEvenIfUserHasSubObjects != null)
            {
                activeDirectoryRemoveADUserByIdentity["DeleteEvenIfUserHasSubObjects"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityDeleteEvenIfUserHasSubObjects);
                activeDirectoryRemoveADUserByIdentitypropCount++;
            }

            if (activeDirectoryRemoveADUserByIdentityForceDeleteRecursive != null)
            {
                activeDirectoryRemoveADUserByIdentity["ForceDeleteRecursive"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityForceDeleteRecursive);
                activeDirectoryRemoveADUserByIdentitypropCount++;
            }

            if (activeDirectoryRemoveADUserByIdentityADServer != null)
            {
                activeDirectoryRemoveADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityADServer);
                activeDirectoryRemoveADUserByIdentitypropCount++;
            }

            activeDirectoryRemoveADUserByIdentitypropCount++;
            activeDirectoryRemoveADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserByIdentityWorkflow);
            if (activeDirectoryRemoveADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse> ActiveDirectoryResetADUserPasswordByIdentity(Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityUserIdentity, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityNewPassword, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityWorkflow, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityAccountPasswordIsStoredPassword = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentitySetUserPasswordProperties = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityChangePasswordAtLogon = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityCannotChangePassword = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityPasswordNeverExpires = null, Expression<Func<bool>> activeDirectoryResetADUserPasswordByIdentityResetPasswordTwice = null, Expression<Func<string>> activeDirectoryResetADUserPasswordByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryResetADUserPasswordByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryResetADUserPasswordByIdentity = new JObject();
            var activeDirectoryResetADUserPasswordByIdentitypropCount = 0;
            activeDirectoryResetADUserPasswordByIdentitypropCount++;
            activeDirectoryResetADUserPasswordByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityUserIdentity);
            activeDirectoryResetADUserPasswordByIdentitypropCount++;
            activeDirectoryResetADUserPasswordByIdentity["NewPassword"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityNewPassword);
            if (activeDirectoryResetADUserPasswordByIdentityAccountPasswordIsStoredPassword != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityAccountPasswordIsStoredPassword);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            if (activeDirectoryResetADUserPasswordByIdentitySetUserPasswordProperties != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["SetUserPasswordProperties"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentitySetUserPasswordProperties);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            if (activeDirectoryResetADUserPasswordByIdentityChangePasswordAtLogon != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["ChangePasswordAtLogon"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityChangePasswordAtLogon);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            if (activeDirectoryResetADUserPasswordByIdentityCannotChangePassword != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["CannotChangePassword"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityCannotChangePassword);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            if (activeDirectoryResetADUserPasswordByIdentityPasswordNeverExpires != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["PasswordNeverExpires"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityPasswordNeverExpires);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            if (activeDirectoryResetADUserPasswordByIdentityResetPasswordTwice != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["ResetPasswordTwice"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityResetPasswordTwice);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            if (activeDirectoryResetADUserPasswordByIdentityADServer != null)
            {
                activeDirectoryResetADUserPasswordByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityADServer);
                activeDirectoryResetADUserPasswordByIdentitypropCount++;
            }

            activeDirectoryResetADUserPasswordByIdentitypropCount++;
            activeDirectoryResetADUserPasswordByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryResetADUserPasswordByIdentityWorkflow);
            if (activeDirectoryResetADUserPasswordByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryResetADUserPasswordByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity(Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityUserIdentity, Expression<Func<bool>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityProtectedFromAccidentalDeletion, Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityWorkflow, Expression<Func<string>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity = new JObject();
            var activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount = 0;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityUserIdentity);
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityProtectedFromAccidentalDeletion);
            if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityADServer != null)
            {
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityADServer);
                activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            }

            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount++;
            activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentityWorkflow);
            if (activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse> ActiveDirectoryDisableADUserByIdentity(Expression<Func<string>> activeDirectoryDisableADUserByIdentityUserIdentity, Expression<Func<string>> activeDirectoryDisableADUserByIdentityWorkflow, Expression<Func<string>> activeDirectoryDisableADUserByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDisableADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryDisableADUserByIdentity = new JObject();
            var activeDirectoryDisableADUserByIdentitypropCount = 0;
            activeDirectoryDisableADUserByIdentitypropCount++;
            activeDirectoryDisableADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryDisableADUserByIdentityUserIdentity);
            if (activeDirectoryDisableADUserByIdentityADServer != null)
            {
                activeDirectoryDisableADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryDisableADUserByIdentityADServer);
                activeDirectoryDisableADUserByIdentitypropCount++;
            }

            activeDirectoryDisableADUserByIdentitypropCount++;
            activeDirectoryDisableADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryDisableADUserByIdentityWorkflow);
            if (activeDirectoryDisableADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryDisableADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryDisableADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse> ActiveDirectoryEnableADUserByIdentity(Expression<Func<string>> activeDirectoryEnableADUserByIdentityUserIdentity, Expression<Func<string>> activeDirectoryEnableADUserByIdentityWorkflow, Expression<Func<string>> activeDirectoryEnableADUserByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryEnableADUserByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryEnableADUserByIdentity = new JObject();
            var activeDirectoryEnableADUserByIdentitypropCount = 0;
            activeDirectoryEnableADUserByIdentitypropCount++;
            activeDirectoryEnableADUserByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryEnableADUserByIdentityUserIdentity);
            if (activeDirectoryEnableADUserByIdentityADServer != null)
            {
                activeDirectoryEnableADUserByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryEnableADUserByIdentityADServer);
                activeDirectoryEnableADUserByIdentitypropCount++;
            }

            activeDirectoryEnableADUserByIdentitypropCount++;
            activeDirectoryEnableADUserByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryEnableADUserByIdentityWorkflow);
            if (activeDirectoryEnableADUserByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryEnableADUserByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryEnableADUserByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse> ActiveDirectorySetADUserHomeFolderByIdentity(Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityUserIdentity, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityWorkflow, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityHomeDrive = null, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityHomeDirectory = null, Expression<Func<bool>> activeDirectorySetADUserHomeFolderByIdentityCreateFolder = null, Expression<Func<string>> activeDirectorySetADUserHomeFolderByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserHomeFolderByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADUserHomeFolderByIdentity = new JObject();
            var activeDirectorySetADUserHomeFolderByIdentitypropCount = 0;
            activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            activeDirectorySetADUserHomeFolderByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityUserIdentity);
            if (activeDirectorySetADUserHomeFolderByIdentityHomeDrive != null)
            {
                activeDirectorySetADUserHomeFolderByIdentity["HomeDrive"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityHomeDrive);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            if (activeDirectorySetADUserHomeFolderByIdentityHomeDirectory != null)
            {
                activeDirectorySetADUserHomeFolderByIdentity["HomeDirectory"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityHomeDirectory);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            if (activeDirectorySetADUserHomeFolderByIdentityCreateFolder != null)
            {
                activeDirectorySetADUserHomeFolderByIdentity["CreateFolder"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityCreateFolder);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            if (activeDirectorySetADUserHomeFolderByIdentityADServer != null)
            {
                activeDirectorySetADUserHomeFolderByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityADServer);
                activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            }

            activeDirectorySetADUserHomeFolderByIdentitypropCount++;
            activeDirectorySetADUserHomeFolderByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADUserHomeFolderByIdentityWorkflow);
            if (activeDirectorySetADUserHomeFolderByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectorySetADUserHomeFolderByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse> ActiveDirectoryCloneADUserGroups(Expression<Func<string>> activeDirectoryCloneADUserGroupsSourceUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserGroupsDestinationUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserGroupsWorkflow, Expression<Func<string>> activeDirectoryCloneADUserGroupsADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryCloneADUserGroups = new JObject();
            var activeDirectoryCloneADUserGroupspropCount = 0;
            activeDirectoryCloneADUserGroupspropCount++;
            activeDirectoryCloneADUserGroups["SourceUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsSourceUserIdentity);
            activeDirectoryCloneADUserGroupspropCount++;
            activeDirectoryCloneADUserGroups["DestinationUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsDestinationUserIdentity);
            if (activeDirectoryCloneADUserGroupsADServer != null)
            {
                activeDirectoryCloneADUserGroups["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsADServer);
                activeDirectoryCloneADUserGroupspropCount++;
            }

            activeDirectoryCloneADUserGroupspropCount++;
            activeDirectoryCloneADUserGroups["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserGroupsWorkflow);
            if (activeDirectoryCloneADUserGroupspropCount > 0)
            {
                callPayload.Body = activeDirectoryCloneADUserGroups;
            }

            return new ApiConnectionAction<ActiveDirectoryCloneADUserGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse> ActiveDirectoryCloneADUserProperties(Expression<Func<string>> activeDirectoryCloneADUserPropertiesSourceUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserPropertiesDestinationUserIdentity, Expression<Func<string>> activeDirectoryCloneADUserPropertiesPropertiesToClone, Expression<Func<string>> activeDirectoryCloneADUserPropertiesWorkflow, Expression<Func<string>> activeDirectoryCloneADUserPropertiesADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryCloneADUserProperties = new JObject();
            var activeDirectoryCloneADUserPropertiespropCount = 0;
            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["SourceUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesSourceUserIdentity);
            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["DestinationUserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesDestinationUserIdentity);
            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["PropertiesToClone"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesPropertiesToClone);
            if (activeDirectoryCloneADUserPropertiesADServer != null)
            {
                activeDirectoryCloneADUserProperties["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesADServer);
                activeDirectoryCloneADUserPropertiespropCount++;
            }

            activeDirectoryCloneADUserPropertiespropCount++;
            activeDirectoryCloneADUserProperties["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryCloneADUserPropertiesWorkflow);
            if (activeDirectoryCloneADUserPropertiespropCount > 0)
            {
                callPayload.Body = activeDirectoryCloneADUserProperties;
            }

            return new ApiConnectionAction<ActiveDirectoryCloneADUserPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName(Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameUserIdentity, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameWorkflow, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameGroupNamesJSON = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameExceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameExceptionIfAllGroupsFailToRemove = null, Expression<Func<string>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameADServer = null, Expression<Func<int>> activeDirectoryRemoveADUserFromMultipleADGroupsByNameMaxGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromMultipleADGroupsByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADUserFromMultipleADGroupsByName = new JObject();
            var activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount = 0;
            activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            activeDirectoryRemoveADUserFromMultipleADGroupsByName["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameUserIdentity);
            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameGroupNamesJSON != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["GroupNamesJSON"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameGroupNamesJSON);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameExceptionIfAnyGroupsFailToRemove != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameExceptionIfAnyGroupsFailToRemove);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameExceptionIfAllGroupsFailToRemove != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameExceptionIfAllGroupsFailToRemove);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameADServer != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameADServer);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNameMaxGroupsPerCall != null)
            {
                activeDirectoryRemoveADUserFromMultipleADGroupsByName["MaxGroupsPerCall"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameMaxGroupsPerCall);
                activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            }

            activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount++;
            activeDirectoryRemoveADUserFromMultipleADGroupsByName["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromMultipleADGroupsByNameWorkflow);
            if (activeDirectoryRemoveADUserFromMultipleADGroupsByNamepropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADUserFromMultipleADGroupsByName;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse> ActiveDirectoryRemoveADUserFromAllGroups(Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsWorkflow, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsUserIdentity = null, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsGroupsToExcludeJSON = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromAllGroupsExceptionIfExcludedGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveADUserFromAllGroupsADServer = null, Expression<Func<bool>> activeDirectoryRemoveADUserFromAllGroupsRunAsThread = null, Expression<Func<int>> activeDirectoryRemoveADUserFromAllGroupsRetrieveOutputDataFromThreadId = null, Expression<Func<int>> activeDirectoryRemoveADUserFromAllGroupsSecondsToWaitForThread = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromAllGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADUserFromAllGroups = new JObject();
            var activeDirectoryRemoveADUserFromAllGroupspropCount = 0;
            if (activeDirectoryRemoveADUserFromAllGroupsUserIdentity != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsUserIdentity);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsGroupsToExcludeJSON != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["GroupsToExcludeJSON"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsGroupsToExcludeJSON);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsExceptionIfExcludedGroupDoesNotExist != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["ExceptionIfExcludedGroupDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsExceptionIfExcludedGroupDoesNotExist);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsADServer != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsADServer);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsRunAsThread != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["RunAsThread"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsRunAsThread);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsRetrieveOutputDataFromThreadId != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsRetrieveOutputDataFromThreadId);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            if (activeDirectoryRemoveADUserFromAllGroupsSecondsToWaitForThread != null)
            {
                activeDirectoryRemoveADUserFromAllGroups["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsSecondsToWaitForThread);
                activeDirectoryRemoveADUserFromAllGroupspropCount++;
            }

            activeDirectoryRemoveADUserFromAllGroupspropCount++;
            activeDirectoryRemoveADUserFromAllGroups["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADUserFromAllGroupsWorkflow);
            if (activeDirectoryRemoveADUserFromAllGroupspropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADUserFromAllGroups;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse> ActiveDirectoryCheckOUExists(Expression<Func<string>> activeDirectoryCheckOUExistsOUIdentity, Expression<Func<string>> activeDirectoryCheckOUExistsWorkflow, Expression<Func<string>> activeDirectoryCheckOUExistsADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCheckOUExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryCheckOUExists = new JObject();
            var activeDirectoryCheckOUExistspropCount = 0;
            activeDirectoryCheckOUExistspropCount++;
            activeDirectoryCheckOUExists["OUIdentity"] = ExpressionConverter.ConvertO(activeDirectoryCheckOUExistsOUIdentity);
            if (activeDirectoryCheckOUExistsADServer != null)
            {
                activeDirectoryCheckOUExists["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryCheckOUExistsADServer);
                activeDirectoryCheckOUExistspropCount++;
            }

            activeDirectoryCheckOUExistspropCount++;
            activeDirectoryCheckOUExists["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryCheckOUExistsWorkflow);
            if (activeDirectoryCheckOUExistspropCount > 0)
            {
                callPayload.Body = activeDirectoryCheckOUExists;
            }

            return new ApiConnectionAction<ActiveDirectoryCheckOUExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse> ActiveDirectoryRemoveADGroupMemberByGroupIdentity(Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityUserIdentity, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityWorkflow, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityGroupIdentity = null, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityGroupName = null, Expression<Func<string>> activeDirectoryRemoveADGroupMemberByGroupIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroupMemberByGroupIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADGroupMemberByGroupIdentity = new JObject();
            var activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount = 0;
            if (activeDirectoryRemoveADGroupMemberByGroupIdentityGroupIdentity != null)
            {
                activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityGroupIdentity);
                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            }

            if (activeDirectoryRemoveADGroupMemberByGroupIdentityGroupName != null)
            {
                activeDirectoryRemoveADGroupMemberByGroupIdentity["GroupName"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityGroupName);
                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            }

            activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            activeDirectoryRemoveADGroupMemberByGroupIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityUserIdentity);
            if (activeDirectoryRemoveADGroupMemberByGroupIdentityADServer != null)
            {
                activeDirectoryRemoveADGroupMemberByGroupIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityADServer);
                activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            }

            activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount++;
            activeDirectoryRemoveADGroupMemberByGroupIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupMemberByGroupIdentityWorkflow);
            if (activeDirectoryRemoveADGroupMemberByGroupIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADGroupMemberByGroupIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity(Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityWorkflow, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityGroupIdentity = null, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityGroupMembersJSON = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityExceptionIfAnyMembersFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityExceptionIfAllMembersFailToRemove = null, Expression<Func<bool>> activeDirectoryRemoveMultipleADGroupMembersByIdentityRemoveAllMembersInASingleCall = null, Expression<Func<string>> activeDirectoryRemoveMultipleADGroupMembersByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveMultipleADGroupMembersByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveMultipleADGroupMembersByIdentity = new JObject();
            var activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount = 0;
            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityGroupIdentity != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityGroupIdentity);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityGroupMembersJSON != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["GroupMembersJSON"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityGroupMembersJSON);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityExceptionIfAnyMembersFailToRemove != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAnyMembersFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityExceptionIfAnyMembersFailToRemove);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityExceptionIfAllMembersFailToRemove != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["ExceptionIfAllMembersFailToRemove"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityExceptionIfAllMembersFailToRemove);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityRemoveAllMembersInASingleCall != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["RemoveAllMembersInASingleCall"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityRemoveAllMembersInASingleCall);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            if (activeDirectoryRemoveMultipleADGroupMembersByIdentityADServer != null)
            {
                activeDirectoryRemoveMultipleADGroupMembersByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityADServer);
                activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            }

            activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount++;
            activeDirectoryRemoveMultipleADGroupMembersByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveMultipleADGroupMembersByIdentityWorkflow);
            if (activeDirectoryRemoveMultipleADGroupMembersByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveMultipleADGroupMembersByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse> ActiveDirectoryUnlockADAccountByIdentity(Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityUserIdentity, Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityWorkflow, Expression<Func<string>> activeDirectoryUnlockADAccountByIdentityADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryUnlockADAccountByIdentity";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryUnlockADAccountByIdentity = new JObject();
            var activeDirectoryUnlockADAccountByIdentitypropCount = 0;
            activeDirectoryUnlockADAccountByIdentitypropCount++;
            activeDirectoryUnlockADAccountByIdentity["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectoryUnlockADAccountByIdentityUserIdentity);
            if (activeDirectoryUnlockADAccountByIdentityADServer != null)
            {
                activeDirectoryUnlockADAccountByIdentity["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryUnlockADAccountByIdentityADServer);
                activeDirectoryUnlockADAccountByIdentitypropCount++;
            }

            activeDirectoryUnlockADAccountByIdentitypropCount++;
            activeDirectoryUnlockADAccountByIdentity["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryUnlockADAccountByIdentityWorkflow);
            if (activeDirectoryUnlockADAccountByIdentitypropCount > 0)
            {
                callPayload.Body = activeDirectoryUnlockADAccountByIdentity;
            }

            return new ApiConnectionAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse> ActiveDirectorySetADServer(Expression<Func<string>> activeDirectorySetADServerWorkflow, Expression<Func<activeDirectorySetADServerPredefinedADServerChoiceInput>> activeDirectorySetADServerPredefinedADServerChoice = null, Expression<Func<string>> activeDirectorySetADServerADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADServer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADServer = new JObject();
            var activeDirectorySetADServerpropCount = 0;
            if (activeDirectorySetADServerPredefinedADServerChoice != null)
            {
                activeDirectorySetADServer["PredefinedADServerChoice"] = ExpressionConverter.ConvertO(activeDirectorySetADServerPredefinedADServerChoice);
                activeDirectorySetADServerpropCount++;
            }

            if (activeDirectorySetADServerADServer != null)
            {
                activeDirectorySetADServer["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADServerADServer);
                activeDirectorySetADServerpropCount++;
            }

            activeDirectorySetADServerpropCount++;
            activeDirectorySetADServer["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADServerWorkflow);
            if (activeDirectorySetADServerpropCount > 0)
            {
                callPayload.Body = activeDirectorySetADServer;
            }

            return new ApiConnectionAction<ActiveDirectorySetADServerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse> ActiveDirectoryGetDomainInfo(Expression<Func<string>> activeDirectoryGetDomainInfoWorkflow, Expression<Func<string>> activeDirectoryGetDomainInfoADServer = null, Expression<Func<activeDirectoryGetDomainInfoPredefinedIdentityInput>> activeDirectoryGetDomainInfoPredefinedIdentity = null, Expression<Func<string>> activeDirectoryGetDomainInfoIdentity = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetDomainInfo = new JObject();
            var activeDirectoryGetDomainInfopropCount = 0;
            if (activeDirectoryGetDomainInfoADServer != null)
            {
                activeDirectoryGetDomainInfo["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoADServer);
                activeDirectoryGetDomainInfopropCount++;
            }

            if (activeDirectoryGetDomainInfoPredefinedIdentity != null)
            {
                activeDirectoryGetDomainInfo["PredefinedIdentity"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoPredefinedIdentity);
                activeDirectoryGetDomainInfopropCount++;
            }

            if (activeDirectoryGetDomainInfoIdentity != null)
            {
                activeDirectoryGetDomainInfo["Identity"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoIdentity);
                activeDirectoryGetDomainInfopropCount++;
            }

            activeDirectoryGetDomainInfopropCount++;
            activeDirectoryGetDomainInfo["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetDomainInfoWorkflow);
            if (activeDirectoryGetDomainInfopropCount > 0)
            {
                callPayload.Body = activeDirectoryGetDomainInfo;
            }

            return new ApiConnectionAction<ActiveDirectoryGetDomainInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse> ActiveDirectoryAddADGroup(Expression<Func<string>> activeDirectoryAddADGroupName, Expression<Func<activeDirectoryAddADGroupGroupCategoryInput>> activeDirectoryAddADGroupGroupCategory, Expression<Func<activeDirectoryAddADGroupGroupScopeInput>> activeDirectoryAddADGroupGroupScope, Expression<Func<string>> activeDirectoryAddADGroupWorkflow, Expression<Func<string>> activeDirectoryAddADGroupSamAccountName = null, Expression<Func<string>> activeDirectoryAddADGroupPath = null, Expression<Func<string>> activeDirectoryAddADGroupDescription = null, Expression<Func<string>> activeDirectoryAddADGroupNotes = null, Expression<Func<string>> activeDirectoryAddADGroupDisplayName = null, Expression<Func<string>> activeDirectoryAddADGroupHomePage = null, Expression<Func<string>> activeDirectoryAddADGroupManagedBy = null, Expression<Func<bool>> activeDirectoryAddADGroupProtectedFromAccidentalDeletion = null, Expression<Func<string>> activeDirectoryAddADGroupADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddADGroup = new JObject();
            var activeDirectoryAddADGrouppropCount = 0;
            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["Name"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupName);
            if (activeDirectoryAddADGroupSamAccountName != null)
            {
                activeDirectoryAddADGroup["SamAccountName"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupSamAccountName);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupPath != null)
            {
                activeDirectoryAddADGroup["Path"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupPath);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupDescription != null)
            {
                activeDirectoryAddADGroup["Description"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupDescription);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupNotes != null)
            {
                activeDirectoryAddADGroup["Notes"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupNotes);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupDisplayName != null)
            {
                activeDirectoryAddADGroup["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupDisplayName);
                activeDirectoryAddADGrouppropCount++;
            }

            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["GroupCategory"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupGroupCategory);
            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["GroupScope"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupGroupScope);
            if (activeDirectoryAddADGroupHomePage != null)
            {
                activeDirectoryAddADGroup["HomePage"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupHomePage);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupManagedBy != null)
            {
                activeDirectoryAddADGroup["ManagedBy"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupManagedBy);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupProtectedFromAccidentalDeletion != null)
            {
                activeDirectoryAddADGroup["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupProtectedFromAccidentalDeletion);
                activeDirectoryAddADGrouppropCount++;
            }

            if (activeDirectoryAddADGroupADServer != null)
            {
                activeDirectoryAddADGroup["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupADServer);
                activeDirectoryAddADGrouppropCount++;
            }

            activeDirectoryAddADGrouppropCount++;
            activeDirectoryAddADGroup["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddADGroupWorkflow);
            if (activeDirectoryAddADGrouppropCount > 0)
            {
                callPayload.Body = activeDirectoryAddADGroup;
            }

            return new ApiConnectionAction<ActiveDirectoryAddADGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse> ActiveDirectoryDoesADGroupExist(Expression<Func<string>> activeDirectoryDoesADGroupExistGroupIdentity, Expression<Func<string>> activeDirectoryDoesADGroupExistWorkflow, Expression<Func<string>> activeDirectoryDoesADGroupExistADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDoesADGroupExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryDoesADGroupExist = new JObject();
            var activeDirectoryDoesADGroupExistpropCount = 0;
            activeDirectoryDoesADGroupExistpropCount++;
            activeDirectoryDoesADGroupExist["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryDoesADGroupExistGroupIdentity);
            if (activeDirectoryDoesADGroupExistADServer != null)
            {
                activeDirectoryDoesADGroupExist["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryDoesADGroupExistADServer);
                activeDirectoryDoesADGroupExistpropCount++;
            }

            activeDirectoryDoesADGroupExistpropCount++;
            activeDirectoryDoesADGroupExist["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryDoesADGroupExistWorkflow);
            if (activeDirectoryDoesADGroupExistpropCount > 0)
            {
                callPayload.Body = activeDirectoryDoesADGroupExist;
            }

            return new ApiConnectionAction<ActiveDirectoryDoesADGroupExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse> ActiveDirectoryRemoveADGroup(Expression<Func<string>> activeDirectoryRemoveADGroupGroupIdentity, Expression<Func<string>> activeDirectoryRemoveADGroupWorkflow, Expression<Func<bool>> activeDirectoryRemoveADGroupDeleteEvenIfProtected = null, Expression<Func<bool>> activeDirectoryRemoveADGroupRaiseExceptionIfGroupDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveADGroupADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveADGroup = new JObject();
            var activeDirectoryRemoveADGrouppropCount = 0;
            activeDirectoryRemoveADGrouppropCount++;
            activeDirectoryRemoveADGroup["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupGroupIdentity);
            if (activeDirectoryRemoveADGroupDeleteEvenIfProtected != null)
            {
                activeDirectoryRemoveADGroup["DeleteEvenIfProtected"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupDeleteEvenIfProtected);
                activeDirectoryRemoveADGrouppropCount++;
            }

            if (activeDirectoryRemoveADGroupRaiseExceptionIfGroupDoesNotExist != null)
            {
                activeDirectoryRemoveADGroup["RaiseExceptionIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupRaiseExceptionIfGroupDoesNotExist);
                activeDirectoryRemoveADGrouppropCount++;
            }

            if (activeDirectoryRemoveADGroupADServer != null)
            {
                activeDirectoryRemoveADGroup["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupADServer);
                activeDirectoryRemoveADGrouppropCount++;
            }

            activeDirectoryRemoveADGrouppropCount++;
            activeDirectoryRemoveADGroup["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveADGroupWorkflow);
            if (activeDirectoryRemoveADGrouppropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveADGroup;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveADGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse> ActiveDirectoryAddOU(Expression<Func<string>> activeDirectoryAddOUName, Expression<Func<string>> activeDirectoryAddOUWorkflow, Expression<Func<string>> activeDirectoryAddOUPath = null, Expression<Func<string>> activeDirectoryAddOUDescription = null, Expression<Func<string>> activeDirectoryAddOUDisplayName = null, Expression<Func<string>> activeDirectoryAddOUManagedBy = null, Expression<Func<bool>> activeDirectoryAddOUProtectedFromAccidentalDeletion = null, Expression<Func<string>> activeDirectoryAddOUStreetAddress = null, Expression<Func<string>> activeDirectoryAddOUCity = null, Expression<Func<string>> activeDirectoryAddOUState = null, Expression<Func<string>> activeDirectoryAddOUPostalCode = null, Expression<Func<string>> activeDirectoryAddOUADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddOU";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryAddOU = new JObject();
            var activeDirectoryAddOUpropCount = 0;
            activeDirectoryAddOUpropCount++;
            activeDirectoryAddOU["Name"] = ExpressionConverter.ConvertO(activeDirectoryAddOUName);
            if (activeDirectoryAddOUPath != null)
            {
                activeDirectoryAddOU["Path"] = ExpressionConverter.ConvertO(activeDirectoryAddOUPath);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUDescription != null)
            {
                activeDirectoryAddOU["Description"] = ExpressionConverter.ConvertO(activeDirectoryAddOUDescription);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUDisplayName != null)
            {
                activeDirectoryAddOU["DisplayName"] = ExpressionConverter.ConvertO(activeDirectoryAddOUDisplayName);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUManagedBy != null)
            {
                activeDirectoryAddOU["ManagedBy"] = ExpressionConverter.ConvertO(activeDirectoryAddOUManagedBy);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUProtectedFromAccidentalDeletion != null)
            {
                activeDirectoryAddOU["ProtectedFromAccidentalDeletion"] = ExpressionConverter.ConvertO(activeDirectoryAddOUProtectedFromAccidentalDeletion);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUStreetAddress != null)
            {
                activeDirectoryAddOU["StreetAddress"] = ExpressionConverter.ConvertO(activeDirectoryAddOUStreetAddress);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUCity != null)
            {
                activeDirectoryAddOU["City"] = ExpressionConverter.ConvertO(activeDirectoryAddOUCity);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUState != null)
            {
                activeDirectoryAddOU["State"] = ExpressionConverter.ConvertO(activeDirectoryAddOUState);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUPostalCode != null)
            {
                activeDirectoryAddOU["PostalCode"] = ExpressionConverter.ConvertO(activeDirectoryAddOUPostalCode);
                activeDirectoryAddOUpropCount++;
            }

            if (activeDirectoryAddOUADServer != null)
            {
                activeDirectoryAddOU["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryAddOUADServer);
                activeDirectoryAddOUpropCount++;
            }

            activeDirectoryAddOUpropCount++;
            activeDirectoryAddOU["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryAddOUWorkflow);
            if (activeDirectoryAddOUpropCount > 0)
            {
                callPayload.Body = activeDirectoryAddOU;
            }

            return new ApiConnectionAction<ActiveDirectoryAddOUResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse> ActiveDirectoryRemoveOU(Expression<Func<string>> activeDirectoryRemoveOUOUIdentity, Expression<Func<string>> activeDirectoryRemoveOUWorkflow, Expression<Func<bool>> activeDirectoryRemoveOUDeleteEvenIfProtected = null, Expression<Func<bool>> activeDirectoryRemoveOURaiseExceptionIfOUDoesNotExist = null, Expression<Func<string>> activeDirectoryRemoveOUADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveOU";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryRemoveOU = new JObject();
            var activeDirectoryRemoveOUpropCount = 0;
            activeDirectoryRemoveOUpropCount++;
            activeDirectoryRemoveOU["OUIdentity"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUOUIdentity);
            if (activeDirectoryRemoveOUDeleteEvenIfProtected != null)
            {
                activeDirectoryRemoveOU["DeleteEvenIfProtected"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUDeleteEvenIfProtected);
                activeDirectoryRemoveOUpropCount++;
            }

            if (activeDirectoryRemoveOURaiseExceptionIfOUDoesNotExist != null)
            {
                activeDirectoryRemoveOU["RaiseExceptionIfOUDoesNotExist"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOURaiseExceptionIfOUDoesNotExist);
                activeDirectoryRemoveOUpropCount++;
            }

            if (activeDirectoryRemoveOUADServer != null)
            {
                activeDirectoryRemoveOU["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUADServer);
                activeDirectoryRemoveOUpropCount++;
            }

            activeDirectoryRemoveOUpropCount++;
            activeDirectoryRemoveOU["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryRemoveOUWorkflow);
            if (activeDirectoryRemoveOUpropCount > 0)
            {
                callPayload.Body = activeDirectoryRemoveOU;
            }

            return new ApiConnectionAction<ActiveDirectoryRemoveOUResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse> ActiveDirectorySetADUserAccountExpirationEndOfDate(Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateUserIdentity, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateYear, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateMonth, Expression<Func<int>> activeDirectorySetADUserAccountExpirationEndOfDateDay, Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateWorkflow, Expression<Func<string>> activeDirectorySetADUserAccountExpirationEndOfDateADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserAccountExpirationEndOfDate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectorySetADUserAccountExpirationEndOfDate = new JObject();
            var activeDirectorySetADUserAccountExpirationEndOfDatepropCount = 0;
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["UserIdentity"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateUserIdentity);
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Year"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateYear);
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Month"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateMonth);
            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Day"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateDay);
            if (activeDirectorySetADUserAccountExpirationEndOfDateADServer != null)
            {
                activeDirectorySetADUserAccountExpirationEndOfDate["ADServer"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateADServer);
                activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            }

            activeDirectorySetADUserAccountExpirationEndOfDatepropCount++;
            activeDirectorySetADUserAccountExpirationEndOfDate["Workflow"] = ExpressionConverter.ConvertO(activeDirectorySetADUserAccountExpirationEndOfDateWorkflow);
            if (activeDirectorySetADUserAccountExpirationEndOfDatepropCount > 0)
            {
                callPayload.Body = activeDirectorySetADUserAccountExpirationEndOfDate;
            }

            return new ApiConnectionAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse> ActiveDirectoryGetADGroupMembers(Expression<Func<string>> activeDirectoryGetADGroupMembersGroupIdentity, Expression<Func<string>> activeDirectoryGetADGroupMembersWorkflow, Expression<Func<bool>> activeDirectoryGetADGroupMembersRecursive = null, Expression<Func<string>> activeDirectoryGetADGroupMembersADServer = null)
        {
            var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var activeDirectoryGetADGroupMembers = new JObject();
            var activeDirectoryGetADGroupMemberspropCount = 0;
            activeDirectoryGetADGroupMemberspropCount++;
            activeDirectoryGetADGroupMembers["GroupIdentity"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersGroupIdentity);
            if (activeDirectoryGetADGroupMembersRecursive != null)
            {
                activeDirectoryGetADGroupMembers["Recursive"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersRecursive);
                activeDirectoryGetADGroupMemberspropCount++;
            }

            if (activeDirectoryGetADGroupMembersADServer != null)
            {
                activeDirectoryGetADGroupMembers["ADServer"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersADServer);
                activeDirectoryGetADGroupMemberspropCount++;
            }

            activeDirectoryGetADGroupMemberspropCount++;
            activeDirectoryGetADGroupMembers["Workflow"] = ExpressionConverter.ConvertO(activeDirectoryGetADGroupMembersWorkflow);
            if (activeDirectoryGetADGroupMemberspropCount > 0)
            {
                callPayload.Body = activeDirectoryGetADGroupMembers;
            }

            return new ApiConnectionAction<ActiveDirectoryGetADGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse> OpenExchangePowerShellRunspace(Expression<Func<string>> openExchangePowerShellRunspaceExchangeServerFQDN, Expression<Func<string>> openExchangePowerShellRunspaceWorkflow, Expression<Func<string>> openExchangePowerShellRunspaceUsername = null, Expression<Func<string>> openExchangePowerShellRunspacePassword = null, Expression<Func<bool>> openExchangePowerShellRunspaceUseSSL = null, Expression<Func<openExchangePowerShellRunspaceConnectionMethodInput>> openExchangePowerShellRunspaceConnectionMethod = null, Expression<Func<openExchangePowerShellRunspaceAuthenticationMechanismInput>> openExchangePowerShellRunspaceAuthenticationMechanism = null, Expression<Func<bool>> openExchangePowerShellRunspaceOnlyConnectIfNotAlreadyConnected = null, Expression<Func<openExchangePowerShellRunspaceCommandTypesToImportLocallyInput>> openExchangePowerShellRunspaceCommandTypesToImportLocally = null, Expression<Func<string>> openExchangePowerShellRunspaceAdditionalCommandsToImportLocallyCSV = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenExchangePowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openExchangePowerShellRunspace = new JObject();
            var openExchangePowerShellRunspacepropCount = 0;
            if (openExchangePowerShellRunspaceUsername != null)
            {
                openExchangePowerShellRunspace["Username"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceUsername);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspacePassword != null)
            {
                openExchangePowerShellRunspace["Password"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspacePassword);
                openExchangePowerShellRunspacepropCount++;
            }

            openExchangePowerShellRunspacepropCount++;
            openExchangePowerShellRunspace["ExchangeServerFQDN"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceExchangeServerFQDN);
            if (openExchangePowerShellRunspaceUseSSL != null)
            {
                openExchangePowerShellRunspace["UseSSL"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceUseSSL);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspaceConnectionMethod != null)
            {
                openExchangePowerShellRunspace["ConnectionMethod"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceConnectionMethod);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspaceAuthenticationMechanism != null)
            {
                openExchangePowerShellRunspace["AuthenticationMechanism"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceAuthenticationMechanism);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspaceOnlyConnectIfNotAlreadyConnected != null)
            {
                openExchangePowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceOnlyConnectIfNotAlreadyConnected);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspaceCommandTypesToImportLocally != null)
            {
                openExchangePowerShellRunspace["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceCommandTypesToImportLocally);
                openExchangePowerShellRunspacepropCount++;
            }

            if (openExchangePowerShellRunspaceAdditionalCommandsToImportLocallyCSV != null)
            {
                openExchangePowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceAdditionalCommandsToImportLocallyCSV);
                openExchangePowerShellRunspacepropCount++;
            }

            openExchangePowerShellRunspacepropCount++;
            openExchangePowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openExchangePowerShellRunspaceWorkflow);
            if (openExchangePowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openExchangePowerShellRunspace;
            }

            return new ApiConnectionAction<OpenExchangePowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse> IsExchangePowerShellRunspaceOpen(Expression<Func<string>> isExchangePowerShellRunspaceOpenWorkflow, Expression<Func<bool>> isExchangePowerShellRunspaceOpenTestCommunications = null, Expression<Func<bool>> isExchangePowerShellRunspaceOpenRetrievePowerShellRunSpacePID = null)
        {
            var apiCallPath = "/PowerShellAutomation/IsExchangePowerShellRunspaceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isExchangePowerShellRunspaceOpen = new JObject();
            var isExchangePowerShellRunspaceOpenpropCount = 0;
            if (isExchangePowerShellRunspaceOpenTestCommunications != null)
            {
                isExchangePowerShellRunspaceOpen["TestCommunications"] = ExpressionConverter.ConvertO(isExchangePowerShellRunspaceOpenTestCommunications);
                isExchangePowerShellRunspaceOpenpropCount++;
            }

            if (isExchangePowerShellRunspaceOpenRetrievePowerShellRunSpacePID != null)
            {
                isExchangePowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(isExchangePowerShellRunspaceOpenRetrievePowerShellRunSpacePID);
                isExchangePowerShellRunspaceOpenpropCount++;
            }

            isExchangePowerShellRunspaceOpenpropCount++;
            isExchangePowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isExchangePowerShellRunspaceOpenWorkflow);
            if (isExchangePowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isExchangePowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsExchangePowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse> RunExchangePowerShellAutomationScript(Expression<Func<string>> runExchangePowerShellAutomationScriptWorkflow, Expression<Func<string>> runExchangePowerShellAutomationScriptPowerShellScriptContents = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptIsNoResultAnError = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptReturnComplexTypes = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptReturnBooleanAsBoolean = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptReturnNumericAsDecimal = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptReturnDateAsDate = null, Expression<Func<string>> runExchangePowerShellAutomationScriptPropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptRunScriptAsThread = null, Expression<Func<int>> runExchangePowerShellAutomationScriptRetrieveOutputDataFromThreadId = null, Expression<Func<int>> runExchangePowerShellAutomationScriptSecondsToWaitForThread = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptScriptContainsStoredPassword = null, Expression<Func<bool>> runExchangePowerShellAutomationScriptLogVerboseOutput = null, Expression<Func<string>> runExchangePowerShellAutomationScriptPropertyNamesToSerializeJSON = null, Expression<Func<string>> runExchangePowerShellAutomationScriptPropertyTypesToSerializeJSON = null, Expression<Func<runExchangePowerShellAutomationScriptPowerShellCommandParametersInputItem[]>> runExchangePowerShellAutomationScriptPowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunExchangePowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runExchangePowerShellAutomationScript = new JObject();
            var runExchangePowerShellAutomationScriptpropCount = 0;
            if (runExchangePowerShellAutomationScriptPowerShellScriptContents != null)
            {
                runExchangePowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptPowerShellScriptContents);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptIsNoResultAnError != null)
            {
                runExchangePowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptIsNoResultAnError);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptReturnComplexTypes != null)
            {
                runExchangePowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptReturnComplexTypes);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptReturnBooleanAsBoolean != null)
            {
                runExchangePowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptReturnBooleanAsBoolean);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptReturnNumericAsDecimal != null)
            {
                runExchangePowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptReturnNumericAsDecimal);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptReturnDateAsDate != null)
            {
                runExchangePowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptReturnDateAsDate);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptPropertiesToReturnAsCollectionJSON != null)
            {
                runExchangePowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptPropertiesToReturnAsCollectionJSON);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptRunScriptAsThread != null)
            {
                runExchangePowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptRunScriptAsThread);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptRetrieveOutputDataFromThreadId != null)
            {
                runExchangePowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptRetrieveOutputDataFromThreadId);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptSecondsToWaitForThread != null)
            {
                runExchangePowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptSecondsToWaitForThread);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptScriptContainsStoredPassword != null)
            {
                runExchangePowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptScriptContainsStoredPassword);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptLogVerboseOutput != null)
            {
                runExchangePowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptLogVerboseOutput);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptPropertyNamesToSerializeJSON != null)
            {
                runExchangePowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptPropertyNamesToSerializeJSON);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptPropertyTypesToSerializeJSON != null)
            {
                runExchangePowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptPropertyTypesToSerializeJSON);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            if (runExchangePowerShellAutomationScriptPowerShellCommandParameters != null)
            {
                runExchangePowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptPowerShellCommandParameters);
                runExchangePowerShellAutomationScriptpropCount++;
            }

            runExchangePowerShellAutomationScriptpropCount++;
            runExchangePowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runExchangePowerShellAutomationScriptWorkflow);
            if (runExchangePowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runExchangePowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunExchangePowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse> CloseExchangePowerShellRunspace(Expression<Func<string>> closeExchangePowerShellRunspaceWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/CloseExchangePowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeExchangePowerShellRunspace = new JObject();
            var closeExchangePowerShellRunspacepropCount = 0;
            closeExchangePowerShellRunspacepropCount++;
            closeExchangePowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeExchangePowerShellRunspaceWorkflow);
            if (closeExchangePowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeExchangePowerShellRunspace;
            }

            return new ApiConnectionAction<CloseExchangePowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse> ExchangeGetMailbox(Expression<Func<string>> exchangeGetMailboxWorkflow, Expression<Func<string>> exchangeGetMailboxIdentity = null, Expression<Func<string>> exchangeGetMailboxFilterPropertyName = null, Expression<Func<exchangeGetMailboxFilterPropertyComparisonInput>> exchangeGetMailboxFilterPropertyComparison = null, Expression<Func<string>> exchangeGetMailboxFilterPropertyValue = null, Expression<Func<exchangeGetMailboxRecipientTypeDetailsInput>> exchangeGetMailboxRecipientTypeDetails = null, Expression<Func<bool>> exchangeGetMailboxNoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetMailbox = new JObject();
            var exchangeGetMailboxpropCount = 0;
            if (exchangeGetMailboxIdentity != null)
            {
                exchangeGetMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeGetMailboxIdentity);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxFilterPropertyName != null)
            {
                exchangeGetMailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeGetMailboxFilterPropertyName);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxFilterPropertyComparison != null)
            {
                exchangeGetMailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeGetMailboxFilterPropertyComparison);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxFilterPropertyValue != null)
            {
                exchangeGetMailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeGetMailboxFilterPropertyValue);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxRecipientTypeDetails != null)
            {
                exchangeGetMailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(exchangeGetMailboxRecipientTypeDetails);
                exchangeGetMailboxpropCount++;
            }

            if (exchangeGetMailboxNoResultIsAnException != null)
            {
                exchangeGetMailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(exchangeGetMailboxNoResultIsAnException);
                exchangeGetMailboxpropCount++;
            }

            exchangeGetMailboxpropCount++;
            exchangeGetMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeGetMailboxWorkflow);
            if (exchangeGetMailboxpropCount > 0)
            {
                callPayload.Body = exchangeGetMailbox;
            }

            return new ApiConnectionAction<ExchangeGetMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse> ExchangeDoesMailboxExist(Expression<Func<string>> exchangeDoesMailboxExistWorkflow, Expression<Func<string>> exchangeDoesMailboxExistIdentity = null, Expression<Func<string>> exchangeDoesMailboxExistFilterPropertyName = null, Expression<Func<exchangeDoesMailboxExistFilterPropertyComparisonInput>> exchangeDoesMailboxExistFilterPropertyComparison = null, Expression<Func<string>> exchangeDoesMailboxExistFilterPropertyValue = null, Expression<Func<exchangeDoesMailboxExistRecipientTypeDetailsInput>> exchangeDoesMailboxExistRecipientTypeDetails = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDoesMailboxExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDoesMailboxExist = new JObject();
            var exchangeDoesMailboxExistpropCount = 0;
            if (exchangeDoesMailboxExistIdentity != null)
            {
                exchangeDoesMailboxExist["Identity"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistIdentity);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistFilterPropertyName != null)
            {
                exchangeDoesMailboxExist["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistFilterPropertyName);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistFilterPropertyComparison != null)
            {
                exchangeDoesMailboxExist["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistFilterPropertyComparison);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistFilterPropertyValue != null)
            {
                exchangeDoesMailboxExist["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistFilterPropertyValue);
                exchangeDoesMailboxExistpropCount++;
            }

            if (exchangeDoesMailboxExistRecipientTypeDetails != null)
            {
                exchangeDoesMailboxExist["RecipientTypeDetails"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistRecipientTypeDetails);
                exchangeDoesMailboxExistpropCount++;
            }

            exchangeDoesMailboxExistpropCount++;
            exchangeDoesMailboxExist["Workflow"] = ExpressionConverter.ConvertO(exchangeDoesMailboxExistWorkflow);
            if (exchangeDoesMailboxExistpropCount > 0)
            {
                callPayload.Body = exchangeDoesMailboxExist;
            }

            return new ApiConnectionAction<ExchangeDoesMailboxExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse> ExchangeAddDistributionGroupMember(Expression<Func<string>> exchangeAddDistributionGroupMemberIdentity, Expression<Func<string>> exchangeAddDistributionGroupMemberMember, Expression<Func<string>> exchangeAddDistributionGroupMemberWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeAddDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeAddDistributionGroupMember = new JObject();
            var exchangeAddDistributionGroupMemberpropCount = 0;
            exchangeAddDistributionGroupMemberpropCount++;
            exchangeAddDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(exchangeAddDistributionGroupMemberIdentity);
            exchangeAddDistributionGroupMemberpropCount++;
            exchangeAddDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(exchangeAddDistributionGroupMemberMember);
            exchangeAddDistributionGroupMemberpropCount++;
            exchangeAddDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(exchangeAddDistributionGroupMemberWorkflow);
            if (exchangeAddDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = exchangeAddDistributionGroupMember;
            }

            return new ApiConnectionAction<ExchangeAddDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse> ExchangeRemoveDistributionGroupMember(Expression<Func<string>> exchangeRemoveDistributionGroupMemberIdentity, Expression<Func<string>> exchangeRemoveDistributionGroupMemberMember, Expression<Func<string>> exchangeRemoveDistributionGroupMemberWorkflow, Expression<Func<bool>> exchangeRemoveDistributionGroupMemberBypassSecurityGroupManagerCheck = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeRemoveDistributionGroupMember = new JObject();
            var exchangeRemoveDistributionGroupMemberpropCount = 0;
            exchangeRemoveDistributionGroupMemberpropCount++;
            exchangeRemoveDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberIdentity);
            exchangeRemoveDistributionGroupMemberpropCount++;
            exchangeRemoveDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberMember);
            if (exchangeRemoveDistributionGroupMemberBypassSecurityGroupManagerCheck != null)
            {
                exchangeRemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberBypassSecurityGroupManagerCheck);
                exchangeRemoveDistributionGroupMemberpropCount++;
            }

            exchangeRemoveDistributionGroupMemberpropCount++;
            exchangeRemoveDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupMemberWorkflow);
            if (exchangeRemoveDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = exchangeRemoveDistributionGroupMember;
            }

            return new ApiConnectionAction<ExchangeRemoveDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse> ExchangeGetDistributionGroup(Expression<Func<string>> exchangeGetDistributionGroupWorkflow, Expression<Func<string>> exchangeGetDistributionGroupIdentity = null, Expression<Func<string>> exchangeGetDistributionGroupFilterPropertyName = null, Expression<Func<exchangeGetDistributionGroupFilterPropertyComparisonInput>> exchangeGetDistributionGroupFilterPropertyComparison = null, Expression<Func<string>> exchangeGetDistributionGroupFilterPropertyValue = null, Expression<Func<bool>> exchangeGetDistributionGroupNoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetDistributionGroup = new JObject();
            var exchangeGetDistributionGrouppropCount = 0;
            if (exchangeGetDistributionGroupIdentity != null)
            {
                exchangeGetDistributionGroup["Identity"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupIdentity);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupFilterPropertyName != null)
            {
                exchangeGetDistributionGroup["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupFilterPropertyName);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupFilterPropertyComparison != null)
            {
                exchangeGetDistributionGroup["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupFilterPropertyComparison);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupFilterPropertyValue != null)
            {
                exchangeGetDistributionGroup["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupFilterPropertyValue);
                exchangeGetDistributionGrouppropCount++;
            }

            if (exchangeGetDistributionGroupNoResultIsAnException != null)
            {
                exchangeGetDistributionGroup["NoResultIsAnException"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupNoResultIsAnException);
                exchangeGetDistributionGrouppropCount++;
            }

            exchangeGetDistributionGrouppropCount++;
            exchangeGetDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupWorkflow);
            if (exchangeGetDistributionGrouppropCount > 0)
            {
                callPayload.Body = exchangeGetDistributionGroup;
            }

            return new ApiConnectionAction<ExchangeGetDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse> ExchangeGetDistributionGroupMembers(Expression<Func<string>> exchangeGetDistributionGroupMembersIdentity, Expression<Func<string>> exchangeGetDistributionGroupMembersWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetDistributionGroupMembers = new JObject();
            var exchangeGetDistributionGroupMemberspropCount = 0;
            exchangeGetDistributionGroupMemberspropCount++;
            exchangeGetDistributionGroupMembers["Identity"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupMembersIdentity);
            exchangeGetDistributionGroupMemberspropCount++;
            exchangeGetDistributionGroupMembers["Workflow"] = ExpressionConverter.ConvertO(exchangeGetDistributionGroupMembersWorkflow);
            if (exchangeGetDistributionGroupMemberspropCount > 0)
            {
                callPayload.Body = exchangeGetDistributionGroupMembers;
            }

            return new ApiConnectionAction<ExchangeGetDistributionGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse> ExchangeGetMailboxDistributionGroupMembership(Expression<Func<string>> exchangeGetMailboxDistributionGroupMembershipIdentity, Expression<Func<string>> exchangeGetMailboxDistributionGroupMembershipWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxDistributionGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetMailboxDistributionGroupMembership = new JObject();
            var exchangeGetMailboxDistributionGroupMembershippropCount = 0;
            exchangeGetMailboxDistributionGroupMembershippropCount++;
            exchangeGetMailboxDistributionGroupMembership["Identity"] = ExpressionConverter.ConvertO(exchangeGetMailboxDistributionGroupMembershipIdentity);
            exchangeGetMailboxDistributionGroupMembershippropCount++;
            exchangeGetMailboxDistributionGroupMembership["Workflow"] = ExpressionConverter.ConvertO(exchangeGetMailboxDistributionGroupMembershipWorkflow);
            if (exchangeGetMailboxDistributionGroupMembershippropCount > 0)
            {
                callPayload.Body = exchangeGetMailboxDistributionGroupMembership;
            }

            return new ApiConnectionAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse> ExchangeNewDistributionGroup(Expression<Func<string>> exchangeNewDistributionGroupName, Expression<Func<string>> exchangeNewDistributionGroupWorkflow, Expression<Func<string>> exchangeNewDistributionGroupAlias = null, Expression<Func<string>> exchangeNewDistributionGroupDisplayName = null, Expression<Func<string>> exchangeNewDistributionGroupNotes = null, Expression<Func<string>> exchangeNewDistributionGroupManagedBy = null, Expression<Func<string>> exchangeNewDistributionGroupMembers = null, Expression<Func<string>> exchangeNewDistributionGroupOrganizationalUnit = null, Expression<Func<string>> exchangeNewDistributionGroupPrimarySmtpAddress = null, Expression<Func<exchangeNewDistributionGroupMemberDepartRestrictionInput>> exchangeNewDistributionGroupMemberDepartRestriction = null, Expression<Func<exchangeNewDistributionGroupMemberJoinRestrictionInput>> exchangeNewDistributionGroupMemberJoinRestriction = null, Expression<Func<bool>> exchangeNewDistributionGroupRequireSenderAuthenticationEnabled = null, Expression<Func<exchangeNewDistributionGroupTypeInput>> exchangeNewDistributionGroupType = null, Expression<Func<bool>> exchangeNewDistributionGroupErrorIfGroupAlreadyExists = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeNewDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeNewDistributionGroup = new JObject();
            var exchangeNewDistributionGrouppropCount = 0;
            exchangeNewDistributionGrouppropCount++;
            exchangeNewDistributionGroup["Name"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupName);
            if (exchangeNewDistributionGroupAlias != null)
            {
                exchangeNewDistributionGroup["Alias"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupAlias);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupDisplayName != null)
            {
                exchangeNewDistributionGroup["DisplayName"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupDisplayName);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupNotes != null)
            {
                exchangeNewDistributionGroup["Notes"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupNotes);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupManagedBy != null)
            {
                exchangeNewDistributionGroup["ManagedBy"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupManagedBy);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupMembers != null)
            {
                exchangeNewDistributionGroup["Members"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupMembers);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupOrganizationalUnit != null)
            {
                exchangeNewDistributionGroup["OrganizationalUnit"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupOrganizationalUnit);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupPrimarySmtpAddress != null)
            {
                exchangeNewDistributionGroup["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupPrimarySmtpAddress);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupMemberDepartRestriction != null)
            {
                exchangeNewDistributionGroup["MemberDepartRestriction"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupMemberDepartRestriction);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupMemberJoinRestriction != null)
            {
                exchangeNewDistributionGroup["MemberJoinRestriction"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupMemberJoinRestriction);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupRequireSenderAuthenticationEnabled != null)
            {
                exchangeNewDistributionGroup["RequireSenderAuthenticationEnabled"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupRequireSenderAuthenticationEnabled);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupType != null)
            {
                exchangeNewDistributionGroup["Type"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupType);
                exchangeNewDistributionGrouppropCount++;
            }

            if (exchangeNewDistributionGroupErrorIfGroupAlreadyExists != null)
            {
                exchangeNewDistributionGroup["ErrorIfGroupAlreadyExists"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupErrorIfGroupAlreadyExists);
                exchangeNewDistributionGrouppropCount++;
            }

            exchangeNewDistributionGrouppropCount++;
            exchangeNewDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(exchangeNewDistributionGroupWorkflow);
            if (exchangeNewDistributionGrouppropCount > 0)
            {
                callPayload.Body = exchangeNewDistributionGroup;
            }

            return new ApiConnectionAction<ExchangeNewDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse> ExchangeRemoveDistributionGroup(Expression<Func<string>> exchangeRemoveDistributionGroupIdentity, Expression<Func<string>> exchangeRemoveDistributionGroupWorkflow, Expression<Func<bool>> exchangeRemoveDistributionGroupBypassSecurityGroupManagerCheck = null, Expression<Func<bool>> exchangeRemoveDistributionGroupErrorIfGroupDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeRemoveDistributionGroup = new JObject();
            var exchangeRemoveDistributionGrouppropCount = 0;
            exchangeRemoveDistributionGrouppropCount++;
            exchangeRemoveDistributionGroup["Identity"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupIdentity);
            if (exchangeRemoveDistributionGroupBypassSecurityGroupManagerCheck != null)
            {
                exchangeRemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupBypassSecurityGroupManagerCheck);
                exchangeRemoveDistributionGrouppropCount++;
            }

            if (exchangeRemoveDistributionGroupErrorIfGroupDoesNotExist != null)
            {
                exchangeRemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupErrorIfGroupDoesNotExist);
                exchangeRemoveDistributionGrouppropCount++;
            }

            exchangeRemoveDistributionGrouppropCount++;
            exchangeRemoveDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(exchangeRemoveDistributionGroupWorkflow);
            if (exchangeRemoveDistributionGrouppropCount > 0)
            {
                callPayload.Body = exchangeRemoveDistributionGroup;
            }

            return new ApiConnectionAction<ExchangeRemoveDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse> ExchangeAddMailboxPermission(Expression<Func<string>> exchangeAddMailboxPermissionIdentity, Expression<Func<string>> exchangeAddMailboxPermissionUser, Expression<Func<string>> exchangeAddMailboxPermissionAccessRights, Expression<Func<string>> exchangeAddMailboxPermissionWorkflow, Expression<Func<bool>> exchangeAddMailboxPermissionAutoMapping = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeAddMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeAddMailboxPermission = new JObject();
            var exchangeAddMailboxPermissionpropCount = 0;
            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["Identity"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionIdentity);
            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["User"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionUser);
            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionAccessRights);
            if (exchangeAddMailboxPermissionAutoMapping != null)
            {
                exchangeAddMailboxPermission["AutoMapping"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionAutoMapping);
                exchangeAddMailboxPermissionpropCount++;
            }

            exchangeAddMailboxPermissionpropCount++;
            exchangeAddMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeAddMailboxPermissionWorkflow);
            if (exchangeAddMailboxPermissionpropCount > 0)
            {
                callPayload.Body = exchangeAddMailboxPermission;
            }

            return new ApiConnectionAction<ExchangeAddMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse> ExchangeRemoveMailboxPermission(Expression<Func<string>> exchangeRemoveMailboxPermissionIdentity, Expression<Func<string>> exchangeRemoveMailboxPermissionUser, Expression<Func<string>> exchangeRemoveMailboxPermissionAccessRights, Expression<Func<string>> exchangeRemoveMailboxPermissionWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeRemoveMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeRemoveMailboxPermission = new JObject();
            var exchangeRemoveMailboxPermissionpropCount = 0;
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["Identity"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionIdentity);
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["User"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionUser);
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionAccessRights);
            exchangeRemoveMailboxPermissionpropCount++;
            exchangeRemoveMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeRemoveMailboxPermissionWorkflow);
            if (exchangeRemoveMailboxPermissionpropCount > 0)
            {
                callPayload.Body = exchangeRemoveMailboxPermission;
            }

            return new ApiConnectionAction<ExchangeRemoveMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse> ExchangeDisableMailbox(Expression<Func<string>> exchangeDisableMailboxIdentity, Expression<Func<string>> exchangeDisableMailboxWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDisableMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDisableMailbox = new JObject();
            var exchangeDisableMailboxpropCount = 0;
            exchangeDisableMailboxpropCount++;
            exchangeDisableMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeDisableMailboxIdentity);
            exchangeDisableMailboxpropCount++;
            exchangeDisableMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeDisableMailboxWorkflow);
            if (exchangeDisableMailboxpropCount > 0)
            {
                callPayload.Body = exchangeDisableMailbox;
            }

            return new ApiConnectionAction<ExchangeDisableMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse> ExchangeDisableRemoteMailbox(Expression<Func<string>> exchangeDisableRemoteMailboxIdentity, Expression<Func<string>> exchangeDisableRemoteMailboxWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDisableRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDisableRemoteMailbox = new JObject();
            var exchangeDisableRemoteMailboxpropCount = 0;
            exchangeDisableRemoteMailboxpropCount++;
            exchangeDisableRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeDisableRemoteMailboxIdentity);
            exchangeDisableRemoteMailboxpropCount++;
            exchangeDisableRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeDisableRemoteMailboxWorkflow);
            if (exchangeDisableRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeDisableRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeDisableRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse> ExchangeEnableMailbox(Expression<Func<string>> exchangeEnableMailboxIdentity, Expression<Func<string>> exchangeEnableMailboxWorkflow, Expression<Func<string>> exchangeEnableMailboxAlias = null, Expression<Func<string>> exchangeEnableMailboxDisplayName = null, Expression<Func<string>> exchangeEnableMailboxLinkedDomainController = null, Expression<Func<string>> exchangeEnableMailboxLinkedMasterAccount = null, Expression<Func<string>> exchangeEnableMailboxDatabase = null, Expression<Func<string>> exchangeEnableMailboxPrimarySmtpAddress = null, Expression<Func<bool>> exchangeEnableMailboxEmailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeEnableMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeEnableMailbox = new JObject();
            var exchangeEnableMailboxpropCount = 0;
            exchangeEnableMailboxpropCount++;
            exchangeEnableMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeEnableMailboxIdentity);
            if (exchangeEnableMailboxAlias != null)
            {
                exchangeEnableMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeEnableMailboxAlias);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxDisplayName != null)
            {
                exchangeEnableMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeEnableMailboxDisplayName);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxLinkedDomainController != null)
            {
                exchangeEnableMailbox["LinkedDomainController"] = ExpressionConverter.ConvertO(exchangeEnableMailboxLinkedDomainController);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxLinkedMasterAccount != null)
            {
                exchangeEnableMailbox["LinkedMasterAccount"] = ExpressionConverter.ConvertO(exchangeEnableMailboxLinkedMasterAccount);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxDatabase != null)
            {
                exchangeEnableMailbox["Database"] = ExpressionConverter.ConvertO(exchangeEnableMailboxDatabase);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxPrimarySmtpAddress != null)
            {
                exchangeEnableMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeEnableMailboxPrimarySmtpAddress);
                exchangeEnableMailboxpropCount++;
            }

            if (exchangeEnableMailboxEmailAddressPolicyEnabled != null)
            {
                exchangeEnableMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeEnableMailboxEmailAddressPolicyEnabled);
                exchangeEnableMailboxpropCount++;
            }

            exchangeEnableMailboxpropCount++;
            exchangeEnableMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeEnableMailboxWorkflow);
            if (exchangeEnableMailboxpropCount > 0)
            {
                callPayload.Body = exchangeEnableMailbox;
            }

            return new ApiConnectionAction<ExchangeEnableMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse> ExchangeEnableRemoteMailbox(Expression<Func<string>> exchangeEnableRemoteMailboxIdentity, Expression<Func<string>> exchangeEnableRemoteMailboxWorkflow, Expression<Func<string>> exchangeEnableRemoteMailboxAlias = null, Expression<Func<string>> exchangeEnableRemoteMailboxDisplayName = null, Expression<Func<string>> exchangeEnableRemoteMailboxRemoteRoutingAddress = null, Expression<Func<string>> exchangeEnableRemoteMailboxPrimarySmtpAddress = null, Expression<Func<bool>> exchangeEnableRemoteMailboxArchive = null, Expression<Func<bool>> exchangeEnableRemoteMailboxEmailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeEnableRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeEnableRemoteMailbox = new JObject();
            var exchangeEnableRemoteMailboxpropCount = 0;
            exchangeEnableRemoteMailboxpropCount++;
            exchangeEnableRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxIdentity);
            if (exchangeEnableRemoteMailboxAlias != null)
            {
                exchangeEnableRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxAlias);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxDisplayName != null)
            {
                exchangeEnableRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxDisplayName);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxRemoteRoutingAddress != null)
            {
                exchangeEnableRemoteMailbox["RemoteRoutingAddress"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxRemoteRoutingAddress);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxPrimarySmtpAddress != null)
            {
                exchangeEnableRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxPrimarySmtpAddress);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxArchive != null)
            {
                exchangeEnableRemoteMailbox["Archive"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxArchive);
                exchangeEnableRemoteMailboxpropCount++;
            }

            if (exchangeEnableRemoteMailboxEmailAddressPolicyEnabled != null)
            {
                exchangeEnableRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxEmailAddressPolicyEnabled);
                exchangeEnableRemoteMailboxpropCount++;
            }

            exchangeEnableRemoteMailboxpropCount++;
            exchangeEnableRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeEnableRemoteMailboxWorkflow);
            if (exchangeEnableRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeEnableRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeEnableRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse> ExchangeGetRemoteMailbox(Expression<Func<string>> exchangeGetRemoteMailboxWorkflow, Expression<Func<string>> exchangeGetRemoteMailboxIdentity = null, Expression<Func<string>> exchangeGetRemoteMailboxFilterPropertyName = null, Expression<Func<exchangeGetRemoteMailboxFilterPropertyComparisonInput>> exchangeGetRemoteMailboxFilterPropertyComparison = null, Expression<Func<string>> exchangeGetRemoteMailboxFilterPropertyValue = null, Expression<Func<bool>> exchangeGetRemoteMailboxNoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetRemoteMailbox = new JObject();
            var exchangeGetRemoteMailboxpropCount = 0;
            if (exchangeGetRemoteMailboxIdentity != null)
            {
                exchangeGetRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxIdentity);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxFilterPropertyName != null)
            {
                exchangeGetRemoteMailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxFilterPropertyName);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxFilterPropertyComparison != null)
            {
                exchangeGetRemoteMailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxFilterPropertyComparison);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxFilterPropertyValue != null)
            {
                exchangeGetRemoteMailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxFilterPropertyValue);
                exchangeGetRemoteMailboxpropCount++;
            }

            if (exchangeGetRemoteMailboxNoResultIsAnException != null)
            {
                exchangeGetRemoteMailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxNoResultIsAnException);
                exchangeGetRemoteMailboxpropCount++;
            }

            exchangeGetRemoteMailboxpropCount++;
            exchangeGetRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxWorkflow);
            if (exchangeGetRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeGetRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeGetRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse> ExchangeDoesRemoteMailboxExist(Expression<Func<string>> exchangeDoesRemoteMailboxExistWorkflow, Expression<Func<string>> exchangeDoesRemoteMailboxExistIdentity = null, Expression<Func<string>> exchangeDoesRemoteMailboxExistFilterPropertyName = null, Expression<Func<exchangeDoesRemoteMailboxExistFilterPropertyComparisonInput>> exchangeDoesRemoteMailboxExistFilterPropertyComparison = null, Expression<Func<string>> exchangeDoesRemoteMailboxExistFilterPropertyValue = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeDoesRemoteMailboxExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeDoesRemoteMailboxExist = new JObject();
            var exchangeDoesRemoteMailboxExistpropCount = 0;
            if (exchangeDoesRemoteMailboxExistIdentity != null)
            {
                exchangeDoesRemoteMailboxExist["Identity"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistIdentity);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            if (exchangeDoesRemoteMailboxExistFilterPropertyName != null)
            {
                exchangeDoesRemoteMailboxExist["FilterPropertyName"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistFilterPropertyName);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            if (exchangeDoesRemoteMailboxExistFilterPropertyComparison != null)
            {
                exchangeDoesRemoteMailboxExist["FilterPropertyComparison"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistFilterPropertyComparison);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            if (exchangeDoesRemoteMailboxExistFilterPropertyValue != null)
            {
                exchangeDoesRemoteMailboxExist["FilterPropertyValue"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistFilterPropertyValue);
                exchangeDoesRemoteMailboxExistpropCount++;
            }

            exchangeDoesRemoteMailboxExistpropCount++;
            exchangeDoesRemoteMailboxExist["Workflow"] = ExpressionConverter.ConvertO(exchangeDoesRemoteMailboxExistWorkflow);
            if (exchangeDoesRemoteMailboxExistpropCount > 0)
            {
                callPayload.Body = exchangeDoesRemoteMailboxExist;
            }

            return new ApiConnectionAction<ExchangeDoesRemoteMailboxExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse> ExchangeNewMailbox(Expression<Func<string>> exchangeNewMailboxName, Expression<Func<string>> exchangeNewMailboxUserPrincipalName, Expression<Func<string>> exchangeNewMailboxWorkflow, Expression<Func<string>> exchangeNewMailboxFirstName = null, Expression<Func<string>> exchangeNewMailboxLastName = null, Expression<Func<string>> exchangeNewMailboxOrganizationalUnit = null, Expression<Func<string>> exchangeNewMailboxDisplayName = null, Expression<Func<string>> exchangeNewMailboxAlias = null, Expression<Func<string>> exchangeNewMailboxPrimarySmtpAddress = null, Expression<Func<string>> exchangeNewMailboxSamAccountName = null, Expression<Func<string>> exchangeNewMailboxPassword = null, Expression<Func<bool>> exchangeNewMailboxAccountPasswordIsStoredPassword = null, Expression<Func<bool>> exchangeNewMailboxResetPasswordOnNextLogon = null, Expression<Func<string>> exchangeNewMailboxDatabase = null, Expression<Func<bool>> exchangeNewMailboxSharedMailbox = null, Expression<Func<bool>> exchangeNewMailboxEmailAddressPolicyEnabled = null, Expression<Func<bool>> exchangeNewMailboxArchive = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeNewMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeNewMailbox = new JObject();
            var exchangeNewMailboxpropCount = 0;
            if (exchangeNewMailboxFirstName != null)
            {
                exchangeNewMailbox["FirstName"] = ExpressionConverter.ConvertO(exchangeNewMailboxFirstName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxLastName != null)
            {
                exchangeNewMailbox["LastName"] = ExpressionConverter.ConvertO(exchangeNewMailboxLastName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxOrganizationalUnit != null)
            {
                exchangeNewMailbox["OrganizationalUnit"] = ExpressionConverter.ConvertO(exchangeNewMailboxOrganizationalUnit);
                exchangeNewMailboxpropCount++;
            }

            exchangeNewMailboxpropCount++;
            exchangeNewMailbox["Name"] = ExpressionConverter.ConvertO(exchangeNewMailboxName);
            if (exchangeNewMailboxDisplayName != null)
            {
                exchangeNewMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeNewMailboxDisplayName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxAlias != null)
            {
                exchangeNewMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeNewMailboxAlias);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxPrimarySmtpAddress != null)
            {
                exchangeNewMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeNewMailboxPrimarySmtpAddress);
                exchangeNewMailboxpropCount++;
            }

            exchangeNewMailboxpropCount++;
            exchangeNewMailbox["UserPrincipalName"] = ExpressionConverter.ConvertO(exchangeNewMailboxUserPrincipalName);
            if (exchangeNewMailboxSamAccountName != null)
            {
                exchangeNewMailbox["SamAccountName"] = ExpressionConverter.ConvertO(exchangeNewMailboxSamAccountName);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxPassword != null)
            {
                exchangeNewMailbox["Password"] = ExpressionConverter.ConvertO(exchangeNewMailboxPassword);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxAccountPasswordIsStoredPassword != null)
            {
                exchangeNewMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(exchangeNewMailboxAccountPasswordIsStoredPassword);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxResetPasswordOnNextLogon != null)
            {
                exchangeNewMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(exchangeNewMailboxResetPasswordOnNextLogon);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxDatabase != null)
            {
                exchangeNewMailbox["Database"] = ExpressionConverter.ConvertO(exchangeNewMailboxDatabase);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxSharedMailbox != null)
            {
                exchangeNewMailbox["SharedMailbox"] = ExpressionConverter.ConvertO(exchangeNewMailboxSharedMailbox);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxEmailAddressPolicyEnabled != null)
            {
                exchangeNewMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeNewMailboxEmailAddressPolicyEnabled);
                exchangeNewMailboxpropCount++;
            }

            if (exchangeNewMailboxArchive != null)
            {
                exchangeNewMailbox["Archive"] = ExpressionConverter.ConvertO(exchangeNewMailboxArchive);
                exchangeNewMailboxpropCount++;
            }

            exchangeNewMailboxpropCount++;
            exchangeNewMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeNewMailboxWorkflow);
            if (exchangeNewMailboxpropCount > 0)
            {
                callPayload.Body = exchangeNewMailbox;
            }

            return new ApiConnectionAction<ExchangeNewMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse> ExchangeNewRemoteMailbox(Expression<Func<string>> exchangeNewRemoteMailboxName, Expression<Func<string>> exchangeNewRemoteMailboxUserPrincipalName, Expression<Func<string>> exchangeNewRemoteMailboxWorkflow, Expression<Func<string>> exchangeNewRemoteMailboxFirstName = null, Expression<Func<string>> exchangeNewRemoteMailboxLastName = null, Expression<Func<string>> exchangeNewRemoteMailboxOnPremisesOrganizationalUnit = null, Expression<Func<string>> exchangeNewRemoteMailboxDisplayName = null, Expression<Func<string>> exchangeNewRemoteMailboxRemoteRoutingAddress = null, Expression<Func<string>> exchangeNewRemoteMailboxAlias = null, Expression<Func<string>> exchangeNewRemoteMailboxPrimarySmtpAddress = null, Expression<Func<string>> exchangeNewRemoteMailboxSamAccountName = null, Expression<Func<string>> exchangeNewRemoteMailboxPassword = null, Expression<Func<bool>> exchangeNewRemoteMailboxAccountPasswordIsStoredPassword = null, Expression<Func<bool>> exchangeNewRemoteMailboxResetPasswordOnNextLogon = null, Expression<Func<bool>> exchangeNewRemoteMailboxSharedMailbox = null, Expression<Func<bool>> exchangeNewRemoteMailboxEmailAddressPolicyEnabled = null, Expression<Func<bool>> exchangeNewRemoteMailboxArchive = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeNewRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeNewRemoteMailbox = new JObject();
            var exchangeNewRemoteMailboxpropCount = 0;
            if (exchangeNewRemoteMailboxFirstName != null)
            {
                exchangeNewRemoteMailbox["FirstName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxFirstName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxLastName != null)
            {
                exchangeNewRemoteMailbox["LastName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxLastName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxOnPremisesOrganizationalUnit != null)
            {
                exchangeNewRemoteMailbox["OnPremisesOrganizationalUnit"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxOnPremisesOrganizationalUnit);
                exchangeNewRemoteMailboxpropCount++;
            }

            exchangeNewRemoteMailboxpropCount++;
            exchangeNewRemoteMailbox["Name"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxName);
            if (exchangeNewRemoteMailboxDisplayName != null)
            {
                exchangeNewRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxDisplayName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxRemoteRoutingAddress != null)
            {
                exchangeNewRemoteMailbox["RemoteRoutingAddress"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxRemoteRoutingAddress);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxAlias != null)
            {
                exchangeNewRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxAlias);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxPrimarySmtpAddress != null)
            {
                exchangeNewRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxPrimarySmtpAddress);
                exchangeNewRemoteMailboxpropCount++;
            }

            exchangeNewRemoteMailboxpropCount++;
            exchangeNewRemoteMailbox["UserPrincipalName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxUserPrincipalName);
            if (exchangeNewRemoteMailboxSamAccountName != null)
            {
                exchangeNewRemoteMailbox["SamAccountName"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxSamAccountName);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxPassword != null)
            {
                exchangeNewRemoteMailbox["Password"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxPassword);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxAccountPasswordIsStoredPassword != null)
            {
                exchangeNewRemoteMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxAccountPasswordIsStoredPassword);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxResetPasswordOnNextLogon != null)
            {
                exchangeNewRemoteMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxResetPasswordOnNextLogon);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxSharedMailbox != null)
            {
                exchangeNewRemoteMailbox["SharedMailbox"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxSharedMailbox);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxEmailAddressPolicyEnabled != null)
            {
                exchangeNewRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxEmailAddressPolicyEnabled);
                exchangeNewRemoteMailboxpropCount++;
            }

            if (exchangeNewRemoteMailboxArchive != null)
            {
                exchangeNewRemoteMailbox["Archive"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxArchive);
                exchangeNewRemoteMailboxpropCount++;
            }

            exchangeNewRemoteMailboxpropCount++;
            exchangeNewRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeNewRemoteMailboxWorkflow);
            if (exchangeNewRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeNewRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeNewRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse> ExchangeSetADServerToViewEntireForest(Expression<Func<bool>> exchangeSetADServerToViewEntireForestViewEntireForest, Expression<Func<string>> exchangeSetADServerToViewEntireForestWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetADServerToViewEntireForest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetADServerToViewEntireForest = new JObject();
            var exchangeSetADServerToViewEntireForestpropCount = 0;
            exchangeSetADServerToViewEntireForestpropCount++;
            exchangeSetADServerToViewEntireForest["ViewEntireForest"] = ExpressionConverter.ConvertO(exchangeSetADServerToViewEntireForestViewEntireForest);
            exchangeSetADServerToViewEntireForestpropCount++;
            exchangeSetADServerToViewEntireForest["Workflow"] = ExpressionConverter.ConvertO(exchangeSetADServerToViewEntireForestWorkflow);
            if (exchangeSetADServerToViewEntireForestpropCount > 0)
            {
                callPayload.Body = exchangeSetADServerToViewEntireForest;
            }

            return new ApiConnectionAction<ExchangeSetADServerToViewEntireForestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse> ExchangeSetMailbox(Expression<Func<string>> exchangeSetMailboxIdentity, Expression<Func<string>> exchangeSetMailboxWorkflow, Expression<Func<bool>> exchangeSetMailboxAccountDisabled = null, Expression<Func<string>> exchangeSetMailboxAlias = null, Expression<Func<string>> exchangeSetMailboxDisplayName = null, Expression<Func<string>> exchangeSetMailboxPrimarySmtpAddress = null, Expression<Func<bool>> exchangeSetMailboxHiddenFromAddressListsEnabled = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute1 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute2 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute3 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute4 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute5 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute6 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute7 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute8 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute9 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute10 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute11 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute12 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute13 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute14 = null, Expression<Func<string>> exchangeSetMailboxCustomAttribute15 = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailbox = new JObject();
            var exchangeSetMailboxpropCount = 0;
            exchangeSetMailboxpropCount++;
            exchangeSetMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxIdentity);
            if (exchangeSetMailboxAccountDisabled != null)
            {
                exchangeSetMailbox["AccountDisabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxAccountDisabled);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxAlias != null)
            {
                exchangeSetMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeSetMailboxAlias);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxDisplayName != null)
            {
                exchangeSetMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeSetMailboxDisplayName);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxPrimarySmtpAddress != null)
            {
                exchangeSetMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetMailboxPrimarySmtpAddress);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxHiddenFromAddressListsEnabled != null)
            {
                exchangeSetMailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxHiddenFromAddressListsEnabled);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute1 != null)
            {
                exchangeSetMailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute1);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute2 != null)
            {
                exchangeSetMailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute2);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute3 != null)
            {
                exchangeSetMailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute3);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute4 != null)
            {
                exchangeSetMailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute4);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute5 != null)
            {
                exchangeSetMailbox["CustomAttribute5"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute5);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute6 != null)
            {
                exchangeSetMailbox["CustomAttribute6"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute6);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute7 != null)
            {
                exchangeSetMailbox["CustomAttribute7"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute7);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute8 != null)
            {
                exchangeSetMailbox["CustomAttribute8"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute8);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute9 != null)
            {
                exchangeSetMailbox["CustomAttribute9"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute9);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute10 != null)
            {
                exchangeSetMailbox["CustomAttribute10"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute10);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute11 != null)
            {
                exchangeSetMailbox["CustomAttribute11"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute11);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute12 != null)
            {
                exchangeSetMailbox["CustomAttribute12"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute12);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute13 != null)
            {
                exchangeSetMailbox["CustomAttribute13"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute13);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute14 != null)
            {
                exchangeSetMailbox["CustomAttribute14"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute14);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxCustomAttribute15 != null)
            {
                exchangeSetMailbox["CustomAttribute15"] = ExpressionConverter.ConvertO(exchangeSetMailboxCustomAttribute15);
                exchangeSetMailboxpropCount++;
            }

            if (exchangeSetMailboxEmailAddressPolicyEnabled != null)
            {
                exchangeSetMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressPolicyEnabled);
                exchangeSetMailboxpropCount++;
            }

            exchangeSetMailboxpropCount++;
            exchangeSetMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxWorkflow);
            if (exchangeSetMailboxpropCount > 0)
            {
                callPayload.Body = exchangeSetMailbox;
            }

            return new ApiConnectionAction<ExchangeSetMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse> ExchangeSetMailboxEmailAddresses(Expression<Func<string>> exchangeSetMailboxEmailAddressesIdentity, Expression<Func<string>> exchangeSetMailboxEmailAddressesWorkflow, Expression<Func<string>> exchangeSetMailboxEmailAddressesAlias = null, Expression<Func<string>> exchangeSetMailboxEmailAddressesPrimarySmtpAddress = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressesEmailAddressPolicyEnabled = null, Expression<Func<string[]>> exchangeSetMailboxEmailAddressesEmailAddressesToAddList = null, Expression<Func<bool>> exchangeSetMailboxEmailAddressesReplaceEmailAddresses = null, Expression<Func<string[]>> exchangeSetMailboxEmailAddressesEmailAddressesToRemoveList = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailboxEmailAddresses = new JObject();
            var exchangeSetMailboxEmailAddressespropCount = 0;
            exchangeSetMailboxEmailAddressespropCount++;
            exchangeSetMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesIdentity);
            if (exchangeSetMailboxEmailAddressesAlias != null)
            {
                exchangeSetMailboxEmailAddresses["Alias"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesAlias);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesPrimarySmtpAddress != null)
            {
                exchangeSetMailboxEmailAddresses["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesPrimarySmtpAddress);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesEmailAddressPolicyEnabled != null)
            {
                exchangeSetMailboxEmailAddresses["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesEmailAddressPolicyEnabled);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesEmailAddressesToAddList != null)
            {
                exchangeSetMailboxEmailAddresses["EmailAddressesToAddList"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesEmailAddressesToAddList);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesReplaceEmailAddresses != null)
            {
                exchangeSetMailboxEmailAddresses["ReplaceEmailAddresses"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesReplaceEmailAddresses);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            if (exchangeSetMailboxEmailAddressesEmailAddressesToRemoveList != null)
            {
                exchangeSetMailboxEmailAddresses["EmailAddressesToRemoveList"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesEmailAddressesToRemoveList);
                exchangeSetMailboxEmailAddressespropCount++;
            }

            exchangeSetMailboxEmailAddressespropCount++;
            exchangeSetMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxEmailAddressesWorkflow);
            if (exchangeSetMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeSetMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeSetMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse> ExchangeGetMailboxEmailAddresses(Expression<Func<string>> exchangeGetMailboxEmailAddressesIdentity, Expression<Func<string>> exchangeGetMailboxEmailAddressesWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetMailboxEmailAddresses = new JObject();
            var exchangeGetMailboxEmailAddressespropCount = 0;
            exchangeGetMailboxEmailAddressespropCount++;
            exchangeGetMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeGetMailboxEmailAddressesIdentity);
            exchangeGetMailboxEmailAddressespropCount++;
            exchangeGetMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeGetMailboxEmailAddressesWorkflow);
            if (exchangeGetMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeGetMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeGetMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse> ExchangeSetRemoteMailboxEmailAddresses(Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesIdentity, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesWorkflow, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesAlias = null, Expression<Func<string>> exchangeSetRemoteMailboxEmailAddressesPrimarySmtpAddress = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressesEmailAddressPolicyEnabled = null, Expression<Func<string[]>> exchangeSetRemoteMailboxEmailAddressesEmailAddressesToAddList = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressesReplaceEmailAddresses = null, Expression<Func<string[]>> exchangeSetRemoteMailboxEmailAddressesEmailAddressesToRemoveList = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetRemoteMailboxEmailAddresses = new JObject();
            var exchangeSetRemoteMailboxEmailAddressespropCount = 0;
            exchangeSetRemoteMailboxEmailAddressespropCount++;
            exchangeSetRemoteMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesIdentity);
            if (exchangeSetRemoteMailboxEmailAddressesAlias != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["Alias"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesAlias);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesPrimarySmtpAddress != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesPrimarySmtpAddress);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesEmailAddressPolicyEnabled != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesEmailAddressPolicyEnabled);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesEmailAddressesToAddList != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToAddList"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesEmailAddressesToAddList);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesReplaceEmailAddresses != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["ReplaceEmailAddresses"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesReplaceEmailAddresses);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressesEmailAddressesToRemoveList != null)
            {
                exchangeSetRemoteMailboxEmailAddresses["EmailAddressesToRemoveList"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesEmailAddressesToRemoveList);
                exchangeSetRemoteMailboxEmailAddressespropCount++;
            }

            exchangeSetRemoteMailboxEmailAddressespropCount++;
            exchangeSetRemoteMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressesWorkflow);
            if (exchangeSetRemoteMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeSetRemoteMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse> ExchangeGetRemoteMailboxEmailAddresses(Expression<Func<string>> exchangeGetRemoteMailboxEmailAddressesIdentity, Expression<Func<string>> exchangeGetRemoteMailboxEmailAddressesWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailboxEmailAddresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeGetRemoteMailboxEmailAddresses = new JObject();
            var exchangeGetRemoteMailboxEmailAddressespropCount = 0;
            exchangeGetRemoteMailboxEmailAddressespropCount++;
            exchangeGetRemoteMailboxEmailAddresses["Identity"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxEmailAddressesIdentity);
            exchangeGetRemoteMailboxEmailAddressespropCount++;
            exchangeGetRemoteMailboxEmailAddresses["Workflow"] = ExpressionConverter.ConvertO(exchangeGetRemoteMailboxEmailAddressesWorkflow);
            if (exchangeGetRemoteMailboxEmailAddressespropCount > 0)
            {
                callPayload.Body = exchangeGetRemoteMailboxEmailAddresses;
            }

            return new ApiConnectionAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse> ExchangeResetMailboxAttributes(Expression<Func<string>> exchangeResetMailboxAttributesIdentity, Expression<Func<string>> exchangeResetMailboxAttributesWorkflow, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute1 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute2 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute3 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute4 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute5 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute6 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute7 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute8 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute9 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute10 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute11 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute12 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute13 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute14 = null, Expression<Func<bool>> exchangeResetMailboxAttributesResetCustomAttribute15 = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeResetMailboxAttributes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeResetMailboxAttributes = new JObject();
            var exchangeResetMailboxAttributespropCount = 0;
            exchangeResetMailboxAttributespropCount++;
            exchangeResetMailboxAttributes["Identity"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesIdentity);
            if (exchangeResetMailboxAttributesResetCustomAttribute1 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute1"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute1);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute2 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute2"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute2);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute3 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute3"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute3);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute4 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute4"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute4);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute5 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute5"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute5);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute6 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute6"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute6);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute7 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute7"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute7);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute8 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute8"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute8);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute9 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute9"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute9);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute10 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute10"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute10);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute11 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute11"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute11);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute12 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute12"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute12);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute13 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute13"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute13);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute14 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute14"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute14);
                exchangeResetMailboxAttributespropCount++;
            }

            if (exchangeResetMailboxAttributesResetCustomAttribute15 != null)
            {
                exchangeResetMailboxAttributes["ResetCustomAttribute15"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesResetCustomAttribute15);
                exchangeResetMailboxAttributespropCount++;
            }

            exchangeResetMailboxAttributespropCount++;
            exchangeResetMailboxAttributes["Workflow"] = ExpressionConverter.ConvertO(exchangeResetMailboxAttributesWorkflow);
            if (exchangeResetMailboxAttributespropCount > 0)
            {
                callPayload.Body = exchangeResetMailboxAttributes;
            }

            return new ApiConnectionAction<ExchangeResetMailboxAttributesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse> ExchangeResetRemoteMailboxAttributes(Expression<Func<string>> exchangeResetRemoteMailboxAttributesIdentity, Expression<Func<string>> exchangeResetRemoteMailboxAttributesWorkflow, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute1 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute2 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute3 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute4 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute5 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute6 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute7 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute8 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute9 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute10 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute11 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute12 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute13 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute14 = null, Expression<Func<bool>> exchangeResetRemoteMailboxAttributesResetCustomAttribute15 = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeResetRemoteMailboxAttributes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeResetRemoteMailboxAttributes = new JObject();
            var exchangeResetRemoteMailboxAttributespropCount = 0;
            exchangeResetRemoteMailboxAttributespropCount++;
            exchangeResetRemoteMailboxAttributes["Identity"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesIdentity);
            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute1 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute1"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute1);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute2 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute2"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute2);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute3 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute3"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute3);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute4 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute4"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute4);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute5 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute5"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute5);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute6 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute6"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute6);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute7 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute7"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute7);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute8 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute8"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute8);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute9 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute9"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute9);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute10 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute10"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute10);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute11 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute11"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute11);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute12 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute12"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute12);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute13 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute13"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute13);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute14 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute14"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute14);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            if (exchangeResetRemoteMailboxAttributesResetCustomAttribute15 != null)
            {
                exchangeResetRemoteMailboxAttributes["ResetCustomAttribute15"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesResetCustomAttribute15);
                exchangeResetRemoteMailboxAttributespropCount++;
            }

            exchangeResetRemoteMailboxAttributespropCount++;
            exchangeResetRemoteMailboxAttributes["Workflow"] = ExpressionConverter.ConvertO(exchangeResetRemoteMailboxAttributesWorkflow);
            if (exchangeResetRemoteMailboxAttributespropCount > 0)
            {
                callPayload.Body = exchangeResetRemoteMailboxAttributes;
            }

            return new ApiConnectionAction<ExchangeResetRemoteMailboxAttributesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse> ExchangeSetRemoteMailbox(Expression<Func<string>> exchangeSetRemoteMailboxIdentity, Expression<Func<string>> exchangeSetRemoteMailboxWorkflow, Expression<Func<string>> exchangeSetRemoteMailboxAlias = null, Expression<Func<string>> exchangeSetRemoteMailboxDisplayName = null, Expression<Func<string>> exchangeSetRemoteMailboxPrimarySmtpAddress = null, Expression<Func<exchangeSetRemoteMailboxTypeInput>> exchangeSetRemoteMailboxType = null, Expression<Func<bool>> exchangeSetRemoteMailboxHiddenFromAddressListsEnabled = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute1 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute2 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute3 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute4 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute5 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute6 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute7 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute8 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute9 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute10 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute11 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute12 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute13 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute14 = null, Expression<Func<string>> exchangeSetRemoteMailboxCustomAttribute15 = null, Expression<Func<bool>> exchangeSetRemoteMailboxEmailAddressPolicyEnabled = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetRemoteMailbox = new JObject();
            var exchangeSetRemoteMailboxpropCount = 0;
            exchangeSetRemoteMailboxpropCount++;
            exchangeSetRemoteMailbox["Identity"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxIdentity);
            if (exchangeSetRemoteMailboxAlias != null)
            {
                exchangeSetRemoteMailbox["Alias"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxAlias);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxDisplayName != null)
            {
                exchangeSetRemoteMailbox["DisplayName"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxDisplayName);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxPrimarySmtpAddress != null)
            {
                exchangeSetRemoteMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxPrimarySmtpAddress);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxType != null)
            {
                exchangeSetRemoteMailbox["Type"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxType);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxHiddenFromAddressListsEnabled != null)
            {
                exchangeSetRemoteMailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxHiddenFromAddressListsEnabled);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute1 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute1);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute2 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute2);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute3 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute3);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute4 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute4);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute5 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute5"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute5);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute6 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute6"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute6);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute7 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute7"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute7);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute8 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute8"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute8);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute9 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute9"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute9);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute10 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute10"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute10);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute11 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute11"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute11);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute12 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute12"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute12);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute13 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute13"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute13);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute14 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute14"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute14);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxCustomAttribute15 != null)
            {
                exchangeSetRemoteMailbox["CustomAttribute15"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxCustomAttribute15);
                exchangeSetRemoteMailboxpropCount++;
            }

            if (exchangeSetRemoteMailboxEmailAddressPolicyEnabled != null)
            {
                exchangeSetRemoteMailbox["EmailAddressPolicyEnabled"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxEmailAddressPolicyEnabled);
                exchangeSetRemoteMailboxpropCount++;
            }

            exchangeSetRemoteMailboxpropCount++;
            exchangeSetRemoteMailbox["Workflow"] = ExpressionConverter.ConvertO(exchangeSetRemoteMailboxWorkflow);
            if (exchangeSetRemoteMailboxpropCount > 0)
            {
                callPayload.Body = exchangeSetRemoteMailbox;
            }

            return new ApiConnectionAction<ExchangeSetRemoteMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse> ExchangeSetMailboxSendOnBehalfOfPermission(Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionIdentity, Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionGrantSendOnBehalfTo, Expression<Func<string>> exchangeSetMailboxSendOnBehalfOfPermissionWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxSendOnBehalfOfPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailboxSendOnBehalfOfPermission = new JObject();
            var exchangeSetMailboxSendOnBehalfOfPermissionpropCount = 0;
            exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
            exchangeSetMailboxSendOnBehalfOfPermission["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxSendOnBehalfOfPermissionIdentity);
            exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
            exchangeSetMailboxSendOnBehalfOfPermission["GrantSendOnBehalfTo"] = ExpressionConverter.ConvertO(exchangeSetMailboxSendOnBehalfOfPermissionGrantSendOnBehalfTo);
            exchangeSetMailboxSendOnBehalfOfPermissionpropCount++;
            exchangeSetMailboxSendOnBehalfOfPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxSendOnBehalfOfPermissionWorkflow);
            if (exchangeSetMailboxSendOnBehalfOfPermissionpropCount > 0)
            {
                callPayload.Body = exchangeSetMailboxSendOnBehalfOfPermission;
            }

            return new ApiConnectionAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse> ExchangeAddADPermission(Expression<Func<string>> exchangeAddADPermissionIdentity, Expression<Func<string>> exchangeAddADPermissionUser, Expression<Func<string>> exchangeAddADPermissionWorkflow, Expression<Func<string>> exchangeAddADPermissionAccessRights = null, Expression<Func<string>> exchangeAddADPermissionExtendedRights = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeAddADPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeAddADPermission = new JObject();
            var exchangeAddADPermissionpropCount = 0;
            exchangeAddADPermissionpropCount++;
            exchangeAddADPermission["Identity"] = ExpressionConverter.ConvertO(exchangeAddADPermissionIdentity);
            exchangeAddADPermissionpropCount++;
            exchangeAddADPermission["User"] = ExpressionConverter.ConvertO(exchangeAddADPermissionUser);
            if (exchangeAddADPermissionAccessRights != null)
            {
                exchangeAddADPermission["AccessRights"] = ExpressionConverter.ConvertO(exchangeAddADPermissionAccessRights);
                exchangeAddADPermissionpropCount++;
            }

            if (exchangeAddADPermissionExtendedRights != null)
            {
                exchangeAddADPermission["ExtendedRights"] = ExpressionConverter.ConvertO(exchangeAddADPermissionExtendedRights);
                exchangeAddADPermissionpropCount++;
            }

            exchangeAddADPermissionpropCount++;
            exchangeAddADPermission["Workflow"] = ExpressionConverter.ConvertO(exchangeAddADPermissionWorkflow);
            if (exchangeAddADPermissionpropCount > 0)
            {
                callPayload.Body = exchangeAddADPermission;
            }

            return new ApiConnectionAction<ExchangeAddADPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse> ExchangeSetMailboxAutoReplyConfiguration(Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationIdentity, Expression<Func<exchangeSetMailboxAutoReplyConfigurationAutoReplyStateInput>> exchangeSetMailboxAutoReplyConfigurationAutoReplyState, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationWorkflow, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationInternalMessage = null, Expression<Func<exchangeSetMailboxAutoReplyConfigurationExternalAudienceInput>> exchangeSetMailboxAutoReplyConfigurationExternalAudience = null, Expression<Func<string>> exchangeSetMailboxAutoReplyConfigurationExternalMessage = null)
        {
            var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxAutoReplyConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exchangeSetMailboxAutoReplyConfiguration = new JObject();
            var exchangeSetMailboxAutoReplyConfigurationpropCount = 0;
            exchangeSetMailboxAutoReplyConfigurationpropCount++;
            exchangeSetMailboxAutoReplyConfiguration["Identity"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationIdentity);
            exchangeSetMailboxAutoReplyConfigurationpropCount++;
            exchangeSetMailboxAutoReplyConfiguration["AutoReplyState"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationAutoReplyState);
            if (exchangeSetMailboxAutoReplyConfigurationInternalMessage != null)
            {
                exchangeSetMailboxAutoReplyConfiguration["InternalMessage"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationInternalMessage);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
            }

            if (exchangeSetMailboxAutoReplyConfigurationExternalAudience != null)
            {
                exchangeSetMailboxAutoReplyConfiguration["ExternalAudience"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationExternalAudience);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
            }

            if (exchangeSetMailboxAutoReplyConfigurationExternalMessage != null)
            {
                exchangeSetMailboxAutoReplyConfiguration["ExternalMessage"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationExternalMessage);
                exchangeSetMailboxAutoReplyConfigurationpropCount++;
            }

            exchangeSetMailboxAutoReplyConfigurationpropCount++;
            exchangeSetMailboxAutoReplyConfiguration["Workflow"] = ExpressionConverter.ConvertO(exchangeSetMailboxAutoReplyConfigurationWorkflow);
            if (exchangeSetMailboxAutoReplyConfigurationpropCount > 0)
            {
                callPayload.Body = exchangeSetMailboxAutoReplyConfiguration;
            }

            return new ApiConnectionAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse> IsAzureADv2PowerShellModuleInstalled(Expression<Func<string>> isAzureADv2PowerShellModuleInstalledWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellModuleInstalled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isAzureADv2PowerShellModuleInstalled = new JObject();
            var isAzureADv2PowerShellModuleInstalledpropCount = 0;
            isAzureADv2PowerShellModuleInstalledpropCount++;
            isAzureADv2PowerShellModuleInstalled["Workflow"] = ExpressionConverter.ConvertO(isAzureADv2PowerShellModuleInstalledWorkflow);
            if (isAzureADv2PowerShellModuleInstalledpropCount > 0)
            {
                callPayload.Body = isAzureADv2PowerShellModuleInstalled;
            }

            return new ApiConnectionAction<IsAzureADv2PowerShellModuleInstalledResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse> OpenAzureADv2PowerShellRunspace(Expression<Func<string>> openAzureADv2PowerShellRunspaceUsername, Expression<Func<string>> openAzureADv2PowerShellRunspacePassword, Expression<Func<string>> openAzureADv2PowerShellRunspaceWorkflow, Expression<Func<string>> openAzureADv2PowerShellRunspaceTenantId = null, Expression<Func<openAzureADv2PowerShellRunspaceAPIToUseInput>> openAzureADv2PowerShellRunspaceAPIToUse = null, Expression<Func<string>> openAzureADv2PowerShellRunspaceAuthenticationScope = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openAzureADv2PowerShellRunspace = new JObject();
            var openAzureADv2PowerShellRunspacepropCount = 0;
            openAzureADv2PowerShellRunspacepropCount++;
            openAzureADv2PowerShellRunspace["Username"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceUsername);
            openAzureADv2PowerShellRunspacepropCount++;
            openAzureADv2PowerShellRunspace["Password"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspacePassword);
            if (openAzureADv2PowerShellRunspaceTenantId != null)
            {
                openAzureADv2PowerShellRunspace["TenantId"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceTenantId);
                openAzureADv2PowerShellRunspacepropCount++;
            }

            if (openAzureADv2PowerShellRunspaceAPIToUse != null)
            {
                openAzureADv2PowerShellRunspace["APIToUse"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceAPIToUse);
                openAzureADv2PowerShellRunspacepropCount++;
            }

            if (openAzureADv2PowerShellRunspaceAuthenticationScope != null)
            {
                openAzureADv2PowerShellRunspace["AuthenticationScope"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceAuthenticationScope);
                openAzureADv2PowerShellRunspacepropCount++;
            }

            openAzureADv2PowerShellRunspacepropCount++;
            openAzureADv2PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWorkflow);
            if (openAzureADv2PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openAzureADv2PowerShellRunspace;
            }

            return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse> OpenAzureADv2PowerShellRunspaceWithCertificate(Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateApplicationId, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateCertificateThumbprint, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateTenantId, Expression<Func<string>> openAzureADv2PowerShellRunspaceWithCertificateWorkflow, Expression<Func<openAzureADv2PowerShellRunspaceWithCertificateAPIToUseInput>> openAzureADv2PowerShellRunspaceWithCertificateAPIToUse = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspaceWithCertificate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openAzureADv2PowerShellRunspaceWithCertificate = new JObject();
            var openAzureADv2PowerShellRunspaceWithCertificatepropCount = 0;
            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["ApplicationId"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateApplicationId);
            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["CertificateThumbprint"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateCertificateThumbprint);
            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["TenantId"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateTenantId);
            if (openAzureADv2PowerShellRunspaceWithCertificateAPIToUse != null)
            {
                openAzureADv2PowerShellRunspaceWithCertificate["APIToUse"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateAPIToUse);
                openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            }

            openAzureADv2PowerShellRunspaceWithCertificatepropCount++;
            openAzureADv2PowerShellRunspaceWithCertificate["Workflow"] = ExpressionConverter.ConvertO(openAzureADv2PowerShellRunspaceWithCertificateWorkflow);
            if (openAzureADv2PowerShellRunspaceWithCertificatepropCount > 0)
            {
                callPayload.Body = openAzureADv2PowerShellRunspaceWithCertificate;
            }

            return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse> IsAzureADv2PowerShellRunspaceOpen(Expression<Func<string>> isAzureADv2PowerShellRunspaceOpenWorkflow, Expression<Func<bool>> isAzureADv2PowerShellRunspaceOpenRetrievePowerShellRunSpacePID = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellRunspaceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isAzureADv2PowerShellRunspaceOpen = new JObject();
            var isAzureADv2PowerShellRunspaceOpenpropCount = 0;
            if (isAzureADv2PowerShellRunspaceOpenRetrievePowerShellRunSpacePID != null)
            {
                isAzureADv2PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(isAzureADv2PowerShellRunspaceOpenRetrievePowerShellRunSpacePID);
                isAzureADv2PowerShellRunspaceOpenpropCount++;
            }

            isAzureADv2PowerShellRunspaceOpenpropCount++;
            isAzureADv2PowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isAzureADv2PowerShellRunspaceOpenWorkflow);
            if (isAzureADv2PowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isAzureADv2PowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsAzureADv2PowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse> RunAzureADv2PowerShellAutomationScript(Expression<Func<string>> runAzureADv2PowerShellAutomationScriptWorkflow, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptPowerShellScriptContents = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptIsNoResultAnError = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptReturnComplexTypes = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptReturnBooleanAsBoolean = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptReturnNumericAsDecimal = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptReturnDateAsDate = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptPropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptRunScriptAsThread = null, Expression<Func<int>> runAzureADv2PowerShellAutomationScriptRetrieveOutputDataFromThreadId = null, Expression<Func<int>> runAzureADv2PowerShellAutomationScriptSecondsToWaitForThread = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptScriptContainsStoredPassword = null, Expression<Func<bool>> runAzureADv2PowerShellAutomationScriptLogVerboseOutput = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptPropertyNamesToSerializeJSON = null, Expression<Func<string>> runAzureADv2PowerShellAutomationScriptPropertyTypesToSerializeJSON = null, Expression<Func<runAzureADv2PowerShellAutomationScriptPowerShellCommandParametersInputItem[]>> runAzureADv2PowerShellAutomationScriptPowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/RunAzureADv2PowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runAzureADv2PowerShellAutomationScript = new JObject();
            var runAzureADv2PowerShellAutomationScriptpropCount = 0;
            if (runAzureADv2PowerShellAutomationScriptPowerShellScriptContents != null)
            {
                runAzureADv2PowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptPowerShellScriptContents);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptIsNoResultAnError != null)
            {
                runAzureADv2PowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptIsNoResultAnError);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptReturnComplexTypes != null)
            {
                runAzureADv2PowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptReturnComplexTypes);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptReturnBooleanAsBoolean != null)
            {
                runAzureADv2PowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptReturnBooleanAsBoolean);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptReturnNumericAsDecimal != null)
            {
                runAzureADv2PowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptReturnNumericAsDecimal);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptReturnDateAsDate != null)
            {
                runAzureADv2PowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptReturnDateAsDate);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptPropertiesToReturnAsCollectionJSON != null)
            {
                runAzureADv2PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptPropertiesToReturnAsCollectionJSON);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptRunScriptAsThread != null)
            {
                runAzureADv2PowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptRunScriptAsThread);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptRetrieveOutputDataFromThreadId != null)
            {
                runAzureADv2PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptRetrieveOutputDataFromThreadId);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptSecondsToWaitForThread != null)
            {
                runAzureADv2PowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptSecondsToWaitForThread);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptScriptContainsStoredPassword != null)
            {
                runAzureADv2PowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptScriptContainsStoredPassword);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptLogVerboseOutput != null)
            {
                runAzureADv2PowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptLogVerboseOutput);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptPropertyNamesToSerializeJSON != null)
            {
                runAzureADv2PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptPropertyNamesToSerializeJSON);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptPropertyTypesToSerializeJSON != null)
            {
                runAzureADv2PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptPropertyTypesToSerializeJSON);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            if (runAzureADv2PowerShellAutomationScriptPowerShellCommandParameters != null)
            {
                runAzureADv2PowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptPowerShellCommandParameters);
                runAzureADv2PowerShellAutomationScriptpropCount++;
            }

            runAzureADv2PowerShellAutomationScriptpropCount++;
            runAzureADv2PowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runAzureADv2PowerShellAutomationScriptWorkflow);
            if (runAzureADv2PowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runAzureADv2PowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunAzureADv2PowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse> CloseAzureADv2PowerShellRunspace(Expression<Func<string>> closeAzureADv2PowerShellRunspaceWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/CloseAzureADv2PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeAzureADv2PowerShellRunspace = new JObject();
            var closeAzureADv2PowerShellRunspacepropCount = 0;
            closeAzureADv2PowerShellRunspacepropCount++;
            closeAzureADv2PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeAzureADv2PowerShellRunspaceWorkflow);
            if (closeAzureADv2PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeAzureADv2PowerShellRunspace;
            }

            return new ApiConnectionAction<CloseAzureADv2PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse> AzureADv2GetAzureADUsers(Expression<Func<string>> azureADv2GetAzureADUsersWorkflow, Expression<Func<string>> azureADv2GetAzureADUsersObjectId = null, Expression<Func<string>> azureADv2GetAzureADUsersFilterPropertyName = null, Expression<Func<azureADv2GetAzureADUsersFilterPropertyComparisonInput>> azureADv2GetAzureADUsersFilterPropertyComparison = null, Expression<Func<string>> azureADv2GetAzureADUsersFilterPropertyValue = null, Expression<Func<bool>> azureADv2GetAzureADUsersNoResultIsAnException = null, Expression<Func<string>> azureADv2GetAzureADUsersPropertiesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUsers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUsers = new JObject();
            var azureADv2GetAzureADUserspropCount = 0;
            if (azureADv2GetAzureADUsersObjectId != null)
            {
                azureADv2GetAzureADUsers["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersObjectId);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersFilterPropertyName != null)
            {
                azureADv2GetAzureADUsers["FilterPropertyName"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersFilterPropertyName);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersFilterPropertyComparison != null)
            {
                azureADv2GetAzureADUsers["FilterPropertyComparison"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersFilterPropertyComparison);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersFilterPropertyValue != null)
            {
                azureADv2GetAzureADUsers["FilterPropertyValue"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersFilterPropertyValue);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersNoResultIsAnException != null)
            {
                azureADv2GetAzureADUsers["NoResultIsAnException"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersNoResultIsAnException);
                azureADv2GetAzureADUserspropCount++;
            }

            if (azureADv2GetAzureADUsersPropertiesToReturn != null)
            {
                azureADv2GetAzureADUsers["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersPropertiesToReturn);
                azureADv2GetAzureADUserspropCount++;
            }

            azureADv2GetAzureADUserspropCount++;
            azureADv2GetAzureADUsers["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUsersWorkflow);
            if (azureADv2GetAzureADUserspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUsers;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse> AzureADv2AddAzureADUser(Expression<Func<string>> azureADv2AddAzureADUserUserPrincipalName, Expression<Func<bool>> azureADv2AddAzureADUserAccountEnabled, Expression<Func<string>> azureADv2AddAzureADUserAccountPassword, Expression<Func<string>> azureADv2AddAzureADUserDisplayName, Expression<Func<string>> azureADv2AddAzureADUserMailNickName, Expression<Func<string>> azureADv2AddAzureADUserWorkflow, Expression<Func<bool>> azureADv2AddAzureADUserAccountPasswordIsStoredPassword = null, Expression<Func<string>> azureADv2AddAzureADUserFirstName = null, Expression<Func<string>> azureADv2AddAzureADUserLastName = null, Expression<Func<string>> azureADv2AddAzureADUserCity = null, Expression<Func<string>> azureADv2AddAzureADUserCompanyName = null, Expression<Func<string>> azureADv2AddAzureADUserCountry = null, Expression<Func<string>> azureADv2AddAzureADUserDepartment = null, Expression<Func<string>> azureADv2AddAzureADUserFaxNumber = null, Expression<Func<string>> azureADv2AddAzureADUserJobTitle = null, Expression<Func<string>> azureADv2AddAzureADUserMobilePhone = null, Expression<Func<string>> azureADv2AddAzureADUserOffice = null, Expression<Func<string>> azureADv2AddAzureADUserPhoneNumber = null, Expression<Func<string>> azureADv2AddAzureADUserPostalCode = null, Expression<Func<string>> azureADv2AddAzureADUserPreferredLanguage = null, Expression<Func<string>> azureADv2AddAzureADUserState = null, Expression<Func<string>> azureADv2AddAzureADUserStreetAddress = null, Expression<Func<string>> azureADv2AddAzureADUserUsageLocation = null, Expression<Func<azureADv2AddAzureADUserAgeGroupInput>> azureADv2AddAzureADUserAgeGroup = null, Expression<Func<azureADv2AddAzureADUserConsentProvidedForMinorInput>> azureADv2AddAzureADUserConsentProvidedForMinor = null, Expression<Func<string>> azureADv2AddAzureADUserEmployeeId = null, Expression<Func<bool>> azureADv2AddAzureADUserForceChangePasswordNextLogin = null, Expression<Func<bool>> azureADv2AddAzureADUserEnforceChangePasswordPolicy = null, Expression<Func<bool>> azureADv2AddAzureADUserPasswordNeverExpires = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddAzureADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AddAzureADUser = new JObject();
            var azureADv2AddAzureADUserpropCount = 0;
            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["UserPrincipalName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserUserPrincipalName);
            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["AccountEnabled"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserAccountEnabled);
            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["AccountPassword"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserAccountPassword);
            if (azureADv2AddAzureADUserAccountPasswordIsStoredPassword != null)
            {
                azureADv2AddAzureADUser["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserAccountPasswordIsStoredPassword);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserFirstName != null)
            {
                azureADv2AddAzureADUser["FirstName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserFirstName);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserLastName != null)
            {
                azureADv2AddAzureADUser["LastName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserLastName);
                azureADv2AddAzureADUserpropCount++;
            }

            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["DisplayName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserDisplayName);
            if (azureADv2AddAzureADUserCity != null)
            {
                azureADv2AddAzureADUser["City"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserCity);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserCompanyName != null)
            {
                azureADv2AddAzureADUser["CompanyName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserCompanyName);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserCountry != null)
            {
                azureADv2AddAzureADUser["Country"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserCountry);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserDepartment != null)
            {
                azureADv2AddAzureADUser["Department"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserDepartment);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserFaxNumber != null)
            {
                azureADv2AddAzureADUser["FaxNumber"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserFaxNumber);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserJobTitle != null)
            {
                azureADv2AddAzureADUser["JobTitle"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserJobTitle);
                azureADv2AddAzureADUserpropCount++;
            }

            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["MailNickName"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserMailNickName);
            if (azureADv2AddAzureADUserMobilePhone != null)
            {
                azureADv2AddAzureADUser["MobilePhone"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserMobilePhone);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserOffice != null)
            {
                azureADv2AddAzureADUser["Office"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserOffice);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserPhoneNumber != null)
            {
                azureADv2AddAzureADUser["PhoneNumber"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserPhoneNumber);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserPostalCode != null)
            {
                azureADv2AddAzureADUser["PostalCode"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserPostalCode);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserPreferredLanguage != null)
            {
                azureADv2AddAzureADUser["PreferredLanguage"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserPreferredLanguage);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserState != null)
            {
                azureADv2AddAzureADUser["State"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserState);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserStreetAddress != null)
            {
                azureADv2AddAzureADUser["StreetAddress"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserStreetAddress);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserUsageLocation != null)
            {
                azureADv2AddAzureADUser["UsageLocation"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserUsageLocation);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserAgeGroup != null)
            {
                azureADv2AddAzureADUser["AgeGroup"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserAgeGroup);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserConsentProvidedForMinor != null)
            {
                azureADv2AddAzureADUser["ConsentProvidedForMinor"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserConsentProvidedForMinor);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserEmployeeId != null)
            {
                azureADv2AddAzureADUser["EmployeeId"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserEmployeeId);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserForceChangePasswordNextLogin != null)
            {
                azureADv2AddAzureADUser["ForceChangePasswordNextLogin"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserForceChangePasswordNextLogin);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserEnforceChangePasswordPolicy != null)
            {
                azureADv2AddAzureADUser["EnforceChangePasswordPolicy"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserEnforceChangePasswordPolicy);
                azureADv2AddAzureADUserpropCount++;
            }

            if (azureADv2AddAzureADUserPasswordNeverExpires != null)
            {
                azureADv2AddAzureADUser["PasswordNeverExpires"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserPasswordNeverExpires);
                azureADv2AddAzureADUserpropCount++;
            }

            azureADv2AddAzureADUserpropCount++;
            azureADv2AddAzureADUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2AddAzureADUserWorkflow);
            if (azureADv2AddAzureADUserpropCount > 0)
            {
                callPayload.Body = azureADv2AddAzureADUser;
            }

            return new ApiConnectionAction<AzureADv2AddAzureADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse> AzureADv2RemoveAzureADUser(Expression<Func<string>> azureADv2RemoveAzureADUserObjectId, Expression<Func<string>> azureADv2RemoveAzureADUserWorkflow, Expression<Func<bool>> azureADv2RemoveAzureADUserErrorIfUserDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAzureADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveAzureADUser = new JObject();
            var azureADv2RemoveAzureADUserpropCount = 0;
            azureADv2RemoveAzureADUserpropCount++;
            azureADv2RemoveAzureADUser["ObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveAzureADUserObjectId);
            if (azureADv2RemoveAzureADUserErrorIfUserDoesNotExist != null)
            {
                azureADv2RemoveAzureADUser["ErrorIfUserDoesNotExist"] = ExpressionConverter.ConvertO(azureADv2RemoveAzureADUserErrorIfUserDoesNotExist);
                azureADv2RemoveAzureADUserpropCount++;
            }

            azureADv2RemoveAzureADUserpropCount++;
            azureADv2RemoveAzureADUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveAzureADUserWorkflow);
            if (azureADv2RemoveAzureADUserpropCount > 0)
            {
                callPayload.Body = azureADv2RemoveAzureADUser;
            }

            return new ApiConnectionAction<AzureADv2RemoveAzureADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse> AzureADv2ResetAzureADUserPassword(Expression<Func<string>> azureADv2ResetAzureADUserPasswordUserPrincipalName, Expression<Func<string>> azureADv2ResetAzureADUserPasswordNewPassword, Expression<Func<string>> azureADv2ResetAzureADUserPasswordWorkflow, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordAccountPasswordIsStoredPassword = null, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordForceChangePasswordNextLogin = null, Expression<Func<bool>> azureADv2ResetAzureADUserPasswordEnforceChangePasswordPolicy = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2ResetAzureADUserPassword = new JObject();
            var azureADv2ResetAzureADUserPasswordpropCount = 0;
            azureADv2ResetAzureADUserPasswordpropCount++;
            azureADv2ResetAzureADUserPassword["UserPrincipalName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordUserPrincipalName);
            azureADv2ResetAzureADUserPasswordpropCount++;
            azureADv2ResetAzureADUserPassword["NewPassword"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordNewPassword);
            if (azureADv2ResetAzureADUserPasswordAccountPasswordIsStoredPassword != null)
            {
                azureADv2ResetAzureADUserPassword["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordAccountPasswordIsStoredPassword);
                azureADv2ResetAzureADUserPasswordpropCount++;
            }

            if (azureADv2ResetAzureADUserPasswordForceChangePasswordNextLogin != null)
            {
                azureADv2ResetAzureADUserPassword["ForceChangePasswordNextLogin"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordForceChangePasswordNextLogin);
                azureADv2ResetAzureADUserPasswordpropCount++;
            }

            if (azureADv2ResetAzureADUserPasswordEnforceChangePasswordPolicy != null)
            {
                azureADv2ResetAzureADUserPassword["EnforceChangePasswordPolicy"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordEnforceChangePasswordPolicy);
                azureADv2ResetAzureADUserPasswordpropCount++;
            }

            azureADv2ResetAzureADUserPasswordpropCount++;
            azureADv2ResetAzureADUserPassword["Workflow"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPasswordWorkflow);
            if (azureADv2ResetAzureADUserPasswordpropCount > 0)
            {
                callPayload.Body = azureADv2ResetAzureADUserPassword;
            }

            return new ApiConnectionAction<AzureADv2ResetAzureADUserPasswordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse> AzureADv2GetAzureADUserGroupMembership(Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipObjectId, Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipWorkflow, Expression<Func<string>> azureADv2GetAzureADUserGroupMembershipPropertiesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserGroupMembership = new JObject();
            var azureADv2GetAzureADUserGroupMembershippropCount = 0;
            azureADv2GetAzureADUserGroupMembershippropCount++;
            azureADv2GetAzureADUserGroupMembership["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserGroupMembershipObjectId);
            if (azureADv2GetAzureADUserGroupMembershipPropertiesToReturn != null)
            {
                azureADv2GetAzureADUserGroupMembership["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserGroupMembershipPropertiesToReturn);
                azureADv2GetAzureADUserGroupMembershippropCount++;
            }

            azureADv2GetAzureADUserGroupMembershippropCount++;
            azureADv2GetAzureADUserGroupMembership["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserGroupMembershipWorkflow);
            if (azureADv2GetAzureADUserGroupMembershippropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserGroupMembership;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse> AzureADv2IsUserInAzureADUserGroup(Expression<Func<string>> azureADv2IsUserInAzureADUserGroupObjectId, Expression<Func<string>> azureADv2IsUserInAzureADUserGroupGroupObjectId, Expression<Func<string>> azureADv2IsUserInAzureADUserGroupWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInAzureADUserGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2IsUserInAzureADUserGroup = new JObject();
            var azureADv2IsUserInAzureADUserGrouppropCount = 0;
            azureADv2IsUserInAzureADUserGrouppropCount++;
            azureADv2IsUserInAzureADUserGroup["ObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInAzureADUserGroupObjectId);
            azureADv2IsUserInAzureADUserGrouppropCount++;
            azureADv2IsUserInAzureADUserGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInAzureADUserGroupGroupObjectId);
            azureADv2IsUserInAzureADUserGrouppropCount++;
            azureADv2IsUserInAzureADUserGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2IsUserInAzureADUserGroupWorkflow);
            if (azureADv2IsUserInAzureADUserGrouppropCount > 0)
            {
                callPayload.Body = azureADv2IsUserInAzureADUserGroup;
            }

            return new ApiConnectionAction<AzureADv2IsUserInAzureADUserGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse> AzureADv2AddUserToGroup(Expression<Func<string>> azureADv2AddUserToGroupUserObjectId, Expression<Func<string>> azureADv2AddUserToGroupGroupObjectId, Expression<Func<string>> azureADv2AddUserToGroupWorkflow, Expression<Func<bool>> azureADv2AddUserToGroupCheckUserGroupMembershipsFirst = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddUserToGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AddUserToGroup = new JObject();
            var azureADv2AddUserToGrouppropCount = 0;
            azureADv2AddUserToGrouppropCount++;
            azureADv2AddUserToGroup["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupUserObjectId);
            azureADv2AddUserToGrouppropCount++;
            azureADv2AddUserToGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupGroupObjectId);
            if (azureADv2AddUserToGroupCheckUserGroupMembershipsFirst != null)
            {
                azureADv2AddUserToGroup["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupCheckUserGroupMembershipsFirst);
                azureADv2AddUserToGrouppropCount++;
            }

            azureADv2AddUserToGrouppropCount++;
            azureADv2AddUserToGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2AddUserToGroupWorkflow);
            if (azureADv2AddUserToGrouppropCount > 0)
            {
                callPayload.Body = azureADv2AddUserToGroup;
            }

            return new ApiConnectionAction<AzureADv2AddUserToGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse> AzureADv2RemoveUserFromGroup(Expression<Func<string>> azureADv2RemoveUserFromGroupUserObjectId, Expression<Func<string>> azureADv2RemoveUserFromGroupGroupObjectId, Expression<Func<string>> azureADv2RemoveUserFromGroupWorkflow, Expression<Func<bool>> azureADv2RemoveUserFromGroupCheckUserGroupMembershipsFirst = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromGroup = new JObject();
            var azureADv2RemoveUserFromGrouppropCount = 0;
            azureADv2RemoveUserFromGrouppropCount++;
            azureADv2RemoveUserFromGroup["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupUserObjectId);
            azureADv2RemoveUserFromGrouppropCount++;
            azureADv2RemoveUserFromGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupGroupObjectId);
            if (azureADv2RemoveUserFromGroupCheckUserGroupMembershipsFirst != null)
            {
                azureADv2RemoveUserFromGroup["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupCheckUserGroupMembershipsFirst);
                azureADv2RemoveUserFromGrouppropCount++;
            }

            azureADv2RemoveUserFromGrouppropCount++;
            azureADv2RemoveUserFromGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromGroupWorkflow);
            if (azureADv2RemoveUserFromGrouppropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromGroup;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse> AzureADv2AddADUserToMultipleADGroups(Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsUserObjectId, Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsWorkflow, Expression<Func<string>> azureADv2AddADUserToMultipleADGroupsGroupNamesJSON = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsExceptionIfAnyGroupsFailToAdd = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsExceptionIfAllGroupsFailToAdd = null, Expression<Func<bool>> azureADv2AddADUserToMultipleADGroupsCheckUserGroupMembershipsFirst = null, Expression<Func<int>> azureADv2AddADUserToMultipleADGroupsMaxAzureADGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddADUserToMultipleADGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AddADUserToMultipleADGroups = new JObject();
            var azureADv2AddADUserToMultipleADGroupspropCount = 0;
            azureADv2AddADUserToMultipleADGroupspropCount++;
            azureADv2AddADUserToMultipleADGroups["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsUserObjectId);
            if (azureADv2AddADUserToMultipleADGroupsGroupNamesJSON != null)
            {
                azureADv2AddADUserToMultipleADGroups["GroupNamesJSON"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsGroupNamesJSON);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            if (azureADv2AddADUserToMultipleADGroupsExceptionIfAnyGroupsFailToAdd != null)
            {
                azureADv2AddADUserToMultipleADGroups["ExceptionIfAnyGroupsFailToAdd"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsExceptionIfAnyGroupsFailToAdd);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            if (azureADv2AddADUserToMultipleADGroupsExceptionIfAllGroupsFailToAdd != null)
            {
                azureADv2AddADUserToMultipleADGroups["ExceptionIfAllGroupsFailToAdd"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsExceptionIfAllGroupsFailToAdd);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            if (azureADv2AddADUserToMultipleADGroupsCheckUserGroupMembershipsFirst != null)
            {
                azureADv2AddADUserToMultipleADGroups["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsCheckUserGroupMembershipsFirst);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            if (azureADv2AddADUserToMultipleADGroupsMaxAzureADGroupsPerCall != null)
            {
                azureADv2AddADUserToMultipleADGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsMaxAzureADGroupsPerCall);
                azureADv2AddADUserToMultipleADGroupspropCount++;
            }

            azureADv2AddADUserToMultipleADGroupspropCount++;
            azureADv2AddADUserToMultipleADGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2AddADUserToMultipleADGroupsWorkflow);
            if (azureADv2AddADUserToMultipleADGroupspropCount > 0)
            {
                callPayload.Body = azureADv2AddADUserToMultipleADGroups;
            }

            return new ApiConnectionAction<AzureADv2AddADUserToMultipleADGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse> AzureADv2RemoveADUserFromMultipleADGroups(Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsUserObjectId, Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsWorkflow, Expression<Func<string>> azureADv2RemoveADUserFromMultipleADGroupsGroupNamesJSON = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsExceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsExceptionIfAllGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveADUserFromMultipleADGroupsCheckUserGroupMembershipsFirst = null, Expression<Func<int>> azureADv2RemoveADUserFromMultipleADGroupsMaxAzureADGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveADUserFromMultipleADGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveADUserFromMultipleADGroups = new JObject();
            var azureADv2RemoveADUserFromMultipleADGroupspropCount = 0;
            azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            azureADv2RemoveADUserFromMultipleADGroups["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsUserObjectId);
            if (azureADv2RemoveADUserFromMultipleADGroupsGroupNamesJSON != null)
            {
                azureADv2RemoveADUserFromMultipleADGroups["GroupNamesJSON"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsGroupNamesJSON);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            if (azureADv2RemoveADUserFromMultipleADGroupsExceptionIfAnyGroupsFailToRemove != null)
            {
                azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsExceptionIfAnyGroupsFailToRemove);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            if (azureADv2RemoveADUserFromMultipleADGroupsExceptionIfAllGroupsFailToRemove != null)
            {
                azureADv2RemoveADUserFromMultipleADGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsExceptionIfAllGroupsFailToRemove);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            if (azureADv2RemoveADUserFromMultipleADGroupsCheckUserGroupMembershipsFirst != null)
            {
                azureADv2RemoveADUserFromMultipleADGroups["CheckUserGroupMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsCheckUserGroupMembershipsFirst);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            if (azureADv2RemoveADUserFromMultipleADGroupsMaxAzureADGroupsPerCall != null)
            {
                azureADv2RemoveADUserFromMultipleADGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsMaxAzureADGroupsPerCall);
                azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            }

            azureADv2RemoveADUserFromMultipleADGroupspropCount++;
            azureADv2RemoveADUserFromMultipleADGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveADUserFromMultipleADGroupsWorkflow);
            if (azureADv2RemoveADUserFromMultipleADGroupspropCount > 0)
            {
                callPayload.Body = azureADv2RemoveADUserFromMultipleADGroups;
            }

            return new ApiConnectionAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse> AzureADv2RemoveUserFromAllGroups(Expression<Func<string>> azureADv2RemoveUserFromAllGroupsUserObjectId, Expression<Func<string>> azureADv2RemoveUserFromAllGroupsWorkflow, Expression<Func<bool>> azureADv2RemoveUserFromAllGroupsExceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromAllGroupsExceptionIfAllGroupsFailToRemove = null, Expression<Func<int>> azureADv2RemoveUserFromAllGroupsMaxAzureADGroupsPerCall = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromAllGroups = new JObject();
            var azureADv2RemoveUserFromAllGroupspropCount = 0;
            azureADv2RemoveUserFromAllGroupspropCount++;
            azureADv2RemoveUserFromAllGroups["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsUserObjectId);
            if (azureADv2RemoveUserFromAllGroupsExceptionIfAnyGroupsFailToRemove != null)
            {
                azureADv2RemoveUserFromAllGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsExceptionIfAnyGroupsFailToRemove);
                azureADv2RemoveUserFromAllGroupspropCount++;
            }

            if (azureADv2RemoveUserFromAllGroupsExceptionIfAllGroupsFailToRemove != null)
            {
                azureADv2RemoveUserFromAllGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsExceptionIfAllGroupsFailToRemove);
                azureADv2RemoveUserFromAllGroupspropCount++;
            }

            if (azureADv2RemoveUserFromAllGroupsMaxAzureADGroupsPerCall != null)
            {
                azureADv2RemoveUserFromAllGroups["MaxAzureADGroupsPerCall"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsMaxAzureADGroupsPerCall);
                azureADv2RemoveUserFromAllGroupspropCount++;
            }

            azureADv2RemoveUserFromAllGroupspropCount++;
            azureADv2RemoveUserFromAllGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllGroupsWorkflow);
            if (azureADv2RemoveUserFromAllGroupspropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromAllGroups;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromAllGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse> AzureADv2GetAzureADLicenseSKUs(Expression<Func<string>> azureADv2GetAzureADLicenseSKUsWorkflow, Expression<Func<azureADv2GetAzureADLicenseSKUsExpandPropertyInput>> azureADv2GetAzureADLicenseSKUsExpandProperty = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADLicenseSKUs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADLicenseSKUs = new JObject();
            var azureADv2GetAzureADLicenseSKUspropCount = 0;
            if (azureADv2GetAzureADLicenseSKUsExpandProperty != null)
            {
                azureADv2GetAzureADLicenseSKUs["ExpandProperty"] = ExpressionConverter.ConvertO(azureADv2GetAzureADLicenseSKUsExpandProperty);
                azureADv2GetAzureADLicenseSKUspropCount++;
            }

            azureADv2GetAzureADLicenseSKUspropCount++;
            azureADv2GetAzureADLicenseSKUs["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADLicenseSKUsWorkflow);
            if (azureADv2GetAzureADLicenseSKUspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADLicenseSKUs;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADLicenseSKUsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse> AzureADv2SetAzureADUserLicense(Expression<Func<string>> azureADv2SetAzureADUserLicenseObjectId, Expression<Func<string>> azureADv2SetAzureADUserLicenseWorkflow, Expression<Func<string>> azureADv2SetAzureADUserLicenseLicenseToAdd = null, Expression<Func<azureADv2SetAzureADUserLicenseLicensePlansChoiceInput>> azureADv2SetAzureADUserLicenseLicensePlansChoice = null, Expression<Func<string>> azureADv2SetAzureADUserLicenseLicensePlansCSV = null, Expression<Func<string>> azureADv2SetAzureADUserLicenseLicensesToRemoveCSV = null, Expression<Func<string>> azureADv2SetAzureADUserLicenseUsageLocation = null, Expression<Func<bool>> azureADv2SetAzureADUserLicenseLocalScope = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserLicense";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2SetAzureADUserLicense = new JObject();
            var azureADv2SetAzureADUserLicensepropCount = 0;
            azureADv2SetAzureADUserLicensepropCount++;
            azureADv2SetAzureADUserLicense["ObjectId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseObjectId);
            if (azureADv2SetAzureADUserLicenseLicenseToAdd != null)
            {
                azureADv2SetAzureADUserLicense["LicenseToAdd"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseLicenseToAdd);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenseLicensePlansChoice != null)
            {
                azureADv2SetAzureADUserLicense["LicensePlansChoice"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseLicensePlansChoice);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenseLicensePlansCSV != null)
            {
                azureADv2SetAzureADUserLicense["LicensePlansCSV"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseLicensePlansCSV);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenseLicensesToRemoveCSV != null)
            {
                azureADv2SetAzureADUserLicense["LicensesToRemoveCSV"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseLicensesToRemoveCSV);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenseUsageLocation != null)
            {
                azureADv2SetAzureADUserLicense["UsageLocation"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseUsageLocation);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            if (azureADv2SetAzureADUserLicenseLocalScope != null)
            {
                azureADv2SetAzureADUserLicense["LocalScope"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseLocalScope);
                azureADv2SetAzureADUserLicensepropCount++;
            }

            azureADv2SetAzureADUserLicensepropCount++;
            azureADv2SetAzureADUserLicense["Workflow"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLicenseWorkflow);
            if (azureADv2SetAzureADUserLicensepropCount > 0)
            {
                callPayload.Body = azureADv2SetAzureADUserLicense;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserLicenseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse> AzureADv2GetAzureADUserLicenses(Expression<Func<string>> azureADv2GetAzureADUserLicensesObjectId, Expression<Func<string>> azureADv2GetAzureADUserLicensesWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserLicenses = new JObject();
            var azureADv2GetAzureADUserLicensespropCount = 0;
            azureADv2GetAzureADUserLicensespropCount++;
            azureADv2GetAzureADUserLicenses["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicensesObjectId);
            azureADv2GetAzureADUserLicensespropCount++;
            azureADv2GetAzureADUserLicenses["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicensesWorkflow);
            if (azureADv2GetAzureADUserLicensespropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserLicenses;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserLicensesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse> AzureADv2GetAzureADUserLicenseServicePlans(Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansObjectId, Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansLicenseSKUPartNumber, Expression<Func<string>> azureADv2GetAzureADUserLicenseServicePlansWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenseServicePlans";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserLicenseServicePlans = new JObject();
            var azureADv2GetAzureADUserLicenseServicePlanspropCount = 0;
            azureADv2GetAzureADUserLicenseServicePlanspropCount++;
            azureADv2GetAzureADUserLicenseServicePlans["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicenseServicePlansObjectId);
            azureADv2GetAzureADUserLicenseServicePlanspropCount++;
            azureADv2GetAzureADUserLicenseServicePlans["LicenseSKUPartNumber"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicenseServicePlansLicenseSKUPartNumber);
            azureADv2GetAzureADUserLicenseServicePlanspropCount++;
            azureADv2GetAzureADUserLicenseServicePlans["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserLicenseServicePlansWorkflow);
            if (azureADv2GetAzureADUserLicenseServicePlanspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserLicenseServicePlans;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse> AzureADv2RemoveAllAzureADUserLicense(Expression<Func<string>> azureADv2RemoveAllAzureADUserLicenseObjectId, Expression<Func<string>> azureADv2RemoveAllAzureADUserLicenseWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAllAzureADUserLicense";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveAllAzureADUserLicense = new JObject();
            var azureADv2RemoveAllAzureADUserLicensepropCount = 0;
            azureADv2RemoveAllAzureADUserLicensepropCount++;
            azureADv2RemoveAllAzureADUserLicense["ObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveAllAzureADUserLicenseObjectId);
            azureADv2RemoveAllAzureADUserLicensepropCount++;
            azureADv2RemoveAllAzureADUserLicense["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveAllAzureADUserLicenseWorkflow);
            if (azureADv2RemoveAllAzureADUserLicensepropCount > 0)
            {
                callPayload.Body = azureADv2RemoveAllAzureADUserLicense;
            }

            return new ApiConnectionAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse> AzureADv2SetAzureADUser(Expression<Func<string>> azureADv2SetAzureADUserObjectId, Expression<Func<string>> azureADv2SetAzureADUserWorkflow, Expression<Func<string>> azureADv2SetAzureADUserFirstName = null, Expression<Func<string>> azureADv2SetAzureADUserLastName = null, Expression<Func<string>> azureADv2SetAzureADUserDisplayName = null, Expression<Func<string>> azureADv2SetAzureADUserCity = null, Expression<Func<string>> azureADv2SetAzureADUserCompanyName = null, Expression<Func<string>> azureADv2SetAzureADUserCountry = null, Expression<Func<string>> azureADv2SetAzureADUserDepartment = null, Expression<Func<string>> azureADv2SetAzureADUserFaxNumber = null, Expression<Func<string>> azureADv2SetAzureADUserJobTitle = null, Expression<Func<string>> azureADv2SetAzureADUserMobilePhone = null, Expression<Func<string>> azureADv2SetAzureADUserOffice = null, Expression<Func<string>> azureADv2SetAzureADUserPhoneNumber = null, Expression<Func<string>> azureADv2SetAzureADUserPostalCode = null, Expression<Func<string>> azureADv2SetAzureADUserPreferredLanguage = null, Expression<Func<string>> azureADv2SetAzureADUserState = null, Expression<Func<string>> azureADv2SetAzureADUserStreetAddress = null, Expression<Func<string>> azureADv2SetAzureADUserUsageLocation = null, Expression<Func<azureADv2SetAzureADUserAgeGroupInput>> azureADv2SetAzureADUserAgeGroup = null, Expression<Func<azureADv2SetAzureADUserConsentProvidedForMinorInput>> azureADv2SetAzureADUserConsentProvidedForMinor = null, Expression<Func<string>> azureADv2SetAzureADUserMailNickName = null, Expression<Func<string>> azureADv2SetAzureADUserEmployeeId = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2SetAzureADUser = new JObject();
            var azureADv2SetAzureADUserpropCount = 0;
            azureADv2SetAzureADUserpropCount++;
            azureADv2SetAzureADUser["ObjectId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserObjectId);
            if (azureADv2SetAzureADUserFirstName != null)
            {
                azureADv2SetAzureADUser["FirstName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserFirstName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserLastName != null)
            {
                azureADv2SetAzureADUser["LastName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserLastName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserDisplayName != null)
            {
                azureADv2SetAzureADUser["DisplayName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserDisplayName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserCity != null)
            {
                azureADv2SetAzureADUser["City"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserCity);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserCompanyName != null)
            {
                azureADv2SetAzureADUser["CompanyName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserCompanyName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserCountry != null)
            {
                azureADv2SetAzureADUser["Country"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserCountry);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserDepartment != null)
            {
                azureADv2SetAzureADUser["Department"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserDepartment);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserFaxNumber != null)
            {
                azureADv2SetAzureADUser["FaxNumber"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserFaxNumber);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserJobTitle != null)
            {
                azureADv2SetAzureADUser["JobTitle"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserJobTitle);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserMobilePhone != null)
            {
                azureADv2SetAzureADUser["MobilePhone"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserMobilePhone);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserOffice != null)
            {
                azureADv2SetAzureADUser["Office"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserOffice);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserPhoneNumber != null)
            {
                azureADv2SetAzureADUser["PhoneNumber"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserPhoneNumber);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserPostalCode != null)
            {
                azureADv2SetAzureADUser["PostalCode"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserPostalCode);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserPreferredLanguage != null)
            {
                azureADv2SetAzureADUser["PreferredLanguage"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserPreferredLanguage);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserState != null)
            {
                azureADv2SetAzureADUser["State"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserState);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserStreetAddress != null)
            {
                azureADv2SetAzureADUser["StreetAddress"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserStreetAddress);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserUsageLocation != null)
            {
                azureADv2SetAzureADUser["UsageLocation"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserUsageLocation);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserAgeGroup != null)
            {
                azureADv2SetAzureADUser["AgeGroup"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserAgeGroup);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserConsentProvidedForMinor != null)
            {
                azureADv2SetAzureADUser["ConsentProvidedForMinor"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserConsentProvidedForMinor);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserMailNickName != null)
            {
                azureADv2SetAzureADUser["MailNickName"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserMailNickName);
                azureADv2SetAzureADUserpropCount++;
            }

            if (azureADv2SetAzureADUserEmployeeId != null)
            {
                azureADv2SetAzureADUser["EmployeeId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserEmployeeId);
                azureADv2SetAzureADUserpropCount++;
            }

            azureADv2SetAzureADUserpropCount++;
            azureADv2SetAzureADUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserWorkflow);
            if (azureADv2SetAzureADUserpropCount > 0)
            {
                callPayload.Body = azureADv2SetAzureADUser;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse> AzureADv2ResetAzureADUserProperties(Expression<Func<string>> azureADv2ResetAzureADUserPropertiesObjectId, Expression<Func<string>> azureADv2ResetAzureADUserPropertiesWorkflow, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetFirstName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetLastName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetCity = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetCompanyName = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetCountry = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetDepartment = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetFaxNumber = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetJobTitle = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetMobilePhone = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetOffice = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetPhoneNumber = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetPostalCode = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetPreferredLanguage = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetState = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetStreetAddress = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetUsageLocation = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetAgeGroup = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetConsentProvidedForMinor = null, Expression<Func<bool>> azureADv2ResetAzureADUserPropertiesResetEmployeeId = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2ResetAzureADUserProperties = new JObject();
            var azureADv2ResetAzureADUserPropertiespropCount = 0;
            azureADv2ResetAzureADUserPropertiespropCount++;
            azureADv2ResetAzureADUserProperties["ObjectId"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesObjectId);
            if (azureADv2ResetAzureADUserPropertiesResetFirstName != null)
            {
                azureADv2ResetAzureADUserProperties["ResetFirstName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetFirstName);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetLastName != null)
            {
                azureADv2ResetAzureADUserProperties["ResetLastName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetLastName);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetCity != null)
            {
                azureADv2ResetAzureADUserProperties["ResetCity"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetCity);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetCompanyName != null)
            {
                azureADv2ResetAzureADUserProperties["ResetCompanyName"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetCompanyName);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetCountry != null)
            {
                azureADv2ResetAzureADUserProperties["ResetCountry"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetCountry);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetDepartment != null)
            {
                azureADv2ResetAzureADUserProperties["ResetDepartment"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetDepartment);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetFaxNumber != null)
            {
                azureADv2ResetAzureADUserProperties["ResetFaxNumber"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetFaxNumber);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetJobTitle != null)
            {
                azureADv2ResetAzureADUserProperties["ResetJobTitle"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetJobTitle);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetMobilePhone != null)
            {
                azureADv2ResetAzureADUserProperties["ResetMobilePhone"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetMobilePhone);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetOffice != null)
            {
                azureADv2ResetAzureADUserProperties["ResetOffice"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetOffice);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetPhoneNumber != null)
            {
                azureADv2ResetAzureADUserProperties["ResetPhoneNumber"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetPhoneNumber);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetPostalCode != null)
            {
                azureADv2ResetAzureADUserProperties["ResetPostalCode"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetPostalCode);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetPreferredLanguage != null)
            {
                azureADv2ResetAzureADUserProperties["ResetPreferredLanguage"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetPreferredLanguage);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetState != null)
            {
                azureADv2ResetAzureADUserProperties["ResetState"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetState);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetStreetAddress != null)
            {
                azureADv2ResetAzureADUserProperties["ResetStreetAddress"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetStreetAddress);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetUsageLocation != null)
            {
                azureADv2ResetAzureADUserProperties["ResetUsageLocation"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetUsageLocation);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetAgeGroup != null)
            {
                azureADv2ResetAzureADUserProperties["ResetAgeGroup"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetAgeGroup);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetConsentProvidedForMinor != null)
            {
                azureADv2ResetAzureADUserProperties["ResetConsentProvidedForMinor"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetConsentProvidedForMinor);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            if (azureADv2ResetAzureADUserPropertiesResetEmployeeId != null)
            {
                azureADv2ResetAzureADUserProperties["ResetEmployeeId"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesResetEmployeeId);
                azureADv2ResetAzureADUserPropertiespropCount++;
            }

            azureADv2ResetAzureADUserPropertiespropCount++;
            azureADv2ResetAzureADUserProperties["Workflow"] = ExpressionConverter.ConvertO(azureADv2ResetAzureADUserPropertiesWorkflow);
            if (azureADv2ResetAzureADUserPropertiespropCount > 0)
            {
                callPayload.Body = azureADv2ResetAzureADUserProperties;
            }

            return new ApiConnectionAction<AzureADv2ResetAzureADUserPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse> AzureADv2SetAzureADUserManager(Expression<Func<string>> azureADv2SetAzureADUserManagerObjectId, Expression<Func<string>> azureADv2SetAzureADUserManagerWorkflow, Expression<Func<string>> azureADv2SetAzureADUserManagerManager = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserManager";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2SetAzureADUserManager = new JObject();
            var azureADv2SetAzureADUserManagerpropCount = 0;
            azureADv2SetAzureADUserManagerpropCount++;
            azureADv2SetAzureADUserManager["ObjectId"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserManagerObjectId);
            if (azureADv2SetAzureADUserManagerManager != null)
            {
                azureADv2SetAzureADUserManager["Manager"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserManagerManager);
                azureADv2SetAzureADUserManagerpropCount++;
            }

            azureADv2SetAzureADUserManagerpropCount++;
            azureADv2SetAzureADUserManager["Workflow"] = ExpressionConverter.ConvertO(azureADv2SetAzureADUserManagerWorkflow);
            if (azureADv2SetAzureADUserManagerpropCount > 0)
            {
                callPayload.Body = azureADv2SetAzureADUserManager;
            }

            return new ApiConnectionAction<AzureADv2SetAzureADUserManagerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse> AzureADv2NewSecurityGroup(Expression<Func<string>> azureADv2NewSecurityGroupDisplayName, Expression<Func<string>> azureADv2NewSecurityGroupWorkflow, Expression<Func<string>> azureADv2NewSecurityGroupDescription = null, Expression<Func<bool>> azureADv2NewSecurityGroupCheckGroupExists = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewSecurityGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2NewSecurityGroup = new JObject();
            var azureADv2NewSecurityGrouppropCount = 0;
            azureADv2NewSecurityGrouppropCount++;
            azureADv2NewSecurityGroup["DisplayName"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupDisplayName);
            if (azureADv2NewSecurityGroupDescription != null)
            {
                azureADv2NewSecurityGroup["Description"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupDescription);
                azureADv2NewSecurityGrouppropCount++;
            }

            if (azureADv2NewSecurityGroupCheckGroupExists != null)
            {
                azureADv2NewSecurityGroup["CheckGroupExists"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupCheckGroupExists);
                azureADv2NewSecurityGrouppropCount++;
            }

            azureADv2NewSecurityGrouppropCount++;
            azureADv2NewSecurityGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2NewSecurityGroupWorkflow);
            if (azureADv2NewSecurityGrouppropCount > 0)
            {
                callPayload.Body = azureADv2NewSecurityGroup;
            }

            return new ApiConnectionAction<AzureADv2NewSecurityGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse> AzureADv2RemoveSecurityGroup(Expression<Func<string>> azureADv2RemoveSecurityGroupGroupObjectId, Expression<Func<string>> azureADv2RemoveSecurityGroupWorkflow, Expression<Func<bool>> azureADv2RemoveSecurityGroupErrorIfGroupDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveSecurityGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveSecurityGroup = new JObject();
            var azureADv2RemoveSecurityGrouppropCount = 0;
            azureADv2RemoveSecurityGrouppropCount++;
            azureADv2RemoveSecurityGroup["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveSecurityGroupGroupObjectId);
            if (azureADv2RemoveSecurityGroupErrorIfGroupDoesNotExist != null)
            {
                azureADv2RemoveSecurityGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(azureADv2RemoveSecurityGroupErrorIfGroupDoesNotExist);
                azureADv2RemoveSecurityGrouppropCount++;
            }

            azureADv2RemoveSecurityGrouppropCount++;
            azureADv2RemoveSecurityGroup["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveSecurityGroupWorkflow);
            if (azureADv2RemoveSecurityGrouppropCount > 0)
            {
                callPayload.Body = azureADv2RemoveSecurityGroup;
            }

            return new ApiConnectionAction<AzureADv2RemoveSecurityGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse> AzureADv2NewMicrosoft365Group(Expression<Func<string>> azureADv2NewMicrosoft365GroupDisplayName, Expression<Func<string>> azureADv2NewMicrosoft365GroupWorkflow, Expression<Func<string>> azureADv2NewMicrosoft365GroupDescription = null, Expression<Func<string>> azureADv2NewMicrosoft365GroupMailNickname = null, Expression<Func<azureADv2NewMicrosoft365GroupGroupVisibilityInput>> azureADv2NewMicrosoft365GroupGroupVisibility = null, Expression<Func<bool>> azureADv2NewMicrosoft365GroupCheckGroupExists = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewMicrosoft365Group";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2NewMicrosoft365Group = new JObject();
            var azureADv2NewMicrosoft365GrouppropCount = 0;
            azureADv2NewMicrosoft365GrouppropCount++;
            azureADv2NewMicrosoft365Group["DisplayName"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupDisplayName);
            if (azureADv2NewMicrosoft365GroupDescription != null)
            {
                azureADv2NewMicrosoft365Group["Description"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupDescription);
                azureADv2NewMicrosoft365GrouppropCount++;
            }

            if (azureADv2NewMicrosoft365GroupMailNickname != null)
            {
                azureADv2NewMicrosoft365Group["MailNickname"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupMailNickname);
                azureADv2NewMicrosoft365GrouppropCount++;
            }

            if (azureADv2NewMicrosoft365GroupGroupVisibility != null)
            {
                azureADv2NewMicrosoft365Group["GroupVisibility"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupGroupVisibility);
                azureADv2NewMicrosoft365GrouppropCount++;
            }

            if (azureADv2NewMicrosoft365GroupCheckGroupExists != null)
            {
                azureADv2NewMicrosoft365Group["CheckGroupExists"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupCheckGroupExists);
                azureADv2NewMicrosoft365GrouppropCount++;
            }

            azureADv2NewMicrosoft365GrouppropCount++;
            azureADv2NewMicrosoft365Group["Workflow"] = ExpressionConverter.ConvertO(azureADv2NewMicrosoft365GroupWorkflow);
            if (azureADv2NewMicrosoft365GrouppropCount > 0)
            {
                callPayload.Body = azureADv2NewMicrosoft365Group;
            }

            return new ApiConnectionAction<AzureADv2NewMicrosoft365GroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse> AzureADv2GetGroups(Expression<Func<string>> azureADv2GetGroupsWorkflow, Expression<Func<string>> azureADv2GetGroupsObjectId = null, Expression<Func<string>> azureADv2GetGroupsFilterPropertyName = null, Expression<Func<azureADv2GetGroupsFilterPropertyComparisonInput>> azureADv2GetGroupsFilterPropertyComparison = null, Expression<Func<string>> azureADv2GetGroupsFilterPropertyValue = null, Expression<Func<bool>> azureADv2GetGroupsNoResultIsAnException = null, Expression<Func<string>> azureADv2GetGroupsPropertiesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetGroups = new JObject();
            var azureADv2GetGroupspropCount = 0;
            if (azureADv2GetGroupsObjectId != null)
            {
                azureADv2GetGroups["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetGroupsObjectId);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsFilterPropertyName != null)
            {
                azureADv2GetGroups["FilterPropertyName"] = ExpressionConverter.ConvertO(azureADv2GetGroupsFilterPropertyName);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsFilterPropertyComparison != null)
            {
                azureADv2GetGroups["FilterPropertyComparison"] = ExpressionConverter.ConvertO(azureADv2GetGroupsFilterPropertyComparison);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsFilterPropertyValue != null)
            {
                azureADv2GetGroups["FilterPropertyValue"] = ExpressionConverter.ConvertO(azureADv2GetGroupsFilterPropertyValue);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsNoResultIsAnException != null)
            {
                azureADv2GetGroups["NoResultIsAnException"] = ExpressionConverter.ConvertO(azureADv2GetGroupsNoResultIsAnException);
                azureADv2GetGroupspropCount++;
            }

            if (azureADv2GetGroupsPropertiesToReturn != null)
            {
                azureADv2GetGroups["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetGroupsPropertiesToReturn);
                azureADv2GetGroupspropCount++;
            }

            azureADv2GetGroupspropCount++;
            azureADv2GetGroups["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetGroupsWorkflow);
            if (azureADv2GetGroupspropCount > 0)
            {
                callPayload.Body = azureADv2GetGroups;
            }

            return new ApiConnectionAction<AzureADv2GetGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse> AzureADv2EnableUser(Expression<Func<string>> azureADv2EnableUserUserObjectId, Expression<Func<string>> azureADv2EnableUserWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2EnableUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2EnableUser = new JObject();
            var azureADv2EnableUserpropCount = 0;
            azureADv2EnableUserpropCount++;
            azureADv2EnableUser["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2EnableUserUserObjectId);
            azureADv2EnableUserpropCount++;
            azureADv2EnableUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2EnableUserWorkflow);
            if (azureADv2EnableUserpropCount > 0)
            {
                callPayload.Body = azureADv2EnableUser;
            }

            return new ApiConnectionAction<AzureADv2EnableUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse> AzureADv2DisableUser(Expression<Func<string>> azureADv2DisableUserUserObjectId, Expression<Func<string>> azureADv2DisableUserWorkflow, Expression<Func<bool>> azureADv2DisableUserRevokeUserRefreshTokens = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2DisableUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2DisableUser = new JObject();
            var azureADv2DisableUserpropCount = 0;
            azureADv2DisableUserpropCount++;
            azureADv2DisableUser["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2DisableUserUserObjectId);
            if (azureADv2DisableUserRevokeUserRefreshTokens != null)
            {
                azureADv2DisableUser["RevokeUserRefreshTokens"] = ExpressionConverter.ConvertO(azureADv2DisableUserRevokeUserRefreshTokens);
                azureADv2DisableUserpropCount++;
            }

            azureADv2DisableUserpropCount++;
            azureADv2DisableUser["Workflow"] = ExpressionConverter.ConvertO(azureADv2DisableUserWorkflow);
            if (azureADv2DisableUserpropCount > 0)
            {
                callPayload.Body = azureADv2DisableUser;
            }

            return new ApiConnectionAction<AzureADv2DisableUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse> AzureADv2AssignUserToRole(Expression<Func<string>> azureADv2AssignUserToRoleUserObjectId, Expression<Func<string>> azureADv2AssignUserToRoleRoleObjectId, Expression<Func<string>> azureADv2AssignUserToRoleWorkflow, Expression<Func<string>> azureADv2AssignUserToRoleDirectoryScopeId = null, Expression<Func<bool>> azureADv2AssignUserToRoleCheckUserRoleMembershipsFirst = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToRole";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AssignUserToRole = new JObject();
            var azureADv2AssignUserToRolepropCount = 0;
            azureADv2AssignUserToRolepropCount++;
            azureADv2AssignUserToRole["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleUserObjectId);
            azureADv2AssignUserToRolepropCount++;
            azureADv2AssignUserToRole["RoleObjectId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleRoleObjectId);
            if (azureADv2AssignUserToRoleDirectoryScopeId != null)
            {
                azureADv2AssignUserToRole["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleDirectoryScopeId);
                azureADv2AssignUserToRolepropCount++;
            }

            if (azureADv2AssignUserToRoleCheckUserRoleMembershipsFirst != null)
            {
                azureADv2AssignUserToRole["CheckUserRoleMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleCheckUserRoleMembershipsFirst);
                azureADv2AssignUserToRolepropCount++;
            }

            azureADv2AssignUserToRolepropCount++;
            azureADv2AssignUserToRole["Workflow"] = ExpressionConverter.ConvertO(azureADv2AssignUserToRoleWorkflow);
            if (azureADv2AssignUserToRolepropCount > 0)
            {
                callPayload.Body = azureADv2AssignUserToRole;
            }

            return new ApiConnectionAction<AzureADv2AssignUserToRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse> AzureADv2AssignUserToMultipleRoles(Expression<Func<string>> azureADv2AssignUserToMultipleRolesUserObjectId, Expression<Func<string>> azureADv2AssignUserToMultipleRolesWorkflow, Expression<Func<string>> azureADv2AssignUserToMultipleRolesRolesJSON = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesExceptionIfAnyRolesFailToAssign = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesExceptionIfAllRolesFailToAssign = null, Expression<Func<string>> azureADv2AssignUserToMultipleRolesDirectoryScopeId = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesCheckUserRoleMembershipsFirst = null, Expression<Func<bool>> azureADv2AssignUserToMultipleRolesCheckRoleIdsExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToMultipleRoles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2AssignUserToMultipleRoles = new JObject();
            var azureADv2AssignUserToMultipleRolespropCount = 0;
            azureADv2AssignUserToMultipleRolespropCount++;
            azureADv2AssignUserToMultipleRoles["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesUserObjectId);
            if (azureADv2AssignUserToMultipleRolesRolesJSON != null)
            {
                azureADv2AssignUserToMultipleRoles["RolesJSON"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesRolesJSON);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            if (azureADv2AssignUserToMultipleRolesExceptionIfAnyRolesFailToAssign != null)
            {
                azureADv2AssignUserToMultipleRoles["ExceptionIfAnyRolesFailToAssign"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesExceptionIfAnyRolesFailToAssign);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            if (azureADv2AssignUserToMultipleRolesExceptionIfAllRolesFailToAssign != null)
            {
                azureADv2AssignUserToMultipleRoles["ExceptionIfAllRolesFailToAssign"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesExceptionIfAllRolesFailToAssign);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            if (azureADv2AssignUserToMultipleRolesDirectoryScopeId != null)
            {
                azureADv2AssignUserToMultipleRoles["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesDirectoryScopeId);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            if (azureADv2AssignUserToMultipleRolesCheckUserRoleMembershipsFirst != null)
            {
                azureADv2AssignUserToMultipleRoles["CheckUserRoleMembershipsFirst"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesCheckUserRoleMembershipsFirst);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            if (azureADv2AssignUserToMultipleRolesCheckRoleIdsExist != null)
            {
                azureADv2AssignUserToMultipleRoles["CheckRoleIdsExist"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesCheckRoleIdsExist);
                azureADv2AssignUserToMultipleRolespropCount++;
            }

            azureADv2AssignUserToMultipleRolespropCount++;
            azureADv2AssignUserToMultipleRoles["Workflow"] = ExpressionConverter.ConvertO(azureADv2AssignUserToMultipleRolesWorkflow);
            if (azureADv2AssignUserToMultipleRolespropCount > 0)
            {
                callPayload.Body = azureADv2AssignUserToMultipleRoles;
            }

            return new ApiConnectionAction<AzureADv2AssignUserToMultipleRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse> AzureADv2RemoveUserFromMultipleRoles(Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesUserObjectId, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesWorkflow, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesRolesJSON = null, Expression<Func<string>> azureADv2RemoveUserFromMultipleRolesDirectoryScopeId = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesExceptionIfAnyRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesExceptionIfAllRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromMultipleRolesExceptionIfRoleDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromMultipleRoles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromMultipleRoles = new JObject();
            var azureADv2RemoveUserFromMultipleRolespropCount = 0;
            azureADv2RemoveUserFromMultipleRolespropCount++;
            azureADv2RemoveUserFromMultipleRoles["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesUserObjectId);
            if (azureADv2RemoveUserFromMultipleRolesRolesJSON != null)
            {
                azureADv2RemoveUserFromMultipleRoles["RolesJSON"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesRolesJSON);
                azureADv2RemoveUserFromMultipleRolespropCount++;
            }

            if (azureADv2RemoveUserFromMultipleRolesDirectoryScopeId != null)
            {
                azureADv2RemoveUserFromMultipleRoles["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesDirectoryScopeId);
                azureADv2RemoveUserFromMultipleRolespropCount++;
            }

            if (azureADv2RemoveUserFromMultipleRolesExceptionIfAnyRolesFailToRemove != null)
            {
                azureADv2RemoveUserFromMultipleRoles["ExceptionIfAnyRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesExceptionIfAnyRolesFailToRemove);
                azureADv2RemoveUserFromMultipleRolespropCount++;
            }

            if (azureADv2RemoveUserFromMultipleRolesExceptionIfAllRolesFailToRemove != null)
            {
                azureADv2RemoveUserFromMultipleRoles["ExceptionIfAllRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesExceptionIfAllRolesFailToRemove);
                azureADv2RemoveUserFromMultipleRolespropCount++;
            }

            if (azureADv2RemoveUserFromMultipleRolesExceptionIfRoleDoesNotExist != null)
            {
                azureADv2RemoveUserFromMultipleRoles["ExceptionIfRoleDoesNotExist"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesExceptionIfRoleDoesNotExist);
                azureADv2RemoveUserFromMultipleRolespropCount++;
            }

            azureADv2RemoveUserFromMultipleRolespropCount++;
            azureADv2RemoveUserFromMultipleRoles["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromMultipleRolesWorkflow);
            if (azureADv2RemoveUserFromMultipleRolespropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromMultipleRoles;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromMultipleRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse> AzureADv2IsUserInRole(Expression<Func<string>> azureADv2IsUserInRoleUserObjectId, Expression<Func<string>> azureADv2IsUserInRoleRoleObjectId, Expression<Func<string>> azureADv2IsUserInRoleWorkflow)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInRole";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2IsUserInRole = new JObject();
            var azureADv2IsUserInRolepropCount = 0;
            azureADv2IsUserInRolepropCount++;
            azureADv2IsUserInRole["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInRoleUserObjectId);
            azureADv2IsUserInRolepropCount++;
            azureADv2IsUserInRole["RoleObjectId"] = ExpressionConverter.ConvertO(azureADv2IsUserInRoleRoleObjectId);
            azureADv2IsUserInRolepropCount++;
            azureADv2IsUserInRole["Workflow"] = ExpressionConverter.ConvertO(azureADv2IsUserInRoleWorkflow);
            if (azureADv2IsUserInRolepropCount > 0)
            {
                callPayload.Body = azureADv2IsUserInRole;
            }

            return new ApiConnectionAction<AzureADv2IsUserInRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse> AzureADv2GetAzureADUserRoleAssignments(Expression<Func<string>> azureADv2GetAzureADUserRoleAssignmentsObjectId, Expression<Func<string>> azureADv2GetAzureADUserRoleAssignmentsWorkflow, Expression<Func<bool>> azureADv2GetAzureADUserRoleAssignmentsRetrieveAdminRoleNames = null, Expression<Func<bool>> azureADv2GetAzureADUserRoleAssignmentsReturnAssignmentIds = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserRoleAssignments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADUserRoleAssignments = new JObject();
            var azureADv2GetAzureADUserRoleAssignmentspropCount = 0;
            azureADv2GetAzureADUserRoleAssignmentspropCount++;
            azureADv2GetAzureADUserRoleAssignments["ObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsObjectId);
            if (azureADv2GetAzureADUserRoleAssignmentsRetrieveAdminRoleNames != null)
            {
                azureADv2GetAzureADUserRoleAssignments["RetrieveAdminRoleNames"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsRetrieveAdminRoleNames);
                azureADv2GetAzureADUserRoleAssignmentspropCount++;
            }

            if (azureADv2GetAzureADUserRoleAssignmentsReturnAssignmentIds != null)
            {
                azureADv2GetAzureADUserRoleAssignments["ReturnAssignmentIds"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsReturnAssignmentIds);
                azureADv2GetAzureADUserRoleAssignmentspropCount++;
            }

            azureADv2GetAzureADUserRoleAssignmentspropCount++;
            azureADv2GetAzureADUserRoleAssignments["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADUserRoleAssignmentsWorkflow);
            if (azureADv2GetAzureADUserRoleAssignmentspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADUserRoleAssignments;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse> AzureADv2RemoveUserFromRole(Expression<Func<string>> azureADv2RemoveUserFromRoleUserObjectId, Expression<Func<string>> azureADv2RemoveUserFromRoleRoleObjectId, Expression<Func<string>> azureADv2RemoveUserFromRoleWorkflow, Expression<Func<string>> azureADv2RemoveUserFromRoleDirectoryScopeId = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromRole";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromRole = new JObject();
            var azureADv2RemoveUserFromRolepropCount = 0;
            azureADv2RemoveUserFromRolepropCount++;
            azureADv2RemoveUserFromRole["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleUserObjectId);
            azureADv2RemoveUserFromRolepropCount++;
            azureADv2RemoveUserFromRole["RoleObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleRoleObjectId);
            if (azureADv2RemoveUserFromRoleDirectoryScopeId != null)
            {
                azureADv2RemoveUserFromRole["DirectoryScopeId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleDirectoryScopeId);
                azureADv2RemoveUserFromRolepropCount++;
            }

            azureADv2RemoveUserFromRolepropCount++;
            azureADv2RemoveUserFromRole["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromRoleWorkflow);
            if (azureADv2RemoveUserFromRolepropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromRole;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromRoleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse> AzureADv2RemoveUserFromAllRoles(Expression<Func<string>> azureADv2RemoveUserFromAllRolesUserObjectId, Expression<Func<string>> azureADv2RemoveUserFromAllRolesWorkflow, Expression<Func<bool>> azureADv2RemoveUserFromAllRolesExceptionIfAnyRolesFailToRemove = null, Expression<Func<bool>> azureADv2RemoveUserFromAllRolesExceptionIfAllRolesFailToRemove = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllRoles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2RemoveUserFromAllRoles = new JObject();
            var azureADv2RemoveUserFromAllRolespropCount = 0;
            azureADv2RemoveUserFromAllRolespropCount++;
            azureADv2RemoveUserFromAllRoles["UserObjectId"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesUserObjectId);
            if (azureADv2RemoveUserFromAllRolesExceptionIfAnyRolesFailToRemove != null)
            {
                azureADv2RemoveUserFromAllRoles["ExceptionIfAnyRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesExceptionIfAnyRolesFailToRemove);
                azureADv2RemoveUserFromAllRolespropCount++;
            }

            if (azureADv2RemoveUserFromAllRolesExceptionIfAllRolesFailToRemove != null)
            {
                azureADv2RemoveUserFromAllRoles["ExceptionIfAllRolesFailToRemove"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesExceptionIfAllRolesFailToRemove);
                azureADv2RemoveUserFromAllRolespropCount++;
            }

            azureADv2RemoveUserFromAllRolespropCount++;
            azureADv2RemoveUserFromAllRoles["Workflow"] = ExpressionConverter.ConvertO(azureADv2RemoveUserFromAllRolesWorkflow);
            if (azureADv2RemoveUserFromAllRolespropCount > 0)
            {
                callPayload.Body = azureADv2RemoveUserFromAllRoles;
            }

            return new ApiConnectionAction<AzureADv2RemoveUserFromAllRolesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse> AzureADv2GetAzureADGroupMembers(Expression<Func<string>> azureADv2GetAzureADGroupMembersGroupObjectId, Expression<Func<string>> azureADv2GetAzureADGroupMembersWorkflow, Expression<Func<string>> azureADv2GetAzureADGroupMembersPropertiesToReturn = null, Expression<Func<string>> azureADv2GetAzureADGroupMembersMemberObjectTypesToReturn = null)
        {
            var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var azureADv2GetAzureADGroupMembers = new JObject();
            var azureADv2GetAzureADGroupMemberspropCount = 0;
            azureADv2GetAzureADGroupMemberspropCount++;
            azureADv2GetAzureADGroupMembers["GroupObjectId"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersGroupObjectId);
            if (azureADv2GetAzureADGroupMembersPropertiesToReturn != null)
            {
                azureADv2GetAzureADGroupMembers["PropertiesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersPropertiesToReturn);
                azureADv2GetAzureADGroupMemberspropCount++;
            }

            if (azureADv2GetAzureADGroupMembersMemberObjectTypesToReturn != null)
            {
                azureADv2GetAzureADGroupMembers["MemberObjectTypesToReturn"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersMemberObjectTypesToReturn);
                azureADv2GetAzureADGroupMemberspropCount++;
            }

            azureADv2GetAzureADGroupMemberspropCount++;
            azureADv2GetAzureADGroupMembers["Workflow"] = ExpressionConverter.ConvertO(azureADv2GetAzureADGroupMembersWorkflow);
            if (azureADv2GetAzureADGroupMemberspropCount > 0)
            {
                callPayload.Body = azureADv2GetAzureADGroupMembers;
            }

            return new ApiConnectionAction<AzureADv2GetAzureADGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse> OpenO365PowerShellRunspace(Expression<Func<string>> openO365PowerShellRunspaceOffice365Username, Expression<Func<string>> openO365PowerShellRunspaceOffice365Password, Expression<Func<string>> openO365PowerShellRunspaceWorkflow, Expression<Func<string>> openO365PowerShellRunspaceExchangeURL = null, Expression<Func<openO365PowerShellRunspaceConnectionMethodInput>> openO365PowerShellRunspaceConnectionMethod = null, Expression<Func<bool>> openO365PowerShellRunspaceOnlyConnectIfNotAlreadyConnected = null, Expression<Func<openO365PowerShellRunspaceCommandTypesToImportLocallyInput>> openO365PowerShellRunspaceCommandTypesToImportLocally = null, Expression<Func<string>> openO365PowerShellRunspaceAdditionalCommandsToImportLocallyCSV = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openO365PowerShellRunspace = new JObject();
            var openO365PowerShellRunspacepropCount = 0;
            openO365PowerShellRunspacepropCount++;
            openO365PowerShellRunspace["Office365Username"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceOffice365Username);
            openO365PowerShellRunspacepropCount++;
            openO365PowerShellRunspace["Office365Password"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceOffice365Password);
            if (openO365PowerShellRunspaceExchangeURL != null)
            {
                openO365PowerShellRunspace["ExchangeURL"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceExchangeURL);
                openO365PowerShellRunspacepropCount++;
            }

            if (openO365PowerShellRunspaceConnectionMethod != null)
            {
                openO365PowerShellRunspace["ConnectionMethod"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceConnectionMethod);
                openO365PowerShellRunspacepropCount++;
            }

            if (openO365PowerShellRunspaceOnlyConnectIfNotAlreadyConnected != null)
            {
                openO365PowerShellRunspace["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceOnlyConnectIfNotAlreadyConnected);
                openO365PowerShellRunspacepropCount++;
            }

            if (openO365PowerShellRunspaceCommandTypesToImportLocally != null)
            {
                openO365PowerShellRunspace["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceCommandTypesToImportLocally);
                openO365PowerShellRunspacepropCount++;
            }

            if (openO365PowerShellRunspaceAdditionalCommandsToImportLocallyCSV != null)
            {
                openO365PowerShellRunspace["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceAdditionalCommandsToImportLocallyCSV);
                openO365PowerShellRunspacepropCount++;
            }

            openO365PowerShellRunspacepropCount++;
            openO365PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWorkflow);
            if (openO365PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = openO365PowerShellRunspace;
            }

            return new ApiConnectionAction<OpenO365PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse> OpenO365PowerShellRunspaceWithCertificate(Expression<Func<string>> openO365PowerShellRunspaceWithCertificateApplicationId, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateCertificateThumbprint, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateOrganization, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateWorkflow, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateExchangeURL = null, Expression<Func<openO365PowerShellRunspaceWithCertificateConnectionMethodInput>> openO365PowerShellRunspaceWithCertificateConnectionMethod = null, Expression<Func<bool>> openO365PowerShellRunspaceWithCertificateOnlyConnectIfNotAlreadyConnected = null, Expression<Func<openO365PowerShellRunspaceWithCertificateCommandTypesToImportLocallyInput>> openO365PowerShellRunspaceWithCertificateCommandTypesToImportLocally = null, Expression<Func<string>> openO365PowerShellRunspaceWithCertificateAdditionalCommandsToImportLocallyCSV = null)
        {
            var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspaceWithCertificate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var openO365PowerShellRunspaceWithCertificate = new JObject();
            var openO365PowerShellRunspaceWithCertificatepropCount = 0;
            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["ApplicationId"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateApplicationId);
            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["CertificateThumbprint"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateCertificateThumbprint);
            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["Organization"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateOrganization);
            if (openO365PowerShellRunspaceWithCertificateExchangeURL != null)
            {
                openO365PowerShellRunspaceWithCertificate["ExchangeURL"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateExchangeURL);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            if (openO365PowerShellRunspaceWithCertificateConnectionMethod != null)
            {
                openO365PowerShellRunspaceWithCertificate["ConnectionMethod"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateConnectionMethod);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            if (openO365PowerShellRunspaceWithCertificateOnlyConnectIfNotAlreadyConnected != null)
            {
                openO365PowerShellRunspaceWithCertificate["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateOnlyConnectIfNotAlreadyConnected);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            if (openO365PowerShellRunspaceWithCertificateCommandTypesToImportLocally != null)
            {
                openO365PowerShellRunspaceWithCertificate["CommandTypesToImportLocally"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateCommandTypesToImportLocally);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            if (openO365PowerShellRunspaceWithCertificateAdditionalCommandsToImportLocallyCSV != null)
            {
                openO365PowerShellRunspaceWithCertificate["AdditionalCommandsToImportLocallyCSV"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateAdditionalCommandsToImportLocallyCSV);
                openO365PowerShellRunspaceWithCertificatepropCount++;
            }

            openO365PowerShellRunspaceWithCertificatepropCount++;
            openO365PowerShellRunspaceWithCertificate["Workflow"] = ExpressionConverter.ConvertO(openO365PowerShellRunspaceWithCertificateWorkflow);
            if (openO365PowerShellRunspaceWithCertificatepropCount > 0)
            {
                callPayload.Body = openO365PowerShellRunspaceWithCertificate;
            }

            return new ApiConnectionAction<OpenO365PowerShellRunspaceWithCertificateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse> IsO365PowerShellRunspaceOpen(Expression<Func<string>> isO365PowerShellRunspaceOpenWorkflow, Expression<Func<bool>> isO365PowerShellRunspaceOpenTestCommunications = null, Expression<Func<bool>> isO365PowerShellRunspaceOpenRetrievePowerShellRunSpacePID = null)
        {
            var apiCallPath = "/PowerShellAutomation/IsO365PowerShellRunspaceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isO365PowerShellRunspaceOpen = new JObject();
            var isO365PowerShellRunspaceOpenpropCount = 0;
            if (isO365PowerShellRunspaceOpenTestCommunications != null)
            {
                isO365PowerShellRunspaceOpen["TestCommunications"] = ExpressionConverter.ConvertO(isO365PowerShellRunspaceOpenTestCommunications);
                isO365PowerShellRunspaceOpenpropCount++;
            }

            if (isO365PowerShellRunspaceOpenRetrievePowerShellRunSpacePID != null)
            {
                isO365PowerShellRunspaceOpen["RetrievePowerShellRunSpacePID"] = ExpressionConverter.ConvertO(isO365PowerShellRunspaceOpenRetrievePowerShellRunSpacePID);
                isO365PowerShellRunspaceOpenpropCount++;
            }

            isO365PowerShellRunspaceOpenpropCount++;
            isO365PowerShellRunspaceOpen["Workflow"] = ExpressionConverter.ConvertO(isO365PowerShellRunspaceOpenWorkflow);
            if (isO365PowerShellRunspaceOpenpropCount > 0)
            {
                callPayload.Body = isO365PowerShellRunspaceOpen;
            }

            return new ApiConnectionAction<IsO365PowerShellRunspaceOpenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse> RunO365PowerShellAutomationScript(Expression<Func<string>> runO365PowerShellAutomationScriptWorkflow, Expression<Func<string>> runO365PowerShellAutomationScriptPowerShellScriptContents = null, Expression<Func<bool>> runO365PowerShellAutomationScriptIsNoResultAnError = null, Expression<Func<bool>> runO365PowerShellAutomationScriptReturnComplexTypes = null, Expression<Func<bool>> runO365PowerShellAutomationScriptReturnBooleanAsBoolean = null, Expression<Func<bool>> runO365PowerShellAutomationScriptReturnNumericAsDecimal = null, Expression<Func<bool>> runO365PowerShellAutomationScriptReturnDateAsDate = null, Expression<Func<string>> runO365PowerShellAutomationScriptPropertiesToReturnAsCollectionJSON = null, Expression<Func<bool>> runO365PowerShellAutomationScriptLocalScope = null, Expression<Func<bool>> runO365PowerShellAutomationScriptRunScriptAsThread = null, Expression<Func<int>> runO365PowerShellAutomationScriptRetrieveOutputDataFromThreadId = null, Expression<Func<int>> runO365PowerShellAutomationScriptSecondsToWaitForThread = null, Expression<Func<bool>> runO365PowerShellAutomationScriptScriptContainsStoredPassword = null, Expression<Func<bool>> runO365PowerShellAutomationScriptLogVerboseOutput = null, Expression<Func<string>> runO365PowerShellAutomationScriptPropertyNamesToSerializeJSON = null, Expression<Func<string>> runO365PowerShellAutomationScriptPropertyTypesToSerializeJSON = null, Expression<Func<runO365PowerShellAutomationScriptPowerShellCommandParametersInputItem[]>> runO365PowerShellAutomationScriptPowerShellCommandParameters = null)
        {
            var apiCallPath = "/PowerShellAutomation/RunO365PowerShellAutomationScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var runO365PowerShellAutomationScript = new JObject();
            var runO365PowerShellAutomationScriptpropCount = 0;
            if (runO365PowerShellAutomationScriptPowerShellScriptContents != null)
            {
                runO365PowerShellAutomationScript["PowerShellScriptContents"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptPowerShellScriptContents);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptIsNoResultAnError != null)
            {
                runO365PowerShellAutomationScript["IsNoResultAnError"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptIsNoResultAnError);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptReturnComplexTypes != null)
            {
                runO365PowerShellAutomationScript["ReturnComplexTypes"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptReturnComplexTypes);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptReturnBooleanAsBoolean != null)
            {
                runO365PowerShellAutomationScript["ReturnBooleanAsBoolean"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptReturnBooleanAsBoolean);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptReturnNumericAsDecimal != null)
            {
                runO365PowerShellAutomationScript["ReturnNumericAsDecimal"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptReturnNumericAsDecimal);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptReturnDateAsDate != null)
            {
                runO365PowerShellAutomationScript["ReturnDateAsDate"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptReturnDateAsDate);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptPropertiesToReturnAsCollectionJSON != null)
            {
                runO365PowerShellAutomationScript["PropertiesToReturnAsCollectionJSON"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptPropertiesToReturnAsCollectionJSON);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptLocalScope != null)
            {
                runO365PowerShellAutomationScript["LocalScope"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptLocalScope);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptRunScriptAsThread != null)
            {
                runO365PowerShellAutomationScript["RunScriptAsThread"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptRunScriptAsThread);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptRetrieveOutputDataFromThreadId != null)
            {
                runO365PowerShellAutomationScript["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptRetrieveOutputDataFromThreadId);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptSecondsToWaitForThread != null)
            {
                runO365PowerShellAutomationScript["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptSecondsToWaitForThread);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptScriptContainsStoredPassword != null)
            {
                runO365PowerShellAutomationScript["ScriptContainsStoredPassword"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptScriptContainsStoredPassword);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptLogVerboseOutput != null)
            {
                runO365PowerShellAutomationScript["LogVerboseOutput"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptLogVerboseOutput);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptPropertyNamesToSerializeJSON != null)
            {
                runO365PowerShellAutomationScript["PropertyNamesToSerializeJSON"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptPropertyNamesToSerializeJSON);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptPropertyTypesToSerializeJSON != null)
            {
                runO365PowerShellAutomationScript["PropertyTypesToSerializeJSON"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptPropertyTypesToSerializeJSON);
                runO365PowerShellAutomationScriptpropCount++;
            }

            if (runO365PowerShellAutomationScriptPowerShellCommandParameters != null)
            {
                runO365PowerShellAutomationScript["PowerShellCommandParameters"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptPowerShellCommandParameters);
                runO365PowerShellAutomationScriptpropCount++;
            }

            runO365PowerShellAutomationScriptpropCount++;
            runO365PowerShellAutomationScript["Workflow"] = ExpressionConverter.ConvertO(runO365PowerShellAutomationScriptWorkflow);
            if (runO365PowerShellAutomationScriptpropCount > 0)
            {
                callPayload.Body = runO365PowerShellAutomationScript;
            }

            return new ApiConnectionAction<RunO365PowerShellAutomationScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse> CloseO365PowerShellRunspace(Expression<Func<string>> closeO365PowerShellRunspaceWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/CloseO365PowerShellRunspace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var closeO365PowerShellRunspace = new JObject();
            var closeO365PowerShellRunspacepropCount = 0;
            closeO365PowerShellRunspacepropCount++;
            closeO365PowerShellRunspace["Workflow"] = ExpressionConverter.ConvertO(closeO365PowerShellRunspaceWorkflow);
            if (closeO365PowerShellRunspacepropCount > 0)
            {
                callPayload.Body = closeO365PowerShellRunspace;
            }

            return new ApiConnectionAction<CloseO365PowerShellRunspaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365MailboxResponse> O365GetO365Mailbox(Expression<Func<string>> o365GetO365MailboxWorkflow, Expression<Func<string>> o365GetO365MailboxIdentity = null, Expression<Func<string>> o365GetO365MailboxFilterPropertyName = null, Expression<Func<o365GetO365MailboxFilterPropertyComparisonInput>> o365GetO365MailboxFilterPropertyComparison = null, Expression<Func<string>> o365GetO365MailboxFilterPropertyValue = null, Expression<Func<o365GetO365MailboxRecipientTypeDetailsInput>> o365GetO365MailboxRecipientTypeDetails = null, Expression<Func<bool>> o365GetO365MailboxNoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetO365Mailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetO365Mailbox = new JObject();
            var o365GetO365MailboxpropCount = 0;
            if (o365GetO365MailboxIdentity != null)
            {
                o365GetO365Mailbox["Identity"] = ExpressionConverter.ConvertO(o365GetO365MailboxIdentity);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxFilterPropertyName != null)
            {
                o365GetO365Mailbox["FilterPropertyName"] = ExpressionConverter.ConvertO(o365GetO365MailboxFilterPropertyName);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxFilterPropertyComparison != null)
            {
                o365GetO365Mailbox["FilterPropertyComparison"] = ExpressionConverter.ConvertO(o365GetO365MailboxFilterPropertyComparison);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxFilterPropertyValue != null)
            {
                o365GetO365Mailbox["FilterPropertyValue"] = ExpressionConverter.ConvertO(o365GetO365MailboxFilterPropertyValue);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxRecipientTypeDetails != null)
            {
                o365GetO365Mailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(o365GetO365MailboxRecipientTypeDetails);
                o365GetO365MailboxpropCount++;
            }

            if (o365GetO365MailboxNoResultIsAnException != null)
            {
                o365GetO365Mailbox["NoResultIsAnException"] = ExpressionConverter.ConvertO(o365GetO365MailboxNoResultIsAnException);
                o365GetO365MailboxpropCount++;
            }

            o365GetO365MailboxpropCount++;
            o365GetO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(o365GetO365MailboxWorkflow);
            if (o365GetO365MailboxpropCount > 0)
            {
                callPayload.Body = o365GetO365Mailbox;
            }

            return new ApiConnectionAction<O365GetO365MailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse> O365AddMailboxPermission(Expression<Func<string>> o365AddMailboxPermissionIdentity, Expression<Func<string>> o365AddMailboxPermissionUser, Expression<Func<string>> o365AddMailboxPermissionAccessRights, Expression<Func<string>> o365AddMailboxPermissionWorkflow, Expression<Func<bool>> o365AddMailboxPermissionAutoMapping = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365AddMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365AddMailboxPermission = new JObject();
            var o365AddMailboxPermissionpropCount = 0;
            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["Identity"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionIdentity);
            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["User"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionUser);
            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionAccessRights);
            if (o365AddMailboxPermissionAutoMapping != null)
            {
                o365AddMailboxPermission["AutoMapping"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionAutoMapping);
                o365AddMailboxPermissionpropCount++;
            }

            o365AddMailboxPermissionpropCount++;
            o365AddMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(o365AddMailboxPermissionWorkflow);
            if (o365AddMailboxPermissionpropCount > 0)
            {
                callPayload.Body = o365AddMailboxPermission;
            }

            return new ApiConnectionAction<O365AddMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse> O365RemoveMailboxPermission(Expression<Func<string>> o365RemoveMailboxPermissionIdentity, Expression<Func<string>> o365RemoveMailboxPermissionUser, Expression<Func<string>> o365RemoveMailboxPermissionAccessRights, Expression<Func<string>> o365RemoveMailboxPermissionWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxPermission";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveMailboxPermission = new JObject();
            var o365RemoveMailboxPermissionpropCount = 0;
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["Identity"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionIdentity);
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["User"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionUser);
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["AccessRights"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionAccessRights);
            o365RemoveMailboxPermissionpropCount++;
            o365RemoveMailboxPermission["Workflow"] = ExpressionConverter.ConvertO(o365RemoveMailboxPermissionWorkflow);
            if (o365RemoveMailboxPermissionpropCount > 0)
            {
                callPayload.Body = o365RemoveMailboxPermission;
            }

            return new ApiConnectionAction<O365RemoveMailboxPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse> O365AddDistributionGroupMember(Expression<Func<string>> o365AddDistributionGroupMemberIdentity, Expression<Func<string>> o365AddDistributionGroupMemberMember, Expression<Func<string>> o365AddDistributionGroupMemberWorkflow, Expression<Func<bool>> o365AddDistributionGroupMemberBypassSecurityGroupManagerCheck = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365AddDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365AddDistributionGroupMember = new JObject();
            var o365AddDistributionGroupMemberpropCount = 0;
            o365AddDistributionGroupMemberpropCount++;
            o365AddDistributionGroupMember["Identity"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberIdentity);
            o365AddDistributionGroupMemberpropCount++;
            o365AddDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberMember);
            if (o365AddDistributionGroupMemberBypassSecurityGroupManagerCheck != null)
            {
                o365AddDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberBypassSecurityGroupManagerCheck);
                o365AddDistributionGroupMemberpropCount++;
            }

            o365AddDistributionGroupMemberpropCount++;
            o365AddDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(o365AddDistributionGroupMemberWorkflow);
            if (o365AddDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = o365AddDistributionGroupMember;
            }

            return new ApiConnectionAction<O365AddDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse> O365GetO365DistributionGroup(Expression<Func<string>> o365GetO365DistributionGroupWorkflow, Expression<Func<string>> o365GetO365DistributionGroupIdentity = null, Expression<Func<string>> o365GetO365DistributionGroupFilterPropertyName = null, Expression<Func<o365GetO365DistributionGroupFilterPropertyComparisonInput>> o365GetO365DistributionGroupFilterPropertyComparison = null, Expression<Func<string>> o365GetO365DistributionGroupFilterPropertyValue = null, Expression<Func<bool>> o365GetO365DistributionGroupNoResultIsAnException = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetO365DistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetO365DistributionGroup = new JObject();
            var o365GetO365DistributionGrouppropCount = 0;
            if (o365GetO365DistributionGroupIdentity != null)
            {
                o365GetO365DistributionGroup["Identity"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupIdentity);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupFilterPropertyName != null)
            {
                o365GetO365DistributionGroup["FilterPropertyName"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupFilterPropertyName);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupFilterPropertyComparison != null)
            {
                o365GetO365DistributionGroup["FilterPropertyComparison"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupFilterPropertyComparison);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupFilterPropertyValue != null)
            {
                o365GetO365DistributionGroup["FilterPropertyValue"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupFilterPropertyValue);
                o365GetO365DistributionGrouppropCount++;
            }

            if (o365GetO365DistributionGroupNoResultIsAnException != null)
            {
                o365GetO365DistributionGroup["NoResultIsAnException"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupNoResultIsAnException);
                o365GetO365DistributionGrouppropCount++;
            }

            o365GetO365DistributionGrouppropCount++;
            o365GetO365DistributionGroup["Workflow"] = ExpressionConverter.ConvertO(o365GetO365DistributionGroupWorkflow);
            if (o365GetO365DistributionGrouppropCount > 0)
            {
                callPayload.Body = o365GetO365DistributionGroup;
            }

            return new ApiConnectionAction<O365GetO365DistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse> O365NewO365DistributionGroup(Expression<Func<string>> o365NewO365DistributionGroupName, Expression<Func<string>> o365NewO365DistributionGroupWorkflow, Expression<Func<string>> o365NewO365DistributionGroupAlias = null, Expression<Func<string>> o365NewO365DistributionGroupDisplayName = null, Expression<Func<string>> o365NewO365DistributionGroupNotes = null, Expression<Func<string>> o365NewO365DistributionGroupManagedBy = null, Expression<Func<string>> o365NewO365DistributionGroupMembers = null, Expression<Func<string>> o365NewO365DistributionGroupOrganizationalUnit = null, Expression<Func<string>> o365NewO365DistributionGroupPrimarySmtpAddress = null, Expression<Func<o365NewO365DistributionGroupMemberDepartRestrictionInput>> o365NewO365DistributionGroupMemberDepartRestriction = null, Expression<Func<o365NewO365DistributionGroupMemberJoinRestrictionInput>> o365NewO365DistributionGroupMemberJoinRestriction = null, Expression<Func<bool>> o365NewO365DistributionGroupRequireSenderAuthenticationEnabled = null, Expression<Func<o365NewO365DistributionGroupTypeInput>> o365NewO365DistributionGroupType = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365NewO365DistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365NewO365DistributionGroup = new JObject();
            var o365NewO365DistributionGrouppropCount = 0;
            o365NewO365DistributionGrouppropCount++;
            o365NewO365DistributionGroup["Name"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupName);
            if (o365NewO365DistributionGroupAlias != null)
            {
                o365NewO365DistributionGroup["Alias"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupAlias);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupDisplayName != null)
            {
                o365NewO365DistributionGroup["DisplayName"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupDisplayName);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupNotes != null)
            {
                o365NewO365DistributionGroup["Notes"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupNotes);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupManagedBy != null)
            {
                o365NewO365DistributionGroup["ManagedBy"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupManagedBy);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupMembers != null)
            {
                o365NewO365DistributionGroup["Members"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupMembers);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupOrganizationalUnit != null)
            {
                o365NewO365DistributionGroup["OrganizationalUnit"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupOrganizationalUnit);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupPrimarySmtpAddress != null)
            {
                o365NewO365DistributionGroup["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupPrimarySmtpAddress);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupMemberDepartRestriction != null)
            {
                o365NewO365DistributionGroup["MemberDepartRestriction"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupMemberDepartRestriction);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupMemberJoinRestriction != null)
            {
                o365NewO365DistributionGroup["MemberJoinRestriction"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupMemberJoinRestriction);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupRequireSenderAuthenticationEnabled != null)
            {
                o365NewO365DistributionGroup["RequireSenderAuthenticationEnabled"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupRequireSenderAuthenticationEnabled);
                o365NewO365DistributionGrouppropCount++;
            }

            if (o365NewO365DistributionGroupType != null)
            {
                o365NewO365DistributionGroup["Type"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupType);
                o365NewO365DistributionGrouppropCount++;
            }

            o365NewO365DistributionGrouppropCount++;
            o365NewO365DistributionGroup["Workflow"] = ExpressionConverter.ConvertO(o365NewO365DistributionGroupWorkflow);
            if (o365NewO365DistributionGrouppropCount > 0)
            {
                callPayload.Body = o365NewO365DistributionGroup;
            }

            return new ApiConnectionAction<O365NewO365DistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse> O365RemoveDistributionGroup(Expression<Func<string>> o365RemoveDistributionGroupIdentity, Expression<Func<string>> o365RemoveDistributionGroupWorkflow, Expression<Func<bool>> o365RemoveDistributionGroupBypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveDistributionGroupErrorIfGroupDoesNotExist = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveDistributionGroup = new JObject();
            var o365RemoveDistributionGrouppropCount = 0;
            o365RemoveDistributionGrouppropCount++;
            o365RemoveDistributionGroup["Identity"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupIdentity);
            if (o365RemoveDistributionGroupBypassSecurityGroupManagerCheck != null)
            {
                o365RemoveDistributionGroup["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupBypassSecurityGroupManagerCheck);
                o365RemoveDistributionGrouppropCount++;
            }

            if (o365RemoveDistributionGroupErrorIfGroupDoesNotExist != null)
            {
                o365RemoveDistributionGroup["ErrorIfGroupDoesNotExist"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupErrorIfGroupDoesNotExist);
                o365RemoveDistributionGrouppropCount++;
            }

            o365RemoveDistributionGrouppropCount++;
            o365RemoveDistributionGroup["Workflow"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupWorkflow);
            if (o365RemoveDistributionGrouppropCount > 0)
            {
                callPayload.Body = o365RemoveDistributionGroup;
            }

            return new ApiConnectionAction<O365RemoveDistributionGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxResponse> O365SetO365Mailbox(Expression<Func<string>> o365SetO365MailboxIdentity, Expression<Func<string>> o365SetO365MailboxWorkflow, Expression<Func<bool>> o365SetO365MailboxAccountDisabled = null, Expression<Func<string>> o365SetO365MailboxAlias = null, Expression<Func<string>> o365SetO365MailboxDisplayName = null, Expression<Func<bool>> o365SetO365MailboxHiddenFromAddressListsEnabled = null, Expression<Func<string>> o365SetO365MailboxCustomAttribute1 = null, Expression<Func<string>> o365SetO365MailboxCustomAttribute2 = null, Expression<Func<string>> o365SetO365MailboxCustomAttribute3 = null, Expression<Func<string>> o365SetO365MailboxCustomAttribute4 = null, Expression<Func<o365SetO365MailboxTypeInput>> o365SetO365MailboxType = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365SetO365Mailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365SetO365Mailbox = new JObject();
            var o365SetO365MailboxpropCount = 0;
            o365SetO365MailboxpropCount++;
            o365SetO365Mailbox["Identity"] = ExpressionConverter.ConvertO(o365SetO365MailboxIdentity);
            if (o365SetO365MailboxAccountDisabled != null)
            {
                o365SetO365Mailbox["AccountDisabled"] = ExpressionConverter.ConvertO(o365SetO365MailboxAccountDisabled);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxAlias != null)
            {
                o365SetO365Mailbox["Alias"] = ExpressionConverter.ConvertO(o365SetO365MailboxAlias);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxDisplayName != null)
            {
                o365SetO365Mailbox["DisplayName"] = ExpressionConverter.ConvertO(o365SetO365MailboxDisplayName);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxHiddenFromAddressListsEnabled != null)
            {
                o365SetO365Mailbox["HiddenFromAddressListsEnabled"] = ExpressionConverter.ConvertO(o365SetO365MailboxHiddenFromAddressListsEnabled);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxCustomAttribute1 != null)
            {
                o365SetO365Mailbox["CustomAttribute1"] = ExpressionConverter.ConvertO(o365SetO365MailboxCustomAttribute1);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxCustomAttribute2 != null)
            {
                o365SetO365Mailbox["CustomAttribute2"] = ExpressionConverter.ConvertO(o365SetO365MailboxCustomAttribute2);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxCustomAttribute3 != null)
            {
                o365SetO365Mailbox["CustomAttribute3"] = ExpressionConverter.ConvertO(o365SetO365MailboxCustomAttribute3);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxCustomAttribute4 != null)
            {
                o365SetO365Mailbox["CustomAttribute4"] = ExpressionConverter.ConvertO(o365SetO365MailboxCustomAttribute4);
                o365SetO365MailboxpropCount++;
            }

            if (o365SetO365MailboxType != null)
            {
                o365SetO365Mailbox["Type"] = ExpressionConverter.ConvertO(o365SetO365MailboxType);
                o365SetO365MailboxpropCount++;
            }

            o365SetO365MailboxpropCount++;
            o365SetO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(o365SetO365MailboxWorkflow);
            if (o365SetO365MailboxpropCount > 0)
            {
                callPayload.Body = o365SetO365Mailbox;
            }

            return new ApiConnectionAction<O365SetO365MailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse> O365WaitForO365Mailbox(Expression<Func<string>> o365WaitForO365MailboxIdentity, Expression<Func<int>> o365WaitForO365MailboxNumberOfTimesToCheck, Expression<Func<int>> o365WaitForO365MailboxSecondsBetweenTries, Expression<Func<string>> o365WaitForO365MailboxWorkflow, Expression<Func<o365WaitForO365MailboxRecipientTypeDetailsInput>> o365WaitForO365MailboxRecipientTypeDetails = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365WaitForO365Mailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365WaitForO365Mailbox = new JObject();
            var o365WaitForO365MailboxpropCount = 0;
            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["Identity"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxIdentity);
            if (o365WaitForO365MailboxRecipientTypeDetails != null)
            {
                o365WaitForO365Mailbox["RecipientTypeDetails"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxRecipientTypeDetails);
                o365WaitForO365MailboxpropCount++;
            }

            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["NumberOfTimesToCheck"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxNumberOfTimesToCheck);
            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["SecondsBetweenTries"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxSecondsBetweenTries);
            o365WaitForO365MailboxpropCount++;
            o365WaitForO365Mailbox["Workflow"] = ExpressionConverter.ConvertO(o365WaitForO365MailboxWorkflow);
            if (o365WaitForO365MailboxpropCount > 0)
            {
                callPayload.Body = o365WaitForO365Mailbox;
            }

            return new ApiConnectionAction<O365WaitForO365MailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse> O365SetO365MailboxAutoReplyConfiguration(Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationIdentity, Expression<Func<o365SetO365MailboxAutoReplyConfigurationAutoReplyStateInput>> o365SetO365MailboxAutoReplyConfigurationAutoReplyState, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationWorkflow, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationInternalMessage = null, Expression<Func<o365SetO365MailboxAutoReplyConfigurationExternalAudienceInput>> o365SetO365MailboxAutoReplyConfigurationExternalAudience = null, Expression<Func<string>> o365SetO365MailboxAutoReplyConfigurationExternalMessage = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365SetO365MailboxAutoReplyConfiguration";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365SetO365MailboxAutoReplyConfiguration = new JObject();
            var o365SetO365MailboxAutoReplyConfigurationpropCount = 0;
            o365SetO365MailboxAutoReplyConfigurationpropCount++;
            o365SetO365MailboxAutoReplyConfiguration["Identity"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationIdentity);
            o365SetO365MailboxAutoReplyConfigurationpropCount++;
            o365SetO365MailboxAutoReplyConfiguration["AutoReplyState"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationAutoReplyState);
            if (o365SetO365MailboxAutoReplyConfigurationInternalMessage != null)
            {
                o365SetO365MailboxAutoReplyConfiguration["InternalMessage"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationInternalMessage);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
            }

            if (o365SetO365MailboxAutoReplyConfigurationExternalAudience != null)
            {
                o365SetO365MailboxAutoReplyConfiguration["ExternalAudience"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationExternalAudience);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
            }

            if (o365SetO365MailboxAutoReplyConfigurationExternalMessage != null)
            {
                o365SetO365MailboxAutoReplyConfiguration["ExternalMessage"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationExternalMessage);
                o365SetO365MailboxAutoReplyConfigurationpropCount++;
            }

            o365SetO365MailboxAutoReplyConfigurationpropCount++;
            o365SetO365MailboxAutoReplyConfiguration["Workflow"] = ExpressionConverter.ConvertO(o365SetO365MailboxAutoReplyConfigurationWorkflow);
            if (o365SetO365MailboxAutoReplyConfigurationpropCount > 0)
            {
                callPayload.Body = o365SetO365MailboxAutoReplyConfiguration;
            }

            return new ApiConnectionAction<O365SetO365MailboxAutoReplyConfigurationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse> O365RemoveDistributionGroupMember(Expression<Func<string>> o365RemoveDistributionGroupMemberGroupIdentity, Expression<Func<string>> o365RemoveDistributionGroupMemberMember, Expression<Func<string>> o365RemoveDistributionGroupMemberWorkflow, Expression<Func<bool>> o365RemoveDistributionGroupMemberBypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveDistributionGroupMemberExceptionIfMemberNotInGroup = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroupMember";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveDistributionGroupMember = new JObject();
            var o365RemoveDistributionGroupMemberpropCount = 0;
            o365RemoveDistributionGroupMemberpropCount++;
            o365RemoveDistributionGroupMember["GroupIdentity"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberGroupIdentity);
            o365RemoveDistributionGroupMemberpropCount++;
            o365RemoveDistributionGroupMember["Member"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberMember);
            if (o365RemoveDistributionGroupMemberBypassSecurityGroupManagerCheck != null)
            {
                o365RemoveDistributionGroupMember["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberBypassSecurityGroupManagerCheck);
                o365RemoveDistributionGroupMemberpropCount++;
            }

            if (o365RemoveDistributionGroupMemberExceptionIfMemberNotInGroup != null)
            {
                o365RemoveDistributionGroupMember["ExceptionIfMemberNotInGroup"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberExceptionIfMemberNotInGroup);
                o365RemoveDistributionGroupMemberpropCount++;
            }

            o365RemoveDistributionGroupMemberpropCount++;
            o365RemoveDistributionGroupMember["Workflow"] = ExpressionConverter.ConvertO(o365RemoveDistributionGroupMemberWorkflow);
            if (o365RemoveDistributionGroupMemberpropCount > 0)
            {
                callPayload.Body = o365RemoveDistributionGroupMember;
            }

            return new ApiConnectionAction<O365RemoveDistributionGroupMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse> O365GetMailboxDistributionGroupMembership(Expression<Func<string>> o365GetMailboxDistributionGroupMembershipMailboxIdentity, Expression<Func<string>> o365GetMailboxDistributionGroupMembershipWorkflow, Expression<Func<string>> o365GetMailboxDistributionGroupMembershipPropertiesToRetrieveJSON = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetMailboxDistributionGroupMembership";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetMailboxDistributionGroupMembership = new JObject();
            var o365GetMailboxDistributionGroupMembershippropCount = 0;
            o365GetMailboxDistributionGroupMembershippropCount++;
            o365GetMailboxDistributionGroupMembership["MailboxIdentity"] = ExpressionConverter.ConvertO(o365GetMailboxDistributionGroupMembershipMailboxIdentity);
            if (o365GetMailboxDistributionGroupMembershipPropertiesToRetrieveJSON != null)
            {
                o365GetMailboxDistributionGroupMembership["PropertiesToRetrieveJSON"] = ExpressionConverter.ConvertO(o365GetMailboxDistributionGroupMembershipPropertiesToRetrieveJSON);
                o365GetMailboxDistributionGroupMembershippropCount++;
            }

            o365GetMailboxDistributionGroupMembershippropCount++;
            o365GetMailboxDistributionGroupMembership["Workflow"] = ExpressionConverter.ConvertO(o365GetMailboxDistributionGroupMembershipWorkflow);
            if (o365GetMailboxDistributionGroupMembershippropCount > 0)
            {
                callPayload.Body = o365GetMailboxDistributionGroupMembership;
            }

            return new ApiConnectionAction<O365GetMailboxDistributionGroupMembershipResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse> O365GetDistributionGroupMembers(Expression<Func<string>> o365GetDistributionGroupMembersGroupIdentity, Expression<Func<string>> o365GetDistributionGroupMembersWorkflow, Expression<Func<string>> o365GetDistributionGroupMembersPropertiesToRetrieveJSON = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365GetDistributionGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365GetDistributionGroupMembers = new JObject();
            var o365GetDistributionGroupMemberspropCount = 0;
            o365GetDistributionGroupMemberspropCount++;
            o365GetDistributionGroupMembers["GroupIdentity"] = ExpressionConverter.ConvertO(o365GetDistributionGroupMembersGroupIdentity);
            if (o365GetDistributionGroupMembersPropertiesToRetrieveJSON != null)
            {
                o365GetDistributionGroupMembers["PropertiesToRetrieveJSON"] = ExpressionConverter.ConvertO(o365GetDistributionGroupMembersPropertiesToRetrieveJSON);
                o365GetDistributionGroupMemberspropCount++;
            }

            o365GetDistributionGroupMemberspropCount++;
            o365GetDistributionGroupMembers["Workflow"] = ExpressionConverter.ConvertO(o365GetDistributionGroupMembersWorkflow);
            if (o365GetDistributionGroupMemberspropCount > 0)
            {
                callPayload.Body = o365GetDistributionGroupMembers;
            }

            return new ApiConnectionAction<O365GetDistributionGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse> O365RemoveMailboxFromAllDistributionGroups(Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsWorkflow, Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsMailboxIdentity = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsBypassSecurityGroupManagerCheck = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsExceptionIfAnyGroupsFailToRemove = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsExceptionIfAllGroupsFailToRemove = null, Expression<Func<string>> o365RemoveMailboxFromAllDistributionGroupsGroupDNsToExcludeJSON = null, Expression<Func<bool>> o365RemoveMailboxFromAllDistributionGroupsRunAsThread = null, Expression<Func<int>> o365RemoveMailboxFromAllDistributionGroupsRetrieveOutputDataFromThreadId = null, Expression<Func<int>> o365RemoveMailboxFromAllDistributionGroupsSecondsToWaitForThread = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxFromAllDistributionGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365RemoveMailboxFromAllDistributionGroups = new JObject();
            var o365RemoveMailboxFromAllDistributionGroupspropCount = 0;
            if (o365RemoveMailboxFromAllDistributionGroupsMailboxIdentity != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["MailboxIdentity"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsMailboxIdentity);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsBypassSecurityGroupManagerCheck != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["BypassSecurityGroupManagerCheck"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsBypassSecurityGroupManagerCheck);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsExceptionIfAnyGroupsFailToRemove != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAnyGroupsFailToRemove"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsExceptionIfAnyGroupsFailToRemove);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsExceptionIfAllGroupsFailToRemove != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["ExceptionIfAllGroupsFailToRemove"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsExceptionIfAllGroupsFailToRemove);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsGroupDNsToExcludeJSON != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["GroupDNsToExcludeJSON"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsGroupDNsToExcludeJSON);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsRunAsThread != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["RunAsThread"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsRunAsThread);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsRetrieveOutputDataFromThreadId != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsRetrieveOutputDataFromThreadId);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            if (o365RemoveMailboxFromAllDistributionGroupsSecondsToWaitForThread != null)
            {
                o365RemoveMailboxFromAllDistributionGroups["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsSecondsToWaitForThread);
                o365RemoveMailboxFromAllDistributionGroupspropCount++;
            }

            o365RemoveMailboxFromAllDistributionGroupspropCount++;
            o365RemoveMailboxFromAllDistributionGroups["Workflow"] = ExpressionConverter.ConvertO(o365RemoveMailboxFromAllDistributionGroupsWorkflow);
            if (o365RemoveMailboxFromAllDistributionGroupspropCount > 0)
            {
                callPayload.Body = o365RemoveMailboxFromAllDistributionGroups;
            }

            return new ApiConnectionAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewMailboxResponse> O365NewMailbox(Expression<Func<string>> o365NewMailboxMicrosoftOnlineServicesID, Expression<Func<string>> o365NewMailboxName, Expression<Func<string>> o365NewMailboxWorkflow, Expression<Func<string>> o365NewMailboxFirstName = null, Expression<Func<string>> o365NewMailboxLastName = null, Expression<Func<string>> o365NewMailboxInitials = null, Expression<Func<string>> o365NewMailboxDisplayName = null, Expression<Func<string>> o365NewMailboxAlias = null, Expression<Func<string>> o365NewMailboxPrimarySmtpAddress = null, Expression<Func<string>> o365NewMailboxPassword = null, Expression<Func<bool>> o365NewMailboxAccountPasswordIsStoredPassword = null, Expression<Func<bool>> o365NewMailboxResetPasswordOnNextLogon = null, Expression<Func<bool>> o365NewMailboxArchive = null, Expression<Func<string>> o365NewMailboxMailboxPlan = null, Expression<Func<string>> o365NewMailboxMailboxRegion = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365NewMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365NewMailbox = new JObject();
            var o365NewMailboxpropCount = 0;
            o365NewMailboxpropCount++;
            o365NewMailbox["MicrosoftOnlineServicesID"] = ExpressionConverter.ConvertO(o365NewMailboxMicrosoftOnlineServicesID);
            o365NewMailboxpropCount++;
            o365NewMailbox["Name"] = ExpressionConverter.ConvertO(o365NewMailboxName);
            if (o365NewMailboxFirstName != null)
            {
                o365NewMailbox["FirstName"] = ExpressionConverter.ConvertO(o365NewMailboxFirstName);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxLastName != null)
            {
                o365NewMailbox["LastName"] = ExpressionConverter.ConvertO(o365NewMailboxLastName);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxInitials != null)
            {
                o365NewMailbox["Initials"] = ExpressionConverter.ConvertO(o365NewMailboxInitials);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxDisplayName != null)
            {
                o365NewMailbox["DisplayName"] = ExpressionConverter.ConvertO(o365NewMailboxDisplayName);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxAlias != null)
            {
                o365NewMailbox["Alias"] = ExpressionConverter.ConvertO(o365NewMailboxAlias);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxPrimarySmtpAddress != null)
            {
                o365NewMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(o365NewMailboxPrimarySmtpAddress);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxPassword != null)
            {
                o365NewMailbox["Password"] = ExpressionConverter.ConvertO(o365NewMailboxPassword);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxAccountPasswordIsStoredPassword != null)
            {
                o365NewMailbox["AccountPasswordIsStoredPassword"] = ExpressionConverter.ConvertO(o365NewMailboxAccountPasswordIsStoredPassword);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxResetPasswordOnNextLogon != null)
            {
                o365NewMailbox["ResetPasswordOnNextLogon"] = ExpressionConverter.ConvertO(o365NewMailboxResetPasswordOnNextLogon);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxArchive != null)
            {
                o365NewMailbox["Archive"] = ExpressionConverter.ConvertO(o365NewMailboxArchive);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxMailboxPlan != null)
            {
                o365NewMailbox["MailboxPlan"] = ExpressionConverter.ConvertO(o365NewMailboxMailboxPlan);
                o365NewMailboxpropCount++;
            }

            if (o365NewMailboxMailboxRegion != null)
            {
                o365NewMailbox["MailboxRegion"] = ExpressionConverter.ConvertO(o365NewMailboxMailboxRegion);
                o365NewMailboxpropCount++;
            }

            o365NewMailboxpropCount++;
            o365NewMailbox["Workflow"] = ExpressionConverter.ConvertO(o365NewMailboxWorkflow);
            if (o365NewMailboxpropCount > 0)
            {
                callPayload.Body = o365NewMailbox;
            }

            return new ApiConnectionAction<O365NewMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse> O365NewSharedMailbox(Expression<Func<string>> o365NewSharedMailboxName, Expression<Func<string>> o365NewSharedMailboxWorkflow, Expression<Func<string>> o365NewSharedMailboxFirstName = null, Expression<Func<string>> o365NewSharedMailboxLastName = null, Expression<Func<string>> o365NewSharedMailboxInitials = null, Expression<Func<string>> o365NewSharedMailboxDisplayName = null, Expression<Func<string>> o365NewSharedMailboxAlias = null, Expression<Func<string>> o365NewSharedMailboxPrimarySmtpAddress = null, Expression<Func<bool>> o365NewSharedMailboxArchive = null, Expression<Func<string>> o365NewSharedMailboxMailboxRegion = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365NewSharedMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365NewSharedMailbox = new JObject();
            var o365NewSharedMailboxpropCount = 0;
            o365NewSharedMailboxpropCount++;
            o365NewSharedMailbox["Name"] = ExpressionConverter.ConvertO(o365NewSharedMailboxName);
            if (o365NewSharedMailboxFirstName != null)
            {
                o365NewSharedMailbox["FirstName"] = ExpressionConverter.ConvertO(o365NewSharedMailboxFirstName);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxLastName != null)
            {
                o365NewSharedMailbox["LastName"] = ExpressionConverter.ConvertO(o365NewSharedMailboxLastName);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxInitials != null)
            {
                o365NewSharedMailbox["Initials"] = ExpressionConverter.ConvertO(o365NewSharedMailboxInitials);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxDisplayName != null)
            {
                o365NewSharedMailbox["DisplayName"] = ExpressionConverter.ConvertO(o365NewSharedMailboxDisplayName);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxAlias != null)
            {
                o365NewSharedMailbox["Alias"] = ExpressionConverter.ConvertO(o365NewSharedMailboxAlias);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxPrimarySmtpAddress != null)
            {
                o365NewSharedMailbox["PrimarySmtpAddress"] = ExpressionConverter.ConvertO(o365NewSharedMailboxPrimarySmtpAddress);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxArchive != null)
            {
                o365NewSharedMailbox["Archive"] = ExpressionConverter.ConvertO(o365NewSharedMailboxArchive);
                o365NewSharedMailboxpropCount++;
            }

            if (o365NewSharedMailboxMailboxRegion != null)
            {
                o365NewSharedMailbox["MailboxRegion"] = ExpressionConverter.ConvertO(o365NewSharedMailboxMailboxRegion);
                o365NewSharedMailboxpropCount++;
            }

            o365NewSharedMailboxpropCount++;
            o365NewSharedMailbox["Workflow"] = ExpressionConverter.ConvertO(o365NewSharedMailboxWorkflow);
            if (o365NewSharedMailboxpropCount > 0)
            {
                callPayload.Body = o365NewSharedMailbox;
            }

            return new ApiConnectionAction<O365NewSharedMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse> O365EnableArchiveMailbox(Expression<Func<string>> o365EnableArchiveMailboxIdentity, Expression<Func<string>> o365EnableArchiveMailboxWorkflow, Expression<Func<bool>> o365EnableArchiveMailboxCheckIfArchiveExists = null, Expression<Func<string>> o365EnableArchiveMailboxArchiveName = null, Expression<Func<bool>> o365EnableArchiveMailboxAutoExpandingArchive = null)
        {
            var apiCallPath = "/PowerShellAutomation/O365EnableArchiveMailbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365EnableArchiveMailbox = new JObject();
            var o365EnableArchiveMailboxpropCount = 0;
            o365EnableArchiveMailboxpropCount++;
            o365EnableArchiveMailbox["Identity"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxIdentity);
            if (o365EnableArchiveMailboxCheckIfArchiveExists != null)
            {
                o365EnableArchiveMailbox["CheckIfArchiveExists"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxCheckIfArchiveExists);
                o365EnableArchiveMailboxpropCount++;
            }

            if (o365EnableArchiveMailboxArchiveName != null)
            {
                o365EnableArchiveMailbox["ArchiveName"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxArchiveName);
                o365EnableArchiveMailboxpropCount++;
            }

            if (o365EnableArchiveMailboxAutoExpandingArchive != null)
            {
                o365EnableArchiveMailbox["AutoExpandingArchive"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxAutoExpandingArchive);
                o365EnableArchiveMailboxpropCount++;
            }

            o365EnableArchiveMailboxpropCount++;
            o365EnableArchiveMailbox["Workflow"] = ExpressionConverter.ConvertO(o365EnableArchiveMailboxWorkflow);
            if (o365EnableArchiveMailboxpropCount > 0)
            {
                callPayload.Body = o365EnableArchiveMailbox;
            }

            return new ApiConnectionAction<O365EnableArchiveMailboxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse> O365DoesMailboxHaveAnArchive(Expression<Func<string>> o365DoesMailboxHaveAnArchiveIdentity, Expression<Func<string>> o365DoesMailboxHaveAnArchiveWorkflow)
        {
            var apiCallPath = "/PowerShellAutomation/O365DoesMailboxHaveAnArchive";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var o365DoesMailboxHaveAnArchive = new JObject();
            var o365DoesMailboxHaveAnArchivepropCount = 0;
            o365DoesMailboxHaveAnArchivepropCount++;
            o365DoesMailboxHaveAnArchive["Identity"] = ExpressionConverter.ConvertO(o365DoesMailboxHaveAnArchiveIdentity);
            o365DoesMailboxHaveAnArchivepropCount++;
            o365DoesMailboxHaveAnArchive["Workflow"] = ExpressionConverter.ConvertO(o365DoesMailboxHaveAnArchiveWorkflow);
            if (o365DoesMailboxHaveAnArchivepropCount > 0)
            {
                callPayload.Body = o365DoesMailboxHaveAnArchive;
            }

            return new ApiConnectionAction<O365DoesMailboxHaveAnArchiveResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse> JMLGetNextAvailableAccountName(Expression<Func<string>> jMLGetNextAvailableAccountNameWorkflow, Expression<Func<string>> jMLGetNextAvailableAccountNameFirstName = null, Expression<Func<string>> jMLGetNextAvailableAccountNameMiddleName = null, Expression<Func<string>> jMLGetNextAvailableAccountNameLastName = null, Expression<Func<string>> jMLGetNextAvailableAccountNameFieldA = null, Expression<Func<string>> jMLGetNextAvailableAccountNameFieldB = null, Expression<Func<string>> jMLGetNextAvailableAccountNameFieldC = null, Expression<Func<string>> jMLGetNextAvailableAccountNameFieldD = null, Expression<Func<int>> jMLGetNextAvailableAccountNameVariableMStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNameVariableNStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNameVariableXStartValue = null, Expression<Func<int>> jMLGetNextAvailableAccountNameMaxAttempts = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameFallbackCausesRetest = null, Expression<Func<string>> jMLGetNextAvailableAccountNameNumbersNotToUse = null, Expression<Func<string>> jMLGetNextAvailableAccountNameCharactersToRemoveFromInputs = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameRemoveDiacriticsFromInputs = null, Expression<Func<bool>> jMLGetNextAvailableAccountNameRemoveNonAlphaNumericFromInputs = null, Expression<Func<string>> jMLGetNextAvailableAccountNameSequenceA1 = null, Expression<Func<jMLGetNextAvailableAccountNamePropertiesToCheckListInputItem[]>> jMLGetNextAvailableAccountNamePropertiesToCheckList = null)
        {
            var apiCallPath = "/PowerShellAutomation/JMLGetNextAvailableAccountName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jMLGetNextAvailableAccountName = new JObject();
            var jMLGetNextAvailableAccountNamepropCount = 0;
            if (jMLGetNextAvailableAccountNameFirstName != null)
            {
                jMLGetNextAvailableAccountName["FirstName"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameFirstName);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameMiddleName != null)
            {
                jMLGetNextAvailableAccountName["MiddleName"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameMiddleName);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameLastName != null)
            {
                jMLGetNextAvailableAccountName["LastName"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameLastName);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameFieldA != null)
            {
                jMLGetNextAvailableAccountName["FieldA"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameFieldA);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameFieldB != null)
            {
                jMLGetNextAvailableAccountName["FieldB"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameFieldB);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameFieldC != null)
            {
                jMLGetNextAvailableAccountName["FieldC"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameFieldC);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameFieldD != null)
            {
                jMLGetNextAvailableAccountName["FieldD"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameFieldD);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameVariableMStartValue != null)
            {
                jMLGetNextAvailableAccountName["VariableMStartValue"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameVariableMStartValue);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameVariableNStartValue != null)
            {
                jMLGetNextAvailableAccountName["VariableNStartValue"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameVariableNStartValue);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameVariableXStartValue != null)
            {
                jMLGetNextAvailableAccountName["VariableXStartValue"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameVariableXStartValue);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameMaxAttempts != null)
            {
                jMLGetNextAvailableAccountName["MaxAttempts"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameMaxAttempts);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameFallbackCausesRetest != null)
            {
                jMLGetNextAvailableAccountName["FallbackCausesRetest"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameFallbackCausesRetest);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameNumbersNotToUse != null)
            {
                jMLGetNextAvailableAccountName["NumbersNotToUse"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameNumbersNotToUse);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameCharactersToRemoveFromInputs != null)
            {
                jMLGetNextAvailableAccountName["CharactersToRemoveFromInputs"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameCharactersToRemoveFromInputs);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameRemoveDiacriticsFromInputs != null)
            {
                jMLGetNextAvailableAccountName["RemoveDiacriticsFromInputs"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameRemoveDiacriticsFromInputs);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameRemoveNonAlphaNumericFromInputs != null)
            {
                jMLGetNextAvailableAccountName["RemoveNonAlphaNumericFromInputs"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameRemoveNonAlphaNumericFromInputs);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNameSequenceA1 != null)
            {
                jMLGetNextAvailableAccountName["SequenceA1"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameSequenceA1);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            if (jMLGetNextAvailableAccountNamePropertiesToCheckList != null)
            {
                jMLGetNextAvailableAccountName["PropertiesToCheckList"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNamePropertiesToCheckList);
                jMLGetNextAvailableAccountNamepropCount++;
            }

            jMLGetNextAvailableAccountNamepropCount++;
            jMLGetNextAvailableAccountName["Workflow"] = ExpressionConverter.ConvertO(jMLGetNextAvailableAccountNameWorkflow);
            if (jMLGetNextAvailableAccountNamepropCount > 0)
            {
                callPayload.Body = jMLGetNextAvailableAccountName;
            }

            return new ApiConnectionAction<JMLGetNextAvailableAccountNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse> JMLConnectToJMLEnvironment(Expression<Func<string>> jMLConnectToJMLEnvironmentWorkflow, Expression<Func<string>> jMLConnectToJMLEnvironmentFriendlyName = null, Expression<Func<bool>> jMLConnectToJMLEnvironmentOnlyConnectIfNotAlreadyConnected = null)
        {
            var apiCallPath = "/PowerShellAutomation/JMLConnectToJMLEnvironment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jMLConnectToJMLEnvironment = new JObject();
            var jMLConnectToJMLEnvironmentpropCount = 0;
            if (jMLConnectToJMLEnvironmentFriendlyName != null)
            {
                jMLConnectToJMLEnvironment["FriendlyName"] = ExpressionConverter.ConvertO(jMLConnectToJMLEnvironmentFriendlyName);
                jMLConnectToJMLEnvironmentpropCount++;
            }

            if (jMLConnectToJMLEnvironmentOnlyConnectIfNotAlreadyConnected != null)
            {
                jMLConnectToJMLEnvironment["OnlyConnectIfNotAlreadyConnected"] = ExpressionConverter.ConvertO(jMLConnectToJMLEnvironmentOnlyConnectIfNotAlreadyConnected);
                jMLConnectToJMLEnvironmentpropCount++;
            }

            jMLConnectToJMLEnvironmentpropCount++;
            jMLConnectToJMLEnvironment["Workflow"] = ExpressionConverter.ConvertO(jMLConnectToJMLEnvironmentWorkflow);
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

    public class runActiveDirectoryPowerShellAutomationScriptPowerShellCommandParametersInputItem
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

    public enum activeDirectoryGetADUserByIdentityFilterPropertyComparisonInput
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

    public enum activeDirectoryGetADGroupByIdentityFilterPropertyComparisonInput
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

    public class activeDirectoryModifyADUserStringPropertyByIdentityPropertiesListInputItem
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

    public enum activeDirectoryDirSyncPolicyTypeInput
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

    public enum activeDirectorySetADServerPredefinedADServerChoiceInput
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

    public enum activeDirectoryGetDomainInfoPredefinedIdentityInput
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

    public enum activeDirectoryAddADGroupGroupCategoryInput
    {
        [EnumMember(Value = "Security")]
        SecurityGroup,
        [EnumMember(Value = "Distribution")]
        DistributionGroup
    }

    public enum activeDirectoryAddADGroupGroupScopeInput
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

    public enum openExchangePowerShellRunspaceConnectionMethodInput
    {
        [EnumMember(Value = "Local")]
        LocalRemoteExchangeRunspaceIsImportedLocally,
        [EnumMember(Value = "Remote")]
        RemoteCommandsRunInRemoteExchangeRunspace
    }

    public enum openExchangePowerShellRunspaceAuthenticationMechanismInput
    {
        Basic,
        CredSSP,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    public enum openExchangePowerShellRunspaceCommandTypesToImportLocallyInput
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

    public class runExchangePowerShellAutomationScriptPowerShellCommandParametersInputItem
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

    public enum exchangeGetMailboxFilterPropertyComparisonInput
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

    public enum exchangeGetMailboxRecipientTypeDetailsInput
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

    public enum exchangeDoesMailboxExistFilterPropertyComparisonInput
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

    public enum exchangeDoesMailboxExistRecipientTypeDetailsInput
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

    public enum exchangeGetDistributionGroupFilterPropertyComparisonInput
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

    public enum exchangeNewDistributionGroupMemberDepartRestrictionInput
    {
        Open,
        Closed
    }

    public enum exchangeNewDistributionGroupMemberJoinRestrictionInput
    {
        Open,
        Closed,
        ApprovalRequired
    }

    public enum exchangeNewDistributionGroupTypeInput
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

    public enum exchangeGetRemoteMailboxFilterPropertyComparisonInput
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

    public enum exchangeDoesRemoteMailboxExistFilterPropertyComparisonInput
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

    public enum exchangeSetRemoteMailboxTypeInput
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

    public enum exchangeSetMailboxAutoReplyConfigurationAutoReplyStateInput
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

    public enum exchangeSetMailboxAutoReplyConfigurationExternalAudienceInput
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

    public enum openAzureADv2PowerShellRunspaceAPIToUseInput
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

    public enum openAzureADv2PowerShellRunspaceWithCertificateAPIToUseInput
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

    public class runAzureADv2PowerShellAutomationScriptPowerShellCommandParametersInputItem
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

    public enum azureADv2GetAzureADUsersFilterPropertyComparisonInput
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

    public enum azureADv2AddAzureADUserAgeGroupInput
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

    public enum azureADv2AddAzureADUserConsentProvidedForMinorInput
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

    public enum azureADv2GetAzureADLicenseSKUsExpandPropertyInput
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

    public enum azureADv2SetAzureADUserLicenseLicensePlansChoiceInput
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

    public enum azureADv2SetAzureADUserAgeGroupInput
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

    public enum azureADv2SetAzureADUserConsentProvidedForMinorInput
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

    public enum azureADv2NewMicrosoft365GroupGroupVisibilityInput
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

    public enum azureADv2GetGroupsFilterPropertyComparisonInput
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

    public enum openO365PowerShellRunspaceConnectionMethodInput
    {
        [EnumMember(Value = "EXO V1 local")]
        EXOV1LocalRemoteExchangeOnlineIsImportedLocally,
        [EnumMember(Value = "EXO V1 remote")]
        EXOV1RemoteCommandsRunInRemoteExchangeOnline,
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

    public enum openO365PowerShellRunspaceCommandTypesToImportLocallyInput
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

    public enum openO365PowerShellRunspaceWithCertificateConnectionMethodInput
    {
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

    public enum openO365PowerShellRunspaceWithCertificateCommandTypesToImportLocallyInput
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

    public class runO365PowerShellAutomationScriptPowerShellCommandParametersInputItem
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

    public enum o365GetO365MailboxFilterPropertyComparisonInput
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

    public enum o365GetO365MailboxRecipientTypeDetailsInput
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

    public enum o365GetO365DistributionGroupFilterPropertyComparisonInput
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

    public enum o365NewO365DistributionGroupMemberDepartRestrictionInput
    {
        Open,
        Closed
    }

    public enum o365NewO365DistributionGroupMemberJoinRestrictionInput
    {
        Open,
        Closed,
        ApprovalRequired
    }

    public enum o365NewO365DistributionGroupTypeInput
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

    public enum o365SetO365MailboxTypeInput
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

    public enum o365WaitForO365MailboxRecipientTypeDetailsInput
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

    public enum o365SetO365MailboxAutoReplyConfigurationAutoReplyStateInput
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

    public enum o365SetO365MailboxAutoReplyConfigurationExternalAudienceInput
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

    public class jMLGetNextAvailableAccountNamePropertiesToCheckListInputItem
    {
        public jMLGetNextAvailableAccountNamePropertiesToCheckListInputItemPropertyToCheckType PropertyToCheck { get; set; }
        public string PropertyNameFormat { get; set; }
        public string PropertyNameFallbackFormat { get; set; }
        public string PropertyNameFallbackFormat2 { get; set; }
        public int PropertyNameMaxLength { get; set; }
        public jMLGetNextAvailableAccountNamePropertiesToCheckListInputItemPropertyNameMaxLengthFieldToCutType PropertyNameMaxLengthFieldToCut { get; set; }
    }

    public enum jMLGetNextAvailableAccountNamePropertiesToCheckListInputItemPropertyToCheckType
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

    public enum jMLGetNextAvailableAccountNamePropertiesToCheckListInputItemPropertyNameMaxLengthFieldToCutType
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