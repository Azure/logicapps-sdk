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
        public IBodyWorkflowAction<OperationsSearchResponse> OperationsSearch([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> term, [WorkflowExpression] Func<int> pageOffset = null, [WorkflowExpression] Func<int> pageLimit = null, [WorkflowExpression] Func<changedWhenInput> changedWhen = null, [WorkflowExpression] Func<int> directParentFolderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = SourceExpressionConverter.ConvertO(term);
                callPayload.Queries["pageOffset"] = Convert.ToString(0);
                if (pageOffset != null)
                    callPayload.Queries["pageOffset"] = SourceExpressionConverter.ConvertO(pageOffset);
                callPayload.Queries["pageLimit"] = Convert.ToString(20);
                if (pageLimit != null)
                    callPayload.Queries["pageLimit"] = SourceExpressionConverter.ConvertO(pageLimit);
                callPayload.Queries["changedWhen"] = Convert.ToString("NotProvided");
                if (changedWhen != null)
                    callPayload.Queries["changedWhen"] = SourceExpressionConverter.Convert(changedWhen);
                if (directParentFolderId != null)
                    callPayload.Queries["directParentFolderId"] = SourceExpressionConverter.ConvertO(directParentFolderId);
                return callPayload;
            }

            return new ApiConnectionAction<OperationsSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetEnrichedSearchArtefactResponse> OperationsArtefactNls([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> simplequery = null, [WorkflowExpression] Func<string> advancedquery = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> channel = null, [WorkflowExpression] Func<int> pageOffset = null, [WorkflowExpression] Func<int> pageLimit = null, [WorkflowExpression] Func<string> facet = null, [WorkflowExpression] Func<string> highlightTags = null)
        {
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
                if (highlightTags != null)
                    callPayload.Queries["highlightTags"] = SourceExpressionConverter.ConvertO(highlightTags);
                return callPayload;
            }

            return new ApiConnectionAction<GetEnrichedSearchArtefactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken> OperationsLiveCsh([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bool> bodyshowFirstResult = null, [WorkflowExpression] Func<bool> bodymaximizeClient = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/live/csh", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                    bodypropCount++;
                }

                if (bodyshowFirstResult != null)
                {
                    body["showFirstResult"] = SourceExpressionConverter.ConvertToken(bodyshowFirstResult);
                    bodypropCount++;
                }

                if (bodymaximizeClient != null)
                {
                    body["maximizeClient"] = SourceExpressionConverter.ConvertToken(bodymaximizeClient);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken> OperationsLiveDocument([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<bool> bodymaximizeClient = null, [WorkflowExpression] Func<string> bodycontainerId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/live/document", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodymaximizeClient != null)
                {
                    body["maximizeClient"] = SourceExpressionConverter.ConvertToken(bodymaximizeClient);
                    bodypropCount++;
                }

                if (bodycontainerId != null)
                {
                    body["containerId"] = SourceExpressionConverter.ConvertToken(bodycontainerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken> OperationsLiveSearch([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<string> bodyquery = null, [WorkflowExpression] Func<bool> bodymaximizeClient = null, [WorkflowExpression] Func<bool> bodyshowFirstResult = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/live/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                    bodypropCount++;
                }

                if (bodymaximizeClient != null)
                {
                    body["maximizeClient"] = SourceExpressionConverter.ConvertToken(bodymaximizeClient);
                    bodypropCount++;
                }

                if (bodyshowFirstResult != null)
                {
                    body["showFirstResult"] = SourceExpressionConverter.ConvertToken(bodyshowFirstResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IWorkflowAction Echo([WorkflowExpression] Func<string> instance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/operations/echo", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetContainerResponse> ResourcesContainerById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/container/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContainerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentResponse> ResourcesDocumentById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> version = null)
        {
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetEnrichedResponseResponse> ResourcesArtefactById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefact/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetEnrichedResponseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PutArtefactResponse> PublishArtefact([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyprimaryResponse = null, [WorkflowExpression] Func<int> bodypanvivaDocumentVersion = null, [WorkflowExpression] Func<ArtefactSection[]> bodycontent = null, [WorkflowExpression] Func<TaggedSectionWithContentViewModel[]> bodytaggedSections = null, [WorkflowExpression] Func<int> bodycategoryid = null, [WorkflowExpression] Func<string> bodypanvivaDocumentId = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyprimaryQuery = null, [WorkflowExpression] Func<QueryVariationViewModel[]> bodyqueryVariations = null, [WorkflowExpression] Func<ResponseVariationViewModel[]> bodyresponseVariations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefact/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyprimaryResponse != null)
                {
                    body["primaryResponse"] = SourceExpressionConverter.ConvertToken(bodyprimaryResponse);
                    bodypropCount++;
                }

                if (bodypanvivaDocumentVersion != null)
                {
                    body["panvivaDocumentVersion"] = SourceExpressionConverter.ConvertToken(bodypanvivaDocumentVersion);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodytaggedSections != null)
                {
                    body["taggedSections"] = SourceExpressionConverter.ConvertToken(bodytaggedSections);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (bodycategoryid != null)
                {
                    categoryObject["id"] = SourceExpressionConverter.ConvertToken(bodycategoryid);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (bodypanvivaDocumentId != null)
                {
                    body["panvivaDocumentId"] = SourceExpressionConverter.ConvertToken(bodypanvivaDocumentId);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyprimaryQuery != null)
                {
                    body["primaryQuery"] = SourceExpressionConverter.ConvertToken(bodyprimaryQuery);
                    bodypropCount++;
                }

                if (bodyqueryVariations != null)
                {
                    body["queryVariations"] = SourceExpressionConverter.ConvertToken(bodyqueryVariations);
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
                    body["responseVariations"] = SourceExpressionConverter.ConvertToken(bodyresponseVariations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PutArtefactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentContainersResponse> ResourcesDocumentByIdContainers([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> version = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}/containers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (version != null)
                    callPayload.Queries["version"] = SourceExpressionConverter.ConvertO(version);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentContainersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentContainerRelationshipsResponse> ResourcesDocumentContainersByIdRelationships([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}/containers/relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentContainerRelationshipsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentTranslationsResponse> ResourcesDocumentByIdTranslations([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/document/{1}/translations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentTranslationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFileResponse> ResourcesFileById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/file/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderResponse> ResourcesFolderById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderChildrenResponse> ResourcesFolderByIdChildren([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/{1}/children", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderChildrenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderTranslationsResponse> ResourcesFolderByIdTranslations([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/{1}/translations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderTranslationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetFolderRootResponse> ResourcesFolderRoot([WorkflowExpression] Func<string> instance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/folder/root", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderRootResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetImageResponse> ResourcesImageById([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/image/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetArtefactCategoriesResponse> ResourcesArtefactCategoriesGet([WorkflowExpression] Func<string> instance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefactcategory", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetArtefactCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PostArtefactCategoryResponse> ResourcesArtefactCategory([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<string> bodyname = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefactcategory", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostArtefactCategoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PostArtefactResponse> ResourcesCreateArtefact([WorkflowExpression] Func<string> instance, [WorkflowExpression] Func<bool> isDraft = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<ArtefactSection[]> bodycontent = null, [WorkflowExpression] Func<ResponseVariationModel[]> bodyvariations = null, [WorkflowExpression] Func<int> bodycategoryid = null, [WorkflowExpression] Func<string> bodyprimaryQuery = null, [WorkflowExpression] Func<QueryVariationModel[]> bodyqueryVariations = null, [WorkflowExpression] Func<int> bodypanvivaDocumentId = null, [WorkflowExpression] Func<int> bodypanvivaDocumentVersion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/resources/artefact", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instance, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isDraft"] = Convert.ToString(false);
                if (isDraft != null)
                    callPayload.Queries["isDraft"] = SourceExpressionConverter.ConvertO(isDraft);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodyvariations != null)
                {
                    body["variations"] = SourceExpressionConverter.ConvertToken(bodyvariations);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (bodycategoryid != null)
                {
                    categoryObject["id"] = SourceExpressionConverter.ConvertToken(bodycategoryid);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (bodyprimaryQuery != null)
                {
                    body["primaryQuery"] = SourceExpressionConverter.ConvertToken(bodyprimaryQuery);
                    bodypropCount++;
                }

                if (bodyqueryVariations != null)
                {
                    body["queryVariations"] = SourceExpressionConverter.ConvertToken(bodyqueryVariations);
                    bodypropCount++;
                }

                if (bodypanvivaDocumentId != null)
                {
                    body["panvivaDocumentId"] = SourceExpressionConverter.ConvertToken(bodypanvivaDocumentId);
                    bodypropCount++;
                }

                if (bodypanvivaDocumentVersion != null)
                {
                    body["panvivaDocumentVersion"] = SourceExpressionConverter.ConvertToken(bodypanvivaDocumentVersion);
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
                return callPayload;
            }

            return new ApiConnectionAction<PostArtefactResponse>(BuildSourceInput);
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