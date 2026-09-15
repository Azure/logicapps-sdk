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
        public IBodyWorkflowAction<CreateInstantPackageResponse> CreateInstantPackage(Expression<Func<string>> bodydocument = null, Expression<Func<bodydocumentLanguageInput>> bodydocumentLanguage = null, Expression<Func<string>> bodydocumentName = null, Expression<Func<string>> bodyexternalPackageData = null, Expression<Func<string>> bodyinitiator = null, Expression<Func<Stakeholder[]>> bodystakeholders = null, Expression<Func<string>> bodycallBackUrl = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodydocumentGroupCode = null, Expression<Func<string>> bodythemeCode = null, Expression<Func<bool>> bodydownloadUnsignedFiles = null, Expression<Func<bool>> bodyreassignEnabled = null, Expression<Func<int>> bodyactionUrlExpirationPeriodInDays = null, Expression<Func<string>> bodyexpiryTimestamp = null, Expression<Func<string>> bodyexternalDocumentReference = null, Expression<Func<string>> bodyexternalPackageReference = null, Expression<Func<string>> bodyf2FRedirectUrl = null, Expression<Func<string>> bodynotificationCallBackUrl = null, Expression<Func<string>> bodypdfErrorHandling = null, Expression<Func<string>> bodyrepresentation = null, Expression<Func<string>> bodyrepresentationType = null, Expression<Func<string>> bodysigningTemplateCode = null, Expression<Func<string>> bodytargetType = null)
        {
            var apiCallPath = "/packages/instant";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocument != null)
            {
                if (bodydocument != null)
                {
                    body["Document"] = CSharpExpressionConverter.ConvertToken(bodydocument);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["Document"] = "";
                bodypropCount++;
            }

            if (bodydocumentLanguage != null)
            {
                body["DocumentLanguage"] = CSharpExpressionConverter.Convert(bodydocumentLanguage);
                bodypropCount++;
            }

            if (bodydocumentName != null)
            {
                body["DocumentName"] = CSharpExpressionConverter.ConvertToken(bodydocumentName);
                bodypropCount++;
            }

            if (bodyexternalPackageData != null)
            {
                body["ExternalPackageData"] = CSharpExpressionConverter.ConvertToken(bodyexternalPackageData);
                bodypropCount++;
            }

            if (bodyinitiator != null)
            {
                body["Initiator"] = CSharpExpressionConverter.ConvertToken(bodyinitiator);
                bodypropCount++;
            }

            if (bodystakeholders != null)
            {
                body["Stakeholders"] = CSharpExpressionConverter.ConvertToken(bodystakeholders);
                bodypropCount++;
            }

            if (bodycallBackUrl != null)
            {
                body["CallBackUrl"] = CSharpExpressionConverter.ConvertToken(bodycallBackUrl);
                bodypropCount++;
            }

            if (bodycorrelationId != null)
            {
                body["CorrelationId"] = CSharpExpressionConverter.ConvertToken(bodycorrelationId);
                bodypropCount++;
            }

            if (bodydocumentGroupCode != null)
            {
                if (bodydocumentGroupCode != null)
                {
                    body["DocumentGroupCode"] = CSharpExpressionConverter.ConvertToken(bodydocumentGroupCode);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["DocumentGroupCode"] = "\"00001\"";
                bodypropCount++;
            }

            if (bodythemeCode != null)
            {
                body["ThemeCode"] = CSharpExpressionConverter.ConvertToken(bodythemeCode);
                bodypropCount++;
            }

            if (bodydownloadUnsignedFiles != null)
            {
                body["DownloadUnsignedFiles"] = CSharpExpressionConverter.ConvertToken(bodydownloadUnsignedFiles);
                bodypropCount++;
            }

            if (bodyreassignEnabled != null)
            {
                body["ReassignEnabled"] = CSharpExpressionConverter.ConvertToken(bodyreassignEnabled);
                bodypropCount++;
            }

            if (bodyactionUrlExpirationPeriodInDays != null)
            {
                body["ActionUrlExpirationPeriodInDays"] = CSharpExpressionConverter.ConvertToken(bodyactionUrlExpirationPeriodInDays);
                bodypropCount++;
            }

            if (bodyexpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = CSharpExpressionConverter.ConvertToken(bodyexpiryTimestamp);
                bodypropCount++;
            }

            if (bodyexternalDocumentReference != null)
            {
                body["ExternalDocumentReference"] = CSharpExpressionConverter.ConvertToken(bodyexternalDocumentReference);
                bodypropCount++;
            }

            if (bodyexternalPackageReference != null)
            {
                body["ExternalPackageReference"] = CSharpExpressionConverter.ConvertToken(bodyexternalPackageReference);
                bodypropCount++;
            }

            if (bodyf2FRedirectUrl != null)
            {
                body["F2FRedirectUrl"] = CSharpExpressionConverter.ConvertToken(bodyf2FRedirectUrl);
                bodypropCount++;
            }

            if (bodynotificationCallBackUrl != null)
            {
                body["NotificationCallBackUrl"] = CSharpExpressionConverter.ConvertToken(bodynotificationCallBackUrl);
                bodypropCount++;
            }

            if (bodypdfErrorHandling != null)
            {
                body["PdfErrorHandling"] = CSharpExpressionConverter.ConvertToken(bodypdfErrorHandling);
                bodypropCount++;
            }

            if (bodyrepresentation != null)
            {
                body["Representation"] = CSharpExpressionConverter.ConvertToken(bodyrepresentation);
                bodypropCount++;
            }

            if (bodyrepresentationType != null)
            {
                body["RepresentationType"] = CSharpExpressionConverter.ConvertToken(bodyrepresentationType);
                bodypropCount++;
            }

            if (bodysigningTemplateCode != null)
            {
                body["SigningTemplateCode"] = CSharpExpressionConverter.ConvertToken(bodysigningTemplateCode);
                bodypropCount++;
            }

            if (bodytargetType != null)
            {
                body["TargetType"] = CSharpExpressionConverter.ConvertToken(bodytargetType);
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
                callPayload.Queries["ContinuationToken"] = CSharpExpressionConverter.ConvertO(continuationToken);
            if (maxQuantity != null)
                callPayload.Queries["MaxQuantity"] = CSharpExpressionConverter.ConvertO(maxQuantity);
            if (sortField != null)
                callPayload.Queries["SortField"] = CSharpExpressionConverter.ConvertO(sortField);
            callPayload.Queries["SortOrder"] = Convert.ToString("\"ASC\"");
            if (sortOrder != null)
                callPayload.Queries["SortOrder"] = CSharpExpressionConverter.ConvertO(sortOrder);
            callPayload.Queries["CreatedBeforeDate"] = Convert.ToString("{{$timestamp}}");
            if (createdBeforeDate != null)
                callPayload.Queries["CreatedBeforeDate"] = CSharpExpressionConverter.ConvertO(createdBeforeDate);
            if (status != null)
                callPayload.Queries["Status"] = CSharpExpressionConverter.ConvertO(status);
            callPayload.Queries["createdAfterDate"] = Convert.ToString("{{eSigner - FutureDate}}");
            if (createdAfterDate != null)
                callPayload.Queries["createdAfterDate"] = CSharpExpressionConverter.ConvertO(createdAfterDate);
            return new ApiConnectionAction<PackageListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreatePackageResponse> CreatePackage(Expression<Func<string>> contentType, Expression<Func<string>> bodyinitiator = null, Expression<Func<string>> bodypackageName = null, Expression<Func<string>> bodycallBackUrl = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodydocumentGroupCode = null, Expression<Func<string>> bodythemeCode = null, Expression<Func<bool>> bodydownloadUnsignedFiles = null, Expression<Func<bool>> bodyreassignEnabled = null, Expression<Func<int>> bodyactionUrlExpirationPeriodInDays = null, Expression<Func<string>> bodyexpiryTimestamp = null, Expression<Func<string>> bodyexternalPackageReference = null, Expression<Func<string>> bodyexternalPackageData = null, Expression<Func<string>> bodyf2FRedirectUrl = null, Expression<Func<string>> bodynotificationCallBackUrl = null)
        {
            var apiCallPath = "/packages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinitiator != null)
            {
                body["Initiator"] = CSharpExpressionConverter.ConvertToken(bodyinitiator);
                bodypropCount++;
            }

            if (bodypackageName != null)
            {
                body["PackageName"] = CSharpExpressionConverter.ConvertToken(bodypackageName);
                bodypropCount++;
            }

            if (bodycallBackUrl != null)
            {
                body["CallBackUrl"] = CSharpExpressionConverter.ConvertToken(bodycallBackUrl);
                bodypropCount++;
            }

            if (bodycorrelationId != null)
            {
                body["CorrelationId"] = CSharpExpressionConverter.ConvertToken(bodycorrelationId);
                bodypropCount++;
            }

            if (bodydocumentGroupCode != null)
            {
                body["DocumentGroupCode"] = CSharpExpressionConverter.ConvertToken(bodydocumentGroupCode);
                bodypropCount++;
            }

            if (bodythemeCode != null)
            {
                body["ThemeCode"] = CSharpExpressionConverter.ConvertToken(bodythemeCode);
                bodypropCount++;
            }

            if (bodydownloadUnsignedFiles != null)
            {
                body["DownloadUnsignedFiles"] = CSharpExpressionConverter.ConvertToken(bodydownloadUnsignedFiles);
                bodypropCount++;
            }

            if (bodyreassignEnabled != null)
            {
                body["ReassignEnabled"] = CSharpExpressionConverter.ConvertToken(bodyreassignEnabled);
                bodypropCount++;
            }

            if (bodyactionUrlExpirationPeriodInDays != null)
            {
                body["ActionUrlExpirationPeriodInDays"] = CSharpExpressionConverter.ConvertToken(bodyactionUrlExpirationPeriodInDays);
                bodypropCount++;
            }

            if (bodyexpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = CSharpExpressionConverter.ConvertToken(bodyexpiryTimestamp);
                bodypropCount++;
            }

            if (bodyexternalPackageReference != null)
            {
                body["ExternalPackageReference"] = CSharpExpressionConverter.ConvertToken(bodyexternalPackageReference);
                bodypropCount++;
            }

            if (bodyexternalPackageData != null)
            {
                body["ExternalPackageData"] = CSharpExpressionConverter.ConvertToken(bodyexternalPackageData);
                bodypropCount++;
            }

            if (bodyf2FRedirectUrl != null)
            {
                body["F2FRedirectUrl"] = CSharpExpressionConverter.ConvertToken(bodyf2FRedirectUrl);
                bodypropCount++;
            }

            if (bodynotificationCallBackUrl != null)
            {
                body["NotificationCallBackUrl"] = CSharpExpressionConverter.ConvertToken(bodynotificationCallBackUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatePackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> AddDocumentToPackage(Expression<Func<string>> packageId, Expression<Func<string>> bodydocument = null, Expression<Func<string>> bodydocumentLanguage = null, Expression<Func<string>> bodydocumentName = null, Expression<Func<SigningField[]>> bodysigningFields = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodydocumentType = null, Expression<Func<string>> bodyexternalDocumentReference = null, Expression<Func<ErrorHandlingResponse[]>> bodypdfErrorHandling = null, Expression<Func<string>> bodyrepresentation = null, Expression<Func<string>> bodyrepresentationType = null, Expression<Func<string>> bodytargetType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/documents", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocument != null)
            {
                body["Document"] = CSharpExpressionConverter.ConvertToken(bodydocument);
                bodypropCount++;
            }

            if (bodydocumentLanguage != null)
            {
                body["DocumentLanguage"] = CSharpExpressionConverter.ConvertToken(bodydocumentLanguage);
                bodypropCount++;
            }

            if (bodydocumentName != null)
            {
                body["DocumentName"] = CSharpExpressionConverter.ConvertToken(bodydocumentName);
                bodypropCount++;
            }

            if (bodysigningFields != null)
            {
                body["SigningFields"] = CSharpExpressionConverter.ConvertToken(bodysigningFields);
                bodypropCount++;
            }

            if (bodycorrelationId != null)
            {
                body["CorrelationId"] = CSharpExpressionConverter.ConvertToken(bodycorrelationId);
                bodypropCount++;
            }

            if (bodydocumentType != null)
            {
                body["DocumentType"] = CSharpExpressionConverter.ConvertToken(bodydocumentType);
                bodypropCount++;
            }

            if (bodyexternalDocumentReference != null)
            {
                body["ExternalDocumentReference"] = CSharpExpressionConverter.ConvertToken(bodyexternalDocumentReference);
                bodypropCount++;
            }

            if (bodypdfErrorHandling != null)
            {
                body["PdfErrorHandling"] = CSharpExpressionConverter.ConvertToken(bodypdfErrorHandling);
                bodypropCount++;
            }

            if (bodyrepresentation != null)
            {
                body["Representation"] = CSharpExpressionConverter.ConvertToken(bodyrepresentation);
                bodypropCount++;
            }

            if (bodyrepresentationType != null)
            {
                body["RepresentationType"] = CSharpExpressionConverter.ConvertToken(bodyrepresentationType);
                bodypropCount++;
            }

            if (bodytargetType != null)
            {
                body["TargetType"] = CSharpExpressionConverter.ConvertToken(bodytargetType);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/locations", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSigningLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> GetPackageStatus(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PackageStatusInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> SetPackageStatus(Expression<Func<string>> id, Expression<Func<string>> bodystatus = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/skipsigners", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadPackage(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/download", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadDocumentFromPackage(Expression<Func<string>> id, Expression<Func<string>> documentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/download/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ExpiryTimeStamp(Expression<Func<string>> id, Expression<Func<string>> bodyexpiryTimestamp = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/expirytimestamp", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = CSharpExpressionConverter.ConvertToken(bodyexpiryTimestamp);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/reminders", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction DeletePackage(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SetProcessInformation(Expression<Func<string>> id, Expression<Func<bodystakeholdersInputItem[]>> bodystakeholders = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/process", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystakeholders != null)
            {
                body["Stakeholders"] = CSharpExpressionConverter.ConvertToken(bodystakeholders);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProofDoc(Expression<Func<string>> packageId, Expression<Func<string>> documentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageCorrelationAuditProof(Expression<Func<string>> correlationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packagecorrelations/{0}/auditproof/download", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(correlationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> DocumentCorrelationAuditProof(Expression<Func<string>> correlationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/documentcorrelations/{0}/auditproof/download", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(correlationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ProofExternalSource(Expression<Func<string>> packageId, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyipAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/proofs", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontent != null)
            {
                body["Content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
            }

            if (bodylocationId != null)
            {
                body["LocationId"] = CSharpExpressionConverter.ConvertToken(bodylocationId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["Type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyipAddress != null)
            {
                body["IpAddress"] = CSharpExpressionConverter.ConvertToken(bodyipAddress);
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

    public enum bodydocumentLanguageInput
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

    public class bodystakeholdersInputItem
    {
        public bodystakeholdersInputItemActorsTypeItem[] Actors { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string Language { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string ExternalStakeholderReference { get; set; }
    }

    public class bodystakeholdersInputItemActorsTypeItem
    {
        public bodystakeholdersInputItemActorsTypeItemTypeType Type { get; set; }
        public string OrderIndex { get; set; }
        public string[] LocationIds { get; set; }
        public SigningTypeInfo[] SigningTypes { get; set; }
        public string Phonenumber { get; set; }
        public string RedirectURL { get; set; }
        public bool SendNotifications { get; set; }
        public bodystakeholdersInputItemActorsTypeItemUserRolesTypeItem[] UserRoles { get; set; }
        public string LegalNoticeCode { get; set; }
        public string LegalNoticetext { get; set; }
    }

    public enum bodystakeholdersInputItemActorsTypeItemTypeType
    {
        Signer,
        Receiver
    }

    public enum bodystakeholdersInputItemActorsTypeItemUserRolesTypeItem
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

namespace Microsoft.Azure.Workflows.Sdk
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