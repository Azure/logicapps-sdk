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
        public IBodyWorkflowAction<GetRatesTaxesResponse> GetRatesTaxes(Expression<Func<string>> bodyoriginAddressline1 = null, Expression<Func<string>> bodyoriginAddressline2 = null, Expression<Func<string>> bodyoriginAddressstate = null, Expression<Func<string>> bodyoriginAddresscity = null, Expression<Func<string>> bodyoriginAddresspostalCode = null, Expression<Func<string>> bodyoriginAddresscountryAlpha2 = null, Expression<Func<string>> bodydestinationAddressline1 = null, Expression<Func<string>> bodydestinationAddressline2 = null, Expression<Func<string>> bodydestinationAddressstate = null, Expression<Func<string>> bodydestinationAddresscity = null, Expression<Func<string>> bodydestinationAddresspostalCode = null, Expression<Func<string>> bodydestinationAddresscountryAlpha2 = null, Expression<Func<string>> bodyincoterms = null, Expression<Func<bool>> bodyinsuranceisInsured = null, Expression<Func<int>> bodyinsuranceinsuredAmount = null, Expression<Func<string>> bodyinsuranceinsuredCurrency = null, Expression<Func<bool>> bodycourierSelectionapplyShippingRules = null, Expression<Func<string>> bodyshippingSettingsunitsweight = null, Expression<Func<string>> bodyshippingSettingsunitsdimensions = null, Expression<Func<string>> bodyshippingSettingsoutputCurrency = null, Expression<Func<bodyparcelsInputItem[]>> bodyparcels = null)
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
                originAddressObject["line_1"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddressline1);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddressline2 != null)
            {
                originAddressObject["line_2"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddressline2);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddressstate != null)
            {
                originAddressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddressstate);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscity != null)
            {
                originAddressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscity);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresspostalCode != null)
            {
                originAddressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresspostalCode);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscountryAlpha2 != null)
            {
                originAddressObject["country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscountryAlpha2);
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
                destinationAddressObject["line_1"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressline1);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddressline2 != null)
            {
                destinationAddressObject["line_2"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressline2);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddressstate != null)
            {
                destinationAddressObject["state"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressstate);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscity != null)
            {
                destinationAddressObject["city"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscity);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresspostalCode != null)
            {
                destinationAddressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresspostalCode);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscountryAlpha2 != null)
            {
                destinationAddressObject["country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscountryAlpha2);
                destinationAddressObjectpropCount++;
            }

            if (destinationAddressObjectpropCount > 0)
            {
                body["destination_address"] = destinationAddressObject;
                bodypropCount++;
            }

            if (bodyincoterms != null)
            {
                body["incoterms"] = CSharpExpressionConverter.ConvertToken(bodyincoterms);
                bodypropCount++;
            }

            var insuranceObject = new JObject();
            var insuranceObjectpropCount = 0;
            if (bodyinsuranceisInsured != null)
            {
                insuranceObject["is_insured"] = CSharpExpressionConverter.ConvertToken(bodyinsuranceisInsured);
                insuranceObjectpropCount++;
            }

            if (bodyinsuranceinsuredAmount != null)
            {
                insuranceObject["insured_amount"] = CSharpExpressionConverter.ConvertToken(bodyinsuranceinsuredAmount);
                insuranceObjectpropCount++;
            }

            if (bodyinsuranceinsuredCurrency != null)
            {
                insuranceObject["insured_currency"] = CSharpExpressionConverter.ConvertToken(bodyinsuranceinsuredCurrency);
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
                courierSelectionObject["apply_shipping_rules"] = CSharpExpressionConverter.ConvertToken(bodycourierSelectionapplyShippingRules);
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
                unitsObject["weight"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsunitsweight);
                unitsObjectpropCount++;
            }

            if (bodyshippingSettingsunitsdimensions != null)
            {
                unitsObject["dimensions"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsunitsdimensions);
                unitsObjectpropCount++;
            }

            if (unitsObjectpropCount > 0)
            {
                shippingSettingsObject["units"] = unitsObject;
                shippingSettingsObjectpropCount++;
            }

            if (bodyshippingSettingsoutputCurrency != null)
            {
                shippingSettingsObject["output_currency"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsoutputCurrency);
                shippingSettingsObjectpropCount++;
            }

            if (shippingSettingsObjectpropCount > 0)
            {
                body["shipping_settings"] = shippingSettingsObject;
                bodypropCount++;
            }

            if (bodyparcels != null)
            {
                body["parcels"] = CSharpExpressionConverter.ConvertToken(bodyparcels);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetRatesTaxesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<ListAllShipmentsResponse> ListAllShipments(Expression<Func<string>> easyshipShipmentId = null, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> confirmedAtFrom = null, Expression<Func<string>> confirmAtTo = null, Expression<Func<string>> labelGeneratedAtFrom = null, Expression<Func<string>> labelGeneratedAtTo = null, Expression<Func<string>> shipmentState = null, Expression<Func<string>> pickupState = null, Expression<Func<string>> deliveryState = null, Expression<Func<string>> labelState = null, Expression<Func<string>> warehouseState = null)
        {
            var apiCallPath = "/v2/shipments";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (easyshipShipmentId != null)
                callPayload.Queries["easyship_shipment_id"] = CSharpExpressionConverter.ConvertO(easyshipShipmentId);
            if (platformOrderNumber != null)
                callPayload.Queries["platform_order_number"] = CSharpExpressionConverter.ConvertO(platformOrderNumber);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            if (createdAtFrom != null)
                callPayload.Queries["created_at_from"] = CSharpExpressionConverter.ConvertO(createdAtFrom);
            if (createdAtTo != null)
                callPayload.Queries["created_at_to"] = CSharpExpressionConverter.ConvertO(createdAtTo);
            if (confirmedAtFrom != null)
                callPayload.Queries["confirmed_at_from"] = CSharpExpressionConverter.ConvertO(confirmedAtFrom);
            if (confirmAtTo != null)
                callPayload.Queries["confirm_at_to"] = CSharpExpressionConverter.ConvertO(confirmAtTo);
            if (labelGeneratedAtFrom != null)
                callPayload.Queries["label_generated_at_from"] = CSharpExpressionConverter.ConvertO(labelGeneratedAtFrom);
            if (labelGeneratedAtTo != null)
                callPayload.Queries["label_generated_at_to"] = CSharpExpressionConverter.ConvertO(labelGeneratedAtTo);
            if (shipmentState != null)
                callPayload.Queries["shipment_state"] = CSharpExpressionConverter.ConvertO(shipmentState);
            if (pickupState != null)
                callPayload.Queries["pickup_state"] = CSharpExpressionConverter.ConvertO(pickupState);
            if (deliveryState != null)
                callPayload.Queries["delivery_state"] = CSharpExpressionConverter.ConvertO(deliveryState);
            if (labelState != null)
                callPayload.Queries["label_state"] = CSharpExpressionConverter.ConvertO(labelState);
            if (warehouseState != null)
                callPayload.Queries["warehouse_state"] = CSharpExpressionConverter.ConvertO(warehouseState);
            return new ApiConnectionAction<ListAllShipmentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<CreateAShipmentResponse> CreateAShipment(Expression<Func<string>> bodyoriginAddressline1 = null, Expression<Func<string>> bodyoriginAddressline2 = null, Expression<Func<string>> bodyoriginAddressstate = null, Expression<Func<string>> bodyoriginAddresscity = null, Expression<Func<string>> bodyoriginAddresspostalCode = null, Expression<Func<string>> bodyoriginAddresscountryAlpha2 = null, Expression<Func<string>> bodyoriginAddresscontactName = null, Expression<Func<string>> bodyoriginAddresscompanyName = null, Expression<Func<string>> bodyoriginAddresscontactPhone = null, Expression<Func<string>> bodyoriginAddresscontactEmail = null, Expression<Func<string>> bodysenderAddressline1 = null, Expression<Func<string>> bodysenderAddressline2 = null, Expression<Func<string>> bodysenderAddressstate = null, Expression<Func<string>> bodysenderAddresscity = null, Expression<Func<string>> bodysenderAddresspostalCode = null, Expression<Func<string>> bodysenderAddresscountryAlpha2 = null, Expression<Func<string>> bodysenderAddresscontactName = null, Expression<Func<string>> bodysenderAddresscompanyName = null, Expression<Func<string>> bodysenderAddresscontactPhone = null, Expression<Func<string>> bodysenderAddresscontactEmail = null, Expression<Func<string>> bodyreturnAddressline1 = null, Expression<Func<string>> bodyreturnAddressline2 = null, Expression<Func<string>> bodyreturnAddressstate = null, Expression<Func<string>> bodyreturnAddresscity = null, Expression<Func<string>> bodyreturnAddresspostalCode = null, Expression<Func<string>> bodyreturnAddresscountryAlpha2 = null, Expression<Func<string>> bodyreturnAddresscontactName = null, Expression<Func<string>> bodyreturnAddresscompanyName = null, Expression<Func<string>> bodyreturnAddresscontactPhone = null, Expression<Func<string>> bodyreturnAddresscontactEmail = null, Expression<Func<string>> bodydestinationAddressline1 = null, Expression<Func<string>> bodydestinationAddressline2 = null, Expression<Func<string>> bodydestinationAddressstate = null, Expression<Func<string>> bodydestinationAddresscity = null, Expression<Func<string>> bodydestinationAddresspostalCode = null, Expression<Func<string>> bodydestinationAddresscountryAlpha2 = null, Expression<Func<string>> bodydestinationAddresscontactName = null, Expression<Func<string>> bodydestinationAddresscompanyName = null, Expression<Func<string>> bodydestinationAddresscontactPhone = null, Expression<Func<string>> bodydestinationAddresscontactEmail = null, Expression<Func<bool>> bodysetAsResidential = null, Expression<Func<string>> bodyconsigneeTaxId = null, Expression<Func<string>> bodyeeiReference = null, Expression<Func<string>> bodyincoterms = null, Expression<Func<bool>> bodyinsuranceisInsured = null, Expression<Func<int>> bodyinsuranceinsuredAmount = null, Expression<Func<string>> bodyinsuranceinsuredCurrency = null, Expression<Func<string>> bodyorderDataplatformName = null, Expression<Func<string>> bodyorderDataplatformOrderNumber = null, Expression<Func<string[]>> bodyorderDataorderTagList = null, Expression<Func<string>> bodyorderDatasellerNotes = null, Expression<Func<string>> bodyorderDatabuyerNotes = null, Expression<Func<string>> bodycourierSelectionselectedCourierId = null, Expression<Func<bool>> bodycourierSelectionallowCourierFallback = null, Expression<Func<bool>> bodycourierSelectionapplyShippingRules = null, Expression<Func<string>> bodyshippingSettingsunitsweight = null, Expression<Func<string>> bodyshippingSettingsunitsdimensions = null, Expression<Func<string>> bodyshippingSettingsprintingOptionsformat = null, Expression<Func<string>> bodyshippingSettingsprintingOptionslabel = null, Expression<Func<string>> bodyshippingSettingsprintingOptionscommercialInvoice = null, Expression<Func<string>> bodyshippingSettingsprintingOptionspackingSlip = null, Expression<Func<bool>> bodyshippingSettingsbuyLabel = null, Expression<Func<bool>> bodyshippingSettingsbuyLabelSynchronous = null, Expression<Func<bodyparcelsInputItem[]>> bodyparcels = null)
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
                originAddressObject["line_1"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddressline1);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddressline2 != null)
            {
                originAddressObject["line_2"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddressline2);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddressstate != null)
            {
                originAddressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddressstate);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscity != null)
            {
                originAddressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscity);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresspostalCode != null)
            {
                originAddressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresspostalCode);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscountryAlpha2 != null)
            {
                originAddressObject["country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscountryAlpha2);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscontactName != null)
            {
                originAddressObject["contact_name"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscontactName);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscompanyName != null)
            {
                originAddressObject["company_name"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscompanyName);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscontactPhone != null)
            {
                originAddressObject["contact_phone"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscontactPhone);
                originAddressObjectpropCount++;
            }

            if (bodyoriginAddresscontactEmail != null)
            {
                originAddressObject["contact_email"] = CSharpExpressionConverter.ConvertToken(bodyoriginAddresscontactEmail);
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
                senderAddressObject["line_1"] = CSharpExpressionConverter.ConvertToken(bodysenderAddressline1);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddressline2 != null)
            {
                senderAddressObject["line_2"] = CSharpExpressionConverter.ConvertToken(bodysenderAddressline2);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddressstate != null)
            {
                senderAddressObject["state"] = CSharpExpressionConverter.ConvertToken(bodysenderAddressstate);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresscity != null)
            {
                senderAddressObject["city"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresscity);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresspostalCode != null)
            {
                senderAddressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresspostalCode);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresscountryAlpha2 != null)
            {
                senderAddressObject["country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresscountryAlpha2);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresscontactName != null)
            {
                senderAddressObject["contact_name"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresscontactName);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresscompanyName != null)
            {
                senderAddressObject["company_name"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresscompanyName);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresscontactPhone != null)
            {
                senderAddressObject["contact_phone"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresscontactPhone);
                senderAddressObjectpropCount++;
            }

            if (bodysenderAddresscontactEmail != null)
            {
                senderAddressObject["contact_email"] = CSharpExpressionConverter.ConvertToken(bodysenderAddresscontactEmail);
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
                returnAddressObject["line_1"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddressline1);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddressline2 != null)
            {
                returnAddressObject["line_2"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddressline2);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddressstate != null)
            {
                returnAddressObject["state"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddressstate);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresscity != null)
            {
                returnAddressObject["city"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresscity);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresspostalCode != null)
            {
                returnAddressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresspostalCode);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresscountryAlpha2 != null)
            {
                returnAddressObject["country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresscountryAlpha2);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresscontactName != null)
            {
                returnAddressObject["contact_name"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresscontactName);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresscompanyName != null)
            {
                returnAddressObject["company_name"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresscompanyName);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresscontactPhone != null)
            {
                returnAddressObject["contact_phone"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresscontactPhone);
                returnAddressObjectpropCount++;
            }

            if (bodyreturnAddresscontactEmail != null)
            {
                returnAddressObject["contact_email"] = CSharpExpressionConverter.ConvertToken(bodyreturnAddresscontactEmail);
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
                destinationAddressObject["line_1"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressline1);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddressline2 != null)
            {
                destinationAddressObject["line_2"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressline2);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddressstate != null)
            {
                destinationAddressObject["state"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressstate);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscity != null)
            {
                destinationAddressObject["city"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscity);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresspostalCode != null)
            {
                destinationAddressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresspostalCode);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscountryAlpha2 != null)
            {
                destinationAddressObject["country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscountryAlpha2);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscontactName != null)
            {
                destinationAddressObject["contact_name"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscontactName);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscompanyName != null)
            {
                destinationAddressObject["company_name"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscompanyName);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscontactPhone != null)
            {
                destinationAddressObject["contact_phone"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscontactPhone);
                destinationAddressObjectpropCount++;
            }

            if (bodydestinationAddresscontactEmail != null)
            {
                destinationAddressObject["contact_email"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddresscontactEmail);
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
                body["set_as_residential"] = CSharpExpressionConverter.ConvertToken(bodysetAsResidential);
                bodypropCount++;
            }

            if (bodyconsigneeTaxId != null)
            {
                body["consignee_tax_id"] = CSharpExpressionConverter.ConvertToken(bodyconsigneeTaxId);
                bodypropCount++;
            }

            if (bodyeeiReference != null)
            {
                body["eei_reference"] = CSharpExpressionConverter.ConvertToken(bodyeeiReference);
                bodypropCount++;
            }

            if (bodyincoterms != null)
            {
                body["incoterms"] = CSharpExpressionConverter.ConvertToken(bodyincoterms);
                bodypropCount++;
            }

            var insuranceObject = new JObject();
            var insuranceObjectpropCount = 0;
            if (bodyinsuranceisInsured != null)
            {
                insuranceObject["is_insured"] = CSharpExpressionConverter.ConvertToken(bodyinsuranceisInsured);
                insuranceObjectpropCount++;
            }

            if (bodyinsuranceinsuredAmount != null)
            {
                insuranceObject["insured_amount"] = CSharpExpressionConverter.ConvertToken(bodyinsuranceinsuredAmount);
                insuranceObjectpropCount++;
            }

            if (bodyinsuranceinsuredCurrency != null)
            {
                insuranceObject["insured_currency"] = CSharpExpressionConverter.ConvertToken(bodyinsuranceinsuredCurrency);
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
                orderDataObject["platform_name"] = CSharpExpressionConverter.ConvertToken(bodyorderDataplatformName);
                orderDataObjectpropCount++;
            }

            if (bodyorderDataplatformOrderNumber != null)
            {
                orderDataObject["platform_order_number"] = CSharpExpressionConverter.ConvertToken(bodyorderDataplatformOrderNumber);
                orderDataObjectpropCount++;
            }

            if (bodyorderDataorderTagList != null)
            {
                orderDataObject["order_tag_list"] = CSharpExpressionConverter.ConvertToken(bodyorderDataorderTagList);
                orderDataObjectpropCount++;
            }

            if (bodyorderDatasellerNotes != null)
            {
                orderDataObject["seller_notes"] = CSharpExpressionConverter.ConvertToken(bodyorderDatasellerNotes);
                orderDataObjectpropCount++;
            }

            if (bodyorderDatabuyerNotes != null)
            {
                orderDataObject["buyer_notes"] = CSharpExpressionConverter.ConvertToken(bodyorderDatabuyerNotes);
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
                courierSelectionObject["selected_courier_id"] = CSharpExpressionConverter.ConvertToken(bodycourierSelectionselectedCourierId);
                courierSelectionObjectpropCount++;
            }

            if (bodycourierSelectionallowCourierFallback != null)
            {
                courierSelectionObject["allow_courier_fallback"] = CSharpExpressionConverter.ConvertToken(bodycourierSelectionallowCourierFallback);
                courierSelectionObjectpropCount++;
            }

            if (bodycourierSelectionapplyShippingRules != null)
            {
                courierSelectionObject["apply_shipping_rules"] = CSharpExpressionConverter.ConvertToken(bodycourierSelectionapplyShippingRules);
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
                unitsObject["weight"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsunitsweight);
                unitsObjectpropCount++;
            }

            if (bodyshippingSettingsunitsdimensions != null)
            {
                unitsObject["dimensions"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsunitsdimensions);
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
                printingOptionsObject["format"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionsformat);
                printingOptionsObjectpropCount++;
            }

            if (bodyshippingSettingsprintingOptionslabel != null)
            {
                printingOptionsObject["label"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionslabel);
                printingOptionsObjectpropCount++;
            }

            if (bodyshippingSettingsprintingOptionscommercialInvoice != null)
            {
                printingOptionsObject["commercial_invoice"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionscommercialInvoice);
                printingOptionsObjectpropCount++;
            }

            if (bodyshippingSettingsprintingOptionspackingSlip != null)
            {
                printingOptionsObject["packing_slip"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsprintingOptionspackingSlip);
                printingOptionsObjectpropCount++;
            }

            if (printingOptionsObjectpropCount > 0)
            {
                shippingSettingsObject["printing_options"] = printingOptionsObject;
                shippingSettingsObjectpropCount++;
            }

            if (bodyshippingSettingsbuyLabel != null)
            {
                shippingSettingsObject["buy_label"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsbuyLabel);
                shippingSettingsObjectpropCount++;
            }

            if (bodyshippingSettingsbuyLabelSynchronous != null)
            {
                shippingSettingsObject["buy_label_synchronous"] = CSharpExpressionConverter.ConvertToken(bodyshippingSettingsbuyLabelSynchronous);
                shippingSettingsObjectpropCount++;
            }

            if (shippingSettingsObjectpropCount > 0)
            {
                body["shipping_settings"] = shippingSettingsObject;
                bodypropCount++;
            }

            if (bodyparcels != null)
            {
                body["parcels"] = CSharpExpressionConverter.ConvertToken(bodyparcels);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateAShipmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<BuyAShipmentLabelResponse> BuyAShipmentLabel(Expression<Func<bodyshipmentsInputItem[]>> bodyshipments = null)
        {
            var apiCallPath = "/label/v1/labels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyshipments != null)
            {
                body["shipments"] = CSharpExpressionConverter.ConvertToken(bodyshipments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<BuyAShipmentLabelResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<DeleteAShipmentResponse> DeleteAShipment(Expression<Func<string>> easyshipShipmentId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(easyshipShipmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteAShipmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateAShipmentResponse> UpdateAShipment(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> bodydestinationCountryAlpha2 = null, Expression<Func<string>> bodydestinationCity = null, Expression<Func<string>> bodydestinationName = null, Expression<Func<string>> bodydestinationAddressLine1 = null, Expression<Func<string>> bodydestinationPhoneNumber = null, Expression<Func<bodyitemsInputItem[]>> bodyitems = null, Expression<Func<string>> bodyplatformName = null, Expression<Func<string>> bodyplatformOrderNumber = null, Expression<Func<string>> bodytaxesDutiesPaidBy = null, Expression<Func<bool>> bodyisInsured = null, Expression<Func<string>> bodyselectedCourierId = null, Expression<Func<int>> bodydestinationPostalCode = null, Expression<Func<string>> bodydestinationState = null, Expression<Func<string>> bodydestinationAddressLine2 = null, Expression<Func<string>> bodydestinationEmailAddress = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(easyshipShipmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydestinationCountryAlpha2 != null)
            {
                body["destination_country_alpha2"] = CSharpExpressionConverter.ConvertToken(bodydestinationCountryAlpha2);
                bodypropCount++;
            }

            if (bodydestinationCity != null)
            {
                body["destination_city"] = CSharpExpressionConverter.ConvertToken(bodydestinationCity);
                bodypropCount++;
            }

            if (bodydestinationName != null)
            {
                body["destination_name"] = CSharpExpressionConverter.ConvertToken(bodydestinationName);
                bodypropCount++;
            }

            if (bodydestinationAddressLine1 != null)
            {
                body["destination_address_line_1"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressLine1);
                bodypropCount++;
            }

            if (bodydestinationPhoneNumber != null)
            {
                body["destination_phone_number"] = CSharpExpressionConverter.ConvertToken(bodydestinationPhoneNumber);
                bodypropCount++;
            }

            if (bodyitems != null)
            {
                body["items"] = CSharpExpressionConverter.ConvertToken(bodyitems);
                bodypropCount++;
            }

            if (bodyplatformName != null)
            {
                body["platform_name"] = CSharpExpressionConverter.ConvertToken(bodyplatformName);
                bodypropCount++;
            }

            if (bodyplatformOrderNumber != null)
            {
                body["platform_order_number"] = CSharpExpressionConverter.ConvertToken(bodyplatformOrderNumber);
                bodypropCount++;
            }

            if (bodytaxesDutiesPaidBy != null)
            {
                body["taxes_duties_paid_by"] = CSharpExpressionConverter.ConvertToken(bodytaxesDutiesPaidBy);
                bodypropCount++;
            }

            if (bodyisInsured != null)
            {
                body["is_insured"] = CSharpExpressionConverter.ConvertToken(bodyisInsured);
                bodypropCount++;
            }

            if (bodyselectedCourierId != null)
            {
                body["selected_courier_id"] = CSharpExpressionConverter.ConvertToken(bodyselectedCourierId);
                bodypropCount++;
            }

            if (bodydestinationPostalCode != null)
            {
                body["destination_postal_code"] = CSharpExpressionConverter.ConvertToken(bodydestinationPostalCode);
                bodypropCount++;
            }

            if (bodydestinationState != null)
            {
                body["destination_state"] = CSharpExpressionConverter.ConvertToken(bodydestinationState);
                bodypropCount++;
            }

            if (bodydestinationAddressLine2 != null)
            {
                body["destination_address_line_2"] = CSharpExpressionConverter.ConvertToken(bodydestinationAddressLine2);
                bodypropCount++;
            }

            if (bodydestinationEmailAddress != null)
            {
                body["destination_email_address"] = CSharpExpressionConverter.ConvertToken(bodydestinationEmailAddress);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAShipmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetAShipmentResponse> GetAShipment(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> format = null, Expression<Func<string>> label = null, Expression<Func<string>> commercialInvoice = null, Expression<Func<string>> packingSlip = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v2/shipments/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(easyshipShipmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (format != null)
                callPayload.Queries["format"] = CSharpExpressionConverter.ConvertO(format);
            if (label != null)
                callPayload.Queries["label"] = CSharpExpressionConverter.ConvertO(label);
            if (commercialInvoice != null)
                callPayload.Queries["commercial_invoice"] = CSharpExpressionConverter.ConvertO(commercialInvoice);
            if (packingSlip != null)
                callPayload.Queries["packing_slip"] = CSharpExpressionConverter.ConvertO(packingSlip);
            return new ApiConnectionAction<GetAShipmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateWarehouseStateResponse> UpdateWarehouseState(Expression<Func<bodyshipmentsInputItem2[]>> bodyshipments = null)
        {
            var apiCallPath = "/v2/shipments/warehouse_state";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyshipments != null)
            {
                body["shipments"] = CSharpExpressionConverter.ConvertToken(bodyshipments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateWarehouseStateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetAvailablePickupSlotsResponse> GetAvailablePickupSlots(Expression<Func<string>> courierId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/pickup/v1/pickup_slots/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(courierId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAvailablePickupSlotsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<RequestAPickupResponse> RequestAPickup(Expression<Func<string>> bodycourierId = null, Expression<Func<string>> bodypreferredDate = null, Expression<Func<string>> bodypreferredMaxTime = null, Expression<Func<string>> bodypreferredMinTime = null, Expression<Func<string[]>> bodyeasyshipShipmentIds = null)
        {
            var apiCallPath = "/pickup/v1/pickups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycourierId != null)
            {
                body["courier_id"] = CSharpExpressionConverter.ConvertToken(bodycourierId);
                bodypropCount++;
            }

            if (bodypreferredDate != null)
            {
                body["preferred_date"] = CSharpExpressionConverter.ConvertToken(bodypreferredDate);
                bodypropCount++;
            }

            if (bodypreferredMaxTime != null)
            {
                body["preferred_max_time"] = CSharpExpressionConverter.ConvertToken(bodypreferredMaxTime);
                bodypropCount++;
            }

            if (bodypreferredMinTime != null)
            {
                body["preferred_min_time"] = CSharpExpressionConverter.ConvertToken(bodypreferredMinTime);
                bodypropCount++;
            }

            if (bodyeasyshipShipmentIds != null)
            {
                body["easyship_shipment_ids"] = CSharpExpressionConverter.ConvertToken(bodyeasyshipShipmentIds);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RequestAPickupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetCheckpointsResponse> GetCheckpoints(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/track/v1/checkpoints";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["easyship_shipment_id"] = CSharpExpressionConverter.ConvertO(easyshipShipmentId);
            if (platformOrderNumber != null)
                callPayload.Queries["platform_order_number"] = CSharpExpressionConverter.ConvertO(platformOrderNumber);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            return new ApiConnectionAction<GetCheckpointsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetStatusResponse> GetStatus(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/track/v1/status";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["easyship_shipment_id"] = CSharpExpressionConverter.ConvertO(easyshipShipmentId);
            if (platformOrderNumber != null)
                callPayload.Queries["platform_order_number"] = CSharpExpressionConverter.ConvertO(platformOrderNumber);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = CSharpExpressionConverter.ConvertO(perPage);
            return new ApiConnectionAction<GetStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetItemCategoriesResponse> GetItemCategories()
        {
            var apiCallPath = "/reference/v1/categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetItemCategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<ListAllBoxesResponse> ListAllBoxes()
        {
            var apiCallPath = "/v2/boxes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAllBoxesResponse>(callPayload);
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