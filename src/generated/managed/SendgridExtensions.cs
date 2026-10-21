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
        public IBodyWorkflowAction<AddGlobalSuppressRequestAndResponse> AddGlobalSuppression(Expression<Func<string[]>> recipientEmailsrecipientEmail = null)
        {
            var __workflow_recipientEmailsrecipientEmail = WorkflowExpression.Compile(recipientEmailsrecipientEmail, nameof(recipientEmailsrecipientEmail), required: false);
            return new DeferredBodyAction<AddGlobalSuppressRequestAndResponse>(() =>
            {
                var apiCallPath = "/suppressions/global";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var recipientEmails = new JObject();
                var recipientEmailspropCount = 0;
                if (__workflow_recipientEmailsrecipientEmail != null)
                {
                    recipientEmails["recipient_emails"] = ExpressionConverter.ConvertO(__workflow_recipientEmailsrecipientEmail);
                    recipientEmailspropCount++;
                }

                if (recipientEmailspropCount > 0)
                {
                    callPayload.Body = recipientEmails;
                }

                return new ApiConnectionAction<AddGlobalSuppressRequestAndResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteGlobalSuppression(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppressions/global/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> AddRecipientToList(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v3/contactdb/lists/{0}/recipients/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<Bounce[]> GetBounce(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<Bounce[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppression/bounces/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Bounce[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteBounce(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/suppression/bounces/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<EmailIsUnsubscribedResponse> CheckEmailIsInUnsubscribesList(Expression<Func<string>> email)
        {
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            return new DeferredBodyAction<EmailIsUnsubscribedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/unsubscribes/{0}", __workflow_email.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EmailIsUnsubscribedResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> SendEmail(Expression<Func<string>> requestfrom, Expression<Func<string>> requestto, Expression<Func<string>> requestsubject, Expression<Func<string>> requestemailBody, Expression<Func<EmailAttachment[]>> requestattachment = null, Expression<Func<string>> requestfromName = null, Expression<Func<string>> requesttoNames = null, Expression<Func<string>> requestcC = null, Expression<Func<string>> requestcCNames = null, Expression<Func<string>> requestbcc = null, Expression<Func<string>> requestbCCNames = null)
        {
            var __workflow_requestfrom = WorkflowExpression.Compile(requestfrom, nameof(requestfrom), required: true);
            var __workflow_requestto = WorkflowExpression.Compile(requestto, nameof(requestto), required: true);
            var __workflow_requestsubject = WorkflowExpression.Compile(requestsubject, nameof(requestsubject), required: true);
            var __workflow_requestemailBody = WorkflowExpression.Compile(requestemailBody, nameof(requestemailBody), required: true);
            var __workflow_requestattachment = WorkflowExpression.Compile(requestattachment, nameof(requestattachment), required: false);
            var __workflow_requestfromName = WorkflowExpression.Compile(requestfromName, nameof(requestfromName), required: false);
            var __workflow_requesttoNames = WorkflowExpression.Compile(requesttoNames, nameof(requesttoNames), required: false);
            var __workflow_requestcC = WorkflowExpression.Compile(requestcC, nameof(requestcC), required: false);
            var __workflow_requestcCNames = WorkflowExpression.Compile(requestcCNames, nameof(requestcCNames), required: false);
            var __workflow_requestbcc = WorkflowExpression.Compile(requestbcc, nameof(requestbcc), required: false);
            var __workflow_requestbCCNames = WorkflowExpression.Compile(requestbCCNames, nameof(requestbCCNames), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/v4/mail/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestattachment != null)
                {
                    request["attachments"] = ExpressionConverter.ConvertO(__workflow_requestattachment);
                    requestpropCount++;
                }

                requestpropCount++;
                request["from"] = ExpressionConverter.ConvertO(__workflow_requestfrom);
                if (__workflow_requestfromName != null)
                {
                    request["fromname"] = ExpressionConverter.ConvertO(__workflow_requestfromName);
                    requestpropCount++;
                }

                requestpropCount++;
                request["to"] = ExpressionConverter.ConvertO(__workflow_requestto);
                if (__workflow_requesttoNames != null)
                {
                    request["toname"] = ExpressionConverter.ConvertO(__workflow_requesttoNames);
                    requestpropCount++;
                }

                requestpropCount++;
                request["subject"] = ExpressionConverter.ConvertO(__workflow_requestsubject);
                requestpropCount++;
                request["text"] = ExpressionConverter.ConvertO(__workflow_requestemailBody);
                request["ishtml"] = true;
                requestpropCount++;
                if (__workflow_requestcC != null)
                {
                    request["cc"] = ExpressionConverter.ConvertO(__workflow_requestcC);
                    requestpropCount++;
                }

                if (__workflow_requestcCNames != null)
                {
                    request["ccname"] = ExpressionConverter.ConvertO(__workflow_requestcCNames);
                    requestpropCount++;
                }

                if (__workflow_requestbcc != null)
                {
                    request["bcc"] = ExpressionConverter.ConvertO(__workflow_requestbcc);
                    requestpropCount++;
                }

                if (__workflow_requestbCCNames != null)
                {
                    request["bccname"] = ExpressionConverter.ConvertO(__workflow_requestbCCNames);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
