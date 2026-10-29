//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismic
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocGenResultResp, ApiConnectionActionConfiguration> GetGenerationResultAsync(Expression<Func<string>> generatedLivedocId)
        {
            var __workflow_generatedLivedocId = WorkflowExpression.Compile(generatedLivedocId, nameof(generatedLivedocId), required: true);
            return new DeferredBodyAction<V2LiveDocsModelsResponseModelsLiveDocGenResultResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/generatedLivedocs/{0}", __workflow_generatedLivedocId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocGenResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2CommonModelsDownloadLocationResp, ApiConnectionActionConfiguration> GetGeneratedLiveDocContent(Expression<Func<string>> generatedLivedocId, Expression<Func<string>> outputId)
        {
            var __workflow_generatedLivedocId = WorkflowExpression.Compile(generatedLivedocId, nameof(generatedLivedocId), required: true);
            var __workflow_outputId = WorkflowExpression.Compile(outputId, nameof(outputId), required: true);
            return new DeferredBodyAction<V2CommonModelsDownloadLocationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/generatedLivedocs/{0}/outputs/{1}/content", __workflow_generatedLivedocId.WithUrlEncoding(1), __workflow_outputId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(false);
                return new ApiConnectionAction<V2CommonModelsDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2PredictiveContentModelsPredictiveContentResponse[], ApiConnectionActionConfiguration> GetPredictiveContentResultSet(Expression<Func<string>> predictiveContentId, Expression<Func<string>> contextId)
        {
            var __workflow_predictiveContentId = WorkflowExpression.Compile(predictiveContentId, nameof(predictiveContentId), required: true);
            var __workflow_contextId = WorkflowExpression.Compile(contextId, nameof(contextId), required: true);
            return new DeferredBodyAction<V2PredictiveContentModelsPredictiveContentResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/predictiveContent/{0}/{1}", __workflow_predictiveContentId.WithUrlEncoding(1), __workflow_contextId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2PredictiveContentModelsPredictiveContentResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2TeamsitesTeamsiteResponse[], ApiConnectionActionConfiguration> GetTeamsitesAsync()
        {
            return new DeferredBodyAction<V2TeamsitesTeamsiteResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/teamsites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2TeamsitesTeamsiteResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LibraryContentManagementModelsItemResponse, ApiConnectionActionConfiguration> GetItemInformation(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<V2LibraryContentManagementModelsItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2LibraryContentManagementModelsItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SubmitLibraryItemToWorkflow(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<SubmitLibraryItemToWorkflowInput>> comment = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/submit", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_comment != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_comment);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocVersionResp, ApiConnectionActionConfiguration> GetLiveDocInputParams(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentVersionId = WorkflowExpression.Compile(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            return new DeferredBodyAction<V2LiveDocsModelsResponseModelsLiveDocVersionResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/livedocVersions/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocVersionResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp, ApiConnectionActionConfiguration> GenerateAsync(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId, Expression<Func<GenerateAsyncInput>> genInputReq = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentVersionId = WorkflowExpression.Compile(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            var __workflow_genInputReq = WorkflowExpression.Compile(genInputReq, nameof(genInputReq), required: false);
            return new DeferredBodyAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/livedocVersions/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_genInputReq != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_genInputReq);
                return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LibraryPublishingPublishResponse, ApiConnectionActionConfiguration> PublishLibraryItems(Expression<Func<string>> teamsiteId, Expression<Func<PublishLibraryItemsInput>> publishRequest = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_publishRequest = WorkflowExpression.Compile(publishRequest, nameof(publishRequest), required: false);
            return new DeferredBodyAction<V2LibraryPublishingPublishResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/publish", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_publishRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_publishRequest);
                return new ApiConnectionAction<V2LibraryPublishingPublishResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2UsersUserResponse, ApiConnectionActionConfiguration> GetUserDetails(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<V2UsersUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2UsersUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration> CreateWorkspaceFolder(Expression<Func<CreateWorkspaceFolderInput>> folder = null)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: false);
            return new DeferredBodyAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workspace/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folder != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_folder);
                return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsFolderResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration> CreateWorkspaceContextualFolder(Expression<Func<CreateWorkspaceContextualFolderInput>> folder = null)
        {
            var __workflow_folder = WorkflowExpression.Compile(folder, nameof(folder), required: false);
            return new DeferredBodyAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workspace/folders/createContextualFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folder != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_folder);
                return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsFolderResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsItemsOfV2WorkSpaceContentManagerModelsWsItemResp, ApiConnectionActionConfiguration> GetWorkspaceFolderItems(Expression<Func<string>> workspaceFolderId)
        {
            var __workflow_workspaceFolderId = WorkflowExpression.Compile(workspaceFolderId, nameof(workspaceFolderId), required: true);
            return new DeferredBodyAction<V2WorkSpaceContentManagerModelsItemsOfV2WorkSpaceContentManagerModelsWsItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/folders/{0}/items", __workflow_workspaceFolderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2WorkSpaceContentManagerModelsItemsOfV2WorkSpaceContentManagerModelsWsItemResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsItemResp, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> workspaceContentId)
        {
            var __workflow_workspaceContentId = WorkflowExpression.Compile(workspaceContentId, nameof(workspaceContentId), required: true);
            return new DeferredBodyAction<V2WorkSpaceContentManagerModelsWsItemResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/items/{0}", __workflow_workspaceContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsItemResp>(callPayload);
            });
        }
    }

    public class SeismicTriggers([ConnectionName] string connectionId)
    {
    }

    public class V2LiveDocsModelsResponseModelsLiveDocGenResultResp
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("outputs")]
        public V2LiveDocsModelsResponseModelsLiveDocGenOutputResultResp[] Outputs { get; set; }
    }

    public class V2LiveDocsModelsResponseModelsLiveDocGenOutputResultResp
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public V2LiveDocsModelsResponseModelsLiveDocGenOutputResultRespStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V2LiveDocsModelsResponseModelsLiveDocGenOutputResultRespStatusType
    {
        Queued,
        Generating,
        Completed,
        Failed
    }

    public class V2CommonModelsDownloadLocationResp
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class V2PredictiveContentModelsPredictiveContentResponse
    {
        [JsonProperty("applicationUrls")]
        public V2WorkspaceApplicationUrl[] ApplicationUrls { get; set; }

        [JsonProperty("contentProfileId")]
        public string ContentProfileId { get; set; }

        [JsonProperty("deliveryOptions")]
        public V2WorkspaceDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("hierarchy")]
        public V2PredictiveContentModelsPredictiveContentHierarchy[] Hierarchy { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("libraryContent")]
        public V2LibraryWorkflowLibraryContent LibraryContent { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("properties")]
        public SeismicPublicIntegrationApiOriginApiClientModelsContentManagerContentCustomProperties[] Properties { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("score")]
        public V2PredictiveContentModelsPredictiveContentScore Score { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public V2LibraryContentManagementModelsUrlInfo Url { get; set; }
    }

    public class V2WorkspaceApplicationUrl
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class V2WorkspaceDeliveryOption
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2PredictiveContentModelsPredictiveContentHierarchy
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class V2LibraryWorkflowLibraryContent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class SeismicPublicIntegrationApiOriginApiClientModelsContentManagerContentCustomProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class V2PredictiveContentModelsPredictiveContentScore
    {
        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("rank")]
        public double Rank { get; set; }
    }

    public class V2LibraryContentManagementModelsUrlInfo
    {
        [JsonProperty("openInNewWindow")]
        public bool OpenInNewWindow { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class V2TeamsitesTeamsiteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class V2LibraryContentManagementModelsItemResponse
    {
        [JsonProperty("assignedToProfiles")]
        public V2LibraryContentManagementModelsAssignedToProfile[] AssignedToProfiles { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public V2CommonCreatedUser CreatedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("experts")]
        public V2LibraryContentManagementModelsContentExperts[] Experts { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public V2CommonModifiedUser ModifiedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("properties")]
        public V2LibraryContentManagementModelsCustomProperties[] Properties { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public V2LibraryContentManagementModelsItemResponseTypeType Type { get; set; }

        [JsonProperty("url")]
        public V2LibraryContentManagementModelsUrlInfo Url { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class V2LibraryContentManagementModelsAssignedToProfile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class V2CommonCreatedUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2LibraryContentManagementModelsContentExperts
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class V2CommonModifiedUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2LibraryContentManagementModelsCustomProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V2LibraryContentManagementModelsItemResponseTypeType
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "youtube")]
        Youtube,
        [EnumMember(Value = "vimeo")]
        Vimeo,
        [EnumMember(Value = "datasource")]
        Datasource,
        [EnumMember(Value = "livedoc")]
        Livedoc,
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "livecomponent")]
        Livecomponent
    }

    public class SubmitLibraryItemToWorkflowInput
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class V2LiveDocsModelsResponseModelsLiveDocVersionResp
    {
        [JsonProperty("adhocInputs")]
        public V2LiveDocsModelsResponseModelsAdhocInputResp[] AdhocInputs { get; set; }
    }

    public class V2LiveDocsModelsResponseModelsAdhocInputResp
    {
        [JsonProperty("columns")]
        public V2LiveDocsModelsResponseModelsAdhocInputRespItems[] Columns { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class V2LiveDocsModelsResponseModelsAdhocInputRespItems
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp
    {
        [JsonProperty("generatedLivedocId")]
        public string GeneratedLivedocId { get; set; }
    }

    public class GenerateAsyncInput
    {
        [JsonProperty("adHocInputs")]
        public V2AdHocInputs[] AdHocInputs { get; set; }

        [JsonProperty("outputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateAsyncInputOutputsTypeItem[] Outputs { get; set; }
    }

    public class V2AdHocInputs
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GenerateAsyncInputOutputsTypeItem
    {
        [JsonProperty("docxOptions")]
        public GenerateAsyncInputOutputsTypeItemDocxOptionsType DocxOptions { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateAsyncInputOutputsTypeItemFormatType Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pdfOptions")]
        public GenerateAsyncInputOutputsTypeItemPdfOptionsType PdfOptions { get; set; }

        [JsonProperty("pptxOptions")]
        public GenerateAsyncInputOutputsTypeItemPptxOptionsType PptxOptions { get; set; }

        [JsonProperty("xlsxOptions")]
        public GenerateAsyncInputOutputsTypeItemXlsxOptionsType XlsxOptions { get; set; }
    }

    public class GenerateAsyncInputOutputsTypeItemDocxOptionsType
    {
        [JsonProperty("imageDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateAsyncInputOutputsTypeItemDocxOptionsTypeImageDpiType? ImageDpi { get; set; } = GenerateAsyncInputOutputsTypeItemDocxOptionsTypeImageDpiType._200;
    }

    public enum GenerateAsyncInputOutputsTypeItemDocxOptionsTypeImageDpiType
    {
        _0 = 0,
        _96 = 96,
        _120 = 120,
        _144 = 144,
        _200 = 200,
        _300 = 300,
        _400 = 400
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateAsyncInputOutputsTypeItemFormatType
    {
        PPTX,
        DOCX,
        PDF,
        XLSX
    }

    public class GenerateAsyncInputOutputsTypeItemPdfOptionsType
    {
        [JsonProperty("compatibility", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateAsyncInputOutputsTypeItemPdfOptionsTypeCompatibilityType? Compatibility { get; set; } = GenerateAsyncInputOutputsTypeItemPdfOptionsTypeCompatibilityType.Acrobat90;

        [JsonProperty("layout", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateAsyncInputOutputsTypeItemPdfOptionsTypeLayoutType? Layout { get; set; } = GenerateAsyncInputOutputsTypeItemPdfOptionsTypeLayoutType.FullPageSlides;

        [JsonProperty("openPassword")]
        public string OpenPassword { get; set; }

        [JsonProperty("ownerOptions")]
        public string OwnerOptions { get; set; }

        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateAsyncInputOutputsTypeItemPdfOptionsTypeCompatibilityType
    {
        [EnumMember(Value = "Acrobat 5.0")]
        Acrobat50,
        [EnumMember(Value = "Acrobat 7.0")]
        Acrobat70,
        [EnumMember(Value = "Acrobat 9.0")]
        Acrobat90
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateAsyncInputOutputsTypeItemPdfOptionsTypeLayoutType
    {
        [EnumMember(Value = "Full Page Slides")]
        FullPageSlides,
        [EnumMember(Value = "Note Pages")]
        NotePages
    }

    public class GenerateAsyncInputOutputsTypeItemPptxOptionsType
    {
        [JsonProperty("clearNotes", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClearNotes { get; set; } = false;

        [JsonProperty("imageDpi", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateAsyncInputOutputsTypeItemPptxOptionsTypeImageDpiType? ImageDpi { get; set; } = GenerateAsyncInputOutputsTypeItemPptxOptionsTypeImageDpiType._200;
    }

    public enum GenerateAsyncInputOutputsTypeItemPptxOptionsTypeImageDpiType
    {
        _0 = 0,
        _96 = 96,
        _120 = 120,
        _144 = 144,
        _200 = 200,
        _300 = 300,
        _400 = 400
    }

    public class GenerateAsyncInputOutputsTypeItemXlsxOptionsType
    {
        [JsonProperty("datasource", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Datasource { get; set; }
    }

    public class V2LibraryPublishingPublishResponse
    {
        [JsonProperty("errors")]
        public V2LibraryPublishingErrorPublishResponseStatus[] Errors { get; set; }

        [JsonProperty("totalErrors")]
        public int TotalErrors { get; set; }

        [JsonProperty("totalRequests")]
        public int TotalRequests { get; set; }

        [JsonProperty("totalSucceeded")]
        public int TotalSucceeded { get; set; }

        [JsonProperty("totalWarnings")]
        public int TotalWarnings { get; set; }

        [JsonProperty("warnings")]
        public V2LibraryPublishingWarningPublishResponseStatus[] Warnings { get; set; }
    }

    public class V2LibraryPublishingErrorPublishResponseStatus
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class V2LibraryPublishingWarningPublishResponseStatus
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class PublishLibraryItemsInput
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("content")]
        public V2LibraryPublishingPublishContentItem[] Content { get; set; }

        [JsonProperty("publishAt")]
        public string PublishAt { get; set; }
    }

    public class V2LibraryPublishingPublishContentItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2UsersUserResponse
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("defaultContentProfileId")]
        public string DefaultContentProfileId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("licenseType")]
        public V2UsersUserResponseLicenseTypeType LicenseType { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("ssoId")]
        public string SsoId { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V2UsersUserResponseLicenseTypeType
    {
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "premium")]
        Premium,
        [EnumMember(Value = "partner")]
        Partner
    }

    public class V2WorkSpaceContentManagerModelsWsFolderResp
    {
        [JsonProperty("applicationUrls")]
        public V2WorkspaceApplicationUrl[] ApplicationUrls { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public V2WorkspaceCreatedUser CreatedBy { get; set; }

        [JsonProperty("deliveryOptions")]
        public V2WorkspaceDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public V2WorkspaceModifiedUser ModifiedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public V2WorkSpaceContentManagerModelsWsFolderRespTypeType Type { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class V2WorkspaceCreatedUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class V2WorkspaceModifiedUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V2WorkSpaceContentManagerModelsWsFolderRespTypeType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File
    }

    public class CreateWorkspaceFolderInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }
    }

    public class CreateWorkspaceContextualFolderInput
    {
        [JsonProperty("contextId")]
        public string ContextId { get; set; }

        [JsonProperty("contextType")]
        public string ContextType { get; set; }

        [JsonProperty("contextTypePlural")]
        public string ContextTypePlural { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("systemType")]
        public string SystemType { get; set; }
    }

    public class V2WorkSpaceContentManagerModelsItemsOfV2WorkSpaceContentManagerModelsWsItemResp
    {
        [JsonProperty("itemCount")]
        public int ItemCount { get; set; }

        [JsonProperty("items")]
        public V2WorkSpaceContentManagerModelsWsItemResp[] Items { get; set; }
    }

    public class V2WorkSpaceContentManagerModelsWsItemResp
    {
        [JsonProperty("applicationUrls")]
        public V2WorkspaceApplicationUrl[] ApplicationUrls { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public V2WorkspaceCreatedUser CreatedBy { get; set; }

        [JsonProperty("deliveryOptions")]
        public V2WorkspaceDeliveryOption[] DeliveryOptions { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isContextualContent")]
        public bool IsContextualContent { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public V2WorkspaceModifiedUser ModifiedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("resourceUrl")]
        public string ResourceUrl { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public V2WorkSpaceContentManagerModelsWsItemRespTypeType Type { get; set; }

        [JsonProperty("url")]
        public V2WorkSpaceContentManagerModelsWsUrlInfoResp Url { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum V2WorkSpaceContentManagerModelsWsItemRespTypeType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File
    }

    public class V2WorkSpaceContentManagerModelsWsUrlInfoResp
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismic;

    public partial class WorkflowManagedActions
    {
        public SeismicActions Seismic(string connectionId) => new SeismicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismicTriggers Seismic(string connectionId) => new SeismicTriggers(connectionId);
    }
}