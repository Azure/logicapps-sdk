//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sendgrid
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SendgridActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<AddGlobalSuppressRequestAndResponse> AddGlobalSuppression([WorkflowExpression] Func<string[]> recipientEmailsrecipientEmail = null)
        {
            SourceExpression.Validate(recipientEmailsrecipientEmail, nameof(recipientEmailsrecipientEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/suppressions/global";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var recipientEmails = new JObject();
                var recipientEmailspropCount = 0;
                if (recipientEmailsrecipientEmail != null)
                {
                    recipientEmails["recipient_emails"] = SourceExpressionConverter.ConvertToken(recipientEmailsrecipientEmail);
                    recipientEmailspropCount++;
                }

                if (recipientEmailspropCount > 0)
                {
                    callPayload.Body = recipientEmails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddGlobalSuppressRequestAndResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteGlobalSuppression([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/suppressions/global/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> AddRecipientToList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v3/contactdb/lists/{0}/recipients/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<Bounce[]> GetBounce([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/suppression/bounces/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Bounce[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IWorkflowAction DeleteBounce([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/suppression/bounces/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<EmailIsUnsubscribedResponse> CheckEmailIsInUnsubscribesList([WorkflowExpression] Func<string> email)
        {
            SourceExpression.Validate(email, nameof(email), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/unsubscribes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(email, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EmailIsUnsubscribedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sendgrid")]
        public IBodyWorkflowAction<JToken> SendEmail([WorkflowExpression] Func<string> requestfrom, [WorkflowExpression] Func<string> requestto, [WorkflowExpression] Func<string> requestsubject, [WorkflowExpression] Func<string> requestemailBody, [WorkflowExpression] Func<EmailAttachment[]> requestattachment = null, [WorkflowExpression] Func<string> requestfromName = null, [WorkflowExpression] Func<string> requesttoNames = null, [WorkflowExpression] Func<string> requestcC = null, [WorkflowExpression] Func<string> requestcCNames = null, [WorkflowExpression] Func<string> requestbcc = null, [WorkflowExpression] Func<string> requestbCCNames = null)
        {
            SourceExpression.Validate(requestfrom, nameof(requestfrom), required: true);
            SourceExpression.Validate(requestto, nameof(requestto), required: true);
            SourceExpression.Validate(requestsubject, nameof(requestsubject), required: true);
            SourceExpression.Validate(requestemailBody, nameof(requestemailBody), required: true);
            SourceExpression.Validate(requestattachment, nameof(requestattachment), required: false);
            SourceExpression.Validate(requestfromName, nameof(requestfromName), required: false);
            SourceExpression.Validate(requesttoNames, nameof(requesttoNames), required: false);
            SourceExpression.Validate(requestcC, nameof(requestcC), required: false);
            SourceExpression.Validate(requestcCNames, nameof(requestcCNames), required: false);
            SourceExpression.Validate(requestbcc, nameof(requestbcc), required: false);
            SourceExpression.Validate(requestbCCNames, nameof(requestbCCNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v4/mail/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestattachment != null)
                {
                    request["attachments"] = SourceExpressionConverter.ConvertToken(requestattachment);
                    requestpropCount++;
                }

                requestpropCount++;
                request["from"] = SourceExpressionConverter.ConvertToken(requestfrom);
                if (requestfromName != null)
                {
                    request["fromname"] = SourceExpressionConverter.ConvertToken(requestfromName);
                    requestpropCount++;
                }

                requestpropCount++;
                request["to"] = SourceExpressionConverter.ConvertToken(requestto);
                if (requesttoNames != null)
                {
                    request["toname"] = SourceExpressionConverter.ConvertToken(requesttoNames);
                    requestpropCount++;
                }

                requestpropCount++;
                request["subject"] = SourceExpressionConverter.ConvertToken(requestsubject);
                requestpropCount++;
                request["text"] = SourceExpressionConverter.ConvertToken(requestemailBody);
                request["ishtml"] = true;
                requestpropCount++;
                if (requestcC != null)
                {
                    request["cc"] = SourceExpressionConverter.ConvertToken(requestcC);
                    requestpropCount++;
                }

                if (requestcCNames != null)
                {
                    request["ccname"] = SourceExpressionConverter.ConvertToken(requestcCNames);
                    requestpropCount++;
                }

                if (requestbcc != null)
                {
                    request["bcc"] = SourceExpressionConverter.ConvertToken(requestbcc);
                    requestpropCount++;
                }

                if (requestbCCNames != null)
                {
                    request["bccname"] = SourceExpressionConverter.ConvertToken(requestbCCNames);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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