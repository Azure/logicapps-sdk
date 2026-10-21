//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcsemailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsemail")]
        public IBodyWorkflowAction<EmailSendResult> SendEmailGAVersion(Expression<Func<string>> emailMessagesenderAddress, Expression<Func<string>> emailMessagecontentsubject, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<emailMessagerecipientstoInputItem[]>> emailMessagerecipientsto = null, Expression<Func<emailMessagerecipientscCInputItem[]>> emailMessagerecipientscC = null, Expression<Func<emailMessagerecipientsbCCInputItem[]>> emailMessagerecipientsbCC = null, Expression<Func<string>> emailMessagecontenthtml = null, Expression<Func<emailMessagereplyToInputItem[]>> emailMessagereplyTo = null, Expression<Func<emailMessageattachmentsInputItem[]>> emailMessageattachments = null, Expression<Func<EmailCustomHeader[]>> emailMessageheaders = null, Expression<Func<bool>> emailMessageuserEngagementTrackingDisabled = null)
        {
            var __workflow_emailMessagesenderAddress = WorkflowExpression.Compile(emailMessagesenderAddress, nameof(emailMessagesenderAddress), required: true);
            var __workflow_emailMessagecontentsubject = WorkflowExpression.Compile(emailMessagecontentsubject, nameof(emailMessagecontentsubject), required: true);
            var __workflow_emailMessageimportance = WorkflowExpression.Compile(emailMessageimportance, nameof(emailMessageimportance), required: false);
            var __workflow_emailMessagerecipientsto = WorkflowExpression.Compile(emailMessagerecipientsto, nameof(emailMessagerecipientsto), required: false);
            var __workflow_emailMessagerecipientscC = WorkflowExpression.Compile(emailMessagerecipientscC, nameof(emailMessagerecipientscC), required: false);
            var __workflow_emailMessagerecipientsbCC = WorkflowExpression.Compile(emailMessagerecipientsbCC, nameof(emailMessagerecipientsbCC), required: false);
            var __workflow_emailMessagecontenthtml = WorkflowExpression.Compile(emailMessagecontenthtml, nameof(emailMessagecontenthtml), required: false);
            var __workflow_emailMessagereplyTo = WorkflowExpression.Compile(emailMessagereplyTo, nameof(emailMessagereplyTo), required: false);
            var __workflow_emailMessageattachments = WorkflowExpression.Compile(emailMessageattachments, nameof(emailMessageattachments), required: false);
            var __workflow_emailMessageheaders = WorkflowExpression.Compile(emailMessageheaders, nameof(emailMessageheaders), required: false);
            var __workflow_emailMessageuserEngagementTrackingDisabled = WorkflowExpression.Compile(emailMessageuserEngagementTrackingDisabled, nameof(emailMessageuserEngagementTrackingDisabled), required: false);
            return new DeferredBodyAction<EmailSendResult>(() =>
            {
                var apiCallPath = "/emails:sendGAVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["senderAddress"] = ExpressionConverter.ConvertO(__workflow_emailMessagesenderAddress);
                if (__workflow_emailMessageimportance != null)
                {
                    if (__workflow_emailMessageimportance != null)
                    {
                        emailMessage["importance"] = ExpressionConverter.ConvertO(__workflow_emailMessageimportance);
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
                if (__workflow_emailMessagerecipientsto != null)
                {
                    recipientsObject["to"] = ExpressionConverter.ConvertO(__workflow_emailMessagerecipientsto);
                    recipientsObjectpropCount++;
                }

                if (__workflow_emailMessagerecipientscC != null)
                {
                    recipientsObject["CC"] = ExpressionConverter.ConvertO(__workflow_emailMessagerecipientscC);
                    recipientsObjectpropCount++;
                }

                if (__workflow_emailMessagerecipientsbCC != null)
                {
                    recipientsObject["bCC"] = ExpressionConverter.ConvertO(__workflow_emailMessagerecipientsbCC);
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
                contentObject["subject"] = ExpressionConverter.ConvertO(__workflow_emailMessagecontentsubject);
                if (__workflow_emailMessagecontenthtml != null)
                {
                    contentObject["html"] = ExpressionConverter.ConvertO(__workflow_emailMessagecontenthtml);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    emailMessage["content"] = contentObject;
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagereplyTo != null)
                {
                    emailMessage["replyTo"] = ExpressionConverter.ConvertO(__workflow_emailMessagereplyTo);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageattachments != null)
                {
                    emailMessage["attachments"] = ExpressionConverter.ConvertO(__workflow_emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageheaders != null)
                {
                    emailMessage["headers"] = ExpressionConverter.ConvertO(__workflow_emailMessageheaders);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageuserEngagementTrackingDisabled != null)
                {
                    emailMessage["userEngagementTrackingDisabled"] = ExpressionConverter.ConvertO(__workflow_emailMessageuserEngagementTrackingDisabled);
                    emailMessagepropCount++;
                }

                if (emailMessagepropCount > 0)
                {
                    callPayload.Body = emailMessage;
                }

                return new ApiConnectionAction<EmailSendResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsemail")]
        public IBodyWorkflowAction<EmailSendResult> GetMessageStatusGAVersion(Expression<Func<string>> operationId)
        {
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            return new DeferredBodyAction<EmailSendResult>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/emails/operations/{0}", __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
                return new ApiConnectionAction<EmailSendResult>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
