//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcsemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsemail")]
        public IBodyWorkflowAction<EmailSendResult> SendEmailGAVersion(Expression<Func<string>> emailMessagesenderAddress, Expression<Func<string>> emailMessagecontentsubject, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<emailMessagerecipientstoInputItem[]>> emailMessagerecipientsto = null, Expression<Func<emailMessagerecipientscCInputItem[]>> emailMessagerecipientscC = null, Expression<Func<emailMessagerecipientsbCCInputItem[]>> emailMessagerecipientsbCC = null, Expression<Func<string>> emailMessagecontenthtml = null, Expression<Func<emailMessagereplyToInputItem[]>> emailMessagereplyTo = null, Expression<Func<emailMessageattachmentsInputItem[]>> emailMessageattachments = null, Expression<Func<EmailCustomHeader[]>> emailMessageheaders = null, Expression<Func<bool>> emailMessageuserEngagementTrackingDisabled = null)
        {
            var apiCallPath = "/emails:sendGAVersion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
            var emailMessage = new JObject();
            var emailMessagepropCount = 0;
            emailMessagepropCount++;
            emailMessage["senderAddress"] = ExpressionConverter.ConvertO(emailMessagesenderAddress);
            if (emailMessageimportance != null)
            {
                if (emailMessageimportance != null)
                {
                    emailMessage["importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
                    emailMessagepropCount++;
                }

                emailMessagepropCount++;
            }
            else
            {
                emailMessage["importance"] = "Normal";
                emailMessagepropCount++;
            }

            var recipientsObject = new JObject();
            var recipientsObjectpropCount = 0;
            if (emailMessagerecipientsto != null)
            {
                recipientsObject["to"] = ExpressionConverter.ConvertO(emailMessagerecipientsto);
                recipientsObjectpropCount++;
            }

            if (emailMessagerecipientscC != null)
            {
                recipientsObject["CC"] = ExpressionConverter.ConvertO(emailMessagerecipientscC);
                recipientsObjectpropCount++;
            }

            if (emailMessagerecipientsbCC != null)
            {
                recipientsObject["bCC"] = ExpressionConverter.ConvertO(emailMessagerecipientsbCC);
                recipientsObjectpropCount++;
            }

            if (recipientsObjectpropCount > 0)
            {
                emailMessage["recipients"] = recipientsObject;
                emailMessagepropCount++;
            }

            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            contentObjectpropCount++;
            contentObject["subject"] = ExpressionConverter.ConvertO(emailMessagecontentsubject);
            if (emailMessagecontenthtml != null)
            {
                contentObject["html"] = ExpressionConverter.ConvertO(emailMessagecontenthtml);
                contentObjectpropCount++;
            }

            if (contentObjectpropCount > 0)
            {
                emailMessage["content"] = contentObject;
                emailMessagepropCount++;
            }

            if (emailMessagereplyTo != null)
            {
                emailMessage["replyTo"] = ExpressionConverter.ConvertO(emailMessagereplyTo);
                emailMessagepropCount++;
            }

            if (emailMessageattachments != null)
            {
                emailMessage["attachments"] = ExpressionConverter.ConvertO(emailMessageattachments);
                emailMessagepropCount++;
            }

            if (emailMessageheaders != null)
            {
                emailMessage["headers"] = ExpressionConverter.ConvertO(emailMessageheaders);
                emailMessagepropCount++;
            }

            if (emailMessageuserEngagementTrackingDisabled != null)
            {
                emailMessage["userEngagementTrackingDisabled"] = ExpressionConverter.ConvertO(emailMessageuserEngagementTrackingDisabled);
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction<EmailSendResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsemail")]
        public IBodyWorkflowAction<EmailSendResult> GetMessageStatusGAVersion(Expression<Func<string>> operationId)
        {
            var apiCallPath = String.Format("/emails/operations/{0}", ExpressionConverter.ConvertWithUrlEncoding(operationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
            return new ApiConnectionAction<EmailSendResult>(callPayload);
        }
    }

    public class AcsemailTriggers([ConnectionName] string connectionId)
    {
    }

    public class EmailSendResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public EmailSendResultStatusType Status { get; set; }

        [JsonProperty("error")]
        public ErrorDetail Error { get; set; }
    }

    public enum EmailSendResultStatusType
    {
        NotStarted,
        Running,
        Succeeded,
        Failed,
        Canceled
    }

    public class ErrorDetail
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("details")]
        public ErrorDetail[] Details { get; set; }

        [JsonProperty("additionalInfo")]
        public ErrorAdditionalInfo[] AdditionalInfo { get; set; }
    }

    public class ErrorAdditionalInfo
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("info")]
        public JToken Info { get; set; }
    }

    public enum emailMessageimportanceInput
    {
        High,
        Normal,
        Low
    }

    public class emailMessagerecipientstoInputItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class emailMessagerecipientscCInputItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class emailMessagerecipientsbCCInputItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class emailMessagereplyToInputItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class emailMessageattachmentsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentInBase64")]
        public string ContentInBase64 { get; set; }
    }

    public class EmailCustomHeader
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail;

    public partial class WorkflowManagedActions
    {
        public AcsemailActions Acsemail(string connectionId) => new AcsemailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AcsemailTriggers Acsemail(string connectionId) => new AcsemailTriggers(connectionId);
    }
}