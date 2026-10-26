//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fieldequip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FieldequipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateCustomer(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/customer/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateCustomer(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/customer/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateWorkOrders(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/workorder/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateWorkOrders(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/workorder/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateItems(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<bodyInputItem22[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/item/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateItems(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<bodyInputItem22[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/item/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateInventory(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<string>> warehouseRefNum = null, Expression<Func<bodyInputItem222[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_warehouseRefNum = WorkflowExpression.Compile(warehouseRefNum, nameof(warehouseRefNum), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/warehouse/inventory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                if (__workflow_warehouseRefNum != null)
                    callPayload.Queries["warehouseRefNum"] = ExpressionConverter.Convert(__workflow_warehouseRefNum);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateItemAdjustment(Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<string>> companyId = null, Expression<Func<string>> warehouseRefNum = null, Expression<Func<bodyInputItem2222[]>> body = null)
        {
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: false);
            var __workflow_warehouseRefNum = WorkflowExpression.Compile(warehouseRefNum, nameof(warehouseRefNum), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/warehouse/inventory/adjustment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_companyId != null)
                    callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                if (__workflow_warehouseRefNum != null)
                    callPayload.Queries["warehouseRefNum"] = ExpressionConverter.Convert(__workflow_warehouseRefNum);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateLocations(Expression<Func<string>> companyId, Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<bodyInputItem22222[]>> body = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/location/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLocations(Expression<Func<string>> companyId, Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<bodyInputItem22222[]>> body = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/location/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateUsers(Expression<Func<string>> companyId, Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<bodyInputItem222222[]>> body = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/user/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fieldequip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUsers(Expression<Func<string>> companyId, Expression<Func<string>> xApiKey, Expression<Func<string>> xOrigin, Expression<Func<UpdateUsersInput>> body = null)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_xApiKey = WorkflowExpression.Compile(xApiKey, nameof(xApiKey), required: true);
            var __workflow_xOrigin = WorkflowExpression.Compile(xOrigin, nameof(xOrigin), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/user/update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["companyId"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Headers["x-api-key"] = ExpressionConverter.Convert(__workflow_xApiKey);
                callPayload.Headers["x-origin"] = ExpressionConverter.Convert(__workflow_xOrigin);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class FieldequipTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodyInputItem
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("businessUnitCode")]
        public string BusinessUnitCode { get; set; }

        [JsonProperty("extCustomerRefNum")]
        public string ExtCustomerRefNum { get; set; }

        [JsonProperty("billingAddress1")]
        public string BillingAddress1 { get; set; }

        [JsonProperty("billingAddress2")]
        public string BillingAddress2 { get; set; }

        [JsonProperty("billingCity")]
        public string BillingCity { get; set; }

        [JsonProperty("billingState")]
        public string BillingState { get; set; }

        [JsonProperty("billingZipCode")]
        public string BillingZipCode { get; set; }

        [JsonProperty("billingCountryCode")]
        public string BillingCountryCode { get; set; }

        [JsonProperty("customerPhone")]
        public string CustomerPhone { get; set; }

        [JsonProperty("customerStatus")]
        public string CustomerStatus { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }

        [JsonProperty("shipToName")]
        public string ShipToName { get; set; }

        [JsonProperty("shipToAddress1")]
        public string ShipToAddress1 { get; set; }

        [JsonProperty("shipToAddress2")]
        public string ShipToAddress2 { get; set; }

        [JsonProperty("shipToCity")]
        public string ShipToCity { get; set; }

        [JsonProperty("shipToState")]
        public string ShipToState { get; set; }

        [JsonProperty("shipToZipCode")]
        public string ShipToZipCode { get; set; }

        [JsonProperty("shipToCountryCode")]
        public string ShipToCountryCode { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("alarming")]
        public bool Alarming { get; set; }

        [JsonProperty("reportedTime")]
        public string ReportedTime { get; set; }

        [JsonProperty("sourceSys")]
        public string SourceSys { get; set; }

        [JsonProperty("sourceKey")]
        public string SourceKey { get; set; }

        [JsonProperty("sparse")]
        public bool Sparse { get; set; }
    }

    public class bodyInputItem22
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("itemDescription")]
        public string ItemDescription { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("costPrice")]
        public string CostPrice { get; set; }

        [JsonProperty("listPrice")]
        public string ListPrice { get; set; }

        [JsonProperty("uomCode")]
        public string UomCode { get; set; }

        [JsonProperty("itemStatus")]
        public string ItemStatus { get; set; }

        [JsonProperty("inventoryItem")]
        public bool InventoryItem { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("warrantyPeriod")]
        public string WarrantyPeriod { get; set; }

        [JsonProperty("supplier")]
        public string Supplier { get; set; }

        [JsonProperty("isSerialized")]
        public bool IsSerialized { get; set; }

        [JsonProperty("taxCode")]
        public string TaxCode { get; set; }
    }

    public class bodyInputItem222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("warehouseRefNum")]
        public string WarehouseRefNum { get; set; }

        [JsonProperty("warehouseName")]
        public string WarehouseName { get; set; }

        [JsonProperty("items")]
        public bodyInputItemItemsTypeItem[] Items { get; set; }
    }

    public class bodyInputItemItemsTypeItem
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("unitCostPrice")]
        public string UnitCostPrice { get; set; }

        [JsonProperty("unitListPrice")]
        public string UnitListPrice { get; set; }

        [JsonProperty("qtyOnHand")]
        public double QtyOnHand { get; set; }

        [JsonProperty("qtyAvailable")]
        public double QtyAvailable { get; set; }

        [JsonProperty("qtyThreshold")]
        public double QtyThreshold { get; set; }
    }

    public class bodyInputItem2222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("warehouseRefNum")]
        public string WarehouseRefNum { get; set; }

        [JsonProperty("warehouseName")]
        public string WarehouseName { get; set; }

        [JsonProperty("items")]
        public bodyInputItemItemsTypeItem2[] Items { get; set; }
    }

    public class bodyInputItemItemsTypeItem2
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("unitListPrice")]
        public string UnitListPrice { get; set; }

        [JsonProperty("unitCostPrice")]
        public string UnitCostPrice { get; set; }

        [JsonProperty("qty")]
        public double Qty { get; set; }

        [JsonProperty("purchaseOrder")]
        public string PurchaseOrder { get; set; }
        public string ReceiptDate { get; set; }
    }

    public class bodyInputItem22222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("locationId")]
        public string LocationId { get; set; }

        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("shipToAddress1")]
        public string ShipToAddress1 { get; set; }

        [JsonProperty("shipToAddress2")]
        public string ShipToAddress2 { get; set; }

        [JsonProperty("shipToCity")]
        public string ShipToCity { get; set; }

        [JsonProperty("shipToState")]
        public string ShipToState { get; set; }

        [JsonProperty("shipToZipCode")]
        public string ShipToZipCode { get; set; }

        [JsonProperty("shipToCountryCode")]
        public string ShipToCountryCode { get; set; }

        [JsonProperty("locationStatus")]
        public string LocationStatus { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("contactEmail")]
        public string ContactEmail { get; set; }

        [JsonProperty("contactPhone")]
        public string ContactPhone { get; set; }
    }

    public class bodyInputItem222222
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("businessUnitCode")]
        public string BusinessUnitCode { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("payrollCode")]
        public string PayrollCode { get; set; }

        [JsonProperty("plantId")]
        public string PlantId { get; set; }

        [JsonProperty("empId")]
        public string EmpId { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("reportingManager")]
        public string ReportingManager { get; set; }

        [JsonProperty("empType")]
        public string EmpType { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }

    public class UpdateUsersInput
    {
        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("businessUnitCode")]
        public string BusinessUnitCode { get; set; }

        [JsonProperty("departmentCode")]
        public string DepartmentCode { get; set; }

        [JsonProperty("payrollCode")]
        public string PayrollCode { get; set; }

        [JsonProperty("plantId")]
        public string PlantId { get; set; }

        [JsonProperty("empId")]
        public string EmpId { get; set; }

        [JsonProperty("mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty("reportingManager")]
        public string ReportingManager { get; set; }

        [JsonProperty("empType")]
        public string EmpType { get; set; }

        [JsonProperty("stateCode")]
        public string StateCode { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fieldequip;

    public partial class WorkflowManagedActions
    {
        public FieldequipActions Fieldequip(string connectionId) => new FieldequipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FieldequipTriggers Fieldequip(string connectionId) => new FieldequipTriggers(connectionId);
    }
}