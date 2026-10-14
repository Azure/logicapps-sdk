//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendgrid
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SendgridActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<AddGlobalSuppressRequestAndResponse> AddGlobalSuppression(Expression<Func<string[]>> recipientEmailsrecipientEmail = null)
        {
            var __workflow_recipientEmailsrecipientEmail = recipientEmailsrecipientEmail == null ? null : WorkflowExpression.Compile(recipientEmailsrecipientEmail);
            WorkflowExpression.Validate(__workflow_recipientEmailsrecipientEmail, nameof(recipientEmailsrecipientEmail), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteGlobalSuppression(Expression<Func<string>> email)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/suppressions/global/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_email, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> AddRecipientToList(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v3/contactdb/lists/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<Bounce[]> GetBounce(Expression<Func<string>> email)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            return new DeferredBodyAction<Bounce[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/suppression/bounces/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_email, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Bounce[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteBounce(Expression<Func<string>> email)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/suppression/bounces/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_email, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<EmailIsUnsubscribedResponse> CheckEmailIsInUnsubscribesList(Expression<Func<string>> email)
        {
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: true);
            return new DeferredBodyAction<EmailIsUnsubscribedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/unsubscribes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_email, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EmailIsUnsubscribedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> SendEmail(Expression<Func<string>> requestfrom, Expression<Func<string>> requestto, Expression<Func<string>> requestsubject, Expression<Func<string>> requestemailBody, Expression<Func<EmailAttachment[]>> requestattachment = null, Expression<Func<string>> requestfromName = null, Expression<Func<string>> requesttoNames = null, Expression<Func<string>> requestcC = null, Expression<Func<string>> requestcCNames = null, Expression<Func<string>> requestbcc = null, Expression<Func<string>> requestbCCNames = null)
        {
            var __workflow_requestfrom = requestfrom == null ? null : WorkflowExpression.Compile(requestfrom);
            WorkflowExpression.Validate(__workflow_requestfrom, nameof(requestfrom), required: true);
            var __workflow_requestto = requestto == null ? null : WorkflowExpression.Compile(requestto);
            WorkflowExpression.Validate(__workflow_requestto, nameof(requestto), required: true);
            var __workflow_requestsubject = requestsubject == null ? null : WorkflowExpression.Compile(requestsubject);
            WorkflowExpression.Validate(__workflow_requestsubject, nameof(requestsubject), required: true);
            var __workflow_requestemailBody = requestemailBody == null ? null : WorkflowExpression.Compile(requestemailBody);
            WorkflowExpression.Validate(__workflow_requestemailBody, nameof(requestemailBody), required: true);
            var __workflow_requestattachment = requestattachment == null ? null : WorkflowExpression.Compile(requestattachment);
            WorkflowExpression.Validate(__workflow_requestattachment, nameof(requestattachment), required: false);
            var __workflow_requestfromName = requestfromName == null ? null : WorkflowExpression.Compile(requestfromName);
            WorkflowExpression.Validate(__workflow_requestfromName, nameof(requestfromName), required: false);
            var __workflow_requesttoNames = requesttoNames == null ? null : WorkflowExpression.Compile(requesttoNames);
            WorkflowExpression.Validate(__workflow_requesttoNames, nameof(requesttoNames), required: false);
            var __workflow_requestcC = requestcC == null ? null : WorkflowExpression.Compile(requestcC);
            WorkflowExpression.Validate(__workflow_requestcC, nameof(requestcC), required: false);
            var __workflow_requestcCNames = requestcCNames == null ? null : WorkflowExpression.Compile(requestcCNames);
            WorkflowExpression.Validate(__workflow_requestcCNames, nameof(requestcCNames), required: false);
            var __workflow_requestbcc = requestbcc == null ? null : WorkflowExpression.Compile(requestbcc);
            WorkflowExpression.Validate(__workflow_requestbcc, nameof(requestbcc), required: false);
            var __workflow_requestbCCNames = requestbCCNames == null ? null : WorkflowExpression.Compile(requestbCCNames);
            WorkflowExpression.Validate(__workflow_requestbCCNames, nameof(requestbCCNames), required: false);
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
