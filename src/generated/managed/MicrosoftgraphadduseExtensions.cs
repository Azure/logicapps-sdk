//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftgraphadduse
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftgraphadduseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<UserPostResponse, ApiConnectionActionConfiguration> User(Expression<Func<UserPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<InvitePostResponse, ApiConnectionActionConfiguration> Invite(Expression<Func<InvitePostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<InvitePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invitations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvitePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MembersPatch(Expression<Func<string>> groupId, Expression<Func<MembersPatchInput>> body = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class MicrosoftgraphadduseTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserPostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("identities")]
        public UserPostResponseIdentitiesTypeItem[] Identities { get; set; }

        [JsonProperty("passwordPolicies")]
        public string PasswordPolicies { get; set; }
    }

    public class UserPostResponseIdentitiesTypeItem
    {
        [JsonProperty("signInType")]
        public string SignInType { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerAssignedId")]
        public string IssuerAssignedId { get; set; }
    }

    public class UserPostInput
    {
        [JsonProperty("accountEnabled")]
        public bool? AccountEnabled { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("passwordProfile")]
        public UserPostInputPasswordProfileType PasswordProfile { get; set; }

        [JsonProperty("identities")]
        public UserPostInputIdentitiesTypeItem[] Identities { get; set; }

        [JsonProperty("onPremisesImmutableId")]
        public string OnPremisesImmutableId { get; set; }
    }

    public class UserPostInputPasswordProfileType
    {
        [JsonProperty("forceChangePasswordNextSignIn")]
        public bool? ForceChangePasswordNextSignIn { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class UserPostInputIdentitiesTypeItem
    {
        [JsonProperty("signInType")]
        public string SignInType { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerAssignedId")]
        public string IssuerAssignedId { get; set; }
    }

    public class InvitePostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inviteRedeemUrl")]
        public string InviteRedeemUrl { get; set; }

        [JsonProperty("invitedUserDisplayName")]
        public string InvitedUserDisplayName { get; set; }

        [JsonProperty("invitedUserType")]
        public string InvitedUserType { get; set; }

        [JsonProperty("invitedUserEmailAddress")]
        public string InvitedUserEmailAddress { get; set; }

        [JsonProperty("sendInvitationMessage")]
        public bool SendInvitationMessage { get; set; }

        [JsonProperty("resetRedemption")]
        public bool ResetRedemption { get; set; }

        [JsonProperty("inviteRedirectUrl")]
        public string InviteRedirectUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("invitedUserMessageInfo")]
        public InvitePostResponseInvitedUserMessageInfoType InvitedUserMessageInfo { get; set; }

        [JsonProperty("invitedUser")]
        public InvitePostResponseInvitedUserType InvitedUser { get; set; }
    }

    public class InvitePostResponseInvitedUserMessageInfoType
    {
        [JsonProperty("messageLanguage")]
        public string MessageLanguage { get; set; }

        [JsonProperty("customizedMessageBody")]
        public string CustomizedMessageBody { get; set; }

        [JsonProperty("ccRecipients")]
        public InvitePostResponseInvitedUserMessageInfoTypeCcRecipientsTypeItem[] CcRecipients { get; set; }
    }

    public class InvitePostResponseInvitedUserMessageInfoTypeCcRecipientsTypeItem
    {
        [JsonProperty("emailAddress")]
        public InvitePostResponseInvitedUserMessageInfoTypeCcRecipientsTypeItemEmailAddressType EmailAddress { get; set; }
    }

    public class InvitePostResponseInvitedUserMessageInfoTypeCcRecipientsTypeItemEmailAddressType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class InvitePostResponseInvitedUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class InvitePostInput
    {
        [JsonProperty("invitedUserEmailAddress")]
        public string InvitedUserEmailAddress { get; set; }

        [JsonProperty("inviteRedirectUrl")]
        public string InviteRedirectUrl { get; set; }
    }

    public class MembersPatchInput
    {
        [JsonProperty("members@odata.bind", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] MembersOdataBind { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftgraphadduse;

    public partial class WorkflowManagedActions
    {
        public MicrosoftgraphadduseActions Microsoftgraphadduse(string connectionId) => new MicrosoftgraphadduseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftgraphadduseTriggers Microsoftgraphadduse(string connectionId) => new MicrosoftgraphadduseTriggers(connectionId);
    }
}