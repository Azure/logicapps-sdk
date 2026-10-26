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
        public IBodyWorkflowAction<SearchForDocumentsInFileCabinetResponse, ApiConnectionActionConfiguration> SearchForDocumentsInFileCabinet(Expression<Func<string>> fileCabinet, Expression<Func<string>> searchDialogId, Expression<Func<object>> searchQuery = null)
        {
            var __workflow_fileCabinet = WorkflowExpression.Compile(fileCabinet, nameof(fileCabinet), required: true);
            var __workflow_searchDialogId = WorkflowExpression.Compile(searchDialogId, nameof(searchDialogId), required: true);
            var __workflow_searchQuery = WorkflowExpression.Compile(searchQuery, nameof(searchQuery), required: false);
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
        public IBodyWorkflowAction<GetFileCabinetsResponse, ApiConnectionActionConfiguration> GetFileCabinets(Expression<Func<fileCabinetTypeInput>> fileCabinetType)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadFile(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<string>> fileNumber, Expression<Func<documentFormatInput>> documentFormat)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<documentFormatInput>> documentFormat)
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
        public IBodyWorkflowAction<UpdateIndexFieldsResponse, ApiConnectionActionConfiguration> UpdateIndexFields(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<documentFieldsInputItem[]>> documentFields = null)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_documentFields = WorkflowExpression.Compile(documentFields, nameof(documentFields), required: false);
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
        public IBodyWorkflowAction<TransferDocumentResponse, ApiConnectionActionConfiguration> TransferDocument(Expression<Func<string>> destinationFileCabinetId, Expression<Func<string>> transferInfosourceFileCabinetDocumentTray, Expression<Func<string>> storeDialogId = null, Expression<Func<transferInfodocsInputItem[]>> transferInfodocs = null, Expression<Func<bool>> transferInfokeepSource = null, Expression<Func<bool>> transferInfofillIntellix = null)
        {
            var __workflow_destinationFileCabinetId = WorkflowExpression.Compile(destinationFileCabinetId, nameof(destinationFileCabinetId), required: true);
            var __workflow_transferInfosourceFileCabinetDocumentTray = WorkflowExpression.Compile(transferInfosourceFileCabinetDocumentTray, nameof(transferInfosourceFileCabinetDocumentTray), required: true);
            var __workflow_storeDialogId = WorkflowExpression.Compile(storeDialogId, nameof(storeDialogId), required: false);
            var __workflow_transferInfodocs = WorkflowExpression.Compile(transferInfodocs, nameof(transferInfodocs), required: false);
            var __workflow_transferInfokeepSource = WorkflowExpression.Compile(transferInfokeepSource, nameof(transferInfokeepSource), required: false);
            var __workflow_transferInfofillIntellix = WorkflowExpression.Compile(transferInfofillIntellix, nameof(transferInfofillIntellix), required: false);
            return new DeferredBodyAction<TransferDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Task/Transfer", __workflow_destinationFileCabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_storeDialogId != null)
                    callPayload.Queries["StoreDialogID"] = ExpressionConverter.Convert(__workflow_storeDialogId);
                var transferInfo = new JObject();
                var transferInfopropCount = 0;
                transferInfopropCount++;
                transferInfo["SourceFileCabinetId"] = ExpressionConverter.ConvertO(__workflow_transferInfosourceFileCabinetDocumentTray);
                if (__workflow_transferInfodocs != null)
                {
                    transferInfo["Documents"] = ExpressionConverter.ConvertO(__workflow_transferInfodocs);
                    transferInfopropCount++;
                }

                if (__workflow_transferInfokeepSource != null)
                {
                    transferInfo["KeepSource"] = ExpressionConverter.ConvertO(__workflow_transferInfokeepSource);
                    transferInfopropCount++;
                }

                if (__workflow_transferInfofillIntellix != null)
                {
                    transferInfo["FillIntellix"] = ExpressionConverter.ConvertO(__workflow_transferInfofillIntellix);
                    transferInfopropCount++;
                }

                if (transferInfopropCount > 0)
                {
                    callPayload.Body = transferInfo;
                }

                return new ApiConnectionAction<TransferDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<PlaceAStampResponse, ApiConnectionActionConfiguration> PlaceAStamp(Expression<Func<string>> fileCabinetId, Expression<Func<int>> documentId, Expression<Func<int>> stampDatafileNumber, Expression<Func<int>> stampDatapageNumber, Expression<Func<int>> stampDatalayer, Expression<Func<string>> stampDatastamp, Expression<Func<double>> stampDatahorizontalPositionXPosition = null, Expression<Func<double>> stampDataverticalPositionYPosition = null, Expression<Func<string>> stampDatapassword = null, Expression<Func<stampDatafieldInputItem[]>> stampDatafield = null)
        {
            var __workflow_fileCabinetId = WorkflowExpression.Compile(fileCabinetId, nameof(fileCabinetId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_stampDatafileNumber = WorkflowExpression.Compile(stampDatafileNumber, nameof(stampDatafileNumber), required: true);
            var __workflow_stampDatapageNumber = WorkflowExpression.Compile(stampDatapageNumber, nameof(stampDatapageNumber), required: true);
            var __workflow_stampDatalayer = WorkflowExpression.Compile(stampDatalayer, nameof(stampDatalayer), required: true);
            var __workflow_stampDatastamp = WorkflowExpression.Compile(stampDatastamp, nameof(stampDatastamp), required: true);
            var __workflow_stampDatahorizontalPositionXPosition = WorkflowExpression.Compile(stampDatahorizontalPositionXPosition, nameof(stampDatahorizontalPositionXPosition), required: false);
            var __workflow_stampDataverticalPositionYPosition = WorkflowExpression.Compile(stampDataverticalPositionYPosition, nameof(stampDataverticalPositionYPosition), required: false);
            var __workflow_stampDatapassword = WorkflowExpression.Compile(stampDatapassword, nameof(stampDatapassword), required: false);
            var __workflow_stampDatafield = WorkflowExpression.Compile(stampDatafield, nameof(stampDatafield), required: false);
            return new DeferredBodyAction<PlaceAStampResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/FileCabinets/{0}/Documents/{1}/Annotation", __workflow_fileCabinetId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var stampData = new JObject();
                var stampDatapropCount = 0;
                stampDatapropCount++;
                stampData["FileNumber"] = ExpressionConverter.ConvertO(__workflow_stampDatafileNumber);
                stampDatapropCount++;
                stampData["PageNumber"] = ExpressionConverter.ConvertO(__workflow_stampDatapageNumber);
                stampDatapropCount++;
                stampData["Layer"] = ExpressionConverter.ConvertO(__workflow_stampDatalayer);
                if (__workflow_stampDatahorizontalPositionXPosition != null)
                {
                    stampData["PositionX"] = ExpressionConverter.ConvertO(__workflow_stampDatahorizontalPositionXPosition);
                    stampDatapropCount++;
                }

                if (__workflow_stampDataverticalPositionYPosition != null)
                {
                    stampData["PositionY"] = ExpressionConverter.ConvertO(__workflow_stampDataverticalPositionYPosition);
                    stampDatapropCount++;
                }

                stampDatapropCount++;
                stampData["StampId"] = ExpressionConverter.ConvertO(__workflow_stampDatastamp);
                if (__workflow_stampDatapassword != null)
                {
                    stampData["Password"] = ExpressionConverter.ConvertO(__workflow_stampDatapassword);
                    stampDatapropCount++;
                }

                if (__workflow_stampDatafield != null)
                {
                    stampData["Fields"] = ExpressionConverter.ConvertO(__workflow_stampDatafield);
                    stampDatapropCount++;
                }

                if (stampDatapropCount > 0)
                {
                    callPayload.Body = stampData;
                }

                return new ApiConnectionAction<PlaceAStampResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docuware")]
        public IBodyWorkflowAction<GetDialogsResponse, ApiConnectionActionConfiguration> GetDialogs(Expression<Func<string>> fileCabinet, Expression<Func<dialogTypeInput>> dialogType = null)
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
        public IBodyWorkflowAction<GetFileCabinetFieldsResponse, ApiConnectionActionConfiguration> GetFileCabinetFields(Expression<Func<string>> fileCabinet, Expression<Func<fieldTypeInput>> fieldType = null)
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

        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string Color { get; set; }
        public bool IsTray { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public int Id { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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