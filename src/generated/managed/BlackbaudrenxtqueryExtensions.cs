//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtquery
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiQueryExecutionJob, ApiConnectionActionConfiguration> GetQueryJobStatus(Expression<Func<string>> jobId, Expression<Func<includeReadUrlInput>> includeReadUrl = null, Expression<Func<contentDispositionInput>> contentDisposition = null)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_includeReadUrl = WorkflowExpression.Compile(includeReadUrl, nameof(includeReadUrl), required: false);
            var __workflow_contentDisposition = WorkflowExpression.Compile(contentDisposition, nameof(contentDisposition), required: false);
            return new DeferredBodyAction<QueryApiQueryExecutionJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Queries["include_read_url"] = Convert.ToString("OnceCompleted");
                if (__workflow_includeReadUrl != null)
                    callPayload.Queries["include_read_url"] = ExpressionConverter.Convert(__workflow_includeReadUrl);
                callPayload.Queries["content_disposition"] = Convert.ToString("Attachment");
                if (__workflow_contentDisposition != null)
                    callPayload.Queries["content_disposition"] = ExpressionConverter.Convert(__workflow_contentDisposition);
                return new ApiConnectionAction<QueryApiQueryExecutionJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> CancelJob(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/jobs/{0}/cancel", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteQuery(Expression<Func<int>> queryId)
        {
            var __workflow_queryId = WorkflowExpression.Compile(queryId, nameof(queryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/queries/{0}", __workflow_queryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Queries["perform_delete"] = Convert.ToString(true);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> StartAdHocQueryExecutionJob(Expression<Func<StartAdHocQueryExecutionJobInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/queries/execute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> StartQueryExecutionJob(Expression<Func<StartQueryExecutionJobInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/queries/executebyid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> StartRefreshStaticQueryExecutionJob(Expression<Func<StartRefreshStaticQueryExecutionJobInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/queries/refreshstaticquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiQuerySummaryV2Collection, ApiConnectionActionConfiguration> ListQueries(Expression<Func<int>> queryTypeIds = null, Expression<Func<int>> category = null, Expression<Func<queryFormatInput>> queryFormat = null, Expression<Func<resultLayoutInput>> resultLayout = null, Expression<Func<string>> searchText = null, Expression<Func<bool>> myFavQueriesOnly = null, Expression<Func<bool>> myQueriesOnly = null, Expression<Func<bool>> mergedQueriesOnly = null, Expression<Func<listQueriesInput>> listQueries = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<bool>> sortDescending = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> addedBy = null, Expression<Func<int>> limit = null, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_queryTypeIds = WorkflowExpression.Compile(queryTypeIds, nameof(queryTypeIds), required: false);
            var __workflow_category = WorkflowExpression.Compile(category, nameof(category), required: false);
            var __workflow_queryFormat = WorkflowExpression.Compile(queryFormat, nameof(queryFormat), required: false);
            var __workflow_resultLayout = WorkflowExpression.Compile(resultLayout, nameof(resultLayout), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_myFavQueriesOnly = WorkflowExpression.Compile(myFavQueriesOnly, nameof(myFavQueriesOnly), required: false);
            var __workflow_myQueriesOnly = WorkflowExpression.Compile(myQueriesOnly, nameof(myQueriesOnly), required: false);
            var __workflow_mergedQueriesOnly = WorkflowExpression.Compile(mergedQueriesOnly, nameof(mergedQueriesOnly), required: false);
            var __workflow_listQueries = WorkflowExpression.Compile(listQueries, nameof(listQueries), required: false);
            var __workflow_sortColumn = WorkflowExpression.Compile(sortColumn, nameof(sortColumn), required: false);
            var __workflow_sortDescending = WorkflowExpression.Compile(sortDescending, nameof(sortDescending), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_addedBy = WorkflowExpression.Compile(addedBy, nameof(addedBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            return new DeferredBodyAction<QueryApiQuerySummaryV2Collection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/v2/queries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                if (__workflow_queryTypeIds != null)
                    callPayload.Queries["query_type_ids"] = ExpressionConverter.Convert(__workflow_queryTypeIds);
                if (__workflow_category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_queryFormat != null)
                    callPayload.Queries["query_format"] = ExpressionConverter.Convert(__workflow_queryFormat);
                if (__workflow_resultLayout != null)
                    callPayload.Queries["result_layout"] = ExpressionConverter.Convert(__workflow_resultLayout);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_myFavQueriesOnly != null)
                    callPayload.Queries["my_fav_queries_only"] = ExpressionConverter.Convert(__workflow_myFavQueriesOnly);
                if (__workflow_myQueriesOnly != null)
                    callPayload.Queries["my_queries_only"] = ExpressionConverter.Convert(__workflow_myQueriesOnly);
                if (__workflow_mergedQueriesOnly != null)
                    callPayload.Queries["merged_queries_only"] = ExpressionConverter.Convert(__workflow_mergedQueriesOnly);
                if (__workflow_listQueries != null)
                    callPayload.Queries["list_queries"] = ExpressionConverter.Convert(__workflow_listQueries);
                if (__workflow_sortColumn != null)
                    callPayload.Queries["sort_column"] = ExpressionConverter.Convert(__workflow_sortColumn);
                if (__workflow_sortDescending != null)
                    callPayload.Queries["sort_descending"] = ExpressionConverter.Convert(__workflow_sortDescending);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_addedBy != null)
                    callPayload.Queries["added_by"] = ExpressionConverter.Convert(__workflow_addedBy);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuation_token"] = ExpressionConverter.Convert(__workflow_continuationToken);
                return new ApiConnectionAction<QueryApiQuerySummaryV2Collection>(callPayload);
            });
        }
    }

    public class BlackbaudrenxtqueryTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryApiQueryExecutionJob
    {
        [JsonProperty("id")]
        public string JobId { get; set; }

        [JsonProperty("status")]
        public QueryApiQueryExecutionJobStatusType Status { get; set; }

        [JsonProperty("row_count")]
        public int RowCount { get; set; }

        [JsonProperty("sas_uri")]
        public string QueryResultsURI { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQueryExecutionJobStatusType
    {
        Pending,
        Running,
        Completed,
        Failed,
        Cancelling,
        Cancelled,
        Throttled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum includeReadUrlInput
    {
        Never,
        OnceRunning,
        OnceCompleted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum contentDispositionInput
    {
        Inline,
        Attachment
    }

    public class QueryApiExecuteQueryResponse
    {
        [JsonProperty("id")]
        public string JobId { get; set; }

        [JsonProperty("status")]
        public QueryApiExecuteQueryResponseStatusType Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiExecuteQueryResponseStatusType
    {
        Pending,
        Running,
        Completed,
        Failed,
        Cancelling,
        Cancelled,
        Throttled
    }

    public class StartAdHocQueryExecutionJobInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken QueryDefinition { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public StartAdHocQueryExecutionJobInputOutputFormatType? OutputFormat { get; set; } = StartAdHocQueryExecutionJobInputOutputFormatType.Csv;

        [JsonProperty("formatting_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public StartAdHocQueryExecutionJobInputFormattingModeType? FormattingMode { get; set; } = StartAdHocQueryExecutionJobInputFormattingModeType.None;

        [JsonProperty("results_file_name")]
        public string Filename { get; set; }

        [JsonProperty("time_zone_offset_in_minutes")]
        public int? TimeZoneOffset { get; set; }

        [JsonProperty("display_code_table_long_description")]
        public bool? UseLongDescriptions { get; set; }

        [JsonProperty("ux_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal StartAdHocQueryExecutionJobInputUXModeType UXMode { get; set; } = StartAdHocQueryExecutionJobInputUXModeType.Asynchronous;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartAdHocQueryExecutionJobInputOutputFormatType
    {
        Csv,
        Json,
        Jsonl,
        Xlsx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartAdHocQueryExecutionJobInputFormattingModeType
    {
        None,
        UI,
        Export
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartAdHocQueryExecutionJobInputUXModeType
    {
        Synchronous,
        Asynchronous
    }

    public class StartQueryExecutionJobInput
    {
        [JsonProperty("v_query_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Type { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Query { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public StartQueryExecutionJobInputOutputFormatType? OutputFormat { get; set; } = StartQueryExecutionJobInputOutputFormatType.Csv;

        [JsonProperty("formatting_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public StartQueryExecutionJobInputFormattingModeType? FormattingMode { get; set; } = StartQueryExecutionJobInputFormattingModeType.None;

        [JsonProperty("sql_generation_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public StartQueryExecutionJobInputSQLGenerationModeType? SQLGenerationMode { get; set; } = StartQueryExecutionJobInputSQLGenerationModeType.Query;

        [JsonProperty("use_static_query_id_set")]
        public bool? UseStaticQuery { get; set; }

        [JsonProperty("results_file_name")]
        public string Filename { get; set; }

        [JsonProperty("time_zone_offset_in_minutes")]
        public int? TimeZoneOffset { get; set; }

        [JsonProperty("display_code_table_long_description")]
        public bool? UseLongDescriptions { get; set; }

        [JsonProperty("ask_fields")]
        public QueryApiAskFieldInformation[] AskField { get; set; }

        [JsonProperty("ux_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal StartQueryExecutionJobInputUXModeType UXMode { get; set; } = StartQueryExecutionJobInputUXModeType.Asynchronous;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartQueryExecutionJobInputOutputFormatType
    {
        Csv,
        Json,
        Jsonl,
        Xlsx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartQueryExecutionJobInputFormattingModeType
    {
        None,
        UI,
        Export
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartQueryExecutionJobInputSQLGenerationModeType
    {
        Query,
        Export,
        Report
    }

    public class QueryApiAskFieldInformation
    {
        [JsonProperty("operator")]
        public QueryApiAskFieldInformationOperatorType Operator { get; set; }

        [JsonProperty("filter_values")]
        public JToken[] Values { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiAskFieldInformationOperatorType
    {
        Equals,
        DoesNotEqual,
        GreaterThan,
        GreaterThanOrEqualTo,
        LessThan,
        LessThanOrEqualTo,
        OneOf,
        NotOneOf,
        Between,
        NotBetween,
        BeginsWith,
        DoesNotBeginWith,
        Contains,
        DoesNotContain,
        Like,
        NotLike,
        Blank,
        NotBlank,
        Ask,
        SoundsLike,
        Any,
        OneOfEach
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartQueryExecutionJobInputUXModeType
    {
        Synchronous,
        Asynchronous
    }

    public class StartRefreshStaticQueryExecutionJobInput
    {
        [JsonProperty("v_query_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Type { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Query { get; set; }

        [JsonProperty("time_zone_offset_in_minutes")]
        public int? TimeZoneOffset { get; set; }

        [JsonProperty("display_code_table_long_description")]
        public bool? UseLongDescriptions { get; set; }

        [JsonProperty("ask_fields")]
        public QueryApiAskFieldInformation[] AskField { get; set; }

        [JsonProperty("ux_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        internal StartRefreshStaticQueryExecutionJobInputUXModeType UXMode { get; set; } = StartRefreshStaticQueryExecutionJobInputUXModeType.Asynchronous;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartRefreshStaticQueryExecutionJobInputUXModeType
    {
        Synchronous,
        Asynchronous
    }

    public class QueryApiQuerySummaryV2Collection
    {
        [JsonProperty("queries")]
        public QueryApiQuerySummary[] Queries { get; set; }

        [JsonProperty("any_query_types")]
        public bool AnyQueryTypes { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("continuation_token")]
        public string ContinuationToken { get; set; }
    }

    public class QueryApiQuerySummary
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        [JsonProperty("format")]
        public QueryApiQuerySummaryFormatType Format { get; set; }

        [JsonProperty("view_supported")]
        public bool ViewSupported { get; set; }

        [JsonProperty("edit_supported")]
        public bool EditSupported { get; set; }

        [JsonProperty("favorite")]
        public bool IsFavorite { get; set; }

        [JsonProperty("has_ask_fields")]
        public bool HasAskFields { get; set; }

        [JsonProperty("created_by_query")]
        public bool CreatedByQuery { get; set; }

        [JsonProperty("supported_execution_modes")]
        public QueryApiQuerySummarySupportedExecutionModesType SupportedExecutionModes { get; set; }

        [JsonProperty("can_modify")]
        public bool CanModify { get; set; }

        [JsonProperty("can_execute")]
        public bool CanExecute { get; set; }

        [JsonProperty("others_can_modify")]
        public bool OthersCanModify { get; set; }

        [JsonProperty("others_can_execute")]
        public bool OthersCanExecute { get; set; }

        [JsonProperty("query_list")]
        public bool IsAQueryList { get; set; }

        [JsonProperty("suppress_duplicates")]
        public bool SuppressDuplicates { get; set; }

        [JsonProperty("output_limit")]
        public QueryApiQuerySummaryOutputLimitType OutputLimit { get; set; }

        [JsonProperty("constituent_filters")]
        public QueryApiQuerySummaryConstituentFiltersType ConstituentFilters { get; set; }

        [JsonProperty("result_layout")]
        public QueryApiQuerySummaryResultLayoutType ResultLayout { get; set; }

        [JsonProperty("select_from_query_name")]
        public string SelectFromQueryName { get; set; }

        [JsonProperty("select_from_query_id")]
        public int SelectFromQueryId { get; set; }

        [JsonProperty("date_last_run")]
        public string LastRun { get; set; }

        [JsonProperty("num_records")]
        public int NumberOfRecords { get; set; }

        [JsonProperty("elapsed_ms")]
        public int ElapsedTime { get; set; }

        [JsonProperty("date_added")]
        public string DateCreated { get; set; }

        [JsonProperty("added_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("date_changed")]
        public string DateChanged { get; set; }

        [JsonProperty("last_changed_by")]
        public string ChangedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQuerySummaryFormatType
    {
        Dynamic,
        Static
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQuerySummarySupportedExecutionModesType
    {
        None,
        ById,
        AdHoc,
        Both
    }

    public class QueryApiQuerySummaryOutputLimitType
    {
        [JsonProperty("type")]
        public QueryApiQuerySummaryOutputLimitTypeTypeType Type { get; set; }

        [JsonProperty("limit")]
        public int Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQuerySummaryOutputLimitTypeTypeType
    {
        RandomSampling,
        TopNumberRows,
        TopPercentRows
    }

    public class QueryApiQuerySummaryConstituentFiltersType
    {
        [JsonProperty("include_inactive")]
        public bool IncludeInactiveConstituents { get; set; }

        [JsonProperty("include_deceased")]
        public bool IncludeDeceasedConstituents { get; set; }

        [JsonProperty("include_no_valid_addresses")]
        public bool IncludeNoValidAddresses { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueryApiQuerySummaryResultLayoutType
    {
        MultiRow,
        SingleRow
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum queryFormatInput
    {
        Dynamic,
        Static
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum resultLayoutInput
    {
        MultiRow,
        SingleRow
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum listQueriesInput
    {
        Unset,
        NoListQueries
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortColumnInput
    {
        Name,
        DateLastRun,
        DateChanged,
        ElapsedMs,
        DateAdded,
        AddedBy,
        LastChangedBy,
        Records
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtquery;

    public partial class WorkflowManagedActions
    {
        public BlackbaudrenxtqueryActions Blackbaudrenxtquery(string connectionId) => new BlackbaudrenxtqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudrenxtqueryTriggers Blackbaudrenxtquery(string connectionId) => new BlackbaudrenxtqueryTriggers(connectionId);
    }
}