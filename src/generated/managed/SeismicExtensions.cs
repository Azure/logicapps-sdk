//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismic
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocGenResultResp> GetGenerationResultAsync([WorkflowExpression] Func<string> generatedLivedocId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/generatedLivedocs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(generatedLivedocId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocGenResultResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2CommonModelsDownloadLocationResp> GetGeneratedLiveDocContent([WorkflowExpression] Func<string> generatedLivedocId, [WorkflowExpression] Func<string> outputId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/generatedLivedocs/{0}/outputs/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(generatedLivedocId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(outputId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction<V2CommonModelsDownloadLocationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2PredictiveContentModelsPredictiveContentResponse[]> GetPredictiveContentResultSet([WorkflowExpression] Func<string> predictiveContentId, [WorkflowExpression] Func<string> contextId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/predictiveContent/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(predictiveContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contextId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2PredictiveContentModelsPredictiveContentResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2TeamsitesTeamsiteResponse[]> GetTeamsitesAsync()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/teamsites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2TeamsitesTeamsiteResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LibraryContentManagementModelsItemResponse> GetItemInformation([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2LibraryContentManagementModelsItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IWorkflowAction SubmitLibraryItemToWorkflow([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> commentcomments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/submit", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (commentcomments != null)
                {
                    comment["comments"] = SourceExpressionConverter.ConvertToken(commentcomments);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocVersionResp> GetLiveDocInputParams([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentVersionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/livedocVersions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentVersionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocVersionResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp> GenerateAsync([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentVersionId, [WorkflowExpression] Func<genInputReqoutputsInputItem[]> genInputReqoutputs, [WorkflowExpression] Func<V2AdHocInputs[]> genInputReqadHocInputs = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/livedocVersions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentVersionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var genInputReq = new JObject();
                var genInputReqpropCount = 0;
                if (genInputReqadHocInputs != null)
                {
                    genInputReq["adHocInputs"] = SourceExpressionConverter.ConvertToken(genInputReqadHocInputs);
                    genInputReqpropCount++;
                }

                genInputReqpropCount++;
                genInputReq["outputs"] = SourceExpressionConverter.ConvertToken(genInputReqoutputs);
                if (genInputReqpropCount > 0)
                {
                    callPayload.Body = genInputReq;
                }
                return callPayload;
            }

            return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LibraryPublishingPublishResponse> PublishLibraryItems([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> publishRequestcomment = null, [WorkflowExpression] Func<V2LibraryPublishingPublishContentItem[]> publishRequestcontent = null, [WorkflowExpression] Func<string> publishRequestpublishAt = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var publishRequest = new JObject();
                var publishRequestpropCount = 0;
                if (publishRequestcomment != null)
                {
                    publishRequest["comment"] = SourceExpressionConverter.ConvertToken(publishRequestcomment);
                    publishRequestpropCount++;
                }

                if (publishRequestcontent != null)
                {
                    publishRequest["content"] = SourceExpressionConverter.ConvertToken(publishRequestcontent);
                    publishRequestpropCount++;
                }

                if (publishRequestpublishAt != null)
                {
                    publishRequest["publishAt"] = SourceExpressionConverter.ConvertToken(publishRequestpublishAt);
                    publishRequestpropCount++;
                }

                if (publishRequestpropCount > 0)
                {
                    callPayload.Body = publishRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<V2LibraryPublishingPublishResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2UsersUserResponse> GetUserDetails([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2UsersUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsFolderResp> CreateWorkspaceFolder([WorkflowExpression] Func<string> foldername = null, [WorkflowExpression] Func<string> folderparentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workspace/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var folder = new JObject();
                var folderpropCount = 0;
                if (foldername != null)
                {
                    folder["name"] = SourceExpressionConverter.ConvertToken(foldername);
                    folderpropCount++;
                }

                if (folderparentFolderId != null)
                {
                    folder["parentFolderId"] = SourceExpressionConverter.ConvertToken(folderparentFolderId);
                    folderpropCount++;
                }

                if (folderpropCount > 0)
                {
                    callPayload.Body = folder;
                }
                return callPayload;
            }

            return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsFolderResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsFolderResp> CreateWorkspaceContextualFolder([WorkflowExpression] Func<string> foldercontextId = null, [WorkflowExpression] Func<string> foldercontextType = null, [WorkflowExpression] Func<string> foldercontextTypePlural = null, [WorkflowExpression] Func<string> foldername = null, [WorkflowExpression] Func<string> foldersystemType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workspace/folders/createContextualFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var folder = new JObject();
                var folderpropCount = 0;
                if (foldercontextId != null)
                {
                    folder["contextId"] = SourceExpressionConverter.ConvertToken(foldercontextId);
                    folderpropCount++;
                }

                if (foldercontextType != null)
                {
                    folder["contextType"] = SourceExpressionConverter.ConvertToken(foldercontextType);
                    folderpropCount++;
                }

                if (foldercontextTypePlural != null)
                {
                    folder["contextTypePlural"] = SourceExpressionConverter.ConvertToken(foldercontextTypePlural);
                    folderpropCount++;
                }

                if (foldername != null)
                {
                    folder["name"] = SourceExpressionConverter.ConvertToken(foldername);
                    folderpropCount++;
                }

                if (foldersystemType != null)
                {
                    folder["systemType"] = SourceExpressionConverter.ConvertToken(foldersystemType);
                    folderpropCount++;
                }

                if (folderpropCount > 0)
                {
                    callPayload.Body = folder;
                }
                return callPayload;
            }

            return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsFolderResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsItemsOfV2WorkSpaceContentManagerModelsWsItemResp> GetWorkspaceFolderItems([WorkflowExpression] Func<string> workspaceFolderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/folders/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceFolderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2WorkSpaceContentManagerModelsItemsOfV2WorkSpaceContentManagerModelsWsItemResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsItemResp> GetItem([WorkflowExpression] Func<string> workspaceContentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsItemResp>(BuildSourceInput);
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

    public class genInputReqoutputsInputItem
    {
        [JsonProperty("docxOptions")]
        public genInputReqoutputsInputItemDocxOptionsType DocxOptions { get; set; }

        [JsonProperty("format")]
        public genInputReqoutputsInputItemFormatType Format { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pdfOptions")]
        public genInputReqoutputsInputItemPdfOptionsType PdfOptions { get; set; }

        [JsonProperty("pptxOptions")]
        public genInputReqoutputsInputItemPptxOptionsType PptxOptions { get; set; }

        [JsonProperty("xlsxOptions")]
        public genInputReqoutputsInputItemXlsxOptionsType XlsxOptions { get; set; }
    }

    public class genInputReqoutputsInputItemDocxOptionsType
    {
        [JsonProperty("imageDpi")]
        public genInputReqoutputsInputItemDocxOptionsTypeImageDpiType ImageDpi { get; set; }
    }

    public enum genInputReqoutputsInputItemDocxOptionsTypeImageDpiType
    {
        _0 = 0,
        _96 = 96,
        _120 = 120,
        _144 = 144,
        _200 = 200,
        _300 = 300,
        _400 = 400
    }

    public enum genInputReqoutputsInputItemFormatType
    {
        PPTX,
        DOCX,
        PDF,
        XLSX
    }

    public class genInputReqoutputsInputItemPdfOptionsType
    {
        [JsonProperty("compatibility")]
        public genInputReqoutputsInputItemPdfOptionsTypeCompatibilityType Compatibility { get; set; }

        [JsonProperty("layout")]
        public genInputReqoutputsInputItemPdfOptionsTypeLayoutType Layout { get; set; }

        [JsonProperty("openPassword")]
        public string OpenPassword { get; set; }

        [JsonProperty("ownerOptions")]
        public string OwnerOptions { get; set; }

        [JsonProperty("ownerPassword")]
        public string OwnerPassword { get; set; }
    }

    public enum genInputReqoutputsInputItemPdfOptionsTypeCompatibilityType
    {
        [EnumMember(Value = "Acrobat 5.0")]
        Acrobat50,
        [EnumMember(Value = "Acrobat 7.0")]
        Acrobat70,
        [EnumMember(Value = "Acrobat 9.0")]
        Acrobat90
    }

    public enum genInputReqoutputsInputItemPdfOptionsTypeLayoutType
    {
        [EnumMember(Value = "Full Page Slides")]
        FullPageSlides,
        [EnumMember(Value = "Note Pages")]
        NotePages
    }

    public class genInputReqoutputsInputItemPptxOptionsType
    {
        [JsonProperty("clearNotes")]
        public bool ClearNotes { get; set; }

        [JsonProperty("imageDpi")]
        public genInputReqoutputsInputItemPptxOptionsTypeImageDpiType ImageDpi { get; set; }
    }

    public enum genInputReqoutputsInputItemPptxOptionsTypeImageDpiType
    {
        _0 = 0,
        _96 = 96,
        _120 = 120,
        _144 = 144,
        _200 = 200,
        _300 = 300,
        _400 = 400
    }

    public class genInputReqoutputsInputItemXlsxOptionsType
    {
        [JsonProperty("datasource")]
        public string Datasource { get; set; }
    }

    public class V2AdHocInputs
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
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

    public enum V2WorkSpaceContentManagerModelsWsFolderRespTypeType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "file")]
        File
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