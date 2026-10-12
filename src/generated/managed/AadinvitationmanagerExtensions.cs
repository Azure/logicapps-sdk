//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AadinvitationmanagerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aadinvitationmanager")]
        [WorkflowExpressionFactory(nameof(__BuildCreateInvitation))]
        public IBodyWorkflowAction<CreateInvitationResponse> CreateInvitation([WorkflowExpression] Func<string> bodyinvitedUserDisplayName = null, [WorkflowExpression] Func<string> bodyinvitedUserEmailAddress = null, [WorkflowExpression] Func<bodyinvitedUserMessageInfoccRecipientsInputItem[]> bodyinvitedUserMessageInfoccRecipients = null, [WorkflowExpression] Func<string> bodyinvitedUserMessageInfocustomizedMessageBody = null, [WorkflowExpression] Func<string> bodyinvitedUserMessageInfomessageLanguage = null, [WorkflowExpression] Func<string> bodyinvitedUserType = null, [WorkflowExpression] Func<string> bodyinviteRedirectUrl = null, [WorkflowExpression] Func<bool> bodyresetRedemption = null, [WorkflowExpression] Func<bool> bodysendInvitationMessage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateInvitationResponse> __BuildCreateInvitation(WorkflowExpression<string> bodyinvitedUserDisplayName = null, WorkflowExpression<string> bodyinvitedUserEmailAddress = null, WorkflowExpression<bodyinvitedUserMessageInfoccRecipientsInputItem[]> bodyinvitedUserMessageInfoccRecipients = null, WorkflowExpression<string> bodyinvitedUserMessageInfocustomizedMessageBody = null, WorkflowExpression<string> bodyinvitedUserMessageInfomessageLanguage = null, WorkflowExpression<string> bodyinvitedUserType = null, WorkflowExpression<string> bodyinviteRedirectUrl = null, WorkflowExpression<bool> bodyresetRedemption = null, WorkflowExpression<bool> bodysendInvitationMessage = null)
        {
            WorkflowExpression.Validate(bodyinvitedUserDisplayName, nameof(bodyinvitedUserDisplayName), required: false);
            WorkflowExpression.Validate(bodyinvitedUserEmailAddress, nameof(bodyinvitedUserEmailAddress), required: false);
            WorkflowExpression.Validate(bodyinvitedUserMessageInfoccRecipients, nameof(bodyinvitedUserMessageInfoccRecipients), required: false);
            WorkflowExpression.Validate(bodyinvitedUserMessageInfocustomizedMessageBody, nameof(bodyinvitedUserMessageInfocustomizedMessageBody), required: false);
            WorkflowExpression.Validate(bodyinvitedUserMessageInfomessageLanguage, nameof(bodyinvitedUserMessageInfomessageLanguage), required: false);
            WorkflowExpression.Validate(bodyinvitedUserType, nameof(bodyinvitedUserType), required: false);
            WorkflowExpression.Validate(bodyinviteRedirectUrl, nameof(bodyinviteRedirectUrl), required: false);
            WorkflowExpression.Validate(bodyresetRedemption, nameof(bodyresetRedemption), required: false);
            WorkflowExpression.Validate(bodysendInvitationMessage, nameof(bodysendInvitationMessage), required: false);
            return new DeferredBodyAction<CreateInvitationResponse>(() =>
            {
                var apiCallPath = "/v1.0/invitations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinvitedUserDisplayName != null)
                {
                    body["invitedUserDisplayName"] = ExpressionConverter.ConvertO(bodyinvitedUserDisplayName);
                    bodypropCount++;
                }

                if (bodyinvitedUserEmailAddress != null)
                {
                    body["invitedUserEmailAddress"] = ExpressionConverter.ConvertO(bodyinvitedUserEmailAddress);
                    bodypropCount++;
                }

                var invitedUserMessageInfoObject = new JObject();
                var invitedUserMessageInfoObjectpropCount = 0;
                if (bodyinvitedUserMessageInfoccRecipients != null)
                {
                    invitedUserMessageInfoObject["ccRecipients"] = ExpressionConverter.ConvertO(bodyinvitedUserMessageInfoccRecipients);
                    invitedUserMessageInfoObjectpropCount++;
                }

                if (bodyinvitedUserMessageInfocustomizedMessageBody != null)
                {
                    invitedUserMessageInfoObject["customizedMessageBody"] = ExpressionConverter.ConvertO(bodyinvitedUserMessageInfocustomizedMessageBody);
                    invitedUserMessageInfoObjectpropCount++;
                }

                if (bodyinvitedUserMessageInfomessageLanguage != null)
                {
                    invitedUserMessageInfoObject["messageLanguage"] = ExpressionConverter.ConvertO(bodyinvitedUserMessageInfomessageLanguage);
                    invitedUserMessageInfoObjectpropCount++;
                }

                if (invitedUserMessageInfoObjectpropCount > 0)
                {
                    body["invitedUserMessageInfo"] = invitedUserMessageInfoObject;
                    bodypropCount++;
                }

                if (bodyinvitedUserType != null)
                {
                    body["invitedUserType"] = ExpressionConverter.ConvertO(bodyinvitedUserType);
                    bodypropCount++;
                }

                if (bodyinviteRedirectUrl != null)
                {
                    body["inviteRedirectUrl"] = ExpressionConverter.ConvertO(bodyinviteRedirectUrl);
                    bodypropCount++;
                }

                if (bodyresetRedemption != null)
                {
                    body["resetRedemption"] = ExpressionConverter.ConvertO(bodyresetRedemption);
                    bodypropCount++;
                }

                if (bodysendInvitationMessage != null)
                {
                    body["sendInvitationMessage"] = ExpressionConverter.ConvertO(bodysendInvitationMessage);
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