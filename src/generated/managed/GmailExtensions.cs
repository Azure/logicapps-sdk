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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            return new ApiConnectionAction<DetailedReceiveMessage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction DeleteEmail(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction TrashEmail(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/Mail/{0}/trash", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction ReplyTo(Expression<Func<string>> id, Expression<Func<string>> replyMessageto = null, Expression<Func<string>> replyMessagecC = null, Expression<Func<string>> replyMessagebCC = null, Expression<Func<string>> replyMessagesubject = null, Expression<Func<string>> replyMessagebody = null, Expression<Func<bool>> replyMessagereplyAll = null, Expression<Func<replyMessageimportanceInput>> replyMessageimportance = null, Expression<Func<Attachment[]>> replyMessageattachments = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/Mail/ReplyTo/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var replyMessage = new JObject();
            var replyMessagepropCount = 0;
            if (replyMessageto != null)
            {
                replyMessage["To"] = CSharpExpressionConverter.ConvertToken(replyMessageto);
                replyMessagepropCount++;
            }

            if (replyMessagecC != null)
            {
                replyMessage["Cc"] = CSharpExpressionConverter.ConvertToken(replyMessagecC);
                replyMessagepropCount++;
            }

            if (replyMessagebCC != null)
            {
                replyMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(replyMessagebCC);
                replyMessagepropCount++;
            }

            if (replyMessagesubject != null)
            {
                replyMessage["Subject"] = CSharpExpressionConverter.ConvertToken(replyMessagesubject);
                replyMessagepropCount++;
            }

            if (replyMessagebody != null)
            {
                replyMessage["Body"] = CSharpExpressionConverter.ConvertToken(replyMessagebody);
                replyMessagepropCount++;
            }

            if (replyMessagereplyAll != null)
            {
                replyMessage["ReplyAll"] = CSharpExpressionConverter.ConvertToken(replyMessagereplyAll);
                replyMessagepropCount++;
            }

            if (replyMessageimportance != null)
            {
                replyMessage["Importance"] = CSharpExpressionConverter.Convert(replyMessageimportance);
                replyMessagepropCount++;
            }

            if (replyMessageattachments != null)
            {
                replyMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(replyMessageattachments);
                replyMessagepropCount++;
            }

            if (replyMessagepropCount > 0)
            {
                callPayload.Body = replyMessage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction SendEmail(Expression<Func<string>> emailMessageto, Expression<Func<string>> emailMessagecC = null, Expression<Func<string>> emailMessagebCC = null, Expression<Func<string>> emailMessagesubject = null, Expression<Func<string>> emailMessagebody = null, Expression<Func<emailMessageimportanceInput>> emailMessageimportance = null, Expression<Func<Attachment[]>> emailMessageattachments = null)
        {
            var apiCallPath = "/v2/Mail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var emailMessage = new JObject();
            var emailMessagepropCount = 0;
            emailMessagepropCount++;
            emailMessage["To"] = CSharpExpressionConverter.ConvertToken(emailMessageto);
            if (emailMessagecC != null)
            {
                emailMessage["Cc"] = CSharpExpressionConverter.ConvertToken(emailMessagecC);
                emailMessagepropCount++;
            }

            if (emailMessagebCC != null)
            {
                emailMessage["Bcc"] = CSharpExpressionConverter.ConvertToken(emailMessagebCC);
                emailMessagepropCount++;
            }

            if (emailMessagesubject != null)
            {
                emailMessage["Subject"] = CSharpExpressionConverter.ConvertToken(emailMessagesubject);
                emailMessagepropCount++;
            }

            if (emailMessagebody != null)
            {
                emailMessage["Body"] = CSharpExpressionConverter.ConvertToken(emailMessagebody);
                emailMessagepropCount++;
            }

            if (emailMessageimportance != null)
            {
                emailMessage["Importance"] = CSharpExpressionConverter.Convert(emailMessageimportance);
                emailMessagepropCount++;
            }

            if (emailMessageattachments != null)
            {
                emailMessage["Attachments"] = CSharpExpressionConverter.ConvertToken(emailMessageattachments);
                emailMessagepropCount++;
            }

            if (emailMessagepropCount > 0)
            {
                callPayload.Body = emailMessage;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class GmailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<DetailedReceiveMessage> OnNewEmail(Expression<Func<string>> label = null, Expression<Func<string>> to = null, Expression<Func<string>> from = null, Expression<Func<string>> subject = null, Expression<Func<importanceInput>> importance = null, Expression<Func<starredInput>> starred = null, Expression<Func<bool>> fetchOnlyWithAttachments = null, Expression<Func<bool>> includeAttachments = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/Mail/OnNewEmail";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["label"] = Convert.ToString("INBOX");
            if (label != null)
                callPayload.Queries["label"] = CSharpExpressionConverter.ConvertO(label);
            if (to != null)
                callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            if (from != null)
                callPayload.Queries["from"] = CSharpExpressionConverter.ConvertO(from);
            if (subject != null)
                callPayload.Queries["subject"] = CSharpExpressionConverter.ConvertO(subject);
            callPayload.Queries["importance"] = Convert.ToString("All");
            if (importance != null)
                callPayload.Queries["importance"] = CSharpExpressionConverter.Convert(importance);
            callPayload.Queries["starred"] = Convert.ToString("All");
            if (starred != null)
                callPayload.Queries["starred"] = CSharpExpressionConverter.Convert(starred);
            callPayload.Queries["fetchOnlyWithAttachments"] = Convert.ToString(false);
            if (fetchOnlyWithAttachments != null)
                callPayload.Queries["fetchOnlyWithAttachments"] = CSharpExpressionConverter.ConvertO(fetchOnlyWithAttachments);
            callPayload.Queries["includeAttachments"] = Convert.ToString(false);
            if (includeAttachments != null)
                callPayload.Queries["includeAttachments"] = CSharpExpressionConverter.ConvertO(includeAttachments);
            return new ApiConnectionTrigger<DetailedReceiveMessage>(callPayload, triggerName, recurrence);
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