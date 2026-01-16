//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gmail
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GmailActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IBodyWorkflowAction<DetailedReceiveMessage> GetEmail(Expression<Func<string>> id, Expression<Func<bool>> includeAttachments = null)
        {
            var apiCallPath = String.Format("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = ExpressionConverter.Convert(includeAttachments);
            return new ApiConnectionAction<DetailedReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Mail/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction SendEmailV2(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<string>> emailMessagesubject = null, Expression<Func<string>> emailMessagebody = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<Attachment[]>> emailMessageattachments = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction ReplyToV2(Expression<Func<string>> id, Expression<Func<string>> replyMessageto = null, Expression<Func<string>> replyMessagecC = null, Expression<Func<string>> replyMessagebCC = null, Expression<Func<string>> replyMessagesubject = null, Expression<Func<string>> replyMessagebody = null, Expression<Func<bool>> replyMessagereplyAll = null, Expression<Func<replyMessageimportanceInput>> replyMessageimportance = null, Expression<Func<Attachment[]>> replyMessageattachments = null)
        {
            var apiCallPath = String.Format("/v2/Mail/ReplyTo/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction TrashEmail(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/Mail/{0}/trash", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class GmailTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<DetailedReceiveMessage> OnNewEmail(Expression<Func<string>> label = null, Expression<Func<string>> to = null, Expression<Func<string>> from = null, Expression<Func<string>> subject = null, Expression<Func<importanceInput>> importance = null, Expression<Func<starredInput>> starred = null, Expression<Func<bool>> fetchOnlyWithAttachments = null, Expression<Func<bool>> includeAttachments = null, string triggerName = null)
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
            return new ApiConnectionTrigger<DetailedReceiveMessage>(callPayload);
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

    public enum emailMessageimportanceInput
    {
        Normal,
        Low,
        High
    }

    public enum replyMessageimportanceInput
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