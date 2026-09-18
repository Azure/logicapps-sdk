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
        public IBodyWorkflowAction<DetailedReceiveMessage> GetEmail([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> includeAttachments = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                return callPayload;
            }

            return new ApiConnectionAction<DetailedReceiveMessage>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction DeleteEmail([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction TrashEmail([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Mail/{0}/trash", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction ReplyTo([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> replyMessageto = null, [WorkflowExpression] Func<string> replyMessagecC = null, [WorkflowExpression] Func<string> replyMessagebCC = null, [WorkflowExpression] Func<string> replyMessagesubject = null, [WorkflowExpression] Func<string> replyMessagebody = null, [WorkflowExpression] Func<bool> replyMessagereplyAll = null, [WorkflowExpression] Func<replyMessageimportanceInput> replyMessageimportance = null, [WorkflowExpression] Func<Attachment[]> replyMessageattachments = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(replyMessageto, nameof(replyMessageto), required: false);
            SourceExpression.Validate(replyMessagecC, nameof(replyMessagecC), required: false);
            SourceExpression.Validate(replyMessagebCC, nameof(replyMessagebCC), required: false);
            SourceExpression.Validate(replyMessagesubject, nameof(replyMessagesubject), required: false);
            SourceExpression.Validate(replyMessagebody, nameof(replyMessagebody), required: false);
            SourceExpression.Validate(replyMessagereplyAll, nameof(replyMessagereplyAll), required: false);
            SourceExpression.Validate(replyMessageimportance, nameof(replyMessageimportance), required: false);
            SourceExpression.Validate(replyMessageattachments, nameof(replyMessageattachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/Mail/ReplyTo/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var replyMessage = new JObject();
                var replyMessagepropCount = 0;
                if (replyMessageto != null)
                {
                    replyMessage["To"] = SourceExpressionConverter.ConvertToken(replyMessageto);
                    replyMessagepropCount++;
                }

                if (replyMessagecC != null)
                {
                    replyMessage["Cc"] = SourceExpressionConverter.ConvertToken(replyMessagecC);
                    replyMessagepropCount++;
                }

                if (replyMessagebCC != null)
                {
                    replyMessage["Bcc"] = SourceExpressionConverter.ConvertToken(replyMessagebCC);
                    replyMessagepropCount++;
                }

                if (replyMessagesubject != null)
                {
                    replyMessage["Subject"] = SourceExpressionConverter.ConvertToken(replyMessagesubject);
                    replyMessagepropCount++;
                }

                if (replyMessagebody != null)
                {
                    replyMessage["Body"] = SourceExpressionConverter.ConvertToken(replyMessagebody);
                    replyMessagepropCount++;
                }

                if (replyMessagereplyAll != null)
                {
                    replyMessage["ReplyAll"] = SourceExpressionConverter.ConvertToken(replyMessagereplyAll);
                    replyMessagepropCount++;
                }

                if (replyMessageimportance != null)
                {
                    replyMessage["Importance"] = SourceExpressionConverter.Convert(replyMessageimportance);
                    replyMessagepropCount++;
                }

                if (replyMessageattachments != null)
                {
                    replyMessage["Attachments"] = SourceExpressionConverter.ConvertToken(replyMessageattachments);
                    replyMessagepropCount++;
                }

                if (replyMessagepropCount > 0)
                {
                    callPayload.Body = replyMessage;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gmail")]
        public IWorkflowAction SendEmail([WorkflowExpression] Func<string> emailMessageto, [WorkflowExpression] Func<string> emailMessagecC = null, [WorkflowExpression] Func<string> emailMessagebCC = null, [WorkflowExpression] Func<string> emailMessagesubject = null, [WorkflowExpression] Func<string> emailMessagebody = null, [WorkflowExpression] Func<emailMessageimportanceInput> emailMessageimportance = null, [WorkflowExpression] Func<Attachment[]> emailMessageattachments = null)
        {
            SourceExpression.Validate(emailMessageto, nameof(emailMessageto), required: true);
            SourceExpression.Validate(emailMessagecC, nameof(emailMessagecC), required: false);
            SourceExpression.Validate(emailMessagebCC, nameof(emailMessagebCC), required: false);
            SourceExpression.Validate(emailMessagesubject, nameof(emailMessagesubject), required: false);
            SourceExpression.Validate(emailMessagebody, nameof(emailMessagebody), required: false);
            SourceExpression.Validate(emailMessageimportance, nameof(emailMessageimportance), required: false);
            SourceExpression.Validate(emailMessageattachments, nameof(emailMessageattachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Mail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var emailMessage = new JObject();
                var emailMessagepropCount = 0;
                emailMessagepropCount++;
                emailMessage["To"] = SourceExpressionConverter.ConvertToken(emailMessageto);
                if (emailMessagecC != null)
                {
                    emailMessage["Cc"] = SourceExpressionConverter.ConvertToken(emailMessagecC);
                    emailMessagepropCount++;
                }

                if (emailMessagebCC != null)
                {
                    emailMessage["Bcc"] = SourceExpressionConverter.ConvertToken(emailMessagebCC);
                    emailMessagepropCount++;
                }

                if (emailMessagesubject != null)
                {
                    emailMessage["Subject"] = SourceExpressionConverter.ConvertToken(emailMessagesubject);
                    emailMessagepropCount++;
                }

                if (emailMessagebody != null)
                {
                    emailMessage["Body"] = SourceExpressionConverter.ConvertToken(emailMessagebody);
                    emailMessagepropCount++;
                }

                if (emailMessageimportance != null)
                {
                    emailMessage["Importance"] = SourceExpressionConverter.Convert(emailMessageimportance);
                    emailMessagepropCount++;
                }

                if (emailMessageattachments != null)
                {
                    emailMessage["Attachments"] = SourceExpressionConverter.ConvertToken(emailMessageattachments);
                    emailMessagepropCount++;
                }

                if (emailMessagepropCount > 0)
                {
                    callPayload.Body = emailMessage;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class GmailTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<DetailedReceiveMessage> OnNewEmail([WorkflowExpression] Func<string> label = null, [WorkflowExpression] Func<string> to = null, [WorkflowExpression] Func<string> from = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<importanceInput> importance = null, [WorkflowExpression] Func<starredInput> starred = null, [WorkflowExpression] Func<bool> fetchOnlyWithAttachments = null, [WorkflowExpression] Func<bool> includeAttachments = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(label, nameof(label), required: false);
            SourceExpression.Validate(to, nameof(to), required: false);
            SourceExpression.Validate(from, nameof(from), required: false);
            SourceExpression.Validate(subject, nameof(subject), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(starred, nameof(starred), required: false);
            SourceExpression.Validate(fetchOnlyWithAttachments, nameof(fetchOnlyWithAttachments), required: false);
            SourceExpression.Validate(includeAttachments, nameof(includeAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Mail/OnNewEmail";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["label"] = Convert.ToString("INBOX");
                if (label != null)
                    callPayload.Queries["label"] = SourceExpressionConverter.ConvertO(label);
                if (to != null)
                    callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                if (from != null)
                    callPayload.Queries["from"] = SourceExpressionConverter.ConvertO(from);
                if (subject != null)
                    callPayload.Queries["subject"] = SourceExpressionConverter.ConvertO(subject);
                callPayload.Queries["importance"] = Convert.ToString("All");
                if (importance != null)
                    callPayload.Queries["importance"] = SourceExpressionConverter.Convert(importance);
                callPayload.Queries["starred"] = Convert.ToString("All");
                if (starred != null)
                    callPayload.Queries["starred"] = SourceExpressionConverter.Convert(starred);
                callPayload.Queries["fetchOnlyWithAttachments"] = Convert.ToString(false);
                if (fetchOnlyWithAttachments != null)
                    callPayload.Queries["fetchOnlyWithAttachments"] = SourceExpressionConverter.ConvertO(fetchOnlyWithAttachments);
                callPayload.Queries["includeAttachments"] = Convert.ToString(false);
                if (includeAttachments != null)
                    callPayload.Queries["includeAttachments"] = SourceExpressionConverter.ConvertO(includeAttachments);
                return callPayload;
            }

            return new ApiConnectionTrigger<DetailedReceiveMessage>(BuildSourceInput, triggerName, recurrence);
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