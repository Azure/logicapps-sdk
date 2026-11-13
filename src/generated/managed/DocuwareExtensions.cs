//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docuware
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocuwareActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<SearchForDocumentsInFileCabinetResponse, ApiConnectionActionConfiguration> SearchForDocumentsInFileCabinet(Expression<Func<string>> fileCabinet, Expression<Func<string>> searchDialogId, Expression<Func<object>> searchQuery)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            var __workflow_searchDialogId = WorkflowExpression.Compile(searchDialogId, nameof(searchDialogId), required: true);
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: true);
            return new DeferredBodyAction<SearchForDocumentsInFileCabinetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Search", __workflow_fileCabinet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["SearchDialogId"] = ExpressionConverter.Convert(__workflow_searchDialogId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_searchQuery);
                return new ApiConnectionAction<SearchForDocumentsInFileCabinetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetOrganizationResponse, ApiConnectionActionConfiguration> GetOrganization()
        {
            return new DeferredBodyAction<GetOrganizationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Organization";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOrganizationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetFileCabinetsResponse, ApiConnectionActionConfiguration> GetFileCabinets(Expression<Func<FileCabinetTypeInput>> fileCabinetType)
        {
            var __workflow_fileCabinetType = WorkflowExpression.Compile(fileCabinetType, nameof(fileCabinetType), required: true);
            return new DeferredBodyAction<GetFileCabinetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileCabinets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FileCabinetType"] = ExpressionConverter.Convert(__workflow_fileCabinetType);
                return new ApiConnectionAction<GetFileCabinetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDocumentInformationResponse, ApiConnectionActionConfiguration> GetDocumentInformation(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredBodyAction<GetDocumentInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadFile(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<string>> fileNumber, Expression<Func<DocumentFormatInput>> documentFormat)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_fileNumber = WorkflowExpression.Compile(fileNumber, nameof(fileNumber), required: true);
            var __workflow_documentFormat = WorkflowExpression.Compile(documentFormat, nameof(documentFormat), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}/Sections/{2}/Download", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_fileNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentFormat"] = ExpressionConverter.Convert(__workflow_documentFormat);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip, deflate, br");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<DocumentFormatInput>> documentFormat)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_documentFormat = WorkflowExpression.Compile(documentFormat, nameof(documentFormat), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}/Download", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DocumentFormat"] = ExpressionConverter.Convert(__workflow_documentFormat);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("gzip, deflate, br");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<UpdateIndexFieldsResponse, ApiConnectionActionConfiguration> UpdateIndexFields(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<DocumentFieldsInputItem[]>> documentFields)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_documentFields = WorkflowExpression.Compile(documentFields, nameof(documentFields), required: true);
            return new DeferredBodyAction<UpdateIndexFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}/Fields", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documentFields);
                return new ApiConnectionAction<UpdateIndexFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<TransferDocumentResponse, ApiConnectionActionConfiguration> TransferDocument(Expression<Func<string>> destinationFileCabinetId, Expression<Func<TransferInfoInput>> transferInfo, Expression<Func<string>> storeDialogId = null)
        {
            var __workflow_destinationFileCabinetId = WorkflowExpression.Compile(destinationFileCabinetId, nameof(destinationFileCabinetId), required: true);
            var __workflow_transferInfo = WorkflowExpression.Compile(transferInfo, nameof(transferInfo), required: true);
            var __workflow_storeDialogId = WorkflowExpression.Compile(storeDialogId, nameof(storeDialogId), required: false);
            return new DeferredBodyAction<TransferDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Task/Transfer", __workflow_destinationFileCabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_storeDialogId != null)
                    callPayload.Queries["StoreDialogID"] = ExpressionConverter.Convert(__workflow_storeDialogId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_transferInfo);
                return new ApiConnectionAction<TransferDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<PlaceAStampResponse, ApiConnectionActionConfiguration> PlaceAStamp(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<StampDataInput>> stampData)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_stampData = WorkflowExpression.Compile(stampData, nameof(stampData), required: true);
            return new DeferredBodyAction<PlaceAStampResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}/Annotation", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_stampData);
                return new ApiConnectionAction<PlaceAStampResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogsResponse, ApiConnectionActionConfiguration> GetDialogs(Expression<Func<string>> fileCabinet, Expression<Func<DialogTypeInput>> dialogType = null)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            var __workflow_dialogType = WorkflowExpression.Compile(dialogType, nameof(dialogType), required: false);
            return new DeferredBodyAction<GetDialogsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Dialogs", __workflow_fileCabinet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["DialogType"] = Convert.ToString("All");
                if (__workflow_dialogType != null)
                    callPayload.Queries["DialogType"] = ExpressionConverter.Convert(__workflow_dialogType);
                return new ApiConnectionAction<GetDialogsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetStampsResponse, ApiConnectionActionConfiguration> GetStamps(Expression<Func<string>> fileCabinet)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            return new DeferredBodyAction<GetStampsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Stamps", __workflow_fileCabinet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStampsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetStampFieldsResponse, ApiConnectionActionConfiguration> GetStampFields(Expression<Func<string>> fileCabinet, Expression<Func<string>> stamp)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            var __workflow_stamp = WorkflowExpression.Compile(stamp, nameof(stamp), required: true);
            return new DeferredBodyAction<GetStampFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Stamps/{1}/Fields", __workflow_fileCabinet.WithUrlEncoding(1), __workflow_stamp.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStampFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetFileCabinetFieldsResponse, ApiConnectionActionConfiguration> GetFileCabinetFields(Expression<Func<string>> fileCabinet, Expression<Func<FieldTypeInput>> fieldType = null)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            var __workflow_fieldType = WorkflowExpression.Compile(fieldType, nameof(fieldType), required: false);
            return new DeferredBodyAction<GetFileCabinetFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Fields", __workflow_fileCabinet.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_fieldType != null)
                    callPayload.Queries["FieldType"] = ExpressionConverter.Convert(__workflow_fieldType);
                return new ApiConnectionAction<GetFileCabinetFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogFieldsResponse, ApiConnectionActionConfiguration> GetDialogFields(Expression<Func<string>> fileCabinet, Expression<Func<string>> dialogId)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            var __workflow_dialogId = WorkflowExpression.Compile(dialogId, nameof(dialogId), required: true);
            return new DeferredBodyAction<GetDialogFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Dialogs/{1}/Fields", __workflow_fileCabinet.WithUrlEncoding(1), __workflow_dialogId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDialogFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<ListDocumentsInDocumentTrayResponse, ApiConnectionActionConfiguration> ListDocumentsInDocumentTray(Expression<Func<string>> documentTray)
        {
            var __workflow_documentTray = WorkflowExpression.Compile(documentTray, nameof(documentTray), required: true);
            return new DeferredBodyAction<ListDocumentsInDocumentTrayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DocumentTrays/{0}/Search", __workflow_documentTray.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListDocumentsInDocumentTrayResponse>(callPayload);
            });
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
        public string Guid { get; set; }
        public string Color { get; set; }
        public bool IsTray { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileCabinetTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentFormatInput
    {
        Original,
        [EnumMember(Value = "PDF with annotations")]
        PdfWithAnnotations,
        [EnumMember(Value = "PDF without annotations")]
        PdfWithoutAnnotations
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

    public class DocumentFieldsInputItem
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

    public class TransferInfoInput
    {
        public TransferInfoInput(string sourceFileCabinetDocumentTray)
        {
            this.SourceFileCabinetDocumentTray = sourceFileCabinetDocumentTray;
        }

        [JsonProperty("SourceFileCabinetId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileCabinetDocumentTray { get; set; }

        [JsonProperty("Documents")]
        public TransferInfoInputDocsTypeItem[] Docs { get; set; }
        public bool? KeepSource { get; set; }
        public bool? FillIntellix { get; set; }
    }

    public class TransferInfoInputDocsTypeItem
    {
        [JsonProperty("DocumentId")]
        public int? Id { get; set; }

        [JsonProperty("IndexFields")]
        public TransferInfoInputDocsTypeItemFieldTypeItem[] Field { get; set; }
    }

    public class TransferInfoInputDocsTypeItemFieldTypeItem
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
        public string Guid { get; set; }
    }

    public class PlaceAStampResponseCreatedType
    {
        public string User { get; set; }
        public string Time { get; set; }
    }

    public class StampDataInput
    {
        public StampDataInput(int fileNumber, int pageNumber, string stamp)
        {
            this.FileNumber = fileNumber;
            this.PageNumber = pageNumber;
            this.Stamp = stamp;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int FileNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Layer { get; set; } = 1;

        [JsonProperty("PositionX")]
        public double? HorizontalPositionXPosition { get; set; }

        [JsonProperty("PositionY")]
        public double? VerticalPositionYPosition { get; set; }

        [JsonProperty("StampId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Stamp { get; set; }
        public string Password { get; set; }

        [JsonProperty("Fields")]
        public StampDataInputFieldTypeItem[] Field { get; set; }
    }

    public class StampDataInputFieldTypeItem
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
        public string Guid { get; set; }
        public string Color { get; set; }
        public bool IsDefault { get; set; }
        public string Type { get; set; }
        public string FileCabinetId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DialogTypeInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldTypeInput
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