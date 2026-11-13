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
        public IBodyWorkflowAction<EmailSendResult, ApiConnectionActionConfiguration> SendEmailGAVersion(Expression<Func<EmailMessageInput>> emailMessage)
        {
            var __workflow_emailMessage = WorkflowExpression.Compile(emailMessage, nameof(emailMessage), required: true);
            return new DeferredBodyAction<EmailSendResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/emails:sendGAVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_emailMessage);
                return new ApiConnectionAction<EmailSendResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "acsemail")]
        public IBodyWorkflowAction<EmailSendResult, ApiConnectionActionConfiguration> GetMessageStatusGAVersion(Expression<Func<string>> operationId)
        {
            var __workflow_operationId = WorkflowExpression.Compile(operationId, nameof(operationId), required: true);
            return new DeferredBodyAction<EmailSendResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/emails/operations/{0}", __workflow_operationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2023-03-31");
                return new ApiConnectionAction<EmailSendResult>(callPayload);
            });
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

    public class EmailMessageInput
    {
        public EmailMessageInput(string senderAddress, EmailMessageInputRecipientsType recipients, ContentDetails content)
        {
            this.SenderAddress = senderAddress;
            this.Recipients = recipients;
            this.Content = content;
        }

        [JsonProperty("senderAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SenderAddress { get; set; }

        [JsonProperty("importance", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailMessageInputImportanceType? Importance { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail.EmailMessageInputImportanceType.Normal;

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailMessageInputRecipientsType Recipients { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public ContentDetails Content { get; set; }

        [JsonProperty("replyTo")]
        public EmailMessageInputReplyToTypeItem[] ReplyTo { get; set; }

        [JsonProperty("attachments")]
        public EmailMessageInputAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("headers")]
        public EmailCustomHeader[] Headers { get; set; }

        [JsonProperty("userEngagementTrackingDisabled")]
        public bool? UserEngagementTrackingDisabled { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EmailMessageInputImportanceType
    {
        High,
        Normal,
        Low
    }

    public class EmailMessageInputRecipientsType
    {
        public EmailMessageInputRecipientsType(EmailMessageInputRecipientsTypeToTypeItem[] to)
        {
            this.To = to;
        }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public EmailMessageInputRecipientsTypeToTypeItem[] To { get; set; }
        public EmailMessageInputRecipientsTypeCCTypeItem[] CC { get; set; }

        [JsonProperty("bCC")]
        public EmailMessageInputRecipientsTypeBccTypeItem[] Bcc { get; set; }
    }

    public class EmailMessageInputRecipientsTypeToTypeItem
    {
        public EmailMessageInputRecipientsTypeToTypeItem(string address)
        {
            this.Address = address;
        }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class EmailMessageInputRecipientsTypeCCTypeItem
    {
        public EmailMessageInputRecipientsTypeCCTypeItem(string address)
        {
            this.Address = address;
        }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class EmailMessageInputRecipientsTypeBccTypeItem
    {
        public EmailMessageInputRecipientsTypeBccTypeItem(string address)
        {
            this.Address = address;
        }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class ContentDetails
    {
        public ContentDetails(string subject)
        {
            this.Subject = subject;
        }

        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }

    public class EmailMessageInputReplyToTypeItem
    {
        public EmailMessageInputReplyToTypeItem(string address)
        {
            this.Address = address;
        }

        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class EmailMessageInputAttachmentsTypeItem
    {
        public EmailMessageInputAttachmentsTypeItem(string name, string contentType, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent contentInBase64)
        {
            this.Name = name;
            this.ContentType = contentType;
            this.ContentInBase64 = contentInBase64;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentType { get; set; }

        [JsonProperty("contentInBase64", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent ContentInBase64 { get; set; }
    }

    public class EmailCustomHeader
    {
        public EmailCustomHeader(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
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