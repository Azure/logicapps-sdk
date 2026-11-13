//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Withoutwireinventory
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WithoutwireinventoryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetWorkOrdersResponseItem[], ApiConnectionActionConfiguration> GetWorkOrders(Expression<Func<string>> orderNumber = null, Expression<Func<string>> beginDate = null, Expression<Func<string>> endDate = null, Expression<Func<OrderStatusCodeInput>> orderStatusCode = null, Expression<Func<string>> itemNumber = null, Expression<Func<string>> parentOrderNumber = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_orderNumber = WorkflowExpression.Compile(orderNumber, nameof(orderNumber), required: false);
            var __workflow_beginDate = WorkflowExpression.Compile(beginDate, nameof(beginDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_orderStatusCode = WorkflowExpression.Compile(orderStatusCode, nameof(orderStatusCode), required: false);
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_parentOrderNumber = WorkflowExpression.Compile(parentOrderNumber, nameof(parentOrderNumber), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetWorkOrdersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/workorder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderNumber != null)
                    callPayload.Queries["OrderNumber"] = ExpressionConverter.Convert(__workflow_orderNumber);
                if (__workflow_beginDate != null)
                    callPayload.Queries["beginDate"] = ExpressionConverter.Convert(__workflow_beginDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_orderStatusCode != null)
                    callPayload.Queries["OrderStatusCode"] = ExpressionConverter.Convert(__workflow_orderStatusCode);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["itemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_parentOrderNumber != null)
                    callPayload.Queries["parentOrderNumber"] = ExpressionConverter.Convert(__workflow_parentOrderNumber);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetWorkOrdersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateUpdateWorkOrderResponse, ApiConnectionActionConfiguration> CreateUpdateWorkOrder(Expression<Func<CreateUpdateWorkOrderBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateUpdateWorkOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/workorder";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateWorkOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<DeleteOrderResponse, ApiConnectionActionConfiguration> DeleteOrder(Expression<Func<DeleteOrderBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<DeleteOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/order";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<SetOrderCompleteResponse, ApiConnectionActionConfiguration> SetOrderComplete(Expression<Func<InboundCompleteBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<SetOrderCompleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/order/complete";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetOrderCompleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<SetOrderStatusResponse, ApiConnectionActionConfiguration> SetOrderStatus(Expression<Func<SetOrderStatusBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<SetOrderStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/order/status";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetOrderStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AssignOrder(Expression<Func<AssignOrderBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/order/assignment";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetInventoryResponseItem[], ApiConnectionActionConfiguration> GetInventory(Expression<Func<string>> itemNumber = null, Expression<Func<string>> binNumber = null, Expression<Func<string>> allocationSetName = null, Expression<Func<string>> warehouseName = null, Expression<Func<string>> coreValue = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_binNumber = WorkflowExpression.Compile(binNumber, nameof(binNumber), required: false);
            var __workflow_allocationSetName = WorkflowExpression.Compile(allocationSetName, nameof(allocationSetName), required: false);
            var __workflow_warehouseName = WorkflowExpression.Compile(warehouseName, nameof(warehouseName), required: false);
            var __workflow_coreValue = WorkflowExpression.Compile(coreValue, nameof(coreValue), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetInventoryResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/inventory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["ItemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_binNumber != null)
                    callPayload.Queries["BinNumber"] = ExpressionConverter.Convert(__workflow_binNumber);
                if (__workflow_allocationSetName != null)
                    callPayload.Queries["AllocationSetName"] = ExpressionConverter.Convert(__workflow_allocationSetName);
                if (__workflow_warehouseName != null)
                    callPayload.Queries["WarehouseName"] = ExpressionConverter.Convert(__workflow_warehouseName);
                if (__workflow_coreValue != null)
                    callPayload.Queries["CoreValue"] = ExpressionConverter.Convert(__workflow_coreValue);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetInventoryResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateInventoryRequestResponse, ApiConnectionActionConfiguration> CreateInventoryRequest(Expression<Func<CreateInventoryRequestBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateInventoryRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/inventory/request";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateInventoryRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateInventoryAdjustmentResponse, ApiConnectionActionConfiguration> CreateInventoryAdjustment(Expression<Func<CreateInventoryAdjustmentBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateInventoryAdjustmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/inventory/adjustment";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateInventoryAdjustmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<DeleteInboundRequestResponse, ApiConnectionActionConfiguration> DeleteInboundRequest(Expression<Func<DeleteInboundRequestBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<DeleteInboundRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteInboundRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateInboundRequestResponse, ApiConnectionActionConfiguration> CreateInboundRequest(Expression<Func<CreateInboundRequestBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateInboundRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateInboundRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateSite(Expression<Func<string>> userName, Expression<Func<string>> warehouse, Expression<Func<CreateSiteBodyInputItem[]>> body = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/warehouse";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateItemResponse, ApiConnectionActionConfiguration> CreateItem(Expression<Func<CreateItemBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/item";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetInboundRequestResponseItem[], ApiConnectionActionConfiguration> GetInboundRequest(Expression<Func<string>> beginDate = null, Expression<Func<string>> endDate = null, Expression<Func<PoStatusInput>> poStatus = null, Expression<Func<LineReceiptStatusInput>> lineReceiptStatus = null, Expression<Func<string>> itemNumber = null, Expression<Func<string>> poNumber = null, Expression<Func<string>> poType = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_beginDate = WorkflowExpression.Compile(beginDate, nameof(beginDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_poStatus = WorkflowExpression.Compile(poStatus, nameof(poStatus), required: false);
            var __workflow_lineReceiptStatus = WorkflowExpression.Compile(lineReceiptStatus, nameof(lineReceiptStatus), required: false);
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_poNumber = WorkflowExpression.Compile(poNumber, nameof(poNumber), required: false);
            var __workflow_poType = WorkflowExpression.Compile(poType, nameof(poType), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetInboundRequestResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder/filter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_beginDate != null)
                    callPayload.Queries["BeginDate"] = ExpressionConverter.Convert(__workflow_beginDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_poStatus != null)
                    callPayload.Queries["POStatus"] = ExpressionConverter.Convert(__workflow_poStatus);
                if (__workflow_lineReceiptStatus != null)
                    callPayload.Queries["LineReceiptStatus"] = ExpressionConverter.Convert(__workflow_lineReceiptStatus);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["ItemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_poNumber != null)
                    callPayload.Queries["PONumber"] = ExpressionConverter.Convert(__workflow_poNumber);
                if (__workflow_poType != null)
                    callPayload.Queries["POType"] = ExpressionConverter.Convert(__workflow_poType);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetInboundRequestResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<InboundCompleteResponse, ApiConnectionActionConfiguration> InboundComplete(Expression<Func<InboundCompleteBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<InboundCompleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder/complete";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InboundCompleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateLocationResponse, ApiConnectionActionConfiguration> CreateLocation(Expression<Func<CreateLocationBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/bins";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<ReceiptCompleteResponse, ApiConnectionActionConfiguration> ReceiptComplete(Expression<Func<ReceiptCompleteBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<ReceiptCompleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder/receipt/complete";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReceiptCompleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetSalesOrdersResponseItem[], ApiConnectionActionConfiguration> GetSalesOrders(Expression<Func<string>> orderNumber = null, Expression<Func<string>> beginDate = null, Expression<Func<string>> endDate = null, Expression<Func<OrderStatusCodeInput>> orderStatusCode = null, Expression<Func<string>> itemNumber = null, Expression<Func<string>> parentOrderNumber = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_orderNumber = WorkflowExpression.Compile(orderNumber, nameof(orderNumber), required: false);
            var __workflow_beginDate = WorkflowExpression.Compile(beginDate, nameof(beginDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_orderStatusCode = WorkflowExpression.Compile(orderStatusCode, nameof(orderStatusCode), required: false);
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_parentOrderNumber = WorkflowExpression.Compile(parentOrderNumber, nameof(parentOrderNumber), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetSalesOrdersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/salesorder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderNumber != null)
                    callPayload.Queries["OrderNumber"] = ExpressionConverter.Convert(__workflow_orderNumber);
                if (__workflow_beginDate != null)
                    callPayload.Queries["beginDate"] = ExpressionConverter.Convert(__workflow_beginDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_orderStatusCode != null)
                    callPayload.Queries["OrderStatusCode"] = ExpressionConverter.Convert(__workflow_orderStatusCode);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["itemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_parentOrderNumber != null)
                    callPayload.Queries["parentOrderNumber"] = ExpressionConverter.Convert(__workflow_parentOrderNumber);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetSalesOrdersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateUpdateSalesOrderResponse, ApiConnectionActionConfiguration> CreateUpdateSalesOrder(Expression<Func<CreateUpdateSalesOrderBodyInputItem[]>> body = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<CreateUpdateSalesOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/salesorder";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateSalesOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConsumeInventory(Expression<Func<string>> userName, Expression<Func<string>> warehouse, Expression<Func<ConsumeInventoryBodyInputItem[]>> body = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/workorder/consumption";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetBarcodeInfoResponse, ApiConnectionActionConfiguration> GetBarcodeInfo(Expression<Func<string>> barcode, Expression<Func<string>> userName, Expression<Func<string>> warehouse)
        {
            var __workflow_barcode = WorkflowExpression.Compile(barcode, nameof(barcode), required: true);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: true);
            return new DeferredBodyAction<GetBarcodeInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/barcode";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Barcode"] = ExpressionConverter.Convert(__workflow_barcode);
                callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetBarcodeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<SingleScanInventoryLookupResponseItem[], ApiConnectionActionConfiguration> SingleScanInventoryLookup(Expression<Func<string>> barcode, Expression<Func<string>> userName, Expression<Func<string>> warehouse)
        {
            var __workflow_barcode = WorkflowExpression.Compile(barcode, nameof(barcode), required: true);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: true);
            return new DeferredBodyAction<SingleScanInventoryLookupResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/po/container";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Barcode"] = ExpressionConverter.Convert(__workflow_barcode);
                callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<SingleScanInventoryLookupResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetTransferOrdersResponseItem[], ApiConnectionActionConfiguration> GetTransferOrders(Expression<Func<string>> orderNumber = null, Expression<Func<string>> beginDate = null, Expression<Func<string>> endDate = null, Expression<Func<OrderStatusCodeInput>> orderStatusCode = null, Expression<Func<string>> itemNumber = null, Expression<Func<string>> parentOrderNumber = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_orderNumber = WorkflowExpression.Compile(orderNumber, nameof(orderNumber), required: false);
            var __workflow_beginDate = WorkflowExpression.Compile(beginDate, nameof(beginDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_orderStatusCode = WorkflowExpression.Compile(orderStatusCode, nameof(orderStatusCode), required: false);
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_parentOrderNumber = WorkflowExpression.Compile(parentOrderNumber, nameof(parentOrderNumber), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetTransferOrdersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/transferorder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderNumber != null)
                    callPayload.Queries["OrderNumber"] = ExpressionConverter.Convert(__workflow_orderNumber);
                if (__workflow_beginDate != null)
                    callPayload.Queries["beginDate"] = ExpressionConverter.Convert(__workflow_beginDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_orderStatusCode != null)
                    callPayload.Queries["OrderStatusCode"] = ExpressionConverter.Convert(__workflow_orderStatusCode);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["itemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_parentOrderNumber != null)
                    callPayload.Queries["parentOrderNumber"] = ExpressionConverter.Convert(__workflow_parentOrderNumber);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetTransferOrdersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateUpdateTransferOrderResponse, ApiConnectionActionConfiguration> CreateUpdateTransferOrder(Expression<Func<string>> userName, Expression<Func<string>> warehouse, Expression<Func<CreateUpdateTransferOrderBodyInputItem[]>> body = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateUpdateTransferOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/transferorder";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateTransferOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetPurchaseOrderResponseItem[], ApiConnectionActionConfiguration> GetPurchaseOrder(Expression<Func<string>> beginDate = null, Expression<Func<string>> endDate = null, Expression<Func<PoStatusInput>> poStatus = null, Expression<Func<LineReceiptStatusInput>> lineReceiptStatus = null, Expression<Func<string>> itemNumber = null, Expression<Func<string>> poNumber = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_beginDate = WorkflowExpression.Compile(beginDate, nameof(beginDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_poStatus = WorkflowExpression.Compile(poStatus, nameof(poStatus), required: false);
            var __workflow_lineReceiptStatus = WorkflowExpression.Compile(lineReceiptStatus, nameof(lineReceiptStatus), required: false);
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_poNumber = WorkflowExpression.Compile(poNumber, nameof(poNumber), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetPurchaseOrderResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder/po";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_beginDate != null)
                    callPayload.Queries["BeginDate"] = ExpressionConverter.Convert(__workflow_beginDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_poStatus != null)
                    callPayload.Queries["POStatus"] = ExpressionConverter.Convert(__workflow_poStatus);
                if (__workflow_lineReceiptStatus != null)
                    callPayload.Queries["LineReceiptStatus"] = ExpressionConverter.Convert(__workflow_lineReceiptStatus);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["ItemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_poNumber != null)
                    callPayload.Queries["PONumber"] = ExpressionConverter.Convert(__workflow_poNumber);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetPurchaseOrderResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreatePurchaseOrderResponse, ApiConnectionActionConfiguration> CreatePurchaseOrder(Expression<Func<string>> userName, Expression<Func<string>> warehouse, Expression<Func<CreatePurchaseOrderBodyInputItem[]>> body = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: true);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreatePurchaseOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/purchaseorder/po";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatePurchaseOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetManufacturingOrderResponseItem[], ApiConnectionActionConfiguration> GetManufacturingOrder(Expression<Func<string>> orderNumber = null, Expression<Func<string>> beginDate = null, Expression<Func<string>> endDate = null, Expression<Func<OrderStatusCodeInput>> orderStatusCode = null, Expression<Func<string>> itemNumber = null, Expression<Func<string>> parentOrderNumber = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_orderNumber = WorkflowExpression.Compile(orderNumber, nameof(orderNumber), required: false);
            var __workflow_beginDate = WorkflowExpression.Compile(beginDate, nameof(beginDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_orderStatusCode = WorkflowExpression.Compile(orderStatusCode, nameof(orderStatusCode), required: false);
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_parentOrderNumber = WorkflowExpression.Compile(parentOrderNumber, nameof(parentOrderNumber), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetManufacturingOrderResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/manufacturingorder";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderNumber != null)
                    callPayload.Queries["OrderNumber"] = ExpressionConverter.Convert(__workflow_orderNumber);
                if (__workflow_beginDate != null)
                    callPayload.Queries["BeginDate"] = ExpressionConverter.Convert(__workflow_beginDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["EndDate"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_orderStatusCode != null)
                    callPayload.Queries["OrderStatusCode"] = ExpressionConverter.Convert(__workflow_orderStatusCode);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["ItemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_parentOrderNumber != null)
                    callPayload.Queries["ParentOrderNumber"] = ExpressionConverter.Convert(__workflow_parentOrderNumber);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetManufacturingOrderResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<CreateUpdateManufacturingOrderResponse, ApiConnectionActionConfiguration> CreateUpdateManufacturingOrder(Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null, Expression<Func<CreateUpdateManufacturingOrderBodyInputItem[]>> body = null)
        {
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateUpdateManufacturingOrderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/manufacturingorder";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUpdateManufacturingOrderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "withoutwireinventory")]
        public IBodyWorkflowAction<GetInventoryAggregateResponseItem[], ApiConnectionActionConfiguration> GetInventoryAggregate(Expression<Func<string>> itemNumber = null, Expression<Func<string>> warehouseName = null, Expression<Func<string>> allocationSetName = null, Expression<Func<string>> userName = null, Expression<Func<string>> warehouse = null)
        {
            var __workflow_itemNumber = WorkflowExpression.Compile(itemNumber, nameof(itemNumber), required: false);
            var __workflow_warehouseName = WorkflowExpression.Compile(warehouseName, nameof(warehouseName), required: false);
            var __workflow_allocationSetName = WorkflowExpression.Compile(allocationSetName, nameof(allocationSetName), required: false);
            var __workflow_userName = WorkflowExpression.Compile(userName, nameof(userName), required: false);
            var __workflow_warehouse = WorkflowExpression.Compile(warehouse, nameof(warehouse), required: false);
            return new DeferredBodyAction<GetInventoryAggregateResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/inventory/quantity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_itemNumber != null)
                    callPayload.Queries["ItemNumber"] = ExpressionConverter.Convert(__workflow_itemNumber);
                if (__workflow_warehouseName != null)
                    callPayload.Queries["WarehouseName"] = ExpressionConverter.Convert(__workflow_warehouseName);
                if (__workflow_allocationSetName != null)
                    callPayload.Queries["AllocationSetName"] = ExpressionConverter.Convert(__workflow_allocationSetName);
                if (__workflow_userName != null)
                    callPayload.Headers["UserName"] = ExpressionConverter.Convert(__workflow_userName);
                if (__workflow_warehouse != null)
                    callPayload.Headers["Warehouse"] = ExpressionConverter.Convert(__workflow_warehouse);
                return new ApiConnectionAction<GetInventoryAggregateResponseItem[]>(callPayload);
            });
        }
    }

    public class WithoutwireinventoryTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetWorkOrdersResponseItem
    {
        public string WarehouseName { get; set; }
        public string CustomerPONumber { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public int OrderType { get; set; }
        public GetWorkOrdersResponseItemCustomerType Customer { get; set; }
        public string RouteDescription { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderComment { get; set; }
        public string DestinationWarehouseName { get; set; }
        public string RouteNumber { get; set; }
        public string ShipDate { get; set; }
        public string DateCreated { get; set; }
        public GetWorkOrdersResponseItemLineItemsTypeItem[] LineItems { get; set; }
        public string LoadDate { get; set; }
        public string PrintDate { get; set; }
        public string ExportDate { get; set; }
        public string ParentOrderNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string ShippingMethodName { get; set; }
        public double ShippingWeight { get; set; }
        public double ShippingCost { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public int Identity { get; set; }
        public int PickingPriority { get; set; }
        public int RoutePickingPriority { get; set; }
    }

    public class GetWorkOrdersResponseItemCustomerType
    {
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerShortDesc { get; set; }
        public string CustomerNumber { get; set; }
        public string UpcManufacturerNumber { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerShipTo { get; set; }
        public int RequiredShelfLife { get; set; }
        public GetWorkOrdersResponseItemCustomerTypeCustomerShippingAddressesTypeItem[] CustomerShippingAddresses { get; set; }
    }

    public class GetWorkOrdersResponseItemCustomerTypeCustomerShippingAddressesTypeItem
    {
        public string CustomerShipName { get; set; }
        public string CustomerShipAddress1 { get; set; }
        public string CustomerShipAddress2 { get; set; }
        public string CustomerShipCity { get; set; }
        public string CustomerShipState { get; set; }
        public string CustomerShipZipCode { get; set; }
        public string CustomerShipZip5 { get; set; }
        public string CustomerShipPhone { get; set; }
        public string CustomerShipFax { get; set; }
        public string CustomerShipCountry { get; set; }
        public string CustomerShipTo { get; set; }
    }

    public class GetWorkOrdersResponseItemLineItemsTypeItem
    {
        public int LineNumber { get; set; }
        public int ComponentSequence { get; set; }
        public string ItemNumber { get; set; }
        public GetWorkOrdersResponseItemLineItemsTypeItemCoreItemTypeType CoreItemType { get; set; }
        public double QuantityOrdered { get; set; }
        public GetWorkOrdersResponseItemLineItemsTypeItemUomTypeType UomType { get; set; }
        public string LineItemComment { get; set; }
        public string ItemDescription { get; set; }
        public GetWorkOrdersResponseItemLineItemsTypeItemPickRecordsTypeItem[] PickRecords { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetWorkOrdersResponseItemLineItemsTypeItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class GetWorkOrdersResponseItemLineItemsTypeItemUomTypeType
    {
        public string UomDesc { get; set; }
        public int SignificantDigits { get; set; }
        public double BaseConversionFactor { get; set; }
    }

    public class GetWorkOrdersResponseItemLineItemsTypeItemPickRecordsTypeItem
    {
        public double QuantityShipped { get; set; }
        public double QuantityPicked { get; set; }
        public string CoreValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderStatusCodeInput
    {
        [EnumMember(Value = "UNA")]
        Una,
        [EnumMember(Value = "WTP")]
        Wtp,
        [EnumMember(Value = "PIP")]
        Pip,
        [EnumMember(Value = "WFE")]
        Wfe,
        [EnumMember(Value = "EXP")]
        Exp,
        [EnumMember(Value = "CMP")]
        Cmp,
        [EnumMember(Value = "REV")]
        Rev,
        [EnumMember(Value = "PRC")]
        Prc,
        [EnumMember(Value = "NEW")]
        New,
        [EnumMember(Value = "WFS")]
        Wfs
    }

    public class CreateUpdateWorkOrderResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public CreateUpdateWorkOrderResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class CreateUpdateWorkOrderResponseInvalidObjectsTypeItem
    {
        public CreateUpdateWorkOrderResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public string Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class CreateUpdateWorkOrderResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public CreateUpdateWorkOrderResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class CreateUpdateWorkOrderResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class CreateUpdateWorkOrderBodyInputItem
    {
        public CreateUpdateWorkOrderBodyInputItem(string warehouseName, string orderNumber, string customerPONumber, string vendorShipmentNumber, string deliveryDate, CreateUpdateWorkOrderBodyInputItemCustomerType customer)
        {
            this.WarehouseName = warehouseName;
            this.OrderNumber = orderNumber;
            this.CustomerPONumber = customerPONumber;
            this.VendorShipmentNumber = vendorShipmentNumber;
            this.DeliveryDate = deliveryDate;
            this.Customer = customer;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string WarehouseName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrderNumber { get; set; }
        public string OrderComment { get; set; }
        public string AllocationSetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerPONumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string VendorShipmentNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RouteNumber { get; set; } = "9999";
        public string RouteDescription { get; set; }
        public string DestinationWarehouseName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeliveryDate { get; set; }
        public string ShipDate { get; set; }
        public string DateCreated { get; set; }
        public string LoadDate { get; set; }
        public string PrintDate { get; set; }
        public string ShippingMethodName { get; set; }
        public string TrackingNumber { get; set; }
        public double? ShippingWeight { get; set; }
        public double? ShippingCost { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUpdateWorkOrderBodyInputItemCustomerType Customer { get; set; }
        public CreateUpdateWorkOrderBodyInputItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class CreateUpdateWorkOrderBodyInputItemCustomerType
    {
        public CreateUpdateWorkOrderBodyInputItemCustomerType(string customerNumber)
        {
            this.CustomerNumber = customerNumber;
        }

        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerShortDesc { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerNumber { get; set; }
        public string CustomerPhone { get; set; }
        public CreateUpdateWorkOrderBodyInputItemCustomerTypeCustomerShippingAddressesTypeItem[] CustomerShippingAddresses { get; set; }
    }

    public class CreateUpdateWorkOrderBodyInputItemCustomerTypeCustomerShippingAddressesTypeItem
    {
        public string CustomerShipName { get; set; }
        public string CustomerShipAttn { get; set; }
        public string CustomerShipAddress1 { get; set; }
        public string CustomerShipAddress2 { get; set; }
        public string CustomerShipCity { get; set; }
        public string CustomerShipState { get; set; }
        public string CustomerShipZipCode { get; set; }
        public string CustomerShipZip5 { get; set; }
        public string CustomerShipPhone { get; set; }
        public string CustomerShipFax { get; set; }
        public string CustomerShipCountry { get; set; }
        public string CustomerShipTo { get; set; }
    }

    public class CreateUpdateWorkOrderBodyInputItemLineItemsTypeItem
    {
        public CreateUpdateWorkOrderBodyInputItemLineItemsTypeItem(int lineNumber, string itemNumber, BodyInputItemLineItemsTypeItemCoreItemTypeType coreItemType, double quantityOrdered)
        {
            this.LineNumber = lineNumber;
            this.ItemNumber = itemNumber;
            this.CoreItemType = coreItemType;
            this.QuantityOrdered = quantityOrdered;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int LineNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputItemLineItemsTypeItemCoreItemTypeType CoreItemType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double QuantityOrdered { get; set; }
        public string AllocationSetName { get; set; }
        public string LineItemComment { get; set; }
        public string ItemDescription { get; set; }
        public CreateUpdateWorkOrderBodyInputItemLineItemsTypeItemUomTypeType UomType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemLineItemsTypeItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class CreateUpdateWorkOrderBodyInputItemLineItemsTypeItemUomTypeType
    {
        public CreateUpdateWorkOrderBodyInputItemLineItemsTypeItemUomTypeType(string uomDesc)
        {
            this.UomDesc = uomDesc;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UomDesc { get; set; }
        public int? SignificantDigits { get; set; }
        public double? BaseConversionFactor { get; set; }
    }

    public class DeleteOrderResponse
    {
        public int TotalCount { get; set; }
        public int DeletedCount { get; set; }
    }

    public class DeleteOrderBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string OrderNumber { get; set; }
    }

    public class SetOrderCompleteResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public SetOrderCompleteResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class SetOrderCompleteResponseInvalidObjectsTypeItem
    {
        public SetOrderCompleteResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public string Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class SetOrderCompleteResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public SetOrderCompleteResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class SetOrderCompleteResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class InboundCompleteBodyInputItem
    {
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class SetOrderStatusResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public SetOrderStatusResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class SetOrderStatusResponseInvalidObjectsTypeItem
    {
        public SetOrderStatusResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public string Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class SetOrderStatusResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public SetOrderStatusResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class SetOrderStatusResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class SetOrderStatusBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string OrderNumber { get; set; }
        public BodyInputItemOrderStatusCodeType? OrderStatusCode { get; set; }
        public string OrderStatusDescription { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemOrderStatusCodeType
    {
        [EnumMember(Value = "UNA")]
        Una,
        [EnumMember(Value = "WTP")]
        Wtp,
        [EnumMember(Value = "PIP")]
        Pip,
        [EnumMember(Value = "WFE")]
        Wfe,
        [EnumMember(Value = "EXP")]
        Exp,
        [EnumMember(Value = "CMP")]
        Cmp,
        [EnumMember(Value = "REV")]
        Rev,
        [EnumMember(Value = "PRC")]
        Prc,
        [EnumMember(Value = "NEW")]
        New,
        [EnumMember(Value = "WFS")]
        Wfs
    }

    public class AssignOrderBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string OrderNumber { get; set; }
        public string[] Assignments { get; set; }
    }

    public class GetInventoryResponseItem
    {
        public string WarehouseName { get; set; }
        public string BinNumber { get; set; }
        public string BinPath { get; set; }
        public string LicensePlateNumber { get; set; }
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public string ItemUom { get; set; }
        public int SignificantDigits { get; set; }
        public double BaseConvFactor { get; set; }
        public double BinSequence { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public bool Active { get; set; }
        public GetInventoryResponseItemCoreItemTypeType CoreItemType { get; set; }
        public string CoreValue { get; set; }
        public double Quantity { get; set; }
        public string AllocationSetName { get; set; }
        public string Distance { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetInventoryResponseItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class CreateInventoryRequestResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public CreateInventoryRequestResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class CreateInventoryRequestResponseInvalidObjectsTypeItem
    {
        public CreateInventoryRequestResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public string Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class CreateInventoryRequestResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public CreateInventoryRequestResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class CreateInventoryRequestResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class CreateInventoryRequestBodyInputItem
    {
        public CreateInventoryRequestBodyInputItem(string itemNumber, string destinationWarehouseName)
        {
            this.ItemNumber = itemNumber;
            this.DestinationWarehouseName = destinationWarehouseName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RequestGroup { get; set; } = "Tech Request";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputItemSourceProcessType? SourceProcess { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Withoutwireinventory.BodyInputItemSourceProcessType.RequestInventory;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemNumber { get; set; }
        public double? Quantity { get; set; }
        public string UomDesc { get; set; }
        public string CoreValue { get; set; }
        public string AllocationSetName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationWarehouseName { get; set; }
        public string DestinationBinNumber { get; set; }
        public string DestinationZone { get; set; }
        public string RequestExpiration { get; set; }
        public string CreatedByUser { get; set; }
        public string SourceWarehouseName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemSourceProcessType
    {
        [EnumMember(Value = "Request Inventory")]
        RequestInventory,
        Replenishment
    }

    public class CreateInventoryAdjustmentResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public CreateInventoryAdjustmentResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class CreateInventoryAdjustmentResponseInvalidObjectsTypeItem
    {
        public CreateInventoryAdjustmentResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public string Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class CreateInventoryAdjustmentResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public CreateInventoryAdjustmentResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class CreateInventoryAdjustmentResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class CreateInventoryAdjustmentBodyInputItem
    {
        public CreateInventoryAdjustmentBodyInputItem(string binNumber, string itemNumber, string warehouse)
        {
            this.BinNumber = binNumber;
            this.ItemNumber = itemNumber;
            this.Warehouse = warehouse;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string BinNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemNumber { get; set; }
        public BodyInputItemCoreValueType? CoreValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Warehouse { get; set; }
        public string UomDesc { get; set; }
        public double? Qty { get; set; }
        public BodyInputItemMovementTypeType? MovementType { get; set; }
        public string Note { get; set; }
        public string OrderNumber { get; set; }
        public string UnitNumber { get; set; }
        public bool? InternalOnly { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemCoreValueType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "DATE")]
        Date
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemMovementTypeType
    {
        [EnumMember(Value = "Adjustment In+")]
        AdjustmentIn,
        [EnumMember(Value = "Auto Adjustment Out")]
        AutoAdjustmentOut,
        Damaged,
        Obsolescence,
        [EnumMember(Value = "Physical Inventory")]
        PhysicalInventory,
        Variance
    }

    public class DeleteInboundRequestResponse
    {
        public int TotalCount { get; set; }
        public int DeletedCount { get; set; }
    }

    public class DeleteInboundRequestBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string PurchaseOrderNumber { get; set; }
    }

    public class CreateInboundRequestResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public CreateInboundRequestResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class CreateInboundRequestResponseInvalidObjectsTypeItem
    {
        public CreateInboundRequestResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public int Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class CreateInboundRequestResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public CreateInboundRequestResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class CreateInboundRequestResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class CreateInboundRequestBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string SchedDeliveryDate { get; set; }
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public string AllocationSetName { get; set; }
        public BodyInputItemPurchaseOrderTypeType? PurchaseOrderType { get; set; }
        public string[] PurchaseOrderComments { get; set; }
        public CreateInboundRequestBodyInputItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public enum BodyInputItemPurchaseOrderTypeType
    {
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class CreateInboundRequestBodyInputItemLineItemsTypeItem
    {
        public int? LineNumber { get; set; }
        public string ItemNumber { get; set; }
        public BodyInputItemLineItemsTypeItemCoreItemTypeType? CoreItemType { get; set; }
        public double? QuantityOrdered { get; set; }
        public string UomDesc { get; set; }
        public double? BaseConversionFactor { get; set; }
        public int? SignificantDigits { get; set; }
        public string AllocationSetName { get; set; }
        public string[] LineItemComments { get; set; }
    }

    public class CreateSiteBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string Address1 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
    }

    public class CreateItemResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public CreateItemResponseInvalidObjectsTypeItem[] InvalidObjects { get; set; }
    }

    public class CreateItemResponseInvalidObjectsTypeItem
    {
        public CreateItemResponseInvalidObjectsTypeItemValidatorType Validator { get; set; }
        public string Identity { get; set; }
        public string IdentityCode { get; set; }
        public string WarehouseName { get; set; }
    }

    public class CreateItemResponseInvalidObjectsTypeItemValidatorType
    {
        public bool IsValid { get; set; }
        public CreateItemResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem[] ImportExceptions { get; set; }
    }

    public class CreateItemResponseInvalidObjectsTypeItemValidatorTypeImportExceptionsTypeItem
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string FieldName { get; set; }
    }

    public class CreateItemBodyInputItem
    {
        public CreateItemBodyInputItem(string itemNumber, BodyInputItemCoreItemTypeType coreItemType, string baseUom)
        {
            this.ItemNumber = itemNumber;
            this.CoreItemType = coreItemType;
            this.BaseUom = baseUom;
        }

        public string WarehouseName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public string ItemGenericDescription { get; set; }
        public BodyInputItemItemTypeType? ItemType { get; set; }
        public string ManufacturerNumber { get; set; }

        [JsonProperty("UPCBarcodeNumber")]
        public string UpcBarcodeNumber { get; set; }
        public double? GrossWeight { get; set; }
        public int? FullPalletQuantity { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? NetWeight { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputItemCoreItemTypeType CoreItemType { get; set; }
        public int? CycleCountInterval { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string BaseUom { get; set; }
        public int? SignificantDigits { get; set; }
        public string ZoneDesc { get; set; }
        public double? BaseConvFactor { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemItemTypeType
    {
        Inventory,
        Kit,
        Service,
        Pallet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class GetInboundRequestResponseItem
    {
        public string WarehouseName { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string SchedDeliveryDate { get; set; }
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public int ReceivingPercentOver { get; set; }
        public int PurchaseOrderType { get; set; }
        public JToken[] PurchaseOrderComments { get; set; }
        public string CompletedDate { get; set; }
        public string ExportedDate { get; set; }
        public string DateCreated { get; set; }
        public bool AssignmentManuallyModified { get; set; }
        public bool WebReceipt { get; set; }
        public string FromWarehouse { get; set; }
        public int Identity { get; set; }
        public string Status { get; set; }
        public string AllocationSetName { get; set; }
        public GetInboundRequestResponseItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class GetInboundRequestResponseItemLineItemsTypeItem
    {
        public int LineNumber { get; set; }
        public string ItemNumber { get; set; }
        public GetInboundRequestResponseItemLineItemsTypeItemCoreItemTypeType CoreItemType { get; set; }
        public double QuantityOrdered { get; set; }
        public string UomDesc { get; set; }
        public double BaseConversionFactor { get; set; }
        public int SignificantDigits { get; set; }
        public JToken[] LineItemComments { get; set; }
        public GetInboundRequestResponseItemLineItemsTypeItemReceiptsTypeItem[] Receipts { get; set; }
        public string AllocationSetName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetInboundRequestResponseItemLineItemsTypeItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class GetInboundRequestResponseItemLineItemsTypeItemReceiptsTypeItem
    {
        public double QuantityReceived { get; set; }
        public double QuantityMissing { get; set; }
        public double QuantityDamaged { get; set; }
        public string CoreValue { get; set; }
        public string DateReceived { get; set; }
        public int Identity { get; set; }
        public string Status { get; set; }
        public int LineNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PoStatusInput
    {
        Unassigned,
        WaitingForReceipt,
        ReceivingInProcess,
        ReceivingComplete,
        Completed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LineReceiptStatusInput
    {
        Unassigned,
        WaitingForReceipt,
        ReceivingInProcess,
        ReceivingComplete,
        Completed
    }

    public class InboundCompleteResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class CreateLocationResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class CreateLocationBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string BinNumber { get; set; }
        public BodyInputItemBinTypeType? BinType { get; set; }
        public string ParentBin { get; set; }
        public int? PickSequence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputItemBinTypeType
    {
        Inventory,
        Damage,
        Manufacturing,
        Receiving,
        QA,
        LicensePlate,
        Overstock,
        WorkInProgress,
        Staging,
        Hold,
        Exception
    }

    public class ReceiptCompleteResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class ReceiptCompleteBodyInputItem
    {
        public int? Identity { get; set; }
    }

    public class GetSalesOrdersResponseItem
    {
        public string WarehouseName { get; set; }
        public string CustomerPONumber { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public int OrderType { get; set; }
        public GetSalesOrdersResponseItemCustomerType Customer { get; set; }
        public string RouteDescription { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderComment { get; set; }
        public string DestinationWarehouseName { get; set; }
        public string RouteNumber { get; set; }
        public string ShipDate { get; set; }
        public string DateCreated { get; set; }
        public GetSalesOrdersResponseItemLineItemsTypeItem[] LineItems { get; set; }
        public string LoadDate { get; set; }
        public string PrintDate { get; set; }
        public string ExportDate { get; set; }
        public string ParentOrderNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string ShippingMethodName { get; set; }
        public double ShippingWeight { get; set; }
        public double ShippingCost { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public int Identity { get; set; }
        public string UseOrderLevelShipping { get; set; }
        public string AllocationSetName { get; set; }
        public int PickingPriority { get; set; }
        public int RoutePickingPriority { get; set; }
    }

    public class GetSalesOrdersResponseItemCustomerType
    {
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerShortDesc { get; set; }
        public string CustomerNumber { get; set; }
        public string UpcManufacturerNumber { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerShipTo { get; set; }
        public string NotificationEmail { get; set; }
        public int RequiredShelfLife { get; set; }
        public GetSalesOrdersResponseItemCustomerTypeCustomerShippingAddressesTypeItem[] CustomerShippingAddresses { get; set; }
    }

    public class GetSalesOrdersResponseItemCustomerTypeCustomerShippingAddressesTypeItem
    {
        public string CustomerShipName { get; set; }
        public string CustomerShipAttn { get; set; }
        public string CustomerShipAddress1 { get; set; }
        public string CustomerShipAddress2 { get; set; }
        public string CustomerShipCity { get; set; }
        public string CustomerShipState { get; set; }
        public string CustomerShipZipCode { get; set; }
        public string CustomerShipZip5 { get; set; }
        public string CustomerShipPhone { get; set; }
        public string CustomerShipFax { get; set; }
        public string CustomerShipCountry { get; set; }
        public string CustomerShipTo { get; set; }
    }

    public class GetSalesOrdersResponseItemLineItemsTypeItem
    {
        public int LineNumber { get; set; }
        public int ComponentSequence { get; set; }
        public string ItemNumber { get; set; }
        public GetSalesOrdersResponseItemLineItemsTypeItemCoreItemTypeType CoreItemType { get; set; }
        public double QuantityOrdered { get; set; }
        public GetSalesOrdersResponseItemLineItemsTypeItemUomTypeType UomType { get; set; }
        public string LineItemComment { get; set; }
        public string ItemDescription { get; set; }
        public string WarehouseName { get; set; }
        public GetSalesOrdersResponseItemLineItemsTypeItemPickRecordsTypeItem[] PickRecords { get; set; }
        public string AllocationSetName { get; set; }

        [JsonProperty("InventoryRequestTaskID")]
        public string InventoryRequestTaskId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetSalesOrdersResponseItemLineItemsTypeItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class GetSalesOrdersResponseItemLineItemsTypeItemUomTypeType
    {
        public string UomDesc { get; set; }
        public int SignificantDigits { get; set; }
        public double BaseConversionFactor { get; set; }
    }

    public class GetSalesOrdersResponseItemLineItemsTypeItemPickRecordsTypeItem
    {
        public double QuantityShipped { get; set; }
        public double QuantityPicked { get; set; }
        public string CoreValue { get; set; }
    }

    public class CreateUpdateSalesOrderResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class CreateUpdateSalesOrderBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string OrderNumber { get; set; }
        public string OrderComment { get; set; }
        public string AllocationSetName { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string DeliveryDate { get; set; }
        public string DestinationWarehouseName { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemCustomerType Customer { get; set; }
        public CreateUpdateSalesOrderBodyInputItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class CreateUpdateManufacturingOrderBodyInputItemCustomerType
    {
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemCustomerTypeCustomerShippingAddressesTypeItem[] CustomerShippingAddresses { get; set; }
    }

    public class CreateUpdateManufacturingOrderBodyInputItemCustomerTypeCustomerShippingAddressesTypeItem
    {
        public string CustomerShipName { get; set; }
        public string CustomerShipTo { get; set; }
    }

    public class CreateUpdateSalesOrderBodyInputItemLineItemsTypeItem
    {
        public int? LineNumber { get; set; }
        public string ItemNumber { get; set; }
        public BodyInputItemLineItemsTypeItemCoreItemTypeType? CoreItemType { get; set; }
        public double? QuantityOrdered { get; set; }
        public string WarehouseName { get; set; }
        public string AllocationSetName { get; set; }
        public string LineItemComment { get; set; }
        public CreateUpdateSalesOrderBodyInputItemLineItemsTypeItemUomTypeType UomType { get; set; }
    }

    public class CreateUpdateSalesOrderBodyInputItemLineItemsTypeItemUomTypeType
    {
        public string UomDesc { get; set; }
    }

    public class ConsumeInventoryBodyInputItem
    {
        public string AllocationSetName { get; set; }
        public string BinPath { get; set; }
        public BodyInputItemCoreValueType? CoreValue { get; set; }
        public string ItemNumber { get; set; }
        public string ItemUom { get; set; }
        public int? LineNumber { get; set; }
        public string OrderNumber { get; set; }
        public double? Quantity { get; set; }
        public string WarehouseName { get; set; }
    }

    public class GetBarcodeInfoResponse
    {
        public int ItemIdentificationCount { get; set; }
        public int LotOnlyCount { get; set; }
        public int ItemOnlyCount { get; set; }
        public int LPCount { get; set; }
        public int BinOnlyCount { get; set; }

        [JsonProperty("UOMBarcodeCount")]
        public int UomBarcodeCount { get; set; }
        public int PoCount { get; set; }
        public int OrderCount { get; set; }
        public int GtinCount { get; set; }
        public bool BinMultiSite { get; set; }
        public int AllocationSetCount { get; set; }
        public int PrinterCount { get; set; }
    }

    public class SingleScanInventoryLookupResponseItem
    {
        [JsonProperty("POID")]
        public int Poid { get; set; }
        public string PONumber { get; set; }
        public SingleScanInventoryLookupResponseItemPODetailsTypeItem[] PODetails { get; set; }
        public int TotalLpReceived { get; set; }
        public int TotalLpShipped { get; set; }
        public string LpNumber { get; set; }
        public string ShipmentNumber { get; set; }
        public string BinNumber { get; set; }
        public bool AllowEdits { get; set; }
    }

    public class SingleScanInventoryLookupResponseItemPODetailsTypeItem
    {
        public SingleScanInventoryLookupResponseItemPODetailsTypeItemItemType Item { get; set; }
        public double Qty { get; set; }

        [JsonProperty("ASNDetailID")]
        public int AsnDetailId { get; set; }
    }

    public class SingleScanInventoryLookupResponseItemPODetailsTypeItemItemType
    {
        [JsonProperty("ItemID")]
        public int ItemId { get; set; }
        public string ItemNumber { get; set; }
        public SingleScanInventoryLookupResponseItemPODetailsTypeItemItemTypeCoreItemTypeType CoreItemType { get; set; }
        public SingleScanInventoryLookupResponseItemPODetailsTypeItemItemTypeCoreValueType CoreValue { get; set; }

        [JsonProperty("UomTypeID")]
        public int UomTypeId { get; set; }
        public string UomDescription { get; set; }
        public int SignificantDigits { get; set; }
        public string BinNumber { get; set; }
        public string BinPath { get; set; }
        public bool IsLp { get; set; }
        public double Weight { get; set; }
        public double BaseConversionFactor { get; set; }
        public string ItemDescription { get; set; }
        public string AllocationSetName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SingleScanInventoryLookupResponseItemPODetailsTypeItemItemTypeCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SingleScanInventoryLookupResponseItemPODetailsTypeItemItemTypeCoreValueType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "DATE")]
        Date
    }

    public class GetTransferOrdersResponseItem
    {
        public string WarehouseName { get; set; }
        public string CustomerPONumber { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public int OrderType { get; set; }
        public GetTransferOrdersResponseItemCustomerType Customer { get; set; }
        public string RouteDescription { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderComment { get; set; }
        public string DestinationWarehouseName { get; set; }
        public string RouteNumber { get; set; }
        public string ShipDate { get; set; }
        public string DateCreated { get; set; }
        public GetTransferOrdersResponseItemLineItemsTypeItem[] LineItems { get; set; }
        public string LoadDate { get; set; }
        public string PrintDate { get; set; }
        public string ExportDate { get; set; }
        public string ParentOrderNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string ShippingMethodName { get; set; }
        public double ShippingWeight { get; set; }
        public double ShippingCost { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public int Identity { get; set; }
        public string UseOrderLevelShipping { get; set; }
        public string AllocationSetName { get; set; }
        public int PickingPriority { get; set; }
        public int RoutePickingPriority { get; set; }
    }

    public class GetTransferOrdersResponseItemCustomerType
    {
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerShortDesc { get; set; }
        public string CustomerNumber { get; set; }
        public string UpcManufacturerNumber { get; set; }
        public string CustomerPhone { get; set; }
        public bool TestInd { get; set; }
        public bool ConsiderDepartment { get; set; }
        public bool ConsiderDepartmentWhenPicking { get; set; }
        public string CustomerShipTo { get; set; }
        public string Gs1CompanyNumber { get; set; }
        public string StartingContainer { get; set; }
        public bool EdiIndicator { get; set; }
        public string CustomerClass { get; set; }
        public string NotificationEmail { get; set; }
        public int RequiredShelfLife { get; set; }
        public GetTransferOrdersResponseItemCustomerTypeCustomerShippingAddressesTypeItem[] CustomerShippingAddresses { get; set; }
    }

    public class GetTransferOrdersResponseItemCustomerTypeCustomerShippingAddressesTypeItem
    {
        public string CustomerShipName { get; set; }
        public string CustomerShipAttn { get; set; }
        public string CustomerShipAddress1 { get; set; }
        public string CustomerShipAddress2 { get; set; }
        public string CustomerShipCity { get; set; }
        public string CustomerShipState { get; set; }
        public string CustomerShipZipCode { get; set; }
        public string CustomerShipZip5 { get; set; }
        public string CustomerShipPhone { get; set; }
        public string CustomerShipFax { get; set; }
        public string CustomerShipCountry { get; set; }
        public string CustomerShipTo { get; set; }
        public string ValidatorObject { get; set; }
    }

    public class GetTransferOrdersResponseItemLineItemsTypeItem
    {
        public int LineNumber { get; set; }
        public int ComponentSequence { get; set; }
        public string ItemNumber { get; set; }
        public GetTransferOrdersResponseItemLineItemsTypeItemCoreItemTypeType CoreItemType { get; set; }
        public double QuantityOrdered { get; set; }
        public GetTransferOrdersResponseItemLineItemsTypeItemUomTypeType UomType { get; set; }
        public string LineItemComment { get; set; }
        public string ItemDescription { get; set; }
        public string WarehouseName { get; set; }
        public GetTransferOrdersResponseItemLineItemsTypeItemPickRecordsTypeItem[] PickRecords { get; set; }
        public string AllocationSetName { get; set; }

        [JsonProperty("InventoryRequestTaskID")]
        public string InventoryRequestTaskId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetTransferOrdersResponseItemLineItemsTypeItemCoreItemTypeType
    {
        [EnumMember(Value = "BASIC")]
        Basic,
        [EnumMember(Value = "LOT")]
        Lot,
        [EnumMember(Value = "SERIAL")]
        Serial,
        [EnumMember(Value = "or DATE")]
        OrDate
    }

    public class GetTransferOrdersResponseItemLineItemsTypeItemUomTypeType
    {
        public string UomDesc { get; set; }
        public int SignificantDigits { get; set; }
        public double BaseConversionFactor { get; set; }
    }

    public class GetTransferOrdersResponseItemLineItemsTypeItemPickRecordsTypeItem
    {
        public double QuantityShipped { get; set; }
        public double QuantityPicked { get; set; }
        public string CoreValue { get; set; }
    }

    public class CreateUpdateTransferOrderResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class CreateUpdateTransferOrderBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string DestinationWarehouseName { get; set; }
        public string CustomerPONumber { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public string AllocationSetName { get; set; }
        public string DateCreated { get; set; }
        public string OrderComment { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemCustomerType Customer { get; set; }
        public string RouteNumber { get; set; }
        public string DeliveryDate { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class CreateUpdateManufacturingOrderBodyInputItemLineItemsTypeItem
    {
        public int? LineNumber { get; set; }
        public string ItemNumber { get; set; }
        public string CoreItemType { get; set; }
        public double? QuantityOrdered { get; set; }
        public string LineItemComment { get; set; }
        public string ItemDescription { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemLineItemsTypeItemUomTypeType UomType { get; set; }
    }

    public class CreateUpdateManufacturingOrderBodyInputItemLineItemsTypeItemUomTypeType
    {
        public string UomDesc { get; set; }
        public int? SignificantDigits { get; set; }
        public double? BaseConversionFactor { get; set; }
    }

    public class GetPurchaseOrderResponseItem
    {
        public string WarehouseName { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string SchedDeliveryDate { get; set; }
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public int ReceivingPercentOver { get; set; }
        public int PurchaseOrderType { get; set; }
        public JToken[] PurchaseOrderComments { get; set; }
        public string CompletedDate { get; set; }
        public string ExportedDate { get; set; }
        public string DateCreated { get; set; }
        public bool AssignmentManuallyModified { get; set; }
        public bool WebReceipt { get; set; }
        public string FromWarehouse { get; set; }
        public int Identity { get; set; }
        public string Status { get; set; }
        public string AllocationSetName { get; set; }
        public GetPurchaseOrderResponseItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class GetPurchaseOrderResponseItemLineItemsTypeItem
    {
        public int LineNumber { get; set; }
        public string ItemNumber { get; set; }
        public string CoreItemType { get; set; }
        public double QuantityOrdered { get; set; }
        public string UomDesc { get; set; }
        public double BaseConversionFactor { get; set; }
        public int SignificantDigits { get; set; }
        public JToken[] LineItemComments { get; set; }
        public GetPurchaseOrderResponseItemLineItemsTypeItemReceiptsTypeItem[] Receipts { get; set; }
        public string AllocationSetName { get; set; }
    }

    public class GetPurchaseOrderResponseItemLineItemsTypeItemReceiptsTypeItem
    {
        public double QuantityReceived { get; set; }
        public double QuantityMissing { get; set; }
        public double QuantityDamaged { get; set; }
        public string CoreValue { get; set; }
        public string DateReceived { get; set; }
        public int Identity { get; set; }
        public string Status { get; set; }
        public int LineNumber { get; set; }
    }

    public class CreatePurchaseOrderResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class CreatePurchaseOrderBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string OrderDate { get; set; }
        public string SchedDeliveryDate { get; set; }
        public string VendorNumber { get; set; }
        public string VendorName { get; set; }
        public string AllocationSetName { get; set; }
        public BodyInputItemPurchaseOrderTypeType? PurchaseOrderType { get; set; }
        public string[] PurchaseOrderComments { get; set; }
        public CreatePurchaseOrderBodyInputItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class CreatePurchaseOrderBodyInputItemLineItemsTypeItem
    {
        public int? LineNumber { get; set; }
        public string ItemNumber { get; set; }
        public string CoreItemType { get; set; }
        public double? QuantityOrdered { get; set; }
        public string UomDesc { get; set; }
        public double? BaseConversionFactor { get; set; }
        public int? SignificantDigits { get; set; }
        public string AllocationSetName { get; set; }
        public string[] LineItemComments { get; set; }
    }

    public class GetManufacturingOrderResponseItem
    {
        public string WarehouseName { get; set; }
        public string CustomerPONumber { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public int OrderType { get; set; }
        public GetManufacturingOrderResponseItemCustomerType Customer { get; set; }
        public string RouteDescription { get; set; }
        public string DeliveryDate { get; set; }
        public string OrderComment { get; set; }
        public string DestinationWarehouseName { get; set; }
        public string RouteNumber { get; set; }
        public string ShipDate { get; set; }
        public string DateCreated { get; set; }
        public GetManufacturingOrderResponseItemLineItemsTypeItem[] LineItems { get; set; }
        public string LoadDate { get; set; }
        public string PrintDate { get; set; }
        public string ExportDate { get; set; }
        public string ParentOrderNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string ShippingMethodName { get; set; }
        public double ShippingWeight { get; set; }
        public double ShippingCost { get; set; }
        public string Status { get; set; }
        public string StatusCode { get; set; }
        public int Identity { get; set; }
        public string UseOrderLevelShipping { get; set; }
        public string AllocationSetName { get; set; }
        public int PickingPriority { get; set; }
        public int RoutePickingPriority { get; set; }
    }

    public class GetManufacturingOrderResponseItemCustomerType
    {
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerShortDesc { get; set; }
        public string CustomerNumber { get; set; }
        public string UpcManufacturerNumber { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerShipTo { get; set; }
        public string NotificationEmail { get; set; }
        public int RequiredShelfLife { get; set; }
        public GetManufacturingOrderResponseItemCustomerTypeCustomerShippingAddressesTypeItem[] CustomerShippingAddresses { get; set; }
    }

    public class GetManufacturingOrderResponseItemCustomerTypeCustomerShippingAddressesTypeItem
    {
        public string CustomerShipName { get; set; }
        public string CustomerShipAttn { get; set; }
        public string CustomerShipAddress1 { get; set; }
        public string CustomerShipAddress2 { get; set; }
        public string CustomerShipCity { get; set; }
        public string CustomerShipState { get; set; }
        public string CustomerShipZipCode { get; set; }
        public string CustomerShipZip5 { get; set; }
        public string CustomerShipPhone { get; set; }
        public string CustomerShipFax { get; set; }
        public string CustomerShipCountry { get; set; }
        public string CustomerShipTo { get; set; }
        public string ValidatorObject { get; set; }
    }

    public class GetManufacturingOrderResponseItemLineItemsTypeItem
    {
        public int LineNumber { get; set; }
        public int ComponentSequence { get; set; }
        public string ItemNumber { get; set; }
        public string CoreItemType { get; set; }
        public double QuantityOrdered { get; set; }
        public GetManufacturingOrderResponseItemLineItemsTypeItemUomTypeType UomType { get; set; }
        public string LineItemComment { get; set; }
        public string ItemDescription { get; set; }
        public string WarehouseName { get; set; }
        public GetManufacturingOrderResponseItemLineItemsTypeItemPickRecordsTypeItem[] PickRecords { get; set; }
        public string AllocationSetName { get; set; }

        [JsonProperty("InventoryRequestTaskID")]
        public string InventoryRequestTaskId { get; set; }
    }

    public class GetManufacturingOrderResponseItemLineItemsTypeItemUomTypeType
    {
        public string UomDesc { get; set; }
        public int SignificantDigits { get; set; }
        public double BaseConversionFactor { get; set; }
    }

    public class GetManufacturingOrderResponseItemLineItemsTypeItemPickRecordsTypeItem
    {
        public double QuantityShipped { get; set; }
        public double QuantityPicked { get; set; }
        public string CoreValue { get; set; }
    }

    public class CreateUpdateManufacturingOrderResponse
    {
        public int TotalCount { get; set; }
        public int InsertedCount { get; set; }
        public int UpdatedCount { get; set; }
        public int InvalidCount { get; set; }
        public JToken[] InvalidObjects { get; set; }
    }

    public class CreateUpdateManufacturingOrderBodyInputItem
    {
        public string WarehouseName { get; set; }
        public string CustomerPONumber { get; set; }
        public string VendorShipmentNumber { get; set; }
        public string OrderNumber { get; set; }
        public string AllocationSetName { get; set; }
        public string DateCreated { get; set; }
        public string OrderComment { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemCustomerType Customer { get; set; }
        public string RouteNumber { get; set; }
        public string DeliveryDate { get; set; }
        public CreateUpdateManufacturingOrderBodyInputItemLineItemsTypeItem[] LineItems { get; set; }
    }

    public class GetInventoryAggregateResponseItem
    {
        public string ItemNumber { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int QuantityOnHold { get; set; }
        public string ItemUom { get; set; }
        public GetInventoryAggregateResponseItemQuantityBySiteTypeItem[] QuantityBySite { get; set; }
    }

    public class GetInventoryAggregateResponseItemQuantityBySiteTypeItem
    {
        public string WarehouseName { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int QuantityOnHold { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Withoutwireinventory;

    public partial class WorkflowManagedActions
    {
        public WithoutwireinventoryActions Withoutwireinventory(string connectionId) => new WithoutwireinventoryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WithoutwireinventoryTriggers Withoutwireinventory(string connectionId) => new WithoutwireinventoryTriggers(connectionId);
    }
}