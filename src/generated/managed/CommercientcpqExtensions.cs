//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commercientcpq
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommercientcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> SAGE100CreateNewCustomer(Expression<Func<string>> bodyARDivisionNo = null, Expression<Func<string>> bodyAddressLine1 = null, Expression<Func<string>> bodyAddressLine2 = null, Expression<Func<string>> bodyAddressLine3 = null, Expression<Func<bool>> bodyBatchFax = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyComment = null, Expression<Func<string>> bodyContactCode = null, Expression<Func<string>> bodyCountryCode = null, Expression<Func<bool>> bodyCreditHold = null, Expression<Func<int>> bodyCreditLimit = null, Expression<Func<int>> bodyCustomerDiscountRate = null, Expression<Func<string>> bodyCustomerName = null, Expression<Func<string>> bodyCustomerNo = null, Expression<Func<string>> bodyCustomerType = null, Expression<Func<string>> bodyDefaultCreditCardPmtType = null, Expression<Func<string>> bodyDefaultItemCode = null, Expression<Func<string>> bodyDefaultPaymentType = null, Expression<Func<string>> bodyEmailAddress = null, Expression<Func<string>> bodyFaxNo = null, Expression<Func<bool>> bodyOpenItemCustomer = null, Expression<Func<string>> bodyPriceLevel = null, Expression<Func<string>> bodyPrimaryShipToCode = null, Expression<Func<bool>> bodyPrintDunningMessage = null, Expression<Func<bool>> bodyResidentialAddress = null, Expression<Func<string>> bodySalespersonNo = null, Expression<Func<string>> bodyShipMethod = null, Expression<Func<string>> bodyState = null, Expression<Func<string>> bodyStatementCycle = null, Expression<Func<string>> bodyTaxExemptNo = null, Expression<Func<string>> bodyTaxSchedule = null, Expression<Func<string>> bodyTelephoneExt = null, Expression<Func<string>> bodyTelephoneNo = null, Expression<Func<string>> bodyTermsCode = null, Expression<Func<string>> bodyURLAddress = null, Expression<Func<string>> bodyZipCode = null)
        {
            var apiCallPath = "/api/v1/SAGE100/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyARDivisionNo != null)
            {
                body["ARDivisionNo"] = ExpressionConverter.ConvertO(bodyARDivisionNo);
                bodypropCount++;
            }

            if (bodyAddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyAddressLine1);
                bodypropCount++;
            }

            if (bodyAddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyAddressLine2);
                bodypropCount++;
            }

            if (bodyAddressLine3 != null)
            {
                body["AddressLine3"] = ExpressionConverter.ConvertO(bodyAddressLine3);
                bodypropCount++;
            }

            if (bodyBatchFax != null)
            {
                body["BatchFax"] = ExpressionConverter.ConvertO(bodyBatchFax);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyComment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
                bodypropCount++;
            }

            if (bodyContactCode != null)
            {
                body["ContactCode"] = ExpressionConverter.ConvertO(bodyContactCode);
                bodypropCount++;
            }

            if (bodyCountryCode != null)
            {
                body["CountryCode"] = ExpressionConverter.ConvertO(bodyCountryCode);
                bodypropCount++;
            }

            if (bodyCreditHold != null)
            {
                body["CreditHold"] = ExpressionConverter.ConvertO(bodyCreditHold);
                bodypropCount++;
            }

            if (bodyCreditLimit != null)
            {
                body["CreditLimit"] = ExpressionConverter.ConvertO(bodyCreditLimit);
                bodypropCount++;
            }

            if (bodyCustomerDiscountRate != null)
            {
                body["CustomerDiscountRate"] = ExpressionConverter.ConvertO(bodyCustomerDiscountRate);
                bodypropCount++;
            }

            if (bodyCustomerName != null)
            {
                body["CustomerName"] = ExpressionConverter.ConvertO(bodyCustomerName);
                bodypropCount++;
            }

            if (bodyCustomerNo != null)
            {
                body["CustomerNo"] = ExpressionConverter.ConvertO(bodyCustomerNo);
                bodypropCount++;
            }

            if (bodyCustomerType != null)
            {
                body["CustomerType"] = ExpressionConverter.ConvertO(bodyCustomerType);
                bodypropCount++;
            }

            if (bodyDefaultCreditCardPmtType != null)
            {
                body["DefaultCreditCardPmtType"] = ExpressionConverter.ConvertO(bodyDefaultCreditCardPmtType);
                bodypropCount++;
            }

            if (bodyDefaultItemCode != null)
            {
                body["DefaultItemCode"] = ExpressionConverter.ConvertO(bodyDefaultItemCode);
                bodypropCount++;
            }

            if (bodyDefaultPaymentType != null)
            {
                body["DefaultPaymentType"] = ExpressionConverter.ConvertO(bodyDefaultPaymentType);
                bodypropCount++;
            }

            if (bodyEmailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyEmailAddress);
                bodypropCount++;
            }

            if (bodyFaxNo != null)
            {
                body["FaxNo"] = ExpressionConverter.ConvertO(bodyFaxNo);
                bodypropCount++;
            }

            if (bodyOpenItemCustomer != null)
            {
                body["OpenItemCustomer"] = ExpressionConverter.ConvertO(bodyOpenItemCustomer);
                bodypropCount++;
            }

            if (bodyPriceLevel != null)
            {
                body["PriceLevel"] = ExpressionConverter.ConvertO(bodyPriceLevel);
                bodypropCount++;
            }

            if (bodyPrimaryShipToCode != null)
            {
                body["PrimaryShipToCode"] = ExpressionConverter.ConvertO(bodyPrimaryShipToCode);
                bodypropCount++;
            }

            if (bodyPrintDunningMessage != null)
            {
                body["PrintDunningMessage"] = ExpressionConverter.ConvertO(bodyPrintDunningMessage);
                bodypropCount++;
            }

            if (bodyResidentialAddress != null)
            {
                body["ResidentialAddress"] = ExpressionConverter.ConvertO(bodyResidentialAddress);
                bodypropCount++;
            }

            if (bodySalespersonNo != null)
            {
                body["SalespersonNo"] = ExpressionConverter.ConvertO(bodySalespersonNo);
                bodypropCount++;
            }

            if (bodyShipMethod != null)
            {
                body["ShipMethod"] = ExpressionConverter.ConvertO(bodyShipMethod);
                bodypropCount++;
            }

            if (bodyState != null)
            {
                body["State"] = ExpressionConverter.ConvertO(bodyState);
                bodypropCount++;
            }

            if (bodyStatementCycle != null)
            {
                body["StatementCycle"] = ExpressionConverter.ConvertO(bodyStatementCycle);
                bodypropCount++;
            }

            if (bodyTaxExemptNo != null)
            {
                body["TaxExemptNo"] = ExpressionConverter.ConvertO(bodyTaxExemptNo);
                bodypropCount++;
            }

            if (bodyTaxSchedule != null)
            {
                body["TaxSchedule"] = ExpressionConverter.ConvertO(bodyTaxSchedule);
                bodypropCount++;
            }

            if (bodyTelephoneExt != null)
            {
                body["TelephoneExt"] = ExpressionConverter.ConvertO(bodyTelephoneExt);
                bodypropCount++;
            }

            if (bodyTelephoneNo != null)
            {
                body["TelephoneNo"] = ExpressionConverter.ConvertO(bodyTelephoneNo);
                bodypropCount++;
            }

            if (bodyTermsCode != null)
            {
                body["TermsCode"] = ExpressionConverter.ConvertO(bodyTermsCode);
                bodypropCount++;
            }

            if (bodyURLAddress != null)
            {
                body["URLAddress"] = ExpressionConverter.ConvertO(bodyURLAddress);
                bodypropCount++;
            }

            if (bodyZipCode != null)
            {
                body["ZipCode"] = ExpressionConverter.ConvertO(bodyZipCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE100CreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> SAGE100CreateNewSalesOrder(Expression<Func<string>> bodyARDivisionNo = null, Expression<Func<bool>> bodyBatchFax = null, Expression<Func<string>> bodyBillToAddress1 = null, Expression<Func<string>> bodyBillToAddress2 = null, Expression<Func<string>> bodyBillToAddress3 = null, Expression<Func<string>> bodyBillToCity = null, Expression<Func<string>> bodyBillToCountryCode = null, Expression<Func<string>> bodyBillToName = null, Expression<Func<string>> bodyBillToState = null, Expression<Func<string>> bodyBillToZipCode = null, Expression<Func<string>> bodyComment = null, Expression<Func<string>> bodyConfirmTo = null, Expression<Func<string>> bodyCustomerNo = null, Expression<Func<string>> bodyCustomerPONo = null, Expression<Func<string>> bodyCycleCode = null, Expression<Func<string>> bodyEmailAddress = null, Expression<Func<string>> bodyFOB = null, Expression<Func<string>> bodyFaxNo = null, Expression<Func<string>> bodyMasterRepeatingOrderNo = null, Expression<Func<int>> bodyNumberOfShippingLabels = null, Expression<Func<string>> bodyOrderDate = null, Expression<Func<string>> bodyOrderStatus = null, Expression<Func<string>> bodyOrderType = null, Expression<Func<bool>> bodyPrintPickingSheets = null, Expression<Func<bool>> bodyPrintSalesOrders = null, Expression<Func<bodySalesOrderLineItemInputItem[]>> bodySalesOrderLineItem = null, Expression<Func<string>> bodySalesOrderNo = null, Expression<Func<string>> bodySalespersonNo = null, Expression<Func<string>> bodyShipExpireDate = null, Expression<Func<string>> bodyShipToAddress1 = null, Expression<Func<string>> bodyShipToAddress2 = null, Expression<Func<string>> bodyShipToAddress3 = null, Expression<Func<string>> bodyShipToCity = null, Expression<Func<string>> bodyShipToCode = null, Expression<Func<string>> bodyShipToCountryCode = null, Expression<Func<string>> bodyShipToName = null, Expression<Func<string>> bodyShipToState = null, Expression<Func<string>> bodyShipToZipCode = null, Expression<Func<string>> bodyShipVia = null, Expression<Func<int>> bodyShipWeight = null, Expression<Func<string>> bodyShipZoneActual = null, Expression<Func<string>> bodySplitCommissions = null, Expression<Func<string>> bodyTaxExemptNo = null, Expression<Func<string>> bodyTaxSchedule = null, Expression<Func<string>> bodyTermsCode = null, Expression<Func<string>> bodyWarehouseCode = null)
        {
            var apiCallPath = "/api/v1/SAGE100/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyARDivisionNo != null)
            {
                body["ARDivisionNo"] = ExpressionConverter.ConvertO(bodyARDivisionNo);
                bodypropCount++;
            }

            if (bodyBatchFax != null)
            {
                body["BatchFax"] = ExpressionConverter.ConvertO(bodyBatchFax);
                bodypropCount++;
            }

            if (bodyBillToAddress1 != null)
            {
                body["BillToAddress1"] = ExpressionConverter.ConvertO(bodyBillToAddress1);
                bodypropCount++;
            }

            if (bodyBillToAddress2 != null)
            {
                body["BillToAddress2"] = ExpressionConverter.ConvertO(bodyBillToAddress2);
                bodypropCount++;
            }

            if (bodyBillToAddress3 != null)
            {
                body["BillToAddress3"] = ExpressionConverter.ConvertO(bodyBillToAddress3);
                bodypropCount++;
            }

            if (bodyBillToCity != null)
            {
                body["BillToCity"] = ExpressionConverter.ConvertO(bodyBillToCity);
                bodypropCount++;
            }

            if (bodyBillToCountryCode != null)
            {
                body["BillToCountryCode"] = ExpressionConverter.ConvertO(bodyBillToCountryCode);
                bodypropCount++;
            }

            if (bodyBillToName != null)
            {
                body["BillToName"] = ExpressionConverter.ConvertO(bodyBillToName);
                bodypropCount++;
            }

            if (bodyBillToState != null)
            {
                body["BillToState"] = ExpressionConverter.ConvertO(bodyBillToState);
                bodypropCount++;
            }

            if (bodyBillToZipCode != null)
            {
                body["BillToZipCode"] = ExpressionConverter.ConvertO(bodyBillToZipCode);
                bodypropCount++;
            }

            if (bodyComment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodyComment);
                bodypropCount++;
            }

            if (bodyConfirmTo != null)
            {
                body["ConfirmTo"] = ExpressionConverter.ConvertO(bodyConfirmTo);
                bodypropCount++;
            }

            if (bodyCustomerNo != null)
            {
                body["CustomerNo"] = ExpressionConverter.ConvertO(bodyCustomerNo);
                bodypropCount++;
            }

            if (bodyCustomerPONo != null)
            {
                body["CustomerPONo"] = ExpressionConverter.ConvertO(bodyCustomerPONo);
                bodypropCount++;
            }

            if (bodyCycleCode != null)
            {
                body["CycleCode"] = ExpressionConverter.ConvertO(bodyCycleCode);
                bodypropCount++;
            }

            if (bodyEmailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyEmailAddress);
                bodypropCount++;
            }

            if (bodyFOB != null)
            {
                body["FOB"] = ExpressionConverter.ConvertO(bodyFOB);
                bodypropCount++;
            }

            if (bodyFaxNo != null)
            {
                body["FaxNo"] = ExpressionConverter.ConvertO(bodyFaxNo);
                bodypropCount++;
            }

            if (bodyMasterRepeatingOrderNo != null)
            {
                body["MasterRepeatingOrderNo"] = ExpressionConverter.ConvertO(bodyMasterRepeatingOrderNo);
                bodypropCount++;
            }

            if (bodyNumberOfShippingLabels != null)
            {
                body["NumberOfShippingLabels"] = ExpressionConverter.ConvertO(bodyNumberOfShippingLabels);
                bodypropCount++;
            }

            if (bodyOrderDate != null)
            {
                body["OrderDate"] = ExpressionConverter.ConvertO(bodyOrderDate);
                bodypropCount++;
            }

            if (bodyOrderStatus != null)
            {
                body["OrderStatus"] = ExpressionConverter.ConvertO(bodyOrderStatus);
                bodypropCount++;
            }

            if (bodyOrderType != null)
            {
                body["OrderType"] = ExpressionConverter.ConvertO(bodyOrderType);
                bodypropCount++;
            }

            if (bodyPrintPickingSheets != null)
            {
                body["PrintPickingSheets"] = ExpressionConverter.ConvertO(bodyPrintPickingSheets);
                bodypropCount++;
            }

            if (bodyPrintSalesOrders != null)
            {
                body["PrintSalesOrders"] = ExpressionConverter.ConvertO(bodyPrintSalesOrders);
                bodypropCount++;
            }

            if (bodySalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodySalesOrderLineItem);
                bodypropCount++;
            }

            if (bodySalesOrderNo != null)
            {
                body["SalesOrderNo"] = ExpressionConverter.ConvertO(bodySalesOrderNo);
                bodypropCount++;
            }

            if (bodySalespersonNo != null)
            {
                body["SalespersonNo"] = ExpressionConverter.ConvertO(bodySalespersonNo);
                bodypropCount++;
            }

            if (bodyShipExpireDate != null)
            {
                body["ShipExpireDate"] = ExpressionConverter.ConvertO(bodyShipExpireDate);
                bodypropCount++;
            }

            if (bodyShipToAddress1 != null)
            {
                body["ShipToAddress1"] = ExpressionConverter.ConvertO(bodyShipToAddress1);
                bodypropCount++;
            }

            if (bodyShipToAddress2 != null)
            {
                body["ShipToAddress2"] = ExpressionConverter.ConvertO(bodyShipToAddress2);
                bodypropCount++;
            }

            if (bodyShipToAddress3 != null)
            {
                body["ShipToAddress3"] = ExpressionConverter.ConvertO(bodyShipToAddress3);
                bodypropCount++;
            }

            if (bodyShipToCity != null)
            {
                body["ShipToCity"] = ExpressionConverter.ConvertO(bodyShipToCity);
                bodypropCount++;
            }

            if (bodyShipToCode != null)
            {
                body["ShipToCode"] = ExpressionConverter.ConvertO(bodyShipToCode);
                bodypropCount++;
            }

            if (bodyShipToCountryCode != null)
            {
                body["ShipToCountryCode"] = ExpressionConverter.ConvertO(bodyShipToCountryCode);
                bodypropCount++;
            }

            if (bodyShipToName != null)
            {
                body["ShipToName"] = ExpressionConverter.ConvertO(bodyShipToName);
                bodypropCount++;
            }

            if (bodyShipToState != null)
            {
                body["ShipToState"] = ExpressionConverter.ConvertO(bodyShipToState);
                bodypropCount++;
            }

            if (bodyShipToZipCode != null)
            {
                body["ShipToZipCode"] = ExpressionConverter.ConvertO(bodyShipToZipCode);
                bodypropCount++;
            }

            if (bodyShipVia != null)
            {
                body["ShipVia"] = ExpressionConverter.ConvertO(bodyShipVia);
                bodypropCount++;
            }

            if (bodyShipWeight != null)
            {
                body["ShipWeight"] = ExpressionConverter.ConvertO(bodyShipWeight);
                bodypropCount++;
            }

            if (bodyShipZoneActual != null)
            {
                body["ShipZoneActual"] = ExpressionConverter.ConvertO(bodyShipZoneActual);
                bodypropCount++;
            }

            if (bodySplitCommissions != null)
            {
                body["SplitCommissions"] = ExpressionConverter.ConvertO(bodySplitCommissions);
                bodypropCount++;
            }

            if (bodyTaxExemptNo != null)
            {
                body["TaxExemptNo"] = ExpressionConverter.ConvertO(bodyTaxExemptNo);
                bodypropCount++;
            }

            if (bodyTaxSchedule != null)
            {
                body["TaxSchedule"] = ExpressionConverter.ConvertO(bodyTaxSchedule);
                bodypropCount++;
            }

            if (bodyTermsCode != null)
            {
                body["TermsCode"] = ExpressionConverter.ConvertO(bodyTermsCode);
                bodypropCount++;
            }

            if (bodyWarehouseCode != null)
            {
                body["WarehouseCode"] = ExpressionConverter.ConvertO(bodyWarehouseCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE100CreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> CommercientCPQCreateNewCustomer(Expression<Func<string>> bodyBillingCity = null, Expression<Func<string>> bodyBillingCounty = null, Expression<Func<string>> bodyBillingPostalCode = null, Expression<Func<string>> bodyBillingState = null, Expression<Func<string>> bodyBillingStreet = null, Expression<Func<string>> bodyGUID = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyShippingCity = null, Expression<Func<string>> bodyShippingCountry = null, Expression<Func<string>> bodyShippingPostalCode = null, Expression<Func<string>> bodyShippingState = null, Expression<Func<string>> bodyShippingStreet = null, Expression<Func<string>> bodyacnm = null)
        {
            var apiCallPath = "/api/v1/commercientcpq/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyBillingCity != null)
            {
                body["BillingCity"] = ExpressionConverter.ConvertO(bodyBillingCity);
                bodypropCount++;
            }

            if (bodyBillingCounty != null)
            {
                body["BillingCounty"] = ExpressionConverter.ConvertO(bodyBillingCounty);
                bodypropCount++;
            }

            if (bodyBillingPostalCode != null)
            {
                body["BillingPostalCode"] = ExpressionConverter.ConvertO(bodyBillingPostalCode);
                bodypropCount++;
            }

            if (bodyBillingState != null)
            {
                body["BillingState"] = ExpressionConverter.ConvertO(bodyBillingState);
                bodypropCount++;
            }

            if (bodyBillingStreet != null)
            {
                body["BillingStreet"] = ExpressionConverter.ConvertO(bodyBillingStreet);
                bodypropCount++;
            }

            if (bodyGUID != null)
            {
                body["GUID"] = ExpressionConverter.ConvertO(bodyGUID);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyShippingCity != null)
            {
                body["ShippingCity"] = ExpressionConverter.ConvertO(bodyShippingCity);
                bodypropCount++;
            }

            if (bodyShippingCountry != null)
            {
                body["ShippingCountry"] = ExpressionConverter.ConvertO(bodyShippingCountry);
                bodypropCount++;
            }

            if (bodyShippingPostalCode != null)
            {
                body["ShippingPostalCode"] = ExpressionConverter.ConvertO(bodyShippingPostalCode);
                bodypropCount++;
            }

            if (bodyShippingState != null)
            {
                body["ShippingState"] = ExpressionConverter.ConvertO(bodyShippingState);
                bodypropCount++;
            }

            if (bodyShippingStreet != null)
            {
                body["ShippingStreet"] = ExpressionConverter.ConvertO(bodyShippingStreet);
                bodypropCount++;
            }

            if (bodyacnm != null)
            {
                body["acnm"] = ExpressionConverter.ConvertO(bodyacnm);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> CommercientCPQCreateNewProduct(Expression<Func<string>> bodyStockCode = null)
        {
            var apiCallPath = "/api/v1/commercientcpq/product";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyStockCode != null)
            {
                body["StockCode"] = ExpressionConverter.ConvertO(bodyStockCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewProductResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> CommercientCPQCreateNewSalesOrder(Expression<Func<string>> bodyOrderHeaderGUID = null, Expression<Func<bodySalesOrderLineItemInputItem2[]>> bodySalesOrderLineItem = null)
        {
            var apiCallPath = "/api/v1/commercientcpq/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyOrderHeaderGUID != null)
            {
                body["OrderHeaderGUID"] = ExpressionConverter.ConvertO(bodyOrderHeaderGUID);
                bodypropCount++;
            }

            if (bodySalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodySalesOrderLineItem);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> QuickBookCreateNewCustomer(Expression<Func<string>> bodyAccountNumber = null, Expression<Func<string>> bodyAltContact = null, Expression<Func<string>> bodyAltPhone = null, Expression<Func<string>> bodyBillAddressAddr1 = null, Expression<Func<string>> bodyBillAddressAddr2 = null, Expression<Func<string>> bodyBillAddressAddr3 = null, Expression<Func<string>> bodyBillAddressAddr4 = null, Expression<Func<string>> bodyBillAddressAddr5 = null, Expression<Func<string>> bodyBillAddressCity = null, Expression<Func<string>> bodyBillAddressCountry = null, Expression<Func<string>> bodyBillAddressNote = null, Expression<Func<string>> bodyBillAddressPostalCode = null, Expression<Func<string>> bodyBillAddressState = null, Expression<Func<string>> bodyCc = null, Expression<Func<string>> bodyClassRef = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyContact = null, Expression<Func<int>> bodyCreditLimit = null, Expression<Func<string>> bodyCustomerTypeRef = null, Expression<Func<string>> bodyEditSequence = null, Expression<Func<string>> bodyEmail = null, Expression<Func<string>> bodyExtraField = null, Expression<Func<string>> bodyFax = null, Expression<Func<string>> bodyFirstName = null, Expression<Func<bool>> bodyIsActive = null, Expression<Func<string>> bodyItemSalesTaxRef = null, Expression<Func<string>> bodyJobTitle = null, Expression<Func<string>> bodyLastName = null, Expression<Func<string>> bodyListID = null, Expression<Func<string>> bodyMiddleName = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyNotes = null, Expression<Func<int>> bodyOpenBalance = null, Expression<Func<string>> bodyOpenBalanceDate = null, Expression<Func<string>> bodyParentRef = null, Expression<Func<string>> bodyPhone = null, Expression<Func<string>> bodyPreferredPaymentMethodRef = null, Expression<Func<string>> bodyPriceLevelRef = null, Expression<Func<string>> bodyResaleNumber = null, Expression<Func<string>> bodySalesRepRef = null, Expression<Func<string>> bodySalesTaxCodeRef = null, Expression<Func<string>> bodySalutation = null, Expression<Func<string>> bodyShipAddressAddr1 = null, Expression<Func<string>> bodyShipAddressAddr2 = null, Expression<Func<string>> bodyShipAddressAddr3 = null, Expression<Func<string>> bodyShipAddressAddr4 = null, Expression<Func<string>> bodyShipAddressAddr5 = null, Expression<Func<string>> bodyShipAddressCity = null, Expression<Func<string>> bodyShipAddressCountry = null, Expression<Func<string>> bodyShipAddressNote = null, Expression<Func<string>> bodyShipAddressPostalCode = null, Expression<Func<string>> bodyShipAddressState = null, Expression<Func<string>> bodyTermsRef = null)
        {
            var apiCallPath = "/api/v1/quickbook/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccountNumber != null)
            {
                body["AccountNumber"] = ExpressionConverter.ConvertO(bodyAccountNumber);
                bodypropCount++;
            }

            if (bodyAltContact != null)
            {
                body["AltContact"] = ExpressionConverter.ConvertO(bodyAltContact);
                bodypropCount++;
            }

            if (bodyAltPhone != null)
            {
                body["AltPhone"] = ExpressionConverter.ConvertO(bodyAltPhone);
                bodypropCount++;
            }

            if (bodyBillAddressAddr1 != null)
            {
                body["BillAddressAddr1"] = ExpressionConverter.ConvertO(bodyBillAddressAddr1);
                bodypropCount++;
            }

            if (bodyBillAddressAddr2 != null)
            {
                body["BillAddressAddr2"] = ExpressionConverter.ConvertO(bodyBillAddressAddr2);
                bodypropCount++;
            }

            if (bodyBillAddressAddr3 != null)
            {
                body["BillAddressAddr3"] = ExpressionConverter.ConvertO(bodyBillAddressAddr3);
                bodypropCount++;
            }

            if (bodyBillAddressAddr4 != null)
            {
                body["BillAddressAddr4"] = ExpressionConverter.ConvertO(bodyBillAddressAddr4);
                bodypropCount++;
            }

            if (bodyBillAddressAddr5 != null)
            {
                body["BillAddressAddr5"] = ExpressionConverter.ConvertO(bodyBillAddressAddr5);
                bodypropCount++;
            }

            if (bodyBillAddressCity != null)
            {
                body["BillAddressCity"] = ExpressionConverter.ConvertO(bodyBillAddressCity);
                bodypropCount++;
            }

            if (bodyBillAddressCountry != null)
            {
                body["BillAddressCountry"] = ExpressionConverter.ConvertO(bodyBillAddressCountry);
                bodypropCount++;
            }

            if (bodyBillAddressNote != null)
            {
                body["BillAddressNote"] = ExpressionConverter.ConvertO(bodyBillAddressNote);
                bodypropCount++;
            }

            if (bodyBillAddressPostalCode != null)
            {
                body["BillAddressPostalCode"] = ExpressionConverter.ConvertO(bodyBillAddressPostalCode);
                bodypropCount++;
            }

            if (bodyBillAddressState != null)
            {
                body["BillAddressState"] = ExpressionConverter.ConvertO(bodyBillAddressState);
                bodypropCount++;
            }

            if (bodyCc != null)
            {
                body["Cc"] = ExpressionConverter.ConvertO(bodyCc);
                bodypropCount++;
            }

            if (bodyClassRef != null)
            {
                body["ClassRef"] = ExpressionConverter.ConvertO(bodyClassRef);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyContact != null)
            {
                body["Contact"] = ExpressionConverter.ConvertO(bodyContact);
                bodypropCount++;
            }

            if (bodyCreditLimit != null)
            {
                body["CreditLimit"] = ExpressionConverter.ConvertO(bodyCreditLimit);
                bodypropCount++;
            }

            if (bodyCustomerTypeRef != null)
            {
                body["CustomerTypeRef"] = ExpressionConverter.ConvertO(bodyCustomerTypeRef);
                bodypropCount++;
            }

            if (bodyEditSequence != null)
            {
                body["EditSequence"] = ExpressionConverter.ConvertO(bodyEditSequence);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyExtraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyExtraField);
                bodypropCount++;
            }

            if (bodyFax != null)
            {
                body["Fax"] = ExpressionConverter.ConvertO(bodyFax);
                bodypropCount++;
            }

            if (bodyFirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyFirstName);
                bodypropCount++;
            }

            if (bodyIsActive != null)
            {
                body["IsActive"] = ExpressionConverter.ConvertO(bodyIsActive);
                bodypropCount++;
            }

            if (bodyItemSalesTaxRef != null)
            {
                body["ItemSalesTaxRef"] = ExpressionConverter.ConvertO(bodyItemSalesTaxRef);
                bodypropCount++;
            }

            if (bodyJobTitle != null)
            {
                body["JobTitle"] = ExpressionConverter.ConvertO(bodyJobTitle);
                bodypropCount++;
            }

            if (bodyLastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodyLastName);
                bodypropCount++;
            }

            if (bodyListID != null)
            {
                body["ListID"] = ExpressionConverter.ConvertO(bodyListID);
                bodypropCount++;
            }

            if (bodyMiddleName != null)
            {
                body["MiddleName"] = ExpressionConverter.ConvertO(bodyMiddleName);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyNotes != null)
            {
                body["Notes"] = ExpressionConverter.ConvertO(bodyNotes);
                bodypropCount++;
            }

            if (bodyOpenBalance != null)
            {
                body["OpenBalance"] = ExpressionConverter.ConvertO(bodyOpenBalance);
                bodypropCount++;
            }

            if (bodyOpenBalanceDate != null)
            {
                body["OpenBalanceDate"] = ExpressionConverter.ConvertO(bodyOpenBalanceDate);
                bodypropCount++;
            }

            if (bodyParentRef != null)
            {
                body["ParentRef"] = ExpressionConverter.ConvertO(bodyParentRef);
                bodypropCount++;
            }

            if (bodyPhone != null)
            {
                body["Phone"] = ExpressionConverter.ConvertO(bodyPhone);
                bodypropCount++;
            }

            if (bodyPreferredPaymentMethodRef != null)
            {
                body["PreferredPaymentMethodRef"] = ExpressionConverter.ConvertO(bodyPreferredPaymentMethodRef);
                bodypropCount++;
            }

            if (bodyPriceLevelRef != null)
            {
                body["PriceLevelRef"] = ExpressionConverter.ConvertO(bodyPriceLevelRef);
                bodypropCount++;
            }

            if (bodyResaleNumber != null)
            {
                body["ResaleNumber"] = ExpressionConverter.ConvertO(bodyResaleNumber);
                bodypropCount++;
            }

            if (bodySalesRepRef != null)
            {
                body["SalesRepRef"] = ExpressionConverter.ConvertO(bodySalesRepRef);
                bodypropCount++;
            }

            if (bodySalesTaxCodeRef != null)
            {
                body["SalesTaxCodeRef"] = ExpressionConverter.ConvertO(bodySalesTaxCodeRef);
                bodypropCount++;
            }

            if (bodySalutation != null)
            {
                body["Salutation"] = ExpressionConverter.ConvertO(bodySalutation);
                bodypropCount++;
            }

            if (bodyShipAddressAddr1 != null)
            {
                body["ShipAddressAddr1"] = ExpressionConverter.ConvertO(bodyShipAddressAddr1);
                bodypropCount++;
            }

            if (bodyShipAddressAddr2 != null)
            {
                body["ShipAddressAddr2"] = ExpressionConverter.ConvertO(bodyShipAddressAddr2);
                bodypropCount++;
            }

            if (bodyShipAddressAddr3 != null)
            {
                body["ShipAddressAddr3"] = ExpressionConverter.ConvertO(bodyShipAddressAddr3);
                bodypropCount++;
            }

            if (bodyShipAddressAddr4 != null)
            {
                body["ShipAddressAddr4"] = ExpressionConverter.ConvertO(bodyShipAddressAddr4);
                bodypropCount++;
            }

            if (bodyShipAddressAddr5 != null)
            {
                body["ShipAddressAddr5"] = ExpressionConverter.ConvertO(bodyShipAddressAddr5);
                bodypropCount++;
            }

            if (bodyShipAddressCity != null)
            {
                body["ShipAddressCity"] = ExpressionConverter.ConvertO(bodyShipAddressCity);
                bodypropCount++;
            }

            if (bodyShipAddressCountry != null)
            {
                body["ShipAddressCountry"] = ExpressionConverter.ConvertO(bodyShipAddressCountry);
                bodypropCount++;
            }

            if (bodyShipAddressNote != null)
            {
                body["ShipAddressNote"] = ExpressionConverter.ConvertO(bodyShipAddressNote);
                bodypropCount++;
            }

            if (bodyShipAddressPostalCode != null)
            {
                body["ShipAddressPostalCode"] = ExpressionConverter.ConvertO(bodyShipAddressPostalCode);
                bodypropCount++;
            }

            if (bodyShipAddressState != null)
            {
                body["ShipAddressState"] = ExpressionConverter.ConvertO(bodyShipAddressState);
                bodypropCount++;
            }

            if (bodyTermsRef != null)
            {
                body["TermsRef"] = ExpressionConverter.ConvertO(bodyTermsRef);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QuickBookCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> QuickBookCreateNewSalesOrder(Expression<Func<string>> bodyBillAddressAddr1 = null, Expression<Func<string>> bodyBillAddressAddr2 = null, Expression<Func<string>> bodyBillAddressAddr3 = null, Expression<Func<string>> bodyBillAddressAddr4 = null, Expression<Func<string>> bodyBillAddressAddr5 = null, Expression<Func<string>> bodyBillAddressCity = null, Expression<Func<string>> bodyBillAddressCountry = null, Expression<Func<string>> bodyBillAddressNote = null, Expression<Func<string>> bodyBillAddressPostalCode = null, Expression<Func<string>> bodyBillAddressState = null, Expression<Func<string>> bodyClassRef = null, Expression<Func<string>> bodyCustomerRefListID = null, Expression<Func<string>> bodyCustomerRefName = null, Expression<Func<string>> bodyCustomerSalesTaxCodeRef = null, Expression<Func<string>> bodyDueDate = null, Expression<Func<string>> bodyEditSequence = null, Expression<Func<string>> bodyExtraField = null, Expression<Func<string>> bodyItemSalesTaxRef = null, Expression<Func<string>> bodyListID = null, Expression<Func<string>> bodyMemo = null, Expression<Func<string>> bodyPONumber = null, Expression<Func<string>> bodyRefNumber = null, Expression<Func<bodySalesOrderLineItemInputItem22[]>> bodySalesOrderLineItem = null, Expression<Func<string>> bodySalesRepRef = null, Expression<Func<string>> bodyShipAddressAddr1 = null, Expression<Func<string>> bodyShipAddressAddr2 = null, Expression<Func<string>> bodyShipAddressAddr3 = null, Expression<Func<string>> bodyShipAddressAddr4 = null, Expression<Func<string>> bodyShipAddressAddr5 = null, Expression<Func<string>> bodyShipAddressCity = null, Expression<Func<string>> bodyShipAddressCountry = null, Expression<Func<string>> bodyShipAddressNote = null, Expression<Func<string>> bodyShipAddressPostalCode = null, Expression<Func<string>> bodyShipAddressState = null, Expression<Func<string>> bodyTemplateRef = null, Expression<Func<string>> bodyTermsRef = null, Expression<Func<string>> bodyTxnDate = null)
        {
            var apiCallPath = "/api/v1/quickbook/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyBillAddressAddr1 != null)
            {
                body["BillAddressAddr1"] = ExpressionConverter.ConvertO(bodyBillAddressAddr1);
                bodypropCount++;
            }

            if (bodyBillAddressAddr2 != null)
            {
                body["BillAddressAddr2"] = ExpressionConverter.ConvertO(bodyBillAddressAddr2);
                bodypropCount++;
            }

            if (bodyBillAddressAddr3 != null)
            {
                body["BillAddressAddr3"] = ExpressionConverter.ConvertO(bodyBillAddressAddr3);
                bodypropCount++;
            }

            if (bodyBillAddressAddr4 != null)
            {
                body["BillAddressAddr4"] = ExpressionConverter.ConvertO(bodyBillAddressAddr4);
                bodypropCount++;
            }

            if (bodyBillAddressAddr5 != null)
            {
                body["BillAddressAddr5"] = ExpressionConverter.ConvertO(bodyBillAddressAddr5);
                bodypropCount++;
            }

            if (bodyBillAddressCity != null)
            {
                body["BillAddressCity"] = ExpressionConverter.ConvertO(bodyBillAddressCity);
                bodypropCount++;
            }

            if (bodyBillAddressCountry != null)
            {
                body["BillAddressCountry"] = ExpressionConverter.ConvertO(bodyBillAddressCountry);
                bodypropCount++;
            }

            if (bodyBillAddressNote != null)
            {
                body["BillAddressNote"] = ExpressionConverter.ConvertO(bodyBillAddressNote);
                bodypropCount++;
            }

            if (bodyBillAddressPostalCode != null)
            {
                body["BillAddressPostalCode"] = ExpressionConverter.ConvertO(bodyBillAddressPostalCode);
                bodypropCount++;
            }

            if (bodyBillAddressState != null)
            {
                body["BillAddressState"] = ExpressionConverter.ConvertO(bodyBillAddressState);
                bodypropCount++;
            }

            if (bodyClassRef != null)
            {
                body["ClassRef"] = ExpressionConverter.ConvertO(bodyClassRef);
                bodypropCount++;
            }

            if (bodyCustomerRefListID != null)
            {
                body["CustomerRefListID"] = ExpressionConverter.ConvertO(bodyCustomerRefListID);
                bodypropCount++;
            }

            if (bodyCustomerRefName != null)
            {
                body["CustomerRefName"] = ExpressionConverter.ConvertO(bodyCustomerRefName);
                bodypropCount++;
            }

            if (bodyCustomerSalesTaxCodeRef != null)
            {
                body["CustomerSalesTaxCodeRef"] = ExpressionConverter.ConvertO(bodyCustomerSalesTaxCodeRef);
                bodypropCount++;
            }

            if (bodyDueDate != null)
            {
                body["DueDate"] = ExpressionConverter.ConvertO(bodyDueDate);
                bodypropCount++;
            }

            if (bodyEditSequence != null)
            {
                body["EditSequence"] = ExpressionConverter.ConvertO(bodyEditSequence);
                bodypropCount++;
            }

            if (bodyExtraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyExtraField);
                bodypropCount++;
            }

            if (bodyItemSalesTaxRef != null)
            {
                body["ItemSalesTaxRef"] = ExpressionConverter.ConvertO(bodyItemSalesTaxRef);
                bodypropCount++;
            }

            if (bodyListID != null)
            {
                body["ListID"] = ExpressionConverter.ConvertO(bodyListID);
                bodypropCount++;
            }

            if (bodyMemo != null)
            {
                body["Memo"] = ExpressionConverter.ConvertO(bodyMemo);
                bodypropCount++;
            }

            if (bodyPONumber != null)
            {
                body["PONumber"] = ExpressionConverter.ConvertO(bodyPONumber);
                bodypropCount++;
            }

            if (bodyRefNumber != null)
            {
                body["RefNumber"] = ExpressionConverter.ConvertO(bodyRefNumber);
                bodypropCount++;
            }

            if (bodySalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodySalesOrderLineItem);
                bodypropCount++;
            }

            if (bodySalesRepRef != null)
            {
                body["SalesRepRef"] = ExpressionConverter.ConvertO(bodySalesRepRef);
                bodypropCount++;
            }

            if (bodyShipAddressAddr1 != null)
            {
                body["ShipAddressAddr1"] = ExpressionConverter.ConvertO(bodyShipAddressAddr1);
                bodypropCount++;
            }

            if (bodyShipAddressAddr2 != null)
            {
                body["ShipAddressAddr2"] = ExpressionConverter.ConvertO(bodyShipAddressAddr2);
                bodypropCount++;
            }

            if (bodyShipAddressAddr3 != null)
            {
                body["ShipAddressAddr3"] = ExpressionConverter.ConvertO(bodyShipAddressAddr3);
                bodypropCount++;
            }

            if (bodyShipAddressAddr4 != null)
            {
                body["ShipAddressAddr4"] = ExpressionConverter.ConvertO(bodyShipAddressAddr4);
                bodypropCount++;
            }

            if (bodyShipAddressAddr5 != null)
            {
                body["ShipAddressAddr5"] = ExpressionConverter.ConvertO(bodyShipAddressAddr5);
                bodypropCount++;
            }

            if (bodyShipAddressCity != null)
            {
                body["ShipAddressCity"] = ExpressionConverter.ConvertO(bodyShipAddressCity);
                bodypropCount++;
            }

            if (bodyShipAddressCountry != null)
            {
                body["ShipAddressCountry"] = ExpressionConverter.ConvertO(bodyShipAddressCountry);
                bodypropCount++;
            }

            if (bodyShipAddressNote != null)
            {
                body["ShipAddressNote"] = ExpressionConverter.ConvertO(bodyShipAddressNote);
                bodypropCount++;
            }

            if (bodyShipAddressPostalCode != null)
            {
                body["ShipAddressPostalCode"] = ExpressionConverter.ConvertO(bodyShipAddressPostalCode);
                bodypropCount++;
            }

            if (bodyShipAddressState != null)
            {
                body["ShipAddressState"] = ExpressionConverter.ConvertO(bodyShipAddressState);
                bodypropCount++;
            }

            if (bodyTemplateRef != null)
            {
                body["TemplateRef"] = ExpressionConverter.ConvertO(bodyTemplateRef);
                bodypropCount++;
            }

            if (bodyTermsRef != null)
            {
                body["TermsRef"] = ExpressionConverter.ConvertO(bodyTermsRef);
                bodypropCount++;
            }

            if (bodyTxnDate != null)
            {
                body["TxnDate"] = ExpressionConverter.ConvertO(bodyTxnDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QuickBookCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> SAGE50UKCreateNewCustomer(Expression<Func<string>> bodyACCOUNTOPENED = null, Expression<Func<string>> bodyACCOUNTREF = null, Expression<Func<int>> bodyACCOUNTSTATUS = null, Expression<Func<string>> bodyADDRESS1 = null, Expression<Func<string>> bodyADDRESS2 = null, Expression<Func<string>> bodyADDRESS3 = null, Expression<Func<string>> bodyADDRESS4 = null, Expression<Func<string>> bodyADDRESS5 = null, Expression<Func<string>> bodyANALYSIS1 = null, Expression<Func<string>> bodyANALYSIS2 = null, Expression<Func<string>> bodyANALYSIS3 = null, Expression<Func<int>> bodyAVERAGEPAYDAYS = null, Expression<Func<int>> bodyBALANCE = null, Expression<Func<bool>> bodyCANAPPLYCHARGES = null, Expression<Func<string>> bodyCONTACTNAME = null, Expression<Func<string>> bodyCOUNTRYCODE = null, Expression<Func<string>> bodyCREDITAPPLIEDFOR = null, Expression<Func<int>> bodyCREDITBUREAU = null, Expression<Func<int>> bodyCREDITLIMIT = null, Expression<Func<int>> bodyCREDITPOSITION = null, Expression<Func<string>> bodyCREDITREFERENCE = null, Expression<Func<int>> bodyCURRENCY = null, Expression<Func<string>> bodyDATECREDITAPPRECEIVED = null, Expression<Func<string>> bodyDEFNOMCODE = null, Expression<Func<int>> bodyDEFTAXCODE = null, Expression<Func<int>> bodyDEPTNUMBER = null, Expression<Func<int>> bodyDISCOUNTRATE = null, Expression<Func<int>> bodyDISCOUNTTYPE = null, Expression<Func<string>> bodyDUNSNUMBER = null, Expression<Func<string>> bodyEMAIL = null, Expression<Func<string>> bodyEMAIL2 = null, Expression<Func<string>> bodyEMAIL3 = null, Expression<Func<string>> bodyExtraField = null, Expression<Func<string>> bodyFAX = null, Expression<Func<bool>> bodyHOLDMAIL = null, Expression<Func<bool>> bodyINACTIVEFLAG = null, Expression<Func<bool>> bodyIsACCOUNTREFAutogenerate = null, Expression<Func<string>> bodyLASTCREDITREV = null, Expression<Func<string>> bodyNAME = null, Expression<Func<string>> bodyNEXTCREDITREV = null, Expression<Func<bool>> bodyOVERRIDEPRODUCTNOMINAL = null, Expression<Func<bool>> bodyOVERRIDEPRODUCTTAX = null, Expression<Func<int>> bodyPAYMENTDUEDAYS = null, Expression<Func<string>> bodyPRICELISTREF = null, Expression<Func<bool>> bodyPRIORITYTRADER = null, Expression<Func<bool>> bodySENDINVOICESELECTRONICALLY = null, Expression<Func<bool>> bodySENDLETTERSELECTRONICALLY = null, Expression<Func<int>> bodySETTLEMENTDISCRATE = null, Expression<Func<int>> bodySETTLEMENTDUEDAYS = null, Expression<Func<string>> bodyTELEPHONE = null, Expression<Func<string>> bodyTELEPHONE2 = null, Expression<Func<string>> bodyTERMS = null, Expression<Func<bool>> bodyTERMSAGREEDFLAG = null, Expression<Func<string>> bodyTRADECONTACT = null, Expression<Func<string>> bodyVATREGNUMBER = null)
        {
            var apiCallPath = "/api/v1/sage50uk/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyACCOUNTOPENED != null)
            {
                body["ACCOUNT_OPENED"] = ExpressionConverter.ConvertO(bodyACCOUNTOPENED);
                bodypropCount++;
            }

            if (bodyACCOUNTREF != null)
            {
                body["ACCOUNT_REF"] = ExpressionConverter.ConvertO(bodyACCOUNTREF);
                bodypropCount++;
            }

            if (bodyACCOUNTSTATUS != null)
            {
                body["ACCOUNT_STATUS"] = ExpressionConverter.ConvertO(bodyACCOUNTSTATUS);
                bodypropCount++;
            }

            if (bodyADDRESS1 != null)
            {
                body["ADDRESS_1"] = ExpressionConverter.ConvertO(bodyADDRESS1);
                bodypropCount++;
            }

            if (bodyADDRESS2 != null)
            {
                body["ADDRESS_2"] = ExpressionConverter.ConvertO(bodyADDRESS2);
                bodypropCount++;
            }

            if (bodyADDRESS3 != null)
            {
                body["ADDRESS_3"] = ExpressionConverter.ConvertO(bodyADDRESS3);
                bodypropCount++;
            }

            if (bodyADDRESS4 != null)
            {
                body["ADDRESS_4"] = ExpressionConverter.ConvertO(bodyADDRESS4);
                bodypropCount++;
            }

            if (bodyADDRESS5 != null)
            {
                body["ADDRESS_5"] = ExpressionConverter.ConvertO(bodyADDRESS5);
                bodypropCount++;
            }

            if (bodyANALYSIS1 != null)
            {
                body["ANALYSIS_1"] = ExpressionConverter.ConvertO(bodyANALYSIS1);
                bodypropCount++;
            }

            if (bodyANALYSIS2 != null)
            {
                body["ANALYSIS_2"] = ExpressionConverter.ConvertO(bodyANALYSIS2);
                bodypropCount++;
            }

            if (bodyANALYSIS3 != null)
            {
                body["ANALYSIS_3"] = ExpressionConverter.ConvertO(bodyANALYSIS3);
                bodypropCount++;
            }

            if (bodyAVERAGEPAYDAYS != null)
            {
                body["AVERAGE_PAY_DAYS"] = ExpressionConverter.ConvertO(bodyAVERAGEPAYDAYS);
                bodypropCount++;
            }

            if (bodyBALANCE != null)
            {
                body["BALANCE"] = ExpressionConverter.ConvertO(bodyBALANCE);
                bodypropCount++;
            }

            if (bodyCANAPPLYCHARGES != null)
            {
                body["CAN_APPLY_CHARGES"] = ExpressionConverter.ConvertO(bodyCANAPPLYCHARGES);
                bodypropCount++;
            }

            if (bodyCONTACTNAME != null)
            {
                body["CONTACT_NAME"] = ExpressionConverter.ConvertO(bodyCONTACTNAME);
                bodypropCount++;
            }

            if (bodyCOUNTRYCODE != null)
            {
                body["COUNTRY_CODE"] = ExpressionConverter.ConvertO(bodyCOUNTRYCODE);
                bodypropCount++;
            }

            if (bodyCREDITAPPLIEDFOR != null)
            {
                body["CREDIT_APPLIED_FOR"] = ExpressionConverter.ConvertO(bodyCREDITAPPLIEDFOR);
                bodypropCount++;
            }

            if (bodyCREDITBUREAU != null)
            {
                body["CREDIT_BUREAU"] = ExpressionConverter.ConvertO(bodyCREDITBUREAU);
                bodypropCount++;
            }

            if (bodyCREDITLIMIT != null)
            {
                body["CREDIT_LIMIT"] = ExpressionConverter.ConvertO(bodyCREDITLIMIT);
                bodypropCount++;
            }

            if (bodyCREDITPOSITION != null)
            {
                body["CREDIT_POSITION"] = ExpressionConverter.ConvertO(bodyCREDITPOSITION);
                bodypropCount++;
            }

            if (bodyCREDITREFERENCE != null)
            {
                body["CREDIT_REFERENCE"] = ExpressionConverter.ConvertO(bodyCREDITREFERENCE);
                bodypropCount++;
            }

            if (bodyCURRENCY != null)
            {
                body["CURRENCY"] = ExpressionConverter.ConvertO(bodyCURRENCY);
                bodypropCount++;
            }

            if (bodyDATECREDITAPPRECEIVED != null)
            {
                body["DATE_CREDIT_APP_RECEIVED"] = ExpressionConverter.ConvertO(bodyDATECREDITAPPRECEIVED);
                bodypropCount++;
            }

            if (bodyDEFNOMCODE != null)
            {
                body["DEF_NOM_CODE"] = ExpressionConverter.ConvertO(bodyDEFNOMCODE);
                bodypropCount++;
            }

            if (bodyDEFTAXCODE != null)
            {
                body["DEF_TAX_CODE"] = ExpressionConverter.ConvertO(bodyDEFTAXCODE);
                bodypropCount++;
            }

            if (bodyDEPTNUMBER != null)
            {
                body["DEPT_NUMBER"] = ExpressionConverter.ConvertO(bodyDEPTNUMBER);
                bodypropCount++;
            }

            if (bodyDISCOUNTRATE != null)
            {
                body["DISCOUNT_RATE"] = ExpressionConverter.ConvertO(bodyDISCOUNTRATE);
                bodypropCount++;
            }

            if (bodyDISCOUNTTYPE != null)
            {
                body["DISCOUNT_TYPE"] = ExpressionConverter.ConvertO(bodyDISCOUNTTYPE);
                bodypropCount++;
            }

            if (bodyDUNSNUMBER != null)
            {
                body["DUNS_NUMBER"] = ExpressionConverter.ConvertO(bodyDUNSNUMBER);
                bodypropCount++;
            }

            if (bodyEMAIL != null)
            {
                body["E_MAIL"] = ExpressionConverter.ConvertO(bodyEMAIL);
                bodypropCount++;
            }

            if (bodyEMAIL2 != null)
            {
                body["E_MAIL2"] = ExpressionConverter.ConvertO(bodyEMAIL2);
                bodypropCount++;
            }

            if (bodyEMAIL3 != null)
            {
                body["E_MAIL3"] = ExpressionConverter.ConvertO(bodyEMAIL3);
                bodypropCount++;
            }

            if (bodyExtraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyExtraField);
                bodypropCount++;
            }

            if (bodyFAX != null)
            {
                body["FAX"] = ExpressionConverter.ConvertO(bodyFAX);
                bodypropCount++;
            }

            if (bodyHOLDMAIL != null)
            {
                body["HOLD_MAIL"] = ExpressionConverter.ConvertO(bodyHOLDMAIL);
                bodypropCount++;
            }

            if (bodyINACTIVEFLAG != null)
            {
                body["INACTIVE_FLAG"] = ExpressionConverter.ConvertO(bodyINACTIVEFLAG);
                bodypropCount++;
            }

            if (bodyIsACCOUNTREFAutogenerate != null)
            {
                body["IsACCOUNT_REF_autogenerate"] = ExpressionConverter.ConvertO(bodyIsACCOUNTREFAutogenerate);
                bodypropCount++;
            }

            if (bodyLASTCREDITREV != null)
            {
                body["LAST_CREDIT_REV"] = ExpressionConverter.ConvertO(bodyLASTCREDITREV);
                bodypropCount++;
            }

            if (bodyNAME != null)
            {
                body["NAME"] = ExpressionConverter.ConvertO(bodyNAME);
                bodypropCount++;
            }

            if (bodyNEXTCREDITREV != null)
            {
                body["NEXT_CREDIT_REV"] = ExpressionConverter.ConvertO(bodyNEXTCREDITREV);
                bodypropCount++;
            }

            if (bodyOVERRIDEPRODUCTNOMINAL != null)
            {
                body["OVERRIDE_PRODUCT_NOMINAL"] = ExpressionConverter.ConvertO(bodyOVERRIDEPRODUCTNOMINAL);
                bodypropCount++;
            }

            if (bodyOVERRIDEPRODUCTTAX != null)
            {
                body["OVERRIDE_PRODUCT_TAX"] = ExpressionConverter.ConvertO(bodyOVERRIDEPRODUCTTAX);
                bodypropCount++;
            }

            if (bodyPAYMENTDUEDAYS != null)
            {
                body["PAYMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(bodyPAYMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodyPRICELISTREF != null)
            {
                body["PRICE_LIST_REF"] = ExpressionConverter.ConvertO(bodyPRICELISTREF);
                bodypropCount++;
            }

            if (bodyPRIORITYTRADER != null)
            {
                body["PRIORITY_TRADER"] = ExpressionConverter.ConvertO(bodyPRIORITYTRADER);
                bodypropCount++;
            }

            if (bodySENDINVOICESELECTRONICALLY != null)
            {
                body["SEND_INVOICES_ELECTRONICALLY"] = ExpressionConverter.ConvertO(bodySENDINVOICESELECTRONICALLY);
                bodypropCount++;
            }

            if (bodySENDLETTERSELECTRONICALLY != null)
            {
                body["SEND_LETTERS_ELECTRONICALLY"] = ExpressionConverter.ConvertO(bodySENDLETTERSELECTRONICALLY);
                bodypropCount++;
            }

            if (bodySETTLEMENTDISCRATE != null)
            {
                body["SETTLEMENT_DISC_RATE"] = ExpressionConverter.ConvertO(bodySETTLEMENTDISCRATE);
                bodypropCount++;
            }

            if (bodySETTLEMENTDUEDAYS != null)
            {
                body["SETTLEMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(bodySETTLEMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodyTELEPHONE != null)
            {
                body["TELEPHONE"] = ExpressionConverter.ConvertO(bodyTELEPHONE);
                bodypropCount++;
            }

            if (bodyTELEPHONE2 != null)
            {
                body["TELEPHONE_2"] = ExpressionConverter.ConvertO(bodyTELEPHONE2);
                bodypropCount++;
            }

            if (bodyTERMS != null)
            {
                body["TERMS"] = ExpressionConverter.ConvertO(bodyTERMS);
                bodypropCount++;
            }

            if (bodyTERMSAGREEDFLAG != null)
            {
                body["TERMS_AGREED_FLAG"] = ExpressionConverter.ConvertO(bodyTERMSAGREEDFLAG);
                bodypropCount++;
            }

            if (bodyTRADECONTACT != null)
            {
                body["TRADE_CONTACT"] = ExpressionConverter.ConvertO(bodyTRADECONTACT);
                bodypropCount++;
            }

            if (bodyVATREGNUMBER != null)
            {
                body["VAT_REG_NUMBER"] = ExpressionConverter.ConvertO(bodyVATREGNUMBER);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50UKCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> SAGE50UKCreateNewSalesOrder(Expression<Func<string>> bodyACCOUNTREF = null, Expression<Func<string>> bodyADDRESS1 = null, Expression<Func<string>> bodyADDRESS2 = null, Expression<Func<string>> bodyADDRESS3 = null, Expression<Func<string>> bodyADDRESS4 = null, Expression<Func<string>> bodyADDRESS5 = null, Expression<Func<int>> bodyAMOUNTPREPAID = null, Expression<Func<string>> bodyANALYSIS1 = null, Expression<Func<string>> bodyANALYSIS2 = null, Expression<Func<string>> bodyANALYSIS3 = null, Expression<Func<int>> bodyCARRDEPTNUMBER = null, Expression<Func<int>> bodyCARRNET = null, Expression<Func<string>> bodyCARRNOMCODE = null, Expression<Func<int>> bodyCARRTAX = null, Expression<Func<int>> bodyCARRTAXCODE = null, Expression<Func<string>> bodyCONSIGNMENTREF = null, Expression<Func<string>> bodyCONTACTNAME = null, Expression<Func<int>> bodyCOURIER = null, Expression<Func<int>> bodyCURRENCY = null, Expression<Func<int>> bodyCUSTDISCRATE = null, Expression<Func<string>> bodyCUSTORDERNUMBER = null, Expression<Func<string>> bodyCUSTTELNUMBER = null, Expression<Func<int>> bodyDEFTAXCODE = null, Expression<Func<bool>> bodyDELETEDFLAG = null, Expression<Func<string>> bodyDELIVERYNAME = null, Expression<Func<string>> bodyDELADDRESS1 = null, Expression<Func<string>> bodyDELADDRESS2 = null, Expression<Func<string>> bodyDELADDRESS3 = null, Expression<Func<string>> bodyDELADDRESS4 = null, Expression<Func<string>> bodyDELADDRESS5 = null, Expression<Func<string>> bodyDESPATCHDATE = null, Expression<Func<string>> bodyDUNSNUMBER = null, Expression<Func<int>> bodyGLOBALDEPTNUMBER = null, Expression<Func<string>> bodyGLOBALDETAILS = null, Expression<Func<string>> bodyGLOBALNOMCODE = null, Expression<Func<int>> bodyGLOBALTAXCODE = null, Expression<Func<string>> bodyINVOICENUMBER = null, Expression<Func<string>> bodyNAME = null, Expression<Func<string>> bodyORDERDATE = null, Expression<Func<int>> bodyORDERNUMBER = null, Expression<Func<int>> bodyORDERTYPE = null, Expression<Func<int>> bodySETTLEMENTDISCRATE = null, Expression<Func<int>> bodySETTLEMENTDUEDAYS = null, Expression<Func<bodySalesOrderLineItemInputItem222[]>> bodySalesOrderLineItem = null)
        {
            var apiCallPath = "/api/v1/sage50uk/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyACCOUNTREF != null)
            {
                body["ACCOUNT_REF"] = ExpressionConverter.ConvertO(bodyACCOUNTREF);
                bodypropCount++;
            }

            if (bodyADDRESS1 != null)
            {
                body["ADDRESS_1"] = ExpressionConverter.ConvertO(bodyADDRESS1);
                bodypropCount++;
            }

            if (bodyADDRESS2 != null)
            {
                body["ADDRESS_2"] = ExpressionConverter.ConvertO(bodyADDRESS2);
                bodypropCount++;
            }

            if (bodyADDRESS3 != null)
            {
                body["ADDRESS_3"] = ExpressionConverter.ConvertO(bodyADDRESS3);
                bodypropCount++;
            }

            if (bodyADDRESS4 != null)
            {
                body["ADDRESS_4"] = ExpressionConverter.ConvertO(bodyADDRESS4);
                bodypropCount++;
            }

            if (bodyADDRESS5 != null)
            {
                body["ADDRESS_5"] = ExpressionConverter.ConvertO(bodyADDRESS5);
                bodypropCount++;
            }

            if (bodyAMOUNTPREPAID != null)
            {
                body["AMOUNT_PREPAID"] = ExpressionConverter.ConvertO(bodyAMOUNTPREPAID);
                bodypropCount++;
            }

            if (bodyANALYSIS1 != null)
            {
                body["ANALYSIS_1"] = ExpressionConverter.ConvertO(bodyANALYSIS1);
                bodypropCount++;
            }

            if (bodyANALYSIS2 != null)
            {
                body["ANALYSIS_2"] = ExpressionConverter.ConvertO(bodyANALYSIS2);
                bodypropCount++;
            }

            if (bodyANALYSIS3 != null)
            {
                body["ANALYSIS_3"] = ExpressionConverter.ConvertO(bodyANALYSIS3);
                bodypropCount++;
            }

            if (bodyCARRDEPTNUMBER != null)
            {
                body["CARR_DEPT_NUMBER"] = ExpressionConverter.ConvertO(bodyCARRDEPTNUMBER);
                bodypropCount++;
            }

            if (bodyCARRNET != null)
            {
                body["CARR_NET"] = ExpressionConverter.ConvertO(bodyCARRNET);
                bodypropCount++;
            }

            if (bodyCARRNOMCODE != null)
            {
                body["CARR_NOM_CODE"] = ExpressionConverter.ConvertO(bodyCARRNOMCODE);
                bodypropCount++;
            }

            if (bodyCARRTAX != null)
            {
                body["CARR_TAX"] = ExpressionConverter.ConvertO(bodyCARRTAX);
                bodypropCount++;
            }

            if (bodyCARRTAXCODE != null)
            {
                body["CARR_TAX_CODE"] = ExpressionConverter.ConvertO(bodyCARRTAXCODE);
                bodypropCount++;
            }

            if (bodyCONSIGNMENTREF != null)
            {
                body["CONSIGNMENT_REF"] = ExpressionConverter.ConvertO(bodyCONSIGNMENTREF);
                bodypropCount++;
            }

            if (bodyCONTACTNAME != null)
            {
                body["CONTACT_NAME"] = ExpressionConverter.ConvertO(bodyCONTACTNAME);
                bodypropCount++;
            }

            if (bodyCOURIER != null)
            {
                body["COURIER"] = ExpressionConverter.ConvertO(bodyCOURIER);
                bodypropCount++;
            }

            if (bodyCURRENCY != null)
            {
                body["CURRENCY"] = ExpressionConverter.ConvertO(bodyCURRENCY);
                bodypropCount++;
            }

            if (bodyCUSTDISCRATE != null)
            {
                body["CUST_DISC_RATE"] = ExpressionConverter.ConvertO(bodyCUSTDISCRATE);
                bodypropCount++;
            }

            if (bodyCUSTORDERNUMBER != null)
            {
                body["CUST_ORDER_NUMBER"] = ExpressionConverter.ConvertO(bodyCUSTORDERNUMBER);
                bodypropCount++;
            }

            if (bodyCUSTTELNUMBER != null)
            {
                body["CUST_TEL_NUMBER"] = ExpressionConverter.ConvertO(bodyCUSTTELNUMBER);
                bodypropCount++;
            }

            if (bodyDEFTAXCODE != null)
            {
                body["DEF_TAX_CODE"] = ExpressionConverter.ConvertO(bodyDEFTAXCODE);
                bodypropCount++;
            }

            if (bodyDELETEDFLAG != null)
            {
                body["DELETED_FLAG"] = ExpressionConverter.ConvertO(bodyDELETEDFLAG);
                bodypropCount++;
            }

            if (bodyDELIVERYNAME != null)
            {
                body["DELIVERY_NAME"] = ExpressionConverter.ConvertO(bodyDELIVERYNAME);
                bodypropCount++;
            }

            if (bodyDELADDRESS1 != null)
            {
                body["DEL_ADDRESS_1"] = ExpressionConverter.ConvertO(bodyDELADDRESS1);
                bodypropCount++;
            }

            if (bodyDELADDRESS2 != null)
            {
                body["DEL_ADDRESS_2"] = ExpressionConverter.ConvertO(bodyDELADDRESS2);
                bodypropCount++;
            }

            if (bodyDELADDRESS3 != null)
            {
                body["DEL_ADDRESS_3"] = ExpressionConverter.ConvertO(bodyDELADDRESS3);
                bodypropCount++;
            }

            if (bodyDELADDRESS4 != null)
            {
                body["DEL_ADDRESS_4"] = ExpressionConverter.ConvertO(bodyDELADDRESS4);
                bodypropCount++;
            }

            if (bodyDELADDRESS5 != null)
            {
                body["DEL_ADDRESS_5"] = ExpressionConverter.ConvertO(bodyDELADDRESS5);
                bodypropCount++;
            }

            if (bodyDESPATCHDATE != null)
            {
                body["DESPATCH_DATE"] = ExpressionConverter.ConvertO(bodyDESPATCHDATE);
                bodypropCount++;
            }

            if (bodyDUNSNUMBER != null)
            {
                body["DUNS_NUMBER"] = ExpressionConverter.ConvertO(bodyDUNSNUMBER);
                bodypropCount++;
            }

            if (bodyGLOBALDEPTNUMBER != null)
            {
                body["GLOBAL_DEPT_NUMBER"] = ExpressionConverter.ConvertO(bodyGLOBALDEPTNUMBER);
                bodypropCount++;
            }

            if (bodyGLOBALDETAILS != null)
            {
                body["GLOBAL_DETAILS"] = ExpressionConverter.ConvertO(bodyGLOBALDETAILS);
                bodypropCount++;
            }

            if (bodyGLOBALNOMCODE != null)
            {
                body["GLOBAL_NOM_CODE"] = ExpressionConverter.ConvertO(bodyGLOBALNOMCODE);
                bodypropCount++;
            }

            if (bodyGLOBALTAXCODE != null)
            {
                body["GLOBAL_TAX_CODE"] = ExpressionConverter.ConvertO(bodyGLOBALTAXCODE);
                bodypropCount++;
            }

            if (bodyINVOICENUMBER != null)
            {
                body["INVOICE_NUMBER"] = ExpressionConverter.ConvertO(bodyINVOICENUMBER);
                bodypropCount++;
            }

            if (bodyNAME != null)
            {
                body["NAME"] = ExpressionConverter.ConvertO(bodyNAME);
                bodypropCount++;
            }

            if (bodyORDERDATE != null)
            {
                body["ORDER_DATE"] = ExpressionConverter.ConvertO(bodyORDERDATE);
                bodypropCount++;
            }

            if (bodyORDERNUMBER != null)
            {
                body["ORDER_NUMBER"] = ExpressionConverter.ConvertO(bodyORDERNUMBER);
                bodypropCount++;
            }

            if (bodyORDERTYPE != null)
            {
                body["ORDER_TYPE"] = ExpressionConverter.ConvertO(bodyORDERTYPE);
                bodypropCount++;
            }

            if (bodySETTLEMENTDISCRATE != null)
            {
                body["SETTLEMENT_DISC_RATE"] = ExpressionConverter.ConvertO(bodySETTLEMENTDISCRATE);
                bodypropCount++;
            }

            if (bodySETTLEMENTDUEDAYS != null)
            {
                body["SETTLEMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(bodySETTLEMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodySalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodySalesOrderLineItem);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50UKCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> SAGE50USCreateNewCustomer(Expression<Func<string>> bodyAccountNumber = null, Expression<Func<string>> bodyBillingCity = null, Expression<Func<string>> bodyBillingCountry = null, Expression<Func<string>> bodyBillingLastName = null, Expression<Func<string>> bodyBillingName = null, Expression<Func<string>> bodyBillingPostalCode = null, Expression<Func<string>> bodyBillingState = null, Expression<Func<string>> bodyBillingStreet = null, Expression<Func<bool>> bodyCCSalesRepresentative = null, Expression<Func<bool>> bodyChargeFinanceCharges = null, Expression<Func<string>> bodyContactName = null, Expression<Func<int>> bodyCreditLimit = null, Expression<Func<int>> bodyCreditStatus = null, Expression<Func<string>> bodyCustomFieldValue1 = null, Expression<Func<string>> bodyCustomFieldValue2 = null, Expression<Func<string>> bodyCustomFieldValue3 = null, Expression<Func<string>> bodyCustomFieldValue4 = null, Expression<Func<string>> bodyCustomFieldValue5 = null, Expression<Func<string>> bodyCustomerGUID = null, Expression<Func<string>> bodyCustomerID = null, Expression<Func<int>> bodyCustomerBalance = null, Expression<Func<string>> bodyCustomerSinceDate = null, Expression<Func<string>> bodyCustomerType = null, Expression<Func<int>> bodyDiscountDays = null, Expression<Func<int>> bodyDiscountPercent = null, Expression<Func<int>> bodyDueDays = null, Expression<Func<string>> bodyEMailAddress = null, Expression<Func<string>> bodyFaxNumber = null, Expression<Func<int>> bodyFormDeliveryMethod = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyPhoneNo1 = null, Expression<Func<string>> bodyPhoneNo2 = null, Expression<Func<int>> bodyPricingLevel = null, Expression<Func<string>> bodySalesRepresentativeID = null, Expression<Func<string>> bodySalesTaxCode = null, Expression<Func<string>> bodyShippingCity = null, Expression<Func<string>> bodyShippingCountry = null, Expression<Func<string>> bodyShippingPostalCode = null, Expression<Func<string>> bodyShippingState = null, Expression<Func<string>> bodyShippingStreet = null, Expression<Func<bool>> bodyTermsType = null, Expression<Func<bool>> bodyUseCODTerms = null, Expression<Func<bool>> bodyUseDueMonthEndTerms = null, Expression<Func<bool>> bodyUsePrepaidTerms = null, Expression<Func<bool>> bodyUseStandardTerms = null, Expression<Func<bool>> bodyisInactive = null)
        {
            var apiCallPath = "/api/v1/sage50us/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccountNumber != null)
            {
                body["Account_Number"] = ExpressionConverter.ConvertO(bodyAccountNumber);
                bodypropCount++;
            }

            if (bodyBillingCity != null)
            {
                body["BillingCity"] = ExpressionConverter.ConvertO(bodyBillingCity);
                bodypropCount++;
            }

            if (bodyBillingCountry != null)
            {
                body["BillingCountry"] = ExpressionConverter.ConvertO(bodyBillingCountry);
                bodypropCount++;
            }

            if (bodyBillingLastName != null)
            {
                body["BillingLastName"] = ExpressionConverter.ConvertO(bodyBillingLastName);
                bodypropCount++;
            }

            if (bodyBillingName != null)
            {
                body["BillingName"] = ExpressionConverter.ConvertO(bodyBillingName);
                bodypropCount++;
            }

            if (bodyBillingPostalCode != null)
            {
                body["BillingPostalCode"] = ExpressionConverter.ConvertO(bodyBillingPostalCode);
                bodypropCount++;
            }

            if (bodyBillingState != null)
            {
                body["BillingState"] = ExpressionConverter.ConvertO(bodyBillingState);
                bodypropCount++;
            }

            if (bodyBillingStreet != null)
            {
                body["BillingStreet"] = ExpressionConverter.ConvertO(bodyBillingStreet);
                bodypropCount++;
            }

            if (bodyCCSalesRepresentative != null)
            {
                body["CC_Sales_Representative"] = ExpressionConverter.ConvertO(bodyCCSalesRepresentative);
                bodypropCount++;
            }

            if (bodyChargeFinanceCharges != null)
            {
                body["Charge_Finance_Charges"] = ExpressionConverter.ConvertO(bodyChargeFinanceCharges);
                bodypropCount++;
            }

            if (bodyContactName != null)
            {
                body["ContactName"] = ExpressionConverter.ConvertO(bodyContactName);
                bodypropCount++;
            }

            if (bodyCreditLimit != null)
            {
                body["Credit_Limit"] = ExpressionConverter.ConvertO(bodyCreditLimit);
                bodypropCount++;
            }

            if (bodyCreditStatus != null)
            {
                body["Credit_Status"] = ExpressionConverter.ConvertO(bodyCreditStatus);
                bodypropCount++;
            }

            if (bodyCustomFieldValue1 != null)
            {
                body["CustomFieldValue1"] = ExpressionConverter.ConvertO(bodyCustomFieldValue1);
                bodypropCount++;
            }

            if (bodyCustomFieldValue2 != null)
            {
                body["CustomFieldValue2"] = ExpressionConverter.ConvertO(bodyCustomFieldValue2);
                bodypropCount++;
            }

            if (bodyCustomFieldValue3 != null)
            {
                body["CustomFieldValue3"] = ExpressionConverter.ConvertO(bodyCustomFieldValue3);
                bodypropCount++;
            }

            if (bodyCustomFieldValue4 != null)
            {
                body["CustomFieldValue4"] = ExpressionConverter.ConvertO(bodyCustomFieldValue4);
                bodypropCount++;
            }

            if (bodyCustomFieldValue5 != null)
            {
                body["CustomFieldValue5"] = ExpressionConverter.ConvertO(bodyCustomFieldValue5);
                bodypropCount++;
            }

            if (bodyCustomerGUID != null)
            {
                body["CustomerGUID"] = ExpressionConverter.ConvertO(bodyCustomerGUID);
                bodypropCount++;
            }

            if (bodyCustomerID != null)
            {
                body["CustomerID"] = ExpressionConverter.ConvertO(bodyCustomerID);
                bodypropCount++;
            }

            if (bodyCustomerBalance != null)
            {
                body["Customer_Balance"] = ExpressionConverter.ConvertO(bodyCustomerBalance);
                bodypropCount++;
            }

            if (bodyCustomerSinceDate != null)
            {
                body["Customer_Since_Date"] = ExpressionConverter.ConvertO(bodyCustomerSinceDate);
                bodypropCount++;
            }

            if (bodyCustomerType != null)
            {
                body["Customer_Type"] = ExpressionConverter.ConvertO(bodyCustomerType);
                bodypropCount++;
            }

            if (bodyDiscountDays != null)
            {
                body["Discount_Days"] = ExpressionConverter.ConvertO(bodyDiscountDays);
                bodypropCount++;
            }

            if (bodyDiscountPercent != null)
            {
                body["Discount_Percent"] = ExpressionConverter.ConvertO(bodyDiscountPercent);
                bodypropCount++;
            }

            if (bodyDueDays != null)
            {
                body["Due_Days"] = ExpressionConverter.ConvertO(bodyDueDays);
                bodypropCount++;
            }

            if (bodyEMailAddress != null)
            {
                body["EMail_Address"] = ExpressionConverter.ConvertO(bodyEMailAddress);
                bodypropCount++;
            }

            if (bodyFaxNumber != null)
            {
                body["FaxNumber"] = ExpressionConverter.ConvertO(bodyFaxNumber);
                bodypropCount++;
            }

            if (bodyFormDeliveryMethod != null)
            {
                body["Form_Delivery_Method"] = ExpressionConverter.ConvertO(bodyFormDeliveryMethod);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyPhoneNo1 != null)
            {
                body["PhoneNo1"] = ExpressionConverter.ConvertO(bodyPhoneNo1);
                bodypropCount++;
            }

            if (bodyPhoneNo2 != null)
            {
                body["PhoneNo2"] = ExpressionConverter.ConvertO(bodyPhoneNo2);
                bodypropCount++;
            }

            if (bodyPricingLevel != null)
            {
                body["Pricing_Level"] = ExpressionConverter.ConvertO(bodyPricingLevel);
                bodypropCount++;
            }

            if (bodySalesRepresentativeID != null)
            {
                body["Sales_Representative_ID"] = ExpressionConverter.ConvertO(bodySalesRepresentativeID);
                bodypropCount++;
            }

            if (bodySalesTaxCode != null)
            {
                body["Sales_Tax_Code"] = ExpressionConverter.ConvertO(bodySalesTaxCode);
                bodypropCount++;
            }

            if (bodyShippingCity != null)
            {
                body["ShippingCity"] = ExpressionConverter.ConvertO(bodyShippingCity);
                bodypropCount++;
            }

            if (bodyShippingCountry != null)
            {
                body["ShippingCountry"] = ExpressionConverter.ConvertO(bodyShippingCountry);
                bodypropCount++;
            }

            if (bodyShippingPostalCode != null)
            {
                body["ShippingPostalCode"] = ExpressionConverter.ConvertO(bodyShippingPostalCode);
                bodypropCount++;
            }

            if (bodyShippingState != null)
            {
                body["ShippingState"] = ExpressionConverter.ConvertO(bodyShippingState);
                bodypropCount++;
            }

            if (bodyShippingStreet != null)
            {
                body["ShippingStreet"] = ExpressionConverter.ConvertO(bodyShippingStreet);
                bodypropCount++;
            }

            if (bodyTermsType != null)
            {
                body["Terms_Type"] = ExpressionConverter.ConvertO(bodyTermsType);
                bodypropCount++;
            }

            if (bodyUseCODTerms != null)
            {
                body["Use_COD_Terms"] = ExpressionConverter.ConvertO(bodyUseCODTerms);
                bodypropCount++;
            }

            if (bodyUseDueMonthEndTerms != null)
            {
                body["Use_Due_Month_End_Terms"] = ExpressionConverter.ConvertO(bodyUseDueMonthEndTerms);
                bodypropCount++;
            }

            if (bodyUsePrepaidTerms != null)
            {
                body["Use_Prepaid_Terms"] = ExpressionConverter.ConvertO(bodyUsePrepaidTerms);
                bodypropCount++;
            }

            if (bodyUseStandardTerms != null)
            {
                body["Use_Standard_Terms"] = ExpressionConverter.ConvertO(bodyUseStandardTerms);
                bodypropCount++;
            }

            if (bodyisInactive != null)
            {
                body["isInactive"] = ExpressionConverter.ConvertO(bodyisInactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50USCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> SAGE50USCreateNewSalesOrder(Expression<Func<string>> bodyAccountsReceivableAccount = null, Expression<Func<string>> bodyAccountsReceivableAcctGUID = null, Expression<Func<int>> bodyAccountsReceivableAmount = null, Expression<Func<bool>> bodyClosed = null, Expression<Func<string>> bodyCustomerID = null, Expression<Func<string>> bodyCustomerPO = null, Expression<Func<string>> bodyDate = null, Expression<Func<int>> bodyDiscountAmount = null, Expression<Func<string>> bodyDisplayedTerms = null, Expression<Func<bool>> bodyDropShip = null, Expression<Func<string>> bodyGUID = null, Expression<Func<bool>> bodyNotePrintsAfterLineItems = null, Expression<Func<bool>> bodyProposal = null, Expression<Func<bool>> bodyProposalAccepted = null, Expression<Func<bodySalesOrderLineItemInputItem2222[]>> bodySalesOrderLineItem = null, Expression<Func<string>> bodySalesOrderNumber = null, Expression<Func<string>> bodySalesRepresentativeGUID = null, Expression<Func<string>> bodySalesRepresentativeID = null, Expression<Func<string>> bodyShipAddressCity = null, Expression<Func<string>> bodyShipAddressCountry = null, Expression<Func<string>> bodyShipAddressLine1 = null, Expression<Func<string>> bodyShipAddressLine2 = null, Expression<Func<string>> bodyShipAddressName = null, Expression<Func<string>> bodyShipAddressState = null, Expression<Func<string>> bodyShipAddressZipCode = null, Expression<Func<string>> bodyShipBy = null, Expression<Func<string>> bodyShipVIA = null, Expression<Func<bool>> bodyStatementNotePrintsBeforeInvRef = null)
        {
            var apiCallPath = "/api/v1/sage50us/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAccountsReceivableAccount != null)
            {
                body["Accounts_Receivable_Account"] = ExpressionConverter.ConvertO(bodyAccountsReceivableAccount);
                bodypropCount++;
            }

            if (bodyAccountsReceivableAcctGUID != null)
            {
                body["Accounts_Receivable_Acct_GUID"] = ExpressionConverter.ConvertO(bodyAccountsReceivableAcctGUID);
                bodypropCount++;
            }

            if (bodyAccountsReceivableAmount != null)
            {
                body["Accounts_Receivable_Amount"] = ExpressionConverter.ConvertO(bodyAccountsReceivableAmount);
                bodypropCount++;
            }

            if (bodyClosed != null)
            {
                body["Closed"] = ExpressionConverter.ConvertO(bodyClosed);
                bodypropCount++;
            }

            if (bodyCustomerID != null)
            {
                body["Customer_ID"] = ExpressionConverter.ConvertO(bodyCustomerID);
                bodypropCount++;
            }

            if (bodyCustomerPO != null)
            {
                body["Customer_PO"] = ExpressionConverter.ConvertO(bodyCustomerPO);
                bodypropCount++;
            }

            if (bodyDate != null)
            {
                body["Date"] = ExpressionConverter.ConvertO(bodyDate);
                bodypropCount++;
            }

            if (bodyDiscountAmount != null)
            {
                body["Discount_Amount"] = ExpressionConverter.ConvertO(bodyDiscountAmount);
                bodypropCount++;
            }

            if (bodyDisplayedTerms != null)
            {
                body["Displayed_Terms"] = ExpressionConverter.ConvertO(bodyDisplayedTerms);
                bodypropCount++;
            }

            if (bodyDropShip != null)
            {
                body["Drop_Ship"] = ExpressionConverter.ConvertO(bodyDropShip);
                bodypropCount++;
            }

            if (bodyGUID != null)
            {
                body["GUID"] = ExpressionConverter.ConvertO(bodyGUID);
                bodypropCount++;
            }

            if (bodyNotePrintsAfterLineItems != null)
            {
                body["Note_Prints_After_Line_Items"] = ExpressionConverter.ConvertO(bodyNotePrintsAfterLineItems);
                bodypropCount++;
            }

            if (bodyProposal != null)
            {
                body["Proposal"] = ExpressionConverter.ConvertO(bodyProposal);
                bodypropCount++;
            }

            if (bodyProposalAccepted != null)
            {
                body["ProposalAccepted"] = ExpressionConverter.ConvertO(bodyProposalAccepted);
                bodypropCount++;
            }

            if (bodySalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodySalesOrderLineItem);
                bodypropCount++;
            }

            if (bodySalesOrderNumber != null)
            {
                body["Sales_Order_Number"] = ExpressionConverter.ConvertO(bodySalesOrderNumber);
                bodypropCount++;
            }

            if (bodySalesRepresentativeGUID != null)
            {
                body["Sales_Representative_GUID"] = ExpressionConverter.ConvertO(bodySalesRepresentativeGUID);
                bodypropCount++;
            }

            if (bodySalesRepresentativeID != null)
            {
                body["Sales_Representative_ID"] = ExpressionConverter.ConvertO(bodySalesRepresentativeID);
                bodypropCount++;
            }

            if (bodyShipAddressCity != null)
            {
                body["ShipAddressCity"] = ExpressionConverter.ConvertO(bodyShipAddressCity);
                bodypropCount++;
            }

            if (bodyShipAddressCountry != null)
            {
                body["ShipAddressCountry"] = ExpressionConverter.ConvertO(bodyShipAddressCountry);
                bodypropCount++;
            }

            if (bodyShipAddressLine1 != null)
            {
                body["ShipAddressLine1"] = ExpressionConverter.ConvertO(bodyShipAddressLine1);
                bodypropCount++;
            }

            if (bodyShipAddressLine2 != null)
            {
                body["ShipAddressLine2"] = ExpressionConverter.ConvertO(bodyShipAddressLine2);
                bodypropCount++;
            }

            if (bodyShipAddressName != null)
            {
                body["ShipAddressName"] = ExpressionConverter.ConvertO(bodyShipAddressName);
                bodypropCount++;
            }

            if (bodyShipAddressState != null)
            {
                body["ShipAddressState"] = ExpressionConverter.ConvertO(bodyShipAddressState);
                bodypropCount++;
            }

            if (bodyShipAddressZipCode != null)
            {
                body["ShipAddressZipCode"] = ExpressionConverter.ConvertO(bodyShipAddressZipCode);
                bodypropCount++;
            }

            if (bodyShipBy != null)
            {
                body["Ship_By"] = ExpressionConverter.ConvertO(bodyShipBy);
                bodypropCount++;
            }

            if (bodyShipVIA != null)
            {
                body["Ship_VIA"] = ExpressionConverter.ConvertO(bodyShipVIA);
                bodypropCount++;
            }

            if (bodyStatementNotePrintsBeforeInvRef != null)
            {
                body["Statement_Note_Prints_Before_Inv_Ref"] = ExpressionConverter.ConvertO(bodyStatementNotePrintsBeforeInvRef);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50USCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> SAPB1CreateNewCustomer(Expression<Func<string>> bodyAddress = null, Expression<Func<string>> bodyBillingAddressName = null, Expression<Func<string>> bodyBillingBlock = null, Expression<Func<string>> bodyBillingCity = null, Expression<Func<string>> bodyBillingCountry = null, Expression<Func<string>> bodyBillingState = null, Expression<Func<string>> bodyBillingStreet = null, Expression<Func<string>> bodyBillingZipCode = null, Expression<Func<string>> bodyCardCode = null, Expression<Func<string>> bodyCardName = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyContactPerson = null, Expression<Func<string>> bodyCountry = null, Expression<Func<string>> bodyCounty = null, Expression<Func<string>> bodyCurrency = null, Expression<Func<string>> bodyEmailAddress = null, Expression<Func<string>> bodyExtraField = null, Expression<Func<string>> bodyFax = null, Expression<Func<string>> bodyFederalTaxID = null, Expression<Func<string>> bodyFreeText = null, Expression<Func<int>> bodyGroupCode = null, Expression<Func<string>> bodyMailAddress = null, Expression<Func<string>> bodyMailCity = null, Expression<Func<string>> bodyMailCountry = null, Expression<Func<string>> bodyMailCounty = null, Expression<Func<string>> bodyMailZipCode = null, Expression<Func<string>> bodyNotes = null, Expression<Func<string>> bodyPhone1 = null, Expression<Func<string>> bodyPhone2 = null, Expression<Func<int>> bodySalesPersonCode = null, Expression<Func<int>> bodySeries = null, Expression<Func<string>> bodyShippingAddressName = null, Expression<Func<string>> bodyShippingBlock = null, Expression<Func<string>> bodyShippingCity = null, Expression<Func<string>> bodyShippingCountry = null, Expression<Func<string>> bodyShippingState = null, Expression<Func<string>> bodyShippingStreet = null, Expression<Func<string>> bodyShippingZipCode = null, Expression<Func<string>> bodyWebSite = null, Expression<Func<string>> bodyZipCode = null, Expression<Func<bodylstContactEmployeesInputItem[]>> bodylstContactEmployees = null)
        {
            var apiCallPath = "/api/v1/sapb1/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAddress != null)
            {
                body["Address"] = ExpressionConverter.ConvertO(bodyAddress);
                bodypropCount++;
            }

            if (bodyBillingAddressName != null)
            {
                body["BillingAddressName"] = ExpressionConverter.ConvertO(bodyBillingAddressName);
                bodypropCount++;
            }

            if (bodyBillingBlock != null)
            {
                body["BillingBlock"] = ExpressionConverter.ConvertO(bodyBillingBlock);
                bodypropCount++;
            }

            if (bodyBillingCity != null)
            {
                body["BillingCity"] = ExpressionConverter.ConvertO(bodyBillingCity);
                bodypropCount++;
            }

            if (bodyBillingCountry != null)
            {
                body["BillingCountry"] = ExpressionConverter.ConvertO(bodyBillingCountry);
                bodypropCount++;
            }

            if (bodyBillingState != null)
            {
                body["BillingState"] = ExpressionConverter.ConvertO(bodyBillingState);
                bodypropCount++;
            }

            if (bodyBillingStreet != null)
            {
                body["BillingStreet"] = ExpressionConverter.ConvertO(bodyBillingStreet);
                bodypropCount++;
            }

            if (bodyBillingZipCode != null)
            {
                body["BillingZipCode"] = ExpressionConverter.ConvertO(bodyBillingZipCode);
                bodypropCount++;
            }

            if (bodyCardCode != null)
            {
                body["CardCode"] = ExpressionConverter.ConvertO(bodyCardCode);
                bodypropCount++;
            }

            if (bodyCardName != null)
            {
                body["CardName"] = ExpressionConverter.ConvertO(bodyCardName);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyContactPerson != null)
            {
                body["ContactPerson"] = ExpressionConverter.ConvertO(bodyContactPerson);
                bodypropCount++;
            }

            if (bodyCountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodyCountry);
                bodypropCount++;
            }

            if (bodyCounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodyCounty);
                bodypropCount++;
            }

            if (bodyCurrency != null)
            {
                body["Currency"] = ExpressionConverter.ConvertO(bodyCurrency);
                bodypropCount++;
            }

            if (bodyEmailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyEmailAddress);
                bodypropCount++;
            }

            if (bodyExtraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyExtraField);
                bodypropCount++;
            }

            if (bodyFax != null)
            {
                body["Fax"] = ExpressionConverter.ConvertO(bodyFax);
                bodypropCount++;
            }

            if (bodyFederalTaxID != null)
            {
                body["FederalTaxID"] = ExpressionConverter.ConvertO(bodyFederalTaxID);
                bodypropCount++;
            }

            if (bodyFreeText != null)
            {
                body["FreeText"] = ExpressionConverter.ConvertO(bodyFreeText);
                bodypropCount++;
            }

            if (bodyGroupCode != null)
            {
                body["GroupCode"] = ExpressionConverter.ConvertO(bodyGroupCode);
                bodypropCount++;
            }

            if (bodyMailAddress != null)
            {
                body["MailAddress"] = ExpressionConverter.ConvertO(bodyMailAddress);
                bodypropCount++;
            }

            if (bodyMailCity != null)
            {
                body["MailCity"] = ExpressionConverter.ConvertO(bodyMailCity);
                bodypropCount++;
            }

            if (bodyMailCountry != null)
            {
                body["MailCountry"] = ExpressionConverter.ConvertO(bodyMailCountry);
                bodypropCount++;
            }

            if (bodyMailCounty != null)
            {
                body["MailCounty"] = ExpressionConverter.ConvertO(bodyMailCounty);
                bodypropCount++;
            }

            if (bodyMailZipCode != null)
            {
                body["MailZipCode"] = ExpressionConverter.ConvertO(bodyMailZipCode);
                bodypropCount++;
            }

            if (bodyNotes != null)
            {
                body["Notes"] = ExpressionConverter.ConvertO(bodyNotes);
                bodypropCount++;
            }

            if (bodyPhone1 != null)
            {
                body["Phone1"] = ExpressionConverter.ConvertO(bodyPhone1);
                bodypropCount++;
            }

            if (bodyPhone2 != null)
            {
                body["Phone2"] = ExpressionConverter.ConvertO(bodyPhone2);
                bodypropCount++;
            }

            if (bodySalesPersonCode != null)
            {
                body["SalesPersonCode"] = ExpressionConverter.ConvertO(bodySalesPersonCode);
                bodypropCount++;
            }

            if (bodySeries != null)
            {
                body["Series"] = ExpressionConverter.ConvertO(bodySeries);
                bodypropCount++;
            }

            if (bodyShippingAddressName != null)
            {
                body["ShippingAddressName"] = ExpressionConverter.ConvertO(bodyShippingAddressName);
                bodypropCount++;
            }

            if (bodyShippingBlock != null)
            {
                body["ShippingBlock"] = ExpressionConverter.ConvertO(bodyShippingBlock);
                bodypropCount++;
            }

            if (bodyShippingCity != null)
            {
                body["ShippingCity"] = ExpressionConverter.ConvertO(bodyShippingCity);
                bodypropCount++;
            }

            if (bodyShippingCountry != null)
            {
                body["ShippingCountry"] = ExpressionConverter.ConvertO(bodyShippingCountry);
                bodypropCount++;
            }

            if (bodyShippingState != null)
            {
                body["ShippingState"] = ExpressionConverter.ConvertO(bodyShippingState);
                bodypropCount++;
            }

            if (bodyShippingStreet != null)
            {
                body["ShippingStreet"] = ExpressionConverter.ConvertO(bodyShippingStreet);
                bodypropCount++;
            }

            if (bodyShippingZipCode != null)
            {
                body["ShippingZipCode"] = ExpressionConverter.ConvertO(bodyShippingZipCode);
                bodypropCount++;
            }

            if (bodyWebSite != null)
            {
                body["WebSite"] = ExpressionConverter.ConvertO(bodyWebSite);
                bodypropCount++;
            }

            if (bodyZipCode != null)
            {
                body["ZipCode"] = ExpressionConverter.ConvertO(bodyZipCode);
                bodypropCount++;
            }

            if (bodylstContactEmployees != null)
            {
                body["lstContactEmployees"] = ExpressionConverter.ConvertO(bodylstContactEmployees);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAPB1CreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> SAPB1CreateNewSalesOrder(Expression<Func<string>> bodyCardCode = null, Expression<Func<string>> bodyDocDate = null, Expression<Func<string>> bodyDocDueDate = null, Expression<Func<int>> bodyDocNum = null, Expression<Func<bodySalesOrderLineItemInputItem22222[]>> bodySalesOrderLineItem = null, Expression<Func<int>> bodySeries = null, Expression<Func<string>> bodyTaxDate = null)
        {
            var apiCallPath = "/api/v1/sapb1/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyCardCode != null)
            {
                body["CardCode"] = ExpressionConverter.ConvertO(bodyCardCode);
                bodypropCount++;
            }

            if (bodyDocDate != null)
            {
                body["DocDate"] = ExpressionConverter.ConvertO(bodyDocDate);
                bodypropCount++;
            }

            if (bodyDocDueDate != null)
            {
                body["DocDueDate"] = ExpressionConverter.ConvertO(bodyDocDueDate);
                bodypropCount++;
            }

            if (bodyDocNum != null)
            {
                body["DocNum"] = ExpressionConverter.ConvertO(bodyDocNum);
                bodypropCount++;
            }

            if (bodySalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodySalesOrderLineItem);
                bodypropCount++;
            }

            if (bodySeries != null)
            {
                body["Series"] = ExpressionConverter.ConvertO(bodySeries);
                bodypropCount++;
            }

            if (bodyTaxDate != null)
            {
                body["TaxDate"] = ExpressionConverter.ConvertO(bodyTaxDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAPB1CreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> SYSPROCreateNewCustomer(Expression<Func<string>> bodyAddTelephone = null, Expression<Func<string>> bodyAltMethodFlag = null, Expression<Func<string>> bodyApplyLineDisc = null, Expression<Func<string>> bodyApplyOrdDisc = null, Expression<Func<string>> bodyArStatementNo = null, Expression<Func<string>> bodyArea = null, Expression<Func<string>> bodyBackOrdReqd = null, Expression<Func<string>> bodyBalanceType = null, Expression<Func<string>> bodyBranch = null, Expression<Func<string>> bodyBuyingGroup1 = null, Expression<Func<string>> bodyBuyingGroup2 = null, Expression<Func<string>> bodyBuyingGroup3 = null, Expression<Func<string>> bodyBuyingGroup4 = null, Expression<Func<string>> bodyBuyingGroup5 = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyCity1 = null, Expression<Func<string>> bodyCompanyTaxNumber = null, Expression<Func<string>> bodyContact = null, Expression<Func<string>> bodyContractPrcReqd = null, Expression<Func<string>> bodyCounterSlsOnly = null, Expression<Func<string>> bodyCountyZip = null, Expression<Func<string>> bodyCountyZip1 = null, Expression<Func<string>> bodyCreditCheckFlag = null, Expression<Func<string>> bodyCreditLimit = null, Expression<Func<string>> bodyCreditStatus = null, Expression<Func<string>> bodyCurrency = null, Expression<Func<string>> bodyCustomerClass = null, Expression<Func<string>> bodyCustomerCode = null, Expression<Func<string>> bodyCustomerOnHold = null, Expression<Func<string>> bodyDateCustAdded = null, Expression<Func<string>> bodyDefaultOrdType = null, Expression<Func<string>> bodyDeliveryTerms = null, Expression<Func<string>> bodyDeliveryTermsC = null, Expression<Func<string>> bodyDetailMoveReqd = null, Expression<Func<string>> bodyDocFax = null, Expression<Func<string>> bodyDocFaxContact = null, Expression<Func<string>> bodyEdiFlag = null, Expression<Func<string>> bodyEdiSenderCode = null, Expression<Func<string>> bodyEmail = null, Expression<Func<string>> bodyExemptFinChg = null, Expression<Func<string>> bodyFax = null, Expression<Func<string>> bodyFaxInvoices = null, Expression<Func<string>> bodyFaxQuotes = null, Expression<Func<string>> bodyFaxStatements = null, Expression<Func<string>> bodyGstExemptFlag = null, Expression<Func<string>> bodyGstExemptNum = null, Expression<Func<string>> bodyGstLevel = null, Expression<Func<string>> bodyHighInv = null, Expression<Func<string>> bodyHighInvDays = null, Expression<Func<string>> bodyHighestBalance = null, Expression<Func<string>> bodyIbtCustomer = null, Expression<Func<string>> bodyInvCommentCode = null, Expression<Func<string>> bodyInvDiscCode = null, Expression<Func<string>> bodyLanguageCode = null, Expression<Func<string>> bodyLineDiscCode = null, Expression<Func<string>> bodyMaintHistory = null, Expression<Func<string>> bodyMaintLastPrcPaid = null, Expression<Func<string>> bodyMinimumOrderChgCod = null, Expression<Func<string>> bodyMinimumOrderValue = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyNationality = null, Expression<Func<string>> bodyNewCustomerCode = null, Expression<Func<string>> bodyPoNumberMandatory = null, Expression<Func<string>> bodyPriceCategoryTable = null, Expression<Func<string>> bodyPriceCode = null, Expression<Func<string>> bodyRouteCode = null, Expression<Func<string>> bodyRouteDistance = null, Expression<Func<string>> bodySalesWarehouse = null, Expression<Func<string>> bodySalesperson = null, Expression<Func<string>> bodySalesperson1 = null, Expression<Func<string>> bodySalesperson2 = null, Expression<Func<string>> bodySalesperson3 = null, Expression<Func<string>> bodyShipPostalCode = null, Expression<Func<string>> bodyShipToAddr1 = null, Expression<Func<string>> bodyShipToAddr2 = null, Expression<Func<string>> bodyShipToAddr3 = null, Expression<Func<string>> bodyShipToAddr3Loc = null, Expression<Func<string>> bodyShipToAddr4 = null, Expression<Func<string>> bodyShipToAddr5 = null, Expression<Func<string>> bodyShipToGpsLat = null, Expression<Func<string>> bodyShipToGpsLong = null, Expression<Func<string>> bodyShippingInstrs = null, Expression<Func<string>> bodyShippingInstrsCod = null, Expression<Func<string>> bodyShippingLocation = null, Expression<Func<string>> bodyShortName = null, Expression<Func<string>> bodySoDefaultDoc = null, Expression<Func<string>> bodySoDefaultType = null, Expression<Func<string>> bodySoldPostalCode = null, Expression<Func<string>> bodySoldToAddr1 = null, Expression<Func<string>> bodySoldToAddr2 = null, Expression<Func<string>> bodySoldToAddr3 = null, Expression<Func<string>> bodySoldToAddr3Loc = null, Expression<Func<string>> bodySoldToAddr4 = null, Expression<Func<string>> bodySoldToAddr5 = null, Expression<Func<string>> bodySoldToGpsLat = null, Expression<Func<string>> bodySoldToGpsLong = null, Expression<Func<string>> bodySpecialInstrs = null, Expression<Func<string>> bodyState = null, Expression<Func<string>> bodyState1 = null, Expression<Func<string>> bodyStateCode = null, Expression<Func<string>> bodyStatementReqd = null, Expression<Func<string>> bodyStockInterchange = null, Expression<Func<string>> bodyTagsToDropFromXML = null, Expression<Func<string>> bodyTaxExemptNumber = null, Expression<Func<string>> bodyTaxStatus = null, Expression<Func<string>> bodyTelephone = null, Expression<Func<string>> bodyTelephoneExtn = null, Expression<Func<string>> bodyTelex = null, Expression<Func<string>> bodyTermsCode = null, Expression<Func<string>> bodyTpmCreditCheck = null, Expression<Func<string>> bodyTpmCustomerFlag = null, Expression<Func<string>> bodyTpmPricingFlag = null, Expression<Func<string>> bodyTransactionNature = null, Expression<Func<string>> bodyTransactionNatureC = null, Expression<Func<string>> bodyUkCurrency = null, Expression<Func<string>> bodyUkVatFlag = null, Expression<Func<string>> bodyUserField1 = null, Expression<Func<string>> bodyUserField2 = null, Expression<Func<string>> bodyWholeOrderShipFlag = null, Expression<Func<string>> bodyeSignature = null)
        {
            var apiCallPath = "/api/v1/syspro/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAddTelephone != null)
            {
                body["AddTelephone"] = ExpressionConverter.ConvertO(bodyAddTelephone);
                bodypropCount++;
            }

            if (bodyAltMethodFlag != null)
            {
                body["AltMethodFlag"] = ExpressionConverter.ConvertO(bodyAltMethodFlag);
                bodypropCount++;
            }

            if (bodyApplyLineDisc != null)
            {
                body["ApplyLineDisc"] = ExpressionConverter.ConvertO(bodyApplyLineDisc);
                bodypropCount++;
            }

            if (bodyApplyOrdDisc != null)
            {
                body["ApplyOrdDisc"] = ExpressionConverter.ConvertO(bodyApplyOrdDisc);
                bodypropCount++;
            }

            if (bodyArStatementNo != null)
            {
                body["ArStatementNo"] = ExpressionConverter.ConvertO(bodyArStatementNo);
                bodypropCount++;
            }

            if (bodyArea != null)
            {
                body["Area"] = ExpressionConverter.ConvertO(bodyArea);
                bodypropCount++;
            }

            if (bodyBackOrdReqd != null)
            {
                body["BackOrdReqd"] = ExpressionConverter.ConvertO(bodyBackOrdReqd);
                bodypropCount++;
            }

            if (bodyBalanceType != null)
            {
                body["BalanceType"] = ExpressionConverter.ConvertO(bodyBalanceType);
                bodypropCount++;
            }

            if (bodyBranch != null)
            {
                body["Branch"] = ExpressionConverter.ConvertO(bodyBranch);
                bodypropCount++;
            }

            if (bodyBuyingGroup1 != null)
            {
                body["BuyingGroup1"] = ExpressionConverter.ConvertO(bodyBuyingGroup1);
                bodypropCount++;
            }

            if (bodyBuyingGroup2 != null)
            {
                body["BuyingGroup2"] = ExpressionConverter.ConvertO(bodyBuyingGroup2);
                bodypropCount++;
            }

            if (bodyBuyingGroup3 != null)
            {
                body["BuyingGroup3"] = ExpressionConverter.ConvertO(bodyBuyingGroup3);
                bodypropCount++;
            }

            if (bodyBuyingGroup4 != null)
            {
                body["BuyingGroup4"] = ExpressionConverter.ConvertO(bodyBuyingGroup4);
                bodypropCount++;
            }

            if (bodyBuyingGroup5 != null)
            {
                body["BuyingGroup5"] = ExpressionConverter.ConvertO(bodyBuyingGroup5);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyCity1 != null)
            {
                body["City1"] = ExpressionConverter.ConvertO(bodyCity1);
                bodypropCount++;
            }

            if (bodyCompanyTaxNumber != null)
            {
                body["CompanyTaxNumber"] = ExpressionConverter.ConvertO(bodyCompanyTaxNumber);
                bodypropCount++;
            }

            if (bodyContact != null)
            {
                body["Contact"] = ExpressionConverter.ConvertO(bodyContact);
                bodypropCount++;
            }

            if (bodyContractPrcReqd != null)
            {
                body["ContractPrcReqd"] = ExpressionConverter.ConvertO(bodyContractPrcReqd);
                bodypropCount++;
            }

            if (bodyCounterSlsOnly != null)
            {
                body["CounterSlsOnly"] = ExpressionConverter.ConvertO(bodyCounterSlsOnly);
                bodypropCount++;
            }

            if (bodyCountyZip != null)
            {
                body["CountyZip"] = ExpressionConverter.ConvertO(bodyCountyZip);
                bodypropCount++;
            }

            if (bodyCountyZip1 != null)
            {
                body["CountyZip1"] = ExpressionConverter.ConvertO(bodyCountyZip1);
                bodypropCount++;
            }

            if (bodyCreditCheckFlag != null)
            {
                body["CreditCheckFlag"] = ExpressionConverter.ConvertO(bodyCreditCheckFlag);
                bodypropCount++;
            }

            if (bodyCreditLimit != null)
            {
                body["CreditLimit"] = ExpressionConverter.ConvertO(bodyCreditLimit);
                bodypropCount++;
            }

            if (bodyCreditStatus != null)
            {
                body["CreditStatus"] = ExpressionConverter.ConvertO(bodyCreditStatus);
                bodypropCount++;
            }

            if (bodyCurrency != null)
            {
                body["Currency"] = ExpressionConverter.ConvertO(bodyCurrency);
                bodypropCount++;
            }

            if (bodyCustomerClass != null)
            {
                body["CustomerClass"] = ExpressionConverter.ConvertO(bodyCustomerClass);
                bodypropCount++;
            }

            if (bodyCustomerCode != null)
            {
                body["CustomerCode"] = ExpressionConverter.ConvertO(bodyCustomerCode);
                bodypropCount++;
            }

            if (bodyCustomerOnHold != null)
            {
                body["CustomerOnHold"] = ExpressionConverter.ConvertO(bodyCustomerOnHold);
                bodypropCount++;
            }

            if (bodyDateCustAdded != null)
            {
                body["DateCustAdded"] = ExpressionConverter.ConvertO(bodyDateCustAdded);
                bodypropCount++;
            }

            if (bodyDefaultOrdType != null)
            {
                body["DefaultOrdType"] = ExpressionConverter.ConvertO(bodyDefaultOrdType);
                bodypropCount++;
            }

            if (bodyDeliveryTerms != null)
            {
                body["DeliveryTerms"] = ExpressionConverter.ConvertO(bodyDeliveryTerms);
                bodypropCount++;
            }

            if (bodyDeliveryTermsC != null)
            {
                body["DeliveryTermsC"] = ExpressionConverter.ConvertO(bodyDeliveryTermsC);
                bodypropCount++;
            }

            if (bodyDetailMoveReqd != null)
            {
                body["DetailMoveReqd"] = ExpressionConverter.ConvertO(bodyDetailMoveReqd);
                bodypropCount++;
            }

            if (bodyDocFax != null)
            {
                body["DocFax"] = ExpressionConverter.ConvertO(bodyDocFax);
                bodypropCount++;
            }

            if (bodyDocFaxContact != null)
            {
                body["DocFaxContact"] = ExpressionConverter.ConvertO(bodyDocFaxContact);
                bodypropCount++;
            }

            if (bodyEdiFlag != null)
            {
                body["EdiFlag"] = ExpressionConverter.ConvertO(bodyEdiFlag);
                bodypropCount++;
            }

            if (bodyEdiSenderCode != null)
            {
                body["EdiSenderCode"] = ExpressionConverter.ConvertO(bodyEdiSenderCode);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyExemptFinChg != null)
            {
                body["ExemptFinChg"] = ExpressionConverter.ConvertO(bodyExemptFinChg);
                bodypropCount++;
            }

            if (bodyFax != null)
            {
                body["Fax"] = ExpressionConverter.ConvertO(bodyFax);
                bodypropCount++;
            }

            if (bodyFaxInvoices != null)
            {
                body["FaxInvoices"] = ExpressionConverter.ConvertO(bodyFaxInvoices);
                bodypropCount++;
            }

            if (bodyFaxQuotes != null)
            {
                body["FaxQuotes"] = ExpressionConverter.ConvertO(bodyFaxQuotes);
                bodypropCount++;
            }

            if (bodyFaxStatements != null)
            {
                body["FaxStatements"] = ExpressionConverter.ConvertO(bodyFaxStatements);
                bodypropCount++;
            }

            if (bodyGstExemptFlag != null)
            {
                body["GstExemptFlag"] = ExpressionConverter.ConvertO(bodyGstExemptFlag);
                bodypropCount++;
            }

            if (bodyGstExemptNum != null)
            {
                body["GstExemptNum"] = ExpressionConverter.ConvertO(bodyGstExemptNum);
                bodypropCount++;
            }

            if (bodyGstLevel != null)
            {
                body["GstLevel"] = ExpressionConverter.ConvertO(bodyGstLevel);
                bodypropCount++;
            }

            if (bodyHighInv != null)
            {
                body["HighInv"] = ExpressionConverter.ConvertO(bodyHighInv);
                bodypropCount++;
            }

            if (bodyHighInvDays != null)
            {
                body["HighInvDays"] = ExpressionConverter.ConvertO(bodyHighInvDays);
                bodypropCount++;
            }

            if (bodyHighestBalance != null)
            {
                body["HighestBalance"] = ExpressionConverter.ConvertO(bodyHighestBalance);
                bodypropCount++;
            }

            if (bodyIbtCustomer != null)
            {
                body["IbtCustomer"] = ExpressionConverter.ConvertO(bodyIbtCustomer);
                bodypropCount++;
            }

            if (bodyInvCommentCode != null)
            {
                body["InvCommentCode"] = ExpressionConverter.ConvertO(bodyInvCommentCode);
                bodypropCount++;
            }

            if (bodyInvDiscCode != null)
            {
                body["InvDiscCode"] = ExpressionConverter.ConvertO(bodyInvDiscCode);
                bodypropCount++;
            }

            if (bodyLanguageCode != null)
            {
                body["LanguageCode"] = ExpressionConverter.ConvertO(bodyLanguageCode);
                bodypropCount++;
            }

            if (bodyLineDiscCode != null)
            {
                body["LineDiscCode"] = ExpressionConverter.ConvertO(bodyLineDiscCode);
                bodypropCount++;
            }

            if (bodyMaintHistory != null)
            {
                body["MaintHistory"] = ExpressionConverter.ConvertO(bodyMaintHistory);
                bodypropCount++;
            }

            if (bodyMaintLastPrcPaid != null)
            {
                body["MaintLastPrcPaid"] = ExpressionConverter.ConvertO(bodyMaintLastPrcPaid);
                bodypropCount++;
            }

            if (bodyMinimumOrderChgCod != null)
            {
                body["MinimumOrderChgCod"] = ExpressionConverter.ConvertO(bodyMinimumOrderChgCod);
                bodypropCount++;
            }

            if (bodyMinimumOrderValue != null)
            {
                body["MinimumOrderValue"] = ExpressionConverter.ConvertO(bodyMinimumOrderValue);
                bodypropCount++;
            }

            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyNationality != null)
            {
                body["Nationality"] = ExpressionConverter.ConvertO(bodyNationality);
                bodypropCount++;
            }

            if (bodyNewCustomerCode != null)
            {
                body["NewCustomerCode"] = ExpressionConverter.ConvertO(bodyNewCustomerCode);
                bodypropCount++;
            }

            if (bodyPoNumberMandatory != null)
            {
                body["PoNumberMandatory"] = ExpressionConverter.ConvertO(bodyPoNumberMandatory);
                bodypropCount++;
            }

            if (bodyPriceCategoryTable != null)
            {
                body["PriceCategoryTable"] = ExpressionConverter.ConvertO(bodyPriceCategoryTable);
                bodypropCount++;
            }

            if (bodyPriceCode != null)
            {
                body["PriceCode"] = ExpressionConverter.ConvertO(bodyPriceCode);
                bodypropCount++;
            }

            if (bodyRouteCode != null)
            {
                body["RouteCode"] = ExpressionConverter.ConvertO(bodyRouteCode);
                bodypropCount++;
            }

            if (bodyRouteDistance != null)
            {
                body["RouteDistance"] = ExpressionConverter.ConvertO(bodyRouteDistance);
                bodypropCount++;
            }

            if (bodySalesWarehouse != null)
            {
                body["SalesWarehouse"] = ExpressionConverter.ConvertO(bodySalesWarehouse);
                bodypropCount++;
            }

            if (bodySalesperson != null)
            {
                body["Salesperson"] = ExpressionConverter.ConvertO(bodySalesperson);
                bodypropCount++;
            }

            if (bodySalesperson1 != null)
            {
                body["Salesperson1"] = ExpressionConverter.ConvertO(bodySalesperson1);
                bodypropCount++;
            }

            if (bodySalesperson2 != null)
            {
                body["Salesperson2"] = ExpressionConverter.ConvertO(bodySalesperson2);
                bodypropCount++;
            }

            if (bodySalesperson3 != null)
            {
                body["Salesperson3"] = ExpressionConverter.ConvertO(bodySalesperson3);
                bodypropCount++;
            }

            if (bodyShipPostalCode != null)
            {
                body["ShipPostalCode"] = ExpressionConverter.ConvertO(bodyShipPostalCode);
                bodypropCount++;
            }

            if (bodyShipToAddr1 != null)
            {
                body["ShipToAddr1"] = ExpressionConverter.ConvertO(bodyShipToAddr1);
                bodypropCount++;
            }

            if (bodyShipToAddr2 != null)
            {
                body["ShipToAddr2"] = ExpressionConverter.ConvertO(bodyShipToAddr2);
                bodypropCount++;
            }

            if (bodyShipToAddr3 != null)
            {
                body["ShipToAddr3"] = ExpressionConverter.ConvertO(bodyShipToAddr3);
                bodypropCount++;
            }

            if (bodyShipToAddr3Loc != null)
            {
                body["ShipToAddr3Loc"] = ExpressionConverter.ConvertO(bodyShipToAddr3Loc);
                bodypropCount++;
            }

            if (bodyShipToAddr4 != null)
            {
                body["ShipToAddr4"] = ExpressionConverter.ConvertO(bodyShipToAddr4);
                bodypropCount++;
            }

            if (bodyShipToAddr5 != null)
            {
                body["ShipToAddr5"] = ExpressionConverter.ConvertO(bodyShipToAddr5);
                bodypropCount++;
            }

            if (bodyShipToGpsLat != null)
            {
                body["ShipToGpsLat"] = ExpressionConverter.ConvertO(bodyShipToGpsLat);
                bodypropCount++;
            }

            if (bodyShipToGpsLong != null)
            {
                body["ShipToGpsLong"] = ExpressionConverter.ConvertO(bodyShipToGpsLong);
                bodypropCount++;
            }

            if (bodyShippingInstrs != null)
            {
                body["ShippingInstrs"] = ExpressionConverter.ConvertO(bodyShippingInstrs);
                bodypropCount++;
            }

            if (bodyShippingInstrsCod != null)
            {
                body["ShippingInstrsCod"] = ExpressionConverter.ConvertO(bodyShippingInstrsCod);
                bodypropCount++;
            }

            if (bodyShippingLocation != null)
            {
                body["ShippingLocation"] = ExpressionConverter.ConvertO(bodyShippingLocation);
                bodypropCount++;
            }

            if (bodyShortName != null)
            {
                body["ShortName"] = ExpressionConverter.ConvertO(bodyShortName);
                bodypropCount++;
            }

            if (bodySoDefaultDoc != null)
            {
                body["SoDefaultDoc"] = ExpressionConverter.ConvertO(bodySoDefaultDoc);
                bodypropCount++;
            }

            if (bodySoDefaultType != null)
            {
                body["SoDefaultType"] = ExpressionConverter.ConvertO(bodySoDefaultType);
                bodypropCount++;
            }

            if (bodySoldPostalCode != null)
            {
                body["SoldPostalCode"] = ExpressionConverter.ConvertO(bodySoldPostalCode);
                bodypropCount++;
            }

            if (bodySoldToAddr1 != null)
            {
                body["SoldToAddr1"] = ExpressionConverter.ConvertO(bodySoldToAddr1);
                bodypropCount++;
            }

            if (bodySoldToAddr2 != null)
            {
                body["SoldToAddr2"] = ExpressionConverter.ConvertO(bodySoldToAddr2);
                bodypropCount++;
            }

            if (bodySoldToAddr3 != null)
            {
                body["SoldToAddr3"] = ExpressionConverter.ConvertO(bodySoldToAddr3);
                bodypropCount++;
            }

            if (bodySoldToAddr3Loc != null)
            {
                body["SoldToAddr3Loc"] = ExpressionConverter.ConvertO(bodySoldToAddr3Loc);
                bodypropCount++;
            }

            if (bodySoldToAddr4 != null)
            {
                body["SoldToAddr4"] = ExpressionConverter.ConvertO(bodySoldToAddr4);
                bodypropCount++;
            }

            if (bodySoldToAddr5 != null)
            {
                body["SoldToAddr5"] = ExpressionConverter.ConvertO(bodySoldToAddr5);
                bodypropCount++;
            }

            if (bodySoldToGpsLat != null)
            {
                body["SoldToGpsLat"] = ExpressionConverter.ConvertO(bodySoldToGpsLat);
                bodypropCount++;
            }

            if (bodySoldToGpsLong != null)
            {
                body["SoldToGpsLong"] = ExpressionConverter.ConvertO(bodySoldToGpsLong);
                bodypropCount++;
            }

            if (bodySpecialInstrs != null)
            {
                body["SpecialInstrs"] = ExpressionConverter.ConvertO(bodySpecialInstrs);
                bodypropCount++;
            }

            if (bodyState != null)
            {
                body["State"] = ExpressionConverter.ConvertO(bodyState);
                bodypropCount++;
            }

            if (bodyState1 != null)
            {
                body["State1"] = ExpressionConverter.ConvertO(bodyState1);
                bodypropCount++;
            }

            if (bodyStateCode != null)
            {
                body["StateCode"] = ExpressionConverter.ConvertO(bodyStateCode);
                bodypropCount++;
            }

            if (bodyStatementReqd != null)
            {
                body["StatementReqd"] = ExpressionConverter.ConvertO(bodyStatementReqd);
                bodypropCount++;
            }

            if (bodyStockInterchange != null)
            {
                body["StockInterchange"] = ExpressionConverter.ConvertO(bodyStockInterchange);
                bodypropCount++;
            }

            if (bodyTagsToDropFromXML != null)
            {
                body["TagsToDropFromXML"] = ExpressionConverter.ConvertO(bodyTagsToDropFromXML);
                bodypropCount++;
            }

            if (bodyTaxExemptNumber != null)
            {
                body["TaxExemptNumber"] = ExpressionConverter.ConvertO(bodyTaxExemptNumber);
                bodypropCount++;
            }

            if (bodyTaxStatus != null)
            {
                body["TaxStatus"] = ExpressionConverter.ConvertO(bodyTaxStatus);
                bodypropCount++;
            }

            if (bodyTelephone != null)
            {
                body["Telephone"] = ExpressionConverter.ConvertO(bodyTelephone);
                bodypropCount++;
            }

            if (bodyTelephoneExtn != null)
            {
                body["TelephoneExtn"] = ExpressionConverter.ConvertO(bodyTelephoneExtn);
                bodypropCount++;
            }

            if (bodyTelex != null)
            {
                body["Telex"] = ExpressionConverter.ConvertO(bodyTelex);
                bodypropCount++;
            }

            if (bodyTermsCode != null)
            {
                body["TermsCode"] = ExpressionConverter.ConvertO(bodyTermsCode);
                bodypropCount++;
            }

            if (bodyTpmCreditCheck != null)
            {
                body["TpmCreditCheck"] = ExpressionConverter.ConvertO(bodyTpmCreditCheck);
                bodypropCount++;
            }

            if (bodyTpmCustomerFlag != null)
            {
                body["TpmCustomerFlag"] = ExpressionConverter.ConvertO(bodyTpmCustomerFlag);
                bodypropCount++;
            }

            if (bodyTpmPricingFlag != null)
            {
                body["TpmPricingFlag"] = ExpressionConverter.ConvertO(bodyTpmPricingFlag);
                bodypropCount++;
            }

            if (bodyTransactionNature != null)
            {
                body["TransactionNature"] = ExpressionConverter.ConvertO(bodyTransactionNature);
                bodypropCount++;
            }

            if (bodyTransactionNatureC != null)
            {
                body["TransactionNatureC"] = ExpressionConverter.ConvertO(bodyTransactionNatureC);
                bodypropCount++;
            }

            if (bodyUkCurrency != null)
            {
                body["UkCurrency"] = ExpressionConverter.ConvertO(bodyUkCurrency);
                bodypropCount++;
            }

            if (bodyUkVatFlag != null)
            {
                body["UkVatFlag"] = ExpressionConverter.ConvertO(bodyUkVatFlag);
                bodypropCount++;
            }

            if (bodyUserField1 != null)
            {
                body["UserField1"] = ExpressionConverter.ConvertO(bodyUserField1);
                bodypropCount++;
            }

            if (bodyUserField2 != null)
            {
                body["UserField2"] = ExpressionConverter.ConvertO(bodyUserField2);
                bodypropCount++;
            }

            if (bodyWholeOrderShipFlag != null)
            {
                body["WholeOrderShipFlag"] = ExpressionConverter.ConvertO(bodyWholeOrderShipFlag);
                bodypropCount++;
            }

            if (bodyeSignature != null)
            {
                body["eSignature"] = ExpressionConverter.ConvertO(bodyeSignature);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SYSPROCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> SYSPROCreateNewSalesOrder(Expression<Func<string>> bodyAcceptEarlierShipDate = null, Expression<Func<string>> bodyAcceptKitOptional = null, Expression<Func<string>> bodyAcceptOrdersIfNoCredit = null, Expression<Func<string>> bodyAddAttachedServiceCharges = null, Expression<Func<string>> bodyAddDangerousGoodsText = null, Expression<Func<string>> bodyAddStockSalesOrderText = null, Expression<Func<string>> bodyAllocationAction = null, Expression<Func<string>> bodyAllowBackOrderForNegativeMerchLine = null, Expression<Func<string>> bodyAllowBackOrderForPartialHold = null, Expression<Func<string>> bodyAllowBackOrderForSuperseded = null, Expression<Func<string>> bodyAllowChangeToZeroPrice = null, Expression<Func<string>> bodyAllowDuplicateOrderNumbers = null, Expression<Func<string>> bodyAllowManualOrderNumberToBeUsed = null, Expression<Func<string>> bodyAllowNonStockItems = null, Expression<Func<string>> bodyAllowZeroPrice = null, Expression<Func<string>> bodyAlternateReference = null, Expression<Func<string>> bodyAlwaysUsePriceEntered = null, Expression<Func<string>> bodyApplyLeadTimeCalculation = null, Expression<Func<string>> bodyApplyParentDiscountToComponents = null, Expression<Func<string>> bodyArea = null, Expression<Func<string>> bodyBranch = null, Expression<Func<string>> bodyCancelReasonCode = null, Expression<Func<string>> bodyCheckForCustomerPoNumbers = null, Expression<Func<string>> bodyCity = null, Expression<Func<string>> bodyCompanyTaxNumber = null, Expression<Func<string>> bodyCountyZip = null, Expression<Func<string>> bodyCreditFailMessage = null, Expression<Func<string>> bodyCurrency = null, Expression<Func<string>> bodyCustomer = null, Expression<Func<string>> bodyCustomerName = null, Expression<Func<string>> bodyCustomerPoNumber = null, Expression<Func<string>> bodyCustomerToUse = null, Expression<Func<string>> bodyDeliveryRoute = null, Expression<Func<string>> bodyDeliveryRouteAction = null, Expression<Func<string>> bodyDeliveryTerms = null, Expression<Func<string>> bodyDocumentFormat = null, Expression<Func<string>> bodyEmail = null, Expression<Func<string>> bodyGlobalTradePromotionCodes = null, Expression<Func<string>> bodyGstExemptNumber = null, Expression<Func<string>> bodyGstExemptionStatus = null, Expression<Func<string>> bodyHeaderFreightCharges = null, Expression<Func<string>> bodyHeaderMiscCharges = null, Expression<Func<string>> bodyIgnoreWarnings = null, Expression<Func<string>> bodyInBoxMsgReqd = null, Expression<Func<string>> bodyIncludeInMrp = null, Expression<Func<string>> bodyInvoiceDateEntered = null, Expression<Func<string>> bodyInvoiceNumberEntered = null, Expression<Func<string>> bodyInvoiceTerms = null, Expression<Func<string>> bodyInvoiceWholeOrderOnly = null, Expression<Func<string>> bodyLanguageCode = null, Expression<Func<string>> bodyMinimumDaysToShip = null, Expression<Func<string>> bodyMultiShipCode = null, Expression<Func<string>> bodyNationality = null, Expression<Func<string>> bodyNewCustomerPoNumber = null, Expression<Func<string>> bodyNewSalesOrderNumber = null, Expression<Func<string>> bodyOperatorToInform = null, Expression<Func<string>> bodyOrderActionType = null, Expression<Func<string>> bodyOrderComments = null, Expression<Func<string>> bodyOrderDate = null, Expression<Func<string>> bodyOrderDiscPercent1 = null, Expression<Func<string>> bodyOrderDiscPercent2 = null, Expression<Func<string>> bodyOrderDiscPercent3 = null, Expression<Func<string>> bodyOrderStatus = null, Expression<Func<string>> bodyOrderType = null, Expression<Func<string>> bodyOverrideCustomerBackOrder = null, Expression<Func<string>> bodyPOSSalesOrder = null, Expression<Func<string>> bodyProcess = null, Expression<Func<string>> bodyProcessFlag = null, Expression<Func<string>> bodyPutEntireQuantityOnNewLoadWhenChanged = null, Expression<Func<string>> bodyReceiverCode = null, Expression<Func<string>> bodyRequestedShipDate = null, Expression<Func<string>> bodyReserveStock = null, Expression<Func<string>> bodyReserveStockRequestAllocs = null, Expression<Func<string>> bodySalesOrder = null, Expression<Func<bodySalesOrderDetailsInputItem[]>> bodySalesOrderDetails = null, Expression<Func<bodySalesOrderFooterCommentsInputItem[]>> bodySalesOrderFooterComments = null, Expression<Func<bodySalesOrderFreightDetailsInputItem[]>> bodySalesOrderFreightDetails = null, Expression<Func<bodySalesOrderHeaderCommentsInputItem[]>> bodySalesOrderHeaderComments = null, Expression<Func<bodySalesOrderMiscChargesDetailsInputItem[]>> bodySalesOrderMiscChargesDetails = null, Expression<Func<string>> bodySalesOrderPromoQualifyAction = null, Expression<Func<string>> bodySalesOrderPromoSelectAction = null, Expression<Func<string>> bodySalesperson = null, Expression<Func<string>> bodySenderCode = null, Expression<Func<string>> bodyShipAddress1 = null, Expression<Func<string>> bodyShipAddress2 = null, Expression<Func<string>> bodyShipAddress3 = null, Expression<Func<string>> bodyShipAddress3Locality = null, Expression<Func<string>> bodyShipAddress4 = null, Expression<Func<string>> bodyShipAddress5 = null, Expression<Func<string>> bodyShipAddressPerLine = null, Expression<Func<string>> bodyShipAddressPerLineTax = null, Expression<Func<string>> bodyShipGpsLat = null, Expression<Func<string>> bodyShipGpsLong = null, Expression<Func<string>> bodyShipPostalCode = null, Expression<Func<string>> bodyShippingInstrs = null, Expression<Func<string>> bodyShippingInstrsCode = null, Expression<Func<string>> bodyShippingLocation = null, Expression<Func<string>> bodySpecialInstrs = null, Expression<Func<string>> bodyState = null, Expression<Func<string>> bodyStatusInProcess = null, Expression<Func<string>> bodyStatusInProcessResponse = null, Expression<Func<string>> bodySupplier = null, Expression<Func<string>> bodyTagsToDropFromXML = null, Expression<Func<string>> bodyTaxExemptNumber = null, Expression<Func<string>> bodyTaxExemptionStatus = null, Expression<Func<string>> bodyTransactionNature = null, Expression<Func<string>> bodyTransmissionReference = null, Expression<Func<string>> bodyTransportMode = null, Expression<Func<string>> bodyTypeOfOrder = null, Expression<Func<string>> bodyUseCustomerSalesWarehouse = null, Expression<Func<string>> bodyUseMasterAccountForCustomerPartNo = null, Expression<Func<string>> bodyUseStockDescSupplied = null, Expression<Func<string>> bodyValidateShippingInstrs = null, Expression<Func<string>> bodyWarehouse = null, Expression<Func<string>> bodyWarehouseListToUse = null, Expression<Func<string>> bodyWarnIfCustomerOnHold = null, Expression<Func<string>> bodyeSignature = null)
        {
            var apiCallPath = "/api/v1/syspro/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyAcceptEarlierShipDate != null)
            {
                body["AcceptEarlierShipDate"] = ExpressionConverter.ConvertO(bodyAcceptEarlierShipDate);
                bodypropCount++;
            }

            if (bodyAcceptKitOptional != null)
            {
                body["AcceptKitOptional"] = ExpressionConverter.ConvertO(bodyAcceptKitOptional);
                bodypropCount++;
            }

            if (bodyAcceptOrdersIfNoCredit != null)
            {
                body["AcceptOrdersIfNoCredit"] = ExpressionConverter.ConvertO(bodyAcceptOrdersIfNoCredit);
                bodypropCount++;
            }

            if (bodyAddAttachedServiceCharges != null)
            {
                body["AddAttachedServiceCharges"] = ExpressionConverter.ConvertO(bodyAddAttachedServiceCharges);
                bodypropCount++;
            }

            if (bodyAddDangerousGoodsText != null)
            {
                body["AddDangerousGoodsText"] = ExpressionConverter.ConvertO(bodyAddDangerousGoodsText);
                bodypropCount++;
            }

            if (bodyAddStockSalesOrderText != null)
            {
                body["AddStockSalesOrderText"] = ExpressionConverter.ConvertO(bodyAddStockSalesOrderText);
                bodypropCount++;
            }

            if (bodyAllocationAction != null)
            {
                body["AllocationAction"] = ExpressionConverter.ConvertO(bodyAllocationAction);
                bodypropCount++;
            }

            if (bodyAllowBackOrderForNegativeMerchLine != null)
            {
                body["AllowBackOrderForNegativeMerchLine"] = ExpressionConverter.ConvertO(bodyAllowBackOrderForNegativeMerchLine);
                bodypropCount++;
            }

            if (bodyAllowBackOrderForPartialHold != null)
            {
                body["AllowBackOrderForPartialHold"] = ExpressionConverter.ConvertO(bodyAllowBackOrderForPartialHold);
                bodypropCount++;
            }

            if (bodyAllowBackOrderForSuperseded != null)
            {
                body["AllowBackOrderForSuperseded"] = ExpressionConverter.ConvertO(bodyAllowBackOrderForSuperseded);
                bodypropCount++;
            }

            if (bodyAllowChangeToZeroPrice != null)
            {
                body["AllowChangeToZeroPrice"] = ExpressionConverter.ConvertO(bodyAllowChangeToZeroPrice);
                bodypropCount++;
            }

            if (bodyAllowDuplicateOrderNumbers != null)
            {
                body["AllowDuplicateOrderNumbers"] = ExpressionConverter.ConvertO(bodyAllowDuplicateOrderNumbers);
                bodypropCount++;
            }

            if (bodyAllowManualOrderNumberToBeUsed != null)
            {
                body["AllowManualOrderNumberToBeUsed"] = ExpressionConverter.ConvertO(bodyAllowManualOrderNumberToBeUsed);
                bodypropCount++;
            }

            if (bodyAllowNonStockItems != null)
            {
                body["AllowNonStockItems"] = ExpressionConverter.ConvertO(bodyAllowNonStockItems);
                bodypropCount++;
            }

            if (bodyAllowZeroPrice != null)
            {
                body["AllowZeroPrice"] = ExpressionConverter.ConvertO(bodyAllowZeroPrice);
                bodypropCount++;
            }

            if (bodyAlternateReference != null)
            {
                body["AlternateReference"] = ExpressionConverter.ConvertO(bodyAlternateReference);
                bodypropCount++;
            }

            if (bodyAlwaysUsePriceEntered != null)
            {
                body["AlwaysUsePriceEntered"] = ExpressionConverter.ConvertO(bodyAlwaysUsePriceEntered);
                bodypropCount++;
            }

            if (bodyApplyLeadTimeCalculation != null)
            {
                body["ApplyLeadTimeCalculation"] = ExpressionConverter.ConvertO(bodyApplyLeadTimeCalculation);
                bodypropCount++;
            }

            if (bodyApplyParentDiscountToComponents != null)
            {
                body["ApplyParentDiscountToComponents"] = ExpressionConverter.ConvertO(bodyApplyParentDiscountToComponents);
                bodypropCount++;
            }

            if (bodyArea != null)
            {
                body["Area"] = ExpressionConverter.ConvertO(bodyArea);
                bodypropCount++;
            }

            if (bodyBranch != null)
            {
                body["Branch"] = ExpressionConverter.ConvertO(bodyBranch);
                bodypropCount++;
            }

            if (bodyCancelReasonCode != null)
            {
                body["CancelReasonCode"] = ExpressionConverter.ConvertO(bodyCancelReasonCode);
                bodypropCount++;
            }

            if (bodyCheckForCustomerPoNumbers != null)
            {
                body["CheckForCustomerPoNumbers"] = ExpressionConverter.ConvertO(bodyCheckForCustomerPoNumbers);
                bodypropCount++;
            }

            if (bodyCity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodyCity);
                bodypropCount++;
            }

            if (bodyCompanyTaxNumber != null)
            {
                body["CompanyTaxNumber"] = ExpressionConverter.ConvertO(bodyCompanyTaxNumber);
                bodypropCount++;
            }

            if (bodyCountyZip != null)
            {
                body["CountyZip"] = ExpressionConverter.ConvertO(bodyCountyZip);
                bodypropCount++;
            }

            if (bodyCreditFailMessage != null)
            {
                body["CreditFailMessage"] = ExpressionConverter.ConvertO(bodyCreditFailMessage);
                bodypropCount++;
            }

            if (bodyCurrency != null)
            {
                body["Currency"] = ExpressionConverter.ConvertO(bodyCurrency);
                bodypropCount++;
            }

            if (bodyCustomer != null)
            {
                body["Customer"] = ExpressionConverter.ConvertO(bodyCustomer);
                bodypropCount++;
            }

            if (bodyCustomerName != null)
            {
                body["CustomerName"] = ExpressionConverter.ConvertO(bodyCustomerName);
                bodypropCount++;
            }

            if (bodyCustomerPoNumber != null)
            {
                body["CustomerPoNumber"] = ExpressionConverter.ConvertO(bodyCustomerPoNumber);
                bodypropCount++;
            }

            if (bodyCustomerToUse != null)
            {
                body["CustomerToUse"] = ExpressionConverter.ConvertO(bodyCustomerToUse);
                bodypropCount++;
            }

            if (bodyDeliveryRoute != null)
            {
                body["DeliveryRoute"] = ExpressionConverter.ConvertO(bodyDeliveryRoute);
                bodypropCount++;
            }

            if (bodyDeliveryRouteAction != null)
            {
                body["DeliveryRouteAction"] = ExpressionConverter.ConvertO(bodyDeliveryRouteAction);
                bodypropCount++;
            }

            if (bodyDeliveryTerms != null)
            {
                body["DeliveryTerms"] = ExpressionConverter.ConvertO(bodyDeliveryTerms);
                bodypropCount++;
            }

            if (bodyDocumentFormat != null)
            {
                body["DocumentFormat"] = ExpressionConverter.ConvertO(bodyDocumentFormat);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodyGlobalTradePromotionCodes != null)
            {
                body["GlobalTradePromotionCodes"] = ExpressionConverter.ConvertO(bodyGlobalTradePromotionCodes);
                bodypropCount++;
            }

            if (bodyGstExemptNumber != null)
            {
                body["GstExemptNumber"] = ExpressionConverter.ConvertO(bodyGstExemptNumber);
                bodypropCount++;
            }

            if (bodyGstExemptionStatus != null)
            {
                body["GstExemptionStatus"] = ExpressionConverter.ConvertO(bodyGstExemptionStatus);
                bodypropCount++;
            }

            if (bodyHeaderFreightCharges != null)
            {
                body["HeaderFreightCharges"] = ExpressionConverter.ConvertO(bodyHeaderFreightCharges);
                bodypropCount++;
            }

            if (bodyHeaderMiscCharges != null)
            {
                body["HeaderMiscCharges"] = ExpressionConverter.ConvertO(bodyHeaderMiscCharges);
                bodypropCount++;
            }

            if (bodyIgnoreWarnings != null)
            {
                body["IgnoreWarnings"] = ExpressionConverter.ConvertO(bodyIgnoreWarnings);
                bodypropCount++;
            }

            if (bodyInBoxMsgReqd != null)
            {
                body["InBoxMsgReqd"] = ExpressionConverter.ConvertO(bodyInBoxMsgReqd);
                bodypropCount++;
            }

            if (bodyIncludeInMrp != null)
            {
                body["IncludeInMrp"] = ExpressionConverter.ConvertO(bodyIncludeInMrp);
                bodypropCount++;
            }

            if (bodyInvoiceDateEntered != null)
            {
                body["InvoiceDateEntered"] = ExpressionConverter.ConvertO(bodyInvoiceDateEntered);
                bodypropCount++;
            }

            if (bodyInvoiceNumberEntered != null)
            {
                body["InvoiceNumberEntered"] = ExpressionConverter.ConvertO(bodyInvoiceNumberEntered);
                bodypropCount++;
            }

            if (bodyInvoiceTerms != null)
            {
                body["InvoiceTerms"] = ExpressionConverter.ConvertO(bodyInvoiceTerms);
                bodypropCount++;
            }

            if (bodyInvoiceWholeOrderOnly != null)
            {
                body["InvoiceWholeOrderOnly"] = ExpressionConverter.ConvertO(bodyInvoiceWholeOrderOnly);
                bodypropCount++;
            }

            if (bodyLanguageCode != null)
            {
                body["LanguageCode"] = ExpressionConverter.ConvertO(bodyLanguageCode);
                bodypropCount++;
            }

            if (bodyMinimumDaysToShip != null)
            {
                body["MinimumDaysToShip"] = ExpressionConverter.ConvertO(bodyMinimumDaysToShip);
                bodypropCount++;
            }

            if (bodyMultiShipCode != null)
            {
                body["MultiShipCode"] = ExpressionConverter.ConvertO(bodyMultiShipCode);
                bodypropCount++;
            }

            if (bodyNationality != null)
            {
                body["Nationality"] = ExpressionConverter.ConvertO(bodyNationality);
                bodypropCount++;
            }

            if (bodyNewCustomerPoNumber != null)
            {
                body["NewCustomerPoNumber"] = ExpressionConverter.ConvertO(bodyNewCustomerPoNumber);
                bodypropCount++;
            }

            if (bodyNewSalesOrderNumber != null)
            {
                body["NewSalesOrderNumber"] = ExpressionConverter.ConvertO(bodyNewSalesOrderNumber);
                bodypropCount++;
            }

            if (bodyOperatorToInform != null)
            {
                body["OperatorToInform"] = ExpressionConverter.ConvertO(bodyOperatorToInform);
                bodypropCount++;
            }

            if (bodyOrderActionType != null)
            {
                body["OrderActionType"] = ExpressionConverter.ConvertO(bodyOrderActionType);
                bodypropCount++;
            }

            if (bodyOrderComments != null)
            {
                body["OrderComments"] = ExpressionConverter.ConvertO(bodyOrderComments);
                bodypropCount++;
            }

            if (bodyOrderDate != null)
            {
                body["OrderDate"] = ExpressionConverter.ConvertO(bodyOrderDate);
                bodypropCount++;
            }

            if (bodyOrderDiscPercent1 != null)
            {
                body["OrderDiscPercent1"] = ExpressionConverter.ConvertO(bodyOrderDiscPercent1);
                bodypropCount++;
            }

            if (bodyOrderDiscPercent2 != null)
            {
                body["OrderDiscPercent2"] = ExpressionConverter.ConvertO(bodyOrderDiscPercent2);
                bodypropCount++;
            }

            if (bodyOrderDiscPercent3 != null)
            {
                body["OrderDiscPercent3"] = ExpressionConverter.ConvertO(bodyOrderDiscPercent3);
                bodypropCount++;
            }

            if (bodyOrderStatus != null)
            {
                body["OrderStatus"] = ExpressionConverter.ConvertO(bodyOrderStatus);
                bodypropCount++;
            }

            if (bodyOrderType != null)
            {
                body["OrderType"] = ExpressionConverter.ConvertO(bodyOrderType);
                bodypropCount++;
            }

            if (bodyOverrideCustomerBackOrder != null)
            {
                body["OverrideCustomerBackOrder"] = ExpressionConverter.ConvertO(bodyOverrideCustomerBackOrder);
                bodypropCount++;
            }

            if (bodyPOSSalesOrder != null)
            {
                body["POSSalesOrder"] = ExpressionConverter.ConvertO(bodyPOSSalesOrder);
                bodypropCount++;
            }

            if (bodyProcess != null)
            {
                body["Process"] = ExpressionConverter.ConvertO(bodyProcess);
                bodypropCount++;
            }

            if (bodyProcessFlag != null)
            {
                body["ProcessFlag"] = ExpressionConverter.ConvertO(bodyProcessFlag);
                bodypropCount++;
            }

            if (bodyPutEntireQuantityOnNewLoadWhenChanged != null)
            {
                body["PutEntireQuantityOnNewLoadWhenChanged"] = ExpressionConverter.ConvertO(bodyPutEntireQuantityOnNewLoadWhenChanged);
                bodypropCount++;
            }

            if (bodyReceiverCode != null)
            {
                body["ReceiverCode"] = ExpressionConverter.ConvertO(bodyReceiverCode);
                bodypropCount++;
            }

            if (bodyRequestedShipDate != null)
            {
                body["RequestedShipDate"] = ExpressionConverter.ConvertO(bodyRequestedShipDate);
                bodypropCount++;
            }

            if (bodyReserveStock != null)
            {
                body["ReserveStock"] = ExpressionConverter.ConvertO(bodyReserveStock);
                bodypropCount++;
            }

            if (bodyReserveStockRequestAllocs != null)
            {
                body["ReserveStockRequestAllocs"] = ExpressionConverter.ConvertO(bodyReserveStockRequestAllocs);
                bodypropCount++;
            }

            if (bodySalesOrder != null)
            {
                body["SalesOrder"] = ExpressionConverter.ConvertO(bodySalesOrder);
                bodypropCount++;
            }

            if (bodySalesOrderDetails != null)
            {
                body["SalesOrderDetails"] = ExpressionConverter.ConvertO(bodySalesOrderDetails);
                bodypropCount++;
            }

            if (bodySalesOrderFooterComments != null)
            {
                body["SalesOrderFooterComments"] = ExpressionConverter.ConvertO(bodySalesOrderFooterComments);
                bodypropCount++;
            }

            if (bodySalesOrderFreightDetails != null)
            {
                body["SalesOrderFreightDetails"] = ExpressionConverter.ConvertO(bodySalesOrderFreightDetails);
                bodypropCount++;
            }

            if (bodySalesOrderHeaderComments != null)
            {
                body["SalesOrderHeaderComments"] = ExpressionConverter.ConvertO(bodySalesOrderHeaderComments);
                bodypropCount++;
            }

            if (bodySalesOrderMiscChargesDetails != null)
            {
                body["SalesOrderMiscChargesDetails"] = ExpressionConverter.ConvertO(bodySalesOrderMiscChargesDetails);
                bodypropCount++;
            }

            if (bodySalesOrderPromoQualifyAction != null)
            {
                body["SalesOrderPromoQualifyAction"] = ExpressionConverter.ConvertO(bodySalesOrderPromoQualifyAction);
                bodypropCount++;
            }

            if (bodySalesOrderPromoSelectAction != null)
            {
                body["SalesOrderPromoSelectAction"] = ExpressionConverter.ConvertO(bodySalesOrderPromoSelectAction);
                bodypropCount++;
            }

            if (bodySalesperson != null)
            {
                body["Salesperson"] = ExpressionConverter.ConvertO(bodySalesperson);
                bodypropCount++;
            }

            if (bodySenderCode != null)
            {
                body["SenderCode"] = ExpressionConverter.ConvertO(bodySenderCode);
                bodypropCount++;
            }

            if (bodyShipAddress1 != null)
            {
                body["ShipAddress1"] = ExpressionConverter.ConvertO(bodyShipAddress1);
                bodypropCount++;
            }

            if (bodyShipAddress2 != null)
            {
                body["ShipAddress2"] = ExpressionConverter.ConvertO(bodyShipAddress2);
                bodypropCount++;
            }

            if (bodyShipAddress3 != null)
            {
                body["ShipAddress3"] = ExpressionConverter.ConvertO(bodyShipAddress3);
                bodypropCount++;
            }

            if (bodyShipAddress3Locality != null)
            {
                body["ShipAddress3Locality"] = ExpressionConverter.ConvertO(bodyShipAddress3Locality);
                bodypropCount++;
            }

            if (bodyShipAddress4 != null)
            {
                body["ShipAddress4"] = ExpressionConverter.ConvertO(bodyShipAddress4);
                bodypropCount++;
            }

            if (bodyShipAddress5 != null)
            {
                body["ShipAddress5"] = ExpressionConverter.ConvertO(bodyShipAddress5);
                bodypropCount++;
            }

            if (bodyShipAddressPerLine != null)
            {
                body["ShipAddressPerLine"] = ExpressionConverter.ConvertO(bodyShipAddressPerLine);
                bodypropCount++;
            }

            if (bodyShipAddressPerLineTax != null)
            {
                body["ShipAddressPerLineTax"] = ExpressionConverter.ConvertO(bodyShipAddressPerLineTax);
                bodypropCount++;
            }

            if (bodyShipGpsLat != null)
            {
                body["ShipGpsLat"] = ExpressionConverter.ConvertO(bodyShipGpsLat);
                bodypropCount++;
            }

            if (bodyShipGpsLong != null)
            {
                body["ShipGpsLong"] = ExpressionConverter.ConvertO(bodyShipGpsLong);
                bodypropCount++;
            }

            if (bodyShipPostalCode != null)
            {
                body["ShipPostalCode"] = ExpressionConverter.ConvertO(bodyShipPostalCode);
                bodypropCount++;
            }

            if (bodyShippingInstrs != null)
            {
                body["ShippingInstrs"] = ExpressionConverter.ConvertO(bodyShippingInstrs);
                bodypropCount++;
            }

            if (bodyShippingInstrsCode != null)
            {
                body["ShippingInstrsCode"] = ExpressionConverter.ConvertO(bodyShippingInstrsCode);
                bodypropCount++;
            }

            if (bodyShippingLocation != null)
            {
                body["ShippingLocation"] = ExpressionConverter.ConvertO(bodyShippingLocation);
                bodypropCount++;
            }

            if (bodySpecialInstrs != null)
            {
                body["SpecialInstrs"] = ExpressionConverter.ConvertO(bodySpecialInstrs);
                bodypropCount++;
            }

            if (bodyState != null)
            {
                body["State"] = ExpressionConverter.ConvertO(bodyState);
                bodypropCount++;
            }

            if (bodyStatusInProcess != null)
            {
                body["StatusInProcess"] = ExpressionConverter.ConvertO(bodyStatusInProcess);
                bodypropCount++;
            }

            if (bodyStatusInProcessResponse != null)
            {
                body["StatusInProcessResponse"] = ExpressionConverter.ConvertO(bodyStatusInProcessResponse);
                bodypropCount++;
            }

            if (bodySupplier != null)
            {
                body["Supplier"] = ExpressionConverter.ConvertO(bodySupplier);
                bodypropCount++;
            }

            if (bodyTagsToDropFromXML != null)
            {
                body["TagsToDropFromXML"] = ExpressionConverter.ConvertO(bodyTagsToDropFromXML);
                bodypropCount++;
            }

            if (bodyTaxExemptNumber != null)
            {
                body["TaxExemptNumber"] = ExpressionConverter.ConvertO(bodyTaxExemptNumber);
                bodypropCount++;
            }

            if (bodyTaxExemptionStatus != null)
            {
                body["TaxExemptionStatus"] = ExpressionConverter.ConvertO(bodyTaxExemptionStatus);
                bodypropCount++;
            }

            if (bodyTransactionNature != null)
            {
                body["TransactionNature"] = ExpressionConverter.ConvertO(bodyTransactionNature);
                bodypropCount++;
            }

            if (bodyTransmissionReference != null)
            {
                body["TransmissionReference"] = ExpressionConverter.ConvertO(bodyTransmissionReference);
                bodypropCount++;
            }

            if (bodyTransportMode != null)
            {
                body["TransportMode"] = ExpressionConverter.ConvertO(bodyTransportMode);
                bodypropCount++;
            }

            if (bodyTypeOfOrder != null)
            {
                body["TypeOfOrder"] = ExpressionConverter.ConvertO(bodyTypeOfOrder);
                bodypropCount++;
            }

            if (bodyUseCustomerSalesWarehouse != null)
            {
                body["UseCustomerSalesWarehouse"] = ExpressionConverter.ConvertO(bodyUseCustomerSalesWarehouse);
                bodypropCount++;
            }

            if (bodyUseMasterAccountForCustomerPartNo != null)
            {
                body["UseMasterAccountForCustomerPartNo"] = ExpressionConverter.ConvertO(bodyUseMasterAccountForCustomerPartNo);
                bodypropCount++;
            }

            if (bodyUseStockDescSupplied != null)
            {
                body["UseStockDescSupplied"] = ExpressionConverter.ConvertO(bodyUseStockDescSupplied);
                bodypropCount++;
            }

            if (bodyValidateShippingInstrs != null)
            {
                body["ValidateShippingInstrs"] = ExpressionConverter.ConvertO(bodyValidateShippingInstrs);
                bodypropCount++;
            }

            if (bodyWarehouse != null)
            {
                body["Warehouse"] = ExpressionConverter.ConvertO(bodyWarehouse);
                bodypropCount++;
            }

            if (bodyWarehouseListToUse != null)
            {
                body["WarehouseListToUse"] = ExpressionConverter.ConvertO(bodyWarehouseListToUse);
                bodypropCount++;
            }

            if (bodyWarnIfCustomerOnHold != null)
            {
                body["WarnIfCustomerOnHold"] = ExpressionConverter.ConvertO(bodyWarnIfCustomerOnHold);
                bodypropCount++;
            }

            if (bodyeSignature != null)
            {
                body["eSignature"] = ExpressionConverter.ConvertO(bodyeSignature);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SYSPROCreateNewSalesOrderResponse>(callPayload);
        }
    }

    public class CommercientcpqTriggers([ConnectionName] string connectionId)
    {
    }

    public class SAGE100CreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAGE100CreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAGE100CreateNewCustomerResponseDataType
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
        public string URLAddress { get; set; }
        public string ZipCode { get; set; }
    }

    public class SAGE100CreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAGE100CreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAGE100CreateNewSalesOrderResponseDataType
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
        public string FOB { get; set; }
        public string FaxNo { get; set; }
        public string MasterRepeatingOrderNo { get; set; }
        public int NumberOfShippingLabels { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public string OrderType { get; set; }
        public bool PrintPickingSheets { get; set; }
        public bool PrintSalesOrders { get; set; }
        public SAGE100CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
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

    public class SAGE100CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
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

    public class bodySalesOrderLineItemInputItem
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

    public class CommercientCPQCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public CommercientCPQCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CommercientCPQCreateNewCustomerResponseDataType
    {
        public string BillingCity { get; set; }
        public string BillingCounty { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingState { get; set; }
        public string BillingStreet { get; set; }
        public string GUID { get; set; }
        public string Name { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingPostalCode { get; set; }
        public string ShippingState { get; set; }
        public string ShippingStreet { get; set; }

        [JsonProperty("acnm")]
        public string Acnm { get; set; }
    }

    public class CommercientCPQCreateNewProductResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public CommercientCPQCreateNewProductResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CommercientCPQCreateNewProductResponseDataType
    {
        public string StockCode { get; set; }
    }

    public class CommercientCPQCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public CommercientCPQCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CommercientCPQCreateNewSalesOrderResponseDataType
    {
        public string OrderHeaderGUID { get; set; }
        public CommercientCPQCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
    }

    public class CommercientCPQCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public string Price { get; set; }
        public string Qty { get; set; }
        public string StockCode { get; set; }
    }

    public class bodySalesOrderLineItemInputItem2
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
        public string ListID { get; set; }
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
        public string CustomerRefListID { get; set; }
        public string CustomerRefName { get; set; }
        public string CustomerSalesTaxCodeRef { get; set; }
        public string DueDate { get; set; }
        public string EditSequence { get; set; }
        public string ExtraField { get; set; }
        public string ItemSalesTaxRef { get; set; }
        public string ListID { get; set; }
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
        public string ItemListID { get; set; }
        public string ItemRef { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public string SalesTaxCodeRef { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class bodySalesOrderLineItemInputItem22
    {
        public int Amount { get; set; }
        public string ClassRef { get; set; }
        public string Desc { get; set; }
        public string EditSequence { get; set; }
        public string ItemListID { get; set; }
        public string ItemRef { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public string SalesTaxCodeRef { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class SAGE50UKCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAGE50UKCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAGE50UKCreateNewCustomerResponseDataType
    {
        [JsonProperty("ACCOUNT_OPENED")]
        public string ACCOUNTOPENED { get; set; }

        [JsonProperty("ACCOUNT_REF")]
        public string ACCOUNTREF { get; set; }

        [JsonProperty("ACCOUNT_STATUS")]
        public int ACCOUNTSTATUS { get; set; }

        [JsonProperty("ADDRESS_1")]
        public string ADDRESS1 { get; set; }

        [JsonProperty("ADDRESS_2")]
        public string ADDRESS2 { get; set; }

        [JsonProperty("ADDRESS_3")]
        public string ADDRESS3 { get; set; }

        [JsonProperty("ADDRESS_4")]
        public string ADDRESS4 { get; set; }

        [JsonProperty("ADDRESS_5")]
        public string ADDRESS5 { get; set; }

        [JsonProperty("ANALYSIS_1")]
        public string ANALYSIS1 { get; set; }

        [JsonProperty("ANALYSIS_2")]
        public string ANALYSIS2 { get; set; }

        [JsonProperty("ANALYSIS_3")]
        public string ANALYSIS3 { get; set; }

        [JsonProperty("AVERAGE_PAY_DAYS")]
        public int AVERAGEPAYDAYS { get; set; }
        public int BALANCE { get; set; }

        [JsonProperty("CAN_APPLY_CHARGES")]
        public bool CANAPPLYCHARGES { get; set; }

        [JsonProperty("CONTACT_NAME")]
        public string CONTACTNAME { get; set; }

        [JsonProperty("COUNTRY_CODE")]
        public string COUNTRYCODE { get; set; }

        [JsonProperty("CREDIT_APPLIED_FOR")]
        public string CREDITAPPLIEDFOR { get; set; }

        [JsonProperty("CREDIT_BUREAU")]
        public int CREDITBUREAU { get; set; }

        [JsonProperty("CREDIT_LIMIT")]
        public int CREDITLIMIT { get; set; }

        [JsonProperty("CREDIT_POSITION")]
        public int CREDITPOSITION { get; set; }

        [JsonProperty("CREDIT_POSITIONSpecified")]
        public bool CREDITPOSITIONSpecified { get; set; }

        [JsonProperty("CREDIT_REFERENCE")]
        public string CREDITREFERENCE { get; set; }
        public int CURRENCY { get; set; }

        [JsonProperty("DATE_CREDIT_APP_RECEIVED")]
        public string DATECREDITAPPRECEIVED { get; set; }

        [JsonProperty("DEF_NOM_CODE")]
        public string DEFNOMCODE { get; set; }

        [JsonProperty("DEF_TAX_CODE")]
        public int DEFTAXCODE { get; set; }

        [JsonProperty("DEPT_NUMBER")]
        public int DEPTNUMBER { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int DISCOUNTRATE { get; set; }

        [JsonProperty("DISCOUNT_TYPE")]
        public int DISCOUNTTYPE { get; set; }

        [JsonProperty("DUNS_NUMBER")]
        public string DUNSNUMBER { get; set; }

        [JsonProperty("E_MAIL")]
        public string EMAIL { get; set; }

        [JsonProperty("E_MAIL2")]
        public string EMAIL2 { get; set; }

        [JsonProperty("E_MAIL3")]
        public string EMAIL3 { get; set; }
        public string FAX { get; set; }

        [JsonProperty("HOLD_MAIL")]
        public bool HOLDMAIL { get; set; }

        [JsonProperty("INACTIVE_FLAG")]
        public bool INACTIVEFLAG { get; set; }

        [JsonProperty("LAST_CREDIT_REV")]
        public string LASTCREDITREV { get; set; }
        public string NAME { get; set; }

        [JsonProperty("NEXT_CREDIT_REV")]
        public string NEXTCREDITREV { get; set; }

        [JsonProperty("OVERRIDE_PRODUCT_NOMINAL")]
        public bool OVERRIDEPRODUCTNOMINAL { get; set; }

        [JsonProperty("OVERRIDE_PRODUCT_TAX")]
        public bool OVERRIDEPRODUCTTAX { get; set; }

        [JsonProperty("PAYMENT_DUE_DAYS")]
        public int PAYMENTDUEDAYS { get; set; }

        [JsonProperty("PRICE_LIST_REF")]
        public string PRICELISTREF { get; set; }

        [JsonProperty("PRIORITY_TRADER")]
        public bool PRIORITYTRADER { get; set; }

        [JsonProperty("SEND_INVOICES_ELECTRONICALLY")]
        public bool SENDINVOICESELECTRONICALLY { get; set; }

        [JsonProperty("SEND_LETTERS_ELECTRONICALLY")]
        public bool SENDLETTERSELECTRONICALLY { get; set; }

        [JsonProperty("SETTLEMENT_DISC_RATE")]
        public int SETTLEMENTDISCRATE { get; set; }

        [JsonProperty("SETTLEMENT_DUE_DAYS")]
        public int SETTLEMENTDUEDAYS { get; set; }
        public string TELEPHONE { get; set; }

        [JsonProperty("TELEPHONE_2")]
        public string TELEPHONE2 { get; set; }
        public string TERMS { get; set; }

        [JsonProperty("TERMS_AGREED_FLAG")]
        public bool TERMSAGREEDFLAG { get; set; }

        [JsonProperty("TRADE_CONTACT")]
        public string TRADECONTACT { get; set; }

        [JsonProperty("VAT_REG_NUMBER")]
        public string VATREGNUMBER { get; set; }
    }

    public class SAGE50UKCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAGE50UKCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAGE50UKCreateNewSalesOrderResponseDataType
    {
        [JsonProperty("ACCOUNT_REF")]
        public string ACCOUNTREF { get; set; }

        [JsonProperty("ADDRESS_1")]
        public string ADDRESS1 { get; set; }

        [JsonProperty("ADDRESS_2")]
        public string ADDRESS2 { get; set; }

        [JsonProperty("ADDRESS_3")]
        public string ADDRESS3 { get; set; }

        [JsonProperty("ADDRESS_4")]
        public string ADDRESS4 { get; set; }

        [JsonProperty("ADDRESS_5")]
        public string ADDRESS5 { get; set; }

        [JsonProperty("AMOUNT_PREPAID")]
        public int AMOUNTPREPAID { get; set; }

        [JsonProperty("ANALYSIS_1")]
        public string ANALYSIS1 { get; set; }

        [JsonProperty("ANALYSIS_2")]
        public string ANALYSIS2 { get; set; }

        [JsonProperty("ANALYSIS_3")]
        public string ANALYSIS3 { get; set; }

        [JsonProperty("CARR_DEPT_NUMBER")]
        public int CARRDEPTNUMBER { get; set; }

        [JsonProperty("CARR_NET")]
        public int CARRNET { get; set; }

        [JsonProperty("CARR_NOM_CODE")]
        public string CARRNOMCODE { get; set; }

        [JsonProperty("CARR_TAX")]
        public int CARRTAX { get; set; }

        [JsonProperty("CARR_TAX_CODE")]
        public int CARRTAXCODE { get; set; }

        [JsonProperty("CONSIGNMENT_REF")]
        public string CONSIGNMENTREF { get; set; }

        [JsonProperty("CONTACT_NAME")]
        public string CONTACTNAME { get; set; }
        public int COURIER { get; set; }
        public int CURRENCY { get; set; }

        [JsonProperty("CUST_DISC_RATE")]
        public int CUSTDISCRATE { get; set; }

        [JsonProperty("CUST_ORDER_NUMBER")]
        public string CUSTORDERNUMBER { get; set; }

        [JsonProperty("CUST_TEL_NUMBER")]
        public string CUSTTELNUMBER { get; set; }

        [JsonProperty("DEF_TAX_CODE")]
        public int DEFTAXCODE { get; set; }

        [JsonProperty("DELETED_FLAG")]
        public bool DELETEDFLAG { get; set; }

        [JsonProperty("DELIVERY_NAME")]
        public string DELIVERYNAME { get; set; }

        [JsonProperty("DEL_ADDRESS_1")]
        public string DELADDRESS1 { get; set; }

        [JsonProperty("DEL_ADDRESS_2")]
        public string DELADDRESS2 { get; set; }

        [JsonProperty("DEL_ADDRESS_3")]
        public string DELADDRESS3 { get; set; }

        [JsonProperty("DEL_ADDRESS_4")]
        public string DELADDRESS4 { get; set; }

        [JsonProperty("DEL_ADDRESS_5")]
        public string DELADDRESS5 { get; set; }

        [JsonProperty("DESPATCH_DATE")]
        public string DESPATCHDATE { get; set; }

        [JsonProperty("DUNS_NUMBER")]
        public string DUNSNUMBER { get; set; }

        [JsonProperty("GLOBAL_DEPT_NUMBER")]
        public int GLOBALDEPTNUMBER { get; set; }

        [JsonProperty("GLOBAL_DETAILS")]
        public string GLOBALDETAILS { get; set; }

        [JsonProperty("GLOBAL_NOM_CODE")]
        public string GLOBALNOMCODE { get; set; }

        [JsonProperty("GLOBAL_TAX_CODE")]
        public int GLOBALTAXCODE { get; set; }

        [JsonProperty("INVOICE_NUMBER")]
        public string INVOICENUMBER { get; set; }
        public string NAME { get; set; }

        [JsonProperty("ORDER_DATE")]
        public string ORDERDATE { get; set; }

        [JsonProperty("ORDER_NUMBER")]
        public int ORDERNUMBER { get; set; }

        [JsonProperty("ORDER_TYPE")]
        public int ORDERTYPE { get; set; }

        [JsonProperty("SETTLEMENT_DISC_RATE")]
        public int SETTLEMENTDISCRATE { get; set; }

        [JsonProperty("SETTLEMENT_DUE_DAYS")]
        public int SETTLEMENTDUEDAYS { get; set; }
        public SAGE50UKCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
    }

    public class SAGE50UKCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public string DESCRIPTION { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int DISCOUNTRATE { get; set; }

        [JsonProperty("QTY_ORDER")]
        public int QTYORDER { get; set; }

        [JsonProperty("STOCK_CODE")]
        public string STOCKCODE { get; set; }

        [JsonProperty("UNIT_PRICE")]
        public int UNITPRICE { get; set; }
    }

    public class bodySalesOrderLineItemInputItem222
    {
        public string DESCRIPTION { get; set; }

        [JsonProperty("DISCOUNT_RATE")]
        public int DISCOUNTRATE { get; set; }

        [JsonProperty("QTY_ORDER")]
        public int QTYORDER { get; set; }

        [JsonProperty("STOCK_CODE")]
        public string STOCKCODE { get; set; }

        [JsonProperty("UNIT_PRICE")]
        public int UNITPRICE { get; set; }
    }

    public class SAGE50USCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAGE50USCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAGE50USCreateNewCustomerResponseDataType
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
        public string CustomerGUID { get; set; }
        public string CustomerID { get; set; }

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
        public string SalesRepresentativeID { get; set; }

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
        public bool UseCODTerms { get; set; }

        [JsonProperty("Use_Due_Month_End_Terms")]
        public bool UseDueMonthEndTerms { get; set; }

        [JsonProperty("Use_Prepaid_Terms")]
        public bool UsePrepaidTerms { get; set; }

        [JsonProperty("Use_Standard_Terms")]
        public bool UseStandardTerms { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }
    }

    public class SAGE50USCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAGE50USCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAGE50USCreateNewSalesOrderResponseDataType
    {
        [JsonProperty("Accounts_Receivable_Account")]
        public string AccountsReceivableAccount { get; set; }

        [JsonProperty("Accounts_Receivable_Acct_GUID")]
        public string AccountsReceivableAcctGUID { get; set; }

        [JsonProperty("Accounts_Receivable_Amount")]
        public int AccountsReceivableAmount { get; set; }
        public bool Closed { get; set; }

        [JsonProperty("Customer_ID")]
        public string CustomerID { get; set; }

        [JsonProperty("Customer_PO")]
        public string CustomerPO { get; set; }
        public string Date { get; set; }

        [JsonProperty("Discount_Amount")]
        public int DiscountAmount { get; set; }

        [JsonProperty("Displayed_Terms")]
        public string DisplayedTerms { get; set; }

        [JsonProperty("Drop_Ship")]
        public bool DropShip { get; set; }
        public string GUID { get; set; }

        [JsonProperty("Note_Prints_After_Line_Items")]
        public bool NotePrintsAfterLineItems { get; set; }
        public bool Proposal { get; set; }
        public bool ProposalAccepted { get; set; }
        public SAGE50USCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }

        [JsonProperty("Sales_Order_Number")]
        public string SalesOrderNumber { get; set; }

        [JsonProperty("Sales_Representative_GUID")]
        public string SalesRepresentativeGUID { get; set; }

        [JsonProperty("Sales_Representative_ID")]
        public string SalesRepresentativeID { get; set; }
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
        public string ShipVIA { get; set; }

        [JsonProperty("Statement_Note_Prints_Before_Inv_Ref")]
        public bool StatementNotePrintsBeforeInvRef { get; set; }
    }

    public class SAGE50USCreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
    {
        public int Amount { get; set; }
        public int DistributionNumber { get; set; }

        [JsonProperty("GL_Account")]
        public string GLAccount { get; set; }

        [JsonProperty("GL_Account_GUID")]
        public string GLAccountGUID { get; set; }

        [JsonProperty("Item_GUID")]
        public string ItemGUID { get; set; }

        [JsonProperty("Item_ID")]
        public string ItemID { get; set; }

        [JsonProperty("Job_GUID")]
        public string JobGUID { get; set; }

        [JsonProperty("Job_ID")]
        public string JobID { get; set; }
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
        public string UMID { get; set; }

        [JsonProperty("UM_Stocking_Units")]
        public int UMStockingUnits { get; set; }

        [JsonProperty("Unit_Price")]
        public int UnitPrice { get; set; }
        public int Weight { get; set; }
    }

    public class bodySalesOrderLineItemInputItem2222
    {
        public int Amount { get; set; }
        public int DistributionNumber { get; set; }

        [JsonProperty("GL_Account")]
        public string GLAccount { get; set; }

        [JsonProperty("GL_Account_GUID")]
        public string GLAccountGUID { get; set; }

        [JsonProperty("Item_GUID")]
        public string ItemGUID { get; set; }

        [JsonProperty("Item_ID")]
        public string ItemID { get; set; }

        [JsonProperty("Job_GUID")]
        public string JobGUID { get; set; }

        [JsonProperty("Job_ID")]
        public string JobID { get; set; }
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
        public string UMID { get; set; }

        [JsonProperty("UM_Stocking_Units")]
        public int UMStockingUnits { get; set; }

        [JsonProperty("Unit_Price")]
        public int UnitPrice { get; set; }
        public int Weight { get; set; }
    }

    public class SAPB1CreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAPB1CreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAPB1CreateNewCustomerResponseDataType
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
        public SAPB1CreateNewCustomerResponseDataTypeLstContactEmployeesTypeItem[] LstContactEmployees { get; set; }
    }

    public class SAPB1CreateNewCustomerResponseDataTypeLstContactEmployeesTypeItem
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

    public class bodylstContactEmployeesInputItem
    {
        public string Address { get; set; }
        public string CityOfBirth { get; set; }
        public string DateOfBirth { get; set; }

        [JsonProperty("E_Mail")]
        public string EMail { get; set; }
        public string Fax { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public int InternalCode { get; set; }
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

    public class SAPB1CreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SAPB1CreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SAPB1CreateNewSalesOrderResponseDataType
    {
        public string CardCode { get; set; }
        public string DocDate { get; set; }
        public bool DocDateSpecified { get; set; }
        public string DocDueDate { get; set; }
        public bool DocDueDateSpecified { get; set; }
        public int DocNum { get; set; }
        public bool DocNumSpecified { get; set; }
        public SAPB1CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem[] SalesOrderLineItem { get; set; }
        public int Series { get; set; }
        public bool SeriesSpecified { get; set; }
        public string TaxDate { get; set; }
        public bool TaxDateSpecified { get; set; }
    }

    public class SAPB1CreateNewSalesOrderResponseDataTypeSalesOrderLineItemTypeItem
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

    public class bodySalesOrderLineItemInputItem22222
    {
        public int DiscountPercent { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public string WarehouseCode { get; set; }
    }

    public class SYSPROCreateNewCustomerResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SYSPROCreateNewCustomerResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SYSPROCreateNewCustomerResponseDataType
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
        public string TagsToDropFromXML { get; set; }
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

    public class SYSPROCreateNewSalesOrderResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public SYSPROCreateNewSalesOrderResponseDataType Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SYSPROCreateNewSalesOrderResponseDataType
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
        public string POSSalesOrder { get; set; }
        public string Process { get; set; }
        public string ProcessFlag { get; set; }
        public string PutEntireQuantityOnNewLoadWhenChanged { get; set; }
        public string ReceiverCode { get; set; }
        public string RequestedShipDate { get; set; }
        public string ReserveStock { get; set; }
        public string ReserveStockRequestAllocs { get; set; }
        public string SalesOrder { get; set; }
        public SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderDetailsTypeItem[] SalesOrderDetails { get; set; }
        public SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderFooterCommentsTypeItem[] SalesOrderFooterComments { get; set; }
        public SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderFreightDetailsTypeItem[] SalesOrderFreightDetails { get; set; }
        public SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderHeaderCommentsTypeItem[] SalesOrderHeaderComments { get; set; }
        public SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderMiscChargesDetailsTypeItem[] SalesOrderMiscChargesDetails { get; set; }
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
        public string TagsToDropFromXML { get; set; }
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

    public class SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderDetailsTypeItem
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

    public class SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderFooterCommentsTypeItem
    {
        public string FooterComment { get; set; }
        public string FooterCommentType { get; set; }
        public string FooterLineActionType { get; set; }
    }

    public class SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderFreightDetailsTypeItem
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

    public class SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderHeaderCommentsTypeItem
    {
        public string HeaderComment { get; set; }
        public string HeaderCommentType { get; set; }
        public string HeaderLineActionType { get; set; }
    }

    public class SYSPROCreateNewSalesOrderResponseDataTypeSalesOrderMiscChargesDetailsTypeItem
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

    public class bodySalesOrderDetailsInputItem
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

    public class bodySalesOrderFooterCommentsInputItem
    {
        public string FooterComment { get; set; }
        public string FooterCommentType { get; set; }
        public string FooterLineActionType { get; set; }
    }

    public class bodySalesOrderFreightDetailsInputItem
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

    public class bodySalesOrderHeaderCommentsInputItem
    {
        public string HeaderComment { get; set; }
        public string HeaderCommentType { get; set; }
        public string HeaderLineActionType { get; set; }
    }

    public class bodySalesOrderMiscChargesDetailsInputItem
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