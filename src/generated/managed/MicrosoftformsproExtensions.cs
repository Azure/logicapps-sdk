//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftformspro
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MicrosoftformsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<string> SendSurvey(Expression<Func<string>> to, Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> emailTemplateId, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<object>> item = null)
        {
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: true);
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_emailTemplateId = emailTemplateId == null ? null : WorkflowExpression.Compile(emailTemplateId);
            WorkflowExpression.Validate(__workflow_emailTemplateId, nameof(emailTemplateId), required: true);
            var __workflow_regarding = regarding == null ? null : WorkflowExpression.Compile(regarding);
            WorkflowExpression.Validate(__workflow_regarding, nameof(regarding), required: false);
            var __workflow_recipientInfo = recipientInfo == null ? null : WorkflowExpression.Compile(recipientInfo);
            WorkflowExpression.Validate(__workflow_recipientInfo, nameof(recipientInfo), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: false);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> CreateSurveyInvite(Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> email = null, Expression<Func<string>> subject = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<object>> item = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_subject = subject == null ? null : WorkflowExpression.Compile(subject);
            WorkflowExpression.Validate(__workflow_subject, nameof(subject), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: false);
            var __workflow_regarding = regarding == null ? null : WorkflowExpression.Compile(regarding);
            WorkflowExpression.Validate(__workflow_regarding, nameof(regarding), required: false);
            var __workflow_recipientInfo = recipientInfo == null ? null : WorkflowExpression.Compile(recipientInfo);
            WorkflowExpression.Validate(__workflow_recipientInfo, nameof(recipientInfo), required: false);
            var __workflow_item = item == null ? null : WorkflowExpression.Compile(item);
            WorkflowExpression.Validate(__workflow_item, nameof(item), required: false);
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
