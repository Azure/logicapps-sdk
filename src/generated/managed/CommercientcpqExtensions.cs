//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Commercientcpq
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CommercientcpqActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> SAGE100CreateNewCustomer(Expression<Func<string>> bodyaRDivisionNo = null, Expression<Func<string>> bodyaddressLine1 = null, Expression<Func<string>> bodyaddressLine2 = null, Expression<Func<string>> bodyaddressLine3 = null, Expression<Func<bool>> bodybatchFax = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodycontactCode = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<bool>> bodycreditHold = null, Expression<Func<int>> bodycreditLimit = null, Expression<Func<int>> bodycustomerDiscountRate = null, Expression<Func<string>> bodycustomerName = null, Expression<Func<string>> bodycustomerNo = null, Expression<Func<string>> bodycustomerType = null, Expression<Func<string>> bodydefaultCreditCardPmtType = null, Expression<Func<string>> bodydefaultItemCode = null, Expression<Func<string>> bodydefaultPaymentType = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyfaxNo = null, Expression<Func<bool>> bodyopenItemCustomer = null, Expression<Func<string>> bodypriceLevel = null, Expression<Func<string>> bodyprimaryShipToCode = null, Expression<Func<bool>> bodyprintDunningMessage = null, Expression<Func<bool>> bodyresidentialAddress = null, Expression<Func<string>> bodysalespersonNo = null, Expression<Func<string>> bodyshipMethod = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodystatementCycle = null, Expression<Func<string>> bodytaxExemptNo = null, Expression<Func<string>> bodytaxSchedule = null, Expression<Func<string>> bodytelephoneExt = null, Expression<Func<string>> bodytelephoneNo = null, Expression<Func<string>> bodytermsCode = null, Expression<Func<string>> bodyuRLAddress = null, Expression<Func<string>> bodyzipCode = null)
        {
            var __workflow_bodyaRDivisionNo = bodyaRDivisionNo == null ? null : WorkflowExpression.Compile(bodyaRDivisionNo);
            WorkflowExpression.Validate(__workflow_bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            var __workflow_bodyaddressLine1 = bodyaddressLine1 == null ? null : WorkflowExpression.Compile(bodyaddressLine1);
            WorkflowExpression.Validate(__workflow_bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            var __workflow_bodyaddressLine2 = bodyaddressLine2 == null ? null : WorkflowExpression.Compile(bodyaddressLine2);
            WorkflowExpression.Validate(__workflow_bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            var __workflow_bodyaddressLine3 = bodyaddressLine3 == null ? null : WorkflowExpression.Compile(bodyaddressLine3);
            WorkflowExpression.Validate(__workflow_bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            var __workflow_bodybatchFax = bodybatchFax == null ? null : WorkflowExpression.Compile(bodybatchFax);
            WorkflowExpression.Validate(__workflow_bodybatchFax, nameof(bodybatchFax), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodycontactCode = bodycontactCode == null ? null : WorkflowExpression.Compile(bodycontactCode);
            WorkflowExpression.Validate(__workflow_bodycontactCode, nameof(bodycontactCode), required: false);
            var __workflow_bodycountryCode = bodycountryCode == null ? null : WorkflowExpression.Compile(bodycountryCode);
            WorkflowExpression.Validate(__workflow_bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodycreditHold = bodycreditHold == null ? null : WorkflowExpression.Compile(bodycreditHold);
            WorkflowExpression.Validate(__workflow_bodycreditHold, nameof(bodycreditHold), required: false);
            var __workflow_bodycreditLimit = bodycreditLimit == null ? null : WorkflowExpression.Compile(bodycreditLimit);
            WorkflowExpression.Validate(__workflow_bodycreditLimit, nameof(bodycreditLimit), required: false);
            var __workflow_bodycustomerDiscountRate = bodycustomerDiscountRate == null ? null : WorkflowExpression.Compile(bodycustomerDiscountRate);
            WorkflowExpression.Validate(__workflow_bodycustomerDiscountRate, nameof(bodycustomerDiscountRate), required: false);
            var __workflow_bodycustomerName = bodycustomerName == null ? null : WorkflowExpression.Compile(bodycustomerName);
            WorkflowExpression.Validate(__workflow_bodycustomerName, nameof(bodycustomerName), required: false);
            var __workflow_bodycustomerNo = bodycustomerNo == null ? null : WorkflowExpression.Compile(bodycustomerNo);
            WorkflowExpression.Validate(__workflow_bodycustomerNo, nameof(bodycustomerNo), required: false);
            var __workflow_bodycustomerType = bodycustomerType == null ? null : WorkflowExpression.Compile(bodycustomerType);
            WorkflowExpression.Validate(__workflow_bodycustomerType, nameof(bodycustomerType), required: false);
            var __workflow_bodydefaultCreditCardPmtType = bodydefaultCreditCardPmtType == null ? null : WorkflowExpression.Compile(bodydefaultCreditCardPmtType);
            WorkflowExpression.Validate(__workflow_bodydefaultCreditCardPmtType, nameof(bodydefaultCreditCardPmtType), required: false);
            var __workflow_bodydefaultItemCode = bodydefaultItemCode == null ? null : WorkflowExpression.Compile(bodydefaultItemCode);
            WorkflowExpression.Validate(__workflow_bodydefaultItemCode, nameof(bodydefaultItemCode), required: false);
            var __workflow_bodydefaultPaymentType = bodydefaultPaymentType == null ? null : WorkflowExpression.Compile(bodydefaultPaymentType);
            WorkflowExpression.Validate(__workflow_bodydefaultPaymentType, nameof(bodydefaultPaymentType), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyfaxNo = bodyfaxNo == null ? null : WorkflowExpression.Compile(bodyfaxNo);
            WorkflowExpression.Validate(__workflow_bodyfaxNo, nameof(bodyfaxNo), required: false);
            var __workflow_bodyopenItemCustomer = bodyopenItemCustomer == null ? null : WorkflowExpression.Compile(bodyopenItemCustomer);
            WorkflowExpression.Validate(__workflow_bodyopenItemCustomer, nameof(bodyopenItemCustomer), required: false);
            var __workflow_bodypriceLevel = bodypriceLevel == null ? null : WorkflowExpression.Compile(bodypriceLevel);
            WorkflowExpression.Validate(__workflow_bodypriceLevel, nameof(bodypriceLevel), required: false);
            var __workflow_bodyprimaryShipToCode = bodyprimaryShipToCode == null ? null : WorkflowExpression.Compile(bodyprimaryShipToCode);
            WorkflowExpression.Validate(__workflow_bodyprimaryShipToCode, nameof(bodyprimaryShipToCode), required: false);
            var __workflow_bodyprintDunningMessage = bodyprintDunningMessage == null ? null : WorkflowExpression.Compile(bodyprintDunningMessage);
            WorkflowExpression.Validate(__workflow_bodyprintDunningMessage, nameof(bodyprintDunningMessage), required: false);
            var __workflow_bodyresidentialAddress = bodyresidentialAddress == null ? null : WorkflowExpression.Compile(bodyresidentialAddress);
            WorkflowExpression.Validate(__workflow_bodyresidentialAddress, nameof(bodyresidentialAddress), required: false);
            var __workflow_bodysalespersonNo = bodysalespersonNo == null ? null : WorkflowExpression.Compile(bodysalespersonNo);
            WorkflowExpression.Validate(__workflow_bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            var __workflow_bodyshipMethod = bodyshipMethod == null ? null : WorkflowExpression.Compile(bodyshipMethod);
            WorkflowExpression.Validate(__workflow_bodyshipMethod, nameof(bodyshipMethod), required: false);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: false);
            var __workflow_bodystatementCycle = bodystatementCycle == null ? null : WorkflowExpression.Compile(bodystatementCycle);
            WorkflowExpression.Validate(__workflow_bodystatementCycle, nameof(bodystatementCycle), required: false);
            var __workflow_bodytaxExemptNo = bodytaxExemptNo == null ? null : WorkflowExpression.Compile(bodytaxExemptNo);
            WorkflowExpression.Validate(__workflow_bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            var __workflow_bodytaxSchedule = bodytaxSchedule == null ? null : WorkflowExpression.Compile(bodytaxSchedule);
            WorkflowExpression.Validate(__workflow_bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            var __workflow_bodytelephoneExt = bodytelephoneExt == null ? null : WorkflowExpression.Compile(bodytelephoneExt);
            WorkflowExpression.Validate(__workflow_bodytelephoneExt, nameof(bodytelephoneExt), required: false);
            var __workflow_bodytelephoneNo = bodytelephoneNo == null ? null : WorkflowExpression.Compile(bodytelephoneNo);
            WorkflowExpression.Validate(__workflow_bodytelephoneNo, nameof(bodytelephoneNo), required: false);
            var __workflow_bodytermsCode = bodytermsCode == null ? null : WorkflowExpression.Compile(bodytermsCode);
            WorkflowExpression.Validate(__workflow_bodytermsCode, nameof(bodytermsCode), required: false);
            var __workflow_bodyuRLAddress = bodyuRLAddress == null ? null : WorkflowExpression.Compile(bodyuRLAddress);
            WorkflowExpression.Validate(__workflow_bodyuRLAddress, nameof(bodyuRLAddress), required: false);
            var __workflow_bodyzipCode = bodyzipCode == null ? null : WorkflowExpression.Compile(bodyzipCode);
            WorkflowExpression.Validate(__workflow_bodyzipCode, nameof(bodyzipCode), required: false);
            return new DeferredBodyAction<SAGE100CreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/SAGE100/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaRDivisionNo != null)
                {
                    body["ARDivisionNo"] = ExpressionConverter.ConvertO(__workflow_bodyaRDivisionNo);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodyaddressLine3 != null)
                {
                    body["AddressLine3"] = ExpressionConverter.ConvertO(__workflow_bodyaddressLine3);
                    bodypropCount++;
                }

                if (__workflow_bodybatchFax != null)
                {
                    body["BatchFax"] = ExpressionConverter.ConvertO(__workflow_bodybatchFax);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodycontactCode != null)
                {
                    body["ContactCode"] = ExpressionConverter.ConvertO(__workflow_bodycontactCode);
                    bodypropCount++;
                }

                if (__workflow_bodycountryCode != null)
                {
                    body["CountryCode"] = ExpressionConverter.ConvertO(__workflow_bodycountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodycreditHold != null)
                {
                    body["CreditHold"] = ExpressionConverter.ConvertO(__workflow_bodycreditHold);
                    bodypropCount++;
                }

                if (__workflow_bodycreditLimit != null)
                {
                    body["CreditLimit"] = ExpressionConverter.ConvertO(__workflow_bodycreditLimit);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerDiscountRate != null)
                {
                    body["CustomerDiscountRate"] = ExpressionConverter.ConvertO(__workflow_bodycustomerDiscountRate);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerName != null)
                {
                    body["CustomerName"] = ExpressionConverter.ConvertO(__workflow_bodycustomerName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerNo != null)
                {
                    body["CustomerNo"] = ExpressionConverter.ConvertO(__workflow_bodycustomerNo);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerType != null)
                {
                    body["CustomerType"] = ExpressionConverter.ConvertO(__workflow_bodycustomerType);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultCreditCardPmtType != null)
                {
                    body["DefaultCreditCardPmtType"] = ExpressionConverter.ConvertO(__workflow_bodydefaultCreditCardPmtType);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultItemCode != null)
                {
                    body["DefaultItemCode"] = ExpressionConverter.ConvertO(__workflow_bodydefaultItemCode);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultPaymentType != null)
                {
                    body["DefaultPaymentType"] = ExpressionConverter.ConvertO(__workflow_bodydefaultPaymentType);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxNo != null)
                {
                    body["FaxNo"] = ExpressionConverter.ConvertO(__workflow_bodyfaxNo);
                    bodypropCount++;
                }

                if (__workflow_bodyopenItemCustomer != null)
                {
                    body["OpenItemCustomer"] = ExpressionConverter.ConvertO(__workflow_bodyopenItemCustomer);
                    bodypropCount++;
                }

                if (__workflow_bodypriceLevel != null)
                {
                    body["PriceLevel"] = ExpressionConverter.ConvertO(__workflow_bodypriceLevel);
                    bodypropCount++;
                }

                if (__workflow_bodyprimaryShipToCode != null)
                {
                    body["PrimaryShipToCode"] = ExpressionConverter.ConvertO(__workflow_bodyprimaryShipToCode);
                    bodypropCount++;
                }

                if (__workflow_bodyprintDunningMessage != null)
                {
                    body["PrintDunningMessage"] = ExpressionConverter.ConvertO(__workflow_bodyprintDunningMessage);
                    bodypropCount++;
                }

                if (__workflow_bodyresidentialAddress != null)
                {
                    body["ResidentialAddress"] = ExpressionConverter.ConvertO(__workflow_bodyresidentialAddress);
                    bodypropCount++;
                }

                if (__workflow_bodysalespersonNo != null)
                {
                    body["SalespersonNo"] = ExpressionConverter.ConvertO(__workflow_bodysalespersonNo);
                    bodypropCount++;
                }

                if (__workflow_bodyshipMethod != null)
                {
                    body["ShipMethod"] = ExpressionConverter.ConvertO(__workflow_bodyshipMethod);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["State"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodystatementCycle != null)
                {
                    body["StatementCycle"] = ExpressionConverter.ConvertO(__workflow_bodystatementCycle);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptNo != null)
                {
                    body["TaxExemptNo"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptNo);
                    bodypropCount++;
                }

                if (__workflow_bodytaxSchedule != null)
                {
                    body["TaxSchedule"] = ExpressionConverter.ConvertO(__workflow_bodytaxSchedule);
                    bodypropCount++;
                }

                if (__workflow_bodytelephoneExt != null)
                {
                    body["TelephoneExt"] = ExpressionConverter.ConvertO(__workflow_bodytelephoneExt);
                    bodypropCount++;
                }

                if (__workflow_bodytelephoneNo != null)
                {
                    body["TelephoneNo"] = ExpressionConverter.ConvertO(__workflow_bodytelephoneNo);
                    bodypropCount++;
                }

                if (__workflow_bodytermsCode != null)
                {
                    body["TermsCode"] = ExpressionConverter.ConvertO(__workflow_bodytermsCode);
                    bodypropCount++;
                }

                if (__workflow_bodyuRLAddress != null)
                {
                    body["URLAddress"] = ExpressionConverter.ConvertO(__workflow_bodyuRLAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["ZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
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
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> SAGE100CreateNewSalesOrder(Expression<Func<string>> bodyaRDivisionNo = null, Expression<Func<bool>> bodybatchFax = null, Expression<Func<string>> bodybillToAddress1 = null, Expression<Func<string>> bodybillToAddress2 = null, Expression<Func<string>> bodybillToAddress3 = null, Expression<Func<string>> bodybillToCity = null, Expression<Func<string>> bodybillToCountryCode = null, Expression<Func<string>> bodybillToName = null, Expression<Func<string>> bodybillToState = null, Expression<Func<string>> bodybillToZipCode = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodyconfirmTo = null, Expression<Func<string>> bodycustomerNo = null, Expression<Func<string>> bodycustomerPONo = null, Expression<Func<string>> bodycycleCode = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyfOB = null, Expression<Func<string>> bodyfaxNo = null, Expression<Func<string>> bodymasterRepeatingOrderNo = null, Expression<Func<int>> bodynumberOfShippingLabels = null, Expression<Func<string>> bodyorderDate = null, Expression<Func<string>> bodyorderStatus = null, Expression<Func<string>> bodyorderType = null, Expression<Func<bool>> bodyprintPickingSheets = null, Expression<Func<bool>> bodyprintSalesOrders = null, Expression<Func<bodysalesOrderLineItemInputItem[]>> bodysalesOrderLineItem = null, Expression<Func<string>> bodysalesOrderNo = null, Expression<Func<string>> bodysalespersonNo = null, Expression<Func<string>> bodyshipExpireDate = null, Expression<Func<string>> bodyshipToAddress1 = null, Expression<Func<string>> bodyshipToAddress2 = null, Expression<Func<string>> bodyshipToAddress3 = null, Expression<Func<string>> bodyshipToCity = null, Expression<Func<string>> bodyshipToCode = null, Expression<Func<string>> bodyshipToCountryCode = null, Expression<Func<string>> bodyshipToName = null, Expression<Func<string>> bodyshipToState = null, Expression<Func<string>> bodyshipToZipCode = null, Expression<Func<string>> bodyshipVia = null, Expression<Func<int>> bodyshipWeight = null, Expression<Func<string>> bodyshipZoneActual = null, Expression<Func<string>> bodysplitCommissions = null, Expression<Func<string>> bodytaxExemptNo = null, Expression<Func<string>> bodytaxSchedule = null, Expression<Func<string>> bodytermsCode = null, Expression<Func<string>> bodywarehouseCode = null)
        {
            var __workflow_bodyaRDivisionNo = bodyaRDivisionNo == null ? null : WorkflowExpression.Compile(bodyaRDivisionNo);
            WorkflowExpression.Validate(__workflow_bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            var __workflow_bodybatchFax = bodybatchFax == null ? null : WorkflowExpression.Compile(bodybatchFax);
            WorkflowExpression.Validate(__workflow_bodybatchFax, nameof(bodybatchFax), required: false);
            var __workflow_bodybillToAddress1 = bodybillToAddress1 == null ? null : WorkflowExpression.Compile(bodybillToAddress1);
            WorkflowExpression.Validate(__workflow_bodybillToAddress1, nameof(bodybillToAddress1), required: false);
            var __workflow_bodybillToAddress2 = bodybillToAddress2 == null ? null : WorkflowExpression.Compile(bodybillToAddress2);
            WorkflowExpression.Validate(__workflow_bodybillToAddress2, nameof(bodybillToAddress2), required: false);
            var __workflow_bodybillToAddress3 = bodybillToAddress3 == null ? null : WorkflowExpression.Compile(bodybillToAddress3);
            WorkflowExpression.Validate(__workflow_bodybillToAddress3, nameof(bodybillToAddress3), required: false);
            var __workflow_bodybillToCity = bodybillToCity == null ? null : WorkflowExpression.Compile(bodybillToCity);
            WorkflowExpression.Validate(__workflow_bodybillToCity, nameof(bodybillToCity), required: false);
            var __workflow_bodybillToCountryCode = bodybillToCountryCode == null ? null : WorkflowExpression.Compile(bodybillToCountryCode);
            WorkflowExpression.Validate(__workflow_bodybillToCountryCode, nameof(bodybillToCountryCode), required: false);
            var __workflow_bodybillToName = bodybillToName == null ? null : WorkflowExpression.Compile(bodybillToName);
            WorkflowExpression.Validate(__workflow_bodybillToName, nameof(bodybillToName), required: false);
            var __workflow_bodybillToState = bodybillToState == null ? null : WorkflowExpression.Compile(bodybillToState);
            WorkflowExpression.Validate(__workflow_bodybillToState, nameof(bodybillToState), required: false);
            var __workflow_bodybillToZipCode = bodybillToZipCode == null ? null : WorkflowExpression.Compile(bodybillToZipCode);
            WorkflowExpression.Validate(__workflow_bodybillToZipCode, nameof(bodybillToZipCode), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodyconfirmTo = bodyconfirmTo == null ? null : WorkflowExpression.Compile(bodyconfirmTo);
            WorkflowExpression.Validate(__workflow_bodyconfirmTo, nameof(bodyconfirmTo), required: false);
            var __workflow_bodycustomerNo = bodycustomerNo == null ? null : WorkflowExpression.Compile(bodycustomerNo);
            WorkflowExpression.Validate(__workflow_bodycustomerNo, nameof(bodycustomerNo), required: false);
            var __workflow_bodycustomerPONo = bodycustomerPONo == null ? null : WorkflowExpression.Compile(bodycustomerPONo);
            WorkflowExpression.Validate(__workflow_bodycustomerPONo, nameof(bodycustomerPONo), required: false);
            var __workflow_bodycycleCode = bodycycleCode == null ? null : WorkflowExpression.Compile(bodycycleCode);
            WorkflowExpression.Validate(__workflow_bodycycleCode, nameof(bodycycleCode), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyfOB = bodyfOB == null ? null : WorkflowExpression.Compile(bodyfOB);
            WorkflowExpression.Validate(__workflow_bodyfOB, nameof(bodyfOB), required: false);
            var __workflow_bodyfaxNo = bodyfaxNo == null ? null : WorkflowExpression.Compile(bodyfaxNo);
            WorkflowExpression.Validate(__workflow_bodyfaxNo, nameof(bodyfaxNo), required: false);
            var __workflow_bodymasterRepeatingOrderNo = bodymasterRepeatingOrderNo == null ? null : WorkflowExpression.Compile(bodymasterRepeatingOrderNo);
            WorkflowExpression.Validate(__workflow_bodymasterRepeatingOrderNo, nameof(bodymasterRepeatingOrderNo), required: false);
            var __workflow_bodynumberOfShippingLabels = bodynumberOfShippingLabels == null ? null : WorkflowExpression.Compile(bodynumberOfShippingLabels);
            WorkflowExpression.Validate(__workflow_bodynumberOfShippingLabels, nameof(bodynumberOfShippingLabels), required: false);
            var __workflow_bodyorderDate = bodyorderDate == null ? null : WorkflowExpression.Compile(bodyorderDate);
            WorkflowExpression.Validate(__workflow_bodyorderDate, nameof(bodyorderDate), required: false);
            var __workflow_bodyorderStatus = bodyorderStatus == null ? null : WorkflowExpression.Compile(bodyorderStatus);
            WorkflowExpression.Validate(__workflow_bodyorderStatus, nameof(bodyorderStatus), required: false);
            var __workflow_bodyorderType = bodyorderType == null ? null : WorkflowExpression.Compile(bodyorderType);
            WorkflowExpression.Validate(__workflow_bodyorderType, nameof(bodyorderType), required: false);
            var __workflow_bodyprintPickingSheets = bodyprintPickingSheets == null ? null : WorkflowExpression.Compile(bodyprintPickingSheets);
            WorkflowExpression.Validate(__workflow_bodyprintPickingSheets, nameof(bodyprintPickingSheets), required: false);
            var __workflow_bodyprintSalesOrders = bodyprintSalesOrders == null ? null : WorkflowExpression.Compile(bodyprintSalesOrders);
            WorkflowExpression.Validate(__workflow_bodyprintSalesOrders, nameof(bodyprintSalesOrders), required: false);
            var __workflow_bodysalesOrderLineItem = bodysalesOrderLineItem == null ? null : WorkflowExpression.Compile(bodysalesOrderLineItem);
            WorkflowExpression.Validate(__workflow_bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            var __workflow_bodysalesOrderNo = bodysalesOrderNo == null ? null : WorkflowExpression.Compile(bodysalesOrderNo);
            WorkflowExpression.Validate(__workflow_bodysalesOrderNo, nameof(bodysalesOrderNo), required: false);
            var __workflow_bodysalespersonNo = bodysalespersonNo == null ? null : WorkflowExpression.Compile(bodysalespersonNo);
            WorkflowExpression.Validate(__workflow_bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            var __workflow_bodyshipExpireDate = bodyshipExpireDate == null ? null : WorkflowExpression.Compile(bodyshipExpireDate);
            WorkflowExpression.Validate(__workflow_bodyshipExpireDate, nameof(bodyshipExpireDate), required: false);
            var __workflow_bodyshipToAddress1 = bodyshipToAddress1 == null ? null : WorkflowExpression.Compile(bodyshipToAddress1);
            WorkflowExpression.Validate(__workflow_bodyshipToAddress1, nameof(bodyshipToAddress1), required: false);
            var __workflow_bodyshipToAddress2 = bodyshipToAddress2 == null ? null : WorkflowExpression.Compile(bodyshipToAddress2);
            WorkflowExpression.Validate(__workflow_bodyshipToAddress2, nameof(bodyshipToAddress2), required: false);
            var __workflow_bodyshipToAddress3 = bodyshipToAddress3 == null ? null : WorkflowExpression.Compile(bodyshipToAddress3);
            WorkflowExpression.Validate(__workflow_bodyshipToAddress3, nameof(bodyshipToAddress3), required: false);
            var __workflow_bodyshipToCity = bodyshipToCity == null ? null : WorkflowExpression.Compile(bodyshipToCity);
            WorkflowExpression.Validate(__workflow_bodyshipToCity, nameof(bodyshipToCity), required: false);
            var __workflow_bodyshipToCode = bodyshipToCode == null ? null : WorkflowExpression.Compile(bodyshipToCode);
            WorkflowExpression.Validate(__workflow_bodyshipToCode, nameof(bodyshipToCode), required: false);
            var __workflow_bodyshipToCountryCode = bodyshipToCountryCode == null ? null : WorkflowExpression.Compile(bodyshipToCountryCode);
            WorkflowExpression.Validate(__workflow_bodyshipToCountryCode, nameof(bodyshipToCountryCode), required: false);
            var __workflow_bodyshipToName = bodyshipToName == null ? null : WorkflowExpression.Compile(bodyshipToName);
            WorkflowExpression.Validate(__workflow_bodyshipToName, nameof(bodyshipToName), required: false);
            var __workflow_bodyshipToState = bodyshipToState == null ? null : WorkflowExpression.Compile(bodyshipToState);
            WorkflowExpression.Validate(__workflow_bodyshipToState, nameof(bodyshipToState), required: false);
            var __workflow_bodyshipToZipCode = bodyshipToZipCode == null ? null : WorkflowExpression.Compile(bodyshipToZipCode);
            WorkflowExpression.Validate(__workflow_bodyshipToZipCode, nameof(bodyshipToZipCode), required: false);
            var __workflow_bodyshipVia = bodyshipVia == null ? null : WorkflowExpression.Compile(bodyshipVia);
            WorkflowExpression.Validate(__workflow_bodyshipVia, nameof(bodyshipVia), required: false);
            var __workflow_bodyshipWeight = bodyshipWeight == null ? null : WorkflowExpression.Compile(bodyshipWeight);
            WorkflowExpression.Validate(__workflow_bodyshipWeight, nameof(bodyshipWeight), required: false);
            var __workflow_bodyshipZoneActual = bodyshipZoneActual == null ? null : WorkflowExpression.Compile(bodyshipZoneActual);
            WorkflowExpression.Validate(__workflow_bodyshipZoneActual, nameof(bodyshipZoneActual), required: false);
            var __workflow_bodysplitCommissions = bodysplitCommissions == null ? null : WorkflowExpression.Compile(bodysplitCommissions);
            WorkflowExpression.Validate(__workflow_bodysplitCommissions, nameof(bodysplitCommissions), required: false);
            var __workflow_bodytaxExemptNo = bodytaxExemptNo == null ? null : WorkflowExpression.Compile(bodytaxExemptNo);
            WorkflowExpression.Validate(__workflow_bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            var __workflow_bodytaxSchedule = bodytaxSchedule == null ? null : WorkflowExpression.Compile(bodytaxSchedule);
            WorkflowExpression.Validate(__workflow_bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            var __workflow_bodytermsCode = bodytermsCode == null ? null : WorkflowExpression.Compile(bodytermsCode);
            WorkflowExpression.Validate(__workflow_bodytermsCode, nameof(bodytermsCode), required: false);
            var __workflow_bodywarehouseCode = bodywarehouseCode == null ? null : WorkflowExpression.Compile(bodywarehouseCode);
            WorkflowExpression.Validate(__workflow_bodywarehouseCode, nameof(bodywarehouseCode), required: false);
            return new DeferredBodyAction<SAGE100CreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/SAGE100/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaRDivisionNo != null)
                {
                    body["ARDivisionNo"] = ExpressionConverter.ConvertO(__workflow_bodyaRDivisionNo);
                    bodypropCount++;
                }

                if (__workflow_bodybatchFax != null)
                {
                    body["BatchFax"] = ExpressionConverter.ConvertO(__workflow_bodybatchFax);
                    bodypropCount++;
                }

                if (__workflow_bodybillToAddress1 != null)
                {
                    body["BillToAddress1"] = ExpressionConverter.ConvertO(__workflow_bodybillToAddress1);
                    bodypropCount++;
                }

                if (__workflow_bodybillToAddress2 != null)
                {
                    body["BillToAddress2"] = ExpressionConverter.ConvertO(__workflow_bodybillToAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodybillToAddress3 != null)
                {
                    body["BillToAddress3"] = ExpressionConverter.ConvertO(__workflow_bodybillToAddress3);
                    bodypropCount++;
                }

                if (__workflow_bodybillToCity != null)
                {
                    body["BillToCity"] = ExpressionConverter.ConvertO(__workflow_bodybillToCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillToCountryCode != null)
                {
                    body["BillToCountryCode"] = ExpressionConverter.ConvertO(__workflow_bodybillToCountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodybillToName != null)
                {
                    body["BillToName"] = ExpressionConverter.ConvertO(__workflow_bodybillToName);
                    bodypropCount++;
                }

                if (__workflow_bodybillToState != null)
                {
                    body["BillToState"] = ExpressionConverter.ConvertO(__workflow_bodybillToState);
                    bodypropCount++;
                }

                if (__workflow_bodybillToZipCode != null)
                {
                    body["BillToZipCode"] = ExpressionConverter.ConvertO(__workflow_bodybillToZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["Comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmTo != null)
                {
                    body["ConfirmTo"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmTo);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerNo != null)
                {
                    body["CustomerNo"] = ExpressionConverter.ConvertO(__workflow_bodycustomerNo);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerPONo != null)
                {
                    body["CustomerPONo"] = ExpressionConverter.ConvertO(__workflow_bodycustomerPONo);
                    bodypropCount++;
                }

                if (__workflow_bodycycleCode != null)
                {
                    body["CycleCode"] = ExpressionConverter.ConvertO(__workflow_bodycycleCode);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyfOB != null)
                {
                    body["FOB"] = ExpressionConverter.ConvertO(__workflow_bodyfOB);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxNo != null)
                {
                    body["FaxNo"] = ExpressionConverter.ConvertO(__workflow_bodyfaxNo);
                    bodypropCount++;
                }

                if (__workflow_bodymasterRepeatingOrderNo != null)
                {
                    body["MasterRepeatingOrderNo"] = ExpressionConverter.ConvertO(__workflow_bodymasterRepeatingOrderNo);
                    bodypropCount++;
                }

                if (__workflow_bodynumberOfShippingLabels != null)
                {
                    body["NumberOfShippingLabels"] = ExpressionConverter.ConvertO(__workflow_bodynumberOfShippingLabels);
                    bodypropCount++;
                }

                if (__workflow_bodyorderDate != null)
                {
                    body["OrderDate"] = ExpressionConverter.ConvertO(__workflow_bodyorderDate);
                    bodypropCount++;
                }

                if (__workflow_bodyorderStatus != null)
                {
                    body["OrderStatus"] = ExpressionConverter.ConvertO(__workflow_bodyorderStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyorderType != null)
                {
                    body["OrderType"] = ExpressionConverter.ConvertO(__workflow_bodyorderType);
                    bodypropCount++;
                }

                if (__workflow_bodyprintPickingSheets != null)
                {
                    body["PrintPickingSheets"] = ExpressionConverter.ConvertO(__workflow_bodyprintPickingSheets);
                    bodypropCount++;
                }

                if (__workflow_bodyprintSalesOrders != null)
                {
                    body["PrintSalesOrders"] = ExpressionConverter.ConvertO(__workflow_bodyprintSalesOrders);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderNo != null)
                {
                    body["SalesOrderNo"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderNo);
                    bodypropCount++;
                }

                if (__workflow_bodysalespersonNo != null)
                {
                    body["SalespersonNo"] = ExpressionConverter.ConvertO(__workflow_bodysalespersonNo);
                    bodypropCount++;
                }

                if (__workflow_bodyshipExpireDate != null)
                {
                    body["ShipExpireDate"] = ExpressionConverter.ConvertO(__workflow_bodyshipExpireDate);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddress1 != null)
                {
                    body["ShipToAddress1"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddress2 != null)
                {
                    body["ShipToAddress2"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddress3 != null)
                {
                    body["ShipToAddress3"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddress3);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToCity != null)
                {
                    body["ShipToCity"] = ExpressionConverter.ConvertO(__workflow_bodyshipToCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToCode != null)
                {
                    body["ShipToCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipToCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToCountryCode != null)
                {
                    body["ShipToCountryCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipToCountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToName != null)
                {
                    body["ShipToName"] = ExpressionConverter.ConvertO(__workflow_bodyshipToName);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToState != null)
                {
                    body["ShipToState"] = ExpressionConverter.ConvertO(__workflow_bodyshipToState);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToZipCode != null)
                {
                    body["ShipToZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipToZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipVia != null)
                {
                    body["ShipVia"] = ExpressionConverter.ConvertO(__workflow_bodyshipVia);
                    bodypropCount++;
                }

                if (__workflow_bodyshipWeight != null)
                {
                    body["ShipWeight"] = ExpressionConverter.ConvertO(__workflow_bodyshipWeight);
                    bodypropCount++;
                }

                if (__workflow_bodyshipZoneActual != null)
                {
                    body["ShipZoneActual"] = ExpressionConverter.ConvertO(__workflow_bodyshipZoneActual);
                    bodypropCount++;
                }

                if (__workflow_bodysplitCommissions != null)
                {
                    body["SplitCommissions"] = ExpressionConverter.ConvertO(__workflow_bodysplitCommissions);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptNo != null)
                {
                    body["TaxExemptNo"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptNo);
                    bodypropCount++;
                }

                if (__workflow_bodytaxSchedule != null)
                {
                    body["TaxSchedule"] = ExpressionConverter.ConvertO(__workflow_bodytaxSchedule);
                    bodypropCount++;
                }

                if (__workflow_bodytermsCode != null)
                {
                    body["TermsCode"] = ExpressionConverter.ConvertO(__workflow_bodytermsCode);
                    bodypropCount++;
                }

                if (__workflow_bodywarehouseCode != null)
                {
                    body["WarehouseCode"] = ExpressionConverter.ConvertO(__workflow_bodywarehouseCode);
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
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> CommercientCPQCreateNewCustomer(Expression<Func<string>> bodybillingCity = null, Expression<Func<string>> bodybillingCounty = null, Expression<Func<string>> bodybillingPostalCode = null, Expression<Func<string>> bodybillingState = null, Expression<Func<string>> bodybillingStreet = null, Expression<Func<string>> bodygUID = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyshippingCity = null, Expression<Func<string>> bodyshippingCountry = null, Expression<Func<string>> bodyshippingPostalCode = null, Expression<Func<string>> bodyshippingState = null, Expression<Func<string>> bodyshippingStreet = null, Expression<Func<string>> bodyacnm = null)
        {
            var __workflow_bodybillingCity = bodybillingCity == null ? null : WorkflowExpression.Compile(bodybillingCity);
            WorkflowExpression.Validate(__workflow_bodybillingCity, nameof(bodybillingCity), required: false);
            var __workflow_bodybillingCounty = bodybillingCounty == null ? null : WorkflowExpression.Compile(bodybillingCounty);
            WorkflowExpression.Validate(__workflow_bodybillingCounty, nameof(bodybillingCounty), required: false);
            var __workflow_bodybillingPostalCode = bodybillingPostalCode == null ? null : WorkflowExpression.Compile(bodybillingPostalCode);
            WorkflowExpression.Validate(__workflow_bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            var __workflow_bodybillingState = bodybillingState == null ? null : WorkflowExpression.Compile(bodybillingState);
            WorkflowExpression.Validate(__workflow_bodybillingState, nameof(bodybillingState), required: false);
            var __workflow_bodybillingStreet = bodybillingStreet == null ? null : WorkflowExpression.Compile(bodybillingStreet);
            WorkflowExpression.Validate(__workflow_bodybillingStreet, nameof(bodybillingStreet), required: false);
            var __workflow_bodygUID = bodygUID == null ? null : WorkflowExpression.Compile(bodygUID);
            WorkflowExpression.Validate(__workflow_bodygUID, nameof(bodygUID), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyshippingCity = bodyshippingCity == null ? null : WorkflowExpression.Compile(bodyshippingCity);
            WorkflowExpression.Validate(__workflow_bodyshippingCity, nameof(bodyshippingCity), required: false);
            var __workflow_bodyshippingCountry = bodyshippingCountry == null ? null : WorkflowExpression.Compile(bodyshippingCountry);
            WorkflowExpression.Validate(__workflow_bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            var __workflow_bodyshippingPostalCode = bodyshippingPostalCode == null ? null : WorkflowExpression.Compile(bodyshippingPostalCode);
            WorkflowExpression.Validate(__workflow_bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            var __workflow_bodyshippingState = bodyshippingState == null ? null : WorkflowExpression.Compile(bodyshippingState);
            WorkflowExpression.Validate(__workflow_bodyshippingState, nameof(bodyshippingState), required: false);
            var __workflow_bodyshippingStreet = bodyshippingStreet == null ? null : WorkflowExpression.Compile(bodyshippingStreet);
            WorkflowExpression.Validate(__workflow_bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            var __workflow_bodyacnm = bodyacnm == null ? null : WorkflowExpression.Compile(bodyacnm);
            WorkflowExpression.Validate(__workflow_bodyacnm, nameof(bodyacnm), required: false);
            return new DeferredBodyAction<CommercientCPQCreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/commercientcpq/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybillingCity != null)
                {
                    body["BillingCity"] = ExpressionConverter.ConvertO(__workflow_bodybillingCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillingCounty != null)
                {
                    body["BillingCounty"] = ExpressionConverter.ConvertO(__workflow_bodybillingCounty);
                    bodypropCount++;
                }

                if (__workflow_bodybillingPostalCode != null)
                {
                    body["BillingPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodybillingPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodybillingState != null)
                {
                    body["BillingState"] = ExpressionConverter.ConvertO(__workflow_bodybillingState);
                    bodypropCount++;
                }

                if (__workflow_bodybillingStreet != null)
                {
                    body["BillingStreet"] = ExpressionConverter.ConvertO(__workflow_bodybillingStreet);
                    bodypropCount++;
                }

                if (__workflow_bodygUID != null)
                {
                    body["GUID"] = ExpressionConverter.ConvertO(__workflow_bodygUID);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCity != null)
                {
                    body["ShippingCity"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCountry != null)
                {
                    body["ShippingCountry"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingPostalCode != null)
                {
                    body["ShippingPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyshippingPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingState != null)
                {
                    body["ShippingState"] = ExpressionConverter.ConvertO(__workflow_bodyshippingState);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingStreet != null)
                {
                    body["ShippingStreet"] = ExpressionConverter.ConvertO(__workflow_bodyshippingStreet);
                    bodypropCount++;
                }

                if (__workflow_bodyacnm != null)
                {
                    body["acnm"] = ExpressionConverter.ConvertO(__workflow_bodyacnm);
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
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> CommercientCPQCreateNewProduct(Expression<Func<string>> bodystockCode = null)
        {
            var __workflow_bodystockCode = bodystockCode == null ? null : WorkflowExpression.Compile(bodystockCode);
            WorkflowExpression.Validate(__workflow_bodystockCode, nameof(bodystockCode), required: false);
            return new DeferredBodyAction<CommercientCPQCreateNewProductResponse>(() =>
            {
                var apiCallPath = "/api/v1/commercientcpq/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystockCode != null)
                {
                    body["StockCode"] = ExpressionConverter.ConvertO(__workflow_bodystockCode);
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
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> CommercientCPQCreateNewSalesOrder(Expression<Func<string>> bodyorderHeaderGUID = null, Expression<Func<bodysalesOrderLineItemInputItem2[]>> bodysalesOrderLineItem = null)
        {
            var __workflow_bodyorderHeaderGUID = bodyorderHeaderGUID == null ? null : WorkflowExpression.Compile(bodyorderHeaderGUID);
            WorkflowExpression.Validate(__workflow_bodyorderHeaderGUID, nameof(bodyorderHeaderGUID), required: false);
            var __workflow_bodysalesOrderLineItem = bodysalesOrderLineItem == null ? null : WorkflowExpression.Compile(bodysalesOrderLineItem);
            WorkflowExpression.Validate(__workflow_bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            return new DeferredBodyAction<CommercientCPQCreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/commercientcpq/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyorderHeaderGUID != null)
                {
                    body["OrderHeaderGUID"] = ExpressionConverter.ConvertO(__workflow_bodyorderHeaderGUID);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderLineItem);
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
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> QuickBookCreateNewCustomer(Expression<Func<string>> bodyaccountNumber = null, Expression<Func<string>> bodyaltContact = null, Expression<Func<string>> bodyaltPhone = null, Expression<Func<string>> bodybillAddressAddr1 = null, Expression<Func<string>> bodybillAddressAddr2 = null, Expression<Func<string>> bodybillAddressAddr3 = null, Expression<Func<string>> bodybillAddressAddr4 = null, Expression<Func<string>> bodybillAddressAddr5 = null, Expression<Func<string>> bodybillAddressCity = null, Expression<Func<string>> bodybillAddressCountry = null, Expression<Func<string>> bodybillAddressNote = null, Expression<Func<string>> bodybillAddressPostalCode = null, Expression<Func<string>> bodybillAddressState = null, Expression<Func<string>> bodycc = null, Expression<Func<string>> bodyclassRef = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodycontact = null, Expression<Func<int>> bodycreditLimit = null, Expression<Func<string>> bodycustomerTypeRef = null, Expression<Func<string>> bodyeditSequence = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<bool>> bodyisActive = null, Expression<Func<string>> bodyitemSalesTaxRef = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodylistID = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynotes = null, Expression<Func<int>> bodyopenBalance = null, Expression<Func<string>> bodyopenBalanceDate = null, Expression<Func<string>> bodyparentRef = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodypreferredPaymentMethodRef = null, Expression<Func<string>> bodypriceLevelRef = null, Expression<Func<string>> bodyresaleNumber = null, Expression<Func<string>> bodysalesRepRef = null, Expression<Func<string>> bodysalesTaxCodeRef = null, Expression<Func<string>> bodysalutation = null, Expression<Func<string>> bodyshipAddressAddr1 = null, Expression<Func<string>> bodyshipAddressAddr2 = null, Expression<Func<string>> bodyshipAddressAddr3 = null, Expression<Func<string>> bodyshipAddressAddr4 = null, Expression<Func<string>> bodyshipAddressAddr5 = null, Expression<Func<string>> bodyshipAddressCity = null, Expression<Func<string>> bodyshipAddressCountry = null, Expression<Func<string>> bodyshipAddressNote = null, Expression<Func<string>> bodyshipAddressPostalCode = null, Expression<Func<string>> bodyshipAddressState = null, Expression<Func<string>> bodytermsRef = null)
        {
            var __workflow_bodyaccountNumber = bodyaccountNumber == null ? null : WorkflowExpression.Compile(bodyaccountNumber);
            WorkflowExpression.Validate(__workflow_bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            var __workflow_bodyaltContact = bodyaltContact == null ? null : WorkflowExpression.Compile(bodyaltContact);
            WorkflowExpression.Validate(__workflow_bodyaltContact, nameof(bodyaltContact), required: false);
            var __workflow_bodyaltPhone = bodyaltPhone == null ? null : WorkflowExpression.Compile(bodyaltPhone);
            WorkflowExpression.Validate(__workflow_bodyaltPhone, nameof(bodyaltPhone), required: false);
            var __workflow_bodybillAddressAddr1 = bodybillAddressAddr1 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr1);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            var __workflow_bodybillAddressAddr2 = bodybillAddressAddr2 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr2);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            var __workflow_bodybillAddressAddr3 = bodybillAddressAddr3 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr3);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            var __workflow_bodybillAddressAddr4 = bodybillAddressAddr4 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr4);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            var __workflow_bodybillAddressAddr5 = bodybillAddressAddr5 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr5);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            var __workflow_bodybillAddressCity = bodybillAddressCity == null ? null : WorkflowExpression.Compile(bodybillAddressCity);
            WorkflowExpression.Validate(__workflow_bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            var __workflow_bodybillAddressCountry = bodybillAddressCountry == null ? null : WorkflowExpression.Compile(bodybillAddressCountry);
            WorkflowExpression.Validate(__workflow_bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            var __workflow_bodybillAddressNote = bodybillAddressNote == null ? null : WorkflowExpression.Compile(bodybillAddressNote);
            WorkflowExpression.Validate(__workflow_bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            var __workflow_bodybillAddressPostalCode = bodybillAddressPostalCode == null ? null : WorkflowExpression.Compile(bodybillAddressPostalCode);
            WorkflowExpression.Validate(__workflow_bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            var __workflow_bodybillAddressState = bodybillAddressState == null ? null : WorkflowExpression.Compile(bodybillAddressState);
            WorkflowExpression.Validate(__workflow_bodybillAddressState, nameof(bodybillAddressState), required: false);
            var __workflow_bodycc = bodycc == null ? null : WorkflowExpression.Compile(bodycc);
            WorkflowExpression.Validate(__workflow_bodycc, nameof(bodycc), required: false);
            var __workflow_bodyclassRef = bodyclassRef == null ? null : WorkflowExpression.Compile(bodyclassRef);
            WorkflowExpression.Validate(__workflow_bodyclassRef, nameof(bodyclassRef), required: false);
            var __workflow_bodycompanyName = bodycompanyName == null ? null : WorkflowExpression.Compile(bodycompanyName);
            WorkflowExpression.Validate(__workflow_bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodycontact = bodycontact == null ? null : WorkflowExpression.Compile(bodycontact);
            WorkflowExpression.Validate(__workflow_bodycontact, nameof(bodycontact), required: false);
            var __workflow_bodycreditLimit = bodycreditLimit == null ? null : WorkflowExpression.Compile(bodycreditLimit);
            WorkflowExpression.Validate(__workflow_bodycreditLimit, nameof(bodycreditLimit), required: false);
            var __workflow_bodycustomerTypeRef = bodycustomerTypeRef == null ? null : WorkflowExpression.Compile(bodycustomerTypeRef);
            WorkflowExpression.Validate(__workflow_bodycustomerTypeRef, nameof(bodycustomerTypeRef), required: false);
            var __workflow_bodyeditSequence = bodyeditSequence == null ? null : WorkflowExpression.Compile(bodyeditSequence);
            WorkflowExpression.Validate(__workflow_bodyeditSequence, nameof(bodyeditSequence), required: false);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyextraField = bodyextraField == null ? null : WorkflowExpression.Compile(bodyextraField);
            WorkflowExpression.Validate(__workflow_bodyextraField, nameof(bodyextraField), required: false);
            var __workflow_bodyfax = bodyfax == null ? null : WorkflowExpression.Compile(bodyfax);
            WorkflowExpression.Validate(__workflow_bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodyisActive = bodyisActive == null ? null : WorkflowExpression.Compile(bodyisActive);
            WorkflowExpression.Validate(__workflow_bodyisActive, nameof(bodyisActive), required: false);
            var __workflow_bodyitemSalesTaxRef = bodyitemSalesTaxRef == null ? null : WorkflowExpression.Compile(bodyitemSalesTaxRef);
            WorkflowExpression.Validate(__workflow_bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            var __workflow_bodyjobTitle = bodyjobTitle == null ? null : WorkflowExpression.Compile(bodyjobTitle);
            WorkflowExpression.Validate(__workflow_bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodylastName = bodylastName == null ? null : WorkflowExpression.Compile(bodylastName);
            WorkflowExpression.Validate(__workflow_bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodylistID = bodylistID == null ? null : WorkflowExpression.Compile(bodylistID);
            WorkflowExpression.Validate(__workflow_bodylistID, nameof(bodylistID), required: false);
            var __workflow_bodymiddleName = bodymiddleName == null ? null : WorkflowExpression.Compile(bodymiddleName);
            WorkflowExpression.Validate(__workflow_bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodynotes = bodynotes == null ? null : WorkflowExpression.Compile(bodynotes);
            WorkflowExpression.Validate(__workflow_bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyopenBalance = bodyopenBalance == null ? null : WorkflowExpression.Compile(bodyopenBalance);
            WorkflowExpression.Validate(__workflow_bodyopenBalance, nameof(bodyopenBalance), required: false);
            var __workflow_bodyopenBalanceDate = bodyopenBalanceDate == null ? null : WorkflowExpression.Compile(bodyopenBalanceDate);
            WorkflowExpression.Validate(__workflow_bodyopenBalanceDate, nameof(bodyopenBalanceDate), required: false);
            var __workflow_bodyparentRef = bodyparentRef == null ? null : WorkflowExpression.Compile(bodyparentRef);
            WorkflowExpression.Validate(__workflow_bodyparentRef, nameof(bodyparentRef), required: false);
            var __workflow_bodyphone = bodyphone == null ? null : WorkflowExpression.Compile(bodyphone);
            WorkflowExpression.Validate(__workflow_bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodypreferredPaymentMethodRef = bodypreferredPaymentMethodRef == null ? null : WorkflowExpression.Compile(bodypreferredPaymentMethodRef);
            WorkflowExpression.Validate(__workflow_bodypreferredPaymentMethodRef, nameof(bodypreferredPaymentMethodRef), required: false);
            var __workflow_bodypriceLevelRef = bodypriceLevelRef == null ? null : WorkflowExpression.Compile(bodypriceLevelRef);
            WorkflowExpression.Validate(__workflow_bodypriceLevelRef, nameof(bodypriceLevelRef), required: false);
            var __workflow_bodyresaleNumber = bodyresaleNumber == null ? null : WorkflowExpression.Compile(bodyresaleNumber);
            WorkflowExpression.Validate(__workflow_bodyresaleNumber, nameof(bodyresaleNumber), required: false);
            var __workflow_bodysalesRepRef = bodysalesRepRef == null ? null : WorkflowExpression.Compile(bodysalesRepRef);
            WorkflowExpression.Validate(__workflow_bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            var __workflow_bodysalesTaxCodeRef = bodysalesTaxCodeRef == null ? null : WorkflowExpression.Compile(bodysalesTaxCodeRef);
            WorkflowExpression.Validate(__workflow_bodysalesTaxCodeRef, nameof(bodysalesTaxCodeRef), required: false);
            var __workflow_bodysalutation = bodysalutation == null ? null : WorkflowExpression.Compile(bodysalutation);
            WorkflowExpression.Validate(__workflow_bodysalutation, nameof(bodysalutation), required: false);
            var __workflow_bodyshipAddressAddr1 = bodyshipAddressAddr1 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr1);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            var __workflow_bodyshipAddressAddr2 = bodyshipAddressAddr2 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr2);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            var __workflow_bodyshipAddressAddr3 = bodyshipAddressAddr3 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr3);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            var __workflow_bodyshipAddressAddr4 = bodyshipAddressAddr4 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr4);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            var __workflow_bodyshipAddressAddr5 = bodyshipAddressAddr5 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr5);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            var __workflow_bodyshipAddressCity = bodyshipAddressCity == null ? null : WorkflowExpression.Compile(bodyshipAddressCity);
            WorkflowExpression.Validate(__workflow_bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            var __workflow_bodyshipAddressCountry = bodyshipAddressCountry == null ? null : WorkflowExpression.Compile(bodyshipAddressCountry);
            WorkflowExpression.Validate(__workflow_bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            var __workflow_bodyshipAddressNote = bodyshipAddressNote == null ? null : WorkflowExpression.Compile(bodyshipAddressNote);
            WorkflowExpression.Validate(__workflow_bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            var __workflow_bodyshipAddressPostalCode = bodyshipAddressPostalCode == null ? null : WorkflowExpression.Compile(bodyshipAddressPostalCode);
            WorkflowExpression.Validate(__workflow_bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            var __workflow_bodyshipAddressState = bodyshipAddressState == null ? null : WorkflowExpression.Compile(bodyshipAddressState);
            WorkflowExpression.Validate(__workflow_bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            var __workflow_bodytermsRef = bodytermsRef == null ? null : WorkflowExpression.Compile(bodytermsRef);
            WorkflowExpression.Validate(__workflow_bodytermsRef, nameof(bodytermsRef), required: false);
            return new DeferredBodyAction<QuickBookCreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/quickbook/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountNumber != null)
                {
                    body["AccountNumber"] = ExpressionConverter.ConvertO(__workflow_bodyaccountNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyaltContact != null)
                {
                    body["AltContact"] = ExpressionConverter.ConvertO(__workflow_bodyaltContact);
                    bodypropCount++;
                }

                if (__workflow_bodyaltPhone != null)
                {
                    body["AltPhone"] = ExpressionConverter.ConvertO(__workflow_bodyaltPhone);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr1 != null)
                {
                    body["BillAddressAddr1"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr1);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr2 != null)
                {
                    body["BillAddressAddr2"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr2);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr3 != null)
                {
                    body["BillAddressAddr3"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr3);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr4 != null)
                {
                    body["BillAddressAddr4"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr4);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr5 != null)
                {
                    body["BillAddressAddr5"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr5);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressCity != null)
                {
                    body["BillAddressCity"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressCountry != null)
                {
                    body["BillAddressCountry"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressNote != null)
                {
                    body["BillAddressNote"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressNote);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressPostalCode != null)
                {
                    body["BillAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressState != null)
                {
                    body["BillAddressState"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodycc != null)
                {
                    body["Cc"] = ExpressionConverter.ConvertO(__workflow_bodycc);
                    bodypropCount++;
                }

                if (__workflow_bodyclassRef != null)
                {
                    body["ClassRef"] = ExpressionConverter.ConvertO(__workflow_bodyclassRef);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodycontact != null)
                {
                    body["Contact"] = ExpressionConverter.ConvertO(__workflow_bodycontact);
                    bodypropCount++;
                }

                if (__workflow_bodycreditLimit != null)
                {
                    body["CreditLimit"] = ExpressionConverter.ConvertO(__workflow_bodycreditLimit);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerTypeRef != null)
                {
                    body["CustomerTypeRef"] = ExpressionConverter.ConvertO(__workflow_bodycustomerTypeRef);
                    bodypropCount++;
                }

                if (__workflow_bodyeditSequence != null)
                {
                    body["EditSequence"] = ExpressionConverter.ConvertO(__workflow_bodyeditSequence);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyextraField != null)
                {
                    body["ExtraField"] = ExpressionConverter.ConvertO(__workflow_bodyextraField);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["Fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["FirstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodyisActive != null)
                {
                    body["IsActive"] = ExpressionConverter.ConvertO(__workflow_bodyisActive);
                    bodypropCount++;
                }

                if (__workflow_bodyitemSalesTaxRef != null)
                {
                    body["ItemSalesTaxRef"] = ExpressionConverter.ConvertO(__workflow_bodyitemSalesTaxRef);
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["JobTitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["LastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodylistID != null)
                {
                    body["ListID"] = ExpressionConverter.ConvertO(__workflow_bodylistID);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["MiddleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["Notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyopenBalance != null)
                {
                    body["OpenBalance"] = ExpressionConverter.ConvertO(__workflow_bodyopenBalance);
                    bodypropCount++;
                }

                if (__workflow_bodyopenBalanceDate != null)
                {
                    body["OpenBalanceDate"] = ExpressionConverter.ConvertO(__workflow_bodyopenBalanceDate);
                    bodypropCount++;
                }

                if (__workflow_bodyparentRef != null)
                {
                    body["ParentRef"] = ExpressionConverter.ConvertO(__workflow_bodyparentRef);
                    bodypropCount++;
                }

                if (__workflow_bodyphone != null)
                {
                    body["Phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredPaymentMethodRef != null)
                {
                    body["PreferredPaymentMethodRef"] = ExpressionConverter.ConvertO(__workflow_bodypreferredPaymentMethodRef);
                    bodypropCount++;
                }

                if (__workflow_bodypriceLevelRef != null)
                {
                    body["PriceLevelRef"] = ExpressionConverter.ConvertO(__workflow_bodypriceLevelRef);
                    bodypropCount++;
                }

                if (__workflow_bodyresaleNumber != null)
                {
                    body["ResaleNumber"] = ExpressionConverter.ConvertO(__workflow_bodyresaleNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysalesRepRef != null)
                {
                    body["SalesRepRef"] = ExpressionConverter.ConvertO(__workflow_bodysalesRepRef);
                    bodypropCount++;
                }

                if (__workflow_bodysalesTaxCodeRef != null)
                {
                    body["SalesTaxCodeRef"] = ExpressionConverter.ConvertO(__workflow_bodysalesTaxCodeRef);
                    bodypropCount++;
                }

                if (__workflow_bodysalutation != null)
                {
                    body["Salutation"] = ExpressionConverter.ConvertO(__workflow_bodysalutation);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr1 != null)
                {
                    body["ShipAddressAddr1"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr2 != null)
                {
                    body["ShipAddressAddr2"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr3 != null)
                {
                    body["ShipAddressAddr3"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr3);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr4 != null)
                {
                    body["ShipAddressAddr4"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr4);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr5 != null)
                {
                    body["ShipAddressAddr5"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr5);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressCity != null)
                {
                    body["ShipAddressCity"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressCountry != null)
                {
                    body["ShipAddressCountry"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressNote != null)
                {
                    body["ShipAddressNote"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressNote);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressPostalCode != null)
                {
                    body["ShipAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressState != null)
                {
                    body["ShipAddressState"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodytermsRef != null)
                {
                    body["TermsRef"] = ExpressionConverter.ConvertO(__workflow_bodytermsRef);
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
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> QuickBookCreateNewSalesOrder(Expression<Func<string>> bodybillAddressAddr1 = null, Expression<Func<string>> bodybillAddressAddr2 = null, Expression<Func<string>> bodybillAddressAddr3 = null, Expression<Func<string>> bodybillAddressAddr4 = null, Expression<Func<string>> bodybillAddressAddr5 = null, Expression<Func<string>> bodybillAddressCity = null, Expression<Func<string>> bodybillAddressCountry = null, Expression<Func<string>> bodybillAddressNote = null, Expression<Func<string>> bodybillAddressPostalCode = null, Expression<Func<string>> bodybillAddressState = null, Expression<Func<string>> bodyclassRef = null, Expression<Func<string>> bodycustomerRefListID = null, Expression<Func<string>> bodycustomerRefName = null, Expression<Func<string>> bodycustomerSalesTaxCodeRef = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyeditSequence = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyitemSalesTaxRef = null, Expression<Func<string>> bodylistID = null, Expression<Func<string>> bodymemo = null, Expression<Func<string>> bodypONumber = null, Expression<Func<string>> bodyrefNumber = null, Expression<Func<bodysalesOrderLineItemInputItem22[]>> bodysalesOrderLineItem = null, Expression<Func<string>> bodysalesRepRef = null, Expression<Func<string>> bodyshipAddressAddr1 = null, Expression<Func<string>> bodyshipAddressAddr2 = null, Expression<Func<string>> bodyshipAddressAddr3 = null, Expression<Func<string>> bodyshipAddressAddr4 = null, Expression<Func<string>> bodyshipAddressAddr5 = null, Expression<Func<string>> bodyshipAddressCity = null, Expression<Func<string>> bodyshipAddressCountry = null, Expression<Func<string>> bodyshipAddressNote = null, Expression<Func<string>> bodyshipAddressPostalCode = null, Expression<Func<string>> bodyshipAddressState = null, Expression<Func<string>> bodytemplateRef = null, Expression<Func<string>> bodytermsRef = null, Expression<Func<string>> bodytxnDate = null)
        {
            var __workflow_bodybillAddressAddr1 = bodybillAddressAddr1 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr1);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            var __workflow_bodybillAddressAddr2 = bodybillAddressAddr2 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr2);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            var __workflow_bodybillAddressAddr3 = bodybillAddressAddr3 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr3);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            var __workflow_bodybillAddressAddr4 = bodybillAddressAddr4 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr4);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            var __workflow_bodybillAddressAddr5 = bodybillAddressAddr5 == null ? null : WorkflowExpression.Compile(bodybillAddressAddr5);
            WorkflowExpression.Validate(__workflow_bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            var __workflow_bodybillAddressCity = bodybillAddressCity == null ? null : WorkflowExpression.Compile(bodybillAddressCity);
            WorkflowExpression.Validate(__workflow_bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            var __workflow_bodybillAddressCountry = bodybillAddressCountry == null ? null : WorkflowExpression.Compile(bodybillAddressCountry);
            WorkflowExpression.Validate(__workflow_bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            var __workflow_bodybillAddressNote = bodybillAddressNote == null ? null : WorkflowExpression.Compile(bodybillAddressNote);
            WorkflowExpression.Validate(__workflow_bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            var __workflow_bodybillAddressPostalCode = bodybillAddressPostalCode == null ? null : WorkflowExpression.Compile(bodybillAddressPostalCode);
            WorkflowExpression.Validate(__workflow_bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            var __workflow_bodybillAddressState = bodybillAddressState == null ? null : WorkflowExpression.Compile(bodybillAddressState);
            WorkflowExpression.Validate(__workflow_bodybillAddressState, nameof(bodybillAddressState), required: false);
            var __workflow_bodyclassRef = bodyclassRef == null ? null : WorkflowExpression.Compile(bodyclassRef);
            WorkflowExpression.Validate(__workflow_bodyclassRef, nameof(bodyclassRef), required: false);
            var __workflow_bodycustomerRefListID = bodycustomerRefListID == null ? null : WorkflowExpression.Compile(bodycustomerRefListID);
            WorkflowExpression.Validate(__workflow_bodycustomerRefListID, nameof(bodycustomerRefListID), required: false);
            var __workflow_bodycustomerRefName = bodycustomerRefName == null ? null : WorkflowExpression.Compile(bodycustomerRefName);
            WorkflowExpression.Validate(__workflow_bodycustomerRefName, nameof(bodycustomerRefName), required: false);
            var __workflow_bodycustomerSalesTaxCodeRef = bodycustomerSalesTaxCodeRef == null ? null : WorkflowExpression.Compile(bodycustomerSalesTaxCodeRef);
            WorkflowExpression.Validate(__workflow_bodycustomerSalesTaxCodeRef, nameof(bodycustomerSalesTaxCodeRef), required: false);
            var __workflow_bodydueDate = bodydueDate == null ? null : WorkflowExpression.Compile(bodydueDate);
            WorkflowExpression.Validate(__workflow_bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyeditSequence = bodyeditSequence == null ? null : WorkflowExpression.Compile(bodyeditSequence);
            WorkflowExpression.Validate(__workflow_bodyeditSequence, nameof(bodyeditSequence), required: false);
            var __workflow_bodyextraField = bodyextraField == null ? null : WorkflowExpression.Compile(bodyextraField);
            WorkflowExpression.Validate(__workflow_bodyextraField, nameof(bodyextraField), required: false);
            var __workflow_bodyitemSalesTaxRef = bodyitemSalesTaxRef == null ? null : WorkflowExpression.Compile(bodyitemSalesTaxRef);
            WorkflowExpression.Validate(__workflow_bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            var __workflow_bodylistID = bodylistID == null ? null : WorkflowExpression.Compile(bodylistID);
            WorkflowExpression.Validate(__workflow_bodylistID, nameof(bodylistID), required: false);
            var __workflow_bodymemo = bodymemo == null ? null : WorkflowExpression.Compile(bodymemo);
            WorkflowExpression.Validate(__workflow_bodymemo, nameof(bodymemo), required: false);
            var __workflow_bodypONumber = bodypONumber == null ? null : WorkflowExpression.Compile(bodypONumber);
            WorkflowExpression.Validate(__workflow_bodypONumber, nameof(bodypONumber), required: false);
            var __workflow_bodyrefNumber = bodyrefNumber == null ? null : WorkflowExpression.Compile(bodyrefNumber);
            WorkflowExpression.Validate(__workflow_bodyrefNumber, nameof(bodyrefNumber), required: false);
            var __workflow_bodysalesOrderLineItem = bodysalesOrderLineItem == null ? null : WorkflowExpression.Compile(bodysalesOrderLineItem);
            WorkflowExpression.Validate(__workflow_bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            var __workflow_bodysalesRepRef = bodysalesRepRef == null ? null : WorkflowExpression.Compile(bodysalesRepRef);
            WorkflowExpression.Validate(__workflow_bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            var __workflow_bodyshipAddressAddr1 = bodyshipAddressAddr1 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr1);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            var __workflow_bodyshipAddressAddr2 = bodyshipAddressAddr2 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr2);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            var __workflow_bodyshipAddressAddr3 = bodyshipAddressAddr3 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr3);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            var __workflow_bodyshipAddressAddr4 = bodyshipAddressAddr4 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr4);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            var __workflow_bodyshipAddressAddr5 = bodyshipAddressAddr5 == null ? null : WorkflowExpression.Compile(bodyshipAddressAddr5);
            WorkflowExpression.Validate(__workflow_bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            var __workflow_bodyshipAddressCity = bodyshipAddressCity == null ? null : WorkflowExpression.Compile(bodyshipAddressCity);
            WorkflowExpression.Validate(__workflow_bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            var __workflow_bodyshipAddressCountry = bodyshipAddressCountry == null ? null : WorkflowExpression.Compile(bodyshipAddressCountry);
            WorkflowExpression.Validate(__workflow_bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            var __workflow_bodyshipAddressNote = bodyshipAddressNote == null ? null : WorkflowExpression.Compile(bodyshipAddressNote);
            WorkflowExpression.Validate(__workflow_bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            var __workflow_bodyshipAddressPostalCode = bodyshipAddressPostalCode == null ? null : WorkflowExpression.Compile(bodyshipAddressPostalCode);
            WorkflowExpression.Validate(__workflow_bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            var __workflow_bodyshipAddressState = bodyshipAddressState == null ? null : WorkflowExpression.Compile(bodyshipAddressState);
            WorkflowExpression.Validate(__workflow_bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            var __workflow_bodytemplateRef = bodytemplateRef == null ? null : WorkflowExpression.Compile(bodytemplateRef);
            WorkflowExpression.Validate(__workflow_bodytemplateRef, nameof(bodytemplateRef), required: false);
            var __workflow_bodytermsRef = bodytermsRef == null ? null : WorkflowExpression.Compile(bodytermsRef);
            WorkflowExpression.Validate(__workflow_bodytermsRef, nameof(bodytermsRef), required: false);
            var __workflow_bodytxnDate = bodytxnDate == null ? null : WorkflowExpression.Compile(bodytxnDate);
            WorkflowExpression.Validate(__workflow_bodytxnDate, nameof(bodytxnDate), required: false);
            return new DeferredBodyAction<QuickBookCreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/quickbook/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybillAddressAddr1 != null)
                {
                    body["BillAddressAddr1"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr1);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr2 != null)
                {
                    body["BillAddressAddr2"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr2);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr3 != null)
                {
                    body["BillAddressAddr3"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr3);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr4 != null)
                {
                    body["BillAddressAddr4"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr4);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressAddr5 != null)
                {
                    body["BillAddressAddr5"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressAddr5);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressCity != null)
                {
                    body["BillAddressCity"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressCountry != null)
                {
                    body["BillAddressCountry"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressNote != null)
                {
                    body["BillAddressNote"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressNote);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressPostalCode != null)
                {
                    body["BillAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodybillAddressState != null)
                {
                    body["BillAddressState"] = ExpressionConverter.ConvertO(__workflow_bodybillAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyclassRef != null)
                {
                    body["ClassRef"] = ExpressionConverter.ConvertO(__workflow_bodyclassRef);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerRefListID != null)
                {
                    body["CustomerRefListID"] = ExpressionConverter.ConvertO(__workflow_bodycustomerRefListID);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerRefName != null)
                {
                    body["CustomerRefName"] = ExpressionConverter.ConvertO(__workflow_bodycustomerRefName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerSalesTaxCodeRef != null)
                {
                    body["CustomerSalesTaxCodeRef"] = ExpressionConverter.ConvertO(__workflow_bodycustomerSalesTaxCodeRef);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodyeditSequence != null)
                {
                    body["EditSequence"] = ExpressionConverter.ConvertO(__workflow_bodyeditSequence);
                    bodypropCount++;
                }

                if (__workflow_bodyextraField != null)
                {
                    body["ExtraField"] = ExpressionConverter.ConvertO(__workflow_bodyextraField);
                    bodypropCount++;
                }

                if (__workflow_bodyitemSalesTaxRef != null)
                {
                    body["ItemSalesTaxRef"] = ExpressionConverter.ConvertO(__workflow_bodyitemSalesTaxRef);
                    bodypropCount++;
                }

                if (__workflow_bodylistID != null)
                {
                    body["ListID"] = ExpressionConverter.ConvertO(__workflow_bodylistID);
                    bodypropCount++;
                }

                if (__workflow_bodymemo != null)
                {
                    body["Memo"] = ExpressionConverter.ConvertO(__workflow_bodymemo);
                    bodypropCount++;
                }

                if (__workflow_bodypONumber != null)
                {
                    body["PONumber"] = ExpressionConverter.ConvertO(__workflow_bodypONumber);
                    bodypropCount++;
                }

                if (__workflow_bodyrefNumber != null)
                {
                    body["RefNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrefNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (__workflow_bodysalesRepRef != null)
                {
                    body["SalesRepRef"] = ExpressionConverter.ConvertO(__workflow_bodysalesRepRef);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr1 != null)
                {
                    body["ShipAddressAddr1"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr2 != null)
                {
                    body["ShipAddressAddr2"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr3 != null)
                {
                    body["ShipAddressAddr3"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr3);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr4 != null)
                {
                    body["ShipAddressAddr4"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr4);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressAddr5 != null)
                {
                    body["ShipAddressAddr5"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressAddr5);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressCity != null)
                {
                    body["ShipAddressCity"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressCountry != null)
                {
                    body["ShipAddressCountry"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressNote != null)
                {
                    body["ShipAddressNote"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressNote);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressPostalCode != null)
                {
                    body["ShipAddressPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressState != null)
                {
                    body["ShipAddressState"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateRef != null)
                {
                    body["TemplateRef"] = ExpressionConverter.ConvertO(__workflow_bodytemplateRef);
                    bodypropCount++;
                }

                if (__workflow_bodytermsRef != null)
                {
                    body["TermsRef"] = ExpressionConverter.ConvertO(__workflow_bodytermsRef);
                    bodypropCount++;
                }

                if (__workflow_bodytxnDate != null)
                {
                    body["TxnDate"] = ExpressionConverter.ConvertO(__workflow_bodytxnDate);
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
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> SAGE50UKCreateNewCustomer(Expression<Func<string>> bodyaCCOUNTOPENED = null, Expression<Func<string>> bodyaCCOUNTREF = null, Expression<Func<int>> bodyaCCOUNTSTATUS = null, Expression<Func<string>> bodyaDDRESS1 = null, Expression<Func<string>> bodyaDDRESS2 = null, Expression<Func<string>> bodyaDDRESS3 = null, Expression<Func<string>> bodyaDDRESS4 = null, Expression<Func<string>> bodyaDDRESS5 = null, Expression<Func<string>> bodyaNALYSIS1 = null, Expression<Func<string>> bodyaNALYSIS2 = null, Expression<Func<string>> bodyaNALYSIS3 = null, Expression<Func<int>> bodyaVERAGEPAYDAYS = null, Expression<Func<int>> bodybALANCE = null, Expression<Func<bool>> bodycANAPPLYCHARGES = null, Expression<Func<string>> bodycONTACTNAME = null, Expression<Func<string>> bodycOUNTRYCODE = null, Expression<Func<string>> bodycREDITAPPLIEDFOR = null, Expression<Func<int>> bodycREDITBUREAU = null, Expression<Func<int>> bodycREDITLIMIT = null, Expression<Func<int>> bodycREDITPOSITION = null, Expression<Func<string>> bodycREDITREFERENCE = null, Expression<Func<int>> bodycURRENCY = null, Expression<Func<string>> bodydATECREDITAPPRECEIVED = null, Expression<Func<string>> bodydEFNOMCODE = null, Expression<Func<int>> bodydEFTAXCODE = null, Expression<Func<int>> bodydEPTNUMBER = null, Expression<Func<int>> bodydISCOUNTRATE = null, Expression<Func<int>> bodydISCOUNTTYPE = null, Expression<Func<string>> bodydUNSNUMBER = null, Expression<Func<string>> bodyeMAIL = null, Expression<Func<string>> bodyeMAIL2 = null, Expression<Func<string>> bodyeMAIL3 = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyfAX = null, Expression<Func<bool>> bodyhOLDMAIL = null, Expression<Func<bool>> bodyiNACTIVEFLAG = null, Expression<Func<bool>> bodyisACCOUNTREFAutogenerate = null, Expression<Func<string>> bodylASTCREDITREV = null, Expression<Func<string>> bodynAME = null, Expression<Func<string>> bodynEXTCREDITREV = null, Expression<Func<bool>> bodyoVERRIDEPRODUCTNOMINAL = null, Expression<Func<bool>> bodyoVERRIDEPRODUCTTAX = null, Expression<Func<int>> bodypAYMENTDUEDAYS = null, Expression<Func<string>> bodypRICELISTREF = null, Expression<Func<bool>> bodypRIORITYTRADER = null, Expression<Func<bool>> bodysENDINVOICESELECTRONICALLY = null, Expression<Func<bool>> bodysENDLETTERSELECTRONICALLY = null, Expression<Func<int>> bodysETTLEMENTDISCRATE = null, Expression<Func<int>> bodysETTLEMENTDUEDAYS = null, Expression<Func<string>> bodytELEPHONE = null, Expression<Func<string>> bodytELEPHONE2 = null, Expression<Func<string>> bodytERMS = null, Expression<Func<bool>> bodytERMSAGREEDFLAG = null, Expression<Func<string>> bodytRADECONTACT = null, Expression<Func<string>> bodyvATREGNUMBER = null)
        {
            var __workflow_bodyaCCOUNTOPENED = bodyaCCOUNTOPENED == null ? null : WorkflowExpression.Compile(bodyaCCOUNTOPENED);
            WorkflowExpression.Validate(__workflow_bodyaCCOUNTOPENED, nameof(bodyaCCOUNTOPENED), required: false);
            var __workflow_bodyaCCOUNTREF = bodyaCCOUNTREF == null ? null : WorkflowExpression.Compile(bodyaCCOUNTREF);
            WorkflowExpression.Validate(__workflow_bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            var __workflow_bodyaCCOUNTSTATUS = bodyaCCOUNTSTATUS == null ? null : WorkflowExpression.Compile(bodyaCCOUNTSTATUS);
            WorkflowExpression.Validate(__workflow_bodyaCCOUNTSTATUS, nameof(bodyaCCOUNTSTATUS), required: false);
            var __workflow_bodyaDDRESS1 = bodyaDDRESS1 == null ? null : WorkflowExpression.Compile(bodyaDDRESS1);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            var __workflow_bodyaDDRESS2 = bodyaDDRESS2 == null ? null : WorkflowExpression.Compile(bodyaDDRESS2);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            var __workflow_bodyaDDRESS3 = bodyaDDRESS3 == null ? null : WorkflowExpression.Compile(bodyaDDRESS3);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            var __workflow_bodyaDDRESS4 = bodyaDDRESS4 == null ? null : WorkflowExpression.Compile(bodyaDDRESS4);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            var __workflow_bodyaDDRESS5 = bodyaDDRESS5 == null ? null : WorkflowExpression.Compile(bodyaDDRESS5);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            var __workflow_bodyaNALYSIS1 = bodyaNALYSIS1 == null ? null : WorkflowExpression.Compile(bodyaNALYSIS1);
            WorkflowExpression.Validate(__workflow_bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            var __workflow_bodyaNALYSIS2 = bodyaNALYSIS2 == null ? null : WorkflowExpression.Compile(bodyaNALYSIS2);
            WorkflowExpression.Validate(__workflow_bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            var __workflow_bodyaNALYSIS3 = bodyaNALYSIS3 == null ? null : WorkflowExpression.Compile(bodyaNALYSIS3);
            WorkflowExpression.Validate(__workflow_bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            var __workflow_bodyaVERAGEPAYDAYS = bodyaVERAGEPAYDAYS == null ? null : WorkflowExpression.Compile(bodyaVERAGEPAYDAYS);
            WorkflowExpression.Validate(__workflow_bodyaVERAGEPAYDAYS, nameof(bodyaVERAGEPAYDAYS), required: false);
            var __workflow_bodybALANCE = bodybALANCE == null ? null : WorkflowExpression.Compile(bodybALANCE);
            WorkflowExpression.Validate(__workflow_bodybALANCE, nameof(bodybALANCE), required: false);
            var __workflow_bodycANAPPLYCHARGES = bodycANAPPLYCHARGES == null ? null : WorkflowExpression.Compile(bodycANAPPLYCHARGES);
            WorkflowExpression.Validate(__workflow_bodycANAPPLYCHARGES, nameof(bodycANAPPLYCHARGES), required: false);
            var __workflow_bodycONTACTNAME = bodycONTACTNAME == null ? null : WorkflowExpression.Compile(bodycONTACTNAME);
            WorkflowExpression.Validate(__workflow_bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            var __workflow_bodycOUNTRYCODE = bodycOUNTRYCODE == null ? null : WorkflowExpression.Compile(bodycOUNTRYCODE);
            WorkflowExpression.Validate(__workflow_bodycOUNTRYCODE, nameof(bodycOUNTRYCODE), required: false);
            var __workflow_bodycREDITAPPLIEDFOR = bodycREDITAPPLIEDFOR == null ? null : WorkflowExpression.Compile(bodycREDITAPPLIEDFOR);
            WorkflowExpression.Validate(__workflow_bodycREDITAPPLIEDFOR, nameof(bodycREDITAPPLIEDFOR), required: false);
            var __workflow_bodycREDITBUREAU = bodycREDITBUREAU == null ? null : WorkflowExpression.Compile(bodycREDITBUREAU);
            WorkflowExpression.Validate(__workflow_bodycREDITBUREAU, nameof(bodycREDITBUREAU), required: false);
            var __workflow_bodycREDITLIMIT = bodycREDITLIMIT == null ? null : WorkflowExpression.Compile(bodycREDITLIMIT);
            WorkflowExpression.Validate(__workflow_bodycREDITLIMIT, nameof(bodycREDITLIMIT), required: false);
            var __workflow_bodycREDITPOSITION = bodycREDITPOSITION == null ? null : WorkflowExpression.Compile(bodycREDITPOSITION);
            WorkflowExpression.Validate(__workflow_bodycREDITPOSITION, nameof(bodycREDITPOSITION), required: false);
            var __workflow_bodycREDITREFERENCE = bodycREDITREFERENCE == null ? null : WorkflowExpression.Compile(bodycREDITREFERENCE);
            WorkflowExpression.Validate(__workflow_bodycREDITREFERENCE, nameof(bodycREDITREFERENCE), required: false);
            var __workflow_bodycURRENCY = bodycURRENCY == null ? null : WorkflowExpression.Compile(bodycURRENCY);
            WorkflowExpression.Validate(__workflow_bodycURRENCY, nameof(bodycURRENCY), required: false);
            var __workflow_bodydATECREDITAPPRECEIVED = bodydATECREDITAPPRECEIVED == null ? null : WorkflowExpression.Compile(bodydATECREDITAPPRECEIVED);
            WorkflowExpression.Validate(__workflow_bodydATECREDITAPPRECEIVED, nameof(bodydATECREDITAPPRECEIVED), required: false);
            var __workflow_bodydEFNOMCODE = bodydEFNOMCODE == null ? null : WorkflowExpression.Compile(bodydEFNOMCODE);
            WorkflowExpression.Validate(__workflow_bodydEFNOMCODE, nameof(bodydEFNOMCODE), required: false);
            var __workflow_bodydEFTAXCODE = bodydEFTAXCODE == null ? null : WorkflowExpression.Compile(bodydEFTAXCODE);
            WorkflowExpression.Validate(__workflow_bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            var __workflow_bodydEPTNUMBER = bodydEPTNUMBER == null ? null : WorkflowExpression.Compile(bodydEPTNUMBER);
            WorkflowExpression.Validate(__workflow_bodydEPTNUMBER, nameof(bodydEPTNUMBER), required: false);
            var __workflow_bodydISCOUNTRATE = bodydISCOUNTRATE == null ? null : WorkflowExpression.Compile(bodydISCOUNTRATE);
            WorkflowExpression.Validate(__workflow_bodydISCOUNTRATE, nameof(bodydISCOUNTRATE), required: false);
            var __workflow_bodydISCOUNTTYPE = bodydISCOUNTTYPE == null ? null : WorkflowExpression.Compile(bodydISCOUNTTYPE);
            WorkflowExpression.Validate(__workflow_bodydISCOUNTTYPE, nameof(bodydISCOUNTTYPE), required: false);
            var __workflow_bodydUNSNUMBER = bodydUNSNUMBER == null ? null : WorkflowExpression.Compile(bodydUNSNUMBER);
            WorkflowExpression.Validate(__workflow_bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            var __workflow_bodyeMAIL = bodyeMAIL == null ? null : WorkflowExpression.Compile(bodyeMAIL);
            WorkflowExpression.Validate(__workflow_bodyeMAIL, nameof(bodyeMAIL), required: false);
            var __workflow_bodyeMAIL2 = bodyeMAIL2 == null ? null : WorkflowExpression.Compile(bodyeMAIL2);
            WorkflowExpression.Validate(__workflow_bodyeMAIL2, nameof(bodyeMAIL2), required: false);
            var __workflow_bodyeMAIL3 = bodyeMAIL3 == null ? null : WorkflowExpression.Compile(bodyeMAIL3);
            WorkflowExpression.Validate(__workflow_bodyeMAIL3, nameof(bodyeMAIL3), required: false);
            var __workflow_bodyextraField = bodyextraField == null ? null : WorkflowExpression.Compile(bodyextraField);
            WorkflowExpression.Validate(__workflow_bodyextraField, nameof(bodyextraField), required: false);
            var __workflow_bodyfAX = bodyfAX == null ? null : WorkflowExpression.Compile(bodyfAX);
            WorkflowExpression.Validate(__workflow_bodyfAX, nameof(bodyfAX), required: false);
            var __workflow_bodyhOLDMAIL = bodyhOLDMAIL == null ? null : WorkflowExpression.Compile(bodyhOLDMAIL);
            WorkflowExpression.Validate(__workflow_bodyhOLDMAIL, nameof(bodyhOLDMAIL), required: false);
            var __workflow_bodyiNACTIVEFLAG = bodyiNACTIVEFLAG == null ? null : WorkflowExpression.Compile(bodyiNACTIVEFLAG);
            WorkflowExpression.Validate(__workflow_bodyiNACTIVEFLAG, nameof(bodyiNACTIVEFLAG), required: false);
            var __workflow_bodyisACCOUNTREFAutogenerate = bodyisACCOUNTREFAutogenerate == null ? null : WorkflowExpression.Compile(bodyisACCOUNTREFAutogenerate);
            WorkflowExpression.Validate(__workflow_bodyisACCOUNTREFAutogenerate, nameof(bodyisACCOUNTREFAutogenerate), required: false);
            var __workflow_bodylASTCREDITREV = bodylASTCREDITREV == null ? null : WorkflowExpression.Compile(bodylASTCREDITREV);
            WorkflowExpression.Validate(__workflow_bodylASTCREDITREV, nameof(bodylASTCREDITREV), required: false);
            var __workflow_bodynAME = bodynAME == null ? null : WorkflowExpression.Compile(bodynAME);
            WorkflowExpression.Validate(__workflow_bodynAME, nameof(bodynAME), required: false);
            var __workflow_bodynEXTCREDITREV = bodynEXTCREDITREV == null ? null : WorkflowExpression.Compile(bodynEXTCREDITREV);
            WorkflowExpression.Validate(__workflow_bodynEXTCREDITREV, nameof(bodynEXTCREDITREV), required: false);
            var __workflow_bodyoVERRIDEPRODUCTNOMINAL = bodyoVERRIDEPRODUCTNOMINAL == null ? null : WorkflowExpression.Compile(bodyoVERRIDEPRODUCTNOMINAL);
            WorkflowExpression.Validate(__workflow_bodyoVERRIDEPRODUCTNOMINAL, nameof(bodyoVERRIDEPRODUCTNOMINAL), required: false);
            var __workflow_bodyoVERRIDEPRODUCTTAX = bodyoVERRIDEPRODUCTTAX == null ? null : WorkflowExpression.Compile(bodyoVERRIDEPRODUCTTAX);
            WorkflowExpression.Validate(__workflow_bodyoVERRIDEPRODUCTTAX, nameof(bodyoVERRIDEPRODUCTTAX), required: false);
            var __workflow_bodypAYMENTDUEDAYS = bodypAYMENTDUEDAYS == null ? null : WorkflowExpression.Compile(bodypAYMENTDUEDAYS);
            WorkflowExpression.Validate(__workflow_bodypAYMENTDUEDAYS, nameof(bodypAYMENTDUEDAYS), required: false);
            var __workflow_bodypRICELISTREF = bodypRICELISTREF == null ? null : WorkflowExpression.Compile(bodypRICELISTREF);
            WorkflowExpression.Validate(__workflow_bodypRICELISTREF, nameof(bodypRICELISTREF), required: false);
            var __workflow_bodypRIORITYTRADER = bodypRIORITYTRADER == null ? null : WorkflowExpression.Compile(bodypRIORITYTRADER);
            WorkflowExpression.Validate(__workflow_bodypRIORITYTRADER, nameof(bodypRIORITYTRADER), required: false);
            var __workflow_bodysENDINVOICESELECTRONICALLY = bodysENDINVOICESELECTRONICALLY == null ? null : WorkflowExpression.Compile(bodysENDINVOICESELECTRONICALLY);
            WorkflowExpression.Validate(__workflow_bodysENDINVOICESELECTRONICALLY, nameof(bodysENDINVOICESELECTRONICALLY), required: false);
            var __workflow_bodysENDLETTERSELECTRONICALLY = bodysENDLETTERSELECTRONICALLY == null ? null : WorkflowExpression.Compile(bodysENDLETTERSELECTRONICALLY);
            WorkflowExpression.Validate(__workflow_bodysENDLETTERSELECTRONICALLY, nameof(bodysENDLETTERSELECTRONICALLY), required: false);
            var __workflow_bodysETTLEMENTDISCRATE = bodysETTLEMENTDISCRATE == null ? null : WorkflowExpression.Compile(bodysETTLEMENTDISCRATE);
            WorkflowExpression.Validate(__workflow_bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            var __workflow_bodysETTLEMENTDUEDAYS = bodysETTLEMENTDUEDAYS == null ? null : WorkflowExpression.Compile(bodysETTLEMENTDUEDAYS);
            WorkflowExpression.Validate(__workflow_bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            var __workflow_bodytELEPHONE = bodytELEPHONE == null ? null : WorkflowExpression.Compile(bodytELEPHONE);
            WorkflowExpression.Validate(__workflow_bodytELEPHONE, nameof(bodytELEPHONE), required: false);
            var __workflow_bodytELEPHONE2 = bodytELEPHONE2 == null ? null : WorkflowExpression.Compile(bodytELEPHONE2);
            WorkflowExpression.Validate(__workflow_bodytELEPHONE2, nameof(bodytELEPHONE2), required: false);
            var __workflow_bodytERMS = bodytERMS == null ? null : WorkflowExpression.Compile(bodytERMS);
            WorkflowExpression.Validate(__workflow_bodytERMS, nameof(bodytERMS), required: false);
            var __workflow_bodytERMSAGREEDFLAG = bodytERMSAGREEDFLAG == null ? null : WorkflowExpression.Compile(bodytERMSAGREEDFLAG);
            WorkflowExpression.Validate(__workflow_bodytERMSAGREEDFLAG, nameof(bodytERMSAGREEDFLAG), required: false);
            var __workflow_bodytRADECONTACT = bodytRADECONTACT == null ? null : WorkflowExpression.Compile(bodytRADECONTACT);
            WorkflowExpression.Validate(__workflow_bodytRADECONTACT, nameof(bodytRADECONTACT), required: false);
            var __workflow_bodyvATREGNUMBER = bodyvATREGNUMBER == null ? null : WorkflowExpression.Compile(bodyvATREGNUMBER);
            WorkflowExpression.Validate(__workflow_bodyvATREGNUMBER, nameof(bodyvATREGNUMBER), required: false);
            return new DeferredBodyAction<SAGE50UKCreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/sage50uk/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaCCOUNTOPENED != null)
                {
                    body["ACCOUNT_OPENED"] = ExpressionConverter.ConvertO(__workflow_bodyaCCOUNTOPENED);
                    bodypropCount++;
                }

                if (__workflow_bodyaCCOUNTREF != null)
                {
                    body["ACCOUNT_REF"] = ExpressionConverter.ConvertO(__workflow_bodyaCCOUNTREF);
                    bodypropCount++;
                }

                if (__workflow_bodyaCCOUNTSTATUS != null)
                {
                    body["ACCOUNT_STATUS"] = ExpressionConverter.ConvertO(__workflow_bodyaCCOUNTSTATUS);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS1 != null)
                {
                    body["ADDRESS_1"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS1);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS2 != null)
                {
                    body["ADDRESS_2"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS2);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS3 != null)
                {
                    body["ADDRESS_3"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS3);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS4 != null)
                {
                    body["ADDRESS_4"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS4);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS5 != null)
                {
                    body["ADDRESS_5"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS5);
                    bodypropCount++;
                }

                if (__workflow_bodyaNALYSIS1 != null)
                {
                    body["ANALYSIS_1"] = ExpressionConverter.ConvertO(__workflow_bodyaNALYSIS1);
                    bodypropCount++;
                }

                if (__workflow_bodyaNALYSIS2 != null)
                {
                    body["ANALYSIS_2"] = ExpressionConverter.ConvertO(__workflow_bodyaNALYSIS2);
                    bodypropCount++;
                }

                if (__workflow_bodyaNALYSIS3 != null)
                {
                    body["ANALYSIS_3"] = ExpressionConverter.ConvertO(__workflow_bodyaNALYSIS3);
                    bodypropCount++;
                }

                if (__workflow_bodyaVERAGEPAYDAYS != null)
                {
                    body["AVERAGE_PAY_DAYS"] = ExpressionConverter.ConvertO(__workflow_bodyaVERAGEPAYDAYS);
                    bodypropCount++;
                }

                if (__workflow_bodybALANCE != null)
                {
                    body["BALANCE"] = ExpressionConverter.ConvertO(__workflow_bodybALANCE);
                    bodypropCount++;
                }

                if (__workflow_bodycANAPPLYCHARGES != null)
                {
                    body["CAN_APPLY_CHARGES"] = ExpressionConverter.ConvertO(__workflow_bodycANAPPLYCHARGES);
                    bodypropCount++;
                }

                if (__workflow_bodycONTACTNAME != null)
                {
                    body["CONTACT_NAME"] = ExpressionConverter.ConvertO(__workflow_bodycONTACTNAME);
                    bodypropCount++;
                }

                if (__workflow_bodycOUNTRYCODE != null)
                {
                    body["COUNTRY_CODE"] = ExpressionConverter.ConvertO(__workflow_bodycOUNTRYCODE);
                    bodypropCount++;
                }

                if (__workflow_bodycREDITAPPLIEDFOR != null)
                {
                    body["CREDIT_APPLIED_FOR"] = ExpressionConverter.ConvertO(__workflow_bodycREDITAPPLIEDFOR);
                    bodypropCount++;
                }

                if (__workflow_bodycREDITBUREAU != null)
                {
                    body["CREDIT_BUREAU"] = ExpressionConverter.ConvertO(__workflow_bodycREDITBUREAU);
                    bodypropCount++;
                }

                if (__workflow_bodycREDITLIMIT != null)
                {
                    body["CREDIT_LIMIT"] = ExpressionConverter.ConvertO(__workflow_bodycREDITLIMIT);
                    bodypropCount++;
                }

                if (__workflow_bodycREDITPOSITION != null)
                {
                    body["CREDIT_POSITION"] = ExpressionConverter.ConvertO(__workflow_bodycREDITPOSITION);
                    bodypropCount++;
                }

                if (__workflow_bodycREDITREFERENCE != null)
                {
                    body["CREDIT_REFERENCE"] = ExpressionConverter.ConvertO(__workflow_bodycREDITREFERENCE);
                    bodypropCount++;
                }

                if (__workflow_bodycURRENCY != null)
                {
                    body["CURRENCY"] = ExpressionConverter.ConvertO(__workflow_bodycURRENCY);
                    bodypropCount++;
                }

                if (__workflow_bodydATECREDITAPPRECEIVED != null)
                {
                    body["DATE_CREDIT_APP_RECEIVED"] = ExpressionConverter.ConvertO(__workflow_bodydATECREDITAPPRECEIVED);
                    bodypropCount++;
                }

                if (__workflow_bodydEFNOMCODE != null)
                {
                    body["DEF_NOM_CODE"] = ExpressionConverter.ConvertO(__workflow_bodydEFNOMCODE);
                    bodypropCount++;
                }

                if (__workflow_bodydEFTAXCODE != null)
                {
                    body["DEF_TAX_CODE"] = ExpressionConverter.ConvertO(__workflow_bodydEFTAXCODE);
                    bodypropCount++;
                }

                if (__workflow_bodydEPTNUMBER != null)
                {
                    body["DEPT_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodydEPTNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodydISCOUNTRATE != null)
                {
                    body["DISCOUNT_RATE"] = ExpressionConverter.ConvertO(__workflow_bodydISCOUNTRATE);
                    bodypropCount++;
                }

                if (__workflow_bodydISCOUNTTYPE != null)
                {
                    body["DISCOUNT_TYPE"] = ExpressionConverter.ConvertO(__workflow_bodydISCOUNTTYPE);
                    bodypropCount++;
                }

                if (__workflow_bodydUNSNUMBER != null)
                {
                    body["DUNS_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodydUNSNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyeMAIL != null)
                {
                    body["E_MAIL"] = ExpressionConverter.ConvertO(__workflow_bodyeMAIL);
                    bodypropCount++;
                }

                if (__workflow_bodyeMAIL2 != null)
                {
                    body["E_MAIL2"] = ExpressionConverter.ConvertO(__workflow_bodyeMAIL2);
                    bodypropCount++;
                }

                if (__workflow_bodyeMAIL3 != null)
                {
                    body["E_MAIL3"] = ExpressionConverter.ConvertO(__workflow_bodyeMAIL3);
                    bodypropCount++;
                }

                if (__workflow_bodyextraField != null)
                {
                    body["ExtraField"] = ExpressionConverter.ConvertO(__workflow_bodyextraField);
                    bodypropCount++;
                }

                if (__workflow_bodyfAX != null)
                {
                    body["FAX"] = ExpressionConverter.ConvertO(__workflow_bodyfAX);
                    bodypropCount++;
                }

                if (__workflow_bodyhOLDMAIL != null)
                {
                    body["HOLD_MAIL"] = ExpressionConverter.ConvertO(__workflow_bodyhOLDMAIL);
                    bodypropCount++;
                }

                if (__workflow_bodyiNACTIVEFLAG != null)
                {
                    body["INACTIVE_FLAG"] = ExpressionConverter.ConvertO(__workflow_bodyiNACTIVEFLAG);
                    bodypropCount++;
                }

                if (__workflow_bodyisACCOUNTREFAutogenerate != null)
                {
                    body["IsACCOUNT_REF_autogenerate"] = ExpressionConverter.ConvertO(__workflow_bodyisACCOUNTREFAutogenerate);
                    bodypropCount++;
                }

                if (__workflow_bodylASTCREDITREV != null)
                {
                    body["LAST_CREDIT_REV"] = ExpressionConverter.ConvertO(__workflow_bodylASTCREDITREV);
                    bodypropCount++;
                }

                if (__workflow_bodynAME != null)
                {
                    body["NAME"] = ExpressionConverter.ConvertO(__workflow_bodynAME);
                    bodypropCount++;
                }

                if (__workflow_bodynEXTCREDITREV != null)
                {
                    body["NEXT_CREDIT_REV"] = ExpressionConverter.ConvertO(__workflow_bodynEXTCREDITREV);
                    bodypropCount++;
                }

                if (__workflow_bodyoVERRIDEPRODUCTNOMINAL != null)
                {
                    body["OVERRIDE_PRODUCT_NOMINAL"] = ExpressionConverter.ConvertO(__workflow_bodyoVERRIDEPRODUCTNOMINAL);
                    bodypropCount++;
                }

                if (__workflow_bodyoVERRIDEPRODUCTTAX != null)
                {
                    body["OVERRIDE_PRODUCT_TAX"] = ExpressionConverter.ConvertO(__workflow_bodyoVERRIDEPRODUCTTAX);
                    bodypropCount++;
                }

                if (__workflow_bodypAYMENTDUEDAYS != null)
                {
                    body["PAYMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(__workflow_bodypAYMENTDUEDAYS);
                    bodypropCount++;
                }

                if (__workflow_bodypRICELISTREF != null)
                {
                    body["PRICE_LIST_REF"] = ExpressionConverter.ConvertO(__workflow_bodypRICELISTREF);
                    bodypropCount++;
                }

                if (__workflow_bodypRIORITYTRADER != null)
                {
                    body["PRIORITY_TRADER"] = ExpressionConverter.ConvertO(__workflow_bodypRIORITYTRADER);
                    bodypropCount++;
                }

                if (__workflow_bodysENDINVOICESELECTRONICALLY != null)
                {
                    body["SEND_INVOICES_ELECTRONICALLY"] = ExpressionConverter.ConvertO(__workflow_bodysENDINVOICESELECTRONICALLY);
                    bodypropCount++;
                }

                if (__workflow_bodysENDLETTERSELECTRONICALLY != null)
                {
                    body["SEND_LETTERS_ELECTRONICALLY"] = ExpressionConverter.ConvertO(__workflow_bodysENDLETTERSELECTRONICALLY);
                    bodypropCount++;
                }

                if (__workflow_bodysETTLEMENTDISCRATE != null)
                {
                    body["SETTLEMENT_DISC_RATE"] = ExpressionConverter.ConvertO(__workflow_bodysETTLEMENTDISCRATE);
                    bodypropCount++;
                }

                if (__workflow_bodysETTLEMENTDUEDAYS != null)
                {
                    body["SETTLEMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(__workflow_bodysETTLEMENTDUEDAYS);
                    bodypropCount++;
                }

                if (__workflow_bodytELEPHONE != null)
                {
                    body["TELEPHONE"] = ExpressionConverter.ConvertO(__workflow_bodytELEPHONE);
                    bodypropCount++;
                }

                if (__workflow_bodytELEPHONE2 != null)
                {
                    body["TELEPHONE_2"] = ExpressionConverter.ConvertO(__workflow_bodytELEPHONE2);
                    bodypropCount++;
                }

                if (__workflow_bodytERMS != null)
                {
                    body["TERMS"] = ExpressionConverter.ConvertO(__workflow_bodytERMS);
                    bodypropCount++;
                }

                if (__workflow_bodytERMSAGREEDFLAG != null)
                {
                    body["TERMS_AGREED_FLAG"] = ExpressionConverter.ConvertO(__workflow_bodytERMSAGREEDFLAG);
                    bodypropCount++;
                }

                if (__workflow_bodytRADECONTACT != null)
                {
                    body["TRADE_CONTACT"] = ExpressionConverter.ConvertO(__workflow_bodytRADECONTACT);
                    bodypropCount++;
                }

                if (__workflow_bodyvATREGNUMBER != null)
                {
                    body["VAT_REG_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyvATREGNUMBER);
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
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> SAGE50UKCreateNewSalesOrder(Expression<Func<string>> bodyaCCOUNTREF = null, Expression<Func<string>> bodyaDDRESS1 = null, Expression<Func<string>> bodyaDDRESS2 = null, Expression<Func<string>> bodyaDDRESS3 = null, Expression<Func<string>> bodyaDDRESS4 = null, Expression<Func<string>> bodyaDDRESS5 = null, Expression<Func<int>> bodyaMOUNTPREPAID = null, Expression<Func<string>> bodyaNALYSIS1 = null, Expression<Func<string>> bodyaNALYSIS2 = null, Expression<Func<string>> bodyaNALYSIS3 = null, Expression<Func<int>> bodycARRDEPTNUMBER = null, Expression<Func<int>> bodycARRNET = null, Expression<Func<string>> bodycARRNOMCODE = null, Expression<Func<int>> bodycARRTAX = null, Expression<Func<int>> bodycARRTAXCODE = null, Expression<Func<string>> bodycONSIGNMENTREF = null, Expression<Func<string>> bodycONTACTNAME = null, Expression<Func<int>> bodycOURIER = null, Expression<Func<int>> bodycURRENCY = null, Expression<Func<int>> bodycUSTDISCRATE = null, Expression<Func<string>> bodycUSTORDERNUMBER = null, Expression<Func<string>> bodycUSTTELNUMBER = null, Expression<Func<int>> bodydEFTAXCODE = null, Expression<Func<bool>> bodydELETEDFLAG = null, Expression<Func<string>> bodydELIVERYNAME = null, Expression<Func<string>> bodydELADDRESS1 = null, Expression<Func<string>> bodydELADDRESS2 = null, Expression<Func<string>> bodydELADDRESS3 = null, Expression<Func<string>> bodydELADDRESS4 = null, Expression<Func<string>> bodydELADDRESS5 = null, Expression<Func<string>> bodydESPATCHDATE = null, Expression<Func<string>> bodydUNSNUMBER = null, Expression<Func<int>> bodygLOBALDEPTNUMBER = null, Expression<Func<string>> bodygLOBALDETAILS = null, Expression<Func<string>> bodygLOBALNOMCODE = null, Expression<Func<int>> bodygLOBALTAXCODE = null, Expression<Func<string>> bodyiNVOICENUMBER = null, Expression<Func<string>> bodynAME = null, Expression<Func<string>> bodyoRDERDATE = null, Expression<Func<int>> bodyoRDERNUMBER = null, Expression<Func<int>> bodyoRDERTYPE = null, Expression<Func<int>> bodysETTLEMENTDISCRATE = null, Expression<Func<int>> bodysETTLEMENTDUEDAYS = null, Expression<Func<bodysalesOrderLineItemInputItem222[]>> bodysalesOrderLineItem = null)
        {
            var __workflow_bodyaCCOUNTREF = bodyaCCOUNTREF == null ? null : WorkflowExpression.Compile(bodyaCCOUNTREF);
            WorkflowExpression.Validate(__workflow_bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            var __workflow_bodyaDDRESS1 = bodyaDDRESS1 == null ? null : WorkflowExpression.Compile(bodyaDDRESS1);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            var __workflow_bodyaDDRESS2 = bodyaDDRESS2 == null ? null : WorkflowExpression.Compile(bodyaDDRESS2);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            var __workflow_bodyaDDRESS3 = bodyaDDRESS3 == null ? null : WorkflowExpression.Compile(bodyaDDRESS3);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            var __workflow_bodyaDDRESS4 = bodyaDDRESS4 == null ? null : WorkflowExpression.Compile(bodyaDDRESS4);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            var __workflow_bodyaDDRESS5 = bodyaDDRESS5 == null ? null : WorkflowExpression.Compile(bodyaDDRESS5);
            WorkflowExpression.Validate(__workflow_bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            var __workflow_bodyaMOUNTPREPAID = bodyaMOUNTPREPAID == null ? null : WorkflowExpression.Compile(bodyaMOUNTPREPAID);
            WorkflowExpression.Validate(__workflow_bodyaMOUNTPREPAID, nameof(bodyaMOUNTPREPAID), required: false);
            var __workflow_bodyaNALYSIS1 = bodyaNALYSIS1 == null ? null : WorkflowExpression.Compile(bodyaNALYSIS1);
            WorkflowExpression.Validate(__workflow_bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            var __workflow_bodyaNALYSIS2 = bodyaNALYSIS2 == null ? null : WorkflowExpression.Compile(bodyaNALYSIS2);
            WorkflowExpression.Validate(__workflow_bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            var __workflow_bodyaNALYSIS3 = bodyaNALYSIS3 == null ? null : WorkflowExpression.Compile(bodyaNALYSIS3);
            WorkflowExpression.Validate(__workflow_bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            var __workflow_bodycARRDEPTNUMBER = bodycARRDEPTNUMBER == null ? null : WorkflowExpression.Compile(bodycARRDEPTNUMBER);
            WorkflowExpression.Validate(__workflow_bodycARRDEPTNUMBER, nameof(bodycARRDEPTNUMBER), required: false);
            var __workflow_bodycARRNET = bodycARRNET == null ? null : WorkflowExpression.Compile(bodycARRNET);
            WorkflowExpression.Validate(__workflow_bodycARRNET, nameof(bodycARRNET), required: false);
            var __workflow_bodycARRNOMCODE = bodycARRNOMCODE == null ? null : WorkflowExpression.Compile(bodycARRNOMCODE);
            WorkflowExpression.Validate(__workflow_bodycARRNOMCODE, nameof(bodycARRNOMCODE), required: false);
            var __workflow_bodycARRTAX = bodycARRTAX == null ? null : WorkflowExpression.Compile(bodycARRTAX);
            WorkflowExpression.Validate(__workflow_bodycARRTAX, nameof(bodycARRTAX), required: false);
            var __workflow_bodycARRTAXCODE = bodycARRTAXCODE == null ? null : WorkflowExpression.Compile(bodycARRTAXCODE);
            WorkflowExpression.Validate(__workflow_bodycARRTAXCODE, nameof(bodycARRTAXCODE), required: false);
            var __workflow_bodycONSIGNMENTREF = bodycONSIGNMENTREF == null ? null : WorkflowExpression.Compile(bodycONSIGNMENTREF);
            WorkflowExpression.Validate(__workflow_bodycONSIGNMENTREF, nameof(bodycONSIGNMENTREF), required: false);
            var __workflow_bodycONTACTNAME = bodycONTACTNAME == null ? null : WorkflowExpression.Compile(bodycONTACTNAME);
            WorkflowExpression.Validate(__workflow_bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            var __workflow_bodycOURIER = bodycOURIER == null ? null : WorkflowExpression.Compile(bodycOURIER);
            WorkflowExpression.Validate(__workflow_bodycOURIER, nameof(bodycOURIER), required: false);
            var __workflow_bodycURRENCY = bodycURRENCY == null ? null : WorkflowExpression.Compile(bodycURRENCY);
            WorkflowExpression.Validate(__workflow_bodycURRENCY, nameof(bodycURRENCY), required: false);
            var __workflow_bodycUSTDISCRATE = bodycUSTDISCRATE == null ? null : WorkflowExpression.Compile(bodycUSTDISCRATE);
            WorkflowExpression.Validate(__workflow_bodycUSTDISCRATE, nameof(bodycUSTDISCRATE), required: false);
            var __workflow_bodycUSTORDERNUMBER = bodycUSTORDERNUMBER == null ? null : WorkflowExpression.Compile(bodycUSTORDERNUMBER);
            WorkflowExpression.Validate(__workflow_bodycUSTORDERNUMBER, nameof(bodycUSTORDERNUMBER), required: false);
            var __workflow_bodycUSTTELNUMBER = bodycUSTTELNUMBER == null ? null : WorkflowExpression.Compile(bodycUSTTELNUMBER);
            WorkflowExpression.Validate(__workflow_bodycUSTTELNUMBER, nameof(bodycUSTTELNUMBER), required: false);
            var __workflow_bodydEFTAXCODE = bodydEFTAXCODE == null ? null : WorkflowExpression.Compile(bodydEFTAXCODE);
            WorkflowExpression.Validate(__workflow_bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            var __workflow_bodydELETEDFLAG = bodydELETEDFLAG == null ? null : WorkflowExpression.Compile(bodydELETEDFLAG);
            WorkflowExpression.Validate(__workflow_bodydELETEDFLAG, nameof(bodydELETEDFLAG), required: false);
            var __workflow_bodydELIVERYNAME = bodydELIVERYNAME == null ? null : WorkflowExpression.Compile(bodydELIVERYNAME);
            WorkflowExpression.Validate(__workflow_bodydELIVERYNAME, nameof(bodydELIVERYNAME), required: false);
            var __workflow_bodydELADDRESS1 = bodydELADDRESS1 == null ? null : WorkflowExpression.Compile(bodydELADDRESS1);
            WorkflowExpression.Validate(__workflow_bodydELADDRESS1, nameof(bodydELADDRESS1), required: false);
            var __workflow_bodydELADDRESS2 = bodydELADDRESS2 == null ? null : WorkflowExpression.Compile(bodydELADDRESS2);
            WorkflowExpression.Validate(__workflow_bodydELADDRESS2, nameof(bodydELADDRESS2), required: false);
            var __workflow_bodydELADDRESS3 = bodydELADDRESS3 == null ? null : WorkflowExpression.Compile(bodydELADDRESS3);
            WorkflowExpression.Validate(__workflow_bodydELADDRESS3, nameof(bodydELADDRESS3), required: false);
            var __workflow_bodydELADDRESS4 = bodydELADDRESS4 == null ? null : WorkflowExpression.Compile(bodydELADDRESS4);
            WorkflowExpression.Validate(__workflow_bodydELADDRESS4, nameof(bodydELADDRESS4), required: false);
            var __workflow_bodydELADDRESS5 = bodydELADDRESS5 == null ? null : WorkflowExpression.Compile(bodydELADDRESS5);
            WorkflowExpression.Validate(__workflow_bodydELADDRESS5, nameof(bodydELADDRESS5), required: false);
            var __workflow_bodydESPATCHDATE = bodydESPATCHDATE == null ? null : WorkflowExpression.Compile(bodydESPATCHDATE);
            WorkflowExpression.Validate(__workflow_bodydESPATCHDATE, nameof(bodydESPATCHDATE), required: false);
            var __workflow_bodydUNSNUMBER = bodydUNSNUMBER == null ? null : WorkflowExpression.Compile(bodydUNSNUMBER);
            WorkflowExpression.Validate(__workflow_bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            var __workflow_bodygLOBALDEPTNUMBER = bodygLOBALDEPTNUMBER == null ? null : WorkflowExpression.Compile(bodygLOBALDEPTNUMBER);
            WorkflowExpression.Validate(__workflow_bodygLOBALDEPTNUMBER, nameof(bodygLOBALDEPTNUMBER), required: false);
            var __workflow_bodygLOBALDETAILS = bodygLOBALDETAILS == null ? null : WorkflowExpression.Compile(bodygLOBALDETAILS);
            WorkflowExpression.Validate(__workflow_bodygLOBALDETAILS, nameof(bodygLOBALDETAILS), required: false);
            var __workflow_bodygLOBALNOMCODE = bodygLOBALNOMCODE == null ? null : WorkflowExpression.Compile(bodygLOBALNOMCODE);
            WorkflowExpression.Validate(__workflow_bodygLOBALNOMCODE, nameof(bodygLOBALNOMCODE), required: false);
            var __workflow_bodygLOBALTAXCODE = bodygLOBALTAXCODE == null ? null : WorkflowExpression.Compile(bodygLOBALTAXCODE);
            WorkflowExpression.Validate(__workflow_bodygLOBALTAXCODE, nameof(bodygLOBALTAXCODE), required: false);
            var __workflow_bodyiNVOICENUMBER = bodyiNVOICENUMBER == null ? null : WorkflowExpression.Compile(bodyiNVOICENUMBER);
            WorkflowExpression.Validate(__workflow_bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            var __workflow_bodynAME = bodynAME == null ? null : WorkflowExpression.Compile(bodynAME);
            WorkflowExpression.Validate(__workflow_bodynAME, nameof(bodynAME), required: false);
            var __workflow_bodyoRDERDATE = bodyoRDERDATE == null ? null : WorkflowExpression.Compile(bodyoRDERDATE);
            WorkflowExpression.Validate(__workflow_bodyoRDERDATE, nameof(bodyoRDERDATE), required: false);
            var __workflow_bodyoRDERNUMBER = bodyoRDERNUMBER == null ? null : WorkflowExpression.Compile(bodyoRDERNUMBER);
            WorkflowExpression.Validate(__workflow_bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            var __workflow_bodyoRDERTYPE = bodyoRDERTYPE == null ? null : WorkflowExpression.Compile(bodyoRDERTYPE);
            WorkflowExpression.Validate(__workflow_bodyoRDERTYPE, nameof(bodyoRDERTYPE), required: false);
            var __workflow_bodysETTLEMENTDISCRATE = bodysETTLEMENTDISCRATE == null ? null : WorkflowExpression.Compile(bodysETTLEMENTDISCRATE);
            WorkflowExpression.Validate(__workflow_bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            var __workflow_bodysETTLEMENTDUEDAYS = bodysETTLEMENTDUEDAYS == null ? null : WorkflowExpression.Compile(bodysETTLEMENTDUEDAYS);
            WorkflowExpression.Validate(__workflow_bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            var __workflow_bodysalesOrderLineItem = bodysalesOrderLineItem == null ? null : WorkflowExpression.Compile(bodysalesOrderLineItem);
            WorkflowExpression.Validate(__workflow_bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            return new DeferredBodyAction<SAGE50UKCreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/sage50uk/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaCCOUNTREF != null)
                {
                    body["ACCOUNT_REF"] = ExpressionConverter.ConvertO(__workflow_bodyaCCOUNTREF);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS1 != null)
                {
                    body["ADDRESS_1"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS1);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS2 != null)
                {
                    body["ADDRESS_2"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS2);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS3 != null)
                {
                    body["ADDRESS_3"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS3);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS4 != null)
                {
                    body["ADDRESS_4"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS4);
                    bodypropCount++;
                }

                if (__workflow_bodyaDDRESS5 != null)
                {
                    body["ADDRESS_5"] = ExpressionConverter.ConvertO(__workflow_bodyaDDRESS5);
                    bodypropCount++;
                }

                if (__workflow_bodyaMOUNTPREPAID != null)
                {
                    body["AMOUNT_PREPAID"] = ExpressionConverter.ConvertO(__workflow_bodyaMOUNTPREPAID);
                    bodypropCount++;
                }

                if (__workflow_bodyaNALYSIS1 != null)
                {
                    body["ANALYSIS_1"] = ExpressionConverter.ConvertO(__workflow_bodyaNALYSIS1);
                    bodypropCount++;
                }

                if (__workflow_bodyaNALYSIS2 != null)
                {
                    body["ANALYSIS_2"] = ExpressionConverter.ConvertO(__workflow_bodyaNALYSIS2);
                    bodypropCount++;
                }

                if (__workflow_bodyaNALYSIS3 != null)
                {
                    body["ANALYSIS_3"] = ExpressionConverter.ConvertO(__workflow_bodyaNALYSIS3);
                    bodypropCount++;
                }

                if (__workflow_bodycARRDEPTNUMBER != null)
                {
                    body["CARR_DEPT_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodycARRDEPTNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodycARRNET != null)
                {
                    body["CARR_NET"] = ExpressionConverter.ConvertO(__workflow_bodycARRNET);
                    bodypropCount++;
                }

                if (__workflow_bodycARRNOMCODE != null)
                {
                    body["CARR_NOM_CODE"] = ExpressionConverter.ConvertO(__workflow_bodycARRNOMCODE);
                    bodypropCount++;
                }

                if (__workflow_bodycARRTAX != null)
                {
                    body["CARR_TAX"] = ExpressionConverter.ConvertO(__workflow_bodycARRTAX);
                    bodypropCount++;
                }

                if (__workflow_bodycARRTAXCODE != null)
                {
                    body["CARR_TAX_CODE"] = ExpressionConverter.ConvertO(__workflow_bodycARRTAXCODE);
                    bodypropCount++;
                }

                if (__workflow_bodycONSIGNMENTREF != null)
                {
                    body["CONSIGNMENT_REF"] = ExpressionConverter.ConvertO(__workflow_bodycONSIGNMENTREF);
                    bodypropCount++;
                }

                if (__workflow_bodycONTACTNAME != null)
                {
                    body["CONTACT_NAME"] = ExpressionConverter.ConvertO(__workflow_bodycONTACTNAME);
                    bodypropCount++;
                }

                if (__workflow_bodycOURIER != null)
                {
                    body["COURIER"] = ExpressionConverter.ConvertO(__workflow_bodycOURIER);
                    bodypropCount++;
                }

                if (__workflow_bodycURRENCY != null)
                {
                    body["CURRENCY"] = ExpressionConverter.ConvertO(__workflow_bodycURRENCY);
                    bodypropCount++;
                }

                if (__workflow_bodycUSTDISCRATE != null)
                {
                    body["CUST_DISC_RATE"] = ExpressionConverter.ConvertO(__workflow_bodycUSTDISCRATE);
                    bodypropCount++;
                }

                if (__workflow_bodycUSTORDERNUMBER != null)
                {
                    body["CUST_ORDER_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodycUSTORDERNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodycUSTTELNUMBER != null)
                {
                    body["CUST_TEL_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodycUSTTELNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodydEFTAXCODE != null)
                {
                    body["DEF_TAX_CODE"] = ExpressionConverter.ConvertO(__workflow_bodydEFTAXCODE);
                    bodypropCount++;
                }

                if (__workflow_bodydELETEDFLAG != null)
                {
                    body["DELETED_FLAG"] = ExpressionConverter.ConvertO(__workflow_bodydELETEDFLAG);
                    bodypropCount++;
                }

                if (__workflow_bodydELIVERYNAME != null)
                {
                    body["DELIVERY_NAME"] = ExpressionConverter.ConvertO(__workflow_bodydELIVERYNAME);
                    bodypropCount++;
                }

                if (__workflow_bodydELADDRESS1 != null)
                {
                    body["DEL_ADDRESS_1"] = ExpressionConverter.ConvertO(__workflow_bodydELADDRESS1);
                    bodypropCount++;
                }

                if (__workflow_bodydELADDRESS2 != null)
                {
                    body["DEL_ADDRESS_2"] = ExpressionConverter.ConvertO(__workflow_bodydELADDRESS2);
                    bodypropCount++;
                }

                if (__workflow_bodydELADDRESS3 != null)
                {
                    body["DEL_ADDRESS_3"] = ExpressionConverter.ConvertO(__workflow_bodydELADDRESS3);
                    bodypropCount++;
                }

                if (__workflow_bodydELADDRESS4 != null)
                {
                    body["DEL_ADDRESS_4"] = ExpressionConverter.ConvertO(__workflow_bodydELADDRESS4);
                    bodypropCount++;
                }

                if (__workflow_bodydELADDRESS5 != null)
                {
                    body["DEL_ADDRESS_5"] = ExpressionConverter.ConvertO(__workflow_bodydELADDRESS5);
                    bodypropCount++;
                }

                if (__workflow_bodydESPATCHDATE != null)
                {
                    body["DESPATCH_DATE"] = ExpressionConverter.ConvertO(__workflow_bodydESPATCHDATE);
                    bodypropCount++;
                }

                if (__workflow_bodydUNSNUMBER != null)
                {
                    body["DUNS_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodydUNSNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodygLOBALDEPTNUMBER != null)
                {
                    body["GLOBAL_DEPT_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodygLOBALDEPTNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodygLOBALDETAILS != null)
                {
                    body["GLOBAL_DETAILS"] = ExpressionConverter.ConvertO(__workflow_bodygLOBALDETAILS);
                    bodypropCount++;
                }

                if (__workflow_bodygLOBALNOMCODE != null)
                {
                    body["GLOBAL_NOM_CODE"] = ExpressionConverter.ConvertO(__workflow_bodygLOBALNOMCODE);
                    bodypropCount++;
                }

                if (__workflow_bodygLOBALTAXCODE != null)
                {
                    body["GLOBAL_TAX_CODE"] = ExpressionConverter.ConvertO(__workflow_bodygLOBALTAXCODE);
                    bodypropCount++;
                }

                if (__workflow_bodyiNVOICENUMBER != null)
                {
                    body["INVOICE_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyiNVOICENUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodynAME != null)
                {
                    body["NAME"] = ExpressionConverter.ConvertO(__workflow_bodynAME);
                    bodypropCount++;
                }

                if (__workflow_bodyoRDERDATE != null)
                {
                    body["ORDER_DATE"] = ExpressionConverter.ConvertO(__workflow_bodyoRDERDATE);
                    bodypropCount++;
                }

                if (__workflow_bodyoRDERNUMBER != null)
                {
                    body["ORDER_NUMBER"] = ExpressionConverter.ConvertO(__workflow_bodyoRDERNUMBER);
                    bodypropCount++;
                }

                if (__workflow_bodyoRDERTYPE != null)
                {
                    body["ORDER_TYPE"] = ExpressionConverter.ConvertO(__workflow_bodyoRDERTYPE);
                    bodypropCount++;
                }

                if (__workflow_bodysETTLEMENTDISCRATE != null)
                {
                    body["SETTLEMENT_DISC_RATE"] = ExpressionConverter.ConvertO(__workflow_bodysETTLEMENTDISCRATE);
                    bodypropCount++;
                }

                if (__workflow_bodysETTLEMENTDUEDAYS != null)
                {
                    body["SETTLEMENT_DUE_DAYS"] = ExpressionConverter.ConvertO(__workflow_bodysETTLEMENTDUEDAYS);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderLineItem);
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
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> SAGE50USCreateNewCustomer(Expression<Func<string>> bodyaccountNumber = null, Expression<Func<string>> bodybillingCity = null, Expression<Func<string>> bodybillingCountry = null, Expression<Func<string>> bodybillingLastName = null, Expression<Func<string>> bodybillingName = null, Expression<Func<string>> bodybillingPostalCode = null, Expression<Func<string>> bodybillingState = null, Expression<Func<string>> bodybillingStreet = null, Expression<Func<bool>> bodycCSalesRepresentative = null, Expression<Func<bool>> bodychargeFinanceCharges = null, Expression<Func<string>> bodycontactName = null, Expression<Func<int>> bodycreditLimit = null, Expression<Func<int>> bodycreditStatus = null, Expression<Func<string>> bodycustomFieldValue1 = null, Expression<Func<string>> bodycustomFieldValue2 = null, Expression<Func<string>> bodycustomFieldValue3 = null, Expression<Func<string>> bodycustomFieldValue4 = null, Expression<Func<string>> bodycustomFieldValue5 = null, Expression<Func<string>> bodycustomerGUID = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<int>> bodycustomerBalance = null, Expression<Func<string>> bodycustomerSinceDate = null, Expression<Func<string>> bodycustomerType = null, Expression<Func<int>> bodydiscountDays = null, Expression<Func<int>> bodydiscountPercent = null, Expression<Func<int>> bodydueDays = null, Expression<Func<string>> bodyeMailAddress = null, Expression<Func<string>> bodyfaxNumber = null, Expression<Func<int>> bodyformDeliveryMethod = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyphoneNo1 = null, Expression<Func<string>> bodyphoneNo2 = null, Expression<Func<int>> bodypricingLevel = null, Expression<Func<string>> bodysalesRepresentativeID = null, Expression<Func<string>> bodysalesTaxCode = null, Expression<Func<string>> bodyshippingCity = null, Expression<Func<string>> bodyshippingCountry = null, Expression<Func<string>> bodyshippingPostalCode = null, Expression<Func<string>> bodyshippingState = null, Expression<Func<string>> bodyshippingStreet = null, Expression<Func<bool>> bodytermsType = null, Expression<Func<bool>> bodyuseCODTerms = null, Expression<Func<bool>> bodyuseDueMonthEndTerms = null, Expression<Func<bool>> bodyusePrepaidTerms = null, Expression<Func<bool>> bodyuseStandardTerms = null, Expression<Func<bool>> bodyisInactive = null)
        {
            var __workflow_bodyaccountNumber = bodyaccountNumber == null ? null : WorkflowExpression.Compile(bodyaccountNumber);
            WorkflowExpression.Validate(__workflow_bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            var __workflow_bodybillingCity = bodybillingCity == null ? null : WorkflowExpression.Compile(bodybillingCity);
            WorkflowExpression.Validate(__workflow_bodybillingCity, nameof(bodybillingCity), required: false);
            var __workflow_bodybillingCountry = bodybillingCountry == null ? null : WorkflowExpression.Compile(bodybillingCountry);
            WorkflowExpression.Validate(__workflow_bodybillingCountry, nameof(bodybillingCountry), required: false);
            var __workflow_bodybillingLastName = bodybillingLastName == null ? null : WorkflowExpression.Compile(bodybillingLastName);
            WorkflowExpression.Validate(__workflow_bodybillingLastName, nameof(bodybillingLastName), required: false);
            var __workflow_bodybillingName = bodybillingName == null ? null : WorkflowExpression.Compile(bodybillingName);
            WorkflowExpression.Validate(__workflow_bodybillingName, nameof(bodybillingName), required: false);
            var __workflow_bodybillingPostalCode = bodybillingPostalCode == null ? null : WorkflowExpression.Compile(bodybillingPostalCode);
            WorkflowExpression.Validate(__workflow_bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            var __workflow_bodybillingState = bodybillingState == null ? null : WorkflowExpression.Compile(bodybillingState);
            WorkflowExpression.Validate(__workflow_bodybillingState, nameof(bodybillingState), required: false);
            var __workflow_bodybillingStreet = bodybillingStreet == null ? null : WorkflowExpression.Compile(bodybillingStreet);
            WorkflowExpression.Validate(__workflow_bodybillingStreet, nameof(bodybillingStreet), required: false);
            var __workflow_bodycCSalesRepresentative = bodycCSalesRepresentative == null ? null : WorkflowExpression.Compile(bodycCSalesRepresentative);
            WorkflowExpression.Validate(__workflow_bodycCSalesRepresentative, nameof(bodycCSalesRepresentative), required: false);
            var __workflow_bodychargeFinanceCharges = bodychargeFinanceCharges == null ? null : WorkflowExpression.Compile(bodychargeFinanceCharges);
            WorkflowExpression.Validate(__workflow_bodychargeFinanceCharges, nameof(bodychargeFinanceCharges), required: false);
            var __workflow_bodycontactName = bodycontactName == null ? null : WorkflowExpression.Compile(bodycontactName);
            WorkflowExpression.Validate(__workflow_bodycontactName, nameof(bodycontactName), required: false);
            var __workflow_bodycreditLimit = bodycreditLimit == null ? null : WorkflowExpression.Compile(bodycreditLimit);
            WorkflowExpression.Validate(__workflow_bodycreditLimit, nameof(bodycreditLimit), required: false);
            var __workflow_bodycreditStatus = bodycreditStatus == null ? null : WorkflowExpression.Compile(bodycreditStatus);
            WorkflowExpression.Validate(__workflow_bodycreditStatus, nameof(bodycreditStatus), required: false);
            var __workflow_bodycustomFieldValue1 = bodycustomFieldValue1 == null ? null : WorkflowExpression.Compile(bodycustomFieldValue1);
            WorkflowExpression.Validate(__workflow_bodycustomFieldValue1, nameof(bodycustomFieldValue1), required: false);
            var __workflow_bodycustomFieldValue2 = bodycustomFieldValue2 == null ? null : WorkflowExpression.Compile(bodycustomFieldValue2);
            WorkflowExpression.Validate(__workflow_bodycustomFieldValue2, nameof(bodycustomFieldValue2), required: false);
            var __workflow_bodycustomFieldValue3 = bodycustomFieldValue3 == null ? null : WorkflowExpression.Compile(bodycustomFieldValue3);
            WorkflowExpression.Validate(__workflow_bodycustomFieldValue3, nameof(bodycustomFieldValue3), required: false);
            var __workflow_bodycustomFieldValue4 = bodycustomFieldValue4 == null ? null : WorkflowExpression.Compile(bodycustomFieldValue4);
            WorkflowExpression.Validate(__workflow_bodycustomFieldValue4, nameof(bodycustomFieldValue4), required: false);
            var __workflow_bodycustomFieldValue5 = bodycustomFieldValue5 == null ? null : WorkflowExpression.Compile(bodycustomFieldValue5);
            WorkflowExpression.Validate(__workflow_bodycustomFieldValue5, nameof(bodycustomFieldValue5), required: false);
            var __workflow_bodycustomerGUID = bodycustomerGUID == null ? null : WorkflowExpression.Compile(bodycustomerGUID);
            WorkflowExpression.Validate(__workflow_bodycustomerGUID, nameof(bodycustomerGUID), required: false);
            var __workflow_bodycustomerID = bodycustomerID == null ? null : WorkflowExpression.Compile(bodycustomerID);
            WorkflowExpression.Validate(__workflow_bodycustomerID, nameof(bodycustomerID), required: false);
            var __workflow_bodycustomerBalance = bodycustomerBalance == null ? null : WorkflowExpression.Compile(bodycustomerBalance);
            WorkflowExpression.Validate(__workflow_bodycustomerBalance, nameof(bodycustomerBalance), required: false);
            var __workflow_bodycustomerSinceDate = bodycustomerSinceDate == null ? null : WorkflowExpression.Compile(bodycustomerSinceDate);
            WorkflowExpression.Validate(__workflow_bodycustomerSinceDate, nameof(bodycustomerSinceDate), required: false);
            var __workflow_bodycustomerType = bodycustomerType == null ? null : WorkflowExpression.Compile(bodycustomerType);
            WorkflowExpression.Validate(__workflow_bodycustomerType, nameof(bodycustomerType), required: false);
            var __workflow_bodydiscountDays = bodydiscountDays == null ? null : WorkflowExpression.Compile(bodydiscountDays);
            WorkflowExpression.Validate(__workflow_bodydiscountDays, nameof(bodydiscountDays), required: false);
            var __workflow_bodydiscountPercent = bodydiscountPercent == null ? null : WorkflowExpression.Compile(bodydiscountPercent);
            WorkflowExpression.Validate(__workflow_bodydiscountPercent, nameof(bodydiscountPercent), required: false);
            var __workflow_bodydueDays = bodydueDays == null ? null : WorkflowExpression.Compile(bodydueDays);
            WorkflowExpression.Validate(__workflow_bodydueDays, nameof(bodydueDays), required: false);
            var __workflow_bodyeMailAddress = bodyeMailAddress == null ? null : WorkflowExpression.Compile(bodyeMailAddress);
            WorkflowExpression.Validate(__workflow_bodyeMailAddress, nameof(bodyeMailAddress), required: false);
            var __workflow_bodyfaxNumber = bodyfaxNumber == null ? null : WorkflowExpression.Compile(bodyfaxNumber);
            WorkflowExpression.Validate(__workflow_bodyfaxNumber, nameof(bodyfaxNumber), required: false);
            var __workflow_bodyformDeliveryMethod = bodyformDeliveryMethod == null ? null : WorkflowExpression.Compile(bodyformDeliveryMethod);
            WorkflowExpression.Validate(__workflow_bodyformDeliveryMethod, nameof(bodyformDeliveryMethod), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyphoneNo1 = bodyphoneNo1 == null ? null : WorkflowExpression.Compile(bodyphoneNo1);
            WorkflowExpression.Validate(__workflow_bodyphoneNo1, nameof(bodyphoneNo1), required: false);
            var __workflow_bodyphoneNo2 = bodyphoneNo2 == null ? null : WorkflowExpression.Compile(bodyphoneNo2);
            WorkflowExpression.Validate(__workflow_bodyphoneNo2, nameof(bodyphoneNo2), required: false);
            var __workflow_bodypricingLevel = bodypricingLevel == null ? null : WorkflowExpression.Compile(bodypricingLevel);
            WorkflowExpression.Validate(__workflow_bodypricingLevel, nameof(bodypricingLevel), required: false);
            var __workflow_bodysalesRepresentativeID = bodysalesRepresentativeID == null ? null : WorkflowExpression.Compile(bodysalesRepresentativeID);
            WorkflowExpression.Validate(__workflow_bodysalesRepresentativeID, nameof(bodysalesRepresentativeID), required: false);
            var __workflow_bodysalesTaxCode = bodysalesTaxCode == null ? null : WorkflowExpression.Compile(bodysalesTaxCode);
            WorkflowExpression.Validate(__workflow_bodysalesTaxCode, nameof(bodysalesTaxCode), required: false);
            var __workflow_bodyshippingCity = bodyshippingCity == null ? null : WorkflowExpression.Compile(bodyshippingCity);
            WorkflowExpression.Validate(__workflow_bodyshippingCity, nameof(bodyshippingCity), required: false);
            var __workflow_bodyshippingCountry = bodyshippingCountry == null ? null : WorkflowExpression.Compile(bodyshippingCountry);
            WorkflowExpression.Validate(__workflow_bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            var __workflow_bodyshippingPostalCode = bodyshippingPostalCode == null ? null : WorkflowExpression.Compile(bodyshippingPostalCode);
            WorkflowExpression.Validate(__workflow_bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            var __workflow_bodyshippingState = bodyshippingState == null ? null : WorkflowExpression.Compile(bodyshippingState);
            WorkflowExpression.Validate(__workflow_bodyshippingState, nameof(bodyshippingState), required: false);
            var __workflow_bodyshippingStreet = bodyshippingStreet == null ? null : WorkflowExpression.Compile(bodyshippingStreet);
            WorkflowExpression.Validate(__workflow_bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            var __workflow_bodytermsType = bodytermsType == null ? null : WorkflowExpression.Compile(bodytermsType);
            WorkflowExpression.Validate(__workflow_bodytermsType, nameof(bodytermsType), required: false);
            var __workflow_bodyuseCODTerms = bodyuseCODTerms == null ? null : WorkflowExpression.Compile(bodyuseCODTerms);
            WorkflowExpression.Validate(__workflow_bodyuseCODTerms, nameof(bodyuseCODTerms), required: false);
            var __workflow_bodyuseDueMonthEndTerms = bodyuseDueMonthEndTerms == null ? null : WorkflowExpression.Compile(bodyuseDueMonthEndTerms);
            WorkflowExpression.Validate(__workflow_bodyuseDueMonthEndTerms, nameof(bodyuseDueMonthEndTerms), required: false);
            var __workflow_bodyusePrepaidTerms = bodyusePrepaidTerms == null ? null : WorkflowExpression.Compile(bodyusePrepaidTerms);
            WorkflowExpression.Validate(__workflow_bodyusePrepaidTerms, nameof(bodyusePrepaidTerms), required: false);
            var __workflow_bodyuseStandardTerms = bodyuseStandardTerms == null ? null : WorkflowExpression.Compile(bodyuseStandardTerms);
            WorkflowExpression.Validate(__workflow_bodyuseStandardTerms, nameof(bodyuseStandardTerms), required: false);
            var __workflow_bodyisInactive = bodyisInactive == null ? null : WorkflowExpression.Compile(bodyisInactive);
            WorkflowExpression.Validate(__workflow_bodyisInactive, nameof(bodyisInactive), required: false);
            return new DeferredBodyAction<SAGE50USCreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/sage50us/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountNumber != null)
                {
                    body["Account_Number"] = ExpressionConverter.ConvertO(__workflow_bodyaccountNumber);
                    bodypropCount++;
                }

                if (__workflow_bodybillingCity != null)
                {
                    body["BillingCity"] = ExpressionConverter.ConvertO(__workflow_bodybillingCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillingCountry != null)
                {
                    body["BillingCountry"] = ExpressionConverter.ConvertO(__workflow_bodybillingCountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillingLastName != null)
                {
                    body["BillingLastName"] = ExpressionConverter.ConvertO(__workflow_bodybillingLastName);
                    bodypropCount++;
                }

                if (__workflow_bodybillingName != null)
                {
                    body["BillingName"] = ExpressionConverter.ConvertO(__workflow_bodybillingName);
                    bodypropCount++;
                }

                if (__workflow_bodybillingPostalCode != null)
                {
                    body["BillingPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodybillingPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodybillingState != null)
                {
                    body["BillingState"] = ExpressionConverter.ConvertO(__workflow_bodybillingState);
                    bodypropCount++;
                }

                if (__workflow_bodybillingStreet != null)
                {
                    body["BillingStreet"] = ExpressionConverter.ConvertO(__workflow_bodybillingStreet);
                    bodypropCount++;
                }

                if (__workflow_bodycCSalesRepresentative != null)
                {
                    body["CC_Sales_Representative"] = ExpressionConverter.ConvertO(__workflow_bodycCSalesRepresentative);
                    bodypropCount++;
                }

                if (__workflow_bodychargeFinanceCharges != null)
                {
                    body["Charge_Finance_Charges"] = ExpressionConverter.ConvertO(__workflow_bodychargeFinanceCharges);
                    bodypropCount++;
                }

                if (__workflow_bodycontactName != null)
                {
                    body["ContactName"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                    bodypropCount++;
                }

                if (__workflow_bodycreditLimit != null)
                {
                    body["Credit_Limit"] = ExpressionConverter.ConvertO(__workflow_bodycreditLimit);
                    bodypropCount++;
                }

                if (__workflow_bodycreditStatus != null)
                {
                    body["Credit_Status"] = ExpressionConverter.ConvertO(__workflow_bodycreditStatus);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldValue1 != null)
                {
                    body["CustomFieldValue1"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldValue1);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldValue2 != null)
                {
                    body["CustomFieldValue2"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldValue2);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldValue3 != null)
                {
                    body["CustomFieldValue3"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldValue3);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldValue4 != null)
                {
                    body["CustomFieldValue4"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldValue4);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFieldValue5 != null)
                {
                    body["CustomFieldValue5"] = ExpressionConverter.ConvertO(__workflow_bodycustomFieldValue5);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerGUID != null)
                {
                    body["CustomerGUID"] = ExpressionConverter.ConvertO(__workflow_bodycustomerGUID);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerID != null)
                {
                    body["CustomerID"] = ExpressionConverter.ConvertO(__workflow_bodycustomerID);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerBalance != null)
                {
                    body["Customer_Balance"] = ExpressionConverter.ConvertO(__workflow_bodycustomerBalance);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerSinceDate != null)
                {
                    body["Customer_Since_Date"] = ExpressionConverter.ConvertO(__workflow_bodycustomerSinceDate);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerType != null)
                {
                    body["Customer_Type"] = ExpressionConverter.ConvertO(__workflow_bodycustomerType);
                    bodypropCount++;
                }

                if (__workflow_bodydiscountDays != null)
                {
                    body["Discount_Days"] = ExpressionConverter.ConvertO(__workflow_bodydiscountDays);
                    bodypropCount++;
                }

                if (__workflow_bodydiscountPercent != null)
                {
                    body["Discount_Percent"] = ExpressionConverter.ConvertO(__workflow_bodydiscountPercent);
                    bodypropCount++;
                }

                if (__workflow_bodydueDays != null)
                {
                    body["Due_Days"] = ExpressionConverter.ConvertO(__workflow_bodydueDays);
                    bodypropCount++;
                }

                if (__workflow_bodyeMailAddress != null)
                {
                    body["EMail_Address"] = ExpressionConverter.ConvertO(__workflow_bodyeMailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxNumber != null)
                {
                    body["FaxNumber"] = ExpressionConverter.ConvertO(__workflow_bodyfaxNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyformDeliveryMethod != null)
                {
                    body["Form_Delivery_Method"] = ExpressionConverter.ConvertO(__workflow_bodyformDeliveryMethod);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNo1 != null)
                {
                    body["PhoneNo1"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNo1);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNo2 != null)
                {
                    body["PhoneNo2"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNo2);
                    bodypropCount++;
                }

                if (__workflow_bodypricingLevel != null)
                {
                    body["Pricing_Level"] = ExpressionConverter.ConvertO(__workflow_bodypricingLevel);
                    bodypropCount++;
                }

                if (__workflow_bodysalesRepresentativeID != null)
                {
                    body["Sales_Representative_ID"] = ExpressionConverter.ConvertO(__workflow_bodysalesRepresentativeID);
                    bodypropCount++;
                }

                if (__workflow_bodysalesTaxCode != null)
                {
                    body["Sales_Tax_Code"] = ExpressionConverter.ConvertO(__workflow_bodysalesTaxCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCity != null)
                {
                    body["ShippingCity"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCountry != null)
                {
                    body["ShippingCountry"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingPostalCode != null)
                {
                    body["ShippingPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyshippingPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingState != null)
                {
                    body["ShippingState"] = ExpressionConverter.ConvertO(__workflow_bodyshippingState);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingStreet != null)
                {
                    body["ShippingStreet"] = ExpressionConverter.ConvertO(__workflow_bodyshippingStreet);
                    bodypropCount++;
                }

                if (__workflow_bodytermsType != null)
                {
                    body["Terms_Type"] = ExpressionConverter.ConvertO(__workflow_bodytermsType);
                    bodypropCount++;
                }

                if (__workflow_bodyuseCODTerms != null)
                {
                    body["Use_COD_Terms"] = ExpressionConverter.ConvertO(__workflow_bodyuseCODTerms);
                    bodypropCount++;
                }

                if (__workflow_bodyuseDueMonthEndTerms != null)
                {
                    body["Use_Due_Month_End_Terms"] = ExpressionConverter.ConvertO(__workflow_bodyuseDueMonthEndTerms);
                    bodypropCount++;
                }

                if (__workflow_bodyusePrepaidTerms != null)
                {
                    body["Use_Prepaid_Terms"] = ExpressionConverter.ConvertO(__workflow_bodyusePrepaidTerms);
                    bodypropCount++;
                }

                if (__workflow_bodyuseStandardTerms != null)
                {
                    body["Use_Standard_Terms"] = ExpressionConverter.ConvertO(__workflow_bodyuseStandardTerms);
                    bodypropCount++;
                }

                if (__workflow_bodyisInactive != null)
                {
                    body["isInactive"] = ExpressionConverter.ConvertO(__workflow_bodyisInactive);
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
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> SAGE50USCreateNewSalesOrder(Expression<Func<string>> bodyaccountsReceivableAccount = null, Expression<Func<string>> bodyaccountsReceivableAcctGUID = null, Expression<Func<int>> bodyaccountsReceivableAmount = null, Expression<Func<bool>> bodyclosed = null, Expression<Func<string>> bodycustomerID = null, Expression<Func<string>> bodycustomerPO = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodydiscountAmount = null, Expression<Func<string>> bodydisplayedTerms = null, Expression<Func<bool>> bodydropShip = null, Expression<Func<string>> bodygUID = null, Expression<Func<bool>> bodynotePrintsAfterLineItems = null, Expression<Func<bool>> bodyproposal = null, Expression<Func<bool>> bodyproposalAccepted = null, Expression<Func<bodysalesOrderLineItemInputItem2222[]>> bodysalesOrderLineItem = null, Expression<Func<string>> bodysalesOrderNumber = null, Expression<Func<string>> bodysalesRepresentativeGUID = null, Expression<Func<string>> bodysalesRepresentativeID = null, Expression<Func<string>> bodyshipAddressCity = null, Expression<Func<string>> bodyshipAddressCountry = null, Expression<Func<string>> bodyshipAddressLine1 = null, Expression<Func<string>> bodyshipAddressLine2 = null, Expression<Func<string>> bodyshipAddressName = null, Expression<Func<string>> bodyshipAddressState = null, Expression<Func<string>> bodyshipAddressZipCode = null, Expression<Func<string>> bodyshipBy = null, Expression<Func<string>> bodyshipVIA = null, Expression<Func<bool>> bodystatementNotePrintsBeforeInvRef = null)
        {
            var __workflow_bodyaccountsReceivableAccount = bodyaccountsReceivableAccount == null ? null : WorkflowExpression.Compile(bodyaccountsReceivableAccount);
            WorkflowExpression.Validate(__workflow_bodyaccountsReceivableAccount, nameof(bodyaccountsReceivableAccount), required: false);
            var __workflow_bodyaccountsReceivableAcctGUID = bodyaccountsReceivableAcctGUID == null ? null : WorkflowExpression.Compile(bodyaccountsReceivableAcctGUID);
            WorkflowExpression.Validate(__workflow_bodyaccountsReceivableAcctGUID, nameof(bodyaccountsReceivableAcctGUID), required: false);
            var __workflow_bodyaccountsReceivableAmount = bodyaccountsReceivableAmount == null ? null : WorkflowExpression.Compile(bodyaccountsReceivableAmount);
            WorkflowExpression.Validate(__workflow_bodyaccountsReceivableAmount, nameof(bodyaccountsReceivableAmount), required: false);
            var __workflow_bodyclosed = bodyclosed == null ? null : WorkflowExpression.Compile(bodyclosed);
            WorkflowExpression.Validate(__workflow_bodyclosed, nameof(bodyclosed), required: false);
            var __workflow_bodycustomerID = bodycustomerID == null ? null : WorkflowExpression.Compile(bodycustomerID);
            WorkflowExpression.Validate(__workflow_bodycustomerID, nameof(bodycustomerID), required: false);
            var __workflow_bodycustomerPO = bodycustomerPO == null ? null : WorkflowExpression.Compile(bodycustomerPO);
            WorkflowExpression.Validate(__workflow_bodycustomerPO, nameof(bodycustomerPO), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodydiscountAmount = bodydiscountAmount == null ? null : WorkflowExpression.Compile(bodydiscountAmount);
            WorkflowExpression.Validate(__workflow_bodydiscountAmount, nameof(bodydiscountAmount), required: false);
            var __workflow_bodydisplayedTerms = bodydisplayedTerms == null ? null : WorkflowExpression.Compile(bodydisplayedTerms);
            WorkflowExpression.Validate(__workflow_bodydisplayedTerms, nameof(bodydisplayedTerms), required: false);
            var __workflow_bodydropShip = bodydropShip == null ? null : WorkflowExpression.Compile(bodydropShip);
            WorkflowExpression.Validate(__workflow_bodydropShip, nameof(bodydropShip), required: false);
            var __workflow_bodygUID = bodygUID == null ? null : WorkflowExpression.Compile(bodygUID);
            WorkflowExpression.Validate(__workflow_bodygUID, nameof(bodygUID), required: false);
            var __workflow_bodynotePrintsAfterLineItems = bodynotePrintsAfterLineItems == null ? null : WorkflowExpression.Compile(bodynotePrintsAfterLineItems);
            WorkflowExpression.Validate(__workflow_bodynotePrintsAfterLineItems, nameof(bodynotePrintsAfterLineItems), required: false);
            var __workflow_bodyproposal = bodyproposal == null ? null : WorkflowExpression.Compile(bodyproposal);
            WorkflowExpression.Validate(__workflow_bodyproposal, nameof(bodyproposal), required: false);
            var __workflow_bodyproposalAccepted = bodyproposalAccepted == null ? null : WorkflowExpression.Compile(bodyproposalAccepted);
            WorkflowExpression.Validate(__workflow_bodyproposalAccepted, nameof(bodyproposalAccepted), required: false);
            var __workflow_bodysalesOrderLineItem = bodysalesOrderLineItem == null ? null : WorkflowExpression.Compile(bodysalesOrderLineItem);
            WorkflowExpression.Validate(__workflow_bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            var __workflow_bodysalesOrderNumber = bodysalesOrderNumber == null ? null : WorkflowExpression.Compile(bodysalesOrderNumber);
            WorkflowExpression.Validate(__workflow_bodysalesOrderNumber, nameof(bodysalesOrderNumber), required: false);
            var __workflow_bodysalesRepresentativeGUID = bodysalesRepresentativeGUID == null ? null : WorkflowExpression.Compile(bodysalesRepresentativeGUID);
            WorkflowExpression.Validate(__workflow_bodysalesRepresentativeGUID, nameof(bodysalesRepresentativeGUID), required: false);
            var __workflow_bodysalesRepresentativeID = bodysalesRepresentativeID == null ? null : WorkflowExpression.Compile(bodysalesRepresentativeID);
            WorkflowExpression.Validate(__workflow_bodysalesRepresentativeID, nameof(bodysalesRepresentativeID), required: false);
            var __workflow_bodyshipAddressCity = bodyshipAddressCity == null ? null : WorkflowExpression.Compile(bodyshipAddressCity);
            WorkflowExpression.Validate(__workflow_bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            var __workflow_bodyshipAddressCountry = bodyshipAddressCountry == null ? null : WorkflowExpression.Compile(bodyshipAddressCountry);
            WorkflowExpression.Validate(__workflow_bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            var __workflow_bodyshipAddressLine1 = bodyshipAddressLine1 == null ? null : WorkflowExpression.Compile(bodyshipAddressLine1);
            WorkflowExpression.Validate(__workflow_bodyshipAddressLine1, nameof(bodyshipAddressLine1), required: false);
            var __workflow_bodyshipAddressLine2 = bodyshipAddressLine2 == null ? null : WorkflowExpression.Compile(bodyshipAddressLine2);
            WorkflowExpression.Validate(__workflow_bodyshipAddressLine2, nameof(bodyshipAddressLine2), required: false);
            var __workflow_bodyshipAddressName = bodyshipAddressName == null ? null : WorkflowExpression.Compile(bodyshipAddressName);
            WorkflowExpression.Validate(__workflow_bodyshipAddressName, nameof(bodyshipAddressName), required: false);
            var __workflow_bodyshipAddressState = bodyshipAddressState == null ? null : WorkflowExpression.Compile(bodyshipAddressState);
            WorkflowExpression.Validate(__workflow_bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            var __workflow_bodyshipAddressZipCode = bodyshipAddressZipCode == null ? null : WorkflowExpression.Compile(bodyshipAddressZipCode);
            WorkflowExpression.Validate(__workflow_bodyshipAddressZipCode, nameof(bodyshipAddressZipCode), required: false);
            var __workflow_bodyshipBy = bodyshipBy == null ? null : WorkflowExpression.Compile(bodyshipBy);
            WorkflowExpression.Validate(__workflow_bodyshipBy, nameof(bodyshipBy), required: false);
            var __workflow_bodyshipVIA = bodyshipVIA == null ? null : WorkflowExpression.Compile(bodyshipVIA);
            WorkflowExpression.Validate(__workflow_bodyshipVIA, nameof(bodyshipVIA), required: false);
            var __workflow_bodystatementNotePrintsBeforeInvRef = bodystatementNotePrintsBeforeInvRef == null ? null : WorkflowExpression.Compile(bodystatementNotePrintsBeforeInvRef);
            WorkflowExpression.Validate(__workflow_bodystatementNotePrintsBeforeInvRef, nameof(bodystatementNotePrintsBeforeInvRef), required: false);
            return new DeferredBodyAction<SAGE50USCreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/sage50us/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountsReceivableAccount != null)
                {
                    body["Accounts_Receivable_Account"] = ExpressionConverter.ConvertO(__workflow_bodyaccountsReceivableAccount);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountsReceivableAcctGUID != null)
                {
                    body["Accounts_Receivable_Acct_GUID"] = ExpressionConverter.ConvertO(__workflow_bodyaccountsReceivableAcctGUID);
                    bodypropCount++;
                }

                if (__workflow_bodyaccountsReceivableAmount != null)
                {
                    body["Accounts_Receivable_Amount"] = ExpressionConverter.ConvertO(__workflow_bodyaccountsReceivableAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyclosed != null)
                {
                    body["Closed"] = ExpressionConverter.ConvertO(__workflow_bodyclosed);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerID != null)
                {
                    body["Customer_ID"] = ExpressionConverter.ConvertO(__workflow_bodycustomerID);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerPO != null)
                {
                    body["Customer_PO"] = ExpressionConverter.ConvertO(__workflow_bodycustomerPO);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["Date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodydiscountAmount != null)
                {
                    body["Discount_Amount"] = ExpressionConverter.ConvertO(__workflow_bodydiscountAmount);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayedTerms != null)
                {
                    body["Displayed_Terms"] = ExpressionConverter.ConvertO(__workflow_bodydisplayedTerms);
                    bodypropCount++;
                }

                if (__workflow_bodydropShip != null)
                {
                    body["Drop_Ship"] = ExpressionConverter.ConvertO(__workflow_bodydropShip);
                    bodypropCount++;
                }

                if (__workflow_bodygUID != null)
                {
                    body["GUID"] = ExpressionConverter.ConvertO(__workflow_bodygUID);
                    bodypropCount++;
                }

                if (__workflow_bodynotePrintsAfterLineItems != null)
                {
                    body["Note_Prints_After_Line_Items"] = ExpressionConverter.ConvertO(__workflow_bodynotePrintsAfterLineItems);
                    bodypropCount++;
                }

                if (__workflow_bodyproposal != null)
                {
                    body["Proposal"] = ExpressionConverter.ConvertO(__workflow_bodyproposal);
                    bodypropCount++;
                }

                if (__workflow_bodyproposalAccepted != null)
                {
                    body["ProposalAccepted"] = ExpressionConverter.ConvertO(__workflow_bodyproposalAccepted);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderNumber != null)
                {
                    body["Sales_Order_Number"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysalesRepresentativeGUID != null)
                {
                    body["Sales_Representative_GUID"] = ExpressionConverter.ConvertO(__workflow_bodysalesRepresentativeGUID);
                    bodypropCount++;
                }

                if (__workflow_bodysalesRepresentativeID != null)
                {
                    body["Sales_Representative_ID"] = ExpressionConverter.ConvertO(__workflow_bodysalesRepresentativeID);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressCity != null)
                {
                    body["ShipAddressCity"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressCountry != null)
                {
                    body["ShipAddressCountry"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressLine1 != null)
                {
                    body["ShipAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressLine2 != null)
                {
                    body["ShipAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressName != null)
                {
                    body["ShipAddressName"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressName);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressState != null)
                {
                    body["ShipAddressState"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressState);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressZipCode != null)
                {
                    body["ShipAddressZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipBy != null)
                {
                    body["Ship_By"] = ExpressionConverter.ConvertO(__workflow_bodyshipBy);
                    bodypropCount++;
                }

                if (__workflow_bodyshipVIA != null)
                {
                    body["Ship_VIA"] = ExpressionConverter.ConvertO(__workflow_bodyshipVIA);
                    bodypropCount++;
                }

                if (__workflow_bodystatementNotePrintsBeforeInvRef != null)
                {
                    body["Statement_Note_Prints_Before_Inv_Ref"] = ExpressionConverter.ConvertO(__workflow_bodystatementNotePrintsBeforeInvRef);
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
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> SAPB1CreateNewCustomer(Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodybillingAddressName = null, Expression<Func<string>> bodybillingBlock = null, Expression<Func<string>> bodybillingCity = null, Expression<Func<string>> bodybillingCountry = null, Expression<Func<string>> bodybillingState = null, Expression<Func<string>> bodybillingStreet = null, Expression<Func<string>> bodybillingZipCode = null, Expression<Func<string>> bodycardCode = null, Expression<Func<string>> bodycardName = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycontactPerson = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycounty = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodyemailAddress = null, Expression<Func<string>> bodyextraField = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyfederalTaxID = null, Expression<Func<string>> bodyfreeText = null, Expression<Func<int>> bodygroupCode = null, Expression<Func<string>> bodymailAddress = null, Expression<Func<string>> bodymailCity = null, Expression<Func<string>> bodymailCountry = null, Expression<Func<string>> bodymailCounty = null, Expression<Func<string>> bodymailZipCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyphone1 = null, Expression<Func<string>> bodyphone2 = null, Expression<Func<int>> bodysalesPersonCode = null, Expression<Func<int>> bodyseries = null, Expression<Func<string>> bodyshippingAddressName = null, Expression<Func<string>> bodyshippingBlock = null, Expression<Func<string>> bodyshippingCity = null, Expression<Func<string>> bodyshippingCountry = null, Expression<Func<string>> bodyshippingState = null, Expression<Func<string>> bodyshippingStreet = null, Expression<Func<string>> bodyshippingZipCode = null, Expression<Func<string>> bodywebSite = null, Expression<Func<string>> bodyzipCode = null, Expression<Func<bodylstContactEmployeesInputItem[]>> bodylstContactEmployees = null)
        {
            var __workflow_bodyaddress = bodyaddress == null ? null : WorkflowExpression.Compile(bodyaddress);
            WorkflowExpression.Validate(__workflow_bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodybillingAddressName = bodybillingAddressName == null ? null : WorkflowExpression.Compile(bodybillingAddressName);
            WorkflowExpression.Validate(__workflow_bodybillingAddressName, nameof(bodybillingAddressName), required: false);
            var __workflow_bodybillingBlock = bodybillingBlock == null ? null : WorkflowExpression.Compile(bodybillingBlock);
            WorkflowExpression.Validate(__workflow_bodybillingBlock, nameof(bodybillingBlock), required: false);
            var __workflow_bodybillingCity = bodybillingCity == null ? null : WorkflowExpression.Compile(bodybillingCity);
            WorkflowExpression.Validate(__workflow_bodybillingCity, nameof(bodybillingCity), required: false);
            var __workflow_bodybillingCountry = bodybillingCountry == null ? null : WorkflowExpression.Compile(bodybillingCountry);
            WorkflowExpression.Validate(__workflow_bodybillingCountry, nameof(bodybillingCountry), required: false);
            var __workflow_bodybillingState = bodybillingState == null ? null : WorkflowExpression.Compile(bodybillingState);
            WorkflowExpression.Validate(__workflow_bodybillingState, nameof(bodybillingState), required: false);
            var __workflow_bodybillingStreet = bodybillingStreet == null ? null : WorkflowExpression.Compile(bodybillingStreet);
            WorkflowExpression.Validate(__workflow_bodybillingStreet, nameof(bodybillingStreet), required: false);
            var __workflow_bodybillingZipCode = bodybillingZipCode == null ? null : WorkflowExpression.Compile(bodybillingZipCode);
            WorkflowExpression.Validate(__workflow_bodybillingZipCode, nameof(bodybillingZipCode), required: false);
            var __workflow_bodycardCode = bodycardCode == null ? null : WorkflowExpression.Compile(bodycardCode);
            WorkflowExpression.Validate(__workflow_bodycardCode, nameof(bodycardCode), required: false);
            var __workflow_bodycardName = bodycardName == null ? null : WorkflowExpression.Compile(bodycardName);
            WorkflowExpression.Validate(__workflow_bodycardName, nameof(bodycardName), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycontactPerson = bodycontactPerson == null ? null : WorkflowExpression.Compile(bodycontactPerson);
            WorkflowExpression.Validate(__workflow_bodycontactPerson, nameof(bodycontactPerson), required: false);
            var __workflow_bodycountry = bodycountry == null ? null : WorkflowExpression.Compile(bodycountry);
            WorkflowExpression.Validate(__workflow_bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycounty = bodycounty == null ? null : WorkflowExpression.Compile(bodycounty);
            WorkflowExpression.Validate(__workflow_bodycounty, nameof(bodycounty), required: false);
            var __workflow_bodycurrency = bodycurrency == null ? null : WorkflowExpression.Compile(bodycurrency);
            WorkflowExpression.Validate(__workflow_bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodyemailAddress = bodyemailAddress == null ? null : WorkflowExpression.Compile(bodyemailAddress);
            WorkflowExpression.Validate(__workflow_bodyemailAddress, nameof(bodyemailAddress), required: false);
            var __workflow_bodyextraField = bodyextraField == null ? null : WorkflowExpression.Compile(bodyextraField);
            WorkflowExpression.Validate(__workflow_bodyextraField, nameof(bodyextraField), required: false);
            var __workflow_bodyfax = bodyfax == null ? null : WorkflowExpression.Compile(bodyfax);
            WorkflowExpression.Validate(__workflow_bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodyfederalTaxID = bodyfederalTaxID == null ? null : WorkflowExpression.Compile(bodyfederalTaxID);
            WorkflowExpression.Validate(__workflow_bodyfederalTaxID, nameof(bodyfederalTaxID), required: false);
            var __workflow_bodyfreeText = bodyfreeText == null ? null : WorkflowExpression.Compile(bodyfreeText);
            WorkflowExpression.Validate(__workflow_bodyfreeText, nameof(bodyfreeText), required: false);
            var __workflow_bodygroupCode = bodygroupCode == null ? null : WorkflowExpression.Compile(bodygroupCode);
            WorkflowExpression.Validate(__workflow_bodygroupCode, nameof(bodygroupCode), required: false);
            var __workflow_bodymailAddress = bodymailAddress == null ? null : WorkflowExpression.Compile(bodymailAddress);
            WorkflowExpression.Validate(__workflow_bodymailAddress, nameof(bodymailAddress), required: false);
            var __workflow_bodymailCity = bodymailCity == null ? null : WorkflowExpression.Compile(bodymailCity);
            WorkflowExpression.Validate(__workflow_bodymailCity, nameof(bodymailCity), required: false);
            var __workflow_bodymailCountry = bodymailCountry == null ? null : WorkflowExpression.Compile(bodymailCountry);
            WorkflowExpression.Validate(__workflow_bodymailCountry, nameof(bodymailCountry), required: false);
            var __workflow_bodymailCounty = bodymailCounty == null ? null : WorkflowExpression.Compile(bodymailCounty);
            WorkflowExpression.Validate(__workflow_bodymailCounty, nameof(bodymailCounty), required: false);
            var __workflow_bodymailZipCode = bodymailZipCode == null ? null : WorkflowExpression.Compile(bodymailZipCode);
            WorkflowExpression.Validate(__workflow_bodymailZipCode, nameof(bodymailZipCode), required: false);
            var __workflow_bodynotes = bodynotes == null ? null : WorkflowExpression.Compile(bodynotes);
            WorkflowExpression.Validate(__workflow_bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyphone1 = bodyphone1 == null ? null : WorkflowExpression.Compile(bodyphone1);
            WorkflowExpression.Validate(__workflow_bodyphone1, nameof(bodyphone1), required: false);
            var __workflow_bodyphone2 = bodyphone2 == null ? null : WorkflowExpression.Compile(bodyphone2);
            WorkflowExpression.Validate(__workflow_bodyphone2, nameof(bodyphone2), required: false);
            var __workflow_bodysalesPersonCode = bodysalesPersonCode == null ? null : WorkflowExpression.Compile(bodysalesPersonCode);
            WorkflowExpression.Validate(__workflow_bodysalesPersonCode, nameof(bodysalesPersonCode), required: false);
            var __workflow_bodyseries = bodyseries == null ? null : WorkflowExpression.Compile(bodyseries);
            WorkflowExpression.Validate(__workflow_bodyseries, nameof(bodyseries), required: false);
            var __workflow_bodyshippingAddressName = bodyshippingAddressName == null ? null : WorkflowExpression.Compile(bodyshippingAddressName);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressName, nameof(bodyshippingAddressName), required: false);
            var __workflow_bodyshippingBlock = bodyshippingBlock == null ? null : WorkflowExpression.Compile(bodyshippingBlock);
            WorkflowExpression.Validate(__workflow_bodyshippingBlock, nameof(bodyshippingBlock), required: false);
            var __workflow_bodyshippingCity = bodyshippingCity == null ? null : WorkflowExpression.Compile(bodyshippingCity);
            WorkflowExpression.Validate(__workflow_bodyshippingCity, nameof(bodyshippingCity), required: false);
            var __workflow_bodyshippingCountry = bodyshippingCountry == null ? null : WorkflowExpression.Compile(bodyshippingCountry);
            WorkflowExpression.Validate(__workflow_bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            var __workflow_bodyshippingState = bodyshippingState == null ? null : WorkflowExpression.Compile(bodyshippingState);
            WorkflowExpression.Validate(__workflow_bodyshippingState, nameof(bodyshippingState), required: false);
            var __workflow_bodyshippingStreet = bodyshippingStreet == null ? null : WorkflowExpression.Compile(bodyshippingStreet);
            WorkflowExpression.Validate(__workflow_bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            var __workflow_bodyshippingZipCode = bodyshippingZipCode == null ? null : WorkflowExpression.Compile(bodyshippingZipCode);
            WorkflowExpression.Validate(__workflow_bodyshippingZipCode, nameof(bodyshippingZipCode), required: false);
            var __workflow_bodywebSite = bodywebSite == null ? null : WorkflowExpression.Compile(bodywebSite);
            WorkflowExpression.Validate(__workflow_bodywebSite, nameof(bodywebSite), required: false);
            var __workflow_bodyzipCode = bodyzipCode == null ? null : WorkflowExpression.Compile(bodyzipCode);
            WorkflowExpression.Validate(__workflow_bodyzipCode, nameof(bodyzipCode), required: false);
            var __workflow_bodylstContactEmployees = bodylstContactEmployees == null ? null : WorkflowExpression.Compile(bodylstContactEmployees);
            WorkflowExpression.Validate(__workflow_bodylstContactEmployees, nameof(bodylstContactEmployees), required: false);
            return new DeferredBodyAction<SAPB1CreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/sapb1/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddress != null)
                {
                    body["Address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodybillingAddressName != null)
                {
                    body["BillingAddressName"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressName);
                    bodypropCount++;
                }

                if (__workflow_bodybillingBlock != null)
                {
                    body["BillingBlock"] = ExpressionConverter.ConvertO(__workflow_bodybillingBlock);
                    bodypropCount++;
                }

                if (__workflow_bodybillingCity != null)
                {
                    body["BillingCity"] = ExpressionConverter.ConvertO(__workflow_bodybillingCity);
                    bodypropCount++;
                }

                if (__workflow_bodybillingCountry != null)
                {
                    body["BillingCountry"] = ExpressionConverter.ConvertO(__workflow_bodybillingCountry);
                    bodypropCount++;
                }

                if (__workflow_bodybillingState != null)
                {
                    body["BillingState"] = ExpressionConverter.ConvertO(__workflow_bodybillingState);
                    bodypropCount++;
                }

                if (__workflow_bodybillingStreet != null)
                {
                    body["BillingStreet"] = ExpressionConverter.ConvertO(__workflow_bodybillingStreet);
                    bodypropCount++;
                }

                if (__workflow_bodybillingZipCode != null)
                {
                    body["BillingZipCode"] = ExpressionConverter.ConvertO(__workflow_bodybillingZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodycardCode != null)
                {
                    body["CardCode"] = ExpressionConverter.ConvertO(__workflow_bodycardCode);
                    bodypropCount++;
                }

                if (__workflow_bodycardName != null)
                {
                    body["CardName"] = ExpressionConverter.ConvertO(__workflow_bodycardName);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPerson != null)
                {
                    body["ContactPerson"] = ExpressionConverter.ConvertO(__workflow_bodycontactPerson);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["Country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodycounty != null)
                {
                    body["County"] = ExpressionConverter.ConvertO(__workflow_bodycounty);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    body["Currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                if (__workflow_bodyemailAddress != null)
                {
                    body["EmailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyemailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodyextraField != null)
                {
                    body["ExtraField"] = ExpressionConverter.ConvertO(__workflow_bodyextraField);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["Fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodyfederalTaxID != null)
                {
                    body["FederalTaxID"] = ExpressionConverter.ConvertO(__workflow_bodyfederalTaxID);
                    bodypropCount++;
                }

                if (__workflow_bodyfreeText != null)
                {
                    body["FreeText"] = ExpressionConverter.ConvertO(__workflow_bodyfreeText);
                    bodypropCount++;
                }

                if (__workflow_bodygroupCode != null)
                {
                    body["GroupCode"] = ExpressionConverter.ConvertO(__workflow_bodygroupCode);
                    bodypropCount++;
                }

                if (__workflow_bodymailAddress != null)
                {
                    body["MailAddress"] = ExpressionConverter.ConvertO(__workflow_bodymailAddress);
                    bodypropCount++;
                }

                if (__workflow_bodymailCity != null)
                {
                    body["MailCity"] = ExpressionConverter.ConvertO(__workflow_bodymailCity);
                    bodypropCount++;
                }

                if (__workflow_bodymailCountry != null)
                {
                    body["MailCountry"] = ExpressionConverter.ConvertO(__workflow_bodymailCountry);
                    bodypropCount++;
                }

                if (__workflow_bodymailCounty != null)
                {
                    body["MailCounty"] = ExpressionConverter.ConvertO(__workflow_bodymailCounty);
                    bodypropCount++;
                }

                if (__workflow_bodymailZipCode != null)
                {
                    body["MailZipCode"] = ExpressionConverter.ConvertO(__workflow_bodymailZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["Notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyphone1 != null)
                {
                    body["Phone1"] = ExpressionConverter.ConvertO(__workflow_bodyphone1);
                    bodypropCount++;
                }

                if (__workflow_bodyphone2 != null)
                {
                    body["Phone2"] = ExpressionConverter.ConvertO(__workflow_bodyphone2);
                    bodypropCount++;
                }

                if (__workflow_bodysalesPersonCode != null)
                {
                    body["SalesPersonCode"] = ExpressionConverter.ConvertO(__workflow_bodysalesPersonCode);
                    bodypropCount++;
                }

                if (__workflow_bodyseries != null)
                {
                    body["Series"] = ExpressionConverter.ConvertO(__workflow_bodyseries);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingAddressName != null)
                {
                    body["ShippingAddressName"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressName);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingBlock != null)
                {
                    body["ShippingBlock"] = ExpressionConverter.ConvertO(__workflow_bodyshippingBlock);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCity != null)
                {
                    body["ShippingCity"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCity);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCountry != null)
                {
                    body["ShippingCountry"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCountry);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingState != null)
                {
                    body["ShippingState"] = ExpressionConverter.ConvertO(__workflow_bodyshippingState);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingStreet != null)
                {
                    body["ShippingStreet"] = ExpressionConverter.ConvertO(__workflow_bodyshippingStreet);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingZipCode != null)
                {
                    body["ShippingZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyshippingZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodywebSite != null)
                {
                    body["WebSite"] = ExpressionConverter.ConvertO(__workflow_bodywebSite);
                    bodypropCount++;
                }

                if (__workflow_bodyzipCode != null)
                {
                    body["ZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyzipCode);
                    bodypropCount++;
                }

                if (__workflow_bodylstContactEmployees != null)
                {
                    body["lstContactEmployees"] = ExpressionConverter.ConvertO(__workflow_bodylstContactEmployees);
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
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> SAPB1CreateNewSalesOrder(Expression<Func<string>> bodycardCode = null, Expression<Func<string>> bodydocDate = null, Expression<Func<string>> bodydocDueDate = null, Expression<Func<int>> bodydocNum = null, Expression<Func<bodysalesOrderLineItemInputItem22222[]>> bodysalesOrderLineItem = null, Expression<Func<int>> bodyseries = null, Expression<Func<string>> bodytaxDate = null)
        {
            var __workflow_bodycardCode = bodycardCode == null ? null : WorkflowExpression.Compile(bodycardCode);
            WorkflowExpression.Validate(__workflow_bodycardCode, nameof(bodycardCode), required: false);
            var __workflow_bodydocDate = bodydocDate == null ? null : WorkflowExpression.Compile(bodydocDate);
            WorkflowExpression.Validate(__workflow_bodydocDate, nameof(bodydocDate), required: false);
            var __workflow_bodydocDueDate = bodydocDueDate == null ? null : WorkflowExpression.Compile(bodydocDueDate);
            WorkflowExpression.Validate(__workflow_bodydocDueDate, nameof(bodydocDueDate), required: false);
            var __workflow_bodydocNum = bodydocNum == null ? null : WorkflowExpression.Compile(bodydocNum);
            WorkflowExpression.Validate(__workflow_bodydocNum, nameof(bodydocNum), required: false);
            var __workflow_bodysalesOrderLineItem = bodysalesOrderLineItem == null ? null : WorkflowExpression.Compile(bodysalesOrderLineItem);
            WorkflowExpression.Validate(__workflow_bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            var __workflow_bodyseries = bodyseries == null ? null : WorkflowExpression.Compile(bodyseries);
            WorkflowExpression.Validate(__workflow_bodyseries, nameof(bodyseries), required: false);
            var __workflow_bodytaxDate = bodytaxDate == null ? null : WorkflowExpression.Compile(bodytaxDate);
            WorkflowExpression.Validate(__workflow_bodytaxDate, nameof(bodytaxDate), required: false);
            return new DeferredBodyAction<SAPB1CreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/sapb1/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycardCode != null)
                {
                    body["CardCode"] = ExpressionConverter.ConvertO(__workflow_bodycardCode);
                    bodypropCount++;
                }

                if (__workflow_bodydocDate != null)
                {
                    body["DocDate"] = ExpressionConverter.ConvertO(__workflow_bodydocDate);
                    bodypropCount++;
                }

                if (__workflow_bodydocDueDate != null)
                {
                    body["DocDueDate"] = ExpressionConverter.ConvertO(__workflow_bodydocDueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydocNum != null)
                {
                    body["DocNum"] = ExpressionConverter.ConvertO(__workflow_bodydocNum);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (__workflow_bodyseries != null)
                {
                    body["Series"] = ExpressionConverter.ConvertO(__workflow_bodyseries);
                    bodypropCount++;
                }

                if (__workflow_bodytaxDate != null)
                {
                    body["TaxDate"] = ExpressionConverter.ConvertO(__workflow_bodytaxDate);
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
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> SYSPROCreateNewCustomer(Expression<Func<string>> bodyaddTelephone = null, Expression<Func<string>> bodyaltMethodFlag = null, Expression<Func<string>> bodyapplyLineDisc = null, Expression<Func<string>> bodyapplyOrdDisc = null, Expression<Func<string>> bodyarStatementNo = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodybackOrdReqd = null, Expression<Func<string>> bodybalanceType = null, Expression<Func<string>> bodybranch = null, Expression<Func<string>> bodybuyingGroup1 = null, Expression<Func<string>> bodybuyingGroup2 = null, Expression<Func<string>> bodybuyingGroup3 = null, Expression<Func<string>> bodybuyingGroup4 = null, Expression<Func<string>> bodybuyingGroup5 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycity1 = null, Expression<Func<string>> bodycompanyTaxNumber = null, Expression<Func<string>> bodycontact = null, Expression<Func<string>> bodycontractPrcReqd = null, Expression<Func<string>> bodycounterSlsOnly = null, Expression<Func<string>> bodycountyZip = null, Expression<Func<string>> bodycountyZip1 = null, Expression<Func<string>> bodycreditCheckFlag = null, Expression<Func<string>> bodycreditLimit = null, Expression<Func<string>> bodycreditStatus = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodycustomerClass = null, Expression<Func<string>> bodycustomerCode = null, Expression<Func<string>> bodycustomerOnHold = null, Expression<Func<string>> bodydateCustAdded = null, Expression<Func<string>> bodydefaultOrdType = null, Expression<Func<string>> bodydeliveryTerms = null, Expression<Func<string>> bodydeliveryTermsC = null, Expression<Func<string>> bodydetailMoveReqd = null, Expression<Func<string>> bodydocFax = null, Expression<Func<string>> bodydocFaxContact = null, Expression<Func<string>> bodyediFlag = null, Expression<Func<string>> bodyediSenderCode = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyexemptFinChg = null, Expression<Func<string>> bodyfax = null, Expression<Func<string>> bodyfaxInvoices = null, Expression<Func<string>> bodyfaxQuotes = null, Expression<Func<string>> bodyfaxStatements = null, Expression<Func<string>> bodygstExemptFlag = null, Expression<Func<string>> bodygstExemptNum = null, Expression<Func<string>> bodygstLevel = null, Expression<Func<string>> bodyhighInv = null, Expression<Func<string>> bodyhighInvDays = null, Expression<Func<string>> bodyhighestBalance = null, Expression<Func<string>> bodyibtCustomer = null, Expression<Func<string>> bodyinvCommentCode = null, Expression<Func<string>> bodyinvDiscCode = null, Expression<Func<string>> bodylanguageCode = null, Expression<Func<string>> bodylineDiscCode = null, Expression<Func<string>> bodymaintHistory = null, Expression<Func<string>> bodymaintLastPrcPaid = null, Expression<Func<string>> bodyminimumOrderChgCod = null, Expression<Func<string>> bodyminimumOrderValue = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodynewCustomerCode = null, Expression<Func<string>> bodypoNumberMandatory = null, Expression<Func<string>> bodypriceCategoryTable = null, Expression<Func<string>> bodypriceCode = null, Expression<Func<string>> bodyrouteCode = null, Expression<Func<string>> bodyrouteDistance = null, Expression<Func<string>> bodysalesWarehouse = null, Expression<Func<string>> bodysalesperson = null, Expression<Func<string>> bodysalesperson1 = null, Expression<Func<string>> bodysalesperson2 = null, Expression<Func<string>> bodysalesperson3 = null, Expression<Func<string>> bodyshipPostalCode = null, Expression<Func<string>> bodyshipToAddr1 = null, Expression<Func<string>> bodyshipToAddr2 = null, Expression<Func<string>> bodyshipToAddr3 = null, Expression<Func<string>> bodyshipToAddr3Loc = null, Expression<Func<string>> bodyshipToAddr4 = null, Expression<Func<string>> bodyshipToAddr5 = null, Expression<Func<string>> bodyshipToGpsLat = null, Expression<Func<string>> bodyshipToGpsLong = null, Expression<Func<string>> bodyshippingInstrs = null, Expression<Func<string>> bodyshippingInstrsCod = null, Expression<Func<string>> bodyshippingLocation = null, Expression<Func<string>> bodyshortName = null, Expression<Func<string>> bodysoDefaultDoc = null, Expression<Func<string>> bodysoDefaultType = null, Expression<Func<string>> bodysoldPostalCode = null, Expression<Func<string>> bodysoldToAddr1 = null, Expression<Func<string>> bodysoldToAddr2 = null, Expression<Func<string>> bodysoldToAddr3 = null, Expression<Func<string>> bodysoldToAddr3Loc = null, Expression<Func<string>> bodysoldToAddr4 = null, Expression<Func<string>> bodysoldToAddr5 = null, Expression<Func<string>> bodysoldToGpsLat = null, Expression<Func<string>> bodysoldToGpsLong = null, Expression<Func<string>> bodyspecialInstrs = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodystate1 = null, Expression<Func<string>> bodystateCode = null, Expression<Func<string>> bodystatementReqd = null, Expression<Func<string>> bodystockInterchange = null, Expression<Func<string>> bodytagsToDropFromXML = null, Expression<Func<string>> bodytaxExemptNumber = null, Expression<Func<string>> bodytaxStatus = null, Expression<Func<string>> bodytelephone = null, Expression<Func<string>> bodytelephoneExtn = null, Expression<Func<string>> bodytelex = null, Expression<Func<string>> bodytermsCode = null, Expression<Func<string>> bodytpmCreditCheck = null, Expression<Func<string>> bodytpmCustomerFlag = null, Expression<Func<string>> bodytpmPricingFlag = null, Expression<Func<string>> bodytransactionNature = null, Expression<Func<string>> bodytransactionNatureC = null, Expression<Func<string>> bodyukCurrency = null, Expression<Func<string>> bodyukVatFlag = null, Expression<Func<string>> bodyuserField1 = null, Expression<Func<string>> bodyuserField2 = null, Expression<Func<string>> bodywholeOrderShipFlag = null, Expression<Func<string>> bodyeSignature = null)
        {
            var __workflow_bodyaddTelephone = bodyaddTelephone == null ? null : WorkflowExpression.Compile(bodyaddTelephone);
            WorkflowExpression.Validate(__workflow_bodyaddTelephone, nameof(bodyaddTelephone), required: false);
            var __workflow_bodyaltMethodFlag = bodyaltMethodFlag == null ? null : WorkflowExpression.Compile(bodyaltMethodFlag);
            WorkflowExpression.Validate(__workflow_bodyaltMethodFlag, nameof(bodyaltMethodFlag), required: false);
            var __workflow_bodyapplyLineDisc = bodyapplyLineDisc == null ? null : WorkflowExpression.Compile(bodyapplyLineDisc);
            WorkflowExpression.Validate(__workflow_bodyapplyLineDisc, nameof(bodyapplyLineDisc), required: false);
            var __workflow_bodyapplyOrdDisc = bodyapplyOrdDisc == null ? null : WorkflowExpression.Compile(bodyapplyOrdDisc);
            WorkflowExpression.Validate(__workflow_bodyapplyOrdDisc, nameof(bodyapplyOrdDisc), required: false);
            var __workflow_bodyarStatementNo = bodyarStatementNo == null ? null : WorkflowExpression.Compile(bodyarStatementNo);
            WorkflowExpression.Validate(__workflow_bodyarStatementNo, nameof(bodyarStatementNo), required: false);
            var __workflow_bodyarea = bodyarea == null ? null : WorkflowExpression.Compile(bodyarea);
            WorkflowExpression.Validate(__workflow_bodyarea, nameof(bodyarea), required: false);
            var __workflow_bodybackOrdReqd = bodybackOrdReqd == null ? null : WorkflowExpression.Compile(bodybackOrdReqd);
            WorkflowExpression.Validate(__workflow_bodybackOrdReqd, nameof(bodybackOrdReqd), required: false);
            var __workflow_bodybalanceType = bodybalanceType == null ? null : WorkflowExpression.Compile(bodybalanceType);
            WorkflowExpression.Validate(__workflow_bodybalanceType, nameof(bodybalanceType), required: false);
            var __workflow_bodybranch = bodybranch == null ? null : WorkflowExpression.Compile(bodybranch);
            WorkflowExpression.Validate(__workflow_bodybranch, nameof(bodybranch), required: false);
            var __workflow_bodybuyingGroup1 = bodybuyingGroup1 == null ? null : WorkflowExpression.Compile(bodybuyingGroup1);
            WorkflowExpression.Validate(__workflow_bodybuyingGroup1, nameof(bodybuyingGroup1), required: false);
            var __workflow_bodybuyingGroup2 = bodybuyingGroup2 == null ? null : WorkflowExpression.Compile(bodybuyingGroup2);
            WorkflowExpression.Validate(__workflow_bodybuyingGroup2, nameof(bodybuyingGroup2), required: false);
            var __workflow_bodybuyingGroup3 = bodybuyingGroup3 == null ? null : WorkflowExpression.Compile(bodybuyingGroup3);
            WorkflowExpression.Validate(__workflow_bodybuyingGroup3, nameof(bodybuyingGroup3), required: false);
            var __workflow_bodybuyingGroup4 = bodybuyingGroup4 == null ? null : WorkflowExpression.Compile(bodybuyingGroup4);
            WorkflowExpression.Validate(__workflow_bodybuyingGroup4, nameof(bodybuyingGroup4), required: false);
            var __workflow_bodybuyingGroup5 = bodybuyingGroup5 == null ? null : WorkflowExpression.Compile(bodybuyingGroup5);
            WorkflowExpression.Validate(__workflow_bodybuyingGroup5, nameof(bodybuyingGroup5), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycity1 = bodycity1 == null ? null : WorkflowExpression.Compile(bodycity1);
            WorkflowExpression.Validate(__workflow_bodycity1, nameof(bodycity1), required: false);
            var __workflow_bodycompanyTaxNumber = bodycompanyTaxNumber == null ? null : WorkflowExpression.Compile(bodycompanyTaxNumber);
            WorkflowExpression.Validate(__workflow_bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            var __workflow_bodycontact = bodycontact == null ? null : WorkflowExpression.Compile(bodycontact);
            WorkflowExpression.Validate(__workflow_bodycontact, nameof(bodycontact), required: false);
            var __workflow_bodycontractPrcReqd = bodycontractPrcReqd == null ? null : WorkflowExpression.Compile(bodycontractPrcReqd);
            WorkflowExpression.Validate(__workflow_bodycontractPrcReqd, nameof(bodycontractPrcReqd), required: false);
            var __workflow_bodycounterSlsOnly = bodycounterSlsOnly == null ? null : WorkflowExpression.Compile(bodycounterSlsOnly);
            WorkflowExpression.Validate(__workflow_bodycounterSlsOnly, nameof(bodycounterSlsOnly), required: false);
            var __workflow_bodycountyZip = bodycountyZip == null ? null : WorkflowExpression.Compile(bodycountyZip);
            WorkflowExpression.Validate(__workflow_bodycountyZip, nameof(bodycountyZip), required: false);
            var __workflow_bodycountyZip1 = bodycountyZip1 == null ? null : WorkflowExpression.Compile(bodycountyZip1);
            WorkflowExpression.Validate(__workflow_bodycountyZip1, nameof(bodycountyZip1), required: false);
            var __workflow_bodycreditCheckFlag = bodycreditCheckFlag == null ? null : WorkflowExpression.Compile(bodycreditCheckFlag);
            WorkflowExpression.Validate(__workflow_bodycreditCheckFlag, nameof(bodycreditCheckFlag), required: false);
            var __workflow_bodycreditLimit = bodycreditLimit == null ? null : WorkflowExpression.Compile(bodycreditLimit);
            WorkflowExpression.Validate(__workflow_bodycreditLimit, nameof(bodycreditLimit), required: false);
            var __workflow_bodycreditStatus = bodycreditStatus == null ? null : WorkflowExpression.Compile(bodycreditStatus);
            WorkflowExpression.Validate(__workflow_bodycreditStatus, nameof(bodycreditStatus), required: false);
            var __workflow_bodycurrency = bodycurrency == null ? null : WorkflowExpression.Compile(bodycurrency);
            WorkflowExpression.Validate(__workflow_bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodycustomerClass = bodycustomerClass == null ? null : WorkflowExpression.Compile(bodycustomerClass);
            WorkflowExpression.Validate(__workflow_bodycustomerClass, nameof(bodycustomerClass), required: false);
            var __workflow_bodycustomerCode = bodycustomerCode == null ? null : WorkflowExpression.Compile(bodycustomerCode);
            WorkflowExpression.Validate(__workflow_bodycustomerCode, nameof(bodycustomerCode), required: false);
            var __workflow_bodycustomerOnHold = bodycustomerOnHold == null ? null : WorkflowExpression.Compile(bodycustomerOnHold);
            WorkflowExpression.Validate(__workflow_bodycustomerOnHold, nameof(bodycustomerOnHold), required: false);
            var __workflow_bodydateCustAdded = bodydateCustAdded == null ? null : WorkflowExpression.Compile(bodydateCustAdded);
            WorkflowExpression.Validate(__workflow_bodydateCustAdded, nameof(bodydateCustAdded), required: false);
            var __workflow_bodydefaultOrdType = bodydefaultOrdType == null ? null : WorkflowExpression.Compile(bodydefaultOrdType);
            WorkflowExpression.Validate(__workflow_bodydefaultOrdType, nameof(bodydefaultOrdType), required: false);
            var __workflow_bodydeliveryTerms = bodydeliveryTerms == null ? null : WorkflowExpression.Compile(bodydeliveryTerms);
            WorkflowExpression.Validate(__workflow_bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            var __workflow_bodydeliveryTermsC = bodydeliveryTermsC == null ? null : WorkflowExpression.Compile(bodydeliveryTermsC);
            WorkflowExpression.Validate(__workflow_bodydeliveryTermsC, nameof(bodydeliveryTermsC), required: false);
            var __workflow_bodydetailMoveReqd = bodydetailMoveReqd == null ? null : WorkflowExpression.Compile(bodydetailMoveReqd);
            WorkflowExpression.Validate(__workflow_bodydetailMoveReqd, nameof(bodydetailMoveReqd), required: false);
            var __workflow_bodydocFax = bodydocFax == null ? null : WorkflowExpression.Compile(bodydocFax);
            WorkflowExpression.Validate(__workflow_bodydocFax, nameof(bodydocFax), required: false);
            var __workflow_bodydocFaxContact = bodydocFaxContact == null ? null : WorkflowExpression.Compile(bodydocFaxContact);
            WorkflowExpression.Validate(__workflow_bodydocFaxContact, nameof(bodydocFaxContact), required: false);
            var __workflow_bodyediFlag = bodyediFlag == null ? null : WorkflowExpression.Compile(bodyediFlag);
            WorkflowExpression.Validate(__workflow_bodyediFlag, nameof(bodyediFlag), required: false);
            var __workflow_bodyediSenderCode = bodyediSenderCode == null ? null : WorkflowExpression.Compile(bodyediSenderCode);
            WorkflowExpression.Validate(__workflow_bodyediSenderCode, nameof(bodyediSenderCode), required: false);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyexemptFinChg = bodyexemptFinChg == null ? null : WorkflowExpression.Compile(bodyexemptFinChg);
            WorkflowExpression.Validate(__workflow_bodyexemptFinChg, nameof(bodyexemptFinChg), required: false);
            var __workflow_bodyfax = bodyfax == null ? null : WorkflowExpression.Compile(bodyfax);
            WorkflowExpression.Validate(__workflow_bodyfax, nameof(bodyfax), required: false);
            var __workflow_bodyfaxInvoices = bodyfaxInvoices == null ? null : WorkflowExpression.Compile(bodyfaxInvoices);
            WorkflowExpression.Validate(__workflow_bodyfaxInvoices, nameof(bodyfaxInvoices), required: false);
            var __workflow_bodyfaxQuotes = bodyfaxQuotes == null ? null : WorkflowExpression.Compile(bodyfaxQuotes);
            WorkflowExpression.Validate(__workflow_bodyfaxQuotes, nameof(bodyfaxQuotes), required: false);
            var __workflow_bodyfaxStatements = bodyfaxStatements == null ? null : WorkflowExpression.Compile(bodyfaxStatements);
            WorkflowExpression.Validate(__workflow_bodyfaxStatements, nameof(bodyfaxStatements), required: false);
            var __workflow_bodygstExemptFlag = bodygstExemptFlag == null ? null : WorkflowExpression.Compile(bodygstExemptFlag);
            WorkflowExpression.Validate(__workflow_bodygstExemptFlag, nameof(bodygstExemptFlag), required: false);
            var __workflow_bodygstExemptNum = bodygstExemptNum == null ? null : WorkflowExpression.Compile(bodygstExemptNum);
            WorkflowExpression.Validate(__workflow_bodygstExemptNum, nameof(bodygstExemptNum), required: false);
            var __workflow_bodygstLevel = bodygstLevel == null ? null : WorkflowExpression.Compile(bodygstLevel);
            WorkflowExpression.Validate(__workflow_bodygstLevel, nameof(bodygstLevel), required: false);
            var __workflow_bodyhighInv = bodyhighInv == null ? null : WorkflowExpression.Compile(bodyhighInv);
            WorkflowExpression.Validate(__workflow_bodyhighInv, nameof(bodyhighInv), required: false);
            var __workflow_bodyhighInvDays = bodyhighInvDays == null ? null : WorkflowExpression.Compile(bodyhighInvDays);
            WorkflowExpression.Validate(__workflow_bodyhighInvDays, nameof(bodyhighInvDays), required: false);
            var __workflow_bodyhighestBalance = bodyhighestBalance == null ? null : WorkflowExpression.Compile(bodyhighestBalance);
            WorkflowExpression.Validate(__workflow_bodyhighestBalance, nameof(bodyhighestBalance), required: false);
            var __workflow_bodyibtCustomer = bodyibtCustomer == null ? null : WorkflowExpression.Compile(bodyibtCustomer);
            WorkflowExpression.Validate(__workflow_bodyibtCustomer, nameof(bodyibtCustomer), required: false);
            var __workflow_bodyinvCommentCode = bodyinvCommentCode == null ? null : WorkflowExpression.Compile(bodyinvCommentCode);
            WorkflowExpression.Validate(__workflow_bodyinvCommentCode, nameof(bodyinvCommentCode), required: false);
            var __workflow_bodyinvDiscCode = bodyinvDiscCode == null ? null : WorkflowExpression.Compile(bodyinvDiscCode);
            WorkflowExpression.Validate(__workflow_bodyinvDiscCode, nameof(bodyinvDiscCode), required: false);
            var __workflow_bodylanguageCode = bodylanguageCode == null ? null : WorkflowExpression.Compile(bodylanguageCode);
            WorkflowExpression.Validate(__workflow_bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodylineDiscCode = bodylineDiscCode == null ? null : WorkflowExpression.Compile(bodylineDiscCode);
            WorkflowExpression.Validate(__workflow_bodylineDiscCode, nameof(bodylineDiscCode), required: false);
            var __workflow_bodymaintHistory = bodymaintHistory == null ? null : WorkflowExpression.Compile(bodymaintHistory);
            WorkflowExpression.Validate(__workflow_bodymaintHistory, nameof(bodymaintHistory), required: false);
            var __workflow_bodymaintLastPrcPaid = bodymaintLastPrcPaid == null ? null : WorkflowExpression.Compile(bodymaintLastPrcPaid);
            WorkflowExpression.Validate(__workflow_bodymaintLastPrcPaid, nameof(bodymaintLastPrcPaid), required: false);
            var __workflow_bodyminimumOrderChgCod = bodyminimumOrderChgCod == null ? null : WorkflowExpression.Compile(bodyminimumOrderChgCod);
            WorkflowExpression.Validate(__workflow_bodyminimumOrderChgCod, nameof(bodyminimumOrderChgCod), required: false);
            var __workflow_bodyminimumOrderValue = bodyminimumOrderValue == null ? null : WorkflowExpression.Compile(bodyminimumOrderValue);
            WorkflowExpression.Validate(__workflow_bodyminimumOrderValue, nameof(bodyminimumOrderValue), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodynationality = bodynationality == null ? null : WorkflowExpression.Compile(bodynationality);
            WorkflowExpression.Validate(__workflow_bodynationality, nameof(bodynationality), required: false);
            var __workflow_bodynewCustomerCode = bodynewCustomerCode == null ? null : WorkflowExpression.Compile(bodynewCustomerCode);
            WorkflowExpression.Validate(__workflow_bodynewCustomerCode, nameof(bodynewCustomerCode), required: false);
            var __workflow_bodypoNumberMandatory = bodypoNumberMandatory == null ? null : WorkflowExpression.Compile(bodypoNumberMandatory);
            WorkflowExpression.Validate(__workflow_bodypoNumberMandatory, nameof(bodypoNumberMandatory), required: false);
            var __workflow_bodypriceCategoryTable = bodypriceCategoryTable == null ? null : WorkflowExpression.Compile(bodypriceCategoryTable);
            WorkflowExpression.Validate(__workflow_bodypriceCategoryTable, nameof(bodypriceCategoryTable), required: false);
            var __workflow_bodypriceCode = bodypriceCode == null ? null : WorkflowExpression.Compile(bodypriceCode);
            WorkflowExpression.Validate(__workflow_bodypriceCode, nameof(bodypriceCode), required: false);
            var __workflow_bodyrouteCode = bodyrouteCode == null ? null : WorkflowExpression.Compile(bodyrouteCode);
            WorkflowExpression.Validate(__workflow_bodyrouteCode, nameof(bodyrouteCode), required: false);
            var __workflow_bodyrouteDistance = bodyrouteDistance == null ? null : WorkflowExpression.Compile(bodyrouteDistance);
            WorkflowExpression.Validate(__workflow_bodyrouteDistance, nameof(bodyrouteDistance), required: false);
            var __workflow_bodysalesWarehouse = bodysalesWarehouse == null ? null : WorkflowExpression.Compile(bodysalesWarehouse);
            WorkflowExpression.Validate(__workflow_bodysalesWarehouse, nameof(bodysalesWarehouse), required: false);
            var __workflow_bodysalesperson = bodysalesperson == null ? null : WorkflowExpression.Compile(bodysalesperson);
            WorkflowExpression.Validate(__workflow_bodysalesperson, nameof(bodysalesperson), required: false);
            var __workflow_bodysalesperson1 = bodysalesperson1 == null ? null : WorkflowExpression.Compile(bodysalesperson1);
            WorkflowExpression.Validate(__workflow_bodysalesperson1, nameof(bodysalesperson1), required: false);
            var __workflow_bodysalesperson2 = bodysalesperson2 == null ? null : WorkflowExpression.Compile(bodysalesperson2);
            WorkflowExpression.Validate(__workflow_bodysalesperson2, nameof(bodysalesperson2), required: false);
            var __workflow_bodysalesperson3 = bodysalesperson3 == null ? null : WorkflowExpression.Compile(bodysalesperson3);
            WorkflowExpression.Validate(__workflow_bodysalesperson3, nameof(bodysalesperson3), required: false);
            var __workflow_bodyshipPostalCode = bodyshipPostalCode == null ? null : WorkflowExpression.Compile(bodyshipPostalCode);
            WorkflowExpression.Validate(__workflow_bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            var __workflow_bodyshipToAddr1 = bodyshipToAddr1 == null ? null : WorkflowExpression.Compile(bodyshipToAddr1);
            WorkflowExpression.Validate(__workflow_bodyshipToAddr1, nameof(bodyshipToAddr1), required: false);
            var __workflow_bodyshipToAddr2 = bodyshipToAddr2 == null ? null : WorkflowExpression.Compile(bodyshipToAddr2);
            WorkflowExpression.Validate(__workflow_bodyshipToAddr2, nameof(bodyshipToAddr2), required: false);
            var __workflow_bodyshipToAddr3 = bodyshipToAddr3 == null ? null : WorkflowExpression.Compile(bodyshipToAddr3);
            WorkflowExpression.Validate(__workflow_bodyshipToAddr3, nameof(bodyshipToAddr3), required: false);
            var __workflow_bodyshipToAddr3Loc = bodyshipToAddr3Loc == null ? null : WorkflowExpression.Compile(bodyshipToAddr3Loc);
            WorkflowExpression.Validate(__workflow_bodyshipToAddr3Loc, nameof(bodyshipToAddr3Loc), required: false);
            var __workflow_bodyshipToAddr4 = bodyshipToAddr4 == null ? null : WorkflowExpression.Compile(bodyshipToAddr4);
            WorkflowExpression.Validate(__workflow_bodyshipToAddr4, nameof(bodyshipToAddr4), required: false);
            var __workflow_bodyshipToAddr5 = bodyshipToAddr5 == null ? null : WorkflowExpression.Compile(bodyshipToAddr5);
            WorkflowExpression.Validate(__workflow_bodyshipToAddr5, nameof(bodyshipToAddr5), required: false);
            var __workflow_bodyshipToGpsLat = bodyshipToGpsLat == null ? null : WorkflowExpression.Compile(bodyshipToGpsLat);
            WorkflowExpression.Validate(__workflow_bodyshipToGpsLat, nameof(bodyshipToGpsLat), required: false);
            var __workflow_bodyshipToGpsLong = bodyshipToGpsLong == null ? null : WorkflowExpression.Compile(bodyshipToGpsLong);
            WorkflowExpression.Validate(__workflow_bodyshipToGpsLong, nameof(bodyshipToGpsLong), required: false);
            var __workflow_bodyshippingInstrs = bodyshippingInstrs == null ? null : WorkflowExpression.Compile(bodyshippingInstrs);
            WorkflowExpression.Validate(__workflow_bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            var __workflow_bodyshippingInstrsCod = bodyshippingInstrsCod == null ? null : WorkflowExpression.Compile(bodyshippingInstrsCod);
            WorkflowExpression.Validate(__workflow_bodyshippingInstrsCod, nameof(bodyshippingInstrsCod), required: false);
            var __workflow_bodyshippingLocation = bodyshippingLocation == null ? null : WorkflowExpression.Compile(bodyshippingLocation);
            WorkflowExpression.Validate(__workflow_bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            var __workflow_bodyshortName = bodyshortName == null ? null : WorkflowExpression.Compile(bodyshortName);
            WorkflowExpression.Validate(__workflow_bodyshortName, nameof(bodyshortName), required: false);
            var __workflow_bodysoDefaultDoc = bodysoDefaultDoc == null ? null : WorkflowExpression.Compile(bodysoDefaultDoc);
            WorkflowExpression.Validate(__workflow_bodysoDefaultDoc, nameof(bodysoDefaultDoc), required: false);
            var __workflow_bodysoDefaultType = bodysoDefaultType == null ? null : WorkflowExpression.Compile(bodysoDefaultType);
            WorkflowExpression.Validate(__workflow_bodysoDefaultType, nameof(bodysoDefaultType), required: false);
            var __workflow_bodysoldPostalCode = bodysoldPostalCode == null ? null : WorkflowExpression.Compile(bodysoldPostalCode);
            WorkflowExpression.Validate(__workflow_bodysoldPostalCode, nameof(bodysoldPostalCode), required: false);
            var __workflow_bodysoldToAddr1 = bodysoldToAddr1 == null ? null : WorkflowExpression.Compile(bodysoldToAddr1);
            WorkflowExpression.Validate(__workflow_bodysoldToAddr1, nameof(bodysoldToAddr1), required: false);
            var __workflow_bodysoldToAddr2 = bodysoldToAddr2 == null ? null : WorkflowExpression.Compile(bodysoldToAddr2);
            WorkflowExpression.Validate(__workflow_bodysoldToAddr2, nameof(bodysoldToAddr2), required: false);
            var __workflow_bodysoldToAddr3 = bodysoldToAddr3 == null ? null : WorkflowExpression.Compile(bodysoldToAddr3);
            WorkflowExpression.Validate(__workflow_bodysoldToAddr3, nameof(bodysoldToAddr3), required: false);
            var __workflow_bodysoldToAddr3Loc = bodysoldToAddr3Loc == null ? null : WorkflowExpression.Compile(bodysoldToAddr3Loc);
            WorkflowExpression.Validate(__workflow_bodysoldToAddr3Loc, nameof(bodysoldToAddr3Loc), required: false);
            var __workflow_bodysoldToAddr4 = bodysoldToAddr4 == null ? null : WorkflowExpression.Compile(bodysoldToAddr4);
            WorkflowExpression.Validate(__workflow_bodysoldToAddr4, nameof(bodysoldToAddr4), required: false);
            var __workflow_bodysoldToAddr5 = bodysoldToAddr5 == null ? null : WorkflowExpression.Compile(bodysoldToAddr5);
            WorkflowExpression.Validate(__workflow_bodysoldToAddr5, nameof(bodysoldToAddr5), required: false);
            var __workflow_bodysoldToGpsLat = bodysoldToGpsLat == null ? null : WorkflowExpression.Compile(bodysoldToGpsLat);
            WorkflowExpression.Validate(__workflow_bodysoldToGpsLat, nameof(bodysoldToGpsLat), required: false);
            var __workflow_bodysoldToGpsLong = bodysoldToGpsLong == null ? null : WorkflowExpression.Compile(bodysoldToGpsLong);
            WorkflowExpression.Validate(__workflow_bodysoldToGpsLong, nameof(bodysoldToGpsLong), required: false);
            var __workflow_bodyspecialInstrs = bodyspecialInstrs == null ? null : WorkflowExpression.Compile(bodyspecialInstrs);
            WorkflowExpression.Validate(__workflow_bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: false);
            var __workflow_bodystate1 = bodystate1 == null ? null : WorkflowExpression.Compile(bodystate1);
            WorkflowExpression.Validate(__workflow_bodystate1, nameof(bodystate1), required: false);
            var __workflow_bodystateCode = bodystateCode == null ? null : WorkflowExpression.Compile(bodystateCode);
            WorkflowExpression.Validate(__workflow_bodystateCode, nameof(bodystateCode), required: false);
            var __workflow_bodystatementReqd = bodystatementReqd == null ? null : WorkflowExpression.Compile(bodystatementReqd);
            WorkflowExpression.Validate(__workflow_bodystatementReqd, nameof(bodystatementReqd), required: false);
            var __workflow_bodystockInterchange = bodystockInterchange == null ? null : WorkflowExpression.Compile(bodystockInterchange);
            WorkflowExpression.Validate(__workflow_bodystockInterchange, nameof(bodystockInterchange), required: false);
            var __workflow_bodytagsToDropFromXML = bodytagsToDropFromXML == null ? null : WorkflowExpression.Compile(bodytagsToDropFromXML);
            WorkflowExpression.Validate(__workflow_bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            var __workflow_bodytaxExemptNumber = bodytaxExemptNumber == null ? null : WorkflowExpression.Compile(bodytaxExemptNumber);
            WorkflowExpression.Validate(__workflow_bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            var __workflow_bodytaxStatus = bodytaxStatus == null ? null : WorkflowExpression.Compile(bodytaxStatus);
            WorkflowExpression.Validate(__workflow_bodytaxStatus, nameof(bodytaxStatus), required: false);
            var __workflow_bodytelephone = bodytelephone == null ? null : WorkflowExpression.Compile(bodytelephone);
            WorkflowExpression.Validate(__workflow_bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodytelephoneExtn = bodytelephoneExtn == null ? null : WorkflowExpression.Compile(bodytelephoneExtn);
            WorkflowExpression.Validate(__workflow_bodytelephoneExtn, nameof(bodytelephoneExtn), required: false);
            var __workflow_bodytelex = bodytelex == null ? null : WorkflowExpression.Compile(bodytelex);
            WorkflowExpression.Validate(__workflow_bodytelex, nameof(bodytelex), required: false);
            var __workflow_bodytermsCode = bodytermsCode == null ? null : WorkflowExpression.Compile(bodytermsCode);
            WorkflowExpression.Validate(__workflow_bodytermsCode, nameof(bodytermsCode), required: false);
            var __workflow_bodytpmCreditCheck = bodytpmCreditCheck == null ? null : WorkflowExpression.Compile(bodytpmCreditCheck);
            WorkflowExpression.Validate(__workflow_bodytpmCreditCheck, nameof(bodytpmCreditCheck), required: false);
            var __workflow_bodytpmCustomerFlag = bodytpmCustomerFlag == null ? null : WorkflowExpression.Compile(bodytpmCustomerFlag);
            WorkflowExpression.Validate(__workflow_bodytpmCustomerFlag, nameof(bodytpmCustomerFlag), required: false);
            var __workflow_bodytpmPricingFlag = bodytpmPricingFlag == null ? null : WorkflowExpression.Compile(bodytpmPricingFlag);
            WorkflowExpression.Validate(__workflow_bodytpmPricingFlag, nameof(bodytpmPricingFlag), required: false);
            var __workflow_bodytransactionNature = bodytransactionNature == null ? null : WorkflowExpression.Compile(bodytransactionNature);
            WorkflowExpression.Validate(__workflow_bodytransactionNature, nameof(bodytransactionNature), required: false);
            var __workflow_bodytransactionNatureC = bodytransactionNatureC == null ? null : WorkflowExpression.Compile(bodytransactionNatureC);
            WorkflowExpression.Validate(__workflow_bodytransactionNatureC, nameof(bodytransactionNatureC), required: false);
            var __workflow_bodyukCurrency = bodyukCurrency == null ? null : WorkflowExpression.Compile(bodyukCurrency);
            WorkflowExpression.Validate(__workflow_bodyukCurrency, nameof(bodyukCurrency), required: false);
            var __workflow_bodyukVatFlag = bodyukVatFlag == null ? null : WorkflowExpression.Compile(bodyukVatFlag);
            WorkflowExpression.Validate(__workflow_bodyukVatFlag, nameof(bodyukVatFlag), required: false);
            var __workflow_bodyuserField1 = bodyuserField1 == null ? null : WorkflowExpression.Compile(bodyuserField1);
            WorkflowExpression.Validate(__workflow_bodyuserField1, nameof(bodyuserField1), required: false);
            var __workflow_bodyuserField2 = bodyuserField2 == null ? null : WorkflowExpression.Compile(bodyuserField2);
            WorkflowExpression.Validate(__workflow_bodyuserField2, nameof(bodyuserField2), required: false);
            var __workflow_bodywholeOrderShipFlag = bodywholeOrderShipFlag == null ? null : WorkflowExpression.Compile(bodywholeOrderShipFlag);
            WorkflowExpression.Validate(__workflow_bodywholeOrderShipFlag, nameof(bodywholeOrderShipFlag), required: false);
            var __workflow_bodyeSignature = bodyeSignature == null ? null : WorkflowExpression.Compile(bodyeSignature);
            WorkflowExpression.Validate(__workflow_bodyeSignature, nameof(bodyeSignature), required: false);
            return new DeferredBodyAction<SYSPROCreateNewCustomerResponse>(() =>
            {
                var apiCallPath = "/api/v1/syspro/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddTelephone != null)
                {
                    body["AddTelephone"] = ExpressionConverter.ConvertO(__workflow_bodyaddTelephone);
                    bodypropCount++;
                }

                if (__workflow_bodyaltMethodFlag != null)
                {
                    body["AltMethodFlag"] = ExpressionConverter.ConvertO(__workflow_bodyaltMethodFlag);
                    bodypropCount++;
                }

                if (__workflow_bodyapplyLineDisc != null)
                {
                    body["ApplyLineDisc"] = ExpressionConverter.ConvertO(__workflow_bodyapplyLineDisc);
                    bodypropCount++;
                }

                if (__workflow_bodyapplyOrdDisc != null)
                {
                    body["ApplyOrdDisc"] = ExpressionConverter.ConvertO(__workflow_bodyapplyOrdDisc);
                    bodypropCount++;
                }

                if (__workflow_bodyarStatementNo != null)
                {
                    body["ArStatementNo"] = ExpressionConverter.ConvertO(__workflow_bodyarStatementNo);
                    bodypropCount++;
                }

                if (__workflow_bodyarea != null)
                {
                    body["Area"] = ExpressionConverter.ConvertO(__workflow_bodyarea);
                    bodypropCount++;
                }

                if (__workflow_bodybackOrdReqd != null)
                {
                    body["BackOrdReqd"] = ExpressionConverter.ConvertO(__workflow_bodybackOrdReqd);
                    bodypropCount++;
                }

                if (__workflow_bodybalanceType != null)
                {
                    body["BalanceType"] = ExpressionConverter.ConvertO(__workflow_bodybalanceType);
                    bodypropCount++;
                }

                if (__workflow_bodybranch != null)
                {
                    body["Branch"] = ExpressionConverter.ConvertO(__workflow_bodybranch);
                    bodypropCount++;
                }

                if (__workflow_bodybuyingGroup1 != null)
                {
                    body["BuyingGroup1"] = ExpressionConverter.ConvertO(__workflow_bodybuyingGroup1);
                    bodypropCount++;
                }

                if (__workflow_bodybuyingGroup2 != null)
                {
                    body["BuyingGroup2"] = ExpressionConverter.ConvertO(__workflow_bodybuyingGroup2);
                    bodypropCount++;
                }

                if (__workflow_bodybuyingGroup3 != null)
                {
                    body["BuyingGroup3"] = ExpressionConverter.ConvertO(__workflow_bodybuyingGroup3);
                    bodypropCount++;
                }

                if (__workflow_bodybuyingGroup4 != null)
                {
                    body["BuyingGroup4"] = ExpressionConverter.ConvertO(__workflow_bodybuyingGroup4);
                    bodypropCount++;
                }

                if (__workflow_bodybuyingGroup5 != null)
                {
                    body["BuyingGroup5"] = ExpressionConverter.ConvertO(__workflow_bodybuyingGroup5);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycity1 != null)
                {
                    body["City1"] = ExpressionConverter.ConvertO(__workflow_bodycity1);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyTaxNumber != null)
                {
                    body["CompanyTaxNumber"] = ExpressionConverter.ConvertO(__workflow_bodycompanyTaxNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycontact != null)
                {
                    body["Contact"] = ExpressionConverter.ConvertO(__workflow_bodycontact);
                    bodypropCount++;
                }

                if (__workflow_bodycontractPrcReqd != null)
                {
                    body["ContractPrcReqd"] = ExpressionConverter.ConvertO(__workflow_bodycontractPrcReqd);
                    bodypropCount++;
                }

                if (__workflow_bodycounterSlsOnly != null)
                {
                    body["CounterSlsOnly"] = ExpressionConverter.ConvertO(__workflow_bodycounterSlsOnly);
                    bodypropCount++;
                }

                if (__workflow_bodycountyZip != null)
                {
                    body["CountyZip"] = ExpressionConverter.ConvertO(__workflow_bodycountyZip);
                    bodypropCount++;
                }

                if (__workflow_bodycountyZip1 != null)
                {
                    body["CountyZip1"] = ExpressionConverter.ConvertO(__workflow_bodycountyZip1);
                    bodypropCount++;
                }

                if (__workflow_bodycreditCheckFlag != null)
                {
                    body["CreditCheckFlag"] = ExpressionConverter.ConvertO(__workflow_bodycreditCheckFlag);
                    bodypropCount++;
                }

                if (__workflow_bodycreditLimit != null)
                {
                    body["CreditLimit"] = ExpressionConverter.ConvertO(__workflow_bodycreditLimit);
                    bodypropCount++;
                }

                if (__workflow_bodycreditStatus != null)
                {
                    body["CreditStatus"] = ExpressionConverter.ConvertO(__workflow_bodycreditStatus);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    body["Currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerClass != null)
                {
                    body["CustomerClass"] = ExpressionConverter.ConvertO(__workflow_bodycustomerClass);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerCode != null)
                {
                    body["CustomerCode"] = ExpressionConverter.ConvertO(__workflow_bodycustomerCode);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerOnHold != null)
                {
                    body["CustomerOnHold"] = ExpressionConverter.ConvertO(__workflow_bodycustomerOnHold);
                    bodypropCount++;
                }

                if (__workflow_bodydateCustAdded != null)
                {
                    body["DateCustAdded"] = ExpressionConverter.ConvertO(__workflow_bodydateCustAdded);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultOrdType != null)
                {
                    body["DefaultOrdType"] = ExpressionConverter.ConvertO(__workflow_bodydefaultOrdType);
                    bodypropCount++;
                }

                if (__workflow_bodydeliveryTerms != null)
                {
                    body["DeliveryTerms"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryTerms);
                    bodypropCount++;
                }

                if (__workflow_bodydeliveryTermsC != null)
                {
                    body["DeliveryTermsC"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryTermsC);
                    bodypropCount++;
                }

                if (__workflow_bodydetailMoveReqd != null)
                {
                    body["DetailMoveReqd"] = ExpressionConverter.ConvertO(__workflow_bodydetailMoveReqd);
                    bodypropCount++;
                }

                if (__workflow_bodydocFax != null)
                {
                    body["DocFax"] = ExpressionConverter.ConvertO(__workflow_bodydocFax);
                    bodypropCount++;
                }

                if (__workflow_bodydocFaxContact != null)
                {
                    body["DocFaxContact"] = ExpressionConverter.ConvertO(__workflow_bodydocFaxContact);
                    bodypropCount++;
                }

                if (__workflow_bodyediFlag != null)
                {
                    body["EdiFlag"] = ExpressionConverter.ConvertO(__workflow_bodyediFlag);
                    bodypropCount++;
                }

                if (__workflow_bodyediSenderCode != null)
                {
                    body["EdiSenderCode"] = ExpressionConverter.ConvertO(__workflow_bodyediSenderCode);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyexemptFinChg != null)
                {
                    body["ExemptFinChg"] = ExpressionConverter.ConvertO(__workflow_bodyexemptFinChg);
                    bodypropCount++;
                }

                if (__workflow_bodyfax != null)
                {
                    body["Fax"] = ExpressionConverter.ConvertO(__workflow_bodyfax);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxInvoices != null)
                {
                    body["FaxInvoices"] = ExpressionConverter.ConvertO(__workflow_bodyfaxInvoices);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxQuotes != null)
                {
                    body["FaxQuotes"] = ExpressionConverter.ConvertO(__workflow_bodyfaxQuotes);
                    bodypropCount++;
                }

                if (__workflow_bodyfaxStatements != null)
                {
                    body["FaxStatements"] = ExpressionConverter.ConvertO(__workflow_bodyfaxStatements);
                    bodypropCount++;
                }

                if (__workflow_bodygstExemptFlag != null)
                {
                    body["GstExemptFlag"] = ExpressionConverter.ConvertO(__workflow_bodygstExemptFlag);
                    bodypropCount++;
                }

                if (__workflow_bodygstExemptNum != null)
                {
                    body["GstExemptNum"] = ExpressionConverter.ConvertO(__workflow_bodygstExemptNum);
                    bodypropCount++;
                }

                if (__workflow_bodygstLevel != null)
                {
                    body["GstLevel"] = ExpressionConverter.ConvertO(__workflow_bodygstLevel);
                    bodypropCount++;
                }

                if (__workflow_bodyhighInv != null)
                {
                    body["HighInv"] = ExpressionConverter.ConvertO(__workflow_bodyhighInv);
                    bodypropCount++;
                }

                if (__workflow_bodyhighInvDays != null)
                {
                    body["HighInvDays"] = ExpressionConverter.ConvertO(__workflow_bodyhighInvDays);
                    bodypropCount++;
                }

                if (__workflow_bodyhighestBalance != null)
                {
                    body["HighestBalance"] = ExpressionConverter.ConvertO(__workflow_bodyhighestBalance);
                    bodypropCount++;
                }

                if (__workflow_bodyibtCustomer != null)
                {
                    body["IbtCustomer"] = ExpressionConverter.ConvertO(__workflow_bodyibtCustomer);
                    bodypropCount++;
                }

                if (__workflow_bodyinvCommentCode != null)
                {
                    body["InvCommentCode"] = ExpressionConverter.ConvertO(__workflow_bodyinvCommentCode);
                    bodypropCount++;
                }

                if (__workflow_bodyinvDiscCode != null)
                {
                    body["InvDiscCode"] = ExpressionConverter.ConvertO(__workflow_bodyinvDiscCode);
                    bodypropCount++;
                }

                if (__workflow_bodylanguageCode != null)
                {
                    body["LanguageCode"] = ExpressionConverter.ConvertO(__workflow_bodylanguageCode);
                    bodypropCount++;
                }

                if (__workflow_bodylineDiscCode != null)
                {
                    body["LineDiscCode"] = ExpressionConverter.ConvertO(__workflow_bodylineDiscCode);
                    bodypropCount++;
                }

                if (__workflow_bodymaintHistory != null)
                {
                    body["MaintHistory"] = ExpressionConverter.ConvertO(__workflow_bodymaintHistory);
                    bodypropCount++;
                }

                if (__workflow_bodymaintLastPrcPaid != null)
                {
                    body["MaintLastPrcPaid"] = ExpressionConverter.ConvertO(__workflow_bodymaintLastPrcPaid);
                    bodypropCount++;
                }

                if (__workflow_bodyminimumOrderChgCod != null)
                {
                    body["MinimumOrderChgCod"] = ExpressionConverter.ConvertO(__workflow_bodyminimumOrderChgCod);
                    bodypropCount++;
                }

                if (__workflow_bodyminimumOrderValue != null)
                {
                    body["MinimumOrderValue"] = ExpressionConverter.ConvertO(__workflow_bodyminimumOrderValue);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodynationality != null)
                {
                    body["Nationality"] = ExpressionConverter.ConvertO(__workflow_bodynationality);
                    bodypropCount++;
                }

                if (__workflow_bodynewCustomerCode != null)
                {
                    body["NewCustomerCode"] = ExpressionConverter.ConvertO(__workflow_bodynewCustomerCode);
                    bodypropCount++;
                }

                if (__workflow_bodypoNumberMandatory != null)
                {
                    body["PoNumberMandatory"] = ExpressionConverter.ConvertO(__workflow_bodypoNumberMandatory);
                    bodypropCount++;
                }

                if (__workflow_bodypriceCategoryTable != null)
                {
                    body["PriceCategoryTable"] = ExpressionConverter.ConvertO(__workflow_bodypriceCategoryTable);
                    bodypropCount++;
                }

                if (__workflow_bodypriceCode != null)
                {
                    body["PriceCode"] = ExpressionConverter.ConvertO(__workflow_bodypriceCode);
                    bodypropCount++;
                }

                if (__workflow_bodyrouteCode != null)
                {
                    body["RouteCode"] = ExpressionConverter.ConvertO(__workflow_bodyrouteCode);
                    bodypropCount++;
                }

                if (__workflow_bodyrouteDistance != null)
                {
                    body["RouteDistance"] = ExpressionConverter.ConvertO(__workflow_bodyrouteDistance);
                    bodypropCount++;
                }

                if (__workflow_bodysalesWarehouse != null)
                {
                    body["SalesWarehouse"] = ExpressionConverter.ConvertO(__workflow_bodysalesWarehouse);
                    bodypropCount++;
                }

                if (__workflow_bodysalesperson != null)
                {
                    body["Salesperson"] = ExpressionConverter.ConvertO(__workflow_bodysalesperson);
                    bodypropCount++;
                }

                if (__workflow_bodysalesperson1 != null)
                {
                    body["Salesperson1"] = ExpressionConverter.ConvertO(__workflow_bodysalesperson1);
                    bodypropCount++;
                }

                if (__workflow_bodysalesperson2 != null)
                {
                    body["Salesperson2"] = ExpressionConverter.ConvertO(__workflow_bodysalesperson2);
                    bodypropCount++;
                }

                if (__workflow_bodysalesperson3 != null)
                {
                    body["Salesperson3"] = ExpressionConverter.ConvertO(__workflow_bodysalesperson3);
                    bodypropCount++;
                }

                if (__workflow_bodyshipPostalCode != null)
                {
                    body["ShipPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddr1 != null)
                {
                    body["ShipToAddr1"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddr1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddr2 != null)
                {
                    body["ShipToAddr2"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddr2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddr3 != null)
                {
                    body["ShipToAddr3"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddr3);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddr3Loc != null)
                {
                    body["ShipToAddr3Loc"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddr3Loc);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddr4 != null)
                {
                    body["ShipToAddr4"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddr4);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToAddr5 != null)
                {
                    body["ShipToAddr5"] = ExpressionConverter.ConvertO(__workflow_bodyshipToAddr5);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToGpsLat != null)
                {
                    body["ShipToGpsLat"] = ExpressionConverter.ConvertO(__workflow_bodyshipToGpsLat);
                    bodypropCount++;
                }

                if (__workflow_bodyshipToGpsLong != null)
                {
                    body["ShipToGpsLong"] = ExpressionConverter.ConvertO(__workflow_bodyshipToGpsLong);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingInstrs != null)
                {
                    body["ShippingInstrs"] = ExpressionConverter.ConvertO(__workflow_bodyshippingInstrs);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingInstrsCod != null)
                {
                    body["ShippingInstrsCod"] = ExpressionConverter.ConvertO(__workflow_bodyshippingInstrsCod);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingLocation != null)
                {
                    body["ShippingLocation"] = ExpressionConverter.ConvertO(__workflow_bodyshippingLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyshortName != null)
                {
                    body["ShortName"] = ExpressionConverter.ConvertO(__workflow_bodyshortName);
                    bodypropCount++;
                }

                if (__workflow_bodysoDefaultDoc != null)
                {
                    body["SoDefaultDoc"] = ExpressionConverter.ConvertO(__workflow_bodysoDefaultDoc);
                    bodypropCount++;
                }

                if (__workflow_bodysoDefaultType != null)
                {
                    body["SoDefaultType"] = ExpressionConverter.ConvertO(__workflow_bodysoDefaultType);
                    bodypropCount++;
                }

                if (__workflow_bodysoldPostalCode != null)
                {
                    body["SoldPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodysoldPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToAddr1 != null)
                {
                    body["SoldToAddr1"] = ExpressionConverter.ConvertO(__workflow_bodysoldToAddr1);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToAddr2 != null)
                {
                    body["SoldToAddr2"] = ExpressionConverter.ConvertO(__workflow_bodysoldToAddr2);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToAddr3 != null)
                {
                    body["SoldToAddr3"] = ExpressionConverter.ConvertO(__workflow_bodysoldToAddr3);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToAddr3Loc != null)
                {
                    body["SoldToAddr3Loc"] = ExpressionConverter.ConvertO(__workflow_bodysoldToAddr3Loc);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToAddr4 != null)
                {
                    body["SoldToAddr4"] = ExpressionConverter.ConvertO(__workflow_bodysoldToAddr4);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToAddr5 != null)
                {
                    body["SoldToAddr5"] = ExpressionConverter.ConvertO(__workflow_bodysoldToAddr5);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToGpsLat != null)
                {
                    body["SoldToGpsLat"] = ExpressionConverter.ConvertO(__workflow_bodysoldToGpsLat);
                    bodypropCount++;
                }

                if (__workflow_bodysoldToGpsLong != null)
                {
                    body["SoldToGpsLong"] = ExpressionConverter.ConvertO(__workflow_bodysoldToGpsLong);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialInstrs != null)
                {
                    body["SpecialInstrs"] = ExpressionConverter.ConvertO(__workflow_bodyspecialInstrs);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["State"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodystate1 != null)
                {
                    body["State1"] = ExpressionConverter.ConvertO(__workflow_bodystate1);
                    bodypropCount++;
                }

                if (__workflow_bodystateCode != null)
                {
                    body["StateCode"] = ExpressionConverter.ConvertO(__workflow_bodystateCode);
                    bodypropCount++;
                }

                if (__workflow_bodystatementReqd != null)
                {
                    body["StatementReqd"] = ExpressionConverter.ConvertO(__workflow_bodystatementReqd);
                    bodypropCount++;
                }

                if (__workflow_bodystockInterchange != null)
                {
                    body["StockInterchange"] = ExpressionConverter.ConvertO(__workflow_bodystockInterchange);
                    bodypropCount++;
                }

                if (__workflow_bodytagsToDropFromXML != null)
                {
                    body["TagsToDropFromXML"] = ExpressionConverter.ConvertO(__workflow_bodytagsToDropFromXML);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptNumber != null)
                {
                    body["TaxExemptNumber"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptNumber);
                    bodypropCount++;
                }

                if (__workflow_bodytaxStatus != null)
                {
                    body["TaxStatus"] = ExpressionConverter.ConvertO(__workflow_bodytaxStatus);
                    bodypropCount++;
                }

                if (__workflow_bodytelephone != null)
                {
                    body["Telephone"] = ExpressionConverter.ConvertO(__workflow_bodytelephone);
                    bodypropCount++;
                }

                if (__workflow_bodytelephoneExtn != null)
                {
                    body["TelephoneExtn"] = ExpressionConverter.ConvertO(__workflow_bodytelephoneExtn);
                    bodypropCount++;
                }

                if (__workflow_bodytelex != null)
                {
                    body["Telex"] = ExpressionConverter.ConvertO(__workflow_bodytelex);
                    bodypropCount++;
                }

                if (__workflow_bodytermsCode != null)
                {
                    body["TermsCode"] = ExpressionConverter.ConvertO(__workflow_bodytermsCode);
                    bodypropCount++;
                }

                if (__workflow_bodytpmCreditCheck != null)
                {
                    body["TpmCreditCheck"] = ExpressionConverter.ConvertO(__workflow_bodytpmCreditCheck);
                    bodypropCount++;
                }

                if (__workflow_bodytpmCustomerFlag != null)
                {
                    body["TpmCustomerFlag"] = ExpressionConverter.ConvertO(__workflow_bodytpmCustomerFlag);
                    bodypropCount++;
                }

                if (__workflow_bodytpmPricingFlag != null)
                {
                    body["TpmPricingFlag"] = ExpressionConverter.ConvertO(__workflow_bodytpmPricingFlag);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionNature != null)
                {
                    body["TransactionNature"] = ExpressionConverter.ConvertO(__workflow_bodytransactionNature);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionNatureC != null)
                {
                    body["TransactionNatureC"] = ExpressionConverter.ConvertO(__workflow_bodytransactionNatureC);
                    bodypropCount++;
                }

                if (__workflow_bodyukCurrency != null)
                {
                    body["UkCurrency"] = ExpressionConverter.ConvertO(__workflow_bodyukCurrency);
                    bodypropCount++;
                }

                if (__workflow_bodyukVatFlag != null)
                {
                    body["UkVatFlag"] = ExpressionConverter.ConvertO(__workflow_bodyukVatFlag);
                    bodypropCount++;
                }

                if (__workflow_bodyuserField1 != null)
                {
                    body["UserField1"] = ExpressionConverter.ConvertO(__workflow_bodyuserField1);
                    bodypropCount++;
                }

                if (__workflow_bodyuserField2 != null)
                {
                    body["UserField2"] = ExpressionConverter.ConvertO(__workflow_bodyuserField2);
                    bodypropCount++;
                }

                if (__workflow_bodywholeOrderShipFlag != null)
                {
                    body["WholeOrderShipFlag"] = ExpressionConverter.ConvertO(__workflow_bodywholeOrderShipFlag);
                    bodypropCount++;
                }

                if (__workflow_bodyeSignature != null)
                {
                    body["eSignature"] = ExpressionConverter.ConvertO(__workflow_bodyeSignature);
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
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> SYSPROCreateNewSalesOrder(Expression<Func<string>> bodyacceptEarlierShipDate = null, Expression<Func<string>> bodyacceptKitOptional = null, Expression<Func<string>> bodyacceptOrdersIfNoCredit = null, Expression<Func<string>> bodyaddAttachedServiceCharges = null, Expression<Func<string>> bodyaddDangerousGoodsText = null, Expression<Func<string>> bodyaddStockSalesOrderText = null, Expression<Func<string>> bodyallocationAction = null, Expression<Func<string>> bodyallowBackOrderForNegativeMerchLine = null, Expression<Func<string>> bodyallowBackOrderForPartialHold = null, Expression<Func<string>> bodyallowBackOrderForSuperseded = null, Expression<Func<string>> bodyallowChangeToZeroPrice = null, Expression<Func<string>> bodyallowDuplicateOrderNumbers = null, Expression<Func<string>> bodyallowManualOrderNumberToBeUsed = null, Expression<Func<string>> bodyallowNonStockItems = null, Expression<Func<string>> bodyallowZeroPrice = null, Expression<Func<string>> bodyalternateReference = null, Expression<Func<string>> bodyalwaysUsePriceEntered = null, Expression<Func<string>> bodyapplyLeadTimeCalculation = null, Expression<Func<string>> bodyapplyParentDiscountToComponents = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodybranch = null, Expression<Func<string>> bodycancelReasonCode = null, Expression<Func<string>> bodycheckForCustomerPoNumbers = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycompanyTaxNumber = null, Expression<Func<string>> bodycountyZip = null, Expression<Func<string>> bodycreditFailMessage = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodycustomer = null, Expression<Func<string>> bodycustomerName = null, Expression<Func<string>> bodycustomerPoNumber = null, Expression<Func<string>> bodycustomerToUse = null, Expression<Func<string>> bodydeliveryRoute = null, Expression<Func<string>> bodydeliveryRouteAction = null, Expression<Func<string>> bodydeliveryTerms = null, Expression<Func<string>> bodydocumentFormat = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyglobalTradePromotionCodes = null, Expression<Func<string>> bodygstExemptNumber = null, Expression<Func<string>> bodygstExemptionStatus = null, Expression<Func<string>> bodyheaderFreightCharges = null, Expression<Func<string>> bodyheaderMiscCharges = null, Expression<Func<string>> bodyignoreWarnings = null, Expression<Func<string>> bodyinBoxMsgReqd = null, Expression<Func<string>> bodyincludeInMrp = null, Expression<Func<string>> bodyinvoiceDateEntered = null, Expression<Func<string>> bodyinvoiceNumberEntered = null, Expression<Func<string>> bodyinvoiceTerms = null, Expression<Func<string>> bodyinvoiceWholeOrderOnly = null, Expression<Func<string>> bodylanguageCode = null, Expression<Func<string>> bodyminimumDaysToShip = null, Expression<Func<string>> bodymultiShipCode = null, Expression<Func<string>> bodynationality = null, Expression<Func<string>> bodynewCustomerPoNumber = null, Expression<Func<string>> bodynewSalesOrderNumber = null, Expression<Func<string>> bodyoperatorToInform = null, Expression<Func<string>> bodyorderActionType = null, Expression<Func<string>> bodyorderComments = null, Expression<Func<string>> bodyorderDate = null, Expression<Func<string>> bodyorderDiscPercent1 = null, Expression<Func<string>> bodyorderDiscPercent2 = null, Expression<Func<string>> bodyorderDiscPercent3 = null, Expression<Func<string>> bodyorderStatus = null, Expression<Func<string>> bodyorderType = null, Expression<Func<string>> bodyoverrideCustomerBackOrder = null, Expression<Func<string>> bodypOSSalesOrder = null, Expression<Func<string>> bodyprocess = null, Expression<Func<string>> bodyprocessFlag = null, Expression<Func<string>> bodyputEntireQuantityOnNewLoadWhenChanged = null, Expression<Func<string>> bodyreceiverCode = null, Expression<Func<string>> bodyrequestedShipDate = null, Expression<Func<string>> bodyreserveStock = null, Expression<Func<string>> bodyreserveStockRequestAllocs = null, Expression<Func<string>> bodysalesOrder = null, Expression<Func<bodysalesOrderDetailsInputItem[]>> bodysalesOrderDetails = null, Expression<Func<bodysalesOrderFooterCommentsInputItem[]>> bodysalesOrderFooterComments = null, Expression<Func<bodysalesOrderFreightDetailsInputItem[]>> bodysalesOrderFreightDetails = null, Expression<Func<bodysalesOrderHeaderCommentsInputItem[]>> bodysalesOrderHeaderComments = null, Expression<Func<bodysalesOrderMiscChargesDetailsInputItem[]>> bodysalesOrderMiscChargesDetails = null, Expression<Func<string>> bodysalesOrderPromoQualifyAction = null, Expression<Func<string>> bodysalesOrderPromoSelectAction = null, Expression<Func<string>> bodysalesperson = null, Expression<Func<string>> bodysenderCode = null, Expression<Func<string>> bodyshipAddress1 = null, Expression<Func<string>> bodyshipAddress2 = null, Expression<Func<string>> bodyshipAddress3 = null, Expression<Func<string>> bodyshipAddress3Locality = null, Expression<Func<string>> bodyshipAddress4 = null, Expression<Func<string>> bodyshipAddress5 = null, Expression<Func<string>> bodyshipAddressPerLine = null, Expression<Func<string>> bodyshipAddressPerLineTax = null, Expression<Func<string>> bodyshipGpsLat = null, Expression<Func<string>> bodyshipGpsLong = null, Expression<Func<string>> bodyshipPostalCode = null, Expression<Func<string>> bodyshippingInstrs = null, Expression<Func<string>> bodyshippingInstrsCode = null, Expression<Func<string>> bodyshippingLocation = null, Expression<Func<string>> bodyspecialInstrs = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodystatusInProcess = null, Expression<Func<string>> bodystatusInProcessResponse = null, Expression<Func<string>> bodysupplier = null, Expression<Func<string>> bodytagsToDropFromXML = null, Expression<Func<string>> bodytaxExemptNumber = null, Expression<Func<string>> bodytaxExemptionStatus = null, Expression<Func<string>> bodytransactionNature = null, Expression<Func<string>> bodytransmissionReference = null, Expression<Func<string>> bodytransportMode = null, Expression<Func<string>> bodytypeOfOrder = null, Expression<Func<string>> bodyuseCustomerSalesWarehouse = null, Expression<Func<string>> bodyuseMasterAccountForCustomerPartNo = null, Expression<Func<string>> bodyuseStockDescSupplied = null, Expression<Func<string>> bodyvalidateShippingInstrs = null, Expression<Func<string>> bodywarehouse = null, Expression<Func<string>> bodywarehouseListToUse = null, Expression<Func<string>> bodywarnIfCustomerOnHold = null, Expression<Func<string>> bodyeSignature = null)
        {
            var __workflow_bodyacceptEarlierShipDate = bodyacceptEarlierShipDate == null ? null : WorkflowExpression.Compile(bodyacceptEarlierShipDate);
            WorkflowExpression.Validate(__workflow_bodyacceptEarlierShipDate, nameof(bodyacceptEarlierShipDate), required: false);
            var __workflow_bodyacceptKitOptional = bodyacceptKitOptional == null ? null : WorkflowExpression.Compile(bodyacceptKitOptional);
            WorkflowExpression.Validate(__workflow_bodyacceptKitOptional, nameof(bodyacceptKitOptional), required: false);
            var __workflow_bodyacceptOrdersIfNoCredit = bodyacceptOrdersIfNoCredit == null ? null : WorkflowExpression.Compile(bodyacceptOrdersIfNoCredit);
            WorkflowExpression.Validate(__workflow_bodyacceptOrdersIfNoCredit, nameof(bodyacceptOrdersIfNoCredit), required: false);
            var __workflow_bodyaddAttachedServiceCharges = bodyaddAttachedServiceCharges == null ? null : WorkflowExpression.Compile(bodyaddAttachedServiceCharges);
            WorkflowExpression.Validate(__workflow_bodyaddAttachedServiceCharges, nameof(bodyaddAttachedServiceCharges), required: false);
            var __workflow_bodyaddDangerousGoodsText = bodyaddDangerousGoodsText == null ? null : WorkflowExpression.Compile(bodyaddDangerousGoodsText);
            WorkflowExpression.Validate(__workflow_bodyaddDangerousGoodsText, nameof(bodyaddDangerousGoodsText), required: false);
            var __workflow_bodyaddStockSalesOrderText = bodyaddStockSalesOrderText == null ? null : WorkflowExpression.Compile(bodyaddStockSalesOrderText);
            WorkflowExpression.Validate(__workflow_bodyaddStockSalesOrderText, nameof(bodyaddStockSalesOrderText), required: false);
            var __workflow_bodyallocationAction = bodyallocationAction == null ? null : WorkflowExpression.Compile(bodyallocationAction);
            WorkflowExpression.Validate(__workflow_bodyallocationAction, nameof(bodyallocationAction), required: false);
            var __workflow_bodyallowBackOrderForNegativeMerchLine = bodyallowBackOrderForNegativeMerchLine == null ? null : WorkflowExpression.Compile(bodyallowBackOrderForNegativeMerchLine);
            WorkflowExpression.Validate(__workflow_bodyallowBackOrderForNegativeMerchLine, nameof(bodyallowBackOrderForNegativeMerchLine), required: false);
            var __workflow_bodyallowBackOrderForPartialHold = bodyallowBackOrderForPartialHold == null ? null : WorkflowExpression.Compile(bodyallowBackOrderForPartialHold);
            WorkflowExpression.Validate(__workflow_bodyallowBackOrderForPartialHold, nameof(bodyallowBackOrderForPartialHold), required: false);
            var __workflow_bodyallowBackOrderForSuperseded = bodyallowBackOrderForSuperseded == null ? null : WorkflowExpression.Compile(bodyallowBackOrderForSuperseded);
            WorkflowExpression.Validate(__workflow_bodyallowBackOrderForSuperseded, nameof(bodyallowBackOrderForSuperseded), required: false);
            var __workflow_bodyallowChangeToZeroPrice = bodyallowChangeToZeroPrice == null ? null : WorkflowExpression.Compile(bodyallowChangeToZeroPrice);
            WorkflowExpression.Validate(__workflow_bodyallowChangeToZeroPrice, nameof(bodyallowChangeToZeroPrice), required: false);
            var __workflow_bodyallowDuplicateOrderNumbers = bodyallowDuplicateOrderNumbers == null ? null : WorkflowExpression.Compile(bodyallowDuplicateOrderNumbers);
            WorkflowExpression.Validate(__workflow_bodyallowDuplicateOrderNumbers, nameof(bodyallowDuplicateOrderNumbers), required: false);
            var __workflow_bodyallowManualOrderNumberToBeUsed = bodyallowManualOrderNumberToBeUsed == null ? null : WorkflowExpression.Compile(bodyallowManualOrderNumberToBeUsed);
            WorkflowExpression.Validate(__workflow_bodyallowManualOrderNumberToBeUsed, nameof(bodyallowManualOrderNumberToBeUsed), required: false);
            var __workflow_bodyallowNonStockItems = bodyallowNonStockItems == null ? null : WorkflowExpression.Compile(bodyallowNonStockItems);
            WorkflowExpression.Validate(__workflow_bodyallowNonStockItems, nameof(bodyallowNonStockItems), required: false);
            var __workflow_bodyallowZeroPrice = bodyallowZeroPrice == null ? null : WorkflowExpression.Compile(bodyallowZeroPrice);
            WorkflowExpression.Validate(__workflow_bodyallowZeroPrice, nameof(bodyallowZeroPrice), required: false);
            var __workflow_bodyalternateReference = bodyalternateReference == null ? null : WorkflowExpression.Compile(bodyalternateReference);
            WorkflowExpression.Validate(__workflow_bodyalternateReference, nameof(bodyalternateReference), required: false);
            var __workflow_bodyalwaysUsePriceEntered = bodyalwaysUsePriceEntered == null ? null : WorkflowExpression.Compile(bodyalwaysUsePriceEntered);
            WorkflowExpression.Validate(__workflow_bodyalwaysUsePriceEntered, nameof(bodyalwaysUsePriceEntered), required: false);
            var __workflow_bodyapplyLeadTimeCalculation = bodyapplyLeadTimeCalculation == null ? null : WorkflowExpression.Compile(bodyapplyLeadTimeCalculation);
            WorkflowExpression.Validate(__workflow_bodyapplyLeadTimeCalculation, nameof(bodyapplyLeadTimeCalculation), required: false);
            var __workflow_bodyapplyParentDiscountToComponents = bodyapplyParentDiscountToComponents == null ? null : WorkflowExpression.Compile(bodyapplyParentDiscountToComponents);
            WorkflowExpression.Validate(__workflow_bodyapplyParentDiscountToComponents, nameof(bodyapplyParentDiscountToComponents), required: false);
            var __workflow_bodyarea = bodyarea == null ? null : WorkflowExpression.Compile(bodyarea);
            WorkflowExpression.Validate(__workflow_bodyarea, nameof(bodyarea), required: false);
            var __workflow_bodybranch = bodybranch == null ? null : WorkflowExpression.Compile(bodybranch);
            WorkflowExpression.Validate(__workflow_bodybranch, nameof(bodybranch), required: false);
            var __workflow_bodycancelReasonCode = bodycancelReasonCode == null ? null : WorkflowExpression.Compile(bodycancelReasonCode);
            WorkflowExpression.Validate(__workflow_bodycancelReasonCode, nameof(bodycancelReasonCode), required: false);
            var __workflow_bodycheckForCustomerPoNumbers = bodycheckForCustomerPoNumbers == null ? null : WorkflowExpression.Compile(bodycheckForCustomerPoNumbers);
            WorkflowExpression.Validate(__workflow_bodycheckForCustomerPoNumbers, nameof(bodycheckForCustomerPoNumbers), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodycompanyTaxNumber = bodycompanyTaxNumber == null ? null : WorkflowExpression.Compile(bodycompanyTaxNumber);
            WorkflowExpression.Validate(__workflow_bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            var __workflow_bodycountyZip = bodycountyZip == null ? null : WorkflowExpression.Compile(bodycountyZip);
            WorkflowExpression.Validate(__workflow_bodycountyZip, nameof(bodycountyZip), required: false);
            var __workflow_bodycreditFailMessage = bodycreditFailMessage == null ? null : WorkflowExpression.Compile(bodycreditFailMessage);
            WorkflowExpression.Validate(__workflow_bodycreditFailMessage, nameof(bodycreditFailMessage), required: false);
            var __workflow_bodycurrency = bodycurrency == null ? null : WorkflowExpression.Compile(bodycurrency);
            WorkflowExpression.Validate(__workflow_bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodycustomer = bodycustomer == null ? null : WorkflowExpression.Compile(bodycustomer);
            WorkflowExpression.Validate(__workflow_bodycustomer, nameof(bodycustomer), required: false);
            var __workflow_bodycustomerName = bodycustomerName == null ? null : WorkflowExpression.Compile(bodycustomerName);
            WorkflowExpression.Validate(__workflow_bodycustomerName, nameof(bodycustomerName), required: false);
            var __workflow_bodycustomerPoNumber = bodycustomerPoNumber == null ? null : WorkflowExpression.Compile(bodycustomerPoNumber);
            WorkflowExpression.Validate(__workflow_bodycustomerPoNumber, nameof(bodycustomerPoNumber), required: false);
            var __workflow_bodycustomerToUse = bodycustomerToUse == null ? null : WorkflowExpression.Compile(bodycustomerToUse);
            WorkflowExpression.Validate(__workflow_bodycustomerToUse, nameof(bodycustomerToUse), required: false);
            var __workflow_bodydeliveryRoute = bodydeliveryRoute == null ? null : WorkflowExpression.Compile(bodydeliveryRoute);
            WorkflowExpression.Validate(__workflow_bodydeliveryRoute, nameof(bodydeliveryRoute), required: false);
            var __workflow_bodydeliveryRouteAction = bodydeliveryRouteAction == null ? null : WorkflowExpression.Compile(bodydeliveryRouteAction);
            WorkflowExpression.Validate(__workflow_bodydeliveryRouteAction, nameof(bodydeliveryRouteAction), required: false);
            var __workflow_bodydeliveryTerms = bodydeliveryTerms == null ? null : WorkflowExpression.Compile(bodydeliveryTerms);
            WorkflowExpression.Validate(__workflow_bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            var __workflow_bodydocumentFormat = bodydocumentFormat == null ? null : WorkflowExpression.Compile(bodydocumentFormat);
            WorkflowExpression.Validate(__workflow_bodydocumentFormat, nameof(bodydocumentFormat), required: false);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyglobalTradePromotionCodes = bodyglobalTradePromotionCodes == null ? null : WorkflowExpression.Compile(bodyglobalTradePromotionCodes);
            WorkflowExpression.Validate(__workflow_bodyglobalTradePromotionCodes, nameof(bodyglobalTradePromotionCodes), required: false);
            var __workflow_bodygstExemptNumber = bodygstExemptNumber == null ? null : WorkflowExpression.Compile(bodygstExemptNumber);
            WorkflowExpression.Validate(__workflow_bodygstExemptNumber, nameof(bodygstExemptNumber), required: false);
            var __workflow_bodygstExemptionStatus = bodygstExemptionStatus == null ? null : WorkflowExpression.Compile(bodygstExemptionStatus);
            WorkflowExpression.Validate(__workflow_bodygstExemptionStatus, nameof(bodygstExemptionStatus), required: false);
            var __workflow_bodyheaderFreightCharges = bodyheaderFreightCharges == null ? null : WorkflowExpression.Compile(bodyheaderFreightCharges);
            WorkflowExpression.Validate(__workflow_bodyheaderFreightCharges, nameof(bodyheaderFreightCharges), required: false);
            var __workflow_bodyheaderMiscCharges = bodyheaderMiscCharges == null ? null : WorkflowExpression.Compile(bodyheaderMiscCharges);
            WorkflowExpression.Validate(__workflow_bodyheaderMiscCharges, nameof(bodyheaderMiscCharges), required: false);
            var __workflow_bodyignoreWarnings = bodyignoreWarnings == null ? null : WorkflowExpression.Compile(bodyignoreWarnings);
            WorkflowExpression.Validate(__workflow_bodyignoreWarnings, nameof(bodyignoreWarnings), required: false);
            var __workflow_bodyinBoxMsgReqd = bodyinBoxMsgReqd == null ? null : WorkflowExpression.Compile(bodyinBoxMsgReqd);
            WorkflowExpression.Validate(__workflow_bodyinBoxMsgReqd, nameof(bodyinBoxMsgReqd), required: false);
            var __workflow_bodyincludeInMrp = bodyincludeInMrp == null ? null : WorkflowExpression.Compile(bodyincludeInMrp);
            WorkflowExpression.Validate(__workflow_bodyincludeInMrp, nameof(bodyincludeInMrp), required: false);
            var __workflow_bodyinvoiceDateEntered = bodyinvoiceDateEntered == null ? null : WorkflowExpression.Compile(bodyinvoiceDateEntered);
            WorkflowExpression.Validate(__workflow_bodyinvoiceDateEntered, nameof(bodyinvoiceDateEntered), required: false);
            var __workflow_bodyinvoiceNumberEntered = bodyinvoiceNumberEntered == null ? null : WorkflowExpression.Compile(bodyinvoiceNumberEntered);
            WorkflowExpression.Validate(__workflow_bodyinvoiceNumberEntered, nameof(bodyinvoiceNumberEntered), required: false);
            var __workflow_bodyinvoiceTerms = bodyinvoiceTerms == null ? null : WorkflowExpression.Compile(bodyinvoiceTerms);
            WorkflowExpression.Validate(__workflow_bodyinvoiceTerms, nameof(bodyinvoiceTerms), required: false);
            var __workflow_bodyinvoiceWholeOrderOnly = bodyinvoiceWholeOrderOnly == null ? null : WorkflowExpression.Compile(bodyinvoiceWholeOrderOnly);
            WorkflowExpression.Validate(__workflow_bodyinvoiceWholeOrderOnly, nameof(bodyinvoiceWholeOrderOnly), required: false);
            var __workflow_bodylanguageCode = bodylanguageCode == null ? null : WorkflowExpression.Compile(bodylanguageCode);
            WorkflowExpression.Validate(__workflow_bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodyminimumDaysToShip = bodyminimumDaysToShip == null ? null : WorkflowExpression.Compile(bodyminimumDaysToShip);
            WorkflowExpression.Validate(__workflow_bodyminimumDaysToShip, nameof(bodyminimumDaysToShip), required: false);
            var __workflow_bodymultiShipCode = bodymultiShipCode == null ? null : WorkflowExpression.Compile(bodymultiShipCode);
            WorkflowExpression.Validate(__workflow_bodymultiShipCode, nameof(bodymultiShipCode), required: false);
            var __workflow_bodynationality = bodynationality == null ? null : WorkflowExpression.Compile(bodynationality);
            WorkflowExpression.Validate(__workflow_bodynationality, nameof(bodynationality), required: false);
            var __workflow_bodynewCustomerPoNumber = bodynewCustomerPoNumber == null ? null : WorkflowExpression.Compile(bodynewCustomerPoNumber);
            WorkflowExpression.Validate(__workflow_bodynewCustomerPoNumber, nameof(bodynewCustomerPoNumber), required: false);
            var __workflow_bodynewSalesOrderNumber = bodynewSalesOrderNumber == null ? null : WorkflowExpression.Compile(bodynewSalesOrderNumber);
            WorkflowExpression.Validate(__workflow_bodynewSalesOrderNumber, nameof(bodynewSalesOrderNumber), required: false);
            var __workflow_bodyoperatorToInform = bodyoperatorToInform == null ? null : WorkflowExpression.Compile(bodyoperatorToInform);
            WorkflowExpression.Validate(__workflow_bodyoperatorToInform, nameof(bodyoperatorToInform), required: false);
            var __workflow_bodyorderActionType = bodyorderActionType == null ? null : WorkflowExpression.Compile(bodyorderActionType);
            WorkflowExpression.Validate(__workflow_bodyorderActionType, nameof(bodyorderActionType), required: false);
            var __workflow_bodyorderComments = bodyorderComments == null ? null : WorkflowExpression.Compile(bodyorderComments);
            WorkflowExpression.Validate(__workflow_bodyorderComments, nameof(bodyorderComments), required: false);
            var __workflow_bodyorderDate = bodyorderDate == null ? null : WorkflowExpression.Compile(bodyorderDate);
            WorkflowExpression.Validate(__workflow_bodyorderDate, nameof(bodyorderDate), required: false);
            var __workflow_bodyorderDiscPercent1 = bodyorderDiscPercent1 == null ? null : WorkflowExpression.Compile(bodyorderDiscPercent1);
            WorkflowExpression.Validate(__workflow_bodyorderDiscPercent1, nameof(bodyorderDiscPercent1), required: false);
            var __workflow_bodyorderDiscPercent2 = bodyorderDiscPercent2 == null ? null : WorkflowExpression.Compile(bodyorderDiscPercent2);
            WorkflowExpression.Validate(__workflow_bodyorderDiscPercent2, nameof(bodyorderDiscPercent2), required: false);
            var __workflow_bodyorderDiscPercent3 = bodyorderDiscPercent3 == null ? null : WorkflowExpression.Compile(bodyorderDiscPercent3);
            WorkflowExpression.Validate(__workflow_bodyorderDiscPercent3, nameof(bodyorderDiscPercent3), required: false);
            var __workflow_bodyorderStatus = bodyorderStatus == null ? null : WorkflowExpression.Compile(bodyorderStatus);
            WorkflowExpression.Validate(__workflow_bodyorderStatus, nameof(bodyorderStatus), required: false);
            var __workflow_bodyorderType = bodyorderType == null ? null : WorkflowExpression.Compile(bodyorderType);
            WorkflowExpression.Validate(__workflow_bodyorderType, nameof(bodyorderType), required: false);
            var __workflow_bodyoverrideCustomerBackOrder = bodyoverrideCustomerBackOrder == null ? null : WorkflowExpression.Compile(bodyoverrideCustomerBackOrder);
            WorkflowExpression.Validate(__workflow_bodyoverrideCustomerBackOrder, nameof(bodyoverrideCustomerBackOrder), required: false);
            var __workflow_bodypOSSalesOrder = bodypOSSalesOrder == null ? null : WorkflowExpression.Compile(bodypOSSalesOrder);
            WorkflowExpression.Validate(__workflow_bodypOSSalesOrder, nameof(bodypOSSalesOrder), required: false);
            var __workflow_bodyprocess = bodyprocess == null ? null : WorkflowExpression.Compile(bodyprocess);
            WorkflowExpression.Validate(__workflow_bodyprocess, nameof(bodyprocess), required: false);
            var __workflow_bodyprocessFlag = bodyprocessFlag == null ? null : WorkflowExpression.Compile(bodyprocessFlag);
            WorkflowExpression.Validate(__workflow_bodyprocessFlag, nameof(bodyprocessFlag), required: false);
            var __workflow_bodyputEntireQuantityOnNewLoadWhenChanged = bodyputEntireQuantityOnNewLoadWhenChanged == null ? null : WorkflowExpression.Compile(bodyputEntireQuantityOnNewLoadWhenChanged);
            WorkflowExpression.Validate(__workflow_bodyputEntireQuantityOnNewLoadWhenChanged, nameof(bodyputEntireQuantityOnNewLoadWhenChanged), required: false);
            var __workflow_bodyreceiverCode = bodyreceiverCode == null ? null : WorkflowExpression.Compile(bodyreceiverCode);
            WorkflowExpression.Validate(__workflow_bodyreceiverCode, nameof(bodyreceiverCode), required: false);
            var __workflow_bodyrequestedShipDate = bodyrequestedShipDate == null ? null : WorkflowExpression.Compile(bodyrequestedShipDate);
            WorkflowExpression.Validate(__workflow_bodyrequestedShipDate, nameof(bodyrequestedShipDate), required: false);
            var __workflow_bodyreserveStock = bodyreserveStock == null ? null : WorkflowExpression.Compile(bodyreserveStock);
            WorkflowExpression.Validate(__workflow_bodyreserveStock, nameof(bodyreserveStock), required: false);
            var __workflow_bodyreserveStockRequestAllocs = bodyreserveStockRequestAllocs == null ? null : WorkflowExpression.Compile(bodyreserveStockRequestAllocs);
            WorkflowExpression.Validate(__workflow_bodyreserveStockRequestAllocs, nameof(bodyreserveStockRequestAllocs), required: false);
            var __workflow_bodysalesOrder = bodysalesOrder == null ? null : WorkflowExpression.Compile(bodysalesOrder);
            WorkflowExpression.Validate(__workflow_bodysalesOrder, nameof(bodysalesOrder), required: false);
            var __workflow_bodysalesOrderDetails = bodysalesOrderDetails == null ? null : WorkflowExpression.Compile(bodysalesOrderDetails);
            WorkflowExpression.Validate(__workflow_bodysalesOrderDetails, nameof(bodysalesOrderDetails), required: false);
            var __workflow_bodysalesOrderFooterComments = bodysalesOrderFooterComments == null ? null : WorkflowExpression.Compile(bodysalesOrderFooterComments);
            WorkflowExpression.Validate(__workflow_bodysalesOrderFooterComments, nameof(bodysalesOrderFooterComments), required: false);
            var __workflow_bodysalesOrderFreightDetails = bodysalesOrderFreightDetails == null ? null : WorkflowExpression.Compile(bodysalesOrderFreightDetails);
            WorkflowExpression.Validate(__workflow_bodysalesOrderFreightDetails, nameof(bodysalesOrderFreightDetails), required: false);
            var __workflow_bodysalesOrderHeaderComments = bodysalesOrderHeaderComments == null ? null : WorkflowExpression.Compile(bodysalesOrderHeaderComments);
            WorkflowExpression.Validate(__workflow_bodysalesOrderHeaderComments, nameof(bodysalesOrderHeaderComments), required: false);
            var __workflow_bodysalesOrderMiscChargesDetails = bodysalesOrderMiscChargesDetails == null ? null : WorkflowExpression.Compile(bodysalesOrderMiscChargesDetails);
            WorkflowExpression.Validate(__workflow_bodysalesOrderMiscChargesDetails, nameof(bodysalesOrderMiscChargesDetails), required: false);
            var __workflow_bodysalesOrderPromoQualifyAction = bodysalesOrderPromoQualifyAction == null ? null : WorkflowExpression.Compile(bodysalesOrderPromoQualifyAction);
            WorkflowExpression.Validate(__workflow_bodysalesOrderPromoQualifyAction, nameof(bodysalesOrderPromoQualifyAction), required: false);
            var __workflow_bodysalesOrderPromoSelectAction = bodysalesOrderPromoSelectAction == null ? null : WorkflowExpression.Compile(bodysalesOrderPromoSelectAction);
            WorkflowExpression.Validate(__workflow_bodysalesOrderPromoSelectAction, nameof(bodysalesOrderPromoSelectAction), required: false);
            var __workflow_bodysalesperson = bodysalesperson == null ? null : WorkflowExpression.Compile(bodysalesperson);
            WorkflowExpression.Validate(__workflow_bodysalesperson, nameof(bodysalesperson), required: false);
            var __workflow_bodysenderCode = bodysenderCode == null ? null : WorkflowExpression.Compile(bodysenderCode);
            WorkflowExpression.Validate(__workflow_bodysenderCode, nameof(bodysenderCode), required: false);
            var __workflow_bodyshipAddress1 = bodyshipAddress1 == null ? null : WorkflowExpression.Compile(bodyshipAddress1);
            WorkflowExpression.Validate(__workflow_bodyshipAddress1, nameof(bodyshipAddress1), required: false);
            var __workflow_bodyshipAddress2 = bodyshipAddress2 == null ? null : WorkflowExpression.Compile(bodyshipAddress2);
            WorkflowExpression.Validate(__workflow_bodyshipAddress2, nameof(bodyshipAddress2), required: false);
            var __workflow_bodyshipAddress3 = bodyshipAddress3 == null ? null : WorkflowExpression.Compile(bodyshipAddress3);
            WorkflowExpression.Validate(__workflow_bodyshipAddress3, nameof(bodyshipAddress3), required: false);
            var __workflow_bodyshipAddress3Locality = bodyshipAddress3Locality == null ? null : WorkflowExpression.Compile(bodyshipAddress3Locality);
            WorkflowExpression.Validate(__workflow_bodyshipAddress3Locality, nameof(bodyshipAddress3Locality), required: false);
            var __workflow_bodyshipAddress4 = bodyshipAddress4 == null ? null : WorkflowExpression.Compile(bodyshipAddress4);
            WorkflowExpression.Validate(__workflow_bodyshipAddress4, nameof(bodyshipAddress4), required: false);
            var __workflow_bodyshipAddress5 = bodyshipAddress5 == null ? null : WorkflowExpression.Compile(bodyshipAddress5);
            WorkflowExpression.Validate(__workflow_bodyshipAddress5, nameof(bodyshipAddress5), required: false);
            var __workflow_bodyshipAddressPerLine = bodyshipAddressPerLine == null ? null : WorkflowExpression.Compile(bodyshipAddressPerLine);
            WorkflowExpression.Validate(__workflow_bodyshipAddressPerLine, nameof(bodyshipAddressPerLine), required: false);
            var __workflow_bodyshipAddressPerLineTax = bodyshipAddressPerLineTax == null ? null : WorkflowExpression.Compile(bodyshipAddressPerLineTax);
            WorkflowExpression.Validate(__workflow_bodyshipAddressPerLineTax, nameof(bodyshipAddressPerLineTax), required: false);
            var __workflow_bodyshipGpsLat = bodyshipGpsLat == null ? null : WorkflowExpression.Compile(bodyshipGpsLat);
            WorkflowExpression.Validate(__workflow_bodyshipGpsLat, nameof(bodyshipGpsLat), required: false);
            var __workflow_bodyshipGpsLong = bodyshipGpsLong == null ? null : WorkflowExpression.Compile(bodyshipGpsLong);
            WorkflowExpression.Validate(__workflow_bodyshipGpsLong, nameof(bodyshipGpsLong), required: false);
            var __workflow_bodyshipPostalCode = bodyshipPostalCode == null ? null : WorkflowExpression.Compile(bodyshipPostalCode);
            WorkflowExpression.Validate(__workflow_bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            var __workflow_bodyshippingInstrs = bodyshippingInstrs == null ? null : WorkflowExpression.Compile(bodyshippingInstrs);
            WorkflowExpression.Validate(__workflow_bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            var __workflow_bodyshippingInstrsCode = bodyshippingInstrsCode == null ? null : WorkflowExpression.Compile(bodyshippingInstrsCode);
            WorkflowExpression.Validate(__workflow_bodyshippingInstrsCode, nameof(bodyshippingInstrsCode), required: false);
            var __workflow_bodyshippingLocation = bodyshippingLocation == null ? null : WorkflowExpression.Compile(bodyshippingLocation);
            WorkflowExpression.Validate(__workflow_bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            var __workflow_bodyspecialInstrs = bodyspecialInstrs == null ? null : WorkflowExpression.Compile(bodyspecialInstrs);
            WorkflowExpression.Validate(__workflow_bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: false);
            var __workflow_bodystatusInProcess = bodystatusInProcess == null ? null : WorkflowExpression.Compile(bodystatusInProcess);
            WorkflowExpression.Validate(__workflow_bodystatusInProcess, nameof(bodystatusInProcess), required: false);
            var __workflow_bodystatusInProcessResponse = bodystatusInProcessResponse == null ? null : WorkflowExpression.Compile(bodystatusInProcessResponse);
            WorkflowExpression.Validate(__workflow_bodystatusInProcessResponse, nameof(bodystatusInProcessResponse), required: false);
            var __workflow_bodysupplier = bodysupplier == null ? null : WorkflowExpression.Compile(bodysupplier);
            WorkflowExpression.Validate(__workflow_bodysupplier, nameof(bodysupplier), required: false);
            var __workflow_bodytagsToDropFromXML = bodytagsToDropFromXML == null ? null : WorkflowExpression.Compile(bodytagsToDropFromXML);
            WorkflowExpression.Validate(__workflow_bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            var __workflow_bodytaxExemptNumber = bodytaxExemptNumber == null ? null : WorkflowExpression.Compile(bodytaxExemptNumber);
            WorkflowExpression.Validate(__workflow_bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            var __workflow_bodytaxExemptionStatus = bodytaxExemptionStatus == null ? null : WorkflowExpression.Compile(bodytaxExemptionStatus);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionStatus, nameof(bodytaxExemptionStatus), required: false);
            var __workflow_bodytransactionNature = bodytransactionNature == null ? null : WorkflowExpression.Compile(bodytransactionNature);
            WorkflowExpression.Validate(__workflow_bodytransactionNature, nameof(bodytransactionNature), required: false);
            var __workflow_bodytransmissionReference = bodytransmissionReference == null ? null : WorkflowExpression.Compile(bodytransmissionReference);
            WorkflowExpression.Validate(__workflow_bodytransmissionReference, nameof(bodytransmissionReference), required: false);
            var __workflow_bodytransportMode = bodytransportMode == null ? null : WorkflowExpression.Compile(bodytransportMode);
            WorkflowExpression.Validate(__workflow_bodytransportMode, nameof(bodytransportMode), required: false);
            var __workflow_bodytypeOfOrder = bodytypeOfOrder == null ? null : WorkflowExpression.Compile(bodytypeOfOrder);
            WorkflowExpression.Validate(__workflow_bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            var __workflow_bodyuseCustomerSalesWarehouse = bodyuseCustomerSalesWarehouse == null ? null : WorkflowExpression.Compile(bodyuseCustomerSalesWarehouse);
            WorkflowExpression.Validate(__workflow_bodyuseCustomerSalesWarehouse, nameof(bodyuseCustomerSalesWarehouse), required: false);
            var __workflow_bodyuseMasterAccountForCustomerPartNo = bodyuseMasterAccountForCustomerPartNo == null ? null : WorkflowExpression.Compile(bodyuseMasterAccountForCustomerPartNo);
            WorkflowExpression.Validate(__workflow_bodyuseMasterAccountForCustomerPartNo, nameof(bodyuseMasterAccountForCustomerPartNo), required: false);
            var __workflow_bodyuseStockDescSupplied = bodyuseStockDescSupplied == null ? null : WorkflowExpression.Compile(bodyuseStockDescSupplied);
            WorkflowExpression.Validate(__workflow_bodyuseStockDescSupplied, nameof(bodyuseStockDescSupplied), required: false);
            var __workflow_bodyvalidateShippingInstrs = bodyvalidateShippingInstrs == null ? null : WorkflowExpression.Compile(bodyvalidateShippingInstrs);
            WorkflowExpression.Validate(__workflow_bodyvalidateShippingInstrs, nameof(bodyvalidateShippingInstrs), required: false);
            var __workflow_bodywarehouse = bodywarehouse == null ? null : WorkflowExpression.Compile(bodywarehouse);
            WorkflowExpression.Validate(__workflow_bodywarehouse, nameof(bodywarehouse), required: false);
            var __workflow_bodywarehouseListToUse = bodywarehouseListToUse == null ? null : WorkflowExpression.Compile(bodywarehouseListToUse);
            WorkflowExpression.Validate(__workflow_bodywarehouseListToUse, nameof(bodywarehouseListToUse), required: false);
            var __workflow_bodywarnIfCustomerOnHold = bodywarnIfCustomerOnHold == null ? null : WorkflowExpression.Compile(bodywarnIfCustomerOnHold);
            WorkflowExpression.Validate(__workflow_bodywarnIfCustomerOnHold, nameof(bodywarnIfCustomerOnHold), required: false);
            var __workflow_bodyeSignature = bodyeSignature == null ? null : WorkflowExpression.Compile(bodyeSignature);
            WorkflowExpression.Validate(__workflow_bodyeSignature, nameof(bodyeSignature), required: false);
            return new DeferredBodyAction<SYSPROCreateNewSalesOrderResponse>(() =>
            {
                var apiCallPath = "/api/v1/syspro/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyacceptEarlierShipDate != null)
                {
                    body["AcceptEarlierShipDate"] = ExpressionConverter.ConvertO(__workflow_bodyacceptEarlierShipDate);
                    bodypropCount++;
                }

                if (__workflow_bodyacceptKitOptional != null)
                {
                    body["AcceptKitOptional"] = ExpressionConverter.ConvertO(__workflow_bodyacceptKitOptional);
                    bodypropCount++;
                }

                if (__workflow_bodyacceptOrdersIfNoCredit != null)
                {
                    body["AcceptOrdersIfNoCredit"] = ExpressionConverter.ConvertO(__workflow_bodyacceptOrdersIfNoCredit);
                    bodypropCount++;
                }

                if (__workflow_bodyaddAttachedServiceCharges != null)
                {
                    body["AddAttachedServiceCharges"] = ExpressionConverter.ConvertO(__workflow_bodyaddAttachedServiceCharges);
                    bodypropCount++;
                }

                if (__workflow_bodyaddDangerousGoodsText != null)
                {
                    body["AddDangerousGoodsText"] = ExpressionConverter.ConvertO(__workflow_bodyaddDangerousGoodsText);
                    bodypropCount++;
                }

                if (__workflow_bodyaddStockSalesOrderText != null)
                {
                    body["AddStockSalesOrderText"] = ExpressionConverter.ConvertO(__workflow_bodyaddStockSalesOrderText);
                    bodypropCount++;
                }

                if (__workflow_bodyallocationAction != null)
                {
                    body["AllocationAction"] = ExpressionConverter.ConvertO(__workflow_bodyallocationAction);
                    bodypropCount++;
                }

                if (__workflow_bodyallowBackOrderForNegativeMerchLine != null)
                {
                    body["AllowBackOrderForNegativeMerchLine"] = ExpressionConverter.ConvertO(__workflow_bodyallowBackOrderForNegativeMerchLine);
                    bodypropCount++;
                }

                if (__workflow_bodyallowBackOrderForPartialHold != null)
                {
                    body["AllowBackOrderForPartialHold"] = ExpressionConverter.ConvertO(__workflow_bodyallowBackOrderForPartialHold);
                    bodypropCount++;
                }

                if (__workflow_bodyallowBackOrderForSuperseded != null)
                {
                    body["AllowBackOrderForSuperseded"] = ExpressionConverter.ConvertO(__workflow_bodyallowBackOrderForSuperseded);
                    bodypropCount++;
                }

                if (__workflow_bodyallowChangeToZeroPrice != null)
                {
                    body["AllowChangeToZeroPrice"] = ExpressionConverter.ConvertO(__workflow_bodyallowChangeToZeroPrice);
                    bodypropCount++;
                }

                if (__workflow_bodyallowDuplicateOrderNumbers != null)
                {
                    body["AllowDuplicateOrderNumbers"] = ExpressionConverter.ConvertO(__workflow_bodyallowDuplicateOrderNumbers);
                    bodypropCount++;
                }

                if (__workflow_bodyallowManualOrderNumberToBeUsed != null)
                {
                    body["AllowManualOrderNumberToBeUsed"] = ExpressionConverter.ConvertO(__workflow_bodyallowManualOrderNumberToBeUsed);
                    bodypropCount++;
                }

                if (__workflow_bodyallowNonStockItems != null)
                {
                    body["AllowNonStockItems"] = ExpressionConverter.ConvertO(__workflow_bodyallowNonStockItems);
                    bodypropCount++;
                }

                if (__workflow_bodyallowZeroPrice != null)
                {
                    body["AllowZeroPrice"] = ExpressionConverter.ConvertO(__workflow_bodyallowZeroPrice);
                    bodypropCount++;
                }

                if (__workflow_bodyalternateReference != null)
                {
                    body["AlternateReference"] = ExpressionConverter.ConvertO(__workflow_bodyalternateReference);
                    bodypropCount++;
                }

                if (__workflow_bodyalwaysUsePriceEntered != null)
                {
                    body["AlwaysUsePriceEntered"] = ExpressionConverter.ConvertO(__workflow_bodyalwaysUsePriceEntered);
                    bodypropCount++;
                }

                if (__workflow_bodyapplyLeadTimeCalculation != null)
                {
                    body["ApplyLeadTimeCalculation"] = ExpressionConverter.ConvertO(__workflow_bodyapplyLeadTimeCalculation);
                    bodypropCount++;
                }

                if (__workflow_bodyapplyParentDiscountToComponents != null)
                {
                    body["ApplyParentDiscountToComponents"] = ExpressionConverter.ConvertO(__workflow_bodyapplyParentDiscountToComponents);
                    bodypropCount++;
                }

                if (__workflow_bodyarea != null)
                {
                    body["Area"] = ExpressionConverter.ConvertO(__workflow_bodyarea);
                    bodypropCount++;
                }

                if (__workflow_bodybranch != null)
                {
                    body["Branch"] = ExpressionConverter.ConvertO(__workflow_bodybranch);
                    bodypropCount++;
                }

                if (__workflow_bodycancelReasonCode != null)
                {
                    body["CancelReasonCode"] = ExpressionConverter.ConvertO(__workflow_bodycancelReasonCode);
                    bodypropCount++;
                }

                if (__workflow_bodycheckForCustomerPoNumbers != null)
                {
                    body["CheckForCustomerPoNumbers"] = ExpressionConverter.ConvertO(__workflow_bodycheckForCustomerPoNumbers);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["City"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyTaxNumber != null)
                {
                    body["CompanyTaxNumber"] = ExpressionConverter.ConvertO(__workflow_bodycompanyTaxNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycountyZip != null)
                {
                    body["CountyZip"] = ExpressionConverter.ConvertO(__workflow_bodycountyZip);
                    bodypropCount++;
                }

                if (__workflow_bodycreditFailMessage != null)
                {
                    body["CreditFailMessage"] = ExpressionConverter.ConvertO(__workflow_bodycreditFailMessage);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    body["Currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                if (__workflow_bodycustomer != null)
                {
                    body["Customer"] = ExpressionConverter.ConvertO(__workflow_bodycustomer);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerName != null)
                {
                    body["CustomerName"] = ExpressionConverter.ConvertO(__workflow_bodycustomerName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerPoNumber != null)
                {
                    body["CustomerPoNumber"] = ExpressionConverter.ConvertO(__workflow_bodycustomerPoNumber);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerToUse != null)
                {
                    body["CustomerToUse"] = ExpressionConverter.ConvertO(__workflow_bodycustomerToUse);
                    bodypropCount++;
                }

                if (__workflow_bodydeliveryRoute != null)
                {
                    body["DeliveryRoute"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryRoute);
                    bodypropCount++;
                }

                if (__workflow_bodydeliveryRouteAction != null)
                {
                    body["DeliveryRouteAction"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryRouteAction);
                    bodypropCount++;
                }

                if (__workflow_bodydeliveryTerms != null)
                {
                    body["DeliveryTerms"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryTerms);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentFormat != null)
                {
                    body["DocumentFormat"] = ExpressionConverter.ConvertO(__workflow_bodydocumentFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyglobalTradePromotionCodes != null)
                {
                    body["GlobalTradePromotionCodes"] = ExpressionConverter.ConvertO(__workflow_bodyglobalTradePromotionCodes);
                    bodypropCount++;
                }

                if (__workflow_bodygstExemptNumber != null)
                {
                    body["GstExemptNumber"] = ExpressionConverter.ConvertO(__workflow_bodygstExemptNumber);
                    bodypropCount++;
                }

                if (__workflow_bodygstExemptionStatus != null)
                {
                    body["GstExemptionStatus"] = ExpressionConverter.ConvertO(__workflow_bodygstExemptionStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyheaderFreightCharges != null)
                {
                    body["HeaderFreightCharges"] = ExpressionConverter.ConvertO(__workflow_bodyheaderFreightCharges);
                    bodypropCount++;
                }

                if (__workflow_bodyheaderMiscCharges != null)
                {
                    body["HeaderMiscCharges"] = ExpressionConverter.ConvertO(__workflow_bodyheaderMiscCharges);
                    bodypropCount++;
                }

                if (__workflow_bodyignoreWarnings != null)
                {
                    body["IgnoreWarnings"] = ExpressionConverter.ConvertO(__workflow_bodyignoreWarnings);
                    bodypropCount++;
                }

                if (__workflow_bodyinBoxMsgReqd != null)
                {
                    body["InBoxMsgReqd"] = ExpressionConverter.ConvertO(__workflow_bodyinBoxMsgReqd);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeInMrp != null)
                {
                    body["IncludeInMrp"] = ExpressionConverter.ConvertO(__workflow_bodyincludeInMrp);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceDateEntered != null)
                {
                    body["InvoiceDateEntered"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceDateEntered);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceNumberEntered != null)
                {
                    body["InvoiceNumberEntered"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceNumberEntered);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceTerms != null)
                {
                    body["InvoiceTerms"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceTerms);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceWholeOrderOnly != null)
                {
                    body["InvoiceWholeOrderOnly"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceWholeOrderOnly);
                    bodypropCount++;
                }

                if (__workflow_bodylanguageCode != null)
                {
                    body["LanguageCode"] = ExpressionConverter.ConvertO(__workflow_bodylanguageCode);
                    bodypropCount++;
                }

                if (__workflow_bodyminimumDaysToShip != null)
                {
                    body["MinimumDaysToShip"] = ExpressionConverter.ConvertO(__workflow_bodyminimumDaysToShip);
                    bodypropCount++;
                }

                if (__workflow_bodymultiShipCode != null)
                {
                    body["MultiShipCode"] = ExpressionConverter.ConvertO(__workflow_bodymultiShipCode);
                    bodypropCount++;
                }

                if (__workflow_bodynationality != null)
                {
                    body["Nationality"] = ExpressionConverter.ConvertO(__workflow_bodynationality);
                    bodypropCount++;
                }

                if (__workflow_bodynewCustomerPoNumber != null)
                {
                    body["NewCustomerPoNumber"] = ExpressionConverter.ConvertO(__workflow_bodynewCustomerPoNumber);
                    bodypropCount++;
                }

                if (__workflow_bodynewSalesOrderNumber != null)
                {
                    body["NewSalesOrderNumber"] = ExpressionConverter.ConvertO(__workflow_bodynewSalesOrderNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyoperatorToInform != null)
                {
                    body["OperatorToInform"] = ExpressionConverter.ConvertO(__workflow_bodyoperatorToInform);
                    bodypropCount++;
                }

                if (__workflow_bodyorderActionType != null)
                {
                    body["OrderActionType"] = ExpressionConverter.ConvertO(__workflow_bodyorderActionType);
                    bodypropCount++;
                }

                if (__workflow_bodyorderComments != null)
                {
                    body["OrderComments"] = ExpressionConverter.ConvertO(__workflow_bodyorderComments);
                    bodypropCount++;
                }

                if (__workflow_bodyorderDate != null)
                {
                    body["OrderDate"] = ExpressionConverter.ConvertO(__workflow_bodyorderDate);
                    bodypropCount++;
                }

                if (__workflow_bodyorderDiscPercent1 != null)
                {
                    body["OrderDiscPercent1"] = ExpressionConverter.ConvertO(__workflow_bodyorderDiscPercent1);
                    bodypropCount++;
                }

                if (__workflow_bodyorderDiscPercent2 != null)
                {
                    body["OrderDiscPercent2"] = ExpressionConverter.ConvertO(__workflow_bodyorderDiscPercent2);
                    bodypropCount++;
                }

                if (__workflow_bodyorderDiscPercent3 != null)
                {
                    body["OrderDiscPercent3"] = ExpressionConverter.ConvertO(__workflow_bodyorderDiscPercent3);
                    bodypropCount++;
                }

                if (__workflow_bodyorderStatus != null)
                {
                    body["OrderStatus"] = ExpressionConverter.ConvertO(__workflow_bodyorderStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyorderType != null)
                {
                    body["OrderType"] = ExpressionConverter.ConvertO(__workflow_bodyorderType);
                    bodypropCount++;
                }

                if (__workflow_bodyoverrideCustomerBackOrder != null)
                {
                    body["OverrideCustomerBackOrder"] = ExpressionConverter.ConvertO(__workflow_bodyoverrideCustomerBackOrder);
                    bodypropCount++;
                }

                if (__workflow_bodypOSSalesOrder != null)
                {
                    body["POSSalesOrder"] = ExpressionConverter.ConvertO(__workflow_bodypOSSalesOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyprocess != null)
                {
                    body["Process"] = ExpressionConverter.ConvertO(__workflow_bodyprocess);
                    bodypropCount++;
                }

                if (__workflow_bodyprocessFlag != null)
                {
                    body["ProcessFlag"] = ExpressionConverter.ConvertO(__workflow_bodyprocessFlag);
                    bodypropCount++;
                }

                if (__workflow_bodyputEntireQuantityOnNewLoadWhenChanged != null)
                {
                    body["PutEntireQuantityOnNewLoadWhenChanged"] = ExpressionConverter.ConvertO(__workflow_bodyputEntireQuantityOnNewLoadWhenChanged);
                    bodypropCount++;
                }

                if (__workflow_bodyreceiverCode != null)
                {
                    body["ReceiverCode"] = ExpressionConverter.ConvertO(__workflow_bodyreceiverCode);
                    bodypropCount++;
                }

                if (__workflow_bodyrequestedShipDate != null)
                {
                    body["RequestedShipDate"] = ExpressionConverter.ConvertO(__workflow_bodyrequestedShipDate);
                    bodypropCount++;
                }

                if (__workflow_bodyreserveStock != null)
                {
                    body["ReserveStock"] = ExpressionConverter.ConvertO(__workflow_bodyreserveStock);
                    bodypropCount++;
                }

                if (__workflow_bodyreserveStockRequestAllocs != null)
                {
                    body["ReserveStockRequestAllocs"] = ExpressionConverter.ConvertO(__workflow_bodyreserveStockRequestAllocs);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrder != null)
                {
                    body["SalesOrder"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrder);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderDetails != null)
                {
                    body["SalesOrderDetails"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderDetails);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderFooterComments != null)
                {
                    body["SalesOrderFooterComments"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderFooterComments);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderFreightDetails != null)
                {
                    body["SalesOrderFreightDetails"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderFreightDetails);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderHeaderComments != null)
                {
                    body["SalesOrderHeaderComments"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderHeaderComments);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderMiscChargesDetails != null)
                {
                    body["SalesOrderMiscChargesDetails"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderMiscChargesDetails);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderPromoQualifyAction != null)
                {
                    body["SalesOrderPromoQualifyAction"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderPromoQualifyAction);
                    bodypropCount++;
                }

                if (__workflow_bodysalesOrderPromoSelectAction != null)
                {
                    body["SalesOrderPromoSelectAction"] = ExpressionConverter.ConvertO(__workflow_bodysalesOrderPromoSelectAction);
                    bodypropCount++;
                }

                if (__workflow_bodysalesperson != null)
                {
                    body["Salesperson"] = ExpressionConverter.ConvertO(__workflow_bodysalesperson);
                    bodypropCount++;
                }

                if (__workflow_bodysenderCode != null)
                {
                    body["SenderCode"] = ExpressionConverter.ConvertO(__workflow_bodysenderCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddress1 != null)
                {
                    body["ShipAddress1"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddress2 != null)
                {
                    body["ShipAddress2"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddress2);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddress3 != null)
                {
                    body["ShipAddress3"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddress3);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddress3Locality != null)
                {
                    body["ShipAddress3Locality"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddress3Locality);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddress4 != null)
                {
                    body["ShipAddress4"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddress4);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddress5 != null)
                {
                    body["ShipAddress5"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddress5);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressPerLine != null)
                {
                    body["ShipAddressPerLine"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressPerLine);
                    bodypropCount++;
                }

                if (__workflow_bodyshipAddressPerLineTax != null)
                {
                    body["ShipAddressPerLineTax"] = ExpressionConverter.ConvertO(__workflow_bodyshipAddressPerLineTax);
                    bodypropCount++;
                }

                if (__workflow_bodyshipGpsLat != null)
                {
                    body["ShipGpsLat"] = ExpressionConverter.ConvertO(__workflow_bodyshipGpsLat);
                    bodypropCount++;
                }

                if (__workflow_bodyshipGpsLong != null)
                {
                    body["ShipGpsLong"] = ExpressionConverter.ConvertO(__workflow_bodyshipGpsLong);
                    bodypropCount++;
                }

                if (__workflow_bodyshipPostalCode != null)
                {
                    body["ShipPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyshipPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingInstrs != null)
                {
                    body["ShippingInstrs"] = ExpressionConverter.ConvertO(__workflow_bodyshippingInstrs);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingInstrsCode != null)
                {
                    body["ShippingInstrsCode"] = ExpressionConverter.ConvertO(__workflow_bodyshippingInstrsCode);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingLocation != null)
                {
                    body["ShippingLocation"] = ExpressionConverter.ConvertO(__workflow_bodyshippingLocation);
                    bodypropCount++;
                }

                if (__workflow_bodyspecialInstrs != null)
                {
                    body["SpecialInstrs"] = ExpressionConverter.ConvertO(__workflow_bodyspecialInstrs);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["State"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodystatusInProcess != null)
                {
                    body["StatusInProcess"] = ExpressionConverter.ConvertO(__workflow_bodystatusInProcess);
                    bodypropCount++;
                }

                if (__workflow_bodystatusInProcessResponse != null)
                {
                    body["StatusInProcessResponse"] = ExpressionConverter.ConvertO(__workflow_bodystatusInProcessResponse);
                    bodypropCount++;
                }

                if (__workflow_bodysupplier != null)
                {
                    body["Supplier"] = ExpressionConverter.ConvertO(__workflow_bodysupplier);
                    bodypropCount++;
                }

                if (__workflow_bodytagsToDropFromXML != null)
                {
                    body["TagsToDropFromXML"] = ExpressionConverter.ConvertO(__workflow_bodytagsToDropFromXML);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptNumber != null)
                {
                    body["TaxExemptNumber"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptNumber);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionStatus != null)
                {
                    body["TaxExemptionStatus"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionStatus);
                    bodypropCount++;
                }

                if (__workflow_bodytransactionNature != null)
                {
                    body["TransactionNature"] = ExpressionConverter.ConvertO(__workflow_bodytransactionNature);
                    bodypropCount++;
                }

                if (__workflow_bodytransmissionReference != null)
                {
                    body["TransmissionReference"] = ExpressionConverter.ConvertO(__workflow_bodytransmissionReference);
                    bodypropCount++;
                }

                if (__workflow_bodytransportMode != null)
                {
                    body["TransportMode"] = ExpressionConverter.ConvertO(__workflow_bodytransportMode);
                    bodypropCount++;
                }

                if (__workflow_bodytypeOfOrder != null)
                {
                    body["TypeOfOrder"] = ExpressionConverter.ConvertO(__workflow_bodytypeOfOrder);
                    bodypropCount++;
                }

                if (__workflow_bodyuseCustomerSalesWarehouse != null)
                {
                    body["UseCustomerSalesWarehouse"] = ExpressionConverter.ConvertO(__workflow_bodyuseCustomerSalesWarehouse);
                    bodypropCount++;
                }

                if (__workflow_bodyuseMasterAccountForCustomerPartNo != null)
                {
                    body["UseMasterAccountForCustomerPartNo"] = ExpressionConverter.ConvertO(__workflow_bodyuseMasterAccountForCustomerPartNo);
                    bodypropCount++;
                }

                if (__workflow_bodyuseStockDescSupplied != null)
                {
                    body["UseStockDescSupplied"] = ExpressionConverter.ConvertO(__workflow_bodyuseStockDescSupplied);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidateShippingInstrs != null)
                {
                    body["ValidateShippingInstrs"] = ExpressionConverter.ConvertO(__workflow_bodyvalidateShippingInstrs);
                    bodypropCount++;
                }

                if (__workflow_bodywarehouse != null)
                {
                    body["Warehouse"] = ExpressionConverter.ConvertO(__workflow_bodywarehouse);
                    bodypropCount++;
                }

                if (__workflow_bodywarehouseListToUse != null)
                {
                    body["WarehouseListToUse"] = ExpressionConverter.ConvertO(__workflow_bodywarehouseListToUse);
                    bodypropCount++;
                }

                if (__workflow_bodywarnIfCustomerOnHold != null)
                {
                    body["WarnIfCustomerOnHold"] = ExpressionConverter.ConvertO(__workflow_bodywarnIfCustomerOnHold);
                    bodypropCount++;
                }

                if (__workflow_bodyeSignature != null)
                {
                    body["eSignature"] = ExpressionConverter.ConvertO(__workflow_bodyeSignature);
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
