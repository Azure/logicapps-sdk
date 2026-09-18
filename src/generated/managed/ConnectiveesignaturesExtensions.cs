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
        public IBodyWorkflowAction<CreateInstantPackageResponse> CreateInstantPackage([WorkflowExpression] Func<string> bodydocument = null, [WorkflowExpression] Func<bodydocumentLanguageInput> bodydocumentLanguage = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<string> bodyexternalPackageData = null, [WorkflowExpression] Func<string> bodyinitiator = null, [WorkflowExpression] Func<Stakeholder[]> bodystakeholders = null, [WorkflowExpression] Func<string> bodycallBackUrl = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentGroupCode = null, [WorkflowExpression] Func<string> bodythemeCode = null, [WorkflowExpression] Func<bool> bodydownloadUnsignedFiles = null, [WorkflowExpression] Func<bool> bodyreassignEnabled = null, [WorkflowExpression] Func<int> bodyactionUrlExpirationPeriodInDays = null, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null, [WorkflowExpression] Func<string> bodyexternalDocumentReference = null, [WorkflowExpression] Func<string> bodyexternalPackageReference = null, [WorkflowExpression] Func<string> bodyf2FRedirectUrl = null, [WorkflowExpression] Func<string> bodynotificationCallBackUrl = null, [WorkflowExpression] Func<string> bodypdfErrorHandling = null, [WorkflowExpression] Func<string> bodyrepresentation = null, [WorkflowExpression] Func<string> bodyrepresentationType = null, [WorkflowExpression] Func<string> bodysigningTemplateCode = null, [WorkflowExpression] Func<string> bodytargetType = null)
        {
            SourceExpression.Validate(bodydocument, nameof(bodydocument), required: false);
            SourceExpression.Validate(bodydocumentLanguage, nameof(bodydocumentLanguage), required: false);
            SourceExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            SourceExpression.Validate(bodyexternalPackageData, nameof(bodyexternalPackageData), required: false);
            SourceExpression.Validate(bodyinitiator, nameof(bodyinitiator), required: false);
            SourceExpression.Validate(bodystakeholders, nameof(bodystakeholders), required: false);
            SourceExpression.Validate(bodycallBackUrl, nameof(bodycallBackUrl), required: false);
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            SourceExpression.Validate(bodydocumentGroupCode, nameof(bodydocumentGroupCode), required: false);
            SourceExpression.Validate(bodythemeCode, nameof(bodythemeCode), required: false);
            SourceExpression.Validate(bodydownloadUnsignedFiles, nameof(bodydownloadUnsignedFiles), required: false);
            SourceExpression.Validate(bodyreassignEnabled, nameof(bodyreassignEnabled), required: false);
            SourceExpression.Validate(bodyactionUrlExpirationPeriodInDays, nameof(bodyactionUrlExpirationPeriodInDays), required: false);
            SourceExpression.Validate(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            SourceExpression.Validate(bodyexternalDocumentReference, nameof(bodyexternalDocumentReference), required: false);
            SourceExpression.Validate(bodyexternalPackageReference, nameof(bodyexternalPackageReference), required: false);
            SourceExpression.Validate(bodyf2FRedirectUrl, nameof(bodyf2FRedirectUrl), required: false);
            SourceExpression.Validate(bodynotificationCallBackUrl, nameof(bodynotificationCallBackUrl), required: false);
            SourceExpression.Validate(bodypdfErrorHandling, nameof(bodypdfErrorHandling), required: false);
            SourceExpression.Validate(bodyrepresentation, nameof(bodyrepresentation), required: false);
            SourceExpression.Validate(bodyrepresentationType, nameof(bodyrepresentationType), required: false);
            SourceExpression.Validate(bodysigningTemplateCode, nameof(bodysigningTemplateCode), required: false);
            SourceExpression.Validate(bodytargetType, nameof(bodytargetType), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        body["Document"] = SourceExpressionConverter.ConvertToken(bodydocument);
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
                    body["DocumentLanguage"] = SourceExpressionConverter.Convert(bodydocumentLanguage);
                    bodypropCount++;
                }

                if (bodydocumentName != null)
                {
                    body["DocumentName"] = SourceExpressionConverter.ConvertToken(bodydocumentName);
                    bodypropCount++;
                }

                if (bodyexternalPackageData != null)
                {
                    body["ExternalPackageData"] = SourceExpressionConverter.ConvertToken(bodyexternalPackageData);
                    bodypropCount++;
                }

                if (bodyinitiator != null)
                {
                    body["Initiator"] = SourceExpressionConverter.ConvertToken(bodyinitiator);
                    bodypropCount++;
                }

                if (bodystakeholders != null)
                {
                    body["Stakeholders"] = SourceExpressionConverter.ConvertToken(bodystakeholders);
                    bodypropCount++;
                }

                if (bodycallBackUrl != null)
                {
                    body["CallBackUrl"] = SourceExpressionConverter.ConvertToken(bodycallBackUrl);
                    bodypropCount++;
                }

                if (bodycorrelationId != null)
                {
                    body["CorrelationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                    bodypropCount++;
                }

                if (bodydocumentGroupCode != null)
                {
                    if (bodydocumentGroupCode != null)
                    {
                        body["DocumentGroupCode"] = SourceExpressionConverter.ConvertToken(bodydocumentGroupCode);
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
                    body["ThemeCode"] = SourceExpressionConverter.ConvertToken(bodythemeCode);
                    bodypropCount++;
                }

                if (bodydownloadUnsignedFiles != null)
                {
                    body["DownloadUnsignedFiles"] = SourceExpressionConverter.ConvertToken(bodydownloadUnsignedFiles);
                    bodypropCount++;
                }

                if (bodyreassignEnabled != null)
                {
                    body["ReassignEnabled"] = SourceExpressionConverter.ConvertToken(bodyreassignEnabled);
                    bodypropCount++;
                }

                if (bodyactionUrlExpirationPeriodInDays != null)
                {
                    body["ActionUrlExpirationPeriodInDays"] = SourceExpressionConverter.ConvertToken(bodyactionUrlExpirationPeriodInDays);
                    bodypropCount++;
                }

                if (bodyexpiryTimestamp != null)
                {
                    body["ExpiryTimestamp"] = SourceExpressionConverter.ConvertToken(bodyexpiryTimestamp);
                    bodypropCount++;
                }

                if (bodyexternalDocumentReference != null)
                {
                    body["ExternalDocumentReference"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentReference);
                    bodypropCount++;
                }

                if (bodyexternalPackageReference != null)
                {
                    body["ExternalPackageReference"] = SourceExpressionConverter.ConvertToken(bodyexternalPackageReference);
                    bodypropCount++;
                }

                if (bodyf2FRedirectUrl != null)
                {
                    body["F2FRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodyf2FRedirectUrl);
                    bodypropCount++;
                }

                if (bodynotificationCallBackUrl != null)
                {
                    body["NotificationCallBackUrl"] = SourceExpressionConverter.ConvertToken(bodynotificationCallBackUrl);
                    bodypropCount++;
                }

                if (bodypdfErrorHandling != null)
                {
                    body["PdfErrorHandling"] = SourceExpressionConverter.ConvertToken(bodypdfErrorHandling);
                    bodypropCount++;
                }

                if (bodyrepresentation != null)
                {
                    body["Representation"] = SourceExpressionConverter.ConvertToken(bodyrepresentation);
                    bodypropCount++;
                }

                if (bodyrepresentationType != null)
                {
                    body["RepresentationType"] = SourceExpressionConverter.ConvertToken(bodyrepresentationType);
                    bodypropCount++;
                }

                if (bodysigningTemplateCode != null)
                {
                    body["SigningTemplateCode"] = SourceExpressionConverter.ConvertToken(bodysigningTemplateCode);
                    bodypropCount++;
                }

                if (bodytargetType != null)
                {
                    body["TargetType"] = SourceExpressionConverter.ConvertToken(bodytargetType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateInstantPackageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageListResponse> PackageList([WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<int> maxQuantity = null, [WorkflowExpression] Func<string> sortField = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<string> createdBeforeDate = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> createdAfterDate = null)
        {
            SourceExpression.Validate(continuationToken, nameof(continuationToken), required: false);
            SourceExpression.Validate(maxQuantity, nameof(maxQuantity), required: false);
            SourceExpression.Validate(sortField, nameof(sortField), required: false);
            SourceExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            SourceExpression.Validate(createdBeforeDate, nameof(createdBeforeDate), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(createdAfterDate, nameof(createdAfterDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (continuationToken != null)
                    callPayload.Queries["ContinuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                if (maxQuantity != null)
                    callPayload.Queries["MaxQuantity"] = SourceExpressionConverter.ConvertO(maxQuantity);
                if (sortField != null)
                    callPayload.Queries["SortField"] = SourceExpressionConverter.ConvertO(sortField);
                callPayload.Queries["SortOrder"] = Convert.ToString("\"ASC\"");
                if (sortOrder != null)
                    callPayload.Queries["SortOrder"] = SourceExpressionConverter.ConvertO(sortOrder);
                callPayload.Queries["CreatedBeforeDate"] = Convert.ToString("{{$timestamp}}");
                if (createdBeforeDate != null)
                    callPayload.Queries["CreatedBeforeDate"] = SourceExpressionConverter.ConvertO(createdBeforeDate);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.ConvertO(status);
                callPayload.Queries["createdAfterDate"] = Convert.ToString("{{eSigner - FutureDate}}");
                if (createdAfterDate != null)
                    callPayload.Queries["createdAfterDate"] = SourceExpressionConverter.ConvertO(createdAfterDate);
                return callPayload;
            }

            return new ApiConnectionAction<PackageListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<CreatePackageResponse> CreatePackage([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyinitiator = null, [WorkflowExpression] Func<string> bodypackageName = null, [WorkflowExpression] Func<string> bodycallBackUrl = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentGroupCode = null, [WorkflowExpression] Func<string> bodythemeCode = null, [WorkflowExpression] Func<bool> bodydownloadUnsignedFiles = null, [WorkflowExpression] Func<bool> bodyreassignEnabled = null, [WorkflowExpression] Func<int> bodyactionUrlExpirationPeriodInDays = null, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null, [WorkflowExpression] Func<string> bodyexternalPackageReference = null, [WorkflowExpression] Func<string> bodyexternalPackageData = null, [WorkflowExpression] Func<string> bodyf2FRedirectUrl = null, [WorkflowExpression] Func<string> bodynotificationCallBackUrl = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(bodyinitiator, nameof(bodyinitiator), required: false);
            SourceExpression.Validate(bodypackageName, nameof(bodypackageName), required: false);
            SourceExpression.Validate(bodycallBackUrl, nameof(bodycallBackUrl), required: false);
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            SourceExpression.Validate(bodydocumentGroupCode, nameof(bodydocumentGroupCode), required: false);
            SourceExpression.Validate(bodythemeCode, nameof(bodythemeCode), required: false);
            SourceExpression.Validate(bodydownloadUnsignedFiles, nameof(bodydownloadUnsignedFiles), required: false);
            SourceExpression.Validate(bodyreassignEnabled, nameof(bodyreassignEnabled), required: false);
            SourceExpression.Validate(bodyactionUrlExpirationPeriodInDays, nameof(bodyactionUrlExpirationPeriodInDays), required: false);
            SourceExpression.Validate(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            SourceExpression.Validate(bodyexternalPackageReference, nameof(bodyexternalPackageReference), required: false);
            SourceExpression.Validate(bodyexternalPackageData, nameof(bodyexternalPackageData), required: false);
            SourceExpression.Validate(bodyf2FRedirectUrl, nameof(bodyf2FRedirectUrl), required: false);
            SourceExpression.Validate(bodynotificationCallBackUrl, nameof(bodynotificationCallBackUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/packages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinitiator != null)
                {
                    body["Initiator"] = SourceExpressionConverter.ConvertToken(bodyinitiator);
                    bodypropCount++;
                }

                if (bodypackageName != null)
                {
                    body["PackageName"] = SourceExpressionConverter.ConvertToken(bodypackageName);
                    bodypropCount++;
                }

                if (bodycallBackUrl != null)
                {
                    body["CallBackUrl"] = SourceExpressionConverter.ConvertToken(bodycallBackUrl);
                    bodypropCount++;
                }

                if (bodycorrelationId != null)
                {
                    body["CorrelationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                    bodypropCount++;
                }

                if (bodydocumentGroupCode != null)
                {
                    body["DocumentGroupCode"] = SourceExpressionConverter.ConvertToken(bodydocumentGroupCode);
                    bodypropCount++;
                }

                if (bodythemeCode != null)
                {
                    body["ThemeCode"] = SourceExpressionConverter.ConvertToken(bodythemeCode);
                    bodypropCount++;
                }

                if (bodydownloadUnsignedFiles != null)
                {
                    body["DownloadUnsignedFiles"] = SourceExpressionConverter.ConvertToken(bodydownloadUnsignedFiles);
                    bodypropCount++;
                }

                if (bodyreassignEnabled != null)
                {
                    body["ReassignEnabled"] = SourceExpressionConverter.ConvertToken(bodyreassignEnabled);
                    bodypropCount++;
                }

                if (bodyactionUrlExpirationPeriodInDays != null)
                {
                    body["ActionUrlExpirationPeriodInDays"] = SourceExpressionConverter.ConvertToken(bodyactionUrlExpirationPeriodInDays);
                    bodypropCount++;
                }

                if (bodyexpiryTimestamp != null)
                {
                    body["ExpiryTimestamp"] = SourceExpressionConverter.ConvertToken(bodyexpiryTimestamp);
                    bodypropCount++;
                }

                if (bodyexternalPackageReference != null)
                {
                    body["ExternalPackageReference"] = SourceExpressionConverter.ConvertToken(bodyexternalPackageReference);
                    bodypropCount++;
                }

                if (bodyexternalPackageData != null)
                {
                    body["ExternalPackageData"] = SourceExpressionConverter.ConvertToken(bodyexternalPackageData);
                    bodypropCount++;
                }

                if (bodyf2FRedirectUrl != null)
                {
                    body["F2FRedirectUrl"] = SourceExpressionConverter.ConvertToken(bodyf2FRedirectUrl);
                    bodypropCount++;
                }

                if (bodynotificationCallBackUrl != null)
                {
                    body["NotificationCallBackUrl"] = SourceExpressionConverter.ConvertToken(bodynotificationCallBackUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatePackageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<AddDocumentToPackageResponse> AddDocumentToPackage([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> bodydocument = null, [WorkflowExpression] Func<string> bodydocumentLanguage = null, [WorkflowExpression] Func<string> bodydocumentName = null, [WorkflowExpression] Func<SigningField[]> bodysigningFields = null, [WorkflowExpression] Func<string> bodycorrelationId = null, [WorkflowExpression] Func<string> bodydocumentType = null, [WorkflowExpression] Func<string> bodyexternalDocumentReference = null, [WorkflowExpression] Func<ErrorHandlingResponse[]> bodypdfErrorHandling = null, [WorkflowExpression] Func<string> bodyrepresentation = null, [WorkflowExpression] Func<string> bodyrepresentationType = null, [WorkflowExpression] Func<string> bodytargetType = null)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            SourceExpression.Validate(bodydocument, nameof(bodydocument), required: false);
            SourceExpression.Validate(bodydocumentLanguage, nameof(bodydocumentLanguage), required: false);
            SourceExpression.Validate(bodydocumentName, nameof(bodydocumentName), required: false);
            SourceExpression.Validate(bodysigningFields, nameof(bodysigningFields), required: false);
            SourceExpression.Validate(bodycorrelationId, nameof(bodycorrelationId), required: false);
            SourceExpression.Validate(bodydocumentType, nameof(bodydocumentType), required: false);
            SourceExpression.Validate(bodyexternalDocumentReference, nameof(bodyexternalDocumentReference), required: false);
            SourceExpression.Validate(bodypdfErrorHandling, nameof(bodypdfErrorHandling), required: false);
            SourceExpression.Validate(bodyrepresentation, nameof(bodyrepresentation), required: false);
            SourceExpression.Validate(bodyrepresentationType, nameof(bodyrepresentationType), required: false);
            SourceExpression.Validate(bodytargetType, nameof(bodytargetType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/documents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydocument != null)
                {
                    body["Document"] = SourceExpressionConverter.ConvertToken(bodydocument);
                    bodypropCount++;
                }

                if (bodydocumentLanguage != null)
                {
                    body["DocumentLanguage"] = SourceExpressionConverter.ConvertToken(bodydocumentLanguage);
                    bodypropCount++;
                }

                if (bodydocumentName != null)
                {
                    body["DocumentName"] = SourceExpressionConverter.ConvertToken(bodydocumentName);
                    bodypropCount++;
                }

                if (bodysigningFields != null)
                {
                    body["SigningFields"] = SourceExpressionConverter.ConvertToken(bodysigningFields);
                    bodypropCount++;
                }

                if (bodycorrelationId != null)
                {
                    body["CorrelationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationId);
                    bodypropCount++;
                }

                if (bodydocumentType != null)
                {
                    body["DocumentType"] = SourceExpressionConverter.ConvertToken(bodydocumentType);
                    bodypropCount++;
                }

                if (bodyexternalDocumentReference != null)
                {
                    body["ExternalDocumentReference"] = SourceExpressionConverter.ConvertToken(bodyexternalDocumentReference);
                    bodypropCount++;
                }

                if (bodypdfErrorHandling != null)
                {
                    body["PdfErrorHandling"] = SourceExpressionConverter.ConvertToken(bodypdfErrorHandling);
                    bodypropCount++;
                }

                if (bodyrepresentation != null)
                {
                    body["Representation"] = SourceExpressionConverter.ConvertToken(bodyrepresentation);
                    bodypropCount++;
                }

                if (bodyrepresentationType != null)
                {
                    body["RepresentationType"] = SourceExpressionConverter.ConvertToken(bodyrepresentationType);
                    bodypropCount++;
                }

                if (bodytargetType != null)
                {
                    body["TargetType"] = SourceExpressionConverter.ConvertToken(bodytargetType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddDocumentToPackageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<GetSigningLocationsResponse> GetSigningLocations([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/locations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSigningLocationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> GetPackageStatus([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PackageStatusInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<PackageStatusInfo> SetPackageStatus([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodystatus = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PackageStatusInfo>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SkipSigners([WorkflowExpression] Func<string> packageId)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/skipsigners", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadPackage([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<string> DownloadDocumentFromPackage([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/download/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ExpiryTimeStamp([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyexpiryTimestamp = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyexpiryTimestamp, nameof(bodyexpiryTimestamp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/expirytimestamp", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexpiryTimestamp != null)
                {
                    body["ExpiryTimestamp"] = SourceExpressionConverter.ConvertToken(bodyexpiryTimestamp);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SendPackageReminders([WorkflowExpression] Func<string> packageId)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/reminders", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction DeletePackage([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction SetProcessInformation([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodystakeholdersInputItem[]> bodystakeholders = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodystakeholders, nameof(bodystakeholders), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/process", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystakeholders != null)
                {
                    body["Stakeholders"] = SourceExpressionConverter.ConvertToken(bodystakeholders);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProof([WorkflowExpression] Func<string> packageId)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Content>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageAuditProofDoc([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/download/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Content>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> PackageCorrelationAuditProof([WorkflowExpression] Func<string> correlationId)
        {
            SourceExpression.Validate(correlationId, nameof(correlationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packagecorrelations/{0}/auditproof/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(correlationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Content>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IBodyWorkflowAction<Content> DocumentCorrelationAuditProof([WorkflowExpression] Func<string> correlationId)
        {
            SourceExpression.Validate(correlationId, nameof(correlationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/documentcorrelations/{0}/auditproof/download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(correlationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Content>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "connectiveesignatures")]
        public IWorkflowAction ProofExternalSource([WorkflowExpression] Func<string> packageId, [WorkflowExpression] Func<string> bodycontent = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyipAddress = null)
        {
            SourceExpression.Validate(packageId, nameof(packageId), required: true);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            SourceExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyipAddress, nameof(bodyipAddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/packages/{0}/auditproof/proofs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(packageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontent != null)
                {
                    body["Content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["LocationId"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["Type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyipAddress != null)
                {
                    body["IpAddress"] = SourceExpressionConverter.ConvertToken(bodyipAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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