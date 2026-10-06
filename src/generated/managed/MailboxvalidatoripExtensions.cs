//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mailboxvalidatorip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MailboxvalidatoripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailboxvalidatorip")]
        [WorkflowExpressionFactory(nameof(__BuildValidateSingle))]
        public IBodyWorkflowAction<ValidateSingleResponse> ValidateSingle([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailboxvalidatorip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateSingleResponse> __BuildValidateSingle(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<ValidateSingleResponse>(() =>
            {
                var apiCallPath = "/validation/single";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                callPayload.Queries["format"] = Convert.ToString("json");
                return new ApiConnectionAction<ValidateSingleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailboxvalidatorip")]
        [WorkflowExpressionFactory(nameof(__BuildValidateDisposable))]
        public IBodyWorkflowAction<ValidateDisposableResponse> ValidateDisposable([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailboxvalidatorip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateDisposableResponse> __BuildValidateDisposable(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<ValidateDisposableResponse>(() =>
            {
                var apiCallPath = "/email/disposable";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                callPayload.Queries["format"] = Convert.ToString("json");
                return new ApiConnectionAction<ValidateDisposableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailboxvalidatorip")]
        [WorkflowExpressionFactory(nameof(__BuildValidateFree))]
        public IBodyWorkflowAction<ValidateFreeResponse> ValidateFree([WorkflowExpression] Func<string> email)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mailboxvalidatorip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ValidateFreeResponse> __BuildValidateFree(WorkflowExpression<string> email)
        {
            WorkflowExpression.Validate(email, nameof(email), required: true);
            return new DeferredBodyAction<ValidateFreeResponse>(() =>
            {
                var apiCallPath = "/email/free";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
                callPayload.Queries["format"] = Convert.ToString("json");
                return new ApiConnectionAction<ValidateFreeResponse>(callPayload);
            });
        }
    }

    public class MailboxvalidatoripTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidateSingleResponse
    {
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("is_free")]
        public string IsFree { get; set; }

        [JsonProperty("is_syntax")]
        public string IsSyntax { get; set; }

        [JsonProperty("is_domain")]
        public string IsDomain { get; set; }

        [JsonProperty("is_smtp")]
        public string IsSmtp { get; set; }

        [JsonProperty("is_verified")]
        public string IsVerified { get; set; }

        [JsonProperty("is_server_down")]
        public string IsServerDown { get; set; }

        [JsonProperty("is_greylisted")]
        public string IsGreylisted { get; set; }

        [JsonProperty("is_disposable")]
        public string IsDisposable { get; set; }

        [JsonProperty("is_suppressed")]
        public string IsSuppressed { get; set; }

        [JsonProperty("is_role")]
        public string IsRole { get; set; }

        [JsonProperty("is_high_risk")]
        public string IsHighRisk { get; set; }

        [JsonProperty("is_catchall")]
        public string IsCatchall { get; set; }

        [JsonProperty("mailboxvalidator_score")]
        public string MailboxvalidatorScore { get; set; }

        [JsonProperty("time_taken")]
        public string TimeTaken { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("credits_available")]
        public int CreditsAvailable { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }

    public class ValidateDisposableResponse
    {
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("is_disposable")]
        public string IsDisposable { get; set; }

        [JsonProperty("credits_available")]
        public int CreditsAvailable { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }

    public class ValidateFreeResponse
    {
        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("is_free")]
        public string IsFree { get; set; }

        [JsonProperty("credits_available")]
        public int CreditsAvailable { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mailboxvalidatorip;

    public partial class WorkflowManagedActions
    {
        public MailboxvalidatoripActions Mailboxvalidatorip(string connectionId) => new MailboxvalidatoripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MailboxvalidatoripTriggers Mailboxvalidatorip(string connectionId) => new MailboxvalidatoripTriggers(connectionId);
    }
}