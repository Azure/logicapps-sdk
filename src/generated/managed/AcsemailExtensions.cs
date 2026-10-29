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
        public IBodyWorkflowAction<EmailSendResult, ApiConnectionActionConfiguration> SendEmailGAVersion(Expression<Func<SendEmailGAVersionInput>> emailMessage)
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

    public class SendEmailGAVersionInput
    {
        [JsonProperty("senderAddress", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SenderAddress { get; set; }

        [JsonProperty("importance", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailGAVersionInputImportanceType? Importance { get; set; } = SendEmailGAVersionInputImportanceType.Normal;

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailGAVersionInputRecipientsType Recipients { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public ContentDetails Content { get; set; }

        [JsonProperty("replyTo")]
        public SendEmailGAVersionInputReplyToTypeItem[] ReplyTo { get; set; }

        [JsonProperty("attachments")]
        public SendEmailGAVersionInputAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("headers")]
        public EmailCustomHeader[] Headers { get; set; }

        [JsonProperty("userEngagementTrackingDisabled")]
        public bool? UserEngagementTrackingDisabled { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendEmailGAVersionInputImportanceType
    {
        High,
        Normal,
        Low
    }

    public class SendEmailGAVersionInputRecipientsType
    {
        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEmailGAVersionInputRecipientsTypeToTypeItem[] To { get; set; }
        public SendEmailGAVersionInputRecipientsTypeCCTypeItem[] CC { get; set; }

        [JsonProperty("bCC")]
        public SendEmailGAVersionInputRecipientsTypeBCCTypeItem[] BCC { get; set; }
    }

    public class SendEmailGAVersionInputRecipientsTypeToTypeItem
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class SendEmailGAVersionInputRecipientsTypeCCTypeItem
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class SendEmailGAVersionInputRecipientsTypeBCCTypeItem
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class ContentDetails
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }
    }

    public class SendEmailGAVersionInputReplyToTypeItem
    {
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Address { get; set; }
    }

    public class SendEmailGAVersionInputAttachmentsTypeItem
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentType { get; set; }

        [JsonProperty("contentInBase64", DefaultValueHandling = DefaultValueHandling.Include)]
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