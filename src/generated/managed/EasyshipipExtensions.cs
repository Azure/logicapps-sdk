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
        public IBodyWorkflowAction<GetRatesTaxesResponse, ApiConnectionActionConfiguration> GetRatesTaxes(Expression<Func<GetRatesTaxesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetRatesTaxesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/rates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetRatesTaxesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<ListAllShipmentsResponse, ApiConnectionActionConfiguration> ListAllShipments(Expression<Func<string>> easyshipShipmentId = null, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null, Expression<Func<string>> createdAtFrom = null, Expression<Func<string>> createdAtTo = null, Expression<Func<string>> confirmedAtFrom = null, Expression<Func<string>> confirmAtTo = null, Expression<Func<string>> labelGeneratedAtFrom = null, Expression<Func<string>> labelGeneratedAtTo = null, Expression<Func<string>> shipmentState = null, Expression<Func<string>> pickupState = null, Expression<Func<string>> deliveryState = null, Expression<Func<string>> labelState = null, Expression<Func<string>> warehouseState = null)
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
            return new DeferredBodyAction<ListAllShipmentsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<CreateAShipmentResponse, ApiConnectionActionConfiguration> CreateAShipment(Expression<Func<CreateAShipmentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAShipmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/shipments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<BuyAShipmentLabelResponse, ApiConnectionActionConfiguration> BuyAShipmentLabel(Expression<Func<BuyAShipmentLabelInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<BuyAShipmentLabelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/label/v1/labels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BuyAShipmentLabelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<DeleteAShipmentResponse, ApiConnectionActionConfiguration> DeleteAShipment(Expression<Func<string>> easyshipShipmentId)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            return new DeferredBodyAction<DeleteAShipmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/shipment/v1/shipments/{0}", __workflow_easyshipShipmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<UpdateAShipmentResponse, ApiConnectionActionConfiguration> UpdateAShipment(Expression<Func<string>> easyshipShipmentId, Expression<Func<UpdateAShipmentInput>> body)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateAShipmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/shipment/v1/shipments/{0}", __workflow_easyshipShipmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateAShipmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetAShipmentResponse, ApiConnectionActionConfiguration> GetAShipment(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> format = null, Expression<Func<string>> label = null, Expression<Func<string>> commercialInvoice = null, Expression<Func<string>> packingSlip = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_label = WorkflowExpression.Compile(label, nameof(label), required: false);
            var __workflow_commercialInvoice = WorkflowExpression.Compile(commercialInvoice, nameof(commercialInvoice), required: false);
            var __workflow_packingSlip = WorkflowExpression.Compile(packingSlip, nameof(packingSlip), required: false);
            return new DeferredBodyAction<GetAShipmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/shipments/{0}", __workflow_easyshipShipmentId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<UpdateWarehouseStateResponse, ApiConnectionActionConfiguration> UpdateWarehouseState(Expression<Func<UpdateWarehouseStateInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateWarehouseStateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/shipments/warehouse_state";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateWarehouseStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetAvailablePickupSlotsResponse, ApiConnectionActionConfiguration> GetAvailablePickupSlots(Expression<Func<string>> courierId)
        {
            var __workflow_courierId = WorkflowExpression.Compile(courierId, nameof(courierId), required: true);
            return new DeferredBodyAction<GetAvailablePickupSlotsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/pickup/v1/pickup_slots/{0}", __workflow_courierId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAvailablePickupSlotsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<RequestAPickupResponse, ApiConnectionActionConfiguration> RequestAPickup(Expression<Func<RequestAPickupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RequestAPickupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pickup/v1/pickups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RequestAPickupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<GetCheckpointsResponse, ApiConnectionActionConfiguration> GetCheckpoints(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_platformOrderNumber = WorkflowExpression.Compile(platformOrderNumber, nameof(platformOrderNumber), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetCheckpointsResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetStatusResponse, ApiConnectionActionConfiguration> GetStatus(Expression<Func<string>> easyshipShipmentId, Expression<Func<string>> platformOrderNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_easyshipShipmentId = WorkflowExpression.Compile(easyshipShipmentId, nameof(easyshipShipmentId), required: true);
            var __workflow_platformOrderNumber = WorkflowExpression.Compile(platformOrderNumber, nameof(platformOrderNumber), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GetStatusResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetItemCategoriesResponse, ApiConnectionActionConfiguration> GetItemCategories()
        {
            return new DeferredBodyAction<GetItemCategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reference/v1/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetItemCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easyshipip")]
        public IBodyWorkflowAction<ListAllBoxesResponse, ApiConnectionActionConfiguration> ListAllBoxes()
        {
            return new DeferredBodyAction<ListAllBoxesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/boxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAllBoxesResponse>(callPayload);
            });
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

    public class GetRatesTaxesInput
    {
        [JsonProperty("origin_address")]
        public GetRatesTaxesInputOriginAddressType OriginAddress { get; set; }

        [JsonProperty("destination_address")]
        public GetRatesTaxesInputDestinationAddressType DestinationAddress { get; set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; set; }

        [JsonProperty("insurance")]
        public GetRatesTaxesInputInsuranceType Insurance { get; set; }

        [JsonProperty("courier_selection")]
        public GetRatesTaxesInputCourierSelectionType CourierSelection { get; set; }

        [JsonProperty("shipping_settings")]
        public GetRatesTaxesInputShippingSettingsType ShippingSettings { get; set; }

        [JsonProperty("parcels")]
        public GetRatesTaxesInputParcelsTypeItem[] Parcels { get; set; }
    }

    public class GetRatesTaxesInputOriginAddressType
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
    }

    public class GetRatesTaxesInputDestinationAddressType
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
    }

    public class GetRatesTaxesInputInsuranceType
    {
        [JsonProperty("is_insured")]
        public bool? IsInsured { get; set; }

        [JsonProperty("insured_amount")]
        public int? InsuredAmount { get; set; }

        [JsonProperty("insured_currency")]
        public string InsuredCurrency { get; set; }
    }

    public class GetRatesTaxesInputCourierSelectionType
    {
        [JsonProperty("apply_shipping_rules")]
        public bool? ApplyShippingRules { get; set; }
    }

    public class GetRatesTaxesInputShippingSettingsType
    {
        [JsonProperty("units")]
        public GetRatesTaxesInputShippingSettingsTypeUnitsType Units { get; set; }

        [JsonProperty("output_currency")]
        public string OutputCurrency { get; set; }
    }

    public class GetRatesTaxesInputShippingSettingsTypeUnitsType
    {
        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        public string Dimensions { get; set; }
    }

    public class GetRatesTaxesInputParcelsTypeItem
    {
        [JsonProperty("total_actual_weight")]
        public double? TotalActualWeight { get; set; }

        [JsonProperty("box")]
        public GetRatesTaxesInputParcelsTypeItemBoxType Box { get; set; }

        [JsonProperty("items")]
        public GetRatesTaxesInputParcelsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class GetRatesTaxesInputParcelsTypeItemBoxType
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }

    public class GetRatesTaxesInputParcelsTypeItemItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("dimensions")]
        public GetRatesTaxesInputParcelsTypeItemItemsTypeItemDimensionsType Dimensions { get; set; }

        [JsonProperty("actual_weight")]
        public int? ActualWeight { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int? DeclaredCustomsValue { get; set; }
    }

    public class GetRatesTaxesInputParcelsTypeItemItemsTypeItemDimensionsType
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

    public class CreateAShipmentInput
    {
        [JsonProperty("origin_address")]
        public CreateAShipmentInputOriginAddressType OriginAddress { get; set; }

        [JsonProperty("sender_address")]
        public CreateAShipmentInputSenderAddressType SenderAddress { get; set; }

        [JsonProperty("return_address")]
        public CreateAShipmentInputReturnAddressType ReturnAddress { get; set; }

        [JsonProperty("destination_address")]
        public CreateAShipmentInputDestinationAddressType DestinationAddress { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("set_as_residential")]
        public bool? SetAsResidential { get; set; }

        [JsonProperty("consignee_tax_id")]
        public string ConsigneeTaxId { get; set; }

        [JsonProperty("eei_reference")]
        public string EeiReference { get; set; }

        [JsonProperty("incoterms")]
        public string Incoterms { get; set; }

        [JsonProperty("insurance")]
        public CreateAShipmentInputInsuranceType Insurance { get; set; }

        [JsonProperty("order_data")]
        public CreateAShipmentInputOrderDataType OrderData { get; set; }

        [JsonProperty("courier_selection")]
        public CreateAShipmentInputCourierSelectionType CourierSelection { get; set; }

        [JsonProperty("shipping_settings")]
        public CreateAShipmentInputShippingSettingsType ShippingSettings { get; set; }

        [JsonProperty("parcels")]
        public CreateAShipmentInputParcelsTypeItem[] Parcels { get; set; }
    }

    public class CreateAShipmentInputOriginAddressType
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

    public class CreateAShipmentInputSenderAddressType
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

    public class CreateAShipmentInputReturnAddressType
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

    public class CreateAShipmentInputDestinationAddressType
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

    public class CreateAShipmentInputInsuranceType
    {
        [JsonProperty("is_insured")]
        public bool? IsInsured { get; set; }

        [JsonProperty("insured_amount")]
        public int? InsuredAmount { get; set; }

        [JsonProperty("insured_currency")]
        public string InsuredCurrency { get; set; }
    }

    public class CreateAShipmentInputOrderDataType
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

    public class CreateAShipmentInputCourierSelectionType
    {
        [JsonProperty("selected_courier_id")]
        public string SelectedCourierId { get; set; }

        [JsonProperty("allow_courier_fallback")]
        public bool? AllowCourierFallback { get; set; }

        [JsonProperty("apply_shipping_rules")]
        public bool? ApplyShippingRules { get; set; }
    }

    public class CreateAShipmentInputShippingSettingsType
    {
        [JsonProperty("units")]
        public CreateAShipmentInputShippingSettingsTypeUnitsType Units { get; set; }

        [JsonProperty("printing_options")]
        public CreateAShipmentInputShippingSettingsTypePrintingOptionsType PrintingOptions { get; set; }

        [JsonProperty("buy_label")]
        public bool? BuyLabel { get; set; }

        [JsonProperty("buy_label_synchronous")]
        public bool? BuyLabelSynchronous { get; set; }
    }

    public class CreateAShipmentInputShippingSettingsTypeUnitsType
    {
        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        public string Dimensions { get; set; }
    }

    public class CreateAShipmentInputShippingSettingsTypePrintingOptionsType
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("commercial_invoice")]
        public string CommercialInvoice { get; set; }

        [JsonProperty("packing_slip")]
        public string PackingSlip { get; set; }
    }

    public class CreateAShipmentInputParcelsTypeItem
    {
        [JsonProperty("total_actual_weight")]
        public double? TotalActualWeight { get; set; }

        [JsonProperty("box")]
        public CreateAShipmentInputParcelsTypeItemBoxType Box { get; set; }

        [JsonProperty("items")]
        public CreateAShipmentInputParcelsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class CreateAShipmentInputParcelsTypeItemBoxType
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }
    }

    public class CreateAShipmentInputParcelsTypeItemItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("dimensions")]
        public CreateAShipmentInputParcelsTypeItemItemsTypeItemDimensionsType Dimensions { get; set; }

        [JsonProperty("actual_weight")]
        public int? ActualWeight { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int? DeclaredCustomsValue { get; set; }
    }

    public class CreateAShipmentInputParcelsTypeItemItemsTypeItemDimensionsType
    {
        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
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

    public class BuyAShipmentLabelInput
    {
        [JsonProperty("shipments")]
        public BuyAShipmentLabelInputShipmentsTypeItem[] Shipments { get; set; }
    }

    public class BuyAShipmentLabelInputShipmentsTypeItem
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

    public class UpdateAShipmentInput
    {
        [JsonProperty("destination_country_alpha2")]
        public string DestinationCountryAlpha2 { get; set; }

        [JsonProperty("destination_city")]
        public string DestinationCity { get; set; }

        [JsonProperty("destination_name")]
        public string DestinationName { get; set; }

        [JsonProperty("destination_address_line_1")]
        public string DestinationAddressLine1 { get; set; }

        [JsonProperty("destination_phone_number")]
        public string DestinationPhoneNumber { get; set; }

        [JsonProperty("items")]
        public UpdateAShipmentInputItemsTypeItem[] Items { get; set; }

        [JsonProperty("platform_name")]
        public string PlatformName { get; set; }

        [JsonProperty("platform_order_number")]
        public string PlatformOrderNumber { get; set; }

        [JsonProperty("taxes_duties_paid_by")]
        public string TaxesDutiesPaidBy { get; set; }

        [JsonProperty("is_insured")]
        public bool? IsInsured { get; set; }

        [JsonProperty("selected_courier_id")]
        public string SelectedCourierId { get; set; }

        [JsonProperty("destination_postal_code")]
        public int? DestinationPostalCode { get; set; }

        [JsonProperty("destination_state")]
        public string DestinationState { get; set; }

        [JsonProperty("destination_address_line_2")]
        public string DestinationAddressLine2 { get; set; }

        [JsonProperty("destination_email_address")]
        public string DestinationEmailAddress { get; set; }
    }

    public class UpdateAShipmentInputItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("actual_weight")]
        public double? ActualWeight { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("declared_currency")]
        public string DeclaredCurrency { get; set; }

        [JsonProperty("declared_customs_value")]
        public int? DeclaredCustomsValue { get; set; }

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

    public class UpdateWarehouseStateInput
    {
        [JsonProperty("shipments")]
        public UpdateWarehouseStateInputShipmentsTypeItem[] Shipments { get; set; }
    }

    public class UpdateWarehouseStateInputShipmentsTypeItem
    {
        [JsonProperty("easyship_shipment_id")]
        public string EasyshipShipmentId { get; set; }

        [JsonProperty("warehouse_state")]
        public string WarehouseState { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("metadata")]
        public UpdateWarehouseStateInputShipmentsTypeItemMetadataType Metadata { get; set; }
    }

    public class UpdateWarehouseStateInputShipmentsTypeItemMetadataType
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

    public class RequestAPickupInput
    {
        [JsonProperty("courier_id")]
        public string CourierId { get; set; }

        [JsonProperty("preferred_date")]
        public string PreferredDate { get; set; }

        [JsonProperty("preferred_max_time")]
        public string PreferredMaxTime { get; set; }

        [JsonProperty("preferred_min_time")]
        public string PreferredMinTime { get; set; }

        [JsonProperty("easyship_shipment_ids")]
        public string[] EasyshipShipmentIds { get; set; }
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