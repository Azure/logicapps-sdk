//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connectiveesignatures
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnectiveesignaturesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreateInstantPackageResponse> CreateInstantPackage([WorkflowExpression] Func<string> bodydocument = null, [WorkflowExpression] Func<bodydocumentLanguageInput> bodydocumentLanguage = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<string> bodyexternalPackageData = null, [WorkflowExpression] Func<string> bodyinitiator = null, [WorkflowExpression] Func<Stakeholder[]> bodystakeholders = null, [WorkflowExpression] Func<string> bodycallBackUrl = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentGroupCode = null, [WorkflowExpression] Func<string> bodythemeCode = null, [WorkflowExpression] Func<bool> bodydownloadUnsignedFiles = null, [WorkflowExpression] Func<bool> bodyreassignEnabled = null, [WorkflowExpression] Func<int> bodyactionUrlExpirationPeriodInDays = null, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null, [WorkflowExpression] Func<string> bodyexternalDocumentReference = null, [WorkflowExpression] Func<string> bodyexternalPackageReference = null, [WorkflowExpression] Func<string> bodyf2FRedirectUrl = null, [WorkflowExpression] Func<string> bodynotificationCallBackUrl = null, [WorkflowExpression] Func<string> bodypdfErrorHandling = null, [WorkflowExpression] Func<string> bodyrepresentation = null, [WorkflowExpression] Func<string> bodyrepresentationType = null, [WorkflowExpression] Func<string> bodysigningTemplateCode = null, [WorkflowExpression] Func<string> bodytargetType = null)
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
                    body["Document"] = ExpressionConverter.ConvertO(bodydocument);
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
                body["DocumentLanguage"] = ExpressionConverter.ConvertO(bodydocumentLanguage);
                bodypropCount++;
            }

            if (bodydocumentName != null)
            {
                body["DocumentName"] = ExpressionConverter.ConvertO(bodydocumentName);
                bodypropCount++;
            }

            if (bodyexternalPackageData != null)
            {
                body["ExternalPackageData"] = ExpressionConverter.ConvertO(bodyexternalPackageData);
                bodypropCount++;
            }

            if (bodyinitiator != null)
            {
                body["Initiator"] = ExpressionConverter.ConvertO(bodyinitiator);
                bodypropCount++;
            }

            if (bodystakeholders != null)
            {
                body["Stakeholders"] = ExpressionConverter.ConvertO(bodystakeholders);
                bodypropCount++;
            }

            if (bodycallBackUrl != null)
            {
                body["CallBackUrl"] = ExpressionConverter.ConvertO(bodycallBackUrl);
                bodypropCount++;
            }

            if (bodycorrelationId != null)
            {
                body["CorrelationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                bodypropCount++;
            }

            if (bodydocumentGroupCode != null)
            {
                if (bodydocumentGroupCode != null)
                {
                    body["DocumentGroupCode"] = ExpressionConverter.ConvertO(bodydocumentGroupCode);
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
                body["ThemeCode"] = ExpressionConverter.ConvertO(bodythemeCode);
                bodypropCount++;
            }

            if (bodydownloadUnsignedFiles != null)
            {
                body["DownloadUnsignedFiles"] = ExpressionConverter.ConvertO(bodydownloadUnsignedFiles);
                bodypropCount++;
            }

            if (bodyreassignEnabled != null)
            {
                body["ReassignEnabled"] = ExpressionConverter.ConvertO(bodyreassignEnabled);
                bodypropCount++;
            }

            if (bodyactionUrlExpirationPeriodInDays != null)
            {
                body["ActionUrlExpirationPeriodInDays"] = ExpressionConverter.ConvertO(bodyactionUrlExpirationPeriodInDays);
                bodypropCount++;
            }

            if (bodyexpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(bodyexpiryTimestamp);
                bodypropCount++;
            }

            if (bodyexternalDocumentReference != null)
            {
                body["ExternalDocumentReference"] = ExpressionConverter.ConvertO(bodyexternalDocumentReference);
                bodypropCount++;
            }

            if (bodyexternalPackageReference != null)
            {
                body["ExternalPackageReference"] = ExpressionConverter.ConvertO(bodyexternalPackageReference);
                bodypropCount++;
            }

            if (bodyf2FRedirectUrl != null)
            {
                body["F2FRedirectUrl"] = ExpressionConverter.ConvertO(bodyf2FRedirectUrl);
                bodypropCount++;
            }

            if (bodynotificationCallBackUrl != null)
            {
                body["NotificationCallBackUrl"] = ExpressionConverter.ConvertO(bodynotificationCallBackUrl);
                bodypropCount++;
            }

            if (bodypdfErrorHandling != null)
            {
                body["PdfErrorHandling"] = ExpressionConverter.ConvertO(bodypdfErrorHandling);
                bodypropCount++;
            }

            if (bodyrepresentation != null)
            {
                body["Representation"] = ExpressionConverter.ConvertO(bodyrepresentation);
                bodypropCount++;
            }

            if (bodyrepresentationType != null)
            {
                body["RepresentationType"] = ExpressionConverter.ConvertO(bodyrepresentationType);
                bodypropCount++;
            }

            if (bodysigningTemplateCode != null)
            {
                body["SigningTemplateCode"] = ExpressionConverter.ConvertO(bodysigningTemplateCode);
                bodypropCount++;
            }

            if (bodytargetType != null)
            {
                body["TargetType"] = ExpressionConverter.ConvertO(bodytargetType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateInstantPackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageListResponse> PackageList([WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<int> maxQuantity = null, [WorkflowExpression] Func<string> sortField = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<string> createdBeforeDate = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> createdAfterDate = null)
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
        public IBodyWorkflowAction<CreatePackageResponse> CreatePackage([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyinitiator = null, [WorkflowExpression] Func<string> bodypackageName = null, [WorkflowExpression] Func<string> bodycallBackUrl = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentGroupCode = null, [WorkflowExpression] Func<string> bodythemeCode = null, [WorkflowExpression] Func<bool> bodydownloadUnsignedFiles = null, [WorkflowExpression] Func<bool> bodyreassignEnabled = null, [WorkflowExpression] Func<int> bodyactionUrlExpirationPeriodInDays = null, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null, [WorkflowExpression] Func<string> bodyexternalPackageReference = null, [WorkflowExpression] Func<string> bodyexternalPackageData = null, [WorkflowExpression] Func<string> bodyf2FRedirectUrl = null, [WorkflowExpression] Func<string> bodynotificationCallBackUrl = null)
        {
            var apiCallPath = "/packages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinitiator != null)
            {
                body["Initiator"] = ExpressionConverter.ConvertO(bodyinitiator);
                bodypropCount++;
            }

            if (bodypackageName != null)
            {
                body["PackageName"] = ExpressionConverter.ConvertO(bodypackageName);
                bodypropCount++;
            }

            if (bodycallBackUrl != null)
            {
                body["CallBackUrl"] = ExpressionConverter.ConvertO(bodycallBackUrl);
                bodypropCount++;
            }

            if (bodycorrelationId != null)
            {
                body["CorrelationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                bodypropCount++;
            }

            if (bodydocumentGroupCode != null)
            {
                body["DocumentGroupCode"] = ExpressionConverter.ConvertO(bodydocumentGroupCode);
                bodypropCount++;
            }

            if (bodythemeCode != null)
            {
                body["ThemeCode"] = ExpressionConverter.ConvertO(bodythemeCode);
                bodypropCount++;
            }

            if (bodydownloadUnsignedFiles != null)
            {
                body["DownloadUnsignedFiles"] = ExpressionConverter.ConvertO(bodydownloadUnsignedFiles);
                bodypropCount++;
            }

            if (bodyreassignEnabled != null)
            {
                body["ReassignEnabled"] = ExpressionConverter.ConvertO(bodyreassignEnabled);
                bodypropCount++;
            }

            if (bodyactionUrlExpirationPeriodInDays != null)
            {
                body["ActionUrlExpirationPeriodInDays"] = ExpressionConverter.ConvertO(bodyactionUrlExpirationPeriodInDays);
                bodypropCount++;
            }

            if (bodyexpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(bodyexpiryTimestamp);
                bodypropCount++;
            }

            if (bodyexternalPackageReference != null)
            {
                body["ExternalPackageReference"] = ExpressionConverter.ConvertO(bodyexternalPackageReference);
                bodypropCount++;
            }

            if (bodyexternalPackageData != null)
            {
                body["ExternalPackageData"] = ExpressionConverter.ConvertO(bodyexternalPackageData);
                bodypropCount++;
            }

            if (bodyf2FRedirectUrl != null)
            {
                body["F2FRedirectUrl"] = ExpressionConverter.ConvertO(bodyf2FRedirectUrl);
                bodypropCount++;
            }

            if (bodynotificationCallBackUrl != null)
            {
                body["NotificationCallBackUrl"] = ExpressionConverter.ConvertO(bodynotificationCallBackUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreatePackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> AddDocumentToPackage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId, [WorkflowExpression] Func<string> bodydocument = null, [WorkflowExpression] Func<string> bodydocumentLanguage = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<SigningField[]> bodysigningFields = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentType = null, [WorkflowExpression] Func<string> bodyexternalDocumentReference = null, [WorkflowExpression] Func<ErrorHandlingResponse[]> bodypdfErrorHandling = null, [WorkflowExpression] Func<string> bodyrepresentation = null, [WorkflowExpression] Func<string> bodyrepresentationType = null, [WorkflowExpression] Func<string> bodytargetType = null)
        {
            var apiCallPath = String.Format("/packages/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydocument != null)
            {
                body["Document"] = ExpressionConverter.ConvertO(bodydocument);
                bodypropCount++;
            }

            if (bodydocumentLanguage != null)
            {
                body["DocumentLanguage"] = ExpressionConverter.ConvertO(bodydocumentLanguage);
                bodypropCount++;
            }

            if (bodydocumentName != null)
            {
                body["DocumentName"] = ExpressionConverter.ConvertO(bodydocumentName);
                bodypropCount++;
            }

            if (bodysigningFields != null)
            {
                body["SigningFields"] = ExpressionConverter.ConvertO(bodysigningFields);
                bodypropCount++;
            }

            if (bodycorrelationId != null)
            {
                body["CorrelationId"] = ExpressionConverter.ConvertO(bodycorrelationId);
                bodypropCount++;
            }

            if (bodydocumentType != null)
            {
                body["DocumentType"] = ExpressionConverter.ConvertO(bodydocumentType);
                bodypropCount++;
            }

            if (bodyexternalDocumentReference != null)
            {
                body["ExternalDocumentReference"] = ExpressionConverter.ConvertO(bodyexternalDocumentReference);
                bodypropCount++;
            }

            if (bodypdfErrorHandling != null)
            {
                body["PdfErrorHandling"] = ExpressionConverter.ConvertO(bodypdfErrorHandling);
                bodypropCount++;
            }

            if (bodyrepresentation != null)
            {
                body["Representation"] = ExpressionConverter.ConvertO(bodyrepresentation);
                bodypropCount++;
            }

            if (bodyrepresentationType != null)
            {
                body["RepresentationType"] = ExpressionConverter.ConvertO(bodyrepresentationType);
                bodypropCount++;
            }

            if (bodytargetType != null)
            {
                body["TargetType"] = ExpressionConverter.ConvertO(bodytargetType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddDocumentToPackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<GetSigningLocationsResponse> GetSigningLocations([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/packages/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSigningLocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> GetPackageStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PackageStatusInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> SetPackageStatus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> bodystatus = null)
        {
            var apiCallPath = String.Format("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PackageStatusInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SkipSigners([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/skipsigners", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadPackage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/packages/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadDocumentFromPackage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> documentId)
        {
            var apiCallPath = String.Format("/packages/{0}/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ExpiryTimeStamp([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null)
        {
            var apiCallPath = String.Format("/packages/{0}/expirytimestamp", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyexpiryTimestamp != null)
            {
                body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(bodyexpiryTimestamp);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SendPackageReminders([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/reminders", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction DeletePackage([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SetProcessInformation([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<bodystakeholdersInputItem[]> bodystakeholders = null)
        {
            var apiCallPath = String.Format("/packages/{0}/process", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystakeholders != null)
            {
                body["Stakeholders"] = ExpressionConverter.ConvertO(bodystakeholders);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProof([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId)
        {
            var apiCallPath = String.Format("/packages/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProofDoc([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId, [WorkflowExpression] Func<string> documentId)
        {
            var apiCallPath = String.Format("/packages/{0}/auditproof/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageCorrelationAuditProof([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> correlationId)
        {
            var apiCallPath = String.Format("/packagecorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(correlationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> DocumentCorrelationAuditProof([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> correlationId)
        {
            var apiCallPath = String.Format("/documentcorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(correlationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Content>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ProofExternalSource([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> packageId, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyipAddress = null)
        {
            var apiCallPath = String.Format("/packages/{0}/auditproof/proofs", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontent != null)
            {
                body["Content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodylocationId != null)
            {
                body["LocationId"] = ExpressionConverter.ConvertO(bodylocationId);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["Type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyipAddress != null)
            {
                body["IpAddress"] = ExpressionConverter.ConvertO(bodyipAddress);
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