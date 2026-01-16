//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Esign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "esign")]
        public IBodyWorkflowAction<UploadFileResponse> UploadFile(Expression<Func<string>> bodybase64, Expression<Func<string>> bodytitle)
        {
            var apiCallPath = "/v3/pa_uploads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["base64"] = ExpressionConverter.ConvertO(bodybase64);
            body["extension"] = "pdf";
            bodypropCount++;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            body["type"] = "document";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UploadFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "esign")]
        public IWorkflowAction CreateEnvelopeFromTemplate(Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytemplateTitle = null, Expression<Func<string>> bodyuploadFile = null, Expression<Func<string>> bodysubject = null, Expression<Func<bodysignersInputItem[]>> bodysigners = null)
        {
            var apiCallPath = "/v3/pa_envelopes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodytemplateTitle != null)
            {
                body["template_title"] = ExpressionConverter.ConvertO(bodytemplateTitle);
                bodypropCount++;
            }

            if (bodyuploadFile != null)
            {
                body["upload_file"] = ExpressionConverter.ConvertO(bodyuploadFile);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodysigners != null)
            {
                body["signers"] = ExpressionConverter.ConvertO(bodysigners);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class EsignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SignDocument()
        {
            var apiCallPath = "/v3/pa_create_webhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target_url"] = "@listcallbackurl()";
            bodypropCount++;
            body["event"] = "document_signed";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CreatedEnvelope()
        {
            var apiCallPath = "/v3/pa_create_webhook_two";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target_url"] = "@listcallbackurl()";
            bodypropCount++;
            body["event"] = "envelope_created";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CompletedEnvelope()
        {
            var apiCallPath = "/v3/pa_create_webhook_three";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target_url"] = "@listcallbackurl()";
            bodypropCount++;
            body["event"] = "envelope_completed";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class UploadFileResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("envelope_status")]
        public string EnvelopeStatus { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("documents")]
        public UploadFileResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("signers")]
        public UploadFileResponseSignersTypeItem[] Signers { get; set; }

        [JsonProperty("envelope_options")]
        public UploadFileResponseEnvelopeOptionsType EnvelopeOptions { get; set; }

        [JsonProperty("envelope_meta")]
        public UploadFileResponseEnvelopeMetaType EnvelopeMeta { get; set; }

        [JsonProperty("tags")]
        public UploadFileResponseTagsTypeItem[] Tags { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("document_status")]
        public string DocumentStatus { get; set; }

        [JsonProperty("upload_file")]
        public UploadFileResponseDocumentsTypeItemUploadFileType UploadFile { get; set; }

        [JsonProperty("document_file")]
        public UploadFileResponseDocumentsTypeItemDocumentFileType DocumentFile { get; set; }

        [JsonProperty("attachment_files")]
        public UploadFileResponseDocumentsTypeItemAttachmentFilesTypeItem[] AttachmentFiles { get; set; }

        [JsonProperty("last_interaction")]
        public string LastInteraction { get; set; }

        [JsonProperty("document_fields")]
        public UploadFileResponseDocumentsTypeItemDocumentFieldsTypeItem[] DocumentFields { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemUploadFileType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("processing")]
        public bool Processing { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("images")]
        public UploadFileResponseDocumentsTypeItemUploadFileTypeImagesTypeItem[] Images { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemUploadFileTypeImagesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemDocumentFileType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("signature_certificate_page")]
        public int SignatureCertificatePage { get; set; }

        [JsonProperty("images")]
        public UploadFileResponseDocumentsTypeItemDocumentFileTypeImagesTypeItem[] Images { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemDocumentFileTypeImagesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemAttachmentFilesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("processing")]
        public bool Processing { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("images")]
        public UploadFileResponseDocumentsTypeItemAttachmentFilesTypeItemImagesTypeItem[] Images { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemAttachmentFilesTypeItemImagesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemDocumentFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("signer_email")]
        public string SignerEmail { get; set; }

        [JsonProperty("signer_id")]
        public string SignerId { get; set; }

        [JsonProperty("field_type")]
        public string FieldType { get; set; }

        [JsonProperty("field_required")]
        public bool FieldRequired { get; set; }

        [JsonProperty("field_placeholder")]
        public string FieldPlaceholder { get; set; }

        [JsonProperty("field_amount")]
        public string FieldAmount { get; set; }

        [JsonProperty("field_value")]
        public string FieldValue { get; set; }

        [JsonProperty("field_dropdown_options")]
        public string[] FieldDropdownOptions { get; set; }

        [JsonProperty("document_position")]
        public UploadFileResponseDocumentsTypeItemDocumentFieldsTypeItemDocumentPositionType DocumentPosition { get; set; }
    }

    public class UploadFileResponseDocumentsTypeItemDocumentFieldsTypeItemDocumentPositionType
    {
        [JsonProperty("x")]
        public string X { get; set; }

        [JsonProperty("y")]
        public string Y { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public class UploadFileResponseSignersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("viewed")]
        public UploadFileResponseSignersTypeItemViewedType Viewed { get; set; }

        [JsonProperty("envelope_status")]
        public UploadFileResponseSignersTypeItemEnvelopeStatusType EnvelopeStatus { get; set; }

        [JsonProperty("individual_document_status")]
        public UploadFileResponseSignersTypeItemIndividualDocumentStatusTypeItem[] IndividualDocumentStatus { get; set; }

        [JsonProperty("signer_details")]
        public UploadFileResponseSignersTypeItemSignerDetailsType SignerDetails { get; set; }
    }

    public class UploadFileResponseSignersTypeItemViewedType
    {
        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("amount_of_times")]
        public int AmountOfTimes { get; set; }
    }

    public class UploadFileResponseSignersTypeItemEnvelopeStatusType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("signed_at")]
        public string SignedAt { get; set; }

        [JsonProperty("declined_at")]
        public string DeclinedAt { get; set; }
    }

    public class UploadFileResponseSignersTypeItemIndividualDocumentStatusTypeItem
    {
        [JsonProperty("document_id")]
        public string DocumentId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("signed_at")]
        public string SignedAt { get; set; }

        [JsonProperty("declined_at")]
        public string DeclinedAt { get; set; }

        [JsonProperty("declined_reason")]
        public string DeclinedReason { get; set; }
    }

    public class UploadFileResponseSignersTypeItemSignerDetailsType
    {
        [JsonProperty("authenticated_user")]
        public bool AuthenticatedUser { get; set; }

        [JsonProperty("current_sequential_signer")]
        public bool CurrentSequentialSigner { get; set; }

        [JsonProperty("registered_user")]
        public bool RegisteredUser { get; set; }

        [JsonProperty("id_checker_document")]
        public string IdCheckerDocument { get; set; }
    }

    public class UploadFileResponseEnvelopeOptionsType
    {
        [JsonProperty("dont_send_signing_emails")]
        public bool DontSendSigningEmails { get; set; }

        [JsonProperty("sign_in_sequential_order")]
        public bool SignInSequentialOrder { get; set; }
    }

    public class UploadFileResponseEnvelopeMetaType
    {
        [JsonProperty("last_interaction")]
        public string LastInteraction { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("audit_trail")]
        public UploadFileResponseEnvelopeMetaTypeAuditTrailTypeItem[] AuditTrail { get; set; }

        [JsonProperty("author")]
        public UploadFileResponseEnvelopeMetaTypeAuthorType Author { get; set; }
    }

    public class UploadFileResponseEnvelopeMetaTypeAuditTrailTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("concern")]
        public UploadFileResponseEnvelopeMetaTypeAuditTrailTypeItemConcernType Concern { get; set; }

        [JsonProperty("resource")]
        public UploadFileResponseEnvelopeMetaTypeAuditTrailTypeItemResourceType Resource { get; set; }
    }

    public class UploadFileResponseEnvelopeMetaTypeAuditTrailTypeItemConcernType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }
    }

    public class UploadFileResponseEnvelopeMetaTypeAuditTrailTypeItemResourceType
    {
        [JsonProperty("instance")]
        public string Instance { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class UploadFileResponseEnvelopeMetaTypeAuthorType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class UploadFileResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodysignersInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Esign;

    public partial class WorkflowManagedActions
    {
        public EsignActions Esign(string connectionId) => new EsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EsignTriggers Esign(string connectionId) => new EsignTriggers(connectionId);
    }
}