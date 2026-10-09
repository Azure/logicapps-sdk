//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shopranos
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShopranosActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildAttributeSetsGETGetAll))]
        public IBodyWorkflowAction<AttributeSetDTO[]> AttributeSetsGETGetAll([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttributeSetDTO[]> __BuildAttributeSetsGETGetAll(WorkflowExpression<string> title = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<AttributeSetDTO[]>(() =>
            {
                var apiCallPath = "/api/AttributeSets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(title);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<AttributeSetDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildAttributesGETGetAll))]
        public IBodyWorkflowAction<AttributeDTO> AttributesGETGetAll([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<bool> isFilterable = null, [WorkflowExpression] Func<bool> displayOnProduct = null, [WorkflowExpression] Func<bool> displayInList = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AttributeDTO> __BuildAttributesGETGetAll(WorkflowExpression<statusInput> status = null, WorkflowExpression<string> type = null, WorkflowExpression<bool> isFilterable = null, WorkflowExpression<bool> displayOnProduct = null, WorkflowExpression<bool> displayInList = null, WorkflowExpression<string> search = null, WorkflowExpression<string> id = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(isFilterable, nameof(isFilterable), required: false);
            WorkflowExpression.Validate(displayOnProduct, nameof(displayOnProduct), required: false);
            WorkflowExpression.Validate(displayInList, nameof(displayInList), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<AttributeDTO>(() =>
            {
                var apiCallPath = "/api/Attributes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(type);
                if (isFilterable != null)
                    callPayload.Queries["IsFilterable"] = ExpressionConverter.Convert(isFilterable);
                if (displayOnProduct != null)
                    callPayload.Queries["DisplayOnProduct"] = ExpressionConverter.Convert(displayOnProduct);
                if (displayInList != null)
                    callPayload.Queries["DisplayInList"] = ExpressionConverter.Convert(displayInList);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<AttributeDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildBrandsGETGetAll))]
        public IBodyWorkflowAction<BrandDTO[]> BrandsGETGetAll([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrandDTO[]> __BuildBrandsGETGetAll(WorkflowExpression<statusInput> status = null, WorkflowExpression<string> search = null, WorkflowExpression<string> code = null, WorkflowExpression<string> id = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(code, nameof(code), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<BrandDTO[]>(() =>
            {
                var apiCallPath = "/api/Brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(code);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<BrandDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildCategoriesGETGetAll))]
        public IBodyWorkflowAction<CategoryDTO[]> CategoriesGETGetAll([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> path = null, [WorkflowExpression] Func<string> parentIds = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CategoryDTO[]> __BuildCategoriesGETGetAll(WorkflowExpression<string> title = null, WorkflowExpression<string> id = null, WorkflowExpression<string> search = null, WorkflowExpression<string> code = null, WorkflowExpression<string> parentId = null, WorkflowExpression<string> path = null, WorkflowExpression<string> parentIds = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(code, nameof(code), required: false);
            WorkflowExpression.Validate(parentId, nameof(parentId), required: false);
            WorkflowExpression.Validate(path, nameof(path), required: false);
            WorkflowExpression.Validate(parentIds, nameof(parentIds), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CategoryDTO[]>(() =>
            {
                var apiCallPath = "/api/Categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(title);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(code);
                if (parentId != null)
                    callPayload.Queries["ParentId"] = ExpressionConverter.Convert(parentId);
                if (path != null)
                    callPayload.Queries["Path"] = ExpressionConverter.Convert(path);
                if (parentIds != null)
                    callPayload.Queries["ParentIds"] = ExpressionConverter.Convert(parentIds);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
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
        [WorkflowExpressionFactory(nameof(__BuildIcoTagsGETGetAll))]
        public IBodyWorkflowAction<IcoTagDTO[]> IcoTagsGETGetAll([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IcoTagDTO[]> __BuildIcoTagsGETGetAll(WorkflowExpression<string> name = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<IcoTagDTO[]>(() =>
            {
                var apiCallPath = "/api/IcoTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<IcoTagDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildProductVariantsGETGetAllFlat))]
        public IBodyWorkflowAction<ProblemDetails> ProductVariantsGETGetAllFlat([WorkflowExpression] Func<string> price = null, [WorkflowExpression] Func<double> maxPrice = null, [WorkflowExpression] Func<string> size1 = null, [WorkflowExpression] Func<string> size2 = null, [WorkflowExpression] Func<string> size3 = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<string> date1 = null, [WorkflowExpression] Func<string> date2 = null, [WorkflowExpression] Func<string> date3 = null, [WorkflowExpression] Func<string> date1DateRange = null, [WorkflowExpression] Func<string> date2DateRange = null, [WorkflowExpression] Func<string> date3DateRange = null, [WorkflowExpression] Func<string> insertDateRange = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<double> minPrice = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> availability = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> sourceTag = null, [WorkflowExpression] Func<string> privacyRule = null, [WorkflowExpression] Func<string> rule = null, [WorkflowExpression] Func<string> condition = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> priceRange = null, [WorkflowExpression] Func<string> brandCode = null, [WorkflowExpression] Func<string> brandId = null, [WorkflowExpression] Func<string> attribute = null, [WorkflowExpression] Func<string> pathCategory = null, [WorkflowExpression] Func<string> categoryId = null, [WorkflowExpression] Func<string> additionalCategoryId = null, [WorkflowExpression] Func<string> stockAvailabilityId = null, [WorkflowExpression] Func<string> attributeSetId = null, [WorkflowExpression] Func<string> priceCategoryId = null, [WorkflowExpression] Func<bool> hasMedia = null, [WorkflowExpression] Func<string> masterId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetails> __BuildProductVariantsGETGetAllFlat(WorkflowExpression<string> price = null, WorkflowExpression<double> maxPrice = null, WorkflowExpression<string> size1 = null, WorkflowExpression<string> size2 = null, WorkflowExpression<string> size3 = null, WorkflowExpression<string> insertDate = null, WorkflowExpression<string> date1 = null, WorkflowExpression<string> date2 = null, WorkflowExpression<string> date3 = null, WorkflowExpression<string> date1DateRange = null, WorkflowExpression<string> date2DateRange = null, WorkflowExpression<string> date3DateRange = null, WorkflowExpression<string> insertDateRange = null, WorkflowExpression<string> search = null, WorkflowExpression<double> minPrice = null, WorkflowExpression<statusInput> status = null, WorkflowExpression<string> availability = null, WorkflowExpression<string> tag = null, WorkflowExpression<string> sourceTag = null, WorkflowExpression<string> privacyRule = null, WorkflowExpression<string> rule = null, WorkflowExpression<string> condition = null, WorkflowExpression<string> ids = null, WorkflowExpression<string> id = null, WorkflowExpression<string> priceRange = null, WorkflowExpression<string> brandCode = null, WorkflowExpression<string> brandId = null, WorkflowExpression<string> attribute = null, WorkflowExpression<string> pathCategory = null, WorkflowExpression<string> categoryId = null, WorkflowExpression<string> additionalCategoryId = null, WorkflowExpression<string> stockAvailabilityId = null, WorkflowExpression<string> attributeSetId = null, WorkflowExpression<string> priceCategoryId = null, WorkflowExpression<bool> hasMedia = null, WorkflowExpression<string> masterId = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(price, nameof(price), required: false);
            WorkflowExpression.Validate(maxPrice, nameof(maxPrice), required: false);
            WorkflowExpression.Validate(size1, nameof(size1), required: false);
            WorkflowExpression.Validate(size2, nameof(size2), required: false);
            WorkflowExpression.Validate(size3, nameof(size3), required: false);
            WorkflowExpression.Validate(insertDate, nameof(insertDate), required: false);
            WorkflowExpression.Validate(date1, nameof(date1), required: false);
            WorkflowExpression.Validate(date2, nameof(date2), required: false);
            WorkflowExpression.Validate(date3, nameof(date3), required: false);
            WorkflowExpression.Validate(date1DateRange, nameof(date1DateRange), required: false);
            WorkflowExpression.Validate(date2DateRange, nameof(date2DateRange), required: false);
            WorkflowExpression.Validate(date3DateRange, nameof(date3DateRange), required: false);
            WorkflowExpression.Validate(insertDateRange, nameof(insertDateRange), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(minPrice, nameof(minPrice), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(availability, nameof(availability), required: false);
            WorkflowExpression.Validate(tag, nameof(tag), required: false);
            WorkflowExpression.Validate(sourceTag, nameof(sourceTag), required: false);
            WorkflowExpression.Validate(privacyRule, nameof(privacyRule), required: false);
            WorkflowExpression.Validate(rule, nameof(rule), required: false);
            WorkflowExpression.Validate(condition, nameof(condition), required: false);
            WorkflowExpression.Validate(ids, nameof(ids), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(priceRange, nameof(priceRange), required: false);
            WorkflowExpression.Validate(brandCode, nameof(brandCode), required: false);
            WorkflowExpression.Validate(brandId, nameof(brandId), required: false);
            WorkflowExpression.Validate(attribute, nameof(attribute), required: false);
            WorkflowExpression.Validate(pathCategory, nameof(pathCategory), required: false);
            WorkflowExpression.Validate(categoryId, nameof(categoryId), required: false);
            WorkflowExpression.Validate(additionalCategoryId, nameof(additionalCategoryId), required: false);
            WorkflowExpression.Validate(stockAvailabilityId, nameof(stockAvailabilityId), required: false);
            WorkflowExpression.Validate(attributeSetId, nameof(attributeSetId), required: false);
            WorkflowExpression.Validate(priceCategoryId, nameof(priceCategoryId), required: false);
            WorkflowExpression.Validate(hasMedia, nameof(hasMedia), required: false);
            WorkflowExpression.Validate(masterId, nameof(masterId), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = "/api/ProductVariants/flat";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (price != null)
                    callPayload.Queries["Price"] = ExpressionConverter.Convert(price);
                if (maxPrice != null)
                    callPayload.Queries["MaxPrice"] = ExpressionConverter.Convert(maxPrice);
                if (size1 != null)
                    callPayload.Queries["Size1"] = ExpressionConverter.Convert(size1);
                if (size2 != null)
                    callPayload.Queries["Size2"] = ExpressionConverter.Convert(size2);
                if (size3 != null)
                    callPayload.Queries["Size3"] = ExpressionConverter.Convert(size3);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(insertDate);
                if (date1 != null)
                    callPayload.Queries["Date1"] = ExpressionConverter.Convert(date1);
                if (date2 != null)
                    callPayload.Queries["Date2"] = ExpressionConverter.Convert(date2);
                if (date3 != null)
                    callPayload.Queries["Date3"] = ExpressionConverter.Convert(date3);
                if (date1DateRange != null)
                    callPayload.Queries["Date1DateRange"] = ExpressionConverter.Convert(date1DateRange);
                if (date2DateRange != null)
                    callPayload.Queries["Date2DateRange"] = ExpressionConverter.Convert(date2DateRange);
                if (date3DateRange != null)
                    callPayload.Queries["Date3DateRange"] = ExpressionConverter.Convert(date3DateRange);
                if (insertDateRange != null)
                    callPayload.Queries["InsertDateRange"] = ExpressionConverter.Convert(insertDateRange);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (minPrice != null)
                    callPayload.Queries["MinPrice"] = ExpressionConverter.Convert(minPrice);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (availability != null)
                    callPayload.Queries["Availability"] = ExpressionConverter.Convert(availability);
                if (tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
                if (sourceTag != null)
                    callPayload.Queries["SourceTag"] = ExpressionConverter.Convert(sourceTag);
                if (privacyRule != null)
                    callPayload.Queries["PrivacyRule"] = ExpressionConverter.Convert(privacyRule);
                if (rule != null)
                    callPayload.Queries["Rule"] = ExpressionConverter.Convert(rule);
                if (condition != null)
                    callPayload.Queries["Condition"] = ExpressionConverter.Convert(condition);
                if (ids != null)
                    callPayload.Queries["Ids"] = ExpressionConverter.Convert(ids);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (priceRange != null)
                    callPayload.Queries["PriceRange"] = ExpressionConverter.Convert(priceRange);
                if (brandCode != null)
                    callPayload.Queries["BrandCode"] = ExpressionConverter.Convert(brandCode);
                if (brandId != null)
                    callPayload.Queries["BrandId"] = ExpressionConverter.Convert(brandId);
                if (attribute != null)
                    callPayload.Queries["Attribute"] = ExpressionConverter.Convert(attribute);
                if (pathCategory != null)
                    callPayload.Queries["PathCategory"] = ExpressionConverter.Convert(pathCategory);
                if (categoryId != null)
                    callPayload.Queries["CategoryId"] = ExpressionConverter.Convert(categoryId);
                if (additionalCategoryId != null)
                    callPayload.Queries["AdditionalCategoryId"] = ExpressionConverter.Convert(additionalCategoryId);
                if (stockAvailabilityId != null)
                    callPayload.Queries["StockAvailabilityId"] = ExpressionConverter.Convert(stockAvailabilityId);
                if (attributeSetId != null)
                    callPayload.Queries["AttributeSetId"] = ExpressionConverter.Convert(attributeSetId);
                if (priceCategoryId != null)
                    callPayload.Queries["PriceCategoryId"] = ExpressionConverter.Convert(priceCategoryId);
                if (hasMedia != null)
                    callPayload.Queries["HasMedia"] = ExpressionConverter.Convert(hasMedia);
                if (masterId != null)
                    callPayload.Queries["MasterId"] = ExpressionConverter.Convert(masterId);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildRelatedProductsGETGetRelated))]
        public IBodyWorkflowAction<RelatedProductVariantDTO> RelatedProductsGETGetRelated([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> variantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RelatedProductVariantDTO> __BuildRelatedProductsGETGetRelated(WorkflowExpression<string> productId, WorkflowExpression<string> variantId)
        {
            WorkflowExpression.Validate(productId, nameof(productId), required: true);
            WorkflowExpression.Validate(variantId, nameof(variantId), required: true);
            return new DeferredBodyAction<RelatedProductVariantDTO>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/RelatedProducts/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(productId, 1), ExpressionConverter.ConvertWithUrlEncoding(variantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RelatedProductVariantDTO>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildStockAvailabilityGETGetAll))]
        public IBodyWorkflowAction<StockAvailabilityDTO[]> StockAvailabilityGETGetAll([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StockAvailabilityDTO[]> __BuildStockAvailabilityGETGetAll(WorkflowExpression<string> title = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(title, nameof(title), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<StockAvailabilityDTO[]>(() =>
            {
                var apiCallPath = "/api/StockAvailability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = ExpressionConverter.Convert(title);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<StockAvailabilityDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildUnitsGETGetAll))]
        public IBodyWorkflowAction<UnitDTO[]> UnitsGETGetAll([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UnitDTO[]> __BuildUnitsGETGetAll(WorkflowExpression<string> name = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<UnitDTO[]>(() =>
            {
                var apiCallPath = "/api/Units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<UnitDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildCartDELETERemoveFromCart))]
        public IBodyWorkflowAction<ProblemDetails> CartDELETERemoveFromCart([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> productVariantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProblemDetails> __BuildCartDELETERemoveFromCart(WorkflowExpression<string> token, WorkflowExpression<string> productVariantId)
        {
            WorkflowExpression.Validate(token, nameof(token), required: true);
            WorkflowExpression.Validate(productVariantId, nameof(productVariantId), required: true);
            return new DeferredBodyAction<ProblemDetails>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/Cart/{0}/Items/{1}", ExpressionConverter.ConvertWithUrlEncoding(token, 1), ExpressionConverter.ConvertWithUrlEncoding(productVariantId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProblemDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildAssortmentValueGETGetAll))]
        public IBodyWorkflowAction<AssortmentValueDTO[]> AssortmentValueGETGetAll([WorkflowExpression] Func<string> customerid, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> productId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssortmentValueDTO[]> __BuildAssortmentValueGETGetAll(WorkflowExpression<string> customerid, WorkflowExpression<statusInput> status = null, WorkflowExpression<sourceInput> source = null, WorkflowExpression<string> type = null, WorkflowExpression<string> category = null, WorkflowExpression<string> id = null, WorkflowExpression<string> productId = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(customerid, nameof(customerid), required: true);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(source, nameof(source), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(productId, nameof(productId), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<AssortmentValueDTO[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/assortment/{0}/values", ExpressionConverter.ConvertWithUrlEncoding(customerid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (source != null)
                    callPayload.Queries["Source"] = ExpressionConverter.Convert(source);
                if (type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(type);
                if (category != null)
                    callPayload.Queries["Category"] = ExpressionConverter.Convert(category);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (productId != null)
                    callPayload.Queries["ProductId"] = ExpressionConverter.Convert(productId);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<AssortmentValueDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildCustomersGETGetAll))]
        public IBodyWorkflowAction<CustomerDTO[]> CustomersGETGetAll([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> salesmanId = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CustomerDTO[]> __BuildCustomersGETGetAll(WorkflowExpression<statusInput> status = null, WorkflowExpression<string> search = null, WorkflowExpression<string> name = null, WorkflowExpression<string> salesmanId = null, WorkflowExpression<string> id = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(salesmanId, nameof(salesmanId), required: false);
            WorkflowExpression.Validate(id, nameof(id), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<CustomerDTO[]>(() =>
            {
                var apiCallPath = "/api/Customers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (name != null)
                    callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
                if (salesmanId != null)
                    callPayload.Queries["SalesmanId"] = ExpressionConverter.Convert(salesmanId);
                if (id != null)
                    callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<CustomerDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildInventoryLevelsGETGetByVariantId))]
        public IBodyWorkflowAction<InventoryLevelDTO[]> InventoryLevelsGETGetByVariantId([WorkflowExpression] Func<string> variantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InventoryLevelDTO[]> __BuildInventoryLevelsGETGetByVariantId(WorkflowExpression<string> variantId)
        {
            WorkflowExpression.Validate(variantId, nameof(variantId), required: true);
            return new DeferredBodyAction<InventoryLevelDTO[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/InventoryLevels/variant/{0}", ExpressionConverter.ConvertWithUrlEncoding(variantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InventoryLevelDTO[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        [WorkflowExpressionFactory(nameof(__BuildOrderGETGetAll))]
        public IBodyWorkflowAction<OrderDTO[]> OrderGETGetAll([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<string> orderStatus = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> customerCode = null, [WorkflowExpression] Func<string> customerTin = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OrderDTO[]> __BuildOrderGETGetAll(WorkflowExpression<string> search = null, WorkflowExpression<string> code = null, WorkflowExpression<string> customerId = null, WorkflowExpression<string> orderStatus = null, WorkflowExpression<string> status = null, WorkflowExpression<string> tag = null, WorkflowExpression<string> customerCode = null, WorkflowExpression<string> customerTin = null, WorkflowExpression<string> insertDate = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: false);
            WorkflowExpression.Validate(code, nameof(code), required: false);
            WorkflowExpression.Validate(customerId, nameof(customerId), required: false);
            WorkflowExpression.Validate(orderStatus, nameof(orderStatus), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(tag, nameof(tag), required: false);
            WorkflowExpression.Validate(customerCode, nameof(customerCode), required: false);
            WorkflowExpression.Validate(customerTin, nameof(customerTin), required: false);
            WorkflowExpression.Validate(insertDate, nameof(insertDate), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<OrderDTO[]>(() =>
            {
                var apiCallPath = "/api/Order";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["Search"] = ExpressionConverter.Convert(search);
                if (code != null)
                    callPayload.Queries["Code"] = ExpressionConverter.Convert(code);
                if (customerId != null)
                    callPayload.Queries["CustomerId"] = ExpressionConverter.Convert(customerId);
                if (orderStatus != null)
                    callPayload.Queries["OrderStatus"] = ExpressionConverter.Convert(orderStatus);
                if (status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(status);
                if (tag != null)
                    callPayload.Queries["Tag"] = ExpressionConverter.Convert(tag);
                if (customerCode != null)
                    callPayload.Queries["CustomerCode"] = ExpressionConverter.Convert(customerCode);
                if (customerTin != null)
                    callPayload.Queries["CustomerTin"] = ExpressionConverter.Convert(customerTin);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = ExpressionConverter.Convert(insertDate);
                if (page != null)
                    callPayload.Queries["Page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = ExpressionConverter.Convert(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = ExpressionConverter.Convert(sort);
                return new ApiConnectionAction<OrderDTO[]>(callPayload);
            });
        }
    }

    public class ShopranosTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildProductCreatedTrigger))]
        public IWorkflowTrigger ProductCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildProductCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildProductUpdatedTrigger))]
        public IWorkflowTrigger ProductUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildProductUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildProductDeletedTrigger))]
        public IWorkflowTrigger ProductDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildProductDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCategoryCreatedTrigger))]
        public IWorkflowTrigger CategoryCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCategoryCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCategoryUpdatedTrigger))]
        public IWorkflowTrigger CategoryUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCategoryUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCategoryDeletedTrigger))]
        public IWorkflowTrigger CategoryDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCategoryDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildBrandCreatedTrigger))]
        public IWorkflowTrigger BrandCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBrandCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildBrandUpdatedTrigger))]
        public IWorkflowTrigger BrandUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBrandUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildBrandDeletedTrigger))]
        public IWorkflowTrigger BrandDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildBrandDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildUnitCreatedTrigger))]
        public IWorkflowTrigger UnitCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUnitCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildUnitUpdatedTrigger))]
        public IWorkflowTrigger UnitUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUnitUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildUnitDeletedTrigger))]
        public IWorkflowTrigger UnitDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUnitDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAttributeCreatedTrigger))]
        public IWorkflowTrigger AttributeCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttributeCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAttributeUpdatedTrigger))]
        public IWorkflowTrigger AttributeUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttributeUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAttributeDeletedTrigger))]
        public IWorkflowTrigger AttributeDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttributeDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAttributeSetCreatedTrigger))]
        public IWorkflowTrigger AttributeSetCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttributeSetCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAttributeSetUpdatedTrigger))]
        public IWorkflowTrigger AttributeSetUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttributeSetUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAttributeSetDeletedTrigger))]
        public IWorkflowTrigger AttributeSetDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildAttributeSetDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCheckoutCreatedTrigger))]
        public IWorkflowTrigger CheckoutCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCheckoutCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCheckoutCompletedTrigger))]
        public IWorkflowTrigger CheckoutCompletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCheckoutCompletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCustomerCreatedTrigger))]
        public IWorkflowTrigger CustomerCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCustomerCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCustomerUpdatedTrigger))]
        public IWorkflowTrigger CustomerUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCustomerUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCustomerDeletedTrigger))]
        public IWorkflowTrigger CustomerDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCustomerDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOrderCreatedTrigger))]
        public IWorkflowTrigger OrderCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOrderCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOrderUpdatedTrigger))]
        public IWorkflowTrigger OrderUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOrderUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOrderDeletedTrigger))]
        public IWorkflowTrigger OrderDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildOrderDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildInventoryLevelCreatedTrigger))]
        public IWorkflowTrigger InventoryLevelCreatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildInventoryLevelCreatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildInventoryLevelUpdatedTrigger))]
        public IWorkflowTrigger InventoryLevelUpdatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildInventoryLevelUpdatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildInventoryLevelDeletedTrigger))]
        public IWorkflowTrigger InventoryLevelDeletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildInventoryLevelDeletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildPaymentInitiatedTrigger))]
        public IWorkflowTrigger PaymentInitiatedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildPaymentInitiatedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildPaymentCompletedTrigger))]
        public IWorkflowTrigger PaymentCompletedTrigger([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildPaymentCompletedTrigger(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
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
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
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