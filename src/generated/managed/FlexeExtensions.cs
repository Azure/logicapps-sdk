//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flexe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlexeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProducts([WorkflowExpression] Func<bodydatadropoffListInputItem[]> bodydatadropoffList = null, [WorkflowExpression] Func<string> bodymetacorrelationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/shipper/dropoff/container";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatadropoffList != null)
                {
                    dataObject["dropoffList"] = SourceExpressionConverter.ConvertToken(bodydatadropoffList);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetacorrelationId != null)
                {
                    metaObject["correlationId"] = SourceExpressionConverter.ConvertToken(bodymetacorrelationId);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction GetInboundShipmentsContainingNonPalletizedProducts([WorkflowExpression] Func<string> continuationToken, [WorkflowExpression] Func<string> pageSize, [WorkflowExpression] Func<string> state, [WorkflowExpression] Func<string> createdAtFrom, [WorkflowExpression] Func<string> createdAtTo, [WorkflowExpression] Func<string> updatedAtFrom, [WorkflowExpression] Func<string> updatedAtTo, [WorkflowExpression] Func<string> customerUUID, [WorkflowExpression] Func<string> purchaseOrder, [WorkflowExpression] Func<string> reservations)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/shipper/dropoff/containers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["continuationToken"] = SourceExpressionConverter.ConvertO(continuationToken);
                callPayload.Queries["pageSize"] = SourceExpressionConverter.ConvertO(pageSize);
                callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                callPayload.Queries["createdAtFrom"] = SourceExpressionConverter.ConvertO(createdAtFrom);
                callPayload.Queries["createdAtTo"] = SourceExpressionConverter.ConvertO(createdAtTo);
                callPayload.Queries["updatedAtFrom"] = SourceExpressionConverter.ConvertO(updatedAtFrom);
                callPayload.Queries["updatedAtTo"] = SourceExpressionConverter.ConvertO(updatedAtTo);
                callPayload.Queries["customerUUID"] = SourceExpressionConverter.ConvertO(customerUUID);
                callPayload.Queries["purchaseOrder"] = SourceExpressionConverter.ConvertO(purchaseOrder);
                callPayload.Queries["reservations"] = SourceExpressionConverter.ConvertO(reservations);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction RequestACountOfInventoryBySkuFromFlexe([WorkflowExpression] Func<string> reservationId = null, [WorkflowExpression] Func<string> clientRequestId = null, [WorkflowExpression] Func<string> continuationToken = null, [WorkflowExpression] Func<string> everInUse = null, [WorkflowExpression] Func<string> inUseSince = null, [WorkflowExpression] Func<string> itemIds = null, [WorkflowExpression] Func<string> skus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/shipper/inventory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reservationId != null)
                    callPayload.Queries["reservation_id"] = SourceExpressionConverter.ConvertO(reservationId);
                if (clientRequestId != null)
                    callPayload.Queries["client_request_id"] = SourceExpressionConverter.ConvertO(clientRequestId);
                if (continuationToken != null)
                    callPayload.Queries["continuation_token"] = SourceExpressionConverter.ConvertO(continuationToken);
                if (everInUse != null)
                    callPayload.Queries["ever_in_use"] = SourceExpressionConverter.ConvertO(everInUse);
                if (inUseSince != null)
                    callPayload.Queries["in_use_since"] = SourceExpressionConverter.ConvertO(inUseSince);
                if (itemIds != null)
                    callPayload.Queries["item_ids[]"] = SourceExpressionConverter.ConvertO(itemIds);
                if (skus != null)
                    callPayload.Queries["skus[]"] = SourceExpressionConverter.ConvertO(skus);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction CreateRetailFulfillmentOrder([WorkflowExpression] Func<string> bodydatareservationid, [WorkflowExpression] Func<string> bodydatareservationtype, [WorkflowExpression] Func<string> bodydatashipmentcustomerUUID, [WorkflowExpression] Func<bodydatashipmentinventoryInputItem[]> bodydatashipmentinventory, [WorkflowExpression] Func<string> bodydatashipmenttype, [WorkflowExpression] Func<string> bodydatashipmentshipToaddressLine1 = null, [WorkflowExpression] Func<string> bodydatashipmentshipTocountry = null, [WorkflowExpression] Func<string> bodydatashipmentshipTolocality = null, [WorkflowExpression] Func<string> bodydatashipmentshipToname = null, [WorkflowExpression] Func<string> bodydatashipmentshipTopostcode = null, [WorkflowExpression] Func<string> bodydatashipmentshipToregion = null, [WorkflowExpression] Func<string> bodydatashipmentshipToaddressLine2 = null, [WorkflowExpression] Func<string> bodydatashipmentshipToaddressLine3 = null, [WorkflowExpression] Func<string> bodydatashipmentshipTophone = null, [WorkflowExpression] Func<string> bodydatashipmentshipToemail = null, [WorkflowExpression] Func<string> bodydatashipmentshipWithinend = null, [WorkflowExpression] Func<string> bodydatashipmentshipWithinstart = null, [WorkflowExpression] Func<string> bodydatashipmentshipmentType = null, [WorkflowExpression] Func<string> bodydatashipmentshipmentMethod = null, [WorkflowExpression] Func<string> bodydatashipmentpurchaseOrder = null, [WorkflowExpression] Func<string> bodydatashipmentrouteBy = null, [WorkflowExpression] Func<string> bodydatashipmentinstructions = null, [WorkflowExpression] Func<string> bodydatashipmentlabelGenerationDatacarrier = null, [WorkflowExpression] Func<string> bodydatashipmentlabelGenerationDatacarrierServiceType = null, [WorkflowExpression] Func<string> bodydatashipmentlabelGenerationDatacarrierBillingAccountId = null, [WorkflowExpression] Func<string> bodydatashipmentbolGenerationDatags1usnumber = null, [WorkflowExpression] Func<string> bodydatashipmentbolGenerationDatags1usshipTovalue = null, [WorkflowExpression] Func<string> bodydatashipmentbolGenerationDatags1usbillTovalue = null, [WorkflowExpression] Func<string> bodydatashipmentbolGenerationDatatype = null, [WorkflowExpression] Func<string> bodydatashipmentroutingDetailsId = null, [WorkflowExpression] Func<string> bodydatashipmentdestinationType = null, [WorkflowExpression] Func<string> bodydatashipmentdestinationRetailer = null, [WorkflowExpression] Func<string> bodymetacorrelationId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/shipper/fulfillment/retail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                var reservationObject = new JObject();
                var reservationObjectpropCount = 0;
                reservationObjectpropCount++;
                reservationObject["id"] = SourceExpressionConverter.ConvertToken(bodydatareservationid);
                reservationObjectpropCount++;
                reservationObject["type"] = SourceExpressionConverter.ConvertToken(bodydatareservationtype);
                if (reservationObjectpropCount > 0)
                {
                    dataObject["reservation"] = reservationObject;
                    dataObjectpropCount++;
                }

                var shipmentObject = new JObject();
                var shipmentObjectpropCount = 0;
                shipmentObjectpropCount++;
                shipmentObject["customerUUID"] = SourceExpressionConverter.ConvertToken(bodydatashipmentcustomerUUID);
                shipmentObjectpropCount++;
                shipmentObject["inventory"] = SourceExpressionConverter.ConvertToken(bodydatashipmentinventory);
                var shipToObject = new JObject();
                var shipToObjectpropCount = 0;
                if (bodydatashipmentshipToaddressLine1 != null)
                {
                    shipToObject["addressLine1"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipToaddressLine1);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipTocountry != null)
                {
                    shipToObject["country"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipTocountry);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipTolocality != null)
                {
                    shipToObject["locality"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipTolocality);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipToname != null)
                {
                    shipToObject["name"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipToname);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipTopostcode != null)
                {
                    shipToObject["postcode"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipTopostcode);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipToregion != null)
                {
                    shipToObject["region"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipToregion);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipToaddressLine2 != null)
                {
                    shipToObject["addressLine2"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipToaddressLine2);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipToaddressLine3 != null)
                {
                    shipToObject["addressLine3"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipToaddressLine3);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipTophone != null)
                {
                    shipToObject["phone"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipTophone);
                    shipToObjectpropCount++;
                }

                if (bodydatashipmentshipToemail != null)
                {
                    shipToObject["email"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipToemail);
                    shipToObjectpropCount++;
                }

                if (shipToObjectpropCount > 0)
                {
                    shipmentObject["shipTo"] = shipToObject;
                    shipmentObjectpropCount++;
                }

                var shipWithinObject = new JObject();
                var shipWithinObjectpropCount = 0;
                if (bodydatashipmentshipWithinend != null)
                {
                    shipWithinObject["end"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipWithinend);
                    shipWithinObjectpropCount++;
                }

                if (bodydatashipmentshipWithinstart != null)
                {
                    shipWithinObject["start"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipWithinstart);
                    shipWithinObjectpropCount++;
                }

                if (shipWithinObjectpropCount > 0)
                {
                    shipmentObject["shipWithin"] = shipWithinObject;
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentshipmentType != null)
                {
                    shipmentObject["shipmentType"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipmentType);
                    shipmentObjectpropCount++;
                }

                shipmentObjectpropCount++;
                shipmentObject["type"] = SourceExpressionConverter.ConvertToken(bodydatashipmenttype);
                if (bodydatashipmentshipmentMethod != null)
                {
                    shipmentObject["shipmentMethod"] = SourceExpressionConverter.ConvertToken(bodydatashipmentshipmentMethod);
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentpurchaseOrder != null)
                {
                    shipmentObject["purchaseOrder"] = SourceExpressionConverter.ConvertToken(bodydatashipmentpurchaseOrder);
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentrouteBy != null)
                {
                    shipmentObject["routeBy"] = SourceExpressionConverter.ConvertToken(bodydatashipmentrouteBy);
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentinstructions != null)
                {
                    shipmentObject["instructions"] = SourceExpressionConverter.ConvertToken(bodydatashipmentinstructions);
                    shipmentObjectpropCount++;
                }

                var labelGenerationDataObject = new JObject();
                var labelGenerationDataObjectpropCount = 0;
                if (bodydatashipmentlabelGenerationDatacarrier != null)
                {
                    labelGenerationDataObject["carrier"] = SourceExpressionConverter.ConvertToken(bodydatashipmentlabelGenerationDatacarrier);
                    labelGenerationDataObjectpropCount++;
                }

                if (bodydatashipmentlabelGenerationDatacarrierServiceType != null)
                {
                    labelGenerationDataObject["carrierServiceType"] = SourceExpressionConverter.ConvertToken(bodydatashipmentlabelGenerationDatacarrierServiceType);
                    labelGenerationDataObjectpropCount++;
                }

                if (bodydatashipmentlabelGenerationDatacarrierBillingAccountId != null)
                {
                    labelGenerationDataObject["carrierBillingAccountId"] = SourceExpressionConverter.ConvertToken(bodydatashipmentlabelGenerationDatacarrierBillingAccountId);
                    labelGenerationDataObjectpropCount++;
                }

                if (labelGenerationDataObjectpropCount > 0)
                {
                    shipmentObject["labelGenerationData"] = labelGenerationDataObject;
                    shipmentObjectpropCount++;
                }

                var bolGenerationDataObject = new JObject();
                var bolGenerationDataObjectpropCount = 0;
                var gs1usObject = new JObject();
                var gs1usObjectpropCount = 0;
                if (bodydatashipmentbolGenerationDatags1usnumber != null)
                {
                    gs1usObject["number"] = SourceExpressionConverter.ConvertToken(bodydatashipmentbolGenerationDatags1usnumber);
                    gs1usObjectpropCount++;
                }

                var shipToObject2 = new JObject();
                var shipToObject2propCount = 0;
                if (bodydatashipmentbolGenerationDatags1usshipTovalue != null)
                {
                    shipToObject2["value"] = SourceExpressionConverter.ConvertToken(bodydatashipmentbolGenerationDatags1usshipTovalue);
                    shipToObject2propCount++;
                }

                if (shipToObject2propCount > 0)
                {
                    gs1usObject["shipTo"] = shipToObject2;
                    gs1usObjectpropCount++;
                }

                var billToObject = new JObject();
                var billToObjectpropCount = 0;
                if (bodydatashipmentbolGenerationDatags1usbillTovalue != null)
                {
                    billToObject["value"] = SourceExpressionConverter.ConvertToken(bodydatashipmentbolGenerationDatags1usbillTovalue);
                    billToObjectpropCount++;
                }

                if (billToObjectpropCount > 0)
                {
                    gs1usObject["billTo"] = billToObject;
                    gs1usObjectpropCount++;
                }

                if (gs1usObjectpropCount > 0)
                {
                    bolGenerationDataObject["gs1us"] = gs1usObject;
                    bolGenerationDataObjectpropCount++;
                }

                if (bodydatashipmentbolGenerationDatatype != null)
                {
                    bolGenerationDataObject["type"] = SourceExpressionConverter.ConvertToken(bodydatashipmentbolGenerationDatatype);
                    bolGenerationDataObjectpropCount++;
                }

                if (bolGenerationDataObjectpropCount > 0)
                {
                    shipmentObject["bolGenerationData"] = bolGenerationDataObject;
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentroutingDetailsId != null)
                {
                    shipmentObject["routingDetailsId"] = SourceExpressionConverter.ConvertToken(bodydatashipmentroutingDetailsId);
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentdestinationType != null)
                {
                    shipmentObject["destinationType"] = SourceExpressionConverter.ConvertToken(bodydatashipmentdestinationType);
                    shipmentObjectpropCount++;
                }

                if (bodydatashipmentdestinationRetailer != null)
                {
                    shipmentObject["destinationRetailer"] = SourceExpressionConverter.ConvertToken(bodydatashipmentdestinationRetailer);
                    shipmentObjectpropCount++;
                }

                if (shipmentObjectpropCount > 0)
                {
                    dataObject["shipment"] = shipmentObject;
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetacorrelationId != null)
                {
                    metaObject["correlationId"] = SourceExpressionConverter.ConvertToken(bodymetacorrelationId);
                    metaObjectpropCount++;
                }

                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction UpdateExistingRetailFulfillmentOrder([WorkflowExpression] Func<string> shipmentId, [WorkflowExpression] Func<string> bodydatastate = null, [WorkflowExpression] Func<string> bodydatascac = null, [WorkflowExpression] Func<string> bodydatabolNumber = null, [WorkflowExpression] Func<string> bodymeta = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/shipper/fulfillment/retail/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(shipmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (bodydatastate != null)
                {
                    dataObject["state"] = SourceExpressionConverter.ConvertToken(bodydatastate);
                    dataObjectpropCount++;
                }

                if (bodydatascac != null)
                {
                    dataObject["scac"] = SourceExpressionConverter.ConvertToken(bodydatascac);
                    dataObjectpropCount++;
                }

                if (bodydatabolNumber != null)
                {
                    dataObject["bolNumber"] = SourceExpressionConverter.ConvertToken(bodydatabolNumber);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodymeta != null)
                {
                    body["meta"] = SourceExpressionConverter.ConvertToken(bodymeta);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class FlexeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse> Webhook([WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class bodydatadropoffListInputItem
    {
        [JsonProperty("billOfLading")]
        public string BillOfLading { get; set; }

        [JsonProperty("inventory")]
        public bodydatadropoffListInputItemInventoryTypeItem[] Inventory { get; set; }

        [JsonProperty("expectedInboundShipmentType")]
        public string ExpectedInboundShipmentType { get; set; }

        [JsonProperty("customerUUID")]
        public string CustomerUUID { get; set; }

        [JsonProperty("containerNumber")]
        public string ContainerNumber { get; set; }

        [JsonProperty("valueOfGoods")]
        public bodydatadropoffListInputItemValueOfGoodsType ValueOfGoods { get; set; }

        [JsonProperty("purchaseOrderId")]
        public string PurchaseOrderId { get; set; }

        [JsonProperty("dropoffDate")]
        public string DropoffDate { get; set; }

        [JsonProperty("containerSealNumber")]
        public string ContainerSealNumber { get; set; }

        [JsonProperty("reservation")]
        public bodydatadropoffListInputItemReservationType Reservation { get; set; }

        [JsonProperty("suplierOrVendor")]
        public string SuplierOrVendor { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lpns")]
        public bodydatadropoffListInputItemLpnsTypeItem[] Lpns { get; set; }
    }

    public class bodydatadropoffListInputItemInventoryTypeItem
    {
        [JsonProperty("count")]
        public bodydatadropoffListInputItemInventoryTypeItemCountType Count { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class bodydatadropoffListInputItemInventoryTypeItemCountType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class bodydatadropoffListInputItemValueOfGoodsType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class bodydatadropoffListInputItemReservationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class bodydatadropoffListInputItemLpnsTypeItem
    {
        [JsonProperty("metadata")]
        public bodydatadropoffListInputItemLpnsTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("inventory")]
        public bodydatadropoffListInputItemLpnsTypeItemInventoryTypeItem[] Inventory { get; set; }
    }

    public class bodydatadropoffListInputItemLpnsTypeItemMetadataType
    {
        [JsonProperty("customReference1")]
        public string CustomReference1 { get; set; }

        [JsonProperty("lotCode")]
        public string LotCode { get; set; }

        [JsonProperty("asnNumber")]
        public string AsnNumber { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("extraProperties")]
        public bodydatadropoffListInputItemLpnsTypeItemMetadataTypeExtraPropertiesType ExtraProperties { get; set; }

        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }

        [JsonProperty("originSite")]
        public string OriginSite { get; set; }

        [JsonProperty("customReference2")]
        public string CustomReference2 { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class bodydatadropoffListInputItemLpnsTypeItemMetadataTypeExtraPropertiesType
    {
        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public class bodydatadropoffListInputItemLpnsTypeItemInventoryTypeItem
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }
    }

    public class bodydatashipmentinventoryInputItem
    {
        [JsonProperty("count")]
        public bodydatashipmentinventoryInputItemCountType Count { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("attachments")]
        public bodydatashipmentinventoryInputItemAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class bodydatashipmentinventoryInputItemCountType
    {
        [JsonProperty("amount")]
        public bodydatashipmentinventoryInputItemCountTypeAmountType Amount { get; set; }

        [JsonProperty("unit")]
        public bodydatashipmentinventoryInputItemCountTypeUnitType Unit { get; set; }
    }

    public class bodydatashipmentinventoryInputItemCountTypeAmountType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodydatashipmentinventoryInputItemCountTypeUnitType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodydatashipmentinventoryInputItemAttachmentsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class WebhookResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("signingKey")]
        public string SigningKey { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Flexe;

    public partial class WorkflowManagedActions
    {
        public FlexeActions Flexe(string connectionId) => new FlexeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FlexeTriggers Flexe(string connectionId) => new FlexeTriggers(connectionId);
    }
}