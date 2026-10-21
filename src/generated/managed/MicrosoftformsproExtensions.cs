//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftformspro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftformsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<string> SendSurvey(Expression<Func<string>> to, Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> emailTemplateId, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<object>> item = null)
        {
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_emailTemplateId = WorkflowExpression.Compile(emailTemplateId, nameof(emailTemplateId), required: true);
            var __workflow_regarding = WorkflowExpression.Compile(regarding, nameof(regarding), required: false);
            var __workflow_recipientInfo = WorkflowExpression.Compile(recipientInfo, nameof(recipientInfo), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/sendmail/flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["FormId"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Queries["EmailTemplateId"] = ExpressionConverter.Convert(__workflow_emailTemplateId);
                if (__workflow_regarding != null)
                    callPayload.Queries["Regarding"] = ExpressionConverter.Convert(__workflow_regarding);
                if (__workflow_recipientInfo != null)
                    callPayload.Queries["RecipientInfo"] = ExpressionConverter.Convert(__workflow_recipientInfo);
                if (__workflow_firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(__workflow_lastName);
                callPayload.Headers["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> CreateSurveyInvite(Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> email = null, Expression<Func<string>> subject = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<object>> item = null)
        {
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_regarding = WorkflowExpression.Compile(regarding, nameof(regarding), required: false);
            var __workflow_recipientInfo = WorkflowExpression.Compile(recipientInfo, nameof(recipientInfo), required: false);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<CreateSurveyInviteResponse>(() =>
            {
                var apiCallPath = "/api/createinvite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FormId"] = ExpressionConverter.Convert(__workflow_formId);
                if (__workflow_email != null)
                    callPayload.Queries["Email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_firstName != null)
                    callPayload.Queries["firstName"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["lastName"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_regarding != null)
                    callPayload.Queries["Regarding"] = ExpressionConverter.Convert(__workflow_regarding);
                if (__workflow_recipientInfo != null)
                    callPayload.Queries["RecipientInfo"] = ExpressionConverter.Convert(__workflow_recipientInfo);
                callPayload.Headers["ProjectId"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<CreateSurveyInviteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
