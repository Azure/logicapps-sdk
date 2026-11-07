//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Edataliasignonlineip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EdataliasignonlineipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edataliasignonlineip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetEvidenceSignedDocument(Expression<Func<string>> documentSetId)
        {
            var __workflow_documentSetId = WorkflowExpression.Compile(documentSetId, nameof(documentSetId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/PSC/v40/DocumentSet/Evidences/{0}", __workflow_documentSetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edataliasignonlineip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSignedDocument(Expression<Func<string>> documentSetId)
        {
            var __workflow_documentSetId = WorkflowExpression.Compile(documentSetId, nameof(documentSetId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/PSC/v40/DocumentSet/Document/{0}", __workflow_documentSetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edataliasignonlineip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetSignedDocumentMultiple(Expression<Func<string>> documentSetId, Expression<Func<string>> documentId)
        {
            var __workflow_documentSetId = WorkflowExpression.Compile(documentSetId, nameof(documentSetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/PSC/v40/DocumentSet/document/{0}/{1}", __workflow_documentSetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "edataliasignonlineip")]
        public IBodyWorkflowAction<GetEnvelopDetailsResponse, ApiConnectionActionConfiguration> GetEnvelopDetails(Expression<Func<string>> documentSetId)
        {
            var __workflow_documentSetId = WorkflowExpression.Compile(documentSetId, nameof(documentSetId), required: true);
            return new DeferredBodyAction<GetEnvelopDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/PSC/v40/DocumentSet/{0}", __workflow_documentSetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEnvelopDetailsResponse>(callPayload);
            });
        }
    }

    public class EdataliasignonlineipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetEnvelopDetailsResponse
    {
        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("senderMail")]
        public string SenderMail { get; set; }

        [JsonProperty("documentSetName")]
        public string DocumentSetName { get; set; }

        [JsonProperty("documentSetReference")]
        public string DocumentSetReference { get; set; }

        [JsonProperty("documentSetId")]
        public string DocumentSetId { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("estimatedPurgationDate")]
        public string EstimatedPurgationDate { get; set; }

        [JsonProperty("purgated")]
        public bool Purgated { get; set; }

        [JsonProperty("purgationDate")]
        public string PurgationDate { get; set; }

        [JsonProperty("sendMethod")]
        public int SendMethod { get; set; }

        [JsonProperty("reminderDays")]
        public int ReminderDays { get; set; }

        [JsonProperty("expireDays")]
        public int ExpireDays { get; set; }

        [JsonProperty("listDatesReminderDays")]
        public string[] ListDatesReminderDays { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("statusTime")]
        public string StatusTime { get; set; }

        [JsonProperty("documents")]
        public GetEnvelopDetailsResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("recipients")]
        public GetEnvelopDetailsResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class GetEnvelopDetailsResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class GetEnvelopDetailsResponseRecipientsTypeItem
    {
        [JsonProperty("recipientid")]
        public string Recipientid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("cardId")]
        public string CardId { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("authType")]
        public int AuthType { get; set; }

        [JsonProperty("recipientActions")]
        public GetEnvelopDetailsResponseRecipientsTypeItemRecipientActionsTypeItem[] RecipientActions { get; set; }

        [JsonProperty("attachments")]
        public GetEnvelopDetailsResponseRecipientsTypeItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class GetEnvelopDetailsResponseRecipientsTypeItemRecipientActionsTypeItem
    {
        [JsonProperty("actionType")]
        public int ActionType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("actionStatus")]
        public int ActionStatus { get; set; }

        [JsonProperty("statusTime")]
        public string StatusTime { get; set; }
    }

    public class GetEnvelopDetailsResponseRecipientsTypeItemAttachmentsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("files")]
        public GetEnvelopDetailsResponseRecipientsTypeItemAttachmentsTypeItemFilesTypeItem[] Files { get; set; }
    }

    public class GetEnvelopDetailsResponseRecipientsTypeItemAttachmentsTypeItemFilesTypeItem
    {
        [JsonProperty("tokenId")]
        public string TokenId { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("purgated")]
        public bool Purgated { get; set; }

        [JsonProperty("purgeDate")]
        public string PurgeDate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Edataliasignonlineip;

    public partial class WorkflowManagedActions
    {
        public EdataliasignonlineipActions Edataliasignonlineip(string connectionId) => new EdataliasignonlineipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EdataliasignonlineipTriggers Edataliasignonlineip(string connectionId) => new EdataliasignonlineipTriggers(connectionId);
    }
}