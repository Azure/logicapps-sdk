//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fdic
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FdicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<InstitutionsResponse, ApiConnectionActionConfiguration> SearchInstitutions(Expression<Func<string>> filters = null, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<InstitutionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/institutions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("NAME");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<InstitutionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<LocationsResponse, ApiConnectionActionConfiguration> SearchLocations(Expression<Func<string>> filters = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<LocationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("NAME");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<LocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<HistoryResponse, ApiConnectionActionConfiguration> GetHistory(Expression<Func<string>> filters = null, Expression<Func<string>> search = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> aggBy = null, Expression<Func<string>> aggTermFields = null, Expression<Func<int>> aggLimit = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_aggBy = WorkflowExpression.Compile(aggBy, nameof(aggBy), required: false);
            var __workflow_aggTermFields = WorkflowExpression.Compile(aggTermFields, nameof(aggTermFields), required: false);
            var __workflow_aggLimit = WorkflowExpression.Compile(aggLimit, nameof(aggLimit), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<HistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("PROCDATE");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(__workflow_aggBy);
                if (__workflow_aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(__workflow_aggTermFields);
                callPayload.Queries["agg_limit"] = Convert.ToString(10);
                if (__workflow_aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(__workflow_aggLimit);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<HistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<FinancialsResponse, ApiConnectionActionConfiguration> GetFinancials(Expression<Func<string>> filters = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> aggBy = null, Expression<Func<string>> aggTermFields = null, Expression<Func<string>> aggSumFields = null, Expression<Func<int>> aggLimit = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_aggBy = WorkflowExpression.Compile(aggBy, nameof(aggBy), required: false);
            var __workflow_aggTermFields = WorkflowExpression.Compile(aggTermFields, nameof(aggTermFields), required: false);
            var __workflow_aggSumFields = WorkflowExpression.Compile(aggSumFields, nameof(aggSumFields), required: false);
            var __workflow_aggLimit = WorkflowExpression.Compile(aggLimit, nameof(aggLimit), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<FinancialsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/financials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("REPDTE");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(__workflow_aggBy);
                if (__workflow_aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(__workflow_aggTermFields);
                if (__workflow_aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(__workflow_aggSumFields);
                if (__workflow_aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(__workflow_aggLimit);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<FinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<SummaryResponse, ApiConnectionActionConfiguration> GetHistorical(Expression<Func<string>> filters = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> aggBy = null, Expression<Func<string>> aggTermFields = null, Expression<Func<string>> aggSumFields = null, Expression<Func<int>> aggLimit = null, Expression<Func<string>> maxValue = null, Expression<Func<string>> maxValueBy = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_aggBy = WorkflowExpression.Compile(aggBy, nameof(aggBy), required: false);
            var __workflow_aggTermFields = WorkflowExpression.Compile(aggTermFields, nameof(aggTermFields), required: false);
            var __workflow_aggSumFields = WorkflowExpression.Compile(aggSumFields, nameof(aggSumFields), required: false);
            var __workflow_aggLimit = WorkflowExpression.Compile(aggLimit, nameof(aggLimit), required: false);
            var __workflow_maxValue = WorkflowExpression.Compile(maxValue, nameof(maxValue), required: false);
            var __workflow_maxValueBy = WorkflowExpression.Compile(maxValueBy, nameof(maxValueBy), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<SummaryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/summary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("YEAR");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(__workflow_aggBy);
                if (__workflow_aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(__workflow_aggTermFields);
                if (__workflow_aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(__workflow_aggSumFields);
                if (__workflow_aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(__workflow_aggLimit);
                if (__workflow_maxValue != null)
                    callPayload.Queries["max_value"] = ExpressionConverter.Convert(__workflow_maxValue);
                if (__workflow_maxValueBy != null)
                    callPayload.Queries["max_value_by"] = ExpressionConverter.Convert(__workflow_maxValueBy);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<SummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<FailuresResponse, ApiConnectionActionConfiguration> GetFailures(Expression<Func<string>> filters = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> totalFields = null, Expression<Func<string>> subtotalBy = null, Expression<Func<string>> aggBy = null, Expression<Func<string>> aggTermFields = null, Expression<Func<string>> aggSumFields = null, Expression<Func<int>> aggLimit = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_totalFields = WorkflowExpression.Compile(totalFields, nameof(totalFields), required: false);
            var __workflow_subtotalBy = WorkflowExpression.Compile(subtotalBy, nameof(subtotalBy), required: false);
            var __workflow_aggBy = WorkflowExpression.Compile(aggBy, nameof(aggBy), required: false);
            var __workflow_aggTermFields = WorkflowExpression.Compile(aggTermFields, nameof(aggTermFields), required: false);
            var __workflow_aggSumFields = WorkflowExpression.Compile(aggSumFields, nameof(aggSumFields), required: false);
            var __workflow_aggLimit = WorkflowExpression.Compile(aggLimit, nameof(aggLimit), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<FailuresResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/failures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("FAILDATE");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_totalFields != null)
                    callPayload.Queries["total_fields"] = ExpressionConverter.Convert(__workflow_totalFields);
                if (__workflow_subtotalBy != null)
                    callPayload.Queries["subtotal_by"] = ExpressionConverter.Convert(__workflow_subtotalBy);
                if (__workflow_aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(__workflow_aggBy);
                if (__workflow_aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(__workflow_aggTermFields);
                if (__workflow_aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(__workflow_aggSumFields);
                callPayload.Queries["agg_limit"] = Convert.ToString(10);
                if (__workflow_aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(__workflow_aggLimit);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<FailuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<SodResponse, ApiConnectionActionConfiguration> GetSod(Expression<Func<string>> filters = null, Expression<Func<string>> fields = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortOrder = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> aggBy = null, Expression<Func<string>> aggTermFields = null, Expression<Func<string>> aggSumFields = null, Expression<Func<int>> aggLimit = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_aggBy = WorkflowExpression.Compile(aggBy, nameof(aggBy), required: false);
            var __workflow_aggTermFields = WorkflowExpression.Compile(aggTermFields, nameof(aggTermFields), required: false);
            var __workflow_aggSumFields = WorkflowExpression.Compile(aggSumFields, nameof(aggSumFields), required: false);
            var __workflow_aggLimit = WorkflowExpression.Compile(aggLimit, nameof(aggLimit), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<SodResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sod";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                callPayload.Queries["sort_by"] = Convert.ToString("YEAR");
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(__workflow_aggBy);
                if (__workflow_aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(__workflow_aggTermFields);
                if (__workflow_aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(__workflow_aggSumFields);
                if (__workflow_aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(__workflow_aggLimit);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<SodResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        public IBodyWorkflowAction<DemographicsResponse, ApiConnectionActionConfiguration> GetDemographics(Expression<Func<string>> filters = null, Expression<Func<FormatInput>> format = null, Expression<Func<bool>> download = null, Expression<Func<string>> fileName = null)
        {
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<DemographicsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/demographics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(__workflow_download);
                if (__workflow_fileName != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_fileName);
                return new ApiConnectionAction<DemographicsResponse>(callPayload);
            });
        }
    }

    public class FdicTriggers([ConnectionName] string connectionId)
    {
    }

    public class InstitutionsResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Institution[] Data { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }

        [JsonProperty("index")]
        public Index Index { get; set; }
    }

    public class Index
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createTimestamp")]
        public string CreateTimestamp { get; set; }
    }

    public class Institution
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("ACTIVE")]
        public int Active { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ASSET")]
        public double Asset { get; set; }

        [JsonProperty("BKCLASS")]
        public DataBkclassType Bkclass { get; set; }
        public string CB { get; set; }

        [JsonProperty("CBSA")]
        public string Cbsa { get; set; }

        [JsonProperty("CBSA_DIV")]
        public string CbsaDiv { get; set; }

        [JsonProperty("CBSA_DIV_FLG")]
        public string CbsaDivFlg { get; set; }

        [JsonProperty("CBSA_DIV_NO")]
        public string CbsaDivNo { get; set; }

        [JsonProperty("CBSA_METRO")]
        public string CbsaMetro { get; set; }

        [JsonProperty("CBSA_METRO_FLG")]
        public string CbsaMetroFlg { get; set; }

        [JsonProperty("CBSA_METRO_NAME")]
        public string CbsaMetroName { get; set; }

        [JsonProperty("CBSA_MICRO_FLG")]
        public string CbsaMicroFlg { get; set; }

        [JsonProperty("CBSA_NO")]
        public string CbsaNo { get; set; }

        [JsonProperty("CERT")]
        public double Cert { get; set; }

        [JsonProperty("CERTCONS")]
        public string Certcons { get; set; }

        [JsonProperty("CFPBEFFDTE")]
        public string Cfpbeffdte { get; set; }

        [JsonProperty("CFPBENDDTE")]
        public string Cfpbenddte { get; set; }

        [JsonProperty("CFPBFLAG")]
        public int Cfpbflag { get; set; }

        [JsonProperty("PRIORNAME1")]
        public string Priorname1 { get; set; }

        [JsonProperty("PRIORNAME2")]
        public JToken Priorname2 { get; set; }

        [JsonProperty("PRIORNAME3")]
        public JToken Priorname3 { get; set; }

        [JsonProperty("PRIORNAME4")]
        public JToken Priorname4 { get; set; }

        [JsonProperty("PRIORNAME5")]
        public JToken Priorname5 { get; set; }

        [JsonProperty("PRIORNAME6")]
        public JToken Priorname6 { get; set; }

        [JsonProperty("PRIORNAME7")]
        public JToken Priorname7 { get; set; }

        [JsonProperty("PRIORNAME8")]
        public JToken Priorname8 { get; set; }

        [JsonProperty("PRIORNAME9")]
        public JToken Priorname9 { get; set; }

        [JsonProperty("PRIORNAME10")]
        public JToken Priorname10 { get; set; }

        [JsonProperty("CHANGEC1")]
        public int Changec1 { get; set; }

        [JsonProperty("CHANGEC2")]
        public string Changec2 { get; set; }

        [JsonProperty("CHANGEC3")]
        public string Changec3 { get; set; }

        [JsonProperty("CHANGEC4")]
        public string Changec4 { get; set; }

        [JsonProperty("CHANGEC5")]
        public string Changec5 { get; set; }

        [JsonProperty("CHANGEC6")]
        public string Changec6 { get; set; }

        [JsonProperty("CHANGEC7")]
        public string Changec7 { get; set; }

        [JsonProperty("CHANGEC8")]
        public string Changec8 { get; set; }

        [JsonProperty("CHANGEC9")]
        public string Changec9 { get; set; }

        [JsonProperty("CHANGEC10")]
        public string Changec10 { get; set; }

        [JsonProperty("CHANGEC11")]
        public string Changec11 { get; set; }

        [JsonProperty("CHANGEC12")]
        public string Changec12 { get; set; }

        [JsonProperty("CHANGEC13")]
        public string Changec13 { get; set; }

        [JsonProperty("CHANGEC14")]
        public string Changec14 { get; set; }

        [JsonProperty("CHANGEC15")]
        public int Changec15 { get; set; }

        [JsonProperty("CHARTER")]
        public string Charter { get; set; }

        [JsonProperty("CHRTAGNT")]
        public string Chrtagnt { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CITYHCR")]
        public string Cityhcr { get; set; }

        [JsonProperty("CLCODE")]
        public string Clcode { get; set; }

        [JsonProperty("CONSERVE")]
        public string Conserve { get; set; }

        [JsonProperty("COUNTY")]
        public string County { get; set; }

        [JsonProperty("CSA")]
        public string Csa { get; set; }

        [JsonProperty("CSA_NO")]
        public string CsaNo { get; set; }

        [JsonProperty("CSA_FLG")]
        public string CsaFlg { get; set; }

        [JsonProperty("DATEUPDT")]
        public string Dateupdt { get; set; }

        [JsonProperty("DENOVO")]
        public string Denovo { get; set; }

        [JsonProperty("DEP")]
        public double Dep { get; set; }

        [JsonProperty("DEPDOM")]
        public double Depdom { get; set; }

        [JsonProperty("DOCKET")]
        public string Docket { get; set; }

        [JsonProperty("EFFDATE")]
        public string Effdate { get; set; }

        [JsonProperty("ENDEFYMD")]
        public string Endefymd { get; set; }
        public string EQ { get; set; }

        [JsonProperty("ESTYMD")]
        public string Estymd { get; set; }

        [JsonProperty("FDICDBS")]
        public double Fdicdbs { get; set; }

        [JsonProperty("FDICREGN")]
        public string Fdicregn { get; set; }

        [JsonProperty("FDICSUPV")]
        public string Fdicsupv { get; set; }

        [JsonProperty("FED")]
        public string Fed { get; set; }

        [JsonProperty("FED_RSSD")]
        public string FedRssd { get; set; }

        [JsonProperty("FEDCHRTR")]
        public int Fedchrtr { get; set; }

        [JsonProperty("FORM31")]
        public string Form31 { get; set; }

        [JsonProperty("HCTMULT")]
        public string Hctmult { get; set; }

        [JsonProperty("IBA")]
        public int Iba { get; set; }

        [JsonProperty("INACTIVE")]
        public int Inactive { get; set; }

        [JsonProperty("INSAGNT1")]
        public string Insagnt1 { get; set; }

        [JsonProperty("INSAGNT2")]
        public string Insagnt2 { get; set; }

        [JsonProperty("INSBIF")]
        public int Insbif { get; set; }

        [JsonProperty("INSCOML")]
        public int Inscoml { get; set; }

        [JsonProperty("INSDATE")]
        public string Insdate { get; set; }

        [JsonProperty("INSDROPDATE_RAW")]
        public string InsdropdateRaw { get; set; }

        [JsonProperty("INSDROPDATE")]
        public string Insdropdate { get; set; }

        [JsonProperty("INSDIF")]
        public int Insdif { get; set; }

        [JsonProperty("INSFDIC")]
        public double Insfdic { get; set; }

        [JsonProperty("INSSAIF")]
        public int Inssaif { get; set; }

        [JsonProperty("INSSAVE")]
        public int Inssave { get; set; }

        [JsonProperty("INSTAG")]
        public string Instag { get; set; }

        [JsonProperty("INSTCRCD")]
        public int Instcrcd { get; set; }

        [JsonProperty("LATITUDE")]
        public double Latitude { get; set; }

        [JsonProperty("LAW_SASSER_FLG")]
        public string LawSasserFlg { get; set; }

        [JsonProperty("LONGITUDE")]
        public double Longitude { get; set; }

        [JsonProperty("MDI_STATUS_CODE")]
        public string MdiStatusCode { get; set; }

        [JsonProperty("MDI_STATUS_DESC")]
        public string MdiStatusDesc { get; set; }

        [JsonProperty("MUTUAL")]
        public string Mutual { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("NAMEHCR")]
        public string Namehcr { get; set; }

        [JsonProperty("NETINC")]
        public double Netinc { get; set; }

        [JsonProperty("NETINCQ")]
        public double Netincq { get; set; }

        [JsonProperty("NEWCERT")]
        public int Newcert { get; set; }

        [JsonProperty("OAKAR")]
        public int Oakar { get; set; }

        [JsonProperty("OCCDIST")]
        public string Occdist { get; set; }

        [JsonProperty("OFFDOM")]
        public double Offdom { get; set; }

        [JsonProperty("OFFFOR")]
        public double Offfor { get; set; }

        [JsonProperty("OFFICES")]
        public double Offices { get; set; }

        [JsonProperty("OFFOA")]
        public double Offoa { get; set; }

        [JsonProperty("PARCERT")]
        public string Parcert { get; set; }

        [JsonProperty("PROCDATE")]
        public string Procdate { get; set; }

        [JsonProperty("QBPRCOML")]
        public string Qbprcoml { get; set; }

        [JsonProperty("REGAGNT")]
        public string Regagnt { get; set; }

        [JsonProperty("REGAGENT2")]
        public string Regagent2 { get; set; }

        [JsonProperty("REPDTE")]
        public string Repdte { get; set; }

        [JsonProperty("RISDATE")]
        public string Risdate { get; set; }

        [JsonProperty("ROA")]
        public double Roa { get; set; }

        [JsonProperty("ROAPTX")]
        public double Roaptx { get; set; }

        [JsonProperty("ROAPTXQ")]
        public double Roaptxq { get; set; }

        [JsonProperty("ROAQ")]
        public double Roaq { get; set; }

        [JsonProperty("ROE")]
        public double Roe { get; set; }

        [JsonProperty("ROEQ")]
        public double Roeq { get; set; }

        [JsonProperty("RSSDHCR")]
        public string Rssdhcr { get; set; }

        [JsonProperty("RUNDATE")]
        public string Rundate { get; set; }

        [JsonProperty("SASSER")]
        public int Sasser { get; set; }

        [JsonProperty("SPECGRP")]
        public double Specgrp { get; set; }

        [JsonProperty("SPECGRPN")]
        public string Specgrpn { get; set; }

        [JsonProperty("STALP")]
        public string Stalp { get; set; }

        [JsonProperty("STALPHCR")]
        public string Stalphcr { get; set; }

        [JsonProperty("STCHRTR")]
        public int Stchrtr { get; set; }

        [JsonProperty("STCNTY")]
        public string Stcnty { get; set; }

        [JsonProperty("STNAME")]
        public string Stname { get; set; }

        [JsonProperty("STNUM")]
        public string Stnum { get; set; }

        [JsonProperty("SUBCHAPS")]
        public string Subchaps { get; set; }

        [JsonProperty("SUPRV_FD")]
        public string SuprvFd { get; set; }
        public string TE01N528 { get; set; }
        public string TE02N528 { get; set; }
        public string TE03N528 { get; set; }
        public string TE04N528 { get; set; }
        public string TE05N528 { get; set; }
        public string TE06N528 { get; set; }
        public string TE07N528 { get; set; }
        public string TE08N528 { get; set; }
        public string TE09N528 { get; set; }
        public string TE10N528 { get; set; }
        public string TE01N529 { get; set; }
        public string TE02N529 { get; set; }
        public string TE03N529 { get; set; }
        public string TE04N529 { get; set; }
        public string TE05N529 { get; set; }
        public string TE06N529 { get; set; }

        [JsonProperty("TRACT")]
        public string Tract { get; set; }

        [JsonProperty("TRUST")]
        public string Trust { get; set; }

        [JsonProperty("ULTCERT")]
        public string Ultcert { get; set; }

        [JsonProperty("UNINUM")]
        public string Uninum { get; set; }

        [JsonProperty("WEBADDR")]
        public string Webaddr { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataBkclassType
    {
        N,
        SM,
        NM,
        SB,
        SA,
        OI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv
    }

    public class LocationsResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Location[] Data { get; set; }
    }

    public class Location
    {
        [JsonProperty("data")]
        public Data1 Data { get; set; }
    }

    public class Data1
    {
        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("BKCLASS")]
        public Data1BkclassType Bkclass { get; set; }

        [JsonProperty("CBSA")]
        public string Cbsa { get; set; }

        [JsonProperty("CBSA_DIV")]
        public string CbsaDiv { get; set; }

        [JsonProperty("CBSA_DIV_FLG")]
        public Data1CbsaDivFlgType CbsaDivFlg { get; set; }

        [JsonProperty("CBSA_DIV_NO")]
        public string CbsaDivNo { get; set; }

        [JsonProperty("CBSA_METRO")]
        public string CbsaMetro { get; set; }

        [JsonProperty("CBSA_METRO_FLG")]
        public string CbsaMetroFlg { get; set; }

        [JsonProperty("CBSA_METRO_NAME")]
        public string CbsaMetroName { get; set; }

        [JsonProperty("CBSA_MICRO_FLG")]
        public Data1CbsaMicroFlgType CbsaMicroFlg { get; set; }

        [JsonProperty("CBSA_NO")]
        public string CbsaNo { get; set; }

        [JsonProperty("CERT")]
        public string Cert { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("COUNTY")]
        public string County { get; set; }

        [JsonProperty("CSA")]
        public string Csa { get; set; }

        [JsonProperty("CSA_FLG")]
        public Data1CsaFlgType CsaFlg { get; set; }

        [JsonProperty("CSA_NO")]
        public string CsaNo { get; set; }

        [JsonProperty("ESTYMD")]
        public string Estymd { get; set; }

        [JsonProperty("FI_UNINUM")]
        public int FiUninum { get; set; }

        [JsonProperty("LATITUDE")]
        public double Latitude { get; set; }

        [JsonProperty("LONGITUDE")]
        public double Longitude { get; set; }

        [JsonProperty("MDI_STATUS_CODE")]
        public string MdiStatusCode { get; set; }

        [JsonProperty("MDI_STATUS_DESC")]
        public string MdiStatusDesc { get; set; }

        [JsonProperty("MAINOFF")]
        public Data1MainoffType Mainoff { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("OFFNAME")]
        public string Offname { get; set; }

        [JsonProperty("OFFNUM")]
        public int Offnum { get; set; }

        [JsonProperty("RUNDATE")]
        public string Rundate { get; set; }

        [JsonProperty("SERVTYPE")]
        public Data1ServtypeType Servtype { get; set; }

        [JsonProperty("SERVTYPE_DESC")]
        public string ServtypeDesc { get; set; }

        [JsonProperty("STALP")]
        public string Stalp { get; set; }

        [JsonProperty("STCNTY")]
        public string Stcnty { get; set; }

        [JsonProperty("STNAME")]
        public string Stname { get; set; }

        [JsonProperty("UNINUM")]
        public int Uninum { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1BkclassType
    {
        N,
        SM,
        NM,
        SB,
        SA,
        OI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1CbsaDivFlgType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1CbsaMicroFlgType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1CsaFlgType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum Data1MainoffType
    {
        _0 = 0,
        _1 = 1
    }

    public enum Data1ServtypeType
    {
        _11 = 11,
        _12 = 12,
        _13 = 13,
        _14 = 14,
        _15 = 15,
        _16 = 16,
        _21 = 21,
        _22 = 22,
        _23 = 23,
        _24 = 24,
        _25 = 25,
        _26 = 26,
        _27 = 27,
        _28 = 28,
        _29 = 29,
        _30 = 30
    }

    public class HistoryResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public History[] Data { get; set; }

        [JsonProperty("totals")]
        public HistoryResponseTotalsType Totals { get; set; }
    }

    public class History
    {
        [JsonProperty("data")]
        public Data4 Data { get; set; }
    }

    public class Data4
    {
        [JsonProperty("TRANSNUM")]
        public double Transnum { get; set; }

        [JsonProperty("CHANGECODE")]
        public double Changecode { get; set; }

        [JsonProperty("CHANGECODE_DESC")]
        public string ChangecodeDesc { get; set; }

        [JsonProperty("PROCDATE")]
        public string Procdate { get; set; }

        [JsonProperty("EFFDATE")]
        public string Effdate { get; set; }

        [JsonProperty("ENDDATE")]
        public string Enddate { get; set; }

        [JsonProperty("UNINUM")]
        public int Uninum { get; set; }

        [JsonProperty("ACQ_UNINUM")]
        public double AcqUninum { get; set; }

        [JsonProperty("OUT_UNINUM")]
        public double OutUninum { get; set; }

        [JsonProperty("ORG_ROLE_CDE")]
        public string OrgRoleCde { get; set; }

        [JsonProperty("REPORT_TYPE")]
        public double ReportType { get; set; }

        [JsonProperty("CLASS")]
        public string Class { get; set; }

        [JsonProperty("BANK_INSURED")]
        public string BankInsured { get; set; }

        [JsonProperty("ACQ_CHANGECODE")]
        public double AcqChangecode { get; set; }

        [JsonProperty("ACQ_ORG_EFF_DTE")]
        public string AcqOrgEffDte { get; set; }

        [JsonProperty("ACQ_INSTNAME")]
        public string AcqInstname { get; set; }

        [JsonProperty("ACQ_CERT")]
        public double AcqCert { get; set; }

        [JsonProperty("ACQ_CLCODE")]
        public double AcqClcode { get; set; }

        [JsonProperty("ACQ_CHARTER")]
        public double AcqCharter { get; set; }

        [JsonProperty("ACQ_CHARTAGENT")]
        public string AcqChartagent { get; set; }

        [JsonProperty("ACQ_FDICREGION")]
        public double AcqFdicregion { get; set; }

        [JsonProperty("ACQ_FDICREGION_DESC")]
        public string AcqFdicregionDesc { get; set; }

        [JsonProperty("ACQ_PADDR")]
        public string AcqPaddr { get; set; }

        [JsonProperty("ACQ_PCITY")]
        public string AcqPcity { get; set; }

        [JsonProperty("ACQ_PSTALP")]
        public string AcqPstalp { get; set; }

        [JsonProperty("ACQ_PZIP5")]
        public string AcqPzip5 { get; set; }

        [JsonProperty("ACQ_PZIPREST")]
        public string AcqPziprest { get; set; }

        [JsonProperty("ACQ_MADDR")]
        public string AcqMaddr { get; set; }

        [JsonProperty("ACQ_MCITY")]
        public string AcqMcity { get; set; }

        [JsonProperty("ACQ_MSTATE")]
        public string AcqMstate { get; set; }

        [JsonProperty("ACQ_MSTALP")]
        public string AcqMstalp { get; set; }

        [JsonProperty("ACQ_MZIP5")]
        public string AcqMzip5 { get; set; }

        [JsonProperty("ACQ_MZIPREST")]
        public string AcqMziprest { get; set; }

        [JsonProperty("ACQ_CLASS")]
        public string AcqClass { get; set; }

        [JsonProperty("ACQ_CNTYNAME")]
        public string AcqCntyname { get; set; }

        [JsonProperty("ACQ_CNTYNUM")]
        public double AcqCntynum { get; set; }

        [JsonProperty("ACQ_INSAGENT1")]
        public string AcqInsagent1 { get; set; }

        [JsonProperty("ACQ_INSAGENT2")]
        public string AcqInsagent2 { get; set; }

        [JsonProperty("ACQ_REGAGENT")]
        public string AcqRegagent { get; set; }

        [JsonProperty("ACQ_TRUST")]
        public string AcqTrust { get; set; }

        [JsonProperty("ACQ_LATITUDE")]
        public double AcqLatitude { get; set; }

        [JsonProperty("ACQ_LONGITUDE")]
        public double AcqLongitude { get; set; }

        [JsonProperty("OUT_INSTNAME")]
        public string OutInstname { get; set; }

        [JsonProperty("OUT_CERT")]
        public double OutCert { get; set; }

        [JsonProperty("OUT_CLCODE")]
        public double OutClcode { get; set; }

        [JsonProperty("OUT_CHARTER")]
        public double OutCharter { get; set; }

        [JsonProperty("OUT_CHARTAGENT")]
        public string OutChartagent { get; set; }

        [JsonProperty("OUT_FDICREGION")]
        public double OutFdicregion { get; set; }

        [JsonProperty("OUT_FDICREGION_DESC")]
        public string OutFdicregionDesc { get; set; }

        [JsonProperty("OUT_PADDR")]
        public string OutPaddr { get; set; }

        [JsonProperty("OUT_PCITY")]
        public string OutPcity { get; set; }

        [JsonProperty("OUT_PSTALP")]
        public string OutPstalp { get; set; }

        [JsonProperty("OUT_PZIP5")]
        public string OutPzip5 { get; set; }

        [JsonProperty("OUT_PZIPREST")]
        public string OutPziprest { get; set; }

        [JsonProperty("OUT_MADDR")]
        public string OutMaddr { get; set; }

        [JsonProperty("OUT_MCITY")]
        public string OutMcity { get; set; }

        [JsonProperty("OUT_MSTATE")]
        public string OutMstate { get; set; }

        [JsonProperty("OUT_MSTALP")]
        public string OutMstalp { get; set; }

        [JsonProperty("OUT_MZIP5")]
        public string OutMzip5 { get; set; }

        [JsonProperty("OUT_MZIPREST")]
        public string OutMziprest { get; set; }

        [JsonProperty("OUT_CLASS")]
        public string OutClass { get; set; }

        [JsonProperty("OUT_CNTYNAME")]
        public string OutCntyname { get; set; }

        [JsonProperty("OUT_CNTYNUM")]
        public double OutCntynum { get; set; }

        [JsonProperty("OUT_INSAGENT1")]
        public string OutInsagent1 { get; set; }

        [JsonProperty("OUT_INSAGENT2")]
        public string OutInsagent2 { get; set; }

        [JsonProperty("OUT_REGAGENT")]
        public string OutRegagent { get; set; }

        [JsonProperty("OUT_TRUST")]
        public string OutTrust { get; set; }

        [JsonProperty("OUT_LATITUDE")]
        public double OutLatitude { get; set; }

        [JsonProperty("OUT_LONGITUDE")]
        public double OutLongitude { get; set; }

        [JsonProperty("SUR_CHANGECODE")]
        public double SurChangecode { get; set; }

        [JsonProperty("SUR_CHANGECODE_DESC")]
        public string SurChangecodeDesc { get; set; }

        [JsonProperty("SUR_INSTNAME")]
        public string SurInstname { get; set; }

        [JsonProperty("SUR_CERT")]
        public double SurCert { get; set; }

        [JsonProperty("SUR_CLCODE")]
        public double SurClcode { get; set; }

        [JsonProperty("SUR_CHARTER")]
        public double SurCharter { get; set; }

        [JsonProperty("SUR_CHARTAGENT")]
        public string SurChartagent { get; set; }

        [JsonProperty("SUR_FDICREGION")]
        public double SurFdicregion { get; set; }

        [JsonProperty("SUR_FDICREGION_DESC")]
        public string SurFdicregionDesc { get; set; }

        [JsonProperty("SUR_MADDR")]
        public string SurMaddr { get; set; }

        [JsonProperty("SUR_MCITY")]
        public string SurMcity { get; set; }

        [JsonProperty("SUR_MSTATE")]
        public string SurMstate { get; set; }

        [JsonProperty("SUR_MSTALP")]
        public string SurMstalp { get; set; }

        [JsonProperty("SUR_MZIP5")]
        public string SurMzip5 { get; set; }

        [JsonProperty("SUR_PZIP5")]
        public string SurPzip5 { get; set; }

        [JsonProperty("SUR_CLASS")]
        public string SurClass { get; set; }

        [JsonProperty("SUR_CNTYNAME")]
        public string SurCntyname { get; set; }

        [JsonProperty("SUR_CNTYNUM")]
        public double SurCntynum { get; set; }

        [JsonProperty("SUR_INSAGENT1")]
        public string SurInsagent1 { get; set; }

        [JsonProperty("SUR_INSAGENT2")]
        public string SurInsagent2 { get; set; }

        [JsonProperty("SUR_PADDR")]
        public string SurPaddr { get; set; }

        [JsonProperty("SUR_PCITY")]
        public string SurPcity { get; set; }

        [JsonProperty("SUR_PSTALP")]
        public string SurPstalp { get; set; }

        [JsonProperty("SUR_PZIPREST")]
        public string SurPziprest { get; set; }

        [JsonProperty("SUR_REGAGENT")]
        public string SurRegagent { get; set; }

        [JsonProperty("SUR_TRUST")]
        public string SurTrust { get; set; }

        [JsonProperty("SUR_LATITUDE")]
        public double SurLatitude { get; set; }

        [JsonProperty("SUR_LONGITUDE")]
        public double SurLongitude { get; set; }

        [JsonProperty("FRM_CNTYNUM")]
        public double FrmCntynum { get; set; }

        [JsonProperty("FRM_PCITY")]
        public string FrmPcity { get; set; }

        [JsonProperty("FRM_REGAGENT")]
        public string FrmRegagent { get; set; }

        [JsonProperty("FRM_PSTALP")]
        public string FrmPstalp { get; set; }

        [JsonProperty("FRM_TRUST")]
        public string FrmTrust { get; set; }

        [JsonProperty("FRM_CLCODE")]
        public double FrmClcode { get; set; }

        [JsonProperty("FRM_PADDR")]
        public string FrmPaddr { get; set; }

        [JsonProperty("FRM_CHARTAGENT")]
        public string FrmChartagent { get; set; }

        [JsonProperty("FRM_CLASS")]
        public string FrmClass { get; set; }

        [JsonProperty("FRM_PZIP5")]
        public string FrmPzip5 { get; set; }

        [JsonProperty("FRM_PZIPREST")]
        public string FrmPziprest { get; set; }

        [JsonProperty("FRM_INSTNAME")]
        public string FrmInstname { get; set; }

        [JsonProperty("FRM_CNTYNAME")]
        public string FrmCntyname { get; set; }

        [JsonProperty("FRM_CERT")]
        public double FrmCert { get; set; }

        [JsonProperty("FRM_OFF_CNTYNAME")]
        public string FrmOffCntyname { get; set; }

        [JsonProperty("FRM_OFF_CNTYNUM")]
        public double FrmOffCntynum { get; set; }

        [JsonProperty("FRM_OFF_PADDR")]
        public string FrmOffPaddr { get; set; }

        [JsonProperty("FRM_OFF_PCITY")]
        public string FrmOffPcity { get; set; }

        [JsonProperty("FRM_OFF_PSTALP")]
        public string FrmOffPstalp { get; set; }

        [JsonProperty("FRM_OFF_PZIP5")]
        public string FrmOffPzip5 { get; set; }

        [JsonProperty("FRM_OFF_PZIPREST")]
        public string FrmOffPziprest { get; set; }

        [JsonProperty("FRM_OFF_SERVTYPE")]
        public double FrmOffServtype { get; set; }

        [JsonProperty("FRM_OFF_SERVTYPE_DESC")]
        public string FrmOffServtypeDesc { get; set; }

        [JsonProperty("FRM_OFF_STATE")]
        public string FrmOffState { get; set; }

        [JsonProperty("FRM_OFF_NAME")]
        public string FrmOffName { get; set; }

        [JsonProperty("FRM_OFF_NUM")]
        public string FrmOffNum { get; set; }

        [JsonProperty("FRM_OFF_TRUST")]
        public string FrmOffTrust { get; set; }

        [JsonProperty("FRM_OFF_CLCODE")]
        public double FrmOffClcode { get; set; }

        [JsonProperty("FRM_OFF_LATITUDE")]
        public double FrmOffLatitude { get; set; }

        [JsonProperty("FRM_OFF_LONGITUDE")]
        public double FrmOffLongitude { get; set; }

        [JsonProperty("FRM_LATITUDE")]
        public double FrmLatitude { get; set; }

        [JsonProperty("FRM_LONGITUDE")]
        public double FrmLongitude { get; set; }

        [JsonProperty("CERT")]
        public double Cert { get; set; }

        [JsonProperty("INSTNAME")]
        public string Instname { get; set; }

        [JsonProperty("CHARTAGENT")]
        public string Chartagent { get; set; }

        [JsonProperty("CLCODE")]
        public double Clcode { get; set; }

        [JsonProperty("FDICREGION")]
        public double Fdicregion { get; set; }

        [JsonProperty("FDICREGION_DESC")]
        public string FdicregionDesc { get; set; }

        [JsonProperty("CNTYNAME")]
        public string Cntyname { get; set; }

        [JsonProperty("CNTYNUM")]
        public double Cntynum { get; set; }

        [JsonProperty("INSAGENT1")]
        public string Insagent1 { get; set; }

        [JsonProperty("INSAGENT2")]
        public string Insagent2 { get; set; }

        [JsonProperty("MADDR")]
        public string Maddr { get; set; }

        [JsonProperty("MCITY")]
        public string Mcity { get; set; }

        [JsonProperty("MSTATE")]
        public string Mstate { get; set; }

        [JsonProperty("MSTALP")]
        public string Mstalp { get; set; }

        [JsonProperty("MZIP5")]
        public string Mzip5 { get; set; }

        [JsonProperty("MZIPREST")]
        public string Mziprest { get; set; }

        [JsonProperty("PADDR")]
        public string Paddr { get; set; }

        [JsonProperty("PZIP5")]
        public string Pzip5 { get; set; }

        [JsonProperty("PSTALP")]
        public string Pstalp { get; set; }

        [JsonProperty("PZIPREST")]
        public string Pziprest { get; set; }

        [JsonProperty("PCITY")]
        public string Pcity { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("TRUST")]
        public string Trust { get; set; }

        [JsonProperty("REGAGENT")]
        public string Regagent { get; set; }

        [JsonProperty("SERVTYPE")]
        public double Servtype { get; set; }

        [JsonProperty("SERVTYPE_DESC")]
        public string ServtypeDesc { get; set; }

        [JsonProperty("OFF_CNTYNAME")]
        public string OffCntyname { get; set; }

        [JsonProperty("OFF_NUM")]
        public double OffNum { get; set; }

        [JsonProperty("OFF_CNTYNUM")]
        public double OffCntynum { get; set; }

        [JsonProperty("OFF_PADDR")]
        public string OffPaddr { get; set; }

        [JsonProperty("OFF_PSTATE")]
        public string OffPstate { get; set; }

        [JsonProperty("OFF_PZIP5")]
        public string OffPzip5 { get; set; }

        [JsonProperty("OFF_PZIPREST")]
        public string OffPziprest { get; set; }

        [JsonProperty("OFF_NAME")]
        public string OffName { get; set; }

        [JsonProperty("OFF_PSTALP")]
        public string OffPstalp { get; set; }

        [JsonProperty("OFF_PCITY")]
        public string OffPcity { get; set; }

        [JsonProperty("OFF_SERVTYPE")]
        public double OffServtype { get; set; }

        [JsonProperty("OFF_LATITUDE")]
        public double OffLatitude { get; set; }

        [JsonProperty("OFF_LONGITUDE")]
        public double OffLongitude { get; set; }

        [JsonProperty("OFF_SERVTYPE_DESC")]
        public string OffServtypeDesc { get; set; }

        [JsonProperty("ESTDATE")]
        public string Estdate { get; set; }

        [JsonProperty("ACQDATE")]
        public string Acqdate { get; set; }

        [JsonProperty("FI_EFFDATE")]
        public string FiEffdate { get; set; }

        [JsonProperty("FI_UNINUM")]
        public int FiUninum { get; set; }

        [JsonProperty("ORG_STAT_FLG")]
        public string OrgStatFlg { get; set; }

        [JsonProperty("LATITUDE")]
        public double Latitude { get; set; }

        [JsonProperty("LONGITUDE")]
        public double Longitude { get; set; }
    }

    public class HistoryResponseTotalsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FinancialsResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Financial[] Data { get; set; }

        [JsonProperty("totals")]
        public FinancialsResponseTotalsType Totals { get; set; }
    }

    public class Financial
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class FinancialsResponseTotalsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class SummaryResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Summary[] Data { get; set; }
    }

    public class Summary
    {
        [JsonProperty("data")]
        public Data2 Data { get; set; }
    }

    public class Data2
    {
        [JsonProperty("ALLOTHER")]
        public int Allother { get; set; }

        [JsonProperty("alsonew")]
        public int Alsonew { get; set; }

        [JsonProperty("ASSET")]
        public int Asset { get; set; }

        [JsonProperty("BANKS")]
        public int Banks { get; set; }

        [JsonProperty("BKPREM")]
        public string Bkprem { get; set; }

        [JsonProperty("BRANCHES")]
        public int Branches { get; set; }

        [JsonProperty("BRANCHIN")]
        public int Branchin { get; set; }

        [JsonProperty("BRO")]
        public int Bro { get; set; }

        [JsonProperty("BRWDMONY")]
        public int Brwdmony { get; set; }

        [JsonProperty("CB_SI")]
        public Data2CbSiType CbSi { get; set; }

        [JsonProperty("chartoth")]
        public int Chartoth { get; set; }

        [JsonProperty("CHBAL")]
        public string Chbal { get; set; }

        [JsonProperty("CHBALI")]
        public string Chbali { get; set; }

        [JsonProperty("chrtrest")]
        public string Chrtrest { get; set; }

        [JsonProperty("comboass")]
        public string Comboass { get; set; }

        [JsonProperty("combos")]
        public string Combos { get; set; }

        [JsonProperty("CONS")]
        public int Cons { get; set; }

        [JsonProperty("CORPBNDS")]
        public int Corpbnds { get; set; }

        [JsonProperty("COUNT")]
        public int Count { get; set; }

        [JsonProperty("CRLNLS")]
        public string Crlnls { get; set; }

        [JsonProperty("DDT")]
        public string Ddt { get; set; }

        [JsonProperty("DEP")]
        public int Dep { get; set; }

        [JsonProperty("DEPDOM")]
        public int Depdom { get; set; }

        [JsonProperty("DEPFOR")]
        public string Depfor { get; set; }

        [JsonProperty("DEPI")]
        public string Depi { get; set; }

        [JsonProperty("DEPIFOR")]
        public string Depifor { get; set; }

        [JsonProperty("DEPNI")]
        public string Depni { get; set; }

        [JsonProperty("DEPNIFOR")]
        public string Depnifor { get; set; }

        [JsonProperty("DRLNLS")]
        public string Drlnls { get; set; }

        [JsonProperty("EAMINTAN")]
        public string Eamintan { get; set; }

        [JsonProperty("EDEP")]
        public string Edep { get; set; }

        [JsonProperty("EDEPDOM")]
        public string Edepdom { get; set; }

        [JsonProperty("EDEPFOR")]
        public string Edepfor { get; set; }

        [JsonProperty("EEREPP")]
        public int Eerepp { get; set; }

        [JsonProperty("EFHLBADV")]
        public int Efhlbadv { get; set; }

        [JsonProperty("EFREPP")]
        public string Efrepp { get; set; }

        [JsonProperty("EINTEXP")]
        public string Eintexp { get; set; }

        [JsonProperty("EINTEXP2")]
        public string Eintexp2 { get; set; }

        [JsonProperty("ELNATR")]
        public string Elnatr { get; set; }

        [JsonProperty("EOTHNINT")]
        public string Eothnint { get; set; }

        [JsonProperty("EPREMAGG")]
        public string Epremagg { get; set; }
        public int EQ { get; set; }

        [JsonProperty("EQCDIV")]
        public string Eqcdiv { get; set; }

        [JsonProperty("EQCDIVC")]
        public string Eqcdivc { get; set; }

        [JsonProperty("EQCDIVP")]
        public string Eqcdivp { get; set; }

        [JsonProperty("EQCS")]
        public string Eqcs { get; set; }

        [JsonProperty("EQDIV")]
        public int Eqdiv { get; set; }

        [JsonProperty("EQNM")]
        public int Eqnm { get; set; }

        [JsonProperty("EQNWCERT")]
        public int Eqnwcert { get; set; }

        [JsonProperty("EQOTHCC")]
        public string Eqothcc { get; set; }

        [JsonProperty("EQPP")]
        public string Eqpp { get; set; }

        [JsonProperty("EQSUR")]
        public string Eqsur { get; set; }

        [JsonProperty("EQUPTOT")]
        public string Equptot { get; set; }

        [JsonProperty("ESAL")]
        public string Esal { get; set; }

        [JsonProperty("ESUBND")]
        public string Esubnd { get; set; }

        [JsonProperty("EXTRA")]
        public string Extra { get; set; }

        [JsonProperty("FD_BIF")]
        public int FdBif { get; set; }

        [JsonProperty("FD_SAIF")]
        public int FdSaif { get; set; }

        [JsonProperty("FREPO")]
        public string Frepo { get; set; }

        [JsonProperty("FREPP")]
        public string Frepp { get; set; }

        [JsonProperty("ICHBAL")]
        public string Ichbal { get; set; }

        [JsonProperty("IFEE")]
        public int Ifee { get; set; }

        [JsonProperty("IFREPO")]
        public string Ifrepo { get; set; }

        [JsonProperty("IGLSEC")]
        public string Iglsec { get; set; }

        [JsonProperty("ILNDOM")]
        public string Ilndom { get; set; }

        [JsonProperty("ILNFOR")]
        public string Ilnfor { get; set; }

        [JsonProperty("ILNLS")]
        public string Ilnls { get; set; }

        [JsonProperty("ILNS")]
        public int Ilns { get; set; }

        [JsonProperty("ILS")]
        public string Ils { get; set; }

        [JsonProperty("INTAN")]
        public string Intan { get; set; }

        [JsonProperty("INTBAST")]
        public int Intbast { get; set; }

        [JsonProperty("INTBLIB")]
        public int Intblib { get; set; }

        [JsonProperty("INTINC")]
        public string Intinc { get; set; }

        [JsonProperty("INTINC2")]
        public string Intinc2 { get; set; }

        [JsonProperty("IRAKEOGH")]
        public int Irakeogh { get; set; }

        [JsonProperty("ISC")]
        public string Isc { get; set; }

        [JsonProperty("ISERCHG")]
        public string Iserchg { get; set; }

        [JsonProperty("ITAX")]
        public string Itax { get; set; }

        [JsonProperty("ITAXR")]
        public int Itaxr { get; set; }

        [JsonProperty("ITRADE")]
        public int Itrade { get; set; }

        [JsonProperty("LIAB")]
        public string Liab { get; set; }

        [JsonProperty("LIABEQ")]
        public int Liabeq { get; set; }

        [JsonProperty("LIQASSTD")]
        public int Liqasstd { get; set; }

        [JsonProperty("LIQUNASS")]
        public int Liqunass { get; set; }

        [JsonProperty("LNAG")]
        public int Lnag { get; set; }

        [JsonProperty("LNALLOTH")]
        public int Lnalloth { get; set; }

        [JsonProperty("LNATRES")]
        public int Lnatres { get; set; }

        [JsonProperty("LNAUTO")]
        public int Lnauto { get; set; }

        [JsonProperty("LNCI")]
        public int Lnci { get; set; }

        [JsonProperty("LNCON")]
        public int Lncon { get; set; }

        [JsonProperty("LNCONOT1")]
        public int Lnconot1 { get; set; }

        [JsonProperty("LNCONOTH")]
        public int Lnconoth { get; set; }

        [JsonProperty("LNCRCD")]
        public int Lncrcd { get; set; }

        [JsonProperty("LNDEP")]
        public int Lndep { get; set; }

        [JsonProperty("LNLS")]
        public int Lnls { get; set; }

        [JsonProperty("LNLSGR")]
        public int Lnlsgr { get; set; }

        [JsonProperty("LNLSNET")]
        public int Lnlsnet { get; set; }

        [JsonProperty("LNMOBILE")]
        public int Lnmobile { get; set; }

        [JsonProperty("LNMUNI")]
        public int Lnmuni { get; set; }

        [JsonProperty("LNRE")]
        public int Lnre { get; set; }

        [JsonProperty("LNREAG")]
        public int Lnreag { get; set; }

        [JsonProperty("LNRECONS")]
        public int Lnrecons { get; set; }

        [JsonProperty("LNREDOM")]
        public int Lnredom { get; set; }

        [JsonProperty("LNREFOR")]
        public int Lnrefor { get; set; }

        [JsonProperty("LNRELOC")]
        public int Lnreloc { get; set; }

        [JsonProperty("LNREMULT")]
        public int Lnremult { get; set; }

        [JsonProperty("LNRENRES")]
        public int Lnrenres { get; set; }

        [JsonProperty("LNRERES")]
        public int Lnreres { get; set; }

        [JsonProperty("LNRESRE")]
        public int Lnresre { get; set; }

        [JsonProperty("LNSP")]
        public int Lnsp { get; set; }
        public int LS { get; set; }

        [JsonProperty("MERGERS")]
        public int Mergers { get; set; }

        [JsonProperty("MISSADJ")]
        public int Missadj { get; set; }

        [JsonProperty("MTGLS")]
        public int Mtgls { get; set; }

        [JsonProperty("NALNLS")]
        public int Nalnls { get; set; }

        [JsonProperty("NCHGREC")]
        public int Nchgrec { get; set; }

        [JsonProperty("NCLNLS")]
        public int Nclnls { get; set; }

        [JsonProperty("NETIMIN")]
        public int Netimin { get; set; }

        [JsonProperty("NETINC")]
        public int Netinc { get; set; }

        [JsonProperty("newcount")]
        public int Newcount { get; set; }

        [JsonProperty("New_Char")]
        public int NewChar { get; set; }

        [JsonProperty("NEW6_1")]
        public int New61 { get; set; }

        [JsonProperty("NEW9_1")]
        public int New91 { get; set; }

        [JsonProperty("NEW10_1")]
        public int New101 { get; set; }

        [JsonProperty("NEW10_2")]
        public int New102 { get; set; }

        [JsonProperty("NEW10_3")]
        public int New103 { get; set; }

        [JsonProperty("NEW11_1")]
        public int New111 { get; set; }

        [JsonProperty("NEW14_1")]
        public int New141 { get; set; }

        [JsonProperty("NEW14_2")]
        public int New142 { get; set; }

        [JsonProperty("NEW14_3")]
        public int New143 { get; set; }

        [JsonProperty("NEW14_4")]
        public int New144 { get; set; }

        [JsonProperty("NEW15_1")]
        public int New151 { get; set; }

        [JsonProperty("NEW15_2")]
        public int New152 { get; set; }

        [JsonProperty("NEW15_3")]
        public int New153 { get; set; }

        [JsonProperty("NEW15_4")]
        public int New154 { get; set; }

        [JsonProperty("NEW15_5")]
        public int New155 { get; set; }

        [JsonProperty("NEW15_7")]
        public int New157 { get; set; }

        [JsonProperty("NEW16_1")]
        public int New161 { get; set; }

        [JsonProperty("NEW16_2")]
        public int New162 { get; set; }

        [JsonProperty("NIM")]
        public int Nim { get; set; }

        [JsonProperty("NONII")]
        public int Nonii { get; set; }

        [JsonProperty("NONIX")]
        public int Nonix { get; set; }

        [JsonProperty("NTLNLS")]
        public int Ntlnls { get; set; }

        [JsonProperty("NTR")]
        public int Ntr { get; set; }

        [JsonProperty("NTRTIME")]
        public int Ntrtime { get; set; }

        [JsonProperty("NTRTMLG")]
        public int Ntrtmlg { get; set; }

        [JsonProperty("NUMEMP")]
        public int Numemp { get; set; }

        [JsonProperty("OEA")]
        public int Oea { get; set; }

        [JsonProperty("OFFICES")]
        public int Offices { get; set; }

        [JsonProperty("OINTBOR")]
        public int Ointbor { get; set; }

        [JsonProperty("OINTEXP")]
        public int Ointexp { get; set; }

        [JsonProperty("OINTINC")]
        public int Ointinc { get; set; }

        [JsonProperty("OONONII")]
        public int Oononii { get; set; }

        [JsonProperty("ORE")]
        public int Ore { get; set; }

        [JsonProperty("ORET")]
        public int Oret { get; set; }

        [JsonProperty("OT_BIF")]
        public int OtBif { get; set; }

        [JsonProperty("OT_SAIF")]
        public int OtSaif { get; set; }

        [JsonProperty("OTHASST")]
        public int Othasst { get; set; }

        [JsonProperty("OTHBFHLB")]
        public int Othbfhlb { get; set; }

        [JsonProperty("OTHBORR")]
        public int Othborr { get; set; }

        [JsonProperty("OTHEQ")]
        public int Otheq { get; set; }

        [JsonProperty("OTHER")]
        public int Other { get; set; }

        [JsonProperty("OTHLIAB")]
        public int Othliab { get; set; }

        [JsonProperty("OTHNBORR")]
        public int Othnborr { get; set; }

        [JsonProperty("OTLNCNTA")]
        public int Otlncnta { get; set; }

        [JsonProperty("PAID_OFF")]
        public int PaidOff { get; set; }

        [JsonProperty("P3LNLS")]
        public int P3Lnls { get; set; }

        [JsonProperty("P9LNLS")]
        public int P9Lnls { get; set; }

        [JsonProperty("PTXNOINC")]
        public int Ptxnoinc { get; set; }

        [JsonProperty("REL_CO")]
        public int RelCo { get; set; }

        [JsonProperty("SAVINGS")]
        public int Savings { get; set; }
        public int SC { get; set; }

        [JsonProperty("SCAGE")]
        public int Scage { get; set; }

        [JsonProperty("SCEQ")]
        public int Sceq { get; set; }

        [JsonProperty("SCMTGBK")]
        public int Scmtgbk { get; set; }

        [JsonProperty("SCMUNI")]
        public int Scmuni { get; set; }

        [JsonProperty("SCMV")]
        public int Scmv { get; set; }

        [JsonProperty("SCRES")]
        public int Scres { get; set; }

        [JsonProperty("SCUS")]
        public int Scus { get; set; }

        [JsonProperty("SCUSA")]
        public int Scusa { get; set; }

        [JsonProperty("SCUST")]
        public int Scust { get; set; }

        [JsonProperty("STNAME")]
        public string Stname { get; set; }

        [JsonProperty("STNUM")]
        public string Stnum { get; set; }

        [JsonProperty("SUBLLPF")]
        public int Subllpf { get; set; }

        [JsonProperty("SUBND")]
        public int Subnd { get; set; }

        [JsonProperty("TINTINC")]
        public int Tintinc { get; set; }

        [JsonProperty("tochrt")]
        public int Tochrt { get; set; }

        [JsonProperty("tofail")]
        public int Tofail { get; set; }

        [JsonProperty("TOINTEXP")]
        public int Tointexp { get; set; }

        [JsonProperty("tomerg")]
        public string Tomerg { get; set; }

        [JsonProperty("tortc")]
        public string Tortc { get; set; }

        [JsonProperty("TOTAL")]
        public int Total { get; set; }

        [JsonProperty("TOT_FDIC")]
        public int TotFdic { get; set; }

        [JsonProperty("TOT_OTS")]
        public int TotOts { get; set; }

        [JsonProperty("TOT_SAVE")]
        public int TotSave { get; set; }

        [JsonProperty("TPD")]
        public int Tpd { get; set; }

        [JsonProperty("TRADE")]
        public int Trade { get; set; }

        [JsonProperty("TRADES")]
        public string Trades { get; set; }

        [JsonProperty("TRN")]
        public string Trn { get; set; }

        [JsonProperty("UNASSIST")]
        public int Unassist { get; set; }

        [JsonProperty("UNINC")]
        public string Uninc { get; set; }

        [JsonProperty("UNIT")]
        public int Unit { get; set; }

        [JsonProperty("YEAR")]
        public string Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data2CbSiType
    {
        CB,
        SI
    }

    public class FailuresResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Failure[] Data { get; set; }

        [JsonProperty("totals")]
        public FailuresResponseTotalsType Totals { get; set; }
    }

    public class Failure
    {
        [JsonProperty("data")]
        public Data3 Data { get; set; }
    }

    public class Data3
    {
        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("CERT")]
        public double Cert { get; set; }

        [JsonProperty("FIN")]
        public string Fin { get; set; }

        [JsonProperty("CITYST")]
        public string Cityst { get; set; }

        [JsonProperty("FAILDATE")]
        public string Faildate { get; set; }

        [JsonProperty("FAILYR")]
        public string Failyr { get; set; }

        [JsonProperty("SAVR")]
        public Data3SavrType Savr { get; set; }

        [JsonProperty("RESTYPE1")]
        public Data3Restype1Type Restype1 { get; set; }

        [JsonProperty("CHCLASS1")]
        public Data3Chclass1Type Chclass1 { get; set; }

        [JsonProperty("RESDATE")]
        public string Resdate { get; set; }

        [JsonProperty("RESTYPE")]
        public Data3RestypeType Restype { get; set; }

        [JsonProperty("QBFDEP")]
        public double Qbfdep { get; set; }

        [JsonProperty("QBFASSET")]
        public int Qbfasset { get; set; }

        [JsonProperty("COST")]
        public string Cost { get; set; }

        [JsonProperty("PSTALP")]
        public string Pstalp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3SavrType
    {
        [EnumMember(Value = "BIF")]
        Bif,
        [EnumMember(Value = "RTC")]
        Rtc,
        [EnumMember(Value = "FSLIC")]
        Fslic,
        [EnumMember(Value = "SAIF")]
        Saif,
        [EnumMember(Value = "DIF")]
        Dif,
        [EnumMember(Value = "FDIC")]
        Fdic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3Restype1Type
    {
        [EnumMember(Value = "A/A")]
        AA,
        [EnumMember(Value = "REP")]
        Rep,
        [EnumMember(Value = "P&A")]
        PA,
        [EnumMember(Value = "PA")]
        PA2,
        PI,
        [EnumMember(Value = "IDT")]
        Idt,
        [EnumMember(Value = "MGR")]
        Mgr,
        PO
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3Chclass1Type
    {
        N,
        SM,
        NM,
        SA,
        SB
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3RestypeType
    {
        Failure,
        Assistance
    }

    public class FailuresResponseTotalsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class SodResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Sod[] Data { get; set; }

        [JsonProperty("totals")]
        public SodResponseTotalsType Totals { get; set; }
    }

    public class Sod
    {
        [JsonProperty("data")]
        public Data6 Data { get; set; }
    }

    public class Data6
    {
        [JsonProperty("ADDRESBR")]
        public string Addresbr { get; set; }

        [JsonProperty("ADDRESS")]
        public string Address { get; set; }

        [JsonProperty("ASSET")]
        public double Asset { get; set; }

        [JsonProperty("BKCLASS")]
        public string Bkclass { get; set; }

        [JsonProperty("BKMO")]
        public double Bkmo { get; set; }

        [JsonProperty("BRCENM")]
        public string Brcenm { get; set; }

        [JsonProperty("BRNUM")]
        public double Brnum { get; set; }

        [JsonProperty("BRSERTYP")]
        public double Brsertyp { get; set; }

        [JsonProperty("CALL")]
        public string Call { get; set; }
        public string CB { get; set; }

        [JsonProperty("CBSA_DIV_NAMB")]
        public string CbsaDivNamb { get; set; }

        [JsonProperty("CERT")]
        public double Cert { get; set; }

        [JsonProperty("CHARTER")]
        public string Charter { get; set; }

        [JsonProperty("CHRTAGNN")]
        public string Chrtagnn { get; set; }

        [JsonProperty("CHRTAGNT")]
        public string Chrtagnt { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("CITY2BR")]
        public string City2BR { get; set; }

        [JsonProperty("CITYBR")]
        public string Citybr { get; set; }

        [JsonProperty("CITYHCR")]
        public string Cityhcr { get; set; }

        [JsonProperty("CLCODE")]
        public double Clcode { get; set; }

        [JsonProperty("CNTRYNA")]
        public string Cntryna { get; set; }

        [JsonProperty("CNTRYNAB")]
        public string Cntrynab { get; set; }

        [JsonProperty("CNTYNAMB")]
        public string Cntynamb { get; set; }

        [JsonProperty("CNTYNUMB")]
        public double Cntynumb { get; set; }

        [JsonProperty("CONSOLD")]
        public int Consold { get; set; }

        [JsonProperty("CSABR")]
        public double Csabr { get; set; }

        [JsonProperty("CSANAMBR")]
        public string Csanambr { get; set; }

        [JsonProperty("DENOVO")]
        public double Denovo { get; set; }

        [JsonProperty("DEPDOM")]
        public double Depdom { get; set; }

        [JsonProperty("DEPSUM")]
        public double Depsum { get; set; }

        [JsonProperty("DEPSUMBR")]
        public double Depsumbr { get; set; }

        [JsonProperty("DIVISIONB")]
        public double Divisionb { get; set; }

        [JsonProperty("DOCKET")]
        public double Docket { get; set; }

        [JsonProperty("ESCROW")]
        public string Escrow { get; set; }

        [JsonProperty("FDICDBS")]
        public double Fdicdbs { get; set; }

        [JsonProperty("FDICNAME")]
        public string Fdicname { get; set; }

        [JsonProperty("FED")]
        public double Fed { get; set; }

        [JsonProperty("FEDNAME")]
        public string Fedname { get; set; }

        [JsonProperty("HCTMULT")]
        public string Hctmult { get; set; }

        [JsonProperty("INSAGNT1")]
        public string Insagnt1 { get; set; }

        [JsonProperty("INSBRDD")]
        public double Insbrdd { get; set; }

        [JsonProperty("INSBRTS")]
        public double Insbrts { get; set; }

        [JsonProperty("INSURED")]
        public string Insured { get; set; }

        [JsonProperty("METROBR")]
        public double Metrobr { get; set; }

        [JsonProperty("MICROBR")]
        public double Microbr { get; set; }

        [JsonProperty("MSABR")]
        public double Msabr { get; set; }

        [JsonProperty("MSANAMB")]
        public string Msanamb { get; set; }

        [JsonProperty("NAMEBR")]
        public string Namebr { get; set; }

        [JsonProperty("NAMEFULL")]
        public string Namefull { get; set; }

        [JsonProperty("NAMEHCR")]
        public string Namehcr { get; set; }

        [JsonProperty("NECNAMB")]
        public string Necnamb { get; set; }

        [JsonProperty("NECTABR")]
        public string Nectabr { get; set; }

        [JsonProperty("OCCDIST")]
        public double Occdist { get; set; }

        [JsonProperty("OCCNAME")]
        public string Occname { get; set; }

        [JsonProperty("PLACENUM")]
        public double Placenum { get; set; }

        [JsonProperty("REGAGNT")]
        public string Regagnt { get; set; }

        [JsonProperty("RSSDHCR")]
        public double Rssdhcr { get; set; }

        [JsonProperty("RSSDID")]
        public double Rssdid { get; set; }

        [JsonProperty("SIMS_ACQUIRED_DATE")]
        public string SimsAcquiredDate { get; set; }

        [JsonProperty("SIMS_DESCRIPTION")]
        public string SimsDescription { get; set; }

        [JsonProperty("SIMS_ESTABLISHED_DATE")]
        public string SimsEstablishedDate { get; set; }

        [JsonProperty("SIMS_LATITUDE")]
        public double SimsLatitude { get; set; }

        [JsonProperty("SIMS_LONGITUDE")]
        public double SimsLongitude { get; set; }

        [JsonProperty("SIMS_PROJECTION")]
        public string SimsProjection { get; set; }

        [JsonProperty("SPECDESC")]
        public string Specdesc { get; set; }

        [JsonProperty("SPECGRP")]
        public double Specgrp { get; set; }

        [JsonProperty("STALP")]
        public string Stalp { get; set; }

        [JsonProperty("STALPBR")]
        public string Stalpbr { get; set; }

        [JsonProperty("STALPHCR")]
        public string Stalphcr { get; set; }

        [JsonProperty("STCNTY")]
        public double Stcnty { get; set; }

        [JsonProperty("STCNTYBR")]
        public double Stcntybr { get; set; }

        [JsonProperty("STNAME")]
        public string Stname { get; set; }

        [JsonProperty("STNAMEBR")]
        public string Stnamebr { get; set; }

        [JsonProperty("STNUMBR")]
        public double Stnumbr { get; set; }

        [JsonProperty("UNINUMBR")]
        public double Uninumbr { get; set; }

        [JsonProperty("UNIT")]
        public double Unit { get; set; }

        [JsonProperty("USA")]
        public double Usa { get; set; }

        [JsonProperty("YEAR")]
        public double Year { get; set; }

        [JsonProperty("ZIP_RAW")]
        public string ZipRaw { get; set; }

        [JsonProperty("ZIPBR_RAW")]
        public string ZipbrRaw { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }

        [JsonProperty("ZIPBR")]
        public string Zipbr { get; set; }
    }

    public class SodResponseTotalsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class DemographicsResponse
    {
        [JsonProperty("meta")]
        public Metadata Meta { get; set; }

        [JsonProperty("data")]
        public Demographics[] Data { get; set; }

        [JsonProperty("totals")]
        public DemographicsResponseTotalsType Totals { get; set; }
    }

    public class Demographics
    {
        [JsonProperty("data")]
        public Data7 Data { get; set; }
    }

    public class Data7
    {
        [JsonProperty("ACTEVT")]
        public string Actevt { get; set; }

        [JsonProperty("BRANCH")]
        public double Branch { get; set; }

        [JsonProperty("CALLYM")]
        public string Callym { get; set; }

        [JsonProperty("CALLYMD")]
        public string Callymd { get; set; }

        [JsonProperty("CBSANAME")]
        public string Cbsaname { get; set; }

        [JsonProperty("CERT")]
        public double Cert { get; set; }

        [JsonProperty("CLCODE")]
        public double Clcode { get; set; }

        [JsonProperty("CNTRYALP")]
        public string Cntryalp { get; set; }

        [JsonProperty("CNTRYNUM")]
        public string Cntrynum { get; set; }

        [JsonProperty("CNTYNUM")]
        public string Cntynum { get; set; }

        [JsonProperty("CSA")]
        public string Csa { get; set; }

        [JsonProperty("DIVISION")]
        public double Division { get; set; }

        [JsonProperty("DOCKET")]
        public double Docket { get; set; }

        [JsonProperty("FDICAREA")]
        public double Fdicarea { get; set; }

        [JsonProperty("FDICTERR")]
        public string Fdicterr { get; set; }

        [JsonProperty("FLDOFDCA")]
        public string Fldofdca { get; set; }

        [JsonProperty("HCTNONE")]
        public string Hctnone { get; set; }

        [JsonProperty("INSAGNT2")]
        public string Insagnt2 { get; set; }

        [JsonProperty("METRO")]
        public double Metro { get; set; }

        [JsonProperty("MICRO")]
        public double Micro { get; set; }

        [JsonProperty("MNRTYCDE")]
        public string Mnrtycde { get; set; }

        [JsonProperty("MNRTYDTE")]
        public string Mnrtydte { get; set; }

        [JsonProperty("OAKAR")]
        public double Oakar { get; set; }

        [JsonProperty("OFFDMULT")]
        public double Offdmult { get; set; }

        [JsonProperty("OFFNDOM")]
        public double Offndom { get; set; }

        [JsonProperty("OFFOTH")]
        public double Offoth { get; set; }

        [JsonProperty("OFFSOD")]
        public double Offsod { get; set; }

        [JsonProperty("OFFSTATE")]
        public double Offstate { get; set; }

        [JsonProperty("OFFTOT")]
        public double Offtot { get; set; }

        [JsonProperty("OFFUSOA")]
        public double Offusoa { get; set; }

        [JsonProperty("QTRNO")]
        public double Qtrno { get; set; }

        [JsonProperty("REPDTE")]
        public string Repdte { get; set; }

        [JsonProperty("REPDTE_INT")]
        public string RepdteInt { get; set; }

        [JsonProperty("RISKTERR")]
        public string Riskterr { get; set; }

        [JsonProperty("SASSER")]
        public int Sasser { get; set; }

        [JsonProperty("SIMS_LAT")]
        public double SimsLat { get; set; }

        [JsonProperty("SIMS_LONG")]
        public double SimsLong { get; set; }

        [JsonProperty("WEBADDR")]
        public string Webaddr { get; set; }
        public string TE01N528 { get; set; }
        public string TE02N528 { get; set; }
        public string TE03N528 { get; set; }
        public string TE04N528 { get; set; }
        public string TE05N528 { get; set; }
        public string TE06N528 { get; set; }
        public string TE07N528 { get; set; }
        public string TE08N528 { get; set; }
        public string TE09N528 { get; set; }
        public string TE10N528 { get; set; }
        public string TE01N529 { get; set; }
        public string TE02N529 { get; set; }
        public string TE03N529 { get; set; }
        public string TE04N529 { get; set; }
        public string TE05N529 { get; set; }
        public string TE06N529 { get; set; }
    }

    public class DemographicsResponseTotalsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fdic;

    public partial class WorkflowManagedActions
    {
        public FdicActions Fdic(string connectionId) => new FdicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FdicTriggers Fdic(string connectionId) => new FdicTriggers(connectionId);
    }
}