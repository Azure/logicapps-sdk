//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendgrid
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendgridActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<AddGlobalSuppressRequestAndResponse, ApiConnectionActionConfiguration> AddGlobalSuppression(Expression<Func<AddGlobalSuppressionInput>> recipientEmails)
        {
            var __workflow_recipientEmails = WorkflowExpression.Compile(recipientEmails, nameof(recipientEmails), required: true);
            return new DeferredBodyAction<AddGlobalSuppressRequestAndResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/suppressions/global";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_recipientEmails);
                return new ApiConnectionAction<AddGlobalSuppressRequestAndResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteGlobalSuppression(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppressions/global/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> AddRecipientToList(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/contactdb/lists/{0}/recipients/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<Bounce[], ApiConnectionActionConfiguration> GetBounce(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<Bounce[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppression/bounces/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Bounce[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteBounce(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppression/bounces/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<EmailIsUnsubscribedResponse, ApiConnectionActionConfiguration> CheckEmailIsInUnsubscribesList(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<EmailIsUnsubscribedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/unsubscribes/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EmailIsUnsubscribedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendEmail(Expression<Func<SendEmailV4Input>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v4/mail/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SendgridTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddGlobalSuppressRequestAndResponse
    {
        [JsonProperty("recipient_emails")]
        public string[] RecipientEmail { get; set; }
    }

    public class AddGlobalSuppressionInput
    {
        [JsonProperty("recipient_emails")]
        public string[] RecipientEmail { get; set; }
    }

    public class Bounce
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class EmailIsUnsubscribedResponse
    {
        [JsonProperty("isUnsubscribed")]
        public bool IsEmailUnsubscribed { get; set; }
    }

    public class SendEmailV4Input
    {
        [JsonProperty("attachments")]
        public EmailAttachment[] Attachment { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("fromname")]
        public string FromName { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("toname")]
        public string ToNames { get; set; }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EmailBody { get; set; }

        [JsonProperty("ishtml", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool IsHtml { get; set; } = true;

        [JsonProperty("cc")]
        public string CC { get; set; }

        [JsonProperty("ccname")]
        public string CCNames { get; set; }

        [JsonProperty("bcc")]
        public string Bcc { get; set; }

        [JsonProperty("bccname")]
        public string BCCNames { get; set; }
    }

    public class EmailAttachment
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("filename")]
        public string Name { get; set; }

        [JsonProperty("contenttype")]
        public string ContentType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sendgrid;

    public partial class WorkflowManagedActions
    {
        public SendgridActions Sendgrid(string connectionId) => new SendgridActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SendgridTriggers Sendgrid(string connectionId) => new SendgridTriggers(connectionId);
    }
}