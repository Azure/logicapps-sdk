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
                body["ARDivisionNo"] = CSharpExpressionConverter.ConvertToken(bodyaRDivisionNo);
                bodypropCount++;
            }

            if (bodyaddressLine1 != null)
            {
                body["AddressLine1"] = CSharpExpressionConverter.ConvertToken(bodyaddressLine1);
                bodypropCount++;
            }

            if (bodyaddressLine2 != null)
            {
                body["AddressLine2"] = CSharpExpressionConverter.ConvertToken(bodyaddressLine2);
                bodypropCount++;
            }

            if (bodyaddressLine3 != null)
            {
                body["AddressLine3"] = CSharpExpressionConverter.ConvertToken(bodyaddressLine3);
                bodypropCount++;
            }

            if (bodybatchFax != null)
            {
                body["BatchFax"] = CSharpExpressionConverter.ConvertToken(bodybatchFax);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodycontactCode != null)
            {
                body["ContactCode"] = CSharpExpressionConverter.ConvertToken(bodycontactCode);
                bodypropCount++;
            }

            if (bodycountryCode != null)
            {
                body["CountryCode"] = CSharpExpressionConverter.ConvertToken(bodycountryCode);
                bodypropCount++;
            }

            if (bodycreditHold != null)
            {
                body["CreditHold"] = CSharpExpressionConverter.ConvertToken(bodycreditHold);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["CreditLimit"] = CSharpExpressionConverter.ConvertToken(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycustomerDiscountRate != null)
            {
                body["CustomerDiscountRate"] = CSharpExpressionConverter.ConvertToken(bodycustomerDiscountRate);
                bodypropCount++;
            }

            if (bodycustomerName != null)
            {
                body["CustomerName"] = CSharpExpressionConverter.ConvertToken(bodycustomerName);
                bodypropCount++;
            }

            if (bodycustomerNo != null)
            {
                body["CustomerNo"] = CSharpExpressionConverter.ConvertToken(bodycustomerNo);
                bodypropCount++;
            }

            if (bodycustomerType != null)
            {
                body["CustomerType"] = CSharpExpressionConverter.ConvertToken(bodycustomerType);
                bodypropCount++;
            }

            if (bodydefaultCreditCardPmtType != null)
            {
                body["DefaultCreditCardPmtType"] = CSharpExpressionConverter.ConvertToken(bodydefaultCreditCardPmtType);
                bodypropCount++;
            }

            if (bodydefaultItemCode != null)
            {
                body["DefaultItemCode"] = CSharpExpressionConverter.ConvertToken(bodydefaultItemCode);
                bodypropCount++;
            }

            if (bodydefaultPaymentType != null)
            {
                body["DefaultPaymentType"] = CSharpExpressionConverter.ConvertToken(bodydefaultPaymentType);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyfaxNo != null)
            {
                body["FaxNo"] = CSharpExpressionConverter.ConvertToken(bodyfaxNo);
                bodypropCount++;
            }

            if (bodyopenItemCustomer != null)
            {
                body["OpenItemCustomer"] = CSharpExpressionConverter.ConvertToken(bodyopenItemCustomer);
                bodypropCount++;
            }

            if (bodypriceLevel != null)
            {
                body["PriceLevel"] = CSharpExpressionConverter.ConvertToken(bodypriceLevel);
                bodypropCount++;
            }

            if (bodyprimaryShipToCode != null)
            {
                body["PrimaryShipToCode"] = CSharpExpressionConverter.ConvertToken(bodyprimaryShipToCode);
                bodypropCount++;
            }

            if (bodyprintDunningMessage != null)
            {
                body["PrintDunningMessage"] = CSharpExpressionConverter.ConvertToken(bodyprintDunningMessage);
                bodypropCount++;
            }

            if (bodyresidentialAddress != null)
            {
                body["ResidentialAddress"] = CSharpExpressionConverter.ConvertToken(bodyresidentialAddress);
                bodypropCount++;
            }

            if (bodysalespersonNo != null)
            {
                body["SalespersonNo"] = CSharpExpressionConverter.ConvertToken(bodysalespersonNo);
                bodypropCount++;
            }

            if (bodyshipMethod != null)
            {
                body["ShipMethod"] = CSharpExpressionConverter.ConvertToken(bodyshipMethod);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["State"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodystatementCycle != null)
            {
                body["StatementCycle"] = CSharpExpressionConverter.ConvertToken(bodystatementCycle);
                bodypropCount++;
            }

            if (bodytaxExemptNo != null)
            {
                body["TaxExemptNo"] = CSharpExpressionConverter.ConvertToken(bodytaxExemptNo);
                bodypropCount++;
            }

            if (bodytaxSchedule != null)
            {
                body["TaxSchedule"] = CSharpExpressionConverter.ConvertToken(bodytaxSchedule);
                bodypropCount++;
            }

            if (bodytelephoneExt != null)
            {
                body["TelephoneExt"] = CSharpExpressionConverter.ConvertToken(bodytelephoneExt);
                bodypropCount++;
            }

            if (bodytelephoneNo != null)
            {
                body["TelephoneNo"] = CSharpExpressionConverter.ConvertToken(bodytelephoneNo);
                bodypropCount++;
            }

            if (bodytermsCode != null)
            {
                body["TermsCode"] = CSharpExpressionConverter.ConvertToken(bodytermsCode);
                bodypropCount++;
            }

            if (bodyuRLAddress != null)
            {
                body["URLAddress"] = CSharpExpressionConverter.ConvertToken(bodyuRLAddress);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["ZipCode"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
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
                body["ARDivisionNo"] = CSharpExpressionConverter.ConvertToken(bodyaRDivisionNo);
                bodypropCount++;
            }

            if (bodybatchFax != null)
            {
                body["BatchFax"] = CSharpExpressionConverter.ConvertToken(bodybatchFax);
                bodypropCount++;
            }

            if (bodybillToAddress1 != null)
            {
                body["BillToAddress1"] = CSharpExpressionConverter.ConvertToken(bodybillToAddress1);
                bodypropCount++;
            }

            if (bodybillToAddress2 != null)
            {
                body["BillToAddress2"] = CSharpExpressionConverter.ConvertToken(bodybillToAddress2);
                bodypropCount++;
            }

            if (bodybillToAddress3 != null)
            {
                body["BillToAddress3"] = CSharpExpressionConverter.ConvertToken(bodybillToAddress3);
                bodypropCount++;
            }

            if (bodybillToCity != null)
            {
                body["BillToCity"] = CSharpExpressionConverter.ConvertToken(bodybillToCity);
                bodypropCount++;
            }

            if (bodybillToCountryCode != null)
            {
                body["BillToCountryCode"] = CSharpExpressionConverter.ConvertToken(bodybillToCountryCode);
                bodypropCount++;
            }

            if (bodybillToName != null)
            {
                body["BillToName"] = CSharpExpressionConverter.ConvertToken(bodybillToName);
                bodypropCount++;
            }

            if (bodybillToState != null)
            {
                body["BillToState"] = CSharpExpressionConverter.ConvertToken(bodybillToState);
                bodypropCount++;
            }

            if (bodybillToZipCode != null)
            {
                body["BillToZipCode"] = CSharpExpressionConverter.ConvertToken(bodybillToZipCode);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["Comment"] = CSharpExpressionConverter.ConvertToken(bodycomment);
                bodypropCount++;
            }

            if (bodyconfirmTo != null)
            {
                body["ConfirmTo"] = CSharpExpressionConverter.ConvertToken(bodyconfirmTo);
                bodypropCount++;
            }

            if (bodycustomerNo != null)
            {
                body["CustomerNo"] = CSharpExpressionConverter.ConvertToken(bodycustomerNo);
                bodypropCount++;
            }

            if (bodycustomerPONo != null)
            {
                body["CustomerPONo"] = CSharpExpressionConverter.ConvertToken(bodycustomerPONo);
                bodypropCount++;
            }

            if (bodycycleCode != null)
            {
                body["CycleCode"] = CSharpExpressionConverter.ConvertToken(bodycycleCode);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyfOB != null)
            {
                body["FOB"] = CSharpExpressionConverter.ConvertToken(bodyfOB);
                bodypropCount++;
            }

            if (bodyfaxNo != null)
            {
                body["FaxNo"] = CSharpExpressionConverter.ConvertToken(bodyfaxNo);
                bodypropCount++;
            }

            if (bodymasterRepeatingOrderNo != null)
            {
                body["MasterRepeatingOrderNo"] = CSharpExpressionConverter.ConvertToken(bodymasterRepeatingOrderNo);
                bodypropCount++;
            }

            if (bodynumberOfShippingLabels != null)
            {
                body["NumberOfShippingLabels"] = CSharpExpressionConverter.ConvertToken(bodynumberOfShippingLabels);
                bodypropCount++;
            }

            if (bodyorderDate != null)
            {
                body["OrderDate"] = CSharpExpressionConverter.ConvertToken(bodyorderDate);
                bodypropCount++;
            }

            if (bodyorderStatus != null)
            {
                body["OrderStatus"] = CSharpExpressionConverter.ConvertToken(bodyorderStatus);
                bodypropCount++;
            }

            if (bodyorderType != null)
            {
                body["OrderType"] = CSharpExpressionConverter.ConvertToken(bodyorderType);
                bodypropCount++;
            }

            if (bodyprintPickingSheets != null)
            {
                body["PrintPickingSheets"] = CSharpExpressionConverter.ConvertToken(bodyprintPickingSheets);
                bodypropCount++;
            }

            if (bodyprintSalesOrders != null)
            {
                body["PrintSalesOrders"] = CSharpExpressionConverter.ConvertToken(bodyprintSalesOrders);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodysalesOrderNo != null)
            {
                body["SalesOrderNo"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderNo);
                bodypropCount++;
            }

            if (bodysalespersonNo != null)
            {
                body["SalespersonNo"] = CSharpExpressionConverter.ConvertToken(bodysalespersonNo);
                bodypropCount++;
            }

            if (bodyshipExpireDate != null)
            {
                body["ShipExpireDate"] = CSharpExpressionConverter.ConvertToken(bodyshipExpireDate);
                bodypropCount++;
            }

            if (bodyshipToAddress1 != null)
            {
                body["ShipToAddress1"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddress1);
                bodypropCount++;
            }

            if (bodyshipToAddress2 != null)
            {
                body["ShipToAddress2"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddress2);
                bodypropCount++;
            }

            if (bodyshipToAddress3 != null)
            {
                body["ShipToAddress3"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddress3);
                bodypropCount++;
            }

            if (bodyshipToCity != null)
            {
                body["ShipToCity"] = CSharpExpressionConverter.ConvertToken(bodyshipToCity);
                bodypropCount++;
            }

            if (bodyshipToCode != null)
            {
                body["ShipToCode"] = CSharpExpressionConverter.ConvertToken(bodyshipToCode);
                bodypropCount++;
            }

            if (bodyshipToCountryCode != null)
            {
                body["ShipToCountryCode"] = CSharpExpressionConverter.ConvertToken(bodyshipToCountryCode);
                bodypropCount++;
            }

            if (bodyshipToName != null)
            {
                body["ShipToName"] = CSharpExpressionConverter.ConvertToken(bodyshipToName);
                bodypropCount++;
            }

            if (bodyshipToState != null)
            {
                body["ShipToState"] = CSharpExpressionConverter.ConvertToken(bodyshipToState);
                bodypropCount++;
            }

            if (bodyshipToZipCode != null)
            {
                body["ShipToZipCode"] = CSharpExpressionConverter.ConvertToken(bodyshipToZipCode);
                bodypropCount++;
            }

            if (bodyshipVia != null)
            {
                body["ShipVia"] = CSharpExpressionConverter.ConvertToken(bodyshipVia);
                bodypropCount++;
            }

            if (bodyshipWeight != null)
            {
                body["ShipWeight"] = CSharpExpressionConverter.ConvertToken(bodyshipWeight);
                bodypropCount++;
            }

            if (bodyshipZoneActual != null)
            {
                body["ShipZoneActual"] = CSharpExpressionConverter.ConvertToken(bodyshipZoneActual);
                bodypropCount++;
            }

            if (bodysplitCommissions != null)
            {
                body["SplitCommissions"] = CSharpExpressionConverter.ConvertToken(bodysplitCommissions);
                bodypropCount++;
            }

            if (bodytaxExemptNo != null)
            {
                body["TaxExemptNo"] = CSharpExpressionConverter.ConvertToken(bodytaxExemptNo);
                bodypropCount++;
            }

            if (bodytaxSchedule != null)
            {
                body["TaxSchedule"] = CSharpExpressionConverter.ConvertToken(bodytaxSchedule);
                bodypropCount++;
            }

            if (bodytermsCode != null)
            {
                body["TermsCode"] = CSharpExpressionConverter.ConvertToken(bodytermsCode);
                bodypropCount++;
            }

            if (bodywarehouseCode != null)
            {
                body["WarehouseCode"] = CSharpExpressionConverter.ConvertToken(bodywarehouseCode);
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
                body["BillingCity"] = CSharpExpressionConverter.ConvertToken(bodybillingCity);
                bodypropCount++;
            }

            if (bodybillingCounty != null)
            {
                body["BillingCounty"] = CSharpExpressionConverter.ConvertToken(bodybillingCounty);
                bodypropCount++;
            }

            if (bodybillingPostalCode != null)
            {
                body["BillingPostalCode"] = CSharpExpressionConverter.ConvertToken(bodybillingPostalCode);
                bodypropCount++;
            }

            if (bodybillingState != null)
            {
                body["BillingState"] = CSharpExpressionConverter.ConvertToken(bodybillingState);
                bodypropCount++;
            }

            if (bodybillingStreet != null)
            {
                body["BillingStreet"] = CSharpExpressionConverter.ConvertToken(bodybillingStreet);
                bodypropCount++;
            }

            if (bodygUID != null)
            {
                body["GUID"] = CSharpExpressionConverter.ConvertToken(bodygUID);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyshippingCity != null)
            {
                body["ShippingCity"] = CSharpExpressionConverter.ConvertToken(bodyshippingCity);
                bodypropCount++;
            }

            if (bodyshippingCountry != null)
            {
                body["ShippingCountry"] = CSharpExpressionConverter.ConvertToken(bodyshippingCountry);
                bodypropCount++;
            }

            if (bodyshippingPostalCode != null)
            {
                body["ShippingPostalCode"] = CSharpExpressionConverter.ConvertToken(bodyshippingPostalCode);
                bodypropCount++;
            }

            if (bodyshippingState != null)
            {
                body["ShippingState"] = CSharpExpressionConverter.ConvertToken(bodyshippingState);
                bodypropCount++;
            }

            if (bodyshippingStreet != null)
            {
                body["ShippingStreet"] = CSharpExpressionConverter.ConvertToken(bodyshippingStreet);
                bodypropCount++;
            }

            if (bodyacnm != null)
            {
                body["acnm"] = CSharpExpressionConverter.ConvertToken(bodyacnm);
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
                body["StockCode"] = CSharpExpressionConverter.ConvertToken(bodystockCode);
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
                body["OrderHeaderGUID"] = CSharpExpressionConverter.ConvertToken(bodyorderHeaderGUID);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderLineItem);
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
                body["AccountNumber"] = CSharpExpressionConverter.ConvertToken(bodyaccountNumber);
                bodypropCount++;
            }

            if (bodyaltContact != null)
            {
                body["AltContact"] = CSharpExpressionConverter.ConvertToken(bodyaltContact);
                bodypropCount++;
            }

            if (bodyaltPhone != null)
            {
                body["AltPhone"] = CSharpExpressionConverter.ConvertToken(bodyaltPhone);
                bodypropCount++;
            }

            if (bodybillAddressAddr1 != null)
            {
                body["BillAddressAddr1"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr1);
                bodypropCount++;
            }

            if (bodybillAddressAddr2 != null)
            {
                body["BillAddressAddr2"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr2);
                bodypropCount++;
            }

            if (bodybillAddressAddr3 != null)
            {
                body["BillAddressAddr3"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr3);
                bodypropCount++;
            }

            if (bodybillAddressAddr4 != null)
            {
                body["BillAddressAddr4"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr4);
                bodypropCount++;
            }

            if (bodybillAddressAddr5 != null)
            {
                body["BillAddressAddr5"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr5);
                bodypropCount++;
            }

            if (bodybillAddressCity != null)
            {
                body["BillAddressCity"] = CSharpExpressionConverter.ConvertToken(bodybillAddressCity);
                bodypropCount++;
            }

            if (bodybillAddressCountry != null)
            {
                body["BillAddressCountry"] = CSharpExpressionConverter.ConvertToken(bodybillAddressCountry);
                bodypropCount++;
            }

            if (bodybillAddressNote != null)
            {
                body["BillAddressNote"] = CSharpExpressionConverter.ConvertToken(bodybillAddressNote);
                bodypropCount++;
            }

            if (bodybillAddressPostalCode != null)
            {
                body["BillAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(bodybillAddressPostalCode);
                bodypropCount++;
            }

            if (bodybillAddressState != null)
            {
                body["BillAddressState"] = CSharpExpressionConverter.ConvertToken(bodybillAddressState);
                bodypropCount++;
            }

            if (bodycc != null)
            {
                body["Cc"] = CSharpExpressionConverter.ConvertToken(bodycc);
                bodypropCount++;
            }

            if (bodyclassRef != null)
            {
                body["ClassRef"] = CSharpExpressionConverter.ConvertToken(bodyclassRef);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = CSharpExpressionConverter.ConvertToken(bodycompanyName);
                bodypropCount++;
            }

            if (bodycontact != null)
            {
                body["Contact"] = CSharpExpressionConverter.ConvertToken(bodycontact);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["CreditLimit"] = CSharpExpressionConverter.ConvertToken(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycustomerTypeRef != null)
            {
                body["CustomerTypeRef"] = CSharpExpressionConverter.ConvertToken(bodycustomerTypeRef);
                bodypropCount++;
            }

            if (bodyeditSequence != null)
            {
                body["EditSequence"] = CSharpExpressionConverter.ConvertToken(bodyeditSequence);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = CSharpExpressionConverter.ConvertToken(bodyextraField);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["Fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["FirstName"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodyisActive != null)
            {
                body["IsActive"] = CSharpExpressionConverter.ConvertToken(bodyisActive);
                bodypropCount++;
            }

            if (bodyitemSalesTaxRef != null)
            {
                body["ItemSalesTaxRef"] = CSharpExpressionConverter.ConvertToken(bodyitemSalesTaxRef);
                bodypropCount++;
            }

            if (bodyjobTitle != null)
            {
                body["JobTitle"] = CSharpExpressionConverter.ConvertToken(bodyjobTitle);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["LastName"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodylistID != null)
            {
                body["ListID"] = CSharpExpressionConverter.ConvertToken(bodylistID);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["MiddleName"] = CSharpExpressionConverter.ConvertToken(bodymiddleName);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["Notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodyopenBalance != null)
            {
                body["OpenBalance"] = CSharpExpressionConverter.ConvertToken(bodyopenBalance);
                bodypropCount++;
            }

            if (bodyopenBalanceDate != null)
            {
                body["OpenBalanceDate"] = CSharpExpressionConverter.ConvertToken(bodyopenBalanceDate);
                bodypropCount++;
            }

            if (bodyparentRef != null)
            {
                body["ParentRef"] = CSharpExpressionConverter.ConvertToken(bodyparentRef);
                bodypropCount++;
            }

            if (bodyphone != null)
            {
                body["Phone"] = CSharpExpressionConverter.ConvertToken(bodyphone);
                bodypropCount++;
            }

            if (bodypreferredPaymentMethodRef != null)
            {
                body["PreferredPaymentMethodRef"] = CSharpExpressionConverter.ConvertToken(bodypreferredPaymentMethodRef);
                bodypropCount++;
            }

            if (bodypriceLevelRef != null)
            {
                body["PriceLevelRef"] = CSharpExpressionConverter.ConvertToken(bodypriceLevelRef);
                bodypropCount++;
            }

            if (bodyresaleNumber != null)
            {
                body["ResaleNumber"] = CSharpExpressionConverter.ConvertToken(bodyresaleNumber);
                bodypropCount++;
            }

            if (bodysalesRepRef != null)
            {
                body["SalesRepRef"] = CSharpExpressionConverter.ConvertToken(bodysalesRepRef);
                bodypropCount++;
            }

            if (bodysalesTaxCodeRef != null)
            {
                body["SalesTaxCodeRef"] = CSharpExpressionConverter.ConvertToken(bodysalesTaxCodeRef);
                bodypropCount++;
            }

            if (bodysalutation != null)
            {
                body["Salutation"] = CSharpExpressionConverter.ConvertToken(bodysalutation);
                bodypropCount++;
            }

            if (bodyshipAddressAddr1 != null)
            {
                body["ShipAddressAddr1"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr1);
                bodypropCount++;
            }

            if (bodyshipAddressAddr2 != null)
            {
                body["ShipAddressAddr2"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr2);
                bodypropCount++;
            }

            if (bodyshipAddressAddr3 != null)
            {
                body["ShipAddressAddr3"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr3);
                bodypropCount++;
            }

            if (bodyshipAddressAddr4 != null)
            {
                body["ShipAddressAddr4"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr4);
                bodypropCount++;
            }

            if (bodyshipAddressAddr5 != null)
            {
                body["ShipAddressAddr5"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr5);
                bodypropCount++;
            }

            if (bodyshipAddressCity != null)
            {
                body["ShipAddressCity"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressCity);
                bodypropCount++;
            }

            if (bodyshipAddressCountry != null)
            {
                body["ShipAddressCountry"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressCountry);
                bodypropCount++;
            }

            if (bodyshipAddressNote != null)
            {
                body["ShipAddressNote"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressNote);
                bodypropCount++;
            }

            if (bodyshipAddressPostalCode != null)
            {
                body["ShipAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressPostalCode);
                bodypropCount++;
            }

            if (bodyshipAddressState != null)
            {
                body["ShipAddressState"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressState);
                bodypropCount++;
            }

            if (bodytermsRef != null)
            {
                body["TermsRef"] = CSharpExpressionConverter.ConvertToken(bodytermsRef);
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
                body["BillAddressAddr1"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr1);
                bodypropCount++;
            }

            if (bodybillAddressAddr2 != null)
            {
                body["BillAddressAddr2"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr2);
                bodypropCount++;
            }

            if (bodybillAddressAddr3 != null)
            {
                body["BillAddressAddr3"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr3);
                bodypropCount++;
            }

            if (bodybillAddressAddr4 != null)
            {
                body["BillAddressAddr4"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr4);
                bodypropCount++;
            }

            if (bodybillAddressAddr5 != null)
            {
                body["BillAddressAddr5"] = CSharpExpressionConverter.ConvertToken(bodybillAddressAddr5);
                bodypropCount++;
            }

            if (bodybillAddressCity != null)
            {
                body["BillAddressCity"] = CSharpExpressionConverter.ConvertToken(bodybillAddressCity);
                bodypropCount++;
            }

            if (bodybillAddressCountry != null)
            {
                body["BillAddressCountry"] = CSharpExpressionConverter.ConvertToken(bodybillAddressCountry);
                bodypropCount++;
            }

            if (bodybillAddressNote != null)
            {
                body["BillAddressNote"] = CSharpExpressionConverter.ConvertToken(bodybillAddressNote);
                bodypropCount++;
            }

            if (bodybillAddressPostalCode != null)
            {
                body["BillAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(bodybillAddressPostalCode);
                bodypropCount++;
            }

            if (bodybillAddressState != null)
            {
                body["BillAddressState"] = CSharpExpressionConverter.ConvertToken(bodybillAddressState);
                bodypropCount++;
            }

            if (bodyclassRef != null)
            {
                body["ClassRef"] = CSharpExpressionConverter.ConvertToken(bodyclassRef);
                bodypropCount++;
            }

            if (bodycustomerRefListID != null)
            {
                body["CustomerRefListID"] = CSharpExpressionConverter.ConvertToken(bodycustomerRefListID);
                bodypropCount++;
            }

            if (bodycustomerRefName != null)
            {
                body["CustomerRefName"] = CSharpExpressionConverter.ConvertToken(bodycustomerRefName);
                bodypropCount++;
            }

            if (bodycustomerSalesTaxCodeRef != null)
            {
                body["CustomerSalesTaxCodeRef"] = CSharpExpressionConverter.ConvertToken(bodycustomerSalesTaxCodeRef);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["DueDate"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
            }

            if (bodyeditSequence != null)
            {
                body["EditSequence"] = CSharpExpressionConverter.ConvertToken(bodyeditSequence);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = CSharpExpressionConverter.ConvertToken(bodyextraField);
                bodypropCount++;
            }

            if (bodyitemSalesTaxRef != null)
            {
                body["ItemSalesTaxRef"] = CSharpExpressionConverter.ConvertToken(bodyitemSalesTaxRef);
                bodypropCount++;
            }

            if (bodylistID != null)
            {
                body["ListID"] = CSharpExpressionConverter.ConvertToken(bodylistID);
                bodypropCount++;
            }

            if (bodymemo != null)
            {
                body["Memo"] = CSharpExpressionConverter.ConvertToken(bodymemo);
                bodypropCount++;
            }

            if (bodypONumber != null)
            {
                body["PONumber"] = CSharpExpressionConverter.ConvertToken(bodypONumber);
                bodypropCount++;
            }

            if (bodyrefNumber != null)
            {
                body["RefNumber"] = CSharpExpressionConverter.ConvertToken(bodyrefNumber);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodysalesRepRef != null)
            {
                body["SalesRepRef"] = CSharpExpressionConverter.ConvertToken(bodysalesRepRef);
                bodypropCount++;
            }

            if (bodyshipAddressAddr1 != null)
            {
                body["ShipAddressAddr1"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr1);
                bodypropCount++;
            }

            if (bodyshipAddressAddr2 != null)
            {
                body["ShipAddressAddr2"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr2);
                bodypropCount++;
            }

            if (bodyshipAddressAddr3 != null)
            {
                body["ShipAddressAddr3"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr3);
                bodypropCount++;
            }

            if (bodyshipAddressAddr4 != null)
            {
                body["ShipAddressAddr4"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr4);
                bodypropCount++;
            }

            if (bodyshipAddressAddr5 != null)
            {
                body["ShipAddressAddr5"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressAddr5);
                bodypropCount++;
            }

            if (bodyshipAddressCity != null)
            {
                body["ShipAddressCity"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressCity);
                bodypropCount++;
            }

            if (bodyshipAddressCountry != null)
            {
                body["ShipAddressCountry"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressCountry);
                bodypropCount++;
            }

            if (bodyshipAddressNote != null)
            {
                body["ShipAddressNote"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressNote);
                bodypropCount++;
            }

            if (bodyshipAddressPostalCode != null)
            {
                body["ShipAddressPostalCode"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressPostalCode);
                bodypropCount++;
            }

            if (bodyshipAddressState != null)
            {
                body["ShipAddressState"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressState);
                bodypropCount++;
            }

            if (bodytemplateRef != null)
            {
                body["TemplateRef"] = CSharpExpressionConverter.ConvertToken(bodytemplateRef);
                bodypropCount++;
            }

            if (bodytermsRef != null)
            {
                body["TermsRef"] = CSharpExpressionConverter.ConvertToken(bodytermsRef);
                bodypropCount++;
            }

            if (bodytxnDate != null)
            {
                body["TxnDate"] = CSharpExpressionConverter.ConvertToken(bodytxnDate);
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
                body["ACCOUNT_OPENED"] = CSharpExpressionConverter.ConvertToken(bodyaCCOUNTOPENED);
                bodypropCount++;
            }

            if (bodyaCCOUNTREF != null)
            {
                body["ACCOUNT_REF"] = CSharpExpressionConverter.ConvertToken(bodyaCCOUNTREF);
                bodypropCount++;
            }

            if (bodyaCCOUNTSTATUS != null)
            {
                body["ACCOUNT_STATUS"] = CSharpExpressionConverter.ConvertToken(bodyaCCOUNTSTATUS);
                bodypropCount++;
            }

            if (bodyaDDRESS1 != null)
            {
                body["ADDRESS_1"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS1);
                bodypropCount++;
            }

            if (bodyaDDRESS2 != null)
            {
                body["ADDRESS_2"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS2);
                bodypropCount++;
            }

            if (bodyaDDRESS3 != null)
            {
                body["ADDRESS_3"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS3);
                bodypropCount++;
            }

            if (bodyaDDRESS4 != null)
            {
                body["ADDRESS_4"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS4);
                bodypropCount++;
            }

            if (bodyaDDRESS5 != null)
            {
                body["ADDRESS_5"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS5);
                bodypropCount++;
            }

            if (bodyaNALYSIS1 != null)
            {
                body["ANALYSIS_1"] = CSharpExpressionConverter.ConvertToken(bodyaNALYSIS1);
                bodypropCount++;
            }

            if (bodyaNALYSIS2 != null)
            {
                body["ANALYSIS_2"] = CSharpExpressionConverter.ConvertToken(bodyaNALYSIS2);
                bodypropCount++;
            }

            if (bodyaNALYSIS3 != null)
            {
                body["ANALYSIS_3"] = CSharpExpressionConverter.ConvertToken(bodyaNALYSIS3);
                bodypropCount++;
            }

            if (bodyaVERAGEPAYDAYS != null)
            {
                body["AVERAGE_PAY_DAYS"] = CSharpExpressionConverter.ConvertToken(bodyaVERAGEPAYDAYS);
                bodypropCount++;
            }

            if (bodybALANCE != null)
            {
                body["BALANCE"] = CSharpExpressionConverter.ConvertToken(bodybALANCE);
                bodypropCount++;
            }

            if (bodycANAPPLYCHARGES != null)
            {
                body["CAN_APPLY_CHARGES"] = CSharpExpressionConverter.ConvertToken(bodycANAPPLYCHARGES);
                bodypropCount++;
            }

            if (bodycONTACTNAME != null)
            {
                body["CONTACT_NAME"] = CSharpExpressionConverter.ConvertToken(bodycONTACTNAME);
                bodypropCount++;
            }

            if (bodycOUNTRYCODE != null)
            {
                body["COUNTRY_CODE"] = CSharpExpressionConverter.ConvertToken(bodycOUNTRYCODE);
                bodypropCount++;
            }

            if (bodycREDITAPPLIEDFOR != null)
            {
                body["CREDIT_APPLIED_FOR"] = CSharpExpressionConverter.ConvertToken(bodycREDITAPPLIEDFOR);
                bodypropCount++;
            }

            if (bodycREDITBUREAU != null)
            {
                body["CREDIT_BUREAU"] = CSharpExpressionConverter.ConvertToken(bodycREDITBUREAU);
                bodypropCount++;
            }

            if (bodycREDITLIMIT != null)
            {
                body["CREDIT_LIMIT"] = CSharpExpressionConverter.ConvertToken(bodycREDITLIMIT);
                bodypropCount++;
            }

            if (bodycREDITPOSITION != null)
            {
                body["CREDIT_POSITION"] = CSharpExpressionConverter.ConvertToken(bodycREDITPOSITION);
                bodypropCount++;
            }

            if (bodycREDITREFERENCE != null)
            {
                body["CREDIT_REFERENCE"] = CSharpExpressionConverter.ConvertToken(bodycREDITREFERENCE);
                bodypropCount++;
            }

            if (bodycURRENCY != null)
            {
                body["CURRENCY"] = CSharpExpressionConverter.ConvertToken(bodycURRENCY);
                bodypropCount++;
            }

            if (bodydATECREDITAPPRECEIVED != null)
            {
                body["DATE_CREDIT_APP_RECEIVED"] = CSharpExpressionConverter.ConvertToken(bodydATECREDITAPPRECEIVED);
                bodypropCount++;
            }

            if (bodydEFNOMCODE != null)
            {
                body["DEF_NOM_CODE"] = CSharpExpressionConverter.ConvertToken(bodydEFNOMCODE);
                bodypropCount++;
            }

            if (bodydEFTAXCODE != null)
            {
                body["DEF_TAX_CODE"] = CSharpExpressionConverter.ConvertToken(bodydEFTAXCODE);
                bodypropCount++;
            }

            if (bodydEPTNUMBER != null)
            {
                body["DEPT_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodydEPTNUMBER);
                bodypropCount++;
            }

            if (bodydISCOUNTRATE != null)
            {
                body["DISCOUNT_RATE"] = CSharpExpressionConverter.ConvertToken(bodydISCOUNTRATE);
                bodypropCount++;
            }

            if (bodydISCOUNTTYPE != null)
            {
                body["DISCOUNT_TYPE"] = CSharpExpressionConverter.ConvertToken(bodydISCOUNTTYPE);
                bodypropCount++;
            }

            if (bodydUNSNUMBER != null)
            {
                body["DUNS_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodydUNSNUMBER);
                bodypropCount++;
            }

            if (bodyeMAIL != null)
            {
                body["E_MAIL"] = CSharpExpressionConverter.ConvertToken(bodyeMAIL);
                bodypropCount++;
            }

            if (bodyeMAIL2 != null)
            {
                body["E_MAIL2"] = CSharpExpressionConverter.ConvertToken(bodyeMAIL2);
                bodypropCount++;
            }

            if (bodyeMAIL3 != null)
            {
                body["E_MAIL3"] = CSharpExpressionConverter.ConvertToken(bodyeMAIL3);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = CSharpExpressionConverter.ConvertToken(bodyextraField);
                bodypropCount++;
            }

            if (bodyfAX != null)
            {
                body["FAX"] = CSharpExpressionConverter.ConvertToken(bodyfAX);
                bodypropCount++;
            }

            if (bodyhOLDMAIL != null)
            {
                body["HOLD_MAIL"] = CSharpExpressionConverter.ConvertToken(bodyhOLDMAIL);
                bodypropCount++;
            }

            if (bodyiNACTIVEFLAG != null)
            {
                body["INACTIVE_FLAG"] = CSharpExpressionConverter.ConvertToken(bodyiNACTIVEFLAG);
                bodypropCount++;
            }

            if (bodyisACCOUNTREFAutogenerate != null)
            {
                body["IsACCOUNT_REF_autogenerate"] = CSharpExpressionConverter.ConvertToken(bodyisACCOUNTREFAutogenerate);
                bodypropCount++;
            }

            if (bodylASTCREDITREV != null)
            {
                body["LAST_CREDIT_REV"] = CSharpExpressionConverter.ConvertToken(bodylASTCREDITREV);
                bodypropCount++;
            }

            if (bodynAME != null)
            {
                body["NAME"] = CSharpExpressionConverter.ConvertToken(bodynAME);
                bodypropCount++;
            }

            if (bodynEXTCREDITREV != null)
            {
                body["NEXT_CREDIT_REV"] = CSharpExpressionConverter.ConvertToken(bodynEXTCREDITREV);
                bodypropCount++;
            }

            if (bodyoVERRIDEPRODUCTNOMINAL != null)
            {
                body["OVERRIDE_PRODUCT_NOMINAL"] = CSharpExpressionConverter.ConvertToken(bodyoVERRIDEPRODUCTNOMINAL);
                bodypropCount++;
            }

            if (bodyoVERRIDEPRODUCTTAX != null)
            {
                body["OVERRIDE_PRODUCT_TAX"] = CSharpExpressionConverter.ConvertToken(bodyoVERRIDEPRODUCTTAX);
                bodypropCount++;
            }

            if (bodypAYMENTDUEDAYS != null)
            {
                body["PAYMENT_DUE_DAYS"] = CSharpExpressionConverter.ConvertToken(bodypAYMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodypRICELISTREF != null)
            {
                body["PRICE_LIST_REF"] = CSharpExpressionConverter.ConvertToken(bodypRICELISTREF);
                bodypropCount++;
            }

            if (bodypRIORITYTRADER != null)
            {
                body["PRIORITY_TRADER"] = CSharpExpressionConverter.ConvertToken(bodypRIORITYTRADER);
                bodypropCount++;
            }

            if (bodysENDINVOICESELECTRONICALLY != null)
            {
                body["SEND_INVOICES_ELECTRONICALLY"] = CSharpExpressionConverter.ConvertToken(bodysENDINVOICESELECTRONICALLY);
                bodypropCount++;
            }

            if (bodysENDLETTERSELECTRONICALLY != null)
            {
                body["SEND_LETTERS_ELECTRONICALLY"] = CSharpExpressionConverter.ConvertToken(bodysENDLETTERSELECTRONICALLY);
                bodypropCount++;
            }

            if (bodysETTLEMENTDISCRATE != null)
            {
                body["SETTLEMENT_DISC_RATE"] = CSharpExpressionConverter.ConvertToken(bodysETTLEMENTDISCRATE);
                bodypropCount++;
            }

            if (bodysETTLEMENTDUEDAYS != null)
            {
                body["SETTLEMENT_DUE_DAYS"] = CSharpExpressionConverter.ConvertToken(bodysETTLEMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodytELEPHONE != null)
            {
                body["TELEPHONE"] = CSharpExpressionConverter.ConvertToken(bodytELEPHONE);
                bodypropCount++;
            }

            if (bodytELEPHONE2 != null)
            {
                body["TELEPHONE_2"] = CSharpExpressionConverter.ConvertToken(bodytELEPHONE2);
                bodypropCount++;
            }

            if (bodytERMS != null)
            {
                body["TERMS"] = CSharpExpressionConverter.ConvertToken(bodytERMS);
                bodypropCount++;
            }

            if (bodytERMSAGREEDFLAG != null)
            {
                body["TERMS_AGREED_FLAG"] = CSharpExpressionConverter.ConvertToken(bodytERMSAGREEDFLAG);
                bodypropCount++;
            }

            if (bodytRADECONTACT != null)
            {
                body["TRADE_CONTACT"] = CSharpExpressionConverter.ConvertToken(bodytRADECONTACT);
                bodypropCount++;
            }

            if (bodyvATREGNUMBER != null)
            {
                body["VAT_REG_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyvATREGNUMBER);
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
                body["ACCOUNT_REF"] = CSharpExpressionConverter.ConvertToken(bodyaCCOUNTREF);
                bodypropCount++;
            }

            if (bodyaDDRESS1 != null)
            {
                body["ADDRESS_1"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS1);
                bodypropCount++;
            }

            if (bodyaDDRESS2 != null)
            {
                body["ADDRESS_2"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS2);
                bodypropCount++;
            }

            if (bodyaDDRESS3 != null)
            {
                body["ADDRESS_3"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS3);
                bodypropCount++;
            }

            if (bodyaDDRESS4 != null)
            {
                body["ADDRESS_4"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS4);
                bodypropCount++;
            }

            if (bodyaDDRESS5 != null)
            {
                body["ADDRESS_5"] = CSharpExpressionConverter.ConvertToken(bodyaDDRESS5);
                bodypropCount++;
            }

            if (bodyaMOUNTPREPAID != null)
            {
                body["AMOUNT_PREPAID"] = CSharpExpressionConverter.ConvertToken(bodyaMOUNTPREPAID);
                bodypropCount++;
            }

            if (bodyaNALYSIS1 != null)
            {
                body["ANALYSIS_1"] = CSharpExpressionConverter.ConvertToken(bodyaNALYSIS1);
                bodypropCount++;
            }

            if (bodyaNALYSIS2 != null)
            {
                body["ANALYSIS_2"] = CSharpExpressionConverter.ConvertToken(bodyaNALYSIS2);
                bodypropCount++;
            }

            if (bodyaNALYSIS3 != null)
            {
                body["ANALYSIS_3"] = CSharpExpressionConverter.ConvertToken(bodyaNALYSIS3);
                bodypropCount++;
            }

            if (bodycARRDEPTNUMBER != null)
            {
                body["CARR_DEPT_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodycARRDEPTNUMBER);
                bodypropCount++;
            }

            if (bodycARRNET != null)
            {
                body["CARR_NET"] = CSharpExpressionConverter.ConvertToken(bodycARRNET);
                bodypropCount++;
            }

            if (bodycARRNOMCODE != null)
            {
                body["CARR_NOM_CODE"] = CSharpExpressionConverter.ConvertToken(bodycARRNOMCODE);
                bodypropCount++;
            }

            if (bodycARRTAX != null)
            {
                body["CARR_TAX"] = CSharpExpressionConverter.ConvertToken(bodycARRTAX);
                bodypropCount++;
            }

            if (bodycARRTAXCODE != null)
            {
                body["CARR_TAX_CODE"] = CSharpExpressionConverter.ConvertToken(bodycARRTAXCODE);
                bodypropCount++;
            }

            if (bodycONSIGNMENTREF != null)
            {
                body["CONSIGNMENT_REF"] = CSharpExpressionConverter.ConvertToken(bodycONSIGNMENTREF);
                bodypropCount++;
            }

            if (bodycONTACTNAME != null)
            {
                body["CONTACT_NAME"] = CSharpExpressionConverter.ConvertToken(bodycONTACTNAME);
                bodypropCount++;
            }

            if (bodycOURIER != null)
            {
                body["COURIER"] = CSharpExpressionConverter.ConvertToken(bodycOURIER);
                bodypropCount++;
            }

            if (bodycURRENCY != null)
            {
                body["CURRENCY"] = CSharpExpressionConverter.ConvertToken(bodycURRENCY);
                bodypropCount++;
            }

            if (bodycUSTDISCRATE != null)
            {
                body["CUST_DISC_RATE"] = CSharpExpressionConverter.ConvertToken(bodycUSTDISCRATE);
                bodypropCount++;
            }

            if (bodycUSTORDERNUMBER != null)
            {
                body["CUST_ORDER_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodycUSTORDERNUMBER);
                bodypropCount++;
            }

            if (bodycUSTTELNUMBER != null)
            {
                body["CUST_TEL_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodycUSTTELNUMBER);
                bodypropCount++;
            }

            if (bodydEFTAXCODE != null)
            {
                body["DEF_TAX_CODE"] = CSharpExpressionConverter.ConvertToken(bodydEFTAXCODE);
                bodypropCount++;
            }

            if (bodydELETEDFLAG != null)
            {
                body["DELETED_FLAG"] = CSharpExpressionConverter.ConvertToken(bodydELETEDFLAG);
                bodypropCount++;
            }

            if (bodydELIVERYNAME != null)
            {
                body["DELIVERY_NAME"] = CSharpExpressionConverter.ConvertToken(bodydELIVERYNAME);
                bodypropCount++;
            }

            if (bodydELADDRESS1 != null)
            {
                body["DEL_ADDRESS_1"] = CSharpExpressionConverter.ConvertToken(bodydELADDRESS1);
                bodypropCount++;
            }

            if (bodydELADDRESS2 != null)
            {
                body["DEL_ADDRESS_2"] = CSharpExpressionConverter.ConvertToken(bodydELADDRESS2);
                bodypropCount++;
            }

            if (bodydELADDRESS3 != null)
            {
                body["DEL_ADDRESS_3"] = CSharpExpressionConverter.ConvertToken(bodydELADDRESS3);
                bodypropCount++;
            }

            if (bodydELADDRESS4 != null)
            {
                body["DEL_ADDRESS_4"] = CSharpExpressionConverter.ConvertToken(bodydELADDRESS4);
                bodypropCount++;
            }

            if (bodydELADDRESS5 != null)
            {
                body["DEL_ADDRESS_5"] = CSharpExpressionConverter.ConvertToken(bodydELADDRESS5);
                bodypropCount++;
            }

            if (bodydESPATCHDATE != null)
            {
                body["DESPATCH_DATE"] = CSharpExpressionConverter.ConvertToken(bodydESPATCHDATE);
                bodypropCount++;
            }

            if (bodydUNSNUMBER != null)
            {
                body["DUNS_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodydUNSNUMBER);
                bodypropCount++;
            }

            if (bodygLOBALDEPTNUMBER != null)
            {
                body["GLOBAL_DEPT_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodygLOBALDEPTNUMBER);
                bodypropCount++;
            }

            if (bodygLOBALDETAILS != null)
            {
                body["GLOBAL_DETAILS"] = CSharpExpressionConverter.ConvertToken(bodygLOBALDETAILS);
                bodypropCount++;
            }

            if (bodygLOBALNOMCODE != null)
            {
                body["GLOBAL_NOM_CODE"] = CSharpExpressionConverter.ConvertToken(bodygLOBALNOMCODE);
                bodypropCount++;
            }

            if (bodygLOBALTAXCODE != null)
            {
                body["GLOBAL_TAX_CODE"] = CSharpExpressionConverter.ConvertToken(bodygLOBALTAXCODE);
                bodypropCount++;
            }

            if (bodyiNVOICENUMBER != null)
            {
                body["INVOICE_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyiNVOICENUMBER);
                bodypropCount++;
            }

            if (bodynAME != null)
            {
                body["NAME"] = CSharpExpressionConverter.ConvertToken(bodynAME);
                bodypropCount++;
            }

            if (bodyoRDERDATE != null)
            {
                body["ORDER_DATE"] = CSharpExpressionConverter.ConvertToken(bodyoRDERDATE);
                bodypropCount++;
            }

            if (bodyoRDERNUMBER != null)
            {
                body["ORDER_NUMBER"] = CSharpExpressionConverter.ConvertToken(bodyoRDERNUMBER);
                bodypropCount++;
            }

            if (bodyoRDERTYPE != null)
            {
                body["ORDER_TYPE"] = CSharpExpressionConverter.ConvertToken(bodyoRDERTYPE);
                bodypropCount++;
            }

            if (bodysETTLEMENTDISCRATE != null)
            {
                body["SETTLEMENT_DISC_RATE"] = CSharpExpressionConverter.ConvertToken(bodysETTLEMENTDISCRATE);
                bodypropCount++;
            }

            if (bodysETTLEMENTDUEDAYS != null)
            {
                body["SETTLEMENT_DUE_DAYS"] = CSharpExpressionConverter.ConvertToken(bodysETTLEMENTDUEDAYS);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderLineItem);
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
                body["Account_Number"] = CSharpExpressionConverter.ConvertToken(bodyaccountNumber);
                bodypropCount++;
            }

            if (bodybillingCity != null)
            {
                body["BillingCity"] = CSharpExpressionConverter.ConvertToken(bodybillingCity);
                bodypropCount++;
            }

            if (bodybillingCountry != null)
            {
                body["BillingCountry"] = CSharpExpressionConverter.ConvertToken(bodybillingCountry);
                bodypropCount++;
            }

            if (bodybillingLastName != null)
            {
                body["BillingLastName"] = CSharpExpressionConverter.ConvertToken(bodybillingLastName);
                bodypropCount++;
            }

            if (bodybillingName != null)
            {
                body["BillingName"] = CSharpExpressionConverter.ConvertToken(bodybillingName);
                bodypropCount++;
            }

            if (bodybillingPostalCode != null)
            {
                body["BillingPostalCode"] = CSharpExpressionConverter.ConvertToken(bodybillingPostalCode);
                bodypropCount++;
            }

            if (bodybillingState != null)
            {
                body["BillingState"] = CSharpExpressionConverter.ConvertToken(bodybillingState);
                bodypropCount++;
            }

            if (bodybillingStreet != null)
            {
                body["BillingStreet"] = CSharpExpressionConverter.ConvertToken(bodybillingStreet);
                bodypropCount++;
            }

            if (bodycCSalesRepresentative != null)
            {
                body["CC_Sales_Representative"] = CSharpExpressionConverter.ConvertToken(bodycCSalesRepresentative);
                bodypropCount++;
            }

            if (bodychargeFinanceCharges != null)
            {
                body["Charge_Finance_Charges"] = CSharpExpressionConverter.ConvertToken(bodychargeFinanceCharges);
                bodypropCount++;
            }

            if (bodycontactName != null)
            {
                body["ContactName"] = CSharpExpressionConverter.ConvertToken(bodycontactName);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["Credit_Limit"] = CSharpExpressionConverter.ConvertToken(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycreditStatus != null)
            {
                body["Credit_Status"] = CSharpExpressionConverter.ConvertToken(bodycreditStatus);
                bodypropCount++;
            }

            if (bodycustomFieldValue1 != null)
            {
                body["CustomFieldValue1"] = CSharpExpressionConverter.ConvertToken(bodycustomFieldValue1);
                bodypropCount++;
            }

            if (bodycustomFieldValue2 != null)
            {
                body["CustomFieldValue2"] = CSharpExpressionConverter.ConvertToken(bodycustomFieldValue2);
                bodypropCount++;
            }

            if (bodycustomFieldValue3 != null)
            {
                body["CustomFieldValue3"] = CSharpExpressionConverter.ConvertToken(bodycustomFieldValue3);
                bodypropCount++;
            }

            if (bodycustomFieldValue4 != null)
            {
                body["CustomFieldValue4"] = CSharpExpressionConverter.ConvertToken(bodycustomFieldValue4);
                bodypropCount++;
            }

            if (bodycustomFieldValue5 != null)
            {
                body["CustomFieldValue5"] = CSharpExpressionConverter.ConvertToken(bodycustomFieldValue5);
                bodypropCount++;
            }

            if (bodycustomerGUID != null)
            {
                body["CustomerGUID"] = CSharpExpressionConverter.ConvertToken(bodycustomerGUID);
                bodypropCount++;
            }

            if (bodycustomerID != null)
            {
                body["CustomerID"] = CSharpExpressionConverter.ConvertToken(bodycustomerID);
                bodypropCount++;
            }

            if (bodycustomerBalance != null)
            {
                body["Customer_Balance"] = CSharpExpressionConverter.ConvertToken(bodycustomerBalance);
                bodypropCount++;
            }

            if (bodycustomerSinceDate != null)
            {
                body["Customer_Since_Date"] = CSharpExpressionConverter.ConvertToken(bodycustomerSinceDate);
                bodypropCount++;
            }

            if (bodycustomerType != null)
            {
                body["Customer_Type"] = CSharpExpressionConverter.ConvertToken(bodycustomerType);
                bodypropCount++;
            }

            if (bodydiscountDays != null)
            {
                body["Discount_Days"] = CSharpExpressionConverter.ConvertToken(bodydiscountDays);
                bodypropCount++;
            }

            if (bodydiscountPercent != null)
            {
                body["Discount_Percent"] = CSharpExpressionConverter.ConvertToken(bodydiscountPercent);
                bodypropCount++;
            }

            if (bodydueDays != null)
            {
                body["Due_Days"] = CSharpExpressionConverter.ConvertToken(bodydueDays);
                bodypropCount++;
            }

            if (bodyeMailAddress != null)
            {
                body["EMail_Address"] = CSharpExpressionConverter.ConvertToken(bodyeMailAddress);
                bodypropCount++;
            }

            if (bodyfaxNumber != null)
            {
                body["FaxNumber"] = CSharpExpressionConverter.ConvertToken(bodyfaxNumber);
                bodypropCount++;
            }

            if (bodyformDeliveryMethod != null)
            {
                body["Form_Delivery_Method"] = CSharpExpressionConverter.ConvertToken(bodyformDeliveryMethod);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodyphoneNo1 != null)
            {
                body["PhoneNo1"] = CSharpExpressionConverter.ConvertToken(bodyphoneNo1);
                bodypropCount++;
            }

            if (bodyphoneNo2 != null)
            {
                body["PhoneNo2"] = CSharpExpressionConverter.ConvertToken(bodyphoneNo2);
                bodypropCount++;
            }

            if (bodypricingLevel != null)
            {
                body["Pricing_Level"] = CSharpExpressionConverter.ConvertToken(bodypricingLevel);
                bodypropCount++;
            }

            if (bodysalesRepresentativeID != null)
            {
                body["Sales_Representative_ID"] = CSharpExpressionConverter.ConvertToken(bodysalesRepresentativeID);
                bodypropCount++;
            }

            if (bodysalesTaxCode != null)
            {
                body["Sales_Tax_Code"] = CSharpExpressionConverter.ConvertToken(bodysalesTaxCode);
                bodypropCount++;
            }

            if (bodyshippingCity != null)
            {
                body["ShippingCity"] = CSharpExpressionConverter.ConvertToken(bodyshippingCity);
                bodypropCount++;
            }

            if (bodyshippingCountry != null)
            {
                body["ShippingCountry"] = CSharpExpressionConverter.ConvertToken(bodyshippingCountry);
                bodypropCount++;
            }

            if (bodyshippingPostalCode != null)
            {
                body["ShippingPostalCode"] = CSharpExpressionConverter.ConvertToken(bodyshippingPostalCode);
                bodypropCount++;
            }

            if (bodyshippingState != null)
            {
                body["ShippingState"] = CSharpExpressionConverter.ConvertToken(bodyshippingState);
                bodypropCount++;
            }

            if (bodyshippingStreet != null)
            {
                body["ShippingStreet"] = CSharpExpressionConverter.ConvertToken(bodyshippingStreet);
                bodypropCount++;
            }

            if (bodytermsType != null)
            {
                body["Terms_Type"] = CSharpExpressionConverter.ConvertToken(bodytermsType);
                bodypropCount++;
            }

            if (bodyuseCODTerms != null)
            {
                body["Use_COD_Terms"] = CSharpExpressionConverter.ConvertToken(bodyuseCODTerms);
                bodypropCount++;
            }

            if (bodyuseDueMonthEndTerms != null)
            {
                body["Use_Due_Month_End_Terms"] = CSharpExpressionConverter.ConvertToken(bodyuseDueMonthEndTerms);
                bodypropCount++;
            }

            if (bodyusePrepaidTerms != null)
            {
                body["Use_Prepaid_Terms"] = CSharpExpressionConverter.ConvertToken(bodyusePrepaidTerms);
                bodypropCount++;
            }

            if (bodyuseStandardTerms != null)
            {
                body["Use_Standard_Terms"] = CSharpExpressionConverter.ConvertToken(bodyuseStandardTerms);
                bodypropCount++;
            }

            if (bodyisInactive != null)
            {
                body["isInactive"] = CSharpExpressionConverter.ConvertToken(bodyisInactive);
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
                body["Accounts_Receivable_Account"] = CSharpExpressionConverter.ConvertToken(bodyaccountsReceivableAccount);
                bodypropCount++;
            }

            if (bodyaccountsReceivableAcctGUID != null)
            {
                body["Accounts_Receivable_Acct_GUID"] = CSharpExpressionConverter.ConvertToken(bodyaccountsReceivableAcctGUID);
                bodypropCount++;
            }

            if (bodyaccountsReceivableAmount != null)
            {
                body["Accounts_Receivable_Amount"] = CSharpExpressionConverter.ConvertToken(bodyaccountsReceivableAmount);
                bodypropCount++;
            }

            if (bodyclosed != null)
            {
                body["Closed"] = CSharpExpressionConverter.ConvertToken(bodyclosed);
                bodypropCount++;
            }

            if (bodycustomerID != null)
            {
                body["Customer_ID"] = CSharpExpressionConverter.ConvertToken(bodycustomerID);
                bodypropCount++;
            }

            if (bodycustomerPO != null)
            {
                body["Customer_PO"] = CSharpExpressionConverter.ConvertToken(bodycustomerPO);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["Date"] = CSharpExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
            }

            if (bodydiscountAmount != null)
            {
                body["Discount_Amount"] = CSharpExpressionConverter.ConvertToken(bodydiscountAmount);
                bodypropCount++;
            }

            if (bodydisplayedTerms != null)
            {
                body["Displayed_Terms"] = CSharpExpressionConverter.ConvertToken(bodydisplayedTerms);
                bodypropCount++;
            }

            if (bodydropShip != null)
            {
                body["Drop_Ship"] = CSharpExpressionConverter.ConvertToken(bodydropShip);
                bodypropCount++;
            }

            if (bodygUID != null)
            {
                body["GUID"] = CSharpExpressionConverter.ConvertToken(bodygUID);
                bodypropCount++;
            }

            if (bodynotePrintsAfterLineItems != null)
            {
                body["Note_Prints_After_Line_Items"] = CSharpExpressionConverter.ConvertToken(bodynotePrintsAfterLineItems);
                bodypropCount++;
            }

            if (bodyproposal != null)
            {
                body["Proposal"] = CSharpExpressionConverter.ConvertToken(bodyproposal);
                bodypropCount++;
            }

            if (bodyproposalAccepted != null)
            {
                body["ProposalAccepted"] = CSharpExpressionConverter.ConvertToken(bodyproposalAccepted);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodysalesOrderNumber != null)
            {
                body["Sales_Order_Number"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderNumber);
                bodypropCount++;
            }

            if (bodysalesRepresentativeGUID != null)
            {
                body["Sales_Representative_GUID"] = CSharpExpressionConverter.ConvertToken(bodysalesRepresentativeGUID);
                bodypropCount++;
            }

            if (bodysalesRepresentativeID != null)
            {
                body["Sales_Representative_ID"] = CSharpExpressionConverter.ConvertToken(bodysalesRepresentativeID);
                bodypropCount++;
            }

            if (bodyshipAddressCity != null)
            {
                body["ShipAddressCity"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressCity);
                bodypropCount++;
            }

            if (bodyshipAddressCountry != null)
            {
                body["ShipAddressCountry"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressCountry);
                bodypropCount++;
            }

            if (bodyshipAddressLine1 != null)
            {
                body["ShipAddressLine1"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressLine1);
                bodypropCount++;
            }

            if (bodyshipAddressLine2 != null)
            {
                body["ShipAddressLine2"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressLine2);
                bodypropCount++;
            }

            if (bodyshipAddressName != null)
            {
                body["ShipAddressName"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressName);
                bodypropCount++;
            }

            if (bodyshipAddressState != null)
            {
                body["ShipAddressState"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressState);
                bodypropCount++;
            }

            if (bodyshipAddressZipCode != null)
            {
                body["ShipAddressZipCode"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressZipCode);
                bodypropCount++;
            }

            if (bodyshipBy != null)
            {
                body["Ship_By"] = CSharpExpressionConverter.ConvertToken(bodyshipBy);
                bodypropCount++;
            }

            if (bodyshipVIA != null)
            {
                body["Ship_VIA"] = CSharpExpressionConverter.ConvertToken(bodyshipVIA);
                bodypropCount++;
            }

            if (bodystatementNotePrintsBeforeInvRef != null)
            {
                body["Statement_Note_Prints_Before_Inv_Ref"] = CSharpExpressionConverter.ConvertToken(bodystatementNotePrintsBeforeInvRef);
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
                body["Address"] = CSharpExpressionConverter.ConvertToken(bodyaddress);
                bodypropCount++;
            }

            if (bodybillingAddressName != null)
            {
                body["BillingAddressName"] = CSharpExpressionConverter.ConvertToken(bodybillingAddressName);
                bodypropCount++;
            }

            if (bodybillingBlock != null)
            {
                body["BillingBlock"] = CSharpExpressionConverter.ConvertToken(bodybillingBlock);
                bodypropCount++;
            }

            if (bodybillingCity != null)
            {
                body["BillingCity"] = CSharpExpressionConverter.ConvertToken(bodybillingCity);
                bodypropCount++;
            }

            if (bodybillingCountry != null)
            {
                body["BillingCountry"] = CSharpExpressionConverter.ConvertToken(bodybillingCountry);
                bodypropCount++;
            }

            if (bodybillingState != null)
            {
                body["BillingState"] = CSharpExpressionConverter.ConvertToken(bodybillingState);
                bodypropCount++;
            }

            if (bodybillingStreet != null)
            {
                body["BillingStreet"] = CSharpExpressionConverter.ConvertToken(bodybillingStreet);
                bodypropCount++;
            }

            if (bodybillingZipCode != null)
            {
                body["BillingZipCode"] = CSharpExpressionConverter.ConvertToken(bodybillingZipCode);
                bodypropCount++;
            }

            if (bodycardCode != null)
            {
                body["CardCode"] = CSharpExpressionConverter.ConvertToken(bodycardCode);
                bodypropCount++;
            }

            if (bodycardName != null)
            {
                body["CardName"] = CSharpExpressionConverter.ConvertToken(bodycardName);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodycontactPerson != null)
            {
                body["ContactPerson"] = CSharpExpressionConverter.ConvertToken(bodycontactPerson);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["Country"] = CSharpExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["County"] = CSharpExpressionConverter.ConvertToken(bodycounty);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["Currency"] = CSharpExpressionConverter.ConvertToken(bodycurrency);
                bodypropCount++;
            }

            if (bodyemailAddress != null)
            {
                body["EmailAddress"] = CSharpExpressionConverter.ConvertToken(bodyemailAddress);
                bodypropCount++;
            }

            if (bodyextraField != null)
            {
                body["ExtraField"] = CSharpExpressionConverter.ConvertToken(bodyextraField);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["Fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodyfederalTaxID != null)
            {
                body["FederalTaxID"] = CSharpExpressionConverter.ConvertToken(bodyfederalTaxID);
                bodypropCount++;
            }

            if (bodyfreeText != null)
            {
                body["FreeText"] = CSharpExpressionConverter.ConvertToken(bodyfreeText);
                bodypropCount++;
            }

            if (bodygroupCode != null)
            {
                body["GroupCode"] = CSharpExpressionConverter.ConvertToken(bodygroupCode);
                bodypropCount++;
            }

            if (bodymailAddress != null)
            {
                body["MailAddress"] = CSharpExpressionConverter.ConvertToken(bodymailAddress);
                bodypropCount++;
            }

            if (bodymailCity != null)
            {
                body["MailCity"] = CSharpExpressionConverter.ConvertToken(bodymailCity);
                bodypropCount++;
            }

            if (bodymailCountry != null)
            {
                body["MailCountry"] = CSharpExpressionConverter.ConvertToken(bodymailCountry);
                bodypropCount++;
            }

            if (bodymailCounty != null)
            {
                body["MailCounty"] = CSharpExpressionConverter.ConvertToken(bodymailCounty);
                bodypropCount++;
            }

            if (bodymailZipCode != null)
            {
                body["MailZipCode"] = CSharpExpressionConverter.ConvertToken(bodymailZipCode);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["Notes"] = CSharpExpressionConverter.ConvertToken(bodynotes);
                bodypropCount++;
            }

            if (bodyphone1 != null)
            {
                body["Phone1"] = CSharpExpressionConverter.ConvertToken(bodyphone1);
                bodypropCount++;
            }

            if (bodyphone2 != null)
            {
                body["Phone2"] = CSharpExpressionConverter.ConvertToken(bodyphone2);
                bodypropCount++;
            }

            if (bodysalesPersonCode != null)
            {
                body["SalesPersonCode"] = CSharpExpressionConverter.ConvertToken(bodysalesPersonCode);
                bodypropCount++;
            }

            if (bodyseries != null)
            {
                body["Series"] = CSharpExpressionConverter.ConvertToken(bodyseries);
                bodypropCount++;
            }

            if (bodyshippingAddressName != null)
            {
                body["ShippingAddressName"] = CSharpExpressionConverter.ConvertToken(bodyshippingAddressName);
                bodypropCount++;
            }

            if (bodyshippingBlock != null)
            {
                body["ShippingBlock"] = CSharpExpressionConverter.ConvertToken(bodyshippingBlock);
                bodypropCount++;
            }

            if (bodyshippingCity != null)
            {
                body["ShippingCity"] = CSharpExpressionConverter.ConvertToken(bodyshippingCity);
                bodypropCount++;
            }

            if (bodyshippingCountry != null)
            {
                body["ShippingCountry"] = CSharpExpressionConverter.ConvertToken(bodyshippingCountry);
                bodypropCount++;
            }

            if (bodyshippingState != null)
            {
                body["ShippingState"] = CSharpExpressionConverter.ConvertToken(bodyshippingState);
                bodypropCount++;
            }

            if (bodyshippingStreet != null)
            {
                body["ShippingStreet"] = CSharpExpressionConverter.ConvertToken(bodyshippingStreet);
                bodypropCount++;
            }

            if (bodyshippingZipCode != null)
            {
                body["ShippingZipCode"] = CSharpExpressionConverter.ConvertToken(bodyshippingZipCode);
                bodypropCount++;
            }

            if (bodywebSite != null)
            {
                body["WebSite"] = CSharpExpressionConverter.ConvertToken(bodywebSite);
                bodypropCount++;
            }

            if (bodyzipCode != null)
            {
                body["ZipCode"] = CSharpExpressionConverter.ConvertToken(bodyzipCode);
                bodypropCount++;
            }

            if (bodylstContactEmployees != null)
            {
                body["lstContactEmployees"] = CSharpExpressionConverter.ConvertToken(bodylstContactEmployees);
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
                body["CardCode"] = CSharpExpressionConverter.ConvertToken(bodycardCode);
                bodypropCount++;
            }

            if (bodydocDate != null)
            {
                body["DocDate"] = CSharpExpressionConverter.ConvertToken(bodydocDate);
                bodypropCount++;
            }

            if (bodydocDueDate != null)
            {
                body["DocDueDate"] = CSharpExpressionConverter.ConvertToken(bodydocDueDate);
                bodypropCount++;
            }

            if (bodydocNum != null)
            {
                body["DocNum"] = CSharpExpressionConverter.ConvertToken(bodydocNum);
                bodypropCount++;
            }

            if (bodysalesOrderLineItem != null)
            {
                body["SalesOrderLineItem"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                bodypropCount++;
            }

            if (bodyseries != null)
            {
                body["Series"] = CSharpExpressionConverter.ConvertToken(bodyseries);
                bodypropCount++;
            }

            if (bodytaxDate != null)
            {
                body["TaxDate"] = CSharpExpressionConverter.ConvertToken(bodytaxDate);
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
                body["AddTelephone"] = CSharpExpressionConverter.ConvertToken(bodyaddTelephone);
                bodypropCount++;
            }

            if (bodyaltMethodFlag != null)
            {
                body["AltMethodFlag"] = CSharpExpressionConverter.ConvertToken(bodyaltMethodFlag);
                bodypropCount++;
            }

            if (bodyapplyLineDisc != null)
            {
                body["ApplyLineDisc"] = CSharpExpressionConverter.ConvertToken(bodyapplyLineDisc);
                bodypropCount++;
            }

            if (bodyapplyOrdDisc != null)
            {
                body["ApplyOrdDisc"] = CSharpExpressionConverter.ConvertToken(bodyapplyOrdDisc);
                bodypropCount++;
            }

            if (bodyarStatementNo != null)
            {
                body["ArStatementNo"] = CSharpExpressionConverter.ConvertToken(bodyarStatementNo);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = CSharpExpressionConverter.ConvertToken(bodyarea);
                bodypropCount++;
            }

            if (bodybackOrdReqd != null)
            {
                body["BackOrdReqd"] = CSharpExpressionConverter.ConvertToken(bodybackOrdReqd);
                bodypropCount++;
            }

            if (bodybalanceType != null)
            {
                body["BalanceType"] = CSharpExpressionConverter.ConvertToken(bodybalanceType);
                bodypropCount++;
            }

            if (bodybranch != null)
            {
                body["Branch"] = CSharpExpressionConverter.ConvertToken(bodybranch);
                bodypropCount++;
            }

            if (bodybuyingGroup1 != null)
            {
                body["BuyingGroup1"] = CSharpExpressionConverter.ConvertToken(bodybuyingGroup1);
                bodypropCount++;
            }

            if (bodybuyingGroup2 != null)
            {
                body["BuyingGroup2"] = CSharpExpressionConverter.ConvertToken(bodybuyingGroup2);
                bodypropCount++;
            }

            if (bodybuyingGroup3 != null)
            {
                body["BuyingGroup3"] = CSharpExpressionConverter.ConvertToken(bodybuyingGroup3);
                bodypropCount++;
            }

            if (bodybuyingGroup4 != null)
            {
                body["BuyingGroup4"] = CSharpExpressionConverter.ConvertToken(bodybuyingGroup4);
                bodypropCount++;
            }

            if (bodybuyingGroup5 != null)
            {
                body["BuyingGroup5"] = CSharpExpressionConverter.ConvertToken(bodybuyingGroup5);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodycity1 != null)
            {
                body["City1"] = CSharpExpressionConverter.ConvertToken(bodycity1);
                bodypropCount++;
            }

            if (bodycompanyTaxNumber != null)
            {
                body["CompanyTaxNumber"] = CSharpExpressionConverter.ConvertToken(bodycompanyTaxNumber);
                bodypropCount++;
            }

            if (bodycontact != null)
            {
                body["Contact"] = CSharpExpressionConverter.ConvertToken(bodycontact);
                bodypropCount++;
            }

            if (bodycontractPrcReqd != null)
            {
                body["ContractPrcReqd"] = CSharpExpressionConverter.ConvertToken(bodycontractPrcReqd);
                bodypropCount++;
            }

            if (bodycounterSlsOnly != null)
            {
                body["CounterSlsOnly"] = CSharpExpressionConverter.ConvertToken(bodycounterSlsOnly);
                bodypropCount++;
            }

            if (bodycountyZip != null)
            {
                body["CountyZip"] = CSharpExpressionConverter.ConvertToken(bodycountyZip);
                bodypropCount++;
            }

            if (bodycountyZip1 != null)
            {
                body["CountyZip1"] = CSharpExpressionConverter.ConvertToken(bodycountyZip1);
                bodypropCount++;
            }

            if (bodycreditCheckFlag != null)
            {
                body["CreditCheckFlag"] = CSharpExpressionConverter.ConvertToken(bodycreditCheckFlag);
                bodypropCount++;
            }

            if (bodycreditLimit != null)
            {
                body["CreditLimit"] = CSharpExpressionConverter.ConvertToken(bodycreditLimit);
                bodypropCount++;
            }

            if (bodycreditStatus != null)
            {
                body["CreditStatus"] = CSharpExpressionConverter.ConvertToken(bodycreditStatus);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["Currency"] = CSharpExpressionConverter.ConvertToken(bodycurrency);
                bodypropCount++;
            }

            if (bodycustomerClass != null)
            {
                body["CustomerClass"] = CSharpExpressionConverter.ConvertToken(bodycustomerClass);
                bodypropCount++;
            }

            if (bodycustomerCode != null)
            {
                body["CustomerCode"] = CSharpExpressionConverter.ConvertToken(bodycustomerCode);
                bodypropCount++;
            }

            if (bodycustomerOnHold != null)
            {
                body["CustomerOnHold"] = CSharpExpressionConverter.ConvertToken(bodycustomerOnHold);
                bodypropCount++;
            }

            if (bodydateCustAdded != null)
            {
                body["DateCustAdded"] = CSharpExpressionConverter.ConvertToken(bodydateCustAdded);
                bodypropCount++;
            }

            if (bodydefaultOrdType != null)
            {
                body["DefaultOrdType"] = CSharpExpressionConverter.ConvertToken(bodydefaultOrdType);
                bodypropCount++;
            }

            if (bodydeliveryTerms != null)
            {
                body["DeliveryTerms"] = CSharpExpressionConverter.ConvertToken(bodydeliveryTerms);
                bodypropCount++;
            }

            if (bodydeliveryTermsC != null)
            {
                body["DeliveryTermsC"] = CSharpExpressionConverter.ConvertToken(bodydeliveryTermsC);
                bodypropCount++;
            }

            if (bodydetailMoveReqd != null)
            {
                body["DetailMoveReqd"] = CSharpExpressionConverter.ConvertToken(bodydetailMoveReqd);
                bodypropCount++;
            }

            if (bodydocFax != null)
            {
                body["DocFax"] = CSharpExpressionConverter.ConvertToken(bodydocFax);
                bodypropCount++;
            }

            if (bodydocFaxContact != null)
            {
                body["DocFaxContact"] = CSharpExpressionConverter.ConvertToken(bodydocFaxContact);
                bodypropCount++;
            }

            if (bodyediFlag != null)
            {
                body["EdiFlag"] = CSharpExpressionConverter.ConvertToken(bodyediFlag);
                bodypropCount++;
            }

            if (bodyediSenderCode != null)
            {
                body["EdiSenderCode"] = CSharpExpressionConverter.ConvertToken(bodyediSenderCode);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyexemptFinChg != null)
            {
                body["ExemptFinChg"] = CSharpExpressionConverter.ConvertToken(bodyexemptFinChg);
                bodypropCount++;
            }

            if (bodyfax != null)
            {
                body["Fax"] = CSharpExpressionConverter.ConvertToken(bodyfax);
                bodypropCount++;
            }

            if (bodyfaxInvoices != null)
            {
                body["FaxInvoices"] = CSharpExpressionConverter.ConvertToken(bodyfaxInvoices);
                bodypropCount++;
            }

            if (bodyfaxQuotes != null)
            {
                body["FaxQuotes"] = CSharpExpressionConverter.ConvertToken(bodyfaxQuotes);
                bodypropCount++;
            }

            if (bodyfaxStatements != null)
            {
                body["FaxStatements"] = CSharpExpressionConverter.ConvertToken(bodyfaxStatements);
                bodypropCount++;
            }

            if (bodygstExemptFlag != null)
            {
                body["GstExemptFlag"] = CSharpExpressionConverter.ConvertToken(bodygstExemptFlag);
                bodypropCount++;
            }

            if (bodygstExemptNum != null)
            {
                body["GstExemptNum"] = CSharpExpressionConverter.ConvertToken(bodygstExemptNum);
                bodypropCount++;
            }

            if (bodygstLevel != null)
            {
                body["GstLevel"] = CSharpExpressionConverter.ConvertToken(bodygstLevel);
                bodypropCount++;
            }

            if (bodyhighInv != null)
            {
                body["HighInv"] = CSharpExpressionConverter.ConvertToken(bodyhighInv);
                bodypropCount++;
            }

            if (bodyhighInvDays != null)
            {
                body["HighInvDays"] = CSharpExpressionConverter.ConvertToken(bodyhighInvDays);
                bodypropCount++;
            }

            if (bodyhighestBalance != null)
            {
                body["HighestBalance"] = CSharpExpressionConverter.ConvertToken(bodyhighestBalance);
                bodypropCount++;
            }

            if (bodyibtCustomer != null)
            {
                body["IbtCustomer"] = CSharpExpressionConverter.ConvertToken(bodyibtCustomer);
                bodypropCount++;
            }

            if (bodyinvCommentCode != null)
            {
                body["InvCommentCode"] = CSharpExpressionConverter.ConvertToken(bodyinvCommentCode);
                bodypropCount++;
            }

            if (bodyinvDiscCode != null)
            {
                body["InvDiscCode"] = CSharpExpressionConverter.ConvertToken(bodyinvDiscCode);
                bodypropCount++;
            }

            if (bodylanguageCode != null)
            {
                body["LanguageCode"] = CSharpExpressionConverter.ConvertToken(bodylanguageCode);
                bodypropCount++;
            }

            if (bodylineDiscCode != null)
            {
                body["LineDiscCode"] = CSharpExpressionConverter.ConvertToken(bodylineDiscCode);
                bodypropCount++;
            }

            if (bodymaintHistory != null)
            {
                body["MaintHistory"] = CSharpExpressionConverter.ConvertToken(bodymaintHistory);
                bodypropCount++;
            }

            if (bodymaintLastPrcPaid != null)
            {
                body["MaintLastPrcPaid"] = CSharpExpressionConverter.ConvertToken(bodymaintLastPrcPaid);
                bodypropCount++;
            }

            if (bodyminimumOrderChgCod != null)
            {
                body["MinimumOrderChgCod"] = CSharpExpressionConverter.ConvertToken(bodyminimumOrderChgCod);
                bodypropCount++;
            }

            if (bodyminimumOrderValue != null)
            {
                body["MinimumOrderValue"] = CSharpExpressionConverter.ConvertToken(bodyminimumOrderValue);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["Nationality"] = CSharpExpressionConverter.ConvertToken(bodynationality);
                bodypropCount++;
            }

            if (bodynewCustomerCode != null)
            {
                body["NewCustomerCode"] = CSharpExpressionConverter.ConvertToken(bodynewCustomerCode);
                bodypropCount++;
            }

            if (bodypoNumberMandatory != null)
            {
                body["PoNumberMandatory"] = CSharpExpressionConverter.ConvertToken(bodypoNumberMandatory);
                bodypropCount++;
            }

            if (bodypriceCategoryTable != null)
            {
                body["PriceCategoryTable"] = CSharpExpressionConverter.ConvertToken(bodypriceCategoryTable);
                bodypropCount++;
            }

            if (bodypriceCode != null)
            {
                body["PriceCode"] = CSharpExpressionConverter.ConvertToken(bodypriceCode);
                bodypropCount++;
            }

            if (bodyrouteCode != null)
            {
                body["RouteCode"] = CSharpExpressionConverter.ConvertToken(bodyrouteCode);
                bodypropCount++;
            }

            if (bodyrouteDistance != null)
            {
                body["RouteDistance"] = CSharpExpressionConverter.ConvertToken(bodyrouteDistance);
                bodypropCount++;
            }

            if (bodysalesWarehouse != null)
            {
                body["SalesWarehouse"] = CSharpExpressionConverter.ConvertToken(bodysalesWarehouse);
                bodypropCount++;
            }

            if (bodysalesperson != null)
            {
                body["Salesperson"] = CSharpExpressionConverter.ConvertToken(bodysalesperson);
                bodypropCount++;
            }

            if (bodysalesperson1 != null)
            {
                body["Salesperson1"] = CSharpExpressionConverter.ConvertToken(bodysalesperson1);
                bodypropCount++;
            }

            if (bodysalesperson2 != null)
            {
                body["Salesperson2"] = CSharpExpressionConverter.ConvertToken(bodysalesperson2);
                bodypropCount++;
            }

            if (bodysalesperson3 != null)
            {
                body["Salesperson3"] = CSharpExpressionConverter.ConvertToken(bodysalesperson3);
                bodypropCount++;
            }

            if (bodyshipPostalCode != null)
            {
                body["ShipPostalCode"] = CSharpExpressionConverter.ConvertToken(bodyshipPostalCode);
                bodypropCount++;
            }

            if (bodyshipToAddr1 != null)
            {
                body["ShipToAddr1"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddr1);
                bodypropCount++;
            }

            if (bodyshipToAddr2 != null)
            {
                body["ShipToAddr2"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddr2);
                bodypropCount++;
            }

            if (bodyshipToAddr3 != null)
            {
                body["ShipToAddr3"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddr3);
                bodypropCount++;
            }

            if (bodyshipToAddr3Loc != null)
            {
                body["ShipToAddr3Loc"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddr3Loc);
                bodypropCount++;
            }

            if (bodyshipToAddr4 != null)
            {
                body["ShipToAddr4"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddr4);
                bodypropCount++;
            }

            if (bodyshipToAddr5 != null)
            {
                body["ShipToAddr5"] = CSharpExpressionConverter.ConvertToken(bodyshipToAddr5);
                bodypropCount++;
            }

            if (bodyshipToGpsLat != null)
            {
                body["ShipToGpsLat"] = CSharpExpressionConverter.ConvertToken(bodyshipToGpsLat);
                bodypropCount++;
            }

            if (bodyshipToGpsLong != null)
            {
                body["ShipToGpsLong"] = CSharpExpressionConverter.ConvertToken(bodyshipToGpsLong);
                bodypropCount++;
            }

            if (bodyshippingInstrs != null)
            {
                body["ShippingInstrs"] = CSharpExpressionConverter.ConvertToken(bodyshippingInstrs);
                bodypropCount++;
            }

            if (bodyshippingInstrsCod != null)
            {
                body["ShippingInstrsCod"] = CSharpExpressionConverter.ConvertToken(bodyshippingInstrsCod);
                bodypropCount++;
            }

            if (bodyshippingLocation != null)
            {
                body["ShippingLocation"] = CSharpExpressionConverter.ConvertToken(bodyshippingLocation);
                bodypropCount++;
            }

            if (bodyshortName != null)
            {
                body["ShortName"] = CSharpExpressionConverter.ConvertToken(bodyshortName);
                bodypropCount++;
            }

            if (bodysoDefaultDoc != null)
            {
                body["SoDefaultDoc"] = CSharpExpressionConverter.ConvertToken(bodysoDefaultDoc);
                bodypropCount++;
            }

            if (bodysoDefaultType != null)
            {
                body["SoDefaultType"] = CSharpExpressionConverter.ConvertToken(bodysoDefaultType);
                bodypropCount++;
            }

            if (bodysoldPostalCode != null)
            {
                body["SoldPostalCode"] = CSharpExpressionConverter.ConvertToken(bodysoldPostalCode);
                bodypropCount++;
            }

            if (bodysoldToAddr1 != null)
            {
                body["SoldToAddr1"] = CSharpExpressionConverter.ConvertToken(bodysoldToAddr1);
                bodypropCount++;
            }

            if (bodysoldToAddr2 != null)
            {
                body["SoldToAddr2"] = CSharpExpressionConverter.ConvertToken(bodysoldToAddr2);
                bodypropCount++;
            }

            if (bodysoldToAddr3 != null)
            {
                body["SoldToAddr3"] = CSharpExpressionConverter.ConvertToken(bodysoldToAddr3);
                bodypropCount++;
            }

            if (bodysoldToAddr3Loc != null)
            {
                body["SoldToAddr3Loc"] = CSharpExpressionConverter.ConvertToken(bodysoldToAddr3Loc);
                bodypropCount++;
            }

            if (bodysoldToAddr4 != null)
            {
                body["SoldToAddr4"] = CSharpExpressionConverter.ConvertToken(bodysoldToAddr4);
                bodypropCount++;
            }

            if (bodysoldToAddr5 != null)
            {
                body["SoldToAddr5"] = CSharpExpressionConverter.ConvertToken(bodysoldToAddr5);
                bodypropCount++;
            }

            if (bodysoldToGpsLat != null)
            {
                body["SoldToGpsLat"] = CSharpExpressionConverter.ConvertToken(bodysoldToGpsLat);
                bodypropCount++;
            }

            if (bodysoldToGpsLong != null)
            {
                body["SoldToGpsLong"] = CSharpExpressionConverter.ConvertToken(bodysoldToGpsLong);
                bodypropCount++;
            }

            if (bodyspecialInstrs != null)
            {
                body["SpecialInstrs"] = CSharpExpressionConverter.ConvertToken(bodyspecialInstrs);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["State"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodystate1 != null)
            {
                body["State1"] = CSharpExpressionConverter.ConvertToken(bodystate1);
                bodypropCount++;
            }

            if (bodystateCode != null)
            {
                body["StateCode"] = CSharpExpressionConverter.ConvertToken(bodystateCode);
                bodypropCount++;
            }

            if (bodystatementReqd != null)
            {
                body["StatementReqd"] = CSharpExpressionConverter.ConvertToken(bodystatementReqd);
                bodypropCount++;
            }

            if (bodystockInterchange != null)
            {
                body["StockInterchange"] = CSharpExpressionConverter.ConvertToken(bodystockInterchange);
                bodypropCount++;
            }

            if (bodytagsToDropFromXML != null)
            {
                body["TagsToDropFromXML"] = CSharpExpressionConverter.ConvertToken(bodytagsToDropFromXML);
                bodypropCount++;
            }

            if (bodytaxExemptNumber != null)
            {
                body["TaxExemptNumber"] = CSharpExpressionConverter.ConvertToken(bodytaxExemptNumber);
                bodypropCount++;
            }

            if (bodytaxStatus != null)
            {
                body["TaxStatus"] = CSharpExpressionConverter.ConvertToken(bodytaxStatus);
                bodypropCount++;
            }

            if (bodytelephone != null)
            {
                body["Telephone"] = CSharpExpressionConverter.ConvertToken(bodytelephone);
                bodypropCount++;
            }

            if (bodytelephoneExtn != null)
            {
                body["TelephoneExtn"] = CSharpExpressionConverter.ConvertToken(bodytelephoneExtn);
                bodypropCount++;
            }

            if (bodytelex != null)
            {
                body["Telex"] = CSharpExpressionConverter.ConvertToken(bodytelex);
                bodypropCount++;
            }

            if (bodytermsCode != null)
            {
                body["TermsCode"] = CSharpExpressionConverter.ConvertToken(bodytermsCode);
                bodypropCount++;
            }

            if (bodytpmCreditCheck != null)
            {
                body["TpmCreditCheck"] = CSharpExpressionConverter.ConvertToken(bodytpmCreditCheck);
                bodypropCount++;
            }

            if (bodytpmCustomerFlag != null)
            {
                body["TpmCustomerFlag"] = CSharpExpressionConverter.ConvertToken(bodytpmCustomerFlag);
                bodypropCount++;
            }

            if (bodytpmPricingFlag != null)
            {
                body["TpmPricingFlag"] = CSharpExpressionConverter.ConvertToken(bodytpmPricingFlag);
                bodypropCount++;
            }

            if (bodytransactionNature != null)
            {
                body["TransactionNature"] = CSharpExpressionConverter.ConvertToken(bodytransactionNature);
                bodypropCount++;
            }

            if (bodytransactionNatureC != null)
            {
                body["TransactionNatureC"] = CSharpExpressionConverter.ConvertToken(bodytransactionNatureC);
                bodypropCount++;
            }

            if (bodyukCurrency != null)
            {
                body["UkCurrency"] = CSharpExpressionConverter.ConvertToken(bodyukCurrency);
                bodypropCount++;
            }

            if (bodyukVatFlag != null)
            {
                body["UkVatFlag"] = CSharpExpressionConverter.ConvertToken(bodyukVatFlag);
                bodypropCount++;
            }

            if (bodyuserField1 != null)
            {
                body["UserField1"] = CSharpExpressionConverter.ConvertToken(bodyuserField1);
                bodypropCount++;
            }

            if (bodyuserField2 != null)
            {
                body["UserField2"] = CSharpExpressionConverter.ConvertToken(bodyuserField2);
                bodypropCount++;
            }

            if (bodywholeOrderShipFlag != null)
            {
                body["WholeOrderShipFlag"] = CSharpExpressionConverter.ConvertToken(bodywholeOrderShipFlag);
                bodypropCount++;
            }

            if (bodyeSignature != null)
            {
                body["eSignature"] = CSharpExpressionConverter.ConvertToken(bodyeSignature);
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
                body["AcceptEarlierShipDate"] = CSharpExpressionConverter.ConvertToken(bodyacceptEarlierShipDate);
                bodypropCount++;
            }

            if (bodyacceptKitOptional != null)
            {
                body["AcceptKitOptional"] = CSharpExpressionConverter.ConvertToken(bodyacceptKitOptional);
                bodypropCount++;
            }

            if (bodyacceptOrdersIfNoCredit != null)
            {
                body["AcceptOrdersIfNoCredit"] = CSharpExpressionConverter.ConvertToken(bodyacceptOrdersIfNoCredit);
                bodypropCount++;
            }

            if (bodyaddAttachedServiceCharges != null)
            {
                body["AddAttachedServiceCharges"] = CSharpExpressionConverter.ConvertToken(bodyaddAttachedServiceCharges);
                bodypropCount++;
            }

            if (bodyaddDangerousGoodsText != null)
            {
                body["AddDangerousGoodsText"] = CSharpExpressionConverter.ConvertToken(bodyaddDangerousGoodsText);
                bodypropCount++;
            }

            if (bodyaddStockSalesOrderText != null)
            {
                body["AddStockSalesOrderText"] = CSharpExpressionConverter.ConvertToken(bodyaddStockSalesOrderText);
                bodypropCount++;
            }

            if (bodyallocationAction != null)
            {
                body["AllocationAction"] = CSharpExpressionConverter.ConvertToken(bodyallocationAction);
                bodypropCount++;
            }

            if (bodyallowBackOrderForNegativeMerchLine != null)
            {
                body["AllowBackOrderForNegativeMerchLine"] = CSharpExpressionConverter.ConvertToken(bodyallowBackOrderForNegativeMerchLine);
                bodypropCount++;
            }

            if (bodyallowBackOrderForPartialHold != null)
            {
                body["AllowBackOrderForPartialHold"] = CSharpExpressionConverter.ConvertToken(bodyallowBackOrderForPartialHold);
                bodypropCount++;
            }

            if (bodyallowBackOrderForSuperseded != null)
            {
                body["AllowBackOrderForSuperseded"] = CSharpExpressionConverter.ConvertToken(bodyallowBackOrderForSuperseded);
                bodypropCount++;
            }

            if (bodyallowChangeToZeroPrice != null)
            {
                body["AllowChangeToZeroPrice"] = CSharpExpressionConverter.ConvertToken(bodyallowChangeToZeroPrice);
                bodypropCount++;
            }

            if (bodyallowDuplicateOrderNumbers != null)
            {
                body["AllowDuplicateOrderNumbers"] = CSharpExpressionConverter.ConvertToken(bodyallowDuplicateOrderNumbers);
                bodypropCount++;
            }

            if (bodyallowManualOrderNumberToBeUsed != null)
            {
                body["AllowManualOrderNumberToBeUsed"] = CSharpExpressionConverter.ConvertToken(bodyallowManualOrderNumberToBeUsed);
                bodypropCount++;
            }

            if (bodyallowNonStockItems != null)
            {
                body["AllowNonStockItems"] = CSharpExpressionConverter.ConvertToken(bodyallowNonStockItems);
                bodypropCount++;
            }

            if (bodyallowZeroPrice != null)
            {
                body["AllowZeroPrice"] = CSharpExpressionConverter.ConvertToken(bodyallowZeroPrice);
                bodypropCount++;
            }

            if (bodyalternateReference != null)
            {
                body["AlternateReference"] = CSharpExpressionConverter.ConvertToken(bodyalternateReference);
                bodypropCount++;
            }

            if (bodyalwaysUsePriceEntered != null)
            {
                body["AlwaysUsePriceEntered"] = CSharpExpressionConverter.ConvertToken(bodyalwaysUsePriceEntered);
                bodypropCount++;
            }

            if (bodyapplyLeadTimeCalculation != null)
            {
                body["ApplyLeadTimeCalculation"] = CSharpExpressionConverter.ConvertToken(bodyapplyLeadTimeCalculation);
                bodypropCount++;
            }

            if (bodyapplyParentDiscountToComponents != null)
            {
                body["ApplyParentDiscountToComponents"] = CSharpExpressionConverter.ConvertToken(bodyapplyParentDiscountToComponents);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = CSharpExpressionConverter.ConvertToken(bodyarea);
                bodypropCount++;
            }

            if (bodybranch != null)
            {
                body["Branch"] = CSharpExpressionConverter.ConvertToken(bodybranch);
                bodypropCount++;
            }

            if (bodycancelReasonCode != null)
            {
                body["CancelReasonCode"] = CSharpExpressionConverter.ConvertToken(bodycancelReasonCode);
                bodypropCount++;
            }

            if (bodycheckForCustomerPoNumbers != null)
            {
                body["CheckForCustomerPoNumbers"] = CSharpExpressionConverter.ConvertToken(bodycheckForCustomerPoNumbers);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["City"] = CSharpExpressionConverter.ConvertToken(bodycity);
                bodypropCount++;
            }

            if (bodycompanyTaxNumber != null)
            {
                body["CompanyTaxNumber"] = CSharpExpressionConverter.ConvertToken(bodycompanyTaxNumber);
                bodypropCount++;
            }

            if (bodycountyZip != null)
            {
                body["CountyZip"] = CSharpExpressionConverter.ConvertToken(bodycountyZip);
                bodypropCount++;
            }

            if (bodycreditFailMessage != null)
            {
                body["CreditFailMessage"] = CSharpExpressionConverter.ConvertToken(bodycreditFailMessage);
                bodypropCount++;
            }

            if (bodycurrency != null)
            {
                body["Currency"] = CSharpExpressionConverter.ConvertToken(bodycurrency);
                bodypropCount++;
            }

            if (bodycustomer != null)
            {
                body["Customer"] = CSharpExpressionConverter.ConvertToken(bodycustomer);
                bodypropCount++;
            }

            if (bodycustomerName != null)
            {
                body["CustomerName"] = CSharpExpressionConverter.ConvertToken(bodycustomerName);
                bodypropCount++;
            }

            if (bodycustomerPoNumber != null)
            {
                body["CustomerPoNumber"] = CSharpExpressionConverter.ConvertToken(bodycustomerPoNumber);
                bodypropCount++;
            }

            if (bodycustomerToUse != null)
            {
                body["CustomerToUse"] = CSharpExpressionConverter.ConvertToken(bodycustomerToUse);
                bodypropCount++;
            }

            if (bodydeliveryRoute != null)
            {
                body["DeliveryRoute"] = CSharpExpressionConverter.ConvertToken(bodydeliveryRoute);
                bodypropCount++;
            }

            if (bodydeliveryRouteAction != null)
            {
                body["DeliveryRouteAction"] = CSharpExpressionConverter.ConvertToken(bodydeliveryRouteAction);
                bodypropCount++;
            }

            if (bodydeliveryTerms != null)
            {
                body["DeliveryTerms"] = CSharpExpressionConverter.ConvertToken(bodydeliveryTerms);
                bodypropCount++;
            }

            if (bodydocumentFormat != null)
            {
                body["DocumentFormat"] = CSharpExpressionConverter.ConvertToken(bodydocumentFormat);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyglobalTradePromotionCodes != null)
            {
                body["GlobalTradePromotionCodes"] = CSharpExpressionConverter.ConvertToken(bodyglobalTradePromotionCodes);
                bodypropCount++;
            }

            if (bodygstExemptNumber != null)
            {
                body["GstExemptNumber"] = CSharpExpressionConverter.ConvertToken(bodygstExemptNumber);
                bodypropCount++;
            }

            if (bodygstExemptionStatus != null)
            {
                body["GstExemptionStatus"] = CSharpExpressionConverter.ConvertToken(bodygstExemptionStatus);
                bodypropCount++;
            }

            if (bodyheaderFreightCharges != null)
            {
                body["HeaderFreightCharges"] = CSharpExpressionConverter.ConvertToken(bodyheaderFreightCharges);
                bodypropCount++;
            }

            if (bodyheaderMiscCharges != null)
            {
                body["HeaderMiscCharges"] = CSharpExpressionConverter.ConvertToken(bodyheaderMiscCharges);
                bodypropCount++;
            }

            if (bodyignoreWarnings != null)
            {
                body["IgnoreWarnings"] = CSharpExpressionConverter.ConvertToken(bodyignoreWarnings);
                bodypropCount++;
            }

            if (bodyinBoxMsgReqd != null)
            {
                body["InBoxMsgReqd"] = CSharpExpressionConverter.ConvertToken(bodyinBoxMsgReqd);
                bodypropCount++;
            }

            if (bodyincludeInMrp != null)
            {
                body["IncludeInMrp"] = CSharpExpressionConverter.ConvertToken(bodyincludeInMrp);
                bodypropCount++;
            }

            if (bodyinvoiceDateEntered != null)
            {
                body["InvoiceDateEntered"] = CSharpExpressionConverter.ConvertToken(bodyinvoiceDateEntered);
                bodypropCount++;
            }

            if (bodyinvoiceNumberEntered != null)
            {
                body["InvoiceNumberEntered"] = CSharpExpressionConverter.ConvertToken(bodyinvoiceNumberEntered);
                bodypropCount++;
            }

            if (bodyinvoiceTerms != null)
            {
                body["InvoiceTerms"] = CSharpExpressionConverter.ConvertToken(bodyinvoiceTerms);
                bodypropCount++;
            }

            if (bodyinvoiceWholeOrderOnly != null)
            {
                body["InvoiceWholeOrderOnly"] = CSharpExpressionConverter.ConvertToken(bodyinvoiceWholeOrderOnly);
                bodypropCount++;
            }

            if (bodylanguageCode != null)
            {
                body["LanguageCode"] = CSharpExpressionConverter.ConvertToken(bodylanguageCode);
                bodypropCount++;
            }

            if (bodyminimumDaysToShip != null)
            {
                body["MinimumDaysToShip"] = CSharpExpressionConverter.ConvertToken(bodyminimumDaysToShip);
                bodypropCount++;
            }

            if (bodymultiShipCode != null)
            {
                body["MultiShipCode"] = CSharpExpressionConverter.ConvertToken(bodymultiShipCode);
                bodypropCount++;
            }

            if (bodynationality != null)
            {
                body["Nationality"] = CSharpExpressionConverter.ConvertToken(bodynationality);
                bodypropCount++;
            }

            if (bodynewCustomerPoNumber != null)
            {
                body["NewCustomerPoNumber"] = CSharpExpressionConverter.ConvertToken(bodynewCustomerPoNumber);
                bodypropCount++;
            }

            if (bodynewSalesOrderNumber != null)
            {
                body["NewSalesOrderNumber"] = CSharpExpressionConverter.ConvertToken(bodynewSalesOrderNumber);
                bodypropCount++;
            }

            if (bodyoperatorToInform != null)
            {
                body["OperatorToInform"] = CSharpExpressionConverter.ConvertToken(bodyoperatorToInform);
                bodypropCount++;
            }

            if (bodyorderActionType != null)
            {
                body["OrderActionType"] = CSharpExpressionConverter.ConvertToken(bodyorderActionType);
                bodypropCount++;
            }

            if (bodyorderComments != null)
            {
                body["OrderComments"] = CSharpExpressionConverter.ConvertToken(bodyorderComments);
                bodypropCount++;
            }

            if (bodyorderDate != null)
            {
                body["OrderDate"] = CSharpExpressionConverter.ConvertToken(bodyorderDate);
                bodypropCount++;
            }

            if (bodyorderDiscPercent1 != null)
            {
                body["OrderDiscPercent1"] = CSharpExpressionConverter.ConvertToken(bodyorderDiscPercent1);
                bodypropCount++;
            }

            if (bodyorderDiscPercent2 != null)
            {
                body["OrderDiscPercent2"] = CSharpExpressionConverter.ConvertToken(bodyorderDiscPercent2);
                bodypropCount++;
            }

            if (bodyorderDiscPercent3 != null)
            {
                body["OrderDiscPercent3"] = CSharpExpressionConverter.ConvertToken(bodyorderDiscPercent3);
                bodypropCount++;
            }

            if (bodyorderStatus != null)
            {
                body["OrderStatus"] = CSharpExpressionConverter.ConvertToken(bodyorderStatus);
                bodypropCount++;
            }

            if (bodyorderType != null)
            {
                body["OrderType"] = CSharpExpressionConverter.ConvertToken(bodyorderType);
                bodypropCount++;
            }

            if (bodyoverrideCustomerBackOrder != null)
            {
                body["OverrideCustomerBackOrder"] = CSharpExpressionConverter.ConvertToken(bodyoverrideCustomerBackOrder);
                bodypropCount++;
            }

            if (bodypOSSalesOrder != null)
            {
                body["POSSalesOrder"] = CSharpExpressionConverter.ConvertToken(bodypOSSalesOrder);
                bodypropCount++;
            }

            if (bodyprocess != null)
            {
                body["Process"] = CSharpExpressionConverter.ConvertToken(bodyprocess);
                bodypropCount++;
            }

            if (bodyprocessFlag != null)
            {
                body["ProcessFlag"] = CSharpExpressionConverter.ConvertToken(bodyprocessFlag);
                bodypropCount++;
            }

            if (bodyputEntireQuantityOnNewLoadWhenChanged != null)
            {
                body["PutEntireQuantityOnNewLoadWhenChanged"] = CSharpExpressionConverter.ConvertToken(bodyputEntireQuantityOnNewLoadWhenChanged);
                bodypropCount++;
            }

            if (bodyreceiverCode != null)
            {
                body["ReceiverCode"] = CSharpExpressionConverter.ConvertToken(bodyreceiverCode);
                bodypropCount++;
            }

            if (bodyrequestedShipDate != null)
            {
                body["RequestedShipDate"] = CSharpExpressionConverter.ConvertToken(bodyrequestedShipDate);
                bodypropCount++;
            }

            if (bodyreserveStock != null)
            {
                body["ReserveStock"] = CSharpExpressionConverter.ConvertToken(bodyreserveStock);
                bodypropCount++;
            }

            if (bodyreserveStockRequestAllocs != null)
            {
                body["ReserveStockRequestAllocs"] = CSharpExpressionConverter.ConvertToken(bodyreserveStockRequestAllocs);
                bodypropCount++;
            }

            if (bodysalesOrder != null)
            {
                body["SalesOrder"] = CSharpExpressionConverter.ConvertToken(bodysalesOrder);
                bodypropCount++;
            }

            if (bodysalesOrderDetails != null)
            {
                body["SalesOrderDetails"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderDetails);
                bodypropCount++;
            }

            if (bodysalesOrderFooterComments != null)
            {
                body["SalesOrderFooterComments"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderFooterComments);
                bodypropCount++;
            }

            if (bodysalesOrderFreightDetails != null)
            {
                body["SalesOrderFreightDetails"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderFreightDetails);
                bodypropCount++;
            }

            if (bodysalesOrderHeaderComments != null)
            {
                body["SalesOrderHeaderComments"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderHeaderComments);
                bodypropCount++;
            }

            if (bodysalesOrderMiscChargesDetails != null)
            {
                body["SalesOrderMiscChargesDetails"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderMiscChargesDetails);
                bodypropCount++;
            }

            if (bodysalesOrderPromoQualifyAction != null)
            {
                body["SalesOrderPromoQualifyAction"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderPromoQualifyAction);
                bodypropCount++;
            }

            if (bodysalesOrderPromoSelectAction != null)
            {
                body["SalesOrderPromoSelectAction"] = CSharpExpressionConverter.ConvertToken(bodysalesOrderPromoSelectAction);
                bodypropCount++;
            }

            if (bodysalesperson != null)
            {
                body["Salesperson"] = CSharpExpressionConverter.ConvertToken(bodysalesperson);
                bodypropCount++;
            }

            if (bodysenderCode != null)
            {
                body["SenderCode"] = CSharpExpressionConverter.ConvertToken(bodysenderCode);
                bodypropCount++;
            }

            if (bodyshipAddress1 != null)
            {
                body["ShipAddress1"] = CSharpExpressionConverter.ConvertToken(bodyshipAddress1);
                bodypropCount++;
            }

            if (bodyshipAddress2 != null)
            {
                body["ShipAddress2"] = CSharpExpressionConverter.ConvertToken(bodyshipAddress2);
                bodypropCount++;
            }

            if (bodyshipAddress3 != null)
            {
                body["ShipAddress3"] = CSharpExpressionConverter.ConvertToken(bodyshipAddress3);
                bodypropCount++;
            }

            if (bodyshipAddress3Locality != null)
            {
                body["ShipAddress3Locality"] = CSharpExpressionConverter.ConvertToken(bodyshipAddress3Locality);
                bodypropCount++;
            }

            if (bodyshipAddress4 != null)
            {
                body["ShipAddress4"] = CSharpExpressionConverter.ConvertToken(bodyshipAddress4);
                bodypropCount++;
            }

            if (bodyshipAddress5 != null)
            {
                body["ShipAddress5"] = CSharpExpressionConverter.ConvertToken(bodyshipAddress5);
                bodypropCount++;
            }

            if (bodyshipAddressPerLine != null)
            {
                body["ShipAddressPerLine"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressPerLine);
                bodypropCount++;
            }

            if (bodyshipAddressPerLineTax != null)
            {
                body["ShipAddressPerLineTax"] = CSharpExpressionConverter.ConvertToken(bodyshipAddressPerLineTax);
                bodypropCount++;
            }

            if (bodyshipGpsLat != null)
            {
                body["ShipGpsLat"] = CSharpExpressionConverter.ConvertToken(bodyshipGpsLat);
                bodypropCount++;
            }

            if (bodyshipGpsLong != null)
            {
                body["ShipGpsLong"] = CSharpExpressionConverter.ConvertToken(bodyshipGpsLong);
                bodypropCount++;
            }

            if (bodyshipPostalCode != null)
            {
                body["ShipPostalCode"] = CSharpExpressionConverter.ConvertToken(bodyshipPostalCode);
                bodypropCount++;
            }

            if (bodyshippingInstrs != null)
            {
                body["ShippingInstrs"] = CSharpExpressionConverter.ConvertToken(bodyshippingInstrs);
                bodypropCount++;
            }

            if (bodyshippingInstrsCode != null)
            {
                body["ShippingInstrsCode"] = CSharpExpressionConverter.ConvertToken(bodyshippingInstrsCode);
                bodypropCount++;
            }

            if (bodyshippingLocation != null)
            {
                body["ShippingLocation"] = CSharpExpressionConverter.ConvertToken(bodyshippingLocation);
                bodypropCount++;
            }

            if (bodyspecialInstrs != null)
            {
                body["SpecialInstrs"] = CSharpExpressionConverter.ConvertToken(bodyspecialInstrs);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["State"] = CSharpExpressionConverter.ConvertToken(bodystate);
                bodypropCount++;
            }

            if (bodystatusInProcess != null)
            {
                body["StatusInProcess"] = CSharpExpressionConverter.ConvertToken(bodystatusInProcess);
                bodypropCount++;
            }

            if (bodystatusInProcessResponse != null)
            {
                body["StatusInProcessResponse"] = CSharpExpressionConverter.ConvertToken(bodystatusInProcessResponse);
                bodypropCount++;
            }

            if (bodysupplier != null)
            {
                body["Supplier"] = CSharpExpressionConverter.ConvertToken(bodysupplier);
                bodypropCount++;
            }

            if (bodytagsToDropFromXML != null)
            {
                body["TagsToDropFromXML"] = CSharpExpressionConverter.ConvertToken(bodytagsToDropFromXML);
                bodypropCount++;
            }

            if (bodytaxExemptNumber != null)
            {
                body["TaxExemptNumber"] = CSharpExpressionConverter.ConvertToken(bodytaxExemptNumber);
                bodypropCount++;
            }

            if (bodytaxExemptionStatus != null)
            {
                body["TaxExemptionStatus"] = CSharpExpressionConverter.ConvertToken(bodytaxExemptionStatus);
                bodypropCount++;
            }

            if (bodytransactionNature != null)
            {
                body["TransactionNature"] = CSharpExpressionConverter.ConvertToken(bodytransactionNature);
                bodypropCount++;
            }

            if (bodytransmissionReference != null)
            {
                body["TransmissionReference"] = CSharpExpressionConverter.ConvertToken(bodytransmissionReference);
                bodypropCount++;
            }

            if (bodytransportMode != null)
            {
                body["TransportMode"] = CSharpExpressionConverter.ConvertToken(bodytransportMode);
                bodypropCount++;
            }

            if (bodytypeOfOrder != null)
            {
                body["TypeOfOrder"] = CSharpExpressionConverter.ConvertToken(bodytypeOfOrder);
                bodypropCount++;
            }

            if (bodyuseCustomerSalesWarehouse != null)
            {
                body["UseCustomerSalesWarehouse"] = CSharpExpressionConverter.ConvertToken(bodyuseCustomerSalesWarehouse);
                bodypropCount++;
            }

            if (bodyuseMasterAccountForCustomerPartNo != null)
            {
                body["UseMasterAccountForCustomerPartNo"] = CSharpExpressionConverter.ConvertToken(bodyuseMasterAccountForCustomerPartNo);
                bodypropCount++;
            }

            if (bodyuseStockDescSupplied != null)
            {
                body["UseStockDescSupplied"] = CSharpExpressionConverter.ConvertToken(bodyuseStockDescSupplied);
                bodypropCount++;
            }

            if (bodyvalidateShippingInstrs != null)
            {
                body["ValidateShippingInstrs"] = CSharpExpressionConverter.ConvertToken(bodyvalidateShippingInstrs);
                bodypropCount++;
            }

            if (bodywarehouse != null)
            {
                body["Warehouse"] = CSharpExpressionConverter.ConvertToken(bodywarehouse);
                bodypropCount++;
            }

            if (bodywarehouseListToUse != null)
            {
                body["WarehouseListToUse"] = CSharpExpressionConverter.ConvertToken(bodywarehouseListToUse);
                bodypropCount++;
            }

            if (bodywarnIfCustomerOnHold != null)
            {
                body["WarnIfCustomerOnHold"] = CSharpExpressionConverter.ConvertToken(bodywarnIfCustomerOnHold);
                bodypropCount++;
            }

            if (bodyeSignature != null)
            {
                body["eSignature"] = CSharpExpressionConverter.ConvertToken(bodyeSignature);
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