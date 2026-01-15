//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Deepboxsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeepboxsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Document> UploadDocument(Expression<Func<object>> data, Expression<Func<object>> file)
        {
            var apiCallPath = "/api/v1/documents/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Document> GetDocumentDetails(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Observer> AddObserver(Expression<Func<string>> documentId, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyisAdmin = null, Expression<Func<string>> bodylanguage = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/observers", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyisAdmin != null)
            {
                body["isAdmin"] = ExpressionConverter.ConvertO(bodyisAdmin);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Observer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction RemoveObserver(Expression<Func<string>> documentId, Expression<Func<string>> observerId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/observers/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(observerId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee[]> GetSignees(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/signees", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Signee[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee> AddSignee(Expression<Func<string>> documentId, Expression<Func<double>> bodyautographPositionheight = null, Expression<Func<int>> bodyautographPositionpageNumber = null, Expression<Func<double>> bodyautographPositionwidth = null, Expression<Func<double>> bodyautographPositionx = null, Expression<Func<double>> bodyautographPositiony = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodysignFieldName = null, Expression<Func<int>> bodysignOrder = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/signees", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var autographPositionObject = new JObject();
            var autographPositionObjectpropCount = 0;
            if (bodyautographPositionheight != null)
            {
                autographPositionObject["height"] = ExpressionConverter.ConvertO(bodyautographPositionheight);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositionpageNumber != null)
            {
                autographPositionObject["pageNumber"] = ExpressionConverter.ConvertO(bodyautographPositionpageNumber);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositionwidth != null)
            {
                autographPositionObject["width"] = ExpressionConverter.ConvertO(bodyautographPositionwidth);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositionx != null)
            {
                autographPositionObject["x"] = ExpressionConverter.ConvertO(bodyautographPositionx);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositiony != null)
            {
                autographPositionObject["y"] = ExpressionConverter.ConvertO(bodyautographPositiony);
                autographPositionObjectpropCount++;
            }

            if (autographPositionObjectpropCount > 0)
            {
                body["autographPosition"] = autographPositionObject;
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodysignFieldName != null)
            {
                body["signFieldName"] = ExpressionConverter.ConvertO(bodysignFieldName);
                bodypropCount++;
            }

            if (bodysignOrder != null)
            {
                body["signOrder"] = ExpressionConverter.ConvertO(bodysignOrder);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Signee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee> GetSignee(Expression<Func<string>> documentId, Expression<Func<string>> signeeId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/signees/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Signee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction RemoveSignee(Expression<Func<string>> documentId, Expression<Func<string>> signeeId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/signees/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee> UpdateSignee(Expression<Func<string>> documentId, Expression<Func<string>> signeeId, Expression<Func<double>> bodyautographPositionheight = null, Expression<Func<int>> bodyautographPositionpageNumber = null, Expression<Func<double>> bodyautographPositionwidth = null, Expression<Func<double>> bodyautographPositionx = null, Expression<Func<double>> bodyautographPositiony = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodylanguage = null, Expression<Func<int>> bodysignOrder = null)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/signees/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var autographPositionObject = new JObject();
            var autographPositionObjectpropCount = 0;
            if (bodyautographPositionheight != null)
            {
                autographPositionObject["height"] = ExpressionConverter.ConvertO(bodyautographPositionheight);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositionpageNumber != null)
            {
                autographPositionObject["pageNumber"] = ExpressionConverter.ConvertO(bodyautographPositionpageNumber);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositionwidth != null)
            {
                autographPositionObject["width"] = ExpressionConverter.ConvertO(bodyautographPositionwidth);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositionx != null)
            {
                autographPositionObject["x"] = ExpressionConverter.ConvertO(bodyautographPositionx);
                autographPositionObjectpropCount++;
            }

            if (bodyautographPositiony != null)
            {
                autographPositionObject["y"] = ExpressionConverter.ConvertO(bodyautographPositiony);
                autographPositionObjectpropCount++;
            }

            if (autographPositionObjectpropCount > 0)
            {
                body["autographPosition"] = autographPositionObject;
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodysignOrder != null)
            {
                body["signOrder"] = ExpressionConverter.ConvertO(bodysignOrder);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Signee>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction ResendInvitation(Expression<Func<string>> documentId, Expression<Func<string>> signeeId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/signees/{1}/resend-invitation", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction StartSignatureProcess(Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/api/v1/documents/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class DeepboxsignTriggers([ConnectionName] string connectionId)
    {
    }

    public class Document
    {
        [JsonProperty("attachmentsAllowed")]
        public bool AttachmentsAllowed { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("completionTime")]
        public string CompletionTime { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("documentMimeType")]
        public string DocumentMimeType { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("documentStatus")]
        public DocumentDocumentStatusType DocumentStatus { get; set; }

        [JsonProperty("documentUrl")]
        public string DocumentUrl { get; set; }

        [JsonProperty("initiatorCompanyDisplayName")]
        public string InitiatorCompanyDisplayName { get; set; }

        [JsonProperty("initiatorCompanyIsVerified")]
        public bool InitiatorCompanyIsVerified { get; set; }

        [JsonProperty("initiatorCompanyVerificationType")]
        public DocumentInitiatorCompanyVerificationTypeType InitiatorCompanyVerificationType { get; set; }

        [JsonProperty("initiatorDisplayEmail")]
        public string InitiatorDisplayEmail { get; set; }

        [JsonProperty("initiatorDisplayName")]
        public string InitiatorDisplayName { get; set; }

        [JsonProperty("initiatorSignKey")]
        public string InitiatorSignKey { get; set; }

        [JsonProperty("jurisdiction")]
        public DocumentJurisdictionType Jurisdiction { get; set; }

        [JsonProperty("observers")]
        public Observer[] Observers { get; set; }

        [JsonProperty("requiredAuthorityService")]
        public DocumentRequiredAuthorityServiceType RequiredAuthorityService { get; set; }

        [JsonProperty("signatureMode")]
        public DocumentSignatureModeType SignatureMode { get; set; }

        [JsonProperty("signees")]
        public Signee[] Signees { get; set; }

        [JsonProperty("signeesOrdered")]
        public Signee[][] SigneesOrdered { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    }

    public enum DocumentDocumentStatusType
    {
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "in-progress")]
        InProgress,
        [EnumMember(Value = "signed")]
        Signed,
        [EnumMember(Value = "withdrawn")]
        Withdrawn,
        [EnumMember(Value = "rejected")]
        Rejected
    }

    public enum DocumentInitiatorCompanyVerificationTypeType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "weak")]
        Weak,
        [EnumMember(Value = "strong")]
        Strong
    }

    public enum DocumentJurisdictionType
    {
        [EnumMember(Value = "zertes")]
        Zertes,
        [EnumMember(Value = "eidas")]
        Eidas
    }

    public class Observer
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("initiatorComment")]
        public string InitiatorComment { get; set; }

        [JsonProperty("isAdmin")]
        public bool IsAdmin { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("observerId")]
        public string ObserverId { get; set; }

        [JsonProperty("signUrl")]
        public string SignUrl { get; set; }

        [JsonProperty("viewedTime")]
        public string ViewedTime { get; set; }
    }

    public enum DocumentRequiredAuthorityServiceType
    {
        [EnumMember(Value = "ras")]
        Ras,
        [EnumMember(Value = "did")]
        Did
    }

    public enum DocumentSignatureModeType
    {
        [EnumMember(Value = "timestamp")]
        Timestamp,
        [EnumMember(Value = "advanced")]
        Advanced,
        [EnumMember(Value = "qualified")]
        Qualified
    }

    public class Signee
    {
        [JsonProperty("autographPosition")]
        public AutographPosition AutographPosition { get; set; }

        [JsonProperty("completionTime")]
        public string CompletionTime { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("initiatorComment")]
        public string InitiatorComment { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("policy")]
        public SigneePolicy Policy { get; set; }

        [JsonProperty("signOrder")]
        public int SignOrder { get; set; }

        [JsonProperty("signStatus")]
        public SigneeSignStatusType SignStatus { get; set; }

        [JsonProperty("signUrl")]
        public string SignUrl { get; set; }

        [JsonProperty("signatureType")]
        public SigneeSignatureTypeType SignatureType { get; set; }

        [JsonProperty("signedTime")]
        public string SignedTime { get; set; }

        [JsonProperty("signeeComment")]
        public string SigneeComment { get; set; }

        [JsonProperty("signeeId")]
        public string SigneeId { get; set; }

        [JsonProperty("viewedTime")]
        public string ViewedTime { get; set; }
    }

    public class AutographPosition
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class SigneePolicy
    {
        [JsonProperty("canModifyAutographPosition")]
        public bool CanModifyAutographPosition { get; set; }
    }

    public enum SigneeSignStatusType
    {
        [EnumMember(Value = "on-hold")]
        OnHold,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in-progress")]
        InProgress,
        [EnumMember(Value = "signed")]
        Signed,
        [EnumMember(Value = "rejected")]
        Rejected
    }

    public enum SigneeSignatureTypeType
    {
        [EnumMember(Value = "signature")]
        Signature,
        [EnumMember(Value = "seal")]
        Seal
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Deepboxsign;

    public partial class WorkflowManagedActions
    {
        public DeepboxsignActions Deepboxsign(string connectionId) => new DeepboxsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeepboxsignTriggers Deepboxsign(string connectionId) => new DeepboxsignTriggers(connectionId);
    }
}