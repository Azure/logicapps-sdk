//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fdic
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FdicActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildSearchInstitutions))]
        public IBodyWorkflowAction<InstitutionsResponse> SearchInstitutions([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InstitutionsResponse> __BuildSearchInstitutions(WorkflowExpression<string> filters = null, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<InstitutionsResponse>(() =>
            {
                var apiCallPath = "/institutions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("NAME");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<InstitutionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLocations))]
        public IBodyWorkflowAction<LocationsResponse> SearchLocations([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LocationsResponse> __BuildSearchLocations(WorkflowExpression<string> filters = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<LocationsResponse>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("NAME");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<LocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildGetHistory))]
        public IBodyWorkflowAction<HistoryResponse> GetHistory([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> aggBy = null, [WorkflowExpression] Func<string> aggTermFields = null, [WorkflowExpression] Func<int> aggLimit = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HistoryResponse> __BuildGetHistory(WorkflowExpression<string> filters = null, WorkflowExpression<string> search = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> aggBy = null, WorkflowExpression<string> aggTermFields = null, WorkflowExpression<int> aggLimit = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(aggBy, nameof(aggBy), required: false);
            WorkflowExpression.Validate(aggTermFields, nameof(aggTermFields), required: false);
            WorkflowExpression.Validate(aggLimit, nameof(aggLimit), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<HistoryResponse>(() =>
            {
                var apiCallPath = "/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("PROCDATE");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(aggBy);
                if (aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(aggTermFields);
                callPayload.Queries["agg_limit"] = Convert.ToString(10);
                if (aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(aggLimit);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<HistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildGetFinancials))]
        public IBodyWorkflowAction<FinancialsResponse> GetFinancials([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> aggBy = null, [WorkflowExpression] Func<string> aggTermFields = null, [WorkflowExpression] Func<string> aggSumFields = null, [WorkflowExpression] Func<int> aggLimit = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FinancialsResponse> __BuildGetFinancials(WorkflowExpression<string> filters = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> aggBy = null, WorkflowExpression<string> aggTermFields = null, WorkflowExpression<string> aggSumFields = null, WorkflowExpression<int> aggLimit = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(aggBy, nameof(aggBy), required: false);
            WorkflowExpression.Validate(aggTermFields, nameof(aggTermFields), required: false);
            WorkflowExpression.Validate(aggSumFields, nameof(aggSumFields), required: false);
            WorkflowExpression.Validate(aggLimit, nameof(aggLimit), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<FinancialsResponse>(() =>
            {
                var apiCallPath = "/financials";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("REPDTE");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(aggBy);
                if (aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(aggTermFields);
                if (aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(aggSumFields);
                if (aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(aggLimit);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<FinancialsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildGetHistorical))]
        public IBodyWorkflowAction<SummaryResponse> GetHistorical([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> aggBy = null, [WorkflowExpression] Func<string> aggTermFields = null, [WorkflowExpression] Func<string> aggSumFields = null, [WorkflowExpression] Func<int> aggLimit = null, [WorkflowExpression] Func<string> maxValue = null, [WorkflowExpression] Func<string> maxValueBy = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SummaryResponse> __BuildGetHistorical(WorkflowExpression<string> filters = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> aggBy = null, WorkflowExpression<string> aggTermFields = null, WorkflowExpression<string> aggSumFields = null, WorkflowExpression<int> aggLimit = null, WorkflowExpression<string> maxValue = null, WorkflowExpression<string> maxValueBy = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(aggBy, nameof(aggBy), required: false);
            WorkflowExpression.Validate(aggTermFields, nameof(aggTermFields), required: false);
            WorkflowExpression.Validate(aggSumFields, nameof(aggSumFields), required: false);
            WorkflowExpression.Validate(aggLimit, nameof(aggLimit), required: false);
            WorkflowExpression.Validate(maxValue, nameof(maxValue), required: false);
            WorkflowExpression.Validate(maxValueBy, nameof(maxValueBy), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<SummaryResponse>(() =>
            {
                var apiCallPath = "/summary";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("YEAR");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(aggBy);
                if (aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(aggTermFields);
                if (aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(aggSumFields);
                if (aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(aggLimit);
                if (maxValue != null)
                    callPayload.Queries["max_value"] = ExpressionConverter.Convert(maxValue);
                if (maxValueBy != null)
                    callPayload.Queries["max_value_by"] = ExpressionConverter.Convert(maxValueBy);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<SummaryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildGetFailures))]
        public IBodyWorkflowAction<FailuresResponse> GetFailures([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> totalFields = null, [WorkflowExpression] Func<string> subtotalBy = null, [WorkflowExpression] Func<string> aggBy = null, [WorkflowExpression] Func<string> aggTermFields = null, [WorkflowExpression] Func<string> aggSumFields = null, [WorkflowExpression] Func<int> aggLimit = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FailuresResponse> __BuildGetFailures(WorkflowExpression<string> filters = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> totalFields = null, WorkflowExpression<string> subtotalBy = null, WorkflowExpression<string> aggBy = null, WorkflowExpression<string> aggTermFields = null, WorkflowExpression<string> aggSumFields = null, WorkflowExpression<int> aggLimit = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(totalFields, nameof(totalFields), required: false);
            WorkflowExpression.Validate(subtotalBy, nameof(subtotalBy), required: false);
            WorkflowExpression.Validate(aggBy, nameof(aggBy), required: false);
            WorkflowExpression.Validate(aggTermFields, nameof(aggTermFields), required: false);
            WorkflowExpression.Validate(aggSumFields, nameof(aggSumFields), required: false);
            WorkflowExpression.Validate(aggLimit, nameof(aggLimit), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<FailuresResponse>(() =>
            {
                var apiCallPath = "/failures";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("FAILDATE");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(100);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (totalFields != null)
                    callPayload.Queries["total_fields"] = ExpressionConverter.Convert(totalFields);
                if (subtotalBy != null)
                    callPayload.Queries["subtotal_by"] = ExpressionConverter.Convert(subtotalBy);
                if (aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(aggBy);
                if (aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(aggTermFields);
                if (aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(aggSumFields);
                callPayload.Queries["agg_limit"] = Convert.ToString(10);
                if (aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(aggLimit);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<FailuresResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildGetSod))]
        public IBodyWorkflowAction<SodResponse> GetSod([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortOrder = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> aggBy = null, [WorkflowExpression] Func<string> aggTermFields = null, [WorkflowExpression] Func<string> aggSumFields = null, [WorkflowExpression] Func<int> aggLimit = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SodResponse> __BuildGetSod(WorkflowExpression<string> filters = null, WorkflowExpression<string> fields = null, WorkflowExpression<string> sortBy = null, WorkflowExpression<string> sortOrder = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> aggBy = null, WorkflowExpression<string> aggTermFields = null, WorkflowExpression<string> aggSumFields = null, WorkflowExpression<int> aggLimit = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            WorkflowExpression.Validate(sortBy, nameof(sortBy), required: false);
            WorkflowExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(aggBy, nameof(aggBy), required: false);
            WorkflowExpression.Validate(aggTermFields, nameof(aggTermFields), required: false);
            WorkflowExpression.Validate(aggSumFields, nameof(aggSumFields), required: false);
            WorkflowExpression.Validate(aggLimit, nameof(aggLimit), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<SodResponse>(() =>
            {
                var apiCallPath = "/sod";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                callPayload.Queries["sort_by"] = Convert.ToString("YEAR");
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(sortBy);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(sortOrder);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (aggBy != null)
                    callPayload.Queries["agg_by"] = ExpressionConverter.Convert(aggBy);
                if (aggTermFields != null)
                    callPayload.Queries["agg_term_fields"] = ExpressionConverter.Convert(aggTermFields);
                if (aggSumFields != null)
                    callPayload.Queries["agg_sum_fields"] = ExpressionConverter.Convert(aggSumFields);
                if (aggLimit != null)
                    callPayload.Queries["agg_limit"] = ExpressionConverter.Convert(aggLimit);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                return new ApiConnectionAction<SodResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fdic")]
        [WorkflowExpressionFactory(nameof(__BuildGetDemographics))]
        public IBodyWorkflowAction<DemographicsResponse> GetDemographics([WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DemographicsResponse> __BuildGetDemographics(WorkflowExpression<string> filters = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(filters, nameof(filters), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<DemographicsResponse>(() =>
            {
                var apiCallPath = "/demographics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (download != null)
                    callPayload.Queries["download"] = ExpressionConverter.Convert(download);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
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
        public int ACTIVE { get; set; }
        public string ADDRESS { get; set; }
        public double ASSET { get; set; }
        public DataBKCLASSType BKCLASS { get; set; }
        public string CB { get; set; }
        public string CBSA { get; set; }

        [JsonProperty("CBSA_DIV")]
        public string CBSADIV { get; set; }

        [JsonProperty("CBSA_DIV_FLG")]
        public string CBSADIVFLG { get; set; }

        [JsonProperty("CBSA_DIV_NO")]
        public string CBSADIVNO { get; set; }

        [JsonProperty("CBSA_METRO")]
        public string CBSAMETRO { get; set; }

        [JsonProperty("CBSA_METRO_FLG")]
        public string CBSAMETROFLG { get; set; }

        [JsonProperty("CBSA_METRO_NAME")]
        public string CBSAMETRONAME { get; set; }

        [JsonProperty("CBSA_MICRO_FLG")]
        public string CBSAMICROFLG { get; set; }

        [JsonProperty("CBSA_NO")]
        public string CBSANO { get; set; }
        public double CERT { get; set; }
        public string CERTCONS { get; set; }
        public string CFPBEFFDTE { get; set; }
        public string CFPBENDDTE { get; set; }
        public int CFPBFLAG { get; set; }
        public string PRIORNAME1 { get; set; }
        public JToken PRIORNAME2 { get; set; }
        public JToken PRIORNAME3 { get; set; }
        public JToken PRIORNAME4 { get; set; }
        public JToken PRIORNAME5 { get; set; }
        public JToken PRIORNAME6 { get; set; }
        public JToken PRIORNAME7 { get; set; }
        public JToken PRIORNAME8 { get; set; }
        public JToken PRIORNAME9 { get; set; }
        public JToken PRIORNAME10 { get; set; }
        public int CHANGEC1 { get; set; }
        public string CHANGEC2 { get; set; }
        public string CHANGEC3 { get; set; }
        public string CHANGEC4 { get; set; }
        public string CHANGEC5 { get; set; }
        public string CHANGEC6 { get; set; }
        public string CHANGEC7 { get; set; }
        public string CHANGEC8 { get; set; }
        public string CHANGEC9 { get; set; }
        public string CHANGEC10 { get; set; }
        public string CHANGEC11 { get; set; }
        public string CHANGEC12 { get; set; }
        public string CHANGEC13 { get; set; }
        public string CHANGEC14 { get; set; }
        public int CHANGEC15 { get; set; }
        public string CHARTER { get; set; }
        public string CHRTAGNT { get; set; }
        public string CITY { get; set; }
        public string CITYHCR { get; set; }
        public string CLCODE { get; set; }
        public string CONSERVE { get; set; }
        public string COUNTY { get; set; }
        public string CSA { get; set; }

        [JsonProperty("CSA_NO")]
        public string CSANO { get; set; }

        [JsonProperty("CSA_FLG")]
        public string CSAFLG { get; set; }
        public string DATEUPDT { get; set; }
        public string DENOVO { get; set; }
        public double DEP { get; set; }
        public double DEPDOM { get; set; }
        public string DOCKET { get; set; }
        public string EFFDATE { get; set; }
        public string ENDEFYMD { get; set; }
        public string EQ { get; set; }
        public string ESTYMD { get; set; }
        public double FDICDBS { get; set; }
        public string FDICREGN { get; set; }
        public string FDICSUPV { get; set; }
        public string FED { get; set; }

        [JsonProperty("FED_RSSD")]
        public string FEDRSSD { get; set; }
        public int FEDCHRTR { get; set; }
        public string FORM31 { get; set; }
        public string HCTMULT { get; set; }
        public int IBA { get; set; }
        public int INACTIVE { get; set; }
        public string INSAGNT1 { get; set; }
        public string INSAGNT2 { get; set; }
        public int INSBIF { get; set; }
        public int INSCOML { get; set; }
        public string INSDATE { get; set; }

        [JsonProperty("INSDROPDATE_RAW")]
        public string INSDROPDATERAW { get; set; }
        public string INSDROPDATE { get; set; }
        public int INSDIF { get; set; }
        public double INSFDIC { get; set; }
        public int INSSAIF { get; set; }
        public int INSSAVE { get; set; }
        public string INSTAG { get; set; }
        public int INSTCRCD { get; set; }
        public double LATITUDE { get; set; }

        [JsonProperty("LAW_SASSER_FLG")]
        public string LAWSASSERFLG { get; set; }
        public double LONGITUDE { get; set; }

        [JsonProperty("MDI_STATUS_CODE")]
        public string MDISTATUSCODE { get; set; }

        [JsonProperty("MDI_STATUS_DESC")]
        public string MDISTATUSDESC { get; set; }
        public string MUTUAL { get; set; }
        public string NAME { get; set; }
        public string NAMEHCR { get; set; }
        public double NETINC { get; set; }
        public double NETINCQ { get; set; }
        public int NEWCERT { get; set; }
        public int OAKAR { get; set; }
        public string OCCDIST { get; set; }
        public double OFFDOM { get; set; }
        public double OFFFOR { get; set; }
        public double OFFICES { get; set; }
        public double OFFOA { get; set; }
        public string PARCERT { get; set; }
        public string PROCDATE { get; set; }
        public string QBPRCOML { get; set; }
        public string REGAGNT { get; set; }
        public string REGAGENT2 { get; set; }
        public string REPDTE { get; set; }
        public string RISDATE { get; set; }
        public double ROA { get; set; }
        public double ROAPTX { get; set; }
        public double ROAPTXQ { get; set; }
        public double ROAQ { get; set; }
        public double ROE { get; set; }
        public double ROEQ { get; set; }
        public string RSSDHCR { get; set; }
        public string RUNDATE { get; set; }
        public int SASSER { get; set; }
        public double SPECGRP { get; set; }
        public string SPECGRPN { get; set; }
        public string STALP { get; set; }
        public string STALPHCR { get; set; }
        public int STCHRTR { get; set; }
        public string STCNTY { get; set; }
        public string STNAME { get; set; }
        public string STNUM { get; set; }
        public string SUBCHAPS { get; set; }

        [JsonProperty("SUPRV_FD")]
        public string SUPRVFD { get; set; }
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
        public string TRACT { get; set; }
        public string TRUST { get; set; }
        public string ULTCERT { get; set; }
        public string UNINUM { get; set; }
        public string WEBADDR { get; set; }
        public string ZIP { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataBKCLASSType
    {
        N,
        SM,
        NM,
        SB,
        SA,
        OI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
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
        public string ADDRESS { get; set; }
        public Data1BKCLASSType BKCLASS { get; set; }
        public string CBSA { get; set; }

        [JsonProperty("CBSA_DIV")]
        public string CBSADIV { get; set; }

        [JsonProperty("CBSA_DIV_FLG")]
        public Data1CBSADIVFLGType CBSADIVFLG { get; set; }

        [JsonProperty("CBSA_DIV_NO")]
        public string CBSADIVNO { get; set; }

        [JsonProperty("CBSA_METRO")]
        public string CBSAMETRO { get; set; }

        [JsonProperty("CBSA_METRO_FLG")]
        public string CBSAMETROFLG { get; set; }

        [JsonProperty("CBSA_METRO_NAME")]
        public string CBSAMETRONAME { get; set; }

        [JsonProperty("CBSA_MICRO_FLG")]
        public Data1CBSAMICROFLGType CBSAMICROFLG { get; set; }

        [JsonProperty("CBSA_NO")]
        public string CBSANO { get; set; }
        public string CERT { get; set; }
        public string CITY { get; set; }
        public string COUNTY { get; set; }
        public string CSA { get; set; }

        [JsonProperty("CSA_FLG")]
        public Data1CSAFLGType CSAFLG { get; set; }

        [JsonProperty("CSA_NO")]
        public string CSANO { get; set; }
        public string ESTYMD { get; set; }

        [JsonProperty("FI_UNINUM")]
        public int FIUNINUM { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }

        [JsonProperty("MDI_STATUS_CODE")]
        public string MDISTATUSCODE { get; set; }

        [JsonProperty("MDI_STATUS_DESC")]
        public string MDISTATUSDESC { get; set; }
        public Data1MAINOFFType MAINOFF { get; set; }
        public string NAME { get; set; }
        public string OFFNAME { get; set; }
        public int OFFNUM { get; set; }
        public string RUNDATE { get; set; }
        public Data1SERVTYPEType SERVTYPE { get; set; }

        [JsonProperty("SERVTYPE_DESC")]
        public string SERVTYPEDESC { get; set; }
        public string STALP { get; set; }
        public string STCNTY { get; set; }
        public string STNAME { get; set; }
        public int UNINUM { get; set; }
        public string ZIP { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1BKCLASSType
    {
        N,
        SM,
        NM,
        SB,
        SA,
        OI
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1CBSADIVFLGType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1CBSAMICROFLGType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1CSAFLGType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1MAINOFFType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data1SERVTYPEType
    {
        [EnumMember(Value = "11")]
        _11,
        [EnumMember(Value = "12")]
        _12,
        [EnumMember(Value = "13")]
        _13,
        [EnumMember(Value = "14")]
        _14,
        [EnumMember(Value = "15")]
        _15,
        [EnumMember(Value = "16")]
        _16,
        [EnumMember(Value = "21")]
        _21,
        [EnumMember(Value = "22")]
        _22,
        [EnumMember(Value = "23")]
        _23,
        [EnumMember(Value = "24")]
        _24,
        [EnumMember(Value = "25")]
        _25,
        [EnumMember(Value = "26")]
        _26,
        [EnumMember(Value = "27")]
        _27,
        [EnumMember(Value = "28")]
        _28,
        [EnumMember(Value = "29")]
        _29,
        [EnumMember(Value = "30")]
        _30
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
        public double TRANSNUM { get; set; }
        public double CHANGECODE { get; set; }

        [JsonProperty("CHANGECODE_DESC")]
        public string CHANGECODEDESC { get; set; }
        public string PROCDATE { get; set; }
        public string EFFDATE { get; set; }
        public string ENDDATE { get; set; }
        public int UNINUM { get; set; }

        [JsonProperty("ACQ_UNINUM")]
        public double ACQUNINUM { get; set; }

        [JsonProperty("OUT_UNINUM")]
        public double OUTUNINUM { get; set; }

        [JsonProperty("ORG_ROLE_CDE")]
        public string ORGROLECDE { get; set; }

        [JsonProperty("REPORT_TYPE")]
        public double REPORTTYPE { get; set; }
        public string CLASS { get; set; }

        [JsonProperty("BANK_INSURED")]
        public string BANKINSURED { get; set; }

        [JsonProperty("ACQ_CHANGECODE")]
        public double ACQCHANGECODE { get; set; }

        [JsonProperty("ACQ_ORG_EFF_DTE")]
        public string ACQORGEFFDTE { get; set; }

        [JsonProperty("ACQ_INSTNAME")]
        public string ACQINSTNAME { get; set; }

        [JsonProperty("ACQ_CERT")]
        public double ACQCERT { get; set; }

        [JsonProperty("ACQ_CLCODE")]
        public double ACQCLCODE { get; set; }

        [JsonProperty("ACQ_CHARTER")]
        public double ACQCHARTER { get; set; }

        [JsonProperty("ACQ_CHARTAGENT")]
        public string ACQCHARTAGENT { get; set; }

        [JsonProperty("ACQ_FDICREGION")]
        public double ACQFDICREGION { get; set; }

        [JsonProperty("ACQ_FDICREGION_DESC")]
        public string ACQFDICREGIONDESC { get; set; }

        [JsonProperty("ACQ_PADDR")]
        public string ACQPADDR { get; set; }

        [JsonProperty("ACQ_PCITY")]
        public string ACQPCITY { get; set; }

        [JsonProperty("ACQ_PSTALP")]
        public string ACQPSTALP { get; set; }

        [JsonProperty("ACQ_PZIP5")]
        public string ACQPZIP5 { get; set; }

        [JsonProperty("ACQ_PZIPREST")]
        public string ACQPZIPREST { get; set; }

        [JsonProperty("ACQ_MADDR")]
        public string ACQMADDR { get; set; }

        [JsonProperty("ACQ_MCITY")]
        public string ACQMCITY { get; set; }

        [JsonProperty("ACQ_MSTATE")]
        public string ACQMSTATE { get; set; }

        [JsonProperty("ACQ_MSTALP")]
        public string ACQMSTALP { get; set; }

        [JsonProperty("ACQ_MZIP5")]
        public string ACQMZIP5 { get; set; }

        [JsonProperty("ACQ_MZIPREST")]
        public string ACQMZIPREST { get; set; }

        [JsonProperty("ACQ_CLASS")]
        public string ACQCLASS { get; set; }

        [JsonProperty("ACQ_CNTYNAME")]
        public string ACQCNTYNAME { get; set; }

        [JsonProperty("ACQ_CNTYNUM")]
        public double ACQCNTYNUM { get; set; }

        [JsonProperty("ACQ_INSAGENT1")]
        public string ACQINSAGENT1 { get; set; }

        [JsonProperty("ACQ_INSAGENT2")]
        public string ACQINSAGENT2 { get; set; }

        [JsonProperty("ACQ_REGAGENT")]
        public string ACQREGAGENT { get; set; }

        [JsonProperty("ACQ_TRUST")]
        public string ACQTRUST { get; set; }

        [JsonProperty("ACQ_LATITUDE")]
        public double ACQLATITUDE { get; set; }

        [JsonProperty("ACQ_LONGITUDE")]
        public double ACQLONGITUDE { get; set; }

        [JsonProperty("OUT_INSTNAME")]
        public string OUTINSTNAME { get; set; }

        [JsonProperty("OUT_CERT")]
        public double OUTCERT { get; set; }

        [JsonProperty("OUT_CLCODE")]
        public double OUTCLCODE { get; set; }

        [JsonProperty("OUT_CHARTER")]
        public double OUTCHARTER { get; set; }

        [JsonProperty("OUT_CHARTAGENT")]
        public string OUTCHARTAGENT { get; set; }

        [JsonProperty("OUT_FDICREGION")]
        public double OUTFDICREGION { get; set; }

        [JsonProperty("OUT_FDICREGION_DESC")]
        public string OUTFDICREGIONDESC { get; set; }

        [JsonProperty("OUT_PADDR")]
        public string OUTPADDR { get; set; }

        [JsonProperty("OUT_PCITY")]
        public string OUTPCITY { get; set; }

        [JsonProperty("OUT_PSTALP")]
        public string OUTPSTALP { get; set; }

        [JsonProperty("OUT_PZIP5")]
        public string OUTPZIP5 { get; set; }

        [JsonProperty("OUT_PZIPREST")]
        public string OUTPZIPREST { get; set; }

        [JsonProperty("OUT_MADDR")]
        public string OUTMADDR { get; set; }

        [JsonProperty("OUT_MCITY")]
        public string OUTMCITY { get; set; }

        [JsonProperty("OUT_MSTATE")]
        public string OUTMSTATE { get; set; }

        [JsonProperty("OUT_MSTALP")]
        public string OUTMSTALP { get; set; }

        [JsonProperty("OUT_MZIP5")]
        public string OUTMZIP5 { get; set; }

        [JsonProperty("OUT_MZIPREST")]
        public string OUTMZIPREST { get; set; }

        [JsonProperty("OUT_CLASS")]
        public string OUTCLASS { get; set; }

        [JsonProperty("OUT_CNTYNAME")]
        public string OUTCNTYNAME { get; set; }

        [JsonProperty("OUT_CNTYNUM")]
        public double OUTCNTYNUM { get; set; }

        [JsonProperty("OUT_INSAGENT1")]
        public string OUTINSAGENT1 { get; set; }

        [JsonProperty("OUT_INSAGENT2")]
        public string OUTINSAGENT2 { get; set; }

        [JsonProperty("OUT_REGAGENT")]
        public string OUTREGAGENT { get; set; }

        [JsonProperty("OUT_TRUST")]
        public string OUTTRUST { get; set; }

        [JsonProperty("OUT_LATITUDE")]
        public double OUTLATITUDE { get; set; }

        [JsonProperty("OUT_LONGITUDE")]
        public double OUTLONGITUDE { get; set; }

        [JsonProperty("SUR_CHANGECODE")]
        public double SURCHANGECODE { get; set; }

        [JsonProperty("SUR_CHANGECODE_DESC")]
        public string SURCHANGECODEDESC { get; set; }

        [JsonProperty("SUR_INSTNAME")]
        public string SURINSTNAME { get; set; }

        [JsonProperty("SUR_CERT")]
        public double SURCERT { get; set; }

        [JsonProperty("SUR_CLCODE")]
        public double SURCLCODE { get; set; }

        [JsonProperty("SUR_CHARTER")]
        public double SURCHARTER { get; set; }

        [JsonProperty("SUR_CHARTAGENT")]
        public string SURCHARTAGENT { get; set; }

        [JsonProperty("SUR_FDICREGION")]
        public double SURFDICREGION { get; set; }

        [JsonProperty("SUR_FDICREGION_DESC")]
        public string SURFDICREGIONDESC { get; set; }

        [JsonProperty("SUR_MADDR")]
        public string SURMADDR { get; set; }

        [JsonProperty("SUR_MCITY")]
        public string SURMCITY { get; set; }

        [JsonProperty("SUR_MSTATE")]
        public string SURMSTATE { get; set; }

        [JsonProperty("SUR_MSTALP")]
        public string SURMSTALP { get; set; }

        [JsonProperty("SUR_MZIP5")]
        public string SURMZIP5 { get; set; }

        [JsonProperty("SUR_PZIP5")]
        public string SURPZIP5 { get; set; }

        [JsonProperty("SUR_CLASS")]
        public string SURCLASS { get; set; }

        [JsonProperty("SUR_CNTYNAME")]
        public string SURCNTYNAME { get; set; }

        [JsonProperty("SUR_CNTYNUM")]
        public double SURCNTYNUM { get; set; }

        [JsonProperty("SUR_INSAGENT1")]
        public string SURINSAGENT1 { get; set; }

        [JsonProperty("SUR_INSAGENT2")]
        public string SURINSAGENT2 { get; set; }

        [JsonProperty("SUR_PADDR")]
        public string SURPADDR { get; set; }

        [JsonProperty("SUR_PCITY")]
        public string SURPCITY { get; set; }

        [JsonProperty("SUR_PSTALP")]
        public string SURPSTALP { get; set; }

        [JsonProperty("SUR_PZIPREST")]
        public string SURPZIPREST { get; set; }

        [JsonProperty("SUR_REGAGENT")]
        public string SURREGAGENT { get; set; }

        [JsonProperty("SUR_TRUST")]
        public string SURTRUST { get; set; }

        [JsonProperty("SUR_LATITUDE")]
        public double SURLATITUDE { get; set; }

        [JsonProperty("SUR_LONGITUDE")]
        public double SURLONGITUDE { get; set; }

        [JsonProperty("FRM_CNTYNUM")]
        public double FRMCNTYNUM { get; set; }

        [JsonProperty("FRM_PCITY")]
        public string FRMPCITY { get; set; }

        [JsonProperty("FRM_REGAGENT")]
        public string FRMREGAGENT { get; set; }

        [JsonProperty("FRM_PSTALP")]
        public string FRMPSTALP { get; set; }

        [JsonProperty("FRM_TRUST")]
        public string FRMTRUST { get; set; }

        [JsonProperty("FRM_CLCODE")]
        public double FRMCLCODE { get; set; }

        [JsonProperty("FRM_PADDR")]
        public string FRMPADDR { get; set; }

        [JsonProperty("FRM_CHARTAGENT")]
        public string FRMCHARTAGENT { get; set; }

        [JsonProperty("FRM_CLASS")]
        public string FRMCLASS { get; set; }

        [JsonProperty("FRM_PZIP5")]
        public string FRMPZIP5 { get; set; }

        [JsonProperty("FRM_PZIPREST")]
        public string FRMPZIPREST { get; set; }

        [JsonProperty("FRM_INSTNAME")]
        public string FRMINSTNAME { get; set; }

        [JsonProperty("FRM_CNTYNAME")]
        public string FRMCNTYNAME { get; set; }

        [JsonProperty("FRM_CERT")]
        public double FRMCERT { get; set; }

        [JsonProperty("FRM_OFF_CNTYNAME")]
        public string FRMOFFCNTYNAME { get; set; }

        [JsonProperty("FRM_OFF_CNTYNUM")]
        public double FRMOFFCNTYNUM { get; set; }

        [JsonProperty("FRM_OFF_PADDR")]
        public string FRMOFFPADDR { get; set; }

        [JsonProperty("FRM_OFF_PCITY")]
        public string FRMOFFPCITY { get; set; }

        [JsonProperty("FRM_OFF_PSTALP")]
        public string FRMOFFPSTALP { get; set; }

        [JsonProperty("FRM_OFF_PZIP5")]
        public string FRMOFFPZIP5 { get; set; }

        [JsonProperty("FRM_OFF_PZIPREST")]
        public string FRMOFFPZIPREST { get; set; }

        [JsonProperty("FRM_OFF_SERVTYPE")]
        public double FRMOFFSERVTYPE { get; set; }

        [JsonProperty("FRM_OFF_SERVTYPE_DESC")]
        public string FRMOFFSERVTYPEDESC { get; set; }

        [JsonProperty("FRM_OFF_STATE")]
        public string FRMOFFSTATE { get; set; }

        [JsonProperty("FRM_OFF_NAME")]
        public string FRMOFFNAME { get; set; }

        [JsonProperty("FRM_OFF_NUM")]
        public string FRMOFFNUM { get; set; }

        [JsonProperty("FRM_OFF_TRUST")]
        public string FRMOFFTRUST { get; set; }

        [JsonProperty("FRM_OFF_CLCODE")]
        public double FRMOFFCLCODE { get; set; }

        [JsonProperty("FRM_OFF_LATITUDE")]
        public double FRMOFFLATITUDE { get; set; }

        [JsonProperty("FRM_OFF_LONGITUDE")]
        public double FRMOFFLONGITUDE { get; set; }

        [JsonProperty("FRM_LATITUDE")]
        public double FRMLATITUDE { get; set; }

        [JsonProperty("FRM_LONGITUDE")]
        public double FRMLONGITUDE { get; set; }
        public double CERT { get; set; }
        public string INSTNAME { get; set; }
        public string CHARTAGENT { get; set; }
        public double CLCODE { get; set; }
        public double FDICREGION { get; set; }

        [JsonProperty("FDICREGION_DESC")]
        public string FDICREGIONDESC { get; set; }
        public string CNTYNAME { get; set; }
        public double CNTYNUM { get; set; }
        public string INSAGENT1 { get; set; }
        public string INSAGENT2 { get; set; }
        public string MADDR { get; set; }
        public string MCITY { get; set; }
        public string MSTATE { get; set; }
        public string MSTALP { get; set; }
        public string MZIP5 { get; set; }
        public string MZIPREST { get; set; }
        public string PADDR { get; set; }
        public string PZIP5 { get; set; }
        public string PSTALP { get; set; }
        public string PZIPREST { get; set; }
        public string PCITY { get; set; }
        public string STATE { get; set; }
        public string TRUST { get; set; }
        public string REGAGENT { get; set; }
        public double SERVTYPE { get; set; }

        [JsonProperty("SERVTYPE_DESC")]
        public string SERVTYPEDESC { get; set; }

        [JsonProperty("OFF_CNTYNAME")]
        public string OFFCNTYNAME { get; set; }

        [JsonProperty("OFF_NUM")]
        public double OFFNUM { get; set; }

        [JsonProperty("OFF_CNTYNUM")]
        public double OFFCNTYNUM { get; set; }

        [JsonProperty("OFF_PADDR")]
        public string OFFPADDR { get; set; }

        [JsonProperty("OFF_PSTATE")]
        public string OFFPSTATE { get; set; }

        [JsonProperty("OFF_PZIP5")]
        public string OFFPZIP5 { get; set; }

        [JsonProperty("OFF_PZIPREST")]
        public string OFFPZIPREST { get; set; }

        [JsonProperty("OFF_NAME")]
        public string OFFNAME { get; set; }

        [JsonProperty("OFF_PSTALP")]
        public string OFFPSTALP { get; set; }

        [JsonProperty("OFF_PCITY")]
        public string OFFPCITY { get; set; }

        [JsonProperty("OFF_SERVTYPE")]
        public double OFFSERVTYPE { get; set; }

        [JsonProperty("OFF_LATITUDE")]
        public double OFFLATITUDE { get; set; }

        [JsonProperty("OFF_LONGITUDE")]
        public double OFFLONGITUDE { get; set; }

        [JsonProperty("OFF_SERVTYPE_DESC")]
        public string OFFSERVTYPEDESC { get; set; }
        public string ESTDATE { get; set; }
        public string ACQDATE { get; set; }

        [JsonProperty("FI_EFFDATE")]
        public string FIEFFDATE { get; set; }

        [JsonProperty("FI_UNINUM")]
        public int FIUNINUM { get; set; }

        [JsonProperty("ORG_STAT_FLG")]
        public string ORGSTATFLG { get; set; }
        public double LATITUDE { get; set; }
        public double LONGITUDE { get; set; }
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
        public int ALLOTHER { get; set; }

        [JsonProperty("alsonew")]
        public int Alsonew { get; set; }
        public int ASSET { get; set; }
        public int BANKS { get; set; }
        public string BKPREM { get; set; }
        public int BRANCHES { get; set; }
        public int BRANCHIN { get; set; }
        public int BRO { get; set; }
        public int BRWDMONY { get; set; }

        [JsonProperty("CB_SI")]
        public Data2CBSIType CBSI { get; set; }

        [JsonProperty("chartoth")]
        public int Chartoth { get; set; }
        public string CHBAL { get; set; }
        public string CHBALI { get; set; }

        [JsonProperty("chrtrest")]
        public string Chrtrest { get; set; }

        [JsonProperty("comboass")]
        public string Comboass { get; set; }

        [JsonProperty("combos")]
        public string Combos { get; set; }
        public int CONS { get; set; }
        public int CORPBNDS { get; set; }
        public int COUNT { get; set; }
        public string CRLNLS { get; set; }
        public string DDT { get; set; }
        public int DEP { get; set; }
        public int DEPDOM { get; set; }
        public string DEPFOR { get; set; }
        public string DEPI { get; set; }
        public string DEPIFOR { get; set; }
        public string DEPNI { get; set; }
        public string DEPNIFOR { get; set; }
        public string DRLNLS { get; set; }
        public string EAMINTAN { get; set; }
        public string EDEP { get; set; }
        public string EDEPDOM { get; set; }
        public string EDEPFOR { get; set; }
        public int EEREPP { get; set; }
        public int EFHLBADV { get; set; }
        public string EFREPP { get; set; }
        public string EINTEXP { get; set; }
        public string EINTEXP2 { get; set; }
        public string ELNATR { get; set; }
        public string EOTHNINT { get; set; }
        public string EPREMAGG { get; set; }
        public int EQ { get; set; }
        public string EQCDIV { get; set; }
        public string EQCDIVC { get; set; }
        public string EQCDIVP { get; set; }
        public string EQCS { get; set; }
        public int EQDIV { get; set; }
        public int EQNM { get; set; }
        public int EQNWCERT { get; set; }
        public string EQOTHCC { get; set; }
        public string EQPP { get; set; }
        public string EQSUR { get; set; }
        public string EQUPTOT { get; set; }
        public string ESAL { get; set; }
        public string ESUBND { get; set; }
        public string EXTRA { get; set; }

        [JsonProperty("FD_BIF")]
        public int FDBIF { get; set; }

        [JsonProperty("FD_SAIF")]
        public int FDSAIF { get; set; }
        public string FREPO { get; set; }
        public string FREPP { get; set; }
        public string ICHBAL { get; set; }
        public int IFEE { get; set; }
        public string IFREPO { get; set; }
        public string IGLSEC { get; set; }
        public string ILNDOM { get; set; }
        public string ILNFOR { get; set; }
        public string ILNLS { get; set; }
        public int ILNS { get; set; }
        public string ILS { get; set; }
        public string INTAN { get; set; }
        public int INTBAST { get; set; }
        public int INTBLIB { get; set; }
        public string INTINC { get; set; }
        public string INTINC2 { get; set; }
        public int IRAKEOGH { get; set; }
        public string ISC { get; set; }
        public string ISERCHG { get; set; }
        public string ITAX { get; set; }
        public int ITAXR { get; set; }
        public int ITRADE { get; set; }
        public string LIAB { get; set; }
        public int LIABEQ { get; set; }
        public int LIQASSTD { get; set; }
        public int LIQUNASS { get; set; }
        public int LNAG { get; set; }
        public int LNALLOTH { get; set; }
        public int LNATRES { get; set; }
        public int LNAUTO { get; set; }
        public int LNCI { get; set; }
        public int LNCON { get; set; }
        public int LNCONOT1 { get; set; }
        public int LNCONOTH { get; set; }
        public int LNCRCD { get; set; }
        public int LNDEP { get; set; }
        public int LNLS { get; set; }
        public int LNLSGR { get; set; }
        public int LNLSNET { get; set; }
        public int LNMOBILE { get; set; }
        public int LNMUNI { get; set; }
        public int LNRE { get; set; }
        public int LNREAG { get; set; }
        public int LNRECONS { get; set; }
        public int LNREDOM { get; set; }
        public int LNREFOR { get; set; }
        public int LNRELOC { get; set; }
        public int LNREMULT { get; set; }
        public int LNRENRES { get; set; }
        public int LNRERES { get; set; }
        public int LNRESRE { get; set; }
        public int LNSP { get; set; }
        public int LS { get; set; }
        public int MERGERS { get; set; }
        public int MISSADJ { get; set; }
        public int MTGLS { get; set; }
        public int NALNLS { get; set; }
        public int NCHGREC { get; set; }
        public int NCLNLS { get; set; }
        public int NETIMIN { get; set; }
        public int NETINC { get; set; }

        [JsonProperty("newcount")]
        public int Newcount { get; set; }

        [JsonProperty("New_Char")]
        public int NewChar { get; set; }

        [JsonProperty("NEW6_1")]
        public int NEW61 { get; set; }

        [JsonProperty("NEW9_1")]
        public int NEW91 { get; set; }

        [JsonProperty("NEW10_1")]
        public int NEW101 { get; set; }

        [JsonProperty("NEW10_2")]
        public int NEW102 { get; set; }

        [JsonProperty("NEW10_3")]
        public int NEW103 { get; set; }

        [JsonProperty("NEW11_1")]
        public int NEW111 { get; set; }

        [JsonProperty("NEW14_1")]
        public int NEW141 { get; set; }

        [JsonProperty("NEW14_2")]
        public int NEW142 { get; set; }

        [JsonProperty("NEW14_3")]
        public int NEW143 { get; set; }

        [JsonProperty("NEW14_4")]
        public int NEW144 { get; set; }

        [JsonProperty("NEW15_1")]
        public int NEW151 { get; set; }

        [JsonProperty("NEW15_2")]
        public int NEW152 { get; set; }

        [JsonProperty("NEW15_3")]
        public int NEW153 { get; set; }

        [JsonProperty("NEW15_4")]
        public int NEW154 { get; set; }

        [JsonProperty("NEW15_5")]
        public int NEW155 { get; set; }

        [JsonProperty("NEW15_7")]
        public int NEW157 { get; set; }

        [JsonProperty("NEW16_1")]
        public int NEW161 { get; set; }

        [JsonProperty("NEW16_2")]
        public int NEW162 { get; set; }
        public int NIM { get; set; }
        public int NONII { get; set; }
        public int NONIX { get; set; }
        public int NTLNLS { get; set; }
        public int NTR { get; set; }
        public int NTRTIME { get; set; }
        public int NTRTMLG { get; set; }
        public int NUMEMP { get; set; }
        public int OEA { get; set; }
        public int OFFICES { get; set; }
        public int OINTBOR { get; set; }
        public int OINTEXP { get; set; }
        public int OINTINC { get; set; }
        public int OONONII { get; set; }
        public int ORE { get; set; }
        public int ORET { get; set; }

        [JsonProperty("OT_BIF")]
        public int OTBIF { get; set; }

        [JsonProperty("OT_SAIF")]
        public int OTSAIF { get; set; }
        public int OTHASST { get; set; }
        public int OTHBFHLB { get; set; }
        public int OTHBORR { get; set; }
        public int OTHEQ { get; set; }
        public int OTHER { get; set; }
        public int OTHLIAB { get; set; }
        public int OTHNBORR { get; set; }
        public int OTLNCNTA { get; set; }

        [JsonProperty("PAID_OFF")]
        public int PAIDOFF { get; set; }
        public int P3LNLS { get; set; }
        public int P9LNLS { get; set; }
        public int PTXNOINC { get; set; }

        [JsonProperty("REL_CO")]
        public int RELCO { get; set; }
        public int SAVINGS { get; set; }
        public int SC { get; set; }
        public int SCAGE { get; set; }
        public int SCEQ { get; set; }
        public int SCMTGBK { get; set; }
        public int SCMUNI { get; set; }
        public int SCMV { get; set; }
        public int SCRES { get; set; }
        public int SCUS { get; set; }
        public int SCUSA { get; set; }
        public int SCUST { get; set; }
        public string STNAME { get; set; }
        public string STNUM { get; set; }
        public int SUBLLPF { get; set; }
        public int SUBND { get; set; }
        public int TINTINC { get; set; }

        [JsonProperty("tochrt")]
        public int Tochrt { get; set; }

        [JsonProperty("tofail")]
        public int Tofail { get; set; }
        public int TOINTEXP { get; set; }

        [JsonProperty("tomerg")]
        public string Tomerg { get; set; }

        [JsonProperty("tortc")]
        public string Tortc { get; set; }
        public int TOTAL { get; set; }

        [JsonProperty("TOT_FDIC")]
        public int TOTFDIC { get; set; }

        [JsonProperty("TOT_OTS")]
        public int TOTOTS { get; set; }

        [JsonProperty("TOT_SAVE")]
        public int TOTSAVE { get; set; }
        public int TPD { get; set; }
        public int TRADE { get; set; }
        public string TRADES { get; set; }
        public string TRN { get; set; }
        public int UNASSIST { get; set; }
        public string UNINC { get; set; }
        public int UNIT { get; set; }
        public string YEAR { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data2CBSIType
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
        public string NAME { get; set; }
        public double CERT { get; set; }
        public string FIN { get; set; }
        public string CITYST { get; set; }
        public string FAILDATE { get; set; }
        public string FAILYR { get; set; }
        public Data3SAVRType SAVR { get; set; }
        public Data3RESTYPE1Type RESTYPE1 { get; set; }
        public Data3CHCLASS1Type CHCLASS1 { get; set; }
        public string RESDATE { get; set; }
        public Data3RESTYPEType RESTYPE { get; set; }
        public double QBFDEP { get; set; }
        public int QBFASSET { get; set; }
        public string COST { get; set; }
        public string PSTALP { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3SAVRType
    {
        BIF,
        RTC,
        FSLIC,
        SAIF,
        DIF,
        FDIC
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3RESTYPE1Type
    {
        [EnumMember(Value = "A/A")]
        AA,
        REP,
        [EnumMember(Value = "P&A")]
        PA,
        PI,
        IDT,
        MGR,
        PO
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3CHCLASS1Type
    {
        N,
        SM,
        NM,
        SA,
        SB
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Data3RESTYPEType
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
        public string ADDRESBR { get; set; }
        public string ADDRESS { get; set; }
        public double ASSET { get; set; }
        public string BKCLASS { get; set; }
        public double BKMO { get; set; }
        public string BRCENM { get; set; }
        public double BRNUM { get; set; }
        public double BRSERTYP { get; set; }
        public string CALL { get; set; }
        public string CB { get; set; }

        [JsonProperty("CBSA_DIV_NAMB")]
        public string CBSADIVNAMB { get; set; }
        public double CERT { get; set; }
        public string CHARTER { get; set; }
        public string CHRTAGNN { get; set; }
        public string CHRTAGNT { get; set; }
        public string CITY { get; set; }
        public string CITY2BR { get; set; }
        public string CITYBR { get; set; }
        public string CITYHCR { get; set; }
        public double CLCODE { get; set; }
        public string CNTRYNA { get; set; }
        public string CNTRYNAB { get; set; }
        public string CNTYNAMB { get; set; }
        public double CNTYNUMB { get; set; }
        public int CONSOLD { get; set; }
        public double CSABR { get; set; }
        public string CSANAMBR { get; set; }
        public double DENOVO { get; set; }
        public double DEPDOM { get; set; }
        public double DEPSUM { get; set; }
        public double DEPSUMBR { get; set; }
        public double DIVISIONB { get; set; }
        public double DOCKET { get; set; }
        public string ESCROW { get; set; }
        public double FDICDBS { get; set; }
        public string FDICNAME { get; set; }
        public double FED { get; set; }
        public string FEDNAME { get; set; }
        public string HCTMULT { get; set; }
        public string INSAGNT1 { get; set; }
        public double INSBRDD { get; set; }
        public double INSBRTS { get; set; }
        public string INSURED { get; set; }
        public double METROBR { get; set; }
        public double MICROBR { get; set; }
        public double MSABR { get; set; }
        public string MSANAMB { get; set; }
        public string NAMEBR { get; set; }
        public string NAMEFULL { get; set; }
        public string NAMEHCR { get; set; }
        public string NECNAMB { get; set; }
        public string NECTABR { get; set; }
        public double OCCDIST { get; set; }
        public string OCCNAME { get; set; }
        public double PLACENUM { get; set; }
        public string REGAGNT { get; set; }
        public double RSSDHCR { get; set; }
        public double RSSDID { get; set; }

        [JsonProperty("SIMS_ACQUIRED_DATE")]
        public string SIMSACQUIREDDATE { get; set; }

        [JsonProperty("SIMS_DESCRIPTION")]
        public string SIMSDESCRIPTION { get; set; }

        [JsonProperty("SIMS_ESTABLISHED_DATE")]
        public string SIMSESTABLISHEDDATE { get; set; }

        [JsonProperty("SIMS_LATITUDE")]
        public double SIMSLATITUDE { get; set; }

        [JsonProperty("SIMS_LONGITUDE")]
        public double SIMSLONGITUDE { get; set; }

        [JsonProperty("SIMS_PROJECTION")]
        public string SIMSPROJECTION { get; set; }
        public string SPECDESC { get; set; }
        public double SPECGRP { get; set; }
        public string STALP { get; set; }
        public string STALPBR { get; set; }
        public string STALPHCR { get; set; }
        public double STCNTY { get; set; }
        public double STCNTYBR { get; set; }
        public string STNAME { get; set; }
        public string STNAMEBR { get; set; }
        public double STNUMBR { get; set; }
        public double UNINUMBR { get; set; }
        public double UNIT { get; set; }
        public double USA { get; set; }
        public double YEAR { get; set; }

        [JsonProperty("ZIP_RAW")]
        public string ZIPRAW { get; set; }

        [JsonProperty("ZIPBR_RAW")]
        public string ZIPBRRAW { get; set; }
        public string ZIP { get; set; }
        public string ZIPBR { get; set; }
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
        public string ACTEVT { get; set; }
        public double BRANCH { get; set; }
        public string CALLYM { get; set; }
        public string CALLYMD { get; set; }
        public string CBSANAME { get; set; }
        public double CERT { get; set; }
        public double CLCODE { get; set; }
        public string CNTRYALP { get; set; }
        public string CNTRYNUM { get; set; }
        public string CNTYNUM { get; set; }
        public string CSA { get; set; }
        public double DIVISION { get; set; }
        public double DOCKET { get; set; }
        public double FDICAREA { get; set; }
        public string FDICTERR { get; set; }
        public string FLDOFDCA { get; set; }
        public string HCTNONE { get; set; }
        public string INSAGNT2 { get; set; }
        public double METRO { get; set; }
        public double MICRO { get; set; }
        public string MNRTYCDE { get; set; }
        public string MNRTYDTE { get; set; }
        public double OAKAR { get; set; }
        public double OFFDMULT { get; set; }
        public double OFFNDOM { get; set; }
        public double OFFOTH { get; set; }
        public double OFFSOD { get; set; }
        public double OFFSTATE { get; set; }
        public double OFFTOT { get; set; }
        public double OFFUSOA { get; set; }
        public double QTRNO { get; set; }
        public string REPDTE { get; set; }

        [JsonProperty("REPDTE_INT")]
        public string REPDTEINT { get; set; }
        public string RISKTERR { get; set; }
        public int SASSER { get; set; }

        [JsonProperty("SIMS_LAT")]
        public double SIMSLAT { get; set; }

        [JsonProperty("SIMS_LONG")]
        public double SIMSLONG { get; set; }
        public string WEBADDR { get; set; }
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