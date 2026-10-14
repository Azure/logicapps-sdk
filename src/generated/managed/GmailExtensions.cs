//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gmail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GmailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IBodyWorkflowAction<DetailedReceiveMessage> GetEmail(Expression<Func<string>> id, Expression<Func<bool>> includeAttachments = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_includeAttachments = includeAttachments == null ? null : WorkflowExpression.Compile(includeAttachments);
            WorkflowExpression.Validate(__workflow_includeAttachments, nameof(includeAttachments), required: false);
            return new DeferredBodyAction<DetailedReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (__workflow_includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(__workflow_includeAttachments);
                return new ApiConnectionAction<DetailedReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction TrashEmail(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}/trash", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction ReplyTo(Expression<Func<string>> id, Expression<Func<string>> replyMessageto = null, Expression<Func<string>> replyMessagecC = null, Expression<Func<string>> replyMessagebCC = null, Expression<Func<string>> replyMessagesubject = null, Expression<Func<string>> replyMessagebody = null, Expression<Func<bool>> replyMessagereplyAll = null, Expression<Func<replyMessageimportanceInput>> replyMessageimportance = null, Expression<Func<Attachment[]>> replyMessageattachments = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_replyMessageto = replyMessageto == null ? null : WorkflowExpression.Compile(replyMessageto);
            WorkflowExpression.Validate(__workflow_replyMessageto, nameof(replyMessageto), required: false);
            var __workflow_replyMessagecC = replyMessagecC == null ? null : WorkflowExpression.Compile(replyMessagecC);
            WorkflowExpression.Validate(__workflow_replyMessagecC, nameof(replyMessagecC), required: false);
            var __workflow_replyMessagebCC = replyMessagebCC == null ? null : WorkflowExpression.Compile(replyMessagebCC);
            WorkflowExpression.Validate(__workflow_replyMessagebCC, nameof(replyMessagebCC), required: false);
            var __workflow_replyMessagesubject = replyMessagesubject == null ? null : WorkflowExpression.Compile(replyMessagesubject);
            WorkflowExpression.Validate(__workflow_replyMessagesubject, nameof(replyMessagesubject), required: false);
            var __workflow_replyMessagebody = replyMessagebody == null ? null : WorkflowExpression.Compile(replyMessagebody);
            WorkflowExpression.Validate(__workflow_replyMessagebody, nameof(replyMessagebody), required: false);
            var __workflow_replyMessagereplyAll = replyMessagereplyAll == null ? null : WorkflowExpression.Compile(replyMessagereplyAll);
            WorkflowExpression.Validate(__workflow_replyMessagereplyAll, nameof(replyMessagereplyAll), required: false);
            var __workflow_replyMessageimportance = replyMessageimportance == null ? null : WorkflowExpression.Compile(replyMessageimportance);
            WorkflowExpression.Validate(__workflow_replyMessageimportance, nameof(replyMessageimportance), required: false);
            var __workflow_replyMessageattachments = replyMessageattachments == null ? null : WorkflowExpression.Compile(replyMessageattachments);
            WorkflowExpression.Validate(__workflow_replyMessageattachments, nameof(replyMessageattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replyMessage = new JObject();
                var replyMessagepropCount = 0;
                if (__workflow_replyMessageto != null)
                {
                    replyMessage["To"] = ExpressionConverter.ConvertO(__workflow_replyMessageto);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessagecC != null)
                {
                    replyMessage["Cc"] = ExpressionConverter.ConvertO(__workflow_replyMessagecC);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessagebCC != null)
                {
                    replyMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_replyMessagebCC);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessagesubject != null)
                {
                    replyMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_replyMessagesubject);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessagebody != null)
                {
                    replyMessage["Body"] = ExpressionConverter.ConvertO(__workflow_replyMessagebody);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessagereplyAll != null)
                {
                    replyMessage["ReplyAll"] = ExpressionConverter.ConvertO(__workflow_replyMessagereplyAll);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessageimportance != null)
                {
                    replyMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_replyMessageimportance);
                    replyMessagepropCount++;
                }

                if (__workflow_replyMessageattachments != null)
                {
                    replyMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_replyMessageattachments);
                    replyMessagepropCount++;
                }

                if (replyMessagepropCount > 0)
                {
                    callPayload.Body = replyMessage;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<string>> emailMessagesubject = null, Expression<Func<string>> emailMessagebody = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<Attachment[]>> emailMessageattachments = null)
        {
            var __workflow_emailMessageto = emailMessageto == null ? null : WorkflowExpression.Compile(emailMessageto);
            WorkflowExpression.Validate(__workflow_emailMessageto, nameof(emailMessageto), required: true);
            var __workflow_emailMessagecC = emailMessagecC == null ? null : WorkflowExpression.Compile(emailMessagecC);
            WorkflowExpression.Validate(__workflow_emailMessagecC, nameof(emailMessagecC), required: false);
            var __workflow_emailMessagebCC = emailMessagebCC == null ? null : WorkflowExpression.Compile(emailMessagebCC);
            WorkflowExpression.Validate(__workflow_emailMessagebCC, nameof(emailMessagebCC), required: false);
            var __workflow_emailMessagesubject = emailMessagesubject == null ? null : WorkflowExpression.Compile(emailMessagesubject);
            WorkflowExpression.Validate(__workflow_emailMessagesubject, nameof(emailMessagesubject), required: false);
            var __workflow_emailMessagebody = emailMessagebody == null ? null : WorkflowExpression.Compile(emailMessagebody);
            WorkflowExpression.Validate(__workflow_emailMessagebody, nameof(emailMessagebody), required: false);
            var __workflow_emailMessageimportance = emailMessageimportance == null ? null : WorkflowExpression.Compile(emailMessageimportance);
            WorkflowExpression.Validate(__workflow_emailMessageimportance, nameof(emailMessageimportance), required: false);
            var __workflow_emailMessageattachments = emailMessageattachments == null ? null : WorkflowExpression.Compile(emailMessageattachments);
            WorkflowExpression.Validate(__workflow_emailMessageattachments, nameof(emailMessageattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = ExpressionConverter.ConvertO(__workflow_emailMessageto);
                if (__workflow_emailMessagecC != null)
                {
                    emailMessage["Cc"] = ExpressionConverter.ConvertO(__workflow_emailMessagecC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(__workflow_emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagesubject != null)
                {
                    emailMessage["Subject"] = ExpressionConverter.ConvertO(__workflow_emailMessagesubject);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessagebody != null)
                {
                    emailMessage["Body"] = ExpressionConverter.ConvertO(__workflow_emailMessagebody);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageimportance != null)
                {
                    emailMessage["Importance"] = ExpressionConverter.ConvertO(__workflow_emailMessageimportance);
                    emailMessagepropCount++;
                }

                if (__workflow_emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(__workflow_emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagepropCount > 0)
                {
                    callPayload.Body = emailMessage;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class GmailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<DetailedReceiveMessage> OnNewEmail(Expression<Func<string>> label = null, Expression<Func<string>> to = null, Expression<Func<string>> from = null, Expression<Func<string>> subject = null, Expression<Func<importanceInput>> importance = null, Expression<Func<starredInput>> starred = null, Expression<Func<bool>> fetchOnlyWithAttachments = null, Expression<Func<bool>> includeAttachments = null, FlowRecurrence recurrence = null)
        {
            var __workflow_label = label == null ? null : WorkflowExpression.Compile(label);
            WorkflowExpression.Validate(__workflow_label, nameof(label), required: false);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: false);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_subject = subject == null ? null : WorkflowExpression.Compile(subject);
            WorkflowExpression.Validate(__workflow_subject, nameof(subject), required: false);
            var __workflow_importance = importance == null ? null : WorkflowExpression.Compile(importance);
            WorkflowExpression.Validate(__workflow_importance, nameof(importance), required: false);
            var __workflow_starred = starred == null ? null : WorkflowExpression.Compile(starred);
            WorkflowExpression.Validate(__workflow_starred, nameof(starred), required: false);
            var __workflow_fetchOnlyWithAttachments = fetchOnlyWithAttachments == null ? null : WorkflowExpression.Compile(fetchOnlyWithAttachments);
            WorkflowExpression.Validate(__workflow_fetchOnlyWithAttachments, nameof(fetchOnlyWithAttachments), required: false);
            var __workflow_includeAttachments = includeAttachments == null ? null : WorkflowExpression.Compile(includeAttachments);
            WorkflowExpression.Validate(__workflow_includeAttachments, nameof(includeAttachments), required: false);
            return new DeferredBodyTrigger<DetailedReceiveMessage>(() =>
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
        public string MessageID { get; set; }

        [JsonProperty("ThreadId")]
        public string ThreadID { get; set; }
    }

    public class Attachment
    {
        public string Name { get; set; }

        [JsonProperty("ContentBytes")]
        public string Content { get; set; }
        public string ContentType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum replyMessageimportanceInput
    {
        Normal,
        Low,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum emailMessageimportanceInput
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
