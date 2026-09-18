//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cognitedatafusionblu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitedatafusionbluActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<ListTimeSeriesResponse> ListTimeSeries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeMetadata = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> partition = null, [WorkflowExpression] Func<string> assetIds = null, [WorkflowExpression] Func<string> rootAssetIds = null, [WorkflowExpression] Func<string> externalIdPrefix = null, [WorkflowExpression] Func<string> accept = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(includeMetadata, nameof(includeMetadata), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(partition, nameof(partition), required: false);
            SourceExpression.Validate(assetIds, nameof(assetIds), required: false);
            SourceExpression.Validate(rootAssetIds, nameof(rootAssetIds), required: false);
            SourceExpression.Validate(externalIdPrefix, nameof(externalIdPrefix), required: false);
            SourceExpression.Validate(accept, nameof(accept), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/timeseries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["includeMetadata"] = Convert.ToString(true);
                if (includeMetadata != null)
                    callPayload.Queries["includeMetadata"] = SourceExpressionConverter.ConvertO(includeMetadata);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (partition != null)
                    callPayload.Queries["partition"] = SourceExpressionConverter.ConvertO(partition);
                if (assetIds != null)
                    callPayload.Queries["assetIds"] = SourceExpressionConverter.ConvertO(assetIds);
                if (rootAssetIds != null)
                    callPayload.Queries["rootAssetIds"] = SourceExpressionConverter.ConvertO(rootAssetIds);
                if (externalIdPrefix != null)
                    callPayload.Queries["externalIdPrefix"] = SourceExpressionConverter.ConvertO(externalIdPrefix);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                return callPayload;
            }

            return new ApiConnectionAction<ListTimeSeriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<FilterTimeSeriesResponse> FilterTimeSeries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyfiltername = null, [WorkflowExpression] Func<string> bodyfilterunit = null, [WorkflowExpression] Func<bool> bodyfilterisString = null, [WorkflowExpression] Func<bool> bodyfilterisStep = null, [WorkflowExpression] Func<int[]> bodyfilterassetIds = null, [WorkflowExpression] Func<string[]> bodyfilterassetExternalIds = null, [WorkflowExpression] Func<int[]> bodyfilterrootAssetIds = null, [WorkflowExpression] Func<bodyfilterassetSubtreeIdsInputItem[]> bodyfilterassetSubtreeIds = null, [WorkflowExpression] Func<bodyfilterdataSetIdsInputItem[]> bodyfilterdataSetIds = null, [WorkflowExpression] Func<string> bodyfilterexternalIdPrefix = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemax = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemin = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemax = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemin = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodycursor = null, [WorkflowExpression] Func<string> bodypartition = null, [WorkflowExpression] Func<bodysortInputItem[]> bodysort = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(accept, nameof(accept), required: false);
            SourceExpression.Validate(bodyfiltername, nameof(bodyfiltername), required: false);
            SourceExpression.Validate(bodyfilterunit, nameof(bodyfilterunit), required: false);
            SourceExpression.Validate(bodyfilterisString, nameof(bodyfilterisString), required: false);
            SourceExpression.Validate(bodyfilterisStep, nameof(bodyfilterisStep), required: false);
            SourceExpression.Validate(bodyfilterassetIds, nameof(bodyfilterassetIds), required: false);
            SourceExpression.Validate(bodyfilterassetExternalIds, nameof(bodyfilterassetExternalIds), required: false);
            SourceExpression.Validate(bodyfilterrootAssetIds, nameof(bodyfilterrootAssetIds), required: false);
            SourceExpression.Validate(bodyfilterassetSubtreeIds, nameof(bodyfilterassetSubtreeIds), required: false);
            SourceExpression.Validate(bodyfilterdataSetIds, nameof(bodyfilterdataSetIds), required: false);
            SourceExpression.Validate(bodyfilterexternalIdPrefix, nameof(bodyfilterexternalIdPrefix), required: false);
            SourceExpression.Validate(bodyfiltercreatedTimemax, nameof(bodyfiltercreatedTimemax), required: false);
            SourceExpression.Validate(bodyfiltercreatedTimemin, nameof(bodyfiltercreatedTimemin), required: false);
            SourceExpression.Validate(bodyfilterlastUpdatedTimemax, nameof(bodyfilterlastUpdatedTimemax), required: false);
            SourceExpression.Validate(bodyfilterlastUpdatedTimemin, nameof(bodyfilterlastUpdatedTimemin), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            SourceExpression.Validate(bodycursor, nameof(bodycursor), required: false);
            SourceExpression.Validate(bodypartition, nameof(bodypartition), required: false);
            SourceExpression.Validate(bodysort, nameof(bodysort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/timeseries/list", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfiltername != null)
                {
                    filterObject["name"] = SourceExpressionConverter.ConvertToken(bodyfiltername);
                    filterObjectpropCount++;
                }

                if (bodyfilterunit != null)
                {
                    filterObject["unit"] = SourceExpressionConverter.ConvertToken(bodyfilterunit);
                    filterObjectpropCount++;
                }

                if (bodyfilterisString != null)
                {
                    filterObject["isString"] = SourceExpressionConverter.ConvertToken(bodyfilterisString);
                    filterObjectpropCount++;
                }

                if (bodyfilterisStep != null)
                {
                    filterObject["isStep"] = SourceExpressionConverter.ConvertToken(bodyfilterisStep);
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
                    filterObject["assetIds"] = SourceExpressionConverter.ConvertToken(bodyfilterassetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetExternalIds != null)
                {
                    filterObject["assetExternalIds"] = SourceExpressionConverter.ConvertToken(bodyfilterassetExternalIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterrootAssetIds != null)
                {
                    filterObject["rootAssetIds"] = SourceExpressionConverter.ConvertToken(bodyfilterrootAssetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetSubtreeIds != null)
                {
                    filterObject["assetSubtreeIds"] = SourceExpressionConverter.ConvertToken(bodyfilterassetSubtreeIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterdataSetIds != null)
                {
                    filterObject["dataSetIds"] = SourceExpressionConverter.ConvertToken(bodyfilterdataSetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterexternalIdPrefix != null)
                {
                    filterObject["externalIdPrefix"] = SourceExpressionConverter.ConvertToken(bodyfilterexternalIdPrefix);
                    filterObjectpropCount++;
                }

                var createdTimeObject = new JObject();
                var createdTimeObjectpropCount = 0;
                if (bodyfiltercreatedTimemax != null)
                {
                    createdTimeObject["max"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedTimemax);
                    createdTimeObjectpropCount++;
                }

                if (bodyfiltercreatedTimemin != null)
                {
                    createdTimeObject["min"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedTimemin);
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
                    lastUpdatedTimeObject["max"] = SourceExpressionConverter.ConvertToken(bodyfilterlastUpdatedTimemax);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (bodyfilterlastUpdatedTimemin != null)
                {
                    lastUpdatedTimeObject["min"] = SourceExpressionConverter.ConvertToken(bodyfilterlastUpdatedTimemin);
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
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
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
                    body["cursor"] = SourceExpressionConverter.ConvertToken(bodycursor);
                    bodypropCount++;
                }

                if (bodypartition != null)
                {
                    body["partition"] = SourceExpressionConverter.ConvertToken(bodypartition);
                    bodypropCount++;
                }

                if (bodysort != null)
                {
                    body["sort"] = SourceExpressionConverter.ConvertToken(bodysort);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FilterTimeSeriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<SearchTimeSeriesResponse> SearchTimeSeries([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyfiltername = null, [WorkflowExpression] Func<string> bodyfilterunit = null, [WorkflowExpression] Func<bool> bodyfilterisString = null, [WorkflowExpression] Func<bool> bodyfilterisStep = null, [WorkflowExpression] Func<int[]> bodyfilterassetIds = null, [WorkflowExpression] Func<string[]> bodyfilterassetExternalIds = null, [WorkflowExpression] Func<int[]> bodyfilterrootAssetIds = null, [WorkflowExpression] Func<bodyfilterassetSubtreeIdsInputItem[]> bodyfilterassetSubtreeIds = null, [WorkflowExpression] Func<bodyfilterdataSetIdsInputItem[]> bodyfilterdataSetIds = null, [WorkflowExpression] Func<string> bodyfilterexternalIdPrefix = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemax = null, [WorkflowExpression] Func<int> bodyfiltercreatedTimemin = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemax = null, [WorkflowExpression] Func<int> bodyfilterlastUpdatedTimemin = null, [WorkflowExpression] Func<string> bodysearchname = null, [WorkflowExpression] Func<string> bodysearchdescription = null, [WorkflowExpression] Func<string> bodysearchquery = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(accept, nameof(accept), required: false);
            SourceExpression.Validate(bodyfiltername, nameof(bodyfiltername), required: false);
            SourceExpression.Validate(bodyfilterunit, nameof(bodyfilterunit), required: false);
            SourceExpression.Validate(bodyfilterisString, nameof(bodyfilterisString), required: false);
            SourceExpression.Validate(bodyfilterisStep, nameof(bodyfilterisStep), required: false);
            SourceExpression.Validate(bodyfilterassetIds, nameof(bodyfilterassetIds), required: false);
            SourceExpression.Validate(bodyfilterassetExternalIds, nameof(bodyfilterassetExternalIds), required: false);
            SourceExpression.Validate(bodyfilterrootAssetIds, nameof(bodyfilterrootAssetIds), required: false);
            SourceExpression.Validate(bodyfilterassetSubtreeIds, nameof(bodyfilterassetSubtreeIds), required: false);
            SourceExpression.Validate(bodyfilterdataSetIds, nameof(bodyfilterdataSetIds), required: false);
            SourceExpression.Validate(bodyfilterexternalIdPrefix, nameof(bodyfilterexternalIdPrefix), required: false);
            SourceExpression.Validate(bodyfiltercreatedTimemax, nameof(bodyfiltercreatedTimemax), required: false);
            SourceExpression.Validate(bodyfiltercreatedTimemin, nameof(bodyfiltercreatedTimemin), required: false);
            SourceExpression.Validate(bodyfilterlastUpdatedTimemax, nameof(bodyfilterlastUpdatedTimemax), required: false);
            SourceExpression.Validate(bodyfilterlastUpdatedTimemin, nameof(bodyfilterlastUpdatedTimemin), required: false);
            SourceExpression.Validate(bodysearchname, nameof(bodysearchname), required: false);
            SourceExpression.Validate(bodysearchdescription, nameof(bodysearchdescription), required: false);
            SourceExpression.Validate(bodysearchquery, nameof(bodysearchquery), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/timeseries/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfiltername != null)
                {
                    filterObject["name"] = SourceExpressionConverter.ConvertToken(bodyfiltername);
                    filterObjectpropCount++;
                }

                if (bodyfilterunit != null)
                {
                    filterObject["unit"] = SourceExpressionConverter.ConvertToken(bodyfilterunit);
                    filterObjectpropCount++;
                }

                if (bodyfilterisString != null)
                {
                    filterObject["isString"] = SourceExpressionConverter.ConvertToken(bodyfilterisString);
                    filterObjectpropCount++;
                }

                if (bodyfilterisStep != null)
                {
                    filterObject["isStep"] = SourceExpressionConverter.ConvertToken(bodyfilterisStep);
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
                    filterObject["assetIds"] = SourceExpressionConverter.ConvertToken(bodyfilterassetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetExternalIds != null)
                {
                    filterObject["assetExternalIds"] = SourceExpressionConverter.ConvertToken(bodyfilterassetExternalIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterrootAssetIds != null)
                {
                    filterObject["rootAssetIds"] = SourceExpressionConverter.ConvertToken(bodyfilterrootAssetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterassetSubtreeIds != null)
                {
                    filterObject["assetSubtreeIds"] = SourceExpressionConverter.ConvertToken(bodyfilterassetSubtreeIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterdataSetIds != null)
                {
                    filterObject["dataSetIds"] = SourceExpressionConverter.ConvertToken(bodyfilterdataSetIds);
                    filterObjectpropCount++;
                }

                if (bodyfilterexternalIdPrefix != null)
                {
                    filterObject["externalIdPrefix"] = SourceExpressionConverter.ConvertToken(bodyfilterexternalIdPrefix);
                    filterObjectpropCount++;
                }

                var createdTimeObject = new JObject();
                var createdTimeObjectpropCount = 0;
                if (bodyfiltercreatedTimemax != null)
                {
                    createdTimeObject["max"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedTimemax);
                    createdTimeObjectpropCount++;
                }

                if (bodyfiltercreatedTimemin != null)
                {
                    createdTimeObject["min"] = SourceExpressionConverter.ConvertToken(bodyfiltercreatedTimemin);
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
                    lastUpdatedTimeObject["max"] = SourceExpressionConverter.ConvertToken(bodyfilterlastUpdatedTimemax);
                    lastUpdatedTimeObjectpropCount++;
                }

                if (bodyfilterlastUpdatedTimemin != null)
                {
                    lastUpdatedTimeObject["min"] = SourceExpressionConverter.ConvertToken(bodyfilterlastUpdatedTimemin);
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
                    searchObject["name"] = SourceExpressionConverter.ConvertToken(bodysearchname);
                    searchObjectpropCount++;
                }

                if (bodysearchdescription != null)
                {
                    searchObject["description"] = SourceExpressionConverter.ConvertToken(bodysearchdescription);
                    searchObjectpropCount++;
                }

                if (bodysearchquery != null)
                {
                    searchObject["query"] = SourceExpressionConverter.ConvertToken(bodysearchquery);
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
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
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
                return callPayload;
            }

            return new ApiConnectionAction<SearchTimeSeriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IWorkflowAction QueryGraphQL([WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> space, [WorkflowExpression] Func<string> datamodel, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyquery = null)
        {
            SourceExpression.Validate(project, nameof(project), required: true);
            SourceExpression.Validate(space, nameof(space), required: true);
            SourceExpression.Validate(datamodel, nameof(datamodel), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(accept, nameof(accept), required: false);
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/projects/{0}/userapis/spaces/{1}/datamodels/{2}/versions/{3}/graphql", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(space, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(datamodel, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (accept != null)
                    callPayload.Headers["Accept"] = SourceExpressionConverter.ConvertO(accept);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquery != null)
                {
                    body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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