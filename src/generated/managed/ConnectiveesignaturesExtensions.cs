//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connectiveesignatures
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnectiveesignaturesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreateInstantPackageResponse> CreateInstantPackage(Expression<Func<string>> bodyDocument = null, Expression<Func<bodyDocumentLanguageInput>> bodyDocumentLanguage = null, Expression<Func<string>> bodyDocumentName = null, Expression<Func<string>> bodyExternalPackageData = null, Expression<Func<string>> bodyInitiator = null, Expression<Func<Stakeholder[]>> bodyStakeholders = null, Expression<Func<string>> bodyCallBackUrl = null, Expression<Func<string>> bodyCorrelationId = null, Expression<Func<string>> bodyDocumentGroupCode = null, Expression<Func<string>> bodyThemeCode = null, Expression<Func<bool>> bodyDownloadUnsignedFiles = null, Expression<Func<bool>> bodyReassignEnabled = null, Expression<Func<int>> bodyActionUrlExpirationPeriodInDays = null, Expression<Func<string>> bodyExpiryTimestamp = null, Expression<Func<string>> bodyExternalDocumentReference = null, Expression<Func<string>> bodyExternalPackageReference = null, Expression<Func<string>> bodyF2FRedirectUrl = null, Expression<Func<string>> bodyNotificationCallBackUrl = null, Expression<Func<string>> bodyPdfErrorHandling = null, Expression<Func<string>> bodyRepresentation = null, Expression<Func<string>> bodyRepresentationType = null, Expression<Func<string>> bodySigningTemplateCode = null, Expression<Func<string>> bodyTargetType = null)
        {
            var apiCallPath = "/packages/instant";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDocument != null)
            {
                body["Document"] = ExpressionConverter.ConvertO(bodyDocument);
                bodypropCount++;
            }

            if (bodyDocumentLanguage != null)
            {
                body["DocumentLanguage"] = ExpressionConverter.ConvertO(bodyDocumentLanguage);
                bodypropCount++;
            }

            if (bodyDocumentName != null)
            {
                body["DocumentName"] = ExpressionConverter.ConvertO(bodyDocumentName);
                bodypropCount++;
            }

            if (bodyExternalPackageData != null)
            {
                body["ExternalPackageData"] = ExpressionConverter.ConvertO(bodyExternalPackageData);
                bodypropCount++;
            }

            if (bodyInitiator != null)
            {
                body["Initiator"] = ExpressionConverter.ConvertO(bodyInitiator);
                bodypropCount++;
            }

            if (bodyStakeholders != null)
            {
                body["Stakeholders"] = ExpressionConverter.ConvertO(bodyStakeholders);
                bodypropCount++;
            }

            if (bodyCallBackUrl != null)
            {
                body["CallBackUrl"] = ExpressionConverter.ConvertO(bodyCallBackUrl);
                bodypropCount++;
            }

            if (bodyCorrelationId != null)
            {
                body["CorrelationId"] = ExpressionConverter.ConvertO(bodyCorrelationId);
                bodypropCount++;
            }

            if (bodyDocumentGroupCode != null)
            {
                body["DocumentGroupCode"] = ExpressionConverter.ConvertO(bodyDocumentGroupCode);
                bodypropCount++;
            }

            if (bodyThemeCode != null)
            {
                body["ThemeCode"] = ExpressionConverter.ConvertO(bodyThemeCode);
                bodypropCount++;
            }

            if (bodyDownloadUnsignedFiles != null)
            {
                body["DownloadUnsignedFiles"] = ExpressionConverter.ConvertO(bodyDownloadUnsignedFiles);
                bodypropCount++;
            }

            if (bodyReassignEnabled != null)
            {
                body["ReassignEnabled"] = ExpressionConverter.ConvertO(bodyReassignEnabled);
                bodypropCount++;
            }

            if (bodyActionUrlExpirationPeriodInDays != null)
            {
                body["ActionUrlExpirationPeriodInDays"] = ExpressionConverter.ConvertO(bodyActionUrlExpirationPeriodInDays);
                bodypropCount++;
            }

            if (bodyExpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(bodyExpiryTimestamp);
                bodypropCount++;
            }

            if (bodyExternalDocumentReference != null)
            {
                body["ExternalDocumentReference"] = ExpressionConverter.ConvertO(bodyExternalDocumentReference);
                bodypropCount++;
            }

            if (bodyExternalPackageReference != null)
            {
                body["ExternalPackageReference"] = ExpressionConverter.ConvertO(bodyExternalPackageReference);
                bodypropCount++;
            }

            if (bodyF2FRedirectUrl != null)
            {
                body["F2FRedirectUrl"] = ExpressionConverter.ConvertO(bodyF2FRedirectUrl);
                bodypropCount++;
            }

            if (bodyNotificationCallBackUrl != null)
            {
                body["NotificationCallBackUrl"] = ExpressionConverter.ConvertO(bodyNotificationCallBackUrl);
                bodypropCount++;
            }

            if (bodyPdfErrorHandling != null)
            {
                body["PdfErrorHandling"] = ExpressionConverter.ConvertO(bodyPdfErrorHandling);
                bodypropCount++;
            }

            if (bodyRepresentation != null)
            {
                body["Representation"] = ExpressionConverter.ConvertO(bodyRepresentation);
                bodypropCount++;
            }

            if (bodyRepresentationType != null)
            {
                body["RepresentationType"] = ExpressionConverter.ConvertO(bodyRepresentationType);
                bodypropCount++;
            }

            if (bodySigningTemplateCode != null)
            {
                body["SigningTemplateCode"] = ExpressionConverter.ConvertO(bodySigningTemplateCode);
                bodypropCount++;
            }

            if (bodyTargetType != null)
            {
                body["TargetType"] = ExpressionConverter.ConvertO(bodyTargetType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateInstantPackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageListResponse> PackageList(Expression<Func<string>> continuationToken = null, Expression<Func<int>> maxQuantity = null, Expression<Func<string>> sortField = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> createdBeforeDate = null, Expression<Func<string>> status = null, Expression<Func<string>> createdAfterDate = null)
        {
            var apiCallPath = "/packages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (continuationToken != null)
                callPayload.Queries["ContinuationToken"] = ExpressionConverter.Convert(continuationToken);
            if (maxQuantity != null)
                callPayload.Queries["MaxQuantity"] = ExpressionConverter.Convert(maxQuantity);
            if (sortField != null)
                callPayload.Queries["SortField"] = ExpressionConverter.Convert(sortField);
            callPayload.Queries["SortOrder"] = Convert.ToString("\"ASC\"");
            if (sortOrder != null)
                callPayload.Queries["SortOrder"] = ExpressionConverter.Convert(sortOrder);
            callPayload.Queries["CreatedBeforeDate"] = Convert.ToString("{{$timestamp}}");
            if (createdBeforeDate != null)
                callPayload.Queries["CreatedBeforeDate"] = ExpressionConverter.Convert(createdBeforeDate);
            if (status != null)
                callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
            callPayload.Queries["createdAfterDate"] = Convert.ToString("{{eSigner - FutureDate}}");
            if (createdAfterDate != null)
                callPayload.Queries["createdAfterDate"] = ExpressionConverter.Convert(createdAfterDate);
            return new ApiConnectionAction<PackageListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreatePackageResponse> CreatePackage(Expression<Func<string>> contentType, Expression<Func<string>> bodyInitiator = null, Expression<Func<string>> bodyPackageName = null, Expression<Func<string>> bodyCallBackUrl = null, Expression<Func<string>> bodyCorrelationId = null, Expression<Func<string>> bodyDocumentGroupCode = null, Expression<Func<string>> bodyThemeCode = null, Expression<Func<bool>> bodyDownloadUnsignedFiles = null, Expression<Func<bool>> bodyReassignEnabled = null, Expression<Func<int>> bodyActionUrlExpirationPeriodInDays = null, Expression<Func<string>> bodyExpiryTimestamp = null, Expression<Func<string>> bodyExternalPackageReference = null, Expression<Func<string>> bodyExternalPackageData = null, Expression<Func<string>> bodyF2FRedirectUrl = null, Expression<Func<string>> bodyNotificationCallBackUrl = null)
        {
            var apiCallPath = "/packages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyInitiator != null)
            {
                body["Initiator"] = ExpressionConverter.ConvertO(bodyInitiator);
                bodypropCount++;
            }

            if (bodyPackageName != null)
            {
                body["PackageName"] = ExpressionConverter.ConvertO(bodyPackageName);
                bodypropCount++;
            }

            if (bodyCallBackUrl != null)
            {
                body["CallBackUrl"] = ExpressionConverter.ConvertO(bodyCallBackUrl);
                bodypropCount++;
            }

            if (bodyCorrelationId != null)
            {
                body["CorrelationId"] = ExpressionConverter.ConvertO(bodyCorrelationId);
                bodypropCount++;
            }

            if (bodyDocumentGroupCode != null)
            {
                body["DocumentGroupCode"] = ExpressionConverter.ConvertO(bodyDocumentGroupCode);
                bodypropCount++;
            }

            if (bodyThemeCode != null)
            {
                body["ThemeCode"] = ExpressionConverter.ConvertO(bodyThemeCode);
                bodypropCount++;
            }

            if (bodyDownloadUnsignedFiles != null)
            {
                body["DownloadUnsignedFiles"] = ExpressionConverter.ConvertO(bodyDownloadUnsignedFiles);
                bodypropCount++;
            }

            if (bodyReassignEnabled != null)
            {
                body["ReassignEnabled"] = ExpressionConverter.ConvertO(bodyReassignEnabled);
                bodypropCount++;
            }

            if (bodyActionUrlExpirationPeriodInDays != null)
            {
                body["ActionUrlExpirationPeriodInDays"] = ExpressionConverter.ConvertO(bodyActionUrlExpirationPeriodInDays);
                bodypropCount++;
            }

            if (bodyExpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(bodyExpiryTimestamp);
                bodypropCount++;
            }

            if (bodyExternalPackageReference != null)
            {
                body["ExternalPackageReference"] = ExpressionConverter.ConvertO(bodyExternalPackageReference);
                bodypropCount++;
            }

            if (bodyExternalPackageData != null)
            {
                body["ExternalPackageData"] = ExpressionConverter.ConvertO(bodyExternalPackageData);
                bodypropCount++;
            }

            if (bodyF2FRedirectUrl != null)
            {
                body["F2FRedirectUrl"] = ExpressionConverter.ConvertO(bodyF2FRedirectUrl);
                bodypropCount++;
            }

            if (bodyNotificationCallBackUrl != null)
            {
                body["NotificationCallBackUrl"] = ExpressionConverter.ConvertO(bodyNotificationCallBackUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatePackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> AddDocumentToPackage(Expression<Func<string>> packageId, Expression<Func<string>> bodyDocument = null, Expression<Func<string>> bodyDocumentLanguage = null, Expression<Func<string>> bodyDocumentName = null, Expression<Func<SigningField[]>> bodySigningFields = null, Expression<Func<string>> bodyCorrelationId = null, Expression<Func<string>> bodyDocumentType = null, Expression<Func<string>> bodyExternalDocumentReference = null, Expression<Func<ErrorHandlingResponse[]>> bodyPdfErrorHandling = null, Expression<Func<string>> bodyRepresentation = null, Expression<Func<string>> bodyRepresentationType = null, Expression<Func<string>> bodyTargetType = null)
        {
            var apiCallPath = String.Format("/packages/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDocument != null)
            {
                body["Document"] = ExpressionConverter.ConvertO(bodyDocument);
                bodypropCount++;
            }

            if (bodyDocumentLanguage != null)
            {
                body["DocumentLanguage"] = ExpressionConverter.ConvertO(bodyDocumentLanguage);
                bodypropCount++;
            }

            if (bodyDocumentName != null)
            {
                body["DocumentName"] = ExpressionConverter.ConvertO(bodyDocumentName);
                bodypropCount++;
            }

            if (bodySigningFields != null)
            {
                body["SigningFields"] = ExpressionConverter.ConvertO(bodySigningFields);
                bodypropCount++;
            }

            if (bodyCorrelationId != null)
            {
                body["CorrelationId"] = ExpressionConverter.ConvertO(bodyCorrelationId);
                bodypropCount++;
            }

            if (bodyDocumentType != null)
            {
                body["DocumentType"] = ExpressionConverter.ConvertO(bodyDocumentType);
                bodypropCount++;
            }

            if (bodyExternalDocumentReference != null)
            {
                body["ExternalDocumentReference"] = ExpressionConverter.ConvertO(bodyExternalDocumentReference);
                bodypropCount++;
            }

            if (bodyPdfErrorHandling != null)
            {
                body["PdfErrorHandling"] = ExpressionConverter.ConvertO(bodyPdfErrorHandling);
                bodypropCount++;
            }

            if (bodyRepresentation != null)
            {
                body["Representation"] = ExpressionConverter.ConvertO(bodyRepresentation);
                bodypropCount++;
            }

            if (bodyRepresentationType != null)
            {
                body["RepresentationType"] = ExpressionConverter.ConvertO(bodyRepresentationType);
                bodypropCount++;
            }

            if (bodyTargetType != null)
            {
                body["TargetType"] = ExpressionConverter.ConvertO(bodyTargetType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddDocumentToPackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<GetSigningLocationsResponse> GetSigningLocations(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/packages/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSigningLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> GetPackageStatus(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PackageStatusInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> SetPackageStatus(Expression<Func<string>> id, Expression<Func<string>> bodyStatus = null)
        {
            var apiCallPath = String.Format("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PackageStatusInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SkipSigners(Expression<Func<string>> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/skipsigners", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadPackage(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/packages/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadDocumentFromPackage(Expression<Func<string>> id, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/packages/{0}/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ExpiryTimeStamp(Expression<Func<string>> id, Expression<Func<string>> bodyExpiryTimestamp = null)
        {
            var apiCallPath = String.Format("/packages/{0}/expirytimestamp", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyExpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(bodyExpiryTimestamp);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SendPackageReminders(Expression<Func<string>> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/reminders", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction DeletePackage(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SetProcessInformation(Expression<Func<string>> id, Expression<Func<bodyStakeholdersInputItem[]>> bodyStakeholders = null)
        {
            var apiCallPath = String.Format("/packages/{0}/process", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyStakeholders != null)
            {
                body["Stakeholders"] = ExpressionConverter.ConvertO(bodyStakeholders);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProof(Expression<Func<string>> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProofDoc(Expression<Func<string>> packageId, Expression<Func<string>> documentId)
        {
            var apiCallPath = String.Format("/packages/{0}/auditproof/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageCorrelationAuditProof(Expression<Func<string>> correlationId)
        {
            var apiCallPath = String.Format("/packagecorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(correlationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> DocumentCorrelationAuditProof(Expression<Func<string>> correlationId)
        {
            var apiCallPath = String.Format("/documentcorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(correlationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ProofExternalSource(Expression<Func<string>> packageId, Expression<Func<string>> bodyContent = null, Expression<Func<string>> bodyLocationId = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyType = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyIpAddress = null)
        {
            var apiCallPath = String.Format("/packages/{0}/auditproof/proofs", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyContent != null)
            {
                body["Content"] = ExpressionConverter.ConvertO(bodyContent);
                bodypropCount++;
            }

            if (bodyLocationId != null)
            {
                body["LocationId"] = ExpressionConverter.ConvertO(bodyLocationId);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyType != null)
            {
                body["Type"] = ExpressionConverter.ConvertO(bodyType);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyIpAddress != null)
            {
                body["IpAddress"] = ExpressionConverter.ConvertO(bodyIpAddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class ConnectiveesignaturesTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateInstantPackageResponse
    {
        public string PackageId { get; set; }
        public string CreationTimestamp { get; set; }
    }

    public enum bodyDocumentLanguageInput
    {
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "es")]
        Es
    }

    public class Stakeholder
    {
        public RequestActor[] Actors { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Language { get; set; }
        public string ExternalStakeholderReference { get; set; }
    }

    public class RequestActor
    {
        public string Type { get; set; }
        public int OrderIndex { get; set; }
        public SigningField[] SigningFields { get; set; }
        public SigningTypeInfo[] SigningTypes { get; set; }
        public string Phonenumber { get; set; }
        public string RedirectUrl { get; set; }
        public bool SendNotifications { get; set; }
        public string[] UserRoles { get; set; }
        public string LegalNoticeCode { get; set; }
        public string LegalNoticeText { get; set; }
    }

    public class SigningField
    {
        public int PageNumber { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Left { get; set; }
        public string Top { get; set; }
        public string MarkerOrFieldId { get; set; }
    }

    public class SigningTypeInfo
    {
        public string SigningType { get; set; }
        public string[] CommitmentTypes { get; set; }
        public string MandatedSignerValidation { get; set; }
        public string[] MandatedSignerIds { get; set; }
        public string SignaturePolicyId { get; set; }
    }

    public class PackageListResponse
    {
        public string ContinuationToken { get; set; }
        public int MaxQuantity { get; set; }
        public int Total { get; set; }
        public Package[] Items { get; set; }
    }

    public class Package
    {
        public string Id { get; set; }
        public string PackageStatus { get; set; }
        public string ExternalPackageReference { get; set; }
    }

    public class CreatePackageResponse
    {
        public string PackageId { get; set; }
        public string CreationTimestamp { get; set; }
    }

    public class AddDocumentToPackageResponse
    {
        public string DocumentId { get; set; }
        public string CreationTimestamp { get; set; }
        public AddDocumentToPackageResponseLocationsTypeItem[] Locations { get; set; }
    }

    public class AddDocumentToPackageResponseLocationsTypeItem
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public int PageNumber { get; set; }
    }

    public class ErrorHandlingResponse
    {
        public string ErrorCode { get; set; }
        public string Message { get; set; }
    }

    public class GetSigningLocationsResponse
    {
        public GetSigningLocationsResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class GetSigningLocationsResponseDocumentsTypeItem
    {
        public string DocumentId { get; set; }
        public string ExternalDocumentReference { get; set; }
        public GetSigningLocationsResponseDocumentsTypeItemLocationsTypeItem[] Locations { get; set; }
    }

    public class GetSigningLocationsResponseDocumentsTypeItemLocationsTypeItem
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public int PageNumber { get; set; }
    }

    public class PackageStatusInfo
    {
        public string PackageName { get; set; }
        public string CreationTimestamp { get; set; }
        public string Initiator { get; set; }
        public string ExpiryTimestamp { get; set; }
        public string ExternalPackageReference { get; set; }
        public string F2FSigningUrl { get; set; }
        public string PackageStatus { get; set; }
        public PackageDocument[] PackageDocuments { get; set; }
        public PackageStatusStakeholdersTypeItem[] Stakeholders { get; set; }
    }

    public class PackageDocument
    {
        public string DocumentId { get; set; }
        public string ExternalDocumentReference { get; set; }
        public string DocumentName { get; set; }
        public string DocumentType { get; set; }
    }

    public class PackageStatusStakeholdersTypeItem
    {
        public string Type { get; set; }
        public string PersonGroupName { get; set; }
        public string ContactGroupCode { get; set; }
        public string EmailAddress { get; set; }
        public string ExternalStakeholderReference { get; set; }
        public string StakeholderId { get; set; }
        public PackageStatusStakeholdersTypeItemActorsTypeItem[] Actors { get; set; }
    }

    public class PackageStatusStakeholdersTypeItemActorsTypeItem
    {
        public string ActorId { get; set; }
        public string ActionUrl { get; set; }
        public PackageStatusStakeholdersTypeItemActorsTypeItemActionUrlsTypeItem[] ActionUrls { get; set; }
        public string ActorStatus { get; set; }
        public string Type { get; set; }
        public string CompletedBy { get; set; }
        public string CompletedTimestamp { get; set; }
        public string Reason { get; set; }
        public PackageStatusStakeholdersTypeItemActorsTypeItemLocationsTypeItem[] Locations { get; set; }
    }

    public class PackageStatusStakeholdersTypeItemActorsTypeItemActionUrlsTypeItem
    {
        public string EmailAddress { get; set; }
        public string Url { get; set; }
    }

    public class PackageStatusStakeholdersTypeItemActorsTypeItemLocationsTypeItem
    {
        public string Id { get; set; }
        public string UsedSigningType { get; set; }
    }

    public class bodyStakeholdersInputItem
    {
        public bodyStakeholdersInputItemActorsTypeItem[] Actors { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string Language { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string ExternalStakeholderReference { get; set; }
    }

    public class bodyStakeholdersInputItemActorsTypeItem
    {
        public bodyStakeholdersInputItemActorsTypeItemTypeType Type { get; set; }
        public string OrderIndex { get; set; }
        public string[] LocationIds { get; set; }
        public SigningTypeInfo[] SigningTypes { get; set; }
        public string Phonenumber { get; set; }
        public string RedirectURL { get; set; }
        public bool SendNotifications { get; set; }
        public bodyStakeholdersInputItemActorsTypeItemUserRolesTypeItem[] UserRoles { get; set; }
        public string LegalNoticeCode { get; set; }
        public string LegalNoticetext { get; set; }
    }

    public enum bodyStakeholdersInputItemActorsTypeItemTypeType
    {
        Signer,
        Receiver
    }

    public enum bodyStakeholdersInputItemActorsTypeItemUserRolesTypeItem
    {
        LEGALNOTICE1,
        LEGALNOTICE2,
        LEGALNOTICE3
    }

    public class Content
    {
        [JsonProperty("uploads")]
        public ContentUploadsTypeItem[] Uploads { get; set; }
    }

    public class ContentUploadsTypeItem
    {
        [JsonProperty("upload")]
        public ContentUploadsTypeItemUploadTypeItem[] Upload { get; set; }

        [JsonProperty("indexes")]
        public ContentUploadsTypeItemIndexesTypeItem[] Indexes { get; set; }

        [JsonProperty("packageCorrelationId")]
        public string PackageCorrelationId { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }
    }

    public class ContentUploadsTypeItemUploadTypeItem
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("signatures")]
        public ContentUploadsTypeItemUploadTypeItemSignaturesTypeItem[] Signatures { get; set; }
    }

    public class ContentUploadsTypeItemUploadTypeItemSignaturesTypeItem
    {
        [JsonProperty("proofs")]
        public ContentUploadsTypeItemUploadTypeItemSignaturesTypeItemProofsTypeItem[] Proofs { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }
    }

    public class ContentUploadsTypeItemUploadTypeItemSignaturesTypeItemProofsTypeItem
    {
        [JsonProperty("proof")]
        public ContentUploadsTypeItemUploadTypeItemSignaturesTypeItemProofsTypeItemProofType Proof { get; set; }
    }

    public class ContentUploadsTypeItemUploadTypeItemSignaturesTypeItemProofsTypeItemProofType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public bool Index { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }
    }

    public class ContentUploadsTypeItemIndexesTypeItem
    {
        [JsonProperty("index")]
        public ContentUploadsTypeItemIndexesTypeItemIndexType Index { get; set; }
    }

    public class ContentUploadsTypeItemIndexesTypeItemIndexType
    {
        [JsonProperty("identifier")]
        public bool Identifier { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Connectiveesignatures;

    public partial class WorkflowManagedActions
    {
        public ConnectiveesignaturesActions Connectiveesignatures(string connectionId) => new ConnectiveesignaturesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ConnectiveesignaturesTriggers Connectiveesignatures(string connectionId) => new ConnectiveesignaturesTriggers(connectionId);
    }
}