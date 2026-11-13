//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commercientcpq
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommercientcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sage100CreateNewCustomerResponse, ApiConnectionActionConfiguration> Sage100CreateNewCustomer(Expression<Func<Sage100CreateNewCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sage100CreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/SAGE100/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sage100CreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sage100CreateNewSalesOrderResponse, ApiConnectionActionConfiguration> Sage100CreateNewSalesOrder(Expression<Func<Sage100CreateNewSalesOrderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sage100CreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/SAGE100/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sage100CreateNewSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCpqCreateNewCustomerResponse, ApiConnectionActionConfiguration> CommercientCpqCreateNewCustomer(Expression<Func<CommercientCpqCreateNewCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CommercientCpqCreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/commercientcpq/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommercientCpqCreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCpqCreateNewProductResponse, ApiConnectionActionConfiguration> CommercientCpqCreateNewProduct(Expression<Func<CommercientCpqCreateNewProductBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CommercientCpqCreateNewProductResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/commercientcpq/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommercientCpqCreateNewProductResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCpqCreateNewSalesOrderResponse, ApiConnectionActionConfiguration> CommercientCpqCreateNewSalesOrder(Expression<Func<CommercientCpqCreateNewSalesOrderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CommercientCpqCreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/commercientcpq/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CommercientCpqCreateNewSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse, ApiConnectionActionConfiguration> QuickBookCreateNewCustomer(Expression<Func<QuickBookCreateNewCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<QuickBookCreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/quickbook/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QuickBookCreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse, ApiConnectionActionConfiguration> QuickBookCreateNewSalesOrder(Expression<Func<QuickBookCreateNewSalesOrderBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<QuickBookCreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/quickbook/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<QuickBookCreateNewSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sage50UKCreateNewCustomerResponse, ApiConnectionActionConfiguration> Sage50UKCreateNewCustomer(Expression<Func<Sage50UKCreateNewCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sage50UKCreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/sage50uk/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sage50UKCreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sage50UKCreateNewSalesOrderResponse, ApiConnectionActionConfiguration> Sage50UKCreateNewSalesOrder(Expression<Func<Sage50UKCreateNewSalesOrderBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Sage50UKCreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/sage50uk/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sage50UKCreateNewSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sage50USCreateNewCustomerResponse, ApiConnectionActionConfiguration> Sage50USCreateNewCustomer(Expression<Func<Sage50USCreateNewCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sage50USCreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/sage50us/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sage50USCreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sage50USCreateNewSalesOrderResponse, ApiConnectionActionConfiguration> Sage50USCreateNewSalesOrder(Expression<Func<Sage50USCreateNewSalesOrderBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Sage50USCreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/sage50us/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sage50USCreateNewSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sapb1CreateNewCustomerResponse, ApiConnectionActionConfiguration> Sapb1CreateNewCustomer(Expression<Func<Sapb1CreateNewCustomerBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Sapb1CreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/sapb1/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sapb1CreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<Sapb1CreateNewSalesOrderResponse, ApiConnectionActionConfiguration> Sapb1CreateNewSalesOrder(Expression<Func<Sapb1CreateNewSalesOrderBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Sapb1CreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/sapb1/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Sapb1CreateNewSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SysproCreateNewCustomerResponse, ApiConnectionActionConfiguration> SysproCreateNewCustomer(Expression<Func<SysproCreateNewCustomerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SysproCreateNewCustomerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/syspro/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SysproCreateNewCustomerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SysproCreateNewSalesOrderResponse, ApiConnectionActionConfiguration> SysproCreateNewSalesOrder(Expression<Func<SysproCreateNewSalesOrderBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SysproCreateNewSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/syspro/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SysproCreateNewSalesOrderResponse>(callPayload);
            });
        }
    }

    public class CommercientcpqTriggers([ConnectionName] string connectionId)
    {
    }

    public class Sage100CreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sage100CreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sage100CreateNewCustomerResponseDataType
    {
        public string ARDivisionNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public bool BatchFax { get; set; }
        public string City { get; set; }
        public string Comment { get; set; }
        public string ContactCode { get; set; }
        public string CountryCode { get; set; }
        public bool CreditHold { get; set; }
        public int CreditLimit { get; set; }
        public int CustomerDiscountRate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerType { get; set; }
        public string DefaultCreditCardPmtType { get; set; }
        public string DefaultItemCode { get; set; }
        public string DefaultPaymentType { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNo { get; set; }
        public bool OpenItemCustomer { get; set; }
        public string PriceLevel { get; set; }
        public string PrimaryShipToCode { get; set; }
        public bool PrintDunningMessage { get; set; }
        public bool ResidentialAddress { get; set; }
        public string SalespersonNo { get; set; }
        public string ShipMethod { get; set; }
        public string State { get; set; }
        public string StatementCycle { get; set; }
        public string TaxExemptNo { get; set; }
        public string TaxSchedule { get; set; }
        public string TelephoneExt { get; set; }
        public string TelephoneNo { get; set; }
        public string TermsCode { get; set; }

        [JsonProperty("URLAddress")]
        public string UrlAddress { get; set; }
        public string ZipCode { get; set; }
    }

    public class Sage100CreateNewCustomerBodyInput
    {
        public string ARDivisionNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public bool? BatchFax { get; set; }
        public string City { get; set; }
        public string Comment { get; set; }
        public string ContactCode { get; set; }
        public string CountryCode { get; set; }
        public bool? CreditHold { get; set; }
        public int? CreditLimit { get; set; }
        public int? CustomerDiscountRate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerType { get; set; }
        public string DefaultCreditCardPmtType { get; set; }
        public string DefaultItemCode { get; set; }
        public string DefaultPaymentType { get; set; }
        public string EmailAddress { get; set; }
        public string FaxNo { get; set; }
        public bool? OpenItemCustomer { get; set; }
        public string PriceLevel { get; set; }
        public string PrimaryShipToCode { get; set; }
        public bool? PrintDunningMessage { get; set; }
        public bool? ResidentialAddress { get; set; }
        public string SalespersonNo { get; set; }
        public string ShipMethod { get; set; }
        public string State { get; set; }
        public string StatementCycle { get; set; }
        public string TaxExemptNo { get; set; }
        public string TaxSchedule { get; set; }
        public string TelephoneExt { get; set; }
        public string TelephoneNo { get; set; }
        public string TermsCode { get; set; }

        [JsonProperty("URLAddress")]
        public string UrlAddress { get; set; }
        public string ZipCode { get; set; }
    }

    public class Sage100CreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sage100CreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sage100CreateNewSalesOrderResponseDataType
    {
        public string ARDivisionNo { get; set; }
        public bool BatchFax { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToAddress3 { get; set; }
        public string BillToCity { get; set; }
        public string BillToCountryCode { get; set; }
        public string BillToName { get; set; }
        public string BillToState { get; set; }
        public string BillToZipCode { get; set; }
        public string Comment { get; set; }
        public string ConfirmTo { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerPONo { get; set; }
        public string CycleCode { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("FOB")]
        public string Fob { get; set; }
        public string FaxNo { get; set; }
        public string MasterRepeatingOrderNo { get; set; }
        public int NumberOfShippingLabels { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderType { get; set; }
        public bool PrintPickingSheets { get; set; }
        public bool PrintSalesOrders { get; set; }
        public Sage100CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public string SalesOrderNo { get; set; }
        public string SalespersonNo { get; set; }
        public string ShipExpireDate { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToCountryCode { get; set; }
        public string ShipToName { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZipCode { get; set; }
        public string ShipVia { get; set; }
        public int ShipWeight { get; set; }
        public string ShipZoneActual { get; set; }
        public string SplitCommissions { get; set; }
        public string TaxExemptNo { get; set; }
        public string TaxSchedule { get; set; }
        public string TermsCode { get; set; }
        public string WarehouseCode { get; set; }
    }

    public class Sage100CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public string CommentText { get; set; }
        public int Discount { get; set; }
        public int ExtensionAmt { get; set; }
        public string ItemCode { get; set; }
        public string ItemCodeDesc { get; set; }
        public string ItemType { get; set; }
        public string ItemWarehouseCode { get; set; }
        public int QuantityOrdered { get; set; }
        public string UnitOfMeasure { get; set; }
        public int UnitPrice { get; set; }
    }

    public class Sage100CreateNewSalesOrderBodyInput
    {
        public string ARDivisionNo { get; set; }
        public bool? BatchFax { get; set; }
        public string BillToAddress1 { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToAddress3 { get; set; }
        public string BillToCity { get; set; }
        public string BillToCountryCode { get; set; }
        public string BillToName { get; set; }
        public string BillToState { get; set; }
        public string BillToZipCode { get; set; }
        public string Comment { get; set; }
        public string ConfirmTo { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerPONo { get; set; }
        public string CycleCode { get; set; }
        public string EmailAddress { get; set; }

        [JsonProperty("FOB")]
        public string Fob { get; set; }
        public string FaxNo { get; set; }
        public string MasterRepeatingOrderNo { get; set; }
        public int? NumberOfShippingLabels { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderType { get; set; }
        public bool? PrintPickingSheets { get; set; }
        public bool? PrintSalesOrders { get; set; }
        public Sage100CreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public string SalesOrderNo { get; set; }
        public string SalespersonNo { get; set; }
        public string ShipExpireDate { get; set; }
        public string ShipToAddress1 { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToAddress3 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToCountryCode { get; set; }
        public string ShipToName { get; set; }
        public string ShipToState { get; set; }
        public string ShipToZipCode { get; set; }
        public string ShipVia { get; set; }
        public int? ShipWeight { get; set; }
        public string ShipZoneActual { get; set; }
        public string SplitCommissions { get; set; }
        public string TaxExemptNo { get; set; }
        public string TaxSchedule { get; set; }
        public string TermsCode { get; set; }
        public string WarehouseCode { get; set; }
    }

    public class Sage100CreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem
    {
        public string CommentText { get; set; }
        public int? Discount { get; set; }
        public int? ExtensionAmt { get; set; }
        public string ItemCode { get; set; }
        public string ItemCodeDesc { get; set; }
        public string ItemType { get; set; }
        public string ItemWarehouseCode { get; set; }
        public int? QuantityOrdered { get; set; }
        public string UnitOfMeasure { get; set; }
        public int? UnitPrice { get; set; }
    }

    public class CommercientCpqCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public CommercientCpqCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CommercientCpqCreateNewCustomerResponseDataType
    {
        public string BillingCity { get; set; }
        public string BillingCounty { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }

        [JsonProperty("GUID")]
        public string Guid { get; set; }
        public string Name { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }

        [JsonProperty("acnm")]
        public string Acnm { get; set; }
    }

    public class CommercientCpqCreateNewCustomerBodyInput
    {
        public string BillingCity { get; set; }
        public string BillingCounty { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }

        [JsonProperty("GUID")]
        public string Guid { get; set; }
        public string Name { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }

        [JsonProperty("acnm")]
        public string Acnm { get; set; }
    }

    public class CommercientCpqCreateNewProductResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public CommercientCpqCreateNewProductResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CommercientCpqCreateNewProductResponseDataType
    {
        public string StockCode { get; set; }
    }

    public class CommercientCpqCreateNewProductBodyInput
    {
        public string StockCode { get; set; }
    }

    public class CommercientCpqCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public CommercientCpqCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CommercientCpqCreateNewSalesOrderResponseDataType
    {
        [JsonProperty("OrderHeaderGUID")]
        public string OrderHeaderGuid { get; set; }
        public CommercientCpqCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
    }

    public class CommercientCpqCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public string Price { get; set; }
        public string Qty { get; set; }
        public string StockCode { get; set; }
    }

    public class CommercientCpqCreateNewSalesOrderBodyInput
    {
        [JsonProperty("OrderHeaderGUID")]
        public string OrderHeaderGuid { get; set; }
        public CommercientCpqCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
    }

    public class CommercientCpqCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem
    {
        public string Price { get; set; }
        public string Qty { get; set; }
        public string StockCode { get; set; }
    }

    public class QuickBookCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public QuickBookCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class QuickBookCreateNewCustomerResponseDataType
    {
        public string AccountNumber { get; set; }
        public string AltContact { get; set; }
        public string AltPhone { get; set; }
        public string BillAddressAddr1 { get; set; }
        public string BillAddressAddr2 { get; set; }
        public string BillAddressAddr3 { get; set; }
        public string BillAddressAddr4 { get; set; }
        public string BillAddressAddr5 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressNote { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string BillAddressState { get; set; }
        public string Cc { get; set; }
        public string ClassRef { get; set; }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        public int CreditLimit { get; set; }
        public string CustomerTypeRef { get; set; }
        public string EditSequence { get; set; }
        public string Email { get; set; }
        public string ExtraField { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public bool IsActive { get; set; }
        public bool IsActiveSpecified { get; set; }
        public string ItemSalesTaxRef { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }

        [JsonProperty("ListID")]
        public string ListId { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int OpenBalance { get; set; }
        public string OpenBalanceDate { get; set; }
        public string ParentRef { get; set; }
        public string Phone { get; set; }
        public string PreferredPaymentMethodRef { get; set; }
        public string PriceLevelRef { get; set; }
        public string ResaleNumber { get; set; }
        public string SalesRepRef { get; set; }
        public string SalesTaxCodeRef { get; set; }
        public string Salutation { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressAddr3 { get; set; }
        public string ShipAddressAddr4 { get; set; }
        public string ShipAddressAddr5 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressNote { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressState { get; set; }
        public string TermsRef { get; set; }
    }

    public class QuickBookCreateNewCustomerBodyInput
    {
        public string AccountNumber { get; set; }
        public string AltContact { get; set; }
        public string AltPhone { get; set; }
        public string BillAddressAddr1 { get; set; }
        public string BillAddressAddr2 { get; set; }
        public string BillAddressAddr3 { get; set; }
        public string BillAddressAddr4 { get; set; }
        public string BillAddressAddr5 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressNote { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string BillAddressState { get; set; }
        public string Cc { get; set; }
        public string ClassRef { get; set; }
        public string CompanyName { get; set; }
        public string Contact { get; set; }
        public int? CreditLimit { get; set; }
        public string CustomerTypeRef { get; set; }
        public string EditSequence { get; set; }
        public string Email { get; set; }
        public string ExtraField { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public bool? IsActive { get; set; }
        public string ItemSalesTaxRef { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }

        [JsonProperty("ListID")]
        public string ListId { get; set; }
        public string MiddleName { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int? OpenBalance { get; set; }
        public string OpenBalanceDate { get; set; }
        public string ParentRef { get; set; }
        public string Phone { get; set; }
        public string PreferredPaymentMethodRef { get; set; }
        public string PriceLevelRef { get; set; }
        public string ResaleNumber { get; set; }
        public string SalesRepRef { get; set; }
        public string SalesTaxCodeRef { get; set; }
        public string Salutation { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressAddr3 { get; set; }
        public string ShipAddressAddr4 { get; set; }
        public string ShipAddressAddr5 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressNote { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressState { get; set; }
        public string TermsRef { get; set; }
    }

    public class QuickBookCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public QuickBookCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class QuickBookCreateNewSalesOrderResponseDataType
    {
        public string BillAddressAddr1 { get; set; }
        public string BillAddressAddr2 { get; set; }
        public string BillAddressAddr3 { get; set; }
        public string BillAddressAddr4 { get; set; }
        public string BillAddressAddr5 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressNote { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string BillAddressState { get; set; }
        public string ClassRef { get; set; }

        [JsonProperty("CustomerRefListID")]
        public string CustomerRefListId { get; set; }
        public string CustomerRefName { get; set; }
        public string CustomerSalesTaxCodeRef { get; set; }
        public string DueDate { get; set; }
        public string EditSequence { get; set; }
        public string ExtraField { get; set; }
        public string ItemSalesTaxRef { get; set; }

        [JsonProperty("ListID")]
        public string ListId { get; set; }
        public string Memo { get; set; }
        public string PONumber { get; set; }
        public string RefNumber { get; set; }
        public QuickBookCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public string SalesRepRef { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressAddr3 { get; set; }
        public string ShipAddressAddr4 { get; set; }
        public string ShipAddressAddr5 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressNote { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressState { get; set; }
        public string TemplateRef { get; set; }
        public string TermsRef { get; set; }
        public string TxnDate { get; set; }
    }

    public class QuickBookCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public int Amount { get; set; }
        public string ClassRef { get; set; }
        public string Desc { get; set; }
        public string EditSequence { get; set; }

        [JsonProperty("ItemListID")]
        public string ItemListId { get; set; }
        public string ItemRef { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public string SalesTaxCodeRef { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class QuickBookCreateNewSalesOrderBodyInput
    {
        public string BillAddressAddr1 { get; set; }
        public string BillAddressAddr2 { get; set; }
        public string BillAddressAddr3 { get; set; }
        public string BillAddressAddr4 { get; set; }
        public string BillAddressAddr5 { get; set; }
        public string BillAddressCity { get; set; }
        public string BillAddressCountry { get; set; }
        public string BillAddressNote { get; set; }
        public string BillAddressPostalCode { get; set; }
        public string BillAddressState { get; set; }
        public string ClassRef { get; set; }

        [JsonProperty("CustomerRefListID")]
        public string CustomerRefListId { get; set; }
        public string CustomerRefName { get; set; }
        public string CustomerSalesTaxCodeRef { get; set; }
        public string DueDate { get; set; }
        public string EditSequence { get; set; }
        public string ExtraField { get; set; }
        public string ItemSalesTaxRef { get; set; }

        [JsonProperty("ListID")]
        public string ListId { get; set; }
        public string Memo { get; set; }
        public string PONumber { get; set; }
        public string RefNumber { get; set; }
        public QuickBookCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public string SalesRepRef { get; set; }
        public string ShipAddressAddr1 { get; set; }
        public string ShipAddressAddr2 { get; set; }
        public string ShipAddressAddr3 { get; set; }
        public string ShipAddressAddr4 { get; set; }
        public string ShipAddressAddr5 { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressNote { get; set; }
        public string ShipAddressPostalCode { get; set; }
        public string ShipAddressState { get; set; }
        public string TemplateRef { get; set; }
        public string TermsRef { get; set; }
        public string TxnDate { get; set; }
    }

    public class QuickBookCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem
    {
        public int? Amount { get; set; }
        public string ClassRef { get; set; }
        public string Desc { get; set; }
        public string EditSequence { get; set; }

        [JsonProperty("ItemListID")]
        public string ItemListId { get; set; }
        public string ItemRef { get; set; }
        public int? Quantity { get; set; }
        public int? Rate { get; set; }
        public string SalesTaxCodeRef { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class Sage50UKCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sage50UKCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sage50UKCreateNewCustomerResponseDataType
    {
        [JsonProperty("ACCOUNT_OPENED")]
        public string AccountOpened { get; set; }

        [JsonProperty("ACCOUNT_REF")]
        public string AccountRef { get; set; }

        [JsonProperty("ACCOUNT_STATUS")]
        public int AccountStatus { get; set; }

        [JsonProperty("ADDRESS_1")]
        public string Address1 { get; set; }

        [JsonProperty("ADDRESS_2")]
        public string Address2 { get; set; }

        [JsonProperty("ADDRESS_3")]
        public string Address3 { get; set; }

        [JsonProperty("ADDRESS_4")]
        public string Address4 { get; set; }

        [JsonProperty("ADDRESS_5")]
        public string Address5 { get; set; }

        [JsonProperty("ANALYSIS_1")]
        public string Analysis1 { get; set; }

        [JsonProperty("ANALYSIS_2")]
        public string Analysis2 { get; set; }

        [JsonProperty("ANALYSIS_3")]
        public string Analysis3 { get; set; }

        [JsonProperty("AVERAGE_PAY_DAYS")]
        public int AveragePayDays { get; set; }

        [JsonProperty("BALANCE")]
        public int Balance { get; set; }

        [JsonProperty("CAN_APPLY_CHARGES")]
        public bool CanApplyCharges { get; set; }

        [JsonProperty("CONTACT_NAME")]
        public string ContactName { get; set; }

        [JsonProperty("COUNTRY_CODE")]
        public string CountryCode { get; set; }

        [JsonProperty("CREDIT_APPLIED_FOR")]
        public string CreditAppliedFor { get; set; }

        [JsonProperty("CREDIT_BUREAU")]
        public int CreditBureau { get; set; }

        [JsonProperty("CREDIT_LIMIT")]
        public int CreditLimit { get; set; }

        [JsonProperty("CREDIT_POSITION")]
        public int CreditPosition { get; set; }

        [JsonProperty("CREDIT_POSITIONSpecified")]
        public bool CreditPositionSpecified { get; set; }

        [JsonProperty("CREDIT_REFERENCE")]
        public string CreditReference { get; set; }

        [JsonProperty("CURRENCY")]
        public int Currency { get; set; }

        [JsonProperty("DATE_CREDIT_APP_RECEIVED")]
        public string DateCreditAppReceived { get; set; }

        [JsonProperty("DEF_NOM_CODE")]
        public string DefNomCode { get; set; }

        [JsonProperty("DEF_TAX_CODE")]
        public int DefTaxCode { get; set; }

        [JsonProperty("DEPT_NUMBER")]
        public int DeptNumber { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int DiscountRate { get; set; }

        [JsonProperty("DISCOUNT_TYPE")]
        public int DiscountType { get; set; }

        [JsonProperty("DUNS_NUMBER")]
        public string DunsNumber { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("E_MAIL2")]
        public string EMail2 { get; set; }

        [JsonProperty("E_MAIL3")]
        public string EMail3 { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("HOLD_MAIL")]
        public bool HoldMail { get; set; }

        [JsonProperty("INACTIVE_FLAG")]
        public bool InactiveFlag { get; set; }

        [JsonProperty("LAST_CREDIT_REV")]
        public string LastCreditRev { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("NEXT_CREDIT_REV")]
        public string NextCreditRev { get; set; }

        [JsonProperty("OVERRIDE_PRODUCT_NOMINAL")]
        public bool OverrideProductNominal { get; set; }

        [JsonProperty("OVERRIDE_PRODUCT_TAX")]
        public bool OverrideProductTax { get; set; }

        [JsonProperty("PAYMENT_DUE_DAYS")]
        public int PaymentDueDays { get; set; }

        [JsonProperty("PRICE_LIST_REF")]
        public string PriceListRef { get; set; }

        [JsonProperty("PRIORITY_TRADER")]
        public bool PriorityTrader { get; set; }

        [JsonProperty("SEND_INVOICES_ELECTRONICALLY")]
        public bool SendInvoicesElectronically { get; set; }

        [JsonProperty("SEND_LETTERS_ELECTRONICALLY")]
        public bool SendLettersElectronically { get; set; }

        [JsonProperty("SETTLEMENT_DISC_RATE")]
        public int SettlementDiscRate { get; set; }

        [JsonProperty("SETTLEMENT_DUE_DAYS")]
        public int SettlementDueDays { get; set; }

        [JsonProperty("TELEPHONE")]
        public string Telephone { get; set; }

        [JsonProperty("TELEPHONE_2")]
        public string Telephone2 { get; set; }

        [JsonProperty("TERMS")]
        public string Terms { get; set; }

        [JsonProperty("TERMS_AGREED_FLAG")]
        public bool TermsAgreedFlag { get; set; }

        [JsonProperty("TRADE_CONTACT")]
        public string TradeContact { get; set; }

        [JsonProperty("VAT_REG_NUMBER")]
        public string VatRegNumber { get; set; }
    }

    public class Sage50UKCreateNewCustomerBodyInput
    {
        [JsonProperty("ACCOUNT_OPENED")]
        public string AccountOpened { get; set; }

        [JsonProperty("ACCOUNT_REF")]
        public string AccountRef { get; set; }

        [JsonProperty("ACCOUNT_STATUS")]
        public int? AccountStatus { get; set; }

        [JsonProperty("ADDRESS_1")]
        public string Address1 { get; set; }

        [JsonProperty("ADDRESS_2")]
        public string Address2 { get; set; }

        [JsonProperty("ADDRESS_3")]
        public string Address3 { get; set; }

        [JsonProperty("ADDRESS_4")]
        public string Address4 { get; set; }

        [JsonProperty("ADDRESS_5")]
        public string Address5 { get; set; }

        [JsonProperty("ANALYSIS_1")]
        public string Analysis1 { get; set; }

        [JsonProperty("ANALYSIS_2")]
        public string Analysis2 { get; set; }

        [JsonProperty("ANALYSIS_3")]
        public string Analysis3 { get; set; }

        [JsonProperty("AVERAGE_PAY_DAYS")]
        public int? AveragePayDays { get; set; }

        [JsonProperty("BALANCE")]
        public int? Balance { get; set; }

        [JsonProperty("CAN_APPLY_CHARGES")]
        public bool? CanApplyCharges { get; set; }

        [JsonProperty("CONTACT_NAME")]
        public string ContactName { get; set; }

        [JsonProperty("COUNTRY_CODE")]
        public string CountryCode { get; set; }

        [JsonProperty("CREDIT_APPLIED_FOR")]
        public string CreditAppliedFor { get; set; }

        [JsonProperty("CREDIT_BUREAU")]
        public int? CreditBureau { get; set; }

        [JsonProperty("CREDIT_LIMIT")]
        public int? CreditLimit { get; set; }

        [JsonProperty("CREDIT_POSITION")]
        public int? CreditPosition { get; set; }

        [JsonProperty("CREDIT_REFERENCE")]
        public string CreditReference { get; set; }

        [JsonProperty("CURRENCY")]
        public int? Currency { get; set; }

        [JsonProperty("DATE_CREDIT_APP_RECEIVED")]
        public string DateCreditAppReceived { get; set; }

        [JsonProperty("DEF_NOM_CODE")]
        public string DefNomCode { get; set; }

        [JsonProperty("DEF_TAX_CODE")]
        public int? DefTaxCode { get; set; }

        [JsonProperty("DEPT_NUMBER")]
        public int? DeptNumber { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int? DiscountRate { get; set; }

        [JsonProperty("DISCOUNT_TYPE")]
        public int? DiscountType { get; set; }

        [JsonProperty("DUNS_NUMBER")]
        public string DunsNumber { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMail { get; set; }

        [JsonProperty("E_MAIL2")]
        public string EMail2 { get; set; }

        [JsonProperty("E_MAIL3")]
        public string EMail3 { get; set; }
        public string ExtraField { get; set; }

        [JsonProperty("FAX")]
        public string Fax { get; set; }

        [JsonProperty("HOLD_MAIL")]
        public bool? HoldMail { get; set; }

        [JsonProperty("INACTIVE_FLAG")]
        public bool? InactiveFlag { get; set; }

        [JsonProperty("IsACCOUNT_REF_autogenerate")]
        public bool? IsAccountRefAutogenerate { get; set; }

        [JsonProperty("LAST_CREDIT_REV")]
        public string LastCreditRev { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("NEXT_CREDIT_REV")]
        public string NextCreditRev { get; set; }

        [JsonProperty("OVERRIDE_PRODUCT_NOMINAL")]
        public bool? OverrideProductNominal { get; set; }

        [JsonProperty("OVERRIDE_PRODUCT_TAX")]
        public bool? OverrideProductTax { get; set; }

        [JsonProperty("PAYMENT_DUE_DAYS")]
        public int? PaymentDueDays { get; set; }

        [JsonProperty("PRICE_LIST_REF")]
        public string PriceListRef { get; set; }

        [JsonProperty("PRIORITY_TRADER")]
        public bool? PriorityTrader { get; set; }

        [JsonProperty("SEND_INVOICES_ELECTRONICALLY")]
        public bool? SendInvoicesElectronically { get; set; }

        [JsonProperty("SEND_LETTERS_ELECTRONICALLY")]
        public bool? SendLettersElectronically { get; set; }

        [JsonProperty("SETTLEMENT_DISC_RATE")]
        public int? SettlementDiscRate { get; set; }

        [JsonProperty("SETTLEMENT_DUE_DAYS")]
        public int? SettlementDueDays { get; set; }

        [JsonProperty("TELEPHONE")]
        public string Telephone { get; set; }

        [JsonProperty("TELEPHONE_2")]
        public string Telephone2 { get; set; }

        [JsonProperty("TERMS")]
        public string Terms { get; set; }

        [JsonProperty("TERMS_AGREED_FLAG")]
        public bool? TermsAgreedFlag { get; set; }

        [JsonProperty("TRADE_CONTACT")]
        public string TradeContact { get; set; }

        [JsonProperty("VAT_REG_NUMBER")]
        public string VatRegNumber { get; set; }
    }

    public class Sage50UKCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sage50UKCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sage50UKCreateNewSalesOrderResponseDataType
    {
        [JsonProperty("ACCOUNT_REF")]
        public string AccountRef { get; set; }

        [JsonProperty("ADDRESS_1")]
        public string Address1 { get; set; }

        [JsonProperty("ADDRESS_2")]
        public string Address2 { get; set; }

        [JsonProperty("ADDRESS_3")]
        public string Address3 { get; set; }

        [JsonProperty("ADDRESS_4")]
        public string Address4 { get; set; }

        [JsonProperty("ADDRESS_5")]
        public string Address5 { get; set; }

        [JsonProperty("AMOUNT_PREPAID")]
        public int AmountPrepaid { get; set; }

        [JsonProperty("ANALYSIS_1")]
        public string Analysis1 { get; set; }

        [JsonProperty("ANALYSIS_2")]
        public string Analysis2 { get; set; }

        [JsonProperty("ANALYSIS_3")]
        public string Analysis3 { get; set; }

        [JsonProperty("CARR_DEPT_NUMBER")]
        public int CarrDeptNumber { get; set; }

        [JsonProperty("CARR_NET")]
        public int CarrNet { get; set; }

        [JsonProperty("CARR_NOM_CODE")]
        public string CarrNomCode { get; set; }

        [JsonProperty("CARR_TAX")]
        public int CarrTax { get; set; }

        [JsonProperty("CARR_TAX_CODE")]
        public int CarrTaxCode { get; set; }

        [JsonProperty("CONSIGNMENT_REF")]
        public string ConsignmentRef { get; set; }

        [JsonProperty("CONTACT_NAME")]
        public string ContactName { get; set; }

        [JsonProperty("COURIER")]
        public int Courier { get; set; }

        [JsonProperty("CURRENCY")]
        public int Currency { get; set; }

        [JsonProperty("CUST_DISC_RATE")]
        public int CustDiscRate { get; set; }

        [JsonProperty("CUST_ORDER_NUMBER")]
        public string CustOrderNumber { get; set; }

        [JsonProperty("CUST_TEL_NUMBER")]
        public string CustTelNumber { get; set; }

        [JsonProperty("DEF_TAX_CODE")]
        public int DefTaxCode { get; set; }

        [JsonProperty("DELETED_FLAG")]
        public bool DeletedFlag { get; set; }

        [JsonProperty("DELIVERY_NAME")]
        public string DeliveryName { get; set; }

        [JsonProperty("DEL_ADDRESS_1")]
        public string DelAddress1 { get; set; }

        [JsonProperty("DEL_ADDRESS_2")]
        public string DelAddress2 { get; set; }

        [JsonProperty("DEL_ADDRESS_3")]
        public string DelAddress3 { get; set; }

        [JsonProperty("DEL_ADDRESS_4")]
        public string DelAddress4 { get; set; }

        [JsonProperty("DEL_ADDRESS_5")]
        public string DelAddress5 { get; set; }

        [JsonProperty("DESPATCH_DATE")]
        public string DespatchDate { get; set; }

        [JsonProperty("DUNS_NUMBER")]
        public string DunsNumber { get; set; }

        [JsonProperty("GLOBAL_DEPT_NUMBER")]
        public int GlobalDeptNumber { get; set; }

        [JsonProperty("GLOBAL_DETAILS")]
        public string GlobalDetails { get; set; }

        [JsonProperty("GLOBAL_NOM_CODE")]
        public string GlobalNomCode { get; set; }

        [JsonProperty("GLOBAL_TAX_CODE")]
        public int GlobalTaxCode { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("ORDER_DATE")]
        public string OrderDate { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public int OrderNumber { get; set; }

        [JsonProperty("ORDER_TYPE")]
        public int OrderType { get; set; }

        [JsonProperty("SETTLEMENT_DISC_RATE")]
        public int SettlementDiscRate { get; set; }

        [JsonProperty("SETTLEMENT_DUE_DAYS")]
        public int SettlementDueDays { get; set; }
        public Sage50UKCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
    }

    public class Sage50UKCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        [JsonProperty("DESCRIPTION")]
        public string Description { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int DiscountRate { get; set; }

        [JsonProperty("QTY_ORDER")]
        public int QtyOrder { get; set; }

        [JsonProperty("STOCK_CODE")]
        public string StockCode { get; set; }

        [JsonProperty("UNIT_PRICE")]
        public int UnitPrice { get; set; }
    }

    public class Sage50UKCreateNewSalesOrderBodyInput
    {
        [JsonProperty("ACCOUNT_REF")]
        public string AccountRef { get; set; }

        [JsonProperty("ADDRESS_1")]
        public string Address1 { get; set; }

        [JsonProperty("ADDRESS_2")]
        public string Address2 { get; set; }

        [JsonProperty("ADDRESS_3")]
        public string Address3 { get; set; }

        [JsonProperty("ADDRESS_4")]
        public string Address4 { get; set; }

        [JsonProperty("ADDRESS_5")]
        public string Address5 { get; set; }

        [JsonProperty("AMOUNT_PREPAID")]
        public int? AmountPrepaid { get; set; }

        [JsonProperty("ANALYSIS_1")]
        public string Analysis1 { get; set; }

        [JsonProperty("ANALYSIS_2")]
        public string Analysis2 { get; set; }

        [JsonProperty("ANALYSIS_3")]
        public string Analysis3 { get; set; }

        [JsonProperty("CARR_DEPT_NUMBER")]
        public int? CarrDeptNumber { get; set; }

        [JsonProperty("CARR_NET")]
        public int? CarrNet { get; set; }

        [JsonProperty("CARR_NOM_CODE")]
        public string CarrNomCode { get; set; }

        [JsonProperty("CARR_TAX")]
        public int? CarrTax { get; set; }

        [JsonProperty("CARR_TAX_CODE")]
        public int? CarrTaxCode { get; set; }

        [JsonProperty("CONSIGNMENT_REF")]
        public string ConsignmentRef { get; set; }

        [JsonProperty("CONTACT_NAME")]
        public string ContactName { get; set; }

        [JsonProperty("COURIER")]
        public int? Courier { get; set; }

        [JsonProperty("CURRENCY")]
        public int? Currency { get; set; }

        [JsonProperty("CUST_DISC_RATE")]
        public int? CustDiscRate { get; set; }

        [JsonProperty("CUST_ORDER_NUMBER")]
        public string CustOrderNumber { get; set; }

        [JsonProperty("CUST_TEL_NUMBER")]
        public string CustTelNumber { get; set; }

        [JsonProperty("DEF_TAX_CODE")]
        public int? DefTaxCode { get; set; }

        [JsonProperty("DELETED_FLAG")]
        public bool? DeletedFlag { get; set; }

        [JsonProperty("DELIVERY_NAME")]
        public string DeliveryName { get; set; }

        [JsonProperty("DEL_ADDRESS_1")]
        public string DelAddress1 { get; set; }

        [JsonProperty("DEL_ADDRESS_2")]
        public string DelAddress2 { get; set; }

        [JsonProperty("DEL_ADDRESS_3")]
        public string DelAddress3 { get; set; }

        [JsonProperty("DEL_ADDRESS_4")]
        public string DelAddress4 { get; set; }

        [JsonProperty("DEL_ADDRESS_5")]
        public string DelAddress5 { get; set; }

        [JsonProperty("DESPATCH_DATE")]
        public string DespatchDate { get; set; }

        [JsonProperty("DUNS_NUMBER")]
        public string DunsNumber { get; set; }

        [JsonProperty("GLOBAL_DEPT_NUMBER")]
        public int? GlobalDeptNumber { get; set; }

        [JsonProperty("GLOBAL_DETAILS")]
        public string GlobalDetails { get; set; }

        [JsonProperty("GLOBAL_NOM_CODE")]
        public string GlobalNomCode { get; set; }

        [JsonProperty("GLOBAL_TAX_CODE")]
        public int? GlobalTaxCode { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("NAME")]
        public string Name { get; set; }

        [JsonProperty("ORDER_DATE")]
        public string OrderDate { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public int? OrderNumber { get; set; }

        [JsonProperty("ORDER_TYPE")]
        public int? OrderType { get; set; }

        [JsonProperty("SETTLEMENT_DISC_RATE")]
        public int? SettlementDiscRate { get; set; }

        [JsonProperty("SETTLEMENT_DUE_DAYS")]
        public int? SettlementDueDays { get; set; }
        public Sage50UKCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
    }

    public class Sage50UKCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem
    {
        [JsonProperty("DESCRIPTION")]
        public string Description { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int? DiscountRate { get; set; }

        [JsonProperty("QTY_ORDER")]
        public int? QtyOrder { get; set; }

        [JsonProperty("STOCK_CODE")]
        public string StockCode { get; set; }

        [JsonProperty("UNIT_PRICE")]
        public int? UnitPrice { get; set; }
    }

    public class Sage50USCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sage50USCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sage50USCreateNewCustomerResponseDataType
    {
        [JsonProperty("Account_Number")]
        public string AccountNumber { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingLastName { get; set; }
        public string BillingName { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }

        [JsonProperty("CC_Sales_Representative")]
        public bool CCSalesRepresentative { get; set; }

        [JsonProperty("Charge_Finance_Charges")]
        public bool ChargeFinanceCharges { get; set; }
        public string ContactName { get; set; }

        [JsonProperty("Credit_Limit")]
        public int CreditLimit { get; set; }

        [JsonProperty("Credit_Status")]
        public int CreditStatus { get; set; }
        public string CustomFieldValue1 { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string CustomFieldValue3 { get; set; }
        public string CustomFieldValue4 { get; set; }
        public string CustomFieldValue5 { get; set; }

        [JsonProperty("CustomerGUID")]
        public string CustomerGuid { get; set; }

        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("Customer_Balance")]
        public int CustomerBalance { get; set; }

        [JsonProperty("Customer_Since_Date")]
        public string CustomerSinceDate { get; set; }

        [JsonProperty("Customer_Type")]
        public string CustomerType { get; set; }

        [JsonProperty("Discount_Days")]
        public int DiscountDays { get; set; }

        [JsonProperty("Discount_Percent")]
        public int DiscountPercent { get; set; }

        [JsonProperty("Due_Days")]
        public int DueDays { get; set; }

        [JsonProperty("EMail_Address")]
        public string EMailAddress { get; set; }
        public string FaxNumber { get; set; }

        [JsonProperty("Form_Delivery_Method")]
        public int FormDeliveryMethod { get; set; }
        public string Name { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }

        [JsonProperty("Pricing_Level")]
        public int PricingLevel { get; set; }

        [JsonProperty("Sales_Representative_ID")]
        public string SalesRepresentativeId { get; set; }

        [JsonProperty("Sales_Tax_Code")]
        public string SalesTaxCode { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }

        [JsonProperty("Terms_Type")]
        public bool TermsType { get; set; }

        [JsonProperty("Use_COD_Terms")]
        public bool UseCodTerms { get; set; }

        [JsonProperty("Use_Due_Month_End_Terms")]
        public bool UseDueMonthEndTerms { get; set; }

        [JsonProperty("Use_Prepaid_Terms")]
        public bool UsePrepaidTerms { get; set; }

        [JsonProperty("Use_Standard_Terms")]
        public bool UseStandardTerms { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }
    }

    public class Sage50USCreateNewCustomerBodyInput
    {
        [JsonProperty("Account_Number")]
        public string AccountNumber { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingLastName { get; set; }
        public string BillingName { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }

        [JsonProperty("CC_Sales_Representative")]
        public bool? CCSalesRepresentative { get; set; }

        [JsonProperty("Charge_Finance_Charges")]
        public bool? ChargeFinanceCharges { get; set; }
        public string ContactName { get; set; }

        [JsonProperty("Credit_Limit")]
        public int? CreditLimit { get; set; }

        [JsonProperty("Credit_Status")]
        public int? CreditStatus { get; set; }
        public string CustomFieldValue1 { get; set; }
        public string CustomFieldValue2 { get; set; }
        public string CustomFieldValue3 { get; set; }
        public string CustomFieldValue4 { get; set; }
        public string CustomFieldValue5 { get; set; }

        [JsonProperty("CustomerGUID")]
        public string CustomerGuid { get; set; }

        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("Customer_Balance")]
        public int? CustomerBalance { get; set; }

        [JsonProperty("Customer_Since_Date")]
        public string CustomerSinceDate { get; set; }

        [JsonProperty("Customer_Type")]
        public string CustomerType { get; set; }

        [JsonProperty("Discount_Days")]
        public int? DiscountDays { get; set; }

        [JsonProperty("Discount_Percent")]
        public int? DiscountPercent { get; set; }

        [JsonProperty("Due_Days")]
        public int? DueDays { get; set; }

        [JsonProperty("EMail_Address")]
        public string EMailAddress { get; set; }
        public string FaxNumber { get; set; }

        [JsonProperty("Form_Delivery_Method")]
        public int? FormDeliveryMethod { get; set; }
        public string Name { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }

        [JsonProperty("Pricing_Level")]
        public int? PricingLevel { get; set; }

        [JsonProperty("Sales_Representative_ID")]
        public string SalesRepresentativeId { get; set; }

        [JsonProperty("Sales_Tax_Code")]
        public string SalesTaxCode { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }

        [JsonProperty("Terms_Type")]
        public bool? TermsType { get; set; }

        [JsonProperty("Use_COD_Terms")]
        public bool? UseCodTerms { get; set; }

        [JsonProperty("Use_Due_Month_End_Terms")]
        public bool? UseDueMonthEndTerms { get; set; }

        [JsonProperty("Use_Prepaid_Terms")]
        public bool? UsePrepaidTerms { get; set; }

        [JsonProperty("Use_Standard_Terms")]
        public bool? UseStandardTerms { get; set; }

        [JsonProperty("isInactive")]
        public bool? IsInactive { get; set; }
    }

    public class Sage50USCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sage50USCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sage50USCreateNewSalesOrderResponseDataType
    {
        [JsonProperty("Accounts_Receivable_Account")]
        public string AccountsReceivableAccount { get; set; }

        [JsonProperty("Accounts_Receivable_Acct_GUID")]
        public string AccountsReceivableAcctGuid { get; set; }

        [JsonProperty("Accounts_Receivable_Amount")]
        public int AccountsReceivableAmount { get; set; }
        public bool Closed { get; set; }

        [JsonProperty("Customer_ID")]
        public string CustomerId { get; set; }

        [JsonProperty("Customer_PO")]
        public string CustomerPO { get; set; }
        public string Date { get; set; }

        [JsonProperty("Discount_Amount")]
        public int DiscountAmount { get; set; }

        [JsonProperty("Displayed_Terms")]
        public string DisplayedTerms { get; set; }

        [JsonProperty("Drop_Ship")]
        public bool DropShip { get; set; }

        [JsonProperty("GUID")]
        public string Guid { get; set; }

        [JsonProperty("Note_Prints_After_Line_Items")]
        public bool NotePrintsAfterLineItems { get; set; }
        public bool Proposal { get; set; }
        public bool ProposalAccepted { get; set; }
        public Sage50USCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }

        [JsonProperty("Sales_Order_Number")]
        public string SalesOrderNumber { get; set; }

        [JsonProperty("Sales_Representative_GUID")]
        public string SalesRepresentativeGuid { get; set; }

        [JsonProperty("Sales_Representative_ID")]
        public string SalesRepresentativeId { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressLine1 { get; set; }
        public string ShipAddressLine2 { get; set; }
        public string ShipAddressName { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressZipCode { get; set; }

        [JsonProperty("Ship_By")]
        public string ShipBy { get; set; }

        [JsonProperty("Ship_VIA")]
        public string ShipVia { get; set; }

        [JsonProperty("Statement_Note_Prints_Before_Inv_Ref")]
        public bool StatementNotePrintsBeforeInvRef { get; set; }
    }

    public class Sage50USCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public int Amount { get; set; }
        public int DistributionNumber { get; set; }

        [JsonProperty("GL_Account")]
        public string GLAccount { get; set; }

        [JsonProperty("GL_Account_GUID")]
        public string GLAccountGuid { get; set; }

        [JsonProperty("Item_GUID")]
        public string ItemGuid { get; set; }

        [JsonProperty("Item_ID")]
        public string ItemId { get; set; }

        [JsonProperty("Job_GUID")]
        public string JobGuid { get; set; }

        [JsonProperty("Job_ID")]
        public string JobId { get; set; }
        public int Quantity { get; set; }

        [JsonProperty("SO_Description")]
        public string SODescription { get; set; }

        [JsonProperty("Stocking_Quantity")]
        public int StockingQuantity { get; set; }

        [JsonProperty("Stocking_Unit_Price")]
        public int StockingUnitPrice { get; set; }

        [JsonProperty("Tax_Type")]
        public int TaxType { get; set; }

        [JsonProperty("UM_ID")]
        public string UmId { get; set; }

        [JsonProperty("UM_Stocking_Units")]
        public int UMStockingUnits { get; set; }

        [JsonProperty("Unit_Price")]
        public int UnitPrice { get; set; }
        public int Weight { get; set; }
    }

    public class Sage50USCreateNewSalesOrderBodyInput
    {
        [JsonProperty("Accounts_Receivable_Account")]
        public string AccountsReceivableAccount { get; set; }

        [JsonProperty("Accounts_Receivable_Acct_GUID")]
        public string AccountsReceivableAcctGuid { get; set; }

        [JsonProperty("Accounts_Receivable_Amount")]
        public int? AccountsReceivableAmount { get; set; }
        public bool? Closed { get; set; }

        [JsonProperty("Customer_ID")]
        public string CustomerId { get; set; }

        [JsonProperty("Customer_PO")]
        public string CustomerPO { get; set; }
        public string Date { get; set; }

        [JsonProperty("Discount_Amount")]
        public int? DiscountAmount { get; set; }

        [JsonProperty("Displayed_Terms")]
        public string DisplayedTerms { get; set; }

        [JsonProperty("Drop_Ship")]
        public bool? DropShip { get; set; }

        [JsonProperty("GUID")]
        public string Guid { get; set; }

        [JsonProperty("Note_Prints_After_Line_Items")]
        public bool? NotePrintsAfterLineItems { get; set; }
        public bool? Proposal { get; set; }
        public bool? ProposalAccepted { get; set; }
        public Sage50USCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }

        [JsonProperty("Sales_Order_Number")]
        public string SalesOrderNumber { get; set; }

        [JsonProperty("Sales_Representative_GUID")]
        public string SalesRepresentativeGuid { get; set; }

        [JsonProperty("Sales_Representative_ID")]
        public string SalesRepresentativeId { get; set; }
        public string ShipAddressCity { get; set; }
        public string ShipAddressCountry { get; set; }
        public string ShipAddressLine1 { get; set; }
        public string ShipAddressLine2 { get; set; }
        public string ShipAddressName { get; set; }
        public string ShipAddressState { get; set; }
        public string ShipAddressZipCode { get; set; }

        [JsonProperty("Ship_By")]
        public string ShipBy { get; set; }

        [JsonProperty("Ship_VIA")]
        public string ShipVia { get; set; }

        [JsonProperty("Statement_Note_Prints_Before_Inv_Ref")]
        public bool? StatementNotePrintsBeforeInvRef { get; set; }
    }

    public class Sage50USCreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem
    {
        public int? Amount { get; set; }
        public int? DistributionNumber { get; set; }

        [JsonProperty("GL_Account")]
        public string GLAccount { get; set; }

        [JsonProperty("GL_Account_GUID")]
        public string GLAccountGuid { get; set; }

        [JsonProperty("Item_GUID")]
        public string ItemGuid { get; set; }

        [JsonProperty("Item_ID")]
        public string ItemId { get; set; }

        [JsonProperty("Job_GUID")]
        public string JobGuid { get; set; }

        [JsonProperty("Job_ID")]
        public string JobId { get; set; }
        public int? Quantity { get; set; }

        [JsonProperty("SO_Description")]
        public string SODescription { get; set; }

        [JsonProperty("Stocking_Quantity")]
        public int? StockingQuantity { get; set; }

        [JsonProperty("Stocking_Unit_Price")]
        public int? StockingUnitPrice { get; set; }

        [JsonProperty("Tax_Type")]
        public int? TaxType { get; set; }

        [JsonProperty("UM_ID")]
        public string UmId { get; set; }

        [JsonProperty("UM_Stocking_Units")]
        public int? UMStockingUnits { get; set; }

        [JsonProperty("Unit_Price")]
        public int? UnitPrice { get; set; }
        public int? Weight { get; set; }
    }

    public class Sapb1CreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sapb1CreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sapb1CreateNewCustomerResponseDataType
    {
        public string Address { get; set; }
        public string BillingBlock { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }
        public string BillingZipCode { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Currency { get; set; }
        public string EmailAddress { get; set; }
        public string ExtraField { get; set; }
        public string Fax { get; set; }
        public string FreeText { get; set; }
        public int GroupCode { get; set; }
        public bool GroupCodeSpecified { get; set; }
        public string MailAddress { get; set; }
        public string MailCity { get; set; }
        public string MailCountry { get; set; }
        public string MailCounty { get; set; }
        public string MailZipCode { get; set; }
        public string Notes { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string ShippingBlock { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingZipCode { get; set; }
        public string ZipCode { get; set; }

        [JsonProperty("lstContactEmployees")]
        public Sapb1CreateNewCustomerResponseDataTypeLstContactEmployeesTypeItem[] LstContactEmployees { get; set; }
    }

    public class Sapb1CreateNewCustomerResponseDataTypeLstContactEmployeesTypeItem
    {
        public string Address { get; set; }
        public string CityOfBirth { get; set; }
        public string DateOfBirth { get; set; }
        public bool DateOfBirthSpecified { get; set; }

        [JsonProperty("E_Mail")]
        public string EMail { get; set; }
        public string Fax { get; set; }
        public string Gender { get; set; }
        public int InternalCode { get; set; }
        public bool InternalCodeSpecified { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public string Pager { get; set; }
        public string Password { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Position { get; set; }
        public string Profession { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string Title { get; set; }
    }

    public class Sapb1CreateNewCustomerBodyInput
    {
        public string Address { get; set; }
        public string BillingAddressName { get; set; }
        public string BillingBlock { get; set; }
        public string BillingCity { get; set; }
        public string BillingCountry { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }
        public string BillingZipCode { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public string City { get; set; }
        public string ContactPerson { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Currency { get; set; }
        public string EmailAddress { get; set; }
        public string ExtraField { get; set; }
        public string Fax { get; set; }

        [JsonProperty("FederalTaxID")]
        public string FederalTaxId { get; set; }
        public string FreeText { get; set; }
        public int? GroupCode { get; set; }
        public string MailAddress { get; set; }
        public string MailCity { get; set; }
        public string MailCountry { get; set; }
        public string MailCounty { get; set; }
        public string MailZipCode { get; set; }
        public string Notes { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int? SalesPersonCode { get; set; }
        public int? Series { get; set; }
        public string ShippingAddressName { get; set; }
        public string ShippingBlock { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingZipCode { get; set; }
        public string WebSite { get; set; }
        public string ZipCode { get; set; }

        [JsonProperty("lstContactEmployees")]
        public BodyInputLstContactEmployeesTypeItem[] LstContactEmployees { get; set; }
    }

    public class BodyInputLstContactEmployeesTypeItem
    {
        public string Address { get; set; }
        public string CityOfBirth { get; set; }
        public string DateOfBirth { get; set; }

        [JsonProperty("E_Mail")]
        public string EMail { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int? InternalCode { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string MobilePhone { get; set; }
        public string Name { get; set; }
        public string Pager { get; set; }
        public string Password { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PlaceOfBirth { get; set; }
        public string Position { get; set; }
        public string Profession { get; set; }
        public string Remarks1 { get; set; }
        public string Remarks2 { get; set; }
        public string Title { get; set; }
        public string UserFieldsName { get; set; }
        public string UserFieldsValues { get; set; }
    }

    public class Sapb1CreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Sapb1CreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class Sapb1CreateNewSalesOrderResponseDataType
    {
        public string CardCode { get; set; }
        public string DocDate { get; set; }
        public bool DocDateSpecified { get; set; }
        public string DocDueDate { get; set; }
        public bool DocDueDateSpecified { get; set; }
        public int DocNum { get; set; }
        public bool DocNumSpecified { get; set; }
        public Sapb1CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public int Series { get; set; }
        public bool SeriesSpecified { get; set; }
        public string TaxDate { get; set; }
        public bool TaxDateSpecified { get; set; }
    }

    public class Sapb1CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public int DiscountPercent { get; set; }
        public bool DiscountPercentSpecified { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public bool QuantitySpecified { get; set; }
        public int UnitPrice { get; set; }
        public bool UnitPriceSpecified { get; set; }
        public string WarehouseCode { get; set; }
    }

    public class Sapb1CreateNewSalesOrderBodyInput
    {
        public string CardCode { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public int? DocNum { get; set; }
        public Sapb1CreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public int? Series { get; set; }
        public string TaxDate { get; set; }
    }

    public class Sapb1CreateNewSalesOrderBodyInputSalesOrderLineItemTypeItem
    {
        public int? DiscountPercent { get; set; }
        public string ItemCode { get; set; }
        public int? Quantity { get; set; }
        public int? UnitPrice { get; set; }
        public string WarehouseCode { get; set; }
    }

    public class SysproCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SysproCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SysproCreateNewCustomerResponseDataType
    {
        public string AddTelephone { get; set; }
        public string AltMethodFlag { get; set; }
        public string ApplyLineDisc { get; set; }
        public string ApplyOrdDisc { get; set; }
        public string ArStatementNo { get; set; }
        public string Area { get; set; }
        public string BackOrdReqd { get; set; }
        public string BalanceType { get; set; }
        public string Branch { get; set; }
        public string BuyingGroup1 { get; set; }
        public string BuyingGroup2 { get; set; }
        public string BuyingGroup3 { get; set; }
        public string BuyingGroup4 { get; set; }
        public string BuyingGroup5 { get; set; }
        public string City { get; set; }
        public string City1 { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string Contact { get; set; }
        public string ContractPrcReqd { get; set; }
        public string CounterSlsOnly { get; set; }
        public string CountyZip { get; set; }
        public string CountyZip1 { get; set; }
        public string CreditCheckFlag { get; set; }
        public string CreditLimit { get; set; }
        public string CreditStatus { get; set; }
        public string Currency { get; set; }
        public string CustomerClass { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerOnHold { get; set; }
        public string DateCustAdded { get; set; }
        public string DefaultOrdType { get; set; }
        public string DeliveryTerms { get; set; }
        public string DeliveryTermsC { get; set; }
        public string DetailMoveReqd { get; set; }
        public string DocFax { get; set; }
        public string DocFaxContact { get; set; }
        public string EdiFlag { get; set; }
        public string EdiSenderCode { get; set; }
        public string Email { get; set; }
        public string ExemptFinChg { get; set; }
        public string Fax { get; set; }
        public string FaxInvoices { get; set; }
        public string FaxQuotes { get; set; }
        public string FaxStatements { get; set; }
        public string GstExemptFlag { get; set; }
        public string GstExemptNum { get; set; }
        public string GstLevel { get; set; }
        public string HighInv { get; set; }
        public string HighInvDays { get; set; }
        public string HighestBalance { get; set; }
        public string IbtCustomer { get; set; }
        public string InvCommentCode { get; set; }
        public string InvDiscCode { get; set; }
        public string LanguageCode { get; set; }
        public string LineDiscCode { get; set; }
        public string MaintHistory { get; set; }
        public string MaintLastPrcPaid { get; set; }
        public string MinimumOrderChgCod { get; set; }
        public string MinimumOrderValue { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string NewCustomerCode { get; set; }
        public string PoNumberMandatory { get; set; }
        public string PriceCategoryTable { get; set; }
        public string PriceCode { get; set; }
        public string RouteCode { get; set; }
        public string RouteDistance { get; set; }
        public string SalesWarehouse { get; set; }
        public string Salesperson { get; set; }
        public string Salesperson1 { get; set; }
        public string Salesperson2 { get; set; }
        public string Salesperson3 { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipToAddr1 { get; set; }
        public string ShipToAddr2 { get; set; }
        public string ShipToAddr3 { get; set; }
        public string ShipToAddr3Loc { get; set; }
        public string ShipToAddr4 { get; set; }
        public string ShipToAddr5 { get; set; }
        public string ShipToGpsLat { get; set; }
        public string ShipToGpsLong { get; set; }
        public string ShippingInstrs { get; set; }
        public string ShippingInstrsCod { get; set; }
        public string ShippingLocation { get; set; }
        public string ShortName { get; set; }
        public string SoDefaultDoc { get; set; }
        public string SoDefaultType { get; set; }
        public string SoldPostalCode { get; set; }
        public string SoldToAddr1 { get; set; }
        public string SoldToAddr2 { get; set; }
        public string SoldToAddr3 { get; set; }
        public string SoldToAddr3Loc { get; set; }
        public string SoldToAddr4 { get; set; }
        public string SoldToAddr5 { get; set; }
        public string SoldToGpsLat { get; set; }
        public string SoldToGpsLong { get; set; }
        public string SpecialInstrs { get; set; }
        public string State { get; set; }
        public string State1 { get; set; }
        public string StateCode { get; set; }
        public string StatementReqd { get; set; }
        public string StockInterchange { get; set; }

        [JsonProperty("TagsToDropFromXML")]
        public string TagsToDropFromXml { get; set; }
        public string TaxExemptNumber { get; set; }
        public string TaxStatus { get; set; }
        public string Telephone { get; set; }
        public string TelephoneExtn { get; set; }
        public string Telex { get; set; }
        public string TermsCode { get; set; }
        public string TpmCreditCheck { get; set; }
        public string TpmCustomerFlag { get; set; }
        public string TpmPricingFlag { get; set; }
        public string TransactionNature { get; set; }
        public string TransactionNatureC { get; set; }
        public string UkCurrency { get; set; }
        public string UkVatFlag { get; set; }
        public string UserField1 { get; set; }
        public string UserField2 { get; set; }
        public string WholeOrderShipFlag { get; set; }

        [JsonProperty("eSignature")]
        public string ESignature { get; set; }
    }

    public class SysproCreateNewCustomerBodyInput
    {
        public string AddTelephone { get; set; }
        public string AltMethodFlag { get; set; }
        public string ApplyLineDisc { get; set; }
        public string ApplyOrdDisc { get; set; }
        public string ArStatementNo { get; set; }
        public string Area { get; set; }
        public string BackOrdReqd { get; set; }
        public string BalanceType { get; set; }
        public string Branch { get; set; }
        public string BuyingGroup1 { get; set; }
        public string BuyingGroup2 { get; set; }
        public string BuyingGroup3 { get; set; }
        public string BuyingGroup4 { get; set; }
        public string BuyingGroup5 { get; set; }
        public string City { get; set; }
        public string City1 { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string Contact { get; set; }
        public string ContractPrcReqd { get; set; }
        public string CounterSlsOnly { get; set; }
        public string CountyZip { get; set; }
        public string CountyZip1 { get; set; }
        public string CreditCheckFlag { get; set; }
        public string CreditLimit { get; set; }
        public string CreditStatus { get; set; }
        public string Currency { get; set; }
        public string CustomerClass { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerOnHold { get; set; }
        public string DateCustAdded { get; set; }
        public string DefaultOrdType { get; set; }
        public string DeliveryTerms { get; set; }
        public string DeliveryTermsC { get; set; }
        public string DetailMoveReqd { get; set; }
        public string DocFax { get; set; }
        public string DocFaxContact { get; set; }
        public string EdiFlag { get; set; }
        public string EdiSenderCode { get; set; }
        public string Email { get; set; }
        public string ExemptFinChg { get; set; }
        public string Fax { get; set; }
        public string FaxInvoices { get; set; }
        public string FaxQuotes { get; set; }
        public string FaxStatements { get; set; }
        public string GstExemptFlag { get; set; }
        public string GstExemptNum { get; set; }
        public string GstLevel { get; set; }
        public string HighInv { get; set; }
        public string HighInvDays { get; set; }
        public string HighestBalance { get; set; }
        public string IbtCustomer { get; set; }
        public string InvCommentCode { get; set; }
        public string InvDiscCode { get; set; }
        public string LanguageCode { get; set; }
        public string LineDiscCode { get; set; }
        public string MaintHistory { get; set; }
        public string MaintLastPrcPaid { get; set; }
        public string MinimumOrderChgCod { get; set; }
        public string MinimumOrderValue { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public string NewCustomerCode { get; set; }
        public string PoNumberMandatory { get; set; }
        public string PriceCategoryTable { get; set; }
        public string PriceCode { get; set; }
        public string RouteCode { get; set; }
        public string RouteDistance { get; set; }
        public string SalesWarehouse { get; set; }
        public string Salesperson { get; set; }
        public string Salesperson1 { get; set; }
        public string Salesperson2 { get; set; }
        public string Salesperson3 { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipToAddr1 { get; set; }
        public string ShipToAddr2 { get; set; }
        public string ShipToAddr3 { get; set; }
        public string ShipToAddr3Loc { get; set; }
        public string ShipToAddr4 { get; set; }
        public string ShipToAddr5 { get; set; }
        public string ShipToGpsLat { get; set; }
        public string ShipToGpsLong { get; set; }
        public string ShippingInstrs { get; set; }
        public string ShippingInstrsCod { get; set; }
        public string ShippingLocation { get; set; }
        public string ShortName { get; set; }
        public string SoDefaultDoc { get; set; }
        public string SoDefaultType { get; set; }
        public string SoldPostalCode { get; set; }
        public string SoldToAddr1 { get; set; }
        public string SoldToAddr2 { get; set; }
        public string SoldToAddr3 { get; set; }
        public string SoldToAddr3Loc { get; set; }
        public string SoldToAddr4 { get; set; }
        public string SoldToAddr5 { get; set; }
        public string SoldToGpsLat { get; set; }
        public string SoldToGpsLong { get; set; }
        public string SpecialInstrs { get; set; }
        public string State { get; set; }
        public string State1 { get; set; }
        public string StateCode { get; set; }
        public string StatementReqd { get; set; }
        public string StockInterchange { get; set; }

        [JsonProperty("TagsToDropFromXML")]
        public string TagsToDropFromXml { get; set; }
        public string TaxExemptNumber { get; set; }
        public string TaxStatus { get; set; }
        public string Telephone { get; set; }
        public string TelephoneExtn { get; set; }
        public string Telex { get; set; }
        public string TermsCode { get; set; }
        public string TpmCreditCheck { get; set; }
        public string TpmCustomerFlag { get; set; }
        public string TpmPricingFlag { get; set; }
        public string TransactionNature { get; set; }
        public string TransactionNatureC { get; set; }
        public string UkCurrency { get; set; }
        public string UkVatFlag { get; set; }
        public string UserField1 { get; set; }
        public string UserField2 { get; set; }
        public string WholeOrderShipFlag { get; set; }

        [JsonProperty("eSignature")]
        public string ESignature { get; set; }
    }

    public class SysproCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SysproCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SysproCreateNewSalesOrderResponseDataType
    {
        public string AcceptEarlierShipDate { get; set; }
        public string AcceptKitOptional { get; set; }
        public string AcceptOrdersIfNoCredit { get; set; }
        public string AddAttachedServiceCharges { get; set; }
        public string AddDangerousGoodsText { get; set; }
        public string AddStockSalesOrderText { get; set; }
        public string AllocationAction { get; set; }
        public string AllowBackOrderForNegativeMerchLine { get; set; }
        public string AllowBackOrderForPartialHold { get; set; }
        public string AllowBackOrderForSuperseded { get; set; }
        public string AllowChangeToZeroPrice { get; set; }
        public string AllowDuplicateOrderNumbers { get; set; }
        public string AllowManualOrderNumberToBeUsed { get; set; }
        public string AllowNonStockItems { get; set; }
        public string AllowZeroPrice { get; set; }
        public string AlternateReference { get; set; }
        public string AlwaysUsePriceEntered { get; set; }
        public string ApplyLeadTimeCalculation { get; set; }
        public string ApplyParentDiscountToComponents { get; set; }
        public string Area { get; set; }
        public string Branch { get; set; }
        public string CancelReasonCode { get; set; }
        public string CheckForCustomerPoNumbers { get; set; }
        public string City { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string CountyZip { get; set; }
        public string CreditFailMessage { get; set; }
        public string Currency { get; set; }
        public string Customer { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPoNumber { get; set; }
        public string CustomerToUse { get; set; }
        public string DeliveryRoute { get; set; }
        public string DeliveryRouteAction { get; set; }
        public string DeliveryTerms { get; set; }
        public string DocumentFormat { get; set; }
        public string Email { get; set; }
        public string GlobalTradePromotionCodes { get; set; }
        public string GstExemptNumber { get; set; }
        public string GstExemptionStatus { get; set; }
        public string HeaderFreightCharges { get; set; }
        public string HeaderMiscCharges { get; set; }
        public string IgnoreWarnings { get; set; }
        public string InBoxMsgReqd { get; set; }
        public string IncludeInMrp { get; set; }
        public string InvoiceDateEntered { get; set; }
        public string InvoiceNumberEntered { get; set; }
        public string InvoiceTerms { get; set; }
        public string InvoiceWholeOrderOnly { get; set; }
        public string LanguageCode { get; set; }
        public string MinimumDaysToShip { get; set; }
        public string MultiShipCode { get; set; }
        public string Nationality { get; set; }
        public string NewCustomerPoNumber { get; set; }
        public string NewSalesOrderNumber { get; set; }
        public string OperatorToInform { get; set; }
        public string OrderActionType { get; set; }
        public string OrderComments { get; set; }
        public string OrderDate { get; set; }
        public string OrderDiscPercent1 { get; set; }
        public string OrderDiscPercent2 { get; set; }
        public string OrderDiscPercent3 { get; set; }
        public string OrderStatus { get; set; }
        public string OrderType { get; set; }
        public string OverrideCustomerBackOrder { get; set; }

        [JsonProperty("POSSalesOrder")]
        public string PosSalesOrder { get; set; }
        public string Process { get; set; }
        public string ProcessFlag { get; set; }
        public string PutEntireQuantityOnNewLoadWhenChanged { get; set; }
        public string ReceiverCode { get; set; }
        public string RequestedShipDate { get; set; }
        public string ReserveStock { get; set; }
        public string ReserveStockRequestAllocs { get; set; }
        public string SalesOrder { get; set; }
        public SysproCreateNewSalesOrderResponseDataTypeSalesOrderDetailsTypeItem[] SalesOrderDetails { get; set; }
        public SysproCreateNewSalesOrderResponseDataTypeSalesOrderFooterCommentsTypeItem[] SalesOrderFooterComments { get; set; }
        public SysproCreateNewSalesOrderResponseDataTypeSalesOrderFreightDetailsTypeItem[] SalesOrderFreightDetails { get; set; }
        public SysproCreateNewSalesOrderResponseDataTypeSalesOrderHeaderCommentsTypeItem[] SalesOrderHeaderComments { get; set; }
        public SysproCreateNewSalesOrderResponseDataTypeSalesOrderMiscChargesDetailsTypeItem[] SalesOrderMiscChargesDetails { get; set; }
        public string SalesOrderPromoQualifyAction { get; set; }
        public string SalesOrderPromoSelectAction { get; set; }
        public string Salesperson { get; set; }
        public string SenderCode { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipAddress3Locality { get; set; }
        public string ShipAddress4 { get; set; }
        public string ShipAddress5 { get; set; }
        public string ShipAddressPerLine { get; set; }
        public string ShipAddressPerLineTax { get; set; }
        public string ShipGpsLat { get; set; }
        public string ShipGpsLong { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShippingInstrs { get; set; }
        public string ShippingInstrsCode { get; set; }
        public string ShippingLocation { get; set; }
        public string SpecialInstrs { get; set; }
        public string State { get; set; }
        public string StatusInProcess { get; set; }
        public string StatusInProcessResponse { get; set; }
        public string Supplier { get; set; }

        [JsonProperty("TagsToDropFromXML")]
        public string TagsToDropFromXml { get; set; }
        public string TaxExemptNumber { get; set; }
        public string TaxExemptionStatus { get; set; }
        public string TransactionNature { get; set; }
        public string TransmissionReference { get; set; }
        public string TransportMode { get; set; }
        public string TypeOfOrder { get; set; }
        public string UseCustomerSalesWarehouse { get; set; }
        public string UseMasterAccountForCustomerPartNo { get; set; }
        public string UseStockDescSupplied { get; set; }
        public string ValidateShippingInstrs { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseListToUse { get; set; }
        public string WarnIfCustomerOnHold { get; set; }

        [JsonProperty("eSignature")]
        public string ESignature { get; set; }
    }

    public class SysproCreateNewSalesOrderResponseDataTypeSalesOrderDetailsTypeItem
    {
        public string AlwaysUseDiscountEntered { get; set; }
        public string CommissionCode { get; set; }
        public string ConfigPrintAck { get; set; }
        public string ConfigPrintDel { get; set; }
        public string ConfigPrintInv { get; set; }
        public string CustRequestDate { get; set; }
        public string CustomersPartNumber { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryRouteCode { get; set; }
        public string DeliverySequence { get; set; }
        public string LineActionType { get; set; }
        public string LineAllocationAction { get; set; }
        public string LineAlwaysUsePriceEntered { get; set; }
        public string LineCancelCode { get; set; }
        public string LineDiscPercent1 { get; set; }
        public string LineDiscPercent2 { get; set; }
        public string LineDiscPercent3 { get; set; }
        public string LineDiscValFlag { get; set; }
        public string LineDiscValue { get; set; }
        public string LineIncludeInMrp { get; set; }
        public string LineMultiShipCode { get; set; }
        public string LineReserveStock { get; set; }
        public string LineReserveStockRequestAllocs { get; set; }
        public string LineShipDate { get; set; }
        public string LineWarehouse { get; set; }
        public string NonStockedLine { get; set; }
        public string NsProductClass { get; set; }
        public string NsUnitCost { get; set; }
        public string OrderQty { get; set; }
        public string OrderUom { get; set; }
        public string OverrideCalculatedDiscount { get; set; }
        public string Pieces { get; set; }
        public string Price { get; set; }
        public string PriceCode { get; set; }
        public string PriceUom { get; set; }
        public string ProductClass { get; set; }
        public string StockCode { get; set; }
        public string StockDescription { get; set; }
        public string StockFstCode { get; set; }
        public string StockLineComment { get; set; }
        public string StockLineCommentActionType { get; set; }
        public string StockLineCommentCommentType { get; set; }
        public string StockNotFstTaxable { get; set; }
        public string StockNotTaxable { get; set; }
        public string StockTaxCode { get; set; }
        public string SupplementaryUnitsFactor { get; set; }
        public string TariffCode { get; set; }
        public string TradePromotionCodes { get; set; }
        public string UnitMass { get; set; }
        public string UnitVolume { get; set; }
        public string Units { get; set; }
        public string UserDefined { get; set; }
    }

    public class SysproCreateNewSalesOrderResponseDataTypeSalesOrderFooterCommentsTypeItem
    {
        public string FooterComment { get; set; }
        public string FooterCommentType { get; set; }
        public string FooterLineActionType { get; set; }
    }

    public class SysproCreateNewSalesOrderResponseDataTypeSalesOrderFreightDetailsTypeItem
    {
        public string FreightCost { get; set; }
        public string FreightFstCode { get; set; }
        public string FreightLineActionType { get; set; }
        public string FreightLineCancelCode { get; set; }
        public string FreightNotFstTaxable { get; set; }
        public string FreightNotTaxable { get; set; }
        public string FreightTaxCode { get; set; }
        public string FreightValue { get; set; }
    }

    public class SysproCreateNewSalesOrderResponseDataTypeSalesOrderHeaderCommentsTypeItem
    {
        public string HeaderComment { get; set; }
        public string HeaderCommentType { get; set; }
        public string HeaderLineActionType { get; set; }
    }

    public class SysproCreateNewSalesOrderResponseDataTypeSalesOrderMiscChargesDetailsTypeItem
    {
        public string MiscChargeCode { get; set; }
        public string MiscChargeCost { get; set; }
        public string MiscChargeValue { get; set; }
        public string MiscConfigPrintAck { get; set; }
        public string MiscConfigPrintDel { get; set; }
        public string MiscConfigPrintInv { get; set; }
        public string MiscDescription { get; set; }
        public string MiscFstCode { get; set; }
        public string MiscLineActionType { get; set; }
        public string MiscLineCancelCode { get; set; }
        public string MiscNotFstTaxable { get; set; }
        public string MiscNotTaxable { get; set; }
        public string MiscProductClass { get; set; }
        public string MiscQuantity { get; set; }
        public string MiscSvcChargePrice { get; set; }
        public string MiscTariffCode { get; set; }
        public string MiscTaxCode { get; set; }
    }

    public class SysproCreateNewSalesOrderBodyInput
    {
        public string AcceptEarlierShipDate { get; set; }
        public string AcceptKitOptional { get; set; }
        public string AcceptOrdersIfNoCredit { get; set; }
        public string AddAttachedServiceCharges { get; set; }
        public string AddDangerousGoodsText { get; set; }
        public string AddStockSalesOrderText { get; set; }
        public string AllocationAction { get; set; }
        public string AllowBackOrderForNegativeMerchLine { get; set; }
        public string AllowBackOrderForPartialHold { get; set; }
        public string AllowBackOrderForSuperseded { get; set; }
        public string AllowChangeToZeroPrice { get; set; }
        public string AllowDuplicateOrderNumbers { get; set; }
        public string AllowManualOrderNumberToBeUsed { get; set; }
        public string AllowNonStockItems { get; set; }
        public string AllowZeroPrice { get; set; }
        public string AlternateReference { get; set; }
        public string AlwaysUsePriceEntered { get; set; }
        public string ApplyLeadTimeCalculation { get; set; }
        public string ApplyParentDiscountToComponents { get; set; }
        public string Area { get; set; }
        public string Branch { get; set; }
        public string CancelReasonCode { get; set; }
        public string CheckForCustomerPoNumbers { get; set; }
        public string City { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string CountyZip { get; set; }
        public string CreditFailMessage { get; set; }
        public string Currency { get; set; }
        public string Customer { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPoNumber { get; set; }
        public string CustomerToUse { get; set; }
        public string DeliveryRoute { get; set; }
        public string DeliveryRouteAction { get; set; }
        public string DeliveryTerms { get; set; }
        public string DocumentFormat { get; set; }
        public string Email { get; set; }
        public string GlobalTradePromotionCodes { get; set; }
        public string GstExemptNumber { get; set; }
        public string GstExemptionStatus { get; set; }
        public string HeaderFreightCharges { get; set; }
        public string HeaderMiscCharges { get; set; }
        public string IgnoreWarnings { get; set; }
        public string InBoxMsgReqd { get; set; }
        public string IncludeInMrp { get; set; }
        public string InvoiceDateEntered { get; set; }
        public string InvoiceNumberEntered { get; set; }
        public string InvoiceTerms { get; set; }
        public string InvoiceWholeOrderOnly { get; set; }
        public string LanguageCode { get; set; }
        public string MinimumDaysToShip { get; set; }
        public string MultiShipCode { get; set; }
        public string Nationality { get; set; }
        public string NewCustomerPoNumber { get; set; }
        public string NewSalesOrderNumber { get; set; }
        public string OperatorToInform { get; set; }
        public string OrderActionType { get; set; }
        public string OrderComments { get; set; }
        public string OrderDate { get; set; }
        public string OrderDiscPercent1 { get; set; }
        public string OrderDiscPercent2 { get; set; }
        public string OrderDiscPercent3 { get; set; }
        public string OrderStatus { get; set; }
        public string OrderType { get; set; }
        public string OverrideCustomerBackOrder { get; set; }

        [JsonProperty("POSSalesOrder")]
        public string PosSalesOrder { get; set; }
        public string Process { get; set; }
        public string ProcessFlag { get; set; }
        public string PutEntireQuantityOnNewLoadWhenChanged { get; set; }
        public string ReceiverCode { get; set; }
        public string RequestedShipDate { get; set; }
        public string ReserveStock { get; set; }
        public string ReserveStockRequestAllocs { get; set; }
        public string SalesOrder { get; set; }
        public BodyInputSalesOrderDetailsTypeItem[] SalesOrderDetails { get; set; }
        public BodyInputSalesOrderFooterCommentsTypeItem[] SalesOrderFooterComments { get; set; }
        public BodyInputSalesOrderFreightDetailsTypeItem[] SalesOrderFreightDetails { get; set; }
        public BodyInputSalesOrderHeaderCommentsTypeItem[] SalesOrderHeaderComments { get; set; }
        public BodyInputSalesOrderMiscChargesDetailsTypeItem[] SalesOrderMiscChargesDetails { get; set; }
        public string SalesOrderPromoQualifyAction { get; set; }
        public string SalesOrderPromoSelectAction { get; set; }
        public string Salesperson { get; set; }
        public string SenderCode { get; set; }
        public string ShipAddress1 { get; set; }
        public string ShipAddress2 { get; set; }
        public string ShipAddress3 { get; set; }
        public string ShipAddress3Locality { get; set; }
        public string ShipAddress4 { get; set; }
        public string ShipAddress5 { get; set; }
        public string ShipAddressPerLine { get; set; }
        public string ShipAddressPerLineTax { get; set; }
        public string ShipGpsLat { get; set; }
        public string ShipGpsLong { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShippingInstrs { get; set; }
        public string ShippingInstrsCode { get; set; }
        public string ShippingLocation { get; set; }
        public string SpecialInstrs { get; set; }
        public string State { get; set; }
        public string StatusInProcess { get; set; }
        public string StatusInProcessResponse { get; set; }
        public string Supplier { get; set; }

        [JsonProperty("TagsToDropFromXML")]
        public string TagsToDropFromXml { get; set; }
        public string TaxExemptNumber { get; set; }
        public string TaxExemptionStatus { get; set; }
        public string TransactionNature { get; set; }
        public string TransmissionReference { get; set; }
        public string TransportMode { get; set; }
        public string TypeOfOrder { get; set; }
        public string UseCustomerSalesWarehouse { get; set; }
        public string UseMasterAccountForCustomerPartNo { get; set; }
        public string UseStockDescSupplied { get; set; }
        public string ValidateShippingInstrs { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseListToUse { get; set; }
        public string WarnIfCustomerOnHold { get; set; }

        [JsonProperty("eSignature")]
        public string ESignature { get; set; }
    }

    public class BodyInputSalesOrderDetailsTypeItem
    {
        public string AlwaysUseDiscountEntered { get; set; }
        public string CommissionCode { get; set; }
        public string ConfigPrintAck { get; set; }
        public string ConfigPrintDel { get; set; }
        public string ConfigPrintInv { get; set; }
        public string CustRequestDate { get; set; }
        public string CustomersPartNumber { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryRouteCode { get; set; }
        public string DeliverySequence { get; set; }
        public string LineActionType { get; set; }
        public string LineAllocationAction { get; set; }
        public string LineAlwaysUsePriceEntered { get; set; }
        public string LineCancelCode { get; set; }
        public string LineDiscPercent1 { get; set; }
        public string LineDiscPercent2 { get; set; }
        public string LineDiscPercent3 { get; set; }
        public string LineDiscValFlag { get; set; }
        public string LineDiscValue { get; set; }
        public string LineIncludeInMrp { get; set; }
        public string LineMultiShipCode { get; set; }
        public string LineReserveStock { get; set; }
        public string LineReserveStockRequestAllocs { get; set; }
        public string LineShipDate { get; set; }
        public string LineWarehouse { get; set; }
        public string NonStockedLine { get; set; }
        public string NsProductClass { get; set; }
        public string NsUnitCost { get; set; }
        public string OrderQty { get; set; }
        public string OrderUom { get; set; }
        public string OverrideCalculatedDiscount { get; set; }
        public string Pieces { get; set; }
        public string Price { get; set; }
        public string PriceCode { get; set; }
        public string PriceUom { get; set; }
        public string ProductClass { get; set; }
        public string StockCode { get; set; }
        public string StockDescription { get; set; }
        public string StockFstCode { get; set; }
        public string StockLineComment { get; set; }
        public string StockLineCommentActionType { get; set; }
        public string StockLineCommentCommentType { get; set; }
        public string StockNotFstTaxable { get; set; }
        public string StockNotTaxable { get; set; }
        public string StockTaxCode { get; set; }
        public string SupplementaryUnitsFactor { get; set; }
        public string TariffCode { get; set; }
        public string TradePromotionCodes { get; set; }
        public string UnitMass { get; set; }
        public string UnitVolume { get; set; }
        public string Units { get; set; }
        public string UserDefined { get; set; }
    }

    public class BodyInputSalesOrderFooterCommentsTypeItem
    {
        public string FooterComment { get; set; }
        public string FooterCommentType { get; set; }
        public string FooterLineActionType { get; set; }
    }

    public class BodyInputSalesOrderFreightDetailsTypeItem
    {
        public string FreightCost { get; set; }
        public string FreightFstCode { get; set; }
        public string FreightLineActionType { get; set; }
        public string FreightLineCancelCode { get; set; }
        public string FreightNotFstTaxable { get; set; }
        public string FreightNotTaxable { get; set; }
        public string FreightTaxCode { get; set; }
        public string FreightValue { get; set; }
    }

    public class BodyInputSalesOrderHeaderCommentsTypeItem
    {
        public string HeaderComment { get; set; }
        public string HeaderCommentType { get; set; }
        public string HeaderLineActionType { get; set; }
    }

    public class BodyInputSalesOrderMiscChargesDetailsTypeItem
    {
        public string MiscChargeCode { get; set; }
        public string MiscChargeCost { get; set; }
        public string MiscChargeValue { get; set; }
        public string MiscConfigPrintAck { get; set; }
        public string MiscConfigPrintDel { get; set; }
        public string MiscConfigPrintInv { get; set; }
        public string MiscDescription { get; set; }
        public string MiscFstCode { get; set; }
        public string MiscLineActionType { get; set; }
        public string MiscLineCancelCode { get; set; }
        public string MiscNotFstTaxable { get; set; }
        public string MiscNotTaxable { get; set; }
        public string MiscProductClass { get; set; }
        public string MiscQuantity { get; set; }
        public string MiscSvcChargePrice { get; set; }
        public string MiscTariffCode { get; set; }
        public string MiscTaxCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Commercientcpq;

    public partial class WorkflowManagedActions
    {
        public CommercientcpqActions Commercientcpq(string connectionId) => new CommercientcpqActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CommercientcpqTriggers Commercientcpq(string connectionId) => new CommercientcpqTriggers(connectionId);
    }
}