//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commercientcpq
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CommercientcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAGE100CreateNewCustomer))]
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> SAGE100CreateNewCustomer([WorkflowExpression] Func<string> bodyaRDivisionNo = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodyaddressLine3 = null, [WorkflowExpression] Func<bool> bodybatchFax = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontactCode = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<bool> bodycreditHold = null, [WorkflowExpression] Func<int> bodycreditLimit = null, [WorkflowExpression] Func<int> bodycustomerDiscountRate = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodycustomerNo = null, [WorkflowExpression] Func<string> bodycustomerType = null, [WorkflowExpression] Func<string> bodydefaultCreditCardPmtType = null, [WorkflowExpression] Func<string> bodydefaultItemCode = null, [WorkflowExpression] Func<string> bodydefaultPaymentType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyfaxNo = null, [WorkflowExpression] Func<bool> bodyopenItemCustomer = null, [WorkflowExpression] Func<string> bodypriceLevel = null, [WorkflowExpression] Func<string> bodyprimaryShipToCode = null, [WorkflowExpression] Func<bool> bodyprintDunningMessage = null, [WorkflowExpression] Func<bool> bodyresidentialAddress = null, [WorkflowExpression] Func<string> bodysalespersonNo = null, [WorkflowExpression] Func<string> bodyshipMethod = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodystatementCycle = null, [WorkflowExpression] Func<string> bodytaxExemptNo = null, [WorkflowExpression] Func<string> bodytaxSchedule = null, [WorkflowExpression] Func<string> bodytelephoneExt = null, [WorkflowExpression] Func<string> bodytelephoneNo = null, [WorkflowExpression] Func<string> bodytermsCode = null, [WorkflowExpression] Func<string> bodyuRLAddress = null, [WorkflowExpression] Func<string> bodyzipCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> __BuildSAGE100CreateNewCustomer(WorkflowValue<string> bodyaRDivisionNo = null, WorkflowValue<string> bodyaddressLine1 = null, WorkflowValue<string> bodyaddressLine2 = null, WorkflowValue<string> bodyaddressLine3 = null, WorkflowValue<bool> bodybatchFax = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodycomment = null, WorkflowValue<string> bodycontactCode = null, WorkflowValue<string> bodycountryCode = null, WorkflowValue<bool> bodycreditHold = null, WorkflowValue<int> bodycreditLimit = null, WorkflowValue<int> bodycustomerDiscountRate = null, WorkflowValue<string> bodycustomerName = null, WorkflowValue<string> bodycustomerNo = null, WorkflowValue<string> bodycustomerType = null, WorkflowValue<string> bodydefaultCreditCardPmtType = null, WorkflowValue<string> bodydefaultItemCode = null, WorkflowValue<string> bodydefaultPaymentType = null, WorkflowValue<string> bodyemailAddress = null, WorkflowValue<string> bodyfaxNo = null, WorkflowValue<bool> bodyopenItemCustomer = null, WorkflowValue<string> bodypriceLevel = null, WorkflowValue<string> bodyprimaryShipToCode = null, WorkflowValue<bool> bodyprintDunningMessage = null, WorkflowValue<bool> bodyresidentialAddress = null, WorkflowValue<string> bodysalespersonNo = null, WorkflowValue<string> bodyshipMethod = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodystatementCycle = null, WorkflowValue<string> bodytaxExemptNo = null, WorkflowValue<string> bodytaxSchedule = null, WorkflowValue<string> bodytelephoneExt = null, WorkflowValue<string> bodytelephoneNo = null, WorkflowValue<string> bodytermsCode = null, WorkflowValue<string> bodyuRLAddress = null, WorkflowValue<string> bodyzipCode = null)
        {
            WorkflowValue.Validate(bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            WorkflowValue.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowValue.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowValue.Validate(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            WorkflowValue.Validate(bodybatchFax, nameof(bodybatchFax), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowValue.Validate(bodycontactCode, nameof(bodycontactCode), required: false);
            WorkflowValue.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            WorkflowValue.Validate(bodycreditHold, nameof(bodycreditHold), required: false);
            WorkflowValue.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowValue.Validate(bodycustomerDiscountRate, nameof(bodycustomerDiscountRate), required: false);
            WorkflowValue.Validate(bodycustomerName, nameof(bodycustomerName), required: false);
            WorkflowValue.Validate(bodycustomerNo, nameof(bodycustomerNo), required: false);
            WorkflowValue.Validate(bodycustomerType, nameof(bodycustomerType), required: false);
            WorkflowValue.Validate(bodydefaultCreditCardPmtType, nameof(bodydefaultCreditCardPmtType), required: false);
            WorkflowValue.Validate(bodydefaultItemCode, nameof(bodydefaultItemCode), required: false);
            WorkflowValue.Validate(bodydefaultPaymentType, nameof(bodydefaultPaymentType), required: false);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowValue.Validate(bodyfaxNo, nameof(bodyfaxNo), required: false);
            WorkflowValue.Validate(bodyopenItemCustomer, nameof(bodyopenItemCustomer), required: false);
            WorkflowValue.Validate(bodypriceLevel, nameof(bodypriceLevel), required: false);
            WorkflowValue.Validate(bodyprimaryShipToCode, nameof(bodyprimaryShipToCode), required: false);
            WorkflowValue.Validate(bodyprintDunningMessage, nameof(bodyprintDunningMessage), required: false);
            WorkflowValue.Validate(bodyresidentialAddress, nameof(bodyresidentialAddress), required: false);
            WorkflowValue.Validate(bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            WorkflowValue.Validate(bodyshipMethod, nameof(bodyshipMethod), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodystatementCycle, nameof(bodystatementCycle), required: false);
            WorkflowValue.Validate(bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            WorkflowValue.Validate(bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            WorkflowValue.Validate(bodytelephoneExt, nameof(bodytelephoneExt), required: false);
            WorkflowValue.Validate(bodytelephoneNo, nameof(bodytelephoneNo), required: false);
            WorkflowValue.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            WorkflowValue.Validate(bodyuRLAddress, nameof(bodyuRLAddress), required: false);
            WorkflowValue.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            return new DeferredBodyAction<SAGE100CreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAGE100CreateNewSalesOrder))]
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> SAGE100CreateNewSalesOrder([WorkflowExpression] Func<string> bodyaRDivisionNo = null, [WorkflowExpression] Func<bool> bodybatchFax = null, [WorkflowExpression] Func<string> bodybillToAddress1 = null, [WorkflowExpression] Func<string> bodybillToAddress2 = null, [WorkflowExpression] Func<string> bodybillToAddress3 = null, [WorkflowExpression] Func<string> bodybillToCity = null, [WorkflowExpression] Func<string> bodybillToCountryCode = null, [WorkflowExpression] Func<string> bodybillToName = null, [WorkflowExpression] Func<string> bodybillToState = null, [WorkflowExpression] Func<string> bodybillToZipCode = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyconfirmTo = null, [WorkflowExpression] Func<string> bodycustomerNo = null, [WorkflowExpression] Func<string> bodycustomerPONo = null, [WorkflowExpression] Func<string> bodycycleCode = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyfOB = null, [WorkflowExpression] Func<string> bodyfaxNo = null, [WorkflowExpression] Func<string> bodymasterRepeatingOrderNo = null, [WorkflowExpression] Func<int> bodynumberOfShippingLabels = null, [WorkflowExpression] Func<string> bodyorderDate = null, [WorkflowExpression] Func<string> bodyorderStatus = null, [WorkflowExpression] Func<string> bodyorderType = null, [WorkflowExpression] Func<bool> bodyprintPickingSheets = null, [WorkflowExpression] Func<bool> bodyprintSalesOrders = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<string> bodysalesOrderNo = null, [WorkflowExpression] Func<string> bodysalespersonNo = null, [WorkflowExpression] Func<string> bodyshipExpireDate = null, [WorkflowExpression] Func<string> bodyshipToAddress1 = null, [WorkflowExpression] Func<string> bodyshipToAddress2 = null, [WorkflowExpression] Func<string> bodyshipToAddress3 = null, [WorkflowExpression] Func<string> bodyshipToCity = null, [WorkflowExpression] Func<string> bodyshipToCode = null, [WorkflowExpression] Func<string> bodyshipToCountryCode = null, [WorkflowExpression] Func<string> bodyshipToName = null, [WorkflowExpression] Func<string> bodyshipToState = null, [WorkflowExpression] Func<string> bodyshipToZipCode = null, [WorkflowExpression] Func<string> bodyshipVia = null, [WorkflowExpression] Func<int> bodyshipWeight = null, [WorkflowExpression] Func<string> bodyshipZoneActual = null, [WorkflowExpression] Func<string> bodysplitCommissions = null, [WorkflowExpression] Func<string> bodytaxExemptNo = null, [WorkflowExpression] Func<string> bodytaxSchedule = null, [WorkflowExpression] Func<string> bodytermsCode = null, [WorkflowExpression] Func<string> bodywarehouseCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> __BuildSAGE100CreateNewSalesOrder(WorkflowValue<string> bodyaRDivisionNo = null, WorkflowValue<bool> bodybatchFax = null, WorkflowValue<string> bodybillToAddress1 = null, WorkflowValue<string> bodybillToAddress2 = null, WorkflowValue<string> bodybillToAddress3 = null, WorkflowValue<string> bodybillToCity = null, WorkflowValue<string> bodybillToCountryCode = null, WorkflowValue<string> bodybillToName = null, WorkflowValue<string> bodybillToState = null, WorkflowValue<string> bodybillToZipCode = null, WorkflowValue<string> bodycomment = null, WorkflowValue<string> bodyconfirmTo = null, WorkflowValue<string> bodycustomerNo = null, WorkflowValue<string> bodycustomerPONo = null, WorkflowValue<string> bodycycleCode = null, WorkflowValue<string> bodyemailAddress = null, WorkflowValue<string> bodyfOB = null, WorkflowValue<string> bodyfaxNo = null, WorkflowValue<string> bodymasterRepeatingOrderNo = null, WorkflowValue<int> bodynumberOfShippingLabels = null, WorkflowValue<string> bodyorderDate = null, WorkflowValue<string> bodyorderStatus = null, WorkflowValue<string> bodyorderType = null, WorkflowValue<bool> bodyprintPickingSheets = null, WorkflowValue<bool> bodyprintSalesOrders = null, WorkflowValue<bodysalesOrderLineItemInputItem[]> bodysalesOrderLineItem = null, WorkflowValue<string> bodysalesOrderNo = null, WorkflowValue<string> bodysalespersonNo = null, WorkflowValue<string> bodyshipExpireDate = null, WorkflowValue<string> bodyshipToAddress1 = null, WorkflowValue<string> bodyshipToAddress2 = null, WorkflowValue<string> bodyshipToAddress3 = null, WorkflowValue<string> bodyshipToCity = null, WorkflowValue<string> bodyshipToCode = null, WorkflowValue<string> bodyshipToCountryCode = null, WorkflowValue<string> bodyshipToName = null, WorkflowValue<string> bodyshipToState = null, WorkflowValue<string> bodyshipToZipCode = null, WorkflowValue<string> bodyshipVia = null, WorkflowValue<int> bodyshipWeight = null, WorkflowValue<string> bodyshipZoneActual = null, WorkflowValue<string> bodysplitCommissions = null, WorkflowValue<string> bodytaxExemptNo = null, WorkflowValue<string> bodytaxSchedule = null, WorkflowValue<string> bodytermsCode = null, WorkflowValue<string> bodywarehouseCode = null)
        {
            WorkflowValue.Validate(bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            WorkflowValue.Validate(bodybatchFax, nameof(bodybatchFax), required: false);
            WorkflowValue.Validate(bodybillToAddress1, nameof(bodybillToAddress1), required: false);
            WorkflowValue.Validate(bodybillToAddress2, nameof(bodybillToAddress2), required: false);
            WorkflowValue.Validate(bodybillToAddress3, nameof(bodybillToAddress3), required: false);
            WorkflowValue.Validate(bodybillToCity, nameof(bodybillToCity), required: false);
            WorkflowValue.Validate(bodybillToCountryCode, nameof(bodybillToCountryCode), required: false);
            WorkflowValue.Validate(bodybillToName, nameof(bodybillToName), required: false);
            WorkflowValue.Validate(bodybillToState, nameof(bodybillToState), required: false);
            WorkflowValue.Validate(bodybillToZipCode, nameof(bodybillToZipCode), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowValue.Validate(bodyconfirmTo, nameof(bodyconfirmTo), required: false);
            WorkflowValue.Validate(bodycustomerNo, nameof(bodycustomerNo), required: false);
            WorkflowValue.Validate(bodycustomerPONo, nameof(bodycustomerPONo), required: false);
            WorkflowValue.Validate(bodycycleCode, nameof(bodycycleCode), required: false);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowValue.Validate(bodyfOB, nameof(bodyfOB), required: false);
            WorkflowValue.Validate(bodyfaxNo, nameof(bodyfaxNo), required: false);
            WorkflowValue.Validate(bodymasterRepeatingOrderNo, nameof(bodymasterRepeatingOrderNo), required: false);
            WorkflowValue.Validate(bodynumberOfShippingLabels, nameof(bodynumberOfShippingLabels), required: false);
            WorkflowValue.Validate(bodyorderDate, nameof(bodyorderDate), required: false);
            WorkflowValue.Validate(bodyorderStatus, nameof(bodyorderStatus), required: false);
            WorkflowValue.Validate(bodyorderType, nameof(bodyorderType), required: false);
            WorkflowValue.Validate(bodyprintPickingSheets, nameof(bodyprintPickingSheets), required: false);
            WorkflowValue.Validate(bodyprintSalesOrders, nameof(bodyprintSalesOrders), required: false);
            WorkflowValue.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowValue.Validate(bodysalesOrderNo, nameof(bodysalesOrderNo), required: false);
            WorkflowValue.Validate(bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            WorkflowValue.Validate(bodyshipExpireDate, nameof(bodyshipExpireDate), required: false);
            WorkflowValue.Validate(bodyshipToAddress1, nameof(bodyshipToAddress1), required: false);
            WorkflowValue.Validate(bodyshipToAddress2, nameof(bodyshipToAddress2), required: false);
            WorkflowValue.Validate(bodyshipToAddress3, nameof(bodyshipToAddress3), required: false);
            WorkflowValue.Validate(bodyshipToCity, nameof(bodyshipToCity), required: false);
            WorkflowValue.Validate(bodyshipToCode, nameof(bodyshipToCode), required: false);
            WorkflowValue.Validate(bodyshipToCountryCode, nameof(bodyshipToCountryCode), required: false);
            WorkflowValue.Validate(bodyshipToName, nameof(bodyshipToName), required: false);
            WorkflowValue.Validate(bodyshipToState, nameof(bodyshipToState), required: false);
            WorkflowValue.Validate(bodyshipToZipCode, nameof(bodyshipToZipCode), required: false);
            WorkflowValue.Validate(bodyshipVia, nameof(bodyshipVia), required: false);
            WorkflowValue.Validate(bodyshipWeight, nameof(bodyshipWeight), required: false);
            WorkflowValue.Validate(bodyshipZoneActual, nameof(bodyshipZoneActual), required: false);
            WorkflowValue.Validate(bodysplitCommissions, nameof(bodysplitCommissions), required: false);
            WorkflowValue.Validate(bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            WorkflowValue.Validate(bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            WorkflowValue.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            WorkflowValue.Validate(bodywarehouseCode, nameof(bodywarehouseCode), required: false);
            return new DeferredBodyAction<SAGE100CreateNewSalesOrderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildCommercientCPQCreateNewCustomer))]
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> CommercientCPQCreateNewCustomer([WorkflowExpression] Func<string> bodybillingCity = null, [WorkflowExpression] Func<string> bodybillingCounty = null, [WorkflowExpression] Func<string> bodybillingPostalCode = null, [WorkflowExpression] Func<string> bodybillingState = null, [WorkflowExpression] Func<string> bodybillingStreet = null, [WorkflowExpression] Func<string> bodygUID = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyshippingCity = null, [WorkflowExpression] Func<string> bodyshippingCountry = null, [WorkflowExpression] Func<string> bodyshippingPostalCode = null, [WorkflowExpression] Func<string> bodyshippingState = null, [WorkflowExpression] Func<string> bodyshippingStreet = null, [WorkflowExpression] Func<string> bodyacnm = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> __BuildCommercientCPQCreateNewCustomer(WorkflowValue<string> bodybillingCity = null, WorkflowValue<string> bodybillingCounty = null, WorkflowValue<string> bodybillingPostalCode = null, WorkflowValue<string> bodybillingState = null, WorkflowValue<string> bodybillingStreet = null, WorkflowValue<string> bodygUID = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyshippingCity = null, WorkflowValue<string> bodyshippingCountry = null, WorkflowValue<string> bodyshippingPostalCode = null, WorkflowValue<string> bodyshippingState = null, WorkflowValue<string> bodyshippingStreet = null, WorkflowValue<string> bodyacnm = null)
        {
            WorkflowValue.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            WorkflowValue.Validate(bodybillingCounty, nameof(bodybillingCounty), required: false);
            WorkflowValue.Validate(bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            WorkflowValue.Validate(bodybillingState, nameof(bodybillingState), required: false);
            WorkflowValue.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            WorkflowValue.Validate(bodygUID, nameof(bodygUID), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            WorkflowValue.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            WorkflowValue.Validate(bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            WorkflowValue.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            WorkflowValue.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            WorkflowValue.Validate(bodyacnm, nameof(bodyacnm), required: false);
            return new DeferredBodyAction<CommercientCPQCreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildCommercientCPQCreateNewProduct))]
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> CommercientCPQCreateNewProduct([WorkflowExpression] Func<string> bodystockCode = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> __BuildCommercientCPQCreateNewProduct(WorkflowValue<string> bodystockCode = null)
        {
            WorkflowValue.Validate(bodystockCode, nameof(bodystockCode), required: false);
            return new DeferredBodyAction<CommercientCPQCreateNewProductResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildCommercientCPQCreateNewSalesOrder))]
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> CommercientCPQCreateNewSalesOrder([WorkflowExpression] Func<string> bodyorderHeaderGUID = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem2[]> bodysalesOrderLineItem = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> __BuildCommercientCPQCreateNewSalesOrder(WorkflowValue<string> bodyorderHeaderGUID = null, WorkflowValue<bodysalesOrderLineItemInputItem2[]> bodysalesOrderLineItem = null)
        {
            WorkflowValue.Validate(bodyorderHeaderGUID, nameof(bodyorderHeaderGUID), required: false);
            WorkflowValue.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            return new DeferredBodyAction<CommercientCPQCreateNewSalesOrderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildQuickBookCreateNewCustomer))]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> QuickBookCreateNewCustomer([WorkflowExpression] Func<string> bodyaccountNumber = null, [WorkflowExpression] Func<string> bodyaltContact = null, [WorkflowExpression] Func<string> bodyaltPhone = null, [WorkflowExpression] Func<string> bodybillAddressAddr1 = null, [WorkflowExpression] Func<string> bodybillAddressAddr2 = null, [WorkflowExpression] Func<string> bodybillAddressAddr3 = null, [WorkflowExpression] Func<string> bodybillAddressAddr4 = null, [WorkflowExpression] Func<string> bodybillAddressAddr5 = null, [WorkflowExpression] Func<string> bodybillAddressCity = null, [WorkflowExpression] Func<string> bodybillAddressCountry = null, [WorkflowExpression] Func<string> bodybillAddressNote = null, [WorkflowExpression] Func<string> bodybillAddressPostalCode = null, [WorkflowExpression] Func<string> bodybillAddressState = null, [WorkflowExpression] Func<string> bodycc = null, [WorkflowExpression] Func<string> bodyclassRef = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodycontact = null, [WorkflowExpression] Func<int> bodycreditLimit = null, [WorkflowExpression] Func<string> bodycustomerTypeRef = null, [WorkflowExpression] Func<string> bodyeditSequence = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<bool> bodyisActive = null, [WorkflowExpression] Func<string> bodyitemSalesTaxRef = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodylistID = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodyopenBalance = null, [WorkflowExpression] Func<string> bodyopenBalanceDate = null, [WorkflowExpression] Func<string> bodyparentRef = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodypreferredPaymentMethodRef = null, [WorkflowExpression] Func<string> bodypriceLevelRef = null, [WorkflowExpression] Func<string> bodyresaleNumber = null, [WorkflowExpression] Func<string> bodysalesRepRef = null, [WorkflowExpression] Func<string> bodysalesTaxCodeRef = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyshipAddressAddr1 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr2 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr3 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr4 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr5 = null, [WorkflowExpression] Func<string> bodyshipAddressCity = null, [WorkflowExpression] Func<string> bodyshipAddressCountry = null, [WorkflowExpression] Func<string> bodyshipAddressNote = null, [WorkflowExpression] Func<string> bodyshipAddressPostalCode = null, [WorkflowExpression] Func<string> bodyshipAddressState = null, [WorkflowExpression] Func<string> bodytermsRef = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> __BuildQuickBookCreateNewCustomer(WorkflowValue<string> bodyaccountNumber = null, WorkflowValue<string> bodyaltContact = null, WorkflowValue<string> bodyaltPhone = null, WorkflowValue<string> bodybillAddressAddr1 = null, WorkflowValue<string> bodybillAddressAddr2 = null, WorkflowValue<string> bodybillAddressAddr3 = null, WorkflowValue<string> bodybillAddressAddr4 = null, WorkflowValue<string> bodybillAddressAddr5 = null, WorkflowValue<string> bodybillAddressCity = null, WorkflowValue<string> bodybillAddressCountry = null, WorkflowValue<string> bodybillAddressNote = null, WorkflowValue<string> bodybillAddressPostalCode = null, WorkflowValue<string> bodybillAddressState = null, WorkflowValue<string> bodycc = null, WorkflowValue<string> bodyclassRef = null, WorkflowValue<string> bodycompanyName = null, WorkflowValue<string> bodycontact = null, WorkflowValue<int> bodycreditLimit = null, WorkflowValue<string> bodycustomerTypeRef = null, WorkflowValue<string> bodyeditSequence = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyextraField = null, WorkflowValue<string> bodyfax = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<bool> bodyisActive = null, WorkflowValue<string> bodyitemSalesTaxRef = null, WorkflowValue<string> bodyjobTitle = null, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodylistID = null, WorkflowValue<string> bodymiddleName = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodynotes = null, WorkflowValue<int> bodyopenBalance = null, WorkflowValue<string> bodyopenBalanceDate = null, WorkflowValue<string> bodyparentRef = null, WorkflowValue<string> bodyphone = null, WorkflowValue<string> bodypreferredPaymentMethodRef = null, WorkflowValue<string> bodypriceLevelRef = null, WorkflowValue<string> bodyresaleNumber = null, WorkflowValue<string> bodysalesRepRef = null, WorkflowValue<string> bodysalesTaxCodeRef = null, WorkflowValue<string> bodysalutation = null, WorkflowValue<string> bodyshipAddressAddr1 = null, WorkflowValue<string> bodyshipAddressAddr2 = null, WorkflowValue<string> bodyshipAddressAddr3 = null, WorkflowValue<string> bodyshipAddressAddr4 = null, WorkflowValue<string> bodyshipAddressAddr5 = null, WorkflowValue<string> bodyshipAddressCity = null, WorkflowValue<string> bodyshipAddressCountry = null, WorkflowValue<string> bodyshipAddressNote = null, WorkflowValue<string> bodyshipAddressPostalCode = null, WorkflowValue<string> bodyshipAddressState = null, WorkflowValue<string> bodytermsRef = null)
        {
            WorkflowValue.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            WorkflowValue.Validate(bodyaltContact, nameof(bodyaltContact), required: false);
            WorkflowValue.Validate(bodyaltPhone, nameof(bodyaltPhone), required: false);
            WorkflowValue.Validate(bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            WorkflowValue.Validate(bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            WorkflowValue.Validate(bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            WorkflowValue.Validate(bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            WorkflowValue.Validate(bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            WorkflowValue.Validate(bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            WorkflowValue.Validate(bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            WorkflowValue.Validate(bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            WorkflowValue.Validate(bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            WorkflowValue.Validate(bodybillAddressState, nameof(bodybillAddressState), required: false);
            WorkflowValue.Validate(bodycc, nameof(bodycc), required: false);
            WorkflowValue.Validate(bodyclassRef, nameof(bodyclassRef), required: false);
            WorkflowValue.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            WorkflowValue.Validate(bodycontact, nameof(bodycontact), required: false);
            WorkflowValue.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowValue.Validate(bodycustomerTypeRef, nameof(bodycustomerTypeRef), required: false);
            WorkflowValue.Validate(bodyeditSequence, nameof(bodyeditSequence), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowValue.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodyisActive, nameof(bodyisActive), required: false);
            WorkflowValue.Validate(bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            WorkflowValue.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodylistID, nameof(bodylistID), required: false);
            WorkflowValue.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowValue.Validate(bodyopenBalance, nameof(bodyopenBalance), required: false);
            WorkflowValue.Validate(bodyopenBalanceDate, nameof(bodyopenBalanceDate), required: false);
            WorkflowValue.Validate(bodyparentRef, nameof(bodyparentRef), required: false);
            WorkflowValue.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowValue.Validate(bodypreferredPaymentMethodRef, nameof(bodypreferredPaymentMethodRef), required: false);
            WorkflowValue.Validate(bodypriceLevelRef, nameof(bodypriceLevelRef), required: false);
            WorkflowValue.Validate(bodyresaleNumber, nameof(bodyresaleNumber), required: false);
            WorkflowValue.Validate(bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            WorkflowValue.Validate(bodysalesTaxCodeRef, nameof(bodysalesTaxCodeRef), required: false);
            WorkflowValue.Validate(bodysalutation, nameof(bodysalutation), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            WorkflowValue.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            WorkflowValue.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            WorkflowValue.Validate(bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            WorkflowValue.Validate(bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            WorkflowValue.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            WorkflowValue.Validate(bodytermsRef, nameof(bodytermsRef), required: false);
            return new DeferredBodyAction<QuickBookCreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildQuickBookCreateNewSalesOrder))]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> QuickBookCreateNewSalesOrder([WorkflowExpression] Func<string> bodybillAddressAddr1 = null, [WorkflowExpression] Func<string> bodybillAddressAddr2 = null, [WorkflowExpression] Func<string> bodybillAddressAddr3 = null, [WorkflowExpression] Func<string> bodybillAddressAddr4 = null, [WorkflowExpression] Func<string> bodybillAddressAddr5 = null, [WorkflowExpression] Func<string> bodybillAddressCity = null, [WorkflowExpression] Func<string> bodybillAddressCountry = null, [WorkflowExpression] Func<string> bodybillAddressNote = null, [WorkflowExpression] Func<string> bodybillAddressPostalCode = null, [WorkflowExpression] Func<string> bodybillAddressState = null, [WorkflowExpression] Func<string> bodyclassRef = null, [WorkflowExpression] Func<string> bodycustomerRefListID = null, [WorkflowExpression] Func<string> bodycustomerRefName = null, [WorkflowExpression] Func<string> bodycustomerSalesTaxCodeRef = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyeditSequence = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyitemSalesTaxRef = null, [WorkflowExpression] Func<string> bodylistID = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<string> bodypONumber = null, [WorkflowExpression] Func<string> bodyrefNumber = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem22[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<string> bodysalesRepRef = null, [WorkflowExpression] Func<string> bodyshipAddressAddr1 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr2 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr3 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr4 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr5 = null, [WorkflowExpression] Func<string> bodyshipAddressCity = null, [WorkflowExpression] Func<string> bodyshipAddressCountry = null, [WorkflowExpression] Func<string> bodyshipAddressNote = null, [WorkflowExpression] Func<string> bodyshipAddressPostalCode = null, [WorkflowExpression] Func<string> bodyshipAddressState = null, [WorkflowExpression] Func<string> bodytemplateRef = null, [WorkflowExpression] Func<string> bodytermsRef = null, [WorkflowExpression] Func<string> bodytxnDate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> __BuildQuickBookCreateNewSalesOrder(WorkflowValue<string> bodybillAddressAddr1 = null, WorkflowValue<string> bodybillAddressAddr2 = null, WorkflowValue<string> bodybillAddressAddr3 = null, WorkflowValue<string> bodybillAddressAddr4 = null, WorkflowValue<string> bodybillAddressAddr5 = null, WorkflowValue<string> bodybillAddressCity = null, WorkflowValue<string> bodybillAddressCountry = null, WorkflowValue<string> bodybillAddressNote = null, WorkflowValue<string> bodybillAddressPostalCode = null, WorkflowValue<string> bodybillAddressState = null, WorkflowValue<string> bodyclassRef = null, WorkflowValue<string> bodycustomerRefListID = null, WorkflowValue<string> bodycustomerRefName = null, WorkflowValue<string> bodycustomerSalesTaxCodeRef = null, WorkflowValue<string> bodydueDate = null, WorkflowValue<string> bodyeditSequence = null, WorkflowValue<string> bodyextraField = null, WorkflowValue<string> bodyitemSalesTaxRef = null, WorkflowValue<string> bodylistID = null, WorkflowValue<string> bodymemo = null, WorkflowValue<string> bodypONumber = null, WorkflowValue<string> bodyrefNumber = null, WorkflowValue<bodysalesOrderLineItemInputItem22[]> bodysalesOrderLineItem = null, WorkflowValue<string> bodysalesRepRef = null, WorkflowValue<string> bodyshipAddressAddr1 = null, WorkflowValue<string> bodyshipAddressAddr2 = null, WorkflowValue<string> bodyshipAddressAddr3 = null, WorkflowValue<string> bodyshipAddressAddr4 = null, WorkflowValue<string> bodyshipAddressAddr5 = null, WorkflowValue<string> bodyshipAddressCity = null, WorkflowValue<string> bodyshipAddressCountry = null, WorkflowValue<string> bodyshipAddressNote = null, WorkflowValue<string> bodyshipAddressPostalCode = null, WorkflowValue<string> bodyshipAddressState = null, WorkflowValue<string> bodytemplateRef = null, WorkflowValue<string> bodytermsRef = null, WorkflowValue<string> bodytxnDate = null)
        {
            WorkflowValue.Validate(bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            WorkflowValue.Validate(bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            WorkflowValue.Validate(bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            WorkflowValue.Validate(bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            WorkflowValue.Validate(bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            WorkflowValue.Validate(bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            WorkflowValue.Validate(bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            WorkflowValue.Validate(bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            WorkflowValue.Validate(bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            WorkflowValue.Validate(bodybillAddressState, nameof(bodybillAddressState), required: false);
            WorkflowValue.Validate(bodyclassRef, nameof(bodyclassRef), required: false);
            WorkflowValue.Validate(bodycustomerRefListID, nameof(bodycustomerRefListID), required: false);
            WorkflowValue.Validate(bodycustomerRefName, nameof(bodycustomerRefName), required: false);
            WorkflowValue.Validate(bodycustomerSalesTaxCodeRef, nameof(bodycustomerSalesTaxCodeRef), required: false);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowValue.Validate(bodyeditSequence, nameof(bodyeditSequence), required: false);
            WorkflowValue.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowValue.Validate(bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            WorkflowValue.Validate(bodylistID, nameof(bodylistID), required: false);
            WorkflowValue.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowValue.Validate(bodypONumber, nameof(bodypONumber), required: false);
            WorkflowValue.Validate(bodyrefNumber, nameof(bodyrefNumber), required: false);
            WorkflowValue.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowValue.Validate(bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            WorkflowValue.Validate(bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            WorkflowValue.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            WorkflowValue.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            WorkflowValue.Validate(bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            WorkflowValue.Validate(bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            WorkflowValue.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            WorkflowValue.Validate(bodytemplateRef, nameof(bodytemplateRef), required: false);
            WorkflowValue.Validate(bodytermsRef, nameof(bodytermsRef), required: false);
            WorkflowValue.Validate(bodytxnDate, nameof(bodytxnDate), required: false);
            return new DeferredBodyAction<QuickBookCreateNewSalesOrderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAGE50UKCreateNewCustomer))]
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> SAGE50UKCreateNewCustomer([WorkflowExpression] Func<string> bodyaCCOUNTOPENED = null, [WorkflowExpression] Func<string> bodyaCCOUNTREF = null, [WorkflowExpression] Func<int> bodyaCCOUNTSTATUS = null, [WorkflowExpression] Func<string> bodyaDDRESS1 = null, [WorkflowExpression] Func<string> bodyaDDRESS2 = null, [WorkflowExpression] Func<string> bodyaDDRESS3 = null, [WorkflowExpression] Func<string> bodyaDDRESS4 = null, [WorkflowExpression] Func<string> bodyaDDRESS5 = null, [WorkflowExpression] Func<string> bodyaNALYSIS1 = null, [WorkflowExpression] Func<string> bodyaNALYSIS2 = null, [WorkflowExpression] Func<string> bodyaNALYSIS3 = null, [WorkflowExpression] Func<int> bodyaVERAGEPAYDAYS = null, [WorkflowExpression] Func<int> bodybALANCE = null, [WorkflowExpression] Func<bool> bodycANAPPLYCHARGES = null, [WorkflowExpression] Func<string> bodycONTACTNAME = null, [WorkflowExpression] Func<string> bodycOUNTRYCODE = null, [WorkflowExpression] Func<string> bodycREDITAPPLIEDFOR = null, [WorkflowExpression] Func<int> bodycREDITBUREAU = null, [WorkflowExpression] Func<int> bodycREDITLIMIT = null, [WorkflowExpression] Func<int> bodycREDITPOSITION = null, [WorkflowExpression] Func<string> bodycREDITREFERENCE = null, [WorkflowExpression] Func<int> bodycURRENCY = null, [WorkflowExpression] Func<string> bodydATECREDITAPPRECEIVED = null, [WorkflowExpression] Func<string> bodydEFNOMCODE = null, [WorkflowExpression] Func<int> bodydEFTAXCODE = null, [WorkflowExpression] Func<int> bodydEPTNUMBER = null, [WorkflowExpression] Func<int> bodydISCOUNTRATE = null, [WorkflowExpression] Func<int> bodydISCOUNTTYPE = null, [WorkflowExpression] Func<string> bodydUNSNUMBER = null, [WorkflowExpression] Func<string> bodyeMAIL = null, [WorkflowExpression] Func<string> bodyeMAIL2 = null, [WorkflowExpression] Func<string> bodyeMAIL3 = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyfAX = null, [WorkflowExpression] Func<bool> bodyhOLDMAIL = null, [WorkflowExpression] Func<bool> bodyiNACTIVEFLAG = null, [WorkflowExpression] Func<bool> bodyisACCOUNTREFAutogenerate = null, [WorkflowExpression] Func<string> bodylASTCREDITREV = null, [WorkflowExpression] Func<string> bodynAME = null, [WorkflowExpression] Func<string> bodynEXTCREDITREV = null, [WorkflowExpression] Func<bool> bodyoVERRIDEPRODUCTNOMINAL = null, [WorkflowExpression] Func<bool> bodyoVERRIDEPRODUCTTAX = null, [WorkflowExpression] Func<int> bodypAYMENTDUEDAYS = null, [WorkflowExpression] Func<string> bodypRICELISTREF = null, [WorkflowExpression] Func<bool> bodypRIORITYTRADER = null, [WorkflowExpression] Func<bool> bodysENDINVOICESELECTRONICALLY = null, [WorkflowExpression] Func<bool> bodysENDLETTERSELECTRONICALLY = null, [WorkflowExpression] Func<int> bodysETTLEMENTDISCRATE = null, [WorkflowExpression] Func<int> bodysETTLEMENTDUEDAYS = null, [WorkflowExpression] Func<string> bodytELEPHONE = null, [WorkflowExpression] Func<string> bodytELEPHONE2 = null, [WorkflowExpression] Func<string> bodytERMS = null, [WorkflowExpression] Func<bool> bodytERMSAGREEDFLAG = null, [WorkflowExpression] Func<string> bodytRADECONTACT = null, [WorkflowExpression] Func<string> bodyvATREGNUMBER = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> __BuildSAGE50UKCreateNewCustomer(WorkflowValue<string> bodyaCCOUNTOPENED = null, WorkflowValue<string> bodyaCCOUNTREF = null, WorkflowValue<int> bodyaCCOUNTSTATUS = null, WorkflowValue<string> bodyaDDRESS1 = null, WorkflowValue<string> bodyaDDRESS2 = null, WorkflowValue<string> bodyaDDRESS3 = null, WorkflowValue<string> bodyaDDRESS4 = null, WorkflowValue<string> bodyaDDRESS5 = null, WorkflowValue<string> bodyaNALYSIS1 = null, WorkflowValue<string> bodyaNALYSIS2 = null, WorkflowValue<string> bodyaNALYSIS3 = null, WorkflowValue<int> bodyaVERAGEPAYDAYS = null, WorkflowValue<int> bodybALANCE = null, WorkflowValue<bool> bodycANAPPLYCHARGES = null, WorkflowValue<string> bodycONTACTNAME = null, WorkflowValue<string> bodycOUNTRYCODE = null, WorkflowValue<string> bodycREDITAPPLIEDFOR = null, WorkflowValue<int> bodycREDITBUREAU = null, WorkflowValue<int> bodycREDITLIMIT = null, WorkflowValue<int> bodycREDITPOSITION = null, WorkflowValue<string> bodycREDITREFERENCE = null, WorkflowValue<int> bodycURRENCY = null, WorkflowValue<string> bodydATECREDITAPPRECEIVED = null, WorkflowValue<string> bodydEFNOMCODE = null, WorkflowValue<int> bodydEFTAXCODE = null, WorkflowValue<int> bodydEPTNUMBER = null, WorkflowValue<int> bodydISCOUNTRATE = null, WorkflowValue<int> bodydISCOUNTTYPE = null, WorkflowValue<string> bodydUNSNUMBER = null, WorkflowValue<string> bodyeMAIL = null, WorkflowValue<string> bodyeMAIL2 = null, WorkflowValue<string> bodyeMAIL3 = null, WorkflowValue<string> bodyextraField = null, WorkflowValue<string> bodyfAX = null, WorkflowValue<bool> bodyhOLDMAIL = null, WorkflowValue<bool> bodyiNACTIVEFLAG = null, WorkflowValue<bool> bodyisACCOUNTREFAutogenerate = null, WorkflowValue<string> bodylASTCREDITREV = null, WorkflowValue<string> bodynAME = null, WorkflowValue<string> bodynEXTCREDITREV = null, WorkflowValue<bool> bodyoVERRIDEPRODUCTNOMINAL = null, WorkflowValue<bool> bodyoVERRIDEPRODUCTTAX = null, WorkflowValue<int> bodypAYMENTDUEDAYS = null, WorkflowValue<string> bodypRICELISTREF = null, WorkflowValue<bool> bodypRIORITYTRADER = null, WorkflowValue<bool> bodysENDINVOICESELECTRONICALLY = null, WorkflowValue<bool> bodysENDLETTERSELECTRONICALLY = null, WorkflowValue<int> bodysETTLEMENTDISCRATE = null, WorkflowValue<int> bodysETTLEMENTDUEDAYS = null, WorkflowValue<string> bodytELEPHONE = null, WorkflowValue<string> bodytELEPHONE2 = null, WorkflowValue<string> bodytERMS = null, WorkflowValue<bool> bodytERMSAGREEDFLAG = null, WorkflowValue<string> bodytRADECONTACT = null, WorkflowValue<string> bodyvATREGNUMBER = null)
        {
            WorkflowValue.Validate(bodyaCCOUNTOPENED, nameof(bodyaCCOUNTOPENED), required: false);
            WorkflowValue.Validate(bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            WorkflowValue.Validate(bodyaCCOUNTSTATUS, nameof(bodyaCCOUNTSTATUS), required: false);
            WorkflowValue.Validate(bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            WorkflowValue.Validate(bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            WorkflowValue.Validate(bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            WorkflowValue.Validate(bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            WorkflowValue.Validate(bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            WorkflowValue.Validate(bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            WorkflowValue.Validate(bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            WorkflowValue.Validate(bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            WorkflowValue.Validate(bodyaVERAGEPAYDAYS, nameof(bodyaVERAGEPAYDAYS), required: false);
            WorkflowValue.Validate(bodybALANCE, nameof(bodybALANCE), required: false);
            WorkflowValue.Validate(bodycANAPPLYCHARGES, nameof(bodycANAPPLYCHARGES), required: false);
            WorkflowValue.Validate(bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            WorkflowValue.Validate(bodycOUNTRYCODE, nameof(bodycOUNTRYCODE), required: false);
            WorkflowValue.Validate(bodycREDITAPPLIEDFOR, nameof(bodycREDITAPPLIEDFOR), required: false);
            WorkflowValue.Validate(bodycREDITBUREAU, nameof(bodycREDITBUREAU), required: false);
            WorkflowValue.Validate(bodycREDITLIMIT, nameof(bodycREDITLIMIT), required: false);
            WorkflowValue.Validate(bodycREDITPOSITION, nameof(bodycREDITPOSITION), required: false);
            WorkflowValue.Validate(bodycREDITREFERENCE, nameof(bodycREDITREFERENCE), required: false);
            WorkflowValue.Validate(bodycURRENCY, nameof(bodycURRENCY), required: false);
            WorkflowValue.Validate(bodydATECREDITAPPRECEIVED, nameof(bodydATECREDITAPPRECEIVED), required: false);
            WorkflowValue.Validate(bodydEFNOMCODE, nameof(bodydEFNOMCODE), required: false);
            WorkflowValue.Validate(bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            WorkflowValue.Validate(bodydEPTNUMBER, nameof(bodydEPTNUMBER), required: false);
            WorkflowValue.Validate(bodydISCOUNTRATE, nameof(bodydISCOUNTRATE), required: false);
            WorkflowValue.Validate(bodydISCOUNTTYPE, nameof(bodydISCOUNTTYPE), required: false);
            WorkflowValue.Validate(bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            WorkflowValue.Validate(bodyeMAIL, nameof(bodyeMAIL), required: false);
            WorkflowValue.Validate(bodyeMAIL2, nameof(bodyeMAIL2), required: false);
            WorkflowValue.Validate(bodyeMAIL3, nameof(bodyeMAIL3), required: false);
            WorkflowValue.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowValue.Validate(bodyfAX, nameof(bodyfAX), required: false);
            WorkflowValue.Validate(bodyhOLDMAIL, nameof(bodyhOLDMAIL), required: false);
            WorkflowValue.Validate(bodyiNACTIVEFLAG, nameof(bodyiNACTIVEFLAG), required: false);
            WorkflowValue.Validate(bodyisACCOUNTREFAutogenerate, nameof(bodyisACCOUNTREFAutogenerate), required: false);
            WorkflowValue.Validate(bodylASTCREDITREV, nameof(bodylASTCREDITREV), required: false);
            WorkflowValue.Validate(bodynAME, nameof(bodynAME), required: false);
            WorkflowValue.Validate(bodynEXTCREDITREV, nameof(bodynEXTCREDITREV), required: false);
            WorkflowValue.Validate(bodyoVERRIDEPRODUCTNOMINAL, nameof(bodyoVERRIDEPRODUCTNOMINAL), required: false);
            WorkflowValue.Validate(bodyoVERRIDEPRODUCTTAX, nameof(bodyoVERRIDEPRODUCTTAX), required: false);
            WorkflowValue.Validate(bodypAYMENTDUEDAYS, nameof(bodypAYMENTDUEDAYS), required: false);
            WorkflowValue.Validate(bodypRICELISTREF, nameof(bodypRICELISTREF), required: false);
            WorkflowValue.Validate(bodypRIORITYTRADER, nameof(bodypRIORITYTRADER), required: false);
            WorkflowValue.Validate(bodysENDINVOICESELECTRONICALLY, nameof(bodysENDINVOICESELECTRONICALLY), required: false);
            WorkflowValue.Validate(bodysENDLETTERSELECTRONICALLY, nameof(bodysENDLETTERSELECTRONICALLY), required: false);
            WorkflowValue.Validate(bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            WorkflowValue.Validate(bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            WorkflowValue.Validate(bodytELEPHONE, nameof(bodytELEPHONE), required: false);
            WorkflowValue.Validate(bodytELEPHONE2, nameof(bodytELEPHONE2), required: false);
            WorkflowValue.Validate(bodytERMS, nameof(bodytERMS), required: false);
            WorkflowValue.Validate(bodytERMSAGREEDFLAG, nameof(bodytERMSAGREEDFLAG), required: false);
            WorkflowValue.Validate(bodytRADECONTACT, nameof(bodytRADECONTACT), required: false);
            WorkflowValue.Validate(bodyvATREGNUMBER, nameof(bodyvATREGNUMBER), required: false);
            return new DeferredBodyAction<SAGE50UKCreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAGE50UKCreateNewSalesOrder))]
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> SAGE50UKCreateNewSalesOrder([WorkflowExpression] Func<string> bodyaCCOUNTREF = null, [WorkflowExpression] Func<string> bodyaDDRESS1 = null, [WorkflowExpression] Func<string> bodyaDDRESS2 = null, [WorkflowExpression] Func<string> bodyaDDRESS3 = null, [WorkflowExpression] Func<string> bodyaDDRESS4 = null, [WorkflowExpression] Func<string> bodyaDDRESS5 = null, [WorkflowExpression] Func<int> bodyaMOUNTPREPAID = null, [WorkflowExpression] Func<string> bodyaNALYSIS1 = null, [WorkflowExpression] Func<string> bodyaNALYSIS2 = null, [WorkflowExpression] Func<string> bodyaNALYSIS3 = null, [WorkflowExpression] Func<int> bodycARRDEPTNUMBER = null, [WorkflowExpression] Func<int> bodycARRNET = null, [WorkflowExpression] Func<string> bodycARRNOMCODE = null, [WorkflowExpression] Func<int> bodycARRTAX = null, [WorkflowExpression] Func<int> bodycARRTAXCODE = null, [WorkflowExpression] Func<string> bodycONSIGNMENTREF = null, [WorkflowExpression] Func<string> bodycONTACTNAME = null, [WorkflowExpression] Func<int> bodycOURIER = null, [WorkflowExpression] Func<int> bodycURRENCY = null, [WorkflowExpression] Func<int> bodycUSTDISCRATE = null, [WorkflowExpression] Func<string> bodycUSTORDERNUMBER = null, [WorkflowExpression] Func<string> bodycUSTTELNUMBER = null, [WorkflowExpression] Func<int> bodydEFTAXCODE = null, [WorkflowExpression] Func<bool> bodydELETEDFLAG = null, [WorkflowExpression] Func<string> bodydELIVERYNAME = null, [WorkflowExpression] Func<string> bodydELADDRESS1 = null, [WorkflowExpression] Func<string> bodydELADDRESS2 = null, [WorkflowExpression] Func<string> bodydELADDRESS3 = null, [WorkflowExpression] Func<string> bodydELADDRESS4 = null, [WorkflowExpression] Func<string> bodydELADDRESS5 = null, [WorkflowExpression] Func<string> bodydESPATCHDATE = null, [WorkflowExpression] Func<string> bodydUNSNUMBER = null, [WorkflowExpression] Func<int> bodygLOBALDEPTNUMBER = null, [WorkflowExpression] Func<string> bodygLOBALDETAILS = null, [WorkflowExpression] Func<string> bodygLOBALNOMCODE = null, [WorkflowExpression] Func<int> bodygLOBALTAXCODE = null, [WorkflowExpression] Func<string> bodyiNVOICENUMBER = null, [WorkflowExpression] Func<string> bodynAME = null, [WorkflowExpression] Func<string> bodyoRDERDATE = null, [WorkflowExpression] Func<int> bodyoRDERNUMBER = null, [WorkflowExpression] Func<int> bodyoRDERTYPE = null, [WorkflowExpression] Func<int> bodysETTLEMENTDISCRATE = null, [WorkflowExpression] Func<int> bodysETTLEMENTDUEDAYS = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem222[]> bodysalesOrderLineItem = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> __BuildSAGE50UKCreateNewSalesOrder(WorkflowValue<string> bodyaCCOUNTREF = null, WorkflowValue<string> bodyaDDRESS1 = null, WorkflowValue<string> bodyaDDRESS2 = null, WorkflowValue<string> bodyaDDRESS3 = null, WorkflowValue<string> bodyaDDRESS4 = null, WorkflowValue<string> bodyaDDRESS5 = null, WorkflowValue<int> bodyaMOUNTPREPAID = null, WorkflowValue<string> bodyaNALYSIS1 = null, WorkflowValue<string> bodyaNALYSIS2 = null, WorkflowValue<string> bodyaNALYSIS3 = null, WorkflowValue<int> bodycARRDEPTNUMBER = null, WorkflowValue<int> bodycARRNET = null, WorkflowValue<string> bodycARRNOMCODE = null, WorkflowValue<int> bodycARRTAX = null, WorkflowValue<int> bodycARRTAXCODE = null, WorkflowValue<string> bodycONSIGNMENTREF = null, WorkflowValue<string> bodycONTACTNAME = null, WorkflowValue<int> bodycOURIER = null, WorkflowValue<int> bodycURRENCY = null, WorkflowValue<int> bodycUSTDISCRATE = null, WorkflowValue<string> bodycUSTORDERNUMBER = null, WorkflowValue<string> bodycUSTTELNUMBER = null, WorkflowValue<int> bodydEFTAXCODE = null, WorkflowValue<bool> bodydELETEDFLAG = null, WorkflowValue<string> bodydELIVERYNAME = null, WorkflowValue<string> bodydELADDRESS1 = null, WorkflowValue<string> bodydELADDRESS2 = null, WorkflowValue<string> bodydELADDRESS3 = null, WorkflowValue<string> bodydELADDRESS4 = null, WorkflowValue<string> bodydELADDRESS5 = null, WorkflowValue<string> bodydESPATCHDATE = null, WorkflowValue<string> bodydUNSNUMBER = null, WorkflowValue<int> bodygLOBALDEPTNUMBER = null, WorkflowValue<string> bodygLOBALDETAILS = null, WorkflowValue<string> bodygLOBALNOMCODE = null, WorkflowValue<int> bodygLOBALTAXCODE = null, WorkflowValue<string> bodyiNVOICENUMBER = null, WorkflowValue<string> bodynAME = null, WorkflowValue<string> bodyoRDERDATE = null, WorkflowValue<int> bodyoRDERNUMBER = null, WorkflowValue<int> bodyoRDERTYPE = null, WorkflowValue<int> bodysETTLEMENTDISCRATE = null, WorkflowValue<int> bodysETTLEMENTDUEDAYS = null, WorkflowValue<bodysalesOrderLineItemInputItem222[]> bodysalesOrderLineItem = null)
        {
            WorkflowValue.Validate(bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            WorkflowValue.Validate(bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            WorkflowValue.Validate(bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            WorkflowValue.Validate(bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            WorkflowValue.Validate(bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            WorkflowValue.Validate(bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            WorkflowValue.Validate(bodyaMOUNTPREPAID, nameof(bodyaMOUNTPREPAID), required: false);
            WorkflowValue.Validate(bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            WorkflowValue.Validate(bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            WorkflowValue.Validate(bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            WorkflowValue.Validate(bodycARRDEPTNUMBER, nameof(bodycARRDEPTNUMBER), required: false);
            WorkflowValue.Validate(bodycARRNET, nameof(bodycARRNET), required: false);
            WorkflowValue.Validate(bodycARRNOMCODE, nameof(bodycARRNOMCODE), required: false);
            WorkflowValue.Validate(bodycARRTAX, nameof(bodycARRTAX), required: false);
            WorkflowValue.Validate(bodycARRTAXCODE, nameof(bodycARRTAXCODE), required: false);
            WorkflowValue.Validate(bodycONSIGNMENTREF, nameof(bodycONSIGNMENTREF), required: false);
            WorkflowValue.Validate(bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            WorkflowValue.Validate(bodycOURIER, nameof(bodycOURIER), required: false);
            WorkflowValue.Validate(bodycURRENCY, nameof(bodycURRENCY), required: false);
            WorkflowValue.Validate(bodycUSTDISCRATE, nameof(bodycUSTDISCRATE), required: false);
            WorkflowValue.Validate(bodycUSTORDERNUMBER, nameof(bodycUSTORDERNUMBER), required: false);
            WorkflowValue.Validate(bodycUSTTELNUMBER, nameof(bodycUSTTELNUMBER), required: false);
            WorkflowValue.Validate(bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            WorkflowValue.Validate(bodydELETEDFLAG, nameof(bodydELETEDFLAG), required: false);
            WorkflowValue.Validate(bodydELIVERYNAME, nameof(bodydELIVERYNAME), required: false);
            WorkflowValue.Validate(bodydELADDRESS1, nameof(bodydELADDRESS1), required: false);
            WorkflowValue.Validate(bodydELADDRESS2, nameof(bodydELADDRESS2), required: false);
            WorkflowValue.Validate(bodydELADDRESS3, nameof(bodydELADDRESS3), required: false);
            WorkflowValue.Validate(bodydELADDRESS4, nameof(bodydELADDRESS4), required: false);
            WorkflowValue.Validate(bodydELADDRESS5, nameof(bodydELADDRESS5), required: false);
            WorkflowValue.Validate(bodydESPATCHDATE, nameof(bodydESPATCHDATE), required: false);
            WorkflowValue.Validate(bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            WorkflowValue.Validate(bodygLOBALDEPTNUMBER, nameof(bodygLOBALDEPTNUMBER), required: false);
            WorkflowValue.Validate(bodygLOBALDETAILS, nameof(bodygLOBALDETAILS), required: false);
            WorkflowValue.Validate(bodygLOBALNOMCODE, nameof(bodygLOBALNOMCODE), required: false);
            WorkflowValue.Validate(bodygLOBALTAXCODE, nameof(bodygLOBALTAXCODE), required: false);
            WorkflowValue.Validate(bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            WorkflowValue.Validate(bodynAME, nameof(bodynAME), required: false);
            WorkflowValue.Validate(bodyoRDERDATE, nameof(bodyoRDERDATE), required: false);
            WorkflowValue.Validate(bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            WorkflowValue.Validate(bodyoRDERTYPE, nameof(bodyoRDERTYPE), required: false);
            WorkflowValue.Validate(bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            WorkflowValue.Validate(bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            WorkflowValue.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            return new DeferredBodyAction<SAGE50UKCreateNewSalesOrderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAGE50USCreateNewCustomer))]
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> SAGE50USCreateNewCustomer([WorkflowExpression] Func<string> bodyaccountNumber = null, [WorkflowExpression] Func<string> bodybillingCity = null, [WorkflowExpression] Func<string> bodybillingCountry = null, [WorkflowExpression] Func<string> bodybillingLastName = null, [WorkflowExpression] Func<string> bodybillingName = null, [WorkflowExpression] Func<string> bodybillingPostalCode = null, [WorkflowExpression] Func<string> bodybillingState = null, [WorkflowExpression] Func<string> bodybillingStreet = null, [WorkflowExpression] Func<bool> bodycCSalesRepresentative = null, [WorkflowExpression] Func<bool> bodychargeFinanceCharges = null, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<int> bodycreditLimit = null, [WorkflowExpression] Func<int> bodycreditStatus = null, [WorkflowExpression] Func<string> bodycustomFieldValue1 = null, [WorkflowExpression] Func<string> bodycustomFieldValue2 = null, [WorkflowExpression] Func<string> bodycustomFieldValue3 = null, [WorkflowExpression] Func<string> bodycustomFieldValue4 = null, [WorkflowExpression] Func<string> bodycustomFieldValue5 = null, [WorkflowExpression] Func<string> bodycustomerGUID = null, [WorkflowExpression] Func<string> bodycustomerID = null, [WorkflowExpression] Func<int> bodycustomerBalance = null, [WorkflowExpression] Func<string> bodycustomerSinceDate = null, [WorkflowExpression] Func<string> bodycustomerType = null, [WorkflowExpression] Func<int> bodydiscountDays = null, [WorkflowExpression] Func<int> bodydiscountPercent = null, [WorkflowExpression] Func<int> bodydueDays = null, [WorkflowExpression] Func<string> bodyeMailAddress = null, [WorkflowExpression] Func<string> bodyfaxNumber = null, [WorkflowExpression] Func<int> bodyformDeliveryMethod = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphoneNo1 = null, [WorkflowExpression] Func<string> bodyphoneNo2 = null, [WorkflowExpression] Func<int> bodypricingLevel = null, [WorkflowExpression] Func<string> bodysalesRepresentativeID = null, [WorkflowExpression] Func<string> bodysalesTaxCode = null, [WorkflowExpression] Func<string> bodyshippingCity = null, [WorkflowExpression] Func<string> bodyshippingCountry = null, [WorkflowExpression] Func<string> bodyshippingPostalCode = null, [WorkflowExpression] Func<string> bodyshippingState = null, [WorkflowExpression] Func<string> bodyshippingStreet = null, [WorkflowExpression] Func<bool> bodytermsType = null, [WorkflowExpression] Func<bool> bodyuseCODTerms = null, [WorkflowExpression] Func<bool> bodyuseDueMonthEndTerms = null, [WorkflowExpression] Func<bool> bodyusePrepaidTerms = null, [WorkflowExpression] Func<bool> bodyuseStandardTerms = null, [WorkflowExpression] Func<bool> bodyisInactive = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> __BuildSAGE50USCreateNewCustomer(WorkflowValue<string> bodyaccountNumber = null, WorkflowValue<string> bodybillingCity = null, WorkflowValue<string> bodybillingCountry = null, WorkflowValue<string> bodybillingLastName = null, WorkflowValue<string> bodybillingName = null, WorkflowValue<string> bodybillingPostalCode = null, WorkflowValue<string> bodybillingState = null, WorkflowValue<string> bodybillingStreet = null, WorkflowValue<bool> bodycCSalesRepresentative = null, WorkflowValue<bool> bodychargeFinanceCharges = null, WorkflowValue<string> bodycontactName = null, WorkflowValue<int> bodycreditLimit = null, WorkflowValue<int> bodycreditStatus = null, WorkflowValue<string> bodycustomFieldValue1 = null, WorkflowValue<string> bodycustomFieldValue2 = null, WorkflowValue<string> bodycustomFieldValue3 = null, WorkflowValue<string> bodycustomFieldValue4 = null, WorkflowValue<string> bodycustomFieldValue5 = null, WorkflowValue<string> bodycustomerGUID = null, WorkflowValue<string> bodycustomerID = null, WorkflowValue<int> bodycustomerBalance = null, WorkflowValue<string> bodycustomerSinceDate = null, WorkflowValue<string> bodycustomerType = null, WorkflowValue<int> bodydiscountDays = null, WorkflowValue<int> bodydiscountPercent = null, WorkflowValue<int> bodydueDays = null, WorkflowValue<string> bodyeMailAddress = null, WorkflowValue<string> bodyfaxNumber = null, WorkflowValue<int> bodyformDeliveryMethod = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodyphoneNo1 = null, WorkflowValue<string> bodyphoneNo2 = null, WorkflowValue<int> bodypricingLevel = null, WorkflowValue<string> bodysalesRepresentativeID = null, WorkflowValue<string> bodysalesTaxCode = null, WorkflowValue<string> bodyshippingCity = null, WorkflowValue<string> bodyshippingCountry = null, WorkflowValue<string> bodyshippingPostalCode = null, WorkflowValue<string> bodyshippingState = null, WorkflowValue<string> bodyshippingStreet = null, WorkflowValue<bool> bodytermsType = null, WorkflowValue<bool> bodyuseCODTerms = null, WorkflowValue<bool> bodyuseDueMonthEndTerms = null, WorkflowValue<bool> bodyusePrepaidTerms = null, WorkflowValue<bool> bodyuseStandardTerms = null, WorkflowValue<bool> bodyisInactive = null)
        {
            WorkflowValue.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            WorkflowValue.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            WorkflowValue.Validate(bodybillingCountry, nameof(bodybillingCountry), required: false);
            WorkflowValue.Validate(bodybillingLastName, nameof(bodybillingLastName), required: false);
            WorkflowValue.Validate(bodybillingName, nameof(bodybillingName), required: false);
            WorkflowValue.Validate(bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            WorkflowValue.Validate(bodybillingState, nameof(bodybillingState), required: false);
            WorkflowValue.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            WorkflowValue.Validate(bodycCSalesRepresentative, nameof(bodycCSalesRepresentative), required: false);
            WorkflowValue.Validate(bodychargeFinanceCharges, nameof(bodychargeFinanceCharges), required: false);
            WorkflowValue.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowValue.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowValue.Validate(bodycreditStatus, nameof(bodycreditStatus), required: false);
            WorkflowValue.Validate(bodycustomFieldValue1, nameof(bodycustomFieldValue1), required: false);
            WorkflowValue.Validate(bodycustomFieldValue2, nameof(bodycustomFieldValue2), required: false);
            WorkflowValue.Validate(bodycustomFieldValue3, nameof(bodycustomFieldValue3), required: false);
            WorkflowValue.Validate(bodycustomFieldValue4, nameof(bodycustomFieldValue4), required: false);
            WorkflowValue.Validate(bodycustomFieldValue5, nameof(bodycustomFieldValue5), required: false);
            WorkflowValue.Validate(bodycustomerGUID, nameof(bodycustomerGUID), required: false);
            WorkflowValue.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            WorkflowValue.Validate(bodycustomerBalance, nameof(bodycustomerBalance), required: false);
            WorkflowValue.Validate(bodycustomerSinceDate, nameof(bodycustomerSinceDate), required: false);
            WorkflowValue.Validate(bodycustomerType, nameof(bodycustomerType), required: false);
            WorkflowValue.Validate(bodydiscountDays, nameof(bodydiscountDays), required: false);
            WorkflowValue.Validate(bodydiscountPercent, nameof(bodydiscountPercent), required: false);
            WorkflowValue.Validate(bodydueDays, nameof(bodydueDays), required: false);
            WorkflowValue.Validate(bodyeMailAddress, nameof(bodyeMailAddress), required: false);
            WorkflowValue.Validate(bodyfaxNumber, nameof(bodyfaxNumber), required: false);
            WorkflowValue.Validate(bodyformDeliveryMethod, nameof(bodyformDeliveryMethod), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyphoneNo1, nameof(bodyphoneNo1), required: false);
            WorkflowValue.Validate(bodyphoneNo2, nameof(bodyphoneNo2), required: false);
            WorkflowValue.Validate(bodypricingLevel, nameof(bodypricingLevel), required: false);
            WorkflowValue.Validate(bodysalesRepresentativeID, nameof(bodysalesRepresentativeID), required: false);
            WorkflowValue.Validate(bodysalesTaxCode, nameof(bodysalesTaxCode), required: false);
            WorkflowValue.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            WorkflowValue.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            WorkflowValue.Validate(bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            WorkflowValue.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            WorkflowValue.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            WorkflowValue.Validate(bodytermsType, nameof(bodytermsType), required: false);
            WorkflowValue.Validate(bodyuseCODTerms, nameof(bodyuseCODTerms), required: false);
            WorkflowValue.Validate(bodyuseDueMonthEndTerms, nameof(bodyuseDueMonthEndTerms), required: false);
            WorkflowValue.Validate(bodyusePrepaidTerms, nameof(bodyusePrepaidTerms), required: false);
            WorkflowValue.Validate(bodyuseStandardTerms, nameof(bodyuseStandardTerms), required: false);
            WorkflowValue.Validate(bodyisInactive, nameof(bodyisInactive), required: false);
            return new DeferredBodyAction<SAGE50USCreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAGE50USCreateNewSalesOrder))]
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> SAGE50USCreateNewSalesOrder([WorkflowExpression] Func<string> bodyaccountsReceivableAccount = null, [WorkflowExpression] Func<string> bodyaccountsReceivableAcctGUID = null, [WorkflowExpression] Func<int> bodyaccountsReceivableAmount = null, [WorkflowExpression] Func<bool> bodyclosed = null, [WorkflowExpression] Func<string> bodycustomerID = null, [WorkflowExpression] Func<string> bodycustomerPO = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<int> bodydiscountAmount = null, [WorkflowExpression] Func<string> bodydisplayedTerms = null, [WorkflowExpression] Func<bool> bodydropShip = null, [WorkflowExpression] Func<string> bodygUID = null, [WorkflowExpression] Func<bool> bodynotePrintsAfterLineItems = null, [WorkflowExpression] Func<bool> bodyproposal = null, [WorkflowExpression] Func<bool> bodyproposalAccepted = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem2222[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<string> bodysalesOrderNumber = null, [WorkflowExpression] Func<string> bodysalesRepresentativeGUID = null, [WorkflowExpression] Func<string> bodysalesRepresentativeID = null, [WorkflowExpression] Func<string> bodyshipAddressCity = null, [WorkflowExpression] Func<string> bodyshipAddressCountry = null, [WorkflowExpression] Func<string> bodyshipAddressLine1 = null, [WorkflowExpression] Func<string> bodyshipAddressLine2 = null, [WorkflowExpression] Func<string> bodyshipAddressName = null, [WorkflowExpression] Func<string> bodyshipAddressState = null, [WorkflowExpression] Func<string> bodyshipAddressZipCode = null, [WorkflowExpression] Func<string> bodyshipBy = null, [WorkflowExpression] Func<string> bodyshipVIA = null, [WorkflowExpression] Func<bool> bodystatementNotePrintsBeforeInvRef = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> __BuildSAGE50USCreateNewSalesOrder(WorkflowValue<string> bodyaccountsReceivableAccount = null, WorkflowValue<string> bodyaccountsReceivableAcctGUID = null, WorkflowValue<int> bodyaccountsReceivableAmount = null, WorkflowValue<bool> bodyclosed = null, WorkflowValue<string> bodycustomerID = null, WorkflowValue<string> bodycustomerPO = null, WorkflowValue<string> bodydate = null, WorkflowValue<int> bodydiscountAmount = null, WorkflowValue<string> bodydisplayedTerms = null, WorkflowValue<bool> bodydropShip = null, WorkflowValue<string> bodygUID = null, WorkflowValue<bool> bodynotePrintsAfterLineItems = null, WorkflowValue<bool> bodyproposal = null, WorkflowValue<bool> bodyproposalAccepted = null, WorkflowValue<bodysalesOrderLineItemInputItem2222[]> bodysalesOrderLineItem = null, WorkflowValue<string> bodysalesOrderNumber = null, WorkflowValue<string> bodysalesRepresentativeGUID = null, WorkflowValue<string> bodysalesRepresentativeID = null, WorkflowValue<string> bodyshipAddressCity = null, WorkflowValue<string> bodyshipAddressCountry = null, WorkflowValue<string> bodyshipAddressLine1 = null, WorkflowValue<string> bodyshipAddressLine2 = null, WorkflowValue<string> bodyshipAddressName = null, WorkflowValue<string> bodyshipAddressState = null, WorkflowValue<string> bodyshipAddressZipCode = null, WorkflowValue<string> bodyshipBy = null, WorkflowValue<string> bodyshipVIA = null, WorkflowValue<bool> bodystatementNotePrintsBeforeInvRef = null)
        {
            WorkflowValue.Validate(bodyaccountsReceivableAccount, nameof(bodyaccountsReceivableAccount), required: false);
            WorkflowValue.Validate(bodyaccountsReceivableAcctGUID, nameof(bodyaccountsReceivableAcctGUID), required: false);
            WorkflowValue.Validate(bodyaccountsReceivableAmount, nameof(bodyaccountsReceivableAmount), required: false);
            WorkflowValue.Validate(bodyclosed, nameof(bodyclosed), required: false);
            WorkflowValue.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            WorkflowValue.Validate(bodycustomerPO, nameof(bodycustomerPO), required: false);
            WorkflowValue.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowValue.Validate(bodydiscountAmount, nameof(bodydiscountAmount), required: false);
            WorkflowValue.Validate(bodydisplayedTerms, nameof(bodydisplayedTerms), required: false);
            WorkflowValue.Validate(bodydropShip, nameof(bodydropShip), required: false);
            WorkflowValue.Validate(bodygUID, nameof(bodygUID), required: false);
            WorkflowValue.Validate(bodynotePrintsAfterLineItems, nameof(bodynotePrintsAfterLineItems), required: false);
            WorkflowValue.Validate(bodyproposal, nameof(bodyproposal), required: false);
            WorkflowValue.Validate(bodyproposalAccepted, nameof(bodyproposalAccepted), required: false);
            WorkflowValue.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowValue.Validate(bodysalesOrderNumber, nameof(bodysalesOrderNumber), required: false);
            WorkflowValue.Validate(bodysalesRepresentativeGUID, nameof(bodysalesRepresentativeGUID), required: false);
            WorkflowValue.Validate(bodysalesRepresentativeID, nameof(bodysalesRepresentativeID), required: false);
            WorkflowValue.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            WorkflowValue.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            WorkflowValue.Validate(bodyshipAddressLine1, nameof(bodyshipAddressLine1), required: false);
            WorkflowValue.Validate(bodyshipAddressLine2, nameof(bodyshipAddressLine2), required: false);
            WorkflowValue.Validate(bodyshipAddressName, nameof(bodyshipAddressName), required: false);
            WorkflowValue.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            WorkflowValue.Validate(bodyshipAddressZipCode, nameof(bodyshipAddressZipCode), required: false);
            WorkflowValue.Validate(bodyshipBy, nameof(bodyshipBy), required: false);
            WorkflowValue.Validate(bodyshipVIA, nameof(bodyshipVIA), required: false);
            WorkflowValue.Validate(bodystatementNotePrintsBeforeInvRef, nameof(bodystatementNotePrintsBeforeInvRef), required: false);
            return new DeferredBodyAction<SAGE50USCreateNewSalesOrderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAPB1CreateNewCustomer))]
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> SAPB1CreateNewCustomer([WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodybillingAddressName = null, [WorkflowExpression] Func<string> bodybillingBlock = null, [WorkflowExpression] Func<string> bodybillingCity = null, [WorkflowExpression] Func<string> bodybillingCountry = null, [WorkflowExpression] Func<string> bodybillingState = null, [WorkflowExpression] Func<string> bodybillingStreet = null, [WorkflowExpression] Func<string> bodybillingZipCode = null, [WorkflowExpression] Func<string> bodycardCode = null, [WorkflowExpression] Func<string> bodycardName = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycontactPerson = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyfederalTaxID = null, [WorkflowExpression] Func<string> bodyfreeText = null, [WorkflowExpression] Func<int> bodygroupCode = null, [WorkflowExpression] Func<string> bodymailAddress = null, [WorkflowExpression] Func<string> bodymailCity = null, [WorkflowExpression] Func<string> bodymailCountry = null, [WorkflowExpression] Func<string> bodymailCounty = null, [WorkflowExpression] Func<string> bodymailZipCode = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<int> bodysalesPersonCode = null, [WorkflowExpression] Func<int> bodyseries = null, [WorkflowExpression] Func<string> bodyshippingAddressName = null, [WorkflowExpression] Func<string> bodyshippingBlock = null, [WorkflowExpression] Func<string> bodyshippingCity = null, [WorkflowExpression] Func<string> bodyshippingCountry = null, [WorkflowExpression] Func<string> bodyshippingState = null, [WorkflowExpression] Func<string> bodyshippingStreet = null, [WorkflowExpression] Func<string> bodyshippingZipCode = null, [WorkflowExpression] Func<string> bodywebSite = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<bodylstContactEmployeesInputItem[]> bodylstContactEmployees = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> __BuildSAPB1CreateNewCustomer(WorkflowValue<string> bodyaddress = null, WorkflowValue<string> bodybillingAddressName = null, WorkflowValue<string> bodybillingBlock = null, WorkflowValue<string> bodybillingCity = null, WorkflowValue<string> bodybillingCountry = null, WorkflowValue<string> bodybillingState = null, WorkflowValue<string> bodybillingStreet = null, WorkflowValue<string> bodybillingZipCode = null, WorkflowValue<string> bodycardCode = null, WorkflowValue<string> bodycardName = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodycontactPerson = null, WorkflowValue<string> bodycountry = null, WorkflowValue<string> bodycounty = null, WorkflowValue<string> bodycurrency = null, WorkflowValue<string> bodyemailAddress = null, WorkflowValue<string> bodyextraField = null, WorkflowValue<string> bodyfax = null, WorkflowValue<string> bodyfederalTaxID = null, WorkflowValue<string> bodyfreeText = null, WorkflowValue<int> bodygroupCode = null, WorkflowValue<string> bodymailAddress = null, WorkflowValue<string> bodymailCity = null, WorkflowValue<string> bodymailCountry = null, WorkflowValue<string> bodymailCounty = null, WorkflowValue<string> bodymailZipCode = null, WorkflowValue<string> bodynotes = null, WorkflowValue<string> bodyphone1 = null, WorkflowValue<string> bodyphone2 = null, WorkflowValue<int> bodysalesPersonCode = null, WorkflowValue<int> bodyseries = null, WorkflowValue<string> bodyshippingAddressName = null, WorkflowValue<string> bodyshippingBlock = null, WorkflowValue<string> bodyshippingCity = null, WorkflowValue<string> bodyshippingCountry = null, WorkflowValue<string> bodyshippingState = null, WorkflowValue<string> bodyshippingStreet = null, WorkflowValue<string> bodyshippingZipCode = null, WorkflowValue<string> bodywebSite = null, WorkflowValue<string> bodyzipCode = null, WorkflowValue<bodylstContactEmployeesInputItem[]> bodylstContactEmployees = null)
        {
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowValue.Validate(bodybillingAddressName, nameof(bodybillingAddressName), required: false);
            WorkflowValue.Validate(bodybillingBlock, nameof(bodybillingBlock), required: false);
            WorkflowValue.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            WorkflowValue.Validate(bodybillingCountry, nameof(bodybillingCountry), required: false);
            WorkflowValue.Validate(bodybillingState, nameof(bodybillingState), required: false);
            WorkflowValue.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            WorkflowValue.Validate(bodybillingZipCode, nameof(bodybillingZipCode), required: false);
            WorkflowValue.Validate(bodycardCode, nameof(bodycardCode), required: false);
            WorkflowValue.Validate(bodycardName, nameof(bodycardName), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodycontactPerson, nameof(bodycontactPerson), required: false);
            WorkflowValue.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowValue.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowValue.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowValue.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowValue.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowValue.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowValue.Validate(bodyfederalTaxID, nameof(bodyfederalTaxID), required: false);
            WorkflowValue.Validate(bodyfreeText, nameof(bodyfreeText), required: false);
            WorkflowValue.Validate(bodygroupCode, nameof(bodygroupCode), required: false);
            WorkflowValue.Validate(bodymailAddress, nameof(bodymailAddress), required: false);
            WorkflowValue.Validate(bodymailCity, nameof(bodymailCity), required: false);
            WorkflowValue.Validate(bodymailCountry, nameof(bodymailCountry), required: false);
            WorkflowValue.Validate(bodymailCounty, nameof(bodymailCounty), required: false);
            WorkflowValue.Validate(bodymailZipCode, nameof(bodymailZipCode), required: false);
            WorkflowValue.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowValue.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowValue.Validate(bodyphone2, nameof(bodyphone2), required: false);
            WorkflowValue.Validate(bodysalesPersonCode, nameof(bodysalesPersonCode), required: false);
            WorkflowValue.Validate(bodyseries, nameof(bodyseries), required: false);
            WorkflowValue.Validate(bodyshippingAddressName, nameof(bodyshippingAddressName), required: false);
            WorkflowValue.Validate(bodyshippingBlock, nameof(bodyshippingBlock), required: false);
            WorkflowValue.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            WorkflowValue.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            WorkflowValue.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            WorkflowValue.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            WorkflowValue.Validate(bodyshippingZipCode, nameof(bodyshippingZipCode), required: false);
            WorkflowValue.Validate(bodywebSite, nameof(bodywebSite), required: false);
            WorkflowValue.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowValue.Validate(bodylstContactEmployees, nameof(bodylstContactEmployees), required: false);
            return new DeferredBodyAction<SAPB1CreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSAPB1CreateNewSalesOrder))]
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> SAPB1CreateNewSalesOrder([WorkflowExpression] Func<string> bodycardCode = null, [WorkflowExpression] Func<string> bodydocDate = null, [WorkflowExpression] Func<string> bodydocDueDate = null, [WorkflowExpression] Func<int> bodydocNum = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem22222[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<int> bodyseries = null, [WorkflowExpression] Func<string> bodytaxDate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> __BuildSAPB1CreateNewSalesOrder(WorkflowValue<string> bodycardCode = null, WorkflowValue<string> bodydocDate = null, WorkflowValue<string> bodydocDueDate = null, WorkflowValue<int> bodydocNum = null, WorkflowValue<bodysalesOrderLineItemInputItem22222[]> bodysalesOrderLineItem = null, WorkflowValue<int> bodyseries = null, WorkflowValue<string> bodytaxDate = null)
        {
            WorkflowValue.Validate(bodycardCode, nameof(bodycardCode), required: false);
            WorkflowValue.Validate(bodydocDate, nameof(bodydocDate), required: false);
            WorkflowValue.Validate(bodydocDueDate, nameof(bodydocDueDate), required: false);
            WorkflowValue.Validate(bodydocNum, nameof(bodydocNum), required: false);
            WorkflowValue.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowValue.Validate(bodyseries, nameof(bodyseries), required: false);
            WorkflowValue.Validate(bodytaxDate, nameof(bodytaxDate), required: false);
            return new DeferredBodyAction<SAPB1CreateNewSalesOrderResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSYSPROCreateNewCustomer))]
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> SYSPROCreateNewCustomer([WorkflowExpression] Func<string> bodyaddTelephone = null, [WorkflowExpression] Func<string> bodyaltMethodFlag = null, [WorkflowExpression] Func<string> bodyapplyLineDisc = null, [WorkflowExpression] Func<string> bodyapplyOrdDisc = null, [WorkflowExpression] Func<string> bodyarStatementNo = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodybackOrdReqd = null, [WorkflowExpression] Func<string> bodybalanceType = null, [WorkflowExpression] Func<string> bodybranch = null, [WorkflowExpression] Func<string> bodybuyingGroup1 = null, [WorkflowExpression] Func<string> bodybuyingGroup2 = null, [WorkflowExpression] Func<string> bodybuyingGroup3 = null, [WorkflowExpression] Func<string> bodybuyingGroup4 = null, [WorkflowExpression] Func<string> bodybuyingGroup5 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycity1 = null, [WorkflowExpression] Func<string> bodycompanyTaxNumber = null, [WorkflowExpression] Func<string> bodycontact = null, [WorkflowExpression] Func<string> bodycontractPrcReqd = null, [WorkflowExpression] Func<string> bodycounterSlsOnly = null, [WorkflowExpression] Func<string> bodycountyZip = null, [WorkflowExpression] Func<string> bodycountyZip1 = null, [WorkflowExpression] Func<string> bodycreditCheckFlag = null, [WorkflowExpression] Func<string> bodycreditLimit = null, [WorkflowExpression] Func<string> bodycreditStatus = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodycustomerClass = null, [WorkflowExpression] Func<string> bodycustomerCode = null, [WorkflowExpression] Func<string> bodycustomerOnHold = null, [WorkflowExpression] Func<string> bodydateCustAdded = null, [WorkflowExpression] Func<string> bodydefaultOrdType = null, [WorkflowExpression] Func<string> bodydeliveryTerms = null, [WorkflowExpression] Func<string> bodydeliveryTermsC = null, [WorkflowExpression] Func<string> bodydetailMoveReqd = null, [WorkflowExpression] Func<string> bodydocFax = null, [WorkflowExpression] Func<string> bodydocFaxContact = null, [WorkflowExpression] Func<string> bodyediFlag = null, [WorkflowExpression] Func<string> bodyediSenderCode = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyexemptFinChg = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyfaxInvoices = null, [WorkflowExpression] Func<string> bodyfaxQuotes = null, [WorkflowExpression] Func<string> bodyfaxStatements = null, [WorkflowExpression] Func<string> bodygstExemptFlag = null, [WorkflowExpression] Func<string> bodygstExemptNum = null, [WorkflowExpression] Func<string> bodygstLevel = null, [WorkflowExpression] Func<string> bodyhighInv = null, [WorkflowExpression] Func<string> bodyhighInvDays = null, [WorkflowExpression] Func<string> bodyhighestBalance = null, [WorkflowExpression] Func<string> bodyibtCustomer = null, [WorkflowExpression] Func<string> bodyinvCommentCode = null, [WorkflowExpression] Func<string> bodyinvDiscCode = null, [WorkflowExpression] Func<string> bodylanguageCode = null, [WorkflowExpression] Func<string> bodylineDiscCode = null, [WorkflowExpression] Func<string> bodymaintHistory = null, [WorkflowExpression] Func<string> bodymaintLastPrcPaid = null, [WorkflowExpression] Func<string> bodyminimumOrderChgCod = null, [WorkflowExpression] Func<string> bodyminimumOrderValue = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodynewCustomerCode = null, [WorkflowExpression] Func<string> bodypoNumberMandatory = null, [WorkflowExpression] Func<string> bodypriceCategoryTable = null, [WorkflowExpression] Func<string> bodypriceCode = null, [WorkflowExpression] Func<string> bodyrouteCode = null, [WorkflowExpression] Func<string> bodyrouteDistance = null, [WorkflowExpression] Func<string> bodysalesWarehouse = null, [WorkflowExpression] Func<string> bodysalesperson = null, [WorkflowExpression] Func<string> bodysalesperson1 = null, [WorkflowExpression] Func<string> bodysalesperson2 = null, [WorkflowExpression] Func<string> bodysalesperson3 = null, [WorkflowExpression] Func<string> bodyshipPostalCode = null, [WorkflowExpression] Func<string> bodyshipToAddr1 = null, [WorkflowExpression] Func<string> bodyshipToAddr2 = null, [WorkflowExpression] Func<string> bodyshipToAddr3 = null, [WorkflowExpression] Func<string> bodyshipToAddr3Loc = null, [WorkflowExpression] Func<string> bodyshipToAddr4 = null, [WorkflowExpression] Func<string> bodyshipToAddr5 = null, [WorkflowExpression] Func<string> bodyshipToGpsLat = null, [WorkflowExpression] Func<string> bodyshipToGpsLong = null, [WorkflowExpression] Func<string> bodyshippingInstrs = null, [WorkflowExpression] Func<string> bodyshippingInstrsCod = null, [WorkflowExpression] Func<string> bodyshippingLocation = null, [WorkflowExpression] Func<string> bodyshortName = null, [WorkflowExpression] Func<string> bodysoDefaultDoc = null, [WorkflowExpression] Func<string> bodysoDefaultType = null, [WorkflowExpression] Func<string> bodysoldPostalCode = null, [WorkflowExpression] Func<string> bodysoldToAddr1 = null, [WorkflowExpression] Func<string> bodysoldToAddr2 = null, [WorkflowExpression] Func<string> bodysoldToAddr3 = null, [WorkflowExpression] Func<string> bodysoldToAddr3Loc = null, [WorkflowExpression] Func<string> bodysoldToAddr4 = null, [WorkflowExpression] Func<string> bodysoldToAddr5 = null, [WorkflowExpression] Func<string> bodysoldToGpsLat = null, [WorkflowExpression] Func<string> bodysoldToGpsLong = null, [WorkflowExpression] Func<string> bodyspecialInstrs = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodystate1 = null, [WorkflowExpression] Func<string> bodystateCode = null, [WorkflowExpression] Func<string> bodystatementReqd = null, [WorkflowExpression] Func<string> bodystockInterchange = null, [WorkflowExpression] Func<string> bodytagsToDropFromXML = null, [WorkflowExpression] Func<string> bodytaxExemptNumber = null, [WorkflowExpression] Func<string> bodytaxStatus = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<string> bodytelephoneExtn = null, [WorkflowExpression] Func<string> bodytelex = null, [WorkflowExpression] Func<string> bodytermsCode = null, [WorkflowExpression] Func<string> bodytpmCreditCheck = null, [WorkflowExpression] Func<string> bodytpmCustomerFlag = null, [WorkflowExpression] Func<string> bodytpmPricingFlag = null, [WorkflowExpression] Func<string> bodytransactionNature = null, [WorkflowExpression] Func<string> bodytransactionNatureC = null, [WorkflowExpression] Func<string> bodyukCurrency = null, [WorkflowExpression] Func<string> bodyukVatFlag = null, [WorkflowExpression] Func<string> bodyuserField1 = null, [WorkflowExpression] Func<string> bodyuserField2 = null, [WorkflowExpression] Func<string> bodywholeOrderShipFlag = null, [WorkflowExpression] Func<string> bodyeSignature = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> __BuildSYSPROCreateNewCustomer(WorkflowValue<string> bodyaddTelephone = null, WorkflowValue<string> bodyaltMethodFlag = null, WorkflowValue<string> bodyapplyLineDisc = null, WorkflowValue<string> bodyapplyOrdDisc = null, WorkflowValue<string> bodyarStatementNo = null, WorkflowValue<string> bodyarea = null, WorkflowValue<string> bodybackOrdReqd = null, WorkflowValue<string> bodybalanceType = null, WorkflowValue<string> bodybranch = null, WorkflowValue<string> bodybuyingGroup1 = null, WorkflowValue<string> bodybuyingGroup2 = null, WorkflowValue<string> bodybuyingGroup3 = null, WorkflowValue<string> bodybuyingGroup4 = null, WorkflowValue<string> bodybuyingGroup5 = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodycity1 = null, WorkflowValue<string> bodycompanyTaxNumber = null, WorkflowValue<string> bodycontact = null, WorkflowValue<string> bodycontractPrcReqd = null, WorkflowValue<string> bodycounterSlsOnly = null, WorkflowValue<string> bodycountyZip = null, WorkflowValue<string> bodycountyZip1 = null, WorkflowValue<string> bodycreditCheckFlag = null, WorkflowValue<string> bodycreditLimit = null, WorkflowValue<string> bodycreditStatus = null, WorkflowValue<string> bodycurrency = null, WorkflowValue<string> bodycustomerClass = null, WorkflowValue<string> bodycustomerCode = null, WorkflowValue<string> bodycustomerOnHold = null, WorkflowValue<string> bodydateCustAdded = null, WorkflowValue<string> bodydefaultOrdType = null, WorkflowValue<string> bodydeliveryTerms = null, WorkflowValue<string> bodydeliveryTermsC = null, WorkflowValue<string> bodydetailMoveReqd = null, WorkflowValue<string> bodydocFax = null, WorkflowValue<string> bodydocFaxContact = null, WorkflowValue<string> bodyediFlag = null, WorkflowValue<string> bodyediSenderCode = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyexemptFinChg = null, WorkflowValue<string> bodyfax = null, WorkflowValue<string> bodyfaxInvoices = null, WorkflowValue<string> bodyfaxQuotes = null, WorkflowValue<string> bodyfaxStatements = null, WorkflowValue<string> bodygstExemptFlag = null, WorkflowValue<string> bodygstExemptNum = null, WorkflowValue<string> bodygstLevel = null, WorkflowValue<string> bodyhighInv = null, WorkflowValue<string> bodyhighInvDays = null, WorkflowValue<string> bodyhighestBalance = null, WorkflowValue<string> bodyibtCustomer = null, WorkflowValue<string> bodyinvCommentCode = null, WorkflowValue<string> bodyinvDiscCode = null, WorkflowValue<string> bodylanguageCode = null, WorkflowValue<string> bodylineDiscCode = null, WorkflowValue<string> bodymaintHistory = null, WorkflowValue<string> bodymaintLastPrcPaid = null, WorkflowValue<string> bodyminimumOrderChgCod = null, WorkflowValue<string> bodyminimumOrderValue = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodynationality = null, WorkflowValue<string> bodynewCustomerCode = null, WorkflowValue<string> bodypoNumberMandatory = null, WorkflowValue<string> bodypriceCategoryTable = null, WorkflowValue<string> bodypriceCode = null, WorkflowValue<string> bodyrouteCode = null, WorkflowValue<string> bodyrouteDistance = null, WorkflowValue<string> bodysalesWarehouse = null, WorkflowValue<string> bodysalesperson = null, WorkflowValue<string> bodysalesperson1 = null, WorkflowValue<string> bodysalesperson2 = null, WorkflowValue<string> bodysalesperson3 = null, WorkflowValue<string> bodyshipPostalCode = null, WorkflowValue<string> bodyshipToAddr1 = null, WorkflowValue<string> bodyshipToAddr2 = null, WorkflowValue<string> bodyshipToAddr3 = null, WorkflowValue<string> bodyshipToAddr3Loc = null, WorkflowValue<string> bodyshipToAddr4 = null, WorkflowValue<string> bodyshipToAddr5 = null, WorkflowValue<string> bodyshipToGpsLat = null, WorkflowValue<string> bodyshipToGpsLong = null, WorkflowValue<string> bodyshippingInstrs = null, WorkflowValue<string> bodyshippingInstrsCod = null, WorkflowValue<string> bodyshippingLocation = null, WorkflowValue<string> bodyshortName = null, WorkflowValue<string> bodysoDefaultDoc = null, WorkflowValue<string> bodysoDefaultType = null, WorkflowValue<string> bodysoldPostalCode = null, WorkflowValue<string> bodysoldToAddr1 = null, WorkflowValue<string> bodysoldToAddr2 = null, WorkflowValue<string> bodysoldToAddr3 = null, WorkflowValue<string> bodysoldToAddr3Loc = null, WorkflowValue<string> bodysoldToAddr4 = null, WorkflowValue<string> bodysoldToAddr5 = null, WorkflowValue<string> bodysoldToGpsLat = null, WorkflowValue<string> bodysoldToGpsLong = null, WorkflowValue<string> bodyspecialInstrs = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodystate1 = null, WorkflowValue<string> bodystateCode = null, WorkflowValue<string> bodystatementReqd = null, WorkflowValue<string> bodystockInterchange = null, WorkflowValue<string> bodytagsToDropFromXML = null, WorkflowValue<string> bodytaxExemptNumber = null, WorkflowValue<string> bodytaxStatus = null, WorkflowValue<string> bodytelephone = null, WorkflowValue<string> bodytelephoneExtn = null, WorkflowValue<string> bodytelex = null, WorkflowValue<string> bodytermsCode = null, WorkflowValue<string> bodytpmCreditCheck = null, WorkflowValue<string> bodytpmCustomerFlag = null, WorkflowValue<string> bodytpmPricingFlag = null, WorkflowValue<string> bodytransactionNature = null, WorkflowValue<string> bodytransactionNatureC = null, WorkflowValue<string> bodyukCurrency = null, WorkflowValue<string> bodyukVatFlag = null, WorkflowValue<string> bodyuserField1 = null, WorkflowValue<string> bodyuserField2 = null, WorkflowValue<string> bodywholeOrderShipFlag = null, WorkflowValue<string> bodyeSignature = null)
        {
            WorkflowValue.Validate(bodyaddTelephone, nameof(bodyaddTelephone), required: false);
            WorkflowValue.Validate(bodyaltMethodFlag, nameof(bodyaltMethodFlag), required: false);
            WorkflowValue.Validate(bodyapplyLineDisc, nameof(bodyapplyLineDisc), required: false);
            WorkflowValue.Validate(bodyapplyOrdDisc, nameof(bodyapplyOrdDisc), required: false);
            WorkflowValue.Validate(bodyarStatementNo, nameof(bodyarStatementNo), required: false);
            WorkflowValue.Validate(bodyarea, nameof(bodyarea), required: false);
            WorkflowValue.Validate(bodybackOrdReqd, nameof(bodybackOrdReqd), required: false);
            WorkflowValue.Validate(bodybalanceType, nameof(bodybalanceType), required: false);
            WorkflowValue.Validate(bodybranch, nameof(bodybranch), required: false);
            WorkflowValue.Validate(bodybuyingGroup1, nameof(bodybuyingGroup1), required: false);
            WorkflowValue.Validate(bodybuyingGroup2, nameof(bodybuyingGroup2), required: false);
            WorkflowValue.Validate(bodybuyingGroup3, nameof(bodybuyingGroup3), required: false);
            WorkflowValue.Validate(bodybuyingGroup4, nameof(bodybuyingGroup4), required: false);
            WorkflowValue.Validate(bodybuyingGroup5, nameof(bodybuyingGroup5), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodycity1, nameof(bodycity1), required: false);
            WorkflowValue.Validate(bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            WorkflowValue.Validate(bodycontact, nameof(bodycontact), required: false);
            WorkflowValue.Validate(bodycontractPrcReqd, nameof(bodycontractPrcReqd), required: false);
            WorkflowValue.Validate(bodycounterSlsOnly, nameof(bodycounterSlsOnly), required: false);
            WorkflowValue.Validate(bodycountyZip, nameof(bodycountyZip), required: false);
            WorkflowValue.Validate(bodycountyZip1, nameof(bodycountyZip1), required: false);
            WorkflowValue.Validate(bodycreditCheckFlag, nameof(bodycreditCheckFlag), required: false);
            WorkflowValue.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowValue.Validate(bodycreditStatus, nameof(bodycreditStatus), required: false);
            WorkflowValue.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowValue.Validate(bodycustomerClass, nameof(bodycustomerClass), required: false);
            WorkflowValue.Validate(bodycustomerCode, nameof(bodycustomerCode), required: false);
            WorkflowValue.Validate(bodycustomerOnHold, nameof(bodycustomerOnHold), required: false);
            WorkflowValue.Validate(bodydateCustAdded, nameof(bodydateCustAdded), required: false);
            WorkflowValue.Validate(bodydefaultOrdType, nameof(bodydefaultOrdType), required: false);
            WorkflowValue.Validate(bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            WorkflowValue.Validate(bodydeliveryTermsC, nameof(bodydeliveryTermsC), required: false);
            WorkflowValue.Validate(bodydetailMoveReqd, nameof(bodydetailMoveReqd), required: false);
            WorkflowValue.Validate(bodydocFax, nameof(bodydocFax), required: false);
            WorkflowValue.Validate(bodydocFaxContact, nameof(bodydocFaxContact), required: false);
            WorkflowValue.Validate(bodyediFlag, nameof(bodyediFlag), required: false);
            WorkflowValue.Validate(bodyediSenderCode, nameof(bodyediSenderCode), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyexemptFinChg, nameof(bodyexemptFinChg), required: false);
            WorkflowValue.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowValue.Validate(bodyfaxInvoices, nameof(bodyfaxInvoices), required: false);
            WorkflowValue.Validate(bodyfaxQuotes, nameof(bodyfaxQuotes), required: false);
            WorkflowValue.Validate(bodyfaxStatements, nameof(bodyfaxStatements), required: false);
            WorkflowValue.Validate(bodygstExemptFlag, nameof(bodygstExemptFlag), required: false);
            WorkflowValue.Validate(bodygstExemptNum, nameof(bodygstExemptNum), required: false);
            WorkflowValue.Validate(bodygstLevel, nameof(bodygstLevel), required: false);
            WorkflowValue.Validate(bodyhighInv, nameof(bodyhighInv), required: false);
            WorkflowValue.Validate(bodyhighInvDays, nameof(bodyhighInvDays), required: false);
            WorkflowValue.Validate(bodyhighestBalance, nameof(bodyhighestBalance), required: false);
            WorkflowValue.Validate(bodyibtCustomer, nameof(bodyibtCustomer), required: false);
            WorkflowValue.Validate(bodyinvCommentCode, nameof(bodyinvCommentCode), required: false);
            WorkflowValue.Validate(bodyinvDiscCode, nameof(bodyinvDiscCode), required: false);
            WorkflowValue.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            WorkflowValue.Validate(bodylineDiscCode, nameof(bodylineDiscCode), required: false);
            WorkflowValue.Validate(bodymaintHistory, nameof(bodymaintHistory), required: false);
            WorkflowValue.Validate(bodymaintLastPrcPaid, nameof(bodymaintLastPrcPaid), required: false);
            WorkflowValue.Validate(bodyminimumOrderChgCod, nameof(bodyminimumOrderChgCod), required: false);
            WorkflowValue.Validate(bodyminimumOrderValue, nameof(bodyminimumOrderValue), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowValue.Validate(bodynewCustomerCode, nameof(bodynewCustomerCode), required: false);
            WorkflowValue.Validate(bodypoNumberMandatory, nameof(bodypoNumberMandatory), required: false);
            WorkflowValue.Validate(bodypriceCategoryTable, nameof(bodypriceCategoryTable), required: false);
            WorkflowValue.Validate(bodypriceCode, nameof(bodypriceCode), required: false);
            WorkflowValue.Validate(bodyrouteCode, nameof(bodyrouteCode), required: false);
            WorkflowValue.Validate(bodyrouteDistance, nameof(bodyrouteDistance), required: false);
            WorkflowValue.Validate(bodysalesWarehouse, nameof(bodysalesWarehouse), required: false);
            WorkflowValue.Validate(bodysalesperson, nameof(bodysalesperson), required: false);
            WorkflowValue.Validate(bodysalesperson1, nameof(bodysalesperson1), required: false);
            WorkflowValue.Validate(bodysalesperson2, nameof(bodysalesperson2), required: false);
            WorkflowValue.Validate(bodysalesperson3, nameof(bodysalesperson3), required: false);
            WorkflowValue.Validate(bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            WorkflowValue.Validate(bodyshipToAddr1, nameof(bodyshipToAddr1), required: false);
            WorkflowValue.Validate(bodyshipToAddr2, nameof(bodyshipToAddr2), required: false);
            WorkflowValue.Validate(bodyshipToAddr3, nameof(bodyshipToAddr3), required: false);
            WorkflowValue.Validate(bodyshipToAddr3Loc, nameof(bodyshipToAddr3Loc), required: false);
            WorkflowValue.Validate(bodyshipToAddr4, nameof(bodyshipToAddr4), required: false);
            WorkflowValue.Validate(bodyshipToAddr5, nameof(bodyshipToAddr5), required: false);
            WorkflowValue.Validate(bodyshipToGpsLat, nameof(bodyshipToGpsLat), required: false);
            WorkflowValue.Validate(bodyshipToGpsLong, nameof(bodyshipToGpsLong), required: false);
            WorkflowValue.Validate(bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            WorkflowValue.Validate(bodyshippingInstrsCod, nameof(bodyshippingInstrsCod), required: false);
            WorkflowValue.Validate(bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            WorkflowValue.Validate(bodyshortName, nameof(bodyshortName), required: false);
            WorkflowValue.Validate(bodysoDefaultDoc, nameof(bodysoDefaultDoc), required: false);
            WorkflowValue.Validate(bodysoDefaultType, nameof(bodysoDefaultType), required: false);
            WorkflowValue.Validate(bodysoldPostalCode, nameof(bodysoldPostalCode), required: false);
            WorkflowValue.Validate(bodysoldToAddr1, nameof(bodysoldToAddr1), required: false);
            WorkflowValue.Validate(bodysoldToAddr2, nameof(bodysoldToAddr2), required: false);
            WorkflowValue.Validate(bodysoldToAddr3, nameof(bodysoldToAddr3), required: false);
            WorkflowValue.Validate(bodysoldToAddr3Loc, nameof(bodysoldToAddr3Loc), required: false);
            WorkflowValue.Validate(bodysoldToAddr4, nameof(bodysoldToAddr4), required: false);
            WorkflowValue.Validate(bodysoldToAddr5, nameof(bodysoldToAddr5), required: false);
            WorkflowValue.Validate(bodysoldToGpsLat, nameof(bodysoldToGpsLat), required: false);
            WorkflowValue.Validate(bodysoldToGpsLong, nameof(bodysoldToGpsLong), required: false);
            WorkflowValue.Validate(bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodystate1, nameof(bodystate1), required: false);
            WorkflowValue.Validate(bodystateCode, nameof(bodystateCode), required: false);
            WorkflowValue.Validate(bodystatementReqd, nameof(bodystatementReqd), required: false);
            WorkflowValue.Validate(bodystockInterchange, nameof(bodystockInterchange), required: false);
            WorkflowValue.Validate(bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            WorkflowValue.Validate(bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            WorkflowValue.Validate(bodytaxStatus, nameof(bodytaxStatus), required: false);
            WorkflowValue.Validate(bodytelephone, nameof(bodytelephone), required: false);
            WorkflowValue.Validate(bodytelephoneExtn, nameof(bodytelephoneExtn), required: false);
            WorkflowValue.Validate(bodytelex, nameof(bodytelex), required: false);
            WorkflowValue.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            WorkflowValue.Validate(bodytpmCreditCheck, nameof(bodytpmCreditCheck), required: false);
            WorkflowValue.Validate(bodytpmCustomerFlag, nameof(bodytpmCustomerFlag), required: false);
            WorkflowValue.Validate(bodytpmPricingFlag, nameof(bodytpmPricingFlag), required: false);
            WorkflowValue.Validate(bodytransactionNature, nameof(bodytransactionNature), required: false);
            WorkflowValue.Validate(bodytransactionNatureC, nameof(bodytransactionNatureC), required: false);
            WorkflowValue.Validate(bodyukCurrency, nameof(bodyukCurrency), required: false);
            WorkflowValue.Validate(bodyukVatFlag, nameof(bodyukVatFlag), required: false);
            WorkflowValue.Validate(bodyuserField1, nameof(bodyuserField1), required: false);
            WorkflowValue.Validate(bodyuserField2, nameof(bodyuserField2), required: false);
            WorkflowValue.Validate(bodywholeOrderShipFlag, nameof(bodywholeOrderShipFlag), required: false);
            WorkflowValue.Validate(bodyeSignature, nameof(bodyeSignature), required: false);
            return new DeferredBodyAction<SYSPROCreateNewCustomerResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        [WorkflowExpressionFactory(nameof(__BuildSYSPROCreateNewSalesOrder))]
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> SYSPROCreateNewSalesOrder([WorkflowExpression] Func<string> bodyacceptEarlierShipDate = null, [WorkflowExpression] Func<string> bodyacceptKitOptional = null, [WorkflowExpression] Func<string> bodyacceptOrdersIfNoCredit = null, [WorkflowExpression] Func<string> bodyaddAttachedServiceCharges = null, [WorkflowExpression] Func<string> bodyaddDangerousGoodsText = null, [WorkflowExpression] Func<string> bodyaddStockSalesOrderText = null, [WorkflowExpression] Func<string> bodyallocationAction = null, [WorkflowExpression] Func<string> bodyallowBackOrderForNegativeMerchLine = null, [WorkflowExpression] Func<string> bodyallowBackOrderForPartialHold = null, [WorkflowExpression] Func<string> bodyallowBackOrderForSuperseded = null, [WorkflowExpression] Func<string> bodyallowChangeToZeroPrice = null, [WorkflowExpression] Func<string> bodyallowDuplicateOrderNumbers = null, [WorkflowExpression] Func<string> bodyallowManualOrderNumberToBeUsed = null, [WorkflowExpression] Func<string> bodyallowNonStockItems = null, [WorkflowExpression] Func<string> bodyallowZeroPrice = null, [WorkflowExpression] Func<string> bodyalternateReference = null, [WorkflowExpression] Func<string> bodyalwaysUsePriceEntered = null, [WorkflowExpression] Func<string> bodyapplyLeadTimeCalculation = null, [WorkflowExpression] Func<string> bodyapplyParentDiscountToComponents = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodybranch = null, [WorkflowExpression] Func<string> bodycancelReasonCode = null, [WorkflowExpression] Func<string> bodycheckForCustomerPoNumbers = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycompanyTaxNumber = null, [WorkflowExpression] Func<string> bodycountyZip = null, [WorkflowExpression] Func<string> bodycreditFailMessage = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodycustomer = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodycustomerPoNumber = null, [WorkflowExpression] Func<string> bodycustomerToUse = null, [WorkflowExpression] Func<string> bodydeliveryRoute = null, [WorkflowExpression] Func<string> bodydeliveryRouteAction = null, [WorkflowExpression] Func<string> bodydeliveryTerms = null, [WorkflowExpression] Func<string> bodydocumentFormat = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyglobalTradePromotionCodes = null, [WorkflowExpression] Func<string> bodygstExemptNumber = null, [WorkflowExpression] Func<string> bodygstExemptionStatus = null, [WorkflowExpression] Func<string> bodyheaderFreightCharges = null, [WorkflowExpression] Func<string> bodyheaderMiscCharges = null, [WorkflowExpression] Func<string> bodyignoreWarnings = null, [WorkflowExpression] Func<string> bodyinBoxMsgReqd = null, [WorkflowExpression] Func<string> bodyincludeInMrp = null, [WorkflowExpression] Func<string> bodyinvoiceDateEntered = null, [WorkflowExpression] Func<string> bodyinvoiceNumberEntered = null, [WorkflowExpression] Func<string> bodyinvoiceTerms = null, [WorkflowExpression] Func<string> bodyinvoiceWholeOrderOnly = null, [WorkflowExpression] Func<string> bodylanguageCode = null, [WorkflowExpression] Func<string> bodyminimumDaysToShip = null, [WorkflowExpression] Func<string> bodymultiShipCode = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodynewCustomerPoNumber = null, [WorkflowExpression] Func<string> bodynewSalesOrderNumber = null, [WorkflowExpression] Func<string> bodyoperatorToInform = null, [WorkflowExpression] Func<string> bodyorderActionType = null, [WorkflowExpression] Func<string> bodyorderComments = null, [WorkflowExpression] Func<string> bodyorderDate = null, [WorkflowExpression] Func<string> bodyorderDiscPercent1 = null, [WorkflowExpression] Func<string> bodyorderDiscPercent2 = null, [WorkflowExpression] Func<string> bodyorderDiscPercent3 = null, [WorkflowExpression] Func<string> bodyorderStatus = null, [WorkflowExpression] Func<string> bodyorderType = null, [WorkflowExpression] Func<string> bodyoverrideCustomerBackOrder = null, [WorkflowExpression] Func<string> bodypOSSalesOrder = null, [WorkflowExpression] Func<string> bodyprocess = null, [WorkflowExpression] Func<string> bodyprocessFlag = null, [WorkflowExpression] Func<string> bodyputEntireQuantityOnNewLoadWhenChanged = null, [WorkflowExpression] Func<string> bodyreceiverCode = null, [WorkflowExpression] Func<string> bodyrequestedShipDate = null, [WorkflowExpression] Func<string> bodyreserveStock = null, [WorkflowExpression] Func<string> bodyreserveStockRequestAllocs = null, [WorkflowExpression] Func<string> bodysalesOrder = null, [WorkflowExpression] Func<bodysalesOrderDetailsInputItem[]> bodysalesOrderDetails = null, [WorkflowExpression] Func<bodysalesOrderFooterCommentsInputItem[]> bodysalesOrderFooterComments = null, [WorkflowExpression] Func<bodysalesOrderFreightDetailsInputItem[]> bodysalesOrderFreightDetails = null, [WorkflowExpression] Func<bodysalesOrderHeaderCommentsInputItem[]> bodysalesOrderHeaderComments = null, [WorkflowExpression] Func<bodysalesOrderMiscChargesDetailsInputItem[]> bodysalesOrderMiscChargesDetails = null, [WorkflowExpression] Func<string> bodysalesOrderPromoQualifyAction = null, [WorkflowExpression] Func<string> bodysalesOrderPromoSelectAction = null, [WorkflowExpression] Func<string> bodysalesperson = null, [WorkflowExpression] Func<string> bodysenderCode = null, [WorkflowExpression] Func<string> bodyshipAddress1 = null, [WorkflowExpression] Func<string> bodyshipAddress2 = null, [WorkflowExpression] Func<string> bodyshipAddress3 = null, [WorkflowExpression] Func<string> bodyshipAddress3Locality = null, [WorkflowExpression] Func<string> bodyshipAddress4 = null, [WorkflowExpression] Func<string> bodyshipAddress5 = null, [WorkflowExpression] Func<string> bodyshipAddressPerLine = null, [WorkflowExpression] Func<string> bodyshipAddressPerLineTax = null, [WorkflowExpression] Func<string> bodyshipGpsLat = null, [WorkflowExpression] Func<string> bodyshipGpsLong = null, [WorkflowExpression] Func<string> bodyshipPostalCode = null, [WorkflowExpression] Func<string> bodyshippingInstrs = null, [WorkflowExpression] Func<string> bodyshippingInstrsCode = null, [WorkflowExpression] Func<string> bodyshippingLocation = null, [WorkflowExpression] Func<string> bodyspecialInstrs = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodystatusInProcess = null, [WorkflowExpression] Func<string> bodystatusInProcessResponse = null, [WorkflowExpression] Func<string> bodysupplier = null, [WorkflowExpression] Func<string> bodytagsToDropFromXML = null, [WorkflowExpression] Func<string> bodytaxExemptNumber = null, [WorkflowExpression] Func<string> bodytaxExemptionStatus = null, [WorkflowExpression] Func<string> bodytransactionNature = null, [WorkflowExpression] Func<string> bodytransmissionReference = null, [WorkflowExpression] Func<string> bodytransportMode = null, [WorkflowExpression] Func<string> bodytypeOfOrder = null, [WorkflowExpression] Func<string> bodyuseCustomerSalesWarehouse = null, [WorkflowExpression] Func<string> bodyuseMasterAccountForCustomerPartNo = null, [WorkflowExpression] Func<string> bodyuseStockDescSupplied = null, [WorkflowExpression] Func<string> bodyvalidateShippingInstrs = null, [WorkflowExpression] Func<string> bodywarehouse = null, [WorkflowExpression] Func<string> bodywarehouseListToUse = null, [WorkflowExpression] Func<string> bodywarnIfCustomerOnHold = null, [WorkflowExpression] Func<string> bodyeSignature = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> __BuildSYSPROCreateNewSalesOrder(WorkflowValue<string> bodyacceptEarlierShipDate = null, WorkflowValue<string> bodyacceptKitOptional = null, WorkflowValue<string> bodyacceptOrdersIfNoCredit = null, WorkflowValue<string> bodyaddAttachedServiceCharges = null, WorkflowValue<string> bodyaddDangerousGoodsText = null, WorkflowValue<string> bodyaddStockSalesOrderText = null, WorkflowValue<string> bodyallocationAction = null, WorkflowValue<string> bodyallowBackOrderForNegativeMerchLine = null, WorkflowValue<string> bodyallowBackOrderForPartialHold = null, WorkflowValue<string> bodyallowBackOrderForSuperseded = null, WorkflowValue<string> bodyallowChangeToZeroPrice = null, WorkflowValue<string> bodyallowDuplicateOrderNumbers = null, WorkflowValue<string> bodyallowManualOrderNumberToBeUsed = null, WorkflowValue<string> bodyallowNonStockItems = null, WorkflowValue<string> bodyallowZeroPrice = null, WorkflowValue<string> bodyalternateReference = null, WorkflowValue<string> bodyalwaysUsePriceEntered = null, WorkflowValue<string> bodyapplyLeadTimeCalculation = null, WorkflowValue<string> bodyapplyParentDiscountToComponents = null, WorkflowValue<string> bodyarea = null, WorkflowValue<string> bodybranch = null, WorkflowValue<string> bodycancelReasonCode = null, WorkflowValue<string> bodycheckForCustomerPoNumbers = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodycompanyTaxNumber = null, WorkflowValue<string> bodycountyZip = null, WorkflowValue<string> bodycreditFailMessage = null, WorkflowValue<string> bodycurrency = null, WorkflowValue<string> bodycustomer = null, WorkflowValue<string> bodycustomerName = null, WorkflowValue<string> bodycustomerPoNumber = null, WorkflowValue<string> bodycustomerToUse = null, WorkflowValue<string> bodydeliveryRoute = null, WorkflowValue<string> bodydeliveryRouteAction = null, WorkflowValue<string> bodydeliveryTerms = null, WorkflowValue<string> bodydocumentFormat = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyglobalTradePromotionCodes = null, WorkflowValue<string> bodygstExemptNumber = null, WorkflowValue<string> bodygstExemptionStatus = null, WorkflowValue<string> bodyheaderFreightCharges = null, WorkflowValue<string> bodyheaderMiscCharges = null, WorkflowValue<string> bodyignoreWarnings = null, WorkflowValue<string> bodyinBoxMsgReqd = null, WorkflowValue<string> bodyincludeInMrp = null, WorkflowValue<string> bodyinvoiceDateEntered = null, WorkflowValue<string> bodyinvoiceNumberEntered = null, WorkflowValue<string> bodyinvoiceTerms = null, WorkflowValue<string> bodyinvoiceWholeOrderOnly = null, WorkflowValue<string> bodylanguageCode = null, WorkflowValue<string> bodyminimumDaysToShip = null, WorkflowValue<string> bodymultiShipCode = null, WorkflowValue<string> bodynationality = null, WorkflowValue<string> bodynewCustomerPoNumber = null, WorkflowValue<string> bodynewSalesOrderNumber = null, WorkflowValue<string> bodyoperatorToInform = null, WorkflowValue<string> bodyorderActionType = null, WorkflowValue<string> bodyorderComments = null, WorkflowValue<string> bodyorderDate = null, WorkflowValue<string> bodyorderDiscPercent1 = null, WorkflowValue<string> bodyorderDiscPercent2 = null, WorkflowValue<string> bodyorderDiscPercent3 = null, WorkflowValue<string> bodyorderStatus = null, WorkflowValue<string> bodyorderType = null, WorkflowValue<string> bodyoverrideCustomerBackOrder = null, WorkflowValue<string> bodypOSSalesOrder = null, WorkflowValue<string> bodyprocess = null, WorkflowValue<string> bodyprocessFlag = null, WorkflowValue<string> bodyputEntireQuantityOnNewLoadWhenChanged = null, WorkflowValue<string> bodyreceiverCode = null, WorkflowValue<string> bodyrequestedShipDate = null, WorkflowValue<string> bodyreserveStock = null, WorkflowValue<string> bodyreserveStockRequestAllocs = null, WorkflowValue<string> bodysalesOrder = null, WorkflowValue<bodysalesOrderDetailsInputItem[]> bodysalesOrderDetails = null, WorkflowValue<bodysalesOrderFooterCommentsInputItem[]> bodysalesOrderFooterComments = null, WorkflowValue<bodysalesOrderFreightDetailsInputItem[]> bodysalesOrderFreightDetails = null, WorkflowValue<bodysalesOrderHeaderCommentsInputItem[]> bodysalesOrderHeaderComments = null, WorkflowValue<bodysalesOrderMiscChargesDetailsInputItem[]> bodysalesOrderMiscChargesDetails = null, WorkflowValue<string> bodysalesOrderPromoQualifyAction = null, WorkflowValue<string> bodysalesOrderPromoSelectAction = null, WorkflowValue<string> bodysalesperson = null, WorkflowValue<string> bodysenderCode = null, WorkflowValue<string> bodyshipAddress1 = null, WorkflowValue<string> bodyshipAddress2 = null, WorkflowValue<string> bodyshipAddress3 = null, WorkflowValue<string> bodyshipAddress3Locality = null, WorkflowValue<string> bodyshipAddress4 = null, WorkflowValue<string> bodyshipAddress5 = null, WorkflowValue<string> bodyshipAddressPerLine = null, WorkflowValue<string> bodyshipAddressPerLineTax = null, WorkflowValue<string> bodyshipGpsLat = null, WorkflowValue<string> bodyshipGpsLong = null, WorkflowValue<string> bodyshipPostalCode = null, WorkflowValue<string> bodyshippingInstrs = null, WorkflowValue<string> bodyshippingInstrsCode = null, WorkflowValue<string> bodyshippingLocation = null, WorkflowValue<string> bodyspecialInstrs = null, WorkflowValue<string> bodystate = null, WorkflowValue<string> bodystatusInProcess = null, WorkflowValue<string> bodystatusInProcessResponse = null, WorkflowValue<string> bodysupplier = null, WorkflowValue<string> bodytagsToDropFromXML = null, WorkflowValue<string> bodytaxExemptNumber = null, WorkflowValue<string> bodytaxExemptionStatus = null, WorkflowValue<string> bodytransactionNature = null, WorkflowValue<string> bodytransmissionReference = null, WorkflowValue<string> bodytransportMode = null, WorkflowValue<string> bodytypeOfOrder = null, WorkflowValue<string> bodyuseCustomerSalesWarehouse = null, WorkflowValue<string> bodyuseMasterAccountForCustomerPartNo = null, WorkflowValue<string> bodyuseStockDescSupplied = null, WorkflowValue<string> bodyvalidateShippingInstrs = null, WorkflowValue<string> bodywarehouse = null, WorkflowValue<string> bodywarehouseListToUse = null, WorkflowValue<string> bodywarnIfCustomerOnHold = null, WorkflowValue<string> bodyeSignature = null)
        {
            WorkflowValue.Validate(bodyacceptEarlierShipDate, nameof(bodyacceptEarlierShipDate), required: false);
            WorkflowValue.Validate(bodyacceptKitOptional, nameof(bodyacceptKitOptional), required: false);
            WorkflowValue.Validate(bodyacceptOrdersIfNoCredit, nameof(bodyacceptOrdersIfNoCredit), required: false);
            WorkflowValue.Validate(bodyaddAttachedServiceCharges, nameof(bodyaddAttachedServiceCharges), required: false);
            WorkflowValue.Validate(bodyaddDangerousGoodsText, nameof(bodyaddDangerousGoodsText), required: false);
            WorkflowValue.Validate(bodyaddStockSalesOrderText, nameof(bodyaddStockSalesOrderText), required: false);
            WorkflowValue.Validate(bodyallocationAction, nameof(bodyallocationAction), required: false);
            WorkflowValue.Validate(bodyallowBackOrderForNegativeMerchLine, nameof(bodyallowBackOrderForNegativeMerchLine), required: false);
            WorkflowValue.Validate(bodyallowBackOrderForPartialHold, nameof(bodyallowBackOrderForPartialHold), required: false);
            WorkflowValue.Validate(bodyallowBackOrderForSuperseded, nameof(bodyallowBackOrderForSuperseded), required: false);
            WorkflowValue.Validate(bodyallowChangeToZeroPrice, nameof(bodyallowChangeToZeroPrice), required: false);
            WorkflowValue.Validate(bodyallowDuplicateOrderNumbers, nameof(bodyallowDuplicateOrderNumbers), required: false);
            WorkflowValue.Validate(bodyallowManualOrderNumberToBeUsed, nameof(bodyallowManualOrderNumberToBeUsed), required: false);
            WorkflowValue.Validate(bodyallowNonStockItems, nameof(bodyallowNonStockItems), required: false);
            WorkflowValue.Validate(bodyallowZeroPrice, nameof(bodyallowZeroPrice), required: false);
            WorkflowValue.Validate(bodyalternateReference, nameof(bodyalternateReference), required: false);
            WorkflowValue.Validate(bodyalwaysUsePriceEntered, nameof(bodyalwaysUsePriceEntered), required: false);
            WorkflowValue.Validate(bodyapplyLeadTimeCalculation, nameof(bodyapplyLeadTimeCalculation), required: false);
            WorkflowValue.Validate(bodyapplyParentDiscountToComponents, nameof(bodyapplyParentDiscountToComponents), required: false);
            WorkflowValue.Validate(bodyarea, nameof(bodyarea), required: false);
            WorkflowValue.Validate(bodybranch, nameof(bodybranch), required: false);
            WorkflowValue.Validate(bodycancelReasonCode, nameof(bodycancelReasonCode), required: false);
            WorkflowValue.Validate(bodycheckForCustomerPoNumbers, nameof(bodycheckForCustomerPoNumbers), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            WorkflowValue.Validate(bodycountyZip, nameof(bodycountyZip), required: false);
            WorkflowValue.Validate(bodycreditFailMessage, nameof(bodycreditFailMessage), required: false);
            WorkflowValue.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowValue.Validate(bodycustomer, nameof(bodycustomer), required: false);
            WorkflowValue.Validate(bodycustomerName, nameof(bodycustomerName), required: false);
            WorkflowValue.Validate(bodycustomerPoNumber, nameof(bodycustomerPoNumber), required: false);
            WorkflowValue.Validate(bodycustomerToUse, nameof(bodycustomerToUse), required: false);
            WorkflowValue.Validate(bodydeliveryRoute, nameof(bodydeliveryRoute), required: false);
            WorkflowValue.Validate(bodydeliveryRouteAction, nameof(bodydeliveryRouteAction), required: false);
            WorkflowValue.Validate(bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            WorkflowValue.Validate(bodydocumentFormat, nameof(bodydocumentFormat), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyglobalTradePromotionCodes, nameof(bodyglobalTradePromotionCodes), required: false);
            WorkflowValue.Validate(bodygstExemptNumber, nameof(bodygstExemptNumber), required: false);
            WorkflowValue.Validate(bodygstExemptionStatus, nameof(bodygstExemptionStatus), required: false);
            WorkflowValue.Validate(bodyheaderFreightCharges, nameof(bodyheaderFreightCharges), required: false);
            WorkflowValue.Validate(bodyheaderMiscCharges, nameof(bodyheaderMiscCharges), required: false);
            WorkflowValue.Validate(bodyignoreWarnings, nameof(bodyignoreWarnings), required: false);
            WorkflowValue.Validate(bodyinBoxMsgReqd, nameof(bodyinBoxMsgReqd), required: false);
            WorkflowValue.Validate(bodyincludeInMrp, nameof(bodyincludeInMrp), required: false);
            WorkflowValue.Validate(bodyinvoiceDateEntered, nameof(bodyinvoiceDateEntered), required: false);
            WorkflowValue.Validate(bodyinvoiceNumberEntered, nameof(bodyinvoiceNumberEntered), required: false);
            WorkflowValue.Validate(bodyinvoiceTerms, nameof(bodyinvoiceTerms), required: false);
            WorkflowValue.Validate(bodyinvoiceWholeOrderOnly, nameof(bodyinvoiceWholeOrderOnly), required: false);
            WorkflowValue.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            WorkflowValue.Validate(bodyminimumDaysToShip, nameof(bodyminimumDaysToShip), required: false);
            WorkflowValue.Validate(bodymultiShipCode, nameof(bodymultiShipCode), required: false);
            WorkflowValue.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowValue.Validate(bodynewCustomerPoNumber, nameof(bodynewCustomerPoNumber), required: false);
            WorkflowValue.Validate(bodynewSalesOrderNumber, nameof(bodynewSalesOrderNumber), required: false);
            WorkflowValue.Validate(bodyoperatorToInform, nameof(bodyoperatorToInform), required: false);
            WorkflowValue.Validate(bodyorderActionType, nameof(bodyorderActionType), required: false);
            WorkflowValue.Validate(bodyorderComments, nameof(bodyorderComments), required: false);
            WorkflowValue.Validate(bodyorderDate, nameof(bodyorderDate), required: false);
            WorkflowValue.Validate(bodyorderDiscPercent1, nameof(bodyorderDiscPercent1), required: false);
            WorkflowValue.Validate(bodyorderDiscPercent2, nameof(bodyorderDiscPercent2), required: false);
            WorkflowValue.Validate(bodyorderDiscPercent3, nameof(bodyorderDiscPercent3), required: false);
            WorkflowValue.Validate(bodyorderStatus, nameof(bodyorderStatus), required: false);
            WorkflowValue.Validate(bodyorderType, nameof(bodyorderType), required: false);
            WorkflowValue.Validate(bodyoverrideCustomerBackOrder, nameof(bodyoverrideCustomerBackOrder), required: false);
            WorkflowValue.Validate(bodypOSSalesOrder, nameof(bodypOSSalesOrder), required: false);
            WorkflowValue.Validate(bodyprocess, nameof(bodyprocess), required: false);
            WorkflowValue.Validate(bodyprocessFlag, nameof(bodyprocessFlag), required: false);
            WorkflowValue.Validate(bodyputEntireQuantityOnNewLoadWhenChanged, nameof(bodyputEntireQuantityOnNewLoadWhenChanged), required: false);
            WorkflowValue.Validate(bodyreceiverCode, nameof(bodyreceiverCode), required: false);
            WorkflowValue.Validate(bodyrequestedShipDate, nameof(bodyrequestedShipDate), required: false);
            WorkflowValue.Validate(bodyreserveStock, nameof(bodyreserveStock), required: false);
            WorkflowValue.Validate(bodyreserveStockRequestAllocs, nameof(bodyreserveStockRequestAllocs), required: false);
            WorkflowValue.Validate(bodysalesOrder, nameof(bodysalesOrder), required: false);
            WorkflowValue.Validate(bodysalesOrderDetails, nameof(bodysalesOrderDetails), required: false);
            WorkflowValue.Validate(bodysalesOrderFooterComments, nameof(bodysalesOrderFooterComments), required: false);
            WorkflowValue.Validate(bodysalesOrderFreightDetails, nameof(bodysalesOrderFreightDetails), required: false);
            WorkflowValue.Validate(bodysalesOrderHeaderComments, nameof(bodysalesOrderHeaderComments), required: false);
            WorkflowValue.Validate(bodysalesOrderMiscChargesDetails, nameof(bodysalesOrderMiscChargesDetails), required: false);
            WorkflowValue.Validate(bodysalesOrderPromoQualifyAction, nameof(bodysalesOrderPromoQualifyAction), required: false);
            WorkflowValue.Validate(bodysalesOrderPromoSelectAction, nameof(bodysalesOrderPromoSelectAction), required: false);
            WorkflowValue.Validate(bodysalesperson, nameof(bodysalesperson), required: false);
            WorkflowValue.Validate(bodysenderCode, nameof(bodysenderCode), required: false);
            WorkflowValue.Validate(bodyshipAddress1, nameof(bodyshipAddress1), required: false);
            WorkflowValue.Validate(bodyshipAddress2, nameof(bodyshipAddress2), required: false);
            WorkflowValue.Validate(bodyshipAddress3, nameof(bodyshipAddress3), required: false);
            WorkflowValue.Validate(bodyshipAddress3Locality, nameof(bodyshipAddress3Locality), required: false);
            WorkflowValue.Validate(bodyshipAddress4, nameof(bodyshipAddress4), required: false);
            WorkflowValue.Validate(bodyshipAddress5, nameof(bodyshipAddress5), required: false);
            WorkflowValue.Validate(bodyshipAddressPerLine, nameof(bodyshipAddressPerLine), required: false);
            WorkflowValue.Validate(bodyshipAddressPerLineTax, nameof(bodyshipAddressPerLineTax), required: false);
            WorkflowValue.Validate(bodyshipGpsLat, nameof(bodyshipGpsLat), required: false);
            WorkflowValue.Validate(bodyshipGpsLong, nameof(bodyshipGpsLong), required: false);
            WorkflowValue.Validate(bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            WorkflowValue.Validate(bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            WorkflowValue.Validate(bodyshippingInstrsCode, nameof(bodyshippingInstrsCode), required: false);
            WorkflowValue.Validate(bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            WorkflowValue.Validate(bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            WorkflowValue.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowValue.Validate(bodystatusInProcess, nameof(bodystatusInProcess), required: false);
            WorkflowValue.Validate(bodystatusInProcessResponse, nameof(bodystatusInProcessResponse), required: false);
            WorkflowValue.Validate(bodysupplier, nameof(bodysupplier), required: false);
            WorkflowValue.Validate(bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            WorkflowValue.Validate(bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            WorkflowValue.Validate(bodytaxExemptionStatus, nameof(bodytaxExemptionStatus), required: false);
            WorkflowValue.Validate(bodytransactionNature, nameof(bodytransactionNature), required: false);
            WorkflowValue.Validate(bodytransmissionReference, nameof(bodytransmissionReference), required: false);
            WorkflowValue.Validate(bodytransportMode, nameof(bodytransportMode), required: false);
            WorkflowValue.Validate(bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            WorkflowValue.Validate(bodyuseCustomerSalesWarehouse, nameof(bodyuseCustomerSalesWarehouse), required: false);
            WorkflowValue.Validate(bodyuseMasterAccountForCustomerPartNo, nameof(bodyuseMasterAccountForCustomerPartNo), required: false);
            WorkflowValue.Validate(bodyuseStockDescSupplied, nameof(bodyuseStockDescSupplied), required: false);
            WorkflowValue.Validate(bodyvalidateShippingInstrs, nameof(bodyvalidateShippingInstrs), required: false);
            WorkflowValue.Validate(bodywarehouse, nameof(bodywarehouse), required: false);
            WorkflowValue.Validate(bodywarehouseListToUse, nameof(bodywarehouseListToUse), required: false);
            WorkflowValue.Validate(bodywarnIfCustomerOnHold, nameof(bodywarnIfCustomerOnHold), required: false);
            WorkflowValue.Validate(bodyeSignature, nameof(bodyeSignature), required: false);
            return new DeferredBodyAction<SYSPROCreateNewSalesOrderResponse>(() =>
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
            });
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
