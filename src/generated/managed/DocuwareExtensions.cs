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
        public IBodyWorkflowAction<StoreToFileCabinetResponse> StoreToFileCabinet(Expression<Func<string>> fileCabinet, Expression<Func<string>> storeDialogId, Expression<Func<string>> index = null, Expression<Func<object>> file = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StoreDialogId"] = ExpressionConverter.Convert(storeDialogId);
            return new ApiConnectionAction<StoreToFileCabinetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<ImportToDocumentTrayResponse> ImportToDocumentTray(Expression<Func<string>> documentTray, Expression<Func<string>> storeDialogId = null, Expression<Func<string>> index = null, Expression<Func<object>> file = null)
        {
            var apiCallPath = String.Format("/DocumentTrays/{0}/Documents", ExpressionConverter.ConvertWithUrlEncoding(documentTray, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (storeDialogId != null)
                callPayload.Queries["StoreDialogId"] = ExpressionConverter.Convert(storeDialogId);
            return new ApiConnectionAction<ImportToDocumentTrayResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<SearchForDocumentsInFileCabinetResponse> SearchForDocumentsInFileCabinet(Expression<Func<string>> fileCabinet, Expression<Func<string>> searchDialogId, Expression<Func<object>> searchQuery = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Search", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["SearchDialogId"] = ExpressionConverter.Convert(searchDialogId);
            callPayload.Body = ExpressionConverter.ConvertO(searchQuery);
            return new ApiConnectionAction<SearchForDocumentsInFileCabinetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetOrganizationResponse> GetOrganization()
        {
            var apiCallPath = "/Organization";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetOrganizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetFileCabinetsResponse> GetFileCabinets(Expression<Func<fileCabinetTypeInput>> fileCabinetType)
        {
            var apiCallPath = "/FileCabinets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FileCabinetType"] = ExpressionConverter.Convert(fileCabinetType);
            return new ApiConnectionAction<GetFileCabinetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDocumentInformationResponse> GetDocumentInformation(Expression<Func<string>> fileCabinetID, Expression<Func<int>> documentID)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(fileCabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(documentID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IWorkflowAction DeleteDocument(Expression<Func<string>> fileCabinetID, Expression<Func<int>> documentID)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(fileCabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(documentID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<string> DownloadFile(Expression<Func<string>> fileCabinetID, Expression<Func<int>> documentId, Expression<Func<string>> fileNumber, Expression<Func<documentFormatInput>> documentFormat)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}/Sections/{2}/Download", ExpressionConverter.ConvertWithUrlEncoding(fileCabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["DocumentFormat"] = ExpressionConverter.Convert(documentFormat);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip, deflate, br");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<string> DownloadDocument(Expression<Func<string>> fileCabinetID, Expression<Func<int>> documentId, Expression<Func<documentFormatInput>> documentFormat)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}/Download", ExpressionConverter.ConvertWithUrlEncoding(fileCabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["DocumentFormat"] = ExpressionConverter.Convert(documentFormat);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip, deflate, br");
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<UpdateIndexFieldsResponse> UpdateIndexFields(Expression<Func<string>> fileCabinetID, Expression<Func<int>> documentID, Expression<Func<documentFieldsInputItem[]>> documentFields = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}/Fields", ExpressionConverter.ConvertWithUrlEncoding(fileCabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(documentID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(documentFields);
            return new ApiConnectionAction<UpdateIndexFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<TransferDocumentResponse> TransferDocument(Expression<Func<string>> destinationFileCabinetID, Expression<Func<string>> transferInfosourceFileCabinetDocumentTray, Expression<Func<string>> storeDialogID = null, Expression<Func<transferInfodocsInputItem[]>> transferInfodocs = null, Expression<Func<bool>> transferInfokeepSource = null, Expression<Func<bool>> transferInfofillIntellix = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Task/Transfer", ExpressionConverter.ConvertWithUrlEncoding(destinationFileCabinetID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (storeDialogID != null)
                callPayload.Queries["StoreDialogID"] = ExpressionConverter.Convert(storeDialogID);
            var transferInfo = new JObject();
            var transferInfopropCount = 0;
            transferInfopropCount++;
            transferInfo["SourceFileCabinetId"] = ExpressionConverter.ConvertO(transferInfosourceFileCabinetDocumentTray);
            if (transferInfodocs != null)
            {
                transferInfo["Documents"] = ExpressionConverter.ConvertO(transferInfodocs);
                transferInfopropCount++;
            }

            if (transferInfokeepSource != null)
            {
                transferInfo["KeepSource"] = ExpressionConverter.ConvertO(transferInfokeepSource);
                transferInfopropCount++;
            }

            if (transferInfofillIntellix != null)
            {
                transferInfo["FillIntellix"] = ExpressionConverter.ConvertO(transferInfofillIntellix);
                transferInfopropCount++;
            }

            if (transferInfopropCount > 0)
            {
                callPayload.Body = transferInfo;
            }

            return new ApiConnectionAction<TransferDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<PlaceAStampResponse> PlaceAStamp(Expression<Func<string>> fileCabinetID, Expression<Func<int>> documentID, Expression<Func<int>> stampDatafileNumber, Expression<Func<int>> stampDatapageNumber, Expression<Func<int>> stampDatalayer, Expression<Func<string>> stampDatastamp, Expression<Func<double>> stampDatahorizontalPositionXPosition = null, Expression<Func<double>> stampDataverticalPositionYPosition = null, Expression<Func<string>> stampDatapassword = null, Expression<Func<stampDatafieldInputItem[]>> stampDatafield = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}/Annotation", ExpressionConverter.ConvertWithUrlEncoding(fileCabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(documentID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var stampData = new JObject();
            var stampDatapropCount = 0;
            stampDatapropCount++;
            stampData["FileNumber"] = ExpressionConverter.ConvertO(stampDatafileNumber);
            stampDatapropCount++;
            stampData["PageNumber"] = ExpressionConverter.ConvertO(stampDatapageNumber);
            stampDatapropCount++;
            stampData["Layer"] = ExpressionConverter.ConvertO(stampDatalayer);
            if (stampDatahorizontalPositionXPosition != null)
            {
                stampData["PositionX"] = ExpressionConverter.ConvertO(stampDatahorizontalPositionXPosition);
                stampDatapropCount++;
            }

            if (stampDataverticalPositionYPosition != null)
            {
                stampData["PositionY"] = ExpressionConverter.ConvertO(stampDataverticalPositionYPosition);
                stampDatapropCount++;
            }

            stampDatapropCount++;
            stampData["StampId"] = ExpressionConverter.ConvertO(stampDatastamp);
            if (stampDatapassword != null)
            {
                stampData["Password"] = ExpressionConverter.ConvertO(stampDatapassword);
                stampDatapropCount++;
            }

            if (stampDatafield != null)
            {
                stampData["Fields"] = ExpressionConverter.ConvertO(stampDatafield);
                stampDatapropCount++;
            }

            if (stampDatapropCount > 0)
            {
                callPayload.Body = stampData;
            }

            return new ApiConnectionAction<PlaceAStampResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogsResponse> GetDialogs(Expression<Func<string>> fileCabinet, Expression<Func<dialogTypeInput>> dialogType = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Dialogs", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["DialogType"] = Convert.ToString("All");
            if (dialogType != null)
                callPayload.Queries["DialogType"] = ExpressionConverter.Convert(dialogType);
            return new ApiConnectionAction<GetDialogsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<AppendFileResponse> AppendFile(Expression<Func<string>> fileCabinet, Expression<Func<string>> docID, Expression<Func<object>> file = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Sections", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["DocID"] = ExpressionConverter.Convert(docID);
            return new ApiConnectionAction<AppendFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> fileCabinet, Expression<Func<int>> documentID, Expression<Func<int>> fileNumber)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}/Sections/{2}/Data", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1), ExpressionConverter.ConvertWithUrlEncoding(documentID, 1), ExpressionConverter.ConvertWithUrlEncoding(fileNumber, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<ReplaceFileResponse> ReplaceFile(Expression<Func<string>> fileCabinet, Expression<Func<int>> documentID, Expression<Func<int>> fileNumber, Expression<Func<object>> file = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Documents/{1}/Sections/{2}/Data", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1), ExpressionConverter.ConvertWithUrlEncoding(documentID, 1), ExpressionConverter.ConvertWithUrlEncoding(fileNumber, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReplaceFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetStampsResponse> GetStamps(Expression<Func<string>> fileCabinet)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Stamps", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStampsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetStampFieldsResponse> GetStampFields(Expression<Func<string>> fileCabinet, Expression<Func<string>> stamp)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Stamps/{1}/Fields", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1), ExpressionConverter.ConvertWithUrlEncoding(stamp, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStampFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetFileCabinetFieldsResponse> GetFileCabinetFields(Expression<Func<string>> fileCabinet, Expression<Func<fieldTypeInput>> fieldType = null)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Fields", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fieldType != null)
                callPayload.Queries["FieldType"] = ExpressionConverter.Convert(fieldType);
            return new ApiConnectionAction<GetFileCabinetFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogFieldsResponse> GetDialogFields(Expression<Func<string>> fileCabinet, Expression<Func<string>> dialogId)
        {
            var apiCallPath = String.Format("/FileCabinets/{0}/Dialogs/{1}/Fields", ExpressionConverter.ConvertWithUrlEncoding(fileCabinet, 1), ExpressionConverter.ConvertWithUrlEncoding(dialogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDialogFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<ListDocumentsInDocumentTrayResponse> ListDocumentsInDocumentTray(Expression<Func<string>> documentTray)
        {
            var apiCallPath = String.Format("/DocumentTrays/{0}/Search", ExpressionConverter.ConvertWithUrlEncoding(documentTray, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListDocumentsInDocumentTrayResponse>(callPayload);
        }
    }

    public class DocuwareTriggers([ConnectionName] string connectionId)
    {
    }

    public class StoreToFileCabinetResponse
    {
        public StoreToFileCabinetResponseSectionsTypeItem[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public StoreToFileCabinetResponseDocumentFlagsType DocumentFlags { get; set; }
    }

    public class StoreToFileCabinetResponseSectionsTypeItem
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

    public class StoreToFileCabinetResponseDocumentFlagsType
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

    public class ImportToDocumentTrayResponse
    {
        public ImportToDocumentTrayResponseSectionsTypeItem[] Sections { get; set; }
        public int DocumentId { get; set; }
        public JToken IndexFields { get; set; }
        public string DocumentTitle { get; set; }
        public string FileCabinetId { get; set; }
        public int TotalPages { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public string VersionStatus { get; set; }
        public ImportToDocumentTrayResponseDocumentFlagsType DocumentFlags { get; set; }
    }

    public class ImportToDocumentTrayResponseSectionsTypeItem
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

    public class ImportToDocumentTrayResponseDocumentFlagsType
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

    public class AppendFileResponse
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

    public class ReplaceFileResponse
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