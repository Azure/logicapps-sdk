//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Connectiveesignatures
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ConnectiveesignaturesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreateInstantPackageResponse> CreateInstantPackage(Expression<Func<string>> bodydocument = null, Expression<Func<bodydocumentLanguageInput>> bodydocumentLanguage = null, Expression<Func<string>> bodydocumentName = null, Expression<Func<string>> bodyexternalPackageData = null, Expression<Func<string>> bodyinitiator = null, Expression<Func<Stakeholder[]>> bodystakeholders = null, Expression<Func<string>> bodycallBackUrl = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodydocumentGroupCode = null, Expression<Func<string>> bodythemeCode = null, Expression<Func<bool>> bodydownloadUnsignedFiles = null, Expression<Func<bool>> bodyreassignEnabled = null, Expression<Func<int>> bodyactionUrlExpirationPeriodInDays = null, Expression<Func<string>> bodyexpiryTimestamp = null, Expression<Func<string>> bodyexternalDocumentReference = null, Expression<Func<string>> bodyexternalPackageReference = null, Expression<Func<string>> bodyf2FRedirectUrl = null, Expression<Func<string>> bodynotificationCallBackUrl = null, Expression<Func<string>> bodypdfErrorHandling = null, Expression<Func<string>> bodyrepresentation = null, Expression<Func<string>> bodyrepresentationType = null, Expression<Func<string>> bodysigningTemplateCode = null, Expression<Func<string>> bodytargetType = null)
        {
            var __workflow_bodydocument = WorkflowExpression.Compile(bodydocument, nameof(bodydocument), required: false);
            var __workflow_bodydocumentLanguage = WorkflowExpression.Compile(bodydocumentLanguage, nameof(bodydocumentLanguage), required: false);
            var __workflow_bodydocumentName = WorkflowExpression.Compile(bodydocumentName, nameof(bodydocumentName), required: false);
            var __workflow_bodyexternalPackageData = WorkflowExpression.Compile(bodyexternalPackageData, nameof(bodyexternalPackageData), required: false);
            var __workflow_bodyinitiator = WorkflowExpression.Compile(bodyinitiator, nameof(bodyinitiator), required: false);
            var __workflow_bodystakeholders = WorkflowExpression.Compile(bodystakeholders, nameof(bodystakeholders), required: false);
            var __workflow_bodycallBackUrl = WorkflowExpression.Compile(bodycallBackUrl, nameof(bodycallBackUrl), required: false);
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: false);
            var __workflow_bodydocumentGroupCode = WorkflowExpression.Compile(bodydocumentGroupCode, nameof(bodydocumentGroupCode), required: false);
            var __workflow_bodythemeCode = WorkflowExpression.Compile(bodythemeCode, nameof(bodythemeCode), required: false);
            var __workflow_bodydownloadUnsignedFiles = WorkflowExpression.Compile(bodydownloadUnsignedFiles, nameof(bodydownloadUnsignedFiles), required: false);
            var __workflow_bodyreassignEnabled = WorkflowExpression.Compile(bodyreassignEnabled, nameof(bodyreassignEnabled), required: false);
            var __workflow_bodyactionUrlExpirationPeriodInDays = WorkflowExpression.Compile(bodyactionUrlExpirationPeriodInDays, nameof(bodyactionUrlExpirationPeriodInDays), required: false);
            var __workflow_bodyexpiryTimestamp = WorkflowExpression.Compile(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            var __workflow_bodyexternalDocumentReference = WorkflowExpression.Compile(bodyexternalDocumentReference, nameof(bodyexternalDocumentReference), required: false);
            var __workflow_bodyexternalPackageReference = WorkflowExpression.Compile(bodyexternalPackageReference, nameof(bodyexternalPackageReference), required: false);
            var __workflow_bodyf2FRedirectUrl = WorkflowExpression.Compile(bodyf2FRedirectUrl, nameof(bodyf2FRedirectUrl), required: false);
            var __workflow_bodynotificationCallBackUrl = WorkflowExpression.Compile(bodynotificationCallBackUrl, nameof(bodynotificationCallBackUrl), required: false);
            var __workflow_bodypdfErrorHandling = WorkflowExpression.Compile(bodypdfErrorHandling, nameof(bodypdfErrorHandling), required: false);
            var __workflow_bodyrepresentation = WorkflowExpression.Compile(bodyrepresentation, nameof(bodyrepresentation), required: false);
            var __workflow_bodyrepresentationType = WorkflowExpression.Compile(bodyrepresentationType, nameof(bodyrepresentationType), required: false);
            var __workflow_bodysigningTemplateCode = WorkflowExpression.Compile(bodysigningTemplateCode, nameof(bodysigningTemplateCode), required: false);
            var __workflow_bodytargetType = WorkflowExpression.Compile(bodytargetType, nameof(bodytargetType), required: false);
            return new DeferredBodyAction<CreateInstantPackageResponse>(() =>
            {
                var apiCallPath = "/packages/instant";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocument != null)
                {
                    if (__workflow_bodydocument != null)
                    {
                        body["Document"] = ExpressionConverter.ConvertO(__workflow_bodydocument);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Document"] = "";
                    bodypropCount++;
                }

                if (__workflow_bodydocumentLanguage != null)
                {
                    body["DocumentLanguage"] = ExpressionConverter.ConvertO(__workflow_bodydocumentLanguage);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentName != null)
                {
                    body["DocumentName"] = ExpressionConverter.ConvertO(__workflow_bodydocumentName);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalPackageData != null)
                {
                    body["ExternalPackageData"] = ExpressionConverter.ConvertO(__workflow_bodyexternalPackageData);
                    bodypropCount++;
                }

                if (__workflow_bodyinitiator != null)
                {
                    body["Initiator"] = ExpressionConverter.ConvertO(__workflow_bodyinitiator);
                    bodypropCount++;
                }

                if (__workflow_bodystakeholders != null)
                {
                    body["Stakeholders"] = ExpressionConverter.ConvertO(__workflow_bodystakeholders);
                    bodypropCount++;
                }

                if (__workflow_bodycallBackUrl != null)
                {
                    body["CallBackUrl"] = ExpressionConverter.ConvertO(__workflow_bodycallBackUrl);
                    bodypropCount++;
                }

                if (__workflow_bodycorrelationId != null)
                {
                    body["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentGroupCode != null)
                {
                    if (__workflow_bodydocumentGroupCode != null)
                    {
                        body["DocumentGroupCode"] = ExpressionConverter.ConvertO(__workflow_bodydocumentGroupCode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["DocumentGroupCode"] = "\"00001\"";
                    bodypropCount++;
                }

                if (__workflow_bodythemeCode != null)
                {
                    body["ThemeCode"] = ExpressionConverter.ConvertO(__workflow_bodythemeCode);
                    bodypropCount++;
                }

                if (__workflow_bodydownloadUnsignedFiles != null)
                {
                    body["DownloadUnsignedFiles"] = ExpressionConverter.ConvertO(__workflow_bodydownloadUnsignedFiles);
                    bodypropCount++;
                }

                if (__workflow_bodyreassignEnabled != null)
                {
                    body["ReassignEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyreassignEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodyactionUrlExpirationPeriodInDays != null)
                {
                    body["ActionUrlExpirationPeriodInDays"] = ExpressionConverter.ConvertO(__workflow_bodyactionUrlExpirationPeriodInDays);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiryTimestamp != null)
                {
                    body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryTimestamp);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalDocumentReference != null)
                {
                    body["ExternalDocumentReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentReference);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalPackageReference != null)
                {
                    body["ExternalPackageReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalPackageReference);
                    bodypropCount++;
                }

                if (__workflow_bodyf2FRedirectUrl != null)
                {
                    body["F2FRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodyf2FRedirectUrl);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationCallBackUrl != null)
                {
                    body["NotificationCallBackUrl"] = ExpressionConverter.ConvertO(__workflow_bodynotificationCallBackUrl);
                    bodypropCount++;
                }

                if (__workflow_bodypdfErrorHandling != null)
                {
                    body["PdfErrorHandling"] = ExpressionConverter.ConvertO(__workflow_bodypdfErrorHandling);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentation != null)
                {
                    body["Representation"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentation);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentationType != null)
                {
                    body["RepresentationType"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentationType);
                    bodypropCount++;
                }

                if (__workflow_bodysigningTemplateCode != null)
                {
                    body["SigningTemplateCode"] = ExpressionConverter.ConvertO(__workflow_bodysigningTemplateCode);
                    bodypropCount++;
                }

                if (__workflow_bodytargetType != null)
                {
                    body["TargetType"] = ExpressionConverter.ConvertO(__workflow_bodytargetType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateInstantPackageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageListResponse> PackageList(Expression<Func<string>> continuationToken = null, Expression<Func<int>> maxQuantity = null, Expression<Func<string>> sortField = null, Expression<Func<string>> sortOrder = null, Expression<Func<string>> createdBeforeDate = null, Expression<Func<string>> status = null, Expression<Func<string>> createdAfterDate = null)
        {
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_maxQuantity = WorkflowExpression.Compile(maxQuantity, nameof(maxQuantity), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_createdBeforeDate = WorkflowExpression.Compile(createdBeforeDate, nameof(createdBeforeDate), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_createdAfterDate = WorkflowExpression.Compile(createdAfterDate, nameof(createdAfterDate), required: false);
            return new DeferredBodyAction<PackageListResponse>(() =>
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["ContinuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                if (__workflow_maxQuantity != null)
                    callPayload.Queries["MaxQuantity"] = ExpressionConverter.Convert(__workflow_maxQuantity);
                if (__workflow_sortField != null)
                    callPayload.Queries["SortField"] = ExpressionConverter.Convert(__workflow_sortField);
                callPayload.Queries["SortOrder"] = Convert.ToString("\"ASC\"");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["SortOrder"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["CreatedBeforeDate"] = Convert.ToString("{{$timestamp}}");
                if (__workflow_createdBeforeDate != null)
                    callPayload.Queries["CreatedBeforeDate"] = ExpressionConverter.Convert(__workflow_createdBeforeDate);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["createdAfterDate"] = Convert.ToString("{{eSigner - FutureDate}}");
                if (__workflow_createdAfterDate != null)
                    callPayload.Queries["createdAfterDate"] = ExpressionConverter.Convert(__workflow_createdAfterDate);
                return new ApiConnectionAction<PackageListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreatePackageResponse> CreatePackage(Expression<Func<string>> contentType, Expression<Func<string>> bodyinitiator = null, Expression<Func<string>> bodypackageName = null, Expression<Func<string>> bodycallBackUrl = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodydocumentGroupCode = null, Expression<Func<string>> bodythemeCode = null, Expression<Func<bool>> bodydownloadUnsignedFiles = null, Expression<Func<bool>> bodyreassignEnabled = null, Expression<Func<int>> bodyactionUrlExpirationPeriodInDays = null, Expression<Func<string>> bodyexpiryTimestamp = null, Expression<Func<string>> bodyexternalPackageReference = null, Expression<Func<string>> bodyexternalPackageData = null, Expression<Func<string>> bodyf2FRedirectUrl = null, Expression<Func<string>> bodynotificationCallBackUrl = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodyinitiator = WorkflowExpression.Compile(bodyinitiator, nameof(bodyinitiator), required: false);
            var __workflow_bodypackageName = WorkflowExpression.Compile(bodypackageName, nameof(bodypackageName), required: false);
            var __workflow_bodycallBackUrl = WorkflowExpression.Compile(bodycallBackUrl, nameof(bodycallBackUrl), required: false);
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: false);
            var __workflow_bodydocumentGroupCode = WorkflowExpression.Compile(bodydocumentGroupCode, nameof(bodydocumentGroupCode), required: false);
            var __workflow_bodythemeCode = WorkflowExpression.Compile(bodythemeCode, nameof(bodythemeCode), required: false);
            var __workflow_bodydownloadUnsignedFiles = WorkflowExpression.Compile(bodydownloadUnsignedFiles, nameof(bodydownloadUnsignedFiles), required: false);
            var __workflow_bodyreassignEnabled = WorkflowExpression.Compile(bodyreassignEnabled, nameof(bodyreassignEnabled), required: false);
            var __workflow_bodyactionUrlExpirationPeriodInDays = WorkflowExpression.Compile(bodyactionUrlExpirationPeriodInDays, nameof(bodyactionUrlExpirationPeriodInDays), required: false);
            var __workflow_bodyexpiryTimestamp = WorkflowExpression.Compile(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            var __workflow_bodyexternalPackageReference = WorkflowExpression.Compile(bodyexternalPackageReference, nameof(bodyexternalPackageReference), required: false);
            var __workflow_bodyexternalPackageData = WorkflowExpression.Compile(bodyexternalPackageData, nameof(bodyexternalPackageData), required: false);
            var __workflow_bodyf2FRedirectUrl = WorkflowExpression.Compile(bodyf2FRedirectUrl, nameof(bodyf2FRedirectUrl), required: false);
            var __workflow_bodynotificationCallBackUrl = WorkflowExpression.Compile(bodynotificationCallBackUrl, nameof(bodynotificationCallBackUrl), required: false);
            return new DeferredBodyAction<CreatePackageResponse>(() =>
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinitiator != null)
                {
                    body["Initiator"] = ExpressionConverter.ConvertO(__workflow_bodyinitiator);
                    bodypropCount++;
                }

                if (__workflow_bodypackageName != null)
                {
                    body["PackageName"] = ExpressionConverter.ConvertO(__workflow_bodypackageName);
                    bodypropCount++;
                }

                if (__workflow_bodycallBackUrl != null)
                {
                    body["CallBackUrl"] = ExpressionConverter.ConvertO(__workflow_bodycallBackUrl);
                    bodypropCount++;
                }

                if (__workflow_bodycorrelationId != null)
                {
                    body["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentGroupCode != null)
                {
                    body["DocumentGroupCode"] = ExpressionConverter.ConvertO(__workflow_bodydocumentGroupCode);
                    bodypropCount++;
                }

                if (__workflow_bodythemeCode != null)
                {
                    body["ThemeCode"] = ExpressionConverter.ConvertO(__workflow_bodythemeCode);
                    bodypropCount++;
                }

                if (__workflow_bodydownloadUnsignedFiles != null)
                {
                    body["DownloadUnsignedFiles"] = ExpressionConverter.ConvertO(__workflow_bodydownloadUnsignedFiles);
                    bodypropCount++;
                }

                if (__workflow_bodyreassignEnabled != null)
                {
                    body["ReassignEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyreassignEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodyactionUrlExpirationPeriodInDays != null)
                {
                    body["ActionUrlExpirationPeriodInDays"] = ExpressionConverter.ConvertO(__workflow_bodyactionUrlExpirationPeriodInDays);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiryTimestamp != null)
                {
                    body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryTimestamp);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalPackageReference != null)
                {
                    body["ExternalPackageReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalPackageReference);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalPackageData != null)
                {
                    body["ExternalPackageData"] = ExpressionConverter.ConvertO(__workflow_bodyexternalPackageData);
                    bodypropCount++;
                }

                if (__workflow_bodyf2FRedirectUrl != null)
                {
                    body["F2FRedirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodyf2FRedirectUrl);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationCallBackUrl != null)
                {
                    body["NotificationCallBackUrl"] = ExpressionConverter.ConvertO(__workflow_bodynotificationCallBackUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreatePackageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> AddDocumentToPackage(Expression<Func<string>> packageId, Expression<Func<string>> bodydocument = null, Expression<Func<string>> bodydocumentLanguage = null, Expression<Func<string>> bodydocumentName = null, Expression<Func<SigningField[]>> bodysigningFields = null, Expression<Func<string>> bodycorrelationId = null, Expression<Func<string>> bodydocumentType = null, Expression<Func<string>> bodyexternalDocumentReference = null, Expression<Func<ErrorHandlingResponse[]>> bodypdfErrorHandling = null, Expression<Func<string>> bodyrepresentation = null, Expression<Func<string>> bodyrepresentationType = null, Expression<Func<string>> bodytargetType = null)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            var __workflow_bodydocument = WorkflowExpression.Compile(bodydocument, nameof(bodydocument), required: false);
            var __workflow_bodydocumentLanguage = WorkflowExpression.Compile(bodydocumentLanguage, nameof(bodydocumentLanguage), required: false);
            var __workflow_bodydocumentName = WorkflowExpression.Compile(bodydocumentName, nameof(bodydocumentName), required: false);
            var __workflow_bodysigningFields = WorkflowExpression.Compile(bodysigningFields, nameof(bodysigningFields), required: false);
            var __workflow_bodycorrelationId = WorkflowExpression.Compile(bodycorrelationId, nameof(bodycorrelationId), required: false);
            var __workflow_bodydocumentType = WorkflowExpression.Compile(bodydocumentType, nameof(bodydocumentType), required: false);
            var __workflow_bodyexternalDocumentReference = WorkflowExpression.Compile(bodyexternalDocumentReference, nameof(bodyexternalDocumentReference), required: false);
            var __workflow_bodypdfErrorHandling = WorkflowExpression.Compile(bodypdfErrorHandling, nameof(bodypdfErrorHandling), required: false);
            var __workflow_bodyrepresentation = WorkflowExpression.Compile(bodyrepresentation, nameof(bodyrepresentation), required: false);
            var __workflow_bodyrepresentationType = WorkflowExpression.Compile(bodyrepresentationType, nameof(bodyrepresentationType), required: false);
            var __workflow_bodytargetType = WorkflowExpression.Compile(bodytargetType, nameof(bodytargetType), required: false);
            return new DeferredBodyAction<AddDocumentToPackageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydocument != null)
                {
                    body["Document"] = ExpressionConverter.ConvertO(__workflow_bodydocument);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentLanguage != null)
                {
                    body["DocumentLanguage"] = ExpressionConverter.ConvertO(__workflow_bodydocumentLanguage);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentName != null)
                {
                    body["DocumentName"] = ExpressionConverter.ConvertO(__workflow_bodydocumentName);
                    bodypropCount++;
                }

                if (__workflow_bodysigningFields != null)
                {
                    body["SigningFields"] = ExpressionConverter.ConvertO(__workflow_bodysigningFields);
                    bodypropCount++;
                }

                if (__workflow_bodycorrelationId != null)
                {
                    body["CorrelationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentType != null)
                {
                    body["DocumentType"] = ExpressionConverter.ConvertO(__workflow_bodydocumentType);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalDocumentReference != null)
                {
                    body["ExternalDocumentReference"] = ExpressionConverter.ConvertO(__workflow_bodyexternalDocumentReference);
                    bodypropCount++;
                }

                if (__workflow_bodypdfErrorHandling != null)
                {
                    body["PdfErrorHandling"] = ExpressionConverter.ConvertO(__workflow_bodypdfErrorHandling);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentation != null)
                {
                    body["Representation"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentation);
                    bodypropCount++;
                }

                if (__workflow_bodyrepresentationType != null)
                {
                    body["RepresentationType"] = ExpressionConverter.ConvertO(__workflow_bodyrepresentationType);
                    bodypropCount++;
                }

                if (__workflow_bodytargetType != null)
                {
                    body["TargetType"] = ExpressionConverter.ConvertO(__workflow_bodytargetType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddDocumentToPackageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<GetSigningLocationsResponse> GetSigningLocations(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetSigningLocationsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSigningLocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> GetPackageStatus(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PackageStatusInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PackageStatusInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> SetPackageStatus(Expression<Func<string>> id, Expression<Func<string>> bodystatus = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PackageStatusInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PackageStatusInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SkipSigners(Expression<Func<string>> packageId)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/skipsigners", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadPackage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadDocumentFromPackage(Expression<Func<string>> id, Expression<Func<string>> documentId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ExpiryTimeStamp(Expression<Func<string>> id, Expression<Func<string>> bodyexpiryTimestamp = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyexpiryTimestamp = WorkflowExpression.Compile(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/expirytimestamp", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexpiryTimestamp != null)
                {
                    body["ExpiryTimestamp"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryTimestamp);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SendPackageReminders(Expression<Func<string>> packageId)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/reminders", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction DeletePackage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SetProcessInformation(Expression<Func<string>> id, Expression<Func<bodystakeholdersInputItem[]>> bodystakeholders = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodystakeholders = WorkflowExpression.Compile(bodystakeholders, nameof(bodystakeholders), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/process", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystakeholders != null)
                {
                    body["Stakeholders"] = ExpressionConverter.ConvertO(__workflow_bodystakeholders);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProof(Expression<Func<string>> packageId)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProofDoc(Expression<Func<string>> packageId, Expression<Func<string>> documentId)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageCorrelationAuditProof(Expression<Func<string>> correlationId)
        {
            var __workflow_correlationId = WorkflowExpression.Compile(correlationId, nameof(correlationId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packagecorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(__workflow_correlationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> DocumentCorrelationAuditProof(Expression<Func<string>> correlationId)
        {
            var __workflow_correlationId = WorkflowExpression.Compile(correlationId, nameof(correlationId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentcorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(__workflow_correlationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ProofExternalSource(Expression<Func<string>> packageId, Expression<Func<string>> bodycontent = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyipAddress = null)
        {
            var __workflow_packageId = WorkflowExpression.Compile(packageId, nameof(packageId), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyipAddress = WorkflowExpression.Compile(bodyipAddress, nameof(bodyipAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/proofs", ExpressionConverter.ConvertWithUrlEncoding(__workflow_packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycontent != null)
                {
                    body["Content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodylocationId != null)
                {
                    body["LocationId"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["Type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyipAddress != null)
                {
                    body["IpAddress"] = ExpressionConverter.ConvertO(__workflow_bodyipAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystakeholdersInputItemActorsTypeItemTypeType
    {
        Signer,
        Receiver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
