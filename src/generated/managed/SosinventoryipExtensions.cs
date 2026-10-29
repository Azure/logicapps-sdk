//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sosinventoryip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SosinventoryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<ItemResponse, ApiConnectionActionConfiguration> Item(Expression<Func<string>> location = null, Expression<Func<string>> tags = null, Expression<Func<typeInput>> type = null, Expression<Func<int>> limit = null)
        {
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/item";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<LotResponse, ApiConnectionActionConfiguration> Lot(Expression<Func<string>> location = null, Expression<Func<archivedInput>> archived = null, Expression<Func<statusInput>> status = null, Expression<Func<int>> limit = null)
        {
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<LotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lot";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<LotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<LocationResponse, ApiConnectionActionConfiguration> Location(Expression<Func<int>> limit = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<LocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<LocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<Customer, ApiConnectionActionConfiguration> GetCustomer(Expression<Func<double>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Customer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/customer/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Customer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<Salesorder, ApiConnectionActionConfiguration> GetSalesOrder(Expression<Func<double>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Salesorder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/salesorder/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Salesorder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<SalesOrderResponse, ApiConnectionActionConfiguration> SalesOrder(Expression<Func<double>> start = null, Expression<Func<double>> maxresults = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> query = null, Expression<Func<bool>> archived = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> location = null, Expression<Func<double>> id = null)
        {
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            return new DeferredBodyAction<SalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/salesorder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["maxresults"] = Convert.ToString(200);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<SalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<Pickticket, ApiConnectionActionConfiguration> UpdatePickTicket(Expression<Func<int>> id, Expression<Func<UpdatePickTicketInput>> pickticket = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_pickticket = WorkflowExpression.Compile(pickticket, nameof(pickticket), required: false);
            return new DeferredBodyAction<Pickticket, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pickticket/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_pickticket != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_pickticket);
                return new ApiConnectionAction<Pickticket>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sosinventoryip")]
        public IBodyWorkflowAction<PickTicketResponse, ApiConnectionActionConfiguration> PickTicket(Expression<Func<double>> start = null, Expression<Func<double>> maxresults = null, Expression<Func<string>> summary = null, Expression<Func<string>> query = null, Expression<Func<bool>> archived = null, Expression<Func<string>> from = null, Expression<Func<string>> to = null, Expression<Func<string>> location = null, Expression<Func<statusInput>> status = null)
        {
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_maxresults = WorkflowExpression.Compile(maxresults, nameof(maxresults), required: false);
            var __workflow_summary = WorkflowExpression.Compile(summary, nameof(summary), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: false);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<PickTicketResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pickticket";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                callPayload.Queries["maxresults"] = Convert.ToString(200);
                if (__workflow_maxresults != null)
                    callPayload.Queries["maxresults"] = ExpressionConverter.Convert(__workflow_maxresults);
                if (__workflow_summary != null)
                    callPayload.Queries["summary"] = ExpressionConverter.Convert(__workflow_summary);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_to != null)
                    callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<PickTicketResponse>(callPayload);
            });
        }
    }

    public class SosinventoryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ItemResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public ItemResponseDataTypeItem[] Data { get; set; }
    }

    public class ItemResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("starred")]
        public int Starred { get; set; }

        [JsonProperty("syncToken")]
        public int SyncToken { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("purchaseDescription")]
        public string PurchaseDescription { get; set; }

        [JsonProperty("vendorPartNumber")]
        public string VendorPartNumber { get; set; }

        [JsonProperty("customerPartNumber")]
        public string CustomerPartNumber { get; set; }

        [JsonProperty("vendor")]
        public ItemResponseDataTypeItemVendorType Vendor { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("warranty")]
        public string Warranty { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("incomeAccount")]
        public ItemResponseDataTypeItemIncomeAccountType IncomeAccount { get; set; }

        [JsonProperty("cogsAccount")]
        public ItemResponseDataTypeItemCogsAccountType CogsAccount { get; set; }

        [JsonProperty("assetAccount")]
        public ItemResponseDataTypeItemAssetAccountType AssetAccount { get; set; }

        [JsonProperty("expenseAccount")]
        public ItemResponseDataTypeItemExpenseAccountType ExpenseAccount { get; set; }

        [JsonProperty("onhand")]
        public double Onhand { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }

        [JsonProperty("onSO")]
        public double OnSO { get; set; }

        [JsonProperty("onSR")]
        public double OnSR { get; set; }

        [JsonProperty("rented")]
        public double Rented { get; set; }

        [JsonProperty("onWO")]
        public double OnWO { get; set; }

        [JsonProperty("onPO")]
        public double OnPO { get; set; }

        [JsonProperty("onRMA")]
        public double OnRMA { get; set; }

        [JsonProperty("reorderPoint")]
        public double ReorderPoint { get; set; }

        [JsonProperty("maxStock")]
        public double MaxStock { get; set; }

        [JsonProperty("leadTime")]
        public double LeadTime { get; set; }

        [JsonProperty("salesPrice")]
        public double SalesPrice { get; set; }

        [JsonProperty("baseSalesPrice")]
        public double BaseSalesPrice { get; set; }

        [JsonProperty("markupPercent")]
        public double MarkupPercent { get; set; }

        [JsonProperty("useMarkup")]
        public bool UseMarkup { get; set; }

        [JsonProperty("minimumPrice")]
        public double MinimumPrice { get; set; }

        [JsonProperty("basePurchaseCost")]
        public double BasePurchaseCost { get; set; }

        [JsonProperty("purchaseCost")]
        public double PurchaseCost { get; set; }

        [JsonProperty("costBasis")]
        public double CostBasis { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }

        [JsonProperty("volumeUnit")]
        public string VolumeUnit { get; set; }

        [JsonProperty("sublevel")]
        public int Sublevel { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("salesTaxCode")]
        public string SalesTaxCode { get; set; }

        [JsonProperty("purchaseTaxCode")]
        public string PurchaseTaxCode { get; set; }

        [JsonProperty("willSync")]
        public bool WillSync { get; set; }

        [JsonProperty("updateShopify")]
        public bool UpdateShopify { get; set; }

        [JsonProperty("updateBigCommerce")]
        public bool UpdateBigCommerce { get; set; }

        [JsonProperty("alwaysShippable")]
        public bool AlwaysShippable { get; set; }

        [JsonProperty("hasImage")]
        public bool HasImage { get; set; }

        [JsonProperty("serialTracking")]
        public bool SerialTracking { get; set; }

        [JsonProperty("lotTracking")]
        public bool LotTracking { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("showOnSalesForms")]
        public bool ShowOnSalesForms { get; set; }

        [JsonProperty("showOnPurchasingForms")]
        public bool ShowOnPurchasingForms { get; set; }

        [JsonProperty("showOnManufacturingForms")]
        public bool ShowOnManufacturingForms { get; set; }

        [JsonProperty("customFields")]
        public string CustomFields { get; set; }

        [JsonProperty("uoms")]
        public JToken[] Uoms { get; set; }

        [JsonProperty("priceTiers")]
        public JToken[] PriceTiers { get; set; }

        [JsonProperty("summaryOnly")]
        public bool SummaryOnly { get; set; }

        [JsonProperty("imageAsBase64String")]
        public string ImageAsBase64String { get; set; }

        [JsonProperty("imageChanged")]
        public bool ImageChanged { get; set; }

        [JsonProperty("commissionRate")]
        public double CommissionRate { get; set; }

        [JsonProperty("commissionAmount")]
        public double CommissionAmount { get; set; }

        [JsonProperty("commissionExempt")]
        public bool CommissionExempt { get; set; }

        [JsonProperty("syncMessage")]
        public string SyncMessage { get; set; }

        [JsonProperty("lastSync")]
        public string LastSync { get; set; }

        [JsonProperty("keys")]
        public string Keys { get; set; }

        [JsonProperty("values")]
        public string Values { get; set; }

        [JsonProperty("__IMTLENGTH__")]
        public int IMTLENGTH { get; set; }

        [JsonProperty("__IMTINDEX__")]
        public int IMTINDEX { get; set; }
    }

    public class ItemResponseDataTypeItemVendorType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ItemResponseDataTypeItemIncomeAccountType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ItemResponseDataTypeItemCogsAccountType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ItemResponseDataTypeItemAssetAccountType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ItemResponseDataTypeItemExpenseAccountType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum typeInput
    {
        [EnumMember(Value = "Inventory Item")]
        InventoryItem,
        Assembly
    }

    public class LotResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public LotResponseDataTypeItem[] Data { get; set; }
    }

    public class LotResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("starred")]
        public int Starred { get; set; }

        [JsonProperty("syncToken")]
        public int SyncToken { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("item")]
        public LotResponseDataTypeItemItemType Item { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("recalled")]
        public bool Recalled { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("customFields")]
        public LotResponseDataTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("onhand")]
        public double Onhand { get; set; }

        [JsonProperty("available")]
        public double Available { get; set; }

        [JsonProperty("summaryOnly")]
        public bool SummaryOnly { get; set; }
    }

    public class LotResponseDataTypeItemItemType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LotResponseDataTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum archivedInput
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class LocationResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public LocationResponseDataTypeItem[] Data { get; set; }
    }

    public class LocationResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("syncToken")]
        public int SyncToken { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("binTracking")]
        public bool BinTracking { get; set; }

        [JsonProperty("bins")]
        public LocationResponseDataTypeItemBinsTypeItem[] Bins { get; set; }

        [JsonProperty("address")]
        public LocationResponseDataTypeItemAddressType Address { get; set; }
    }

    public class LocationResponseDataTypeItemBinsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("syncToken")]
        public int SyncToken { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("sortOrder")]
        public int SortOrder { get; set; }
    }

    public class LocationResponseDataTypeItemAddressType
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("line4")]
        public string Line4 { get; set; }

        [JsonProperty("line5")]
        public string Line5 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }
    }

    public class Customer
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("starred")]
        public int Starred { get; set; }

        [JsonProperty("syncToken")]
        public int SyncToken { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("parent")]
        public CustomerParentType Parent { get; set; }

        [JsonProperty("sublevel")]
        public int Sublevel { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("altPhone")]
        public string AltPhone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("contact")]
        public CustomerContactType Contact { get; set; }

        [JsonProperty("billing")]
        public AddressInfo Billing { get; set; }

        [JsonProperty("shipping")]
        public AddressInfo Shipping { get; set; }

        [JsonProperty("terms")]
        public CustomerTermsType Terms { get; set; }

        [JsonProperty("priceTier")]
        public CustomerPriceTierType PriceTier { get; set; }

        [JsonProperty("paymentMethod")]
        public CustomerPaymentMethodType PaymentMethod { get; set; }

        [JsonProperty("salesRep")]
        public CustomerSalesRepType SalesRep { get; set; }

        [JsonProperty("customerType")]
        public CustomerCustomerTypeType CustomerType { get; set; }

        [JsonProperty("resaleNumber")]
        public string ResaleNumber { get; set; }

        [JsonProperty("contractorNumber")]
        public string ContractorNumber { get; set; }

        [JsonProperty("businessLicense")]
        public string BusinessLicense { get; set; }

        [JsonProperty("foundUsVia")]
        public string FoundUsVia { get; set; }

        [JsonProperty("currency")]
        public CustomerCurrencyType Currency { get; set; }

        [JsonProperty("tax")]
        public CustomerTaxType Tax { get; set; }

        [JsonProperty("creditHold")]
        public bool CreditHold { get; set; }

        [JsonProperty("billWithParent")]
        public bool BillWithParent { get; set; }

        [JsonProperty("lastSync")]
        public string LastSync { get; set; }

        [JsonProperty("syncMessage")]
        public string SyncMessage { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("customFields")]
        public CustomerCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("altAddresses")]
        public JToken[] AltAddresses { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("summaryOnly")]
        public bool SummaryOnly { get; set; }
    }

    public class CustomerParentType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerContactType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }
    }

    public class AddressInfo
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("addressName")]
        public string AddressName { get; set; }

        [JsonProperty("addressType")]
        public string AddressType { get; set; }

        [JsonProperty("address")]
        public AddressAddressType Address { get; set; }
    }

    public class AddressAddressType
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("line4")]
        public string Line4 { get; set; }

        [JsonProperty("line5")]
        public string Line5 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class CustomerTermsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerPriceTierType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerPaymentMethodType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerSalesRepType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerCustomerTypeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerCurrencyType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerTaxType
    {
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("taxCode")]
        public CustomerTaxTypeTaxCodeType TaxCode { get; set; }
    }

    public class CustomerTaxTypeTaxCodeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CustomerCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    public class Salesorder
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("starred")]
        public double Starred { get; set; }

        [JsonProperty("syncToken")]
        public double SyncToken { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("customer")]
        public SalesorderCustomerType Customer { get; set; }

        [JsonProperty("location")]
        public SalesorderLocationType Location { get; set; }

        [JsonProperty("billing")]
        public AddressInfo Billing { get; set; }

        [JsonProperty("shipping")]
        public AddressInfo Shipping { get; set; }

        [JsonProperty("terms")]
        public SalesorderTermsType Terms { get; set; }

        [JsonProperty("salesRep")]
        public SalesorderSalesRepType SalesRep { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("department")]
        public SalesorderDepartmentType Department { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("assignedToUser")]
        public string AssignedToUser { get; set; }

        [JsonProperty("orderStage")]
        public string OrderStage { get; set; }

        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("linkedTransaction")]
        public string LinkedTransaction { get; set; }

        [JsonProperty("linkedInvoices")]
        public JToken[] LinkedInvoices { get; set; }

        [JsonProperty("linkedShipments")]
        public JToken[] LinkedShipments { get; set; }

        [JsonProperty("transactionLocationQuickBooks")]
        public string TransactionLocationQuickBooks { get; set; }

        [JsonProperty("exchangeRate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("customerMessage")]
        public string CustomerMessage { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("customerNotes")]
        public string CustomerNotes { get; set; }

        [JsonProperty("customFields")]
        public string CustomFields { get; set; }

        [JsonProperty("customerPO")]
        public string CustomerPO { get; set; }

        [JsonProperty("depositPercent")]
        public double DepositPercent { get; set; }

        [JsonProperty("depositAmount")]
        public double DepositAmount { get; set; }

        [JsonProperty("subTotal")]
        public double SubTotal { get; set; }

        [JsonProperty("discountPercent")]
        public double DiscountPercent { get; set; }

        [JsonProperty("discountAmount")]
        public double DiscountAmount { get; set; }

        [JsonProperty("taxPercent")]
        public double TaxPercent { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("shippingAmount")]
        public double ShippingAmount { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("discountTaxable")]
        public bool DiscountTaxable { get; set; }

        [JsonProperty("shippingTaxable")]
        public bool ShippingTaxable { get; set; }

        [JsonProperty("dropShip")]
        public bool DropShip { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("summaryOnly")]
        public bool SummaryOnly { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("earliestDueDate")]
        public string EarliestDueDate { get; set; }

        [JsonProperty("statusLink")]
        public string StatusLink { get; set; }

        [JsonProperty("keys")]
        public string Keys { get; set; }

        [JsonProperty("values")]
        public string Values { get; set; }

        [JsonProperty("lines")]
        public SalesorderLinesTypeItem[] Lines { get; set; }
    }

    public class SalesorderCustomerType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SalesorderLocationType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SalesorderTermsType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SalesorderSalesRepType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SalesorderDepartmentType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SalesorderLinesTypeItem
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("lineNumber")]
        public double LineNumber { get; set; }

        [JsonProperty("item")]
        public SalesorderLinesTypeItemItemType Item { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("workcenter")]
        public string Workcenter { get; set; }

        [JsonProperty("tax")]
        public SalesorderLinesTypeItemTaxType Tax { get; set; }

        [JsonProperty("linkedTransaction")]
        public string LinkedTransaction { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("weightunit")]
        public string Weightunit { get; set; }

        [JsonProperty("volumeunit")]
        public string Volumeunit { get; set; }

        [JsonProperty("unitprice")]
        public double Unitprice { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("altAmount")]
        public double AltAmount { get; set; }

        [JsonProperty("picked")]
        public double Picked { get; set; }

        [JsonProperty("shipped")]
        public double Shipped { get; set; }

        [JsonProperty("invoiced")]
        public double Invoiced { get; set; }

        [JsonProperty("produced")]
        public double Produced { get; set; }

        [JsonProperty("returned")]
        public double Returned { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("margin")]
        public double Margin { get; set; }

        [JsonProperty("listPrice")]
        public double ListPrice { get; set; }

        [JsonProperty("percentdiscount")]
        public double Percentdiscount { get; set; }

        [JsonProperty("duedate")]
        public string Duedate { get; set; }

        [JsonProperty("uom")]
        public double Uom { get; set; }

        [JsonProperty("bin")]
        public string Bin { get; set; }

        [JsonProperty("lot")]
        public string Lot { get; set; }

        [JsonProperty("serials")]
        public string Serials { get; set; }
    }

    public class SalesorderLinesTypeItemItemType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SalesorderLinesTypeItemTaxType
    {
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }
    }

    public class SalesOrderResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public Salesorder[] Data { get; set; }
    }

    public class Pickticket
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("starred")]
        public int Starred { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("syncToken")]
        public int SyncToken { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("customer")]
        public PickticketCustomerType Customer { get; set; }

        [JsonProperty("location")]
        public PickticketLocationType Location { get; set; }

        [JsonProperty("channel")]
        public PickticketChannelType Channel { get; set; }

        [JsonProperty("priority")]
        public PickticketPriorityType Priority { get; set; }

        [JsonProperty("assignedToUser")]
        public PickticketAssignedToUserType AssignedToUser { get; set; }

        [JsonProperty("shippingMethod")]
        public PickticketShippingMethodType ShippingMethod { get; set; }

        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        [JsonProperty("linkedTransaction")]
        public Linkedtransaction LinkedTransaction { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("customerNotes")]
        public string CustomerNotes { get; set; }

        [JsonProperty("customFields")]
        public PickticketCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("pickBy")]
        public string PickBy { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("summaryOnly")]
        public bool SummaryOnly { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("lines")]
        public PickticketLinesTypeItem[] Lines { get; set; }
    }

    public class PickticketCustomerType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketLocationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketChannelType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketPriorityType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketAssignedToUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketShippingMethodType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Linkedtransaction
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty("refNumber")]
        public string RefNumber { get; set; }

        [JsonProperty("linenumber")]
        public int Linenumber { get; set; }
    }

    public class PickticketCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    public class PickticketLinesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lineNumber")]
        public int LineNumber { get; set; }

        [JsonProperty("item")]
        public PickticketLinesTypeItemItemType Item { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("job")]
        public PickticketLinesTypeItemJobType Job { get; set; }

        [JsonProperty("workcenter")]
        public PickticketLinesTypeItemWorkcenterType Workcenter { get; set; }

        [JsonProperty("tax")]
        public PickticketLinesTypeItemTaxType Tax { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("weightunit")]
        public string Weightunit { get; set; }

        [JsonProperty("volumeunit")]
        public string Volumeunit { get; set; }

        [JsonProperty("uom")]
        public PickticketLinesTypeItemUomType Uom { get; set; }

        [JsonProperty("lot")]
        public PickticketLinesTypeItemLotType Lot { get; set; }
    }

    public class PickticketLinesTypeItemItemType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketLinesTypeItemJobType
    {
        [JsonProperty("id")]
        public double Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketLinesTypeItemWorkcenterType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketLinesTypeItemTaxType
    {
        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("taxCode")]
        public PickticketLinesTypeItemTaxTypeTaxCodeType TaxCode { get; set; }
    }

    public class PickticketLinesTypeItemTaxTypeTaxCodeType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketLinesTypeItemUomType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickticketLinesTypeItemLotType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInput
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("starred")]
        public int? Starred { get; set; }

        [JsonProperty("closed")]
        public bool? Closed { get; set; }

        [JsonProperty("syncToken")]
        public int? SyncToken { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("customer")]
        public UpdatePickTicketInputCustomerType Customer { get; set; }

        [JsonProperty("location")]
        public UpdatePickTicketInputLocationType Location { get; set; }

        [JsonProperty("channel")]
        public UpdatePickTicketInputChannelType Channel { get; set; }

        [JsonProperty("priority")]
        public UpdatePickTicketInputPriorityType Priority { get; set; }

        [JsonProperty("assignedToUser")]
        public UpdatePickTicketInputAssignedToUserType AssignedToUser { get; set; }

        [JsonProperty("shippingMethod")]
        public UpdatePickTicketInputShippingMethodType ShippingMethod { get; set; }

        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        [JsonProperty("linkedTransaction")]
        public Linkedtransaction LinkedTransaction { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("customerNotes")]
        public string CustomerNotes { get; set; }

        [JsonProperty("customFields")]
        public UpdatePickTicketInputCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("pickBy")]
        public string PickBy { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("archived")]
        public bool? Archived { get; set; }

        [JsonProperty("summaryOnly")]
        public bool? SummaryOnly { get; set; }

        [JsonProperty("hasSignature")]
        public bool? HasSignature { get; set; }

        [JsonProperty("lines")]
        public UpdatePickTicketInputLinesTypeItem[] Lines { get; set; }
    }

    public class UpdatePickTicketInputCustomerType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputLocationType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputChannelType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputPriorityType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputAssignedToUserType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputShippingMethodType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputCustomFieldsTypeItem
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItem
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("lineNumber")]
        public int? LineNumber { get; set; }

        [JsonProperty("item")]
        public UpdatePickTicketInputLinesTypeItemItemType Item { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("job")]
        public UpdatePickTicketInputLinesTypeItemJobType Job { get; set; }

        [JsonProperty("workcenter")]
        public UpdatePickTicketInputLinesTypeItemWorkcenterType Workcenter { get; set; }

        [JsonProperty("tax")]
        public UpdatePickTicketInputLinesTypeItemTaxType Tax { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double? Quantity { get; set; }

        [JsonProperty("weight")]
        public double? Weight { get; set; }

        [JsonProperty("volume")]
        public double? Volume { get; set; }

        [JsonProperty("weightunit")]
        public string Weightunit { get; set; }

        [JsonProperty("volumeunit")]
        public string Volumeunit { get; set; }

        [JsonProperty("uom")]
        public UpdatePickTicketInputLinesTypeItemUomType Uom { get; set; }

        [JsonProperty("lot")]
        public UpdatePickTicketInputLinesTypeItemLotType Lot { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemItemType
    {
        [JsonProperty("id")]
        public double? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemJobType
    {
        [JsonProperty("id")]
        public double? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemWorkcenterType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemTaxType
    {
        [JsonProperty("taxable")]
        public bool? Taxable { get; set; }

        [JsonProperty("taxCode")]
        public UpdatePickTicketInputLinesTypeItemTaxTypeTaxCodeType TaxCode { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemTaxTypeTaxCodeType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemUomType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdatePickTicketInputLinesTypeItemLotType
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PickTicketResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("data")]
        public Pickticket[] Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sosinventoryip;

    public partial class WorkflowManagedActions
    {
        public SosinventoryipActions Sosinventoryip(string connectionId) => new SosinventoryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SosinventoryipTriggers Sosinventoryip(string connectionId) => new SosinventoryipTriggers(connectionId);
    }
}