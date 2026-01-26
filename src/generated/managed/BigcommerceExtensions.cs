//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bigcommerce
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BigcommerceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bigcommerce")]
        public IBodyWorkflowAction<OrderResp[]> GetAllOrders(Expression<Func<string>> storeHash, Expression<Func<int>> minId = null, Expression<Func<int>> maxId = null, Expression<Func<double>> minTotal = null, Expression<Func<double>> maxTotal = null, Expression<Func<int>> customerId = null, Expression<Func<string>> email = null, Expression<Func<int>> statusId = null, Expression<Func<string>> cartId = null, Expression<Func<paymentMethodInput>> paymentMethod = null, Expression<Func<string>> minDateCreated = null, Expression<Func<string>> maxDateCreated = null, Expression<Func<string>> minDateModified = null, Expression<Func<string>> maxDateModified = null, Expression<Func<double>> page = null, Expression<Func<double>> limit = null, Expression<Func<sortInput>> sort = null, Expression<Func<bool>> isDeleted = null, Expression<Func<bool>> channelId = null)
        {
            var apiCallPath = String.Format("/{0}/v2/orders", ExpressionConverter.ConvertWithUrlEncoding(storeHash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (minId != null)
                callPayload.Queries["min_id"] = ExpressionConverter.Convert(minId);
            if (maxId != null)
                callPayload.Queries["max_id"] = ExpressionConverter.Convert(maxId);
            if (minTotal != null)
                callPayload.Queries["min_total"] = ExpressionConverter.Convert(minTotal);
            if (maxTotal != null)
                callPayload.Queries["max_total"] = ExpressionConverter.Convert(maxTotal);
            if (customerId != null)
                callPayload.Queries["customer_id"] = ExpressionConverter.Convert(customerId);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (statusId != null)
                callPayload.Queries["status_id"] = ExpressionConverter.Convert(statusId);
            if (cartId != null)
                callPayload.Queries["cart_id"] = ExpressionConverter.Convert(cartId);
            if (paymentMethod != null)
                callPayload.Queries["payment_method"] = ExpressionConverter.Convert(paymentMethod);
            if (minDateCreated != null)
                callPayload.Queries["min_date_created"] = ExpressionConverter.Convert(minDateCreated);
            if (maxDateCreated != null)
                callPayload.Queries["max_date_created"] = ExpressionConverter.Convert(maxDateCreated);
            if (minDateModified != null)
                callPayload.Queries["min_date_modified"] = ExpressionConverter.Convert(minDateModified);
            if (maxDateModified != null)
                callPayload.Queries["max_date_modified"] = ExpressionConverter.Convert(maxDateModified);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (isDeleted != null)
                callPayload.Queries["is_deleted"] = ExpressionConverter.Convert(isDeleted);
            if (channelId != null)
                callPayload.Queries["channel_id"] = ExpressionConverter.Convert(channelId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<OrderResp[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bigcommerce")]
        public IBodyWorkflowAction<OrderResp> UpdateAnOrder(Expression<Func<string>> storeHash, Expression<Func<int>> orderId)
        {
            var apiCallPath = String.Format("/{0}/v2/orders/{1}", ExpressionConverter.ConvertWithUrlEncoding(storeHash, 1), ExpressionConverter.ConvertWithUrlEncoding(orderId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OrderResp>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bigcommerce")]
        public IBodyWorkflowAction<OrderProductResp[]> GetAllOrderProducts(Expression<Func<string>> storeHash, Expression<Func<string>> orderId, Expression<Func<double>> page = null, Expression<Func<double>> limit = null)
        {
            var apiCallPath = String.Format("/{0}/v2/orders/{1}/products", ExpressionConverter.ConvertWithUrlEncoding(storeHash, 1), ExpressionConverter.ConvertWithUrlEncoding(orderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<OrderProductResp[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bigcommerce")]
        public IBodyWorkflowAction<OrderShippingAddressResp[]> GetAllOrderShippingAddresses(Expression<Func<string>> storeHash, Expression<Func<string>> orderId, Expression<Func<double>> page = null, Expression<Func<double>> limit = null)
        {
            var apiCallPath = String.Format("/{0}/v2/orders/{1}/shipping_addresses", ExpressionConverter.ConvertWithUrlEncoding(storeHash, 1), ExpressionConverter.ConvertWithUrlEncoding(orderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<OrderShippingAddressResp[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bigcommerce")]
        public IBodyWorkflowAction<ProductCollectionResponse> GetProducts(Expression<Func<string>> storeHash, Expression<Func<int>> id = null, Expression<Func<string>> name = null, Expression<Func<string>> upc = null, Expression<Func<double>> price = null, Expression<Func<double>> weight = null, Expression<Func<conditionInput>> condition = null, Expression<Func<int>> brandId = null, Expression<Func<string>> dateModified = null, Expression<Func<string>> dateModifiedMax = null, Expression<Func<string>> dateModifiedMin = null, Expression<Func<string>> dateLastImported = null, Expression<Func<string>> dateLastImportedMax = null, Expression<Func<string>> dateLastImportedMin = null, Expression<Func<bool>> isVisible = null, Expression<Func<isFeaturedInput>> isFeatured = null, Expression<Func<int>> isFreeShipping = null, Expression<Func<int>> inventoryLevel = null, Expression<Func<int>> inventoryLevelIn = null, Expression<Func<int>> inventoryLevelNotIn = null, Expression<Func<int>> inventoryLevelMin = null, Expression<Func<int>> inventoryLevelMax = null, Expression<Func<int>> inventoryLevelGreater = null, Expression<Func<int>> inventoryLevelLess = null, Expression<Func<int>> inventoryLow = null, Expression<Func<int>> outOfStock = null, Expression<Func<int>> totalSold = null, Expression<Func<typeInput>> type = null, Expression<Func<int>> categories = null, Expression<Func<string>> keyword = null, Expression<Func<keywordContextInput>> keywordContext = null, Expression<Func<int>> status = null, Expression<Func<includeInput>> include = null, Expression<Func<string>> includeFields = null, Expression<Func<string>> excludeFields = null, Expression<Func<availabilityInput>> availability = null, Expression<Func<int>> page = null, Expression<Func<int>> limit = null, Expression<Func<directionInput>> direction = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> categoriesIn = null)
        {
            var apiCallPath = String.Format("/{0}/v3/catalog/products", ExpressionConverter.ConvertWithUrlEncoding(storeHash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (upc != null)
                callPayload.Queries["upc"] = ExpressionConverter.Convert(upc);
            if (price != null)
                callPayload.Queries["price"] = ExpressionConverter.Convert(price);
            if (weight != null)
                callPayload.Queries["weight"] = ExpressionConverter.Convert(weight);
            if (condition != null)
                callPayload.Queries["condition"] = ExpressionConverter.Convert(condition);
            if (brandId != null)
                callPayload.Queries["brand_id"] = ExpressionConverter.Convert(brandId);
            if (dateModified != null)
                callPayload.Queries["date_modified"] = ExpressionConverter.Convert(dateModified);
            if (dateModifiedMax != null)
                callPayload.Queries["date_modified:max"] = ExpressionConverter.Convert(dateModifiedMax);
            if (dateModifiedMin != null)
                callPayload.Queries["date_modified:min"] = ExpressionConverter.Convert(dateModifiedMin);
            if (dateLastImported != null)
                callPayload.Queries["date_last_imported"] = ExpressionConverter.Convert(dateLastImported);
            if (dateLastImportedMax != null)
                callPayload.Queries["date_last_imported:max"] = ExpressionConverter.Convert(dateLastImportedMax);
            if (dateLastImportedMin != null)
                callPayload.Queries["date_last_imported:min"] = ExpressionConverter.Convert(dateLastImportedMin);
            if (isVisible != null)
                callPayload.Queries["is_visible"] = ExpressionConverter.Convert(isVisible);
            if (isFeatured != null)
                callPayload.Queries["is_featured"] = ExpressionConverter.Convert(isFeatured);
            if (isFreeShipping != null)
                callPayload.Queries["is_free_shipping"] = ExpressionConverter.Convert(isFreeShipping);
            if (inventoryLevel != null)
                callPayload.Queries["inventory_level"] = ExpressionConverter.Convert(inventoryLevel);
            if (inventoryLevelIn != null)
                callPayload.Queries["inventory_level:in"] = ExpressionConverter.Convert(inventoryLevelIn);
            if (inventoryLevelNotIn != null)
                callPayload.Queries["inventory_level:not_in"] = ExpressionConverter.Convert(inventoryLevelNotIn);
            if (inventoryLevelMin != null)
                callPayload.Queries["inventory_level:min"] = ExpressionConverter.Convert(inventoryLevelMin);
            if (inventoryLevelMax != null)
                callPayload.Queries["inventory_level:max"] = ExpressionConverter.Convert(inventoryLevelMax);
            if (inventoryLevelGreater != null)
                callPayload.Queries["inventory_level:greater"] = ExpressionConverter.Convert(inventoryLevelGreater);
            if (inventoryLevelLess != null)
                callPayload.Queries["inventory_level:less"] = ExpressionConverter.Convert(inventoryLevelLess);
            if (inventoryLow != null)
                callPayload.Queries["inventory_low"] = ExpressionConverter.Convert(inventoryLow);
            if (outOfStock != null)
                callPayload.Queries["out_of_stock"] = ExpressionConverter.Convert(outOfStock);
            if (totalSold != null)
                callPayload.Queries["total_sold"] = ExpressionConverter.Convert(totalSold);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (categories != null)
                callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
            if (keyword != null)
                callPayload.Queries["keyword"] = ExpressionConverter.Convert(keyword);
            if (keywordContext != null)
                callPayload.Queries["keyword_context"] = ExpressionConverter.Convert(keywordContext);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (include != null)
                callPayload.Queries["include"] = ExpressionConverter.Convert(include);
            if (includeFields != null)
                callPayload.Queries["include_fields"] = ExpressionConverter.Convert(includeFields);
            if (excludeFields != null)
                callPayload.Queries["exclude_fields"] = ExpressionConverter.Convert(excludeFields);
            if (availability != null)
                callPayload.Queries["availability"] = ExpressionConverter.Convert(availability);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (direction != null)
                callPayload.Queries["direction"] = ExpressionConverter.Convert(direction);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (categoriesIn != null)
                callPayload.Queries["categories:in"] = ExpressionConverter.Convert(categoriesIn);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ProductCollectionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bigcommerce")]
        public IBodyWorkflowAction<CustomerCollectionResponse> GetCustomers(Expression<Func<string>> storeHash, Expression<Func<double>> limit = null, Expression<Func<int[]>> idIn = null, Expression<Func<int[]>> customerGroupIdIn = null, Expression<Func<string>> dateModified = null, Expression<Func<string>> dateModifiedMin = null, Expression<Func<string>> dateModifiedMax = null, Expression<Func<string>> include = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = String.Format("/{0}/v3/customers", ExpressionConverter.ConvertWithUrlEncoding(storeHash, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (idIn != null)
                callPayload.Queries["id:in"] = ExpressionConverter.Convert(idIn);
            if (customerGroupIdIn != null)
                callPayload.Queries["customer_group_id:in"] = ExpressionConverter.Convert(customerGroupIdIn);
            if (dateModified != null)
                callPayload.Queries["date_modified"] = ExpressionConverter.Convert(dateModified);
            if (dateModifiedMin != null)
                callPayload.Queries["date_modified:min"] = ExpressionConverter.Convert(dateModifiedMin);
            if (dateModifiedMax != null)
                callPayload.Queries["date_modified:max"] = ExpressionConverter.Convert(dateModifiedMax);
            if (include != null)
                callPayload.Queries["include"] = ExpressionConverter.Convert(include);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<CustomerCollectionResponse>(callPayload);
        }
    }

    public class BigcommerceTriggers([ConnectionName] string connectionId)
    {
    }

    public class OrderResp
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("date_shipped")]
        public string DateShipped { get; set; }

        [JsonProperty("cart_id")]
        public string CartId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subtotal_tax")]
        public string SubtotalTax { get; set; }

        [JsonProperty("shipping_cost_tax")]
        public string ShippingCostTax { get; set; }

        [JsonProperty("shipping_cost_tax_class_id")]
        public int ShippingCostTaxClassId { get; set; }

        [JsonProperty("handling_cost_tax")]
        public string HandlingCostTax { get; set; }

        [JsonProperty("handling_cost_tax_class_id")]
        public int HandlingCostTaxClassId { get; set; }

        [JsonProperty("wrapping_cost_tax")]
        public string WrappingCostTax { get; set; }

        [JsonProperty("wrapping_cost_tax_class_id")]
        public int WrappingCostTaxClassId { get; set; }

        [JsonProperty("payment_status")]
        public PaymentStatus PaymentStatus { get; set; }

        [JsonProperty("store_credit_amount")]
        public string StoreCreditAmount { get; set; }

        [JsonProperty("gift_certificate_amount")]
        public string GiftCertificateAmount { get; set; }

        [JsonProperty("currency_id")]
        public int CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_exchange_rate")]
        public string CurrencyExchangeRate { get; set; }

        [JsonProperty("default_currency_id")]
        public int DefaultCurrencyId { get; set; }

        [JsonProperty("coupon_discount")]
        public string CouponDiscount { get; set; }

        [JsonProperty("shipping_address_count")]
        public double ShippingAddressCount { get; set; }

        [JsonProperty("is_email_opt_in")]
        public bool IsEmailOptIn { get; set; }

        [JsonProperty("order_source")]
        public string OrderSource { get; set; }

        [JsonProperty("products")]
        public ProductsResource Products { get; set; }

        [JsonProperty("shipping_addresses")]
        public ShippingAddressResource ShippingAddresses { get; set; }

        [JsonProperty("coupons")]
        public CouponsResource Coupons { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; }

        [JsonProperty("base_handling_cost")]
        public string BaseHandlingCost { get; set; }

        [JsonProperty("base_shipping_cost")]
        public string BaseShippingCost { get; set; }

        [JsonProperty("base_wrapping_cost")]
        public string BaseWrappingCost { get; set; }

        [JsonProperty("billing_address")]
        public BillingAddressFull BillingAddress { get; set; }

        [JsonProperty("channel_id")]
        public int ChannelId { get; set; }

        [JsonProperty("customer_id")]
        public double CustomerId { get; set; }

        [JsonProperty("customer_message")]
        public string CustomerMessage { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("default_currency_code")]
        public string DefaultCurrencyCode { get; set; }

        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        [JsonProperty("ebay_order_id")]
        public string EbayOrderId { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("external_source")]
        public string ExternalSource { get; set; }

        [JsonProperty("geoip_country")]
        public string GeoipCountry { get; set; }

        [JsonProperty("geoip_country_iso2")]
        public string GeoipCountryIso2 { get; set; }

        [JsonProperty("handling_cost_ex_tax")]
        public string HandlingCostExTax { get; set; }

        [JsonProperty("handling_cost_inc_tax")]
        public string HandlingCostIncTax { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("is_deleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("items_shipped")]
        public double ItemsShipped { get; set; }

        [JsonProperty("items_total")]
        public double ItemsTotal { get; set; }

        [JsonProperty("order_is_digital")]
        public bool OrderIsDigital { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonProperty("payment_provider_id")]
        public string PaymentProviderId { get; set; }

        [JsonProperty("refunded_amount")]
        public string RefundedAmount { get; set; }

        [JsonProperty("shipping_cost_ex_tax")]
        public string ShippingCostExTax { get; set; }

        [JsonProperty("shipping_cost_inc_tax")]
        public string ShippingCostIncTax { get; set; }

        [JsonProperty("staff_notes")]
        public string StaffNotes { get; set; }

        [JsonProperty("subtotal_ex_tax")]
        public string SubtotalExTax { get; set; }

        [JsonProperty("subtotal_inc_tax")]
        public string SubtotalIncTax { get; set; }

        [JsonProperty("tax_provider_id")]
        public TaxProviderId TaxProviderId { get; set; }

        [JsonProperty("customer_locale")]
        public string CustomerLocale { get; set; }

        [JsonProperty("total_ex_tax")]
        public string TotalExTax { get; set; }

        [JsonProperty("total_inc_tax")]
        public string TotalIncTax { get; set; }

        [JsonProperty("wrapping_cost_ex_tax")]
        public string WrappingCostExTax { get; set; }

        [JsonProperty("wrapping_cost_inc_tax")]
        public string WrappingCostIncTax { get; set; }
    }

    public enum PaymentStatus
    {
        [EnumMember(Value = "authorized")]
        Authorized,
        [EnumMember(Value = "captured")]
        Captured,
        [EnumMember(Value = "capture pending")]
        CapturePending,
        [EnumMember(Value = "declined")]
        Declined,
        [EnumMember(Value = "held for review")]
        HeldForReview,
        [EnumMember(Value = "paid")]
        Paid,
        [EnumMember(Value = "partially refunded")]
        PartiallyRefunded,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "refunded")]
        Refunded,
        [EnumMember(Value = "void")]
        Void,
        [EnumMember(Value = "void pending")]
        VoidPending
    }

    public class ProductsResource
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class ShippingAddressResource
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class CouponsResource
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class BillingAddressFull
    {
        [JsonProperty("billingAddress")]
        public BillingAddressBase BillingAddress { get; set; }

        [JsonProperty("form_fields")]
        public FormFields[] FormFields { get; set; }
    }

    public class BillingAddressBase
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class FormFields
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum PaymentMethod
    {
        [EnumMember(Value = "Credit Card")]
        CreditCard,
        Cash,
        [EnumMember(Value = "Test Payment Gateway")]
        TestPaymentGateway,
        Manual
    }

    public enum TaxProviderId
    {
        BasicTaxProvider,
        AvaTaxProvider
    }

    public enum paymentMethodInput
    {
        Manual,
        [EnumMember(Value = "Cash on Delivery")]
        CashOnDelivery,
        [EnumMember(Value = "Credit Card")]
        CreditCard,
        [EnumMember(Value = "Test Payment Gateway")]
        TestPaymentGateway,
        [EnumMember(Value = "Pay In Store")]
        PayInStore
    }

    public enum sortInput
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "sku")]
        Sku,
        [EnumMember(Value = "price")]
        Price,
        [EnumMember(Value = "date_modified")]
        DateModified,
        [EnumMember(Value = "date_last_imported")]
        DateLastImported,
        [EnumMember(Value = "inventory_level")]
        InventoryLevel,
        [EnumMember(Value = "is_visible")]
        IsVisible,
        [EnumMember(Value = "total_sold")]
        TotalSold
    }

    public class OrderProductResp
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("order_address_id")]
        public int OrderAddressId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("type")]
        public OrderProductRespTypeType Type { get; set; }

        [JsonProperty("base_price")]
        public string BasePrice { get; set; }

        [JsonProperty("price_ex_tax")]
        public string PriceExTax { get; set; }

        [JsonProperty("price_inc_tax")]
        public string PriceIncTax { get; set; }

        [JsonProperty("price_tax")]
        public string PriceTax { get; set; }

        [JsonProperty("base_total")]
        public string BaseTotal { get; set; }

        [JsonProperty("total_ex_tax")]
        public string TotalExTax { get; set; }

        [JsonProperty("total_inc_tax")]
        public string TotalIncTax { get; set; }

        [JsonProperty("total_tax")]
        public string TotalTax { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("base_cost_price")]
        public string BaseCostPrice { get; set; }

        [JsonProperty("cost_price_inc_tax")]
        public string CostPriceIncTax { get; set; }

        [JsonProperty("cost_price_ex_tax")]
        public string CostPriceExTax { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("cost_price_tax")]
        public string CostPriceTax { get; set; }

        [JsonProperty("is_refunded")]
        public bool IsRefunded { get; set; }

        [JsonProperty("refunded_amount")]
        public string RefundedAmount { get; set; }

        [JsonProperty("return_id")]
        public double ReturnId { get; set; }

        [JsonProperty("wrapping_name")]
        public string WrappingName { get; set; }

        [JsonProperty("base_wrapping_cost")]
        public string BaseWrappingCost { get; set; }

        [JsonProperty("wrapping_cost_ex_tax")]
        public string WrappingCostExTax { get; set; }

        [JsonProperty("wrapping_cost_inc_tax")]
        public string WrappingCostIncTax { get; set; }

        [JsonProperty("wrapping_cost_tax")]
        public string WrappingCostTax { get; set; }

        [JsonProperty("wrapping_message")]
        public string WrappingMessage { get; set; }

        [JsonProperty("quantity_shipped")]
        public double QuantityShipped { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_date")]
        public string EventDate { get; set; }

        [JsonProperty("fixed_shipping_cost")]
        public string FixedShippingCost { get; set; }

        [JsonProperty("ebay_item_id")]
        public string EbayItemId { get; set; }

        [JsonProperty("ebay_transaction_id")]
        public string EbayTransactionId { get; set; }

        [JsonProperty("option_set_id")]
        public int OptionSetId { get; set; }

        [JsonProperty("parent_order_product_id")]
        public int ParentOrderProductId { get; set; }

        [JsonProperty("is_bundled_product")]
        public bool IsBundledProduct { get; set; }

        [JsonProperty("bin_picking_number")]
        public string BinPickingNumber { get; set; }

        [JsonProperty("applied_discounts")]
        public OrderProductRespAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }

        [JsonProperty("product_options")]
        public OrderProductRespProductOptionsTypeItem[] ProductOptions { get; set; }

        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }

        [JsonProperty("variant_id")]
        public int VariantId { get; set; }

        [JsonProperty("name_customer")]
        public string NameCustomer { get; set; }

        [JsonProperty("name_merchant")]
        public string NameMerchant { get; set; }
    }

    public enum OrderProductRespTypeType
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "digital")]
        Digital
    }

    public class OrderProductRespAppliedDiscountsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("target")]
        public OrderProductRespAppliedDiscountsTypeItemTargetType Target { get; set; }
    }

    public enum OrderProductRespAppliedDiscountsTypeItemTargetType
    {
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "product")]
        Product
    }

    public class OrderProductRespProductOptionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("option_id")]
        public int OptionId { get; set; }

        [JsonProperty("order_product_id")]
        public int OrderProductId { get; set; }

        [JsonProperty("product_option_id")]
        public int ProductOptionId { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public OrderProductRespProductOptionsTypeItemTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_style")]
        public string DisplayStyle { get; set; }

        [JsonProperty("display_name_customer")]
        public string DisplayNameCustomer { get; set; }

        [JsonProperty("display_name_merchant")]
        public string DisplayNameMerchant { get; set; }

        [JsonProperty("display_value_customer")]
        public string DisplayValueCustomer { get; set; }

        [JsonProperty("display_value_merchant")]
        public string DisplayValueMerchant { get; set; }
    }

    public enum OrderProductRespProductOptionsTypeItemTypeType
    {
        Checkbox,
        [EnumMember(Value = "Date field")]
        DateField,
        [EnumMember(Value = "File Upload")]
        FileUpload,
        [EnumMember(Value = "Multi-line text field")]
        MultiLineTextField,
        [EnumMember(Value = "Multiple choice")]
        MultipleChoice,
        [EnumMember(Value = "Product Pick List")]
        ProductPickList,
        Swatch,
        [EnumMember(Value = "Text field")]
        TextField
    }

    public class OrderShippingAddressResp
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("items_total")]
        public double ItemsTotal { get; set; }

        [JsonProperty("items_shipped")]
        public double ItemsShipped { get; set; }

        [JsonProperty("base_cost")]
        public string BaseCost { get; set; }

        [JsonProperty("cost_ex_tax")]
        public string CostExTax { get; set; }

        [JsonProperty("cost_inc_tax")]
        public string CostIncTax { get; set; }

        [JsonProperty("cost_tax")]
        public string CostTax { get; set; }

        [JsonProperty("cost_tax_class_id")]
        public int CostTaxClassId { get; set; }

        [JsonProperty("handling_cost_ex_tax")]
        public string HandlingCostExTax { get; set; }

        [JsonProperty("handling_cost_inc_tax")]
        public string HandlingCostIncTax { get; set; }

        [JsonProperty("handling_cost_tax")]
        public string HandlingCostTax { get; set; }

        [JsonProperty("handling_cost_tax_class_id")]
        public int HandlingCostTaxClassId { get; set; }

        [JsonProperty("shipping_zone_id")]
        public double ShippingZoneId { get; set; }

        [JsonProperty("shipping_zone_name")]
        public string ShippingZoneName { get; set; }

        [JsonProperty("form_fields")]
        public FormFields[] FormFields { get; set; }

        [JsonProperty("shipping_quotes")]
        public ShippingQuotesResource ShippingQuotes { get; set; }

        [JsonProperty("shipping_addresses")]
        public ShippingAddressBase ShippingAddresses { get; set; }
    }

    public class ShippingQuotesResource
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class ShippingAddressBase
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("shipping_method")]
        public string ShippingMethod { get; set; }
    }

    public class ProductCollectionResponse
    {
        [JsonProperty("data")]
        public ProductFull[] Data { get; set; }

        [JsonProperty("meta")]
        public MetaCollectionFull Meta { get; set; }
    }

    public class ProductFull
    {
        [JsonProperty("schema")]
        public ProductBase Schema { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("base_variant_id")]
        public int BaseVariantId { get; set; }

        [JsonProperty("calculated_price")]
        public double CalculatedPrice { get; set; }

        [JsonProperty("options")]
        public ProductOptionBase[] Options { get; set; }

        [JsonProperty("modifiers")]
        public ProductModifierFull[] Modifiers { get; set; }

        [JsonProperty("option_set_id")]
        public int OptionSetId { get; set; }

        [JsonProperty("option_set_display")]
        public string OptionSetDisplay { get; set; }

        [JsonProperty("variants")]
        public ProductVariantFull Variants { get; set; }
    }

    public class ProductBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public ProductBaseTypeType Type { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("cost_price")]
        public double CostPrice { get; set; }

        [JsonProperty("retail_price")]
        public double RetailPrice { get; set; }

        [JsonProperty("sale_price")]
        public double SalePrice { get; set; }

        [JsonProperty("map_price")]
        public double MapPrice { get; set; }

        [JsonProperty("tax_class_id")]
        public int TaxClassId { get; set; }

        [JsonProperty("product_tax_code")]
        public string ProductTaxCode { get; set; }

        [JsonProperty("categories")]
        public int[] Categories { get; set; }

        [JsonProperty("brand_id")]
        public int BrandId { get; set; }

        [JsonProperty("inventory_level")]
        public int InventoryLevel { get; set; }

        [JsonProperty("inventory_warning_level")]
        public int InventoryWarningLevel { get; set; }

        [JsonProperty("inventory_tracking")]
        public ProductBaseInventoryTrackingType InventoryTracking { get; set; }

        [JsonProperty("fixed_cost_shipping_price")]
        public double FixedCostShippingPrice { get; set; }

        [JsonProperty("is_free_shipping")]
        public bool IsFreeShipping { get; set; }

        [JsonProperty("is_visible")]
        public bool IsVisible { get; set; }

        [JsonProperty("is_featured")]
        public bool IsFeatured { get; set; }

        [JsonProperty("related_products")]
        public int[] RelatedProducts { get; set; }

        [JsonProperty("warranty")]
        public string Warranty { get; set; }

        [JsonProperty("bin_picking_number")]
        public string BinPickingNumber { get; set; }

        [JsonProperty("layout_file")]
        public string LayoutFile { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }

        [JsonProperty("search_keywords")]
        public string SearchKeywords { get; set; }

        [JsonProperty("availability")]
        public ProductBaseAvailabilityType Availability { get; set; }

        [JsonProperty("availability_description")]
        public string AvailabilityDescription { get; set; }

        [JsonProperty("gift_wrapping_options_type")]
        public ProductBaseGiftWrappingOptionsTypeType GiftWrappingOptionsType { get; set; }

        [JsonProperty("gift_wrapping_options_list")]
        public int[] GiftWrappingOptionsList { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("condition")]
        public ProductBaseConditionType Condition { get; set; }

        [JsonProperty("is_condition_shown")]
        public bool IsConditionShown { get; set; }

        [JsonProperty("order_quantity_minimum")]
        public int OrderQuantityMinimum { get; set; }

        [JsonProperty("order_quantity_maximum")]
        public int OrderQuantityMaximum { get; set; }

        [JsonProperty("page_title")]
        public string PageTitle { get; set; }

        [JsonProperty("meta_keywords")]
        public string[] MetaKeywords { get; set; }

        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }

        [JsonProperty("view_count")]
        public int ViewCount { get; set; }

        [JsonProperty("preorder_release_date")]
        public string PreorderReleaseDate { get; set; }

        [JsonProperty("preorder_message")]
        public string PreorderMessage { get; set; }

        [JsonProperty("is_preorder_only")]
        public bool IsPreorderOnly { get; set; }

        [JsonProperty("is_price_hidden")]
        public bool IsPriceHidden { get; set; }

        [JsonProperty("price_hidden_label")]
        public string PriceHiddenLabel { get; set; }

        [JsonProperty("custom_url")]
        public CustomUrlFull CustomUrl { get; set; }

        [JsonProperty("open_graph_type")]
        public ProductBaseOpenGraphTypeType OpenGraphType { get; set; }

        [JsonProperty("open_graph_title")]
        public string OpenGraphTitle { get; set; }

        [JsonProperty("open_graph_description")]
        public string OpenGraphDescription { get; set; }

        [JsonProperty("open_graph_use_meta_description")]
        public bool OpenGraphUseMetaDescription { get; set; }

        [JsonProperty("open_graph_use_product_name")]
        public bool OpenGraphUseProductName { get; set; }

        [JsonProperty("open_graph_use_image")]
        public bool OpenGraphUseImage { get; set; }

        [JsonProperty("brand_name or brand_id")]
        public string BrandNameOrBrandId { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        [JsonProperty("reviews_rating_sum")]
        public int ReviewsRatingSum { get; set; }

        [JsonProperty("reviews_count")]
        public int ReviewsCount { get; set; }

        [JsonProperty("total_sold")]
        public int TotalSold { get; set; }

        [JsonProperty("custom_fields")]
        public ProductCustomFieldPut[] CustomFields { get; set; }

        [JsonProperty("bulk_pricing_rules")]
        public BulkPricingRuleFull[] BulkPricingRules { get; set; }

        [JsonProperty("images")]
        public ProductImageFull[] Images { get; set; }

        [JsonProperty("videos")]
        public ProductVideoFull[] Videos { get; set; }
    }

    public enum ProductBaseTypeType
    {
        [EnumMember(Value = "physical")]
        Physical,
        [EnumMember(Value = "digital")]
        Digital
    }

    public enum ProductBaseInventoryTrackingType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "variant")]
        Variant
    }

    public enum ProductBaseAvailabilityType
    {
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "preorder")]
        Preorder
    }

    public enum ProductBaseGiftWrappingOptionsTypeType
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "list")]
        List
    }

    public enum ProductBaseConditionType
    {
        New,
        Used,
        Refurbished
    }

    public class CustomUrlFull
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_customized")]
        public bool IsCustomized { get; set; }
    }

    public enum ProductBaseOpenGraphTypeType
    {
        [EnumMember(Value = "product")]
        Product,
        [EnumMember(Value = "album")]
        Album,
        [EnumMember(Value = "book")]
        Book,
        [EnumMember(Value = "drink")]
        Drink,
        [EnumMember(Value = "food")]
        Food,
        [EnumMember(Value = "game")]
        Game,
        [EnumMember(Value = "movie")]
        Movie,
        [EnumMember(Value = "song")]
        Song,
        [EnumMember(Value = "tv_show")]
        TvShow
    }

    public class ProductCustomFieldPut
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BulkPricingRuleFull
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quantity_min")]
        public int QuantityMin { get; set; }

        [JsonProperty("quantity_max")]
        public int QuantityMax { get; set; }

        [JsonProperty("type")]
        public BulkPricingRuleFullTypeType Type { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public enum BulkPricingRuleFullTypeType
    {
        [EnumMember(Value = "price")]
        Price,
        [EnumMember(Value = "percent")]
        Percent,
        [EnumMember(Value = "fixed")]
        Fixed
    }

    public class ProductImageFull
    {
        [JsonProperty("image_file")]
        public string ImageFile { get; set; }

        [JsonProperty("is_thumbnail")]
        public bool IsThumbnail { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("url_zoom")]
        public string UrlZoom { get; set; }

        [JsonProperty("url_standard")]
        public string UrlStandard { get; set; }

        [JsonProperty("url_thumbnail")]
        public string UrlThumbnail { get; set; }

        [JsonProperty("url_tiny")]
        public string UrlTiny { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ProductVideoFull
    {
        [JsonProperty("schema")]
        public ProductVideoBase Schema { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }
    }

    public class ProductVideoBase
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("type")]
        public ProductVideoBaseTypeType Type { get; set; }

        [JsonProperty("video_id")]
        public string VideoId { get; set; }
    }

    public enum ProductVideoBaseTypeType
    {
        [EnumMember(Value = "youtube")]
        Youtube
    }

    public class ProductOptionBase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public ProductOptionBaseTypeType Type { get; set; }

        [JsonProperty("config")]
        public ProductOptionConfigFull Config { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("option_values")]
        public ProductOptionOptionValueFull OptionValues { get; set; }
    }

    public enum ProductOptionBaseTypeType
    {
        [EnumMember(Value = "radio_buttons")]
        RadioButtons,
        [EnumMember(Value = "rectangles")]
        Rectangles,
        [EnumMember(Value = "dropdown")]
        Dropdown,
        [EnumMember(Value = "product_list")]
        ProductList,
        [EnumMember(Value = "product_list_with_images")]
        ProductListWithImages,
        [EnumMember(Value = "swatch")]
        Swatch
    }

    public class ProductOptionConfigFull
    {
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        [JsonProperty("checked_by_default")]
        public bool CheckedByDefault { get; set; }

        [JsonProperty("checkbox_label")]
        public string CheckboxLabel { get; set; }

        [JsonProperty("date_limited")]
        public bool DateLimited { get; set; }

        [JsonProperty("date_limit_mode")]
        public ProductOptionConfigFullDateLimitModeType DateLimitMode { get; set; }

        [JsonProperty("date_earliest_value")]
        public string DateEarliestValue { get; set; }

        [JsonProperty("date_latest_value")]
        public string DateLatestValue { get; set; }

        [JsonProperty("file_types_mode")]
        public ProductOptionConfigFullFileTypesModeType FileTypesMode { get; set; }

        [JsonProperty("file_types_supported")]
        public string[] FileTypesSupported { get; set; }

        [JsonProperty("file_types_other")]
        public string[] FileTypesOther { get; set; }

        [JsonProperty("file_max_size")]
        public int FileMaxSize { get; set; }

        [JsonProperty("text_characters_limited")]
        public bool TextCharactersLimited { get; set; }

        [JsonProperty("text_min_length")]
        public int TextMinLength { get; set; }

        [JsonProperty("text_max_length")]
        public int TextMaxLength { get; set; }

        [JsonProperty("text_lines_limited")]
        public bool TextLinesLimited { get; set; }

        [JsonProperty("text_max_lines")]
        public int TextMaxLines { get; set; }

        [JsonProperty("number_limited")]
        public bool NumberLimited { get; set; }

        [JsonProperty("number_limit_mode")]
        public ProductOptionConfigFullNumberLimitModeType NumberLimitMode { get; set; }

        [JsonProperty("number_lowest_value")]
        public double NumberLowestValue { get; set; }

        [JsonProperty("number_highest_value")]
        public double NumberHighestValue { get; set; }

        [JsonProperty("number_integers_only")]
        public bool NumberIntegersOnly { get; set; }

        [JsonProperty("product_list_adjusts_inventory")]
        public bool ProductListAdjustsInventory { get; set; }

        [JsonProperty("product_list_adjusts_pricing")]
        public bool ProductListAdjustsPricing { get; set; }

        [JsonProperty("product_list_shipping_calc")]
        public ProductOptionConfigFullProductListShippingCalcType ProductListShippingCalc { get; set; }
    }

    public enum ProductOptionConfigFullDateLimitModeType
    {
        [EnumMember(Value = "earliest")]
        Earliest,
        [EnumMember(Value = "range")]
        Range,
        [EnumMember(Value = "latest")]
        Latest
    }

    public enum ProductOptionConfigFullFileTypesModeType
    {
        [EnumMember(Value = "specific")]
        Specific,
        [EnumMember(Value = "all")]
        All
    }

    public enum ProductOptionConfigFullNumberLimitModeType
    {
        [EnumMember(Value = "lowest")]
        Lowest,
        [EnumMember(Value = "highest")]
        Highest,
        [EnumMember(Value = "range")]
        Range
    }

    public enum ProductOptionConfigFullProductListShippingCalcType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "weight")]
        Weight,
        [EnumMember(Value = "package")]
        Package
    }

    public class ProductOptionOptionValueFull
    {
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("value_data")]
        public JToken ValueData { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ProductModifierFull
    {
        [JsonProperty("schema")]
        public ProductModifierBase Schema { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("option_values")]
        public ProductModifierOptionValueFull[] OptionValues { get; set; }
    }

    public class ProductModifierBase
    {
        [JsonProperty("type")]
        public ProductModifierBaseTypeType Type { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("config")]
        public ConfigFull Config { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

    public enum ProductModifierBaseTypeType
    {
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "multi_line_text")]
        MultiLineText,
        [EnumMember(Value = "numbers_only_text")]
        NumbersOnlyText,
        [EnumMember(Value = "radio_buttons")]
        RadioButtons,
        [EnumMember(Value = "rectangles")]
        Rectangles,
        [EnumMember(Value = "dropdown")]
        Dropdown,
        [EnumMember(Value = "product_list")]
        ProductList,
        [EnumMember(Value = "product_list_with_images")]
        ProductListWithImages,
        [EnumMember(Value = "swatch")]
        Swatch
    }

    public class ConfigFull
    {
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        [JsonProperty("checked_by_default")]
        public bool CheckedByDefault { get; set; }

        [JsonProperty("checkbox_label")]
        public string CheckboxLabel { get; set; }

        [JsonProperty("date_limited")]
        public bool DateLimited { get; set; }

        [JsonProperty("date_limit_mode")]
        public ConfigFullDateLimitModeType DateLimitMode { get; set; }

        [JsonProperty("date_earliest_value")]
        public string DateEarliestValue { get; set; }

        [JsonProperty("date_latest_value")]
        public string DateLatestValue { get; set; }

        [JsonProperty("file_types_mode")]
        public ConfigFullFileTypesModeType FileTypesMode { get; set; }

        [JsonProperty("file_types_supported")]
        public string[] FileTypesSupported { get; set; }

        [JsonProperty("file_types_other")]
        public string[] FileTypesOther { get; set; }

        [JsonProperty("file_max_size")]
        public int FileMaxSize { get; set; }

        [JsonProperty("text_characters_limited")]
        public bool TextCharactersLimited { get; set; }

        [JsonProperty("text_min_length")]
        public int TextMinLength { get; set; }

        [JsonProperty("text_max_length")]
        public int TextMaxLength { get; set; }

        [JsonProperty("text_lines_limited")]
        public bool TextLinesLimited { get; set; }

        [JsonProperty("text_max_lines")]
        public int TextMaxLines { get; set; }

        [JsonProperty("number_limited")]
        public bool NumberLimited { get; set; }

        [JsonProperty("number_limit_mode")]
        public ConfigFullNumberLimitModeType NumberLimitMode { get; set; }

        [JsonProperty("number_lowest_value")]
        public double NumberLowestValue { get; set; }

        [JsonProperty("number_highest_value")]
        public double NumberHighestValue { get; set; }

        [JsonProperty("number_integers_only")]
        public bool NumberIntegersOnly { get; set; }

        [JsonProperty("product_list_adjusts_inventory")]
        public bool ProductListAdjustsInventory { get; set; }

        [JsonProperty("product_list_adjusts_pricing")]
        public bool ProductListAdjustsPricing { get; set; }

        [JsonProperty("product_list_shipping_calc")]
        public ConfigFullProductListShippingCalcType ProductListShippingCalc { get; set; }
    }

    public enum ConfigFullDateLimitModeType
    {
        [EnumMember(Value = "earliest")]
        Earliest,
        [EnumMember(Value = "range")]
        Range,
        [EnumMember(Value = "latest")]
        Latest
    }

    public enum ConfigFullFileTypesModeType
    {
        [EnumMember(Value = "specific")]
        Specific,
        [EnumMember(Value = "all")]
        All
    }

    public enum ConfigFullNumberLimitModeType
    {
        [EnumMember(Value = "lowest")]
        Lowest,
        [EnumMember(Value = "highest")]
        Highest,
        [EnumMember(Value = "range")]
        Range
    }

    public enum ConfigFullProductListShippingCalcType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "weight")]
        Weight,
        [EnumMember(Value = "package")]
        Package
    }

    public class ProductModifierOptionValueFull
    {
        [JsonProperty("is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }

        [JsonProperty("value_data")]
        public JToken ValueData { get; set; }

        [JsonProperty("adjusters")]
        public AdjustersFull Adjusters { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("option_id")]
        public int OptionId { get; set; }
    }

    public class AdjustersFull
    {
        [JsonProperty("price")]
        public AdjusterFull Price { get; set; }

        [JsonProperty("weight")]
        public AdjusterFull Weight { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("purchasing_disabled")]
        public PurchasingDisabled PurchasingDisabled { get; set; }
    }

    public class AdjusterFull
    {
        [JsonProperty("adjuster")]
        public Adjuster Adjuster { get; set; }

        [JsonProperty("adjuster_value")]
        public double AdjusterValue { get; set; }
    }

    public enum Adjuster
    {
        [EnumMember(Value = "relative")]
        Relative,
        [EnumMember(Value = "percentage")]
        Percentage
    }

    public class PurchasingDisabled
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ProductVariantFull
    {
        [JsonProperty("cost_price")]
        public double CostPrice { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("sale_price")]
        public double SalePrice { get; set; }

        [JsonProperty("retail_price")]
        public double RetailPrice { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("depth")]
        public double Depth { get; set; }

        [JsonProperty("is_free_shipping")]
        public bool IsFreeShipping { get; set; }

        [JsonProperty("fixed_cost_shipping_price")]
        public double FixedCostShippingPrice { get; set; }

        [JsonProperty("purchasing_disabled")]
        public bool PurchasingDisabled { get; set; }

        [JsonProperty("purchasing_disabled_message")]
        public string PurchasingDisabledMessage { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }

        [JsonProperty("inventory_level")]
        public int InventoryLevel { get; set; }

        [JsonProperty("inventory_warning_level")]
        public int InventoryWarningLevel { get; set; }

        [JsonProperty("bin_picking_number")]
        public string BinPickingNumber { get; set; }

        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("sku_id")]
        public int SkuId { get; set; }

        [JsonProperty("option_values")]
        public ProductVariantOptionValueFull[] OptionValues { get; set; }

        [JsonProperty("calculated_price")]
        public double CalculatedPrice { get; set; }

        [JsonProperty("calculated_weight")]
        public double CalculatedWeight { get; set; }
    }

    public class ProductVariantOptionValueFull
    {
        [JsonProperty("option_display_name")]
        public string OptionDisplayName { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("option_id")]
        public int OptionId { get; set; }
    }

    public class MetaCollectionFull
    {
        [JsonProperty("pagination")]
        public PaginationFull Pagination { get; set; }
    }

    public class PaginationFull
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public enum conditionInput
    {
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "used")]
        Used,
        [EnumMember(Value = "refurbished")]
        Refurbished
    }

    public enum isFeaturedInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "0")]
        _0
    }

    public enum typeInput
    {
        [EnumMember(Value = "digital")]
        Digital,
        [EnumMember(Value = "physical")]
        Physical
    }

    public enum keywordContextInput
    {
        [EnumMember(Value = "shopper")]
        Shopper,
        [EnumMember(Value = "merchant")]
        Merchant
    }

    public enum includeInput
    {
        [EnumMember(Value = "variants")]
        Variants,
        [EnumMember(Value = "images")]
        Images,
        [EnumMember(Value = "custom_fields")]
        CustomFields,
        [EnumMember(Value = "bulk_pricing_rules")]
        BulkPricingRules,
        [EnumMember(Value = "primary_image")]
        PrimaryImage,
        [EnumMember(Value = "modifiers")]
        Modifiers,
        [EnumMember(Value = "options")]
        Options,
        [EnumMember(Value = "videos")]
        Videos
    }

    public enum availabilityInput
    {
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "preorder")]
        Preorder
    }

    public enum directionInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CustomerCollectionResponse
    {
        [JsonProperty("data")]
        public CustomerFull[] Data { get; set; }
    }

    public class CustomerFull
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("registration_ip_address")]
        public string RegistrationIpAddress { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("tax_exempt_category")]
        public string TaxExemptCategory { get; set; }

        [JsonProperty("customer_group_id")]
        public int CustomerGroupId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("address_count")]
        public int AddressCount { get; set; }

        [JsonProperty("attribute_count")]
        public int AttributeCount { get; set; }

        [JsonProperty("authentication")]
        public CustomerFullAuthenticationType Authentication { get; set; }

        [JsonProperty("addresses")]
        public AddressFull[] Addresses { get; set; }

        [JsonProperty("attributes")]
        public AttributeFull[] Attributes { get; set; }

        [JsonProperty("store_credit_amounts")]
        public CustomerStoredCreditAmountsItem[] StoreCreditAmounts { get; set; }

        [JsonProperty("accepts_product_review_abandoned_cart_emails")]
        public bool AcceptsProductReviewAbandonedCartEmails { get; set; }

        [JsonProperty("channel_ids")]
        public int[] ChannelIds { get; set; }
    }

    public class CustomerFullAuthenticationType
    {
        [JsonProperty("force_password_reset")]
        public bool ForcePasswordReset { get; set; }
    }

    public class AddressFull
    {
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

        [JsonProperty("state_or_province")]
        public string StateOrProvince { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address_type")]
        public AddressFullAddressTypeType AddressType { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public enum AddressFullAddressTypeType
    {
        [EnumMember(Value = "residential")]
        Residential,
        [EnumMember(Value = "commercial")]
        Commercial
    }

    public class AttributeFull
    {
        [JsonProperty("attribute_id")]
        public int AttributeId { get; set; }

        [JsonProperty("attribute_value")]
        public string AttributeValue { get; set; }

        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class CustomerStoredCreditAmountsItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bigcommerce;

    public partial class WorkflowManagedActions
    {
        public BigcommerceActions Bigcommerce(string connectionId) => new BigcommerceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BigcommerceTriggers Bigcommerce(string connectionId) => new BigcommerceTriggers(connectionId);
    }
}