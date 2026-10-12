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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSendSurvey(WorkflowExpression<string> to, WorkflowExpression<string> projectId, WorkflowExpression<string> formId, WorkflowExpression<string> emailTemplateId, WorkflowExpression<string> regarding = null, WorkflowExpression<string> recipientInfo = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(to, nameof(to), required: true);
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(emailTemplateId, nameof(emailTemplateId), required: true);
            WorkflowExpression.Validate(regarding, nameof(regarding), required: false);
            WorkflowExpression.Validate(recipientInfo, nameof(recipientInfo), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> __BuildCreateSurveyInvite(WorkflowExpression<string> projectId, WorkflowExpression<string> formId, WorkflowExpression<string> email = null, WorkflowExpression<string> subject = null, WorkflowExpression<string> firstName = null, WorkflowExpression<string> lastName = null, WorkflowExpression<string> regarding = null, WorkflowExpression<string> recipientInfo = null, WorkflowExpression<object> item = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(subject, nameof(subject), required: false);
            WorkflowExpression.Validate(firstName, nameof(firstName), required: false);
            WorkflowExpression.Validate(lastName, nameof(lastName), required: false);
            WorkflowExpression.Validate(regarding, nameof(regarding), required: false);
            WorkflowExpression.Validate(recipientInfo, nameof(recipientInfo), required: false);
            WorkflowExpression.Validate(item, nameof(item), required: false);
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