//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shopranos
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ShopranosActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<AttributeSetDTO[]> AttributeSetsGETGetAll(Expression<Func<string>> title = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<AttributeSetDTO[]>(() =>
            {
                var apiCallPath = "/api/AttributeSets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<AttributeSetDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<AttributeDTO> AttributesGETGetAll(Expression<Func<statusInput>> status = null, Expression<Func<string>> type = null, Expression<Func<bool>> isFilterable = null, Expression<Func<bool>> displayOnProduct = null, Expression<Func<bool>> displayInList = null, Expression<Func<string>> search = null, Expression<Func<string>> id = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_isFilterable = isFilterable == null ? null : WorkflowExpression.Compile(isFilterable);
            WorkflowExpression.Validate(__workflow_isFilterable, nameof(isFilterable), required: false);
            var __workflow_displayOnProduct = displayOnProduct == null ? null : WorkflowExpression.Compile(displayOnProduct);
            WorkflowExpression.Validate(__workflow_displayOnProduct, nameof(displayOnProduct), required: false);
            var __workflow_displayInList = displayInList == null ? null : WorkflowExpression.Compile(displayInList);
            WorkflowExpression.Validate(__workflow_displayInList, nameof(displayInList), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<AttributeDTO>(() =>
            {
                var apiCallPath = "/api/Attributes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_isFilterable != null)
                    callPayload.Queries["IsFilterable"] = ExpressionConverter.Convert(__workflow_isFilterable);
                if (__workflow_displayOnProduct != null)
                    callPayload.Queries["DisplayOnProduct"] = ExpressionConverter.Convert(__workflow_displayOnProduct);
                if (__workflow_displayInList != null)
                    callPayload.Queries["DisplayInList"] = ExpressionConverter.Convert(__workflow_displayInList);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<AttributeDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<BrandDTO[]> BrandsGETGetAll(Expression<Func<statusInput>> status = null, Expression<Func<string>> search = null, Expression<Func<string>> code = null, Expression<Func<string>> id = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_code = code == null ? null : WorkflowExpression.Compile(code);
            WorkflowExpression.Validate(__workflow_code, nameof(code), required: false);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<BrandDTO[]>(() =>
            {
                var apiCallPath = "/api/Brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<BrandDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<CategoryDTO[]> CategoriesGETGetAll(Expression<Func<string>> title = null, Expression<Func<string>> id = null, Expression<Func<string>> search = null, Expression<Func<string>> code = null, Expression<Func<string>> parentId = null, Expression<Func<string>> path = null, Expression<Func<string>> parentIds = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_code = code == null ? null : WorkflowExpression.Compile(code);
            WorkflowExpression.Validate(__workflow_code, nameof(code), required: false);
            var __workflow_parentId = parentId == null ? null : WorkflowExpression.Compile(parentId);
            WorkflowExpression.Validate(__workflow_parentId, nameof(parentId), required: false);
            var __workflow_path = path == null ? null : WorkflowExpression.Compile(path);
            WorkflowExpression.Validate(__workflow_path, nameof(path), required: false);
            var __workflow_parentIds = parentIds == null ? null : WorkflowExpression.Compile(parentIds);
            WorkflowExpression.Validate(__workflow_parentIds, nameof(parentIds), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<CategoryDTO[]>(() =>
            {
                var apiCallPath = "/api/Categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_parentId != null)
                    callPayload.Queries["ParentId"] = ExpressionConverter.Convert(__workflow_parentId);
                if (__workflow_path != null)
                    callPayload.Queries["Path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_parentIds != null)
                    callPayload.Queries["ParentIds"] = ExpressionConverter.Convert(__workflow_parentIds);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<CategoryDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<ProblemDetails> FiltersPOSTBuildFilters()
        {
            var apiCallPath = "/api/Filters/clear";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProblemDetails>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<IcoTagDTO[]> IcoTagsGETGetAll(Expression<Func<string>> name = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<IcoTagDTO[]>(() =>
            {
                var apiCallPath = "/api/IcoTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<IcoTagDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<ProblemDetails> ProductVariantsGETGetAllFlat(Expression<Func<string>> price = null, Expression<Func<double>> maxPrice = null, Expression<Func<string>> size1 = null, Expression<Func<string>> size2 = null, Expression<Func<string>> size3 = null, Expression<Func<string>> insertDate = null, Expression<Func<string>> date1 = null, Expression<Func<string>> date2 = null, Expression<Func<string>> date3 = null, Expression<Func<string>> date1DateRange = null, Expression<Func<string>> date2DateRange = null, Expression<Func<string>> date3DateRange = null, Expression<Func<string>> insertDateRange = null, Expression<Func<string>> search = null, Expression<Func<double>> minPrice = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> availability = null, Expression<Func<string>> tag = null, Expression<Func<string>> sourceTag = null, Expression<Func<string>> privacyRule = null, Expression<Func<string>> rule = null, Expression<Func<string>> condition = null, Expression<Func<string>> ids = null, Expression<Func<string>> id = null, Expression<Func<string>> priceRange = null, Expression<Func<string>> brandCode = null, Expression<Func<string>> brandId = null, Expression<Func<string>> attribute = null, Expression<Func<string>> pathCategory = null, Expression<Func<string>> categoryId = null, Expression<Func<string>> additionalCategoryId = null, Expression<Func<string>> stockAvailabilityId = null, Expression<Func<string>> attributeSetId = null, Expression<Func<string>> priceCategoryId = null, Expression<Func<bool>> hasMedia = null, Expression<Func<string>> masterId = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_price = price == null ? null : WorkflowExpression.Compile(price);
            WorkflowExpression.Validate(__workflow_price, nameof(price), required: false);
            var __workflow_maxPrice = maxPrice == null ? null : WorkflowExpression.Compile(maxPrice);
            WorkflowExpression.Validate(__workflow_maxPrice, nameof(maxPrice), required: false);
            var __workflow_size1 = size1 == null ? null : WorkflowExpression.Compile(size1);
            WorkflowExpression.Validate(__workflow_size1, nameof(size1), required: false);
            var __workflow_size2 = size2 == null ? null : WorkflowExpression.Compile(size2);
            WorkflowExpression.Validate(__workflow_size2, nameof(size2), required: false);
            var __workflow_size3 = size3 == null ? null : WorkflowExpression.Compile(size3);
            WorkflowExpression.Validate(__workflow_size3, nameof(size3), required: false);
            var __workflow_insertDate = insertDate == null ? null : WorkflowExpression.Compile(insertDate);
            WorkflowExpression.Validate(__workflow_insertDate, nameof(insertDate), required: false);
            var __workflow_date1 = date1 == null ? null : WorkflowExpression.Compile(date1);
            WorkflowExpression.Validate(__workflow_date1, nameof(date1), required: false);
            var __workflow_date2 = date2 == null ? null : WorkflowExpression.Compile(date2);
            WorkflowExpression.Validate(__workflow_date2, nameof(date2), required: false);
            var __workflow_date3 = date3 == null ? null : WorkflowExpression.Compile(date3);
            WorkflowExpression.Validate(__workflow_date3, nameof(date3), required: false);
            var __workflow_date1DateRange = date1DateRange == null ? null : WorkflowExpression.Compile(date1DateRange);
            WorkflowExpression.Validate(__workflow_date1DateRange, nameof(date1DateRange), required: false);
            var __workflow_date2DateRange = date2DateRange == null ? null : WorkflowExpression.Compile(date2DateRange);
            WorkflowExpression.Validate(__workflow_date2DateRange, nameof(date2DateRange), required: false);
            var __workflow_date3DateRange = date3DateRange == null ? null : WorkflowExpression.Compile(date3DateRange);
            WorkflowExpression.Validate(__workflow_date3DateRange, nameof(date3DateRange), required: false);
            var __workflow_insertDateRange = insertDateRange == null ? null : WorkflowExpression.Compile(insertDateRange);
            WorkflowExpression.Validate(__workflow_insertDateRange, nameof(insertDateRange), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_minPrice = minPrice == null ? null : WorkflowExpression.Compile(minPrice);
            WorkflowExpression.Validate(__workflow_minPrice, nameof(minPrice), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_availability = availability == null ? null : WorkflowExpression.Compile(availability);
            WorkflowExpression.Validate(__workflow_availability, nameof(availability), required: false);
            var __workflow_tag = tag == null ? null : WorkflowExpression.Compile(tag);
            WorkflowExpression.Validate(__workflow_tag, nameof(tag), required: false);
            var __workflow_sourceTag = sourceTag == null ? null : WorkflowExpression.Compile(sourceTag);
            WorkflowExpression.Validate(__workflow_sourceTag, nameof(sourceTag), required: false);
            var __workflow_privacyRule = privacyRule == null ? null : WorkflowExpression.Compile(privacyRule);
            WorkflowExpression.Validate(__workflow_privacyRule, nameof(privacyRule), required: false);
            var __workflow_rule = rule == null ? null : WorkflowExpression.Compile(rule);
            WorkflowExpression.Validate(__workflow_rule, nameof(rule), required: false);
            var __workflow_condition = condition == null ? null : WorkflowExpression.Compile(condition);
            WorkflowExpression.Validate(__workflow_condition, nameof(condition), required: false);
            var __workflow_ids = ids == null ? null : WorkflowExpression.Compile(ids);
            WorkflowExpression.Validate(__workflow_ids, nameof(ids), required: false);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_priceRange = priceRange == null ? null : WorkflowExpression.Compile(priceRange);
            WorkflowExpression.Validate(__workflow_priceRange, nameof(priceRange), required: false);
            var __workflow_brandCode = brandCode == null ? null : WorkflowExpression.Compile(brandCode);
            WorkflowExpression.Validate(__workflow_brandCode, nameof(brandCode), required: false);
            var __workflow_brandId = brandId == null ? null : WorkflowExpression.Compile(brandId);
            WorkflowExpression.Validate(__workflow_brandId, nameof(brandId), required: false);
            var __workflow_attribute = attribute == null ? null : WorkflowExpression.Compile(attribute);
            WorkflowExpression.Validate(__workflow_attribute, nameof(attribute), required: false);
            var __workflow_pathCategory = pathCategory == null ? null : WorkflowExpression.Compile(pathCategory);
            WorkflowExpression.Validate(__workflow_pathCategory, nameof(pathCategory), required: false);
            var __workflow_categoryId = categoryId == null ? null : WorkflowExpression.Compile(categoryId);
            WorkflowExpression.Validate(__workflow_categoryId, nameof(categoryId), required: false);
            var __workflow_additionalCategoryId = additionalCategoryId == null ? null : WorkflowExpression.Compile(additionalCategoryId);
            WorkflowExpression.Validate(__workflow_additionalCategoryId, nameof(additionalCategoryId), required: false);
            var __workflow_stockAvailabilityId = stockAvailabilityId == null ? null : WorkflowExpression.Compile(stockAvailabilityId);
            WorkflowExpression.Validate(__workflow_stockAvailabilityId, nameof(stockAvailabilityId), required: false);
            var __workflow_attributeSetId = attributeSetId == null ? null : WorkflowExpression.Compile(attributeSetId);
            WorkflowExpression.Validate(__workflow_attributeSetId, nameof(attributeSetId), required: false);
            var __workflow_priceCategoryId = priceCategoryId == null ? null : WorkflowExpression.Compile(priceCategoryId);
            WorkflowExpression.Validate(__workflow_priceCategoryId, nameof(priceCategoryId), required: false);
            var __workflow_hasMedia = hasMedia == null ? null : WorkflowExpression.Compile(hasMedia);
            WorkflowExpression.Validate(__workflow_hasMedia, nameof(hasMedia), required: false);
            var __workflow_masterId = masterId == null ? null : WorkflowExpression.Compile(masterId);
            WorkflowExpression.Validate(__workflow_masterId, nameof(masterId), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = "/api/ProductVariants/flat";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_price != null)
                    callPayload.Queries["Price"] = ExpressionConverter.Convert(__workflow_price);
                if (__workflow_maxPrice != null)
                    callPayload.Queries["MaxPrice"] = ExpressionConverter.Convert(__workflow_maxPrice);
                if (__workflow_size1 != null)
                    callPayload.Queries["Size1"] = ExpressionConverter.Convert(__workflow_size1);
                if (__workflow_size2 != null)
                    callPayload.Queries["Size2"] = ExpressionConverter.Convert(__workflow_size2);
                if (__workflow_size3 != null)
                    callPayload.Queries["Size3"] = ExpressionConverter.Convert(__workflow_size3);
                if (__workflow_insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(__workflow_insertDate);
                if (__workflow_date1 != null)
                    callPayload.Queries["Date1"] = ExpressionConverter.Convert(__workflow_date1);
                if (__workflow_date2 != null)
                    callPayload.Queries["Date2"] = ExpressionConverter.Convert(__workflow_date2);
                if (__workflow_date3 != null)
                    callPayload.Queries["Date3"] = ExpressionConverter.Convert(__workflow_date3);
                if (__workflow_date1DateRange != null)
                    callPayload.Queries["Date1DateRange"] = ExpressionConverter.Convert(__workflow_date1DateRange);
                if (__workflow_date2DateRange != null)
                    callPayload.Queries["Date2DateRange"] = ExpressionConverter.Convert(__workflow_date2DateRange);
                if (__workflow_date3DateRange != null)
                    callPayload.Queries["Date3DateRange"] = ExpressionConverter.Convert(__workflow_date3DateRange);
                if (__workflow_insertDateRange != null)
                    callPayload.Queries["InsertDateRange"] = ExpressionConverter.Convert(__workflow_insertDateRange);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_minPrice != null)
                    callPayload.Queries["MinPrice"] = ExpressionConverter.Convert(__workflow_minPrice);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_availability != null)
                    callPayload.Queries["Availability"] = ExpressionConverter.Convert(__workflow_availability);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_sourceTag != null)
                    callPayload.Queries["SourceTag"] = ExpressionConverter.Convert(__workflow_sourceTag);
                if (__workflow_privacyRule != null)
                    callPayload.Queries["PrivacyRule"] = ExpressionConverter.Convert(__workflow_privacyRule);
                if (__workflow_rule != null)
                    callPayload.Queries["Rule"] = ExpressionConverter.Convert(__workflow_rule);
                if (__workflow_condition != null)
                    callPayload.Queries["Condition"] = ExpressionConverter.Convert(__workflow_condition);
                if (__workflow_ids != null)
                    callPayload.Queries["Ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_priceRange != null)
                    callPayload.Queries["PriceRange"] = ExpressionConverter.Convert(__workflow_priceRange);
                if (__workflow_brandCode != null)
                    callPayload.Queries["BrandCode"] = ExpressionConverter.Convert(__workflow_brandCode);
                if (__workflow_brandId != null)
                    callPayload.Queries["BrandId"] = ExpressionConverter.Convert(__workflow_brandId);
                if (__workflow_attribute != null)
                    callPayload.Queries["Attribute"] = ExpressionConverter.Convert(__workflow_attribute);
                if (__workflow_pathCategory != null)
                    callPayload.Queries["PathCategory"] = ExpressionConverter.Convert(__workflow_pathCategory);
                if (__workflow_categoryId != null)
                    callPayload.Queries["CategoryId"] = ExpressionConverter.Convert(__workflow_categoryId);
                if (__workflow_additionalCategoryId != null)
                    callPayload.Queries["AdditionalCategoryId"] = ExpressionConverter.Convert(__workflow_additionalCategoryId);
                if (__workflow_stockAvailabilityId != null)
                    callPayload.Queries["StockAvailabilityId"] = ExpressionConverter.Convert(__workflow_stockAvailabilityId);
                if (__workflow_attributeSetId != null)
                    callPayload.Queries["AttributeSetId"] = ExpressionConverter.Convert(__workflow_attributeSetId);
                if (__workflow_priceCategoryId != null)
                    callPayload.Queries["PriceCategoryId"] = ExpressionConverter.Convert(__workflow_priceCategoryId);
                if (__workflow_hasMedia != null)
                    callPayload.Queries["HasMedia"] = ExpressionConverter.Convert(__workflow_hasMedia);
                if (__workflow_masterId != null)
                    callPayload.Queries["MasterId"] = ExpressionConverter.Convert(__workflow_masterId);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<RelatedProductVariantDTO> RelatedProductsGETGetRelated(Expression<Func<string>> productId, Expression<Func<string>> variantId)
        {
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: true);
            var __workflow_variantId = variantId == null ? null : WorkflowExpression.Compile(variantId);
            WorkflowExpression.Validate(__workflow_variantId, nameof(variantId), required: true);
            return new DeferredBodyAction<RelatedProductVariantDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/RelatedProducts/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_productId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_variantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RelatedProductVariantDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<StockAvailabilityDTO[]> StockAvailabilityGETGetAll(Expression<Func<string>> title = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<StockAvailabilityDTO[]>(() =>
            {
                var apiCallPath = "/api/StockAvailability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<StockAvailabilityDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<UnitDTO[]> UnitsGETGetAll(Expression<Func<string>> name = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<UnitDTO[]>(() =>
            {
                var apiCallPath = "/api/Units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<UnitDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<ProblemDetails> CartDELETERemoveFromCart(Expression<Func<string>> token, Expression<Func<string>> productVariantId)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_productVariantId = productVariantId == null ? null : WorkflowExpression.Compile(productVariantId);
            WorkflowExpression.Validate(__workflow_productVariantId, nameof(productVariantId), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Cart/{0}/Items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_token, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_productVariantId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<AssortmentValueDTO[]> AssortmentValueGETGetAll(Expression<Func<string>> customerid, Expression<Func<statusInput>> status = null, Expression<Func<sourceInput>> source = null, Expression<Func<string>> type = null, Expression<Func<string>> category = null, Expression<Func<string>> id = null, Expression<Func<string>> productId = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_customerid = customerid == null ? null : WorkflowExpression.Compile(customerid);
            WorkflowExpression.Validate(__workflow_customerid, nameof(customerid), required: true);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_source = source == null ? null : WorkflowExpression.Compile(source);
            WorkflowExpression.Validate(__workflow_source, nameof(source), required: false);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            var __workflow_category = category == null ? null : WorkflowExpression.Compile(category);
            WorkflowExpression.Validate(__workflow_category, nameof(category), required: false);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_productId = productId == null ? null : WorkflowExpression.Compile(productId);
            WorkflowExpression.Validate(__workflow_productId, nameof(productId), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<AssortmentValueDTO[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/assortment/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(__workflow_customerid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_category != null)
                    callPayload.Queries["Category"] = ExpressionConverter.Convert(__workflow_category);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_productId != null)
                    callPayload.Queries["ProductId"] = ExpressionConverter.Convert(__workflow_productId);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<AssortmentValueDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<CustomerDTO[]> CustomersGETGetAll(Expression<Func<statusInput>> status = null, Expression<Func<string>> search = null, Expression<Func<string>> name = null, Expression<Func<string>> salesmanId = null, Expression<Func<string>> id = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_name = name == null ? null : WorkflowExpression.Compile(name);
            WorkflowExpression.Validate(__workflow_name, nameof(name), required: false);
            var __workflow_salesmanId = salesmanId == null ? null : WorkflowExpression.Compile(salesmanId);
            WorkflowExpression.Validate(__workflow_salesmanId, nameof(salesmanId), required: false);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<CustomerDTO[]>(() =>
            {
                var apiCallPath = "/api/Customers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_salesmanId != null)
                    callPayload.Queries["SalesmanId"] = ExpressionConverter.Convert(__workflow_salesmanId);
                if (__workflow_id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<CustomerDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<InventoryLevelDTO[]> InventoryLevelsGETGetByVariantId(Expression<Func<string>> variantId)
        {
            var __workflow_variantId = variantId == null ? null : WorkflowExpression.Compile(variantId);
            WorkflowExpression.Validate(__workflow_variantId, nameof(variantId), required: true);
            return new DeferredBodyAction<InventoryLevelDTO[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/InventoryLevels/variant/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_variantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InventoryLevelDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<OrderDTO[]> OrderGETGetAll(Expression<Func<string>> search = null, Expression<Func<string>> code = null, Expression<Func<string>> customerId = null, Expression<Func<string>> orderStatus = null, Expression<Func<string>> status = null, Expression<Func<string>> tag = null, Expression<Func<string>> customerCode = null, Expression<Func<string>> customerTin = null, Expression<Func<string>> insertDate = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sort = null)
        {
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_code = code == null ? null : WorkflowExpression.Compile(code);
            WorkflowExpression.Validate(__workflow_code, nameof(code), required: false);
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: false);
            var __workflow_orderStatus = orderStatus == null ? null : WorkflowExpression.Compile(orderStatus);
            WorkflowExpression.Validate(__workflow_orderStatus, nameof(orderStatus), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_tag = tag == null ? null : WorkflowExpression.Compile(tag);
            WorkflowExpression.Validate(__workflow_tag, nameof(tag), required: false);
            var __workflow_customerCode = customerCode == null ? null : WorkflowExpression.Compile(customerCode);
            WorkflowExpression.Validate(__workflow_customerCode, nameof(customerCode), required: false);
            var __workflow_customerTin = customerTin == null ? null : WorkflowExpression.Compile(customerTin);
            WorkflowExpression.Validate(__workflow_customerTin, nameof(customerTin), required: false);
            var __workflow_insertDate = insertDate == null ? null : WorkflowExpression.Compile(insertDate);
            WorkflowExpression.Validate(__workflow_insertDate, nameof(insertDate), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_pageSize = pageSize == null ? null : WorkflowExpression.Compile(pageSize);
            WorkflowExpression.Validate(__workflow_pageSize, nameof(pageSize), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
            return new DeferredBodyAction<OrderDTO[]>(() =>
            {
                var apiCallPath = "/api/Order";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_customerId != null)
                    callPayload.Queries["CustomerId"] = ExpressionConverter.Convert(__workflow_customerId);
                if (__workflow_orderStatus != null)
                    callPayload.Queries["OrderStatus"] = ExpressionConverter.Convert(__workflow_orderStatus);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_customerCode != null)
                    callPayload.Queries["CustomerCode"] = ExpressionConverter.Convert(__workflow_customerCode);
                if (__workflow_customerTin != null)
                    callPayload.Queries["CustomerTin"] = ExpressionConverter.Convert(__workflow_customerTin);
                if (__workflow_insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(__workflow_insertDate);
                if (__workflow_page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<OrderDTO[]>(callPayload);
            });
        }
    }

    public class ShopranosTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProductCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/product/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger ProductUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/product/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger ProductDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/product/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CategoryCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/category/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CategoryUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/category/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CategoryDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/category/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BrandCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/brand/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BrandUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/brand/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger BrandDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/brand/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger UnitCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/unit/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger UnitUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/unit/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger UnitDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/unit/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger AttributeCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/attribute/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger AttributeUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/attribute/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger AttributeDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/attribute/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger AttributeSetCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/attributeset/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger AttributeSetUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/attributeset/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger AttributeSetDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/attributeset/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CheckoutCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/checkout/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CheckoutCompletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/checkout/completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CustomerCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/customer/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CustomerUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/customer/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CustomerDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/customer/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger OrderCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/order/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger OrderUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/order/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger OrderDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/order/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger InventoryLevelCreatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/inventorylevel/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger InventoryLevelUpdatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/inventorylevel/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger InventoryLevelDeletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/inventorylevel/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger PaymentInitiatedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/payment/initiated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger PaymentCompletedTrigger(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhook/register/payment/completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class AttributeSetDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("groups")]
        public AttributeSetGroupDTO[] Groups { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }
    }

    public class AttributeSetGroupDTO
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("items")]
        public AttributeSetItemDTO[] Items { get; set; }
    }

    public class AttributeSetItemDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class AttributeDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("usedAsFilter")]
        public bool UsedAsFilter { get; set; }

        [JsonProperty("displayOnProduct")]
        public bool DisplayOnProduct { get; set; }

        [JsonProperty("displayOnList")]
        public bool DisplayOnList { get; set; }

        [JsonProperty("displayOnCompare")]
        public bool DisplayOnCompare { get; set; }

        [JsonProperty("type")]
        public AttributeDTOTypeType Type { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("status")]
        public AttributeDTOStatusType Status { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("items")]
        public AttributeItemDTO[] Items { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AttributeDTOTypeType
    {
        Text,
        Items,
        Color,
        Size
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AttributeDTOStatusType
    {
        Draft,
        Active,
        Archived,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class AttributeItemDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("colorCode")]
        public string ColorCode { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        Active,
        Inactive,
        StopOrder,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class BrandDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("status")]
        public BrandDTOStatusType Status { get; set; }

        [JsonProperty("metaKeywords")]
        public string[] MetaKeywords { get; set; }

        [JsonProperty("mediaItem")]
        public JToken MediaItem { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BrandDTOStatusType
    {
        Draft,
        Active,
        Archived,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CategoryDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("displayInMenu")]
        public bool DisplayInMenu { get; set; }

        [JsonProperty("displayAsList")]
        public bool DisplayAsList { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("mediaItem")]
        public JToken MediaItem { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }

        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        [JsonProperty("metaKeywords")]
        public string[] MetaKeywords { get; set; }

        [JsonProperty("treeIds")]
        public string[] TreeIds { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("status")]
        public CategoryDTOStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategoryDTOStatusType
    {
        Draft,
        Active,
        Archived,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class ProblemDetails
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("instance")]
        public string Instance { get; set; }
    }

    public class IcoTagDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("textColor")]
        public string TextColor { get; set; }

        [JsonProperty("productIds")]
        public string[] ProductIds { get; set; }

        [JsonProperty("ruleEnabled")]
        public bool RuleEnabled { get; set; }

        [JsonProperty("dateFrom")]
        public string DateFrom { get; set; }

        [JsonProperty("dateTo")]
        public string DateTo { get; set; }

        [JsonProperty("mode")]
        public IcoTagDTOModeType Mode { get; set; }

        [JsonProperty("status")]
        public IcoTagDTOStatusType Status { get; set; }

        [JsonProperty("rule")]
        public JToken Rule { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IcoTagDTOModeType
    {
        Automatic,
        Manual,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IcoTagDTOStatusType
    {
        Draft,
        Active,
        Archived,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class RelatedProductVariantDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("dimension1ItemIds")]
        public string[] Dimension1ItemIds { get; set; }

        [JsonProperty("dimension2ItemIds")]
        public string[] Dimension2ItemIds { get; set; }

        [JsonProperty("dimension3ItemIds")]
        public string[] Dimension3ItemIds { get; set; }
    }

    public class StockAvailabilityDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("lines")]
        public StockAvailabilityLineDTO[] Lines { get; set; }
    }

    public class StockAvailabilityLineDTO
    {
        [JsonProperty("mediaItem")]
        public JToken MediaItem { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }
    }

    public class UnitDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }
    }

    public class AssortmentValueDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("status")]
        public AssortmentValueDTOStatusType Status { get; set; }

        [JsonProperty("source")]
        public AssortmentValueDTOSourceType Source { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssortmentValueDTOStatusType
    {
        Inactive,
        Active
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssortmentValueDTOSourceType
    {
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "orders")]
        Orders
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sourceInput
    {
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "orders")]
        Orders
    }

    public class CustomerDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tin")]
        public string Tin { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("priceCategoryId")]
        public string PriceCategoryId { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("sourceTags")]
        public string[] SourceTags { get; set; }

        [JsonProperty("address")]
        public JToken Address { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("status")]
        public CustomerDTOStatusType Status { get; set; }

        [JsonProperty("branches")]
        public CustomerBranchDTO[] Branches { get; set; }

        [JsonProperty("additionalFeatures")]
        public JToken AdditionalFeatures { get; set; }

        [JsonProperty("customFields")]
        public CustomerCustomFieldDTO[] CustomFields { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("salesmanId")]
        public string SalesmanId { get; set; }

        [JsonProperty("taxOffice")]
        public string TaxOffice { get; set; }

        [JsonProperty("contactLanguage")]
        public string ContactLanguage { get; set; }

        [JsonProperty("vatType")]
        public CustomerDTOVatTypeType VatType { get; set; }

        [JsonProperty("shopType")]
        public CustomerDTOShopTypeType ShopType { get; set; }

        [JsonProperty("shippingAddresses")]
        public CustomerShippingAddressDTO[] ShippingAddresses { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerDTOStatusType
    {
        Active,
        Inactive,
        StopOrder,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CustomerBranchDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address")]
        public JToken Address { get; set; }

        [JsonProperty("status")]
        public CustomerBranchDTOStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerBranchDTOStatusType
    {
        Active,
        Inactive,
        StopOrder,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CustomerCustomFieldDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("translation")]
        public JToken Translation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerDTOVatTypeType
    {
        Zero,
        Regular,
        Discounted,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CustomerDTOShopTypeType
    {
        B2B,
        B2C,
        Both,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    public class CustomerShippingAddressDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public JToken Address { get; set; }
    }

    public class InventoryLevelDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("productVariantId")]
        public string ProductVariantId { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("expectedInventoryLines")]
        public ExpectedInventoryLineDTO[] ExpectedInventoryLines { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }

    public class ExpectedInventoryLineDTO
    {
        [JsonProperty("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonProperty("expectedQuantity")]
        public double ExpectedQuantity { get; set; }
    }

    public class OrderDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("checkoutToken")]
        public string CheckoutToken { get; set; }

        [JsonProperty("cartToken")]
        public string CartToken { get; set; }

        [JsonProperty("status")]
        public OrderDTOStatusType Status { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerBranchId")]
        public string CustomerBranchId { get; set; }

        [JsonProperty("customerBranchSourceId")]
        public string CustomerBranchSourceId { get; set; }

        [JsonProperty("customerTin")]
        public string CustomerTin { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("customerCode")]
        public string CustomerCode { get; set; }

        [JsonProperty("customerSourceId")]
        public string CustomerSourceId { get; set; }

        [JsonProperty("customerBranchName")]
        public string CustomerBranchName { get; set; }

        [JsonProperty("currency")]
        public OrderDTOCurrencyType Currency { get; set; }

        [JsonProperty("cancelledAt")]
        public string CancelledAt { get; set; }

        [JsonProperty("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonProperty("cancellationReason")]
        public string CancellationReason { get; set; }

        [JsonProperty("closedAt")]
        public string ClosedAt { get; set; }

        [JsonProperty("referenceCode")]
        public string ReferenceCode { get; set; }

        [JsonProperty("discountRate")]
        public double DiscountRate { get; set; }

        [JsonProperty("discountValue")]
        public double DiscountValue { get; set; }

        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("vatAmount")]
        public double VatAmount { get; set; }

        [JsonProperty("expenseAmount")]
        public double ExpenseAmount { get; set; }

        [JsonProperty("financialStatus")]
        public OrderDTOFinancialStatusType FinancialStatus { get; set; }

        [JsonProperty("fulfillmentStatus")]
        public OrderDTOFulfillmentStatusType FulfillmentStatus { get; set; }

        [JsonProperty("billingAddress")]
        public JToken BillingAddress { get; set; }

        [JsonProperty("shippingAddress")]
        public JToken ShippingAddress { get; set; }

        [JsonProperty("requiresCalculation")]
        public bool RequiresCalculation { get; set; }

        [JsonProperty("lines")]
        public OrderLineDTO[] Lines { get; set; }

        [JsonProperty("vatAnalysis")]
        public VatAnalysisDTO[] VatAnalysis { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceTags")]
        public string[] SourceTags { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("insertDate")]
        public string InsertDate { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("invoiceUrl")]
        public string InvoiceUrl { get; set; }

        [JsonProperty("notify")]
        public string Notify { get; set; }

        [JsonProperty("notified")]
        public string[] Notified { get; set; }

        [JsonProperty("customFields")]
        public OrderCustomFieldDTO[] CustomFields { get; set; }

        [JsonProperty("shippingLine")]
        public JToken ShippingLine { get; set; }

        [JsonProperty("giftLines")]
        public GiftLineDTO[] GiftLines { get; set; }

        [JsonProperty("expenseLines")]
        public ExpenseLineDTO[] ExpenseLines { get; set; }

        [JsonProperty("payment")]
        public JToken Payment { get; set; }

        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderDTOStatusType
    {
        Draft,
        Placed,
        Cancelled,
        Processing,
        ToBeShipped,
        Shipped,
        PartialDelivery,
        FailedToDeliver,
        Delivered,
        Rejected,
        Completed,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderDTOCurrencyType
    {
        [EnumMember(Value = "aed")]
        Aed,
        [EnumMember(Value = "afn")]
        Afn,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "amd")]
        Amd,
        [EnumMember(Value = "ang")]
        Ang,
        [EnumMember(Value = "aoa")]
        Aoa,
        [EnumMember(Value = "ars")]
        Ars,
        [EnumMember(Value = "aud")]
        Aud,
        [EnumMember(Value = "awg")]
        Awg,
        [EnumMember(Value = "azn")]
        Azn,
        [EnumMember(Value = "bam")]
        Bam,
        [EnumMember(Value = "bbd")]
        Bbd,
        [EnumMember(Value = "bdt")]
        Bdt,
        [EnumMember(Value = "bgn")]
        Bgn,
        [EnumMember(Value = "bhd")]
        Bhd,
        [EnumMember(Value = "bif")]
        Bif,
        [EnumMember(Value = "bmd")]
        Bmd,
        [EnumMember(Value = "bnd")]
        Bnd,
        [EnumMember(Value = "bob")]
        Bob,
        [EnumMember(Value = "bov")]
        Bov,
        [EnumMember(Value = "brl")]
        Brl,
        [EnumMember(Value = "bsd")]
        Bsd,
        [EnumMember(Value = "btn")]
        Btn,
        [EnumMember(Value = "bwp")]
        Bwp,
        [EnumMember(Value = "byn")]
        Byn,
        [EnumMember(Value = "bzd")]
        Bzd,
        [EnumMember(Value = "cad")]
        Cad,
        [EnumMember(Value = "cdf")]
        Cdf,
        [EnumMember(Value = "che")]
        Che,
        [EnumMember(Value = "chf")]
        Chf,
        [EnumMember(Value = "chw")]
        Chw,
        [EnumMember(Value = "clf")]
        Clf,
        [EnumMember(Value = "clp")]
        Clp,
        [EnumMember(Value = "cny")]
        Cny,
        [EnumMember(Value = "cop")]
        Cop,
        [EnumMember(Value = "cou")]
        Cou,
        [EnumMember(Value = "crc")]
        Crc,
        [EnumMember(Value = "cuc")]
        Cuc,
        [EnumMember(Value = "cup")]
        Cup,
        [EnumMember(Value = "cve")]
        Cve,
        [EnumMember(Value = "czk")]
        Czk,
        [EnumMember(Value = "djf")]
        Djf,
        [EnumMember(Value = "dkk")]
        Dkk,
        [EnumMember(Value = "dop")]
        Dop,
        [EnumMember(Value = "dzd")]
        Dzd,
        [EnumMember(Value = "egp")]
        Egp,
        [EnumMember(Value = "ern")]
        Ern,
        [EnumMember(Value = "etb")]
        Etb,
        [EnumMember(Value = "eur")]
        Eur,
        [EnumMember(Value = "fjd")]
        Fjd,
        [EnumMember(Value = "fkp")]
        Fkp,
        [EnumMember(Value = "gbp")]
        Gbp,
        [EnumMember(Value = "gel")]
        Gel,
        [EnumMember(Value = "ghs")]
        Ghs,
        [EnumMember(Value = "gip")]
        Gip,
        [EnumMember(Value = "gmd")]
        Gmd,
        [EnumMember(Value = "gnf")]
        Gnf,
        [EnumMember(Value = "gtq")]
        Gtq,
        [EnumMember(Value = "gyd")]
        Gyd,
        [EnumMember(Value = "hkd")]
        Hkd,
        [EnumMember(Value = "hnl")]
        Hnl,
        [EnumMember(Value = "hrk")]
        Hrk,
        [EnumMember(Value = "htg")]
        Htg,
        [EnumMember(Value = "huf")]
        Huf,
        [EnumMember(Value = "idr")]
        Idr,
        [EnumMember(Value = "ils")]
        Ils,
        [EnumMember(Value = "inr")]
        Inr,
        [EnumMember(Value = "iqd")]
        Iqd,
        [EnumMember(Value = "irr")]
        Irr,
        [EnumMember(Value = "isk")]
        Isk,
        [EnumMember(Value = "jmd")]
        Jmd,
        [EnumMember(Value = "jod")]
        Jod,
        [EnumMember(Value = "jpy")]
        Jpy,
        [EnumMember(Value = "kes")]
        Kes,
        [EnumMember(Value = "kgs")]
        Kgs,
        [EnumMember(Value = "khr")]
        Khr,
        [EnumMember(Value = "kmf")]
        Kmf,
        [EnumMember(Value = "kpw")]
        Kpw,
        [EnumMember(Value = "krw")]
        Krw,
        [EnumMember(Value = "kwd")]
        Kwd,
        [EnumMember(Value = "kyd")]
        Kyd,
        [EnumMember(Value = "kzt")]
        Kzt,
        [EnumMember(Value = "lak")]
        Lak,
        [EnumMember(Value = "lbp")]
        Lbp,
        [EnumMember(Value = "lkr")]
        Lkr,
        [EnumMember(Value = "lrd")]
        Lrd,
        [EnumMember(Value = "lsl")]
        Lsl,
        [EnumMember(Value = "lyd")]
        Lyd,
        [EnumMember(Value = "mad")]
        Mad,
        [EnumMember(Value = "mdl")]
        Mdl,
        [EnumMember(Value = "mga")]
        Mga,
        [EnumMember(Value = "mkd")]
        Mkd,
        [EnumMember(Value = "mmk")]
        Mmk,
        [EnumMember(Value = "mnt")]
        Mnt,
        [EnumMember(Value = "mop")]
        Mop,
        [EnumMember(Value = "mru")]
        Mru,
        [EnumMember(Value = "mur")]
        Mur,
        [EnumMember(Value = "mvr")]
        Mvr,
        [EnumMember(Value = "mwk")]
        Mwk,
        [EnumMember(Value = "mxn")]
        Mxn,
        [EnumMember(Value = "mxv")]
        Mxv,
        [EnumMember(Value = "myr")]
        Myr,
        [EnumMember(Value = "mzn")]
        Mzn,
        [EnumMember(Value = "nad")]
        Nad,
        [EnumMember(Value = "ngn")]
        Ngn,
        [EnumMember(Value = "nio")]
        Nio,
        [EnumMember(Value = "nok")]
        Nok,
        [EnumMember(Value = "npr")]
        Npr,
        [EnumMember(Value = "nzd")]
        Nzd,
        [EnumMember(Value = "omr")]
        Omr,
        [EnumMember(Value = "pab")]
        Pab,
        [EnumMember(Value = "pen")]
        Pen,
        [EnumMember(Value = "pgk")]
        Pgk,
        [EnumMember(Value = "php")]
        Php,
        [EnumMember(Value = "pkr")]
        Pkr,
        [EnumMember(Value = "pln")]
        Pln,
        [EnumMember(Value = "pyg")]
        Pyg,
        [EnumMember(Value = "qar")]
        Qar,
        [EnumMember(Value = "ron")]
        Ron,
        [EnumMember(Value = "rsd")]
        Rsd,
        [EnumMember(Value = "rub")]
        Rub,
        [EnumMember(Value = "rwf")]
        Rwf,
        [EnumMember(Value = "sar")]
        Sar,
        [EnumMember(Value = "sbd")]
        Sbd,
        [EnumMember(Value = "scr")]
        Scr,
        [EnumMember(Value = "sdg")]
        Sdg,
        [EnumMember(Value = "sek")]
        Sek,
        [EnumMember(Value = "sgd")]
        Sgd,
        [EnumMember(Value = "shp")]
        Shp,
        [EnumMember(Value = "sll")]
        Sll,
        [EnumMember(Value = "sos")]
        Sos,
        [EnumMember(Value = "srd")]
        Srd,
        [EnumMember(Value = "ssp")]
        Ssp,
        [EnumMember(Value = "stn")]
        Stn,
        [EnumMember(Value = "svc")]
        Svc,
        [EnumMember(Value = "syp")]
        Syp,
        [EnumMember(Value = "szl")]
        Szl,
        [EnumMember(Value = "thb")]
        Thb,
        [EnumMember(Value = "tjs")]
        Tjs,
        [EnumMember(Value = "tmt")]
        Tmt,
        [EnumMember(Value = "tnd")]
        Tnd,
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "try")]
        Try,
        [EnumMember(Value = "ttd")]
        Ttd,
        [EnumMember(Value = "twd")]
        Twd,
        [EnumMember(Value = "tzs")]
        Tzs,
        [EnumMember(Value = "uah")]
        Uah,
        [EnumMember(Value = "ugx")]
        Ugx,
        [EnumMember(Value = "usd")]
        Usd,
        [EnumMember(Value = "usn")]
        Usn,
        [EnumMember(Value = "uyi")]
        Uyi,
        [EnumMember(Value = "uyu")]
        Uyu,
        [EnumMember(Value = "uyw")]
        Uyw,
        [EnumMember(Value = "uzs")]
        Uzs,
        [EnumMember(Value = "ves")]
        Ves,
        [EnumMember(Value = "vnd")]
        Vnd,
        [EnumMember(Value = "vuv")]
        Vuv,
        [EnumMember(Value = "wst")]
        Wst,
        [EnumMember(Value = "xaf")]
        Xaf,
        [EnumMember(Value = "xag")]
        Xag,
        [EnumMember(Value = "xau")]
        Xau,
        [EnumMember(Value = "xba")]
        Xba,
        [EnumMember(Value = "xbb")]
        Xbb,
        [EnumMember(Value = "xbc")]
        Xbc,
        [EnumMember(Value = "xbd")]
        Xbd,
        [EnumMember(Value = "xcd")]
        Xcd,
        [EnumMember(Value = "xdr")]
        Xdr,
        [EnumMember(Value = "xof")]
        Xof,
        [EnumMember(Value = "xpd")]
        Xpd,
        [EnumMember(Value = "xpf")]
        Xpf,
        [EnumMember(Value = "xpt")]
        Xpt,
        [EnumMember(Value = "xsu")]
        Xsu,
        [EnumMember(Value = "xts")]
        Xts,
        [EnumMember(Value = "xua")]
        Xua,
        [EnumMember(Value = "xxx")]
        Xxx,
        [EnumMember(Value = "yer")]
        Yer,
        [EnumMember(Value = "zar")]
        Zar,
        [EnumMember(Value = "zmw")]
        Zmw,
        [EnumMember(Value = "zwl")]
        Zwl,
        [EnumMember(Value = "ignore")]
        Ignore
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderDTOFinancialStatusType
    {
        Pending,
        Authorized,
        PartiallyPaid,
        PartiallyRefunded,
        Refunded,
        Voided
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderDTOFulfillmentStatusType
    {
        Fulfilled,
        Null,
        Partial,
        Restocked
    }

    public class OrderLineDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("productVariantId")]
        public string ProductVariantId { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("unitId")]
        public string UnitId { get; set; }

        [JsonProperty("salesUnitId")]
        public string SalesUnitId { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unitQuantity")]
        public double UnitQuantity { get; set; }

        [JsonProperty("netValue")]
        public double NetValue { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("expenseValue")]
        public double ExpenseValue { get; set; }

        [JsonProperty("priceValue1")]
        public double PriceValue1 { get; set; }

        [JsonProperty("priceValue2")]
        public double PriceValue2 { get; set; }

        [JsonProperty("priceValue3")]
        public double PriceValue3 { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("lineValue")]
        public double LineValue { get; set; }

        [JsonProperty("discountValue")]
        public double DiscountValue { get; set; }

        [JsonProperty("discountRate")]
        public double DiscountRate { get; set; }

        [JsonProperty("vatValue")]
        public double VatValue { get; set; }

        [JsonProperty("vatRate")]
        public double VatRate { get; set; }

        [JsonProperty("vatCode")]
        public string VatCode { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("dimension1Caption")]
        public string Dimension1Caption { get; set; }

        [JsonProperty("dimension2Caption")]
        public string Dimension2Caption { get; set; }

        [JsonProperty("dimension3Caption")]
        public string Dimension3Caption { get; set; }

        [JsonProperty("dimension1Value")]
        public string Dimension1Value { get; set; }

        [JsonProperty("dimension2Value")]
        public string Dimension2Value { get; set; }

        [JsonProperty("dimension3Value")]
        public string Dimension3Value { get; set; }
    }

    public class VatAnalysisDTO
    {
        [JsonProperty("vatRate")]
        public double VatRate { get; set; }

        [JsonProperty("vatAmount")]
        public double VatAmount { get; set; }

        [JsonProperty("vatCode")]
        public string VatCode { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }
    }

    public class OrderCustomFieldDTO
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class GiftLineDTO
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("productVariantId")]
        public string ProductVariantId { get; set; }

        [JsonProperty("productTitle")]
        public string ProductTitle { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("vatCode")]
        public string VatCode { get; set; }

        [JsonProperty("imageLink")]
        public string ImageLink { get; set; }

        [JsonProperty("productAlias")]
        public string ProductAlias { get; set; }
    }

    public class ExpenseLineDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("netValue")]
        public double NetValue { get; set; }

        [JsonProperty("vatValue")]
        public double VatValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shopranos;

    public partial class WorkflowManagedActions
    {
        public ShopranosActions Shopranos(string connectionId) => new ShopranosActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShopranosTriggers Shopranos(string connectionId) => new ShopranosTriggers(connectionId);
    }
}
