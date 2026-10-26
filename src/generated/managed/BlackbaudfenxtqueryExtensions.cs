//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtquery
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudfenxtqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiQueryExecutionJob, ApiConnectionActionConfiguration> GetQueryJobStatus(Expression<Func<moduleInput>> module, Expression<Func<string>> jobId, Expression<Func<includeReadUrlInput>> includeReadUrl = null, Expression<Func<contentDispositionInput>> contentDisposition = null)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_includeReadUrl = WorkflowExpression.Compile(includeReadUrl, nameof(includeReadUrl), required: false);
            var __workflow_contentDisposition = WorkflowExpression.Compile(contentDisposition, nameof(contentDisposition), required: false);
            return new DeferredBodyAction<QueryApiQueryExecutionJob, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/jobs/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
                callPayload.Queries["include_read_url"] = Convert.ToString("OnceCompleted");
                if (__workflow_includeReadUrl != null)
                    callPayload.Queries["include_read_url"] = ExpressionConverter.Convert(__workflow_includeReadUrl);
                callPayload.Queries["content_disposition"] = Convert.ToString("Attachment");
                if (__workflow_contentDisposition != null)
                    callPayload.Queries["content_disposition"] = ExpressionConverter.Convert(__workflow_contentDisposition);
                return new ApiConnectionAction<QueryApiQueryExecutionJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> CancelJob(Expression<Func<moduleInput>> module, Expression<Func<string>> jobId)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/jobs/{0}/cancel", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteQuery(Expression<Func<moduleInput>> module, Expression<Func<int>> queryId)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_queryId = WorkflowExpression.Compile(queryId, nameof(queryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/query/queries/{0}", __workflow_queryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
                callPayload.Queries["perform_delete"] = Convert.ToString(true);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> StartAdHocQueryExecutionJob(Expression<Func<moduleInput>> module, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat = null, Expression<Func<bodyformattingModeInput>> bodyformattingMode = null, Expression<Func<string>> bodyfilename = null, Expression<Func<int>> bodytimeZoneOffset = null, Expression<Func<bool>> bodyuseLongDescriptions = null)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            var __workflow_bodyformattingMode = WorkflowExpression.Compile(bodyformattingMode, nameof(bodyformattingMode), required: false);
            var __workflow_bodyfilename = WorkflowExpression.Compile(bodyfilename, nameof(bodyfilename), required: false);
            var __workflow_bodytimeZoneOffset = WorkflowExpression.Compile(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            var __workflow_bodyuseLongDescriptions = WorkflowExpression.Compile(bodyuseLongDescriptions, nameof(bodyuseLongDescriptions), required: false);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/queries/execute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (__workflow_bodyoutputFormat != null)
                {
                    if (__workflow_bodyoutputFormat != null)
                    {
                        body["output_format"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["output_format"] = "Csv";
                    bodypropCount++;
                }

                if (__workflow_bodyformattingMode != null)
                {
                    if (__workflow_bodyformattingMode != null)
                    {
                        body["formatting_mode"] = ExpressionConverter.ConvertO(__workflow_bodyformattingMode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["formatting_mode"] = "None";
                    bodypropCount++;
                }

                if (__workflow_bodyfilename != null)
                {
                    body["results_file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfilename);
                    bodypropCount++;
                }

                if (__workflow_bodytimeZoneOffset != null)
                {
                    body["time_zone_offset_in_minutes"] = ExpressionConverter.ConvertO(__workflow_bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (__workflow_bodyuseLongDescriptions != null)
                {
                    body["display_code_table_long_description"] = ExpressionConverter.ConvertO(__workflow_bodyuseLongDescriptions);
                    bodypropCount++;
                }

                body["ux_mode"] = "Asynchronous";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> StartQueryExecutionJob(Expression<Func<moduleInput>> module, Expression<Func<int>> bodytype, Expression<Func<int>> bodyquery, Expression<Func<bodyoutputFormatInput>> bodyoutputFormat = null, Expression<Func<bodyformattingModeInput>> bodyformattingMode = null, Expression<Func<bodysQLGenerationModeInput>> bodysQLGenerationMode = null, Expression<Func<bool>> bodyuseStaticQuery = null, Expression<Func<string>> bodyfilename = null, Expression<Func<int>> bodytimeZoneOffset = null, Expression<Func<bool>> bodyuseLongDescriptions = null, Expression<Func<QueryApiAskFieldInformation[]>> bodyaskField = null)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodyoutputFormat = WorkflowExpression.Compile(bodyoutputFormat, nameof(bodyoutputFormat), required: false);
            var __workflow_bodyformattingMode = WorkflowExpression.Compile(bodyformattingMode, nameof(bodyformattingMode), required: false);
            var __workflow_bodysQLGenerationMode = WorkflowExpression.Compile(bodysQLGenerationMode, nameof(bodysQLGenerationMode), required: false);
            var __workflow_bodyuseStaticQuery = WorkflowExpression.Compile(bodyuseStaticQuery, nameof(bodyuseStaticQuery), required: false);
            var __workflow_bodyfilename = WorkflowExpression.Compile(bodyfilename, nameof(bodyfilename), required: false);
            var __workflow_bodytimeZoneOffset = WorkflowExpression.Compile(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            var __workflow_bodyuseLongDescriptions = WorkflowExpression.Compile(bodyuseLongDescriptions, nameof(bodyuseLongDescriptions), required: false);
            var __workflow_bodyaskField = WorkflowExpression.Compile(bodyaskField, nameof(bodyaskField), required: false);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/queries/executebyid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["v_query_type_id"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                if (__workflow_bodyoutputFormat != null)
                {
                    if (__workflow_bodyoutputFormat != null)
                    {
                        body["output_format"] = ExpressionConverter.ConvertO(__workflow_bodyoutputFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["output_format"] = "Csv";
                    bodypropCount++;
                }

                if (__workflow_bodyformattingMode != null)
                {
                    if (__workflow_bodyformattingMode != null)
                    {
                        body["formatting_mode"] = ExpressionConverter.ConvertO(__workflow_bodyformattingMode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["formatting_mode"] = "None";
                    bodypropCount++;
                }

                if (__workflow_bodysQLGenerationMode != null)
                {
                    if (__workflow_bodysQLGenerationMode != null)
                    {
                        body["sql_generation_mode"] = ExpressionConverter.ConvertO(__workflow_bodysQLGenerationMode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sql_generation_mode"] = "Query";
                    bodypropCount++;
                }

                if (__workflow_bodyuseStaticQuery != null)
                {
                    body["use_static_query_id_set"] = ExpressionConverter.ConvertO(__workflow_bodyuseStaticQuery);
                    bodypropCount++;
                }

                if (__workflow_bodyfilename != null)
                {
                    body["results_file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfilename);
                    bodypropCount++;
                }

                if (__workflow_bodytimeZoneOffset != null)
                {
                    body["time_zone_offset_in_minutes"] = ExpressionConverter.ConvertO(__workflow_bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (__workflow_bodyuseLongDescriptions != null)
                {
                    body["display_code_table_long_description"] = ExpressionConverter.ConvertO(__workflow_bodyuseLongDescriptions);
                    bodypropCount++;
                }

                if (__workflow_bodyaskField != null)
                {
                    body["ask_fields"] = ExpressionConverter.ConvertO(__workflow_bodyaskField);
                    bodypropCount++;
                }

                body["ux_mode"] = "Asynchronous";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration> StartRefreshStaticQueryExecutionJob(Expression<Func<moduleInput>> module, Expression<Func<int>> bodytype, Expression<Func<int>> bodyquery, Expression<Func<int>> bodytimeZoneOffset = null, Expression<Func<bool>> bodyuseLongDescriptions = null, Expression<Func<QueryApiAskFieldInformation[]>> bodyaskField = null)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyquery = WorkflowExpression.Compile(bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodytimeZoneOffset = WorkflowExpression.Compile(bodytimeZoneOffset, nameof(bodytimeZoneOffset), required: false);
            var __workflow_bodyuseLongDescriptions = WorkflowExpression.Compile(bodyuseLongDescriptions, nameof(bodyuseLongDescriptions), required: false);
            var __workflow_bodyaskField = WorkflowExpression.Compile(bodyaskField, nameof(bodyaskField), required: false);
            return new DeferredBodyAction<QueryApiExecuteQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/query/queries/refreshstaticquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["v_query_type_id"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                if (__workflow_bodytimeZoneOffset != null)
                {
                    body["time_zone_offset_in_minutes"] = ExpressionConverter.ConvertO(__workflow_bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (__workflow_bodyuseLongDescriptions != null)
                {
                    body["display_code_table_long_description"] = ExpressionConverter.ConvertO(__workflow_bodyuseLongDescriptions);
                    bodypropCount++;
                }

                if (__workflow_bodyaskField != null)
                {
                    body["ask_fields"] = ExpressionConverter.ConvertO(__workflow_bodyaskField);
                    bodypropCount++;
                }

                body["ux_mode"] = "Asynchronous";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryApiExecuteQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtquery")]
        public IBodyWorkflowAction<QueryApiQuerySummaryV2Collection, ApiConnectionActionConfiguration> ListQueries(Expression<Func<moduleInput>> module, Expression<Func<int>> queryTypeIds = null, Expression<Func<int>> category = null, Expression<Func<queryFormatInput>> queryFormat = null, Expression<Func<resultLayoutInput>> resultLayout = null, Expression<Func<string>> searchText = null, Expression<Func<bool>> myFavQueriesOnly = null, Expression<Func<bool>> myQueriesOnly = null, Expression<Func<bool>> mergedQueriesOnly = null, Expression<Func<listQueriesInput>> listQueries = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<bool>> sortDescending = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> addedBy = null, Expression<Func<int>> limit = null, Expression<Func<string>> continuationToken = null)
        {
            var __workflow_module = WorkflowExpression.Compile(module, nameof(module), required: true);
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
                callPayload.Queries["product"] = Convert.ToString("FE");
                callPayload.Queries["module"] = ExpressionConverter.Convert(__workflow_module);
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

    public class BlackbaudfenxtqueryTriggers([ConnectionName] string connectionId)
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
    public enum moduleInput
    {
        GeneralLedger,
        AccountsPayable,
        AccountsReceivable,
        FixedAssets,
        CashReceipts
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoutputFormatInput
    {
        Csv,
        Json,
        Jsonl,
        Xlsx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyformattingModeInput
    {
        None,
        UI,
        Export
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysQLGenerationModeInput
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

        [JsonProperty("suppress_duplicates")]
        public bool SuppressDuplicates { get; set; }

        [JsonProperty("output_limit")]
        public QueryApiQuerySummaryOutputLimitType OutputLimit { get; set; }

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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtquery;

    public partial class WorkflowManagedActions
    {
        public BlackbaudfenxtqueryActions Blackbaudfenxtquery(string connectionId) => new BlackbaudfenxtqueryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudfenxtqueryTriggers Blackbaudfenxtquery(string connectionId) => new BlackbaudfenxtqueryTriggers(connectionId);
    }
}