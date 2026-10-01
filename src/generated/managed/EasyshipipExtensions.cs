//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyshipip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyshipipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetRatesTaxesResponse> GetRatesTaxes([WorkflowExpression] Func<string> bodyoriginAddressline1 = null, [WorkflowExpression] Func<string> bodyoriginAddressline2 = null, [WorkflowExpression] Func<string> bodyoriginAddressstate = null, [WorkflowExpression] Func<string> bodyoriginAddresscity = null, [WorkflowExpression] Func<string> bodyoriginAddresspostalCode = null, [WorkflowExpression] Func<string> bodyoriginAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodydestinationAddressline1 = null, [WorkflowExpression] Func<string> bodydestinationAddressline2 = null, [WorkflowExpression] Func<string> bodydestinationAddressstate = null, [WorkflowExpression] Func<string> bodydestinationAddresscity = null, [WorkflowExpression] Func<string> bodydestinationAddresspostalCode = null, [WorkflowExpression] Func<string> bodydestinationAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodyincoterms = null, [WorkflowExpression] Func<bool> bodyinsuranceisInsured = null, [WorkflowExpression] Func<int> bodyinsuranceinsuredAmount = null, [WorkflowExpression] Func<string> bodyinsuranceinsuredCurrency = null, [WorkflowExpression] Func<bool> bodycourierSelectionapplyShippingRules = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsweight = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsdimensions = null, [WorkflowExpression] Func<string> bodyshippingSettingsoutputCurrency = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/rates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var originAddressObject = new JObject();
                var originAddressObjectpropCount = 0;
                if (bodyoriginAddressline1 != null)
                {
                    originAddressObject["line_1"] = SourceExpressionConverter.ConvertToken(bodyoriginAddressline1);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressline2 != null)
                {
                    originAddressObject["line_2"] = SourceExpressionConverter.ConvertToken(bodyoriginAddressline2);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressstate != null)
                {
                    originAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodyoriginAddressstate);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscity != null)
                {
                    originAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscity);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresspostalCode != null)
                {
                    originAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresspostalCode);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscountryAlpha2 != null)
                {
                    originAddressObject["country_alpha2"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscountryAlpha2);
                    originAddressObjectpropCount++;
                }

                if (originAddressObjectpropCount > 0)
                {
                    body["origin_address"] = originAddressObject;
                    bodypropCount++;
                }

                var destinationAddressObject = new JObject();
                var destinationAddressObjectpropCount = 0;
                if (bodydestinationAddressline1 != null)
                {
                    destinationAddressObject["line_1"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressline1);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressline2 != null)
                {
                    destinationAddressObject["line_2"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressline2);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressstate != null)
                {
                    destinationAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressstate);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscity != null)
                {
                    destinationAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscity);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresspostalCode != null)
                {
                    destinationAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresspostalCode);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscountryAlpha2 != null)
                {
                    destinationAddressObject["country_alpha2"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscountryAlpha2);
                    destinationAddressObjectpropCount++;
                }

                if (destinationAddressObjectpropCount > 0)
                {
                    body["destination_address"] = destinationAddressObject;
                    bodypropCount++;
                }

                if (bodyincoterms != null)
                {
                    body["incoterms"] = SourceExpressionConverter.ConvertToken(bodyincoterms);
                    bodypropCount++;
                }

                var insuranceObject = new JObject();
                var insuranceObjectpropCount = 0;
                if (bodyinsuranceisInsured != null)
                {
                    insuranceObject["is_insured"] = SourceExpressionConverter.ConvertToken(bodyinsuranceisInsured);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredAmount != null)
                {
                    insuranceObject["insured_amount"] = SourceExpressionConverter.ConvertToken(bodyinsuranceinsuredAmount);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredCurrency != null)
                {
                    insuranceObject["insured_currency"] = SourceExpressionConverter.ConvertToken(bodyinsuranceinsuredCurrency);
                    insuranceObjectpropCount++;
                }

                if (insuranceObjectpropCount > 0)
                {
                    body["insurance"] = insuranceObject;
                    bodypropCount++;
                }

                var courierSelectionObject = new JObject();
                var courierSelectionObjectpropCount = 0;
                if (bodycourierSelectionapplyShippingRules != null)
                {
                    courierSelectionObject["apply_shipping_rules"] = SourceExpressionConverter.ConvertToken(bodycourierSelectionapplyShippingRules);
                    courierSelectionObjectpropCount++;
                }

                if (courierSelectionObjectpropCount > 0)
                {
                    body["courier_selection"] = courierSelectionObject;
                    bodypropCount++;
                }

                var shippingSettingsObject = new JObject();
                var shippingSettingsObjectpropCount = 0;
                var unitsObject = new JObject();
                var unitsObjectpropCount = 0;
                if (bodyshippingSettingsunitsweight != null)
                {
                    unitsObject["weight"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsunitsweight);
                    unitsObjectpropCount++;
                }

                if (bodyshippingSettingsunitsdimensions != null)
                {
                    unitsObject["dimensions"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsunitsdimensions);
                    unitsObjectpropCount++;
                }

                if (unitsObjectpropCount > 0)
                {
                    shippingSettingsObject["units"] = unitsObject;
                    shippingSettingsObjectpropCount++;
                }

                if (bodyshippingSettingsoutputCurrency != null)
                {
                    shippingSettingsObject["output_currency"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsoutputCurrency);
                    shippingSettingsObjectpropCount++;
                }

                if (shippingSettingsObjectpropCount > 0)
                {
                    body["shipping_settings"] = shippingSettingsObject;
                    bodypropCount++;
                }

                if (bodyparcels != null)
                {
                    body["parcels"] = SourceExpressionConverter.ConvertToken(bodyparcels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetRatesTaxesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<ListAllShipmentsResponse> ListAllShipments([WorkflowExpression] Func<string> easyshipShipmentId = null, [WorkflowExpression] Func<string> platformOrderNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> createdAtFrom = null, [WorkflowExpression] Func<string> createdAtTo = null, [WorkflowExpression] Func<string> confirmedAtFrom = null, [WorkflowExpression] Func<string> confirmAtTo = null, [WorkflowExpression] Func<string> labelGeneratedAtFrom = null, [WorkflowExpression] Func<string> labelGeneratedAtTo = null, [WorkflowExpression] Func<string> shipmentState = null, [WorkflowExpression] Func<string> pickupState = null, [WorkflowExpression] Func<string> deliveryState = null, [WorkflowExpression] Func<string> labelState = null, [WorkflowExpression] Func<string> warehouseState = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/shipments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (easyshipShipmentId != null)
                    callPayload.Queries["easyship_shipment_id"] = SourceExpressionConverter.ConvertO(easyshipShipmentId);
                if (platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = SourceExpressionConverter.ConvertO(platformOrderNumber);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                if (createdAtFrom != null)
                    callPayload.Queries["created_at_from"] = SourceExpressionConverter.ConvertO(createdAtFrom);
                if (createdAtTo != null)
                    callPayload.Queries["created_at_to"] = SourceExpressionConverter.ConvertO(createdAtTo);
                if (confirmedAtFrom != null)
                    callPayload.Queries["confirmed_at_from"] = SourceExpressionConverter.ConvertO(confirmedAtFrom);
                if (confirmAtTo != null)
                    callPayload.Queries["confirm_at_to"] = SourceExpressionConverter.ConvertO(confirmAtTo);
                if (labelGeneratedAtFrom != null)
                    callPayload.Queries["label_generated_at_from"] = SourceExpressionConverter.ConvertO(labelGeneratedAtFrom);
                if (labelGeneratedAtTo != null)
                    callPayload.Queries["label_generated_at_to"] = SourceExpressionConverter.ConvertO(labelGeneratedAtTo);
                if (shipmentState != null)
                    callPayload.Queries["shipment_state"] = SourceExpressionConverter.ConvertO(shipmentState);
                if (pickupState != null)
                    callPayload.Queries["pickup_state"] = SourceExpressionConverter.ConvertO(pickupState);
                if (deliveryState != null)
                    callPayload.Queries["delivery_state"] = SourceExpressionConverter.ConvertO(deliveryState);
                if (labelState != null)
                    callPayload.Queries["label_state"] = SourceExpressionConverter.ConvertO(labelState);
                if (warehouseState != null)
                    callPayload.Queries["warehouse_state"] = SourceExpressionConverter.ConvertO(warehouseState);
                return callPayload;
            }

            return new ApiConnectionAction<ListAllShipmentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<CreateAShipmentResponse> CreateAShipment([WorkflowExpression] Func<string> bodyoriginAddressline1 = null, [WorkflowExpression] Func<string> bodyoriginAddressline2 = null, [WorkflowExpression] Func<string> bodyoriginAddressstate = null, [WorkflowExpression] Func<string> bodyoriginAddresscity = null, [WorkflowExpression] Func<string> bodyoriginAddresspostalCode = null, [WorkflowExpression] Func<string> bodyoriginAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodyoriginAddresscontactName = null, [WorkflowExpression] Func<string> bodyoriginAddresscompanyName = null, [WorkflowExpression] Func<string> bodyoriginAddresscontactPhone = null, [WorkflowExpression] Func<string> bodyoriginAddresscontactEmail = null, [WorkflowExpression] Func<string> bodysenderAddressline1 = null, [WorkflowExpression] Func<string> bodysenderAddressline2 = null, [WorkflowExpression] Func<string> bodysenderAddressstate = null, [WorkflowExpression] Func<string> bodysenderAddresscity = null, [WorkflowExpression] Func<string> bodysenderAddresspostalCode = null, [WorkflowExpression] Func<string> bodysenderAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodysenderAddresscontactName = null, [WorkflowExpression] Func<string> bodysenderAddresscompanyName = null, [WorkflowExpression] Func<string> bodysenderAddresscontactPhone = null, [WorkflowExpression] Func<string> bodysenderAddresscontactEmail = null, [WorkflowExpression] Func<string> bodyreturnAddressline1 = null, [WorkflowExpression] Func<string> bodyreturnAddressline2 = null, [WorkflowExpression] Func<string> bodyreturnAddressstate = null, [WorkflowExpression] Func<string> bodyreturnAddresscity = null, [WorkflowExpression] Func<string> bodyreturnAddresspostalCode = null, [WorkflowExpression] Func<string> bodyreturnAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodyreturnAddresscontactName = null, [WorkflowExpression] Func<string> bodyreturnAddresscompanyName = null, [WorkflowExpression] Func<string> bodyreturnAddresscontactPhone = null, [WorkflowExpression] Func<string> bodyreturnAddresscontactEmail = null, [WorkflowExpression] Func<string> bodydestinationAddressline1 = null, [WorkflowExpression] Func<string> bodydestinationAddressline2 = null, [WorkflowExpression] Func<string> bodydestinationAddressstate = null, [WorkflowExpression] Func<string> bodydestinationAddresscity = null, [WorkflowExpression] Func<string> bodydestinationAddresspostalCode = null, [WorkflowExpression] Func<string> bodydestinationAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodydestinationAddresscontactName = null, [WorkflowExpression] Func<string> bodydestinationAddresscompanyName = null, [WorkflowExpression] Func<string> bodydestinationAddresscontactPhone = null, [WorkflowExpression] Func<string> bodydestinationAddresscontactEmail = null, [WorkflowExpression] Func<bool> bodysetAsResidential = null, [WorkflowExpression] Func<string> bodyconsigneeTaxId = null, [WorkflowExpression] Func<string> bodyeeiReference = null, [WorkflowExpression] Func<string> bodyincoterms = null, [WorkflowExpression] Func<bool> bodyinsuranceisInsured = null, [WorkflowExpression] Func<int> bodyinsuranceinsuredAmount = null, [WorkflowExpression] Func<string> bodyinsuranceinsuredCurrency = null, [WorkflowExpression] Func<string> bodyorderDataplatformName = null, [WorkflowExpression] Func<string> bodyorderDataplatformOrderNumber = null, [WorkflowExpression] Func<string[]> bodyorderDataorderTagList = null, [WorkflowExpression] Func<string> bodyorderDatasellerNotes = null, [WorkflowExpression] Func<string> bodyorderDatabuyerNotes = null, [WorkflowExpression] Func<string> bodycourierSelectionselectedCourierId = null, [WorkflowExpression] Func<bool> bodycourierSelectionallowCourierFallback = null, [WorkflowExpression] Func<bool> bodycourierSelectionapplyShippingRules = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsweight = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsdimensions = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionsformat = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionslabel = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionscommercialInvoice = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionspackingSlip = null, [WorkflowExpression] Func<bool> bodyshippingSettingsbuyLabel = null, [WorkflowExpression] Func<bool> bodyshippingSettingsbuyLabelSynchronous = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var originAddressObject = new JObject();
                var originAddressObjectpropCount = 0;
                if (bodyoriginAddressline1 != null)
                {
                    originAddressObject["line_1"] = SourceExpressionConverter.ConvertToken(bodyoriginAddressline1);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressline2 != null)
                {
                    originAddressObject["line_2"] = SourceExpressionConverter.ConvertToken(bodyoriginAddressline2);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressstate != null)
                {
                    originAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodyoriginAddressstate);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscity != null)
                {
                    originAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscity);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresspostalCode != null)
                {
                    originAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresspostalCode);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscountryAlpha2 != null)
                {
                    originAddressObject["country_alpha2"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscountryAlpha2);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscontactName != null)
                {
                    originAddressObject["contact_name"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscontactName);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscompanyName != null)
                {
                    originAddressObject["company_name"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscompanyName);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscontactPhone != null)
                {
                    originAddressObject["contact_phone"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscontactPhone);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscontactEmail != null)
                {
                    originAddressObject["contact_email"] = SourceExpressionConverter.ConvertToken(bodyoriginAddresscontactEmail);
                    originAddressObjectpropCount++;
                }

                if (originAddressObjectpropCount > 0)
                {
                    body["origin_address"] = originAddressObject;
                    bodypropCount++;
                }

                var senderAddressObject = new JObject();
                var senderAddressObjectpropCount = 0;
                if (bodysenderAddressline1 != null)
                {
                    senderAddressObject["line_1"] = SourceExpressionConverter.ConvertToken(bodysenderAddressline1);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddressline2 != null)
                {
                    senderAddressObject["line_2"] = SourceExpressionConverter.ConvertToken(bodysenderAddressline2);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddressstate != null)
                {
                    senderAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodysenderAddressstate);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscity != null)
                {
                    senderAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodysenderAddresscity);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresspostalCode != null)
                {
                    senderAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodysenderAddresspostalCode);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscountryAlpha2 != null)
                {
                    senderAddressObject["country_alpha2"] = SourceExpressionConverter.ConvertToken(bodysenderAddresscountryAlpha2);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscontactName != null)
                {
                    senderAddressObject["contact_name"] = SourceExpressionConverter.ConvertToken(bodysenderAddresscontactName);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscompanyName != null)
                {
                    senderAddressObject["company_name"] = SourceExpressionConverter.ConvertToken(bodysenderAddresscompanyName);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscontactPhone != null)
                {
                    senderAddressObject["contact_phone"] = SourceExpressionConverter.ConvertToken(bodysenderAddresscontactPhone);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscontactEmail != null)
                {
                    senderAddressObject["contact_email"] = SourceExpressionConverter.ConvertToken(bodysenderAddresscontactEmail);
                    senderAddressObjectpropCount++;
                }

                if (senderAddressObjectpropCount > 0)
                {
                    body["sender_address"] = senderAddressObject;
                    bodypropCount++;
                }

                var returnAddressObject = new JObject();
                var returnAddressObjectpropCount = 0;
                if (bodyreturnAddressline1 != null)
                {
                    returnAddressObject["line_1"] = SourceExpressionConverter.ConvertToken(bodyreturnAddressline1);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddressline2 != null)
                {
                    returnAddressObject["line_2"] = SourceExpressionConverter.ConvertToken(bodyreturnAddressline2);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddressstate != null)
                {
                    returnAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodyreturnAddressstate);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscity != null)
                {
                    returnAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresscity);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresspostalCode != null)
                {
                    returnAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresspostalCode);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscountryAlpha2 != null)
                {
                    returnAddressObject["country_alpha2"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresscountryAlpha2);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscontactName != null)
                {
                    returnAddressObject["contact_name"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresscontactName);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscompanyName != null)
                {
                    returnAddressObject["company_name"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresscompanyName);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscontactPhone != null)
                {
                    returnAddressObject["contact_phone"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresscontactPhone);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscontactEmail != null)
                {
                    returnAddressObject["contact_email"] = SourceExpressionConverter.ConvertToken(bodyreturnAddresscontactEmail);
                    returnAddressObjectpropCount++;
                }

                if (returnAddressObjectpropCount > 0)
                {
                    body["return_address"] = returnAddressObject;
                    bodypropCount++;
                }

                var destinationAddressObject = new JObject();
                var destinationAddressObjectpropCount = 0;
                if (bodydestinationAddressline1 != null)
                {
                    destinationAddressObject["line_1"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressline1);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressline2 != null)
                {
                    destinationAddressObject["line_2"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressline2);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressstate != null)
                {
                    destinationAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressstate);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscity != null)
                {
                    destinationAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscity);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresspostalCode != null)
                {
                    destinationAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresspostalCode);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscountryAlpha2 != null)
                {
                    destinationAddressObject["country_alpha2"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscountryAlpha2);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscontactName != null)
                {
                    destinationAddressObject["contact_name"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscontactName);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscompanyName != null)
                {
                    destinationAddressObject["company_name"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscompanyName);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscontactPhone != null)
                {
                    destinationAddressObject["contact_phone"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscontactPhone);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscontactEmail != null)
                {
                    destinationAddressObject["contact_email"] = SourceExpressionConverter.ConvertToken(bodydestinationAddresscontactEmail);
                    destinationAddressObjectpropCount++;
                }

                if (destinationAddressObjectpropCount > 0)
                {
                    body["destination_address"] = destinationAddressObject;
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodysetAsResidential != null)
                {
                    body["set_as_residential"] = SourceExpressionConverter.ConvertToken(bodysetAsResidential);
                    bodypropCount++;
                }

                if (bodyconsigneeTaxId != null)
                {
                    body["consignee_tax_id"] = SourceExpressionConverter.ConvertToken(bodyconsigneeTaxId);
                    bodypropCount++;
                }

                if (bodyeeiReference != null)
                {
                    body["eei_reference"] = SourceExpressionConverter.ConvertToken(bodyeeiReference);
                    bodypropCount++;
                }

                if (bodyincoterms != null)
                {
                    body["incoterms"] = SourceExpressionConverter.ConvertToken(bodyincoterms);
                    bodypropCount++;
                }

                var insuranceObject = new JObject();
                var insuranceObjectpropCount = 0;
                if (bodyinsuranceisInsured != null)
                {
                    insuranceObject["is_insured"] = SourceExpressionConverter.ConvertToken(bodyinsuranceisInsured);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredAmount != null)
                {
                    insuranceObject["insured_amount"] = SourceExpressionConverter.ConvertToken(bodyinsuranceinsuredAmount);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredCurrency != null)
                {
                    insuranceObject["insured_currency"] = SourceExpressionConverter.ConvertToken(bodyinsuranceinsuredCurrency);
                    insuranceObjectpropCount++;
                }

                if (insuranceObjectpropCount > 0)
                {
                    body["insurance"] = insuranceObject;
                    bodypropCount++;
                }

                var orderDataObject = new JObject();
                var orderDataObjectpropCount = 0;
                if (bodyorderDataplatformName != null)
                {
                    orderDataObject["platform_name"] = SourceExpressionConverter.ConvertToken(bodyorderDataplatformName);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDataplatformOrderNumber != null)
                {
                    orderDataObject["platform_order_number"] = SourceExpressionConverter.ConvertToken(bodyorderDataplatformOrderNumber);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDataorderTagList != null)
                {
                    orderDataObject["order_tag_list"] = SourceExpressionConverter.ConvertToken(bodyorderDataorderTagList);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDatasellerNotes != null)
                {
                    orderDataObject["seller_notes"] = SourceExpressionConverter.ConvertToken(bodyorderDatasellerNotes);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDatabuyerNotes != null)
                {
                    orderDataObject["buyer_notes"] = SourceExpressionConverter.ConvertToken(bodyorderDatabuyerNotes);
                    orderDataObjectpropCount++;
                }

                if (orderDataObjectpropCount > 0)
                {
                    body["order_data"] = orderDataObject;
                    bodypropCount++;
                }

                var courierSelectionObject = new JObject();
                var courierSelectionObjectpropCount = 0;
                if (bodycourierSelectionselectedCourierId != null)
                {
                    courierSelectionObject["selected_courier_id"] = SourceExpressionConverter.ConvertToken(bodycourierSelectionselectedCourierId);
                    courierSelectionObjectpropCount++;
                }

                if (bodycourierSelectionallowCourierFallback != null)
                {
                    courierSelectionObject["allow_courier_fallback"] = SourceExpressionConverter.ConvertToken(bodycourierSelectionallowCourierFallback);
                    courierSelectionObjectpropCount++;
                }

                if (bodycourierSelectionapplyShippingRules != null)
                {
                    courierSelectionObject["apply_shipping_rules"] = SourceExpressionConverter.ConvertToken(bodycourierSelectionapplyShippingRules);
                    courierSelectionObjectpropCount++;
                }

                if (courierSelectionObjectpropCount > 0)
                {
                    body["courier_selection"] = courierSelectionObject;
                    bodypropCount++;
                }

                var shippingSettingsObject = new JObject();
                var shippingSettingsObjectpropCount = 0;
                var unitsObject = new JObject();
                var unitsObjectpropCount = 0;
                if (bodyshippingSettingsunitsweight != null)
                {
                    unitsObject["weight"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsunitsweight);
                    unitsObjectpropCount++;
                }

                if (bodyshippingSettingsunitsdimensions != null)
                {
                    unitsObject["dimensions"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsunitsdimensions);
                    unitsObjectpropCount++;
                }

                if (unitsObjectpropCount > 0)
                {
                    shippingSettingsObject["units"] = unitsObject;
                    shippingSettingsObjectpropCount++;
                }

                var printingOptionsObject = new JObject();
                var printingOptionsObjectpropCount = 0;
                if (bodyshippingSettingsprintingOptionsformat != null)
                {
                    printingOptionsObject["format"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionsformat);
                    printingOptionsObjectpropCount++;
                }

                if (bodyshippingSettingsprintingOptionslabel != null)
                {
                    printingOptionsObject["label"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionslabel);
                    printingOptionsObjectpropCount++;
                }

                if (bodyshippingSettingsprintingOptionscommercialInvoice != null)
                {
                    printingOptionsObject["commercial_invoice"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionscommercialInvoice);
                    printingOptionsObjectpropCount++;
                }

                if (bodyshippingSettingsprintingOptionspackingSlip != null)
                {
                    printingOptionsObject["packing_slip"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionspackingSlip);
                    printingOptionsObjectpropCount++;
                }

                if (printingOptionsObjectpropCount > 0)
                {
                    shippingSettingsObject["printing_options"] = printingOptionsObject;
                    shippingSettingsObjectpropCount++;
                }

                if (bodyshippingSettingsbuyLabel != null)
                {
                    shippingSettingsObject["buy_label"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsbuyLabel);
                    shippingSettingsObjectpropCount++;
                }

                if (bodyshippingSettingsbuyLabelSynchronous != null)
                {
                    shippingSettingsObject["buy_label_synchronous"] = SourceExpressionConverter.ConvertToken(bodyshippingSettingsbuyLabelSynchronous);
                    shippingSettingsObjectpropCount++;
                }

                if (shippingSettingsObjectpropCount > 0)
                {
                    body["shipping_settings"] = shippingSettingsObject;
                    bodypropCount++;
                }

                if (bodyparcels != null)
                {
                    body["parcels"] = SourceExpressionConverter.ConvertToken(bodyparcels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateAShipmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<BuyAShipmentLabelResponse> BuyAShipmentLabel([WorkflowExpression] Func<bodyshipmentsInputItem[]> bodyshipments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/label/v1/labels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshipments != null)
                {
                    body["shipments"] = SourceExpressionConverter.ConvertToken(bodyshipments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BuyAShipmentLabelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<DeleteAShipmentResponse> DeleteAShipment([WorkflowExpression] Func<string> easyshipShipmentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(easyshipShipmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteAShipmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateAShipmentResponse> UpdateAShipment([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> bodydestinationCountryAlpha2 = null, [WorkflowExpression] Func<string> bodydestinationCity = null, [WorkflowExpression] Func<string> bodydestinationName = null, [WorkflowExpression] Func<string> bodydestinationAddressLine1 = null, [WorkflowExpression] Func<string> bodydestinationPhoneNumber = null, [WorkflowExpression] Func<bodyitemsInputItem[]> bodyitems = null, [WorkflowExpression] Func<string> bodyplatformName = null, [WorkflowExpression] Func<string> bodyplatformOrderNumber = null, [WorkflowExpression] Func<string> bodytaxesDutiesPaidBy = null, [WorkflowExpression] Func<bool> bodyisInsured = null, [WorkflowExpression] Func<string> bodyselectedCourierId = null, [WorkflowExpression] Func<int> bodydestinationPostalCode = null, [WorkflowExpression] Func<string> bodydestinationState = null, [WorkflowExpression] Func<string> bodydestinationAddressLine2 = null, [WorkflowExpression] Func<string> bodydestinationEmailAddress = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(easyshipShipmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestinationCountryAlpha2 != null)
                {
                    body["destination_country_alpha2"] = SourceExpressionConverter.ConvertToken(bodydestinationCountryAlpha2);
                    bodypropCount++;
                }

                if (bodydestinationCity != null)
                {
                    body["destination_city"] = SourceExpressionConverter.ConvertToken(bodydestinationCity);
                    bodypropCount++;
                }

                if (bodydestinationName != null)
                {
                    body["destination_name"] = SourceExpressionConverter.ConvertToken(bodydestinationName);
                    bodypropCount++;
                }

                if (bodydestinationAddressLine1 != null)
                {
                    body["destination_address_line_1"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressLine1);
                    bodypropCount++;
                }

                if (bodydestinationPhoneNumber != null)
                {
                    body["destination_phone_number"] = SourceExpressionConverter.ConvertToken(bodydestinationPhoneNumber);
                    bodypropCount++;
                }

                if (bodyitems != null)
                {
                    body["items"] = SourceExpressionConverter.ConvertToken(bodyitems);
                    bodypropCount++;
                }

                if (bodyplatformName != null)
                {
                    body["platform_name"] = SourceExpressionConverter.ConvertToken(bodyplatformName);
                    bodypropCount++;
                }

                if (bodyplatformOrderNumber != null)
                {
                    body["platform_order_number"] = SourceExpressionConverter.ConvertToken(bodyplatformOrderNumber);
                    bodypropCount++;
                }

                if (bodytaxesDutiesPaidBy != null)
                {
                    body["taxes_duties_paid_by"] = SourceExpressionConverter.ConvertToken(bodytaxesDutiesPaidBy);
                    bodypropCount++;
                }

                if (bodyisInsured != null)
                {
                    body["is_insured"] = SourceExpressionConverter.ConvertToken(bodyisInsured);
                    bodypropCount++;
                }

                if (bodyselectedCourierId != null)
                {
                    body["selected_courier_id"] = SourceExpressionConverter.ConvertToken(bodyselectedCourierId);
                    bodypropCount++;
                }

                if (bodydestinationPostalCode != null)
                {
                    body["destination_postal_code"] = SourceExpressionConverter.ConvertToken(bodydestinationPostalCode);
                    bodypropCount++;
                }

                if (bodydestinationState != null)
                {
                    body["destination_state"] = SourceExpressionConverter.ConvertToken(bodydestinationState);
                    bodypropCount++;
                }

                if (bodydestinationAddressLine2 != null)
                {
                    body["destination_address_line_2"] = SourceExpressionConverter.ConvertToken(bodydestinationAddressLine2);
                    bodypropCount++;
                }

                if (bodydestinationEmailAddress != null)
                {
                    body["destination_email_address"] = SourceExpressionConverter.ConvertToken(bodydestinationEmailAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateAShipmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetAShipmentResponse> GetAShipment([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> label = null, [WorkflowExpression] Func<string> commercialInvoice = null, [WorkflowExpression] Func<string> packingSlip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/shipments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(easyshipShipmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.ConvertO(format);
                if (label != null)
                    callPayload.Queries["label"] = SourceExpressionConverter.ConvertO(label);
                if (commercialInvoice != null)
                    callPayload.Queries["commercial_invoice"] = SourceExpressionConverter.ConvertO(commercialInvoice);
                if (packingSlip != null)
                    callPayload.Queries["packing_slip"] = SourceExpressionConverter.ConvertO(packingSlip);
                return callPayload;
            }

            return new ApiConnectionAction<GetAShipmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateWarehouseStateResponse> UpdateWarehouseState([WorkflowExpression] Func<bodyshipmentsInputItem2[]> bodyshipments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/shipments/warehouse_state";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshipments != null)
                {
                    body["shipments"] = SourceExpressionConverter.ConvertToken(bodyshipments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateWarehouseStateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetAvailablePickupSlotsResponse> GetAvailablePickupSlots([WorkflowExpression] Func<string> courierId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/pickup/v1/pickup_slots/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(courierId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAvailablePickupSlotsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<RequestAPickupResponse> RequestAPickup([WorkflowExpression] Func<string> bodycourierId = null, [WorkflowExpression] Func<string> bodypreferredDate = null, [WorkflowExpression] Func<string> bodypreferredMaxTime = null, [WorkflowExpression] Func<string> bodypreferredMinTime = null, [WorkflowExpression] Func<string[]> bodyeasyshipShipmentIds = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/pickup/v1/pickups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycourierId != null)
                {
                    body["courier_id"] = SourceExpressionConverter.ConvertToken(bodycourierId);
                    bodypropCount++;
                }

                if (bodypreferredDate != null)
                {
                    body["preferred_date"] = SourceExpressionConverter.ConvertToken(bodypreferredDate);
                    bodypropCount++;
                }

                if (bodypreferredMaxTime != null)
                {
                    body["preferred_max_time"] = SourceExpressionConverter.ConvertToken(bodypreferredMaxTime);
                    bodypropCount++;
                }

                if (bodypreferredMinTime != null)
                {
                    body["preferred_min_time"] = SourceExpressionConverter.ConvertToken(bodypreferredMinTime);
                    bodypropCount++;
                }

                if (bodyeasyshipShipmentIds != null)
                {
                    body["easyship_shipment_ids"] = SourceExpressionConverter.ConvertToken(bodyeasyshipShipmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RequestAPickupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetCheckpointsResponse> GetCheckpoints([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> platformOrderNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/track/v1/checkpoints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["easyship_shipment_id"] = SourceExpressionConverter.ConvertO(easyshipShipmentId);
                if (platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = SourceExpressionConverter.ConvertO(platformOrderNumber);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<GetCheckpointsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetStatusResponse> GetStatus([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> platformOrderNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/track/v1/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["easyship_shipment_id"] = SourceExpressionConverter.ConvertO(easyshipShipmentId);
                if (platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = SourceExpressionConverter.ConvertO(platformOrderNumber);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<GetStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetItemCategoriesResponse> GetItemCategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reference/v1/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetItemCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<ListAllBoxesResponse> ListAllBoxes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/boxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListAllBoxesResponse>(BuildSourceInput);
        }
    }

    public class EasyshipipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRatesTaxesResponse
    {
        [JsonProperty("rates")]
        public GetRatesTaxesResponseRatesTypeItem[] Rates { get; set; }
    }

    public class GetRatesTaxesResponseRatesTypeItem
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("courier_name")]
        public string CourierName { get; set; }

        [JsonProperty("min_delivery_time")]
        public int MinDeliveryTime { get; set; }

        [JsonProperty("max_delivery_time")]
        public int MaxDeliveryTime { get; set; }

        [JsonProperty("value_for_money_rank")]
        public int ValueForMoneyRank { get; set; }

        [JsonProperty("delivery_time_rank")]
        public int DeliveryTimeRank { get; set; }

        [JsonProperty("shipment_charge")]
        public double ShipmentCharge { get; set; }

        [JsonProperty("fuel_surcharge")]
        public double FuelSurcharge { get; set; }

        [JsonProperty("remote_area_surcharge")]
        public int RemoteAreaSurcharge { get; set; }

        [JsonProperty("shipment_charge_total")]
        public double ShipmentChargeTotal { get; set; }

        [JsonProperty("warehouse_handling_fee")]
        public int WarehouseHandlingFee { get; set; }

        [JsonProperty("insurance_fee")]
        public int InsuranceFee { get; set; }

        [JsonProperty("ddp_handling_fee")]
        public int DdpHandlingFee { get; set; }

        [JsonProperty("import_tax_charge")]
        public int ImportTaxCharge { get; set; }

        [JsonProperty("import_duty_charge")]
        public int ImportDutyCharge { get; set; }

        [JsonProperty("total_charge")]
        public double TotalCharge { get; set; }

        [JsonProperty("is_above_threshold")]
        public bool IsAboveThreshold { get; set; }

        [JsonProperty("effective_incoterms")]
        public string EffectiveIncoterms { get; set; }

        [JsonProperty("estimated_import_tax")]
        public int EstimatedImportTax { get; set; }

        [JsonProperty("estimated_import_duty")]
        public int EstimatedImportDuty { get; set; }

        [JsonProperty("courier_does_pickup")]
        public bool CourierDoesPickup { get; set; }

        [JsonProperty("courier_dropoff_url")]
        public string CourierDropoffUrl { get; set; }

        [JsonProperty("tracking_rating")]
        public int TrackingRating { get; set; }

        [JsonProperty("payment_recipient")]
        public string PaymentRecipient { get; set; }

        [JsonProperty("courier_remarks")]
        public string CourierRemarks { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("box")]
        public GetRatesTaxesResponseRatesTypeItemBoxType Box { get; set; }

        [JsonProperty("minimum_pickup_fee")]
        public int MinimumPickupFee { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }
    }

    public class GetRatesTaxesResponseRatesTypeItemBoxType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class bodyparcelsInputItem
    {
        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("box")]
        public bodyparcelsInputItemBoxType Box { get; set; }

        [JsonProperty("items")]
        public bodyparcelsInputItemItemsTypeItem[] Items { get; set; }
    }

    public class bodyparcelsInputItemBoxType
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class bodyparcelsInputItemItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("dimensions")]
        public bodyparcelsInputItemItemsTypeItemDimensionsType Dimensions { get; set; }

        [JsonProperty("actual_weight")]
        public int ActualWeight { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int DeclaredCustomsValue { get; set; }
    }

    public class bodyparcelsInputItemItemsTypeItemDimensionsType
    {
        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }

    public class ListAllShipmentsResponse
    {
        [JsonProperty("shipments")]
        public ListAllShipmentsResponseShipmentsTypeItem[] Shipments { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("label_paid_at")]
        public string LabelPaidAt { get; set; }

        [JsonProperty("label_generated_at")]
        public string LabelGeneratedAt { get; set; }

        [JsonProperty("order_created_at")]
        public string OrderCreatedAt { get; set; }

        [JsonProperty("origin_address")]
        public ListAllShipmentsResponseShipmentsTypeItemOriginAddressType OriginAddress { get; set; }

        [JsonProperty("sender_address")]
        public ListAllShipmentsResponseShipmentsTypeItemSenderAddressType SenderAddress { get; set; }

        [JsonProperty("return_address")]
        public ListAllShipmentsResponseShipmentsTypeItemReturnAddressType ReturnAddress { get; set; }

        [JsonProperty("destination_address")]
        public ListAllShipmentsResponseShipmentsTypeItemDestinationAddressType DestinationAddress { get; set; }

        [JsonProperty("order_data")]
        public ListAllShipmentsResponseShipmentsTypeItemOrderDataType OrderData { get; set; }

        [JsonProperty("set_as_residential")]
        public bool SetAsResidential { get; set; }

        [JsonProperty("consignee_tax_id")]
        public string ConsigneeTaxId { get; set; }

        [JsonProperty("eei_reference")]
        public string EeiReference { get; set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; set; }

        [JsonProperty("insurance")]
        public ListAllShipmentsResponseShipmentsTypeItemInsuranceType Insurance { get; set; }

        [JsonProperty("parcels")]
        public ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItem[] Parcels { get; set; }

        [JsonProperty("total_customs_value")]
        public double TotalCustomsValue { get; set; }

        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("total_dimensional_weight")]
        public double TotalDimensionalWeight { get; set; }

        [JsonProperty("total_volumetric_weight")]
        public double TotalVolumetricWeight { get; set; }

        [JsonProperty("shipment_state")]
        public string ShipmentState { get; set; }

        [JsonProperty("pickup_state")]
        public string PickupState { get; set; }

        [JsonProperty("delivery_state")]
        public string DeliveryState { get; set; }

        [JsonProperty("label_state")]
        public string LabelState { get; set; }

        [JsonProperty("warehouse_state")]
        public string WarehouseState { get; set; }

        [JsonProperty("trackings")]
        public ListAllShipmentsResponseShipmentsTypeItemTrackingsTypeItem[] Trackings { get; set; }

        [JsonProperty("tracking_page_url")]
        public string TrackingPageUrl { get; set; }

        [JsonProperty("shipping_documents")]
        public JToken[] ShippingDocuments { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("selected_courier")]
        public ListAllShipmentsResponseShipmentsTypeItemSelectedCourierType SelectedCourier { get; set; }

        [JsonProperty("rates")]
        public ListAllShipmentsResponseShipmentsTypeItemRatesTypeItem[] Rates { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemOriginAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemSenderAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemReturnAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemDestinationAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemOrderDataType
    {
        [JsonProperty("platform_name")]
        public string PlatformName { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("order_tag_list")]
        public string[] OrderTagList { get; set; }

        [JsonProperty("seller_notes")]
        public string SellerNotes { get; set; }

        [JsonProperty("buyer_notes")]
        public string BuyerNotes { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemInsuranceType
    {
        [JsonProperty("is_insured")]
        public bool IsInsured { get; set; }

        [JsonProperty("insured_amount")]
        public int InsuredAmount { get; set; }

        [JsonProperty("insured_currency")]
        public string InsuredCurrency { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItem
    {
        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("total_customs_value")]
        public double TotalCustomsValue { get; set; }

        [JsonProperty("total_dimensional_weight")]
        public double TotalDimensionalWeight { get; set; }

        [JsonProperty("total_volumetric_weight")]
        public double TotalVolumetricWeight { get; set; }

        [JsonProperty("box")]
        public ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItemBoxType Box { get; set; }

        [JsonProperty("items")]
        public ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItemBoxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courier_umbrella_name")]
        public string CourierUmbrellaName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("outer_length")]
        public double OuterLength { get; set; }

        [JsonProperty("outer_width")]
        public double OuterWidth { get; set; }

        [JsonProperty("outer_height")]
        public double OuterHeight { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItemItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("actual_weight")]
        public int ActualWeight { get; set; }

        [JsonProperty("dimensional_weight")]
        public int DimensionalWeight { get; set; }

        [JsonProperty("volumetric_weight")]
        public int VolumetricWeight { get; set; }

        [JsonProperty("origin_currency")]
        public string OriginCurrency { get; set; }

        [JsonProperty("origin_customs_value")]
        public int OriginCustomsValue { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int DeclaredCustomsValue { get; set; }

        [JsonProperty("dimensions")]
        public ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItemItemsTypeItemDimensionsType Dimensions { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemParcelsTypeItemItemsTypeItemDimensionsType
    {
        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemTrackingsTypeItem
    {
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("local_tracking_number")]
        public string LocalTrackingNumber { get; set; }

        [JsonProperty("alternate_tracking_number")]
        public string AlternateTrackingNumber { get; set; }

        [JsonProperty("leg_number")]
        public int LegNumber { get; set; }

        [JsonProperty("handler")]
        public string Handler { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemSelectedCourierType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemRatesTypeItem
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("courier_name")]
        public string CourierName { get; set; }

        [JsonProperty("min_delivery_time")]
        public int MinDeliveryTime { get; set; }

        [JsonProperty("max_delivery_time")]
        public int MaxDeliveryTime { get; set; }

        [JsonProperty("value_for_money_rank")]
        public int ValueForMoneyRank { get; set; }

        [JsonProperty("delivery_time_rank")]
        public int DeliveryTimeRank { get; set; }

        [JsonProperty("shipment_charge")]
        public double ShipmentCharge { get; set; }

        [JsonProperty("fuel_surcharge")]
        public double FuelSurcharge { get; set; }

        [JsonProperty("remote_area_surcharge")]
        public int RemoteAreaSurcharge { get; set; }

        [JsonProperty("oversized_surcharge")]
        public int OversizedSurcharge { get; set; }

        [JsonProperty("additional_services_surcharge")]
        public int AdditionalServicesSurcharge { get; set; }

        [JsonProperty("residential_full_fee")]
        public int ResidentialFullFee { get; set; }

        [JsonProperty("residential_discounted_fee")]
        public int ResidentialDiscountedFee { get; set; }

        [JsonProperty("shipment_charge_total")]
        public double ShipmentChargeTotal { get; set; }

        [JsonProperty("warehouse_handling_fee")]
        public int WarehouseHandlingFee { get; set; }

        [JsonProperty("insurance_fee")]
        public int InsuranceFee { get; set; }

        [JsonProperty("sales_tax")]
        public int SalesTax { get; set; }

        [JsonProperty("provincial_sales_tax")]
        public int ProvincialSalesTax { get; set; }

        [JsonProperty("ddp_handling_fee")]
        public int DdpHandlingFee { get; set; }

        [JsonProperty("import_tax_charge")]
        public int ImportTaxCharge { get; set; }

        [JsonProperty("import_duty_charge")]
        public int ImportDutyCharge { get; set; }

        [JsonProperty("total_charge")]
        public double TotalCharge { get; set; }

        [JsonProperty("is_above_threshold")]
        public bool IsAboveThreshold { get; set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; set; }

        [JsonProperty("estimated_import_tax")]
        public int EstimatedImportTax { get; set; }

        [JsonProperty("estimated_import_duty")]
        public int EstimatedImportDuty { get; set; }

        [JsonProperty("available_handover_options")]
        public string AvailableHandoverOptions { get; set; }

        [JsonProperty("tracking_rating")]
        public int TrackingRating { get; set; }

        [JsonProperty("easyship_rating")]
        public int EasyshipRating { get; set; }

        [JsonProperty("courier_remarks")]
        public string CourierRemarks { get; set; }

        [JsonProperty("payment_recipient")]
        public string PaymentRecipient { get; set; }

        [JsonProperty("discount")]
        public ListAllShipmentsResponseShipmentsTypeItemRatesTypeItemDiscountType Discount { get; set; }

        [JsonProperty("effective_incoterms")]
        public string EffectiveIncoterms { get; set; }
    }

    public class ListAllShipmentsResponseShipmentsTypeItemRatesTypeItemDiscountType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }
    }

    public class CreateAShipmentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }

        [JsonProperty("shipment")]
        public CreateAShipmentResponseShipmentType Shipment { get; set; }
    }

    public class CreateAShipmentResponseShipmentType
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("label_paid_at")]
        public string LabelPaidAt { get; set; }

        [JsonProperty("label_generated_at")]
        public string LabelGeneratedAt { get; set; }

        [JsonProperty("order_created_at")]
        public string OrderCreatedAt { get; set; }

        [JsonProperty("origin_address")]
        public CreateAShipmentResponseShipmentTypeOriginAddressType OriginAddress { get; set; }

        [JsonProperty("sender_address")]
        public CreateAShipmentResponseShipmentTypeSenderAddressType SenderAddress { get; set; }

        [JsonProperty("return_address")]
        public CreateAShipmentResponseShipmentTypeReturnAddressType ReturnAddress { get; set; }

        [JsonProperty("destination_address")]
        public CreateAShipmentResponseShipmentTypeDestinationAddressType DestinationAddress { get; set; }

        [JsonProperty("order_data")]
        public CreateAShipmentResponseShipmentTypeOrderDataType OrderData { get; set; }

        [JsonProperty("set_as_residential")]
        public bool SetAsResidential { get; set; }

        [JsonProperty("consignee_tax_id")]
        public string ConsigneeTaxId { get; set; }

        [JsonProperty("eei_reference")]
        public string EeiReference { get; set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; set; }

        [JsonProperty("insurance")]
        public CreateAShipmentResponseShipmentTypeInsuranceType Insurance { get; set; }

        [JsonProperty("parcels_count")]
        public int ParcelsCount { get; set; }

        [JsonProperty("parcels")]
        public CreateAShipmentResponseShipmentTypeParcelsTypeItem[] Parcels { get; set; }

        [JsonProperty("total_customs_value")]
        public double TotalCustomsValue { get; set; }

        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("total_dimensional_weight")]
        public double TotalDimensionalWeight { get; set; }

        [JsonProperty("total_volumetric_weight")]
        public double TotalVolumetricWeight { get; set; }

        [JsonProperty("shipment_state")]
        public string ShipmentState { get; set; }

        [JsonProperty("pickup_state")]
        public string PickupState { get; set; }

        [JsonProperty("delivery_state")]
        public string DeliveryState { get; set; }

        [JsonProperty("label_state")]
        public string LabelState { get; set; }

        [JsonProperty("warehouse_state")]
        public string WarehouseState { get; set; }

        [JsonProperty("trackings")]
        public CreateAShipmentResponseShipmentTypeTrackingsTypeItem[] Trackings { get; set; }

        [JsonProperty("tracking_page_url")]
        public string TrackingPageUrl { get; set; }

        [JsonProperty("shipping_documents")]
        public CreateAShipmentResponseShipmentTypeShippingDocumentsTypeItem[] ShippingDocuments { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("selected_courier")]
        public CreateAShipmentResponseShipmentTypeSelectedCourierType SelectedCourier { get; set; }

        [JsonProperty("rates")]
        public CreateAShipmentResponseShipmentTypeRatesTypeItem[] Rates { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeOriginAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeSenderAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeReturnAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeDestinationAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country_alpha2")]
        public string CountryAlpha2 { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeOrderDataType
    {
        [JsonProperty("platform_name")]
        public string PlatformName { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("order_tag_list")]
        public string[] OrderTagList { get; set; }

        [JsonProperty("seller_notes")]
        public string SellerNotes { get; set; }

        [JsonProperty("buyer_notes")]
        public string BuyerNotes { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeInsuranceType
    {
        [JsonProperty("is_insured")]
        public bool IsInsured { get; set; }

        [JsonProperty("insured_amount")]
        public int InsuredAmount { get; set; }

        [JsonProperty("insured_currency")]
        public string InsuredCurrency { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeParcelsTypeItem
    {
        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("total_customs_value")]
        public double TotalCustomsValue { get; set; }

        [JsonProperty("total_dimensional_weight")]
        public double TotalDimensionalWeight { get; set; }

        [JsonProperty("total_volumetric_weight")]
        public double TotalVolumetricWeight { get; set; }

        [JsonProperty("box")]
        public CreateAShipmentResponseShipmentTypeParcelsTypeItemBoxType Box { get; set; }

        [JsonProperty("items")]
        public CreateAShipmentResponseShipmentTypeParcelsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeParcelsTypeItemBoxType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeParcelsTypeItemItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("actual_weight")]
        public int ActualWeight { get; set; }

        [JsonProperty("dimensional_weight")]
        public int DimensionalWeight { get; set; }

        [JsonProperty("volumetric_weight")]
        public int VolumetricWeight { get; set; }

        [JsonProperty("origin_currency")]
        public string OriginCurrency { get; set; }

        [JsonProperty("origin_customs_value")]
        public int OriginCustomsValue { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int DeclaredCustomsValue { get; set; }

        [JsonProperty("dimensions")]
        public CreateAShipmentResponseShipmentTypeParcelsTypeItemItemsTypeItemDimensionsType Dimensions { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeParcelsTypeItemItemsTypeItemDimensionsType
    {
        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeTrackingsTypeItem
    {
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("local_tracking_number")]
        public string LocalTrackingNumber { get; set; }

        [JsonProperty("alternate_tracking_number")]
        public string AlternateTrackingNumber { get; set; }

        [JsonProperty("leg_number")]
        public int LegNumber { get; set; }

        [JsonProperty("handler")]
        public string Handler { get; set; }

        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeShippingDocumentsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("base64_encoded_strings")]
        public string[] Base64EncodedStrings { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeSelectedCourierType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeRatesTypeItem
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("courier_name")]
        public string CourierName { get; set; }

        [JsonProperty("min_delivery_time")]
        public int MinDeliveryTime { get; set; }

        [JsonProperty("max_delivery_time")]
        public int MaxDeliveryTime { get; set; }

        [JsonProperty("value_for_money_rank")]
        public int ValueForMoneyRank { get; set; }

        [JsonProperty("delivery_time_rank")]
        public int DeliveryTimeRank { get; set; }

        [JsonProperty("shipment_charge")]
        public double ShipmentCharge { get; set; }

        [JsonProperty("fuel_surcharge")]
        public double FuelSurcharge { get; set; }

        [JsonProperty("remote_area_surcharge")]
        public int RemoteAreaSurcharge { get; set; }

        [JsonProperty("oversized_surcharge")]
        public int OversizedSurcharge { get; set; }

        [JsonProperty("additional_services_surcharge")]
        public int AdditionalServicesSurcharge { get; set; }

        [JsonProperty("residential_full_fee")]
        public int ResidentialFullFee { get; set; }

        [JsonProperty("residential_discounted_fee")]
        public int ResidentialDiscountedFee { get; set; }

        [JsonProperty("shipment_charge_total")]
        public double ShipmentChargeTotal { get; set; }

        [JsonProperty("warehouse_handling_fee")]
        public int WarehouseHandlingFee { get; set; }

        [JsonProperty("insurance_fee")]
        public int InsuranceFee { get; set; }

        [JsonProperty("sales_tax")]
        public int SalesTax { get; set; }

        [JsonProperty("provincial_sales_tax")]
        public int ProvincialSalesTax { get; set; }

        [JsonProperty("ddp_handling_fee")]
        public int DdpHandlingFee { get; set; }

        [JsonProperty("import_tax_charge")]
        public int ImportTaxCharge { get; set; }

        [JsonProperty("import_duty_charge")]
        public int ImportDutyCharge { get; set; }

        [JsonProperty("total_charge")]
        public double TotalCharge { get; set; }

        [JsonProperty("is_above_threshold")]
        public bool IsAboveThreshold { get; set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; set; }

        [JsonProperty("estimated_import_tax")]
        public int EstimatedImportTax { get; set; }

        [JsonProperty("estimated_import_duty")]
        public int EstimatedImportDuty { get; set; }

        [JsonProperty("available_handover_options")]
        public string AvailableHandoverOptions { get; set; }

        [JsonProperty("tracking_rating")]
        public int TrackingRating { get; set; }

        [JsonProperty("easyship_rating")]
        public int EasyshipRating { get; set; }

        [JsonProperty("courier_remarks")]
        public string CourierRemarks { get; set; }

        [JsonProperty("payment_recipient")]
        public string PaymentRecipient { get; set; }

        [JsonProperty("discount")]
        public CreateAShipmentResponseShipmentTypeRatesTypeItemDiscountType Discount { get; set; }

        [JsonProperty("effective_incoterms")]
        public string EffectiveIncoterms { get; set; }
    }

    public class CreateAShipmentResponseShipmentTypeRatesTypeItemDiscountType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }
    }

    public class BuyAShipmentLabelResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }

        [JsonProperty("total_cost")]
        public int TotalCost { get; set; }

        [JsonProperty("available_balance")]
        public int AvailableBalance { get; set; }

        [JsonProperty("labels")]
        public BuyAShipmentLabelResponseLabelsTypeItem[] Labels { get; set; }
    }

    public class BuyAShipmentLabelResponseLabelsTypeItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("label_state")]
        public string LabelState { get; set; }

        [JsonProperty("label_url")]
        public string LabelUrl { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_page_url")]
        public string TrackingPageUrl { get; set; }
    }

    public class bodyshipmentsInputItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("courier_id")]
        public string CourierId { get; set; }
    }

    public class DeleteAShipmentResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class UpdateAShipmentResponse
    {
        [JsonProperty("shipment")]
        public UpdateAShipmentResponseShipmentType Shipment { get; set; }
    }

    public class UpdateAShipmentResponseShipmentType
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("destination_name")]
        public string DestinationName { get; set; }

        [JsonProperty("destination_address_line_1")]
        public string DestinationAddressLine1 { get; set; }

        [JsonProperty("destination_address_line_2")]
        public string DestinationAddressLine2 { get; set; }

        [JsonProperty("destination_city")]
        public string DestinationCity { get; set; }

        [JsonProperty("destination_state")]
        public string DestinationState { get; set; }

        [JsonProperty("destination_postal_code")]
        public string DestinationPostalCode { get; set; }

        [JsonProperty("destination_phone_number")]
        public string DestinationPhoneNumber { get; set; }

        [JsonProperty("destination_email_address")]
        public string DestinationEmailAddress { get; set; }

        [JsonProperty("platform_name")]
        public string PlatformName { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("total_customs_value")]
        public double TotalCustomsValue { get; set; }

        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("total_dimensional_weight")]
        public double TotalDimensionalWeight { get; set; }

        [JsonProperty("total_volumetric_weight")]
        public double TotalVolumetricWeight { get; set; }

        [JsonProperty("is_insured")]
        public bool IsInsured { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("origin_country")]
        public UpdateAShipmentResponseShipmentTypeOriginCountryType OriginCountry { get; set; }

        [JsonProperty("destination_country")]
        public UpdateAShipmentResponseShipmentTypeDestinationCountryType DestinationCountry { get; set; }

        [JsonProperty("items")]
        public UpdateAShipmentResponseShipmentTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("box")]
        public UpdateAShipmentResponseShipmentTypeBoxType Box { get; set; }

        [JsonProperty("selected_courier")]
        public UpdateAShipmentResponseShipmentTypeSelectedCourierType SelectedCourier { get; set; }

        [JsonProperty("rates")]
        public UpdateAShipmentResponseShipmentTypeRatesTypeItem[] Rates { get; set; }
    }

    public class UpdateAShipmentResponseShipmentTypeOriginCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }
    }

    public class UpdateAShipmentResponseShipmentTypeDestinationCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }
    }

    public class UpdateAShipmentResponseShipmentTypeItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("actual_weight")]
        public double ActualWeight { get; set; }

        [JsonProperty("dimensional_weight")]
        public double DimensionalWeight { get; set; }

        [JsonProperty("volumetric_weight")]
        public double VolumetricWeight { get; set; }

        [JsonProperty("declared_customs_value")]
        public int DeclaredCustomsValue { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("origin_customs_value")]
        public double OriginCustomsValue { get; set; }

        [JsonProperty("origin_currency")]
        public string OriginCurrency { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class UpdateAShipmentResponseShipmentTypeBoxType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class UpdateAShipmentResponseShipmentTypeSelectedCourierType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("min_delivery_time")]
        public int MinDeliveryTime { get; set; }

        [JsonProperty("max_delivery_time")]
        public int MaxDeliveryTime { get; set; }

        [JsonProperty("shipment_charge")]
        public double ShipmentCharge { get; set; }

        [JsonProperty("fuel_surcharge")]
        public double FuelSurcharge { get; set; }

        [JsonProperty("remote_area_surcharge")]
        public int RemoteAreaSurcharge { get; set; }

        [JsonProperty("shipment_charge_total")]
        public double ShipmentChargeTotal { get; set; }

        [JsonProperty("warehouse_handling_fee")]
        public int WarehouseHandlingFee { get; set; }

        [JsonProperty("insurance_fee")]
        public int InsuranceFee { get; set; }

        [JsonProperty("import_tax_charge")]
        public int ImportTaxCharge { get; set; }

        [JsonProperty("import_duty_charge")]
        public int ImportDutyCharge { get; set; }

        [JsonProperty("ddp_handling_fee")]
        public int DdpHandlingFee { get; set; }

        [JsonProperty("total_charge")]
        public double TotalCharge { get; set; }

        [JsonProperty("is_above_threshold")]
        public bool IsAboveThreshold { get; set; }

        [JsonProperty("effective_incoterms")]
        public string EffectiveIncoterms { get; set; }

        [JsonProperty("estimated_import_tax")]
        public int EstimatedImportTax { get; set; }

        [JsonProperty("estimated_import_duty")]
        public int EstimatedImportDuty { get; set; }

        [JsonProperty("courier_does_pickup")]
        public bool CourierDoesPickup { get; set; }

        [JsonProperty("courier_dropoff_url")]
        public string CourierDropoffUrl { get; set; }

        [JsonProperty("courier_remarks")]
        public string CourierRemarks { get; set; }

        [JsonProperty("payment_recipient")]
        public string PaymentRecipient { get; set; }
    }

    public class UpdateAShipmentResponseShipmentTypeRatesTypeItem
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("courier_name")]
        public string CourierName { get; set; }

        [JsonProperty("min_delivery_time")]
        public int MinDeliveryTime { get; set; }

        [JsonProperty("max_delivery_time")]
        public int MaxDeliveryTime { get; set; }

        [JsonProperty("value_for_money_rank")]
        public int ValueForMoneyRank { get; set; }

        [JsonProperty("delivery_time_rank")]
        public int DeliveryTimeRank { get; set; }

        [JsonProperty("shipment_charge")]
        public double ShipmentCharge { get; set; }

        [JsonProperty("fuel_surcharge")]
        public double FuelSurcharge { get; set; }

        [JsonProperty("remote_area_surcharge")]
        public int RemoteAreaSurcharge { get; set; }

        [JsonProperty("shipment_charge_total")]
        public double ShipmentChargeTotal { get; set; }

        [JsonProperty("warehouse_handling_fee")]
        public int WarehouseHandlingFee { get; set; }

        [JsonProperty("insurance_fee")]
        public int InsuranceFee { get; set; }

        [JsonProperty("ddp_handling_fee")]
        public int DdpHandlingFee { get; set; }

        [JsonProperty("import_tax_charge")]
        public int ImportTaxCharge { get; set; }

        [JsonProperty("import_duty_charge")]
        public int ImportDutyCharge { get; set; }

        [JsonProperty("total_charge")]
        public double TotalCharge { get; set; }

        [JsonProperty("is_above_threshold")]
        public bool IsAboveThreshold { get; set; }

        [JsonProperty("effective_incoterms")]
        public string EffectiveIncoterms { get; set; }

        [JsonProperty("estimated_import_tax")]
        public int EstimatedImportTax { get; set; }

        [JsonProperty("estimated_import_duty")]
        public int EstimatedImportDuty { get; set; }

        [JsonProperty("courier_does_pickup")]
        public bool CourierDoesPickup { get; set; }

        [JsonProperty("courier_dropoff_url")]
        public string CourierDropoffUrl { get; set; }

        [JsonProperty("tracking_rating")]
        public int TrackingRating { get; set; }

        [JsonProperty("easyship_rating")]
        public double EasyshipRating { get; set; }

        [JsonProperty("courier_remarks")]
        public string CourierRemarks { get; set; }

        [JsonProperty("payment_recipient")]
        public string PaymentRecipient { get; set; }
    }

    public class bodyitemsInputItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("actual_weight")]
        public double ActualWeight { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int DeclaredCustomsValue { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class GetAShipmentResponse
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("destination_name")]
        public string DestinationName { get; set; }

        [JsonProperty("destination_address_line_1")]
        public string DestinationAddressLine1 { get; set; }

        [JsonProperty("destination_address_line_2")]
        public string DestinationAddressLine2 { get; set; }

        [JsonProperty("destination_city")]
        public string DestinationCity { get; set; }

        [JsonProperty("destination_state")]
        public string DestinationState { get; set; }

        [JsonProperty("destination_postal_code")]
        public string DestinationPostalCode { get; set; }

        [JsonProperty("destination_phone_number")]
        public string DestinationPhoneNumber { get; set; }

        [JsonProperty("destination_email_address")]
        public string DestinationEmailAddress { get; set; }

        [JsonProperty("order_notes")]
        public string OrderNotes { get; set; }

        [JsonProperty("order_created_at")]
        public string OrderCreatedAt { get; set; }

        [JsonProperty("platform_name")]
        public string PlatformName { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("total_customs_value")]
        public double TotalCustomsValue { get; set; }

        [JsonProperty("total_actual_weight")]
        public double TotalActualWeight { get; set; }

        [JsonProperty("total_dimensional_weight")]
        public double TotalDimensionalWeight { get; set; }

        [JsonProperty("total_volumetric_weight")]
        public double TotalVolumetricWeight { get; set; }

        [JsonProperty("is_insured")]
        public bool IsInsured { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("warehouse_state")]
        public string WarehouseState { get; set; }

        [JsonProperty("origin_country")]
        public GetAShipmentResponseOriginCountryType OriginCountry { get; set; }

        [JsonProperty("destination_country")]
        public GetAShipmentResponseDestinationCountryType DestinationCountry { get; set; }

        [JsonProperty("items")]
        public GetAShipmentResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("box")]
        public GetAShipmentResponseBoxType Box { get; set; }

        [JsonProperty("selected_courier")]
        public GetAShipmentResponseSelectedCourierType SelectedCourier { get; set; }

        [JsonProperty("shipping_documents")]
        public GetAShipmentResponseShippingDocumentsType ShippingDocuments { get; set; }
    }

    public class GetAShipmentResponseOriginCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }
    }

    public class GetAShipmentResponseDestinationCountryType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alpha2")]
        public string Alpha2 { get; set; }
    }

    public class GetAShipmentResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("actual_weight")]
        public double ActualWeight { get; set; }

        [JsonProperty("dimensional_weight")]
        public double DimensionalWeight { get; set; }

        [JsonProperty("volumetric_weight")]
        public double VolumetricWeight { get; set; }

        [JsonProperty("declared_customs_value")]
        public int DeclaredCustomsValue { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("origin_customs_value")]
        public double OriginCustomsValue { get; set; }

        [JsonProperty("origin_currency")]
        public string OriginCurrency { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class GetAShipmentResponseBoxType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class GetAShipmentResponseSelectedCourierType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("min_delivery_time")]
        public int MinDeliveryTime { get; set; }

        [JsonProperty("max_delivery_time")]
        public int MaxDeliveryTime { get; set; }

        [JsonProperty("shipment_charge")]
        public double ShipmentCharge { get; set; }

        [JsonProperty("fuel_surcharge")]
        public double FuelSurcharge { get; set; }

        [JsonProperty("remote_area_surcharge")]
        public int RemoteAreaSurcharge { get; set; }

        [JsonProperty("shipment_charge_total")]
        public double ShipmentChargeTotal { get; set; }

        [JsonProperty("warehouse_handling_fee")]
        public int WarehouseHandlingFee { get; set; }

        [JsonProperty("insurance_fee")]
        public int InsuranceFee { get; set; }

        [JsonProperty("import_tax_charge")]
        public int ImportTaxCharge { get; set; }

        [JsonProperty("import_duty_charge")]
        public int ImportDutyCharge { get; set; }

        [JsonProperty("ddp_handling_fee")]
        public int DdpHandlingFee { get; set; }

        [JsonProperty("total_charge")]
        public double TotalCharge { get; set; }

        [JsonProperty("is_above_threshold")]
        public bool IsAboveThreshold { get; set; }

        [JsonProperty("effective_incoterms")]
        public string EffectiveIncoterms { get; set; }

        [JsonProperty("estimated_import_tax")]
        public int EstimatedImportTax { get; set; }

        [JsonProperty("estimated_import_duty")]
        public int EstimatedImportDuty { get; set; }

        [JsonProperty("courier_does_pickup")]
        public bool CourierDoesPickup { get; set; }

        [JsonProperty("courier_dropoff_url")]
        public string CourierDropoffUrl { get; set; }

        [JsonProperty("courier_remarks")]
        public string CourierRemarks { get; set; }

        [JsonProperty("payment_recipient")]
        public string PaymentRecipient { get; set; }
    }

    public class GetAShipmentResponseShippingDocumentsType
    {
        [JsonProperty("label")]
        public GetAShipmentResponseShippingDocumentsTypeLabelType Label { get; set; }

        [JsonProperty("commercial_invoice")]
        public GetAShipmentResponseShippingDocumentsTypeCommercialInvoiceType CommercialInvoice { get; set; }

        [JsonProperty("packing_slip")]
        public GetAShipmentResponseShippingDocumentsTypePackingSlipType PackingSlip { get; set; }

        [JsonProperty("battery_form")]
        public GetAShipmentResponseShippingDocumentsTypeBatteryFormType BatteryForm { get; set; }

        [JsonProperty("battery_caution_label")]
        public GetAShipmentResponseShippingDocumentsTypeBatteryCautionLabelType BatteryCautionLabel { get; set; }
    }

    public class GetAShipmentResponseShippingDocumentsTypeLabelType
    {
        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("base64_encoded_strings")]
        public string[] Base64EncodedStrings { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GetAShipmentResponseShippingDocumentsTypeCommercialInvoiceType
    {
        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("base64_encoded_strings")]
        public JToken[] Base64EncodedStrings { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAShipmentResponseShippingDocumentsTypePackingSlipType
    {
        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("base64_encoded_strings")]
        public string[] Base64EncodedStrings { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAShipmentResponseShippingDocumentsTypeBatteryFormType
    {
        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("base64_encoded_strings")]
        public JToken[] Base64EncodedStrings { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAShipmentResponseShippingDocumentsTypeBatteryCautionLabelType
    {
        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("base64_encoded_strings")]
        public JToken[] Base64EncodedStrings { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class UpdateWarehouseStateResponse
    {
        [JsonProperty("message")]
        public UpdateWarehouseStateResponseMessageTypeItem[] Message { get; set; }
    }

    public class UpdateWarehouseStateResponseMessageTypeItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("warehouse_state_updated")]
        public string WarehouseStateUpdated { get; set; }
    }

    public class bodyshipmentsInputItem2
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("warehouse_state")]
        public string WarehouseState { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("metadata")]
        public bodyshipmentsInputItemMetadataType Metadata { get; set; }
    }

    public class bodyshipmentsInputItemMetadataType
    {
        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }
    }

    public class GetAvailablePickupSlotsResponse
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("courier_name")]
        public string CourierName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("pickup")]
        public GetAvailablePickupSlotsResponsePickupType Pickup { get; set; }
    }

    public class GetAvailablePickupSlotsResponsePickupType
    {
        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }

        [JsonProperty("provider_customer_service_phone")]
        public string ProviderCustomerServicePhone { get; set; }

        [JsonProperty("slots")]
        public JToken Slots { get; set; }
    }

    public class RequestAPickupResponse
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("courier_name")]
        public string CourierName { get; set; }

        [JsonProperty("easyship_shipment_ids")]
        public string[] EasyshipShipmentIds { get; set; }

        [JsonProperty("pickup")]
        public RequestAPickupResponsePickupType Pickup { get; set; }
    }

    public class RequestAPickupResponsePickupType
    {
        [JsonProperty("easyship_pickup_id")]
        public string EasyshipPickupId { get; set; }

        [JsonProperty("preferred_min_time")]
        public string PreferredMinTime { get; set; }

        [JsonProperty("preferred_max_time")]
        public string PreferredMaxTime { get; set; }

        [JsonProperty("pickup_reference_number")]
        public string PickupReferenceNumber { get; set; }

        [JsonProperty("pickup_fee")]
        public string PickupFee { get; set; }

        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }

        [JsonProperty("provider_customer_service_phone")]
        public string ProviderCustomerServicePhone { get; set; }

        [JsonProperty("shipments_count")]
        public string ShipmentsCount { get; set; }

        [JsonProperty("total_actual_weight")]
        public string TotalActualWeight { get; set; }

        [JsonProperty("pickup_state")]
        public string PickupState { get; set; }

        [JsonProperty("address")]
        public RequestAPickupResponsePickupTypeAddressType Address { get; set; }
    }

    public class RequestAPickupResponsePickupTypeAddressType
    {
        [JsonProperty("line_1")]
        public string Line1 { get; set; }

        [JsonProperty("line_2")]
        public string Line2 { get; set; }

        [JsonProperty("line_3")]
        public string Line3 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }
    }

    public class GetCheckpointsResponse
    {
        [JsonProperty("total_page")]
        public int TotalPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("shipments")]
        public GetCheckpointsResponseShipmentsTypeItem[] Shipments { get; set; }
    }

    public class GetCheckpointsResponseShipmentsTypeItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_page_url")]
        public string TrackingPageUrl { get; set; }

        [JsonProperty("checkpoints")]
        public GetCheckpointsResponseShipmentsTypeItemCheckpointsTypeItem[] Checkpoints { get; set; }
    }

    public class GetCheckpointsResponseShipmentsTypeItemCheckpointsTypeItem
    {
        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        [JsonProperty("handler")]
        public string Handler { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_iso3")]
        public string CountryIso3 { get; set; }

        [JsonProperty("coordinates")]
        public JToken[] Coordinates { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("checkpoint_time")]
        public string CheckpointTime { get; set; }

        [JsonProperty("primary_status")]
        public string PrimaryStatus { get; set; }
    }

    public class GetStatusResponse
    {
        [JsonProperty("total_page")]
        public int TotalPage { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("shipments")]
        public GetStatusResponseShipmentsTypeItem[] Shipments { get; set; }
    }

    public class GetStatusResponseShipmentsTypeItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("tracking_page_url")]
        public string TrackingPageUrl { get; set; }
    }

    public class GetItemCategoriesResponse
    {
        [JsonProperty("categories")]
        public GetItemCategoriesResponseCategoriesTypeItem[] Categories { get; set; }
    }

    public class GetItemCategoriesResponseCategoriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class ListAllBoxesResponse
    {
        [JsonProperty("boxes")]
        public ListAllBoxesResponseBoxesTypeItem[] Boxes { get; set; }
    }

    public class ListAllBoxesResponseBoxesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("courier_umbrella_name")]
        public string CourierUmbrellaName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("outer_length")]
        public double OuterLength { get; set; }

        [JsonProperty("outer_width")]
        public double OuterWidth { get; set; }

        [JsonProperty("outer_height")]
        public double OuterHeight { get; set; }

        [JsonProperty("weight")]
        public double Weight { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easyshipip;

    public partial class WorkflowManagedActions
    {
        public EasyshipipActions Easyshipip(string connectionId) => new EasyshipipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasyshipipTriggers Easyshipip(string connectionId) => new EasyshipipTriggers(connectionId);
    }
}