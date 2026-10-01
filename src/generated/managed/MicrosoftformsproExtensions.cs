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
        public IBodyWorkflowAction<string> SendSurvey([WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> emailTemplateId, [WorkflowExpression] Func<string> regarding = null, [WorkflowExpression] Func<string> recipientInfo = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/sendmail/flow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                callPayload.Queries["FormId"] = SourceExpressionConverter.ConvertO(formId);
                callPayload.Queries["EmailTemplateId"] = SourceExpressionConverter.ConvertO(emailTemplateId);
                if (regarding != null)
                    callPayload.Queries["Regarding"] = SourceExpressionConverter.ConvertO(regarding);
                if (recipientInfo != null)
                    callPayload.Queries["RecipientInfo"] = SourceExpressionConverter.ConvertO(recipientInfo);
                if (firstName != null)
                    callPayload.Queries["firstName"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["lastName"] = SourceExpressionConverter.ConvertO(lastName);
                callPayload.Headers["ProjectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftformspro")]
        public IBodyWorkflowAction<CreateSurveyInviteResponse> CreateSurveyInvite([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> regarding = null, [WorkflowExpression] Func<string> recipientInfo = null, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/createinvite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FormId"] = SourceExpressionConverter.ConvertO(formId);
                if (email != null)
                    callPayload.Queries["Email"] = SourceExpressionConverter.ConvertO(email);
                if (subject != null)
                    callPayload.Queries["subject"] = SourceExpressionConverter.ConvertO(subject);
                if (firstName != null)
                    callPayload.Queries["firstName"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["lastName"] = SourceExpressionConverter.ConvertO(lastName);
                if (regarding != null)
                    callPayload.Queries["Regarding"] = SourceExpressionConverter.ConvertO(regarding);
                if (recipientInfo != null)
                    callPayload.Queries["RecipientInfo"] = SourceExpressionConverter.ConvertO(recipientInfo);
                callPayload.Headers["ProjectId"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<CreateSurveyInviteResponse>(BuildSourceInput);
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