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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DetailedReceiveMessage> __BuildGetEmail(WorkflowValue<string> id, WorkflowValue<bool> includeAttachments = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEmail(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTrashEmail(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReplyTo(WorkflowValue<string> id, WorkflowValue<string> replyMessageto = null, WorkflowValue<string> replyMessagecC = null, WorkflowValue<string> replyMessagebCC = null, WorkflowValue<string> replyMessagesubject = null, WorkflowValue<string> replyMessagebody = null, WorkflowValue<bool> replyMessagereplyAll = null, WorkflowValue<replyMessageimportanceInput> replyMessageimportance = null, WorkflowValue<Attachment[]> replyMessageattachments = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(replyMessageto, nameof(replyMessageto), required: false);
            WorkflowValue.Validate(replyMessagecC, nameof(replyMessagecC), required: false);
            WorkflowValue.Validate(replyMessagebCC, nameof(replyMessagebCC), required: false);
            WorkflowValue.Validate(replyMessagesubject, nameof(replyMessagesubject), required: false);
            WorkflowValue.Validate(replyMessagebody, nameof(replyMessagebody), required: false);
            WorkflowValue.Validate(replyMessagereplyAll, nameof(replyMessagereplyAll), required: false);
            WorkflowValue.Validate(replyMessageimportance, nameof(replyMessageimportance), required: false);
            WorkflowValue.Validate(replyMessageattachments, nameof(replyMessageattachments), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEmail(WorkflowValue<string> emailMessageto, WorkflowValue<string> emailMessagecC = null, WorkflowValue<string> emailMessagebCC = null, WorkflowValue<string> emailMessagesubject = null, WorkflowValue<string> emailMessagebody = null, WorkflowValue<emailMessageimportanceInput> emailMessageimportance = null, WorkflowValue<Attachment[]> emailMessageattachments = null)
        {
            WorkflowValue.Validate(emailMessageto, nameof(emailMessageto), required: true);
            WorkflowValue.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            WorkflowValue.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            WorkflowValue.Validate(emailMessagesubject, nameof(emailMessagesubject), required: false);
            WorkflowValue.Validate(emailMessagebody, nameof(emailMessagebody), required: false);
            WorkflowValue.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            WorkflowValue.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
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
        public IBodyWorkflowTrigger<DetailedReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> label = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<starredInput> starred = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachments = null, [WorkflowExpression] Func<bool> includeAttachments = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<DetailedReceiveMessage> __BuildOnNewEmail(WorkflowValue<string> label = null, WorkflowValue<string> to = null, WorkflowValue<string> from = null, WorkflowValue<string> subject = null, WorkflowValue<importanceInput> importance = null, WorkflowValue<starredInput> starred = null, WorkflowValue<bool> fetchOnlyWithAttachments = null, WorkflowValue<bool> includeAttachments = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(label, nameof(label), required: false);
            WorkflowValue.Validate(to, nameof(to), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(subject, nameof(subject), required: false);
            WorkflowValue.Validate(importance, nameof(importance), required: false);
            WorkflowValue.Validate(starred, nameof(starred), required: false);
            WorkflowValue.Validate(fetchOnlyWithAttachments, nameof(fetchOnlyWithAttachments), required: false);
            WorkflowValue.Validate(includeAttachments, nameof(includeAttachments), required: false);
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
                return new ApiConnectionTrigger<DetailedReceiveMessage>(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum replyMessageimportanceInput
    {
        Normal,
        Low,
        High
    }

    public enum emailMessageimportanceInput
    {
        Normal,
        Low,
        High
    }

    public enum importanceInput
    {
        All,
        Important,
        [EnumMember(Value = "Not important")]
        NotImportant
    }

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
