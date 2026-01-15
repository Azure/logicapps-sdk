//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Sendgrid
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendgridActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> SendEmailV4(Expression<Func<string>> requestfrom, Expression<Func<string>> requestto, Expression<Func<string>> requestsubject, Expression<Func<string>> requestemailBody, Expression<Func<EmailAttachment[]>> requestattachment = null, Expression<Func<string>> requestfromName = null, Expression<Func<string>> requesttoNames = null, Expression<Func<string>> requestcC = null, Expression<Func<string>> requestcCNames = null, Expression<Func<string>> requestbcc = null, Expression<Func<string>> requestbCCNames = null)
        {
            var apiCallPath = "/v4/mail/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestattachment != null)
            {
                request["attachments"] = ExpressionConverter.ConvertO(requestattachment);
                requestpropCount++;
            }

            requestpropCount++;
            request["from"] = ExpressionConverter.ConvertO(requestfrom);
            if (requestfromName != null)
            {
                request["fromname"] = ExpressionConverter.ConvertO(requestfromName);
                requestpropCount++;
            }

            requestpropCount++;
            request["to"] = ExpressionConverter.ConvertO(requestto);
            if (requesttoNames != null)
            {
                request["toname"] = ExpressionConverter.ConvertO(requesttoNames);
                requestpropCount++;
            }

            requestpropCount++;
            request["subject"] = ExpressionConverter.ConvertO(requestsubject);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requestemailBody);
            request["ishtml"] = true;
            requestpropCount++;
            if (requestcC != null)
            {
                request["cc"] = ExpressionConverter.ConvertO(requestcC);
                requestpropCount++;
            }

            if (requestcCNames != null)
            {
                request["ccname"] = ExpressionConverter.ConvertO(requestcCNames);
                requestpropCount++;
            }

            if (requestbcc != null)
            {
                request["bcc"] = ExpressionConverter.ConvertO(requestbcc);
                requestpropCount++;
            }

            if (requestbCCNames != null)
            {
                request["bccname"] = ExpressionConverter.ConvertO(requestbCCNames);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<AddGlobalSuppressRequestAndResponse> AddGlobalSuppression(Expression<Func<string[]>> recipientEmailsrecipientEmail = null)
        {
            var apiCallPath = "/suppressions/global";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var recipientEmails = new JObject();
            var recipientEmailspropCount = 0;
            if (recipientEmailsrecipientEmail != null)
            {
                recipientEmails["recipient_emails"] = ExpressionConverter.ConvertO(recipientEmailsrecipientEmail);
                recipientEmailspropCount++;
            }

            if (recipientEmailspropCount > 0)
            {
                callPayload.Body = recipientEmails;
            }

            return new ApiConnectionAction<AddGlobalSuppressRequestAndResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteGlobalSuppression(Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/suppressions/global/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> AddRecipientToList(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var apiCallPath = String.Format("/v3/contactdb/lists/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<Bounce[]> GetBounce(Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/suppression/bounces/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Bounce[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteBounce(Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/suppression/bounces/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<EmailIsUnsubscribedResponse> CheckEmailIsInUnsubscribesList(Expression<Func<string>> email)
        {
            var apiCallPath = String.Format("/unsubscribes/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EmailIsUnsubscribedResponse>(callPayload);
        }
    }

    public class SendgridTriggers([ConnectionName] string connectionId)
    {
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Sendgrid;

    public partial class WorkflowManagedActions
    {
        public SendgridActions Sendgrid(string connectionId) => new SendgridActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SendgridTriggers Sendgrid(string connectionId) => new SendgridTriggers(connectionId);
    }
}