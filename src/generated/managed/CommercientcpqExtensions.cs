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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> __BuildSAGE100CreateNewCustomer(WorkflowExpression<string> bodyaRDivisionNo = null, WorkflowExpression<string> bodyaddressLine1 = null, WorkflowExpression<string> bodyaddressLine2 = null, WorkflowExpression<string> bodyaddressLine3 = null, WorkflowExpression<bool> bodybatchFax = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodycontactCode = null, WorkflowExpression<string> bodycountryCode = null, WorkflowExpression<bool> bodycreditHold = null, WorkflowExpression<int> bodycreditLimit = null, WorkflowExpression<int> bodycustomerDiscountRate = null, WorkflowExpression<string> bodycustomerName = null, WorkflowExpression<string> bodycustomerNo = null, WorkflowExpression<string> bodycustomerType = null, WorkflowExpression<string> bodydefaultCreditCardPmtType = null, WorkflowExpression<string> bodydefaultItemCode = null, WorkflowExpression<string> bodydefaultPaymentType = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyfaxNo = null, WorkflowExpression<bool> bodyopenItemCustomer = null, WorkflowExpression<string> bodypriceLevel = null, WorkflowExpression<string> bodyprimaryShipToCode = null, WorkflowExpression<bool> bodyprintDunningMessage = null, WorkflowExpression<bool> bodyresidentialAddress = null, WorkflowExpression<string> bodysalespersonNo = null, WorkflowExpression<string> bodyshipMethod = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodystatementCycle = null, WorkflowExpression<string> bodytaxExemptNo = null, WorkflowExpression<string> bodytaxSchedule = null, WorkflowExpression<string> bodytelephoneExt = null, WorkflowExpression<string> bodytelephoneNo = null, WorkflowExpression<string> bodytermsCode = null, WorkflowExpression<string> bodyuRLAddress = null, WorkflowExpression<string> bodyzipCode = null)
        {
            WorkflowExpression.Validate(bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            WorkflowExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            WorkflowExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            WorkflowExpression.Validate(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            WorkflowExpression.Validate(bodybatchFax, nameof(bodybatchFax), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodycontactCode, nameof(bodycontactCode), required: false);
            WorkflowExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            WorkflowExpression.Validate(bodycreditHold, nameof(bodycreditHold), required: false);
            WorkflowExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowExpression.Validate(bodycustomerDiscountRate, nameof(bodycustomerDiscountRate), required: false);
            WorkflowExpression.Validate(bodycustomerName, nameof(bodycustomerName), required: false);
            WorkflowExpression.Validate(bodycustomerNo, nameof(bodycustomerNo), required: false);
            WorkflowExpression.Validate(bodycustomerType, nameof(bodycustomerType), required: false);
            WorkflowExpression.Validate(bodydefaultCreditCardPmtType, nameof(bodydefaultCreditCardPmtType), required: false);
            WorkflowExpression.Validate(bodydefaultItemCode, nameof(bodydefaultItemCode), required: false);
            WorkflowExpression.Validate(bodydefaultPaymentType, nameof(bodydefaultPaymentType), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyfaxNo, nameof(bodyfaxNo), required: false);
            WorkflowExpression.Validate(bodyopenItemCustomer, nameof(bodyopenItemCustomer), required: false);
            WorkflowExpression.Validate(bodypriceLevel, nameof(bodypriceLevel), required: false);
            WorkflowExpression.Validate(bodyprimaryShipToCode, nameof(bodyprimaryShipToCode), required: false);
            WorkflowExpression.Validate(bodyprintDunningMessage, nameof(bodyprintDunningMessage), required: false);
            WorkflowExpression.Validate(bodyresidentialAddress, nameof(bodyresidentialAddress), required: false);
            WorkflowExpression.Validate(bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            WorkflowExpression.Validate(bodyshipMethod, nameof(bodyshipMethod), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodystatementCycle, nameof(bodystatementCycle), required: false);
            WorkflowExpression.Validate(bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            WorkflowExpression.Validate(bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            WorkflowExpression.Validate(bodytelephoneExt, nameof(bodytelephoneExt), required: false);
            WorkflowExpression.Validate(bodytelephoneNo, nameof(bodytelephoneNo), required: false);
            WorkflowExpression.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            WorkflowExpression.Validate(bodyuRLAddress, nameof(bodyuRLAddress), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> __BuildSAGE100CreateNewSalesOrder(WorkflowExpression<string> bodyaRDivisionNo = null, WorkflowExpression<bool> bodybatchFax = null, WorkflowExpression<string> bodybillToAddress1 = null, WorkflowExpression<string> bodybillToAddress2 = null, WorkflowExpression<string> bodybillToAddress3 = null, WorkflowExpression<string> bodybillToCity = null, WorkflowExpression<string> bodybillToCountryCode = null, WorkflowExpression<string> bodybillToName = null, WorkflowExpression<string> bodybillToState = null, WorkflowExpression<string> bodybillToZipCode = null, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodyconfirmTo = null, WorkflowExpression<string> bodycustomerNo = null, WorkflowExpression<string> bodycustomerPONo = null, WorkflowExpression<string> bodycycleCode = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyfOB = null, WorkflowExpression<string> bodyfaxNo = null, WorkflowExpression<string> bodymasterRepeatingOrderNo = null, WorkflowExpression<int> bodynumberOfShippingLabels = null, WorkflowExpression<string> bodyorderDate = null, WorkflowExpression<string> bodyorderStatus = null, WorkflowExpression<string> bodyorderType = null, WorkflowExpression<bool> bodyprintPickingSheets = null, WorkflowExpression<bool> bodyprintSalesOrders = null, WorkflowExpression<bodysalesOrderLineItemInputItem[]> bodysalesOrderLineItem = null, WorkflowExpression<string> bodysalesOrderNo = null, WorkflowExpression<string> bodysalespersonNo = null, WorkflowExpression<string> bodyshipExpireDate = null, WorkflowExpression<string> bodyshipToAddress1 = null, WorkflowExpression<string> bodyshipToAddress2 = null, WorkflowExpression<string> bodyshipToAddress3 = null, WorkflowExpression<string> bodyshipToCity = null, WorkflowExpression<string> bodyshipToCode = null, WorkflowExpression<string> bodyshipToCountryCode = null, WorkflowExpression<string> bodyshipToName = null, WorkflowExpression<string> bodyshipToState = null, WorkflowExpression<string> bodyshipToZipCode = null, WorkflowExpression<string> bodyshipVia = null, WorkflowExpression<int> bodyshipWeight = null, WorkflowExpression<string> bodyshipZoneActual = null, WorkflowExpression<string> bodysplitCommissions = null, WorkflowExpression<string> bodytaxExemptNo = null, WorkflowExpression<string> bodytaxSchedule = null, WorkflowExpression<string> bodytermsCode = null, WorkflowExpression<string> bodywarehouseCode = null)
        {
            WorkflowExpression.Validate(bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            WorkflowExpression.Validate(bodybatchFax, nameof(bodybatchFax), required: false);
            WorkflowExpression.Validate(bodybillToAddress1, nameof(bodybillToAddress1), required: false);
            WorkflowExpression.Validate(bodybillToAddress2, nameof(bodybillToAddress2), required: false);
            WorkflowExpression.Validate(bodybillToAddress3, nameof(bodybillToAddress3), required: false);
            WorkflowExpression.Validate(bodybillToCity, nameof(bodybillToCity), required: false);
            WorkflowExpression.Validate(bodybillToCountryCode, nameof(bodybillToCountryCode), required: false);
            WorkflowExpression.Validate(bodybillToName, nameof(bodybillToName), required: false);
            WorkflowExpression.Validate(bodybillToState, nameof(bodybillToState), required: false);
            WorkflowExpression.Validate(bodybillToZipCode, nameof(bodybillToZipCode), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodyconfirmTo, nameof(bodyconfirmTo), required: false);
            WorkflowExpression.Validate(bodycustomerNo, nameof(bodycustomerNo), required: false);
            WorkflowExpression.Validate(bodycustomerPONo, nameof(bodycustomerPONo), required: false);
            WorkflowExpression.Validate(bodycycleCode, nameof(bodycycleCode), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyfOB, nameof(bodyfOB), required: false);
            WorkflowExpression.Validate(bodyfaxNo, nameof(bodyfaxNo), required: false);
            WorkflowExpression.Validate(bodymasterRepeatingOrderNo, nameof(bodymasterRepeatingOrderNo), required: false);
            WorkflowExpression.Validate(bodynumberOfShippingLabels, nameof(bodynumberOfShippingLabels), required: false);
            WorkflowExpression.Validate(bodyorderDate, nameof(bodyorderDate), required: false);
            WorkflowExpression.Validate(bodyorderStatus, nameof(bodyorderStatus), required: false);
            WorkflowExpression.Validate(bodyorderType, nameof(bodyorderType), required: false);
            WorkflowExpression.Validate(bodyprintPickingSheets, nameof(bodyprintPickingSheets), required: false);
            WorkflowExpression.Validate(bodyprintSalesOrders, nameof(bodyprintSalesOrders), required: false);
            WorkflowExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowExpression.Validate(bodysalesOrderNo, nameof(bodysalesOrderNo), required: false);
            WorkflowExpression.Validate(bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            WorkflowExpression.Validate(bodyshipExpireDate, nameof(bodyshipExpireDate), required: false);
            WorkflowExpression.Validate(bodyshipToAddress1, nameof(bodyshipToAddress1), required: false);
            WorkflowExpression.Validate(bodyshipToAddress2, nameof(bodyshipToAddress2), required: false);
            WorkflowExpression.Validate(bodyshipToAddress3, nameof(bodyshipToAddress3), required: false);
            WorkflowExpression.Validate(bodyshipToCity, nameof(bodyshipToCity), required: false);
            WorkflowExpression.Validate(bodyshipToCode, nameof(bodyshipToCode), required: false);
            WorkflowExpression.Validate(bodyshipToCountryCode, nameof(bodyshipToCountryCode), required: false);
            WorkflowExpression.Validate(bodyshipToName, nameof(bodyshipToName), required: false);
            WorkflowExpression.Validate(bodyshipToState, nameof(bodyshipToState), required: false);
            WorkflowExpression.Validate(bodyshipToZipCode, nameof(bodyshipToZipCode), required: false);
            WorkflowExpression.Validate(bodyshipVia, nameof(bodyshipVia), required: false);
            WorkflowExpression.Validate(bodyshipWeight, nameof(bodyshipWeight), required: false);
            WorkflowExpression.Validate(bodyshipZoneActual, nameof(bodyshipZoneActual), required: false);
            WorkflowExpression.Validate(bodysplitCommissions, nameof(bodysplitCommissions), required: false);
            WorkflowExpression.Validate(bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            WorkflowExpression.Validate(bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            WorkflowExpression.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            WorkflowExpression.Validate(bodywarehouseCode, nameof(bodywarehouseCode), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> __BuildCommercientCPQCreateNewCustomer(WorkflowExpression<string> bodybillingCity = null, WorkflowExpression<string> bodybillingCounty = null, WorkflowExpression<string> bodybillingPostalCode = null, WorkflowExpression<string> bodybillingState = null, WorkflowExpression<string> bodybillingStreet = null, WorkflowExpression<string> bodygUID = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyshippingCity = null, WorkflowExpression<string> bodyshippingCountry = null, WorkflowExpression<string> bodyshippingPostalCode = null, WorkflowExpression<string> bodyshippingState = null, WorkflowExpression<string> bodyshippingStreet = null, WorkflowExpression<string> bodyacnm = null)
        {
            WorkflowExpression.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            WorkflowExpression.Validate(bodybillingCounty, nameof(bodybillingCounty), required: false);
            WorkflowExpression.Validate(bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            WorkflowExpression.Validate(bodybillingState, nameof(bodybillingState), required: false);
            WorkflowExpression.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            WorkflowExpression.Validate(bodygUID, nameof(bodygUID), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            WorkflowExpression.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            WorkflowExpression.Validate(bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            WorkflowExpression.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            WorkflowExpression.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            WorkflowExpression.Validate(bodyacnm, nameof(bodyacnm), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> __BuildCommercientCPQCreateNewProduct(WorkflowExpression<string> bodystockCode = null)
        {
            WorkflowExpression.Validate(bodystockCode, nameof(bodystockCode), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> __BuildCommercientCPQCreateNewSalesOrder(WorkflowExpression<string> bodyorderHeaderGUID = null, WorkflowExpression<bodysalesOrderLineItemInputItem2[]> bodysalesOrderLineItem = null)
        {
            WorkflowExpression.Validate(bodyorderHeaderGUID, nameof(bodyorderHeaderGUID), required: false);
            WorkflowExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> __BuildQuickBookCreateNewCustomer(WorkflowExpression<string> bodyaccountNumber = null, WorkflowExpression<string> bodyaltContact = null, WorkflowExpression<string> bodyaltPhone = null, WorkflowExpression<string> bodybillAddressAddr1 = null, WorkflowExpression<string> bodybillAddressAddr2 = null, WorkflowExpression<string> bodybillAddressAddr3 = null, WorkflowExpression<string> bodybillAddressAddr4 = null, WorkflowExpression<string> bodybillAddressAddr5 = null, WorkflowExpression<string> bodybillAddressCity = null, WorkflowExpression<string> bodybillAddressCountry = null, WorkflowExpression<string> bodybillAddressNote = null, WorkflowExpression<string> bodybillAddressPostalCode = null, WorkflowExpression<string> bodybillAddressState = null, WorkflowExpression<string> bodycc = null, WorkflowExpression<string> bodyclassRef = null, WorkflowExpression<string> bodycompanyName = null, WorkflowExpression<string> bodycontact = null, WorkflowExpression<int> bodycreditLimit = null, WorkflowExpression<string> bodycustomerTypeRef = null, WorkflowExpression<string> bodyeditSequence = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyextraField = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<bool> bodyisActive = null, WorkflowExpression<string> bodyitemSalesTaxRef = null, WorkflowExpression<string> bodyjobTitle = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodylistID = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<int> bodyopenBalance = null, WorkflowExpression<string> bodyopenBalanceDate = null, WorkflowExpression<string> bodyparentRef = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodypreferredPaymentMethodRef = null, WorkflowExpression<string> bodypriceLevelRef = null, WorkflowExpression<string> bodyresaleNumber = null, WorkflowExpression<string> bodysalesRepRef = null, WorkflowExpression<string> bodysalesTaxCodeRef = null, WorkflowExpression<string> bodysalutation = null, WorkflowExpression<string> bodyshipAddressAddr1 = null, WorkflowExpression<string> bodyshipAddressAddr2 = null, WorkflowExpression<string> bodyshipAddressAddr3 = null, WorkflowExpression<string> bodyshipAddressAddr4 = null, WorkflowExpression<string> bodyshipAddressAddr5 = null, WorkflowExpression<string> bodyshipAddressCity = null, WorkflowExpression<string> bodyshipAddressCountry = null, WorkflowExpression<string> bodyshipAddressNote = null, WorkflowExpression<string> bodyshipAddressPostalCode = null, WorkflowExpression<string> bodyshipAddressState = null, WorkflowExpression<string> bodytermsRef = null)
        {
            WorkflowExpression.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            WorkflowExpression.Validate(bodyaltContact, nameof(bodyaltContact), required: false);
            WorkflowExpression.Validate(bodyaltPhone, nameof(bodyaltPhone), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            WorkflowExpression.Validate(bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            WorkflowExpression.Validate(bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            WorkflowExpression.Validate(bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            WorkflowExpression.Validate(bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            WorkflowExpression.Validate(bodybillAddressState, nameof(bodybillAddressState), required: false);
            WorkflowExpression.Validate(bodycc, nameof(bodycc), required: false);
            WorkflowExpression.Validate(bodyclassRef, nameof(bodyclassRef), required: false);
            WorkflowExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            WorkflowExpression.Validate(bodycontact, nameof(bodycontact), required: false);
            WorkflowExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowExpression.Validate(bodycustomerTypeRef, nameof(bodycustomerTypeRef), required: false);
            WorkflowExpression.Validate(bodyeditSequence, nameof(bodyeditSequence), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodyisActive, nameof(bodyisActive), required: false);
            WorkflowExpression.Validate(bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            WorkflowExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodylistID, nameof(bodylistID), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodyopenBalance, nameof(bodyopenBalance), required: false);
            WorkflowExpression.Validate(bodyopenBalanceDate, nameof(bodyopenBalanceDate), required: false);
            WorkflowExpression.Validate(bodyparentRef, nameof(bodyparentRef), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodypreferredPaymentMethodRef, nameof(bodypreferredPaymentMethodRef), required: false);
            WorkflowExpression.Validate(bodypriceLevelRef, nameof(bodypriceLevelRef), required: false);
            WorkflowExpression.Validate(bodyresaleNumber, nameof(bodyresaleNumber), required: false);
            WorkflowExpression.Validate(bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            WorkflowExpression.Validate(bodysalesTaxCodeRef, nameof(bodysalesTaxCodeRef), required: false);
            WorkflowExpression.Validate(bodysalutation, nameof(bodysalutation), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            WorkflowExpression.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            WorkflowExpression.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            WorkflowExpression.Validate(bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            WorkflowExpression.Validate(bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            WorkflowExpression.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            WorkflowExpression.Validate(bodytermsRef, nameof(bodytermsRef), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> __BuildQuickBookCreateNewSalesOrder(WorkflowExpression<string> bodybillAddressAddr1 = null, WorkflowExpression<string> bodybillAddressAddr2 = null, WorkflowExpression<string> bodybillAddressAddr3 = null, WorkflowExpression<string> bodybillAddressAddr4 = null, WorkflowExpression<string> bodybillAddressAddr5 = null, WorkflowExpression<string> bodybillAddressCity = null, WorkflowExpression<string> bodybillAddressCountry = null, WorkflowExpression<string> bodybillAddressNote = null, WorkflowExpression<string> bodybillAddressPostalCode = null, WorkflowExpression<string> bodybillAddressState = null, WorkflowExpression<string> bodyclassRef = null, WorkflowExpression<string> bodycustomerRefListID = null, WorkflowExpression<string> bodycustomerRefName = null, WorkflowExpression<string> bodycustomerSalesTaxCodeRef = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodyeditSequence = null, WorkflowExpression<string> bodyextraField = null, WorkflowExpression<string> bodyitemSalesTaxRef = null, WorkflowExpression<string> bodylistID = null, WorkflowExpression<string> bodymemo = null, WorkflowExpression<string> bodypONumber = null, WorkflowExpression<string> bodyrefNumber = null, WorkflowExpression<bodysalesOrderLineItemInputItem22[]> bodysalesOrderLineItem = null, WorkflowExpression<string> bodysalesRepRef = null, WorkflowExpression<string> bodyshipAddressAddr1 = null, WorkflowExpression<string> bodyshipAddressAddr2 = null, WorkflowExpression<string> bodyshipAddressAddr3 = null, WorkflowExpression<string> bodyshipAddressAddr4 = null, WorkflowExpression<string> bodyshipAddressAddr5 = null, WorkflowExpression<string> bodyshipAddressCity = null, WorkflowExpression<string> bodyshipAddressCountry = null, WorkflowExpression<string> bodyshipAddressNote = null, WorkflowExpression<string> bodyshipAddressPostalCode = null, WorkflowExpression<string> bodyshipAddressState = null, WorkflowExpression<string> bodytemplateRef = null, WorkflowExpression<string> bodytermsRef = null, WorkflowExpression<string> bodytxnDate = null)
        {
            WorkflowExpression.Validate(bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            WorkflowExpression.Validate(bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            WorkflowExpression.Validate(bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            WorkflowExpression.Validate(bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            WorkflowExpression.Validate(bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            WorkflowExpression.Validate(bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            WorkflowExpression.Validate(bodybillAddressState, nameof(bodybillAddressState), required: false);
            WorkflowExpression.Validate(bodyclassRef, nameof(bodyclassRef), required: false);
            WorkflowExpression.Validate(bodycustomerRefListID, nameof(bodycustomerRefListID), required: false);
            WorkflowExpression.Validate(bodycustomerRefName, nameof(bodycustomerRefName), required: false);
            WorkflowExpression.Validate(bodycustomerSalesTaxCodeRef, nameof(bodycustomerSalesTaxCodeRef), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodyeditSequence, nameof(bodyeditSequence), required: false);
            WorkflowExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowExpression.Validate(bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            WorkflowExpression.Validate(bodylistID, nameof(bodylistID), required: false);
            WorkflowExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            WorkflowExpression.Validate(bodypONumber, nameof(bodypONumber), required: false);
            WorkflowExpression.Validate(bodyrefNumber, nameof(bodyrefNumber), required: false);
            WorkflowExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowExpression.Validate(bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            WorkflowExpression.Validate(bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            WorkflowExpression.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            WorkflowExpression.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            WorkflowExpression.Validate(bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            WorkflowExpression.Validate(bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            WorkflowExpression.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            WorkflowExpression.Validate(bodytemplateRef, nameof(bodytemplateRef), required: false);
            WorkflowExpression.Validate(bodytermsRef, nameof(bodytermsRef), required: false);
            WorkflowExpression.Validate(bodytxnDate, nameof(bodytxnDate), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> __BuildSAGE50UKCreateNewCustomer(WorkflowExpression<string> bodyaCCOUNTOPENED = null, WorkflowExpression<string> bodyaCCOUNTREF = null, WorkflowExpression<int> bodyaCCOUNTSTATUS = null, WorkflowExpression<string> bodyaDDRESS1 = null, WorkflowExpression<string> bodyaDDRESS2 = null, WorkflowExpression<string> bodyaDDRESS3 = null, WorkflowExpression<string> bodyaDDRESS4 = null, WorkflowExpression<string> bodyaDDRESS5 = null, WorkflowExpression<string> bodyaNALYSIS1 = null, WorkflowExpression<string> bodyaNALYSIS2 = null, WorkflowExpression<string> bodyaNALYSIS3 = null, WorkflowExpression<int> bodyaVERAGEPAYDAYS = null, WorkflowExpression<int> bodybALANCE = null, WorkflowExpression<bool> bodycANAPPLYCHARGES = null, WorkflowExpression<string> bodycONTACTNAME = null, WorkflowExpression<string> bodycOUNTRYCODE = null, WorkflowExpression<string> bodycREDITAPPLIEDFOR = null, WorkflowExpression<int> bodycREDITBUREAU = null, WorkflowExpression<int> bodycREDITLIMIT = null, WorkflowExpression<int> bodycREDITPOSITION = null, WorkflowExpression<string> bodycREDITREFERENCE = null, WorkflowExpression<int> bodycURRENCY = null, WorkflowExpression<string> bodydATECREDITAPPRECEIVED = null, WorkflowExpression<string> bodydEFNOMCODE = null, WorkflowExpression<int> bodydEFTAXCODE = null, WorkflowExpression<int> bodydEPTNUMBER = null, WorkflowExpression<int> bodydISCOUNTRATE = null, WorkflowExpression<int> bodydISCOUNTTYPE = null, WorkflowExpression<string> bodydUNSNUMBER = null, WorkflowExpression<string> bodyeMAIL = null, WorkflowExpression<string> bodyeMAIL2 = null, WorkflowExpression<string> bodyeMAIL3 = null, WorkflowExpression<string> bodyextraField = null, WorkflowExpression<string> bodyfAX = null, WorkflowExpression<bool> bodyhOLDMAIL = null, WorkflowExpression<bool> bodyiNACTIVEFLAG = null, WorkflowExpression<bool> bodyisACCOUNTREFAutogenerate = null, WorkflowExpression<string> bodylASTCREDITREV = null, WorkflowExpression<string> bodynAME = null, WorkflowExpression<string> bodynEXTCREDITREV = null, WorkflowExpression<bool> bodyoVERRIDEPRODUCTNOMINAL = null, WorkflowExpression<bool> bodyoVERRIDEPRODUCTTAX = null, WorkflowExpression<int> bodypAYMENTDUEDAYS = null, WorkflowExpression<string> bodypRICELISTREF = null, WorkflowExpression<bool> bodypRIORITYTRADER = null, WorkflowExpression<bool> bodysENDINVOICESELECTRONICALLY = null, WorkflowExpression<bool> bodysENDLETTERSELECTRONICALLY = null, WorkflowExpression<int> bodysETTLEMENTDISCRATE = null, WorkflowExpression<int> bodysETTLEMENTDUEDAYS = null, WorkflowExpression<string> bodytELEPHONE = null, WorkflowExpression<string> bodytELEPHONE2 = null, WorkflowExpression<string> bodytERMS = null, WorkflowExpression<bool> bodytERMSAGREEDFLAG = null, WorkflowExpression<string> bodytRADECONTACT = null, WorkflowExpression<string> bodyvATREGNUMBER = null)
        {
            WorkflowExpression.Validate(bodyaCCOUNTOPENED, nameof(bodyaCCOUNTOPENED), required: false);
            WorkflowExpression.Validate(bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            WorkflowExpression.Validate(bodyaCCOUNTSTATUS, nameof(bodyaCCOUNTSTATUS), required: false);
            WorkflowExpression.Validate(bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            WorkflowExpression.Validate(bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            WorkflowExpression.Validate(bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            WorkflowExpression.Validate(bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            WorkflowExpression.Validate(bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            WorkflowExpression.Validate(bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            WorkflowExpression.Validate(bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            WorkflowExpression.Validate(bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            WorkflowExpression.Validate(bodyaVERAGEPAYDAYS, nameof(bodyaVERAGEPAYDAYS), required: false);
            WorkflowExpression.Validate(bodybALANCE, nameof(bodybALANCE), required: false);
            WorkflowExpression.Validate(bodycANAPPLYCHARGES, nameof(bodycANAPPLYCHARGES), required: false);
            WorkflowExpression.Validate(bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            WorkflowExpression.Validate(bodycOUNTRYCODE, nameof(bodycOUNTRYCODE), required: false);
            WorkflowExpression.Validate(bodycREDITAPPLIEDFOR, nameof(bodycREDITAPPLIEDFOR), required: false);
            WorkflowExpression.Validate(bodycREDITBUREAU, nameof(bodycREDITBUREAU), required: false);
            WorkflowExpression.Validate(bodycREDITLIMIT, nameof(bodycREDITLIMIT), required: false);
            WorkflowExpression.Validate(bodycREDITPOSITION, nameof(bodycREDITPOSITION), required: false);
            WorkflowExpression.Validate(bodycREDITREFERENCE, nameof(bodycREDITREFERENCE), required: false);
            WorkflowExpression.Validate(bodycURRENCY, nameof(bodycURRENCY), required: false);
            WorkflowExpression.Validate(bodydATECREDITAPPRECEIVED, nameof(bodydATECREDITAPPRECEIVED), required: false);
            WorkflowExpression.Validate(bodydEFNOMCODE, nameof(bodydEFNOMCODE), required: false);
            WorkflowExpression.Validate(bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            WorkflowExpression.Validate(bodydEPTNUMBER, nameof(bodydEPTNUMBER), required: false);
            WorkflowExpression.Validate(bodydISCOUNTRATE, nameof(bodydISCOUNTRATE), required: false);
            WorkflowExpression.Validate(bodydISCOUNTTYPE, nameof(bodydISCOUNTTYPE), required: false);
            WorkflowExpression.Validate(bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            WorkflowExpression.Validate(bodyeMAIL, nameof(bodyeMAIL), required: false);
            WorkflowExpression.Validate(bodyeMAIL2, nameof(bodyeMAIL2), required: false);
            WorkflowExpression.Validate(bodyeMAIL3, nameof(bodyeMAIL3), required: false);
            WorkflowExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowExpression.Validate(bodyfAX, nameof(bodyfAX), required: false);
            WorkflowExpression.Validate(bodyhOLDMAIL, nameof(bodyhOLDMAIL), required: false);
            WorkflowExpression.Validate(bodyiNACTIVEFLAG, nameof(bodyiNACTIVEFLAG), required: false);
            WorkflowExpression.Validate(bodyisACCOUNTREFAutogenerate, nameof(bodyisACCOUNTREFAutogenerate), required: false);
            WorkflowExpression.Validate(bodylASTCREDITREV, nameof(bodylASTCREDITREV), required: false);
            WorkflowExpression.Validate(bodynAME, nameof(bodynAME), required: false);
            WorkflowExpression.Validate(bodynEXTCREDITREV, nameof(bodynEXTCREDITREV), required: false);
            WorkflowExpression.Validate(bodyoVERRIDEPRODUCTNOMINAL, nameof(bodyoVERRIDEPRODUCTNOMINAL), required: false);
            WorkflowExpression.Validate(bodyoVERRIDEPRODUCTTAX, nameof(bodyoVERRIDEPRODUCTTAX), required: false);
            WorkflowExpression.Validate(bodypAYMENTDUEDAYS, nameof(bodypAYMENTDUEDAYS), required: false);
            WorkflowExpression.Validate(bodypRICELISTREF, nameof(bodypRICELISTREF), required: false);
            WorkflowExpression.Validate(bodypRIORITYTRADER, nameof(bodypRIORITYTRADER), required: false);
            WorkflowExpression.Validate(bodysENDINVOICESELECTRONICALLY, nameof(bodysENDINVOICESELECTRONICALLY), required: false);
            WorkflowExpression.Validate(bodysENDLETTERSELECTRONICALLY, nameof(bodysENDLETTERSELECTRONICALLY), required: false);
            WorkflowExpression.Validate(bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            WorkflowExpression.Validate(bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            WorkflowExpression.Validate(bodytELEPHONE, nameof(bodytELEPHONE), required: false);
            WorkflowExpression.Validate(bodytELEPHONE2, nameof(bodytELEPHONE2), required: false);
            WorkflowExpression.Validate(bodytERMS, nameof(bodytERMS), required: false);
            WorkflowExpression.Validate(bodytERMSAGREEDFLAG, nameof(bodytERMSAGREEDFLAG), required: false);
            WorkflowExpression.Validate(bodytRADECONTACT, nameof(bodytRADECONTACT), required: false);
            WorkflowExpression.Validate(bodyvATREGNUMBER, nameof(bodyvATREGNUMBER), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> __BuildSAGE50UKCreateNewSalesOrder(WorkflowExpression<string> bodyaCCOUNTREF = null, WorkflowExpression<string> bodyaDDRESS1 = null, WorkflowExpression<string> bodyaDDRESS2 = null, WorkflowExpression<string> bodyaDDRESS3 = null, WorkflowExpression<string> bodyaDDRESS4 = null, WorkflowExpression<string> bodyaDDRESS5 = null, WorkflowExpression<int> bodyaMOUNTPREPAID = null, WorkflowExpression<string> bodyaNALYSIS1 = null, WorkflowExpression<string> bodyaNALYSIS2 = null, WorkflowExpression<string> bodyaNALYSIS3 = null, WorkflowExpression<int> bodycARRDEPTNUMBER = null, WorkflowExpression<int> bodycARRNET = null, WorkflowExpression<string> bodycARRNOMCODE = null, WorkflowExpression<int> bodycARRTAX = null, WorkflowExpression<int> bodycARRTAXCODE = null, WorkflowExpression<string> bodycONSIGNMENTREF = null, WorkflowExpression<string> bodycONTACTNAME = null, WorkflowExpression<int> bodycOURIER = null, WorkflowExpression<int> bodycURRENCY = null, WorkflowExpression<int> bodycUSTDISCRATE = null, WorkflowExpression<string> bodycUSTORDERNUMBER = null, WorkflowExpression<string> bodycUSTTELNUMBER = null, WorkflowExpression<int> bodydEFTAXCODE = null, WorkflowExpression<bool> bodydELETEDFLAG = null, WorkflowExpression<string> bodydELIVERYNAME = null, WorkflowExpression<string> bodydELADDRESS1 = null, WorkflowExpression<string> bodydELADDRESS2 = null, WorkflowExpression<string> bodydELADDRESS3 = null, WorkflowExpression<string> bodydELADDRESS4 = null, WorkflowExpression<string> bodydELADDRESS5 = null, WorkflowExpression<string> bodydESPATCHDATE = null, WorkflowExpression<string> bodydUNSNUMBER = null, WorkflowExpression<int> bodygLOBALDEPTNUMBER = null, WorkflowExpression<string> bodygLOBALDETAILS = null, WorkflowExpression<string> bodygLOBALNOMCODE = null, WorkflowExpression<int> bodygLOBALTAXCODE = null, WorkflowExpression<string> bodyiNVOICENUMBER = null, WorkflowExpression<string> bodynAME = null, WorkflowExpression<string> bodyoRDERDATE = null, WorkflowExpression<int> bodyoRDERNUMBER = null, WorkflowExpression<int> bodyoRDERTYPE = null, WorkflowExpression<int> bodysETTLEMENTDISCRATE = null, WorkflowExpression<int> bodysETTLEMENTDUEDAYS = null, WorkflowExpression<bodysalesOrderLineItemInputItem222[]> bodysalesOrderLineItem = null)
        {
            WorkflowExpression.Validate(bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            WorkflowExpression.Validate(bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            WorkflowExpression.Validate(bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            WorkflowExpression.Validate(bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            WorkflowExpression.Validate(bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            WorkflowExpression.Validate(bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            WorkflowExpression.Validate(bodyaMOUNTPREPAID, nameof(bodyaMOUNTPREPAID), required: false);
            WorkflowExpression.Validate(bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            WorkflowExpression.Validate(bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            WorkflowExpression.Validate(bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            WorkflowExpression.Validate(bodycARRDEPTNUMBER, nameof(bodycARRDEPTNUMBER), required: false);
            WorkflowExpression.Validate(bodycARRNET, nameof(bodycARRNET), required: false);
            WorkflowExpression.Validate(bodycARRNOMCODE, nameof(bodycARRNOMCODE), required: false);
            WorkflowExpression.Validate(bodycARRTAX, nameof(bodycARRTAX), required: false);
            WorkflowExpression.Validate(bodycARRTAXCODE, nameof(bodycARRTAXCODE), required: false);
            WorkflowExpression.Validate(bodycONSIGNMENTREF, nameof(bodycONSIGNMENTREF), required: false);
            WorkflowExpression.Validate(bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            WorkflowExpression.Validate(bodycOURIER, nameof(bodycOURIER), required: false);
            WorkflowExpression.Validate(bodycURRENCY, nameof(bodycURRENCY), required: false);
            WorkflowExpression.Validate(bodycUSTDISCRATE, nameof(bodycUSTDISCRATE), required: false);
            WorkflowExpression.Validate(bodycUSTORDERNUMBER, nameof(bodycUSTORDERNUMBER), required: false);
            WorkflowExpression.Validate(bodycUSTTELNUMBER, nameof(bodycUSTTELNUMBER), required: false);
            WorkflowExpression.Validate(bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            WorkflowExpression.Validate(bodydELETEDFLAG, nameof(bodydELETEDFLAG), required: false);
            WorkflowExpression.Validate(bodydELIVERYNAME, nameof(bodydELIVERYNAME), required: false);
            WorkflowExpression.Validate(bodydELADDRESS1, nameof(bodydELADDRESS1), required: false);
            WorkflowExpression.Validate(bodydELADDRESS2, nameof(bodydELADDRESS2), required: false);
            WorkflowExpression.Validate(bodydELADDRESS3, nameof(bodydELADDRESS3), required: false);
            WorkflowExpression.Validate(bodydELADDRESS4, nameof(bodydELADDRESS4), required: false);
            WorkflowExpression.Validate(bodydELADDRESS5, nameof(bodydELADDRESS5), required: false);
            WorkflowExpression.Validate(bodydESPATCHDATE, nameof(bodydESPATCHDATE), required: false);
            WorkflowExpression.Validate(bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            WorkflowExpression.Validate(bodygLOBALDEPTNUMBER, nameof(bodygLOBALDEPTNUMBER), required: false);
            WorkflowExpression.Validate(bodygLOBALDETAILS, nameof(bodygLOBALDETAILS), required: false);
            WorkflowExpression.Validate(bodygLOBALNOMCODE, nameof(bodygLOBALNOMCODE), required: false);
            WorkflowExpression.Validate(bodygLOBALTAXCODE, nameof(bodygLOBALTAXCODE), required: false);
            WorkflowExpression.Validate(bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            WorkflowExpression.Validate(bodynAME, nameof(bodynAME), required: false);
            WorkflowExpression.Validate(bodyoRDERDATE, nameof(bodyoRDERDATE), required: false);
            WorkflowExpression.Validate(bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            WorkflowExpression.Validate(bodyoRDERTYPE, nameof(bodyoRDERTYPE), required: false);
            WorkflowExpression.Validate(bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            WorkflowExpression.Validate(bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            WorkflowExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> __BuildSAGE50USCreateNewCustomer(WorkflowExpression<string> bodyaccountNumber = null, WorkflowExpression<string> bodybillingCity = null, WorkflowExpression<string> bodybillingCountry = null, WorkflowExpression<string> bodybillingLastName = null, WorkflowExpression<string> bodybillingName = null, WorkflowExpression<string> bodybillingPostalCode = null, WorkflowExpression<string> bodybillingState = null, WorkflowExpression<string> bodybillingStreet = null, WorkflowExpression<bool> bodycCSalesRepresentative = null, WorkflowExpression<bool> bodychargeFinanceCharges = null, WorkflowExpression<string> bodycontactName = null, WorkflowExpression<int> bodycreditLimit = null, WorkflowExpression<int> bodycreditStatus = null, WorkflowExpression<string> bodycustomFieldValue1 = null, WorkflowExpression<string> bodycustomFieldValue2 = null, WorkflowExpression<string> bodycustomFieldValue3 = null, WorkflowExpression<string> bodycustomFieldValue4 = null, WorkflowExpression<string> bodycustomFieldValue5 = null, WorkflowExpression<string> bodycustomerGUID = null, WorkflowExpression<string> bodycustomerID = null, WorkflowExpression<int> bodycustomerBalance = null, WorkflowExpression<string> bodycustomerSinceDate = null, WorkflowExpression<string> bodycustomerType = null, WorkflowExpression<int> bodydiscountDays = null, WorkflowExpression<int> bodydiscountPercent = null, WorkflowExpression<int> bodydueDays = null, WorkflowExpression<string> bodyeMailAddress = null, WorkflowExpression<string> bodyfaxNumber = null, WorkflowExpression<int> bodyformDeliveryMethod = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyphoneNo1 = null, WorkflowExpression<string> bodyphoneNo2 = null, WorkflowExpression<int> bodypricingLevel = null, WorkflowExpression<string> bodysalesRepresentativeID = null, WorkflowExpression<string> bodysalesTaxCode = null, WorkflowExpression<string> bodyshippingCity = null, WorkflowExpression<string> bodyshippingCountry = null, WorkflowExpression<string> bodyshippingPostalCode = null, WorkflowExpression<string> bodyshippingState = null, WorkflowExpression<string> bodyshippingStreet = null, WorkflowExpression<bool> bodytermsType = null, WorkflowExpression<bool> bodyuseCODTerms = null, WorkflowExpression<bool> bodyuseDueMonthEndTerms = null, WorkflowExpression<bool> bodyusePrepaidTerms = null, WorkflowExpression<bool> bodyuseStandardTerms = null, WorkflowExpression<bool> bodyisInactive = null)
        {
            WorkflowExpression.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            WorkflowExpression.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            WorkflowExpression.Validate(bodybillingCountry, nameof(bodybillingCountry), required: false);
            WorkflowExpression.Validate(bodybillingLastName, nameof(bodybillingLastName), required: false);
            WorkflowExpression.Validate(bodybillingName, nameof(bodybillingName), required: false);
            WorkflowExpression.Validate(bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            WorkflowExpression.Validate(bodybillingState, nameof(bodybillingState), required: false);
            WorkflowExpression.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            WorkflowExpression.Validate(bodycCSalesRepresentative, nameof(bodycCSalesRepresentative), required: false);
            WorkflowExpression.Validate(bodychargeFinanceCharges, nameof(bodychargeFinanceCharges), required: false);
            WorkflowExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            WorkflowExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowExpression.Validate(bodycreditStatus, nameof(bodycreditStatus), required: false);
            WorkflowExpression.Validate(bodycustomFieldValue1, nameof(bodycustomFieldValue1), required: false);
            WorkflowExpression.Validate(bodycustomFieldValue2, nameof(bodycustomFieldValue2), required: false);
            WorkflowExpression.Validate(bodycustomFieldValue3, nameof(bodycustomFieldValue3), required: false);
            WorkflowExpression.Validate(bodycustomFieldValue4, nameof(bodycustomFieldValue4), required: false);
            WorkflowExpression.Validate(bodycustomFieldValue5, nameof(bodycustomFieldValue5), required: false);
            WorkflowExpression.Validate(bodycustomerGUID, nameof(bodycustomerGUID), required: false);
            WorkflowExpression.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            WorkflowExpression.Validate(bodycustomerBalance, nameof(bodycustomerBalance), required: false);
            WorkflowExpression.Validate(bodycustomerSinceDate, nameof(bodycustomerSinceDate), required: false);
            WorkflowExpression.Validate(bodycustomerType, nameof(bodycustomerType), required: false);
            WorkflowExpression.Validate(bodydiscountDays, nameof(bodydiscountDays), required: false);
            WorkflowExpression.Validate(bodydiscountPercent, nameof(bodydiscountPercent), required: false);
            WorkflowExpression.Validate(bodydueDays, nameof(bodydueDays), required: false);
            WorkflowExpression.Validate(bodyeMailAddress, nameof(bodyeMailAddress), required: false);
            WorkflowExpression.Validate(bodyfaxNumber, nameof(bodyfaxNumber), required: false);
            WorkflowExpression.Validate(bodyformDeliveryMethod, nameof(bodyformDeliveryMethod), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyphoneNo1, nameof(bodyphoneNo1), required: false);
            WorkflowExpression.Validate(bodyphoneNo2, nameof(bodyphoneNo2), required: false);
            WorkflowExpression.Validate(bodypricingLevel, nameof(bodypricingLevel), required: false);
            WorkflowExpression.Validate(bodysalesRepresentativeID, nameof(bodysalesRepresentativeID), required: false);
            WorkflowExpression.Validate(bodysalesTaxCode, nameof(bodysalesTaxCode), required: false);
            WorkflowExpression.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            WorkflowExpression.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            WorkflowExpression.Validate(bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            WorkflowExpression.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            WorkflowExpression.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            WorkflowExpression.Validate(bodytermsType, nameof(bodytermsType), required: false);
            WorkflowExpression.Validate(bodyuseCODTerms, nameof(bodyuseCODTerms), required: false);
            WorkflowExpression.Validate(bodyuseDueMonthEndTerms, nameof(bodyuseDueMonthEndTerms), required: false);
            WorkflowExpression.Validate(bodyusePrepaidTerms, nameof(bodyusePrepaidTerms), required: false);
            WorkflowExpression.Validate(bodyuseStandardTerms, nameof(bodyuseStandardTerms), required: false);
            WorkflowExpression.Validate(bodyisInactive, nameof(bodyisInactive), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> __BuildSAGE50USCreateNewSalesOrder(WorkflowExpression<string> bodyaccountsReceivableAccount = null, WorkflowExpression<string> bodyaccountsReceivableAcctGUID = null, WorkflowExpression<int> bodyaccountsReceivableAmount = null, WorkflowExpression<bool> bodyclosed = null, WorkflowExpression<string> bodycustomerID = null, WorkflowExpression<string> bodycustomerPO = null, WorkflowExpression<string> bodydate = null, WorkflowExpression<int> bodydiscountAmount = null, WorkflowExpression<string> bodydisplayedTerms = null, WorkflowExpression<bool> bodydropShip = null, WorkflowExpression<string> bodygUID = null, WorkflowExpression<bool> bodynotePrintsAfterLineItems = null, WorkflowExpression<bool> bodyproposal = null, WorkflowExpression<bool> bodyproposalAccepted = null, WorkflowExpression<bodysalesOrderLineItemInputItem2222[]> bodysalesOrderLineItem = null, WorkflowExpression<string> bodysalesOrderNumber = null, WorkflowExpression<string> bodysalesRepresentativeGUID = null, WorkflowExpression<string> bodysalesRepresentativeID = null, WorkflowExpression<string> bodyshipAddressCity = null, WorkflowExpression<string> bodyshipAddressCountry = null, WorkflowExpression<string> bodyshipAddressLine1 = null, WorkflowExpression<string> bodyshipAddressLine2 = null, WorkflowExpression<string> bodyshipAddressName = null, WorkflowExpression<string> bodyshipAddressState = null, WorkflowExpression<string> bodyshipAddressZipCode = null, WorkflowExpression<string> bodyshipBy = null, WorkflowExpression<string> bodyshipVIA = null, WorkflowExpression<bool> bodystatementNotePrintsBeforeInvRef = null)
        {
            WorkflowExpression.Validate(bodyaccountsReceivableAccount, nameof(bodyaccountsReceivableAccount), required: false);
            WorkflowExpression.Validate(bodyaccountsReceivableAcctGUID, nameof(bodyaccountsReceivableAcctGUID), required: false);
            WorkflowExpression.Validate(bodyaccountsReceivableAmount, nameof(bodyaccountsReceivableAmount), required: false);
            WorkflowExpression.Validate(bodyclosed, nameof(bodyclosed), required: false);
            WorkflowExpression.Validate(bodycustomerID, nameof(bodycustomerID), required: false);
            WorkflowExpression.Validate(bodycustomerPO, nameof(bodycustomerPO), required: false);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodydiscountAmount, nameof(bodydiscountAmount), required: false);
            WorkflowExpression.Validate(bodydisplayedTerms, nameof(bodydisplayedTerms), required: false);
            WorkflowExpression.Validate(bodydropShip, nameof(bodydropShip), required: false);
            WorkflowExpression.Validate(bodygUID, nameof(bodygUID), required: false);
            WorkflowExpression.Validate(bodynotePrintsAfterLineItems, nameof(bodynotePrintsAfterLineItems), required: false);
            WorkflowExpression.Validate(bodyproposal, nameof(bodyproposal), required: false);
            WorkflowExpression.Validate(bodyproposalAccepted, nameof(bodyproposalAccepted), required: false);
            WorkflowExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowExpression.Validate(bodysalesOrderNumber, nameof(bodysalesOrderNumber), required: false);
            WorkflowExpression.Validate(bodysalesRepresentativeGUID, nameof(bodysalesRepresentativeGUID), required: false);
            WorkflowExpression.Validate(bodysalesRepresentativeID, nameof(bodysalesRepresentativeID), required: false);
            WorkflowExpression.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            WorkflowExpression.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            WorkflowExpression.Validate(bodyshipAddressLine1, nameof(bodyshipAddressLine1), required: false);
            WorkflowExpression.Validate(bodyshipAddressLine2, nameof(bodyshipAddressLine2), required: false);
            WorkflowExpression.Validate(bodyshipAddressName, nameof(bodyshipAddressName), required: false);
            WorkflowExpression.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            WorkflowExpression.Validate(bodyshipAddressZipCode, nameof(bodyshipAddressZipCode), required: false);
            WorkflowExpression.Validate(bodyshipBy, nameof(bodyshipBy), required: false);
            WorkflowExpression.Validate(bodyshipVIA, nameof(bodyshipVIA), required: false);
            WorkflowExpression.Validate(bodystatementNotePrintsBeforeInvRef, nameof(bodystatementNotePrintsBeforeInvRef), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> __BuildSAPB1CreateNewCustomer(WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodybillingAddressName = null, WorkflowExpression<string> bodybillingBlock = null, WorkflowExpression<string> bodybillingCity = null, WorkflowExpression<string> bodybillingCountry = null, WorkflowExpression<string> bodybillingState = null, WorkflowExpression<string> bodybillingStreet = null, WorkflowExpression<string> bodybillingZipCode = null, WorkflowExpression<string> bodycardCode = null, WorkflowExpression<string> bodycardName = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycontactPerson = null, WorkflowExpression<string> bodycountry = null, WorkflowExpression<string> bodycounty = null, WorkflowExpression<string> bodycurrency = null, WorkflowExpression<string> bodyemailAddress = null, WorkflowExpression<string> bodyextraField = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodyfederalTaxID = null, WorkflowExpression<string> bodyfreeText = null, WorkflowExpression<int> bodygroupCode = null, WorkflowExpression<string> bodymailAddress = null, WorkflowExpression<string> bodymailCity = null, WorkflowExpression<string> bodymailCountry = null, WorkflowExpression<string> bodymailCounty = null, WorkflowExpression<string> bodymailZipCode = null, WorkflowExpression<string> bodynotes = null, WorkflowExpression<string> bodyphone1 = null, WorkflowExpression<string> bodyphone2 = null, WorkflowExpression<int> bodysalesPersonCode = null, WorkflowExpression<int> bodyseries = null, WorkflowExpression<string> bodyshippingAddressName = null, WorkflowExpression<string> bodyshippingBlock = null, WorkflowExpression<string> bodyshippingCity = null, WorkflowExpression<string> bodyshippingCountry = null, WorkflowExpression<string> bodyshippingState = null, WorkflowExpression<string> bodyshippingStreet = null, WorkflowExpression<string> bodyshippingZipCode = null, WorkflowExpression<string> bodywebSite = null, WorkflowExpression<string> bodyzipCode = null, WorkflowExpression<bodylstContactEmployeesInputItem[]> bodylstContactEmployees = null)
        {
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodybillingAddressName, nameof(bodybillingAddressName), required: false);
            WorkflowExpression.Validate(bodybillingBlock, nameof(bodybillingBlock), required: false);
            WorkflowExpression.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            WorkflowExpression.Validate(bodybillingCountry, nameof(bodybillingCountry), required: false);
            WorkflowExpression.Validate(bodybillingState, nameof(bodybillingState), required: false);
            WorkflowExpression.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            WorkflowExpression.Validate(bodybillingZipCode, nameof(bodybillingZipCode), required: false);
            WorkflowExpression.Validate(bodycardCode, nameof(bodycardCode), required: false);
            WorkflowExpression.Validate(bodycardName, nameof(bodycardName), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycontactPerson, nameof(bodycontactPerson), required: false);
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            WorkflowExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            WorkflowExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            WorkflowExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodyfederalTaxID, nameof(bodyfederalTaxID), required: false);
            WorkflowExpression.Validate(bodyfreeText, nameof(bodyfreeText), required: false);
            WorkflowExpression.Validate(bodygroupCode, nameof(bodygroupCode), required: false);
            WorkflowExpression.Validate(bodymailAddress, nameof(bodymailAddress), required: false);
            WorkflowExpression.Validate(bodymailCity, nameof(bodymailCity), required: false);
            WorkflowExpression.Validate(bodymailCountry, nameof(bodymailCountry), required: false);
            WorkflowExpression.Validate(bodymailCounty, nameof(bodymailCounty), required: false);
            WorkflowExpression.Validate(bodymailZipCode, nameof(bodymailZipCode), required: false);
            WorkflowExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            WorkflowExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            WorkflowExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            WorkflowExpression.Validate(bodysalesPersonCode, nameof(bodysalesPersonCode), required: false);
            WorkflowExpression.Validate(bodyseries, nameof(bodyseries), required: false);
            WorkflowExpression.Validate(bodyshippingAddressName, nameof(bodyshippingAddressName), required: false);
            WorkflowExpression.Validate(bodyshippingBlock, nameof(bodyshippingBlock), required: false);
            WorkflowExpression.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            WorkflowExpression.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            WorkflowExpression.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            WorkflowExpression.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            WorkflowExpression.Validate(bodyshippingZipCode, nameof(bodyshippingZipCode), required: false);
            WorkflowExpression.Validate(bodywebSite, nameof(bodywebSite), required: false);
            WorkflowExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            WorkflowExpression.Validate(bodylstContactEmployees, nameof(bodylstContactEmployees), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> __BuildSAPB1CreateNewSalesOrder(WorkflowExpression<string> bodycardCode = null, WorkflowExpression<string> bodydocDate = null, WorkflowExpression<string> bodydocDueDate = null, WorkflowExpression<int> bodydocNum = null, WorkflowExpression<bodysalesOrderLineItemInputItem22222[]> bodysalesOrderLineItem = null, WorkflowExpression<int> bodyseries = null, WorkflowExpression<string> bodytaxDate = null)
        {
            WorkflowExpression.Validate(bodycardCode, nameof(bodycardCode), required: false);
            WorkflowExpression.Validate(bodydocDate, nameof(bodydocDate), required: false);
            WorkflowExpression.Validate(bodydocDueDate, nameof(bodydocDueDate), required: false);
            WorkflowExpression.Validate(bodydocNum, nameof(bodydocNum), required: false);
            WorkflowExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            WorkflowExpression.Validate(bodyseries, nameof(bodyseries), required: false);
            WorkflowExpression.Validate(bodytaxDate, nameof(bodytaxDate), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> __BuildSYSPROCreateNewCustomer(WorkflowExpression<string> bodyaddTelephone = null, WorkflowExpression<string> bodyaltMethodFlag = null, WorkflowExpression<string> bodyapplyLineDisc = null, WorkflowExpression<string> bodyapplyOrdDisc = null, WorkflowExpression<string> bodyarStatementNo = null, WorkflowExpression<string> bodyarea = null, WorkflowExpression<string> bodybackOrdReqd = null, WorkflowExpression<string> bodybalanceType = null, WorkflowExpression<string> bodybranch = null, WorkflowExpression<string> bodybuyingGroup1 = null, WorkflowExpression<string> bodybuyingGroup2 = null, WorkflowExpression<string> bodybuyingGroup3 = null, WorkflowExpression<string> bodybuyingGroup4 = null, WorkflowExpression<string> bodybuyingGroup5 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycity1 = null, WorkflowExpression<string> bodycompanyTaxNumber = null, WorkflowExpression<string> bodycontact = null, WorkflowExpression<string> bodycontractPrcReqd = null, WorkflowExpression<string> bodycounterSlsOnly = null, WorkflowExpression<string> bodycountyZip = null, WorkflowExpression<string> bodycountyZip1 = null, WorkflowExpression<string> bodycreditCheckFlag = null, WorkflowExpression<string> bodycreditLimit = null, WorkflowExpression<string> bodycreditStatus = null, WorkflowExpression<string> bodycurrency = null, WorkflowExpression<string> bodycustomerClass = null, WorkflowExpression<string> bodycustomerCode = null, WorkflowExpression<string> bodycustomerOnHold = null, WorkflowExpression<string> bodydateCustAdded = null, WorkflowExpression<string> bodydefaultOrdType = null, WorkflowExpression<string> bodydeliveryTerms = null, WorkflowExpression<string> bodydeliveryTermsC = null, WorkflowExpression<string> bodydetailMoveReqd = null, WorkflowExpression<string> bodydocFax = null, WorkflowExpression<string> bodydocFaxContact = null, WorkflowExpression<string> bodyediFlag = null, WorkflowExpression<string> bodyediSenderCode = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyexemptFinChg = null, WorkflowExpression<string> bodyfax = null, WorkflowExpression<string> bodyfaxInvoices = null, WorkflowExpression<string> bodyfaxQuotes = null, WorkflowExpression<string> bodyfaxStatements = null, WorkflowExpression<string> bodygstExemptFlag = null, WorkflowExpression<string> bodygstExemptNum = null, WorkflowExpression<string> bodygstLevel = null, WorkflowExpression<string> bodyhighInv = null, WorkflowExpression<string> bodyhighInvDays = null, WorkflowExpression<string> bodyhighestBalance = null, WorkflowExpression<string> bodyibtCustomer = null, WorkflowExpression<string> bodyinvCommentCode = null, WorkflowExpression<string> bodyinvDiscCode = null, WorkflowExpression<string> bodylanguageCode = null, WorkflowExpression<string> bodylineDiscCode = null, WorkflowExpression<string> bodymaintHistory = null, WorkflowExpression<string> bodymaintLastPrcPaid = null, WorkflowExpression<string> bodyminimumOrderChgCod = null, WorkflowExpression<string> bodyminimumOrderValue = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodynationality = null, WorkflowExpression<string> bodynewCustomerCode = null, WorkflowExpression<string> bodypoNumberMandatory = null, WorkflowExpression<string> bodypriceCategoryTable = null, WorkflowExpression<string> bodypriceCode = null, WorkflowExpression<string> bodyrouteCode = null, WorkflowExpression<string> bodyrouteDistance = null, WorkflowExpression<string> bodysalesWarehouse = null, WorkflowExpression<string> bodysalesperson = null, WorkflowExpression<string> bodysalesperson1 = null, WorkflowExpression<string> bodysalesperson2 = null, WorkflowExpression<string> bodysalesperson3 = null, WorkflowExpression<string> bodyshipPostalCode = null, WorkflowExpression<string> bodyshipToAddr1 = null, WorkflowExpression<string> bodyshipToAddr2 = null, WorkflowExpression<string> bodyshipToAddr3 = null, WorkflowExpression<string> bodyshipToAddr3Loc = null, WorkflowExpression<string> bodyshipToAddr4 = null, WorkflowExpression<string> bodyshipToAddr5 = null, WorkflowExpression<string> bodyshipToGpsLat = null, WorkflowExpression<string> bodyshipToGpsLong = null, WorkflowExpression<string> bodyshippingInstrs = null, WorkflowExpression<string> bodyshippingInstrsCod = null, WorkflowExpression<string> bodyshippingLocation = null, WorkflowExpression<string> bodyshortName = null, WorkflowExpression<string> bodysoDefaultDoc = null, WorkflowExpression<string> bodysoDefaultType = null, WorkflowExpression<string> bodysoldPostalCode = null, WorkflowExpression<string> bodysoldToAddr1 = null, WorkflowExpression<string> bodysoldToAddr2 = null, WorkflowExpression<string> bodysoldToAddr3 = null, WorkflowExpression<string> bodysoldToAddr3Loc = null, WorkflowExpression<string> bodysoldToAddr4 = null, WorkflowExpression<string> bodysoldToAddr5 = null, WorkflowExpression<string> bodysoldToGpsLat = null, WorkflowExpression<string> bodysoldToGpsLong = null, WorkflowExpression<string> bodyspecialInstrs = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodystate1 = null, WorkflowExpression<string> bodystateCode = null, WorkflowExpression<string> bodystatementReqd = null, WorkflowExpression<string> bodystockInterchange = null, WorkflowExpression<string> bodytagsToDropFromXML = null, WorkflowExpression<string> bodytaxExemptNumber = null, WorkflowExpression<string> bodytaxStatus = null, WorkflowExpression<string> bodytelephone = null, WorkflowExpression<string> bodytelephoneExtn = null, WorkflowExpression<string> bodytelex = null, WorkflowExpression<string> bodytermsCode = null, WorkflowExpression<string> bodytpmCreditCheck = null, WorkflowExpression<string> bodytpmCustomerFlag = null, WorkflowExpression<string> bodytpmPricingFlag = null, WorkflowExpression<string> bodytransactionNature = null, WorkflowExpression<string> bodytransactionNatureC = null, WorkflowExpression<string> bodyukCurrency = null, WorkflowExpression<string> bodyukVatFlag = null, WorkflowExpression<string> bodyuserField1 = null, WorkflowExpression<string> bodyuserField2 = null, WorkflowExpression<string> bodywholeOrderShipFlag = null, WorkflowExpression<string> bodyeSignature = null)
        {
            WorkflowExpression.Validate(bodyaddTelephone, nameof(bodyaddTelephone), required: false);
            WorkflowExpression.Validate(bodyaltMethodFlag, nameof(bodyaltMethodFlag), required: false);
            WorkflowExpression.Validate(bodyapplyLineDisc, nameof(bodyapplyLineDisc), required: false);
            WorkflowExpression.Validate(bodyapplyOrdDisc, nameof(bodyapplyOrdDisc), required: false);
            WorkflowExpression.Validate(bodyarStatementNo, nameof(bodyarStatementNo), required: false);
            WorkflowExpression.Validate(bodyarea, nameof(bodyarea), required: false);
            WorkflowExpression.Validate(bodybackOrdReqd, nameof(bodybackOrdReqd), required: false);
            WorkflowExpression.Validate(bodybalanceType, nameof(bodybalanceType), required: false);
            WorkflowExpression.Validate(bodybranch, nameof(bodybranch), required: false);
            WorkflowExpression.Validate(bodybuyingGroup1, nameof(bodybuyingGroup1), required: false);
            WorkflowExpression.Validate(bodybuyingGroup2, nameof(bodybuyingGroup2), required: false);
            WorkflowExpression.Validate(bodybuyingGroup3, nameof(bodybuyingGroup3), required: false);
            WorkflowExpression.Validate(bodybuyingGroup4, nameof(bodybuyingGroup4), required: false);
            WorkflowExpression.Validate(bodybuyingGroup5, nameof(bodybuyingGroup5), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycity1, nameof(bodycity1), required: false);
            WorkflowExpression.Validate(bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            WorkflowExpression.Validate(bodycontact, nameof(bodycontact), required: false);
            WorkflowExpression.Validate(bodycontractPrcReqd, nameof(bodycontractPrcReqd), required: false);
            WorkflowExpression.Validate(bodycounterSlsOnly, nameof(bodycounterSlsOnly), required: false);
            WorkflowExpression.Validate(bodycountyZip, nameof(bodycountyZip), required: false);
            WorkflowExpression.Validate(bodycountyZip1, nameof(bodycountyZip1), required: false);
            WorkflowExpression.Validate(bodycreditCheckFlag, nameof(bodycreditCheckFlag), required: false);
            WorkflowExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            WorkflowExpression.Validate(bodycreditStatus, nameof(bodycreditStatus), required: false);
            WorkflowExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowExpression.Validate(bodycustomerClass, nameof(bodycustomerClass), required: false);
            WorkflowExpression.Validate(bodycustomerCode, nameof(bodycustomerCode), required: false);
            WorkflowExpression.Validate(bodycustomerOnHold, nameof(bodycustomerOnHold), required: false);
            WorkflowExpression.Validate(bodydateCustAdded, nameof(bodydateCustAdded), required: false);
            WorkflowExpression.Validate(bodydefaultOrdType, nameof(bodydefaultOrdType), required: false);
            WorkflowExpression.Validate(bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            WorkflowExpression.Validate(bodydeliveryTermsC, nameof(bodydeliveryTermsC), required: false);
            WorkflowExpression.Validate(bodydetailMoveReqd, nameof(bodydetailMoveReqd), required: false);
            WorkflowExpression.Validate(bodydocFax, nameof(bodydocFax), required: false);
            WorkflowExpression.Validate(bodydocFaxContact, nameof(bodydocFaxContact), required: false);
            WorkflowExpression.Validate(bodyediFlag, nameof(bodyediFlag), required: false);
            WorkflowExpression.Validate(bodyediSenderCode, nameof(bodyediSenderCode), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyexemptFinChg, nameof(bodyexemptFinChg), required: false);
            WorkflowExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            WorkflowExpression.Validate(bodyfaxInvoices, nameof(bodyfaxInvoices), required: false);
            WorkflowExpression.Validate(bodyfaxQuotes, nameof(bodyfaxQuotes), required: false);
            WorkflowExpression.Validate(bodyfaxStatements, nameof(bodyfaxStatements), required: false);
            WorkflowExpression.Validate(bodygstExemptFlag, nameof(bodygstExemptFlag), required: false);
            WorkflowExpression.Validate(bodygstExemptNum, nameof(bodygstExemptNum), required: false);
            WorkflowExpression.Validate(bodygstLevel, nameof(bodygstLevel), required: false);
            WorkflowExpression.Validate(bodyhighInv, nameof(bodyhighInv), required: false);
            WorkflowExpression.Validate(bodyhighInvDays, nameof(bodyhighInvDays), required: false);
            WorkflowExpression.Validate(bodyhighestBalance, nameof(bodyhighestBalance), required: false);
            WorkflowExpression.Validate(bodyibtCustomer, nameof(bodyibtCustomer), required: false);
            WorkflowExpression.Validate(bodyinvCommentCode, nameof(bodyinvCommentCode), required: false);
            WorkflowExpression.Validate(bodyinvDiscCode, nameof(bodyinvDiscCode), required: false);
            WorkflowExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            WorkflowExpression.Validate(bodylineDiscCode, nameof(bodylineDiscCode), required: false);
            WorkflowExpression.Validate(bodymaintHistory, nameof(bodymaintHistory), required: false);
            WorkflowExpression.Validate(bodymaintLastPrcPaid, nameof(bodymaintLastPrcPaid), required: false);
            WorkflowExpression.Validate(bodyminimumOrderChgCod, nameof(bodyminimumOrderChgCod), required: false);
            WorkflowExpression.Validate(bodyminimumOrderValue, nameof(bodyminimumOrderValue), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowExpression.Validate(bodynewCustomerCode, nameof(bodynewCustomerCode), required: false);
            WorkflowExpression.Validate(bodypoNumberMandatory, nameof(bodypoNumberMandatory), required: false);
            WorkflowExpression.Validate(bodypriceCategoryTable, nameof(bodypriceCategoryTable), required: false);
            WorkflowExpression.Validate(bodypriceCode, nameof(bodypriceCode), required: false);
            WorkflowExpression.Validate(bodyrouteCode, nameof(bodyrouteCode), required: false);
            WorkflowExpression.Validate(bodyrouteDistance, nameof(bodyrouteDistance), required: false);
            WorkflowExpression.Validate(bodysalesWarehouse, nameof(bodysalesWarehouse), required: false);
            WorkflowExpression.Validate(bodysalesperson, nameof(bodysalesperson), required: false);
            WorkflowExpression.Validate(bodysalesperson1, nameof(bodysalesperson1), required: false);
            WorkflowExpression.Validate(bodysalesperson2, nameof(bodysalesperson2), required: false);
            WorkflowExpression.Validate(bodysalesperson3, nameof(bodysalesperson3), required: false);
            WorkflowExpression.Validate(bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            WorkflowExpression.Validate(bodyshipToAddr1, nameof(bodyshipToAddr1), required: false);
            WorkflowExpression.Validate(bodyshipToAddr2, nameof(bodyshipToAddr2), required: false);
            WorkflowExpression.Validate(bodyshipToAddr3, nameof(bodyshipToAddr3), required: false);
            WorkflowExpression.Validate(bodyshipToAddr3Loc, nameof(bodyshipToAddr3Loc), required: false);
            WorkflowExpression.Validate(bodyshipToAddr4, nameof(bodyshipToAddr4), required: false);
            WorkflowExpression.Validate(bodyshipToAddr5, nameof(bodyshipToAddr5), required: false);
            WorkflowExpression.Validate(bodyshipToGpsLat, nameof(bodyshipToGpsLat), required: false);
            WorkflowExpression.Validate(bodyshipToGpsLong, nameof(bodyshipToGpsLong), required: false);
            WorkflowExpression.Validate(bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            WorkflowExpression.Validate(bodyshippingInstrsCod, nameof(bodyshippingInstrsCod), required: false);
            WorkflowExpression.Validate(bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            WorkflowExpression.Validate(bodyshortName, nameof(bodyshortName), required: false);
            WorkflowExpression.Validate(bodysoDefaultDoc, nameof(bodysoDefaultDoc), required: false);
            WorkflowExpression.Validate(bodysoDefaultType, nameof(bodysoDefaultType), required: false);
            WorkflowExpression.Validate(bodysoldPostalCode, nameof(bodysoldPostalCode), required: false);
            WorkflowExpression.Validate(bodysoldToAddr1, nameof(bodysoldToAddr1), required: false);
            WorkflowExpression.Validate(bodysoldToAddr2, nameof(bodysoldToAddr2), required: false);
            WorkflowExpression.Validate(bodysoldToAddr3, nameof(bodysoldToAddr3), required: false);
            WorkflowExpression.Validate(bodysoldToAddr3Loc, nameof(bodysoldToAddr3Loc), required: false);
            WorkflowExpression.Validate(bodysoldToAddr4, nameof(bodysoldToAddr4), required: false);
            WorkflowExpression.Validate(bodysoldToAddr5, nameof(bodysoldToAddr5), required: false);
            WorkflowExpression.Validate(bodysoldToGpsLat, nameof(bodysoldToGpsLat), required: false);
            WorkflowExpression.Validate(bodysoldToGpsLong, nameof(bodysoldToGpsLong), required: false);
            WorkflowExpression.Validate(bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodystate1, nameof(bodystate1), required: false);
            WorkflowExpression.Validate(bodystateCode, nameof(bodystateCode), required: false);
            WorkflowExpression.Validate(bodystatementReqd, nameof(bodystatementReqd), required: false);
            WorkflowExpression.Validate(bodystockInterchange, nameof(bodystockInterchange), required: false);
            WorkflowExpression.Validate(bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            WorkflowExpression.Validate(bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            WorkflowExpression.Validate(bodytaxStatus, nameof(bodytaxStatus), required: false);
            WorkflowExpression.Validate(bodytelephone, nameof(bodytelephone), required: false);
            WorkflowExpression.Validate(bodytelephoneExtn, nameof(bodytelephoneExtn), required: false);
            WorkflowExpression.Validate(bodytelex, nameof(bodytelex), required: false);
            WorkflowExpression.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            WorkflowExpression.Validate(bodytpmCreditCheck, nameof(bodytpmCreditCheck), required: false);
            WorkflowExpression.Validate(bodytpmCustomerFlag, nameof(bodytpmCustomerFlag), required: false);
            WorkflowExpression.Validate(bodytpmPricingFlag, nameof(bodytpmPricingFlag), required: false);
            WorkflowExpression.Validate(bodytransactionNature, nameof(bodytransactionNature), required: false);
            WorkflowExpression.Validate(bodytransactionNatureC, nameof(bodytransactionNatureC), required: false);
            WorkflowExpression.Validate(bodyukCurrency, nameof(bodyukCurrency), required: false);
            WorkflowExpression.Validate(bodyukVatFlag, nameof(bodyukVatFlag), required: false);
            WorkflowExpression.Validate(bodyuserField1, nameof(bodyuserField1), required: false);
            WorkflowExpression.Validate(bodyuserField2, nameof(bodyuserField2), required: false);
            WorkflowExpression.Validate(bodywholeOrderShipFlag, nameof(bodywholeOrderShipFlag), required: false);
            WorkflowExpression.Validate(bodyeSignature, nameof(bodyeSignature), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> __BuildSYSPROCreateNewSalesOrder(WorkflowExpression<string> bodyacceptEarlierShipDate = null, WorkflowExpression<string> bodyacceptKitOptional = null, WorkflowExpression<string> bodyacceptOrdersIfNoCredit = null, WorkflowExpression<string> bodyaddAttachedServiceCharges = null, WorkflowExpression<string> bodyaddDangerousGoodsText = null, WorkflowExpression<string> bodyaddStockSalesOrderText = null, WorkflowExpression<string> bodyallocationAction = null, WorkflowExpression<string> bodyallowBackOrderForNegativeMerchLine = null, WorkflowExpression<string> bodyallowBackOrderForPartialHold = null, WorkflowExpression<string> bodyallowBackOrderForSuperseded = null, WorkflowExpression<string> bodyallowChangeToZeroPrice = null, WorkflowExpression<string> bodyallowDuplicateOrderNumbers = null, WorkflowExpression<string> bodyallowManualOrderNumberToBeUsed = null, WorkflowExpression<string> bodyallowNonStockItems = null, WorkflowExpression<string> bodyallowZeroPrice = null, WorkflowExpression<string> bodyalternateReference = null, WorkflowExpression<string> bodyalwaysUsePriceEntered = null, WorkflowExpression<string> bodyapplyLeadTimeCalculation = null, WorkflowExpression<string> bodyapplyParentDiscountToComponents = null, WorkflowExpression<string> bodyarea = null, WorkflowExpression<string> bodybranch = null, WorkflowExpression<string> bodycancelReasonCode = null, WorkflowExpression<string> bodycheckForCustomerPoNumbers = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycompanyTaxNumber = null, WorkflowExpression<string> bodycountyZip = null, WorkflowExpression<string> bodycreditFailMessage = null, WorkflowExpression<string> bodycurrency = null, WorkflowExpression<string> bodycustomer = null, WorkflowExpression<string> bodycustomerName = null, WorkflowExpression<string> bodycustomerPoNumber = null, WorkflowExpression<string> bodycustomerToUse = null, WorkflowExpression<string> bodydeliveryRoute = null, WorkflowExpression<string> bodydeliveryRouteAction = null, WorkflowExpression<string> bodydeliveryTerms = null, WorkflowExpression<string> bodydocumentFormat = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyglobalTradePromotionCodes = null, WorkflowExpression<string> bodygstExemptNumber = null, WorkflowExpression<string> bodygstExemptionStatus = null, WorkflowExpression<string> bodyheaderFreightCharges = null, WorkflowExpression<string> bodyheaderMiscCharges = null, WorkflowExpression<string> bodyignoreWarnings = null, WorkflowExpression<string> bodyinBoxMsgReqd = null, WorkflowExpression<string> bodyincludeInMrp = null, WorkflowExpression<string> bodyinvoiceDateEntered = null, WorkflowExpression<string> bodyinvoiceNumberEntered = null, WorkflowExpression<string> bodyinvoiceTerms = null, WorkflowExpression<string> bodyinvoiceWholeOrderOnly = null, WorkflowExpression<string> bodylanguageCode = null, WorkflowExpression<string> bodyminimumDaysToShip = null, WorkflowExpression<string> bodymultiShipCode = null, WorkflowExpression<string> bodynationality = null, WorkflowExpression<string> bodynewCustomerPoNumber = null, WorkflowExpression<string> bodynewSalesOrderNumber = null, WorkflowExpression<string> bodyoperatorToInform = null, WorkflowExpression<string> bodyorderActionType = null, WorkflowExpression<string> bodyorderComments = null, WorkflowExpression<string> bodyorderDate = null, WorkflowExpression<string> bodyorderDiscPercent1 = null, WorkflowExpression<string> bodyorderDiscPercent2 = null, WorkflowExpression<string> bodyorderDiscPercent3 = null, WorkflowExpression<string> bodyorderStatus = null, WorkflowExpression<string> bodyorderType = null, WorkflowExpression<string> bodyoverrideCustomerBackOrder = null, WorkflowExpression<string> bodypOSSalesOrder = null, WorkflowExpression<string> bodyprocess = null, WorkflowExpression<string> bodyprocessFlag = null, WorkflowExpression<string> bodyputEntireQuantityOnNewLoadWhenChanged = null, WorkflowExpression<string> bodyreceiverCode = null, WorkflowExpression<string> bodyrequestedShipDate = null, WorkflowExpression<string> bodyreserveStock = null, WorkflowExpression<string> bodyreserveStockRequestAllocs = null, WorkflowExpression<string> bodysalesOrder = null, WorkflowExpression<bodysalesOrderDetailsInputItem[]> bodysalesOrderDetails = null, WorkflowExpression<bodysalesOrderFooterCommentsInputItem[]> bodysalesOrderFooterComments = null, WorkflowExpression<bodysalesOrderFreightDetailsInputItem[]> bodysalesOrderFreightDetails = null, WorkflowExpression<bodysalesOrderHeaderCommentsInputItem[]> bodysalesOrderHeaderComments = null, WorkflowExpression<bodysalesOrderMiscChargesDetailsInputItem[]> bodysalesOrderMiscChargesDetails = null, WorkflowExpression<string> bodysalesOrderPromoQualifyAction = null, WorkflowExpression<string> bodysalesOrderPromoSelectAction = null, WorkflowExpression<string> bodysalesperson = null, WorkflowExpression<string> bodysenderCode = null, WorkflowExpression<string> bodyshipAddress1 = null, WorkflowExpression<string> bodyshipAddress2 = null, WorkflowExpression<string> bodyshipAddress3 = null, WorkflowExpression<string> bodyshipAddress3Locality = null, WorkflowExpression<string> bodyshipAddress4 = null, WorkflowExpression<string> bodyshipAddress5 = null, WorkflowExpression<string> bodyshipAddressPerLine = null, WorkflowExpression<string> bodyshipAddressPerLineTax = null, WorkflowExpression<string> bodyshipGpsLat = null, WorkflowExpression<string> bodyshipGpsLong = null, WorkflowExpression<string> bodyshipPostalCode = null, WorkflowExpression<string> bodyshippingInstrs = null, WorkflowExpression<string> bodyshippingInstrsCode = null, WorkflowExpression<string> bodyshippingLocation = null, WorkflowExpression<string> bodyspecialInstrs = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodystatusInProcess = null, WorkflowExpression<string> bodystatusInProcessResponse = null, WorkflowExpression<string> bodysupplier = null, WorkflowExpression<string> bodytagsToDropFromXML = null, WorkflowExpression<string> bodytaxExemptNumber = null, WorkflowExpression<string> bodytaxExemptionStatus = null, WorkflowExpression<string> bodytransactionNature = null, WorkflowExpression<string> bodytransmissionReference = null, WorkflowExpression<string> bodytransportMode = null, WorkflowExpression<string> bodytypeOfOrder = null, WorkflowExpression<string> bodyuseCustomerSalesWarehouse = null, WorkflowExpression<string> bodyuseMasterAccountForCustomerPartNo = null, WorkflowExpression<string> bodyuseStockDescSupplied = null, WorkflowExpression<string> bodyvalidateShippingInstrs = null, WorkflowExpression<string> bodywarehouse = null, WorkflowExpression<string> bodywarehouseListToUse = null, WorkflowExpression<string> bodywarnIfCustomerOnHold = null, WorkflowExpression<string> bodyeSignature = null)
        {
            WorkflowExpression.Validate(bodyacceptEarlierShipDate, nameof(bodyacceptEarlierShipDate), required: false);
            WorkflowExpression.Validate(bodyacceptKitOptional, nameof(bodyacceptKitOptional), required: false);
            WorkflowExpression.Validate(bodyacceptOrdersIfNoCredit, nameof(bodyacceptOrdersIfNoCredit), required: false);
            WorkflowExpression.Validate(bodyaddAttachedServiceCharges, nameof(bodyaddAttachedServiceCharges), required: false);
            WorkflowExpression.Validate(bodyaddDangerousGoodsText, nameof(bodyaddDangerousGoodsText), required: false);
            WorkflowExpression.Validate(bodyaddStockSalesOrderText, nameof(bodyaddStockSalesOrderText), required: false);
            WorkflowExpression.Validate(bodyallocationAction, nameof(bodyallocationAction), required: false);
            WorkflowExpression.Validate(bodyallowBackOrderForNegativeMerchLine, nameof(bodyallowBackOrderForNegativeMerchLine), required: false);
            WorkflowExpression.Validate(bodyallowBackOrderForPartialHold, nameof(bodyallowBackOrderForPartialHold), required: false);
            WorkflowExpression.Validate(bodyallowBackOrderForSuperseded, nameof(bodyallowBackOrderForSuperseded), required: false);
            WorkflowExpression.Validate(bodyallowChangeToZeroPrice, nameof(bodyallowChangeToZeroPrice), required: false);
            WorkflowExpression.Validate(bodyallowDuplicateOrderNumbers, nameof(bodyallowDuplicateOrderNumbers), required: false);
            WorkflowExpression.Validate(bodyallowManualOrderNumberToBeUsed, nameof(bodyallowManualOrderNumberToBeUsed), required: false);
            WorkflowExpression.Validate(bodyallowNonStockItems, nameof(bodyallowNonStockItems), required: false);
            WorkflowExpression.Validate(bodyallowZeroPrice, nameof(bodyallowZeroPrice), required: false);
            WorkflowExpression.Validate(bodyalternateReference, nameof(bodyalternateReference), required: false);
            WorkflowExpression.Validate(bodyalwaysUsePriceEntered, nameof(bodyalwaysUsePriceEntered), required: false);
            WorkflowExpression.Validate(bodyapplyLeadTimeCalculation, nameof(bodyapplyLeadTimeCalculation), required: false);
            WorkflowExpression.Validate(bodyapplyParentDiscountToComponents, nameof(bodyapplyParentDiscountToComponents), required: false);
            WorkflowExpression.Validate(bodyarea, nameof(bodyarea), required: false);
            WorkflowExpression.Validate(bodybranch, nameof(bodybranch), required: false);
            WorkflowExpression.Validate(bodycancelReasonCode, nameof(bodycancelReasonCode), required: false);
            WorkflowExpression.Validate(bodycheckForCustomerPoNumbers, nameof(bodycheckForCustomerPoNumbers), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            WorkflowExpression.Validate(bodycountyZip, nameof(bodycountyZip), required: false);
            WorkflowExpression.Validate(bodycreditFailMessage, nameof(bodycreditFailMessage), required: false);
            WorkflowExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            WorkflowExpression.Validate(bodycustomer, nameof(bodycustomer), required: false);
            WorkflowExpression.Validate(bodycustomerName, nameof(bodycustomerName), required: false);
            WorkflowExpression.Validate(bodycustomerPoNumber, nameof(bodycustomerPoNumber), required: false);
            WorkflowExpression.Validate(bodycustomerToUse, nameof(bodycustomerToUse), required: false);
            WorkflowExpression.Validate(bodydeliveryRoute, nameof(bodydeliveryRoute), required: false);
            WorkflowExpression.Validate(bodydeliveryRouteAction, nameof(bodydeliveryRouteAction), required: false);
            WorkflowExpression.Validate(bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            WorkflowExpression.Validate(bodydocumentFormat, nameof(bodydocumentFormat), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyglobalTradePromotionCodes, nameof(bodyglobalTradePromotionCodes), required: false);
            WorkflowExpression.Validate(bodygstExemptNumber, nameof(bodygstExemptNumber), required: false);
            WorkflowExpression.Validate(bodygstExemptionStatus, nameof(bodygstExemptionStatus), required: false);
            WorkflowExpression.Validate(bodyheaderFreightCharges, nameof(bodyheaderFreightCharges), required: false);
            WorkflowExpression.Validate(bodyheaderMiscCharges, nameof(bodyheaderMiscCharges), required: false);
            WorkflowExpression.Validate(bodyignoreWarnings, nameof(bodyignoreWarnings), required: false);
            WorkflowExpression.Validate(bodyinBoxMsgReqd, nameof(bodyinBoxMsgReqd), required: false);
            WorkflowExpression.Validate(bodyincludeInMrp, nameof(bodyincludeInMrp), required: false);
            WorkflowExpression.Validate(bodyinvoiceDateEntered, nameof(bodyinvoiceDateEntered), required: false);
            WorkflowExpression.Validate(bodyinvoiceNumberEntered, nameof(bodyinvoiceNumberEntered), required: false);
            WorkflowExpression.Validate(bodyinvoiceTerms, nameof(bodyinvoiceTerms), required: false);
            WorkflowExpression.Validate(bodyinvoiceWholeOrderOnly, nameof(bodyinvoiceWholeOrderOnly), required: false);
            WorkflowExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            WorkflowExpression.Validate(bodyminimumDaysToShip, nameof(bodyminimumDaysToShip), required: false);
            WorkflowExpression.Validate(bodymultiShipCode, nameof(bodymultiShipCode), required: false);
            WorkflowExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            WorkflowExpression.Validate(bodynewCustomerPoNumber, nameof(bodynewCustomerPoNumber), required: false);
            WorkflowExpression.Validate(bodynewSalesOrderNumber, nameof(bodynewSalesOrderNumber), required: false);
            WorkflowExpression.Validate(bodyoperatorToInform, nameof(bodyoperatorToInform), required: false);
            WorkflowExpression.Validate(bodyorderActionType, nameof(bodyorderActionType), required: false);
            WorkflowExpression.Validate(bodyorderComments, nameof(bodyorderComments), required: false);
            WorkflowExpression.Validate(bodyorderDate, nameof(bodyorderDate), required: false);
            WorkflowExpression.Validate(bodyorderDiscPercent1, nameof(bodyorderDiscPercent1), required: false);
            WorkflowExpression.Validate(bodyorderDiscPercent2, nameof(bodyorderDiscPercent2), required: false);
            WorkflowExpression.Validate(bodyorderDiscPercent3, nameof(bodyorderDiscPercent3), required: false);
            WorkflowExpression.Validate(bodyorderStatus, nameof(bodyorderStatus), required: false);
            WorkflowExpression.Validate(bodyorderType, nameof(bodyorderType), required: false);
            WorkflowExpression.Validate(bodyoverrideCustomerBackOrder, nameof(bodyoverrideCustomerBackOrder), required: false);
            WorkflowExpression.Validate(bodypOSSalesOrder, nameof(bodypOSSalesOrder), required: false);
            WorkflowExpression.Validate(bodyprocess, nameof(bodyprocess), required: false);
            WorkflowExpression.Validate(bodyprocessFlag, nameof(bodyprocessFlag), required: false);
            WorkflowExpression.Validate(bodyputEntireQuantityOnNewLoadWhenChanged, nameof(bodyputEntireQuantityOnNewLoadWhenChanged), required: false);
            WorkflowExpression.Validate(bodyreceiverCode, nameof(bodyreceiverCode), required: false);
            WorkflowExpression.Validate(bodyrequestedShipDate, nameof(bodyrequestedShipDate), required: false);
            WorkflowExpression.Validate(bodyreserveStock, nameof(bodyreserveStock), required: false);
            WorkflowExpression.Validate(bodyreserveStockRequestAllocs, nameof(bodyreserveStockRequestAllocs), required: false);
            WorkflowExpression.Validate(bodysalesOrder, nameof(bodysalesOrder), required: false);
            WorkflowExpression.Validate(bodysalesOrderDetails, nameof(bodysalesOrderDetails), required: false);
            WorkflowExpression.Validate(bodysalesOrderFooterComments, nameof(bodysalesOrderFooterComments), required: false);
            WorkflowExpression.Validate(bodysalesOrderFreightDetails, nameof(bodysalesOrderFreightDetails), required: false);
            WorkflowExpression.Validate(bodysalesOrderHeaderComments, nameof(bodysalesOrderHeaderComments), required: false);
            WorkflowExpression.Validate(bodysalesOrderMiscChargesDetails, nameof(bodysalesOrderMiscChargesDetails), required: false);
            WorkflowExpression.Validate(bodysalesOrderPromoQualifyAction, nameof(bodysalesOrderPromoQualifyAction), required: false);
            WorkflowExpression.Validate(bodysalesOrderPromoSelectAction, nameof(bodysalesOrderPromoSelectAction), required: false);
            WorkflowExpression.Validate(bodysalesperson, nameof(bodysalesperson), required: false);
            WorkflowExpression.Validate(bodysenderCode, nameof(bodysenderCode), required: false);
            WorkflowExpression.Validate(bodyshipAddress1, nameof(bodyshipAddress1), required: false);
            WorkflowExpression.Validate(bodyshipAddress2, nameof(bodyshipAddress2), required: false);
            WorkflowExpression.Validate(bodyshipAddress3, nameof(bodyshipAddress3), required: false);
            WorkflowExpression.Validate(bodyshipAddress3Locality, nameof(bodyshipAddress3Locality), required: false);
            WorkflowExpression.Validate(bodyshipAddress4, nameof(bodyshipAddress4), required: false);
            WorkflowExpression.Validate(bodyshipAddress5, nameof(bodyshipAddress5), required: false);
            WorkflowExpression.Validate(bodyshipAddressPerLine, nameof(bodyshipAddressPerLine), required: false);
            WorkflowExpression.Validate(bodyshipAddressPerLineTax, nameof(bodyshipAddressPerLineTax), required: false);
            WorkflowExpression.Validate(bodyshipGpsLat, nameof(bodyshipGpsLat), required: false);
            WorkflowExpression.Validate(bodyshipGpsLong, nameof(bodyshipGpsLong), required: false);
            WorkflowExpression.Validate(bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            WorkflowExpression.Validate(bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            WorkflowExpression.Validate(bodyshippingInstrsCode, nameof(bodyshippingInstrsCode), required: false);
            WorkflowExpression.Validate(bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            WorkflowExpression.Validate(bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodystatusInProcess, nameof(bodystatusInProcess), required: false);
            WorkflowExpression.Validate(bodystatusInProcessResponse, nameof(bodystatusInProcessResponse), required: false);
            WorkflowExpression.Validate(bodysupplier, nameof(bodysupplier), required: false);
            WorkflowExpression.Validate(bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            WorkflowExpression.Validate(bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            WorkflowExpression.Validate(bodytaxExemptionStatus, nameof(bodytaxExemptionStatus), required: false);
            WorkflowExpression.Validate(bodytransactionNature, nameof(bodytransactionNature), required: false);
            WorkflowExpression.Validate(bodytransmissionReference, nameof(bodytransmissionReference), required: false);
            WorkflowExpression.Validate(bodytransportMode, nameof(bodytransportMode), required: false);
            WorkflowExpression.Validate(bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            WorkflowExpression.Validate(bodyuseCustomerSalesWarehouse, nameof(bodyuseCustomerSalesWarehouse), required: false);
            WorkflowExpression.Validate(bodyuseMasterAccountForCustomerPartNo, nameof(bodyuseMasterAccountForCustomerPartNo), required: false);
            WorkflowExpression.Validate(bodyuseStockDescSupplied, nameof(bodyuseStockDescSupplied), required: false);
            WorkflowExpression.Validate(bodyvalidateShippingInstrs, nameof(bodyvalidateShippingInstrs), required: false);
            WorkflowExpression.Validate(bodywarehouse, nameof(bodywarehouse), required: false);
            WorkflowExpression.Validate(bodywarehouseListToUse, nameof(bodywarehouseListToUse), required: false);
            WorkflowExpression.Validate(bodywarnIfCustomerOnHold, nameof(bodywarnIfCustomerOnHold), required: false);
            WorkflowExpression.Validate(bodyeSignature, nameof(bodyeSignature), required: false);
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