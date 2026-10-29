//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Squarebusinessip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SquarebusinessipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BankAccountListResponse, ApiConnectionActionConfiguration> BankAccountList(Expression<Func<string>> cursor = null, Expression<Func<int>> limit = null, Expression<Func<string>> locationId = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            return new DeferredBodyAction<BankAccountListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bank-accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                return new ApiConnectionAction<BankAccountListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingCreateResponse, ApiConnectionActionConfiguration> BookingCreate(Expression<Func<string>> bodybookingcustomerId = null, Expression<Func<string>> bodybookingstartAt = null, Expression<Func<string>> bodybookinglocationId = null, Expression<Func<bodybookingappointmentSegmentsInputItem[]>> bodybookingappointmentSegments = null)
        {
            var __workflow_bodybookingcustomerId = WorkflowExpression.Compile(bodybookingcustomerId, nameof(bodybookingcustomerId), required: false);
            var __workflow_bodybookingstartAt = WorkflowExpression.Compile(bodybookingstartAt, nameof(bodybookingstartAt), required: false);
            var __workflow_bodybookinglocationId = WorkflowExpression.Compile(bodybookinglocationId, nameof(bodybookinglocationId), required: false);
            var __workflow_bodybookingappointmentSegments = WorkflowExpression.Compile(bodybookingappointmentSegments, nameof(bodybookingappointmentSegments), required: false);
            return new DeferredBodyAction<BookingCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bookings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var bookingObject = new JObject();
                var bookingObjectpropCount = 0;
                if (__workflow_bodybookingcustomerId != null)
                {
                    bookingObject["customer_id"] = ExpressionConverter.ConvertO(__workflow_bodybookingcustomerId);
                    bookingObjectpropCount++;
                }

                if (__workflow_bodybookingstartAt != null)
                {
                    bookingObject["start_at"] = ExpressionConverter.ConvertO(__workflow_bodybookingstartAt);
                    bookingObjectpropCount++;
                }

                if (__workflow_bodybookinglocationId != null)
                {
                    bookingObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodybookinglocationId);
                    bookingObjectpropCount++;
                }

                if (__workflow_bodybookingappointmentSegments != null)
                {
                    bookingObject["appointment_segments"] = ExpressionConverter.ConvertO(__workflow_bodybookingappointmentSegments);
                    bookingObjectpropCount++;
                }

                if (bookingObjectpropCount > 0)
                {
                    body["booking"] = bookingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BookingCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingAvailabilityResponse, ApiConnectionActionConfiguration> BookingAvailability(Expression<Func<string>> bodyqueryfilterstartAtRangestartAt = null, Expression<Func<string>> bodyqueryfilterstartAtRangeendAt = null, Expression<Func<string>> bodyqueryfilterlocationId = null, Expression<Func<bodyqueryfiltersegmentFiltersInputItem[]>> bodyqueryfiltersegmentFilters = null)
        {
            var __workflow_bodyqueryfilterstartAtRangestartAt = WorkflowExpression.Compile(bodyqueryfilterstartAtRangestartAt, nameof(bodyqueryfilterstartAtRangestartAt), required: false);
            var __workflow_bodyqueryfilterstartAtRangeendAt = WorkflowExpression.Compile(bodyqueryfilterstartAtRangeendAt, nameof(bodyqueryfilterstartAtRangeendAt), required: false);
            var __workflow_bodyqueryfilterlocationId = WorkflowExpression.Compile(bodyqueryfilterlocationId, nameof(bodyqueryfilterlocationId), required: false);
            var __workflow_bodyqueryfiltersegmentFilters = WorkflowExpression.Compile(bodyqueryfiltersegmentFilters, nameof(bodyqueryfiltersegmentFilters), required: false);
            return new DeferredBodyAction<BookingAvailabilityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bookings/availability/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var startAtRangeObject = new JObject();
                var startAtRangeObjectpropCount = 0;
                if (__workflow_bodyqueryfilterstartAtRangestartAt != null)
                {
                    startAtRangeObject["start_at"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterstartAtRangestartAt);
                    startAtRangeObjectpropCount++;
                }

                if (__workflow_bodyqueryfilterstartAtRangeendAt != null)
                {
                    startAtRangeObject["end_at"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterstartAtRangeendAt);
                    startAtRangeObjectpropCount++;
                }

                if (startAtRangeObjectpropCount > 0)
                {
                    filterObject["start_at_range"] = startAtRangeObject;
                    filterObjectpropCount++;
                }

                if (__workflow_bodyqueryfilterlocationId != null)
                {
                    filterObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterlocationId);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyqueryfiltersegmentFilters != null)
                {
                    filterObject["segment_filters"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfiltersegmentFilters);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BookingAvailabilityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingRetrieveProfileResponse, ApiConnectionActionConfiguration> BookingRetrieveProfile()
        {
            return new DeferredBodyAction<BookingRetrieveProfileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bookings/business-booking-profile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BookingRetrieveProfileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingListTeamProfilesResponse, ApiConnectionActionConfiguration> BookingListTeamProfiles(Expression<Func<bool>> bookableOnly = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null, Expression<Func<string>> locationId = null)
        {
            var __workflow_bookableOnly = WorkflowExpression.Compile(bookableOnly, nameof(bookableOnly), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            return new DeferredBodyAction<BookingListTeamProfilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bookings/team-member-booking-profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_bookableOnly != null)
                    callPayload.Queries["bookable_only"] = ExpressionConverter.Convert(__workflow_bookableOnly);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                return new ApiConnectionAction<BookingListTeamProfilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CashDrawerListShiftsResponse, ApiConnectionActionConfiguration> CashDrawerListShifts(Expression<Func<string>> locationId = null, Expression<Func<sortOrderInput>> sortOrder = null, Expression<Func<string>> beginTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            var __workflow_beginTime = WorkflowExpression.Compile(beginTime, nameof(beginTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<CashDrawerListShiftsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cash-drawers/shifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                if (__workflow_beginTime != null)
                    callPayload.Queries["begin_time"] = ExpressionConverter.Convert(__workflow_beginTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<CashDrawerListShiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CashDrawerRetrieveShiftResponse, ApiConnectionActionConfiguration> CashDrawerRetrieveShift(Expression<Func<string>> shiftId, Expression<Func<string>> locationId)
        {
            var __workflow_shiftId = WorkflowExpression.Compile(shiftId, nameof(shiftId), required: true);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredBodyAction<CashDrawerRetrieveShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cash-drawers/shifts/{0}", __workflow_shiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                return new ApiConnectionAction<CashDrawerRetrieveShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CashDrawerListEventsResponse, ApiConnectionActionConfiguration> CashDrawerListEvents(Expression<Func<string>> shiftId, Expression<Func<string>> locationId, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null)
        {
            var __workflow_shiftId = WorkflowExpression.Compile(shiftId, nameof(shiftId), required: true);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<CashDrawerListEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/cash-drawers/shifts/{0}/events", __workflow_shiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<CashDrawerListEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CheckoutCreateResponse, ApiConnectionActionConfiguration> CheckoutCreate(Expression<Func<string>> locationId, Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodyredirectUrl = null, Expression<Func<string>> bodyorderidempotencyKey = null, Expression<Func<string>> bodyorderorderlocationId = null, Expression<Func<string>> bodyorderordercustomerId = null, Expression<Func<string>> bodyorderorderreferenceId = null, Expression<Func<bodyorderorderlineItemsInputItem[]>> bodyorderorderlineItems = null, Expression<Func<bodyorderordertaxesInputItem[]>> bodyorderordertaxes = null, Expression<Func<bodyorderorderdiscountsInputItem[]>> bodyorderorderdiscounts = null, Expression<Func<bodyadditionalRecipientsInputItem[]>> bodyadditionalRecipients = null, Expression<Func<bool>> bodyaskForShippingAddress = null, Expression<Func<string>> bodymerchantSupportEmail = null, Expression<Func<string>> bodyprePopulateBuyerEmail = null, Expression<Func<string>> bodyprePopulateShippingAddressaddressLine1 = null, Expression<Func<string>> bodyprePopulateShippingAddressaddressLine2 = null, Expression<Func<string>> bodyprePopulateShippingAddresslocality = null, Expression<Func<string>> bodyprePopulateShippingAddressadministrativeDistrictLevel1 = null, Expression<Func<string>> bodyprePopulateShippingAddresspostalCode = null, Expression<Func<string>> bodyprePopulateShippingAddresscountry = null, Expression<Func<string>> bodyprePopulateShippingAddressfirstName = null, Expression<Func<string>> bodyprePopulateShippingAddresslastName = null)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodyredirectUrl = WorkflowExpression.Compile(bodyredirectUrl, nameof(bodyredirectUrl), required: false);
            var __workflow_bodyorderidempotencyKey = WorkflowExpression.Compile(bodyorderidempotencyKey, nameof(bodyorderidempotencyKey), required: false);
            var __workflow_bodyorderorderlocationId = WorkflowExpression.Compile(bodyorderorderlocationId, nameof(bodyorderorderlocationId), required: false);
            var __workflow_bodyorderordercustomerId = WorkflowExpression.Compile(bodyorderordercustomerId, nameof(bodyorderordercustomerId), required: false);
            var __workflow_bodyorderorderreferenceId = WorkflowExpression.Compile(bodyorderorderreferenceId, nameof(bodyorderorderreferenceId), required: false);
            var __workflow_bodyorderorderlineItems = WorkflowExpression.Compile(bodyorderorderlineItems, nameof(bodyorderorderlineItems), required: false);
            var __workflow_bodyorderordertaxes = WorkflowExpression.Compile(bodyorderordertaxes, nameof(bodyorderordertaxes), required: false);
            var __workflow_bodyorderorderdiscounts = WorkflowExpression.Compile(bodyorderorderdiscounts, nameof(bodyorderorderdiscounts), required: false);
            var __workflow_bodyadditionalRecipients = WorkflowExpression.Compile(bodyadditionalRecipients, nameof(bodyadditionalRecipients), required: false);
            var __workflow_bodyaskForShippingAddress = WorkflowExpression.Compile(bodyaskForShippingAddress, nameof(bodyaskForShippingAddress), required: false);
            var __workflow_bodymerchantSupportEmail = WorkflowExpression.Compile(bodymerchantSupportEmail, nameof(bodymerchantSupportEmail), required: false);
            var __workflow_bodyprePopulateBuyerEmail = WorkflowExpression.Compile(bodyprePopulateBuyerEmail, nameof(bodyprePopulateBuyerEmail), required: false);
            var __workflow_bodyprePopulateShippingAddressaddressLine1 = WorkflowExpression.Compile(bodyprePopulateShippingAddressaddressLine1, nameof(bodyprePopulateShippingAddressaddressLine1), required: false);
            var __workflow_bodyprePopulateShippingAddressaddressLine2 = WorkflowExpression.Compile(bodyprePopulateShippingAddressaddressLine2, nameof(bodyprePopulateShippingAddressaddressLine2), required: false);
            var __workflow_bodyprePopulateShippingAddresslocality = WorkflowExpression.Compile(bodyprePopulateShippingAddresslocality, nameof(bodyprePopulateShippingAddresslocality), required: false);
            var __workflow_bodyprePopulateShippingAddressadministrativeDistrictLevel1 = WorkflowExpression.Compile(bodyprePopulateShippingAddressadministrativeDistrictLevel1, nameof(bodyprePopulateShippingAddressadministrativeDistrictLevel1), required: false);
            var __workflow_bodyprePopulateShippingAddresspostalCode = WorkflowExpression.Compile(bodyprePopulateShippingAddresspostalCode, nameof(bodyprePopulateShippingAddresspostalCode), required: false);
            var __workflow_bodyprePopulateShippingAddresscountry = WorkflowExpression.Compile(bodyprePopulateShippingAddresscountry, nameof(bodyprePopulateShippingAddresscountry), required: false);
            var __workflow_bodyprePopulateShippingAddressfirstName = WorkflowExpression.Compile(bodyprePopulateShippingAddressfirstName, nameof(bodyprePopulateShippingAddressfirstName), required: false);
            var __workflow_bodyprePopulateShippingAddresslastName = WorkflowExpression.Compile(bodyprePopulateShippingAddresslastName, nameof(bodyprePopulateShippingAddresslastName), required: false);
            return new DeferredBodyAction<CheckoutCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}/checkouts", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                if (__workflow_bodyredirectUrl != null)
                {
                    body["redirect_url"] = ExpressionConverter.ConvertO(__workflow_bodyredirectUrl);
                    bodypropCount++;
                }

                var orderObject = new JObject();
                var orderObjectpropCount = 0;
                if (__workflow_bodyorderidempotencyKey != null)
                {
                    orderObject["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyorderidempotencyKey);
                    orderObjectpropCount++;
                }

                var orderObject2 = new JObject();
                var orderObject2propCount = 0;
                if (__workflow_bodyorderorderlocationId != null)
                {
                    orderObject2["location_id"] = ExpressionConverter.ConvertO(__workflow_bodyorderorderlocationId);
                    orderObject2propCount++;
                }

                if (__workflow_bodyorderordercustomerId != null)
                {
                    orderObject2["customer_id"] = ExpressionConverter.ConvertO(__workflow_bodyorderordercustomerId);
                    orderObject2propCount++;
                }

                if (__workflow_bodyorderorderreferenceId != null)
                {
                    orderObject2["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyorderorderreferenceId);
                    orderObject2propCount++;
                }

                if (__workflow_bodyorderorderlineItems != null)
                {
                    orderObject2["line_items"] = ExpressionConverter.ConvertO(__workflow_bodyorderorderlineItems);
                    orderObject2propCount++;
                }

                if (__workflow_bodyorderordertaxes != null)
                {
                    orderObject2["taxes"] = ExpressionConverter.ConvertO(__workflow_bodyorderordertaxes);
                    orderObject2propCount++;
                }

                if (__workflow_bodyorderorderdiscounts != null)
                {
                    orderObject2["discounts"] = ExpressionConverter.ConvertO(__workflow_bodyorderorderdiscounts);
                    orderObject2propCount++;
                }

                if (orderObject2propCount > 0)
                {
                    orderObject["order"] = orderObject2;
                    orderObjectpropCount++;
                }

                if (orderObjectpropCount > 0)
                {
                    body["order"] = orderObject;
                    bodypropCount++;
                }

                if (__workflow_bodyadditionalRecipients != null)
                {
                    body["additional_recipients"] = ExpressionConverter.ConvertO(__workflow_bodyadditionalRecipients);
                    bodypropCount++;
                }

                if (__workflow_bodyaskForShippingAddress != null)
                {
                    body["ask_for_shipping_address"] = ExpressionConverter.ConvertO(__workflow_bodyaskForShippingAddress);
                    bodypropCount++;
                }

                if (__workflow_bodymerchantSupportEmail != null)
                {
                    body["merchant_support_email"] = ExpressionConverter.ConvertO(__workflow_bodymerchantSupportEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyprePopulateBuyerEmail != null)
                {
                    body["pre_populate_buyer_email"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateBuyerEmail);
                    bodypropCount++;
                }

                var prePopulateShippingAddressObject = new JObject();
                var prePopulateShippingAddressObjectpropCount = 0;
                if (__workflow_bodyprePopulateShippingAddressaddressLine1 != null)
                {
                    prePopulateShippingAddressObject["address_line_1"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddressaddressLine1);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddressaddressLine2 != null)
                {
                    prePopulateShippingAddressObject["address_line_2"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddressaddressLine2);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddresslocality != null)
                {
                    prePopulateShippingAddressObject["locality"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddresslocality);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddressadministrativeDistrictLevel1 != null)
                {
                    prePopulateShippingAddressObject["administrative_district_level_1"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddressadministrativeDistrictLevel1);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddresspostalCode != null)
                {
                    prePopulateShippingAddressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddresspostalCode);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddresscountry != null)
                {
                    prePopulateShippingAddressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddresscountry);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddressfirstName != null)
                {
                    prePopulateShippingAddressObject["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddressfirstName);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (__workflow_bodyprePopulateShippingAddresslastName != null)
                {
                    prePopulateShippingAddressObject["last_name"] = ExpressionConverter.ConvertO(__workflow_bodyprePopulateShippingAddresslastName);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (prePopulateShippingAddressObjectpropCount > 0)
                {
                    body["pre_populate_shipping_address"] = prePopulateShippingAddressObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CheckoutCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceListResponse, ApiConnectionActionConfiguration> DeviceList(Expression<Func<string>> cursor = null, Expression<Func<string>> locationId = null, Expression<Func<string>> productType = null, Expression<Func<statusInput>> status = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_productType = WorkflowExpression.Compile(productType, nameof(productType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<DeviceListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/devices/codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_productType != null)
                    callPayload.Queries["product_type"] = ExpressionConverter.Convert(__workflow_productType);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<DeviceListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceCreateResponse, ApiConnectionActionConfiguration> DeviceCreate(Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodydeviceCodename = null, Expression<Func<string>> bodydeviceCodelocationId = null, Expression<Func<string>> bodydeviceCodeproductType = null)
        {
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodydeviceCodename = WorkflowExpression.Compile(bodydeviceCodename, nameof(bodydeviceCodename), required: false);
            var __workflow_bodydeviceCodelocationId = WorkflowExpression.Compile(bodydeviceCodelocationId, nameof(bodydeviceCodelocationId), required: false);
            var __workflow_bodydeviceCodeproductType = WorkflowExpression.Compile(bodydeviceCodeproductType, nameof(bodydeviceCodeproductType), required: false);
            return new DeferredBodyAction<DeviceCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/devices/codes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                var deviceCodeObject = new JObject();
                var deviceCodeObjectpropCount = 0;
                if (__workflow_bodydeviceCodename != null)
                {
                    deviceCodeObject["name"] = ExpressionConverter.ConvertO(__workflow_bodydeviceCodename);
                    deviceCodeObjectpropCount++;
                }

                if (__workflow_bodydeviceCodelocationId != null)
                {
                    deviceCodeObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodydeviceCodelocationId);
                    deviceCodeObjectpropCount++;
                }

                if (__workflow_bodydeviceCodeproductType != null)
                {
                    deviceCodeObject["product_type"] = ExpressionConverter.ConvertO(__workflow_bodydeviceCodeproductType);
                    deviceCodeObjectpropCount++;
                }

                if (deviceCodeObjectpropCount > 0)
                {
                    body["device_code"] = deviceCodeObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeviceCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceGetResponse, ApiConnectionActionConfiguration> DeviceGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DeviceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/devices/codes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeviceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardListResponse, ApiConnectionActionConfiguration> GiftCardList(Expression<Func<string>> giftCardId = null, Expression<Func<string>> type = null, Expression<Func<string>> locationId = null, Expression<Func<string>> beginTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null, Expression<Func<sortOrderInput>> sortOrder = null)
        {
            var __workflow_giftCardId = WorkflowExpression.Compile(giftCardId, nameof(giftCardId), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_beginTime = WorkflowExpression.Compile(beginTime, nameof(beginTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_sortOrder = WorkflowExpression.Compile(sortOrder, nameof(sortOrder), required: false);
            return new DeferredBodyAction<GiftCardListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_giftCardId != null)
                    callPayload.Queries["gift_card_id"] = ExpressionConverter.Convert(__workflow_giftCardId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_beginTime != null)
                    callPayload.Queries["begin_time"] = ExpressionConverter.Convert(__workflow_beginTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["end_time"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (__workflow_sortOrder != null)
                    callPayload.Queries["sort_order"] = ExpressionConverter.Convert(__workflow_sortOrder);
                return new ApiConnectionAction<GiftCardListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardCreateResponse, ApiConnectionActionConfiguration> GiftCardCreate(Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodygiftCardActivitygiftCardId = null, Expression<Func<bodygiftCardActivitytypeInput>> bodygiftCardActivitytype = null, Expression<Func<string>> bodygiftCardActivitylocationId = null, Expression<Func<string>> bodygiftCardActivityactivateActivityDetailsorderId = null, Expression<Func<string>> bodygiftCardActivityactivateActivityDetailslineItemUid = null)
        {
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodygiftCardActivitygiftCardId = WorkflowExpression.Compile(bodygiftCardActivitygiftCardId, nameof(bodygiftCardActivitygiftCardId), required: false);
            var __workflow_bodygiftCardActivitytype = WorkflowExpression.Compile(bodygiftCardActivitytype, nameof(bodygiftCardActivitytype), required: false);
            var __workflow_bodygiftCardActivitylocationId = WorkflowExpression.Compile(bodygiftCardActivitylocationId, nameof(bodygiftCardActivitylocationId), required: false);
            var __workflow_bodygiftCardActivityactivateActivityDetailsorderId = WorkflowExpression.Compile(bodygiftCardActivityactivateActivityDetailsorderId, nameof(bodygiftCardActivityactivateActivityDetailsorderId), required: false);
            var __workflow_bodygiftCardActivityactivateActivityDetailslineItemUid = WorkflowExpression.Compile(bodygiftCardActivityactivateActivityDetailslineItemUid, nameof(bodygiftCardActivityactivateActivityDetailslineItemUid), required: false);
            return new DeferredBodyAction<GiftCardCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                var giftCardActivityObject = new JObject();
                var giftCardActivityObjectpropCount = 0;
                if (__workflow_bodygiftCardActivitygiftCardId != null)
                {
                    giftCardActivityObject["gift_card_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftCardActivitygiftCardId);
                    giftCardActivityObjectpropCount++;
                }

                if (__workflow_bodygiftCardActivitytype != null)
                {
                    giftCardActivityObject["type"] = ExpressionConverter.ConvertO(__workflow_bodygiftCardActivitytype);
                    giftCardActivityObjectpropCount++;
                }

                if (__workflow_bodygiftCardActivitylocationId != null)
                {
                    giftCardActivityObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftCardActivitylocationId);
                    giftCardActivityObjectpropCount++;
                }

                var activateActivityDetailsObject = new JObject();
                var activateActivityDetailsObjectpropCount = 0;
                if (__workflow_bodygiftCardActivityactivateActivityDetailsorderId != null)
                {
                    activateActivityDetailsObject["order_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftCardActivityactivateActivityDetailsorderId);
                    activateActivityDetailsObjectpropCount++;
                }

                if (__workflow_bodygiftCardActivityactivateActivityDetailslineItemUid != null)
                {
                    activateActivityDetailsObject["line_item_uid"] = ExpressionConverter.ConvertO(__workflow_bodygiftCardActivityactivateActivityDetailslineItemUid);
                    activateActivityDetailsObjectpropCount++;
                }

                if (activateActivityDetailsObjectpropCount > 0)
                {
                    giftCardActivityObject["activate_activity_details"] = activateActivityDetailsObject;
                    giftCardActivityObjectpropCount++;
                }

                if (giftCardActivityObjectpropCount > 0)
                {
                    body["gift_card_activity"] = giftCardActivityObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftCardCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveGANResponse, ApiConnectionActionConfiguration> GiftCardRetrieveGAN(Expression<Func<string>> bodygan = null)
        {
            var __workflow_bodygan = WorkflowExpression.Compile(bodygan, nameof(bodygan), required: false);
            return new DeferredBodyAction<GiftCardRetrieveGANResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/from-gan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygan != null)
                {
                    body["gan"] = ExpressionConverter.ConvertO(__workflow_bodygan);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftCardRetrieveGANResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveNonceResponse, ApiConnectionActionConfiguration> GiftCardRetrieveNonce(Expression<Func<string>> bodynonce = null)
        {
            var __workflow_bodynonce = WorkflowExpression.Compile(bodynonce, nameof(bodynonce), required: false);
            return new DeferredBodyAction<GiftCardRetrieveNonceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/from-nonce";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodynonce != null)
                {
                    body["nonce"] = ExpressionConverter.ConvertO(__workflow_bodynonce);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftCardRetrieveNonceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardLinkResponse, ApiConnectionActionConfiguration> GiftCardLink(Expression<Func<string>> giftCardId, Expression<Func<string>> bodycustomerId = null)
        {
            var __workflow_giftCardId = WorkflowExpression.Compile(giftCardId, nameof(giftCardId), required: true);
            var __workflow_bodycustomerId = WorkflowExpression.Compile(bodycustomerId, nameof(bodycustomerId), required: false);
            return new DeferredBodyAction<GiftCardLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift-cards/{0}/link-customer", __workflow_giftCardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomerId != null)
                {
                    body["customer_id"] = ExpressionConverter.ConvertO(__workflow_bodycustomerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftCardLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardUnlinkResponse, ApiConnectionActionConfiguration> GiftCardUnlink(Expression<Func<string>> giftCardId, Expression<Func<string>> bodycustomerId = null)
        {
            var __workflow_giftCardId = WorkflowExpression.Compile(giftCardId, nameof(giftCardId), required: true);
            var __workflow_bodycustomerId = WorkflowExpression.Compile(bodycustomerId, nameof(bodycustomerId), required: false);
            return new DeferredBodyAction<GiftCardUnlinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift-cards/{0}/unlink-customer", __workflow_giftCardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomerId != null)
                {
                    body["customer_id"] = ExpressionConverter.ConvertO(__workflow_bodycustomerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftCardUnlinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveResponse, ApiConnectionActionConfiguration> GiftCardRetrieve(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GiftCardRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift-cards/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftCardRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborListBreakResponse, ApiConnectionActionConfiguration> LaborListBreak(Expression<Func<string>> locationId = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<LaborListBreakResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/break-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locationId != null)
                    callPayload.Queries["location_id"] = ExpressionConverter.Convert(__workflow_locationId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<LaborListBreakResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborCreateBreakResponse, ApiConnectionActionConfiguration> LaborCreateBreak(Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodybreakTypelocationId = null, Expression<Func<string>> bodybreakTypebreakName = null, Expression<Func<string>> bodybreakTypeexpectedDuration = null, Expression<Func<bool>> bodybreakTypeisPaid = null)
        {
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodybreakTypelocationId = WorkflowExpression.Compile(bodybreakTypelocationId, nameof(bodybreakTypelocationId), required: false);
            var __workflow_bodybreakTypebreakName = WorkflowExpression.Compile(bodybreakTypebreakName, nameof(bodybreakTypebreakName), required: false);
            var __workflow_bodybreakTypeexpectedDuration = WorkflowExpression.Compile(bodybreakTypeexpectedDuration, nameof(bodybreakTypeexpectedDuration), required: false);
            var __workflow_bodybreakTypeisPaid = WorkflowExpression.Compile(bodybreakTypeisPaid, nameof(bodybreakTypeisPaid), required: false);
            return new DeferredBodyAction<LaborCreateBreakResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/break-types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                var breakTypeObject = new JObject();
                var breakTypeObjectpropCount = 0;
                if (__workflow_bodybreakTypelocationId != null)
                {
                    breakTypeObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypelocationId);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypebreakName != null)
                {
                    breakTypeObject["break_name"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypebreakName);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypeexpectedDuration != null)
                {
                    breakTypeObject["expected_duration"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypeexpectedDuration);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypeisPaid != null)
                {
                    breakTypeObject["is_paid"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypeisPaid);
                    breakTypeObjectpropCount++;
                }

                if (breakTypeObjectpropCount > 0)
                {
                    body["break_type"] = breakTypeObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LaborCreateBreakResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborGetBreakResponse, ApiConnectionActionConfiguration> LaborGetBreak(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaborGetBreakResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/break-types/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaborGetBreakResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> LaborDeleteBreak(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/break-types/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborUpdateBreakResponse, ApiConnectionActionConfiguration> LaborUpdateBreak(Expression<Func<string>> id, Expression<Func<string>> bodybreakTypelocationId = null, Expression<Func<string>> bodybreakTypebreakName = null, Expression<Func<string>> bodybreakTypeexpectedDuration = null, Expression<Func<bool>> bodybreakTypeisPaid = null, Expression<Func<int>> bodybreakTypeversion = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodybreakTypelocationId = WorkflowExpression.Compile(bodybreakTypelocationId, nameof(bodybreakTypelocationId), required: false);
            var __workflow_bodybreakTypebreakName = WorkflowExpression.Compile(bodybreakTypebreakName, nameof(bodybreakTypebreakName), required: false);
            var __workflow_bodybreakTypeexpectedDuration = WorkflowExpression.Compile(bodybreakTypeexpectedDuration, nameof(bodybreakTypeexpectedDuration), required: false);
            var __workflow_bodybreakTypeisPaid = WorkflowExpression.Compile(bodybreakTypeisPaid, nameof(bodybreakTypeisPaid), required: false);
            var __workflow_bodybreakTypeversion = WorkflowExpression.Compile(bodybreakTypeversion, nameof(bodybreakTypeversion), required: false);
            return new DeferredBodyAction<LaborUpdateBreakResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/break-types/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var breakTypeObject = new JObject();
                var breakTypeObjectpropCount = 0;
                if (__workflow_bodybreakTypelocationId != null)
                {
                    breakTypeObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypelocationId);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypebreakName != null)
                {
                    breakTypeObject["break_name"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypebreakName);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypeexpectedDuration != null)
                {
                    breakTypeObject["expected_duration"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypeexpectedDuration);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypeisPaid != null)
                {
                    breakTypeObject["is_paid"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypeisPaid);
                    breakTypeObjectpropCount++;
                }

                if (__workflow_bodybreakTypeversion != null)
                {
                    breakTypeObject["version"] = ExpressionConverter.ConvertO(__workflow_bodybreakTypeversion);
                    breakTypeObjectpropCount++;
                }

                if (breakTypeObjectpropCount > 0)
                {
                    body["break_type"] = breakTypeObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LaborUpdateBreakResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborCreateShiftResponse, ApiConnectionActionConfiguration> LaborCreateShift(Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodyshiftteamMemberId = null, Expression<Func<string>> bodyshiftlocationId = null, Expression<Func<string>> bodyshiftstartAt = null, Expression<Func<string>> bodyshiftendAt = null, Expression<Func<string>> bodyshiftwagetitle = null, Expression<Func<int>> bodyshiftwagehourlyRateamount = null, Expression<Func<string>> bodyshiftwagehourlyRatecurrency = null, Expression<Func<bodyshiftbreaksInputItem[]>> bodyshiftbreaks = null)
        {
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodyshiftteamMemberId = WorkflowExpression.Compile(bodyshiftteamMemberId, nameof(bodyshiftteamMemberId), required: false);
            var __workflow_bodyshiftlocationId = WorkflowExpression.Compile(bodyshiftlocationId, nameof(bodyshiftlocationId), required: false);
            var __workflow_bodyshiftstartAt = WorkflowExpression.Compile(bodyshiftstartAt, nameof(bodyshiftstartAt), required: false);
            var __workflow_bodyshiftendAt = WorkflowExpression.Compile(bodyshiftendAt, nameof(bodyshiftendAt), required: false);
            var __workflow_bodyshiftwagetitle = WorkflowExpression.Compile(bodyshiftwagetitle, nameof(bodyshiftwagetitle), required: false);
            var __workflow_bodyshiftwagehourlyRateamount = WorkflowExpression.Compile(bodyshiftwagehourlyRateamount, nameof(bodyshiftwagehourlyRateamount), required: false);
            var __workflow_bodyshiftwagehourlyRatecurrency = WorkflowExpression.Compile(bodyshiftwagehourlyRatecurrency, nameof(bodyshiftwagehourlyRatecurrency), required: false);
            var __workflow_bodyshiftbreaks = WorkflowExpression.Compile(bodyshiftbreaks, nameof(bodyshiftbreaks), required: false);
            return new DeferredBodyAction<LaborCreateShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/shifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                var shiftObject = new JObject();
                var shiftObjectpropCount = 0;
                if (__workflow_bodyshiftteamMemberId != null)
                {
                    shiftObject["team_member_id"] = ExpressionConverter.ConvertO(__workflow_bodyshiftteamMemberId);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftlocationId != null)
                {
                    shiftObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodyshiftlocationId);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftstartAt != null)
                {
                    shiftObject["start_at"] = ExpressionConverter.ConvertO(__workflow_bodyshiftstartAt);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftendAt != null)
                {
                    shiftObject["end_at"] = ExpressionConverter.ConvertO(__workflow_bodyshiftendAt);
                    shiftObjectpropCount++;
                }

                var wageObject = new JObject();
                var wageObjectpropCount = 0;
                if (__workflow_bodyshiftwagetitle != null)
                {
                    wageObject["title"] = ExpressionConverter.ConvertO(__workflow_bodyshiftwagetitle);
                    wageObjectpropCount++;
                }

                var hourlyRateObject = new JObject();
                var hourlyRateObjectpropCount = 0;
                if (__workflow_bodyshiftwagehourlyRateamount != null)
                {
                    hourlyRateObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodyshiftwagehourlyRateamount);
                    hourlyRateObjectpropCount++;
                }

                if (__workflow_bodyshiftwagehourlyRatecurrency != null)
                {
                    hourlyRateObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyshiftwagehourlyRatecurrency);
                    hourlyRateObjectpropCount++;
                }

                if (hourlyRateObjectpropCount > 0)
                {
                    wageObject["hourly_rate"] = hourlyRateObject;
                    wageObjectpropCount++;
                }

                if (wageObjectpropCount > 0)
                {
                    shiftObject["wage"] = wageObject;
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftbreaks != null)
                {
                    shiftObject["breaks"] = ExpressionConverter.ConvertO(__workflow_bodyshiftbreaks);
                    shiftObjectpropCount++;
                }

                if (shiftObjectpropCount > 0)
                {
                    body["shift"] = shiftObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LaborCreateShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborSearchShiftsResponse, ApiConnectionActionConfiguration> LaborSearchShifts(Expression<Func<string>> bodyqueryfilterworkdaydateRangestartDate = null, Expression<Func<string>> bodyqueryfilterworkdaydateRangeendDate = null, Expression<Func<string>> bodyqueryfilterworkdaymatchShiftsBy = null, Expression<Func<string>> bodyqueryfilterworkdaydefaultTimezone = null, Expression<Func<int>> bodylimit = null)
        {
            var __workflow_bodyqueryfilterworkdaydateRangestartDate = WorkflowExpression.Compile(bodyqueryfilterworkdaydateRangestartDate, nameof(bodyqueryfilterworkdaydateRangestartDate), required: false);
            var __workflow_bodyqueryfilterworkdaydateRangeendDate = WorkflowExpression.Compile(bodyqueryfilterworkdaydateRangeendDate, nameof(bodyqueryfilterworkdaydateRangeendDate), required: false);
            var __workflow_bodyqueryfilterworkdaymatchShiftsBy = WorkflowExpression.Compile(bodyqueryfilterworkdaymatchShiftsBy, nameof(bodyqueryfilterworkdaymatchShiftsBy), required: false);
            var __workflow_bodyqueryfilterworkdaydefaultTimezone = WorkflowExpression.Compile(bodyqueryfilterworkdaydefaultTimezone, nameof(bodyqueryfilterworkdaydefaultTimezone), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<LaborSearchShiftsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/shifts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var workdayObject = new JObject();
                var workdayObjectpropCount = 0;
                var dateRangeObject = new JObject();
                var dateRangeObjectpropCount = 0;
                if (__workflow_bodyqueryfilterworkdaydateRangestartDate != null)
                {
                    dateRangeObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterworkdaydateRangestartDate);
                    dateRangeObjectpropCount++;
                }

                if (__workflow_bodyqueryfilterworkdaydateRangeendDate != null)
                {
                    dateRangeObject["end_date"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterworkdaydateRangeendDate);
                    dateRangeObjectpropCount++;
                }

                if (dateRangeObjectpropCount > 0)
                {
                    workdayObject["date_range"] = dateRangeObject;
                    workdayObjectpropCount++;
                }

                if (__workflow_bodyqueryfilterworkdaymatchShiftsBy != null)
                {
                    workdayObject["match_shifts_by"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterworkdaymatchShiftsBy);
                    workdayObjectpropCount++;
                }

                if (__workflow_bodyqueryfilterworkdaydefaultTimezone != null)
                {
                    workdayObject["default_timezone"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterworkdaydefaultTimezone);
                    workdayObjectpropCount++;
                }

                if (workdayObjectpropCount > 0)
                {
                    filterObject["workday"] = workdayObject;
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LaborSearchShiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborGetShiftResponse, ApiConnectionActionConfiguration> LaborGetShift(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaborGetShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/shifts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaborGetShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> LaborDeleteShift(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/shifts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborUpdateShiftResponse, ApiConnectionActionConfiguration> LaborUpdateShift(Expression<Func<string>> id, Expression<Func<string>> bodyshiftteamMemberId = null, Expression<Func<string>> bodyshiftlocationId = null, Expression<Func<string>> bodyshiftstartAt = null, Expression<Func<string>> bodyshiftendAt = null, Expression<Func<string>> bodyshiftwagetitle = null, Expression<Func<int>> bodyshiftwagehourlyRateamount = null, Expression<Func<string>> bodyshiftwagehourlyRatecurrency = null, Expression<Func<bodyshiftbreaksInputItem2[]>> bodyshiftbreaks = null, Expression<Func<int>> bodyshiftversion = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyshiftteamMemberId = WorkflowExpression.Compile(bodyshiftteamMemberId, nameof(bodyshiftteamMemberId), required: false);
            var __workflow_bodyshiftlocationId = WorkflowExpression.Compile(bodyshiftlocationId, nameof(bodyshiftlocationId), required: false);
            var __workflow_bodyshiftstartAt = WorkflowExpression.Compile(bodyshiftstartAt, nameof(bodyshiftstartAt), required: false);
            var __workflow_bodyshiftendAt = WorkflowExpression.Compile(bodyshiftendAt, nameof(bodyshiftendAt), required: false);
            var __workflow_bodyshiftwagetitle = WorkflowExpression.Compile(bodyshiftwagetitle, nameof(bodyshiftwagetitle), required: false);
            var __workflow_bodyshiftwagehourlyRateamount = WorkflowExpression.Compile(bodyshiftwagehourlyRateamount, nameof(bodyshiftwagehourlyRateamount), required: false);
            var __workflow_bodyshiftwagehourlyRatecurrency = WorkflowExpression.Compile(bodyshiftwagehourlyRatecurrency, nameof(bodyshiftwagehourlyRatecurrency), required: false);
            var __workflow_bodyshiftbreaks = WorkflowExpression.Compile(bodyshiftbreaks, nameof(bodyshiftbreaks), required: false);
            var __workflow_bodyshiftversion = WorkflowExpression.Compile(bodyshiftversion, nameof(bodyshiftversion), required: false);
            return new DeferredBodyAction<LaborUpdateShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/shifts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var shiftObject = new JObject();
                var shiftObjectpropCount = 0;
                if (__workflow_bodyshiftteamMemberId != null)
                {
                    shiftObject["team_member_id"] = ExpressionConverter.ConvertO(__workflow_bodyshiftteamMemberId);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftlocationId != null)
                {
                    shiftObject["location_id"] = ExpressionConverter.ConvertO(__workflow_bodyshiftlocationId);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftstartAt != null)
                {
                    shiftObject["start_at"] = ExpressionConverter.ConvertO(__workflow_bodyshiftstartAt);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftendAt != null)
                {
                    shiftObject["end_at"] = ExpressionConverter.ConvertO(__workflow_bodyshiftendAt);
                    shiftObjectpropCount++;
                }

                var wageObject = new JObject();
                var wageObjectpropCount = 0;
                if (__workflow_bodyshiftwagetitle != null)
                {
                    wageObject["title"] = ExpressionConverter.ConvertO(__workflow_bodyshiftwagetitle);
                    wageObjectpropCount++;
                }

                var hourlyRateObject = new JObject();
                var hourlyRateObjectpropCount = 0;
                if (__workflow_bodyshiftwagehourlyRateamount != null)
                {
                    hourlyRateObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodyshiftwagehourlyRateamount);
                    hourlyRateObjectpropCount++;
                }

                if (__workflow_bodyshiftwagehourlyRatecurrency != null)
                {
                    hourlyRateObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyshiftwagehourlyRatecurrency);
                    hourlyRateObjectpropCount++;
                }

                if (hourlyRateObjectpropCount > 0)
                {
                    wageObject["hourly_rate"] = hourlyRateObject;
                    wageObjectpropCount++;
                }

                if (wageObjectpropCount > 0)
                {
                    shiftObject["wage"] = wageObject;
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftbreaks != null)
                {
                    shiftObject["breaks"] = ExpressionConverter.ConvertO(__workflow_bodyshiftbreaks);
                    shiftObjectpropCount++;
                }

                if (__workflow_bodyshiftversion != null)
                {
                    shiftObject["version"] = ExpressionConverter.ConvertO(__workflow_bodyshiftversion);
                    shiftObjectpropCount++;
                }

                if (shiftObjectpropCount > 0)
                {
                    body["shift"] = shiftObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LaborUpdateShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborListWagesResponse, ApiConnectionActionConfiguration> LaborListWages(Expression<Func<string>> teamMemberId = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<LaborListWagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/team-member-wages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_teamMemberId != null)
                    callPayload.Queries["team_member_id"] = ExpressionConverter.Convert(__workflow_teamMemberId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<LaborListWagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborGetWageResponse, ApiConnectionActionConfiguration> LaborGetWage(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LaborGetWageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/team-member-wages/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LaborGetWageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborListConfigsResponse, ApiConnectionActionConfiguration> LaborListConfigs(Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<LaborListConfigsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/workweek-configs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<LaborListConfigsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborUpdateConfigResponse, ApiConnectionActionConfiguration> LaborUpdateConfig(Expression<Func<string>> id, Expression<Func<string>> bodyworkweekConfigstartOfWeek = null, Expression<Func<string>> bodyworkweekConfigstartOfDayLocalTime = null, Expression<Func<int>> bodyworkweekConfigversion = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyworkweekConfigstartOfWeek = WorkflowExpression.Compile(bodyworkweekConfigstartOfWeek, nameof(bodyworkweekConfigstartOfWeek), required: false);
            var __workflow_bodyworkweekConfigstartOfDayLocalTime = WorkflowExpression.Compile(bodyworkweekConfigstartOfDayLocalTime, nameof(bodyworkweekConfigstartOfDayLocalTime), required: false);
            var __workflow_bodyworkweekConfigversion = WorkflowExpression.Compile(bodyworkweekConfigversion, nameof(bodyworkweekConfigversion), required: false);
            return new DeferredBodyAction<LaborUpdateConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/workweek-configs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var workweekConfigObject = new JObject();
                var workweekConfigObjectpropCount = 0;
                if (__workflow_bodyworkweekConfigstartOfWeek != null)
                {
                    workweekConfigObject["start_of_week"] = ExpressionConverter.ConvertO(__workflow_bodyworkweekConfigstartOfWeek);
                    workweekConfigObjectpropCount++;
                }

                if (__workflow_bodyworkweekConfigstartOfDayLocalTime != null)
                {
                    workweekConfigObject["start_of_day_local_time"] = ExpressionConverter.ConvertO(__workflow_bodyworkweekConfigstartOfDayLocalTime);
                    workweekConfigObjectpropCount++;
                }

                if (__workflow_bodyworkweekConfigversion != null)
                {
                    workweekConfigObject["version"] = ExpressionConverter.ConvertO(__workflow_bodyworkweekConfigversion);
                    workweekConfigObjectpropCount++;
                }

                if (workweekConfigObjectpropCount > 0)
                {
                    body["workweek_config"] = workweekConfigObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LaborUpdateConfigResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationListResponse, ApiConnectionActionConfiguration> LocationList()
        {
            return new DeferredBodyAction<LocationListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationCreateResponse, ApiConnectionActionConfiguration> LocationCreate(Expression<Func<string>> bodylocationname = null, Expression<Func<string>> bodylocationdescription = null, Expression<Func<string>> bodylocationfacebookUrl = null, Expression<Func<string>> bodylocationaddressaddressLine1 = null, Expression<Func<string>> bodylocationaddressadministrativeDistrictLevel1 = null, Expression<Func<string>> bodylocationaddresslocality = null, Expression<Func<string>> bodylocationaddresspostalCode = null)
        {
            var __workflow_bodylocationname = WorkflowExpression.Compile(bodylocationname, nameof(bodylocationname), required: false);
            var __workflow_bodylocationdescription = WorkflowExpression.Compile(bodylocationdescription, nameof(bodylocationdescription), required: false);
            var __workflow_bodylocationfacebookUrl = WorkflowExpression.Compile(bodylocationfacebookUrl, nameof(bodylocationfacebookUrl), required: false);
            var __workflow_bodylocationaddressaddressLine1 = WorkflowExpression.Compile(bodylocationaddressaddressLine1, nameof(bodylocationaddressaddressLine1), required: false);
            var __workflow_bodylocationaddressadministrativeDistrictLevel1 = WorkflowExpression.Compile(bodylocationaddressadministrativeDistrictLevel1, nameof(bodylocationaddressadministrativeDistrictLevel1), required: false);
            var __workflow_bodylocationaddresslocality = WorkflowExpression.Compile(bodylocationaddresslocality, nameof(bodylocationaddresslocality), required: false);
            var __workflow_bodylocationaddresspostalCode = WorkflowExpression.Compile(bodylocationaddresspostalCode, nameof(bodylocationaddresspostalCode), required: false);
            return new DeferredBodyAction<LocationCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodylocationname != null)
                {
                    locationObject["name"] = ExpressionConverter.ConvertO(__workflow_bodylocationname);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationdescription != null)
                {
                    locationObject["description"] = ExpressionConverter.ConvertO(__workflow_bodylocationdescription);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationfacebookUrl != null)
                {
                    locationObject["facebook_url"] = ExpressionConverter.ConvertO(__workflow_bodylocationfacebookUrl);
                    locationObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodylocationaddressaddressLine1 != null)
                {
                    addressObject["address_line_1"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodylocationaddressadministrativeDistrictLevel1 != null)
                {
                    addressObject["administrative_district_level_1"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddressadministrativeDistrictLevel1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodylocationaddresslocality != null)
                {
                    addressObject["locality"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddresslocality);
                    addressObjectpropCount++;
                }

                if (__workflow_bodylocationaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    locationObject["address"] = addressObject;
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LocationCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationRetrieveResponse, ApiConnectionActionConfiguration> LocationRetrieve(Expression<Func<string>> locationId)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            return new DeferredBodyAction<LocationRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationUpdateResponse, ApiConnectionActionConfiguration> LocationUpdate(Expression<Func<string>> locationId, Expression<Func<string>> bodylocationname = null, Expression<Func<string>> bodylocationdescription = null, Expression<Func<string>> bodylocationfacebookUrl = null, Expression<Func<string>> bodylocationtwitterUsername = null, Expression<Func<string>> bodylocationinstagramUsername = null, Expression<Func<string>> bodylocationaddressaddressLine1 = null, Expression<Func<string>> bodylocationaddressadministrativeDistrictLevel1 = null, Expression<Func<string>> bodylocationaddresslocality = null, Expression<Func<string>> bodylocationaddresspostalCode = null, Expression<Func<bodylocationbusinessHoursperiodsInputItem[]>> bodylocationbusinessHoursperiods = null)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            var __workflow_bodylocationname = WorkflowExpression.Compile(bodylocationname, nameof(bodylocationname), required: false);
            var __workflow_bodylocationdescription = WorkflowExpression.Compile(bodylocationdescription, nameof(bodylocationdescription), required: false);
            var __workflow_bodylocationfacebookUrl = WorkflowExpression.Compile(bodylocationfacebookUrl, nameof(bodylocationfacebookUrl), required: false);
            var __workflow_bodylocationtwitterUsername = WorkflowExpression.Compile(bodylocationtwitterUsername, nameof(bodylocationtwitterUsername), required: false);
            var __workflow_bodylocationinstagramUsername = WorkflowExpression.Compile(bodylocationinstagramUsername, nameof(bodylocationinstagramUsername), required: false);
            var __workflow_bodylocationaddressaddressLine1 = WorkflowExpression.Compile(bodylocationaddressaddressLine1, nameof(bodylocationaddressaddressLine1), required: false);
            var __workflow_bodylocationaddressadministrativeDistrictLevel1 = WorkflowExpression.Compile(bodylocationaddressadministrativeDistrictLevel1, nameof(bodylocationaddressadministrativeDistrictLevel1), required: false);
            var __workflow_bodylocationaddresslocality = WorkflowExpression.Compile(bodylocationaddresslocality, nameof(bodylocationaddresslocality), required: false);
            var __workflow_bodylocationaddresspostalCode = WorkflowExpression.Compile(bodylocationaddresspostalCode, nameof(bodylocationaddresspostalCode), required: false);
            var __workflow_bodylocationbusinessHoursperiods = WorkflowExpression.Compile(bodylocationbusinessHoursperiods, nameof(bodylocationbusinessHoursperiods), required: false);
            return new DeferredBodyAction<LocationUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodylocationname != null)
                {
                    locationObject["name"] = ExpressionConverter.ConvertO(__workflow_bodylocationname);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationdescription != null)
                {
                    locationObject["description"] = ExpressionConverter.ConvertO(__workflow_bodylocationdescription);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationfacebookUrl != null)
                {
                    locationObject["facebook_url"] = ExpressionConverter.ConvertO(__workflow_bodylocationfacebookUrl);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationtwitterUsername != null)
                {
                    locationObject["twitter_username"] = ExpressionConverter.ConvertO(__workflow_bodylocationtwitterUsername);
                    locationObjectpropCount++;
                }

                if (__workflow_bodylocationinstagramUsername != null)
                {
                    locationObject["instagram_username"] = ExpressionConverter.ConvertO(__workflow_bodylocationinstagramUsername);
                    locationObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodylocationaddressaddressLine1 != null)
                {
                    addressObject["address_line_1"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodylocationaddressadministrativeDistrictLevel1 != null)
                {
                    addressObject["administrative_district_level_1"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddressadministrativeDistrictLevel1);
                    addressObjectpropCount++;
                }

                if (__workflow_bodylocationaddresslocality != null)
                {
                    addressObject["locality"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddresslocality);
                    addressObjectpropCount++;
                }

                if (__workflow_bodylocationaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodylocationaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    locationObject["address"] = addressObject;
                    locationObjectpropCount++;
                }

                var businessHoursObject = new JObject();
                var businessHoursObjectpropCount = 0;
                if (__workflow_bodylocationbusinessHoursperiods != null)
                {
                    businessHoursObject["periods"] = ExpressionConverter.ConvertO(__workflow_bodylocationbusinessHoursperiods);
                    businessHoursObjectpropCount++;
                }

                if (businessHoursObjectpropCount > 0)
                {
                    locationObject["business_hours"] = businessHoursObject;
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LocationUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCreateAccountResponse, ApiConnectionActionConfiguration> LoyaltyCreateAccount(Expression<Func<string>> bodyloyaltyAccountmappingphoneNumber = null, Expression<Func<string>> bodyloyaltyAccountprogramId = null, Expression<Func<string>> bodyidempotencyKey = null)
        {
            var __workflow_bodyloyaltyAccountmappingphoneNumber = WorkflowExpression.Compile(bodyloyaltyAccountmappingphoneNumber, nameof(bodyloyaltyAccountmappingphoneNumber), required: false);
            var __workflow_bodyloyaltyAccountprogramId = WorkflowExpression.Compile(bodyloyaltyAccountprogramId, nameof(bodyloyaltyAccountprogramId), required: false);
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            return new DeferredBodyAction<LoyaltyCreateAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/accounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var loyaltyAccountObject = new JObject();
                var loyaltyAccountObjectpropCount = 0;
                var mappingObject = new JObject();
                var mappingObjectpropCount = 0;
                if (__workflow_bodyloyaltyAccountmappingphoneNumber != null)
                {
                    mappingObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyloyaltyAccountmappingphoneNumber);
                    mappingObjectpropCount++;
                }

                if (mappingObjectpropCount > 0)
                {
                    loyaltyAccountObject["mapping"] = mappingObject;
                    loyaltyAccountObjectpropCount++;
                }

                if (__workflow_bodyloyaltyAccountprogramId != null)
                {
                    loyaltyAccountObject["program_id"] = ExpressionConverter.ConvertO(__workflow_bodyloyaltyAccountprogramId);
                    loyaltyAccountObjectpropCount++;
                }

                if (loyaltyAccountObjectpropCount > 0)
                {
                    body["loyalty_account"] = loyaltyAccountObject;
                    bodypropCount++;
                }

                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltyCreateAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchAccountsResponse, ApiConnectionActionConfiguration> LoyaltySearchAccounts(Expression<Func<int>> bodylimit = null)
        {
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<LoyaltySearchAccountsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/accounts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltySearchAccountsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRetrieveAccountResponse, ApiConnectionActionConfiguration> LoyaltyRetrieveAccount(Expression<Func<string>> accountId)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            return new DeferredBodyAction<LoyaltyRetrieveAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/accounts/{0}", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LoyaltyRetrieveAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyAccumulatePointsResponse, ApiConnectionActionConfiguration> LoyaltyAccumulatePoints(Expression<Func<string>> accountId, Expression<Func<string>> bodyaccumulatePointsorderId = null, Expression<Func<string>> bodylocationId = null, Expression<Func<string>> bodyidempotencyKey = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bodyaccumulatePointsorderId = WorkflowExpression.Compile(bodyaccumulatePointsorderId, nameof(bodyaccumulatePointsorderId), required: false);
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            return new DeferredBodyAction<LoyaltyAccumulatePointsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/accounts/{0}/accumulate", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var accumulatePointsObject = new JObject();
                var accumulatePointsObjectpropCount = 0;
                if (__workflow_bodyaccumulatePointsorderId != null)
                {
                    accumulatePointsObject["order_id"] = ExpressionConverter.ConvertO(__workflow_bodyaccumulatePointsorderId);
                    accumulatePointsObjectpropCount++;
                }

                if (accumulatePointsObjectpropCount > 0)
                {
                    body["accumulate_points"] = accumulatePointsObject;
                    bodypropCount++;
                }

                if (__workflow_bodylocationId != null)
                {
                    body["location_id"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltyAccumulatePointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyAdjustPointsResponse, ApiConnectionActionConfiguration> LoyaltyAdjustPoints(Expression<Func<string>> accountId, Expression<Func<int>> bodyadjustPointspoints = null, Expression<Func<string>> bodyadjustPointsreason = null, Expression<Func<string>> bodyidempotencyKey = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_bodyadjustPointspoints = WorkflowExpression.Compile(bodyadjustPointspoints, nameof(bodyadjustPointspoints), required: false);
            var __workflow_bodyadjustPointsreason = WorkflowExpression.Compile(bodyadjustPointsreason, nameof(bodyadjustPointsreason), required: false);
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            return new DeferredBodyAction<LoyaltyAdjustPointsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/accounts/{0}/adjust", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var adjustPointsObject = new JObject();
                var adjustPointsObjectpropCount = 0;
                if (__workflow_bodyadjustPointspoints != null)
                {
                    adjustPointsObject["points"] = ExpressionConverter.ConvertO(__workflow_bodyadjustPointspoints);
                    adjustPointsObjectpropCount++;
                }

                if (__workflow_bodyadjustPointsreason != null)
                {
                    adjustPointsObject["reason"] = ExpressionConverter.ConvertO(__workflow_bodyadjustPointsreason);
                    adjustPointsObjectpropCount++;
                }

                if (adjustPointsObjectpropCount > 0)
                {
                    body["adjust_points"] = adjustPointsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltyAdjustPointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchEventsResponse, ApiConnectionActionConfiguration> LoyaltySearchEvents(Expression<Func<string>> bodyqueryfilterorderFilterorderId = null, Expression<Func<int>> bodylimit = null)
        {
            var __workflow_bodyqueryfilterorderFilterorderId = WorkflowExpression.Compile(bodyqueryfilterorderFilterorderId, nameof(bodyqueryfilterorderFilterorderId), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<LoyaltySearchEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/events/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                var orderFilterObject = new JObject();
                var orderFilterObjectpropCount = 0;
                if (__workflow_bodyqueryfilterorderFilterorderId != null)
                {
                    orderFilterObject["order_id"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterorderFilterorderId);
                    orderFilterObjectpropCount++;
                }

                if (orderFilterObjectpropCount > 0)
                {
                    filterObject["order_filter"] = orderFilterObject;
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltySearchEventsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRetrieveProgramResponse, ApiConnectionActionConfiguration> LoyaltyRetrieveProgram(Expression<Func<string>> programId)
        {
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            return new DeferredBodyAction<LoyaltyRetrieveProgramResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/programs/{0}", __workflow_programId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LoyaltyRetrieveProgramResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCalculatePointsResponse, ApiConnectionActionConfiguration> LoyaltyCalculatePoints(Expression<Func<string>> programId, Expression<Func<string>> bodyorderId = null)
        {
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            var __workflow_bodyorderId = WorkflowExpression.Compile(bodyorderId, nameof(bodyorderId), required: false);
            return new DeferredBodyAction<LoyaltyCalculatePointsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/programs/{0}/calculate", __workflow_programId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyorderId != null)
                {
                    body["order_id"] = ExpressionConverter.ConvertO(__workflow_bodyorderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltyCalculatePointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCreateRewardResponse, ApiConnectionActionConfiguration> LoyaltyCreateReward(Expression<Func<string>> bodyrewardloyaltyAccountId = null, Expression<Func<string>> bodyrewardrewardTierId = null, Expression<Func<string>> bodyrewardorderId = null, Expression<Func<string>> bodyidempotencyKey = null)
        {
            var __workflow_bodyrewardloyaltyAccountId = WorkflowExpression.Compile(bodyrewardloyaltyAccountId, nameof(bodyrewardloyaltyAccountId), required: false);
            var __workflow_bodyrewardrewardTierId = WorkflowExpression.Compile(bodyrewardrewardTierId, nameof(bodyrewardrewardTierId), required: false);
            var __workflow_bodyrewardorderId = WorkflowExpression.Compile(bodyrewardorderId, nameof(bodyrewardorderId), required: false);
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            return new DeferredBodyAction<LoyaltyCreateRewardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/rewards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rewardObject = new JObject();
                var rewardObjectpropCount = 0;
                if (__workflow_bodyrewardloyaltyAccountId != null)
                {
                    rewardObject["loyalty_account_id"] = ExpressionConverter.ConvertO(__workflow_bodyrewardloyaltyAccountId);
                    rewardObjectpropCount++;
                }

                if (__workflow_bodyrewardrewardTierId != null)
                {
                    rewardObject["reward_tier_id"] = ExpressionConverter.ConvertO(__workflow_bodyrewardrewardTierId);
                    rewardObjectpropCount++;
                }

                if (__workflow_bodyrewardorderId != null)
                {
                    rewardObject["order_id"] = ExpressionConverter.ConvertO(__workflow_bodyrewardorderId);
                    rewardObjectpropCount++;
                }

                if (rewardObjectpropCount > 0)
                {
                    body["reward"] = rewardObject;
                    bodypropCount++;
                }

                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltyCreateRewardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchRewardsResponse, ApiConnectionActionConfiguration> LoyaltySearchRewards(Expression<Func<string>> bodyqueryloyaltyAccountId = null, Expression<Func<int>> bodylimit = null)
        {
            var __workflow_bodyqueryloyaltyAccountId = WorkflowExpression.Compile(bodyqueryloyaltyAccountId, nameof(bodyqueryloyaltyAccountId), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<LoyaltySearchRewardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/rewards/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (__workflow_bodyqueryloyaltyAccountId != null)
                {
                    queryObject["loyalty_account_id"] = ExpressionConverter.ConvertO(__workflow_bodyqueryloyaltyAccountId);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltySearchRewardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRetrieveRewardResponse, ApiConnectionActionConfiguration> LoyaltyRetrieveReward(Expression<Func<string>> rewardId)
        {
            var __workflow_rewardId = WorkflowExpression.Compile(rewardId, nameof(rewardId), required: true);
            return new DeferredBodyAction<LoyaltyRetrieveRewardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/rewards/{0}", __workflow_rewardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LoyaltyRetrieveRewardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> LoyaltyDeleteReward(Expression<Func<string>> rewardId)
        {
            var __workflow_rewardId = WorkflowExpression.Compile(rewardId, nameof(rewardId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/rewards/{0}", __workflow_rewardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRedeemRewardResponse, ApiConnectionActionConfiguration> LoyaltyRedeemReward(Expression<Func<string>> rewardId, Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodylocationId = null)
        {
            var __workflow_rewardId = WorkflowExpression.Compile(rewardId, nameof(rewardId), required: true);
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            return new DeferredBodyAction<LoyaltyRedeemRewardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/rewards/{0}/redeem", __workflow_rewardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                if (__workflow_bodylocationId != null)
                {
                    body["location_id"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoyaltyRedeemRewardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<MerchantListResponse, ApiConnectionActionConfiguration> MerchantList(Expression<Func<int>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<MerchantListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/merchants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<MerchantListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<MerchantRetrieveResponse, ApiConnectionActionConfiguration> MerchantRetrieve(Expression<Func<string>> merchantId)
        {
            var __workflow_merchantId = WorkflowExpression.Compile(merchantId, nameof(merchantId), required: true);
            return new DeferredBodyAction<MerchantRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/merchants/{0}", __workflow_merchantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MerchantRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<MobileAuthorizationCreateResponse, ApiConnectionActionConfiguration> MobileAuthorizationCreate(Expression<Func<string>> bodylocationId = null)
        {
            var __workflow_bodylocationId = WorkflowExpression.Compile(bodylocationId, nameof(bodylocationId), required: false);
            return new DeferredBodyAction<MobileAuthorizationCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mobile/authorization-code";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylocationId != null)
                {
                    body["location_id"] = ExpressionConverter.ConvertO(__workflow_bodylocationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MobileAuthorizationCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<SiteListResponse, ApiConnectionActionConfiguration> SiteList()
        {
            return new DeferredBodyAction<SiteListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<SnippetRetrieveResponse, ApiConnectionActionConfiguration> SnippetRetrieve(Expression<Func<string>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SnippetRetrieveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sites/{0}/snippet", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SnippetRetrieveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SnippetDelete(Expression<Func<string>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sites/{0}/snippet", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<SnippetUpsertResponse, ApiConnectionActionConfiguration> SnippetUpsert(Expression<Func<string>> siteId, Expression<Func<string>> bodysnippetcontent = null)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_bodysnippetcontent = WorkflowExpression.Compile(bodysnippetcontent, nameof(bodysnippetcontent), required: false);
            return new DeferredBodyAction<SnippetUpsertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sites/{0}/snippet", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var snippetObject = new JObject();
                var snippetObjectpropCount = 0;
                if (__workflow_bodysnippetcontent != null)
                {
                    snippetObject["content"] = ExpressionConverter.ConvertO(__workflow_bodysnippetcontent);
                    snippetObjectpropCount++;
                }

                if (snippetObjectpropCount > 0)
                {
                    body["snippet"] = snippetObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SnippetUpsertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamCreateMemberResponse, ApiConnectionActionConfiguration> TeamCreateMember(Expression<Func<string>> bodyidempotencyKey = null, Expression<Func<string>> bodyteamMemberreferenceId = null, Expression<Func<string>> bodyteamMemberstatus = null, Expression<Func<string>> bodyteamMembergivenName = null, Expression<Func<string>> bodyteamMemberfamilyName = null, Expression<Func<string>> bodyteamMemberemailAddress = null, Expression<Func<string>> bodyteamMemberphoneNumber = null, Expression<Func<string[]>> bodyteamMemberassignedLocationslocationIds = null, Expression<Func<string>> bodyteamMemberassignedLocationsassignmentType = null)
        {
            var __workflow_bodyidempotencyKey = WorkflowExpression.Compile(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            var __workflow_bodyteamMemberreferenceId = WorkflowExpression.Compile(bodyteamMemberreferenceId, nameof(bodyteamMemberreferenceId), required: false);
            var __workflow_bodyteamMemberstatus = WorkflowExpression.Compile(bodyteamMemberstatus, nameof(bodyteamMemberstatus), required: false);
            var __workflow_bodyteamMembergivenName = WorkflowExpression.Compile(bodyteamMembergivenName, nameof(bodyteamMembergivenName), required: false);
            var __workflow_bodyteamMemberfamilyName = WorkflowExpression.Compile(bodyteamMemberfamilyName, nameof(bodyteamMemberfamilyName), required: false);
            var __workflow_bodyteamMemberemailAddress = WorkflowExpression.Compile(bodyteamMemberemailAddress, nameof(bodyteamMemberemailAddress), required: false);
            var __workflow_bodyteamMemberphoneNumber = WorkflowExpression.Compile(bodyteamMemberphoneNumber, nameof(bodyteamMemberphoneNumber), required: false);
            var __workflow_bodyteamMemberassignedLocationslocationIds = WorkflowExpression.Compile(bodyteamMemberassignedLocationslocationIds, nameof(bodyteamMemberassignedLocationslocationIds), required: false);
            var __workflow_bodyteamMemberassignedLocationsassignmentType = WorkflowExpression.Compile(bodyteamMemberassignedLocationsassignmentType, nameof(bodyteamMemberassignedLocationsassignmentType), required: false);
            return new DeferredBodyAction<TeamCreateMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = ExpressionConverter.ConvertO(__workflow_bodyidempotencyKey);
                    bodypropCount++;
                }

                var teamMemberObject = new JObject();
                var teamMemberObjectpropCount = 0;
                if (__workflow_bodyteamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberstatus != null)
                {
                    teamMemberObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberstatus);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (__workflow_bodyteamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (__workflow_bodyteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberassignedLocationsassignmentType);
                    assignedLocationsObjectpropCount++;
                }

                if (assignedLocationsObjectpropCount > 0)
                {
                    teamMemberObject["assigned_locations"] = assignedLocationsObject;
                    teamMemberObjectpropCount++;
                }

                if (teamMemberObjectpropCount > 0)
                {
                    body["team_member"] = teamMemberObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TeamCreateMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamCreateBulkMembersResponse, ApiConnectionActionConfiguration> TeamCreateBulkMembers(Expression<Func<string>> bodyteamMembersidempotencyKey1teamMembergivenName = null, Expression<Func<string>> bodyteamMembersidempotencyKey1teamMemberfamilyName = null, Expression<Func<string>> bodyteamMembersidempotencyKey1teamMemberemailAddress = null, Expression<Func<string>> bodyteamMembersidempotencyKey1teamMemberreferenceId = null, Expression<Func<string>> bodyteamMembersidempotencyKey1teamMemberphoneNumber = null, Expression<Func<string[]>> bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds = null, Expression<Func<string>> bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType = null, Expression<Func<string>> bodyteamMembersidempotencyKey2teamMembergivenName = null, Expression<Func<string>> bodyteamMembersidempotencyKey2teamMemberfamilyName = null, Expression<Func<string>> bodyteamMembersidempotencyKey2teamMemberemailAddress = null, Expression<Func<string>> bodyteamMembersidempotencyKey2teamMemberreferenceId = null, Expression<Func<string>> bodyteamMembersidempotencyKey2teamMemberphoneNumber = null, Expression<Func<string>> bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType = null)
        {
            var __workflow_bodyteamMembersidempotencyKey1teamMembergivenName = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMembergivenName, nameof(bodyteamMembersidempotencyKey1teamMembergivenName), required: false);
            var __workflow_bodyteamMembersidempotencyKey1teamMemberfamilyName = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMemberfamilyName, nameof(bodyteamMembersidempotencyKey1teamMemberfamilyName), required: false);
            var __workflow_bodyteamMembersidempotencyKey1teamMemberemailAddress = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMemberemailAddress, nameof(bodyteamMembersidempotencyKey1teamMemberemailAddress), required: false);
            var __workflow_bodyteamMembersidempotencyKey1teamMemberreferenceId = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMemberreferenceId, nameof(bodyteamMembersidempotencyKey1teamMemberreferenceId), required: false);
            var __workflow_bodyteamMembersidempotencyKey1teamMemberphoneNumber = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMemberphoneNumber, nameof(bodyteamMembersidempotencyKey1teamMemberphoneNumber), required: false);
            var __workflow_bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds, nameof(bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds), required: false);
            var __workflow_bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType = WorkflowExpression.Compile(bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType, nameof(bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType), required: false);
            var __workflow_bodyteamMembersidempotencyKey2teamMembergivenName = WorkflowExpression.Compile(bodyteamMembersidempotencyKey2teamMembergivenName, nameof(bodyteamMembersidempotencyKey2teamMembergivenName), required: false);
            var __workflow_bodyteamMembersidempotencyKey2teamMemberfamilyName = WorkflowExpression.Compile(bodyteamMembersidempotencyKey2teamMemberfamilyName, nameof(bodyteamMembersidempotencyKey2teamMemberfamilyName), required: false);
            var __workflow_bodyteamMembersidempotencyKey2teamMemberemailAddress = WorkflowExpression.Compile(bodyteamMembersidempotencyKey2teamMemberemailAddress, nameof(bodyteamMembersidempotencyKey2teamMemberemailAddress), required: false);
            var __workflow_bodyteamMembersidempotencyKey2teamMemberreferenceId = WorkflowExpression.Compile(bodyteamMembersidempotencyKey2teamMemberreferenceId, nameof(bodyteamMembersidempotencyKey2teamMemberreferenceId), required: false);
            var __workflow_bodyteamMembersidempotencyKey2teamMemberphoneNumber = WorkflowExpression.Compile(bodyteamMembersidempotencyKey2teamMemberphoneNumber, nameof(bodyteamMembersidempotencyKey2teamMemberphoneNumber), required: false);
            var __workflow_bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType = WorkflowExpression.Compile(bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType, nameof(bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType), required: false);
            return new DeferredBodyAction<TeamCreateBulkMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members/bulk-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var teamMembersObject = new JObject();
                var teamMembersObjectpropCount = 0;
                var idempotencyKey1Object = new JObject();
                var idempotencyKey1ObjectpropCount = 0;
                var teamMemberObject = new JObject();
                var teamMemberObjectpropCount = 0;
                if (__workflow_bodyteamMembersidempotencyKey1teamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey1teamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey1teamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey1teamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey1teamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (__workflow_bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType);
                    assignedLocationsObjectpropCount++;
                }

                if (assignedLocationsObjectpropCount > 0)
                {
                    teamMemberObject["assigned_locations"] = assignedLocationsObject;
                    teamMemberObjectpropCount++;
                }

                if (teamMemberObjectpropCount > 0)
                {
                    idempotencyKey1Object["team_member"] = teamMemberObject;
                    idempotencyKey1ObjectpropCount++;
                }

                if (idempotencyKey1ObjectpropCount > 0)
                {
                    teamMembersObject["idempotency-key-1"] = idempotencyKey1Object;
                    teamMembersObjectpropCount++;
                }

                var idempotencyKey2Object = new JObject();
                var idempotencyKey2ObjectpropCount = 0;
                var teamMemberObject2 = new JObject();
                var teamMemberObject2propCount = 0;
                if (__workflow_bodyteamMembersidempotencyKey2teamMembergivenName != null)
                {
                    teamMemberObject2["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey2teamMembergivenName);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey2teamMemberfamilyName != null)
                {
                    teamMemberObject2["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey2teamMemberfamilyName);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey2teamMemberemailAddress != null)
                {
                    teamMemberObject2["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey2teamMemberemailAddress);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey2teamMemberreferenceId != null)
                {
                    teamMemberObject2["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey2teamMemberreferenceId);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersidempotencyKey2teamMemberphoneNumber != null)
                {
                    teamMemberObject2["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey2teamMemberphoneNumber);
                    teamMemberObject2propCount++;
                }

                var assignedLocationsObject2 = new JObject();
                var assignedLocationsObject2propCount = 0;
                if (__workflow_bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject2["assignment_type"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType);
                    assignedLocationsObject2propCount++;
                }

                if (assignedLocationsObject2propCount > 0)
                {
                    teamMemberObject2["assigned_locations"] = assignedLocationsObject2;
                    teamMemberObject2propCount++;
                }

                if (teamMemberObject2propCount > 0)
                {
                    idempotencyKey2Object["team_member"] = teamMemberObject2;
                    idempotencyKey2ObjectpropCount++;
                }

                if (idempotencyKey2ObjectpropCount > 0)
                {
                    teamMembersObject["idempotency-key-2"] = idempotencyKey2Object;
                    teamMembersObjectpropCount++;
                }

                if (teamMembersObjectpropCount > 0)
                {
                    body["team_members"] = teamMembersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TeamCreateBulkMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateBulkMembersResponse, ApiConnectionActionConfiguration> TeamUpdateBulkMembers(Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId = null, Expression<Func<bool>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner = null, Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus = null, Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName = null, Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName = null, Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress = null, Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber = null, Expression<Func<string[]>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds = null, Expression<Func<string>> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId = null, Expression<Func<bool>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber = null, Expression<Func<string>> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType = null)
        {
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds), required: false);
            var __workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType = WorkflowExpression.Compile(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber), required: false);
            var __workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType = WorkflowExpression.Compile(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType), required: false);
            return new DeferredBodyAction<TeamUpdateBulkMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members/bulk-update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var teamMembersObject = new JObject();
                var teamMembersObjectpropCount = 0;
                var fpgteZNMaf0qOKA4t6PObject = new JObject();
                var fpgteZNMaf0qOKA4t6PObjectpropCount = 0;
                var teamMemberObject = new JObject();
                var teamMemberObjectpropCount = 0;
                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner != null)
                {
                    teamMemberObject["is_owner"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus != null)
                {
                    teamMemberObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType);
                    assignedLocationsObjectpropCount++;
                }

                if (assignedLocationsObjectpropCount > 0)
                {
                    teamMemberObject["assigned_locations"] = assignedLocationsObject;
                    teamMemberObjectpropCount++;
                }

                if (teamMemberObjectpropCount > 0)
                {
                    fpgteZNMaf0qOKA4t6PObject["team_member"] = teamMemberObject;
                    fpgteZNMaf0qOKA4t6PObjectpropCount++;
                }

                if (fpgteZNMaf0qOKA4t6PObjectpropCount > 0)
                {
                    teamMembersObject["fpgteZNMaf0qOK-a4t6P"] = fpgteZNMaf0qOKA4t6PObject;
                    teamMembersObjectpropCount++;
                }

                var aFMwA08kRMIF3Vs0OEObject = new JObject();
                var aFMwA08kRMIF3Vs0OEObjectpropCount = 0;
                var teamMemberObject2 = new JObject();
                var teamMemberObject2propCount = 0;
                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId != null)
                {
                    teamMemberObject2["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner != null)
                {
                    teamMemberObject2["is_owner"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus != null)
                {
                    teamMemberObject2["status"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName != null)
                {
                    teamMemberObject2["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName != null)
                {
                    teamMemberObject2["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress != null)
                {
                    teamMemberObject2["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress);
                    teamMemberObject2propCount++;
                }

                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber != null)
                {
                    teamMemberObject2["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber);
                    teamMemberObject2propCount++;
                }

                var assignedLocationsObject2 = new JObject();
                var assignedLocationsObject2propCount = 0;
                if (__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject2["assignment_type"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType);
                    assignedLocationsObject2propCount++;
                }

                if (assignedLocationsObject2propCount > 0)
                {
                    teamMemberObject2["assigned_locations"] = assignedLocationsObject2;
                    teamMemberObject2propCount++;
                }

                if (teamMemberObject2propCount > 0)
                {
                    aFMwA08kRMIF3Vs0OEObject["team_member"] = teamMemberObject2;
                    aFMwA08kRMIF3Vs0OEObjectpropCount++;
                }

                if (aFMwA08kRMIF3Vs0OEObjectpropCount > 0)
                {
                    teamMembersObject["AFMwA08kR-MIF-3Vs0OE"] = aFMwA08kRMIF3Vs0OEObject;
                    teamMembersObjectpropCount++;
                }

                if (teamMembersObjectpropCount > 0)
                {
                    body["team_members"] = teamMembersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TeamUpdateBulkMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamSearchResponse, ApiConnectionActionConfiguration> TeamSearch(Expression<Func<string[]>> bodyqueryfilterlocationIds = null, Expression<Func<string>> bodyqueryfilterstatus = null, Expression<Func<int>> bodylimit = null)
        {
            var __workflow_bodyqueryfilterlocationIds = WorkflowExpression.Compile(bodyqueryfilterlocationIds, nameof(bodyqueryfilterlocationIds), required: false);
            var __workflow_bodyqueryfilterstatus = WorkflowExpression.Compile(bodyqueryfilterstatus, nameof(bodyqueryfilterstatus), required: false);
            var __workflow_bodylimit = WorkflowExpression.Compile(bodylimit, nameof(bodylimit), required: false);
            return new DeferredBodyAction<TeamSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyqueryfilterlocationIds != null)
                {
                    filterObject["location_ids"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterlocationIds);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyqueryfilterstatus != null)
                {
                    filterObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyqueryfilterstatus);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    queryObject["filter"] = filterObject;
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TeamSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamRetrieveMemberResponse, ApiConnectionActionConfiguration> TeamRetrieveMember(Expression<Func<string>> teamMemberId)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: true);
            return new DeferredBodyAction<TeamRetrieveMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team-members/{0}", __workflow_teamMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TeamRetrieveMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateResponse, ApiConnectionActionConfiguration> TeamUpdate(Expression<Func<string>> teamMemberId, Expression<Func<string>> bodyteamMemberreferenceId = null, Expression<Func<string>> bodyteamMemberstatus = null, Expression<Func<string>> bodyteamMembergivenName = null, Expression<Func<string>> bodyteamMemberfamilyName = null, Expression<Func<string>> bodyteamMemberemailAddress = null, Expression<Func<string>> bodyteamMemberphoneNumber = null, Expression<Func<string[]>> bodyteamMemberassignedLocationslocationIds = null, Expression<Func<string>> bodyteamMemberassignedLocationsassignmentType = null)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: true);
            var __workflow_bodyteamMemberreferenceId = WorkflowExpression.Compile(bodyteamMemberreferenceId, nameof(bodyteamMemberreferenceId), required: false);
            var __workflow_bodyteamMemberstatus = WorkflowExpression.Compile(bodyteamMemberstatus, nameof(bodyteamMemberstatus), required: false);
            var __workflow_bodyteamMembergivenName = WorkflowExpression.Compile(bodyteamMembergivenName, nameof(bodyteamMembergivenName), required: false);
            var __workflow_bodyteamMemberfamilyName = WorkflowExpression.Compile(bodyteamMemberfamilyName, nameof(bodyteamMemberfamilyName), required: false);
            var __workflow_bodyteamMemberemailAddress = WorkflowExpression.Compile(bodyteamMemberemailAddress, nameof(bodyteamMemberemailAddress), required: false);
            var __workflow_bodyteamMemberphoneNumber = WorkflowExpression.Compile(bodyteamMemberphoneNumber, nameof(bodyteamMemberphoneNumber), required: false);
            var __workflow_bodyteamMemberassignedLocationslocationIds = WorkflowExpression.Compile(bodyteamMemberassignedLocationslocationIds, nameof(bodyteamMemberassignedLocationslocationIds), required: false);
            var __workflow_bodyteamMemberassignedLocationsassignmentType = WorkflowExpression.Compile(bodyteamMemberassignedLocationsassignmentType, nameof(bodyteamMemberassignedLocationsassignmentType), required: false);
            return new DeferredBodyAction<TeamUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team-members/{0}", __workflow_teamMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var teamMemberObject = new JObject();
                var teamMemberObjectpropCount = 0;
                if (__workflow_bodyteamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberstatus != null)
                {
                    teamMemberObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberstatus);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (__workflow_bodyteamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (__workflow_bodyteamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (__workflow_bodyteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = ExpressionConverter.ConvertO(__workflow_bodyteamMemberassignedLocationsassignmentType);
                    assignedLocationsObjectpropCount++;
                }

                if (assignedLocationsObjectpropCount > 0)
                {
                    teamMemberObject["assigned_locations"] = assignedLocationsObject;
                    teamMemberObjectpropCount++;
                }

                if (teamMemberObjectpropCount > 0)
                {
                    body["team_member"] = teamMemberObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TeamUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamRetrieveWageResponse, ApiConnectionActionConfiguration> TeamRetrieveWage(Expression<Func<string>> teamMemberId)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: true);
            return new DeferredBodyAction<TeamRetrieveWageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team-members/{0}/wage-setting", __workflow_teamMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TeamRetrieveWageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateWageResponse, ApiConnectionActionConfiguration> TeamUpdateWage(Expression<Func<string>> teamMemberId, Expression<Func<bool>> bodywageSettingisOvertimeExempt = null, Expression<Func<bodywageSettingjobAssignmentsInputItem[]>> bodywageSettingjobAssignments = null)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: true);
            var __workflow_bodywageSettingisOvertimeExempt = WorkflowExpression.Compile(bodywageSettingisOvertimeExempt, nameof(bodywageSettingisOvertimeExempt), required: false);
            var __workflow_bodywageSettingjobAssignments = WorkflowExpression.Compile(bodywageSettingjobAssignments, nameof(bodywageSettingjobAssignments), required: false);
            return new DeferredBodyAction<TeamUpdateWageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team-members/{0}/wage-setting", __workflow_teamMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var wageSettingObject = new JObject();
                var wageSettingObjectpropCount = 0;
                if (__workflow_bodywageSettingisOvertimeExempt != null)
                {
                    wageSettingObject["is_overtime_exempt"] = ExpressionConverter.ConvertO(__workflow_bodywageSettingisOvertimeExempt);
                    wageSettingObjectpropCount++;
                }

                if (__workflow_bodywageSettingjobAssignments != null)
                {
                    wageSettingObject["job_assignments"] = ExpressionConverter.ConvertO(__workflow_bodywageSettingjobAssignments);
                    wageSettingObjectpropCount++;
                }

                if (wageSettingObjectpropCount > 0)
                {
                    body["wage_setting"] = wageSettingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TeamUpdateWageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BankAccountGetV1Response, ApiConnectionActionConfiguration> BankAccountGet(Expression<Func<string>> v1BankAccountId)
        {
            var __workflow_v1BankAccountId = WorkflowExpression.Compile(v1BankAccountId, nameof(v1BankAccountId), required: true);
            return new DeferredBodyAction<BankAccountGetV1Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bank-accounts/by-v1-id/{0}", __workflow_v1BankAccountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BankAccountGetV1Response>(callPayload);
            });
        }
    }

    public class SquarebusinessipTriggers([ConnectionName] string connectionId)
    {
    }

    public class BankAccountListResponse
    {
        [JsonProperty("bank_accounts")]
        public BankAccountListResponseBankAccountsTypeItem[] BankAccounts { get; set; }
    }

    public class BankAccountListResponseBankAccountsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account_number_suffix")]
        public string AccountNumberSuffix { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("primary_bank_identification_number")]
        public string PrimaryBankIdentificationNumber { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("creditable")]
        public bool Creditable { get; set; }

        [JsonProperty("debitable")]
        public bool Debitable { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }
    }

    public class BookingCreateResponse
    {
        [JsonProperty("booking")]
        public BookingCreateResponseBookingType Booking { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }
    }

    public class BookingCreateResponseBookingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_note")]
        public string CustomerNote { get; set; }

        [JsonProperty("seller_note")]
        public string SellerNote { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("appointment_segments")]
        public BookingCreateResponseBookingTypeAppointmentSegmentsTypeItem[] AppointmentSegments { get; set; }
    }

    public class BookingCreateResponseBookingTypeAppointmentSegmentsTypeItem
    {
        [JsonProperty("duration_minutes")]
        public int DurationMinutes { get; set; }

        [JsonProperty("service_variation_id")]
        public string ServiceVariationId { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("service_variation_version")]
        public int ServiceVariationVersion { get; set; }
    }

    public class bodybookingappointmentSegmentsInputItem
    {
        [JsonProperty("duration_minutes")]
        public int DurationMinutes { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("service_variation_id")]
        public string ServiceVariationId { get; set; }

        [JsonProperty("service_variation_version")]
        public int ServiceVariationVersion { get; set; }
    }

    public class BookingAvailabilityResponse
    {
        [JsonProperty("availabilities")]
        public BookingAvailabilityResponseAvailabilitiesTypeItem[] Availabilities { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }
    }

    public class BookingAvailabilityResponseAvailabilitiesTypeItem
    {
        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("appointment_segments")]
        public BookingAvailabilityResponseAvailabilitiesTypeItemAppointmentSegmentsTypeItem[] AppointmentSegments { get; set; }
    }

    public class BookingAvailabilityResponseAvailabilitiesTypeItemAppointmentSegmentsTypeItem
    {
        [JsonProperty("duration_minutes")]
        public int DurationMinutes { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("service_variation_id")]
        public string ServiceVariationId { get; set; }

        [JsonProperty("service_variation_version")]
        public int ServiceVariationVersion { get; set; }
    }

    public class bodyqueryfiltersegmentFiltersInputItem
    {
        [JsonProperty("service_variation_id")]
        public string ServiceVariationId { get; set; }

        [JsonProperty("team_member_id_filter")]
        public bodyqueryfiltersegmentFiltersInputItemTeamMemberIdFilterType TeamMemberIdFilter { get; set; }
    }

    public class bodyqueryfiltersegmentFiltersInputItemTeamMemberIdFilterType
    {
        [JsonProperty("any")]
        public string[] Any { get; set; }
    }

    public class BookingRetrieveProfileResponse
    {
        [JsonProperty("business_booking_profile")]
        public BookingRetrieveProfileResponseBusinessBookingProfileType BusinessBookingProfile { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }
    }

    public class BookingRetrieveProfileResponseBusinessBookingProfileType
    {
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("booking_enabled")]
        public bool BookingEnabled { get; set; }

        [JsonProperty("customer_timezone_choice")]
        public string CustomerTimezoneChoice { get; set; }

        [JsonProperty("booking_policy")]
        public string BookingPolicy { get; set; }

        [JsonProperty("allow_user_cancel")]
        public bool AllowUserCancel { get; set; }

        [JsonProperty("business_appointment_settings")]
        public BookingRetrieveProfileResponseBusinessBookingProfileTypeBusinessAppointmentSettingsType BusinessAppointmentSettings { get; set; }
    }

    public class BookingRetrieveProfileResponseBusinessBookingProfileTypeBusinessAppointmentSettingsType
    {
        [JsonProperty("location_types")]
        public string[] LocationTypes { get; set; }

        [JsonProperty("alignment_time")]
        public string AlignmentTime { get; set; }

        [JsonProperty("min_booking_lead_time_seconds")]
        public int MinBookingLeadTimeSeconds { get; set; }

        [JsonProperty("max_booking_lead_time_seconds")]
        public int MaxBookingLeadTimeSeconds { get; set; }

        [JsonProperty("any_team_member_booking_enabled")]
        public bool AnyTeamMemberBookingEnabled { get; set; }

        [JsonProperty("multiple_service_booking_enabled")]
        public bool MultipleServiceBookingEnabled { get; set; }

        [JsonProperty("cancellation_fee_money")]
        public BookingRetrieveProfileResponseBusinessBookingProfileTypeBusinessAppointmentSettingsTypeCancellationFeeMoneyType CancellationFeeMoney { get; set; }

        [JsonProperty("cancellation_policy")]
        public string CancellationPolicy { get; set; }

        [JsonProperty("skip_booking_flow_staff_selection")]
        public bool SkipBookingFlowStaffSelection { get; set; }
    }

    public class BookingRetrieveProfileResponseBusinessBookingProfileTypeBusinessAppointmentSettingsTypeCancellationFeeMoneyType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BookingListTeamProfilesResponse
    {
        [JsonProperty("team_member_booking_profiles")]
        public BookingListTeamProfilesResponseTeamMemberBookingProfilesTypeItem[] TeamMemberBookingProfiles { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }
    }

    public class BookingListTeamProfilesResponseTeamMemberBookingProfilesTypeItem
    {
        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("is_bookable")]
        public bool IsBookable { get; set; }
    }

    public class CashDrawerListShiftsResponse
    {
        [JsonProperty("items")]
        public CashDrawerListShiftsResponseItemsTypeItem[] Items { get; set; }
    }

    public class CashDrawerListShiftsResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("opened_at")]
        public string OpenedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("opened_cash_money")]
        public CashDrawerListShiftsResponseItemsTypeItemOpenedCashMoneyType OpenedCashMoney { get; set; }

        [JsonProperty("expected_cash_money")]
        public CashDrawerListShiftsResponseItemsTypeItemExpectedCashMoneyType ExpectedCashMoney { get; set; }

        [JsonProperty("closed_cash_money")]
        public CashDrawerListShiftsResponseItemsTypeItemClosedCashMoneyType ClosedCashMoney { get; set; }
    }

    public class CashDrawerListShiftsResponseItemsTypeItemOpenedCashMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerListShiftsResponseItemsTypeItemExpectedCashMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerListShiftsResponseItemsTypeItemClosedCashMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortOrderInput
    {
        ASC,
        DESC
    }

    public class CashDrawerRetrieveShiftResponse
    {
        [JsonProperty("cash_drawer_shift")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftType CashDrawerShift { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("opened_at")]
        public string OpenedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("opening_employee_id")]
        public string OpeningEmployeeId { get; set; }

        [JsonProperty("ending_employee_id")]
        public string EndingEmployeeId { get; set; }

        [JsonProperty("closing_employee_id")]
        public string ClosingEmployeeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("opened_cash_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeOpenedCashMoneyType OpenedCashMoney { get; set; }

        [JsonProperty("cash_payment_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashPaymentMoneyType CashPaymentMoney { get; set; }

        [JsonProperty("cash_refunds_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashRefundsMoneyType CashRefundsMoney { get; set; }

        [JsonProperty("cash_paid_in_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashPaidInMoneyType CashPaidInMoney { get; set; }

        [JsonProperty("cash_paid_out_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashPaidOutMoneyType CashPaidOutMoney { get; set; }

        [JsonProperty("expected_cash_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeExpectedCashMoneyType ExpectedCashMoney { get; set; }

        [JsonProperty("closed_cash_money")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeClosedCashMoneyType ClosedCashMoney { get; set; }

        [JsonProperty("device")]
        public CashDrawerRetrieveShiftResponseCashDrawerShiftTypeDeviceType Device { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeOpenedCashMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashPaymentMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashRefundsMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashPaidInMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeCashPaidOutMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeExpectedCashMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeClosedCashMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CashDrawerRetrieveShiftResponseCashDrawerShiftTypeDeviceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CashDrawerListEventsResponse
    {
        [JsonProperty("events")]
        public CashDrawerListEventsResponseEventsTypeItem[] Events { get; set; }
    }

    public class CashDrawerListEventsResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("event_money")]
        public CashDrawerListEventsResponseEventsTypeItemEventMoneyType EventMoney { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CashDrawerListEventsResponseEventsTypeItemEventMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponse
    {
        [JsonProperty("checkout")]
        public CheckoutCreateResponseCheckoutType Checkout { get; set; }
    }

    public class CheckoutCreateResponseCheckoutType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("checkout_page_url")]
        public string CheckoutPageUrl { get; set; }

        [JsonProperty("ask_for_shipping_address")]
        public bool AskForShippingAddress { get; set; }

        [JsonProperty("merchant_support_email")]
        public string MerchantSupportEmail { get; set; }

        [JsonProperty("pre_populate_buyer_email")]
        public string PrePopulateBuyerEmail { get; set; }

        [JsonProperty("pre_populate_shipping_address")]
        public CheckoutCreateResponseCheckoutTypePrePopulateShippingAddressType PrePopulateShippingAddress { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("order")]
        public CheckoutCreateResponseCheckoutTypeOrderType Order { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("additional_recipients")]
        public CheckoutCreateResponseCheckoutTypeAdditionalRecipientsTypeItem[] AdditionalRecipients { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypePrePopulateShippingAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("line_items")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("taxes")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("discounts")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeDiscountsTypeItem[] Discounts { get; set; }

        [JsonProperty("total_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeTotalMoneyType TotalMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeTotalDiscountMoneyType TotalDiscountMoney { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("applied_taxes")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedTaxesTypeItem[] AppliedTaxes { get; set; }

        [JsonProperty("applied_discounts")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }

        [JsonProperty("base_price_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("total_tax_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemTotalTaxMoneyType TotalTaxMoney { get; set; }

        [JsonProperty("total_discount_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemTotalDiscountMoneyType TotalDiscountMoney { get; set; }

        [JsonProperty("total_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemTotalMoneyType TotalMoney { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedTaxesTypeItem
    {
        [JsonProperty("tax_uid")]
        public string TaxUid { get; set; }

        [JsonProperty("applied_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedTaxesTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedTaxesTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }

        [JsonProperty("applied_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemAppliedDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeLineItemsTypeItemTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeTaxesTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("amount_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeDiscountsTypeItemAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("applied_money")]
        public CheckoutCreateResponseCheckoutTypeOrderTypeDiscountsTypeItemAppliedMoneyType AppliedMoney { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeDiscountsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeDiscountsTypeItemAppliedMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeTotalMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeTotalTaxMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeOrderTypeTotalDiscountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeAdditionalRecipientsTypeItem
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("amount_money")]
        public CheckoutCreateResponseCheckoutTypeAdditionalRecipientsTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class CheckoutCreateResponseCheckoutTypeAdditionalRecipientsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodyorderorderlineItemsInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public bodyorderorderlineItemsInputItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("applied_discounts")]
        public bodyorderorderlineItemsInputItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }

        [JsonProperty("applied_taxes")]
        public bodyorderorderlineItemsInputItemAppliedTaxesTypeItem[] AppliedTaxes { get; set; }
    }

    public class bodyorderorderlineItemsInputItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodyorderorderlineItemsInputItemAppliedDiscountsTypeItem
    {
        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }
    }

    public class bodyorderorderlineItemsInputItemAppliedTaxesTypeItem
    {
        [JsonProperty("tax_uid")]
        public string TaxUid { get; set; }
    }

    public class bodyorderordertaxesInputItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class bodyorderorderdiscountsInputItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("amount_money")]
        public bodyorderorderdiscountsInputItemAmountMoneyType AmountMoney { get; set; }
    }

    public class bodyorderorderdiscountsInputItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodyadditionalRecipientsInputItem
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("amount_money")]
        public bodyadditionalRecipientsInputItemAmountMoneyType AmountMoney { get; set; }
    }

    public class bodyadditionalRecipientsInputItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class DeviceListResponse
    {
        [JsonProperty("device_codes")]
        public DeviceListResponseDeviceCodesTypeItem[] DeviceCodes { get; set; }
    }

    public class DeviceListResponseDeviceCodesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("pair_by")]
        public string PairBy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("status_changed_at")]
        public string StatusChangedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        UNKNOWN,
        UNPAIRED,
        PAIRED,
        EXPIRED
    }

    public class DeviceCreateResponse
    {
        [JsonProperty("device_code")]
        public DeviceCreateResponseDeviceCodeType DeviceCode { get; set; }
    }

    public class DeviceCreateResponseDeviceCodeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("pair_by")]
        public string PairBy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_changed_at")]
        public string StatusChangedAt { get; set; }
    }

    public class DeviceGetResponse
    {
        [JsonProperty("device_code")]
        public DeviceGetResponseDeviceCodeType DeviceCode { get; set; }
    }

    public class DeviceGetResponseDeviceCodeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("pair_by")]
        public string PairBy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("status_changed_at")]
        public string StatusChangedAt { get; set; }
    }

    public class GiftCardListResponse
    {
        [JsonProperty("gift_card_activities")]
        public GiftCardListResponseGiftCardActivitiesTypeItem[] GiftCardActivities { get; set; }
    }

    public class GiftCardListResponseGiftCardActivitiesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("gift_card_id")]
        public string GiftCardId { get; set; }

        [JsonProperty("gift_card_gan")]
        public string GiftCardGan { get; set; }

        [JsonProperty("gift_card_balance_money")]
        public GiftCardListResponseGiftCardActivitiesTypeItemGiftCardBalanceMoneyType GiftCardBalanceMoney { get; set; }

        [JsonProperty("redeem_activity_details")]
        public GiftCardListResponseGiftCardActivitiesTypeItemRedeemActivityDetailsType RedeemActivityDetails { get; set; }

        [JsonProperty("activate_activity_details")]
        public GiftCardListResponseGiftCardActivitiesTypeItemActivateActivityDetailsType ActivateActivityDetails { get; set; }
    }

    public class GiftCardListResponseGiftCardActivitiesTypeItemGiftCardBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardListResponseGiftCardActivitiesTypeItemRedeemActivityDetailsType
    {
        [JsonProperty("amount_money")]
        public GiftCardListResponseGiftCardActivitiesTypeItemRedeemActivityDetailsTypeAmountMoneyType AmountMoney { get; set; }
    }

    public class GiftCardListResponseGiftCardActivitiesTypeItemRedeemActivityDetailsTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardListResponseGiftCardActivitiesTypeItemActivateActivityDetailsType
    {
        [JsonProperty("amount_money")]
        public GiftCardListResponseGiftCardActivitiesTypeItemActivateActivityDetailsTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("line_item_uid")]
        public string LineItemUid { get; set; }
    }

    public class GiftCardListResponseGiftCardActivitiesTypeItemActivateActivityDetailsTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardCreateResponse
    {
        [JsonProperty("gift_card_activity")]
        public GiftCardCreateResponseGiftCardActivityType GiftCardActivity { get; set; }
    }

    public class GiftCardCreateResponseGiftCardActivityType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("gift_card_id")]
        public string GiftCardId { get; set; }

        [JsonProperty("gift_card_gan")]
        public string GiftCardGan { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gift_card_balance_money")]
        public GiftCardCreateResponseGiftCardActivityTypeGiftCardBalanceMoneyType GiftCardBalanceMoney { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("activate_activity_details")]
        public GiftCardCreateResponseGiftCardActivityTypeActivateActivityDetailsType ActivateActivityDetails { get; set; }
    }

    public class GiftCardCreateResponseGiftCardActivityTypeGiftCardBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardCreateResponseGiftCardActivityTypeActivateActivityDetailsType
    {
        [JsonProperty("amount_money")]
        public GiftCardCreateResponseGiftCardActivityTypeActivateActivityDetailsTypeAmountMoneyType AmountMoney { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("line_item_uid")]
        public string LineItemUid { get; set; }
    }

    public class GiftCardCreateResponseGiftCardActivityTypeActivateActivityDetailsTypeAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftCardActivitytypeInput
    {
        ACTIVATE,
        LOAD,
        REDEEM,
        [EnumMember(Value = "CLEAR_BALANCE")]
        CLEARBALANCE,
        DEACTIVATE,
        [EnumMember(Value = "ADJUST_INCREMENT")]
        ADJUSTINCREMENT,
        [EnumMember(Value = "ADJUST_DECREMENT")]
        ADJUSTDECREMENT,
        REFUND,
        [EnumMember(Value = "UNLINKED_ACTIVITY_REFUND")]
        UNLINKEDACTIVITYREFUND,
        IMPORT,
        BLOCK,
        UNBLOCK,
        [EnumMember(Value = "IMPORT_REVERSAL")]
        IMPORTREVERSAL
    }

    public class GiftCardRetrieveGANResponse
    {
        [JsonProperty("gift_card")]
        public GiftCardRetrieveGANResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardRetrieveGANResponseGiftCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gan_source")]
        public string GanSource { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("balance_money")]
        public GiftCardRetrieveGANResponseGiftCardTypeBalanceMoneyType BalanceMoney { get; set; }

        [JsonProperty("gan")]
        public string Gan { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GiftCardRetrieveGANResponseGiftCardTypeBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardRetrieveNonceResponse
    {
        [JsonProperty("gift_card")]
        public GiftCardRetrieveNonceResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardRetrieveNonceResponseGiftCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gan_source")]
        public string GanSource { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("balance_money")]
        public GiftCardRetrieveNonceResponseGiftCardTypeBalanceMoneyType BalanceMoney { get; set; }

        [JsonProperty("gan")]
        public string Gan { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GiftCardRetrieveNonceResponseGiftCardTypeBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardLinkResponse
    {
        [JsonProperty("gift_card")]
        public GiftCardLinkResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardLinkResponseGiftCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gan_source")]
        public string GanSource { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("balance_money")]
        public GiftCardLinkResponseGiftCardTypeBalanceMoneyType BalanceMoney { get; set; }

        [JsonProperty("gan")]
        public string Gan { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("customer_ids")]
        public string[] CustomerIds { get; set; }
    }

    public class GiftCardLinkResponseGiftCardTypeBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardUnlinkResponse
    {
        [JsonProperty("gift_card")]
        public GiftCardUnlinkResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardUnlinkResponseGiftCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gan_source")]
        public string GanSource { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("balance_money")]
        public GiftCardUnlinkResponseGiftCardTypeBalanceMoneyType BalanceMoney { get; set; }

        [JsonProperty("gan")]
        public string Gan { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GiftCardUnlinkResponseGiftCardTypeBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardRetrieveResponse
    {
        [JsonProperty("gift_card")]
        public GiftCardRetrieveResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardRetrieveResponseGiftCardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("gan_source")]
        public string GanSource { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("balance_money")]
        public GiftCardRetrieveResponseGiftCardTypeBalanceMoneyType BalanceMoney { get; set; }

        [JsonProperty("gan")]
        public string Gan { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GiftCardRetrieveResponseGiftCardTypeBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborListBreakResponse
    {
        [JsonProperty("break_types")]
        public LaborListBreakResponseBreakTypesTypeItem[] BreakTypes { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class LaborListBreakResponseBreakTypesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("break_name")]
        public string BreakName { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborCreateBreakResponse
    {
        [JsonProperty("break_type")]
        public LaborCreateBreakResponseBreakTypeType BreakType { get; set; }
    }

    public class LaborCreateBreakResponseBreakTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("break_name")]
        public string BreakName { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborGetBreakResponse
    {
        [JsonProperty("break_type")]
        public LaborGetBreakResponseBreakTypeType BreakType { get; set; }
    }

    public class LaborGetBreakResponseBreakTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("break_name")]
        public string BreakName { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborUpdateBreakResponse
    {
        [JsonProperty("break_type")]
        public LaborUpdateBreakResponseBreakTypeType BreakType { get; set; }
    }

    public class LaborUpdateBreakResponseBreakTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("break_name")]
        public string BreakName { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborCreateShiftResponse
    {
        [JsonProperty("shift")]
        public LaborCreateShiftResponseShiftType Shift { get; set; }
    }

    public class LaborCreateShiftResponseShiftType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("wage")]
        public LaborCreateShiftResponseShiftTypeWageType Wage { get; set; }

        [JsonProperty("breaks")]
        public LaborCreateShiftResponseShiftTypeBreaksTypeItem[] Breaks { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborCreateShiftResponseShiftTypeWageType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public LaborCreateShiftResponseShiftTypeWageTypeHourlyRateType HourlyRate { get; set; }
    }

    public class LaborCreateShiftResponseShiftTypeWageTypeHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborCreateShiftResponseShiftTypeBreaksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("break_type_id")]
        public string BreakTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }
    }

    public class bodyshiftbreaksInputItem
    {
        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("break_type_id")]
        public string BreakTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }
    }

    public class LaborSearchShiftsResponse
    {
        [JsonProperty("shifts")]
        public LaborSearchShiftsResponseShiftsTypeItem[] Shifts { get; set; }
    }

    public class LaborSearchShiftsResponseShiftsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("wage")]
        public LaborSearchShiftsResponseShiftsTypeItemWageType Wage { get; set; }

        [JsonProperty("breaks")]
        public LaborSearchShiftsResponseShiftsTypeItemBreaksTypeItem[] Breaks { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborSearchShiftsResponseShiftsTypeItemWageType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public LaborSearchShiftsResponseShiftsTypeItemWageTypeHourlyRateType HourlyRate { get; set; }
    }

    public class LaborSearchShiftsResponseShiftsTypeItemWageTypeHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborSearchShiftsResponseShiftsTypeItemBreaksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("break_type_id")]
        public string BreakTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }
    }

    public class LaborGetShiftResponse
    {
        [JsonProperty("shift")]
        public LaborGetShiftResponseShiftType Shift { get; set; }
    }

    public class LaborGetShiftResponseShiftType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("wage")]
        public LaborGetShiftResponseShiftTypeWageType Wage { get; set; }

        [JsonProperty("breaks")]
        public LaborGetShiftResponseShiftTypeBreaksTypeItem[] Breaks { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborGetShiftResponseShiftTypeWageType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public LaborGetShiftResponseShiftTypeWageTypeHourlyRateType HourlyRate { get; set; }
    }

    public class LaborGetShiftResponseShiftTypeWageTypeHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborGetShiftResponseShiftTypeBreaksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("break_type_id")]
        public string BreakTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }
    }

    public class LaborUpdateShiftResponse
    {
        [JsonProperty("shift")]
        public LaborUpdateShiftResponseShiftType Shift { get; set; }
    }

    public class LaborUpdateShiftResponseShiftType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("employee_id")]
        public string EmployeeId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("wage")]
        public LaborUpdateShiftResponseShiftTypeWageType Wage { get; set; }

        [JsonProperty("breaks")]
        public LaborUpdateShiftResponseShiftTypeBreaksTypeItem[] Breaks { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborUpdateShiftResponseShiftTypeWageType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public LaborUpdateShiftResponseShiftTypeWageTypeHourlyRateType HourlyRate { get; set; }
    }

    public class LaborUpdateShiftResponseShiftTypeWageTypeHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborUpdateShiftResponseShiftTypeBreaksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("break_type_id")]
        public string BreakTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }
    }

    public class bodyshiftbreaksInputItem2
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("break_type_id")]
        public string BreakTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool IsPaid { get; set; }
    }

    public class LaborListWagesResponse
    {
        [JsonProperty("team_member_wages")]
        public LaborListWagesResponseTeamMemberWagesTypeItem[] TeamMemberWages { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class LaborListWagesResponseTeamMemberWagesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public LaborListWagesResponseTeamMemberWagesTypeItemHourlyRateType HourlyRate { get; set; }
    }

    public class LaborListWagesResponseTeamMemberWagesTypeItemHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborGetWageResponse
    {
        [JsonProperty("team_member_wage")]
        public LaborGetWageResponseTeamMemberWageType TeamMemberWage { get; set; }
    }

    public class LaborGetWageResponseTeamMemberWageType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public LaborGetWageResponseTeamMemberWageTypeHourlyRateType HourlyRate { get; set; }
    }

    public class LaborGetWageResponseTeamMemberWageTypeHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborListConfigsResponse
    {
        [JsonProperty("workweek_configs")]
        public LaborListConfigsResponseWorkweekConfigsTypeItem[] WorkweekConfigs { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class LaborListConfigsResponseWorkweekConfigsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_of_week")]
        public string StartOfWeek { get; set; }

        [JsonProperty("start_of_day_local_time")]
        public string StartOfDayLocalTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LaborUpdateConfigResponse
    {
        [JsonProperty("workweek_config")]
        public LaborUpdateConfigResponseWorkweekConfigType WorkweekConfig { get; set; }
    }

    public class LaborUpdateConfigResponseWorkweekConfigType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("start_of_week")]
        public string StartOfWeek { get; set; }

        [JsonProperty("start_of_day_local_time")]
        public string StartOfDayLocalTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LocationListResponse
    {
        [JsonProperty("locations")]
        public LocationListResponseLocationsTypeItem[] Locations { get; set; }
    }

    public class LocationListResponseLocationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public LocationListResponseLocationsTypeItemAddressType Address { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
    }

    public class LocationListResponseLocationsTypeItemAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class LocationCreateResponse
    {
        [JsonProperty("location")]
        public LocationCreateResponseLocationType Location { get; set; }
    }

    public class LocationCreateResponseLocationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public LocationCreateResponseLocationTypeAddressType Address { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonProperty("coordinates")]
        public LocationCreateResponseLocationTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }
    }

    public class LocationCreateResponseLocationTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }

    public class LocationCreateResponseLocationTypeCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class LocationRetrieveResponse
    {
        [JsonProperty("location")]
        public LocationRetrieveResponseLocationType Location { get; set; }
    }

    public class LocationRetrieveResponseLocationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public LocationRetrieveResponseLocationTypeAddressType Address { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }
    }

    public class LocationRetrieveResponseLocationTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class LocationUpdateResponse
    {
        [JsonProperty("location")]
        public LocationUpdateResponseLocationType Location { get; set; }
    }

    public class LocationUpdateResponseLocationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public LocationUpdateResponseLocationTypeAddressType Address { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("business_hours")]
        public LocationUpdateResponseLocationTypeBusinessHoursType BusinessHours { get; set; }

        [JsonProperty("business_email")]
        public string BusinessEmail { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUsername { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUsername { get; set; }

        [JsonProperty("coordinates")]
        public LocationUpdateResponseLocationTypeCoordinatesType Coordinates { get; set; }

        [JsonProperty("mcc")]
        public string Mcc { get; set; }
    }

    public class LocationUpdateResponseLocationTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }

    public class LocationUpdateResponseLocationTypeBusinessHoursType
    {
        [JsonProperty("periods")]
        public LocationUpdateResponseLocationTypeBusinessHoursTypePeriodsTypeItem[] Periods { get; set; }
    }

    public class LocationUpdateResponseLocationTypeBusinessHoursTypePeriodsTypeItem
    {
        [JsonProperty("day_of_week")]
        public string DayOfWeek { get; set; }

        [JsonProperty("start_local_time")]
        public string StartLocalTime { get; set; }

        [JsonProperty("end_local_time")]
        public string EndLocalTime { get; set; }
    }

    public class LocationUpdateResponseLocationTypeCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class bodylocationbusinessHoursperiodsInputItem
    {
        [JsonProperty("day_of_week")]
        public string DayOfWeek { get; set; }

        [JsonProperty("start_local_time")]
        public string StartLocalTime { get; set; }

        [JsonProperty("end_local_time")]
        public string EndLocalTime { get; set; }
    }

    public class LoyaltyCreateAccountResponse
    {
        [JsonProperty("loyalty_account")]
        public LoyaltyCreateAccountResponseLoyaltyAccountType LoyaltyAccount { get; set; }
    }

    public class LoyaltyCreateAccountResponseLoyaltyAccountType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mapping")]
        public LoyaltyCreateAccountResponseLoyaltyAccountTypeMappingType Mapping { get; set; }

        [JsonProperty("program_id")]
        public string ProgramId { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("lifetime_points")]
        public int LifetimePoints { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LoyaltyCreateAccountResponseLoyaltyAccountTypeMappingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class LoyaltySearchAccountsResponse
    {
        [JsonProperty("loyalty_accounts")]
        public LoyaltySearchAccountsResponseLoyaltyAccountsTypeItem[] LoyaltyAccounts { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class LoyaltySearchAccountsResponseLoyaltyAccountsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mapping")]
        public LoyaltySearchAccountsResponseLoyaltyAccountsTypeItemMappingType Mapping { get; set; }

        [JsonProperty("program_id")]
        public string ProgramId { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("lifetime_points")]
        public int LifetimePoints { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LoyaltySearchAccountsResponseLoyaltyAccountsTypeItemMappingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class LoyaltyRetrieveAccountResponse
    {
        [JsonProperty("loyalty_account")]
        public LoyaltyRetrieveAccountResponseLoyaltyAccountType LoyaltyAccount { get; set; }
    }

    public class LoyaltyRetrieveAccountResponseLoyaltyAccountType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mapping")]
        public LoyaltyRetrieveAccountResponseLoyaltyAccountTypeMappingType Mapping { get; set; }

        [JsonProperty("program_id")]
        public string ProgramId { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("lifetime_points")]
        public int LifetimePoints { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LoyaltyRetrieveAccountResponseLoyaltyAccountTypeMappingType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class LoyaltyAccumulatePointsResponse
    {
        [JsonProperty("event")]
        public LoyaltyAccumulatePointsResponseEventType Event { get; set; }
    }

    public class LoyaltyAccumulatePointsResponseEventType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("accumulate_points")]
        public LoyaltyAccumulatePointsResponseEventTypeAccumulatePointsType AccumulatePoints { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class LoyaltyAccumulatePointsResponseEventTypeAccumulatePointsType
    {
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }

    public class LoyaltyAdjustPointsResponse
    {
        [JsonProperty("event")]
        public LoyaltyAdjustPointsResponseEventType Event { get; set; }
    }

    public class LoyaltyAdjustPointsResponseEventType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("adjust_points")]
        public LoyaltyAdjustPointsResponseEventTypeAdjustPointsType AdjustPoints { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class LoyaltyAdjustPointsResponseEventTypeAdjustPointsType
    {
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class LoyaltySearchEventsResponse
    {
        [JsonProperty("events")]
        public LoyaltySearchEventsResponseEventsTypeItem[] Events { get; set; }
    }

    public class LoyaltySearchEventsResponseEventsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("accumulate_points")]
        public LoyaltySearchEventsResponseEventsTypeItemAccumulatePointsType AccumulatePoints { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("redeem_reward")]
        public LoyaltySearchEventsResponseEventsTypeItemRedeemRewardType RedeemReward { get; set; }

        [JsonProperty("create_reward")]
        public LoyaltySearchEventsResponseEventsTypeItemCreateRewardType CreateReward { get; set; }
    }

    public class LoyaltySearchEventsResponseEventsTypeItemAccumulatePointsType
    {
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }

    public class LoyaltySearchEventsResponseEventsTypeItemRedeemRewardType
    {
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; set; }

        [JsonProperty("reward_id")]
        public string RewardId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }

    public class LoyaltySearchEventsResponseEventsTypeItemCreateRewardType
    {
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; set; }

        [JsonProperty("reward_id")]
        public string RewardId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }

    public class LoyaltyRetrieveProgramResponse
    {
        [JsonProperty("program")]
        public LoyaltyRetrieveProgramResponseProgramType Program { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reward_tiers")]
        public LoyaltyRetrieveProgramResponseProgramTypeRewardTiersTypeItem[] RewardTiers { get; set; }

        [JsonProperty("terminology")]
        public LoyaltyRetrieveProgramResponseProgramTypeTerminologyType Terminology { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("accrual_rules")]
        public LoyaltyRetrieveProgramResponseProgramTypeAccrualRulesTypeItem[] AccrualRules { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramTypeRewardTiersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("definition")]
        public LoyaltyRetrieveProgramResponseProgramTypeRewardTiersTypeItemDefinitionType Definition { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("pricing_rule_reference")]
        public LoyaltyRetrieveProgramResponseProgramTypeRewardTiersTypeItemPricingRuleReferenceType PricingRuleReference { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramTypeRewardTiersTypeItemDefinitionType
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("percentage_discount")]
        public string PercentageDiscount { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramTypeRewardTiersTypeItemPricingRuleReferenceType
    {
        [JsonProperty("object_id")]
        public string ObjectId { get; set; }

        [JsonProperty("catalog_version")]
        public string CatalogVersion { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramTypeTerminologyType
    {
        [JsonProperty("one")]
        public string One { get; set; }

        [JsonProperty("other")]
        public string Other { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramTypeAccrualRulesTypeItem
    {
        [JsonProperty("accrual_type")]
        public string AccrualType { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("spend_amount_money")]
        public LoyaltyRetrieveProgramResponseProgramTypeAccrualRulesTypeItemSpendAmountMoneyType SpendAmountMoney { get; set; }

        [JsonProperty("excluded_category_ids")]
        public string[] ExcludedCategoryIds { get; set; }

        [JsonProperty("excluded_item_variation_ids")]
        public string[] ExcludedItemVariationIds { get; set; }
    }

    public class LoyaltyRetrieveProgramResponseProgramTypeAccrualRulesTypeItemSpendAmountMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

    public class LoyaltyCalculatePointsResponse
    {
        [JsonProperty("points")]
        public int Points { get; set; }
    }

    public class LoyaltyCreateRewardResponse
    {
        [JsonProperty("reward")]
        public LoyaltyCreateRewardResponseRewardType Reward { get; set; }
    }

    public class LoyaltyCreateRewardResponseRewardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("reward_tier_id")]
        public string RewardTierId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LoyaltySearchRewardsResponse
    {
        [JsonProperty("rewards")]
        public LoyaltySearchRewardsResponseRewardsTypeItem[] Rewards { get; set; }
    }

    public class LoyaltySearchRewardsResponseRewardsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("reward_tier_id")]
        public string RewardTierId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("redeemed_at")]
        public string RedeemedAt { get; set; }
    }

    public class LoyaltyRetrieveRewardResponse
    {
        [JsonProperty("reward")]
        public LoyaltyRetrieveRewardResponseRewardType Reward { get; set; }
    }

    public class LoyaltyRetrieveRewardResponseRewardType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("reward_tier_id")]
        public string RewardTierId { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("redeemed_at")]
        public string RedeemedAt { get; set; }
    }

    public class LoyaltyRedeemRewardResponse
    {
        [JsonProperty("event")]
        public LoyaltyRedeemRewardResponseEventType Event { get; set; }
    }

    public class LoyaltyRedeemRewardResponseEventType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("redeem_reward")]
        public LoyaltyRedeemRewardResponseEventTypeRedeemRewardType RedeemReward { get; set; }

        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class LoyaltyRedeemRewardResponseEventTypeRedeemRewardType
    {
        [JsonProperty("loyalty_program_id")]
        public string LoyaltyProgramId { get; set; }

        [JsonProperty("reward_id")]
        public string RewardId { get; set; }
    }

    public class MerchantListResponse
    {
        [JsonProperty("merchant")]
        public MerchantListResponseMerchantTypeItem[] Merchant { get; set; }
    }

    public class MerchantListResponseMerchantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("main_location_id")]
        public string MainLocationId { get; set; }
    }

    public class MerchantRetrieveResponse
    {
        [JsonProperty("merchant")]
        public MerchantRetrieveResponseMerchantType Merchant { get; set; }
    }

    public class MerchantRetrieveResponseMerchantType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("main_location_id")]
        public string MainLocationId { get; set; }
    }

    public class MobileAuthorizationCreateResponse
    {
        [JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }
    }

    public class SiteListResponse
    {
        [JsonProperty("sites")]
        public SiteListResponseSitesTypeItem[] Sites { get; set; }
    }

    public class SiteListResponseSitesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("site_title")]
        public string SiteTitle { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("is_published")]
        public bool IsPublished { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class SnippetRetrieveResponse
    {
        [JsonProperty("snippet")]
        public SnippetRetrieveResponseSnippetType Snippet { get; set; }
    }

    public class SnippetRetrieveResponseSnippetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class SnippetUpsertResponse
    {
        [JsonProperty("snippet")]
        public SnippetUpsertResponseSnippetType Snippet { get; set; }
    }

    public class SnippetUpsertResponseSnippetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TeamCreateMemberResponse
    {
        [JsonProperty("team_member")]
        public TeamCreateMemberResponseTeamMemberType TeamMember { get; set; }
    }

    public class TeamCreateMemberResponseTeamMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamCreateMemberResponseTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class TeamCreateMemberResponseTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }
    }

    public class TeamCreateBulkMembersResponse
    {
        [JsonProperty("team_members")]
        public TeamCreateBulkMembersResponseTeamMembersType TeamMembers { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersType
    {
        [JsonProperty("idempotency-key-1")]
        public TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey1Type IdempotencyKey1 { get; set; }

        [JsonProperty("idempotency-key-2")]
        public TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey2Type IdempotencyKey2 { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey1Type
    {
        [JsonProperty("team_member")]
        public TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey1TypeTeamMemberType TeamMember { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey1TypeTeamMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey1TypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey1TypeTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey2Type
    {
        [JsonProperty("team_member")]
        public TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey2TypeTeamMemberType TeamMember { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey2TypeTeamMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey2TypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class TeamCreateBulkMembersResponseTeamMembersTypeIdempotencyKey2TypeTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }
    }

    public class TeamUpdateBulkMembersResponse
    {
        [JsonProperty("team_members")]
        public TeamUpdateBulkMembersResponseTeamMembersType TeamMembers { get; set; }
    }

    public class TeamUpdateBulkMembersResponseTeamMembersType
    {
        [JsonProperty("team_member_id")]
        public TeamUpdateBulkMembersResponseTeamMembersTypeTeamMemberIdType TeamMemberId { get; set; }
    }

    public class TeamUpdateBulkMembersResponseTeamMembersTypeTeamMemberIdType
    {
        [JsonProperty("team_member")]
        public TeamUpdateBulkMembersResponseTeamMembersTypeTeamMemberIdTypeTeamMemberType TeamMember { get; set; }
    }

    public class TeamUpdateBulkMembersResponseTeamMembersTypeTeamMemberIdTypeTeamMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamUpdateBulkMembersResponseTeamMembersTypeTeamMemberIdTypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class TeamUpdateBulkMembersResponseTeamMembersTypeTeamMemberIdTypeTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }
    }

    public class TeamSearchResponse
    {
        [JsonProperty("team_members")]
        public TeamSearchResponseTeamMembersTypeItem[] TeamMembers { get; set; }

        [JsonProperty("cursor")]
        public string Cursor { get; set; }
    }

    public class TeamSearchResponseTeamMembersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamSearchResponseTeamMembersTypeItemAssignedLocationsType AssignedLocations { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class TeamSearchResponseTeamMembersTypeItemAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }
    }

    public class TeamRetrieveMemberResponse
    {
        [JsonProperty("team_member")]
        public TeamRetrieveMemberResponseTeamMemberType TeamMember { get; set; }
    }

    public class TeamRetrieveMemberResponseTeamMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamRetrieveMemberResponseTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class TeamRetrieveMemberResponseTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }
    }

    public class TeamUpdateResponse
    {
        [JsonProperty("team_member")]
        public TeamUpdateResponseTeamMemberType TeamMember { get; set; }
    }

    public class TeamUpdateResponseTeamMemberType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool IsOwner { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("assigned_locations")]
        public TeamUpdateResponseTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class TeamUpdateResponseTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }

        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }
    }

    public class TeamRetrieveWageResponse
    {
        [JsonProperty("wage_setting")]
        public TeamRetrieveWageResponseWageSettingType WageSetting { get; set; }
    }

    public class TeamRetrieveWageResponseWageSettingType
    {
        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("job_assignments")]
        public TeamRetrieveWageResponseWageSettingTypeJobAssignmentsTypeItem[] JobAssignments { get; set; }

        [JsonProperty("is_overtime_exempt")]
        public bool IsOvertimeExempt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TeamRetrieveWageResponseWageSettingTypeJobAssignmentsTypeItem
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        [JsonProperty("hourly_rate")]
        public TeamRetrieveWageResponseWageSettingTypeJobAssignmentsTypeItemHourlyRateType HourlyRate { get; set; }

        [JsonProperty("annual_rate")]
        public TeamRetrieveWageResponseWageSettingTypeJobAssignmentsTypeItemAnnualRateType AnnualRate { get; set; }

        [JsonProperty("weekly_hours")]
        public int WeeklyHours { get; set; }
    }

    public class TeamRetrieveWageResponseWageSettingTypeJobAssignmentsTypeItemHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TeamRetrieveWageResponseWageSettingTypeJobAssignmentsTypeItemAnnualRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TeamUpdateWageResponse
    {
        [JsonProperty("wage_setting")]
        public TeamUpdateWageResponseWageSettingType WageSetting { get; set; }
    }

    public class TeamUpdateWageResponseWageSettingType
    {
        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("job_assignments")]
        public TeamUpdateWageResponseWageSettingTypeJobAssignmentsTypeItem[] JobAssignments { get; set; }

        [JsonProperty("is_overtime_exempt")]
        public bool IsOvertimeExempt { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TeamUpdateWageResponseWageSettingTypeJobAssignmentsTypeItem
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        [JsonProperty("hourly_rate")]
        public TeamUpdateWageResponseWageSettingTypeJobAssignmentsTypeItemHourlyRateType HourlyRate { get; set; }

        [JsonProperty("annual_rate")]
        public TeamUpdateWageResponseWageSettingTypeJobAssignmentsTypeItemAnnualRateType AnnualRate { get; set; }

        [JsonProperty("weekly_hours")]
        public int WeeklyHours { get; set; }
    }

    public class TeamUpdateWageResponseWageSettingTypeJobAssignmentsTypeItemHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class TeamUpdateWageResponseWageSettingTypeJobAssignmentsTypeItemAnnualRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodywageSettingjobAssignmentsInputItem
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        [JsonProperty("annual_rate")]
        public bodywageSettingjobAssignmentsInputItemAnnualRateType AnnualRate { get; set; }

        [JsonProperty("weekly_hours")]
        public int WeeklyHours { get; set; }

        [JsonProperty("hourly_rate")]
        public bodywageSettingjobAssignmentsInputItemHourlyRateType HourlyRate { get; set; }
    }

    public class bodywageSettingjobAssignmentsInputItemAnnualRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class bodywageSettingjobAssignmentsInputItemHourlyRateType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BankAccountGetV1Response
    {
        [JsonProperty("bank_account")]
        public BankAccountGetV1ResponseBankAccountType BankAccount { get; set; }
    }

    public class BankAccountGetV1ResponseBankAccountType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("account_number_suffix")]
        public string AccountNumberSuffix { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("holder_name")]
        public string HolderName { get; set; }

        [JsonProperty("primary_bank_identification_number")]
        public string PrimaryBankIdentificationNumber { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("creditable")]
        public bool Creditable { get; set; }

        [JsonProperty("debitable")]
        public bool Debitable { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Squarebusinessip;

    public partial class WorkflowManagedActions
    {
        public SquarebusinessipActions Squarebusinessip(string connectionId) => new SquarebusinessipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SquarebusinessipTriggers Squarebusinessip(string connectionId) => new SquarebusinessipTriggers(connectionId);
    }
}