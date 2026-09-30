//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docuware
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocuwareActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<SearchForDocumentsInFileCabinetResponse> SearchForDocumentsInFileCabinet([WorkflowExpression] Func<string> fileCabinet, [WorkflowExpression] Func<string> searchDialogId, [WorkflowExpression] Func<object> searchQuery = null)
        {
            SourceExpression.Validate(fileCabinet, nameof(fileCabinet), required: true);
            SourceExpression.Validate(searchDialogId, nameof(searchDialogId), required: true);
            SourceExpression.Validate(searchQuery, nameof(searchQuery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinet, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SearchDialogId"] = SourceExpressionConverter.ConvertO(searchDialogId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(searchQuery);
                return callPayload;
            }

            return new ApiConnectionAction<SearchForDocumentsInFileCabinetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetOrganizationResponse> GetOrganization()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Organization";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetOrganizationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetFileCabinetsResponse> GetFileCabinets([WorkflowExpression] Func<fileCabinetTypeInput> fileCabinetType)
        {
            SourceExpression.Validate(fileCabinetType, nameof(fileCabinetType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/FileCabinets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileCabinetType"] = SourceExpressionConverter.Convert(fileCabinetType);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileCabinetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDocumentInformationResponse> GetDocumentInformation([WorkflowExpression] Func<string> fileCabinetId, [WorkflowExpression] Func<int> documentId)
        {
            SourceExpression.Validate(fileCabinetId, nameof(fileCabinetId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Documents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> fileCabinetId, [WorkflowExpression] Func<int> documentId)
        {
            SourceExpression.Validate(fileCabinetId, nameof(fileCabinetId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Documents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<string> DownloadFile([WorkflowExpression] Func<string> fileCabinetId, [WorkflowExpression] Func<int> documentId, [WorkflowExpression] Func<string> fileNumber, [WorkflowExpression] Func<documentFormatInput> documentFormat)
        {
            SourceExpression.Validate(fileCabinetId, nameof(fileCabinetId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(fileNumber, nameof(fileNumber), required: true);
            SourceExpression.Validate(documentFormat, nameof(documentFormat), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Documents/{1}/Sections/{2}/Download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentFormat"] = SourceExpressionConverter.Convert(documentFormat);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip, deflate, br");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> fileCabinetId, [WorkflowExpression] Func<int> documentId, [WorkflowExpression] Func<documentFormatInput> documentFormat)
        {
            SourceExpression.Validate(fileCabinetId, nameof(fileCabinetId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(documentFormat, nameof(documentFormat), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Documents/{1}/Download", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentFormat"] = SourceExpressionConverter.Convert(documentFormat);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip, deflate, br");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<UpdateIndexFieldsResponse> UpdateIndexFields([WorkflowExpression] Func<string> fileCabinetId, [WorkflowExpression] Func<int> documentId, [WorkflowExpression] Func<documentFieldsInputItem[]> documentFields = null)
        {
            SourceExpression.Validate(fileCabinetId, nameof(fileCabinetId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(documentFields, nameof(documentFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Documents/{1}/Fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(documentFields);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateIndexFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<TransferDocumentResponse> TransferDocument([WorkflowExpression] Func<string> destinationFileCabinetId, [WorkflowExpression] Func<string> transferInfosourceFileCabinetDocumentTray, [WorkflowExpression] Func<string> storeDialogId = null, [WorkflowExpression] Func<transferInfodocsInputItem[]> transferInfodocs = null, [WorkflowExpression] Func<bool> transferInfokeepSource = null, [WorkflowExpression] Func<bool> transferInfofillIntellix = null)
        {
            SourceExpression.Validate(destinationFileCabinetId, nameof(destinationFileCabinetId), required: true);
            SourceExpression.Validate(transferInfosourceFileCabinetDocumentTray, nameof(transferInfosourceFileCabinetDocumentTray), required: true);
            SourceExpression.Validate(storeDialogId, nameof(storeDialogId), required: false);
            SourceExpression.Validate(transferInfodocs, nameof(transferInfodocs), required: false);
            SourceExpression.Validate(transferInfokeepSource, nameof(transferInfokeepSource), required: false);
            SourceExpression.Validate(transferInfofillIntellix, nameof(transferInfofillIntellix), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Task/Transfer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(destinationFileCabinetId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (storeDialogId != null)
                    callPayload.Queries["StoreDialogID"] = SourceExpressionConverter.ConvertO(storeDialogId);
                var transferInfo = new JObject();
                var transferInfopropCount = 0;
                transferInfopropCount++;
                transferInfo["SourceFileCabinetId"] = SourceExpressionConverter.ConvertToken(transferInfosourceFileCabinetDocumentTray);
                if (transferInfodocs != null)
                {
                    transferInfo["Documents"] = SourceExpressionConverter.ConvertToken(transferInfodocs);
                    transferInfopropCount++;
                }

                if (transferInfokeepSource != null)
                {
                    transferInfo["KeepSource"] = SourceExpressionConverter.ConvertToken(transferInfokeepSource);
                    transferInfopropCount++;
                }

                if (transferInfofillIntellix != null)
                {
                    transferInfo["FillIntellix"] = SourceExpressionConverter.ConvertToken(transferInfofillIntellix);
                    transferInfopropCount++;
                }

                if (transferInfopropCount > 0)
                {
                    callPayload.Body = transferInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TransferDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<PlaceAStampResponse> PlaceAStamp([WorkflowExpression] Func<string> fileCabinetId, [WorkflowExpression] Func<int> documentId, [WorkflowExpression] Func<int> stampDatafileNumber, [WorkflowExpression] Func<int> stampDatapageNumber, [WorkflowExpression] Func<int> stampDatalayer, [WorkflowExpression] Func<string> stampDatastamp, [WorkflowExpression] Func<double> stampDatahorizontalPositionXPosition = null, [WorkflowExpression] Func<double> stampDataverticalPositionYPosition = null, [WorkflowExpression] Func<string> stampDatapassword = null, [WorkflowExpression] Func<stampDatafieldInputItem[]> stampDatafield = null)
        {
            SourceExpression.Validate(fileCabinetId, nameof(fileCabinetId), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(stampDatafileNumber, nameof(stampDatafileNumber), required: true);
            SourceExpression.Validate(stampDatapageNumber, nameof(stampDatapageNumber), required: true);
            SourceExpression.Validate(stampDatalayer, nameof(stampDatalayer), required: true);
            SourceExpression.Validate(stampDatastamp, nameof(stampDatastamp), required: true);
            SourceExpression.Validate(stampDatahorizontalPositionXPosition, nameof(stampDatahorizontalPositionXPosition), required: false);
            SourceExpression.Validate(stampDataverticalPositionYPosition, nameof(stampDataverticalPositionYPosition), required: false);
            SourceExpression.Validate(stampDatapassword, nameof(stampDatapassword), required: false);
            SourceExpression.Validate(stampDatafield, nameof(stampDatafield), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Documents/{1}/Annotation", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var stampData = new JObject();
                var stampDatapropCount = 0;
                stampDatapropCount++;
                stampData["FileNumber"] = SourceExpressionConverter.ConvertToken(stampDatafileNumber);
                stampDatapropCount++;
                stampData["PageNumber"] = SourceExpressionConverter.ConvertToken(stampDatapageNumber);
                stampDatapropCount++;
                stampData["Layer"] = SourceExpressionConverter.ConvertToken(stampDatalayer);
                if (stampDatahorizontalPositionXPosition != null)
                {
                    stampData["PositionX"] = SourceExpressionConverter.ConvertToken(stampDatahorizontalPositionXPosition);
                    stampDatapropCount++;
                }

                if (stampDataverticalPositionYPosition != null)
                {
                    stampData["PositionY"] = SourceExpressionConverter.ConvertToken(stampDataverticalPositionYPosition);
                    stampDatapropCount++;
                }

                stampDatapropCount++;
                stampData["StampId"] = SourceExpressionConverter.ConvertToken(stampDatastamp);
                if (stampDatapassword != null)
                {
                    stampData["Password"] = SourceExpressionConverter.ConvertToken(stampDatapassword);
                    stampDatapropCount++;
                }

                if (stampDatafield != null)
                {
                    stampData["Fields"] = SourceExpressionConverter.ConvertToken(stampDatafield);
                    stampDatapropCount++;
                }

                if (stampDatapropCount > 0)
                {
                    callPayload.Body = stampData;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PlaceAStampResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogsResponse> GetDialogs([WorkflowExpression] Func<string> fileCabinet, [WorkflowExpression] Func<dialogTypeInput> dialogType = null)
        {
            SourceExpression.Validate(fileCabinet, nameof(fileCabinet), required: true);
            SourceExpression.Validate(dialogType, nameof(dialogType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Dialogs", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DialogType"] = Convert.ToString("All");
                if (dialogType != null)
                    callPayload.Queries["DialogType"] = SourceExpressionConverter.Convert(dialogType);
                return callPayload;
            }

            return new ApiConnectionAction<GetDialogsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetStampsResponse> GetStamps([WorkflowExpression] Func<string> fileCabinet)
        {
            SourceExpression.Validate(fileCabinet, nameof(fileCabinet), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Stamps", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetStampsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetStampFieldsResponse> GetStampFields([WorkflowExpression] Func<string> fileCabinet, [WorkflowExpression] Func<string> stamp)
        {
            SourceExpression.Validate(fileCabinet, nameof(fileCabinet), required: true);
            SourceExpression.Validate(stamp, nameof(stamp), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Stamps/{1}/Fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinet, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stamp, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetStampFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetFileCabinetFieldsResponse> GetFileCabinetFields([WorkflowExpression] Func<string> fileCabinet, [WorkflowExpression] Func<fieldTypeInput> fieldType = null)
        {
            SourceExpression.Validate(fileCabinet, nameof(fileCabinet), required: true);
            SourceExpression.Validate(fieldType, nameof(fieldType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinet, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fieldType != null)
                    callPayload.Queries["FieldType"] = SourceExpressionConverter.Convert(fieldType);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileCabinetFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogFieldsResponse> GetDialogFields([WorkflowExpression] Func<string> fileCabinet, [WorkflowExpression] Func<string> dialogId)
        {
            SourceExpression.Validate(fileCabinet, nameof(fileCabinet), required: true);
            SourceExpression.Validate(dialogId, nameof(dialogId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/FileCabinets/{0}/Dialogs/{1}/Fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileCabinet, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dialogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDialogFieldsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<ListDocumentsInDocumentTrayResponse> ListDocumentsInDocumentTray([WorkflowExpression] Func<string> documentTray)
        {
            SourceExpression.Validate(documentTray, nameof(documentTray), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/DocumentTrays/{0}/Search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentTray, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDocumentsInDocumentTrayResponse>(BuildSourceInput);
        }
    }

    public class DocuwareTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchForDocumentsInFileCabinetResponse
    {
        public int Count { get; set; }
        public SearchForDocumentsInFileCabinetResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class SearchForDocumentsInFileCabinetResponseDocumentsTypeItem
    {
        public JToken[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public SearchForDocumentsInFileCabinetResponseDocumentsTypeItemDocumentFlagsType DocumentFlags { get; set; }
    }

    public class SearchForDocumentsInFileCabinetResponseDocumentsTypeItemDocumentFlagsType
    {
        [JsonProperty("isCold")]
        public bool IsCold { get; set; }

        [JsonProperty("isDBRecord")]
        public bool IsDBRecord { get; set; }

        [JsonProperty("isCheckedOut")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("isCopyRightProtected")]
        public bool IsCopyRightProtected { get; set; }

        [JsonProperty("isVoiceAvailable")]
        public bool IsVoiceAvailable { get; set; }

        [JsonProperty("hasAppendedDocuments")]
        public bool HasAppendedDocuments { get; set; }

        [JsonProperty("isProtected")]
        public bool IsProtected { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isEmail")]
        public bool IsEmail { get; set; }
    }

    public class GetOrganizationResponse
    {
        public string Name { get; set; }
    }

    public class GetFileCabinetsResponse
    {
        public GetFileCabinetsResponseFileCabinetsTypeItem[] FileCabinets { get; set; }
    }

    public class GetFileCabinetsResponseFileCabinetsTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string Color { get; set; }
        public bool IsTray { get; set; }
    }

    public enum fileCabinetTypeInput
    {
        All,
        FileCabinet,
        DocumentTray
    }

    public class GetDocumentInformationResponse
    {
        public GetDocumentInformationResponseSectionsTypeItem[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public GetDocumentInformationResponseDocumentFlagsType DocumentFlags { get; set; }
    }

    public class GetDocumentInformationResponseSectionsTypeItem
    {
        public string[] SignatureStatus { get; set; }
        public string SectionId { get; set; }
        public string ContentType { get; set; }
        public bool HaveMorePages { get; set; }
        public int PageCount { get; set; }
        public int FileSize { get; set; }
        public string OriginalFileName { get; set; }
        public string ContentModified { get; set; }
        public bool HasTextAnnotation { get; set; }
        public bool AnnotationsPreview { get; set; }
    }

    public class GetDocumentInformationResponseDocumentFlagsType
    {
        [JsonProperty("isCold")]
        public bool IsCold { get; set; }

        [JsonProperty("isDBRecord")]
        public bool IsDBRecord { get; set; }

        [JsonProperty("isCheckedOut")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("isCopyRightProtected")]
        public bool IsCopyRightProtected { get; set; }

        [JsonProperty("isVoiceAvailable")]
        public bool IsVoiceAvailable { get; set; }

        [JsonProperty("hasAppendedDocuments")]
        public bool HasAppendedDocuments { get; set; }

        [JsonProperty("isProtected")]
        public bool IsProtected { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isEmail")]
        public bool IsEmail { get; set; }
    }

    public enum documentFormatInput
    {
        Original,
        [EnumMember(Value = "PDF with annotations")]
        PDFWithAnnotations,
        [EnumMember(Value = "PDF without annotations")]
        PDFWithoutAnnotations
    }

    public class UpdateIndexFieldsResponse
    {
        public UpdateIndexFieldsResponseSectionsTypeItem[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public UpdateIndexFieldsResponseDocumentFlagsType DocumentFlags { get; set; }
    }

    public class UpdateIndexFieldsResponseSectionsTypeItem
    {
        public string[] SignatureStatus { get; set; }
        public string SectionId { get; set; }
        public string ContentType { get; set; }
        public bool HaveMorePages { get; set; }
        public int PageCount { get; set; }
        public int FileSize { get; set; }
        public string OriginalFileName { get; set; }
        public string ContentModified { get; set; }
        public bool HasTextAnnotation { get; set; }
        public bool AnnotationsPreview { get; set; }
    }

    public class UpdateIndexFieldsResponseDocumentFlagsType
    {
        [JsonProperty("isCold")]
        public bool IsCold { get; set; }

        [JsonProperty("isDBRecord")]
        public bool IsDBRecord { get; set; }

        [JsonProperty("isCheckedOut")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("isCopyRightProtected")]
        public bool IsCopyRightProtected { get; set; }

        [JsonProperty("isVoiceAvailable")]
        public bool IsVoiceAvailable { get; set; }

        [JsonProperty("hasAppendedDocuments")]
        public bool HasAppendedDocuments { get; set; }

        [JsonProperty("isProtected")]
        public bool IsProtected { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isEmail")]
        public bool IsEmail { get; set; }
    }

    public class documentFieldsInputItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class TransferDocumentResponse
    {
        public int Count { get; set; }
        public TransferDocumentResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class TransferDocumentResponseDocumentsTypeItem
    {
        public TransferDocumentResponseDocumentsTypeItemSectionsTypeItem[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public TransferDocumentResponseDocumentsTypeItemDocumentFlagsType DocumentFlags { get; set; }
    }

    public class TransferDocumentResponseDocumentsTypeItemSectionsTypeItem
    {
        public string[] SignatureStatus { get; set; }
        public string SectionId { get; set; }
        public string ContentType { get; set; }
        public bool HaveMorePages { get; set; }
        public int PageCount { get; set; }
        public int FileSize { get; set; }
        public string OriginalFileName { get; set; }
        public string ContentModified { get; set; }
        public bool HasTextAnnotation { get; set; }
        public bool AnnotationsPreview { get; set; }
    }

    public class TransferDocumentResponseDocumentsTypeItemDocumentFlagsType
    {
        [JsonProperty("isCold")]
        public bool IsCold { get; set; }

        [JsonProperty("isDBRecord")]
        public bool IsDBRecord { get; set; }

        [JsonProperty("isCheckedOut")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("isCopyRightProtected")]
        public bool IsCopyRightProtected { get; set; }

        [JsonProperty("isVoiceAvailable")]
        public bool IsVoiceAvailable { get; set; }

        [JsonProperty("hasAppendedDocuments")]
        public bool HasAppendedDocuments { get; set; }

        [JsonProperty("isProtected")]
        public bool IsProtected { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isEmail")]
        public bool IsEmail { get; set; }
    }

    public class transferInfodocsInputItem
    {
        [JsonProperty("DocumentId")]
        public int ID { get; set; }

        [JsonProperty("IndexFields")]
        public transferInfodocsInputItemFieldTypeItem[] Field { get; set; }
    }

    public class transferInfodocsInputItemFieldTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class PlaceAStampResponse
    {
        public PlaceAStampResponseCreatedType Created { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Rotation { get; set; }
        public bool Transparent { get; set; }
        public int StrokeWidth { get; set; }

        [JsonProperty("Guid")]
        public string Id { get; set; }
    }

    public class PlaceAStampResponseCreatedType
    {
        public string User { get; set; }
        public string Time { get; set; }
    }

    public class stampDatafieldInputItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetDialogsResponse
    {
        public GetDialogsResponseDialogsTypeItem[] Dialogs { get; set; }
    }

    public class GetDialogsResponseDialogsTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string Color { get; set; }
        public bool IsDefault { get; set; }
        public string Type { get; set; }
        public string FileCabinetId { get; set; }
    }

    public enum dialogTypeInput
    {
        All,
        Search,
        Store,
        Result,
        Index,
        List,
        Folders
    }

    public class GetStampsResponse
    {
        public GetStampsResponseStampsTypeItem[] Stamps { get; set; }
    }

    public class GetStampsResponseStampsTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Color { get; set; }
        public string Signature { get; set; }
        public bool PasswordProtected { get; set; }
        public bool Overwrite { get; set; }
        public string Type { get; set; }
        public string FileCabinetId { get; set; }
    }

    public class GetStampFieldsResponse
    {
        public GetStampFieldsResponseFieldsTypeItem[] Fields { get; set; }
    }

    public class GetStampFieldsResponseFieldsTypeItem
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string DisplayName { get; set; }
    }

    public class GetFileCabinetFieldsResponse
    {
        public GetFileCabinetFieldsResponseFieldsTypeItem[] Fields { get; set; }
    }

    public class GetFileCabinetFieldsResponseFieldsTypeItem
    {
        public GetFileCabinetFieldsResponseFieldsTypeItemTableFieldColumnsTypeItem[] TableFieldColumns { get; set; }
        public bool UsedAsDocumentName { get; set; }
        public string DBFieldName { get; set; }
        public string DWFieldType { get; set; }
        public string DisplayName { get; set; }
        public bool DropLeadingBlanks { get; set; }
        public bool DropLeadingZero { get; set; }
        public string FieldInfoText { get; set; }
        public string FixedEntry { get; set; }
        public int Length { get; set; }
        public bool NotEmpty { get; set; }
        public int Precision { get; set; }
        public string Scope { get; set; }
    }

    public class GetFileCabinetFieldsResponseFieldsTypeItemTableFieldColumnsTypeItem
    {
        public string DBFieldName { get; set; }
        public string DWFieldType { get; set; }
        public string DisplayName { get; set; }
        public bool DropLeadingBlanks { get; set; }
        public bool DropLeadingZero { get; set; }
        public string FieldInfoText { get; set; }
        public string FixedEntry { get; set; }
        public int Length { get; set; }
        public bool NotEmpty { get; set; }
        public int Precision { get; set; }
        public string Scope { get; set; }
    }

    public enum fieldTypeInput
    {
        User,
        System
    }

    public class GetDialogFieldsResponse
    {
        public GetDialogFieldsResponseFieldsTypeItem[] Fields { get; set; }
    }

    public class GetDialogFieldsResponseFieldsTypeItem
    {
        public string DBFieldName { get; set; }
        public string DWFieldType { get; set; }
        public string DisplayName { get; set; }
        public bool ReadOnly { get; set; }
        public bool Visible { get; set; }
    }

    public class ListDocumentsInDocumentTrayResponse
    {
        public int Count { get; set; }
        public ListDocumentsInDocumentTrayResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class ListDocumentsInDocumentTrayResponseDocumentsTypeItem
    {
        public JToken[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public ListDocumentsInDocumentTrayResponseDocumentsTypeItemDocumentFlagsType DocumentFlags { get; set; }
    }

    public class ListDocumentsInDocumentTrayResponseDocumentsTypeItemDocumentFlagsType
    {
        [JsonProperty("isCold")]
        public bool IsCold { get; set; }

        [JsonProperty("isDBRecord")]
        public bool IsDBRecord { get; set; }

        [JsonProperty("isCheckedOut")]
        public bool IsCheckedOut { get; set; }

        [JsonProperty("isCopyRightProtected")]
        public bool IsCopyRightProtected { get; set; }

        [JsonProperty("isVoiceAvailable")]
        public bool IsVoiceAvailable { get; set; }

        [JsonProperty("hasAppendedDocuments")]
        public bool HasAppendedDocuments { get; set; }

        [JsonProperty("isProtected")]
        public bool IsProtected { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("isEmail")]
        public bool IsEmail { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docuware;

    public partial class WorkflowManagedActions
    {
        public DocuwareActions Docuware(string connectionId) => new DocuwareActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DocuwareTriggers Docuware(string connectionId) => new DocuwareTriggers(connectionId);
    }
}