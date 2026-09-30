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
        public IBodyWorkflowAction<SAGE100CreateNewCustomerResponse> SAGE100CreateNewCustomer([WorkflowExpression] Func<string> bodyaRDivisionNo = null, [WorkflowExpression] Func<string> bodyaddressLine1 = null, [WorkflowExpression] Func<string> bodyaddressLine2 = null, [WorkflowExpression] Func<string> bodyaddressLine3 = null, [WorkflowExpression] Func<bool> bodybatchFax = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodycontactCode = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<bool> bodycreditHold = null, [WorkflowExpression] Func<int> bodycreditLimit = null, [WorkflowExpression] Func<int> bodycustomerDiscountRate = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodycustomerNo = null, [WorkflowExpression] Func<string> bodycustomerType = null, [WorkflowExpression] Func<string> bodydefaultCreditCardPmtType = null, [WorkflowExpression] Func<string> bodydefaultItemCode = null, [WorkflowExpression] Func<string> bodydefaultPaymentType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyfaxNo = null, [WorkflowExpression] Func<bool> bodyopenItemCustomer = null, [WorkflowExpression] Func<string> bodypriceLevel = null, [WorkflowExpression] Func<string> bodyprimaryShipToCode = null, [WorkflowExpression] Func<bool> bodyprintDunningMessage = null, [WorkflowExpression] Func<bool> bodyresidentialAddress = null, [WorkflowExpression] Func<string> bodysalespersonNo = null, [WorkflowExpression] Func<string> bodyshipMethod = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodystatementCycle = null, [WorkflowExpression] Func<string> bodytaxExemptNo = null, [WorkflowExpression] Func<string> bodytaxSchedule = null, [WorkflowExpression] Func<string> bodytelephoneExt = null, [WorkflowExpression] Func<string> bodytelephoneNo = null, [WorkflowExpression] Func<string> bodytermsCode = null, [WorkflowExpression] Func<string> bodyuRLAddress = null, [WorkflowExpression] Func<string> bodyzipCode = null)
        {
            SourceExpression.Validate(bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            SourceExpression.Validate(bodyaddressLine1, nameof(bodyaddressLine1), required: false);
            SourceExpression.Validate(bodyaddressLine2, nameof(bodyaddressLine2), required: false);
            SourceExpression.Validate(bodyaddressLine3, nameof(bodyaddressLine3), required: false);
            SourceExpression.Validate(bodybatchFax, nameof(bodybatchFax), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodycontactCode, nameof(bodycontactCode), required: false);
            SourceExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            SourceExpression.Validate(bodycreditHold, nameof(bodycreditHold), required: false);
            SourceExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            SourceExpression.Validate(bodycustomerDiscountRate, nameof(bodycustomerDiscountRate), required: false);
            SourceExpression.Validate(bodycustomerName, nameof(bodycustomerName), required: false);
            SourceExpression.Validate(bodycustomerNo, nameof(bodycustomerNo), required: false);
            SourceExpression.Validate(bodycustomerType, nameof(bodycustomerType), required: false);
            SourceExpression.Validate(bodydefaultCreditCardPmtType, nameof(bodydefaultCreditCardPmtType), required: false);
            SourceExpression.Validate(bodydefaultItemCode, nameof(bodydefaultItemCode), required: false);
            SourceExpression.Validate(bodydefaultPaymentType, nameof(bodydefaultPaymentType), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyfaxNo, nameof(bodyfaxNo), required: false);
            SourceExpression.Validate(bodyopenItemCustomer, nameof(bodyopenItemCustomer), required: false);
            SourceExpression.Validate(bodypriceLevel, nameof(bodypriceLevel), required: false);
            SourceExpression.Validate(bodyprimaryShipToCode, nameof(bodyprimaryShipToCode), required: false);
            SourceExpression.Validate(bodyprintDunningMessage, nameof(bodyprintDunningMessage), required: false);
            SourceExpression.Validate(bodyresidentialAddress, nameof(bodyresidentialAddress), required: false);
            SourceExpression.Validate(bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            SourceExpression.Validate(bodyshipMethod, nameof(bodyshipMethod), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodystatementCycle, nameof(bodystatementCycle), required: false);
            SourceExpression.Validate(bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            SourceExpression.Validate(bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            SourceExpression.Validate(bodytelephoneExt, nameof(bodytelephoneExt), required: false);
            SourceExpression.Validate(bodytelephoneNo, nameof(bodytelephoneNo), required: false);
            SourceExpression.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            SourceExpression.Validate(bodyuRLAddress, nameof(bodyuRLAddress), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/SAGE100/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaRDivisionNo != null)
                {
                    body["ARDivisionNo"] = SourceExpressionConverter.ConvertToken(bodyaRDivisionNo);
                    bodypropCount++;
                }

                if (bodyaddressLine1 != null)
                {
                    body["AddressLine1"] = SourceExpressionConverter.ConvertToken(bodyaddressLine1);
                    bodypropCount++;
                }

                if (bodyaddressLine2 != null)
                {
                    body["AddressLine2"] = SourceExpressionConverter.ConvertToken(bodyaddressLine2);
                    bodypropCount++;
                }

                if (bodyaddressLine3 != null)
                {
                    body["AddressLine3"] = SourceExpressionConverter.ConvertToken(bodyaddressLine3);
                    bodypropCount++;
                }

                if (bodybatchFax != null)
                {
                    body["BatchFax"] = SourceExpressionConverter.ConvertToken(bodybatchFax);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodycontactCode != null)
                {
                    body["ContactCode"] = SourceExpressionConverter.ConvertToken(bodycontactCode);
                    bodypropCount++;
                }

                if (bodycountryCode != null)
                {
                    body["CountryCode"] = SourceExpressionConverter.ConvertToken(bodycountryCode);
                    bodypropCount++;
                }

                if (bodycreditHold != null)
                {
                    body["CreditHold"] = SourceExpressionConverter.ConvertToken(bodycreditHold);
                    bodypropCount++;
                }

                if (bodycreditLimit != null)
                {
                    body["CreditLimit"] = SourceExpressionConverter.ConvertToken(bodycreditLimit);
                    bodypropCount++;
                }

                if (bodycustomerDiscountRate != null)
                {
                    body["CustomerDiscountRate"] = SourceExpressionConverter.ConvertToken(bodycustomerDiscountRate);
                    bodypropCount++;
                }

                if (bodycustomerName != null)
                {
                    body["CustomerName"] = SourceExpressionConverter.ConvertToken(bodycustomerName);
                    bodypropCount++;
                }

                if (bodycustomerNo != null)
                {
                    body["CustomerNo"] = SourceExpressionConverter.ConvertToken(bodycustomerNo);
                    bodypropCount++;
                }

                if (bodycustomerType != null)
                {
                    body["CustomerType"] = SourceExpressionConverter.ConvertToken(bodycustomerType);
                    bodypropCount++;
                }

                if (bodydefaultCreditCardPmtType != null)
                {
                    body["DefaultCreditCardPmtType"] = SourceExpressionConverter.ConvertToken(bodydefaultCreditCardPmtType);
                    bodypropCount++;
                }

                if (bodydefaultItemCode != null)
                {
                    body["DefaultItemCode"] = SourceExpressionConverter.ConvertToken(bodydefaultItemCode);
                    bodypropCount++;
                }

                if (bodydefaultPaymentType != null)
                {
                    body["DefaultPaymentType"] = SourceExpressionConverter.ConvertToken(bodydefaultPaymentType);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyfaxNo != null)
                {
                    body["FaxNo"] = SourceExpressionConverter.ConvertToken(bodyfaxNo);
                    bodypropCount++;
                }

                if (bodyopenItemCustomer != null)
                {
                    body["OpenItemCustomer"] = SourceExpressionConverter.ConvertToken(bodyopenItemCustomer);
                    bodypropCount++;
                }

                if (bodypriceLevel != null)
                {
                    body["PriceLevel"] = SourceExpressionConverter.ConvertToken(bodypriceLevel);
                    bodypropCount++;
                }

                if (bodyprimaryShipToCode != null)
                {
                    body["PrimaryShipToCode"] = SourceExpressionConverter.ConvertToken(bodyprimaryShipToCode);
                    bodypropCount++;
                }

                if (bodyprintDunningMessage != null)
                {
                    body["PrintDunningMessage"] = SourceExpressionConverter.ConvertToken(bodyprintDunningMessage);
                    bodypropCount++;
                }

                if (bodyresidentialAddress != null)
                {
                    body["ResidentialAddress"] = SourceExpressionConverter.ConvertToken(bodyresidentialAddress);
                    bodypropCount++;
                }

                if (bodysalespersonNo != null)
                {
                    body["SalespersonNo"] = SourceExpressionConverter.ConvertToken(bodysalespersonNo);
                    bodypropCount++;
                }

                if (bodyshipMethod != null)
                {
                    body["ShipMethod"] = SourceExpressionConverter.ConvertToken(bodyshipMethod);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["State"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodystatementCycle != null)
                {
                    body["StatementCycle"] = SourceExpressionConverter.ConvertToken(bodystatementCycle);
                    bodypropCount++;
                }

                if (bodytaxExemptNo != null)
                {
                    body["TaxExemptNo"] = SourceExpressionConverter.ConvertToken(bodytaxExemptNo);
                    bodypropCount++;
                }

                if (bodytaxSchedule != null)
                {
                    body["TaxSchedule"] = SourceExpressionConverter.ConvertToken(bodytaxSchedule);
                    bodypropCount++;
                }

                if (bodytelephoneExt != null)
                {
                    body["TelephoneExt"] = SourceExpressionConverter.ConvertToken(bodytelephoneExt);
                    bodypropCount++;
                }

                if (bodytelephoneNo != null)
                {
                    body["TelephoneNo"] = SourceExpressionConverter.ConvertToken(bodytelephoneNo);
                    bodypropCount++;
                }

                if (bodytermsCode != null)
                {
                    body["TermsCode"] = SourceExpressionConverter.ConvertToken(bodytermsCode);
                    bodypropCount++;
                }

                if (bodyuRLAddress != null)
                {
                    body["URLAddress"] = SourceExpressionConverter.ConvertToken(bodyuRLAddress);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["ZipCode"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAGE100CreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE100CreateNewSalesOrderResponse> SAGE100CreateNewSalesOrder([WorkflowExpression] Func<string> bodyaRDivisionNo = null, [WorkflowExpression] Func<bool> bodybatchFax = null, [WorkflowExpression] Func<string> bodybillToAddress1 = null, [WorkflowExpression] Func<string> bodybillToAddress2 = null, [WorkflowExpression] Func<string> bodybillToAddress3 = null, [WorkflowExpression] Func<string> bodybillToCity = null, [WorkflowExpression] Func<string> bodybillToCountryCode = null, [WorkflowExpression] Func<string> bodybillToName = null, [WorkflowExpression] Func<string> bodybillToState = null, [WorkflowExpression] Func<string> bodybillToZipCode = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyconfirmTo = null, [WorkflowExpression] Func<string> bodycustomerNo = null, [WorkflowExpression] Func<string> bodycustomerPONo = null, [WorkflowExpression] Func<string> bodycycleCode = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyfOB = null, [WorkflowExpression] Func<string> bodyfaxNo = null, [WorkflowExpression] Func<string> bodymasterRepeatingOrderNo = null, [WorkflowExpression] Func<int> bodynumberOfShippingLabels = null, [WorkflowExpression] Func<string> bodyorderDate = null, [WorkflowExpression] Func<string> bodyorderStatus = null, [WorkflowExpression] Func<string> bodyorderType = null, [WorkflowExpression] Func<bool> bodyprintPickingSheets = null, [WorkflowExpression] Func<bool> bodyprintSalesOrders = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<string> bodysalesOrderNo = null, [WorkflowExpression] Func<string> bodysalespersonNo = null, [WorkflowExpression] Func<string> bodyshipExpireDate = null, [WorkflowExpression] Func<string> bodyshipToAddress1 = null, [WorkflowExpression] Func<string> bodyshipToAddress2 = null, [WorkflowExpression] Func<string> bodyshipToAddress3 = null, [WorkflowExpression] Func<string> bodyshipToCity = null, [WorkflowExpression] Func<string> bodyshipToCode = null, [WorkflowExpression] Func<string> bodyshipToCountryCode = null, [WorkflowExpression] Func<string> bodyshipToName = null, [WorkflowExpression] Func<string> bodyshipToState = null, [WorkflowExpression] Func<string> bodyshipToZipCode = null, [WorkflowExpression] Func<string> bodyshipVia = null, [WorkflowExpression] Func<int> bodyshipWeight = null, [WorkflowExpression] Func<string> bodyshipZoneActual = null, [WorkflowExpression] Func<string> bodysplitCommissions = null, [WorkflowExpression] Func<string> bodytaxExemptNo = null, [WorkflowExpression] Func<string> bodytaxSchedule = null, [WorkflowExpression] Func<string> bodytermsCode = null, [WorkflowExpression] Func<string> bodywarehouseCode = null)
        {
            SourceExpression.Validate(bodyaRDivisionNo, nameof(bodyaRDivisionNo), required: false);
            SourceExpression.Validate(bodybatchFax, nameof(bodybatchFax), required: false);
            SourceExpression.Validate(bodybillToAddress1, nameof(bodybillToAddress1), required: false);
            SourceExpression.Validate(bodybillToAddress2, nameof(bodybillToAddress2), required: false);
            SourceExpression.Validate(bodybillToAddress3, nameof(bodybillToAddress3), required: false);
            SourceExpression.Validate(bodybillToCity, nameof(bodybillToCity), required: false);
            SourceExpression.Validate(bodybillToCountryCode, nameof(bodybillToCountryCode), required: false);
            SourceExpression.Validate(bodybillToName, nameof(bodybillToName), required: false);
            SourceExpression.Validate(bodybillToState, nameof(bodybillToState), required: false);
            SourceExpression.Validate(bodybillToZipCode, nameof(bodybillToZipCode), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodyconfirmTo, nameof(bodyconfirmTo), required: false);
            SourceExpression.Validate(bodycustomerNo, nameof(bodycustomerNo), required: false);
            SourceExpression.Validate(bodycustomerPONo, nameof(bodycustomerPONo), required: false);
            SourceExpression.Validate(bodycycleCode, nameof(bodycycleCode), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyfOB, nameof(bodyfOB), required: false);
            SourceExpression.Validate(bodyfaxNo, nameof(bodyfaxNo), required: false);
            SourceExpression.Validate(bodymasterRepeatingOrderNo, nameof(bodymasterRepeatingOrderNo), required: false);
            SourceExpression.Validate(bodynumberOfShippingLabels, nameof(bodynumberOfShippingLabels), required: false);
            SourceExpression.Validate(bodyorderDate, nameof(bodyorderDate), required: false);
            SourceExpression.Validate(bodyorderStatus, nameof(bodyorderStatus), required: false);
            SourceExpression.Validate(bodyorderType, nameof(bodyorderType), required: false);
            SourceExpression.Validate(bodyprintPickingSheets, nameof(bodyprintPickingSheets), required: false);
            SourceExpression.Validate(bodyprintSalesOrders, nameof(bodyprintSalesOrders), required: false);
            SourceExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            SourceExpression.Validate(bodysalesOrderNo, nameof(bodysalesOrderNo), required: false);
            SourceExpression.Validate(bodysalespersonNo, nameof(bodysalespersonNo), required: false);
            SourceExpression.Validate(bodyshipExpireDate, nameof(bodyshipExpireDate), required: false);
            SourceExpression.Validate(bodyshipToAddress1, nameof(bodyshipToAddress1), required: false);
            SourceExpression.Validate(bodyshipToAddress2, nameof(bodyshipToAddress2), required: false);
            SourceExpression.Validate(bodyshipToAddress3, nameof(bodyshipToAddress3), required: false);
            SourceExpression.Validate(bodyshipToCity, nameof(bodyshipToCity), required: false);
            SourceExpression.Validate(bodyshipToCode, nameof(bodyshipToCode), required: false);
            SourceExpression.Validate(bodyshipToCountryCode, nameof(bodyshipToCountryCode), required: false);
            SourceExpression.Validate(bodyshipToName, nameof(bodyshipToName), required: false);
            SourceExpression.Validate(bodyshipToState, nameof(bodyshipToState), required: false);
            SourceExpression.Validate(bodyshipToZipCode, nameof(bodyshipToZipCode), required: false);
            SourceExpression.Validate(bodyshipVia, nameof(bodyshipVia), required: false);
            SourceExpression.Validate(bodyshipWeight, nameof(bodyshipWeight), required: false);
            SourceExpression.Validate(bodyshipZoneActual, nameof(bodyshipZoneActual), required: false);
            SourceExpression.Validate(bodysplitCommissions, nameof(bodysplitCommissions), required: false);
            SourceExpression.Validate(bodytaxExemptNo, nameof(bodytaxExemptNo), required: false);
            SourceExpression.Validate(bodytaxSchedule, nameof(bodytaxSchedule), required: false);
            SourceExpression.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            SourceExpression.Validate(bodywarehouseCode, nameof(bodywarehouseCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/SAGE100/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaRDivisionNo != null)
                {
                    body["ARDivisionNo"] = SourceExpressionConverter.ConvertToken(bodyaRDivisionNo);
                    bodypropCount++;
                }

                if (bodybatchFax != null)
                {
                    body["BatchFax"] = SourceExpressionConverter.ConvertToken(bodybatchFax);
                    bodypropCount++;
                }

                if (bodybillToAddress1 != null)
                {
                    body["BillToAddress1"] = SourceExpressionConverter.ConvertToken(bodybillToAddress1);
                    bodypropCount++;
                }

                if (bodybillToAddress2 != null)
                {
                    body["BillToAddress2"] = SourceExpressionConverter.ConvertToken(bodybillToAddress2);
                    bodypropCount++;
                }

                if (bodybillToAddress3 != null)
                {
                    body["BillToAddress3"] = SourceExpressionConverter.ConvertToken(bodybillToAddress3);
                    bodypropCount++;
                }

                if (bodybillToCity != null)
                {
                    body["BillToCity"] = SourceExpressionConverter.ConvertToken(bodybillToCity);
                    bodypropCount++;
                }

                if (bodybillToCountryCode != null)
                {
                    body["BillToCountryCode"] = SourceExpressionConverter.ConvertToken(bodybillToCountryCode);
                    bodypropCount++;
                }

                if (bodybillToName != null)
                {
                    body["BillToName"] = SourceExpressionConverter.ConvertToken(bodybillToName);
                    bodypropCount++;
                }

                if (bodybillToState != null)
                {
                    body["BillToState"] = SourceExpressionConverter.ConvertToken(bodybillToState);
                    bodypropCount++;
                }

                if (bodybillToZipCode != null)
                {
                    body["BillToZipCode"] = SourceExpressionConverter.ConvertToken(bodybillToZipCode);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyconfirmTo != null)
                {
                    body["ConfirmTo"] = SourceExpressionConverter.ConvertToken(bodyconfirmTo);
                    bodypropCount++;
                }

                if (bodycustomerNo != null)
                {
                    body["CustomerNo"] = SourceExpressionConverter.ConvertToken(bodycustomerNo);
                    bodypropCount++;
                }

                if (bodycustomerPONo != null)
                {
                    body["CustomerPONo"] = SourceExpressionConverter.ConvertToken(bodycustomerPONo);
                    bodypropCount++;
                }

                if (bodycycleCode != null)
                {
                    body["CycleCode"] = SourceExpressionConverter.ConvertToken(bodycycleCode);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyfOB != null)
                {
                    body["FOB"] = SourceExpressionConverter.ConvertToken(bodyfOB);
                    bodypropCount++;
                }

                if (bodyfaxNo != null)
                {
                    body["FaxNo"] = SourceExpressionConverter.ConvertToken(bodyfaxNo);
                    bodypropCount++;
                }

                if (bodymasterRepeatingOrderNo != null)
                {
                    body["MasterRepeatingOrderNo"] = SourceExpressionConverter.ConvertToken(bodymasterRepeatingOrderNo);
                    bodypropCount++;
                }

                if (bodynumberOfShippingLabels != null)
                {
                    body["NumberOfShippingLabels"] = SourceExpressionConverter.ConvertToken(bodynumberOfShippingLabels);
                    bodypropCount++;
                }

                if (bodyorderDate != null)
                {
                    body["OrderDate"] = SourceExpressionConverter.ConvertToken(bodyorderDate);
                    bodypropCount++;
                }

                if (bodyorderStatus != null)
                {
                    body["OrderStatus"] = SourceExpressionConverter.ConvertToken(bodyorderStatus);
                    bodypropCount++;
                }

                if (bodyorderType != null)
                {
                    body["OrderType"] = SourceExpressionConverter.ConvertToken(bodyorderType);
                    bodypropCount++;
                }

                if (bodyprintPickingSheets != null)
                {
                    body["PrintPickingSheets"] = SourceExpressionConverter.ConvertToken(bodyprintPickingSheets);
                    bodypropCount++;
                }

                if (bodyprintSalesOrders != null)
                {
                    body["PrintSalesOrders"] = SourceExpressionConverter.ConvertToken(bodyprintSalesOrders);
                    bodypropCount++;
                }

                if (bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = SourceExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (bodysalesOrderNo != null)
                {
                    body["SalesOrderNo"] = SourceExpressionConverter.ConvertToken(bodysalesOrderNo);
                    bodypropCount++;
                }

                if (bodysalespersonNo != null)
                {
                    body["SalespersonNo"] = SourceExpressionConverter.ConvertToken(bodysalespersonNo);
                    bodypropCount++;
                }

                if (bodyshipExpireDate != null)
                {
                    body["ShipExpireDate"] = SourceExpressionConverter.ConvertToken(bodyshipExpireDate);
                    bodypropCount++;
                }

                if (bodyshipToAddress1 != null)
                {
                    body["ShipToAddress1"] = SourceExpressionConverter.ConvertToken(bodyshipToAddress1);
                    bodypropCount++;
                }

                if (bodyshipToAddress2 != null)
                {
                    body["ShipToAddress2"] = SourceExpressionConverter.ConvertToken(bodyshipToAddress2);
                    bodypropCount++;
                }

                if (bodyshipToAddress3 != null)
                {
                    body["ShipToAddress3"] = SourceExpressionConverter.ConvertToken(bodyshipToAddress3);
                    bodypropCount++;
                }

                if (bodyshipToCity != null)
                {
                    body["ShipToCity"] = SourceExpressionConverter.ConvertToken(bodyshipToCity);
                    bodypropCount++;
                }

                if (bodyshipToCode != null)
                {
                    body["ShipToCode"] = SourceExpressionConverter.ConvertToken(bodyshipToCode);
                    bodypropCount++;
                }

                if (bodyshipToCountryCode != null)
                {
                    body["ShipToCountryCode"] = SourceExpressionConverter.ConvertToken(bodyshipToCountryCode);
                    bodypropCount++;
                }

                if (bodyshipToName != null)
                {
                    body["ShipToName"] = SourceExpressionConverter.ConvertToken(bodyshipToName);
                    bodypropCount++;
                }

                if (bodyshipToState != null)
                {
                    body["ShipToState"] = SourceExpressionConverter.ConvertToken(bodyshipToState);
                    bodypropCount++;
                }

                if (bodyshipToZipCode != null)
                {
                    body["ShipToZipCode"] = SourceExpressionConverter.ConvertToken(bodyshipToZipCode);
                    bodypropCount++;
                }

                if (bodyshipVia != null)
                {
                    body["ShipVia"] = SourceExpressionConverter.ConvertToken(bodyshipVia);
                    bodypropCount++;
                }

                if (bodyshipWeight != null)
                {
                    body["ShipWeight"] = SourceExpressionConverter.ConvertToken(bodyshipWeight);
                    bodypropCount++;
                }

                if (bodyshipZoneActual != null)
                {
                    body["ShipZoneActual"] = SourceExpressionConverter.ConvertToken(bodyshipZoneActual);
                    bodypropCount++;
                }

                if (bodysplitCommissions != null)
                {
                    body["SplitCommissions"] = SourceExpressionConverter.ConvertToken(bodysplitCommissions);
                    bodypropCount++;
                }

                if (bodytaxExemptNo != null)
                {
                    body["TaxExemptNo"] = SourceExpressionConverter.ConvertToken(bodytaxExemptNo);
                    bodypropCount++;
                }

                if (bodytaxSchedule != null)
                {
                    body["TaxSchedule"] = SourceExpressionConverter.ConvertToken(bodytaxSchedule);
                    bodypropCount++;
                }

                if (bodytermsCode != null)
                {
                    body["TermsCode"] = SourceExpressionConverter.ConvertToken(bodytermsCode);
                    bodypropCount++;
                }

                if (bodywarehouseCode != null)
                {
                    body["WarehouseCode"] = SourceExpressionConverter.ConvertToken(bodywarehouseCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAGE100CreateNewSalesOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewCustomerResponse> CommercientCPQCreateNewCustomer([WorkflowExpression] Func<string> bodybillingCity = null, [WorkflowExpression] Func<string> bodybillingCounty = null, [WorkflowExpression] Func<string> bodybillingPostalCode = null, [WorkflowExpression] Func<string> bodybillingState = null, [WorkflowExpression] Func<string> bodybillingStreet = null, [WorkflowExpression] Func<string> bodygUId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyshippingCity = null, [WorkflowExpression] Func<string> bodyshippingCountry = null, [WorkflowExpression] Func<string> bodyshippingPostalCode = null, [WorkflowExpression] Func<string> bodyshippingState = null, [WorkflowExpression] Func<string> bodyshippingStreet = null, [WorkflowExpression] Func<string> bodyacnm = null)
        {
            SourceExpression.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            SourceExpression.Validate(bodybillingCounty, nameof(bodybillingCounty), required: false);
            SourceExpression.Validate(bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            SourceExpression.Validate(bodybillingState, nameof(bodybillingState), required: false);
            SourceExpression.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            SourceExpression.Validate(bodygUId, nameof(bodygUId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            SourceExpression.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            SourceExpression.Validate(bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            SourceExpression.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            SourceExpression.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            SourceExpression.Validate(bodyacnm, nameof(bodyacnm), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/commercientcpq/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybillingCity != null)
                {
                    body["BillingCity"] = SourceExpressionConverter.ConvertToken(bodybillingCity);
                    bodypropCount++;
                }

                if (bodybillingCounty != null)
                {
                    body["BillingCounty"] = SourceExpressionConverter.ConvertToken(bodybillingCounty);
                    bodypropCount++;
                }

                if (bodybillingPostalCode != null)
                {
                    body["BillingPostalCode"] = SourceExpressionConverter.ConvertToken(bodybillingPostalCode);
                    bodypropCount++;
                }

                if (bodybillingState != null)
                {
                    body["BillingState"] = SourceExpressionConverter.ConvertToken(bodybillingState);
                    bodypropCount++;
                }

                if (bodybillingStreet != null)
                {
                    body["BillingStreet"] = SourceExpressionConverter.ConvertToken(bodybillingStreet);
                    bodypropCount++;
                }

                if (bodygUId != null)
                {
                    body["GUID"] = SourceExpressionConverter.ConvertToken(bodygUId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyshippingCity != null)
                {
                    body["ShippingCity"] = SourceExpressionConverter.ConvertToken(bodyshippingCity);
                    bodypropCount++;
                }

                if (bodyshippingCountry != null)
                {
                    body["ShippingCountry"] = SourceExpressionConverter.ConvertToken(bodyshippingCountry);
                    bodypropCount++;
                }

                if (bodyshippingPostalCode != null)
                {
                    body["ShippingPostalCode"] = SourceExpressionConverter.ConvertToken(bodyshippingPostalCode);
                    bodypropCount++;
                }

                if (bodyshippingState != null)
                {
                    body["ShippingState"] = SourceExpressionConverter.ConvertToken(bodyshippingState);
                    bodypropCount++;
                }

                if (bodyshippingStreet != null)
                {
                    body["ShippingStreet"] = SourceExpressionConverter.ConvertToken(bodyshippingStreet);
                    bodypropCount++;
                }

                if (bodyacnm != null)
                {
                    body["acnm"] = SourceExpressionConverter.ConvertToken(bodyacnm);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewProductResponse> CommercientCPQCreateNewProduct([WorkflowExpression] Func<string> bodystockCode = null)
        {
            SourceExpression.Validate(bodystockCode, nameof(bodystockCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/commercientcpq/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystockCode != null)
                {
                    body["StockCode"] = SourceExpressionConverter.ConvertToken(bodystockCode);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewProductResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<CommercientCPQCreateNewSalesOrderResponse> CommercientCPQCreateNewSalesOrder([WorkflowExpression] Func<string> bodyorderHeaderGUID = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem2[]> bodysalesOrderLineItem = null)
        {
            SourceExpression.Validate(bodyorderHeaderGUID, nameof(bodyorderHeaderGUID), required: false);
            SourceExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/commercientcpq/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderHeaderGUID != null)
                {
                    body["OrderHeaderGUID"] = SourceExpressionConverter.ConvertToken(bodyorderHeaderGUID);
                    bodypropCount++;
                }

                if (bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = SourceExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommercientCPQCreateNewSalesOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewCustomerResponse> QuickBookCreateNewCustomer([WorkflowExpression] Func<string> bodyaccountNumber = null, [WorkflowExpression] Func<string> bodyaltContact = null, [WorkflowExpression] Func<string> bodyaltPhone = null, [WorkflowExpression] Func<string> bodybillAddressAddr1 = null, [WorkflowExpression] Func<string> bodybillAddressAddr2 = null, [WorkflowExpression] Func<string> bodybillAddressAddr3 = null, [WorkflowExpression] Func<string> bodybillAddressAddr4 = null, [WorkflowExpression] Func<string> bodybillAddressAddr5 = null, [WorkflowExpression] Func<string> bodybillAddressCity = null, [WorkflowExpression] Func<string> bodybillAddressCountry = null, [WorkflowExpression] Func<string> bodybillAddressNote = null, [WorkflowExpression] Func<string> bodybillAddressPostalCode = null, [WorkflowExpression] Func<string> bodybillAddressState = null, [WorkflowExpression] Func<string> bodycc = null, [WorkflowExpression] Func<string> bodyclassRef = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodycontact = null, [WorkflowExpression] Func<int> bodycreditLimit = null, [WorkflowExpression] Func<string> bodycustomerTypeRef = null, [WorkflowExpression] Func<string> bodyeditSequence = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<bool> bodyisActive = null, [WorkflowExpression] Func<string> bodyitemSalesTaxRef = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodylistId = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<int> bodyopenBalance = null, [WorkflowExpression] Func<string> bodyopenBalanceDate = null, [WorkflowExpression] Func<string> bodyparentRef = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodypreferredPaymentMethodRef = null, [WorkflowExpression] Func<string> bodypriceLevelRef = null, [WorkflowExpression] Func<string> bodyresaleNumber = null, [WorkflowExpression] Func<string> bodysalesRepRef = null, [WorkflowExpression] Func<string> bodysalesTaxCodeRef = null, [WorkflowExpression] Func<string> bodysalutation = null, [WorkflowExpression] Func<string> bodyshipAddressAddr1 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr2 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr3 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr4 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr5 = null, [WorkflowExpression] Func<string> bodyshipAddressCity = null, [WorkflowExpression] Func<string> bodyshipAddressCountry = null, [WorkflowExpression] Func<string> bodyshipAddressNote = null, [WorkflowExpression] Func<string> bodyshipAddressPostalCode = null, [WorkflowExpression] Func<string> bodyshipAddressState = null, [WorkflowExpression] Func<string> bodytermsRef = null)
        {
            SourceExpression.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            SourceExpression.Validate(bodyaltContact, nameof(bodyaltContact), required: false);
            SourceExpression.Validate(bodyaltPhone, nameof(bodyaltPhone), required: false);
            SourceExpression.Validate(bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            SourceExpression.Validate(bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            SourceExpression.Validate(bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            SourceExpression.Validate(bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            SourceExpression.Validate(bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            SourceExpression.Validate(bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            SourceExpression.Validate(bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            SourceExpression.Validate(bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            SourceExpression.Validate(bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            SourceExpression.Validate(bodybillAddressState, nameof(bodybillAddressState), required: false);
            SourceExpression.Validate(bodycc, nameof(bodycc), required: false);
            SourceExpression.Validate(bodyclassRef, nameof(bodyclassRef), required: false);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodycontact, nameof(bodycontact), required: false);
            SourceExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            SourceExpression.Validate(bodycustomerTypeRef, nameof(bodycustomerTypeRef), required: false);
            SourceExpression.Validate(bodyeditSequence, nameof(bodyeditSequence), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            SourceExpression.Validate(bodyisActive, nameof(bodyisActive), required: false);
            SourceExpression.Validate(bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            SourceExpression.Validate(bodyjobTitle, nameof(bodyjobTitle), required: false);
            SourceExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            SourceExpression.Validate(bodylistId, nameof(bodylistId), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyopenBalance, nameof(bodyopenBalance), required: false);
            SourceExpression.Validate(bodyopenBalanceDate, nameof(bodyopenBalanceDate), required: false);
            SourceExpression.Validate(bodyparentRef, nameof(bodyparentRef), required: false);
            SourceExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            SourceExpression.Validate(bodypreferredPaymentMethodRef, nameof(bodypreferredPaymentMethodRef), required: false);
            SourceExpression.Validate(bodypriceLevelRef, nameof(bodypriceLevelRef), required: false);
            SourceExpression.Validate(bodyresaleNumber, nameof(bodyresaleNumber), required: false);
            SourceExpression.Validate(bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            SourceExpression.Validate(bodysalesTaxCodeRef, nameof(bodysalesTaxCodeRef), required: false);
            SourceExpression.Validate(bodysalutation, nameof(bodysalutation), required: false);
            SourceExpression.Validate(bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            SourceExpression.Validate(bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            SourceExpression.Validate(bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            SourceExpression.Validate(bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            SourceExpression.Validate(bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            SourceExpression.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            SourceExpression.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            SourceExpression.Validate(bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            SourceExpression.Validate(bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            SourceExpression.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            SourceExpression.Validate(bodytermsRef, nameof(bodytermsRef), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/quickbook/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountNumber != null)
                {
                    body["AccountNumber"] = SourceExpressionConverter.ConvertToken(bodyaccountNumber);
                    bodypropCount++;
                }

                if (bodyaltContact != null)
                {
                    body["AltContact"] = SourceExpressionConverter.ConvertToken(bodyaltContact);
                    bodypropCount++;
                }

                if (bodyaltPhone != null)
                {
                    body["AltPhone"] = SourceExpressionConverter.ConvertToken(bodyaltPhone);
                    bodypropCount++;
                }

                if (bodybillAddressAddr1 != null)
                {
                    body["BillAddressAddr1"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr1);
                    bodypropCount++;
                }

                if (bodybillAddressAddr2 != null)
                {
                    body["BillAddressAddr2"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr2);
                    bodypropCount++;
                }

                if (bodybillAddressAddr3 != null)
                {
                    body["BillAddressAddr3"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr3);
                    bodypropCount++;
                }

                if (bodybillAddressAddr4 != null)
                {
                    body["BillAddressAddr4"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr4);
                    bodypropCount++;
                }

                if (bodybillAddressAddr5 != null)
                {
                    body["BillAddressAddr5"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr5);
                    bodypropCount++;
                }

                if (bodybillAddressCity != null)
                {
                    body["BillAddressCity"] = SourceExpressionConverter.ConvertToken(bodybillAddressCity);
                    bodypropCount++;
                }

                if (bodybillAddressCountry != null)
                {
                    body["BillAddressCountry"] = SourceExpressionConverter.ConvertToken(bodybillAddressCountry);
                    bodypropCount++;
                }

                if (bodybillAddressNote != null)
                {
                    body["BillAddressNote"] = SourceExpressionConverter.ConvertToken(bodybillAddressNote);
                    bodypropCount++;
                }

                if (bodybillAddressPostalCode != null)
                {
                    body["BillAddressPostalCode"] = SourceExpressionConverter.ConvertToken(bodybillAddressPostalCode);
                    bodypropCount++;
                }

                if (bodybillAddressState != null)
                {
                    body["BillAddressState"] = SourceExpressionConverter.ConvertToken(bodybillAddressState);
                    bodypropCount++;
                }

                if (bodycc != null)
                {
                    body["Cc"] = SourceExpressionConverter.ConvertToken(bodycc);
                    bodypropCount++;
                }

                if (bodyclassRef != null)
                {
                    body["ClassRef"] = SourceExpressionConverter.ConvertToken(bodyclassRef);
                    bodypropCount++;
                }

                if (bodycompanyName != null)
                {
                    body["CompanyName"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodycontact != null)
                {
                    body["Contact"] = SourceExpressionConverter.ConvertToken(bodycontact);
                    bodypropCount++;
                }

                if (bodycreditLimit != null)
                {
                    body["CreditLimit"] = SourceExpressionConverter.ConvertToken(bodycreditLimit);
                    bodypropCount++;
                }

                if (bodycustomerTypeRef != null)
                {
                    body["CustomerTypeRef"] = SourceExpressionConverter.ConvertToken(bodycustomerTypeRef);
                    bodypropCount++;
                }

                if (bodyeditSequence != null)
                {
                    body["EditSequence"] = SourceExpressionConverter.ConvertToken(bodyeditSequence);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyextraField != null)
                {
                    body["ExtraField"] = SourceExpressionConverter.ConvertToken(bodyextraField);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["Fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["FirstName"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodyisActive != null)
                {
                    body["IsActive"] = SourceExpressionConverter.ConvertToken(bodyisActive);
                    bodypropCount++;
                }

                if (bodyitemSalesTaxRef != null)
                {
                    body["ItemSalesTaxRef"] = SourceExpressionConverter.ConvertToken(bodyitemSalesTaxRef);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["JobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["LastName"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodylistId != null)
                {
                    body["ListID"] = SourceExpressionConverter.ConvertToken(bodylistId);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["MiddleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["Notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyopenBalance != null)
                {
                    body["OpenBalance"] = SourceExpressionConverter.ConvertToken(bodyopenBalance);
                    bodypropCount++;
                }

                if (bodyopenBalanceDate != null)
                {
                    body["OpenBalanceDate"] = SourceExpressionConverter.ConvertToken(bodyopenBalanceDate);
                    bodypropCount++;
                }

                if (bodyparentRef != null)
                {
                    body["ParentRef"] = SourceExpressionConverter.ConvertToken(bodyparentRef);
                    bodypropCount++;
                }

                if (bodyphone != null)
                {
                    body["Phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodypreferredPaymentMethodRef != null)
                {
                    body["PreferredPaymentMethodRef"] = SourceExpressionConverter.ConvertToken(bodypreferredPaymentMethodRef);
                    bodypropCount++;
                }

                if (bodypriceLevelRef != null)
                {
                    body["PriceLevelRef"] = SourceExpressionConverter.ConvertToken(bodypriceLevelRef);
                    bodypropCount++;
                }

                if (bodyresaleNumber != null)
                {
                    body["ResaleNumber"] = SourceExpressionConverter.ConvertToken(bodyresaleNumber);
                    bodypropCount++;
                }

                if (bodysalesRepRef != null)
                {
                    body["SalesRepRef"] = SourceExpressionConverter.ConvertToken(bodysalesRepRef);
                    bodypropCount++;
                }

                if (bodysalesTaxCodeRef != null)
                {
                    body["SalesTaxCodeRef"] = SourceExpressionConverter.ConvertToken(bodysalesTaxCodeRef);
                    bodypropCount++;
                }

                if (bodysalutation != null)
                {
                    body["Salutation"] = SourceExpressionConverter.ConvertToken(bodysalutation);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr1 != null)
                {
                    body["ShipAddressAddr1"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr1);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr2 != null)
                {
                    body["ShipAddressAddr2"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr2);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr3 != null)
                {
                    body["ShipAddressAddr3"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr3);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr4 != null)
                {
                    body["ShipAddressAddr4"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr4);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr5 != null)
                {
                    body["ShipAddressAddr5"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr5);
                    bodypropCount++;
                }

                if (bodyshipAddressCity != null)
                {
                    body["ShipAddressCity"] = SourceExpressionConverter.ConvertToken(bodyshipAddressCity);
                    bodypropCount++;
                }

                if (bodyshipAddressCountry != null)
                {
                    body["ShipAddressCountry"] = SourceExpressionConverter.ConvertToken(bodyshipAddressCountry);
                    bodypropCount++;
                }

                if (bodyshipAddressNote != null)
                {
                    body["ShipAddressNote"] = SourceExpressionConverter.ConvertToken(bodyshipAddressNote);
                    bodypropCount++;
                }

                if (bodyshipAddressPostalCode != null)
                {
                    body["ShipAddressPostalCode"] = SourceExpressionConverter.ConvertToken(bodyshipAddressPostalCode);
                    bodypropCount++;
                }

                if (bodyshipAddressState != null)
                {
                    body["ShipAddressState"] = SourceExpressionConverter.ConvertToken(bodyshipAddressState);
                    bodypropCount++;
                }

                if (bodytermsRef != null)
                {
                    body["TermsRef"] = SourceExpressionConverter.ConvertToken(bodytermsRef);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuickBookCreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<QuickBookCreateNewSalesOrderResponse> QuickBookCreateNewSalesOrder([WorkflowExpression] Func<string> bodybillAddressAddr1 = null, [WorkflowExpression] Func<string> bodybillAddressAddr2 = null, [WorkflowExpression] Func<string> bodybillAddressAddr3 = null, [WorkflowExpression] Func<string> bodybillAddressAddr4 = null, [WorkflowExpression] Func<string> bodybillAddressAddr5 = null, [WorkflowExpression] Func<string> bodybillAddressCity = null, [WorkflowExpression] Func<string> bodybillAddressCountry = null, [WorkflowExpression] Func<string> bodybillAddressNote = null, [WorkflowExpression] Func<string> bodybillAddressPostalCode = null, [WorkflowExpression] Func<string> bodybillAddressState = null, [WorkflowExpression] Func<string> bodyclassRef = null, [WorkflowExpression] Func<string> bodycustomerRefListId = null, [WorkflowExpression] Func<string> bodycustomerRefName = null, [WorkflowExpression] Func<string> bodycustomerSalesTaxCodeRef = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyeditSequence = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyitemSalesTaxRef = null, [WorkflowExpression] Func<string> bodylistId = null, [WorkflowExpression] Func<string> bodymemo = null, [WorkflowExpression] Func<string> bodypONumber = null, [WorkflowExpression] Func<string> bodyrefNumber = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem22[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<string> bodysalesRepRef = null, [WorkflowExpression] Func<string> bodyshipAddressAddr1 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr2 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr3 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr4 = null, [WorkflowExpression] Func<string> bodyshipAddressAddr5 = null, [WorkflowExpression] Func<string> bodyshipAddressCity = null, [WorkflowExpression] Func<string> bodyshipAddressCountry = null, [WorkflowExpression] Func<string> bodyshipAddressNote = null, [WorkflowExpression] Func<string> bodyshipAddressPostalCode = null, [WorkflowExpression] Func<string> bodyshipAddressState = null, [WorkflowExpression] Func<string> bodytemplateRef = null, [WorkflowExpression] Func<string> bodytermsRef = null, [WorkflowExpression] Func<string> bodytxnDate = null)
        {
            SourceExpression.Validate(bodybillAddressAddr1, nameof(bodybillAddressAddr1), required: false);
            SourceExpression.Validate(bodybillAddressAddr2, nameof(bodybillAddressAddr2), required: false);
            SourceExpression.Validate(bodybillAddressAddr3, nameof(bodybillAddressAddr3), required: false);
            SourceExpression.Validate(bodybillAddressAddr4, nameof(bodybillAddressAddr4), required: false);
            SourceExpression.Validate(bodybillAddressAddr5, nameof(bodybillAddressAddr5), required: false);
            SourceExpression.Validate(bodybillAddressCity, nameof(bodybillAddressCity), required: false);
            SourceExpression.Validate(bodybillAddressCountry, nameof(bodybillAddressCountry), required: false);
            SourceExpression.Validate(bodybillAddressNote, nameof(bodybillAddressNote), required: false);
            SourceExpression.Validate(bodybillAddressPostalCode, nameof(bodybillAddressPostalCode), required: false);
            SourceExpression.Validate(bodybillAddressState, nameof(bodybillAddressState), required: false);
            SourceExpression.Validate(bodyclassRef, nameof(bodyclassRef), required: false);
            SourceExpression.Validate(bodycustomerRefListId, nameof(bodycustomerRefListId), required: false);
            SourceExpression.Validate(bodycustomerRefName, nameof(bodycustomerRefName), required: false);
            SourceExpression.Validate(bodycustomerSalesTaxCodeRef, nameof(bodycustomerSalesTaxCodeRef), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyeditSequence, nameof(bodyeditSequence), required: false);
            SourceExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            SourceExpression.Validate(bodyitemSalesTaxRef, nameof(bodyitemSalesTaxRef), required: false);
            SourceExpression.Validate(bodylistId, nameof(bodylistId), required: false);
            SourceExpression.Validate(bodymemo, nameof(bodymemo), required: false);
            SourceExpression.Validate(bodypONumber, nameof(bodypONumber), required: false);
            SourceExpression.Validate(bodyrefNumber, nameof(bodyrefNumber), required: false);
            SourceExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            SourceExpression.Validate(bodysalesRepRef, nameof(bodysalesRepRef), required: false);
            SourceExpression.Validate(bodyshipAddressAddr1, nameof(bodyshipAddressAddr1), required: false);
            SourceExpression.Validate(bodyshipAddressAddr2, nameof(bodyshipAddressAddr2), required: false);
            SourceExpression.Validate(bodyshipAddressAddr3, nameof(bodyshipAddressAddr3), required: false);
            SourceExpression.Validate(bodyshipAddressAddr4, nameof(bodyshipAddressAddr4), required: false);
            SourceExpression.Validate(bodyshipAddressAddr5, nameof(bodyshipAddressAddr5), required: false);
            SourceExpression.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            SourceExpression.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            SourceExpression.Validate(bodyshipAddressNote, nameof(bodyshipAddressNote), required: false);
            SourceExpression.Validate(bodyshipAddressPostalCode, nameof(bodyshipAddressPostalCode), required: false);
            SourceExpression.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            SourceExpression.Validate(bodytemplateRef, nameof(bodytemplateRef), required: false);
            SourceExpression.Validate(bodytermsRef, nameof(bodytermsRef), required: false);
            SourceExpression.Validate(bodytxnDate, nameof(bodytxnDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/quickbook/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybillAddressAddr1 != null)
                {
                    body["BillAddressAddr1"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr1);
                    bodypropCount++;
                }

                if (bodybillAddressAddr2 != null)
                {
                    body["BillAddressAddr2"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr2);
                    bodypropCount++;
                }

                if (bodybillAddressAddr3 != null)
                {
                    body["BillAddressAddr3"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr3);
                    bodypropCount++;
                }

                if (bodybillAddressAddr4 != null)
                {
                    body["BillAddressAddr4"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr4);
                    bodypropCount++;
                }

                if (bodybillAddressAddr5 != null)
                {
                    body["BillAddressAddr5"] = SourceExpressionConverter.ConvertToken(bodybillAddressAddr5);
                    bodypropCount++;
                }

                if (bodybillAddressCity != null)
                {
                    body["BillAddressCity"] = SourceExpressionConverter.ConvertToken(bodybillAddressCity);
                    bodypropCount++;
                }

                if (bodybillAddressCountry != null)
                {
                    body["BillAddressCountry"] = SourceExpressionConverter.ConvertToken(bodybillAddressCountry);
                    bodypropCount++;
                }

                if (bodybillAddressNote != null)
                {
                    body["BillAddressNote"] = SourceExpressionConverter.ConvertToken(bodybillAddressNote);
                    bodypropCount++;
                }

                if (bodybillAddressPostalCode != null)
                {
                    body["BillAddressPostalCode"] = SourceExpressionConverter.ConvertToken(bodybillAddressPostalCode);
                    bodypropCount++;
                }

                if (bodybillAddressState != null)
                {
                    body["BillAddressState"] = SourceExpressionConverter.ConvertToken(bodybillAddressState);
                    bodypropCount++;
                }

                if (bodyclassRef != null)
                {
                    body["ClassRef"] = SourceExpressionConverter.ConvertToken(bodyclassRef);
                    bodypropCount++;
                }

                if (bodycustomerRefListId != null)
                {
                    body["CustomerRefListID"] = SourceExpressionConverter.ConvertToken(bodycustomerRefListId);
                    bodypropCount++;
                }

                if (bodycustomerRefName != null)
                {
                    body["CustomerRefName"] = SourceExpressionConverter.ConvertToken(bodycustomerRefName);
                    bodypropCount++;
                }

                if (bodycustomerSalesTaxCodeRef != null)
                {
                    body["CustomerSalesTaxCodeRef"] = SourceExpressionConverter.ConvertToken(bodycustomerSalesTaxCodeRef);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["DueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodyeditSequence != null)
                {
                    body["EditSequence"] = SourceExpressionConverter.ConvertToken(bodyeditSequence);
                    bodypropCount++;
                }

                if (bodyextraField != null)
                {
                    body["ExtraField"] = SourceExpressionConverter.ConvertToken(bodyextraField);
                    bodypropCount++;
                }

                if (bodyitemSalesTaxRef != null)
                {
                    body["ItemSalesTaxRef"] = SourceExpressionConverter.ConvertToken(bodyitemSalesTaxRef);
                    bodypropCount++;
                }

                if (bodylistId != null)
                {
                    body["ListID"] = SourceExpressionConverter.ConvertToken(bodylistId);
                    bodypropCount++;
                }

                if (bodymemo != null)
                {
                    body["Memo"] = SourceExpressionConverter.ConvertToken(bodymemo);
                    bodypropCount++;
                }

                if (bodypONumber != null)
                {
                    body["PONumber"] = SourceExpressionConverter.ConvertToken(bodypONumber);
                    bodypropCount++;
                }

                if (bodyrefNumber != null)
                {
                    body["RefNumber"] = SourceExpressionConverter.ConvertToken(bodyrefNumber);
                    bodypropCount++;
                }

                if (bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = SourceExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (bodysalesRepRef != null)
                {
                    body["SalesRepRef"] = SourceExpressionConverter.ConvertToken(bodysalesRepRef);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr1 != null)
                {
                    body["ShipAddressAddr1"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr1);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr2 != null)
                {
                    body["ShipAddressAddr2"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr2);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr3 != null)
                {
                    body["ShipAddressAddr3"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr3);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr4 != null)
                {
                    body["ShipAddressAddr4"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr4);
                    bodypropCount++;
                }

                if (bodyshipAddressAddr5 != null)
                {
                    body["ShipAddressAddr5"] = SourceExpressionConverter.ConvertToken(bodyshipAddressAddr5);
                    bodypropCount++;
                }

                if (bodyshipAddressCity != null)
                {
                    body["ShipAddressCity"] = SourceExpressionConverter.ConvertToken(bodyshipAddressCity);
                    bodypropCount++;
                }

                if (bodyshipAddressCountry != null)
                {
                    body["ShipAddressCountry"] = SourceExpressionConverter.ConvertToken(bodyshipAddressCountry);
                    bodypropCount++;
                }

                if (bodyshipAddressNote != null)
                {
                    body["ShipAddressNote"] = SourceExpressionConverter.ConvertToken(bodyshipAddressNote);
                    bodypropCount++;
                }

                if (bodyshipAddressPostalCode != null)
                {
                    body["ShipAddressPostalCode"] = SourceExpressionConverter.ConvertToken(bodyshipAddressPostalCode);
                    bodypropCount++;
                }

                if (bodyshipAddressState != null)
                {
                    body["ShipAddressState"] = SourceExpressionConverter.ConvertToken(bodyshipAddressState);
                    bodypropCount++;
                }

                if (bodytemplateRef != null)
                {
                    body["TemplateRef"] = SourceExpressionConverter.ConvertToken(bodytemplateRef);
                    bodypropCount++;
                }

                if (bodytermsRef != null)
                {
                    body["TermsRef"] = SourceExpressionConverter.ConvertToken(bodytermsRef);
                    bodypropCount++;
                }

                if (bodytxnDate != null)
                {
                    body["TxnDate"] = SourceExpressionConverter.ConvertToken(bodytxnDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QuickBookCreateNewSalesOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50UKCreateNewCustomerResponse> SAGE50UKCreateNewCustomer([WorkflowExpression] Func<string> bodyaCCOUNTOPENED = null, [WorkflowExpression] Func<string> bodyaCCOUNTREF = null, [WorkflowExpression] Func<int> bodyaCCOUNTSTATUS = null, [WorkflowExpression] Func<string> bodyaDDRESS1 = null, [WorkflowExpression] Func<string> bodyaDDRESS2 = null, [WorkflowExpression] Func<string> bodyaDDRESS3 = null, [WorkflowExpression] Func<string> bodyaDDRESS4 = null, [WorkflowExpression] Func<string> bodyaDDRESS5 = null, [WorkflowExpression] Func<string> bodyaNALYSIS1 = null, [WorkflowExpression] Func<string> bodyaNALYSIS2 = null, [WorkflowExpression] Func<string> bodyaNALYSIS3 = null, [WorkflowExpression] Func<int> bodyaVERAGEPAYDAYS = null, [WorkflowExpression] Func<int> bodybALANCE = null, [WorkflowExpression] Func<bool> bodycANAPPLYCHARGES = null, [WorkflowExpression] Func<string> bodycONTACTNAME = null, [WorkflowExpression] Func<string> bodycOUNTRYCODE = null, [WorkflowExpression] Func<string> bodycREDITAPPLIEDFOR = null, [WorkflowExpression] Func<int> bodycREDITBUREAU = null, [WorkflowExpression] Func<int> bodycREDITLIMIT = null, [WorkflowExpression] Func<int> bodycREDITPOSITION = null, [WorkflowExpression] Func<string> bodycREDITREFERENCE = null, [WorkflowExpression] Func<int> bodycURRENCY = null, [WorkflowExpression] Func<string> bodydATECREDITAPPRECEIVED = null, [WorkflowExpression] Func<string> bodydEFNOMCODE = null, [WorkflowExpression] Func<int> bodydEFTAXCODE = null, [WorkflowExpression] Func<int> bodydEPTNUMBER = null, [WorkflowExpression] Func<int> bodydISCOUNTRATE = null, [WorkflowExpression] Func<int> bodydISCOUNTTYPE = null, [WorkflowExpression] Func<string> bodydUNSNUMBER = null, [WorkflowExpression] Func<string> bodyeMAIL = null, [WorkflowExpression] Func<string> bodyeMAIL2 = null, [WorkflowExpression] Func<string> bodyeMAIL3 = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyfAX = null, [WorkflowExpression] Func<bool> bodyhOLDMAIL = null, [WorkflowExpression] Func<bool> bodyiNACTIVEFLAG = null, [WorkflowExpression] Func<bool> bodyisACCOUNTREFAutogenerate = null, [WorkflowExpression] Func<string> bodylASTCREDITREV = null, [WorkflowExpression] Func<string> bodynAME = null, [WorkflowExpression] Func<string> bodynEXTCREDITREV = null, [WorkflowExpression] Func<bool> bodyoVERRIdEPRODUCTNOMINAL = null, [WorkflowExpression] Func<bool> bodyoVERRIdEPRODUCTTAX = null, [WorkflowExpression] Func<int> bodypAYMENTDUEDAYS = null, [WorkflowExpression] Func<string> bodypRICELISTREF = null, [WorkflowExpression] Func<bool> bodypRIORITYTRADER = null, [WorkflowExpression] Func<bool> bodysENDINVOICESELECTRONICALLY = null, [WorkflowExpression] Func<bool> bodysENDLETTERSELECTRONICALLY = null, [WorkflowExpression] Func<int> bodysETTLEMENTDISCRATE = null, [WorkflowExpression] Func<int> bodysETTLEMENTDUEDAYS = null, [WorkflowExpression] Func<string> bodytELEPHONE = null, [WorkflowExpression] Func<string> bodytELEPHONE2 = null, [WorkflowExpression] Func<string> bodytERMS = null, [WorkflowExpression] Func<bool> bodytERMSAGREEDFLAG = null, [WorkflowExpression] Func<string> bodytRADECONTACT = null, [WorkflowExpression] Func<string> bodyvATREGNUMBER = null)
        {
            SourceExpression.Validate(bodyaCCOUNTOPENED, nameof(bodyaCCOUNTOPENED), required: false);
            SourceExpression.Validate(bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            SourceExpression.Validate(bodyaCCOUNTSTATUS, nameof(bodyaCCOUNTSTATUS), required: false);
            SourceExpression.Validate(bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            SourceExpression.Validate(bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            SourceExpression.Validate(bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            SourceExpression.Validate(bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            SourceExpression.Validate(bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            SourceExpression.Validate(bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            SourceExpression.Validate(bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            SourceExpression.Validate(bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            SourceExpression.Validate(bodyaVERAGEPAYDAYS, nameof(bodyaVERAGEPAYDAYS), required: false);
            SourceExpression.Validate(bodybALANCE, nameof(bodybALANCE), required: false);
            SourceExpression.Validate(bodycANAPPLYCHARGES, nameof(bodycANAPPLYCHARGES), required: false);
            SourceExpression.Validate(bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            SourceExpression.Validate(bodycOUNTRYCODE, nameof(bodycOUNTRYCODE), required: false);
            SourceExpression.Validate(bodycREDITAPPLIEDFOR, nameof(bodycREDITAPPLIEDFOR), required: false);
            SourceExpression.Validate(bodycREDITBUREAU, nameof(bodycREDITBUREAU), required: false);
            SourceExpression.Validate(bodycREDITLIMIT, nameof(bodycREDITLIMIT), required: false);
            SourceExpression.Validate(bodycREDITPOSITION, nameof(bodycREDITPOSITION), required: false);
            SourceExpression.Validate(bodycREDITREFERENCE, nameof(bodycREDITREFERENCE), required: false);
            SourceExpression.Validate(bodycURRENCY, nameof(bodycURRENCY), required: false);
            SourceExpression.Validate(bodydATECREDITAPPRECEIVED, nameof(bodydATECREDITAPPRECEIVED), required: false);
            SourceExpression.Validate(bodydEFNOMCODE, nameof(bodydEFNOMCODE), required: false);
            SourceExpression.Validate(bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            SourceExpression.Validate(bodydEPTNUMBER, nameof(bodydEPTNUMBER), required: false);
            SourceExpression.Validate(bodydISCOUNTRATE, nameof(bodydISCOUNTRATE), required: false);
            SourceExpression.Validate(bodydISCOUNTTYPE, nameof(bodydISCOUNTTYPE), required: false);
            SourceExpression.Validate(bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            SourceExpression.Validate(bodyeMAIL, nameof(bodyeMAIL), required: false);
            SourceExpression.Validate(bodyeMAIL2, nameof(bodyeMAIL2), required: false);
            SourceExpression.Validate(bodyeMAIL3, nameof(bodyeMAIL3), required: false);
            SourceExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            SourceExpression.Validate(bodyfAX, nameof(bodyfAX), required: false);
            SourceExpression.Validate(bodyhOLDMAIL, nameof(bodyhOLDMAIL), required: false);
            SourceExpression.Validate(bodyiNACTIVEFLAG, nameof(bodyiNACTIVEFLAG), required: false);
            SourceExpression.Validate(bodyisACCOUNTREFAutogenerate, nameof(bodyisACCOUNTREFAutogenerate), required: false);
            SourceExpression.Validate(bodylASTCREDITREV, nameof(bodylASTCREDITREV), required: false);
            SourceExpression.Validate(bodynAME, nameof(bodynAME), required: false);
            SourceExpression.Validate(bodynEXTCREDITREV, nameof(bodynEXTCREDITREV), required: false);
            SourceExpression.Validate(bodyoVERRIdEPRODUCTNOMINAL, nameof(bodyoVERRIdEPRODUCTNOMINAL), required: false);
            SourceExpression.Validate(bodyoVERRIdEPRODUCTTAX, nameof(bodyoVERRIdEPRODUCTTAX), required: false);
            SourceExpression.Validate(bodypAYMENTDUEDAYS, nameof(bodypAYMENTDUEDAYS), required: false);
            SourceExpression.Validate(bodypRICELISTREF, nameof(bodypRICELISTREF), required: false);
            SourceExpression.Validate(bodypRIORITYTRADER, nameof(bodypRIORITYTRADER), required: false);
            SourceExpression.Validate(bodysENDINVOICESELECTRONICALLY, nameof(bodysENDINVOICESELECTRONICALLY), required: false);
            SourceExpression.Validate(bodysENDLETTERSELECTRONICALLY, nameof(bodysENDLETTERSELECTRONICALLY), required: false);
            SourceExpression.Validate(bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            SourceExpression.Validate(bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            SourceExpression.Validate(bodytELEPHONE, nameof(bodytELEPHONE), required: false);
            SourceExpression.Validate(bodytELEPHONE2, nameof(bodytELEPHONE2), required: false);
            SourceExpression.Validate(bodytERMS, nameof(bodytERMS), required: false);
            SourceExpression.Validate(bodytERMSAGREEDFLAG, nameof(bodytERMSAGREEDFLAG), required: false);
            SourceExpression.Validate(bodytRADECONTACT, nameof(bodytRADECONTACT), required: false);
            SourceExpression.Validate(bodyvATREGNUMBER, nameof(bodyvATREGNUMBER), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sage50uk/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaCCOUNTOPENED != null)
                {
                    body["ACCOUNT_OPENED"] = SourceExpressionConverter.ConvertToken(bodyaCCOUNTOPENED);
                    bodypropCount++;
                }

                if (bodyaCCOUNTREF != null)
                {
                    body["ACCOUNT_REF"] = SourceExpressionConverter.ConvertToken(bodyaCCOUNTREF);
                    bodypropCount++;
                }

                if (bodyaCCOUNTSTATUS != null)
                {
                    body["ACCOUNT_STATUS"] = SourceExpressionConverter.ConvertToken(bodyaCCOUNTSTATUS);
                    bodypropCount++;
                }

                if (bodyaDDRESS1 != null)
                {
                    body["ADDRESS_1"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS1);
                    bodypropCount++;
                }

                if (bodyaDDRESS2 != null)
                {
                    body["ADDRESS_2"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS2);
                    bodypropCount++;
                }

                if (bodyaDDRESS3 != null)
                {
                    body["ADDRESS_3"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS3);
                    bodypropCount++;
                }

                if (bodyaDDRESS4 != null)
                {
                    body["ADDRESS_4"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS4);
                    bodypropCount++;
                }

                if (bodyaDDRESS5 != null)
                {
                    body["ADDRESS_5"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS5);
                    bodypropCount++;
                }

                if (bodyaNALYSIS1 != null)
                {
                    body["ANALYSIS_1"] = SourceExpressionConverter.ConvertToken(bodyaNALYSIS1);
                    bodypropCount++;
                }

                if (bodyaNALYSIS2 != null)
                {
                    body["ANALYSIS_2"] = SourceExpressionConverter.ConvertToken(bodyaNALYSIS2);
                    bodypropCount++;
                }

                if (bodyaNALYSIS3 != null)
                {
                    body["ANALYSIS_3"] = SourceExpressionConverter.ConvertToken(bodyaNALYSIS3);
                    bodypropCount++;
                }

                if (bodyaVERAGEPAYDAYS != null)
                {
                    body["AVERAGE_PAY_DAYS"] = SourceExpressionConverter.ConvertToken(bodyaVERAGEPAYDAYS);
                    bodypropCount++;
                }

                if (bodybALANCE != null)
                {
                    body["BALANCE"] = SourceExpressionConverter.ConvertToken(bodybALANCE);
                    bodypropCount++;
                }

                if (bodycANAPPLYCHARGES != null)
                {
                    body["CAN_APPLY_CHARGES"] = SourceExpressionConverter.ConvertToken(bodycANAPPLYCHARGES);
                    bodypropCount++;
                }

                if (bodycONTACTNAME != null)
                {
                    body["CONTACT_NAME"] = SourceExpressionConverter.ConvertToken(bodycONTACTNAME);
                    bodypropCount++;
                }

                if (bodycOUNTRYCODE != null)
                {
                    body["COUNTRY_CODE"] = SourceExpressionConverter.ConvertToken(bodycOUNTRYCODE);
                    bodypropCount++;
                }

                if (bodycREDITAPPLIEDFOR != null)
                {
                    body["CREDIT_APPLIED_FOR"] = SourceExpressionConverter.ConvertToken(bodycREDITAPPLIEDFOR);
                    bodypropCount++;
                }

                if (bodycREDITBUREAU != null)
                {
                    body["CREDIT_BUREAU"] = SourceExpressionConverter.ConvertToken(bodycREDITBUREAU);
                    bodypropCount++;
                }

                if (bodycREDITLIMIT != null)
                {
                    body["CREDIT_LIMIT"] = SourceExpressionConverter.ConvertToken(bodycREDITLIMIT);
                    bodypropCount++;
                }

                if (bodycREDITPOSITION != null)
                {
                    body["CREDIT_POSITION"] = SourceExpressionConverter.ConvertToken(bodycREDITPOSITION);
                    bodypropCount++;
                }

                if (bodycREDITREFERENCE != null)
                {
                    body["CREDIT_REFERENCE"] = SourceExpressionConverter.ConvertToken(bodycREDITREFERENCE);
                    bodypropCount++;
                }

                if (bodycURRENCY != null)
                {
                    body["CURRENCY"] = SourceExpressionConverter.ConvertToken(bodycURRENCY);
                    bodypropCount++;
                }

                if (bodydATECREDITAPPRECEIVED != null)
                {
                    body["DATE_CREDIT_APP_RECEIVED"] = SourceExpressionConverter.ConvertToken(bodydATECREDITAPPRECEIVED);
                    bodypropCount++;
                }

                if (bodydEFNOMCODE != null)
                {
                    body["DEF_NOM_CODE"] = SourceExpressionConverter.ConvertToken(bodydEFNOMCODE);
                    bodypropCount++;
                }

                if (bodydEFTAXCODE != null)
                {
                    body["DEF_TAX_CODE"] = SourceExpressionConverter.ConvertToken(bodydEFTAXCODE);
                    bodypropCount++;
                }

                if (bodydEPTNUMBER != null)
                {
                    body["DEPT_NUMBER"] = SourceExpressionConverter.ConvertToken(bodydEPTNUMBER);
                    bodypropCount++;
                }

                if (bodydISCOUNTRATE != null)
                {
                    body["DISCOUNT_RATE"] = SourceExpressionConverter.ConvertToken(bodydISCOUNTRATE);
                    bodypropCount++;
                }

                if (bodydISCOUNTTYPE != null)
                {
                    body["DISCOUNT_TYPE"] = SourceExpressionConverter.ConvertToken(bodydISCOUNTTYPE);
                    bodypropCount++;
                }

                if (bodydUNSNUMBER != null)
                {
                    body["DUNS_NUMBER"] = SourceExpressionConverter.ConvertToken(bodydUNSNUMBER);
                    bodypropCount++;
                }

                if (bodyeMAIL != null)
                {
                    body["E_MAIL"] = SourceExpressionConverter.ConvertToken(bodyeMAIL);
                    bodypropCount++;
                }

                if (bodyeMAIL2 != null)
                {
                    body["E_MAIL2"] = SourceExpressionConverter.ConvertToken(bodyeMAIL2);
                    bodypropCount++;
                }

                if (bodyeMAIL3 != null)
                {
                    body["E_MAIL3"] = SourceExpressionConverter.ConvertToken(bodyeMAIL3);
                    bodypropCount++;
                }

                if (bodyextraField != null)
                {
                    body["ExtraField"] = SourceExpressionConverter.ConvertToken(bodyextraField);
                    bodypropCount++;
                }

                if (bodyfAX != null)
                {
                    body["FAX"] = SourceExpressionConverter.ConvertToken(bodyfAX);
                    bodypropCount++;
                }

                if (bodyhOLDMAIL != null)
                {
                    body["HOLD_MAIL"] = SourceExpressionConverter.ConvertToken(bodyhOLDMAIL);
                    bodypropCount++;
                }

                if (bodyiNACTIVEFLAG != null)
                {
                    body["INACTIVE_FLAG"] = SourceExpressionConverter.ConvertToken(bodyiNACTIVEFLAG);
                    bodypropCount++;
                }

                if (bodyisACCOUNTREFAutogenerate != null)
                {
                    body["IsACCOUNT_REF_autogenerate"] = SourceExpressionConverter.ConvertToken(bodyisACCOUNTREFAutogenerate);
                    bodypropCount++;
                }

                if (bodylASTCREDITREV != null)
                {
                    body["LAST_CREDIT_REV"] = SourceExpressionConverter.ConvertToken(bodylASTCREDITREV);
                    bodypropCount++;
                }

                if (bodynAME != null)
                {
                    body["NAME"] = SourceExpressionConverter.ConvertToken(bodynAME);
                    bodypropCount++;
                }

                if (bodynEXTCREDITREV != null)
                {
                    body["NEXT_CREDIT_REV"] = SourceExpressionConverter.ConvertToken(bodynEXTCREDITREV);
                    bodypropCount++;
                }

                if (bodyoVERRIdEPRODUCTNOMINAL != null)
                {
                    body["OVERRIDE_PRODUCT_NOMINAL"] = SourceExpressionConverter.ConvertToken(bodyoVERRIdEPRODUCTNOMINAL);
                    bodypropCount++;
                }

                if (bodyoVERRIdEPRODUCTTAX != null)
                {
                    body["OVERRIDE_PRODUCT_TAX"] = SourceExpressionConverter.ConvertToken(bodyoVERRIdEPRODUCTTAX);
                    bodypropCount++;
                }

                if (bodypAYMENTDUEDAYS != null)
                {
                    body["PAYMENT_DUE_DAYS"] = SourceExpressionConverter.ConvertToken(bodypAYMENTDUEDAYS);
                    bodypropCount++;
                }

                if (bodypRICELISTREF != null)
                {
                    body["PRICE_LIST_REF"] = SourceExpressionConverter.ConvertToken(bodypRICELISTREF);
                    bodypropCount++;
                }

                if (bodypRIORITYTRADER != null)
                {
                    body["PRIORITY_TRADER"] = SourceExpressionConverter.ConvertToken(bodypRIORITYTRADER);
                    bodypropCount++;
                }

                if (bodysENDINVOICESELECTRONICALLY != null)
                {
                    body["SEND_INVOICES_ELECTRONICALLY"] = SourceExpressionConverter.ConvertToken(bodysENDINVOICESELECTRONICALLY);
                    bodypropCount++;
                }

                if (bodysENDLETTERSELECTRONICALLY != null)
                {
                    body["SEND_LETTERS_ELECTRONICALLY"] = SourceExpressionConverter.ConvertToken(bodysENDLETTERSELECTRONICALLY);
                    bodypropCount++;
                }

                if (bodysETTLEMENTDISCRATE != null)
                {
                    body["SETTLEMENT_DISC_RATE"] = SourceExpressionConverter.ConvertToken(bodysETTLEMENTDISCRATE);
                    bodypropCount++;
                }

                if (bodysETTLEMENTDUEDAYS != null)
                {
                    body["SETTLEMENT_DUE_DAYS"] = SourceExpressionConverter.ConvertToken(bodysETTLEMENTDUEDAYS);
                    bodypropCount++;
                }

                if (bodytELEPHONE != null)
                {
                    body["TELEPHONE"] = SourceExpressionConverter.ConvertToken(bodytELEPHONE);
                    bodypropCount++;
                }

                if (bodytELEPHONE2 != null)
                {
                    body["TELEPHONE_2"] = SourceExpressionConverter.ConvertToken(bodytELEPHONE2);
                    bodypropCount++;
                }

                if (bodytERMS != null)
                {
                    body["TERMS"] = SourceExpressionConverter.ConvertToken(bodytERMS);
                    bodypropCount++;
                }

                if (bodytERMSAGREEDFLAG != null)
                {
                    body["TERMS_AGREED_FLAG"] = SourceExpressionConverter.ConvertToken(bodytERMSAGREEDFLAG);
                    bodypropCount++;
                }

                if (bodytRADECONTACT != null)
                {
                    body["TRADE_CONTACT"] = SourceExpressionConverter.ConvertToken(bodytRADECONTACT);
                    bodypropCount++;
                }

                if (bodyvATREGNUMBER != null)
                {
                    body["VAT_REG_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyvATREGNUMBER);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAGE50UKCreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50UKCreateNewSalesOrderResponse> SAGE50UKCreateNewSalesOrder([WorkflowExpression] Func<string> bodyaCCOUNTREF = null, [WorkflowExpression] Func<string> bodyaDDRESS1 = null, [WorkflowExpression] Func<string> bodyaDDRESS2 = null, [WorkflowExpression] Func<string> bodyaDDRESS3 = null, [WorkflowExpression] Func<string> bodyaDDRESS4 = null, [WorkflowExpression] Func<string> bodyaDDRESS5 = null, [WorkflowExpression] Func<int> bodyaMOUNTPREPAId = null, [WorkflowExpression] Func<string> bodyaNALYSIS1 = null, [WorkflowExpression] Func<string> bodyaNALYSIS2 = null, [WorkflowExpression] Func<string> bodyaNALYSIS3 = null, [WorkflowExpression] Func<int> bodycARRDEPTNUMBER = null, [WorkflowExpression] Func<int> bodycARRNET = null, [WorkflowExpression] Func<string> bodycARRNOMCODE = null, [WorkflowExpression] Func<int> bodycARRTAX = null, [WorkflowExpression] Func<int> bodycARRTAXCODE = null, [WorkflowExpression] Func<string> bodycONSIGNMENTREF = null, [WorkflowExpression] Func<string> bodycONTACTNAME = null, [WorkflowExpression] Func<int> bodycOURIER = null, [WorkflowExpression] Func<int> bodycURRENCY = null, [WorkflowExpression] Func<int> bodycUSTDISCRATE = null, [WorkflowExpression] Func<string> bodycUSTORDERNUMBER = null, [WorkflowExpression] Func<string> bodycUSTTELNUMBER = null, [WorkflowExpression] Func<int> bodydEFTAXCODE = null, [WorkflowExpression] Func<bool> bodydELETEDFLAG = null, [WorkflowExpression] Func<string> bodydELIVERYNAME = null, [WorkflowExpression] Func<string> bodydELADDRESS1 = null, [WorkflowExpression] Func<string> bodydELADDRESS2 = null, [WorkflowExpression] Func<string> bodydELADDRESS3 = null, [WorkflowExpression] Func<string> bodydELADDRESS4 = null, [WorkflowExpression] Func<string> bodydELADDRESS5 = null, [WorkflowExpression] Func<string> bodydESPATCHDATE = null, [WorkflowExpression] Func<string> bodydUNSNUMBER = null, [WorkflowExpression] Func<int> bodygLOBALDEPTNUMBER = null, [WorkflowExpression] Func<string> bodygLOBALDETAILS = null, [WorkflowExpression] Func<string> bodygLOBALNOMCODE = null, [WorkflowExpression] Func<int> bodygLOBALTAXCODE = null, [WorkflowExpression] Func<string> bodyiNVOICENUMBER = null, [WorkflowExpression] Func<string> bodynAME = null, [WorkflowExpression] Func<string> bodyoRDERDATE = null, [WorkflowExpression] Func<int> bodyoRDERNUMBER = null, [WorkflowExpression] Func<int> bodyoRDERTYPE = null, [WorkflowExpression] Func<int> bodysETTLEMENTDISCRATE = null, [WorkflowExpression] Func<int> bodysETTLEMENTDUEDAYS = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem222[]> bodysalesOrderLineItem = null)
        {
            SourceExpression.Validate(bodyaCCOUNTREF, nameof(bodyaCCOUNTREF), required: false);
            SourceExpression.Validate(bodyaDDRESS1, nameof(bodyaDDRESS1), required: false);
            SourceExpression.Validate(bodyaDDRESS2, nameof(bodyaDDRESS2), required: false);
            SourceExpression.Validate(bodyaDDRESS3, nameof(bodyaDDRESS3), required: false);
            SourceExpression.Validate(bodyaDDRESS4, nameof(bodyaDDRESS4), required: false);
            SourceExpression.Validate(bodyaDDRESS5, nameof(bodyaDDRESS5), required: false);
            SourceExpression.Validate(bodyaMOUNTPREPAId, nameof(bodyaMOUNTPREPAId), required: false);
            SourceExpression.Validate(bodyaNALYSIS1, nameof(bodyaNALYSIS1), required: false);
            SourceExpression.Validate(bodyaNALYSIS2, nameof(bodyaNALYSIS2), required: false);
            SourceExpression.Validate(bodyaNALYSIS3, nameof(bodyaNALYSIS3), required: false);
            SourceExpression.Validate(bodycARRDEPTNUMBER, nameof(bodycARRDEPTNUMBER), required: false);
            SourceExpression.Validate(bodycARRNET, nameof(bodycARRNET), required: false);
            SourceExpression.Validate(bodycARRNOMCODE, nameof(bodycARRNOMCODE), required: false);
            SourceExpression.Validate(bodycARRTAX, nameof(bodycARRTAX), required: false);
            SourceExpression.Validate(bodycARRTAXCODE, nameof(bodycARRTAXCODE), required: false);
            SourceExpression.Validate(bodycONSIGNMENTREF, nameof(bodycONSIGNMENTREF), required: false);
            SourceExpression.Validate(bodycONTACTNAME, nameof(bodycONTACTNAME), required: false);
            SourceExpression.Validate(bodycOURIER, nameof(bodycOURIER), required: false);
            SourceExpression.Validate(bodycURRENCY, nameof(bodycURRENCY), required: false);
            SourceExpression.Validate(bodycUSTDISCRATE, nameof(bodycUSTDISCRATE), required: false);
            SourceExpression.Validate(bodycUSTORDERNUMBER, nameof(bodycUSTORDERNUMBER), required: false);
            SourceExpression.Validate(bodycUSTTELNUMBER, nameof(bodycUSTTELNUMBER), required: false);
            SourceExpression.Validate(bodydEFTAXCODE, nameof(bodydEFTAXCODE), required: false);
            SourceExpression.Validate(bodydELETEDFLAG, nameof(bodydELETEDFLAG), required: false);
            SourceExpression.Validate(bodydELIVERYNAME, nameof(bodydELIVERYNAME), required: false);
            SourceExpression.Validate(bodydELADDRESS1, nameof(bodydELADDRESS1), required: false);
            SourceExpression.Validate(bodydELADDRESS2, nameof(bodydELADDRESS2), required: false);
            SourceExpression.Validate(bodydELADDRESS3, nameof(bodydELADDRESS3), required: false);
            SourceExpression.Validate(bodydELADDRESS4, nameof(bodydELADDRESS4), required: false);
            SourceExpression.Validate(bodydELADDRESS5, nameof(bodydELADDRESS5), required: false);
            SourceExpression.Validate(bodydESPATCHDATE, nameof(bodydESPATCHDATE), required: false);
            SourceExpression.Validate(bodydUNSNUMBER, nameof(bodydUNSNUMBER), required: false);
            SourceExpression.Validate(bodygLOBALDEPTNUMBER, nameof(bodygLOBALDEPTNUMBER), required: false);
            SourceExpression.Validate(bodygLOBALDETAILS, nameof(bodygLOBALDETAILS), required: false);
            SourceExpression.Validate(bodygLOBALNOMCODE, nameof(bodygLOBALNOMCODE), required: false);
            SourceExpression.Validate(bodygLOBALTAXCODE, nameof(bodygLOBALTAXCODE), required: false);
            SourceExpression.Validate(bodyiNVOICENUMBER, nameof(bodyiNVOICENUMBER), required: false);
            SourceExpression.Validate(bodynAME, nameof(bodynAME), required: false);
            SourceExpression.Validate(bodyoRDERDATE, nameof(bodyoRDERDATE), required: false);
            SourceExpression.Validate(bodyoRDERNUMBER, nameof(bodyoRDERNUMBER), required: false);
            SourceExpression.Validate(bodyoRDERTYPE, nameof(bodyoRDERTYPE), required: false);
            SourceExpression.Validate(bodysETTLEMENTDISCRATE, nameof(bodysETTLEMENTDISCRATE), required: false);
            SourceExpression.Validate(bodysETTLEMENTDUEDAYS, nameof(bodysETTLEMENTDUEDAYS), required: false);
            SourceExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sage50uk/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaCCOUNTREF != null)
                {
                    body["ACCOUNT_REF"] = SourceExpressionConverter.ConvertToken(bodyaCCOUNTREF);
                    bodypropCount++;
                }

                if (bodyaDDRESS1 != null)
                {
                    body["ADDRESS_1"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS1);
                    bodypropCount++;
                }

                if (bodyaDDRESS2 != null)
                {
                    body["ADDRESS_2"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS2);
                    bodypropCount++;
                }

                if (bodyaDDRESS3 != null)
                {
                    body["ADDRESS_3"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS3);
                    bodypropCount++;
                }

                if (bodyaDDRESS4 != null)
                {
                    body["ADDRESS_4"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS4);
                    bodypropCount++;
                }

                if (bodyaDDRESS5 != null)
                {
                    body["ADDRESS_5"] = SourceExpressionConverter.ConvertToken(bodyaDDRESS5);
                    bodypropCount++;
                }

                if (bodyaMOUNTPREPAId != null)
                {
                    body["AMOUNT_PREPAID"] = SourceExpressionConverter.ConvertToken(bodyaMOUNTPREPAId);
                    bodypropCount++;
                }

                if (bodyaNALYSIS1 != null)
                {
                    body["ANALYSIS_1"] = SourceExpressionConverter.ConvertToken(bodyaNALYSIS1);
                    bodypropCount++;
                }

                if (bodyaNALYSIS2 != null)
                {
                    body["ANALYSIS_2"] = SourceExpressionConverter.ConvertToken(bodyaNALYSIS2);
                    bodypropCount++;
                }

                if (bodyaNALYSIS3 != null)
                {
                    body["ANALYSIS_3"] = SourceExpressionConverter.ConvertToken(bodyaNALYSIS3);
                    bodypropCount++;
                }

                if (bodycARRDEPTNUMBER != null)
                {
                    body["CARR_DEPT_NUMBER"] = SourceExpressionConverter.ConvertToken(bodycARRDEPTNUMBER);
                    bodypropCount++;
                }

                if (bodycARRNET != null)
                {
                    body["CARR_NET"] = SourceExpressionConverter.ConvertToken(bodycARRNET);
                    bodypropCount++;
                }

                if (bodycARRNOMCODE != null)
                {
                    body["CARR_NOM_CODE"] = SourceExpressionConverter.ConvertToken(bodycARRNOMCODE);
                    bodypropCount++;
                }

                if (bodycARRTAX != null)
                {
                    body["CARR_TAX"] = SourceExpressionConverter.ConvertToken(bodycARRTAX);
                    bodypropCount++;
                }

                if (bodycARRTAXCODE != null)
                {
                    body["CARR_TAX_CODE"] = SourceExpressionConverter.ConvertToken(bodycARRTAXCODE);
                    bodypropCount++;
                }

                if (bodycONSIGNMENTREF != null)
                {
                    body["CONSIGNMENT_REF"] = SourceExpressionConverter.ConvertToken(bodycONSIGNMENTREF);
                    bodypropCount++;
                }

                if (bodycONTACTNAME != null)
                {
                    body["CONTACT_NAME"] = SourceExpressionConverter.ConvertToken(bodycONTACTNAME);
                    bodypropCount++;
                }

                if (bodycOURIER != null)
                {
                    body["COURIER"] = SourceExpressionConverter.ConvertToken(bodycOURIER);
                    bodypropCount++;
                }

                if (bodycURRENCY != null)
                {
                    body["CURRENCY"] = SourceExpressionConverter.ConvertToken(bodycURRENCY);
                    bodypropCount++;
                }

                if (bodycUSTDISCRATE != null)
                {
                    body["CUST_DISC_RATE"] = SourceExpressionConverter.ConvertToken(bodycUSTDISCRATE);
                    bodypropCount++;
                }

                if (bodycUSTORDERNUMBER != null)
                {
                    body["CUST_ORDER_NUMBER"] = SourceExpressionConverter.ConvertToken(bodycUSTORDERNUMBER);
                    bodypropCount++;
                }

                if (bodycUSTTELNUMBER != null)
                {
                    body["CUST_TEL_NUMBER"] = SourceExpressionConverter.ConvertToken(bodycUSTTELNUMBER);
                    bodypropCount++;
                }

                if (bodydEFTAXCODE != null)
                {
                    body["DEF_TAX_CODE"] = SourceExpressionConverter.ConvertToken(bodydEFTAXCODE);
                    bodypropCount++;
                }

                if (bodydELETEDFLAG != null)
                {
                    body["DELETED_FLAG"] = SourceExpressionConverter.ConvertToken(bodydELETEDFLAG);
                    bodypropCount++;
                }

                if (bodydELIVERYNAME != null)
                {
                    body["DELIVERY_NAME"] = SourceExpressionConverter.ConvertToken(bodydELIVERYNAME);
                    bodypropCount++;
                }

                if (bodydELADDRESS1 != null)
                {
                    body["DEL_ADDRESS_1"] = SourceExpressionConverter.ConvertToken(bodydELADDRESS1);
                    bodypropCount++;
                }

                if (bodydELADDRESS2 != null)
                {
                    body["DEL_ADDRESS_2"] = SourceExpressionConverter.ConvertToken(bodydELADDRESS2);
                    bodypropCount++;
                }

                if (bodydELADDRESS3 != null)
                {
                    body["DEL_ADDRESS_3"] = SourceExpressionConverter.ConvertToken(bodydELADDRESS3);
                    bodypropCount++;
                }

                if (bodydELADDRESS4 != null)
                {
                    body["DEL_ADDRESS_4"] = SourceExpressionConverter.ConvertToken(bodydELADDRESS4);
                    bodypropCount++;
                }

                if (bodydELADDRESS5 != null)
                {
                    body["DEL_ADDRESS_5"] = SourceExpressionConverter.ConvertToken(bodydELADDRESS5);
                    bodypropCount++;
                }

                if (bodydESPATCHDATE != null)
                {
                    body["DESPATCH_DATE"] = SourceExpressionConverter.ConvertToken(bodydESPATCHDATE);
                    bodypropCount++;
                }

                if (bodydUNSNUMBER != null)
                {
                    body["DUNS_NUMBER"] = SourceExpressionConverter.ConvertToken(bodydUNSNUMBER);
                    bodypropCount++;
                }

                if (bodygLOBALDEPTNUMBER != null)
                {
                    body["GLOBAL_DEPT_NUMBER"] = SourceExpressionConverter.ConvertToken(bodygLOBALDEPTNUMBER);
                    bodypropCount++;
                }

                if (bodygLOBALDETAILS != null)
                {
                    body["GLOBAL_DETAILS"] = SourceExpressionConverter.ConvertToken(bodygLOBALDETAILS);
                    bodypropCount++;
                }

                if (bodygLOBALNOMCODE != null)
                {
                    body["GLOBAL_NOM_CODE"] = SourceExpressionConverter.ConvertToken(bodygLOBALNOMCODE);
                    bodypropCount++;
                }

                if (bodygLOBALTAXCODE != null)
                {
                    body["GLOBAL_TAX_CODE"] = SourceExpressionConverter.ConvertToken(bodygLOBALTAXCODE);
                    bodypropCount++;
                }

                if (bodyiNVOICENUMBER != null)
                {
                    body["INVOICE_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyiNVOICENUMBER);
                    bodypropCount++;
                }

                if (bodynAME != null)
                {
                    body["NAME"] = SourceExpressionConverter.ConvertToken(bodynAME);
                    bodypropCount++;
                }

                if (bodyoRDERDATE != null)
                {
                    body["ORDER_DATE"] = SourceExpressionConverter.ConvertToken(bodyoRDERDATE);
                    bodypropCount++;
                }

                if (bodyoRDERNUMBER != null)
                {
                    body["ORDER_NUMBER"] = SourceExpressionConverter.ConvertToken(bodyoRDERNUMBER);
                    bodypropCount++;
                }

                if (bodyoRDERTYPE != null)
                {
                    body["ORDER_TYPE"] = SourceExpressionConverter.ConvertToken(bodyoRDERTYPE);
                    bodypropCount++;
                }

                if (bodysETTLEMENTDISCRATE != null)
                {
                    body["SETTLEMENT_DISC_RATE"] = SourceExpressionConverter.ConvertToken(bodysETTLEMENTDISCRATE);
                    bodypropCount++;
                }

                if (bodysETTLEMENTDUEDAYS != null)
                {
                    body["SETTLEMENT_DUE_DAYS"] = SourceExpressionConverter.ConvertToken(bodysETTLEMENTDUEDAYS);
                    bodypropCount++;
                }

                if (bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = SourceExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAGE50UKCreateNewSalesOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50USCreateNewCustomerResponse> SAGE50USCreateNewCustomer([WorkflowExpression] Func<string> bodyaccountNumber = null, [WorkflowExpression] Func<string> bodybillingCity = null, [WorkflowExpression] Func<string> bodybillingCountry = null, [WorkflowExpression] Func<string> bodybillingLastName = null, [WorkflowExpression] Func<string> bodybillingName = null, [WorkflowExpression] Func<string> bodybillingPostalCode = null, [WorkflowExpression] Func<string> bodybillingState = null, [WorkflowExpression] Func<string> bodybillingStreet = null, [WorkflowExpression] Func<bool> bodycCSalesRepresentative = null, [WorkflowExpression] Func<bool> bodychargeFinanceCharges = null, [WorkflowExpression] Func<string> bodycontactName = null, [WorkflowExpression] Func<int> bodycreditLimit = null, [WorkflowExpression] Func<int> bodycreditStatus = null, [WorkflowExpression] Func<string> bodycustomFieldValue1 = null, [WorkflowExpression] Func<string> bodycustomFieldValue2 = null, [WorkflowExpression] Func<string> bodycustomFieldValue3 = null, [WorkflowExpression] Func<string> bodycustomFieldValue4 = null, [WorkflowExpression] Func<string> bodycustomFieldValue5 = null, [WorkflowExpression] Func<string> bodycustomerGUID = null, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<int> bodycustomerBalance = null, [WorkflowExpression] Func<string> bodycustomerSinceDate = null, [WorkflowExpression] Func<string> bodycustomerType = null, [WorkflowExpression] Func<int> bodydiscountDays = null, [WorkflowExpression] Func<int> bodydiscountPercent = null, [WorkflowExpression] Func<int> bodydueDays = null, [WorkflowExpression] Func<string> bodyeMailAddress = null, [WorkflowExpression] Func<string> bodyfaxNumber = null, [WorkflowExpression] Func<int> bodyformDeliveryMethod = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyphoneNo1 = null, [WorkflowExpression] Func<string> bodyphoneNo2 = null, [WorkflowExpression] Func<int> bodypricingLevel = null, [WorkflowExpression] Func<string> bodysalesRepresentativeId = null, [WorkflowExpression] Func<string> bodysalesTaxCode = null, [WorkflowExpression] Func<string> bodyshippingCity = null, [WorkflowExpression] Func<string> bodyshippingCountry = null, [WorkflowExpression] Func<string> bodyshippingPostalCode = null, [WorkflowExpression] Func<string> bodyshippingState = null, [WorkflowExpression] Func<string> bodyshippingStreet = null, [WorkflowExpression] Func<bool> bodytermsType = null, [WorkflowExpression] Func<bool> bodyuseCODTerms = null, [WorkflowExpression] Func<bool> bodyuseDueMonthEndTerms = null, [WorkflowExpression] Func<bool> bodyusePrepaidTerms = null, [WorkflowExpression] Func<bool> bodyuseStandardTerms = null, [WorkflowExpression] Func<bool> bodyisInactive = null)
        {
            SourceExpression.Validate(bodyaccountNumber, nameof(bodyaccountNumber), required: false);
            SourceExpression.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            SourceExpression.Validate(bodybillingCountry, nameof(bodybillingCountry), required: false);
            SourceExpression.Validate(bodybillingLastName, nameof(bodybillingLastName), required: false);
            SourceExpression.Validate(bodybillingName, nameof(bodybillingName), required: false);
            SourceExpression.Validate(bodybillingPostalCode, nameof(bodybillingPostalCode), required: false);
            SourceExpression.Validate(bodybillingState, nameof(bodybillingState), required: false);
            SourceExpression.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            SourceExpression.Validate(bodycCSalesRepresentative, nameof(bodycCSalesRepresentative), required: false);
            SourceExpression.Validate(bodychargeFinanceCharges, nameof(bodychargeFinanceCharges), required: false);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: false);
            SourceExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            SourceExpression.Validate(bodycreditStatus, nameof(bodycreditStatus), required: false);
            SourceExpression.Validate(bodycustomFieldValue1, nameof(bodycustomFieldValue1), required: false);
            SourceExpression.Validate(bodycustomFieldValue2, nameof(bodycustomFieldValue2), required: false);
            SourceExpression.Validate(bodycustomFieldValue3, nameof(bodycustomFieldValue3), required: false);
            SourceExpression.Validate(bodycustomFieldValue4, nameof(bodycustomFieldValue4), required: false);
            SourceExpression.Validate(bodycustomFieldValue5, nameof(bodycustomFieldValue5), required: false);
            SourceExpression.Validate(bodycustomerGUID, nameof(bodycustomerGUID), required: false);
            SourceExpression.Validate(bodycustomerId, nameof(bodycustomerId), required: false);
            SourceExpression.Validate(bodycustomerBalance, nameof(bodycustomerBalance), required: false);
            SourceExpression.Validate(bodycustomerSinceDate, nameof(bodycustomerSinceDate), required: false);
            SourceExpression.Validate(bodycustomerType, nameof(bodycustomerType), required: false);
            SourceExpression.Validate(bodydiscountDays, nameof(bodydiscountDays), required: false);
            SourceExpression.Validate(bodydiscountPercent, nameof(bodydiscountPercent), required: false);
            SourceExpression.Validate(bodydueDays, nameof(bodydueDays), required: false);
            SourceExpression.Validate(bodyeMailAddress, nameof(bodyeMailAddress), required: false);
            SourceExpression.Validate(bodyfaxNumber, nameof(bodyfaxNumber), required: false);
            SourceExpression.Validate(bodyformDeliveryMethod, nameof(bodyformDeliveryMethod), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyphoneNo1, nameof(bodyphoneNo1), required: false);
            SourceExpression.Validate(bodyphoneNo2, nameof(bodyphoneNo2), required: false);
            SourceExpression.Validate(bodypricingLevel, nameof(bodypricingLevel), required: false);
            SourceExpression.Validate(bodysalesRepresentativeId, nameof(bodysalesRepresentativeId), required: false);
            SourceExpression.Validate(bodysalesTaxCode, nameof(bodysalesTaxCode), required: false);
            SourceExpression.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            SourceExpression.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            SourceExpression.Validate(bodyshippingPostalCode, nameof(bodyshippingPostalCode), required: false);
            SourceExpression.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            SourceExpression.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            SourceExpression.Validate(bodytermsType, nameof(bodytermsType), required: false);
            SourceExpression.Validate(bodyuseCODTerms, nameof(bodyuseCODTerms), required: false);
            SourceExpression.Validate(bodyuseDueMonthEndTerms, nameof(bodyuseDueMonthEndTerms), required: false);
            SourceExpression.Validate(bodyusePrepaidTerms, nameof(bodyusePrepaidTerms), required: false);
            SourceExpression.Validate(bodyuseStandardTerms, nameof(bodyuseStandardTerms), required: false);
            SourceExpression.Validate(bodyisInactive, nameof(bodyisInactive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sage50us/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountNumber != null)
                {
                    body["Account_Number"] = SourceExpressionConverter.ConvertToken(bodyaccountNumber);
                    bodypropCount++;
                }

                if (bodybillingCity != null)
                {
                    body["BillingCity"] = SourceExpressionConverter.ConvertToken(bodybillingCity);
                    bodypropCount++;
                }

                if (bodybillingCountry != null)
                {
                    body["BillingCountry"] = SourceExpressionConverter.ConvertToken(bodybillingCountry);
                    bodypropCount++;
                }

                if (bodybillingLastName != null)
                {
                    body["BillingLastName"] = SourceExpressionConverter.ConvertToken(bodybillingLastName);
                    bodypropCount++;
                }

                if (bodybillingName != null)
                {
                    body["BillingName"] = SourceExpressionConverter.ConvertToken(bodybillingName);
                    bodypropCount++;
                }

                if (bodybillingPostalCode != null)
                {
                    body["BillingPostalCode"] = SourceExpressionConverter.ConvertToken(bodybillingPostalCode);
                    bodypropCount++;
                }

                if (bodybillingState != null)
                {
                    body["BillingState"] = SourceExpressionConverter.ConvertToken(bodybillingState);
                    bodypropCount++;
                }

                if (bodybillingStreet != null)
                {
                    body["BillingStreet"] = SourceExpressionConverter.ConvertToken(bodybillingStreet);
                    bodypropCount++;
                }

                if (bodycCSalesRepresentative != null)
                {
                    body["CC_Sales_Representative"] = SourceExpressionConverter.ConvertToken(bodycCSalesRepresentative);
                    bodypropCount++;
                }

                if (bodychargeFinanceCharges != null)
                {
                    body["Charge_Finance_Charges"] = SourceExpressionConverter.ConvertToken(bodychargeFinanceCharges);
                    bodypropCount++;
                }

                if (bodycontactName != null)
                {
                    body["ContactName"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                    bodypropCount++;
                }

                if (bodycreditLimit != null)
                {
                    body["Credit_Limit"] = SourceExpressionConverter.ConvertToken(bodycreditLimit);
                    bodypropCount++;
                }

                if (bodycreditStatus != null)
                {
                    body["Credit_Status"] = SourceExpressionConverter.ConvertToken(bodycreditStatus);
                    bodypropCount++;
                }

                if (bodycustomFieldValue1 != null)
                {
                    body["CustomFieldValue1"] = SourceExpressionConverter.ConvertToken(bodycustomFieldValue1);
                    bodypropCount++;
                }

                if (bodycustomFieldValue2 != null)
                {
                    body["CustomFieldValue2"] = SourceExpressionConverter.ConvertToken(bodycustomFieldValue2);
                    bodypropCount++;
                }

                if (bodycustomFieldValue3 != null)
                {
                    body["CustomFieldValue3"] = SourceExpressionConverter.ConvertToken(bodycustomFieldValue3);
                    bodypropCount++;
                }

                if (bodycustomFieldValue4 != null)
                {
                    body["CustomFieldValue4"] = SourceExpressionConverter.ConvertToken(bodycustomFieldValue4);
                    bodypropCount++;
                }

                if (bodycustomFieldValue5 != null)
                {
                    body["CustomFieldValue5"] = SourceExpressionConverter.ConvertToken(bodycustomFieldValue5);
                    bodypropCount++;
                }

                if (bodycustomerGUID != null)
                {
                    body["CustomerGUID"] = SourceExpressionConverter.ConvertToken(bodycustomerGUID);
                    bodypropCount++;
                }

                if (bodycustomerId != null)
                {
                    body["CustomerID"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodycustomerBalance != null)
                {
                    body["Customer_Balance"] = SourceExpressionConverter.ConvertToken(bodycustomerBalance);
                    bodypropCount++;
                }

                if (bodycustomerSinceDate != null)
                {
                    body["Customer_Since_Date"] = SourceExpressionConverter.ConvertToken(bodycustomerSinceDate);
                    bodypropCount++;
                }

                if (bodycustomerType != null)
                {
                    body["Customer_Type"] = SourceExpressionConverter.ConvertToken(bodycustomerType);
                    bodypropCount++;
                }

                if (bodydiscountDays != null)
                {
                    body["Discount_Days"] = SourceExpressionConverter.ConvertToken(bodydiscountDays);
                    bodypropCount++;
                }

                if (bodydiscountPercent != null)
                {
                    body["Discount_Percent"] = SourceExpressionConverter.ConvertToken(bodydiscountPercent);
                    bodypropCount++;
                }

                if (bodydueDays != null)
                {
                    body["Due_Days"] = SourceExpressionConverter.ConvertToken(bodydueDays);
                    bodypropCount++;
                }

                if (bodyeMailAddress != null)
                {
                    body["EMail_Address"] = SourceExpressionConverter.ConvertToken(bodyeMailAddress);
                    bodypropCount++;
                }

                if (bodyfaxNumber != null)
                {
                    body["FaxNumber"] = SourceExpressionConverter.ConvertToken(bodyfaxNumber);
                    bodypropCount++;
                }

                if (bodyformDeliveryMethod != null)
                {
                    body["Form_Delivery_Method"] = SourceExpressionConverter.ConvertToken(bodyformDeliveryMethod);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyphoneNo1 != null)
                {
                    body["PhoneNo1"] = SourceExpressionConverter.ConvertToken(bodyphoneNo1);
                    bodypropCount++;
                }

                if (bodyphoneNo2 != null)
                {
                    body["PhoneNo2"] = SourceExpressionConverter.ConvertToken(bodyphoneNo2);
                    bodypropCount++;
                }

                if (bodypricingLevel != null)
                {
                    body["Pricing_Level"] = SourceExpressionConverter.ConvertToken(bodypricingLevel);
                    bodypropCount++;
                }

                if (bodysalesRepresentativeId != null)
                {
                    body["Sales_Representative_ID"] = SourceExpressionConverter.ConvertToken(bodysalesRepresentativeId);
                    bodypropCount++;
                }

                if (bodysalesTaxCode != null)
                {
                    body["Sales_Tax_Code"] = SourceExpressionConverter.ConvertToken(bodysalesTaxCode);
                    bodypropCount++;
                }

                if (bodyshippingCity != null)
                {
                    body["ShippingCity"] = SourceExpressionConverter.ConvertToken(bodyshippingCity);
                    bodypropCount++;
                }

                if (bodyshippingCountry != null)
                {
                    body["ShippingCountry"] = SourceExpressionConverter.ConvertToken(bodyshippingCountry);
                    bodypropCount++;
                }

                if (bodyshippingPostalCode != null)
                {
                    body["ShippingPostalCode"] = SourceExpressionConverter.ConvertToken(bodyshippingPostalCode);
                    bodypropCount++;
                }

                if (bodyshippingState != null)
                {
                    body["ShippingState"] = SourceExpressionConverter.ConvertToken(bodyshippingState);
                    bodypropCount++;
                }

                if (bodyshippingStreet != null)
                {
                    body["ShippingStreet"] = SourceExpressionConverter.ConvertToken(bodyshippingStreet);
                    bodypropCount++;
                }

                if (bodytermsType != null)
                {
                    body["Terms_Type"] = SourceExpressionConverter.ConvertToken(bodytermsType);
                    bodypropCount++;
                }

                if (bodyuseCODTerms != null)
                {
                    body["Use_COD_Terms"] = SourceExpressionConverter.ConvertToken(bodyuseCODTerms);
                    bodypropCount++;
                }

                if (bodyuseDueMonthEndTerms != null)
                {
                    body["Use_Due_Month_End_Terms"] = SourceExpressionConverter.ConvertToken(bodyuseDueMonthEndTerms);
                    bodypropCount++;
                }

                if (bodyusePrepaidTerms != null)
                {
                    body["Use_Prepaid_Terms"] = SourceExpressionConverter.ConvertToken(bodyusePrepaidTerms);
                    bodypropCount++;
                }

                if (bodyuseStandardTerms != null)
                {
                    body["Use_Standard_Terms"] = SourceExpressionConverter.ConvertToken(bodyuseStandardTerms);
                    bodypropCount++;
                }

                if (bodyisInactive != null)
                {
                    body["isInactive"] = SourceExpressionConverter.ConvertToken(bodyisInactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAGE50USCreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAGE50USCreateNewSalesOrderResponse> SAGE50USCreateNewSalesOrder([WorkflowExpression] Func<string> bodyaccountsReceivableAccount = null, [WorkflowExpression] Func<string> bodyaccountsReceivableAcctGUID = null, [WorkflowExpression] Func<int> bodyaccountsReceivableAmount = null, [WorkflowExpression] Func<bool> bodyclosed = null, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<string> bodycustomerPO = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<int> bodydiscountAmount = null, [WorkflowExpression] Func<string> bodydisplayedTerms = null, [WorkflowExpression] Func<bool> bodydropShip = null, [WorkflowExpression] Func<string> bodygUId = null, [WorkflowExpression] Func<bool> bodynotePrintsAfterLineItems = null, [WorkflowExpression] Func<bool> bodyproposal = null, [WorkflowExpression] Func<bool> bodyproposalAccepted = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem2222[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<string> bodysalesOrderNumber = null, [WorkflowExpression] Func<string> bodysalesRepresentativeGUID = null, [WorkflowExpression] Func<string> bodysalesRepresentativeId = null, [WorkflowExpression] Func<string> bodyshipAddressCity = null, [WorkflowExpression] Func<string> bodyshipAddressCountry = null, [WorkflowExpression] Func<string> bodyshipAddressLine1 = null, [WorkflowExpression] Func<string> bodyshipAddressLine2 = null, [WorkflowExpression] Func<string> bodyshipAddressName = null, [WorkflowExpression] Func<string> bodyshipAddressState = null, [WorkflowExpression] Func<string> bodyshipAddressZipCode = null, [WorkflowExpression] Func<string> bodyshipBy = null, [WorkflowExpression] Func<string> bodyshipVIA = null, [WorkflowExpression] Func<bool> bodystatementNotePrintsBeforeInvRef = null)
        {
            SourceExpression.Validate(bodyaccountsReceivableAccount, nameof(bodyaccountsReceivableAccount), required: false);
            SourceExpression.Validate(bodyaccountsReceivableAcctGUID, nameof(bodyaccountsReceivableAcctGUID), required: false);
            SourceExpression.Validate(bodyaccountsReceivableAmount, nameof(bodyaccountsReceivableAmount), required: false);
            SourceExpression.Validate(bodyclosed, nameof(bodyclosed), required: false);
            SourceExpression.Validate(bodycustomerId, nameof(bodycustomerId), required: false);
            SourceExpression.Validate(bodycustomerPO, nameof(bodycustomerPO), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodydiscountAmount, nameof(bodydiscountAmount), required: false);
            SourceExpression.Validate(bodydisplayedTerms, nameof(bodydisplayedTerms), required: false);
            SourceExpression.Validate(bodydropShip, nameof(bodydropShip), required: false);
            SourceExpression.Validate(bodygUId, nameof(bodygUId), required: false);
            SourceExpression.Validate(bodynotePrintsAfterLineItems, nameof(bodynotePrintsAfterLineItems), required: false);
            SourceExpression.Validate(bodyproposal, nameof(bodyproposal), required: false);
            SourceExpression.Validate(bodyproposalAccepted, nameof(bodyproposalAccepted), required: false);
            SourceExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            SourceExpression.Validate(bodysalesOrderNumber, nameof(bodysalesOrderNumber), required: false);
            SourceExpression.Validate(bodysalesRepresentativeGUID, nameof(bodysalesRepresentativeGUID), required: false);
            SourceExpression.Validate(bodysalesRepresentativeId, nameof(bodysalesRepresentativeId), required: false);
            SourceExpression.Validate(bodyshipAddressCity, nameof(bodyshipAddressCity), required: false);
            SourceExpression.Validate(bodyshipAddressCountry, nameof(bodyshipAddressCountry), required: false);
            SourceExpression.Validate(bodyshipAddressLine1, nameof(bodyshipAddressLine1), required: false);
            SourceExpression.Validate(bodyshipAddressLine2, nameof(bodyshipAddressLine2), required: false);
            SourceExpression.Validate(bodyshipAddressName, nameof(bodyshipAddressName), required: false);
            SourceExpression.Validate(bodyshipAddressState, nameof(bodyshipAddressState), required: false);
            SourceExpression.Validate(bodyshipAddressZipCode, nameof(bodyshipAddressZipCode), required: false);
            SourceExpression.Validate(bodyshipBy, nameof(bodyshipBy), required: false);
            SourceExpression.Validate(bodyshipVIA, nameof(bodyshipVIA), required: false);
            SourceExpression.Validate(bodystatementNotePrintsBeforeInvRef, nameof(bodystatementNotePrintsBeforeInvRef), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sage50us/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountsReceivableAccount != null)
                {
                    body["Accounts_Receivable_Account"] = SourceExpressionConverter.ConvertToken(bodyaccountsReceivableAccount);
                    bodypropCount++;
                }

                if (bodyaccountsReceivableAcctGUID != null)
                {
                    body["Accounts_Receivable_Acct_GUID"] = SourceExpressionConverter.ConvertToken(bodyaccountsReceivableAcctGUID);
                    bodypropCount++;
                }

                if (bodyaccountsReceivableAmount != null)
                {
                    body["Accounts_Receivable_Amount"] = SourceExpressionConverter.ConvertToken(bodyaccountsReceivableAmount);
                    bodypropCount++;
                }

                if (bodyclosed != null)
                {
                    body["Closed"] = SourceExpressionConverter.ConvertToken(bodyclosed);
                    bodypropCount++;
                }

                if (bodycustomerId != null)
                {
                    body["Customer_ID"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodycustomerPO != null)
                {
                    body["Customer_PO"] = SourceExpressionConverter.ConvertToken(bodycustomerPO);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["Date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodydiscountAmount != null)
                {
                    body["Discount_Amount"] = SourceExpressionConverter.ConvertToken(bodydiscountAmount);
                    bodypropCount++;
                }

                if (bodydisplayedTerms != null)
                {
                    body["Displayed_Terms"] = SourceExpressionConverter.ConvertToken(bodydisplayedTerms);
                    bodypropCount++;
                }

                if (bodydropShip != null)
                {
                    body["Drop_Ship"] = SourceExpressionConverter.ConvertToken(bodydropShip);
                    bodypropCount++;
                }

                if (bodygUId != null)
                {
                    body["GUID"] = SourceExpressionConverter.ConvertToken(bodygUId);
                    bodypropCount++;
                }

                if (bodynotePrintsAfterLineItems != null)
                {
                    body["Note_Prints_After_Line_Items"] = SourceExpressionConverter.ConvertToken(bodynotePrintsAfterLineItems);
                    bodypropCount++;
                }

                if (bodyproposal != null)
                {
                    body["Proposal"] = SourceExpressionConverter.ConvertToken(bodyproposal);
                    bodypropCount++;
                }

                if (bodyproposalAccepted != null)
                {
                    body["ProposalAccepted"] = SourceExpressionConverter.ConvertToken(bodyproposalAccepted);
                    bodypropCount++;
                }

                if (bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = SourceExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (bodysalesOrderNumber != null)
                {
                    body["Sales_Order_Number"] = SourceExpressionConverter.ConvertToken(bodysalesOrderNumber);
                    bodypropCount++;
                }

                if (bodysalesRepresentativeGUID != null)
                {
                    body["Sales_Representative_GUID"] = SourceExpressionConverter.ConvertToken(bodysalesRepresentativeGUID);
                    bodypropCount++;
                }

                if (bodysalesRepresentativeId != null)
                {
                    body["Sales_Representative_ID"] = SourceExpressionConverter.ConvertToken(bodysalesRepresentativeId);
                    bodypropCount++;
                }

                if (bodyshipAddressCity != null)
                {
                    body["ShipAddressCity"] = SourceExpressionConverter.ConvertToken(bodyshipAddressCity);
                    bodypropCount++;
                }

                if (bodyshipAddressCountry != null)
                {
                    body["ShipAddressCountry"] = SourceExpressionConverter.ConvertToken(bodyshipAddressCountry);
                    bodypropCount++;
                }

                if (bodyshipAddressLine1 != null)
                {
                    body["ShipAddressLine1"] = SourceExpressionConverter.ConvertToken(bodyshipAddressLine1);
                    bodypropCount++;
                }

                if (bodyshipAddressLine2 != null)
                {
                    body["ShipAddressLine2"] = SourceExpressionConverter.ConvertToken(bodyshipAddressLine2);
                    bodypropCount++;
                }

                if (bodyshipAddressName != null)
                {
                    body["ShipAddressName"] = SourceExpressionConverter.ConvertToken(bodyshipAddressName);
                    bodypropCount++;
                }

                if (bodyshipAddressState != null)
                {
                    body["ShipAddressState"] = SourceExpressionConverter.ConvertToken(bodyshipAddressState);
                    bodypropCount++;
                }

                if (bodyshipAddressZipCode != null)
                {
                    body["ShipAddressZipCode"] = SourceExpressionConverter.ConvertToken(bodyshipAddressZipCode);
                    bodypropCount++;
                }

                if (bodyshipBy != null)
                {
                    body["Ship_By"] = SourceExpressionConverter.ConvertToken(bodyshipBy);
                    bodypropCount++;
                }

                if (bodyshipVIA != null)
                {
                    body["Ship_VIA"] = SourceExpressionConverter.ConvertToken(bodyshipVIA);
                    bodypropCount++;
                }

                if (bodystatementNotePrintsBeforeInvRef != null)
                {
                    body["Statement_Note_Prints_Before_Inv_Ref"] = SourceExpressionConverter.ConvertToken(bodystatementNotePrintsBeforeInvRef);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAGE50USCreateNewSalesOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAPB1CreateNewCustomerResponse> SAPB1CreateNewCustomer([WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodybillingAddressName = null, [WorkflowExpression] Func<string> bodybillingBlock = null, [WorkflowExpression] Func<string> bodybillingCity = null, [WorkflowExpression] Func<string> bodybillingCountry = null, [WorkflowExpression] Func<string> bodybillingState = null, [WorkflowExpression] Func<string> bodybillingStreet = null, [WorkflowExpression] Func<string> bodybillingZipCode = null, [WorkflowExpression] Func<string> bodycardCode = null, [WorkflowExpression] Func<string> bodycardName = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycontactPerson = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<string> bodyextraField = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyfederalTaxId = null, [WorkflowExpression] Func<string> bodyfreeText = null, [WorkflowExpression] Func<int> bodygroupCode = null, [WorkflowExpression] Func<string> bodymailAddress = null, [WorkflowExpression] Func<string> bodymailCity = null, [WorkflowExpression] Func<string> bodymailCountry = null, [WorkflowExpression] Func<string> bodymailCounty = null, [WorkflowExpression] Func<string> bodymailZipCode = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyphone1 = null, [WorkflowExpression] Func<string> bodyphone2 = null, [WorkflowExpression] Func<int> bodysalesPersonCode = null, [WorkflowExpression] Func<int> bodyseries = null, [WorkflowExpression] Func<string> bodyshippingAddressName = null, [WorkflowExpression] Func<string> bodyshippingBlock = null, [WorkflowExpression] Func<string> bodyshippingCity = null, [WorkflowExpression] Func<string> bodyshippingCountry = null, [WorkflowExpression] Func<string> bodyshippingState = null, [WorkflowExpression] Func<string> bodyshippingStreet = null, [WorkflowExpression] Func<string> bodyshippingZipCode = null, [WorkflowExpression] Func<string> bodywebSite = null, [WorkflowExpression] Func<string> bodyzipCode = null, [WorkflowExpression] Func<bodylstContactEmployeesInputItem[]> bodylstContactEmployees = null)
        {
            SourceExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            SourceExpression.Validate(bodybillingAddressName, nameof(bodybillingAddressName), required: false);
            SourceExpression.Validate(bodybillingBlock, nameof(bodybillingBlock), required: false);
            SourceExpression.Validate(bodybillingCity, nameof(bodybillingCity), required: false);
            SourceExpression.Validate(bodybillingCountry, nameof(bodybillingCountry), required: false);
            SourceExpression.Validate(bodybillingState, nameof(bodybillingState), required: false);
            SourceExpression.Validate(bodybillingStreet, nameof(bodybillingStreet), required: false);
            SourceExpression.Validate(bodybillingZipCode, nameof(bodybillingZipCode), required: false);
            SourceExpression.Validate(bodycardCode, nameof(bodycardCode), required: false);
            SourceExpression.Validate(bodycardName, nameof(bodycardName), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycontactPerson, nameof(bodycontactPerson), required: false);
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: false);
            SourceExpression.Validate(bodycounty, nameof(bodycounty), required: false);
            SourceExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            SourceExpression.Validate(bodyemailAddress, nameof(bodyemailAddress), required: false);
            SourceExpression.Validate(bodyextraField, nameof(bodyextraField), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodyfederalTaxId, nameof(bodyfederalTaxId), required: false);
            SourceExpression.Validate(bodyfreeText, nameof(bodyfreeText), required: false);
            SourceExpression.Validate(bodygroupCode, nameof(bodygroupCode), required: false);
            SourceExpression.Validate(bodymailAddress, nameof(bodymailAddress), required: false);
            SourceExpression.Validate(bodymailCity, nameof(bodymailCity), required: false);
            SourceExpression.Validate(bodymailCountry, nameof(bodymailCountry), required: false);
            SourceExpression.Validate(bodymailCounty, nameof(bodymailCounty), required: false);
            SourceExpression.Validate(bodymailZipCode, nameof(bodymailZipCode), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyphone1, nameof(bodyphone1), required: false);
            SourceExpression.Validate(bodyphone2, nameof(bodyphone2), required: false);
            SourceExpression.Validate(bodysalesPersonCode, nameof(bodysalesPersonCode), required: false);
            SourceExpression.Validate(bodyseries, nameof(bodyseries), required: false);
            SourceExpression.Validate(bodyshippingAddressName, nameof(bodyshippingAddressName), required: false);
            SourceExpression.Validate(bodyshippingBlock, nameof(bodyshippingBlock), required: false);
            SourceExpression.Validate(bodyshippingCity, nameof(bodyshippingCity), required: false);
            SourceExpression.Validate(bodyshippingCountry, nameof(bodyshippingCountry), required: false);
            SourceExpression.Validate(bodyshippingState, nameof(bodyshippingState), required: false);
            SourceExpression.Validate(bodyshippingStreet, nameof(bodyshippingStreet), required: false);
            SourceExpression.Validate(bodyshippingZipCode, nameof(bodyshippingZipCode), required: false);
            SourceExpression.Validate(bodywebSite, nameof(bodywebSite), required: false);
            SourceExpression.Validate(bodyzipCode, nameof(bodyzipCode), required: false);
            SourceExpression.Validate(bodylstContactEmployees, nameof(bodylstContactEmployees), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sapb1/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddress != null)
                {
                    body["Address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodybillingAddressName != null)
                {
                    body["BillingAddressName"] = SourceExpressionConverter.ConvertToken(bodybillingAddressName);
                    bodypropCount++;
                }

                if (bodybillingBlock != null)
                {
                    body["BillingBlock"] = SourceExpressionConverter.ConvertToken(bodybillingBlock);
                    bodypropCount++;
                }

                if (bodybillingCity != null)
                {
                    body["BillingCity"] = SourceExpressionConverter.ConvertToken(bodybillingCity);
                    bodypropCount++;
                }

                if (bodybillingCountry != null)
                {
                    body["BillingCountry"] = SourceExpressionConverter.ConvertToken(bodybillingCountry);
                    bodypropCount++;
                }

                if (bodybillingState != null)
                {
                    body["BillingState"] = SourceExpressionConverter.ConvertToken(bodybillingState);
                    bodypropCount++;
                }

                if (bodybillingStreet != null)
                {
                    body["BillingStreet"] = SourceExpressionConverter.ConvertToken(bodybillingStreet);
                    bodypropCount++;
                }

                if (bodybillingZipCode != null)
                {
                    body["BillingZipCode"] = SourceExpressionConverter.ConvertToken(bodybillingZipCode);
                    bodypropCount++;
                }

                if (bodycardCode != null)
                {
                    body["CardCode"] = SourceExpressionConverter.ConvertToken(bodycardCode);
                    bodypropCount++;
                }

                if (bodycardName != null)
                {
                    body["CardName"] = SourceExpressionConverter.ConvertToken(bodycardName);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycontactPerson != null)
                {
                    body["ContactPerson"] = SourceExpressionConverter.ConvertToken(bodycontactPerson);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["Country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["County"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    body["Currency"] = SourceExpressionConverter.ConvertToken(bodycurrency);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["EmailAddress"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyextraField != null)
                {
                    body["ExtraField"] = SourceExpressionConverter.ConvertToken(bodyextraField);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["Fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodyfederalTaxId != null)
                {
                    body["FederalTaxID"] = SourceExpressionConverter.ConvertToken(bodyfederalTaxId);
                    bodypropCount++;
                }

                if (bodyfreeText != null)
                {
                    body["FreeText"] = SourceExpressionConverter.ConvertToken(bodyfreeText);
                    bodypropCount++;
                }

                if (bodygroupCode != null)
                {
                    body["GroupCode"] = SourceExpressionConverter.ConvertToken(bodygroupCode);
                    bodypropCount++;
                }

                if (bodymailAddress != null)
                {
                    body["MailAddress"] = SourceExpressionConverter.ConvertToken(bodymailAddress);
                    bodypropCount++;
                }

                if (bodymailCity != null)
                {
                    body["MailCity"] = SourceExpressionConverter.ConvertToken(bodymailCity);
                    bodypropCount++;
                }

                if (bodymailCountry != null)
                {
                    body["MailCountry"] = SourceExpressionConverter.ConvertToken(bodymailCountry);
                    bodypropCount++;
                }

                if (bodymailCounty != null)
                {
                    body["MailCounty"] = SourceExpressionConverter.ConvertToken(bodymailCounty);
                    bodypropCount++;
                }

                if (bodymailZipCode != null)
                {
                    body["MailZipCode"] = SourceExpressionConverter.ConvertToken(bodymailZipCode);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["Notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyphone1 != null)
                {
                    body["Phone1"] = SourceExpressionConverter.ConvertToken(bodyphone1);
                    bodypropCount++;
                }

                if (bodyphone2 != null)
                {
                    body["Phone2"] = SourceExpressionConverter.ConvertToken(bodyphone2);
                    bodypropCount++;
                }

                if (bodysalesPersonCode != null)
                {
                    body["SalesPersonCode"] = SourceExpressionConverter.ConvertToken(bodysalesPersonCode);
                    bodypropCount++;
                }

                if (bodyseries != null)
                {
                    body["Series"] = SourceExpressionConverter.ConvertToken(bodyseries);
                    bodypropCount++;
                }

                if (bodyshippingAddressName != null)
                {
                    body["ShippingAddressName"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressName);
                    bodypropCount++;
                }

                if (bodyshippingBlock != null)
                {
                    body["ShippingBlock"] = SourceExpressionConverter.ConvertToken(bodyshippingBlock);
                    bodypropCount++;
                }

                if (bodyshippingCity != null)
                {
                    body["ShippingCity"] = SourceExpressionConverter.ConvertToken(bodyshippingCity);
                    bodypropCount++;
                }

                if (bodyshippingCountry != null)
                {
                    body["ShippingCountry"] = SourceExpressionConverter.ConvertToken(bodyshippingCountry);
                    bodypropCount++;
                }

                if (bodyshippingState != null)
                {
                    body["ShippingState"] = SourceExpressionConverter.ConvertToken(bodyshippingState);
                    bodypropCount++;
                }

                if (bodyshippingStreet != null)
                {
                    body["ShippingStreet"] = SourceExpressionConverter.ConvertToken(bodyshippingStreet);
                    bodypropCount++;
                }

                if (bodyshippingZipCode != null)
                {
                    body["ShippingZipCode"] = SourceExpressionConverter.ConvertToken(bodyshippingZipCode);
                    bodypropCount++;
                }

                if (bodywebSite != null)
                {
                    body["WebSite"] = SourceExpressionConverter.ConvertToken(bodywebSite);
                    bodypropCount++;
                }

                if (bodyzipCode != null)
                {
                    body["ZipCode"] = SourceExpressionConverter.ConvertToken(bodyzipCode);
                    bodypropCount++;
                }

                if (bodylstContactEmployees != null)
                {
                    body["lstContactEmployees"] = SourceExpressionConverter.ConvertToken(bodylstContactEmployees);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPB1CreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SAPB1CreateNewSalesOrderResponse> SAPB1CreateNewSalesOrder([WorkflowExpression] Func<string> bodycardCode = null, [WorkflowExpression] Func<string> bodydocDate = null, [WorkflowExpression] Func<string> bodydocDueDate = null, [WorkflowExpression] Func<int> bodydocNum = null, [WorkflowExpression] Func<bodysalesOrderLineItemInputItem22222[]> bodysalesOrderLineItem = null, [WorkflowExpression] Func<int> bodyseries = null, [WorkflowExpression] Func<string> bodytaxDate = null)
        {
            SourceExpression.Validate(bodycardCode, nameof(bodycardCode), required: false);
            SourceExpression.Validate(bodydocDate, nameof(bodydocDate), required: false);
            SourceExpression.Validate(bodydocDueDate, nameof(bodydocDueDate), required: false);
            SourceExpression.Validate(bodydocNum, nameof(bodydocNum), required: false);
            SourceExpression.Validate(bodysalesOrderLineItem, nameof(bodysalesOrderLineItem), required: false);
            SourceExpression.Validate(bodyseries, nameof(bodyseries), required: false);
            SourceExpression.Validate(bodytaxDate, nameof(bodytaxDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/sapb1/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycardCode != null)
                {
                    body["CardCode"] = SourceExpressionConverter.ConvertToken(bodycardCode);
                    bodypropCount++;
                }

                if (bodydocDate != null)
                {
                    body["DocDate"] = SourceExpressionConverter.ConvertToken(bodydocDate);
                    bodypropCount++;
                }

                if (bodydocDueDate != null)
                {
                    body["DocDueDate"] = SourceExpressionConverter.ConvertToken(bodydocDueDate);
                    bodypropCount++;
                }

                if (bodydocNum != null)
                {
                    body["DocNum"] = SourceExpressionConverter.ConvertToken(bodydocNum);
                    bodypropCount++;
                }

                if (bodysalesOrderLineItem != null)
                {
                    body["SalesOrderLineItem"] = SourceExpressionConverter.ConvertToken(bodysalesOrderLineItem);
                    bodypropCount++;
                }

                if (bodyseries != null)
                {
                    body["Series"] = SourceExpressionConverter.ConvertToken(bodyseries);
                    bodypropCount++;
                }

                if (bodytaxDate != null)
                {
                    body["TaxDate"] = SourceExpressionConverter.ConvertToken(bodytaxDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SAPB1CreateNewSalesOrderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SYSPROCreateNewCustomerResponse> SYSPROCreateNewCustomer([WorkflowExpression] Func<string> bodyaddTelephone = null, [WorkflowExpression] Func<string> bodyaltMethodFlag = null, [WorkflowExpression] Func<string> bodyapplyLineDisc = null, [WorkflowExpression] Func<string> bodyapplyOrdDisc = null, [WorkflowExpression] Func<string> bodyarStatementNo = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodybackOrdReqd = null, [WorkflowExpression] Func<string> bodybalanceType = null, [WorkflowExpression] Func<string> bodybranch = null, [WorkflowExpression] Func<string> bodybuyingGroup1 = null, [WorkflowExpression] Func<string> bodybuyingGroup2 = null, [WorkflowExpression] Func<string> bodybuyingGroup3 = null, [WorkflowExpression] Func<string> bodybuyingGroup4 = null, [WorkflowExpression] Func<string> bodybuyingGroup5 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycity1 = null, [WorkflowExpression] Func<string> bodycompanyTaxNumber = null, [WorkflowExpression] Func<string> bodycontact = null, [WorkflowExpression] Func<string> bodycontractPrcReqd = null, [WorkflowExpression] Func<string> bodycounterSlsOnly = null, [WorkflowExpression] Func<string> bodycountyZip = null, [WorkflowExpression] Func<string> bodycountyZip1 = null, [WorkflowExpression] Func<string> bodycreditCheckFlag = null, [WorkflowExpression] Func<string> bodycreditLimit = null, [WorkflowExpression] Func<string> bodycreditStatus = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodycustomerClass = null, [WorkflowExpression] Func<string> bodycustomerCode = null, [WorkflowExpression] Func<string> bodycustomerOnHold = null, [WorkflowExpression] Func<string> bodydateCustAdded = null, [WorkflowExpression] Func<string> bodydefaultOrdType = null, [WorkflowExpression] Func<string> bodydeliveryTerms = null, [WorkflowExpression] Func<string> bodydeliveryTermsC = null, [WorkflowExpression] Func<string> bodydetailMoveReqd = null, [WorkflowExpression] Func<string> bodydocFax = null, [WorkflowExpression] Func<string> bodydocFaxContact = null, [WorkflowExpression] Func<string> bodyediFlag = null, [WorkflowExpression] Func<string> bodyediSenderCode = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyexemptFinChg = null, [WorkflowExpression] Func<string> bodyfax = null, [WorkflowExpression] Func<string> bodyfaxInvoices = null, [WorkflowExpression] Func<string> bodyfaxQuotes = null, [WorkflowExpression] Func<string> bodyfaxStatements = null, [WorkflowExpression] Func<string> bodygstExemptFlag = null, [WorkflowExpression] Func<string> bodygstExemptNum = null, [WorkflowExpression] Func<string> bodygstLevel = null, [WorkflowExpression] Func<string> bodyhighInv = null, [WorkflowExpression] Func<string> bodyhighInvDays = null, [WorkflowExpression] Func<string> bodyhighestBalance = null, [WorkflowExpression] Func<string> bodyibtCustomer = null, [WorkflowExpression] Func<string> bodyinvCommentCode = null, [WorkflowExpression] Func<string> bodyinvDiscCode = null, [WorkflowExpression] Func<string> bodylanguageCode = null, [WorkflowExpression] Func<string> bodylineDiscCode = null, [WorkflowExpression] Func<string> bodymaintHistory = null, [WorkflowExpression] Func<string> bodymaintLastPrcPaid = null, [WorkflowExpression] Func<string> bodyminimumOrderChgCod = null, [WorkflowExpression] Func<string> bodyminimumOrderValue = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodynewCustomerCode = null, [WorkflowExpression] Func<string> bodypoNumberMandatory = null, [WorkflowExpression] Func<string> bodypriceCategoryTable = null, [WorkflowExpression] Func<string> bodypriceCode = null, [WorkflowExpression] Func<string> bodyrouteCode = null, [WorkflowExpression] Func<string> bodyrouteDistance = null, [WorkflowExpression] Func<string> bodysalesWarehouse = null, [WorkflowExpression] Func<string> bodysalesperson = null, [WorkflowExpression] Func<string> bodysalesperson1 = null, [WorkflowExpression] Func<string> bodysalesperson2 = null, [WorkflowExpression] Func<string> bodysalesperson3 = null, [WorkflowExpression] Func<string> bodyshipPostalCode = null, [WorkflowExpression] Func<string> bodyshipToAddr1 = null, [WorkflowExpression] Func<string> bodyshipToAddr2 = null, [WorkflowExpression] Func<string> bodyshipToAddr3 = null, [WorkflowExpression] Func<string> bodyshipToAddr3Loc = null, [WorkflowExpression] Func<string> bodyshipToAddr4 = null, [WorkflowExpression] Func<string> bodyshipToAddr5 = null, [WorkflowExpression] Func<string> bodyshipToGpsLat = null, [WorkflowExpression] Func<string> bodyshipToGpsLong = null, [WorkflowExpression] Func<string> bodyshippingInstrs = null, [WorkflowExpression] Func<string> bodyshippingInstrsCod = null, [WorkflowExpression] Func<string> bodyshippingLocation = null, [WorkflowExpression] Func<string> bodyshortName = null, [WorkflowExpression] Func<string> bodysoDefaultDoc = null, [WorkflowExpression] Func<string> bodysoDefaultType = null, [WorkflowExpression] Func<string> bodysoldPostalCode = null, [WorkflowExpression] Func<string> bodysoldToAddr1 = null, [WorkflowExpression] Func<string> bodysoldToAddr2 = null, [WorkflowExpression] Func<string> bodysoldToAddr3 = null, [WorkflowExpression] Func<string> bodysoldToAddr3Loc = null, [WorkflowExpression] Func<string> bodysoldToAddr4 = null, [WorkflowExpression] Func<string> bodysoldToAddr5 = null, [WorkflowExpression] Func<string> bodysoldToGpsLat = null, [WorkflowExpression] Func<string> bodysoldToGpsLong = null, [WorkflowExpression] Func<string> bodyspecialInstrs = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodystate1 = null, [WorkflowExpression] Func<string> bodystateCode = null, [WorkflowExpression] Func<string> bodystatementReqd = null, [WorkflowExpression] Func<string> bodystockInterchange = null, [WorkflowExpression] Func<string> bodytagsToDropFromXML = null, [WorkflowExpression] Func<string> bodytaxExemptNumber = null, [WorkflowExpression] Func<string> bodytaxStatus = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<string> bodytelephoneExtn = null, [WorkflowExpression] Func<string> bodytelex = null, [WorkflowExpression] Func<string> bodytermsCode = null, [WorkflowExpression] Func<string> bodytpmCreditCheck = null, [WorkflowExpression] Func<string> bodytpmCustomerFlag = null, [WorkflowExpression] Func<string> bodytpmPricingFlag = null, [WorkflowExpression] Func<string> bodytransactionNature = null, [WorkflowExpression] Func<string> bodytransactionNatureC = null, [WorkflowExpression] Func<string> bodyukCurrency = null, [WorkflowExpression] Func<string> bodyukVatFlag = null, [WorkflowExpression] Func<string> bodyuserField1 = null, [WorkflowExpression] Func<string> bodyuserField2 = null, [WorkflowExpression] Func<string> bodywholeOrderShipFlag = null, [WorkflowExpression] Func<string> bodyeSignature = null)
        {
            SourceExpression.Validate(bodyaddTelephone, nameof(bodyaddTelephone), required: false);
            SourceExpression.Validate(bodyaltMethodFlag, nameof(bodyaltMethodFlag), required: false);
            SourceExpression.Validate(bodyapplyLineDisc, nameof(bodyapplyLineDisc), required: false);
            SourceExpression.Validate(bodyapplyOrdDisc, nameof(bodyapplyOrdDisc), required: false);
            SourceExpression.Validate(bodyarStatementNo, nameof(bodyarStatementNo), required: false);
            SourceExpression.Validate(bodyarea, nameof(bodyarea), required: false);
            SourceExpression.Validate(bodybackOrdReqd, nameof(bodybackOrdReqd), required: false);
            SourceExpression.Validate(bodybalanceType, nameof(bodybalanceType), required: false);
            SourceExpression.Validate(bodybranch, nameof(bodybranch), required: false);
            SourceExpression.Validate(bodybuyingGroup1, nameof(bodybuyingGroup1), required: false);
            SourceExpression.Validate(bodybuyingGroup2, nameof(bodybuyingGroup2), required: false);
            SourceExpression.Validate(bodybuyingGroup3, nameof(bodybuyingGroup3), required: false);
            SourceExpression.Validate(bodybuyingGroup4, nameof(bodybuyingGroup4), required: false);
            SourceExpression.Validate(bodybuyingGroup5, nameof(bodybuyingGroup5), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycity1, nameof(bodycity1), required: false);
            SourceExpression.Validate(bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            SourceExpression.Validate(bodycontact, nameof(bodycontact), required: false);
            SourceExpression.Validate(bodycontractPrcReqd, nameof(bodycontractPrcReqd), required: false);
            SourceExpression.Validate(bodycounterSlsOnly, nameof(bodycounterSlsOnly), required: false);
            SourceExpression.Validate(bodycountyZip, nameof(bodycountyZip), required: false);
            SourceExpression.Validate(bodycountyZip1, nameof(bodycountyZip1), required: false);
            SourceExpression.Validate(bodycreditCheckFlag, nameof(bodycreditCheckFlag), required: false);
            SourceExpression.Validate(bodycreditLimit, nameof(bodycreditLimit), required: false);
            SourceExpression.Validate(bodycreditStatus, nameof(bodycreditStatus), required: false);
            SourceExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            SourceExpression.Validate(bodycustomerClass, nameof(bodycustomerClass), required: false);
            SourceExpression.Validate(bodycustomerCode, nameof(bodycustomerCode), required: false);
            SourceExpression.Validate(bodycustomerOnHold, nameof(bodycustomerOnHold), required: false);
            SourceExpression.Validate(bodydateCustAdded, nameof(bodydateCustAdded), required: false);
            SourceExpression.Validate(bodydefaultOrdType, nameof(bodydefaultOrdType), required: false);
            SourceExpression.Validate(bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            SourceExpression.Validate(bodydeliveryTermsC, nameof(bodydeliveryTermsC), required: false);
            SourceExpression.Validate(bodydetailMoveReqd, nameof(bodydetailMoveReqd), required: false);
            SourceExpression.Validate(bodydocFax, nameof(bodydocFax), required: false);
            SourceExpression.Validate(bodydocFaxContact, nameof(bodydocFaxContact), required: false);
            SourceExpression.Validate(bodyediFlag, nameof(bodyediFlag), required: false);
            SourceExpression.Validate(bodyediSenderCode, nameof(bodyediSenderCode), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyexemptFinChg, nameof(bodyexemptFinChg), required: false);
            SourceExpression.Validate(bodyfax, nameof(bodyfax), required: false);
            SourceExpression.Validate(bodyfaxInvoices, nameof(bodyfaxInvoices), required: false);
            SourceExpression.Validate(bodyfaxQuotes, nameof(bodyfaxQuotes), required: false);
            SourceExpression.Validate(bodyfaxStatements, nameof(bodyfaxStatements), required: false);
            SourceExpression.Validate(bodygstExemptFlag, nameof(bodygstExemptFlag), required: false);
            SourceExpression.Validate(bodygstExemptNum, nameof(bodygstExemptNum), required: false);
            SourceExpression.Validate(bodygstLevel, nameof(bodygstLevel), required: false);
            SourceExpression.Validate(bodyhighInv, nameof(bodyhighInv), required: false);
            SourceExpression.Validate(bodyhighInvDays, nameof(bodyhighInvDays), required: false);
            SourceExpression.Validate(bodyhighestBalance, nameof(bodyhighestBalance), required: false);
            SourceExpression.Validate(bodyibtCustomer, nameof(bodyibtCustomer), required: false);
            SourceExpression.Validate(bodyinvCommentCode, nameof(bodyinvCommentCode), required: false);
            SourceExpression.Validate(bodyinvDiscCode, nameof(bodyinvDiscCode), required: false);
            SourceExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            SourceExpression.Validate(bodylineDiscCode, nameof(bodylineDiscCode), required: false);
            SourceExpression.Validate(bodymaintHistory, nameof(bodymaintHistory), required: false);
            SourceExpression.Validate(bodymaintLastPrcPaid, nameof(bodymaintLastPrcPaid), required: false);
            SourceExpression.Validate(bodyminimumOrderChgCod, nameof(bodyminimumOrderChgCod), required: false);
            SourceExpression.Validate(bodyminimumOrderValue, nameof(bodyminimumOrderValue), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            SourceExpression.Validate(bodynewCustomerCode, nameof(bodynewCustomerCode), required: false);
            SourceExpression.Validate(bodypoNumberMandatory, nameof(bodypoNumberMandatory), required: false);
            SourceExpression.Validate(bodypriceCategoryTable, nameof(bodypriceCategoryTable), required: false);
            SourceExpression.Validate(bodypriceCode, nameof(bodypriceCode), required: false);
            SourceExpression.Validate(bodyrouteCode, nameof(bodyrouteCode), required: false);
            SourceExpression.Validate(bodyrouteDistance, nameof(bodyrouteDistance), required: false);
            SourceExpression.Validate(bodysalesWarehouse, nameof(bodysalesWarehouse), required: false);
            SourceExpression.Validate(bodysalesperson, nameof(bodysalesperson), required: false);
            SourceExpression.Validate(bodysalesperson1, nameof(bodysalesperson1), required: false);
            SourceExpression.Validate(bodysalesperson2, nameof(bodysalesperson2), required: false);
            SourceExpression.Validate(bodysalesperson3, nameof(bodysalesperson3), required: false);
            SourceExpression.Validate(bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            SourceExpression.Validate(bodyshipToAddr1, nameof(bodyshipToAddr1), required: false);
            SourceExpression.Validate(bodyshipToAddr2, nameof(bodyshipToAddr2), required: false);
            SourceExpression.Validate(bodyshipToAddr3, nameof(bodyshipToAddr3), required: false);
            SourceExpression.Validate(bodyshipToAddr3Loc, nameof(bodyshipToAddr3Loc), required: false);
            SourceExpression.Validate(bodyshipToAddr4, nameof(bodyshipToAddr4), required: false);
            SourceExpression.Validate(bodyshipToAddr5, nameof(bodyshipToAddr5), required: false);
            SourceExpression.Validate(bodyshipToGpsLat, nameof(bodyshipToGpsLat), required: false);
            SourceExpression.Validate(bodyshipToGpsLong, nameof(bodyshipToGpsLong), required: false);
            SourceExpression.Validate(bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            SourceExpression.Validate(bodyshippingInstrsCod, nameof(bodyshippingInstrsCod), required: false);
            SourceExpression.Validate(bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            SourceExpression.Validate(bodyshortName, nameof(bodyshortName), required: false);
            SourceExpression.Validate(bodysoDefaultDoc, nameof(bodysoDefaultDoc), required: false);
            SourceExpression.Validate(bodysoDefaultType, nameof(bodysoDefaultType), required: false);
            SourceExpression.Validate(bodysoldPostalCode, nameof(bodysoldPostalCode), required: false);
            SourceExpression.Validate(bodysoldToAddr1, nameof(bodysoldToAddr1), required: false);
            SourceExpression.Validate(bodysoldToAddr2, nameof(bodysoldToAddr2), required: false);
            SourceExpression.Validate(bodysoldToAddr3, nameof(bodysoldToAddr3), required: false);
            SourceExpression.Validate(bodysoldToAddr3Loc, nameof(bodysoldToAddr3Loc), required: false);
            SourceExpression.Validate(bodysoldToAddr4, nameof(bodysoldToAddr4), required: false);
            SourceExpression.Validate(bodysoldToAddr5, nameof(bodysoldToAddr5), required: false);
            SourceExpression.Validate(bodysoldToGpsLat, nameof(bodysoldToGpsLat), required: false);
            SourceExpression.Validate(bodysoldToGpsLong, nameof(bodysoldToGpsLong), required: false);
            SourceExpression.Validate(bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodystate1, nameof(bodystate1), required: false);
            SourceExpression.Validate(bodystateCode, nameof(bodystateCode), required: false);
            SourceExpression.Validate(bodystatementReqd, nameof(bodystatementReqd), required: false);
            SourceExpression.Validate(bodystockInterchange, nameof(bodystockInterchange), required: false);
            SourceExpression.Validate(bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            SourceExpression.Validate(bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            SourceExpression.Validate(bodytaxStatus, nameof(bodytaxStatus), required: false);
            SourceExpression.Validate(bodytelephone, nameof(bodytelephone), required: false);
            SourceExpression.Validate(bodytelephoneExtn, nameof(bodytelephoneExtn), required: false);
            SourceExpression.Validate(bodytelex, nameof(bodytelex), required: false);
            SourceExpression.Validate(bodytermsCode, nameof(bodytermsCode), required: false);
            SourceExpression.Validate(bodytpmCreditCheck, nameof(bodytpmCreditCheck), required: false);
            SourceExpression.Validate(bodytpmCustomerFlag, nameof(bodytpmCustomerFlag), required: false);
            SourceExpression.Validate(bodytpmPricingFlag, nameof(bodytpmPricingFlag), required: false);
            SourceExpression.Validate(bodytransactionNature, nameof(bodytransactionNature), required: false);
            SourceExpression.Validate(bodytransactionNatureC, nameof(bodytransactionNatureC), required: false);
            SourceExpression.Validate(bodyukCurrency, nameof(bodyukCurrency), required: false);
            SourceExpression.Validate(bodyukVatFlag, nameof(bodyukVatFlag), required: false);
            SourceExpression.Validate(bodyuserField1, nameof(bodyuserField1), required: false);
            SourceExpression.Validate(bodyuserField2, nameof(bodyuserField2), required: false);
            SourceExpression.Validate(bodywholeOrderShipFlag, nameof(bodywholeOrderShipFlag), required: false);
            SourceExpression.Validate(bodyeSignature, nameof(bodyeSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/syspro/customer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddTelephone != null)
                {
                    body["AddTelephone"] = SourceExpressionConverter.ConvertToken(bodyaddTelephone);
                    bodypropCount++;
                }

                if (bodyaltMethodFlag != null)
                {
                    body["AltMethodFlag"] = SourceExpressionConverter.ConvertToken(bodyaltMethodFlag);
                    bodypropCount++;
                }

                if (bodyapplyLineDisc != null)
                {
                    body["ApplyLineDisc"] = SourceExpressionConverter.ConvertToken(bodyapplyLineDisc);
                    bodypropCount++;
                }

                if (bodyapplyOrdDisc != null)
                {
                    body["ApplyOrdDisc"] = SourceExpressionConverter.ConvertToken(bodyapplyOrdDisc);
                    bodypropCount++;
                }

                if (bodyarStatementNo != null)
                {
                    body["ArStatementNo"] = SourceExpressionConverter.ConvertToken(bodyarStatementNo);
                    bodypropCount++;
                }

                if (bodyarea != null)
                {
                    body["Area"] = SourceExpressionConverter.ConvertToken(bodyarea);
                    bodypropCount++;
                }

                if (bodybackOrdReqd != null)
                {
                    body["BackOrdReqd"] = SourceExpressionConverter.ConvertToken(bodybackOrdReqd);
                    bodypropCount++;
                }

                if (bodybalanceType != null)
                {
                    body["BalanceType"] = SourceExpressionConverter.ConvertToken(bodybalanceType);
                    bodypropCount++;
                }

                if (bodybranch != null)
                {
                    body["Branch"] = SourceExpressionConverter.ConvertToken(bodybranch);
                    bodypropCount++;
                }

                if (bodybuyingGroup1 != null)
                {
                    body["BuyingGroup1"] = SourceExpressionConverter.ConvertToken(bodybuyingGroup1);
                    bodypropCount++;
                }

                if (bodybuyingGroup2 != null)
                {
                    body["BuyingGroup2"] = SourceExpressionConverter.ConvertToken(bodybuyingGroup2);
                    bodypropCount++;
                }

                if (bodybuyingGroup3 != null)
                {
                    body["BuyingGroup3"] = SourceExpressionConverter.ConvertToken(bodybuyingGroup3);
                    bodypropCount++;
                }

                if (bodybuyingGroup4 != null)
                {
                    body["BuyingGroup4"] = SourceExpressionConverter.ConvertToken(bodybuyingGroup4);
                    bodypropCount++;
                }

                if (bodybuyingGroup5 != null)
                {
                    body["BuyingGroup5"] = SourceExpressionConverter.ConvertToken(bodybuyingGroup5);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycity1 != null)
                {
                    body["City1"] = SourceExpressionConverter.ConvertToken(bodycity1);
                    bodypropCount++;
                }

                if (bodycompanyTaxNumber != null)
                {
                    body["CompanyTaxNumber"] = SourceExpressionConverter.ConvertToken(bodycompanyTaxNumber);
                    bodypropCount++;
                }

                if (bodycontact != null)
                {
                    body["Contact"] = SourceExpressionConverter.ConvertToken(bodycontact);
                    bodypropCount++;
                }

                if (bodycontractPrcReqd != null)
                {
                    body["ContractPrcReqd"] = SourceExpressionConverter.ConvertToken(bodycontractPrcReqd);
                    bodypropCount++;
                }

                if (bodycounterSlsOnly != null)
                {
                    body["CounterSlsOnly"] = SourceExpressionConverter.ConvertToken(bodycounterSlsOnly);
                    bodypropCount++;
                }

                if (bodycountyZip != null)
                {
                    body["CountyZip"] = SourceExpressionConverter.ConvertToken(bodycountyZip);
                    bodypropCount++;
                }

                if (bodycountyZip1 != null)
                {
                    body["CountyZip1"] = SourceExpressionConverter.ConvertToken(bodycountyZip1);
                    bodypropCount++;
                }

                if (bodycreditCheckFlag != null)
                {
                    body["CreditCheckFlag"] = SourceExpressionConverter.ConvertToken(bodycreditCheckFlag);
                    bodypropCount++;
                }

                if (bodycreditLimit != null)
                {
                    body["CreditLimit"] = SourceExpressionConverter.ConvertToken(bodycreditLimit);
                    bodypropCount++;
                }

                if (bodycreditStatus != null)
                {
                    body["CreditStatus"] = SourceExpressionConverter.ConvertToken(bodycreditStatus);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    body["Currency"] = SourceExpressionConverter.ConvertToken(bodycurrency);
                    bodypropCount++;
                }

                if (bodycustomerClass != null)
                {
                    body["CustomerClass"] = SourceExpressionConverter.ConvertToken(bodycustomerClass);
                    bodypropCount++;
                }

                if (bodycustomerCode != null)
                {
                    body["CustomerCode"] = SourceExpressionConverter.ConvertToken(bodycustomerCode);
                    bodypropCount++;
                }

                if (bodycustomerOnHold != null)
                {
                    body["CustomerOnHold"] = SourceExpressionConverter.ConvertToken(bodycustomerOnHold);
                    bodypropCount++;
                }

                if (bodydateCustAdded != null)
                {
                    body["DateCustAdded"] = SourceExpressionConverter.ConvertToken(bodydateCustAdded);
                    bodypropCount++;
                }

                if (bodydefaultOrdType != null)
                {
                    body["DefaultOrdType"] = SourceExpressionConverter.ConvertToken(bodydefaultOrdType);
                    bodypropCount++;
                }

                if (bodydeliveryTerms != null)
                {
                    body["DeliveryTerms"] = SourceExpressionConverter.ConvertToken(bodydeliveryTerms);
                    bodypropCount++;
                }

                if (bodydeliveryTermsC != null)
                {
                    body["DeliveryTermsC"] = SourceExpressionConverter.ConvertToken(bodydeliveryTermsC);
                    bodypropCount++;
                }

                if (bodydetailMoveReqd != null)
                {
                    body["DetailMoveReqd"] = SourceExpressionConverter.ConvertToken(bodydetailMoveReqd);
                    bodypropCount++;
                }

                if (bodydocFax != null)
                {
                    body["DocFax"] = SourceExpressionConverter.ConvertToken(bodydocFax);
                    bodypropCount++;
                }

                if (bodydocFaxContact != null)
                {
                    body["DocFaxContact"] = SourceExpressionConverter.ConvertToken(bodydocFaxContact);
                    bodypropCount++;
                }

                if (bodyediFlag != null)
                {
                    body["EdiFlag"] = SourceExpressionConverter.ConvertToken(bodyediFlag);
                    bodypropCount++;
                }

                if (bodyediSenderCode != null)
                {
                    body["EdiSenderCode"] = SourceExpressionConverter.ConvertToken(bodyediSenderCode);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyexemptFinChg != null)
                {
                    body["ExemptFinChg"] = SourceExpressionConverter.ConvertToken(bodyexemptFinChg);
                    bodypropCount++;
                }

                if (bodyfax != null)
                {
                    body["Fax"] = SourceExpressionConverter.ConvertToken(bodyfax);
                    bodypropCount++;
                }

                if (bodyfaxInvoices != null)
                {
                    body["FaxInvoices"] = SourceExpressionConverter.ConvertToken(bodyfaxInvoices);
                    bodypropCount++;
                }

                if (bodyfaxQuotes != null)
                {
                    body["FaxQuotes"] = SourceExpressionConverter.ConvertToken(bodyfaxQuotes);
                    bodypropCount++;
                }

                if (bodyfaxStatements != null)
                {
                    body["FaxStatements"] = SourceExpressionConverter.ConvertToken(bodyfaxStatements);
                    bodypropCount++;
                }

                if (bodygstExemptFlag != null)
                {
                    body["GstExemptFlag"] = SourceExpressionConverter.ConvertToken(bodygstExemptFlag);
                    bodypropCount++;
                }

                if (bodygstExemptNum != null)
                {
                    body["GstExemptNum"] = SourceExpressionConverter.ConvertToken(bodygstExemptNum);
                    bodypropCount++;
                }

                if (bodygstLevel != null)
                {
                    body["GstLevel"] = SourceExpressionConverter.ConvertToken(bodygstLevel);
                    bodypropCount++;
                }

                if (bodyhighInv != null)
                {
                    body["HighInv"] = SourceExpressionConverter.ConvertToken(bodyhighInv);
                    bodypropCount++;
                }

                if (bodyhighInvDays != null)
                {
                    body["HighInvDays"] = SourceExpressionConverter.ConvertToken(bodyhighInvDays);
                    bodypropCount++;
                }

                if (bodyhighestBalance != null)
                {
                    body["HighestBalance"] = SourceExpressionConverter.ConvertToken(bodyhighestBalance);
                    bodypropCount++;
                }

                if (bodyibtCustomer != null)
                {
                    body["IbtCustomer"] = SourceExpressionConverter.ConvertToken(bodyibtCustomer);
                    bodypropCount++;
                }

                if (bodyinvCommentCode != null)
                {
                    body["InvCommentCode"] = SourceExpressionConverter.ConvertToken(bodyinvCommentCode);
                    bodypropCount++;
                }

                if (bodyinvDiscCode != null)
                {
                    body["InvDiscCode"] = SourceExpressionConverter.ConvertToken(bodyinvDiscCode);
                    bodypropCount++;
                }

                if (bodylanguageCode != null)
                {
                    body["LanguageCode"] = SourceExpressionConverter.ConvertToken(bodylanguageCode);
                    bodypropCount++;
                }

                if (bodylineDiscCode != null)
                {
                    body["LineDiscCode"] = SourceExpressionConverter.ConvertToken(bodylineDiscCode);
                    bodypropCount++;
                }

                if (bodymaintHistory != null)
                {
                    body["MaintHistory"] = SourceExpressionConverter.ConvertToken(bodymaintHistory);
                    bodypropCount++;
                }

                if (bodymaintLastPrcPaid != null)
                {
                    body["MaintLastPrcPaid"] = SourceExpressionConverter.ConvertToken(bodymaintLastPrcPaid);
                    bodypropCount++;
                }

                if (bodyminimumOrderChgCod != null)
                {
                    body["MinimumOrderChgCod"] = SourceExpressionConverter.ConvertToken(bodyminimumOrderChgCod);
                    bodypropCount++;
                }

                if (bodyminimumOrderValue != null)
                {
                    body["MinimumOrderValue"] = SourceExpressionConverter.ConvertToken(bodyminimumOrderValue);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["Name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodynationality != null)
                {
                    body["Nationality"] = SourceExpressionConverter.ConvertToken(bodynationality);
                    bodypropCount++;
                }

                if (bodynewCustomerCode != null)
                {
                    body["NewCustomerCode"] = SourceExpressionConverter.ConvertToken(bodynewCustomerCode);
                    bodypropCount++;
                }

                if (bodypoNumberMandatory != null)
                {
                    body["PoNumberMandatory"] = SourceExpressionConverter.ConvertToken(bodypoNumberMandatory);
                    bodypropCount++;
                }

                if (bodypriceCategoryTable != null)
                {
                    body["PriceCategoryTable"] = SourceExpressionConverter.ConvertToken(bodypriceCategoryTable);
                    bodypropCount++;
                }

                if (bodypriceCode != null)
                {
                    body["PriceCode"] = SourceExpressionConverter.ConvertToken(bodypriceCode);
                    bodypropCount++;
                }

                if (bodyrouteCode != null)
                {
                    body["RouteCode"] = SourceExpressionConverter.ConvertToken(bodyrouteCode);
                    bodypropCount++;
                }

                if (bodyrouteDistance != null)
                {
                    body["RouteDistance"] = SourceExpressionConverter.ConvertToken(bodyrouteDistance);
                    bodypropCount++;
                }

                if (bodysalesWarehouse != null)
                {
                    body["SalesWarehouse"] = SourceExpressionConverter.ConvertToken(bodysalesWarehouse);
                    bodypropCount++;
                }

                if (bodysalesperson != null)
                {
                    body["Salesperson"] = SourceExpressionConverter.ConvertToken(bodysalesperson);
                    bodypropCount++;
                }

                if (bodysalesperson1 != null)
                {
                    body["Salesperson1"] = SourceExpressionConverter.ConvertToken(bodysalesperson1);
                    bodypropCount++;
                }

                if (bodysalesperson2 != null)
                {
                    body["Salesperson2"] = SourceExpressionConverter.ConvertToken(bodysalesperson2);
                    bodypropCount++;
                }

                if (bodysalesperson3 != null)
                {
                    body["Salesperson3"] = SourceExpressionConverter.ConvertToken(bodysalesperson3);
                    bodypropCount++;
                }

                if (bodyshipPostalCode != null)
                {
                    body["ShipPostalCode"] = SourceExpressionConverter.ConvertToken(bodyshipPostalCode);
                    bodypropCount++;
                }

                if (bodyshipToAddr1 != null)
                {
                    body["ShipToAddr1"] = SourceExpressionConverter.ConvertToken(bodyshipToAddr1);
                    bodypropCount++;
                }

                if (bodyshipToAddr2 != null)
                {
                    body["ShipToAddr2"] = SourceExpressionConverter.ConvertToken(bodyshipToAddr2);
                    bodypropCount++;
                }

                if (bodyshipToAddr3 != null)
                {
                    body["ShipToAddr3"] = SourceExpressionConverter.ConvertToken(bodyshipToAddr3);
                    bodypropCount++;
                }

                if (bodyshipToAddr3Loc != null)
                {
                    body["ShipToAddr3Loc"] = SourceExpressionConverter.ConvertToken(bodyshipToAddr3Loc);
                    bodypropCount++;
                }

                if (bodyshipToAddr4 != null)
                {
                    body["ShipToAddr4"] = SourceExpressionConverter.ConvertToken(bodyshipToAddr4);
                    bodypropCount++;
                }

                if (bodyshipToAddr5 != null)
                {
                    body["ShipToAddr5"] = SourceExpressionConverter.ConvertToken(bodyshipToAddr5);
                    bodypropCount++;
                }

                if (bodyshipToGpsLat != null)
                {
                    body["ShipToGpsLat"] = SourceExpressionConverter.ConvertToken(bodyshipToGpsLat);
                    bodypropCount++;
                }

                if (bodyshipToGpsLong != null)
                {
                    body["ShipToGpsLong"] = SourceExpressionConverter.ConvertToken(bodyshipToGpsLong);
                    bodypropCount++;
                }

                if (bodyshippingInstrs != null)
                {
                    body["ShippingInstrs"] = SourceExpressionConverter.ConvertToken(bodyshippingInstrs);
                    bodypropCount++;
                }

                if (bodyshippingInstrsCod != null)
                {
                    body["ShippingInstrsCod"] = SourceExpressionConverter.ConvertToken(bodyshippingInstrsCod);
                    bodypropCount++;
                }

                if (bodyshippingLocation != null)
                {
                    body["ShippingLocation"] = SourceExpressionConverter.ConvertToken(bodyshippingLocation);
                    bodypropCount++;
                }

                if (bodyshortName != null)
                {
                    body["ShortName"] = SourceExpressionConverter.ConvertToken(bodyshortName);
                    bodypropCount++;
                }

                if (bodysoDefaultDoc != null)
                {
                    body["SoDefaultDoc"] = SourceExpressionConverter.ConvertToken(bodysoDefaultDoc);
                    bodypropCount++;
                }

                if (bodysoDefaultType != null)
                {
                    body["SoDefaultType"] = SourceExpressionConverter.ConvertToken(bodysoDefaultType);
                    bodypropCount++;
                }

                if (bodysoldPostalCode != null)
                {
                    body["SoldPostalCode"] = SourceExpressionConverter.ConvertToken(bodysoldPostalCode);
                    bodypropCount++;
                }

                if (bodysoldToAddr1 != null)
                {
                    body["SoldToAddr1"] = SourceExpressionConverter.ConvertToken(bodysoldToAddr1);
                    bodypropCount++;
                }

                if (bodysoldToAddr2 != null)
                {
                    body["SoldToAddr2"] = SourceExpressionConverter.ConvertToken(bodysoldToAddr2);
                    bodypropCount++;
                }

                if (bodysoldToAddr3 != null)
                {
                    body["SoldToAddr3"] = SourceExpressionConverter.ConvertToken(bodysoldToAddr3);
                    bodypropCount++;
                }

                if (bodysoldToAddr3Loc != null)
                {
                    body["SoldToAddr3Loc"] = SourceExpressionConverter.ConvertToken(bodysoldToAddr3Loc);
                    bodypropCount++;
                }

                if (bodysoldToAddr4 != null)
                {
                    body["SoldToAddr4"] = SourceExpressionConverter.ConvertToken(bodysoldToAddr4);
                    bodypropCount++;
                }

                if (bodysoldToAddr5 != null)
                {
                    body["SoldToAddr5"] = SourceExpressionConverter.ConvertToken(bodysoldToAddr5);
                    bodypropCount++;
                }

                if (bodysoldToGpsLat != null)
                {
                    body["SoldToGpsLat"] = SourceExpressionConverter.ConvertToken(bodysoldToGpsLat);
                    bodypropCount++;
                }

                if (bodysoldToGpsLong != null)
                {
                    body["SoldToGpsLong"] = SourceExpressionConverter.ConvertToken(bodysoldToGpsLong);
                    bodypropCount++;
                }

                if (bodyspecialInstrs != null)
                {
                    body["SpecialInstrs"] = SourceExpressionConverter.ConvertToken(bodyspecialInstrs);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["State"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodystate1 != null)
                {
                    body["State1"] = SourceExpressionConverter.ConvertToken(bodystate1);
                    bodypropCount++;
                }

                if (bodystateCode != null)
                {
                    body["StateCode"] = SourceExpressionConverter.ConvertToken(bodystateCode);
                    bodypropCount++;
                }

                if (bodystatementReqd != null)
                {
                    body["StatementReqd"] = SourceExpressionConverter.ConvertToken(bodystatementReqd);
                    bodypropCount++;
                }

                if (bodystockInterchange != null)
                {
                    body["StockInterchange"] = SourceExpressionConverter.ConvertToken(bodystockInterchange);
                    bodypropCount++;
                }

                if (bodytagsToDropFromXML != null)
                {
                    body["TagsToDropFromXML"] = SourceExpressionConverter.ConvertToken(bodytagsToDropFromXML);
                    bodypropCount++;
                }

                if (bodytaxExemptNumber != null)
                {
                    body["TaxExemptNumber"] = SourceExpressionConverter.ConvertToken(bodytaxExemptNumber);
                    bodypropCount++;
                }

                if (bodytaxStatus != null)
                {
                    body["TaxStatus"] = SourceExpressionConverter.ConvertToken(bodytaxStatus);
                    bodypropCount++;
                }

                if (bodytelephone != null)
                {
                    body["Telephone"] = SourceExpressionConverter.ConvertToken(bodytelephone);
                    bodypropCount++;
                }

                if (bodytelephoneExtn != null)
                {
                    body["TelephoneExtn"] = SourceExpressionConverter.ConvertToken(bodytelephoneExtn);
                    bodypropCount++;
                }

                if (bodytelex != null)
                {
                    body["Telex"] = SourceExpressionConverter.ConvertToken(bodytelex);
                    bodypropCount++;
                }

                if (bodytermsCode != null)
                {
                    body["TermsCode"] = SourceExpressionConverter.ConvertToken(bodytermsCode);
                    bodypropCount++;
                }

                if (bodytpmCreditCheck != null)
                {
                    body["TpmCreditCheck"] = SourceExpressionConverter.ConvertToken(bodytpmCreditCheck);
                    bodypropCount++;
                }

                if (bodytpmCustomerFlag != null)
                {
                    body["TpmCustomerFlag"] = SourceExpressionConverter.ConvertToken(bodytpmCustomerFlag);
                    bodypropCount++;
                }

                if (bodytpmPricingFlag != null)
                {
                    body["TpmPricingFlag"] = SourceExpressionConverter.ConvertToken(bodytpmPricingFlag);
                    bodypropCount++;
                }

                if (bodytransactionNature != null)
                {
                    body["TransactionNature"] = SourceExpressionConverter.ConvertToken(bodytransactionNature);
                    bodypropCount++;
                }

                if (bodytransactionNatureC != null)
                {
                    body["TransactionNatureC"] = SourceExpressionConverter.ConvertToken(bodytransactionNatureC);
                    bodypropCount++;
                }

                if (bodyukCurrency != null)
                {
                    body["UkCurrency"] = SourceExpressionConverter.ConvertToken(bodyukCurrency);
                    bodypropCount++;
                }

                if (bodyukVatFlag != null)
                {
                    body["UkVatFlag"] = SourceExpressionConverter.ConvertToken(bodyukVatFlag);
                    bodypropCount++;
                }

                if (bodyuserField1 != null)
                {
                    body["UserField1"] = SourceExpressionConverter.ConvertToken(bodyuserField1);
                    bodypropCount++;
                }

                if (bodyuserField2 != null)
                {
                    body["UserField2"] = SourceExpressionConverter.ConvertToken(bodyuserField2);
                    bodypropCount++;
                }

                if (bodywholeOrderShipFlag != null)
                {
                    body["WholeOrderShipFlag"] = SourceExpressionConverter.ConvertToken(bodywholeOrderShipFlag);
                    bodypropCount++;
                }

                if (bodyeSignature != null)
                {
                    body["eSignature"] = SourceExpressionConverter.ConvertToken(bodyeSignature);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SYSPROCreateNewCustomerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "commercientcpq")]
        public IBodyWorkflowAction<SYSPROCreateNewSalesOrderResponse> SYSPROCreateNewSalesOrder([WorkflowExpression] Func<string> bodyacceptEarlierShipDate = null, [WorkflowExpression] Func<string> bodyacceptKitOptional = null, [WorkflowExpression] Func<string> bodyacceptOrdersIfNoCredit = null, [WorkflowExpression] Func<string> bodyaddAttachedServiceCharges = null, [WorkflowExpression] Func<string> bodyaddDangerousGoodsText = null, [WorkflowExpression] Func<string> bodyaddStockSalesOrderText = null, [WorkflowExpression] Func<string> bodyallocationAction = null, [WorkflowExpression] Func<string> bodyallowBackOrderForNegativeMerchLine = null, [WorkflowExpression] Func<string> bodyallowBackOrderForPartialHold = null, [WorkflowExpression] Func<string> bodyallowBackOrderForSuperseded = null, [WorkflowExpression] Func<string> bodyallowChangeToZeroPrice = null, [WorkflowExpression] Func<string> bodyallowDuplicateOrderNumbers = null, [WorkflowExpression] Func<string> bodyallowManualOrderNumberToBeUsed = null, [WorkflowExpression] Func<string> bodyallowNonStockItems = null, [WorkflowExpression] Func<string> bodyallowZeroPrice = null, [WorkflowExpression] Func<string> bodyalternateReference = null, [WorkflowExpression] Func<string> bodyalwaysUsePriceEntered = null, [WorkflowExpression] Func<string> bodyapplyLeadTimeCalculation = null, [WorkflowExpression] Func<string> bodyapplyParentDiscountToComponents = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodybranch = null, [WorkflowExpression] Func<string> bodycancelReasonCode = null, [WorkflowExpression] Func<string> bodycheckForCustomerPoNumbers = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycompanyTaxNumber = null, [WorkflowExpression] Func<string> bodycountyZip = null, [WorkflowExpression] Func<string> bodycreditFailMessage = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodycustomer = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodycustomerPoNumber = null, [WorkflowExpression] Func<string> bodycustomerToUse = null, [WorkflowExpression] Func<string> bodydeliveryRoute = null, [WorkflowExpression] Func<string> bodydeliveryRouteAction = null, [WorkflowExpression] Func<string> bodydeliveryTerms = null, [WorkflowExpression] Func<string> bodydocumentFormat = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyglobalTradePromotionCodes = null, [WorkflowExpression] Func<string> bodygstExemptNumber = null, [WorkflowExpression] Func<string> bodygstExemptionStatus = null, [WorkflowExpression] Func<string> bodyheaderFreightCharges = null, [WorkflowExpression] Func<string> bodyheaderMiscCharges = null, [WorkflowExpression] Func<string> bodyignoreWarnings = null, [WorkflowExpression] Func<string> bodyinBoxMsgReqd = null, [WorkflowExpression] Func<string> bodyincludeInMrp = null, [WorkflowExpression] Func<string> bodyinvoiceDateEntered = null, [WorkflowExpression] Func<string> bodyinvoiceNumberEntered = null, [WorkflowExpression] Func<string> bodyinvoiceTerms = null, [WorkflowExpression] Func<string> bodyinvoiceWholeOrderOnly = null, [WorkflowExpression] Func<string> bodylanguageCode = null, [WorkflowExpression] Func<string> bodyminimumDaysToShip = null, [WorkflowExpression] Func<string> bodymultiShipCode = null, [WorkflowExpression] Func<string> bodynationality = null, [WorkflowExpression] Func<string> bodynewCustomerPoNumber = null, [WorkflowExpression] Func<string> bodynewSalesOrderNumber = null, [WorkflowExpression] Func<string> bodyoperatorToInform = null, [WorkflowExpression] Func<string> bodyorderActionType = null, [WorkflowExpression] Func<string> bodyorderComments = null, [WorkflowExpression] Func<string> bodyorderDate = null, [WorkflowExpression] Func<string> bodyorderDiscPercent1 = null, [WorkflowExpression] Func<string> bodyorderDiscPercent2 = null, [WorkflowExpression] Func<string> bodyorderDiscPercent3 = null, [WorkflowExpression] Func<string> bodyorderStatus = null, [WorkflowExpression] Func<string> bodyorderType = null, [WorkflowExpression] Func<string> bodyoverrideCustomerBackOrder = null, [WorkflowExpression] Func<string> bodypOSSalesOrder = null, [WorkflowExpression] Func<string> bodyprocess = null, [WorkflowExpression] Func<string> bodyprocessFlag = null, [WorkflowExpression] Func<string> bodyputEntireQuantityOnNewLoadWhenChanged = null, [WorkflowExpression] Func<string> bodyreceiverCode = null, [WorkflowExpression] Func<string> bodyrequestedShipDate = null, [WorkflowExpression] Func<string> bodyreserveStock = null, [WorkflowExpression] Func<string> bodyreserveStockRequestAllocs = null, [WorkflowExpression] Func<string> bodysalesOrder = null, [WorkflowExpression] Func<bodysalesOrderDetailsInputItem[]> bodysalesOrderDetails = null, [WorkflowExpression] Func<bodysalesOrderFooterCommentsInputItem[]> bodysalesOrderFooterComments = null, [WorkflowExpression] Func<bodysalesOrderFreightDetailsInputItem[]> bodysalesOrderFreightDetails = null, [WorkflowExpression] Func<bodysalesOrderHeaderCommentsInputItem[]> bodysalesOrderHeaderComments = null, [WorkflowExpression] Func<bodysalesOrderMiscChargesDetailsInputItem[]> bodysalesOrderMiscChargesDetails = null, [WorkflowExpression] Func<string> bodysalesOrderPromoQualifyAction = null, [WorkflowExpression] Func<string> bodysalesOrderPromoSelectAction = null, [WorkflowExpression] Func<string> bodysalesperson = null, [WorkflowExpression] Func<string> bodysenderCode = null, [WorkflowExpression] Func<string> bodyshipAddress1 = null, [WorkflowExpression] Func<string> bodyshipAddress2 = null, [WorkflowExpression] Func<string> bodyshipAddress3 = null, [WorkflowExpression] Func<string> bodyshipAddress3Locality = null, [WorkflowExpression] Func<string> bodyshipAddress4 = null, [WorkflowExpression] Func<string> bodyshipAddress5 = null, [WorkflowExpression] Func<string> bodyshipAddressPerLine = null, [WorkflowExpression] Func<string> bodyshipAddressPerLineTax = null, [WorkflowExpression] Func<string> bodyshipGpsLat = null, [WorkflowExpression] Func<string> bodyshipGpsLong = null, [WorkflowExpression] Func<string> bodyshipPostalCode = null, [WorkflowExpression] Func<string> bodyshippingInstrs = null, [WorkflowExpression] Func<string> bodyshippingInstrsCode = null, [WorkflowExpression] Func<string> bodyshippingLocation = null, [WorkflowExpression] Func<string> bodyspecialInstrs = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodystatusInProcess = null, [WorkflowExpression] Func<string> bodystatusInProcessResponse = null, [WorkflowExpression] Func<string> bodysupplier = null, [WorkflowExpression] Func<string> bodytagsToDropFromXML = null, [WorkflowExpression] Func<string> bodytaxExemptNumber = null, [WorkflowExpression] Func<string> bodytaxExemptionStatus = null, [WorkflowExpression] Func<string> bodytransactionNature = null, [WorkflowExpression] Func<string> bodytransmissionReference = null, [WorkflowExpression] Func<string> bodytransportMode = null, [WorkflowExpression] Func<string> bodytypeOfOrder = null, [WorkflowExpression] Func<string> bodyuseCustomerSalesWarehouse = null, [WorkflowExpression] Func<string> bodyuseMasterAccountForCustomerPartNo = null, [WorkflowExpression] Func<string> bodyuseStockDescSupplied = null, [WorkflowExpression] Func<string> bodyvalidateShippingInstrs = null, [WorkflowExpression] Func<string> bodywarehouse = null, [WorkflowExpression] Func<string> bodywarehouseListToUse = null, [WorkflowExpression] Func<string> bodywarnIfCustomerOnHold = null, [WorkflowExpression] Func<string> bodyeSignature = null)
        {
            SourceExpression.Validate(bodyacceptEarlierShipDate, nameof(bodyacceptEarlierShipDate), required: false);
            SourceExpression.Validate(bodyacceptKitOptional, nameof(bodyacceptKitOptional), required: false);
            SourceExpression.Validate(bodyacceptOrdersIfNoCredit, nameof(bodyacceptOrdersIfNoCredit), required: false);
            SourceExpression.Validate(bodyaddAttachedServiceCharges, nameof(bodyaddAttachedServiceCharges), required: false);
            SourceExpression.Validate(bodyaddDangerousGoodsText, nameof(bodyaddDangerousGoodsText), required: false);
            SourceExpression.Validate(bodyaddStockSalesOrderText, nameof(bodyaddStockSalesOrderText), required: false);
            SourceExpression.Validate(bodyallocationAction, nameof(bodyallocationAction), required: false);
            SourceExpression.Validate(bodyallowBackOrderForNegativeMerchLine, nameof(bodyallowBackOrderForNegativeMerchLine), required: false);
            SourceExpression.Validate(bodyallowBackOrderForPartialHold, nameof(bodyallowBackOrderForPartialHold), required: false);
            SourceExpression.Validate(bodyallowBackOrderForSuperseded, nameof(bodyallowBackOrderForSuperseded), required: false);
            SourceExpression.Validate(bodyallowChangeToZeroPrice, nameof(bodyallowChangeToZeroPrice), required: false);
            SourceExpression.Validate(bodyallowDuplicateOrderNumbers, nameof(bodyallowDuplicateOrderNumbers), required: false);
            SourceExpression.Validate(bodyallowManualOrderNumberToBeUsed, nameof(bodyallowManualOrderNumberToBeUsed), required: false);
            SourceExpression.Validate(bodyallowNonStockItems, nameof(bodyallowNonStockItems), required: false);
            SourceExpression.Validate(bodyallowZeroPrice, nameof(bodyallowZeroPrice), required: false);
            SourceExpression.Validate(bodyalternateReference, nameof(bodyalternateReference), required: false);
            SourceExpression.Validate(bodyalwaysUsePriceEntered, nameof(bodyalwaysUsePriceEntered), required: false);
            SourceExpression.Validate(bodyapplyLeadTimeCalculation, nameof(bodyapplyLeadTimeCalculation), required: false);
            SourceExpression.Validate(bodyapplyParentDiscountToComponents, nameof(bodyapplyParentDiscountToComponents), required: false);
            SourceExpression.Validate(bodyarea, nameof(bodyarea), required: false);
            SourceExpression.Validate(bodybranch, nameof(bodybranch), required: false);
            SourceExpression.Validate(bodycancelReasonCode, nameof(bodycancelReasonCode), required: false);
            SourceExpression.Validate(bodycheckForCustomerPoNumbers, nameof(bodycheckForCustomerPoNumbers), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodycompanyTaxNumber, nameof(bodycompanyTaxNumber), required: false);
            SourceExpression.Validate(bodycountyZip, nameof(bodycountyZip), required: false);
            SourceExpression.Validate(bodycreditFailMessage, nameof(bodycreditFailMessage), required: false);
            SourceExpression.Validate(bodycurrency, nameof(bodycurrency), required: false);
            SourceExpression.Validate(bodycustomer, nameof(bodycustomer), required: false);
            SourceExpression.Validate(bodycustomerName, nameof(bodycustomerName), required: false);
            SourceExpression.Validate(bodycustomerPoNumber, nameof(bodycustomerPoNumber), required: false);
            SourceExpression.Validate(bodycustomerToUse, nameof(bodycustomerToUse), required: false);
            SourceExpression.Validate(bodydeliveryRoute, nameof(bodydeliveryRoute), required: false);
            SourceExpression.Validate(bodydeliveryRouteAction, nameof(bodydeliveryRouteAction), required: false);
            SourceExpression.Validate(bodydeliveryTerms, nameof(bodydeliveryTerms), required: false);
            SourceExpression.Validate(bodydocumentFormat, nameof(bodydocumentFormat), required: false);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyglobalTradePromotionCodes, nameof(bodyglobalTradePromotionCodes), required: false);
            SourceExpression.Validate(bodygstExemptNumber, nameof(bodygstExemptNumber), required: false);
            SourceExpression.Validate(bodygstExemptionStatus, nameof(bodygstExemptionStatus), required: false);
            SourceExpression.Validate(bodyheaderFreightCharges, nameof(bodyheaderFreightCharges), required: false);
            SourceExpression.Validate(bodyheaderMiscCharges, nameof(bodyheaderMiscCharges), required: false);
            SourceExpression.Validate(bodyignoreWarnings, nameof(bodyignoreWarnings), required: false);
            SourceExpression.Validate(bodyinBoxMsgReqd, nameof(bodyinBoxMsgReqd), required: false);
            SourceExpression.Validate(bodyincludeInMrp, nameof(bodyincludeInMrp), required: false);
            SourceExpression.Validate(bodyinvoiceDateEntered, nameof(bodyinvoiceDateEntered), required: false);
            SourceExpression.Validate(bodyinvoiceNumberEntered, nameof(bodyinvoiceNumberEntered), required: false);
            SourceExpression.Validate(bodyinvoiceTerms, nameof(bodyinvoiceTerms), required: false);
            SourceExpression.Validate(bodyinvoiceWholeOrderOnly, nameof(bodyinvoiceWholeOrderOnly), required: false);
            SourceExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            SourceExpression.Validate(bodyminimumDaysToShip, nameof(bodyminimumDaysToShip), required: false);
            SourceExpression.Validate(bodymultiShipCode, nameof(bodymultiShipCode), required: false);
            SourceExpression.Validate(bodynationality, nameof(bodynationality), required: false);
            SourceExpression.Validate(bodynewCustomerPoNumber, nameof(bodynewCustomerPoNumber), required: false);
            SourceExpression.Validate(bodynewSalesOrderNumber, nameof(bodynewSalesOrderNumber), required: false);
            SourceExpression.Validate(bodyoperatorToInform, nameof(bodyoperatorToInform), required: false);
            SourceExpression.Validate(bodyorderActionType, nameof(bodyorderActionType), required: false);
            SourceExpression.Validate(bodyorderComments, nameof(bodyorderComments), required: false);
            SourceExpression.Validate(bodyorderDate, nameof(bodyorderDate), required: false);
            SourceExpression.Validate(bodyorderDiscPercent1, nameof(bodyorderDiscPercent1), required: false);
            SourceExpression.Validate(bodyorderDiscPercent2, nameof(bodyorderDiscPercent2), required: false);
            SourceExpression.Validate(bodyorderDiscPercent3, nameof(bodyorderDiscPercent3), required: false);
            SourceExpression.Validate(bodyorderStatus, nameof(bodyorderStatus), required: false);
            SourceExpression.Validate(bodyorderType, nameof(bodyorderType), required: false);
            SourceExpression.Validate(bodyoverrideCustomerBackOrder, nameof(bodyoverrideCustomerBackOrder), required: false);
            SourceExpression.Validate(bodypOSSalesOrder, nameof(bodypOSSalesOrder), required: false);
            SourceExpression.Validate(bodyprocess, nameof(bodyprocess), required: false);
            SourceExpression.Validate(bodyprocessFlag, nameof(bodyprocessFlag), required: false);
            SourceExpression.Validate(bodyputEntireQuantityOnNewLoadWhenChanged, nameof(bodyputEntireQuantityOnNewLoadWhenChanged), required: false);
            SourceExpression.Validate(bodyreceiverCode, nameof(bodyreceiverCode), required: false);
            SourceExpression.Validate(bodyrequestedShipDate, nameof(bodyrequestedShipDate), required: false);
            SourceExpression.Validate(bodyreserveStock, nameof(bodyreserveStock), required: false);
            SourceExpression.Validate(bodyreserveStockRequestAllocs, nameof(bodyreserveStockRequestAllocs), required: false);
            SourceExpression.Validate(bodysalesOrder, nameof(bodysalesOrder), required: false);
            SourceExpression.Validate(bodysalesOrderDetails, nameof(bodysalesOrderDetails), required: false);
            SourceExpression.Validate(bodysalesOrderFooterComments, nameof(bodysalesOrderFooterComments), required: false);
            SourceExpression.Validate(bodysalesOrderFreightDetails, nameof(bodysalesOrderFreightDetails), required: false);
            SourceExpression.Validate(bodysalesOrderHeaderComments, nameof(bodysalesOrderHeaderComments), required: false);
            SourceExpression.Validate(bodysalesOrderMiscChargesDetails, nameof(bodysalesOrderMiscChargesDetails), required: false);
            SourceExpression.Validate(bodysalesOrderPromoQualifyAction, nameof(bodysalesOrderPromoQualifyAction), required: false);
            SourceExpression.Validate(bodysalesOrderPromoSelectAction, nameof(bodysalesOrderPromoSelectAction), required: false);
            SourceExpression.Validate(bodysalesperson, nameof(bodysalesperson), required: false);
            SourceExpression.Validate(bodysenderCode, nameof(bodysenderCode), required: false);
            SourceExpression.Validate(bodyshipAddress1, nameof(bodyshipAddress1), required: false);
            SourceExpression.Validate(bodyshipAddress2, nameof(bodyshipAddress2), required: false);
            SourceExpression.Validate(bodyshipAddress3, nameof(bodyshipAddress3), required: false);
            SourceExpression.Validate(bodyshipAddress3Locality, nameof(bodyshipAddress3Locality), required: false);
            SourceExpression.Validate(bodyshipAddress4, nameof(bodyshipAddress4), required: false);
            SourceExpression.Validate(bodyshipAddress5, nameof(bodyshipAddress5), required: false);
            SourceExpression.Validate(bodyshipAddressPerLine, nameof(bodyshipAddressPerLine), required: false);
            SourceExpression.Validate(bodyshipAddressPerLineTax, nameof(bodyshipAddressPerLineTax), required: false);
            SourceExpression.Validate(bodyshipGpsLat, nameof(bodyshipGpsLat), required: false);
            SourceExpression.Validate(bodyshipGpsLong, nameof(bodyshipGpsLong), required: false);
            SourceExpression.Validate(bodyshipPostalCode, nameof(bodyshipPostalCode), required: false);
            SourceExpression.Validate(bodyshippingInstrs, nameof(bodyshippingInstrs), required: false);
            SourceExpression.Validate(bodyshippingInstrsCode, nameof(bodyshippingInstrsCode), required: false);
            SourceExpression.Validate(bodyshippingLocation, nameof(bodyshippingLocation), required: false);
            SourceExpression.Validate(bodyspecialInstrs, nameof(bodyspecialInstrs), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodystatusInProcess, nameof(bodystatusInProcess), required: false);
            SourceExpression.Validate(bodystatusInProcessResponse, nameof(bodystatusInProcessResponse), required: false);
            SourceExpression.Validate(bodysupplier, nameof(bodysupplier), required: false);
            SourceExpression.Validate(bodytagsToDropFromXML, nameof(bodytagsToDropFromXML), required: false);
            SourceExpression.Validate(bodytaxExemptNumber, nameof(bodytaxExemptNumber), required: false);
            SourceExpression.Validate(bodytaxExemptionStatus, nameof(bodytaxExemptionStatus), required: false);
            SourceExpression.Validate(bodytransactionNature, nameof(bodytransactionNature), required: false);
            SourceExpression.Validate(bodytransmissionReference, nameof(bodytransmissionReference), required: false);
            SourceExpression.Validate(bodytransportMode, nameof(bodytransportMode), required: false);
            SourceExpression.Validate(bodytypeOfOrder, nameof(bodytypeOfOrder), required: false);
            SourceExpression.Validate(bodyuseCustomerSalesWarehouse, nameof(bodyuseCustomerSalesWarehouse), required: false);
            SourceExpression.Validate(bodyuseMasterAccountForCustomerPartNo, nameof(bodyuseMasterAccountForCustomerPartNo), required: false);
            SourceExpression.Validate(bodyuseStockDescSupplied, nameof(bodyuseStockDescSupplied), required: false);
            SourceExpression.Validate(bodyvalidateShippingInstrs, nameof(bodyvalidateShippingInstrs), required: false);
            SourceExpression.Validate(bodywarehouse, nameof(bodywarehouse), required: false);
            SourceExpression.Validate(bodywarehouseListToUse, nameof(bodywarehouseListToUse), required: false);
            SourceExpression.Validate(bodywarnIfCustomerOnHold, nameof(bodywarnIfCustomerOnHold), required: false);
            SourceExpression.Validate(bodyeSignature, nameof(bodyeSignature), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/syspro/salesorder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyacceptEarlierShipDate != null)
                {
                    body["AcceptEarlierShipDate"] = SourceExpressionConverter.ConvertToken(bodyacceptEarlierShipDate);
                    bodypropCount++;
                }

                if (bodyacceptKitOptional != null)
                {
                    body["AcceptKitOptional"] = SourceExpressionConverter.ConvertToken(bodyacceptKitOptional);
                    bodypropCount++;
                }

                if (bodyacceptOrdersIfNoCredit != null)
                {
                    body["AcceptOrdersIfNoCredit"] = SourceExpressionConverter.ConvertToken(bodyacceptOrdersIfNoCredit);
                    bodypropCount++;
                }

                if (bodyaddAttachedServiceCharges != null)
                {
                    body["AddAttachedServiceCharges"] = SourceExpressionConverter.ConvertToken(bodyaddAttachedServiceCharges);
                    bodypropCount++;
                }

                if (bodyaddDangerousGoodsText != null)
                {
                    body["AddDangerousGoodsText"] = SourceExpressionConverter.ConvertToken(bodyaddDangerousGoodsText);
                    bodypropCount++;
                }

                if (bodyaddStockSalesOrderText != null)
                {
                    body["AddStockSalesOrderText"] = SourceExpressionConverter.ConvertToken(bodyaddStockSalesOrderText);
                    bodypropCount++;
                }

                if (bodyallocationAction != null)
                {
                    body["AllocationAction"] = SourceExpressionConverter.ConvertToken(bodyallocationAction);
                    bodypropCount++;
                }

                if (bodyallowBackOrderForNegativeMerchLine != null)
                {
                    body["AllowBackOrderForNegativeMerchLine"] = SourceExpressionConverter.ConvertToken(bodyallowBackOrderForNegativeMerchLine);
                    bodypropCount++;
                }

                if (bodyallowBackOrderForPartialHold != null)
                {
                    body["AllowBackOrderForPartialHold"] = SourceExpressionConverter.ConvertToken(bodyallowBackOrderForPartialHold);
                    bodypropCount++;
                }

                if (bodyallowBackOrderForSuperseded != null)
                {
                    body["AllowBackOrderForSuperseded"] = SourceExpressionConverter.ConvertToken(bodyallowBackOrderForSuperseded);
                    bodypropCount++;
                }

                if (bodyallowChangeToZeroPrice != null)
                {
                    body["AllowChangeToZeroPrice"] = SourceExpressionConverter.ConvertToken(bodyallowChangeToZeroPrice);
                    bodypropCount++;
                }

                if (bodyallowDuplicateOrderNumbers != null)
                {
                    body["AllowDuplicateOrderNumbers"] = SourceExpressionConverter.ConvertToken(bodyallowDuplicateOrderNumbers);
                    bodypropCount++;
                }

                if (bodyallowManualOrderNumberToBeUsed != null)
                {
                    body["AllowManualOrderNumberToBeUsed"] = SourceExpressionConverter.ConvertToken(bodyallowManualOrderNumberToBeUsed);
                    bodypropCount++;
                }

                if (bodyallowNonStockItems != null)
                {
                    body["AllowNonStockItems"] = SourceExpressionConverter.ConvertToken(bodyallowNonStockItems);
                    bodypropCount++;
                }

                if (bodyallowZeroPrice != null)
                {
                    body["AllowZeroPrice"] = SourceExpressionConverter.ConvertToken(bodyallowZeroPrice);
                    bodypropCount++;
                }

                if (bodyalternateReference != null)
                {
                    body["AlternateReference"] = SourceExpressionConverter.ConvertToken(bodyalternateReference);
                    bodypropCount++;
                }

                if (bodyalwaysUsePriceEntered != null)
                {
                    body["AlwaysUsePriceEntered"] = SourceExpressionConverter.ConvertToken(bodyalwaysUsePriceEntered);
                    bodypropCount++;
                }

                if (bodyapplyLeadTimeCalculation != null)
                {
                    body["ApplyLeadTimeCalculation"] = SourceExpressionConverter.ConvertToken(bodyapplyLeadTimeCalculation);
                    bodypropCount++;
                }

                if (bodyapplyParentDiscountToComponents != null)
                {
                    body["ApplyParentDiscountToComponents"] = SourceExpressionConverter.ConvertToken(bodyapplyParentDiscountToComponents);
                    bodypropCount++;
                }

                if (bodyarea != null)
                {
                    body["Area"] = SourceExpressionConverter.ConvertToken(bodyarea);
                    bodypropCount++;
                }

                if (bodybranch != null)
                {
                    body["Branch"] = SourceExpressionConverter.ConvertToken(bodybranch);
                    bodypropCount++;
                }

                if (bodycancelReasonCode != null)
                {
                    body["CancelReasonCode"] = SourceExpressionConverter.ConvertToken(bodycancelReasonCode);
                    bodypropCount++;
                }

                if (bodycheckForCustomerPoNumbers != null)
                {
                    body["CheckForCustomerPoNumbers"] = SourceExpressionConverter.ConvertToken(bodycheckForCustomerPoNumbers);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["City"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycompanyTaxNumber != null)
                {
                    body["CompanyTaxNumber"] = SourceExpressionConverter.ConvertToken(bodycompanyTaxNumber);
                    bodypropCount++;
                }

                if (bodycountyZip != null)
                {
                    body["CountyZip"] = SourceExpressionConverter.ConvertToken(bodycountyZip);
                    bodypropCount++;
                }

                if (bodycreditFailMessage != null)
                {
                    body["CreditFailMessage"] = SourceExpressionConverter.ConvertToken(bodycreditFailMessage);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    body["Currency"] = SourceExpressionConverter.ConvertToken(bodycurrency);
                    bodypropCount++;
                }

                if (bodycustomer != null)
                {
                    body["Customer"] = SourceExpressionConverter.ConvertToken(bodycustomer);
                    bodypropCount++;
                }

                if (bodycustomerName != null)
                {
                    body["CustomerName"] = SourceExpressionConverter.ConvertToken(bodycustomerName);
                    bodypropCount++;
                }

                if (bodycustomerPoNumber != null)
                {
                    body["CustomerPoNumber"] = SourceExpressionConverter.ConvertToken(bodycustomerPoNumber);
                    bodypropCount++;
                }

                if (bodycustomerToUse != null)
                {
                    body["CustomerToUse"] = SourceExpressionConverter.ConvertToken(bodycustomerToUse);
                    bodypropCount++;
                }

                if (bodydeliveryRoute != null)
                {
                    body["DeliveryRoute"] = SourceExpressionConverter.ConvertToken(bodydeliveryRoute);
                    bodypropCount++;
                }

                if (bodydeliveryRouteAction != null)
                {
                    body["DeliveryRouteAction"] = SourceExpressionConverter.ConvertToken(bodydeliveryRouteAction);
                    bodypropCount++;
                }

                if (bodydeliveryTerms != null)
                {
                    body["DeliveryTerms"] = SourceExpressionConverter.ConvertToken(bodydeliveryTerms);
                    bodypropCount++;
                }

                if (bodydocumentFormat != null)
                {
                    body["DocumentFormat"] = SourceExpressionConverter.ConvertToken(bodydocumentFormat);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyglobalTradePromotionCodes != null)
                {
                    body["GlobalTradePromotionCodes"] = SourceExpressionConverter.ConvertToken(bodyglobalTradePromotionCodes);
                    bodypropCount++;
                }

                if (bodygstExemptNumber != null)
                {
                    body["GstExemptNumber"] = SourceExpressionConverter.ConvertToken(bodygstExemptNumber);
                    bodypropCount++;
                }

                if (bodygstExemptionStatus != null)
                {
                    body["GstExemptionStatus"] = SourceExpressionConverter.ConvertToken(bodygstExemptionStatus);
                    bodypropCount++;
                }

                if (bodyheaderFreightCharges != null)
                {
                    body["HeaderFreightCharges"] = SourceExpressionConverter.ConvertToken(bodyheaderFreightCharges);
                    bodypropCount++;
                }

                if (bodyheaderMiscCharges != null)
                {
                    body["HeaderMiscCharges"] = SourceExpressionConverter.ConvertToken(bodyheaderMiscCharges);
                    bodypropCount++;
                }

                if (bodyignoreWarnings != null)
                {
                    body["IgnoreWarnings"] = SourceExpressionConverter.ConvertToken(bodyignoreWarnings);
                    bodypropCount++;
                }

                if (bodyinBoxMsgReqd != null)
                {
                    body["InBoxMsgReqd"] = SourceExpressionConverter.ConvertToken(bodyinBoxMsgReqd);
                    bodypropCount++;
                }

                if (bodyincludeInMrp != null)
                {
                    body["IncludeInMrp"] = SourceExpressionConverter.ConvertToken(bodyincludeInMrp);
                    bodypropCount++;
                }

                if (bodyinvoiceDateEntered != null)
                {
                    body["InvoiceDateEntered"] = SourceExpressionConverter.ConvertToken(bodyinvoiceDateEntered);
                    bodypropCount++;
                }

                if (bodyinvoiceNumberEntered != null)
                {
                    body["InvoiceNumberEntered"] = SourceExpressionConverter.ConvertToken(bodyinvoiceNumberEntered);
                    bodypropCount++;
                }

                if (bodyinvoiceTerms != null)
                {
                    body["InvoiceTerms"] = SourceExpressionConverter.ConvertToken(bodyinvoiceTerms);
                    bodypropCount++;
                }

                if (bodyinvoiceWholeOrderOnly != null)
                {
                    body["InvoiceWholeOrderOnly"] = SourceExpressionConverter.ConvertToken(bodyinvoiceWholeOrderOnly);
                    bodypropCount++;
                }

                if (bodylanguageCode != null)
                {
                    body["LanguageCode"] = SourceExpressionConverter.ConvertToken(bodylanguageCode);
                    bodypropCount++;
                }

                if (bodyminimumDaysToShip != null)
                {
                    body["MinimumDaysToShip"] = SourceExpressionConverter.ConvertToken(bodyminimumDaysToShip);
                    bodypropCount++;
                }

                if (bodymultiShipCode != null)
                {
                    body["MultiShipCode"] = SourceExpressionConverter.ConvertToken(bodymultiShipCode);
                    bodypropCount++;
                }

                if (bodynationality != null)
                {
                    body["Nationality"] = SourceExpressionConverter.ConvertToken(bodynationality);
                    bodypropCount++;
                }

                if (bodynewCustomerPoNumber != null)
                {
                    body["NewCustomerPoNumber"] = SourceExpressionConverter.ConvertToken(bodynewCustomerPoNumber);
                    bodypropCount++;
                }

                if (bodynewSalesOrderNumber != null)
                {
                    body["NewSalesOrderNumber"] = SourceExpressionConverter.ConvertToken(bodynewSalesOrderNumber);
                    bodypropCount++;
                }

                if (bodyoperatorToInform != null)
                {
                    body["OperatorToInform"] = SourceExpressionConverter.ConvertToken(bodyoperatorToInform);
                    bodypropCount++;
                }

                if (bodyorderActionType != null)
                {
                    body["OrderActionType"] = SourceExpressionConverter.ConvertToken(bodyorderActionType);
                    bodypropCount++;
                }

                if (bodyorderComments != null)
                {
                    body["OrderComments"] = SourceExpressionConverter.ConvertToken(bodyorderComments);
                    bodypropCount++;
                }

                if (bodyorderDate != null)
                {
                    body["OrderDate"] = SourceExpressionConverter.ConvertToken(bodyorderDate);
                    bodypropCount++;
                }

                if (bodyorderDiscPercent1 != null)
                {
                    body["OrderDiscPercent1"] = SourceExpressionConverter.ConvertToken(bodyorderDiscPercent1);
                    bodypropCount++;
                }

                if (bodyorderDiscPercent2 != null)
                {
                    body["OrderDiscPercent2"] = SourceExpressionConverter.ConvertToken(bodyorderDiscPercent2);
                    bodypropCount++;
                }

                if (bodyorderDiscPercent3 != null)
                {
                    body["OrderDiscPercent3"] = SourceExpressionConverter.ConvertToken(bodyorderDiscPercent3);
                    bodypropCount++;
                }

                if (bodyorderStatus != null)
                {
                    body["OrderStatus"] = SourceExpressionConverter.ConvertToken(bodyorderStatus);
                    bodypropCount++;
                }

                if (bodyorderType != null)
                {
                    body["OrderType"] = SourceExpressionConverter.ConvertToken(bodyorderType);
                    bodypropCount++;
                }

                if (bodyoverrideCustomerBackOrder != null)
                {
                    body["OverrideCustomerBackOrder"] = SourceExpressionConverter.ConvertToken(bodyoverrideCustomerBackOrder);
                    bodypropCount++;
                }

                if (bodypOSSalesOrder != null)
                {
                    body["POSSalesOrder"] = SourceExpressionConverter.ConvertToken(bodypOSSalesOrder);
                    bodypropCount++;
                }

                if (bodyprocess != null)
                {
                    body["Process"] = SourceExpressionConverter.ConvertToken(bodyprocess);
                    bodypropCount++;
                }

                if (bodyprocessFlag != null)
                {
                    body["ProcessFlag"] = SourceExpressionConverter.ConvertToken(bodyprocessFlag);
                    bodypropCount++;
                }

                if (bodyputEntireQuantityOnNewLoadWhenChanged != null)
                {
                    body["PutEntireQuantityOnNewLoadWhenChanged"] = SourceExpressionConverter.ConvertToken(bodyputEntireQuantityOnNewLoadWhenChanged);
                    bodypropCount++;
                }

                if (bodyreceiverCode != null)
                {
                    body["ReceiverCode"] = SourceExpressionConverter.ConvertToken(bodyreceiverCode);
                    bodypropCount++;
                }

                if (bodyrequestedShipDate != null)
                {
                    body["RequestedShipDate"] = SourceExpressionConverter.ConvertToken(bodyrequestedShipDate);
                    bodypropCount++;
                }

                if (bodyreserveStock != null)
                {
                    body["ReserveStock"] = SourceExpressionConverter.ConvertToken(bodyreserveStock);
                    bodypropCount++;
                }

                if (bodyreserveStockRequestAllocs != null)
                {
                    body["ReserveStockRequestAllocs"] = SourceExpressionConverter.ConvertToken(bodyreserveStockRequestAllocs);
                    bodypropCount++;
                }

                if (bodysalesOrder != null)
                {
                    body["SalesOrder"] = SourceExpressionConverter.ConvertToken(bodysalesOrder);
                    bodypropCount++;
                }

                if (bodysalesOrderDetails != null)
                {
                    body["SalesOrderDetails"] = SourceExpressionConverter.ConvertToken(bodysalesOrderDetails);
                    bodypropCount++;
                }

                if (bodysalesOrderFooterComments != null)
                {
                    body["SalesOrderFooterComments"] = SourceExpressionConverter.ConvertToken(bodysalesOrderFooterComments);
                    bodypropCount++;
                }

                if (bodysalesOrderFreightDetails != null)
                {
                    body["SalesOrderFreightDetails"] = SourceExpressionConverter.ConvertToken(bodysalesOrderFreightDetails);
                    bodypropCount++;
                }

                if (bodysalesOrderHeaderComments != null)
                {
                    body["SalesOrderHeaderComments"] = SourceExpressionConverter.ConvertToken(bodysalesOrderHeaderComments);
                    bodypropCount++;
                }

                if (bodysalesOrderMiscChargesDetails != null)
                {
                    body["SalesOrderMiscChargesDetails"] = SourceExpressionConverter.ConvertToken(bodysalesOrderMiscChargesDetails);
                    bodypropCount++;
                }

                if (bodysalesOrderPromoQualifyAction != null)
                {
                    body["SalesOrderPromoQualifyAction"] = SourceExpressionConverter.ConvertToken(bodysalesOrderPromoQualifyAction);
                    bodypropCount++;
                }

                if (bodysalesOrderPromoSelectAction != null)
                {
                    body["SalesOrderPromoSelectAction"] = SourceExpressionConverter.ConvertToken(bodysalesOrderPromoSelectAction);
                    bodypropCount++;
                }

                if (bodysalesperson != null)
                {
                    body["Salesperson"] = SourceExpressionConverter.ConvertToken(bodysalesperson);
                    bodypropCount++;
                }

                if (bodysenderCode != null)
                {
                    body["SenderCode"] = SourceExpressionConverter.ConvertToken(bodysenderCode);
                    bodypropCount++;
                }

                if (bodyshipAddress1 != null)
                {
                    body["ShipAddress1"] = SourceExpressionConverter.ConvertToken(bodyshipAddress1);
                    bodypropCount++;
                }

                if (bodyshipAddress2 != null)
                {
                    body["ShipAddress2"] = SourceExpressionConverter.ConvertToken(bodyshipAddress2);
                    bodypropCount++;
                }

                if (bodyshipAddress3 != null)
                {
                    body["ShipAddress3"] = SourceExpressionConverter.ConvertToken(bodyshipAddress3);
                    bodypropCount++;
                }

                if (bodyshipAddress3Locality != null)
                {
                    body["ShipAddress3Locality"] = SourceExpressionConverter.ConvertToken(bodyshipAddress3Locality);
                    bodypropCount++;
                }

                if (bodyshipAddress4 != null)
                {
                    body["ShipAddress4"] = SourceExpressionConverter.ConvertToken(bodyshipAddress4);
                    bodypropCount++;
                }

                if (bodyshipAddress5 != null)
                {
                    body["ShipAddress5"] = SourceExpressionConverter.ConvertToken(bodyshipAddress5);
                    bodypropCount++;
                }

                if (bodyshipAddressPerLine != null)
                {
                    body["ShipAddressPerLine"] = SourceExpressionConverter.ConvertToken(bodyshipAddressPerLine);
                    bodypropCount++;
                }

                if (bodyshipAddressPerLineTax != null)
                {
                    body["ShipAddressPerLineTax"] = SourceExpressionConverter.ConvertToken(bodyshipAddressPerLineTax);
                    bodypropCount++;
                }

                if (bodyshipGpsLat != null)
                {
                    body["ShipGpsLat"] = SourceExpressionConverter.ConvertToken(bodyshipGpsLat);
                    bodypropCount++;
                }

                if (bodyshipGpsLong != null)
                {
                    body["ShipGpsLong"] = SourceExpressionConverter.ConvertToken(bodyshipGpsLong);
                    bodypropCount++;
                }

                if (bodyshipPostalCode != null)
                {
                    body["ShipPostalCode"] = SourceExpressionConverter.ConvertToken(bodyshipPostalCode);
                    bodypropCount++;
                }

                if (bodyshippingInstrs != null)
                {
                    body["ShippingInstrs"] = SourceExpressionConverter.ConvertToken(bodyshippingInstrs);
                    bodypropCount++;
                }

                if (bodyshippingInstrsCode != null)
                {
                    body["ShippingInstrsCode"] = SourceExpressionConverter.ConvertToken(bodyshippingInstrsCode);
                    bodypropCount++;
                }

                if (bodyshippingLocation != null)
                {
                    body["ShippingLocation"] = SourceExpressionConverter.ConvertToken(bodyshippingLocation);
                    bodypropCount++;
                }

                if (bodyspecialInstrs != null)
                {
                    body["SpecialInstrs"] = SourceExpressionConverter.ConvertToken(bodyspecialInstrs);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["State"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodystatusInProcess != null)
                {
                    body["StatusInProcess"] = SourceExpressionConverter.ConvertToken(bodystatusInProcess);
                    bodypropCount++;
                }

                if (bodystatusInProcessResponse != null)
                {
                    body["StatusInProcessResponse"] = SourceExpressionConverter.ConvertToken(bodystatusInProcessResponse);
                    bodypropCount++;
                }

                if (bodysupplier != null)
                {
                    body["Supplier"] = SourceExpressionConverter.ConvertToken(bodysupplier);
                    bodypropCount++;
                }

                if (bodytagsToDropFromXML != null)
                {
                    body["TagsToDropFromXML"] = SourceExpressionConverter.ConvertToken(bodytagsToDropFromXML);
                    bodypropCount++;
                }

                if (bodytaxExemptNumber != null)
                {
                    body["TaxExemptNumber"] = SourceExpressionConverter.ConvertToken(bodytaxExemptNumber);
                    bodypropCount++;
                }

                if (bodytaxExemptionStatus != null)
                {
                    body["TaxExemptionStatus"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionStatus);
                    bodypropCount++;
                }

                if (bodytransactionNature != null)
                {
                    body["TransactionNature"] = SourceExpressionConverter.ConvertToken(bodytransactionNature);
                    bodypropCount++;
                }

                if (bodytransmissionReference != null)
                {
                    body["TransmissionReference"] = SourceExpressionConverter.ConvertToken(bodytransmissionReference);
                    bodypropCount++;
                }

                if (bodytransportMode != null)
                {
                    body["TransportMode"] = SourceExpressionConverter.ConvertToken(bodytransportMode);
                    bodypropCount++;
                }

                if (bodytypeOfOrder != null)
                {
                    body["TypeOfOrder"] = SourceExpressionConverter.ConvertToken(bodytypeOfOrder);
                    bodypropCount++;
                }

                if (bodyuseCustomerSalesWarehouse != null)
                {
                    body["UseCustomerSalesWarehouse"] = SourceExpressionConverter.ConvertToken(bodyuseCustomerSalesWarehouse);
                    bodypropCount++;
                }

                if (bodyuseMasterAccountForCustomerPartNo != null)
                {
                    body["UseMasterAccountForCustomerPartNo"] = SourceExpressionConverter.ConvertToken(bodyuseMasterAccountForCustomerPartNo);
                    bodypropCount++;
                }

                if (bodyuseStockDescSupplied != null)
                {
                    body["UseStockDescSupplied"] = SourceExpressionConverter.ConvertToken(bodyuseStockDescSupplied);
                    bodypropCount++;
                }

                if (bodyvalidateShippingInstrs != null)
                {
                    body["ValidateShippingInstrs"] = SourceExpressionConverter.ConvertToken(bodyvalidateShippingInstrs);
                    bodypropCount++;
                }

                if (bodywarehouse != null)
                {
                    body["Warehouse"] = SourceExpressionConverter.ConvertToken(bodywarehouse);
                    bodypropCount++;
                }

                if (bodywarehouseListToUse != null)
                {
                    body["WarehouseListToUse"] = SourceExpressionConverter.ConvertToken(bodywarehouseListToUse);
                    bodypropCount++;
                }

                if (bodywarnIfCustomerOnHold != null)
                {
                    body["WarnIfCustomerOnHold"] = SourceExpressionConverter.ConvertToken(bodywarnIfCustomerOnHold);
                    bodypropCount++;
                }

                if (bodyeSignature != null)
                {
                    body["eSignature"] = SourceExpressionConverter.ConvertToken(bodyeSignature);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SYSPROCreateNewSalesOrderResponse>(BuildSourceInput);
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