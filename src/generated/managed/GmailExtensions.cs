//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gmail
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GmailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IBodyWorkflowAction<DetailedReceiveMessage, ApiConnectionActionConfiguration> GetEmail(Expression<Func<string>> id, Expression<Func<bool>> includeAttachments = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            return new DeferredBodyAction<DetailedReceiveMessage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                return new ApiConnectionAction<DetailedReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEmail(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TrashEmail(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Mail/{0}/trash", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplyTo(Expression<Func<string>> id, Expression<Func<ReplyToV2Input>> replyMessage)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_replyMessage = WorkflowExpression.Compile(replyMessage, nameof(replyMessage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/Mail/ReplyTo/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_replyMessage);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendEmail(Expression<Func<SendEmailV2Input>> emailMessage)
        {
            var __workflow_emailMessage = WorkflowExpression.Compile(emailMessage, nameof(emailMessage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_emailMessage);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class GmailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<DetailedReceiveMessage, ApiConnectionTriggerConfiguration> OnNewEmail(Expression<Func<string>> label = null, Expression<Func<string>> to = null, Expression<Func<string>> from = null, Expression<Func<string>> subject = null, Expression<Func<importanceInput>> importance = null, Expression<Func<starredInput>> starred = null, Expression<Func<bool>> fetchOnlyWithAttachments = null, Expression<Func<bool>> includeAttachments = null, FlowRecurrence recurrence = null)
        {
            var __workflow_label = WorkflowExpression.Compile(label, nameof(label), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_starred = WorkflowExpression.Compile(starred, nameof(starred), required: false);
            var __workflow_fetchOnlyWithAttachments = WorkflowExpression.Compile(fetchOnlyWithAttachments, nameof(fetchOnlyWithAttachments), required: false);
            var __workflow_includeAttachments = WorkflowExpression.Compile(includeAttachments, nameof(includeAttachments), required: false);
            return new DeferredBodyTrigger<DetailedReceiveMessage, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Mail/OnNewEmail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["label"] = Convert.ToString("INBOX");
                if (__workflow_label != null)
                    callPayload.Queries["label"] = ExpressionConverter.Convert(__workflow_label);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                callPayload.Queries["importance"] = Convert.ToString("All");
                if (__workflow_importance != null)
                    callPayload.Queries["importance"] = ExpressionConverter.Convert(__workflow_importance);
                callPayload.Queries["starred"] = Convert.ToString("All");
                if (__workflow_starred != null)
                    callPayload.Queries["starred"] = ExpressionConverter.Convert(__workflow_starred);
                callPayload.Queries["fetchOnlyWithAttachments"] = Convert.ToString(false);
                if (__workflow_fetchOnlyWithAttachments != null)
                    callPayload.Queries["fetchOnlyWithAttachments"] = ExpressionConverter.Convert(__workflow_fetchOnlyWithAttachments);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                return new ApiConnectionTrigger<DetailedReceiveMessage>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class DetailedReceiveMessage
    {
        public string From { get; set; }

        [JsonProperty("SenderName")]
        public string SenderSName { get; set; }
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Snippet { get; set; }

        [JsonProperty("LabelIds")]
        public string[] LabelIDs { get; set; }

        [JsonProperty("DateTimeReceived")]
        public string ReceivedDateTime { get; set; }
        public int EstimatedSize { get; set; }
        public bool IsRead { get; set; }

        [JsonProperty("IsHtml")]
        public bool IsHTML { get; set; }
        public bool HasAttachments { get; set; }
        public Attachment[] Attachments { get; set; }

        [JsonProperty("Id")]
        public string MessageId { get; set; }
        public string ThreadId { get; set; }
    }

    public class Attachment
    {
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
        public string ContentType { get; set; }
    }

    public class ReplyToV2Input
    {
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool? ReplyAll { get; set; }
        public ReplyToV2InputImportanceType? Importance { get; set; }
        public Attachment[] Attachments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReplyToV2InputImportanceType
    {
        Normal,
        Low,
        High
    }

    public class SendEmailV2Input
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("Cc")]
        public string CC { get; set; }

        [JsonProperty("Bcc")]
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public SendEmailV2InputImportanceType? Importance { get; set; }
        public Attachment[] Attachments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendEmailV2InputImportanceType
    {
        Normal,
        Low,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum importanceInput
    {
        All,
        Important,
        [EnumMember(Value = "Not important")]
        NotImportant
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum starredInput
    {
        All,
        Starred,
        [EnumMember(Value = "Not starred")]
        NotStarred
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gmail;

    public partial class WorkflowManagedActions
    {
        public GmailActions Gmail(string connectionId) => new GmailActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GmailTriggers Gmail(string connectionId) => new GmailTriggers(connectionId);
    }
}