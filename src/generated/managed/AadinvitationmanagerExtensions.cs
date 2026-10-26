//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AadinvitationmanagerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aadinvitationmanager")]
        public IBodyWorkflowAction<CreateInvitationResponse, ApiConnectionActionConfiguration> CreateInvitation(Expression<Func<CreateInvitationInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateInvitationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/invitations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class CreateInvitationInput
    {
        [JsonProperty("invitedUserDisplayName")]
        public string InvitedUserDisplayName { get; set; }

        [JsonProperty("invitedUserEmailAddress")]
        public string InvitedUserEmailAddress { get; set; }

        [JsonProperty("invitedUserMessageInfo")]
        public InvitedUserMessageInfo InvitedUserMessageInfo { get; set; }

        [JsonProperty("invitedUserType")]
        public string InvitedUserType { get; set; }

        [JsonProperty("inviteRedirectUrl")]
        public string InviteRedirectUrl { get; set; }

        [JsonProperty("resetRedemption")]
        public bool? ResetRedemption { get; set; }

        [JsonProperty("sendInvitationMessage")]
        public bool? SendInvitationMessage { get; set; }
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