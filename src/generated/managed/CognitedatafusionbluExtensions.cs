//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Cognitedatafusionblu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CognitedatafusionbluActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<ListTimeSeriesResponse> ListTimeSeries(Expression<Func<string>> project, Expression<Func<int>> limit = null, Expression<Func<bool>> includeMetadata = null, Expression<Func<string>> cursor = null, Expression<Func<string>> partition = null, Expression<Func<string>> assetIds = null, Expression<Func<string>> rootAssetIds = null, Expression<Func<string>> externalIdPrefix = null, Expression<Func<string>> accept = null)
        {
            var apiCallPath = String.Format("/api/v1/projects/{0}/timeseries", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<FilterTimeSeriesResponse> FilterTimeSeries(Expression<Func<string>> project, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyfiltername = null, Expression<Func<string>> bodyfilterunit = null, Expression<Func<bool>> bodyfilterisString = null, Expression<Func<bool>> bodyfilterisStep = null, Expression<Func<int[]>> bodyfilterassetIds = null, Expression<Func<string[]>> bodyfilterassetExternalIds = null, Expression<Func<int[]>> bodyfilterrootAssetIds = null, Expression<Func<bodyfilterassetSubtreeIdsInputItem[]>> bodyfilterassetSubtreeIds = null, Expression<Func<bodyfilterdataSetIdsInputItem[]>> bodyfilterdataSetIds = null, Expression<Func<string>> bodyfilterexternalIdPrefix = null, Expression<Func<int>> bodyfiltercreatedTimemax = null, Expression<Func<int>> bodyfiltercreatedTimemin = null, Expression<Func<int>> bodyfilterlastUpdatedTimemax = null, Expression<Func<int>> bodyfilterlastUpdatedTimemin = null, Expression<Func<int>> bodylimit = null, Expression<Func<string>> bodycursor = null, Expression<Func<string>> bodypartition = null, Expression<Func<bodysortInputItem[]>> bodysort = null)
        {
            var apiCallPath = String.Format("/api/v1/projects/{0}/timeseries/list", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
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
                body["limit"] = ExpressionConverter.ConvertO(bodylimit);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<SearchTimeSeriesResponse> SearchTimeSeries(Expression<Func<string>> project, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyfiltername = null, Expression<Func<string>> bodyfilterunit = null, Expression<Func<bool>> bodyfilterisString = null, Expression<Func<bool>> bodyfilterisStep = null, Expression<Func<int[]>> bodyfilterassetIds = null, Expression<Func<string[]>> bodyfilterassetExternalIds = null, Expression<Func<int[]>> bodyfilterrootAssetIds = null, Expression<Func<bodyfilterassetSubtreeIdsInputItem[]>> bodyfilterassetSubtreeIds = null, Expression<Func<bodyfilterdataSetIdsInputItem[]>> bodyfilterdataSetIds = null, Expression<Func<string>> bodyfilterexternalIdPrefix = null, Expression<Func<int>> bodyfiltercreatedTimemax = null, Expression<Func<int>> bodyfiltercreatedTimemin = null, Expression<Func<int>> bodyfilterlastUpdatedTimemax = null, Expression<Func<int>> bodyfilterlastUpdatedTimemin = null, Expression<Func<string>> bodysearchname = null, Expression<Func<string>> bodysearchdescription = null, Expression<Func<string>> bodysearchquery = null, Expression<Func<int>> bodylimit = null)
        {
            var apiCallPath = String.Format("/api/v1/projects/{0}/timeseries/search", ExpressionConverter.ConvertWithUrlEncoding(project, 1));
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
                body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchTimeSeriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IWorkflowAction QueryGraphQL(Expression<Func<string>> project, Expression<Func<string>> space, Expression<Func<string>> datamodel, Expression<Func<string>> version, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyquery = null)
        {
            var apiCallPath = String.Format("/api/v1/projects/{0}/userapis/spaces/{1}/datamodels/{2}/versions/{3}/graphql", ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(space, 1), ExpressionConverter.ConvertWithUrlEncoding(datamodel, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
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
    using Microsoft.Azure.Workflows.Sdk.Cognitedatafusionblu;

    public partial class WorkflowManagedActions
    {
        public CognitedatafusionbluActions Cognitedatafusionblu(string connectionId) => new CognitedatafusionbluActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CognitedatafusionbluTriggers Cognitedatafusionblu(string connectionId) => new CognitedatafusionbluTriggers(connectionId);
    }
}