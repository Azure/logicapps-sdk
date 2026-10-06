//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebayip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EbayipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetDefaultCategoryTreeId))]
        public IBodyWorkflowAction<GetDefaultCategoryTreeIdResponse> GetDefaultCategoryTreeId([WorkflowExpression] Func<string> marketplaceId, [WorkflowExpression] Func<string> acceptLanguage)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDefaultCategoryTreeIdResponse> __BuildGetDefaultCategoryTreeId(WorkflowExpression<string> marketplaceId, WorkflowExpression<string> acceptLanguage)
        {
            WorkflowExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            WorkflowExpression.Validate(acceptLanguage, nameof(acceptLanguage), required: true);
            return new DeferredBodyAction<GetDefaultCategoryTreeIdResponse>(() =>
            {
                var apiCallPath = "/commerce/taxonomy/v1/get_default_category_tree_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = ExpressionConverter.Convert(marketplaceId);
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
                return new ApiConnectionAction<GetDefaultCategoryTreeIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCategorySuggestions))]
        public IBodyWorkflowAction<GetCategorySuggestionsResponse> GetCategorySuggestions([WorkflowExpression] Func<string> categoryTreeId, [WorkflowExpression] Func<string> q)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCategorySuggestionsResponse> __BuildGetCategorySuggestions(WorkflowExpression<string> categoryTreeId, WorkflowExpression<string> q)
        {
            WorkflowExpression.Validate(categoryTreeId, nameof(categoryTreeId), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: true);
            return new DeferredBodyAction<GetCategorySuggestionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/commerce/taxonomy/v1/category_tree/{0}/get_category_suggestions", ExpressionConverter.ConvertWithUrlEncoding(categoryTreeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("application/gzip");
                return new ApiConnectionAction<GetCategorySuggestionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemAspects))]
        public IBodyWorkflowAction<GetItemAspectsResponse> GetItemAspects([WorkflowExpression] Func<string> categoryTreeId, [WorkflowExpression] Func<string> categoryId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItemAspectsResponse> __BuildGetItemAspects(WorkflowExpression<string> categoryTreeId, WorkflowExpression<string> categoryId)
        {
            WorkflowExpression.Validate(categoryTreeId, nameof(categoryTreeId), required: true);
            WorkflowExpression.Validate(categoryId, nameof(categoryId), required: true);
            return new DeferredBodyAction<GetItemAspectsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/commerce/taxonomy/v1/category_tree/{0}/get_item_aspects_for_category", ExpressionConverter.ConvertWithUrlEncoding(categoryTreeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = ExpressionConverter.Convert(categoryId);
                return new ApiConnectionAction<GetItemAspectsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetFulfillmentPolicies))]
        public IBodyWorkflowAction<GetFulfillmentPoliciesResponse> GetFulfillmentPolicies([WorkflowExpression] Func<string> marketplaceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFulfillmentPoliciesResponse> __BuildGetFulfillmentPolicies(WorkflowExpression<string> marketplaceId)
        {
            WorkflowExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            return new DeferredBodyAction<GetFulfillmentPoliciesResponse>(() =>
            {
                var apiCallPath = "/sell/account/v1/fulfillment_policy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = ExpressionConverter.Convert(marketplaceId);
                return new ApiConnectionAction<GetFulfillmentPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetFulfillmentPolicy))]
        public IBodyWorkflowAction<GetFulfillmentPolicyResponse> GetFulfillmentPolicy([WorkflowExpression] Func<string> fulfillmentPolicyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFulfillmentPolicyResponse> __BuildGetFulfillmentPolicy(WorkflowExpression<string> fulfillmentPolicyId)
        {
            WorkflowExpression.Validate(fulfillmentPolicyId, nameof(fulfillmentPolicyId), required: true);
            return new DeferredBodyAction<GetFulfillmentPolicyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/account/v1/fulfillment_policy/{0}", ExpressionConverter.ConvertWithUrlEncoding(fulfillmentPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFulfillmentPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetPaymentPolicy))]
        public IBodyWorkflowAction<GetPaymentPolicyResponse> GetPaymentPolicy([WorkflowExpression] Func<string> paymentPolicyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPaymentPolicyResponse> __BuildGetPaymentPolicy(WorkflowExpression<string> paymentPolicyId)
        {
            WorkflowExpression.Validate(paymentPolicyId, nameof(paymentPolicyId), required: true);
            return new DeferredBodyAction<GetPaymentPolicyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/account/v1/payment_policy/{0}", ExpressionConverter.ConvertWithUrlEncoding(paymentPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPaymentPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetReturnPolicies))]
        public IBodyWorkflowAction<GetReturnPoliciesResponse> GetReturnPolicies([WorkflowExpression] Func<string> marketplaceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetReturnPoliciesResponse> __BuildGetReturnPolicies(WorkflowExpression<string> marketplaceId)
        {
            WorkflowExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            return new DeferredBodyAction<GetReturnPoliciesResponse>(() =>
            {
                var apiCallPath = "/sell/account/v1/return_policy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = ExpressionConverter.Convert(marketplaceId);
                return new ApiConnectionAction<GetReturnPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetReturnPolicy))]
        public IBodyWorkflowAction<GetReturnPolicyResponse> GetReturnPolicy([WorkflowExpression] Func<string> returnPolicyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetReturnPolicyResponse> __BuildGetReturnPolicy(WorkflowExpression<string> returnPolicyId)
        {
            WorkflowExpression.Validate(returnPolicyId, nameof(returnPolicyId), required: true);
            return new DeferredBodyAction<GetReturnPolicyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/account/v1/return_policy/{0}", ExpressionConverter.ConvertWithUrlEncoding(returnPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetReturnPolicyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetInventoryItem))]
        public IBodyWorkflowAction<GetInventoryItemResponse> GetInventoryItem([WorkflowExpression] Func<string> sku)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInventoryItemResponse> __BuildGetInventoryItem(WorkflowExpression<string> sku)
        {
            WorkflowExpression.Validate(sku, nameof(sku), required: true);
            return new DeferredBodyAction<GetInventoryItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/inventory_item/{0}", ExpressionConverter.ConvertWithUrlEncoding(sku, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetInventoryItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOrReplaceInventoryItem))]
        public IBodyWorkflowAction<CreateOrReplaceInventoryItemResponse> CreateOrReplaceInventoryItem([WorkflowExpression] Func<string> sku, [WorkflowExpression] Func<string> contentLanguage, [WorkflowExpression] Func<bodyavailabilitypickupAtLocationAvailabilityInputItem[]> bodyavailabilitypickupAtLocationAvailability = null, [WorkflowExpression] Func<bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItem[]> bodyavailabilityshipToLocationAvailabilityavailabilityDistributions = null, [WorkflowExpression] Func<int> bodyavailabilityshipToLocationAvailabilityquantity = null, [WorkflowExpression] Func<bodyconditionInput> bodycondition = null, [WorkflowExpression] Func<string> bodyconditionDescription = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizedimensionsheight = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizedimensionslength = null, [WorkflowExpression] Func<bodypackageWeightAndSizedimensionsunitInput> bodypackageWeightAndSizedimensionsunit = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizedimensionswidth = null, [WorkflowExpression] Func<bodypackageWeightAndSizepackageTypeInput> bodypackageWeightAndSizepackageType = null, [WorkflowExpression] Func<bodypackageWeightAndSizeweightunitInput> bodypackageWeightAndSizeweightunit = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizeweightvalue = null, [WorkflowExpression] Func<string> bodyproductbrand = null, [WorkflowExpression] Func<string> bodyproductdescription = null, [WorkflowExpression] Func<string[]> bodyproductean = null, [WorkflowExpression] Func<string> bodyproductepid = null, [WorkflowExpression] Func<string[]> bodyproductimageUrls = null, [WorkflowExpression] Func<string[]> bodyproductisbn = null, [WorkflowExpression] Func<string> bodyproductmpn = null, [WorkflowExpression] Func<string> bodyproductsubtitle = null, [WorkflowExpression] Func<string> bodyproducttitle = null, [WorkflowExpression] Func<string[]> bodyproductupc = null, [WorkflowExpression] Func<string[]> bodyproductvideoIds = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOrReplaceInventoryItemResponse> __BuildCreateOrReplaceInventoryItem(WorkflowExpression<string> sku, WorkflowExpression<string> contentLanguage, WorkflowExpression<bodyavailabilitypickupAtLocationAvailabilityInputItem[]> bodyavailabilitypickupAtLocationAvailability = null, WorkflowExpression<bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItem[]> bodyavailabilityshipToLocationAvailabilityavailabilityDistributions = null, WorkflowExpression<int> bodyavailabilityshipToLocationAvailabilityquantity = null, WorkflowExpression<bodyconditionInput> bodycondition = null, WorkflowExpression<string> bodyconditionDescription = null, WorkflowExpression<double> bodypackageWeightAndSizedimensionsheight = null, WorkflowExpression<double> bodypackageWeightAndSizedimensionslength = null, WorkflowExpression<bodypackageWeightAndSizedimensionsunitInput> bodypackageWeightAndSizedimensionsunit = null, WorkflowExpression<double> bodypackageWeightAndSizedimensionswidth = null, WorkflowExpression<bodypackageWeightAndSizepackageTypeInput> bodypackageWeightAndSizepackageType = null, WorkflowExpression<bodypackageWeightAndSizeweightunitInput> bodypackageWeightAndSizeweightunit = null, WorkflowExpression<double> bodypackageWeightAndSizeweightvalue = null, WorkflowExpression<string> bodyproductbrand = null, WorkflowExpression<string> bodyproductdescription = null, WorkflowExpression<string[]> bodyproductean = null, WorkflowExpression<string> bodyproductepid = null, WorkflowExpression<string[]> bodyproductimageUrls = null, WorkflowExpression<string[]> bodyproductisbn = null, WorkflowExpression<string> bodyproductmpn = null, WorkflowExpression<string> bodyproductsubtitle = null, WorkflowExpression<string> bodyproducttitle = null, WorkflowExpression<string[]> bodyproductupc = null, WorkflowExpression<string[]> bodyproductvideoIds = null)
        {
            WorkflowExpression.Validate(sku, nameof(sku), required: true);
            WorkflowExpression.Validate(contentLanguage, nameof(contentLanguage), required: true);
            WorkflowExpression.Validate(bodyavailabilitypickupAtLocationAvailability, nameof(bodyavailabilitypickupAtLocationAvailability), required: false);
            WorkflowExpression.Validate(bodyavailabilityshipToLocationAvailabilityavailabilityDistributions, nameof(bodyavailabilityshipToLocationAvailabilityavailabilityDistributions), required: false);
            WorkflowExpression.Validate(bodyavailabilityshipToLocationAvailabilityquantity, nameof(bodyavailabilityshipToLocationAvailabilityquantity), required: false);
            WorkflowExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            WorkflowExpression.Validate(bodyconditionDescription, nameof(bodyconditionDescription), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizedimensionsheight, nameof(bodypackageWeightAndSizedimensionsheight), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizedimensionslength, nameof(bodypackageWeightAndSizedimensionslength), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizedimensionsunit, nameof(bodypackageWeightAndSizedimensionsunit), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizedimensionswidth, nameof(bodypackageWeightAndSizedimensionswidth), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizepackageType, nameof(bodypackageWeightAndSizepackageType), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizeweightunit, nameof(bodypackageWeightAndSizeweightunit), required: false);
            WorkflowExpression.Validate(bodypackageWeightAndSizeweightvalue, nameof(bodypackageWeightAndSizeweightvalue), required: false);
            WorkflowExpression.Validate(bodyproductbrand, nameof(bodyproductbrand), required: false);
            WorkflowExpression.Validate(bodyproductdescription, nameof(bodyproductdescription), required: false);
            WorkflowExpression.Validate(bodyproductean, nameof(bodyproductean), required: false);
            WorkflowExpression.Validate(bodyproductepid, nameof(bodyproductepid), required: false);
            WorkflowExpression.Validate(bodyproductimageUrls, nameof(bodyproductimageUrls), required: false);
            WorkflowExpression.Validate(bodyproductisbn, nameof(bodyproductisbn), required: false);
            WorkflowExpression.Validate(bodyproductmpn, nameof(bodyproductmpn), required: false);
            WorkflowExpression.Validate(bodyproductsubtitle, nameof(bodyproductsubtitle), required: false);
            WorkflowExpression.Validate(bodyproducttitle, nameof(bodyproducttitle), required: false);
            WorkflowExpression.Validate(bodyproductupc, nameof(bodyproductupc), required: false);
            WorkflowExpression.Validate(bodyproductvideoIds, nameof(bodyproductvideoIds), required: false);
            return new DeferredBodyAction<CreateOrReplaceInventoryItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/inventory_item/{0}", ExpressionConverter.ConvertWithUrlEncoding(sku, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Content-Language"] = ExpressionConverter.Convert(contentLanguage);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var availabilityObject = new JObject();
                var availabilityObjectpropCount = 0;
                if (bodyavailabilitypickupAtLocationAvailability != null)
                {
                    availabilityObject["pickupAtLocationAvailability"] = ExpressionConverter.ConvertO(bodyavailabilitypickupAtLocationAvailability);
                    availabilityObjectpropCount++;
                }

                var shipToLocationAvailabilityObject = new JObject();
                var shipToLocationAvailabilityObjectpropCount = 0;
                if (bodyavailabilityshipToLocationAvailabilityavailabilityDistributions != null)
                {
                    shipToLocationAvailabilityObject["availabilityDistributions"] = ExpressionConverter.ConvertO(bodyavailabilityshipToLocationAvailabilityavailabilityDistributions);
                    shipToLocationAvailabilityObjectpropCount++;
                }

                if (bodyavailabilityshipToLocationAvailabilityquantity != null)
                {
                    shipToLocationAvailabilityObject["quantity"] = ExpressionConverter.ConvertO(bodyavailabilityshipToLocationAvailabilityquantity);
                    shipToLocationAvailabilityObjectpropCount++;
                }

                if (shipToLocationAvailabilityObjectpropCount > 0)
                {
                    availabilityObject["shipToLocationAvailability"] = shipToLocationAvailabilityObject;
                    availabilityObjectpropCount++;
                }

                if (availabilityObjectpropCount > 0)
                {
                    body["availability"] = availabilityObject;
                    bodypropCount++;
                }

                if (bodycondition != null)
                {
                    body["condition"] = ExpressionConverter.ConvertO(bodycondition);
                    bodypropCount++;
                }

                if (bodyconditionDescription != null)
                {
                    body["conditionDescription"] = ExpressionConverter.ConvertO(bodyconditionDescription);
                    bodypropCount++;
                }

                var packageWeightAndSizeObject = new JObject();
                var packageWeightAndSizeObjectpropCount = 0;
                var dimensionsObject = new JObject();
                var dimensionsObjectpropCount = 0;
                if (bodypackageWeightAndSizedimensionsheight != null)
                {
                    dimensionsObject["height"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizedimensionsheight);
                    dimensionsObjectpropCount++;
                }

                if (bodypackageWeightAndSizedimensionslength != null)
                {
                    dimensionsObject["length"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizedimensionslength);
                    dimensionsObjectpropCount++;
                }

                if (bodypackageWeightAndSizedimensionsunit != null)
                {
                    dimensionsObject["unit"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizedimensionsunit);
                    dimensionsObjectpropCount++;
                }

                if (bodypackageWeightAndSizedimensionswidth != null)
                {
                    dimensionsObject["width"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizedimensionswidth);
                    dimensionsObjectpropCount++;
                }

                if (dimensionsObjectpropCount > 0)
                {
                    packageWeightAndSizeObject["dimensions"] = dimensionsObject;
                    packageWeightAndSizeObjectpropCount++;
                }

                if (bodypackageWeightAndSizepackageType != null)
                {
                    packageWeightAndSizeObject["packageType"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizepackageType);
                    packageWeightAndSizeObjectpropCount++;
                }

                var weightObject = new JObject();
                var weightObjectpropCount = 0;
                if (bodypackageWeightAndSizeweightunit != null)
                {
                    weightObject["unit"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizeweightunit);
                    weightObjectpropCount++;
                }

                if (bodypackageWeightAndSizeweightvalue != null)
                {
                    weightObject["value"] = ExpressionConverter.ConvertO(bodypackageWeightAndSizeweightvalue);
                    weightObjectpropCount++;
                }

                if (weightObjectpropCount > 0)
                {
                    packageWeightAndSizeObject["weight"] = weightObject;
                    packageWeightAndSizeObjectpropCount++;
                }

                if (packageWeightAndSizeObjectpropCount > 0)
                {
                    body["packageWeightAndSize"] = packageWeightAndSizeObject;
                    bodypropCount++;
                }

                var productObject = new JObject();
                var productObjectpropCount = 0;
                var aspectsObject = new JObject();
                var aspectsObjectpropCount = 0;
                if (aspectsObjectpropCount > 0)
                {
                    productObject["aspects"] = aspectsObject;
                    productObjectpropCount++;
                }

                if (bodyproductbrand != null)
                {
                    productObject["brand"] = ExpressionConverter.ConvertO(bodyproductbrand);
                    productObjectpropCount++;
                }

                if (bodyproductdescription != null)
                {
                    productObject["description"] = ExpressionConverter.ConvertO(bodyproductdescription);
                    productObjectpropCount++;
                }

                if (bodyproductean != null)
                {
                    productObject["ean"] = ExpressionConverter.ConvertO(bodyproductean);
                    productObjectpropCount++;
                }

                if (bodyproductepid != null)
                {
                    productObject["epid"] = ExpressionConverter.ConvertO(bodyproductepid);
                    productObjectpropCount++;
                }

                if (bodyproductimageUrls != null)
                {
                    productObject["imageUrls"] = ExpressionConverter.ConvertO(bodyproductimageUrls);
                    productObjectpropCount++;
                }

                if (bodyproductisbn != null)
                {
                    productObject["isbn"] = ExpressionConverter.ConvertO(bodyproductisbn);
                    productObjectpropCount++;
                }

                if (bodyproductmpn != null)
                {
                    productObject["mpn"] = ExpressionConverter.ConvertO(bodyproductmpn);
                    productObjectpropCount++;
                }

                if (bodyproductsubtitle != null)
                {
                    productObject["subtitle"] = ExpressionConverter.ConvertO(bodyproductsubtitle);
                    productObjectpropCount++;
                }

                if (bodyproducttitle != null)
                {
                    productObject["title"] = ExpressionConverter.ConvertO(bodyproducttitle);
                    productObjectpropCount++;
                }

                if (bodyproductupc != null)
                {
                    productObject["upc"] = ExpressionConverter.ConvertO(bodyproductupc);
                    productObjectpropCount++;
                }

                if (bodyproductvideoIds != null)
                {
                    productObject["videoIds"] = ExpressionConverter.ConvertO(bodyproductvideoIds);
                    productObjectpropCount++;
                }

                if (productObjectpropCount > 0)
                {
                    body["product"] = productObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateOrReplaceInventoryItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetInventoryItems))]
        public IBodyWorkflowAction<GetInventoryItemsResponse> GetInventoryItems([WorkflowExpression] Func<string> Limit = null, [WorkflowExpression] Func<string> Offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInventoryItemsResponse> __BuildGetInventoryItems(WorkflowExpression<string> Limit = null, WorkflowExpression<string> Offset = null)
        {
            WorkflowExpression.Validate(Limit, nameof(Limit), required: false);
            WorkflowExpression.Validate(Offset, nameof(Offset), required: false);
            return new DeferredBodyAction<GetInventoryItemsResponse>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/inventory_item";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Limit != null)
                    callPayload.Queries[" limit"] = ExpressionConverter.Convert(Limit);
                if (Offset != null)
                    callPayload.Queries[" offset"] = ExpressionConverter.Convert(Offset);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetInventoryItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetInventoryLocation))]
        public IBodyWorkflowAction<GetInventoryLocationResponse> GetInventoryLocation([WorkflowExpression] Func<string> merchantLocationKey)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInventoryLocationResponse> __BuildGetInventoryLocation(WorkflowExpression<string> merchantLocationKey)
        {
            WorkflowExpression.Validate(merchantLocationKey, nameof(merchantLocationKey), required: true);
            return new DeferredBodyAction<GetInventoryLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/location/{0}", ExpressionConverter.ConvertWithUrlEncoding(merchantLocationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetInventoryLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateInventoryLocation))]
        public IBodyWorkflowAction<string> CreateInventoryLocation([WorkflowExpression] Func<string> merchantLocationKey, [WorkflowExpression] Func<string> bodylocationaddressaddressLine1 = null, [WorkflowExpression] Func<string> bodylocationaddressaddressLine2 = null, [WorkflowExpression] Func<string> bodylocationaddresscity = null, [WorkflowExpression] Func<string> bodylocationaddresscountry = null, [WorkflowExpression] Func<string> bodylocationaddresscounty = null, [WorkflowExpression] Func<string> bodylocationaddresspostalCode = null, [WorkflowExpression] Func<string> bodylocationaddressstateOrProvince = null, [WorkflowExpression] Func<string> bodylocationgeoCoordinateslatitude = null, [WorkflowExpression] Func<string> bodylocationgeoCoordinateslongitude = null, [WorkflowExpression] Func<string> bodylocationAdditionalInformation = null, [WorkflowExpression] Func<string> bodylocationInstructions = null, [WorkflowExpression] Func<bodylocationTypesInputItem[]> bodylocationTypes = null, [WorkflowExpression] Func<string> bodylocationWebUrl = null, [WorkflowExpression] Func<string> bodymerchantLocationStatus = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodyoperatingHoursInputItem[]> bodyoperatingHours = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<bodyspecialHoursInputItem[]> bodyspecialHours = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateInventoryLocation(WorkflowExpression<string> merchantLocationKey, WorkflowExpression<string> bodylocationaddressaddressLine1 = null, WorkflowExpression<string> bodylocationaddressaddressLine2 = null, WorkflowExpression<string> bodylocationaddresscity = null, WorkflowExpression<string> bodylocationaddresscountry = null, WorkflowExpression<string> bodylocationaddresscounty = null, WorkflowExpression<string> bodylocationaddresspostalCode = null, WorkflowExpression<string> bodylocationaddressstateOrProvince = null, WorkflowExpression<string> bodylocationgeoCoordinateslatitude = null, WorkflowExpression<string> bodylocationgeoCoordinateslongitude = null, WorkflowExpression<string> bodylocationAdditionalInformation = null, WorkflowExpression<string> bodylocationInstructions = null, WorkflowExpression<bodylocationTypesInputItem[]> bodylocationTypes = null, WorkflowExpression<string> bodylocationWebUrl = null, WorkflowExpression<string> bodymerchantLocationStatus = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<bodyoperatingHoursInputItem[]> bodyoperatingHours = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<bodyspecialHoursInputItem[]> bodyspecialHours = null)
        {
            WorkflowExpression.Validate(merchantLocationKey, nameof(merchantLocationKey), required: true);
            WorkflowExpression.Validate(bodylocationaddressaddressLine1, nameof(bodylocationaddressaddressLine1), required: false);
            WorkflowExpression.Validate(bodylocationaddressaddressLine2, nameof(bodylocationaddressaddressLine2), required: false);
            WorkflowExpression.Validate(bodylocationaddresscity, nameof(bodylocationaddresscity), required: false);
            WorkflowExpression.Validate(bodylocationaddresscountry, nameof(bodylocationaddresscountry), required: false);
            WorkflowExpression.Validate(bodylocationaddresscounty, nameof(bodylocationaddresscounty), required: false);
            WorkflowExpression.Validate(bodylocationaddresspostalCode, nameof(bodylocationaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodylocationaddressstateOrProvince, nameof(bodylocationaddressstateOrProvince), required: false);
            WorkflowExpression.Validate(bodylocationgeoCoordinateslatitude, nameof(bodylocationgeoCoordinateslatitude), required: false);
            WorkflowExpression.Validate(bodylocationgeoCoordinateslongitude, nameof(bodylocationgeoCoordinateslongitude), required: false);
            WorkflowExpression.Validate(bodylocationAdditionalInformation, nameof(bodylocationAdditionalInformation), required: false);
            WorkflowExpression.Validate(bodylocationInstructions, nameof(bodylocationInstructions), required: false);
            WorkflowExpression.Validate(bodylocationTypes, nameof(bodylocationTypes), required: false);
            WorkflowExpression.Validate(bodylocationWebUrl, nameof(bodylocationWebUrl), required: false);
            WorkflowExpression.Validate(bodymerchantLocationStatus, nameof(bodymerchantLocationStatus), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyoperatingHours, nameof(bodyoperatingHours), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodyspecialHours, nameof(bodyspecialHours), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/location/{0}", ExpressionConverter.ConvertWithUrlEncoding(merchantLocationKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodylocationaddressaddressLine1 != null)
                {
                    addressObject["addressLine1"] = ExpressionConverter.ConvertO(bodylocationaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (bodylocationaddressaddressLine2 != null)
                {
                    addressObject["addressLine2"] = ExpressionConverter.ConvertO(bodylocationaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresscity != null)
                {
                    addressObject["city"] = ExpressionConverter.ConvertO(bodylocationaddresscity);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodylocationaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresscounty != null)
                {
                    addressObject["county"] = ExpressionConverter.ConvertO(bodylocationaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresspostalCode != null)
                {
                    addressObject["postalCode"] = ExpressionConverter.ConvertO(bodylocationaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodylocationaddressstateOrProvince != null)
                {
                    addressObject["stateOrProvince"] = ExpressionConverter.ConvertO(bodylocationaddressstateOrProvince);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    locationObject["address"] = addressObject;
                    locationObjectpropCount++;
                }

                var geoCoordinatesObject = new JObject();
                var geoCoordinatesObjectpropCount = 0;
                if (bodylocationgeoCoordinateslatitude != null)
                {
                    geoCoordinatesObject["latitude"] = ExpressionConverter.ConvertO(bodylocationgeoCoordinateslatitude);
                    geoCoordinatesObjectpropCount++;
                }

                if (bodylocationgeoCoordinateslongitude != null)
                {
                    geoCoordinatesObject["longitude"] = ExpressionConverter.ConvertO(bodylocationgeoCoordinateslongitude);
                    geoCoordinatesObjectpropCount++;
                }

                if (geoCoordinatesObjectpropCount > 0)
                {
                    locationObject["geoCoordinates"] = geoCoordinatesObject;
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodylocationAdditionalInformation != null)
                {
                    body["locationAdditionalInformation"] = ExpressionConverter.ConvertO(bodylocationAdditionalInformation);
                    bodypropCount++;
                }

                if (bodylocationInstructions != null)
                {
                    body["locationInstructions"] = ExpressionConverter.ConvertO(bodylocationInstructions);
                    bodypropCount++;
                }

                if (bodylocationTypes != null)
                {
                    body["locationTypes"] = ExpressionConverter.ConvertO(bodylocationTypes);
                    bodypropCount++;
                }

                if (bodylocationWebUrl != null)
                {
                    body["locationWebUrl"] = ExpressionConverter.ConvertO(bodylocationWebUrl);
                    bodypropCount++;
                }

                if (bodymerchantLocationStatus != null)
                {
                    body["merchantLocationStatus"] = ExpressionConverter.ConvertO(bodymerchantLocationStatus);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyoperatingHours != null)
                {
                    body["operatingHours"] = ExpressionConverter.ConvertO(bodyoperatingHours);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                    bodypropCount++;
                }

                if (bodyspecialHours != null)
                {
                    body["specialHours"] = ExpressionConverter.ConvertO(bodyspecialHours);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetInventoryLocations))]
        public IBodyWorkflowAction<GetInventoryLocationsResponse> GetInventoryLocations([WorkflowExpression] Func<string> Offset = null, [WorkflowExpression] Func<string> Limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInventoryLocationsResponse> __BuildGetInventoryLocations(WorkflowExpression<string> Offset = null, WorkflowExpression<string> Limit = null)
        {
            WorkflowExpression.Validate(Offset, nameof(Offset), required: false);
            WorkflowExpression.Validate(Limit, nameof(Limit), required: false);
            return new DeferredBodyAction<GetInventoryLocationsResponse>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Offset != null)
                    callPayload.Queries[" offset"] = ExpressionConverter.Convert(Offset);
                if (Limit != null)
                    callPayload.Queries[" limit"] = ExpressionConverter.Convert(Limit);
                return new ApiConnectionAction<GetInventoryLocationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemConditionPolicies))]
        public IBodyWorkflowAction<GetItemConditionPoliciesResponse> GetItemConditionPolicies([WorkflowExpression] Func<string> marketplaceId, [WorkflowExpression] Func<string> Filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItemConditionPoliciesResponse> __BuildGetItemConditionPolicies(WorkflowExpression<string> marketplaceId, WorkflowExpression<string> Filter = null)
        {
            WorkflowExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            WorkflowExpression.Validate(Filter, nameof(Filter), required: false);
            return new DeferredBodyAction<GetItemConditionPoliciesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/metadata/v1/marketplace/{0}/get_item_condition_policies", ExpressionConverter.ConvertWithUrlEncoding(marketplaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Filter != null)
                    callPayload.Queries[" filter"] = ExpressionConverter.Convert(Filter);
                return new ApiConnectionAction<GetItemConditionPoliciesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetOffers))]
        public IBodyWorkflowAction<GetOffersResponse> GetOffers([WorkflowExpression] Func<string> sku, [WorkflowExpression] Func<string> MarketplaceId = null, [WorkflowExpression] Func<string> Format = null, [WorkflowExpression] Func<string> Limit = null, [WorkflowExpression] Func<string> Offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOffersResponse> __BuildGetOffers(WorkflowExpression<string> sku, WorkflowExpression<string> MarketplaceId = null, WorkflowExpression<string> Format = null, WorkflowExpression<string> Limit = null, WorkflowExpression<string> Offset = null)
        {
            WorkflowExpression.Validate(sku, nameof(sku), required: true);
            WorkflowExpression.Validate(MarketplaceId, nameof(MarketplaceId), required: false);
            WorkflowExpression.Validate(Format, nameof(Format), required: false);
            WorkflowExpression.Validate(Limit, nameof(Limit), required: false);
            WorkflowExpression.Validate(Offset, nameof(Offset), required: false);
            return new DeferredBodyAction<GetOffersResponse>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/offer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sku"] = ExpressionConverter.Convert(sku);
                if (MarketplaceId != null)
                    callPayload.Queries[" marketplace_id"] = ExpressionConverter.Convert(MarketplaceId);
                if (Format != null)
                    callPayload.Queries[" format"] = ExpressionConverter.Convert(Format);
                if (Limit != null)
                    callPayload.Queries[" limit"] = ExpressionConverter.Convert(Limit);
                if (Offset != null)
                    callPayload.Queries[" offset"] = ExpressionConverter.Convert(Offset);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetOffersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOffer))]
        public IBodyWorkflowAction<CreateOfferResponse> CreateOffer([WorkflowExpression] Func<int> bodyavailableQuantity = null, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<string> bodycharitycharityId = null, [WorkflowExpression] Func<string> bodycharitydonationPercentage = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproducerProductId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityshipmentPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductDocumentationId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeecurrency = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeevalue = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<bool> bodyhideBuyerDetails = null, [WorkflowExpression] Func<bool> bodyincludeCatalogProductDetails = null, [WorkflowExpression] Func<string> bodylistingDescription = null, [WorkflowExpression] Func<bodylistingDurationInput> bodylistingDuration = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricevalue = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricevalue = null, [WorkflowExpression] Func<bool> bodylistingPoliciesbestOfferTermsbestOfferEnabled = null, [WorkflowExpression] Func<bool> bodylistingPolicieseBayPlusIfEligible = null, [WorkflowExpression] Func<string> bodylistingPoliciesfulfillmentPolicyId = null, [WorkflowExpression] Func<string> bodylistingPoliciespaymentPolicyId = null, [WorkflowExpression] Func<string[]> bodylistingPoliciesproductCompliancePolicyIds = null, [WorkflowExpression] Func<string> bodylistingPoliciesreturnPolicyId = null, [WorkflowExpression] Func<bodylistingPoliciesshippingCostOverridesInputItem[]> bodylistingPoliciesshippingCostOverrides = null, [WorkflowExpression] Func<string> bodylistingPoliciestakeBackPolicyId = null, [WorkflowExpression] Func<string> bodylistingStartDate = null, [WorkflowExpression] Func<int> bodylotSize = null, [WorkflowExpression] Func<string> bodymarketplaceId = null, [WorkflowExpression] Func<string> bodymerchantLocationKey = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricevalue = null, [WorkflowExpression] Func<bodypricingSummaryoriginallySoldForRetailPriceOnInput> bodypricingSummaryoriginallySoldForRetailPriceOn = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummarypricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummarypricevalue = null, [WorkflowExpression] Func<bodypricingSummarypricingVisibilityInput> bodypricingSummarypricingVisibility = null, [WorkflowExpression] Func<int> bodyquantityLimitPerBuyer = null, [WorkflowExpression] Func<string> bodysecondaryCategoryId = null, [WorkflowExpression] Func<string> bodysku = null, [WorkflowExpression] Func<string[]> bodystoreCategoryNames = null, [WorkflowExpression] Func<bool> bodytaxapplyTax = null, [WorkflowExpression] Func<string> bodytaxthirdPartyTaxCategory = null, [WorkflowExpression] Func<double> bodytaxvatPercentage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateOfferResponse> __BuildCreateOffer(WorkflowExpression<int> bodyavailableQuantity = null, WorkflowExpression<string> bodycategoryId = null, WorkflowExpression<string> bodycharitycharityId = null, WorkflowExpression<string> bodycharitydonationPercentage = null, WorkflowExpression<string> bodyextendedProducerResponsibilityproducerProductId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityproductPackageId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityshipmentPackageId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityproductDocumentationId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityecoParticipationFeecurrency = null, WorkflowExpression<string> bodyextendedProducerResponsibilityecoParticipationFeevalue = null, WorkflowExpression<bodyformatInput> bodyformat = null, WorkflowExpression<bool> bodyhideBuyerDetails = null, WorkflowExpression<bool> bodyincludeCatalogProductDetails = null, WorkflowExpression<string> bodylistingDescription = null, WorkflowExpression<bodylistingDurationInput> bodylistingDuration = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoAcceptPricevalue = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoDeclinePricevalue = null, WorkflowExpression<bool> bodylistingPoliciesbestOfferTermsbestOfferEnabled = null, WorkflowExpression<bool> bodylistingPolicieseBayPlusIfEligible = null, WorkflowExpression<string> bodylistingPoliciesfulfillmentPolicyId = null, WorkflowExpression<string> bodylistingPoliciespaymentPolicyId = null, WorkflowExpression<string[]> bodylistingPoliciesproductCompliancePolicyIds = null, WorkflowExpression<string> bodylistingPoliciesreturnPolicyId = null, WorkflowExpression<bodylistingPoliciesshippingCostOverridesInputItem[]> bodylistingPoliciesshippingCostOverrides = null, WorkflowExpression<string> bodylistingPoliciestakeBackPolicyId = null, WorkflowExpression<string> bodylistingStartDate = null, WorkflowExpression<int> bodylotSize = null, WorkflowExpression<string> bodymarketplaceId = null, WorkflowExpression<string> bodymerchantLocationKey = null, WorkflowExpression<string> bodypricingSummaryauctionReservePricecurrency = null, WorkflowExpression<string> bodypricingSummaryauctionReservePricevalue = null, WorkflowExpression<string> bodypricingSummaryauctionStartPricecurrency = null, WorkflowExpression<string> bodypricingSummaryauctionStartPricevalue = null, WorkflowExpression<string> bodypricingSummaryminimumAdvertisedPricecurrency = null, WorkflowExpression<string> bodypricingSummaryminimumAdvertisedPricevalue = null, WorkflowExpression<bodypricingSummaryoriginallySoldForRetailPriceOnInput> bodypricingSummaryoriginallySoldForRetailPriceOn = null, WorkflowExpression<string> bodypricingSummaryoriginalRetailPricecurrency = null, WorkflowExpression<string> bodypricingSummaryoriginalRetailPricevalue = null, WorkflowExpression<string> bodypricingSummarypricecurrency = null, WorkflowExpression<string> bodypricingSummarypricevalue = null, WorkflowExpression<bodypricingSummarypricingVisibilityInput> bodypricingSummarypricingVisibility = null, WorkflowExpression<int> bodyquantityLimitPerBuyer = null, WorkflowExpression<string> bodysecondaryCategoryId = null, WorkflowExpression<string> bodysku = null, WorkflowExpression<string[]> bodystoreCategoryNames = null, WorkflowExpression<bool> bodytaxapplyTax = null, WorkflowExpression<string> bodytaxthirdPartyTaxCategory = null, WorkflowExpression<double> bodytaxvatPercentage = null)
        {
            WorkflowExpression.Validate(bodyavailableQuantity, nameof(bodyavailableQuantity), required: false);
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            WorkflowExpression.Validate(bodycharitycharityId, nameof(bodycharitycharityId), required: false);
            WorkflowExpression.Validate(bodycharitydonationPercentage, nameof(bodycharitydonationPercentage), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityproducerProductId, nameof(bodyextendedProducerResponsibilityproducerProductId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityproductPackageId, nameof(bodyextendedProducerResponsibilityproductPackageId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityshipmentPackageId, nameof(bodyextendedProducerResponsibilityshipmentPackageId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityproductDocumentationId, nameof(bodyextendedProducerResponsibilityproductDocumentationId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeecurrency, nameof(bodyextendedProducerResponsibilityecoParticipationFeecurrency), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeevalue, nameof(bodyextendedProducerResponsibilityecoParticipationFeevalue), required: false);
            WorkflowExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowExpression.Validate(bodyhideBuyerDetails, nameof(bodyhideBuyerDetails), required: false);
            WorkflowExpression.Validate(bodyincludeCatalogProductDetails, nameof(bodyincludeCatalogProductDetails), required: false);
            WorkflowExpression.Validate(bodylistingDescription, nameof(bodylistingDescription), required: false);
            WorkflowExpression.Validate(bodylistingDuration, nameof(bodylistingDuration), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsbestOfferEnabled, nameof(bodylistingPoliciesbestOfferTermsbestOfferEnabled), required: false);
            WorkflowExpression.Validate(bodylistingPolicieseBayPlusIfEligible, nameof(bodylistingPolicieseBayPlusIfEligible), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesfulfillmentPolicyId, nameof(bodylistingPoliciesfulfillmentPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingPoliciespaymentPolicyId, nameof(bodylistingPoliciespaymentPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesproductCompliancePolicyIds, nameof(bodylistingPoliciesproductCompliancePolicyIds), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesreturnPolicyId, nameof(bodylistingPoliciesreturnPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesshippingCostOverrides, nameof(bodylistingPoliciesshippingCostOverrides), required: false);
            WorkflowExpression.Validate(bodylistingPoliciestakeBackPolicyId, nameof(bodylistingPoliciestakeBackPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingStartDate, nameof(bodylistingStartDate), required: false);
            WorkflowExpression.Validate(bodylotSize, nameof(bodylotSize), required: false);
            WorkflowExpression.Validate(bodymarketplaceId, nameof(bodymarketplaceId), required: false);
            WorkflowExpression.Validate(bodymerchantLocationKey, nameof(bodymerchantLocationKey), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionReservePricecurrency, nameof(bodypricingSummaryauctionReservePricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionReservePricevalue, nameof(bodypricingSummaryauctionReservePricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionStartPricecurrency, nameof(bodypricingSummaryauctionStartPricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionStartPricevalue, nameof(bodypricingSummaryauctionStartPricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummaryminimumAdvertisedPricecurrency, nameof(bodypricingSummaryminimumAdvertisedPricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryminimumAdvertisedPricevalue, nameof(bodypricingSummaryminimumAdvertisedPricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummaryoriginallySoldForRetailPriceOn, nameof(bodypricingSummaryoriginallySoldForRetailPriceOn), required: false);
            WorkflowExpression.Validate(bodypricingSummaryoriginalRetailPricecurrency, nameof(bodypricingSummaryoriginalRetailPricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryoriginalRetailPricevalue, nameof(bodypricingSummaryoriginalRetailPricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummarypricecurrency, nameof(bodypricingSummarypricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummarypricevalue, nameof(bodypricingSummarypricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummarypricingVisibility, nameof(bodypricingSummarypricingVisibility), required: false);
            WorkflowExpression.Validate(bodyquantityLimitPerBuyer, nameof(bodyquantityLimitPerBuyer), required: false);
            WorkflowExpression.Validate(bodysecondaryCategoryId, nameof(bodysecondaryCategoryId), required: false);
            WorkflowExpression.Validate(bodysku, nameof(bodysku), required: false);
            WorkflowExpression.Validate(bodystoreCategoryNames, nameof(bodystoreCategoryNames), required: false);
            WorkflowExpression.Validate(bodytaxapplyTax, nameof(bodytaxapplyTax), required: false);
            WorkflowExpression.Validate(bodytaxthirdPartyTaxCategory, nameof(bodytaxthirdPartyTaxCategory), required: false);
            WorkflowExpression.Validate(bodytaxvatPercentage, nameof(bodytaxvatPercentage), required: false);
            return new DeferredBodyAction<CreateOfferResponse>(() =>
            {
                var apiCallPath = "/sell/inventory/v1/offer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyavailableQuantity != null)
                {
                    body["availableQuantity"] = ExpressionConverter.ConvertO(bodyavailableQuantity);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                    bodypropCount++;
                }

                var charityObject = new JObject();
                var charityObjectpropCount = 0;
                if (bodycharitycharityId != null)
                {
                    charityObject["charityId"] = ExpressionConverter.ConvertO(bodycharitycharityId);
                    charityObjectpropCount++;
                }

                if (bodycharitydonationPercentage != null)
                {
                    charityObject["donationPercentage"] = ExpressionConverter.ConvertO(bodycharitydonationPercentage);
                    charityObjectpropCount++;
                }

                if (charityObjectpropCount > 0)
                {
                    body["charity"] = charityObject;
                    bodypropCount++;
                }

                var extendedProducerResponsibilityObject = new JObject();
                var extendedProducerResponsibilityObjectpropCount = 0;
                if (bodyextendedProducerResponsibilityproducerProductId != null)
                {
                    extendedProducerResponsibilityObject["producerProductId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityproducerProductId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductPackageId != null)
                {
                    extendedProducerResponsibilityObject["productPackageId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityproductPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityshipmentPackageId != null)
                {
                    extendedProducerResponsibilityObject["shipmentPackageId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityshipmentPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductDocumentationId != null)
                {
                    extendedProducerResponsibilityObject["productDocumentationId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityproductDocumentationId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                var ecoParticipationFeeObject = new JObject();
                var ecoParticipationFeeObjectpropCount = 0;
                if (bodyextendedProducerResponsibilityecoParticipationFeecurrency != null)
                {
                    ecoParticipationFeeObject["currency"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityecoParticipationFeecurrency);
                    ecoParticipationFeeObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityecoParticipationFeevalue != null)
                {
                    ecoParticipationFeeObject["value"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityecoParticipationFeevalue);
                    ecoParticipationFeeObjectpropCount++;
                }

                if (ecoParticipationFeeObjectpropCount > 0)
                {
                    extendedProducerResponsibilityObject["ecoParticipationFee"] = ecoParticipationFeeObject;
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (extendedProducerResponsibilityObjectpropCount > 0)
                {
                    body["extendedProducerResponsibility"] = extendedProducerResponsibilityObject;
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                if (bodyhideBuyerDetails != null)
                {
                    body["hideBuyerDetails"] = ExpressionConverter.ConvertO(bodyhideBuyerDetails);
                    bodypropCount++;
                }

                if (bodyincludeCatalogProductDetails != null)
                {
                    body["includeCatalogProductDetails"] = ExpressionConverter.ConvertO(bodyincludeCatalogProductDetails);
                    bodypropCount++;
                }

                if (bodylistingDescription != null)
                {
                    body["listingDescription"] = ExpressionConverter.ConvertO(bodylistingDescription);
                    bodypropCount++;
                }

                if (bodylistingDuration != null)
                {
                    body["listingDuration"] = ExpressionConverter.ConvertO(bodylistingDuration);
                    bodypropCount++;
                }

                var listingPoliciesObject = new JObject();
                var listingPoliciesObjectpropCount = 0;
                var bestOfferTermsObject = new JObject();
                var bestOfferTermsObjectpropCount = 0;
                var autoAcceptPriceObject = new JObject();
                var autoAcceptPriceObjectpropCount = 0;
                if (bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency != null)
                {
                    autoAcceptPriceObject["currency"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency);
                    autoAcceptPriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoAcceptPricevalue != null)
                {
                    autoAcceptPriceObject["value"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue);
                    autoAcceptPriceObjectpropCount++;
                }

                if (autoAcceptPriceObjectpropCount > 0)
                {
                    bestOfferTermsObject["autoAcceptPrice"] = autoAcceptPriceObject;
                    bestOfferTermsObjectpropCount++;
                }

                var autoDeclinePriceObject = new JObject();
                var autoDeclinePriceObjectpropCount = 0;
                if (bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency != null)
                {
                    autoDeclinePriceObject["currency"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency);
                    autoDeclinePriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoDeclinePricevalue != null)
                {
                    autoDeclinePriceObject["value"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue);
                    autoDeclinePriceObjectpropCount++;
                }

                if (autoDeclinePriceObjectpropCount > 0)
                {
                    bestOfferTermsObject["autoDeclinePrice"] = autoDeclinePriceObject;
                    bestOfferTermsObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsbestOfferEnabled != null)
                {
                    bestOfferTermsObject["bestOfferEnabled"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsbestOfferEnabled);
                    bestOfferTermsObjectpropCount++;
                }

                if (bestOfferTermsObjectpropCount > 0)
                {
                    listingPoliciesObject["bestOfferTerms"] = bestOfferTermsObject;
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPolicieseBayPlusIfEligible != null)
                {
                    listingPoliciesObject["eBayPlusIfEligible"] = ExpressionConverter.ConvertO(bodylistingPolicieseBayPlusIfEligible);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesfulfillmentPolicyId != null)
                {
                    listingPoliciesObject["fulfillmentPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciesfulfillmentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciespaymentPolicyId != null)
                {
                    listingPoliciesObject["paymentPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciespaymentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesproductCompliancePolicyIds != null)
                {
                    listingPoliciesObject["productCompliancePolicyIds"] = ExpressionConverter.ConvertO(bodylistingPoliciesproductCompliancePolicyIds);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesreturnPolicyId != null)
                {
                    listingPoliciesObject["returnPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciesreturnPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesshippingCostOverrides != null)
                {
                    listingPoliciesObject["shippingCostOverrides"] = ExpressionConverter.ConvertO(bodylistingPoliciesshippingCostOverrides);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciestakeBackPolicyId != null)
                {
                    listingPoliciesObject["takeBackPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciestakeBackPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (listingPoliciesObjectpropCount > 0)
                {
                    body["listingPolicies"] = listingPoliciesObject;
                    bodypropCount++;
                }

                if (bodylistingStartDate != null)
                {
                    body["listingStartDate"] = ExpressionConverter.ConvertO(bodylistingStartDate);
                    bodypropCount++;
                }

                if (bodylotSize != null)
                {
                    body["lotSize"] = ExpressionConverter.ConvertO(bodylotSize);
                    bodypropCount++;
                }

                if (bodymarketplaceId != null)
                {
                    body["marketplaceId"] = ExpressionConverter.ConvertO(bodymarketplaceId);
                    bodypropCount++;
                }

                if (bodymerchantLocationKey != null)
                {
                    body["merchantLocationKey"] = ExpressionConverter.ConvertO(bodymerchantLocationKey);
                    bodypropCount++;
                }

                var pricingSummaryObject = new JObject();
                var pricingSummaryObjectpropCount = 0;
                var auctionReservePriceObject = new JObject();
                var auctionReservePriceObjectpropCount = 0;
                if (bodypricingSummaryauctionReservePricecurrency != null)
                {
                    auctionReservePriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionReservePricecurrency);
                    auctionReservePriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionReservePricevalue != null)
                {
                    auctionReservePriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionReservePricevalue);
                    auctionReservePriceObjectpropCount++;
                }

                if (auctionReservePriceObjectpropCount > 0)
                {
                    pricingSummaryObject["auctionReservePrice"] = auctionReservePriceObject;
                    pricingSummaryObjectpropCount++;
                }

                var auctionStartPriceObject = new JObject();
                var auctionStartPriceObjectpropCount = 0;
                if (bodypricingSummaryauctionStartPricecurrency != null)
                {
                    auctionStartPriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionStartPricecurrency);
                    auctionStartPriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionStartPricevalue != null)
                {
                    auctionStartPriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionStartPricevalue);
                    auctionStartPriceObjectpropCount++;
                }

                if (auctionStartPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["auctionStartPrice"] = auctionStartPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                var minimumAdvertisedPriceObject = new JObject();
                var minimumAdvertisedPriceObjectpropCount = 0;
                if (bodypricingSummaryminimumAdvertisedPricecurrency != null)
                {
                    minimumAdvertisedPriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryminimumAdvertisedPricecurrency);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (bodypricingSummaryminimumAdvertisedPricevalue != null)
                {
                    minimumAdvertisedPriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryminimumAdvertisedPricevalue);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (minimumAdvertisedPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["minimumAdvertisedPrice"] = minimumAdvertisedPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummaryoriginallySoldForRetailPriceOn != null)
                {
                    pricingSummaryObject["originallySoldForRetailPriceOn"] = ExpressionConverter.ConvertO(bodypricingSummaryoriginallySoldForRetailPriceOn);
                    pricingSummaryObjectpropCount++;
                }

                var originalRetailPriceObject = new JObject();
                var originalRetailPriceObjectpropCount = 0;
                if (bodypricingSummaryoriginalRetailPricecurrency != null)
                {
                    originalRetailPriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryoriginalRetailPricecurrency);
                    originalRetailPriceObjectpropCount++;
                }

                if (bodypricingSummaryoriginalRetailPricevalue != null)
                {
                    originalRetailPriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryoriginalRetailPricevalue);
                    originalRetailPriceObjectpropCount++;
                }

                if (originalRetailPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["originalRetailPrice"] = originalRetailPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                var priceObject = new JObject();
                var priceObjectpropCount = 0;
                if (bodypricingSummarypricecurrency != null)
                {
                    priceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummarypricecurrency);
                    priceObjectpropCount++;
                }

                if (bodypricingSummarypricevalue != null)
                {
                    priceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummarypricevalue);
                    priceObjectpropCount++;
                }

                if (priceObjectpropCount > 0)
                {
                    pricingSummaryObject["price"] = priceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummarypricingVisibility != null)
                {
                    pricingSummaryObject["pricingVisibility"] = ExpressionConverter.ConvertO(bodypricingSummarypricingVisibility);
                    pricingSummaryObjectpropCount++;
                }

                if (pricingSummaryObjectpropCount > 0)
                {
                    body["pricingSummary"] = pricingSummaryObject;
                    bodypropCount++;
                }

                if (bodyquantityLimitPerBuyer != null)
                {
                    body["quantityLimitPerBuyer"] = ExpressionConverter.ConvertO(bodyquantityLimitPerBuyer);
                    bodypropCount++;
                }

                if (bodysecondaryCategoryId != null)
                {
                    body["secondaryCategoryId"] = ExpressionConverter.ConvertO(bodysecondaryCategoryId);
                    bodypropCount++;
                }

                if (bodysku != null)
                {
                    body["sku"] = ExpressionConverter.ConvertO(bodysku);
                    bodypropCount++;
                }

                if (bodystoreCategoryNames != null)
                {
                    body["storeCategoryNames"] = ExpressionConverter.ConvertO(bodystoreCategoryNames);
                    bodypropCount++;
                }

                var taxObject = new JObject();
                var taxObjectpropCount = 0;
                if (bodytaxapplyTax != null)
                {
                    taxObject["applyTax"] = ExpressionConverter.ConvertO(bodytaxapplyTax);
                    taxObjectpropCount++;
                }

                if (bodytaxthirdPartyTaxCategory != null)
                {
                    taxObject["thirdPartyTaxCategory"] = ExpressionConverter.ConvertO(bodytaxthirdPartyTaxCategory);
                    taxObjectpropCount++;
                }

                if (bodytaxvatPercentage != null)
                {
                    taxObject["vatPercentage"] = ExpressionConverter.ConvertO(bodytaxvatPercentage);
                    taxObjectpropCount++;
                }

                if (taxObjectpropCount > 0)
                {
                    body["tax"] = taxObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildGetOffer))]
        public IBodyWorkflowAction<GetOfferResponse> GetOffer([WorkflowExpression] Func<string> offerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetOfferResponse> __BuildGetOffer(WorkflowExpression<string> offerId)
        {
            WorkflowExpression.Validate(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<GetOfferResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}", ExpressionConverter.ConvertWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<GetOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteOffer))]
        public IBodyWorkflowAction<string> DeleteOffer([WorkflowExpression] Func<string> offerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDeleteOffer(WorkflowExpression<string> offerId)
        {
            WorkflowExpression.Validate(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}", ExpressionConverter.ConvertWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateOffer))]
        public IBodyWorkflowAction<UpdateOfferResponse> UpdateOffer([WorkflowExpression] Func<string> offerId, [WorkflowExpression] Func<int> bodyavailableQuantity = null, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<string> bodycharitycharityId = null, [WorkflowExpression] Func<string> bodycharitydonationPercentage = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproducerProductId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityshipmentPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductDocumentationId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeecurrency = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeevalue = null, [WorkflowExpression] Func<bool> bodyhideBuyerDetails = null, [WorkflowExpression] Func<bool> bodyincludeCatalogProductDetails = null, [WorkflowExpression] Func<string> bodylistingDescription = null, [WorkflowExpression] Func<bodylistingDurationInput> bodylistingDuration = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricevalue = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricevalue = null, [WorkflowExpression] Func<bool> bodylistingPoliciesbestOfferTermsbestOfferEnabled = null, [WorkflowExpression] Func<bool> bodylistingPolicieseBayPlusIfEligible = null, [WorkflowExpression] Func<string> bodylistingPoliciesfulfillmentPolicyId = null, [WorkflowExpression] Func<string> bodylistingPoliciespaymentPolicyId = null, [WorkflowExpression] Func<string[]> bodylistingPoliciesproductCompliancePolicyIds = null, [WorkflowExpression] Func<string> bodylistingPoliciesreturnPolicyId = null, [WorkflowExpression] Func<bodylistingPoliciesshippingCostOverridesInputItem2[]> bodylistingPoliciesshippingCostOverrides = null, [WorkflowExpression] Func<string> bodylistingPoliciestakeBackPolicyId = null, [WorkflowExpression] Func<string> bodylistingStartDate = null, [WorkflowExpression] Func<int> bodylotSize = null, [WorkflowExpression] Func<string> bodymerchantLocationKey = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricevalue = null, [WorkflowExpression] Func<bodypricingSummaryoriginallySoldForRetailPriceOnInput> bodypricingSummaryoriginallySoldForRetailPriceOn = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummarypricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummarypricevalue = null, [WorkflowExpression] Func<bodypricingSummarypricingVisibilityInput> bodypricingSummarypricingVisibility = null, [WorkflowExpression] Func<int> bodyquantityLimitPerBuyer = null, [WorkflowExpression] Func<string> bodysecondaryCategoryId = null, [WorkflowExpression] Func<string[]> bodystoreCategoryNames = null, [WorkflowExpression] Func<bool> bodytaxapplyTax = null, [WorkflowExpression] Func<string> bodytaxthirdPartyTaxCategory = null, [WorkflowExpression] Func<double> bodytaxvatPercentage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateOfferResponse> __BuildUpdateOffer(WorkflowExpression<string> offerId, WorkflowExpression<int> bodyavailableQuantity = null, WorkflowExpression<string> bodycategoryId = null, WorkflowExpression<string> bodycharitycharityId = null, WorkflowExpression<string> bodycharitydonationPercentage = null, WorkflowExpression<string> bodyextendedProducerResponsibilityproducerProductId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityproductPackageId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityshipmentPackageId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityproductDocumentationId = null, WorkflowExpression<string> bodyextendedProducerResponsibilityecoParticipationFeecurrency = null, WorkflowExpression<string> bodyextendedProducerResponsibilityecoParticipationFeevalue = null, WorkflowExpression<bool> bodyhideBuyerDetails = null, WorkflowExpression<bool> bodyincludeCatalogProductDetails = null, WorkflowExpression<string> bodylistingDescription = null, WorkflowExpression<bodylistingDurationInput> bodylistingDuration = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoAcceptPricevalue = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency = null, WorkflowExpression<string> bodylistingPoliciesbestOfferTermsautoDeclinePricevalue = null, WorkflowExpression<bool> bodylistingPoliciesbestOfferTermsbestOfferEnabled = null, WorkflowExpression<bool> bodylistingPolicieseBayPlusIfEligible = null, WorkflowExpression<string> bodylistingPoliciesfulfillmentPolicyId = null, WorkflowExpression<string> bodylistingPoliciespaymentPolicyId = null, WorkflowExpression<string[]> bodylistingPoliciesproductCompliancePolicyIds = null, WorkflowExpression<string> bodylistingPoliciesreturnPolicyId = null, WorkflowExpression<bodylistingPoliciesshippingCostOverridesInputItem2[]> bodylistingPoliciesshippingCostOverrides = null, WorkflowExpression<string> bodylistingPoliciestakeBackPolicyId = null, WorkflowExpression<string> bodylistingStartDate = null, WorkflowExpression<int> bodylotSize = null, WorkflowExpression<string> bodymerchantLocationKey = null, WorkflowExpression<string> bodypricingSummaryauctionReservePricecurrency = null, WorkflowExpression<string> bodypricingSummaryauctionReservePricevalue = null, WorkflowExpression<string> bodypricingSummaryauctionStartPricecurrency = null, WorkflowExpression<string> bodypricingSummaryauctionStartPricevalue = null, WorkflowExpression<string> bodypricingSummaryminimumAdvertisedPricecurrency = null, WorkflowExpression<string> bodypricingSummaryminimumAdvertisedPricevalue = null, WorkflowExpression<bodypricingSummaryoriginallySoldForRetailPriceOnInput> bodypricingSummaryoriginallySoldForRetailPriceOn = null, WorkflowExpression<string> bodypricingSummaryoriginalRetailPricecurrency = null, WorkflowExpression<string> bodypricingSummaryoriginalRetailPricevalue = null, WorkflowExpression<string> bodypricingSummarypricecurrency = null, WorkflowExpression<string> bodypricingSummarypricevalue = null, WorkflowExpression<bodypricingSummarypricingVisibilityInput> bodypricingSummarypricingVisibility = null, WorkflowExpression<int> bodyquantityLimitPerBuyer = null, WorkflowExpression<string> bodysecondaryCategoryId = null, WorkflowExpression<string[]> bodystoreCategoryNames = null, WorkflowExpression<bool> bodytaxapplyTax = null, WorkflowExpression<string> bodytaxthirdPartyTaxCategory = null, WorkflowExpression<double> bodytaxvatPercentage = null)
        {
            WorkflowExpression.Validate(offerId, nameof(offerId), required: true);
            WorkflowExpression.Validate(bodyavailableQuantity, nameof(bodyavailableQuantity), required: false);
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            WorkflowExpression.Validate(bodycharitycharityId, nameof(bodycharitycharityId), required: false);
            WorkflowExpression.Validate(bodycharitydonationPercentage, nameof(bodycharitydonationPercentage), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityproducerProductId, nameof(bodyextendedProducerResponsibilityproducerProductId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityproductPackageId, nameof(bodyextendedProducerResponsibilityproductPackageId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityshipmentPackageId, nameof(bodyextendedProducerResponsibilityshipmentPackageId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityproductDocumentationId, nameof(bodyextendedProducerResponsibilityproductDocumentationId), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeecurrency, nameof(bodyextendedProducerResponsibilityecoParticipationFeecurrency), required: false);
            WorkflowExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeevalue, nameof(bodyextendedProducerResponsibilityecoParticipationFeevalue), required: false);
            WorkflowExpression.Validate(bodyhideBuyerDetails, nameof(bodyhideBuyerDetails), required: false);
            WorkflowExpression.Validate(bodyincludeCatalogProductDetails, nameof(bodyincludeCatalogProductDetails), required: false);
            WorkflowExpression.Validate(bodylistingDescription, nameof(bodylistingDescription), required: false);
            WorkflowExpression.Validate(bodylistingDuration, nameof(bodylistingDuration), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesbestOfferTermsbestOfferEnabled, nameof(bodylistingPoliciesbestOfferTermsbestOfferEnabled), required: false);
            WorkflowExpression.Validate(bodylistingPolicieseBayPlusIfEligible, nameof(bodylistingPolicieseBayPlusIfEligible), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesfulfillmentPolicyId, nameof(bodylistingPoliciesfulfillmentPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingPoliciespaymentPolicyId, nameof(bodylistingPoliciespaymentPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesproductCompliancePolicyIds, nameof(bodylistingPoliciesproductCompliancePolicyIds), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesreturnPolicyId, nameof(bodylistingPoliciesreturnPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingPoliciesshippingCostOverrides, nameof(bodylistingPoliciesshippingCostOverrides), required: false);
            WorkflowExpression.Validate(bodylistingPoliciestakeBackPolicyId, nameof(bodylistingPoliciestakeBackPolicyId), required: false);
            WorkflowExpression.Validate(bodylistingStartDate, nameof(bodylistingStartDate), required: false);
            WorkflowExpression.Validate(bodylotSize, nameof(bodylotSize), required: false);
            WorkflowExpression.Validate(bodymerchantLocationKey, nameof(bodymerchantLocationKey), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionReservePricecurrency, nameof(bodypricingSummaryauctionReservePricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionReservePricevalue, nameof(bodypricingSummaryauctionReservePricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionStartPricecurrency, nameof(bodypricingSummaryauctionStartPricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryauctionStartPricevalue, nameof(bodypricingSummaryauctionStartPricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummaryminimumAdvertisedPricecurrency, nameof(bodypricingSummaryminimumAdvertisedPricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryminimumAdvertisedPricevalue, nameof(bodypricingSummaryminimumAdvertisedPricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummaryoriginallySoldForRetailPriceOn, nameof(bodypricingSummaryoriginallySoldForRetailPriceOn), required: false);
            WorkflowExpression.Validate(bodypricingSummaryoriginalRetailPricecurrency, nameof(bodypricingSummaryoriginalRetailPricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummaryoriginalRetailPricevalue, nameof(bodypricingSummaryoriginalRetailPricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummarypricecurrency, nameof(bodypricingSummarypricecurrency), required: false);
            WorkflowExpression.Validate(bodypricingSummarypricevalue, nameof(bodypricingSummarypricevalue), required: false);
            WorkflowExpression.Validate(bodypricingSummarypricingVisibility, nameof(bodypricingSummarypricingVisibility), required: false);
            WorkflowExpression.Validate(bodyquantityLimitPerBuyer, nameof(bodyquantityLimitPerBuyer), required: false);
            WorkflowExpression.Validate(bodysecondaryCategoryId, nameof(bodysecondaryCategoryId), required: false);
            WorkflowExpression.Validate(bodystoreCategoryNames, nameof(bodystoreCategoryNames), required: false);
            WorkflowExpression.Validate(bodytaxapplyTax, nameof(bodytaxapplyTax), required: false);
            WorkflowExpression.Validate(bodytaxthirdPartyTaxCategory, nameof(bodytaxthirdPartyTaxCategory), required: false);
            WorkflowExpression.Validate(bodytaxvatPercentage, nameof(bodytaxvatPercentage), required: false);
            return new DeferredBodyAction<UpdateOfferResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}", ExpressionConverter.ConvertWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Language"] = Convert.ToString("en-US");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyavailableQuantity != null)
                {
                    body["availableQuantity"] = ExpressionConverter.ConvertO(bodyavailableQuantity);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                    bodypropCount++;
                }

                var charityObject = new JObject();
                var charityObjectpropCount = 0;
                if (bodycharitycharityId != null)
                {
                    charityObject["charityId"] = ExpressionConverter.ConvertO(bodycharitycharityId);
                    charityObjectpropCount++;
                }

                if (bodycharitydonationPercentage != null)
                {
                    charityObject["donationPercentage"] = ExpressionConverter.ConvertO(bodycharitydonationPercentage);
                    charityObjectpropCount++;
                }

                if (charityObjectpropCount > 0)
                {
                    body["charity"] = charityObject;
                    bodypropCount++;
                }

                var extendedProducerResponsibilityObject = new JObject();
                var extendedProducerResponsibilityObjectpropCount = 0;
                if (bodyextendedProducerResponsibilityproducerProductId != null)
                {
                    extendedProducerResponsibilityObject["producerProductId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityproducerProductId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductPackageId != null)
                {
                    extendedProducerResponsibilityObject["productPackageId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityproductPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityshipmentPackageId != null)
                {
                    extendedProducerResponsibilityObject["shipmentPackageId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityshipmentPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductDocumentationId != null)
                {
                    extendedProducerResponsibilityObject["productDocumentationId"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityproductDocumentationId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                var ecoParticipationFeeObject = new JObject();
                var ecoParticipationFeeObjectpropCount = 0;
                if (bodyextendedProducerResponsibilityecoParticipationFeecurrency != null)
                {
                    ecoParticipationFeeObject["currency"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityecoParticipationFeecurrency);
                    ecoParticipationFeeObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityecoParticipationFeevalue != null)
                {
                    ecoParticipationFeeObject["value"] = ExpressionConverter.ConvertO(bodyextendedProducerResponsibilityecoParticipationFeevalue);
                    ecoParticipationFeeObjectpropCount++;
                }

                if (ecoParticipationFeeObjectpropCount > 0)
                {
                    extendedProducerResponsibilityObject["ecoParticipationFee"] = ecoParticipationFeeObject;
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (extendedProducerResponsibilityObjectpropCount > 0)
                {
                    body["extendedProducerResponsibility"] = extendedProducerResponsibilityObject;
                    bodypropCount++;
                }

                if (bodyhideBuyerDetails != null)
                {
                    body["hideBuyerDetails"] = ExpressionConverter.ConvertO(bodyhideBuyerDetails);
                    bodypropCount++;
                }

                if (bodyincludeCatalogProductDetails != null)
                {
                    body["includeCatalogProductDetails"] = ExpressionConverter.ConvertO(bodyincludeCatalogProductDetails);
                    bodypropCount++;
                }

                if (bodylistingDescription != null)
                {
                    body["listingDescription"] = ExpressionConverter.ConvertO(bodylistingDescription);
                    bodypropCount++;
                }

                if (bodylistingDuration != null)
                {
                    body["listingDuration"] = ExpressionConverter.ConvertO(bodylistingDuration);
                    bodypropCount++;
                }

                var listingPoliciesObject = new JObject();
                var listingPoliciesObjectpropCount = 0;
                var bestOfferTermsObject = new JObject();
                var bestOfferTermsObjectpropCount = 0;
                var autoAcceptPriceObject = new JObject();
                var autoAcceptPriceObjectpropCount = 0;
                if (bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency != null)
                {
                    autoAcceptPriceObject["currency"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency);
                    autoAcceptPriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoAcceptPricevalue != null)
                {
                    autoAcceptPriceObject["value"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue);
                    autoAcceptPriceObjectpropCount++;
                }

                if (autoAcceptPriceObjectpropCount > 0)
                {
                    bestOfferTermsObject["autoAcceptPrice"] = autoAcceptPriceObject;
                    bestOfferTermsObjectpropCount++;
                }

                var autoDeclinePriceObject = new JObject();
                var autoDeclinePriceObjectpropCount = 0;
                if (bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency != null)
                {
                    autoDeclinePriceObject["currency"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency);
                    autoDeclinePriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoDeclinePricevalue != null)
                {
                    autoDeclinePriceObject["value"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue);
                    autoDeclinePriceObjectpropCount++;
                }

                if (autoDeclinePriceObjectpropCount > 0)
                {
                    bestOfferTermsObject["autoDeclinePrice"] = autoDeclinePriceObject;
                    bestOfferTermsObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsbestOfferEnabled != null)
                {
                    bestOfferTermsObject["bestOfferEnabled"] = ExpressionConverter.ConvertO(bodylistingPoliciesbestOfferTermsbestOfferEnabled);
                    bestOfferTermsObjectpropCount++;
                }

                if (bestOfferTermsObjectpropCount > 0)
                {
                    listingPoliciesObject["bestOfferTerms"] = bestOfferTermsObject;
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPolicieseBayPlusIfEligible != null)
                {
                    listingPoliciesObject["eBayPlusIfEligible"] = ExpressionConverter.ConvertO(bodylistingPolicieseBayPlusIfEligible);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesfulfillmentPolicyId != null)
                {
                    listingPoliciesObject["fulfillmentPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciesfulfillmentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciespaymentPolicyId != null)
                {
                    listingPoliciesObject["paymentPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciespaymentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesproductCompliancePolicyIds != null)
                {
                    listingPoliciesObject["productCompliancePolicyIds"] = ExpressionConverter.ConvertO(bodylistingPoliciesproductCompliancePolicyIds);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesreturnPolicyId != null)
                {
                    listingPoliciesObject["returnPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciesreturnPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesshippingCostOverrides != null)
                {
                    listingPoliciesObject["shippingCostOverrides"] = ExpressionConverter.ConvertO(bodylistingPoliciesshippingCostOverrides);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciestakeBackPolicyId != null)
                {
                    listingPoliciesObject["takeBackPolicyId"] = ExpressionConverter.ConvertO(bodylistingPoliciestakeBackPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (listingPoliciesObjectpropCount > 0)
                {
                    body["listingPolicies"] = listingPoliciesObject;
                    bodypropCount++;
                }

                if (bodylistingStartDate != null)
                {
                    body["listingStartDate"] = ExpressionConverter.ConvertO(bodylistingStartDate);
                    bodypropCount++;
                }

                if (bodylotSize != null)
                {
                    body["lotSize"] = ExpressionConverter.ConvertO(bodylotSize);
                    bodypropCount++;
                }

                if (bodymerchantLocationKey != null)
                {
                    body["merchantLocationKey"] = ExpressionConverter.ConvertO(bodymerchantLocationKey);
                    bodypropCount++;
                }

                var pricingSummaryObject = new JObject();
                var pricingSummaryObjectpropCount = 0;
                var auctionReservePriceObject = new JObject();
                var auctionReservePriceObjectpropCount = 0;
                if (bodypricingSummaryauctionReservePricecurrency != null)
                {
                    auctionReservePriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionReservePricecurrency);
                    auctionReservePriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionReservePricevalue != null)
                {
                    auctionReservePriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionReservePricevalue);
                    auctionReservePriceObjectpropCount++;
                }

                if (auctionReservePriceObjectpropCount > 0)
                {
                    pricingSummaryObject["auctionReservePrice"] = auctionReservePriceObject;
                    pricingSummaryObjectpropCount++;
                }

                var auctionStartPriceObject = new JObject();
                var auctionStartPriceObjectpropCount = 0;
                if (bodypricingSummaryauctionStartPricecurrency != null)
                {
                    auctionStartPriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionStartPricecurrency);
                    auctionStartPriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionStartPricevalue != null)
                {
                    auctionStartPriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryauctionStartPricevalue);
                    auctionStartPriceObjectpropCount++;
                }

                if (auctionStartPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["auctionStartPrice"] = auctionStartPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                var minimumAdvertisedPriceObject = new JObject();
                var minimumAdvertisedPriceObjectpropCount = 0;
                if (bodypricingSummaryminimumAdvertisedPricecurrency != null)
                {
                    minimumAdvertisedPriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryminimumAdvertisedPricecurrency);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (bodypricingSummaryminimumAdvertisedPricevalue != null)
                {
                    minimumAdvertisedPriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryminimumAdvertisedPricevalue);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (minimumAdvertisedPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["minimumAdvertisedPrice"] = minimumAdvertisedPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummaryoriginallySoldForRetailPriceOn != null)
                {
                    pricingSummaryObject["originallySoldForRetailPriceOn"] = ExpressionConverter.ConvertO(bodypricingSummaryoriginallySoldForRetailPriceOn);
                    pricingSummaryObjectpropCount++;
                }

                var originalRetailPriceObject = new JObject();
                var originalRetailPriceObjectpropCount = 0;
                if (bodypricingSummaryoriginalRetailPricecurrency != null)
                {
                    originalRetailPriceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummaryoriginalRetailPricecurrency);
                    originalRetailPriceObjectpropCount++;
                }

                if (bodypricingSummaryoriginalRetailPricevalue != null)
                {
                    originalRetailPriceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummaryoriginalRetailPricevalue);
                    originalRetailPriceObjectpropCount++;
                }

                if (originalRetailPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["originalRetailPrice"] = originalRetailPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                var priceObject = new JObject();
                var priceObjectpropCount = 0;
                if (bodypricingSummarypricecurrency != null)
                {
                    priceObject["currency"] = ExpressionConverter.ConvertO(bodypricingSummarypricecurrency);
                    priceObjectpropCount++;
                }

                if (bodypricingSummarypricevalue != null)
                {
                    priceObject["value"] = ExpressionConverter.ConvertO(bodypricingSummarypricevalue);
                    priceObjectpropCount++;
                }

                if (priceObjectpropCount > 0)
                {
                    pricingSummaryObject["price"] = priceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummarypricingVisibility != null)
                {
                    pricingSummaryObject["pricingVisibility"] = ExpressionConverter.ConvertO(bodypricingSummarypricingVisibility);
                    pricingSummaryObjectpropCount++;
                }

                if (pricingSummaryObjectpropCount > 0)
                {
                    body["pricingSummary"] = pricingSummaryObject;
                    bodypropCount++;
                }

                if (bodyquantityLimitPerBuyer != null)
                {
                    body["quantityLimitPerBuyer"] = ExpressionConverter.ConvertO(bodyquantityLimitPerBuyer);
                    bodypropCount++;
                }

                if (bodysecondaryCategoryId != null)
                {
                    body["secondaryCategoryId"] = ExpressionConverter.ConvertO(bodysecondaryCategoryId);
                    bodypropCount++;
                }

                if (bodystoreCategoryNames != null)
                {
                    body["storeCategoryNames"] = ExpressionConverter.ConvertO(bodystoreCategoryNames);
                    bodypropCount++;
                }

                var taxObject = new JObject();
                var taxObjectpropCount = 0;
                if (bodytaxapplyTax != null)
                {
                    taxObject["applyTax"] = ExpressionConverter.ConvertO(bodytaxapplyTax);
                    taxObjectpropCount++;
                }

                if (bodytaxthirdPartyTaxCategory != null)
                {
                    taxObject["thirdPartyTaxCategory"] = ExpressionConverter.ConvertO(bodytaxthirdPartyTaxCategory);
                    taxObjectpropCount++;
                }

                if (bodytaxvatPercentage != null)
                {
                    taxObject["vatPercentage"] = ExpressionConverter.ConvertO(bodytaxvatPercentage);
                    taxObjectpropCount++;
                }

                if (taxObjectpropCount > 0)
                {
                    body["tax"] = taxObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildWithdrawOffer))]
        public IBodyWorkflowAction<WithdrawOfferResponse> WithdrawOffer([WorkflowExpression] Func<string> offerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WithdrawOfferResponse> __BuildWithdrawOffer(WorkflowExpression<string> offerId)
        {
            WorkflowExpression.Validate(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<WithdrawOfferResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}/withdraw", ExpressionConverter.ConvertWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return new ApiConnectionAction<WithdrawOfferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [WorkflowExpressionFactory(nameof(__BuildPublishOffer))]
        public IBodyWorkflowAction<PublishOfferResponse> PublishOffer([WorkflowExpression] Func<string> offerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PublishOfferResponse> __BuildPublishOffer(WorkflowExpression<string> offerId)
        {
            WorkflowExpression.Validate(offerId, nameof(offerId), required: true);
            return new DeferredBodyAction<PublishOfferResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}/publish/", ExpressionConverter.ConvertWithUrlEncoding(offerId, 1));
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

    public class bodyavailabilitypickupAtLocationAvailabilityInputItem
    {
        [JsonProperty("availabilityType")]
        public bodyavailabilitypickupAtLocationAvailabilityInputItemAvailabilityTypeType AvailabilityType { get; set; }

        [JsonProperty("fulfillmentTime")]
        public bodyavailabilitypickupAtLocationAvailabilityInputItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public enum bodyavailabilitypickupAtLocationAvailabilityInputItemAvailabilityTypeType
    {
        [EnumMember(Value = "IN_STOCK")]
        INSTOCK,
        [EnumMember(Value = "OUT_OF_STOCK")]
        OUTOFSTOCK,
        [EnumMember(Value = "SHIP_TO_STORE")]
        SHIPTOSTORE
    }

    public class bodyavailabilitypickupAtLocationAvailabilityInputItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public bodyavailabilitypickupAtLocationAvailabilityInputItemFulfillmentTimeTypeUnitType Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public enum bodyavailabilitypickupAtLocationAvailabilityInputItemFulfillmentTimeTypeUnitType
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

    public class bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItem
    {
        [JsonProperty("fulfillmentTime")]
        public bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItemFulfillmentTimeType FulfillmentTime { get; set; }

        [JsonProperty("merchantLocationKey")]
        public string MerchantLocationKey { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }

    public class bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItemFulfillmentTimeType
    {
        [JsonProperty("unit")]
        public bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItemFulfillmentTimeTypeUnitType Unit { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public enum bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItemFulfillmentTimeTypeUnitType
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

    public enum bodyconditionInput
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

    public enum bodypackageWeightAndSizedimensionsunitInput
    {
        INCH,
        FEET,
        CENTIMETER,
        METER
    }

    public enum bodypackageWeightAndSizepackageTypeInput
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

    public enum bodypackageWeightAndSizeweightunitInput
    {
        POUND,
        KILOGRAM,
        OUNCE,
        GRAM
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

    public enum bodylocationTypesInputItem
    {
        STORE,
        WAREHOUSE
    }

    public class bodyoperatingHoursInputItem
    {
        [JsonProperty("dayOfWeekEnum")]
        public bodyoperatingHoursInputItemDayOfWeekEnumType DayOfWeekEnum { get; set; }

        [JsonProperty("intervals")]
        public bodyoperatingHoursInputItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public enum bodyoperatingHoursInputItemDayOfWeekEnumType
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,
        SUNDAY
    }

    public class bodyoperatingHoursInputItemIntervalsTypeItem
    {
        [JsonProperty("close")]
        public string Close { get; set; }

        [JsonProperty("open")]
        public string Open { get; set; }
    }

    public class bodyspecialHoursInputItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("intervals")]
        public bodyspecialHoursInputItemIntervalsTypeItem[] Intervals { get; set; }
    }

    public class bodyspecialHoursInputItemIntervalsTypeItem
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

    public enum bodyformatInput
    {
        AUCTION,
        [EnumMember(Value = "FIXED_PRICE")]
        FIXEDPRICE
    }

    public enum bodylistingDurationInput
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

    public class bodylistingPoliciesshippingCostOverridesInputItem
    {
        [JsonProperty("additionalShippingCost")]
        public bodylistingPoliciesshippingCostOverridesInputItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("shippingCost")]
        public bodylistingPoliciesshippingCostOverridesInputItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceType")]
        public bodylistingPoliciesshippingCostOverridesInputItemShippingServiceTypeType ShippingServiceType { get; set; }
    }

    public class bodylistingPoliciesshippingCostOverridesInputItemAdditionalShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodylistingPoliciesshippingCostOverridesInputItemShippingCostType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodylistingPoliciesshippingCostOverridesInputItemShippingServiceTypeType
    {
        DOMESTIC,
        INTERNATIONAL
    }

    public enum bodypricingSummaryoriginallySoldForRetailPriceOnInput
    {
        [EnumMember(Value = "ON_EBAY")]
        ONEBAY,
        [EnumMember(Value = "OFF_EBAY")]
        OFFEBAY,
        [EnumMember(Value = "ON_AND_OFF_EBAY")]
        ONANDOFFEBAY
    }

    public enum bodypricingSummarypricingVisibilityInput
    {
        NONE,
        [EnumMember(Value = "PRE_CHECKOUT")]
        PRECHECKOUT,
        [EnumMember(Value = "DURING_CHECKOUT")]
        DURINGCHECKOUT
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

    public class bodylistingPoliciesshippingCostOverridesInputItem2
    {
        [JsonProperty("additionalShippingCost")]
        public bodylistingPoliciesshippingCostOverridesInputItemAdditionalShippingCostType AdditionalShippingCost { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("shippingCost")]
        public bodylistingPoliciesshippingCostOverridesInputItemShippingCostType ShippingCost { get; set; }

        [JsonProperty("shippingServiceType")]
        public bodylistingPoliciesshippingCostOverridesInputItemShippingServiceTypeType ShippingServiceType { get; set; }
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