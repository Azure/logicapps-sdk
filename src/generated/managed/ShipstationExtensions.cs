//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shipstation
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShipstationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shipstation")]
        public IBodyWorkflowAction<GetOrderResponse, ApiConnectionActionConfiguration> GetOrderById(Expression<Func<double>> orderId)
        {
            var __workflow_orderId = WorkflowExpression.Compile(orderId, nameof(orderId), required: true);
            return new DeferredBodyAction<GetOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/orders/{0}", __workflow_orderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shipstation")]
        public IBodyWorkflowAction<CreateLabelforOrderResponse, ApiConnectionActionConfiguration> CreateLabelForOrder(Expression<Func<object>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateLabelforOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders/createlabelfororder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateLabelforOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shipstation")]
        public IBodyWorkflowAction<CreateUpdateOrderResponse, ApiConnectionActionConfiguration> CreateUpdateOrder(Expression<Func<object>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUpdateOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/orders/createorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateOrderResponse>(callPayload);
            });
        }
    }

    public class ShipstationTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscribeResponse, ApiConnectionTriggerConfiguration> WebhookSubscribe(Expression<Func<WebhookSubscribeInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookSubscribeResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/subscribe";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookSubscribeResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetOrderResponse
    {
        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("orderKey")]
        public string OrderKey { get; set; }

        [JsonProperty("orderDate")]
        public string OrderDate { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("modifyDate")]
        public string ModifyDate { get; set; }

        [JsonProperty("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonProperty("shipByDate")]
        public string ShipByDate { get; set; }

        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerUsername")]
        public string CustomerUsername { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("billTo")]
        public BillTo BillTo { get; set; }

        [JsonProperty("shipTo")]
        public ShipTo ShipTo { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("orderTotal")]
        public double OrderTotal { get; set; }

        [JsonProperty("amountPaid")]
        public double AmountPaid { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("shippingAmount")]
        public double ShippingAmount { get; set; }

        [JsonProperty("customerNotes")]
        public string CustomerNotes { get; set; }

        [JsonProperty("internalNotes")]
        public string InternalNotes { get; set; }

        [JsonProperty("gift")]
        public bool Gift { get; set; }

        [JsonProperty("giftMessage")]
        public string GiftMessage { get; set; }

        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("requestedShippingService")]
        public string RequestedShippingService { get; set; }

        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        [JsonProperty("serviceCode")]
        public string ServiceCode { get; set; }

        [JsonProperty("packageCode")]
        public string PackageCode { get; set; }

        [JsonProperty("confirmation")]
        public string Confirmation { get; set; }

        [JsonProperty("shipDate")]
        public string ShipDate { get; set; }

        [JsonProperty("holdUntilDate")]
        public string HoldUntilDate { get; set; }

        [JsonProperty("weight")]
        public Weight Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("insuranceOptions")]
        public InsuranceOptions InsuranceOptions { get; set; }

        [JsonProperty("internationalOptions")]
        public InternationalOptions InternationalOptions { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("tagIds")]
        public string TagIds { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("externallyFulfilled")]
        public bool ExternallyFulfilled { get; set; }

        [JsonProperty("externallyFulfilledBy")]
        public string ExternallyFulfilledBy { get; set; }
    }

    public class BillTo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("street1")]
        public string Street1 { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("street3")]
        public string Street3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("residential")]
        public string Residential { get; set; }

        [JsonProperty("addressVerified")]
        public string AddressVerified { get; set; }
    }

    public class ShipTo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("street1")]
        public string Street1 { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("street3")]
        public string Street3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("residential")]
        public bool Residential { get; set; }

        [JsonProperty("addressVerified")]
        public string AddressVerified { get; set; }
    }

    public class Item
    {
        [JsonProperty("lineItemKey")]
        public string LineItemKey { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("weight")]
        public Weight Weight { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("shippingAmount")]
        public double ShippingAmount { get; set; }

        [JsonProperty("warehouseLocation")]
        public string WarehouseLocation { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("productId")]
        public int ProductId { get; set; }

        [JsonProperty("fulfillmentSku")]
        public string FulfillmentSku { get; set; }

        [JsonProperty("adjustment")]
        public bool Adjustment { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }
    }

    public class Weight
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class Option
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Dimensions
    {
        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("length")]
        public double Length { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }
    }

    public class InsuranceOptions
    {
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("insureShipment")]
        public bool InsureShipment { get; set; }

        [JsonProperty("insuredValue")]
        public double InsuredValue { get; set; }
    }

    public class InternationalOptions
    {
        [JsonProperty("contents")]
        public string Contents { get; set; }

        [JsonProperty("customsItems")]
        public CustomsItem[] CustomsItems { get; set; }

        [JsonProperty("nonDelivery")]
        public string NonDelivery { get; set; }
    }

    public class CustomsItem
    {
        [JsonProperty("customsItemId")]
        public int CustomsItemId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("harmonizedTariffCode")]
        public string HarmonizedTariffCode { get; set; }

        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }
    }

    public class AdvancedOptions
    {
        [JsonProperty("warehouseId")]
        public int WarehouseId { get; set; }

        [JsonProperty("nonMachinable")]
        public bool NonMachinable { get; set; }

        [JsonProperty("saturdayDelivery")]
        public bool SaturdayDelivery { get; set; }

        [JsonProperty("containsAlcohol")]
        public bool ContainsAlcohol { get; set; }

        [JsonProperty("mergedOrSplit")]
        public bool MergedOrSplit { get; set; }

        [JsonProperty("mergedIds")]
        public string[] MergedIds { get; set; }

        [JsonProperty("parentId")]
        public string ParentId { get; set; }

        [JsonProperty("storeId")]
        public int StoreId { get; set; }

        [JsonProperty("customField1")]
        public string CustomField1 { get; set; }

        [JsonProperty("customField2")]
        public string CustomField2 { get; set; }

        [JsonProperty("customField3")]
        public string CustomField3 { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("billToParty")]
        public string BillToParty { get; set; }

        [JsonProperty("billToAccount")]
        public string BillToAccount { get; set; }

        [JsonProperty("billToPostalCode")]
        public string BillToPostalCode { get; set; }

        [JsonProperty("billToCountryCode")]
        public string BillToCountryCode { get; set; }
    }

    public class CreateLabelforOrderResponse
    {
        [JsonProperty("shipmentId")]
        public int ShipmentId { get; set; }

        [JsonProperty("shipmentCost")]
        public double ShipmentCost { get; set; }

        [JsonProperty("insuranceCost")]
        public double InsuranceCost { get; set; }

        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        [JsonProperty("labelData")]
        public string LabelData { get; set; }

        [JsonProperty("formData")]
        public string FormData { get; set; }
    }

    public class CreateUpdateOrderResponse
    {
        [JsonProperty("orderId")]
        public int OrderId { get; set; }

        [JsonProperty("orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("orderKey")]
        public string OrderKey { get; set; }

        [JsonProperty("orderDate")]
        public string OrderDate { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("modifyDate")]
        public string ModifyDate { get; set; }

        [JsonProperty("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonProperty("shipByDate")]
        public string ShipByDate { get; set; }

        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("customerUsername")]
        public string CustomerUsername { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("billTo")]
        public BillTo BillTo { get; set; }

        [JsonProperty("shipTo")]
        public ShipTo ShipTo { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("orderTotal")]
        public double OrderTotal { get; set; }

        [JsonProperty("amountPaid")]
        public double AmountPaid { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("shippingAmount")]
        public double ShippingAmount { get; set; }

        [JsonProperty("customerNotes")]
        public string CustomerNotes { get; set; }

        [JsonProperty("internalNotes")]
        public string InternalNotes { get; set; }

        [JsonProperty("gift")]
        public bool Gift { get; set; }

        [JsonProperty("giftMessage")]
        public string GiftMessage { get; set; }

        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonProperty("requestedShippingService")]
        public string RequestedShippingService { get; set; }

        [JsonProperty("carrierCode")]
        public string CarrierCode { get; set; }

        [JsonProperty("serviceCode")]
        public string ServiceCode { get; set; }

        [JsonProperty("packageCode")]
        public string PackageCode { get; set; }

        [JsonProperty("confirmation")]
        public string Confirmation { get; set; }

        [JsonProperty("shipDate")]
        public string ShipDate { get; set; }

        [JsonProperty("holdUntilDate")]
        public string HoldUntilDate { get; set; }

        [JsonProperty("weight")]
        public Weight Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("insuranceOptions")]
        public InsuranceOptions InsuranceOptions { get; set; }

        [JsonProperty("internationalOptions")]
        public InternationalOptions InternationalOptions { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("tagIds")]
        public string TagIds { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("externallyFulfilled")]
        public bool ExternallyFulfilled { get; set; }

        [JsonProperty("externallyFulfilledBy")]
        public string ExternallyFulfilledBy { get; set; }
    }

    public class WebhookSubscribeResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class WebhookSubscribeInput
    {
        [JsonProperty("friendly_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FriendlyName { get; set; }

        [JsonProperty("target_url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Event { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shipstation;

    public partial class WorkflowManagedActions
    {
        public ShipstationActions Shipstation(string connectionId) => new ShipstationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShipstationTriggers Shipstation(string connectionId) => new ShipstationTriggers(connectionId);
    }
}