//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Foxitesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FoxitesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CreateEnvelopefromURLResponse, ApiConnectionActionConfiguration> CreateEnvelopefromURL(Expression<Func<CreateEnvelopefromURLInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEnvelopefromURLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/createfolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEnvelopefromURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetEnvelopeDetailsResponse, ApiConnectionActionConfiguration> GetEnvelopeDetails(Expression<Func<int>> folderId, Expression<Func<string>> accessToken = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_accessToken = WorkflowExpression.Compile(accessToken, nameof(accessToken), required: false);
            return new DeferredBodyAction<GetEnvelopeDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/myfolder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                if (__workflow_accessToken != null)
                    callPayload.Queries["access_token"] = ExpressionConverter.Convert(__workflow_accessToken);
                return new ApiConnectionAction<GetEnvelopeDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetEnvelopeIdsResponse, ApiConnectionActionConfiguration> GetEnvelopeIds(Expression<Func<string>> dateFrom, Expression<Func<string>> dateTo, Expression<Func<statusInput>> status = null)
        {
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: true);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<GetEnvelopeIdsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/getAllFolderIdsByStatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["dateFrom"] = ExpressionConverter.Convert(__workflow_dateFrom);
                callPayload.Queries["dateTo"] = ExpressionConverter.Convert(__workflow_dateTo);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<GetEnvelopeIdsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<SendSignatureReminderResponse, ApiConnectionActionConfiguration> SendSignatureReminder(Expression<Func<SendSignatureReminderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSignatureReminderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/signaturereminder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSignatureReminderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadEnvelopeFiles(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<MoveEnvelopestoRecycleBinResponse, ApiConnectionActionConfiguration> MoveEnvelopestoRecycleBin(Expression<Func<EnvelopeIdentifiers[]>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveEnvelopestoRecycleBinResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/movetorecyclebin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveEnvelopestoRecycleBinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetEnvelopeActivityHistoryResponse, ApiConnectionActionConfiguration> GetEnvelopeActivityHistory(Expression<Func<int>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<GetEnvelopeActivityHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/viewActivityHistory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<GetEnvelopeActivityHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadSingleDocumentPDF(Expression<Func<string>> folderId, Expression<Func<string>> docNumber)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_docNumber = WorkflowExpression.Compile(docNumber, nameof(docNumber), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/document/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["docNumber"] = ExpressionConverter.Convert(__workflow_docNumber);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetDeletedEnvelopeHistoryResponse, ApiConnectionActionConfiguration> GetDeletedEnvelopeHistory(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<GetDeletedEnvelopeHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/deletedLog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<GetDeletedEnvelopeHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CancelEnvelopeResponse, ApiConnectionActionConfiguration> CancelEnvelope(Expression<Func<CancelEnvelopeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CancelEnvelopeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/cancelFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CancelEnvelopeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<DeleteEnvelopesResponse, ApiConnectionActionConfiguration> DeleteEnvelopes(Expression<Func<DeleteEnvelopesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteEnvelopesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteEnvelopesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetTemplatesbyTemplateIdsResponse, ApiConnectionActionConfiguration> GetTemplatesbyTemplateIds(Expression<Func<GetTemplatesbyTemplateIdsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetTemplatesbyTemplateIdsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/templateDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetTemplatesbyTemplateIdsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetTemplateDetailsResponse, ApiConnectionActionConfiguration> GetTemplateDetails(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<GetTemplateDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/mytemplate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = ExpressionConverter.Convert(__workflow_templateId);
                return new ApiConnectionAction<GetTemplateDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetalistofallTemplatesResponse, ApiConnectionActionConfiguration> GetalistofallTemplates()
        {
            return new DeferredBodyAction<GetalistofallTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetalistofallTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CreateTemplatefromURLResponse, ApiConnectionActionConfiguration> CreateTemplatefromURL(Expression<Func<CreateTemplatefromURLInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTemplatefromURLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/createtemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTemplatefromURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CreateTemplatefromBase64Response, ApiConnectionActionConfiguration> CreateTemplatefromBase64(Expression<Func<CreateTemplatefromBase64Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTemplatefromBase64Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/createtemplatefrombase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTemplatefromBase64Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CreateEnvelopefromTemplateResponse, ApiConnectionActionConfiguration> CreateEnvelopefromTemplate(Expression<Func<CreateEnvelopefromTemplateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEnvelopefromTemplateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates/createFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEnvelopefromTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTriggerWebhookChannel(Expression<Func<int>> channelId)
        {
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/deletechannel/{0}", __workflow_channelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<ListallWebhookChannelsResponse, ApiConnectionActionConfiguration> ListallWebhookChannels()
        {
            return new DeferredBodyAction<ListallWebhookChannelsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhook/channellist";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListallWebhookChannelsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetWebhookChannelDetailsResponse, ApiConnectionActionConfiguration> GetWebhookChannelDetails(Expression<Func<string>> channelId)
        {
            var __workflow_channelId = WorkflowExpression.Compile(channelId, nameof(channelId), required: true);
            return new DeferredBodyAction<GetWebhookChannelDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhook/mychannel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["channelId"] = ExpressionConverter.Convert(__workflow_channelId);
                return new ApiConnectionAction<GetWebhookChannelDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CreateEmailGroupResponse, ApiConnectionActionConfiguration> CreateEmailGroup(Expression<Func<CreateEmailGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEmailGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/parties/createEmailGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEmailGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<GetEmailGroupDetailsResponse, ApiConnectionActionConfiguration> GetEmailGroupDetails(Expression<Func<GetEmailGroupDetailsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetEmailGroupDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/parties/getEmailGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetEmailGroupDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadReport(Expression<Func<DownloadReportInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/getFolders/download";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/vnd.ms-excel");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "foxitesign")]
        public IBodyWorkflowAction<CreateEnvelopefromBase64Response, ApiConnectionActionConfiguration> CreateEnvelopefromBase64(Expression<Func<CreateEnvelopefromBase64Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateEnvelopefromBase64Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/createfolderfrombase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateEnvelopefromBase64Response>(callPayload);
            });
        }
    }

    public class FoxitesignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration> TriggerEnvelopeSent(Expression<Func<TriggerEnvelopeSentInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/trigger/envelope_sent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookEventPayload>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration> TriggerEnvelopeViewed(Expression<Func<TriggerEnvelopeViewedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/trigger/envelope_viewed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookEventPayload>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration> TriggerEnvelopeSigned(Expression<Func<TriggerEnvelopeSignedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/trigger/envelope_signed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookEventPayload>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration> TriggerEnvelopeCancelled(Expression<Func<TriggerEnvelopeCancelledInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/trigger/envelope_cancelled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookEventPayload>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration> TriggerEnvelopeExecuted(Expression<Func<TriggerEnvelopeExecutedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/trigger/envelope_executed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookEventPayload>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration> TriggerEnvelopeDeleted(Expression<Func<TriggerEnvelopeDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookEventPayload, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhook/trigger/envelope_deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookEventPayload>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateEnvelopefromURLResponse
    {
        [JsonProperty("folder")]
        public CreateEnvelopefromURLResponseEnvelopeType Envelope { get; set; }

        [JsonProperty("embeddedSigningSessions")]
        public CreateEnvelopefromURLResponseEmbeddedSigningSessionsTypeItem[] EmbeddedSigningSessions { get; set; }

        [JsonProperty("embeddedToken")]
        public string EmbeddedSendingToken { get; set; }

        [JsonProperty("embeddedSessionURL")]
        public string SendingSessionURL { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateEnvelopefromURLResponseEnvelopeType
    {
        [JsonProperty("envelopeId")]
        public int Id { get; set; }

        [JsonProperty("envelopeName")]
        public string Name { get; set; }

        [JsonProperty("folderCustomName")]
        public string CustomName { get; set; }

        [JsonProperty("folderPassword")]
        public string Password { get; set; }

        [JsonProperty("folderAuthorId")]
        public int CreatorId { get; set; }

        [JsonProperty("folderAuthorFirstName")]
        public string CreatorFirstName { get; set; }

        [JsonProperty("folderAuthorLastName")]
        public string CreatorLastName { get; set; }

        [JsonProperty("folderAuthorEmail")]
        public string CreatorEmail { get; set; }

        [JsonProperty("folderAuthorRole")]
        public string CreatorRole { get; set; }

        [JsonProperty("envelopeCompanyId")]
        public int CompanyId { get; set; }

        [JsonProperty("folderCreationDate")]
        public int CreatedDate { get; set; }

        [JsonProperty("folderSentDate")]
        public int SentDate { get; set; }

        [JsonProperty("envelopeStatus")]
        public string Status { get; set; }

        [JsonProperty("custom_field1")]
        public string CustomField1 { get; set; }

        [JsonProperty("custom_field2")]
        public string CustomField2 { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("folderDocumentIds")]
        public int[] DocumentIDs { get; set; }

        [JsonProperty("documentsList")]
        public CreateEnvelopefromURLResponseEnvelopeTypeDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("folderRecipientParties")]
        public CreateEnvelopefromURLResponseEnvelopeTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("folderAccessURLForAuthor")]
        public string AuthorSigningURL { get; set; }

        [JsonProperty("draftFolderAccessURL")]
        public string DraftAccessURL { get; set; }

        [JsonProperty("boardRoomSign")]
        public bool BoardroomSigning { get; set; }

        [JsonProperty("includeLogo")]
        public bool IncludeLogo { get; set; }

        [JsonProperty("email_btnBgColor")]
        public string ButtonBackgroundColor { get; set; }

        [JsonProperty("email_btnTxtColor")]
        public string ButtonTextColor { get; set; }

        [JsonProperty("emailTemplateLogo")]
        public string EmailLogo { get; set; }

        [JsonProperty("emailTemplateId")]
        public int EmailTemplateId { get; set; }

        [JsonProperty("emailHeader")]
        public string EmailHeader { get; set; }

        [JsonProperty("emailFooter")]
        public string EmailFooter { get; set; }

        [JsonProperty("purgeFlag")]
        public bool PurgeScheduled { get; set; }

        [JsonProperty("purgeStartDate")]
        public string PurgeStartDate { get; set; }

        [JsonProperty("purgeEndDate")]
        public string PurgeEndDate { get; set; }

        [JsonProperty("bulkId")]
        public int BulkSendId { get; set; }

        [JsonProperty("enforceSignWorkflow")]
        public bool EnforceSignOrder { get; set; }

        [JsonProperty("currentWorkflowStep")]
        public int CurrentStep { get; set; }

        [JsonProperty("transactionSource")]
        public string TransactionSource { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("inPersonSignable")]
        public bool InPersonSigning { get; set; }

        [JsonProperty("overrideAccountReminders")]
        public bool OverrideReminders { get; set; }

        [JsonProperty("overrideAccountRecipientDelegation")]
        public bool OverrideDelegation { get; set; }

        [JsonProperty("allowRecipientsToDelegate")]
        public bool AllowDelegation { get; set; }

        [JsonProperty("envelopeOriginatorId")]
        public int OriginatorId { get; set; }

        [JsonProperty("envelopeDate")]
        public int Date { get; set; }

        [JsonProperty("envelopeSharedDate")]
        public int SharedDate { get; set; }

        [JsonProperty("envelopeContractIds")]
        public int[] ContractIDs { get; set; }

        [JsonProperty("envelopePartyPermissions")]
        public CreateEnvelopefromURLResponseEnvelopeTypeRecipientPermissionsTypeItem[] RecipientPermissions { get; set; }

        [JsonProperty("envelopeAuthenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("allowSingleSignerInBulk")]
        public bool SingleSignerBulk { get; set; }

        [JsonProperty("folderNameBasedOnFileNaming")]
        public bool FileBasedNaming { get; set; }

        [JsonProperty("documentNameBasedOnFileNaming")]
        public bool DocFileBasedName { get; set; }

        [JsonProperty("certificateNameBasedOnFileNaming")]
        public bool CertFileBasedName { get; set; }

        [JsonProperty("enableFileNamingBeforeExecution")]
        public bool PreExecFileNaming { get; set; }

        [JsonProperty("payeeAddedd")]
        public bool PayeeAdded { get; set; }

        [JsonProperty("selfSignerEnabled")]
        public bool SelfSigningEnabled { get; set; }

        [JsonProperty("notaryEnabled")]
        public bool NotaryEnabled { get; set; }

        [JsonProperty("limitedVisibilityFlag")]
        public bool LimitedVisibility { get; set; }

        [JsonProperty("postSigningVisibility")]
        public bool PostSignVisibility { get; set; }

        [JsonProperty("wetSignatureEnabled")]
        public bool WetSignature { get; set; }

        [JsonProperty("mergeEnabled")]
        public bool MergeEnabled { get; set; }
    }

    public class CreateEnvelopefromURLResponseEnvelopeTypeDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("contractId")]
        public int ContractId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("contractCreatedBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("contractCreatedOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("contractStatus")]
        public string ContractStatus { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("contractVersionId")]
        public int VersionId { get; set; }

        [JsonProperty("contractVersionName")]
        public string VersionName { get; set; }

        [JsonProperty("contractVersionDesc")]
        public string VersionDescription { get; set; }

        [JsonProperty("versionCreatedby")]
        public int VersionCreatedBy { get; set; }

        [JsonProperty("versionCreatedOn")]
        public string VersionCreatedOn { get; set; }

        [JsonProperty("contractVersionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("contractTransactionSource")]
        public string TransactionSource { get; set; }
    }

    public class CreateEnvelopefromURLResponseEnvelopeTypeRecipientsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public CreateEnvelopefromURLResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int RecipientCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string RecipientAccessURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string Comments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string SignerAuthLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyField { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleField { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PaymentFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool Payee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringPayment { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignDone { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("allowOptionalSigner")]
        public bool OptionalSignerAllowed { get; set; }

        [JsonProperty("optionalSigners")]
        public int[] OptionalSigners { get; set; }
    }

    public class CreateEnvelopefromURLResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string EmailAddress { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniqueRecipientId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("passwordUpdateDate")]
        public string PasswordUpdatedDate { get; set; }

        [JsonProperty("passwordUpdateStatus")]
        public bool PasswordUpdatedStatus { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("requestLocale")]
        public string Locale { get; set; }

        [JsonProperty("share_among_department")]
        public bool ShareWithDept { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("docStatusFilter")]
        public string StatusFilter { get; set; }

        [JsonProperty("docDateFilter")]
        public string DateFilter { get; set; }

        [JsonProperty("userSecureFieldAccess")]
        public bool SecureFieldAccess { get; set; }

        [JsonProperty("expandSidebar")]
        public bool ExpandSidebar { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool AdvEmailValidation { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("loginCount")]
        public int LoginCount { get; set; }

        [JsonProperty("sendMailForPasswordReset")]
        public bool PasswordResetEmail { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("userPrimaryCompany")]
        public int PrimaryCompany { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("subcontractorDescription")]
        public string SubcontractorDescription { get; set; }

        [JsonProperty("subcontractorOrganization")]
        public string SubcontractorOrganization { get; set; }

        [JsonProperty("subcAddedDate")]
        public int SubcontractorAddedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CreateEnvelopefromURLResponseEnvelopeTypeRecipientPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public CreateEnvelopefromURLResponseEnvelopeTypeRecipientPermissionsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int RecipientCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string RecipientAccessURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string Comments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string SignerAuthLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyField { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleField { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PaymentFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool Payee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringPayment { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignDone { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }
    }

    public class CreateEnvelopefromURLResponseEnvelopeTypeRecipientPermissionsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string EmailAddress { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniqueRecipientId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("passwordUpdateDate")]
        public string PasswordUpdatedDate { get; set; }

        [JsonProperty("passwordUpdateStatus")]
        public bool PasswordUpdatedStatus { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("requestLocale")]
        public string Locale { get; set; }

        [JsonProperty("share_among_department")]
        public bool ShareWithDept { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("docStatusFilter")]
        public string StatusFilter { get; set; }

        [JsonProperty("docDateFilter")]
        public string DateFilter { get; set; }

        [JsonProperty("userSecureFieldAccess")]
        public bool SecureFieldAccess { get; set; }

        [JsonProperty("expandSidebar")]
        public bool ExpandSidebar { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool AdvEmailValidation { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("loginCount")]
        public int LoginCount { get; set; }

        [JsonProperty("sendMailForPasswordReset")]
        public bool PasswordResetEmail { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("userPrimaryCompany")]
        public int PrimaryCompany { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("subcontractorDescription")]
        public string SubcontractorDescription { get; set; }

        [JsonProperty("subcontractorOrganization")]
        public string SubcontractorOrganization { get; set; }

        [JsonProperty("subcAddedDate")]
        public int SubcontractorAddedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CreateEnvelopefromURLResponseEmbeddedSigningSessionsTypeItem
    {
        [JsonProperty("emailIdOfSigner")]
        public string SignerEmail { get; set; }

        [JsonProperty("embeddedToken")]
        public string SigningToken { get; set; }

        [JsonProperty("embeddedSessionURL")]
        public string SigningSessionURL { get; set; }
    }

    public class CreateEnvelopefromURLInput
    {
        [JsonProperty("folderName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnvelopeName { get; set; }

        [JsonProperty("inputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputType { get; set; } = "url";

        [JsonProperty("fileUrls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] FileUrls { get; set; }

        [JsonProperty("fileNames", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] FileNames { get; set; }

        [JsonProperty("parties", DefaultValueHandling = DefaultValueHandling.Include)]
        public Party[] Parties { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("sendNow", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendNow { get; set; } = true;

        [JsonProperty("createEmbeddedSigningSession", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CreateEmbeddedSigningSession { get; set; }

        [JsonProperty("createEmbeddedSigningSessionForAllParties")]
        public bool? CreateEmbeddedSigningSessionForAllParties { get; set; }

        [JsonProperty("processTextTags", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessTextTags { get; set; }

        [JsonProperty("processAcroFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessAcroFields { get; set; }

        [JsonProperty("signInSequence")]
        public bool? SignInSequence { get; set; }

        [JsonProperty("inPersonEnable")]
        public bool? InPersonEnable { get; set; }

        [JsonProperty("fixRecipientParties")]
        public bool? FixRecipientParties { get; set; }

        [JsonProperty("fixDocuments")]
        public bool? FixDocuments { get; set; }

        [JsonProperty("sendSuccessUrl")]
        public string SendSuccessUrl { get; set; }

        [JsonProperty("sendErrorUrl")]
        public string SendErrorUrl { get; set; }

        [JsonProperty("createEmbeddedSendingSession")]
        public bool? CreateEmbeddedSendingSession { get; set; }

        [JsonProperty("embeddedSignersEmailIds")]
        public string[] EmbeddedSignersEmailIds { get; set; }

        [JsonProperty("signSuccessUrl")]
        public string SignSuccessUrl { get; set; }

        [JsonProperty("signDeclineUrl")]
        public string SignDeclineUrl { get; set; }

        [JsonProperty("signLaterUrl")]
        public string SignLaterUrl { get; set; }

        [JsonProperty("signErrorUrl")]
        public string SignErrorUrl { get; set; }

        [JsonProperty("allowSendNowAndEmbeddedSigningSession")]
        public bool? AllowSendNowAndEmbeddedSigningSession { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool? AdvancedEmailValidation { get; set; }

        [JsonProperty("signSuccessUrlAllParties")]
        public bool? SignSuccessUrlAllParties { get; set; }

        [JsonProperty("emailTemplateId")]
        public int? EmailTemplateId { get; set; }

        [JsonProperty("signerInstructionId")]
        public int? SignerInstructionId { get; set; }

        [JsonProperty("confirmationInstructionId")]
        public string ConfirmationInstructionId { get; set; }

        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }

        [JsonProperty("sessionExpire")]
        public bool? SessionExpire { get; set; }

        [JsonProperty("expiry")]
        public int? Expiry { get; set; }

        [JsonProperty("dependentFields")]
        public DependentField DependentFields { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("hideAddMeButton")]
        public bool? HideAddMeButton { get; set; }

        [JsonProperty("hideAddNewButton")]
        public bool? HideAddNewButton { get; set; }

        [JsonProperty("hideAddGroupButton")]
        public bool? HideAddGroupButton { get; set; }

        [JsonProperty("hideFieldNameForRecipients")]
        public bool? HideFieldNameForRecipients { get; set; }

        [JsonProperty("hideCheckboxBorder")]
        public bool? HideCheckboxBorder { get; set; }

        [JsonProperty("hideSignerSelectOption")]
        public bool? HideSignerSelectOption { get; set; }

        [JsonProperty("hideSignerActions")]
        public bool? HideSignerActions { get; set; }

        [JsonProperty("hideSenderName")]
        public bool? HideSenderName { get; set; }

        [JsonProperty("hideFolderName")]
        public bool? HideFolderName { get; set; }

        [JsonProperty("hideDocumentsName")]
        public bool? HideDocumentsName { get; set; }

        [JsonProperty("hideDeclineToSign")]
        public bool? HideDeclineToSign { get; set; }

        [JsonProperty("hideMoreAction")]
        public bool? HideMoreAction { get; set; }

        [JsonProperty("hideSendButton")]
        public bool? HideSendButton { get; set; }

        [JsonProperty("hideNextRequiredFieldbtn")]
        public bool? HideNextRequiredFieldbtn { get; set; }

        [JsonProperty("requiredBothEmbeddedSession")]
        public bool? RequiredBothEmbeddedSession { get; set; }

        [JsonProperty("folderPassword")]
        public string EnvelopePassword { get; set; }

        [JsonProperty("enableStepByStep")]
        public bool? EnableStepByStep { get; set; }

        [JsonProperty("hideAddPartiesOption")]
        public bool? HideAddPartiesOption { get; set; }

        [JsonProperty("selfSign")]
        public bool? SelfSign { get; set; }

        [JsonProperty("selfSignerSuccessUrl")]
        public string SelfSignerSuccessUrl { get; set; }
    }

    public class Party
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string EmailAddress { get; set; }

        [JsonProperty("permission")]
        public Permissions Permission { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("signerAuthLevel")]
        public SignerAuthLevels SignerAuthLevel { get; set; }

        [JsonProperty("isPlaceholder")]
        public bool IsPlaceholder { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }

        [JsonProperty("allowNameChange")]
        public string AllowNameChange { get; set; }

        [JsonProperty("workflowSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("hostEmailId")]
        public string HostEmailId { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("partyIsEmailGroup")]
        public bool PartyIsEmailGroup { get; set; }

        [JsonProperty("emailGroupId")]
        public int EmailGroupId { get; set; }

        [JsonProperty("allowSingleSignerInBulk")]
        public bool SingleSignerBulk { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Permissions
    {
        [EnumMember(Value = "FILL_FIELDS_AND_SIGN")]
        FILLFIELDSANDSIGN,
        [EnumMember(Value = "FILL_FIELDS_ONLY")]
        FILLFIELDSONLY,
        [EnumMember(Value = "SIGN_ONLY")]
        SIGNONLY,
        [EnumMember(Value = "VIEW_ONLY")]
        VIEWONLY,
        [EnumMember(Value = "PARTY_ASSIGNER")]
        PARTYASSIGNER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerAuthLevels
    {
        NO,
        [EnumMember(Value = "SMS LINK")]
        SMSLINK,
        [EnumMember(Value = "Email Access Code")]
        EmailAccessCode,
        [EnumMember(Value = "SMS Access Code")]
        SMSAccessCode,
        [EnumMember(Value = "Voice Access Code")]
        VoiceAccessCode,
        [EnumMember(Value = "User-defined Access Code")]
        UserDefinedAccessCode
    }

    public class DependentField
    {
        [JsonProperty("dependentFields")]
        public DependentField1[] DependentFields { get; set; }
    }

    public class DependentField1
    {
        [JsonProperty("dependentFieldName")]
        public string DependentFieldName { get; set; }

        [JsonProperty("parentFieldName")]
        public string ParentFieldName { get; set; }

        [JsonProperty("parentFieldValue")]
        public string ParentFieldValue { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }
    }

    public class GetEnvelopeDetailsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("folder")]
        public GetEnvelopeDetailsResponseEnvelopeType Envelope { get; set; }

        [JsonProperty("allFields")]
        public GetEnvelopeDetailsResponseAllFieldsTypeItem[] AllFields { get; set; }

        [JsonProperty("allFieldsNameValue")]
        public GetEnvelopeDetailsResponseFieldValuesTypeItem[] FieldValues { get; set; }

        [JsonProperty("Folder History")]
        public GetEnvelopeDetailsResponseEnvelopeHistoryTypeItem[] EnvelopeHistory { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeType
    {
        [JsonProperty("envelopeId")]
        public int Id { get; set; }

        [JsonProperty("envelopeName")]
        public string Name { get; set; }

        [JsonProperty("folderAuthorId")]
        public int AuthorId { get; set; }

        [JsonProperty("folderAuthorFirstName")]
        public string AuthorFirstName { get; set; }

        [JsonProperty("folderAuthorLastName")]
        public string AuthorLastName { get; set; }

        [JsonProperty("folderAuthorEmail")]
        public string AuthorEmail { get; set; }

        [JsonProperty("folderAuthorRole")]
        public string AuthorRole { get; set; }

        [JsonProperty("envelopeCompanyId")]
        public int CompanyId { get; set; }

        [JsonProperty("folderCreationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("folderSentDate")]
        public int SentDate { get; set; }

        [JsonProperty("envelopeStatus")]
        public string Status { get; set; }

        [JsonProperty("folderDocumentIds")]
        public int[] DocumentIDs { get; set; }

        [JsonProperty("documentsList")]
        public GetEnvelopeDetailsResponseEnvelopeTypeDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("folderRecipientParties")]
        public GetEnvelopeDetailsResponseEnvelopeTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("folderAccessURLForAuthor")]
        public string AuthorAccessURL { get; set; }

        [JsonProperty("bulkId")]
        public int BulkId { get; set; }

        [JsonProperty("enforceSignWorkflow")]
        public bool EnforceSignOrder { get; set; }

        [JsonProperty("currentWorkflowStep")]
        public int CurrentWorkflowStep { get; set; }

        [JsonProperty("transactionSource")]
        public string TransactionSource { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("inPersonSignable")]
        public bool InPersonSigning { get; set; }

        [JsonProperty("overrideAccountReminders")]
        public bool OverrideReminders { get; set; }

        [JsonProperty("envelopeOriginatorId")]
        public int OriginatorId { get; set; }

        [JsonProperty("envelopeDate")]
        public int Date { get; set; }

        [JsonProperty("envelopeSharedDate")]
        public int SharedDate { get; set; }

        [JsonProperty("envelopeContractIds")]
        public int[] ContractIDs { get; set; }

        [JsonProperty("envelopePartyPermissions")]
        public GetEnvelopeDetailsResponseEnvelopeTypePartyPermissionsTypeItem[] PartyPermissions { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeTypeDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("contractId")]
        public int ContractId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("contractCreatedBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("contractCreatedOn")]
        public int CreatedOn { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("contractStatus")]
        public string DocumentStatus { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("contractVersionId")]
        public int VersionId { get; set; }

        [JsonProperty("contractVersionName")]
        public string VersionName { get; set; }

        [JsonProperty("contractVersionDesc")]
        public string VersionDescription { get; set; }

        [JsonProperty("versionCreatedby")]
        public int VersionCreatedBy { get; set; }

        [JsonProperty("versionCreatedOn")]
        public int VersionCreatedOn { get; set; }

        [JsonProperty("contractVersionNumber")]
        public int VersionNumber { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeTypeRecipientsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public GetEnvelopeDetailsResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string SigningURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string ExtraComments { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int AccountCreatedDate { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeTypePartyPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public GetEnvelopeDetailsResponseEnvelopeTypePartyPermissionsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("folderAccessURL")]
        public string SigningURL { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeTypePartyPermissionsTypeItemRecipientDetailsType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }
    }

    public class GetEnvelopeDetailsResponseAllFieldsTypeItem
    {
        [JsonProperty("fieldTagId")]
        public int FieldId { get; set; }

        [JsonProperty("contractId")]
        public int DocumentId { get; set; }

        [JsonProperty("versionId")]
        public int VersionId { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("documentPageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("docFieldId")]
        public string FieldDocId { get; set; }

        [JsonProperty("partyResponsible")]
        public int ResponsibleParty { get; set; }

        [JsonProperty("dependent")]
        public bool IsDependent { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("value")]
        public string FieldValue { get; set; }
    }

    public class GetEnvelopeDetailsResponseFieldValuesTypeItem
    {
        [JsonProperty("fieldId")]
        public int FieldId { get; set; }

        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("documentVersionId")]
        public int VersionId { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("name")]
        public string FieldName { get; set; }

        [JsonProperty("value")]
        public string FieldValue { get; set; }
    }

    public class GetEnvelopeDetailsResponseEnvelopeHistoryTypeItem
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("dateChanged")]
        public int Date { get; set; }

        [JsonProperty("changeDoneByParty")]
        public int PartyId { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }
    }

    public class GetEnvelopeIdsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("allFolderIds")]
        public int[] EnvelopeIDs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        EXECUTED,
        SHARED,
        DRAFT,
        [EnumMember(Value = "PARTIALLY SIGNED")]
        PARTIALLYSIGNED,
        CANCELED,
        EXPIRED,
        DELETED
    }

    public class SendSignatureReminderResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("reminder sent")]
        public int EnvelopeId { get; set; }
    }

    public class SendSignatureReminderInput
    {
        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EnvelopeId { get; set; }
    }

    public class MoveEnvelopestoRecycleBinResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class EnvelopeIdentifiers
    {
        [JsonProperty("folderIds")]
        public int[] FolderIds { get; set; }
    }

    public class GetEnvelopeActivityHistoryResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("details")]
        public GetEnvelopeActivityHistoryResponseDetailsType Details { get; set; }
    }

    public class GetEnvelopeActivityHistoryResponseDetailsType
    {
        [JsonProperty("folderId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("enclosedDocuments")]
        public string EnclosedDocuments { get; set; }

        [JsonProperty("envelopeRecipients")]
        public string Recipients { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("latestActivityDate")]
        public string LatestActivityDate { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("dateSent")]
        public string DateSent { get; set; }

        [JsonProperty("activities")]
        public GetEnvelopeActivityHistoryResponseDetailsTypeActivitiesTypeItem[] Activities { get; set; }
    }

    public class GetEnvelopeActivityHistoryResponseDetailsTypeActivitiesTypeItem
    {
        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("folderStatus")]
        public string EnvelopeStatus { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("ipAddress")]
        public string IPAddress { get; set; }
    }

    public class GetDeletedEnvelopeHistoryResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("Deleted Folder Log Info")]
        public GetDeletedEnvelopeHistoryResponseDeletedEnvelopeInfoTypeItem[] DeletedEnvelopeInfo { get; set; }

        [JsonProperty("Deleted Folder Log History")]
        public GetDeletedEnvelopeHistoryResponseDeletionLogHistoryTypeItem[] DeletionLogHistory { get; set; }
    }

    public class GetDeletedEnvelopeHistoryResponseDeletedEnvelopeInfoTypeItem
    {
        [JsonProperty("folderId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("folderName")]
        public string EnvelopeName { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("deletionDate")]
        public int DeletionDate { get; set; }

        [JsonProperty("deletedBy")]
        public string DeletedBy { get; set; }
    }

    public class GetDeletedEnvelopeHistoryResponseDeletionLogHistoryTypeItem
    {
        [JsonProperty("partiesName")]
        public string PerformedBy { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }
    }

    public class CancelEnvelopeResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("folders cancelled")]
        public int[] CancelledEnvelopeIDs { get; set; }
    }

    public class CancelEnvelopeInput
    {
        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int EnvelopeId { get; set; }

        [JsonProperty("reason_for_cancellation", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReasonForCancellation { get; set; }
    }

    public class DeleteEnvelopesResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class DeleteEnvelopesInput
    {
        [JsonProperty("folderIds")]
        public int[] FolderIds { get; set; }
    }

    public class GetTemplatesbyTemplateIdsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("total_templates")]
        public int TotalTemplates { get; set; }

        [JsonProperty("templateIdList")]
        public JToken TemplateList { get; set; }
    }

    public class GetTemplatesbyTemplateIdsInput
    {
        [JsonProperty("templateIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] TemplateIds { get; set; }
    }

    public class GetTemplateDetailsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("template")]
        public GetTemplateDetailsResponseTemplateType Template { get; set; }

        [JsonProperty("allfields")]
        public GetTemplateDetailsResponseAllFieldsTypeItem[] AllFields { get; set; }
    }

    public class GetTemplateDetailsResponseTemplateType
    {
        [JsonProperty("templateId")]
        public int Id { get; set; }

        [JsonProperty("templateName")]
        public string Name { get; set; }

        [JsonProperty("templateDesc")]
        public string Description { get; set; }

        [JsonProperty("templateType")]
        public string Type { get; set; }

        [JsonProperty("templateCreationDate")]
        public int CreatedDate { get; set; }

        [JsonProperty("templateLastUpdateDate")]
        public int LastUpdatedDate { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("numberOfParties")]
        public int NumberOfParties { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("shareAll")]
        public bool ShareWithAll { get; set; }

        [JsonProperty("templateCustomName")]
        public string CustomNamePattern { get; set; }

        [JsonProperty("templatePartyPermissions")]
        public GetTemplateDetailsResponseTemplateTypePartyPermissionsTypeItem[] PartyPermissions { get; set; }

        [JsonProperty("templateCreatedBy")]
        public GetTemplateDetailsResponseTemplateTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("templateLastUpdatedBy")]
        public GetTemplateDetailsResponseTemplateTypeLastUpdatedByType LastUpdatedBy { get; set; }
    }

    public class GetTemplateDetailsResponseTemplateTypePartyPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("templateId")]
        public int Id { get; set; }

        [JsonProperty("templatePermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("templatePartyRole")]
        public string PartyRole { get; set; }
    }

    public class GetTemplateDetailsResponseTemplateTypeCreatedByType
    {
        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class GetTemplateDetailsResponseTemplateTypeLastUpdatedByType
    {
        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class GetTemplateDetailsResponseAllFieldsTypeItem
    {
        [JsonProperty("fieldTagId")]
        public int FieldTagId { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("documentPageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("partyResponsible")]
        public int PartyResponsible { get; set; }

        [JsonProperty("partyResponsibleSequence")]
        public int PartySequence { get; set; }

        [JsonProperty("docFieldId")]
        public string DocFieldId { get; set; }

        [JsonProperty("dependent")]
        public bool Dependent { get; set; }

        [JsonProperty("tabOrder")]
        public int TabOrder { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("customFieldName")]
        public string CustomFieldName { get; set; }

        [JsonProperty("shareAll")]
        public bool ShareAll { get; set; }

        [JsonProperty("allowEdit")]
        public bool AllowEdit { get; set; }

        [JsonProperty("textfieldName")]
        public string TextFieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fontSize")]
        public int FontSize { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("multiLine")]
        public bool MultiLine { get; set; }

        [JsonProperty("characterLimit")]
        public int CharacterLimit { get; set; }

        [JsonProperty("datefieldName")]
        public string DateFieldName { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("cbname")]
        public string CheckboxName { get; set; }

        [JsonProperty("cbgroup")]
        public string CheckboxGroup { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("securedfieldName")]
        public string SecuredFieldName { get; set; }

        [JsonProperty("charToDisplay")]
        public int CharsToDisplay { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("initialImage")]
        public string InitialImage { get; set; }

        [JsonProperty("attachmentfieldName")]
        public string AttachmentFieldName { get; set; }

        [JsonProperty("attachmentfieldDescription")]
        public string AttachmentDescription { get; set; }
    }

    public class GetalistofallTemplatesResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("total_templates")]
        public int TotalTemplates { get; set; }

        [JsonProperty("templatesList")]
        public GetalistofallTemplatesResponseTemplatesListTypeItem[] TemplatesList { get; set; }
    }

    public class GetalistofallTemplatesResponseTemplatesListTypeItem
    {
        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("templateDesc")]
        public string TemplateDescription { get; set; }

        [JsonProperty("templateType")]
        public string TemplateType { get; set; }

        [JsonProperty("templateCreationDate")]
        public int CreatedDate { get; set; }

        [JsonProperty("templateLastUpdateDate")]
        public int LastUpdatedDate { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("numberOfParties")]
        public int NumberOfParties { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("shareAll")]
        public bool ShareWithAll { get; set; }

        [JsonProperty("templateCreatedBy")]
        public GetalistofallTemplatesResponseTemplatesListTypeItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("templateLastUpdatedBy")]
        public GetalistofallTemplatesResponseTemplatesListTypeItemLastUpdatedByType LastUpdatedBy { get; set; }
    }

    public class GetalistofallTemplatesResponseTemplatesListTypeItemCreatedByType
    {
        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }
    }

    public class GetalistofallTemplatesResponseTemplatesListTypeItemLastUpdatedByType
    {
        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }
    }

    public class CreateTemplatefromURLResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("template")]
        public CreateTemplatefromURLResponseTemplateType Template { get; set; }

        [JsonProperty("allfields")]
        public CreateTemplatefromURLResponseTemplateFieldsTypeItem[] TemplateFields { get; set; }
    }

    public class CreateTemplatefromURLResponseTemplateType
    {
        [JsonProperty("templateId")]
        public int Id { get; set; }

        [JsonProperty("templateName")]
        public string Name { get; set; }

        [JsonProperty("templateDesc")]
        public string Description { get; set; }

        [JsonProperty("templateType")]
        public string Type { get; set; }

        [JsonProperty("templateCreationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("templateLastUpdateDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("numberOfParties")]
        public int NumberOfParties { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("shareAll")]
        public bool SharedWithAll { get; set; }

        [JsonProperty("templateCustomName")]
        public string CustomNamePattern { get; set; }

        [JsonProperty("templatePartyPermissions")]
        public CreateTemplatefromURLResponseTemplateTypePartyPermissionsTypeItem[] PartyPermissions { get; set; }

        [JsonProperty("templateCreatedBy")]
        public CreateTemplatefromURLResponseTemplateTypeCreatedByType CreatedBy { get; set; }

        [JsonProperty("templateLastUpdatedBy")]
        public CreateTemplatefromURLResponseTemplateTypeLastUpdatedByType LastUpdatedBy { get; set; }
    }

    public class CreateTemplatefromURLResponseTemplateTypePartyPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int PartyId { get; set; }

        [JsonProperty("templateId")]
        public int Id { get; set; }

        [JsonProperty("templatePermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("templatePartyRole")]
        public string PartyRole { get; set; }
    }

    public class CreateTemplatefromURLResponseTemplateTypeCreatedByType
    {
        [JsonProperty("partyId")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class CreateTemplatefromURLResponseTemplateTypeLastUpdatedByType
    {
        [JsonProperty("partyId")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class CreateTemplatefromURLResponseTemplateFieldsTypeItem
    {
        [JsonProperty("fieldTagId")]
        public int FieldId { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("documentPageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("partyResponsible")]
        public int ResponsibleParty { get; set; }

        [JsonProperty("partyResponsibleSequence")]
        public int PartySequence { get; set; }

        [JsonProperty("docFieldId")]
        public string FieldDocId { get; set; }

        [JsonProperty("dependent")]
        public bool IsDependent { get; set; }

        [JsonProperty("tabOrder")]
        public int TabOrder { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("customFieldName")]
        public string CustomFieldName { get; set; }

        [JsonProperty("shareAll")]
        public bool ShareAll { get; set; }

        [JsonProperty("allowEdit")]
        public bool AllowEdit { get; set; }

        [JsonProperty("textfieldName")]
        public string TextFieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fontSize")]
        public int FontSize { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("multiLine")]
        public bool MultiLine { get; set; }

        [JsonProperty("characterLimit")]
        public int CharacterLimit { get; set; }

        [JsonProperty("datefieldName")]
        public string DateFieldName { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("cbname")]
        public string CheckboxName { get; set; }

        [JsonProperty("cbgroup")]
        public string CheckboxGroup { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("securedfieldName")]
        public string SecuredFieldName { get; set; }

        [JsonProperty("charToDisplay")]
        public int CharsToDisplay { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("initialImage")]
        public string InitialImage { get; set; }

        [JsonProperty("attachmentfieldName")]
        public string AttachmentFieldName { get; set; }

        [JsonProperty("attachmentfieldDescription")]
        public string AttachmentDescription { get; set; }
    }

    public class CreateTemplatefromURLInput
    {
        [JsonProperty("templateName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateName { get; set; }

        [JsonProperty("templateUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateURL { get; set; }

        [JsonProperty("inputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputType { get; set; } = "url";

        [JsonProperty("processTextTags", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessTextTags { get; set; } = true;

        [JsonProperty("processAcroFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessAcroFields { get; set; } = true;

        [JsonProperty("shareAll", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ShareAll { get; set; }

        [JsonProperty("numberOfParties", DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfParties { get; set; }

        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }

        [JsonProperty("authorEmail")]
        public string AuthorEmail { get; set; }

        [JsonProperty("createEmbeddedTemplateSession")]
        public bool? CreateEmbeddedTemplateSession { get; set; }

        [JsonProperty("redirectURL")]
        public string RedirectUrl { get; set; }

        [JsonProperty("hideSendTemplate")]
        public bool? HideSendTemplate { get; set; }

        [JsonProperty("fixRecipientParties")]
        public bool? FixRecipientParties { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("parties", DefaultValueHandling = DefaultValueHandling.Include)]
        public TemplateParty[] Parties { get; set; }

        [JsonProperty("hideMoreAction")]
        public bool? HideMoreAction { get; set; }

        [JsonProperty("hideShareWithAll")]
        public bool? HideShareWithAll { get; set; }

        [JsonProperty("hideAddParty")]
        public bool? HideAddParty { get; set; }

        [JsonProperty("hideMeButton")]
        public bool? HideMeButton { get; set; }

        [JsonProperty("hideOthersButton")]
        public bool? HideOthersButton { get; set; }

        [JsonProperty("hideExistingContactSelectOption")]
        public bool? HideExistingContactSelectOption { get; set; }

        [JsonProperty("hideFieldNameForRecipients")]
        public bool? HideFieldNameForRecipients { get; set; }

        [JsonProperty("hideCheckboxBorder")]
        public bool? HideCheckboxBorder { get; set; }
    }

    public class TemplateParty
    {
        [JsonProperty("permission")]
        public Permissions Permission { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }
    }

    public class CreateTemplatefromBase64Response
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("template")]
        public CreateTemplatefromBase64ResponseTemplateType Template { get; set; }

        [JsonProperty("allfields")]
        public CreateTemplatefromBase64ResponseTemplateFieldsTypeItem[] TemplateFields { get; set; }
    }

    public class CreateTemplatefromBase64ResponseTemplateType
    {
        [JsonProperty("templateId")]
        public int Id { get; set; }

        [JsonProperty("templateName")]
        public string Name { get; set; }

        [JsonProperty("templateDesc")]
        public string Description { get; set; }

        [JsonProperty("templateType")]
        public string Type { get; set; }

        [JsonProperty("templateCreationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("templateLastUpdateDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("numberOfParties")]
        public int NumberOfParties { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("shareAll")]
        public bool SharedWithAll { get; set; }

        [JsonProperty("templatePartyPermissions")]
        public CreateTemplatefromBase64ResponseTemplateTypePartyPermissionsTypeItem[] PartyPermissions { get; set; }

        [JsonProperty("templateCreatedBy")]
        public CreateTemplatefromBase64ResponseTemplateTypeCreatedByType CreatedBy { get; set; }
    }

    public class CreateTemplatefromBase64ResponseTemplateTypePartyPermissionsTypeItem
    {
        [JsonProperty("template_party_id")]
        public int PartyId { get; set; }

        [JsonProperty("templateId")]
        public int Id { get; set; }

        [JsonProperty("templatePermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("templatePartyRole")]
        public string PartyRole { get; set; }
    }

    public class CreateTemplatefromBase64ResponseTemplateTypeCreatedByType
    {
        [JsonProperty("partyId")]
        public int UserId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }
    }

    public class CreateTemplatefromBase64ResponseTemplateFieldsTypeItem
    {
        [JsonProperty("fieldTagId")]
        public int FieldId { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("documentPageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("partyResponsible")]
        public int ResponsibleParty { get; set; }

        [JsonProperty("partyResponsibleSequence")]
        public int PartySequence { get; set; }

        [JsonProperty("docFieldId")]
        public string FieldDocId { get; set; }

        [JsonProperty("dependent")]
        public bool IsDependent { get; set; }

        [JsonProperty("tabOrder")]
        public int TabOrder { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("customFieldName")]
        public string CustomFieldName { get; set; }

        [JsonProperty("shareAll")]
        public bool ShareAll { get; set; }

        [JsonProperty("allowEdit")]
        public bool AllowEdit { get; set; }

        [JsonProperty("textfieldName")]
        public string TextFieldName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("fontSize")]
        public int FontSize { get; set; }

        [JsonProperty("fontColor")]
        public string FontColor { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("multiLine")]
        public bool MultiLine { get; set; }

        [JsonProperty("characterLimit")]
        public int CharacterLimit { get; set; }

        [JsonProperty("datefieldName")]
        public string DateFieldName { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("cbname")]
        public string CheckboxName { get; set; }

        [JsonProperty("cbgroup")]
        public string CheckboxGroup { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }

        [JsonProperty("securedfieldName")]
        public string SecuredFieldName { get; set; }

        [JsonProperty("charToDisplay")]
        public int CharsToDisplay { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("initialImage")]
        public string InitialImage { get; set; }

        [JsonProperty("attachmentfieldName")]
        public string AttachmentFieldName { get; set; }

        [JsonProperty("attachmentfieldDescription")]
        public string AttachmentDescription { get; set; }
    }

    public class CreateTemplatefromBase64Input
    {
        [JsonProperty("templateName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateName { get; set; }

        [JsonProperty("base64FileString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Base64FileString { get; set; }

        [JsonProperty("inputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTemplatefromBase64InputInputTypeType InputType { get; set; } = CreateTemplatefromBase64InputInputTypeType.Base64;

        [JsonProperty("processTextTags", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessTextTags { get; set; } = true;

        [JsonProperty("processAcroFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessAcroFields { get; set; } = true;

        [JsonProperty("shareAll", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ShareAll { get; set; }

        [JsonProperty("numberOfParties", DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfParties { get; set; }

        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }

        [JsonProperty("authorEmail")]
        public string AuthorEmail { get; set; }

        [JsonProperty("createEmbeddedTemplateSession")]
        public bool? CreateEmbeddedTemplateSession { get; set; }

        [JsonProperty("redirectURL")]
        public string RedirectURL { get; set; }

        [JsonProperty("hideSendTemplate")]
        public bool? HideSendTemplate { get; set; }

        [JsonProperty("fixRecipientParties")]
        public bool? FixRecipientParties { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("parties", DefaultValueHandling = DefaultValueHandling.Include)]
        public TemplateParty[] Parties { get; set; }

        [JsonProperty("hideMoreAction")]
        public bool? HideMoreAction { get; set; }

        [JsonProperty("hideShareWithAll")]
        public bool? HideShareWithAll { get; set; }

        [JsonProperty("hideAddParty")]
        public bool? HideAddParty { get; set; }

        [JsonProperty("hideMeButton")]
        public bool? HideMeButton { get; set; }

        [JsonProperty("hideOthersButton")]
        public bool? HideOthersButton { get; set; }

        [JsonProperty("hideFieldNameForRecipients")]
        public bool? HideFieldNameForRecipients { get; set; }

        [JsonProperty("hideCheckboxBorder")]
        public bool? HideCheckboxBorder { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTemplatefromBase64InputInputTypeType
    {
        [EnumMember(Value = "base64")]
        Base64
    }

    public class CreateEnvelopefromTemplateResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("embeddedSigningSessions")]
        public CreateEnvelopefromTemplateResponseEmbeddedSigningSessionsTypeItem[] EmbeddedSigningSessions { get; set; }

        [JsonProperty("embeddedToken")]
        public string EmbeddedSendingToken { get; set; }

        [JsonProperty("embeddedSessionURL")]
        public string SendingSessionURL { get; set; }

        [JsonProperty("folder")]
        public CreateEnvelopefromTemplateResponseEnvelopeType Envelope { get; set; }
    }

    public class CreateEnvelopefromTemplateResponseEmbeddedSigningSessionsTypeItem
    {
        [JsonProperty("emailIdOfSigner")]
        public string SignerEmail { get; set; }

        [JsonProperty("embeddedToken")]
        public string SigningToken { get; set; }

        [JsonProperty("embeddedSessionURL")]
        public string SigningSessionURL { get; set; }
    }

    public class CreateEnvelopefromTemplateResponseEnvelopeType
    {
        [JsonProperty("envelopeId")]
        public int Id { get; set; }

        [JsonProperty("envelopeName")]
        public string Name { get; set; }

        [JsonProperty("folderCustomName")]
        public string CustomName { get; set; }

        [JsonProperty("folderPassword")]
        public string Password { get; set; }

        [JsonProperty("folderAuthorId")]
        public int AuthorId { get; set; }

        [JsonProperty("folderAuthorFirstName")]
        public string AuthorFirstName { get; set; }

        [JsonProperty("folderAuthorLastName")]
        public string AuthorLastName { get; set; }

        [JsonProperty("folderAuthorEmail")]
        public string AuthorEmail { get; set; }

        [JsonProperty("folderAuthorRole")]
        public string AuthorRole { get; set; }

        [JsonProperty("envelopeCompanyId")]
        public int CompanyId { get; set; }

        [JsonProperty("folderCreationDate")]
        public int CreationDate { get; set; }

        [JsonProperty("folderSentDate")]
        public int SentDate { get; set; }

        [JsonProperty("envelopeStatus")]
        public string Status { get; set; }

        [JsonProperty("custom_field1")]
        public string CustomField1 { get; set; }

        [JsonProperty("custom_field2")]
        public string CustomField2 { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("folderDocumentIds")]
        public int[] DocumentIDs { get; set; }

        [JsonProperty("documentsList")]
        public CreateEnvelopefromTemplateResponseEnvelopeTypeDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("folderRecipientParties")]
        public CreateEnvelopefromTemplateResponseEnvelopeTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("folderAccessURLForAuthor")]
        public string AuthorAccessURL { get; set; }

        [JsonProperty("draftFolderAccessURL")]
        public string DraftAccessURL { get; set; }

        [JsonProperty("boardRoomSign")]
        public bool BoardRoomSign { get; set; }

        [JsonProperty("includeLogo")]
        public bool IncludeLogo { get; set; }

        [JsonProperty("email_btnBgColor")]
        public string EmailButtonColor { get; set; }

        [JsonProperty("email_btnTxtColor")]
        public string EmailButtonTextColor { get; set; }

        [JsonProperty("emailTemplateLogo")]
        public string EmailLogo { get; set; }

        [JsonProperty("emailTemplateId")]
        public int EmailTemplateId { get; set; }

        [JsonProperty("emailHeader")]
        public string EmailHeader { get; set; }

        [JsonProperty("emailFooter")]
        public string EmailFooter { get; set; }

        [JsonProperty("purgeFlag")]
        public bool PurgeScheduled { get; set; }

        [JsonProperty("purgeStartDate")]
        public string PurgeStartDate { get; set; }

        [JsonProperty("purgeEndDate")]
        public string PurgeEndDate { get; set; }

        [JsonProperty("bulkId")]
        public int BulkId { get; set; }

        [JsonProperty("enforceSignWorkflow")]
        public bool EnforceSignOrder { get; set; }

        [JsonProperty("currentWorkflowStep")]
        public int CurrentWorkflowStep { get; set; }

        [JsonProperty("transactionSource")]
        public string TransactionSource { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("inPersonSignable")]
        public bool InPersonSigning { get; set; }

        [JsonProperty("overrideAccountReminders")]
        public bool OverrideReminders { get; set; }

        [JsonProperty("overrideAccountRecipientDelegation")]
        public bool OverrideDelegation { get; set; }

        [JsonProperty("allowRecipientsToDelegate")]
        public bool AllowDelegation { get; set; }

        [JsonProperty("envelopeOriginatorId")]
        public int OriginatorId { get; set; }

        [JsonProperty("envelopeDate")]
        public int Date { get; set; }

        [JsonProperty("envelopeSharedDate")]
        public int SharedDate { get; set; }

        [JsonProperty("envelopeContractIds")]
        public int[] ContractIDs { get; set; }

        [JsonProperty("envelopePartyPermissions")]
        public CreateEnvelopefromTemplateResponseEnvelopeTypePartyPermissionsTypeItem[] PartyPermissions { get; set; }

        [JsonProperty("envelopeAuthenticationLevel")]
        public string AuthenticationLevel { get; set; }

        [JsonProperty("allowSingleSignerInBulk")]
        public bool AllowSingleSignerBulk { get; set; }

        [JsonProperty("folderNameBasedOnFileNaming")]
        public bool NameBasedOnFile { get; set; }

        [JsonProperty("documentNameBasedOnFileNaming")]
        public bool DocumentNameBasedOnFile { get; set; }

        [JsonProperty("certificateNameBasedOnFileNaming")]
        public bool CertificateNameBasedOnFile { get; set; }

        [JsonProperty("enableFileNamingBeforeExecution")]
        public bool EnableFileNaming { get; set; }

        [JsonProperty("payeeAddedd")]
        public bool PayeeAdded { get; set; }

        [JsonProperty("selfSignerEnabled")]
        public bool SelfSigner { get; set; }

        [JsonProperty("notaryEnabled")]
        public bool NotaryEnabled { get; set; }

        [JsonProperty("limitedVisibilityFlag")]
        public bool LimitedVisibility { get; set; }

        [JsonProperty("postSigningVisibility")]
        public bool PostSigningVisibility { get; set; }

        [JsonProperty("wetSignatureEnabled")]
        public bool WetSignatureEnabled { get; set; }

        [JsonProperty("mergeEnabled")]
        public bool MergeEnabled { get; set; }
    }

    public class CreateEnvelopefromTemplateResponseEnvelopeTypeDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("contractId")]
        public int ContractId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("contractCreatedBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("contractCreatedOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("contractStatus")]
        public string DocumentStatus { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("contractVersionId")]
        public int VersionId { get; set; }

        [JsonProperty("contractVersionName")]
        public string VersionName { get; set; }

        [JsonProperty("contractVersionDesc")]
        public string VersionDescription { get; set; }

        [JsonProperty("versionCreatedby")]
        public int VersionCreatedBy { get; set; }

        [JsonProperty("versionCreatedOn")]
        public string VersionCreatedOn { get; set; }

        [JsonProperty("contractVersionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("contractTransactionSource")]
        public string TransactionSource { get; set; }
    }

    public class CreateEnvelopefromTemplateResponseEnvelopeTypeRecipientsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public CreateEnvelopefromTemplateResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int PartyCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string SigningURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string ExtraComments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string AuthenticationLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyFieldValue { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleFieldValue { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PayFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool IsPayee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringFieldExists { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignCompleted { get; set; }

        [JsonProperty("allowOptionalSigner")]
        public bool AllowOptionalSigner { get; set; }

        [JsonProperty("optionalSigners")]
        public string OptionalSigners { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }
    }

    public class CreateEnvelopefromTemplateResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("placeholder")]
        public bool IsPlaceholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int AccountCreatedDate { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniquePartyId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthenticationLevel { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("subcontractorDescription")]
        public string SubcontractorDescription { get; set; }

        [JsonProperty("subcontractorOrganization")]
        public string SubcontractorOrganization { get; set; }

        [JsonProperty("subcAddedDate")]
        public int SubcontractorAddedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CreateEnvelopefromTemplateResponseEnvelopeTypePartyPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("folderAccessURL")]
        public string SigningURL { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }
    }

    public class CreateEnvelopefromTemplateInput
    {
        [JsonProperty("folderName")]
        public string EnvelopeName { get; set; }

        [JsonProperty("templateIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] TemplateIds { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool? AdvancedEmailValidation { get; set; }

        [JsonProperty("parties", DefaultValueHandling = DefaultValueHandling.Include)]
        public Party[] Parties { get; set; }

        [JsonProperty("folderPassword")]
        public string EnvelopePassword { get; set; }

        [JsonProperty("signInSequence")]
        public bool? SignInSequence { get; set; }

        [JsonProperty("inPersonEnable")]
        public bool? InPersonEnable { get; set; }

        [JsonProperty("sendNow", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendNow { get; set; } = true;

        [JsonProperty("signSuccessUrlAllParties")]
        public bool? SignSuccessUrlAllParties { get; set; }

        [JsonProperty("createEmbeddedSendingSession")]
        public bool? CreateEmbeddedSendingSession { get; set; }

        [JsonProperty("fixRecipientParties")]
        public bool? FixRecipientParties { get; set; }

        [JsonProperty("fixDocuments")]
        public bool? FixDocuments { get; set; }

        [JsonProperty("sendSuccessUrl")]
        public string SendSuccessUrl { get; set; }

        [JsonProperty("sendErrorUrl")]
        public string SendErrorUrl { get; set; }

        [JsonProperty("hideSignerSelectOption")]
        public bool? HideSignerSelectOption { get; set; }

        [JsonProperty("hideSignerActions")]
        public bool? HideSignerActions { get; set; }

        [JsonProperty("hideSenderName")]
        public bool? HideSenderName { get; set; }

        [JsonProperty("hideSendButton")]
        public bool? HideSendButton { get; set; }

        [JsonProperty("hideFolderName")]
        public bool? HideFolderName { get; set; }

        [JsonProperty("hideDocumentsName")]
        public bool? HideDocumentsName { get; set; }

        [JsonProperty("hideAddMeButton")]
        public bool? HideAddMeButton { get; set; }

        [JsonProperty("hideAddNewButton")]
        public bool? HideAddNewButton { get; set; }

        [JsonProperty("hideAddGroupButton")]
        public bool? HideAddGroupButton { get; set; }

        [JsonProperty("createEmbeddedSigningSession")]
        public bool? CreateEmbeddedSigningSession { get; set; }

        [JsonProperty("createEmbeddedSigningSessionForAllParties")]
        public bool? CreateEmbeddedSigningSessionForAllParties { get; set; }

        [JsonProperty("embeddedSignersEmailIds")]
        public string[] EmbeddedSignersEmailIds { get; set; }

        [JsonProperty("signSuccessUrl")]
        public string SignSuccessUrl { get; set; }

        [JsonProperty("signDeclineUrl")]
        public string SignDeclineUrl { get; set; }

        [JsonProperty("signLaterUrl")]
        public string SignLaterUrl { get; set; }

        [JsonProperty("signErrorUrl")]
        public string SignErrorUrl { get; set; }

        [JsonProperty("hideNextRequiredFieldBtn")]
        public bool? HideNextRequiredFieldBtn { get; set; }

        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }

        [JsonProperty("hideDeclineToSign")]
        public bool? HideDeclineToSign { get; set; }

        [JsonProperty("hideMoreAction")]
        public bool? HideMoreAction { get; set; }

        [JsonProperty("hideAddPartiesOption")]
        public bool? HideAddPartiesOption { get; set; }

        [JsonProperty("sessionExpire")]
        public bool? SessionExpire { get; set; }

        [JsonProperty("expiry")]
        public int? Expiry { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("allowSendNowAndEmbeddedSigningSession")]
        public bool? AllowSendNowAndEmbeddedSigningSession { get; set; }

        [JsonProperty("enableStepByStep")]
        public bool? EnableStepByStep { get; set; }
    }

    public class ListallWebhookChannelsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("total_channel")]
        public int TotalChannels { get; set; }

        [JsonProperty("templatesList")]
        public ListallWebhookChannelsResponseWebhookChannelsTypeItem[] WebhookChannels { get; set; }
    }

    public class ListallWebhookChannelsResponseWebhookChannelsTypeItem
    {
        [JsonProperty("channelId")]
        public int ChannelId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("channelName")]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookURL { get; set; }

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("dateUpdated")]
        public int DateUpdated { get; set; }

        [JsonProperty("webhookLevel")]
        public string WebhookLevel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("eventsSubscribedMap")]
        public ListallWebhookChannelsResponseWebhookChannelsTypeItemSubscribedEventsType SubscribedEvents { get; set; }
    }

    public class ListallWebhookChannelsResponseWebhookChannelsTypeItemSubscribedEventsType
    {
        [JsonProperty("folder_sent")]
        public bool EnvelopeSent { get; set; }

        [JsonProperty("folder_viewed")]
        public bool EnvelopeViewed { get; set; }

        [JsonProperty("folder_signed")]
        public bool EnvelopeSigned { get; set; }

        [JsonProperty("folder_cancelled")]
        public bool EnvelopeCancelled { get; set; }

        [JsonProperty("folder_executed")]
        public bool EnvelopeExecuted { get; set; }

        [JsonProperty("folder_deleted")]
        public bool EnvelopeDeleted { get; set; }
    }

    public class GetWebhookChannelDetailsResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("channel")]
        public GetWebhookChannelDetailsResponseChannelType Channel { get; set; }
    }

    public class GetWebhookChannelDetailsResponseChannelType
    {
        [JsonProperty("channelId")]
        public int Id { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("channelName")]
        public string Name { get; set; }

        [JsonProperty("webhookUrl")]
        public string WebhookURL { get; set; }

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("dateUpdated")]
        public int DateUpdated { get; set; }

        [JsonProperty("webhookLevel")]
        public string WebhookLevel { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("eventsSubscribedMap")]
        public GetWebhookChannelDetailsResponseChannelTypeSubscribedEventsType SubscribedEvents { get; set; }
    }

    public class GetWebhookChannelDetailsResponseChannelTypeSubscribedEventsType
    {
        [JsonProperty("folder_sent")]
        public bool EnvelopeSent { get; set; }

        [JsonProperty("folder_viewed")]
        public bool EnvelopeViewed { get; set; }

        [JsonProperty("folder_signed")]
        public bool EnvelopeSigned { get; set; }

        [JsonProperty("folder_cancelled")]
        public bool EnvelopeCancelled { get; set; }

        [JsonProperty("folder_executed")]
        public bool EnvelopeExecuted { get; set; }

        [JsonProperty("folder_deleted")]
        public bool EnvelopeDeleted { get; set; }
    }

    public class CreateEmailGroupResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("emailGroup")]
        public CreateEmailGroupResponseEmailGroupType EmailGroup { get; set; }
    }

    public class CreateEmailGroupResponseEmailGroupType
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("groupDesc")]
        public string GroupDescription { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("parties")]
        public CreateEmailGroupResponseEmailGroupTypePartiesTypeItem[] Parties { get; set; }
    }

    public class CreateEmailGroupResponseEmailGroupTypePartiesTypeItem
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }
    }

    public class CreateEmailGroupInput
    {
        [JsonProperty("emailGroupName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupName { get; set; }

        [JsonProperty("emailGroupDescription")]
        public string GroupDescription { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool? AllowAdvancedEmailValidation { get; set; }

        [JsonProperty("parties", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEmailGroupInputPartiesTypeItem[] Parties { get; set; }
    }

    public class CreateEmailGroupInputPartiesTypeItem
    {
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("emailId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class GetEmailGroupDetailsResponse
    {
        [JsonProperty("allEmailGroups")]
        public GetEmailGroupDetailsResponseEmailGroupsTypeItem[] EmailGroups { get; set; }
    }

    public class GetEmailGroupDetailsResponseEmailGroupsTypeItem
    {
        [JsonProperty("groupId")]
        public int GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("groupDesc")]
        public string GroupDescription { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("parties")]
        public GetEmailGroupDetailsResponseEmailGroupsTypeItemPartiesTypeItem[] Parties { get; set; }
    }

    public class GetEmailGroupDetailsResponseEmailGroupsTypeItemPartiesTypeItem
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }
    }

    public class GetEmailGroupDetailsInput
    {
        [JsonProperty("emailGroupNames", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] EmailGroupNames { get; set; }
    }

    public class DownloadReportInput
    {
        [JsonProperty("status")]
        public EnvelopeStatus? Status { get; set; }

        [JsonProperty("creationDateFrom")]
        public string CreationDateFrom { get; set; }

        [JsonProperty("creationDateTo")]
        public string CreationDateTo { get; set; }

        [JsonProperty("folderName")]
        public string EnvelopeName { get; set; }

        [JsonProperty("includeFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IncludeFields { get; set; } = "false";

        [JsonProperty("authorEmail")]
        public string AuthorEmail { get; set; }

        [JsonProperty("signerEmail")]
        public string SignerEmail { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeStatus
    {
        EXECUTED,
        SHARED,
        DRAFT,
        [EnumMember(Value = "PARTIALLY SIGNED")]
        PARTIALLYSIGNED,
        CANCELED,
        EXPIRED,
        DELETED
    }

    public class CreateEnvelopefromBase64Response
    {
        [JsonProperty("folder")]
        public CreateEnvelopefromBase64ResponseEnvelopeType Envelope { get; set; }

        [JsonProperty("embeddedSigningSessions")]
        public CreateEnvelopefromBase64ResponseEmbeddedSigningSessionsTypeItem[] EmbeddedSigningSessions { get; set; }

        [JsonProperty("embeddedToken")]
        public string EmbeddedSendingToken { get; set; }

        [JsonProperty("embeddedSessionURL")]
        public string SendingSessionURL { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEnvelopeType
    {
        [JsonProperty("envelopeId")]
        public int Id { get; set; }

        [JsonProperty("envelopeName")]
        public string Name { get; set; }

        [JsonProperty("folderCustomName")]
        public string CustomName { get; set; }

        [JsonProperty("folderPassword")]
        public string Password { get; set; }

        [JsonProperty("folderAuthorId")]
        public int CreatorId { get; set; }

        [JsonProperty("folderAuthorFirstName")]
        public string CreatorFirstName { get; set; }

        [JsonProperty("folderAuthorLastName")]
        public string CreatorLastName { get; set; }

        [JsonProperty("folderAuthorEmail")]
        public string CreatorEmail { get; set; }

        [JsonProperty("folderAuthorRole")]
        public string CreatorRole { get; set; }

        [JsonProperty("envelopeCompanyId")]
        public int CompanyId { get; set; }

        [JsonProperty("folderCreationDate")]
        public int CreatedDate { get; set; }

        [JsonProperty("folderSentDate")]
        public int SentDate { get; set; }

        [JsonProperty("envelopeStatus")]
        public string Status { get; set; }

        [JsonProperty("custom_field1")]
        public string CustomField1 { get; set; }

        [JsonProperty("custom_field2")]
        public string CustomField2 { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("folderDocumentIds")]
        public int[] DocumentIDs { get; set; }

        [JsonProperty("documentsList")]
        public CreateEnvelopefromBase64ResponseEnvelopeTypeDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("folderRecipientParties")]
        public CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("folderAccessURLForAuthor")]
        public string AuthorSigningURL { get; set; }

        [JsonProperty("draftFolderAccessURL")]
        public string DraftAccessURL { get; set; }

        [JsonProperty("boardRoomSign")]
        public bool BoardroomSigning { get; set; }

        [JsonProperty("includeLogo")]
        public bool IncludeLogo { get; set; }

        [JsonProperty("email_btnBgColor")]
        public string ButtonBackgroundColor { get; set; }

        [JsonProperty("email_btnTxtColor")]
        public string ButtonTextColor { get; set; }

        [JsonProperty("emailTemplateLogo")]
        public string EmailLogo { get; set; }

        [JsonProperty("emailTemplateId")]
        public int EmailTemplateId { get; set; }

        [JsonProperty("emailHeader")]
        public string EmailHeader { get; set; }

        [JsonProperty("emailFooter")]
        public string EmailFooter { get; set; }

        [JsonProperty("purgeFlag")]
        public bool PurgeScheduled { get; set; }

        [JsonProperty("purgeStartDate")]
        public string PurgeStartDate { get; set; }

        [JsonProperty("purgeEndDate")]
        public string PurgeEndDate { get; set; }

        [JsonProperty("bulkId")]
        public int BulkSendId { get; set; }

        [JsonProperty("enforceSignWorkflow")]
        public bool EnforceSignOrder { get; set; }

        [JsonProperty("currentWorkflowStep")]
        public int CurrentStep { get; set; }

        [JsonProperty("transactionSource")]
        public string TransactionSource { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("inPersonSignable")]
        public bool InPersonSigning { get; set; }

        [JsonProperty("overrideAccountReminders")]
        public bool OverrideReminders { get; set; }

        [JsonProperty("overrideAccountRecipientDelegation")]
        public bool OverrideDelegation { get; set; }

        [JsonProperty("allowRecipientsToDelegate")]
        public bool AllowDelegation { get; set; }

        [JsonProperty("envelopeOriginatorId")]
        public int OriginatorId { get; set; }

        [JsonProperty("envelopeDate")]
        public int Date { get; set; }

        [JsonProperty("envelopeSharedDate")]
        public int SharedDate { get; set; }

        [JsonProperty("envelopeContractIds")]
        public int[] ContractIDs { get; set; }

        [JsonProperty("envelopePartyPermissions")]
        public CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientPermissionsTypeItem[] RecipientPermissions { get; set; }

        [JsonProperty("envelopeAuthenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("allowSingleSignerInBulk")]
        public bool SingleSignerBulk { get; set; }

        [JsonProperty("folderNameBasedOnFileNaming")]
        public bool FileBasedNaming { get; set; }

        [JsonProperty("documentNameBasedOnFileNaming")]
        public bool DocFileBasedName { get; set; }

        [JsonProperty("certificateNameBasedOnFileNaming")]
        public bool CertFileBasedName { get; set; }

        [JsonProperty("enableFileNamingBeforeExecution")]
        public bool PreExecFileNaming { get; set; }

        [JsonProperty("payeeAddedd")]
        public bool PayeeAdded { get; set; }

        [JsonProperty("selfSignerEnabled")]
        public bool SelfSigningEnabled { get; set; }

        [JsonProperty("notaryEnabled")]
        public bool NotaryEnabled { get; set; }

        [JsonProperty("limitedVisibilityFlag")]
        public bool LimitedVisibility { get; set; }

        [JsonProperty("postSigningVisibility")]
        public bool PostSignVisibility { get; set; }

        [JsonProperty("wetSignatureEnabled")]
        public bool WetSignature { get; set; }

        [JsonProperty("mergeEnabled")]
        public bool MergeEnabled { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEnvelopeTypeDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("contractId")]
        public int ContractId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("contractCreatedBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("contractCreatedOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("contractStatus")]
        public string ContractStatus { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("contractVersionId")]
        public int VersionId { get; set; }

        [JsonProperty("contractVersionName")]
        public string VersionName { get; set; }

        [JsonProperty("contractVersionDesc")]
        public string VersionDescription { get; set; }

        [JsonProperty("versionCreatedby")]
        public int VersionCreatedBy { get; set; }

        [JsonProperty("versionCreatedOn")]
        public string VersionCreatedOn { get; set; }

        [JsonProperty("contractVersionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("contractTransactionSource")]
        public string TransactionSource { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int RecipientCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string RecipientAccessURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string Comments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string SignerAuthLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyField { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleField { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PaymentFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool Payee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringPayment { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignDone { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }

        [JsonProperty("allowOptionalSigner")]
        public bool OptionalSignerAllowed { get; set; }

        [JsonProperty("optionalSigners")]
        public int[] OptionalSigners { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string EmailAddress { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniqueRecipientId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("passwordUpdateDate")]
        public string PasswordUpdatedDate { get; set; }

        [JsonProperty("passwordUpdateStatus")]
        public bool PasswordUpdatedStatus { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("requestLocale")]
        public string Locale { get; set; }

        [JsonProperty("share_among_department")]
        public bool ShareWithDept { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("docStatusFilter")]
        public string StatusFilter { get; set; }

        [JsonProperty("docDateFilter")]
        public string DateFilter { get; set; }

        [JsonProperty("userSecureFieldAccess")]
        public bool SecureFieldAccess { get; set; }

        [JsonProperty("expandSidebar")]
        public bool ExpandSidebar { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool AdvEmailValidation { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("loginCount")]
        public int LoginCount { get; set; }

        [JsonProperty("sendMailForPasswordReset")]
        public bool PasswordResetEmail { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("userPrimaryCompany")]
        public int PrimaryCompany { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("subcontractorDescription")]
        public string SubcontractorDescription { get; set; }

        [JsonProperty("subcontractorOrganization")]
        public string SubcontractorOrganization { get; set; }

        [JsonProperty("subcAddedDate")]
        public int SubcontractorAddedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientPermissionsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int RecipientCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string RecipientAccessURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string Comments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string SignerAuthLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string RecipientRole { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyField { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleField { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PaymentFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool Payee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringPayment { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignDone { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEnvelopeTypeRecipientPermissionsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string EmailAddress { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniqueRecipientId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("passwordUpdateDate")]
        public string PasswordUpdatedDate { get; set; }

        [JsonProperty("passwordUpdateStatus")]
        public bool PasswordUpdatedStatus { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("requestLocale")]
        public string Locale { get; set; }

        [JsonProperty("share_among_department")]
        public bool ShareWithDept { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("docStatusFilter")]
        public string StatusFilter { get; set; }

        [JsonProperty("docDateFilter")]
        public string DateFilter { get; set; }

        [JsonProperty("userSecureFieldAccess")]
        public bool SecureFieldAccess { get; set; }

        [JsonProperty("expandSidebar")]
        public bool ExpandSidebar { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool AdvEmailValidation { get; set; }

        [JsonProperty("managerId")]
        public string ManagerId { get; set; }

        [JsonProperty("loginCount")]
        public int LoginCount { get; set; }

        [JsonProperty("sendMailForPasswordReset")]
        public bool PasswordResetEmail { get; set; }

        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("userPrimaryCompany")]
        public int PrimaryCompany { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("deviceToken")]
        public string DeviceToken { get; set; }

        [JsonProperty("subcontractorDescription")]
        public string SubcontractorDescription { get; set; }

        [JsonProperty("subcontractorOrganization")]
        public string SubcontractorOrganization { get; set; }

        [JsonProperty("subcAddedDate")]
        public int SubcontractorAddedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class CreateEnvelopefromBase64ResponseEmbeddedSigningSessionsTypeItem
    {
        [JsonProperty("emailIdOfSigner")]
        public string SignerEmail { get; set; }

        [JsonProperty("embeddedToken")]
        public string SigningToken { get; set; }

        [JsonProperty("embeddedSessionURL")]
        public string SigningSessionURL { get; set; }
    }

    public class CreateEnvelopefromBase64Input
    {
        [JsonProperty("folderName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EnvelopeName { get; set; }

        [JsonProperty("inputType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEnvelopefromBase64InputInputTypeType? InputType { get; set; } = CreateEnvelopefromBase64InputInputTypeType.Base64;

        [JsonProperty("base64FileString", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Base64FileStrings { get; set; }

        [JsonProperty("fileNames", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] FileNames { get; set; }

        [JsonProperty("parties", DefaultValueHandling = DefaultValueHandling.Include)]
        public Party[] Parties { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("sendNow", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendNow { get; set; } = true;

        [JsonProperty("createEmbeddedSigningSession", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CreateEmbeddedSigningSession { get; set; }

        [JsonProperty("createEmbeddedSigningSessionForAllParties")]
        public bool? CreateEmbeddedSigningSessionForAllParties { get; set; }

        [JsonProperty("processTextTags", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessTextTags { get; set; }

        [JsonProperty("processAcroFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ProcessAcroFields { get; set; }

        [JsonProperty("signInSequence")]
        public bool? SignInSequence { get; set; }

        [JsonProperty("inPersonEnable")]
        public bool? InPersonEnable { get; set; }

        [JsonProperty("fixRecipientParties")]
        public bool? FixRecipientParties { get; set; }

        [JsonProperty("fixDocuments")]
        public bool? FixDocuments { get; set; }

        [JsonProperty("sendSuccessUrl")]
        public string SendSuccessUrl { get; set; }

        [JsonProperty("sendErrorUrl")]
        public string SendErrorUrl { get; set; }

        [JsonProperty("createEmbeddedSendingSession")]
        public bool? CreateEmbeddedSendingSession { get; set; }

        [JsonProperty("embeddedSignersEmailIds")]
        public string[] EmbeddedSignersEmailIds { get; set; }

        [JsonProperty("signSuccessUrl")]
        public string SignSuccessUrl { get; set; }

        [JsonProperty("signDeclineUrl")]
        public string SignDeclineUrl { get; set; }

        [JsonProperty("signLaterUrl")]
        public string SignLaterUrl { get; set; }

        [JsonProperty("signErrorUrl")]
        public string SignErrorUrl { get; set; }

        [JsonProperty("allowSendNowAndEmbeddedSigningSession")]
        public bool? AllowSendNowAndEmbeddedSigningSession { get; set; }

        [JsonProperty("allowAdvancedEmailValidation")]
        public bool? AdvancedEmailValidation { get; set; }

        [JsonProperty("signSuccessUrlAllParties")]
        public bool? SignSuccessUrlAllParties { get; set; }

        [JsonProperty("emailTemplateId")]
        public int? EmailTemplateId { get; set; }

        [JsonProperty("signerInstructionId")]
        public int? SignerInstructionId { get; set; }

        [JsonProperty("confirmationInstructionId")]
        public string ConfirmationInstructionId { get; set; }

        [JsonProperty("themeColor")]
        public string ThemeColor { get; set; }

        [JsonProperty("sessionExpire")]
        public bool? SessionExpire { get; set; }

        [JsonProperty("expiry")]
        public int? Expiry { get; set; }

        [JsonProperty("dependentFields")]
        public DependentField DependentFields { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("hideAddMeButton")]
        public bool? HideAddMeButton { get; set; }

        [JsonProperty("hideAddNewButton")]
        public bool? HideAddNewButton { get; set; }

        [JsonProperty("hideAddGroupButton")]
        public bool? HideAddGroupButton { get; set; }

        [JsonProperty("hideFieldNameForRecipients")]
        public bool? HideFieldNameForRecipients { get; set; }

        [JsonProperty("hideCheckboxBorder")]
        public bool? HideCheckboxBorder { get; set; }

        [JsonProperty("hideSignerSelectOption")]
        public bool? HideSignerSelectOption { get; set; }

        [JsonProperty("hideSignerActions")]
        public bool? HideSignerActions { get; set; }

        [JsonProperty("hideSenderName")]
        public bool? HideSenderName { get; set; }

        [JsonProperty("hideFolderName")]
        public bool? HideFolderName { get; set; }

        [JsonProperty("hideDocumentsName")]
        public bool? HideDocumentsName { get; set; }

        [JsonProperty("hideDeclineToSign")]
        public bool? HideDeclineToSign { get; set; }

        [JsonProperty("hideMoreAction")]
        public bool? HideMoreAction { get; set; }

        [JsonProperty("hideSendButton")]
        public bool? HideSendButton { get; set; }

        [JsonProperty("hideNextRequiredFieldbtn")]
        public bool? HideNextRequiredFieldbtn { get; set; }

        [JsonProperty("requiredBothEmbeddedSession")]
        public bool? RequiredBothEmbeddedSession { get; set; }

        [JsonProperty("folderPassword")]
        public string EnvelopePassword { get; set; }

        [JsonProperty("enableStepByStep")]
        public bool? EnableStepByStep { get; set; }

        [JsonProperty("hideAddPartiesOption")]
        public bool? HideAddPartiesOption { get; set; }

        [JsonProperty("selfSign")]
        public bool? SelfSign { get; set; }

        [JsonProperty("selfSignerSuccessUrl")]
        public string SelfSignerSuccessUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopefromBase64InputInputTypeType
    {
        [EnumMember(Value = "base64")]
        Base64
    }

    public class WebhookEventPayload
    {
        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_date")]
        public int EventDate { get; set; }

        [JsonProperty("data")]
        public WebhookEventPayloadEventDataType EventData { get; set; }
    }

    public class WebhookEventPayloadEventDataType
    {
        [JsonProperty("folder")]
        public WebhookEventPayloadEventDataTypeEnvelopeType Envelope { get; set; }
    }

    public class WebhookEventPayloadEventDataTypeEnvelopeType
    {
        [JsonProperty("envelopeId")]
        public int Id { get; set; }

        [JsonProperty("envelopeName")]
        public string Name { get; set; }

        [JsonProperty("folderCustomName")]
        public string CustomName { get; set; }

        [JsonProperty("folderPassword")]
        public string Password { get; set; }

        [JsonProperty("folderAuthorId")]
        public int CreatorId { get; set; }

        [JsonProperty("folderAuthorFirstName")]
        public string CreatorFirstName { get; set; }

        [JsonProperty("folderAuthorLastName")]
        public string CreatorLastName { get; set; }

        [JsonProperty("folderAuthorEmail")]
        public string CreatorEmail { get; set; }

        [JsonProperty("folderAuthorRole")]
        public string CreatorRole { get; set; }

        [JsonProperty("envelopeCompanyId")]
        public int CompanyId { get; set; }

        [JsonProperty("folderCreationDate")]
        public int CreatedDate { get; set; }

        [JsonProperty("folderSentDate")]
        public int SentDate { get; set; }

        [JsonProperty("envelopeStatus")]
        public string Status { get; set; }

        [JsonProperty("custom_field1")]
        public string CustomField1 { get; set; }

        [JsonProperty("custom_field2")]
        public string CustomField2 { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("folderDocumentIds")]
        public int[] DocumentIDs { get; set; }

        [JsonProperty("documentsList")]
        public WebhookEventPayloadEventDataTypeEnvelopeTypeDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("folderRecipientParties")]
        public WebhookEventPayloadEventDataTypeEnvelopeTypeRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("folderAccessURLForAuthor")]
        public string AuthorAccessURL { get; set; }

        [JsonProperty("draftFolderAccessURL")]
        public string DraftAccessURL { get; set; }

        [JsonProperty("boardRoomSign")]
        public bool BoardroomSigning { get; set; }

        [JsonProperty("includeLogo")]
        public bool IncludeLogo { get; set; }

        [JsonProperty("email_btnBgColor")]
        public string ButtonBackgroundColor { get; set; }

        [JsonProperty("email_btnTxtColor")]
        public string ButtonTextColor { get; set; }

        [JsonProperty("emailTemplateLogo")]
        public string EmailLogo { get; set; }

        [JsonProperty("emailTemplateId")]
        public int EmailTemplateId { get; set; }

        [JsonProperty("emailHeader")]
        public string EmailHeader { get; set; }

        [JsonProperty("emailFooter")]
        public string EmailFooter { get; set; }

        [JsonProperty("purgeFlag")]
        public bool PurgeScheduled { get; set; }

        [JsonProperty("purgeStartDate")]
        public string PurgeStartDate { get; set; }

        [JsonProperty("purgeEndDate")]
        public string PurgeEndDate { get; set; }

        [JsonProperty("bulkId")]
        public int BulkId { get; set; }

        [JsonProperty("enforceSignWorkflow")]
        public bool EnforceSignOrder { get; set; }

        [JsonProperty("currentWorkflowStep")]
        public int CurrentWorkflowStep { get; set; }

        [JsonProperty("transactionSource")]
        public string TransactionSource { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("inPersonSignable")]
        public bool InPersonSigning { get; set; }

        [JsonProperty("overrideAccountReminders")]
        public bool OverrideReminders { get; set; }

        [JsonProperty("overrideAccountRecipientDelegation")]
        public bool OverrideDelegation { get; set; }

        [JsonProperty("allowRecipientsToDelegate")]
        public bool AllowDelegation { get; set; }

        [JsonProperty("envelopeOriginatorId")]
        public int OriginatorId { get; set; }

        [JsonProperty("envelopeDate")]
        public int Date { get; set; }

        [JsonProperty("envelopeSharedDate")]
        public int SharedDate { get; set; }

        [JsonProperty("envelopeContractIds")]
        public int[] ContractIDs { get; set; }

        [JsonProperty("envelopePartyPermissions")]
        public WebhookEventPayloadEventDataTypeEnvelopeTypePartyPermissionsTypeItem[] PartyPermissions { get; set; }

        [JsonProperty("envelopeAuthenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("allowSingleSignerInBulk")]
        public bool SingleSignerBulk { get; set; }

        [JsonProperty("folderNameBasedOnFileNaming")]
        public bool FileBasedFolderName { get; set; }

        [JsonProperty("documentNameBasedOnFileNaming")]
        public bool FileBasedDocName { get; set; }

        [JsonProperty("certificateNameBasedOnFileNaming")]
        public bool FileBasedCertName { get; set; }

        [JsonProperty("enableFileNamingBeforeExecution")]
        public bool PreExecFileNaming { get; set; }

        [JsonProperty("payeeAddedd")]
        public bool PayeeAdded { get; set; }

        [JsonProperty("selfSignerEnabled")]
        public bool SelfSigningEnabled { get; set; }

        [JsonProperty("notaryEnabled")]
        public bool NotaryEnabled { get; set; }

        [JsonProperty("limitedVisibilityFlag")]
        public bool LimitedVisibility { get; set; }

        [JsonProperty("postSigningVisibility")]
        public bool PostSignVisibility { get; set; }

        [JsonProperty("wetSignatureEnabled")]
        public bool WetSignature { get; set; }

        [JsonProperty("mergeEnabled")]
        public bool MergeEnabled { get; set; }
    }

    public class WebhookEventPayloadEventDataTypeEnvelopeTypeDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("contractId")]
        public int ContractId { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("contractCreatedBy")]
        public int CreatedBy { get; set; }

        [JsonProperty("contractCreatedOn")]
        public int CreatedOn { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("contractStatus")]
        public string ContractStatus { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }

        [JsonProperty("contractVersionId")]
        public int VersionId { get; set; }

        [JsonProperty("contractVersionName")]
        public string VersionName { get; set; }

        [JsonProperty("contractVersionDesc")]
        public string VersionDescription { get; set; }

        [JsonProperty("versionCreatedby")]
        public int VersionCreatedBy { get; set; }

        [JsonProperty("versionCreatedOn")]
        public int VersionCreatedOn { get; set; }

        [JsonProperty("contractVersionNumber")]
        public int VersionNumber { get; set; }

        [JsonProperty("contractTransactionSource")]
        public string TransactionSource { get; set; }
    }

    public class WebhookEventPayloadEventDataTypeEnvelopeTypeRecipientsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public WebhookEventPayloadEventDataTypeEnvelopeTypeRecipientsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string Mobile { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int RecipientCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string RecipientSigningURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string Comments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string SignerAuthLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string Role { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyField { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleField { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PaymentFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool Payee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringPayment { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignDone { get; set; }

        [JsonProperty("allowOptionalSigner")]
        public bool OptionalSigner { get; set; }

        [JsonProperty("optionalSigners")]
        public int[] OptionalSigners { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }
    }

    public class WebhookEventPayloadEventDataTypeEnvelopeTypeRecipientsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniqueId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("passwordUpdateDate")]
        public string PasswordUpdatedDate { get; set; }

        [JsonProperty("passwordUpdateStatus")]
        public bool PasswordStatus { get; set; }
    }

    public class WebhookEventPayloadEventDataTypeEnvelopeTypePartyPermissionsTypeItem
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("partyDetails")]
        public WebhookEventPayloadEventDataTypeEnvelopeTypePartyPermissionsTypeItemRecipientDetailsType RecipientDetails { get; set; }

        [JsonProperty("dialingCode")]
        public string DialingCode { get; set; }

        [JsonProperty("mobileNumber")]
        public string Mobile { get; set; }

        [JsonProperty("signerSignatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("contractPermissions")]
        public string Permissions { get; set; }

        [JsonProperty("partySequence")]
        public int SigningOrder { get; set; }

        [JsonProperty("workflowSignSequence")]
        public int WorkflowSequence { get; set; }

        [JsonProperty("envelopeId")]
        public int EnvelopeId { get; set; }

        [JsonProperty("partyCompanyId")]
        public int RecipientCompanyId { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("folderAccessURL")]
        public string RecipientSigningURL { get; set; }

        [JsonProperty("securityMode")]
        public string SecurityMode { get; set; }

        [JsonProperty("extraComments")]
        public string Comments { get; set; }

        [JsonProperty("allowNameChange")]
        public bool AllowNameChange { get; set; }

        [JsonProperty("signerNameUpdated")]
        public bool NameUpdated { get; set; }

        [JsonProperty("signerAuthenticationLevel")]
        public string SignerAuthLevel { get; set; }

        [JsonProperty("userDefinedAccessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("signatureId")]
        public string SignatureId { get; set; }

        [JsonProperty("partyRole")]
        public string Role { get; set; }

        [JsonProperty("companyFieldValue")]
        public string CompanyField { get; set; }

        [JsonProperty("titleFieldValue")]
        public string TitleField { get; set; }

        [JsonProperty("reasonSigning")]
        public string ReasonForSigning { get; set; }

        [JsonProperty("payFieldAdded")]
        public bool PaymentFieldAdded { get; set; }

        [JsonProperty("payee")]
        public bool Payee { get; set; }

        [JsonProperty("recurringFieldExist")]
        public bool RecurringPayment { get; set; }

        [JsonProperty("printAndSignCompleted")]
        public bool PrintAndSignDone { get; set; }

        [JsonProperty("allowOptionalSigner")]
        public bool OptionalSigner { get; set; }

        [JsonProperty("optionalSigners")]
        public int[] OptionalSigners { get; set; }

        [JsonProperty("paid")]
        public bool Paid { get; set; }
    }

    public class WebhookEventPayloadEventDataTypeEnvelopeTypePartyPermissionsTypeItemRecipientDetailsType
    {
        [JsonProperty("partyId")]
        public int RecipientId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emailId")]
        public string Email { get; set; }

        [JsonProperty("placeholder")]
        public bool Placeholder { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("dateCreated")]
        public int DateCreated { get; set; }

        [JsonProperty("optOutEmails")]
        public bool OptOutEmails { get; set; }

        [JsonProperty("uniquePartyId")]
        public string UniqueId { get; set; }

        [JsonProperty("authenticationLevel")]
        public string AuthLevel { get; set; }

        [JsonProperty("passwordUpdateDate")]
        public string PasswordUpdatedDate { get; set; }

        [JsonProperty("passwordUpdateStatus")]
        public bool PasswordStatus { get; set; }
    }

    public class TriggerEnvelopeSentInput
    {
        [JsonProperty("channelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhookLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerEnvelopeSentInputWebhookLevelType WebhookLevel { get; set; } = TriggerEnvelopeSentInputWebhookLevelType.Account;

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("allowAll", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool AllowAll { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Events { get; set; } = JToken.Parse("{\"folder_sent\":true,\"folder_viewed\":false,\"folder_signed\":false,\"folder_cancelled\":false,\"folder_executed\":false,\"folder_deleted\":false}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerEnvelopeSentInputWebhookLevelType
    {
        Account,
        [EnumMember(Value = "API App")]
        APIApp
    }

    public class TriggerEnvelopeViewedInput
    {
        [JsonProperty("channelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhookLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerEnvelopeViewedInputWebhookLevelType WebhookLevel { get; set; } = TriggerEnvelopeViewedInputWebhookLevelType.APIApp;

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("allowAll", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool AllowAll { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Events { get; set; } = JToken.Parse("{\"folder_sent\":false,\"folder_viewed\":true,\"folder_signed\":false,\"folder_cancelled\":false,\"folder_executed\":false,\"folder_deleted\":false}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerEnvelopeViewedInputWebhookLevelType
    {
        Account,
        [EnumMember(Value = "API App")]
        APIApp
    }

    public class TriggerEnvelopeSignedInput
    {
        [JsonProperty("channelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhookLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerEnvelopeSignedInputWebhookLevelType WebhookLevel { get; set; } = TriggerEnvelopeSignedInputWebhookLevelType.APIApp;

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("allowAll", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool AllowAll { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Events { get; set; } = JToken.Parse("{\"folder_sent\":false,\"folder_viewed\":false,\"folder_signed\":true,\"folder_cancelled\":false,\"folder_executed\":false,\"folder_deleted\":false}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerEnvelopeSignedInputWebhookLevelType
    {
        Account,
        [EnumMember(Value = "API App")]
        APIApp
    }

    public class TriggerEnvelopeCancelledInput
    {
        [JsonProperty("channelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhookLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerEnvelopeCancelledInputWebhookLevelType WebhookLevel { get; set; } = TriggerEnvelopeCancelledInputWebhookLevelType.APIApp;

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("allowAll", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool AllowAll { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Events { get; set; } = JToken.Parse("{\"folder_sent\":false,\"folder_viewed\":false,\"folder_signed\":false,\"folder_cancelled\":true,\"folder_executed\":false,\"folder_deleted\":false}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerEnvelopeCancelledInputWebhookLevelType
    {
        Account,
        [EnumMember(Value = "API App")]
        APIApp
    }

    public class TriggerEnvelopeExecutedInput
    {
        [JsonProperty("channelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhookLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerEnvelopeExecutedInputWebhookLevelType WebhookLevel { get; set; } = TriggerEnvelopeExecutedInputWebhookLevelType.APIApp;

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("allowAll", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool AllowAll { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Events { get; set; } = JToken.Parse("{\"folder_sent\":false,\"folder_viewed\":false,\"folder_signed\":false,\"folder_cancelled\":false,\"folder_executed\":true,\"folder_deleted\":false}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerEnvelopeExecutedInputWebhookLevelType
    {
        Account,
        [EnumMember(Value = "API App")]
        APIApp
    }

    public class TriggerEnvelopeDeletedInput
    {
        [JsonProperty("channelName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChannelName { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("webhookLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public TriggerEnvelopeDeletedInputWebhookLevelType WebhookLevel { get; set; } = TriggerEnvelopeDeletedInputWebhookLevelType.APIApp;

        [JsonProperty("webhookSecret")]
        public string WebhookSecret { get; set; }

        [JsonProperty("allowAll", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool AllowAll { get; set; } = true;

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Events { get; set; } = JToken.Parse("{\"folder_sent\":false,\"folder_viewed\":false,\"folder_signed\":false,\"folder_cancelled\":false,\"folder_executed\":false,\"folder_deleted\":true}");
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggerEnvelopeDeletedInputWebhookLevelType
    {
        Account,
        [EnumMember(Value = "API App")]
        APIApp
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Foxitesign;

    public partial class WorkflowManagedActions
    {
        public FoxitesignActions Foxitesign(string connectionId) => new FoxitesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FoxitesignTriggers Foxitesign(string connectionId) => new FoxitesignTriggers(connectionId);
    }
}