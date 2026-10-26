//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Flexe
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FlexeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NotifyWarehouseOfAnInboundShipmentContainingNonPalletizedProducts(Expression<Func<bodydatadropoffListInputItem[]>> bodydatadropoffList = null, Expression<Func<string>> bodymetacorrelationId = null)
        {
            var __workflow_bodydatadropoffList = WorkflowExpression.Compile(bodydatadropoffList, nameof(bodydatadropoffList), required: false);
            var __workflow_bodymetacorrelationId = WorkflowExpression.Compile(bodymetacorrelationId, nameof(bodymetacorrelationId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/shipper/dropoff/container";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_bodydatadropoffList != null)
                {
                    dataObject["dropoffList"] = ExpressionConverter.ConvertO(__workflow_bodydatadropoffList);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetacorrelationId != null)
                {
                    metaObject["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodymetacorrelationId);
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

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetInboundShipmentsContainingNonPalletizedProducts(Expression<Func<string>> continuationToken, Expression<Func<string>> pageSize, Expression<Func<string>> state, Expression<Func<string>> createdAtFrom, Expression<Func<string>> createdAtTo, Expression<Func<string>> updatedAtFrom, Expression<Func<string>> updatedAtTo, Expression<Func<string>> customerUUID, Expression<Func<string>> purchaseOrder, Expression<Func<string>> reservations)
        {
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: true);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: true);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: true);
            var __workflow_createdAtFrom = WorkflowExpression.Compile(createdAtFrom, nameof(createdAtFrom), required: true);
            var __workflow_createdAtTo = WorkflowExpression.Compile(createdAtTo, nameof(createdAtTo), required: true);
            var __workflow_updatedAtFrom = WorkflowExpression.Compile(updatedAtFrom, nameof(updatedAtFrom), required: true);
            var __workflow_updatedAtTo = WorkflowExpression.Compile(updatedAtTo, nameof(updatedAtTo), required: true);
            var __workflow_customerUUID = WorkflowExpression.Compile(customerUUID, nameof(customerUUID), required: true);
            var __workflow_purchaseOrder = WorkflowExpression.Compile(purchaseOrder, nameof(purchaseOrder), required: true);
            var __workflow_reservations = WorkflowExpression.Compile(reservations, nameof(reservations), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/shipper/dropoff/containers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["continuationToken"] = ExpressionConverter.Convert(__workflow_continuationToken);
                callPayload.Queries["pageSize"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                callPayload.Queries["createdAtFrom"] = ExpressionConverter.Convert(__workflow_createdAtFrom);
                callPayload.Queries["createdAtTo"] = ExpressionConverter.Convert(__workflow_createdAtTo);
                callPayload.Queries["updatedAtFrom"] = ExpressionConverter.Convert(__workflow_updatedAtFrom);
                callPayload.Queries["updatedAtTo"] = ExpressionConverter.Convert(__workflow_updatedAtTo);
                callPayload.Queries["customerUUID"] = ExpressionConverter.Convert(__workflow_customerUUID);
                callPayload.Queries["purchaseOrder"] = ExpressionConverter.Convert(__workflow_purchaseOrder);
                callPayload.Queries["reservations"] = ExpressionConverter.Convert(__workflow_reservations);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RequestACountOfInventoryBySkuFromFlexe(Expression<Func<string>> reservationId = null, Expression<Func<string>> clientRequestId = null, Expression<Func<string>> continuationToken = null, Expression<Func<string>> everInUse = null, Expression<Func<string>> inUseSince = null, Expression<Func<string>> itemIds = null, Expression<Func<string>> skus = null)
        {
            var __workflow_reservationId = WorkflowExpression.Compile(reservationId, nameof(reservationId), required: false);
            var __workflow_clientRequestId = WorkflowExpression.Compile(clientRequestId, nameof(clientRequestId), required: false);
            var __workflow_continuationToken = WorkflowExpression.Compile(continuationToken, nameof(continuationToken), required: false);
            var __workflow_everInUse = WorkflowExpression.Compile(everInUse, nameof(everInUse), required: false);
            var __workflow_inUseSince = WorkflowExpression.Compile(inUseSince, nameof(inUseSince), required: false);
            var __workflow_itemIds = WorkflowExpression.Compile(itemIds, nameof(itemIds), required: false);
            var __workflow_skus = WorkflowExpression.Compile(skus, nameof(skus), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/shipper/inventory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reservationId != null)
                    callPayload.Queries["reservation_id"] = ExpressionConverter.Convert(__workflow_reservationId);
                if (__workflow_clientRequestId != null)
                    callPayload.Queries["client_request_id"] = ExpressionConverter.Convert(__workflow_clientRequestId);
                if (__workflow_continuationToken != null)
                    callPayload.Queries["continuation_token"] = ExpressionConverter.Convert(__workflow_continuationToken);
                if (__workflow_everInUse != null)
                    callPayload.Queries["ever_in_use"] = ExpressionConverter.Convert(__workflow_everInUse);
                if (__workflow_inUseSince != null)
                    callPayload.Queries["in_use_since"] = ExpressionConverter.Convert(__workflow_inUseSince);
                if (__workflow_itemIds != null)
                    callPayload.Queries["item_ids[]"] = ExpressionConverter.Convert(__workflow_itemIds);
                if (__workflow_skus != null)
                    callPayload.Queries["skus[]"] = ExpressionConverter.Convert(__workflow_skus);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateRetailFulfillmentOrder(Expression<Func<string>> bodydatareservationid, Expression<Func<string>> bodydatareservationtype, Expression<Func<string>> bodydatashipmentcustomerUUID, Expression<Func<bodydatashipmentinventoryInputItem[]>> bodydatashipmentinventory, Expression<Func<string>> bodydatashipmenttype, Expression<Func<string>> bodydatashipmentshipToaddressLine1 = null, Expression<Func<string>> bodydatashipmentshipTocountry = null, Expression<Func<string>> bodydatashipmentshipTolocality = null, Expression<Func<string>> bodydatashipmentshipToname = null, Expression<Func<string>> bodydatashipmentshipTopostcode = null, Expression<Func<string>> bodydatashipmentshipToregion = null, Expression<Func<string>> bodydatashipmentshipToaddressLine2 = null, Expression<Func<string>> bodydatashipmentshipToaddressLine3 = null, Expression<Func<string>> bodydatashipmentshipTophone = null, Expression<Func<string>> bodydatashipmentshipToemail = null, Expression<Func<string>> bodydatashipmentshipWithinend = null, Expression<Func<string>> bodydatashipmentshipWithinstart = null, Expression<Func<string>> bodydatashipmentshipmentType = null, Expression<Func<string>> bodydatashipmentshipmentMethod = null, Expression<Func<string>> bodydatashipmentpurchaseOrder = null, Expression<Func<string>> bodydatashipmentrouteBy = null, Expression<Func<string>> bodydatashipmentinstructions = null, Expression<Func<string>> bodydatashipmentlabelGenerationDatacarrier = null, Expression<Func<string>> bodydatashipmentlabelGenerationDatacarrierServiceType = null, Expression<Func<string>> bodydatashipmentlabelGenerationDatacarrierBillingAccountId = null, Expression<Func<string>> bodydatashipmentbolGenerationDatags1usnumber = null, Expression<Func<string>> bodydatashipmentbolGenerationDatags1usshipTovalue = null, Expression<Func<string>> bodydatashipmentbolGenerationDatags1usbillTovalue = null, Expression<Func<string>> bodydatashipmentbolGenerationDatatype = null, Expression<Func<string>> bodydatashipmentroutingDetailsId = null, Expression<Func<string>> bodydatashipmentdestinationType = null, Expression<Func<string>> bodydatashipmentdestinationRetailer = null, Expression<Func<string>> bodymetacorrelationId = null)
        {
            var __workflow_bodydatareservationid = WorkflowExpression.Compile(bodydatareservationid, nameof(bodydatareservationid), required: true);
            var __workflow_bodydatareservationtype = WorkflowExpression.Compile(bodydatareservationtype, nameof(bodydatareservationtype), required: true);
            var __workflow_bodydatashipmentcustomerUUID = WorkflowExpression.Compile(bodydatashipmentcustomerUUID, nameof(bodydatashipmentcustomerUUID), required: true);
            var __workflow_bodydatashipmentinventory = WorkflowExpression.Compile(bodydatashipmentinventory, nameof(bodydatashipmentinventory), required: true);
            var __workflow_bodydatashipmenttype = WorkflowExpression.Compile(bodydatashipmenttype, nameof(bodydatashipmenttype), required: true);
            var __workflow_bodydatashipmentshipToaddressLine1 = WorkflowExpression.Compile(bodydatashipmentshipToaddressLine1, nameof(bodydatashipmentshipToaddressLine1), required: false);
            var __workflow_bodydatashipmentshipTocountry = WorkflowExpression.Compile(bodydatashipmentshipTocountry, nameof(bodydatashipmentshipTocountry), required: false);
            var __workflow_bodydatashipmentshipTolocality = WorkflowExpression.Compile(bodydatashipmentshipTolocality, nameof(bodydatashipmentshipTolocality), required: false);
            var __workflow_bodydatashipmentshipToname = WorkflowExpression.Compile(bodydatashipmentshipToname, nameof(bodydatashipmentshipToname), required: false);
            var __workflow_bodydatashipmentshipTopostcode = WorkflowExpression.Compile(bodydatashipmentshipTopostcode, nameof(bodydatashipmentshipTopostcode), required: false);
            var __workflow_bodydatashipmentshipToregion = WorkflowExpression.Compile(bodydatashipmentshipToregion, nameof(bodydatashipmentshipToregion), required: false);
            var __workflow_bodydatashipmentshipToaddressLine2 = WorkflowExpression.Compile(bodydatashipmentshipToaddressLine2, nameof(bodydatashipmentshipToaddressLine2), required: false);
            var __workflow_bodydatashipmentshipToaddressLine3 = WorkflowExpression.Compile(bodydatashipmentshipToaddressLine3, nameof(bodydatashipmentshipToaddressLine3), required: false);
            var __workflow_bodydatashipmentshipTophone = WorkflowExpression.Compile(bodydatashipmentshipTophone, nameof(bodydatashipmentshipTophone), required: false);
            var __workflow_bodydatashipmentshipToemail = WorkflowExpression.Compile(bodydatashipmentshipToemail, nameof(bodydatashipmentshipToemail), required: false);
            var __workflow_bodydatashipmentshipWithinend = WorkflowExpression.Compile(bodydatashipmentshipWithinend, nameof(bodydatashipmentshipWithinend), required: false);
            var __workflow_bodydatashipmentshipWithinstart = WorkflowExpression.Compile(bodydatashipmentshipWithinstart, nameof(bodydatashipmentshipWithinstart), required: false);
            var __workflow_bodydatashipmentshipmentType = WorkflowExpression.Compile(bodydatashipmentshipmentType, nameof(bodydatashipmentshipmentType), required: false);
            var __workflow_bodydatashipmentshipmentMethod = WorkflowExpression.Compile(bodydatashipmentshipmentMethod, nameof(bodydatashipmentshipmentMethod), required: false);
            var __workflow_bodydatashipmentpurchaseOrder = WorkflowExpression.Compile(bodydatashipmentpurchaseOrder, nameof(bodydatashipmentpurchaseOrder), required: false);
            var __workflow_bodydatashipmentrouteBy = WorkflowExpression.Compile(bodydatashipmentrouteBy, nameof(bodydatashipmentrouteBy), required: false);
            var __workflow_bodydatashipmentinstructions = WorkflowExpression.Compile(bodydatashipmentinstructions, nameof(bodydatashipmentinstructions), required: false);
            var __workflow_bodydatashipmentlabelGenerationDatacarrier = WorkflowExpression.Compile(bodydatashipmentlabelGenerationDatacarrier, nameof(bodydatashipmentlabelGenerationDatacarrier), required: false);
            var __workflow_bodydatashipmentlabelGenerationDatacarrierServiceType = WorkflowExpression.Compile(bodydatashipmentlabelGenerationDatacarrierServiceType, nameof(bodydatashipmentlabelGenerationDatacarrierServiceType), required: false);
            var __workflow_bodydatashipmentlabelGenerationDatacarrierBillingAccountId = WorkflowExpression.Compile(bodydatashipmentlabelGenerationDatacarrierBillingAccountId, nameof(bodydatashipmentlabelGenerationDatacarrierBillingAccountId), required: false);
            var __workflow_bodydatashipmentbolGenerationDatags1usnumber = WorkflowExpression.Compile(bodydatashipmentbolGenerationDatags1usnumber, nameof(bodydatashipmentbolGenerationDatags1usnumber), required: false);
            var __workflow_bodydatashipmentbolGenerationDatags1usshipTovalue = WorkflowExpression.Compile(bodydatashipmentbolGenerationDatags1usshipTovalue, nameof(bodydatashipmentbolGenerationDatags1usshipTovalue), required: false);
            var __workflow_bodydatashipmentbolGenerationDatags1usbillTovalue = WorkflowExpression.Compile(bodydatashipmentbolGenerationDatags1usbillTovalue, nameof(bodydatashipmentbolGenerationDatags1usbillTovalue), required: false);
            var __workflow_bodydatashipmentbolGenerationDatatype = WorkflowExpression.Compile(bodydatashipmentbolGenerationDatatype, nameof(bodydatashipmentbolGenerationDatatype), required: false);
            var __workflow_bodydatashipmentroutingDetailsId = WorkflowExpression.Compile(bodydatashipmentroutingDetailsId, nameof(bodydatashipmentroutingDetailsId), required: false);
            var __workflow_bodydatashipmentdestinationType = WorkflowExpression.Compile(bodydatashipmentdestinationType, nameof(bodydatashipmentdestinationType), required: false);
            var __workflow_bodydatashipmentdestinationRetailer = WorkflowExpression.Compile(bodydatashipmentdestinationRetailer, nameof(bodydatashipmentdestinationRetailer), required: false);
            var __workflow_bodymetacorrelationId = WorkflowExpression.Compile(bodymetacorrelationId, nameof(bodymetacorrelationId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
                reservationObject["id"] = ExpressionConverter.ConvertO(__workflow_bodydatareservationid);
                reservationObjectpropCount++;
                reservationObject["type"] = ExpressionConverter.ConvertO(__workflow_bodydatareservationtype);
                if (reservationObjectpropCount > 0)
                {
                    dataObject["reservation"] = reservationObject;
                    dataObjectpropCount++;
                }

                var shipmentObject = new JObject();
                var shipmentObjectpropCount = 0;
                shipmentObjectpropCount++;
                shipmentObject["customerUUID"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentcustomerUUID);
                shipmentObjectpropCount++;
                shipmentObject["inventory"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentinventory);
                var shipToObject = new JObject();
                var shipToObjectpropCount = 0;
                if (__workflow_bodydatashipmentshipToaddressLine1 != null)
                {
                    shipToObject["addressLine1"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipToaddressLine1);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipTocountry != null)
                {
                    shipToObject["country"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipTocountry);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipTolocality != null)
                {
                    shipToObject["locality"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipTolocality);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipToname != null)
                {
                    shipToObject["name"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipToname);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipTopostcode != null)
                {
                    shipToObject["postcode"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipTopostcode);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipToregion != null)
                {
                    shipToObject["region"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipToregion);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipToaddressLine2 != null)
                {
                    shipToObject["addressLine2"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipToaddressLine2);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipToaddressLine3 != null)
                {
                    shipToObject["addressLine3"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipToaddressLine3);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipTophone != null)
                {
                    shipToObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipTophone);
                    shipToObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipToemail != null)
                {
                    shipToObject["email"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipToemail);
                    shipToObjectpropCount++;
                }

                if (shipToObjectpropCount > 0)
                {
                    shipmentObject["shipTo"] = shipToObject;
                    shipmentObjectpropCount++;
                }

                var shipWithinObject = new JObject();
                var shipWithinObjectpropCount = 0;
                if (__workflow_bodydatashipmentshipWithinend != null)
                {
                    shipWithinObject["end"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipWithinend);
                    shipWithinObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipWithinstart != null)
                {
                    shipWithinObject["start"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipWithinstart);
                    shipWithinObjectpropCount++;
                }

                if (shipWithinObjectpropCount > 0)
                {
                    shipmentObject["shipWithin"] = shipWithinObject;
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentshipmentType != null)
                {
                    shipmentObject["shipmentType"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipmentType);
                    shipmentObjectpropCount++;
                }

                shipmentObjectpropCount++;
                shipmentObject["type"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmenttype);
                if (__workflow_bodydatashipmentshipmentMethod != null)
                {
                    shipmentObject["shipmentMethod"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentshipmentMethod);
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentpurchaseOrder != null)
                {
                    shipmentObject["purchaseOrder"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentpurchaseOrder);
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentrouteBy != null)
                {
                    shipmentObject["routeBy"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentrouteBy);
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentinstructions != null)
                {
                    shipmentObject["instructions"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentinstructions);
                    shipmentObjectpropCount++;
                }

                var labelGenerationDataObject = new JObject();
                var labelGenerationDataObjectpropCount = 0;
                if (__workflow_bodydatashipmentlabelGenerationDatacarrier != null)
                {
                    labelGenerationDataObject["carrier"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentlabelGenerationDatacarrier);
                    labelGenerationDataObjectpropCount++;
                }

                if (__workflow_bodydatashipmentlabelGenerationDatacarrierServiceType != null)
                {
                    labelGenerationDataObject["carrierServiceType"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentlabelGenerationDatacarrierServiceType);
                    labelGenerationDataObjectpropCount++;
                }

                if (__workflow_bodydatashipmentlabelGenerationDatacarrierBillingAccountId != null)
                {
                    labelGenerationDataObject["carrierBillingAccountId"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentlabelGenerationDatacarrierBillingAccountId);
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
                if (__workflow_bodydatashipmentbolGenerationDatags1usnumber != null)
                {
                    gs1usObject["number"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentbolGenerationDatags1usnumber);
                    gs1usObjectpropCount++;
                }

                var shipToObject2 = new JObject();
                var shipToObject2propCount = 0;
                if (__workflow_bodydatashipmentbolGenerationDatags1usshipTovalue != null)
                {
                    shipToObject2["value"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentbolGenerationDatags1usshipTovalue);
                    shipToObject2propCount++;
                }

                if (shipToObject2propCount > 0)
                {
                    gs1usObject["shipTo"] = shipToObject2;
                    gs1usObjectpropCount++;
                }

                var billToObject = new JObject();
                var billToObjectpropCount = 0;
                if (__workflow_bodydatashipmentbolGenerationDatags1usbillTovalue != null)
                {
                    billToObject["value"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentbolGenerationDatags1usbillTovalue);
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

                if (__workflow_bodydatashipmentbolGenerationDatatype != null)
                {
                    bolGenerationDataObject["type"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentbolGenerationDatatype);
                    bolGenerationDataObjectpropCount++;
                }

                if (bolGenerationDataObjectpropCount > 0)
                {
                    shipmentObject["bolGenerationData"] = bolGenerationDataObject;
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentroutingDetailsId != null)
                {
                    shipmentObject["routingDetailsId"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentroutingDetailsId);
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentdestinationType != null)
                {
                    shipmentObject["destinationType"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentdestinationType);
                    shipmentObjectpropCount++;
                }

                if (__workflow_bodydatashipmentdestinationRetailer != null)
                {
                    shipmentObject["destinationRetailer"] = ExpressionConverter.ConvertO(__workflow_bodydatashipmentdestinationRetailer);
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
                if (__workflow_bodymetacorrelationId != null)
                {
                    metaObject["correlationId"] = ExpressionConverter.ConvertO(__workflow_bodymetacorrelationId);
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

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "flexe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateExistingRetailFulfillmentOrder(Expression<Func<string>> shipmentId, Expression<Func<string>> bodydatastate = null, Expression<Func<string>> bodydatascac = null, Expression<Func<string>> bodydatabolNumber = null, Expression<Func<string>> bodymeta = null)
        {
            var __workflow_shipmentId = WorkflowExpression.Compile(shipmentId, nameof(shipmentId), required: true);
            var __workflow_bodydatastate = WorkflowExpression.Compile(bodydatastate, nameof(bodydatastate), required: false);
            var __workflow_bodydatascac = WorkflowExpression.Compile(bodydatascac, nameof(bodydatascac), required: false);
            var __workflow_bodydatabolNumber = WorkflowExpression.Compile(bodydatabolNumber, nameof(bodydatabolNumber), required: false);
            var __workflow_bodymeta = WorkflowExpression.Compile(bodymeta, nameof(bodymeta), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/shipper/fulfillment/retail/{0}", __workflow_shipmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (__workflow_bodydatastate != null)
                {
                    dataObject["state"] = ExpressionConverter.ConvertO(__workflow_bodydatastate);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatascac != null)
                {
                    dataObject["scac"] = ExpressionConverter.ConvertO(__workflow_bodydatascac);
                    dataObjectpropCount++;
                }

                if (__workflow_bodydatabolNumber != null)
                {
                    dataObject["bolNumber"] = ExpressionConverter.ConvertO(__workflow_bodydatabolNumber);
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (__workflow_bodymeta != null)
                {
                    body["meta"] = ExpressionConverter.ConvertO(__workflow_bodymeta);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class FlexeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse, ApiConnectionTriggerConfiguration> Webhook(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<WebhookResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            });
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