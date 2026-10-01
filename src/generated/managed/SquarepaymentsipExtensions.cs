//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Squarepaymentsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SquarepaymentsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<ApplePayRegisterResponse> ApplePayRegister([WorkflowExpression] Func<string> bodydomainName)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/apple-pay/domains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain_name"] = SourceExpressionConverter.ConvertToken(bodydomainName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApplePayRegisterResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardListResponse> CardList([WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<bool> includeDisabled = null, [WorkflowExpression] Func<string> referenceId = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (customerId != null)
                    callPayload.Queries["customer_id"] = SourceExpressionConverter.ConvertO(customerId);
                if (includeDisabled != null)
                    callPayload.Queries["include_disabled"] = SourceExpressionConverter.ConvertO(includeDisabled);
                if (referenceId != null)
                    callPayload.Queries["reference_id"] = SourceExpressionConverter.ConvertO(referenceId);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                return callPayload;
            }

            return new ApiConnectionAction<CardListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardCreateResponse> CardCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<string> bodycardbillingAddressaddressLine1 = null, [WorkflowExpression] Func<string> bodycardbillingAddressaddressLine2 = null, [WorkflowExpression] Func<string> bodycardbillingAddresslocality = null, [WorkflowExpression] Func<string> bodycardbillingAddressadministrativeDistrictLevel1 = null, [WorkflowExpression] Func<string> bodycardbillingAddresspostalCode = null, [WorkflowExpression] Func<string> bodycardbillingAddresscountry = null, [WorkflowExpression] Func<string> bodycardcardholderName = null, [WorkflowExpression] Func<string> bodycardcustomerId = null, [WorkflowExpression] Func<string> bodycardreferenceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["source_id"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                var cardObject = new JObject();
                var cardObjectpropCount = 0;
                var billingAddressObject = new JObject();
                var billingAddressObjectpropCount = 0;
                if (bodycardbillingAddressaddressLine1 != null)
                {
                    billingAddressObject["address_line_1"] = SourceExpressionConverter.ConvertToken(bodycardbillingAddressaddressLine1);
                    billingAddressObjectpropCount++;
                }

                if (bodycardbillingAddressaddressLine2 != null)
                {
                    billingAddressObject["address_line_2"] = SourceExpressionConverter.ConvertToken(bodycardbillingAddressaddressLine2);
                    billingAddressObjectpropCount++;
                }

                if (bodycardbillingAddresslocality != null)
                {
                    billingAddressObject["locality"] = SourceExpressionConverter.ConvertToken(bodycardbillingAddresslocality);
                    billingAddressObjectpropCount++;
                }

                if (bodycardbillingAddressadministrativeDistrictLevel1 != null)
                {
                    billingAddressObject["administrative_district_level_1"] = SourceExpressionConverter.ConvertToken(bodycardbillingAddressadministrativeDistrictLevel1);
                    billingAddressObjectpropCount++;
                }

                if (bodycardbillingAddresspostalCode != null)
                {
                    billingAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodycardbillingAddresspostalCode);
                    billingAddressObjectpropCount++;
                }

                if (bodycardbillingAddresscountry != null)
                {
                    billingAddressObject["country"] = SourceExpressionConverter.ConvertToken(bodycardbillingAddresscountry);
                    billingAddressObjectpropCount++;
                }

                if (billingAddressObjectpropCount > 0)
                {
                    cardObject["billing_address"] = billingAddressObject;
                    cardObjectpropCount++;
                }

                if (bodycardcardholderName != null)
                {
                    cardObject["cardholder_name"] = SourceExpressionConverter.ConvertToken(bodycardcardholderName);
                    cardObjectpropCount++;
                }

                if (bodycardcustomerId != null)
                {
                    cardObject["customer_id"] = SourceExpressionConverter.ConvertToken(bodycardcustomerId);
                    cardObjectpropCount++;
                }

                if (bodycardreferenceId != null)
                {
                    cardObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodycardreferenceId);
                    cardObjectpropCount++;
                }

                if (cardObjectpropCount > 0)
                {
                    body["card"] = cardObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CardCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardRetrieveResponse> CardRetrieve([WorkflowExpression] Func<string> cardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CardRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardDisableResponse> CardDisable([WorkflowExpression] Func<string> cardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/{0}/disable", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CardDisableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogBatchDeleteResponse> CatalogBatchDelete([WorkflowExpression] Func<string[]> bodyobjectIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/batch-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIds != null)
                {
                    body["object_ids"] = SourceExpressionConverter.ConvertToken(bodyobjectIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogBatchDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogBatchRetrieveResponse> CatalogBatchRetrieve([WorkflowExpression] Func<string[]> bodyobjectIds = null, [WorkflowExpression] Func<int> bodycatalogVersion = null, [WorkflowExpression] Func<bool> bodyincludeRelatedObjects = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectIds != null)
                {
                    body["object_ids"] = SourceExpressionConverter.ConvertToken(bodyobjectIds);
                    bodypropCount++;
                }

                if (bodycatalogVersion != null)
                {
                    body["catalog_version"] = SourceExpressionConverter.ConvertToken(bodycatalogVersion);
                    bodypropCount++;
                }

                if (bodyincludeRelatedObjects != null)
                {
                    body["include_related_objects"] = SourceExpressionConverter.ConvertToken(bodyincludeRelatedObjects);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogBatchRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogBatchUpsertResponse> CatalogBatchUpsert([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<bodybatchesInputItem[]> bodybatches = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/batch-upsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodybatches != null)
                {
                    body["batches"] = SourceExpressionConverter.ConvertToken(bodybatches);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogBatchUpsertResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogInfoResponse> CatalogInfo()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CatalogInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogListResponse> CatalogList([WorkflowExpression] Func<int> cursor = null, [WorkflowExpression] Func<string> types = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (types != null)
                    callPayload.Queries["types"] = SourceExpressionConverter.ConvertO(types);
                return callPayload;
            }

            return new ApiConnectionAction<CatalogListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogUpsertResponse> CatalogUpsert([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyObjectid = null, [WorkflowExpression] Func<string> bodyObjecttype = null, [WorkflowExpression] Func<string> bodyObjectitemDataabbreviation = null, [WorkflowExpression] Func<string> bodyObjectitemDatatitle = null, [WorkflowExpression] Func<string> bodyObjectitemDataname = null, [WorkflowExpression] Func<bodyObjectitemDatavariationsInputItem[]> bodyObjectitemDatavariations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/object";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var @objectObject = new JObject();
                var @objectObjectpropCount = 0;
                if (bodyObjectid != null)
                {
                    @objectObject["id"] = SourceExpressionConverter.ConvertToken(bodyObjectid);
                    @objectObjectpropCount++;
                }

                if (bodyObjecttype != null)
                {
                    @objectObject["type"] = SourceExpressionConverter.ConvertToken(bodyObjecttype);
                    @objectObjectpropCount++;
                }

                var itemDataObject = new JObject();
                var itemDataObjectpropCount = 0;
                if (bodyObjectitemDataabbreviation != null)
                {
                    itemDataObject["abbreviation"] = SourceExpressionConverter.ConvertToken(bodyObjectitemDataabbreviation);
                    itemDataObjectpropCount++;
                }

                if (bodyObjectitemDatatitle != null)
                {
                    itemDataObject["title"] = SourceExpressionConverter.ConvertToken(bodyObjectitemDatatitle);
                    itemDataObjectpropCount++;
                }

                if (bodyObjectitemDataname != null)
                {
                    itemDataObject["name"] = SourceExpressionConverter.ConvertToken(bodyObjectitemDataname);
                    itemDataObjectpropCount++;
                }

                if (bodyObjectitemDatavariations != null)
                {
                    itemDataObject["variations"] = SourceExpressionConverter.ConvertToken(bodyObjectitemDatavariations);
                    itemDataObjectpropCount++;
                }

                if (itemDataObjectpropCount > 0)
                {
                    @objectObject["item_data"] = itemDataObject;
                    @objectObjectpropCount++;
                }

                if (@objectObjectpropCount > 0)
                {
                    body["object"] = @objectObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogUpsertResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogRetrieveResponse> CatalogRetrieve([WorkflowExpression] Func<string> objectId, [WorkflowExpression] Func<bool> includeRelatedObjects = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/catalog/object/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeRelatedObjects != null)
                    callPayload.Queries["include_related_objects"] = SourceExpressionConverter.ConvertO(includeRelatedObjects);
                return callPayload;
            }

            return new ApiConnectionAction<CatalogRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogDeleteResponse> CatalogDelete([WorkflowExpression] Func<string> objectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/catalog/object/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(objectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CatalogDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogSearchResponse> CatalogSearch([WorkflowExpression] Func<string[]> bodyobjectTypes = null, [WorkflowExpression] Func<string> bodyqueryprefixQueryattributeName = null, [WorkflowExpression] Func<string> bodyqueryprefixQueryattributePrefix = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobjectTypes != null)
                {
                    body["object_types"] = SourceExpressionConverter.ConvertToken(bodyobjectTypes);
                    bodypropCount++;
                }

                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var prefixQueryObject = new JObject();
                var prefixQueryObjectpropCount = 0;
                if (bodyqueryprefixQueryattributeName != null)
                {
                    prefixQueryObject["attribute_name"] = SourceExpressionConverter.ConvertToken(bodyqueryprefixQueryattributeName);
                    prefixQueryObjectpropCount++;
                }

                if (bodyqueryprefixQueryattributePrefix != null)
                {
                    prefixQueryObject["attribute_prefix"] = SourceExpressionConverter.ConvertToken(bodyqueryprefixQueryattributePrefix);
                    prefixQueryObjectpropCount++;
                }

                if (prefixQueryObjectpropCount > 0)
                {
                    queryObject["prefix_query"] = prefixQueryObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogUpdateModifierResponse> CatalogUpdateModifier([WorkflowExpression] Func<string[]> bodyitemIds = null, [WorkflowExpression] Func<string[]> bodymodifierListsToEnable = null, [WorkflowExpression] Func<string[]> bodymodifierListsToDisable = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/update-item-modifier-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyitemIds != null)
                {
                    body["item_ids"] = SourceExpressionConverter.ConvertToken(bodyitemIds);
                    bodypropCount++;
                }

                if (bodymodifierListsToEnable != null)
                {
                    body["modifier_lists_to_enable"] = SourceExpressionConverter.ConvertToken(bodymodifierListsToEnable);
                    bodypropCount++;
                }

                if (bodymodifierListsToDisable != null)
                {
                    body["modifier_lists_to_disable"] = SourceExpressionConverter.ConvertToken(bodymodifierListsToDisable);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogUpdateModifierResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogUpdateTaxesResponse> CatalogUpdateTaxes([WorkflowExpression] Func<string[]> bodyitemIds = null, [WorkflowExpression] Func<string[]> bodytaxesToEnable = null, [WorkflowExpression] Func<string[]> bodytaxesToDisable = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/catalog/update-item-taxes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyitemIds != null)
                {
                    body["item_ids"] = SourceExpressionConverter.ConvertToken(bodyitemIds);
                    bodypropCount++;
                }

                if (bodytaxesToEnable != null)
                {
                    body["taxes_to_enable"] = SourceExpressionConverter.ConvertToken(bodytaxesToEnable);
                    bodypropCount++;
                }

                if (bodytaxesToDisable != null)
                {
                    body["taxes_to_disable"] = SourceExpressionConverter.ConvertToken(bodytaxesToDisable);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CatalogUpdateTaxesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerGroupListResponse> CustomerGroupList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/customers/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerGroupListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomGroupCreateResponse> CustomGroupCreate([WorkflowExpression] Func<string> bodygroupname = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/customers/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodygroupname != null)
                {
                    groupObject["name"] = SourceExpressionConverter.ConvertToken(bodygroupname);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    body["group"] = groupObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomGroupCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerGroupRetrieveResponse> CustomerGroupRetrieve([WorkflowExpression] Func<string> groupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerGroupRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> CustomerGroupDelete([WorkflowExpression] Func<string> groupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerGroupUpdateResponse> CustomerGroupUpdate([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> bodygroupname = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var groupObject = new JObject();
                var groupObjectpropCount = 0;
                if (bodygroupname != null)
                {
                    groupObject["name"] = SourceExpressionConverter.ConvertToken(bodygroupname);
                    groupObjectpropCount++;
                }

                if (groupObjectpropCount > 0)
                {
                    body["group"] = groupObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerGroupUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerSegmentListResponse> CustomerSegmentList([WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/customers/segments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerSegmentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerSegmentRetrieveResponse> CustomerSegmentRetrieve([WorkflowExpression] Func<string> segmentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/segments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(segmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerSegmentRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerListResponse> CustomerList([WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<sortFieldInput> sortField = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/customers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["sort_field"] = Convert.ToString("DEFAULT");
                if (sortField != null)
                    callPayload.Queries["sort_field"] = SourceExpressionConverter.Convert(sortField);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerCreateResponse> CustomerCreate([WorkflowExpression] Func<string> bodygivenName = null, [WorkflowExpression] Func<string> bodyfamilyName = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodynickname = null, [WorkflowExpression] Func<string> bodyaddressaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressaddressLine2 = null, [WorkflowExpression] Func<string> bodyaddresslocality = null, [WorkflowExpression] Func<string> bodyaddressadministrativeDistrictLevel1 = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodybirthday = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/customers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygivenName != null)
                {
                    body["given_name"] = SourceExpressionConverter.ConvertToken(bodygivenName);
                    bodypropCount++;
                }

                if (bodyfamilyName != null)
                {
                    body["family_name"] = SourceExpressionConverter.ConvertToken(bodyfamilyName);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["email_address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["company_name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodynickname != null)
                {
                    body["nickname"] = SourceExpressionConverter.ConvertToken(bodynickname);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyaddressaddressLine1 != null)
                {
                    addressObject["address_line_1"] = SourceExpressionConverter.ConvertToken(bodyaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (bodyaddressaddressLine2 != null)
                {
                    addressObject["address_line_2"] = SourceExpressionConverter.ConvertToken(bodyaddressaddressLine2);
                    addressObjectpropCount++;
                }

                if (bodyaddresslocality != null)
                {
                    addressObject["locality"] = SourceExpressionConverter.ConvertToken(bodyaddresslocality);
                    addressObjectpropCount++;
                }

                if (bodyaddressadministrativeDistrictLevel1 != null)
                {
                    addressObject["administrative_district_level_1"] = SourceExpressionConverter.ConvertToken(bodyaddressadministrativeDistrictLevel1);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                if (bodyphoneNumber != null)
                {
                    body["phone_number"] = SourceExpressionConverter.ConvertToken(bodyphoneNumber);
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["reference_id"] = SourceExpressionConverter.ConvertToken(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodybirthday != null)
                {
                    body["birthday"] = SourceExpressionConverter.ConvertToken(bodybirthday);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerSearchResponse> CustomerSearch([WorkflowExpression] Func<string> bodyqueryfilteremailAddressfuzzy = null, [WorkflowExpression] Func<string[]> bodyqueryfiltercreationSourcevalues = null, [WorkflowExpression] Func<string> bodyqueryfiltercreationSourcerule = null, [WorkflowExpression] Func<string> bodyqueryfiltercreatedAtstartAt = null, [WorkflowExpression] Func<string> bodyqueryfiltercreatedAtendAt = null, [WorkflowExpression] Func<string[]> bodyqueryfiltergroupIdsall = null, [WorkflowExpression] Func<string> bodyquerysortfield = null, [WorkflowExpression] Func<string> bodyquerysortorder = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/customers/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var emailAddressObject = new JObject();
                var emailAddressObjectpropCount = 0;
                if (bodyqueryfilteremailAddressfuzzy != null)
                {
                    emailAddressObject["fuzzy"] = SourceExpressionConverter.ConvertToken(bodyqueryfilteremailAddressfuzzy);
                    emailAddressObjectpropCount++;
                }

                if (emailAddressObjectpropCount > 0)
                {
                    filterObject["email_address"] = emailAddressObject;
                    filterObjectpropCount++;
                }

                var creationSourceObject = new JObject();
                var creationSourceObjectpropCount = 0;
                if (bodyqueryfiltercreationSourcevalues != null)
                {
                    creationSourceObject["values"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltercreationSourcevalues);
                    creationSourceObjectpropCount++;
                }

                if (bodyqueryfiltercreationSourcerule != null)
                {
                    creationSourceObject["rule"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltercreationSourcerule);
                    creationSourceObjectpropCount++;
                }

                if (creationSourceObjectpropCount > 0)
                {
                    filterObject["creation_source"] = creationSourceObject;
                    filterObjectpropCount++;
                }

                var createdAtObject = new JObject();
                var createdAtObjectpropCount = 0;
                if (bodyqueryfiltercreatedAtstartAt != null)
                {
                    createdAtObject["start_at"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltercreatedAtstartAt);
                    createdAtObjectpropCount++;
                }

                if (bodyqueryfiltercreatedAtendAt != null)
                {
                    createdAtObject["end_at"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltercreatedAtendAt);
                    createdAtObjectpropCount++;
                }

                if (createdAtObjectpropCount > 0)
                {
                    filterObject["created_at"] = createdAtObject;
                    filterObjectpropCount++;
                }

                var groupIdsObject = new JObject();
                var groupIdsObjectpropCount = 0;
                if (bodyqueryfiltergroupIdsall != null)
                {
                    groupIdsObject["all"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltergroupIdsall);
                    groupIdsObjectpropCount++;
                }

                if (groupIdsObjectpropCount > 0)
                {
                    filterObject["group_ids"] = groupIdsObject;
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (bodyquerysortfield != null)
                {
                    sortObject["field"] = SourceExpressionConverter.ConvertToken(bodyquerysortfield);
                    sortObjectpropCount++;
                }

                if (bodyquerysortorder != null)
                {
                    sortObject["order"] = SourceExpressionConverter.ConvertToken(bodyquerysortorder);
                    sortObjectpropCount++;
                }

                if (sortObjectpropCount > 0)
                {
                    queryObject["sort"] = sortObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CustomerSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerRetrieveResponse> CustomerRetrieve([WorkflowExpression] Func<string> customerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> CustomerDelete([WorkflowExpression] Func<string> customerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerUpdateResponse> CustomerUpdate([WorkflowExpression] Func<string> customerId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> CustomerRemoveGroup([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> groupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/{0}/groups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> CustomerAddGroup([WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> groupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/customers/{0}/groups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeListResponse> DisputeList([WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<statesInput> states = null, [WorkflowExpression] Func<string> locationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/disputes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (states != null)
                    callPayload.Queries["states"] = SourceExpressionConverter.Convert(states);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                return callPayload;
            }

            return new ApiConnectionAction<DisputeListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeRetrieveResponse> DisputeRetrieve([WorkflowExpression] Func<string> disputeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DisputeRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeAcceptResponse> DisputeAccept([WorkflowExpression] Func<string> disputeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}/accept", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DisputeAcceptResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeListEvidenceResponse> DisputeListEvidence([WorkflowExpression] Func<string> disputeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}/evidence", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DisputeListEvidenceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeCreateEvidenceTextResponse> DisputeCreateEvidenceText([WorkflowExpression] Func<string> disputeId, [WorkflowExpression] Func<bodyevidenceTypeInput> bodyevidenceType = null, [WorkflowExpression] Func<string> bodyevidenceText = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}/evidence-text", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyevidenceType != null)
                {
                    body["evidence_type"] = SourceExpressionConverter.Convert(bodyevidenceType);
                    bodypropCount++;
                }

                if (bodyevidenceText != null)
                {
                    body["evidence_text"] = SourceExpressionConverter.ConvertToken(bodyevidenceText);
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DisputeCreateEvidenceTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeRetrieveEvidenceResponse> DisputeRetrieveEvidence([WorkflowExpression] Func<string> disputeId, [WorkflowExpression] Func<string> evidenceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}/evidence/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(evidenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DisputeRetrieveEvidenceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> DisputeDeleteEvidence([WorkflowExpression] Func<string> disputeId, [WorkflowExpression] Func<string> evidenceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}/evidence/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(evidenceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<EvidenceSubmitResponse> EvidenceSubmit([WorkflowExpression] Func<string> disputeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/disputes/{0}/submit-evidence", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(disputeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<EvidenceSubmitResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrieveAdjustmentResponse> InventoryRetrieveAdjustment([WorkflowExpression] Func<string> adjustmentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/inventory/adjustments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(adjustmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InventoryRetrieveAdjustmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryBatchChangeResponse> InventoryBatchChange([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<bodychangesInputItem[]> bodychanges = null, [WorkflowExpression] Func<bool> bodyignoreUnchangedCounts = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/inventory/changes/batch-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodychanges != null)
                {
                    body["changes"] = SourceExpressionConverter.ConvertToken(bodychanges);
                    bodypropCount++;
                }

                if (bodyignoreUnchangedCounts != null)
                {
                    body["ignore_unchanged_counts"] = SourceExpressionConverter.ConvertToken(bodyignoreUnchangedCounts);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InventoryBatchChangeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryBatchRetrieveChangesResponse> InventoryBatchRetrieveChanges([WorkflowExpression] Func<string[]> bodycatalogObjectIds = null, [WorkflowExpression] Func<string[]> bodylocationIds = null, [WorkflowExpression] Func<string[]> bodytypes = null, [WorkflowExpression] Func<string[]> bodystates = null, [WorkflowExpression] Func<string> bodyupdatedAfter = null, [WorkflowExpression] Func<string> bodyupdatedBefore = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/inventory/changes/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycatalogObjectIds != null)
                {
                    body["catalog_object_ids"] = SourceExpressionConverter.ConvertToken(bodycatalogObjectIds);
                    bodypropCount++;
                }

                if (bodylocationIds != null)
                {
                    body["location_ids"] = SourceExpressionConverter.ConvertToken(bodylocationIds);
                    bodypropCount++;
                }

                if (bodytypes != null)
                {
                    body["types"] = SourceExpressionConverter.ConvertToken(bodytypes);
                    bodypropCount++;
                }

                if (bodystates != null)
                {
                    body["states"] = SourceExpressionConverter.ConvertToken(bodystates);
                    bodypropCount++;
                }

                if (bodyupdatedAfter != null)
                {
                    body["updated_after"] = SourceExpressionConverter.ConvertToken(bodyupdatedAfter);
                    bodypropCount++;
                }

                if (bodyupdatedBefore != null)
                {
                    body["updated_before"] = SourceExpressionConverter.ConvertToken(bodyupdatedBefore);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InventoryBatchRetrieveChangesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryBatchRetrieveCountsResponse> InventoryBatchRetrieveCounts([WorkflowExpression] Func<string[]> bodycatalogObjectIds = null, [WorkflowExpression] Func<string[]> bodylocationIds = null, [WorkflowExpression] Func<string> bodyupdatedAfter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/inventory/counts/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycatalogObjectIds != null)
                {
                    body["catalog_object_ids"] = SourceExpressionConverter.ConvertToken(bodycatalogObjectIds);
                    bodypropCount++;
                }

                if (bodylocationIds != null)
                {
                    body["location_ids"] = SourceExpressionConverter.ConvertToken(bodylocationIds);
                    bodypropCount++;
                }

                if (bodyupdatedAfter != null)
                {
                    body["updated_after"] = SourceExpressionConverter.ConvertToken(bodyupdatedAfter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InventoryBatchRetrieveCountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrievePhysicalCountResponse> InventoryRetrievePhysicalCount([WorkflowExpression] Func<string> physicalCountId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/inventory/physical-counts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(physicalCountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InventoryRetrievePhysicalCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrieveTransferResponse> InventoryRetrieveTransfer([WorkflowExpression] Func<string> transferId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/inventory/transfers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(transferId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InventoryRetrieveTransferResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrieveCountResponse> InventoryRetrieveCount([WorkflowExpression] Func<string> catalogObjectId, [WorkflowExpression] Func<string> locationIds = null, [WorkflowExpression] Func<string> cursor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/inventory/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogObjectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locationIds != null)
                    callPayload.Queries["location_ids"] = SourceExpressionConverter.ConvertO(locationIds);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<InventoryRetrieveCountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceListResponse> InvoiceList([WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceCreateResponse> InvoiceCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyinvoicelocationId = null, [WorkflowExpression] Func<string> bodyinvoiceorderId = null, [WorkflowExpression] Func<string> bodyinvoicescheduledAt = null, [WorkflowExpression] Func<string> bodyinvoiceprimaryRecipientcustomerId = null, [WorkflowExpression] Func<string> bodyinvoicedeliveryMethod = null, [WorkflowExpression] Func<bodyinvoicepaymentRequestsInputItem[]> bodyinvoicepaymentRequests = null, [WorkflowExpression] Func<string> bodyinvoiceinvoiceNumber = null, [WorkflowExpression] Func<string> bodyinvoicetitle = null, [WorkflowExpression] Func<string> bodyinvoicedescription = null, [WorkflowExpression] Func<bool> bodyinvoiceacceptedPaymentMethodscard = null, [WorkflowExpression] Func<bool> bodyinvoiceacceptedPaymentMethodssquareGiftCard = null, [WorkflowExpression] Func<bool> bodyinvoiceacceptedPaymentMethodsbankAccount = null, [WorkflowExpression] Func<bodyinvoicecustomFieldsInputItem[]> bodyinvoicecustomFields = null, [WorkflowExpression] Func<string> bodyinvoicesaleOrServiceDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var invoiceObject = new JObject();
                var invoiceObjectpropCount = 0;
                if (bodyinvoicelocationId != null)
                {
                    invoiceObject["location_id"] = SourceExpressionConverter.ConvertToken(bodyinvoicelocationId);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoiceorderId != null)
                {
                    invoiceObject["order_id"] = SourceExpressionConverter.ConvertToken(bodyinvoiceorderId);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicescheduledAt != null)
                {
                    invoiceObject["scheduled_at"] = SourceExpressionConverter.ConvertToken(bodyinvoicescheduledAt);
                    invoiceObjectpropCount++;
                }

                var primaryRecipientObject = new JObject();
                var primaryRecipientObjectpropCount = 0;
                if (bodyinvoiceprimaryRecipientcustomerId != null)
                {
                    primaryRecipientObject["customer_id"] = SourceExpressionConverter.ConvertToken(bodyinvoiceprimaryRecipientcustomerId);
                    primaryRecipientObjectpropCount++;
                }

                if (primaryRecipientObjectpropCount > 0)
                {
                    invoiceObject["primary_recipient"] = primaryRecipientObject;
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicedeliveryMethod != null)
                {
                    invoiceObject["delivery_method"] = SourceExpressionConverter.ConvertToken(bodyinvoicedeliveryMethod);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicepaymentRequests != null)
                {
                    invoiceObject["payment_requests"] = SourceExpressionConverter.ConvertToken(bodyinvoicepaymentRequests);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoiceinvoiceNumber != null)
                {
                    invoiceObject["invoice_number"] = SourceExpressionConverter.ConvertToken(bodyinvoiceinvoiceNumber);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicetitle != null)
                {
                    invoiceObject["title"] = SourceExpressionConverter.ConvertToken(bodyinvoicetitle);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicedescription != null)
                {
                    invoiceObject["description"] = SourceExpressionConverter.ConvertToken(bodyinvoicedescription);
                    invoiceObjectpropCount++;
                }

                var acceptedPaymentMethodsObject = new JObject();
                var acceptedPaymentMethodsObjectpropCount = 0;
                if (bodyinvoiceacceptedPaymentMethodscard != null)
                {
                    acceptedPaymentMethodsObject["card"] = SourceExpressionConverter.ConvertToken(bodyinvoiceacceptedPaymentMethodscard);
                    acceptedPaymentMethodsObjectpropCount++;
                }

                if (bodyinvoiceacceptedPaymentMethodssquareGiftCard != null)
                {
                    acceptedPaymentMethodsObject["square_gift_card"] = SourceExpressionConverter.ConvertToken(bodyinvoiceacceptedPaymentMethodssquareGiftCard);
                    acceptedPaymentMethodsObjectpropCount++;
                }

                if (bodyinvoiceacceptedPaymentMethodsbankAccount != null)
                {
                    acceptedPaymentMethodsObject["bank_account"] = SourceExpressionConverter.ConvertToken(bodyinvoiceacceptedPaymentMethodsbankAccount);
                    acceptedPaymentMethodsObjectpropCount++;
                }

                if (acceptedPaymentMethodsObjectpropCount > 0)
                {
                    invoiceObject["accepted_payment_methods"] = acceptedPaymentMethodsObject;
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicecustomFields != null)
                {
                    invoiceObject["custom_fields"] = SourceExpressionConverter.ConvertToken(bodyinvoicecustomFields);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicesaleOrServiceDate != null)
                {
                    invoiceObject["sale_or_service_date"] = SourceExpressionConverter.ConvertToken(bodyinvoicesaleOrServiceDate);
                    invoiceObjectpropCount++;
                }

                if (invoiceObjectpropCount > 0)
                {
                    body["invoice"] = invoiceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceSearchResponse> InvoiceSearch([WorkflowExpression] Func<string[]> bodyqueryfilterlocationIds = null, [WorkflowExpression] Func<string[]> bodyqueryfiltercustomerIds = null, [WorkflowExpression] Func<string> bodyquerysortfield = null, [WorkflowExpression] Func<string> bodyquerysortorder = null, [WorkflowExpression] Func<int> bodyquerylimit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyqueryfilterlocationIds != null)
                {
                    filterObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterlocationIds);
                    filterObjectpropCount++;
                }

                if (bodyqueryfiltercustomerIds != null)
                {
                    filterObject["customer_ids"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltercustomerIds);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (bodyquerysortfield != null)
                {
                    sortObject["field"] = SourceExpressionConverter.ConvertToken(bodyquerysortfield);
                    sortObjectpropCount++;
                }

                if (bodyquerysortorder != null)
                {
                    sortObject["order"] = SourceExpressionConverter.ConvertToken(bodyquerysortorder);
                    sortObjectpropCount++;
                }

                if (sortObjectpropCount > 0)
                {
                    queryObject["sort"] = sortObject;
                    queryObjectpropCount++;
                }

                if (bodyquerylimit != null)
                {
                    queryObject["limit"] = SourceExpressionConverter.ConvertToken(bodyquerylimit);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceGetResponse> InvoiceGet([WorkflowExpression] Func<string> invoiceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> InvoiceDelete([WorkflowExpression] Func<string> invoiceId, [WorkflowExpression] Func<int> version = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (version != null)
                    callPayload.Queries["version"] = SourceExpressionConverter.ConvertO(version);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceUpdateResponse> InvoiceUpdate([WorkflowExpression] Func<string> invoiceId, [WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<bodyinvoicepaymentRequestsInputItem2[]> bodyinvoicepaymentRequests = null, [WorkflowExpression] Func<string[]> bodyfieldsToClear = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var invoiceObject = new JObject();
                var invoiceObjectpropCount = 0;
                if (bodyinvoicepaymentRequests != null)
                {
                    invoiceObject["payment_requests"] = SourceExpressionConverter.ConvertToken(bodyinvoicepaymentRequests);
                    invoiceObjectpropCount++;
                }

                if (invoiceObjectpropCount > 0)
                {
                    body["invoice"] = invoiceObject;
                    bodypropCount++;
                }

                if (bodyfieldsToClear != null)
                {
                    body["fields_to_clear"] = SourceExpressionConverter.ConvertToken(bodyfieldsToClear);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceCancelResponse> InvoiceCancel([WorkflowExpression] Func<string> invoiceId, [WorkflowExpression] Func<int> bodyversion = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyversion != null)
                {
                    body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceCancelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoicePublishResponse> InvoicePublish([WorkflowExpression] Func<string> invoiceId, [WorkflowExpression] Func<int> bodyversion = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyversion != null)
                {
                    body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoicePublishResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderCreateResponse> OrderCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyorderreferenceId = null, [WorkflowExpression] Func<string> bodyorderlocationId = null, [WorkflowExpression] Func<bodyorderlineItemsInputItem[]> bodyorderlineItems = null, [WorkflowExpression] Func<bodyordertaxesInputItem[]> bodyordertaxes = null, [WorkflowExpression] Func<bodyorderdiscountsInputItem[]> bodyorderdiscounts = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var orderObject = new JObject();
                var orderObjectpropCount = 0;
                if (bodyorderreferenceId != null)
                {
                    orderObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodyorderreferenceId);
                    orderObjectpropCount++;
                }

                if (bodyorderlocationId != null)
                {
                    orderObject["location_id"] = SourceExpressionConverter.ConvertToken(bodyorderlocationId);
                    orderObjectpropCount++;
                }

                if (bodyorderlineItems != null)
                {
                    orderObject["line_items"] = SourceExpressionConverter.ConvertToken(bodyorderlineItems);
                    orderObjectpropCount++;
                }

                if (bodyordertaxes != null)
                {
                    orderObject["taxes"] = SourceExpressionConverter.ConvertToken(bodyordertaxes);
                    orderObjectpropCount++;
                }

                if (bodyorderdiscounts != null)
                {
                    orderObject["discounts"] = SourceExpressionConverter.ConvertToken(bodyorderdiscounts);
                    orderObjectpropCount++;
                }

                if (orderObjectpropCount > 0)
                {
                    body["order"] = orderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderBatchRetrieveResponse> OrderBatchRetrieve([WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string[]> bodyorderIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/orders/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyorderIds != null)
                {
                    body["order_ids"] = SourceExpressionConverter.ConvertToken(bodyorderIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderBatchRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderCalculateResponse> OrderCalculate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyorderlocationId = null, [WorkflowExpression] Func<bodyorderdiscountsInputItem2[]> bodyorderdiscounts = null, [WorkflowExpression] Func<bodyorderlineItemsInputItem2[]> bodyorderlineItems = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/orders/calculate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var orderObject = new JObject();
                var orderObjectpropCount = 0;
                if (bodyorderlocationId != null)
                {
                    orderObject["location_id"] = SourceExpressionConverter.ConvertToken(bodyorderlocationId);
                    orderObjectpropCount++;
                }

                if (bodyorderdiscounts != null)
                {
                    orderObject["discounts"] = SourceExpressionConverter.ConvertToken(bodyorderdiscounts);
                    orderObjectpropCount++;
                }

                if (bodyorderlineItems != null)
                {
                    orderObject["line_items"] = SourceExpressionConverter.ConvertToken(bodyorderlineItems);
                    orderObjectpropCount++;
                }

                if (orderObjectpropCount > 0)
                {
                    body["order"] = orderObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderCalculateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderCloneResponse> OrderClone([WorkflowExpression] Func<string> bodyorderId = null, [WorkflowExpression] Func<int> bodyversion = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/orders/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderId != null)
                {
                    body["order_id"] = SourceExpressionConverter.ConvertToken(bodyorderId);
                    bodypropCount++;
                }

                if (bodyversion != null)
                {
                    body["version"] = SourceExpressionConverter.ConvertToken(bodyversion);
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderCloneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderSearchResponse> OrderSearch([WorkflowExpression] Func<bool> bodyreturnEntries = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string[]> bodylocationIds = null, [WorkflowExpression] Func<string> bodyqueryfilterdateTimeFilterclosedAtstartAt = null, [WorkflowExpression] Func<string> bodyqueryfilterdateTimeFilterclosedAtendAt = null, [WorkflowExpression] Func<string[]> bodyqueryfilterstateFilterstates = null, [WorkflowExpression] Func<string> bodyquerysortsortField = null, [WorkflowExpression] Func<string> bodyquerysortsortOrder = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/orders/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyreturnEntries != null)
                {
                    body["return_entries"] = SourceExpressionConverter.ConvertToken(bodyreturnEntries);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodylocationIds != null)
                {
                    body["location_ids"] = SourceExpressionConverter.ConvertToken(bodylocationIds);
                    bodypropCount++;
                }

                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var dateTimeFilterObject = new JObject();
                var dateTimeFilterObjectpropCount = 0;
                var closedAtObject = new JObject();
                var closedAtObjectpropCount = 0;
                if (bodyqueryfilterdateTimeFilterclosedAtstartAt != null)
                {
                    closedAtObject["start_at"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterdateTimeFilterclosedAtstartAt);
                    closedAtObjectpropCount++;
                }

                if (bodyqueryfilterdateTimeFilterclosedAtendAt != null)
                {
                    closedAtObject["end_at"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterdateTimeFilterclosedAtendAt);
                    closedAtObjectpropCount++;
                }

                if (closedAtObjectpropCount > 0)
                {
                    dateTimeFilterObject["closed_at"] = closedAtObject;
                    dateTimeFilterObjectpropCount++;
                }

                if (dateTimeFilterObjectpropCount > 0)
                {
                    filterObject["date_time_filter"] = dateTimeFilterObject;
                    filterObjectpropCount++;
                }

                var stateFilterObject = new JObject();
                var stateFilterObjectpropCount = 0;
                if (bodyqueryfilterstateFilterstates != null)
                {
                    stateFilterObject["states"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterstateFilterstates);
                    stateFilterObjectpropCount++;
                }

                if (stateFilterObjectpropCount > 0)
                {
                    filterObject["state_filter"] = stateFilterObject;
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                var sortObject = new JObject();
                var sortObjectpropCount = 0;
                if (bodyquerysortsortField != null)
                {
                    sortObject["sort_field"] = SourceExpressionConverter.ConvertToken(bodyquerysortsortField);
                    sortObjectpropCount++;
                }

                if (bodyquerysortsortOrder != null)
                {
                    sortObject["sort_order"] = SourceExpressionConverter.ConvertToken(bodyquerysortsortOrder);
                    sortObjectpropCount++;
                }

                if (sortObjectpropCount > 0)
                {
                    queryObject["sort"] = sortObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderRetrieveResponse> OrderRetrieve([WorkflowExpression] Func<string> orderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/orders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(orderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OrderRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderUpdateResponse> OrderUpdate([WorkflowExpression] Func<string> orderId, [WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<int> bodyorderversion = null, [WorkflowExpression] Func<bodyorderlineItemsInputItem22[]> bodyorderlineItems = null, [WorkflowExpression] Func<string[]> bodyfieldsToClear = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/orders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(orderId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var orderObject = new JObject();
                var orderObjectpropCount = 0;
                if (bodyorderversion != null)
                {
                    orderObject["version"] = SourceExpressionConverter.ConvertToken(bodyorderversion);
                    orderObjectpropCount++;
                }

                if (bodyorderlineItems != null)
                {
                    orderObject["line_items"] = SourceExpressionConverter.ConvertToken(bodyorderlineItems);
                    orderObjectpropCount++;
                }

                if (orderObjectpropCount > 0)
                {
                    body["order"] = orderObject;
                    bodypropCount++;
                }

                if (bodyfieldsToClear != null)
                {
                    body["fields_to_clear"] = SourceExpressionConverter.ConvertToken(bodyfieldsToClear);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderPayResponse> OrderPay([WorkflowExpression] Func<string> orderId, [WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string[]> bodypaymentIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/orders/{0}/pay", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(orderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypaymentIds != null)
                {
                    body["payment_ids"] = SourceExpressionConverter.ConvertToken(bodypaymentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderPayResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentListResponse> PaymentList([WorkflowExpression] Func<string> beginTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<int> total = null, [WorkflowExpression] Func<string> last4 = null, [WorkflowExpression] Func<string> cardBrand = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/payments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (beginTime != null)
                    callPayload.Queries["begin_time"] = SourceExpressionConverter.ConvertO(beginTime);
                if (endTime != null)
                    callPayload.Queries["end_time"] = SourceExpressionConverter.ConvertO(endTime);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (total != null)
                    callPayload.Queries["total"] = SourceExpressionConverter.ConvertO(total);
                if (last4 != null)
                    callPayload.Queries["last_4"] = SourceExpressionConverter.ConvertO(last4);
                if (cardBrand != null)
                    callPayload.Queries["card_brand"] = SourceExpressionConverter.ConvertO(cardBrand);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<PaymentListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentCreateResponse> PaymentCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<int> bodyamountMoneyamount = null, [WorkflowExpression] Func<string> bodyamountMoneycurrency = null, [WorkflowExpression] Func<string> bodysourceId = null, [WorkflowExpression] Func<bool> bodyautocomplete = null, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyreferenceId = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<int> bodyappFeeMoneyamount = null, [WorkflowExpression] Func<string> bodyappFeeMoneycurrency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/payments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var amountMoneyObject = new JObject();
                var amountMoneyObjectpropCount = 0;
                if (bodyamountMoneyamount != null)
                {
                    amountMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodyamountMoneyamount);
                    amountMoneyObjectpropCount++;
                }

                if (bodyamountMoneycurrency != null)
                {
                    amountMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodyamountMoneycurrency);
                    amountMoneyObjectpropCount++;
                }

                if (amountMoneyObjectpropCount > 0)
                {
                    body["amount_money"] = amountMoneyObject;
                    bodypropCount++;
                }

                if (bodysourceId != null)
                {
                    body["source_id"] = SourceExpressionConverter.ConvertToken(bodysourceId);
                    bodypropCount++;
                }

                if (bodyautocomplete != null)
                {
                    body["autocomplete"] = SourceExpressionConverter.ConvertToken(bodyautocomplete);
                    bodypropCount++;
                }

                if (bodycustomerId != null)
                {
                    body["customer_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyreferenceId != null)
                {
                    body["reference_id"] = SourceExpressionConverter.ConvertToken(bodyreferenceId);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                var appFeeMoneyObject = new JObject();
                var appFeeMoneyObjectpropCount = 0;
                if (bodyappFeeMoneyamount != null)
                {
                    appFeeMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodyappFeeMoneyamount);
                    appFeeMoneyObjectpropCount++;
                }

                if (bodyappFeeMoneycurrency != null)
                {
                    appFeeMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodyappFeeMoneycurrency);
                    appFeeMoneyObjectpropCount++;
                }

                if (appFeeMoneyObjectpropCount > 0)
                {
                    body["app_fee_money"] = appFeeMoneyObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PaymentCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken> PaymentCancelIdempotency([WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/payments/cancel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentGetResponse> PaymentGet([WorkflowExpression] Func<string> paymentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/payments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(paymentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PaymentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentUpdateResponse> PaymentUpdate([WorkflowExpression] Func<string> paymentId, [WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<int> bodypaymentamountMoneyamount = null, [WorkflowExpression] Func<string> bodypaymentamountMoneycurrency = null, [WorkflowExpression] Func<int> bodypaymenttipMoneyamount = null, [WorkflowExpression] Func<string> bodypaymenttipMoneycurrency = null, [WorkflowExpression] Func<string> bodypaymentversionToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/payments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(paymentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var paymentObject = new JObject();
                var paymentObjectpropCount = 0;
                var amountMoneyObject = new JObject();
                var amountMoneyObjectpropCount = 0;
                if (bodypaymentamountMoneyamount != null)
                {
                    amountMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodypaymentamountMoneyamount);
                    amountMoneyObjectpropCount++;
                }

                if (bodypaymentamountMoneycurrency != null)
                {
                    amountMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodypaymentamountMoneycurrency);
                    amountMoneyObjectpropCount++;
                }

                if (amountMoneyObjectpropCount > 0)
                {
                    paymentObject["amount_money"] = amountMoneyObject;
                    paymentObjectpropCount++;
                }

                var tipMoneyObject = new JObject();
                var tipMoneyObjectpropCount = 0;
                if (bodypaymenttipMoneyamount != null)
                {
                    tipMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodypaymenttipMoneyamount);
                    tipMoneyObjectpropCount++;
                }

                if (bodypaymenttipMoneycurrency != null)
                {
                    tipMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodypaymenttipMoneycurrency);
                    tipMoneyObjectpropCount++;
                }

                if (tipMoneyObjectpropCount > 0)
                {
                    paymentObject["tip_money"] = tipMoneyObject;
                    paymentObjectpropCount++;
                }

                if (bodypaymentversionToken != null)
                {
                    paymentObject["version_token"] = SourceExpressionConverter.ConvertToken(bodypaymentversionToken);
                    paymentObjectpropCount++;
                }

                if (paymentObjectpropCount > 0)
                {
                    body["payment"] = paymentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PaymentUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentCancelResponse> PaymentCancel([WorkflowExpression] Func<string> paymentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/payments/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(paymentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PaymentCancelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentCompleteResponse> PaymentComplete([WorkflowExpression] Func<string> paymentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/payments/{0}/complete", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(paymentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PaymentCompleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<RefundListResponse> RefundList([WorkflowExpression] Func<string> beginTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> sourceType = null, [WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/refunds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (beginTime != null)
                    callPayload.Queries["begin_time"] = SourceExpressionConverter.ConvertO(beginTime);
                if (endTime != null)
                    callPayload.Queries["end_time"] = SourceExpressionConverter.ConvertO(endTime);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (sourceType != null)
                    callPayload.Queries["source_type"] = SourceExpressionConverter.ConvertO(sourceType);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<RefundListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<RefundPaymentResponse> RefundPayment([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodypaymentId = null, [WorkflowExpression] Func<int> bodyamountMoneyamount = null, [WorkflowExpression] Func<string> bodyamountMoneycurrency = null, [WorkflowExpression] Func<int> bodyappFeeMoneyamount = null, [WorkflowExpression] Func<string> bodyappFeeMoneycurrency = null, [WorkflowExpression] Func<string> bodyreason = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/refunds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypaymentId != null)
                {
                    body["payment_id"] = SourceExpressionConverter.ConvertToken(bodypaymentId);
                    bodypropCount++;
                }

                var amountMoneyObject = new JObject();
                var amountMoneyObjectpropCount = 0;
                if (bodyamountMoneyamount != null)
                {
                    amountMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodyamountMoneyamount);
                    amountMoneyObjectpropCount++;
                }

                if (bodyamountMoneycurrency != null)
                {
                    amountMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodyamountMoneycurrency);
                    amountMoneyObjectpropCount++;
                }

                if (amountMoneyObjectpropCount > 0)
                {
                    body["amount_money"] = amountMoneyObject;
                    bodypropCount++;
                }

                var appFeeMoneyObject = new JObject();
                var appFeeMoneyObjectpropCount = 0;
                if (bodyappFeeMoneyamount != null)
                {
                    appFeeMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodyappFeeMoneyamount);
                    appFeeMoneyObjectpropCount++;
                }

                if (bodyappFeeMoneycurrency != null)
                {
                    appFeeMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodyappFeeMoneycurrency);
                    appFeeMoneyObjectpropCount++;
                }

                if (appFeeMoneyObjectpropCount > 0)
                {
                    body["app_fee_money"] = appFeeMoneyObject;
                    bodypropCount++;
                }

                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RefundPaymentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<RefundGetResponse> RefundGet([WorkflowExpression] Func<string> refundId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/refunds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(refundId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RefundGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionCreateResponse> SubscriptionCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyplanId = null, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<string> bodycardId = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodytaxPercentage = null, [WorkflowExpression] Func<int> bodypriceOverrideMoneyamount = null, [WorkflowExpression] Func<string> bodypriceOverrideMoneycurrency = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodysourcename = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyplanId != null)
                {
                    body["plan_id"] = SourceExpressionConverter.ConvertToken(bodyplanId);
                    bodypropCount++;
                }

                if (bodycustomerId != null)
                {
                    body["customer_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodycardId != null)
                {
                    body["card_id"] = SourceExpressionConverter.ConvertToken(bodycardId);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodytaxPercentage != null)
                {
                    body["tax_percentage"] = SourceExpressionConverter.ConvertToken(bodytaxPercentage);
                    bodypropCount++;
                }

                var priceOverrideMoneyObject = new JObject();
                var priceOverrideMoneyObjectpropCount = 0;
                if (bodypriceOverrideMoneyamount != null)
                {
                    priceOverrideMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodypriceOverrideMoneyamount);
                    priceOverrideMoneyObjectpropCount++;
                }

                if (bodypriceOverrideMoneycurrency != null)
                {
                    priceOverrideMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodypriceOverrideMoneycurrency);
                    priceOverrideMoneyObjectpropCount++;
                }

                if (priceOverrideMoneyObjectpropCount > 0)
                {
                    body["price_override_money"] = priceOverrideMoneyObject;
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                var sourceObject = new JObject();
                var sourceObjectpropCount = 0;
                if (bodysourcename != null)
                {
                    sourceObject["name"] = SourceExpressionConverter.ConvertToken(bodysourcename);
                    sourceObjectpropCount++;
                }

                if (sourceObjectpropCount > 0)
                {
                    body["source"] = sourceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionSearchResponse> SubscriptionSearch([WorkflowExpression] Func<string[]> bodyqueryfilterlocationIds = null, [WorkflowExpression] Func<string[]> bodyqueryfiltercustomerIds = null, [WorkflowExpression] Func<string[]> bodyqueryfiltersourceNames = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/subscriptions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyqueryfilterlocationIds != null)
                {
                    filterObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterlocationIds);
                    filterObjectpropCount++;
                }

                if (bodyqueryfiltercustomerIds != null)
                {
                    filterObject["customer_ids"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltercustomerIds);
                    filterObjectpropCount++;
                }

                if (bodyqueryfiltersourceNames != null)
                {
                    filterObject["source_names"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltersourceNames);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionRetrieveResponse> SubscriptionRetrieve([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionUpdateResponse> SubscriptionUpdate([WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<int> bodysubscriptionversion = null, [WorkflowExpression] Func<string> bodysubscriptiontaxPercentage = null, [WorkflowExpression] Func<int> bodysubscriptionpriceOverrideMoneyamount = null, [WorkflowExpression] Func<string> bodysubscriptionpriceOverrideMoneycurrency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var subscriptionObject = new JObject();
                var subscriptionObjectpropCount = 0;
                if (bodysubscriptionversion != null)
                {
                    subscriptionObject["version"] = SourceExpressionConverter.ConvertToken(bodysubscriptionversion);
                    subscriptionObjectpropCount++;
                }

                if (bodysubscriptiontaxPercentage != null)
                {
                    subscriptionObject["tax_percentage"] = SourceExpressionConverter.ConvertToken(bodysubscriptiontaxPercentage);
                    subscriptionObjectpropCount++;
                }

                var priceOverrideMoneyObject = new JObject();
                var priceOverrideMoneyObjectpropCount = 0;
                if (bodysubscriptionpriceOverrideMoneyamount != null)
                {
                    priceOverrideMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodysubscriptionpriceOverrideMoneyamount);
                    priceOverrideMoneyObjectpropCount++;
                }

                if (bodysubscriptionpriceOverrideMoneycurrency != null)
                {
                    priceOverrideMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodysubscriptionpriceOverrideMoneycurrency);
                    priceOverrideMoneyObjectpropCount++;
                }

                if (priceOverrideMoneyObjectpropCount > 0)
                {
                    subscriptionObject["price_override_money"] = priceOverrideMoneyObject;
                    subscriptionObjectpropCount++;
                }

                if (subscriptionObjectpropCount > 0)
                {
                    body["subscription"] = subscriptionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionCancelResponse> SubscriptionCancel([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionCancelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionListEventsResponse> SubscriptionListEvents([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionListEventsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionResumeResponse> SubscriptionResume([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/subscriptions/{0}/resume", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriptionResumeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCreateCheckoutResponse> TerminalCreateCheckout([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<int> bodycheckoutamountMoneyamount = null, [WorkflowExpression] Func<string> bodycheckoutamountMoneycurrency = null, [WorkflowExpression] Func<string> bodycheckoutreferenceId = null, [WorkflowExpression] Func<string> bodycheckoutdeviceOptionsdeviceId = null, [WorkflowExpression] Func<string> bodycheckoutnote = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/terminals/checkouts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var checkoutObject = new JObject();
                var checkoutObjectpropCount = 0;
                var amountMoneyObject = new JObject();
                var amountMoneyObjectpropCount = 0;
                if (bodycheckoutamountMoneyamount != null)
                {
                    amountMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodycheckoutamountMoneyamount);
                    amountMoneyObjectpropCount++;
                }

                if (bodycheckoutamountMoneycurrency != null)
                {
                    amountMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodycheckoutamountMoneycurrency);
                    amountMoneyObjectpropCount++;
                }

                if (amountMoneyObjectpropCount > 0)
                {
                    checkoutObject["amount_money"] = amountMoneyObject;
                    checkoutObjectpropCount++;
                }

                if (bodycheckoutreferenceId != null)
                {
                    checkoutObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodycheckoutreferenceId);
                    checkoutObjectpropCount++;
                }

                var deviceOptionsObject = new JObject();
                var deviceOptionsObjectpropCount = 0;
                if (bodycheckoutdeviceOptionsdeviceId != null)
                {
                    deviceOptionsObject["device_id"] = SourceExpressionConverter.ConvertToken(bodycheckoutdeviceOptionsdeviceId);
                    deviceOptionsObjectpropCount++;
                }

                if (deviceOptionsObjectpropCount > 0)
                {
                    checkoutObject["device_options"] = deviceOptionsObject;
                    checkoutObjectpropCount++;
                }

                if (bodycheckoutnote != null)
                {
                    checkoutObject["note"] = SourceExpressionConverter.ConvertToken(bodycheckoutnote);
                    checkoutObjectpropCount++;
                }

                if (checkoutObjectpropCount > 0)
                {
                    body["checkout"] = checkoutObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TerminalCreateCheckoutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalSearchCheckoutsResponse> TerminalSearchCheckouts([WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodyqueryfilterstatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/terminals/checkouts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyqueryfilterstatus != null)
                {
                    filterObject["status"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterstatus);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TerminalSearchCheckoutsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalGetCheckoutResponse> TerminalGetCheckout([WorkflowExpression] Func<string> checkoutId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/terminals/checkouts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(checkoutId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TerminalGetCheckoutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCancelCheckoutResponse> TerminalCancelCheckout([WorkflowExpression] Func<string> checkoutId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/terminals/checkouts/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(checkoutId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TerminalCancelCheckoutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCreateRefundResponse> TerminalCreateRefund([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<int> bodyrefundamountMoneyamount = null, [WorkflowExpression] Func<string> bodyrefundamountMoneycurrency = null, [WorkflowExpression] Func<string> bodyrefunddeviceId = null, [WorkflowExpression] Func<string> bodyrefundreason = null, [WorkflowExpression] Func<string> bodyrefundpaymentId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/terminals/refunds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var refundObject = new JObject();
                var refundObjectpropCount = 0;
                var amountMoneyObject = new JObject();
                var amountMoneyObjectpropCount = 0;
                if (bodyrefundamountMoneyamount != null)
                {
                    amountMoneyObject["amount"] = SourceExpressionConverter.ConvertToken(bodyrefundamountMoneyamount);
                    amountMoneyObjectpropCount++;
                }

                if (bodyrefundamountMoneycurrency != null)
                {
                    amountMoneyObject["currency"] = SourceExpressionConverter.ConvertToken(bodyrefundamountMoneycurrency);
                    amountMoneyObjectpropCount++;
                }

                if (amountMoneyObjectpropCount > 0)
                {
                    refundObject["amount_money"] = amountMoneyObject;
                    refundObjectpropCount++;
                }

                if (bodyrefunddeviceId != null)
                {
                    refundObject["device_id"] = SourceExpressionConverter.ConvertToken(bodyrefunddeviceId);
                    refundObjectpropCount++;
                }

                if (bodyrefundreason != null)
                {
                    refundObject["reason"] = SourceExpressionConverter.ConvertToken(bodyrefundreason);
                    refundObjectpropCount++;
                }

                if (bodyrefundpaymentId != null)
                {
                    refundObject["payment_id"] = SourceExpressionConverter.ConvertToken(bodyrefundpaymentId);
                    refundObjectpropCount++;
                }

                if (refundObjectpropCount > 0)
                {
                    body["refund"] = refundObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TerminalCreateRefundResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalSearchRefundsResponse> TerminalSearchRefunds([WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodyqueryfilterstatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/terminals/refunds/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyqueryfilterstatus != null)
                {
                    filterObject["status"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterstatus);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TerminalSearchRefundsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalGetRefundResponse> TerminalGetRefund([WorkflowExpression] Func<string> terminalRefundId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/terminals/refunds/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(terminalRefundId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TerminalGetRefundResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCancelRefundResponse> TerminalCancelRefund([WorkflowExpression] Func<string> terminalRefundId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/terminals/refunds/{0}/cancel", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(terminalRefundId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TerminalCancelRefundResponse>(BuildSourceInput);
        }
    }

    public class SquarepaymentsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApplePayRegisterResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CardListResponse
    {
        [JsonProperty("cards")]
        public CardListResponseCardsTypeItem[] Cards { get; set; }
    }

    public class CardListResponseCardsTypeItem
    {
        [JsonProperty("card")]
        public CardListResponseCardsTypeItemCardType Card { get; set; }
    }

    public class CardListResponseCardsTypeItemCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("billing_address")]
        public CardListResponseCardsTypeItemCardTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CardListResponseCardsTypeItemCardTypeBillingAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public enum sortOrderInput
    {
        ASC,
        DESC
    }

    public class CardCreateResponse
    {
        [JsonProperty("card")]
        public CardCreateResponseCardType Card { get; set; }
    }

    public class CardCreateResponseCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("billing_address")]
        public CardCreateResponseCardTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CardCreateResponseCardTypeBillingAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CardRetrieveResponse
    {
        [JsonProperty("card")]
        public CardRetrieveResponseCardType Card { get; set; }
    }

    public class CardRetrieveResponseCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("billing_address")]
        public CardRetrieveResponseCardTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CardRetrieveResponseCardTypeBillingAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CardDisableResponse
    {
        [JsonProperty("card")]
        public CardDisableResponseCardType Card { get; set; }
    }

    public class CardDisableResponseCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("billing_address")]
        public CardDisableResponseCardTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CardDisableResponseCardTypeBillingAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CatalogBatchDeleteResponse
    {
        [JsonProperty("deleted_object_ids")]
        public string[] DeletedObjectIds { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }

    public class CatalogBatchRetrieveResponse
    {
        [JsonProperty("objects")]
        public CatalogBatchRetrieveResponseObjectsTypeItem[] Objects { get; set; }

        [JsonProperty("related_objects")]
        public CatalogBatchRetrieveResponseRelatedObjectsTypeItem[] RelatedObjects { get; set; }
    }

    public class CatalogBatchRetrieveResponseObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public CatalogBatchRetrieveResponseObjectsTypeItemItemDataType ItemData { get; set; }
    }

    public class CatalogBatchRetrieveResponseObjectsTypeItemItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("tax_ids")]
        public string[] TaxIds { get; set; }

        [JsonProperty("variations")]
        public CatalogBatchRetrieveResponseObjectsTypeItemItemDataTypeVariationsTypeItem[] Variations { get; set; }
    }

    public class CatalogBatchRetrieveResponseObjectsTypeItemItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogBatchRetrieveResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogBatchRetrieveResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public CatalogBatchRetrieveResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class CatalogBatchRetrieveResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogBatchRetrieveResponseRelatedObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("category_data")]
        public CatalogBatchRetrieveResponseRelatedObjectsTypeItemCategoryDataType CategoryData { get; set; }

        [JsonProperty("tax_data")]
        public CatalogBatchRetrieveResponseRelatedObjectsTypeItemTaxDataType TaxData { get; set; }
    }

    public class CatalogBatchRetrieveResponseRelatedObjectsTypeItemCategoryDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CatalogBatchRetrieveResponseRelatedObjectsTypeItemTaxDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("calculation_phase")]
        public string CalculationPhase { get; set; }

        [JsonProperty("inclusion_type")]
        public string InclusionType { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CatalogBatchUpsertResponse
    {
        [JsonProperty("objects")]
        public CatalogBatchUpsertResponseObjectsTypeItem[] Objects { get; set; }

        [JsonProperty("id_mappings")]
        public CatalogBatchUpsertResponseIdMappingsTypeItem[] IdMappings { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public CatalogBatchUpsertResponseObjectsTypeItemItemDataType ItemData { get; set; }

        [JsonProperty("category_data")]
        public CatalogBatchUpsertResponseObjectsTypeItemCategoryDataType CategoryData { get; set; }

        [JsonProperty("tax_data")]
        public CatalogBatchUpsertResponseObjectsTypeItemTaxDataType TaxData { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItemItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("tax_ids")]
        public string[] TaxIds { get; set; }

        [JsonProperty("variations")]
        public CatalogBatchUpsertResponseObjectsTypeItemItemDataTypeVariationsTypeItem[] Variations { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItemItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogBatchUpsertResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public CatalogBatchUpsertResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItemCategoryDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CatalogBatchUpsertResponseObjectsTypeItemTaxDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("calculation_phase")]
        public string CalculationPhase { get; set; }

        [JsonProperty("inclusion_type")]
        public string InclusionType { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applies_to_custom_amounts")]
        public bool AppliesToCustomAmounts { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CatalogBatchUpsertResponseIdMappingsTypeItem
    {
        [JsonProperty("client_object_id")]
        public string ClientObjectId { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }
    }

    public class bodybatchesInputItem
    {
        [JsonProperty("objects")]
        public bodybatchesInputItemObjectsTypeItem[] Objects { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public bodybatchesInputItemObjectsTypeItemItemDataType ItemData { get; set; }

        [JsonProperty("category_data")]
        public bodybatchesInputItemObjectsTypeItemCategoryDataType CategoryData { get; set; }

        [JsonProperty("tax_data")]
        public bodybatchesInputItemObjectsTypeItemTaxDataType TaxData { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItemItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("tax_ids")]
        public string[] TaxIds { get; set; }

        [JsonProperty("variations")]
        public bodybatchesInputItemObjectsTypeItemItemDataTypeVariationsTypeItem[] Variations { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItemItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public bodybatchesInputItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public bodybatchesInputItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItemCategoryDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodybatchesInputItemObjectsTypeItemTaxDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("calculation_phase")]
        public string CalculationPhase { get; set; }

        [JsonProperty("inclusion_type")]
        public string InclusionType { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applies_to_custom_amounts")]
        public bool AppliesToCustomAmounts { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CatalogInfoResponse
    {
        [JsonProperty("limits")]
        public CatalogInfoResponseLimitsType Limits { get; set; }
    }

    public class CatalogInfoResponseLimitsType
    {
        [JsonProperty("batch_upsert_max_objects_per_batch")]
        public int BatchUpsertMaxObjectsPerBatch { get; set; }

        [JsonProperty("batch_upsert_max_total_objects")]
        public int BatchUpsertMaxTotalObjects { get; set; }

        [JsonProperty("batch_retrieve_max_object_ids")]
        public int BatchRetrieveMaxObjectIds { get; set; }

        [JsonProperty("search_max_page_limit")]
        public int SearchMaxPageLimit { get; set; }

        [JsonProperty("batch_delete_max_object_ids")]
        public int BatchDeleteMaxObjectIds { get; set; }

        [JsonProperty("update_item_taxes_max_item_ids")]
        public int UpdateItemTaxesMaxItemIds { get; set; }

        [JsonProperty("update_item_taxes_max_taxes_to_enable")]
        public int UpdateItemTaxesMaxTaxesToEnable { get; set; }

        [JsonProperty("update_item_taxes_max_taxes_to_disable")]
        public int UpdateItemTaxesMaxTaxesToDisable { get; set; }

        [JsonProperty("update_item_modifier_lists_max_item_ids")]
        public int UpdateItemModifierListsMaxItemIds { get; set; }

        [JsonProperty("update_item_modifier_lists_max_modifier_lists_to_enable")]
        public int UpdateItemModifierListsMaxModifierListsToEnable { get; set; }

        [JsonProperty("update_item_modifier_lists_max_modifier_lists_to_disable")]
        public int UpdateItemModifierListsMaxModifierListsToDisable { get; set; }
    }

    public class CatalogListResponse
    {
        [JsonProperty("objects")]
        public CatalogListResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class CatalogListResponseObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("category_data")]
        public CatalogListResponseObjectsTypeItemCategoryDataType CategoryData { get; set; }

        [JsonProperty("tax_data")]
        public CatalogListResponseObjectsTypeItemTaxDataType TaxData { get; set; }
    }

    public class CatalogListResponseObjectsTypeItemCategoryDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CatalogListResponseObjectsTypeItemTaxDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("calculation_phase")]
        public string CalculationPhase { get; set; }

        [JsonProperty("inclusion_type")]
        public string InclusionType { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class CatalogUpsertResponse
    {
        [JsonProperty("catalog_object")]
        public CatalogUpsertResponseCatalogObjectType CatalogObject { get; set; }

        [JsonProperty("id_mappings")]
        public CatalogUpsertResponseIdMappingsTypeItem[] IdMappings { get; set; }
    }

    public class CatalogUpsertResponseCatalogObjectType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public CatalogUpsertResponseCatalogObjectTypeItemDataType ItemData { get; set; }
    }

    public class CatalogUpsertResponseCatalogObjectTypeItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("variations")]
        public CatalogUpsertResponseCatalogObjectTypeItemDataTypeVariationsTypeItem[] Variations { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }
    }

    public class CatalogUpsertResponseCatalogObjectTypeItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogUpsertResponseCatalogObjectTypeItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogUpsertResponseCatalogObjectTypeItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("stockable")]
        public bool Stockable { get; set; }

        [JsonProperty("price_money")]
        public CatalogUpsertResponseCatalogObjectTypeItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class CatalogUpsertResponseCatalogObjectTypeItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogUpsertResponseIdMappingsTypeItem
    {
        [JsonProperty("client_object_id")]
        public string ClientObjectId { get; set; }

        [JsonProperty("object_id")]
        public string ObjectId { get; set; }
    }

    public class bodyObjectitemDatavariationsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("item_variation_data")]
        public bodyObjectitemDatavariationsInputItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class bodyObjectitemDatavariationsInputItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public bodyObjectitemDatavariationsInputItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class bodyObjectitemDatavariationsInputItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogRetrieveResponse
    {
        [JsonProperty("object")]
        public CatalogRetrieveResponseObjectEntityType ObjectEntity { get; set; }
    }

    public class CatalogRetrieveResponseObjectEntityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public CatalogRetrieveResponseObjectEntityTypeItemDataType ItemData { get; set; }
    }

    public class CatalogRetrieveResponseObjectEntityTypeItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("tax_ids")]
        public string[] TaxIds { get; set; }

        [JsonProperty("variations")]
        public CatalogRetrieveResponseObjectEntityTypeItemDataTypeVariationsTypeItem[] Variations { get; set; }
    }

    public class CatalogRetrieveResponseObjectEntityTypeItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogRetrieveResponseObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogRetrieveResponseObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public CatalogRetrieveResponseObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class CatalogRetrieveResponseObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogDeleteResponse
    {
        [JsonProperty("deleted_object_ids")]
        public string[] DeletedObjectIds { get; set; }

        [JsonProperty("deleted_at")]
        public string DeletedAt { get; set; }
    }

    public class CatalogSearchResponse
    {
        [JsonProperty("objects")]
        public CatalogSearchResponseObjectsTypeItem[] Objects { get; set; }
    }

    public class CatalogSearchResponseObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public CatalogSearchResponseObjectsTypeItemItemDataType ItemData { get; set; }
    }

    public class CatalogSearchResponseObjectsTypeItemItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("tax_ids")]
        public string[] TaxIds { get; set; }

        [JsonProperty("variations")]
        public CatalogSearchResponseObjectsTypeItemItemDataTypeVariationsTypeItem[] Variations { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class CatalogSearchResponseObjectsTypeItemItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogSearchResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogSearchResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ordinal")]
        public int Ordinal { get; set; }

        [JsonProperty("price_money")]
        public CatalogSearchResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }
    }

    public class CatalogSearchResponseObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogUpdateModifierResponse
    {
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CatalogUpdateTaxesResponse
    {
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomerGroupListResponse
    {
        [JsonProperty("groups")]
        public CustomerGroupListResponseGroupsTypeItem[] Groups { get; set; }
    }

    public class CustomerGroupListResponseGroupsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomGroupCreateResponse
    {
        [JsonProperty("group")]
        public CustomGroupCreateResponseGroupType Group { get; set; }
    }

    public class CustomGroupCreateResponseGroupType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomerGroupRetrieveResponse
    {
        [JsonProperty("group")]
        public CustomerGroupRetrieveResponseGroupType Group { get; set; }
    }

    public class CustomerGroupRetrieveResponseGroupType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomerGroupUpdateResponse
    {
        [JsonProperty("group")]
        public CustomerGroupUpdateResponseGroupType Group { get; set; }
    }

    public class CustomerGroupUpdateResponseGroupType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomerSegmentListResponse
    {
        [JsonProperty("segments")]
        public CustomerSegmentListResponseSegmentsTypeItem[] Segments { get; set; }
    }

    public class CustomerSegmentListResponseSegmentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomerSegmentRetrieveResponse
    {
        [JsonProperty("segment")]
        public CustomerSegmentRetrieveResponseSegmentType Segment { get; set; }
    }

    public class CustomerSegmentRetrieveResponseSegmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CustomerListResponse
    {
        [JsonProperty("customers")]
        public CustomerListResponseCustomersTypeItem[] Customers { get; set; }
    }

    public class CustomerListResponseCustomersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("address")]
        public CustomerListResponseCustomersTypeItemAddressType Address { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("preferences")]
        public CustomerListResponseCustomersTypeItemPreferencesType Preferences { get; set; }

        [JsonProperty("creation_source")]
        public string CreationSource { get; set; }

        [JsonProperty("group_ids")]
        public string[] GroupIds { get; set; }

        [JsonProperty("segment_ids")]
        public string[] SegmentIds { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CustomerListResponseCustomersTypeItemAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CustomerListResponseCustomersTypeItemPreferencesType
    {
        [JsonProperty("email_unsubscribed")]
        public bool EmailUnsubscribed { get; set; }
    }

    public enum sortFieldInput
    {
        DEFAULT,
        [EnumMember(Value = "CREATED_AT")]
        CREATEDAT
    }

    public class CustomerCreateResponse
    {
        [JsonProperty("customer")]
        public CustomerCreateResponseCustomerType Customer { get; set; }
    }

    public class CustomerCreateResponseCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("address")]
        public CustomerCreateResponseCustomerTypeAddressType Address { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("preferences")]
        public CustomerCreateResponseCustomerTypePreferencesType Preferences { get; set; }

        [JsonProperty("creation_source")]
        public string CreationSource { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CustomerCreateResponseCustomerTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CustomerCreateResponseCustomerTypePreferencesType
    {
        [JsonProperty("email_unsubscribed")]
        public bool EmailUnsubscribed { get; set; }
    }

    public class CustomerSearchResponse
    {
        [JsonProperty("customers")]
        public CustomerSearchResponseCustomersTypeItem[] Customers { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class CustomerSearchResponseCustomersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("address")]
        public CustomerSearchResponseCustomersTypeItemAddressType Address { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("preferences")]
        public CustomerSearchResponseCustomersTypeItemPreferencesType Preferences { get; set; }

        [JsonProperty("creation_source")]
        public string CreationSource { get; set; }

        [JsonProperty("group_ids")]
        public string[] GroupIds { get; set; }

        [JsonProperty("segment_ids")]
        public string[] SegmentIds { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class CustomerSearchResponseCustomersTypeItemAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CustomerSearchResponseCustomersTypeItemPreferencesType
    {
        [JsonProperty("email_unsubscribed")]
        public bool EmailUnsubscribed { get; set; }
    }

    public class CustomerRetrieveResponse
    {
        [JsonProperty("customer")]
        public CustomerRetrieveResponseCustomerType Customer { get; set; }
    }

    public class CustomerRetrieveResponseCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("address")]
        public CustomerRetrieveResponseCustomerTypeAddressType Address { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("preferences")]
        public CustomerRetrieveResponseCustomerTypePreferencesType Preferences { get; set; }

        [JsonProperty("creation_source")]
        public string CreationSource { get; set; }

        [JsonProperty("group_ids")]
        public string[] GroupIds { get; set; }

        [JsonProperty("segment_ids")]
        public string[] SegmentIds { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CustomerRetrieveResponseCustomerTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CustomerRetrieveResponseCustomerTypePreferencesType
    {
        [JsonProperty("email_unsubscribed")]
        public bool EmailUnsubscribed { get; set; }
    }

    public class CustomerUpdateResponse
    {
        [JsonProperty("customer")]
        public CustomerUpdateResponseCustomerType Customer { get; set; }
    }

    public class CustomerUpdateResponseCustomerType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("address")]
        public CustomerUpdateResponseCustomerTypeAddressType Address { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("preferences")]
        public CustomerUpdateResponseCustomerTypePreferencesType Preferences { get; set; }

        [JsonProperty("creation_source")]
        public string CreationSource { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class CustomerUpdateResponseCustomerTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CustomerUpdateResponseCustomerTypePreferencesType
    {
        [JsonProperty("email_unsubscribed")]
        public bool EmailUnsubscribed { get; set; }
    }

    public class DisputeListResponse
    {
        [JsonProperty("disputes")]
        public DisputeListResponseDisputesTypeItem[] Disputes { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class DisputeListResponseDisputesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public DisputeListResponseDisputesTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("disputed_payments")]
        public DisputeListResponseDisputesTypeItemDisputedPaymentsTypeItem[] DisputedPayments { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("brand_dispute_id")]
        public string BrandDisputeId { get; set; }
    }

    public class DisputeListResponseDisputesTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class DisputeListResponseDisputesTypeItemDisputedPaymentsTypeItem
    {
        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
    }

    public enum statesInput
    {
        [EnumMember(Value = "UNKNOWN_STATE")]
        UNKNOWNSTATE,
        [EnumMember(Value = "INQUIRY_EVIDENCE_REQUIRED")]
        INQUIRYEVIdENCEREQUIRED,
        [EnumMember(Value = "INQUIRY_PROCESSING")]
        INQUIRYPROCESSING,
        [EnumMember(Value = "INQUIRY_CLOSED")]
        INQUIRYCLOSED,
        [EnumMember(Value = "EVIDENCE_REQUIRED")]
        EVIdENCEREQUIRED,
        PROCESSING,
        WON,
        LOST,
        ACCEPTED,
        [EnumMember(Value = "WAITING_THIRD_PARTY")]
        WAITINGTHIRDPARTY
    }

    public class DisputeRetrieveResponse
    {
        [JsonProperty("dispute")]
        public DisputeRetrieveResponseDisputeType Dispute { get; set; }
    }

    public class DisputeRetrieveResponseDisputeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public DisputeRetrieveResponseDisputeTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("disputed_payments")]
        public DisputeRetrieveResponseDisputeTypeDisputedPaymentsTypeItem[] DisputedPayments { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("brand_dispute_id")]
        public string BrandDisputeId { get; set; }
    }

    public class DisputeRetrieveResponseDisputeTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class DisputeRetrieveResponseDisputeTypeDisputedPaymentsTypeItem
    {
        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
    }

    public class DisputeAcceptResponse
    {
        [JsonProperty("dispute")]
        public DisputeAcceptResponseDisputeType Dispute { get; set; }
    }

    public class DisputeAcceptResponseDisputeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public DisputeAcceptResponseDisputeTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("disputed_payments")]
        public DisputeAcceptResponseDisputeTypeDisputedPaymentsTypeItem[] DisputedPayments { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("brand_dispute_id")]
        public string BrandDisputeId { get; set; }
    }

    public class DisputeAcceptResponseDisputeTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class DisputeAcceptResponseDisputeTypeDisputedPaymentsTypeItem
    {
        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
    }

    public class DisputeListEvidenceResponse
    {
        [JsonProperty("evidence")]
        public DisputeListEvidenceResponseEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class DisputeListEvidenceResponseEvidenceTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dispute_id")]
        public string DisputeId { get; set; }

        [JsonProperty("evidence_text")]
        public string EvidenceText { get; set; }

        [JsonProperty("evidence_type")]
        public string EvidenceType { get; set; }

        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }

        [JsonProperty("evidence_id")]
        public string EvidenceId { get; set; }

        [JsonProperty("evidence_file")]
        public DisputeListEvidenceResponseEvidenceTypeItemEvidenceFileType EvidenceFile { get; set; }
    }

    public class DisputeListEvidenceResponseEvidenceTypeItemEvidenceFileType
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("filetype")]
        public string Filetype { get; set; }
    }

    public class DisputeCreateEvidenceTextResponse
    {
        [JsonProperty("evidence")]
        public DisputeCreateEvidenceTextResponseEvidenceType Evidence { get; set; }
    }

    public class DisputeCreateEvidenceTextResponseEvidenceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dispute_id")]
        public string DisputeId { get; set; }

        [JsonProperty("evidence_text")]
        public string EvidenceText { get; set; }

        [JsonProperty("evidence_type")]
        public string EvidenceType { get; set; }

        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }
    }

    public enum bodyevidenceTypeInput
    {
        [EnumMember(Value = "GENERIC_EVIDENCE")]
        GENERICEVIdENCE,
        [EnumMember(Value = "ONLINE_OR_APP_ACCESS_LOG")]
        ONLINEORAPPACCESSLOG,
        [EnumMember(Value = "AUTHORIZATION_DOCUMENTATION")]
        AUTHORIZATIONDOCUMENTATION,
        [EnumMember(Value = "CANCELLATION_OR_REFUND_DOCUMENTATION")]
        CANCELLATIONORREFUNDDOCUMENTATION,
        [EnumMember(Value = "CARDHOLDER_COMMUNICATION")]
        CARDHOLDERCOMMUNICATION,
        [EnumMember(Value = "CARDHOLDER_INFORMATION")]
        CARDHOLDERINFORMATION,
        [EnumMember(Value = "PURCHASE_ACKNOWLEDGEMENT")]
        PURCHASEACKNOWLEDGEMENT,
        [EnumMember(Value = "DUPLICATE_CHARGE_DOCUMENTATION")]
        DUPLICATECHARGEDOCUMENTATION,
        [EnumMember(Value = "PRODUCT_OR_SERVICE_DESCRIPTION")]
        PRODUCTORSERVICEDESCRIPTION,
        RECEIPT,
        [EnumMember(Value = "SERVICE_RECEIVED_DOCUMENTATION")]
        SERVICERECEIVEDDOCUMENTATION,
        [EnumMember(Value = "PROOF_OF_DELIVERY_DOCUMENTATION")]
        PROOFOFDELIVERYDOCUMENTATION,
        [EnumMember(Value = "RELATED_TRANSACTION_DOCUMENTATION")]
        RELATEDTRANSACTIONDOCUMENTATION,
        [EnumMember(Value = "REBUTTAL_EXPLANATION")]
        REBUTTALEXPLANATION,
        [EnumMember(Value = "TRACKING_NUMBER")]
        TRACKINGNUMBER
    }

    public class DisputeRetrieveEvidenceResponse
    {
        [JsonProperty("evidence")]
        public DisputeRetrieveEvidenceResponseEvidenceType Evidence { get; set; }
    }

    public class DisputeRetrieveEvidenceResponseEvidenceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dispute_id")]
        public string DisputeId { get; set; }

        [JsonProperty("evidence_file")]
        public DisputeRetrieveEvidenceResponseEvidenceTypeEvidenceFileType EvidenceFile { get; set; }

        [JsonProperty("evidence_type")]
        public string EvidenceType { get; set; }

        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }
    }

    public class DisputeRetrieveEvidenceResponseEvidenceTypeEvidenceFileType
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("filetype")]
        public string Filetype { get; set; }
    }

    public class EvidenceSubmitResponse
    {
        [JsonProperty("dispute")]
        public EvidenceSubmitResponseDisputeType Dispute { get; set; }
    }

    public class EvidenceSubmitResponseDisputeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public EvidenceSubmitResponseDisputeTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("due_at")]
        public string DueAt { get; set; }

        [JsonProperty("disputed_payments")]
        public EvidenceSubmitResponseDisputeTypeDisputedPaymentsTypeItem[] DisputedPayments { get; set; }

        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("brand_dispute_id")]
        public string BrandDisputeId { get; set; }
    }

    public class EvidenceSubmitResponseDisputeTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class EvidenceSubmitResponseDisputeTypeDisputedPaymentsTypeItem
    {
        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
    }

    public class InventoryRetrieveAdjustmentResponse
    {
        [JsonProperty("adjustment")]
        public InventoryRetrieveAdjustmentResponseAdjustmentType Adjustment { get; set; }
    }

    public class InventoryRetrieveAdjustmentResponseAdjustmentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("from_state")]
        public string FromState { get; set; }

        [JsonProperty("to_state")]
        public string ToState { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("total_price_money")]
        public InventoryRetrieveAdjustmentResponseAdjustmentTypeTotalPriceMoneyType TotalPriceMoney { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("source")]
        public InventoryRetrieveAdjustmentResponseAdjustmentTypeSourceType Source { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }
    }

    public class InventoryRetrieveAdjustmentResponseAdjustmentTypeTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InventoryRetrieveAdjustmentResponseAdjustmentTypeSourceType
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InventoryBatchChangeResponse
    {
        [JsonProperty("counts")]
        public InventoryBatchChangeResponseCountsTypeItem[] Counts { get; set; }
    }

    public class InventoryBatchChangeResponseCountsTypeItem
    {
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("calculated_at")]
        public string CalculatedAt { get; set; }
    }

    public class bodychangesInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("physical_count")]
        public bodychangesInputItemPhysicalCountType PhysicalCount { get; set; }
    }

    public class bodychangesInputItemPhysicalCountType
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }
    }

    public class InventoryBatchRetrieveChangesResponse
    {
        [JsonProperty("changes")]
        public InventoryBatchRetrieveChangesResponseChangesTypeItem[] Changes { get; set; }
    }

    public class InventoryBatchRetrieveChangesResponseChangesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("physical_count")]
        public InventoryBatchRetrieveChangesResponseChangesTypeItemPhysicalCountType PhysicalCount { get; set; }
    }

    public class InventoryBatchRetrieveChangesResponseChangesTypeItemPhysicalCountType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("source")]
        public InventoryBatchRetrieveChangesResponseChangesTypeItemPhysicalCountTypeSourceType Source { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class InventoryBatchRetrieveChangesResponseChangesTypeItemPhysicalCountTypeSourceType
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InventoryBatchRetrieveCountsResponse
    {
        [JsonProperty("counts")]
        public InventoryBatchRetrieveCountsResponseCountsTypeItem[] Counts { get; set; }
    }

    public class InventoryBatchRetrieveCountsResponseCountsTypeItem
    {
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("calculated_at")]
        public string CalculatedAt { get; set; }
    }

    public class InventoryRetrievePhysicalCountResponse
    {
        [JsonProperty("count")]
        public InventoryRetrievePhysicalCountResponseCountType Count { get; set; }
    }

    public class InventoryRetrievePhysicalCountResponseCountType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("source")]
        public InventoryRetrievePhysicalCountResponseCountTypeSourceType Source { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class InventoryRetrievePhysicalCountResponseCountTypeSourceType
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InventoryRetrieveTransferResponse
    {
        [JsonProperty("transfer")]
        public InventoryRetrieveTransferResponseTransferType Transfer { get; set; }
    }

    public class InventoryRetrieveTransferResponseTransferType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("from_location_id")]
        public string FromLocationId { get; set; }

        [JsonProperty("to_location_id")]
        public string ToLocationId { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("source")]
        public InventoryRetrieveTransferResponseTransferTypeSourceType Source { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class InventoryRetrieveTransferResponseTransferTypeSourceType
    {
        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InventoryRetrieveCountResponse
    {
        [JsonProperty("counts")]
        public InventoryRetrieveCountResponseCountsTypeItem[] Counts { get; set; }
    }

    public class InventoryRetrieveCountResponseCountsTypeItem
    {
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("catalog_object_type")]
        public string CatalogObjectType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("calculated_at")]
        public string CalculatedAt { get; set; }
    }

    public class InvoiceListResponse
    {
        [JsonProperty("invoices")]
        public InvoiceListResponseInvoicesTypeItem[] Invoices { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceListResponseInvoicesTypeItemPrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceListResponseInvoicesTypeItemAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceListResponseInvoicesTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }

        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("next_payment_amount_money")]
        public InvoiceListResponseInvoicesTypeItemNextPaymentAmountMoneyType NextPaymentAmountMoney { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("reminders")]
        public InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }

        [JsonProperty("percentage_requested")]
        public string PercentageRequested { get; set; }

        [JsonProperty("card_id")]
        public string CardId { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemPaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemPrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class InvoiceListResponseInvoicesTypeItemNextPaymentAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceCreateResponse
    {
        [JsonProperty("invoice")]
        public InvoiceCreateResponseInvoiceType Invoice { get; set; }
    }

    public class InvoiceCreateResponseInvoiceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceCreateResponseInvoiceTypePrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceCreateResponseInvoiceTypeAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceCreateResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("reminders")]
        public InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypePrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypeAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoiceCreateResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class bodyinvoicepaymentRequestsInputItem
    {
        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }

        [JsonProperty("reminders")]
        public bodyinvoicepaymentRequestsInputItemRemindersTypeItem[] Reminders { get; set; }
    }

    public class bodyinvoicepaymentRequestsInputItemRemindersTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }
    }

    public class bodyinvoicecustomFieldsInputItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class InvoiceSearchResponse
    {
        [JsonProperty("invoices")]
        public InvoiceSearchResponseInvoicesTypeItem[] Invoices { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceSearchResponseInvoicesTypeItemPrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceSearchResponseInvoicesTypeItemAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceSearchResponseInvoicesTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }

        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("next_payment_amount_money")]
        public InvoiceSearchResponseInvoicesTypeItemNextPaymentAmountMoneyType NextPaymentAmountMoney { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("reminders")]
        public InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }

        [JsonProperty("percentage_requested")]
        public string PercentageRequested { get; set; }

        [JsonProperty("card_id")]
        public string CardId { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemPaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemPrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class InvoiceSearchResponseInvoicesTypeItemNextPaymentAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceGetResponse
    {
        [JsonProperty("invoice")]
        public InvoiceGetResponseInvoiceType Invoice { get; set; }
    }

    public class InvoiceGetResponseInvoiceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceGetResponseInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceGetResponseInvoiceTypePrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceGetResponseInvoiceTypeAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceGetResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("reminders")]
        public InvoiceGetResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoiceGetResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoiceGetResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class InvoiceUpdateResponse
    {
        [JsonProperty("invoice")]
        public InvoiceUpdateResponseInvoiceType Invoice { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceUpdateResponseInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceUpdateResponseInvoiceTypePrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("next_payment_amount_money")]
        public InvoiceUpdateResponseInvoiceTypeNextPaymentAmountMoneyType NextPaymentAmountMoney { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceUpdateResponseInvoiceTypeAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceUpdateResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoiceUpdateResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoiceUpdateResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypePrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypeNextPaymentAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypeAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoiceUpdateResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class bodyinvoicepaymentRequestsInputItem2
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }
    }

    public class InvoiceCancelResponse
    {
        [JsonProperty("invoice")]
        public InvoiceCancelResponseInvoiceType Invoice { get; set; }
    }

    public class InvoiceCancelResponseInvoiceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceCancelResponseInvoiceTypePrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceCancelResponseInvoiceTypeAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceCancelResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("reminders")]
        public InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypePrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypeAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoiceCancelResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class InvoicePublishResponse
    {
        [JsonProperty("invoice")]
        public InvoicePublishResponseInvoiceType Invoice { get; set; }
    }

    public class InvoicePublishResponseInvoiceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("payment_requests")]
        public InvoicePublishResponseInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoicePublishResponseInvoiceTypePrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("public_url")]
        public string PublicUrl { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoicePublishResponseInvoiceTypeAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoicePublishResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool TippingEnabled { get; set; }

        [JsonProperty("reminders")]
        public InvoicePublishResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("computed_amount_money")]
        public InvoicePublishResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType ComputedAmountMoney { get; set; }

        [JsonProperty("total_completed_amount_money")]
        public InvoicePublishResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType TotalCompletedAmountMoney { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypePaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int RelativeScheduledDays { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypePaymentRequestsTypeItemComputedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypePaymentRequestsTypeItemTotalCompletedAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypePrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypeAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool BankAccount { get; set; }
    }

    public class InvoicePublishResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }
    }

    public class OrderCreateResponse
    {
        [JsonProperty("order")]
        public OrderCreateResponseOrderType Order { get; set; }
    }

    public class OrderCreateResponseOrderType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("line_items")]
        public OrderCreateResponseOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("taxes")]
        public OrderCreateResponseOrderTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("discounts")]
        public OrderCreateResponseOrderTypeDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("total_money")]
        public OrderCreateResponseOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderCreateResponseOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderCreateResponseOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_tip_money")]
        public OrderCreateResponseOrderTypeTotalTipMoneyType TotalTipMoney { get; set; }

        [JsonProperty("total_service_charge_money")]
        public OrderCreateResponseOrderTypeTotalServiceChargeMoneyType TotalServiceChargeMoney { get; set; }

        [JsonProperty("net_amounts")]
        public OrderCreateResponseOrderTypeNetAmountsType NetAmounts { get; set; }

        [JsonProperty("source")]
        public OrderCreateResponseOrderTypeSourceType Source { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("applied_taxes")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItem[] AppliedTaxes { get; set; }

        [JsonProperty("applied_discounts")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("gross_sales_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType GrossSalesMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("variation_total_price_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType VariationTotalPriceMoney { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("variation_name")]
        public string VariationName { get; set; }

        [JsonProperty("modifiers")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemModifiersTypeItem[] Modifiers { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("tax_uid")]
        public string TaxUid { get; set; }

        [JsonProperty("applied_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }

        [JsonProperty("applied_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemModifiersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemModifiersTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("total_price_money")]
        public OrderCreateResponseOrderTypeLineItemsTypeItemModifiersTypeItemTotalPriceMoneyType TotalPriceMoney { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemModifiersTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeLineItemsTypeItemModifiersTypeItemTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeTaxesTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applied_money")]
        public OrderCreateResponseOrderTypeTaxesTypeItemAppliedMoneyType AppliedMoney { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class OrderCreateResponseOrderTypeTaxesTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applied_money")]
        public OrderCreateResponseOrderTypeDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("amount_money")]
        public OrderCreateResponseOrderTypeDiscountsTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class OrderCreateResponseOrderTypeDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeDiscountsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeTotalTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeTotalServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeNetAmountsType
    {
        [JsonProperty("total_money")]
        public OrderCreateResponseOrderTypeNetAmountsTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("tax_money")]
        public OrderCreateResponseOrderTypeNetAmountsTypeTaxMoneyType TaxMoney { get; set; }

        [JsonProperty("discount_money")]
        public OrderCreateResponseOrderTypeNetAmountsTypeDiscountMoneyType DiscountMoney { get; set; }

        [JsonProperty("tip_money")]
        public OrderCreateResponseOrderTypeNetAmountsTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("service_charge_money")]
        public OrderCreateResponseOrderTypeNetAmountsTypeServiceChargeMoneyType ServiceChargeMoney { get; set; }
    }

    public class OrderCreateResponseOrderTypeNetAmountsTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeNetAmountsTypeTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeNetAmountsTypeDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeNetAmountsTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeNetAmountsTypeServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateResponseOrderTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyorderlineItemsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public bodyorderlineItemsInputItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("modifiers")]
        public bodyorderlineItemsInputItemModifiersTypeItem[] Modifiers { get; set; }

        [JsonProperty("applied_discounts")]
        public bodyorderlineItemsInputItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }
    }

    public class bodyorderlineItemsInputItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodyorderlineItemsInputItemModifiersTypeItem
    {
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }
    }

    public class bodyorderlineItemsInputItemAppliedDiscountsTypeItem
    {
        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }
    }

    public class bodyordertaxesInputItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class bodyorderdiscountsInputItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("amount_money")]
        public bodyorderdiscountsInputItemAmountMoneyType AmountMoney { get; set; }
    }

    public class bodyorderdiscountsInputItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderBatchRetrieveResponse
    {
        [JsonProperty("orders")]
        public OrderBatchRetrieveResponseOrdersTypeItem[] Orders { get; set; }
    }

    public class OrderBatchRetrieveResponseOrdersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("line_items")]
        public OrderBatchRetrieveResponseOrdersTypeItemLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("total_money")]
        public OrderBatchRetrieveResponseOrdersTypeItemTotalMoneyType TotalMoney { get; set; }
    }

    public class OrderBatchRetrieveResponseOrdersTypeItemLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public OrderBatchRetrieveResponseOrdersTypeItemLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderBatchRetrieveResponseOrdersTypeItemLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }
    }

    public class OrderBatchRetrieveResponseOrdersTypeItemLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderBatchRetrieveResponseOrdersTypeItemLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderBatchRetrieveResponseOrdersTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponse
    {
        [JsonProperty("order")]
        public OrderCalculateResponseOrderType Order { get; set; }
    }

    public class OrderCalculateResponseOrderType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("line_items")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("discounts")]
        public OrderCalculateResponseOrderTypeDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderCalculateResponseOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderCalculateResponseOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_tip_money")]
        public OrderCalculateResponseOrderTypeTotalTipMoneyType TotalTipMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderCalculateResponseOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("total_service_charge_money")]
        public OrderCalculateResponseOrderTypeTotalServiceChargeMoneyType TotalServiceChargeMoney { get; set; }

        [JsonProperty("net_amounts")]
        public OrderCalculateResponseOrderTypeNetAmountsType NetAmounts { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("gross_sales_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType GrossSalesMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("variation_total_price_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType VariationTotalPriceMoney { get; set; }

        [JsonProperty("applied_discounts")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }

        [JsonProperty("applied_money")]
        public OrderCalculateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class OrderCalculateResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applied_money")]
        public OrderCalculateResponseOrderTypeDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class OrderCalculateResponseOrderTypeDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeTotalTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeTotalServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeNetAmountsType
    {
        [JsonProperty("total_money")]
        public OrderCalculateResponseOrderTypeNetAmountsTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("tax_money")]
        public OrderCalculateResponseOrderTypeNetAmountsTypeTaxMoneyType TaxMoney { get; set; }

        [JsonProperty("discount_money")]
        public OrderCalculateResponseOrderTypeNetAmountsTypeDiscountMoneyType DiscountMoney { get; set; }

        [JsonProperty("tip_money")]
        public OrderCalculateResponseOrderTypeNetAmountsTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("service_charge_money")]
        public OrderCalculateResponseOrderTypeNetAmountsTypeServiceChargeMoneyType ServiceChargeMoney { get; set; }
    }

    public class OrderCalculateResponseOrderTypeNetAmountsTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeNetAmountsTypeTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeNetAmountsTypeDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeNetAmountsTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCalculateResponseOrderTypeNetAmountsTypeServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodyorderdiscountsInputItem2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class bodyorderlineItemsInputItem2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public bodyorderlineItemsInputItemBasePriceMoneyType BasePriceMoney { get; set; }
    }

    public class OrderCloneResponse
    {
        [JsonProperty("order")]
        public OrderCloneResponseOrderType Order { get; set; }
    }

    public class OrderCloneResponseOrderType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("line_items")]
        public OrderCloneResponseOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("taxes")]
        public OrderCloneResponseOrderTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("discounts")]
        public OrderCloneResponseOrderTypeDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("total_money")]
        public OrderCloneResponseOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderCloneResponseOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderCloneResponseOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_tip_money")]
        public OrderCloneResponseOrderTypeTotalTipMoneyType TotalTipMoney { get; set; }

        [JsonProperty("total_service_charge_money")]
        public OrderCloneResponseOrderTypeTotalServiceChargeMoneyType TotalServiceChargeMoney { get; set; }

        [JsonProperty("net_amounts")]
        public OrderCloneResponseOrderTypeNetAmountsType NetAmounts { get; set; }

        [JsonProperty("source")]
        public OrderCloneResponseOrderTypeSourceType Source { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("applied_taxes")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItem[] AppliedTaxes { get; set; }

        [JsonProperty("applied_discounts")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("gross_sales_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType GrossSalesMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("variation_total_price_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType VariationTotalPriceMoney { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("variation_name")]
        public string VariationName { get; set; }

        [JsonProperty("modifiers")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemModifiersTypeItem[] Modifiers { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("tax_uid")]
        public string TaxUid { get; set; }

        [JsonProperty("applied_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemAppliedTaxesTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }

        [JsonProperty("applied_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemModifiersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemModifiersTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("total_price_money")]
        public OrderCloneResponseOrderTypeLineItemsTypeItemModifiersTypeItemTotalPriceMoneyType TotalPriceMoney { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemModifiersTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeLineItemsTypeItemModifiersTypeItemTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeTaxesTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applied_money")]
        public OrderCloneResponseOrderTypeTaxesTypeItemAppliedMoneyType AppliedMoney { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class OrderCloneResponseOrderTypeTaxesTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applied_money")]
        public OrderCloneResponseOrderTypeDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("amount_money")]
        public OrderCloneResponseOrderTypeDiscountsTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class OrderCloneResponseOrderTypeDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeDiscountsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeTotalTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeTotalServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeNetAmountsType
    {
        [JsonProperty("total_money")]
        public OrderCloneResponseOrderTypeNetAmountsTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("tax_money")]
        public OrderCloneResponseOrderTypeNetAmountsTypeTaxMoneyType TaxMoney { get; set; }

        [JsonProperty("discount_money")]
        public OrderCloneResponseOrderTypeNetAmountsTypeDiscountMoneyType DiscountMoney { get; set; }

        [JsonProperty("tip_money")]
        public OrderCloneResponseOrderTypeNetAmountsTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("service_charge_money")]
        public OrderCloneResponseOrderTypeNetAmountsTypeServiceChargeMoneyType ServiceChargeMoney { get; set; }
    }

    public class OrderCloneResponseOrderTypeNetAmountsTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeNetAmountsTypeTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeNetAmountsTypeDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeNetAmountsTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeNetAmountsTypeServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCloneResponseOrderTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrderSearchResponse
    {
        [JsonProperty("order_entries")]
        public OrderSearchResponseOrderEntriesTypeItem[] OrderEntries { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class OrderSearchResponseOrderEntriesTypeItem
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class OrderRetrieveResponse
    {
        [JsonProperty("order")]
        public OrderRetrieveResponseOrderType Order { get; set; }
    }

    public class OrderRetrieveResponseOrderType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("line_items")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("discounts")]
        public OrderRetrieveResponseOrderTypeDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderRetrieveResponseOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderRetrieveResponseOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_tip_money")]
        public OrderRetrieveResponseOrderTypeTotalTipMoneyType TotalTipMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderRetrieveResponseOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("total_service_charge_money")]
        public OrderRetrieveResponseOrderTypeTotalServiceChargeMoneyType TotalServiceChargeMoney { get; set; }

        [JsonProperty("net_amounts")]
        public OrderRetrieveResponseOrderTypeNetAmountsType NetAmounts { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("gross_sales_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType GrossSalesMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("variation_total_price_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType VariationTotalPriceMoney { get; set; }

        [JsonProperty("applied_discounts")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }

        [JsonProperty("applied_money")]
        public OrderRetrieveResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("applied_money")]
        public OrderRetrieveResponseOrderTypeDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeTotalTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeTotalServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeNetAmountsType
    {
        [JsonProperty("total_money")]
        public OrderRetrieveResponseOrderTypeNetAmountsTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("tax_money")]
        public OrderRetrieveResponseOrderTypeNetAmountsTypeTaxMoneyType TaxMoney { get; set; }

        [JsonProperty("discount_money")]
        public OrderRetrieveResponseOrderTypeNetAmountsTypeDiscountMoneyType DiscountMoney { get; set; }

        [JsonProperty("tip_money")]
        public OrderRetrieveResponseOrderTypeNetAmountsTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("service_charge_money")]
        public OrderRetrieveResponseOrderTypeNetAmountsTypeServiceChargeMoneyType ServiceChargeMoney { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeNetAmountsTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeNetAmountsTypeTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeNetAmountsTypeDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeNetAmountsTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderRetrieveResponseOrderTypeNetAmountsTypeServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponse
    {
        [JsonProperty("order")]
        public OrderUpdateResponseOrderType Order { get; set; }
    }

    public class OrderUpdateResponseOrderType
    {
        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("total_money")]
        public OrderUpdateResponseOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("source")]
        public OrderUpdateResponseOrderTypeSourceType Source { get; set; }

        [JsonProperty("line_items")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("total_service_charge_money")]
        public OrderUpdateResponseOrderTypeTotalServiceChargeMoneyType TotalServiceChargeMoney { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderUpdateResponseOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderUpdateResponseOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("net_amounts")]
        public OrderUpdateResponseOrderTypeNetAmountsType NetAmounts { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class OrderUpdateResponseOrderTypeTotalMoneyType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class OrderUpdateResponseOrderTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItem
    {
        [JsonProperty("total_tax_money")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("gross_sales_money")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType GrossSalesMoney { get; set; }

        [JsonProperty("base_price_money")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("variation_total_price_money")]
        public OrderUpdateResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType VariationTotalPriceMoney { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class OrderUpdateResponseOrderTypeLineItemsTypeItemVariationTotalPriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeTotalServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeNetAmountsType
    {
        [JsonProperty("service_charge_money")]
        public OrderUpdateResponseOrderTypeNetAmountsTypeServiceChargeMoneyType ServiceChargeMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderUpdateResponseOrderTypeNetAmountsTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("discount_money")]
        public OrderUpdateResponseOrderTypeNetAmountsTypeDiscountMoneyType DiscountMoney { get; set; }

        [JsonProperty("tax_money")]
        public OrderUpdateResponseOrderTypeNetAmountsTypeTaxMoneyType TaxMoney { get; set; }
    }

    public class OrderUpdateResponseOrderTypeNetAmountsTypeServiceChargeMoneyType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class OrderUpdateResponseOrderTypeNetAmountsTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderUpdateResponseOrderTypeNetAmountsTypeDiscountMoneyType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class OrderUpdateResponseOrderTypeNetAmountsTypeTaxMoneyType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class bodyorderlineItemsInputItem22
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public bodyorderlineItemsInputItemBasePriceMoneyType BasePriceMoney { get; set; }
    }

    public class OrderPayResponse
    {
        [JsonProperty("order")]
        public OrderPayResponseOrderType Order { get; set; }
    }

    public class OrderPayResponseOrderType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("line_items")]
        public OrderPayResponseOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderPayResponseOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderPayResponseOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderPayResponseOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("tenders")]
        public OrderPayResponseOrderTypeTendersTypeItem[] Tenders { get; set; }

        [JsonProperty("total_service_charge_money")]
        public OrderPayResponseOrderTypeTotalServiceChargeMoneyType TotalServiceChargeMoney { get; set; }

        [JsonProperty("net_amounts")]
        public OrderPayResponseOrderTypeNetAmountsType NetAmounts { get; set; }

        [JsonProperty("source")]
        public OrderPayResponseOrderTypeSourceType Source { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class OrderPayResponseOrderTypeLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public OrderPayResponseOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("gross_sales_money")]
        public OrderPayResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType GrossSalesMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public OrderPayResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public OrderPayResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public OrderPayResponseOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }
    }

    public class OrderPayResponseOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeLineItemsTypeItemGrossSalesMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeTendersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("amount_money")]
        public OrderPayResponseOrderTypeTendersTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("card_details")]
        public OrderPayResponseOrderTypeTendersTypeItemCardDetailsType CardDetails { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
    }

    public class OrderPayResponseOrderTypeTendersTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeTendersTypeItemCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public OrderPayResponseOrderTypeTendersTypeItemCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }
    }

    public class OrderPayResponseOrderTypeTendersTypeItemCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }
    }

    public class OrderPayResponseOrderTypeTotalServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeNetAmountsType
    {
        [JsonProperty("total_money")]
        public OrderPayResponseOrderTypeNetAmountsTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("tax_money")]
        public OrderPayResponseOrderTypeNetAmountsTypeTaxMoneyType TaxMoney { get; set; }

        [JsonProperty("discount_money")]
        public OrderPayResponseOrderTypeNetAmountsTypeDiscountMoneyType DiscountMoney { get; set; }

        [JsonProperty("tip_money")]
        public OrderPayResponseOrderTypeNetAmountsTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("service_charge_money")]
        public OrderPayResponseOrderTypeNetAmountsTypeServiceChargeMoneyType ServiceChargeMoney { get; set; }
    }

    public class OrderPayResponseOrderTypeNetAmountsTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeNetAmountsTypeTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeNetAmountsTypeDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeNetAmountsTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeNetAmountsTypeServiceChargeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderPayResponseOrderTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PaymentListResponse
    {
        [JsonProperty("payments")]
        public PaymentListResponsePaymentsTypeItem[] Payments { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("amount_money")]
        public PaymentListResponsePaymentsTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("delay_duration")]
        public string DelayDuration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("card_details")]
        public PaymentListResponsePaymentsTypeItemCardDetailsType CardDetails { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("processing_fee")]
        public PaymentListResponsePaymentsTypeItemProcessingFeeTypeItem[] ProcessingFee { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("total_money")]
        public PaymentListResponsePaymentsTypeItemTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("approved_money")]
        public PaymentListResponsePaymentsTypeItemApprovedMoneyType ApprovedMoney { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty("delay_action")]
        public string DelayAction { get; set; }

        [JsonProperty("delayed_until")]
        public string DelayedUntil { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("application_details")]
        public PaymentListResponsePaymentsTypeItemApplicationDetailsType ApplicationDetails { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public PaymentListResponsePaymentsTypeItemCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }

        [JsonProperty("cvv_status")]
        public string CvvStatus { get; set; }

        [JsonProperty("avs_status")]
        public string AvsStatus { get; set; }

        [JsonProperty("auth_result_code")]
        public string AuthResultCode { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }

        [JsonProperty("card_payment_timeline")]
        public PaymentListResponsePaymentsTypeItemCardDetailsTypeCardPaymentTimelineType CardPaymentTimeline { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemCardDetailsTypeCardPaymentTimelineType
    {
        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("captured_at")]
        public string CapturedAt { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemProcessingFeeTypeItem
    {
        [JsonProperty("effective_at")]
        public string EffectiveAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount_money")]
        public PaymentListResponsePaymentsTypeItemProcessingFeeTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemProcessingFeeTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemApprovedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentListResponsePaymentsTypeItemApplicationDetailsType
    {
        [JsonProperty("square_product")]
        public string SquareProduct { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }

    public class PaymentCreateResponse
    {
        [JsonProperty("payment")]
        public PaymentCreateResponsePaymentType Payment { get; set; }
    }

    public class PaymentCreateResponsePaymentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("amount_money")]
        public PaymentCreateResponsePaymentTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("app_fee_money")]
        public PaymentCreateResponsePaymentTypeAppFeeMoneyType AppFeeMoney { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("delay_duration")]
        public string DelayDuration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("card_details")]
        public PaymentCreateResponsePaymentTypeCardDetailsType CardDetails { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("risk_evaluation")]
        public PaymentCreateResponsePaymentTypeRiskEvaluationType RiskEvaluation { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("total_money")]
        public PaymentCreateResponsePaymentTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("approved_money")]
        public PaymentCreateResponsePaymentTypeApprovedMoneyType ApprovedMoney { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty("delay_action")]
        public string DelayAction { get; set; }

        [JsonProperty("delayed_until")]
        public string DelayedUntil { get; set; }

        [JsonProperty("application_details")]
        public PaymentCreateResponsePaymentTypeApplicationDetailsType ApplicationDetails { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeAppFeeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public PaymentCreateResponsePaymentTypeCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }

        [JsonProperty("cvv_status")]
        public string CvvStatus { get; set; }

        [JsonProperty("avs_status")]
        public string AvsStatus { get; set; }

        [JsonProperty("auth_result_code")]
        public string AuthResultCode { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }

        [JsonProperty("card_payment_timeline")]
        public PaymentCreateResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType CardPaymentTimeline { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType
    {
        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("captured_at")]
        public string CapturedAt { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeRiskEvaluationType
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeApprovedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCreateResponsePaymentTypeApplicationDetailsType
    {
        [JsonProperty("square_product")]
        public string SquareProduct { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }

    public class PaymentGetResponse
    {
        [JsonProperty("payment")]
        public PaymentGetResponsePaymentType Payment { get; set; }
    }

    public class PaymentGetResponsePaymentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("amount_money")]
        public PaymentGetResponsePaymentTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("delay_duration")]
        public string DelayDuration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("card_details")]
        public PaymentGetResponsePaymentTypeCardDetailsType CardDetails { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("processing_fee")]
        public PaymentGetResponsePaymentTypeProcessingFeeTypeItem[] ProcessingFee { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("total_money")]
        public PaymentGetResponsePaymentTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("approved_money")]
        public PaymentGetResponsePaymentTypeApprovedMoneyType ApprovedMoney { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty("delay_action")]
        public string DelayAction { get; set; }

        [JsonProperty("delayed_until")]
        public string DelayedUntil { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("application_details")]
        public PaymentGetResponsePaymentTypeApplicationDetailsType ApplicationDetails { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentGetResponsePaymentTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentGetResponsePaymentTypeCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public PaymentGetResponsePaymentTypeCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }

        [JsonProperty("cvv_status")]
        public string CvvStatus { get; set; }

        [JsonProperty("avs_status")]
        public string AvsStatus { get; set; }

        [JsonProperty("auth_result_code")]
        public string AuthResultCode { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }

        [JsonProperty("card_payment_timeline")]
        public PaymentGetResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType CardPaymentTimeline { get; set; }
    }

    public class PaymentGetResponsePaymentTypeCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class PaymentGetResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType
    {
        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("captured_at")]
        public string CapturedAt { get; set; }
    }

    public class PaymentGetResponsePaymentTypeProcessingFeeTypeItem
    {
        [JsonProperty("effective_at")]
        public string EffectiveAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount_money")]
        public PaymentGetResponsePaymentTypeProcessingFeeTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class PaymentGetResponsePaymentTypeProcessingFeeTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentGetResponsePaymentTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentGetResponsePaymentTypeApprovedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentGetResponsePaymentTypeApplicationDetailsType
    {
        [JsonProperty("square_product")]
        public string SquareProduct { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }

    public class PaymentUpdateResponse
    {
        [JsonProperty("payment")]
        public PaymentUpdateResponsePaymentType Payment { get; set; }
    }

    public class PaymentUpdateResponsePaymentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("amount_money")]
        public PaymentUpdateResponsePaymentTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("tip_money")]
        public PaymentUpdateResponsePaymentTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("delay_duration")]
        public string DelayDuration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("card_details")]
        public PaymentUpdateResponsePaymentTypeCardDetailsType CardDetails { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("risk_evaluation")]
        public PaymentUpdateResponsePaymentTypeRiskEvaluationType RiskEvaluation { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("total_money")]
        public PaymentUpdateResponsePaymentTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("approved_money")]
        public PaymentUpdateResponsePaymentTypeApprovedMoneyType ApprovedMoney { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("delay_action")]
        public string DelayAction { get; set; }

        [JsonProperty("delayed_until")]
        public string DelayedUntil { get; set; }

        [JsonProperty("application_details")]
        public PaymentUpdateResponsePaymentTypeApplicationDetailsType ApplicationDetails { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public PaymentUpdateResponsePaymentTypeCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }

        [JsonProperty("cvv_status")]
        public string CvvStatus { get; set; }

        [JsonProperty("avs_status")]
        public string AvsStatus { get; set; }

        [JsonProperty("auth_result_code")]
        public string AuthResultCode { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }

        [JsonProperty("card_payment_timeline")]
        public PaymentUpdateResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType CardPaymentTimeline { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType
    {
        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeRiskEvaluationType
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeApprovedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentUpdateResponsePaymentTypeApplicationDetailsType
    {
        [JsonProperty("square_product")]
        public string SquareProduct { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }

    public class PaymentCancelResponse
    {
        [JsonProperty("payment")]
        public PaymentCancelResponsePaymentType Payment { get; set; }
    }

    public class PaymentCancelResponsePaymentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("amount_money")]
        public PaymentCancelResponsePaymentTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("tip_money")]
        public PaymentCancelResponsePaymentTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("delay_duration")]
        public string DelayDuration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("card_details")]
        public PaymentCancelResponsePaymentTypeCardDetailsType CardDetails { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("risk_evaluation")]
        public PaymentCancelResponsePaymentTypeRiskEvaluationType RiskEvaluation { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("total_money")]
        public PaymentCancelResponsePaymentTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("approved_money")]
        public PaymentCancelResponsePaymentTypeApprovedMoneyType ApprovedMoney { get; set; }

        [JsonProperty("delay_action")]
        public string DelayAction { get; set; }

        [JsonProperty("delayed_until")]
        public string DelayedUntil { get; set; }

        [JsonProperty("application_details")]
        public PaymentCancelResponsePaymentTypeApplicationDetailsType ApplicationDetails { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public PaymentCancelResponsePaymentTypeCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }

        [JsonProperty("cvv_status")]
        public string CvvStatus { get; set; }

        [JsonProperty("avs_status")]
        public string AvsStatus { get; set; }

        [JsonProperty("auth_result_code")]
        public string AuthResultCode { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }

        [JsonProperty("card_payment_timeline")]
        public PaymentCancelResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType CardPaymentTimeline { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType
    {
        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("voided_at")]
        public string VoidedAt { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeRiskEvaluationType
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeApprovedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCancelResponsePaymentTypeApplicationDetailsType
    {
        [JsonProperty("square_product")]
        public string SquareProduct { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }

    public class PaymentCompleteResponse
    {
        [JsonProperty("payment")]
        public PaymentCompleteResponsePaymentType Payment { get; set; }
    }

    public class PaymentCompleteResponsePaymentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("amount_money")]
        public PaymentCompleteResponsePaymentTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("delay_duration")]
        public string DelayDuration { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }

        [JsonProperty("card_details")]
        public PaymentCompleteResponsePaymentTypeCardDetailsType CardDetails { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("processing_fee")]
        public PaymentCompleteResponsePaymentTypeProcessingFeeTypeItem[] ProcessingFee { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("total_money")]
        public PaymentCompleteResponsePaymentTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("approved_money")]
        public PaymentCompleteResponsePaymentTypeApprovedMoneyType ApprovedMoney { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("receipt_number")]
        public string ReceiptNumber { get; set; }

        [JsonProperty("receipt_url")]
        public string ReceiptUrl { get; set; }

        [JsonProperty("delay_action")]
        public string DelayAction { get; set; }

        [JsonProperty("delayed_until")]
        public string DelayedUntil { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("application_details")]
        public PaymentCompleteResponsePaymentTypeApplicationDetailsType ApplicationDetails { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeCardDetailsType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("card")]
        public PaymentCompleteResponsePaymentTypeCardDetailsTypeCardType Card { get; set; }

        [JsonProperty("entry_method")]
        public string EntryMethod { get; set; }

        [JsonProperty("cvv_status")]
        public string CvvStatus { get; set; }

        [JsonProperty("avs_status")]
        public string AvsStatus { get; set; }

        [JsonProperty("auth_result_code")]
        public string AuthResultCode { get; set; }

        [JsonProperty("statement_description")]
        public string StatementDescription { get; set; }

        [JsonProperty("card_payment_timeline")]
        public PaymentCompleteResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType CardPaymentTimeline { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeCardDetailsTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("prepaid_type")]
        public string PrepaidType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeCardDetailsTypeCardPaymentTimelineType
    {
        [JsonProperty("authorized_at")]
        public string AuthorizedAt { get; set; }

        [JsonProperty("captured_at")]
        public string CapturedAt { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeProcessingFeeTypeItem
    {
        [JsonProperty("effective_at")]
        public string EffectiveAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount_money")]
        public PaymentCompleteResponsePaymentTypeProcessingFeeTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeProcessingFeeTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeApprovedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCompleteResponsePaymentTypeApplicationDetailsType
    {
        [JsonProperty("square_product")]
        public string SquareProduct { get; set; }

        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }
    }

    public class RefundListResponse
    {
        [JsonProperty("refunds")]
        public RefundListResponseRefundsTypeItem[] Refunds { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class RefundListResponseRefundsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount_money")]
        public RefundListResponseRefundsTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processing_fee")]
        public RefundListResponseRefundsTypeItemProcessingFeeTypeItem[] ProcessingFee { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class RefundListResponseRefundsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RefundListResponseRefundsTypeItemProcessingFeeTypeItem
    {
        [JsonProperty("effective_at")]
        public string EffectiveAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount_money")]
        public RefundListResponseRefundsTypeItemProcessingFeeTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class RefundListResponseRefundsTypeItemProcessingFeeTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RefundPaymentResponse
    {
        [JsonProperty("refund")]
        public RefundPaymentResponseRefundType Refund { get; set; }
    }

    public class RefundPaymentResponseRefundType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount_money")]
        public RefundPaymentResponseRefundTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_fee_money")]
        public RefundPaymentResponseRefundTypeAppFeeMoneyType AppFeeMoney { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class RefundPaymentResponseRefundTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RefundPaymentResponseRefundTypeAppFeeMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RefundGetResponse
    {
        [JsonProperty("refund")]
        public RefundGetResponseRefundType Refund { get; set; }
    }

    public class RefundGetResponseRefundType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("amount_money")]
        public RefundGetResponseRefundTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processing_fee")]
        public RefundGetResponseRefundTypeProcessingFeeTypeItem[] ProcessingFee { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class RefundGetResponseRefundTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RefundGetResponseRefundTypeProcessingFeeTypeItem
    {
        [JsonProperty("effective_at")]
        public string EffectiveAt { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount_money")]
        public RefundGetResponseRefundTypeProcessingFeeTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class RefundGetResponseRefundTypeProcessingFeeTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionCreateResponse
    {
        [JsonProperty("subscription")]
        public SubscriptionCreateResponseSubscriptionType Subscription { get; set; }
    }

    public class SubscriptionCreateResponseSubscriptionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tax_percentage")]
        public string TaxPercentage { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionCreateResponseSubscriptionTypePriceOverrideMoneyType PriceOverrideMoney { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("card_id")]
        public string CardId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionCreateResponseSubscriptionTypeSourceType Source { get; set; }
    }

    public class SubscriptionCreateResponseSubscriptionTypePriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionCreateResponseSubscriptionTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubscriptionSearchResponse
    {
        [JsonProperty("subscriptions")]
        public SubscriptionSearchResponseSubscriptionsTypeItem[] Subscriptions { get; set; }
    }

    public class SubscriptionSearchResponseSubscriptionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("canceled_date")]
        public string CanceledDate { get; set; }

        [JsonProperty("charged_through_date")]
        public string ChargedThroughDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("card_id")]
        public string CardId { get; set; }

        [JsonProperty("paid_until_date")]
        public string PaidUntilDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionSearchResponseSubscriptionsTypeItemSourceType Source { get; set; }

        [JsonProperty("tax_percentage")]
        public string TaxPercentage { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionSearchResponseSubscriptionsTypeItemPriceOverrideMoneyType PriceOverrideMoney { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("invoice_ids")]
        public string[] InvoiceIds { get; set; }
    }

    public class SubscriptionSearchResponseSubscriptionsTypeItemSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubscriptionSearchResponseSubscriptionsTypeItemPriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionRetrieveResponse
    {
        [JsonProperty("subscription")]
        public SubscriptionRetrieveResponseSubscriptionType Subscription { get; set; }
    }

    public class SubscriptionRetrieveResponseSubscriptionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("charged_through_date")]
        public string ChargedThroughDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("invoice_ids")]
        public string[] InvoiceIds { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionRetrieveResponseSubscriptionTypePriceOverrideMoneyType PriceOverrideMoney { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("paid_until_date")]
        public string PaidUntilDate { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionRetrieveResponseSubscriptionTypeSourceType Source { get; set; }
    }

    public class SubscriptionRetrieveResponseSubscriptionTypePriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionRetrieveResponseSubscriptionTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubscriptionUpdateResponse
    {
        [JsonProperty("subscription")]
        public SubscriptionUpdateResponseSubscriptionType Subscription { get; set; }
    }

    public class SubscriptionUpdateResponseSubscriptionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionUpdateResponseSubscriptionTypePriceOverrideMoneyType PriceOverrideMoney { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionUpdateResponseSubscriptionTypeSourceType Source { get; set; }
    }

    public class SubscriptionUpdateResponseSubscriptionTypePriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionUpdateResponseSubscriptionTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubscriptionCancelResponse
    {
        [JsonProperty("subscription")]
        public SubscriptionCancelResponseSubscriptionType Subscription { get; set; }
    }

    public class SubscriptionCancelResponseSubscriptionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("card_id")]
        public string CardId { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("canceled_date")]
        public string CanceledDate { get; set; }

        [JsonProperty("paid_until_date")]
        public string PaidUntilDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionCancelResponseSubscriptionTypeSourceType Source { get; set; }
    }

    public class SubscriptionCancelResponseSubscriptionTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubscriptionListEventsResponse
    {
        [JsonProperty("subscription_events")]
        public SubscriptionListEventsResponseSubscriptionEventsTypeItem[] SubscriptionEvents { get; set; }
    }

    public class SubscriptionListEventsResponseSubscriptionEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subscription_event_type")]
        public string SubscriptionEventType { get; set; }

        [JsonProperty("effective_date")]
        public string EffectiveDate { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }
    }

    public class SubscriptionResumeResponse
    {
        [JsonProperty("subscription")]
        public SubscriptionResumeResponseSubscriptionType Subscription { get; set; }
    }

    public class SubscriptionResumeResponseSubscriptionType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("plan_id")]
        public string PlanId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionResumeResponseSubscriptionTypePriceOverrideMoneyType PriceOverrideMoney { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionResumeResponseSubscriptionTypeSourceType Source { get; set; }
    }

    public class SubscriptionResumeResponseSubscriptionTypePriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionResumeResponseSubscriptionTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class TerminalCreateCheckoutResponse
    {
        [JsonProperty("checkout")]
        public TerminalCreateCheckoutResponseCheckoutType Checkout { get; set; }
    }

    public class TerminalCreateCheckoutResponseCheckoutType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public TerminalCreateCheckoutResponseCheckoutTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("device_options")]
        public TerminalCreateCheckoutResponseCheckoutTypeDeviceOptionsType DeviceOptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }

        [JsonProperty("payment_type")]
        public string PaymentType { get; set; }
    }

    public class TerminalCreateCheckoutResponseCheckoutTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalCreateCheckoutResponseCheckoutTypeDeviceOptionsType
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("tip_settings")]
        public TerminalCreateCheckoutResponseCheckoutTypeDeviceOptionsTypeTipSettingsType TipSettings { get; set; }

        [JsonProperty("skip_receipt_screen")]
        public bool SkipReceiptScreen { get; set; }
    }

    public class TerminalCreateCheckoutResponseCheckoutTypeDeviceOptionsTypeTipSettingsType
    {
        [JsonProperty("allow_tipping")]
        public bool AllowTipping { get; set; }
    }

    public class TerminalSearchCheckoutsResponse
    {
        [JsonProperty("checkouts")]
        public TerminalSearchCheckoutsResponseCheckoutsTypeItem[] Checkouts { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class TerminalSearchCheckoutsResponseCheckoutsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public TerminalSearchCheckoutsResponseCheckoutsTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("device_options")]
        public TerminalSearchCheckoutsResponseCheckoutsTypeItemDeviceOptionsType DeviceOptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_ids")]
        public string[] PaymentIds { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }
    }

    public class TerminalSearchCheckoutsResponseCheckoutsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalSearchCheckoutsResponseCheckoutsTypeItemDeviceOptionsType
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("tip_settings")]
        public TerminalSearchCheckoutsResponseCheckoutsTypeItemDeviceOptionsTypeTipSettingsType TipSettings { get; set; }

        [JsonProperty("skip_receipt_screen")]
        public bool SkipReceiptScreen { get; set; }
    }

    public class TerminalSearchCheckoutsResponseCheckoutsTypeItemDeviceOptionsTypeTipSettingsType
    {
        [JsonProperty("allow_tipping")]
        public bool AllowTipping { get; set; }
    }

    public class TerminalGetCheckoutResponse
    {
        [JsonProperty("checkout")]
        public TerminalGetCheckoutResponseCheckoutType Checkout { get; set; }
    }

    public class TerminalGetCheckoutResponseCheckoutType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public TerminalGetCheckoutResponseCheckoutTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("device_options")]
        public TerminalGetCheckoutResponseCheckoutTypeDeviceOptionsType DeviceOptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }
    }

    public class TerminalGetCheckoutResponseCheckoutTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalGetCheckoutResponseCheckoutTypeDeviceOptionsType
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("tip_settings")]
        public TerminalGetCheckoutResponseCheckoutTypeDeviceOptionsTypeTipSettingsType TipSettings { get; set; }

        [JsonProperty("skip_receipt_screen")]
        public bool SkipReceiptScreen { get; set; }
    }

    public class TerminalGetCheckoutResponseCheckoutTypeDeviceOptionsTypeTipSettingsType
    {
        [JsonProperty("allow_tipping")]
        public bool AllowTipping { get; set; }
    }

    public class TerminalCancelCheckoutResponse
    {
        [JsonProperty("checkout")]
        public TerminalCancelCheckoutResponseCheckoutType Checkout { get; set; }
    }

    public class TerminalCancelCheckoutResponseCheckoutType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount_money")]
        public TerminalCancelCheckoutResponseCheckoutTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("device_options")]
        public TerminalCancelCheckoutResponseCheckoutTypeDeviceOptionsType DeviceOptions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }
    }

    public class TerminalCancelCheckoutResponseCheckoutTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalCancelCheckoutResponseCheckoutTypeDeviceOptionsType
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("tip_settings")]
        public TerminalCancelCheckoutResponseCheckoutTypeDeviceOptionsTypeTipSettingsType TipSettings { get; set; }

        [JsonProperty("skip_receipt_screen")]
        public bool SkipReceiptScreen { get; set; }
    }

    public class TerminalCancelCheckoutResponseCheckoutTypeDeviceOptionsTypeTipSettingsType
    {
        [JsonProperty("allow_tipping")]
        public bool AllowTipping { get; set; }
    }

    public class TerminalCreateRefundResponse
    {
        [JsonProperty("refund")]
        public TerminalCreateRefundResponseRefundType Refund { get; set; }
    }

    public class TerminalCreateRefundResponseRefundType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("amount_money")]
        public TerminalCreateRefundResponseRefundTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("card")]
        public TerminalCreateRefundResponseRefundTypeCardType Card { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }
    }

    public class TerminalCreateRefundResponseRefundTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalCreateRefundResponseRefundTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class TerminalSearchRefundsResponse
    {
        [JsonProperty("refunds")]
        public TerminalSearchRefundsResponseRefundsTypeItem[] Refunds { get; set; }
    }

    public class TerminalSearchRefundsResponseRefundsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("refund_id")]
        public string RefundId { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("amount_money")]
        public TerminalSearchRefundsResponseRefundsTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("card")]
        public TerminalSearchRefundsResponseRefundsTypeItemCardType Card { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }
    }

    public class TerminalSearchRefundsResponseRefundsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalSearchRefundsResponseRefundsTypeItemCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class TerminalGetRefundResponse
    {
        [JsonProperty("refund")]
        public TerminalGetRefundResponseRefundType Refund { get; set; }
    }

    public class TerminalGetRefundResponseRefundType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("refund_id")]
        public string RefundId { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("amount_money")]
        public TerminalGetRefundResponseRefundTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("card")]
        public TerminalGetRefundResponseRefundTypeCardType Card { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }
    }

    public class TerminalGetRefundResponseRefundTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalGetRefundResponseRefundTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }

    public class TerminalCancelRefundResponse
    {
        [JsonProperty("refund")]
        public TerminalCancelRefundResponseRefundType Refund { get; set; }
    }

    public class TerminalCancelRefundResponseRefundType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("amount_money")]
        public TerminalCancelRefundResponseRefundTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("deadline_duration")]
        public string DeadlineDuration { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("app_id")]
        public string AppId { get; set; }

        [JsonProperty("card")]
        public TerminalCancelRefundResponseRefundTypeCardType Card { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }
    }

    public class TerminalCancelRefundResponseRefundTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalCancelRefundResponseRefundTypeCardType
    {
        [JsonProperty("card_brand")]
        public string CardBrand { get; set; }

        [JsonProperty("last_4")]
        public string Last4 { get; set; }

        [JsonProperty("exp_month")]
        public int ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public int ExpYear { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("card_type")]
        public string CardType { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Squarepaymentsip;

    public partial class WorkflowManagedActions
    {
        public SquarepaymentsipActions Squarepaymentsip(string connectionId) => new SquarepaymentsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SquarepaymentsipTriggers Squarepaymentsip(string connectionId) => new SquarepaymentsipTriggers(connectionId);
    }
}