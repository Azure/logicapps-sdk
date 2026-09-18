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
        public IBodyWorkflowAction<UserPostResponse> User([WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null, [WorkflowExpression] Func<bodyidentitiesInputItem[]> bodyidentities = null, [WorkflowExpression] Func<string> bodyonPremisesImmutableId = null)
        {
            SourceExpression.Validate(bodyaccountEnabled, nameof(bodyaccountEnabled), required: false);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            SourceExpression.Validate(bodymailNickname, nameof(bodymailNickname), required: false);
            SourceExpression.Validate(bodyuserPrincipalName, nameof(bodyuserPrincipalName), required: false);
            SourceExpression.Validate(bodypasswordProfileforceChangePasswordNextSignIn, nameof(bodypasswordProfileforceChangePasswordNextSignIn), required: false);
            SourceExpression.Validate(bodypasswordProfilepassword, nameof(bodypasswordProfilepassword), required: false);
            SourceExpression.Validate(bodyidentities, nameof(bodyidentities), required: false);
            SourceExpression.Validate(bodyonPremisesImmutableId, nameof(bodyonPremisesImmutableId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = SourceExpressionConverter.ConvertToken(bodyaccountEnabled);
                    bodypropCount++;
                }

                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodymailNickname != null)
                {
                    body["mailNickname"] = SourceExpressionConverter.ConvertToken(bodymailNickname);
                    bodypropCount++;
                }

                if (bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = SourceExpressionConverter.ConvertToken(bodyuserPrincipalName);
                    bodypropCount++;
                }

                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = SourceExpressionConverter.ConvertToken(bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = SourceExpressionConverter.ConvertToken(bodypasswordProfilepassword);
                    passwordProfileObjectpropCount++;
                }

                if (passwordProfileObjectpropCount > 0)
                {
                    body["passwordProfile"] = passwordProfileObject;
                    bodypropCount++;
                }

                if (bodyidentities != null)
                {
                    body["identities"] = SourceExpressionConverter.ConvertToken(bodyidentities);
                    bodypropCount++;
                }

                if (bodyonPremisesImmutableId != null)
                {
                    body["onPremisesImmutableId"] = SourceExpressionConverter.ConvertToken(bodyonPremisesImmutableId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<InvitePostResponse> Invite([WorkflowExpression] Func<string> bodyinvitedUserEmailAddress = null, [WorkflowExpression] Func<string> bodyinviteRedirectUrl = null)
        {
            SourceExpression.Validate(bodyinvitedUserEmailAddress, nameof(bodyinvitedUserEmailAddress), required: false);
            SourceExpression.Validate(bodyinviteRedirectUrl, nameof(bodyinviteRedirectUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invitations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinvitedUserEmailAddress != null)
                {
                    body["invitedUserEmailAddress"] = SourceExpressionConverter.ConvertToken(bodyinvitedUserEmailAddress);
                    bodypropCount++;
                }

                if (bodyinviteRedirectUrl != null)
                {
                    body["inviteRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodyinviteRedirectUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvitePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftgraphadduse")]
        public IBodyWorkflowAction<string> MembersPatch([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string[]> bodymembersOdataBind)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(bodymembersOdataBind, nameof(bodymembersOdataBind), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["members@odata.bind"] = SourceExpressionConverter.ConvertToken(bodymembersOdataBind);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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