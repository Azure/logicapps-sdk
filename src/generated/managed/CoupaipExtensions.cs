//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Coupaip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CoupaipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad[]> OrderListQuery(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/order_pads";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<OrderPad[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad> OrderListCreate(Expression<Func<string>> orderPadname, Expression<Func<OrderPadLine[]>> orderPadorderPadLines, Expression<Func<string>> orderPadaddAllItems = null, Expression<Func<string>> orderPadanySupplier = null, Expression<Func<object>> orderPadbaseValue = null, Expression<Func<string>> orderPadbaseValueCurrencycode = null, Expression<Func<string>> orderPadbaseValueCurrencyenabled = null, Expression<Func<int>> orderPadbaseValueCurrencyid = null, Expression<Func<string>> orderPadbaseValueCurrencyname = null, Expression<Func<int>> orderPadid = null)
        {
            var apiCallPath = "/api/order_pads";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var orderPad = new JObject();
            var orderPadpropCount = 0;
            if (orderPadaddAllItems != null)
            {
                orderPad["add-all-items"] = ExpressionConverter.ConvertO(orderPadaddAllItems);
                orderPadpropCount++;
            }

            if (orderPadanySupplier != null)
            {
                orderPad["any-supplier"] = ExpressionConverter.ConvertO(orderPadanySupplier);
                orderPadpropCount++;
            }

            if (orderPadbaseValue != null)
            {
                orderPad["base-value"] = ExpressionConverter.ConvertO(orderPadbaseValue);
                orderPadpropCount++;
            }

            var  base  - value - currencyObject  =  new  JObject ( ) ; 
            var  base  - value - currencyObjectpropCount  =  0 ; 
            if (orderPadbaseValueCurrencycode != null)
            {
                base - value - currencyObject["code"] = ExpressionConverter.ConvertO(orderPadbaseValueCurrencycode);
                base - value - currencyObjectpropCount++;
            }

            if (orderPadbaseValueCurrencyenabled != null)
            {
                base - value - currencyObject["enabled"] = ExpressionConverter.ConvertO(orderPadbaseValueCurrencyenabled);
                base - value - currencyObjectpropCount++;
            }

            if (orderPadbaseValueCurrencyid != null)
            {
                base - value - currencyObject["id"] = ExpressionConverter.ConvertO(orderPadbaseValueCurrencyid);
                base - value - currencyObjectpropCount++;
            }

            if (orderPadbaseValueCurrencyname != null)
            {
                base - value - currencyObject["name"] = ExpressionConverter.ConvertO(orderPadbaseValueCurrencyname);
                base - value - currencyObjectpropCount++;
            }

            if (base - value - currencyObjectpropCount > 0)
            {
                orderPad["base-value-currency"] = base-value-currencyObject;
                orderPadpropCount++;
            }

            if (orderPadid != null)
            {
                orderPad["id"] = ExpressionConverter.ConvertO(orderPadid);
                orderPadpropCount++;
            }

            orderPadpropCount++;
            orderPad["name"] = ExpressionConverter.ConvertO(orderPadname);
            orderPadpropCount++;
            orderPad["order-pad-lines"] = ExpressionConverter.ConvertO(orderPadorderPadLines);
            if (orderPadpropCount > 0)
            {
                callPayload.Body = orderPad;
            }

            return new ApiConnectionAction<OrderPad>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<OrderPad> OrderListGetId(Expression<Func<int>> id, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/api/order_pads/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<OrderPad>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoices[]> InvoicesGet(Expression<Func<dirInput>> dir = null, Expression<Func<string>> invoiceDateLt = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> limit = null, Expression<Func<string>> offset = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["dir"] = Convert.ToString("desc");
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (invoiceDateLt != null)
                callPayload.Queries["invoice_date[lt]"] = ExpressionConverter.Convert(invoiceDateLt);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            callPayload.Queries["filter"] = Convert.ToString("default_invoices_filter");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<Invoices[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoices> InvoiceCreate(Expression<Func<string>> requestedbodyinvoiceDate = null, Expression<Func<string>> requestedbodyinvoiceNumber = null, Expression<Func<bool>> requestedbodylineLevelTaxation = null, Expression<Func<string>> requestedbodytotalWithTaxes = null, Expression<Func<string>> requestedbodydocumentType = null, Expression<Func<string>> requestedbodyrequestedBylogin = null, Expression<Func<bool>> requestedbodyaccountTypeactive = null, Expression<Func<string>> requestedbodyaccountTypecurrencycode = null, Expression<Func<string>> requestedbodyaccountTypecurrencyenabled = null, Expression<Func<int>> requestedbodyaccountTypecurrencyid = null, Expression<Func<string>> requestedbodyaccountTypecurrencyname = null, Expression<Func<int>> requestedbodyaccountTypeid = null, Expression<Func<string>> requestedbodyaccountTypename = null, Expression<Func<string>> requestedbodycurrencycode = null, Expression<Func<string>> requestedbodysupplieraccountNumber = null, Expression<Func<string>> requestedbodysuppliercreatedAt = null, Expression<Func<string>> requestedbodysupplierdisplayName = null, Expression<Func<int>> requestedbodysupplierid = null, Expression<Func<string>> requestedbodysuppliername = null, Expression<Func<string>> requestedbodysuppliernumber = null, Expression<Func<string>> requestedbodysupplierstatus = null, Expression<Func<string>> requestedbodylocationCode = null, Expression<Func<requestedbodyinvoiceLinesInputItem[]>> requestedbodyinvoiceLines = null)
        {
            var apiCallPath = "/api/invoices";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestedbody = new JObject();
            var requestedbodypropCount = 0;
            if (requestedbodyinvoiceDate != null)
            {
                requestedbody["invoice-date"] = ExpressionConverter.ConvertO(requestedbodyinvoiceDate);
                requestedbodypropCount++;
            }

            if (requestedbodyinvoiceNumber != null)
            {
                requestedbody["invoice-number"] = ExpressionConverter.ConvertO(requestedbodyinvoiceNumber);
                requestedbodypropCount++;
            }

            if (requestedbodylineLevelTaxation != null)
            {
                requestedbody["line-level-taxation"] = ExpressionConverter.ConvertO(requestedbodylineLevelTaxation);
                requestedbodypropCount++;
            }

            if (requestedbodytotalWithTaxes != null)
            {
                requestedbody["total-with-taxes"] = ExpressionConverter.ConvertO(requestedbodytotalWithTaxes);
                requestedbodypropCount++;
            }

            if (requestedbodydocumentType != null)
            {
                requestedbody["document-type"] = ExpressionConverter.ConvertO(requestedbodydocumentType);
                requestedbodypropCount++;
            }

            var requested - byObject  =  new  JObject ( );
            var requested - byObjectpropCount  =  0;
            if (requestedbodyrequestedBylogin != null)
            {
                requested - byObject["login"] = ExpressionConverter.ConvertO(requestedbodyrequestedBylogin);
                requested - byObjectpropCount++;
            }

            if (requested - byObjectpropCount > 0)
            {
                requestedbody["requested-by"] = requested-byObject;
                requestedbodypropCount++;
            }

            var account - typeObject  =  new  JObject ( );
            var account - typeObjectpropCount  =  0;
            if (requestedbodyaccountTypeactive != null)
            {
                account - typeObject["active"] = ExpressionConverter.ConvertO(requestedbodyaccountTypeactive);
                account - typeObjectpropCount++;
            }

            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (requestedbodyaccountTypecurrencycode != null)
            {
                currencyObject["code"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencycode);
                currencyObjectpropCount++;
            }

            if (requestedbodyaccountTypecurrencyenabled != null)
            {
                currencyObject["enabled"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencyenabled);
                currencyObjectpropCount++;
            }

            if (requestedbodyaccountTypecurrencyid != null)
            {
                currencyObject["id"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencyid);
                currencyObjectpropCount++;
            }

            if (requestedbodyaccountTypecurrencyname != null)
            {
                currencyObject["name"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencyname);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                account - typeObject["currency"] = currencyObject;
                account - typeObjectpropCount++;
            }

            if (requestedbodyaccountTypeid != null)
            {
                account - typeObject["id"] = ExpressionConverter.ConvertO(requestedbodyaccountTypeid);
                account - typeObjectpropCount++;
            }

            if (requestedbodyaccountTypename != null)
            {
                account - typeObject["name"] = ExpressionConverter.ConvertO(requestedbodyaccountTypename);
                account - typeObjectpropCount++;
            }

            if (account - typeObjectpropCount > 0)
            {
                requestedbody["account-type"] = account-typeObject;
                requestedbodypropCount++;
            }

            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (requestedbodycurrencycode != null)
            {
                currencyObject["code"] = ExpressionConverter.ConvertO(requestedbodycurrencycode);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                requestedbody["currency"] = currencyObject;
                requestedbodypropCount++;
            }

            var supplierObject = new JObject();
            var supplierObjectpropCount = 0;
            if (requestedbodysupplieraccountNumber != null)
            {
                supplierObject["account-number"] = ExpressionConverter.ConvertO(requestedbodysupplieraccountNumber);
                supplierObjectpropCount++;
            }

            if (requestedbodysuppliercreatedAt != null)
            {
                supplierObject["created-at"] = ExpressionConverter.ConvertO(requestedbodysuppliercreatedAt);
                supplierObjectpropCount++;
            }

            if (requestedbodysupplierdisplayName != null)
            {
                supplierObject["display-name"] = ExpressionConverter.ConvertO(requestedbodysupplierdisplayName);
                supplierObjectpropCount++;
            }

            if (requestedbodysupplierid != null)
            {
                supplierObject["id"] = ExpressionConverter.ConvertO(requestedbodysupplierid);
                supplierObjectpropCount++;
            }

            if (requestedbodysuppliername != null)
            {
                supplierObject["name"] = ExpressionConverter.ConvertO(requestedbodysuppliername);
                supplierObjectpropCount++;
            }

            if (requestedbodysuppliernumber != null)
            {
                supplierObject["number"] = ExpressionConverter.ConvertO(requestedbodysuppliernumber);
                supplierObjectpropCount++;
            }

            if (requestedbodysupplierstatus != null)
            {
                supplierObject["status"] = ExpressionConverter.ConvertO(requestedbodysupplierstatus);
                supplierObjectpropCount++;
            }

            if (supplierObjectpropCount > 0)
            {
                requestedbody["supplier"] = supplierObject;
                requestedbodypropCount++;
            }

            if (requestedbodylocationCode != null)
            {
                requestedbody["ship-to-address"] = ExpressionConverter.ConvertO(requestedbodylocationCode);
                requestedbodypropCount++;
            }

            if (requestedbodyinvoiceLines != null)
            {
                requestedbody["invoice-lines"] = ExpressionConverter.ConvertO(requestedbodyinvoiceLines);
                requestedbodypropCount++;
            }

            if (requestedbodypropCount > 0)
            {
                callPayload.Body = requestedbody;
            }

            return new ApiConnectionAction<Invoices>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoices> InvoicesGetById(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/api/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Invoices>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IWorkflowAction InvoicesDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoices> InvoicesUpdate(Expression<Func<string>> id, Expression<Func<string>> requestedbodyinvoiceDate = null, Expression<Func<string>> requestedbodyinvoiceNumber = null, Expression<Func<bool>> requestedbodylineLevelTaxation = null, Expression<Func<string>> requestedbodytotalWithTaxes = null, Expression<Func<string>> requestedbodydocumentType = null, Expression<Func<string>> requestedbodyrequestedBylogin = null, Expression<Func<bool>> requestedbodyaccountTypeactive = null, Expression<Func<string>> requestedbodyaccountTypecurrencycode = null, Expression<Func<string>> requestedbodyaccountTypecurrencyenabled = null, Expression<Func<int>> requestedbodyaccountTypecurrencyid = null, Expression<Func<string>> requestedbodyaccountTypecurrencyname = null, Expression<Func<int>> requestedbodyaccountTypeid = null, Expression<Func<string>> requestedbodyaccountTypename = null, Expression<Func<string>> requestedbodycurrencycode = null, Expression<Func<string>> requestedbodysupplieraccountNumber = null, Expression<Func<string>> requestedbodysuppliercreatedAt = null, Expression<Func<string>> requestedbodysupplierdisplayName = null, Expression<Func<int>> requestedbodysupplierid = null, Expression<Func<string>> requestedbodysuppliername = null, Expression<Func<string>> requestedbodysuppliernumber = null, Expression<Func<string>> requestedbodysupplierstatus = null, Expression<Func<string>> requestedbodylocationCode = null, Expression<Func<requestedbodyinvoiceLinesInputItem2[]>> requestedbodyinvoiceLines = null)
        {
            var apiCallPath = String.Format("/api/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestedbody = new JObject();
            var requestedbodypropCount = 0;
            if (requestedbodyinvoiceDate != null)
            {
                requestedbody["invoice-date"] = ExpressionConverter.ConvertO(requestedbodyinvoiceDate);
                requestedbodypropCount++;
            }

            if (requestedbodyinvoiceNumber != null)
            {
                requestedbody["invoice-number"] = ExpressionConverter.ConvertO(requestedbodyinvoiceNumber);
                requestedbodypropCount++;
            }

            if (requestedbodylineLevelTaxation != null)
            {
                requestedbody["line-level-taxation"] = ExpressionConverter.ConvertO(requestedbodylineLevelTaxation);
                requestedbodypropCount++;
            }

            if (requestedbodytotalWithTaxes != null)
            {
                requestedbody["total-with-taxes"] = ExpressionConverter.ConvertO(requestedbodytotalWithTaxes);
                requestedbodypropCount++;
            }

            if (requestedbodydocumentType != null)
            {
                requestedbody["document-type"] = ExpressionConverter.ConvertO(requestedbodydocumentType);
                requestedbodypropCount++;
            }

            var requested - byObject  =  new  JObject ( );
            var requested - byObjectpropCount  =  0;
            if (requestedbodyrequestedBylogin != null)
            {
                requested - byObject["login"] = ExpressionConverter.ConvertO(requestedbodyrequestedBylogin);
                requested - byObjectpropCount++;
            }

            if (requested - byObjectpropCount > 0)
            {
                requestedbody["requested-by"] = requested-byObject;
                requestedbodypropCount++;
            }

            var account - typeObject  =  new  JObject ( );
            var account - typeObjectpropCount  =  0;
            if (requestedbodyaccountTypeactive != null)
            {
                account - typeObject["active"] = ExpressionConverter.ConvertO(requestedbodyaccountTypeactive);
                account - typeObjectpropCount++;
            }

            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (requestedbodyaccountTypecurrencycode != null)
            {
                currencyObject["code"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencycode);
                currencyObjectpropCount++;
            }

            if (requestedbodyaccountTypecurrencyenabled != null)
            {
                currencyObject["enabled"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencyenabled);
                currencyObjectpropCount++;
            }

            if (requestedbodyaccountTypecurrencyid != null)
            {
                currencyObject["id"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencyid);
                currencyObjectpropCount++;
            }

            if (requestedbodyaccountTypecurrencyname != null)
            {
                currencyObject["name"] = ExpressionConverter.ConvertO(requestedbodyaccountTypecurrencyname);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                account - typeObject["currency"] = currencyObject;
                account - typeObjectpropCount++;
            }

            if (requestedbodyaccountTypeid != null)
            {
                account - typeObject["id"] = ExpressionConverter.ConvertO(requestedbodyaccountTypeid);
                account - typeObjectpropCount++;
            }

            if (requestedbodyaccountTypename != null)
            {
                account - typeObject["name"] = ExpressionConverter.ConvertO(requestedbodyaccountTypename);
                account - typeObjectpropCount++;
            }

            if (account - typeObjectpropCount > 0)
            {
                requestedbody["account-type"] = account-typeObject;
                requestedbodypropCount++;
            }

            var currencyObject = new JObject();
            var currencyObjectpropCount = 0;
            if (requestedbodycurrencycode != null)
            {
                currencyObject["code"] = ExpressionConverter.ConvertO(requestedbodycurrencycode);
                currencyObjectpropCount++;
            }

            if (currencyObjectpropCount > 0)
            {
                requestedbody["currency"] = currencyObject;
                requestedbodypropCount++;
            }

            var supplierObject = new JObject();
            var supplierObjectpropCount = 0;
            if (requestedbodysupplieraccountNumber != null)
            {
                supplierObject["account-number"] = ExpressionConverter.ConvertO(requestedbodysupplieraccountNumber);
                supplierObjectpropCount++;
            }

            if (requestedbodysuppliercreatedAt != null)
            {
                supplierObject["created-at"] = ExpressionConverter.ConvertO(requestedbodysuppliercreatedAt);
                supplierObjectpropCount++;
            }

            if (requestedbodysupplierdisplayName != null)
            {
                supplierObject["display-name"] = ExpressionConverter.ConvertO(requestedbodysupplierdisplayName);
                supplierObjectpropCount++;
            }

            if (requestedbodysupplierid != null)
            {
                supplierObject["id"] = ExpressionConverter.ConvertO(requestedbodysupplierid);
                supplierObjectpropCount++;
            }

            if (requestedbodysuppliername != null)
            {
                supplierObject["name"] = ExpressionConverter.ConvertO(requestedbodysuppliername);
                supplierObjectpropCount++;
            }

            if (requestedbodysuppliernumber != null)
            {
                supplierObject["number"] = ExpressionConverter.ConvertO(requestedbodysuppliernumber);
                supplierObjectpropCount++;
            }

            if (requestedbodysupplierstatus != null)
            {
                supplierObject["status"] = ExpressionConverter.ConvertO(requestedbodysupplierstatus);
                supplierObjectpropCount++;
            }

            if (supplierObjectpropCount > 0)
            {
                requestedbody["supplier"] = supplierObject;
                requestedbodypropCount++;
            }

            if (requestedbodylocationCode != null)
            {
                requestedbody["ship-to-address"] = ExpressionConverter.ConvertO(requestedbodylocationCode);
                requestedbodypropCount++;
            }

            if (requestedbodyinvoiceLines != null)
            {
                requestedbody["invoice-lines"] = ExpressionConverter.ConvertO(requestedbodyinvoiceLines);
                requestedbodypropCount++;
            }

            if (requestedbodypropCount > 0)
            {
                callPayload.Body = requestedbody;
            }

            return new ApiConnectionAction<Invoices>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Invoices> InvoicesVoid(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/invoices/{0}/void", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Invoices>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InventoryTransaction> ReceiptsVoid(Expression<Func<string>> id, Expression<Func<string>> fields = null)
        {
            var apiCallPath = String.Format("/api/receiving_transactions/{0}/void", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<InventoryTransaction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<InventoryTransaction> ReceiptCreate(Expression<Func<int>> bodyquantity = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<double>> bodyreceiptTransactionIDToVoid = null, Expression<Func<int>> bodyorderLinecoupaInteralLineID = null)
        {
            var apiCallPath = "/api/receiving_transactions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquantity != null)
            {
                body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyreceiptTransactionIDToVoid != null)
            {
                body["original-transaction-id"] = ExpressionConverter.ConvertO(bodyreceiptTransactionIDToVoid);
                bodypropCount++;
            }

            var order - lineObject  =  new  JObject ( );
            var order - lineObjectpropCount  =  0;
            if (bodyorderLinecoupaInteralLineID != null)
            {
                order - lineObject["id"] = ExpressionConverter.ConvertO(bodyorderLinecoupaInteralLineID);
                order - lineObjectpropCount++;
            }

            if (order - lineObjectpropCount > 0)
            {
                body["order-line"] = order-lineObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InventoryTransaction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Contract[]> ContractGet(Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null, Expression<Func<dirInput>> dir = null)
        {
            var apiCallPath = "/api/contracts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            return new ApiConnectionAction<Contract[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Contract> ContractPost(Expression<Func<ContractTerm[]>> contractcontractTerms = null, Expression<Func<string>> contractcreatedAt = null, Expression<Func<string>> contractdescription = null, Expression<Func<string>> contractendDate = null, Expression<Func<int>> contractid = null, Expression<Func<string>> contractmaximumValue = null, Expression<Func<string>> contractminimumValue = null, Expression<Func<string>> contractname = null, Expression<Func<string>> contractnumber = null, Expression<Func<string>> contractstartDate = null, Expression<Func<string>> contractstatus = null, Expression<Func<string>> contractsupplieraccountNumber = null, Expression<Func<string>> contractsuppliercreatedAt = null, Expression<Func<string>> contractsupplierdisplayName = null, Expression<Func<int>> contractsupplierid = null, Expression<Func<string>> contractsuppliername = null, Expression<Func<string>> contractsuppliernumber = null, Expression<Func<string>> contractsupplierstatus = null, Expression<Func<string>> contractsupplierAccount = null, Expression<Func<string>> contractupdatedAt = null, Expression<Func<int>> contractversion = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/contracts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            var contract = new JObject();
            var contractpropCount = 0;
            if (contractcontractTerms != null)
            {
                contract["contract-terms"] = ExpressionConverter.ConvertO(contractcontractTerms);
                contractpropCount++;
            }

            if (contractcreatedAt != null)
            {
                contract["created-at"] = ExpressionConverter.ConvertO(contractcreatedAt);
                contractpropCount++;
            }

            if (contractdescription != null)
            {
                contract["description"] = ExpressionConverter.ConvertO(contractdescription);
                contractpropCount++;
            }

            if (contractendDate != null)
            {
                contract["end-date"] = ExpressionConverter.ConvertO(contractendDate);
                contractpropCount++;
            }

            if (contractid != null)
            {
                contract["id"] = ExpressionConverter.ConvertO(contractid);
                contractpropCount++;
            }

            if (contractmaximumValue != null)
            {
                contract["maximum-value"] = ExpressionConverter.ConvertO(contractmaximumValue);
                contractpropCount++;
            }

            if (contractminimumValue != null)
            {
                contract["minimum-value"] = ExpressionConverter.ConvertO(contractminimumValue);
                contractpropCount++;
            }

            if (contractname != null)
            {
                contract["name"] = ExpressionConverter.ConvertO(contractname);
                contractpropCount++;
            }

            if (contractnumber != null)
            {
                contract["number"] = ExpressionConverter.ConvertO(contractnumber);
                contractpropCount++;
            }

            if (contractstartDate != null)
            {
                contract["start-date"] = ExpressionConverter.ConvertO(contractstartDate);
                contractpropCount++;
            }

            if (contractstatus != null)
            {
                contract["status"] = ExpressionConverter.ConvertO(contractstatus);
                contractpropCount++;
            }

            var supplierObject = new JObject();
            var supplierObjectpropCount = 0;
            if (contractsupplieraccountNumber != null)
            {
                supplierObject["account-number"] = ExpressionConverter.ConvertO(contractsupplieraccountNumber);
                supplierObjectpropCount++;
            }

            if (contractsuppliercreatedAt != null)
            {
                supplierObject["created-at"] = ExpressionConverter.ConvertO(contractsuppliercreatedAt);
                supplierObjectpropCount++;
            }

            if (contractsupplierdisplayName != null)
            {
                supplierObject["display-name"] = ExpressionConverter.ConvertO(contractsupplierdisplayName);
                supplierObjectpropCount++;
            }

            if (contractsupplierid != null)
            {
                supplierObject["id"] = ExpressionConverter.ConvertO(contractsupplierid);
                supplierObjectpropCount++;
            }

            if (contractsuppliername != null)
            {
                supplierObject["name"] = ExpressionConverter.ConvertO(contractsuppliername);
                supplierObjectpropCount++;
            }

            if (contractsuppliernumber != null)
            {
                supplierObject["number"] = ExpressionConverter.ConvertO(contractsuppliernumber);
                supplierObjectpropCount++;
            }

            if (contractsupplierstatus != null)
            {
                supplierObject["status"] = ExpressionConverter.ConvertO(contractsupplierstatus);
                supplierObjectpropCount++;
            }

            if (supplierObjectpropCount > 0)
            {
                contract["supplier"] = supplierObject;
                contractpropCount++;
            }

            if (contractsupplierAccount != null)
            {
                contract["supplier-account"] = ExpressionConverter.ConvertO(contractsupplierAccount);
                contractpropCount++;
            }

            if (contractupdatedAt != null)
            {
                contract["updated-at"] = ExpressionConverter.ConvertO(contractupdatedAt);
                contractpropCount++;
            }

            if (contractversion != null)
            {
                contract["version"] = ExpressionConverter.ConvertO(contractversion);
                contractpropCount++;
            }

            if (contractpropCount > 0)
            {
                callPayload.Body = contract;
            }

            return new ApiConnectionAction<Contract>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Contract> ContractGetId(Expression<Func<string>> id, Expression<Func<int>> offset = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<dirInput>> dir = null)
        {
            var apiCallPath = String.Format("/api/contracts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            return new ApiConnectionAction<Contract>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<ContractTerm> ContractTermAdd(Expression<Func<string>> id, Expression<Func<bodycontractTermTypeInput>> bodycontractTermType = null, Expression<Func<string>> bodycreatedAt = null, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytier1DiscPct = null, Expression<Func<string>> bodytier1UpperBound = null, Expression<Func<string>> bodytier2DiscPct = null, Expression<Func<string>> bodytier2UpperBound = null, Expression<Func<string>> bodytier3DiscPct = null, Expression<Func<string>> bodytier3UpperBound = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyupdatedAt = null, Expression<Func<string>> bodyusePctDiscounts = null)
        {
            var apiCallPath = String.Format("/api/contracts/{0}/contract_terms", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontractTermType != null)
            {
                body["contract-term-type"] = ExpressionConverter.ConvertO(bodycontractTermType);
                bodypropCount++;
            }

            if (bodycreatedAt != null)
            {
                body["created-at"] = ExpressionConverter.ConvertO(bodycreatedAt);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytier1DiscPct != null)
            {
                body["tier-1-disc-pct"] = ExpressionConverter.ConvertO(bodytier1DiscPct);
                bodypropCount++;
            }

            if (bodytier1UpperBound != null)
            {
                body["tier-1-upper-bound"] = ExpressionConverter.ConvertO(bodytier1UpperBound);
                bodypropCount++;
            }

            if (bodytier2DiscPct != null)
            {
                body["tier-2-disc-pct"] = ExpressionConverter.ConvertO(bodytier2DiscPct);
                bodypropCount++;
            }

            if (bodytier2UpperBound != null)
            {
                body["tier-2-upper-bound"] = ExpressionConverter.ConvertO(bodytier2UpperBound);
                bodypropCount++;
            }

            if (bodytier3DiscPct != null)
            {
                body["tier-3-disc-pct"] = ExpressionConverter.ConvertO(bodytier3DiscPct);
                bodypropCount++;
            }

            if (bodytier3UpperBound != null)
            {
                body["tier-3-upper-bound"] = ExpressionConverter.ConvertO(bodytier3UpperBound);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyupdatedAt != null)
            {
                body["updated-at"] = ExpressionConverter.ConvertO(bodyupdatedAt);
                bodypropCount++;
            }

            if (bodyusePctDiscounts != null)
            {
                body["use-pct-discounts"] = ExpressionConverter.ConvertO(bodyusePctDiscounts);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContractTerm>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<RequisitionHeader> ReqFreeText(Expression<Func<RequisitionLine[]>> bodyrequisitionLines, Expression<Func<string>> bodyshipToAddresscountrycode, Expression<Func<string>> bodystatus, Expression<Func<Attachments[]>> bodyattachments = null, Expression<Func<bool>> bodyexported = null, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodyjustification = null, Expression<Func<string>> bodyneedByDate = null, Expression<Func<string>> bodyreqTitle = null, Expression<Func<bool>> bodyrequesteractive = null, Expression<Func<UserGroup[]>> bodyrequesterapprovalGroups = null, Expression<Func<bodyrequesterbusinessGroupSecurityTypeInput>> bodyrequesterbusinessGroupSecurityType = null, Expression<Func<BusinessGroup[]>> bodyrequestercontentGroups = null, Expression<Func<string>> bodyrequestercreatedAt = null, Expression<Func<string>> bodyrequesteremail = null, Expression<Func<string>> bodyrequesterlogin = null, Expression<Func<string>> bodyrequesterfullname = null, Expression<Func<int>> bodyrequesterid = null, Expression<Func<string>> bodyrequesterupdatedAt = null, Expression<Func<UserGroup[]>> bodyrequesteruserGroups = null, Expression<Func<bool>> bodycreatedByactive = null, Expression<Func<UserGroup[]>> bodycreatedByapprovalGroups = null, Expression<Func<bodycreatedBybusinessGroupSecurityTypeInput>> bodycreatedBybusinessGroupSecurityType = null, Expression<Func<BusinessGroup[]>> bodycreatedBycontentGroups = null, Expression<Func<string>> bodycreatedBycreatedAt = null, Expression<Func<string>> bodycreatedByemail = null, Expression<Func<string>> bodycreatedBylogin = null, Expression<Func<string>> bodycreatedByfullname = null, Expression<Func<int>> bodycreatedByid = null, Expression<Func<string>> bodycreatedByupdatedAt = null, Expression<Func<UserGroup[]>> bodycreatedByuserGroups = null, Expression<Func<string>> bodyshipToAddressname = null, Expression<Func<string>> bodyshipToAddresslocationCode = null, Expression<Func<string>> bodyshipToAddressstreet1 = null, Expression<Func<string>> bodyshipToAddressstreet2 = null, Expression<Func<string>> bodyshipToAddresscity = null, Expression<Func<string>> bodyshipToAddressstate = null, Expression<Func<string>> bodyshipToAddresspostalCode = null, Expression<Func<int>> bodyshipToAddresscountryid = null, Expression<Func<string>> bodyshipToAddresscountryname = null, Expression<Func<int>> bodyshipToAddressid = null, Expression<Func<string>> bodyshipToAttention = null)
        {
            var apiCallPath = "/api/requisitions/add_to_cart";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyattachments != null)
            {
                body["attachments"] = ExpressionConverter.ConvertO(bodyattachments);
                bodypropCount++;
            }

            if (bodyexported != null)
            {
                body["exported"] = ExpressionConverter.ConvertO(bodyexported);
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyjustification != null)
            {
                body["justification"] = ExpressionConverter.ConvertO(bodyjustification);
                bodypropCount++;
            }

            if (bodyneedByDate != null)
            {
                body["need-by-date"] = ExpressionConverter.ConvertO(bodyneedByDate);
                bodypropCount++;
            }

            if (bodyreqTitle != null)
            {
                body["req-title"] = ExpressionConverter.ConvertO(bodyreqTitle);
                bodypropCount++;
            }

            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            if (bodyrequesteractive != null)
            {
                requesterObject["active"] = ExpressionConverter.ConvertO(bodyrequesteractive);
                requesterObjectpropCount++;
            }

            if (bodyrequesterapprovalGroups != null)
            {
                requesterObject["approval-groups"] = ExpressionConverter.ConvertO(bodyrequesterapprovalGroups);
                requesterObjectpropCount++;
            }

            if (bodyrequesterbusinessGroupSecurityType != null)
            {
                requesterObject["business-group-security-type"] = ExpressionConverter.ConvertO(bodyrequesterbusinessGroupSecurityType);
                requesterObjectpropCount++;
            }

            if (bodyrequestercontentGroups != null)
            {
                requesterObject["content-groups"] = ExpressionConverter.ConvertO(bodyrequestercontentGroups);
                requesterObjectpropCount++;
            }

            if (bodyrequestercreatedAt != null)
            {
                requesterObject["created-at"] = ExpressionConverter.ConvertO(bodyrequestercreatedAt);
                requesterObjectpropCount++;
            }

            if (bodyrequesteremail != null)
            {
                requesterObject["email"] = ExpressionConverter.ConvertO(bodyrequesteremail);
                requesterObjectpropCount++;
            }

            if (bodyrequesterlogin != null)
            {
                requesterObject["login"] = ExpressionConverter.ConvertO(bodyrequesterlogin);
                requesterObjectpropCount++;
            }

            if (bodyrequesterfullname != null)
            {
                requesterObject["fullname"] = ExpressionConverter.ConvertO(bodyrequesterfullname);
                requesterObjectpropCount++;
            }

            if (bodyrequesterid != null)
            {
                requesterObject["id"] = ExpressionConverter.ConvertO(bodyrequesterid);
                requesterObjectpropCount++;
            }

            if (bodyrequesterupdatedAt != null)
            {
                requesterObject["updated-at"] = ExpressionConverter.ConvertO(bodyrequesterupdatedAt);
                requesterObjectpropCount++;
            }

            if (bodyrequesteruserGroups != null)
            {
                requesterObject["user-groups"] = ExpressionConverter.ConvertO(bodyrequesteruserGroups);
                requesterObjectpropCount++;
            }

            if (requesterObjectpropCount > 0)
            {
                body["requester"] = requesterObject;
                bodypropCount++;
            }

            var created - byObject  =  new  JObject ( );
            var created - byObjectpropCount  =  0;
            if (bodyrequesteractive != null)
            {
                created - byObject["active"] = ExpressionConverter.ConvertO(bodyrequesteractive);
                created - byObjectpropCount++;
            }

            if (bodyrequesterapprovalGroups != null)
            {
                created - byObject["approval-groups"] = ExpressionConverter.ConvertO(bodyrequesterapprovalGroups);
                created - byObjectpropCount++;
            }

            if (bodyrequesterbusinessGroupSecurityType != null)
            {
                created - byObject["business-group-security-type"] = ExpressionConverter.ConvertO(bodyrequesterbusinessGroupSecurityType);
                created - byObjectpropCount++;
            }

            if (bodyrequestercontentGroups != null)
            {
                created - byObject["content-groups"] = ExpressionConverter.ConvertO(bodyrequestercontentGroups);
                created - byObjectpropCount++;
            }

            if (bodyrequestercreatedAt != null)
            {
                created - byObject["created-at"] = ExpressionConverter.ConvertO(bodyrequestercreatedAt);
                created - byObjectpropCount++;
            }

            if (bodyrequesteremail != null)
            {
                created - byObject["email"] = ExpressionConverter.ConvertO(bodyrequesteremail);
                created - byObjectpropCount++;
            }

            if (bodyrequesterlogin != null)
            {
                created - byObject["login"] = ExpressionConverter.ConvertO(bodyrequesterlogin);
                created - byObjectpropCount++;
            }

            if (bodyrequesterfullname != null)
            {
                created - byObject["fullname"] = ExpressionConverter.ConvertO(bodyrequesterfullname);
                created - byObjectpropCount++;
            }

            if (bodyrequesterid != null)
            {
                created - byObject["id"] = ExpressionConverter.ConvertO(bodyrequesterid);
                created - byObjectpropCount++;
            }

            if (bodyrequesterupdatedAt != null)
            {
                created - byObject["updated-at"] = ExpressionConverter.ConvertO(bodyrequesterupdatedAt);
                created - byObjectpropCount++;
            }

            if (bodyrequesteruserGroups != null)
            {
                created - byObject["user-groups"] = ExpressionConverter.ConvertO(bodyrequesteruserGroups);
                created - byObjectpropCount++;
            }

            if (created - byObjectpropCount > 0)
            {
                body["created-by"] = created-byObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["requisition-lines"] = ExpressionConverter.ConvertO(bodyrequisitionLines);
            var ship - to - addressObject  =  new  JObject ( );
            var ship - to - addressObjectpropCount  =  0;
            if (bodyshipToAddressname != null)
            {
                ship - to - addressObject["name"] = ExpressionConverter.ConvertO(bodyshipToAddressname);
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddresslocationCode != null)
            {
                ship - to - addressObject["location-code"] = ExpressionConverter.ConvertO(bodyshipToAddresslocationCode);
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddressstreet1 != null)
            {
                ship - to - addressObject["street1"] = ExpressionConverter.ConvertO(bodyshipToAddressstreet1);
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddressstreet2 != null)
            {
                ship - to - addressObject["street2"] = ExpressionConverter.ConvertO(bodyshipToAddressstreet2);
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddresscity != null)
            {
                ship - to - addressObject["city"] = ExpressionConverter.ConvertO(bodyshipToAddresscity);
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddressstate != null)
            {
                ship - to - addressObject["state"] = ExpressionConverter.ConvertO(bodyshipToAddressstate);
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddresspostalCode != null)
            {
                ship - to - addressObject["postal-code"] = ExpressionConverter.ConvertO(bodyshipToAddresspostalCode);
                ship - to - addressObjectpropCount++;
            }

            var countryObject = new JObject();
            var countryObjectpropCount = 0;
            countryObjectpropCount++;
            countryObject["code"] = ExpressionConverter.ConvertO(bodyshipToAddresscountrycode);
            if (bodyshipToAddresscountryid != null)
            {
                countryObject["id"] = ExpressionConverter.ConvertO(bodyshipToAddresscountryid);
                countryObjectpropCount++;
            }

            if (bodyshipToAddresscountryname != null)
            {
                countryObject["name"] = ExpressionConverter.ConvertO(bodyshipToAddresscountryname);
                countryObjectpropCount++;
            }

            if (countryObjectpropCount > 0)
            {
                ship - to - addressObject["country"] = countryObject;
                ship - to - addressObjectpropCount++;
            }

            if (bodyshipToAddressid != null)
            {
                ship - to - addressObject["id"] = ExpressionConverter.ConvertO(bodyshipToAddressid);
                ship - to - addressObjectpropCount++;
            }

            if (ship - to - addressObjectpropCount > 0)
            {
                body["ship-to-address"] = ship-to-addressObject;
                bodypropCount++;
            }

            if (bodyshipToAttention != null)
            {
                body["ship-to-attention"] = ExpressionConverter.ConvertO(bodyshipToAttention);
                bodypropCount++;
            }

            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RequisitionHeader>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder[]> POGet(Expression<Func<string>> filter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null)
        {
            var apiCallPath = "/api/purchase_orders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            return new ApiConnectionAction<PurchaseOrder[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder> POGetId(Expression<Func<string>> id, Expression<Func<string>> filter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("po_shallow");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            return new ApiConnectionAction<PurchaseOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder> POCancel(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}/cancel", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PurchaseOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder> POClose(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}/close", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PurchaseOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<PurchaseOrder> POReOpen(Expression<Func<string>> id, Expression<Func<string>> bodyreasonCode = null, Expression<Func<string>> bodyreasonComment = null)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}/reopen", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyreasonCode != null)
            {
                body["reason_insight_code"] = ExpressionConverter.ConvertO(bodyreasonCode);
                bodypropCount++;
            }

            if (bodyreasonComment != null)
            {
                body["reason-insight-event-comment"] = ExpressionConverter.ConvertO(bodyreasonComment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PurchaseOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<RequisitionHeader[]> ReqGet(Expression<Func<string>> limit = null, Expression<Func<string>> offset = null)
        {
            var apiCallPath = "/api/requisitions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<RequisitionHeader[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<RequisitionHeader> ReqGetById(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/requisitions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RequisitionHeader>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<RequisitionHeader> ReqUpdate(Expression<Func<string>> id, Expression<Func<RequisitionLine[]>> requestedbodyrequisitionLines, Expression<Func<string>> requestedbodyshipToAddresscountrycode, Expression<Func<string>> requestedbodystatus, Expression<Func<Attachments[]>> requestedbodyattachments = null, Expression<Func<bool>> requestedbodyexported = null, Expression<Func<int>> requestedbodyid = null, Expression<Func<string>> requestedbodyjustification = null, Expression<Func<string>> requestedbodyneedByDate = null, Expression<Func<string>> requestedbodyreqTitle = null, Expression<Func<bool>> requestedbodyrequesteractive = null, Expression<Func<UserGroup[]>> requestedbodyrequesterapprovalGroups = null, Expression<Func<requestedbodyrequesterbusinessGroupSecurityTypeInput>> requestedbodyrequesterbusinessGroupSecurityType = null, Expression<Func<BusinessGroup[]>> requestedbodyrequestercontentGroups = null, Expression<Func<string>> requestedbodyrequestercreatedAt = null, Expression<Func<string>> requestedbodyrequesteremail = null, Expression<Func<string>> requestedbodyrequesterlogin = null, Expression<Func<string>> requestedbodyrequesterfullname = null, Expression<Func<int>> requestedbodyrequesterid = null, Expression<Func<string>> requestedbodyrequesterupdatedAt = null, Expression<Func<UserGroup[]>> requestedbodyrequesteruserGroups = null, Expression<Func<bool>> requestedbodycreatedByactive = null, Expression<Func<UserGroup[]>> requestedbodycreatedByapprovalGroups = null, Expression<Func<requestedbodycreatedBybusinessGroupSecurityTypeInput>> requestedbodycreatedBybusinessGroupSecurityType = null, Expression<Func<BusinessGroup[]>> requestedbodycreatedBycontentGroups = null, Expression<Func<string>> requestedbodycreatedBycreatedAt = null, Expression<Func<string>> requestedbodycreatedByemail = null, Expression<Func<string>> requestedbodycreatedBylogin = null, Expression<Func<string>> requestedbodycreatedByfullname = null, Expression<Func<int>> requestedbodycreatedByid = null, Expression<Func<string>> requestedbodycreatedByupdatedAt = null, Expression<Func<UserGroup[]>> requestedbodycreatedByuserGroups = null, Expression<Func<string>> requestedbodyshipToAddressname = null, Expression<Func<string>> requestedbodyshipToAddresslocationCode = null, Expression<Func<string>> requestedbodyshipToAddressstreet1 = null, Expression<Func<string>> requestedbodyshipToAddressstreet2 = null, Expression<Func<string>> requestedbodyshipToAddresscity = null, Expression<Func<string>> requestedbodyshipToAddressstate = null, Expression<Func<string>> requestedbodyshipToAddresspostalCode = null, Expression<Func<int>> requestedbodyshipToAddresscountryid = null, Expression<Func<string>> requestedbodyshipToAddresscountryname = null, Expression<Func<int>> requestedbodyshipToAddressid = null, Expression<Func<string>> requestedbodyshipToAttention = null)
        {
            var apiCallPath = String.Format("/api/requisitions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestedbody = new JObject();
            var requestedbodypropCount = 0;
            if (requestedbodyattachments != null)
            {
                requestedbody["attachments"] = ExpressionConverter.ConvertO(requestedbodyattachments);
                requestedbodypropCount++;
            }

            if (requestedbodyexported != null)
            {
                requestedbody["exported"] = ExpressionConverter.ConvertO(requestedbodyexported);
                requestedbodypropCount++;
            }

            if (requestedbodyid != null)
            {
                requestedbody["id"] = ExpressionConverter.ConvertO(requestedbodyid);
                requestedbodypropCount++;
            }

            if (requestedbodyjustification != null)
            {
                requestedbody["justification"] = ExpressionConverter.ConvertO(requestedbodyjustification);
                requestedbodypropCount++;
            }

            if (requestedbodyneedByDate != null)
            {
                requestedbody["need-by-date"] = ExpressionConverter.ConvertO(requestedbodyneedByDate);
                requestedbodypropCount++;
            }

            if (requestedbodyreqTitle != null)
            {
                requestedbody["req-title"] = ExpressionConverter.ConvertO(requestedbodyreqTitle);
                requestedbodypropCount++;
            }

            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            if (requestedbodyrequesteractive != null)
            {
                requesterObject["active"] = ExpressionConverter.ConvertO(requestedbodyrequesteractive);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterapprovalGroups != null)
            {
                requesterObject["approval-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesterapprovalGroups);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterbusinessGroupSecurityType != null)
            {
                requesterObject["business-group-security-type"] = ExpressionConverter.ConvertO(requestedbodyrequesterbusinessGroupSecurityType);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequestercontentGroups != null)
            {
                requesterObject["content-groups"] = ExpressionConverter.ConvertO(requestedbodyrequestercontentGroups);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequestercreatedAt != null)
            {
                requesterObject["created-at"] = ExpressionConverter.ConvertO(requestedbodyrequestercreatedAt);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesteremail != null)
            {
                requesterObject["email"] = ExpressionConverter.ConvertO(requestedbodyrequesteremail);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterlogin != null)
            {
                requesterObject["login"] = ExpressionConverter.ConvertO(requestedbodyrequesterlogin);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterfullname != null)
            {
                requesterObject["fullname"] = ExpressionConverter.ConvertO(requestedbodyrequesterfullname);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterid != null)
            {
                requesterObject["id"] = ExpressionConverter.ConvertO(requestedbodyrequesterid);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterupdatedAt != null)
            {
                requesterObject["updated-at"] = ExpressionConverter.ConvertO(requestedbodyrequesterupdatedAt);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesteruserGroups != null)
            {
                requesterObject["user-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesteruserGroups);
                requesterObjectpropCount++;
            }

            if (requesterObjectpropCount > 0)
            {
                requestedbody["requester"] = requesterObject;
                requestedbodypropCount++;
            }

            var created - byObject  =  new  JObject ( );
            var created - byObjectpropCount  =  0;
            if (requestedbodyrequesteractive != null)
            {
                created - byObject["active"] = ExpressionConverter.ConvertO(requestedbodyrequesteractive);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterapprovalGroups != null)
            {
                created - byObject["approval-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesterapprovalGroups);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterbusinessGroupSecurityType != null)
            {
                created - byObject["business-group-security-type"] = ExpressionConverter.ConvertO(requestedbodyrequesterbusinessGroupSecurityType);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequestercontentGroups != null)
            {
                created - byObject["content-groups"] = ExpressionConverter.ConvertO(requestedbodyrequestercontentGroups);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequestercreatedAt != null)
            {
                created - byObject["created-at"] = ExpressionConverter.ConvertO(requestedbodyrequestercreatedAt);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesteremail != null)
            {
                created - byObject["email"] = ExpressionConverter.ConvertO(requestedbodyrequesteremail);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterlogin != null)
            {
                created - byObject["login"] = ExpressionConverter.ConvertO(requestedbodyrequesterlogin);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterfullname != null)
            {
                created - byObject["fullname"] = ExpressionConverter.ConvertO(requestedbodyrequesterfullname);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterid != null)
            {
                created - byObject["id"] = ExpressionConverter.ConvertO(requestedbodyrequesterid);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterupdatedAt != null)
            {
                created - byObject["updated-at"] = ExpressionConverter.ConvertO(requestedbodyrequesterupdatedAt);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesteruserGroups != null)
            {
                created - byObject["user-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesteruserGroups);
                created - byObjectpropCount++;
            }

            if (created - byObjectpropCount > 0)
            {
                requestedbody["created-by"] = created-byObject;
                requestedbodypropCount++;
            }

            requestedbodypropCount++;
            requestedbody["requisition-lines"] = ExpressionConverter.ConvertO(requestedbodyrequisitionLines);
            var ship - to - addressObject  =  new  JObject ( );
            var ship - to - addressObjectpropCount  =  0;
            if (requestedbodyshipToAddressname != null)
            {
                ship - to - addressObject["name"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressname);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddresslocationCode != null)
            {
                ship - to - addressObject["location-code"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresslocationCode);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressstreet1 != null)
            {
                ship - to - addressObject["street1"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressstreet1);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressstreet2 != null)
            {
                ship - to - addressObject["street2"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressstreet2);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddresscity != null)
            {
                ship - to - addressObject["city"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscity);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressstate != null)
            {
                ship - to - addressObject["state"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressstate);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddresspostalCode != null)
            {
                ship - to - addressObject["postal-code"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresspostalCode);
                ship - to - addressObjectpropCount++;
            }

            var countryObject = new JObject();
            var countryObjectpropCount = 0;
            countryObjectpropCount++;
            countryObject["code"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscountrycode);
            if (requestedbodyshipToAddresscountryid != null)
            {
                countryObject["id"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscountryid);
                countryObjectpropCount++;
            }

            if (requestedbodyshipToAddresscountryname != null)
            {
                countryObject["name"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscountryname);
                countryObjectpropCount++;
            }

            if (countryObjectpropCount > 0)
            {
                ship - to - addressObject["country"] = countryObject;
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressid != null)
            {
                ship - to - addressObject["id"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressid);
                ship - to - addressObjectpropCount++;
            }

            if (ship - to - addressObjectpropCount > 0)
            {
                requestedbody["ship-to-address"] = ship-to-addressObject;
                requestedbodypropCount++;
            }

            if (requestedbodyshipToAttention != null)
            {
                requestedbody["ship-to-attention"] = ExpressionConverter.ConvertO(requestedbodyshipToAttention);
                requestedbodypropCount++;
            }

            requestedbodypropCount++;
            requestedbody["status"] = ExpressionConverter.ConvertO(requestedbodystatus);
            if (requestedbodypropCount > 0)
            {
                callPayload.Body = requestedbody;
            }

            return new ApiConnectionAction<RequisitionHeader>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<RequisitionHeader> ReqCreate(Expression<Func<RequisitionLine[]>> requestedbodyrequisitionLines, Expression<Func<string>> requestedbodyshipToAddresscountrycode, Expression<Func<string>> requestedbodystatus, Expression<Func<Attachments[]>> requestedbodyattachments = null, Expression<Func<bool>> requestedbodyexported = null, Expression<Func<int>> requestedbodyid = null, Expression<Func<string>> requestedbodyjustification = null, Expression<Func<string>> requestedbodyneedByDate = null, Expression<Func<string>> requestedbodyreqTitle = null, Expression<Func<bool>> requestedbodyrequesteractive = null, Expression<Func<UserGroup[]>> requestedbodyrequesterapprovalGroups = null, Expression<Func<requestedbodyrequesterbusinessGroupSecurityTypeInput>> requestedbodyrequesterbusinessGroupSecurityType = null, Expression<Func<BusinessGroup[]>> requestedbodyrequestercontentGroups = null, Expression<Func<string>> requestedbodyrequestercreatedAt = null, Expression<Func<string>> requestedbodyrequesteremail = null, Expression<Func<string>> requestedbodyrequesterlogin = null, Expression<Func<string>> requestedbodyrequesterfullname = null, Expression<Func<int>> requestedbodyrequesterid = null, Expression<Func<string>> requestedbodyrequesterupdatedAt = null, Expression<Func<UserGroup[]>> requestedbodyrequesteruserGroups = null, Expression<Func<bool>> requestedbodycreatedByactive = null, Expression<Func<UserGroup[]>> requestedbodycreatedByapprovalGroups = null, Expression<Func<requestedbodycreatedBybusinessGroupSecurityTypeInput>> requestedbodycreatedBybusinessGroupSecurityType = null, Expression<Func<BusinessGroup[]>> requestedbodycreatedBycontentGroups = null, Expression<Func<string>> requestedbodycreatedBycreatedAt = null, Expression<Func<string>> requestedbodycreatedByemail = null, Expression<Func<string>> requestedbodycreatedBylogin = null, Expression<Func<string>> requestedbodycreatedByfullname = null, Expression<Func<int>> requestedbodycreatedByid = null, Expression<Func<string>> requestedbodycreatedByupdatedAt = null, Expression<Func<UserGroup[]>> requestedbodycreatedByuserGroups = null, Expression<Func<string>> requestedbodyshipToAddressname = null, Expression<Func<string>> requestedbodyshipToAddresslocationCode = null, Expression<Func<string>> requestedbodyshipToAddressstreet1 = null, Expression<Func<string>> requestedbodyshipToAddressstreet2 = null, Expression<Func<string>> requestedbodyshipToAddresscity = null, Expression<Func<string>> requestedbodyshipToAddressstate = null, Expression<Func<string>> requestedbodyshipToAddresspostalCode = null, Expression<Func<int>> requestedbodyshipToAddresscountryid = null, Expression<Func<string>> requestedbodyshipToAddresscountryname = null, Expression<Func<int>> requestedbodyshipToAddressid = null, Expression<Func<string>> requestedbodyshipToAttention = null)
        {
            var apiCallPath = "/api/requisitions/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestedbody = new JObject();
            var requestedbodypropCount = 0;
            if (requestedbodyattachments != null)
            {
                requestedbody["attachments"] = ExpressionConverter.ConvertO(requestedbodyattachments);
                requestedbodypropCount++;
            }

            if (requestedbodyexported != null)
            {
                requestedbody["exported"] = ExpressionConverter.ConvertO(requestedbodyexported);
                requestedbodypropCount++;
            }

            if (requestedbodyid != null)
            {
                requestedbody["id"] = ExpressionConverter.ConvertO(requestedbodyid);
                requestedbodypropCount++;
            }

            if (requestedbodyjustification != null)
            {
                requestedbody["justification"] = ExpressionConverter.ConvertO(requestedbodyjustification);
                requestedbodypropCount++;
            }

            if (requestedbodyneedByDate != null)
            {
                requestedbody["need-by-date"] = ExpressionConverter.ConvertO(requestedbodyneedByDate);
                requestedbodypropCount++;
            }

            if (requestedbodyreqTitle != null)
            {
                requestedbody["req-title"] = ExpressionConverter.ConvertO(requestedbodyreqTitle);
                requestedbodypropCount++;
            }

            var requesterObject = new JObject();
            var requesterObjectpropCount = 0;
            if (requestedbodyrequesteractive != null)
            {
                requesterObject["active"] = ExpressionConverter.ConvertO(requestedbodyrequesteractive);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterapprovalGroups != null)
            {
                requesterObject["approval-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesterapprovalGroups);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterbusinessGroupSecurityType != null)
            {
                requesterObject["business-group-security-type"] = ExpressionConverter.ConvertO(requestedbodyrequesterbusinessGroupSecurityType);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequestercontentGroups != null)
            {
                requesterObject["content-groups"] = ExpressionConverter.ConvertO(requestedbodyrequestercontentGroups);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequestercreatedAt != null)
            {
                requesterObject["created-at"] = ExpressionConverter.ConvertO(requestedbodyrequestercreatedAt);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesteremail != null)
            {
                requesterObject["email"] = ExpressionConverter.ConvertO(requestedbodyrequesteremail);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterlogin != null)
            {
                requesterObject["login"] = ExpressionConverter.ConvertO(requestedbodyrequesterlogin);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterfullname != null)
            {
                requesterObject["fullname"] = ExpressionConverter.ConvertO(requestedbodyrequesterfullname);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterid != null)
            {
                requesterObject["id"] = ExpressionConverter.ConvertO(requestedbodyrequesterid);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesterupdatedAt != null)
            {
                requesterObject["updated-at"] = ExpressionConverter.ConvertO(requestedbodyrequesterupdatedAt);
                requesterObjectpropCount++;
            }

            if (requestedbodyrequesteruserGroups != null)
            {
                requesterObject["user-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesteruserGroups);
                requesterObjectpropCount++;
            }

            if (requesterObjectpropCount > 0)
            {
                requestedbody["requester"] = requesterObject;
                requestedbodypropCount++;
            }

            var created - byObject  =  new  JObject ( );
            var created - byObjectpropCount  =  0;
            if (requestedbodyrequesteractive != null)
            {
                created - byObject["active"] = ExpressionConverter.ConvertO(requestedbodyrequesteractive);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterapprovalGroups != null)
            {
                created - byObject["approval-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesterapprovalGroups);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterbusinessGroupSecurityType != null)
            {
                created - byObject["business-group-security-type"] = ExpressionConverter.ConvertO(requestedbodyrequesterbusinessGroupSecurityType);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequestercontentGroups != null)
            {
                created - byObject["content-groups"] = ExpressionConverter.ConvertO(requestedbodyrequestercontentGroups);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequestercreatedAt != null)
            {
                created - byObject["created-at"] = ExpressionConverter.ConvertO(requestedbodyrequestercreatedAt);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesteremail != null)
            {
                created - byObject["email"] = ExpressionConverter.ConvertO(requestedbodyrequesteremail);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterlogin != null)
            {
                created - byObject["login"] = ExpressionConverter.ConvertO(requestedbodyrequesterlogin);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterfullname != null)
            {
                created - byObject["fullname"] = ExpressionConverter.ConvertO(requestedbodyrequesterfullname);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterid != null)
            {
                created - byObject["id"] = ExpressionConverter.ConvertO(requestedbodyrequesterid);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesterupdatedAt != null)
            {
                created - byObject["updated-at"] = ExpressionConverter.ConvertO(requestedbodyrequesterupdatedAt);
                created - byObjectpropCount++;
            }

            if (requestedbodyrequesteruserGroups != null)
            {
                created - byObject["user-groups"] = ExpressionConverter.ConvertO(requestedbodyrequesteruserGroups);
                created - byObjectpropCount++;
            }

            if (created - byObjectpropCount > 0)
            {
                requestedbody["created-by"] = created-byObject;
                requestedbodypropCount++;
            }

            requestedbodypropCount++;
            requestedbody["requisition-lines"] = ExpressionConverter.ConvertO(requestedbodyrequisitionLines);
            var ship - to - addressObject  =  new  JObject ( );
            var ship - to - addressObjectpropCount  =  0;
            if (requestedbodyshipToAddressname != null)
            {
                ship - to - addressObject["name"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressname);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddresslocationCode != null)
            {
                ship - to - addressObject["location-code"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresslocationCode);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressstreet1 != null)
            {
                ship - to - addressObject["street1"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressstreet1);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressstreet2 != null)
            {
                ship - to - addressObject["street2"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressstreet2);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddresscity != null)
            {
                ship - to - addressObject["city"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscity);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressstate != null)
            {
                ship - to - addressObject["state"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressstate);
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddresspostalCode != null)
            {
                ship - to - addressObject["postal-code"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresspostalCode);
                ship - to - addressObjectpropCount++;
            }

            var countryObject = new JObject();
            var countryObjectpropCount = 0;
            countryObjectpropCount++;
            countryObject["code"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscountrycode);
            if (requestedbodyshipToAddresscountryid != null)
            {
                countryObject["id"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscountryid);
                countryObjectpropCount++;
            }

            if (requestedbodyshipToAddresscountryname != null)
            {
                countryObject["name"] = ExpressionConverter.ConvertO(requestedbodyshipToAddresscountryname);
                countryObjectpropCount++;
            }

            if (countryObjectpropCount > 0)
            {
                ship - to - addressObject["country"] = countryObject;
                ship - to - addressObjectpropCount++;
            }

            if (requestedbodyshipToAddressid != null)
            {
                ship - to - addressObject["id"] = ExpressionConverter.ConvertO(requestedbodyshipToAddressid);
                ship - to - addressObjectpropCount++;
            }

            if (ship - to - addressObjectpropCount > 0)
            {
                requestedbody["ship-to-address"] = ship-to-addressObject;
                requestedbodypropCount++;
            }

            if (requestedbodyshipToAttention != null)
            {
                requestedbody["ship-to-attention"] = ExpressionConverter.ConvertO(requestedbodyshipToAttention);
                requestedbodypropCount++;
            }

            requestedbodypropCount++;
            requestedbody["status"] = ExpressionConverter.ConvertO(requestedbodystatus);
            if (requestedbodypropCount > 0)
            {
                callPayload.Body = requestedbody;
            }

            return new ApiConnectionAction<RequisitionHeader>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Item> ItemsGetbyId(Expression<Func<string>> id, Expression<Func<returnObjectInput>> returnObject = null)
        {
            var apiCallPath = String.Format("/api/items/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Item[]> ItemsQuery(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/items";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<Item[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Item> ItemsCreate(Expression<Func<string>> bodycommodityname, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyitemNumber = null, Expression<Func<bool>> bodyactive = null, Expression<Func<bool>> bodycommodityactive = null, Expression<Func<string>> bodycommoditycreatedAt = null, Expression<Func<int>> bodycommodityid = null, Expression<Func<string>> bodycommodityupdatedAt = null, Expression<Func<string>> bodyuomname = null, Expression<Func<string>> bodyuomcode = null, Expression<Func<bool>> bodyuomactive = null, Expression<Func<int>> bodyuomid = null, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodyimageUrl = null)
        {
            var apiCallPath = "/api/items";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyitemNumber != null)
            {
                body["item-number"] = ExpressionConverter.ConvertO(bodyitemNumber);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            var commodityObject = new JObject();
            var commodityObjectpropCount = 0;
            if (bodycommodityactive != null)
            {
                commodityObject["active"] = ExpressionConverter.ConvertO(bodycommodityactive);
                commodityObjectpropCount++;
            }

            if (bodycommoditycreatedAt != null)
            {
                commodityObject["created-at"] = ExpressionConverter.ConvertO(bodycommoditycreatedAt);
                commodityObjectpropCount++;
            }

            if (bodycommodityid != null)
            {
                commodityObject["id"] = ExpressionConverter.ConvertO(bodycommodityid);
                commodityObjectpropCount++;
            }

            commodityObjectpropCount++;
            commodityObject["name"] = ExpressionConverter.ConvertO(bodycommodityname);
            if (bodycommodityupdatedAt != null)
            {
                commodityObject["updated-at"] = ExpressionConverter.ConvertO(bodycommodityupdatedAt);
                commodityObjectpropCount++;
            }

            if (commodityObjectpropCount > 0)
            {
                body["commodity"] = commodityObject;
                bodypropCount++;
            }

            var uomObject = new JObject();
            var uomObjectpropCount = 0;
            if (bodyuomname != null)
            {
                uomObject["name"] = ExpressionConverter.ConvertO(bodyuomname);
                uomObjectpropCount++;
            }

            if (bodyuomcode != null)
            {
                uomObject["code"] = ExpressionConverter.ConvertO(bodyuomcode);
                uomObjectpropCount++;
            }

            if (bodyuomactive != null)
            {
                uomObject["active"] = ExpressionConverter.ConvertO(bodyuomactive);
                uomObjectpropCount++;
            }

            if (bodyuomid != null)
            {
                uomObject["id"] = ExpressionConverter.ConvertO(bodyuomid);
                uomObjectpropCount++;
            }

            if (uomObjectpropCount > 0)
            {
                body["uom"] = uomObject;
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodyimageUrl != null)
            {
                body["image-url"] = ExpressionConverter.ConvertO(bodyimageUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Item>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<SupplierItem> SupplierItemsGetById(Expression<Func<string>> id, Expression<Func<int>> offset = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<dirInput>> dir = null)
        {
            var apiCallPath = String.Format("/api/supplier_items/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            return new ApiConnectionAction<SupplierItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<CommentsInfo> CommentsPOCreate(Expression<Func<string>> poId, Expression<Func<int>> bodycommentableId = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}/comments", ExpressionConverter.ConvertWithUrlEncoding(poId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycommentableId != null)
            {
                body["commentable-id"] = ExpressionConverter.ConvertO(bodycommentableId);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommentsInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachments> AttachmentsComment(Expression<Func<string>> id, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodytype = null, Expression<Func<bodyintentInput>> bodyintent = null, Expression<Func<string>> bodyurl = null)
        {
            var apiCallPath = String.Format("/api/comments/{0}/attachments/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyintent != null)
            {
                body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Attachments>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachments[]> AttachmentsPoGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}/attachments/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Attachments[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Attachments> AttachmentsPo(Expression<Func<string>> id, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodytype = null, Expression<Func<bodyintentInput>> bodyintent = null, Expression<Func<string>> bodyurl = null)
        {
            var apiCallPath = String.Format("/api/purchase_orders/{0}/attachments/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyintent != null)
            {
                body["intent"] = ExpressionConverter.ConvertO(bodyintent);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Attachments>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Address> AddressGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Address>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Address> AddressUpdate(Expression<Func<string>> id, Expression<Func<string>> bodycountrycode, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylocationCode = null, Expression<Func<string>> bodystreet1 = null, Expression<Func<string>> bodystreet2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<int>> bodycountryid = null, Expression<Func<string>> bodycountryname = null, Expression<Func<int>> bodyid = null)
        {
            var apiCallPath = String.Format("/api/addresses/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylocationCode != null)
            {
                body["location-code"] = ExpressionConverter.ConvertO(bodylocationCode);
                bodypropCount++;
            }

            if (bodystreet1 != null)
            {
                body["street1"] = ExpressionConverter.ConvertO(bodystreet1);
                bodypropCount++;
            }

            if (bodystreet2 != null)
            {
                body["street2"] = ExpressionConverter.ConvertO(bodystreet2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postal-code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            var countryObject = new JObject();
            var countryObjectpropCount = 0;
            countryObjectpropCount++;
            countryObject["code"] = ExpressionConverter.ConvertO(bodycountrycode);
            if (bodycountryid != null)
            {
                countryObject["id"] = ExpressionConverter.ConvertO(bodycountryid);
                countryObjectpropCount++;
            }

            if (bodycountryname != null)
            {
                countryObject["name"] = ExpressionConverter.ConvertO(bodycountryname);
                countryObjectpropCount++;
            }

            if (countryObjectpropCount > 0)
            {
                body["country"] = countryObject;
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Address>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Address[]> AddressQuery(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null)
        {
            var apiCallPath = "/api/addresses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            return new ApiConnectionAction<Address[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Address> AddressCreate(Expression<Func<string>> bodycountrycode, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodylocationCode = null, Expression<Func<string>> bodystreet1 = null, Expression<Func<string>> bodystreet2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<int>> bodycountryid = null, Expression<Func<string>> bodycountryname = null, Expression<Func<int>> bodyid = null)
        {
            var apiCallPath = "/api/addresses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodylocationCode != null)
            {
                body["location-code"] = ExpressionConverter.ConvertO(bodylocationCode);
                bodypropCount++;
            }

            if (bodystreet1 != null)
            {
                body["street1"] = ExpressionConverter.ConvertO(bodystreet1);
                bodypropCount++;
            }

            if (bodystreet2 != null)
            {
                body["street2"] = ExpressionConverter.ConvertO(bodystreet2);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postal-code"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            var countryObject = new JObject();
            var countryObjectpropCount = 0;
            countryObjectpropCount++;
            countryObject["code"] = ExpressionConverter.ConvertO(bodycountrycode);
            if (bodycountryid != null)
            {
                countryObject["id"] = ExpressionConverter.ConvertO(bodycountryid);
                countryObjectpropCount++;
            }

            if (bodycountryname != null)
            {
                countryObject["name"] = ExpressionConverter.ConvertO(bodycountryname);
                countryObjectpropCount++;
            }

            if (countryObjectpropCount > 0)
            {
                body["country"] = countryObject;
                bodypropCount++;
            }

            if (bodyid != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Address>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Integration[]> IntegrationsQuery(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/integrations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<Integration[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Supplier[]> SuppliersGet(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/suppliers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<Supplier[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<IntegrationRun> IntegrationRunGet(Expression<Func<int>> id, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/api/integration_runs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<IntegrationRun>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<IntegrationError[]> IntegrationErrorsQuery(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/integration_errors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<IntegrationError[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<IntegrationRun[]> IntegrationRunsQuery(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/integration_runs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<IntegrationRun[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<UserSimple[]> UsersQuery(Expression<Func<string>> login = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (login != null)
                callPayload.Queries["login"] = ExpressionConverter.Convert(login);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<UserSimple[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<Lookup[]> LookupQuery(Expression<Func<string>> name = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/lookups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<Lookup[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "coupaip")]
        public IBodyWorkflowAction<LookupValue[]> LookupValuesQuery(Expression<Func<string>> lookupName = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> orderBy = null, Expression<Func<dirInput>> dir = null, Expression<Func<returnObjectInput>> returnObject = null, Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/api/lookup_values";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lookupName != null)
                callPayload.Queries["lookup[name]"] = ExpressionConverter.Convert(lookupName);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orderBy != null)
                callPayload.Queries["order_by"] = ExpressionConverter.Convert(orderBy);
            if (dir != null)
                callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
            if (returnObject != null)
                callPayload.Queries["return_object"] = ExpressionConverter.Convert(returnObject);
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<LookupValue[]>(callPayload);
        }
    }

    public class CoupaipTriggers([ConnectionName] string connectionId)
    {
    }

    public class OrderPad
    {
        [JsonProperty("add-all-items")]
        public string AddAllItems { get; set; }

        [JsonProperty("any-supplier")]
        public string AnySupplier { get; set; }

        [JsonProperty("base-value")]
        public JToken BaseValue { get; set; }

        [JsonProperty("base-value-currency")]
        public Currency BaseValueCurrency { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order-pad-lines")]
        public OrderPadLine[] OrderPadLines { get; set; }
    }

    public class Currency
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("enabled")]
        public string Enabled { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OrderPadLine
    {
        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("order-amount-method")]
        public OrderPadLineOrderAmountMethodType OrderAmountMethod { get; set; }

        [JsonProperty("supplier-id")]
        public int SupplierId { get; set; }

        [JsonProperty("par-level")]
        public double ParLevel { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item-number")]
        public string ItemNumber { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("commodity")]
        public Commodity Commodity { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image-url")]
        public string ImageUrl { get; set; }
    }

    public class Commodity
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public class Uom
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public enum OrderPadLineOrderAmountMethodType
    {
        [EnumMember(Value = "amount")]
        Amount,
        [EnumMember(Value = "par")]
        Par
    }

    public enum dirInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public enum returnObjectInput
    {
        [EnumMember(Value = "limited")]
        Limited,
        [EnumMember(Value = "shallow")]
        Shallow,
        [EnumMember(Value = "none")]
        None
    }

    public class Invoices
    {
        [JsonProperty("invoice-date")]
        public string InvoiceDate { get; set; }

        [JsonProperty("invoice-number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("line-level-taxation")]
        public bool LineLevelTaxation { get; set; }

        [JsonProperty("total-with-taxes")]
        public string TotalWithTaxes { get; set; }

        [JsonProperty("document-type")]
        public string DocumentType { get; set; }

        [JsonProperty("requested-by")]
        public InvoicesRequestedByType RequestedBy { get; set; }

        [JsonProperty("account-type")]
        public AccountType AccountType { get; set; }

        [JsonProperty("currency")]
        public InvoicesCurrencyType Currency { get; set; }

        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }

        [JsonProperty("ship-to-address")]
        public string LocationCode { get; set; }

        [JsonProperty("invoice-lines")]
        public InvoicesInvoiceLinesTypeItem[] InvoiceLines { get; set; }
    }

    public class InvoicesRequestedByType
    {
        [JsonProperty("login")]
        public string Login { get; set; }
    }

    public class AccountType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InvoicesCurrencyType
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class Supplier
    {
        [JsonProperty("account-number")]
        public string AccountNumber { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("display-name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class InvoicesInvoiceLinesTypeItem
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("accounting-total")]
        public string AccountingTotal { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("line-num")]
        public int LineNum { get; set; }

        [JsonProperty("id")]
        public int LineId { get; set; }

        [JsonProperty("order-header-num")]
        public int OrderHeaderNum { get; set; }

        [JsonProperty("po-number")]
        public string PoNumber { get; set; }

        [JsonProperty("order-line-num")]
        public string OrderLineNum { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("type")]
        public InvoicesInvoiceLinesTypeItemTypeType Type { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }
    }

    public class Account
    {
        [JsonProperty("account-type")]
        public AccountType AccountType { get; set; }

        [JsonProperty("account-type-id")]
        public int AccountTypeId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("created-by")]
        public UserSimple CreatedBy { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("segment-1")]
        public string Segment1 { get; set; }

        [JsonProperty("segment-2")]
        public string Segment2 { get; set; }

        [JsonProperty("segment-3")]
        public string Segment3 { get; set; }

        [JsonProperty("segment-4")]
        public string Segment4 { get; set; }

        [JsonProperty("segment-5")]
        public string Segment5 { get; set; }

        [JsonProperty("segment-6")]
        public string Segment6 { get; set; }

        [JsonProperty("updated-by")]
        public UserSimple UpdatedBy { get; set; }
    }

    public class UserSimple
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("approval-groups")]
        public UserGroup[] ApprovalGroups { get; set; }

        [JsonProperty("business-group-security-type")]
        public UserSimpleBusinessGroupSecurityTypeType BusinessGroupSecurityType { get; set; }

        [JsonProperty("content-groups")]
        public BusinessGroup[] ContentGroups { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("user-groups")]
        public UserGroup[] UserGroups { get; set; }
    }

    public class UserGroup
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("can-approve")]
        public bool CanApprove { get; set; }

        [JsonProperty("content-groups")]
        public BusinessGroup[] ContentGroups { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class BusinessGroup
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public enum UserSimpleBusinessGroupSecurityTypeType
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum InvoicesInvoiceLinesTypeItemTypeType
    {
        InvoiceQuantityLine,
        InvoiceAmountLine
    }

    public class Contract
    {
        [JsonProperty("contract-terms")]
        public ContractTerm[] ContractTerms { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("end-date")]
        public string EndDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("maximum-value")]
        public string MaximumValue { get; set; }

        [JsonProperty("minimum-value")]
        public string MinimumValue { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("start-date")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }

        [JsonProperty("supplier-account")]
        public string SupplierAccount { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class ContractTerm
    {
        [JsonProperty("contract-term-type")]
        public ContractTermContractTermTypeType ContractTermType { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tier-1-disc-pct")]
        public string Tier1DiscPct { get; set; }

        [JsonProperty("tier-1-upper-bound")]
        public string Tier1UpperBound { get; set; }

        [JsonProperty("tier-2-disc-pct")]
        public string Tier2DiscPct { get; set; }

        [JsonProperty("tier-2-upper-bound")]
        public string Tier2UpperBound { get; set; }

        [JsonProperty("tier-3-disc-pct")]
        public string Tier3DiscPct { get; set; }

        [JsonProperty("tier-3-upper-bound")]
        public string Tier3UpperBound { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("use-pct-discounts")]
        public string UsePctDiscounts { get; set; }
    }

    public enum ContractTermContractTermTypeType
    {
        PerOrderContractTerm,
        TotalQtyContractTerm,
        TotalAmtContractTerm,
        PriceRangeContractTerm
    }

    public enum statusInput
    {
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "new")]
        New,
        [EnumMember(Value = "on_hold")]
        OnHold,
        [EnumMember(Value = "pending_action")]
        PendingAction,
        [EnumMember(Value = "pending_approval")]
        PendingApproval,
        [EnumMember(Value = "pending_receipt")]
        PendingReceipt
    }

    public class requestedbodyinvoiceLinesInputItem
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("accounting-total")]
        public string AccountingTotal { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("line-num")]
        public int LineNum { get; set; }

        [JsonProperty("id")]
        public int LineId { get; set; }

        [JsonProperty("order-header-num")]
        public int OrderHeaderNum { get; set; }

        [JsonProperty("po-number")]
        public string PoNumber { get; set; }

        [JsonProperty("order-line-num")]
        public string OrderLineNum { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("type")]
        public requestedbodyinvoiceLinesInputItemTypeType Type { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }
    }

    public enum requestedbodyinvoiceLinesInputItemTypeType
    {
        InvoiceQuantityLine,
        InvoiceAmountLine
    }

    public class requestedbodyinvoiceLinesInputItem2
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("accounting-total")]
        public string AccountingTotal { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("line-num")]
        public int LineNum { get; set; }

        [JsonProperty("id")]
        public int LineId { get; set; }

        [JsonProperty("order-header-num")]
        public int OrderHeaderNum { get; set; }

        [JsonProperty("po-number")]
        public string PoNumber { get; set; }

        [JsonProperty("order-line-num")]
        public string OrderLineNum { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("type")]
        public requestedbodyinvoiceLinesInputItemTypeType Type { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }
    }

    public class InventoryTransaction
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("attachments")]
        public Attachments[] Attachments { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("order-line")]
        public OrderLine OrderLine { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("receipt")]
        public Receipt Receipt { get; set; }

        [JsonProperty("requester")]
        public UserSimple Requester { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("transaction-date")]
        public string TransactionDate { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public class Attachments
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("intent")]
        public AttachmentsIntentType Intent { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum AttachmentsIntentType
    {
        Internal,
        Supplier
    }

    public class OrderLine
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("accounting-total")]
        public double AccountingTotal { get; set; }

        [JsonProperty("attachments")]
        public Attachments[] Attachments { get; set; }

        [JsonProperty("commodity")]
        public Commodity Commodity { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("invoiced")]
        public double Invoiced { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("line-num")]
        public string LineNum { get; set; }

        [JsonProperty("order-header-id")]
        public int OrderHeaderId { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("received")]
        public string Received { get; set; }

        [JsonProperty("requester")]
        public UserSimple Requester { get; set; }

        [JsonProperty("source-part-num")]
        public string SourcePartNum { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }
    }

    public class Receipt
    {
        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("receipt-date")]
        public string ReceiptDate { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("unit-price")]
        public double UnitPrice { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public enum bodytypeInput
    {
        ReceivingQuantityConsumption,
        ReceivingAmountConsumption,
        ReceivingQuantityDisposal,
        ReceivingAmountDisposal,
        ReceivingQuantityReturnToSupplier,
        ReceivingAmountReturnToSupplier,
        InventoryReceipt,
        VoidReceivingQuantityConsumption,
        VoidReceivingAmountConsumption,
        VoidReceivingQuantityDisposal,
        VoidReceivingAmountDisposal,
        VoidReceivingQuantityReturnToSupplier,
        VoidReceivingAmountReturnToSupplier,
        VoidInventoryReceipt
    }

    public enum bodycontractTermTypeInput
    {
        PerOrderContractTerm,
        TotalQtyContractTerm,
        TotalAmtContractTerm,
        PriceRangeContractTerm
    }

    public class RequisitionHeader
    {
        [JsonProperty("attachments")]
        public Attachments[] Attachments { get; set; }

        [JsonProperty("exported")]
        public bool Exported { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("justification")]
        public string Justification { get; set; }

        [JsonProperty("need-by-date")]
        public string NeedByDate { get; set; }

        [JsonProperty("req-title")]
        public string ReqTitle { get; set; }

        [JsonProperty("requester")]
        public UserSimple Requester { get; set; }

        [JsonProperty("created-by")]
        public UserSimple CreatedBy { get; set; }

        [JsonProperty("requisition-lines")]
        public RequisitionLine[] RequisitionLines { get; set; }

        [JsonProperty("ship-to-address")]
        public Address ShipToAddress { get; set; }

        [JsonProperty("ship-to-attention")]
        public string ShipToAttention { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class RequisitionLine
    {
        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("attachments")]
        public Attachments[] Attachments { get; set; }

        [JsonProperty("commodity")]
        public Commodity Commodity { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("form-response")]
        public FormResponse FormResponse { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image-url")]
        public string ImageUrl { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("line-num")]
        public int LineNum { get; set; }

        [JsonProperty("line-owner")]
        public UserSimple LineOwner { get; set; }

        [JsonProperty("line-type")]
        public RequisitionLineLineTypeType LineType { get; set; }

        [JsonProperty("order-line-id")]
        public int OrderLineId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("transmission-emails")]
        public string TransmissionEmails { get; set; }

        [JsonProperty("transmission-method-override")]
        public RequisitionLineTransmissionMethodOverrideType TransmissionMethodOverride { get; set; }

        [JsonProperty("unit-price")]
        public double UnitPrice { get; set; }

        [JsonProperty("uom")]
        public Uom Uom { get; set; }
    }

    public class FormResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public enum RequisitionLineLineTypeType
    {
        RequisitionQuantityLine,
        RequisitionAmountLine
    }

    public enum RequisitionLineTransmissionMethodOverrideType
    {
        [EnumMember(Value = "supplier_default")]
        SupplierDefault,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "do_not_transmit")]
        DoNotTransmit
    }

    public class Address
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location-code")]
        public string LocationCode { get; set; }

        [JsonProperty("street1")]
        public string Street1 { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal-code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class Country
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum bodyrequesterbusinessGroupSecurityTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum bodycreatedBybusinessGroupSecurityTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public class PurchaseOrder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ship-to-attention")]
        public string ShipToAttention { get; set; }

        [JsonProperty("ship-to-address")]
        public PurchaseOrderShipToAddressType ShipToAddress { get; set; }

        [JsonProperty("order-lines")]
        public OrderLine[] OrderLines { get; set; }
    }

    public class PurchaseOrderShipToAddressType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum requestedbodyrequesterbusinessGroupSecurityTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public enum requestedbodycreatedBybusinessGroupSecurityTypeInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1
    }

    public class SupplierItem
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("currency")]
        public Currency Currency { get; set; }

        [JsonProperty("contract")]
        public Contract Contract { get; set; }

        [JsonProperty("contract-term")]
        public ContractTerm ContractTerm { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("lead-time")]
        public int LeadTime { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("minimum-order-quantity")]
        public string MinimumOrderQuantity { get; set; }

        [JsonProperty("order-increment")]
        public string OrderIncrement { get; set; }

        [JsonProperty("price-tier-1")]
        public string PriceTier1 { get; set; }

        [JsonProperty("price-tier-2")]
        public string PriceTier2 { get; set; }

        [JsonProperty("price-tier-3")]
        public string PriceTier3 { get; set; }

        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }

        [JsonProperty("preferred")]
        public bool Preferred { get; set; }

        [JsonProperty("supplier-aux-part-num")]
        public string SupplierAuxPartNum { get; set; }

        [JsonProperty("supplier-part-num")]
        public string SupplierPartNum { get; set; }

        [JsonProperty("unspsc-code")]
        public string UnspscCode { get; set; }
    }

    public class CommentsInfo
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("commentable-id")]
        public int CommentableId { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public enum bodyintentInput
    {
        Internal,
        Supplier
    }

    public class Integration
    {
        [JsonProperty("business-object")]
        public string BusinessObject { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("created-at")]
        public string CreatedAt { get; set; }

        [JsonProperty("direction")]
        public IntegrationDirectionType Direction { get; set; }

        [JsonProperty("end-system")]
        public string EndSystem { get; set; }

        [JsonProperty("end-system-type")]
        public IntegrationEndSystemTypeType EndSystemType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("standard")]
        public bool Standard { get; set; }
    }

    public enum IntegrationDirectionType
    {
        [EnumMember(Value = "to_coupa")]
        ToCoupa,
        [EnumMember(Value = "from_coupa")]
        FromCoupa
    }

    public enum IntegrationEndSystemTypeType
    {
        [EnumMember(Value = "payroll")]
        Payroll,
        [EnumMember(Value = "erp")]
        Erp,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "third_party_partner")]
        ThirdPartyPartner,
        [EnumMember(Value = "third_party_vendor")]
        ThirdPartyVendor,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "internal")]
        Internal
    }

    public class IntegrationRun
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("integration")]
        public Integration Integration { get; set; }

        [JsonProperty("integration-errors")]
        public IntegrationError[] IntegrationErrors { get; set; }

        [JsonProperty("records-processed")]
        public int RecordsProcessed { get; set; }

        [JsonProperty("start-time")]
        public string StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("total-records")]
        public int TotalRecords { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }
    }

    public class IntegrationError
    {
        [JsonProperty("contact-alert-type")]
        public string ContactAlertType { get; set; }

        [JsonProperty("created-by")]
        public UserSimple CreatedBy { get; set; }

        [JsonProperty("creation-method")]
        public string CreationMethod { get; set; }

        [JsonProperty("document-id")]
        public int DocumentId { get; set; }

        [JsonProperty("document-status")]
        public string DocumentStatus { get; set; }

        [JsonProperty("document-type")]
        public IntegrationErrorDocumentTypeType DocumentType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("integration-filename")]
        public string IntegrationFilename { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated-at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updated-by")]
        public UserSimple UpdatedBy { get; set; }
    }

    public enum IntegrationErrorDocumentTypeType
    {
        ContingentWorkOrderHeader,
        ExternalOrderHeader,
        OrderHeader,
        InventoryTransaction,
        InvoiceHeader,
        ExpenseReport,
        RequisitionHeader,
        Account,
        Supplier,
        User,
        Address,
        RemitToAddress,
        Contract,
        ExchangeRate,
        Invoice,
        Requisition,
        Payment,
        ApprovalChain,
        LookupValue,
        Item,
        SupplierInformation,
        [EnumMember(Value = "Asn::Header")]
        AsnHeader,
        AccountValidationRule,
        [EnumMember(Value = "Payables::External::Payable")]
        PayablesExternalPayable,
        Charge,
        [EnumMember(Value = "Payables::Invoice")]
        PayablesInvoice,
        [EnumMember(Value = "Payables::Expense")]
        PayablesExpense,
        [EnumMember(Value = "CoupaPay::Payment")]
        CoupaPayPayment,
        [EnumMember(Value = "CoupaPay::Statement")]
        CoupaPayStatement
    }

    public class Lookup
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("level-1-name")]
        public string Level1Name { get; set; }

        [JsonProperty("level-2-name")]
        public string Level2Name { get; set; }

        [JsonProperty("level-3-name")]
        public string Level3Name { get; set; }

        [JsonProperty("level-4-name")]
        public string Level4Name { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LookupValue
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("external-ref-num")]
        public string ExternalRefNum { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is-default")]
        public bool IsDefault { get; set; }

        [JsonProperty("lookup")]
        public Lookup Lookup { get; set; }

        [JsonProperty("lookup-id")]
        public int LookupId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Coupaip;

    public partial class WorkflowManagedActions
    {
        public CoupaipActions Coupaip(string connectionId) => new CoupaipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CoupaipTriggers Coupaip(string connectionId) => new CoupaipTriggers(connectionId);
    }
}