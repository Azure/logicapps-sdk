//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flexe
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlexeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProducts(Expression<Func<NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/shipper/dropoff/container";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetInboundShipmentsContainingNonPalletizedProducts(Expression<Func<string>> continuationToken, Expression<Func<string>> pageSize, Expression<Func<string>> state, Expression<Func<string>> createdAtFrom, Expression<Func<string>> createdAtTo, Expression<Func<string>> updatedAtFrom, Expression<Func<string>> updatedAtTo, Expression<Func<string>> customerUUID, Expression<Func<string>> purchaseOrder, Expression<Func<string>> reservations)
        {
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: true);
            var __workflow_createdAtFrom = WorkflowExpression.Compile(createdAtFrom, nameof(createdAtFrom), required: true);
            var __workflow_createdAtTo = WorkflowExpression.Compile(createdAtTo, nameof(createdAtTo), required: true);
            var __workflow_updatedAtFrom = WorkflowExpression.Compile(updatedAtFrom, nameof(updatedAtFrom), required: true);
            var __workflow_updatedAtTo = WorkflowExpression.Compile(updatedAtTo, nameof(updatedAtTo), required: true);
            var __workflow_customerUUID = WorkflowExpression.Compile(customerUUID, nameof(customerUUID), required: true);
            var __workflow_purchaseOrder = WorkflowExpression.Compile(purchaseOrder, nameof(purchaseOrder), required: true);
            var __workflow_reservations = WorkflowExpression.Compile(reservations, nameof(reservations), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/shipper/dropoff/containers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(__workflow_createdAtFrom);
                callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(__workflow_createdAtTo);
                callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(__workflow_updatedAtFrom);
                callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(__workflow_updatedAtTo);
                callPayload.Queries["customerUUID"] = ExpressionConverter.Convert(__workflow_customerUUID);
                callPayload.Queries["purchaseOrder"] = ExpressionConverter.Convert(__workflow_purchaseOrder);
                callPayload.Queries["reservations"] = ExpressionConverter.Convert(__workflow_reservations);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RequestACountOfInventoryBySkuFromFlexe(Expression<Func<string>> reservationId = null, Expression<Func<string>> clientRequestId = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> everInUse = null, Expression<Func<string>> inUseSince = null, Expression<Func<string>> itemIds = null, Expression<Func<string>> skus = null)
        {
            var __workflow_reservationId = WorkflowExpression.Compile(reservationId, nameof(reservationId), required: false);
            var __workflow_clientRequestId = WorkflowExpression.Compile(clientRequestId, nameof(clientRequestId), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_everInUse = WorkflowExpression.Compile(everInUse, nameof(everInUse), required: false);
            var __workflow_inUseSince = WorkflowExpression.Compile(inUseSince, nameof(inUseSince), required: false);
            var __workflow_itemIds = WorkflowExpression.Compile(itemIds, nameof(itemIds), required: false);
            var __workflow_skus = WorkflowExpression.Compile(skus, nameof(skus), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/shipper/inventory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reservationId != null)
                    callPayload.Queries["reservation_id"] = ExpressionConverter.Convert(__workflow_reservationId);
                if (__workflow_clientRequestId != null)
                    callPayload.Queries["client_request_id"] = ExpressionConverter.Convert(__workflow_clientRequestId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuation_token"] = ExpressionConverter.Convert(__workflow_continuationToken);
                if (__workflow_everInUse != null)
                    callPayload.Queries["ever_in_use"] = ExpressionConverter.Convert(__workflow_everInUse);
                if (__workflow_inUseSince != null)
                    callPayload.Queries["in_use_since"] = ExpressionConverter.Convert(__workflow_inUseSince);
                if (__workflow_itemIds != null)
                    callPayload.Queries["item_ids[]"] = ExpressionConverter.Convert(__workflow_itemIds);
                if (__workflow_skus != null)
                    callPayload.Queries["skus[]"] = ExpressionConverter.Convert(__workflow_skus);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateRetailFulfillmentOrder(Expression<Func<CreateRetailFulfillmentOrderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/shipper/fulfillment/retail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateExistingRetailFulfillmentOrder(Expression<Func<string>> shipmentId, Expression<Func<UpdateExistingRetailFulfillmentOrderInput>> body)
        {
            var __workflow_shipmentId = WorkflowExpression.Compile(shipmentId, nameof(shipmentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/shipper/fulfillment/retail/{0}", __workflow_shipmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class FlexeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> Webhook(Expression<Func<WebhookInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataType Data { get; set; }

        [JsonProperty("meta", DefaultValueHandling = DefaultValueHandling.Include)]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputMetaType Meta { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataType
    {
        [JsonProperty("dropoffList", DefaultValueHandling = DefaultValueHandling.Include)]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItem[] DropoffList { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItem
    {
        [JsonProperty("billOfLading")]
        public string BillOfLading { get; set; }

        [JsonProperty("inventory")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemInventoryTypeItem[] Inventory { get; set; }

        [JsonProperty("expectedInboundShipmentType")]
        public string ExpectedInboundShipmentType { get; set; }

        [JsonProperty("customerUUID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerUUID { get; set; }

        [JsonProperty("containerNumber")]
        public string ContainerNumber { get; set; }

        [JsonProperty("valueOfGoods")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemValueOfGoodsType ValueOfGoods { get; set; }

        [JsonProperty("purchaseOrderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PurchaseOrderId { get; set; }

        [JsonProperty("dropoffDate", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DropoffDate { get; set; }

        [JsonProperty("containerSealNumber")]
        public string ContainerSealNumber { get; set; }

        [JsonProperty("reservation", DefaultValueHandling = DefaultValueHandling.Include)]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemReservationType Reservation { get; set; }

        [JsonProperty("suplierOrVendor")]
        public string SuplierOrVendor { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lpns")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItem[] Lpns { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemInventoryTypeItem
    {
        [JsonProperty("count")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemInventoryTypeItemCountType Count { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemInventoryTypeItemCountType
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Amount { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Unit { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemValueOfGoodsType
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Amount { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Unit { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemReservationType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItem
    {
        [JsonProperty("metadata")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("inventory")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItemInventoryTypeItem[] Inventory { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItemMetadataType
    {
        [JsonProperty("customReference1")]
        public string CustomReference1 { get; set; }

        [JsonProperty("lotCode")]
        public string LotCode { get; set; }

        [JsonProperty("asnNumber")]
        public string AsnNumber { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("extraProperties")]
        public NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItemMetadataTypeExtraPropertiesType ExtraProperties { get; set; }

        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }

        [JsonProperty("originSite")]
        public string OriginSite { get; set; }

        [JsonProperty("customReference2")]
        public string CustomReference2 { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItemMetadataTypeExtraPropertiesType
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputDataTypeDropoffListTypeItemLpnsTypeItemInventoryTypeItem
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProductsInputMetaType
    {
        [JsonProperty("correlationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; }
    }

    public class CreateRetailFulfillmentOrderInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataType Data { get; set; }

        [JsonProperty("meta", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputMetaType Meta { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataType
    {
        [JsonProperty("reservation", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeReservationType Reservation { get; set; }

        [JsonProperty("shipment", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentType Shipment { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeReservationType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentType
    {
        [JsonProperty("customerUUID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerUUID { get; set; }

        [JsonProperty("inventory", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItem[] Inventory { get; set; }

        [JsonProperty("shipTo", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeShipToType ShipTo { get; set; }

        [JsonProperty("shipWithin", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeShipWithinType ShipWithin { get; set; }

        [JsonProperty("shipmentType")]
        public string ShipmentType { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; }

        [JsonProperty("shipmentMethod")]
        public string ShipmentMethod { get; set; }

        [JsonProperty("purchaseOrder")]
        public string PurchaseOrder { get; set; }

        [JsonProperty("routeBy")]
        public string RouteBy { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("labelGenerationData")]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeLabelGenerationDataType LabelGenerationData { get; set; }

        [JsonProperty("bolGenerationData")]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataType BolGenerationData { get; set; }

        [JsonProperty("routingDetailsId")]
        public string RoutingDetailsId { get; set; }

        [JsonProperty("destinationType")]
        public string DestinationType { get; set; }

        [JsonProperty("destinationRetailer")]
        public string DestinationRetailer { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItem
    {
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemCountType Count { get; set; }

        [JsonProperty("sku", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Sku { get; set; }

        [JsonProperty("attachments")]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemCountType
    {
        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemCountTypeAmountType Amount { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemCountTypeUnitType Unit { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemCountTypeAmountType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemCountTypeUnitType
    {
        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeInventoryTypeItemAttachmentsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeShipToType
    {
        [JsonProperty("addressLine1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AddressLine1 { get; set; }

        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Country { get; set; }

        [JsonProperty("locality", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Locality { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("postcode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Postcode { get; set; }

        [JsonProperty("region", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Region { get; set; }

        [JsonProperty("addressLine2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("addressLine3")]
        public string AddressLine3 { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeShipWithinType
    {
        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public string End { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeLabelGenerationDataType
    {
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("carrierServiceType")]
        public string CarrierServiceType { get; set; }

        [JsonProperty("carrierBillingAccountId")]
        public string CarrierBillingAccountId { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataType
    {
        [JsonProperty("gs1us")]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataTypeGs1usType Gs1us { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataTypeGs1usType
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("shipTo")]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataTypeGs1usTypeShipToType ShipTo { get; set; }

        [JsonProperty("billTo")]
        public CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataTypeGs1usTypeBillToType BillTo { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataTypeGs1usTypeShipToType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputDataTypeShipmentTypeBolGenerationDataTypeGs1usTypeBillToType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateRetailFulfillmentOrderInputMetaType
    {
        [JsonProperty("correlationId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CorrelationId { get; set; }
    }

    public class UpdateExistingRetailFulfillmentOrderInput
    {
        [JsonProperty("data")]
        public UpdateExistingRetailFulfillmentOrderInputDataType Data { get; set; }

        [JsonProperty("meta")]
        public string Meta { get; set; }
    }

    public class UpdateExistingRetailFulfillmentOrderInputDataType
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("scac")]
        public string Scac { get; set; }

        [JsonProperty("bolNumber")]
        public string BolNumber { get; set; }
    }

    public class WebhookResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signingKey")]
        public string SigningKey { get; set; }
    }

    public class WebhookInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flexe;

    public partial class WorkflowManagedActions
    {
        public FlexeActions Flexe(string connectionId) => new FlexeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlexeTriggers Flexe(string connectionId) => new FlexeTriggers(connectionId);
    }
}