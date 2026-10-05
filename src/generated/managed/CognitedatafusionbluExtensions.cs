//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitedatafusionblu
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitedatafusionbluActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        [WorkflowExpressionFactory(nameof(__BuildListTimeSeries))]
        public IBodyWorkflowAction<ListTimeSeriesResponse> ListTimeSeries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeMetadata = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> assetIds = null, [WorkflowExpression] Func<string> rootAssetIds = null, [WorkflowExpression] Func<string> externalIdPrefix = null, [WorkflowExpression] Func<string> accept = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimeSeriesResponse> __BuildListTimeSeries(WorkflowValue<string> project, WorkflowValue<int> limit = null, WorkflowValue<bool> includeMetadata = null, WorkflowValue<string> cursor = null, WorkflowValue<string> partition = null, WorkflowValue<string> assetIds = null, WorkflowValue<string> rootAssetIds = null, WorkflowValue<string> externalIdPrefix = null, WorkflowValue<string> accept = null)
        {
            WorkflowValue.Validate(project, nameof(project), required: true);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(includeMetadata, nameof(includeMetadata), required: false);
            WorkflowValue.Validate(cursor, nameof(cursor), required: false);
            WorkflowValue.Validate(partition, nameof(partition), required: false);
            WorkflowValue.Validate(assetIds, nameof(assetIds), required: false);
            WorkflowValue.Validate(rootAssetIds, nameof(rootAssetIds), required: false);
            WorkflowValue.Validate(externalIdPrefix, nameof(externalIdPrefix), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
            return new DeferredBodyAction<ListTimeSeriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/timeseries", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["includeMetadata"] = Convert.ToString(true);
                if (includeMetadata != null)
                    callPayload.Queries["includeMetadata"] = ExpressionConverter.Convert(includeMetadata);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                if (partition != null)
                    callPayload.Queries["partition"] = ExpressionConverter.Convert(partition);
                if (assetIds != null)
                    callPayload.Queries["assetIds"] = ExpressionConverter.Convert(assetIds);
                if (rootAssetIds != null)
                    callPayload.Queries["rootAssetIds"] = ExpressionConverter.Convert(rootAssetIds);
                if (externalIdPrefix != null)
                    callPayload.Queries["externalIdPrefix"] = ExpressionConverter.Convert(externalIdPrefix);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                return new ApiConnectionAction<ListTimeSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        [WorkflowExpressionFactory(nameof(__BuildFilterTimeSeries))]
        public IBodyWorkflowAction<FilterTimeSeriesResponse> FilterTimeSeries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyfiltername = null, [WorkflowExpression] Func<string> bodyfilterunit = null, [WorkflowExpression] Func<bool> bodyfilterisString = null, [WorkflowExpression] Func<bool> bodyfilterisStep = null, [WorkflowExpression] Func<int[]> bodyfilterassetIds = null, [WorkflowExpression] Func<string[]> bodyfilterassetExternalIds = null, [WorkflowExpression] Func<int[]> bodyfilterrootAssetIds = null, [WorkflowExpression] Func<bodyfilterassetSubtreeIdsInputItem[]> bodyfilterassetSubtreeIds = null, [WorkflowExpression] Func<bodyfilterdataSetIdsInputItem[]> bodyfilterdataSetIds = null, [WorkflowExpression] Func<string> bodyfilterexternalIdPrefix = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemax = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemin = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemax = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemin = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodycursor = null, [WorkflowExpression] Func<string> bodypartition = null, [WorkflowExpression] Func<bodysortInputItem[]> bodysort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilterTimeSeriesResponse> __BuildFilterTimeSeries(WorkflowValue<string> project, WorkflowValue<string> contentType = null, WorkflowValue<string> accept = null, WorkflowValue<string> bodyfiltername = null, WorkflowValue<string> bodyfilterunit = null, WorkflowValue<bool> bodyfilterisString = null, WorkflowValue<bool> bodyfilterisStep = null, WorkflowValue<int[]> bodyfilterassetIds = null, WorkflowValue<string[]> bodyfilterassetExternalIds = null, WorkflowValue<int[]> bodyfilterrootAssetIds = null, WorkflowValue<bodyfilterassetSubtreeIdsInputItem[]> bodyfilterassetSubtreeIds = null, WorkflowValue<bodyfilterdataSetIdsInputItem[]> bodyfilterdataSetIds = null, WorkflowValue<string> bodyfilterexternalIdPrefix = null, WorkflowValue<int> bodyfiltercreatedTimemax = null, WorkflowValue<int> bodyfiltercreatedTimemin = null, WorkflowValue<int> bodyfilterlastUpdatedTimemax = null, WorkflowValue<int> bodyfilterlastUpdatedTimemin = null, WorkflowValue<int> bodylimit = null, WorkflowValue<string> bodycursor = null, WorkflowValue<string> bodypartition = null, WorkflowValue<bodysortInputItem[]> bodysort = null)
        {
            WorkflowValue.Validate(project, nameof(project), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
            WorkflowValue.Validate(bodyfiltername, nameof(bodyfiltername), required: false);
            WorkflowValue.Validate(bodyfilterunit, nameof(bodyfilterunit), required: false);
            WorkflowValue.Validate(bodyfilterisString, nameof(bodyfilterisString), required: false);
            WorkflowValue.Validate(bodyfilterisStep, nameof(bodyfilterisStep), required: false);
            WorkflowValue.Validate(bodyfilterassetIds, nameof(bodyfilterassetIds), required: false);
            WorkflowValue.Validate(bodyfilterassetExternalIds, nameof(bodyfilterassetExternalIds), required: false);
            WorkflowValue.Validate(bodyfilterrootAssetIds, nameof(bodyfilterrootAssetIds), required: false);
            WorkflowValue.Validate(bodyfilterassetSubtreeIds, nameof(bodyfilterassetSubtreeIds), required: false);
            WorkflowValue.Validate(bodyfilterdataSetIds, nameof(bodyfilterdataSetIds), required: false);
            WorkflowValue.Validate(bodyfilterexternalIdPrefix, nameof(bodyfilterexternalIdPrefix), required: false);
            WorkflowValue.Validate(bodyfiltercreatedTimemax, nameof(bodyfiltercreatedTimemax), required: false);
            WorkflowValue.Validate(bodyfiltercreatedTimemin, nameof(bodyfiltercreatedTimemin), required: false);
            WorkflowValue.Validate(bodyfilterlastUpdatedTimemax, nameof(bodyfilterlastUpdatedTimemax), required: false);
            WorkflowValue.Validate(bodyfilterlastUpdatedTimemin, nameof(bodyfilterlastUpdatedTimemin), required: false);
            WorkflowValue.Validate(bodylimit, nameof(bodylimit), required: false);
            WorkflowValue.Validate(bodycursor, nameof(bodycursor), required: false);
            WorkflowValue.Validate(bodypartition, nameof(bodypartition), required: false);
            WorkflowValue.Validate(bodysort, nameof(bodysort), required: false);
            return new DeferredBodyAction<FilterTimeSeriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/timeseries/list", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfiltername != null)
                {
                    filterObject["name"] = ExpressionConverter.ConvertO(bodyfiltername);
                    filterObjectpropCount++;
                }

                if (bodyfilterunit != null)
                {
                    filterObject["unit"] = ExpressionConverter.ConvertO(bodyfilterunit);
                    filterObjectpropCount++;
                }

                if (bodyfilterisString != null)
                {
                    filterObject["isString"] = ExpressionConverter.ConvertO(bodyfilterisString);
                    filterObjectpropCount++;
                }

                if (bodyfilterisStep != null)
                {
                    filterObject["isStep"] = ExpressionConverter.ConvertO(bodyfilterisStep);
                    filterObjectpropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    filterObject["metadata"] = metadataObject;
                    filterObjectpropCount++;
                }

                if (bodyfilterassetIds != null)
                {
                    filterObject["assetIds"] = ExpressionConverter.ConvertO(bodyfilterassetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetExternalIds != null)
                {
                    filterObject["assetExternalIds"] = ExpressionConverter.ConvertO(bodyfilterassetExternalIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterrootAssetIds != null)
                {
                    filterObject["rootAssetIds"] = ExpressionConverter.ConvertO(bodyfilterrootAssetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetSubtreeIds != null)
                {
                    filterObject["assetSubtreeIds"] = ExpressionConverter.ConvertO(bodyfilterassetSubtreeIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterdataSetIds != null)
                {
                    filterObject["dataSetIds"] = ExpressionConverter.ConvertO(bodyfilterdataSetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterexternalIdPrefix != null)
                {
                    filterObject["externalIdPrefix"] = ExpressionConverter.ConvertO(bodyfilterexternalIdPrefix);
                    filterObjectpropCount++;
                }

                var createdTimeObject = new JObject();
                var createdTimeObjectpropCount = 0;
                if (bodyfiltercreatedTimemax != null)
                {
                    createdTimeObject["max"] = ExpressionConverter.ConvertO(bodyfiltercreatedTimemax);
                    createdTimeObjectpropCount++;
                }

                if (bodyfiltercreatedTimemin != null)
                {
                    createdTimeObject["min"] = ExpressionConverter.ConvertO(bodyfiltercreatedTimemin);
                    createdTimeObjectpropCount++;
                }

                if (createdTimeObjectpropCount > 0)
                {
                    filterObject["createdTime"] = createdTimeObject;
                    filterObjectpropCount++;
                }

                var lastUpdatedTimeObject = new JObject();
                var lastUpdatedTimeObjectpropCount = 0;
                if (bodyfilterlastUpdatedTimemax != null)
                {
                    lastUpdatedTimeObject["max"] = ExpressionConverter.ConvertO(bodyfilterlastUpdatedTimemax);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (bodyfilterlastUpdatedTimemin != null)
                {
                    lastUpdatedTimeObject["min"] = ExpressionConverter.ConvertO(bodyfilterlastUpdatedTimemin);
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

                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 100;
                    bodypropCount++;
                }

                if (bodycursor != null)
                {
                    body["cursor"] = ExpressionConverter.ConvertO(bodycursor);
                    bodypropCount++;
                }

                if (bodypartition != null)
                {
                    body["partition"] = ExpressionConverter.ConvertO(bodypartition);
                    bodypropCount++;
                }

                if (bodysort != null)
                {
                    body["sort"] = ExpressionConverter.ConvertO(bodysort);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FilterTimeSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        [WorkflowExpressionFactory(nameof(__BuildSearchTimeSeries))]
        public IBodyWorkflowAction<SearchTimeSeriesResponse> SearchTimeSeries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyfiltername = null, [WorkflowExpression] Func<string> bodyfilterunit = null, [WorkflowExpression] Func<bool> bodyfilterisString = null, [WorkflowExpression] Func<bool> bodyfilterisStep = null, [WorkflowExpression] Func<int[]> bodyfilterassetIds = null, [WorkflowExpression] Func<string[]> bodyfilterassetExternalIds = null, [WorkflowExpression] Func<int[]> bodyfilterrootAssetIds = null, [WorkflowExpression] Func<bodyfilterassetSubtreeIdsInputItem[]> bodyfilterassetSubtreeIds = null, [WorkflowExpression] Func<bodyfilterdataSetIdsInputItem[]> bodyfilterdataSetIds = null, [WorkflowExpression] Func<string> bodyfilterexternalIdPrefix = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemax = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemin = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemax = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemin = null, [WorkflowExpression] Func<string> bodysearchname = null, [WorkflowExpression] Func<string> bodysearchdescription = null, [WorkflowExpression] Func<string> bodysearchquery = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchTimeSeriesResponse> __BuildSearchTimeSeries(WorkflowValue<string> project, WorkflowValue<string> contentType = null, WorkflowValue<string> accept = null, WorkflowValue<string> bodyfiltername = null, WorkflowValue<string> bodyfilterunit = null, WorkflowValue<bool> bodyfilterisString = null, WorkflowValue<bool> bodyfilterisStep = null, WorkflowValue<int[]> bodyfilterassetIds = null, WorkflowValue<string[]> bodyfilterassetExternalIds = null, WorkflowValue<int[]> bodyfilterrootAssetIds = null, WorkflowValue<bodyfilterassetSubtreeIdsInputItem[]> bodyfilterassetSubtreeIds = null, WorkflowValue<bodyfilterdataSetIdsInputItem[]> bodyfilterdataSetIds = null, WorkflowValue<string> bodyfilterexternalIdPrefix = null, WorkflowValue<int> bodyfiltercreatedTimemax = null, WorkflowValue<int> bodyfiltercreatedTimemin = null, WorkflowValue<int> bodyfilterlastUpdatedTimemax = null, WorkflowValue<int> bodyfilterlastUpdatedTimemin = null, WorkflowValue<string> bodysearchname = null, WorkflowValue<string> bodysearchdescription = null, WorkflowValue<string> bodysearchquery = null, WorkflowValue<int> bodylimit = null)
        {
            WorkflowValue.Validate(project, nameof(project), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
            WorkflowValue.Validate(bodyfiltername, nameof(bodyfiltername), required: false);
            WorkflowValue.Validate(bodyfilterunit, nameof(bodyfilterunit), required: false);
            WorkflowValue.Validate(bodyfilterisString, nameof(bodyfilterisString), required: false);
            WorkflowValue.Validate(bodyfilterisStep, nameof(bodyfilterisStep), required: false);
            WorkflowValue.Validate(bodyfilterassetIds, nameof(bodyfilterassetIds), required: false);
            WorkflowValue.Validate(bodyfilterassetExternalIds, nameof(bodyfilterassetExternalIds), required: false);
            WorkflowValue.Validate(bodyfilterrootAssetIds, nameof(bodyfilterrootAssetIds), required: false);
            WorkflowValue.Validate(bodyfilterassetSubtreeIds, nameof(bodyfilterassetSubtreeIds), required: false);
            WorkflowValue.Validate(bodyfilterdataSetIds, nameof(bodyfilterdataSetIds), required: false);
            WorkflowValue.Validate(bodyfilterexternalIdPrefix, nameof(bodyfilterexternalIdPrefix), required: false);
            WorkflowValue.Validate(bodyfiltercreatedTimemax, nameof(bodyfiltercreatedTimemax), required: false);
            WorkflowValue.Validate(bodyfiltercreatedTimemin, nameof(bodyfiltercreatedTimemin), required: false);
            WorkflowValue.Validate(bodyfilterlastUpdatedTimemax, nameof(bodyfilterlastUpdatedTimemax), required: false);
            WorkflowValue.Validate(bodyfilterlastUpdatedTimemin, nameof(bodyfilterlastUpdatedTimemin), required: false);
            WorkflowValue.Validate(bodysearchname, nameof(bodysearchname), required: false);
            WorkflowValue.Validate(bodysearchdescription, nameof(bodysearchdescription), required: false);
            WorkflowValue.Validate(bodysearchquery, nameof(bodysearchquery), required: false);
            WorkflowValue.Validate(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<SearchTimeSeriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/timeseries/search", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfiltername != null)
                {
                    filterObject["name"] = ExpressionConverter.ConvertO(bodyfiltername);
                    filterObjectpropCount++;
                }

                if (bodyfilterunit != null)
                {
                    filterObject["unit"] = ExpressionConverter.ConvertO(bodyfilterunit);
                    filterObjectpropCount++;
                }

                if (bodyfilterisString != null)
                {
                    filterObject["isString"] = ExpressionConverter.ConvertO(bodyfilterisString);
                    filterObjectpropCount++;
                }

                if (bodyfilterisStep != null)
                {
                    filterObject["isStep"] = ExpressionConverter.ConvertO(bodyfilterisStep);
                    filterObjectpropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    filterObject["metadata"] = metadataObject;
                    filterObjectpropCount++;
                }

                if (bodyfilterassetIds != null)
                {
                    filterObject["assetIds"] = ExpressionConverter.ConvertO(bodyfilterassetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetExternalIds != null)
                {
                    filterObject["assetExternalIds"] = ExpressionConverter.ConvertO(bodyfilterassetExternalIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterrootAssetIds != null)
                {
                    filterObject["rootAssetIds"] = ExpressionConverter.ConvertO(bodyfilterrootAssetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetSubtreeIds != null)
                {
                    filterObject["assetSubtreeIds"] = ExpressionConverter.ConvertO(bodyfilterassetSubtreeIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterdataSetIds != null)
                {
                    filterObject["dataSetIds"] = ExpressionConverter.ConvertO(bodyfilterdataSetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterexternalIdPrefix != null)
                {
                    filterObject["externalIdPrefix"] = ExpressionConverter.ConvertO(bodyfilterexternalIdPrefix);
                    filterObjectpropCount++;
                }

                var createdTimeObject = new JObject();
                var createdTimeObjectpropCount = 0;
                if (bodyfiltercreatedTimemax != null)
                {
                    createdTimeObject["max"] = ExpressionConverter.ConvertO(bodyfiltercreatedTimemax);
                    createdTimeObjectpropCount++;
                }

                if (bodyfiltercreatedTimemin != null)
                {
                    createdTimeObject["min"] = ExpressionConverter.ConvertO(bodyfiltercreatedTimemin);
                    createdTimeObjectpropCount++;
                }

                if (createdTimeObjectpropCount > 0)
                {
                    filterObject["createdTime"] = createdTimeObject;
                    filterObjectpropCount++;
                }

                var lastUpdatedTimeObject = new JObject();
                var lastUpdatedTimeObjectpropCount = 0;
                if (bodyfilterlastUpdatedTimemax != null)
                {
                    lastUpdatedTimeObject["max"] = ExpressionConverter.ConvertO(bodyfilterlastUpdatedTimemax);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (bodyfilterlastUpdatedTimemin != null)
                {
                    lastUpdatedTimeObject["min"] = ExpressionConverter.ConvertO(bodyfilterlastUpdatedTimemin);
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
                if (bodysearchname != null)
                {
                    searchObject["name"] = ExpressionConverter.ConvertO(bodysearchname);
                    searchObjectpropCount++;
                }

                if (bodysearchdescription != null)
                {
                    searchObject["description"] = ExpressionConverter.ConvertO(bodysearchdescription);
                    searchObjectpropCount++;
                }

                if (bodysearchquery != null)
                {
                    searchObject["query"] = ExpressionConverter.ConvertO(bodysearchquery);
                    searchObjectpropCount++;
                }

                if (searchObjectpropCount > 0)
                {
                    body["search"] = searchObject;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = ExpressionConverter.ConvertO(bodylimit);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        [WorkflowExpressionFactory(nameof(__BuildQueryGraphQL))]
        public IWorkflowAction QueryGraphQL([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> space, [WorkflowExpression] Func<string> datamodel, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildQueryGraphQL(WorkflowValue<string> project, WorkflowValue<string> space, WorkflowValue<string> datamodel, WorkflowValue<string> version, WorkflowValue<string> contentType = null, WorkflowValue<string> accept = null, WorkflowValue<string> bodyquery = null)
        {
            WorkflowValue.Validate(project, nameof(project), required: true);
            WorkflowValue.Validate(space, nameof(space), required: true);
            WorkflowValue.Validate(datamodel, nameof(datamodel), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(accept, nameof(accept), required: false);
            WorkflowValue.Validate(bodyquery, nameof(bodyquery), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/userapis/spaces/{1}/datamodels/{2}/versions/{3}/graphql", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(space, 1), ExpressionConverter.ConvertWithUrlEncoding(datamodel, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquery != null)
                {
                    body["query"] = ExpressionConverter.ConvertO(bodyquery);
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
            });
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

    public enum bodysortInputItemOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

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
