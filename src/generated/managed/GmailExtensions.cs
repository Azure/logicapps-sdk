//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gmail
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GmailActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmail))]
        public IBodyWorkflowAction<DetailedReceiveMessage> GetEmail([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> includeAttachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetailedReceiveMessage> __BuildGetEmail(WorkflowExpression<string> id, WorkflowExpression<bool> includeAttachments = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            return new DeferredBodyAction<DetailedReceiveMessage>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
                return new ApiConnectionAction<DetailedReceiveMessage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEmail))]
        public IWorkflowAction DeleteEmail([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEmail(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [WorkflowExpressionFactory(nameof(__BuildTrashEmail))]
        public IWorkflowAction TrashEmail([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTrashEmail(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Mail/{0}/trash", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [WorkflowExpressionFactory(nameof(__BuildReplyTo))]
        public IWorkflowAction ReplyTo([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> replyMessageto = null, [WorkflowExpression] Func<string> replyMessagecC = null, [WorkflowExpression] Func<string> replyMessagebCC = null, [WorkflowExpression] Func<string> replyMessagesubject = null, [WorkflowExpression] Func<string> replyMessagebody = null, [WorkflowExpression] Func<bool> replyMessagereplyAll = null, [WorkflowExpression] Func<replyMessageimportanceInput> replyMessageimportance = null, [WorkflowExpression] Func<Attachment[]> replyMessageattachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplyTo(WorkflowExpression<string> id, WorkflowExpression<string> replyMessageto = null, WorkflowExpression<string> replyMessagecC = null, WorkflowExpression<string> replyMessagebCC = null, WorkflowExpression<string> replyMessagesubject = null, WorkflowExpression<string> replyMessagebody = null, WorkflowExpression<bool> replyMessagereplyAll = null, WorkflowExpression<replyMessageimportanceInput> replyMessageimportance = null, WorkflowExpression<Attachment[]> replyMessageattachments = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(replyMessageto, nameof(replyMessageto), required: false);
            WorkflowExpression.Validate(replyMessagecC, nameof(replyMessagecC), required: false);
            WorkflowExpression.Validate(replyMessagebCC, nameof(replyMessagebCC), required: false);
            WorkflowExpression.Validate(replyMessagesubject, nameof(replyMessagesubject), required: false);
            WorkflowExpression.Validate(replyMessagebody, nameof(replyMessagebody), required: false);
            WorkflowExpression.Validate(replyMessagereplyAll, nameof(replyMessagereplyAll), required: false);
            WorkflowExpression.Validate(replyMessageimportance, nameof(replyMessageimportance), required: false);
            WorkflowExpression.Validate(replyMessageattachments, nameof(replyMessageattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replyMessage = new JObject();
                var replyMessagepropCount = 0;
                if (replyMessageto != null)
                {
                    replyMessage["To"] = ExpressionConverter.ConvertO(replyMessageto);
                    replyMessagepropCount++;
                }

                if (replyMessagecC != null)
                {
                    replyMessage["Cc"] = ExpressionConverter.ConvertO(replyMessagecC);
                    replyMessagepropCount++;
                }

                if (replyMessagebCC != null)
                {
                    replyMessage["Bcc"] = ExpressionConverter.ConvertO(replyMessagebCC);
                    replyMessagepropCount++;
                }

                if (replyMessagesubject != null)
                {
                    replyMessage["Subject"] = ExpressionConverter.ConvertO(replyMessagesubject);
                    replyMessagepropCount++;
                }

                if (replyMessagebody != null)
                {
                    replyMessage["Body"] = ExpressionConverter.ConvertO(replyMessagebody);
                    replyMessagepropCount++;
                }

                if (replyMessagereplyAll != null)
                {
                    replyMessage["ReplyAll"] = ExpressionConverter.ConvertO(replyMessagereplyAll);
                    replyMessagepropCount++;
                }

                if (replyMessageimportance != null)
                {
                    replyMessage["Importance"] = ExpressionConverter.ConvertO(replyMessageimportance);
                    replyMessagepropCount++;
                }

                if (replyMessageattachments != null)
                {
                    replyMessage["Attachments"] = ExpressionConverter.ConvertO(replyMessageattachments);
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
        [WorkflowExpressionFactory(nameof(__BuildSendEmail))]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<string> emailMessagesubject = null, [WorkflowExpression] Func<string> emailMessagebody = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null, [WorkflowExpression] Func<Attachment[]> emailMessageattachments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEmail(WorkflowExpression<string> emailMessageto, WorkflowExpression<string> emailMessagecC = null, WorkflowExpression<string> emailMessagebCC = null, WorkflowExpression<string> emailMessagesubject = null, WorkflowExpression<string> emailMessagebody = null, WorkflowExpression<emailMessageimportanceInput> emailMessageimportance = null, WorkflowExpression<Attachment[]> emailMessageattachments = null)
        {
            WorkflowExpression.Validate(emailMessageto, nameof(emailMessageto), required: true);
            WorkflowExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            WorkflowExpression.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            WorkflowExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: false);
            WorkflowExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: false);
            WorkflowExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            WorkflowExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = ExpressionConverter.ConvertO(emailMessageto);
                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = ExpressionConverter.ConvertO(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = ExpressionConverter.ConvertO(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessagesubject != null)
                {
                    emailMessage["Subject"] = ExpressionConverter.ConvertO(emailMessagesubject);
                    emailMessagepropCount++;
                }

                if (emailMessagebody != null)
                {
                    emailMessage["Body"] = ExpressionConverter.ConvertO(emailMessagebody);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    emailMessage["Importance"] = ExpressionConverter.ConvertO(emailMessageimportance);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = ExpressionConverter.ConvertO(emailMessageattachments);
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

        [WorkflowExpressionFactory(nameof(__BuildOnNewEmail))]
        public IBodyWorkflowTrigger<DetailedReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> label = null,[WorkflowExpression] Func<string> to = null,[WorkflowExpression] Func<string> from = null,[WorkflowExpression] Func<string> subject = null,[WorkflowExpression] Func<importanceInput> importance = null,[WorkflowExpression] Func<starredInput> starred = null,[WorkflowExpression] Func<bool> fetchOnlyWithAttachments = null,[WorkflowExpression] Func<bool> includeAttachments = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<DetailedReceiveMessage> __BuildOnNewEmail(WorkflowExpression<string> label = null,WorkflowExpression<string> to = null,WorkflowExpression<string> from = null,WorkflowExpression<string> subject = null,WorkflowExpression<importanceInput> importance = null,WorkflowExpression<starredInput> starred = null,WorkflowExpression<bool> fetchOnlyWithAttachments = null,WorkflowExpression<bool> includeAttachments = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(label, nameof(label), required: false);
            WorkflowExpression.Validate(to, nameof(to), required: false);
            WorkflowExpression.Validate(from, nameof(from), required: false);
            WorkflowExpression.Validate(subject, nameof(subject), required: false);
            WorkflowExpression.Validate(importance, nameof(importance), required: false);
            WorkflowExpression.Validate(starred, nameof(starred), required: false);
            WorkflowExpression.Validate(fetchOnlyWithAttachments, nameof(fetchOnlyWithAttachments), required: false);
            WorkflowExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            return new DeferredBodyTrigger<DetailedReceiveMessage>(() =>
            {
                var apiCallPath = "/Mail/OnNewEmail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["label"] = Convert.ToString("INBOX");
                if (label != null)
                    callPayload.Queries["label"] = ExpressionConverter.Convert(label);
                if (to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (subject != null)
                    callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
                callPayload.Queries["importance"] = Convert.ToString("All");
                if (importance != null)
                    callPayload.Queries["importance"] = ExpressionConverter.Convert(importance);
                callPayload.Queries["starred"] = Convert.ToString("All");
                if (starred != null)
                    callPayload.Queries["starred"] = ExpressionConverter.Convert(starred);
                callPayload.Queries["fetchOnlyWithAttachments"] = Convert.ToString(false);
                if (fetchOnlyWithAttachments != null)
                    callPayload.Queries["fetchOnlyWithAttachments"] = ExpressionConverter.Convert(fetchOnlyWithAttachments);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
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