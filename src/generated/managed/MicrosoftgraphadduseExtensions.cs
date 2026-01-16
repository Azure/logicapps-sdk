//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftgraphadduse
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftgraphadduseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<UserPostResponse> UserPost(Expression<Func<bool>> bodyaccountEnabled = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodymailNickname = null, Expression<Func<string>> bodyuserPrincipalName = null, Expression<Func<bool>> bodypasswordProfileforceChangePasswordNextSignIn = null, Expression<Func<string>> bodypasswordProfilepassword = null, Expression<Func<bodyidentitiesInputItem[]>> bodyidentities = null, Expression<Func<string>> bodyonPremisesImmutableId = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccountEnabled != null)
            {
                body["accountEnabled"] = ExpressionConverter.ConvertO(bodyaccountEnabled);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodymailNickname != null)
            {
                body["mailNickname"] = ExpressionConverter.ConvertO(bodymailNickname);
                bodypropCount++;
            }

            if (bodyuserPrincipalName != null)
            {
                body["userPrincipalName"] = ExpressionConverter.ConvertO(bodyuserPrincipalName);
                bodypropCount++;
            }

            var passwordProfileObject = new JObject();
            var passwordProfileObjectpropCount = 0;
            if (bodypasswordProfileforceChangePasswordNextSignIn != null)
            {
                passwordProfileObject["forceChangePasswordNextSignIn"] = ExpressionConverter.ConvertO(bodypasswordProfileforceChangePasswordNextSignIn);
                passwordProfileObjectpropCount++;
            }

            if (bodypasswordProfilepassword != null)
            {
                passwordProfileObject["password"] = ExpressionConverter.ConvertO(bodypasswordProfilepassword);
                passwordProfileObjectpropCount++;
            }

            if (passwordProfileObjectpropCount > 0)
            {
                body["passwordProfile"] = passwordProfileObject;
                bodypropCount++;
            }

            if (bodyidentities != null)
            {
                body["identities"] = ExpressionConverter.ConvertO(bodyidentities);
                bodypropCount++;
            }

            if (bodyonPremisesImmutableId != null)
            {
                body["onPremisesImmutableId"] = ExpressionConverter.ConvertO(bodyonPremisesImmutableId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<InvitePostResponse> InvitePost(Expression<Func<string>> bodyinvitedUserEmailAddress = null, Expression<Func<string>> bodyinviteRedirectUrl = null)
        {
            var apiCallPath = "/invitations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinvitedUserEmailAddress != null)
            {
                body["invitedUserEmailAddress"] = ExpressionConverter.ConvertO(bodyinvitedUserEmailAddress);
                bodypropCount++;
            }

            if (bodyinviteRedirectUrl != null)
            {
                body["inviteRedirectUrl"] = ExpressionConverter.ConvertO(bodyinviteRedirectUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InvitePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<string> MembersPatch(Expression<Func<string>> groupId, Expression<Func<string[]>> bodymembersOdataBind)
        {
            var apiCallPath = String.Format("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["members@odata.bind"] = ExpressionConverter.ConvertO(bodymembersOdataBind);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
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

    public class bodyidentitiesInputItem
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
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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