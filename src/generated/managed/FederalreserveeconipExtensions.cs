//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Federalreserveeconip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FederalreserveeconipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<CategoryGetAResponse, ApiConnectionActionConfiguration> CategoryGetA(Expression<Func<int>> categoryId)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            return new DeferredBodyAction<CategoryGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                return new ApiConnectionAction<CategoryGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<CategoryGetChildResponse, ApiConnectionActionConfiguration> CategoryGetChild(Expression<Func<int>> categoryId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<CategoryGetChildResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category/children";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<CategoryGetChildResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<CategoryGetRelatedResponse, ApiConnectionActionConfiguration> CategoryGetRelated(Expression<Func<int>> categoryId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<CategoryGetRelatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category/related";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<CategoryGetRelatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<CategoryGetSeriesResponse, ApiConnectionActionConfiguration> CategoryGetSeries(Expression<Func<int>> categoryId, Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<FilterVariableInput>> filterVariable = null, Expression<Func<string>> filterValue = null, Expression<Func<string>> excludeTagNames = null)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_filterVariable = WorkflowExpression.Compile(filterVariable, nameof(filterVariable), required: false);
            var __workflow_filterValue = WorkflowExpression.Compile(filterValue, nameof(filterValue), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            return new DeferredBodyAction<CategoryGetSeriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category/series";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_filterVariable != null)
                    callPayload.Queries["filter_variable"] = ExpressionConverter.Convert(__workflow_filterVariable);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filter_value"] = ExpressionConverter.Convert(__workflow_filterValue);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                return new ApiConnectionAction<CategoryGetSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<CategoryGetTagsResponse, ApiConnectionActionConfiguration> CategoryGetTags(Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<CategoryGetTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<CategoryGetTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<CategoryGetRelatedTagsResponse, ApiConnectionActionConfiguration> CategoryGetRelatedTags(Expression<Func<int>> categoryId, Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<string>> excludeTagNames = null)
        {
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            return new DeferredBodyAction<CategoryGetRelatedTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category/related_tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(__workflow_categoryId);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                return new ApiConnectionAction<CategoryGetRelatedTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetAllResponse, ApiConnectionActionConfiguration> ReleaseGetAll(Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ReleaseGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/category/releases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<ReleaseGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetDatesResponse, ApiConnectionActionConfiguration> ReleaseGetDates(Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<IncludeReleaseDatesWithNoDataInput>> includeReleaseDatesWithNoData = null)
        {
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_includeReleaseDatesWithNoData = WorkflowExpression.Compile(includeReleaseDatesWithNoData, nameof(includeReleaseDatesWithNoData), required: false);
            return new DeferredBodyAction<ReleaseGetDatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/releases/dates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_includeReleaseDatesWithNoData != null)
                    callPayload.Queries["include_release_dates_with_no_data"] = ExpressionConverter.Convert(__workflow_includeReleaseDatesWithNoData);
                return new ApiConnectionAction<ReleaseGetDatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetAResponse, ApiConnectionActionConfiguration> ReleaseGetA(Expression<Func<int>> releaseId = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<ReleaseGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<ReleaseGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetReleaseDatesResponse, ApiConnectionActionConfiguration> ReleaseGetReleaseDates(Expression<Func<int>> releaseId = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<IncludeReleaseDatesWithNoDataInput>> includeReleaseDatesWithNoData = null)
        {
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_includeReleaseDatesWithNoData = WorkflowExpression.Compile(includeReleaseDatesWithNoData, nameof(includeReleaseDatesWithNoData), required: false);
            return new DeferredBodyAction<ReleaseGetReleaseDatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release/dates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_includeReleaseDatesWithNoData != null)
                    callPayload.Queries["include_release_dates_with_no_data"] = ExpressionConverter.Convert(__workflow_includeReleaseDatesWithNoData);
                return new ApiConnectionAction<ReleaseGetReleaseDatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetSeriesResponse, ApiConnectionActionConfiguration> ReleaseGetSeries(Expression<Func<string>> tagNames, Expression<Func<int>> releaseId = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<FilterVariableInput>> filterVariable = null, Expression<Func<string>> filterValue = null, Expression<Func<string>> excludeTagNames = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_filterVariable = WorkflowExpression.Compile(filterVariable, nameof(filterVariable), required: false);
            var __workflow_filterValue = WorkflowExpression.Compile(filterValue, nameof(filterValue), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            return new DeferredBodyAction<ReleaseGetSeriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release/series";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_filterVariable != null)
                    callPayload.Queries["filter_variable"] = ExpressionConverter.Convert(__workflow_filterVariable);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filter_value"] = ExpressionConverter.Convert(__workflow_filterValue);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                return new ApiConnectionAction<ReleaseGetSeriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetSourcesResponse, ApiConnectionActionConfiguration> ReleaseGetSources(Expression<Func<int>> releaseId = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<ReleaseGetSourcesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<ReleaseGetSourcesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetTagsResponse, ApiConnectionActionConfiguration> ReleaseGetTags(Expression<Func<string>> tagNames, Expression<Func<int>> releaseId = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ReleaseGetTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<ReleaseGetTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetRelatedTagsResponse, ApiConnectionActionConfiguration> ReleaseGetRelatedTags(Expression<Func<string>> tagNames, Expression<Func<int>> releaseId = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<string>> excludeTagNames = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<ReleaseGetRelatedTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release/related_tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<ReleaseGetRelatedTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<ReleaseGetTablesResponse, ApiConnectionActionConfiguration> ReleaseGetTables(Expression<Func<int>> releaseId = null, Expression<Func<int>> elementId = null, Expression<Func<IncludeObservationValuesInput>> includeObservationValues = null, Expression<Func<string>> observationDate = null)
        {
            var __workflow_releaseId = WorkflowExpression.Compile(releaseId, nameof(releaseId), required: false);
            var __workflow_elementId = WorkflowExpression.Compile(elementId, nameof(elementId), required: false);
            var __workflow_includeObservationValues = WorkflowExpression.Compile(includeObservationValues, nameof(includeObservationValues), required: false);
            var __workflow_observationDate = WorkflowExpression.Compile(observationDate, nameof(observationDate), required: false);
            return new DeferredBodyAction<ReleaseGetTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/release/tables";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_releaseId != null)
                    callPayload.Queries["release_id"] = ExpressionConverter.Convert(__workflow_releaseId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_elementId != null)
                    callPayload.Queries["element_id"] = ExpressionConverter.Convert(__workflow_elementId);
                callPayload.Queries["include_observation_values"] = Convert.ToString("false");
                if (__workflow_includeObservationValues != null)
                    callPayload.Queries["include_observation_values"] = ExpressionConverter.Convert(__workflow_includeObservationValues);
                if (__workflow_observationDate != null)
                    callPayload.Queries["observation_date"] = ExpressionConverter.Convert(__workflow_observationDate);
                return new ApiConnectionAction<ReleaseGetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetAResponse, ApiConnectionActionConfiguration> SeriesGetA(Expression<Func<string>> seriesId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_seriesId = WorkflowExpression.Compile(seriesId, nameof(seriesId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<SeriesGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_id"] = ExpressionConverter.Convert(__workflow_seriesId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<SeriesGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetCategoryResponse, ApiConnectionActionConfiguration> SeriesGetCategory(Expression<Func<string>> seriesId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_seriesId = WorkflowExpression.Compile(seriesId, nameof(seriesId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<SeriesGetCategoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_id"] = ExpressionConverter.Convert(__workflow_seriesId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<SeriesGetCategoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetReleaseResponse, ApiConnectionActionConfiguration> SeriesGetRelease(Expression<Func<string>> seriesId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_seriesId = WorkflowExpression.Compile(seriesId, nameof(seriesId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<SeriesGetReleaseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/release";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_id"] = ExpressionConverter.Convert(__workflow_seriesId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<SeriesGetReleaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesSearchResponse, ApiConnectionActionConfiguration> SeriesSearch(Expression<Func<string>> tagNames, Expression<Func<string>> searchText = null, Expression<Func<SearchTypeInput>> searchType = null, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<FilterVariableInput>> filterVariable = null, Expression<Func<string>> filterValue = null, Expression<Func<string>> excludeTagNames = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_searchType = WorkflowExpression.Compile(searchType, nameof(searchType), required: false);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_filterVariable = WorkflowExpression.Compile(filterVariable, nameof(filterVariable), required: false);
            var __workflow_filterValue = WorkflowExpression.Compile(filterValue, nameof(filterValue), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            return new DeferredBodyAction<SeriesSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                callPayload.Queries["search_type"] = Convert.ToString("full_text");
                if (__workflow_searchType != null)
                    callPayload.Queries["search_type"] = ExpressionConverter.Convert(__workflow_searchType);
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_filterVariable != null)
                    callPayload.Queries["filter_variable"] = ExpressionConverter.Convert(__workflow_filterVariable);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filter_value"] = ExpressionConverter.Convert(__workflow_filterValue);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                return new ApiConnectionAction<SeriesSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetRelatedTagsSearchResponse, ApiConnectionActionConfiguration> SeriesGetRelatedTagsSearch(Expression<Func<string>> seriesSearchText, Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<string>> excludeTagNames = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> tagSearchText = null)
        {
            var __workflow_seriesSearchText = WorkflowExpression.Compile(seriesSearchText, nameof(seriesSearchText), required: true);
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_tagSearchText = WorkflowExpression.Compile(tagSearchText, nameof(tagSearchText), required: false);
            return new DeferredBodyAction<SeriesGetRelatedTagsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/search/related_tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_search_text"] = ExpressionConverter.Convert(__workflow_seriesSearchText);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_tagSearchText != null)
                    callPayload.Queries["tag_search_text"] = ExpressionConverter.Convert(__workflow_tagSearchText);
                return new ApiConnectionAction<SeriesGetRelatedTagsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetTagsSearchResponse, ApiConnectionActionConfiguration> SeriesGetTagsSearch(Expression<Func<string>> seriesSearchText, Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> tagSearchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_seriesSearchText = WorkflowExpression.Compile(seriesSearchText, nameof(seriesSearchText), required: true);
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_tagSearchText = WorkflowExpression.Compile(tagSearchText, nameof(tagSearchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<SeriesGetTagsSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/search/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_search_text"] = ExpressionConverter.Convert(__workflow_seriesSearchText);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_tagSearchText != null)
                    callPayload.Queries["tag_search_text"] = ExpressionConverter.Convert(__workflow_tagSearchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<SeriesGetTagsSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetTagsResponse, ApiConnectionActionConfiguration> SeriesGetTags(Expression<Func<string>> seriesId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_seriesId = WorkflowExpression.Compile(seriesId, nameof(seriesId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<SeriesGetTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_id"] = ExpressionConverter.Convert(__workflow_seriesId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<SeriesGetTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetUpdatesResponse, ApiConnectionActionConfiguration> SeriesGetUpdates(Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> filterValue = null, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null)
        {
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_filterValue = WorkflowExpression.Compile(filterValue, nameof(filterValue), required: false);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            return new DeferredBodyAction<SeriesGetUpdatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/updates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_filterValue != null)
                    callPayload.Queries["filter_value"] = ExpressionConverter.Convert(__workflow_filterValue);
                if (__workflow_startTime != null)
                    callPayload.Queries["start_time"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(__workflow_endTime);
                return new ApiConnectionAction<SeriesGetUpdatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SeriesGetHistoryDatesResponse, ApiConnectionActionConfiguration> SeriesGetHistoryDates(Expression<Func<string>> seriesId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_seriesId = WorkflowExpression.Compile(seriesId, nameof(seriesId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<SeriesGetHistoryDatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/series/vintagedates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["series_id"] = ExpressionConverter.Convert(__workflow_seriesId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<SeriesGetHistoryDatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SourcesGetAllResponse, ApiConnectionActionConfiguration> SourcesGetAll(Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<SourcesGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<SourcesGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SourceGetAResponse, ApiConnectionActionConfiguration> SourceGetA(Expression<Func<int>> sourceId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null)
        {
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            return new DeferredBodyAction<SourceGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/source";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_id"] = ExpressionConverter.Convert(__workflow_sourceId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                return new ApiConnectionAction<SourceGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<SourceGetReleasesResponse, ApiConnectionActionConfiguration> SourceGetReleases(Expression<Func<int>> sourceId, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_sourceId = WorkflowExpression.Compile(sourceId, nameof(sourceId), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<SourceGetReleasesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/source/releases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source_id"] = ExpressionConverter.Convert(__workflow_sourceId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<SourceGetReleasesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<TagGetAllResponse, ApiConnectionActionConfiguration> TagGetAll(Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<TagGetAllResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<TagGetAllResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<TagGetRelatedResponse, ApiConnectionActionConfiguration> TagGetRelated(Expression<Func<string>> tagNames, Expression<Func<string>> realtimeStart = null, Expression<Func<string>> realtimeEnd = null, Expression<Func<string>> excludeTagNames = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_realtimeStart = WorkflowExpression.Compile(realtimeStart, nameof(realtimeStart), required: false);
            var __workflow_realtimeEnd = WorkflowExpression.Compile(realtimeEnd, nameof(realtimeEnd), required: false);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<TagGetRelatedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/related_tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_realtimeStart != null)
                    callPayload.Queries["realtime_start"] = ExpressionConverter.Convert(__workflow_realtimeStart);
                if (__workflow_realtimeEnd != null)
                    callPayload.Queries["realtime_end"] = ExpressionConverter.Convert(__workflow_realtimeEnd);
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<TagGetRelatedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "federalreserveeconip")]
        public IBodyWorkflowAction<TagGetSeriesResponse, ApiConnectionActionConfiguration> TagGetSeries(Expression<Func<string>> tagNames, Expression<Func<string>> excludeTagNames = null, Expression<Func<TagGroupIdInput>> tagGroupId = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<SortOrderInput>> sortOrder = null)
        {
            var __workflow_tagNames = WorkflowExpression.Compile(tagNames, nameof(tagNames), required: true);
            var __workflow_excludeTagNames = WorkflowExpression.Compile(excludeTagNames, nameof(excludeTagNames), required: false);
            var __workflow_tagGroupId = WorkflowExpression.Compile(tagGroupId, nameof(tagGroupId), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<TagGetSeriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tags/series";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tag_names"] = ExpressionConverter.Convert(__workflow_tagNames);
                callPayload.Queries["file_type"] = Convert.ToString("json");
                if (__workflow_excludeTagNames != null)
                    callPayload.Queries["exclude_tag_names"] = ExpressionConverter.Convert(__workflow_excludeTagNames);
                if (__workflow_tagGroupId != null)
                    callPayload.Queries["tag_group_id"] = ExpressionConverter.Convert(__workflow_tagGroupId);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                callPayload.Queries["limit"] = Convert.ToString(1000);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                callPayload.Queries["order_by"] = Convert.ToString("series_id");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order_by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["sort_order"] = Convert.ToString("asc");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<TagGetSeriesResponse>(callPayload);
            });
        }
    }

    public class FederalreserveeconipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CategoryGetAResponse
    {
        [JsonProperty("categories")]
        public CategoryGetAResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class CategoryGetAResponseCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
    }

    public class CategoryGetChildResponse
    {
        [JsonProperty("categories")]
        public CategoryGetChildResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class CategoryGetChildResponseCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
    }

    public class CategoryGetRelatedResponse
    {
        [JsonProperty("categories")]
        public CategoryGetRelatedResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class CategoryGetRelatedResponseCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
    }

    public class CategoryGetSeriesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public CategoryGetSeriesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public CategoryGetSeriesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("seriess")]
        public CategoryGetSeriesResponseSeriessTypeItem[] Seriess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryGetSeriesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryGetSeriesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CategoryGetSeriesResponseSeriessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("observation_start")]
        public string ObservationStart { get; set; }

        [JsonProperty("observation_end")]
        public string ObservationEnd { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("frequency_short")]
        public string FrequencyShort { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("units_short")]
        public string UnitsShort { get; set; }

        [JsonProperty("seasonal_adjustment")]
        public string SeasonalAdjustment { get; set; }

        [JsonProperty("seasonal_adjustment_short")]
        public string SeasonalAdjustmentShort { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("group_popularity")]
        public int GroupPopularity { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderByInput
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FilterVariableInput
    {
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment
    }

    public class CategoryGetTagsResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public CategoryGetTagsResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public CategoryGetTagsResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public CategoryGetTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryGetTagsResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryGetTagsResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CategoryGetTagsResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGroupIdInput
    {
        [EnumMember(Value = "freq")]
        Freq,
        [EnumMember(Value = "gen")]
        Gen,
        [EnumMember(Value = "geo")]
        Geo,
        [EnumMember(Value = "geot")]
        Geot,
        [EnumMember(Value = "rls")]
        Rls,
        [EnumMember(Value = "seas")]
        Seas,
        [EnumMember(Value = "src")]
        Src
    }

    public class CategoryGetRelatedTagsResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public CategoryGetRelatedTagsResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public CategoryGetRelatedTagsResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public CategoryGetRelatedTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryGetRelatedTagsResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryGetRelatedTagsResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CategoryGetRelatedTagsResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class ReleaseGetAllResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public ReleaseGetAllResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public ReleaseGetAllResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("releases")]
        public ReleaseGetAllResponseReleasesTypeItem[] Releases { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetAllResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetAllResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ReleaseGetAllResponseReleasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("press_release")]
        public bool PressRelease { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ReleaseGetDatesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public ReleaseGetDatesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public ReleaseGetDatesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("release_dates")]
        public ReleaseGetDatesResponseReleaseDatesTypeItem[] ReleaseDates { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetDatesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetDatesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ReleaseGetDatesResponseReleaseDatesTypeItem
    {
        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("release_name")]
        public string ReleaseName { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IncludeReleaseDatesWithNoDataInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class ReleaseGetAResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("releases")]
        public ReleaseGetAResponseReleasesTypeItem[] Releases { get; set; }
    }

    public class ReleaseGetAResponseReleasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("press_release")]
        public bool PressRelease { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ReleaseGetReleaseDatesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public ReleaseGetReleaseDatesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public ReleaseGetReleaseDatesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("release_dates")]
        public ReleaseGetReleaseDatesResponseReleaseDatesTypeItem[] ReleaseDates { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetReleaseDatesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetReleaseDatesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ReleaseGetReleaseDatesResponseReleaseDatesTypeItem
    {
        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    public class ReleaseGetSeriesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public ReleaseGetSeriesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public ReleaseGetSeriesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("seriess")]
        public ReleaseGetSeriesResponseSeriessTypeItem[] Seriess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetSeriesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetSeriesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ReleaseGetSeriesResponseSeriessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("observation_start")]
        public string ObservationStart { get; set; }

        [JsonProperty("observation_end")]
        public string ObservationEnd { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("frequency_short")]
        public string FrequencyShort { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("units_short")]
        public string UnitsShort { get; set; }

        [JsonProperty("seasonal_adjustment")]
        public string SeasonalAdjustment { get; set; }

        [JsonProperty("seasonal_adjustment_short")]
        public string SeasonalAdjustmentShort { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("group_popularity")]
        public int GroupPopularity { get; set; }
    }

    public class ReleaseGetSourcesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("sources")]
        public ReleaseGetSourcesResponseSourcesTypeItem[] Sources { get; set; }
    }

    public class ReleaseGetSourcesResponseSourcesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ReleaseGetTagsResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public ReleaseGetTagsResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public ReleaseGetTagsResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public ReleaseGetTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetTagsResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetTagsResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ReleaseGetTagsResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class ReleaseGetRelatedTagsResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public ReleaseGetRelatedTagsResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public ReleaseGetRelatedTagsResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public ReleaseGetRelatedTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetRelatedTagsResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReleaseGetRelatedTagsResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class ReleaseGetRelatedTagsResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class ReleaseGetTablesResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("element_id")]
        public int ElementId { get; set; }

        [JsonProperty("release_id")]
        public string ReleaseId { get; set; }

        [JsonProperty("elements")]
        public ReleaseGetTablesResponseElementsType Elements { get; set; }
    }

    public class ReleaseGetTablesResponseElementsType
    {
        [JsonProperty("element")]
        public ReleaseGetTablesResponseElementsTypeElementType Element { get; set; }
    }

    public class ReleaseGetTablesResponseElementsTypeElementType
    {
        [JsonProperty("element_id")]
        public int ElementId { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("series_id")]
        public string SeriesId { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("line")]
        public string Line { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("children")]
        public ReleaseGetTablesResponseElementsTypeElementTypeChildrenTypeItem[] Children { get; set; }
    }

    public class ReleaseGetTablesResponseElementsTypeElementTypeChildrenTypeItem
    {
        [JsonProperty("element_id")]
        public int ElementId { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("series_id")]
        public string SeriesId { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("line")]
        public string Line { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("children")]
        public JToken[] Children { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IncludeObservationValuesInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class SeriesGetAResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("seriess")]
        public SeriesGetAResponseSeriessTypeItem[] Seriess { get; set; }
    }

    public class SeriesGetAResponseSeriessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("observation_start")]
        public string ObservationStart { get; set; }

        [JsonProperty("observation_end")]
        public string ObservationEnd { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("frequency_short")]
        public string FrequencyShort { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("units_short")]
        public string UnitsShort { get; set; }

        [JsonProperty("seasonal_adjustment")]
        public string SeasonalAdjustment { get; set; }

        [JsonProperty("seasonal_adjustment_short")]
        public string SeasonalAdjustmentShort { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class SeriesGetCategoryResponse
    {
        [JsonProperty("categories")]
        public SeriesGetCategoryResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class SeriesGetCategoryResponseCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }
    }

    public class SeriesGetReleaseResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("releases")]
        public SeriesGetReleaseResponseReleasesTypeItem[] Releases { get; set; }
    }

    public class SeriesGetReleaseResponseReleasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("press_release")]
        public bool PressRelease { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SeriesSearchResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SeriesSearchResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SeriesSearchResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("seriess")]
        public SeriesSearchResponseSeriessTypeItem[] Seriess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesSearchResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesSearchResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SeriesSearchResponseSeriessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("observation_start")]
        public string ObservationStart { get; set; }

        [JsonProperty("observation_end")]
        public string ObservationEnd { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("frequency_short")]
        public string FrequencyShort { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("units_short")]
        public string UnitsShort { get; set; }

        [JsonProperty("seasonal_adjustment")]
        public string SeasonalAdjustment { get; set; }

        [JsonProperty("seasonal_adjustment_short")]
        public string SeasonalAdjustmentShort { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("group_popularity")]
        public int GroupPopularity { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchTypeInput
    {
        [EnumMember(Value = "full_text")]
        FullText,
        [EnumMember(Value = "series_id")]
        SeriesId
    }

    public class SeriesGetRelatedTagsSearchResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SeriesGetRelatedTagsSearchResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SeriesGetRelatedTagsSearchResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public SeriesGetRelatedTagsSearchResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetRelatedTagsSearchResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetRelatedTagsSearchResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SeriesGetRelatedTagsSearchResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class SeriesGetTagsSearchResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SeriesGetTagsSearchResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SeriesGetTagsSearchResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public SeriesGetTagsSearchResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetTagsSearchResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetTagsSearchResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SeriesGetTagsSearchResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class SeriesGetTagsResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SeriesGetTagsResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SeriesGetTagsResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public SeriesGetTagsResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetTagsResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetTagsResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SeriesGetTagsResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class SeriesGetUpdatesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("filter_variable")]
        public string FilterVariable { get; set; }

        [JsonProperty("filter_value")]
        public string FilterValue { get; set; }

        [JsonProperty("order_by")]
        public SeriesGetUpdatesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SeriesGetUpdatesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("seriess")]
        public SeriesGetUpdatesResponseSeriessTypeItem[] Seriess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetUpdatesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetUpdatesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SeriesGetUpdatesResponseSeriessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("observation_start")]
        public string ObservationStart { get; set; }

        [JsonProperty("observation_end")]
        public string ObservationEnd { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("frequency_short")]
        public string FrequencyShort { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("units_short")]
        public string UnitsShort { get; set; }

        [JsonProperty("seasonal_adjustment")]
        public string SeasonalAdjustment { get; set; }

        [JsonProperty("seasonal_adjustment_short")]
        public string SeasonalAdjustmentShort { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }
    }

    public class SeriesGetHistoryDatesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SeriesGetHistoryDatesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SeriesGetHistoryDatesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("vintage_dates")]
        public string[] VintageDates { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetHistoryDatesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeriesGetHistoryDatesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SourcesGetAllResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SourcesGetAllResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SourcesGetAllResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("sources")]
        public SourcesGetAllResponseSourcesTypeItem[] Sources { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourcesGetAllResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourcesGetAllResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SourcesGetAllResponseSourcesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SourceGetAResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("sources")]
        public SourceGetAResponseSourcesTypeItem[] Sources { get; set; }
    }

    public class SourceGetAResponseSourcesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SourceGetReleasesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public SourceGetReleasesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public SourceGetReleasesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("releases")]
        public SourceGetReleasesResponseReleasesTypeItem[] Releases { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourceGetReleasesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SourceGetReleasesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class SourceGetReleasesResponseReleasesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("press_release")]
        public bool PressRelease { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class TagGetAllResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public TagGetAllResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public TagGetAllResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public TagGetAllResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGetAllResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGetAllResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class TagGetAllResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class TagGetRelatedResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public TagGetRelatedResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public TagGetRelatedResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("tags")]
        public TagGetRelatedResponseTagsTypeItem[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGetRelatedResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGetRelatedResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class TagGetRelatedResponseTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("series_count")]
        public int SeriesCount { get; set; }
    }

    public class TagGetSeriesResponse
    {
        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("order_by")]
        public TagGetSeriesResponseOrderByType OrderBy { get; set; }

        [JsonProperty("sort_order")]
        public TagGetSeriesResponseSortOrderType SortOrder { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("seriess")]
        public TagGetSeriesResponseSeriessTypeItem[] Seriess { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGetSeriesResponseOrderByType
    {
        [EnumMember(Value = "series_id")]
        SeriesId,
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "units")]
        Units,
        [EnumMember(Value = "frequency")]
        Frequency,
        [EnumMember(Value = "seasonal_adjustment")]
        SeasonalAdjustment,
        [EnumMember(Value = "realtime_start")]
        RealtimeStart,
        [EnumMember(Value = "realtime_end")]
        RealtimeEnd,
        [EnumMember(Value = "last_updated")]
        LastUpdated,
        [EnumMember(Value = "observation_start")]
        ObservationStart,
        [EnumMember(Value = "observation_end")]
        ObservationEnd,
        [EnumMember(Value = "popularity")]
        Popularity,
        [EnumMember(Value = "group_popularity")]
        GroupPopularity
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TagGetSeriesResponseSortOrderType
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class TagGetSeriesResponseSeriessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("realtime_start")]
        public string RealtimeStart { get; set; }

        [JsonProperty("realtime_end")]
        public string RealtimeEnd { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("observation_start")]
        public string ObservationStart { get; set; }

        [JsonProperty("observation_end")]
        public string ObservationEnd { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("frequency_short")]
        public string FrequencyShort { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("units_short")]
        public string UnitsShort { get; set; }

        [JsonProperty("seasonal_adjustment")]
        public string SeasonalAdjustment { get; set; }

        [JsonProperty("seasonal_adjustment_short")]
        public string SeasonalAdjustmentShort { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("group_popularity")]
        public int GroupPopularity { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Federalreserveeconip;

    public partial class WorkflowManagedActions
    {
        public FederalreserveeconipActions Federalreserveeconip(string connectionId) => new FederalreserveeconipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FederalreserveeconipTriggers Federalreserveeconip(string connectionId) => new FederalreserveeconipTriggers(connectionId);
    }
}