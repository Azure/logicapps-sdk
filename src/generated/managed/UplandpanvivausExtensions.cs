//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uplandpanvivaus
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UplandpanvivausActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<OperationsSearchResponse> OperationsSearch(Expression<Func<string>> instance, Expression<Func<string>> term, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null, Expression<Func<changedWhenInput>> changedWhen = null, Expression<Func<int>> directParentFolderId = null)
        {
            var apiCallPath = String.Format("/{0}/operations/search", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["term"] = ExpressionConverter.Convert(term);
            callPayload.Queries["pageOffset"] = Convert.ToString(0);
            if (pageOffset != null)
                callPayload.Queries["pageOffset"] = ExpressionConverter.Convert(pageOffset);
            callPayload.Queries["pageLimit"] = Convert.ToString(20);
            if (pageLimit != null)
                callPayload.Queries["pageLimit"] = ExpressionConverter.Convert(pageLimit);
            callPayload.Queries["changedWhen"] = Convert.ToString("NotProvided");
            if (changedWhen != null)
                callPayload.Queries["changedWhen"] = ExpressionConverter.Convert(changedWhen);
            if (directParentFolderId != null)
                callPayload.Queries["directParentFolderId"] = ExpressionConverter.Convert(directParentFolderId);
            return new ApiConnectionAction<OperationsSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetEnrichedSearchArtefactResponse> OperationsArtefactNls(Expression<Func<string>> instance, Expression<Func<string>> simplequery = null, Expression<Func<string>> advancedquery = null, Expression<Func<string>> filter = null, Expression<Func<string>> channel = null, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null, Expression<Func<string>> facet = null, Expression<Func<string>> highlightTags = null)
        {
            var apiCallPath = String.Format("/{0}/operations/artefact/nls", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (simplequery != null)
                callPayload.Queries["simplequery"] = ExpressionConverter.Convert(simplequery);
            if (advancedquery != null)
                callPayload.Queries["advancedquery"] = ExpressionConverter.Convert(advancedquery);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (channel != null)
                callPayload.Queries["channel"] = ExpressionConverter.Convert(channel);
            if (pageOffset != null)
                callPayload.Queries["pageOffset"] = ExpressionConverter.Convert(pageOffset);
            if (pageLimit != null)
                callPayload.Queries["pageLimit"] = ExpressionConverter.Convert(pageLimit);
            if (facet != null)
                callPayload.Queries["facet"] = ExpressionConverter.Convert(facet);
            if (highlightTags != null)
                callPayload.Queries["highlightTags"] = ExpressionConverter.Convert(highlightTags);
            return new ApiConnectionAction<GetEnrichedSearchArtefactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken> OperationsLiveCsh(Expression<Func<string>> instance, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyquery = null, Expression<Func<bool>> bodyshowFirstResult = null, Expression<Func<bool>> bodymaximizeClient = null)
        {
            var apiCallPath = String.Format("/{0}/operations/live/csh", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                bodypropCount++;
            }

            if (bodyshowFirstResult != null)
            {
                body["showFirstResult"] = ExpressionConverter.ConvertO(bodyshowFirstResult);
                bodypropCount++;
            }

            if (bodymaximizeClient != null)
            {
                body["maximizeClient"] = ExpressionConverter.ConvertO(bodymaximizeClient);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken> OperationsLiveDocument(Expression<Func<string>> instance, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodylocation = null, Expression<Func<bool>> bodymaximizeClient = null, Expression<Func<string>> bodycontainerId = null)
        {
            var apiCallPath = String.Format("/{0}/operations/live/document", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = ExpressionConverter.ConvertO(bodylocation);
                bodypropCount++;
            }

            if (bodymaximizeClient != null)
            {
                body["maximizeClient"] = ExpressionConverter.ConvertO(bodymaximizeClient);
                bodypropCount++;
            }

            if (bodycontainerId != null)
            {
                body["containerId"] = ExpressionConverter.ConvertO(bodycontainerId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken> OperationsLiveSearch(Expression<Func<string>> instance, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyquery = null, Expression<Func<bool>> bodymaximizeClient = null, Expression<Func<bool>> bodyshowFirstResult = null)
        {
            var apiCallPath = String.Format("/{0}/operations/live/search", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodyquery != null)
            {
                body["query"] = ExpressionConverter.ConvertO(bodyquery);
                bodypropCount++;
            }

            if (bodymaximizeClient != null)
            {
                body["maximizeClient"] = ExpressionConverter.ConvertO(bodymaximizeClient);
                bodypropCount++;
            }

            if (bodyshowFirstResult != null)
            {
                body["showFirstResult"] = ExpressionConverter.ConvertO(bodyshowFirstResult);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IWorkflowAction Echo(Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/{0}/operations/echo", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetContainerResponse> ResourcesContainerById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/container/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContainerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentResponse> ResourcesDocumentById(Expression<Func<string>> instance, Expression<Func<string>> id, Expression<Func<int>> version = null)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (version != null)
                callPayload.Queries["version"] = ExpressionConverter.Convert(version);
            return new ApiConnectionAction<GetDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetEnrichedResponseResponse> ResourcesArtefactById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/artefact/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetEnrichedResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PutArtefactResponse> PublishArtefact(Expression<Func<string>> instance, Expression<Func<string>> id, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyprimaryResponse = null, Expression<Func<int>> bodypanvivaDocumentVersion = null, Expression<Func<ArtefactSection[]>> bodycontent = null, Expression<Func<TaggedSectionWithContentViewModel[]>> bodytaggedSections = null, Expression<Func<int>> bodycategoryid = null, Expression<Func<string>> bodypanvivaDocumentId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyprimaryQuery = null, Expression<Func<QueryVariationViewModel[]>> bodyqueryVariations = null, Expression<Func<ResponseVariationViewModel[]>> bodyresponseVariations = null)
        {
            var apiCallPath = String.Format("/{0}/resources/artefact/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyprimaryResponse != null)
            {
                body["primaryResponse"] = ExpressionConverter.ConvertO(bodyprimaryResponse);
                bodypropCount++;
            }

            if (bodypanvivaDocumentVersion != null)
            {
                body["panvivaDocumentVersion"] = ExpressionConverter.ConvertO(bodypanvivaDocumentVersion);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodytaggedSections != null)
            {
                body["taggedSections"] = ExpressionConverter.ConvertO(bodytaggedSections);
                bodypropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            if (bodycategoryid != null)
            {
                categoryObject["id"] = ExpressionConverter.ConvertO(bodycategoryid);
                categoryObjectpropCount++;
            }

            if (categoryObjectpropCount > 0)
            {
                body["category"] = categoryObject;
                bodypropCount++;
            }

            if (bodypanvivaDocumentId != null)
            {
                body["panvivaDocumentId"] = ExpressionConverter.ConvertO(bodypanvivaDocumentId);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyprimaryQuery != null)
            {
                body["primaryQuery"] = ExpressionConverter.ConvertO(bodyprimaryQuery);
                bodypropCount++;
            }

            if (bodyqueryVariations != null)
            {
                body["queryVariations"] = ExpressionConverter.ConvertO(bodyqueryVariations);
                bodypropCount++;
            }

            var metaDataObject = new JObject();
            var metaDataObjectpropCount = 0;
            if (metaDataObjectpropCount > 0)
            {
                body["metaData"] = metaDataObject;
                bodypropCount++;
            }

            if (bodyresponseVariations != null)
            {
                body["responseVariations"] = ExpressionConverter.ConvertO(bodyresponseVariations);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PutArtefactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentContainersResponse> ResourcesDocumentByIdContainers(Expression<Func<string>> instance, Expression<Func<int>> id, Expression<Func<int>> version = null)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}/containers", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (version != null)
                callPayload.Queries["version"] = ExpressionConverter.Convert(version);
            return new ApiConnectionAction<GetDocumentContainersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentContainerRelationshipsResponse> ResourcesDocumentContainersByIdRelationships(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}/containers/relationships", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentContainerRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentTranslationsResponse> ResourcesDocumentByIdTranslations(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}/translations", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentTranslationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFileResponse> ResourcesFileById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/file/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderResponse> ResourcesFolderById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderChildrenResponse> ResourcesFolderByIdChildren(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/{1}/children", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderChildrenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderTranslationsResponse> ResourcesFolderByIdTranslations(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/{1}/translations", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderTranslationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderRootResponse> ResourcesFolderRoot(Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/root", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderRootResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetImageResponse> ResourcesImageById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/image/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetImageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetArtefactCategoriesResponse> ResourcesArtefactCategoriesGet(Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/{0}/resources/artefactcategory", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetArtefactCategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PostArtefactCategoryResponse> ResourcesArtefactCategoryPost(Expression<Func<string>> instance, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = String.Format("/{0}/resources/artefactcategory", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostArtefactCategoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PostArtefactResponse> ResourcesCreateArtefact(Expression<Func<string>> instance, Expression<Func<bool>> isDraft = null, Expression<Func<string>> bodytitle = null, Expression<Func<ArtefactSection[]>> bodycontent = null, Expression<Func<ResponseVariationModel[]>> bodyvariations = null, Expression<Func<int>> bodycategoryid = null, Expression<Func<string>> bodyprimaryQuery = null, Expression<Func<QueryVariationModel[]>> bodyqueryVariations = null, Expression<Func<int>> bodypanvivaDocumentId = null, Expression<Func<int>> bodypanvivaDocumentVersion = null)
        {
            var apiCallPath = String.Format("/{0}/resources/artefact", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["isDraft"] = Convert.ToString(false);
            if (isDraft != null)
                callPayload.Queries["isDraft"] = ExpressionConverter.Convert(isDraft);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodycontent != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
            }

            if (bodyvariations != null)
            {
                body["variations"] = ExpressionConverter.ConvertO(bodyvariations);
                bodypropCount++;
            }

            var categoryObject = new JObject();
            var categoryObjectpropCount = 0;
            if (bodycategoryid != null)
            {
                categoryObject["id"] = ExpressionConverter.ConvertO(bodycategoryid);
                categoryObjectpropCount++;
            }

            if (categoryObjectpropCount > 0)
            {
                body["category"] = categoryObject;
                bodypropCount++;
            }

            if (bodyprimaryQuery != null)
            {
                body["primaryQuery"] = ExpressionConverter.ConvertO(bodyprimaryQuery);
                bodypropCount++;
            }

            if (bodyqueryVariations != null)
            {
                body["queryVariations"] = ExpressionConverter.ConvertO(bodyqueryVariations);
                bodypropCount++;
            }

            if (bodypanvivaDocumentId != null)
            {
                body["panvivaDocumentId"] = ExpressionConverter.ConvertO(bodypanvivaDocumentId);
                bodypropCount++;
            }

            if (bodypanvivaDocumentVersion != null)
            {
                body["panvivaDocumentVersion"] = ExpressionConverter.ConvertO(bodypanvivaDocumentVersion);
                bodypropCount++;
            }

            var metaDataObject = new JObject();
            var metaDataObjectpropCount = 0;
            if (metaDataObjectpropCount > 0)
            {
                body["metaData"] = metaDataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PostArtefactResponse>(callPayload);
        }
    }

    public class UplandpanvivausTriggers([ConnectionName] string connectionId)
    {
    }

    public class OperationsSearchResponse
    {
        [JsonProperty("results")]
        public OperationsSearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("links")]
        public OperationsSearchResponseLinksTypeItem[] Links { get; set; }
    }

    public class OperationsSearchResponseResultsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("matchedFields")]
        public string[] MatchedFields { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("links")]
        public OperationsSearchResponseResultsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class OperationsSearchResponseResultsTypeItemLinksTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class OperationsSearchResponseLinksTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum changedWhenInput
    {
        NotProvided,
        [EnumMember(Value = "today")]
        Today,
        [EnumMember(Value = "yesterday")]
        Yesterday,
        [EnumMember(Value = "thisWeek")]
        ThisWeek,
        [EnumMember(Value = "lastWeek")]
        LastWeek,
        [EnumMember(Value = "thisMonth")]
        ThisMonth,
        [EnumMember(Value = "lastMonth")]
        LastMonth,
        [EnumMember(Value = "thisYear")]
        ThisYear,
        [EnumMember(Value = "lastYear")]
        LastYear
    }

    public class GetEnrichedSearchArtefactResponse
    {
        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        [JsonProperty("results")]
        public EnrichedSearchResult[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class Facet
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("groups")]
        public StringInt64NullableKeyValuePair[] Groups { get; set; }
    }

    public class StringInt64NullableKeyValuePair
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class EnrichedSearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

        [JsonProperty("simpleContent")]
        public string SimpleContent { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("metaData")]
        public JToken MetaData { get; set; }

        [JsonProperty("searchScore")]
        public double SearchScore { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("queryVariations")]
        public QueryVariation[] QueryVariations { get; set; }

        [JsonProperty("primaryQuery")]
        public string PrimaryQuery { get; set; }

        [JsonProperty("panvivaDocumentId")]
        public int PanvivaDocumentId { get; set; }

        [JsonProperty("panvivaDocumentVersion")]
        public int PanvivaDocumentVersion { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("highlights")]
        public Highlights Highlights { get; set; }
    }

    public class ResponseSection
    {
        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("resourceLocation")]
        public string ResourceLocation { get; set; }
    }

    public class Category
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Link
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class QueryVariation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class Highlights
    {
        [JsonProperty("primaryQuery")]
        public string PrimaryQuery { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetContainerResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class GetDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("release")]
        public int Release { get; set; }

        [JsonProperty("released")]
        public bool Released { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("training")]
        public Training Training { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("cshKeywords")]
        public string[] CshKeywords { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("reusableContent")]
        public bool ReusableContent { get; set; }

        [JsonProperty("changeNote")]
        public string ChangeNote { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class Tag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Training
    {
        [JsonProperty("failureFeedback")]
        public string FailureFeedback { get; set; }

        [JsonProperty("forcePageSequence")]
        public bool ForcePageSequence { get; set; }

        [JsonProperty("forceQuestionSequence")]
        public bool ForceQuestionSequence { get; set; }

        [JsonProperty("passingScore")]
        public int PassingScore { get; set; }

        [JsonProperty("successFeedback")]
        public string SuccessFeedback { get; set; }
    }

    public class GetEnrichedResponseResponse
    {
        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

        [JsonProperty("simpleContent")]
        public string SimpleContent { get; set; }

        [JsonProperty("variations")]
        public EnrichedResponseVariation[] Variations { get; set; }

        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("primaryQuery")]
        public string PrimaryQuery { get; set; }

        [JsonProperty("queryVariations")]
        public QueryVariation[] QueryVariations { get; set; }

        [JsonProperty("panvivaDocumentId")]
        public int PanvivaDocumentId { get; set; }

        [JsonProperty("panvivaDocumentVersion")]
        public int PanvivaDocumentVersion { get; set; }

        [JsonProperty("metaData")]
        public JToken MetaData { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }
    }

    public class EnrichedResponseVariation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

        [JsonProperty("simpleContent")]
        public string SimpleContent { get; set; }

        [JsonProperty("channels")]
        public Channel[] Channels { get; set; }
    }

    public class Channel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PutArtefactResponse
    {
        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ArtefactSection
    {
        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("resourceLocation")]
        public string ResourceLocation { get; set; }
    }

    public class TaggedSectionWithContentViewModel
    {
        [JsonProperty("sectionId")]
        public string SectionId { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class QueryVariationViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class ResponseVariationViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("channels")]
        public ChannelViewModel[] Channels { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ChannelViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetDocumentContainersResponse
    {
        [JsonProperty("containers")]
        public Container[] Containers { get; set; }
    }

    public class Container
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class GetDocumentContainerRelationshipsResponse
    {
        [JsonProperty("relationships")]
        public ContainerRelationship[] Relationships { get; set; }
    }

    public class ContainerRelationship
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("taskFlow")]
        public string TaskFlow { get; set; }
    }

    public class GetDocumentTranslationsResponse
    {
        [JsonProperty("translations")]
        public Document[] Translations { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }
    }

    public class Document
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("release")]
        public int Release { get; set; }

        [JsonProperty("released")]
        public bool Released { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("training")]
        public Training Training { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("cshKeywords")]
        public string[] CshKeywords { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("reusableContent")]
        public bool ReusableContent { get; set; }

        [JsonProperty("changeNote")]
        public string ChangeNote { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class GetFileResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("release")]
        public int Release { get; set; }

        [JsonProperty("released")]
        public bool Released { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("cshKeywords")]
        public string[] CshKeywords { get; set; }

        [JsonProperty("changeNote")]
        public string ChangeNote { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }
    }

    public class GetFolderResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class GetFolderChildrenResponse
    {
        [JsonProperty("children")]
        public Resource[] Children { get; set; }
    }

    public class Resource
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetFolderTranslationsResponse
    {
        [JsonProperty("translations")]
        public Folder[] Translations { get; set; }
    }

    public class Folder
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class GetFolderRootResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class GetImageResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class GetArtefactCategoriesResponse
    {
        [JsonProperty("categories")]
        public ArtefactCategory[] Categories { get; set; }
    }

    public class ArtefactCategory
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }

    public class PostArtefactCategoryResponse
    {
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }

    public class PostArtefactResponse
    {
        [JsonProperty("hasErrors")]
        public bool HasErrors { get; set; }

        [JsonProperty("errors")]
        public string[] Errors { get; set; }

        [JsonProperty("responseId")]
        public string ResponseId { get; set; }
    }

    public class ResponseVariationModel
    {
        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

        [JsonProperty("channels")]
        public Channel[] Channels { get; set; }
    }

    public class QueryVariationModel
    {
        [JsonProperty("query")]
        public string Query { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Uplandpanvivaus;

    public partial class WorkflowManagedActions
    {
        public UplandpanvivausActions Uplandpanvivaus(string connectionId) => new UplandpanvivausActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UplandpanvivausTriggers Uplandpanvivaus(string connectionId) => new UplandpanvivausTriggers(connectionId);
    }
}