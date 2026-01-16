//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftformspro
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MicrosoftformsproActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<string> SendSurvey(Expression<Func<string>> to, Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> emailTemplateId, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<object>> item = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> CreateSurveyInvite(Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> email = null, Expression<Func<string>> subject = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<object>> item = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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