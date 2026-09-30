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
        public IBodyWorkflowAction<GetSearchResponse> OperationsSearch([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> term, [WorkflowExpression] Func<int> pageOffset = null, [WorkflowExpression] Func<int> pageLimit = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(term, nameof(term), required: true);
            SourceExpression.Validate(pageOffset, nameof(pageOffset), required: false);
            SourceExpression.Validate(pageLimit, nameof(pageLimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = SourceExpressionConverter.ConvertO(term);
                if (pageOffset != null)
                    callPayload.Queries["pageOffset"] = SourceExpressionConverter.ConvertO(pageOffset);
                if (pageLimit != null)
                    callPayload.Queries["pageLimit"] = SourceExpressionConverter.ConvertO(pageLimit);
                return callPayload;
            }

            return new ApiConnectionAction<GetSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetSearchArtefactResponse> OperationsArtefactNls([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> simplequery = null, [WorkflowExpression] Func<string> advancedquery = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> channel = null, [WorkflowExpression] Func<int> pageOffset = null, [WorkflowExpression] Func<int> pageLimit = null, [WorkflowExpression] Func<string> facet = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(simplequery, nameof(simplequery), required: false);
            SourceExpression.Validate(advancedquery, nameof(advancedquery), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(channel, nameof(channel), required: false);
            SourceExpression.Validate(pageOffset, nameof(pageOffset), required: false);
            SourceExpression.Validate(pageLimit, nameof(pageLimit), required: false);
            SourceExpression.Validate(facet, nameof(facet), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/artefact/nls", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (simplequery != null)
                    callPayload.Queries["simplequery"] = SourceExpressionConverter.ConvertO(simplequery);
                if (advancedquery != null)
                    callPayload.Queries["advancedquery"] = SourceExpressionConverter.ConvertO(advancedquery);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (channel != null)
                    callPayload.Queries["channel"] = SourceExpressionConverter.ConvertO(channel);
                if (pageOffset != null)
                    callPayload.Queries["pageOffset"] = SourceExpressionConverter.ConvertO(pageOffset);
                if (pageLimit != null)
                    callPayload.Queries["pageLimit"] = SourceExpressionConverter.ConvertO(pageLimit);
                if (facet != null)
                    callPayload.Queries["facet"] = SourceExpressionConverter.ConvertO(facet);
                return callPayload;
            }

            return new ApiConnectionAction<GetSearchArtefactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken> OperationsLiveCsh([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> postLiveCshRequestusername = null, [WorkflowExpression] Func<string> postLiveCshRequestuserId = null, [WorkflowExpression] Func<string> postLiveCshRequestquery = null, [WorkflowExpression] Func<bool> postLiveCshRequestshowFirstResult = null, [WorkflowExpression] Func<bool> postLiveCshRequestmaximizeClient = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(postLiveCshRequestusername, nameof(postLiveCshRequestusername), required: false);
            SourceExpression.Validate(postLiveCshRequestuserId, nameof(postLiveCshRequestuserId), required: false);
            SourceExpression.Validate(postLiveCshRequestquery, nameof(postLiveCshRequestquery), required: false);
            SourceExpression.Validate(postLiveCshRequestshowFirstResult, nameof(postLiveCshRequestshowFirstResult), required: false);
            SourceExpression.Validate(postLiveCshRequestmaximizeClient, nameof(postLiveCshRequestmaximizeClient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/live/csh", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postLiveCshRequest = new JObject();
                var postLiveCshRequestpropCount = 0;
                if (postLiveCshRequestusername != null)
                {
                    postLiveCshRequest["username"] = SourceExpressionConverter.ConvertToken(postLiveCshRequestusername);
                    postLiveCshRequestpropCount++;
                }

                if (postLiveCshRequestuserId != null)
                {
                    postLiveCshRequest["userId"] = SourceExpressionConverter.ConvertToken(postLiveCshRequestuserId);
                    postLiveCshRequestpropCount++;
                }

                if (postLiveCshRequestquery != null)
                {
                    postLiveCshRequest["query"] = SourceExpressionConverter.ConvertToken(postLiveCshRequestquery);
                    postLiveCshRequestpropCount++;
                }

                if (postLiveCshRequestshowFirstResult != null)
                {
                    postLiveCshRequest["showFirstResult"] = SourceExpressionConverter.ConvertToken(postLiveCshRequestshowFirstResult);
                    postLiveCshRequestpropCount++;
                }

                if (postLiveCshRequestmaximizeClient != null)
                {
                    postLiveCshRequest["maximizeClient"] = SourceExpressionConverter.ConvertToken(postLiveCshRequestmaximizeClient);
                    postLiveCshRequestpropCount++;
                }

                if (postLiveCshRequestpropCount > 0)
                {
                    callPayload.Body = postLiveCshRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken> OperationsLiveDocument([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> postLiveDocumentRequestusername = null, [WorkflowExpression] Func<string> postLiveDocumentRequestuserId = null, [WorkflowExpression] Func<string> postLiveDocumentRequestid = null, [WorkflowExpression] Func<string> postLiveDocumentRequestlocation = null, [WorkflowExpression] Func<bool> postLiveDocumentRequestmaximizeClient = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(postLiveDocumentRequestusername, nameof(postLiveDocumentRequestusername), required: false);
            SourceExpression.Validate(postLiveDocumentRequestuserId, nameof(postLiveDocumentRequestuserId), required: false);
            SourceExpression.Validate(postLiveDocumentRequestid, nameof(postLiveDocumentRequestid), required: false);
            SourceExpression.Validate(postLiveDocumentRequestlocation, nameof(postLiveDocumentRequestlocation), required: false);
            SourceExpression.Validate(postLiveDocumentRequestmaximizeClient, nameof(postLiveDocumentRequestmaximizeClient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/live/document", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postLiveDocumentRequest = new JObject();
                var postLiveDocumentRequestpropCount = 0;
                if (postLiveDocumentRequestusername != null)
                {
                    postLiveDocumentRequest["username"] = SourceExpressionConverter.ConvertToken(postLiveDocumentRequestusername);
                    postLiveDocumentRequestpropCount++;
                }

                if (postLiveDocumentRequestuserId != null)
                {
                    postLiveDocumentRequest["userId"] = SourceExpressionConverter.ConvertToken(postLiveDocumentRequestuserId);
                    postLiveDocumentRequestpropCount++;
                }

                if (postLiveDocumentRequestid != null)
                {
                    postLiveDocumentRequest["id"] = SourceExpressionConverter.ConvertToken(postLiveDocumentRequestid);
                    postLiveDocumentRequestpropCount++;
                }

                if (postLiveDocumentRequestlocation != null)
                {
                    postLiveDocumentRequest["location"] = SourceExpressionConverter.ConvertToken(postLiveDocumentRequestlocation);
                    postLiveDocumentRequestpropCount++;
                }

                if (postLiveDocumentRequestmaximizeClient != null)
                {
                    postLiveDocumentRequest["maximizeClient"] = SourceExpressionConverter.ConvertToken(postLiveDocumentRequestmaximizeClient);
                    postLiveDocumentRequestpropCount++;
                }

                if (postLiveDocumentRequestpropCount > 0)
                {
                    callPayload.Body = postLiveDocumentRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<JToken> OperationsLiveSearch([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> postLiveSearchRequestusername = null, [WorkflowExpression] Func<string> postLiveSearchRequestuserId = null, [WorkflowExpression] Func<string> postLiveSearchRequestquery = null, [WorkflowExpression] Func<bool> postLiveSearchRequestmaximizeClient = null, [WorkflowExpression] Func<bool> postLiveSearchRequestshowFirstResult = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(postLiveSearchRequestusername, nameof(postLiveSearchRequestusername), required: false);
            SourceExpression.Validate(postLiveSearchRequestuserId, nameof(postLiveSearchRequestuserId), required: false);
            SourceExpression.Validate(postLiveSearchRequestquery, nameof(postLiveSearchRequestquery), required: false);
            SourceExpression.Validate(postLiveSearchRequestmaximizeClient, nameof(postLiveSearchRequestmaximizeClient), required: false);
            SourceExpression.Validate(postLiveSearchRequestshowFirstResult, nameof(postLiveSearchRequestshowFirstResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/live/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postLiveSearchRequest = new JObject();
                var postLiveSearchRequestpropCount = 0;
                if (postLiveSearchRequestusername != null)
                {
                    postLiveSearchRequest["username"] = SourceExpressionConverter.ConvertToken(postLiveSearchRequestusername);
                    postLiveSearchRequestpropCount++;
                }

                if (postLiveSearchRequestuserId != null)
                {
                    postLiveSearchRequest["userId"] = SourceExpressionConverter.ConvertToken(postLiveSearchRequestuserId);
                    postLiveSearchRequestpropCount++;
                }

                if (postLiveSearchRequestquery != null)
                {
                    postLiveSearchRequest["query"] = SourceExpressionConverter.ConvertToken(postLiveSearchRequestquery);
                    postLiveSearchRequestpropCount++;
                }

                if (postLiveSearchRequestmaximizeClient != null)
                {
                    postLiveSearchRequest["maximizeClient"] = SourceExpressionConverter.ConvertToken(postLiveSearchRequestmaximizeClient);
                    postLiveSearchRequestpropCount++;
                }

                if (postLiveSearchRequestshowFirstResult != null)
                {
                    postLiveSearchRequest["showFirstResult"] = SourceExpressionConverter.ConvertToken(postLiveSearchRequestshowFirstResult);
                    postLiveSearchRequestpropCount++;
                }

                if (postLiveSearchRequestpropCount > 0)
                {
                    callPayload.Body = postLiveSearchRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetContainerResponse> ResourcesContainerById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/container/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContainerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentResponse> ResourcesDocumentById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> version = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(version, nameof(version), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (version != null)
                    callPayload.Queries["version"] = SourceExpressionConverter.ConvertO(version);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetResponseResponse> ResourcesArtefactById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefact/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetResponseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentContainersResponse> ResourcesDocumentByIdContainers([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}/containers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentContainersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentContainerRelationshipsResponse> ResourcesDocumentByIdContainersRelationships([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}/containers/relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentContainerRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetDocumentTranslationsResponse> ResourcesDocumentByIdTranslations([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}/translations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentTranslationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFileResponse> ResourcesFileById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/file/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderResponse> ResourcesFolderById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderChildrenResponse> ResourcesFolderByIdChildren([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/{1}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderChildrenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderTranslationsResponse> ResourcesFolderByIdTranslations([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/{1}/translations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderTranslationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetFolderRootResponse> ResourcesFolderRoot([WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/root", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderRootResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetImageResponse> ResourcesImageById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/image/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<GetArtefactCategoriesResponse> ResourcesArtefactCategoriesGet([WorkflowExpression] Func<string> instance)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefactcategory", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetArtefactCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "panviva")]
        public IBodyWorkflowAction<PostArtefactCategoryResponse> ResourcesArtefactCategory([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> postArtefactCategoryRequestname = null)
        {
            SourceExpression.Validate(instance, nameof(instance), required: true);
            SourceExpression.Validate(postArtefactCategoryRequestname, nameof(postArtefactCategoryRequestname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefactcategory", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var postArtefactCategoryRequest = new JObject();
                var postArtefactCategoryRequestpropCount = 0;
                if (postArtefactCategoryRequestname != null)
                {
                    postArtefactCategoryRequest["name"] = SourceExpressionConverter.ConvertToken(postArtefactCategoryRequestname);
                    postArtefactCategoryRequestpropCount++;
                }

                if (postArtefactCategoryRequestpropCount > 0)
                {
                    callPayload.Body = postArtefactCategoryRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostArtefactCategoryResponse>(BuildSourceInput);
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