//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shopranos
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShopranosActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<AttributeSetDTO[]> AttributeSetsGETGetAll([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/AttributeSets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = SourceExpressionConverter.ConvertO(title);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<AttributeSetDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<AttributeDTO> AttributesGETGetAll([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<bool> isFilterable = null, [WorkflowExpression] Func<bool> displayOnProduct = null, [WorkflowExpression] Func<bool> displayInList = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(isFilterable, nameof(isFilterable), required: false);
            SourceExpression.Validate(displayOnProduct, nameof(displayOnProduct), required: false);
            SourceExpression.Validate(displayInList, nameof(displayInList), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Attributes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (type != null)
                    callPayload.Queries["Type"] = SourceExpressionConverter.ConvertO(type);
                if (isFilterable != null)
                    callPayload.Queries["IsFilterable"] = SourceExpressionConverter.ConvertO(isFilterable);
                if (displayOnProduct != null)
                    callPayload.Queries["DisplayOnProduct"] = SourceExpressionConverter.ConvertO(displayOnProduct);
                if (displayInList != null)
                    callPayload.Queries["DisplayInList"] = SourceExpressionConverter.ConvertO(displayInList);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<AttributeDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<BrandDTO[]> BrandsGETGetAll([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(code, nameof(code), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (code != null)
                    callPayload.Queries["Code"] = SourceExpressionConverter.ConvertO(code);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<BrandDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<CategoryDTO[]> CategoriesGETGetAll([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> parentId = null, [WorkflowExpression] Func<string> path = null, [WorkflowExpression] Func<string> parentIds = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(code, nameof(code), required: false);
            SourceExpression.Validate(parentId, nameof(parentId), required: false);
            SourceExpression.Validate(path, nameof(path), required: false);
            SourceExpression.Validate(parentIds, nameof(parentIds), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = SourceExpressionConverter.ConvertO(title);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (code != null)
                    callPayload.Queries["Code"] = SourceExpressionConverter.ConvertO(code);
                if (parentId != null)
                    callPayload.Queries["ParentId"] = SourceExpressionConverter.ConvertO(parentId);
                if (path != null)
                    callPayload.Queries["Path"] = SourceExpressionConverter.ConvertO(path);
                if (parentIds != null)
                    callPayload.Queries["ParentIds"] = SourceExpressionConverter.ConvertO(parentIds);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<CategoryDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<ProblemDetails> FiltersPOSTBuildFilters()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Filters/clear";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<IcoTagDTO[]> IcoTagsGETGetAll([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/IcoTags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<IcoTagDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<ProblemDetails> ProductVariantsGETGetAllFlat([WorkflowExpression] Func<string> price = null, [WorkflowExpression] Func<double> maxPrice = null, [WorkflowExpression] Func<string> size1 = null, [WorkflowExpression] Func<string> size2 = null, [WorkflowExpression] Func<string> size3 = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<string> date1 = null, [WorkflowExpression] Func<string> date2 = null, [WorkflowExpression] Func<string> date3 = null, [WorkflowExpression] Func<string> date1DateRange = null, [WorkflowExpression] Func<string> date2DateRange = null, [WorkflowExpression] Func<string> date3DateRange = null, [WorkflowExpression] Func<string> insertDateRange = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<double> minPrice = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> availability = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> sourceTag = null, [WorkflowExpression] Func<string> privacyRule = null, [WorkflowExpression] Func<string> rule = null, [WorkflowExpression] Func<string> condition = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> priceRange = null, [WorkflowExpression] Func<string> brandCode = null, [WorkflowExpression] Func<string> brandId = null, [WorkflowExpression] Func<string> attribute = null, [WorkflowExpression] Func<string> pathCategory = null, [WorkflowExpression] Func<string> categoryId = null, [WorkflowExpression] Func<string> additionalCategoryId = null, [WorkflowExpression] Func<string> stockAvailabilityId = null, [WorkflowExpression] Func<string> attributeSetId = null, [WorkflowExpression] Func<string> priceCategoryId = null, [WorkflowExpression] Func<bool> hasMedia = null, [WorkflowExpression] Func<string> masterId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(price, nameof(price), required: false);
            SourceExpression.Validate(maxPrice, nameof(maxPrice), required: false);
            SourceExpression.Validate(size1, nameof(size1), required: false);
            SourceExpression.Validate(size2, nameof(size2), required: false);
            SourceExpression.Validate(size3, nameof(size3), required: false);
            SourceExpression.Validate(insertDate, nameof(insertDate), required: false);
            SourceExpression.Validate(date1, nameof(date1), required: false);
            SourceExpression.Validate(date2, nameof(date2), required: false);
            SourceExpression.Validate(date3, nameof(date3), required: false);
            SourceExpression.Validate(date1DateRange, nameof(date1DateRange), required: false);
            SourceExpression.Validate(date2DateRange, nameof(date2DateRange), required: false);
            SourceExpression.Validate(date3DateRange, nameof(date3DateRange), required: false);
            SourceExpression.Validate(insertDateRange, nameof(insertDateRange), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(minPrice, nameof(minPrice), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(availability, nameof(availability), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(sourceTag, nameof(sourceTag), required: false);
            SourceExpression.Validate(privacyRule, nameof(privacyRule), required: false);
            SourceExpression.Validate(rule, nameof(rule), required: false);
            SourceExpression.Validate(condition, nameof(condition), required: false);
            SourceExpression.Validate(ids, nameof(ids), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(priceRange, nameof(priceRange), required: false);
            SourceExpression.Validate(brandCode, nameof(brandCode), required: false);
            SourceExpression.Validate(brandId, nameof(brandId), required: false);
            SourceExpression.Validate(attribute, nameof(attribute), required: false);
            SourceExpression.Validate(pathCategory, nameof(pathCategory), required: false);
            SourceExpression.Validate(categoryId, nameof(categoryId), required: false);
            SourceExpression.Validate(additionalCategoryId, nameof(additionalCategoryId), required: false);
            SourceExpression.Validate(stockAvailabilityId, nameof(stockAvailabilityId), required: false);
            SourceExpression.Validate(attributeSetId, nameof(attributeSetId), required: false);
            SourceExpression.Validate(priceCategoryId, nameof(priceCategoryId), required: false);
            SourceExpression.Validate(hasMedia, nameof(hasMedia), required: false);
            SourceExpression.Validate(masterId, nameof(masterId), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ProductVariants/flat";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (price != null)
                    callPayload.Queries["Price"] = SourceExpressionConverter.ConvertO(price);
                if (maxPrice != null)
                    callPayload.Queries["MaxPrice"] = SourceExpressionConverter.ConvertO(maxPrice);
                if (size1 != null)
                    callPayload.Queries["Size1"] = SourceExpressionConverter.ConvertO(size1);
                if (size2 != null)
                    callPayload.Queries["Size2"] = SourceExpressionConverter.ConvertO(size2);
                if (size3 != null)
                    callPayload.Queries["Size3"] = SourceExpressionConverter.ConvertO(size3);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = SourceExpressionConverter.ConvertO(insertDate);
                if (date1 != null)
                    callPayload.Queries["Date1"] = SourceExpressionConverter.ConvertO(date1);
                if (date2 != null)
                    callPayload.Queries["Date2"] = SourceExpressionConverter.ConvertO(date2);
                if (date3 != null)
                    callPayload.Queries["Date3"] = SourceExpressionConverter.ConvertO(date3);
                if (date1DateRange != null)
                    callPayload.Queries["Date1DateRange"] = SourceExpressionConverter.ConvertO(date1DateRange);
                if (date2DateRange != null)
                    callPayload.Queries["Date2DateRange"] = SourceExpressionConverter.ConvertO(date2DateRange);
                if (date3DateRange != null)
                    callPayload.Queries["Date3DateRange"] = SourceExpressionConverter.ConvertO(date3DateRange);
                if (insertDateRange != null)
                    callPayload.Queries["InsertDateRange"] = SourceExpressionConverter.ConvertO(insertDateRange);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (minPrice != null)
                    callPayload.Queries["MinPrice"] = SourceExpressionConverter.ConvertO(minPrice);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (availability != null)
                    callPayload.Queries["Availability"] = SourceExpressionConverter.ConvertO(availability);
                if (tag != null)
                    callPayload.Queries["Tag"] = SourceExpressionConverter.ConvertO(tag);
                if (sourceTag != null)
                    callPayload.Queries["SourceTag"] = SourceExpressionConverter.ConvertO(sourceTag);
                if (privacyRule != null)
                    callPayload.Queries["PrivacyRule"] = SourceExpressionConverter.ConvertO(privacyRule);
                if (rule != null)
                    callPayload.Queries["Rule"] = SourceExpressionConverter.ConvertO(rule);
                if (condition != null)
                    callPayload.Queries["Condition"] = SourceExpressionConverter.ConvertO(condition);
                if (ids != null)
                    callPayload.Queries["Ids"] = SourceExpressionConverter.ConvertO(ids);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (priceRange != null)
                    callPayload.Queries["PriceRange"] = SourceExpressionConverter.ConvertO(priceRange);
                if (brandCode != null)
                    callPayload.Queries["BrandCode"] = SourceExpressionConverter.ConvertO(brandCode);
                if (brandId != null)
                    callPayload.Queries["BrandId"] = SourceExpressionConverter.ConvertO(brandId);
                if (attribute != null)
                    callPayload.Queries["Attribute"] = SourceExpressionConverter.ConvertO(attribute);
                if (pathCategory != null)
                    callPayload.Queries["PathCategory"] = SourceExpressionConverter.ConvertO(pathCategory);
                if (categoryId != null)
                    callPayload.Queries["CategoryId"] = SourceExpressionConverter.ConvertO(categoryId);
                if (additionalCategoryId != null)
                    callPayload.Queries["AdditionalCategoryId"] = SourceExpressionConverter.ConvertO(additionalCategoryId);
                if (stockAvailabilityId != null)
                    callPayload.Queries["StockAvailabilityId"] = SourceExpressionConverter.ConvertO(stockAvailabilityId);
                if (attributeSetId != null)
                    callPayload.Queries["AttributeSetId"] = SourceExpressionConverter.ConvertO(attributeSetId);
                if (priceCategoryId != null)
                    callPayload.Queries["PriceCategoryId"] = SourceExpressionConverter.ConvertO(priceCategoryId);
                if (hasMedia != null)
                    callPayload.Queries["HasMedia"] = SourceExpressionConverter.ConvertO(hasMedia);
                if (masterId != null)
                    callPayload.Queries["MasterId"] = SourceExpressionConverter.ConvertO(masterId);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<RelatedProductVariantDTO> RelatedProductsGETGetRelated([WorkflowExpression] Func<string> productId, [WorkflowExpression] Func<string> variantId)
        {
            SourceExpression.Validate(productId, nameof(productId), required: true);
            SourceExpression.Validate(variantId, nameof(variantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/RelatedProducts/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(variantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RelatedProductVariantDTO>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<StockAvailabilityDTO[]> StockAvailabilityGETGetAll([WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(title, nameof(title), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/StockAvailability";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (title != null)
                    callPayload.Queries["Title"] = SourceExpressionConverter.ConvertO(title);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<StockAvailabilityDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<UnitDTO[]> UnitsGETGetAll([WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<UnitDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<ProblemDetails> CartDELETERemoveFromCart([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> productVariantId)
        {
            SourceExpression.Validate(token, nameof(token), required: true);
            SourceExpression.Validate(productVariantId, nameof(productVariantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/Cart/{0}/Items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(token, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(productVariantId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProblemDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<AssortmentValueDTO[]> AssortmentValueGETGetAll([WorkflowExpression] Func<string> customerid, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<sourceInput> source = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> category = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<string> productId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(customerid, nameof(customerid), required: true);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(source, nameof(source), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(category, nameof(category), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(productId, nameof(productId), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/assortment/{0}/values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (source != null)
                    callPayload.Queries["Source"] = SourceExpressionConverter.Convert(source);
                if (type != null)
                    callPayload.Queries["Type"] = SourceExpressionConverter.ConvertO(type);
                if (category != null)
                    callPayload.Queries["Category"] = SourceExpressionConverter.ConvertO(category);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (productId != null)
                    callPayload.Queries["ProductId"] = SourceExpressionConverter.ConvertO(productId);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<AssortmentValueDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<CustomerDTO[]> CustomersGETGetAll([WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<string> salesmanId = null, [WorkflowExpression] Func<string> id = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(salesmanId, nameof(salesmanId), required: false);
            SourceExpression.Validate(id, nameof(id), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Customers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.Convert(status);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (name != null)
                    callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                if (salesmanId != null)
                    callPayload.Queries["SalesmanId"] = SourceExpressionConverter.ConvertO(salesmanId);
                if (id != null)
                    callPayload.Queries["Id"] = SourceExpressionConverter.ConvertO(id);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<InventoryLevelDTO[]> InventoryLevelsGETGetByVariantId([WorkflowExpression] Func<string> variantId)
        {
            SourceExpression.Validate(variantId, nameof(variantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/InventoryLevels/variant/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(variantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InventoryLevelDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopranos")]
        public IBodyWorkflowAction<OrderDTO[]> OrderGETGetAll([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<string> orderStatus = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> customerCode = null, [WorkflowExpression] Func<string> customerTin = null, [WorkflowExpression] Func<string> insertDate = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sort = null)
        {
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(code, nameof(code), required: false);
            SourceExpression.Validate(customerId, nameof(customerId), required: false);
            SourceExpression.Validate(orderStatus, nameof(orderStatus), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(customerCode, nameof(customerCode), required: false);
            SourceExpression.Validate(customerTin, nameof(customerTin), required: false);
            SourceExpression.Validate(insertDate, nameof(insertDate), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(pageSize, nameof(pageSize), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Order";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["Search"] = SourceExpressionConverter.ConvertO(search);
                if (code != null)
                    callPayload.Queries["Code"] = SourceExpressionConverter.ConvertO(code);
                if (customerId != null)
                    callPayload.Queries["CustomerId"] = SourceExpressionConverter.ConvertO(customerId);
                if (orderStatus != null)
                    callPayload.Queries["OrderStatus"] = SourceExpressionConverter.ConvertO(orderStatus);
                if (status != null)
                    callPayload.Queries["Status"] = SourceExpressionConverter.ConvertO(status);
                if (tag != null)
                    callPayload.Queries["Tag"] = SourceExpressionConverter.ConvertO(tag);
                if (customerCode != null)
                    callPayload.Queries["CustomerCode"] = SourceExpressionConverter.ConvertO(customerCode);
                if (customerTin != null)
                    callPayload.Queries["CustomerTin"] = SourceExpressionConverter.ConvertO(customerTin);
                if (insertDate != null)
                    callPayload.Queries["InsertDate"] = SourceExpressionConverter.ConvertO(insertDate);
                if (page != null)
                    callPayload.Queries["Page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["PageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sort != null)
                    callPayload.Queries["Sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<OrderDTO[]>(BuildSourceInput);
        }
    }

    public class ShopranosTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProductCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/product/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ProductUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/product/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ProductDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/product/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CategoryCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/category/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CategoryUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/category/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CategoryDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/category/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BrandCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/brand/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BrandUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/brand/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger BrandDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/brand/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UnitCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/unit/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UnitUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/unit/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger UnitDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/unit/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttributeCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/attribute/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttributeUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/attribute/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttributeDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/attribute/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttributeSetCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/attributeset/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttributeSetUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/attributeset/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger AttributeSetDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/attributeset/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CheckoutCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/checkout/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CheckoutCompletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/checkout/completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CustomerCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/customer/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CustomerUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/customer/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CustomerDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/customer/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OrderCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/order/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OrderUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/order/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger OrderDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/order/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger InventoryLevelCreatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/inventorylevel/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger InventoryLevelUpdatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/inventorylevel/updated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger InventoryLevelDeletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/inventorylevel/deleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger PaymentInitiatedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/payment/initiated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger PaymentCompletedTrigger([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/webhook/register/payment/completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["Url"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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

    public enum AttributeDTOTypeType
    {
        Text,
        Items,
        Color,
        Size
    }

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

    public enum IcoTagDTOModeType
    {
        Automatic,
        Manual,
        [EnumMember(Value = "ignore")]
        Ignore
    }

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

    public enum AssortmentValueDTOStatusType
    {
        Inactive,
        Active
    }

    public enum AssortmentValueDTOSourceType
    {
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "orders")]
        Orders
    }

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

    public enum CustomerDTOVatTypeType
    {
        Zero,
        Regular,
        Discounted,
        [EnumMember(Value = "ignore")]
        Ignore
    }

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

    public enum OrderDTOFinancialStatusType
    {
        Pending,
        Authorized,
        PartiallyPaid,
        PartiallyRefunded,
        Refunded,
        Voided
    }

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