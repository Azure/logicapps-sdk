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
            callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            callPayload.Queries["FormId"] = CSharpExpressionConverter.ConvertO(formId);
            callPayload.Queries["EmailTemplateId"] = CSharpExpressionConverter.ConvertO(emailTemplateId);
            if (regarding != null)
                callPayload.Queries["Regarding"] = CSharpExpressionConverter.ConvertO(regarding);
            if (recipientInfo != null)
                callPayload.Queries["RecipientInfo"] = CSharpExpressionConverter.ConvertO(recipientInfo);
            if (firstName != null)
                callPayload.Queries["firstName"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lastName != null)
                callPayload.Queries["lastName"] = CSharpExpressionConverter.ConvertO(lastName);
            callPayload.Headers["ProjectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> CreateSurveyInvite(Expression<Func<string>> projectId, Expression<Func<string>> formId, Expression<Func<string>> email = null, Expression<Func<string>> subject = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> regarding = null, Expression<Func<string>> recipientInfo = null, Expression<Func<object>> item = null)
        {
            var apiCallPath = "/api/createinvite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FormId"] = CSharpExpressionConverter.ConvertO(formId);
            if (email != null)
                callPayload.Queries["Email"] = CSharpExpressionConverter.ConvertO(email);
            if (subject != null)
                callPayload.Queries["subject"] = CSharpExpressionConverter.ConvertO(subject);
            if (firstName != null)
                callPayload.Queries["firstName"] = CSharpExpressionConverter.ConvertO(firstName);
            if (lastName != null)
                callPayload.Queries["lastName"] = CSharpExpressionConverter.ConvertO(lastName);
            if (regarding != null)
                callPayload.Queries["Regarding"] = CSharpExpressionConverter.ConvertO(regarding);
            if (recipientInfo != null)
                callPayload.Queries["RecipientInfo"] = CSharpExpressionConverter.ConvertO(recipientInfo);
            callPayload.Headers["ProjectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(item);
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