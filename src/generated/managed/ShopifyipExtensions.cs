//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shopifyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShopifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopifyip")]
        public IBodyWorkflowAction<RetrieveAllOrdersResponse> RetrieveAllOrders(Expression<Func<string>> ids = null, Expression<Func<string>> limit = null, Expression<Func<string>> sinceId = null, Expression<Func<string>> createdAtMin = null, Expression<Func<string>> createdAtMax = null, Expression<Func<string>> updatedAtMin = null, Expression<Func<string>> updatedAtMax = null, Expression<Func<string>> processedAtMin = null, Expression<Func<string>> processedAtMax = null, Expression<Func<string>> attributionAppId = null, Expression<Func<string>> status = null, Expression<Func<string>> financialStatus = null, Expression<Func<string>> fulfillmentStatus = null, Expression<Func<string>> fields = null, Expression<Func<string>> order = null)
        {
            var apiCallPath = "/admin/api/2021-04/orders.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sinceId != null)
                callPayload.Queries["since_id"] = ExpressionConverter.Convert(sinceId);
            if (createdAtMin != null)
                callPayload.Queries["created_at_min"] = ExpressionConverter.Convert(createdAtMin);
            if (createdAtMax != null)
                callPayload.Queries["created_at_max"] = ExpressionConverter.Convert(createdAtMax);
            if (updatedAtMin != null)
                callPayload.Queries["updated_at_min"] = ExpressionConverter.Convert(updatedAtMin);
            if (updatedAtMax != null)
                callPayload.Queries["updated_at_max"] = ExpressionConverter.Convert(updatedAtMax);
            if (processedAtMin != null)
                callPayload.Queries["processed_at_min"] = ExpressionConverter.Convert(processedAtMin);
            if (processedAtMax != null)
                callPayload.Queries["processed_at_max"] = ExpressionConverter.Convert(processedAtMax);
            if (attributionAppId != null)
                callPayload.Queries["attribution_app_id"] = ExpressionConverter.Convert(attributionAppId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (financialStatus != null)
                callPayload.Queries["financial_status"] = ExpressionConverter.Convert(financialStatus);
            if (fulfillmentStatus != null)
                callPayload.Queries["fulfillment_status"] = ExpressionConverter.Convert(fulfillmentStatus);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (order != null)
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            return new ApiConnectionAction<RetrieveAllOrdersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopifyip")]
        public IBodyWorkflowAction<Order> UpdateAnOrder(Expression<Func<string>> orderId)
        {
            var apiCallPath = String.Format("/admin/api/2021-04/orders/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(orderId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Order>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopifyip")]
        public IBodyWorkflowAction<Order> CancelAnOrder(Expression<Func<string>> orderId, Expression<Func<string>> amount = null, Expression<Func<string>> currency = null, Expression<Func<string>> restock = null, Expression<Func<string>> reason = null, Expression<Func<string>> email = null, Expression<Func<string>> refund = null)
        {
            var apiCallPath = String.Format("/admin/api/2021-04/orders/{0}/cancel.json", ExpressionConverter.ConvertWithUrlEncoding(orderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (amount != null)
                callPayload.Queries["amount"] = ExpressionConverter.Convert(amount);
            if (currency != null)
                callPayload.Queries["currency"] = ExpressionConverter.Convert(currency);
            if (restock != null)
                callPayload.Queries["restock"] = ExpressionConverter.Convert(restock);
            if (reason != null)
                callPayload.Queries["reason"] = ExpressionConverter.Convert(reason);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (refund != null)
                callPayload.Queries["refund"] = ExpressionConverter.Convert(refund);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Order>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shopifyip")]
        public IBodyWorkflowAction<RetrieveListOfCustomersResponse> RetrieveListOfCustomers(Expression<Func<string>> ids = null, Expression<Func<string>> sinceId = null, Expression<Func<string>> createdAtMin = null, Expression<Func<string>> createdAtMax = null, Expression<Func<string>> updatedAtMin = null, Expression<Func<string>> updatedAtMax = null, Expression<Func<string>> limit = null, Expression<Func<string>> fields = null)
        {
            var apiCallPath = "/admin/api/2021-04/customers.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (sinceId != null)
                callPayload.Queries["since_id"] = ExpressionConverter.Convert(sinceId);
            if (createdAtMin != null)
                callPayload.Queries["created_at_min"] = ExpressionConverter.Convert(createdAtMin);
            if (createdAtMax != null)
                callPayload.Queries["created_at_max"] = ExpressionConverter.Convert(createdAtMax);
            if (updatedAtMin != null)
                callPayload.Queries["updated_at_min"] = ExpressionConverter.Convert(updatedAtMin);
            if (updatedAtMax != null)
                callPayload.Queries["updated_at_max"] = ExpressionConverter.Convert(updatedAtMax);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<RetrieveListOfCustomersResponse>(callPayload);
        }
    }

    public class ShopifyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrieveAllOrdersResponse
    {
        [JsonProperty("orders")]
        public Order[] Orders { get; set; }
    }

    public class Order
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("total_price")]
        public string TotalPrice { get; set; }

        [JsonProperty("subtotal_price")]
        public string SubtotalPrice { get; set; }

        [JsonProperty("total_weight")]
        public int TotalWeight { get; set; }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        [JsonProperty("taxes_included")]
        public bool TaxesIncluded { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("total_discounts")]
        public string TotalDiscounts { get; set; }

        [JsonProperty("total_line_items_price")]
        public string TotalLineItemsPrice { get; set; }

        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        [JsonProperty("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }

        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        [JsonProperty("total_price_usd")]
        public string TotalPriceUsd { get; set; }

        [JsonProperty("checkout_token")]
        public string CheckoutToken { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        [JsonProperty("source_identifier")]
        public string SourceIdentifier { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("processed_at")]
        public string ProcessedAt { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("customer_locale")]
        public string CustomerLocale { get; set; }

        [JsonProperty("app_id")]
        public int AppId { get; set; }

        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonProperty("landing_site_ref")]
        public string LandingSiteRef { get; set; }

        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        [JsonProperty("discount_applications")]
        public DiscountApplication[] DiscountApplications { get; set; }

        [JsonProperty("discount_codes")]
        public DiscountCode[] DiscountCodes { get; set; }

        [JsonProperty("note_attributes")]
        public NoteAttribute[] NoteAttributes { get; set; }

        [JsonProperty("payment_gateway_names")]
        public string[] PaymentGatewayNames { get; set; }

        [JsonProperty("processing_method")]
        public string ProcessingMethod { get; set; }

        [JsonProperty("checkout_id")]
        public int CheckoutId { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("tax_lines")]
        public TaxLine[] TaxLines { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        [JsonProperty("order_status_url")]
        public string OrderStatusUrl { get; set; }

        [JsonProperty("presentment_currency")]
        public string PresentmentCurrency { get; set; }

        [JsonProperty("total_line_items_price_set")]
        public SubtotalTaxDiscountPriceSet TotalLineItemsPriceSet { get; set; }

        [JsonProperty("total_discounts_set")]
        public SubtotalTaxDiscountPriceSet TotalDiscountsSet { get; set; }

        [JsonProperty("total_shipping_price_set")]
        public SubtotalTaxDiscountPriceSet TotalShippingPriceSet { get; set; }

        [JsonProperty("subtotal_price_set")]
        public SubtotalTaxDiscountPriceSet SubtotalPriceSet { get; set; }

        [JsonProperty("total_price_set")]
        public SubtotalTaxDiscountPriceSet TotalPriceSet { get; set; }

        [JsonProperty("total_tax_set")]
        public SubtotalTaxDiscountPriceSet TotalTaxSet { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }

        [JsonProperty("shipping_lines")]
        public ShippingLine[] ShippingLines { get; set; }

        [JsonProperty("billing_address")]
        public BillingAddress BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }

        [JsonProperty("client_details")]
        public ClientDetail ClientDetails { get; set; }

        [JsonProperty("payment_details")]
        public PaymentDetail PaymentDetails { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("line_items")]
        public LineItem[] LineItems { get; set; }

        [JsonProperty("fulfillments")]
        public Fulfillment[] Fulfillments { get; set; }

        [JsonProperty("refunds")]
        public Refund[] Refunds { get; set; }
    }

    public class DiscountApplication
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("value_type")]
        public string ValueType { get; set; }

        [JsonProperty("allocation_method")]
        public string AllocationMethod { get; set; }

        [JsonProperty("target_selection")]
        public string TargetSelection { get; set; }

        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DiscountCode
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class NoteAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class TaxLine
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price_set")]
        public SubtotalTaxDiscountPriceSet PriceSet { get; set; }
    }

    public class SubtotalTaxDiscountPriceSet
    {
        [JsonProperty("shop_money")]
        public SubtotalTaxDiscountPriceSetShopMoneyType ShopMoney { get; set; }

        [JsonProperty("presentment_money")]
        public SubtotalTaxDiscountPriceSetPresentmentMoneyType PresentmentMoney { get; set; }
    }

    public class SubtotalTaxDiscountPriceSetShopMoneyType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

    public class SubtotalTaxDiscountPriceSetPresentmentMoneyType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

    public class ShippingLine
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("requested_fulfillment_service_id")]
        public string RequestedFulfillmentServiceId { get; set; }

        [JsonProperty("delivery_category")]
        public string DeliveryCategory { get; set; }

        [JsonProperty("carrier_identifier")]
        public string CarrierIdentifier { get; set; }

        [JsonProperty("discounted_price")]
        public string DiscountedPrice { get; set; }

        [JsonProperty("price_set")]
        public SubtotalTaxDiscountPriceSet PriceSet { get; set; }

        [JsonProperty("discounted_price_set")]
        public SubtotalTaxDiscountPriceSet DiscountedPriceSet { get; set; }

        [JsonProperty("discount_allocations")]
        public JToken[] DiscountAllocations { get; set; }

        [JsonProperty("tax_lines")]
        public TaxLine[] TaxLines { get; set; }
    }

    public class BillingAddress
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }
    }

    public class ShippingAddress
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }
    }

    public class ClientDetail
    {
        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonProperty("accept_language")]
        public string AcceptLanguage { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("session_hash")]
        public string SessionHash { get; set; }

        [JsonProperty("browser_width")]
        public int BrowserWidth { get; set; }

        [JsonProperty("browser_height")]
        public int BrowserHeight { get; set; }
    }

    public class PaymentDetail
    {
        [JsonProperty("credit_card_bin")]
        public string CreditCardBin { get; set; }

        [JsonProperty("avs_result_code")]
        public string AvsResultCode { get; set; }

        [JsonProperty("cvv_result_code")]
        public string CvvResultCode { get; set; }

        [JsonProperty("credit_card_number")]
        public string CreditCardNumber { get; set; }

        [JsonProperty("credit_card_company")]
        public string CreditCardCompany { get; set; }
    }

    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("orders_count")]
        public int OrdersCount { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("total_spent")]
        public string TotalSpent { get; set; }

        [JsonProperty("last_order_id")]
        public int LastOrderId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("verified_email")]
        public bool VerifiedEmail { get; set; }

        [JsonProperty("multipass_identifier")]
        public string MultipassIdentifier { get; set; }

        [JsonProperty("tax_exempt")]
        public bool TaxExempt { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("last_order_name")]
        public string LastOrderName { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("addresses")]
        public DefaultAddress[] Addresses { get; set; }

        [JsonProperty("accepts_marketing_updated_at")]
        public string AcceptsMarketingUpdatedAt { get; set; }

        [JsonProperty("marketing_opt_in_level")]
        public string MarketingOptInLevel { get; set; }

        [JsonProperty("tax_exemptions")]
        public JToken[] TaxExemptions { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }

        [JsonProperty("default_address")]
        public DefaultAddress DefaultAddress { get; set; }
    }

    public class DefaultAddress
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }
    }

    public class LineItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("variant_title")]
        public string VariantTitle { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("gift_card")]
        public bool GiftCard { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("variant_inventory_management")]
        public string VariantInventoryManagement { get; set; }

        [JsonProperty("properties")]
        public LineItemProperty[] Properties { get; set; }

        [JsonProperty("product_exists")]
        public bool ProductExists { get; set; }

        [JsonProperty("fulfillable_quantity")]
        public int FulfillableQuantity { get; set; }

        [JsonProperty("grams")]
        public int Grams { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("total_discount")]
        public string TotalDiscount { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("price_set")]
        public SubtotalTaxDiscountPriceSet PriceSet { get; set; }

        [JsonProperty("total_discount_set")]
        public SubtotalTaxDiscountPriceSet TotalDiscountSet { get; set; }

        [JsonProperty("discount_allocations")]
        public JToken[] DiscountAllocations { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }

        [JsonProperty("tax_lines")]
        public TaxLine[] TaxLines { get; set; }
    }

    public class LineItemProperty
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Fulfillment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("tracking_company")]
        public string TrackingCompany { get; set; }

        [JsonProperty("shipment_status")]
        public string ShipmentStatus { get; set; }

        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_numbers")]
        public string[] TrackingNumbers { get; set; }

        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        [JsonProperty("tracking_urls")]
        public string[] TrackingUrls { get; set; }

        [JsonProperty("receipt")]
        public Receipt Receipt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }

        [JsonProperty("line_items")]
        public LineItem[] LineItems { get; set; }
    }

    public class Receipt
    {
        [JsonProperty("testcase")]
        public bool Testcase { get; set; }

        [JsonProperty("authorization")]
        public string Authorization { get; set; }
    }

    public class Refund
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("processed_at")]
        public string ProcessedAt { get; set; }

        [JsonProperty("restock")]
        public bool Restock { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        [JsonProperty("order_adjustments")]
        public JToken[] OrderAdjustments { get; set; }
    }

    public class Transaction
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("authorization")]
        public string Authorization { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("processed_at")]
        public string ProcessedAt { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("receipt")]
        public JToken Receipt { get; set; }

        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string AdminGraphqlApiId { get; set; }
    }

    public class RetrieveListOfCustomersResponse
    {
        [JsonProperty("customers")]
        public Customer[] Customers { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shopifyip;

    public partial class WorkflowManagedActions
    {
        public ShopifyipActions Shopifyip(string connectionId) => new ShopifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShopifyipTriggers Shopifyip(string connectionId) => new ShopifyipTriggers(connectionId);
    }
}