//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deepboxsign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeepboxsignActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IBodyWorkflowAction<Document> UploadDocument([WorkflowExpression] Func<object> data, [WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Document> __BuildUploadDocument(WorkflowExpression<object> data, WorkflowExpression<object> file)
        {
            WorkflowExpression.Validate(data, nameof(data), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = "/api/v1/documents/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentDetails))]
        public IBodyWorkflowAction<Document> GetDocumentDetails([WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Document> __BuildGetDocumentDetails(WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildAddObserver))]
        public IBodyWorkflowAction<Observer> AddObserver([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyisAdmin = null, [WorkflowExpression] Func<string> bodylanguage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Observer> __BuildAddObserver(WorkflowExpression<string> documentId, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<bool> bodyisAdmin = null, WorkflowExpression<string> bodylanguage = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyisAdmin, nameof(bodyisAdmin), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            return new DeferredBodyAction<Observer>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/observers", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveObserver))]
        public IWorkflowAction RemoveObserver([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> observerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveObserver(WorkflowExpression<string> documentId, WorkflowExpression<string> observerId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(observerId, nameof(observerId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/observers/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(observerId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildGetSignees))]
        public IBodyWorkflowAction<Signee[]> GetSignees([WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Signee[]> __BuildGetSignees(WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<Signee[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Signee[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildAddSignee))]
        public IBodyWorkflowAction<Signee> AddSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<double> bodyautographPositionheight = null, [WorkflowExpression] Func<int> bodyautographPositionpageNumber = null, [WorkflowExpression] Func<double> bodyautographPositionwidth = null, [WorkflowExpression] Func<double> bodyautographPositionx = null, [WorkflowExpression] Func<double> bodyautographPositiony = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodysignFieldName = null, [WorkflowExpression] Func<int> bodysignOrder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Signee> __BuildAddSignee(WorkflowExpression<string> documentId, WorkflowExpression<double> bodyautographPositionheight = null, WorkflowExpression<int> bodyautographPositionpageNumber = null, WorkflowExpression<double> bodyautographPositionwidth = null, WorkflowExpression<double> bodyautographPositionx = null, WorkflowExpression<double> bodyautographPositiony = null, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodylanguage = null, WorkflowExpression<string> bodysignFieldName = null, WorkflowExpression<int> bodysignOrder = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(bodyautographPositionheight, nameof(bodyautographPositionheight), required: false);
            WorkflowExpression.Validate(bodyautographPositionpageNumber, nameof(bodyautographPositionpageNumber), required: false);
            WorkflowExpression.Validate(bodyautographPositionwidth, nameof(bodyautographPositionwidth), required: false);
            WorkflowExpression.Validate(bodyautographPositionx, nameof(bodyautographPositionx), required: false);
            WorkflowExpression.Validate(bodyautographPositiony, nameof(bodyautographPositiony), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodysignFieldName, nameof(bodysignFieldName), required: false);
            WorkflowExpression.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            return new DeferredBodyAction<Signee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildGetSignee))]
        public IBodyWorkflowAction<Signee> GetSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Signee> __BuildGetSignee(WorkflowExpression<string> documentId, WorkflowExpression<string> signeeId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(signeeId, nameof(signeeId), required: true);
            return new DeferredBodyAction<Signee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Signee>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveSignee))]
        public IWorkflowAction RemoveSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveSignee(WorkflowExpression<string> documentId, WorkflowExpression<string> signeeId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(signeeId, nameof(signeeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSignee))]
        public IBodyWorkflowAction<Signee> UpdateSignee([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId, [WorkflowExpression] Func<double> bodyautographPositionheight = null, [WorkflowExpression] Func<int> bodyautographPositionpageNumber = null, [WorkflowExpression] Func<double> bodyautographPositionwidth = null, [WorkflowExpression] Func<double> bodyautographPositionx = null, [WorkflowExpression] Func<double> bodyautographPositiony = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<int> bodysignOrder = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Signee> __BuildUpdateSignee(WorkflowExpression<string> documentId, WorkflowExpression<string> signeeId, WorkflowExpression<double> bodyautographPositionheight = null, WorkflowExpression<int> bodyautographPositionpageNumber = null, WorkflowExpression<double> bodyautographPositionwidth = null, WorkflowExpression<double> bodyautographPositionx = null, WorkflowExpression<double> bodyautographPositiony = null, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodylanguage = null, WorkflowExpression<int> bodysignOrder = null)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(signeeId, nameof(signeeId), required: true);
            WorkflowExpression.Validate(bodyautographPositionheight, nameof(bodyautographPositionheight), required: false);
            WorkflowExpression.Validate(bodyautographPositionpageNumber, nameof(bodyautographPositionpageNumber), required: false);
            WorkflowExpression.Validate(bodyautographPositionwidth, nameof(bodyautographPositionwidth), required: false);
            WorkflowExpression.Validate(bodyautographPositionx, nameof(bodyautographPositionx), required: false);
            WorkflowExpression.Validate(bodyautographPositiony, nameof(bodyautographPositiony), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowExpression.Validate(bodysignOrder, nameof(bodysignOrder), required: false);
            return new DeferredBodyAction<Signee>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildResendInvitation))]
        public IWorkflowAction ResendInvitation([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> signeeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildResendInvitation(WorkflowExpression<string> documentId, WorkflowExpression<string> signeeId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            WorkflowExpression.Validate(signeeId, nameof(signeeId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/signees/{1}/resend-invitation", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(signeeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [WorkflowExpressionFactory(nameof(__BuildStartSignatureProcess))]
        public IWorkflowAction StartSignatureProcess([WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deepboxsign")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildStartSignatureProcess(WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentInitiatorCompanyVerificationTypeType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "weak")]
        Weak,
        [EnumMember(Value = "strong")]
        Strong
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentRequiredAuthorityServiceType
    {
        [EnumMember(Value = "ras")]
        Ras,
        [EnumMember(Value = "did")]
        Did
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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