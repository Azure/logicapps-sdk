//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Marksign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarksignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<UploadDocumentResponse, ApiConnectionActionConfiguration> UploadDocument(Expression<Func<string>> fileName, Expression<Func<string>> body, Expression<Func<BillingTypeInput>> billingType, Expression<Func<AccessInput>> access = null)
        {
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_billingType = WorkflowExpression.Compile(billingType, nameof(billingType), required: true);
            var __workflow_access = WorkflowExpression.Compile(access, nameof(access), required: false);
            return new DeferredBodyAction<UploadDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/document/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_name"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Queries["access"] = Convert.ToString("private");
                if (__workflow_access != null)
                    callPayload.Queries["access"] = ExpressionConverter.Convert(__workflow_access);
                callPayload.Queries["billing_type"] = ExpressionConverter.Convert(__workflow_billingType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<AcknowledgedResponse, ApiConnectionActionConfiguration> InviteSigner(Expression<Func<string>> documentId, Expression<Func<InviteSignerBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AcknowledgedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/signer", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AcknowledgedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<GetSignersResponse, ApiConnectionActionConfiguration> GetSigners(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetSignersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/signer", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSignersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<AcknowledgedResponse, ApiConnectionActionConfiguration> WaitForSignatureEvent(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<AcknowledgedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/power-automate/document/{0}/wait-event", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WaitForSignatureEventBodyInput().ToJToken();
                return new ApiConnectionAction<AcknowledgedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<SigningWaitResponse, ApiConnectionActionConfiguration> WaitForSignature(Expression<Func<string>> documentId, Expression<Func<int>> timeoutMinutes = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_timeoutMinutes = WorkflowExpression.Compile(timeoutMinutes, nameof(timeoutMinutes), required: false);
            return new DeferredBodyAction<SigningWaitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/power-automate/document/{0}/wait-for-signing", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeoutMinutes != null)
                    callPayload.Queries["timeout_minutes"] = ExpressionConverter.Convert(__workflow_timeoutMinutes);
                return new ApiConnectionAction<SigningWaitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<GetDocumentStatusResponse, ApiConnectionActionConfiguration> GetDocumentStatus(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/{0}/check-status", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/download", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<ListDocumentsResponse, ApiConnectionActionConfiguration> ListDocuments(Expression<Func<string>> query = null, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ListDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<AcknowledgedResponse, ApiConnectionActionConfiguration> RemoveDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<AcknowledgedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AcknowledgedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<CreateContainerResponse, ApiConnectionActionConfiguration> CreateContainer(Expression<Func<CreateContainerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateContainerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-automate/document/create-container";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateContainerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<CreateSignerLinksResponse, ApiConnectionActionConfiguration> CreateSignerLinks(Expression<Func<CreateSignerLinksBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSignerLinksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/document/generate-temporary-signing-link";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSignerLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<AcknowledgedResponse, ApiConnectionActionConfiguration> DeleteSigningLink(Expression<Func<string>> temporarySigningLinkId)
        {
            var __workflow_temporarySigningLinkId = WorkflowExpression.Compile(temporarySigningLinkId, nameof(temporarySigningLinkId), required: true);
            return new DeferredBodyAction<AcknowledgedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/signing-link/{0}", __workflow_temporarySigningLinkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AcknowledgedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<AcknowledgedResponse, ApiConnectionActionConfiguration> ExtendSignatures(Expression<Func<string>> documentId, Expression<Func<ExtendSignaturesBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AcknowledgedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/power-automate/document/{0}/extend", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AcknowledgedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<ValidateDocumentResponse, ApiConnectionActionConfiguration> ValidateDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<ValidateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/power-automate/document/{0}/validate", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ValidateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<SigningWaitResponse, ApiConnectionActionConfiguration> WaitForSigner(Expression<Func<string>> documentId, Expression<Func<string>> signerEmail, Expression<Func<int>> timeoutMinutes = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_signerEmail = WorkflowExpression.Compile(signerEmail, nameof(signerEmail), required: true);
            var __workflow_timeoutMinutes = WorkflowExpression.Compile(timeoutMinutes, nameof(timeoutMinutes), required: false);
            return new DeferredBodyAction<SigningWaitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/power-automate/document/{0}/wait-for-signer", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["signer_email"] = ExpressionConverter.Convert(__workflow_signerEmail);
                if (__workflow_timeoutMinutes != null)
                    callPayload.Queries["timeout_minutes"] = ExpressionConverter.Convert(__workflow_timeoutMinutes);
                return new ApiConnectionAction<SigningWaitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<CreateSharedLinkResponse, ApiConnectionActionConfiguration> CreateSharedLink(Expression<Func<CreateSharedLinkBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSharedLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/power-automate/document/shared-link";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSharedLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marksign")]
        public IBodyWorkflowAction<InviteByLinkResponse, ApiConnectionActionConfiguration> InviteByLink(Expression<Func<string>> documentId, Expression<Func<InviteByLinkBodyInput>> body)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InviteByLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/power-automate/document/{0}/invite-by-link", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InviteByLinkResponse>(callPayload);
            });
        }
    }

    public class MarksignTriggers([ConnectionName] string connectionId)
    {
    }

    public class UploadDocumentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public UploadDocumentResponseDocumentType Document { get; set; }
    }

    public class UploadDocumentResponseDocumentType
    {
        [JsonProperty("uuid")]
        public string DocumentId { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BillingTypeInput
    {
        [EnumMember(Value = "document_owner")]
        DocumentOwner,
        [EnumMember(Value = "each_signer")]
        EachSigner
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccessInput
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public
    }

    public class AcknowledgedResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InviteSignerBodyInput
    {
        public InviteSignerBodyInput(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("surname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("language")]
        public BodyInputLanguageType? Language { get; set; }

        [JsonProperty("success_url")]
        public string SuccessURL { get; set; }

        [JsonProperty("purpose")]
        public SignerPurpose? Purpose { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackURL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLanguageType
    {
        [EnumMember(Value = "lt")]
        Lithuanian,
        [EnumMember(Value = "en")]
        English,
        [EnumMember(Value = "pl")]
        Polish
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SignerPurpose
    {
        [EnumMember(Value = "e_signature")]
        ElectronicSignature,
        [EnumMember(Value = "review")]
        Review,
        [EnumMember(Value = "confirmation")]
        Confirmation,
        [EnumMember(Value = "visa")]
        Visa,
        [EnumMember(Value = "acknowledgement")]
        Acknowledgement
    }

    public class GetSignersResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public GetSignersResponseSignersTypeItem[] Signers { get; set; }
    }

    public class GetSignersResponseSignersTypeItem
    {
        [JsonProperty("id")]
        public string SignerId { get; set; }

        [JsonProperty("name")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string SigningStatus { get; set; }

        [JsonProperty("rejection_reason")]
        public string RejectionReason { get; set; }
    }

    public class WaitForSignatureEventBodyInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class SigningWaitResponse
    {
        [JsonProperty("document_status")]
        public string DocumentStatus { get; set; }

        [JsonProperty("rejected_by")]
        public string RejectedBy { get; set; }

        [JsonProperty("rejection_reason")]
        public string RejectionReason { get; set; }
    }

    public class GetDocumentStatusResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public GetDocumentStatusResponseResultType Result { get; set; }
    }

    public class GetDocumentStatusResponseResultType
    {
        [JsonProperty("document_status")]
        public string DocumentStatus { get; set; }
    }

    public class ListDocumentsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ListDocumentsResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ListDocumentsResponseDocumentsTypeItem
    {
        [JsonProperty("uuid")]
        public string DocumentId { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("status")]
        public string DocumentStatus { get; set; }

        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }
    }

    public class CreateContainerResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public CreateContainerResponseDocumentType Document { get; set; }
    }

    public class CreateContainerResponseDocumentType
    {
        [JsonProperty("uuid")]
        public string DocumentId { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }
    }

    public class CreateContainerBodyInput
    {
        public CreateContainerBodyInput(BodyInputDocumentTypeType documentType, BodyInputFilesTypeItem[] files)
        {
            this.DocumentType = documentType;
            this.Files = files;
        }

        [JsonProperty("document_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDocumentTypeType DocumentType { get; set; }

        [JsonProperty("files", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFilesTypeItem[] Files { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDocumentTypeType
    {
        [EnumMember(Value = "adoc.cedoc")]
        ADocCeDoc,
        [EnumMember(Value = "adoc.bedoc")]
        ADocBeDoc,
        [EnumMember(Value = "adoc.gedoc")]
        ADocGeDoc,
        [EnumMember(Value = "adoc.ggedoc")]
        ADocGGeDoc,
        [EnumMember(Value = "bdoc")]
        BDoc,
        [EnumMember(Value = "asice")]
        ASiCE
    }

    public class BodyInputFilesTypeItem
    {
        public BodyInputFilesTypeItem(string fileName, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent)
        {
            this.FileName = fileName;
            this.FileContent = fileContent;
        }

        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("file_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("adoc_file_type")]
        public BodyInputFilesTypeItemFileTypeADocOnlyType? FileTypeADocOnly { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputFilesTypeItemFileTypeADocOnlyType
    {
        [EnumMember(Value = "main")]
        MainDocument,
        [EnumMember(Value = "appendix")]
        Appendix,
        [EnumMember(Value = "attachment")]
        Attachment
    }

    public class CreateSignerLinksResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("temporary_signing_links")]
        public CreateSignerLinksResponseSigningLinksTypeItem[] SigningLinks { get; set; }

        [JsonProperty("documents")]
        public CreateSignerLinksResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class CreateSignerLinksResponseSigningLinksTypeItem
    {
        [JsonProperty("id")]
        public string SignerId { get; set; }

        [JsonProperty("member_name")]
        public string FirstName { get; set; }

        [JsonProperty("member_surname")]
        public string LastName { get; set; }

        [JsonProperty("member_email")]
        public string Email { get; set; }

        [JsonProperty("temporary_signing_link")]
        public string SigningLink { get; set; }

        [JsonProperty("temporary_signing_link_id")]
        public string SigningLinkId { get; set; }

        [JsonProperty("valid_until")]
        public int ValidUntil { get; set; }
    }

    public class CreateSignerLinksResponseDocumentsTypeItem
    {
        [JsonProperty("uuid")]
        public string DocumentId { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }
    }

    public class CreateSignerLinksBodyInput
    {
        public CreateSignerLinksBodyInput(string[] documentIDs, BodyInputSignersTypeItem[] signers)
        {
            this.DocumentIDs = documentIDs;
            this.Signers = signers;
        }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] DocumentIDs { get; set; }

        [JsonProperty("signers", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSignersTypeItem[] Signers { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackURL { get; set; }

        [JsonProperty("reject_callback_url")]
        public string RejectionCallbackURL { get; set; }

        [JsonProperty("expire_after")]
        public int? ExpireAfterMinutes { get; set; }

        [JsonProperty("show_reject_button")]
        public bool? ShowRejectButton { get; set; }

        [JsonProperty("delete_document_after")]
        public int? DeleteDocumentAfterMinutes { get; set; }
    }

    public class BodyInputSignersTypeItem
    {
        [JsonProperty("id")]
        public string SignerId { get; set; }

        [JsonProperty("name")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("personal_code")]
        public string PersonalCode { get; set; }

        [JsonProperty("authentication_required")]
        public bool? RequireAuthentication { get; set; }

        [JsonProperty("position")]
        public string PositionADocOnly { get; set; }

        [JsonProperty("structural_subdivision")]
        public string DepartmentADocOnly { get; set; }

        [JsonProperty("signing_purpose")]
        public BodyInputSignersTypeItemSigningPurposeADocOnlyType? SigningPurposeADocOnly { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSignersTypeItemSigningPurposeADocOnlyType
    {
        [EnumMember(Value = "signature")]
        Signature,
        [EnumMember(Value = "confirmation")]
        Confirmation,
        [EnumMember(Value = "visa")]
        Visa,
        [EnumMember(Value = "conciliation")]
        Conciliation,
        [EnumMember(Value = "registration")]
        Registration,
        [EnumMember(Value = "registration-of-incomming-documents")]
        RegistrationOfIncomingDocuments,
        [EnumMember(Value = "acknowledgement")]
        Acknowledgement,
        [EnumMember(Value = "notarisation")]
        Notarisation,
        [EnumMember(Value = "copy-certification")]
        CopyCertification,
        [EnumMember(Value = "resolution")]
        Resolution,
        [EnumMember(Value = "end-of-execution")]
        EndOfExecution,
        [EnumMember(Value = "authenticity")]
        Authenticity
    }

    public class ExtendSignaturesBodyInput
    {
        public ExtendSignaturesBodyInput(BodyInputLevelType level)
        {
            this.Level = level;
        }

        [JsonProperty("level", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLevelType Level { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLevelType
    {
        [EnumMember(Value = "LT")]
        LongTermLT,
        [EnumMember(Value = "LTA")]
        LongTermWithArchiveTimestampLTA
    }

    public class ValidateDocumentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public ValidateDocumentResponseValidationReportType ValidationReport { get; set; }

        [JsonProperty("metadata")]
        public ValidateDocumentResponseMetadataType Metadata { get; set; }
    }

    public class ValidateDocumentResponseValidationReportType
    {
        [JsonProperty("document")]
        public ValidateDocumentResponseValidationReportTypeDocumentType Document { get; set; }

        [JsonProperty("signatures")]
        public ValidateDocumentResponseValidationReportTypeSignaturesTypeItem[] Signatures { get; set; }

        [JsonProperty("certificates")]
        public JToken[] Certificates { get; set; }

        [JsonProperty("timestamps")]
        public JToken[] Timestamps { get; set; }
    }

    public class ValidateDocumentResponseValidationReportTypeDocumentType
    {
        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("valid_to")]
        public string ValidTo { get; set; }

        [JsonProperty("name")]
        public string DocumentName { get; set; }

        [JsonProperty("mimetype")]
        public string MIMEType { get; set; }
    }

    public class ValidateDocumentResponseValidationReportTypeSignaturesTypeItem
    {
        [JsonProperty("id")]
        public string SignatureId { get; set; }

        [JsonProperty("signing_time")]
        public string SigningTime { get; set; }

        [JsonProperty("signature_format")]
        public string SignatureFormat { get; set; }

        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("valid_to")]
        public string ValidTo { get; set; }
    }

    public class ValidateDocumentResponseMetadataType
    {
        [JsonProperty("validation_time")]
        public string ValidationTime { get; set; }
    }

    public class CreateSharedLinkResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public CreateSharedLinkResponseLinkType Link { get; set; }
    }

    public class CreateSharedLinkResponseLinkType
    {
        [JsonProperty("signing_link")]
        public string SigningLink { get; set; }

        [JsonProperty("signing_link_id")]
        public string SigningLinkId { get; set; }

        [JsonProperty("valid_until")]
        public int ValidUntil { get; set; }
    }

    public class CreateSharedLinkBodyInput
    {
        public CreateSharedLinkBodyInput(string[] documentIDs)
        {
            this.DocumentIDs = documentIDs;
        }

        [JsonProperty("documents", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] DocumentIDs { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackURL { get; set; }

        [JsonProperty("expire_after")]
        public int? ExpireAfterMinutes { get; set; }

        [JsonProperty("delete_document_after")]
        public int? DeleteDocumentAfterMinutes { get; set; }
    }

    public class InviteByLinkResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public InviteByLinkResponseInvitationType Invitation { get; set; }
    }

    public class InviteByLinkResponseInvitationType
    {
        [JsonProperty("invitation_url")]
        public string InvitationURL { get; set; }
    }

    public class InviteByLinkBodyInput
    {
        public InviteByLinkBodyInput(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FirstName { get; set; }

        [JsonProperty("surname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LastName { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("success_url")]
        public string SuccessURL { get; set; }

        [JsonProperty("purpose")]
        public SignerPurpose? Purpose { get; set; }

        [JsonProperty("callback_url")]
        public string CallbackURL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Marksign;

    public partial class WorkflowManagedActions
    {
        public MarksignActions Marksign(string connectionId) => new MarksignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MarksignTriggers Marksign(string connectionId) => new MarksignTriggers(connectionId);
    }
}