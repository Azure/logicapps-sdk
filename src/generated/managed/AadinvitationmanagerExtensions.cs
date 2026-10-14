//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AadinvitationmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aadinvitationmanager")]
        public IBodyWorkflowAction<CreateInvitationResponse> CreateInvitation(Expression<Func<string>> bodyinvitedUserDisplayName = null, Expression<Func<string>> bodyinvitedUserEmailAddress = null, Expression<Func<bodyinvitedUserMessageInfoccRecipientsInputItem[]>> bodyinvitedUserMessageInfoccRecipients = null, Expression<Func<string>> bodyinvitedUserMessageInfocustomizedMessageBody = null, Expression<Func<string>> bodyinvitedUserMessageInfomessageLanguage = null, Expression<Func<string>> bodyinvitedUserType = null, Expression<Func<string>> bodyinviteRedirectUrl = null, Expression<Func<bool>> bodyresetRedemption = null, Expression<Func<bool>> bodysendInvitationMessage = null)
        {
            var __workflow_bodyinvitedUserDisplayName = bodyinvitedUserDisplayName == null ? null : WorkflowExpression.Compile(bodyinvitedUserDisplayName);
            WorkflowExpression.Validate(__workflow_bodyinvitedUserDisplayName, nameof(bodyinvitedUserDisplayName), required: false);
            var __workflow_bodyinvitedUserEmailAddress = bodyinvitedUserEmailAddress == null ? null : WorkflowExpression.Compile(bodyinvitedUserEmailAddress);
            WorkflowExpression.Validate(__workflow_bodyinvitedUserEmailAddress, nameof(bodyinvitedUserEmailAddress), required: false);
            var __workflow_bodyinvitedUserMessageInfoccRecipients = bodyinvitedUserMessageInfoccRecipients == null ? null : WorkflowExpression.Compile(bodyinvitedUserMessageInfoccRecipients);
            WorkflowExpression.Validate(__workflow_bodyinvitedUserMessageInfoccRecipients, nameof(bodyinvitedUserMessageInfoccRecipients), required: false);
            var __workflow_bodyinvitedUserMessageInfocustomizedMessageBody = bodyinvitedUserMessageInfocustomizedMessageBody == null ? null : WorkflowExpression.Compile(bodyinvitedUserMessageInfocustomizedMessageBody);
            WorkflowExpression.Validate(__workflow_bodyinvitedUserMessageInfocustomizedMessageBody, nameof(bodyinvitedUserMessageInfocustomizedMessageBody), required: false);
            var __workflow_bodyinvitedUserMessageInfomessageLanguage = bodyinvitedUserMessageInfomessageLanguage == null ? null : WorkflowExpression.Compile(bodyinvitedUserMessageInfomessageLanguage);
            WorkflowExpression.Validate(__workflow_bodyinvitedUserMessageInfomessageLanguage, nameof(bodyinvitedUserMessageInfomessageLanguage), required: false);
            var __workflow_bodyinvitedUserType = bodyinvitedUserType == null ? null : WorkflowExpression.Compile(bodyinvitedUserType);
            WorkflowExpression.Validate(__workflow_bodyinvitedUserType, nameof(bodyinvitedUserType), required: false);
            var __workflow_bodyinviteRedirectUrl = bodyinviteRedirectUrl == null ? null : WorkflowExpression.Compile(bodyinviteRedirectUrl);
            WorkflowExpression.Validate(__workflow_bodyinviteRedirectUrl, nameof(bodyinviteRedirectUrl), required: false);
            var __workflow_bodyresetRedemption = bodyresetRedemption == null ? null : WorkflowExpression.Compile(bodyresetRedemption);
            WorkflowExpression.Validate(__workflow_bodyresetRedemption, nameof(bodyresetRedemption), required: false);
            var __workflow_bodysendInvitationMessage = bodysendInvitationMessage == null ? null : WorkflowExpression.Compile(bodysendInvitationMessage);
            WorkflowExpression.Validate(__workflow_bodysendInvitationMessage, nameof(bodysendInvitationMessage), required: false);
            return new DeferredBodyAction<CreateInvitationResponse>(() =>
            {
                var apiCallPath = "/v1.0/invitations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinvitedUserDisplayName != null)
                {
                    body["invitedUserDisplayName"] = ExpressionConverter.ConvertO(__workflow_bodyinvitedUserDisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitedUserEmailAddress != null)
                {
                    body["invitedUserEmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyinvitedUserEmailAddress);
                    bodypropCount++;
                }

                var invitedUserMessageInfoObject = new JObject();
                var invitedUserMessageInfoObjectpropCount = 0;
                if (__workflow_bodyinvitedUserMessageInfoccRecipients != null)
                {
                    invitedUserMessageInfoObject["ccRecipients"] = ExpressionConverter.ConvertO(__workflow_bodyinvitedUserMessageInfoccRecipients);
                    invitedUserMessageInfoObjectpropCount++;
                }

                if (__workflow_bodyinvitedUserMessageInfocustomizedMessageBody != null)
                {
                    invitedUserMessageInfoObject["customizedMessageBody"] = ExpressionConverter.ConvertO(__workflow_bodyinvitedUserMessageInfocustomizedMessageBody);
                    invitedUserMessageInfoObjectpropCount++;
                }

                if (__workflow_bodyinvitedUserMessageInfomessageLanguage != null)
                {
                    invitedUserMessageInfoObject["messageLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyinvitedUserMessageInfomessageLanguage);
                    invitedUserMessageInfoObjectpropCount++;
                }

                if (invitedUserMessageInfoObjectpropCount > 0)
                {
                    body["invitedUserMessageInfo"] = invitedUserMessageInfoObject;
                    bodypropCount++;
                }

                if (__workflow_bodyinvitedUserType != null)
                {
                    body["invitedUserType"] = ExpressionConverter.ConvertO(__workflow_bodyinvitedUserType);
                    bodypropCount++;
                }

                if (__workflow_bodyinviteRedirectUrl != null)
                {
                    body["inviteRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodyinviteRedirectUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyresetRedemption != null)
                {
                    body["resetRedemption"] = ExpressionConverter.ConvertO(__workflow_bodyresetRedemption);
                    bodypropCount++;
                }

                if (__workflow_bodysendInvitationMessage != null)
                {
                    body["sendInvitationMessage"] = ExpressionConverter.ConvertO(__workflow_bodysendInvitationMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateInvitationResponse>(callPayload);
            });
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
