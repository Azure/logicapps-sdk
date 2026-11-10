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
        public IBodyWorkflowAction<ListTimeSeriesResponse, ApiConnectionActionConfiguration> ListTimeSeries(Expression<Func<string>> project, Expression<Func<int>> limit = null, Expression<Func<bool>> includeMetadata = null, Expression<Func<string>> cursor = null, Expression<Func<string>> partition = null, Expression<Func<string>> assetIds = null, Expression<Func<string>> rootAssetIds = null, Expression<Func<string>> externalIdPrefix = null, Expression<Func<string>> accept = null)
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
            return new DeferredBodyAction<ListTimeSeriesResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<FilterTimeSeriesResponse, ApiConnectionActionConfiguration> FilterTimeSeries(Expression<Func<string>> project, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<FilterTimeSeriesBodyInput>> body = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FilterTimeSeriesResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = (JToken.Parse("{\"filter\":{\"name\":\"consequat sunt magna in\",\"unit\":\"dolor incididunt aute \",\"isString\":false,\"isStep\":true,\"metadata\":{\"adipisicing_5\":\"esse sint fugiat Lorem\",\"consequat_1\":\"enim Duis\"},\"assetIds\":[363848954441724,793045462540095,1261042166839739],\"assetExternalIds\":[\"my.known.id\"],\"rootAssetIds\":[343099548723932,88483999203217],\"assetSubtreeIds\":[{\"id\":4211006077124470}],\"dataSetIds\":[{\"id\":6354138669857534}],\"externalIdPrefix\":\"my.known.prefix\",\"createdTime\":{\"max\":62632439,\"min\":6703914},\"lastUpdatedTime\":{\"max\":89135725,\"min\":9586224}},\"advancedFilter\":{\"and\":[{\"value\":\"\\u003CCircular reference to #/components/schemas/TimeSeriesFilterLanguage detected\\u003E\"}]},\"limit\":100,\"cursor\":\"4zj0Vy2fo0NtNMb229mI9r1V3YG5NBL752kQz1cKtwo\",\"partition\":\"1/10\",\"sort\":[{\"property\":[\"ut commodo ut qui\"],\"order\":\"desc\",\"nulls\":\"auto\"}]}")).ToJToken();
                return new ApiConnectionAction<FilterTimeSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IBodyWorkflowAction<SearchTimeSeriesResponse, ApiConnectionActionConfiguration> SearchTimeSeries(Expression<Func<string>> project, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<SearchTimeSeriesBodyInput>> body = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SearchTimeSeriesResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                else
                    callPayload.Body = (JToken.Parse("{\"filter\":{\"name\":\"dolore Duis reprehenderit in velit\",\"unit\":\"reprehenderit velit\",\"isString\":false,\"isStep\":false,\"metadata\":{\"nisi_c\":\"ipsum\"},\"assetIds\":[363848954441724,793045462540095,1261042166839739],\"assetExternalIds\":[\"my.known.id\"],\"rootAssetIds\":[343099548723932,88483999203217],\"assetSubtreeIds\":[{\"id\":5739678374793478}],\"dataSetIds\":[{\"id\":1013419334254488}],\"externalIdPrefix\":\"my.known.prefix\",\"createdTime\":{\"max\":23053915,\"min\":16855291},\"lastUpdatedTime\":{\"max\":35295875,\"min\":48926022}},\"search\":{\"name\":\"non in minim fugiat ma\",\"description\":\"dolor veniam in\",\"query\":\"some other\"},\"limit\":100}")).ToJToken();
                return new ApiConnectionAction<SearchTimeSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cognitedatafusionblu")]
        public IWorkflowAction<ApiConnectionActionConfiguration> QueryGraphQL(Expression<Func<string>> project, Expression<Func<string>> space, Expression<Func<string>> datamodel, Expression<Func<string>> version, Expression<Func<QueryGraphQLBodyInput>> body, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null)
        {
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_space = WorkflowExpression.Compile(space, nameof(space), required: true);
            var __workflow_datamodel = WorkflowExpression.Compile(datamodel, nameof(datamodel), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class FilterTimeSeriesBodyInput
    {
        [JsonProperty("filter")]
        public BodyInputFilterType Filter { get; set; }

        [JsonProperty("advancedFilter")]
        public JToken AdvancedFilter { get; set; }

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;

        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("partition")]
        public string Partition { get; set; }

        [JsonProperty("sort")]
        public BodyInputSortTypeItem[] Sort { get; set; }
    }

    public class BodyInputFilterType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("isString")]
        public bool? IsString { get; set; }

        [JsonProperty("isStep")]
        public bool? IsStep { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("assetIds")]
        public int[] AssetIds { get; set; }

        [JsonProperty("assetExternalIds")]
        public string[] AssetExternalIds { get; set; }

        [JsonProperty("rootAssetIds")]
        public int[] RootAssetIds { get; set; }

        [JsonProperty("assetSubtreeIds")]
        public BodyInputFilterTypeAssetSubtreeIdsTypeItem[] AssetSubtreeIds { get; set; }

        [JsonProperty("dataSetIds")]
        public BodyInputFilterTypeDataSetIdsTypeItem[] DataSetIds { get; set; }

        [JsonProperty("externalIdPrefix")]
        public string ExternalIdPrefix { get; set; }

        [JsonProperty("createdTime")]
        public BodyInputFilterTypeCreatedTimeType CreatedTime { get; set; }

        [JsonProperty("lastUpdatedTime")]
        public BodyInputFilterTypeLastUpdatedTimeType LastUpdatedTime { get; set; }
    }

    public class BodyInputFilterTypeAssetSubtreeIdsTypeItem
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class BodyInputFilterTypeDataSetIdsTypeItem
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
    }

    public class BodyInputFilterTypeCreatedTimeType
    {
        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("min")]
        public int? Min { get; set; }
    }

    public class BodyInputFilterTypeLastUpdatedTimeType
    {
        [JsonProperty("max")]
        public int? Max { get; set; }

        [JsonProperty("min")]
        public int? Min { get; set; }
    }

    public class BodyInputSortTypeItem
    {
        [JsonProperty("property")]
        public string[] Property { get; set; }

        [JsonProperty("order")]
        public BodyInputSortTypeItemOrderType? Order { get; set; }

        [JsonProperty("nulls", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSortTypeItemNullsType? Nulls { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Cognitedatafusionblu.BodyInputSortTypeItemNullsType.Auto;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSortTypeItemOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSortTypeItemNullsType
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

    public class SearchTimeSeriesBodyInput
    {
        [JsonProperty("filter")]
        public BodyInputFilterType Filter { get; set; }

        [JsonProperty("search")]
        public BodyInputSearchType Search { get; set; }

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 100;
    }

    public class BodyInputSearchType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }
    }

    public class QueryGraphQLBodyInput
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }
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