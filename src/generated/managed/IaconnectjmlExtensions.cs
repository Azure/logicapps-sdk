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
        public IBodyWorkflowAction<RunActiveDirectoryPowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunActiveDirectoryPowerShellAutomationScript(Expression<Func<RunActiveDirectoryPowerShellAutomationScriptInput>> runActiveDirectoryPowerShellAutomationScript)
        {
            var __workflow_runActiveDirectoryPowerShellAutomationScript = WorkflowExpression.Compile(runActiveDirectoryPowerShellAutomationScript, nameof(runActiveDirectoryPowerShellAutomationScript), required: true);
            return new DeferredBodyAction<RunActiveDirectoryPowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunActiveDirectoryPowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runActiveDirectoryPowerShellAutomationScript);
                return new ApiConnectionAction<RunActiveDirectoryPowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse, ApiConnectionActionConfiguration> OpenActiveDirectoryPowerShellRunspaceWithCredentials(Expression<Func<OpenActiveDirectoryPowerShellRunspaceWithCredentialsInput>> openActiveDirectoryPowerShellRunspaceWithCredentials)
        {
            var __workflow_openActiveDirectoryPowerShellRunspaceWithCredentials = WorkflowExpression.Compile(openActiveDirectoryPowerShellRunspaceWithCredentials, nameof(openActiveDirectoryPowerShellRunspaceWithCredentials), required: true);
            return new DeferredBodyAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenActiveDirectoryPowerShellRunspaceWithCredentials";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openActiveDirectoryPowerShellRunspaceWithCredentials);
                return new ApiConnectionAction<OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseActiveDirectoryPowerShellRunspace(Expression<Func<CloseActiveDirectoryPowerShellRunspaceInput>> closeActiveDirectoryPowerShellRunspace)
        {
            var __workflow_closeActiveDirectoryPowerShellRunspace = WorkflowExpression.Compile(closeActiveDirectoryPowerShellRunspace, nameof(closeActiveDirectoryPowerShellRunspace), required: true);
            return new DeferredBodyAction<CloseActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_closeActiveDirectoryPowerShellRunspace);
                return new ApiConnectionAction<CloseActiveDirectoryPowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsActiveDirectoryPowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsActiveDirectoryPowerShellRunspaceOpen(Expression<Func<IsActiveDirectoryPowerShellRunspaceOpenInput>> isActiveDirectoryPowerShellRunspaceOpen)
        {
            var __workflow_isActiveDirectoryPowerShellRunspaceOpen = WorkflowExpression.Compile(isActiveDirectoryPowerShellRunspaceOpen, nameof(isActiveDirectoryPowerShellRunspaceOpen), required: true);
            return new DeferredBodyAction<IsActiveDirectoryPowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsActiveDirectoryPowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isActiveDirectoryPowerShellRunspaceOpen);
                return new ApiConnectionAction<IsActiveDirectoryPowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenLocalPassthroughActiveDirectoryPowerShellRunspace(Expression<Func<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceInput>> openLocalPassthroughActiveDirectoryPowerShellRunspace)
        {
            var __workflow_openLocalPassthroughActiveDirectoryPowerShellRunspace = WorkflowExpression.Compile(openLocalPassthroughActiveDirectoryPowerShellRunspace, nameof(openLocalPassthroughActiveDirectoryPowerShellRunspace), required: true);
            return new DeferredBodyAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenLocalPassthroughActiveDirectoryPowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openLocalPassthroughActiveDirectoryPowerShellRunspace);
                return new ApiConnectionAction<OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADUser(Expression<Func<ActiveDirectoryAddADUserInput>> activeDirectoryAddADUser)
        {
            var __workflow_activeDirectoryAddADUser = WorkflowExpression.Compile(activeDirectoryAddADUser, nameof(activeDirectoryAddADUser), required: true);
            return new DeferredBodyAction<ActiveDirectoryAddADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUser);
                return new ApiConnectionAction<ActiveDirectoryAddADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADUserByIdentity(Expression<Func<ActiveDirectoryGetADUserByIdentityInput>> activeDirectoryGetADUserByIdentity)
        {
            var __workflow_activeDirectoryGetADUserByIdentity = WorkflowExpression.Compile(activeDirectoryGetADUserByIdentity, nameof(activeDirectoryGetADUserByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserByIdentity);
                return new ApiConnectionAction<ActiveDirectoryGetADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetOUFromUserDNResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetOUFromUserDN(Expression<Func<ActiveDirectoryGetOUFromUserDNInput>> activeDirectoryGetOUFromUserDN)
        {
            var __workflow_activeDirectoryGetOUFromUserDN = WorkflowExpression.Compile(activeDirectoryGetOUFromUserDN, nameof(activeDirectoryGetOUFromUserDN), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetOUFromUserDNResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetOUFromUserDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetOUFromUserDN);
                return new ApiConnectionAction<ActiveDirectoryGetOUFromUserDNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainFQDNFromDNResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetDomainFQDNFromDN(Expression<Func<ActiveDirectoryGetDomainFQDNFromDNInput>> activeDirectoryGetDomainFQDNFromDN)
        {
            var __workflow_activeDirectoryGetDomainFQDNFromDN = WorkflowExpression.Compile(activeDirectoryGetDomainFQDNFromDN, nameof(activeDirectoryGetDomainFQDNFromDN), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetDomainFQDNFromDNResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainFQDNFromDN";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainFQDNFromDN);
                return new ApiConnectionAction<ActiveDirectoryGetDomainFQDNFromDNResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADGroupByIdentity(Expression<Func<ActiveDirectoryGetADGroupByIdentityInput>> activeDirectoryGetADGroupByIdentity)
        {
            var __workflow_activeDirectoryGetADGroupByIdentity = WorkflowExpression.Compile(activeDirectoryGetADGroupByIdentity, nameof(activeDirectoryGetADGroupByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetADGroupByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupByIdentity);
                return new ApiConnectionAction<ActiveDirectoryGetADGroupByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupMemberByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADGroupMemberByIdentity(Expression<Func<ActiveDirectoryAddADGroupMemberByIdentityInput>> activeDirectoryAddADGroupMemberByIdentity)
        {
            var __workflow_activeDirectoryAddADGroupMemberByIdentity = WorkflowExpression.Compile(activeDirectoryAddADGroupMemberByIdentity, nameof(activeDirectoryAddADGroupMemberByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryAddADGroupMemberByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroupMemberByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroupMemberByIdentity);
                return new ApiConnectionAction<ActiveDirectoryAddADGroupMemberByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddMultipleADGroupMembersByIdentity(Expression<Func<ActiveDirectoryAddMultipleADGroupMembersByIdentityInput>> activeDirectoryAddMultipleADGroupMembersByIdentity)
        {
            var __workflow_activeDirectoryAddMultipleADGroupMembersByIdentity = WorkflowExpression.Compile(activeDirectoryAddMultipleADGroupMembersByIdentity, nameof(activeDirectoryAddMultipleADGroupMembersByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddMultipleADGroupMembersByIdentity);
                return new ApiConnectionAction<ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADUserToMultipleADGroupsByName(Expression<Func<ActiveDirectoryAddADUserToMultipleADGroupsByNameInput>> activeDirectoryAddADUserToMultipleADGroupsByName)
        {
            var __workflow_activeDirectoryAddADUserToMultipleADGroupsByName = WorkflowExpression.Compile(activeDirectoryAddADUserToMultipleADGroupsByName, nameof(activeDirectoryAddADUserToMultipleADGroupsByName), required: true);
            return new DeferredBodyAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADUserToMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADUserToMultipleADGroupsByName);
                return new ApiConnectionAction<ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADUserGroupMembershipResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADUserGroupMembership(Expression<Func<ActiveDirectoryGetADUserGroupMembershipInput>> activeDirectoryGetADUserGroupMembership)
        {
            var __workflow_activeDirectoryGetADUserGroupMembership = WorkflowExpression.Compile(activeDirectoryGetADUserGroupMembership, nameof(activeDirectoryGetADUserGroupMembership), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetADUserGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADUserGroupMembership);
                return new ApiConnectionAction<ActiveDirectoryGetADUserGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryModifyADUserStringPropertyByIdentity(Expression<Func<ActiveDirectoryModifyADUserStringPropertyByIdentityInput>> activeDirectoryModifyADUserStringPropertyByIdentity)
        {
            var __workflow_activeDirectoryModifyADUserStringPropertyByIdentity = WorkflowExpression.Compile(activeDirectoryModifyADUserStringPropertyByIdentity, nameof(activeDirectoryModifyADUserStringPropertyByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserStringPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserStringPropertyByIdentity);
                return new ApiConnectionAction<ActiveDirectoryModifyADUserStringPropertyByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryModifyADUserBooleanPropertyByIdentity(Expression<Func<ActiveDirectoryModifyADUserBooleanPropertyByIdentityInput>> activeDirectoryModifyADUserBooleanPropertyByIdentity)
        {
            var __workflow_activeDirectoryModifyADUserBooleanPropertyByIdentity = WorkflowExpression.Compile(activeDirectoryModifyADUserBooleanPropertyByIdentity, nameof(activeDirectoryModifyADUserBooleanPropertyByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserBooleanPropertyByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserBooleanPropertyByIdentity);
                return new ApiConnectionAction<ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryModifyADUserPropertiesResponse, ApiConnectionActionConfiguration> ActiveDirectoryModifyADUserProperties(Expression<Func<ActiveDirectoryModifyADUserPropertiesInput>> activeDirectoryModifyADUserProperties)
        {
            var __workflow_activeDirectoryModifyADUserProperties = WorkflowExpression.Compile(activeDirectoryModifyADUserProperties, nameof(activeDirectoryModifyADUserProperties), required: true);
            return new DeferredBodyAction<ActiveDirectoryModifyADUserPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryModifyADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryModifyADUserProperties);
                return new ApiConnectionAction<ActiveDirectoryModifyADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryMoveADUserToOUByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryMoveADUserToOUByIdentity(Expression<Func<ActiveDirectoryMoveADUserToOUByIdentityInput>> activeDirectoryMoveADUserToOUByIdentity)
        {
            var __workflow_activeDirectoryMoveADUserToOUByIdentity = WorkflowExpression.Compile(activeDirectoryMoveADUserToOUByIdentity, nameof(activeDirectoryMoveADUserToOUByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryMoveADUserToOUByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryMoveADUserToOUByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryMoveADUserToOUByIdentity);
                return new ApiConnectionAction<ActiveDirectoryMoveADUserToOUByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryClearADUserAccountExpirationResponse, ApiConnectionActionConfiguration> ActiveDirectoryClearADUserAccountExpiration(Expression<Func<ActiveDirectoryClearADUserAccountExpirationInput>> activeDirectoryClearADUserAccountExpiration)
        {
            var __workflow_activeDirectoryClearADUserAccountExpiration = WorkflowExpression.Compile(activeDirectoryClearADUserAccountExpiration, nameof(activeDirectoryClearADUserAccountExpiration), required: true);
            return new DeferredBodyAction<ActiveDirectoryClearADUserAccountExpirationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryClearADUserAccountExpiration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryClearADUserAccountExpiration);
                return new ApiConnectionAction<ActiveDirectoryClearADUserAccountExpirationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDirSyncResponse, ApiConnectionActionConfiguration> ActiveDirectoryDirSync(Expression<Func<ActiveDirectoryDirSyncInput>> activeDirectoryDirSync)
        {
            var __workflow_activeDirectoryDirSync = WorkflowExpression.Compile(activeDirectoryDirSync, nameof(activeDirectoryDirSync), required: true);
            return new DeferredBodyAction<ActiveDirectoryDirSyncResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDirSync";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryDirSync);
                return new ApiConnectionAction<ActiveDirectoryDirSyncResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADUserByIdentity(Expression<Func<ActiveDirectoryRemoveADUserByIdentityInput>> activeDirectoryRemoveADUserByIdentity)
        {
            var __workflow_activeDirectoryRemoveADUserByIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADUserByIdentity, nameof(activeDirectoryRemoveADUserByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserByIdentity);
                return new ApiConnectionAction<ActiveDirectoryRemoveADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryResetADUserPasswordByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryResetADUserPasswordByIdentity(Expression<Func<ActiveDirectoryResetADUserPasswordByIdentityInput>> activeDirectoryResetADUserPasswordByIdentity)
        {
            var __workflow_activeDirectoryResetADUserPasswordByIdentity = WorkflowExpression.Compile(activeDirectoryResetADUserPasswordByIdentity, nameof(activeDirectoryResetADUserPasswordByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryResetADUserPasswordByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryResetADUserPasswordByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryResetADUserPasswordByIdentity);
                return new ApiConnectionAction<ActiveDirectoryResetADUserPasswordByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity(Expression<Func<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityInput>> activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity)
        {
            var __workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity = WorkflowExpression.Compile(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity, nameof(activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserProtectedFromAccidentalDeletionByIdentity);
                return new ApiConnectionAction<ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDisableADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryDisableADUserByIdentity(Expression<Func<ActiveDirectoryDisableADUserByIdentityInput>> activeDirectoryDisableADUserByIdentity)
        {
            var __workflow_activeDirectoryDisableADUserByIdentity = WorkflowExpression.Compile(activeDirectoryDisableADUserByIdentity, nameof(activeDirectoryDisableADUserByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryDisableADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDisableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryDisableADUserByIdentity);
                return new ApiConnectionAction<ActiveDirectoryDisableADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryEnableADUserByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryEnableADUserByIdentity(Expression<Func<ActiveDirectoryEnableADUserByIdentityInput>> activeDirectoryEnableADUserByIdentity)
        {
            var __workflow_activeDirectoryEnableADUserByIdentity = WorkflowExpression.Compile(activeDirectoryEnableADUserByIdentity, nameof(activeDirectoryEnableADUserByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryEnableADUserByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryEnableADUserByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryEnableADUserByIdentity);
                return new ApiConnectionAction<ActiveDirectoryEnableADUserByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADUserHomeFolderByIdentity(Expression<Func<ActiveDirectorySetADUserHomeFolderByIdentityInput>> activeDirectorySetADUserHomeFolderByIdentity)
        {
            var __workflow_activeDirectorySetADUserHomeFolderByIdentity = WorkflowExpression.Compile(activeDirectorySetADUserHomeFolderByIdentity, nameof(activeDirectorySetADUserHomeFolderByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserHomeFolderByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserHomeFolderByIdentity);
                return new ApiConnectionAction<ActiveDirectorySetADUserHomeFolderByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserGroupsResponse, ApiConnectionActionConfiguration> ActiveDirectoryCloneADUserGroups(Expression<Func<ActiveDirectoryCloneADUserGroupsInput>> activeDirectoryCloneADUserGroups)
        {
            var __workflow_activeDirectoryCloneADUserGroups = WorkflowExpression.Compile(activeDirectoryCloneADUserGroups, nameof(activeDirectoryCloneADUserGroups), required: true);
            return new DeferredBodyAction<ActiveDirectoryCloneADUserGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserGroups);
                return new ApiConnectionAction<ActiveDirectoryCloneADUserGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCloneADUserPropertiesResponse, ApiConnectionActionConfiguration> ActiveDirectoryCloneADUserProperties(Expression<Func<ActiveDirectoryCloneADUserPropertiesInput>> activeDirectoryCloneADUserProperties)
        {
            var __workflow_activeDirectoryCloneADUserProperties = WorkflowExpression.Compile(activeDirectoryCloneADUserProperties, nameof(activeDirectoryCloneADUserProperties), required: true);
            return new DeferredBodyAction<ActiveDirectoryCloneADUserPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCloneADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryCloneADUserProperties);
                return new ApiConnectionAction<ActiveDirectoryCloneADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADUserFromMultipleADGroupsByName(Expression<Func<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameInput>> activeDirectoryRemoveADUserFromMultipleADGroupsByName)
        {
            var __workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByName = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromMultipleADGroupsByName, nameof(activeDirectoryRemoveADUserFromMultipleADGroupsByName), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromMultipleADGroupsByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromMultipleADGroupsByName);
                return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADUserFromAllGroups(Expression<Func<ActiveDirectoryRemoveADUserFromAllGroupsInput>> activeDirectoryRemoveADUserFromAllGroups)
        {
            var __workflow_activeDirectoryRemoveADUserFromAllGroups = WorkflowExpression.Compile(activeDirectoryRemoveADUserFromAllGroups, nameof(activeDirectoryRemoveADUserFromAllGroups), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADUserFromAllGroups);
                return new ApiConnectionAction<ActiveDirectoryRemoveADUserFromAllGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryCheckOUExistsResponse, ApiConnectionActionConfiguration> ActiveDirectoryCheckOUExists(Expression<Func<ActiveDirectoryCheckOUExistsInput>> activeDirectoryCheckOUExists)
        {
            var __workflow_activeDirectoryCheckOUExists = WorkflowExpression.Compile(activeDirectoryCheckOUExists, nameof(activeDirectoryCheckOUExists), required: true);
            return new DeferredBodyAction<ActiveDirectoryCheckOUExistsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryCheckOUExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryCheckOUExists);
                return new ApiConnectionAction<ActiveDirectoryCheckOUExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADGroupMemberByGroupIdentity(Expression<Func<ActiveDirectoryRemoveADGroupMemberByGroupIdentityInput>> activeDirectoryRemoveADGroupMemberByGroupIdentity)
        {
            var __workflow_activeDirectoryRemoveADGroupMemberByGroupIdentity = WorkflowExpression.Compile(activeDirectoryRemoveADGroupMemberByGroupIdentity, nameof(activeDirectoryRemoveADGroupMemberByGroupIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroupMemberByGroupIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroupMemberByGroupIdentity);
                return new ApiConnectionAction<ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveMultipleADGroupMembersByIdentity(Expression<Func<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityInput>> activeDirectoryRemoveMultipleADGroupMembersByIdentity)
        {
            var __workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentity = WorkflowExpression.Compile(activeDirectoryRemoveMultipleADGroupMembersByIdentity, nameof(activeDirectoryRemoveMultipleADGroupMembersByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveMultipleADGroupMembersByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveMultipleADGroupMembersByIdentity);
                return new ApiConnectionAction<ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryUnlockADAccountByIdentityResponse, ApiConnectionActionConfiguration> ActiveDirectoryUnlockADAccountByIdentity(Expression<Func<ActiveDirectoryUnlockADAccountByIdentityInput>> activeDirectoryUnlockADAccountByIdentity)
        {
            var __workflow_activeDirectoryUnlockADAccountByIdentity = WorkflowExpression.Compile(activeDirectoryUnlockADAccountByIdentity, nameof(activeDirectoryUnlockADAccountByIdentity), required: true);
            return new DeferredBodyAction<ActiveDirectoryUnlockADAccountByIdentityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryUnlockADAccountByIdentity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryUnlockADAccountByIdentity);
                return new ApiConnectionAction<ActiveDirectoryUnlockADAccountByIdentityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADServerResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADServer(Expression<Func<ActiveDirectorySetADServerInput>> activeDirectorySetADServer)
        {
            var __workflow_activeDirectorySetADServer = WorkflowExpression.Compile(activeDirectorySetADServer, nameof(activeDirectorySetADServer), required: true);
            return new DeferredBodyAction<ActiveDirectorySetADServerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADServer);
                return new ApiConnectionAction<ActiveDirectorySetADServerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetDomainInfoResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetDomainInfo(Expression<Func<ActiveDirectoryGetDomainInfoInput>> activeDirectoryGetDomainInfo)
        {
            var __workflow_activeDirectoryGetDomainInfo = WorkflowExpression.Compile(activeDirectoryGetDomainInfo, nameof(activeDirectoryGetDomainInfo), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetDomainInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetDomainInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetDomainInfo);
                return new ApiConnectionAction<ActiveDirectoryGetDomainInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddADGroupResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddADGroup(Expression<Func<ActiveDirectoryAddADGroupInput>> activeDirectoryAddADGroup)
        {
            var __workflow_activeDirectoryAddADGroup = WorkflowExpression.Compile(activeDirectoryAddADGroup, nameof(activeDirectoryAddADGroup), required: true);
            return new DeferredBodyAction<ActiveDirectoryAddADGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddADGroup);
                return new ApiConnectionAction<ActiveDirectoryAddADGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryDoesADGroupExistResponse, ApiConnectionActionConfiguration> ActiveDirectoryDoesADGroupExist(Expression<Func<ActiveDirectoryDoesADGroupExistInput>> activeDirectoryDoesADGroupExist)
        {
            var __workflow_activeDirectoryDoesADGroupExist = WorkflowExpression.Compile(activeDirectoryDoesADGroupExist, nameof(activeDirectoryDoesADGroupExist), required: true);
            return new DeferredBodyAction<ActiveDirectoryDoesADGroupExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryDoesADGroupExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryDoesADGroupExist);
                return new ApiConnectionAction<ActiveDirectoryDoesADGroupExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveADGroupResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveADGroup(Expression<Func<ActiveDirectoryRemoveADGroupInput>> activeDirectoryRemoveADGroup)
        {
            var __workflow_activeDirectoryRemoveADGroup = WorkflowExpression.Compile(activeDirectoryRemoveADGroup, nameof(activeDirectoryRemoveADGroup), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveADGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveADGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveADGroup);
                return new ApiConnectionAction<ActiveDirectoryRemoveADGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryAddOUResponse, ApiConnectionActionConfiguration> ActiveDirectoryAddOU(Expression<Func<ActiveDirectoryAddOUInput>> activeDirectoryAddOU)
        {
            var __workflow_activeDirectoryAddOU = WorkflowExpression.Compile(activeDirectoryAddOU, nameof(activeDirectoryAddOU), required: true);
            return new DeferredBodyAction<ActiveDirectoryAddOUResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryAddOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryAddOU);
                return new ApiConnectionAction<ActiveDirectoryAddOUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryRemoveOUResponse, ApiConnectionActionConfiguration> ActiveDirectoryRemoveOU(Expression<Func<ActiveDirectoryRemoveOUInput>> activeDirectoryRemoveOU)
        {
            var __workflow_activeDirectoryRemoveOU = WorkflowExpression.Compile(activeDirectoryRemoveOU, nameof(activeDirectoryRemoveOU), required: true);
            return new DeferredBodyAction<ActiveDirectoryRemoveOUResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryRemoveOU";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryRemoveOU);
                return new ApiConnectionAction<ActiveDirectoryRemoveOUResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse, ApiConnectionActionConfiguration> ActiveDirectorySetADUserAccountExpirationEndOfDate(Expression<Func<ActiveDirectorySetADUserAccountExpirationEndOfDateInput>> activeDirectorySetADUserAccountExpirationEndOfDate)
        {
            var __workflow_activeDirectorySetADUserAccountExpirationEndOfDate = WorkflowExpression.Compile(activeDirectorySetADUserAccountExpirationEndOfDate, nameof(activeDirectorySetADUserAccountExpirationEndOfDate), required: true);
            return new DeferredBodyAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectorySetADUserAccountExpirationEndOfDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectorySetADUserAccountExpirationEndOfDate);
                return new ApiConnectionAction<ActiveDirectorySetADUserAccountExpirationEndOfDateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ActiveDirectoryGetADGroupMembersResponse, ApiConnectionActionConfiguration> ActiveDirectoryGetADGroupMembers(Expression<Func<ActiveDirectoryGetADGroupMembersInput>> activeDirectoryGetADGroupMembers)
        {
            var __workflow_activeDirectoryGetADGroupMembers = WorkflowExpression.Compile(activeDirectoryGetADGroupMembers, nameof(activeDirectoryGetADGroupMembers), required: true);
            return new DeferredBodyAction<ActiveDirectoryGetADGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ActiveDirectoryGetADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_activeDirectoryGetADGroupMembers);
                return new ApiConnectionAction<ActiveDirectoryGetADGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenExchangePowerShellRunspace(Expression<Func<OpenExchangePowerShellRunspaceInput>> openExchangePowerShellRunspace)
        {
            var __workflow_openExchangePowerShellRunspace = WorkflowExpression.Compile(openExchangePowerShellRunspace, nameof(openExchangePowerShellRunspace), required: true);
            return new DeferredBodyAction<OpenExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openExchangePowerShellRunspace);
                return new ApiConnectionAction<OpenExchangePowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsExchangePowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsExchangePowerShellRunspaceOpen(Expression<Func<IsExchangePowerShellRunspaceOpenInput>> isExchangePowerShellRunspaceOpen)
        {
            var __workflow_isExchangePowerShellRunspaceOpen = WorkflowExpression.Compile(isExchangePowerShellRunspaceOpen, nameof(isExchangePowerShellRunspaceOpen), required: true);
            return new DeferredBodyAction<IsExchangePowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsExchangePowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isExchangePowerShellRunspaceOpen);
                return new ApiConnectionAction<IsExchangePowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunExchangePowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunExchangePowerShellAutomationScript(Expression<Func<RunExchangePowerShellAutomationScriptInput>> runExchangePowerShellAutomationScript)
        {
            var __workflow_runExchangePowerShellAutomationScript = WorkflowExpression.Compile(runExchangePowerShellAutomationScript, nameof(runExchangePowerShellAutomationScript), required: true);
            return new DeferredBodyAction<RunExchangePowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunExchangePowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runExchangePowerShellAutomationScript);
                return new ApiConnectionAction<RunExchangePowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseExchangePowerShellRunspace(Expression<Func<CloseExchangePowerShellRunspaceInput>> closeExchangePowerShellRunspace)
        {
            var __workflow_closeExchangePowerShellRunspace = WorkflowExpression.Compile(closeExchangePowerShellRunspace, nameof(closeExchangePowerShellRunspace), required: true);
            return new DeferredBodyAction<CloseExchangePowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseExchangePowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_closeExchangePowerShellRunspace);
                return new ApiConnectionAction<CloseExchangePowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxResponse, ApiConnectionActionConfiguration> ExchangeGetMailbox(Expression<Func<ExchangeGetMailboxInput>> exchangeGetMailbox)
        {
            var __workflow_exchangeGetMailbox = WorkflowExpression.Compile(exchangeGetMailbox, nameof(exchangeGetMailbox), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetMailbox);
                return new ApiConnectionAction<ExchangeGetMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesMailboxExistResponse, ApiConnectionActionConfiguration> ExchangeDoesMailboxExist(Expression<Func<ExchangeDoesMailboxExistInput>> exchangeDoesMailboxExist)
        {
            var __workflow_exchangeDoesMailboxExist = WorkflowExpression.Compile(exchangeDoesMailboxExist, nameof(exchangeDoesMailboxExist), required: true);
            return new DeferredBodyAction<ExchangeDoesMailboxExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeDoesMailboxExist);
                return new ApiConnectionAction<ExchangeDoesMailboxExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddDistributionGroupMemberResponse, ApiConnectionActionConfiguration> ExchangeAddDistributionGroupMember(Expression<Func<ExchangeAddDistributionGroupMemberInput>> exchangeAddDistributionGroupMember)
        {
            var __workflow_exchangeAddDistributionGroupMember = WorkflowExpression.Compile(exchangeAddDistributionGroupMember, nameof(exchangeAddDistributionGroupMember), required: true);
            return new DeferredBodyAction<ExchangeAddDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeAddDistributionGroupMember);
                return new ApiConnectionAction<ExchangeAddDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration> ExchangeRemoveDistributionGroupMember(Expression<Func<ExchangeRemoveDistributionGroupMemberInput>> exchangeRemoveDistributionGroupMember)
        {
            var __workflow_exchangeRemoveDistributionGroupMember = WorkflowExpression.Compile(exchangeRemoveDistributionGroupMember, nameof(exchangeRemoveDistributionGroupMember), required: true);
            return new DeferredBodyAction<ExchangeRemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroupMember);
                return new ApiConnectionAction<ExchangeRemoveDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupResponse, ApiConnectionActionConfiguration> ExchangeGetDistributionGroup(Expression<Func<ExchangeGetDistributionGroupInput>> exchangeGetDistributionGroup)
        {
            var __workflow_exchangeGetDistributionGroup = WorkflowExpression.Compile(exchangeGetDistributionGroup, nameof(exchangeGetDistributionGroup), required: true);
            return new DeferredBodyAction<ExchangeGetDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroup);
                return new ApiConnectionAction<ExchangeGetDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetDistributionGroupMembersResponse, ApiConnectionActionConfiguration> ExchangeGetDistributionGroupMembers(Expression<Func<ExchangeGetDistributionGroupMembersInput>> exchangeGetDistributionGroupMembers)
        {
            var __workflow_exchangeGetDistributionGroupMembers = WorkflowExpression.Compile(exchangeGetDistributionGroupMembers, nameof(exchangeGetDistributionGroupMembers), required: true);
            return new DeferredBodyAction<ExchangeGetDistributionGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetDistributionGroupMembers);
                return new ApiConnectionAction<ExchangeGetDistributionGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration> ExchangeGetMailboxDistributionGroupMembership(Expression<Func<ExchangeGetMailboxDistributionGroupMembershipInput>> exchangeGetMailboxDistributionGroupMembership)
        {
            var __workflow_exchangeGetMailboxDistributionGroupMembership = WorkflowExpression.Compile(exchangeGetMailboxDistributionGroupMembership, nameof(exchangeGetMailboxDistributionGroupMembership), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxDistributionGroupMembership);
                return new ApiConnectionAction<ExchangeGetMailboxDistributionGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewDistributionGroupResponse, ApiConnectionActionConfiguration> ExchangeNewDistributionGroup(Expression<Func<ExchangeNewDistributionGroupInput>> exchangeNewDistributionGroup)
        {
            var __workflow_exchangeNewDistributionGroup = WorkflowExpression.Compile(exchangeNewDistributionGroup, nameof(exchangeNewDistributionGroup), required: true);
            return new DeferredBodyAction<ExchangeNewDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeNewDistributionGroup);
                return new ApiConnectionAction<ExchangeNewDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveDistributionGroupResponse, ApiConnectionActionConfiguration> ExchangeRemoveDistributionGroup(Expression<Func<ExchangeRemoveDistributionGroupInput>> exchangeRemoveDistributionGroup)
        {
            var __workflow_exchangeRemoveDistributionGroup = WorkflowExpression.Compile(exchangeRemoveDistributionGroup, nameof(exchangeRemoveDistributionGroup), required: true);
            return new DeferredBodyAction<ExchangeRemoveDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeRemoveDistributionGroup);
                return new ApiConnectionAction<ExchangeRemoveDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddMailboxPermissionResponse, ApiConnectionActionConfiguration> ExchangeAddMailboxPermission(Expression<Func<ExchangeAddMailboxPermissionInput>> exchangeAddMailboxPermission)
        {
            var __workflow_exchangeAddMailboxPermission = WorkflowExpression.Compile(exchangeAddMailboxPermission, nameof(exchangeAddMailboxPermission), required: true);
            return new DeferredBodyAction<ExchangeAddMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeAddMailboxPermission);
                return new ApiConnectionAction<ExchangeAddMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeRemoveMailboxPermissionResponse, ApiConnectionActionConfiguration> ExchangeRemoveMailboxPermission(Expression<Func<ExchangeRemoveMailboxPermissionInput>> exchangeRemoveMailboxPermission)
        {
            var __workflow_exchangeRemoveMailboxPermission = WorkflowExpression.Compile(exchangeRemoveMailboxPermission, nameof(exchangeRemoveMailboxPermission), required: true);
            return new DeferredBodyAction<ExchangeRemoveMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeRemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeRemoveMailboxPermission);
                return new ApiConnectionAction<ExchangeRemoveMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableMailboxResponse, ApiConnectionActionConfiguration> ExchangeDisableMailbox(Expression<Func<ExchangeDisableMailboxInput>> exchangeDisableMailbox)
        {
            var __workflow_exchangeDisableMailbox = WorkflowExpression.Compile(exchangeDisableMailbox, nameof(exchangeDisableMailbox), required: true);
            return new DeferredBodyAction<ExchangeDisableMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeDisableMailbox);
                return new ApiConnectionAction<ExchangeDisableMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDisableRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeDisableRemoteMailbox(Expression<Func<ExchangeDisableRemoteMailboxInput>> exchangeDisableRemoteMailbox)
        {
            var __workflow_exchangeDisableRemoteMailbox = WorkflowExpression.Compile(exchangeDisableRemoteMailbox, nameof(exchangeDisableRemoteMailbox), required: true);
            return new DeferredBodyAction<ExchangeDisableRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDisableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeDisableRemoteMailbox);
                return new ApiConnectionAction<ExchangeDisableRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableMailboxResponse, ApiConnectionActionConfiguration> ExchangeEnableMailbox(Expression<Func<ExchangeEnableMailboxInput>> exchangeEnableMailbox)
        {
            var __workflow_exchangeEnableMailbox = WorkflowExpression.Compile(exchangeEnableMailbox, nameof(exchangeEnableMailbox), required: true);
            return new DeferredBodyAction<ExchangeEnableMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeEnableMailbox);
                return new ApiConnectionAction<ExchangeEnableMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeEnableRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeEnableRemoteMailbox(Expression<Func<ExchangeEnableRemoteMailboxInput>> exchangeEnableRemoteMailbox)
        {
            var __workflow_exchangeEnableRemoteMailbox = WorkflowExpression.Compile(exchangeEnableRemoteMailbox, nameof(exchangeEnableRemoteMailbox), required: true);
            return new DeferredBodyAction<ExchangeEnableRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeEnableRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeEnableRemoteMailbox);
                return new ApiConnectionAction<ExchangeEnableRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeGetRemoteMailbox(Expression<Func<ExchangeGetRemoteMailboxInput>> exchangeGetRemoteMailbox)
        {
            var __workflow_exchangeGetRemoteMailbox = WorkflowExpression.Compile(exchangeGetRemoteMailbox, nameof(exchangeGetRemoteMailbox), required: true);
            return new DeferredBodyAction<ExchangeGetRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailbox);
                return new ApiConnectionAction<ExchangeGetRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeDoesRemoteMailboxExistResponse, ApiConnectionActionConfiguration> ExchangeDoesRemoteMailboxExist(Expression<Func<ExchangeDoesRemoteMailboxExistInput>> exchangeDoesRemoteMailboxExist)
        {
            var __workflow_exchangeDoesRemoteMailboxExist = WorkflowExpression.Compile(exchangeDoesRemoteMailboxExist, nameof(exchangeDoesRemoteMailboxExist), required: true);
            return new DeferredBodyAction<ExchangeDoesRemoteMailboxExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeDoesRemoteMailboxExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeDoesRemoteMailboxExist);
                return new ApiConnectionAction<ExchangeDoesRemoteMailboxExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewMailboxResponse, ApiConnectionActionConfiguration> ExchangeNewMailbox(Expression<Func<ExchangeNewMailboxInput>> exchangeNewMailbox)
        {
            var __workflow_exchangeNewMailbox = WorkflowExpression.Compile(exchangeNewMailbox, nameof(exchangeNewMailbox), required: true);
            return new DeferredBodyAction<ExchangeNewMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeNewMailbox);
                return new ApiConnectionAction<ExchangeNewMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeNewRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeNewRemoteMailbox(Expression<Func<ExchangeNewRemoteMailboxInput>> exchangeNewRemoteMailbox)
        {
            var __workflow_exchangeNewRemoteMailbox = WorkflowExpression.Compile(exchangeNewRemoteMailbox, nameof(exchangeNewRemoteMailbox), required: true);
            return new DeferredBodyAction<ExchangeNewRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeNewRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeNewRemoteMailbox);
                return new ApiConnectionAction<ExchangeNewRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetADServerToViewEntireForestResponse, ApiConnectionActionConfiguration> ExchangeSetADServerToViewEntireForest(Expression<Func<ExchangeSetADServerToViewEntireForestInput>> exchangeSetADServerToViewEntireForest)
        {
            var __workflow_exchangeSetADServerToViewEntireForest = WorkflowExpression.Compile(exchangeSetADServerToViewEntireForest, nameof(exchangeSetADServerToViewEntireForest), required: true);
            return new DeferredBodyAction<ExchangeSetADServerToViewEntireForestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetADServerToViewEntireForest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetADServerToViewEntireForest);
                return new ApiConnectionAction<ExchangeSetADServerToViewEntireForestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxResponse, ApiConnectionActionConfiguration> ExchangeSetMailbox(Expression<Func<ExchangeSetMailboxInput>> exchangeSetMailbox)
        {
            var __workflow_exchangeSetMailbox = WorkflowExpression.Compile(exchangeSetMailbox, nameof(exchangeSetMailbox), required: true);
            return new DeferredBodyAction<ExchangeSetMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetMailbox);
                return new ApiConnectionAction<ExchangeSetMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeSetMailboxEmailAddresses(Expression<Func<ExchangeSetMailboxEmailAddressesInput>> exchangeSetMailboxEmailAddresses)
        {
            var __workflow_exchangeSetMailboxEmailAddresses = WorkflowExpression.Compile(exchangeSetMailboxEmailAddresses, nameof(exchangeSetMailboxEmailAddresses), required: true);
            return new DeferredBodyAction<ExchangeSetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxEmailAddresses);
                return new ApiConnectionAction<ExchangeSetMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeGetMailboxEmailAddresses(Expression<Func<ExchangeGetMailboxEmailAddressesInput>> exchangeGetMailboxEmailAddresses)
        {
            var __workflow_exchangeGetMailboxEmailAddresses = WorkflowExpression.Compile(exchangeGetMailboxEmailAddresses, nameof(exchangeGetMailboxEmailAddresses), required: true);
            return new DeferredBodyAction<ExchangeGetMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetMailboxEmailAddresses);
                return new ApiConnectionAction<ExchangeGetMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeSetRemoteMailboxEmailAddresses(Expression<Func<ExchangeSetRemoteMailboxEmailAddressesInput>> exchangeSetRemoteMailboxEmailAddresses)
        {
            var __workflow_exchangeSetRemoteMailboxEmailAddresses = WorkflowExpression.Compile(exchangeSetRemoteMailboxEmailAddresses, nameof(exchangeSetRemoteMailboxEmailAddresses), required: true);
            return new DeferredBodyAction<ExchangeSetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailboxEmailAddresses);
                return new ApiConnectionAction<ExchangeSetRemoteMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeGetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration> ExchangeGetRemoteMailboxEmailAddresses(Expression<Func<ExchangeGetRemoteMailboxEmailAddressesInput>> exchangeGetRemoteMailboxEmailAddresses)
        {
            var __workflow_exchangeGetRemoteMailboxEmailAddresses = WorkflowExpression.Compile(exchangeGetRemoteMailboxEmailAddresses, nameof(exchangeGetRemoteMailboxEmailAddresses), required: true);
            return new DeferredBodyAction<ExchangeGetRemoteMailboxEmailAddressesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeGetRemoteMailboxEmailAddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeGetRemoteMailboxEmailAddresses);
                return new ApiConnectionAction<ExchangeGetRemoteMailboxEmailAddressesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetMailboxAttributesResponse, ApiConnectionActionConfiguration> ExchangeResetMailboxAttributes(Expression<Func<ExchangeResetMailboxAttributesInput>> exchangeResetMailboxAttributes)
        {
            var __workflow_exchangeResetMailboxAttributes = WorkflowExpression.Compile(exchangeResetMailboxAttributes, nameof(exchangeResetMailboxAttributes), required: true);
            return new DeferredBodyAction<ExchangeResetMailboxAttributesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeResetMailboxAttributes);
                return new ApiConnectionAction<ExchangeResetMailboxAttributesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeResetRemoteMailboxAttributesResponse, ApiConnectionActionConfiguration> ExchangeResetRemoteMailboxAttributes(Expression<Func<ExchangeResetRemoteMailboxAttributesInput>> exchangeResetRemoteMailboxAttributes)
        {
            var __workflow_exchangeResetRemoteMailboxAttributes = WorkflowExpression.Compile(exchangeResetRemoteMailboxAttributes, nameof(exchangeResetRemoteMailboxAttributes), required: true);
            return new DeferredBodyAction<ExchangeResetRemoteMailboxAttributesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeResetRemoteMailboxAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeResetRemoteMailboxAttributes);
                return new ApiConnectionAction<ExchangeResetRemoteMailboxAttributesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetRemoteMailboxResponse, ApiConnectionActionConfiguration> ExchangeSetRemoteMailbox(Expression<Func<ExchangeSetRemoteMailboxInput>> exchangeSetRemoteMailbox)
        {
            var __workflow_exchangeSetRemoteMailbox = WorkflowExpression.Compile(exchangeSetRemoteMailbox, nameof(exchangeSetRemoteMailbox), required: true);
            return new DeferredBodyAction<ExchangeSetRemoteMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetRemoteMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetRemoteMailbox);
                return new ApiConnectionAction<ExchangeSetRemoteMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse, ApiConnectionActionConfiguration> ExchangeSetMailboxSendOnBehalfOfPermission(Expression<Func<ExchangeSetMailboxSendOnBehalfOfPermissionInput>> exchangeSetMailboxSendOnBehalfOfPermission)
        {
            var __workflow_exchangeSetMailboxSendOnBehalfOfPermission = WorkflowExpression.Compile(exchangeSetMailboxSendOnBehalfOfPermission, nameof(exchangeSetMailboxSendOnBehalfOfPermission), required: true);
            return new DeferredBodyAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxSendOnBehalfOfPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxSendOnBehalfOfPermission);
                return new ApiConnectionAction<ExchangeSetMailboxSendOnBehalfOfPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeAddADPermissionResponse, ApiConnectionActionConfiguration> ExchangeAddADPermission(Expression<Func<ExchangeAddADPermissionInput>> exchangeAddADPermission)
        {
            var __workflow_exchangeAddADPermission = WorkflowExpression.Compile(exchangeAddADPermission, nameof(exchangeAddADPermission), required: true);
            return new DeferredBodyAction<ExchangeAddADPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeAddADPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeAddADPermission);
                return new ApiConnectionAction<ExchangeAddADPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<ExchangeSetMailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration> ExchangeSetMailboxAutoReplyConfiguration(Expression<Func<ExchangeSetMailboxAutoReplyConfigurationInput>> exchangeSetMailboxAutoReplyConfiguration)
        {
            var __workflow_exchangeSetMailboxAutoReplyConfiguration = WorkflowExpression.Compile(exchangeSetMailboxAutoReplyConfiguration, nameof(exchangeSetMailboxAutoReplyConfiguration), required: true);
            return new DeferredBodyAction<ExchangeSetMailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/ExchangeSetMailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_exchangeSetMailboxAutoReplyConfiguration);
                return new ApiConnectionAction<ExchangeSetMailboxAutoReplyConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellModuleInstalledResponse, ApiConnectionActionConfiguration> IsAzureADv2PowerShellModuleInstalled(Expression<Func<IsAzureADv2PowerShellModuleInstalledInput>> isAzureADv2PowerShellModuleInstalled)
        {
            var __workflow_isAzureADv2PowerShellModuleInstalled = WorkflowExpression.Compile(isAzureADv2PowerShellModuleInstalled, nameof(isAzureADv2PowerShellModuleInstalled), required: true);
            return new DeferredBodyAction<IsAzureADv2PowerShellModuleInstalledResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellModuleInstalled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isAzureADv2PowerShellModuleInstalled);
                return new ApiConnectionAction<IsAzureADv2PowerShellModuleInstalledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenAzureADv2PowerShellRunspace(Expression<Func<OpenAzureADv2PowerShellRunspaceInput>> openAzureADv2PowerShellRunspace)
        {
            var __workflow_openAzureADv2PowerShellRunspace = WorkflowExpression.Compile(openAzureADv2PowerShellRunspace, nameof(openAzureADv2PowerShellRunspace), required: true);
            return new DeferredBodyAction<OpenAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspace);
                return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration> OpenAzureADv2PowerShellRunspaceWithCertificate(Expression<Func<OpenAzureADv2PowerShellRunspaceWithCertificateInput>> openAzureADv2PowerShellRunspaceWithCertificate)
        {
            var __workflow_openAzureADv2PowerShellRunspaceWithCertificate = WorkflowExpression.Compile(openAzureADv2PowerShellRunspaceWithCertificate, nameof(openAzureADv2PowerShellRunspaceWithCertificate), required: true);
            return new DeferredBodyAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/OpenAzureADv2PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openAzureADv2PowerShellRunspaceWithCertificate);
                return new ApiConnectionAction<OpenAzureADv2PowerShellRunspaceWithCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsAzureADv2PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsAzureADv2PowerShellRunspaceOpen(Expression<Func<IsAzureADv2PowerShellRunspaceOpenInput>> isAzureADv2PowerShellRunspaceOpen)
        {
            var __workflow_isAzureADv2PowerShellRunspaceOpen = WorkflowExpression.Compile(isAzureADv2PowerShellRunspaceOpen, nameof(isAzureADv2PowerShellRunspaceOpen), required: true);
            return new DeferredBodyAction<IsAzureADv2PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/IsAzureADv2PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isAzureADv2PowerShellRunspaceOpen);
                return new ApiConnectionAction<IsAzureADv2PowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunAzureADv2PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunAzureADv2PowerShellAutomationScript(Expression<Func<RunAzureADv2PowerShellAutomationScriptInput>> runAzureADv2PowerShellAutomationScript)
        {
            var __workflow_runAzureADv2PowerShellAutomationScript = WorkflowExpression.Compile(runAzureADv2PowerShellAutomationScript, nameof(runAzureADv2PowerShellAutomationScript), required: true);
            return new DeferredBodyAction<RunAzureADv2PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/RunAzureADv2PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runAzureADv2PowerShellAutomationScript);
                return new ApiConnectionAction<RunAzureADv2PowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseAzureADv2PowerShellRunspace(Expression<Func<CloseAzureADv2PowerShellRunspaceInput>> closeAzureADv2PowerShellRunspace)
        {
            var __workflow_closeAzureADv2PowerShellRunspace = WorkflowExpression.Compile(closeAzureADv2PowerShellRunspace, nameof(closeAzureADv2PowerShellRunspace), required: true);
            return new DeferredBodyAction<CloseAzureADv2PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/CloseAzureADv2PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_closeAzureADv2PowerShellRunspace);
                return new ApiConnectionAction<CloseAzureADv2PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUsersResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUsers(Expression<Func<AzureADv2GetAzureADUsersInput>> azureADv2GetAzureADUsers)
        {
            var __workflow_azureADv2GetAzureADUsers = WorkflowExpression.Compile(azureADv2GetAzureADUsers, nameof(azureADv2GetAzureADUsers), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUsers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUsers);
                return new ApiConnectionAction<AzureADv2GetAzureADUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddAzureADUserResponse, ApiConnectionActionConfiguration> AzureADv2AddAzureADUser(Expression<Func<AzureADv2AddAzureADUserInput>> azureADv2AddAzureADUser)
        {
            var __workflow_azureADv2AddAzureADUser = WorkflowExpression.Compile(azureADv2AddAzureADUser, nameof(azureADv2AddAzureADUser), required: true);
            return new DeferredBodyAction<AzureADv2AddAzureADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2AddAzureADUser);
                return new ApiConnectionAction<AzureADv2AddAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAzureADUserResponse, ApiConnectionActionConfiguration> AzureADv2RemoveAzureADUser(Expression<Func<AzureADv2RemoveAzureADUserInput>> azureADv2RemoveAzureADUser)
        {
            var __workflow_azureADv2RemoveAzureADUser = WorkflowExpression.Compile(azureADv2RemoveAzureADUser, nameof(azureADv2RemoveAzureADUser), required: true);
            return new DeferredBodyAction<AzureADv2RemoveAzureADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAzureADUser);
                return new ApiConnectionAction<AzureADv2RemoveAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPasswordResponse, ApiConnectionActionConfiguration> AzureADv2ResetAzureADUserPassword(Expression<Func<AzureADv2ResetAzureADUserPasswordInput>> azureADv2ResetAzureADUserPassword)
        {
            var __workflow_azureADv2ResetAzureADUserPassword = WorkflowExpression.Compile(azureADv2ResetAzureADUserPassword, nameof(azureADv2ResetAzureADUserPassword), required: true);
            return new DeferredBodyAction<AzureADv2ResetAzureADUserPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserPassword);
                return new ApiConnectionAction<AzureADv2ResetAzureADUserPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserGroupMembershipResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserGroupMembership(Expression<Func<AzureADv2GetAzureADUserGroupMembershipInput>> azureADv2GetAzureADUserGroupMembership)
        {
            var __workflow_azureADv2GetAzureADUserGroupMembership = WorkflowExpression.Compile(azureADv2GetAzureADUserGroupMembership, nameof(azureADv2GetAzureADUserGroupMembership), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserGroupMembership);
                return new ApiConnectionAction<AzureADv2GetAzureADUserGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInAzureADUserGroupResponse, ApiConnectionActionConfiguration> AzureADv2IsUserInAzureADUserGroup(Expression<Func<AzureADv2IsUserInAzureADUserGroupInput>> azureADv2IsUserInAzureADUserGroup)
        {
            var __workflow_azureADv2IsUserInAzureADUserGroup = WorkflowExpression.Compile(azureADv2IsUserInAzureADUserGroup, nameof(azureADv2IsUserInAzureADUserGroup), required: true);
            return new DeferredBodyAction<AzureADv2IsUserInAzureADUserGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInAzureADUserGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInAzureADUserGroup);
                return new ApiConnectionAction<AzureADv2IsUserInAzureADUserGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddUserToGroupResponse, ApiConnectionActionConfiguration> AzureADv2AddUserToGroup(Expression<Func<AzureADv2AddUserToGroupInput>> azureADv2AddUserToGroup)
        {
            var __workflow_azureADv2AddUserToGroup = WorkflowExpression.Compile(azureADv2AddUserToGroup, nameof(azureADv2AddUserToGroup), required: true);
            return new DeferredBodyAction<AzureADv2AddUserToGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddUserToGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2AddUserToGroup);
                return new ApiConnectionAction<AzureADv2AddUserToGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromGroupResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromGroup(Expression<Func<AzureADv2RemoveUserFromGroupInput>> azureADv2RemoveUserFromGroup)
        {
            var __workflow_azureADv2RemoveUserFromGroup = WorkflowExpression.Compile(azureADv2RemoveUserFromGroup, nameof(azureADv2RemoveUserFromGroup), required: true);
            return new DeferredBodyAction<AzureADv2RemoveUserFromGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromGroup);
                return new ApiConnectionAction<AzureADv2RemoveUserFromGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AddADUserToMultipleADGroupsResponse, ApiConnectionActionConfiguration> AzureADv2AddADUserToMultipleADGroups(Expression<Func<AzureADv2AddADUserToMultipleADGroupsInput>> azureADv2AddADUserToMultipleADGroups)
        {
            var __workflow_azureADv2AddADUserToMultipleADGroups = WorkflowExpression.Compile(azureADv2AddADUserToMultipleADGroups, nameof(azureADv2AddADUserToMultipleADGroups), required: true);
            return new DeferredBodyAction<AzureADv2AddADUserToMultipleADGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AddADUserToMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2AddADUserToMultipleADGroups);
                return new ApiConnectionAction<AzureADv2AddADUserToMultipleADGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse, ApiConnectionActionConfiguration> AzureADv2RemoveADUserFromMultipleADGroups(Expression<Func<AzureADv2RemoveADUserFromMultipleADGroupsInput>> azureADv2RemoveADUserFromMultipleADGroups)
        {
            var __workflow_azureADv2RemoveADUserFromMultipleADGroups = WorkflowExpression.Compile(azureADv2RemoveADUserFromMultipleADGroups, nameof(azureADv2RemoveADUserFromMultipleADGroups), required: true);
            return new DeferredBodyAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveADUserFromMultipleADGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveADUserFromMultipleADGroups);
                return new ApiConnectionAction<AzureADv2RemoveADUserFromMultipleADGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllGroupsResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromAllGroups(Expression<Func<AzureADv2RemoveUserFromAllGroupsInput>> azureADv2RemoveUserFromAllGroups)
        {
            var __workflow_azureADv2RemoveUserFromAllGroups = WorkflowExpression.Compile(azureADv2RemoveUserFromAllGroups, nameof(azureADv2RemoveUserFromAllGroups), required: true);
            return new DeferredBodyAction<AzureADv2RemoveUserFromAllGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllGroups);
                return new ApiConnectionAction<AzureADv2RemoveUserFromAllGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADLicenseSKUsResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADLicenseSKUs(Expression<Func<AzureADv2GetAzureADLicenseSKUsInput>> azureADv2GetAzureADLicenseSKUs)
        {
            var __workflow_azureADv2GetAzureADLicenseSKUs = WorkflowExpression.Compile(azureADv2GetAzureADLicenseSKUs, nameof(azureADv2GetAzureADLicenseSKUs), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADLicenseSKUsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADLicenseSKUs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADLicenseSKUs);
                return new ApiConnectionAction<AzureADv2GetAzureADLicenseSKUsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserLicenseResponse, ApiConnectionActionConfiguration> AzureADv2SetAzureADUserLicense(Expression<Func<AzureADv2SetAzureADUserLicenseInput>> azureADv2SetAzureADUserLicense)
        {
            var __workflow_azureADv2SetAzureADUserLicense = WorkflowExpression.Compile(azureADv2SetAzureADUserLicense, nameof(azureADv2SetAzureADUserLicense), required: true);
            return new DeferredBodyAction<AzureADv2SetAzureADUserLicenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserLicense);
                return new ApiConnectionAction<AzureADv2SetAzureADUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicensesResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserLicenses(Expression<Func<AzureADv2GetAzureADUserLicensesInput>> azureADv2GetAzureADUserLicenses)
        {
            var __workflow_azureADv2GetAzureADUserLicenses = WorkflowExpression.Compile(azureADv2GetAzureADUserLicenses, nameof(azureADv2GetAzureADUserLicenses), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserLicensesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicenses);
                return new ApiConnectionAction<AzureADv2GetAzureADUserLicensesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserLicenseServicePlansResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserLicenseServicePlans(Expression<Func<AzureADv2GetAzureADUserLicenseServicePlansInput>> azureADv2GetAzureADUserLicenseServicePlans)
        {
            var __workflow_azureADv2GetAzureADUserLicenseServicePlans = WorkflowExpression.Compile(azureADv2GetAzureADUserLicenseServicePlans, nameof(azureADv2GetAzureADUserLicenseServicePlans), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserLicenseServicePlansResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserLicenseServicePlans";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserLicenseServicePlans);
                return new ApiConnectionAction<AzureADv2GetAzureADUserLicenseServicePlansResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveAllAzureADUserLicenseResponse, ApiConnectionActionConfiguration> AzureADv2RemoveAllAzureADUserLicense(Expression<Func<AzureADv2RemoveAllAzureADUserLicenseInput>> azureADv2RemoveAllAzureADUserLicense)
        {
            var __workflow_azureADv2RemoveAllAzureADUserLicense = WorkflowExpression.Compile(azureADv2RemoveAllAzureADUserLicense, nameof(azureADv2RemoveAllAzureADUserLicense), required: true);
            return new DeferredBodyAction<AzureADv2RemoveAllAzureADUserLicenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveAllAzureADUserLicense";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveAllAzureADUserLicense);
                return new ApiConnectionAction<AzureADv2RemoveAllAzureADUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserResponse, ApiConnectionActionConfiguration> AzureADv2SetAzureADUser(Expression<Func<AzureADv2SetAzureADUserInput>> azureADv2SetAzureADUser)
        {
            var __workflow_azureADv2SetAzureADUser = WorkflowExpression.Compile(azureADv2SetAzureADUser, nameof(azureADv2SetAzureADUser), required: true);
            return new DeferredBodyAction<AzureADv2SetAzureADUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUser);
                return new ApiConnectionAction<AzureADv2SetAzureADUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2ResetAzureADUserPropertiesResponse, ApiConnectionActionConfiguration> AzureADv2ResetAzureADUserProperties(Expression<Func<AzureADv2ResetAzureADUserPropertiesInput>> azureADv2ResetAzureADUserProperties)
        {
            var __workflow_azureADv2ResetAzureADUserProperties = WorkflowExpression.Compile(azureADv2ResetAzureADUserProperties, nameof(azureADv2ResetAzureADUserProperties), required: true);
            return new DeferredBodyAction<AzureADv2ResetAzureADUserPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2ResetAzureADUserProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2ResetAzureADUserProperties);
                return new ApiConnectionAction<AzureADv2ResetAzureADUserPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2SetAzureADUserManagerResponse, ApiConnectionActionConfiguration> AzureADv2SetAzureADUserManager(Expression<Func<AzureADv2SetAzureADUserManagerInput>> azureADv2SetAzureADUserManager)
        {
            var __workflow_azureADv2SetAzureADUserManager = WorkflowExpression.Compile(azureADv2SetAzureADUserManager, nameof(azureADv2SetAzureADUserManager), required: true);
            return new DeferredBodyAction<AzureADv2SetAzureADUserManagerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2SetAzureADUserManager";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2SetAzureADUserManager);
                return new ApiConnectionAction<AzureADv2SetAzureADUserManagerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewSecurityGroupResponse, ApiConnectionActionConfiguration> AzureADv2NewSecurityGroup(Expression<Func<AzureADv2NewSecurityGroupInput>> azureADv2NewSecurityGroup)
        {
            var __workflow_azureADv2NewSecurityGroup = WorkflowExpression.Compile(azureADv2NewSecurityGroup, nameof(azureADv2NewSecurityGroup), required: true);
            return new DeferredBodyAction<AzureADv2NewSecurityGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2NewSecurityGroup);
                return new ApiConnectionAction<AzureADv2NewSecurityGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveSecurityGroupResponse, ApiConnectionActionConfiguration> AzureADv2RemoveSecurityGroup(Expression<Func<AzureADv2RemoveSecurityGroupInput>> azureADv2RemoveSecurityGroup)
        {
            var __workflow_azureADv2RemoveSecurityGroup = WorkflowExpression.Compile(azureADv2RemoveSecurityGroup, nameof(azureADv2RemoveSecurityGroup), required: true);
            return new DeferredBodyAction<AzureADv2RemoveSecurityGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveSecurityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveSecurityGroup);
                return new ApiConnectionAction<AzureADv2RemoveSecurityGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2NewMicrosoft365GroupResponse, ApiConnectionActionConfiguration> AzureADv2NewMicrosoft365Group(Expression<Func<AzureADv2NewMicrosoft365GroupInput>> azureADv2NewMicrosoft365Group)
        {
            var __workflow_azureADv2NewMicrosoft365Group = WorkflowExpression.Compile(azureADv2NewMicrosoft365Group, nameof(azureADv2NewMicrosoft365Group), required: true);
            return new DeferredBodyAction<AzureADv2NewMicrosoft365GroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2NewMicrosoft365Group";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2NewMicrosoft365Group);
                return new ApiConnectionAction<AzureADv2NewMicrosoft365GroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetGroupsResponse, ApiConnectionActionConfiguration> AzureADv2GetGroups(Expression<Func<AzureADv2GetGroupsInput>> azureADv2GetGroups)
        {
            var __workflow_azureADv2GetGroups = WorkflowExpression.Compile(azureADv2GetGroups, nameof(azureADv2GetGroups), required: true);
            return new DeferredBodyAction<AzureADv2GetGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetGroups);
                return new ApiConnectionAction<AzureADv2GetGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2EnableUserResponse, ApiConnectionActionConfiguration> AzureADv2EnableUser(Expression<Func<AzureADv2EnableUserInput>> azureADv2EnableUser)
        {
            var __workflow_azureADv2EnableUser = WorkflowExpression.Compile(azureADv2EnableUser, nameof(azureADv2EnableUser), required: true);
            return new DeferredBodyAction<AzureADv2EnableUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2EnableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2EnableUser);
                return new ApiConnectionAction<AzureADv2EnableUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2DisableUserResponse, ApiConnectionActionConfiguration> AzureADv2DisableUser(Expression<Func<AzureADv2DisableUserInput>> azureADv2DisableUser)
        {
            var __workflow_azureADv2DisableUser = WorkflowExpression.Compile(azureADv2DisableUser, nameof(azureADv2DisableUser), required: true);
            return new DeferredBodyAction<AzureADv2DisableUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2DisableUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2DisableUser);
                return new ApiConnectionAction<AzureADv2DisableUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToRoleResponse, ApiConnectionActionConfiguration> AzureADv2AssignUserToRole(Expression<Func<AzureADv2AssignUserToRoleInput>> azureADv2AssignUserToRole)
        {
            var __workflow_azureADv2AssignUserToRole = WorkflowExpression.Compile(azureADv2AssignUserToRole, nameof(azureADv2AssignUserToRole), required: true);
            return new DeferredBodyAction<AzureADv2AssignUserToRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToRole);
                return new ApiConnectionAction<AzureADv2AssignUserToRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2AssignUserToMultipleRolesResponse, ApiConnectionActionConfiguration> AzureADv2AssignUserToMultipleRoles(Expression<Func<AzureADv2AssignUserToMultipleRolesInput>> azureADv2AssignUserToMultipleRoles)
        {
            var __workflow_azureADv2AssignUserToMultipleRoles = WorkflowExpression.Compile(azureADv2AssignUserToMultipleRoles, nameof(azureADv2AssignUserToMultipleRoles), required: true);
            return new DeferredBodyAction<AzureADv2AssignUserToMultipleRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2AssignUserToMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2AssignUserToMultipleRoles);
                return new ApiConnectionAction<AzureADv2AssignUserToMultipleRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromMultipleRolesResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromMultipleRoles(Expression<Func<AzureADv2RemoveUserFromMultipleRolesInput>> azureADv2RemoveUserFromMultipleRoles)
        {
            var __workflow_azureADv2RemoveUserFromMultipleRoles = WorkflowExpression.Compile(azureADv2RemoveUserFromMultipleRoles, nameof(azureADv2RemoveUserFromMultipleRoles), required: true);
            return new DeferredBodyAction<AzureADv2RemoveUserFromMultipleRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromMultipleRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromMultipleRoles);
                return new ApiConnectionAction<AzureADv2RemoveUserFromMultipleRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2IsUserInRoleResponse, ApiConnectionActionConfiguration> AzureADv2IsUserInRole(Expression<Func<AzureADv2IsUserInRoleInput>> azureADv2IsUserInRole)
        {
            var __workflow_azureADv2IsUserInRole = WorkflowExpression.Compile(azureADv2IsUserInRole, nameof(azureADv2IsUserInRole), required: true);
            return new DeferredBodyAction<AzureADv2IsUserInRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2IsUserInRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2IsUserInRole);
                return new ApiConnectionAction<AzureADv2IsUserInRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADUserRoleAssignmentsResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADUserRoleAssignments(Expression<Func<AzureADv2GetAzureADUserRoleAssignmentsInput>> azureADv2GetAzureADUserRoleAssignments)
        {
            var __workflow_azureADv2GetAzureADUserRoleAssignments = WorkflowExpression.Compile(azureADv2GetAzureADUserRoleAssignments, nameof(azureADv2GetAzureADUserRoleAssignments), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADUserRoleAssignmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADUserRoleAssignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADUserRoleAssignments);
                return new ApiConnectionAction<AzureADv2GetAzureADUserRoleAssignmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromRoleResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromRole(Expression<Func<AzureADv2RemoveUserFromRoleInput>> azureADv2RemoveUserFromRole)
        {
            var __workflow_azureADv2RemoveUserFromRole = WorkflowExpression.Compile(azureADv2RemoveUserFromRole, nameof(azureADv2RemoveUserFromRole), required: true);
            return new DeferredBodyAction<AzureADv2RemoveUserFromRoleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromRole";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromRole);
                return new ApiConnectionAction<AzureADv2RemoveUserFromRoleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2RemoveUserFromAllRolesResponse, ApiConnectionActionConfiguration> AzureADv2RemoveUserFromAllRoles(Expression<Func<AzureADv2RemoveUserFromAllRolesInput>> azureADv2RemoveUserFromAllRoles)
        {
            var __workflow_azureADv2RemoveUserFromAllRoles = WorkflowExpression.Compile(azureADv2RemoveUserFromAllRoles, nameof(azureADv2RemoveUserFromAllRoles), required: true);
            return new DeferredBodyAction<AzureADv2RemoveUserFromAllRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2RemoveUserFromAllRoles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2RemoveUserFromAllRoles);
                return new ApiConnectionAction<AzureADv2RemoveUserFromAllRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<AzureADv2GetAzureADGroupMembersResponse, ApiConnectionActionConfiguration> AzureADv2GetAzureADGroupMembers(Expression<Func<AzureADv2GetAzureADGroupMembersInput>> azureADv2GetAzureADGroupMembers)
        {
            var __workflow_azureADv2GetAzureADGroupMembers = WorkflowExpression.Compile(azureADv2GetAzureADGroupMembers, nameof(azureADv2GetAzureADGroupMembers), required: true);
            return new DeferredBodyAction<AzureADv2GetAzureADGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAzureADv2/AzureADv2GetAzureADGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_azureADv2GetAzureADGroupMembers);
                return new ApiConnectionAction<AzureADv2GetAzureADGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration> OpenO365PowerShellRunspace(Expression<Func<OpenO365PowerShellRunspaceInput>> openO365PowerShellRunspace)
        {
            var __workflow_openO365PowerShellRunspace = WorkflowExpression.Compile(openO365PowerShellRunspace, nameof(openO365PowerShellRunspace), required: true);
            return new DeferredBodyAction<OpenO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspace);
                return new ApiConnectionAction<OpenO365PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<OpenO365PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration> OpenO365PowerShellRunspaceWithCertificate(Expression<Func<OpenO365PowerShellRunspaceWithCertificateInput>> openO365PowerShellRunspaceWithCertificate)
        {
            var __workflow_openO365PowerShellRunspaceWithCertificate = WorkflowExpression.Compile(openO365PowerShellRunspaceWithCertificate, nameof(openO365PowerShellRunspaceWithCertificate), required: true);
            return new DeferredBodyAction<OpenO365PowerShellRunspaceWithCertificateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/OpenO365PowerShellRunspaceWithCertificate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_openO365PowerShellRunspaceWithCertificate);
                return new ApiConnectionAction<OpenO365PowerShellRunspaceWithCertificateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<IsO365PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration> IsO365PowerShellRunspaceOpen(Expression<Func<IsO365PowerShellRunspaceOpenInput>> isO365PowerShellRunspaceOpen)
        {
            var __workflow_isO365PowerShellRunspaceOpen = WorkflowExpression.Compile(isO365PowerShellRunspaceOpen, nameof(isO365PowerShellRunspaceOpen), required: true);
            return new DeferredBodyAction<IsO365PowerShellRunspaceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/IsO365PowerShellRunspaceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isO365PowerShellRunspaceOpen);
                return new ApiConnectionAction<IsO365PowerShellRunspaceOpenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<RunO365PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration> RunO365PowerShellAutomationScript(Expression<Func<RunO365PowerShellAutomationScriptInput>> runO365PowerShellAutomationScript)
        {
            var __workflow_runO365PowerShellAutomationScript = WorkflowExpression.Compile(runO365PowerShellAutomationScript, nameof(runO365PowerShellAutomationScript), required: true);
            return new DeferredBodyAction<RunO365PowerShellAutomationScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/RunO365PowerShellAutomationScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runO365PowerShellAutomationScript);
                return new ApiConnectionAction<RunO365PowerShellAutomationScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<CloseO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration> CloseO365PowerShellRunspace(Expression<Func<CloseO365PowerShellRunspaceInput>> closeO365PowerShellRunspace)
        {
            var __workflow_closeO365PowerShellRunspace = WorkflowExpression.Compile(closeO365PowerShellRunspace, nameof(closeO365PowerShellRunspace), required: true);
            return new DeferredBodyAction<CloseO365PowerShellRunspaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/CloseO365PowerShellRunspace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_closeO365PowerShellRunspace);
                return new ApiConnectionAction<CloseO365PowerShellRunspaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365MailboxResponse, ApiConnectionActionConfiguration> O365GetO365Mailbox(Expression<Func<O365GetO365MailboxInput>> o365GetO365Mailbox)
        {
            var __workflow_o365GetO365Mailbox = WorkflowExpression.Compile(o365GetO365Mailbox, nameof(o365GetO365Mailbox), required: true);
            return new DeferredBodyAction<O365GetO365MailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365GetO365Mailbox);
                return new ApiConnectionAction<O365GetO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddMailboxPermissionResponse, ApiConnectionActionConfiguration> O365AddMailboxPermission(Expression<Func<O365AddMailboxPermissionInput>> o365AddMailboxPermission)
        {
            var __workflow_o365AddMailboxPermission = WorkflowExpression.Compile(o365AddMailboxPermission, nameof(o365AddMailboxPermission), required: true);
            return new DeferredBodyAction<O365AddMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365AddMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365AddMailboxPermission);
                return new ApiConnectionAction<O365AddMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxPermissionResponse, ApiConnectionActionConfiguration> O365RemoveMailboxPermission(Expression<Func<O365RemoveMailboxPermissionInput>> o365RemoveMailboxPermission)
        {
            var __workflow_o365RemoveMailboxPermission = WorkflowExpression.Compile(o365RemoveMailboxPermission, nameof(o365RemoveMailboxPermission), required: true);
            return new DeferredBodyAction<O365RemoveMailboxPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxPermission";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxPermission);
                return new ApiConnectionAction<O365RemoveMailboxPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365AddDistributionGroupMemberResponse, ApiConnectionActionConfiguration> O365AddDistributionGroupMember(Expression<Func<O365AddDistributionGroupMemberInput>> o365AddDistributionGroupMember)
        {
            var __workflow_o365AddDistributionGroupMember = WorkflowExpression.Compile(o365AddDistributionGroupMember, nameof(o365AddDistributionGroupMember), required: true);
            return new DeferredBodyAction<O365AddDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365AddDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365AddDistributionGroupMember);
                return new ApiConnectionAction<O365AddDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetO365DistributionGroupResponse, ApiConnectionActionConfiguration> O365GetO365DistributionGroup(Expression<Func<O365GetO365DistributionGroupInput>> o365GetO365DistributionGroup)
        {
            var __workflow_o365GetO365DistributionGroup = WorkflowExpression.Compile(o365GetO365DistributionGroup, nameof(o365GetO365DistributionGroup), required: true);
            return new DeferredBodyAction<O365GetO365DistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365GetO365DistributionGroup);
                return new ApiConnectionAction<O365GetO365DistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewO365DistributionGroupResponse, ApiConnectionActionConfiguration> O365NewO365DistributionGroup(Expression<Func<O365NewO365DistributionGroupInput>> o365NewO365DistributionGroup)
        {
            var __workflow_o365NewO365DistributionGroup = WorkflowExpression.Compile(o365NewO365DistributionGroup, nameof(o365NewO365DistributionGroup), required: true);
            return new DeferredBodyAction<O365NewO365DistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewO365DistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365NewO365DistributionGroup);
                return new ApiConnectionAction<O365NewO365DistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupResponse, ApiConnectionActionConfiguration> O365RemoveDistributionGroup(Expression<Func<O365RemoveDistributionGroupInput>> o365RemoveDistributionGroup)
        {
            var __workflow_o365RemoveDistributionGroup = WorkflowExpression.Compile(o365RemoveDistributionGroup, nameof(o365RemoveDistributionGroup), required: true);
            return new DeferredBodyAction<O365RemoveDistributionGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroup);
                return new ApiConnectionAction<O365RemoveDistributionGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxResponse, ApiConnectionActionConfiguration> O365SetO365Mailbox(Expression<Func<O365SetO365MailboxInput>> o365SetO365Mailbox)
        {
            var __workflow_o365SetO365Mailbox = WorkflowExpression.Compile(o365SetO365Mailbox, nameof(o365SetO365Mailbox), required: true);
            return new DeferredBodyAction<O365SetO365MailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365SetO365Mailbox);
                return new ApiConnectionAction<O365SetO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365WaitForO365MailboxResponse, ApiConnectionActionConfiguration> O365WaitForO365Mailbox(Expression<Func<O365WaitForO365MailboxInput>> o365WaitForO365Mailbox)
        {
            var __workflow_o365WaitForO365Mailbox = WorkflowExpression.Compile(o365WaitForO365Mailbox, nameof(o365WaitForO365Mailbox), required: true);
            return new DeferredBodyAction<O365WaitForO365MailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365WaitForO365Mailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365WaitForO365Mailbox);
                return new ApiConnectionAction<O365WaitForO365MailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365SetO365MailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration> O365SetO365MailboxAutoReplyConfiguration(Expression<Func<O365SetO365MailboxAutoReplyConfigurationInput>> o365SetO365MailboxAutoReplyConfiguration)
        {
            var __workflow_o365SetO365MailboxAutoReplyConfiguration = WorkflowExpression.Compile(o365SetO365MailboxAutoReplyConfiguration, nameof(o365SetO365MailboxAutoReplyConfiguration), required: true);
            return new DeferredBodyAction<O365SetO365MailboxAutoReplyConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365SetO365MailboxAutoReplyConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365SetO365MailboxAutoReplyConfiguration);
                return new ApiConnectionAction<O365SetO365MailboxAutoReplyConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration> O365RemoveDistributionGroupMember(Expression<Func<O365RemoveDistributionGroupMemberInput>> o365RemoveDistributionGroupMember)
        {
            var __workflow_o365RemoveDistributionGroupMember = WorkflowExpression.Compile(o365RemoveDistributionGroupMember, nameof(o365RemoveDistributionGroupMember), required: true);
            return new DeferredBodyAction<O365RemoveDistributionGroupMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveDistributionGroupMember";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365RemoveDistributionGroupMember);
                return new ApiConnectionAction<O365RemoveDistributionGroupMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration> O365GetMailboxDistributionGroupMembership(Expression<Func<O365GetMailboxDistributionGroupMembershipInput>> o365GetMailboxDistributionGroupMembership)
        {
            var __workflow_o365GetMailboxDistributionGroupMembership = WorkflowExpression.Compile(o365GetMailboxDistributionGroupMembership, nameof(o365GetMailboxDistributionGroupMembership), required: true);
            return new DeferredBodyAction<O365GetMailboxDistributionGroupMembershipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetMailboxDistributionGroupMembership";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365GetMailboxDistributionGroupMembership);
                return new ApiConnectionAction<O365GetMailboxDistributionGroupMembershipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365GetDistributionGroupMembersResponse, ApiConnectionActionConfiguration> O365GetDistributionGroupMembers(Expression<Func<O365GetDistributionGroupMembersInput>> o365GetDistributionGroupMembers)
        {
            var __workflow_o365GetDistributionGroupMembers = WorkflowExpression.Compile(o365GetDistributionGroupMembers, nameof(o365GetDistributionGroupMembers), required: true);
            return new DeferredBodyAction<O365GetDistributionGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365GetDistributionGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365GetDistributionGroupMembers);
                return new ApiConnectionAction<O365GetDistributionGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365RemoveMailboxFromAllDistributionGroupsResponse, ApiConnectionActionConfiguration> O365RemoveMailboxFromAllDistributionGroups(Expression<Func<O365RemoveMailboxFromAllDistributionGroupsInput>> o365RemoveMailboxFromAllDistributionGroups)
        {
            var __workflow_o365RemoveMailboxFromAllDistributionGroups = WorkflowExpression.Compile(o365RemoveMailboxFromAllDistributionGroups, nameof(o365RemoveMailboxFromAllDistributionGroups), required: true);
            return new DeferredBodyAction<O365RemoveMailboxFromAllDistributionGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365RemoveMailboxFromAllDistributionGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365RemoveMailboxFromAllDistributionGroups);
                return new ApiConnectionAction<O365RemoveMailboxFromAllDistributionGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewMailboxResponse, ApiConnectionActionConfiguration> O365NewMailbox(Expression<Func<O365NewMailboxInput>> o365NewMailbox)
        {
            var __workflow_o365NewMailbox = WorkflowExpression.Compile(o365NewMailbox, nameof(o365NewMailbox), required: true);
            return new DeferredBodyAction<O365NewMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365NewMailbox);
                return new ApiConnectionAction<O365NewMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365NewSharedMailboxResponse, ApiConnectionActionConfiguration> O365NewSharedMailbox(Expression<Func<O365NewSharedMailboxInput>> o365NewSharedMailbox)
        {
            var __workflow_o365NewSharedMailbox = WorkflowExpression.Compile(o365NewSharedMailbox, nameof(o365NewSharedMailbox), required: true);
            return new DeferredBodyAction<O365NewSharedMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365NewSharedMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365NewSharedMailbox);
                return new ApiConnectionAction<O365NewSharedMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365EnableArchiveMailboxResponse, ApiConnectionActionConfiguration> O365EnableArchiveMailbox(Expression<Func<O365EnableArchiveMailboxInput>> o365EnableArchiveMailbox)
        {
            var __workflow_o365EnableArchiveMailbox = WorkflowExpression.Compile(o365EnableArchiveMailbox, nameof(o365EnableArchiveMailbox), required: true);
            return new DeferredBodyAction<O365EnableArchiveMailboxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365EnableArchiveMailbox";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365EnableArchiveMailbox);
                return new ApiConnectionAction<O365EnableArchiveMailboxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<O365DoesMailboxHaveAnArchiveResponse, ApiConnectionActionConfiguration> O365DoesMailboxHaveAnArchive(Expression<Func<O365DoesMailboxHaveAnArchiveInput>> o365DoesMailboxHaveAnArchive)
        {
            var __workflow_o365DoesMailboxHaveAnArchive = WorkflowExpression.Compile(o365DoesMailboxHaveAnArchive, nameof(o365DoesMailboxHaveAnArchive), required: true);
            return new DeferredBodyAction<O365DoesMailboxHaveAnArchiveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/O365DoesMailboxHaveAnArchive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_o365DoesMailboxHaveAnArchive);
                return new ApiConnectionAction<O365DoesMailboxHaveAnArchiveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLGetNextAvailableAccountNameResponse, ApiConnectionActionConfiguration> JMLGetNextAvailableAccountName(Expression<Func<JMLGetNextAvailableAccountNameInput>> jMLGetNextAvailableAccountName)
        {
            var __workflow_jMLGetNextAvailableAccountName = WorkflowExpression.Compile(jMLGetNextAvailableAccountName, nameof(jMLGetNextAvailableAccountName), required: true);
            return new DeferredBodyAction<JMLGetNextAvailableAccountNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/JMLGetNextAvailableAccountName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jMLGetNextAvailableAccountName);
                return new ApiConnectionAction<JMLGetNextAvailableAccountNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjml")]
        public IBodyWorkflowAction<JMLConnectToJMLEnvironmentResponse, ApiConnectionActionConfiguration> JMLConnectToJMLEnvironment(Expression<Func<JMLConnectToJMLEnvironmentInput>> jMLConnectToJMLEnvironment)
        {
            var __workflow_jMLConnectToJMLEnvironment = WorkflowExpression.Compile(jMLConnectToJMLEnvironment, nameof(jMLConnectToJMLEnvironment), required: true);
            return new DeferredBodyAction<JMLConnectToJMLEnvironmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/PowerShellAutomation/JMLConnectToJMLEnvironment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jMLConnectToJMLEnvironment);
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

    public class RunActiveDirectoryPowerShellAutomationScriptInput
    {
        public string PowerShellScriptContents { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsNoResultAnError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnComplexTypes { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBooleanAsBoolean { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnNumericAsDecimal { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDateAsDate { get; set; } = false;
        public string PropertiesToReturnAsCollectionJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunScriptAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ScriptContainsStoredPassword { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogVerboseOutput { get; set; } = false;
        public string PropertyNamesToSerializeJSON { get; set; }
        public string PropertyTypesToSerializeJSON { get; set; }
        public RunActiveDirectoryPowerShellAutomationScriptInputPowerShellCommandParametersTypeItem[] PowerShellCommandParameters { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunActiveDirectoryPowerShellAutomationScriptInputPowerShellCommandParametersTypeItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int? IntValue { get; set; }
        public bool? BooleanValue { get; set; }
        public double? DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class OpenActiveDirectoryPowerShellRunspaceWithCredentialsResponse
    {
        public bool OpenActiveDirectoryPowerShellRunspaceWithCredentialsResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class OpenActiveDirectoryPowerShellRunspaceWithCredentialsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
        public string RemoteComputer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseSSL { get; set; } = false;
        public int? AlternativeTCPPort { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CloseActiveDirectoryPowerShellRunspaceResponse
    {
        public bool CloseActiveDirectoryPowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CloseActiveDirectoryPowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class IsActiveDirectoryPowerShellRunspaceOpenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResponse
    {
        public bool OpenLocalPassthroughActiveDirectoryPowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class OpenLocalPassthroughActiveDirectoryPowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryAddADUserResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string CreatedUserDistinguishedName { get; set; }
        public string CreatedUserSAMAccountName { get; set; }
        public string CreatedUserPrincipalName { get; set; }
    }

    public class ActiveDirectoryAddADUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string UserPrincipalName { get; set; }
        public string SamAccountName { get; set; }
        public string GivenName { get; set; }
        public string SurName { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string AccountPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Enabled { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ChangePasswordAtLogon { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CannotChangePassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordNeverExpires { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryGetADUserByIdentityResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfUsersFound { get; set; }
    }

    public class ActiveDirectoryGetADUserByIdentityInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ActiveDirectoryGetADUserByIdentityInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ActiveDirectoryGetADUserByIdentityInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }
        public string SearchOUBase { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchOUBaseSubtree { get; set; } = true;
        public string Properties { get; set; }
        public string ADServer { get; set; }
        public string PropertiesToReturnAsCollectionJSON { get; set; }
        public string PropertyNamesToSerializeJSON { get; set; }
        public string PropertyTypesToSerializeJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectoryGetADUserByIdentityInputFilterPropertyComparisonType
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

    public class ActiveDirectoryGetOUFromUserDNInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserDN { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryGetDomainFQDNFromDNResponse
    {
        public string DomainFQDN { get; set; }
    }

    public class ActiveDirectoryGetDomainFQDNFromDNInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DN { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryGetADGroupByIdentityResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    public class ActiveDirectoryGetADGroupByIdentityInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ActiveDirectoryGetADGroupByIdentityInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ActiveDirectoryGetADGroupByIdentityInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }
        public string SearchOUBase { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchOUBaseSubtree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfGroupDoesNotExist { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectoryGetADGroupByIdentityInputFilterPropertyComparisonType
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

    public class ActiveDirectoryAddADGroupMemberByIdentityInput
    {
        public string GroupIdentity { get; set; }
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryAddMultipleADGroupMembersByIdentityResponse
    {
        public int ADGroupMembersAddedSuccessfully { get; set; }
        public int ADGroupMembersFailedToAdd { get; set; }
        public string AddADGroupMembersMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryAddMultipleADGroupMembersByIdentityInput
    {
        public string GroupIdentity { get; set; }
        public string GroupMembersJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyMembersFailToAdd { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllMembersFailToAdd { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddAllMembersInASingleCall { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryAddADUserToMultipleADGroupsByNameResponse
    {
        public int ADGroupsAddedSuccessfully { get; set; }
        public int ADGroupsFailedToAdd { get; set; }
        public string AddADGroupsMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryAddADUserToMultipleADGroupsByNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string GroupNamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyGroupsFailToAdd { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllGroupsFailToAdd { get; set; } = false;
        public string ADServer { get; set; }
        public int? MaxGroupsPerCall { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryGetADUserGroupMembershipResponse
    {
        public string GroupMembershipJSON { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    public class ActiveDirectoryGetADUserGroupMembershipInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryModifyADUserStringPropertyByIdentityResponse
    {
        public bool ActiveDirectoryModifyADUserStringPropertyByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryModifyADUserStringPropertyByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public ActiveDirectoryModifyADUserStringPropertyByIdentityInputPropertiesListTypeItem[] PropertiesList { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryModifyADUserStringPropertyByIdentityInputPropertiesListTypeItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class ActiveDirectoryModifyADUserBooleanPropertyByIdentityResponse
    {
        public bool ActiveDirectoryModifyADUserBooleanPropertyByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryModifyADUserBooleanPropertyByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PropertyValue { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryModifyADUserPropertiesResponse
    {
        public bool ActiveDirectoryModifyADUserPropertiesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryModifyADUserPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string CountryString { get; set; }
        public string CountryISO3166 { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string GivenName { get; set; }
        public string HomePhone { get; set; }
        public string Initials { get; set; }
        public string IPPhone { get; set; }
        public string Manager { get; set; }
        public string MobilePhone { get; set; }
        public string Notes { get; set; }
        public string Office { get; set; }
        public string OfficePhone { get; set; }
        public string PostalCode { get; set; }
        public string ProfilePath { get; set; }
        public string ScriptPath { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryMoveADUserToOUByIdentityResponse
    {
        public bool ActiveDirectoryMoveADUserToOUByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryMoveADUserToOUByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetPath { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryClearADUserAccountExpirationResponse
    {
        public bool ActiveDirectoryClearADUserAccountExpirationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryClearADUserAccountExpirationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryDirSyncResponse
    {
        public string PowerShellJSONOutput { get; set; }
    }

    public class ActiveDirectoryDirSyncInput
    {
        public ActiveDirectoryDirSyncInputPolicyTypeType? PolicyType { get; set; }
        public string ComputerName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRetryAttempts { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsBetweenRetries { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectoryDirSyncInputPolicyTypeType
    {
        Delta,
        Initial
    }

    public class ActiveDirectoryRemoveADUserByIdentityResponse
    {
        public bool ActiveDirectoryRemoveADUserByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveADUserByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveProtectionFromAccidentalDeletion { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteEvenIfUserHasSubObjects { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ForceDeleteRecursive { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryResetADUserPasswordByIdentityResponse
    {
        public bool ActiveDirectoryResetADUserPasswordByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryResetADUserPasswordByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetUserPasswordProperties { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ChangePasswordAtLogon { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CannotChangePassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordNeverExpires { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPasswordTwice { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResponse
    {
        public bool ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADUserProtectedFromAccidentalDeletionByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProtectedFromAccidentalDeletion { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryDisableADUserByIdentityResponse
    {
        public bool ActiveDirectoryDisableADUserByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryDisableADUserByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryEnableADUserByIdentityResponse
    {
        public bool ActiveDirectoryEnableADUserByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryEnableADUserByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectorySetADUserHomeFolderByIdentityResponse
    {
        public bool ActiveDirectorySetADUserHomeFolderByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADUserHomeFolderByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string HomeDrive { get; set; }
        public string HomeDirectory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateFolder { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryCloneADUserGroupsResponse
    {
        public int ADGroupsAddedSuccessfully { get; set; }
        public int ADGroupsFailedToAdd { get; set; }
        public string AddADGroupsMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryCloneADUserGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceUserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationUserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryCloneADUserPropertiesResponse
    {
        public bool ActiveDirectoryCloneADUserPropertiesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryCloneADUserPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceUserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationUserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PropertiesToClone { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameResponse
    {
        public int ADGroupsRemovedSuccessfully { get; set; }
        public int ADGroupsFailedToRemove { get; set; }
        public string RemoveADGroupsMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveADUserFromMultipleADGroupsByNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string GroupNamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyGroupsFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllGroupsFailToRemove { get; set; } = false;
        public string ADServer { get; set; }
        public int? MaxGroupsPerCall { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryRemoveADUserFromAllGroupsResponse
    {
        public int ADGroupsRemovedSuccessfully { get; set; }
        public int ADGroupsFailedToRemove { get; set; }
        public int ADGroupsExcludedFromRemoval { get; set; }
        public string RemoveADGroupsMasterErrorMessage { get; set; }
        public int ThreadId { get; set; }
    }

    public class ActiveDirectoryRemoveADUserFromAllGroupsInput
    {
        public string UserIdentity { get; set; }
        public string GroupsToExcludeJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfExcludedGroupDoesNotExist { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryCheckOUExistsResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool OUExists { get; set; }
    }

    public class ActiveDirectoryCheckOUExistsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OUIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryRemoveADGroupMemberByGroupIdentityResponse
    {
        public bool ActiveDirectoryRemoveADGroupMemberByGroupIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveADGroupMemberByGroupIdentityInput
    {
        public string GroupIdentity { get; set; }
        public string GroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryRemoveMultipleADGroupMembersByIdentityResponse
    {
        public int ADGroupMembersRemovedSuccessfully { get; set; }
        public int ADGroupMembersFailedToRemove { get; set; }
        public string RemoveADGroupMembersMasterErrorMessage { get; set; }
    }

    public class ActiveDirectoryRemoveMultipleADGroupMembersByIdentityInput
    {
        public string GroupIdentity { get; set; }
        public string GroupMembersJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyMembersFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllMembersFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveAllMembersInASingleCall { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryUnlockADAccountByIdentityResponse
    {
        public bool ActiveDirectoryUnlockADAccountByIdentityResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectoryUnlockADAccountByIdentityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectorySetADServerResponse
    {
        public bool ActiveDirectorySetADServerResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADServerInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ActiveDirectorySetADServerInputPredefinedADServerChoiceType? PredefinedADServerChoice { get; set; } = ActiveDirectorySetADServerInputPredefinedADServerChoiceType.ManualSpecifyInADServerField;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectorySetADServerInputPredefinedADServerChoiceType
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

        [JsonProperty("DomainSID")]
        public string DomainSId { get; set; }
        public string Forest { get; set; }
        public string InfrastructureMaster { get; set; }
        public string NetBIOSName { get; set; }
        public string ObjectGUID { get; set; }
        public string PDCEmulator { get; set; }

        [JsonProperty("RIDMaster")]
        public string RIdMaster { get; set; }
    }

    public class ActiveDirectoryGetDomainInfoInput
    {
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ActiveDirectoryGetDomainInfoInputPredefinedIdentityType? PredefinedIdentity { get; set; } = ActiveDirectoryGetDomainInfoInputPredefinedIdentityType.ManualSpecifyInDomainIdentityField;
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectoryGetDomainInfoInputPredefinedIdentityType
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

    public class ActiveDirectoryAddADGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string SamAccountName { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string DisplayName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ActiveDirectoryAddADGroupInputGroupCategoryType GroupCategory { get; set; } = ActiveDirectoryAddADGroupInputGroupCategoryType.SecurityGroup;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ActiveDirectoryAddADGroupInputGroupScopeType GroupScope { get; set; } = ActiveDirectoryAddADGroupInputGroupScopeType.Global;
        public string HomePage { get; set; }
        public string ManagedBy { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProtectedFromAccidentalDeletion { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectoryAddADGroupInputGroupCategoryType
    {
        [EnumMember(Value = "Security")]
        SecurityGroup,
        [EnumMember(Value = "Distribution")]
        DistributionGroup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActiveDirectoryAddADGroupInputGroupScopeType
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

    public class ActiveDirectoryDoesADGroupExistInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupIdentity { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryRemoveADGroupResponse
    {
        public int NumberOfGroupsDeleted { get; set; }
    }

    public class ActiveDirectoryRemoveADGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteEvenIfProtected { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfGroupDoesNotExist { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryAddOUResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string CreatedOUDistinguishedName { get; set; }
    }

    public class ActiveDirectoryAddOUInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string ManagedBy { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProtectedFromAccidentalDeletion { get; set; } = true;
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryRemoveOUResponse
    {
        public int NumberOfOUsDeleted { get; set; }
    }

    public class ActiveDirectoryRemoveOUInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OUIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteEvenIfProtected { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfOUDoesNotExist { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectorySetADUserAccountExpirationEndOfDateResponse
    {
        public bool ActiveDirectorySetADUserAccountExpirationEndOfDateResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ActiveDirectorySetADUserAccountExpirationEndOfDateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Year { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Month { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Day { get; set; }
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ActiveDirectoryGetADGroupMembersResponse
    {
        public string GroupMembersJSON { get; set; }
        public int CountOfGroupMembersFound { get; set; }
    }

    public class ActiveDirectoryGetADGroupMembersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Recursive { get; set; } = false;
        public string ADServer { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class OpenExchangePowerShellRunspaceResponse
    {
        public bool OpenExchangePowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class OpenExchangePowerShellRunspaceInput
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ExchangeServerFQDN { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseSSL { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenExchangePowerShellRunspaceInputConnectionMethodType? ConnectionMethod { get; set; } = OpenExchangePowerShellRunspaceInputConnectionMethodType.RemoteCommandsRunInRemoteExchangeRunspace;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenExchangePowerShellRunspaceInputAuthenticationMechanismType? AuthenticationMechanism { get; set; } = OpenExchangePowerShellRunspaceInputAuthenticationMechanismType.Kerberos;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyConnectIfNotAlreadyConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenExchangePowerShellRunspaceInputCommandTypesToImportLocallyType? CommandTypesToImportLocally { get; set; } = OpenExchangePowerShellRunspaceInputCommandTypesToImportLocallyType.AllAllExchangePSCommands;
        public string AdditionalCommandsToImportLocallyCSV { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenExchangePowerShellRunspaceInputConnectionMethodType
    {
        [EnumMember(Value = "Local")]
        LocalRemoteExchangeRunspaceIsImportedLocally,
        [EnumMember(Value = "Remote")]
        RemoteCommandsRunInRemoteExchangeRunspace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenExchangePowerShellRunspaceInputAuthenticationMechanismType
    {
        Basic,
        CredSSP,
        Default,
        Digest,
        Kerberos,
        Negotiate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenExchangePowerShellRunspaceInputCommandTypesToImportLocallyType
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

        [JsonProperty("PowerShellRunspacePID")]
        public int PowerShellRunspacePId { get; set; }
        public bool IsAgentHostingPowerShellRunSpace { get; set; }
    }

    public class IsExchangePowerShellRunspaceOpenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TestCommunications { get; set; } = true;

        [JsonProperty("RetrievePowerShellRunSpacePID", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrievePowerShellRunSpacePId { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunExchangePowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class RunExchangePowerShellAutomationScriptInput
    {
        public string PowerShellScriptContents { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsNoResultAnError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnComplexTypes { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBooleanAsBoolean { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnNumericAsDecimal { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDateAsDate { get; set; } = false;
        public string PropertiesToReturnAsCollectionJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunScriptAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ScriptContainsStoredPassword { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogVerboseOutput { get; set; } = false;
        public string PropertyNamesToSerializeJSON { get; set; }
        public string PropertyTypesToSerializeJSON { get; set; }
        public RunExchangePowerShellAutomationScriptInputPowerShellCommandParametersTypeItem[] PowerShellCommandParameters { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunExchangePowerShellAutomationScriptInputPowerShellCommandParametersTypeItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int? IntValue { get; set; }
        public bool? BooleanValue { get; set; }
        public double? DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class CloseExchangePowerShellRunspaceResponse
    {
        public bool CloseExchangePowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CloseExchangePowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeGetMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    public class ExchangeGetMailboxInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeGetMailboxInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ExchangeGetMailboxInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }
        public ExchangeGetMailboxInputRecipientTypeDetailsType? RecipientTypeDetails { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeGetMailboxInputFilterPropertyComparisonType
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
    public enum ExchangeGetMailboxInputRecipientTypeDetailsType
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

    public class ExchangeDoesMailboxExistInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeDoesMailboxExistInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ExchangeDoesMailboxExistInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }
        public ExchangeDoesMailboxExistInputRecipientTypeDetailsType? RecipientTypeDetails { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeDoesMailboxExistInputFilterPropertyComparisonType
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
    public enum ExchangeDoesMailboxExistInputRecipientTypeDetailsType
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

    public class ExchangeAddDistributionGroupMemberInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Member { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeRemoveDistributionGroupMemberResponse
    {
        public bool ExchangeRemoveDistributionGroupMemberResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeRemoveDistributionGroupMemberInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Member { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BypassSecurityGroupManagerCheck { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeGetDistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfDistributionGroupsFound { get; set; }
    }

    public class ExchangeGetDistributionGroupInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeGetDistributionGroupInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ExchangeGetDistributionGroupInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeGetDistributionGroupInputFilterPropertyComparisonType
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

    public class ExchangeGetDistributionGroupMembersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeGetMailboxDistributionGroupMembershipResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfDistributionGroupsFound { get; set; }
    }

    public class ExchangeGetMailboxDistributionGroupMembershipInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeNewDistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string NewGroupDN { get; set; }
        public string NewGroupGUID { get; set; }
    }

    public class ExchangeNewDistributionGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string Notes { get; set; }
        public string ManagedBy { get; set; }
        public string Members { get; set; }
        public string OrganizationalUnit { get; set; }
        public string PrimarySmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeNewDistributionGroupInputMemberDepartRestrictionType? MemberDepartRestriction { get; set; } = ExchangeNewDistributionGroupInputMemberDepartRestrictionType.Open;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeNewDistributionGroupInputMemberJoinRestrictionType? MemberJoinRestriction { get; set; } = ExchangeNewDistributionGroupInputMemberJoinRestrictionType.Closed;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RequireSenderAuthenticationEnabled { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeNewDistributionGroupInputTypeType? Type { get; set; } = ExchangeNewDistributionGroupInputTypeType.Distribution;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ErrorIfGroupAlreadyExists { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeNewDistributionGroupInputMemberDepartRestrictionType
    {
        Open,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeNewDistributionGroupInputMemberJoinRestrictionType
    {
        Open,
        Closed,
        ApprovalRequired
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeNewDistributionGroupInputTypeType
    {
        Distribution,
        Security
    }

    public class ExchangeRemoveDistributionGroupResponse
    {
        public bool ExchangeRemoveDistributionGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeRemoveDistributionGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BypassSecurityGroupManagerCheck { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ErrorIfGroupDoesNotExist { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeAddMailboxPermissionResponse
    {
        public bool ExchangeAddMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeAddMailboxPermissionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessRights { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoMapping { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeRemoveMailboxPermissionResponse
    {
        public bool ExchangeRemoveMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeRemoveMailboxPermissionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessRights { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeDisableMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
    }

    public class ExchangeDisableMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeDisableRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
    }

    public class ExchangeDisableRemoteMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeEnableMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeEnableMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string LinkedDomainController { get; set; }
        public string LinkedMasterAccount { get; set; }
        public string Database { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public bool? EmailAddressPolicyEnabled { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeEnableRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeEnableRemoteMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string RemoteRoutingAddress { get; set; }
        public string PrimarySmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Archive { get; set; } = false;
        public bool? EmailAddressPolicyEnabled { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeGetRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    public class ExchangeGetRemoteMailboxInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeGetRemoteMailboxInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ExchangeGetRemoteMailboxInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeGetRemoteMailboxInputFilterPropertyComparisonType
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

    public class ExchangeDoesRemoteMailboxExistInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeDoesRemoteMailboxExistInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = ExchangeDoesRemoteMailboxExistInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeDoesRemoteMailboxExistInputFilterPropertyComparisonType
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

    public class ExchangeNewMailboxInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OrganizationalUnit { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public string PrimarySmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }
        public string SamAccountName { get; set; }
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPasswordOnNextLogon { get; set; } = true;
        public string Database { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SharedMailbox { get; set; } = false;
        public bool? EmailAddressPolicyEnabled { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Archive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeNewRemoteMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public string NewMailboxDN { get; set; }
        public string NewMailboxGUID { get; set; }
    }

    public class ExchangeNewRemoteMailboxInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OnPremisesOrganizationalUnit { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string RemoteRoutingAddress { get; set; }
        public string Alias { get; set; }
        public string PrimarySmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }
        public string SamAccountName { get; set; }
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPasswordOnNextLogon { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SharedMailbox { get; set; } = false;
        public bool? EmailAddressPolicyEnabled { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Archive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeSetADServerToViewEntireForestResponse
    {
        public bool ExchangeSetADServerToViewEntireForestResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetADServerToViewEntireForestInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ViewEntireForest { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeSetMailboxResponse
    {
        public bool ExchangeSetMailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public bool? AccountDisabled { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public bool? HiddenFromAddressListsEnabled { get; set; }
        public string CustomAttribute1 { get; set; }
        public string CustomAttribute2 { get; set; }
        public string CustomAttribute3 { get; set; }
        public string CustomAttribute4 { get; set; }
        public string CustomAttribute5 { get; set; }
        public string CustomAttribute6 { get; set; }
        public string CustomAttribute7 { get; set; }
        public string CustomAttribute8 { get; set; }
        public string CustomAttribute9 { get; set; }
        public string CustomAttribute10 { get; set; }
        public string CustomAttribute11 { get; set; }
        public string CustomAttribute12 { get; set; }
        public string CustomAttribute13 { get; set; }
        public string CustomAttribute14 { get; set; }
        public string CustomAttribute15 { get; set; }
        public bool? EmailAddressPolicyEnabled { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeSetMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeSetMailboxEmailAddressesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public string Alias { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public bool? EmailAddressPolicyEnabled { get; set; }
        public string[] EmailAddressesToAddList { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceEmailAddresses { get; set; } = true;
        public string[] EmailAddressesToRemoveList { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeGetMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeGetMailboxEmailAddressesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeSetRemoteMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeSetRemoteMailboxEmailAddressesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public string Alias { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public bool? EmailAddressPolicyEnabled { get; set; }
        public string[] EmailAddressesToAddList { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceEmailAddresses { get; set; } = true;
        public string[] EmailAddressesToRemoveList { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeGetRemoteMailboxEmailAddressesResponse
    {
        public string[] MailboxEmailAddresses { get; set; }
    }

    public class ExchangeGetRemoteMailboxEmailAddressesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeResetMailboxAttributesResponse
    {
        public bool ExchangeResetMailboxAttributesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeResetMailboxAttributesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute1 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute2 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute3 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute4 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute5 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute6 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute7 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute8 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute9 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute10 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute11 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute12 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute13 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute14 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute15 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeResetRemoteMailboxAttributesResponse
    {
        public bool ExchangeResetRemoteMailboxAttributesResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeResetRemoteMailboxAttributesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute1 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute2 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute3 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute4 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute5 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute6 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute7 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute8 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute9 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute10 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute11 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute12 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute13 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute14 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCustomAttribute15 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeSetRemoteMailboxResponse
    {
        public bool ExchangeSetRemoteMailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetRemoteMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public ExchangeSetRemoteMailboxInputTypeType? Type { get; set; }
        public bool? HiddenFromAddressListsEnabled { get; set; }
        public string CustomAttribute1 { get; set; }
        public string CustomAttribute2 { get; set; }
        public string CustomAttribute3 { get; set; }
        public string CustomAttribute4 { get; set; }
        public string CustomAttribute5 { get; set; }
        public string CustomAttribute6 { get; set; }
        public string CustomAttribute7 { get; set; }
        public string CustomAttribute8 { get; set; }
        public string CustomAttribute9 { get; set; }
        public string CustomAttribute10 { get; set; }
        public string CustomAttribute11 { get; set; }
        public string CustomAttribute12 { get; set; }
        public string CustomAttribute13 { get; set; }
        public string CustomAttribute14 { get; set; }
        public string CustomAttribute15 { get; set; }
        public bool? EmailAddressPolicyEnabled { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeSetRemoteMailboxInputTypeType
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

    public class ExchangeSetMailboxSendOnBehalfOfPermissionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GrantSendOnBehalfTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeAddADPermissionResponse
    {
        public bool ExchangeAddADPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeAddADPermissionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }
        public string AccessRights { get; set; }
        public string ExtendedRights { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExchangeSetMailboxAutoReplyConfigurationResponse
    {
        public bool ExchangeSetMailboxAutoReplyConfigurationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ExchangeSetMailboxAutoReplyConfigurationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeSetMailboxAutoReplyConfigurationInputAutoReplyStateType AutoReplyState { get; set; } = ExchangeSetMailboxAutoReplyConfigurationInputAutoReplyStateType.EnabledAutomaticRepliesAreSent;
        public string InternalMessage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ExchangeSetMailboxAutoReplyConfigurationInputExternalAudienceType? ExternalAudience { get; set; } = ExchangeSetMailboxAutoReplyConfigurationInputExternalAudienceType.AllRepliesAreSentToAllSenders;
        public string ExternalMessage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeSetMailboxAutoReplyConfigurationInputAutoReplyStateType
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExchangeSetMailboxAutoReplyConfigurationInputExternalAudienceType
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

    public class IsAzureADv2PowerShellModuleInstalledInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class OpenAzureADv2PowerShellRunspaceResponse
    {
        public bool OpenAzureADv2PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class OpenAzureADv2PowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Username { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
        public string TenantId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenAzureADv2PowerShellRunspaceInputAPIToUseType? APIToUse { get; set; } = OpenAzureADv2PowerShellRunspaceInputAPIToUseType.AutoDetect;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationScope { get; set; } = "User.ReadWrite.All Group.ReadWrite.All LicenseAssignment.ReadWrite.All";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAzureADv2PowerShellRunspaceInputAPIToUseType
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

    public class OpenAzureADv2PowerShellRunspaceWithCertificateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApplicationId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CertificateThumbprint { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string TenantId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenAzureADv2PowerShellRunspaceWithCertificateInputAPIToUseType? APIToUse { get; set; } = OpenAzureADv2PowerShellRunspaceWithCertificateInputAPIToUseType.AutoDetect;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAzureADv2PowerShellRunspaceWithCertificateInputAPIToUseType
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

        [JsonProperty("PowerShellRunspacePID")]
        public int PowerShellRunspacePId { get; set; }
        public bool IsAgentHostingPowerShellRunSpace { get; set; }
    }

    public class IsAzureADv2PowerShellRunspaceOpenInput
    {
        [JsonProperty("RetrievePowerShellRunSpacePID", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrievePowerShellRunSpacePId { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunAzureADv2PowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class RunAzureADv2PowerShellAutomationScriptInput
    {
        public string PowerShellScriptContents { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsNoResultAnError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnComplexTypes { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBooleanAsBoolean { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnNumericAsDecimal { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDateAsDate { get; set; } = false;
        public string PropertiesToReturnAsCollectionJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunScriptAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ScriptContainsStoredPassword { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogVerboseOutput { get; set; } = false;
        public string PropertyNamesToSerializeJSON { get; set; }
        public string PropertyTypesToSerializeJSON { get; set; }
        public RunAzureADv2PowerShellAutomationScriptInputPowerShellCommandParametersTypeItem[] PowerShellCommandParameters { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunAzureADv2PowerShellAutomationScriptInputPowerShellCommandParametersTypeItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int? IntValue { get; set; }
        public bool? BooleanValue { get; set; }
        public double? DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class CloseAzureADv2PowerShellRunspaceResponse
    {
        public bool CloseAzureADv2PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CloseAzureADv2PowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2GetAzureADUsersResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfUsersFound { get; set; }
    }

    public class AzureADv2GetAzureADUsersInput
    {
        public string ObjectId { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureADv2GetAzureADUsersInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = AzureADv2GetAzureADUsersInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;
        public string PropertiesToReturn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2GetAzureADUsersInputFilterPropertyComparisonType
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

    public class AzureADv2AddAzureADUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AccountEnabled { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccountPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        public string FaxNumber { get; set; }
        public string JobTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailNickName { get; set; }
        public string MobilePhone { get; set; }
        public string Office { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string PreferredLanguage { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string UsageLocation { get; set; }
        public AzureADv2AddAzureADUserInputAgeGroupType? AgeGroup { get; set; }
        public AzureADv2AddAzureADUserInputConsentProvidedForMinorType? ConsentProvidedForMinor { get; set; }
        public string EmployeeId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ForceChangePasswordNextLogin { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnforceChangePasswordPolicy { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordNeverExpires { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2AddAzureADUserInputAgeGroupType
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2AddAzureADUserInputConsentProvidedForMinorType
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

    public class AzureADv2RemoveAzureADUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ErrorIfUserDoesNotExist { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2ResetAzureADUserPasswordResponse
    {
        public bool AzureADv2ResetAzureADUserPasswordResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2ResetAzureADUserPasswordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ForceChangePasswordNextLogin { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnforceChangePasswordPolicy { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2GetAzureADUserGroupMembershipResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    public class AzureADv2GetAzureADUserGroupMembershipInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }
        public string PropertiesToReturn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2IsUserInAzureADUserGroupResponse
    {
        public bool UserIsInGroup { get; set; }
    }

    public class AzureADv2IsUserInAzureADUserGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2AddUserToGroupResponse
    {
        public bool AzureADv2AddUserToGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2AddUserToGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckUserGroupMembershipsFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveUserFromGroupResponse
    {
        public bool AzureADv2RemoveUserFromGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckUserGroupMembershipsFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2AddADUserToMultipleADGroupsResponse
    {
        public int AzureADGroupsAddedSuccessfully { get; set; }
        public int AzureADGroupsFailedToAdd { get; set; }
        public string AddAzureADGroupsMasterErrorMessage { get; set; }
    }

    public class AzureADv2AddADUserToMultipleADGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }
        public string GroupNamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyGroupsFailToAdd { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllGroupsFailToAdd { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckUserGroupMembershipsFirst { get; set; } = true;
        public int? MaxAzureADGroupsPerCall { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveADUserFromMultipleADGroupsResponse
    {
        public int AzureADGroupsRemovedSuccessfully { get; set; }
        public int AzureADGroupsFailedToRemove { get; set; }
        public string RemoveAzureADGroupsErrorMessage { get; set; }
    }

    public class AzureADv2RemoveADUserFromMultipleADGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }
        public string GroupNamesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyGroupsFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllGroupsFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckUserGroupMembershipsFirst { get; set; } = true;
        public int? MaxAzureADGroupsPerCall { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveUserFromAllGroupsResponse
    {
        public int AzureADGroupsRemovedSuccessfully { get; set; }
        public int AzureADGroupsFailedToRemove { get; set; }
        public string RemoveAzureADGroupsErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromAllGroupsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyGroupsFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllGroupsFailToRemove { get; set; } = false;
        public int? MaxAzureADGroupsPerCall { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2GetAzureADLicenseSKUsResponse
    {
        public string LicenseSKUJSONOutput { get; set; }
        public int CountOfSKUsFound { get; set; }
    }

    public class AzureADv2GetAzureADLicenseSKUsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureADv2GetAzureADLicenseSKUsInputExpandPropertyType? ExpandProperty { get; set; } = AzureADv2GetAzureADLicenseSKUsInputExpandPropertyType.None;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2GetAzureADLicenseSKUsInputExpandPropertyType
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

    public class AzureADv2SetAzureADUserLicenseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }
        public string LicenseToAdd { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureADv2SetAzureADUserLicenseInputLicensePlansChoiceType? LicensePlansChoice { get; set; } = AzureADv2SetAzureADUserLicenseInputLicensePlansChoiceType.AllEnableAllPlans;
        public string LicensePlansCSV { get; set; }
        public string LicensesToRemoveCSV { get; set; }
        public string UsageLocation { get; set; }
        public bool? LocalScope { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2SetAzureADUserLicenseInputLicensePlansChoiceType
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

    public class AzureADv2GetAzureADUserLicensesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2GetAzureADUserLicenseServicePlansResponse
    {
        public string UserLicenseSKUServicePlansJSONOutput { get; set; }
        public int CountOfUserLicenseSKUServicePlansFound { get; set; }
    }

    public class AzureADv2GetAzureADUserLicenseServicePlansInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LicenseSKUPartNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveAllAzureADUserLicenseResponse
    {
        public bool AzureADv2RemoveAllAzureADUserLicenseResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2RemoveAllAzureADUserLicenseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2SetAzureADUserResponse
    {
        public bool AzureADv2SetAzureADUserResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2SetAzureADUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        public string FaxNumber { get; set; }
        public string JobTitle { get; set; }
        public string MobilePhone { get; set; }
        public string Office { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCode { get; set; }
        public string PreferredLanguage { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string UsageLocation { get; set; }
        public AzureADv2SetAzureADUserInputAgeGroupType? AgeGroup { get; set; }
        public AzureADv2SetAzureADUserInputConsentProvidedForMinorType? ConsentProvidedForMinor { get; set; }
        public string MailNickName { get; set; }
        public string EmployeeId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2SetAzureADUserInputAgeGroupType
    {
        None,
        Minor,
        NotAdult,
        Adult
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2SetAzureADUserInputConsentProvidedForMinorType
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

    public class AzureADv2ResetAzureADUserPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetFirstName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetLastName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCity { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCompanyName { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetCountry { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetDepartment { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetFaxNumber { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetJobTitle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetMobilePhone { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetOffice { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPhoneNumber { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPostalCode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPreferredLanguage { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetState { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetStreetAddress { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetUsageLocation { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetAgeGroup { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetConsentProvidedForMinor { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetEmployeeId { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2SetAzureADUserManagerResponse
    {
        public bool AzureADv2SetAzureADUserManagerResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2SetAzureADUserManagerInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }
        public string Manager { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2NewSecurityGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string CreatedGroupObjectId { get; set; }
    }

    public class AzureADv2NewSecurityGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckGroupExists { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveSecurityGroupResponse
    {
        public bool GroupExisted { get; set; }
    }

    public class AzureADv2RemoveSecurityGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ErrorIfGroupDoesNotExist { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2NewMicrosoft365GroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public bool GroupAlreadyExists { get; set; }
        public string CreatedGroupObjectId { get; set; }
    }

    public class AzureADv2NewMicrosoft365GroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string MailNickname { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureADv2NewMicrosoft365GroupInputGroupVisibilityType? GroupVisibility { get; set; } = AzureADv2NewMicrosoft365GroupInputGroupVisibilityType.PublicAnyoneCanViewOrJoin;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckGroupExists { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2NewMicrosoft365GroupInputGroupVisibilityType
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

    public class AzureADv2GetGroupsInput
    {
        public string ObjectId { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AzureADv2GetGroupsInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = AzureADv2GetGroupsInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;
        public string PropertiesToReturn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AzureADv2GetGroupsInputFilterPropertyComparisonType
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

    public class AzureADv2EnableUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2DisableUserResponse
    {
        public bool AzureADv2DisableUserResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2DisableUserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RevokeUserRefreshTokens { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2AssignUserToRoleResponse
    {
        public bool AzureADv2AssignUserToRoleResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class AzureADv2AssignUserToRoleInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryScopeId { get; set; } = "/";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckUserRoleMembershipsFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2AssignUserToMultipleRolesResponse
    {
        public int AzureADRolesAssignedSuccessfully { get; set; }
        public int AzureADRolesFailedToAssign { get; set; }
        public string AssignAzureADRolesMasterErrorMessage { get; set; }
    }

    public class AzureADv2AssignUserToMultipleRolesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }
        public string RolesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyRolesFailToAssign { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllRolesFailToAssign { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryScopeId { get; set; } = "/";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckUserRoleMembershipsFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckRoleIdsExist { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveUserFromMultipleRolesResponse
    {
        public int AzureADRolesRemovedSuccessfully { get; set; }
        public int AzureADRolesFailedToRemove { get; set; }
        public string RemoveAzureADRolesMasterErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromMultipleRolesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }
        public string RolesJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryScopeId { get; set; } = "*";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyRolesFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllRolesFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfRoleDoesNotExist { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2IsUserInRoleResponse
    {
        public bool UserIsAssignedToRole { get; set; }
    }

    public class AzureADv2IsUserInRoleInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2GetAzureADUserRoleAssignmentsResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfRoleAssignmentsFound { get; set; }
    }

    public class AzureADv2GetAzureADUserRoleAssignmentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrieveAdminRoleNames { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnAssignmentIds { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveUserFromRoleResponse
    {
        public bool UserRemovedFromRole { get; set; }
    }

    public class AzureADv2RemoveUserFromRoleInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RoleObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryScopeId { get; set; } = "*";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2RemoveUserFromAllRolesResponse
    {
        public int AzureADRolesRemovedSuccessfully { get; set; }
        public int AzureADRolesFailedToRemove { get; set; }
        public string RemoveAzureADRolesErrorMessage { get; set; }
    }

    public class AzureADv2RemoveUserFromAllRolesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserObjectId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyRolesFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllRolesFailToRemove { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AzureADv2GetAzureADGroupMembersResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupMembersFound { get; set; }
    }

    public class AzureADv2GetAzureADGroupMembersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupObjectId { get; set; }
        public string PropertiesToReturn { get; set; }
        public string MemberObjectTypesToReturn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class OpenO365PowerShellRunspaceResponse
    {
        public bool OpenO365PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class OpenO365PowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Office365Username { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Office365Password { get; set; }
        public string ExchangeURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenO365PowerShellRunspaceInputConnectionMethodType? ConnectionMethod { get; set; } = OpenO365PowerShellRunspaceInputConnectionMethodType.EXOV1LocalRemoteExchangeOnlineIsImportedLocally;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyConnectIfNotAlreadyConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenO365PowerShellRunspaceInputCommandTypesToImportLocallyType? CommandTypesToImportLocally { get; set; } = OpenO365PowerShellRunspaceInputCommandTypesToImportLocallyType.AllAllO365ExchangePSCommands;
        public string AdditionalCommandsToImportLocallyCSV { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenO365PowerShellRunspaceInputConnectionMethodType
    {
        [EnumMember(Value = "EXO V1 local")]
        EXOV1LocalRemoteExchangeOnlineIsImportedLocally,
        [EnumMember(Value = "EXO V1 remote")]
        EXOV1RemoteCommandsRunInRemoteExchangeOnline,
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenO365PowerShellRunspaceInputCommandTypesToImportLocallyType
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

    public class OpenO365PowerShellRunspaceWithCertificateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ApplicationId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CertificateThumbprint { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Organization { get; set; }
        public string ExchangeURL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenO365PowerShellRunspaceWithCertificateInputConnectionMethodType? ConnectionMethod { get; set; } = OpenO365PowerShellRunspaceWithCertificateInputConnectionMethodType.EXOV2ExchangeOnlinePowerShellV2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyConnectIfNotAlreadyConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public OpenO365PowerShellRunspaceWithCertificateInputCommandTypesToImportLocallyType? CommandTypesToImportLocally { get; set; } = OpenO365PowerShellRunspaceWithCertificateInputCommandTypesToImportLocallyType.AllAllO365ExchangePSCommands;
        public string AdditionalCommandsToImportLocallyCSV { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenO365PowerShellRunspaceWithCertificateInputConnectionMethodType
    {
        [EnumMember(Value = "EXO V2")]
        EXOV2ExchangeOnlinePowerShellV2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenO365PowerShellRunspaceWithCertificateInputCommandTypesToImportLocallyType
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

        [JsonProperty("PowerShellRunspacePID")]
        public int PowerShellRunspacePId { get; set; }
        public bool IsAgentHostingPowerShellRunSpace { get; set; }
    }

    public class IsO365PowerShellRunspaceOpenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TestCommunications { get; set; } = true;

        [JsonProperty("RetrievePowerShellRunSpacePID", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrievePowerShellRunSpacePId { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunO365PowerShellAutomationScriptResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int ThreadId { get; set; }
    }

    public class RunO365PowerShellAutomationScriptInput
    {
        public string PowerShellScriptContents { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsNoResultAnError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnComplexTypes { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnBooleanAsBoolean { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnNumericAsDecimal { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDateAsDate { get; set; } = false;
        public string PropertiesToReturnAsCollectionJSON { get; set; }
        public bool? LocalScope { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunScriptAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ScriptContainsStoredPassword { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LogVerboseOutput { get; set; } = false;
        public string PropertyNamesToSerializeJSON { get; set; }
        public string PropertyTypesToSerializeJSON { get; set; }
        public RunO365PowerShellAutomationScriptInputPowerShellCommandParametersTypeItem[] PowerShellCommandParameters { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunO365PowerShellAutomationScriptInputPowerShellCommandParametersTypeItem
    {
        public string Name { get; set; }
        public string StringValue { get; set; }
        public int? IntValue { get; set; }
        public bool? BooleanValue { get; set; }
        public double? DecimalValue { get; set; }
        public JToken ObjectValue { get; set; }
    }

    public class CloseO365PowerShellRunspaceResponse
    {
        public bool CloseO365PowerShellRunspaceResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CloseO365PowerShellRunspaceInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365GetO365MailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfMailboxesFound { get; set; }
    }

    public class O365GetO365MailboxInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public O365GetO365MailboxInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = O365GetO365MailboxInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }
        public O365GetO365MailboxInputRecipientTypeDetailsType? RecipientTypeDetails { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365GetO365MailboxInputFilterPropertyComparisonType
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
    public enum O365GetO365MailboxInputRecipientTypeDetailsType
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

    public class O365AddMailboxPermissionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessRights { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoMapping { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365RemoveMailboxPermissionResponse
    {
        public bool O365RemoveMailboxPermissionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365RemoveMailboxPermissionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessRights { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365AddDistributionGroupMemberResponse
    {
        public bool O365AddDistributionGroupMemberResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365AddDistributionGroupMemberInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Member { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BypassSecurityGroupManagerCheck { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365GetO365DistributionGroupResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfGroupsFound { get; set; }
    }

    public class O365GetO365DistributionGroupInput
    {
        public string Identity { get; set; }
        public string FilterPropertyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public O365GetO365DistributionGroupInputFilterPropertyComparisonType? FilterPropertyComparison { get; set; } = O365GetO365DistributionGroupInputFilterPropertyComparisonType.EqualsExactMatch;
        public string FilterPropertyValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NoResultIsAnException { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365GetO365DistributionGroupInputFilterPropertyComparisonType
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

    public class O365NewO365DistributionGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public string Notes { get; set; }
        public string ManagedBy { get; set; }
        public string Members { get; set; }
        public string OrganizationalUnit { get; set; }
        public string PrimarySmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public O365NewO365DistributionGroupInputMemberDepartRestrictionType? MemberDepartRestriction { get; set; } = O365NewO365DistributionGroupInputMemberDepartRestrictionType.Open;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public O365NewO365DistributionGroupInputMemberJoinRestrictionType? MemberJoinRestriction { get; set; } = O365NewO365DistributionGroupInputMemberJoinRestrictionType.Closed;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RequireSenderAuthenticationEnabled { get; set; } = false;
        public O365NewO365DistributionGroupInputTypeType? Type { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365NewO365DistributionGroupInputMemberDepartRestrictionType
    {
        Open,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365NewO365DistributionGroupInputMemberJoinRestrictionType
    {
        Open,
        Closed,
        ApprovalRequired
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365NewO365DistributionGroupInputTypeType
    {
        Distribution,
        Security
    }

    public class O365RemoveDistributionGroupResponse
    {
        public bool O365RemoveDistributionGroupResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365RemoveDistributionGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BypassSecurityGroupManagerCheck { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ErrorIfGroupDoesNotExist { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365SetO365MailboxResponse
    {
        public bool O365SetO365MailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365SetO365MailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public bool? AccountDisabled { get; set; }
        public string Alias { get; set; }
        public string DisplayName { get; set; }
        public bool? HiddenFromAddressListsEnabled { get; set; }
        public string CustomAttribute1 { get; set; }
        public string CustomAttribute2 { get; set; }
        public string CustomAttribute3 { get; set; }
        public string CustomAttribute4 { get; set; }
        public O365SetO365MailboxInputTypeType? Type { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365SetO365MailboxInputTypeType
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

    public class O365WaitForO365MailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }
        public O365WaitForO365MailboxInputRecipientTypeDetailsType? RecipientTypeDetails { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfTimesToCheck { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsBetweenTries { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365WaitForO365MailboxInputRecipientTypeDetailsType
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

    public class O365SetO365MailboxAutoReplyConfigurationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public O365SetO365MailboxAutoReplyConfigurationInputAutoReplyStateType AutoReplyState { get; set; } = O365SetO365MailboxAutoReplyConfigurationInputAutoReplyStateType.EnabledAutomaticRepliesAreSent;
        public string InternalMessage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public O365SetO365MailboxAutoReplyConfigurationInputExternalAudienceType? ExternalAudience { get; set; } = O365SetO365MailboxAutoReplyConfigurationInputExternalAudienceType.AllRepliesAreSentToAllSenders;
        public string ExternalMessage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365SetO365MailboxAutoReplyConfigurationInputAutoReplyStateType
    {
        [EnumMember(Value = "Enabled")]
        EnabledAutomaticRepliesAreSent,
        [EnumMember(Value = "Disabled")]
        DisabledAutomaticRepliesAreNotSent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum O365SetO365MailboxAutoReplyConfigurationInputExternalAudienceType
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

    public class O365RemoveDistributionGroupMemberInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Member { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BypassSecurityGroupManagerCheck { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfMemberNotInGroup { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365GetMailboxDistributionGroupMembershipResponse
    {
        public string PowerShellJSONOutput { get; set; }
        public int CountOfDistributionGroupsFound { get; set; }
    }

    public class O365GetMailboxDistributionGroupMembershipInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailboxIdentity { get; set; }
        public string PropertiesToRetrieveJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365GetDistributionGroupMembersResponse
    {
        public string O365DistributionGroupMembersJSON { get; set; }
        public int O365CountOfDistributionGroupsMembers { get; set; }
    }

    public class O365GetDistributionGroupMembersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupIdentity { get; set; }
        public string PropertiesToRetrieveJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365RemoveMailboxFromAllDistributionGroupsResponse
    {
        public int O365GroupsRemovedSuccessfully { get; set; }
        public int O365GroupsFailedToRemove { get; set; }
        public int O365GroupsExcludedFromRemoval { get; set; }
        public string RemoveO365GroupsErrorMessage { get; set; }
        public int ThreadId { get; set; }
    }

    public class O365RemoveMailboxFromAllDistributionGroupsInput
    {
        public string MailboxIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BypassSecurityGroupManagerCheck { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAnyGroupsFailToRemove { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExceptionIfAllGroupsFailToRemove { get; set; } = true;
        public string GroupDNsToExcludeJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365NewMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }

        [JsonProperty("NewUserMicrosoftOnlineServicesID")]
        public string NewUserMicrosoftOnlineServicesId { get; set; }
        public string NewMailboxGUID { get; set; }
        public string NewMailboxPrimarySmtpAddress { get; set; }
    }

    public class O365NewMailboxInput
    {
        [JsonProperty("MicrosoftOnlineServicesID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MicrosoftOnlineServicesId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public string PrimarySmtpAddress { get; set; }
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AccountPasswordIsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetPasswordOnNextLogon { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Archive { get; set; } = false;
        public string MailboxPlan { get; set; }
        public string MailboxRegion { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365NewSharedMailboxResponse
    {
        public string PowerShellJSONOutput { get; set; }

        [JsonProperty("NewUserMicrosoftOnlineServicesID")]
        public string NewUserMicrosoftOnlineServicesId { get; set; }
        public string NewMailboxGUID { get; set; }
        public string NewMailboxPrimarySmtpAddress { get; set; }
    }

    public class O365NewSharedMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string DisplayName { get; set; }
        public string Alias { get; set; }
        public string PrimarySmtpAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Archive { get; set; } = false;
        public string MailboxRegion { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365EnableArchiveMailboxResponse
    {
        public bool O365EnableArchiveMailboxResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class O365EnableArchiveMailboxInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckIfArchiveExists { get; set; } = true;
        public string ArchiveName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoExpandingArchive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class O365DoesMailboxHaveAnArchiveResponse
    {
        public bool MailboxHasAnArchive { get; set; }
    }

    public class O365DoesMailboxHaveAnArchiveInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class JMLGetNextAvailableAccountNameInput
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FieldA { get; set; }
        public string FieldB { get; set; }
        public string FieldC { get; set; }
        public string FieldD { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VariableMStartValue { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VariableNStartValue { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VariableXStartValue { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxAttempts { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FallbackCausesRetest { get; set; } = true;
        public string NumbersNotToUse { get; set; }
        public string CharactersToRemoveFromInputs { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveDiacriticsFromInputs { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveNonAlphaNumericFromInputs { get; set; } = true;
        public string SequenceA1 { get; set; }
        public JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItem[] PropertiesToCheckList { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItemPropertyToCheckType? PropertyToCheck { get; set; } = JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItemPropertyToCheckType.ActiveDirectorySAMAccountName;
        public string PropertyNameFormat { get; set; }
        public string PropertyNameFallbackFormat { get; set; }
        public string PropertyNameFallbackFormat2 { get; set; }
        public int? PropertyNameMaxLength { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItemPropertyNameMaxLengthFieldToCutType? PropertyNameMaxLengthFieldToCut { get; set; } = JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItemPropertyNameMaxLengthFieldToCutType.LastName;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItemPropertyToCheckType
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
    public enum JMLGetNextAvailableAccountNameInputPropertiesToCheckListTypeItemPropertyNameMaxLengthFieldToCutType
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

    public class JMLConnectToJMLEnvironmentInput
    {
        public string FriendlyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyConnectIfNotAlreadyConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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