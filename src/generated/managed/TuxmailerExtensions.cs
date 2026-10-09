//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tuxmailer
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TuxmailerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tuxmailer")]
        [WorkflowExpressionFactory(nameof(__BuildValidateEmail))]
        public IBodyWorkflowAction<ValidateEmailResponse> ValidateEmail([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<string> teamName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateEmailResponse> __BuildValidateEmail(WorkflowExpression<string> email, WorkflowExpression<string> teamName = null)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            WorkflowExpression.Validate(teamName, nameof(teamName), required: false);
            return new DeferredBodyAction<ValidateEmailResponse>(() =>
            {
                var apiCallPath = "/common/v1/user/validate/email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                if (teamName != null)
                    callPayload.Queries["team_name"] = ExpressionConverter.Convert(teamName);
                return new ApiConnectionAction<ValidateEmailResponse>(callPayload);
            });
        }
    }

    public class TuxmailerTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateEmailResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("is_catchall_domain")]
        public bool IsCatchallDomain { get; set; }

        [JsonProperty("is_disposable")]
        public bool IsDisposable { get; set; }

        [JsonProperty("is_free_email_provider")]
        public bool IsFreeEmailProvider { get; set; }

        [JsonProperty("mail_server_used_for_validation")]
        public string MailServerUsedForValidation { get; set; }

        [JsonProperty("valid_address")]
        public bool ValidAddress { get; set; }

        [JsonProperty("valid_domain")]
        public bool ValidDomain { get; set; }

        [JsonProperty("valid_smtp")]
        public bool ValidSmtp { get; set; }

        [JsonProperty("valid_syntax")]
        public bool ValidSyntax { get; set; }

        [JsonProperty("is_role_based")]
        public bool IsRoleBased { get; set; }

        [JsonProperty("has_full_inbox")]
        public bool HasFullInbox { get; set; }

        [JsonProperty("is_disabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("blacklisted")]
        public bool Blacklisted { get; set; }

        [JsonProperty("billable")]
        public bool Billable { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tuxmailer;

    public partial class WorkflowManagedActions
    {
        public TuxmailerActions Tuxmailer(string connectionId) => new TuxmailerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TuxmailerTriggers Tuxmailer(string connectionId) => new TuxmailerTriggers(connectionId);
    }
}