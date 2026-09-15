//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AadinvitationmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aadinvitationmanager")]
        public IBodyWorkflowAction<CreateInvitationResponse> CreateInvitation(Expression<Func<string>> bodyinvitedUserDisplayName = null, Expression<Func<string>> bodyinvitedUserEmailAddress = null, Expression<Func<bodyinvitedUserMessageInfoccRecipientsInputItem[]>> bodyinvitedUserMessageInfoccRecipients = null, Expression<Func<string>> bodyinvitedUserMessageInfocustomizedMessageBody = null, Expression<Func<string>> bodyinvitedUserMessageInfomessageLanguage = null, Expression<Func<string>> bodyinvitedUserType = null, Expression<Func<string>> bodyinviteRedirectUrl = null, Expression<Func<bool>> bodyresetRedemption = null, Expression<Func<bool>> bodysendInvitationMessage = null)
        {
            var apiCallPath = "/v1.0/invitations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinvitedUserDisplayName != null)
            {
                body["invitedUserDisplayName"] = CSharpExpressionConverter.ConvertToken(bodyinvitedUserDisplayName);
                bodypropCount++;
            }

            if (bodyinvitedUserEmailAddress != null)
            {
                body["invitedUserEmailAddress"] = CSharpExpressionConverter.ConvertToken(bodyinvitedUserEmailAddress);
                bodypropCount++;
            }

            var invitedUserMessageInfoObject = new JObject();
            var invitedUserMessageInfoObjectpropCount = 0;
            if (bodyinvitedUserMessageInfoccRecipients != null)
            {
                invitedUserMessageInfoObject["ccRecipients"] = CSharpExpressionConverter.ConvertToken(bodyinvitedUserMessageInfoccRecipients);
                invitedUserMessageInfoObjectpropCount++;
            }

            if (bodyinvitedUserMessageInfocustomizedMessageBody != null)
            {
                invitedUserMessageInfoObject["customizedMessageBody"] = CSharpExpressionConverter.ConvertToken(bodyinvitedUserMessageInfocustomizedMessageBody);
                invitedUserMessageInfoObjectpropCount++;
            }

            invitedUserMessageInfoObject["messageLanguage"] = "en-US";
            invitedUserMessageInfoObjectpropCount++;
            if (bodyinvitedUserMessageInfomessageLanguage != null)
            {
                invitedUserMessageInfoObject["messageLanguage"] = CSharpExpressionConverter.ConvertToken(bodyinvitedUserMessageInfomessageLanguage);
            }

            body["invitedUserMessageInfo"] = invitedUserMessageInfoObject;
            bodypropCount++;

            if (bodyinvitedUserType != null)
            {
                body["invitedUserType"] = CSharpExpressionConverter.ConvertToken(bodyinvitedUserType);
                bodypropCount++;
            }

            if (bodyinviteRedirectUrl != null)
            {
                body["inviteRedirectUrl"] = CSharpExpressionConverter.ConvertToken(bodyinviteRedirectUrl);
                bodypropCount++;
            }

            if (bodyresetRedemption != null)
            {
                body["resetRedemption"] = CSharpExpressionConverter.ConvertToken(bodyresetRedemption);
                bodypropCount++;
            }

            if (bodysendInvitationMessage != null)
            {
                body["sendInvitationMessage"] = CSharpExpressionConverter.ConvertToken(bodysendInvitationMessage);
                bodypropCount++;
            }

            callPayload.Body = body;

            return new ApiConnectionAction<CreateInvitationResponse>(callPayload);
        }
    }

    public class AadinvitationmanagerTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateInvitationResponse
    {
        [JsonProperty("inviteRedeemUrl")]
        public string InviteRedeemUrl { get; set; }

        [JsonProperty("invitedUserDisplayName")]
        public string InvitedUserDisplayName { get; set; }

        [JsonProperty("invitedUserEmailAddress")]
        public string InvitedUserEmailAddress { get; set; }

        [JsonProperty("sendInvitationMessage")]
        public bool SendInvitationMessage { get; set; }

        [JsonProperty("invitedUserMessageInfo")]
        public InvitedUserMessageInfo InvitedUserMessageInfo { get; set; }

        [JsonProperty("inviteRedirectUrl")]
        public string InviteRedirectUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("invitedUser")]
        public InvitedUser InvitedUser { get; set; }
    }

    public class InvitedUserMessageInfo
    {
        [JsonProperty("ccRecipients")]
        public CcRecipientsItem[] CcRecipients { get; set; }

        [JsonProperty("customizedMessageBody")]
        public string CustomizedMessageBody { get; set; }

        [JsonProperty("messageLanguage")]
        public string MessageLanguage { get; set; }
    }

    public class CcRecipientsItem
    {
        [JsonProperty("emailAddress")]
        public EmailAddress EmailAddress { get; set; }
    }

    public class EmailAddress
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InvitedUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyinvitedUserMessageInfoccRecipientsInputItem
    {
        [JsonProperty("emailAddress")]
        public EmailAddress EmailAddress { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager;

    public partial class WorkflowManagedActions
    {
        public AadinvitationmanagerActions Aadinvitationmanager(string connectionId) => new AadinvitationmanagerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AadinvitationmanagerTriggers Aadinvitationmanager(string connectionId) => new AadinvitationmanagerTriggers(connectionId);
    }
}