//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Pkisigning
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PkisigningActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel[]> ActorsList(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<bool>> hasActed = null)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}/Actors", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (hasActed != null)
                callPayload.Queries["hasActed"] = ExpressionConverter.Convert(hasActed);
            return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsCreate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<actorModelactionInput>> actorModelaction, Expression<Func<string>> actorModelfirstname, Expression<Func<string>> actorModellastname, Expression<Func<string>> actorModelemail, Expression<Func<string>> actorModelmobile, Expression<Func<string>> actorModeldeadline, Expression<Func<actorModellanguageInput>> actorModellanguage, Expression<Func<bool>> actorModelvalidateRealIdentity, Expression<Func<string>> actorModelprefix = null, Expression<Func<int>> actorModeldossierPersonId = null, Expression<Func<string>> actorModelmessage = null, Expression<Func<string>> actorModelfieldName = null, Expression<Func<string>> actorModelplaceholder = null)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}/Actors", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actorModel = new JObject();
            var actorModelpropCount = 0;
            actorModelpropCount++;
            actorModel["action"] = ExpressionConverter.ConvertO(actorModelaction);
            actorModelpropCount++;
            actorModel["firstname"] = ExpressionConverter.ConvertO(actorModelfirstname);
            if (actorModelprefix != null)
            {
                actorModel["prefix"] = ExpressionConverter.ConvertO(actorModelprefix);
                actorModelpropCount++;
            }

            actorModelpropCount++;
            actorModel["lastname"] = ExpressionConverter.ConvertO(actorModellastname);
            actorModelpropCount++;
            actorModel["email"] = ExpressionConverter.ConvertO(actorModelemail);
            actorModelpropCount++;
            actorModel["mobile"] = ExpressionConverter.ConvertO(actorModelmobile);
            actorModelpropCount++;
            actorModel["deadline"] = ExpressionConverter.ConvertO(actorModeldeadline);
            actorModelpropCount++;
            actorModel["language"] = ExpressionConverter.ConvertO(actorModellanguage);
            actorModelpropCount++;
            actorModel["validateRealIdentity"] = ExpressionConverter.ConvertO(actorModelvalidateRealIdentity);
            if (actorModeldossierPersonId != null)
            {
                actorModel["dossierPersonId"] = ExpressionConverter.ConvertO(actorModeldossierPersonId);
                actorModelpropCount++;
            }

            if (actorModelmessage != null)
            {
                actorModel["message"] = ExpressionConverter.ConvertO(actorModelmessage);
                actorModelpropCount++;
            }

            if (actorModelfieldName != null)
            {
                actorModel["fieldName"] = ExpressionConverter.ConvertO(actorModelfieldName);
                actorModelpropCount++;
            }

            if (actorModelplaceholder != null)
            {
                actorModel["placeholder"] = ExpressionConverter.ConvertO(actorModelplaceholder);
                actorModelpropCount++;
            }

            actorModel["sigFieldX"] = 0;
            actorModelpropCount++;
            actorModel["sigFieldY"] = 0;
            actorModelpropCount++;
            actorModel["sigFieldH"] = 0;
            actorModelpropCount++;
            actorModel["sigFieldW"] = 0;
            actorModelpropCount++;
            if (actorModelpropCount > 0)
            {
                callPayload.Body = actorModel;
            }

            return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId, Expression<Func<actorModelModelactionInput>> actorModelModelaction, Expression<Func<string>> actorModelModelfirstname, Expression<Func<string>> actorModelModellastname, Expression<Func<string>> actorModelModelemail, Expression<Func<string>> actorModelModelmobile, Expression<Func<string>> actorModelModeldeadline, Expression<Func<actorModelModellanguageInput>> actorModelModellanguage, Expression<Func<bool>> actorModelModelvalidateRealIdentity, Expression<Func<string>> actorModelModelprefix = null, Expression<Func<int>> actorModelModeldossierPersonId = null, Expression<Func<string>> actorModelModelmessage = null)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var actorModelModel = new JObject();
            var actorModelModelpropCount = 0;
            actorModelModelpropCount++;
            actorModelModel["action"] = ExpressionConverter.ConvertO(actorModelModelaction);
            actorModelModelpropCount++;
            actorModelModel["firstname"] = ExpressionConverter.ConvertO(actorModelModelfirstname);
            if (actorModelModelprefix != null)
            {
                actorModelModel["prefix"] = ExpressionConverter.ConvertO(actorModelModelprefix);
                actorModelModelpropCount++;
            }

            actorModelModelpropCount++;
            actorModelModel["lastname"] = ExpressionConverter.ConvertO(actorModelModellastname);
            actorModelModelpropCount++;
            actorModelModel["email"] = ExpressionConverter.ConvertO(actorModelModelemail);
            actorModelModelpropCount++;
            actorModelModel["mobile"] = ExpressionConverter.ConvertO(actorModelModelmobile);
            actorModelModelpropCount++;
            actorModelModel["deadline"] = ExpressionConverter.ConvertO(actorModelModeldeadline);
            actorModelModelpropCount++;
            actorModelModel["language"] = ExpressionConverter.ConvertO(actorModelModellanguage);
            actorModelModelpropCount++;
            actorModelModel["validateRealIdentity"] = ExpressionConverter.ConvertO(actorModelModelvalidateRealIdentity);
            if (actorModelModeldossierPersonId != null)
            {
                actorModelModel["dossierPersonId"] = ExpressionConverter.ConvertO(actorModelModeldossierPersonId);
                actorModelModelpropCount++;
            }

            if (actorModelModelmessage != null)
            {
                actorModelModel["message"] = ExpressionConverter.ConvertO(actorModelModelmessage);
                actorModelModelpropCount++;
            }

            if (actorModelModelpropCount > 0)
            {
                callPayload.Body = actorModelModel;
            }

            return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel> ActorsGet(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ExtendedSignerModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction ActorsDelete(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<string>> actorId)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}/Actors/{2}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(actorId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<ExtendedSignerModel[]> ActorsRequestActors(Expression<Func<string>> requestId, Expression<Func<bool>> hasActed = null)
        {
            var apiCallPath = String.Format("/requests/{0}/Actors", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (hasActed != null)
                callPayload.Queries["hasActed"] = ExpressionConverter.Convert(hasActed);
            return new ApiConnectionAction<ExtendedSignerModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction ActorsResendCurrentInvite(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/requests/{0}/Actors/ResendCurrentInvite", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction ActorsWithdrawCurrentInvite(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/requests/{0}/Actors/WithdrawCurrentInvite", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<DocumentMetaDataModel> DocumentsGet(Expression<Func<string>> requestId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<DocumentMetaDataModel> DocumentsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> documentId, Expression<Func<metadatadocumentTypeInput>> metadatadocumentType, Expression<Func<string>> metadataname = null, Expression<Func<string>> metadatafilename = null)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var metadata = new JObject();
            var metadatapropCount = 0;
            if (metadataname != null)
            {
                metadata["name"] = ExpressionConverter.ConvertO(metadataname);
                metadatapropCount++;
            }

            if (metadatafilename != null)
            {
                metadata["filename"] = ExpressionConverter.ConvertO(metadatafilename);
                metadatapropCount++;
            }

            metadatapropCount++;
            metadata["documentType"] = ExpressionConverter.ConvertO(metadatadocumentType);
            if (metadatapropCount > 0)
            {
                callPayload.Body = metadata;
            }

            return new ApiConnectionAction<DocumentMetaDataModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction DocumentsDelete(Expression<Func<string>> requestId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/requests/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> OrganisationsGetWorkgroups(Expression<Func<string>> organisationId)
        {
            var apiCallPath = String.Format("/Organisations/{0}/workgroups", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<OrganisationWorkgroup[]> OrganisationsGetWorkgroupsByUser(Expression<Func<string>> organisationId, Expression<Func<string>> modelusername)
        {
            var apiCallPath = String.Format("/Organisations/{0}/workgroups", ExpressionConverter.ConvertWithUrlEncoding(organisationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            modelpropCount++;
            model["username"] = ExpressionConverter.ConvertO(modelusername);
            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<OrganisationWorkgroup[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel> RequestsCreate(Expression<Func<string>> modelname, Expression<Func<int>> modelclearancelevel, Expression<Func<string>> modelworkgroupId = null, Expression<Func<string>> modelowner = null)
        {
            var apiCallPath = "/requests";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            modelpropCount++;
            model["name"] = ExpressionConverter.ConvertO(modelname);
            if (modelworkgroupId != null)
            {
                model["workgroupId"] = ExpressionConverter.ConvertO(modelworkgroupId);
                modelpropCount++;
            }

            modelpropCount++;
            model["clearancelevel"] = ExpressionConverter.ConvertO(modelclearancelevel);
            if (modelowner != null)
            {
                model["owner"] = ExpressionConverter.ConvertO(modelowner);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<RequestModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel> RequestsGet(Expression<Func<string>> requestId, Expression<Func<string>> callbackAuthenticationKey = null)
        {
            var apiCallPath = String.Format("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (callbackAuthenticationKey != null)
                callPayload.Queries["callbackAuthenticationKey"] = ExpressionConverter.Convert(callbackAuthenticationKey);
            return new ApiConnectionAction<RequestModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<RequestModel> RequestsUpdate(Expression<Func<string>> requestId, Expression<Func<string>> modelname, Expression<Func<int>> modelclearancelevel, Expression<Func<string>> modelworkgroupId = null, Expression<Func<string>> modelowner = null)
        {
            var apiCallPath = String.Format("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            modelpropCount++;
            model["name"] = ExpressionConverter.ConvertO(modelname);
            if (modelworkgroupId != null)
            {
                model["workgroupId"] = ExpressionConverter.ConvertO(modelworkgroupId);
                modelpropCount++;
            }

            modelpropCount++;
            model["clearancelevel"] = ExpressionConverter.ConvertO(modelclearancelevel);
            if (modelowner != null)
            {
                model["owner"] = ExpressionConverter.ConvertO(modelowner);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<RequestModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction RequestsDelete(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IBodyWorkflowAction<object> RequestsDownload(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/requests/{0}/Download", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pkisigning")]
        public IWorkflowAction RequestsSend(Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/requests/{0}/Send", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class PkisigningTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExtendedSignerModel
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("sigFieldX")]
        public double SigFieldX { get; set; }

        [JsonProperty("sigFieldY")]
        public double SigFieldY { get; set; }

        [JsonProperty("sigFieldH")]
        public double SigFieldH { get; set; }

        [JsonProperty("sigFieldW")]
        public double SigFieldW { get; set; }

        [JsonProperty("action")]
        public ExtendedSignerModelActionType Action { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("language")]
        public ExtendedSignerModelLanguageType Language { get; set; }

        [JsonProperty("validateRealIdentity")]
        public bool ValidateRealIdentity { get; set; }

        [JsonProperty("dossierPersonId")]
        public int DossierPersonId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("signingDate")]
        public string SigningDate { get; set; }

        [JsonProperty("hasSigned")]
        public bool HasSigned { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("emailActivity")]
        public EmailActivity[] EmailActivity { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    public enum ExtendedSignerModelActionType
    {
        Sign,
        Download,
        Approve
    }

    public enum ExtendedSignerModelLanguageType
    {
        NL,
        EN
    }

    public class EmailActivity
    {
        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("pkisMessageType")]
        public string PkisMessageType { get; set; }

        [JsonProperty("pkisInviteId")]
        public string PkisInviteId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public enum actorModelactionInput
    {
        Sign,
        Download,
        Approve
    }

    public enum actorModellanguageInput
    {
        NL,
        EN
    }

    public enum actorModelModelactionInput
    {
        Sign,
        Download,
        Approve
    }

    public enum actorModelModellanguageInput
    {
        NL,
        EN
    }

    public class DocumentMetaDataModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public DocumentMetaDataModelStatusType Status { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signatures")]
        public SignatureData[] Signatures { get; set; }

        [JsonProperty("emptySignatureFields")]
        public SignatureField[] EmptySignatureFields { get; set; }

        [JsonProperty("containsBlankSignatureFields")]
        public bool ContainsBlankSignatureFields { get; set; }

        [JsonProperty("actors")]
        public ExtendedSignerModel[] Actors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }

        [JsonProperty("signerNote")]
        public string SignerNote { get; set; }

        [JsonProperty("recipientNote")]
        public string RecipientNote { get; set; }

        [JsonProperty("isMyDocument")]
        public bool IsMyDocument { get; set; }

        [JsonProperty("dossierIndex")]
        public int DossierIndex { get; set; }

        [JsonProperty("documentSize")]
        public int DocumentSize { get; set; }

        [JsonProperty("documentType")]
        public DocumentMetaDataModelDocumentTypeType DocumentType { get; set; }
    }

    public enum DocumentMetaDataModelStatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Elapsed,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature,
        PendingDetermination
    }

    public class SignatureData
    {
        [JsonProperty("subject")]
        public KeyValuePairOfStringAndString[] Subject { get; set; }

        [JsonProperty("issuer")]
        public KeyValuePairOfStringAndString[] Issuer { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("euQualified")]
        public bool EuQualified { get; set; }

        [JsonProperty("advanced")]
        public bool Advanced { get; set; }

        [JsonProperty("eSeal")]
        public bool ESeal { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("signatureField")]
        public string SignatureField { get; set; }

        [JsonProperty("signatureImage")]
        public string SignatureImage { get; set; }
    }

    public class KeyValuePairOfStringAndString
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SignatureField
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    public enum DocumentMetaDataModelDocumentTypeType
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    public enum metadatadocumentTypeInput
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    public class OrganisationWorkgroup
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RequestModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dossierName")]
        public string DossierName { get; set; }

        [JsonProperty("documents")]
        public DocumentModel[] Documents { get; set; }

        [JsonProperty("status")]
        public RequestModelStatusType Status { get; set; }

        [JsonProperty("actors")]
        public ExtendedSignerModel[] Actors { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("signatures")]
        public SignatureData[] Signatures { get; set; }

        [JsonProperty("dossierType")]
        public RequestModelDossierTypeType DossierType { get; set; }

        [JsonProperty("reasons")]
        public string Reasons { get; set; }

        [JsonProperty("signerNote")]
        public string SignerNote { get; set; }

        [JsonProperty("recipientNote")]
        public string RecipientNote { get; set; }

        [JsonProperty("accorderNote")]
        public string AccorderNote { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("emailActivity")]
        public EmailActivity[] EmailActivity { get; set; }

        [JsonProperty("myDossier")]
        public bool MyDossier { get; set; }

        [JsonProperty("taxPaymentStatus")]
        public string TaxPaymentStatus { get; set; }

        [JsonProperty("workgroup")]
        public string Workgroup { get; set; }

        [JsonProperty("clearancelevel")]
        public int Clearancelevel { get; set; }
    }

    public class DocumentModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("documentType")]
        public DocumentModelDocumentTypeType DocumentType { get; set; }

        [JsonProperty("dossierIndex")]
        public int DossierIndex { get; set; }

        [JsonProperty("documentstatus")]
        public DocumentModelDocumentstatusType Documentstatus { get; set; }

        [JsonProperty("actors")]
        public SignerModel[] Actors { get; set; }
    }

    public enum DocumentModelDocumentTypeType
    {
        RegularPdf,
        XbrlPublicationVersionAnnualReport,
        XbrlAuditorsReport,
        DetachedSignature,
        XbrlPreparerExtension,
        PdfAudittrail,
        XbrlCompositionStatement,
        XbrlStatutoryVersionAnnualReport,
        DNBStaat,
        RegularXml,
        ReferencedDocument,
        Json,
        JsonSignature,
        GenericTextFile,
        VatDeclaration,
        VatEuRecapitulativeStatement,
        IncomeTaxDeclaration,
        CorporateTaxDeclaration,
        XbrlNexusVersionAnnualReport,
        XbrlAuditorsReportSFO,
        XbrlAssessmentStatement,
        SignatureStylesheet,
        EnvelopingSignatureData,
        PageImage,
        SHA256Hash,
        SHA256Signature,
        Unspecified
    }

    public enum DocumentModelDocumentstatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Elapsed,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature,
        PendingDetermination
    }

    public class SignerModel
    {
        [JsonProperty("action")]
        public SignerModelActionType Action { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("language")]
        public SignerModelLanguageType Language { get; set; }

        [JsonProperty("validateRealIdentity")]
        public bool ValidateRealIdentity { get; set; }

        [JsonProperty("dossierPersonId")]
        public int DossierPersonId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("sigFieldX")]
        public double SigFieldX { get; set; }

        [JsonProperty("sigFieldY")]
        public double SigFieldY { get; set; }

        [JsonProperty("sigFieldH")]
        public double SigFieldH { get; set; }

        [JsonProperty("sigFieldW")]
        public double SigFieldW { get; set; }
    }

    public enum SignerModelActionType
    {
        Sign,
        Download,
        Approve
    }

    public enum SignerModelLanguageType
    {
        NL,
        EN
    }

    public enum RequestModelStatusType
    {
        Active,
        Completed,
        Declined,
        Processing,
        Error,
        PendingSbrNexus,
        Withdrawn,
        PendingDigipoort,
        New,
        Filing,
        InvitationExpired,
        Expired,
        PendingApproval,
        PendingDownload,
        PendingSignature
    }

    public enum RequestModelDossierTypeType
    {
        IcpDeclaration,
        IncomeTaxDeclaration,
        VatDeclaration,
        Unknown,
        PDF,
        FinancialStatements,
        SbrAssurance,
        SbrNexusAssurance,
        SbrNexusAnnualReport,
        CorporateTaxDeclaration,
        Incomplete,
        AnnualFinancialFiles
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Pkisigning;

    public partial class WorkflowManagedActions
    {
        public PkisigningActions Pkisigning(string connectionId) => new PkisigningActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PkisigningTriggers Pkisigning(string connectionId) => new PkisigningTriggers(connectionId);
    }
}