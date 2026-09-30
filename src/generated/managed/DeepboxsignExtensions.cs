//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deepboxsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeepboxsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Document> GetDocumentDetails([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Document>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Observer> AddObserver([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/observers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyisAdmin != null)
                {
                    body["isAdmin"] = SourceExpressionConverter.ConvertToken(bodyisAdmin);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Observer>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction RemoveObserver([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> observerId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(observerId, nameof(observerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/observers/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(observerId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee[]> GetSignees([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Signee[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee> AddSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<double> bodyautographPositionheight = null, [WorkflowExpression] Func<int> bodyautographPositionpageNumber = null, [WorkflowExpression] Func<double> bodyautographPositionwidth = null, [WorkflowExpression] Func<double> bodyautographPositionx = null, [WorkflowExpression] Func<double> bodyautographPositiony = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodysignFieldName = null, [WorkflowExpression] Func<int> bodysignOrder = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyautographPositionheight, nameof(bodyautographPositionheight), required: false);
            SourceExpression.Validate(bodyautographPositionpageNumber, nameof(bodyautographPositionpageNumber), required: false);
            SourceExpression.Validate(bodyautographPositionwidth, nameof(bodyautographPositionwidth), required: false);
            SourceExpression.Validate(bodyautographPositionx, nameof(bodyautographPositionx), required: false);
            SourceExpression.Validate(bodyautographPositiony, nameof(bodyautographPositiony), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodysignFieldName, nameof(bodysignFieldName), required: false);
            SourceExpression.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var autographPositionObject = new JObject();
                var autographPositionObjectpropCount = 0;
                if (bodyautographPositionheight != null)
                {
                    autographPositionObject["height"] = SourceExpressionConverter.ConvertToken(bodyautographPositionheight);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositionpageNumber != null)
                {
                    autographPositionObject["pageNumber"] = SourceExpressionConverter.ConvertToken(bodyautographPositionpageNumber);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositionwidth != null)
                {
                    autographPositionObject["width"] = SourceExpressionConverter.ConvertToken(bodyautographPositionwidth);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositionx != null)
                {
                    autographPositionObject["x"] = SourceExpressionConverter.ConvertToken(bodyautographPositionx);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositiony != null)
                {
                    autographPositionObject["y"] = SourceExpressionConverter.ConvertToken(bodyautographPositiony);
                    autographPositionObjectpropCount++;
                }

                if (autographPositionObjectpropCount > 0)
                {
                    body["autographPosition"] = autographPositionObject;
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodysignFieldName != null)
                {
                    body["signFieldName"] = SourceExpressionConverter.ConvertToken(bodysignFieldName);
                    bodypropCount++;
                }

                if (bodysignOrder != null)
                {
                    body["signOrder"] = SourceExpressionConverter.ConvertToken(bodysignOrder);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Signee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee> GetSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(signeeId, nameof(signeeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Signee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction RemoveSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(signeeId, nameof(signeeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IBodyWorkflowAction<Signee> UpdateSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId, [WorkflowExpression] Func<double> bodyautographPositionheight = null, [WorkflowExpression] Func<int> bodyautographPositionpageNumber = null, [WorkflowExpression] Func<double> bodyautographPositionwidth = null, [WorkflowExpression] Func<double> bodyautographPositionx = null, [WorkflowExpression] Func<double> bodyautographPositiony = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<int> bodysignOrder = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(signeeId, nameof(signeeId), required: true);
            SourceExpression.Validate(bodyautographPositionheight, nameof(bodyautographPositionheight), required: false);
            SourceExpression.Validate(bodyautographPositionpageNumber, nameof(bodyautographPositionpageNumber), required: false);
            SourceExpression.Validate(bodyautographPositionwidth, nameof(bodyautographPositionwidth), required: false);
            SourceExpression.Validate(bodyautographPositionx, nameof(bodyautographPositionx), required: false);
            SourceExpression.Validate(bodyautographPositiony, nameof(bodyautographPositiony), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var autographPositionObject = new JObject();
                var autographPositionObjectpropCount = 0;
                if (bodyautographPositionheight != null)
                {
                    autographPositionObject["height"] = SourceExpressionConverter.ConvertToken(bodyautographPositionheight);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositionpageNumber != null)
                {
                    autographPositionObject["pageNumber"] = SourceExpressionConverter.ConvertToken(bodyautographPositionpageNumber);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositionwidth != null)
                {
                    autographPositionObject["width"] = SourceExpressionConverter.ConvertToken(bodyautographPositionwidth);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositionx != null)
                {
                    autographPositionObject["x"] = SourceExpressionConverter.ConvertToken(bodyautographPositionx);
                    autographPositionObjectpropCount++;
                }

                if (bodyautographPositiony != null)
                {
                    autographPositionObject["y"] = SourceExpressionConverter.ConvertToken(bodyautographPositiony);
                    autographPositionObjectpropCount++;
                }

                if (autographPositionObjectpropCount > 0)
                {
                    body["autographPosition"] = autographPositionObject;
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodysignOrder != null)
                {
                    body["signOrder"] = SourceExpressionConverter.ConvertToken(bodysignOrder);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Signee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction ResendInvitation([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(signeeId, nameof(signeeId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}/resend-invitation", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        public IWorkflowAction StartSignatureProcess([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deepboxsign;

    public partial class WorkflowManagedActions
    {
        public DeepboxsignActions Deepboxsign(string connectionId) => new DeepboxsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeepboxsignTriggers Deepboxsign(string connectionId) => new DeepboxsignTriggers(connectionId);
    }
}