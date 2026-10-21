//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitedatafusionblu
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitedatafusionbluActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<ListTimeSeriesResponse> ListTimeSeries(Expression<Func<string>> project, Expression<Func<int>> limit = null, Expression<Func<bool>> includeMetadata = null, Expression<Func<string>> cursor = null, Expression<Func<string>> partition = null, Expression<Func<string>> assetIds = null, Expression<Func<string>> rootAssetIds = null, Expression<Func<string>> externalIdPrefix = null, Expression<Func<string>> accept = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_includeMetadata = WorkflowExpression.Compile(includeMetadata, nameof(includeMetadata), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_partition = WorkflowExpression.Compile(partition, nameof(partition), required: false);
            var __workflow_assetIds = WorkflowExpression.Compile(assetIds, nameof(assetIds), required: false);
            var __workflow_rootAssetIds = WorkflowExpression.Compile(rootAssetIds, nameof(rootAssetIds), required: false);
            var __workflow_externalIdPrefix = WorkflowExpression.Compile(externalIdPrefix, nameof(externalIdPrefix), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            return new DeferredBodyAction<ListTimeSeriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/projects/{0}/timeseries", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["includeMetadata"] = Convert.ToString(true);
                if (__workflow_includeMetadata != null)
                    callPayload.Queries["includeMetadata"] = ExpressionConverter.Convert(__workflow_includeMetadata);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(__workflow_partition);
                if (__workflow_assetIds != null)
                    callPayload.Queries["assetIds"] = ExpressionConverter.Convert(__workflow_assetIds);
                if (__workflow_rootAssetIds != null)
                    callPayload.Queries["rootAssetIds"] = ExpressionConverter.Convert(__workflow_rootAssetIds);
                if (__workflow_externalIdPrefix != null)
                    callPayload.Queries["externalIdPrefix"] = ExpressionConverter.Convert(__workflow_externalIdPrefix);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                return new ApiConnectionAction<ListTimeSeriesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<FilterTimeSeriesResponse> FilterTimeSeries(Expression<Func<string>> project, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyfiltername = null, Expression<Func<string>> bodyfilterunit = null, Expression<Func<bool>> bodyfilterisString = null, Expression<Func<bool>> bodyfilterisStep = null, Expression<Func<int[]>> bodyfilterassetIds = null, Expression<Func<string[]>> bodyfilterassetExternalIds = null, Expression<Func<int[]>> bodyfilterrootAssetIds = null, Expression<Func<bodyfilterassetSubtreeIdsInputItem[]>> bodyfilterassetSubtreeIds = null, Expression<Func<bodyfilterdataSetIdsInputItem[]>> bodyfilterdataSetIds = null, Expression<Func<string>> bodyfilterexternalIdPrefix = null, Expression<Func<int>> bodyfiltercreatedTimemax = null, Expression<Func<int>> bodyfiltercreatedTimemin = null, Expression<Func<int>> bodyfilterlastUpdatedTimemax = null, Expression<Func<int>> bodyfilterlastUpdatedTimemin = null, Expression<Func<int>> bodylimit = null, Expression<Func<string>> bodycursor = null, Expression<Func<string>> bodypartition = null, Expression<Func<bodysortInputItem[]>> bodysort = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyfiltername = WorkflowExpression.Compile(bodyfiltername, nameof(bodyfiltername), required: false);
            var __workflow_bodyfilterunit = WorkflowExpression.Compile(bodyfilterunit, nameof(bodyfilterunit), required: false);
            var __workflow_bodyfilterisString = WorkflowExpression.Compile(bodyfilterisString, nameof(bodyfilterisString), required: false);
            var __workflow_bodyfilterisStep = WorkflowExpression.Compile(bodyfilterisStep, nameof(bodyfilterisStep), required: false);
            var __workflow_bodyfilterassetIds = WorkflowExpression.Compile(bodyfilterassetIds, nameof(bodyfilterassetIds), required: false);
            var __workflow_bodyfilterassetExternalIds = WorkflowExpression.Compile(bodyfilterassetExternalIds, nameof(bodyfilterassetExternalIds), required: false);
            var __workflow_bodyfilterrootAssetIds = WorkflowExpression.Compile(bodyfilterrootAssetIds, nameof(bodyfilterrootAssetIds), required: false);
            var __workflow_bodyfilterassetSubtreeIds = WorkflowExpression.Compile(bodyfilterassetSubtreeIds, nameof(bodyfilterassetSubtreeIds), required: false);
            var __workflow_bodyfilterdataSetIds = WorkflowExpression.Compile(bodyfilterdataSetIds, nameof(bodyfilterdataSetIds), required: false);
            var __workflow_bodyfilterexternalIdPrefix = WorkflowExpression.Compile(bodyfilterexternalIdPrefix, nameof(bodyfilterexternalIdPrefix), required: false);
            var __workflow_bodyfiltercreatedTimemax = WorkflowExpression.Compile(bodyfiltercreatedTimemax, nameof(bodyfiltercreatedTimemax), required: false);
            var __workflow_bodyfiltercreatedTimemin = WorkflowExpression.Compile(bodyfiltercreatedTimemin, nameof(bodyfiltercreatedTimemin), required: false);
            var __workflow_bodyfilterlastUpdatedTimemax = WorkflowExpression.Compile(bodyfilterlastUpdatedTimemax, nameof(bodyfilterlastUpdatedTimemax), required: false);
            var __workflow_bodyfilterlastUpdatedTimemin = WorkflowExpression.Compile(bodyfilterlastUpdatedTimemin, nameof(bodyfilterlastUpdatedTimemin), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            var __workflow_bodycursor = WorkflowExpression.Compile(bodycursor, nameof(bodycursor), required: false);
            var __workflow_bodypartition = WorkflowExpression.Compile(bodypartition, nameof(bodypartition), required: false);
            var __workflow_bodysort = WorkflowExpression.Compile(bodysort, nameof(bodysort), required: false);
            return new DeferredBodyAction<FilterTimeSeriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/projects/{0}/timeseries/list", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfiltername != null)
                {
                    filterObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfiltername);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterunit != null)
                {
                    filterObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodyfilterunit);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterisString != null)
                {
                    filterObject["isString"] = ExpressionConverter.ConvertO(__workflow_bodyfilterisString);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterisStep != null)
                {
                    filterObject["isStep"] = ExpressionConverter.ConvertO(__workflow_bodyfilterisStep);
                    filterObjectpropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    filterObject["metadata"] = metadataObject;
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterassetIds != null)
                {
                    filterObject["assetIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterassetIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterassetExternalIds != null)
                {
                    filterObject["assetExternalIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterassetExternalIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterrootAssetIds != null)
                {
                    filterObject["rootAssetIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterrootAssetIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterassetSubtreeIds != null)
                {
                    filterObject["assetSubtreeIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterassetSubtreeIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterdataSetIds != null)
                {
                    filterObject["dataSetIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterdataSetIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterexternalIdPrefix != null)
                {
                    filterObject["externalIdPrefix"] = ExpressionConverter.ConvertO(__workflow_bodyfilterexternalIdPrefix);
                    filterObjectpropCount++;
                }

                var createdTimeObject = new JObject();
                var createdTimeObjectpropCount = 0;
                if (__workflow_bodyfiltercreatedTimemax != null)
                {
                    createdTimeObject["max"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedTimemax);
                    createdTimeObjectpropCount++;
                }

                if (__workflow_bodyfiltercreatedTimemin != null)
                {
                    createdTimeObject["min"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedTimemin);
                    createdTimeObjectpropCount++;
                }

                if (createdTimeObjectpropCount > 0)
                {
                    filterObject["createdTime"] = createdTimeObject;
                    filterObjectpropCount++;
                }

                var lastUpdatedTimeObject = new JObject();
                var lastUpdatedTimeObjectpropCount = 0;
                if (__workflow_bodyfilterlastUpdatedTimemax != null)
                {
                    lastUpdatedTimeObject["max"] = ExpressionConverter.ConvertO(__workflow_bodyfilterlastUpdatedTimemax);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (__workflow_bodyfilterlastUpdatedTimemin != null)
                {
                    lastUpdatedTimeObject["min"] = ExpressionConverter.ConvertO(__workflow_bodyfilterlastUpdatedTimemin);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (lastUpdatedTimeObjectpropCount > 0)
                {
                    filterObject["lastUpdatedTime"] = lastUpdatedTimeObject;
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                var advancedFilterObject = new JObject();
                var advancedFilterObjectpropCount = 0;
                if (advancedFilterObjectpropCount > 0)
                {
                    body["advancedFilter"] = advancedFilterObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    if (__workflow_bodylimit != null)
                    {
                        body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 100;
                    bodypropCount++;
                }

                if (__workflow_bodycursor != null)
                {
                    body["cursor"] = ExpressionConverter.ConvertO(__workflow_bodycursor);
                    bodypropCount++;
                }

                if (__workflow_bodypartition != null)
                {
                    body["partition"] = ExpressionConverter.ConvertO(__workflow_bodypartition);
                    bodypropCount++;
                }

                if (__workflow_bodysort != null)
                {
                    body["sort"] = ExpressionConverter.ConvertO(__workflow_bodysort);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FilterTimeSeriesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<SearchTimeSeriesResponse> SearchTimeSeries(Expression<Func<string>> project, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyfiltername = null, Expression<Func<string>> bodyfilterunit = null, Expression<Func<bool>> bodyfilterisString = null, Expression<Func<bool>> bodyfilterisStep = null, Expression<Func<int[]>> bodyfilterassetIds = null, Expression<Func<string[]>> bodyfilterassetExternalIds = null, Expression<Func<int[]>> bodyfilterrootAssetIds = null, Expression<Func<bodyfilterassetSubtreeIdsInputItem[]>> bodyfilterassetSubtreeIds = null, Expression<Func<bodyfilterdataSetIdsInputItem[]>> bodyfilterdataSetIds = null, Expression<Func<string>> bodyfilterexternalIdPrefix = null, Expression<Func<int>> bodyfiltercreatedTimemax = null, Expression<Func<int>> bodyfiltercreatedTimemin = null, Expression<Func<int>> bodyfilterlastUpdatedTimemax = null, Expression<Func<int>> bodyfilterlastUpdatedTimemin = null, Expression<Func<string>> bodysearchname = null, Expression<Func<string>> bodysearchdescription = null, Expression<Func<string>> bodysearchquery = null, Expression<Func<int>> bodylimit = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyfiltername = WorkflowExpression.Compile(bodyfiltername, nameof(bodyfiltername), required: false);
            var __workflow_bodyfilterunit = WorkflowExpression.Compile(bodyfilterunit, nameof(bodyfilterunit), required: false);
            var __workflow_bodyfilterisString = WorkflowExpression.Compile(bodyfilterisString, nameof(bodyfilterisString), required: false);
            var __workflow_bodyfilterisStep = WorkflowExpression.Compile(bodyfilterisStep, nameof(bodyfilterisStep), required: false);
            var __workflow_bodyfilterassetIds = WorkflowExpression.Compile(bodyfilterassetIds, nameof(bodyfilterassetIds), required: false);
            var __workflow_bodyfilterassetExternalIds = WorkflowExpression.Compile(bodyfilterassetExternalIds, nameof(bodyfilterassetExternalIds), required: false);
            var __workflow_bodyfilterrootAssetIds = WorkflowExpression.Compile(bodyfilterrootAssetIds, nameof(bodyfilterrootAssetIds), required: false);
            var __workflow_bodyfilterassetSubtreeIds = WorkflowExpression.Compile(bodyfilterassetSubtreeIds, nameof(bodyfilterassetSubtreeIds), required: false);
            var __workflow_bodyfilterdataSetIds = WorkflowExpression.Compile(bodyfilterdataSetIds, nameof(bodyfilterdataSetIds), required: false);
            var __workflow_bodyfilterexternalIdPrefix = WorkflowExpression.Compile(bodyfilterexternalIdPrefix, nameof(bodyfilterexternalIdPrefix), required: false);
            var __workflow_bodyfiltercreatedTimemax = WorkflowExpression.Compile(bodyfiltercreatedTimemax, nameof(bodyfiltercreatedTimemax), required: false);
            var __workflow_bodyfiltercreatedTimemin = WorkflowExpression.Compile(bodyfiltercreatedTimemin, nameof(bodyfiltercreatedTimemin), required: false);
            var __workflow_bodyfilterlastUpdatedTimemax = WorkflowExpression.Compile(bodyfilterlastUpdatedTimemax, nameof(bodyfilterlastUpdatedTimemax), required: false);
            var __workflow_bodyfilterlastUpdatedTimemin = WorkflowExpression.Compile(bodyfilterlastUpdatedTimemin, nameof(bodyfilterlastUpdatedTimemin), required: false);
            var __workflow_bodysearchname = WorkflowExpression.Compile(bodysearchname, nameof(bodysearchname), required: false);
            var __workflow_bodysearchdescription = WorkflowExpression.Compile(bodysearchdescription, nameof(bodysearchdescription), required: false);
            var __workflow_bodysearchquery = WorkflowExpression.Compile(bodysearchquery, nameof(bodysearchquery), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<SearchTimeSeriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/projects/{0}/timeseries/search", __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfiltername != null)
                {
                    filterObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfiltername);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterunit != null)
                {
                    filterObject["unit"] = ExpressionConverter.ConvertO(__workflow_bodyfilterunit);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterisString != null)
                {
                    filterObject["isString"] = ExpressionConverter.ConvertO(__workflow_bodyfilterisString);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterisStep != null)
                {
                    filterObject["isStep"] = ExpressionConverter.ConvertO(__workflow_bodyfilterisStep);
                    filterObjectpropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    filterObject["metadata"] = metadataObject;
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterassetIds != null)
                {
                    filterObject["assetIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterassetIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterassetExternalIds != null)
                {
                    filterObject["assetExternalIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterassetExternalIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterrootAssetIds != null)
                {
                    filterObject["rootAssetIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterrootAssetIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterassetSubtreeIds != null)
                {
                    filterObject["assetSubtreeIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterassetSubtreeIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterdataSetIds != null)
                {
                    filterObject["dataSetIds"] = ExpressionConverter.ConvertO(__workflow_bodyfilterdataSetIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterexternalIdPrefix != null)
                {
                    filterObject["externalIdPrefix"] = ExpressionConverter.ConvertO(__workflow_bodyfilterexternalIdPrefix);
                    filterObjectpropCount++;
                }

                var createdTimeObject = new JObject();
                var createdTimeObjectpropCount = 0;
                if (__workflow_bodyfiltercreatedTimemax != null)
                {
                    createdTimeObject["max"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedTimemax);
                    createdTimeObjectpropCount++;
                }

                if (__workflow_bodyfiltercreatedTimemin != null)
                {
                    createdTimeObject["min"] = ExpressionConverter.ConvertO(__workflow_bodyfiltercreatedTimemin);
                    createdTimeObjectpropCount++;
                }

                if (createdTimeObjectpropCount > 0)
                {
                    filterObject["createdTime"] = createdTimeObject;
                    filterObjectpropCount++;
                }

                var lastUpdatedTimeObject = new JObject();
                var lastUpdatedTimeObjectpropCount = 0;
                if (__workflow_bodyfilterlastUpdatedTimemax != null)
                {
                    lastUpdatedTimeObject["max"] = ExpressionConverter.ConvertO(__workflow_bodyfilterlastUpdatedTimemax);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (__workflow_bodyfilterlastUpdatedTimemin != null)
                {
                    lastUpdatedTimeObject["min"] = ExpressionConverter.ConvertO(__workflow_bodyfilterlastUpdatedTimemin);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (lastUpdatedTimeObjectpropCount > 0)
                {
                    filterObject["lastUpdatedTime"] = lastUpdatedTimeObject;
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                var searchObject = new JObject();
                var searchObjectpropCount = 0;
                if (__workflow_bodysearchname != null)
                {
                    searchObject["name"] = ExpressionConverter.ConvertO(__workflow_bodysearchname);
                    searchObjectpropCount++;
                }

                if (__workflow_bodysearchdescription != null)
                {
                    searchObject["description"] = ExpressionConverter.ConvertO(__workflow_bodysearchdescription);
                    searchObjectpropCount++;
                }

                if (__workflow_bodysearchquery != null)
                {
                    searchObject["query"] = ExpressionConverter.ConvertO(__workflow_bodysearchquery);
                    searchObjectpropCount++;
                }

                if (searchObjectpropCount > 0)
                {
                    body["search"] = searchObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    if (__workflow_bodylimit != null)
                    {
                        body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 100;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchTimeSeriesResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IWorkflowAction QueryGraphQL(Expression<Func<string>> project, Expression<Func<string>> space, Expression<Func<string>> datamodel, Expression<Func<string>> version, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyquery = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_space = WorkflowExpression.Compile(space, nameof(space), required: true);
            var __workflow_datamodel = WorkflowExpression.Compile(datamodel, nameof(datamodel), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/projects/{0}/userapis/spaces/{1}/datamodels/{2}/versions/{3}/graphql", __workflow_project.WithUrlEncoding(1), __workflow_space.WithUrlEncoding(1), __workflow_datamodel.WithUrlEncoding(1), __workflow_version.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                    bodypropCount++;
                }

                var variablesObject = new JObject();
                var variablesObjectpropCount = 0;
                if (variablesObjectpropCount > 0)
                {
                    body["variables"] = variablesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class CognitedatafusionbluTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListTimeSeriesResponse
    {
        [JsonProperty("items")]
        public ListTimeSeriesResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("nextCursor")]
        public string NextCursor { get; set; }
    }

    public class ListTimeSeriesResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isString")]
        public bool IsString { get; set; }

        [JsonProperty("isStep")]
        public bool IsStep { get; set; }

        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public int LastUpdatedTime { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public ListTimeSeriesResponseItemsTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("assetId")]
        public int AssetId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("securityCategories")]
        public int[] SecurityCategories { get; set; }

        [JsonProperty("dataSetId")]
        public int DataSetId { get; set; }
    }

    public class ListTimeSeriesResponseItemsTypeItemMetadataType
    {
        [JsonProperty("tempord")]
        public string Tempord { get; set; }

        [JsonProperty("eiusmod_0_3")]
        public string Eiusmod03 { get; set; }

        [JsonProperty("auteb")]
        public string Auteb { get; set; }
    }

    public class FilterTimeSeriesResponse
    {
        [JsonProperty("items")]
        public FilterTimeSeriesResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("nextCursor")]
        public string NextCursor { get; set; }
    }

    public class FilterTimeSeriesResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isString")]
        public bool IsString { get; set; }

        [JsonProperty("isStep")]
        public bool IsStep { get; set; }

        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public int LastUpdatedTime { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public FilterTimeSeriesResponseItemsTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("assetId")]
        public int AssetId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("securityCategories")]
        public int[] SecurityCategories { get; set; }

        [JsonProperty("dataSetId")]
        public int DataSetId { get; set; }
    }

    public class FilterTimeSeriesResponseItemsTypeItemMetadataType
    {
        [JsonProperty("tempord")]
        public string Tempord { get; set; }

        [JsonProperty("eiusmod_0_3")]
        public string Eiusmod03 { get; set; }

        [JsonProperty("auteb")]
        public string Auteb { get; set; }
    }

    public class bodyfilterassetSubtreeIdsInputItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class bodyfilterdataSetIdsInputItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class bodysortInputItem
    {
        [JsonProperty("property")]
        public string[] Property { get; set; }

        [JsonProperty("order")]
        public bodysortInputItemOrderType Order { get; set; }

        [JsonProperty("nulls")]
        public bodysortInputItemNullsType Nulls { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortInputItemOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysortInputItemNullsType
    {
        [EnumMember(Value = "first")]
        First,
        [EnumMember(Value = "last")]
        Last,
        [EnumMember(Value = "auto")]
        Auto
    }

    public class SearchTimeSeriesResponse
    {
        [JsonProperty("items")]
        public SearchTimeSeriesResponseItemsTypeItem[] Items { get; set; }
    }

    public class SearchTimeSeriesResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isString")]
        public bool IsString { get; set; }

        [JsonProperty("isStep")]
        public bool IsStep { get; set; }

        [JsonProperty("createdTime")]
        public int CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public int LastUpdatedTime { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("metadata")]
        public SearchTimeSeriesResponseItemsTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("assetId")]
        public int AssetId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("securityCategories")]
        public int[] SecurityCategories { get; set; }

        [JsonProperty("dataSetId")]
        public int DataSetId { get; set; }
    }

    public class SearchTimeSeriesResponseItemsTypeItemMetadataType
    {
        [JsonProperty("cupidatat4b_")]
        public string Cupidatat4b { get; set; }

        [JsonProperty("reprehenderit36")]
        public string Reprehenderit36 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cognitedatafusionblu;

    public partial class WorkflowManagedActions
    {
        public CognitedatafusionbluActions Cognitedatafusionblu(string connectionId) => new CognitedatafusionbluActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitedatafusionbluTriggers Cognitedatafusionblu(string connectionId) => new CognitedatafusionbluTriggers(connectionId);
    }
}
