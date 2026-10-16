//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easyshipip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasyshipipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetRatesTaxesResponse> GetRatesTaxes(Expression<Func<string>> bodyoriginAddressline1 = null, Expression<Func<string>> bodyoriginAddressline2 = null, Expression<Func<string>> bodyoriginAddressstate = null, Expression<Func<string>> bodyoriginAddresscity = null, Expression<Func<string>> bodyoriginAddresspostalCode = null, Expression<Func<string>> bodyoriginAddresscountryAlpha2 = null, Expression<Func<string>> bodydestinationAddressline1 = null, Expression<Func<string>> bodydestinationAddressline2 = null, Expression<Func<string>> bodydestinationAddressstate = null, Expression<Func<string>> bodydestinationAddresscity = null, Expression<Func<string>> bodydestinationAddresspostalCode = null, Expression<Func<string>> bodydestinationAddresscountryAlpha2 = null, Expression<Func<string>> bodyincoterms = null, Expression<Func<bool>> bodyinsuranceisInsured = null, Expression<Func<int>> bodyinsuranceinsuredAmount = null, Expression<Func<string>> bodyinsuranceinsuredCurrency = null, Expression<Func<bool>> bodycourierSelectionapplyShippingRules = null, Expression<Func<string>> bodyshippingSettingsunitsweight = null, Expression<Func<string>> bodyshippingSettingsunitsdimensions = null, Expression<Func<string>> bodyshippingSettingsoutputCurrency = null, Expression<Func<bodyparcelsInputItem[]>> bodyparcels = null)
        {
            var __workflow_bodyoriginAddressline1 = WorkflowExpression.Compile(bodyoriginAddressline1, nameof(bodyoriginAddressline1), required: false);
            var __workflow_bodyoriginAddressline2 = WorkflowExpression.Compile(bodyoriginAddressline2, nameof(bodyoriginAddressline2), required: false);
            var __workflow_bodyoriginAddressstate = WorkflowExpression.Compile(bodyoriginAddressstate, nameof(bodyoriginAddressstate), required: false);
            var __workflow_bodyoriginAddresscity = WorkflowExpression.Compile(bodyoriginAddresscity, nameof(bodyoriginAddresscity), required: false);
            var __workflow_bodyoriginAddresspostalCode = WorkflowExpression.Compile(bodyoriginAddresspostalCode, nameof(bodyoriginAddresspostalCode), required: false);
            var __workflow_bodyoriginAddresscountryAlpha2 = WorkflowExpression.Compile(bodyoriginAddresscountryAlpha2, nameof(bodyoriginAddresscountryAlpha2), required: false);
            var __workflow_bodydestinationAddressline1 = WorkflowExpression.Compile(bodydestinationAddressline1, nameof(bodydestinationAddressline1), required: false);
            var __workflow_bodydestinationAddressline2 = WorkflowExpression.Compile(bodydestinationAddressline2, nameof(bodydestinationAddressline2), required: false);
            var __workflow_bodydestinationAddressstate = WorkflowExpression.Compile(bodydestinationAddressstate, nameof(bodydestinationAddressstate), required: false);
            var __workflow_bodydestinationAddresscity = WorkflowExpression.Compile(bodydestinationAddresscity, nameof(bodydestinationAddresscity), required: false);
            var __workflow_bodydestinationAddresspostalCode = WorkflowExpression.Compile(bodydestinationAddresspostalCode, nameof(bodydestinationAddresspostalCode), required: false);
            var __workflow_bodydestinationAddresscountryAlpha2 = WorkflowExpression.Compile(bodydestinationAddresscountryAlpha2, nameof(bodydestinationAddresscountryAlpha2), required: false);
            var __workflow_bodyincoterms = WorkflowExpression.Compile(bodyincoterms, nameof(bodyincoterms), required: false);
            var __workflow_bodyinsuranceisInsured = WorkflowExpression.Compile(bodyinsuranceisInsured, nameof(bodyinsuranceisInsured), required: false);
            var __workflow_bodyinsuranceinsuredAmount = WorkflowExpression.Compile(bodyinsuranceinsuredAmount, nameof(bodyinsuranceinsuredAmount), required: false);
            var __workflow_bodyinsuranceinsuredCurrency = WorkflowExpression.Compile(bodyinsuranceinsuredCurrency, nameof(bodyinsuranceinsuredCurrency), required: false);
            var __workflow_bodycourierSelectionapplyShippingRules = WorkflowExpression.Compile(bodycourierSelectionapplyShippingRules, nameof(bodycourierSelectionapplyShippingRules), required: false);
            var __workflow_bodyshippingSettingsunitsweight = WorkflowExpression.Compile(bodyshippingSettingsunitsweight, nameof(bodyshippingSettingsunitsweight), required: false);
            var __workflow_bodyshippingSettingsunitsdimensions = WorkflowExpression.Compile(bodyshippingSettingsunitsdimensions, nameof(bodyshippingSettingsunitsdimensions), required: false);
            var __workflow_bodyshippingSettingsoutputCurrency = WorkflowExpression.Compile(bodyshippingSettingsoutputCurrency, nameof(bodyshippingSettingsoutputCurrency), required: false);
            var __workflow_bodyparcels = WorkflowExpression.Compile(bodyparcels, nameof(bodyparcels), required: false);
            return new DeferredBodyAction<GetRatesTaxesResponse>(() =>
            {
                var apiCallPath = "/v2/rates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var originAddressObject = new JObject();
                var originAddressObjectpropCount = 0;
                if (__workflow_bodyoriginAddressline1 != null)
                {
                    originAddressObject["line_1"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddressline1);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddressline2 != null)
                {
                    originAddressObject["line_2"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddressline2);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddressstate != null)
                {
                    originAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddressstate);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscity != null)
                {
                    originAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscity);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresspostalCode != null)
                {
                    originAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresspostalCode);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscountryAlpha2 != null)
                {
                    originAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscountryAlpha2);
                    originAddressObjectpropCount++;
                }

                if (originAddressObjectpropCount > 0)
                {
                    body["origin_address"] = originAddressObject;
                    bodypropCount++;
                }

                var destinationAddressObject = new JObject();
                var destinationAddressObjectpropCount = 0;
                if (__workflow_bodydestinationAddressline1 != null)
                {
                    destinationAddressObject["line_1"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressline1);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddressline2 != null)
                {
                    destinationAddressObject["line_2"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressline2);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddressstate != null)
                {
                    destinationAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressstate);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscity != null)
                {
                    destinationAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscity);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresspostalCode != null)
                {
                    destinationAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresspostalCode);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscountryAlpha2 != null)
                {
                    destinationAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscountryAlpha2);
                    destinationAddressObjectpropCount++;
                }

                if (destinationAddressObjectpropCount > 0)
                {
                    body["destination_address"] = destinationAddressObject;
                    bodypropCount++;
                }

                if (__workflow_bodyincoterms != null)
                {
                    body["incoterms"] = ExpressionConverter.ConvertO(__workflow_bodyincoterms);
                    bodypropCount++;
                }

                var insuranceObject = new JObject();
                var insuranceObjectpropCount = 0;
                if (__workflow_bodyinsuranceisInsured != null)
                {
                    insuranceObject["is_insured"] = ExpressionConverter.ConvertO(__workflow_bodyinsuranceisInsured);
                    insuranceObjectpropCount++;
                }

                if (__workflow_bodyinsuranceinsuredAmount != null)
                {
                    insuranceObject["insured_amount"] = ExpressionConverter.ConvertO(__workflow_bodyinsuranceinsuredAmount);
                    insuranceObjectpropCount++;
                }

                if (__workflow_bodyinsuranceinsuredCurrency != null)
                {
                    insuranceObject["insured_currency"] = ExpressionConverter.ConvertO(__workflow_bodyinsuranceinsuredCurrency);
                    insuranceObjectpropCount++;
                }

                if (insuranceObjectpropCount > 0)
                {
                    body["insurance"] = insuranceObject;
                    bodypropCount++;
                }

                var courierSelectionObject = new JObject();
                var courierSelectionObjectpropCount = 0;
                if (__workflow_bodycourierSelectionapplyShippingRules != null)
                {
                    courierSelectionObject["apply_shipping_rules"] = ExpressionConverter.ConvertO(__workflow_bodycourierSelectionapplyShippingRules);
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
                if (__workflow_bodyshippingSettingsunitsweight != null)
                {
                    unitsObject["weight"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsunitsweight);
                    unitsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsunitsdimensions != null)
                {
                    unitsObject["dimensions"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsunitsdimensions);
                    unitsObjectpropCount++;
                }

                if (unitsObjectpropCount > 0)
                {
                    shippingSettingsObject["units"] = unitsObject;
                    shippingSettingsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsoutputCurrency != null)
                {
                    shippingSettingsObject["output_currency"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsoutputCurrency);
                    shippingSettingsObjectpropCount++;
                }

                if (shippingSettingsObjectpropCount > 0)
                {
                    body["shipping_settings"] = shippingSettingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyparcels != null)
                {
                    body["parcels"] = ExpressionConverter.ConvertO(__workflow_bodyparcels);
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
        public IBodyWorkflowAction<ListAllShipmentsResponse> ListAllShipments(Expression<Func<string>> easyshipShipmentId = null, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> confirmedAtFrom = null, Expression<Func<string>> confirmAtTo = null, Expression<Func<string>> labelGeneratedAtFrom = null, Expression<Func<string>> labelGeneratedAtTo = null, Expression<Func<string>> shipmentState = null, Expression<Func<string>> pickupState = null, Expression<Func<string>> deliveryState = null, Expression<Func<string>> labelState = null, Expression<Func<string>> warehouseState = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: false);
            var __workflow_platformOrderNumber = WorkflowExpression.Compile(platformOrderNumber, nameof(platformOrderNumber), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_createdAtFrom = WorkflowExpression.Compile(createdAtFrom, nameof(createdAtFrom), required: false);
            var __workflow_createdAtTo = WorkflowExpression.Compile(createdAtTo, nameof(createdAtTo), required: false);
            var __workflow_confirmedAtFrom = WorkflowExpression.Compile(confirmedAtFrom, nameof(confirmedAtFrom), required: false);
            var __workflow_confirmAtTo = WorkflowExpression.Compile(confirmAtTo, nameof(confirmAtTo), required: false);
            var __workflow_labelGeneratedAtFrom = WorkflowExpression.Compile(labelGeneratedAtFrom, nameof(labelGeneratedAtFrom), required: false);
            var __workflow_labelGeneratedAtTo = WorkflowExpression.Compile(labelGeneratedAtTo, nameof(labelGeneratedAtTo), required: false);
            var __workflow_shipmentState = WorkflowExpression.Compile(shipmentState, nameof(shipmentState), required: false);
            var __workflow_pickupState = WorkflowExpression.Compile(pickupState, nameof(pickupState), required: false);
            var __workflow_deliveryState = WorkflowExpression.Compile(deliveryState, nameof(deliveryState), required: false);
            var __workflow_labelState = WorkflowExpression.Compile(labelState, nameof(labelState), required: false);
            var __workflow_warehouseState = WorkflowExpression.Compile(warehouseState, nameof(warehouseState), required: false);
            return new DeferredBodyAction<ListAllShipmentsResponse>(() =>
            {
                var apiCallPath = "/v2/shipments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_easyshipShipmentId != null)
                    callPayload.Queries["easyship_shipment_id"] = ExpressionConverter.Convert(__workflow_easyshipShipmentId);
                if (__workflow_platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = ExpressionConverter.Convert(__workflow_platformOrderNumber);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                if (__workflow_createdAtFrom != null)
                    callPayload.Queries["created_at_from"] = ExpressionConverter.Convert(__workflow_createdAtFrom);
                if (__workflow_createdAtTo != null)
                    callPayload.Queries["created_at_to"] = ExpressionConverter.Convert(__workflow_createdAtTo);
                if (__workflow_confirmedAtFrom != null)
                    callPayload.Queries["confirmed_at_from"] = ExpressionConverter.Convert(__workflow_confirmedAtFrom);
                if (__workflow_confirmAtTo != null)
                    callPayload.Queries["confirm_at_to"] = ExpressionConverter.Convert(__workflow_confirmAtTo);
                if (__workflow_labelGeneratedAtFrom != null)
                    callPayload.Queries["label_generated_at_from"] = ExpressionConverter.Convert(__workflow_labelGeneratedAtFrom);
                if (__workflow_labelGeneratedAtTo != null)
                    callPayload.Queries["label_generated_at_to"] = ExpressionConverter.Convert(__workflow_labelGeneratedAtTo);
                if (__workflow_shipmentState != null)
                    callPayload.Queries["shipment_state"] = ExpressionConverter.Convert(__workflow_shipmentState);
                if (__workflow_pickupState != null)
                    callPayload.Queries["pickup_state"] = ExpressionConverter.Convert(__workflow_pickupState);
                if (__workflow_deliveryState != null)
                    callPayload.Queries["delivery_state"] = ExpressionConverter.Convert(__workflow_deliveryState);
                if (__workflow_labelState != null)
                    callPayload.Queries["label_state"] = ExpressionConverter.Convert(__workflow_labelState);
                if (__workflow_warehouseState != null)
                    callPayload.Queries["warehouse_state"] = ExpressionConverter.Convert(__workflow_warehouseState);
                return new ApiConnectionAction<ListAllShipmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<CreateAShipmentResponse> CreateAShipment(Expression<Func<string>> bodyoriginAddressline1 = null, Expression<Func<string>> bodyoriginAddressline2 = null, Expression<Func<string>> bodyoriginAddressstate = null, Expression<Func<string>> bodyoriginAddresscity = null, Expression<Func<string>> bodyoriginAddresspostalCode = null, Expression<Func<string>> bodyoriginAddresscountryAlpha2 = null, Expression<Func<string>> bodyoriginAddresscontactName = null, Expression<Func<string>> bodyoriginAddresscompanyName = null, Expression<Func<string>> bodyoriginAddresscontactPhone = null, Expression<Func<string>> bodyoriginAddresscontactEmail = null, Expression<Func<string>> bodysenderAddressline1 = null, Expression<Func<string>> bodysenderAddressline2 = null, Expression<Func<string>> bodysenderAddressstate = null, Expression<Func<string>> bodysenderAddresscity = null, Expression<Func<string>> bodysenderAddresspostalCode = null, Expression<Func<string>> bodysenderAddresscountryAlpha2 = null, Expression<Func<string>> bodysenderAddresscontactName = null, Expression<Func<string>> bodysenderAddresscompanyName = null, Expression<Func<string>> bodysenderAddresscontactPhone = null, Expression<Func<string>> bodysenderAddresscontactEmail = null, Expression<Func<string>> bodyreturnAddressline1 = null, Expression<Func<string>> bodyreturnAddressline2 = null, Expression<Func<string>> bodyreturnAddressstate = null, Expression<Func<string>> bodyreturnAddresscity = null, Expression<Func<string>> bodyreturnAddresspostalCode = null, Expression<Func<string>> bodyreturnAddresscountryAlpha2 = null, Expression<Func<string>> bodyreturnAddresscontactName = null, Expression<Func<string>> bodyreturnAddresscompanyName = null, Expression<Func<string>> bodyreturnAddresscontactPhone = null, Expression<Func<string>> bodyreturnAddresscontactEmail = null, Expression<Func<string>> bodydestinationAddressline1 = null, Expression<Func<string>> bodydestinationAddressline2 = null, Expression<Func<string>> bodydestinationAddressstate = null, Expression<Func<string>> bodydestinationAddresscity = null, Expression<Func<string>> bodydestinationAddresspostalCode = null, Expression<Func<string>> bodydestinationAddresscountryAlpha2 = null, Expression<Func<string>> bodydestinationAddresscontactName = null, Expression<Func<string>> bodydestinationAddresscompanyName = null, Expression<Func<string>> bodydestinationAddresscontactPhone = null, Expression<Func<string>> bodydestinationAddresscontactEmail = null, Expression<Func<bool>> bodysetAsResidential = null, Expression<Func<string>> bodyconsigneeTaxId = null, Expression<Func<string>> bodyeeiReference = null, Expression<Func<string>> bodyincoterms = null, Expression<Func<bool>> bodyinsuranceisInsured = null, Expression<Func<int>> bodyinsuranceinsuredAmount = null, Expression<Func<string>> bodyinsuranceinsuredCurrency = null, Expression<Func<string>> bodyorderDataplatformName = null, Expression<Func<string>> bodyorderDataplatformOrderNumber = null, Expression<Func<string[]>> bodyorderDataorderTagList = null, Expression<Func<string>> bodyorderDatasellerNotes = null, Expression<Func<string>> bodyorderDatabuyerNotes = null, Expression<Func<string>> bodycourierSelectionselectedCourierId = null, Expression<Func<bool>> bodycourierSelectionallowCourierFallback = null, Expression<Func<bool>> bodycourierSelectionapplyShippingRules = null, Expression<Func<string>> bodyshippingSettingsunitsweight = null, Expression<Func<string>> bodyshippingSettingsunitsdimensions = null, Expression<Func<string>> bodyshippingSettingsprintingOptionsformat = null, Expression<Func<string>> bodyshippingSettingsprintingOptionslabel = null, Expression<Func<string>> bodyshippingSettingsprintingOptionscommercialInvoice = null, Expression<Func<string>> bodyshippingSettingsprintingOptionspackingSlip = null, Expression<Func<bool>> bodyshippingSettingsbuyLabel = null, Expression<Func<bool>> bodyshippingSettingsbuyLabelSynchronous = null, Expression<Func<bodyparcelsInputItem[]>> bodyparcels = null)
        {
            var __workflow_bodyoriginAddressline1 = WorkflowExpression.Compile(bodyoriginAddressline1, nameof(bodyoriginAddressline1), required: false);
            var __workflow_bodyoriginAddressline2 = WorkflowExpression.Compile(bodyoriginAddressline2, nameof(bodyoriginAddressline2), required: false);
            var __workflow_bodyoriginAddressstate = WorkflowExpression.Compile(bodyoriginAddressstate, nameof(bodyoriginAddressstate), required: false);
            var __workflow_bodyoriginAddresscity = WorkflowExpression.Compile(bodyoriginAddresscity, nameof(bodyoriginAddresscity), required: false);
            var __workflow_bodyoriginAddresspostalCode = WorkflowExpression.Compile(bodyoriginAddresspostalCode, nameof(bodyoriginAddresspostalCode), required: false);
            var __workflow_bodyoriginAddresscountryAlpha2 = WorkflowExpression.Compile(bodyoriginAddresscountryAlpha2, nameof(bodyoriginAddresscountryAlpha2), required: false);
            var __workflow_bodyoriginAddresscontactName = WorkflowExpression.Compile(bodyoriginAddresscontactName, nameof(bodyoriginAddresscontactName), required: false);
            var __workflow_bodyoriginAddresscompanyName = WorkflowExpression.Compile(bodyoriginAddresscompanyName, nameof(bodyoriginAddresscompanyName), required: false);
            var __workflow_bodyoriginAddresscontactPhone = WorkflowExpression.Compile(bodyoriginAddresscontactPhone, nameof(bodyoriginAddresscontactPhone), required: false);
            var __workflow_bodyoriginAddresscontactEmail = WorkflowExpression.Compile(bodyoriginAddresscontactEmail, nameof(bodyoriginAddresscontactEmail), required: false);
            var __workflow_bodysenderAddressline1 = WorkflowExpression.Compile(bodysenderAddressline1, nameof(bodysenderAddressline1), required: false);
            var __workflow_bodysenderAddressline2 = WorkflowExpression.Compile(bodysenderAddressline2, nameof(bodysenderAddressline2), required: false);
            var __workflow_bodysenderAddressstate = WorkflowExpression.Compile(bodysenderAddressstate, nameof(bodysenderAddressstate), required: false);
            var __workflow_bodysenderAddresscity = WorkflowExpression.Compile(bodysenderAddresscity, nameof(bodysenderAddresscity), required: false);
            var __workflow_bodysenderAddresspostalCode = WorkflowExpression.Compile(bodysenderAddresspostalCode, nameof(bodysenderAddresspostalCode), required: false);
            var __workflow_bodysenderAddresscountryAlpha2 = WorkflowExpression.Compile(bodysenderAddresscountryAlpha2, nameof(bodysenderAddresscountryAlpha2), required: false);
            var __workflow_bodysenderAddresscontactName = WorkflowExpression.Compile(bodysenderAddresscontactName, nameof(bodysenderAddresscontactName), required: false);
            var __workflow_bodysenderAddresscompanyName = WorkflowExpression.Compile(bodysenderAddresscompanyName, nameof(bodysenderAddresscompanyName), required: false);
            var __workflow_bodysenderAddresscontactPhone = WorkflowExpression.Compile(bodysenderAddresscontactPhone, nameof(bodysenderAddresscontactPhone), required: false);
            var __workflow_bodysenderAddresscontactEmail = WorkflowExpression.Compile(bodysenderAddresscontactEmail, nameof(bodysenderAddresscontactEmail), required: false);
            var __workflow_bodyreturnAddressline1 = WorkflowExpression.Compile(bodyreturnAddressline1, nameof(bodyreturnAddressline1), required: false);
            var __workflow_bodyreturnAddressline2 = WorkflowExpression.Compile(bodyreturnAddressline2, nameof(bodyreturnAddressline2), required: false);
            var __workflow_bodyreturnAddressstate = WorkflowExpression.Compile(bodyreturnAddressstate, nameof(bodyreturnAddressstate), required: false);
            var __workflow_bodyreturnAddresscity = WorkflowExpression.Compile(bodyreturnAddresscity, nameof(bodyreturnAddresscity), required: false);
            var __workflow_bodyreturnAddresspostalCode = WorkflowExpression.Compile(bodyreturnAddresspostalCode, nameof(bodyreturnAddresspostalCode), required: false);
            var __workflow_bodyreturnAddresscountryAlpha2 = WorkflowExpression.Compile(bodyreturnAddresscountryAlpha2, nameof(bodyreturnAddresscountryAlpha2), required: false);
            var __workflow_bodyreturnAddresscontactName = WorkflowExpression.Compile(bodyreturnAddresscontactName, nameof(bodyreturnAddresscontactName), required: false);
            var __workflow_bodyreturnAddresscompanyName = WorkflowExpression.Compile(bodyreturnAddresscompanyName, nameof(bodyreturnAddresscompanyName), required: false);
            var __workflow_bodyreturnAddresscontactPhone = WorkflowExpression.Compile(bodyreturnAddresscontactPhone, nameof(bodyreturnAddresscontactPhone), required: false);
            var __workflow_bodyreturnAddresscontactEmail = WorkflowExpression.Compile(bodyreturnAddresscontactEmail, nameof(bodyreturnAddresscontactEmail), required: false);
            var __workflow_bodydestinationAddressline1 = WorkflowExpression.Compile(bodydestinationAddressline1, nameof(bodydestinationAddressline1), required: false);
            var __workflow_bodydestinationAddressline2 = WorkflowExpression.Compile(bodydestinationAddressline2, nameof(bodydestinationAddressline2), required: false);
            var __workflow_bodydestinationAddressstate = WorkflowExpression.Compile(bodydestinationAddressstate, nameof(bodydestinationAddressstate), required: false);
            var __workflow_bodydestinationAddresscity = WorkflowExpression.Compile(bodydestinationAddresscity, nameof(bodydestinationAddresscity), required: false);
            var __workflow_bodydestinationAddresspostalCode = WorkflowExpression.Compile(bodydestinationAddresspostalCode, nameof(bodydestinationAddresspostalCode), required: false);
            var __workflow_bodydestinationAddresscountryAlpha2 = WorkflowExpression.Compile(bodydestinationAddresscountryAlpha2, nameof(bodydestinationAddresscountryAlpha2), required: false);
            var __workflow_bodydestinationAddresscontactName = WorkflowExpression.Compile(bodydestinationAddresscontactName, nameof(bodydestinationAddresscontactName), required: false);
            var __workflow_bodydestinationAddresscompanyName = WorkflowExpression.Compile(bodydestinationAddresscompanyName, nameof(bodydestinationAddresscompanyName), required: false);
            var __workflow_bodydestinationAddresscontactPhone = WorkflowExpression.Compile(bodydestinationAddresscontactPhone, nameof(bodydestinationAddresscontactPhone), required: false);
            var __workflow_bodydestinationAddresscontactEmail = WorkflowExpression.Compile(bodydestinationAddresscontactEmail, nameof(bodydestinationAddresscontactEmail), required: false);
            var __workflow_bodysetAsResidential = WorkflowExpression.Compile(bodysetAsResidential, nameof(bodysetAsResidential), required: false);
            var __workflow_bodyconsigneeTaxId = WorkflowExpression.Compile(bodyconsigneeTaxId, nameof(bodyconsigneeTaxId), required: false);
            var __workflow_bodyeeiReference = WorkflowExpression.Compile(bodyeeiReference, nameof(bodyeeiReference), required: false);
            var __workflow_bodyincoterms = WorkflowExpression.Compile(bodyincoterms, nameof(bodyincoterms), required: false);
            var __workflow_bodyinsuranceisInsured = WorkflowExpression.Compile(bodyinsuranceisInsured, nameof(bodyinsuranceisInsured), required: false);
            var __workflow_bodyinsuranceinsuredAmount = WorkflowExpression.Compile(bodyinsuranceinsuredAmount, nameof(bodyinsuranceinsuredAmount), required: false);
            var __workflow_bodyinsuranceinsuredCurrency = WorkflowExpression.Compile(bodyinsuranceinsuredCurrency, nameof(bodyinsuranceinsuredCurrency), required: false);
            var __workflow_bodyorderDataplatformName = WorkflowExpression.Compile(bodyorderDataplatformName, nameof(bodyorderDataplatformName), required: false);
            var __workflow_bodyorderDataplatformOrderNumber = WorkflowExpression.Compile(bodyorderDataplatformOrderNumber, nameof(bodyorderDataplatformOrderNumber), required: false);
            var __workflow_bodyorderDataorderTagList = WorkflowExpression.Compile(bodyorderDataorderTagList, nameof(bodyorderDataorderTagList), required: false);
            var __workflow_bodyorderDatasellerNotes = WorkflowExpression.Compile(bodyorderDatasellerNotes, nameof(bodyorderDatasellerNotes), required: false);
            var __workflow_bodyorderDatabuyerNotes = WorkflowExpression.Compile(bodyorderDatabuyerNotes, nameof(bodyorderDatabuyerNotes), required: false);
            var __workflow_bodycourierSelectionselectedCourierId = WorkflowExpression.Compile(bodycourierSelectionselectedCourierId, nameof(bodycourierSelectionselectedCourierId), required: false);
            var __workflow_bodycourierSelectionallowCourierFallback = WorkflowExpression.Compile(bodycourierSelectionallowCourierFallback, nameof(bodycourierSelectionallowCourierFallback), required: false);
            var __workflow_bodycourierSelectionapplyShippingRules = WorkflowExpression.Compile(bodycourierSelectionapplyShippingRules, nameof(bodycourierSelectionapplyShippingRules), required: false);
            var __workflow_bodyshippingSettingsunitsweight = WorkflowExpression.Compile(bodyshippingSettingsunitsweight, nameof(bodyshippingSettingsunitsweight), required: false);
            var __workflow_bodyshippingSettingsunitsdimensions = WorkflowExpression.Compile(bodyshippingSettingsunitsdimensions, nameof(bodyshippingSettingsunitsdimensions), required: false);
            var __workflow_bodyshippingSettingsprintingOptionsformat = WorkflowExpression.Compile(bodyshippingSettingsprintingOptionsformat, nameof(bodyshippingSettingsprintingOptionsformat), required: false);
            var __workflow_bodyshippingSettingsprintingOptionslabel = WorkflowExpression.Compile(bodyshippingSettingsprintingOptionslabel, nameof(bodyshippingSettingsprintingOptionslabel), required: false);
            var __workflow_bodyshippingSettingsprintingOptionscommercialInvoice = WorkflowExpression.Compile(bodyshippingSettingsprintingOptionscommercialInvoice, nameof(bodyshippingSettingsprintingOptionscommercialInvoice), required: false);
            var __workflow_bodyshippingSettingsprintingOptionspackingSlip = WorkflowExpression.Compile(bodyshippingSettingsprintingOptionspackingSlip, nameof(bodyshippingSettingsprintingOptionspackingSlip), required: false);
            var __workflow_bodyshippingSettingsbuyLabel = WorkflowExpression.Compile(bodyshippingSettingsbuyLabel, nameof(bodyshippingSettingsbuyLabel), required: false);
            var __workflow_bodyshippingSettingsbuyLabelSynchronous = WorkflowExpression.Compile(bodyshippingSettingsbuyLabelSynchronous, nameof(bodyshippingSettingsbuyLabelSynchronous), required: false);
            var __workflow_bodyparcels = WorkflowExpression.Compile(bodyparcels, nameof(bodyparcels), required: false);
            return new DeferredBodyAction<CreateAShipmentResponse>(() =>
            {
                var apiCallPath = "/v2/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var originAddressObject = new JObject();
                var originAddressObjectpropCount = 0;
                if (__workflow_bodyoriginAddressline1 != null)
                {
                    originAddressObject["line_1"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddressline1);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddressline2 != null)
                {
                    originAddressObject["line_2"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddressline2);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddressstate != null)
                {
                    originAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddressstate);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscity != null)
                {
                    originAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscity);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresspostalCode != null)
                {
                    originAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresspostalCode);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscountryAlpha2 != null)
                {
                    originAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscountryAlpha2);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscontactName != null)
                {
                    originAddressObject["contact_name"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscontactName);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscompanyName != null)
                {
                    originAddressObject["company_name"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscompanyName);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscontactPhone != null)
                {
                    originAddressObject["contact_phone"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscontactPhone);
                    originAddressObjectpropCount++;
                }

                if (__workflow_bodyoriginAddresscontactEmail != null)
                {
                    originAddressObject["contact_email"] = ExpressionConverter.ConvertO(__workflow_bodyoriginAddresscontactEmail);
                    originAddressObjectpropCount++;
                }

                if (originAddressObjectpropCount > 0)
                {
                    body["origin_address"] = originAddressObject;
                    bodypropCount++;
                }

                var senderAddressObject = new JObject();
                var senderAddressObjectpropCount = 0;
                if (__workflow_bodysenderAddressline1 != null)
                {
                    senderAddressObject["line_1"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddressline1);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddressline2 != null)
                {
                    senderAddressObject["line_2"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddressline2);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddressstate != null)
                {
                    senderAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddressstate);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresscity != null)
                {
                    senderAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresscity);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresspostalCode != null)
                {
                    senderAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresspostalCode);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresscountryAlpha2 != null)
                {
                    senderAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresscountryAlpha2);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresscontactName != null)
                {
                    senderAddressObject["contact_name"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresscontactName);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresscompanyName != null)
                {
                    senderAddressObject["company_name"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresscompanyName);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresscontactPhone != null)
                {
                    senderAddressObject["contact_phone"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresscontactPhone);
                    senderAddressObjectpropCount++;
                }

                if (__workflow_bodysenderAddresscontactEmail != null)
                {
                    senderAddressObject["contact_email"] = ExpressionConverter.ConvertO(__workflow_bodysenderAddresscontactEmail);
                    senderAddressObjectpropCount++;
                }

                if (senderAddressObjectpropCount > 0)
                {
                    body["sender_address"] = senderAddressObject;
                    bodypropCount++;
                }

                var returnAddressObject = new JObject();
                var returnAddressObjectpropCount = 0;
                if (__workflow_bodyreturnAddressline1 != null)
                {
                    returnAddressObject["line_1"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddressline1);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddressline2 != null)
                {
                    returnAddressObject["line_2"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddressline2);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddressstate != null)
                {
                    returnAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddressstate);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresscity != null)
                {
                    returnAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresscity);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresspostalCode != null)
                {
                    returnAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresspostalCode);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresscountryAlpha2 != null)
                {
                    returnAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresscountryAlpha2);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresscontactName != null)
                {
                    returnAddressObject["contact_name"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresscontactName);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresscompanyName != null)
                {
                    returnAddressObject["company_name"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresscompanyName);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresscontactPhone != null)
                {
                    returnAddressObject["contact_phone"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresscontactPhone);
                    returnAddressObjectpropCount++;
                }

                if (__workflow_bodyreturnAddresscontactEmail != null)
                {
                    returnAddressObject["contact_email"] = ExpressionConverter.ConvertO(__workflow_bodyreturnAddresscontactEmail);
                    returnAddressObjectpropCount++;
                }

                if (returnAddressObjectpropCount > 0)
                {
                    body["return_address"] = returnAddressObject;
                    bodypropCount++;
                }

                var destinationAddressObject = new JObject();
                var destinationAddressObjectpropCount = 0;
                if (__workflow_bodydestinationAddressline1 != null)
                {
                    destinationAddressObject["line_1"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressline1);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddressline2 != null)
                {
                    destinationAddressObject["line_2"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressline2);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddressstate != null)
                {
                    destinationAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressstate);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscity != null)
                {
                    destinationAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscity);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresspostalCode != null)
                {
                    destinationAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresspostalCode);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscountryAlpha2 != null)
                {
                    destinationAddressObject["country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscountryAlpha2);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscontactName != null)
                {
                    destinationAddressObject["contact_name"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscontactName);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscompanyName != null)
                {
                    destinationAddressObject["company_name"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscompanyName);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscontactPhone != null)
                {
                    destinationAddressObject["contact_phone"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscontactPhone);
                    destinationAddressObjectpropCount++;
                }

                if (__workflow_bodydestinationAddresscontactEmail != null)
                {
                    destinationAddressObject["contact_email"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddresscontactEmail);
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

                if (__workflow_bodysetAsResidential != null)
                {
                    body["set_as_residential"] = ExpressionConverter.ConvertO(__workflow_bodysetAsResidential);
                    bodypropCount++;
                }

                if (__workflow_bodyconsigneeTaxId != null)
                {
                    body["consignee_tax_id"] = ExpressionConverter.ConvertO(__workflow_bodyconsigneeTaxId);
                    bodypropCount++;
                }

                if (__workflow_bodyeeiReference != null)
                {
                    body["eei_reference"] = ExpressionConverter.ConvertO(__workflow_bodyeeiReference);
                    bodypropCount++;
                }

                if (__workflow_bodyincoterms != null)
                {
                    body["incoterms"] = ExpressionConverter.ConvertO(__workflow_bodyincoterms);
                    bodypropCount++;
                }

                var insuranceObject = new JObject();
                var insuranceObjectpropCount = 0;
                if (__workflow_bodyinsuranceisInsured != null)
                {
                    insuranceObject["is_insured"] = ExpressionConverter.ConvertO(__workflow_bodyinsuranceisInsured);
                    insuranceObjectpropCount++;
                }

                if (__workflow_bodyinsuranceinsuredAmount != null)
                {
                    insuranceObject["insured_amount"] = ExpressionConverter.ConvertO(__workflow_bodyinsuranceinsuredAmount);
                    insuranceObjectpropCount++;
                }

                if (__workflow_bodyinsuranceinsuredCurrency != null)
                {
                    insuranceObject["insured_currency"] = ExpressionConverter.ConvertO(__workflow_bodyinsuranceinsuredCurrency);
                    insuranceObjectpropCount++;
                }

                if (insuranceObjectpropCount > 0)
                {
                    body["insurance"] = insuranceObject;
                    bodypropCount++;
                }

                var orderDataObject = new JObject();
                var orderDataObjectpropCount = 0;
                if (__workflow_bodyorderDataplatformName != null)
                {
                    orderDataObject["platform_name"] = ExpressionConverter.ConvertO(__workflow_bodyorderDataplatformName);
                    orderDataObjectpropCount++;
                }

                if (__workflow_bodyorderDataplatformOrderNumber != null)
                {
                    orderDataObject["platform_order_number"] = ExpressionConverter.ConvertO(__workflow_bodyorderDataplatformOrderNumber);
                    orderDataObjectpropCount++;
                }

                if (__workflow_bodyorderDataorderTagList != null)
                {
                    orderDataObject["order_tag_list"] = ExpressionConverter.ConvertO(__workflow_bodyorderDataorderTagList);
                    orderDataObjectpropCount++;
                }

                if (__workflow_bodyorderDatasellerNotes != null)
                {
                    orderDataObject["seller_notes"] = ExpressionConverter.ConvertO(__workflow_bodyorderDatasellerNotes);
                    orderDataObjectpropCount++;
                }

                if (__workflow_bodyorderDatabuyerNotes != null)
                {
                    orderDataObject["buyer_notes"] = ExpressionConverter.ConvertO(__workflow_bodyorderDatabuyerNotes);
                    orderDataObjectpropCount++;
                }

                if (orderDataObjectpropCount > 0)
                {
                    body["order_data"] = orderDataObject;
                    bodypropCount++;
                }

                var courierSelectionObject = new JObject();
                var courierSelectionObjectpropCount = 0;
                if (__workflow_bodycourierSelectionselectedCourierId != null)
                {
                    courierSelectionObject["selected_courier_id"] = ExpressionConverter.ConvertO(__workflow_bodycourierSelectionselectedCourierId);
                    courierSelectionObjectpropCount++;
                }

                if (__workflow_bodycourierSelectionallowCourierFallback != null)
                {
                    courierSelectionObject["allow_courier_fallback"] = ExpressionConverter.ConvertO(__workflow_bodycourierSelectionallowCourierFallback);
                    courierSelectionObjectpropCount++;
                }

                if (__workflow_bodycourierSelectionapplyShippingRules != null)
                {
                    courierSelectionObject["apply_shipping_rules"] = ExpressionConverter.ConvertO(__workflow_bodycourierSelectionapplyShippingRules);
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
                if (__workflow_bodyshippingSettingsunitsweight != null)
                {
                    unitsObject["weight"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsunitsweight);
                    unitsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsunitsdimensions != null)
                {
                    unitsObject["dimensions"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsunitsdimensions);
                    unitsObjectpropCount++;
                }

                if (unitsObjectpropCount > 0)
                {
                    shippingSettingsObject["units"] = unitsObject;
                    shippingSettingsObjectpropCount++;
                }

                var printingOptionsObject = new JObject();
                var printingOptionsObjectpropCount = 0;
                if (__workflow_bodyshippingSettingsprintingOptionsformat != null)
                {
                    printingOptionsObject["format"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsprintingOptionsformat);
                    printingOptionsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsprintingOptionslabel != null)
                {
                    printingOptionsObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsprintingOptionslabel);
                    printingOptionsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsprintingOptionscommercialInvoice != null)
                {
                    printingOptionsObject["commercial_invoice"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsprintingOptionscommercialInvoice);
                    printingOptionsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsprintingOptionspackingSlip != null)
                {
                    printingOptionsObject["packing_slip"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsprintingOptionspackingSlip);
                    printingOptionsObjectpropCount++;
                }

                if (printingOptionsObjectpropCount > 0)
                {
                    shippingSettingsObject["printing_options"] = printingOptionsObject;
                    shippingSettingsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsbuyLabel != null)
                {
                    shippingSettingsObject["buy_label"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsbuyLabel);
                    shippingSettingsObjectpropCount++;
                }

                if (__workflow_bodyshippingSettingsbuyLabelSynchronous != null)
                {
                    shippingSettingsObject["buy_label_synchronous"] = ExpressionConverter.ConvertO(__workflow_bodyshippingSettingsbuyLabelSynchronous);
                    shippingSettingsObjectpropCount++;
                }

                if (shippingSettingsObjectpropCount > 0)
                {
                    body["shipping_settings"] = shippingSettingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyparcels != null)
                {
                    body["parcels"] = ExpressionConverter.ConvertO(__workflow_bodyparcels);
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
        public IBodyWorkflowAction<BuyAShipmentLabelResponse> BuyAShipmentLabel(Expression<Func<bodyshipmentsInputItem[]>> bodyshipments = null)
        {
            var __workflow_bodyshipments = WorkflowExpression.Compile(bodyshipments, nameof(bodyshipments), required: false);
            return new DeferredBodyAction<BuyAShipmentLabelResponse>(() =>
            {
                var apiCallPath = "/label/v1/labels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyshipments != null)
                {
                    body["shipments"] = ExpressionConverter.ConvertO(__workflow_bodyshipments);
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
        public IBodyWorkflowAction<DeleteAShipmentResponse> DeleteAShipment(Expression<Func<string>> easyshipShipmentId)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            return new DeferredBodyAction<DeleteAShipmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_easyshipShipmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateAShipmentResponse> UpdateAShipment(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> bodydestinationCountryAlpha2 = null, Expression<Func<string>> bodydestinationCity = null, Expression<Func<string>> bodydestinationName = null, Expression<Func<string>> bodydestinationAddressLine1 = null, Expression<Func<string>> bodydestinationPhoneNumber = null, Expression<Func<bodyitemsInputItem[]>> bodyitems = null, Expression<Func<string>> bodyplatformName = null, Expression<Func<string>> bodyplatformOrderNumber = null, Expression<Func<string>> bodytaxesDutiesPaidBy = null, Expression<Func<bool>> bodyisInsured = null, Expression<Func<string>> bodyselectedCourierId = null, Expression<Func<int>> bodydestinationPostalCode = null, Expression<Func<string>> bodydestinationState = null, Expression<Func<string>> bodydestinationAddressLine2 = null, Expression<Func<string>> bodydestinationEmailAddress = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_bodydestinationCountryAlpha2 = WorkflowExpression.Compile(bodydestinationCountryAlpha2, nameof(bodydestinationCountryAlpha2), required: false);
            var __workflow_bodydestinationCity = WorkflowExpression.Compile(bodydestinationCity, nameof(bodydestinationCity), required: false);
            var __workflow_bodydestinationName = WorkflowExpression.Compile(bodydestinationName, nameof(bodydestinationName), required: false);
            var __workflow_bodydestinationAddressLine1 = WorkflowExpression.Compile(bodydestinationAddressLine1, nameof(bodydestinationAddressLine1), required: false);
            var __workflow_bodydestinationPhoneNumber = WorkflowExpression.Compile(bodydestinationPhoneNumber, nameof(bodydestinationPhoneNumber), required: false);
            var __workflow_bodyitems = WorkflowExpression.Compile(bodyitems, nameof(bodyitems), required: false);
            var __workflow_bodyplatformName = WorkflowExpression.Compile(bodyplatformName, nameof(bodyplatformName), required: false);
            var __workflow_bodyplatformOrderNumber = WorkflowExpression.Compile(bodyplatformOrderNumber, nameof(bodyplatformOrderNumber), required: false);
            var __workflow_bodytaxesDutiesPaidBy = WorkflowExpression.Compile(bodytaxesDutiesPaidBy, nameof(bodytaxesDutiesPaidBy), required: false);
            var __workflow_bodyisInsured = WorkflowExpression.Compile(bodyisInsured, nameof(bodyisInsured), required: false);
            var __workflow_bodyselectedCourierId = WorkflowExpression.Compile(bodyselectedCourierId, nameof(bodyselectedCourierId), required: false);
            var __workflow_bodydestinationPostalCode = WorkflowExpression.Compile(bodydestinationPostalCode, nameof(bodydestinationPostalCode), required: false);
            var __workflow_bodydestinationState = WorkflowExpression.Compile(bodydestinationState, nameof(bodydestinationState), required: false);
            var __workflow_bodydestinationAddressLine2 = WorkflowExpression.Compile(bodydestinationAddressLine2, nameof(bodydestinationAddressLine2), required: false);
            var __workflow_bodydestinationEmailAddress = WorkflowExpression.Compile(bodydestinationEmailAddress, nameof(bodydestinationEmailAddress), required: false);
            return new DeferredBodyAction<UpdateAShipmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/shipment/v1/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_easyshipShipmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydestinationCountryAlpha2 != null)
                {
                    body["destination_country_alpha2"] = ExpressionConverter.ConvertO(__workflow_bodydestinationCountryAlpha2);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationCity != null)
                {
                    body["destination_city"] = ExpressionConverter.ConvertO(__workflow_bodydestinationCity);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationName != null)
                {
                    body["destination_name"] = ExpressionConverter.ConvertO(__workflow_bodydestinationName);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationAddressLine1 != null)
                {
                    body["destination_address_line_1"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationPhoneNumber != null)
                {
                    body["destination_phone_number"] = ExpressionConverter.ConvertO(__workflow_bodydestinationPhoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyitems != null)
                {
                    body["items"] = ExpressionConverter.ConvertO(__workflow_bodyitems);
                    bodypropCount++;
                }

                if (__workflow_bodyplatformName != null)
                {
                    body["platform_name"] = ExpressionConverter.ConvertO(__workflow_bodyplatformName);
                    bodypropCount++;
                }

                if (__workflow_bodyplatformOrderNumber != null)
                {
                    body["platform_order_number"] = ExpressionConverter.ConvertO(__workflow_bodyplatformOrderNumber);
                    bodypropCount++;
                }

                if (__workflow_bodytaxesDutiesPaidBy != null)
                {
                    body["taxes_duties_paid_by"] = ExpressionConverter.ConvertO(__workflow_bodytaxesDutiesPaidBy);
                    bodypropCount++;
                }

                if (__workflow_bodyisInsured != null)
                {
                    body["is_insured"] = ExpressionConverter.ConvertO(__workflow_bodyisInsured);
                    bodypropCount++;
                }

                if (__workflow_bodyselectedCourierId != null)
                {
                    body["selected_courier_id"] = ExpressionConverter.ConvertO(__workflow_bodyselectedCourierId);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationPostalCode != null)
                {
                    body["destination_postal_code"] = ExpressionConverter.ConvertO(__workflow_bodydestinationPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationState != null)
                {
                    body["destination_state"] = ExpressionConverter.ConvertO(__workflow_bodydestinationState);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationAddressLine2 != null)
                {
                    body["destination_address_line_2"] = ExpressionConverter.ConvertO(__workflow_bodydestinationAddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodydestinationEmailAddress != null)
                {
                    body["destination_email_address"] = ExpressionConverter.ConvertO(__workflow_bodydestinationEmailAddress);
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
        public IBodyWorkflowAction<GetAShipmentResponse> GetAShipment(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> format = null, Expression<Func<string>> label = null, Expression<Func<string>> commercialInvoice = null, Expression<Func<string>> packingSlip = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_label = WorkflowExpression.Compile(label, nameof(label), required: false);
            var __workflow_commercialInvoice = WorkflowExpression.Compile(commercialInvoice, nameof(commercialInvoice), required: false);
            var __workflow_packingSlip = WorkflowExpression.Compile(packingSlip, nameof(packingSlip), required: false);
            return new DeferredBodyAction<GetAShipmentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/shipments/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_easyshipShipmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_label != null)
                    callPayload.Queries["label"] = ExpressionConverter.Convert(__workflow_label);
                if (__workflow_commercialInvoice != null)
                    callPayload.Queries["commercial_invoice"] = ExpressionConverter.Convert(__workflow_commercialInvoice);
                if (__workflow_packingSlip != null)
                    callPayload.Queries["packing_slip"] = ExpressionConverter.Convert(__workflow_packingSlip);
                return new ApiConnectionAction<GetAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateWarehouseStateResponse> UpdateWarehouseState(Expression<Func<bodyshipmentsInputItem2[]>> bodyshipments = null)
        {
            var __workflow_bodyshipments = WorkflowExpression.Compile(bodyshipments, nameof(bodyshipments), required: false);
            return new DeferredBodyAction<UpdateWarehouseStateResponse>(() =>
            {
                var apiCallPath = "/v2/shipments/warehouse_state";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyshipments != null)
                {
                    body["shipments"] = ExpressionConverter.ConvertO(__workflow_bodyshipments);
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
        public IBodyWorkflowAction<GetAvailablePickupSlotsResponse> GetAvailablePickupSlots(Expression<Func<string>> courierId)
        {
            var __workflow_courierId = WorkflowExpression.Compile(courierId, nameof(courierId), required: true);
            return new DeferredBodyAction<GetAvailablePickupSlotsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/pickup/v1/pickup_slots/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_courierId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAvailablePickupSlotsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<RequestAPickupResponse> RequestAPickup(Expression<Func<string>> bodycourierId = null, Expression<Func<string>> bodypreferredDate = null, Expression<Func<string>> bodypreferredMaxTime = null, Expression<Func<string>> bodypreferredMinTime = null, Expression<Func<string[]>> bodyeasyshipShipmentIds = null)
        {
            var __workflow_bodycourierId = WorkflowExpression.Compile(bodycourierId, nameof(bodycourierId), required: false);
            var __workflow_bodypreferredDate = WorkflowExpression.Compile(bodypreferredDate, nameof(bodypreferredDate), required: false);
            var __workflow_bodypreferredMaxTime = WorkflowExpression.Compile(bodypreferredMaxTime, nameof(bodypreferredMaxTime), required: false);
            var __workflow_bodypreferredMinTime = WorkflowExpression.Compile(bodypreferredMinTime, nameof(bodypreferredMinTime), required: false);
            var __workflow_bodyeasyshipShipmentIds = WorkflowExpression.Compile(bodyeasyshipShipmentIds, nameof(bodyeasyshipShipmentIds), required: false);
            return new DeferredBodyAction<RequestAPickupResponse>(() =>
            {
                var apiCallPath = "/pickup/v1/pickups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycourierId != null)
                {
                    body["courier_id"] = ExpressionConverter.ConvertO(__workflow_bodycourierId);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredDate != null)
                {
                    body["preferred_date"] = ExpressionConverter.ConvertO(__workflow_bodypreferredDate);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredMaxTime != null)
                {
                    body["preferred_max_time"] = ExpressionConverter.ConvertO(__workflow_bodypreferredMaxTime);
                    bodypropCount++;
                }

                if (__workflow_bodypreferredMinTime != null)
                {
                    body["preferred_min_time"] = ExpressionConverter.ConvertO(__workflow_bodypreferredMinTime);
                    bodypropCount++;
                }

                if (__workflow_bodyeasyshipShipmentIds != null)
                {
                    body["easyship_shipment_ids"] = ExpressionConverter.ConvertO(__workflow_bodyeasyshipShipmentIds);
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
        public IBodyWorkflowAction<GetCheckpointsResponse> GetCheckpoints(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_platformOrderNumber = WorkflowExpression.Compile(platformOrderNumber, nameof(platformOrderNumber), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetCheckpointsResponse>(() =>
            {
                var apiCallPath = "/track/v1/checkpoints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["easyship_shipment_id"] = ExpressionConverter.Convert(__workflow_easyshipShipmentId);
                if (__workflow_platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = ExpressionConverter.Convert(__workflow_platformOrderNumber);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<GetCheckpointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetStatusResponse> GetStatus(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_platformOrderNumber = WorkflowExpression.Compile(platformOrderNumber, nameof(platformOrderNumber), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetStatusResponse>(() =>
            {
                var apiCallPath = "/track/v1/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["easyship_shipment_id"] = ExpressionConverter.Convert(__workflow_easyshipShipmentId);
                if (__workflow_platformOrderNumber != null)
                    callPayload.Queries["platform_order_number"] = ExpressionConverter.Convert(__workflow_platformOrderNumber);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
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
