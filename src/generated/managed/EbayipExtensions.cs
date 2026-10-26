//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebayip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EbayipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetDefaultCategoryTreeIdResponse, ApiConnectionActionConfiguration> GetDefaultCategoryTreeId(Expression<Func<string>> marketplaceId, Expression<Func<string>> acceptLanguage)
        {
            var __workflow_marketplaceId = WorkflowExpression.Compile(marketplaceId, nameof(marketplaceId), required: true);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: true);
            return new DeferredBodyAction<GetDefaultCategoryTreeIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/commerce/taxonomy/v1/get_default_category_tree_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = ExpressionConverter.Convert(__workflow_marketplaceId);
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                return new ApiConnectionAction<GetDefaultCategoryTreeIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetCategorySuggestionsResponse, ApiConnectionActionConfiguration> GetCategorySuggestions(Expression<Func<string>> categoryTreeId, Expression<Func<string>> q)
        {
            var __workflow_categoryTreeId = WorkflowExpression.Compile(categoryTreeId, nameof(categoryTreeId), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            return new DeferredBodyAction<GetCategorySuggestionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commerce/taxonomy/v1/category_tree/{0}/get_category_suggestions", __workflow_categoryTreeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("application/gzip");
                return new ApiConnectionAction<GetCategorySuggestionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetItemAspectsResponse, ApiConnectionActionConfiguration> GetItemAspects(Expression<Func<string>> categoryTreeId, Expression<Func<string>> categoryId)
        {
            var __workflow_categoryTreeId = WorkflowExpression.Compile(categoryTreeId, nameof(categoryTreeId), required: true);
            var __workflow_categoryId = WorkflowExpression.Compile(categoryId, nameof(categoryId), required: true);
            return new DeferredBodyAction<GetItemAspectsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/commerce/taxonomy/v1/category_tree/{0}/get_item_aspects_for_category", __workflow_categoryTreeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(__workflow_categoryId);
                return new ApiConnectionAction<GetItemAspectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetFulfillmentPoliciesResponse, ApiConnectionActionConfiguration> GetFulfillmentPolicies(Expression<Func<string>> marketplaceId)
        {
            var __workflow_marketplaceId = WorkflowExpression.Compile(marketplaceId, nameof(marketplaceId), required: true);
            return new DeferredBodyAction<GetFulfillmentPoliciesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sell/account/v1/fulfillment_policy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = ExpressionConverter.Convert(__workflow_marketplaceId);
                return new ApiConnectionAction<GetFulfillmentPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetFulfillmentPolicyResponse, ApiConnectionActionConfiguration> GetFulfillmentPolicy(Expression<Func<string>> fulfillmentPolicyId)
        {
            var __workflow_fulfillmentPolicyId = WorkflowExpression.Compile(fulfillmentPolicyId, nameof(fulfillmentPolicyId), required: true);
            return new DeferredBodyAction<GetFulfillmentPolicyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/account/v1/fulfillment_policy/{0}", __workflow_fulfillmentPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFulfillmentPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetPaymentPolicyResponse, ApiConnectionActionConfiguration> GetPaymentPolicy(Expression<Func<string>> paymentPolicyId)
        {
            var __workflow_paymentPolicyId = WorkflowExpression.Compile(paymentPolicyId, nameof(paymentPolicyId), required: true);
            return new DeferredBodyAction<GetPaymentPolicyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/account/v1/payment_policy/{0}", __workflow_paymentPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPaymentPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetReturnPoliciesResponse, ApiConnectionActionConfiguration> GetReturnPolicies(Expression<Func<string>> marketplaceId)
        {
            var __workflow_marketplaceId = WorkflowExpression.Compile(marketplaceId, nameof(marketplaceId), required: true);
            return new DeferredBodyAction<GetReturnPoliciesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sell/account/v1/return_policy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = ExpressionConverter.Convert(__workflow_marketplaceId);
                return new ApiConnectionAction<GetReturnPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetReturnPolicyResponse, ApiConnectionActionConfiguration> GetReturnPolicy(Expression<Func<string>> returnPolicyId)
        {
            var __workflow_returnPolicyId = WorkflowExpression.Compile(returnPolicyId, nameof(returnPolicyId), required: true);
            return new DeferredBodyAction<GetReturnPolicyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/account/v1/return_policy/{0}", __workflow_returnPolicyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetReturnPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryItemResponse, ApiConnectionActionConfiguration> GetInventoryItem(Expression<Func<string>> sku)
        {
            var __workflow_sku = WorkflowExpression.Compile(sku, nameof(sku), required: true);
            return new DeferredBodyAction<GetInventoryItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/inventory_item/{0}", __workflow_sku.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetInventoryItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<CreateOrReplaceInventoryItemResponse, ApiConnectionActionConfiguration> CreateOrReplaceInventoryItem(Expression<Func<string>> sku, Expression<Func<string>> contentLanguage, Expression<Func<CreateOrReplaceInventoryItemInput>> body = null)
        {
            var __workflow_sku = WorkflowExpression.Compile(sku, nameof(sku), required: true);
            var __workflow_contentLanguage = WorkflowExpression.Compile(contentLanguage, nameof(contentLanguage), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateOrReplaceInventoryItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/inventory_item/{0}", __workflow_sku.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Content-Language"] = ExpressionConverter.Convert(__workflow_contentLanguage);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateOrReplaceInventoryItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryItemsResponse, ApiConnectionActionConfiguration> GetInventoryItems(Expression<Func<string>> Limit = null, Expression<Func<string>> Offset = null)
        {
            var __workflow_Limit = WorkflowExpression.Compile(Limit, nameof(Limit), required: false);
            var __workflow_Offset = WorkflowExpression.Compile(Offset, nameof(Offset), required: false);
            return new DeferredBodyAction<GetInventoryItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/inventory_item";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Limit != null)
                    callPayload.Queries[" limit"] = ExpressionConverter.Convert(__workflow_Limit);
                if (__workflow_Offset != null)
                    callPayload.Queries[" offset"] = ExpressionConverter.Convert(__workflow_Offset);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetInventoryItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryLocationResponse, ApiConnectionActionConfiguration> GetInventoryLocation(Expression<Func<string>> merchantLocationKey)
        {
            var __workflow_merchantLocationKey = WorkflowExpression.Compile(merchantLocationKey, nameof(merchantLocationKey), required: true);
            return new DeferredBodyAction<GetInventoryLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/location/{0}", __workflow_merchantLocationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInventoryLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateInventoryLocation(Expression<Func<string>> merchantLocationKey, Expression<Func<CreateInventoryLocationInput>> body = null)
        {
            var __workflow_merchantLocationKey = WorkflowExpression.Compile(merchantLocationKey, nameof(merchantLocationKey), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/location/{0}", __workflow_merchantLocationKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryLocationsResponse, ApiConnectionActionConfiguration> GetInventoryLocations(Expression<Func<string>> Offset = null, Expression<Func<string>> Limit = null)
        {
            var __workflow_Offset = WorkflowExpression.Compile(Offset, nameof(Offset), required: false);
            var __workflow_Limit = WorkflowExpression.Compile(Limit, nameof(Limit), required: false);
            return new DeferredBodyAction<GetInventoryLocationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Offset != null)
                    callPayload.Queries[" offset"] = ExpressionConverter.Convert(__workflow_Offset);
                if (__workflow_Limit != null)
                    callPayload.Queries[" limit"] = ExpressionConverter.Convert(__workflow_Limit);
                return new ApiConnectionAction<GetInventoryLocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetItemConditionPoliciesResponse, ApiConnectionActionConfiguration> GetItemConditionPolicies(Expression<Func<string>> marketplaceId, Expression<Func<string>> Filter = null)
        {
            var __workflow_marketplaceId = WorkflowExpression.Compile(marketplaceId, nameof(marketplaceId), required: true);
            var __workflow_Filter = WorkflowExpression.Compile(Filter, nameof(Filter), required: false);
            return new DeferredBodyAction<GetItemConditionPoliciesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/metadata/v1/marketplace/{0}/get_item_condition_policies", __workflow_marketplaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Filter != null)
                    callPayload.Queries[" filter"] = ExpressionConverter.Convert(__workflow_Filter);
                return new ApiConnectionAction<GetItemConditionPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetOffersResponse, ApiConnectionActionConfiguration> GetOffers(Expression<Func<string>> sku, Expression<Func<string>> MarketplaceId = null, Expression<Func<string>> Format = null, Expression<Func<string>> Limit = null, Expression<Func<string>> Offset = null)
        {
            var __workflow_sku = WorkflowExpression.Compile(sku, nameof(sku), required: true);
            var __workflow_MarketplaceId = WorkflowExpression.Compile(MarketplaceId, nameof(MarketplaceId), required: false);
            var __workflow_Format = WorkflowExpression.Compile(Format, nameof(Format), required: false);
            var __workflow_Limit = WorkflowExpression.Compile(Limit, nameof(Limit), required: false);
            var __workflow_Offset = WorkflowExpression.Compile(Offset, nameof(Offset), required: false);
            return new DeferredBodyAction<GetOffersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/offer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sku"] = ExpressionConverter.Convert(__workflow_sku);
                if (__workflow_MarketplaceId != null)
                    callPayload.Queries[" marketplace_id"] = ExpressionConverter.Convert(__workflow_MarketplaceId);
                if (__workflow_Format != null)
                    callPayload.Queries[" format"] = ExpressionConverter.Convert(__workflow_Format);
                if (__workflow_Limit != null)
                    callPayload.Queries[" limit"] = ExpressionConverter.Convert(__workflow_Limit);
                if (__workflow_Offset != null)
                    callPayload.Queries[" offset"] = ExpressionConverter.Convert(__workflow_Offset);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetOffersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<CreateOfferResponse, ApiConnectionActionConfiguration> CreateOffer(Expression<Func<CreateOfferInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateOfferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/offer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetOfferResponse, ApiConnectionActionConfiguration> GetOffer(Expression<Func<string>> offerId)
        {
            var __workflow_offerId = WorkflowExpression.Compile(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<GetOfferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/offer/{0}", __workflow_offerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteOffer(Expression<Func<string>> offerId)
        {
            var __workflow_offerId = WorkflowExpression.Compile(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/offer/{0}", __workflow_offerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<UpdateOfferResponse, ApiConnectionActionConfiguration> UpdateOffer(Expression<Func<string>> offerId, Expression<Func<UpdateOfferInput>> body = null)
        {
            var __workflow_offerId = WorkflowExpression.Compile(offerId, nameof(offerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateOfferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/offer/{0}", __workflow_offerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Language"] = Convert.ToString("en-US");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<WithdrawOfferResponse, ApiConnectionActionConfiguration> WithdrawOffer(Expression<Func<string>> offerId)
        {
            var __workflow_offerId = WorkflowExpression.Compile(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<WithdrawOfferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/offer/{0}/withdraw", __workflow_offerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<WithdrawOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<PublishOfferResponse, ApiConnectionActionConfiguration> PublishOffer(Expression<Func<string>> offerId)
        {
            var __workflow_offerId = WorkflowExpression.Compile(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<PublishOfferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sell/inventory/v1/offer/{0}/publish/", __workflow_offerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<PublishOfferResponse>(callPayload);
            });
        }
    }

    public class EbayipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetDefaultCategoryTreeIdResponse
    {
        [JsonProperty("categoryTreeId")]
        public string CategoryTreeId { get; set; }

        [JsonProperty("categoryTreeVersion")]
        public string CategoryTreeVersion { get; set; }
    }

    public class GetCategorySuggestionsResponse
    {
        [JsonProperty("categorySuggestions")]
        public GetCategorySuggestionsResponseCategorySuggestionsTypeItem[] CategorySuggestions { get; set; }

        [JsonProperty("categoryTreeId")]
        public string CategoryTreeId { get; set; }

        [JsonProperty("categoryTreeVersion")]
        public string CategoryTreeVersion { get; set; }
    }

    public class GetCategorySuggestionsResponseCategorySuggestionsTypeItem
    {
        [JsonProperty("category")]
        public GetCategorySuggestionsResponseCategorySuggestionsTypeItemCategoryType Category { get; set; }

        [JsonProperty("categoryTreeNodeAncestors")]
        public GetCategorySuggestionsResponseCategorySuggestionsTypeItemCategoryTreeNodeAncestorsTypeItem[] CategoryTreeNodeAncestors { get; set; }

        [JsonProperty("categoryTreeNodeLevel")]
        public int CategoryTreeNodeLevel { get; set; }

        [JsonProperty("relevancy")]
        public string Relevancy { get; set; }
    }

    public class GetCategorySuggestionsResponseCategorySuggestionsTypeItemCategoryType
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
    }

    public class GetCategorySuggestionsResponseCategorySuggestionsTypeItemCategoryTreeNodeAncestorsTypeItem
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("categorySubtreeNodeHref")]
        public string CategorySubtreeNodeHref { get; set; }

        [JsonProperty("categoryTreeNodeLevel")]
        public int CategoryTreeNodeLevel { get; set; }
    }

    public class GetItemAspectsResponse
    {
        [JsonProperty("aspects")]
        public GetItemAspectsResponseAspectsTypeItem[] Aspects { get; set; }
    }

    public class GetItemAspectsResponseAspectsTypeItem
    {
        [JsonProperty("aspectConstraint")]
        public GetItemAspectsResponseAspectsTypeItemAspectConstraintType AspectConstraint { get; set; }

        [JsonProperty("aspectValues")]
        public GetItemAspectsResponseAspectsTypeItemAspectValuesTypeItem[] AspectValues { get; set; }

        [JsonProperty("localizedAspectName")]
        public string LocalizedAspectName { get; set; }

        [JsonProperty("relevanceIndicator")]
        public GetItemAspectsResponseAspectsTypeItemRelevanceIndicatorType RelevanceIndicator { get; set; }
    }

    public class GetItemAspectsResponseAspectsTypeItemAspectConstraintType
    {
        [JsonProperty("aspectApplicableTo")]
        public string[] AspectApplicableTo { get; set; }

        [JsonProperty("aspectDataType")]
        public string AspectDataType { get; set; }

        [JsonProperty("aspectEnabledForVariations")]
        public bool AspectEnabledForVariations { get; set; }

        [JsonProperty("aspectFormat")]
        public string AspectFormat { get; set; }

        [JsonProperty("aspectMaxLength")]
        public int AspectMaxLength { get; set; }

        [JsonProperty("aspectMode")]
        public string AspectMode { get; set; }

        [JsonProperty("aspectRequired")]
        public bool AspectRequired { get; set; }

        [JsonProperty("aspectUsage")]
        public string AspectUsage { get; set; }

        [JsonProperty("expectedRequiredByDate")]
        public string ExpectedRequiredByDate { get; set; }

        [JsonProperty("itemToAspectCardinality")]
        public string ItemToAspectCardinality { get; set; }
    }

    public class GetItemAspectsResponseAspectsTypeItemAspectValuesTypeItem
    {
        [JsonProperty("localizedValue")]
        public string LocalizedValue { get; set; }

        [JsonProperty("valueConstraints")]
        public GetItemAspectsResponseAspectsTypeItemAspectValuesTypeItemValueConstraintsTypeItem[] ValueConstraints { get; set; }
    }

    public class GetItemAspectsResponseAspectsTypeItemAspectValuesTypeItemValueConstraintsTypeItem
    {
        [JsonProperty("applicableForLocalizedAspectName")]
        public string ApplicableForLocalizedAspectName { get; set; }

        [JsonProperty("applicableForLocalizedAspectValues")]
        public string[] ApplicableForLocalizedAspectValues { get; set; }
    }

    public class GetItemAspectsResponseAspectsTypeItemRelevanceIndicatorType
    {
        [JsonProperty("searchCount")]
        public int SearchCount { get; set; }
    }

    public class GetFulfillmentPoliciesResponse
    {
        [JsonProperty("fulfillmentPolicies")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItem[] FulfillmentPolicies { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItem
    {
        [JsonProperty("categoryTypes")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemCategoryTypesTypeItem[] CategoryTypes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("freightShipping")]
        public bool FreightShipping { get; set; }

        [JsonProperty("fulfillmentPolicyId")]
        public string FulfillmentPolicyId { get; set; }

        [JsonProperty("globalShipping")]
        public bool GlobalShipping { get; set; }

        [JsonProperty("handlingTime")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemHandlingTimeType HandlingTime { get; set; }

        [JsonProperty("localPickup")]
        public bool LocalPickup { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pickupDropOff")]
        public bool PickupDropOff { get; set; }

        [JsonProperty("shippingOptions")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItem[] ShippingOptions { get; set; }

        [JsonProperty("shipToLocations")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShipToLocationsType ShipToLocations { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemCategoryTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemHandlingTimeType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItem
    {
        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("insuranceFee")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemInsuranceFeeType InsuranceFee { get; set; }

        [JsonProperty("optionType")]
        public string OptionType { get; set; }

        [JsonProperty("packageHandlingCost")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemPackageHandlingCostType PackageHandlingCost { get; set; }

        [JsonProperty("rateTableId")]
        public string RateTableId { get; set; }

        [JsonProperty("shippingServices")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItem[] ShippingServices { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemInsuranceFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemPackageHandlingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItem
    {
        [JsonProperty("additionalShippingCost")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("buyerResponsibleForPickup")]
        public bool BuyerResponsibleForPickup { get; set; }

        [JsonProperty("buyerResponsibleForShipping")]
        public bool BuyerResponsibleForShipping { get; set; }

        [JsonProperty("cashOnDeliveryFee")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemCashOnDeliveryFeeType CashOnDeliveryFee { get; set; }

        [JsonProperty("freeShipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty("shippingCarrierCode")]
        public string ShippingCarrierCode { get; set; }

        [JsonProperty("shippingCost")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceCode")]
        public string ShippingServiceCode { get; set; }

        [JsonProperty("shipToLocations")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsType ShipToLocations { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }

        [JsonProperty("surcharge")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemSurchargeType Surcharge { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemCashOnDeliveryFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsType
    {
        [JsonProperty("regionExcluded")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionExcludedTypeItem[] RegionExcluded { get; set; }

        [JsonProperty("regionIncluded")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionIncludedTypeItem[] RegionIncluded { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionExcludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionIncludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShippingOptionsTypeItemShippingServicesTypeItemSurchargeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShipToLocationsType
    {
        [JsonProperty("regionExcluded")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShipToLocationsTypeRegionExcludedTypeItem[] RegionExcluded { get; set; }

        [JsonProperty("regionIncluded")]
        public GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShipToLocationsTypeRegionIncludedTypeItem[] RegionIncluded { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShipToLocationsTypeRegionExcludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPoliciesResponseFulfillmentPoliciesTypeItemShipToLocationsTypeRegionIncludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPolicyResponse
    {
        [JsonProperty("categoryTypes")]
        public GetFulfillmentPolicyResponseCategoryTypesTypeItem[] CategoryTypes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("freightShipping")]
        public bool FreightShipping { get; set; }

        [JsonProperty("fulfillmentPolicyId")]
        public string FulfillmentPolicyId { get; set; }

        [JsonProperty("globalShipping")]
        public bool GlobalShipping { get; set; }

        [JsonProperty("handlingTime")]
        public GetFulfillmentPolicyResponseHandlingTimeType HandlingTime { get; set; }

        [JsonProperty("localPickup")]
        public bool LocalPickup { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pickupDropOff")]
        public bool PickupDropOff { get; set; }

        [JsonProperty("shippingOptions")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItem[] ShippingOptions { get; set; }

        [JsonProperty("shipToLocations")]
        public GetFulfillmentPolicyResponseShipToLocationsType ShipToLocations { get; set; }
    }

    public class GetFulfillmentPolicyResponseCategoryTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetFulfillmentPolicyResponseHandlingTimeType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItem
    {
        [JsonProperty("costType")]
        public string CostType { get; set; }

        [JsonProperty("optionType")]
        public string OptionType { get; set; }

        [JsonProperty("packageHandlingCost")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemPackageHandlingCostType PackageHandlingCost { get; set; }

        [JsonProperty("rateTableId")]
        public string RateTableId { get; set; }

        [JsonProperty("shippingServices")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItem[] ShippingServices { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemPackageHandlingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItem
    {
        [JsonProperty("additionalShippingCost")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("buyerResponsibleForPickup")]
        public bool BuyerResponsibleForPickup { get; set; }

        [JsonProperty("buyerResponsibleForShipping")]
        public bool BuyerResponsibleForShipping { get; set; }

        [JsonProperty("cashOnDeliveryFee")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemCashOnDeliveryFeeType CashOnDeliveryFee { get; set; }

        [JsonProperty("freeShipping")]
        public bool FreeShipping { get; set; }

        [JsonProperty("shippingCarrierCode")]
        public string ShippingCarrierCode { get; set; }

        [JsonProperty("shippingCost")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceCode")]
        public string ShippingServiceCode { get; set; }

        [JsonProperty("shipToLocations")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsType ShipToLocations { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemCashOnDeliveryFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsType
    {
        [JsonProperty("regionExcluded")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionExcludedTypeItem[] RegionExcluded { get; set; }

        [JsonProperty("regionIncluded")]
        public GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionIncludedTypeItem[] RegionIncluded { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionExcludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPolicyResponseShippingOptionsTypeItemShippingServicesTypeItemShipToLocationsTypeRegionIncludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPolicyResponseShipToLocationsType
    {
        [JsonProperty("regionExcluded")]
        public GetFulfillmentPolicyResponseShipToLocationsTypeRegionExcludedTypeItem[] RegionExcluded { get; set; }

        [JsonProperty("regionIncluded")]
        public GetFulfillmentPolicyResponseShipToLocationsTypeRegionIncludedTypeItem[] RegionIncluded { get; set; }
    }

    public class GetFulfillmentPolicyResponseShipToLocationsTypeRegionExcludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetFulfillmentPolicyResponseShipToLocationsTypeRegionIncludedTypeItem
    {
        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("regionType")]
        public string RegionType { get; set; }
    }

    public class GetPaymentPolicyResponse
    {
        [JsonProperty("categoryTypes")]
        public GetPaymentPolicyResponseCategoryTypesTypeItem[] CategoryTypes { get; set; }

        [JsonProperty("deposit")]
        public GetPaymentPolicyResponseDepositType Deposit { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fullPaymentDueIn")]
        public GetPaymentPolicyResponseFullPaymentDueInType FullPaymentDueIn { get; set; }

        [JsonProperty("immediatePay")]
        public bool ImmediatePay { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("paymentInstructions")]
        public string PaymentInstructions { get; set; }

        [JsonProperty("paymentMethods")]
        public GetPaymentPolicyResponsePaymentMethodsTypeItem[] PaymentMethods { get; set; }

        [JsonProperty("paymentPolicyId")]
        public string PaymentPolicyId { get; set; }
    }

    public class GetPaymentPolicyResponseCategoryTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetPaymentPolicyResponseDepositType
    {
        [JsonProperty("amount")]
        public GetPaymentPolicyResponseDepositTypeAmountType Amount { get; set; }

        [JsonProperty("dueIn")]
        public GetPaymentPolicyResponseDepositTypeDueInType DueIn { get; set; }
    }

    public class GetPaymentPolicyResponseDepositTypeAmountType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPaymentPolicyResponseDepositTypeDueInType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetPaymentPolicyResponseFullPaymentDueInType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetPaymentPolicyResponsePaymentMethodsTypeItem
    {
        [JsonProperty("paymentMethodType")]
        public string PaymentMethodType { get; set; }
    }

    public class GetReturnPoliciesResponse
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("returnPolicies")]
        public GetReturnPoliciesResponseReturnPoliciesTypeItem[] ReturnPolicies { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetReturnPoliciesResponseReturnPoliciesTypeItem
    {
        [JsonProperty("categoryTypes")]
        public GetReturnPoliciesResponseReturnPoliciesTypeItemCategoryTypesTypeItem[] CategoryTypes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internationalOverride")]
        public GetReturnPoliciesResponseReturnPoliciesTypeItemInternationalOverrideType InternationalOverride { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refundMethod")]
        public string RefundMethod { get; set; }

        [JsonProperty("returnInstructions")]
        public string ReturnInstructions { get; set; }

        [JsonProperty("returnMethod")]
        public string ReturnMethod { get; set; }

        [JsonProperty("returnPeriod")]
        public GetReturnPoliciesResponseReturnPoliciesTypeItemReturnPeriodType ReturnPeriod { get; set; }

        [JsonProperty("returnPolicyId")]
        public string ReturnPolicyId { get; set; }

        [JsonProperty("returnsAccepted")]
        public bool ReturnsAccepted { get; set; }

        [JsonProperty("returnShippingCostPayer")]
        public string ReturnShippingCostPayer { get; set; }
    }

    public class GetReturnPoliciesResponseReturnPoliciesTypeItemCategoryTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetReturnPoliciesResponseReturnPoliciesTypeItemInternationalOverrideType
    {
        [JsonProperty("returnMethod")]
        public string ReturnMethod { get; set; }

        [JsonProperty("returnPeriod")]
        public GetReturnPoliciesResponseReturnPoliciesTypeItemInternationalOverrideTypeReturnPeriodType ReturnPeriod { get; set; }

        [JsonProperty("returnsAccepted")]
        public bool ReturnsAccepted { get; set; }

        [JsonProperty("returnShippingCostPayer")]
        public string ReturnShippingCostPayer { get; set; }
    }

    public class GetReturnPoliciesResponseReturnPoliciesTypeItemInternationalOverrideTypeReturnPeriodType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetReturnPoliciesResponseReturnPoliciesTypeItemReturnPeriodType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetReturnPolicyResponse
    {
        [JsonProperty("categoryTypes")]
        public GetReturnPolicyResponseCategoryTypesTypeItem[] CategoryTypes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internationalOverride")]
        public GetReturnPolicyResponseInternationalOverrideType InternationalOverride { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("refundMethod")]
        public string RefundMethod { get; set; }

        [JsonProperty("returnInstructions")]
        public string ReturnInstructions { get; set; }

        [JsonProperty("returnMethod")]
        public string ReturnMethod { get; set; }

        [JsonProperty("returnPeriod")]
        public GetReturnPolicyResponseReturnPeriodType ReturnPeriod { get; set; }

        [JsonProperty("returnPolicyId")]
        public string ReturnPolicyId { get; set; }

        [JsonProperty("returnsAccepted")]
        public bool ReturnsAccepted { get; set; }

        [JsonProperty("returnShippingCostPayer")]
        public string ReturnShippingCostPayer { get; set; }
    }

    public class GetReturnPolicyResponseCategoryTypesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetReturnPolicyResponseInternationalOverrideType
    {
        [JsonProperty("returnMethod")]
        public string ReturnMethod { get; set; }

        [JsonProperty("returnPeriod")]
        public GetReturnPolicyResponseInternationalOverrideTypeReturnPeriodType ReturnPeriod { get; set; }

        [JsonProperty("returnsAccepted")]
        public bool ReturnsAccepted { get; set; }

        [JsonProperty("returnShippingCostPayer")]
        public string ReturnShippingCostPayer { get; set; }
    }

    public class GetReturnPolicyResponseInternationalOverrideTypeReturnPeriodType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetReturnPolicyResponseReturnPeriodType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetInventoryItemResponse
    {
        [JsonProperty("availability")]
        public GetInventoryItemResponseAvailabilityType Availability { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("conditionDescription")]
        public string ConditionDescription { get; set; }

        [JsonProperty("groupIds")]
        public string[] GroupIds { get; set; }

        [JsonProperty("inventoryItemGroupKeys")]
        public string[] InventoryItemGroupKeys { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("packageWeightAndSize")]
        public GetInventoryItemResponsePackageWeightAndSizeType PackageWeightAndSize { get; set; }

        [JsonProperty("product")]
        public GetInventoryItemResponseProductType Product { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityType
    {
        [JsonProperty("pickupAtLocationAvailability")]
        public GetInventoryItemResponseAvailabilityTypePickupAtLocationAvailabilityTypeItem[] PickupAtLocationAvailability { get; set; }

        [JsonProperty("shipToLocationAvailability")]
        public GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityType ShipToLocationAvailability { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityTypePickupAtLocationAvailabilityTypeItem
    {
        [JsonProperty("availabilityType")]
        public string AvailabilityType { get; set; }

        [JsonProperty("fulfillmentTime")]
        public GetInventoryItemResponseAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityType
    {
        [JsonProperty("allocationByFormat")]
        public GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityTypeAllocationByFormatType AllocationByFormat { get; set; }

        [JsonProperty("availabilityDistributions")]
        public GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItem[] AvailabilityDistributions { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityTypeAllocationByFormatType
    {
        [JsonProperty("auction")]
        public int Auction { get; set; }

        [JsonProperty("fixedPrice")]
        public int FixedPrice { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItem
    {
        [JsonProperty("fulfillmentTime")]
        public GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetInventoryItemResponseAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetInventoryItemResponsePackageWeightAndSizeType
    {
        [JsonProperty("dimensions")]
        public GetInventoryItemResponsePackageWeightAndSizeTypeDimensionsType Dimensions { get; set; }

        [JsonProperty("packageType")]
        public string PackageType { get; set; }

        [JsonProperty("weight")]
        public GetInventoryItemResponsePackageWeightAndSizeTypeWeightType Weight { get; set; }
    }

    public class GetInventoryItemResponsePackageWeightAndSizeTypeDimensionsType
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    public class GetInventoryItemResponsePackageWeightAndSizeTypeWeightType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetInventoryItemResponseProductType
    {
        [JsonProperty("aspects")]
        public JToken Aspects { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ean")]
        public string[] Ean { get; set; }

        [JsonProperty("epid")]
        public string Epid { get; set; }

        [JsonProperty("imageUrls")]
        public string[] ImageUrls { get; set; }

        [JsonProperty("isbn")]
        public string[] Isbn { get; set; }

        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("upc")]
        public string[] Upc { get; set; }

        [JsonProperty("videoIds")]
        public string[] VideoIds { get; set; }
    }

    public class CreateOrReplaceInventoryItemResponse
    {
        [JsonProperty("warnings")]
        public CreateOrReplaceInventoryItemResponseWarningsTypeItem[] Warnings { get; set; }
    }

    public class CreateOrReplaceInventoryItemResponseWarningsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("inputRefIds")]
        public string[] InputRefIds { get; set; }

        [JsonProperty("longMessage")]
        public string LongMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("outputRefIds")]
        public string[] OutputRefIds { get; set; }

        [JsonProperty("parameters")]
        public CreateOrReplaceInventoryItemResponseWarningsTypeItemParametersTypeItem[] Parameters { get; set; }

        [JsonProperty("subdomain")]
        public JToken Subdomain { get; set; }
    }

    public class CreateOrReplaceInventoryItemResponseWarningsTypeItemParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOrReplaceInventoryItemInput
    {
        [JsonProperty("availability")]
        public CreateOrReplaceInventoryItemInputAvailabilityType Availability { get; set; }

        [JsonProperty("condition")]
        public CreateOrReplaceInventoryItemInputConditionType? Condition { get; set; }

        [JsonProperty("conditionDescription")]
        public string ConditionDescription { get; set; }

        [JsonProperty("packageWeightAndSize")]
        public CreateOrReplaceInventoryItemInputPackageWeightAndSizeType PackageWeightAndSize { get; set; }

        [JsonProperty("product")]
        public CreateOrReplaceInventoryItemInputProductType Product { get; set; }
    }

    public class CreateOrReplaceInventoryItemInputAvailabilityType
    {
        [JsonProperty("pickupAtLocationAvailability")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItem[] PickupAtLocationAvailability { get; set; }

        [JsonProperty("shipToLocationAvailability")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityType ShipToLocationAvailability { get; set; }
    }

    public class CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItem
    {
        [JsonProperty("availabilityType")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItemAvailabilityTypeType? AvailabilityType { get; set; }

        [JsonProperty("fulfillmentTime")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItemAvailabilityTypeType
    {
        [EnumMember(Value = "IN_STOCK")]
        INSTOCK,
        [EnumMember(Value = "OUT_OF_STOCK")]
        OUTOFSTOCK,
        [EnumMember(Value = "SHIP_TO_STORE")]
        SHIPTOSTORE
    }

    public class CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeTypeUnitType? Unit { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeTypeUnitType
    {
        YEAR,
        MONTH,
        DAY,
        HOUR,
        [EnumMember(Value = "CALENDAR_DAY")]
        CALENDARDAY,
        [EnumMember(Value = "BUSINESS_DAY")]
        BUSINESSDAY,
        MINUTE,
        SECOND,
        MILLISECOND
    }

    public class CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityType
    {
        [JsonProperty("availabilityDistributions")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItem[] AvailabilityDistributions { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }

    public class CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItem
    {
        [JsonProperty("fulfillmentTime")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }
    }

    public class CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeTypeUnitType? Unit { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeTypeUnitType
    {
        YEAR,
        MONTH,
        DAY,
        HOUR,
        [EnumMember(Value = "CALENDAR_DAY")]
        CALENDARDAY,
        [EnumMember(Value = "BUSINESS_DAY")]
        BUSINESSDAY,
        MINUTE,
        SECOND,
        MILLISECOND
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputConditionType
    {
        NEW,
        [EnumMember(Value = "LIKE_NEW")]
        LIKENEW,
        [EnumMember(Value = "NEW_OTHER")]
        NEWOTHER,
        [EnumMember(Value = "NEW_WITH_DEFECTS")]
        NEWWITHDEFECTS,
        [EnumMember(Value = "MANUFACTURER_REFURBISHED")]
        MANUFACTURERREFURBISHED,
        [EnumMember(Value = "CERTIFIED_REFURBISHED")]
        CERTIFIEDREFURBISHED,
        [EnumMember(Value = "EXCELLENT_REFURBISHED")]
        EXCELLENTREFURBISHED,
        [EnumMember(Value = "VERY_GOOD_REFURBISHED")]
        VERYGOODREFURBISHED,
        [EnumMember(Value = "GOOD_REFURBISHED")]
        GOODREFURBISHED,
        [EnumMember(Value = "SELLER_REFURBISHED")]
        SELLERREFURBISHED,
        [EnumMember(Value = "USED_EXCELLENT")]
        USEDEXCELLENT,
        [EnumMember(Value = "USED_VERY_GOOD")]
        USEDVERYGOOD,
        [EnumMember(Value = "USED_GOOD")]
        USEDGOOD,
        [EnumMember(Value = "USED_ACCEPTABLE")]
        USEDACCEPTABLE,
        [EnumMember(Value = "FOR_PARTS_OR_NOT_WORKING")]
        FORPARTSORNOTWORKING
    }

    public class CreateOrReplaceInventoryItemInputPackageWeightAndSizeType
    {
        [JsonProperty("dimensions")]
        public CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeDimensionsType Dimensions { get; set; }

        [JsonProperty("packageType")]
        public CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypePackageTypeType? PackageType { get; set; }

        [JsonProperty("weight")]
        public CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeWeightType Weight { get; set; }
    }

    public class CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeDimensionsType
    {
        [JsonProperty("height")]
        public double? Height { get; set; }

        [JsonProperty("length")]
        public double? Length { get; set; }

        [JsonProperty("unit")]
        public CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeDimensionsTypeUnitType? Unit { get; set; }

        [JsonProperty("width")]
        public double? Width { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeDimensionsTypeUnitType
    {
        INCH,
        FEET,
        CENTIMETER,
        METER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypePackageTypeType
    {
        LETTER,
        [EnumMember(Value = "BULKY_GOODS")]
        BULKYGOODS,
        CARAVAN,
        CARS,
        EUROPALLET,
        [EnumMember(Value = "EXPANDABLE_TOUGH_BAGS")]
        EXPANDABLETOUGHBAGS,
        [EnumMember(Value = "EXTRA_LARGE_PACK")]
        EXTRALARGEPACK,
        FURNITURE,
        [EnumMember(Value = "INDUSTRY_VEHICLES")]
        INDUSTRYVEHICLES,
        [EnumMember(Value = "LARGE_CANADA_POSTBOX")]
        LARGECANADAPOSTBOX,
        [EnumMember(Value = "LARGE_CANADA_POST_BUBBLE_MAILER")]
        LARGECANADAPOSTBUBBLEMAILER,
        [EnumMember(Value = "LARGE_ENVELOPE")]
        LARGEENVELOPE,
        [EnumMember(Value = "MAILING_BOX")]
        MAILINGBOX,
        [EnumMember(Value = "MEDIUM_CANADA_POST_BOX")]
        MEDIUMCANADAPOSTBOX,
        [EnumMember(Value = "MEDIUM_CANADA_POST_BUBBLE_MAILER")]
        MEDIUMCANADAPOSTBUBBLEMAILER,
        MOTORBIKES,
        [EnumMember(Value = "ONE_WAY_PALLET")]
        ONEWAYPALLET,
        [EnumMember(Value = "PACKAGE_THICK_ENVELOPE")]
        PACKAGETHICKENVELOPE,
        [EnumMember(Value = "PADDED_BAGS")]
        PADDEDBAGS,
        [EnumMember(Value = "PARCEL_OR_PADDED_ENVELOPE")]
        PARCELORPADDEDENVELOPE,
        ROLL,
        [EnumMember(Value = "SMALL_CANADA_POST_BOX")]
        SMALLCANADAPOSTBOX,
        [EnumMember(Value = "TOUGH_BAGS")]
        TOUGHBAGS,
        [EnumMember(Value = "UPS_LETTER")]
        UPSLETTER,
        [EnumMember(Value = "USPS_FLAT_RATE_ENVELOPE")]
        USPSFLATRATEENVELOPE,
        [EnumMember(Value = "USPS_LARGE_PACK")]
        USPSLARGEPACK,
        [EnumMember(Value = "VERY_LARGE_PACK")]
        VERYLARGEPACK,
        [EnumMember(Value = "WINE_PAK")]
        WINEPAK
    }

    public class CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeWeightType
    {
        [JsonProperty("unit")]
        public CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeWeightTypeUnitType? Unit { get; set; }

        [JsonProperty("value")]
        public double? Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOrReplaceInventoryItemInputPackageWeightAndSizeTypeWeightTypeUnitType
    {
        POUND,
        KILOGRAM,
        OUNCE,
        GRAM
    }

    public class CreateOrReplaceInventoryItemInputProductType
    {
        [JsonProperty("aspects")]
        public JToken Aspects { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ean")]
        public string[] Ean { get; set; }

        [JsonProperty("epid")]
        public string Epid { get; set; }

        [JsonProperty("imageUrls")]
        public string[] ImageUrls { get; set; }

        [JsonProperty("isbn")]
        public string[] Isbn { get; set; }

        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("upc")]
        public string[] Upc { get; set; }

        [JsonProperty("videoIds")]
        public string[] VideoIds { get; set; }
    }

    public class GetInventoryItemsResponse
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("inventoryItems")]
        public GetInventoryItemsResponseInventoryItemsTypeItem[] InventoryItems { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItem
    {
        [JsonProperty("availability")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityType Availability { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("conditionDescription")]
        public string ConditionDescription { get; set; }

        [JsonProperty("groupIds")]
        public string[] GroupIds { get; set; }

        [JsonProperty("inventoryItemGroupKeys")]
        public string[] InventoryItemGroupKeys { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("packageWeightAndSize")]
        public GetInventoryItemsResponseInventoryItemsTypeItemPackageWeightAndSizeType PackageWeightAndSize { get; set; }

        [JsonProperty("product")]
        public GetInventoryItemsResponseInventoryItemsTypeItemProductType Product { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityType
    {
        [JsonProperty("pickupAtLocationAvailability")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypePickupAtLocationAvailabilityTypeItem[] PickupAtLocationAvailability { get; set; }

        [JsonProperty("shipToLocationAvailability")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityType ShipToLocationAvailability { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypePickupAtLocationAvailabilityTypeItem
    {
        [JsonProperty("availabilityType")]
        public string AvailabilityType { get; set; }

        [JsonProperty("fulfillmentTime")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypePickupAtLocationAvailabilityTypeItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityType
    {
        [JsonProperty("allocationByFormat")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityTypeAllocationByFormatType AllocationByFormat { get; set; }

        [JsonProperty("availabilityDistributions")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItem[] AvailabilityDistributions { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityTypeAllocationByFormatType
    {
        [JsonProperty("auction")]
        public int Auction { get; set; }

        [JsonProperty("fixedPrice")]
        public int FixedPrice { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItem
    {
        [JsonProperty("fulfillmentTime")]
        public GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemAvailabilityTypeShipToLocationAvailabilityTypeAvailabilityDistributionsTypeItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemPackageWeightAndSizeType
    {
        [JsonProperty("dimensions")]
        public GetInventoryItemsResponseInventoryItemsTypeItemPackageWeightAndSizeTypeDimensionsType Dimensions { get; set; }

        [JsonProperty("packageType")]
        public string PackageType { get; set; }

        [JsonProperty("weight")]
        public GetInventoryItemsResponseInventoryItemsTypeItemPackageWeightAndSizeTypeWeightType Weight { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemPackageWeightAndSizeTypeDimensionsType
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemPackageWeightAndSizeTypeWeightType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetInventoryItemsResponseInventoryItemsTypeItemProductType
    {
        [JsonProperty("aspects")]
        public JToken Aspects { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ean")]
        public string[] Ean { get; set; }

        [JsonProperty("epid")]
        public string Epid { get; set; }

        [JsonProperty("imageUrls")]
        public string[] ImageUrls { get; set; }

        [JsonProperty("isbn")]
        public string[] Isbn { get; set; }

        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("upc")]
        public string[] Upc { get; set; }

        [JsonProperty("videoIds")]
        public string[] VideoIds { get; set; }
    }

    public class GetInventoryLocationResponse
    {
        [JsonProperty("location")]
        public GetInventoryLocationResponseLocationType Location { get; set; }

        [JsonProperty("locationAdditionalInformation")]
        public string LocationAdditionalInformation { get; set; }

        [JsonProperty("locationInstructions")]
        public string LocationInstructions { get; set; }

        [JsonProperty("locationTypes")]
        public string[] LocationTypes { get; set; }

        [JsonProperty("locationWebUrl")]
        public string LocationWebUrl { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("merchantLocationStatus")]
        public string MerchantLocationStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operatingHours")]
        public GetInventoryLocationResponseOperatingHoursTypeItem[] OperatingHours { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("specialHours")]
        public GetInventoryLocationResponseSpecialHoursTypeItem[] SpecialHours { get; set; }
    }

    public class GetInventoryLocationResponseLocationType
    {
        [JsonProperty("address")]
        public GetInventoryLocationResponseLocationTypeAddressType Address { get; set; }

        [JsonProperty("geoCoordinates")]
        public GetInventoryLocationResponseLocationTypeGeoCoordinatesType GeoCoordinates { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }
    }

    public class GetInventoryLocationResponseLocationTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("stateOrProvince")]
        public string StateOrProvince { get; set; }
    }

    public class GetInventoryLocationResponseLocationTypeGeoCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class GetInventoryLocationResponseOperatingHoursTypeItem
    {
        [JsonProperty("dayOfWeekEnum")]
        public string DayOfWeekEnum { get; set; }

        [JsonProperty("intervals")]
        public GetInventoryLocationResponseOperatingHoursTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class GetInventoryLocationResponseOperatingHoursTypeItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class GetInventoryLocationResponseSpecialHoursTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("intervals")]
        public GetInventoryLocationResponseSpecialHoursTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class GetInventoryLocationResponseSpecialHoursTypeItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class CreateInventoryLocationInput
    {
        [JsonProperty("location")]
        public CreateInventoryLocationInputLocationType Location { get; set; }

        [JsonProperty("locationAdditionalInformation")]
        public string LocationAdditionalInformation { get; set; }

        [JsonProperty("locationInstructions")]
        public string LocationInstructions { get; set; }

        [JsonProperty("locationTypes")]
        public CreateInventoryLocationInputLocationTypesTypeItem[] LocationTypes { get; set; }

        [JsonProperty("locationWebUrl")]
        public string LocationWebUrl { get; set; }

        [JsonProperty("merchantLocationStatus")]
        public string MerchantLocationStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operatingHours")]
        public CreateInventoryLocationInputOperatingHoursTypeItem[] OperatingHours { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("specialHours")]
        public CreateInventoryLocationInputSpecialHoursTypeItem[] SpecialHours { get; set; }
    }

    public class CreateInventoryLocationInputLocationType
    {
        [JsonProperty("address")]
        public CreateInventoryLocationInputLocationTypeAddressType Address { get; set; }

        [JsonProperty("geoCoordinates")]
        public CreateInventoryLocationInputLocationTypeGeoCoordinatesType GeoCoordinates { get; set; }
    }

    public class CreateInventoryLocationInputLocationTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("stateOrProvince")]
        public string StateOrProvince { get; set; }
    }

    public class CreateInventoryLocationInputLocationTypeGeoCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateInventoryLocationInputLocationTypesTypeItem
    {
        STORE,
        WAREHOUSE
    }

    public class CreateInventoryLocationInputOperatingHoursTypeItem
    {
        [JsonProperty("dayOfWeekEnum")]
        public CreateInventoryLocationInputOperatingHoursTypeItemDayOfWeekEnumType? DayOfWeekEnum { get; set; }

        [JsonProperty("intervals")]
        public CreateInventoryLocationInputOperatingHoursTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateInventoryLocationInputOperatingHoursTypeItemDayOfWeekEnumType
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        [EnumMember(Value = "FRIDAY")]
        FRIdAY,
        SATURDAY,
        SUNDAY
    }

    public class CreateInventoryLocationInputOperatingHoursTypeItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class CreateInventoryLocationInputSpecialHoursTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("intervals")]
        public CreateInventoryLocationInputSpecialHoursTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class CreateInventoryLocationInputSpecialHoursTypeItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class GetInventoryLocationsResponse
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offset")]
        public string Offset { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("locations")]
        public GetInventoryLocationsResponseLocationsTypeItem[] Locations { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItem
    {
        [JsonProperty("location")]
        public GetInventoryLocationsResponseLocationsTypeItemLocationType Location { get; set; }

        [JsonProperty("locationAdditionalInformation")]
        public string LocationAdditionalInformation { get; set; }

        [JsonProperty("locationInstructions")]
        public string LocationInstructions { get; set; }

        [JsonProperty("locationTypes")]
        public string[] LocationTypes { get; set; }

        [JsonProperty("locationWebUrl")]
        public string LocationWebUrl { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("merchantLocationStatus")]
        public string MerchantLocationStatus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operatingHours")]
        public GetInventoryLocationsResponseLocationsTypeItemOperatingHoursTypeItem[] OperatingHours { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("specialHours")]
        public GetInventoryLocationsResponseLocationsTypeItemSpecialHoursTypeItem[] SpecialHours { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemLocationType
    {
        [JsonProperty("address")]
        public GetInventoryLocationsResponseLocationsTypeItemLocationTypeAddressType Address { get; set; }

        [JsonProperty("geoCoordinates")]
        public GetInventoryLocationsResponseLocationsTypeItemLocationTypeGeoCoordinatesType GeoCoordinates { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemLocationTypeAddressType
    {
        [JsonProperty("addressLine1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("stateOrProvince")]
        public string StateOrProvince { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemLocationTypeGeoCoordinatesType
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemOperatingHoursTypeItem
    {
        [JsonProperty("dayOfWeekEnum")]
        public string DayOfWeekEnum { get; set; }

        [JsonProperty("intervals")]
        public GetInventoryLocationsResponseLocationsTypeItemOperatingHoursTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemOperatingHoursTypeItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemSpecialHoursTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("intervals")]
        public GetInventoryLocationsResponseLocationsTypeItemSpecialHoursTypeItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class GetInventoryLocationsResponseLocationsTypeItemSpecialHoursTypeItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class GetItemConditionPoliciesResponse
    {
        [JsonProperty("itemConditionPolicies")]
        public GetItemConditionPoliciesResponseItemConditionPoliciesTypeItem[] ItemConditionPolicies { get; set; }

        [JsonProperty("warnings")]
        public GetItemConditionPoliciesResponseWarningsTypeItem[] Warnings { get; set; }
    }

    public class GetItemConditionPoliciesResponseItemConditionPoliciesTypeItem
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categoryTreeId")]
        public string CategoryTreeId { get; set; }

        [JsonProperty("itemConditionRequired")]
        public bool ItemConditionRequired { get; set; }

        [JsonProperty("itemConditions")]
        public GetItemConditionPoliciesResponseItemConditionPoliciesTypeItemItemConditionsTypeItem[] ItemConditions { get; set; }
    }

    public class GetItemConditionPoliciesResponseItemConditionPoliciesTypeItemItemConditionsTypeItem
    {
        [JsonProperty("conditionDescription")]
        public string ConditionDescription { get; set; }

        [JsonProperty("conditionId")]
        public string ConditionId { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }
    }

    public class GetItemConditionPoliciesResponseWarningsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("inputRefIds")]
        public string[] InputRefIds { get; set; }

        [JsonProperty("longMessage")]
        public string LongMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("outputRefIds")]
        public string[] OutputRefIds { get; set; }

        [JsonProperty("parameters")]
        public GetItemConditionPoliciesResponseWarningsTypeItemParametersTypeItem[] Parameters { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }
    }

    public class GetItemConditionPoliciesResponseWarningsTypeItemParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponse
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("offers")]
        public GetOffersResponseOffersTypeItem[] Offers { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class GetOffersResponseOffersTypeItem
    {
        [JsonProperty("availableQuantity")]
        public int AvailableQuantity { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("charity")]
        public GetOffersResponseOffersTypeItemCharityType Charity { get; set; }

        [JsonProperty("extendedProducerResponsibility")]
        public GetOffersResponseOffersTypeItemExtendedProducerResponsibilityType ExtendedProducerResponsibility { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("hideBuyerDetails")]
        public bool HideBuyerDetails { get; set; }

        [JsonProperty("includeCatalogProductDetails")]
        public bool IncludeCatalogProductDetails { get; set; }

        [JsonProperty("listing")]
        public GetOffersResponseOffersTypeItemListingType Listing { get; set; }

        [JsonProperty("listingDescription")]
        public string ListingDescription { get; set; }

        [JsonProperty("listingDuration")]
        public string ListingDuration { get; set; }

        [JsonProperty("listingPolicies")]
        public GetOffersResponseOffersTypeItemListingPoliciesType ListingPolicies { get; set; }

        [JsonProperty("listingStartDate")]
        public string ListingStartDate { get; set; }

        [JsonProperty("lotSize")]
        public int LotSize { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("pricingSummary")]
        public GetOffersResponseOffersTypeItemPricingSummaryType PricingSummary { get; set; }

        [JsonProperty("quantityLimitPerBuyer")]
        public int QuantityLimitPerBuyer { get; set; }

        [JsonProperty("secondaryCategoryId")]
        public string SecondaryCategoryId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("storeCategoryNames")]
        public string[] StoreCategoryNames { get; set; }

        [JsonProperty("tax")]
        public GetOffersResponseOffersTypeItemTaxType Tax { get; set; }
    }

    public class GetOffersResponseOffersTypeItemCharityType
    {
        [JsonProperty("charityId")]
        public string CharityId { get; set; }

        [JsonProperty("donationPercentage")]
        public string DonationPercentage { get; set; }
    }

    public class GetOffersResponseOffersTypeItemExtendedProducerResponsibilityType
    {
        [JsonProperty("producerProductId")]
        public string ProducerProductId { get; set; }

        [JsonProperty("productPackageId")]
        public string ProductPackageId { get; set; }

        [JsonProperty("shipmentPackageId")]
        public string ShipmentPackageId { get; set; }

        [JsonProperty("productDocumentationId")]
        public string ProductDocumentationId { get; set; }

        [JsonProperty("ecoParticipationFee")]
        public GetOffersResponseOffersTypeItemExtendedProducerResponsibilityTypeEcoParticipationFeeType EcoParticipationFee { get; set; }
    }

    public class GetOffersResponseOffersTypeItemExtendedProducerResponsibilityTypeEcoParticipationFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingType
    {
        [JsonProperty("listingId")]
        public string ListingId { get; set; }

        [JsonProperty("listingStatus")]
        public string ListingStatus { get; set; }

        [JsonProperty("soldQuantity")]
        public int SoldQuantity { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesType
    {
        [JsonProperty("bestOfferTerms")]
        public GetOffersResponseOffersTypeItemListingPoliciesTypeBestOfferTermsType BestOfferTerms { get; set; }

        [JsonProperty("eBayPlusIfEligible")]
        public bool EBayPlusIfEligible { get; set; }

        [JsonProperty("fulfillmentPolicyId")]
        public string FulfillmentPolicyId { get; set; }

        [JsonProperty("paymentPolicyId")]
        public string PaymentPolicyId { get; set; }

        [JsonProperty("productCompliancePolicyIds")]
        public string[] ProductCompliancePolicyIds { get; set; }

        [JsonProperty("returnPolicyId")]
        public string ReturnPolicyId { get; set; }

        [JsonProperty("shippingCostOverrides")]
        public GetOffersResponseOffersTypeItemListingPoliciesTypeShippingCostOverridesTypeItem[] ShippingCostOverrides { get; set; }

        [JsonProperty("takeBackPolicyId")]
        public string TakeBackPolicyId { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesTypeBestOfferTermsType
    {
        [JsonProperty("autoAcceptPrice")]
        public GetOffersResponseOffersTypeItemListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType AutoAcceptPrice { get; set; }

        [JsonProperty("autoDeclinePrice")]
        public GetOffersResponseOffersTypeItemListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType AutoDeclinePrice { get; set; }

        [JsonProperty("bestOfferEnabled")]
        public bool BestOfferEnabled { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesTypeShippingCostOverridesTypeItem
    {
        [JsonProperty("additionalShippingCost")]
        public GetOffersResponseOffersTypeItemListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("shippingCost")]
        public GetOffersResponseOffersTypeItemListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceType")]
        public string ShippingServiceType { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemPricingSummaryType
    {
        [JsonProperty("auctionReservePrice")]
        public GetOffersResponseOffersTypeItemPricingSummaryTypeAuctionReservePriceType AuctionReservePrice { get; set; }

        [JsonProperty("auctionStartPrice")]
        public GetOffersResponseOffersTypeItemPricingSummaryTypeAuctionStartPriceType AuctionStartPrice { get; set; }

        [JsonProperty("minimumAdvertisedPrice")]
        public GetOffersResponseOffersTypeItemPricingSummaryTypeMinimumAdvertisedPriceType MinimumAdvertisedPrice { get; set; }

        [JsonProperty("originallySoldForRetailPriceOn")]
        public string OriginallySoldForRetailPriceOn { get; set; }

        [JsonProperty("originalRetailPrice")]
        public GetOffersResponseOffersTypeItemPricingSummaryTypeOriginalRetailPriceType OriginalRetailPrice { get; set; }

        [JsonProperty("price")]
        public GetOffersResponseOffersTypeItemPricingSummaryTypePriceType Price { get; set; }

        [JsonProperty("pricingVisibility")]
        public string PricingVisibility { get; set; }
    }

    public class GetOffersResponseOffersTypeItemPricingSummaryTypeAuctionReservePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemPricingSummaryTypeAuctionStartPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemPricingSummaryTypeMinimumAdvertisedPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemPricingSummaryTypeOriginalRetailPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemPricingSummaryTypePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOffersResponseOffersTypeItemTaxType
    {
        [JsonProperty("applyTax")]
        public bool ApplyTax { get; set; }

        [JsonProperty("thirdPartyTaxCategory")]
        public string ThirdPartyTaxCategory { get; set; }

        [JsonProperty("vatPercentage")]
        public double VatPercentage { get; set; }
    }

    public class CreateOfferResponse
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("warnings")]
        public CreateOfferResponseWarningsTypeItem[] Warnings { get; set; }
    }

    public class CreateOfferResponseWarningsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("inputRefIds")]
        public string[] InputRefIds { get; set; }

        [JsonProperty("longMessage")]
        public string LongMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("outputRefIds")]
        public string[] OutputRefIds { get; set; }

        [JsonProperty("parameters")]
        public CreateOfferResponseWarningsTypeItemParametersTypeItem[] Parameters { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }
    }

    public class CreateOfferResponseWarningsTypeItemParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInput
    {
        [JsonProperty("availableQuantity")]
        public int? AvailableQuantity { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("charity")]
        public CreateOfferInputCharityType Charity { get; set; }

        [JsonProperty("extendedProducerResponsibility")]
        public CreateOfferInputExtendedProducerResponsibilityType ExtendedProducerResponsibility { get; set; }

        [JsonProperty("format")]
        public CreateOfferInputFormatType? Format { get; set; }

        [JsonProperty("hideBuyerDetails")]
        public bool? HideBuyerDetails { get; set; }

        [JsonProperty("includeCatalogProductDetails")]
        public bool? IncludeCatalogProductDetails { get; set; }

        [JsonProperty("listingDescription")]
        public string ListingDescription { get; set; }

        [JsonProperty("listingDuration")]
        public CreateOfferInputListingDurationType? ListingDuration { get; set; }

        [JsonProperty("listingPolicies")]
        public CreateOfferInputListingPoliciesType ListingPolicies { get; set; }

        [JsonProperty("listingStartDate")]
        public string ListingStartDate { get; set; }

        [JsonProperty("lotSize")]
        public int? LotSize { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("pricingSummary")]
        public CreateOfferInputPricingSummaryType PricingSummary { get; set; }

        [JsonProperty("quantityLimitPerBuyer")]
        public int? QuantityLimitPerBuyer { get; set; }

        [JsonProperty("secondaryCategoryId")]
        public string SecondaryCategoryId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("storeCategoryNames")]
        public string[] StoreCategoryNames { get; set; }

        [JsonProperty("tax")]
        public CreateOfferInputTaxType Tax { get; set; }
    }

    public class CreateOfferInputCharityType
    {
        [JsonProperty("charityId")]
        public string CharityId { get; set; }

        [JsonProperty("donationPercentage")]
        public string DonationPercentage { get; set; }
    }

    public class CreateOfferInputExtendedProducerResponsibilityType
    {
        [JsonProperty("producerProductId")]
        public string ProducerProductId { get; set; }

        [JsonProperty("productPackageId")]
        public string ProductPackageId { get; set; }

        [JsonProperty("shipmentPackageId")]
        public string ShipmentPackageId { get; set; }

        [JsonProperty("productDocumentationId")]
        public string ProductDocumentationId { get; set; }

        [JsonProperty("ecoParticipationFee")]
        public CreateOfferInputExtendedProducerResponsibilityTypeEcoParticipationFeeType EcoParticipationFee { get; set; }
    }

    public class CreateOfferInputExtendedProducerResponsibilityTypeEcoParticipationFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOfferInputFormatType
    {
        AUCTION,
        [EnumMember(Value = "FIXED_PRICE")]
        FIXEDPRICE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOfferInputListingDurationType
    {
        [EnumMember(Value = "DAYS_1")]
        DAYS1,
        [EnumMember(Value = "DAYS_3")]
        DAYS3,
        [EnumMember(Value = "DAYS_5")]
        DAYS5,
        [EnumMember(Value = "DAYS_7")]
        DAYS7,
        [EnumMember(Value = "DAYS_10")]
        DAYS10,
        [EnumMember(Value = "DAYS_21")]
        DAYS21,
        [EnumMember(Value = "DAYS_30")]
        DAYS30,
        GTC
    }

    public class CreateOfferInputListingPoliciesType
    {
        [JsonProperty("bestOfferTerms")]
        public CreateOfferInputListingPoliciesTypeBestOfferTermsType BestOfferTerms { get; set; }

        [JsonProperty("eBayPlusIfEligible")]
        public bool? EBayPlusIfEligible { get; set; }

        [JsonProperty("fulfillmentPolicyId")]
        public string FulfillmentPolicyId { get; set; }

        [JsonProperty("paymentPolicyId")]
        public string PaymentPolicyId { get; set; }

        [JsonProperty("productCompliancePolicyIds")]
        public string[] ProductCompliancePolicyIds { get; set; }

        [JsonProperty("returnPolicyId")]
        public string ReturnPolicyId { get; set; }

        [JsonProperty("shippingCostOverrides")]
        public CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItem[] ShippingCostOverrides { get; set; }

        [JsonProperty("takeBackPolicyId")]
        public string TakeBackPolicyId { get; set; }
    }

    public class CreateOfferInputListingPoliciesTypeBestOfferTermsType
    {
        [JsonProperty("autoAcceptPrice")]
        public CreateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType AutoAcceptPrice { get; set; }

        [JsonProperty("autoDeclinePrice")]
        public CreateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType AutoDeclinePrice { get; set; }

        [JsonProperty("bestOfferEnabled")]
        public bool? BestOfferEnabled { get; set; }
    }

    public class CreateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItem
    {
        [JsonProperty("additionalShippingCost")]
        public CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("shippingCost")]
        public CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceType")]
        public CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingServiceTypeType? ShippingServiceType { get; set; }
    }

    public class CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingServiceTypeType
    {
        DOMESTIC,
        INTERNATIONAL
    }

    public class CreateOfferInputPricingSummaryType
    {
        [JsonProperty("auctionReservePrice")]
        public CreateOfferInputPricingSummaryTypeAuctionReservePriceType AuctionReservePrice { get; set; }

        [JsonProperty("auctionStartPrice")]
        public CreateOfferInputPricingSummaryTypeAuctionStartPriceType AuctionStartPrice { get; set; }

        [JsonProperty("minimumAdvertisedPrice")]
        public CreateOfferInputPricingSummaryTypeMinimumAdvertisedPriceType MinimumAdvertisedPrice { get; set; }

        [JsonProperty("originallySoldForRetailPriceOn")]
        public CreateOfferInputPricingSummaryTypeOriginallySoldForRetailPriceOnType? OriginallySoldForRetailPriceOn { get; set; }

        [JsonProperty("originalRetailPrice")]
        public CreateOfferInputPricingSummaryTypeOriginalRetailPriceType OriginalRetailPrice { get; set; }

        [JsonProperty("price")]
        public CreateOfferInputPricingSummaryTypePriceType Price { get; set; }

        [JsonProperty("pricingVisibility")]
        public CreateOfferInputPricingSummaryTypePricingVisibilityType? PricingVisibility { get; set; }
    }

    public class CreateOfferInputPricingSummaryTypeAuctionReservePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInputPricingSummaryTypeAuctionStartPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInputPricingSummaryTypeMinimumAdvertisedPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOfferInputPricingSummaryTypeOriginallySoldForRetailPriceOnType
    {
        [EnumMember(Value = "ON_EBAY")]
        ONEBAY,
        [EnumMember(Value = "OFF_EBAY")]
        OFFEBAY,
        [EnumMember(Value = "ON_AND_OFF_EBAY")]
        ONANDOFFEBAY
    }

    public class CreateOfferInputPricingSummaryTypeOriginalRetailPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateOfferInputPricingSummaryTypePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOfferInputPricingSummaryTypePricingVisibilityType
    {
        NONE,
        [EnumMember(Value = "PRE_CHECKOUT")]
        PRECHECKOUT,
        [EnumMember(Value = "DURING_CHECKOUT")]
        DURINGCHECKOUT
    }

    public class CreateOfferInputTaxType
    {
        [JsonProperty("applyTax")]
        public bool? ApplyTax { get; set; }

        [JsonProperty("thirdPartyTaxCategory")]
        public string ThirdPartyTaxCategory { get; set; }

        [JsonProperty("vatPercentage")]
        public double? VatPercentage { get; set; }
    }

    public class GetOfferResponse
    {
        [JsonProperty("availableQuantity")]
        public int AvailableQuantity { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("charity")]
        public GetOfferResponseCharityType Charity { get; set; }

        [JsonProperty("extendedProducerResponsibility")]
        public GetOfferResponseExtendedProducerResponsibilityType ExtendedProducerResponsibility { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("hideBuyerDetails")]
        public bool HideBuyerDetails { get; set; }

        [JsonProperty("includeCatalogProductDetails")]
        public bool IncludeCatalogProductDetails { get; set; }

        [JsonProperty("listing")]
        public GetOfferResponseListingType Listing { get; set; }

        [JsonProperty("listingDescription")]
        public string ListingDescription { get; set; }

        [JsonProperty("listingDuration")]
        public string ListingDuration { get; set; }

        [JsonProperty("listingPolicies")]
        public GetOfferResponseListingPoliciesType ListingPolicies { get; set; }

        [JsonProperty("listingStartDate")]
        public string ListingStartDate { get; set; }

        [JsonProperty("lotSize")]
        public int LotSize { get; set; }

        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("pricingSummary")]
        public GetOfferResponsePricingSummaryType PricingSummary { get; set; }

        [JsonProperty("quantityLimitPerBuyer")]
        public int QuantityLimitPerBuyer { get; set; }

        [JsonProperty("secondaryCategoryId")]
        public string SecondaryCategoryId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("storeCategoryNames")]
        public string[] StoreCategoryNames { get; set; }

        [JsonProperty("tax")]
        public GetOfferResponseTaxType Tax { get; set; }
    }

    public class GetOfferResponseCharityType
    {
        [JsonProperty("charityId")]
        public string CharityId { get; set; }

        [JsonProperty("donationPercentage")]
        public string DonationPercentage { get; set; }
    }

    public class GetOfferResponseExtendedProducerResponsibilityType
    {
        [JsonProperty("producerProductId")]
        public string ProducerProductId { get; set; }

        [JsonProperty("productPackageId")]
        public string ProductPackageId { get; set; }

        [JsonProperty("shipmentPackageId")]
        public string ShipmentPackageId { get; set; }

        [JsonProperty("productDocumentationId")]
        public string ProductDocumentationId { get; set; }

        [JsonProperty("ecoParticipationFee")]
        public GetOfferResponseExtendedProducerResponsibilityTypeEcoParticipationFeeType EcoParticipationFee { get; set; }
    }

    public class GetOfferResponseExtendedProducerResponsibilityTypeEcoParticipationFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponseListingType
    {
        [JsonProperty("listingId")]
        public string ListingId { get; set; }

        [JsonProperty("listingStatus")]
        public string ListingStatus { get; set; }

        [JsonProperty("soldQuantity")]
        public int SoldQuantity { get; set; }
    }

    public class GetOfferResponseListingPoliciesType
    {
        [JsonProperty("bestOfferTerms")]
        public GetOfferResponseListingPoliciesTypeBestOfferTermsType BestOfferTerms { get; set; }

        [JsonProperty("eBayPlusIfEligible")]
        public bool EBayPlusIfEligible { get; set; }

        [JsonProperty("fulfillmentPolicyId")]
        public string FulfillmentPolicyId { get; set; }

        [JsonProperty("paymentPolicyId")]
        public string PaymentPolicyId { get; set; }

        [JsonProperty("productCompliancePolicyIds")]
        public string[] ProductCompliancePolicyIds { get; set; }

        [JsonProperty("returnPolicyId")]
        public string ReturnPolicyId { get; set; }

        [JsonProperty("shippingCostOverrides")]
        public GetOfferResponseListingPoliciesTypeShippingCostOverridesTypeItem[] ShippingCostOverrides { get; set; }

        [JsonProperty("takeBackPolicyId")]
        public string TakeBackPolicyId { get; set; }
    }

    public class GetOfferResponseListingPoliciesTypeBestOfferTermsType
    {
        [JsonProperty("autoAcceptPrice")]
        public GetOfferResponseListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType AutoAcceptPrice { get; set; }

        [JsonProperty("autoDeclinePrice")]
        public GetOfferResponseListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType AutoDeclinePrice { get; set; }

        [JsonProperty("bestOfferEnabled")]
        public bool BestOfferEnabled { get; set; }
    }

    public class GetOfferResponseListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponseListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponseListingPoliciesTypeShippingCostOverridesTypeItem
    {
        [JsonProperty("additionalShippingCost")]
        public GetOfferResponseListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("shippingCost")]
        public GetOfferResponseListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceType")]
        public string ShippingServiceType { get; set; }
    }

    public class GetOfferResponseListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponseListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponsePricingSummaryType
    {
        [JsonProperty("auctionReservePrice")]
        public GetOfferResponsePricingSummaryTypeAuctionReservePriceType AuctionReservePrice { get; set; }

        [JsonProperty("auctionStartPrice")]
        public GetOfferResponsePricingSummaryTypeAuctionStartPriceType AuctionStartPrice { get; set; }

        [JsonProperty("minimumAdvertisedPrice")]
        public GetOfferResponsePricingSummaryTypeMinimumAdvertisedPriceType MinimumAdvertisedPrice { get; set; }

        [JsonProperty("originallySoldForRetailPriceOn")]
        public string OriginallySoldForRetailPriceOn { get; set; }

        [JsonProperty("originalRetailPrice")]
        public GetOfferResponsePricingSummaryTypeOriginalRetailPriceType OriginalRetailPrice { get; set; }

        [JsonProperty("price")]
        public GetOfferResponsePricingSummaryTypePriceType Price { get; set; }

        [JsonProperty("pricingVisibility")]
        public string PricingVisibility { get; set; }
    }

    public class GetOfferResponsePricingSummaryTypeAuctionReservePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponsePricingSummaryTypeAuctionStartPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponsePricingSummaryTypeMinimumAdvertisedPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponsePricingSummaryTypeOriginalRetailPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponsePricingSummaryTypePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetOfferResponseTaxType
    {
        [JsonProperty("applyTax")]
        public bool ApplyTax { get; set; }

        [JsonProperty("thirdPartyTaxCategory")]
        public string ThirdPartyTaxCategory { get; set; }

        [JsonProperty("vatPercentage")]
        public double VatPercentage { get; set; }
    }

    public class UpdateOfferResponse
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        [JsonProperty("warnings")]
        public UpdateOfferResponseWarningsTypeItem[] Warnings { get; set; }
    }

    public class UpdateOfferResponseWarningsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("inputRefIds")]
        public string[] InputRefIds { get; set; }

        [JsonProperty("longMessage")]
        public string LongMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("outputRefIds")]
        public string[] OutputRefIds { get; set; }

        [JsonProperty("parameters")]
        public UpdateOfferResponseWarningsTypeItemParametersTypeItem[] Parameters { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }
    }

    public class UpdateOfferResponseWarningsTypeItemParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInput
    {
        [JsonProperty("availableQuantity")]
        public int? AvailableQuantity { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("charity")]
        public UpdateOfferInputCharityType Charity { get; set; }

        [JsonProperty("extendedProducerResponsibility")]
        public UpdateOfferInputExtendedProducerResponsibilityType ExtendedProducerResponsibility { get; set; }

        [JsonProperty("hideBuyerDetails")]
        public bool? HideBuyerDetails { get; set; }

        [JsonProperty("includeCatalogProductDetails")]
        public bool? IncludeCatalogProductDetails { get; set; }

        [JsonProperty("listingDescription")]
        public string ListingDescription { get; set; }

        [JsonProperty("listingDuration")]
        public UpdateOfferInputListingDurationType? ListingDuration { get; set; }

        [JsonProperty("listingPolicies")]
        public UpdateOfferInputListingPoliciesType ListingPolicies { get; set; }

        [JsonProperty("listingStartDate")]
        public string ListingStartDate { get; set; }

        [JsonProperty("lotSize")]
        public int? LotSize { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("pricingSummary")]
        public UpdateOfferInputPricingSummaryType PricingSummary { get; set; }

        [JsonProperty("quantityLimitPerBuyer")]
        public int? QuantityLimitPerBuyer { get; set; }

        [JsonProperty("secondaryCategoryId")]
        public string SecondaryCategoryId { get; set; }

        [JsonProperty("storeCategoryNames")]
        public string[] StoreCategoryNames { get; set; }

        [JsonProperty("tax")]
        public UpdateOfferInputTaxType Tax { get; set; }
    }

    public class UpdateOfferInputCharityType
    {
        [JsonProperty("charityId")]
        public string CharityId { get; set; }

        [JsonProperty("donationPercentage")]
        public string DonationPercentage { get; set; }
    }

    public class UpdateOfferInputExtendedProducerResponsibilityType
    {
        [JsonProperty("producerProductId")]
        public string ProducerProductId { get; set; }

        [JsonProperty("productPackageId")]
        public string ProductPackageId { get; set; }

        [JsonProperty("shipmentPackageId")]
        public string ShipmentPackageId { get; set; }

        [JsonProperty("productDocumentationId")]
        public string ProductDocumentationId { get; set; }

        [JsonProperty("ecoParticipationFee")]
        public UpdateOfferInputExtendedProducerResponsibilityTypeEcoParticipationFeeType EcoParticipationFee { get; set; }
    }

    public class UpdateOfferInputExtendedProducerResponsibilityTypeEcoParticipationFeeType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOfferInputListingDurationType
    {
        [EnumMember(Value = "DAYS_1")]
        DAYS1,
        [EnumMember(Value = "DAYS_3")]
        DAYS3,
        [EnumMember(Value = "DAYS_5")]
        DAYS5,
        [EnumMember(Value = "DAYS_7")]
        DAYS7,
        [EnumMember(Value = "DAYS_10")]
        DAYS10,
        [EnumMember(Value = "DAYS_21")]
        DAYS21,
        [EnumMember(Value = "DAYS_30")]
        DAYS30,
        GTC
    }

    public class UpdateOfferInputListingPoliciesType
    {
        [JsonProperty("bestOfferTerms")]
        public UpdateOfferInputListingPoliciesTypeBestOfferTermsType BestOfferTerms { get; set; }

        [JsonProperty("eBayPlusIfEligible")]
        public bool? EBayPlusIfEligible { get; set; }

        [JsonProperty("fulfillmentPolicyId")]
        public string FulfillmentPolicyId { get; set; }

        [JsonProperty("paymentPolicyId")]
        public string PaymentPolicyId { get; set; }

        [JsonProperty("productCompliancePolicyIds")]
        public string[] ProductCompliancePolicyIds { get; set; }

        [JsonProperty("returnPolicyId")]
        public string ReturnPolicyId { get; set; }

        [JsonProperty("shippingCostOverrides")]
        public UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItem[] ShippingCostOverrides { get; set; }

        [JsonProperty("takeBackPolicyId")]
        public string TakeBackPolicyId { get; set; }
    }

    public class UpdateOfferInputListingPoliciesTypeBestOfferTermsType
    {
        [JsonProperty("autoAcceptPrice")]
        public UpdateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType AutoAcceptPrice { get; set; }

        [JsonProperty("autoDeclinePrice")]
        public UpdateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType AutoDeclinePrice { get; set; }

        [JsonProperty("bestOfferEnabled")]
        public bool? BestOfferEnabled { get; set; }
    }

    public class UpdateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoAcceptPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInputListingPoliciesTypeBestOfferTermsTypeAutoDeclinePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItem
    {
        [JsonProperty("additionalShippingCost")]
        public UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("shippingCost")]
        public UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceType")]
        public UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingServiceTypeType? ShippingServiceType { get; set; }
    }

    public class UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOfferInputListingPoliciesTypeShippingCostOverridesTypeItemShippingServiceTypeType
    {
        DOMESTIC,
        INTERNATIONAL
    }

    public class UpdateOfferInputPricingSummaryType
    {
        [JsonProperty("auctionReservePrice")]
        public UpdateOfferInputPricingSummaryTypeAuctionReservePriceType AuctionReservePrice { get; set; }

        [JsonProperty("auctionStartPrice")]
        public UpdateOfferInputPricingSummaryTypeAuctionStartPriceType AuctionStartPrice { get; set; }

        [JsonProperty("minimumAdvertisedPrice")]
        public UpdateOfferInputPricingSummaryTypeMinimumAdvertisedPriceType MinimumAdvertisedPrice { get; set; }

        [JsonProperty("originallySoldForRetailPriceOn")]
        public UpdateOfferInputPricingSummaryTypeOriginallySoldForRetailPriceOnType? OriginallySoldForRetailPriceOn { get; set; }

        [JsonProperty("originalRetailPrice")]
        public UpdateOfferInputPricingSummaryTypeOriginalRetailPriceType OriginalRetailPrice { get; set; }

        [JsonProperty("price")]
        public UpdateOfferInputPricingSummaryTypePriceType Price { get; set; }

        [JsonProperty("pricingVisibility")]
        public UpdateOfferInputPricingSummaryTypePricingVisibilityType? PricingVisibility { get; set; }
    }

    public class UpdateOfferInputPricingSummaryTypeAuctionReservePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInputPricingSummaryTypeAuctionStartPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInputPricingSummaryTypeMinimumAdvertisedPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOfferInputPricingSummaryTypeOriginallySoldForRetailPriceOnType
    {
        [EnumMember(Value = "ON_EBAY")]
        ONEBAY,
        [EnumMember(Value = "OFF_EBAY")]
        OFFEBAY,
        [EnumMember(Value = "ON_AND_OFF_EBAY")]
        ONANDOFFEBAY
    }

    public class UpdateOfferInputPricingSummaryTypeOriginalRetailPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UpdateOfferInputPricingSummaryTypePriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateOfferInputPricingSummaryTypePricingVisibilityType
    {
        NONE,
        [EnumMember(Value = "PRE_CHECKOUT")]
        PRECHECKOUT,
        [EnumMember(Value = "DURING_CHECKOUT")]
        DURINGCHECKOUT
    }

    public class UpdateOfferInputTaxType
    {
        [JsonProperty("applyTax")]
        public bool? ApplyTax { get; set; }

        [JsonProperty("thirdPartyTaxCategory")]
        public string ThirdPartyTaxCategory { get; set; }

        [JsonProperty("vatPercentage")]
        public double? VatPercentage { get; set; }
    }

    public class WithdrawOfferResponse
    {
        [JsonProperty("listingId")]
        public string ListingId { get; set; }

        [JsonProperty("warnings")]
        public WithdrawOfferResponseWarningsTypeItem[] Warnings { get; set; }
    }

    public class WithdrawOfferResponseWarningsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("inputRefIds")]
        public string[] InputRefIds { get; set; }

        [JsonProperty("longMessage")]
        public string LongMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("outputRefIds")]
        public string[] OutputRefIds { get; set; }

        [JsonProperty("parameters")]
        public WithdrawOfferResponseWarningsTypeItemParametersTypeItem[] Parameters { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }
    }

    public class WithdrawOfferResponseWarningsTypeItemParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PublishOfferResponse
    {
        [JsonProperty("listingId")]
        public string ListingId { get; set; }

        [JsonProperty("warnings")]
        public PublishOfferResponseWarningsTypeItem[] Warnings { get; set; }
    }

    public class PublishOfferResponseWarningsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("errorId")]
        public int ErrorId { get; set; }

        [JsonProperty("inputRefIds")]
        public string[] InputRefIds { get; set; }

        [JsonProperty("longMessage")]
        public string LongMessage { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("outputRefIds")]
        public string[] OutputRefIds { get; set; }

        [JsonProperty("parameters")]
        public PublishOfferResponseWarningsTypeItemParametersTypeItem[] Parameters { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }
    }

    public class PublishOfferResponseWarningsTypeItemParametersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ebayip;

    public partial class WorkflowManagedActions
    {
        public EbayipActions Ebayip(string connectionId) => new EbayipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EbayipTriggers Ebayip(string connectionId) => new EbayipTriggers(connectionId);
    }
}