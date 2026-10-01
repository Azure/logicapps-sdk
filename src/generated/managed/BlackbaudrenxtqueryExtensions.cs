//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudrenxtquery
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudrenxtqueryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiQueryExecutionJob> GetQueryJobStatus([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<includeReadUrlInput> includeReadUrl = null, [WorkflowExpression] Func<contentDispositionInput> contentDisposition = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/query/jobs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Queries["include_read_url"] = Convert.ToString("OnceCompleted");
                if (includeReadUrl != null)
                    callPayload.Queries["include_read_url"] = SourceExpressionConverter.Convert(includeReadUrl);
                callPayload.Queries["content_disposition"] = Convert.ToString("Attachment");
                if (contentDisposition != null)
                    callPayload.Queries["content_disposition"] = SourceExpressionConverter.Convert(contentDisposition);
                return callPayload;
            }

            return new ApiConnectionAction<QueryApiQueryExecutionJob>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> CancelJob([WorkflowExpression] Func<string> jobId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/query/jobs/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                return callPayload;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IWorkflowAction DeleteQuery([WorkflowExpression] Func<int> queryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/query/queries/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(queryId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                callPayload.Queries["perform_delete"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartAdHocQueryExecutionJob([WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyformattingModeInput> bodyformattingMode = null, [WorkflowExpression] Func<string> bodyfilename = null, [WorkflowExpression] Func<int> bodytimeZoneOffset = null, [WorkflowExpression] Func<bool> bodyuseLongDescriptions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/queries/execute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodyoutputFormat != null)
                {
                    if (bodyoutputFormat != null)
                    {
                        body["output_format"] = SourceExpressionConverter.Convert(bodyoutputFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["output_format"] = "Csv";
                    bodypropCount++;
                }

                if (bodyformattingMode != null)
                {
                    if (bodyformattingMode != null)
                    {
                        body["formatting_mode"] = SourceExpressionConverter.Convert(bodyformattingMode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["formatting_mode"] = "None";
                    bodypropCount++;
                }

                if (bodyfilename != null)
                {
                    body["results_file_name"] = SourceExpressionConverter.ConvertToken(bodyfilename);
                    bodypropCount++;
                }

                if (bodytimeZoneOffset != null)
                {
                    body["time_zone_offset_in_minutes"] = SourceExpressionConverter.ConvertToken(bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (bodyuseLongDescriptions != null)
                {
                    body["display_code_table_long_description"] = SourceExpressionConverter.ConvertToken(bodyuseLongDescriptions);
                    bodypropCount++;
                }

                body["ux_mode"] = "Asynchronous";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartQueryExecutionJob([WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyquery, [WorkflowExpression] Func<bodyoutputFormatInput> bodyoutputFormat = null, [WorkflowExpression] Func<bodyformattingModeInput> bodyformattingMode = null, [WorkflowExpression] Func<bodysQLGenerationModeInput> bodysQLGenerationMode = null, [WorkflowExpression] Func<bool> bodyuseStaticQuery = null, [WorkflowExpression] Func<string> bodyfilename = null, [WorkflowExpression] Func<int> bodytimeZoneOffset = null, [WorkflowExpression] Func<bool> bodyuseLongDescriptions = null, [WorkflowExpression] Func<QueryApiAskFieldInformation[]> bodyaskField = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/queries/executebyid";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["v_query_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodyoutputFormat != null)
                {
                    if (bodyoutputFormat != null)
                    {
                        body["output_format"] = SourceExpressionConverter.Convert(bodyoutputFormat);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["output_format"] = "Csv";
                    bodypropCount++;
                }

                if (bodyformattingMode != null)
                {
                    if (bodyformattingMode != null)
                    {
                        body["formatting_mode"] = SourceExpressionConverter.Convert(bodyformattingMode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["formatting_mode"] = "None";
                    bodypropCount++;
                }

                if (bodysQLGenerationMode != null)
                {
                    if (bodysQLGenerationMode != null)
                    {
                        body["sql_generation_mode"] = SourceExpressionConverter.Convert(bodysQLGenerationMode);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sql_generation_mode"] = "Query";
                    bodypropCount++;
                }

                if (bodyuseStaticQuery != null)
                {
                    body["use_static_query_id_set"] = SourceExpressionConverter.ConvertToken(bodyuseStaticQuery);
                    bodypropCount++;
                }

                if (bodyfilename != null)
                {
                    body["results_file_name"] = SourceExpressionConverter.ConvertToken(bodyfilename);
                    bodypropCount++;
                }

                if (bodytimeZoneOffset != null)
                {
                    body["time_zone_offset_in_minutes"] = SourceExpressionConverter.ConvertToken(bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (bodyuseLongDescriptions != null)
                {
                    body["display_code_table_long_description"] = SourceExpressionConverter.ConvertToken(bodyuseLongDescriptions);
                    bodypropCount++;
                }

                if (bodyaskField != null)
                {
                    body["ask_fields"] = SourceExpressionConverter.ConvertToken(bodyaskField);
                    bodypropCount++;
                }

                body["ux_mode"] = "Asynchronous";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiExecuteQueryResponse> StartRefreshStaticQueryExecutionJob([WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodyquery, [WorkflowExpression] Func<int> bodytimeZoneOffset = null, [WorkflowExpression] Func<bool> bodyuseLongDescriptions = null, [WorkflowExpression] Func<QueryApiAskFieldInformation[]> bodyaskField = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/queries/refreshstaticquery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["v_query_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodytimeZoneOffset != null)
                {
                    body["time_zone_offset_in_minutes"] = SourceExpressionConverter.ConvertToken(bodytimeZoneOffset);
                    bodypropCount++;
                }

                if (bodyuseLongDescriptions != null)
                {
                    body["display_code_table_long_description"] = SourceExpressionConverter.ConvertToken(bodyuseLongDescriptions);
                    bodypropCount++;
                }

                if (bodyaskField != null)
                {
                    body["ask_fields"] = SourceExpressionConverter.ConvertToken(bodyaskField);
                    bodypropCount++;
                }

                body["ux_mode"] = "Asynchronous";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryApiExecuteQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudrenxtquery")]
        public IBodyWorkflowAction<QueryApiQuerySummaryV2Collection> ListQueries([WorkflowExpression] Func<int> queryTypeIds = null, [WorkflowExpression] Func<int> category = null, [WorkflowExpression] Func<queryFormatInput> queryFormat = null, [WorkflowExpression] Func<resultLayoutInput> resultLayout = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<bool> myFavQueriesOnly = null, [WorkflowExpression] Func<bool> myQueriesOnly = null, [WorkflowExpression] Func<bool> mergedQueriesOnly = null, [WorkflowExpression] Func<listQueriesInput> listQueries = null, [WorkflowExpression] Func<sortColumnInput> sortColumn = null, [WorkflowExpression] Func<bool> sortDescending = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> addedBy = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> continuationToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/query/v2/queries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["product"] = Convert.ToString("RE");
                callPayload.Queries["module"] = Convert.ToString("None");
                if (queryTypeIds != null)
                    callPayload.Queries["query_type_ids"] = SourceExpressionConverter.ConvertO(queryTypeIds);
                if (category != null)
                    callPayload.Queries["category"] = SourceExpressionConverter.ConvertO(category);
                if (queryFormat != null)
                    callPayload.Queries["query_format"] = SourceExpressionConverter.Convert(queryFormat);
                if (resultLayout != null)
                    callPayload.Queries["result_layout"] = SourceExpressionConverter.Convert(resultLayout);
                if (searchText != null)
                    callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (myFavQueriesOnly != null)
                    callPayload.Queries["my_fav_queries_only"] = SourceExpressionConverter.ConvertO(myFavQueriesOnly);
                if (myQueriesOnly != null)
                    callPayload.Queries["my_queries_only"] = SourceExpressionConverter.ConvertO(myQueriesOnly);
                if (mergedQueriesOnly != null)
                    callPayload.Queries["merged_queries_only"] = SourceExpressionConverter.ConvertO(mergedQueriesOnly);
                if (listQueries != null)
                    callPayload.Queries["list_queries"] = SourceExpressionConverter.Convert(listQueries);
                if (sortColumn != null)
                    callPayload.Queries["sort_column"] = SourceExpressionConverter.Convert(sortColumn);
                if (sortDescending != null)
                    callPayload.Queries["sort_descending"] = SourceExpressionConverter.ConvertO(sortDescending);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (addedBy != null)
                    callPayload.Queries["added_by"] = SourceExpressionConverter.ConvertO(addedBy);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (continuationToken != null)
                    callPayload.Queries["continuation_token"] = SourceExpressionConverter.ConvertO(continuationToken);
                return callPayload;
            }

            return new ApiConnectionAction<QueryApiQuerySummaryV2Collection>(BuildSourceInput);
        }
    }

    public class BlackbaudrenxtqueryTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryApiQueryExecutionJob
    {
        [JsonProperty("id")]
        public string JobID { get; set; }

        [JsonProperty("status")]
        public QueryApiQueryExecutionJobStatusType Status { get; set; }

        [JsonProperty("row_count")]
        public int RowCount { get; set; }

        [JsonProperty("sas_uri")]
        public string QueryResultsURI { get; set; }
    }

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

    public enum includeReadUrlInput
    {
        Never,
        OnceRunning,
        OnceCompleted
    }

    public enum contentDispositionInput
    {
        Inline,
        Attachment
    }

    public class QueryApiExecuteQueryResponse
    {
        [JsonProperty("id")]
        public string JobID { get; set; }

        [JsonProperty("status")]
        public QueryApiExecuteQueryResponseStatusType Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

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

    public enum bodyoutputFormatInput
    {
        Csv,
        Json,
        Jsonl,
        Xlsx
    }

    public enum bodyformattingModeInput
    {
        None,
        UI,
        Export
    }

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
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("type_id")]
        public int TypeID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("category_id")]
        public int CategoryID { get; set; }

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
        public int SelectFromQueryID { get; set; }

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

    public enum QueryApiQuerySummaryFormatType
    {
        Dynamic,
        Static
    }

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

    public enum QueryApiQuerySummaryResultLayoutType
    {
        MultiRow,
        SingleRow
    }

    public enum queryFormatInput
    {
        Dynamic,
        Static
    }

    public enum resultLayoutInput
    {
        MultiRow,
        SingleRow
    }

    public enum listQueriesInput
    {
        Unset,
        NoListQueries
    }

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