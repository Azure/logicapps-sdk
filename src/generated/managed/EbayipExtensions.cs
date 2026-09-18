//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ebayip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EbayipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetDefaultCategoryTreeIdResponse> GetDefaultCategoryTreeId([WorkflowExpression] Func<string> marketplaceId, [WorkflowExpression] Func<string> acceptLanguage)
        {
            SourceExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            SourceExpression.Validate(acceptLanguage, nameof(acceptLanguage), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/commerce/taxonomy/v1/get_default_category_tree_id";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = SourceExpressionConverter.ConvertO(marketplaceId);
                callPayload.Headers["Accept-Language"] = SourceExpressionConverter.ConvertO(acceptLanguage);
                return callPayload;
            }

            return new ApiConnectionAction<GetDefaultCategoryTreeIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetCategorySuggestionsResponse> GetCategorySuggestions([WorkflowExpression] Func<string> categoryTreeId, [WorkflowExpression] Func<string> q)
        {
            SourceExpression.Validate(categoryTreeId, nameof(categoryTreeId), required: true);
            SourceExpression.Validate(q, nameof(q), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commerce/taxonomy/v1/category_tree/{0}/get_category_suggestions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryTreeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Accept-Encoding"] = Convert.ToString("application/gzip");
                return callPayload;
            }

            return new ApiConnectionAction<GetCategorySuggestionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetItemAspectsResponse> GetItemAspects([WorkflowExpression] Func<string> categoryTreeId, [WorkflowExpression] Func<string> categoryId)
        {
            SourceExpression.Validate(categoryTreeId, nameof(categoryTreeId), required: true);
            SourceExpression.Validate(categoryId, nameof(categoryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commerce/taxonomy/v1/category_tree/{0}/get_item_aspects_for_category", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(categoryTreeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["category_id"] = SourceExpressionConverter.ConvertO(categoryId);
                return callPayload;
            }

            return new ApiConnectionAction<GetItemAspectsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetFulfillmentPoliciesResponse> GetFulfillmentPolicies([WorkflowExpression] Func<string> marketplaceId)
        {
            SourceExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sell/account/v1/fulfillment_policy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = SourceExpressionConverter.ConvertO(marketplaceId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFulfillmentPoliciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetFulfillmentPolicyResponse> GetFulfillmentPolicy([WorkflowExpression] Func<string> fulfillmentPolicyId)
        {
            SourceExpression.Validate(fulfillmentPolicyId, nameof(fulfillmentPolicyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/account/v1/fulfillment_policy/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fulfillmentPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFulfillmentPolicyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetPaymentPolicyResponse> GetPaymentPolicy([WorkflowExpression] Func<string> paymentPolicyId)
        {
            SourceExpression.Validate(paymentPolicyId, nameof(paymentPolicyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/account/v1/payment_policy/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(paymentPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPaymentPolicyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetReturnPoliciesResponse> GetReturnPolicies([WorkflowExpression] Func<string> marketplaceId)
        {
            SourceExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sell/account/v1/return_policy";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["marketplace_id"] = SourceExpressionConverter.ConvertO(marketplaceId);
                return callPayload;
            }

            return new ApiConnectionAction<GetReturnPoliciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetReturnPolicyResponse> GetReturnPolicy([WorkflowExpression] Func<string> returnPolicyId)
        {
            SourceExpression.Validate(returnPolicyId, nameof(returnPolicyId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/account/v1/return_policy/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(returnPolicyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetReturnPolicyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryItemResponse> GetInventoryItem([WorkflowExpression] Func<string> sku)
        {
            SourceExpression.Validate(sku, nameof(sku), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/inventory_item/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sku, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return callPayload;
            }

            return new ApiConnectionAction<GetInventoryItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<CreateOrReplaceInventoryItemResponse> CreateOrReplaceInventoryItem([WorkflowExpression] Func<string> sku, [WorkflowExpression] Func<string> contentLanguage, [WorkflowExpression] Func<bodyavailabilitypickupAtLocationAvailabilityInputItem[]> bodyavailabilitypickupAtLocationAvailability = null, [WorkflowExpression] Func<bodyavailabilityshipToLocationAvailabilityavailabilityDistributionsInputItem[]> bodyavailabilityshipToLocationAvailabilityavailabilityDistributions = null, [WorkflowExpression] Func<int> bodyavailabilityshipToLocationAvailabilityquantity = null, [WorkflowExpression] Func<bodyconditionInput> bodycondition = null, [WorkflowExpression] Func<string> bodyconditionDescription = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizedimensionsheight = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizedimensionslength = null, [WorkflowExpression] Func<bodypackageWeightAndSizedimensionsunitInput> bodypackageWeightAndSizedimensionsunit = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizedimensionswidth = null, [WorkflowExpression] Func<bodypackageWeightAndSizepackageTypeInput> bodypackageWeightAndSizepackageType = null, [WorkflowExpression] Func<bodypackageWeightAndSizeweightunitInput> bodypackageWeightAndSizeweightunit = null, [WorkflowExpression] Func<double> bodypackageWeightAndSizeweightvalue = null, [WorkflowExpression] Func<string> bodyproductbrand = null, [WorkflowExpression] Func<string> bodyproductdescription = null, [WorkflowExpression] Func<string[]> bodyproductean = null, [WorkflowExpression] Func<string> bodyproductepid = null, [WorkflowExpression] Func<string[]> bodyproductimageUrls = null, [WorkflowExpression] Func<string[]> bodyproductisbn = null, [WorkflowExpression] Func<string> bodyproductmpn = null, [WorkflowExpression] Func<string> bodyproductsubtitle = null, [WorkflowExpression] Func<string> bodyproducttitle = null, [WorkflowExpression] Func<string[]> bodyproductupc = null, [WorkflowExpression] Func<string[]> bodyproductvideoIds = null)
        {
            SourceExpression.Validate(sku, nameof(sku), required: true);
            SourceExpression.Validate(contentLanguage, nameof(contentLanguage), required: true);
            SourceExpression.Validate(bodyavailabilitypickupAtLocationAvailability, nameof(bodyavailabilitypickupAtLocationAvailability), required: false);
            SourceExpression.Validate(bodyavailabilityshipToLocationAvailabilityavailabilityDistributions, nameof(bodyavailabilityshipToLocationAvailabilityavailabilityDistributions), required: false);
            SourceExpression.Validate(bodyavailabilityshipToLocationAvailabilityquantity, nameof(bodyavailabilityshipToLocationAvailabilityquantity), required: false);
            SourceExpression.Validate(bodycondition, nameof(bodycondition), required: false);
            SourceExpression.Validate(bodyconditionDescription, nameof(bodyconditionDescription), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizedimensionsheight, nameof(bodypackageWeightAndSizedimensionsheight), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizedimensionslength, nameof(bodypackageWeightAndSizedimensionslength), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizedimensionsunit, nameof(bodypackageWeightAndSizedimensionsunit), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizedimensionswidth, nameof(bodypackageWeightAndSizedimensionswidth), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizepackageType, nameof(bodypackageWeightAndSizepackageType), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizeweightunit, nameof(bodypackageWeightAndSizeweightunit), required: false);
            SourceExpression.Validate(bodypackageWeightAndSizeweightvalue, nameof(bodypackageWeightAndSizeweightvalue), required: false);
            SourceExpression.Validate(bodyproductbrand, nameof(bodyproductbrand), required: false);
            SourceExpression.Validate(bodyproductdescription, nameof(bodyproductdescription), required: false);
            SourceExpression.Validate(bodyproductean, nameof(bodyproductean), required: false);
            SourceExpression.Validate(bodyproductepid, nameof(bodyproductepid), required: false);
            SourceExpression.Validate(bodyproductimageUrls, nameof(bodyproductimageUrls), required: false);
            SourceExpression.Validate(bodyproductisbn, nameof(bodyproductisbn), required: false);
            SourceExpression.Validate(bodyproductmpn, nameof(bodyproductmpn), required: false);
            SourceExpression.Validate(bodyproductsubtitle, nameof(bodyproductsubtitle), required: false);
            SourceExpression.Validate(bodyproducttitle, nameof(bodyproducttitle), required: false);
            SourceExpression.Validate(bodyproductupc, nameof(bodyproductupc), required: false);
            SourceExpression.Validate(bodyproductvideoIds, nameof(bodyproductvideoIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/inventory_item/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sku, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Content-Language"] = SourceExpressionConverter.ConvertO(contentLanguage);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var availabilityObject = new JObject();
                var availabilityObjectpropCount = 0;
                if (bodyavailabilitypickupAtLocationAvailability != null)
                {
                    availabilityObject["pickupAtLocationAvailability"] = SourceExpressionConverter.ConvertToken(bodyavailabilitypickupAtLocationAvailability);
                    availabilityObjectpropCount++;
                }

                var shipToLocationAvailabilityObject = new JObject();
                var shipToLocationAvailabilityObjectpropCount = 0;
                if (bodyavailabilityshipToLocationAvailabilityavailabilityDistributions != null)
                {
                    shipToLocationAvailabilityObject["availabilityDistributions"] = SourceExpressionConverter.ConvertToken(bodyavailabilityshipToLocationAvailabilityavailabilityDistributions);
                    shipToLocationAvailabilityObjectpropCount++;
                }

                if (bodyavailabilityshipToLocationAvailabilityquantity != null)
                {
                    shipToLocationAvailabilityObject["quantity"] = SourceExpressionConverter.ConvertToken(bodyavailabilityshipToLocationAvailabilityquantity);
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
                    body["condition"] = SourceExpressionConverter.Convert(bodycondition);
                    bodypropCount++;
                }

                if (bodyconditionDescription != null)
                {
                    body["conditionDescription"] = SourceExpressionConverter.ConvertToken(bodyconditionDescription);
                    bodypropCount++;
                }

                var packageWeightAndSizeObject = new JObject();
                var packageWeightAndSizeObjectpropCount = 0;
                var dimensionsObject = new JObject();
                var dimensionsObjectpropCount = 0;
                if (bodypackageWeightAndSizedimensionsheight != null)
                {
                    dimensionsObject["height"] = SourceExpressionConverter.ConvertToken(bodypackageWeightAndSizedimensionsheight);
                    dimensionsObjectpropCount++;
                }

                if (bodypackageWeightAndSizedimensionslength != null)
                {
                    dimensionsObject["length"] = SourceExpressionConverter.ConvertToken(bodypackageWeightAndSizedimensionslength);
                    dimensionsObjectpropCount++;
                }

                if (bodypackageWeightAndSizedimensionsunit != null)
                {
                    dimensionsObject["unit"] = SourceExpressionConverter.Convert(bodypackageWeightAndSizedimensionsunit);
                    dimensionsObjectpropCount++;
                }

                if (bodypackageWeightAndSizedimensionswidth != null)
                {
                    dimensionsObject["width"] = SourceExpressionConverter.ConvertToken(bodypackageWeightAndSizedimensionswidth);
                    dimensionsObjectpropCount++;
                }

                if (dimensionsObjectpropCount > 0)
                {
                    packageWeightAndSizeObject["dimensions"] = dimensionsObject;
                    packageWeightAndSizeObjectpropCount++;
                }

                if (bodypackageWeightAndSizepackageType != null)
                {
                    packageWeightAndSizeObject["packageType"] = SourceExpressionConverter.Convert(bodypackageWeightAndSizepackageType);
                    packageWeightAndSizeObjectpropCount++;
                }

                var weightObject = new JObject();
                var weightObjectpropCount = 0;
                if (bodypackageWeightAndSizeweightunit != null)
                {
                    weightObject["unit"] = SourceExpressionConverter.Convert(bodypackageWeightAndSizeweightunit);
                    weightObjectpropCount++;
                }

                if (bodypackageWeightAndSizeweightvalue != null)
                {
                    weightObject["value"] = SourceExpressionConverter.ConvertToken(bodypackageWeightAndSizeweightvalue);
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
                    productObject["brand"] = SourceExpressionConverter.ConvertToken(bodyproductbrand);
                    productObjectpropCount++;
                }

                if (bodyproductdescription != null)
                {
                    productObject["description"] = SourceExpressionConverter.ConvertToken(bodyproductdescription);
                    productObjectpropCount++;
                }

                if (bodyproductean != null)
                {
                    productObject["ean"] = SourceExpressionConverter.ConvertToken(bodyproductean);
                    productObjectpropCount++;
                }

                if (bodyproductepid != null)
                {
                    productObject["epid"] = SourceExpressionConverter.ConvertToken(bodyproductepid);
                    productObjectpropCount++;
                }

                if (bodyproductimageUrls != null)
                {
                    productObject["imageUrls"] = SourceExpressionConverter.ConvertToken(bodyproductimageUrls);
                    productObjectpropCount++;
                }

                if (bodyproductisbn != null)
                {
                    productObject["isbn"] = SourceExpressionConverter.ConvertToken(bodyproductisbn);
                    productObjectpropCount++;
                }

                if (bodyproductmpn != null)
                {
                    productObject["mpn"] = SourceExpressionConverter.ConvertToken(bodyproductmpn);
                    productObjectpropCount++;
                }

                if (bodyproductsubtitle != null)
                {
                    productObject["subtitle"] = SourceExpressionConverter.ConvertToken(bodyproductsubtitle);
                    productObjectpropCount++;
                }

                if (bodyproducttitle != null)
                {
                    productObject["title"] = SourceExpressionConverter.ConvertToken(bodyproducttitle);
                    productObjectpropCount++;
                }

                if (bodyproductupc != null)
                {
                    productObject["upc"] = SourceExpressionConverter.ConvertToken(bodyproductupc);
                    productObjectpropCount++;
                }

                if (bodyproductvideoIds != null)
                {
                    productObject["videoIds"] = SourceExpressionConverter.ConvertToken(bodyproductvideoIds);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateOrReplaceInventoryItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryItemsResponse> GetInventoryItems([WorkflowExpression] Func<string> Limit = null, [WorkflowExpression] Func<string> Offset = null)
        {
            SourceExpression.Validate(Limit, nameof(Limit), required: false);
            SourceExpression.Validate(Offset, nameof(Offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sell/inventory/v1/inventory_item";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Limit != null)
                    callPayload.Queries[" limit"] = SourceExpressionConverter.ConvertO(Limit);
                if (Offset != null)
                    callPayload.Queries[" offset"] = SourceExpressionConverter.ConvertO(Offset);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return callPayload;
            }

            return new ApiConnectionAction<GetInventoryItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryLocationResponse> GetInventoryLocation([WorkflowExpression] Func<string> merchantLocationKey)
        {
            SourceExpression.Validate(merchantLocationKey, nameof(merchantLocationKey), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/location/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(merchantLocationKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetInventoryLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<string> CreateInventoryLocation([WorkflowExpression] Func<string> merchantLocationKey, [WorkflowExpression] Func<string> bodylocationaddressaddressLine1 = null, [WorkflowExpression] Func<string> bodylocationaddressaddressLine2 = null, [WorkflowExpression] Func<string> bodylocationaddresscity = null, [WorkflowExpression] Func<string> bodylocationaddresscountry = null, [WorkflowExpression] Func<string> bodylocationaddresscounty = null, [WorkflowExpression] Func<string> bodylocationaddresspostalCode = null, [WorkflowExpression] Func<string> bodylocationaddressstateOrProvince = null, [WorkflowExpression] Func<string> bodylocationgeoCoordinateslatitude = null, [WorkflowExpression] Func<string> bodylocationgeoCoordinateslongitude = null, [WorkflowExpression] Func<string> bodylocationAdditionalInformation = null, [WorkflowExpression] Func<string> bodylocationInstructions = null, [WorkflowExpression] Func<bodylocationTypesInputItem[]> bodylocationTypes = null, [WorkflowExpression] Func<string> bodylocationWebUrl = null, [WorkflowExpression] Func<string> bodymerchantLocationStatus = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodyoperatingHoursInputItem[]> bodyoperatingHours = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<bodyspecialHoursInputItem[]> bodyspecialHours = null)
        {
            SourceExpression.Validate(merchantLocationKey, nameof(merchantLocationKey), required: true);
            SourceExpression.Validate(bodylocationaddressaddressLine1, nameof(bodylocationaddressaddressLine1), required: false);
            SourceExpression.Validate(bodylocationaddressaddressLine2, nameof(bodylocationaddressaddressLine2), required: false);
            SourceExpression.Validate(bodylocationaddresscity, nameof(bodylocationaddresscity), required: false);
            SourceExpression.Validate(bodylocationaddresscountry, nameof(bodylocationaddresscountry), required: false);
            SourceExpression.Validate(bodylocationaddresscounty, nameof(bodylocationaddresscounty), required: false);
            SourceExpression.Validate(bodylocationaddresspostalCode, nameof(bodylocationaddresspostalCode), required: false);
            SourceExpression.Validate(bodylocationaddressstateOrProvince, nameof(bodylocationaddressstateOrProvince), required: false);
            SourceExpression.Validate(bodylocationgeoCoordinateslatitude, nameof(bodylocationgeoCoordinateslatitude), required: false);
            SourceExpression.Validate(bodylocationgeoCoordinateslongitude, nameof(bodylocationgeoCoordinateslongitude), required: false);
            SourceExpression.Validate(bodylocationAdditionalInformation, nameof(bodylocationAdditionalInformation), required: false);
            SourceExpression.Validate(bodylocationInstructions, nameof(bodylocationInstructions), required: false);
            SourceExpression.Validate(bodylocationTypes, nameof(bodylocationTypes), required: false);
            SourceExpression.Validate(bodylocationWebUrl, nameof(bodylocationWebUrl), required: false);
            SourceExpression.Validate(bodymerchantLocationStatus, nameof(bodymerchantLocationStatus), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyoperatingHours, nameof(bodyoperatingHours), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodyspecialHours, nameof(bodyspecialHours), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/location/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(merchantLocationKey, 1));
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
                    addressObject["addressLine1"] = SourceExpressionConverter.ConvertToken(bodylocationaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (bodylocationaddressaddressLine2 != null)
                {
                    addressObject["addressLine2"] = SourceExpressionConverter.ConvertToken(bodylocationaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodylocationaddresscity);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodylocationaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodylocationaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresspostalCode != null)
                {
                    addressObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodylocationaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodylocationaddressstateOrProvince != null)
                {
                    addressObject["stateOrProvince"] = SourceExpressionConverter.ConvertToken(bodylocationaddressstateOrProvince);
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
                    geoCoordinatesObject["latitude"] = SourceExpressionConverter.ConvertToken(bodylocationgeoCoordinateslatitude);
                    geoCoordinatesObjectpropCount++;
                }

                if (bodylocationgeoCoordinateslongitude != null)
                {
                    geoCoordinatesObject["longitude"] = SourceExpressionConverter.ConvertToken(bodylocationgeoCoordinateslongitude);
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
                    body["locationAdditionalInformation"] = SourceExpressionConverter.ConvertToken(bodylocationAdditionalInformation);
                    bodypropCount++;
                }

                if (bodylocationInstructions != null)
                {
                    body["locationInstructions"] = SourceExpressionConverter.ConvertToken(bodylocationInstructions);
                    bodypropCount++;
                }

                if (bodylocationTypes != null)
                {
                    body["locationTypes"] = SourceExpressionConverter.ConvertToken(bodylocationTypes);
                    bodypropCount++;
                }

                if (bodylocationWebUrl != null)
                {
                    body["locationWebUrl"] = SourceExpressionConverter.ConvertToken(bodylocationWebUrl);
                    bodypropCount++;
                }

                if (bodymerchantLocationStatus != null)
                {
                    body["merchantLocationStatus"] = SourceExpressionConverter.ConvertToken(bodymerchantLocationStatus);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyoperatingHours != null)
                {
                    body["operatingHours"] = SourceExpressionConverter.ConvertToken(bodyoperatingHours);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodyspecialHours != null)
                {
                    body["specialHours"] = SourceExpressionConverter.ConvertToken(bodyspecialHours);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetInventoryLocationsResponse> GetInventoryLocations([WorkflowExpression] Func<string> Offset = null, [WorkflowExpression] Func<string> Limit = null)
        {
            SourceExpression.Validate(Offset, nameof(Offset), required: false);
            SourceExpression.Validate(Limit, nameof(Limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sell/inventory/v1/location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Offset != null)
                    callPayload.Queries[" offset"] = SourceExpressionConverter.ConvertO(Offset);
                if (Limit != null)
                    callPayload.Queries[" limit"] = SourceExpressionConverter.ConvertO(Limit);
                return callPayload;
            }

            return new ApiConnectionAction<GetInventoryLocationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetItemConditionPoliciesResponse> GetItemConditionPolicies([WorkflowExpression] Func<string> marketplaceId, [WorkflowExpression] Func<string> Filter = null)
        {
            SourceExpression.Validate(marketplaceId, nameof(marketplaceId), required: true);
            SourceExpression.Validate(Filter, nameof(Filter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/metadata/v1/marketplace/{0}/get_item_condition_policies", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(marketplaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (Filter != null)
                    callPayload.Queries[" filter"] = SourceExpressionConverter.ConvertO(Filter);
                return callPayload;
            }

            return new ApiConnectionAction<GetItemConditionPoliciesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetOffersResponse> GetOffers([WorkflowExpression] Func<string> sku, [WorkflowExpression] Func<string> MarketplaceId = null, [WorkflowExpression] Func<string> Format = null, [WorkflowExpression] Func<string> Limit = null, [WorkflowExpression] Func<string> Offset = null)
        {
            SourceExpression.Validate(sku, nameof(sku), required: true);
            SourceExpression.Validate(MarketplaceId, nameof(MarketplaceId), required: false);
            SourceExpression.Validate(Format, nameof(Format), required: false);
            SourceExpression.Validate(Limit, nameof(Limit), required: false);
            SourceExpression.Validate(Offset, nameof(Offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sell/inventory/v1/offer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sku"] = SourceExpressionConverter.ConvertO(sku);
                if (MarketplaceId != null)
                    callPayload.Queries[" marketplace_id"] = SourceExpressionConverter.ConvertO(MarketplaceId);
                if (Format != null)
                    callPayload.Queries[" format"] = SourceExpressionConverter.ConvertO(Format);
                if (Limit != null)
                    callPayload.Queries[" limit"] = SourceExpressionConverter.ConvertO(Limit);
                if (Offset != null)
                    callPayload.Queries[" offset"] = SourceExpressionConverter.ConvertO(Offset);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return callPayload;
            }

            return new ApiConnectionAction<GetOffersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<CreateOfferResponse> CreateOffer([WorkflowExpression] Func<int> bodyavailableQuantity = null, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<string> bodycharitycharityId = null, [WorkflowExpression] Func<string> bodycharitydonationPercentage = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproducerProductId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityshipmentPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductDocumentationId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeecurrency = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeevalue = null, [WorkflowExpression] Func<bodyformatInput> bodyformat = null, [WorkflowExpression] Func<bool> bodyhideBuyerDetails = null, [WorkflowExpression] Func<bool> bodyincludeCatalogProductDetails = null, [WorkflowExpression] Func<string> bodylistingDescription = null, [WorkflowExpression] Func<bodylistingDurationInput> bodylistingDuration = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricevalue = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricevalue = null, [WorkflowExpression] Func<bool> bodylistingPoliciesbestOfferTermsbestOfferEnabled = null, [WorkflowExpression] Func<bool> bodylistingPolicieseBayPlusIfEligible = null, [WorkflowExpression] Func<string> bodylistingPoliciesfulfillmentPolicyId = null, [WorkflowExpression] Func<string> bodylistingPoliciespaymentPolicyId = null, [WorkflowExpression] Func<string[]> bodylistingPoliciesproductCompliancePolicyIds = null, [WorkflowExpression] Func<string> bodylistingPoliciesreturnPolicyId = null, [WorkflowExpression] Func<bodylistingPoliciesshippingCostOverridesInputItem[]> bodylistingPoliciesshippingCostOverrides = null, [WorkflowExpression] Func<string> bodylistingPoliciestakeBackPolicyId = null, [WorkflowExpression] Func<string> bodylistingStartDate = null, [WorkflowExpression] Func<int> bodylotSize = null, [WorkflowExpression] Func<string> bodymarketplaceId = null, [WorkflowExpression] Func<string> bodymerchantLocationKey = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricevalue = null, [WorkflowExpression] Func<bodypricingSummaryoriginallySoldForRetailPriceOnInput> bodypricingSummaryoriginallySoldForRetailPriceOn = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummarypricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummarypricevalue = null, [WorkflowExpression] Func<bodypricingSummarypricingVisibilityInput> bodypricingSummarypricingVisibility = null, [WorkflowExpression] Func<int> bodyquantityLimitPerBuyer = null, [WorkflowExpression] Func<string> bodysecondaryCategoryId = null, [WorkflowExpression] Func<string> bodysku = null, [WorkflowExpression] Func<string[]> bodystoreCategoryNames = null, [WorkflowExpression] Func<bool> bodytaxapplyTax = null, [WorkflowExpression] Func<string> bodytaxthirdPartyTaxCategory = null, [WorkflowExpression] Func<double> bodytaxvatPercentage = null)
        {
            SourceExpression.Validate(bodyavailableQuantity, nameof(bodyavailableQuantity), required: false);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            SourceExpression.Validate(bodycharitycharityId, nameof(bodycharitycharityId), required: false);
            SourceExpression.Validate(bodycharitydonationPercentage, nameof(bodycharitydonationPercentage), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityproducerProductId, nameof(bodyextendedProducerResponsibilityproducerProductId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityproductPackageId, nameof(bodyextendedProducerResponsibilityproductPackageId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityshipmentPackageId, nameof(bodyextendedProducerResponsibilityshipmentPackageId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityproductDocumentationId, nameof(bodyextendedProducerResponsibilityproductDocumentationId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeecurrency, nameof(bodyextendedProducerResponsibilityecoParticipationFeecurrency), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeevalue, nameof(bodyextendedProducerResponsibilityecoParticipationFeevalue), required: false);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyhideBuyerDetails, nameof(bodyhideBuyerDetails), required: false);
            SourceExpression.Validate(bodyincludeCatalogProductDetails, nameof(bodyincludeCatalogProductDetails), required: false);
            SourceExpression.Validate(bodylistingDescription, nameof(bodylistingDescription), required: false);
            SourceExpression.Validate(bodylistingDuration, nameof(bodylistingDuration), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsbestOfferEnabled, nameof(bodylistingPoliciesbestOfferTermsbestOfferEnabled), required: false);
            SourceExpression.Validate(bodylistingPolicieseBayPlusIfEligible, nameof(bodylistingPolicieseBayPlusIfEligible), required: false);
            SourceExpression.Validate(bodylistingPoliciesfulfillmentPolicyId, nameof(bodylistingPoliciesfulfillmentPolicyId), required: false);
            SourceExpression.Validate(bodylistingPoliciespaymentPolicyId, nameof(bodylistingPoliciespaymentPolicyId), required: false);
            SourceExpression.Validate(bodylistingPoliciesproductCompliancePolicyIds, nameof(bodylistingPoliciesproductCompliancePolicyIds), required: false);
            SourceExpression.Validate(bodylistingPoliciesreturnPolicyId, nameof(bodylistingPoliciesreturnPolicyId), required: false);
            SourceExpression.Validate(bodylistingPoliciesshippingCostOverrides, nameof(bodylistingPoliciesshippingCostOverrides), required: false);
            SourceExpression.Validate(bodylistingPoliciestakeBackPolicyId, nameof(bodylistingPoliciestakeBackPolicyId), required: false);
            SourceExpression.Validate(bodylistingStartDate, nameof(bodylistingStartDate), required: false);
            SourceExpression.Validate(bodylotSize, nameof(bodylotSize), required: false);
            SourceExpression.Validate(bodymarketplaceId, nameof(bodymarketplaceId), required: false);
            SourceExpression.Validate(bodymerchantLocationKey, nameof(bodymerchantLocationKey), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionReservePricecurrency, nameof(bodypricingSummaryauctionReservePricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionReservePricevalue, nameof(bodypricingSummaryauctionReservePricevalue), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionStartPricecurrency, nameof(bodypricingSummaryauctionStartPricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionStartPricevalue, nameof(bodypricingSummaryauctionStartPricevalue), required: false);
            SourceExpression.Validate(bodypricingSummaryminimumAdvertisedPricecurrency, nameof(bodypricingSummaryminimumAdvertisedPricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryminimumAdvertisedPricevalue, nameof(bodypricingSummaryminimumAdvertisedPricevalue), required: false);
            SourceExpression.Validate(bodypricingSummaryoriginallySoldForRetailPriceOn, nameof(bodypricingSummaryoriginallySoldForRetailPriceOn), required: false);
            SourceExpression.Validate(bodypricingSummaryoriginalRetailPricecurrency, nameof(bodypricingSummaryoriginalRetailPricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryoriginalRetailPricevalue, nameof(bodypricingSummaryoriginalRetailPricevalue), required: false);
            SourceExpression.Validate(bodypricingSummarypricecurrency, nameof(bodypricingSummarypricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummarypricevalue, nameof(bodypricingSummarypricevalue), required: false);
            SourceExpression.Validate(bodypricingSummarypricingVisibility, nameof(bodypricingSummarypricingVisibility), required: false);
            SourceExpression.Validate(bodyquantityLimitPerBuyer, nameof(bodyquantityLimitPerBuyer), required: false);
            SourceExpression.Validate(bodysecondaryCategoryId, nameof(bodysecondaryCategoryId), required: false);
            SourceExpression.Validate(bodysku, nameof(bodysku), required: false);
            SourceExpression.Validate(bodystoreCategoryNames, nameof(bodystoreCategoryNames), required: false);
            SourceExpression.Validate(bodytaxapplyTax, nameof(bodytaxapplyTax), required: false);
            SourceExpression.Validate(bodytaxthirdPartyTaxCategory, nameof(bodytaxthirdPartyTaxCategory), required: false);
            SourceExpression.Validate(bodytaxvatPercentage, nameof(bodytaxvatPercentage), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    body["availableQuantity"] = SourceExpressionConverter.ConvertToken(bodyavailableQuantity);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                var charityObject = new JObject();
                var charityObjectpropCount = 0;
                if (bodycharitycharityId != null)
                {
                    charityObject["charityId"] = SourceExpressionConverter.ConvertToken(bodycharitycharityId);
                    charityObjectpropCount++;
                }

                if (bodycharitydonationPercentage != null)
                {
                    charityObject["donationPercentage"] = SourceExpressionConverter.ConvertToken(bodycharitydonationPercentage);
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
                    extendedProducerResponsibilityObject["producerProductId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityproducerProductId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductPackageId != null)
                {
                    extendedProducerResponsibilityObject["productPackageId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityproductPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityshipmentPackageId != null)
                {
                    extendedProducerResponsibilityObject["shipmentPackageId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityshipmentPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductDocumentationId != null)
                {
                    extendedProducerResponsibilityObject["productDocumentationId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityproductDocumentationId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                var ecoParticipationFeeObject = new JObject();
                var ecoParticipationFeeObjectpropCount = 0;
                if (bodyextendedProducerResponsibilityecoParticipationFeecurrency != null)
                {
                    ecoParticipationFeeObject["currency"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityecoParticipationFeecurrency);
                    ecoParticipationFeeObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityecoParticipationFeevalue != null)
                {
                    ecoParticipationFeeObject["value"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityecoParticipationFeevalue);
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
                    body["format"] = SourceExpressionConverter.Convert(bodyformat);
                    bodypropCount++;
                }

                if (bodyhideBuyerDetails != null)
                {
                    body["hideBuyerDetails"] = SourceExpressionConverter.ConvertToken(bodyhideBuyerDetails);
                    bodypropCount++;
                }

                if (bodyincludeCatalogProductDetails != null)
                {
                    body["includeCatalogProductDetails"] = SourceExpressionConverter.ConvertToken(bodyincludeCatalogProductDetails);
                    bodypropCount++;
                }

                if (bodylistingDescription != null)
                {
                    body["listingDescription"] = SourceExpressionConverter.ConvertToken(bodylistingDescription);
                    bodypropCount++;
                }

                if (bodylistingDuration != null)
                {
                    body["listingDuration"] = SourceExpressionConverter.Convert(bodylistingDuration);
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
                    autoAcceptPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency);
                    autoAcceptPriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoAcceptPricevalue != null)
                {
                    autoAcceptPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue);
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
                    autoDeclinePriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency);
                    autoDeclinePriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoDeclinePricevalue != null)
                {
                    autoDeclinePriceObject["value"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue);
                    autoDeclinePriceObjectpropCount++;
                }

                if (autoDeclinePriceObjectpropCount > 0)
                {
                    bestOfferTermsObject["autoDeclinePrice"] = autoDeclinePriceObject;
                    bestOfferTermsObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsbestOfferEnabled != null)
                {
                    bestOfferTermsObject["bestOfferEnabled"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsbestOfferEnabled);
                    bestOfferTermsObjectpropCount++;
                }

                if (bestOfferTermsObjectpropCount > 0)
                {
                    listingPoliciesObject["bestOfferTerms"] = bestOfferTermsObject;
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPolicieseBayPlusIfEligible != null)
                {
                    listingPoliciesObject["eBayPlusIfEligible"] = SourceExpressionConverter.ConvertToken(bodylistingPolicieseBayPlusIfEligible);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesfulfillmentPolicyId != null)
                {
                    listingPoliciesObject["fulfillmentPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesfulfillmentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciespaymentPolicyId != null)
                {
                    listingPoliciesObject["paymentPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciespaymentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesproductCompliancePolicyIds != null)
                {
                    listingPoliciesObject["productCompliancePolicyIds"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesproductCompliancePolicyIds);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesreturnPolicyId != null)
                {
                    listingPoliciesObject["returnPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesreturnPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesshippingCostOverrides != null)
                {
                    listingPoliciesObject["shippingCostOverrides"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesshippingCostOverrides);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciestakeBackPolicyId != null)
                {
                    listingPoliciesObject["takeBackPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciestakeBackPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (listingPoliciesObjectpropCount > 0)
                {
                    body["listingPolicies"] = listingPoliciesObject;
                    bodypropCount++;
                }

                if (bodylistingStartDate != null)
                {
                    body["listingStartDate"] = SourceExpressionConverter.ConvertToken(bodylistingStartDate);
                    bodypropCount++;
                }

                if (bodylotSize != null)
                {
                    body["lotSize"] = SourceExpressionConverter.ConvertToken(bodylotSize);
                    bodypropCount++;
                }

                if (bodymarketplaceId != null)
                {
                    body["marketplaceId"] = SourceExpressionConverter.ConvertToken(bodymarketplaceId);
                    bodypropCount++;
                }

                if (bodymerchantLocationKey != null)
                {
                    body["merchantLocationKey"] = SourceExpressionConverter.ConvertToken(bodymerchantLocationKey);
                    bodypropCount++;
                }

                var pricingSummaryObject = new JObject();
                var pricingSummaryObjectpropCount = 0;
                var auctionReservePriceObject = new JObject();
                var auctionReservePriceObjectpropCount = 0;
                if (bodypricingSummaryauctionReservePricecurrency != null)
                {
                    auctionReservePriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionReservePricecurrency);
                    auctionReservePriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionReservePricevalue != null)
                {
                    auctionReservePriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionReservePricevalue);
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
                    auctionStartPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionStartPricecurrency);
                    auctionStartPriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionStartPricevalue != null)
                {
                    auctionStartPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionStartPricevalue);
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
                    minimumAdvertisedPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryminimumAdvertisedPricecurrency);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (bodypricingSummaryminimumAdvertisedPricevalue != null)
                {
                    minimumAdvertisedPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryminimumAdvertisedPricevalue);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (minimumAdvertisedPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["minimumAdvertisedPrice"] = minimumAdvertisedPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummaryoriginallySoldForRetailPriceOn != null)
                {
                    pricingSummaryObject["originallySoldForRetailPriceOn"] = SourceExpressionConverter.Convert(bodypricingSummaryoriginallySoldForRetailPriceOn);
                    pricingSummaryObjectpropCount++;
                }

                var originalRetailPriceObject = new JObject();
                var originalRetailPriceObjectpropCount = 0;
                if (bodypricingSummaryoriginalRetailPricecurrency != null)
                {
                    originalRetailPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryoriginalRetailPricecurrency);
                    originalRetailPriceObjectpropCount++;
                }

                if (bodypricingSummaryoriginalRetailPricevalue != null)
                {
                    originalRetailPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryoriginalRetailPricevalue);
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
                    priceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummarypricecurrency);
                    priceObjectpropCount++;
                }

                if (bodypricingSummarypricevalue != null)
                {
                    priceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummarypricevalue);
                    priceObjectpropCount++;
                }

                if (priceObjectpropCount > 0)
                {
                    pricingSummaryObject["price"] = priceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummarypricingVisibility != null)
                {
                    pricingSummaryObject["pricingVisibility"] = SourceExpressionConverter.Convert(bodypricingSummarypricingVisibility);
                    pricingSummaryObjectpropCount++;
                }

                if (pricingSummaryObjectpropCount > 0)
                {
                    body["pricingSummary"] = pricingSummaryObject;
                    bodypropCount++;
                }

                if (bodyquantityLimitPerBuyer != null)
                {
                    body["quantityLimitPerBuyer"] = SourceExpressionConverter.ConvertToken(bodyquantityLimitPerBuyer);
                    bodypropCount++;
                }

                if (bodysecondaryCategoryId != null)
                {
                    body["secondaryCategoryId"] = SourceExpressionConverter.ConvertToken(bodysecondaryCategoryId);
                    bodypropCount++;
                }

                if (bodysku != null)
                {
                    body["sku"] = SourceExpressionConverter.ConvertToken(bodysku);
                    bodypropCount++;
                }

                if (bodystoreCategoryNames != null)
                {
                    body["storeCategoryNames"] = SourceExpressionConverter.ConvertToken(bodystoreCategoryNames);
                    bodypropCount++;
                }

                var taxObject = new JObject();
                var taxObjectpropCount = 0;
                if (bodytaxapplyTax != null)
                {
                    taxObject["applyTax"] = SourceExpressionConverter.ConvertToken(bodytaxapplyTax);
                    taxObjectpropCount++;
                }

                if (bodytaxthirdPartyTaxCategory != null)
                {
                    taxObject["thirdPartyTaxCategory"] = SourceExpressionConverter.ConvertToken(bodytaxthirdPartyTaxCategory);
                    taxObjectpropCount++;
                }

                if (bodytaxvatPercentage != null)
                {
                    taxObject["vatPercentage"] = SourceExpressionConverter.ConvertToken(bodytaxvatPercentage);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateOfferResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<GetOfferResponse> GetOffer([WorkflowExpression] Func<string> offerId)
        {
            SourceExpression.Validate(offerId, nameof(offerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return callPayload;
            }

            return new ApiConnectionAction<GetOfferResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<string> DeleteOffer([WorkflowExpression] Func<string> offerId)
        {
            SourceExpression.Validate(offerId, nameof(offerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<UpdateOfferResponse> UpdateOffer([WorkflowExpression] Func<string> offerId, [WorkflowExpression] Func<int> bodyavailableQuantity = null, [WorkflowExpression] Func<string> bodycategoryId = null, [WorkflowExpression] Func<string> bodycharitycharityId = null, [WorkflowExpression] Func<string> bodycharitydonationPercentage = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproducerProductId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityshipmentPackageId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityproductDocumentationId = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeecurrency = null, [WorkflowExpression] Func<string> bodyextendedProducerResponsibilityecoParticipationFeevalue = null, [WorkflowExpression] Func<bool> bodyhideBuyerDetails = null, [WorkflowExpression] Func<bool> bodyincludeCatalogProductDetails = null, [WorkflowExpression] Func<string> bodylistingDescription = null, [WorkflowExpression] Func<bodylistingDurationInput> bodylistingDuration = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoAcceptPricevalue = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency = null, [WorkflowExpression] Func<string> bodylistingPoliciesbestOfferTermsautoDeclinePricevalue = null, [WorkflowExpression] Func<bool> bodylistingPoliciesbestOfferTermsbestOfferEnabled = null, [WorkflowExpression] Func<bool> bodylistingPolicieseBayPlusIfEligible = null, [WorkflowExpression] Func<string> bodylistingPoliciesfulfillmentPolicyId = null, [WorkflowExpression] Func<string> bodylistingPoliciespaymentPolicyId = null, [WorkflowExpression] Func<string[]> bodylistingPoliciesproductCompliancePolicyIds = null, [WorkflowExpression] Func<string> bodylistingPoliciesreturnPolicyId = null, [WorkflowExpression] Func<bodylistingPoliciesshippingCostOverridesInputItem2[]> bodylistingPoliciesshippingCostOverrides = null, [WorkflowExpression] Func<string> bodylistingPoliciestakeBackPolicyId = null, [WorkflowExpression] Func<string> bodylistingStartDate = null, [WorkflowExpression] Func<int> bodylotSize = null, [WorkflowExpression] Func<string> bodymerchantLocationKey = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionReservePricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryauctionStartPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryminimumAdvertisedPricevalue = null, [WorkflowExpression] Func<bodypricingSummaryoriginallySoldForRetailPriceOnInput> bodypricingSummaryoriginallySoldForRetailPriceOn = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummaryoriginalRetailPricevalue = null, [WorkflowExpression] Func<string> bodypricingSummarypricecurrency = null, [WorkflowExpression] Func<string> bodypricingSummarypricevalue = null, [WorkflowExpression] Func<bodypricingSummarypricingVisibilityInput> bodypricingSummarypricingVisibility = null, [WorkflowExpression] Func<int> bodyquantityLimitPerBuyer = null, [WorkflowExpression] Func<string> bodysecondaryCategoryId = null, [WorkflowExpression] Func<string[]> bodystoreCategoryNames = null, [WorkflowExpression] Func<bool> bodytaxapplyTax = null, [WorkflowExpression] Func<string> bodytaxthirdPartyTaxCategory = null, [WorkflowExpression] Func<double> bodytaxvatPercentage = null)
        {
            SourceExpression.Validate(offerId, nameof(offerId), required: true);
            SourceExpression.Validate(bodyavailableQuantity, nameof(bodyavailableQuantity), required: false);
            SourceExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            SourceExpression.Validate(bodycharitycharityId, nameof(bodycharitycharityId), required: false);
            SourceExpression.Validate(bodycharitydonationPercentage, nameof(bodycharitydonationPercentage), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityproducerProductId, nameof(bodyextendedProducerResponsibilityproducerProductId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityproductPackageId, nameof(bodyextendedProducerResponsibilityproductPackageId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityshipmentPackageId, nameof(bodyextendedProducerResponsibilityshipmentPackageId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityproductDocumentationId, nameof(bodyextendedProducerResponsibilityproductDocumentationId), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeecurrency, nameof(bodyextendedProducerResponsibilityecoParticipationFeecurrency), required: false);
            SourceExpression.Validate(bodyextendedProducerResponsibilityecoParticipationFeevalue, nameof(bodyextendedProducerResponsibilityecoParticipationFeevalue), required: false);
            SourceExpression.Validate(bodyhideBuyerDetails, nameof(bodyhideBuyerDetails), required: false);
            SourceExpression.Validate(bodyincludeCatalogProductDetails, nameof(bodyincludeCatalogProductDetails), required: false);
            SourceExpression.Validate(bodylistingDescription, nameof(bodylistingDescription), required: false);
            SourceExpression.Validate(bodylistingDuration, nameof(bodylistingDuration), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue, nameof(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue, nameof(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue), required: false);
            SourceExpression.Validate(bodylistingPoliciesbestOfferTermsbestOfferEnabled, nameof(bodylistingPoliciesbestOfferTermsbestOfferEnabled), required: false);
            SourceExpression.Validate(bodylistingPolicieseBayPlusIfEligible, nameof(bodylistingPolicieseBayPlusIfEligible), required: false);
            SourceExpression.Validate(bodylistingPoliciesfulfillmentPolicyId, nameof(bodylistingPoliciesfulfillmentPolicyId), required: false);
            SourceExpression.Validate(bodylistingPoliciespaymentPolicyId, nameof(bodylistingPoliciespaymentPolicyId), required: false);
            SourceExpression.Validate(bodylistingPoliciesproductCompliancePolicyIds, nameof(bodylistingPoliciesproductCompliancePolicyIds), required: false);
            SourceExpression.Validate(bodylistingPoliciesreturnPolicyId, nameof(bodylistingPoliciesreturnPolicyId), required: false);
            SourceExpression.Validate(bodylistingPoliciesshippingCostOverrides, nameof(bodylistingPoliciesshippingCostOverrides), required: false);
            SourceExpression.Validate(bodylistingPoliciestakeBackPolicyId, nameof(bodylistingPoliciestakeBackPolicyId), required: false);
            SourceExpression.Validate(bodylistingStartDate, nameof(bodylistingStartDate), required: false);
            SourceExpression.Validate(bodylotSize, nameof(bodylotSize), required: false);
            SourceExpression.Validate(bodymerchantLocationKey, nameof(bodymerchantLocationKey), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionReservePricecurrency, nameof(bodypricingSummaryauctionReservePricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionReservePricevalue, nameof(bodypricingSummaryauctionReservePricevalue), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionStartPricecurrency, nameof(bodypricingSummaryauctionStartPricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryauctionStartPricevalue, nameof(bodypricingSummaryauctionStartPricevalue), required: false);
            SourceExpression.Validate(bodypricingSummaryminimumAdvertisedPricecurrency, nameof(bodypricingSummaryminimumAdvertisedPricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryminimumAdvertisedPricevalue, nameof(bodypricingSummaryminimumAdvertisedPricevalue), required: false);
            SourceExpression.Validate(bodypricingSummaryoriginallySoldForRetailPriceOn, nameof(bodypricingSummaryoriginallySoldForRetailPriceOn), required: false);
            SourceExpression.Validate(bodypricingSummaryoriginalRetailPricecurrency, nameof(bodypricingSummaryoriginalRetailPricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummaryoriginalRetailPricevalue, nameof(bodypricingSummaryoriginalRetailPricevalue), required: false);
            SourceExpression.Validate(bodypricingSummarypricecurrency, nameof(bodypricingSummarypricecurrency), required: false);
            SourceExpression.Validate(bodypricingSummarypricevalue, nameof(bodypricingSummarypricevalue), required: false);
            SourceExpression.Validate(bodypricingSummarypricingVisibility, nameof(bodypricingSummarypricingVisibility), required: false);
            SourceExpression.Validate(bodyquantityLimitPerBuyer, nameof(bodyquantityLimitPerBuyer), required: false);
            SourceExpression.Validate(bodysecondaryCategoryId, nameof(bodysecondaryCategoryId), required: false);
            SourceExpression.Validate(bodystoreCategoryNames, nameof(bodystoreCategoryNames), required: false);
            SourceExpression.Validate(bodytaxapplyTax, nameof(bodytaxapplyTax), required: false);
            SourceExpression.Validate(bodytaxthirdPartyTaxCategory, nameof(bodytaxthirdPartyTaxCategory), required: false);
            SourceExpression.Validate(bodytaxvatPercentage, nameof(bodytaxvatPercentage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Language"] = Convert.ToString("en-US");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyavailableQuantity != null)
                {
                    body["availableQuantity"] = SourceExpressionConverter.ConvertToken(bodyavailableQuantity);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                var charityObject = new JObject();
                var charityObjectpropCount = 0;
                if (bodycharitycharityId != null)
                {
                    charityObject["charityId"] = SourceExpressionConverter.ConvertToken(bodycharitycharityId);
                    charityObjectpropCount++;
                }

                if (bodycharitydonationPercentage != null)
                {
                    charityObject["donationPercentage"] = SourceExpressionConverter.ConvertToken(bodycharitydonationPercentage);
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
                    extendedProducerResponsibilityObject["producerProductId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityproducerProductId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductPackageId != null)
                {
                    extendedProducerResponsibilityObject["productPackageId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityproductPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityshipmentPackageId != null)
                {
                    extendedProducerResponsibilityObject["shipmentPackageId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityshipmentPackageId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityproductDocumentationId != null)
                {
                    extendedProducerResponsibilityObject["productDocumentationId"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityproductDocumentationId);
                    extendedProducerResponsibilityObjectpropCount++;
                }

                var ecoParticipationFeeObject = new JObject();
                var ecoParticipationFeeObjectpropCount = 0;
                if (bodyextendedProducerResponsibilityecoParticipationFeecurrency != null)
                {
                    ecoParticipationFeeObject["currency"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityecoParticipationFeecurrency);
                    ecoParticipationFeeObjectpropCount++;
                }

                if (bodyextendedProducerResponsibilityecoParticipationFeevalue != null)
                {
                    ecoParticipationFeeObject["value"] = SourceExpressionConverter.ConvertToken(bodyextendedProducerResponsibilityecoParticipationFeevalue);
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
                    body["hideBuyerDetails"] = SourceExpressionConverter.ConvertToken(bodyhideBuyerDetails);
                    bodypropCount++;
                }

                if (bodyincludeCatalogProductDetails != null)
                {
                    body["includeCatalogProductDetails"] = SourceExpressionConverter.ConvertToken(bodyincludeCatalogProductDetails);
                    bodypropCount++;
                }

                if (bodylistingDescription != null)
                {
                    body["listingDescription"] = SourceExpressionConverter.ConvertToken(bodylistingDescription);
                    bodypropCount++;
                }

                if (bodylistingDuration != null)
                {
                    body["listingDuration"] = SourceExpressionConverter.Convert(bodylistingDuration);
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
                    autoAcceptPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoAcceptPricecurrency);
                    autoAcceptPriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoAcceptPricevalue != null)
                {
                    autoAcceptPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoAcceptPricevalue);
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
                    autoDeclinePriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoDeclinePricecurrency);
                    autoDeclinePriceObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsautoDeclinePricevalue != null)
                {
                    autoDeclinePriceObject["value"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsautoDeclinePricevalue);
                    autoDeclinePriceObjectpropCount++;
                }

                if (autoDeclinePriceObjectpropCount > 0)
                {
                    bestOfferTermsObject["autoDeclinePrice"] = autoDeclinePriceObject;
                    bestOfferTermsObjectpropCount++;
                }

                if (bodylistingPoliciesbestOfferTermsbestOfferEnabled != null)
                {
                    bestOfferTermsObject["bestOfferEnabled"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesbestOfferTermsbestOfferEnabled);
                    bestOfferTermsObjectpropCount++;
                }

                if (bestOfferTermsObjectpropCount > 0)
                {
                    listingPoliciesObject["bestOfferTerms"] = bestOfferTermsObject;
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPolicieseBayPlusIfEligible != null)
                {
                    listingPoliciesObject["eBayPlusIfEligible"] = SourceExpressionConverter.ConvertToken(bodylistingPolicieseBayPlusIfEligible);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesfulfillmentPolicyId != null)
                {
                    listingPoliciesObject["fulfillmentPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesfulfillmentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciespaymentPolicyId != null)
                {
                    listingPoliciesObject["paymentPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciespaymentPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesproductCompliancePolicyIds != null)
                {
                    listingPoliciesObject["productCompliancePolicyIds"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesproductCompliancePolicyIds);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesreturnPolicyId != null)
                {
                    listingPoliciesObject["returnPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesreturnPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciesshippingCostOverrides != null)
                {
                    listingPoliciesObject["shippingCostOverrides"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciesshippingCostOverrides);
                    listingPoliciesObjectpropCount++;
                }

                if (bodylistingPoliciestakeBackPolicyId != null)
                {
                    listingPoliciesObject["takeBackPolicyId"] = SourceExpressionConverter.ConvertToken(bodylistingPoliciestakeBackPolicyId);
                    listingPoliciesObjectpropCount++;
                }

                if (listingPoliciesObjectpropCount > 0)
                {
                    body["listingPolicies"] = listingPoliciesObject;
                    bodypropCount++;
                }

                if (bodylistingStartDate != null)
                {
                    body["listingStartDate"] = SourceExpressionConverter.ConvertToken(bodylistingStartDate);
                    bodypropCount++;
                }

                if (bodylotSize != null)
                {
                    body["lotSize"] = SourceExpressionConverter.ConvertToken(bodylotSize);
                    bodypropCount++;
                }

                if (bodymerchantLocationKey != null)
                {
                    body["merchantLocationKey"] = SourceExpressionConverter.ConvertToken(bodymerchantLocationKey);
                    bodypropCount++;
                }

                var pricingSummaryObject = new JObject();
                var pricingSummaryObjectpropCount = 0;
                var auctionReservePriceObject = new JObject();
                var auctionReservePriceObjectpropCount = 0;
                if (bodypricingSummaryauctionReservePricecurrency != null)
                {
                    auctionReservePriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionReservePricecurrency);
                    auctionReservePriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionReservePricevalue != null)
                {
                    auctionReservePriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionReservePricevalue);
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
                    auctionStartPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionStartPricecurrency);
                    auctionStartPriceObjectpropCount++;
                }

                if (bodypricingSummaryauctionStartPricevalue != null)
                {
                    auctionStartPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryauctionStartPricevalue);
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
                    minimumAdvertisedPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryminimumAdvertisedPricecurrency);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (bodypricingSummaryminimumAdvertisedPricevalue != null)
                {
                    minimumAdvertisedPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryminimumAdvertisedPricevalue);
                    minimumAdvertisedPriceObjectpropCount++;
                }

                if (minimumAdvertisedPriceObjectpropCount > 0)
                {
                    pricingSummaryObject["minimumAdvertisedPrice"] = minimumAdvertisedPriceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummaryoriginallySoldForRetailPriceOn != null)
                {
                    pricingSummaryObject["originallySoldForRetailPriceOn"] = SourceExpressionConverter.Convert(bodypricingSummaryoriginallySoldForRetailPriceOn);
                    pricingSummaryObjectpropCount++;
                }

                var originalRetailPriceObject = new JObject();
                var originalRetailPriceObjectpropCount = 0;
                if (bodypricingSummaryoriginalRetailPricecurrency != null)
                {
                    originalRetailPriceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryoriginalRetailPricecurrency);
                    originalRetailPriceObjectpropCount++;
                }

                if (bodypricingSummaryoriginalRetailPricevalue != null)
                {
                    originalRetailPriceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummaryoriginalRetailPricevalue);
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
                    priceObject["currency"] = SourceExpressionConverter.ConvertToken(bodypricingSummarypricecurrency);
                    priceObjectpropCount++;
                }

                if (bodypricingSummarypricevalue != null)
                {
                    priceObject["value"] = SourceExpressionConverter.ConvertToken(bodypricingSummarypricevalue);
                    priceObjectpropCount++;
                }

                if (priceObjectpropCount > 0)
                {
                    pricingSummaryObject["price"] = priceObject;
                    pricingSummaryObjectpropCount++;
                }

                if (bodypricingSummarypricingVisibility != null)
                {
                    pricingSummaryObject["pricingVisibility"] = SourceExpressionConverter.Convert(bodypricingSummarypricingVisibility);
                    pricingSummaryObjectpropCount++;
                }

                if (pricingSummaryObjectpropCount > 0)
                {
                    body["pricingSummary"] = pricingSummaryObject;
                    bodypropCount++;
                }

                if (bodyquantityLimitPerBuyer != null)
                {
                    body["quantityLimitPerBuyer"] = SourceExpressionConverter.ConvertToken(bodyquantityLimitPerBuyer);
                    bodypropCount++;
                }

                if (bodysecondaryCategoryId != null)
                {
                    body["secondaryCategoryId"] = SourceExpressionConverter.ConvertToken(bodysecondaryCategoryId);
                    bodypropCount++;
                }

                if (bodystoreCategoryNames != null)
                {
                    body["storeCategoryNames"] = SourceExpressionConverter.ConvertToken(bodystoreCategoryNames);
                    bodypropCount++;
                }

                var taxObject = new JObject();
                var taxObjectpropCount = 0;
                if (bodytaxapplyTax != null)
                {
                    taxObject["applyTax"] = SourceExpressionConverter.ConvertToken(bodytaxapplyTax);
                    taxObjectpropCount++;
                }

                if (bodytaxthirdPartyTaxCategory != null)
                {
                    taxObject["thirdPartyTaxCategory"] = SourceExpressionConverter.ConvertToken(bodytaxthirdPartyTaxCategory);
                    taxObjectpropCount++;
                }

                if (bodytaxvatPercentage != null)
                {
                    taxObject["vatPercentage"] = SourceExpressionConverter.ConvertToken(bodytaxvatPercentage);
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
                return callPayload;
            }

            return new ApiConnectionAction<UpdateOfferResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<WithdrawOfferResponse> WithdrawOffer([WorkflowExpression] Func<string> offerId)
        {
            SourceExpression.Validate(offerId, nameof(offerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}/withdraw", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return callPayload;
            }

            return new ApiConnectionAction<WithdrawOfferResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ebayip")]
        public IBodyWorkflowAction<PublishOfferResponse> PublishOffer([WorkflowExpression] Func<string> offerId)
        {
            SourceExpression.Validate(offerId, nameof(offerId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sell/inventory/v1/offer/{0}/publish/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept-Language"] = Convert.ToString("en-US");
                return callPayload;
            }

            return new ApiConnectionAction<PublishOfferResponse>(BuildSourceInput);
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