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
        [WorkflowExpressionFactory(nameof(__BuildCreateInstantPackage))]
        public IBodyWorkflowAction<CreateInstantPackageResponse> CreateInstantPackage([WorkflowExpression] Func<string> bodydocument = null, [WorkflowExpression] Func<bodydocumentLanguageInput> bodydocumentLanguage = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<string> bodyexternalPackageData = null, [WorkflowExpression] Func<string> bodyinitiator = null, [WorkflowExpression] Func<Stakeholder[]> bodystakeholders = null, [WorkflowExpression] Func<string> bodycallBackUrl = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentGroupCode = null, [WorkflowExpression] Func<string> bodythemeCode = null, [WorkflowExpression] Func<bool> bodydownloadUnsignedFiles = null, [WorkflowExpression] Func<bool> bodyreassignEnabled = null, [WorkflowExpression] Func<int> bodyactionUrlExpirationPeriodInDays = null, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null, [WorkflowExpression] Func<string> bodyexternalDocumentReference = null, [WorkflowExpression] Func<string> bodyexternalPackageReference = null, [WorkflowExpression] Func<string> bodyf2FRedirectUrl = null, [WorkflowExpression] Func<string> bodynotificationCallBackUrl = null, [WorkflowExpression] Func<string> bodypdfErrorHandling = null, [WorkflowExpression] Func<string> bodyrepresentation = null, [WorkflowExpression] Func<string> bodyrepresentationType = null, [WorkflowExpression] Func<string> bodysigningTemplateCode = null, [WorkflowExpression] Func<string> bodytargetType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateInstantPackageResponse> __BuildCreateInstantPackage(WorkflowExpression<string> bodydocument = null, WorkflowExpression<bodydocumentLanguageInput> bodydocumentLanguage = null, WorkflowExpression<string> bodydocumentName = null, WorkflowExpression<string> bodyexternalPackageData = null, WorkflowExpression<string> bodyinitiator = null, WorkflowExpression<Stakeholder[]> bodystakeholders = null, WorkflowExpression<string> bodycallBackUrl = null, WorkflowExpression<string> bodycorrelationId = null, WorkflowExpression<string> bodydocumentGroupCode = null, WorkflowExpression<string> bodythemeCode = null, WorkflowExpression<bool> bodydownloadUnsignedFiles = null, WorkflowExpression<bool> bodyreassignEnabled = null, WorkflowExpression<int> bodyactionUrlExpirationPeriodInDays = null, WorkflowExpression<string> bodyexpiryTimestamp = null, WorkflowExpression<string> bodyexternalDocumentReference = null, WorkflowExpression<string> bodyexternalPackageReference = null, WorkflowExpression<string> bodyf2FRedirectUrl = null, WorkflowExpression<string> bodynotificationCallBackUrl = null, WorkflowExpression<string> bodypdfErrorHandling = null, WorkflowExpression<string> bodyrepresentation = null, WorkflowExpression<string> bodyrepresentationType = null, WorkflowExpression<string> bodysigningTemplateCode = null, WorkflowExpression<string> bodytargetType = null)
        {
            WorkflowExpression.Validate(bodydocument, nameof(bodydocument), required: false);
            WorkflowExpression.Validate(bodydocumentLanguage, nameof(bodydocumentLanguage), required: false);
            WorkflowExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            WorkflowExpression.Validate(bodyexternalPackageData, nameof(bodyexternalPackageData), required: false);
            WorkflowExpression.Validate(bodyinitiator, nameof(bodyinitiator), required: false);
            WorkflowExpression.Validate(bodystakeholders, nameof(bodystakeholders), required: false);
            WorkflowExpression.Validate(bodycallBackUrl, nameof(bodycallBackUrl), required: false);
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            WorkflowExpression.Validate(bodydocumentGroupCode, nameof(bodydocumentGroupCode), required: false);
            WorkflowExpression.Validate(bodythemeCode, nameof(bodythemeCode), required: false);
            WorkflowExpression.Validate(bodydownloadUnsignedFiles, nameof(bodydownloadUnsignedFiles), required: false);
            WorkflowExpression.Validate(bodyreassignEnabled, nameof(bodyreassignEnabled), required: false);
            WorkflowExpression.Validate(bodyactionUrlExpirationPeriodInDays, nameof(bodyactionUrlExpirationPeriodInDays), required: false);
            WorkflowExpression.Validate(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            WorkflowExpression.Validate(bodyexternalDocumentReference, nameof(bodyexternalDocumentReference), required: false);
            WorkflowExpression.Validate(bodyexternalPackageReference, nameof(bodyexternalPackageReference), required: false);
            WorkflowExpression.Validate(bodyf2FRedirectUrl, nameof(bodyf2FRedirectUrl), required: false);
            WorkflowExpression.Validate(bodynotificationCallBackUrl, nameof(bodynotificationCallBackUrl), required: false);
            WorkflowExpression.Validate(bodypdfErrorHandling, nameof(bodypdfErrorHandling), required: false);
            WorkflowExpression.Validate(bodyrepresentation, nameof(bodyrepresentation), required: false);
            WorkflowExpression.Validate(bodyrepresentationType, nameof(bodyrepresentationType), required: false);
            WorkflowExpression.Validate(bodysigningTemplateCode, nameof(bodysigningTemplateCode), required: false);
            WorkflowExpression.Validate(bodytargetType, nameof(bodytargetType), required: false);
            return new DeferredBodyAction<CreateInstantPackageResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildPackageList))]
        public IBodyWorkflowAction<PackageListResponse> PackageList([WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<int> maxQuantity = null, [WorkflowExpression] Func<string> sortField = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<string> createdBeforeDate = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> createdAfterDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PackageListResponse> __BuildPackageList(WorkflowExpression<string> continuationToken = null, WorkflowExpression<int> maxQuantity = null, WorkflowExpression<string> sortField = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<string> createdBeforeDate = null, WorkflowExpression<string> status = null, WorkflowExpression<string> createdAfterDate = null)
        {
            WorkflowExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            WorkflowExpression.Validate(maxQuantity, nameof(maxQuantity), required: false);
            WorkflowExpression.Validate(sortField, nameof(sortField), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(createdBeforeDate, nameof(createdBeforeDate), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(createdAfterDate, nameof(createdAfterDate), required: false);
            return new DeferredBodyAction<PackageListResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePackage))]
        public IBodyWorkflowAction<CreatePackageResponse> CreatePackage([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyinitiator = null, [WorkflowExpression] Func<string> bodypackageName = null, [WorkflowExpression] Func<string> bodycallBackUrl = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentGroupCode = null, [WorkflowExpression] Func<string> bodythemeCode = null, [WorkflowExpression] Func<bool> bodydownloadUnsignedFiles = null, [WorkflowExpression] Func<bool> bodyreassignEnabled = null, [WorkflowExpression] Func<int> bodyactionUrlExpirationPeriodInDays = null, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null, [WorkflowExpression] Func<string> bodyexternalPackageReference = null, [WorkflowExpression] Func<string> bodyexternalPackageData = null, [WorkflowExpression] Func<string> bodyf2FRedirectUrl = null, [WorkflowExpression] Func<string> bodynotificationCallBackUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePackageResponse> __BuildCreatePackage(WorkflowExpression<string> contentType, WorkflowExpression<string> bodyinitiator = null, WorkflowExpression<string> bodypackageName = null, WorkflowExpression<string> bodycallBackUrl = null, WorkflowExpression<string> bodycorrelationId = null, WorkflowExpression<string> bodydocumentGroupCode = null, WorkflowExpression<string> bodythemeCode = null, WorkflowExpression<bool> bodydownloadUnsignedFiles = null, WorkflowExpression<bool> bodyreassignEnabled = null, WorkflowExpression<int> bodyactionUrlExpirationPeriodInDays = null, WorkflowExpression<string> bodyexpiryTimestamp = null, WorkflowExpression<string> bodyexternalPackageReference = null, WorkflowExpression<string> bodyexternalPackageData = null, WorkflowExpression<string> bodyf2FRedirectUrl = null, WorkflowExpression<string> bodynotificationCallBackUrl = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(bodyinitiator, nameof(bodyinitiator), required: false);
            WorkflowExpression.Validate(bodypackageName, nameof(bodypackageName), required: false);
            WorkflowExpression.Validate(bodycallBackUrl, nameof(bodycallBackUrl), required: false);
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            WorkflowExpression.Validate(bodydocumentGroupCode, nameof(bodydocumentGroupCode), required: false);
            WorkflowExpression.Validate(bodythemeCode, nameof(bodythemeCode), required: false);
            WorkflowExpression.Validate(bodydownloadUnsignedFiles, nameof(bodydownloadUnsignedFiles), required: false);
            WorkflowExpression.Validate(bodyreassignEnabled, nameof(bodyreassignEnabled), required: false);
            WorkflowExpression.Validate(bodyactionUrlExpirationPeriodInDays, nameof(bodyactionUrlExpirationPeriodInDays), required: false);
            WorkflowExpression.Validate(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            WorkflowExpression.Validate(bodyexternalPackageReference, nameof(bodyexternalPackageReference), required: false);
            WorkflowExpression.Validate(bodyexternalPackageData, nameof(bodyexternalPackageData), required: false);
            WorkflowExpression.Validate(bodyf2FRedirectUrl, nameof(bodyf2FRedirectUrl), required: false);
            WorkflowExpression.Validate(bodynotificationCallBackUrl, nameof(bodynotificationCallBackUrl), required: false);
            return new DeferredBodyAction<CreatePackageResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildAddDocumentToPackage))]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> AddDocumentToPackage([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> bodydocument = null, [WorkflowExpression] Func<string> bodydocumentLanguage = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<SigningField[]> bodysigningFields = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentType = null, [WorkflowExpression] Func<string> bodyexternalDocumentReference = null, [WorkflowExpression] Func<ErrorHandlingResponse[]> bodypdfErrorHandling = null, [WorkflowExpression] Func<string> bodyrepresentation = null, [WorkflowExpression] Func<string> bodyrepresentationType = null, [WorkflowExpression] Func<string> bodytargetType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> __BuildAddDocumentToPackage(WorkflowExpression<string> packageId, WorkflowExpression<string> bodydocument = null, WorkflowExpression<string> bodydocumentLanguage = null, WorkflowExpression<string> bodydocumentName = null, WorkflowExpression<SigningField[]> bodysigningFields = null, WorkflowExpression<string> bodycorrelationId = null, WorkflowExpression<string> bodydocumentType = null, WorkflowExpression<string> bodyexternalDocumentReference = null, WorkflowExpression<ErrorHandlingResponse[]> bodypdfErrorHandling = null, WorkflowExpression<string> bodyrepresentation = null, WorkflowExpression<string> bodyrepresentationType = null, WorkflowExpression<string> bodytargetType = null)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            WorkflowExpression.Validate(bodydocument, nameof(bodydocument), required: false);
            WorkflowExpression.Validate(bodydocumentLanguage, nameof(bodydocumentLanguage), required: false);
            WorkflowExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            WorkflowExpression.Validate(bodysigningFields, nameof(bodysigningFields), required: false);
            WorkflowExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            WorkflowExpression.Validate(bodydocumentType, nameof(bodydocumentType), required: false);
            WorkflowExpression.Validate(bodyexternalDocumentReference, nameof(bodyexternalDocumentReference), required: false);
            WorkflowExpression.Validate(bodypdfErrorHandling, nameof(bodypdfErrorHandling), required: false);
            WorkflowExpression.Validate(bodyrepresentation, nameof(bodyrepresentation), required: false);
            WorkflowExpression.Validate(bodyrepresentationType, nameof(bodyrepresentationType), required: false);
            WorkflowExpression.Validate(bodytargetType, nameof(bodytargetType), required: false);
            return new DeferredBodyAction<AddDocumentToPackageResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildGetSigningLocations))]
        public IBodyWorkflowAction<GetSigningLocationsResponse> GetSigningLocations([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSigningLocationsResponse> __BuildGetSigningLocations(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetSigningLocationsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/locations", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSigningLocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildGetPackageStatus))]
        public IBodyWorkflowAction<PackageStatusInfo> GetPackageStatus([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PackageStatusInfo> __BuildGetPackageStatus(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<PackageStatusInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PackageStatusInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildSetPackageStatus))]
        public IBodyWorkflowAction<PackageStatusInfo> SetPackageStatus([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodystatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PackageStatusInfo> __BuildSetPackageStatus(WorkflowExpression<string> id, WorkflowExpression<string> bodystatus = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            return new DeferredBodyAction<PackageStatusInfo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildSkipSigners))]
        public IWorkflowAction SkipSigners([WorkflowExpression] Func<string> packageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSkipSigners(WorkflowExpression<string> packageId)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/skipsigners", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadPackage))]
        public IBodyWorkflowAction<string> DownloadPackage([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDownloadPackage(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/download", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadDocumentFromPackage))]
        public IBodyWorkflowAction<string> DownloadDocumentFromPackage([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDownloadDocumentFromPackage(WorkflowExpression<string> id, WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildExpiryTimeStamp))]
        public IWorkflowAction ExpiryTimeStamp([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildExpiryTimeStamp(WorkflowExpression<string> id, WorkflowExpression<string> bodyexpiryTimestamp = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/expirytimestamp", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildSendPackageReminders))]
        public IWorkflowAction SendPackageReminders([WorkflowExpression] Func<string> packageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendPackageReminders(WorkflowExpression<string> packageId)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/reminders", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildDeletePackage))]
        public IWorkflowAction DeletePackage([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletePackage(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildSetProcessInformation))]
        public IWorkflowAction SetProcessInformation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodystakeholdersInputItem[]> bodystakeholders = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetProcessInformation(WorkflowExpression<string> id, WorkflowExpression<bodystakeholdersInputItem[]> bodystakeholders = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodystakeholders, nameof(bodystakeholders), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/process", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildPackageAuditProof))]
        public IBodyWorkflowAction<Content> PackageAuditProof([WorkflowExpression] Func<string> packageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Content> __BuildPackageAuditProof(WorkflowExpression<string> packageId)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildPackageAuditProofDoc))]
        public IBodyWorkflowAction<Content> PackageAuditProofDoc([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> documentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Content> __BuildPackageAuditProofDoc(WorkflowExpression<string> packageId, WorkflowExpression<string> documentId)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            WorkflowExpression.Validate(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download/{1}", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildPackageCorrelationAuditProof))]
        public IBodyWorkflowAction<Content> PackageCorrelationAuditProof([WorkflowExpression] Func<string> correlationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Content> __BuildPackageCorrelationAuditProof(WorkflowExpression<string> correlationId)
        {
            WorkflowExpression.Validate(correlationId, nameof(correlationId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packagecorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(correlationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildDocumentCorrelationAuditProof))]
        public IBodyWorkflowAction<Content> DocumentCorrelationAuditProof([WorkflowExpression] Func<string> correlationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Content> __BuildDocumentCorrelationAuditProof(WorkflowExpression<string> correlationId)
        {
            WorkflowExpression.Validate(correlationId, nameof(correlationId), required: true);
            return new DeferredBodyAction<Content>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/documentcorrelations/{0}/auditproof/download", ExpressionConverter.ConvertWithUrlEncoding(correlationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Content>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [WorkflowExpressionFactory(nameof(__BuildProofExternalSource))]
        public IWorkflowAction ProofExternalSource([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyipAddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProofExternalSource(WorkflowExpression<string> packageId, WorkflowExpression<string> bodycontent = null, WorkflowExpression<string> bodylocationId = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyipAddress = null)
        {
            WorkflowExpression.Validate(packageId, nameof(packageId), required: true);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            WorkflowExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyipAddress, nameof(bodyipAddress), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/proofs", ExpressionConverter.ConvertWithUrlEncoding(packageId, 1));
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