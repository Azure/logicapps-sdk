//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftformspro
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftformsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        [WorkflowExpressionFactory(nameof(__BuildSendSurvey))]
        public IBodyWorkflowAction<string> SendSurvey([WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> emailTemplateId, [WorkflowExpression] Func<string> regarding = null, [WorkflowExpression] Func<string> recipientInfo = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSendSurvey(WorkflowValue<string> to, WorkflowValue<string> projectId, WorkflowValue<string> formId, WorkflowValue<string> emailTemplateId, WorkflowValue<string> regarding = null, WorkflowValue<string> recipientInfo = null, WorkflowValue<string> firstName = null, WorkflowValue<string> lastName = null, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(to, nameof(to), required: true);
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            WorkflowValue.Validate(emailTemplateId, nameof(emailTemplateId), required: true);
            WorkflowValue.Validate(regarding, nameof(regarding), required: false);
            WorkflowValue.Validate(recipientInfo, nameof(recipientInfo), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(lastName, nameof(lastName), required: false);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/sendmail/flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                callPayload.Queries["FormId"] = ExpressionConverter.Convert(formId);
                callPayload.Queries["EmailTemplateId"] = ExpressionConverter.Convert(emailTemplateId);
                if (regarding != null)
                    callPayload.Queries["Regarding"] = ExpressionConverter.Convert(regarding);
                if (recipientInfo != null)
                    callPayload.Queries["RecipientInfo"] = ExpressionConverter.Convert(recipientInfo);
                if (firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(lastName);
                callPayload.Headers["ProjectId"] = ExpressionConverter.Convert(projectId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSurveyInvite))]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> CreateSurveyInvite([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> regarding = null, [WorkflowExpression] Func<string> recipientInfo = null, [WorkflowExpression] Func<object> item = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> __BuildCreateSurveyInvite(WorkflowValue<string> projectId, WorkflowValue<string> formId, WorkflowValue<string> email = null, WorkflowValue<string> subject = null, WorkflowValue<string> firstName = null, WorkflowValue<string> lastName = null, WorkflowValue<string> regarding = null, WorkflowValue<string> recipientInfo = null, WorkflowValue<object> item = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(formId, nameof(formId), required: true);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(subject, nameof(subject), required: false);
            WorkflowValue.Validate(firstName, nameof(firstName), required: false);
            WorkflowValue.Validate(lastName, nameof(lastName), required: false);
            WorkflowValue.Validate(regarding, nameof(regarding), required: false);
            WorkflowValue.Validate(recipientInfo, nameof(recipientInfo), required: false);
            WorkflowValue.Validate(item, nameof(item), required: false);
            return new DeferredBodyAction<CreateSurveyInviteResponse>(() =>
            {
                var apiCallPath = "/api/createinvite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FormId"] = ExpressionConverter.Convert(formId);
                if (email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(email);
                if (subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
                if (firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(firstName);
                if (lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(lastName);
                if (regarding != null)
                    callPayload.Queries["Regarding"] = ExpressionConverter.Convert(regarding);
                if (recipientInfo != null)
                    callPayload.Queries["RecipientInfo"] = ExpressionConverter.Convert(recipientInfo);
                callPayload.Headers["ProjectId"] = ExpressionConverter.Convert(projectId);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<CreateSurveyInviteResponse>(callPayload);
            });
        }
    }

    public class MicrosoftformsproTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateSurveyInviteResponse
    {
        public string InvitationId { get; set; }
        public string Invitationlink { get; set; }
        public string Unsubscribelink { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftformspro;

    public partial class WorkflowManagedActions
    {
        public MicrosoftformsproActions Microsoftformspro(string connectionId) => new MicrosoftformsproActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MicrosoftformsproTriggers Microsoftformspro(string connectionId) => new MicrosoftformsproTriggers(connectionId);
    }
}
