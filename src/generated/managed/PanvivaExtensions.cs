//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Panviva
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PanvivaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetSearchResponse, ApiConnectionActionConfiguration> OperationsSearch(Expression<Func<string>> instance, Expression<Func<string>> term, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: true);
            var __workflow_pageOffset = WorkflowExpression.Compile(pageOffset, nameof(pageOffset), required: false);
            var __workflow_pageLimit = WorkflowExpression.Compile(pageLimit, nameof(pageLimit), required: false);
            return new DeferredBodyAction<GetSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/search", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = ExpressionConverter.Convert(__workflow_term);
                if (__workflow_pageOffset != null)
                    callPayload.Queries["pageOffset"] = ExpressionConverter.Convert(__workflow_pageOffset);
                if (__workflow_pageLimit != null)
                    callPayload.Queries["pageLimit"] = ExpressionConverter.Convert(__workflow_pageLimit);
                return new ApiConnectionAction<GetSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetSearchArtefactResponse, ApiConnectionActionConfiguration> OperationsArtefactNls(Expression<Func<string>> instance, Expression<Func<string>> simplequery = null, Expression<Func<string>> advancedquery = null, Expression<Func<string>> filter = null, Expression<Func<string>> channel = null, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null, Expression<Func<string>> facet = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_simplequery = WorkflowExpression.Compile(simplequery, nameof(simplequery), required: false);
            var __workflow_advancedquery = WorkflowExpression.Compile(advancedquery, nameof(advancedquery), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_channel = WorkflowExpression.Compile(channel, nameof(channel), required: false);
            var __workflow_pageOffset = WorkflowExpression.Compile(pageOffset, nameof(pageOffset), required: false);
            var __workflow_pageLimit = WorkflowExpression.Compile(pageLimit, nameof(pageLimit), required: false);
            var __workflow_facet = WorkflowExpression.Compile(facet, nameof(facet), required: false);
            return new DeferredBodyAction<GetSearchArtefactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/artefact/nls", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_simplequery != null)
                    callPayload.Queries["simplequery"] = ExpressionConverter.Convert(__workflow_simplequery);
                if (__workflow_advancedquery != null)
                    callPayload.Queries["advancedquery"] = ExpressionConverter.Convert(__workflow_advancedquery);
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_channel != null)
                    callPayload.Queries["channel"] = ExpressionConverter.Convert(__workflow_channel);
                if (__workflow_pageOffset != null)
                    callPayload.Queries["pageOffset"] = ExpressionConverter.Convert(__workflow_pageOffset);
                if (__workflow_pageLimit != null)
                    callPayload.Queries["pageLimit"] = ExpressionConverter.Convert(__workflow_pageLimit);
                if (__workflow_facet != null)
                    callPayload.Queries["facet"] = ExpressionConverter.Convert(__workflow_facet);
                return new ApiConnectionAction<GetSearchArtefactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> OperationsLiveCsh(Expression<Func<string>> instance, Expression<Func<OperationsLiveCshInput>> postLiveCshRequest = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_postLiveCshRequest = WorkflowExpression.Compile(postLiveCshRequest, nameof(postLiveCshRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/live/csh", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postLiveCshRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_postLiveCshRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> OperationsLiveDocument(Expression<Func<string>> instance, Expression<Func<OperationsLiveDocumentInput>> postLiveDocumentRequest = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_postLiveDocumentRequest = WorkflowExpression.Compile(postLiveDocumentRequest, nameof(postLiveDocumentRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/live/document", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postLiveDocumentRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_postLiveDocumentRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> OperationsLiveSearch(Expression<Func<string>> instance, Expression<Func<OperationsLiveSearchInput>> postLiveSearchRequest = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_postLiveSearchRequest = WorkflowExpression.Compile(postLiveSearchRequest, nameof(postLiveSearchRequest), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/live/search", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postLiveSearchRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_postLiveSearchRequest);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetContainerResponse, ApiConnectionActionConfiguration> ResourcesContainerById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetContainerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/container/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContainerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentResponse, ApiConnectionActionConfiguration> ResourcesDocumentById(Expression<Func<string>> instance, Expression<Func<string>> id, Expression<Func<int>> version = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            return new DeferredBodyAction<GetDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/document/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                return new ApiConnectionAction<GetDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetResponseResponse, ApiConnectionActionConfiguration> ResourcesArtefactById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefact/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentContainersResponse, ApiConnectionActionConfiguration> ResourcesDocumentByIdContainers(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentContainersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/document/{1}/containers", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentContainersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentContainerRelationshipsResponse, ApiConnectionActionConfiguration> ResourcesDocumentByIdContainersRelationships(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentContainerRelationshipsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/document/{1}/containers/relationships", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentContainerRelationshipsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentTranslationsResponse, ApiConnectionActionConfiguration> ResourcesDocumentByIdTranslations(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentTranslationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/document/{1}/translations", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDocumentTranslationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFileResponse, ApiConnectionActionConfiguration> ResourcesFileById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/file/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderResponse, ApiConnectionActionConfiguration> ResourcesFolderById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/folder/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderChildrenResponse, ApiConnectionActionConfiguration> ResourcesFolderByIdChildren(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFolderChildrenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/folder/{1}/children", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderChildrenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderTranslationsResponse, ApiConnectionActionConfiguration> ResourcesFolderByIdTranslations(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFolderTranslationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/folder/{1}/translations", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderTranslationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderRootResponse, ApiConnectionActionConfiguration> ResourcesFolderRoot(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetFolderRootResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/folder/root", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFolderRootResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetImageResponse, ApiConnectionActionConfiguration> ResourcesImageById(Expression<Func<string>> instance, Expression<Func<int>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/image/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetArtefactCategoriesResponse, ApiConnectionActionConfiguration> ResourcesArtefactCategoriesGet(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredBodyAction<GetArtefactCategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefactcategory", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetArtefactCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<PostArtefactCategoryResponse, ApiConnectionActionConfiguration> ResourcesArtefactCategory(Expression<Func<string>> instance, Expression<Func<ResourcesArtefactCategoryPostInput>> postArtefactCategoryRequest = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_postArtefactCategoryRequest = WorkflowExpression.Compile(postArtefactCategoryRequest, nameof(postArtefactCategoryRequest), required: false);
            return new DeferredBodyAction<PostArtefactCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefactcategory", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_postArtefactCategoryRequest != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_postArtefactCategoryRequest);
                return new ApiConnectionAction<PostArtefactCategoryResponse>(callPayload);
            });
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

    public class OperationsLiveCshInput
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("showFirstResult")]
        public bool? ShowFirstResult { get; set; }

        [JsonProperty("maximizeClient")]
        public bool? MaximizeClient { get; set; }
    }

    public class OperationsLiveDocumentInput
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("maximizeClient")]
        public bool? MaximizeClient { get; set; }
    }

    public class OperationsLiveSearchInput
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("maximizeClient")]
        public bool? MaximizeClient { get; set; }

        [JsonProperty("showFirstResult")]
        public bool? ShowFirstResult { get; set; }
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

    public class ResourcesArtefactCategoryPostInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
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