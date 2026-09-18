//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendgrid
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendgridActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<AddGlobalSuppressRequestAndResponse> AddGlobalSuppression([WorkflowExpression] Func<string[]> recipientEmailsrecipientEmail = null)
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
        public IWorkflowAction DeleteGlobalSuppression([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> email)
        {
            var apiCallPath = String.Format("/suppressions/global/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> AddRecipientToList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> listId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> recipientId)
        {
            var apiCallPath = String.Format("/v3/contactdb/lists/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<Bounce[]> GetBounce([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> email)
        {
            var apiCallPath = String.Format("/suppression/bounces/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Bounce[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteBounce([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> email)
        {
            var apiCallPath = String.Format("/suppression/bounces/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<EmailIsUnsubscribedResponse> CheckEmailIsInUnsubscribesList([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> email)
        {
            var apiCallPath = String.Format("/unsubscribes/{0}", ExpressionConverter.ConvertWithUrlEncoding(email, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<EmailIsUnsubscribedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> SendEmail([WorkflowExpression] Func<string> requestfrom, [WorkflowExpression] Func<string> requestto, [WorkflowExpression] Func<string> requestsubject, [WorkflowExpression] Func<string> requestemailBody, [WorkflowExpression] Func<EmailAttachment[]> requestattachment = null, [WorkflowExpression] Func<string> requestfromName = null, [WorkflowExpression] Func<string> requesttoNames = null, [WorkflowExpression] Func<string> requestcC = null, [WorkflowExpression] Func<string> requestcCNames = null, [WorkflowExpression] Func<string> requestbcc = null, [WorkflowExpression] Func<string> requestbCCNames = null)
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