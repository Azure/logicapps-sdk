//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Squarepaymentsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SquarepaymentsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<ApplePayRegisterResponse, ApiConnectionActionConfiguration> ApplePayRegister(Expression<Func<ApplePayRegisterInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ApplePayRegisterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/apple-pay/domains";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApplePayRegisterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardListResponse, ApiConnectionActionConfiguration> CardList(Expression<Func<string>> cursor = null, Expression<Func<string>> customerId = null, Expression<Func<bool>> includeDisabled = null, Expression<Func<string>> referenceId = null, Expression<Func<sortOrderInput>> sortOrder = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: false);
            var __workflow_includeDisabled = WorkflowExpression.Compile(includeDisabled, nameof(includeDisabled), required: false);
            var __workflow_referenceId = WorkflowExpression.Compile(referenceId, nameof(referenceId), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<CardListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_customerId != null)
                    callPayload.Queries["customer_id"] = ExpressionConverter.Convert(__workflow_customerId);
                if (__workflow_includeDisabled != null)
                    callPayload.Queries["include_disabled"] = ExpressionConverter.Convert(__workflow_includeDisabled);
                if (__workflow_referenceId != null)
                    callPayload.Queries["reference_id"] = ExpressionConverter.Convert(__workflow_referenceId);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<CardListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardCreateResponse, ApiConnectionActionConfiguration> CardCreate(Expression<Func<CardCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CardCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CardCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardRetrieveResponse, ApiConnectionActionConfiguration> CardRetrieve(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CardDisableResponse, ApiConnectionActionConfiguration> CardDisable(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<CardDisableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cards/{0}/disable", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardDisableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogBatchDeleteResponse, ApiConnectionActionConfiguration> CatalogBatchDelete(Expression<Func<CatalogBatchDeleteInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CatalogBatchDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/batch-delete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogBatchDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogBatchRetrieveResponse, ApiConnectionActionConfiguration> CatalogBatchRetrieve(Expression<Func<CatalogBatchRetrieveInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CatalogBatchRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogBatchRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogBatchUpsertResponse, ApiConnectionActionConfiguration> CatalogBatchUpsert(Expression<Func<CatalogBatchUpsertInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CatalogBatchUpsertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/batch-upsert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogBatchUpsertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogInfoResponse, ApiConnectionActionConfiguration> CatalogInfo()
        {
            return new DeferredBodyAction<CatalogInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CatalogInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogListResponse, ApiConnectionActionConfiguration> CatalogList(Expression<Func<int>> cursor = null, Expression<Func<string>> types = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_types = WorkflowExpression.Compile(types, nameof(types), required: false);
            return new DeferredBodyAction<CatalogListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_types != null)
                    callPayload.Queries["types"] = ExpressionConverter.Convert(__workflow_types);
                return new ApiConnectionAction<CatalogListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogUpsertResponse, ApiConnectionActionConfiguration> CatalogUpsert(Expression<Func<CatalogUpsertInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CatalogUpsertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/object";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogUpsertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogRetrieveResponse, ApiConnectionActionConfiguration> CatalogRetrieve(Expression<Func<string>> objectId, Expression<Func<bool>> includeRelatedObjects = null)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            var __workflow_includeRelatedObjects = WorkflowExpression.Compile(includeRelatedObjects, nameof(includeRelatedObjects), required: false);
            return new DeferredBodyAction<CatalogRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/catalog/object/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeRelatedObjects != null)
                    callPayload.Queries["include_related_objects"] = ExpressionConverter.Convert(__workflow_includeRelatedObjects);
                return new ApiConnectionAction<CatalogRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogDeleteResponse, ApiConnectionActionConfiguration> CatalogDelete(Expression<Func<string>> objectId)
        {
            var __workflow_objectId = WorkflowExpression.Compile(objectId, nameof(objectId), required: true);
            return new DeferredBodyAction<CatalogDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/catalog/object/{0}", __workflow_objectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CatalogDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogSearchResponse, ApiConnectionActionConfiguration> CatalogSearch(Expression<Func<CatalogSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CatalogSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogUpdateModifierResponse, ApiConnectionActionConfiguration> CatalogUpdateModifier(Expression<Func<CatalogUpdateModifierInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CatalogUpdateModifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/update-item-modifier-lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogUpdateModifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CatalogUpdateTaxesResponse, ApiConnectionActionConfiguration> CatalogUpdateTaxes(Expression<Func<CatalogUpdateTaxesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CatalogUpdateTaxesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/catalog/update-item-taxes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CatalogUpdateTaxesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerGroupListResponse, ApiConnectionActionConfiguration> CustomerGroupList()
        {
            return new DeferredBodyAction<CustomerGroupListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customers/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerGroupListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomGroupCreateResponse, ApiConnectionActionConfiguration> CustomGroupCreate(Expression<Func<CustomGroupCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomGroupCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customers/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomGroupCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerGroupRetrieveResponse, ApiConnectionActionConfiguration> CustomerGroupRetrieve(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<CustomerGroupRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerGroupRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CustomerGroupDelete(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerGroupUpdateResponse, ApiConnectionActionConfiguration> CustomerGroupUpdate(Expression<Func<string>> groupId, Expression<Func<CustomerGroupUpdateInput>> body = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CustomerGroupUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerGroupUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerSegmentListResponse, ApiConnectionActionConfiguration> CustomerSegmentList(Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<CustomerSegmentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customers/segments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<CustomerSegmentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerSegmentRetrieveResponse, ApiConnectionActionConfiguration> CustomerSegmentRetrieve(Expression<Func<string>> segmentId)
        {
            var __workflow_segmentId = WorkflowExpression.Compile(segmentId, nameof(segmentId), required: true);
            return new DeferredBodyAction<CustomerSegmentRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/segments/{0}", __workflow_segmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerSegmentRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerListResponse, ApiConnectionActionConfiguration> CustomerList(Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<sortFieldInput>> sortField = null, Expression<Func<sortOrderInput>> sortOrder = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sortField = WorkflowExpression.Compile(sortField, nameof(sortField), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<CustomerListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["sort_field"] = Convert.ToString("DEFAULT");
                if (__workflow_sortField != null)
                    callPayload.Queries["sort_field"] = ExpressionConverter.Convert(__workflow_sortField);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<CustomerListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerCreateResponse, ApiConnectionActionConfiguration> CustomerCreate(Expression<Func<CustomerCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CustomerCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerSearchResponse, ApiConnectionActionConfiguration> CustomerSearch(Expression<Func<CustomerSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CustomerSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/customers/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CustomerSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerRetrieveResponse, ApiConnectionActionConfiguration> CustomerRetrieve(Expression<Func<string>> customerId)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            return new DeferredBodyAction<CustomerRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/{0}", __workflow_customerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CustomerDelete(Expression<Func<string>> customerId)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/{0}", __workflow_customerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<CustomerUpdateResponse, ApiConnectionActionConfiguration> CustomerUpdate(Expression<Func<string>> customerId)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            return new DeferredBodyAction<CustomerUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/{0}", __workflow_customerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CustomerUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CustomerRemoveGroup(Expression<Func<string>> customerId, Expression<Func<string>> groupId)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/{0}/groups/{1}", __workflow_customerId.WithUrlEncoding(1), __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CustomerAddGroup(Expression<Func<string>> customerId, Expression<Func<string>> groupId)
        {
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customers/{0}/groups/{1}", __workflow_customerId.WithUrlEncoding(1), __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeListResponse, ApiConnectionActionConfiguration> DisputeList(Expression<Func<string>> cursor = null, Expression<Func<statesInput>> states = null, Expression<Func<string>> locationId = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_states = WorkflowExpression.Compile(states, nameof(states), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            return new DeferredBodyAction<DisputeListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/disputes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_states != null)
                    callPayload.Queries["states"] = ExpressionConverter.Convert(__workflow_states);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                return new ApiConnectionAction<DisputeListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeRetrieveResponse, ApiConnectionActionConfiguration> DisputeRetrieve(Expression<Func<string>> disputeId)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            return new DeferredBodyAction<DisputeRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}", __workflow_disputeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DisputeRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeAcceptResponse, ApiConnectionActionConfiguration> DisputeAccept(Expression<Func<string>> disputeId)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            return new DeferredBodyAction<DisputeAcceptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}/accept", __workflow_disputeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DisputeAcceptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeListEvidenceResponse, ApiConnectionActionConfiguration> DisputeListEvidence(Expression<Func<string>> disputeId)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            return new DeferredBodyAction<DisputeListEvidenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}/evidence", __workflow_disputeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DisputeListEvidenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeCreateEvidenceTextResponse, ApiConnectionActionConfiguration> DisputeCreateEvidenceText(Expression<Func<string>> disputeId, Expression<Func<DisputeCreateEvidenceTextInput>> body = null)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DisputeCreateEvidenceTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}/evidence-text", __workflow_disputeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DisputeCreateEvidenceTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<DisputeRetrieveEvidenceResponse, ApiConnectionActionConfiguration> DisputeRetrieveEvidence(Expression<Func<string>> disputeId, Expression<Func<string>> evidenceId)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            var __workflow_evidenceId = WorkflowExpression.Compile(evidenceId, nameof(evidenceId), required: true);
            return new DeferredBodyAction<DisputeRetrieveEvidenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}/evidence/{1}", __workflow_disputeId.WithUrlEncoding(1), __workflow_evidenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DisputeRetrieveEvidenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DisputeDeleteEvidence(Expression<Func<string>> disputeId, Expression<Func<string>> evidenceId)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            var __workflow_evidenceId = WorkflowExpression.Compile(evidenceId, nameof(evidenceId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}/evidence/{1}", __workflow_disputeId.WithUrlEncoding(1), __workflow_evidenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<EvidenceSubmitResponse, ApiConnectionActionConfiguration> EvidenceSubmit(Expression<Func<string>> disputeId)
        {
            var __workflow_disputeId = WorkflowExpression.Compile(disputeId, nameof(disputeId), required: true);
            return new DeferredBodyAction<EvidenceSubmitResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/disputes/{0}/submit-evidence", __workflow_disputeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EvidenceSubmitResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrieveAdjustmentResponse, ApiConnectionActionConfiguration> InventoryRetrieveAdjustment(Expression<Func<string>> adjustmentId)
        {
            var __workflow_adjustmentId = WorkflowExpression.Compile(adjustmentId, nameof(adjustmentId), required: true);
            return new DeferredBodyAction<InventoryRetrieveAdjustmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inventory/adjustments/{0}", __workflow_adjustmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InventoryRetrieveAdjustmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryBatchChangeResponse, ApiConnectionActionConfiguration> InventoryBatchChange(Expression<Func<InventoryBatchChangeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InventoryBatchChangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inventory/changes/batch-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InventoryBatchChangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryBatchRetrieveChangesResponse, ApiConnectionActionConfiguration> InventoryBatchRetrieveChanges(Expression<Func<InventoryBatchRetrieveChangesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InventoryBatchRetrieveChangesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inventory/changes/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InventoryBatchRetrieveChangesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryBatchRetrieveCountsResponse, ApiConnectionActionConfiguration> InventoryBatchRetrieveCounts(Expression<Func<InventoryBatchRetrieveCountsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InventoryBatchRetrieveCountsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/inventory/counts/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InventoryBatchRetrieveCountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrievePhysicalCountResponse, ApiConnectionActionConfiguration> InventoryRetrievePhysicalCount(Expression<Func<string>> physicalCountId)
        {
            var __workflow_physicalCountId = WorkflowExpression.Compile(physicalCountId, nameof(physicalCountId), required: true);
            return new DeferredBodyAction<InventoryRetrievePhysicalCountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inventory/physical-counts/{0}", __workflow_physicalCountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InventoryRetrievePhysicalCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrieveTransferResponse, ApiConnectionActionConfiguration> InventoryRetrieveTransfer(Expression<Func<string>> transferId)
        {
            var __workflow_transferId = WorkflowExpression.Compile(transferId, nameof(transferId), required: true);
            return new DeferredBodyAction<InventoryRetrieveTransferResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inventory/transfers/{0}", __workflow_transferId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InventoryRetrieveTransferResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InventoryRetrieveCountResponse, ApiConnectionActionConfiguration> InventoryRetrieveCount(Expression<Func<string>> catalogObjectId, Expression<Func<string>> locationIds = null, Expression<Func<string>> cursor = null)
        {
            var __workflow_catalogObjectId = WorkflowExpression.Compile(catalogObjectId, nameof(catalogObjectId), required: true);
            var __workflow_locationIds = WorkflowExpression.Compile(locationIds, nameof(locationIds), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<InventoryRetrieveCountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/inventory/{0}", __workflow_catalogObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locationIds != null)
                    callPayload.Queries["location_ids"] = ExpressionConverter.Convert(__workflow_locationIds);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<InventoryRetrieveCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceListResponse, ApiConnectionActionConfiguration> InvoiceList(Expression<Func<string>> locationId = null, Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<InvoiceListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<InvoiceListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceCreateResponse, ApiConnectionActionConfiguration> InvoiceCreate(Expression<Func<InvoiceCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InvoiceCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvoiceCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceSearchResponse, ApiConnectionActionConfiguration> InvoiceSearch(Expression<Func<InvoiceSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InvoiceSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoices/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvoiceSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceGetResponse, ApiConnectionActionConfiguration> InvoiceGet(Expression<Func<string>> invoiceId)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<InvoiceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InvoiceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvoiceDelete(Expression<Func<string>> invoiceId, Expression<Func<int>> version = null)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(__workflow_version);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceUpdateResponse, ApiConnectionActionConfiguration> InvoiceUpdate(Expression<Func<string>> invoiceId, Expression<Func<InvoiceUpdateInput>> body = null)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<InvoiceUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvoiceUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoiceCancelResponse, ApiConnectionActionConfiguration> InvoiceCancel(Expression<Func<string>> invoiceId, Expression<Func<InvoiceCancelInput>> body = null)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<InvoiceCancelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/cancel", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvoiceCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<InvoicePublishResponse, ApiConnectionActionConfiguration> InvoicePublish(Expression<Func<string>> invoiceId, Expression<Func<InvoicePublishInput>> body)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InvoicePublishResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoices/{0}/publish", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InvoicePublishResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderCreateResponse, ApiConnectionActionConfiguration> OrderCreate(Expression<Func<OrderCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderBatchRetrieveResponse, ApiConnectionActionConfiguration> OrderBatchRetrieve(Expression<Func<OrderBatchRetrieveInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<OrderBatchRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders/batch-retrieve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderBatchRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderCalculateResponse, ApiConnectionActionConfiguration> OrderCalculate(Expression<Func<OrderCalculateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderCalculateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders/calculate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderCalculateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderCloneResponse, ApiConnectionActionConfiguration> OrderClone(Expression<Func<OrderCloneInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderCloneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders/clone";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderCloneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderSearchResponse, ApiConnectionActionConfiguration> OrderSearch(Expression<Func<OrderSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderRetrieveResponse, ApiConnectionActionConfiguration> OrderRetrieve(Expression<Func<string>> orderId)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            return new DeferredBodyAction<OrderRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orders/{0}", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrderRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderUpdateResponse, ApiConnectionActionConfiguration> OrderUpdate(Expression<Func<string>> orderId, Expression<Func<OrderUpdateInput>> body)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orders/{0}", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<OrderPayResponse, ApiConnectionActionConfiguration> OrderPay(Expression<Func<string>> orderId, Expression<Func<OrderPayInput>> body)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OrderPayResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orders/{0}/pay", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OrderPayResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentListResponse, ApiConnectionActionConfiguration> PaymentList(Expression<Func<string>> beginTime = null, Expression<Func<string>> endTime = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<string>> cursor = null, Expression<Func<string>> locationId = null, Expression<Func<int>> total = null, Expression<Func<string>> last4 = null, Expression<Func<string>> cardBrand = null, Expression<Func<int>> limit = null)
        {
            var __workflow_beginTime = WorkflowExpression.Compile(beginTime, nameof(beginTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_total = WorkflowExpression.Compile(total, nameof(total), required: false);
            var __workflow_last4 = WorkflowExpression.Compile(last4, nameof(last4), required: false);
            var __workflow_cardBrand = WorkflowExpression.Compile(cardBrand, nameof(cardBrand), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<PaymentListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/payments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_beginTime != null)
                    callPayload.Queries["begin_time"] = ExpressionConverter.Convert(__workflow_beginTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(__workflow_endTime);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_total != null)
                    callPayload.Queries["total"] = ExpressionConverter.Convert(__workflow_total);
                if (__workflow_last4 != null)
                    callPayload.Queries["last_4"] = ExpressionConverter.Convert(__workflow_last4);
                if (__workflow_cardBrand != null)
                    callPayload.Queries["card_brand"] = ExpressionConverter.Convert(__workflow_cardBrand);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<PaymentListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentCreateResponse, ApiConnectionActionConfiguration> PaymentCreate(Expression<Func<PaymentCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PaymentCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/payments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PaymentCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> PaymentCancelIdempotency(Expression<Func<PaymentCancelIdempotencyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/payments/cancel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentGetResponse, ApiConnectionActionConfiguration> PaymentGet(Expression<Func<string>> paymentId)
        {
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<PaymentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payments/{0}", __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaymentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentUpdateResponse, ApiConnectionActionConfiguration> PaymentUpdate(Expression<Func<string>> paymentId, Expression<Func<PaymentUpdateInput>> body)
        {
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PaymentUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payments/{0}", __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PaymentUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentCancelResponse, ApiConnectionActionConfiguration> PaymentCancel(Expression<Func<string>> paymentId)
        {
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<PaymentCancelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payments/{0}/cancel", __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaymentCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<PaymentCompleteResponse, ApiConnectionActionConfiguration> PaymentComplete(Expression<Func<string>> paymentId)
        {
            var __workflow_paymentId = WorkflowExpression.Compile(paymentId, nameof(paymentId), required: true);
            return new DeferredBodyAction<PaymentCompleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/payments/{0}/complete", __workflow_paymentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PaymentCompleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<RefundListResponse, ApiConnectionActionConfiguration> RefundList(Expression<Func<string>> beginTime = null, Expression<Func<string>> endTime = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<string>> cursor = null, Expression<Func<string>> locationId = null, Expression<Func<string>> status = null, Expression<Func<string>> sourceType = null, Expression<Func<int>> limit = null)
        {
            var __workflow_beginTime = WorkflowExpression.Compile(beginTime, nameof(beginTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_sourceType = WorkflowExpression.Compile(sourceType, nameof(sourceType), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<RefundListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/refunds";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_beginTime != null)
                    callPayload.Queries["begin_time"] = ExpressionConverter.Convert(__workflow_beginTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(__workflow_endTime);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_sourceType != null)
                    callPayload.Queries["source_type"] = ExpressionConverter.Convert(__workflow_sourceType);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<RefundListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<RefundPaymentResponse, ApiConnectionActionConfiguration> RefundPayment(Expression<Func<RefundPaymentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RefundPaymentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/refunds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RefundPaymentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<RefundGetResponse, ApiConnectionActionConfiguration> RefundGet(Expression<Func<string>> refundId)
        {
            var __workflow_refundId = WorkflowExpression.Compile(refundId, nameof(refundId), required: true);
            return new DeferredBodyAction<RefundGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/refunds/{0}", __workflow_refundId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RefundGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionCreateResponse, ApiConnectionActionConfiguration> SubscriptionCreate(Expression<Func<SubscriptionCreateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriptionCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriptionCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionSearchResponse, ApiConnectionActionConfiguration> SubscriptionSearch(Expression<Func<SubscriptionSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriptionSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/subscriptions/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriptionSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionRetrieveResponse, ApiConnectionActionConfiguration> SubscriptionRetrieve(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<SubscriptionRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriptionRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionUpdateResponse, ApiConnectionActionConfiguration> SubscriptionUpdate(Expression<Func<string>> subscriptionId, Expression<Func<SubscriptionUpdateInput>> body)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SubscriptionUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriptionUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionCancelResponse, ApiConnectionActionConfiguration> SubscriptionCancel(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<SubscriptionCancelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/cancel", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriptionCancelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionListEventsResponse, ApiConnectionActionConfiguration> SubscriptionListEvents(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<SubscriptionListEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/events", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SubscriptionListEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<SubscriptionResumeResponse, ApiConnectionActionConfiguration> SubscriptionResume(Expression<Func<string>> subscriptionId, Expression<Func<object>> body = null)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SubscriptionResumeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/subscriptions/{0}/resume", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SubscriptionResumeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCreateCheckoutResponse, ApiConnectionActionConfiguration> TerminalCreateCheckout(Expression<Func<TerminalCreateCheckoutInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TerminalCreateCheckoutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/terminals/checkouts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TerminalCreateCheckoutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalSearchCheckoutsResponse, ApiConnectionActionConfiguration> TerminalSearchCheckouts(Expression<Func<TerminalSearchCheckoutsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TerminalSearchCheckoutsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/terminals/checkouts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TerminalSearchCheckoutsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalGetCheckoutResponse, ApiConnectionActionConfiguration> TerminalGetCheckout(Expression<Func<string>> checkoutId)
        {
            var __workflow_checkoutId = WorkflowExpression.Compile(checkoutId, nameof(checkoutId), required: true);
            return new DeferredBodyAction<TerminalGetCheckoutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/terminals/checkouts/{0}", __workflow_checkoutId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TerminalGetCheckoutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCancelCheckoutResponse, ApiConnectionActionConfiguration> TerminalCancelCheckout(Expression<Func<string>> checkoutId, Expression<Func<object>> body = null)
        {
            var __workflow_checkoutId = WorkflowExpression.Compile(checkoutId, nameof(checkoutId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TerminalCancelCheckoutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/terminals/checkouts/{0}/cancel", __workflow_checkoutId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TerminalCancelCheckoutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCreateRefundResponse, ApiConnectionActionConfiguration> TerminalCreateRefund(Expression<Func<TerminalCreateRefundInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TerminalCreateRefundResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/terminals/refunds";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TerminalCreateRefundResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalSearchRefundsResponse, ApiConnectionActionConfiguration> TerminalSearchRefunds(Expression<Func<TerminalSearchRefundsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TerminalSearchRefundsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/terminals/refunds/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TerminalSearchRefundsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalGetRefundResponse, ApiConnectionActionConfiguration> TerminalGetRefund(Expression<Func<string>> terminalRefundId)
        {
            var __workflow_terminalRefundId = WorkflowExpression.Compile(terminalRefundId, nameof(terminalRefundId), required: true);
            return new DeferredBodyAction<TerminalGetRefundResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/terminals/refunds/{0}", __workflow_terminalRefundId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TerminalGetRefundResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarepaymentsip")]
        public IBodyWorkflowAction<TerminalCancelRefundResponse, ApiConnectionActionConfiguration> TerminalCancelRefund(Expression<Func<string>> terminalRefundId, Expression<Func<object>> body = null)
        {
            var __workflow_terminalRefundId = WorkflowExpression.Compile(terminalRefundId, nameof(terminalRefundId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<TerminalCancelRefundResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/terminals/refunds/{0}/cancel", __workflow_terminalRefundId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TerminalCancelRefundResponse>(callPayload);
            });
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

    public class ApplePayRegisterInput
    {
        [JsonProperty("domain_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DomainName { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CardCreateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("card")]
        public CardCreateInputCardType Card { get; set; }
    }

    public class CardCreateInputCardType
    {
        [JsonProperty("billing_address")]
        public CardCreateInputCardTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("cardholder_name")]
        public string CardholderName { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }
    }

    public class CardCreateInputCardTypeBillingAddressType
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

    public class CatalogBatchDeleteInput
    {
        [JsonProperty("object_ids")]
        public string[] ObjectIds { get; set; }
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

    public class CatalogBatchRetrieveInput
    {
        [JsonProperty("object_ids")]
        public string[] ObjectIds { get; set; }

        [JsonProperty("catalog_version")]
        public int? CatalogVersion { get; set; }

        [JsonProperty("include_related_objects")]
        public bool? IncludeRelatedObjects { get; set; }
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

    public class CatalogBatchUpsertInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("batches")]
        public CatalogBatchUpsertInputBatchesTypeItem[] Batches { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItem
    {
        [JsonProperty("objects")]
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItem[] Objects { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool? PresentAtAllLocations { get; set; }

        [JsonProperty("item_data")]
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataType ItemData { get; set; }

        [JsonProperty("category_data")]
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemCategoryDataType CategoryData { get; set; }

        [JsonProperty("tax_data")]
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemTaxDataType TaxData { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataType
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
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataTypeVariationsTypeItem[] Variations { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataTypeVariationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("present_at_all_locations")]
        public bool? PresentAtAllLocations { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemCategoryDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CatalogBatchUpsertInputBatchesTypeItemObjectsTypeItemTaxDataType
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
        public bool? AppliesToCustomAmounts { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
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

    public class CatalogUpsertInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("object")]
        public CatalogUpsertInputObjectEntityType ObjectEntity { get; set; }
    }

    public class CatalogUpsertInputObjectEntityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("item_data")]
        public CatalogUpsertInputObjectEntityTypeItemDataType ItemData { get; set; }
    }

    public class CatalogUpsertInputObjectEntityTypeItemDataType
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("variations")]
        public CatalogUpsertInputObjectEntityTypeItemDataTypeVariationsTypeItem[] Variations { get; set; }
    }

    public class CatalogUpsertInputObjectEntityTypeItemDataTypeVariationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("item_variation_data")]
        public CatalogUpsertInputObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataType ItemVariationData { get; set; }
    }

    public class CatalogUpsertInputObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataType
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricing_type")]
        public string PricingType { get; set; }

        [JsonProperty("price_money")]
        public CatalogUpsertInputObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType PriceMoney { get; set; }
    }

    public class CatalogUpsertInputObjectEntityTypeItemDataTypeVariationsTypeItemItemVariationDataTypePriceMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

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

    public class CatalogSearchInput
    {
        [JsonProperty("object_types")]
        public string[] ObjectTypes { get; set; }

        [JsonProperty("query")]
        public CatalogSearchInputQueryType Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class CatalogSearchInputQueryType
    {
        [JsonProperty("prefix_query")]
        public CatalogSearchInputQueryTypePrefixQueryType PrefixQuery { get; set; }
    }

    public class CatalogSearchInputQueryTypePrefixQueryType
    {
        [JsonProperty("attribute_name")]
        public string AttributeName { get; set; }

        [JsonProperty("attribute_prefix")]
        public string AttributePrefix { get; set; }
    }

    public class CatalogUpdateModifierResponse
    {
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CatalogUpdateModifierInput
    {
        [JsonProperty("item_ids")]
        public string[] ItemIds { get; set; }

        [JsonProperty("modifier_lists_to_enable")]
        public string[] ModifierListsToEnable { get; set; }

        [JsonProperty("modifier_lists_to_disable")]
        public string[] ModifierListsToDisable { get; set; }
    }

    public class CatalogUpdateTaxesResponse
    {
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CatalogUpdateTaxesInput
    {
        [JsonProperty("item_ids")]
        public string[] ItemIds { get; set; }

        [JsonProperty("taxes_to_enable")]
        public string[] TaxesToEnable { get; set; }

        [JsonProperty("taxes_to_disable")]
        public string[] TaxesToDisable { get; set; }
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

    public class CustomGroupCreateInput
    {
        [JsonProperty("group")]
        public CustomGroupCreateInputGroupType Group { get; set; }
    }

    public class CustomGroupCreateInputGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
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

    public class CustomerGroupUpdateInput
    {
        [JsonProperty("group")]
        public CustomerGroupUpdateInputGroupType Group { get; set; }
    }

    public class CustomerGroupUpdateInputGroupType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CustomerCreateInput
    {
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
        public CustomerCreateInputAddressType Address { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }
    }

    public class CustomerCreateInputAddressType
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

    public class CustomerSearchInput
    {
        [JsonProperty("query")]
        public CustomerSearchInputQueryType Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class CustomerSearchInputQueryType
    {
        [JsonProperty("filter")]
        public CustomerSearchInputQueryTypeFilterType Filter { get; set; }

        [JsonProperty("sort")]
        public CustomerSearchInputQueryTypeSortType Sort { get; set; }
    }

    public class CustomerSearchInputQueryTypeFilterType
    {
        [JsonProperty("email_address")]
        public CustomerSearchInputQueryTypeFilterTypeEmailAddressType EmailAddress { get; set; }

        [JsonProperty("creation_source")]
        public CustomerSearchInputQueryTypeFilterTypeCreationSourceType CreationSource { get; set; }

        [JsonProperty("created_at")]
        public CustomerSearchInputQueryTypeFilterTypeCreatedAtType CreatedAt { get; set; }

        [JsonProperty("group_ids")]
        public CustomerSearchInputQueryTypeFilterTypeGroupIdsType GroupIds { get; set; }
    }

    public class CustomerSearchInputQueryTypeFilterTypeEmailAddressType
    {
        [JsonProperty("fuzzy")]
        public string Fuzzy { get; set; }
    }

    public class CustomerSearchInputQueryTypeFilterTypeCreationSourceType
    {
        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }
    }

    public class CustomerSearchInputQueryTypeFilterTypeCreatedAtType
    {
        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }
    }

    public class CustomerSearchInputQueryTypeFilterTypeGroupIdsType
    {
        [JsonProperty("all")]
        public string[] All { get; set; }
    }

    public class CustomerSearchInputQueryTypeSortType
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class DisputeCreateEvidenceTextInput
    {
        [JsonProperty("evidence_type")]
        public DisputeCreateEvidenceTextInputEvidenceTypeType? EvidenceType { get; set; }

        [JsonProperty("evidence_text")]
        public string EvidenceText { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DisputeCreateEvidenceTextInputEvidenceTypeType
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

    public class InventoryBatchChangeInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("changes")]
        public InventoryBatchChangeInputChangesTypeItem[] Changes { get; set; }

        [JsonProperty("ignore_unchanged_counts")]
        public bool? IgnoreUnchangedCounts { get; set; }
    }

    public class InventoryBatchChangeInputChangesTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("physical_count")]
        public InventoryBatchChangeInputChangesTypeItemPhysicalCountType PhysicalCount { get; set; }
    }

    public class InventoryBatchChangeInputChangesTypeItemPhysicalCountType
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

    public class InventoryBatchRetrieveChangesInput
    {
        [JsonProperty("catalog_object_ids")]
        public string[] CatalogObjectIds { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        [JsonProperty("states")]
        public string[] States { get; set; }

        [JsonProperty("updated_after")]
        public string UpdatedAfter { get; set; }

        [JsonProperty("updated_before")]
        public string UpdatedBefore { get; set; }
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

    public class InventoryBatchRetrieveCountsInput
    {
        [JsonProperty("catalog_object_ids")]
        public string[] CatalogObjectIds { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("updated_after")]
        public string UpdatedAfter { get; set; }
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

    public class InvoiceCreateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("invoice")]
        public InvoiceCreateInputInvoiceType Invoice { get; set; }
    }

    public class InvoiceCreateInputInvoiceType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("scheduled_at")]
        public string ScheduledAt { get; set; }

        [JsonProperty("primary_recipient")]
        public InvoiceCreateInputInvoiceTypePrimaryRecipientType PrimaryRecipient { get; set; }

        [JsonProperty("delivery_method")]
        public string DeliveryMethod { get; set; }

        [JsonProperty("payment_requests")]
        public InvoiceCreateInputInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("accepted_payment_methods")]
        public InvoiceCreateInputInvoiceTypeAcceptedPaymentMethodsType AcceptedPaymentMethods { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceCreateInputInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("sale_or_service_date")]
        public string SaleOrServiceDate { get; set; }
    }

    public class InvoiceCreateInputInvoiceTypePrimaryRecipientType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
    }

    public class InvoiceCreateInputInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("request_type")]
        public string RequestType { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool? TippingEnabled { get; set; }

        [JsonProperty("automatic_payment_source")]
        public string AutomaticPaymentSource { get; set; }

        [JsonProperty("reminders")]
        public InvoiceCreateInputInvoiceTypePaymentRequestsTypeItemRemindersTypeItem[] Reminders { get; set; }
    }

    public class InvoiceCreateInputInvoiceTypePaymentRequestsTypeItemRemindersTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("relative_scheduled_days")]
        public int? RelativeScheduledDays { get; set; }
    }

    public class InvoiceCreateInputInvoiceTypeAcceptedPaymentMethodsType
    {
        [JsonProperty("card")]
        public bool? Card { get; set; }

        [JsonProperty("square_gift_card")]
        public bool? SquareGiftCard { get; set; }

        [JsonProperty("bank_account")]
        public bool? BankAccount { get; set; }
    }

    public class InvoiceCreateInputInvoiceTypeCustomFieldsTypeItem
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

    public class InvoiceSearchInput
    {
        [JsonProperty("query")]
        public InvoiceSearchInputQueryType Query { get; set; }
    }

    public class InvoiceSearchInputQueryType
    {
        [JsonProperty("filter")]
        public InvoiceSearchInputQueryTypeFilterType Filter { get; set; }

        [JsonProperty("sort")]
        public InvoiceSearchInputQueryTypeSortType Sort { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class InvoiceSearchInputQueryTypeFilterType
    {
        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("customer_ids")]
        public string[] CustomerIds { get; set; }
    }

    public class InvoiceSearchInputQueryTypeSortType
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }
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

    public class InvoiceUpdateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("invoice")]
        public InvoiceUpdateInputInvoiceType Invoice { get; set; }

        [JsonProperty("fields_to_clear")]
        public string[] FieldsToClear { get; set; }
    }

    public class InvoiceUpdateInputInvoiceType
    {
        [JsonProperty("payment_requests")]
        public InvoiceUpdateInputInvoiceTypePaymentRequestsTypeItem[] PaymentRequests { get; set; }
    }

    public class InvoiceUpdateInputInvoiceTypePaymentRequestsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("tipping_enabled")]
        public bool? TippingEnabled { get; set; }
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

    public class InvoiceCancelInput
    {
        [JsonProperty("version")]
        public int? Version { get; set; }
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

    public class InvoicePublishInput
    {
        [JsonProperty("version")]
        public int? Version { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
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

    public class OrderCreateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("order")]
        public OrderCreateInputOrderType Order { get; set; }
    }

    public class OrderCreateInputOrderType
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("line_items")]
        public OrderCreateInputOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("taxes")]
        public OrderCreateInputOrderTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("discounts")]
        public OrderCreateInputOrderTypeDiscountsTypeItem[] Discounts { get; set; }
    }

    public class OrderCreateInputOrderTypeLineItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCreateInputOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }

        [JsonProperty("modifiers")]
        public OrderCreateInputOrderTypeLineItemsTypeItemModifiersTypeItem[] Modifiers { get; set; }

        [JsonProperty("applied_discounts")]
        public OrderCreateInputOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }
    }

    public class OrderCreateInputOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class OrderCreateInputOrderTypeLineItemsTypeItemModifiersTypeItem
    {
        [JsonProperty("catalog_object_id")]
        public string CatalogObjectId { get; set; }
    }

    public class OrderCreateInputOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }
    }

    public class OrderCreateInputOrderTypeTaxesTypeItem
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

    public class OrderCreateInputOrderTypeDiscountsTypeItem
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
        public OrderCreateInputOrderTypeDiscountsTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class OrderCreateInputOrderTypeDiscountsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

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

    public class OrderBatchRetrieveInput
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("order_ids")]
        public string[] OrderIds { get; set; }
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

    public class OrderCalculateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("order")]
        public OrderCalculateInputOrderType Order { get; set; }
    }

    public class OrderCalculateInputOrderType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("discounts")]
        public OrderCalculateInputOrderTypeDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("line_items")]
        public OrderCalculateInputOrderTypeLineItemsTypeItem[] LineItems { get; set; }
    }

    public class OrderCalculateInputOrderTypeDiscountsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class OrderCalculateInputOrderTypeLineItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public OrderCalculateInputOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }
    }

    public class OrderCalculateInputOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
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

    public class OrderCloneInput
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
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

    public class OrderSearchInput
    {
        [JsonProperty("return_entries")]
        public bool? ReturnEntries { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("query")]
        public OrderSearchInputQueryType Query { get; set; }
    }

    public class OrderSearchInputQueryType
    {
        [JsonProperty("filter")]
        public OrderSearchInputQueryTypeFilterType Filter { get; set; }

        [JsonProperty("sort")]
        public OrderSearchInputQueryTypeSortType Sort { get; set; }
    }

    public class OrderSearchInputQueryTypeFilterType
    {
        [JsonProperty("date_time_filter")]
        public OrderSearchInputQueryTypeFilterTypeDateTimeFilterType DateTimeFilter { get; set; }

        [JsonProperty("state_filter")]
        public OrderSearchInputQueryTypeFilterTypeStateFilterType StateFilter { get; set; }
    }

    public class OrderSearchInputQueryTypeFilterTypeDateTimeFilterType
    {
        [JsonProperty("closed_at")]
        public OrderSearchInputQueryTypeFilterTypeDateTimeFilterTypeClosedAtType ClosedAt { get; set; }
    }

    public class OrderSearchInputQueryTypeFilterTypeDateTimeFilterTypeClosedAtType
    {
        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }
    }

    public class OrderSearchInputQueryTypeFilterTypeStateFilterType
    {
        [JsonProperty("states")]
        public string[] States { get; set; }
    }

    public class OrderSearchInputQueryTypeSortType
    {
        [JsonProperty("sort_field")]
        public string SortField { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }
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

    public class OrderUpdateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("order")]
        public OrderUpdateInputOrderType Order { get; set; }

        [JsonProperty("fields_to_clear")]
        public string[] FieldsToClear { get; set; }
    }

    public class OrderUpdateInputOrderType
    {
        [JsonProperty("version")]
        public int? Version { get; set; }

        [JsonProperty("line_items")]
        public OrderUpdateInputOrderTypeLineItemsTypeItem[] LineItems { get; set; }
    }

    public class OrderUpdateInputOrderTypeLineItemsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("base_price_money")]
        public OrderUpdateInputOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }
    }

    public class OrderUpdateInputOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
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

    public class OrderPayInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("payment_ids")]
        public string[] PaymentIds { get; set; }
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

    public class PaymentCreateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("amount_money")]
        public PaymentCreateInputAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("autocomplete")]
        public bool? Autocomplete { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("app_fee_money")]
        public PaymentCreateInputAppFeeMoneyType AppFeeMoney { get; set; }
    }

    public class PaymentCreateInputAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCreateInputAppFeeMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentCancelIdempotencyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
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

    public class PaymentUpdateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("payment")]
        public PaymentUpdateInputPaymentType Payment { get; set; }
    }

    public class PaymentUpdateInputPaymentType
    {
        [JsonProperty("amount_money")]
        public PaymentUpdateInputPaymentTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("tip_money")]
        public PaymentUpdateInputPaymentTypeTipMoneyType TipMoney { get; set; }

        [JsonProperty("version_token")]
        public string VersionToken { get; set; }
    }

    public class PaymentUpdateInputPaymentTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class PaymentUpdateInputPaymentTypeTipMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
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

    public class RefundPaymentInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }

        [JsonProperty("amount_money")]
        public RefundPaymentInputAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("app_fee_money")]
        public RefundPaymentInputAppFeeMoneyType AppFeeMoney { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class RefundPaymentInputAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class RefundPaymentInputAppFeeMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

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

    public class SubscriptionCreateInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

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

        [JsonProperty("tax_percentage")]
        public string TaxPercentage { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionCreateInputPriceOverrideMoneyType PriceOverrideMoney { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("source")]
        public SubscriptionCreateInputSourceType Source { get; set; }
    }

    public class SubscriptionCreateInputPriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class SubscriptionCreateInputSourceType
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

    public class SubscriptionSearchInput
    {
        [JsonProperty("query")]
        public SubscriptionSearchInputQueryType Query { get; set; }
    }

    public class SubscriptionSearchInputQueryType
    {
        [JsonProperty("filter")]
        public SubscriptionSearchInputQueryTypeFilterType Filter { get; set; }
    }

    public class SubscriptionSearchInputQueryTypeFilterType
    {
        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("customer_ids")]
        public string[] CustomerIds { get; set; }

        [JsonProperty("source_names")]
        public string[] SourceNames { get; set; }
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

    public class SubscriptionUpdateInput
    {
        [JsonProperty("subscription")]
        public SubscriptionUpdateInputSubscriptionType Subscription { get; set; }
    }

    public class SubscriptionUpdateInputSubscriptionType
    {
        [JsonProperty("version")]
        public int? Version { get; set; }

        [JsonProperty("tax_percentage")]
        public string TaxPercentage { get; set; }

        [JsonProperty("price_override_money")]
        public SubscriptionUpdateInputSubscriptionTypePriceOverrideMoneyType PriceOverrideMoney { get; set; }
    }

    public class SubscriptionUpdateInputSubscriptionTypePriceOverrideMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
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

    public class TerminalCreateCheckoutInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("checkout")]
        public TerminalCreateCheckoutInputCheckoutType Checkout { get; set; }
    }

    public class TerminalCreateCheckoutInputCheckoutType
    {
        [JsonProperty("amount_money")]
        public TerminalCreateCheckoutInputCheckoutTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("device_options")]
        public TerminalCreateCheckoutInputCheckoutTypeDeviceOptionsType DeviceOptions { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class TerminalCreateCheckoutInputCheckoutTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TerminalCreateCheckoutInputCheckoutTypeDeviceOptionsType
    {
        [JsonProperty("device_id")]
        public string DeviceId { get; set; }
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

    public class TerminalSearchCheckoutsInput
    {
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("query")]
        public TerminalSearchCheckoutsInputQueryType Query { get; set; }
    }

    public class TerminalSearchCheckoutsInputQueryType
    {
        [JsonProperty("filter")]
        public TerminalSearchCheckoutsInputQueryTypeFilterType Filter { get; set; }
    }

    public class TerminalSearchCheckoutsInputQueryTypeFilterType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
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

    public class TerminalCreateRefundInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("refund")]
        public TerminalCreateRefundInputRefundType Refund { get; set; }
    }

    public class TerminalCreateRefundInputRefundType
    {
        [JsonProperty("amount_money")]
        public TerminalCreateRefundInputRefundTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
    }

    public class TerminalCreateRefundInputRefundTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
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

    public class TerminalSearchRefundsInput
    {
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("query")]
        public TerminalSearchRefundsInputQueryType Query { get; set; }
    }

    public class TerminalSearchRefundsInputQueryType
    {
        [JsonProperty("filter")]
        public TerminalSearchRefundsInputQueryTypeFilterType Filter { get; set; }
    }

    public class TerminalSearchRefundsInputQueryTypeFilterType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
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