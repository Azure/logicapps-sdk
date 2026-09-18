//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abstractemailvalidat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbstractemailvalidatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abstractemailvalidat")]
        public IBodyWorkflowAction<ValidationResponse> Validation([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                return callPayload;
            }

            return new ApiConnectionAction<ValidationResponse>(BuildSourceInput);
        }
    }

    public class AbstractemailvalidatTriggers([ConnectionName] string connectionId)
    {
    }

    public class ValidationResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("autocorrect")]
        public string Autocorrect { get; set; }

        [JsonProperty("deliverability")]
        public string Deliverability { get; set; }

        [JsonProperty("quality_score")]
        public string QualityScore { get; set; }

        [JsonProperty("is_valid_format")]
        public ValidationResponseIsValidFormatType IsValidFormat { get; set; }

        [JsonProperty("is_free_email")]
        public ValidationResponseIsFreeEmailType IsFreeEmail { get; set; }

        [JsonProperty("is_disposable_email")]
        public ValidationResponseIsDisposableEmailType IsDisposableEmail { get; set; }

        [JsonProperty("is_role_email")]
        public ValidationResponseIsRoleEmailType IsRoleEmail { get; set; }

        [JsonProperty("is_catchall_email")]
        public ValidationResponseIsCatchallEmailType IsCatchallEmail { get; set; }

        [JsonProperty("is_mx_found")]
        public ValidationResponseIsMxFoundType IsMxFound { get; set; }

        [JsonProperty("is_smtp_valid")]
        public ValidationResponseIsSmtpValidType IsSmtpValid { get; set; }
    }

    public class ValidationResponseIsValidFormatType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ValidationResponseIsFreeEmailType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ValidationResponseIsDisposableEmailType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ValidationResponseIsRoleEmailType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ValidationResponseIsCatchallEmailType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ValidationResponseIsMxFoundType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ValidationResponseIsSmtpValidType
    {
        [JsonProperty("value")]
        public bool Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abstractemailvalidat;

    public partial class WorkflowManagedActions
    {
        public AbstractemailvalidatActions Abstractemailvalidat(string connectionId) => new AbstractemailvalidatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbstractemailvalidatTriggers Abstractemailvalidat(string connectionId) => new AbstractemailvalidatTriggers(connectionId);
    }
}