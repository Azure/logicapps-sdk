//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rebrickableip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RebrickableipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoColorsListResponse, ApiConnectionActionConfiguration> LegoColorsList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoColorsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/lego/colors/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoColorsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoColorsReadResponse, ApiConnectionActionConfiguration> LegoColorsRead(Expression<Func<string>> id, Expression<Func<string>> ordering = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoColorsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/colors/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoColorsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoElementsReadResponse, ApiConnectionActionConfiguration> LegoElementsRead(Expression<Func<string>> elementId)
        {
            var __workflow_elementId = WorkflowExpression.Compile(elementId, nameof(elementId), required: true);
            return new DeferredBodyAction<LegoElementsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/elements/{0}/", __workflow_elementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LegoElementsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsListResponse, ApiConnectionActionConfiguration> LegoMinifigsList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<double>> minParts = null, Expression<Func<double>> maxParts = null, Expression<Func<string>> inSetNum = null, Expression<Func<string>> inThemeId = null, Expression<Func<string>> ordering = null, Expression<Func<string>> search = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_minParts = WorkflowExpression.Compile(minParts, nameof(minParts), required: false);
            var __workflow_maxParts = WorkflowExpression.Compile(maxParts, nameof(maxParts), required: false);
            var __workflow_inSetNum = WorkflowExpression.Compile(inSetNum, nameof(inSetNum), required: false);
            var __workflow_inThemeId = WorkflowExpression.Compile(inThemeId, nameof(inThemeId), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<LegoMinifigsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/lego/minifigs/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_minParts != null)
                    callPayload.Queries["min_parts"] = ExpressionConverter.Convert(__workflow_minParts);
                if (__workflow_maxParts != null)
                    callPayload.Queries["max_parts"] = ExpressionConverter.Convert(__workflow_maxParts);
                if (__workflow_inSetNum != null)
                    callPayload.Queries["in_set_num"] = ExpressionConverter.Convert(__workflow_inSetNum);
                if (__workflow_inThemeId != null)
                    callPayload.Queries["in_theme_id"] = ExpressionConverter.Convert(__workflow_inThemeId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<LegoMinifigsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsReadResponse, ApiConnectionActionConfiguration> LegoMinifigsRead(Expression<Func<string>> setNum)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            return new DeferredBodyAction<LegoMinifigsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/minifigs/{0}/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LegoMinifigsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsPartsListResponse, ApiConnectionActionConfiguration> LegoMinifigsPartsList(Expression<Func<string>> setNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LegoMinifigsPartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/minifigs/{0}/parts/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LegoMinifigsPartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsSetsListResponse, ApiConnectionActionConfiguration> LegoMinifigsSetsList(Expression<Func<string>> setNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoMinifigsSetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/minifigs/{0}/sets/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoMinifigsSetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartCategoriesListResponse, ApiConnectionActionConfiguration> LegoPartCategoriesList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoPartCategoriesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/lego/part_categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoPartCategoriesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartCategoriesReadResponse, ApiConnectionActionConfiguration> LegoPartCategoriesRead(Expression<Func<int>> id, Expression<Func<string>> ordering = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoPartCategoriesReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/part_categories/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoPartCategoriesReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsListResponse, ApiConnectionActionConfiguration> LegoPartsList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partNum = null, Expression<Func<string>> partNums = null, Expression<Func<string>> partCatId = null, Expression<Func<string>> colorId = null, Expression<Func<string>> bricklinkId = null, Expression<Func<string>> brickowlId = null, Expression<Func<string>> legoId = null, Expression<Func<string>> ldrawId = null, Expression<Func<string>> ordering = null, Expression<Func<string>> search = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: false);
            var __workflow_partNums = WorkflowExpression.Compile(partNums, nameof(partNums), required: false);
            var __workflow_partCatId = WorkflowExpression.Compile(partCatId, nameof(partCatId), required: false);
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: false);
            var __workflow_bricklinkId = WorkflowExpression.Compile(bricklinkId, nameof(bricklinkId), required: false);
            var __workflow_brickowlId = WorkflowExpression.Compile(brickowlId, nameof(brickowlId), required: false);
            var __workflow_legoId = WorkflowExpression.Compile(legoId, nameof(legoId), required: false);
            var __workflow_ldrawId = WorkflowExpression.Compile(ldrawId, nameof(ldrawId), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<LegoPartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/lego/parts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partNum != null)
                    callPayload.Queries["part_num"] = ExpressionConverter.Convert(__workflow_partNum);
                if (__workflow_partNums != null)
                    callPayload.Queries["part_nums"] = ExpressionConverter.Convert(__workflow_partNums);
                if (__workflow_partCatId != null)
                    callPayload.Queries["part_cat_id"] = ExpressionConverter.Convert(__workflow_partCatId);
                if (__workflow_colorId != null)
                    callPayload.Queries["color_id"] = ExpressionConverter.Convert(__workflow_colorId);
                if (__workflow_bricklinkId != null)
                    callPayload.Queries["bricklink_id"] = ExpressionConverter.Convert(__workflow_bricklinkId);
                if (__workflow_brickowlId != null)
                    callPayload.Queries["brickowl_id"] = ExpressionConverter.Convert(__workflow_brickowlId);
                if (__workflow_legoId != null)
                    callPayload.Queries["lego_id"] = ExpressionConverter.Convert(__workflow_legoId);
                if (__workflow_ldrawId != null)
                    callPayload.Queries["ldraw_id"] = ExpressionConverter.Convert(__workflow_ldrawId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<LegoPartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsReadResponse, ApiConnectionActionConfiguration> LegoPartsRead(Expression<Func<string>> partNum)
        {
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: true);
            return new DeferredBodyAction<LegoPartsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/parts/{0}/", __workflow_partNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LegoPartsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsColorsListResponse, ApiConnectionActionConfiguration> LegoPartsColorsList(Expression<Func<string>> partNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoPartsColorsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/parts/{0}/colors/", __workflow_partNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoPartsColorsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsColorsReadResponse, ApiConnectionActionConfiguration> LegoPartsColorsRead(Expression<Func<string>> colorId, Expression<Func<string>> partNum)
        {
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: true);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: true);
            return new DeferredBodyAction<LegoPartsColorsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/parts/{0}/colors/{1}/", __workflow_partNum.WithUrlEncoding(1), __workflow_colorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LegoPartsColorsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsColorsSetsListResponse, ApiConnectionActionConfiguration> LegoPartsColorsSetsList(Expression<Func<string>> colorId, Expression<Func<string>> partNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: true);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoPartsColorsSetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/parts/{0}/colors/{1}/sets/", __workflow_partNum.WithUrlEncoding(1), __workflow_colorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoPartsColorsSetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsListResponse, ApiConnectionActionConfiguration> LegoSetsList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> themeId = null, Expression<Func<double>> minYear = null, Expression<Func<double>> maxYear = null, Expression<Func<double>> minParts = null, Expression<Func<double>> maxParts = null, Expression<Func<string>> ordering = null, Expression<Func<string>> search = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_themeId = WorkflowExpression.Compile(themeId, nameof(themeId), required: false);
            var __workflow_minYear = WorkflowExpression.Compile(minYear, nameof(minYear), required: false);
            var __workflow_maxYear = WorkflowExpression.Compile(maxYear, nameof(maxYear), required: false);
            var __workflow_minParts = WorkflowExpression.Compile(minParts, nameof(minParts), required: false);
            var __workflow_maxParts = WorkflowExpression.Compile(maxParts, nameof(maxParts), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<LegoSetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/lego/sets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_themeId != null)
                    callPayload.Queries["theme_id"] = ExpressionConverter.Convert(__workflow_themeId);
                if (__workflow_minYear != null)
                    callPayload.Queries["min_year"] = ExpressionConverter.Convert(__workflow_minYear);
                if (__workflow_maxYear != null)
                    callPayload.Queries["max_year"] = ExpressionConverter.Convert(__workflow_maxYear);
                if (__workflow_minParts != null)
                    callPayload.Queries["min_parts"] = ExpressionConverter.Convert(__workflow_minParts);
                if (__workflow_maxParts != null)
                    callPayload.Queries["max_parts"] = ExpressionConverter.Convert(__workflow_maxParts);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<LegoSetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsReadResponse, ApiConnectionActionConfiguration> LegoSetsRead(Expression<Func<string>> setNum)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            return new DeferredBodyAction<LegoSetsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/sets/{0}/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LegoSetsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsAlternatesListResponse, ApiConnectionActionConfiguration> LegoSetsAlternatesList(Expression<Func<string>> setNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoSetsAlternatesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/sets/{0}/alternates/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoSetsAlternatesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsMinifigsListResponse, ApiConnectionActionConfiguration> LegoSetsMinifigsList(Expression<Func<string>> setNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LegoSetsMinifigsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/sets/{0}/minifigs/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LegoSetsMinifigsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsPartsListResponse, ApiConnectionActionConfiguration> LegoSetsPartsList(Expression<Func<string>> setNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LegoSetsPartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/sets/{0}/parts/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LegoSetsPartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsSetsListResponse, ApiConnectionActionConfiguration> LegoSetsSetsList(Expression<Func<string>> setNum, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<LegoSetsSetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/sets/{0}/sets/", __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<LegoSetsSetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoThemesListResponse, ApiConnectionActionConfiguration> LegoThemesList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoThemesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/lego/themes/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoThemesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoThemesReadResponse, ApiConnectionActionConfiguration> LegoThemesRead(Expression<Func<int>> id, Expression<Func<string>> ordering = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<LegoThemesReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/lego/themes/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<LegoThemesReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersTokenCreateResponse, ApiConnectionActionConfiguration> UsersTokenCreate(Expression<Func<string>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UsersTokenCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/users/_token/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UsersTokenCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersBadgesListResponse, ApiConnectionActionConfiguration> UsersBadgesList(Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersBadgesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/users/badges/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersBadgesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersBadgesReadResponse, ApiConnectionActionConfiguration> UsersBadgesRead(Expression<Func<int>> id, Expression<Func<string>> ordering = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersBadgesReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/badges/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersBadgesReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersAllpartsListResponse, ApiConnectionActionConfiguration> UsersAllpartsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partNum = null, Expression<Func<double>> partCatId = null, Expression<Func<double>> colorId = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: false);
            var __workflow_partCatId = WorkflowExpression.Compile(partCatId, nameof(partCatId), required: false);
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: false);
            return new DeferredBodyAction<UsersAllpartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/allparts/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partNum != null)
                    callPayload.Queries["part_num"] = ExpressionConverter.Convert(__workflow_partNum);
                if (__workflow_partCatId != null)
                    callPayload.Queries["part_cat_id"] = ExpressionConverter.Convert(__workflow_partCatId);
                if (__workflow_colorId != null)
                    callPayload.Queries["color_id"] = ExpressionConverter.Convert(__workflow_colorId);
                return new ApiConnectionAction<UsersAllpartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersBuildReadResponse, ApiConnectionActionConfiguration> UsersBuildRead(Expression<Func<string>> setNum, Expression<Func<string>> userToken)
        {
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            return new DeferredBodyAction<UsersBuildReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/build/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UsersBuildReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersLostPartsListResponse, ApiConnectionActionConfiguration> UsersLostPartsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersLostPartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/lost_parts/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersLostPartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UsersLostPartsDelete(Expression<Func<string>> userToken, Expression<Func<string>> id, Expression<Func<string>> ordering = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/lost_parts/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersMinifigsListResponse, ApiConnectionActionConfiguration> UsersMinifigsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> figSetNum = null, Expression<Func<string>> ordering = null, Expression<Func<string>> search = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_figSetNum = WorkflowExpression.Compile(figSetNum, nameof(figSetNum), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<UsersMinifigsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/minifigs/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_figSetNum != null)
                    callPayload.Queries["fig_set_num"] = ExpressionConverter.Convert(__workflow_figSetNum);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<UsersMinifigsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsListResponse, ApiConnectionActionConfiguration> UsersPartlistsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<UsersPartlistsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<UsersPartlistsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsReadResponse, ApiConnectionActionConfiguration> UsersPartlistsRead(Expression<Func<string>> listId, Expression<Func<string>> userToken)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            return new DeferredBodyAction<UsersPartlistsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UsersPartlistsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UsersPartlistsDelete(Expression<Func<string>> listId, Expression<Func<string>> userToken)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsUpdateResponse, ApiConnectionActionConfiguration> UsersPartlistsUpdate(Expression<Func<string>> userToken, Expression<Func<string>> listId, Expression<Func<UsersPartlistsUpdateInput>> body)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UsersPartlistsUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UsersPartlistsUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsPartsListResponse, ApiConnectionActionConfiguration> UsersPartlistsPartsList(Expression<Func<string>> listId, Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersPartlistsPartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/{1}/parts/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersPartlistsPartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsPartsReadResponse, ApiConnectionActionConfiguration> UsersPartlistsPartsRead(Expression<Func<string>> colorId, Expression<Func<string>> listId, Expression<Func<string>> partNum, Expression<Func<string>> userToken, Expression<Func<string>> ordering = null)
        {
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersPartlistsPartsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/{1}/parts/{2}/{3}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1), __workflow_partNum.WithUrlEncoding(1), __workflow_colorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersPartlistsPartsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UsersPartlistsPartsDelete(Expression<Func<string>> colorId, Expression<Func<string>> listId, Expression<Func<string>> partNum, Expression<Func<string>> userToken, Expression<Func<string>> ordering = null)
        {
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/partlists/{1}/parts/{2}/{3}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1), __workflow_partNum.WithUrlEncoding(1), __workflow_colorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartsListResponse, ApiConnectionActionConfiguration> UsersPartsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> partNum = null, Expression<Func<double>> partCatId = null, Expression<Func<double>> colorId = null, Expression<Func<string>> ordering = null, Expression<Func<string>> search = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_partNum = WorkflowExpression.Compile(partNum, nameof(partNum), required: false);
            var __workflow_partCatId = WorkflowExpression.Compile(partCatId, nameof(partCatId), required: false);
            var __workflow_colorId = WorkflowExpression.Compile(colorId, nameof(colorId), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<UsersPartsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/parts/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_partNum != null)
                    callPayload.Queries["part_num"] = ExpressionConverter.Convert(__workflow_partNum);
                if (__workflow_partCatId != null)
                    callPayload.Queries["part_cat_id"] = ExpressionConverter.Convert(__workflow_partCatId);
                if (__workflow_colorId != null)
                    callPayload.Queries["color_id"] = ExpressionConverter.Convert(__workflow_colorId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<UsersPartsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersProfileReadResponse, ApiConnectionActionConfiguration> UsersProfileRead(Expression<Func<string>> userToken)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            return new DeferredBodyAction<UsersProfileReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/profile/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UsersProfileReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsListResponse, ApiConnectionActionConfiguration> UsersSetlistsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<UsersSetlistsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<UsersSetlistsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsReadResponse, ApiConnectionActionConfiguration> UsersSetlistsRead(Expression<Func<string>> listId, Expression<Func<string>> userToken)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            return new DeferredBodyAction<UsersSetlistsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UsersSetlistsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UsersSetlistsDelete(Expression<Func<string>> listId, Expression<Func<string>> userToken)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsPartialUpdateResponse, ApiConnectionActionConfiguration> UsersSetlistsPartialUpdate(Expression<Func<string>> userToken, Expression<Func<string>> listId, Expression<Func<UsersSetlistsPartialUpdateInput>> body = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UsersSetlistsPartialUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/{1}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UsersSetlistsPartialUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsSetsListResponse, ApiConnectionActionConfiguration> UsersSetlistsSetsList(Expression<Func<string>> listId, Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> ordering = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersSetlistsSetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/{1}/sets/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersSetlistsSetsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsSetsReadResponse, ApiConnectionActionConfiguration> UsersSetlistsSetsRead(Expression<Func<string>> listId, Expression<Func<string>> setNum, Expression<Func<string>> userToken, Expression<Func<string>> ordering = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<UsersSetlistsSetsReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/{1}/sets/{2}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1), __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<UsersSetlistsSetsReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UsersSetlistsSetsDelete(Expression<Func<string>> listId, Expression<Func<string>> setNum, Expression<Func<string>> userToken, Expression<Func<string>> ordering = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: true);
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/setlists/{1}/sets/{2}/", __workflow_userToken.WithUrlEncoding(1), __workflow_listId.WithUrlEncoding(1), __workflow_setNum.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetsListResponse, ApiConnectionActionConfiguration> UsersSetsList(Expression<Func<string>> userToken, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> setNum = null, Expression<Func<double>> themeId = null, Expression<Func<double>> minYear = null, Expression<Func<double>> maxYear = null, Expression<Func<double>> minParts = null, Expression<Func<double>> maxParts = null, Expression<Func<string>> ordering = null, Expression<Func<string>> search = null)
        {
            var __workflow_userToken = WorkflowExpression.Compile(userToken, nameof(userToken), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_setNum = WorkflowExpression.Compile(setNum, nameof(setNum), required: false);
            var __workflow_themeId = WorkflowExpression.Compile(themeId, nameof(themeId), required: false);
            var __workflow_minYear = WorkflowExpression.Compile(minYear, nameof(minYear), required: false);
            var __workflow_maxYear = WorkflowExpression.Compile(maxYear, nameof(maxYear), required: false);
            var __workflow_minParts = WorkflowExpression.Compile(minParts, nameof(minParts), required: false);
            var __workflow_maxParts = WorkflowExpression.Compile(maxParts, nameof(maxParts), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<UsersSetsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/users/{0}/sets/", __workflow_userToken.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_setNum != null)
                    callPayload.Queries["set_num"] = ExpressionConverter.Convert(__workflow_setNum);
                if (__workflow_themeId != null)
                    callPayload.Queries["theme_id"] = ExpressionConverter.Convert(__workflow_themeId);
                if (__workflow_minYear != null)
                    callPayload.Queries["min_year"] = ExpressionConverter.Convert(__workflow_minYear);
                if (__workflow_maxYear != null)
                    callPayload.Queries["max_year"] = ExpressionConverter.Convert(__workflow_maxYear);
                if (__workflow_minParts != null)
                    callPayload.Queries["min_parts"] = ExpressionConverter.Convert(__workflow_minParts);
                if (__workflow_maxParts != null)
                    callPayload.Queries["max_parts"] = ExpressionConverter.Convert(__workflow_maxParts);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<UsersSetsListResponse>(callPayload);
            });
        }
    }

    public class RebrickableipTriggers([ConnectionName] string connectionId)
    {
    }

    public class LegoColorsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoColorsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public LegoColorsListResponseResultsTypeItemExternalIdsType ExternalIds { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItemExternalIdsType
    {
        public LegoColorsListResponseResultsTypeItemExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public LegoColorsListResponseResultsTypeItemExternalIdsTypeLEGOType LEGO { get; set; }
        public LegoColorsListResponseResultsTypeItemExternalIdsTypePeeronType Peeron { get; set; }
        public LegoColorsListResponseResultsTypeItemExternalIdsTypeLDrawType LDraw { get; set; }
        public LegoColorsListResponseResultsTypeItemExternalIdsTypeBrickLinkType BrickLink { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItemExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItemExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItemExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public JToken[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItemExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsListResponseResultsTypeItemExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsReadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public LegoColorsReadResponseExternalIdsType ExternalIds { get; set; }
    }

    public class LegoColorsReadResponseExternalIdsType
    {
        public LegoColorsReadResponseExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public LegoColorsReadResponseExternalIdsTypeLEGOType LEGO { get; set; }
        public LegoColorsReadResponseExternalIdsTypePeeronType Peeron { get; set; }
        public LegoColorsReadResponseExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class LegoColorsReadResponseExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsReadResponseExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsReadResponseExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public JToken[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoColorsReadResponseExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoElementsReadResponse
    {
        [JsonProperty("part")]
        public LegoElementsReadResponsePartType Part { get; set; }

        [JsonProperty("color")]
        public LegoElementsReadResponseColorType Color { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("design_id")]
        public string DesignId { get; set; }

        [JsonProperty("element_img_url")]
        public string ElementImgUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }
    }

    public class LegoElementsReadResponsePartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("year_from")]
        public int YearFrom { get; set; }

        [JsonProperty("year_to")]
        public int YearTo { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("prints")]
        public string[] Prints { get; set; }

        [JsonProperty("molds")]
        public string[] Molds { get; set; }

        [JsonProperty("alternates")]
        public string[] Alternates { get; set; }

        [JsonProperty("external_ids")]
        public LegoElementsReadResponsePartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class LegoElementsReadResponsePartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] Brickset { get; set; }
        public string[] LDraw { get; set; }
        public string[] LEGO { get; set; }
    }

    public class LegoElementsReadResponseColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public LegoElementsReadResponseColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class LegoElementsReadResponseColorTypeExternalIdsType
    {
        public LegoElementsReadResponseColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public LegoElementsReadResponseColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public LegoElementsReadResponseColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public LegoElementsReadResponseColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public LegoElementsReadResponseColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class LegoElementsReadResponseColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoElementsReadResponseColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoElementsReadResponseColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoElementsReadResponseColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoElementsReadResponseColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoMinifigsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoMinifigsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoMinifigsListResponseResultsTypeItem
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class LegoMinifigsReadResponse
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class LegoMinifigsPartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoMinifigsPartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("inv_part_id")]
        public int InvPartId { get; set; }

        [JsonProperty("part")]
        public LegoMinifigsPartsListResponseResultsTypeItemPartType Part { get; set; }

        [JsonProperty("color")]
        public LegoMinifigsPartsListResponseResultsTypeItemColorType Color { get; set; }

        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("is_spare")]
        public bool IsSpare { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemPartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public LegoMinifigsPartsListResponseResultsTypeItemPartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemPartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] Brickset { get; set; }
        public string[] LDraw { get; set; }
        public string[] LEGO { get; set; }
        public string[] Peeron { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsType
    {
        public LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoMinifigsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoMinifigsSetsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoMinifigsSetsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoMinifigsSetsListResponseResultsTypeItem
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class LegoPartCategoriesListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoPartCategoriesListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoPartCategoriesListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_count")]
        public int PartCount { get; set; }
    }

    public class LegoPartCategoriesReadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_count")]
        public int PartCount { get; set; }
    }

    public class LegoPartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoPartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoPartsListResponseResultsTypeItem
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public LegoPartsListResponseResultsTypeItemExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class LegoPartsListResponseResultsTypeItemExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] Brickset { get; set; }
        public string[] LDraw { get; set; }
        public string[] LEGO { get; set; }
    }

    public class LegoPartsReadResponse
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("year_from")]
        public int YearFrom { get; set; }

        [JsonProperty("year_to")]
        public int YearTo { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("prints")]
        public string[] Prints { get; set; }

        [JsonProperty("molds")]
        public string[] Molds { get; set; }

        [JsonProperty("alternates")]
        public string[] Alternates { get; set; }

        [JsonProperty("external_ids")]
        public LegoPartsReadResponseExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class LegoPartsReadResponseExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] Brickset { get; set; }
        public string[] LEGO { get; set; }
    }

    public class LegoPartsColorsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoPartsColorsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoPartsColorsListResponseResultsTypeItem
    {
        [JsonProperty("color_id")]
        public int ColorId { get; set; }

        [JsonProperty("color_name")]
        public string ColorName { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }

        [JsonProperty("num_set_parts")]
        public int NumSetParts { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("elements")]
        public string[] Elements { get; set; }
    }

    public class LegoPartsColorsReadResponse
    {
        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("year_from")]
        public int YearFrom { get; set; }

        [JsonProperty("year_to")]
        public int YearTo { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }

        [JsonProperty("num_set_parts")]
        public int NumSetParts { get; set; }

        [JsonProperty("elements")]
        public string[] Elements { get; set; }
    }

    public class LegoPartsColorsSetsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoPartsColorsSetsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoPartsColorsSetsListResponseResultsTypeItem
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class LegoSetsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoSetsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoSetsListResponseResultsTypeItem
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class LegoSetsReadResponse
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class LegoSetsAlternatesListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoSetsAlternatesListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoSetsAlternatesListResponseResultsTypeItem
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("moc_img_url")]
        public string MocImgUrl { get; set; }

        [JsonProperty("moc_url")]
        public string MocUrl { get; set; }

        [JsonProperty("designer_name")]
        public string DesignerName { get; set; }

        [JsonProperty("designer_url")]
        public string DesignerUrl { get; set; }
    }

    public class LegoSetsMinifigsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoSetsMinifigsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoSetsMinifigsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }
    }

    public class LegoSetsPartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoSetsPartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("inv_part_id")]
        public int InvPartId { get; set; }

        [JsonProperty("part")]
        public LegoSetsPartsListResponseResultsTypeItemPartType Part { get; set; }

        [JsonProperty("color")]
        public LegoSetsPartsListResponseResultsTypeItemColorType Color { get; set; }

        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("is_spare")]
        public bool IsSpare { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemPartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public LegoSetsPartsListResponseResultsTypeItemPartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemPartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] Brickset { get; set; }
        public string[] LDraw { get; set; }
        public string[] LEGO { get; set; }
        public string[] Peeron { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsType
    {
        public LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoSetsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class LegoSetsSetsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoSetsSetsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoSetsSetsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }
    }

    public class LegoThemesListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LegoThemesListResponseResultsTypeItem[] Results { get; set; }
    }

    public class LegoThemesListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LegoThemesReadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UsersTokenCreateResponse
    {
        [JsonProperty("user_token")]
        public string UserToken { get; set; }
    }

    public class UsersBadgesListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersBadgesListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersBadgesListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }
    }

    public class UsersBadgesReadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }
    }

    public class UsersAllpartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersAllpartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItem
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("part")]
        public UsersAllpartsListResponseResultsTypeItemPartType Part { get; set; }

        [JsonProperty("color")]
        public UsersAllpartsListResponseResultsTypeItemColorType Color { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemPartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public UsersAllpartsListResponseResultsTypeItemPartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemPartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] LDraw { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public string IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsType
    {
        public UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersAllpartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersBuildReadResponse
    {
        [JsonProperty("user")]
        public int User { get; set; }

        [JsonProperty("inventory")]
        public int Inventory { get; set; }

        [JsonProperty("user_list")]
        public string UserList { get; set; }

        [JsonProperty("pct_owned")]
        public double PctOwned { get; set; }

        [JsonProperty("num_missing")]
        public int NumMissing { get; set; }

        [JsonProperty("num_ignored")]
        public int NumIgnored { get; set; }

        [JsonProperty("num_owned_less_ignored")]
        public int NumOwnedLessIgnored { get; set; }

        [JsonProperty("total_parts")]
        public int TotalParts { get; set; }

        [JsonProperty("total_parts_less_ignored")]
        public int TotalPartsLessIgnored { get; set; }

        [JsonProperty("build_options")]
        public UsersBuildReadResponseBuildOptionsType BuildOptions { get; set; }
    }

    public class UsersBuildReadResponseBuildOptionsType
    {
        [JsonProperty("ignore_print")]
        public bool IgnorePrint { get; set; }

        [JsonProperty("ignore_mold")]
        public bool IgnoreMold { get; set; }

        [JsonProperty("ignore_altp")]
        public bool IgnoreAltp { get; set; }

        [JsonProperty("ignore_minifigs")]
        public bool IgnoreMinifigs { get; set; }

        [JsonProperty("ignore_non_lego")]
        public bool IgnoreNonLego { get; set; }

        [JsonProperty("sort_by")]
        public int SortBy { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("min_parts")]
        public int MinParts { get; set; }

        [JsonProperty("max_parts")]
        public int MaxParts { get; set; }

        [JsonProperty("min_year")]
        public int MinYear { get; set; }

        [JsonProperty("max_year")]
        public int MaxYear { get; set; }

        [JsonProperty("added_days_ago")]
        public int AddedDaysAgo { get; set; }

        [JsonProperty("inc_official")]
        public bool IncOfficial { get; set; }

        [JsonProperty("inc_custom")]
        public bool IncCustom { get; set; }

        [JsonProperty("inc_bmodels")]
        public bool IncBmodels { get; set; }

        [JsonProperty("inc_accessory")]
        public bool IncAccessory { get; set; }

        [JsonProperty("inc_premium")]
        public bool IncPremium { get; set; }

        [JsonProperty("inc_alts")]
        public bool IncAlts { get; set; }

        [JsonProperty("inc_owned")]
        public bool IncOwned { get; set; }
    }

    public class UsersLostPartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersLostPartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItem
    {
        [JsonProperty("lost_part_id")]
        public int LostPartId { get; set; }

        [JsonProperty("lost_quantity")]
        public int LostQuantity { get; set; }

        [JsonProperty("inv_part")]
        public UsersLostPartsListResponseResultsTypeItemInvPartType InvPart { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("inv_part_id")]
        public int InvPartId { get; set; }

        [JsonProperty("part")]
        public UsersLostPartsListResponseResultsTypeItemInvPartTypePartType Part { get; set; }

        [JsonProperty("color")]
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorType Color { get; set; }

        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("is_spare")]
        public bool IsSpare { get; set; }

        [JsonProperty("element_id")]
        public string ElementId { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypePartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public UsersLostPartsListResponseResultsTypeItemInvPartTypePartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypePartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] Brickset { get; set; }
        public string[] LDraw { get; set; }
        public string[] LEGO { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsType
    {
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersLostPartsListResponseResultsTypeItemInvPartTypeColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersMinifigsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersMinifigsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersMinifigsListResponseResultsTypeItem
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("minifig")]
        public UsersMinifigsListResponseResultsTypeItemMinifigType Minifig { get; set; }
    }

    public class UsersMinifigsListResponseResultsTypeItemMinifigType
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class UsersPartlistsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersPartlistsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersPartlistsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_buildable")]
        public bool IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }
    }

    public class UsersPartlistsReadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_buildable")]
        public bool IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }
    }

    public class UsersPartlistsUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_buildable")]
        public bool IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }
    }

    public class UsersPartlistsUpdateInput
    {
        [JsonProperty("is_buildable")]
        public bool? IsBuildable { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("num_parts")]
        public int? NumParts { get; set; }
    }

    public class UsersPartlistsPartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersPartlistsPartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItem
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("part")]
        public UsersPartlistsPartsListResponseResultsTypeItemPartType Part { get; set; }

        [JsonProperty("color")]
        public UsersPartlistsPartsListResponseResultsTypeItemColorType Color { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemPartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public UsersPartlistsPartsListResponseResultsTypeItemPartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemPartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] LDraw { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsType
    {
        public UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsReadResponse
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("part")]
        public UsersPartlistsPartsReadResponsePartType Part { get; set; }

        [JsonProperty("color")]
        public UsersPartlistsPartsReadResponseColorType Color { get; set; }
    }

    public class UsersPartlistsPartsReadResponsePartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public UsersPartlistsPartsReadResponsePartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class UsersPartlistsPartsReadResponsePartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
    }

    public class UsersPartlistsPartsReadResponseColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public UsersPartlistsPartsReadResponseColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class UsersPartlistsPartsReadResponseColorTypeExternalIdsType
    {
        public UsersPartlistsPartsReadResponseColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public UsersPartlistsPartsReadResponseColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public UsersPartlistsPartsReadResponseColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class UsersPartlistsPartsReadResponseColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsReadResponseColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartlistsPartsReadResponseColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersPartsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItem
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("part")]
        public UsersPartsListResponseResultsTypeItemPartType Part { get; set; }

        [JsonProperty("color")]
        public UsersPartsListResponseResultsTypeItemColorType Color { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemPartType
    {
        [JsonProperty("part_num")]
        public string PartNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("part_cat_id")]
        public int PartCatId { get; set; }

        [JsonProperty("part_url")]
        public string PartUrl { get; set; }

        [JsonProperty("part_img_url")]
        public string PartImgUrl { get; set; }

        [JsonProperty("external_ids")]
        public UsersPartsListResponseResultsTypeItemPartTypeExternalIdsType ExternalIds { get; set; }

        [JsonProperty("print_of")]
        public string PrintOf { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemPartTypeExternalIdsType
    {
        public string[] BrickLink { get; set; }
        public string[] BrickOwl { get; set; }
        public string[] LDraw { get; set; }
        public string[] Brickset { get; set; }
        public string[] LEGO { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rgb")]
        public string Rgb { get; set; }

        [JsonProperty("is_trans")]
        public bool IsTrans { get; set; }

        [JsonProperty("external_ids")]
        public UsersPartsListResponseResultsTypeItemColorTypeExternalIdsType ExternalIds { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorTypeExternalIdsType
    {
        public UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType BrickLink { get; set; }
        public UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType BrickOwl { get; set; }
        public UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType LEGO { get; set; }
        public UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType Peeron { get; set; }
        public UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType LDraw { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickLinkType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeBrickOwlType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLEGOType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypePeeronType
    {
        [JsonProperty("ext_ids")]
        public string[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersPartsListResponseResultsTypeItemColorTypeExternalIdsTypeLDrawType
    {
        [JsonProperty("ext_ids")]
        public int[] ExtIds { get; set; }

        [JsonProperty("ext_descrs")]
        public string[][] ExtDescrs { get; set; }
    }

    public class UsersProfileReadResponse
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("last_activity")]
        public string LastActivity { get; set; }

        [JsonProperty("last_ip")]
        public string LastIp { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("rewards")]
        public UsersProfileReadResponseRewardsType Rewards { get; set; }

        [JsonProperty("lego")]
        public UsersProfileReadResponseLegoType Lego { get; set; }

        [JsonProperty("avatar_img")]
        public string AvatarImg { get; set; }
    }

    public class UsersProfileReadResponseRewardsType
    {
        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("badges")]
        public int[] Badges { get; set; }
    }

    public class UsersProfileReadResponseLegoType
    {
        [JsonProperty("total_sets")]
        public int TotalSets { get; set; }

        [JsonProperty("total_loose_parts")]
        public int TotalLooseParts { get; set; }

        [JsonProperty("total_set_parts")]
        public int TotalSetParts { get; set; }

        [JsonProperty("lost_set_parts")]
        public int LostSetParts { get; set; }

        [JsonProperty("all_parts")]
        public int AllParts { get; set; }

        [JsonProperty("total_figs")]
        public int TotalFigs { get; set; }
    }

    public class UsersSetlistsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersSetlistsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersSetlistsListResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_buildable")]
        public bool IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }
    }

    public class UsersSetlistsReadResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_buildable")]
        public bool IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }
    }

    public class UsersSetlistsPartialUpdateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_buildable")]
        public bool IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_sets")]
        public int NumSets { get; set; }
    }

    public class UsersSetlistsPartialUpdateInput
    {
        [JsonProperty("is_buildable")]
        public bool? IsBuildable { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("num_sets")]
        public int? NumSets { get; set; }
    }

    public class UsersSetlistsSetsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersSetlistsSetsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersSetlistsSetsListResponseResultsTypeItem
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("include_spares")]
        public bool IncludeSpares { get; set; }

        [JsonProperty("set")]
        public UsersSetlistsSetsListResponseResultsTypeItemSetType Set { get; set; }
    }

    public class UsersSetlistsSetsListResponseResultsTypeItemSetType
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class UsersSetlistsSetsReadResponse
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("include_spares")]
        public bool IncludeSpares { get; set; }

        [JsonProperty("set")]
        public UsersSetlistsSetsReadResponseSetType Set { get; set; }
    }

    public class UsersSetlistsSetsReadResponseSetType
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }

    public class UsersSetsListResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public UsersSetsListResponseResultsTypeItem[] Results { get; set; }
    }

    public class UsersSetsListResponseResultsTypeItem
    {
        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("include_spares")]
        public bool IncludeSpares { get; set; }

        [JsonProperty("set")]
        public UsersSetsListResponseResultsTypeItemSetType Set { get; set; }
    }

    public class UsersSetsListResponseResultsTypeItemSetType
    {
        [JsonProperty("set_num")]
        public string SetNum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("theme_id")]
        public int ThemeId { get; set; }

        [JsonProperty("num_parts")]
        public int NumParts { get; set; }

        [JsonProperty("set_img_url")]
        public string SetImgUrl { get; set; }

        [JsonProperty("set_url")]
        public string SetUrl { get; set; }

        [JsonProperty("last_modified_dt")]
        public string LastModifiedDt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rebrickableip;

    public partial class WorkflowManagedActions
    {
        public RebrickableipActions Rebrickableip(string connectionId) => new RebrickableipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RebrickableipTriggers Rebrickableip(string connectionId) => new RebrickableipTriggers(connectionId);
    }
}