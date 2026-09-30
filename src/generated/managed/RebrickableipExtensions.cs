//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rebrickableip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RebrickableipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoColorsListResponse> LegoColorsList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/lego/colors/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoColorsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoColorsReadResponse> LegoColorsRead([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/colors/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoColorsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoElementsReadResponse> LegoElementsRead([WorkflowExpression] Func<string> elementId)
        {
            SourceExpression.Validate(elementId, nameof(elementId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/elements/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(elementId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LegoElementsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsListResponse> LegoMinifigsList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<double> minParts = null, [WorkflowExpression] Func<double> maxParts = null, [WorkflowExpression] Func<string> inSetNum = null, [WorkflowExpression] Func<string> inThemeId = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(minParts, nameof(minParts), required: false);
            SourceExpression.Validate(maxParts, nameof(maxParts), required: false);
            SourceExpression.Validate(inSetNum, nameof(inSetNum), required: false);
            SourceExpression.Validate(inThemeId, nameof(inThemeId), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/lego/minifigs/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (minParts != null)
                    callPayload.Queries["min_parts"] = SourceExpressionConverter.ConvertO(minParts);
                if (maxParts != null)
                    callPayload.Queries["max_parts"] = SourceExpressionConverter.ConvertO(maxParts);
                if (inSetNum != null)
                    callPayload.Queries["in_set_num"] = SourceExpressionConverter.ConvertO(inSetNum);
                if (inThemeId != null)
                    callPayload.Queries["in_theme_id"] = SourceExpressionConverter.ConvertO(inThemeId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<LegoMinifigsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsReadResponse> LegoMinifigsRead([WorkflowExpression] Func<string> setNum)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/minifigs/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LegoMinifigsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsPartsListResponse> LegoMinifigsPartsList([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/minifigs/{0}/parts/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LegoMinifigsPartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoMinifigsSetsListResponse> LegoMinifigsSetsList([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/minifigs/{0}/sets/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoMinifigsSetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartCategoriesListResponse> LegoPartCategoriesList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/lego/part_categories/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartCategoriesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartCategoriesReadResponse> LegoPartCategoriesRead([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/part_categories/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartCategoriesReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsListResponse> LegoPartsList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> partNum = null, [WorkflowExpression] Func<string> partNums = null, [WorkflowExpression] Func<string> partCatId = null, [WorkflowExpression] Func<string> colorId = null, [WorkflowExpression] Func<string> bricklinkId = null, [WorkflowExpression] Func<string> brickowlId = null, [WorkflowExpression] Func<string> legoId = null, [WorkflowExpression] Func<string> ldrawId = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(partNum, nameof(partNum), required: false);
            SourceExpression.Validate(partNums, nameof(partNums), required: false);
            SourceExpression.Validate(partCatId, nameof(partCatId), required: false);
            SourceExpression.Validate(colorId, nameof(colorId), required: false);
            SourceExpression.Validate(bricklinkId, nameof(bricklinkId), required: false);
            SourceExpression.Validate(brickowlId, nameof(brickowlId), required: false);
            SourceExpression.Validate(legoId, nameof(legoId), required: false);
            SourceExpression.Validate(ldrawId, nameof(ldrawId), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/lego/parts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (partNum != null)
                    callPayload.Queries["part_num"] = SourceExpressionConverter.ConvertO(partNum);
                if (partNums != null)
                    callPayload.Queries["part_nums"] = SourceExpressionConverter.ConvertO(partNums);
                if (partCatId != null)
                    callPayload.Queries["part_cat_id"] = SourceExpressionConverter.ConvertO(partCatId);
                if (colorId != null)
                    callPayload.Queries["color_id"] = SourceExpressionConverter.ConvertO(colorId);
                if (bricklinkId != null)
                    callPayload.Queries["bricklink_id"] = SourceExpressionConverter.ConvertO(bricklinkId);
                if (brickowlId != null)
                    callPayload.Queries["brickowl_id"] = SourceExpressionConverter.ConvertO(brickowlId);
                if (legoId != null)
                    callPayload.Queries["lego_id"] = SourceExpressionConverter.ConvertO(legoId);
                if (ldrawId != null)
                    callPayload.Queries["ldraw_id"] = SourceExpressionConverter.ConvertO(ldrawId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsReadResponse> LegoPartsRead([WorkflowExpression] Func<string> partNum)
        {
            SourceExpression.Validate(partNum, nameof(partNum), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/parts/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsColorsListResponse> LegoPartsColorsList([WorkflowExpression] Func<string> partNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(partNum, nameof(partNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/parts/{0}/colors/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartsColorsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsColorsReadResponse> LegoPartsColorsRead([WorkflowExpression] Func<string> colorId, [WorkflowExpression] Func<string> partNum)
        {
            SourceExpression.Validate(colorId, nameof(colorId), required: true);
            SourceExpression.Validate(partNum, nameof(partNum), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/parts/{0}/colors/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partNum, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(colorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartsColorsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoPartsColorsSetsListResponse> LegoPartsColorsSetsList([WorkflowExpression] Func<string> colorId, [WorkflowExpression] Func<string> partNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(colorId, nameof(colorId), required: true);
            SourceExpression.Validate(partNum, nameof(partNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/parts/{0}/colors/{1}/sets/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partNum, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(colorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoPartsColorsSetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsListResponse> LegoSetsList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> themeId = null, [WorkflowExpression] Func<double> minYear = null, [WorkflowExpression] Func<double> maxYear = null, [WorkflowExpression] Func<double> minParts = null, [WorkflowExpression] Func<double> maxParts = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(themeId, nameof(themeId), required: false);
            SourceExpression.Validate(minYear, nameof(minYear), required: false);
            SourceExpression.Validate(maxYear, nameof(maxYear), required: false);
            SourceExpression.Validate(minParts, nameof(minParts), required: false);
            SourceExpression.Validate(maxParts, nameof(maxParts), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/lego/sets/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (themeId != null)
                    callPayload.Queries["theme_id"] = SourceExpressionConverter.ConvertO(themeId);
                if (minYear != null)
                    callPayload.Queries["min_year"] = SourceExpressionConverter.ConvertO(minYear);
                if (maxYear != null)
                    callPayload.Queries["max_year"] = SourceExpressionConverter.ConvertO(maxYear);
                if (minParts != null)
                    callPayload.Queries["min_parts"] = SourceExpressionConverter.ConvertO(minParts);
                if (maxParts != null)
                    callPayload.Queries["max_parts"] = SourceExpressionConverter.ConvertO(maxParts);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<LegoSetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsReadResponse> LegoSetsRead([WorkflowExpression] Func<string> setNum)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/sets/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LegoSetsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsAlternatesListResponse> LegoSetsAlternatesList([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/sets/{0}/alternates/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoSetsAlternatesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsMinifigsListResponse> LegoSetsMinifigsList([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/sets/{0}/minifigs/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LegoSetsMinifigsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsPartsListResponse> LegoSetsPartsList([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/sets/{0}/parts/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LegoSetsPartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoSetsSetsListResponse> LegoSetsSetsList([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/sets/{0}/sets/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<LegoSetsSetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoThemesListResponse> LegoThemesList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/lego/themes/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoThemesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<LegoThemesReadResponse> LegoThemesRead([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/lego/themes/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<LegoThemesReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersTokenCreateResponse> UsersTokenCreate([WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/users/_token/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/x-www-form-urlencoded");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<UsersTokenCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersBadgesListResponse> UsersBadgesList([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/users/badges/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersBadgesListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersBadgesReadResponse> UsersBadgesRead([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/badges/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersBadgesReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersAllpartsListResponse> UsersAllpartsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> partNum = null, [WorkflowExpression] Func<double> partCatId = null, [WorkflowExpression] Func<double> colorId = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(partNum, nameof(partNum), required: false);
            SourceExpression.Validate(partCatId, nameof(partCatId), required: false);
            SourceExpression.Validate(colorId, nameof(colorId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/allparts/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (partNum != null)
                    callPayload.Queries["part_num"] = SourceExpressionConverter.ConvertO(partNum);
                if (partCatId != null)
                    callPayload.Queries["part_cat_id"] = SourceExpressionConverter.ConvertO(partCatId);
                if (colorId != null)
                    callPayload.Queries["color_id"] = SourceExpressionConverter.ConvertO(colorId);
                return callPayload;
            }

            return new ApiConnectionAction<UsersAllpartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersBuildReadResponse> UsersBuildRead([WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<string> userToken)
        {
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/build/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UsersBuildReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersLostPartsListResponse> UsersLostPartsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/lost_parts/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersLostPartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction UsersLostPartsDelete([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/lost_parts/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersMinifigsListResponse> UsersMinifigsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> figSetNum = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(figSetNum, nameof(figSetNum), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/minifigs/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (figSetNum != null)
                    callPayload.Queries["fig_set_num"] = SourceExpressionConverter.ConvertO(figSetNum);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<UsersMinifigsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsListResponse> UsersPartlistsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<UsersPartlistsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsReadResponse> UsersPartlistsRead([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> userToken)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UsersPartlistsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction UsersPartlistsDelete([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> userToken)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsUpdateResponse> UsersPartlistsUpdate([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyisBuildable = null, [WorkflowExpression] Func<int> bodynumParts = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyisBuildable, nameof(bodyisBuildable), required: false);
            SourceExpression.Validate(bodynumParts, nameof(bodynumParts), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisBuildable != null)
                {
                    body["is_buildable"] = SourceExpressionConverter.ConvertToken(bodyisBuildable);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodynumParts != null)
                {
                    body["num_parts"] = SourceExpressionConverter.ConvertToken(bodynumParts);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UsersPartlistsUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsPartsListResponse> UsersPartlistsPartsList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/{1}/parts/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersPartlistsPartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartlistsPartsReadResponse> UsersPartlistsPartsRead([WorkflowExpression] Func<string> colorId, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> partNum, [WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(colorId, nameof(colorId), required: true);
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(partNum, nameof(partNum), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/{1}/parts/{2}/{3}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partNum, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(colorId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersPartlistsPartsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction UsersPartlistsPartsDelete([WorkflowExpression] Func<string> colorId, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> partNum, [WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(colorId, nameof(colorId), required: true);
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(partNum, nameof(partNum), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/partlists/{1}/parts/{2}/{3}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partNum, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(colorId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersPartsListResponse> UsersPartsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> partNum = null, [WorkflowExpression] Func<double> partCatId = null, [WorkflowExpression] Func<double> colorId = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(partNum, nameof(partNum), required: false);
            SourceExpression.Validate(partCatId, nameof(partCatId), required: false);
            SourceExpression.Validate(colorId, nameof(colorId), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/parts/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (partNum != null)
                    callPayload.Queries["part_num"] = SourceExpressionConverter.ConvertO(partNum);
                if (partCatId != null)
                    callPayload.Queries["part_cat_id"] = SourceExpressionConverter.ConvertO(partCatId);
                if (colorId != null)
                    callPayload.Queries["color_id"] = SourceExpressionConverter.ConvertO(colorId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<UsersPartsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersProfileReadResponse> UsersProfileRead([WorkflowExpression] Func<string> userToken)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/profile/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UsersProfileReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsListResponse> UsersSetlistsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<UsersSetlistsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsReadResponse> UsersSetlistsRead([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> userToken)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UsersSetlistsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction UsersSetlistsDelete([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> userToken)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsPartialUpdateResponse> UsersSetlistsPartialUpdate([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<bool> bodyisBuildable = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<int> bodynumSets = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodyisBuildable, nameof(bodyisBuildable), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodynumSets, nameof(bodynumSets), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/{1}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisBuildable != null)
                {
                    body["is_buildable"] = SourceExpressionConverter.ConvertToken(bodyisBuildable);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynumSets != null)
                {
                    body["num_sets"] = SourceExpressionConverter.ConvertToken(bodynumSets);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UsersSetlistsPartialUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsSetsListResponse> UsersSetlistsSetsList([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/{1}/sets/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersSetlistsSetsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetlistsSetsReadResponse> UsersSetlistsSetsRead([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/{1}/sets/{2}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<UsersSetlistsSetsReadResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IWorkflowAction UsersSetlistsSetsDelete([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> setNum, [WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<string> ordering = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(setNum, nameof(setNum), required: true);
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/setlists/{1}/sets/{2}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(setNum, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rebrickableip")]
        public IBodyWorkflowAction<UsersSetsListResponse> UsersSetsList([WorkflowExpression] Func<string> userToken, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> setNum = null, [WorkflowExpression] Func<double> themeId = null, [WorkflowExpression] Func<double> minYear = null, [WorkflowExpression] Func<double> maxYear = null, [WorkflowExpression] Func<double> minParts = null, [WorkflowExpression] Func<double> maxParts = null, [WorkflowExpression] Func<string> ordering = null, [WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(userToken, nameof(userToken), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(setNum, nameof(setNum), required: false);
            SourceExpression.Validate(themeId, nameof(themeId), required: false);
            SourceExpression.Validate(minYear, nameof(minYear), required: false);
            SourceExpression.Validate(maxYear, nameof(maxYear), required: false);
            SourceExpression.Validate(minParts, nameof(minParts), required: false);
            SourceExpression.Validate(maxParts, nameof(maxParts), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/users/{0}/sets/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userToken, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (setNum != null)
                    callPayload.Queries["set_num"] = SourceExpressionConverter.ConvertO(setNum);
                if (themeId != null)
                    callPayload.Queries["theme_id"] = SourceExpressionConverter.ConvertO(themeId);
                if (minYear != null)
                    callPayload.Queries["min_year"] = SourceExpressionConverter.ConvertO(minYear);
                if (maxYear != null)
                    callPayload.Queries["max_year"] = SourceExpressionConverter.ConvertO(maxYear);
                if (minParts != null)
                    callPayload.Queries["min_parts"] = SourceExpressionConverter.ConvertO(minParts);
                if (maxParts != null)
                    callPayload.Queries["max_parts"] = SourceExpressionConverter.ConvertO(maxParts);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.ConvertO(ordering);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<UsersSetsListResponse>(BuildSourceInput);
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