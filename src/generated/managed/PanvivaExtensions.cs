//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Panviva
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PanvivaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetSearchResponse> OperationsSearch(Expression<Func<string>> instance, Expression<Func<string>> term, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null)
        {
            var apiCallPath = String.Format("/{0}/operations/search", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["term"] = ExpressionConverter.Convert(term);
            if (pageOffset != null)
                callPayload.Queries["pageOffset"] = ExpressionConverter.Convert(pageOffset);
            if (pageLimit != null)
                callPayload.Queries["pageLimit"] = ExpressionConverter.Convert(pageLimit);
            return new ApiConnectionAction<GetSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetSearchArtefactResponse> OperationsArtefactNls(Expression<Func<string>> instance, Expression<Func<string>> simplequery = null, Expression<Func<string>> advancedquery = null, Expression<Func<string>> filter = null, Expression<Func<string>> channel = null, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null, Expression<Func<string>> facet = null)
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
            return new ApiConnectionAction<GetSearchArtefactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken> OperationsLiveCsh(Expression<Func<string>> instance, Expression<Func<string>> postLiveCshRequestusername = null, Expression<Func<string>> postLiveCshRequestuserId = null, Expression<Func<string>> postLiveCshRequestquery = null, Expression<Func<bool>> postLiveCshRequestshowFirstResult = null, Expression<Func<bool>> postLiveCshRequestmaximizeClient = null)
        {
            var apiCallPath = String.Format("/{0}/operations/live/csh", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postLiveCshRequest = new JObject();
            var postLiveCshRequestpropCount = 0;
            if (postLiveCshRequestusername != null)
            {
                postLiveCshRequest["username"] = ExpressionConverter.ConvertO(postLiveCshRequestusername);
                postLiveCshRequestpropCount++;
            }

            if (postLiveCshRequestuserId != null)
            {
                postLiveCshRequest["userId"] = ExpressionConverter.ConvertO(postLiveCshRequestuserId);
                postLiveCshRequestpropCount++;
            }

            if (postLiveCshRequestquery != null)
            {
                postLiveCshRequest["query"] = ExpressionConverter.ConvertO(postLiveCshRequestquery);
                postLiveCshRequestpropCount++;
            }

            if (postLiveCshRequestshowFirstResult != null)
            {
                postLiveCshRequest["showFirstResult"] = ExpressionConverter.ConvertO(postLiveCshRequestshowFirstResult);
                postLiveCshRequestpropCount++;
            }

            if (postLiveCshRequestmaximizeClient != null)
            {
                postLiveCshRequest["maximizeClient"] = ExpressionConverter.ConvertO(postLiveCshRequestmaximizeClient);
                postLiveCshRequestpropCount++;
            }

            if (postLiveCshRequestpropCount > 0)
            {
                callPayload.Body = postLiveCshRequest;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken> OperationsLiveDocument(Expression<Func<string>> instance, Expression<Func<string>> postLiveDocumentRequestusername = null, Expression<Func<string>> postLiveDocumentRequestuserId = null, Expression<Func<string>> postLiveDocumentRequestid = null, Expression<Func<string>> postLiveDocumentRequestlocation = null, Expression<Func<bool>> postLiveDocumentRequestmaximizeClient = null)
        {
            var apiCallPath = String.Format("/{0}/operations/live/document", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postLiveDocumentRequest = new JObject();
            var postLiveDocumentRequestpropCount = 0;
            if (postLiveDocumentRequestusername != null)
            {
                postLiveDocumentRequest["username"] = ExpressionConverter.ConvertO(postLiveDocumentRequestusername);
                postLiveDocumentRequestpropCount++;
            }

            if (postLiveDocumentRequestuserId != null)
            {
                postLiveDocumentRequest["userId"] = ExpressionConverter.ConvertO(postLiveDocumentRequestuserId);
                postLiveDocumentRequestpropCount++;
            }

            if (postLiveDocumentRequestid != null)
            {
                postLiveDocumentRequest["id"] = ExpressionConverter.ConvertO(postLiveDocumentRequestid);
                postLiveDocumentRequestpropCount++;
            }

            if (postLiveDocumentRequestlocation != null)
            {
                postLiveDocumentRequest["location"] = ExpressionConverter.ConvertO(postLiveDocumentRequestlocation);
                postLiveDocumentRequestpropCount++;
            }

            if (postLiveDocumentRequestmaximizeClient != null)
            {
                postLiveDocumentRequest["maximizeClient"] = ExpressionConverter.ConvertO(postLiveDocumentRequestmaximizeClient);
                postLiveDocumentRequestpropCount++;
            }

            if (postLiveDocumentRequestpropCount > 0)
            {
                callPayload.Body = postLiveDocumentRequest;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken> OperationsLiveSearch(Expression<Func<string>> instance, Expression<Func<string>> postLiveSearchRequestusername = null, Expression<Func<string>> postLiveSearchRequestuserId = null, Expression<Func<string>> postLiveSearchRequestquery = null, Expression<Func<bool>> postLiveSearchRequestmaximizeClient = null, Expression<Func<bool>> postLiveSearchRequestshowFirstResult = null)
        {
            var apiCallPath = String.Format("/{0}/operations/live/search", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postLiveSearchRequest = new JObject();
            var postLiveSearchRequestpropCount = 0;
            if (postLiveSearchRequestusername != null)
            {
                postLiveSearchRequest["username"] = ExpressionConverter.ConvertO(postLiveSearchRequestusername);
                postLiveSearchRequestpropCount++;
            }

            if (postLiveSearchRequestuserId != null)
            {
                postLiveSearchRequest["userId"] = ExpressionConverter.ConvertO(postLiveSearchRequestuserId);
                postLiveSearchRequestpropCount++;
            }

            if (postLiveSearchRequestquery != null)
            {
                postLiveSearchRequest["query"] = ExpressionConverter.ConvertO(postLiveSearchRequestquery);
                postLiveSearchRequestpropCount++;
            }

            if (postLiveSearchRequestmaximizeClient != null)
            {
                postLiveSearchRequest["maximizeClient"] = ExpressionConverter.ConvertO(postLiveSearchRequestmaximizeClient);
                postLiveSearchRequestpropCount++;
            }

            if (postLiveSearchRequestshowFirstResult != null)
            {
                postLiveSearchRequest["showFirstResult"] = ExpressionConverter.ConvertO(postLiveSearchRequestshowFirstResult);
                postLiveSearchRequestpropCount++;
            }

            if (postLiveSearchRequestpropCount > 0)
            {
                callPayload.Body = postLiveSearchRequest;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetContainerResponse> ResourcesContainerById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/container/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContainerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentResponse> ResourcesDocumentById(Expression<Func<string>> instance, Expression<Func<string>> id, Expression<Func<int>> version = null)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (version != null)
                callPayload.Queries["version"] = ExpressionConverter.Convert(version);
            return new ApiConnectionAction<GetDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetResponseResponse> ResourcesArtefactById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/artefact/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetResponseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentContainersResponse> ResourcesDocumentByIdContainers(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}/containers", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentContainersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentContainerRelationshipsResponse> ResourcesDocumentByIdContainersRelationships(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}/containers/relationships", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentContainerRelationshipsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentTranslationsResponse> ResourcesDocumentByIdTranslations(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/document/{1}/translations", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetDocumentTranslationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFileResponse> ResourcesFileById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/file/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderResponse> ResourcesFolderById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderChildrenResponse> ResourcesFolderByIdChildren(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/{1}/children", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderChildrenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderTranslationsResponse> ResourcesFolderByIdTranslations(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/{1}/translations", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderTranslationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderRootResponse> ResourcesFolderRoot(Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/{0}/resources/folder/root", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetFolderRootResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetImageResponse> ResourcesImageById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/{0}/resources/image/{1}", ExpressionConverter.ConvertWithUrlEncoding(instance, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetImageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetArtefactCategoriesResponse> ResourcesArtefactCategoriesGet(Expression<Func<string>> instance)
        {
            var apiCallPath = String.Format("/{0}/resources/artefactcategory", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetArtefactCategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<PostArtefactCategoryResponse> ResourcesArtefactCategoryPost(Expression<Func<string>> instance, Expression<Func<string>> postArtefactCategoryRequestname = null)
        {
            var apiCallPath = String.Format("/{0}/resources/artefactcategory", ExpressionConverter.ConvertWithUrlEncoding(instance, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var postArtefactCategoryRequest = new JObject();
            var postArtefactCategoryRequestpropCount = 0;
            if (postArtefactCategoryRequestname != null)
            {
                postArtefactCategoryRequest["name"] = ExpressionConverter.ConvertO(postArtefactCategoryRequestname);
                postArtefactCategoryRequestpropCount++;
            }

            if (postArtefactCategoryRequestpropCount > 0)
            {
                callPayload.Body = postArtefactCategoryRequest;
            }

            return new ApiConnectionAction<PostArtefactCategoryResponse>(callPayload);
        }
    }

    public class PanvivaTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSearchResponse
    {
        [JsonProperty("results")]
        public ResourceSearchResult[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
    }

    public class ResourceSearchResult
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("matchedFields")]
        public string[] MatchedFields { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }
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

    public class GetSearchArtefactResponse
    {
        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        [JsonProperty("results")]
        public SearchResult[] Results { get; set; }

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

    public class SearchResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

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
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }
    }

    public class QueryVariation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
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

    public class GetResponseResponse
    {
        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

        [JsonProperty("variations")]
        public ResponseVariation[] Variations { get; set; }

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

    public class ResponseVariation
    {
        [JsonProperty("content")]
        public ResponseSection[] Content { get; set; }

        [JsonProperty("channels")]
        public Channel[] Channels { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }
    }

    public class Channel
    {
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Panviva;

    public partial class WorkflowManagedActions
    {
        public PanvivaActions Panviva(string connectionId) => new PanvivaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PanvivaTriggers Panviva(string connectionId) => new PanvivaTriggers(connectionId);
    }
}