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
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> SAGE100CreateNewCustomer(Expression<Func<string>> bodyaRDivisionNo = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodyaddressLine3 = null, Expression<Func<bool>> bodybatchFax = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactCode = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<bool>> bodycreditHold = null, Expression<Func<int>> bodycreditLimit = null, Expression<Func<int>> bodycustomerDiscountRate = null, Expression<Func<string>> bodycustomerName = null, Expression<Func<string>> bodycustomerNo = null, Expression<Func<string>> bodycustomerType = null, Expression<Func<string>> bodydefaultCreditCardPmtType = null, Expression<Func<string>> bodydefaultItemCode = null, Expression<Func<string>> bodydefaultPaymentType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyfaxNo = null, Expression<Func<bool>> bodyopenItemCustomer = null, Expression<Func<string>> bodypriceLevel = null, Expression<Func<string>> bodyprimaryShipToCode = null, Expression<Func<bool>> bodyprintDunningMessage = null, Expression<Func<bool>> bodyresidentialAddress = null, Expression<Func<string>> bodysalespersonNo = null, Expression<Func<string>> bodyshipMethod = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodystatementCycle = null, Expression<Func<string>> bodytaxExemptNo = null, Expression<Func<string>> bodytaxSchedule = null, Expression<Func<string>> bodytelephoneExt = null, Expression<Func<string>> bodytelephoneNo = null, Expression<Func<string>> bodytermsCode = null, Expression<Func<string>> bodyuRLAddress = null, Expression<Func<string>> bodyzipCode = null)
        {
            var apiCallPath = "/api/v1/SAGE100/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaRDivisionNo != null)
            {
                body["ARDivisionNo"] = ExpressionConverter.ConvertO(bodyaRDivisionNo);
                bodypropCount++;
            }

            if (bodyaddressLine1 != null)
            {
                body["AddressLine1"] = ExpressionConverter.ConvertO(bodyaddressLine1);
                bodypropCount++;
            }

            if (bodyaddressLine2 != null)
            {
                body["AddressLine2"] = ExpressionConverter.ConvertO(bodyaddressLine2);
                bodypropCount++;
            }

            if (bodyaddressLine3 != null)
            {
                body["AddressLine3"] = ExpressionConverter.ConvertO(bodyaddressLine3);
                bodypropCount++;
            }

            if (bodybatchFax != null)
            {
                body["BatchFax"] = ExpressionConverter.ConvertO(bodybatchFax);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodycontactCode != null)
            {
                body["ContactCode"] = ExpressionConverter.ConvertO(bodycontactCode);
                bodypropCount++;
            }

            if (bodycountryCode != null)
            {
                body["CountryCode"] = ExpressionConverter.ConvertO(bodycountryCode);
                bodypropCount++;
            }

            if (bodycreditHold != null)
            {
                body["CreditHold"] = ExpressionConverter.ConvertO(bodycreditHold);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["CreditLimit"] = ExpressionConverter.ConvertO(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycustomerDiscountRate != null)
            {
                body["CustomerDiscountRate"] = ExpressionConverter.ConvertO(bodycustomerDiscountRate);
                bodypropCount++;
            }

            if (bodycustomerName != null)
            {
                body["CustomerName"] = ExpressionConverter.ConvertO(bodycustomerName);
                bodypropCount++;
            }

            if (bodycustomerNo != null)
            {
                body["CustomerNo"] = ExpressionConverter.ConvertO(bodycustomerNo);
                bodypropCount++;
            }

            if (bodycustomerType != null)
            {
                body["CustomerType"] = ExpressionConverter.ConvertO(bodycustomerType);
                bodypropCount++;
            }

            if (bodydefaultCreditCardPmtType != null)
            {
                body["DefaultCreditCardPmtType"] = ExpressionConverter.ConvertO(bodydefaultCreditCardPmtType);
                bodypropCount++;
            }

            if (bodydefaultItemCode != null)
            {
                body["DefaultItemCode"] = ExpressionConverter.ConvertO(bodydefaultItemCode);
                bodypropCount++;
            }

            if (bodydefaultPaymentType != null)
            {
                body["DefaultPaymentType"] = ExpressionConverter.ConvertO(bodydefaultPaymentType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyfaxNo != null)
            {
                body["FaxNo"] = ExpressionConverter.ConvertO(bodyfaxNo);
                bodypropCount++;
            }

            if (bodyopenItemCustomer != null)
            {
                body["OpenItemCustomer"] = ExpressionConverter.ConvertO(bodyopenItemCustomer);
                bodypropCount++;
            }

            if (bodypriceLevel != null)
            {
                body["PriceLevel"] = ExpressionConverter.ConvertO(bodypriceLevel);
                bodypropCount++;
            }

            if (bodyprimaryShipToCode != null)
            {
                body["PrimaryShipToCode"] = ExpressionConverter.ConvertO(bodyprimaryShipToCode);
                bodypropCount++;
            }

            if (bodyprintDunningMessage != null)
            {
                body["PrintDunningMessage"] = ExpressionConverter.ConvertO(bodyprintDunningMessage);
                bodypropCount++;
            }

            if (bodyresidentialAddress != null)
            {
                body["ResidentialAddress"] = ExpressionConverter.ConvertO(bodyresidentialAddress);
                bodypropCount++;
            }

            if (bodysalespersonNo != null)
            {
                body["SalespersonNo"] = ExpressionConverter.ConvertO(bodysalespersonNo);
                bodypropCount++;
            }

            if (bodyshipMethod != null)
            {
                body["ShipMethod"] = ExpressionConverter.ConvertO(bodyshipMethod);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["State"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodystatementCycle != null)
            {
                body["StatementCycle"] = ExpressionConverter.ConvertO(bodystatementCycle);
                bodypropCount++;
            }

            if (bodytaxExemptNo != null)
            {
                body["TaxExemptNo"] = ExpressionConverter.ConvertO(bodytaxExemptNo);
                bodypropCount++;
            }

            if (bodytaxSchedule != null)
            {
                body["TaxSchedule"] = ExpressionConverter.ConvertO(bodytaxSchedule);
                bodypropCount++;
            }

            if (bodytelephoneExt != null)
            {
                body["TelephoneExt"] = ExpressionConverter.ConvertO(bodytelephoneExt);
                bodypropCount++;
            }

            if (bodytelephoneNo != null)
            {
                body["TelephoneNo"] = ExpressionConverter.ConvertO(bodytelephoneNo);
                bodypropCount++;
            }

            if (bodytermsCode != null)
            {
                body["TermsCode"] = ExpressionConverter.ConvertO(bodytermsCode);
                bodypropCount++;
            }

            if (bodyuRLAddress != null)
            {
                body["URLAddress"] = ExpressionConverter.ConvertO(bodyuRLAddress);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["ZipCode"] = ExpressionConverter.ConvertO(bodyzipCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE100CreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> SAGE100CreateNewSalesOrder(Expression<Func<string>> bodyaRDivisionNo = null, Expression<Func<bool>> bodybatchFax = null, Expression<Func<string>> bodybillToAddress1 = null, Expression<Func<string>> bodybillToAddress2 = null, Expression<Func<string>> bodybillToAddress3 = null, Expression<Func<string>> bodybillToCity = null, Expression<Func<string>> bodybillToCountryCode = null, Expression<Func<string>> bodybillToName = null, Expression<Func<string>> bodybillToState = null, Expression<Func<string>> bodybillToZipCode = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyconfirmTo = null, Expression<Func<string>> bodycustomerNo = null, Expression<Func<string>> bodycustomerPONo = null, Expression<Func<string>> bodycycleCode = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyfOB = null, Expression<Func<string>> bodyfaxNo = null, Expression<Func<string>> bodymasterRepeatingOrderNo = null, Expression<Func<int>> bodynumberOfShippingLabels = null, Expression<Func<string>> bodyorderDate = null, Expression<Func<string>> bodyorderStatus = null, Expression<Func<string>> bodyorderType = null, Expression<Func<bool>> bodyprintPickingSheets = null, Expression<Func<bool>> bodyprintSalesOrders = null, Expression<Func<bodysalesOrderLineItemInputItem[]>> bodysalesOrderLineItem = null, Expression<Func<string>> bodysalesOrderNo = null, Expression<Func<string>> bodysalespersonNo = null, Expression<Func<string>> bodyshipExpireDate = null, Expression<Func<string>> bodyshipToAddress1 = null, Expression<Func<string>> bodyshipToAddress2 = null, Expression<Func<string>> bodyshipToAddress3 = null, Expression<Func<string>> bodyshipToCity = null, Expression<Func<string>> bodyshipToCode = null, Expression<Func<string>> bodyshipToCountryCode = null, Expression<Func<string>> bodyshipToName = null, Expression<Func<string>> bodyshipToState = null, Expression<Func<string>> bodyshipToZipCode = null, Expression<Func<string>> bodyshipVia = null, Expression<Func<int>> bodyshipWeight = null, Expression<Func<string>> bodyshipZoneActual = null, Expression<Func<string>> bodysplitCommissions = null, Expression<Func<string>> bodytaxExemptNo = null, Expression<Func<string>> bodytaxSchedule = null, Expression<Func<string>> bodytermsCode = null, Expression<Func<string>> bodywarehouseCode = null)
        {
            var apiCallPath = "/api/v1/SAGE100/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaRDivisionNo != null)
            {
                body["ARDivisionNo"] = ExpressionConverter.ConvertO(bodyaRDivisionNo);
                bodypropCount++;
            }

            if (bodybatchFax != null)
            {
                body["BatchFax"] = ExpressionConverter.ConvertO(bodybatchFax);
                bodypropCount++;
            }

            if (bodybillToAddress1 != null)
            {
                body["BillToAddress1"] = ExpressionConverter.ConvertO(bodybillToAddress1);
                bodypropCount++;
            }

            if (bodybillToAddress2 != null)
            {
                body["BillToAddress2"] = ExpressionConverter.ConvertO(bodybillToAddress2);
                bodypropCount++;
            }

            if (bodybillToAddress3 != null)
            {
                body["BillToAddress3"] = ExpressionConverter.ConvertO(bodybillToAddress3);
                bodypropCount++;
            }

            if (bodybillToCity != null)
            {
                body["BillToCity"] = ExpressionConverter.ConvertO(bodybillToCity);
                bodypropCount++;
            }

            if (bodybillToCountryCode != null)
            {
                body["BillToCountryCode"] = ExpressionConverter.ConvertO(bodybillToCountryCode);
                bodypropCount++;
            }

            if (bodybillToName != null)
            {
                body["BillToName"] = ExpressionConverter.ConvertO(bodybillToName);
                bodypropCount++;
            }

            if (bodybillToState != null)
            {
                body["BillToState"] = ExpressionConverter.ConvertO(bodybillToState);
                bodypropCount++;
            }

            if (bodybillToZipCode != null)
            {
                body["BillToZipCode"] = ExpressionConverter.ConvertO(bodybillToZipCode);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["Comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodyconfirmTo != null)
            {
                body["ConfirmTo"] = ExpressionConverter.ConvertO(bodyconfirmTo);
                bodypropCount++;
            }

            if (bodycustomerNo != null)
            {
                body["CustomerNo"] = ExpressionConverter.ConvertO(bodycustomerNo);
                bodypropCount++;
            }

            if (bodycustomerPONo != null)
            {
                body["CustomerPONo"] = ExpressionConverter.ConvertO(bodycustomerPONo);
                bodypropCount++;
            }

            if (bodycycleCode != null)
            {
                body["CycleCode"] = ExpressionConverter.ConvertO(bodycycleCode);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyfOB != null)
            {
                body["FOB"] = ExpressionConverter.ConvertO(bodyfOB);
                bodypropCount++;
            }

            if (bodyfaxNo != null)
            {
                body["FaxNo"] = ExpressionConverter.ConvertO(bodyfaxNo);
                bodypropCount++;
            }

            if (bodymasterRepeatingOrderNo != null)
            {
                body["MasterRepeatingOrderNo"] = ExpressionConverter.ConvertO(bodymasterRepeatingOrderNo);
                bodypropCount++;
            }

            if (bodynumberOfShippingLabels != null)
            {
                body["NumberOfShippingLabels"] = ExpressionConverter.ConvertO(bodynumberOfShippingLabels);
                bodypropCount++;
            }

            if (bodyorderDate != null)
            {
                body["OrderDate"] = ExpressionConverter.ConvertO(bodyorderDate);
                bodypropCount++;
            }

            if (bodyorderStatus != null)
            {
                body["OrderStatus"] = ExpressionConverter.ConvertO(bodyorderStatus);
                bodypropCount++;
            }

            if (bodyorderType != null)
            {
                body["OrderType"] = ExpressionConverter.ConvertO(bodyorderType);
                bodypropCount++;
            }

            if (bodyprintPickingSheets != null)
            {
                body["PrintPickingSheets"] = ExpressionConverter.ConvertO(bodyprintPickingSheets);
                bodypropCount++;
            }

            if (bodyprintSalesOrders != null)
            {
                body["PrintSalesOrders"] = ExpressionConverter.ConvertO(bodyprintSalesOrders);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodysalesOrderNo != null)
            {
                body["SalesOrderNo"] = ExpressionConverter.ConvertO(bodysalesOrderNo);
                bodypropCount++;
            }

            if (bodysalespersonNo != null)
            {
                body["SalespersonNo"] = ExpressionConverter.ConvertO(bodysalespersonNo);
                bodypropCount++;
            }

            if (bodyshipExpireDate != null)
            {
                body["ShipExpireDate"] = ExpressionConverter.ConvertO(bodyshipExpireDate);
                bodypropCount++;
            }

            if (bodyshipToAddress1 != null)
            {
                body["ShipToAddress1"] = ExpressionConverter.ConvertO(bodyshipToAddress1);
                bodypropCount++;
            }

            if (bodyshipToAddress2 != null)
            {
                body["ShipToAddress2"] = ExpressionConverter.ConvertO(bodyshipToAddress2);
                bodypropCount++;
            }

            if (bodyshipToAddress3 != null)
            {
                body["ShipToAddress3"] = ExpressionConverter.ConvertO(bodyshipToAddress3);
                bodypropCount++;
            }

            if (bodyshipToCity != null)
            {
                body["ShipToCity"] = ExpressionConverter.ConvertO(bodyshipToCity);
                bodypropCount++;
            }

            if (bodyshipToCode != null)
            {
                body["ShipToCode"] = ExpressionConverter.ConvertO(bodyshipToCode);
                bodypropCount++;
            }

            if (bodyshipToCountryCode != null)
            {
                body["ShipToCountryCode"] = ExpressionConverter.ConvertO(bodyshipToCountryCode);
                bodypropCount++;
            }

            if (bodyshipToName != null)
            {
                body["ShipToName"] = ExpressionConverter.ConvertO(bodyshipToName);
                bodypropCount++;
            }

            if (bodyshipToState != null)
            {
                body["ShipToState"] = ExpressionConverter.ConvertO(bodyshipToState);
                bodypropCount++;
            }

            if (bodyshipToZipCode != null)
            {
                body["ShipToZipCode"] = ExpressionConverter.ConvertO(bodyshipToZipCode);
                bodypropCount++;
            }

            if (bodyshipVia != null)
            {
                body["ShipVia"] = ExpressionConverter.ConvertO(bodyshipVia);
                bodypropCount++;
            }

            if (bodyshipWeight != null)
            {
                body["ShipWeight"] = ExpressionConverter.ConvertO(bodyshipWeight);
                bodypropCount++;
            }

            if (bodyshipZoneActual != null)
            {
                body["ShipZoneActual"] = ExpressionConverter.ConvertO(bodyshipZoneActual);
                bodypropCount++;
            }

            if (bodysplitCommissions != null)
            {
                body["SplitCommissions"] = ExpressionConverter.ConvertO(bodysplitCommissions);
                bodypropCount++;
            }

            if (bodytaxExemptNo != null)
            {
                body["TaxExemptNo"] = ExpressionConverter.ConvertO(bodytaxExemptNo);
                bodypropCount++;
            }

            if (bodytaxSchedule != null)
            {
                body["TaxSchedule"] = ExpressionConverter.ConvertO(bodytaxSchedule);
                bodypropCount++;
            }

            if (bodytermsCode != null)
            {
                body["TermsCode"] = ExpressionConverter.ConvertO(bodytermsCode);
                bodypropCount++;
            }

            if (bodywarehouseCode != null)
            {
                body["WarehouseCode"] = ExpressionConverter.ConvertO(bodywarehouseCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE100CreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> CommercientCPQCreateNewCustomer(Expression<Func<string>> bodybillingCity = null, Expression<Func<string>> bodybillingCounty = null, Expression<Func<string>> bodybillingPostalCode = null, Expression<Func<string>> bodybillingState = null, Expression<Func<string>> bodybillingStreet = null, Expression<Func<string>> bodygUID = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyshippingCity = null, Expression<Func<string>> bodyshippingCountry = null, Expression<Func<string>> bodyshippingPostalCode = null, Expression<Func<string>> bodyshippingState = null, Expression<Func<string>> bodyshippingStreet = null, Expression<Func<string>> bodyacnm = null)
        {
            var apiCallPath = "/api/v1/commercientcpq/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybillingCity != null)
            {
                body["BillingCity"] = ExpressionConverter.ConvertO(bodybillingCity);
                bodypropCount++;
            }

            if (bodybillingCounty != null)
            {
                body["BillingCounty"] = ExpressionConverter.ConvertO(bodybillingCounty);
                bodypropCount++;
            }

            if (bodybillingPostalCode != null)
            {
                body["BillingPostalCode"] = ExpressionConverter.ConvertO(bodybillingPostalCode);
                bodypropCount++;
            }

            if (bodybillingState != null)
            {
                body["BillingState"] = ExpressionConverter.ConvertO(bodybillingState);
                bodypropCount++;
            }

            if (bodybillingStreet != null)
            {
                body["BillingStreet"] = ExpressionConverter.ConvertO(bodybillingStreet);
                bodypropCount++;
            }

            if (bodygUID != null)
            {
                body["GUID"] = ExpressionConverter.ConvertO(bodygUID);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyshippingCity != null)
            {
                body["ShippingCity"] = ExpressionConverter.ConvertO(bodyshippingCity);
                bodypropCount++;
            }

            if (bodyshippingCountry != null)
            {
                body["ShippingCountry"] = ExpressionConverter.ConvertO(bodyshippingCountry);
                bodypropCount++;
            }

            if (bodyshippingPostalCode != null)
            {
                body["ShippingPostalCode"] = ExpressionConverter.ConvertO(bodyshippingPostalCode);
                bodypropCount++;
            }

            if (bodyshippingState != null)
            {
                body["ShippingState"] = ExpressionConverter.ConvertO(bodyshippingState);
                bodypropCount++;
            }

            if (bodyshippingStreet != null)
            {
                body["ShippingStreet"] = ExpressionConverter.ConvertO(bodyshippingStreet);
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
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> CommercientCPQCreateNewProduct(Expression<Func<string>> bodystockCode = null)
        {
            var apiCallPath = "/api/v1/commercientcpq/product";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystockCode != null)
            {
                body["StockCode"] = ExpressionConverter.ConvertO(bodystockCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewProductResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> CommercientCPQCreateNewSalesOrder(Expression<Func<string>> bodyorderHeaderGUID = null, Expression<Func<bodysalesOrderLineItemInputItem2[]>> bodysalesOrderLineItem = null)
        {
            var apiCallPath = "/api/v1/commercientcpq/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyorderHeaderGUID != null)
            {
                body["OrderHeaderGUID"] = ExpressionConverter.ConvertO(bodyorderHeaderGUID);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> QuickBookCreateNewCustomer(Expression<Func<string>> bodyaccountNumber = null, Expression<Func<string>> bodyaltContact = null, Expression<Func<string>> bodyaltPhone = null, Expression<Func<string>> bodybillAddressAddr1 = null, Expression<Func<string>> bodybillAddressAddr2 = null, Expression<Func<string>> bodybillAddressAddr3 = null, Expression<Func<string>> bodybillAddressAddr4 = null, Expression<Func<string>> bodybillAddressAddr5 = null, Expression<Func<string>> bodybillAddressCity = null, Expression<Func<string>> bodybillAddressCountry = null, Expression<Func<string>> bodybillAddressNote = null, Expression<Func<string>> bodybillAddressPostalCode = null, Expression<Func<string>> bodybillAddressState = null, Expression<Func<string>> bodycc = null, Expression<Func<string>> bodyclassRef = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodycontact = null, Expression<Func<int>> bodycreditLimit = null, Expression<Func<string>> bodycustomerTypeRef = null, Expression<Func<string>> bodyeditSequence = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<bool>> bodyisActive = null, Expression<Func<string>> bodyitemSalesTaxRef = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodylistID = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyopenBalance = null, Expression<Func<string>> bodyopenBalanceDate = null, Expression<Func<string>> bodyparentRef = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodypreferredPaymentMethodRef = null, Expression<Func<string>> bodypriceLevelRef = null, Expression<Func<string>> bodyresaleNumber = null, Expression<Func<string>> bodysalesRepRef = null, Expression<Func<string>> bodysalesTaxCodeRef = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyshipAddressAddr1 = null, Expression<Func<string>> bodyshipAddressAddr2 = null, Expression<Func<string>> bodyshipAddressAddr3 = null, Expression<Func<string>> bodyshipAddressAddr4 = null, Expression<Func<string>> bodyshipAddressAddr5 = null, Expression<Func<string>> bodyshipAddressCity = null, Expression<Func<string>> bodyshipAddressCountry = null, Expression<Func<string>> bodyshipAddressNote = null, Expression<Func<string>> bodyshipAddressPostalCode = null, Expression<Func<string>> bodyshipAddressState = null, Expression<Func<string>> bodytermsRef = null)
        {
            var apiCallPath = "/api/v1/quickbook/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccountNumber != null)
            {
                body["AccountNumber"] = ExpressionConverter.ConvertO(bodyaccountNumber);
                bodypropCount++;
            }

            if (bodyaltContact != null)
            {
                body["AltContact"] = ExpressionConverter.ConvertO(bodyaltContact);
                bodypropCount++;
            }

            if (bodyaltPhone != null)
            {
                body["AltPhone"] = ExpressionConverter.ConvertO(bodyaltPhone);
                bodypropCount++;
            }

            if (bodybillAddressAddr1 != null)
            {
                body["BillAddressAddr1"] = ExpressionConverter.ConvertO(bodybillAddressAddr1);
                bodypropCount++;
            }

            if (bodybillAddressAddr2 != null)
            {
                body["BillAddressAddr2"] = ExpressionConverter.ConvertO(bodybillAddressAddr2);
                bodypropCount++;
            }

            if (bodybillAddressAddr3 != null)
            {
                body["BillAddressAddr3"] = ExpressionConverter.ConvertO(bodybillAddressAddr3);
                bodypropCount++;
            }

            if (bodybillAddressAddr4 != null)
            {
                body["BillAddressAddr4"] = ExpressionConverter.ConvertO(bodybillAddressAddr4);
                bodypropCount++;
            }

            if (bodybillAddressAddr5 != null)
            {
                body["BillAddressAddr5"] = ExpressionConverter.ConvertO(bodybillAddressAddr5);
                bodypropCount++;
            }

            if (bodybillAddressCity != null)
            {
                body["BillAddressCity"] = ExpressionConverter.ConvertO(bodybillAddressCity);
                bodypropCount++;
            }

            if (bodybillAddressCountry != null)
            {
                body["BillAddressCountry"] = ExpressionConverter.ConvertO(bodybillAddressCountry);
                bodypropCount++;
            }

            if (bodybillAddressNote != null)
            {
                body["BillAddressNote"] = ExpressionConverter.ConvertO(bodybillAddressNote);
                bodypropCount++;
            }

            if (bodybillAddressPostalCode != null)
            {
                body["BillAddressPostalCode"] = ExpressionConverter.ConvertO(bodybillAddressPostalCode);
                bodypropCount++;
            }

            if (bodybillAddressState != null)
            {
                body["BillAddressState"] = ExpressionConverter.ConvertO(bodybillAddressState);
                bodypropCount++;
            }

            if (bodycc != null)
            {
                body["Cc"] = ExpressionConverter.ConvertO(bodycc);
                bodypropCount++;
            }

            if (bodyclassRef != null)
            {
                body["ClassRef"] = ExpressionConverter.ConvertO(bodyclassRef);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodycontact != null)
            {
                body["Contact"] = ExpressionConverter.ConvertO(bodycontact);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["CreditLimit"] = ExpressionConverter.ConvertO(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycustomerTypeRef != null)
            {
                body["CustomerTypeRef"] = ExpressionConverter.ConvertO(bodycustomerTypeRef);
                bodypropCount++;
            }

            if (bodyeditSequence != null)
            {
                body["EditSequence"] = ExpressionConverter.ConvertO(bodyeditSequence);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyextraField);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["Fax"] = ExpressionConverter.ConvertO(bodyfax);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["FirstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodyisActive != null)
            {
                body["IsActive"] = ExpressionConverter.ConvertO(bodyisActive);
                bodypropCount++;
            }

            if (bodyitemSalesTaxRef != null)
            {
                body["ItemSalesTaxRef"] = ExpressionConverter.ConvertO(bodyitemSalesTaxRef);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["JobTitle"] = ExpressionConverter.ConvertO(bodyjobTitle);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["LastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodylistID != null)
            {
                body["ListID"] = ExpressionConverter.ConvertO(bodylistID);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["MiddleName"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["Notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyopenBalance != null)
            {
                body["OpenBalance"] = ExpressionConverter.ConvertO(bodyopenBalance);
                bodypropCount++;
            }

            if (bodyopenBalanceDate != null)
            {
                body["OpenBalanceDate"] = ExpressionConverter.ConvertO(bodyopenBalanceDate);
                bodypropCount++;
            }

            if (bodyparentRef != null)
            {
                body["ParentRef"] = ExpressionConverter.ConvertO(bodyparentRef);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["Phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            if (bodypreferredPaymentMethodRef != null)
            {
                body["PreferredPaymentMethodRef"] = ExpressionConverter.ConvertO(bodypreferredPaymentMethodRef);
                bodypropCount++;
            }

            if (bodypriceLevelRef != null)
            {
                body["PriceLevelRef"] = ExpressionConverter.ConvertO(bodypriceLevelRef);
                bodypropCount++;
            }

            if (bodyresaleNumber != null)
            {
                body["ResaleNumber"] = ExpressionConverter.ConvertO(bodyresaleNumber);
                bodypropCount++;
            }

            if (bodysalesRepRef != null)
            {
                body["SalesRepRef"] = ExpressionConverter.ConvertO(bodysalesRepRef);
                bodypropCount++;
            }

            if (bodysalesTaxCodeRef != null)
            {
                body["SalesTaxCodeRef"] = ExpressionConverter.ConvertO(bodysalesTaxCodeRef);
                bodypropCount++;
            }

            if (bodysalutation != null)
            {
                body["Salutation"] = ExpressionConverter.ConvertO(bodysalutation);
                bodypropCount++;
            }

            if (bodyshipAddressAddr1 != null)
            {
                body["ShipAddressAddr1"] = ExpressionConverter.ConvertO(bodyshipAddressAddr1);
                bodypropCount++;
            }

            if (bodyshipAddressAddr2 != null)
            {
                body["ShipAddressAddr2"] = ExpressionConverter.ConvertO(bodyshipAddressAddr2);
                bodypropCount++;
            }

            if (bodyshipAddressAddr3 != null)
            {
                body["ShipAddressAddr3"] = ExpressionConverter.ConvertO(bodyshipAddressAddr3);
                bodypropCount++;
            }

            if (bodyshipAddressAddr4 != null)
            {
                body["ShipAddressAddr4"] = ExpressionConverter.ConvertO(bodyshipAddressAddr4);
                bodypropCount++;
            }

            if (bodyshipAddressAddr5 != null)
            {
                body["ShipAddressAddr5"] = ExpressionConverter.ConvertO(bodyshipAddressAddr5);
                bodypropCount++;
            }

            if (bodyshipAddressCity != null)
            {
                body["ShipAddressCity"] = ExpressionConverter.ConvertO(bodyshipAddressCity);
                bodypropCount++;
            }

            if (bodyshipAddressCountry != null)
            {
                body["ShipAddressCountry"] = ExpressionConverter.ConvertO(bodyshipAddressCountry);
                bodypropCount++;
            }

            if (bodyshipAddressNote != null)
            {
                body["ShipAddressNote"] = ExpressionConverter.ConvertO(bodyshipAddressNote);
                bodypropCount++;
            }

            if (bodyshipAddressPostalCode != null)
            {
                body["ShipAddressPostalCode"] = ExpressionConverter.ConvertO(bodyshipAddressPostalCode);
                bodypropCount++;
            }

            if (bodyshipAddressState != null)
            {
                body["ShipAddressState"] = ExpressionConverter.ConvertO(bodyshipAddressState);
                bodypropCount++;
            }

            if (bodytermsRef != null)
            {
                body["TermsRef"] = ExpressionConverter.ConvertO(bodytermsRef);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QuickBookCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> QuickBookCreateNewSalesOrder(Expression<Func<string>> bodybillAddressAddr1 = null, Expression<Func<string>> bodybillAddressAddr2 = null, Expression<Func<string>> bodybillAddressAddr3 = null, Expression<Func<string>> bodybillAddressAddr4 = null, Expression<Func<string>> bodybillAddressAddr5 = null, Expression<Func<string>> bodybillAddressCity = null, Expression<Func<string>> bodybillAddressCountry = null, Expression<Func<string>> bodybillAddressNote = null, Expression<Func<string>> bodybillAddressPostalCode = null, Expression<Func<string>> bodybillAddressState = null, Expression<Func<string>> bodyclassRef = null, Expression<Func<string>> bodycustomerRefListID = null, Expression<Func<string>> bodycustomerRefName = null, Expression<Func<string>> bodycustomerSalesTaxCodeRef = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyeditSequence = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyitemSalesTaxRef = null, Expression<Func<string>> bodylistID = null, Expression<Func<string>> bodymemo = null, Expression<Func<string>> bodypONumber = null, Expression<Func<string>> bodyrefNumber = null, Expression<Func<bodysalesOrderLineItemInputItem22[]>> bodysalesOrderLineItem = null, Expression<Func<string>> bodysalesRepRef = null, Expression<Func<string>> bodyshipAddressAddr1 = null, Expression<Func<string>> bodyshipAddressAddr2 = null, Expression<Func<string>> bodyshipAddressAddr3 = null, Expression<Func<string>> bodyshipAddressAddr4 = null, Expression<Func<string>> bodyshipAddressAddr5 = null, Expression<Func<string>> bodyshipAddressCity = null, Expression<Func<string>> bodyshipAddressCountry = null, Expression<Func<string>> bodyshipAddressNote = null, Expression<Func<string>> bodyshipAddressPostalCode = null, Expression<Func<string>> bodyshipAddressState = null, Expression<Func<string>> bodytemplateRef = null, Expression<Func<string>> bodytermsRef = null, Expression<Func<string>> bodytxnDate = null)
        {
            var apiCallPath = "/api/v1/quickbook/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybillAddressAddr1 != null)
            {
                body["BillAddressAddr1"] = ExpressionConverter.ConvertO(bodybillAddressAddr1);
                bodypropCount++;
            }

            if (bodybillAddressAddr2 != null)
            {
                body["BillAddressAddr2"] = ExpressionConverter.ConvertO(bodybillAddressAddr2);
                bodypropCount++;
            }

            if (bodybillAddressAddr3 != null)
            {
                body["BillAddressAddr3"] = ExpressionConverter.ConvertO(bodybillAddressAddr3);
                bodypropCount++;
            }

            if (bodybillAddressAddr4 != null)
            {
                body["BillAddressAddr4"] = ExpressionConverter.ConvertO(bodybillAddressAddr4);
                bodypropCount++;
            }

            if (bodybillAddressAddr5 != null)
            {
                body["BillAddressAddr5"] = ExpressionConverter.ConvertO(bodybillAddressAddr5);
                bodypropCount++;
            }

            if (bodybillAddressCity != null)
            {
                body["BillAddressCity"] = ExpressionConverter.ConvertO(bodybillAddressCity);
                bodypropCount++;
            }

            if (bodybillAddressCountry != null)
            {
                body["BillAddressCountry"] = ExpressionConverter.ConvertO(bodybillAddressCountry);
                bodypropCount++;
            }

            if (bodybillAddressNote != null)
            {
                body["BillAddressNote"] = ExpressionConverter.ConvertO(bodybillAddressNote);
                bodypropCount++;
            }

            if (bodybillAddressPostalCode != null)
            {
                body["BillAddressPostalCode"] = ExpressionConverter.ConvertO(bodybillAddressPostalCode);
                bodypropCount++;
            }

            if (bodybillAddressState != null)
            {
                body["BillAddressState"] = ExpressionConverter.ConvertO(bodybillAddressState);
                bodypropCount++;
            }

            if (bodyclassRef != null)
            {
                body["ClassRef"] = ExpressionConverter.ConvertO(bodyclassRef);
                bodypropCount++;
            }

            if (bodycustomerRefListID != null)
            {
                body["CustomerRefListID"] = ExpressionConverter.ConvertO(bodycustomerRefListID);
                bodypropCount++;
            }

            if (bodycustomerRefName != null)
            {
                body["CustomerRefName"] = ExpressionConverter.ConvertO(bodycustomerRefName);
                bodypropCount++;
            }

            if (bodycustomerSalesTaxCodeRef != null)
            {
                body["CustomerSalesTaxCodeRef"] = ExpressionConverter.ConvertO(bodycustomerSalesTaxCodeRef);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["DueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodyeditSequence != null)
            {
                body["EditSequence"] = ExpressionConverter.ConvertO(bodyeditSequence);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyextraField);
                bodypropCount++;
            }

            if (bodyitemSalesTaxRef != null)
            {
                body["ItemSalesTaxRef"] = ExpressionConverter.ConvertO(bodyitemSalesTaxRef);
                bodypropCount++;
            }

            if (bodylistID != null)
            {
                body["ListID"] = ExpressionConverter.ConvertO(bodylistID);
                bodypropCount++;
            }

            if (bodymemo != null)
            {
                body["Memo"] = ExpressionConverter.ConvertO(bodymemo);
                bodypropCount++;
            }

            if (bodypONumber != null)
            {
                body["PONumber"] = ExpressionConverter.ConvertO(bodypONumber);
                bodypropCount++;
            }

            if (bodyrefNumber != null)
            {
                body["RefNumber"] = ExpressionConverter.ConvertO(bodyrefNumber);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodysalesRepRef != null)
            {
                body["SalesRepRef"] = ExpressionConverter.ConvertO(bodysalesRepRef);
                bodypropCount++;
            }

            if (bodyshipAddressAddr1 != null)
            {
                body["ShipAddressAddr1"] = ExpressionConverter.ConvertO(bodyshipAddressAddr1);
                bodypropCount++;
            }

            if (bodyshipAddressAddr2 != null)
            {
                body["ShipAddressAddr2"] = ExpressionConverter.ConvertO(bodyshipAddressAddr2);
                bodypropCount++;
            }

            if (bodyshipAddressAddr3 != null)
            {
                body["ShipAddressAddr3"] = ExpressionConverter.ConvertO(bodyshipAddressAddr3);
                bodypropCount++;
            }

            if (bodyshipAddressAddr4 != null)
            {
                body["ShipAddressAddr4"] = ExpressionConverter.ConvertO(bodyshipAddressAddr4);
                bodypropCount++;
            }

            if (bodyshipAddressAddr5 != null)
            {
                body["ShipAddressAddr5"] = ExpressionConverter.ConvertO(bodyshipAddressAddr5);
                bodypropCount++;
            }

            if (bodyshipAddressCity != null)
            {
                body["ShipAddressCity"] = ExpressionConverter.ConvertO(bodyshipAddressCity);
                bodypropCount++;
            }

            if (bodyshipAddressCountry != null)
            {
                body["ShipAddressCountry"] = ExpressionConverter.ConvertO(bodyshipAddressCountry);
                bodypropCount++;
            }

            if (bodyshipAddressNote != null)
            {
                body["ShipAddressNote"] = ExpressionConverter.ConvertO(bodyshipAddressNote);
                bodypropCount++;
            }

            if (bodyshipAddressPostalCode != null)
            {
                body["ShipAddressPostalCode"] = ExpressionConverter.ConvertO(bodyshipAddressPostalCode);
                bodypropCount++;
            }

            if (bodyshipAddressState != null)
            {
                body["ShipAddressState"] = ExpressionConverter.ConvertO(bodyshipAddressState);
                bodypropCount++;
            }

            if (bodytemplateRef != null)
            {
                body["TemplateRef"] = ExpressionConverter.ConvertO(bodytemplateRef);
                bodypropCount++;
            }

            if (bodytermsRef != null)
            {
                body["TermsRef"] = ExpressionConverter.ConvertO(bodytermsRef);
                bodypropCount++;
            }

            if (bodytxnDate != null)
            {
                body["TxnDate"] = ExpressionConverter.ConvertO(bodytxnDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<QuickBookCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> SAGE50UKCreateNewCustomer(Expression<Func<string>> bodyaCCOUNTOPENED = null, Expression<Func<string>> bodyaCCOUNTREF = null, Expression<Func<int>> bodyaCCOUNTSTATUS = null, Expression<Func<string>> bodyaDDRESS1 = null, Expression<Func<string>> bodyaDDRESS2 = null, Expression<Func<string>> bodyaDDRESS3 = null, Expression<Func<string>> bodyaDDRESS4 = null, Expression<Func<string>> bodyaDDRESS5 = null, Expression<Func<string>> bodyaNALYSIS1 = null, Expression<Func<string>> bodyaNALYSIS2 = null, Expression<Func<string>> bodyaNALYSIS3 = null, Expression<Func<int>> bodyaVERAGEPAYDAYS = null, Expression<Func<int>> bodybALANCE = null, Expression<Func<bool>> bodycANAPPLYCHARGES = null, Expression<Func<string>> bodycONTACTNAME = null, Expression<Func<string>> bodycOUNTRYCODE = null, Expression<Func<string>> bodycREDITAPPLIEDFOR = null, Expression<Func<int>> bodycREDITBUREAU = null, Expression<Func<int>> bodycREDITLIMIT = null, Expression<Func<int>> bodycREDITPOSITION = null, Expression<Func<string>> bodycREDITREFERENCE = null, Expression<Func<int>> bodycURRENCY = null, Expression<Func<string>> bodydATECREDITAPPRECEIVED = null, Expression<Func<string>> bodydEFNOMCODE = null, Expression<Func<int>> bodydEFTAXCODE = null, Expression<Func<int>> bodydEPTNUMBER = null, Expression<Func<int>> bodydISCOUNTRATE = null, Expression<Func<int>> bodydISCOUNTTYPE = null, Expression<Func<string>> bodydUNSNUMBER = null, Expression<Func<string>> bodyeMAIL = null, Expression<Func<string>> bodyeMAIL2 = null, Expression<Func<string>> bodyeMAIL3 = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyfAX = null, Expression<Func<bool>> bodyhOLDMAIL = null, Expression<Func<bool>> bodyiNACTIVEFLAG = null, Expression<Func<bool>> bodyisACCOUNTREFAutogenerate = null, Expression<Func<string>> bodylASTCREDITREV = null, Expression<Func<string>> bodynAME = null, Expression<Func<string>> bodynEXTCREDITREV = null, Expression<Func<bool>> bodyoVERRIDEPRODUCTNOMINAL = null, Expression<Func<bool>> bodyoVERRIDEPRODUCTTAX = null, Expression<Func<int>> bodypAYMENTDUEDAYS = null, Expression<Func<string>> bodypRICELISTREF = null, Expression<Func<bool>> bodypRIORITYTRADER = null, Expression<Func<bool>> bodysENDINVOICESELECTRONICALLY = null, Expression<Func<bool>> bodysENDLETTERSELECTRONICALLY = null, Expression<Func<int>> bodysETTLEMENTDISCRATE = null, Expression<Func<int>> bodysETTLEMENTDUEDAYS = null, Expression<Func<string>> bodytELEPHONE = null, Expression<Func<string>> bodytELEPHONE2 = null, Expression<Func<string>> bodytERMS = null, Expression<Func<bool>> bodytERMSAGREEDFLAG = null, Expression<Func<string>> bodytRADECONTACT = null, Expression<Func<string>> bodyvATREGNUMBER = null)
        {
            var apiCallPath = "/api/v1/sage50uk/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaCCOUNTOPENED != null)
            {
                body["ACCOUNT_OPENED"] = ExpressionConverter.ConvertO(bodyaCCOUNTOPENED);
                bodypropCount++;
            }

            if (bodyaCCOUNTREF != null)
            {
                body["ACCOUNT_REF"] = ExpressionConverter.ConvertO(bodyaCCOUNTREF);
                bodypropCount++;
            }

            if (bodyaCCOUNTSTATUS != null)
            {
                body["ACCOUNT_STATUS"] = ExpressionConverter.ConvertO(bodyaCCOUNTSTATUS);
                bodypropCount++;
            }

            if (bodyaDDRESS1 != null)
            {
                body["ADDRESS_1"] = ExpressionConverter.ConvertO(bodyaDDRESS1);
                bodypropCount++;
            }

            if (bodyaDDRESS2 != null)
            {
                body["ADDRESS_2"] = ExpressionConverter.ConvertO(bodyaDDRESS2);
                bodypropCount++;
            }

            if (bodyaDDRESS3 != null)
            {
                body["ADDRESS_3"] = ExpressionConverter.ConvertO(bodyaDDRESS3);
                bodypropCount++;
            }

            if (bodyaDDRESS4 != null)
            {
                body["ADDRESS_4"] = ExpressionConverter.ConvertO(bodyaDDRESS4);
                bodypropCount++;
            }

            if (bodyaDDRESS5 != null)
            {
                body["ADDRESS_5"] = ExpressionConverter.ConvertO(bodyaDDRESS5);
                bodypropCount++;
            }

            if (bodyaNALYSIS1 != null)
            {
                body["ANALYSIS_1"] = ExpressionConverter.ConvertO(bodyaNALYSIS1);
                bodypropCount++;
            }

            if (bodyaNALYSIS2 != null)
            {
                body["ANALYSIS_2"] = ExpressionConverter.ConvertO(bodyaNALYSIS2);
                bodypropCount++;
            }

            if (bodyaNALYSIS3 != null)
            {
                body["ANALYSIS_3"] = ExpressionConverter.ConvertO(bodyaNALYSIS3);
                bodypropCount++;
            }

            if (bodyaVERAGEPAYDAYS != null)
            {
                body["AVERAGE_PAY_DAYS"] = ExpressionConverter.ConvertO(bodyaVERAGEPAYDAYS);
                bodypropCount++;
            }

            if (bodybALANCE != null)
            {
                body["BALANCE"] = ExpressionConverter.ConvertO(bodybALANCE);
                bodypropCount++;
            }

            if (bodycANAPPLYCHARGES != null)
            {
                body["CAN_APPLY_CHARGES"] = ExpressionConverter.ConvertO(bodycANAPPLYCHARGES);
                bodypropCount++;
            }

            if (bodycONTACTNAME != null)
            {
                body["CONTACT_NAME"] = ExpressionConverter.ConvertO(bodycONTACTNAME);
                bodypropCount++;
            }

            if (bodycOUNTRYCODE != null)
            {
                body["COUNTRY_CODE"] = ExpressionConverter.ConvertO(bodycOUNTRYCODE);
                bodypropCount++;
            }

            if (bodycREDITAPPLIEDFOR != null)
            {
                body["CREDIT_APPLIED_FOR"] = ExpressionConverter.ConvertO(bodycREDITAPPLIEDFOR);
                bodypropCount++;
            }

            if (bodycREDITBUREAU != null)
            {
                body["CREDIT_BUREAU"] = ExpressionConverter.ConvertO(bodycREDITBUREAU);
                bodypropCount++;
            }

            if (bodycREDITLIMIT != null)
            {
                body["CREDIT_LIMIT"] = ExpressionConverter.ConvertO(bodycREDITLIMIT);
                bodypropCount++;
            }

            if (bodycREDITPOSITION != null)
            {
                body["CREDIT_POSITION"] = ExpressionConverter.ConvertO(bodycREDITPOSITION);
                bodypropCount++;
            }

            if (bodycREDITREFERENCE != null)
            {
                body["CREDIT_REFERENCE"] = ExpressionConverter.ConvertO(bodycREDITREFERENCE);
                bodypropCount++;
            }

            if (bodycURRENCY != null)
            {
                body["CURRENCY"] = ExpressionConverter.ConvertO(bodycURRENCY);
                bodypropCount++;
            }

            if (bodydATECREDITAPPRECEIVED != null)
            {
                body["DATE_CREDIT_APP_RECEIVED"] = ExpressionConverter.ConvertO(bodydATECREDITAPPRECEIVED);
                bodypropCount++;
            }

            if (bodydEFNOMCODE != null)
            {
                body["DEF_NOM_CODE"] = ExpressionConverter.ConvertO(bodydEFNOMCODE);
                bodypropCount++;
            }

            if (bodydEFTAXCODE != null)
            {
                body["DEF_TAX_CODE"] = ExpressionConverter.ConvertO(bodydEFTAXCODE);
                bodypropCount++;
            }

            if (bodydEPTNUMBER != null)
            {
                body["DEPT_NUMBER"] = ExpressionConverter.ConvertO(bodydEPTNUMBER);
                bodypropCount++;
            }

            if (bodydISCOUNTRATE != null)
            {
                body["DISCOUNT_RATE"] = ExpressionConverter.ConvertO(bodydISCOUNTRATE);
                bodypropCount++;
            }

            if (bodydISCOUNTTYPE != null)
            {
                body["DISCOUNT_TYPE"] = ExpressionConverter.ConvertO(bodydISCOUNTTYPE);
                bodypropCount++;
            }

            if (bodydUNSNUMBER != null)
            {
                body["DUNS_NUMBER"] = ExpressionConverter.ConvertO(bodydUNSNUMBER);
                bodypropCount++;
            }

            if (bodyeMAIL != null)
            {
                body["E_MAIL"] = ExpressionConverter.ConvertO(bodyeMAIL);
                bodypropCount++;
            }

            if (bodyeMAIL2 != null)
            {
                body["E_MAIL2"] = ExpressionConverter.ConvertO(bodyeMAIL2);
                bodypropCount++;
            }

            if (bodyeMAIL3 != null)
            {
                body["E_MAIL3"] = ExpressionConverter.ConvertO(bodyeMAIL3);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyextraField);
                bodypropCount++;
            }

            if (bodyfAX != null)
            {
                body["FAX"] = ExpressionConverter.ConvertO(bodyfAX);
                bodypropCount++;
            }

            if (bodyhOLDMAIL != null)
            {
                body["HOLD_MAIL"] = ExpressionConverter.ConvertO(bodyhOLDMAIL);
                bodypropCount++;
            }

            if (bodyiNACTIVEFLAG != null)
            {
                body["INACTIVE_FLAG"] = ExpressionConverter.ConvertO(bodyiNACTIVEFLAG);
                bodypropCount++;
            }

            if (bodyisACCOUNTREFAutogenerate != null)
            {
                body["IsACCOUNT_REF_autogenerate"] = ExpressionConverter.ConvertO(bodyisACCOUNTREFAutogenerate);
                bodypropCount++;
            }

            if (bodylASTCREDITREV != null)
            {
                body["LAST_CREDIT_REV"] = ExpressionConverter.ConvertO(bodylASTCREDITREV);
                bodypropCount++;
            }

            if (bodynAME != null)
            {
                body["NAME"] = ExpressionConverter.ConvertO(bodynAME);
                bodypropCount++;
            }

            if (bodynEXTCREDITREV != null)
            {
                body["NEXT_CREDIT_REV"] = ExpressionConverter.ConvertO(bodynEXTCREDITREV);
                bodypropCount++;
            }

            if (bodyoVERRIDEPRODUCTNOMINAL != null)
            {
                body["OVERRIDE_PRODUCT_NOMINAL"] = ExpressionConverter.ConvertO(bodyoVERRIDEPRODUCTNOMINAL);
                bodypropCount++;
            }

            if (bodyoVERRIDEPRODUCTTAX != null)
            {
                body["OVERRIDE_PRODUCT_TAX"] = ExpressionConverter.ConvertO(bodyoVERRIDEPRODUCTTAX);
                bodypropCount++;
            }

            if (bodypAYMENTDUEDAYS != null)
            {
                body["PAYMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(bodypAYMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodypRICELISTREF != null)
            {
                body["PRICE_LIST_REF"] = ExpressionConverter.ConvertO(bodypRICELISTREF);
                bodypropCount++;
            }

            if (bodypRIORITYTRADER != null)
            {
                body["PRIORITY_TRADER"] = ExpressionConverter.ConvertO(bodypRIORITYTRADER);
                bodypropCount++;
            }

            if (bodysENDINVOICESELECTRONICALLY != null)
            {
                body["SEND_INVOICES_ELECTRONICALLY"] = ExpressionConverter.ConvertO(bodysENDINVOICESELECTRONICALLY);
                bodypropCount++;
            }

            if (bodysENDLETTERSELECTRONICALLY != null)
            {
                body["SEND_LETTERS_ELECTRONICALLY"] = ExpressionConverter.ConvertO(bodysENDLETTERSELECTRONICALLY);
                bodypropCount++;
            }

            if (bodysETTLEMENTDISCRATE != null)
            {
                body["SETTLEMENT_DISC_RATE"] = ExpressionConverter.ConvertO(bodysETTLEMENTDISCRATE);
                bodypropCount++;
            }

            if (bodysETTLEMENTDUEDAYS != null)
            {
                body["SETTLEMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(bodysETTLEMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodytELEPHONE != null)
            {
                body["TELEPHONE"] = ExpressionConverter.ConvertO(bodytELEPHONE);
                bodypropCount++;
            }

            if (bodytELEPHONE2 != null)
            {
                body["TELEPHONE_2"] = ExpressionConverter.ConvertO(bodytELEPHONE2);
                bodypropCount++;
            }

            if (bodytERMS != null)
            {
                body["TERMS"] = ExpressionConverter.ConvertO(bodytERMS);
                bodypropCount++;
            }

            if (bodytERMSAGREEDFLAG != null)
            {
                body["TERMS_AGREED_FLAG"] = ExpressionConverter.ConvertO(bodytERMSAGREEDFLAG);
                bodypropCount++;
            }

            if (bodytRADECONTACT != null)
            {
                body["TRADE_CONTACT"] = ExpressionConverter.ConvertO(bodytRADECONTACT);
                bodypropCount++;
            }

            if (bodyvATREGNUMBER != null)
            {
                body["VAT_REG_NUMBER"] = ExpressionConverter.ConvertO(bodyvATREGNUMBER);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50UKCreateNewCustomerResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> SAGE50UKCreateNewSalesOrder(Expression<Func<string>> bodyaCCOUNTREF = null, Expression<Func<string>> bodyaDDRESS1 = null, Expression<Func<string>> bodyaDDRESS2 = null, Expression<Func<string>> bodyaDDRESS3 = null, Expression<Func<string>> bodyaDDRESS4 = null, Expression<Func<string>> bodyaDDRESS5 = null, Expression<Func<int>> bodyaMOUNTPREPAID = null, Expression<Func<string>> bodyaNALYSIS1 = null, Expression<Func<string>> bodyaNALYSIS2 = null, Expression<Func<string>> bodyaNALYSIS3 = null, Expression<Func<int>> bodycARRDEPTNUMBER = null, Expression<Func<int>> bodycARRNET = null, Expression<Func<string>> bodycARRNOMCODE = null, Expression<Func<int>> bodycARRTAX = null, Expression<Func<int>> bodycARRTAXCODE = null, Expression<Func<string>> bodycONSIGNMENTREF = null, Expression<Func<string>> bodycONTACTNAME = null, Expression<Func<int>> bodycOURIER = null, Expression<Func<int>> bodycURRENCY = null, Expression<Func<int>> bodycUSTDISCRATE = null, Expression<Func<string>> bodycUSTORDERNUMBER = null, Expression<Func<string>> bodycUSTTELNUMBER = null, Expression<Func<int>> bodydEFTAXCODE = null, Expression<Func<bool>> bodydELETEDFLAG = null, Expression<Func<string>> bodydELIVERYNAME = null, Expression<Func<string>> bodydELADDRESS1 = null, Expression<Func<string>> bodydELADDRESS2 = null, Expression<Func<string>> bodydELADDRESS3 = null, Expression<Func<string>> bodydELADDRESS4 = null, Expression<Func<string>> bodydELADDRESS5 = null, Expression<Func<string>> bodydESPATCHDATE = null, Expression<Func<string>> bodydUNSNUMBER = null, Expression<Func<int>> bodygLOBALDEPTNUMBER = null, Expression<Func<string>> bodygLOBALDETAILS = null, Expression<Func<string>> bodygLOBALNOMCODE = null, Expression<Func<int>> bodygLOBALTAXCODE = null, Expression<Func<string>> bodyiNVOICENUMBER = null, Expression<Func<string>> bodynAME = null, Expression<Func<string>> bodyoRDERDATE = null, Expression<Func<int>> bodyoRDERNUMBER = null, Expression<Func<int>> bodyoRDERTYPE = null, Expression<Func<int>> bodysETTLEMENTDISCRATE = null, Expression<Func<int>> bodysETTLEMENTDUEDAYS = null, Expression<Func<bodysalesOrderLineItemInputItem222[]>> bodysalesOrderLineItem = null)
        {
            var apiCallPath = "/api/v1/sage50uk/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaCCOUNTREF != null)
            {
                body["ACCOUNT_REF"] = ExpressionConverter.ConvertO(bodyaCCOUNTREF);
                bodypropCount++;
            }

            if (bodyaDDRESS1 != null)
            {
                body["ADDRESS_1"] = ExpressionConverter.ConvertO(bodyaDDRESS1);
                bodypropCount++;
            }

            if (bodyaDDRESS2 != null)
            {
                body["ADDRESS_2"] = ExpressionConverter.ConvertO(bodyaDDRESS2);
                bodypropCount++;
            }

            if (bodyaDDRESS3 != null)
            {
                body["ADDRESS_3"] = ExpressionConverter.ConvertO(bodyaDDRESS3);
                bodypropCount++;
            }

            if (bodyaDDRESS4 != null)
            {
                body["ADDRESS_4"] = ExpressionConverter.ConvertO(bodyaDDRESS4);
                bodypropCount++;
            }

            if (bodyaDDRESS5 != null)
            {
                body["ADDRESS_5"] = ExpressionConverter.ConvertO(bodyaDDRESS5);
                bodypropCount++;
            }

            if (bodyaMOUNTPREPAID != null)
            {
                body["AMOUNT_PREPAID"] = ExpressionConverter.ConvertO(bodyaMOUNTPREPAID);
                bodypropCount++;
            }

            if (bodyaNALYSIS1 != null)
            {
                body["ANALYSIS_1"] = ExpressionConverter.ConvertO(bodyaNALYSIS1);
                bodypropCount++;
            }

            if (bodyaNALYSIS2 != null)
            {
                body["ANALYSIS_2"] = ExpressionConverter.ConvertO(bodyaNALYSIS2);
                bodypropCount++;
            }

            if (bodyaNALYSIS3 != null)
            {
                body["ANALYSIS_3"] = ExpressionConverter.ConvertO(bodyaNALYSIS3);
                bodypropCount++;
            }

            if (bodycARRDEPTNUMBER != null)
            {
                body["CARR_DEPT_NUMBER"] = ExpressionConverter.ConvertO(bodycARRDEPTNUMBER);
                bodypropCount++;
            }

            if (bodycARRNET != null)
            {
                body["CARR_NET"] = ExpressionConverter.ConvertO(bodycARRNET);
                bodypropCount++;
            }

            if (bodycARRNOMCODE != null)
            {
                body["CARR_NOM_CODE"] = ExpressionConverter.ConvertO(bodycARRNOMCODE);
                bodypropCount++;
            }

            if (bodycARRTAX != null)
            {
                body["CARR_TAX"] = ExpressionConverter.ConvertO(bodycARRTAX);
                bodypropCount++;
            }

            if (bodycARRTAXCODE != null)
            {
                body["CARR_TAX_CODE"] = ExpressionConverter.ConvertO(bodycARRTAXCODE);
                bodypropCount++;
            }

            if (bodycONSIGNMENTREF != null)
            {
                body["CONSIGNMENT_REF"] = ExpressionConverter.ConvertO(bodycONSIGNMENTREF);
                bodypropCount++;
            }

            if (bodycONTACTNAME != null)
            {
                body["CONTACT_NAME"] = ExpressionConverter.ConvertO(bodycONTACTNAME);
                bodypropCount++;
            }

            if (bodycOURIER != null)
            {
                body["COURIER"] = ExpressionConverter.ConvertO(bodycOURIER);
                bodypropCount++;
            }

            if (bodycURRENCY != null)
            {
                body["CURRENCY"] = ExpressionConverter.ConvertO(bodycURRENCY);
                bodypropCount++;
            }

            if (bodycUSTDISCRATE != null)
            {
                body["CUST_DISC_RATE"] = ExpressionConverter.ConvertO(bodycUSTDISCRATE);
                bodypropCount++;
            }

            if (bodycUSTORDERNUMBER != null)
            {
                body["CUST_ORDER_NUMBER"] = ExpressionConverter.ConvertO(bodycUSTORDERNUMBER);
                bodypropCount++;
            }

            if (bodycUSTTELNUMBER != null)
            {
                body["CUST_TEL_NUMBER"] = ExpressionConverter.ConvertO(bodycUSTTELNUMBER);
                bodypropCount++;
            }

            if (bodydEFTAXCODE != null)
            {
                body["DEF_TAX_CODE"] = ExpressionConverter.ConvertO(bodydEFTAXCODE);
                bodypropCount++;
            }

            if (bodydELETEDFLAG != null)
            {
                body["DELETED_FLAG"] = ExpressionConverter.ConvertO(bodydELETEDFLAG);
                bodypropCount++;
            }

            if (bodydELIVERYNAME != null)
            {
                body["DELIVERY_NAME"] = ExpressionConverter.ConvertO(bodydELIVERYNAME);
                bodypropCount++;
            }

            if (bodydELADDRESS1 != null)
            {
                body["DEL_ADDRESS_1"] = ExpressionConverter.ConvertO(bodydELADDRESS1);
                bodypropCount++;
            }

            if (bodydELADDRESS2 != null)
            {
                body["DEL_ADDRESS_2"] = ExpressionConverter.ConvertO(bodydELADDRESS2);
                bodypropCount++;
            }

            if (bodydELADDRESS3 != null)
            {
                body["DEL_ADDRESS_3"] = ExpressionConverter.ConvertO(bodydELADDRESS3);
                bodypropCount++;
            }

            if (bodydELADDRESS4 != null)
            {
                body["DEL_ADDRESS_4"] = ExpressionConverter.ConvertO(bodydELADDRESS4);
                bodypropCount++;
            }

            if (bodydELADDRESS5 != null)
            {
                body["DEL_ADDRESS_5"] = ExpressionConverter.ConvertO(bodydELADDRESS5);
                bodypropCount++;
            }

            if (bodydESPATCHDATE != null)
            {
                body["DESPATCH_DATE"] = ExpressionConverter.ConvertO(bodydESPATCHDATE);
                bodypropCount++;
            }

            if (bodydUNSNUMBER != null)
            {
                body["DUNS_NUMBER"] = ExpressionConverter.ConvertO(bodydUNSNUMBER);
                bodypropCount++;
            }

            if (bodygLOBALDEPTNUMBER != null)
            {
                body["GLOBAL_DEPT_NUMBER"] = ExpressionConverter.ConvertO(bodygLOBALDEPTNUMBER);
                bodypropCount++;
            }

            if (bodygLOBALDETAILS != null)
            {
                body["GLOBAL_DETAILS"] = ExpressionConverter.ConvertO(bodygLOBALDETAILS);
                bodypropCount++;
            }

            if (bodygLOBALNOMCODE != null)
            {
                body["GLOBAL_NOM_CODE"] = ExpressionConverter.ConvertO(bodygLOBALNOMCODE);
                bodypropCount++;
            }

            if (bodygLOBALTAXCODE != null)
            {
                body["GLOBAL_TAX_CODE"] = ExpressionConverter.ConvertO(bodygLOBALTAXCODE);
                bodypropCount++;
            }

            if (bodyiNVOICENUMBER != null)
            {
                body["INVOICE_NUMBER"] = ExpressionConverter.ConvertO(bodyiNVOICENUMBER);
                bodypropCount++;
            }

            if (bodynAME != null)
            {
                body["NAME"] = ExpressionConverter.ConvertO(bodynAME);
                bodypropCount++;
            }

            if (bodyoRDERDATE != null)
            {
                body["ORDER_DATE"] = ExpressionConverter.ConvertO(bodyoRDERDATE);
                bodypropCount++;
            }

            if (bodyoRDERNUMBER != null)
            {
                body["ORDER_NUMBER"] = ExpressionConverter.ConvertO(bodyoRDERNUMBER);
                bodypropCount++;
            }

            if (bodyoRDERTYPE != null)
            {
                body["ORDER_TYPE"] = ExpressionConverter.ConvertO(bodyoRDERTYPE);
                bodypropCount++;
            }

            if (bodysETTLEMENTDISCRATE != null)
            {
                body["SETTLEMENT_DISC_RATE"] = ExpressionConverter.ConvertO(bodysETTLEMENTDISCRATE);
                bodypropCount++;
            }

            if (bodysETTLEMENTDUEDAYS != null)
            {
                body["SETTLEMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(bodysETTLEMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50UKCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> SAGE50USCreateNewCustomer(Expression<Func<string>> bodyaccountNumber = null, Expression<Func<string>> bodybillingCity = null, Expression<Func<string>> bodybillingCountry = null, Expression<Func<string>> bodybillingLastName = null, Expression<Func<string>> bodybillingName = null, Expression<Func<string>> bodybillingPostalCode = null, Expression<Func<string>> bodybillingState = null, Expression<Func<string>> bodybillingStreet = null, Expression<Func<bool>> bodycCSalesRepresentative = null, Expression<Func<bool>> bodychargeFinanceCharges = null, Expression<Func<string>> bodycontactName = null, Expression<Func<int>> bodycreditLimit = null, Expression<Func<int>> bodycreditStatus = null, Expression<Func<string>> bodycustomFieldValue1 = null, Expression<Func<string>> bodycustomFieldValue2 = null, Expression<Func<string>> bodycustomFieldValue3 = null, Expression<Func<string>> bodycustomFieldValue4 = null, Expression<Func<string>> bodycustomFieldValue5 = null, Expression<Func<string>> bodycustomerGUID = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<int>> bodycustomerBalance = null, Expression<Func<string>> bodycustomerSinceDate = null, Expression<Func<string>> bodycustomerType = null, Expression<Func<int>> bodydiscountDays = null, Expression<Func<int>> bodydiscountPercent = null, Expression<Func<int>> bodydueDays = null, Expression<Func<string>> bodyeMailAddress = null, Expression<Func<string>> bodyfaxNumber = null, Expression<Func<int>> bodyformDeliveryMethod = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyphoneNo1 = null, Expression<Func<string>> bodyphoneNo2 = null, Expression<Func<int>> bodypricingLevel = null, Expression<Func<string>> bodysalesRepresentativeID = null, Expression<Func<string>> bodysalesTaxCode = null, Expression<Func<string>> bodyshippingCity = null, Expression<Func<string>> bodyshippingCountry = null, Expression<Func<string>> bodyshippingPostalCode = null, Expression<Func<string>> bodyshippingState = null, Expression<Func<string>> bodyshippingStreet = null, Expression<Func<bool>> bodytermsType = null, Expression<Func<bool>> bodyuseCODTerms = null, Expression<Func<bool>> bodyuseDueMonthEndTerms = null, Expression<Func<bool>> bodyusePrepaidTerms = null, Expression<Func<bool>> bodyuseStandardTerms = null, Expression<Func<bool>> bodyisInactive = null)
        {
            var apiCallPath = "/api/v1/sage50us/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccountNumber != null)
            {
                body["Account_Number"] = ExpressionConverter.ConvertO(bodyaccountNumber);
                bodypropCount++;
            }

            if (bodybillingCity != null)
            {
                body["BillingCity"] = ExpressionConverter.ConvertO(bodybillingCity);
                bodypropCount++;
            }

            if (bodybillingCountry != null)
            {
                body["BillingCountry"] = ExpressionConverter.ConvertO(bodybillingCountry);
                bodypropCount++;
            }

            if (bodybillingLastName != null)
            {
                body["BillingLastName"] = ExpressionConverter.ConvertO(bodybillingLastName);
                bodypropCount++;
            }

            if (bodybillingName != null)
            {
                body["BillingName"] = ExpressionConverter.ConvertO(bodybillingName);
                bodypropCount++;
            }

            if (bodybillingPostalCode != null)
            {
                body["BillingPostalCode"] = ExpressionConverter.ConvertO(bodybillingPostalCode);
                bodypropCount++;
            }

            if (bodybillingState != null)
            {
                body["BillingState"] = ExpressionConverter.ConvertO(bodybillingState);
                bodypropCount++;
            }

            if (bodybillingStreet != null)
            {
                body["BillingStreet"] = ExpressionConverter.ConvertO(bodybillingStreet);
                bodypropCount++;
            }

            if (bodycCSalesRepresentative != null)
            {
                body["CC_Sales_Representative"] = ExpressionConverter.ConvertO(bodycCSalesRepresentative);
                bodypropCount++;
            }

            if (bodychargeFinanceCharges != null)
            {
                body["Charge_Finance_Charges"] = ExpressionConverter.ConvertO(bodychargeFinanceCharges);
                bodypropCount++;
            }

            if (bodycontactName != null)
            {
                body["ContactName"] = ExpressionConverter.ConvertO(bodycontactName);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["Credit_Limit"] = ExpressionConverter.ConvertO(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycreditStatus != null)
            {
                body["Credit_Status"] = ExpressionConverter.ConvertO(bodycreditStatus);
                bodypropCount++;
            }

            if (bodycustomFieldValue1 != null)
            {
                body["CustomFieldValue1"] = ExpressionConverter.ConvertO(bodycustomFieldValue1);
                bodypropCount++;
            }

            if (bodycustomFieldValue2 != null)
            {
                body["CustomFieldValue2"] = ExpressionConverter.ConvertO(bodycustomFieldValue2);
                bodypropCount++;
            }

            if (bodycustomFieldValue3 != null)
            {
                body["CustomFieldValue3"] = ExpressionConverter.ConvertO(bodycustomFieldValue3);
                bodypropCount++;
            }

            if (bodycustomFieldValue4 != null)
            {
                body["CustomFieldValue4"] = ExpressionConverter.ConvertO(bodycustomFieldValue4);
                bodypropCount++;
            }

            if (bodycustomFieldValue5 != null)
            {
                body["CustomFieldValue5"] = ExpressionConverter.ConvertO(bodycustomFieldValue5);
                bodypropCount++;
            }

            if (bodycustomerGUID != null)
            {
                body["CustomerGUID"] = ExpressionConverter.ConvertO(bodycustomerGUID);
                bodypropCount++;
            }

            if (bodycustomerID != null)
            {
                body["CustomerID"] = ExpressionConverter.ConvertO(bodycustomerID);
                bodypropCount++;
            }

            if (bodycustomerBalance != null)
            {
                body["Customer_Balance"] = ExpressionConverter.ConvertO(bodycustomerBalance);
                bodypropCount++;
            }

            if (bodycustomerSinceDate != null)
            {
                body["Customer_Since_Date"] = ExpressionConverter.ConvertO(bodycustomerSinceDate);
                bodypropCount++;
            }

            if (bodycustomerType != null)
            {
                body["Customer_Type"] = ExpressionConverter.ConvertO(bodycustomerType);
                bodypropCount++;
            }

            if (bodydiscountDays != null)
            {
                body["Discount_Days"] = ExpressionConverter.ConvertO(bodydiscountDays);
                bodypropCount++;
            }

            if (bodydiscountPercent != null)
            {
                body["Discount_Percent"] = ExpressionConverter.ConvertO(bodydiscountPercent);
                bodypropCount++;
            }

            if (bodydueDays != null)
            {
                body["Due_Days"] = ExpressionConverter.ConvertO(bodydueDays);
                bodypropCount++;
            }

            if (bodyeMailAddress != null)
            {
                body["EMail_Address"] = ExpressionConverter.ConvertO(bodyeMailAddress);
                bodypropCount++;
            }

            if (bodyfaxNumber != null)
            {
                body["FaxNumber"] = ExpressionConverter.ConvertO(bodyfaxNumber);
                bodypropCount++;
            }

            if (bodyformDeliveryMethod != null)
            {
                body["Form_Delivery_Method"] = ExpressionConverter.ConvertO(bodyformDeliveryMethod);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyphoneNo1 != null)
            {
                body["PhoneNo1"] = ExpressionConverter.ConvertO(bodyphoneNo1);
                bodypropCount++;
            }

            if (bodyphoneNo2 != null)
            {
                body["PhoneNo2"] = ExpressionConverter.ConvertO(bodyphoneNo2);
                bodypropCount++;
            }

            if (bodypricingLevel != null)
            {
                body["Pricing_Level"] = ExpressionConverter.ConvertO(bodypricingLevel);
                bodypropCount++;
            }

            if (bodysalesRepresentativeID != null)
            {
                body["Sales_Representative_ID"] = ExpressionConverter.ConvertO(bodysalesRepresentativeID);
                bodypropCount++;
            }

            if (bodysalesTaxCode != null)
            {
                body["Sales_Tax_Code"] = ExpressionConverter.ConvertO(bodysalesTaxCode);
                bodypropCount++;
            }

            if (bodyshippingCity != null)
            {
                body["ShippingCity"] = ExpressionConverter.ConvertO(bodyshippingCity);
                bodypropCount++;
            }

            if (bodyshippingCountry != null)
            {
                body["ShippingCountry"] = ExpressionConverter.ConvertO(bodyshippingCountry);
                bodypropCount++;
            }

            if (bodyshippingPostalCode != null)
            {
                body["ShippingPostalCode"] = ExpressionConverter.ConvertO(bodyshippingPostalCode);
                bodypropCount++;
            }

            if (bodyshippingState != null)
            {
                body["ShippingState"] = ExpressionConverter.ConvertO(bodyshippingState);
                bodypropCount++;
            }

            if (bodyshippingStreet != null)
            {
                body["ShippingStreet"] = ExpressionConverter.ConvertO(bodyshippingStreet);
                bodypropCount++;
            }

            if (bodytermsType != null)
            {
                body["Terms_Type"] = ExpressionConverter.ConvertO(bodytermsType);
                bodypropCount++;
            }

            if (bodyuseCODTerms != null)
            {
                body["Use_COD_Terms"] = ExpressionConverter.ConvertO(bodyuseCODTerms);
                bodypropCount++;
            }

            if (bodyuseDueMonthEndTerms != null)
            {
                body["Use_Due_Month_End_Terms"] = ExpressionConverter.ConvertO(bodyuseDueMonthEndTerms);
                bodypropCount++;
            }

            if (bodyusePrepaidTerms != null)
            {
                body["Use_Prepaid_Terms"] = ExpressionConverter.ConvertO(bodyusePrepaidTerms);
                bodypropCount++;
            }

            if (bodyuseStandardTerms != null)
            {
                body["Use_Standard_Terms"] = ExpressionConverter.ConvertO(bodyuseStandardTerms);
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
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> SAGE50USCreateNewSalesOrder(Expression<Func<string>> bodyaccountsReceivableAccount = null, Expression<Func<string>> bodyaccountsReceivableAcctGUID = null, Expression<Func<int>> bodyaccountsReceivableAmount = null, Expression<Func<bool>> bodyclosed = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<string>> bodycustomerPO = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodydiscountAmount = null, Expression<Func<string>> bodydisplayedTerms = null, Expression<Func<bool>> bodydropShip = null, Expression<Func<string>> bodygUID = null, Expression<Func<bool>> bodynotePrintsAfterLineItems = null, Expression<Func<bool>> bodyproposal = null, Expression<Func<bool>> bodyproposalAccepted = null, Expression<Func<bodysalesOrderLineItemInputItem2222[]>> bodysalesOrderLineItem = null, Expression<Func<string>> bodysalesOrderNumber = null, Expression<Func<string>> bodysalesRepresentativeGUID = null, Expression<Func<string>> bodysalesRepresentativeID = null, Expression<Func<string>> bodyshipAddressCity = null, Expression<Func<string>> bodyshipAddressCountry = null, Expression<Func<string>> bodyshipAddressLine1 = null, Expression<Func<string>> bodyshipAddressLine2 = null, Expression<Func<string>> bodyshipAddressName = null, Expression<Func<string>> bodyshipAddressState = null, Expression<Func<string>> bodyshipAddressZipCode = null, Expression<Func<string>> bodyshipBy = null, Expression<Func<string>> bodyshipVIA = null, Expression<Func<bool>> bodystatementNotePrintsBeforeInvRef = null)
        {
            var apiCallPath = "/api/v1/sage50us/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaccountsReceivableAccount != null)
            {
                body["Accounts_Receivable_Account"] = ExpressionConverter.ConvertO(bodyaccountsReceivableAccount);
                bodypropCount++;
            }

            if (bodyaccountsReceivableAcctGUID != null)
            {
                body["Accounts_Receivable_Acct_GUID"] = ExpressionConverter.ConvertO(bodyaccountsReceivableAcctGUID);
                bodypropCount++;
            }

            if (bodyaccountsReceivableAmount != null)
            {
                body["Accounts_Receivable_Amount"] = ExpressionConverter.ConvertO(bodyaccountsReceivableAmount);
                bodypropCount++;
            }

            if (bodyclosed != null)
            {
                body["Closed"] = ExpressionConverter.ConvertO(bodyclosed);
                bodypropCount++;
            }

            if (bodycustomerID != null)
            {
                body["Customer_ID"] = ExpressionConverter.ConvertO(bodycustomerID);
                bodypropCount++;
            }

            if (bodycustomerPO != null)
            {
                body["Customer_PO"] = ExpressionConverter.ConvertO(bodycustomerPO);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["Date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodydiscountAmount != null)
            {
                body["Discount_Amount"] = ExpressionConverter.ConvertO(bodydiscountAmount);
                bodypropCount++;
            }

            if (bodydisplayedTerms != null)
            {
                body["Displayed_Terms"] = ExpressionConverter.ConvertO(bodydisplayedTerms);
                bodypropCount++;
            }

            if (bodydropShip != null)
            {
                body["Drop_Ship"] = ExpressionConverter.ConvertO(bodydropShip);
                bodypropCount++;
            }

            if (bodygUID != null)
            {
                body["GUID"] = ExpressionConverter.ConvertO(bodygUID);
                bodypropCount++;
            }

            if (bodynotePrintsAfterLineItems != null)
            {
                body["Note_Prints_After_Line_Items"] = ExpressionConverter.ConvertO(bodynotePrintsAfterLineItems);
                bodypropCount++;
            }

            if (bodyproposal != null)
            {
                body["Proposal"] = ExpressionConverter.ConvertO(bodyproposal);
                bodypropCount++;
            }

            if (bodyproposalAccepted != null)
            {
                body["ProposalAccepted"] = ExpressionConverter.ConvertO(bodyproposalAccepted);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodysalesOrderNumber != null)
            {
                body["Sales_Order_Number"] = ExpressionConverter.ConvertO(bodysalesOrderNumber);
                bodypropCount++;
            }

            if (bodysalesRepresentativeGUID != null)
            {
                body["Sales_Representative_GUID"] = ExpressionConverter.ConvertO(bodysalesRepresentativeGUID);
                bodypropCount++;
            }

            if (bodysalesRepresentativeID != null)
            {
                body["Sales_Representative_ID"] = ExpressionConverter.ConvertO(bodysalesRepresentativeID);
                bodypropCount++;
            }

            if (bodyshipAddressCity != null)
            {
                body["ShipAddressCity"] = ExpressionConverter.ConvertO(bodyshipAddressCity);
                bodypropCount++;
            }

            if (bodyshipAddressCountry != null)
            {
                body["ShipAddressCountry"] = ExpressionConverter.ConvertO(bodyshipAddressCountry);
                bodypropCount++;
            }

            if (bodyshipAddressLine1 != null)
            {
                body["ShipAddressLine1"] = ExpressionConverter.ConvertO(bodyshipAddressLine1);
                bodypropCount++;
            }

            if (bodyshipAddressLine2 != null)
            {
                body["ShipAddressLine2"] = ExpressionConverter.ConvertO(bodyshipAddressLine2);
                bodypropCount++;
            }

            if (bodyshipAddressName != null)
            {
                body["ShipAddressName"] = ExpressionConverter.ConvertO(bodyshipAddressName);
                bodypropCount++;
            }

            if (bodyshipAddressState != null)
            {
                body["ShipAddressState"] = ExpressionConverter.ConvertO(bodyshipAddressState);
                bodypropCount++;
            }

            if (bodyshipAddressZipCode != null)
            {
                body["ShipAddressZipCode"] = ExpressionConverter.ConvertO(bodyshipAddressZipCode);
                bodypropCount++;
            }

            if (bodyshipBy != null)
            {
                body["Ship_By"] = ExpressionConverter.ConvertO(bodyshipBy);
                bodypropCount++;
            }

            if (bodyshipVIA != null)
            {
                body["Ship_VIA"] = ExpressionConverter.ConvertO(bodyshipVIA);
                bodypropCount++;
            }

            if (bodystatementNotePrintsBeforeInvRef != null)
            {
                body["Statement_Note_Prints_Before_Inv_Ref"] = ExpressionConverter.ConvertO(bodystatementNotePrintsBeforeInvRef);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAGE50USCreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> SAPB1CreateNewCustomer(Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodybillingAddressName = null, Expression<Func<string>> bodybillingBlock = null, Expression<Func<string>> bodybillingCity = null, Expression<Func<string>> bodybillingCountry = null, Expression<Func<string>> bodybillingState = null, Expression<Func<string>> bodybillingStreet = null, Expression<Func<string>> bodybillingZipCode = null, Expression<Func<string>> bodycardCode = null, Expression<Func<string>> bodycardName = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycontactPerson = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyfederalTaxID = null, Expression<Func<string>> bodyfreeText = null, Expression<Func<int>> bodygroupCode = null, Expression<Func<string>> bodymailAddress = null, Expression<Func<string>> bodymailCity = null, Expression<Func<string>> bodymailCountry = null, Expression<Func<string>> bodymailCounty = null, Expression<Func<string>> bodymailZipCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<int>> bodysalesPersonCode = null, Expression<Func<int>> bodyseries = null, Expression<Func<string>> bodyshippingAddressName = null, Expression<Func<string>> bodyshippingBlock = null, Expression<Func<string>> bodyshippingCity = null, Expression<Func<string>> bodyshippingCountry = null, Expression<Func<string>> bodyshippingState = null, Expression<Func<string>> bodyshippingStreet = null, Expression<Func<string>> bodyshippingZipCode = null, Expression<Func<string>> bodywebSite = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<bodylstContactEmployeesInputItem[]>> bodylstContactEmployees = null)
        {
            var apiCallPath = "/api/v1/sapb1/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaddress != null)
            {
                body["Address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodybillingAddressName != null)
            {
                body["BillingAddressName"] = ExpressionConverter.ConvertO(bodybillingAddressName);
                bodypropCount++;
            }

            if (bodybillingBlock != null)
            {
                body["BillingBlock"] = ExpressionConverter.ConvertO(bodybillingBlock);
                bodypropCount++;
            }

            if (bodybillingCity != null)
            {
                body["BillingCity"] = ExpressionConverter.ConvertO(bodybillingCity);
                bodypropCount++;
            }

            if (bodybillingCountry != null)
            {
                body["BillingCountry"] = ExpressionConverter.ConvertO(bodybillingCountry);
                bodypropCount++;
            }

            if (bodybillingState != null)
            {
                body["BillingState"] = ExpressionConverter.ConvertO(bodybillingState);
                bodypropCount++;
            }

            if (bodybillingStreet != null)
            {
                body["BillingStreet"] = ExpressionConverter.ConvertO(bodybillingStreet);
                bodypropCount++;
            }

            if (bodybillingZipCode != null)
            {
                body["BillingZipCode"] = ExpressionConverter.ConvertO(bodybillingZipCode);
                bodypropCount++;
            }

            if (bodycardCode != null)
            {
                body["CardCode"] = ExpressionConverter.ConvertO(bodycardCode);
                bodypropCount++;
            }

            if (bodycardName != null)
            {
                body["CardName"] = ExpressionConverter.ConvertO(bodycardName);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycontactPerson != null)
            {
                body["ContactPerson"] = ExpressionConverter.ConvertO(bodycontactPerson);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["Country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["County"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["Currency"] = ExpressionConverter.ConvertO(bodycurrency);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = ExpressionConverter.ConvertO(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = ExpressionConverter.ConvertO(bodyextraField);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["Fax"] = ExpressionConverter.ConvertO(bodyfax);
                bodypropCount++;
            }

            if (bodyfederalTaxID != null)
            {
                body["FederalTaxID"] = ExpressionConverter.ConvertO(bodyfederalTaxID);
                bodypropCount++;
            }

            if (bodyfreeText != null)
            {
                body["FreeText"] = ExpressionConverter.ConvertO(bodyfreeText);
                bodypropCount++;
            }

            if (bodygroupCode != null)
            {
                body["GroupCode"] = ExpressionConverter.ConvertO(bodygroupCode);
                bodypropCount++;
            }

            if (bodymailAddress != null)
            {
                body["MailAddress"] = ExpressionConverter.ConvertO(bodymailAddress);
                bodypropCount++;
            }

            if (bodymailCity != null)
            {
                body["MailCity"] = ExpressionConverter.ConvertO(bodymailCity);
                bodypropCount++;
            }

            if (bodymailCountry != null)
            {
                body["MailCountry"] = ExpressionConverter.ConvertO(bodymailCountry);
                bodypropCount++;
            }

            if (bodymailCounty != null)
            {
                body["MailCounty"] = ExpressionConverter.ConvertO(bodymailCounty);
                bodypropCount++;
            }

            if (bodymailZipCode != null)
            {
                body["MailZipCode"] = ExpressionConverter.ConvertO(bodymailZipCode);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["Notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyphone1 != null)
            {
                body["Phone1"] = ExpressionConverter.ConvertO(bodyphone1);
                bodypropCount++;
            }

            if (bodyphone2 != null)
            {
                body["Phone2"] = ExpressionConverter.ConvertO(bodyphone2);
                bodypropCount++;
            }

            if (bodysalesPersonCode != null)
            {
                body["SalesPersonCode"] = ExpressionConverter.ConvertO(bodysalesPersonCode);
                bodypropCount++;
            }

            if (bodyseries != null)
            {
                body["Series"] = ExpressionConverter.ConvertO(bodyseries);
                bodypropCount++;
            }

            if (bodyshippingAddressName != null)
            {
                body["ShippingAddressName"] = ExpressionConverter.ConvertO(bodyshippingAddressName);
                bodypropCount++;
            }

            if (bodyshippingBlock != null)
            {
                body["ShippingBlock"] = ExpressionConverter.ConvertO(bodyshippingBlock);
                bodypropCount++;
            }

            if (bodyshippingCity != null)
            {
                body["ShippingCity"] = ExpressionConverter.ConvertO(bodyshippingCity);
                bodypropCount++;
            }

            if (bodyshippingCountry != null)
            {
                body["ShippingCountry"] = ExpressionConverter.ConvertO(bodyshippingCountry);
                bodypropCount++;
            }

            if (bodyshippingState != null)
            {
                body["ShippingState"] = ExpressionConverter.ConvertO(bodyshippingState);
                bodypropCount++;
            }

            if (bodyshippingStreet != null)
            {
                body["ShippingStreet"] = ExpressionConverter.ConvertO(bodyshippingStreet);
                bodypropCount++;
            }

            if (bodyshippingZipCode != null)
            {
                body["ShippingZipCode"] = ExpressionConverter.ConvertO(bodyshippingZipCode);
                bodypropCount++;
            }

            if (bodywebSite != null)
            {
                body["WebSite"] = ExpressionConverter.ConvertO(bodywebSite);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["ZipCode"] = ExpressionConverter.ConvertO(bodyzipCode);
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
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> SAPB1CreateNewSalesOrder(Expression<Func<string>> bodycardCode = null, Expression<Func<string>> bodydocDate = null, Expression<Func<string>> bodydocDueDate = null, Expression<Func<int>> bodydocNum = null, Expression<Func<bodysalesOrderLineItemInputItem22222[]>> bodysalesOrderLineItem = null, Expression<Func<int>> bodyseries = null, Expression<Func<string>> bodytaxDate = null)
        {
            var apiCallPath = "/api/v1/sapb1/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycardCode != null)
            {
                body["CardCode"] = ExpressionConverter.ConvertO(bodycardCode);
                bodypropCount++;
            }

            if (bodydocDate != null)
            {
                body["DocDate"] = ExpressionConverter.ConvertO(bodydocDate);
                bodypropCount++;
            }

            if (bodydocDueDate != null)
            {
                body["DocDueDate"] = ExpressionConverter.ConvertO(bodydocDueDate);
                bodypropCount++;
            }

            if (bodydocNum != null)
            {
                body["DocNum"] = ExpressionConverter.ConvertO(bodydocNum);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodyseries != null)
            {
                body["Series"] = ExpressionConverter.ConvertO(bodyseries);
                bodypropCount++;
            }

            if (bodytaxDate != null)
            {
                body["TaxDate"] = ExpressionConverter.ConvertO(bodytaxDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SAPB1CreateNewSalesOrderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> SYSPROCreateNewCustomer(Expression<Func<string>> bodyaddTelephone = null, Expression<Func<string>> bodyaltMethodFlag = null, Expression<Func<string>> bodyapplyLineDisc = null, Expression<Func<string>> bodyapplyOrdDisc = null, Expression<Func<string>> bodyarStatementNo = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodybackOrdReqd = null, Expression<Func<string>> bodybalanceType = null, Expression<Func<string>> bodybranch = null, Expression<Func<string>> bodybuyingGroup1 = null, Expression<Func<string>> bodybuyingGroup2 = null, Expression<Func<string>> bodybuyingGroup3 = null, Expression<Func<string>> bodybuyingGroup4 = null, Expression<Func<string>> bodybuyingGroup5 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycity1 = null, Expression<Func<string>> bodycompanyTaxNumber = null, Expression<Func<string>> bodycontact = null, Expression<Func<string>> bodycontractPrcReqd = null, Expression<Func<string>> bodycounterSlsOnly = null, Expression<Func<string>> bodycountyZip = null, Expression<Func<string>> bodycountyZip1 = null, Expression<Func<string>> bodycreditCheckFlag = null, Expression<Func<string>> bodycreditLimit = null, Expression<Func<string>> bodycreditStatus = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodycustomerClass = null, Expression<Func<string>> bodycustomerCode = null, Expression<Func<string>> bodycustomerOnHold = null, Expression<Func<string>> bodydateCustAdded = null, Expression<Func<string>> bodydefaultOrdType = null, Expression<Func<string>> bodydeliveryTerms = null, Expression<Func<string>> bodydeliveryTermsC = null, Expression<Func<string>> bodydetailMoveReqd = null, Expression<Func<string>> bodydocFax = null, Expression<Func<string>> bodydocFaxContact = null, Expression<Func<string>> bodyediFlag = null, Expression<Func<string>> bodyediSenderCode = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyexemptFinChg = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyfaxInvoices = null, Expression<Func<string>> bodyfaxQuotes = null, Expression<Func<string>> bodyfaxStatements = null, Expression<Func<string>> bodygstExemptFlag = null, Expression<Func<string>> bodygstExemptNum = null, Expression<Func<string>> bodygstLevel = null, Expression<Func<string>> bodyhighInv = null, Expression<Func<string>> bodyhighInvDays = null, Expression<Func<string>> bodyhighestBalance = null, Expression<Func<string>> bodyibtCustomer = null, Expression<Func<string>> bodyinvCommentCode = null, Expression<Func<string>> bodyinvDiscCode = null, Expression<Func<string>> bodylanguageCode = null, Expression<Func<string>> bodylineDiscCode = null, Expression<Func<string>> bodymaintHistory = null, Expression<Func<string>> bodymaintLastPrcPaid = null, Expression<Func<string>> bodyminimumOrderChgCod = null, Expression<Func<string>> bodyminimumOrderValue = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodynewCustomerCode = null, Expression<Func<string>> bodypoNumberMandatory = null, Expression<Func<string>> bodypriceCategoryTable = null, Expression<Func<string>> bodypriceCode = null, Expression<Func<string>> bodyrouteCode = null, Expression<Func<string>> bodyrouteDistance = null, Expression<Func<string>> bodysalesWarehouse = null, Expression<Func<string>> bodysalesperson = null, Expression<Func<string>> bodysalesperson1 = null, Expression<Func<string>> bodysalesperson2 = null, Expression<Func<string>> bodysalesperson3 = null, Expression<Func<string>> bodyshipPostalCode = null, Expression<Func<string>> bodyshipToAddr1 = null, Expression<Func<string>> bodyshipToAddr2 = null, Expression<Func<string>> bodyshipToAddr3 = null, Expression<Func<string>> bodyshipToAddr3Loc = null, Expression<Func<string>> bodyshipToAddr4 = null, Expression<Func<string>> bodyshipToAddr5 = null, Expression<Func<string>> bodyshipToGpsLat = null, Expression<Func<string>> bodyshipToGpsLong = null, Expression<Func<string>> bodyshippingInstrs = null, Expression<Func<string>> bodyshippingInstrsCod = null, Expression<Func<string>> bodyshippingLocation = null, Expression<Func<string>> bodyshortName = null, Expression<Func<string>> bodysoDefaultDoc = null, Expression<Func<string>> bodysoDefaultType = null, Expression<Func<string>> bodysoldPostalCode = null, Expression<Func<string>> bodysoldToAddr1 = null, Expression<Func<string>> bodysoldToAddr2 = null, Expression<Func<string>> bodysoldToAddr3 = null, Expression<Func<string>> bodysoldToAddr3Loc = null, Expression<Func<string>> bodysoldToAddr4 = null, Expression<Func<string>> bodysoldToAddr5 = null, Expression<Func<string>> bodysoldToGpsLat = null, Expression<Func<string>> bodysoldToGpsLong = null, Expression<Func<string>> bodyspecialInstrs = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodystate1 = null, Expression<Func<string>> bodystateCode = null, Expression<Func<string>> bodystatementReqd = null, Expression<Func<string>> bodystockInterchange = null, Expression<Func<string>> bodytagsToDropFromXML = null, Expression<Func<string>> bodytaxExemptNumber = null, Expression<Func<string>> bodytaxStatus = null, Expression<Func<string>> bodytelephone = null, Expression<Func<string>> bodytelephoneExtn = null, Expression<Func<string>> bodytelex = null, Expression<Func<string>> bodytermsCode = null, Expression<Func<string>> bodytpmCreditCheck = null, Expression<Func<string>> bodytpmCustomerFlag = null, Expression<Func<string>> bodytpmPricingFlag = null, Expression<Func<string>> bodytransactionNature = null, Expression<Func<string>> bodytransactionNatureC = null, Expression<Func<string>> bodyukCurrency = null, Expression<Func<string>> bodyukVatFlag = null, Expression<Func<string>> bodyuserField1 = null, Expression<Func<string>> bodyuserField2 = null, Expression<Func<string>> bodywholeOrderShipFlag = null, Expression<Func<string>> bodyeSignature = null)
        {
            var apiCallPath = "/api/v1/syspro/customer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaddTelephone != null)
            {
                body["AddTelephone"] = ExpressionConverter.ConvertO(bodyaddTelephone);
                bodypropCount++;
            }

            if (bodyaltMethodFlag != null)
            {
                body["AltMethodFlag"] = ExpressionConverter.ConvertO(bodyaltMethodFlag);
                bodypropCount++;
            }

            if (bodyapplyLineDisc != null)
            {
                body["ApplyLineDisc"] = ExpressionConverter.ConvertO(bodyapplyLineDisc);
                bodypropCount++;
            }

            if (bodyapplyOrdDisc != null)
            {
                body["ApplyOrdDisc"] = ExpressionConverter.ConvertO(bodyapplyOrdDisc);
                bodypropCount++;
            }

            if (bodyarStatementNo != null)
            {
                body["ArStatementNo"] = ExpressionConverter.ConvertO(bodyarStatementNo);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = ExpressionConverter.ConvertO(bodyarea);
                bodypropCount++;
            }

            if (bodybackOrdReqd != null)
            {
                body["BackOrdReqd"] = ExpressionConverter.ConvertO(bodybackOrdReqd);
                bodypropCount++;
            }

            if (bodybalanceType != null)
            {
                body["BalanceType"] = ExpressionConverter.ConvertO(bodybalanceType);
                bodypropCount++;
            }

            if (bodybranch != null)
            {
                body["Branch"] = ExpressionConverter.ConvertO(bodybranch);
                bodypropCount++;
            }

            if (bodybuyingGroup1 != null)
            {
                body["BuyingGroup1"] = ExpressionConverter.ConvertO(bodybuyingGroup1);
                bodypropCount++;
            }

            if (bodybuyingGroup2 != null)
            {
                body["BuyingGroup2"] = ExpressionConverter.ConvertO(bodybuyingGroup2);
                bodypropCount++;
            }

            if (bodybuyingGroup3 != null)
            {
                body["BuyingGroup3"] = ExpressionConverter.ConvertO(bodybuyingGroup3);
                bodypropCount++;
            }

            if (bodybuyingGroup4 != null)
            {
                body["BuyingGroup4"] = ExpressionConverter.ConvertO(bodybuyingGroup4);
                bodypropCount++;
            }

            if (bodybuyingGroup5 != null)
            {
                body["BuyingGroup5"] = ExpressionConverter.ConvertO(bodybuyingGroup5);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycity1 != null)
            {
                body["City1"] = ExpressionConverter.ConvertO(bodycity1);
                bodypropCount++;
            }

            if (bodycompanyTaxNumber != null)
            {
                body["CompanyTaxNumber"] = ExpressionConverter.ConvertO(bodycompanyTaxNumber);
                bodypropCount++;
            }

            if (bodycontact != null)
            {
                body["Contact"] = ExpressionConverter.ConvertO(bodycontact);
                bodypropCount++;
            }

            if (bodycontractPrcReqd != null)
            {
                body["ContractPrcReqd"] = ExpressionConverter.ConvertO(bodycontractPrcReqd);
                bodypropCount++;
            }

            if (bodycounterSlsOnly != null)
            {
                body["CounterSlsOnly"] = ExpressionConverter.ConvertO(bodycounterSlsOnly);
                bodypropCount++;
            }

            if (bodycountyZip != null)
            {
                body["CountyZip"] = ExpressionConverter.ConvertO(bodycountyZip);
                bodypropCount++;
            }

            if (bodycountyZip1 != null)
            {
                body["CountyZip1"] = ExpressionConverter.ConvertO(bodycountyZip1);
                bodypropCount++;
            }

            if (bodycreditCheckFlag != null)
            {
                body["CreditCheckFlag"] = ExpressionConverter.ConvertO(bodycreditCheckFlag);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["CreditLimit"] = ExpressionConverter.ConvertO(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycreditStatus != null)
            {
                body["CreditStatus"] = ExpressionConverter.ConvertO(bodycreditStatus);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["Currency"] = ExpressionConverter.ConvertO(bodycurrency);
                bodypropCount++;
            }

            if (bodycustomerClass != null)
            {
                body["CustomerClass"] = ExpressionConverter.ConvertO(bodycustomerClass);
                bodypropCount++;
            }

            if (bodycustomerCode != null)
            {
                body["CustomerCode"] = ExpressionConverter.ConvertO(bodycustomerCode);
                bodypropCount++;
            }

            if (bodycustomerOnHold != null)
            {
                body["CustomerOnHold"] = ExpressionConverter.ConvertO(bodycustomerOnHold);
                bodypropCount++;
            }

            if (bodydateCustAdded != null)
            {
                body["DateCustAdded"] = ExpressionConverter.ConvertO(bodydateCustAdded);
                bodypropCount++;
            }

            if (bodydefaultOrdType != null)
            {
                body["DefaultOrdType"] = ExpressionConverter.ConvertO(bodydefaultOrdType);
                bodypropCount++;
            }

            if (bodydeliveryTerms != null)
            {
                body["DeliveryTerms"] = ExpressionConverter.ConvertO(bodydeliveryTerms);
                bodypropCount++;
            }

            if (bodydeliveryTermsC != null)
            {
                body["DeliveryTermsC"] = ExpressionConverter.ConvertO(bodydeliveryTermsC);
                bodypropCount++;
            }

            if (bodydetailMoveReqd != null)
            {
                body["DetailMoveReqd"] = ExpressionConverter.ConvertO(bodydetailMoveReqd);
                bodypropCount++;
            }

            if (bodydocFax != null)
            {
                body["DocFax"] = ExpressionConverter.ConvertO(bodydocFax);
                bodypropCount++;
            }

            if (bodydocFaxContact != null)
            {
                body["DocFaxContact"] = ExpressionConverter.ConvertO(bodydocFaxContact);
                bodypropCount++;
            }

            if (bodyediFlag != null)
            {
                body["EdiFlag"] = ExpressionConverter.ConvertO(bodyediFlag);
                bodypropCount++;
            }

            if (bodyediSenderCode != null)
            {
                body["EdiSenderCode"] = ExpressionConverter.ConvertO(bodyediSenderCode);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyexemptFinChg != null)
            {
                body["ExemptFinChg"] = ExpressionConverter.ConvertO(bodyexemptFinChg);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["Fax"] = ExpressionConverter.ConvertO(bodyfax);
                bodypropCount++;
            }

            if (bodyfaxInvoices != null)
            {
                body["FaxInvoices"] = ExpressionConverter.ConvertO(bodyfaxInvoices);
                bodypropCount++;
            }

            if (bodyfaxQuotes != null)
            {
                body["FaxQuotes"] = ExpressionConverter.ConvertO(bodyfaxQuotes);
                bodypropCount++;
            }

            if (bodyfaxStatements != null)
            {
                body["FaxStatements"] = ExpressionConverter.ConvertO(bodyfaxStatements);
                bodypropCount++;
            }

            if (bodygstExemptFlag != null)
            {
                body["GstExemptFlag"] = ExpressionConverter.ConvertO(bodygstExemptFlag);
                bodypropCount++;
            }

            if (bodygstExemptNum != null)
            {
                body["GstExemptNum"] = ExpressionConverter.ConvertO(bodygstExemptNum);
                bodypropCount++;
            }

            if (bodygstLevel != null)
            {
                body["GstLevel"] = ExpressionConverter.ConvertO(bodygstLevel);
                bodypropCount++;
            }

            if (bodyhighInv != null)
            {
                body["HighInv"] = ExpressionConverter.ConvertO(bodyhighInv);
                bodypropCount++;
            }

            if (bodyhighInvDays != null)
            {
                body["HighInvDays"] = ExpressionConverter.ConvertO(bodyhighInvDays);
                bodypropCount++;
            }

            if (bodyhighestBalance != null)
            {
                body["HighestBalance"] = ExpressionConverter.ConvertO(bodyhighestBalance);
                bodypropCount++;
            }

            if (bodyibtCustomer != null)
            {
                body["IbtCustomer"] = ExpressionConverter.ConvertO(bodyibtCustomer);
                bodypropCount++;
            }

            if (bodyinvCommentCode != null)
            {
                body["InvCommentCode"] = ExpressionConverter.ConvertO(bodyinvCommentCode);
                bodypropCount++;
            }

            if (bodyinvDiscCode != null)
            {
                body["InvDiscCode"] = ExpressionConverter.ConvertO(bodyinvDiscCode);
                bodypropCount++;
            }

            if (bodylanguageCode != null)
            {
                body["LanguageCode"] = ExpressionConverter.ConvertO(bodylanguageCode);
                bodypropCount++;
            }

            if (bodylineDiscCode != null)
            {
                body["LineDiscCode"] = ExpressionConverter.ConvertO(bodylineDiscCode);
                bodypropCount++;
            }

            if (bodymaintHistory != null)
            {
                body["MaintHistory"] = ExpressionConverter.ConvertO(bodymaintHistory);
                bodypropCount++;
            }

            if (bodymaintLastPrcPaid != null)
            {
                body["MaintLastPrcPaid"] = ExpressionConverter.ConvertO(bodymaintLastPrcPaid);
                bodypropCount++;
            }

            if (bodyminimumOrderChgCod != null)
            {
                body["MinimumOrderChgCod"] = ExpressionConverter.ConvertO(bodyminimumOrderChgCod);
                bodypropCount++;
            }

            if (bodyminimumOrderValue != null)
            {
                body["MinimumOrderValue"] = ExpressionConverter.ConvertO(bodyminimumOrderValue);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["Nationality"] = ExpressionConverter.ConvertO(bodynationality);
                bodypropCount++;
            }

            if (bodynewCustomerCode != null)
            {
                body["NewCustomerCode"] = ExpressionConverter.ConvertO(bodynewCustomerCode);
                bodypropCount++;
            }

            if (bodypoNumberMandatory != null)
            {
                body["PoNumberMandatory"] = ExpressionConverter.ConvertO(bodypoNumberMandatory);
                bodypropCount++;
            }

            if (bodypriceCategoryTable != null)
            {
                body["PriceCategoryTable"] = ExpressionConverter.ConvertO(bodypriceCategoryTable);
                bodypropCount++;
            }

            if (bodypriceCode != null)
            {
                body["PriceCode"] = ExpressionConverter.ConvertO(bodypriceCode);
                bodypropCount++;
            }

            if (bodyrouteCode != null)
            {
                body["RouteCode"] = ExpressionConverter.ConvertO(bodyrouteCode);
                bodypropCount++;
            }

            if (bodyrouteDistance != null)
            {
                body["RouteDistance"] = ExpressionConverter.ConvertO(bodyrouteDistance);
                bodypropCount++;
            }

            if (bodysalesWarehouse != null)
            {
                body["SalesWarehouse"] = ExpressionConverter.ConvertO(bodysalesWarehouse);
                bodypropCount++;
            }

            if (bodysalesperson != null)
            {
                body["Salesperson"] = ExpressionConverter.ConvertO(bodysalesperson);
                bodypropCount++;
            }

            if (bodysalesperson1 != null)
            {
                body["Salesperson1"] = ExpressionConverter.ConvertO(bodysalesperson1);
                bodypropCount++;
            }

            if (bodysalesperson2 != null)
            {
                body["Salesperson2"] = ExpressionConverter.ConvertO(bodysalesperson2);
                bodypropCount++;
            }

            if (bodysalesperson3 != null)
            {
                body["Salesperson3"] = ExpressionConverter.ConvertO(bodysalesperson3);
                bodypropCount++;
            }

            if (bodyshipPostalCode != null)
            {
                body["ShipPostalCode"] = ExpressionConverter.ConvertO(bodyshipPostalCode);
                bodypropCount++;
            }

            if (bodyshipToAddr1 != null)
            {
                body["ShipToAddr1"] = ExpressionConverter.ConvertO(bodyshipToAddr1);
                bodypropCount++;
            }

            if (bodyshipToAddr2 != null)
            {
                body["ShipToAddr2"] = ExpressionConverter.ConvertO(bodyshipToAddr2);
                bodypropCount++;
            }

            if (bodyshipToAddr3 != null)
            {
                body["ShipToAddr3"] = ExpressionConverter.ConvertO(bodyshipToAddr3);
                bodypropCount++;
            }

            if (bodyshipToAddr3Loc != null)
            {
                body["ShipToAddr3Loc"] = ExpressionConverter.ConvertO(bodyshipToAddr3Loc);
                bodypropCount++;
            }

            if (bodyshipToAddr4 != null)
            {
                body["ShipToAddr4"] = ExpressionConverter.ConvertO(bodyshipToAddr4);
                bodypropCount++;
            }

            if (bodyshipToAddr5 != null)
            {
                body["ShipToAddr5"] = ExpressionConverter.ConvertO(bodyshipToAddr5);
                bodypropCount++;
            }

            if (bodyshipToGpsLat != null)
            {
                body["ShipToGpsLat"] = ExpressionConverter.ConvertO(bodyshipToGpsLat);
                bodypropCount++;
            }

            if (bodyshipToGpsLong != null)
            {
                body["ShipToGpsLong"] = ExpressionConverter.ConvertO(bodyshipToGpsLong);
                bodypropCount++;
            }

            if (bodyshippingInstrs != null)
            {
                body["ShippingInstrs"] = ExpressionConverter.ConvertO(bodyshippingInstrs);
                bodypropCount++;
            }

            if (bodyshippingInstrsCod != null)
            {
                body["ShippingInstrsCod"] = ExpressionConverter.ConvertO(bodyshippingInstrsCod);
                bodypropCount++;
            }

            if (bodyshippingLocation != null)
            {
                body["ShippingLocation"] = ExpressionConverter.ConvertO(bodyshippingLocation);
                bodypropCount++;
            }

            if (bodyshortName != null)
            {
                body["ShortName"] = ExpressionConverter.ConvertO(bodyshortName);
                bodypropCount++;
            }

            if (bodysoDefaultDoc != null)
            {
                body["SoDefaultDoc"] = ExpressionConverter.ConvertO(bodysoDefaultDoc);
                bodypropCount++;
            }

            if (bodysoDefaultType != null)
            {
                body["SoDefaultType"] = ExpressionConverter.ConvertO(bodysoDefaultType);
                bodypropCount++;
            }

            if (bodysoldPostalCode != null)
            {
                body["SoldPostalCode"] = ExpressionConverter.ConvertO(bodysoldPostalCode);
                bodypropCount++;
            }

            if (bodysoldToAddr1 != null)
            {
                body["SoldToAddr1"] = ExpressionConverter.ConvertO(bodysoldToAddr1);
                bodypropCount++;
            }

            if (bodysoldToAddr2 != null)
            {
                body["SoldToAddr2"] = ExpressionConverter.ConvertO(bodysoldToAddr2);
                bodypropCount++;
            }

            if (bodysoldToAddr3 != null)
            {
                body["SoldToAddr3"] = ExpressionConverter.ConvertO(bodysoldToAddr3);
                bodypropCount++;
            }

            if (bodysoldToAddr3Loc != null)
            {
                body["SoldToAddr3Loc"] = ExpressionConverter.ConvertO(bodysoldToAddr3Loc);
                bodypropCount++;
            }

            if (bodysoldToAddr4 != null)
            {
                body["SoldToAddr4"] = ExpressionConverter.ConvertO(bodysoldToAddr4);
                bodypropCount++;
            }

            if (bodysoldToAddr5 != null)
            {
                body["SoldToAddr5"] = ExpressionConverter.ConvertO(bodysoldToAddr5);
                bodypropCount++;
            }

            if (bodysoldToGpsLat != null)
            {
                body["SoldToGpsLat"] = ExpressionConverter.ConvertO(bodysoldToGpsLat);
                bodypropCount++;
            }

            if (bodysoldToGpsLong != null)
            {
                body["SoldToGpsLong"] = ExpressionConverter.ConvertO(bodysoldToGpsLong);
                bodypropCount++;
            }

            if (bodyspecialInstrs != null)
            {
                body["SpecialInstrs"] = ExpressionConverter.ConvertO(bodyspecialInstrs);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["State"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodystate1 != null)
            {
                body["State1"] = ExpressionConverter.ConvertO(bodystate1);
                bodypropCount++;
            }

            if (bodystateCode != null)
            {
                body["StateCode"] = ExpressionConverter.ConvertO(bodystateCode);
                bodypropCount++;
            }

            if (bodystatementReqd != null)
            {
                body["StatementReqd"] = ExpressionConverter.ConvertO(bodystatementReqd);
                bodypropCount++;
            }

            if (bodystockInterchange != null)
            {
                body["StockInterchange"] = ExpressionConverter.ConvertO(bodystockInterchange);
                bodypropCount++;
            }

            if (bodytagsToDropFromXML != null)
            {
                body["TagsToDropFromXML"] = ExpressionConverter.ConvertO(bodytagsToDropFromXML);
                bodypropCount++;
            }

            if (bodytaxExemptNumber != null)
            {
                body["TaxExemptNumber"] = ExpressionConverter.ConvertO(bodytaxExemptNumber);
                bodypropCount++;
            }

            if (bodytaxStatus != null)
            {
                body["TaxStatus"] = ExpressionConverter.ConvertO(bodytaxStatus);
                bodypropCount++;
            }

            if (bodytelephone != null)
            {
                body["Telephone"] = ExpressionConverter.ConvertO(bodytelephone);
                bodypropCount++;
            }

            if (bodytelephoneExtn != null)
            {
                body["TelephoneExtn"] = ExpressionConverter.ConvertO(bodytelephoneExtn);
                bodypropCount++;
            }

            if (bodytelex != null)
            {
                body["Telex"] = ExpressionConverter.ConvertO(bodytelex);
                bodypropCount++;
            }

            if (bodytermsCode != null)
            {
                body["TermsCode"] = ExpressionConverter.ConvertO(bodytermsCode);
                bodypropCount++;
            }

            if (bodytpmCreditCheck != null)
            {
                body["TpmCreditCheck"] = ExpressionConverter.ConvertO(bodytpmCreditCheck);
                bodypropCount++;
            }

            if (bodytpmCustomerFlag != null)
            {
                body["TpmCustomerFlag"] = ExpressionConverter.ConvertO(bodytpmCustomerFlag);
                bodypropCount++;
            }

            if (bodytpmPricingFlag != null)
            {
                body["TpmPricingFlag"] = ExpressionConverter.ConvertO(bodytpmPricingFlag);
                bodypropCount++;
            }

            if (bodytransactionNature != null)
            {
                body["TransactionNature"] = ExpressionConverter.ConvertO(bodytransactionNature);
                bodypropCount++;
            }

            if (bodytransactionNatureC != null)
            {
                body["TransactionNatureC"] = ExpressionConverter.ConvertO(bodytransactionNatureC);
                bodypropCount++;
            }

            if (bodyukCurrency != null)
            {
                body["UkCurrency"] = ExpressionConverter.ConvertO(bodyukCurrency);
                bodypropCount++;
            }

            if (bodyukVatFlag != null)
            {
                body["UkVatFlag"] = ExpressionConverter.ConvertO(bodyukVatFlag);
                bodypropCount++;
            }

            if (bodyuserField1 != null)
            {
                body["UserField1"] = ExpressionConverter.ConvertO(bodyuserField1);
                bodypropCount++;
            }

            if (bodyuserField2 != null)
            {
                body["UserField2"] = ExpressionConverter.ConvertO(bodyuserField2);
                bodypropCount++;
            }

            if (bodywholeOrderShipFlag != null)
            {
                body["WholeOrderShipFlag"] = ExpressionConverter.ConvertO(bodywholeOrderShipFlag);
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
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> SYSPROCreateNewSalesOrder(Expression<Func<string>> bodyacceptEarlierShipDate = null, Expression<Func<string>> bodyacceptKitOptional = null, Expression<Func<string>> bodyacceptOrdersIfNoCredit = null, Expression<Func<string>> bodyaddAttachedServiceCharges = null, Expression<Func<string>> bodyaddDangerousGoodsText = null, Expression<Func<string>> bodyaddStockSalesOrderText = null, Expression<Func<string>> bodyallocationAction = null, Expression<Func<string>> bodyallowBackOrderForNegativeMerchLine = null, Expression<Func<string>> bodyallowBackOrderForPartialHold = null, Expression<Func<string>> bodyallowBackOrderForSuperseded = null, Expression<Func<string>> bodyallowChangeToZeroPrice = null, Expression<Func<string>> bodyallowDuplicateOrderNumbers = null, Expression<Func<string>> bodyallowManualOrderNumberToBeUsed = null, Expression<Func<string>> bodyallowNonStockItems = null, Expression<Func<string>> bodyallowZeroPrice = null, Expression<Func<string>> bodyalternateReference = null, Expression<Func<string>> bodyalwaysUsePriceEntered = null, Expression<Func<string>> bodyapplyLeadTimeCalculation = null, Expression<Func<string>> bodyapplyParentDiscountToComponents = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodybranch = null, Expression<Func<string>> bodycancelReasonCode = null, Expression<Func<string>> bodycheckForCustomerPoNumbers = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycompanyTaxNumber = null, Expression<Func<string>> bodycountyZip = null, Expression<Func<string>> bodycreditFailMessage = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodycustomer = null, Expression<Func<string>> bodycustomerName = null, Expression<Func<string>> bodycustomerPoNumber = null, Expression<Func<string>> bodycustomerToUse = null, Expression<Func<string>> bodydeliveryRoute = null, Expression<Func<string>> bodydeliveryRouteAction = null, Expression<Func<string>> bodydeliveryTerms = null, Expression<Func<string>> bodydocumentFormat = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyglobalTradePromotionCodes = null, Expression<Func<string>> bodygstExemptNumber = null, Expression<Func<string>> bodygstExemptionStatus = null, Expression<Func<string>> bodyheaderFreightCharges = null, Expression<Func<string>> bodyheaderMiscCharges = null, Expression<Func<string>> bodyignoreWarnings = null, Expression<Func<string>> bodyinBoxMsgReqd = null, Expression<Func<string>> bodyincludeInMrp = null, Expression<Func<string>> bodyinvoiceDateEntered = null, Expression<Func<string>> bodyinvoiceNumberEntered = null, Expression<Func<string>> bodyinvoiceTerms = null, Expression<Func<string>> bodyinvoiceWholeOrderOnly = null, Expression<Func<string>> bodylanguageCode = null, Expression<Func<string>> bodyminimumDaysToShip = null, Expression<Func<string>> bodymultiShipCode = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodynewCustomerPoNumber = null, Expression<Func<string>> bodynewSalesOrderNumber = null, Expression<Func<string>> bodyoperatorToInform = null, Expression<Func<string>> bodyorderActionType = null, Expression<Func<string>> bodyorderComments = null, Expression<Func<string>> bodyorderDate = null, Expression<Func<string>> bodyorderDiscPercent1 = null, Expression<Func<string>> bodyorderDiscPercent2 = null, Expression<Func<string>> bodyorderDiscPercent3 = null, Expression<Func<string>> bodyorderStatus = null, Expression<Func<string>> bodyorderType = null, Expression<Func<string>> bodyoverrideCustomerBackOrder = null, Expression<Func<string>> bodypOSSalesOrder = null, Expression<Func<string>> bodyprocess = null, Expression<Func<string>> bodyprocessFlag = null, Expression<Func<string>> bodyputEntireQuantityOnNewLoadWhenChanged = null, Expression<Func<string>> bodyreceiverCode = null, Expression<Func<string>> bodyrequestedShipDate = null, Expression<Func<string>> bodyreserveStock = null, Expression<Func<string>> bodyreserveStockRequestAllocs = null, Expression<Func<string>> bodysalesOrder = null, Expression<Func<bodysalesOrderDetailsInputItem[]>> bodysalesOrderDetails = null, Expression<Func<bodysalesOrderFooterCommentsInputItem[]>> bodysalesOrderFooterComments = null, Expression<Func<bodysalesOrderFreightDetailsInputItem[]>> bodysalesOrderFreightDetails = null, Expression<Func<bodysalesOrderHeaderCommentsInputItem[]>> bodysalesOrderHeaderComments = null, Expression<Func<bodysalesOrderMiscChargesDetailsInputItem[]>> bodysalesOrderMiscChargesDetails = null, Expression<Func<string>> bodysalesOrderPromoQualifyAction = null, Expression<Func<string>> bodysalesOrderPromoSelectAction = null, Expression<Func<string>> bodysalesperson = null, Expression<Func<string>> bodysenderCode = null, Expression<Func<string>> bodyshipAddress1 = null, Expression<Func<string>> bodyshipAddress2 = null, Expression<Func<string>> bodyshipAddress3 = null, Expression<Func<string>> bodyshipAddress3Locality = null, Expression<Func<string>> bodyshipAddress4 = null, Expression<Func<string>> bodyshipAddress5 = null, Expression<Func<string>> bodyshipAddressPerLine = null, Expression<Func<string>> bodyshipAddressPerLineTax = null, Expression<Func<string>> bodyshipGpsLat = null, Expression<Func<string>> bodyshipGpsLong = null, Expression<Func<string>> bodyshipPostalCode = null, Expression<Func<string>> bodyshippingInstrs = null, Expression<Func<string>> bodyshippingInstrsCode = null, Expression<Func<string>> bodyshippingLocation = null, Expression<Func<string>> bodyspecialInstrs = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodystatusInProcess = null, Expression<Func<string>> bodystatusInProcessResponse = null, Expression<Func<string>> bodysupplier = null, Expression<Func<string>> bodytagsToDropFromXML = null, Expression<Func<string>> bodytaxExemptNumber = null, Expression<Func<string>> bodytaxExemptionStatus = null, Expression<Func<string>> bodytransactionNature = null, Expression<Func<string>> bodytransmissionReference = null, Expression<Func<string>> bodytransportMode = null, Expression<Func<string>> bodytypeOfOrder = null, Expression<Func<string>> bodyuseCustomerSalesWarehouse = null, Expression<Func<string>> bodyuseMasterAccountForCustomerPartNo = null, Expression<Func<string>> bodyuseStockDescSupplied = null, Expression<Func<string>> bodyvalidateShippingInstrs = null, Expression<Func<string>> bodywarehouse = null, Expression<Func<string>> bodywarehouseListToUse = null, Expression<Func<string>> bodywarnIfCustomerOnHold = null, Expression<Func<string>> bodyeSignature = null)
        {
            var apiCallPath = "/api/v1/syspro/salesorder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyacceptEarlierShipDate != null)
            {
                body["AcceptEarlierShipDate"] = ExpressionConverter.ConvertO(bodyacceptEarlierShipDate);
                bodypropCount++;
            }

            if (bodyacceptKitOptional != null)
            {
                body["AcceptKitOptional"] = ExpressionConverter.ConvertO(bodyacceptKitOptional);
                bodypropCount++;
            }

            if (bodyacceptOrdersIfNoCredit != null)
            {
                body["AcceptOrdersIfNoCredit"] = ExpressionConverter.ConvertO(bodyacceptOrdersIfNoCredit);
                bodypropCount++;
            }

            if (bodyaddAttachedServiceCharges != null)
            {
                body["AddAttachedServiceCharges"] = ExpressionConverter.ConvertO(bodyaddAttachedServiceCharges);
                bodypropCount++;
            }

            if (bodyaddDangerousGoodsText != null)
            {
                body["AddDangerousGoodsText"] = ExpressionConverter.ConvertO(bodyaddDangerousGoodsText);
                bodypropCount++;
            }

            if (bodyaddStockSalesOrderText != null)
            {
                body["AddStockSalesOrderText"] = ExpressionConverter.ConvertO(bodyaddStockSalesOrderText);
                bodypropCount++;
            }

            if (bodyallocationAction != null)
            {
                body["AllocationAction"] = ExpressionConverter.ConvertO(bodyallocationAction);
                bodypropCount++;
            }

            if (bodyallowBackOrderForNegativeMerchLine != null)
            {
                body["AllowBackOrderForNegativeMerchLine"] = ExpressionConverter.ConvertO(bodyallowBackOrderForNegativeMerchLine);
                bodypropCount++;
            }

            if (bodyallowBackOrderForPartialHold != null)
            {
                body["AllowBackOrderForPartialHold"] = ExpressionConverter.ConvertO(bodyallowBackOrderForPartialHold);
                bodypropCount++;
            }

            if (bodyallowBackOrderForSuperseded != null)
            {
                body["AllowBackOrderForSuperseded"] = ExpressionConverter.ConvertO(bodyallowBackOrderForSuperseded);
                bodypropCount++;
            }

            if (bodyallowChangeToZeroPrice != null)
            {
                body["AllowChangeToZeroPrice"] = ExpressionConverter.ConvertO(bodyallowChangeToZeroPrice);
                bodypropCount++;
            }

            if (bodyallowDuplicateOrderNumbers != null)
            {
                body["AllowDuplicateOrderNumbers"] = ExpressionConverter.ConvertO(bodyallowDuplicateOrderNumbers);
                bodypropCount++;
            }

            if (bodyallowManualOrderNumberToBeUsed != null)
            {
                body["AllowManualOrderNumberToBeUsed"] = ExpressionConverter.ConvertO(bodyallowManualOrderNumberToBeUsed);
                bodypropCount++;
            }

            if (bodyallowNonStockItems != null)
            {
                body["AllowNonStockItems"] = ExpressionConverter.ConvertO(bodyallowNonStockItems);
                bodypropCount++;
            }

            if (bodyallowZeroPrice != null)
            {
                body["AllowZeroPrice"] = ExpressionConverter.ConvertO(bodyallowZeroPrice);
                bodypropCount++;
            }

            if (bodyalternateReference != null)
            {
                body["AlternateReference"] = ExpressionConverter.ConvertO(bodyalternateReference);
                bodypropCount++;
            }

            if (bodyalwaysUsePriceEntered != null)
            {
                body["AlwaysUsePriceEntered"] = ExpressionConverter.ConvertO(bodyalwaysUsePriceEntered);
                bodypropCount++;
            }

            if (bodyapplyLeadTimeCalculation != null)
            {
                body["ApplyLeadTimeCalculation"] = ExpressionConverter.ConvertO(bodyapplyLeadTimeCalculation);
                bodypropCount++;
            }

            if (bodyapplyParentDiscountToComponents != null)
            {
                body["ApplyParentDiscountToComponents"] = ExpressionConverter.ConvertO(bodyapplyParentDiscountToComponents);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = ExpressionConverter.ConvertO(bodyarea);
                bodypropCount++;
            }

            if (bodybranch != null)
            {
                body["Branch"] = ExpressionConverter.ConvertO(bodybranch);
                bodypropCount++;
            }

            if (bodycancelReasonCode != null)
            {
                body["CancelReasonCode"] = ExpressionConverter.ConvertO(bodycancelReasonCode);
                bodypropCount++;
            }

            if (bodycheckForCustomerPoNumbers != null)
            {
                body["CheckForCustomerPoNumbers"] = ExpressionConverter.ConvertO(bodycheckForCustomerPoNumbers);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycompanyTaxNumber != null)
            {
                body["CompanyTaxNumber"] = ExpressionConverter.ConvertO(bodycompanyTaxNumber);
                bodypropCount++;
            }

            if (bodycountyZip != null)
            {
                body["CountyZip"] = ExpressionConverter.ConvertO(bodycountyZip);
                bodypropCount++;
            }

            if (bodycreditFailMessage != null)
            {
                body["CreditFailMessage"] = ExpressionConverter.ConvertO(bodycreditFailMessage);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["Currency"] = ExpressionConverter.ConvertO(bodycurrency);
                bodypropCount++;
            }

            if (bodycustomer != null)
            {
                body["Customer"] = ExpressionConverter.ConvertO(bodycustomer);
                bodypropCount++;
            }

            if (bodycustomerName != null)
            {
                body["CustomerName"] = ExpressionConverter.ConvertO(bodycustomerName);
                bodypropCount++;
            }

            if (bodycustomerPoNumber != null)
            {
                body["CustomerPoNumber"] = ExpressionConverter.ConvertO(bodycustomerPoNumber);
                bodypropCount++;
            }

            if (bodycustomerToUse != null)
            {
                body["CustomerToUse"] = ExpressionConverter.ConvertO(bodycustomerToUse);
                bodypropCount++;
            }

            if (bodydeliveryRoute != null)
            {
                body["DeliveryRoute"] = ExpressionConverter.ConvertO(bodydeliveryRoute);
                bodypropCount++;
            }

            if (bodydeliveryRouteAction != null)
            {
                body["DeliveryRouteAction"] = ExpressionConverter.ConvertO(bodydeliveryRouteAction);
                bodypropCount++;
            }

            if (bodydeliveryTerms != null)
            {
                body["DeliveryTerms"] = ExpressionConverter.ConvertO(bodydeliveryTerms);
                bodypropCount++;
            }

            if (bodydocumentFormat != null)
            {
                body["DocumentFormat"] = ExpressionConverter.ConvertO(bodydocumentFormat);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyglobalTradePromotionCodes != null)
            {
                body["GlobalTradePromotionCodes"] = ExpressionConverter.ConvertO(bodyglobalTradePromotionCodes);
                bodypropCount++;
            }

            if (bodygstExemptNumber != null)
            {
                body["GstExemptNumber"] = ExpressionConverter.ConvertO(bodygstExemptNumber);
                bodypropCount++;
            }

            if (bodygstExemptionStatus != null)
            {
                body["GstExemptionStatus"] = ExpressionConverter.ConvertO(bodygstExemptionStatus);
                bodypropCount++;
            }

            if (bodyheaderFreightCharges != null)
            {
                body["HeaderFreightCharges"] = ExpressionConverter.ConvertO(bodyheaderFreightCharges);
                bodypropCount++;
            }

            if (bodyheaderMiscCharges != null)
            {
                body["HeaderMiscCharges"] = ExpressionConverter.ConvertO(bodyheaderMiscCharges);
                bodypropCount++;
            }

            if (bodyignoreWarnings != null)
            {
                body["IgnoreWarnings"] = ExpressionConverter.ConvertO(bodyignoreWarnings);
                bodypropCount++;
            }

            if (bodyinBoxMsgReqd != null)
            {
                body["InBoxMsgReqd"] = ExpressionConverter.ConvertO(bodyinBoxMsgReqd);
                bodypropCount++;
            }

            if (bodyincludeInMrp != null)
            {
                body["IncludeInMrp"] = ExpressionConverter.ConvertO(bodyincludeInMrp);
                bodypropCount++;
            }

            if (bodyinvoiceDateEntered != null)
            {
                body["InvoiceDateEntered"] = ExpressionConverter.ConvertO(bodyinvoiceDateEntered);
                bodypropCount++;
            }

            if (bodyinvoiceNumberEntered != null)
            {
                body["InvoiceNumberEntered"] = ExpressionConverter.ConvertO(bodyinvoiceNumberEntered);
                bodypropCount++;
            }

            if (bodyinvoiceTerms != null)
            {
                body["InvoiceTerms"] = ExpressionConverter.ConvertO(bodyinvoiceTerms);
                bodypropCount++;
            }

            if (bodyinvoiceWholeOrderOnly != null)
            {
                body["InvoiceWholeOrderOnly"] = ExpressionConverter.ConvertO(bodyinvoiceWholeOrderOnly);
                bodypropCount++;
            }

            if (bodylanguageCode != null)
            {
                body["LanguageCode"] = ExpressionConverter.ConvertO(bodylanguageCode);
                bodypropCount++;
            }

            if (bodyminimumDaysToShip != null)
            {
                body["MinimumDaysToShip"] = ExpressionConverter.ConvertO(bodyminimumDaysToShip);
                bodypropCount++;
            }

            if (bodymultiShipCode != null)
            {
                body["MultiShipCode"] = ExpressionConverter.ConvertO(bodymultiShipCode);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["Nationality"] = ExpressionConverter.ConvertO(bodynationality);
                bodypropCount++;
            }

            if (bodynewCustomerPoNumber != null)
            {
                body["NewCustomerPoNumber"] = ExpressionConverter.ConvertO(bodynewCustomerPoNumber);
                bodypropCount++;
            }

            if (bodynewSalesOrderNumber != null)
            {
                body["NewSalesOrderNumber"] = ExpressionConverter.ConvertO(bodynewSalesOrderNumber);
                bodypropCount++;
            }

            if (bodyoperatorToInform != null)
            {
                body["OperatorToInform"] = ExpressionConverter.ConvertO(bodyoperatorToInform);
                bodypropCount++;
            }

            if (bodyorderActionType != null)
            {
                body["OrderActionType"] = ExpressionConverter.ConvertO(bodyorderActionType);
                bodypropCount++;
            }

            if (bodyorderComments != null)
            {
                body["OrderComments"] = ExpressionConverter.ConvertO(bodyorderComments);
                bodypropCount++;
            }

            if (bodyorderDate != null)
            {
                body["OrderDate"] = ExpressionConverter.ConvertO(bodyorderDate);
                bodypropCount++;
            }

            if (bodyorderDiscPercent1 != null)
            {
                body["OrderDiscPercent1"] = ExpressionConverter.ConvertO(bodyorderDiscPercent1);
                bodypropCount++;
            }

            if (bodyorderDiscPercent2 != null)
            {
                body["OrderDiscPercent2"] = ExpressionConverter.ConvertO(bodyorderDiscPercent2);
                bodypropCount++;
            }

            if (bodyorderDiscPercent3 != null)
            {
                body["OrderDiscPercent3"] = ExpressionConverter.ConvertO(bodyorderDiscPercent3);
                bodypropCount++;
            }

            if (bodyorderStatus != null)
            {
                body["OrderStatus"] = ExpressionConverter.ConvertO(bodyorderStatus);
                bodypropCount++;
            }

            if (bodyorderType != null)
            {
                body["OrderType"] = ExpressionConverter.ConvertO(bodyorderType);
                bodypropCount++;
            }

            if (bodyoverrideCustomerBackOrder != null)
            {
                body["OverrideCustomerBackOrder"] = ExpressionConverter.ConvertO(bodyoverrideCustomerBackOrder);
                bodypropCount++;
            }

            if (bodypOSSalesOrder != null)
            {
                body["POSSalesOrder"] = ExpressionConverter.ConvertO(bodypOSSalesOrder);
                bodypropCount++;
            }

            if (bodyprocess != null)
            {
                body["Process"] = ExpressionConverter.ConvertO(bodyprocess);
                bodypropCount++;
            }

            if (bodyprocessFlag != null)
            {
                body["ProcessFlag"] = ExpressionConverter.ConvertO(bodyprocessFlag);
                bodypropCount++;
            }

            if (bodyputEntireQuantityOnNewLoadWhenChanged != null)
            {
                body["PutEntireQuantityOnNewLoadWhenChanged"] = ExpressionConverter.ConvertO(bodyputEntireQuantityOnNewLoadWhenChanged);
                bodypropCount++;
            }

            if (bodyreceiverCode != null)
            {
                body["ReceiverCode"] = ExpressionConverter.ConvertO(bodyreceiverCode);
                bodypropCount++;
            }

            if (bodyrequestedShipDate != null)
            {
                body["RequestedShipDate"] = ExpressionConverter.ConvertO(bodyrequestedShipDate);
                bodypropCount++;
            }

            if (bodyreserveStock != null)
            {
                body["ReserveStock"] = ExpressionConverter.ConvertO(bodyreserveStock);
                bodypropCount++;
            }

            if (bodyreserveStockRequestAllocs != null)
            {
                body["ReserveStockRequestAllocs"] = ExpressionConverter.ConvertO(bodyreserveStockRequestAllocs);
                bodypropCount++;
            }

            if (bodysalesOrder != null)
            {
                body["SalesOrder"] = ExpressionConverter.ConvertO(bodysalesOrder);
                bodypropCount++;
            }

            if (bodysalesOrderDetails != null)
            {
                body["SalesOrderDetails"] = ExpressionConverter.ConvertO(bodysalesOrderDetails);
                bodypropCount++;
            }

            if (bodysalesOrderFooterComments != null)
            {
                body["SalesOrderFooterComments"] = ExpressionConverter.ConvertO(bodysalesOrderFooterComments);
                bodypropCount++;
            }

            if (bodysalesOrderFreightDetails != null)
            {
                body["SalesOrderFreightDetails"] = ExpressionConverter.ConvertO(bodysalesOrderFreightDetails);
                bodypropCount++;
            }

            if (bodysalesOrderHeaderComments != null)
            {
                body["SalesOrderHeaderComments"] = ExpressionConverter.ConvertO(bodysalesOrderHeaderComments);
                bodypropCount++;
            }

            if (bodysalesOrderMiscChargesDetails != null)
            {
                body["SalesOrderMiscChargesDetails"] = ExpressionConverter.ConvertO(bodysalesOrderMiscChargesDetails);
                bodypropCount++;
            }

            if (bodysalesOrderPromoQualifyAction != null)
            {
                body["SalesOrderPromoQualifyAction"] = ExpressionConverter.ConvertO(bodysalesOrderPromoQualifyAction);
                bodypropCount++;
            }

            if (bodysalesOrderPromoSelectAction != null)
            {
                body["SalesOrderPromoSelectAction"] = ExpressionConverter.ConvertO(bodysalesOrderPromoSelectAction);
                bodypropCount++;
            }

            if (bodysalesperson != null)
            {
                body["Salesperson"] = ExpressionConverter.ConvertO(bodysalesperson);
                bodypropCount++;
            }

            if (bodysenderCode != null)
            {
                body["SenderCode"] = ExpressionConverter.ConvertO(bodysenderCode);
                bodypropCount++;
            }

            if (bodyshipAddress1 != null)
            {
                body["ShipAddress1"] = ExpressionConverter.ConvertO(bodyshipAddress1);
                bodypropCount++;
            }

            if (bodyshipAddress2 != null)
            {
                body["ShipAddress2"] = ExpressionConverter.ConvertO(bodyshipAddress2);
                bodypropCount++;
            }

            if (bodyshipAddress3 != null)
            {
                body["ShipAddress3"] = ExpressionConverter.ConvertO(bodyshipAddress3);
                bodypropCount++;
            }

            if (bodyshipAddress3Locality != null)
            {
                body["ShipAddress3Locality"] = ExpressionConverter.ConvertO(bodyshipAddress3Locality);
                bodypropCount++;
            }

            if (bodyshipAddress4 != null)
            {
                body["ShipAddress4"] = ExpressionConverter.ConvertO(bodyshipAddress4);
                bodypropCount++;
            }

            if (bodyshipAddress5 != null)
            {
                body["ShipAddress5"] = ExpressionConverter.ConvertO(bodyshipAddress5);
                bodypropCount++;
            }

            if (bodyshipAddressPerLine != null)
            {
                body["ShipAddressPerLine"] = ExpressionConverter.ConvertO(bodyshipAddressPerLine);
                bodypropCount++;
            }

            if (bodyshipAddressPerLineTax != null)
            {
                body["ShipAddressPerLineTax"] = ExpressionConverter.ConvertO(bodyshipAddressPerLineTax);
                bodypropCount++;
            }

            if (bodyshipGpsLat != null)
            {
                body["ShipGpsLat"] = ExpressionConverter.ConvertO(bodyshipGpsLat);
                bodypropCount++;
            }

            if (bodyshipGpsLong != null)
            {
                body["ShipGpsLong"] = ExpressionConverter.ConvertO(bodyshipGpsLong);
                bodypropCount++;
            }

            if (bodyshipPostalCode != null)
            {
                body["ShipPostalCode"] = ExpressionConverter.ConvertO(bodyshipPostalCode);
                bodypropCount++;
            }

            if (bodyshippingInstrs != null)
            {
                body["ShippingInstrs"] = ExpressionConverter.ConvertO(bodyshippingInstrs);
                bodypropCount++;
            }

            if (bodyshippingInstrsCode != null)
            {
                body["ShippingInstrsCode"] = ExpressionConverter.ConvertO(bodyshippingInstrsCode);
                bodypropCount++;
            }

            if (bodyshippingLocation != null)
            {
                body["ShippingLocation"] = ExpressionConverter.ConvertO(bodyshippingLocation);
                bodypropCount++;
            }

            if (bodyspecialInstrs != null)
            {
                body["SpecialInstrs"] = ExpressionConverter.ConvertO(bodyspecialInstrs);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["State"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodystatusInProcess != null)
            {
                body["StatusInProcess"] = ExpressionConverter.ConvertO(bodystatusInProcess);
                bodypropCount++;
            }

            if (bodystatusInProcessResponse != null)
            {
                body["StatusInProcessResponse"] = ExpressionConverter.ConvertO(bodystatusInProcessResponse);
                bodypropCount++;
            }

            if (bodysupplier != null)
            {
                body["Supplier"] = ExpressionConverter.ConvertO(bodysupplier);
                bodypropCount++;
            }

            if (bodytagsToDropFromXML != null)
            {
                body["TagsToDropFromXML"] = ExpressionConverter.ConvertO(bodytagsToDropFromXML);
                bodypropCount++;
            }

            if (bodytaxExemptNumber != null)
            {
                body["TaxExemptNumber"] = ExpressionConverter.ConvertO(bodytaxExemptNumber);
                bodypropCount++;
            }

            if (bodytaxExemptionStatus != null)
            {
                body["TaxExemptionStatus"] = ExpressionConverter.ConvertO(bodytaxExemptionStatus);
                bodypropCount++;
            }

            if (bodytransactionNature != null)
            {
                body["TransactionNature"] = ExpressionConverter.ConvertO(bodytransactionNature);
                bodypropCount++;
            }

            if (bodytransmissionReference != null)
            {
                body["TransmissionReference"] = ExpressionConverter.ConvertO(bodytransmissionReference);
                bodypropCount++;
            }

            if (bodytransportMode != null)
            {
                body["TransportMode"] = ExpressionConverter.ConvertO(bodytransportMode);
                bodypropCount++;
            }

            if (bodytypeOfOrder != null)
            {
                body["TypeOfOrder"] = ExpressionConverter.ConvertO(bodytypeOfOrder);
                bodypropCount++;
            }

            if (bodyuseCustomerSalesWarehouse != null)
            {
                body["UseCustomerSalesWarehouse"] = ExpressionConverter.ConvertO(bodyuseCustomerSalesWarehouse);
                bodypropCount++;
            }

            if (bodyuseMasterAccountForCustomerPartNo != null)
            {
                body["UseMasterAccountForCustomerPartNo"] = ExpressionConverter.ConvertO(bodyuseMasterAccountForCustomerPartNo);
                bodypropCount++;
            }

            if (bodyuseStockDescSupplied != null)
            {
                body["UseStockDescSupplied"] = ExpressionConverter.ConvertO(bodyuseStockDescSupplied);
                bodypropCount++;
            }

            if (bodyvalidateShippingInstrs != null)
            {
                body["ValidateShippingInstrs"] = ExpressionConverter.ConvertO(bodyvalidateShippingInstrs);
                bodypropCount++;
            }

            if (bodywarehouse != null)
            {
                body["Warehouse"] = ExpressionConverter.ConvertO(bodywarehouse);
                bodypropCount++;
            }

            if (bodywarehouseListToUse != null)
            {
                body["WarehouseListToUse"] = ExpressionConverter.ConvertO(bodywarehouseListToUse);
                bodypropCount++;
            }

            if (bodywarnIfCustomerOnHold != null)
            {
                body["WarnIfCustomerOnHold"] = ExpressionConverter.ConvertO(bodywarnIfCustomerOnHold);
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

    public class bodysalesOrderLineItemInputItem
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

    public class bodysalesOrderLineItemInputItem2
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

    public class bodysalesOrderLineItemInputItem22
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

    public class bodysalesOrderLineItemInputItem222
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

    public class bodysalesOrderLineItemInputItem2222
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

    public class bodysalesOrderLineItemInputItem22222
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

    public class bodysalesOrderDetailsInputItem
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

    public class bodysalesOrderFooterCommentsInputItem
    {
        public string FooterComment { get; set; }
        public string FooterCommentType { get; set; }
        public string FooterLineActionType { get; set; }
    }

    public class bodysalesOrderFreightDetailsInputItem
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

    public class bodysalesOrderHeaderCommentsInputItem
    {
        public string HeaderComment { get; set; }
        public string HeaderCommentType { get; set; }
        public string HeaderLineActionType { get; set; }
    }

    public class bodysalesOrderMiscChargesDetailsInputItem
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