//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Signinghub
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigninghubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<AboutSigningHubResponse> AboutSigningHub()
        {
            var apiCallPath = "/v1/about";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AboutSigningHubResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<CreateWorkflowResponse> CreateWorkflow(Expression<Func<string>> createWorkflowRequestdocumentContent, Expression<Func<string>> createWorkflowRequestdocumentName)
        {
            var apiCallPath = "/v1/packages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createWorkflowRequest = new JObject();
            var createWorkflowRequestpropCount = 0;
            createWorkflowRequestpropCount++;
            createWorkflowRequest["documentContent"] = ExpressionConverter.ConvertO(createWorkflowRequestdocumentContent);
            createWorkflowRequestpropCount++;
            createWorkflowRequest["documentName"] = ExpressionConverter.ConvertO(createWorkflowRequestdocumentName);
            if (createWorkflowRequestpropCount > 0)
            {
                callPayload.Body = createWorkflowRequest;
            }

            return new ApiConnectionAction<CreateWorkflowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<GetWorkflowsResponseItem[]> GetWorkflows(Expression<Func<getWorkflowsRequestdocumentStatusInput>> getWorkflowsRequestdocumentStatus, Expression<Func<getWorkflowsRequestfolderInput>> getWorkflowsRequestfolder, Expression<Func<int>> getWorkflowsRequestpageNo, Expression<Func<int>> getWorkflowsRequestrecordsPerPage = null, Expression<Func<string>> getWorkflowsRequestsearchText = null)
        {
            var apiCallPath = "/v1/packages/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getWorkflowsRequest = new JObject();
            var getWorkflowsRequestpropCount = 0;
            getWorkflowsRequestpropCount++;
            getWorkflowsRequest["documentStatus"] = ExpressionConverter.ConvertO(getWorkflowsRequestdocumentStatus);
            getWorkflowsRequestpropCount++;
            getWorkflowsRequest["folder"] = ExpressionConverter.ConvertO(getWorkflowsRequestfolder);
            getWorkflowsRequestpropCount++;
            getWorkflowsRequest["pageNo"] = ExpressionConverter.ConvertO(getWorkflowsRequestpageNo);
            if (getWorkflowsRequestrecordsPerPage != null)
            {
                getWorkflowsRequest["recordsPerPage"] = ExpressionConverter.ConvertO(getWorkflowsRequestrecordsPerPage);
                getWorkflowsRequestpropCount++;
            }

            if (getWorkflowsRequestsearchText != null)
            {
                getWorkflowsRequest["searchText"] = ExpressionConverter.ConvertO(getWorkflowsRequestsearchText);
                getWorkflowsRequestpropCount++;
            }

            if (getWorkflowsRequestpropCount > 0)
            {
                callPayload.Body = getWorkflowsRequest;
            }

            return new ApiConnectionAction<GetWorkflowsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<DeleteWorkflowResponse> DeleteWorkflow(Expression<Func<int>> packageId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteWorkflowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<ApproveDocumentResponse> ApproveDocument(Expression<Func<int>> packageId, Expression<Func<string>> approveDocumentRequestapproveReason = null)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/approve", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var approveDocumentRequest = new JObject();
            var approveDocumentRequestpropCount = 0;
            if (approveDocumentRequestapproveReason != null)
            {
                approveDocumentRequest["approveReason"] = ExpressionConverter.ConvertO(approveDocumentRequestapproveReason);
                approveDocumentRequestpropCount++;
            }

            if (approveDocumentRequestpropCount > 0)
            {
                callPayload.Body = approveDocumentRequest;
            }

            return new ApiConnectionAction<ApproveDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<DownloadWorkflowResponse> DownloadWorkflow(Expression<Func<int>> packageId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/base64", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DownloadWorkflowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<CompleteWorkflowResponse> CompleteWorkflow(Expression<Func<string>> packageId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/complete", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CompleteWorkflowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<DeclineDocumentResponse> DeclineDocument(Expression<Func<int>> packageId, Expression<Func<string>> declineDocumentRequestdeclineReason)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/decline", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var declineDocumentRequest = new JObject();
            var declineDocumentRequestpropCount = 0;
            declineDocumentRequestpropCount++;
            declineDocumentRequest["declineReason"] = ExpressionConverter.ConvertO(declineDocumentRequestdeclineReason);
            if (declineDocumentRequestpropCount > 0)
            {
                callPayload.Body = declineDocumentRequest;
            }

            return new ApiConnectionAction<DeclineDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument(Expression<Func<int>> packageId, Expression<Func<string>> uploadDocumentRequestdocumentContent, Expression<Func<string>> uploadDocumentRequestdocumentName)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uploadDocumentRequest = new JObject();
            var uploadDocumentRequestpropCount = 0;
            uploadDocumentRequestpropCount++;
            uploadDocumentRequest["documentContent"] = ExpressionConverter.ConvertO(uploadDocumentRequestdocumentContent);
            uploadDocumentRequestpropCount++;
            uploadDocumentRequest["documentName"] = ExpressionConverter.ConvertO(uploadDocumentRequestdocumentName);
            if (uploadDocumentRequestpropCount > 0)
            {
                callPayload.Body = uploadDocumentRequest;
            }

            return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<DownloadDocumentResponse> DownloadDocument(Expression<Func<int>> packageId, Expression<Func<int>> documentId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/documents/{1}/base64", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DownloadDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<SignDocumentResponse> SignDocument(Expression<Func<int>> packageId, Expression<Func<int>> documentId, Expression<Func<int>> signDocumentRequestpageNo, Expression<Func<signDocumentRequestpagePositionInput>> signDocumentRequestpagePosition, Expression<Func<int>> signDocumentRequestpageX = null, Expression<Func<int>> signDocumentRequestpageY = null)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/documents/{1}/sign", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var signDocumentRequest = new JObject();
            var signDocumentRequestpropCount = 0;
            signDocumentRequestpropCount++;
            signDocumentRequest["pageNo"] = ExpressionConverter.ConvertO(signDocumentRequestpageNo);
            signDocumentRequestpropCount++;
            signDocumentRequest["pagePosition"] = ExpressionConverter.ConvertO(signDocumentRequestpagePosition);
            if (signDocumentRequestpageX != null)
            {
                signDocumentRequest["pageX"] = ExpressionConverter.ConvertO(signDocumentRequestpageX);
                signDocumentRequestpropCount++;
            }

            if (signDocumentRequestpageY != null)
            {
                signDocumentRequest["pageY"] = ExpressionConverter.ConvertO(signDocumentRequestpageY);
                signDocumentRequestpropCount++;
            }

            if (signDocumentRequestpropCount > 0)
            {
                callPayload.Body = signDocumentRequest;
            }

            return new ApiConnectionAction<SignDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<ApplyTemplateResponse> ApplyTemplate(Expression<Func<int>> packageId, Expression<Func<int>> documentId, Expression<Func<bool>> applyTemplateRequestapplyToAll, Expression<Func<string>> applyTemplateRequesttemplateName)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/documents/{1}/template", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var applyTemplateRequest = new JObject();
            var applyTemplateRequestpropCount = 0;
            applyTemplateRequestpropCount++;
            applyTemplateRequest["applyToAll"] = ExpressionConverter.ConvertO(applyTemplateRequestapplyToAll);
            applyTemplateRequestpropCount++;
            applyTemplateRequest["templateName"] = ExpressionConverter.ConvertO(applyTemplateRequesttemplateName);
            if (applyTemplateRequestpropCount > 0)
            {
                callPayload.Body = applyTemplateRequest;
            }

            return new ApiConnectionAction<ApplyTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<ShareWorkflowResponseItem[]> ShareWorkflow(Expression<Func<int>> packageId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/share", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShareWorkflowResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<GetWorkflowDetailsResponseItem[]> GetWorkflowDetails(Expression<Func<int>> packageId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/workflow", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetWorkflowDetailsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<GetRecipientsResponse> GetRecipients(Expression<Func<int>> packageId)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/workflow/recipients", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRecipientsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<AddRecipientResponse> AddRecipient(Expression<Func<int>> packageId, Expression<Func<bool>> addRecipientRequestaddSignatureField, Expression<Func<bool>> addRecipientRequestemailNotification, Expression<Func<addRecipientRequestpagePositionInput>> addRecipientRequestpagePosition, Expression<Func<addRecipientRequestroleInput>> addRecipientRequestrole, Expression<Func<int>> addRecipientRequestsigningOrder, Expression<Func<string>> addRecipientRequestuserEmail, Expression<Func<string>> addRecipientRequestuserName, Expression<Func<int>> addRecipientRequestdocumentId = null, Expression<Func<bool>> addRecipientRequestonlyMe = null, Expression<Func<int>> addRecipientRequestpageNo = null, Expression<Func<int>> addRecipientRequestpageX = null, Expression<Func<int>> addRecipientRequestpageY = null)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/workflow/users", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var addRecipientRequest = new JObject();
            var addRecipientRequestpropCount = 0;
            addRecipientRequestpropCount++;
            addRecipientRequest["addSignatureField"] = ExpressionConverter.ConvertO(addRecipientRequestaddSignatureField);
            if (addRecipientRequestdocumentId != null)
            {
                addRecipientRequest["documentId"] = ExpressionConverter.ConvertO(addRecipientRequestdocumentId);
                addRecipientRequestpropCount++;
            }

            addRecipientRequestpropCount++;
            addRecipientRequest["emailNotification"] = ExpressionConverter.ConvertO(addRecipientRequestemailNotification);
            if (addRecipientRequestonlyMe != null)
            {
                addRecipientRequest["onlyMe"] = ExpressionConverter.ConvertO(addRecipientRequestonlyMe);
                addRecipientRequestpropCount++;
            }

            if (addRecipientRequestpageNo != null)
            {
                addRecipientRequest["pageNo"] = ExpressionConverter.ConvertO(addRecipientRequestpageNo);
                addRecipientRequestpropCount++;
            }

            addRecipientRequestpropCount++;
            addRecipientRequest["pagePosition"] = ExpressionConverter.ConvertO(addRecipientRequestpagePosition);
            if (addRecipientRequestpageX != null)
            {
                addRecipientRequest["pageX"] = ExpressionConverter.ConvertO(addRecipientRequestpageX);
                addRecipientRequestpropCount++;
            }

            if (addRecipientRequestpageY != null)
            {
                addRecipientRequest["pageY"] = ExpressionConverter.ConvertO(addRecipientRequestpageY);
                addRecipientRequestpropCount++;
            }

            addRecipientRequestpropCount++;
            addRecipientRequest["role"] = ExpressionConverter.ConvertO(addRecipientRequestrole);
            addRecipientRequestpropCount++;
            addRecipientRequest["signingOrder"] = ExpressionConverter.ConvertO(addRecipientRequestsigningOrder);
            addRecipientRequestpropCount++;
            addRecipientRequest["userEmail"] = ExpressionConverter.ConvertO(addRecipientRequestuserEmail);
            addRecipientRequestpropCount++;
            addRecipientRequest["userName"] = ExpressionConverter.ConvertO(addRecipientRequestuserName);
            if (addRecipientRequestpropCount > 0)
            {
                callPayload.Body = addRecipientRequest;
            }

            return new ApiConnectionAction<AddRecipientResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<DeleteRecipientResponse> DeleteRecipient(Expression<Func<int>> packageId, Expression<Func<int>> order)
        {
            var apiCallPath = String.Format("/v1/packages/{0}/workflow/{1}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(order, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteRecipientResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<GetContectsResponseItem[]> GetContects(Expression<Func<int>> getContactsRequestpageNo, Expression<Func<int>> getContactsRequestrecordsPerPage, Expression<Func<bool>> getContactsRequestenterprise = null, Expression<Func<string>> getContactsRequestsearchText = null)
        {
            var apiCallPath = "/v1/settings/contacts/list";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getContactsRequest = new JObject();
            var getContactsRequestpropCount = 0;
            if (getContactsRequestenterprise != null)
            {
                getContactsRequest["enterprise"] = ExpressionConverter.ConvertO(getContactsRequestenterprise);
                getContactsRequestpropCount++;
            }

            getContactsRequestpropCount++;
            getContactsRequest["pageNo"] = ExpressionConverter.ConvertO(getContactsRequestpageNo);
            getContactsRequestpropCount++;
            getContactsRequest["recordsPerPage"] = ExpressionConverter.ConvertO(getContactsRequestrecordsPerPage);
            if (getContactsRequestsearchText != null)
            {
                getContactsRequest["searchText"] = ExpressionConverter.ConvertO(getContactsRequestsearchText);
                getContactsRequestpropCount++;
            }

            if (getContactsRequestpropCount > 0)
            {
                callPayload.Body = getContactsRequest;
            }

            return new ApiConnectionAction<GetContectsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "signinghub")]
        public IBodyWorkflowAction<GetTemplatesResponse> GetTemplates()
        {
            var apiCallPath = "/v1/settings/templates/enterprise";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTemplatesResponse>(callPayload);
        }
    }

    public class SigninghubTriggers([ConnectionName] string connectionId)
    {
    }

    public class AboutSigningHubResponse
    {
        [JsonProperty("aboutSigningHub")]
        public AboutSigningHubResponseAboutSigningHubType AboutSigningHub { get; set; }
    }

    public class AboutSigningHubResponseAboutSigningHubType
    {
        [JsonProperty("build")]
        public string Build { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("installation_name")]
        public string InstallationName { get; set; }

        [JsonProperty("patents")]
        public AboutSigningHubResponseAboutSigningHubTypePatentsType Patents { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class AboutSigningHubResponseAboutSigningHubTypePatentsType
    {
        [JsonProperty("us_patent_no")]
        public string UsPatentNo { get; set; }
    }

    public class CreateWorkflowResponse
    {
        [JsonProperty("documentId")]
        public int DocumentId { get; set; }

        [JsonProperty("packageId")]
        public int PackageId { get; set; }
    }

    public class GetWorkflowsResponseItem
    {
        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        [JsonProperty("next_signer")]
        public string NextSigner { get; set; }

        [JsonProperty("next_signer_email")]
        public GetWorkflowsResponseItemNextSignerEmailTypeItem[] NextSignerEmail { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("package_id")]
        public int PackageId { get; set; }

        [JsonProperty("package_name")]
        public string PackageName { get; set; }

        [JsonProperty("package_owner")]
        public string PackageOwner { get; set; }

        [JsonProperty("package_status")]
        public string PackageStatus { get; set; }

        [JsonProperty("unread")]
        public bool Unread { get; set; }

        [JsonProperty("uploaded_on")]
        public string UploadedOn { get; set; }
    }

    public class GetWorkflowsResponseItemNextSignerEmailTypeItem
    {
        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }

    public enum getWorkflowsRequestdocumentStatusInput
    {
        ALL,
        DRAFT,
        PENDING,
        SIGNED,
        DECLINED,
        INPROGRESS,
        COMPLETED
    }

    public enum getWorkflowsRequestfolderInput
    {
        INBOX,
        ARCHIVE
    }

    public class DeleteWorkflowResponse
    {
        [JsonProperty("packageDeleted")]
        public bool PackageDeleted { get; set; }
    }

    public class ApproveDocumentResponse
    {
        [JsonProperty("documentApproved")]
        public bool DocumentApproved { get; set; }
    }

    public class DownloadWorkflowResponse
    {
        [JsonProperty("packageContent")]
        public string PackageContent { get; set; }

        [JsonProperty("packageType")]
        public string PackageType { get; set; }
    }

    public class CompleteWorkflowResponse
    {
        [JsonProperty("workflowCompleted")]
        public bool WorkflowCompleted { get; set; }
    }

    public class DeclineDocumentResponse
    {
        [JsonProperty("documentDeclined")]
        public bool DocumentDeclined { get; set; }
    }

    public class UploadDocumentResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    public class DownloadDocumentResponse
    {
        [JsonProperty("documentContent")]
        public string DocumentContent { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }
    }

    public class SignDocumentResponse
    {
        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public enum signDocumentRequestpagePositionInput
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight,
        Center
    }

    public class ApplyTemplateResponse
    {
        [JsonProperty("applyTemplate")]
        public ApplyTemplateResponseApplyTemplateType ApplyTemplate { get; set; }
    }

    public class ApplyTemplateResponseApplyTemplateType
    {
        [JsonProperty("certify")]
        public ApplyTemplateResponseApplyTemplateTypeCertifyType Certify { get; set; }

        [JsonProperty("document_height")]
        public int DocumentHeight { get; set; }

        [JsonProperty("document_id")]
        public int DocumentId { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("document_order")]
        public int DocumentOrder { get; set; }

        [JsonProperty("document_pages")]
        public int DocumentPages { get; set; }

        [JsonProperty("document_source")]
        public string DocumentSource { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("document_width")]
        public int DocumentWidth { get; set; }

        [JsonProperty("form_fields")]
        public bool FormFields { get; set; }

        [JsonProperty("lock_form_fields")]
        public bool LockFormFields { get; set; }

        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        [JsonProperty("template")]
        public ApplyTemplateResponseApplyTemplateTypeTemplateType Template { get; set; }

        [JsonProperty("uploaded_on")]
        public string UploadedOn { get; set; }
    }

    public class ApplyTemplateResponseApplyTemplateTypeCertifyType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }
    }

    public class ApplyTemplateResponseApplyTemplateTypeTemplateType
    {
        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }
    }

    public class ShareWorkflowResponseItem
    {
        [JsonProperty("packageID")]
        public int PackageID { get; set; }
    }

    public class GetWorkflowDetailsResponseItem
    {
        [JsonProperty("documents")]
        public GetWorkflowDetailsResponseItemDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        [JsonProperty("next_signer")]
        public string NextSigner { get; set; }

        [JsonProperty("next_signer_email")]
        public JToken[] NextSignerEmail { get; set; }

        [JsonProperty("owner_name")]
        public string OwnerName { get; set; }

        [JsonProperty("package_id")]
        public int PackageId { get; set; }

        [JsonProperty("package_name")]
        public string PackageName { get; set; }

        [JsonProperty("package_owner")]
        public string PackageOwner { get; set; }

        [JsonProperty("package_status")]
        public string PackageStatus { get; set; }

        [JsonProperty("uploaded_on")]
        public string UploadedOn { get; set; }

        [JsonProperty("users")]
        public JToken[] Users { get; set; }

        [JsonProperty("workflow")]
        public GetWorkflowDetailsResponseItemWorkflowType Workflow { get; set; }
    }

    public class GetWorkflowDetailsResponseItemDocumentsTypeItem
    {
        [JsonProperty("certify")]
        public GetWorkflowDetailsResponseItemDocumentsTypeItemCertifyType Certify { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("document_height")]
        public int DocumentHeight { get; set; }

        [JsonProperty("document_id")]
        public int DocumentId { get; set; }

        [JsonProperty("document_name")]
        public string DocumentName { get; set; }

        [JsonProperty("document_order")]
        public int DocumentOrder { get; set; }

        [JsonProperty("document_pages")]
        public int DocumentPages { get; set; }

        [JsonProperty("document_source")]
        public string DocumentSource { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("document_width")]
        public int DocumentWidth { get; set; }

        [JsonProperty("form_fields")]
        public bool FormFields { get; set; }

        [JsonProperty("lock_form_fields")]
        public bool LockFormFields { get; set; }

        [JsonProperty("modified_on")]
        public string ModifiedOn { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }
    }

    public class GetWorkflowDetailsResponseItemDocumentsTypeItemCertifyType
    {
        [JsonProperty("allowed_permissions")]
        public string[] AllowedPermissions { get; set; }

        [JsonProperty("default_permission")]
        public string DefaultPermission { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class GetWorkflowDetailsResponseItemWorkflowType
    {
        [JsonProperty("continue_on_decline")]
        public bool ContinueOnDecline { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("post_process")]
        public GetWorkflowDetailsResponseItemWorkflowTypePostProcessType PostProcess { get; set; }

        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("workflow_mode")]
        public string WorkflowMode { get; set; }

        [JsonProperty("workflow_status")]
        public string WorkflowStatus { get; set; }

        [JsonProperty("workflow_type")]
        public string WorkflowType { get; set; }
    }

    public class GetWorkflowDetailsResponseItemWorkflowTypePostProcessType
    {
        [JsonProperty("contacts")]
        public JToken[] Contacts { get; set; }

        [JsonProperty("dropbox")]
        public bool Dropbox { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("google_drive")]
        public bool GoogleDrive { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("recipients")]
        public string Recipients { get; set; }

        [JsonProperty("workflow_recipients")]
        public bool WorkflowRecipients { get; set; }
    }

    public class GetRecipientsResponse
    {
        [JsonProperty("recipients")]
        public GetRecipientsResponseRecipientsTypeItem[] Recipients { get; set; }
    }

    public class GetRecipientsResponseRecipientsTypeItem
    {
        [JsonProperty("delegatee")]
        public string Delegatee { get; set; }

        [JsonProperty("delegatee_name")]
        public string DelegateeName { get; set; }

        [JsonProperty("group_members")]
        public string GroupMembers { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("process_status")]
        public string ProcessStatus { get; set; }

        [JsonProperty("processed_as")]
        public string ProcessedAs { get; set; }

        [JsonProperty("processed_by")]
        public string ProcessedBy { get; set; }

        [JsonProperty("processed_on")]
        public string ProcessedOn { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("signing_order")]
        public int SigningOrder { get; set; }

        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_national_id")]
        public string UserNationalId { get; set; }
    }

    public class AddRecipientResponse
    {
        [JsonProperty("recipientAdded")]
        public bool RecipientAdded { get; set; }
    }

    public enum addRecipientRequestpagePositionInput
    {
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight,
        Center
    }

    public enum addRecipientRequestroleInput
    {
        SIGNER,
        REVIEWER,
        EDITOR,
        [EnumMember(Value = "CARBON_COPY")]
        CARBONCOPY,
        [EnumMember(Value = "INPERSON_HOST")]
        INPERSONHOST
    }

    public class DeleteRecipientResponse
    {
        [JsonProperty("recipientDeleted")]
        public bool RecipientDeleted { get; set; }
    }

    public class GetContectsResponseItem
    {
        [JsonProperty("user_email")]
        public string UserEmail { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_national_id")]
        public string UserNationalId { get; set; }
    }

    public class GetTemplatesResponse
    {
        [JsonProperty("templatesCollection")]
        public GetTemplatesResponseTemplatesCollectionTypeItem[] TemplatesCollection { get; set; }
    }

    public class GetTemplatesResponseTemplatesCollectionTypeItem
    {
        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        [JsonProperty("template_id")]
        public int TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("template_public")]
        public bool TemplatePublic { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Signinghub;

    public partial class WorkflowManagedActions
    {
        public SigninghubActions Signinghub(string connectionId) => new SigninghubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigninghubTriggers Signinghub(string connectionId) => new SigninghubTriggers(connectionId);
    }
}