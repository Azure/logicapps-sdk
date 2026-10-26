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
        public IWorkflowAction<ApiConnectionActionConfiguration> SubmitLibraryItemToWorkflow(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> commentcomments = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_commentcomments = WorkflowExpression.Compile(commentcomments, nameof(commentcomments), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/submit", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                if (__workflow_commentcomments != null)
                {
                    comment["comments"] = ExpressionConverter.ConvertO(__workflow_commentcomments);
                    commentpropCount++;
                }

                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

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
        public IBodyWorkflowAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp, ApiConnectionActionConfiguration> GenerateAsync(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentVersionId, Expression<Func<genInputReqoutputsInputItem[]>> genInputReqoutputs, Expression<Func<V2AdHocInputs[]>> genInputReqadHocInputs = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentVersionId = WorkflowExpression.Compile(libraryContentVersionId, nameof(libraryContentVersionId), required: true);
            var __workflow_genInputReqoutputs = WorkflowExpression.Compile(genInputReqoutputs, nameof(genInputReqoutputs), required: true);
            var __workflow_genInputReqadHocInputs = WorkflowExpression.Compile(genInputReqadHocInputs, nameof(genInputReqadHocInputs), required: false);
            return new DeferredBodyAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/livedocVersions/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var genInputReq = new JObject();
                var genInputReqpropCount = 0;
                if (__workflow_genInputReqadHocInputs != null)
                {
                    genInputReq["adHocInputs"] = ExpressionConverter.ConvertO(__workflow_genInputReqadHocInputs);
                    genInputReqpropCount++;
                }

                genInputReqpropCount++;
                genInputReq["outputs"] = ExpressionConverter.ConvertO(__workflow_genInputReqoutputs);
                if (genInputReqpropCount > 0)
                {
                    callPayload.Body = genInputReq;
                }

                return new ApiConnectionAction<V2LiveDocsModelsResponseModelsLiveDocGenSuccinctResultResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2LibraryPublishingPublishResponse, ApiConnectionActionConfiguration> PublishLibraryItems(Expression<Func<string>> teamsiteId, Expression<Func<string>> publishRequestcomment = null, Expression<Func<V2LibraryPublishingPublishContentItem[]>> publishRequestcontent = null, Expression<Func<string>> publishRequestpublishAt = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_publishRequestcomment = WorkflowExpression.Compile(publishRequestcomment, nameof(publishRequestcomment), required: false);
            var __workflow_publishRequestcontent = WorkflowExpression.Compile(publishRequestcontent, nameof(publishRequestcontent), required: false);
            var __workflow_publishRequestpublishAt = WorkflowExpression.Compile(publishRequestpublishAt, nameof(publishRequestpublishAt), required: false);
            return new DeferredBodyAction<V2LibraryPublishingPublishResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/publish", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var publishRequest = new JObject();
                var publishRequestpropCount = 0;
                if (__workflow_publishRequestcomment != null)
                {
                    publishRequest["comment"] = ExpressionConverter.ConvertO(__workflow_publishRequestcomment);
                    publishRequestpropCount++;
                }

                if (__workflow_publishRequestcontent != null)
                {
                    publishRequest["content"] = ExpressionConverter.ConvertO(__workflow_publishRequestcontent);
                    publishRequestpropCount++;
                }

                if (__workflow_publishRequestpublishAt != null)
                {
                    publishRequest["publishAt"] = ExpressionConverter.ConvertO(__workflow_publishRequestpublishAt);
                    publishRequestpropCount++;
                }

                if (publishRequestpropCount > 0)
                {
                    callPayload.Body = publishRequest;
                }

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
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration> CreateWorkspaceFolder(Expression<Func<string>> foldername = null, Expression<Func<string>> folderparentFolderId = null)
        {
            var __workflow_foldername = WorkflowExpression.Compile(foldername, nameof(foldername), required: false);
            var __workflow_folderparentFolderId = WorkflowExpression.Compile(folderparentFolderId, nameof(folderparentFolderId), required: false);
            return new DeferredBodyAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workspace/folders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var folder = new JObject();
                var folderpropCount = 0;
                if (__workflow_foldername != null)
                {
                    folder["name"] = ExpressionConverter.ConvertO(__workflow_foldername);
                    folderpropCount++;
                }

                if (__workflow_folderparentFolderId != null)
                {
                    folder["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_folderparentFolderId);
                    folderpropCount++;
                }

                if (folderpropCount > 0)
                {
                    callPayload.Body = folder;
                }

                return new ApiConnectionAction<V2WorkSpaceContentManagerModelsWsFolderResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismic")]
        public IBodyWorkflowAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration> CreateWorkspaceContextualFolder(Expression<Func<string>> foldercontextId = null, Expression<Func<string>> foldercontextType = null, Expression<Func<string>> foldercontextTypePlural = null, Expression<Func<string>> foldername = null, Expression<Func<string>> foldersystemType = null)
        {
            var __workflow_foldercontextId = WorkflowExpression.Compile(foldercontextId, nameof(foldercontextId), required: false);
            var __workflow_foldercontextType = WorkflowExpression.Compile(foldercontextType, nameof(foldercontextType), required: false);
            var __workflow_foldercontextTypePlural = WorkflowExpression.Compile(foldercontextTypePlural, nameof(foldercontextTypePlural), required: false);
            var __workflow_foldername = WorkflowExpression.Compile(foldername, nameof(foldername), required: false);
            var __workflow_foldersystemType = WorkflowExpression.Compile(foldersystemType, nameof(foldersystemType), required: false);
            return new DeferredBodyAction<V2WorkSpaceContentManagerModelsWsFolderResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workspace/folders/createContextualFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var folder = new JObject();
                var folderpropCount = 0;
                if (__workflow_foldercontextId != null)
                {
                    folder["contextId"] = ExpressionConverter.ConvertO(__workflow_foldercontextId);
                    folderpropCount++;
                }

                if (__workflow_foldercontextType != null)
                {
                    folder["contextType"] = ExpressionConverter.ConvertO(__workflow_foldercontextType);
                    folderpropCount++;
                }

                if (__workflow_foldercontextTypePlural != null)
                {
                    folder["contextTypePlural"] = ExpressionConverter.ConvertO(__workflow_foldercontextTypePlural);
                    folderpropCount++;
                }

                if (__workflow_foldername != null)
                {
                    folder["name"] = ExpressionConverter.ConvertO(__workflow_foldername);
                    folderpropCount++;
                }

                if (__workflow_foldersystemType != null)
                {
                    folder["systemType"] = ExpressionConverter.ConvertO(__workflow_foldersystemType);
                    folderpropCount++;
                }

                if (folderpropCount > 0)
                {
                    callPayload.Body = folder;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum genInputReqoutputsInputItemPdfOptionsTypeCompatibilityType
    {
        [EnumMember(Value = "Acrobat 5.0")]
        Acrobat50,
        [EnumMember(Value = "Acrobat 7.0")]
        Acrobat70,
        [EnumMember(Value = "Acrobat 9.0")]
        Acrobat90
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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