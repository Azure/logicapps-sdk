//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyshipip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyshipipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetRatesTaxes))]
        public IBodyWorkflowAction<GetRatesTaxesResponse> GetRatesTaxes([WorkflowExpression] Func<string> bodyoriginAddressline1 = null, [WorkflowExpression] Func<string> bodyoriginAddressline2 = null, [WorkflowExpression] Func<string> bodyoriginAddressstate = null, [WorkflowExpression] Func<string> bodyoriginAddresscity = null, [WorkflowExpression] Func<string> bodyoriginAddresspostalCode = null, [WorkflowExpression] Func<string> bodyoriginAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodydestinationAddressline1 = null, [WorkflowExpression] Func<string> bodydestinationAddressline2 = null, [WorkflowExpression] Func<string> bodydestinationAddressstate = null, [WorkflowExpression] Func<string> bodydestinationAddresscity = null, [WorkflowExpression] Func<string> bodydestinationAddresspostalCode = null, [WorkflowExpression] Func<string> bodydestinationAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodyincoterms = null, [WorkflowExpression] Func<bool> bodyinsuranceisInsured = null, [WorkflowExpression] Func<int> bodyinsuranceinsuredAmount = null, [WorkflowExpression] Func<string> bodyinsuranceinsuredCurrency = null, [WorkflowExpression] Func<bool> bodycourierSelectionapplyShippingRules = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsweight = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsdimensions = null, [WorkflowExpression] Func<string> bodyshippingSettingsoutputCurrency = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRatesTaxesResponse> __BuildGetRatesTaxes(WorkflowValue<string> bodyoriginAddressline1 = null, WorkflowValue<string> bodyoriginAddressline2 = null, WorkflowValue<string> bodyoriginAddressstate = null, WorkflowValue<string> bodyoriginAddresscity = null, WorkflowValue<string> bodyoriginAddresspostalCode = null, WorkflowValue<string> bodyoriginAddresscountryAlpha2 = null, WorkflowValue<string> bodydestinationAddressline1 = null, WorkflowValue<string> bodydestinationAddressline2 = null, WorkflowValue<string> bodydestinationAddressstate = null, WorkflowValue<string> bodydestinationAddresscity = null, WorkflowValue<string> bodydestinationAddresspostalCode = null, WorkflowValue<string> bodydestinationAddresscountryAlpha2 = null, WorkflowValue<string> bodyincoterms = null, WorkflowValue<bool> bodyinsuranceisInsured = null, WorkflowValue<int> bodyinsuranceinsuredAmount = null, WorkflowValue<string> bodyinsuranceinsuredCurrency = null, WorkflowValue<bool> bodycourierSelectionapplyShippingRules = null, WorkflowValue<string> bodyshippingSettingsunitsweight = null, WorkflowValue<string> bodyshippingSettingsunitsdimensions = null, WorkflowValue<string> bodyshippingSettingsoutputCurrency = null, WorkflowValue<bodyparcelsInputItem[]> bodyparcels = null)
        {
            WorkflowValue.Validate(bodyoriginAddressline1, nameof(bodyoriginAddressline1), required: false);
            WorkflowValue.Validate(bodyoriginAddressline2, nameof(bodyoriginAddressline2), required: false);
            WorkflowValue.Validate(bodyoriginAddressstate, nameof(bodyoriginAddressstate), required: false);
            WorkflowValue.Validate(bodyoriginAddresscity, nameof(bodyoriginAddresscity), required: false);
            WorkflowValue.Validate(bodyoriginAddresspostalCode, nameof(bodyoriginAddresspostalCode), required: false);
            WorkflowValue.Validate(bodyoriginAddresscountryAlpha2, nameof(bodyoriginAddresscountryAlpha2), required: false);
            WorkflowValue.Validate(bodydestinationAddressline1, nameof(bodydestinationAddressline1), required: false);
            WorkflowValue.Validate(bodydestinationAddressline2, nameof(bodydestinationAddressline2), required: false);
            WorkflowValue.Validate(bodydestinationAddressstate, nameof(bodydestinationAddressstate), required: false);
            WorkflowValue.Validate(bodydestinationAddresscity, nameof(bodydestinationAddresscity), required: false);
            WorkflowValue.Validate(bodydestinationAddresspostalCode, nameof(bodydestinationAddresspostalCode), required: false);
            WorkflowValue.Validate(bodydestinationAddresscountryAlpha2, nameof(bodydestinationAddresscountryAlpha2), required: false);
            WorkflowValue.Validate(bodyincoterms, nameof(bodyincoterms), required: false);
            WorkflowValue.Validate(bodyinsuranceisInsured, nameof(bodyinsuranceisInsured), required: false);
            WorkflowValue.Validate(bodyinsuranceinsuredAmount, nameof(bodyinsuranceinsuredAmount), required: false);
            WorkflowValue.Validate(bodyinsuranceinsuredCurrency, nameof(bodyinsuranceinsuredCurrency), required: false);
            WorkflowValue.Validate(bodycourierSelectionapplyShippingRules, nameof(bodycourierSelectionapplyShippingRules), required: false);
            WorkflowValue.Validate(bodyshippingSettingsunitsweight, nameof(bodyshippingSettingsunitsweight), required: false);
            WorkflowValue.Validate(bodyshippingSettingsunitsdimensions, nameof(bodyshippingSettingsunitsdimensions), required: false);
            WorkflowValue.Validate(bodyshippingSettingsoutputCurrency, nameof(bodyshippingSettingsoutputCurrency), required: false);
            WorkflowValue.Validate(bodyparcels, nameof(bodyparcels), required: false);
            return new DeferredBodyAction<GetRatesTaxesResponse>(() =>
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
                    originAddressObject["line_1"] = ExpressionConverter.ConvertO(bodyoriginAddressline1);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressline2 != null)
                {
                    originAddressObject["line_2"] = ExpressionConverter.ConvertO(bodyoriginAddressline2);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressstate != null)
                {
                    originAddressObject["state"] = ExpressionConverter.ConvertO(bodyoriginAddressstate);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscity != null)
                {
                    originAddressObject["city"] = ExpressionConverter.ConvertO(bodyoriginAddresscity);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresspostalCode != null)
                {
                    originAddressObject["postal_code"] = ExpressionConverter.ConvertO(bodyoriginAddresspostalCode);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscountryAlpha2 != null)
                {
                    originAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(bodyoriginAddresscountryAlpha2);
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
                    destinationAddressObject["line_1"] = ExpressionConverter.ConvertO(bodydestinationAddressline1);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressline2 != null)
                {
                    destinationAddressObject["line_2"] = ExpressionConverter.ConvertO(bodydestinationAddressline2);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressstate != null)
                {
                    destinationAddressObject["state"] = ExpressionConverter.ConvertO(bodydestinationAddressstate);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscity != null)
                {
                    destinationAddressObject["city"] = ExpressionConverter.ConvertO(bodydestinationAddresscity);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresspostalCode != null)
                {
                    destinationAddressObject["postal_code"] = ExpressionConverter.ConvertO(bodydestinationAddresspostalCode);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscountryAlpha2 != null)
                {
                    destinationAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(bodydestinationAddresscountryAlpha2);
                    destinationAddressObjectpropCount++;
                }

                if (destinationAddressObjectpropCount > 0)
                {
                    body["destination_address"] = destinationAddressObject;
                    bodypropCount++;
                }

                if (bodyincoterms != null)
                {
                    body["incoterms"] = ExpressionConverter.ConvertO(bodyincoterms);
                    bodypropCount++;
                }

                var insuranceObject = new JObject();
                var insuranceObjectpropCount = 0;
                if (bodyinsuranceisInsured != null)
                {
                    insuranceObject["is_insured"] = ExpressionConverter.ConvertO(bodyinsuranceisInsured);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredAmount != null)
                {
                    insuranceObject["insured_amount"] = ExpressionConverter.ConvertO(bodyinsuranceinsuredAmount);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredCurrency != null)
                {
                    insuranceObject["insured_currency"] = ExpressionConverter.ConvertO(bodyinsuranceinsuredCurrency);
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
                    courierSelectionObject["apply_shipping_rules"] = ExpressionConverter.ConvertO(bodycourierSelectionapplyShippingRules);
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
                    unitsObject["weight"] = ExpressionConverter.ConvertO(bodyshippingSettingsunitsweight);
                    unitsObjectpropCount++;
                }

                if (bodyshippingSettingsunitsdimensions != null)
                {
                    unitsObject["dimensions"] = ExpressionConverter.ConvertO(bodyshippingSettingsunitsdimensions);
                    unitsObjectpropCount++;
                }

                if (unitsObjectpropCount > 0)
                {
                    shippingSettingsObject["units"] = unitsObject;
                    shippingSettingsObjectpropCount++;
                }

                if (bodyshippingSettingsoutputCurrency != null)
                {
                    shippingSettingsObject["output_currency"] = ExpressionConverter.ConvertO(bodyshippingSettingsoutputCurrency);
                    shippingSettingsObjectpropCount++;
                }

                if (shippingSettingsObjectpropCount > 0)
                {
                    body["shipping_settings"] = shippingSettingsObject;
                    bodypropCount++;
                }

                if (bodyparcels != null)
                {
                    body["parcels"] = ExpressionConverter.ConvertO(bodyparcels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetRatesTaxesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildListAllShipments))]
        public IBodyWorkflowAction<ListAllShipmentsResponse> ListAllShipments([WorkflowExpression] Func<string> easyshipShipmentId = null, [WorkflowExpression] Func<string> platformOrderNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<string> createdAtFrom = null, [WorkflowExpression] Func<string> createdAtTo = null, [WorkflowExpression] Func<string> confirmedAtFrom = null, [WorkflowExpression] Func<string> confirmAtTo = null, [WorkflowExpression] Func<string> labelGeneratedAtFrom = null, [WorkflowExpression] Func<string> labelGeneratedAtTo = null, [WorkflowExpression] Func<string> shipmentState = null, [WorkflowExpression] Func<string> pickupState = null, [WorkflowExpression] Func<string> deliveryState = null, [WorkflowExpression] Func<string> labelState = null, [WorkflowExpression] Func<string> warehouseState = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListAllShipmentsResponse> __BuildListAllShipments(WorkflowValue<string> easyshipShipmentId = null, WorkflowValue<string> platformOrderNumber = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null, WorkflowValue<string> createdAtFrom = null, WorkflowValue<string> createdAtTo = null, WorkflowValue<string> confirmedAtFrom = null, WorkflowValue<string> confirmAtTo = null, WorkflowValue<string> labelGeneratedAtFrom = null, WorkflowValue<string> labelGeneratedAtTo = null, WorkflowValue<string> shipmentState = null, WorkflowValue<string> pickupState = null, WorkflowValue<string> deliveryState = null, WorkflowValue<string> labelState = null, WorkflowValue<string> warehouseState = null)
        {
            WorkflowValue.Validate(easyshipShipmentId, nameof(easyshipShipmentId), required: false);
            WorkflowValue.Validate(platformOrderNumber, nameof(platformOrderNumber), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            WorkflowValue.Validate(createdAtFrom, nameof(createdAtFrom), required: false);
            WorkflowValue.Validate(createdAtTo, nameof(createdAtTo), required: false);
            WorkflowValue.Validate(confirmedAtFrom, nameof(confirmedAtFrom), required: false);
            WorkflowValue.Validate(confirmAtTo, nameof(confirmAtTo), required: false);
            WorkflowValue.Validate(labelGeneratedAtFrom, nameof(labelGeneratedAtFrom), required: false);
            WorkflowValue.Validate(labelGeneratedAtTo, nameof(labelGeneratedAtTo), required: false);
            WorkflowValue.Validate(shipmentState, nameof(shipmentState), required: false);
            WorkflowValue.Validate(pickupState, nameof(pickupState), required: false);
            WorkflowValue.Validate(deliveryState, nameof(deliveryState), required: false);
            WorkflowValue.Validate(labelState, nameof(labelState), required: false);
            WorkflowValue.Validate(warehouseState, nameof(warehouseState), required: false);
            return new DeferredBodyAction<ListAllShipmentsResponse>(() =>
            {
                var apiCallPath = "/v2/shipments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (easyshipShipmentId != null)
                    callPayload.Queries["easyship_shipment_id"] = ExpressionConverter.Convert(easyshipShipmentId);
                if (platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = ExpressionConverter.Convert(platformOrderNumber);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                if (createdAtFrom != null)
                    callPayload.Queries["created_at_from"] = ExpressionConverter.Convert(createdAtFrom);
                if (createdAtTo != null)
                    callPayload.Queries["created_at_to"] = ExpressionConverter.Convert(createdAtTo);
                if (confirmedAtFrom != null)
                    callPayload.Queries["confirmed_at_from"] = ExpressionConverter.Convert(confirmedAtFrom);
                if (confirmAtTo != null)
                    callPayload.Queries["confirm_at_to"] = ExpressionConverter.Convert(confirmAtTo);
                if (labelGeneratedAtFrom != null)
                    callPayload.Queries["label_generated_at_from"] = ExpressionConverter.Convert(labelGeneratedAtFrom);
                if (labelGeneratedAtTo != null)
                    callPayload.Queries["label_generated_at_to"] = ExpressionConverter.Convert(labelGeneratedAtTo);
                if (shipmentState != null)
                    callPayload.Queries["shipment_state"] = ExpressionConverter.Convert(shipmentState);
                if (pickupState != null)
                    callPayload.Queries["pickup_state"] = ExpressionConverter.Convert(pickupState);
                if (deliveryState != null)
                    callPayload.Queries["delivery_state"] = ExpressionConverter.Convert(deliveryState);
                if (labelState != null)
                    callPayload.Queries["label_state"] = ExpressionConverter.Convert(labelState);
                if (warehouseState != null)
                    callPayload.Queries["warehouse_state"] = ExpressionConverter.Convert(warehouseState);
                return new ApiConnectionAction<ListAllShipmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAShipment))]
        public IBodyWorkflowAction<CreateAShipmentResponse> CreateAShipment([WorkflowExpression] Func<string> bodyoriginAddressline1 = null, [WorkflowExpression] Func<string> bodyoriginAddressline2 = null, [WorkflowExpression] Func<string> bodyoriginAddressstate = null, [WorkflowExpression] Func<string> bodyoriginAddresscity = null, [WorkflowExpression] Func<string> bodyoriginAddresspostalCode = null, [WorkflowExpression] Func<string> bodyoriginAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodyoriginAddresscontactName = null, [WorkflowExpression] Func<string> bodyoriginAddresscompanyName = null, [WorkflowExpression] Func<string> bodyoriginAddresscontactPhone = null, [WorkflowExpression] Func<string> bodyoriginAddresscontactEmail = null, [WorkflowExpression] Func<string> bodysenderAddressline1 = null, [WorkflowExpression] Func<string> bodysenderAddressline2 = null, [WorkflowExpression] Func<string> bodysenderAddressstate = null, [WorkflowExpression] Func<string> bodysenderAddresscity = null, [WorkflowExpression] Func<string> bodysenderAddresspostalCode = null, [WorkflowExpression] Func<string> bodysenderAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodysenderAddresscontactName = null, [WorkflowExpression] Func<string> bodysenderAddresscompanyName = null, [WorkflowExpression] Func<string> bodysenderAddresscontactPhone = null, [WorkflowExpression] Func<string> bodysenderAddresscontactEmail = null, [WorkflowExpression] Func<string> bodyreturnAddressline1 = null, [WorkflowExpression] Func<string> bodyreturnAddressline2 = null, [WorkflowExpression] Func<string> bodyreturnAddressstate = null, [WorkflowExpression] Func<string> bodyreturnAddresscity = null, [WorkflowExpression] Func<string> bodyreturnAddresspostalCode = null, [WorkflowExpression] Func<string> bodyreturnAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodyreturnAddresscontactName = null, [WorkflowExpression] Func<string> bodyreturnAddresscompanyName = null, [WorkflowExpression] Func<string> bodyreturnAddresscontactPhone = null, [WorkflowExpression] Func<string> bodyreturnAddresscontactEmail = null, [WorkflowExpression] Func<string> bodydestinationAddressline1 = null, [WorkflowExpression] Func<string> bodydestinationAddressline2 = null, [WorkflowExpression] Func<string> bodydestinationAddressstate = null, [WorkflowExpression] Func<string> bodydestinationAddresscity = null, [WorkflowExpression] Func<string> bodydestinationAddresspostalCode = null, [WorkflowExpression] Func<string> bodydestinationAddresscountryAlpha2 = null, [WorkflowExpression] Func<string> bodydestinationAddresscontactName = null, [WorkflowExpression] Func<string> bodydestinationAddresscompanyName = null, [WorkflowExpression] Func<string> bodydestinationAddresscontactPhone = null, [WorkflowExpression] Func<string> bodydestinationAddresscontactEmail = null, [WorkflowExpression] Func<bool> bodysetAsResidential = null, [WorkflowExpression] Func<string> bodyconsigneeTaxId = null, [WorkflowExpression] Func<string> bodyeeiReference = null, [WorkflowExpression] Func<string> bodyincoterms = null, [WorkflowExpression] Func<bool> bodyinsuranceisInsured = null, [WorkflowExpression] Func<int> bodyinsuranceinsuredAmount = null, [WorkflowExpression] Func<string> bodyinsuranceinsuredCurrency = null, [WorkflowExpression] Func<string> bodyorderDataplatformName = null, [WorkflowExpression] Func<string> bodyorderDataplatformOrderNumber = null, [WorkflowExpression] Func<string[]> bodyorderDataorderTagList = null, [WorkflowExpression] Func<string> bodyorderDatasellerNotes = null, [WorkflowExpression] Func<string> bodyorderDatabuyerNotes = null, [WorkflowExpression] Func<string> bodycourierSelectionselectedCourierId = null, [WorkflowExpression] Func<bool> bodycourierSelectionallowCourierFallback = null, [WorkflowExpression] Func<bool> bodycourierSelectionapplyShippingRules = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsweight = null, [WorkflowExpression] Func<string> bodyshippingSettingsunitsdimensions = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionsformat = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionslabel = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionscommercialInvoice = null, [WorkflowExpression] Func<string> bodyshippingSettingsprintingOptionspackingSlip = null, [WorkflowExpression] Func<bool> bodyshippingSettingsbuyLabel = null, [WorkflowExpression] Func<bool> bodyshippingSettingsbuyLabelSynchronous = null, [WorkflowExpression] Func<bodyparcelsInputItem[]> bodyparcels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAShipmentResponse> __BuildCreateAShipment(WorkflowValue<string> bodyoriginAddressline1 = null, WorkflowValue<string> bodyoriginAddressline2 = null, WorkflowValue<string> bodyoriginAddressstate = null, WorkflowValue<string> bodyoriginAddresscity = null, WorkflowValue<string> bodyoriginAddresspostalCode = null, WorkflowValue<string> bodyoriginAddresscountryAlpha2 = null, WorkflowValue<string> bodyoriginAddresscontactName = null, WorkflowValue<string> bodyoriginAddresscompanyName = null, WorkflowValue<string> bodyoriginAddresscontactPhone = null, WorkflowValue<string> bodyoriginAddresscontactEmail = null, WorkflowValue<string> bodysenderAddressline1 = null, WorkflowValue<string> bodysenderAddressline2 = null, WorkflowValue<string> bodysenderAddressstate = null, WorkflowValue<string> bodysenderAddresscity = null, WorkflowValue<string> bodysenderAddresspostalCode = null, WorkflowValue<string> bodysenderAddresscountryAlpha2 = null, WorkflowValue<string> bodysenderAddresscontactName = null, WorkflowValue<string> bodysenderAddresscompanyName = null, WorkflowValue<string> bodysenderAddresscontactPhone = null, WorkflowValue<string> bodysenderAddresscontactEmail = null, WorkflowValue<string> bodyreturnAddressline1 = null, WorkflowValue<string> bodyreturnAddressline2 = null, WorkflowValue<string> bodyreturnAddressstate = null, WorkflowValue<string> bodyreturnAddresscity = null, WorkflowValue<string> bodyreturnAddresspostalCode = null, WorkflowValue<string> bodyreturnAddresscountryAlpha2 = null, WorkflowValue<string> bodyreturnAddresscontactName = null, WorkflowValue<string> bodyreturnAddresscompanyName = null, WorkflowValue<string> bodyreturnAddresscontactPhone = null, WorkflowValue<string> bodyreturnAddresscontactEmail = null, WorkflowValue<string> bodydestinationAddressline1 = null, WorkflowValue<string> bodydestinationAddressline2 = null, WorkflowValue<string> bodydestinationAddressstate = null, WorkflowValue<string> bodydestinationAddresscity = null, WorkflowValue<string> bodydestinationAddresspostalCode = null, WorkflowValue<string> bodydestinationAddresscountryAlpha2 = null, WorkflowValue<string> bodydestinationAddresscontactName = null, WorkflowValue<string> bodydestinationAddresscompanyName = null, WorkflowValue<string> bodydestinationAddresscontactPhone = null, WorkflowValue<string> bodydestinationAddresscontactEmail = null, WorkflowValue<bool> bodysetAsResidential = null, WorkflowValue<string> bodyconsigneeTaxId = null, WorkflowValue<string> bodyeeiReference = null, WorkflowValue<string> bodyincoterms = null, WorkflowValue<bool> bodyinsuranceisInsured = null, WorkflowValue<int> bodyinsuranceinsuredAmount = null, WorkflowValue<string> bodyinsuranceinsuredCurrency = null, WorkflowValue<string> bodyorderDataplatformName = null, WorkflowValue<string> bodyorderDataplatformOrderNumber = null, WorkflowValue<string[]> bodyorderDataorderTagList = null, WorkflowValue<string> bodyorderDatasellerNotes = null, WorkflowValue<string> bodyorderDatabuyerNotes = null, WorkflowValue<string> bodycourierSelectionselectedCourierId = null, WorkflowValue<bool> bodycourierSelectionallowCourierFallback = null, WorkflowValue<bool> bodycourierSelectionapplyShippingRules = null, WorkflowValue<string> bodyshippingSettingsunitsweight = null, WorkflowValue<string> bodyshippingSettingsunitsdimensions = null, WorkflowValue<string> bodyshippingSettingsprintingOptionsformat = null, WorkflowValue<string> bodyshippingSettingsprintingOptionslabel = null, WorkflowValue<string> bodyshippingSettingsprintingOptionscommercialInvoice = null, WorkflowValue<string> bodyshippingSettingsprintingOptionspackingSlip = null, WorkflowValue<bool> bodyshippingSettingsbuyLabel = null, WorkflowValue<bool> bodyshippingSettingsbuyLabelSynchronous = null, WorkflowValue<bodyparcelsInputItem[]> bodyparcels = null)
        {
            WorkflowValue.Validate(bodyoriginAddressline1, nameof(bodyoriginAddressline1), required: false);
            WorkflowValue.Validate(bodyoriginAddressline2, nameof(bodyoriginAddressline2), required: false);
            WorkflowValue.Validate(bodyoriginAddressstate, nameof(bodyoriginAddressstate), required: false);
            WorkflowValue.Validate(bodyoriginAddresscity, nameof(bodyoriginAddresscity), required: false);
            WorkflowValue.Validate(bodyoriginAddresspostalCode, nameof(bodyoriginAddresspostalCode), required: false);
            WorkflowValue.Validate(bodyoriginAddresscountryAlpha2, nameof(bodyoriginAddresscountryAlpha2), required: false);
            WorkflowValue.Validate(bodyoriginAddresscontactName, nameof(bodyoriginAddresscontactName), required: false);
            WorkflowValue.Validate(bodyoriginAddresscompanyName, nameof(bodyoriginAddresscompanyName), required: false);
            WorkflowValue.Validate(bodyoriginAddresscontactPhone, nameof(bodyoriginAddresscontactPhone), required: false);
            WorkflowValue.Validate(bodyoriginAddresscontactEmail, nameof(bodyoriginAddresscontactEmail), required: false);
            WorkflowValue.Validate(bodysenderAddressline1, nameof(bodysenderAddressline1), required: false);
            WorkflowValue.Validate(bodysenderAddressline2, nameof(bodysenderAddressline2), required: false);
            WorkflowValue.Validate(bodysenderAddressstate, nameof(bodysenderAddressstate), required: false);
            WorkflowValue.Validate(bodysenderAddresscity, nameof(bodysenderAddresscity), required: false);
            WorkflowValue.Validate(bodysenderAddresspostalCode, nameof(bodysenderAddresspostalCode), required: false);
            WorkflowValue.Validate(bodysenderAddresscountryAlpha2, nameof(bodysenderAddresscountryAlpha2), required: false);
            WorkflowValue.Validate(bodysenderAddresscontactName, nameof(bodysenderAddresscontactName), required: false);
            WorkflowValue.Validate(bodysenderAddresscompanyName, nameof(bodysenderAddresscompanyName), required: false);
            WorkflowValue.Validate(bodysenderAddresscontactPhone, nameof(bodysenderAddresscontactPhone), required: false);
            WorkflowValue.Validate(bodysenderAddresscontactEmail, nameof(bodysenderAddresscontactEmail), required: false);
            WorkflowValue.Validate(bodyreturnAddressline1, nameof(bodyreturnAddressline1), required: false);
            WorkflowValue.Validate(bodyreturnAddressline2, nameof(bodyreturnAddressline2), required: false);
            WorkflowValue.Validate(bodyreturnAddressstate, nameof(bodyreturnAddressstate), required: false);
            WorkflowValue.Validate(bodyreturnAddresscity, nameof(bodyreturnAddresscity), required: false);
            WorkflowValue.Validate(bodyreturnAddresspostalCode, nameof(bodyreturnAddresspostalCode), required: false);
            WorkflowValue.Validate(bodyreturnAddresscountryAlpha2, nameof(bodyreturnAddresscountryAlpha2), required: false);
            WorkflowValue.Validate(bodyreturnAddresscontactName, nameof(bodyreturnAddresscontactName), required: false);
            WorkflowValue.Validate(bodyreturnAddresscompanyName, nameof(bodyreturnAddresscompanyName), required: false);
            WorkflowValue.Validate(bodyreturnAddresscontactPhone, nameof(bodyreturnAddresscontactPhone), required: false);
            WorkflowValue.Validate(bodyreturnAddresscontactEmail, nameof(bodyreturnAddresscontactEmail), required: false);
            WorkflowValue.Validate(bodydestinationAddressline1, nameof(bodydestinationAddressline1), required: false);
            WorkflowValue.Validate(bodydestinationAddressline2, nameof(bodydestinationAddressline2), required: false);
            WorkflowValue.Validate(bodydestinationAddressstate, nameof(bodydestinationAddressstate), required: false);
            WorkflowValue.Validate(bodydestinationAddresscity, nameof(bodydestinationAddresscity), required: false);
            WorkflowValue.Validate(bodydestinationAddresspostalCode, nameof(bodydestinationAddresspostalCode), required: false);
            WorkflowValue.Validate(bodydestinationAddresscountryAlpha2, nameof(bodydestinationAddresscountryAlpha2), required: false);
            WorkflowValue.Validate(bodydestinationAddresscontactName, nameof(bodydestinationAddresscontactName), required: false);
            WorkflowValue.Validate(bodydestinationAddresscompanyName, nameof(bodydestinationAddresscompanyName), required: false);
            WorkflowValue.Validate(bodydestinationAddresscontactPhone, nameof(bodydestinationAddresscontactPhone), required: false);
            WorkflowValue.Validate(bodydestinationAddresscontactEmail, nameof(bodydestinationAddresscontactEmail), required: false);
            WorkflowValue.Validate(bodysetAsResidential, nameof(bodysetAsResidential), required: false);
            WorkflowValue.Validate(bodyconsigneeTaxId, nameof(bodyconsigneeTaxId), required: false);
            WorkflowValue.Validate(bodyeeiReference, nameof(bodyeeiReference), required: false);
            WorkflowValue.Validate(bodyincoterms, nameof(bodyincoterms), required: false);
            WorkflowValue.Validate(bodyinsuranceisInsured, nameof(bodyinsuranceisInsured), required: false);
            WorkflowValue.Validate(bodyinsuranceinsuredAmount, nameof(bodyinsuranceinsuredAmount), required: false);
            WorkflowValue.Validate(bodyinsuranceinsuredCurrency, nameof(bodyinsuranceinsuredCurrency), required: false);
            WorkflowValue.Validate(bodyorderDataplatformName, nameof(bodyorderDataplatformName), required: false);
            WorkflowValue.Validate(bodyorderDataplatformOrderNumber, nameof(bodyorderDataplatformOrderNumber), required: false);
            WorkflowValue.Validate(bodyorderDataorderTagList, nameof(bodyorderDataorderTagList), required: false);
            WorkflowValue.Validate(bodyorderDatasellerNotes, nameof(bodyorderDatasellerNotes), required: false);
            WorkflowValue.Validate(bodyorderDatabuyerNotes, nameof(bodyorderDatabuyerNotes), required: false);
            WorkflowValue.Validate(bodycourierSelectionselectedCourierId, nameof(bodycourierSelectionselectedCourierId), required: false);
            WorkflowValue.Validate(bodycourierSelectionallowCourierFallback, nameof(bodycourierSelectionallowCourierFallback), required: false);
            WorkflowValue.Validate(bodycourierSelectionapplyShippingRules, nameof(bodycourierSelectionapplyShippingRules), required: false);
            WorkflowValue.Validate(bodyshippingSettingsunitsweight, nameof(bodyshippingSettingsunitsweight), required: false);
            WorkflowValue.Validate(bodyshippingSettingsunitsdimensions, nameof(bodyshippingSettingsunitsdimensions), required: false);
            WorkflowValue.Validate(bodyshippingSettingsprintingOptionsformat, nameof(bodyshippingSettingsprintingOptionsformat), required: false);
            WorkflowValue.Validate(bodyshippingSettingsprintingOptionslabel, nameof(bodyshippingSettingsprintingOptionslabel), required: false);
            WorkflowValue.Validate(bodyshippingSettingsprintingOptionscommercialInvoice, nameof(bodyshippingSettingsprintingOptionscommercialInvoice), required: false);
            WorkflowValue.Validate(bodyshippingSettingsprintingOptionspackingSlip, nameof(bodyshippingSettingsprintingOptionspackingSlip), required: false);
            WorkflowValue.Validate(bodyshippingSettingsbuyLabel, nameof(bodyshippingSettingsbuyLabel), required: false);
            WorkflowValue.Validate(bodyshippingSettingsbuyLabelSynchronous, nameof(bodyshippingSettingsbuyLabelSynchronous), required: false);
            WorkflowValue.Validate(bodyparcels, nameof(bodyparcels), required: false);
            return new DeferredBodyAction<CreateAShipmentResponse>(() =>
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
                    originAddressObject["line_1"] = ExpressionConverter.ConvertO(bodyoriginAddressline1);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressline2 != null)
                {
                    originAddressObject["line_2"] = ExpressionConverter.ConvertO(bodyoriginAddressline2);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddressstate != null)
                {
                    originAddressObject["state"] = ExpressionConverter.ConvertO(bodyoriginAddressstate);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscity != null)
                {
                    originAddressObject["city"] = ExpressionConverter.ConvertO(bodyoriginAddresscity);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresspostalCode != null)
                {
                    originAddressObject["postal_code"] = ExpressionConverter.ConvertO(bodyoriginAddresspostalCode);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscountryAlpha2 != null)
                {
                    originAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(bodyoriginAddresscountryAlpha2);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscontactName != null)
                {
                    originAddressObject["contact_name"] = ExpressionConverter.ConvertO(bodyoriginAddresscontactName);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscompanyName != null)
                {
                    originAddressObject["company_name"] = ExpressionConverter.ConvertO(bodyoriginAddresscompanyName);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscontactPhone != null)
                {
                    originAddressObject["contact_phone"] = ExpressionConverter.ConvertO(bodyoriginAddresscontactPhone);
                    originAddressObjectpropCount++;
                }

                if (bodyoriginAddresscontactEmail != null)
                {
                    originAddressObject["contact_email"] = ExpressionConverter.ConvertO(bodyoriginAddresscontactEmail);
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
                    senderAddressObject["line_1"] = ExpressionConverter.ConvertO(bodysenderAddressline1);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddressline2 != null)
                {
                    senderAddressObject["line_2"] = ExpressionConverter.ConvertO(bodysenderAddressline2);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddressstate != null)
                {
                    senderAddressObject["state"] = ExpressionConverter.ConvertO(bodysenderAddressstate);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscity != null)
                {
                    senderAddressObject["city"] = ExpressionConverter.ConvertO(bodysenderAddresscity);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresspostalCode != null)
                {
                    senderAddressObject["postal_code"] = ExpressionConverter.ConvertO(bodysenderAddresspostalCode);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscountryAlpha2 != null)
                {
                    senderAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(bodysenderAddresscountryAlpha2);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscontactName != null)
                {
                    senderAddressObject["contact_name"] = ExpressionConverter.ConvertO(bodysenderAddresscontactName);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscompanyName != null)
                {
                    senderAddressObject["company_name"] = ExpressionConverter.ConvertO(bodysenderAddresscompanyName);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscontactPhone != null)
                {
                    senderAddressObject["contact_phone"] = ExpressionConverter.ConvertO(bodysenderAddresscontactPhone);
                    senderAddressObjectpropCount++;
                }

                if (bodysenderAddresscontactEmail != null)
                {
                    senderAddressObject["contact_email"] = ExpressionConverter.ConvertO(bodysenderAddresscontactEmail);
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
                    returnAddressObject["line_1"] = ExpressionConverter.ConvertO(bodyreturnAddressline1);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddressline2 != null)
                {
                    returnAddressObject["line_2"] = ExpressionConverter.ConvertO(bodyreturnAddressline2);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddressstate != null)
                {
                    returnAddressObject["state"] = ExpressionConverter.ConvertO(bodyreturnAddressstate);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscity != null)
                {
                    returnAddressObject["city"] = ExpressionConverter.ConvertO(bodyreturnAddresscity);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresspostalCode != null)
                {
                    returnAddressObject["postal_code"] = ExpressionConverter.ConvertO(bodyreturnAddresspostalCode);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscountryAlpha2 != null)
                {
                    returnAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(bodyreturnAddresscountryAlpha2);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscontactName != null)
                {
                    returnAddressObject["contact_name"] = ExpressionConverter.ConvertO(bodyreturnAddresscontactName);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscompanyName != null)
                {
                    returnAddressObject["company_name"] = ExpressionConverter.ConvertO(bodyreturnAddresscompanyName);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscontactPhone != null)
                {
                    returnAddressObject["contact_phone"] = ExpressionConverter.ConvertO(bodyreturnAddresscontactPhone);
                    returnAddressObjectpropCount++;
                }

                if (bodyreturnAddresscontactEmail != null)
                {
                    returnAddressObject["contact_email"] = ExpressionConverter.ConvertO(bodyreturnAddresscontactEmail);
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
                    destinationAddressObject["line_1"] = ExpressionConverter.ConvertO(bodydestinationAddressline1);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressline2 != null)
                {
                    destinationAddressObject["line_2"] = ExpressionConverter.ConvertO(bodydestinationAddressline2);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddressstate != null)
                {
                    destinationAddressObject["state"] = ExpressionConverter.ConvertO(bodydestinationAddressstate);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscity != null)
                {
                    destinationAddressObject["city"] = ExpressionConverter.ConvertO(bodydestinationAddresscity);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresspostalCode != null)
                {
                    destinationAddressObject["postal_code"] = ExpressionConverter.ConvertO(bodydestinationAddresspostalCode);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscountryAlpha2 != null)
                {
                    destinationAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(bodydestinationAddresscountryAlpha2);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscontactName != null)
                {
                    destinationAddressObject["contact_name"] = ExpressionConverter.ConvertO(bodydestinationAddresscontactName);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscompanyName != null)
                {
                    destinationAddressObject["company_name"] = ExpressionConverter.ConvertO(bodydestinationAddresscompanyName);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscontactPhone != null)
                {
                    destinationAddressObject["contact_phone"] = ExpressionConverter.ConvertO(bodydestinationAddresscontactPhone);
                    destinationAddressObjectpropCount++;
                }

                if (bodydestinationAddresscontactEmail != null)
                {
                    destinationAddressObject["contact_email"] = ExpressionConverter.ConvertO(bodydestinationAddresscontactEmail);
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
                    body["set_as_residential"] = ExpressionConverter.ConvertO(bodysetAsResidential);
                    bodypropCount++;
                }

                if (bodyconsigneeTaxId != null)
                {
                    body["consignee_tax_id"] = ExpressionConverter.ConvertO(bodyconsigneeTaxId);
                    bodypropCount++;
                }

                if (bodyeeiReference != null)
                {
                    body["eei_reference"] = ExpressionConverter.ConvertO(bodyeeiReference);
                    bodypropCount++;
                }

                if (bodyincoterms != null)
                {
                    body["incoterms"] = ExpressionConverter.ConvertO(bodyincoterms);
                    bodypropCount++;
                }

                var insuranceObject = new JObject();
                var insuranceObjectpropCount = 0;
                if (bodyinsuranceisInsured != null)
                {
                    insuranceObject["is_insured"] = ExpressionConverter.ConvertO(bodyinsuranceisInsured);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredAmount != null)
                {
                    insuranceObject["insured_amount"] = ExpressionConverter.ConvertO(bodyinsuranceinsuredAmount);
                    insuranceObjectpropCount++;
                }

                if (bodyinsuranceinsuredCurrency != null)
                {
                    insuranceObject["insured_currency"] = ExpressionConverter.ConvertO(bodyinsuranceinsuredCurrency);
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
                    orderDataObject["platform_name"] = ExpressionConverter.ConvertO(bodyorderDataplatformName);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDataplatformOrderNumber != null)
                {
                    orderDataObject["platform_order_number"] = ExpressionConverter.ConvertO(bodyorderDataplatformOrderNumber);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDataorderTagList != null)
                {
                    orderDataObject["order_tag_list"] = ExpressionConverter.ConvertO(bodyorderDataorderTagList);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDatasellerNotes != null)
                {
                    orderDataObject["seller_notes"] = ExpressionConverter.ConvertO(bodyorderDatasellerNotes);
                    orderDataObjectpropCount++;
                }

                if (bodyorderDatabuyerNotes != null)
                {
                    orderDataObject["buyer_notes"] = ExpressionConverter.ConvertO(bodyorderDatabuyerNotes);
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
                    courierSelectionObject["selected_courier_id"] = ExpressionConverter.ConvertO(bodycourierSelectionselectedCourierId);
                    courierSelectionObjectpropCount++;
                }

                if (bodycourierSelectionallowCourierFallback != null)
                {
                    courierSelectionObject["allow_courier_fallback"] = ExpressionConverter.ConvertO(bodycourierSelectionallowCourierFallback);
                    courierSelectionObjectpropCount++;
                }

                if (bodycourierSelectionapplyShippingRules != null)
                {
                    courierSelectionObject["apply_shipping_rules"] = ExpressionConverter.ConvertO(bodycourierSelectionapplyShippingRules);
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
                    unitsObject["weight"] = ExpressionConverter.ConvertO(bodyshippingSettingsunitsweight);
                    unitsObjectpropCount++;
                }

                if (bodyshippingSettingsunitsdimensions != null)
                {
                    unitsObject["dimensions"] = ExpressionConverter.ConvertO(bodyshippingSettingsunitsdimensions);
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
                    printingOptionsObject["format"] = ExpressionConverter.ConvertO(bodyshippingSettingsprintingOptionsformat);
                    printingOptionsObjectpropCount++;
                }

                if (bodyshippingSettingsprintingOptionslabel != null)
                {
                    printingOptionsObject["label"] = ExpressionConverter.ConvertO(bodyshippingSettingsprintingOptionslabel);
                    printingOptionsObjectpropCount++;
                }

                if (bodyshippingSettingsprintingOptionscommercialInvoice != null)
                {
                    printingOptionsObject["commercial_invoice"] = ExpressionConverter.ConvertO(bodyshippingSettingsprintingOptionscommercialInvoice);
                    printingOptionsObjectpropCount++;
                }

                if (bodyshippingSettingsprintingOptionspackingSlip != null)
                {
                    printingOptionsObject["packing_slip"] = ExpressionConverter.ConvertO(bodyshippingSettingsprintingOptionspackingSlip);
                    printingOptionsObjectpropCount++;
                }

                if (printingOptionsObjectpropCount > 0)
                {
                    shippingSettingsObject["printing_options"] = printingOptionsObject;
                    shippingSettingsObjectpropCount++;
                }

                if (bodyshippingSettingsbuyLabel != null)
                {
                    shippingSettingsObject["buy_label"] = ExpressionConverter.ConvertO(bodyshippingSettingsbuyLabel);
                    shippingSettingsObjectpropCount++;
                }

                if (bodyshippingSettingsbuyLabelSynchronous != null)
                {
                    shippingSettingsObject["buy_label_synchronous"] = ExpressionConverter.ConvertO(bodyshippingSettingsbuyLabelSynchronous);
                    shippingSettingsObjectpropCount++;
                }

                if (shippingSettingsObjectpropCount > 0)
                {
                    body["shipping_settings"] = shippingSettingsObject;
                    bodypropCount++;
                }

                if (bodyparcels != null)
                {
                    body["parcels"] = ExpressionConverter.ConvertO(bodyparcels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildBuyAShipmentLabel))]
        public IBodyWorkflowAction<BuyAShipmentLabelResponse> BuyAShipmentLabel([WorkflowExpression] Func<bodyshipmentsInputItem[]> bodyshipments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BuyAShipmentLabelResponse> __BuildBuyAShipmentLabel(WorkflowValue<bodyshipmentsInputItem[]> bodyshipments = null)
        {
            WorkflowValue.Validate(bodyshipments, nameof(bodyshipments), required: false);
            return new DeferredBodyAction<BuyAShipmentLabelResponse>(() =>
            {
                var apiCallPath = "/label/v1/labels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshipments != null)
                {
                    body["shipments"] = ExpressionConverter.ConvertO(bodyshipments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BuyAShipmentLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAShipment))]
        public IBodyWorkflowAction<DeleteAShipmentResponse> DeleteAShipment([WorkflowExpression] Func<string> easyshipShipmentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteAShipmentResponse> __BuildDeleteAShipment(WorkflowValue<string> easyshipShipmentId)
        {
            WorkflowValue.Validate(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            return new DeferredBodyAction<DeleteAShipmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(easyshipShipmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAShipment))]
        public IBodyWorkflowAction<UpdateAShipmentResponse> UpdateAShipment([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> bodydestinationCountryAlpha2 = null, [WorkflowExpression] Func<string> bodydestinationCity = null, [WorkflowExpression] Func<string> bodydestinationName = null, [WorkflowExpression] Func<string> bodydestinationAddressLine1 = null, [WorkflowExpression] Func<string> bodydestinationPhoneNumber = null, [WorkflowExpression] Func<bodyitemsInputItem[]> bodyitems = null, [WorkflowExpression] Func<string> bodyplatformName = null, [WorkflowExpression] Func<string> bodyplatformOrderNumber = null, [WorkflowExpression] Func<string> bodytaxesDutiesPaidBy = null, [WorkflowExpression] Func<bool> bodyisInsured = null, [WorkflowExpression] Func<string> bodyselectedCourierId = null, [WorkflowExpression] Func<int> bodydestinationPostalCode = null, [WorkflowExpression] Func<string> bodydestinationState = null, [WorkflowExpression] Func<string> bodydestinationAddressLine2 = null, [WorkflowExpression] Func<string> bodydestinationEmailAddress = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAShipmentResponse> __BuildUpdateAShipment(WorkflowValue<string> easyshipShipmentId, WorkflowValue<string> bodydestinationCountryAlpha2 = null, WorkflowValue<string> bodydestinationCity = null, WorkflowValue<string> bodydestinationName = null, WorkflowValue<string> bodydestinationAddressLine1 = null, WorkflowValue<string> bodydestinationPhoneNumber = null, WorkflowValue<bodyitemsInputItem[]> bodyitems = null, WorkflowValue<string> bodyplatformName = null, WorkflowValue<string> bodyplatformOrderNumber = null, WorkflowValue<string> bodytaxesDutiesPaidBy = null, WorkflowValue<bool> bodyisInsured = null, WorkflowValue<string> bodyselectedCourierId = null, WorkflowValue<int> bodydestinationPostalCode = null, WorkflowValue<string> bodydestinationState = null, WorkflowValue<string> bodydestinationAddressLine2 = null, WorkflowValue<string> bodydestinationEmailAddress = null)
        {
            WorkflowValue.Validate(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            WorkflowValue.Validate(bodydestinationCountryAlpha2, nameof(bodydestinationCountryAlpha2), required: false);
            WorkflowValue.Validate(bodydestinationCity, nameof(bodydestinationCity), required: false);
            WorkflowValue.Validate(bodydestinationName, nameof(bodydestinationName), required: false);
            WorkflowValue.Validate(bodydestinationAddressLine1, nameof(bodydestinationAddressLine1), required: false);
            WorkflowValue.Validate(bodydestinationPhoneNumber, nameof(bodydestinationPhoneNumber), required: false);
            WorkflowValue.Validate(bodyitems, nameof(bodyitems), required: false);
            WorkflowValue.Validate(bodyplatformName, nameof(bodyplatformName), required: false);
            WorkflowValue.Validate(bodyplatformOrderNumber, nameof(bodyplatformOrderNumber), required: false);
            WorkflowValue.Validate(bodytaxesDutiesPaidBy, nameof(bodytaxesDutiesPaidBy), required: false);
            WorkflowValue.Validate(bodyisInsured, nameof(bodyisInsured), required: false);
            WorkflowValue.Validate(bodyselectedCourierId, nameof(bodyselectedCourierId), required: false);
            WorkflowValue.Validate(bodydestinationPostalCode, nameof(bodydestinationPostalCode), required: false);
            WorkflowValue.Validate(bodydestinationState, nameof(bodydestinationState), required: false);
            WorkflowValue.Validate(bodydestinationAddressLine2, nameof(bodydestinationAddressLine2), required: false);
            WorkflowValue.Validate(bodydestinationEmailAddress, nameof(bodydestinationEmailAddress), required: false);
            return new DeferredBodyAction<UpdateAShipmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(easyshipShipmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestinationCountryAlpha2 != null)
                {
                    body["destination_country_alpha2"] = ExpressionConverter.ConvertO(bodydestinationCountryAlpha2);
                    bodypropCount++;
                }

                if (bodydestinationCity != null)
                {
                    body["destination_city"] = ExpressionConverter.ConvertO(bodydestinationCity);
                    bodypropCount++;
                }

                if (bodydestinationName != null)
                {
                    body["destination_name"] = ExpressionConverter.ConvertO(bodydestinationName);
                    bodypropCount++;
                }

                if (bodydestinationAddressLine1 != null)
                {
                    body["destination_address_line_1"] = ExpressionConverter.ConvertO(bodydestinationAddressLine1);
                    bodypropCount++;
                }

                if (bodydestinationPhoneNumber != null)
                {
                    body["destination_phone_number"] = ExpressionConverter.ConvertO(bodydestinationPhoneNumber);
                    bodypropCount++;
                }

                if (bodyitems != null)
                {
                    body["items"] = ExpressionConverter.ConvertO(bodyitems);
                    bodypropCount++;
                }

                if (bodyplatformName != null)
                {
                    body["platform_name"] = ExpressionConverter.ConvertO(bodyplatformName);
                    bodypropCount++;
                }

                if (bodyplatformOrderNumber != null)
                {
                    body["platform_order_number"] = ExpressionConverter.ConvertO(bodyplatformOrderNumber);
                    bodypropCount++;
                }

                if (bodytaxesDutiesPaidBy != null)
                {
                    body["taxes_duties_paid_by"] = ExpressionConverter.ConvertO(bodytaxesDutiesPaidBy);
                    bodypropCount++;
                }

                if (bodyisInsured != null)
                {
                    body["is_insured"] = ExpressionConverter.ConvertO(bodyisInsured);
                    bodypropCount++;
                }

                if (bodyselectedCourierId != null)
                {
                    body["selected_courier_id"] = ExpressionConverter.ConvertO(bodyselectedCourierId);
                    bodypropCount++;
                }

                if (bodydestinationPostalCode != null)
                {
                    body["destination_postal_code"] = ExpressionConverter.ConvertO(bodydestinationPostalCode);
                    bodypropCount++;
                }

                if (bodydestinationState != null)
                {
                    body["destination_state"] = ExpressionConverter.ConvertO(bodydestinationState);
                    bodypropCount++;
                }

                if (bodydestinationAddressLine2 != null)
                {
                    body["destination_address_line_2"] = ExpressionConverter.ConvertO(bodydestinationAddressLine2);
                    bodypropCount++;
                }

                if (bodydestinationEmailAddress != null)
                {
                    body["destination_email_address"] = ExpressionConverter.ConvertO(bodydestinationEmailAddress);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetAShipment))]
        public IBodyWorkflowAction<GetAShipmentResponse> GetAShipment([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> format = null, [WorkflowExpression] Func<string> label = null, [WorkflowExpression] Func<string> commercialInvoice = null, [WorkflowExpression] Func<string> packingSlip = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAShipmentResponse> __BuildGetAShipment(WorkflowValue<string> easyshipShipmentId, WorkflowValue<string> format = null, WorkflowValue<string> label = null, WorkflowValue<string> commercialInvoice = null, WorkflowValue<string> packingSlip = null)
        {
            WorkflowValue.Validate(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(label, nameof(label), required: false);
            WorkflowValue.Validate(commercialInvoice, nameof(commercialInvoice), required: false);
            WorkflowValue.Validate(packingSlip, nameof(packingSlip), required: false);
            return new DeferredBodyAction<GetAShipmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(easyshipShipmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (label != null)
                    callPayload.Queries["label"] = ExpressionConverter.Convert(label);
                if (commercialInvoice != null)
                    callPayload.Queries["commercial_invoice"] = ExpressionConverter.Convert(commercialInvoice);
                if (packingSlip != null)
                    callPayload.Queries["packing_slip"] = ExpressionConverter.Convert(packingSlip);
                return new ApiConnectionAction<GetAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWarehouseState))]
        public IBodyWorkflowAction<UpdateWarehouseStateResponse> UpdateWarehouseState([WorkflowExpression] Func<bodyshipmentsInputItem2[]> bodyshipments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateWarehouseStateResponse> __BuildUpdateWarehouseState(WorkflowValue<bodyshipmentsInputItem2[]> bodyshipments = null)
        {
            WorkflowValue.Validate(bodyshipments, nameof(bodyshipments), required: false);
            return new DeferredBodyAction<UpdateWarehouseStateResponse>(() =>
            {
                var apiCallPath = "/v2/shipments/warehouse_state";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshipments != null)
                {
                    body["shipments"] = ExpressionConverter.ConvertO(bodyshipments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateWarehouseStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetAvailablePickupSlots))]
        public IBodyWorkflowAction<GetAvailablePickupSlotsResponse> GetAvailablePickupSlots([WorkflowExpression] Func<string> courierId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAvailablePickupSlotsResponse> __BuildGetAvailablePickupSlots(WorkflowValue<string> courierId)
        {
            WorkflowValue.Validate(courierId, nameof(courierId), required: true);
            return new DeferredBodyAction<GetAvailablePickupSlotsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pickup/v1/pickup_slots/{0}", ExpressionConverter.ConvertWithUrlEncoding(courierId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAvailablePickupSlotsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildRequestAPickup))]
        public IBodyWorkflowAction<RequestAPickupResponse> RequestAPickup([WorkflowExpression] Func<string> bodycourierId = null, [WorkflowExpression] Func<string> bodypreferredDate = null, [WorkflowExpression] Func<string> bodypreferredMaxTime = null, [WorkflowExpression] Func<string> bodypreferredMinTime = null, [WorkflowExpression] Func<string[]> bodyeasyshipShipmentIds = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RequestAPickupResponse> __BuildRequestAPickup(WorkflowValue<string> bodycourierId = null, WorkflowValue<string> bodypreferredDate = null, WorkflowValue<string> bodypreferredMaxTime = null, WorkflowValue<string> bodypreferredMinTime = null, WorkflowValue<string[]> bodyeasyshipShipmentIds = null)
        {
            WorkflowValue.Validate(bodycourierId, nameof(bodycourierId), required: false);
            WorkflowValue.Validate(bodypreferredDate, nameof(bodypreferredDate), required: false);
            WorkflowValue.Validate(bodypreferredMaxTime, nameof(bodypreferredMaxTime), required: false);
            WorkflowValue.Validate(bodypreferredMinTime, nameof(bodypreferredMinTime), required: false);
            WorkflowValue.Validate(bodyeasyshipShipmentIds, nameof(bodyeasyshipShipmentIds), required: false);
            return new DeferredBodyAction<RequestAPickupResponse>(() =>
            {
                var apiCallPath = "/pickup/v1/pickups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycourierId != null)
                {
                    body["courier_id"] = ExpressionConverter.ConvertO(bodycourierId);
                    bodypropCount++;
                }

                if (bodypreferredDate != null)
                {
                    body["preferred_date"] = ExpressionConverter.ConvertO(bodypreferredDate);
                    bodypropCount++;
                }

                if (bodypreferredMaxTime != null)
                {
                    body["preferred_max_time"] = ExpressionConverter.ConvertO(bodypreferredMaxTime);
                    bodypropCount++;
                }

                if (bodypreferredMinTime != null)
                {
                    body["preferred_min_time"] = ExpressionConverter.ConvertO(bodypreferredMinTime);
                    bodypropCount++;
                }

                if (bodyeasyshipShipmentIds != null)
                {
                    body["easyship_shipment_ids"] = ExpressionConverter.ConvertO(bodyeasyshipShipmentIds);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RequestAPickupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCheckpoints))]
        public IBodyWorkflowAction<GetCheckpointsResponse> GetCheckpoints([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> platformOrderNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCheckpointsResponse> __BuildGetCheckpoints(WorkflowValue<string> easyshipShipmentId, WorkflowValue<string> platformOrderNumber = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            WorkflowValue.Validate(platformOrderNumber, nameof(platformOrderNumber), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetCheckpointsResponse>(() =>
            {
                var apiCallPath = "/track/v1/checkpoints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["easyship_shipment_id"] = ExpressionConverter.Convert(easyshipShipmentId);
                if (platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = ExpressionConverter.Convert(platformOrderNumber);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<GetCheckpointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatus))]
        public IBodyWorkflowAction<GetStatusResponse> GetStatus([WorkflowExpression] Func<string> easyshipShipmentId, [WorkflowExpression] Func<string> platformOrderNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStatusResponse> __BuildGetStatus(WorkflowValue<string> easyshipShipmentId, WorkflowValue<string> platformOrderNumber = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            WorkflowValue.Validate(platformOrderNumber, nameof(platformOrderNumber), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetStatusResponse>(() =>
            {
                var apiCallPath = "/track/v1/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["easyship_shipment_id"] = ExpressionConverter.Convert(easyshipShipmentId);
                if (platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = ExpressionConverter.Convert(platformOrderNumber);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<GetStatusResponse>(callPayload);
            });
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
