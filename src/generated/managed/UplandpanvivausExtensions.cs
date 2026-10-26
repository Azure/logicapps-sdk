//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uplandpanvivaus
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UplandpanvivausActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<OperationsSearchResponse, ApiConnectionActionConfiguration> OperationsSearch(Expression<Func<string>> instance, Expression<Func<string>> term, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null, Expression<Func<changedWhenInput>> changedWhen = null, Expression<Func<int>> directParentFolderId = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_term = WorkflowExpression.Compile(term, nameof(term), required: true);
            var __workflow_pageOffset = WorkflowExpression.Compile(pageOffset, nameof(pageOffset), required: false);
            var __workflow_pageLimit = WorkflowExpression.Compile(pageLimit, nameof(pageLimit), required: false);
            var __workflow_changedWhen = WorkflowExpression.Compile(changedWhen, nameof(changedWhen), required: false);
            var __workflow_directParentFolderId = WorkflowExpression.Compile(directParentFolderId, nameof(directParentFolderId), required: false);
            return new DeferredBodyAction<OperationsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/search", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = ExpressionConverter.Convert(__workflow_term);
                callPayload.Queries["pageOffset"] = Convert.ToString(0);
                if (__workflow_pageOffset != null)
                    callPayload.Queries["pageOffset"] = ExpressionConverter.Convert(__workflow_pageOffset);
                callPayload.Queries["pageLimit"] = Convert.ToString(20);
                if (__workflow_pageLimit != null)
                    callPayload.Queries["pageLimit"] = ExpressionConverter.Convert(__workflow_pageLimit);
                callPayload.Queries["changedWhen"] = Convert.ToString("NotProvided");
                if (__workflow_changedWhen != null)
                    callPayload.Queries["changedWhen"] = ExpressionConverter.Convert(__workflow_changedWhen);
                if (__workflow_directParentFolderId != null)
                    callPayload.Queries["directParentFolderId"] = ExpressionConverter.Convert(__workflow_directParentFolderId);
                return new ApiConnectionAction<OperationsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetEnrichedSearchArtefactResponse, ApiConnectionActionConfiguration> OperationsArtefactNls(Expression<Func<string>> instance, Expression<Func<string>> simplequery = null, Expression<Func<string>> advancedquery = null, Expression<Func<string>> filter = null, Expression<Func<string>> channel = null, Expression<Func<int>> pageOffset = null, Expression<Func<int>> pageLimit = null, Expression<Func<string>> facet = null, Expression<Func<string>> highlightTags = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_simplequery = WorkflowExpression.Compile(simplequery, nameof(simplequery), required: false);
            var __workflow_advancedquery = WorkflowExpression.Compile(advancedquery, nameof(advancedquery), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_channel = WorkflowExpression.Compile(channel, nameof(channel), required: false);
            var __workflow_pageOffset = WorkflowExpression.Compile(pageOffset, nameof(pageOffset), required: false);
            var __workflow_pageLimit = WorkflowExpression.Compile(pageLimit, nameof(pageLimit), required: false);
            var __workflow_facet = WorkflowExpression.Compile(facet, nameof(facet), required: false);
            var __workflow_highlightTags = WorkflowExpression.Compile(highlightTags, nameof(highlightTags), required: false);
            return new DeferredBodyAction<GetEnrichedSearchArtefactResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_highlightTags != null)
                    callPayload.Queries["highlightTags"] = ExpressionConverter.Convert(__workflow_highlightTags);
                return new ApiConnectionAction<GetEnrichedSearchArtefactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> OperationsLiveCsh(Expression<Func<string>> instance, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyquery = null, Expression<Func<bool>> bodyshowFirstResult = null, Expression<Func<bool>> bodymaximizeClient = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodyshowFirstResult = WorkflowExpression.Compile(bodyshowFirstResult, nameof(bodyshowFirstResult), required: false);
            var __workflow_bodymaximizeClient = WorkflowExpression.Compile(bodymaximizeClient, nameof(bodymaximizeClient), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/live/csh", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                if (__workflow_bodyshowFirstResult != null)
                {
                    body["showFirstResult"] = ExpressionConverter.ConvertO(__workflow_bodyshowFirstResult);
                    bodypropCount++;
                }

                if (__workflow_bodymaximizeClient != null)
                {
                    body["maximizeClient"] = ExpressionConverter.ConvertO(__workflow_bodymaximizeClient);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> OperationsLiveDocument(Expression<Func<string>> instance, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodylocation = null, Expression<Func<bool>> bodymaximizeClient = null, Expression<Func<string>> bodycontainerId = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodymaximizeClient = WorkflowExpression.Compile(bodymaximizeClient, nameof(bodymaximizeClient), required: false);
            var __workflow_bodycontainerId = WorkflowExpression.Compile(bodycontainerId, nameof(bodycontainerId), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/live/document", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodymaximizeClient != null)
                {
                    body["maximizeClient"] = ExpressionConverter.ConvertO(__workflow_bodymaximizeClient);
                    bodypropCount++;
                }

                if (__workflow_bodycontainerId != null)
                {
                    body["containerId"] = ExpressionConverter.ConvertO(__workflow_bodycontainerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> OperationsLiveSearch(Expression<Func<string>> instance, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodyuserId = null, Expression<Func<string>> bodyquery = null, Expression<Func<bool>> bodymaximizeClient = null, Expression<Func<bool>> bodyshowFirstResult = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyusername = WorkflowExpression.Compile(bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            var __workflow_bodymaximizeClient = WorkflowExpression.Compile(bodymaximizeClient, nameof(bodymaximizeClient), required: false);
            var __workflow_bodyshowFirstResult = WorkflowExpression.Compile(bodyshowFirstResult, nameof(bodyshowFirstResult), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/live/search", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                if (__workflow_bodymaximizeClient != null)
                {
                    body["maximizeClient"] = ExpressionConverter.ConvertO(__workflow_bodymaximizeClient);
                    bodypropCount++;
                }

                if (__workflow_bodyshowFirstResult != null)
                {
                    body["showFirstResult"] = ExpressionConverter.ConvertO(__workflow_bodyshowFirstResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Echo(Expression<Func<string>> instance)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/operations/echo", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetEnrichedResponseResponse, ApiConnectionActionConfiguration> ResourcesArtefactById(Expression<Func<string>> instance, Expression<Func<string>> id)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetEnrichedResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefact/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEnrichedResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PutArtefactResponse, ApiConnectionActionConfiguration> PublishArtefact(Expression<Func<string>> instance, Expression<Func<string>> id, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyprimaryResponse = null, Expression<Func<int>> bodypanvivaDocumentVersion = null, Expression<Func<ArtefactSection[]>> bodycontent = null, Expression<Func<TaggedSectionWithContentViewModel[]>> bodytaggedSections = null, Expression<Func<int>> bodycategoryid = null, Expression<Func<string>> bodypanvivaDocumentId = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyprimaryQuery = null, Expression<Func<QueryVariationViewModel[]>> bodyqueryVariations = null, Expression<Func<ResponseVariationViewModel[]>> bodyresponseVariations = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyprimaryResponse = WorkflowExpression.Compile(bodyprimaryResponse, nameof(bodyprimaryResponse), required: false);
            var __workflow_bodypanvivaDocumentVersion = WorkflowExpression.Compile(bodypanvivaDocumentVersion, nameof(bodypanvivaDocumentVersion), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodytaggedSections = WorkflowExpression.Compile(bodytaggedSections, nameof(bodytaggedSections), required: false);
            var __workflow_bodycategoryid = WorkflowExpression.Compile(bodycategoryid, nameof(bodycategoryid), required: false);
            var __workflow_bodypanvivaDocumentId = WorkflowExpression.Compile(bodypanvivaDocumentId, nameof(bodypanvivaDocumentId), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyprimaryQuery = WorkflowExpression.Compile(bodyprimaryQuery, nameof(bodyprimaryQuery), required: false);
            var __workflow_bodyqueryVariations = WorkflowExpression.Compile(bodyqueryVariations, nameof(bodyqueryVariations), required: false);
            var __workflow_bodyresponseVariations = WorkflowExpression.Compile(bodyresponseVariations, nameof(bodyresponseVariations), required: false);
            return new DeferredBodyAction<PutArtefactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefact/{1}", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryResponse != null)
                {
                    body["primaryResponse"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryResponse);
                    bodypropCount++;
                }

                if (__workflow_bodypanvivaDocumentVersion != null)
                {
                    body["panvivaDocumentVersion"] = ExpressionConverter.ConvertO(__workflow_bodypanvivaDocumentVersion);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodytaggedSections != null)
                {
                    body["taggedSections"] = ExpressionConverter.ConvertO(__workflow_bodytaggedSections);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (__workflow_bodycategoryid != null)
                {
                    categoryObject["id"] = ExpressionConverter.ConvertO(__workflow_bodycategoryid);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (__workflow_bodypanvivaDocumentId != null)
                {
                    body["panvivaDocumentId"] = ExpressionConverter.ConvertO(__workflow_bodypanvivaDocumentId);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryQuery != null)
                {
                    body["primaryQuery"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryQuery);
                    bodypropCount++;
                }

                if (__workflow_bodyqueryVariations != null)
                {
                    body["queryVariations"] = ExpressionConverter.ConvertO(__workflow_bodyqueryVariations);
                    bodypropCount++;
                }

                var metaDataObject = new JObject();
                var metaDataObjectpropCount = 0;
                if (metaDataObjectpropCount > 0)
                {
                    body["metaData"] = metaDataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyresponseVariations != null)
                {
                    body["responseVariations"] = ExpressionConverter.ConvertO(__workflow_bodyresponseVariations);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PutArtefactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentContainersResponse, ApiConnectionActionConfiguration> ResourcesDocumentByIdContainers(Expression<Func<string>> instance, Expression<Func<int>> id, Expression<Func<int>> version = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            return new DeferredBodyAction<GetDocumentContainersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/document/{1}/containers", __workflow_instance.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                return new ApiConnectionAction<GetDocumentContainersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<GetDocumentContainerRelationshipsResponse, ApiConnectionActionConfiguration> ResourcesDocumentContainersByIdRelationships(Expression<Func<string>> instance, Expression<Func<int>> id)
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PostArtefactCategoryResponse, ApiConnectionActionConfiguration> ResourcesArtefactCategory(Expression<Func<string>> instance, Expression<Func<string>> bodyname = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<PostArtefactCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefactcategory", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostArtefactCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uplandpanvivaus")]
        public IBodyWorkflowAction<PostArtefactResponse, ApiConnectionActionConfiguration> ResourcesCreateArtefact(Expression<Func<string>> instance, Expression<Func<bool>> isDraft = null, Expression<Func<string>> bodytitle = null, Expression<Func<ArtefactSection[]>> bodycontent = null, Expression<Func<ResponseVariationModel[]>> bodyvariations = null, Expression<Func<int>> bodycategoryid = null, Expression<Func<string>> bodyprimaryQuery = null, Expression<Func<QueryVariationModel[]>> bodyqueryVariations = null, Expression<Func<int>> bodypanvivaDocumentId = null, Expression<Func<int>> bodypanvivaDocumentVersion = null)
        {
            var __workflow_instance = WorkflowExpression.Compile(instance, nameof(instance), required: true);
            var __workflow_isDraft = WorkflowExpression.Compile(isDraft, nameof(isDraft), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            var __workflow_bodyvariations = WorkflowExpression.Compile(bodyvariations, nameof(bodyvariations), required: false);
            var __workflow_bodycategoryid = WorkflowExpression.Compile(bodycategoryid, nameof(bodycategoryid), required: false);
            var __workflow_bodyprimaryQuery = WorkflowExpression.Compile(bodyprimaryQuery, nameof(bodyprimaryQuery), required: false);
            var __workflow_bodyqueryVariations = WorkflowExpression.Compile(bodyqueryVariations, nameof(bodyqueryVariations), required: false);
            var __workflow_bodypanvivaDocumentId = WorkflowExpression.Compile(bodypanvivaDocumentId, nameof(bodypanvivaDocumentId), required: false);
            var __workflow_bodypanvivaDocumentVersion = WorkflowExpression.Compile(bodypanvivaDocumentVersion, nameof(bodypanvivaDocumentVersion), required: false);
            return new DeferredBodyAction<PostArtefactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/resources/artefact", __workflow_instance.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isDraft"] = Convert.ToString(false);
                if (__workflow_isDraft != null)
                    callPayload.Queries["isDraft"] = ExpressionConverter.Convert(__workflow_isDraft);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (__workflow_bodyvariations != null)
                {
                    body["variations"] = ExpressionConverter.ConvertO(__workflow_bodyvariations);
                    bodypropCount++;
                }

                var categoryObject = new JObject();
                var categoryObjectpropCount = 0;
                if (__workflow_bodycategoryid != null)
                {
                    categoryObject["id"] = ExpressionConverter.ConvertO(__workflow_bodycategoryid);
                    categoryObjectpropCount++;
                }

                if (categoryObjectpropCount > 0)
                {
                    body["category"] = categoryObject;
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryQuery != null)
                {
                    body["primaryQuery"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryQuery);
                    bodypropCount++;
                }

                if (__workflow_bodyqueryVariations != null)
                {
                    body["queryVariations"] = ExpressionConverter.ConvertO(__workflow_bodyqueryVariations);
                    bodypropCount++;
                }

                if (__workflow_bodypanvivaDocumentId != null)
                {
                    body["panvivaDocumentId"] = ExpressionConverter.ConvertO(__workflow_bodypanvivaDocumentId);
                    bodypropCount++;
                }

                if (__workflow_bodypanvivaDocumentVersion != null)
                {
                    body["panvivaDocumentVersion"] = ExpressionConverter.ConvertO(__workflow_bodypanvivaDocumentVersion);
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
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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