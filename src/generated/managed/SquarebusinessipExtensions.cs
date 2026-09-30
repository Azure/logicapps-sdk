//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Squarebusinessip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SquarebusinessipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BankAccountListResponse> BankAccountList([WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> locationId = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(locationId, nameof(locationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bank-accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                return callPayload;
            }

            return new ApiConnectionAction<BankAccountListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingCreateResponse> BookingCreate([WorkflowExpression] Func<string> bodybookingcustomerId = null, [WorkflowExpression] Func<string> bodybookingstartAt = null, [WorkflowExpression] Func<string> bodybookinglocationId = null, [WorkflowExpression] Func<bodybookingappointmentSegmentsInputItem[]> bodybookingappointmentSegments = null)
        {
            SourceExpression.Validate(bodybookingcustomerId, nameof(bodybookingcustomerId), required: false);
            SourceExpression.Validate(bodybookingstartAt, nameof(bodybookingstartAt), required: false);
            SourceExpression.Validate(bodybookinglocationId, nameof(bodybookinglocationId), required: false);
            SourceExpression.Validate(bodybookingappointmentSegments, nameof(bodybookingappointmentSegments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var bookingObject = new JObject();
                var bookingObjectpropCount = 0;
                if (bodybookingcustomerId != null)
                {
                    bookingObject["customer_id"] = SourceExpressionConverter.ConvertToken(bodybookingcustomerId);
                    bookingObjectpropCount++;
                }

                if (bodybookingstartAt != null)
                {
                    bookingObject["start_at"] = SourceExpressionConverter.ConvertToken(bodybookingstartAt);
                    bookingObjectpropCount++;
                }

                if (bodybookinglocationId != null)
                {
                    bookingObject["location_id"] = SourceExpressionConverter.ConvertToken(bodybookinglocationId);
                    bookingObjectpropCount++;
                }

                if (bodybookingappointmentSegments != null)
                {
                    bookingObject["appointment_segments"] = SourceExpressionConverter.ConvertToken(bodybookingappointmentSegments);
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
                return callPayload;
            }

            return new ApiConnectionAction<BookingCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingAvailabilityResponse> BookingAvailability([WorkflowExpression] Func<string> bodyqueryfilterstartAtRangestartAt = null, [WorkflowExpression] Func<string> bodyqueryfilterstartAtRangeendAt = null, [WorkflowExpression] Func<string> bodyqueryfilterlocationId = null, [WorkflowExpression] Func<bodyqueryfiltersegmentFiltersInputItem[]> bodyqueryfiltersegmentFilters = null)
        {
            SourceExpression.Validate(bodyqueryfilterstartAtRangestartAt, nameof(bodyqueryfilterstartAtRangestartAt), required: false);
            SourceExpression.Validate(bodyqueryfilterstartAtRangeendAt, nameof(bodyqueryfilterstartAtRangeendAt), required: false);
            SourceExpression.Validate(bodyqueryfilterlocationId, nameof(bodyqueryfilterlocationId), required: false);
            SourceExpression.Validate(bodyqueryfiltersegmentFilters, nameof(bodyqueryfiltersegmentFilters), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyqueryfilterstartAtRangestartAt != null)
                {
                    startAtRangeObject["start_at"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterstartAtRangestartAt);
                    startAtRangeObjectpropCount++;
                }

                if (bodyqueryfilterstartAtRangeendAt != null)
                {
                    startAtRangeObject["end_at"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterstartAtRangeendAt);
                    startAtRangeObjectpropCount++;
                }

                if (startAtRangeObjectpropCount > 0)
                {
                    filterObject["start_at_range"] = startAtRangeObject;
                    filterObjectpropCount++;
                }

                if (bodyqueryfilterlocationId != null)
                {
                    filterObject["location_id"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterlocationId);
                    filterObjectpropCount++;
                }

                if (bodyqueryfiltersegmentFilters != null)
                {
                    filterObject["segment_filters"] = SourceExpressionConverter.ConvertToken(bodyqueryfiltersegmentFilters);
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
                return callPayload;
            }

            return new ApiConnectionAction<BookingAvailabilityResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingRetrieveProfileResponse> BookingRetrieveProfile()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookings/business-booking-profile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BookingRetrieveProfileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingListTeamProfilesResponse> BookingListTeamProfiles([WorkflowExpression] Func<bool> bookableOnly = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> locationId = null)
        {
            SourceExpression.Validate(bookableOnly, nameof(bookableOnly), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(locationId, nameof(locationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bookings/team-member-booking-profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (bookableOnly != null)
                    callPayload.Queries["bookable_only"] = SourceExpressionConverter.ConvertO(bookableOnly);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                return callPayload;
            }

            return new ApiConnectionAction<BookingListTeamProfilesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CashDrawerListShiftsResponse> CashDrawerListShifts([WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null, [WorkflowExpression] Func<string> beginTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(locationId, nameof(locationId), required: false);
            SourceExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            SourceExpression.Validate(beginTime, nameof(beginTime), required: false);
            SourceExpression.Validate(endTime, nameof(endTime), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cash-drawers/shifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                if (beginTime != null)
                    callPayload.Queries["begin_time"] = SourceExpressionConverter.ConvertO(beginTime);
                if (endTime != null)
                    callPayload.Queries["end_time"] = SourceExpressionConverter.ConvertO(endTime);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<CashDrawerListShiftsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CashDrawerRetrieveShiftResponse> CashDrawerRetrieveShift([WorkflowExpression] Func<string> shiftId, [WorkflowExpression] Func<string> locationId)
        {
            SourceExpression.Validate(shiftId, nameof(shiftId), required: true);
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cash-drawers/shifts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(shiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                return callPayload;
            }

            return new ApiConnectionAction<CashDrawerRetrieveShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CashDrawerListEventsResponse> CashDrawerListEvents([WorkflowExpression] Func<string> shiftId, [WorkflowExpression] Func<string> locationId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(shiftId, nameof(shiftId), required: true);
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cash-drawers/shifts/{0}/events", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(shiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<CashDrawerListEventsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<CheckoutCreateResponse> CheckoutCreate([WorkflowExpression] Func<string> locationId, [WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyredirectUrl = null, [WorkflowExpression] Func<string> bodyorderidempotencyKey = null, [WorkflowExpression] Func<string> bodyorderorderlocationId = null, [WorkflowExpression] Func<string> bodyorderordercustomerId = null, [WorkflowExpression] Func<string> bodyorderorderreferenceId = null, [WorkflowExpression] Func<bodyorderorderlineItemsInputItem[]> bodyorderorderlineItems = null, [WorkflowExpression] Func<bodyorderordertaxesInputItem[]> bodyorderordertaxes = null, [WorkflowExpression] Func<bodyorderorderdiscountsInputItem[]> bodyorderorderdiscounts = null, [WorkflowExpression] Func<bodyadditionalRecipientsInputItem[]> bodyadditionalRecipients = null, [WorkflowExpression] Func<bool> bodyaskForShippingAddress = null, [WorkflowExpression] Func<string> bodymerchantSupportEmail = null, [WorkflowExpression] Func<string> bodyprePopulateBuyerEmail = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddressaddressLine1 = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddressaddressLine2 = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddresslocality = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddressadministrativeDistrictLevel1 = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddresspostalCode = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddresscountry = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddressfirstName = null, [WorkflowExpression] Func<string> bodyprePopulateShippingAddresslastName = null)
        {
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodyredirectUrl, nameof(bodyredirectUrl), required: false);
            SourceExpression.Validate(bodyorderidempotencyKey, nameof(bodyorderidempotencyKey), required: false);
            SourceExpression.Validate(bodyorderorderlocationId, nameof(bodyorderorderlocationId), required: false);
            SourceExpression.Validate(bodyorderordercustomerId, nameof(bodyorderordercustomerId), required: false);
            SourceExpression.Validate(bodyorderorderreferenceId, nameof(bodyorderorderreferenceId), required: false);
            SourceExpression.Validate(bodyorderorderlineItems, nameof(bodyorderorderlineItems), required: false);
            SourceExpression.Validate(bodyorderordertaxes, nameof(bodyorderordertaxes), required: false);
            SourceExpression.Validate(bodyorderorderdiscounts, nameof(bodyorderorderdiscounts), required: false);
            SourceExpression.Validate(bodyadditionalRecipients, nameof(bodyadditionalRecipients), required: false);
            SourceExpression.Validate(bodyaskForShippingAddress, nameof(bodyaskForShippingAddress), required: false);
            SourceExpression.Validate(bodymerchantSupportEmail, nameof(bodymerchantSupportEmail), required: false);
            SourceExpression.Validate(bodyprePopulateBuyerEmail, nameof(bodyprePopulateBuyerEmail), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddressaddressLine1, nameof(bodyprePopulateShippingAddressaddressLine1), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddressaddressLine2, nameof(bodyprePopulateShippingAddressaddressLine2), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddresslocality, nameof(bodyprePopulateShippingAddresslocality), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddressadministrativeDistrictLevel1, nameof(bodyprePopulateShippingAddressadministrativeDistrictLevel1), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddresspostalCode, nameof(bodyprePopulateShippingAddresspostalCode), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddresscountry, nameof(bodyprePopulateShippingAddresscountry), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddressfirstName, nameof(bodyprePopulateShippingAddressfirstName), required: false);
            SourceExpression.Validate(bodyprePopulateShippingAddresslastName, nameof(bodyprePopulateShippingAddresslastName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}/checkouts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodyredirectUrl != null)
                {
                    body["redirect_url"] = SourceExpressionConverter.ConvertToken(bodyredirectUrl);
                    bodypropCount++;
                }

                var orderObject = new JObject();
                var orderObjectpropCount = 0;
                if (bodyorderidempotencyKey != null)
                {
                    orderObject["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyorderidempotencyKey);
                    orderObjectpropCount++;
                }

                var orderObject2 = new JObject();
                var orderObject2propCount = 0;
                if (bodyorderorderlocationId != null)
                {
                    orderObject2["location_id"] = SourceExpressionConverter.ConvertToken(bodyorderorderlocationId);
                    orderObject2propCount++;
                }

                if (bodyorderordercustomerId != null)
                {
                    orderObject2["customer_id"] = SourceExpressionConverter.ConvertToken(bodyorderordercustomerId);
                    orderObject2propCount++;
                }

                if (bodyorderorderreferenceId != null)
                {
                    orderObject2["reference_id"] = SourceExpressionConverter.ConvertToken(bodyorderorderreferenceId);
                    orderObject2propCount++;
                }

                if (bodyorderorderlineItems != null)
                {
                    orderObject2["line_items"] = SourceExpressionConverter.ConvertToken(bodyorderorderlineItems);
                    orderObject2propCount++;
                }

                if (bodyorderordertaxes != null)
                {
                    orderObject2["taxes"] = SourceExpressionConverter.ConvertToken(bodyorderordertaxes);
                    orderObject2propCount++;
                }

                if (bodyorderorderdiscounts != null)
                {
                    orderObject2["discounts"] = SourceExpressionConverter.ConvertToken(bodyorderorderdiscounts);
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

                if (bodyadditionalRecipients != null)
                {
                    body["additional_recipients"] = SourceExpressionConverter.ConvertToken(bodyadditionalRecipients);
                    bodypropCount++;
                }

                if (bodyaskForShippingAddress != null)
                {
                    body["ask_for_shipping_address"] = SourceExpressionConverter.ConvertToken(bodyaskForShippingAddress);
                    bodypropCount++;
                }

                if (bodymerchantSupportEmail != null)
                {
                    body["merchant_support_email"] = SourceExpressionConverter.ConvertToken(bodymerchantSupportEmail);
                    bodypropCount++;
                }

                if (bodyprePopulateBuyerEmail != null)
                {
                    body["pre_populate_buyer_email"] = SourceExpressionConverter.ConvertToken(bodyprePopulateBuyerEmail);
                    bodypropCount++;
                }

                var prePopulateShippingAddressObject = new JObject();
                var prePopulateShippingAddressObjectpropCount = 0;
                if (bodyprePopulateShippingAddressaddressLine1 != null)
                {
                    prePopulateShippingAddressObject["address_line_1"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddressaddressLine1);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddressaddressLine2 != null)
                {
                    prePopulateShippingAddressObject["address_line_2"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddressaddressLine2);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddresslocality != null)
                {
                    prePopulateShippingAddressObject["locality"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddresslocality);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddressadministrativeDistrictLevel1 != null)
                {
                    prePopulateShippingAddressObject["administrative_district_level_1"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddressadministrativeDistrictLevel1);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddresspostalCode != null)
                {
                    prePopulateShippingAddressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddresspostalCode);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddresscountry != null)
                {
                    prePopulateShippingAddressObject["country"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddresscountry);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddressfirstName != null)
                {
                    prePopulateShippingAddressObject["first_name"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddressfirstName);
                    prePopulateShippingAddressObjectpropCount++;
                }

                if (bodyprePopulateShippingAddresslastName != null)
                {
                    prePopulateShippingAddressObject["last_name"] = SourceExpressionConverter.ConvertToken(bodyprePopulateShippingAddresslastName);
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
                return callPayload;
            }

            return new ApiConnectionAction<CheckoutCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceListResponse> DeviceList([WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<string> productType = null, [WorkflowExpression] Func<statusInput> status = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(locationId, nameof(locationId), required: false);
            SourceExpression.Validate(productType, nameof(productType), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/devices/codes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (productType != null)
                    callPayload.Queries["product_type"] = SourceExpressionConverter.ConvertO(productType);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                return callPayload;
            }

            return new ApiConnectionAction<DeviceListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceCreateResponse> DeviceCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodydeviceCodename = null, [WorkflowExpression] Func<string> bodydeviceCodelocationId = null, [WorkflowExpression] Func<string> bodydeviceCodeproductType = null)
        {
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodydeviceCodename, nameof(bodydeviceCodename), required: false);
            SourceExpression.Validate(bodydeviceCodelocationId, nameof(bodydeviceCodelocationId), required: false);
            SourceExpression.Validate(bodydeviceCodeproductType, nameof(bodydeviceCodeproductType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/devices/codes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var deviceCodeObject = new JObject();
                var deviceCodeObjectpropCount = 0;
                if (bodydeviceCodename != null)
                {
                    deviceCodeObject["name"] = SourceExpressionConverter.ConvertToken(bodydeviceCodename);
                    deviceCodeObjectpropCount++;
                }

                if (bodydeviceCodelocationId != null)
                {
                    deviceCodeObject["location_id"] = SourceExpressionConverter.ConvertToken(bodydeviceCodelocationId);
                    deviceCodeObjectpropCount++;
                }

                if (bodydeviceCodeproductType != null)
                {
                    deviceCodeObject["product_type"] = SourceExpressionConverter.ConvertToken(bodydeviceCodeproductType);
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
                return callPayload;
            }

            return new ApiConnectionAction<DeviceCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceGetResponse> DeviceGet([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/devices/codes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeviceGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardListResponse> GiftCardList([WorkflowExpression] Func<string> giftCardId = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<string> beginTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<sortOrderInput> sortOrder = null)
        {
            SourceExpression.Validate(giftCardId, nameof(giftCardId), required: false);
            SourceExpression.Validate(type, nameof(type), required: false);
            SourceExpression.Validate(locationId, nameof(locationId), required: false);
            SourceExpression.Validate(beginTime, nameof(beginTime), required: false);
            SourceExpression.Validate(endTime, nameof(endTime), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(sortOrder, nameof(sortOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-cards/activities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (giftCardId != null)
                    callPayload.Queries["gift_card_id"] = SourceExpressionConverter.ConvertO(giftCardId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (beginTime != null)
                    callPayload.Queries["begin_time"] = SourceExpressionConverter.ConvertO(beginTime);
                if (endTime != null)
                    callPayload.Queries["end_time"] = SourceExpressionConverter.ConvertO(endTime);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                callPayload.Queries["sort_order"] = Convert.ToString("ASC");
                if (sortOrder != null)
                    callPayload.Queries["sort_order"] = SourceExpressionConverter.Convert(sortOrder);
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardCreateResponse> GiftCardCreate([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodygiftCardActivitygiftCardId = null, [WorkflowExpression] Func<bodygiftCardActivitytypeInput> bodygiftCardActivitytype = null, [WorkflowExpression] Func<string> bodygiftCardActivitylocationId = null, [WorkflowExpression] Func<string> bodygiftCardActivityactivateActivityDetailsorderId = null, [WorkflowExpression] Func<string> bodygiftCardActivityactivateActivityDetailslineItemUid = null)
        {
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodygiftCardActivitygiftCardId, nameof(bodygiftCardActivitygiftCardId), required: false);
            SourceExpression.Validate(bodygiftCardActivitytype, nameof(bodygiftCardActivitytype), required: false);
            SourceExpression.Validate(bodygiftCardActivitylocationId, nameof(bodygiftCardActivitylocationId), required: false);
            SourceExpression.Validate(bodygiftCardActivityactivateActivityDetailsorderId, nameof(bodygiftCardActivityactivateActivityDetailsorderId), required: false);
            SourceExpression.Validate(bodygiftCardActivityactivateActivityDetailslineItemUid, nameof(bodygiftCardActivityactivateActivityDetailslineItemUid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-cards/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var giftCardActivityObject = new JObject();
                var giftCardActivityObjectpropCount = 0;
                if (bodygiftCardActivitygiftCardId != null)
                {
                    giftCardActivityObject["gift_card_id"] = SourceExpressionConverter.ConvertToken(bodygiftCardActivitygiftCardId);
                    giftCardActivityObjectpropCount++;
                }

                if (bodygiftCardActivitytype != null)
                {
                    giftCardActivityObject["type"] = SourceExpressionConverter.Convert(bodygiftCardActivitytype);
                    giftCardActivityObjectpropCount++;
                }

                if (bodygiftCardActivitylocationId != null)
                {
                    giftCardActivityObject["location_id"] = SourceExpressionConverter.ConvertToken(bodygiftCardActivitylocationId);
                    giftCardActivityObjectpropCount++;
                }

                var activateActivityDetailsObject = new JObject();
                var activateActivityDetailsObjectpropCount = 0;
                if (bodygiftCardActivityactivateActivityDetailsorderId != null)
                {
                    activateActivityDetailsObject["order_id"] = SourceExpressionConverter.ConvertToken(bodygiftCardActivityactivateActivityDetailsorderId);
                    activateActivityDetailsObjectpropCount++;
                }

                if (bodygiftCardActivityactivateActivityDetailslineItemUid != null)
                {
                    activateActivityDetailsObject["line_item_uid"] = SourceExpressionConverter.ConvertToken(bodygiftCardActivityactivateActivityDetailslineItemUid);
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
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveGANResponse> GiftCardRetrieveGAN([WorkflowExpression] Func<string> bodygan = null)
        {
            SourceExpression.Validate(bodygan, nameof(bodygan), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-cards/from-gan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygan != null)
                {
                    body["gan"] = SourceExpressionConverter.ConvertToken(bodygan);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardRetrieveGANResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveNonceResponse> GiftCardRetrieveNonce([WorkflowExpression] Func<string> bodynonce = null)
        {
            SourceExpression.Validate(bodynonce, nameof(bodynonce), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-cards/from-nonce";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynonce != null)
                {
                    body["nonce"] = SourceExpressionConverter.ConvertToken(bodynonce);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardRetrieveNonceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardLinkResponse> GiftCardLink([WorkflowExpression] Func<string> giftCardId, [WorkflowExpression] Func<string> bodycustomerId = null)
        {
            SourceExpression.Validate(giftCardId, nameof(giftCardId), required: true);
            SourceExpression.Validate(bodycustomerId, nameof(bodycustomerId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift-cards/{0}/link-customer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftCardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomerId != null)
                {
                    body["customer_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardUnlinkResponse> GiftCardUnlink([WorkflowExpression] Func<string> giftCardId, [WorkflowExpression] Func<string> bodycustomerId = null)
        {
            SourceExpression.Validate(giftCardId, nameof(giftCardId), required: true);
            SourceExpression.Validate(bodycustomerId, nameof(bodycustomerId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift-cards/{0}/unlink-customer", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftCardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomerId != null)
                {
                    body["customer_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardUnlinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveResponse> GiftCardRetrieve([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift-cards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftCardRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborListBreakResponse> LaborListBreak([WorkflowExpression] Func<string> locationId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(locationId, nameof(locationId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/labor/break-types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (locationId != null)
                    callPayload.Queries["location_id"] = SourceExpressionConverter.ConvertO(locationId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<LaborListBreakResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborCreateBreakResponse> LaborCreateBreak([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodybreakTypelocationId = null, [WorkflowExpression] Func<string> bodybreakTypebreakName = null, [WorkflowExpression] Func<string> bodybreakTypeexpectedDuration = null, [WorkflowExpression] Func<bool> bodybreakTypeisPaid = null)
        {
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodybreakTypelocationId, nameof(bodybreakTypelocationId), required: false);
            SourceExpression.Validate(bodybreakTypebreakName, nameof(bodybreakTypebreakName), required: false);
            SourceExpression.Validate(bodybreakTypeexpectedDuration, nameof(bodybreakTypeexpectedDuration), required: false);
            SourceExpression.Validate(bodybreakTypeisPaid, nameof(bodybreakTypeisPaid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/labor/break-types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var breakTypeObject = new JObject();
                var breakTypeObjectpropCount = 0;
                if (bodybreakTypelocationId != null)
                {
                    breakTypeObject["location_id"] = SourceExpressionConverter.ConvertToken(bodybreakTypelocationId);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypebreakName != null)
                {
                    breakTypeObject["break_name"] = SourceExpressionConverter.ConvertToken(bodybreakTypebreakName);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypeexpectedDuration != null)
                {
                    breakTypeObject["expected_duration"] = SourceExpressionConverter.ConvertToken(bodybreakTypeexpectedDuration);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypeisPaid != null)
                {
                    breakTypeObject["is_paid"] = SourceExpressionConverter.ConvertToken(bodybreakTypeisPaid);
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
                return callPayload;
            }

            return new ApiConnectionAction<LaborCreateBreakResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborGetBreakResponse> LaborGetBreak([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/break-types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaborGetBreakResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken> LaborDeleteBreak([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/break-types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborUpdateBreakResponse> LaborUpdateBreak([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodybreakTypelocationId = null, [WorkflowExpression] Func<string> bodybreakTypebreakName = null, [WorkflowExpression] Func<string> bodybreakTypeexpectedDuration = null, [WorkflowExpression] Func<bool> bodybreakTypeisPaid = null, [WorkflowExpression] Func<int> bodybreakTypeversion = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodybreakTypelocationId, nameof(bodybreakTypelocationId), required: false);
            SourceExpression.Validate(bodybreakTypebreakName, nameof(bodybreakTypebreakName), required: false);
            SourceExpression.Validate(bodybreakTypeexpectedDuration, nameof(bodybreakTypeexpectedDuration), required: false);
            SourceExpression.Validate(bodybreakTypeisPaid, nameof(bodybreakTypeisPaid), required: false);
            SourceExpression.Validate(bodybreakTypeversion, nameof(bodybreakTypeversion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/break-types/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var breakTypeObject = new JObject();
                var breakTypeObjectpropCount = 0;
                if (bodybreakTypelocationId != null)
                {
                    breakTypeObject["location_id"] = SourceExpressionConverter.ConvertToken(bodybreakTypelocationId);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypebreakName != null)
                {
                    breakTypeObject["break_name"] = SourceExpressionConverter.ConvertToken(bodybreakTypebreakName);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypeexpectedDuration != null)
                {
                    breakTypeObject["expected_duration"] = SourceExpressionConverter.ConvertToken(bodybreakTypeexpectedDuration);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypeisPaid != null)
                {
                    breakTypeObject["is_paid"] = SourceExpressionConverter.ConvertToken(bodybreakTypeisPaid);
                    breakTypeObjectpropCount++;
                }

                if (bodybreakTypeversion != null)
                {
                    breakTypeObject["version"] = SourceExpressionConverter.ConvertToken(bodybreakTypeversion);
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
                return callPayload;
            }

            return new ApiConnectionAction<LaborUpdateBreakResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborCreateShiftResponse> LaborCreateShift([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyshiftteamMemberId = null, [WorkflowExpression] Func<string> bodyshiftlocationId = null, [WorkflowExpression] Func<string> bodyshiftstartAt = null, [WorkflowExpression] Func<string> bodyshiftendAt = null, [WorkflowExpression] Func<string> bodyshiftwagetitle = null, [WorkflowExpression] Func<int> bodyshiftwagehourlyRateamount = null, [WorkflowExpression] Func<string> bodyshiftwagehourlyRatecurrency = null, [WorkflowExpression] Func<bodyshiftbreaksInputItem[]> bodyshiftbreaks = null)
        {
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodyshiftteamMemberId, nameof(bodyshiftteamMemberId), required: false);
            SourceExpression.Validate(bodyshiftlocationId, nameof(bodyshiftlocationId), required: false);
            SourceExpression.Validate(bodyshiftstartAt, nameof(bodyshiftstartAt), required: false);
            SourceExpression.Validate(bodyshiftendAt, nameof(bodyshiftendAt), required: false);
            SourceExpression.Validate(bodyshiftwagetitle, nameof(bodyshiftwagetitle), required: false);
            SourceExpression.Validate(bodyshiftwagehourlyRateamount, nameof(bodyshiftwagehourlyRateamount), required: false);
            SourceExpression.Validate(bodyshiftwagehourlyRatecurrency, nameof(bodyshiftwagehourlyRatecurrency), required: false);
            SourceExpression.Validate(bodyshiftbreaks, nameof(bodyshiftbreaks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/labor/shifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var shiftObject = new JObject();
                var shiftObjectpropCount = 0;
                if (bodyshiftteamMemberId != null)
                {
                    shiftObject["team_member_id"] = SourceExpressionConverter.ConvertToken(bodyshiftteamMemberId);
                    shiftObjectpropCount++;
                }

                if (bodyshiftlocationId != null)
                {
                    shiftObject["location_id"] = SourceExpressionConverter.ConvertToken(bodyshiftlocationId);
                    shiftObjectpropCount++;
                }

                if (bodyshiftstartAt != null)
                {
                    shiftObject["start_at"] = SourceExpressionConverter.ConvertToken(bodyshiftstartAt);
                    shiftObjectpropCount++;
                }

                if (bodyshiftendAt != null)
                {
                    shiftObject["end_at"] = SourceExpressionConverter.ConvertToken(bodyshiftendAt);
                    shiftObjectpropCount++;
                }

                var wageObject = new JObject();
                var wageObjectpropCount = 0;
                if (bodyshiftwagetitle != null)
                {
                    wageObject["title"] = SourceExpressionConverter.ConvertToken(bodyshiftwagetitle);
                    wageObjectpropCount++;
                }

                var hourlyRateObject = new JObject();
                var hourlyRateObjectpropCount = 0;
                if (bodyshiftwagehourlyRateamount != null)
                {
                    hourlyRateObject["amount"] = SourceExpressionConverter.ConvertToken(bodyshiftwagehourlyRateamount);
                    hourlyRateObjectpropCount++;
                }

                if (bodyshiftwagehourlyRatecurrency != null)
                {
                    hourlyRateObject["currency"] = SourceExpressionConverter.ConvertToken(bodyshiftwagehourlyRatecurrency);
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

                if (bodyshiftbreaks != null)
                {
                    shiftObject["breaks"] = SourceExpressionConverter.ConvertToken(bodyshiftbreaks);
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
                return callPayload;
            }

            return new ApiConnectionAction<LaborCreateShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborSearchShiftsResponse> LaborSearchShifts([WorkflowExpression] Func<string> bodyqueryfilterworkdaydateRangestartDate = null, [WorkflowExpression] Func<string> bodyqueryfilterworkdaydateRangeendDate = null, [WorkflowExpression] Func<string> bodyqueryfilterworkdaymatchShiftsBy = null, [WorkflowExpression] Func<string> bodyqueryfilterworkdaydefaultTimezone = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(bodyqueryfilterworkdaydateRangestartDate, nameof(bodyqueryfilterworkdaydateRangestartDate), required: false);
            SourceExpression.Validate(bodyqueryfilterworkdaydateRangeendDate, nameof(bodyqueryfilterworkdaydateRangeendDate), required: false);
            SourceExpression.Validate(bodyqueryfilterworkdaymatchShiftsBy, nameof(bodyqueryfilterworkdaymatchShiftsBy), required: false);
            SourceExpression.Validate(bodyqueryfilterworkdaydefaultTimezone, nameof(bodyqueryfilterworkdaydefaultTimezone), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyqueryfilterworkdaydateRangestartDate != null)
                {
                    dateRangeObject["start_date"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterworkdaydateRangestartDate);
                    dateRangeObjectpropCount++;
                }

                if (bodyqueryfilterworkdaydateRangeendDate != null)
                {
                    dateRangeObject["end_date"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterworkdaydateRangeendDate);
                    dateRangeObjectpropCount++;
                }

                if (dateRangeObjectpropCount > 0)
                {
                    workdayObject["date_range"] = dateRangeObject;
                    workdayObjectpropCount++;
                }

                if (bodyqueryfilterworkdaymatchShiftsBy != null)
                {
                    workdayObject["match_shifts_by"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterworkdaymatchShiftsBy);
                    workdayObjectpropCount++;
                }

                if (bodyqueryfilterworkdaydefaultTimezone != null)
                {
                    workdayObject["default_timezone"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterworkdaydefaultTimezone);
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

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LaborSearchShiftsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborGetShiftResponse> LaborGetShift([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/shifts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaborGetShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken> LaborDeleteShift([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/shifts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborUpdateShiftResponse> LaborUpdateShift([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyshiftteamMemberId = null, [WorkflowExpression] Func<string> bodyshiftlocationId = null, [WorkflowExpression] Func<string> bodyshiftstartAt = null, [WorkflowExpression] Func<string> bodyshiftendAt = null, [WorkflowExpression] Func<string> bodyshiftwagetitle = null, [WorkflowExpression] Func<int> bodyshiftwagehourlyRateamount = null, [WorkflowExpression] Func<string> bodyshiftwagehourlyRatecurrency = null, [WorkflowExpression] Func<bodyshiftbreaksInputItem2[]> bodyshiftbreaks = null, [WorkflowExpression] Func<int> bodyshiftversion = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyshiftteamMemberId, nameof(bodyshiftteamMemberId), required: false);
            SourceExpression.Validate(bodyshiftlocationId, nameof(bodyshiftlocationId), required: false);
            SourceExpression.Validate(bodyshiftstartAt, nameof(bodyshiftstartAt), required: false);
            SourceExpression.Validate(bodyshiftendAt, nameof(bodyshiftendAt), required: false);
            SourceExpression.Validate(bodyshiftwagetitle, nameof(bodyshiftwagetitle), required: false);
            SourceExpression.Validate(bodyshiftwagehourlyRateamount, nameof(bodyshiftwagehourlyRateamount), required: false);
            SourceExpression.Validate(bodyshiftwagehourlyRatecurrency, nameof(bodyshiftwagehourlyRatecurrency), required: false);
            SourceExpression.Validate(bodyshiftbreaks, nameof(bodyshiftbreaks), required: false);
            SourceExpression.Validate(bodyshiftversion, nameof(bodyshiftversion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/shifts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var shiftObject = new JObject();
                var shiftObjectpropCount = 0;
                if (bodyshiftteamMemberId != null)
                {
                    shiftObject["team_member_id"] = SourceExpressionConverter.ConvertToken(bodyshiftteamMemberId);
                    shiftObjectpropCount++;
                }

                if (bodyshiftlocationId != null)
                {
                    shiftObject["location_id"] = SourceExpressionConverter.ConvertToken(bodyshiftlocationId);
                    shiftObjectpropCount++;
                }

                if (bodyshiftstartAt != null)
                {
                    shiftObject["start_at"] = SourceExpressionConverter.ConvertToken(bodyshiftstartAt);
                    shiftObjectpropCount++;
                }

                if (bodyshiftendAt != null)
                {
                    shiftObject["end_at"] = SourceExpressionConverter.ConvertToken(bodyshiftendAt);
                    shiftObjectpropCount++;
                }

                var wageObject = new JObject();
                var wageObjectpropCount = 0;
                if (bodyshiftwagetitle != null)
                {
                    wageObject["title"] = SourceExpressionConverter.ConvertToken(bodyshiftwagetitle);
                    wageObjectpropCount++;
                }

                var hourlyRateObject = new JObject();
                var hourlyRateObjectpropCount = 0;
                if (bodyshiftwagehourlyRateamount != null)
                {
                    hourlyRateObject["amount"] = SourceExpressionConverter.ConvertToken(bodyshiftwagehourlyRateamount);
                    hourlyRateObjectpropCount++;
                }

                if (bodyshiftwagehourlyRatecurrency != null)
                {
                    hourlyRateObject["currency"] = SourceExpressionConverter.ConvertToken(bodyshiftwagehourlyRatecurrency);
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

                if (bodyshiftbreaks != null)
                {
                    shiftObject["breaks"] = SourceExpressionConverter.ConvertToken(bodyshiftbreaks);
                    shiftObjectpropCount++;
                }

                if (bodyshiftversion != null)
                {
                    shiftObject["version"] = SourceExpressionConverter.ConvertToken(bodyshiftversion);
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
                return callPayload;
            }

            return new ApiConnectionAction<LaborUpdateShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborListWagesResponse> LaborListWages([WorkflowExpression] Func<string> teamMemberId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(teamMemberId, nameof(teamMemberId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/labor/team-member-wages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (teamMemberId != null)
                    callPayload.Queries["team_member_id"] = SourceExpressionConverter.ConvertO(teamMemberId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<LaborListWagesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborGetWageResponse> LaborGetWage([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/team-member-wages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LaborGetWageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborListConfigsResponse> LaborListConfigs([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/labor/workweek-configs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<LaborListConfigsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborUpdateConfigResponse> LaborUpdateConfig([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyworkweekConfigstartOfWeek = null, [WorkflowExpression] Func<string> bodyworkweekConfigstartOfDayLocalTime = null, [WorkflowExpression] Func<int> bodyworkweekConfigversion = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyworkweekConfigstartOfWeek, nameof(bodyworkweekConfigstartOfWeek), required: false);
            SourceExpression.Validate(bodyworkweekConfigstartOfDayLocalTime, nameof(bodyworkweekConfigstartOfDayLocalTime), required: false);
            SourceExpression.Validate(bodyworkweekConfigversion, nameof(bodyworkweekConfigversion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/labor/workweek-configs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var workweekConfigObject = new JObject();
                var workweekConfigObjectpropCount = 0;
                if (bodyworkweekConfigstartOfWeek != null)
                {
                    workweekConfigObject["start_of_week"] = SourceExpressionConverter.ConvertToken(bodyworkweekConfigstartOfWeek);
                    workweekConfigObjectpropCount++;
                }

                if (bodyworkweekConfigstartOfDayLocalTime != null)
                {
                    workweekConfigObject["start_of_day_local_time"] = SourceExpressionConverter.ConvertToken(bodyworkweekConfigstartOfDayLocalTime);
                    workweekConfigObjectpropCount++;
                }

                if (bodyworkweekConfigversion != null)
                {
                    workweekConfigObject["version"] = SourceExpressionConverter.ConvertToken(bodyworkweekConfigversion);
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
                return callPayload;
            }

            return new ApiConnectionAction<LaborUpdateConfigResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationListResponse> LocationList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LocationListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationCreateResponse> LocationCreate([WorkflowExpression] Func<string> bodylocationname = null, [WorkflowExpression] Func<string> bodylocationdescription = null, [WorkflowExpression] Func<string> bodylocationfacebookUrl = null, [WorkflowExpression] Func<string> bodylocationaddressaddressLine1 = null, [WorkflowExpression] Func<string> bodylocationaddressadministrativeDistrictLevel1 = null, [WorkflowExpression] Func<string> bodylocationaddresslocality = null, [WorkflowExpression] Func<string> bodylocationaddresspostalCode = null)
        {
            SourceExpression.Validate(bodylocationname, nameof(bodylocationname), required: false);
            SourceExpression.Validate(bodylocationdescription, nameof(bodylocationdescription), required: false);
            SourceExpression.Validate(bodylocationfacebookUrl, nameof(bodylocationfacebookUrl), required: false);
            SourceExpression.Validate(bodylocationaddressaddressLine1, nameof(bodylocationaddressaddressLine1), required: false);
            SourceExpression.Validate(bodylocationaddressadministrativeDistrictLevel1, nameof(bodylocationaddressadministrativeDistrictLevel1), required: false);
            SourceExpression.Validate(bodylocationaddresslocality, nameof(bodylocationaddresslocality), required: false);
            SourceExpression.Validate(bodylocationaddresspostalCode, nameof(bodylocationaddresspostalCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationname != null)
                {
                    locationObject["name"] = SourceExpressionConverter.ConvertToken(bodylocationname);
                    locationObjectpropCount++;
                }

                if (bodylocationdescription != null)
                {
                    locationObject["description"] = SourceExpressionConverter.ConvertToken(bodylocationdescription);
                    locationObjectpropCount++;
                }

                if (bodylocationfacebookUrl != null)
                {
                    locationObject["facebook_url"] = SourceExpressionConverter.ConvertToken(bodylocationfacebookUrl);
                    locationObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodylocationaddressaddressLine1 != null)
                {
                    addressObject["address_line_1"] = SourceExpressionConverter.ConvertToken(bodylocationaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (bodylocationaddressadministrativeDistrictLevel1 != null)
                {
                    addressObject["administrative_district_level_1"] = SourceExpressionConverter.ConvertToken(bodylocationaddressadministrativeDistrictLevel1);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresslocality != null)
                {
                    addressObject["locality"] = SourceExpressionConverter.ConvertToken(bodylocationaddresslocality);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodylocationaddresspostalCode);
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
                return callPayload;
            }

            return new ApiConnectionAction<LocationCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationRetrieveResponse> LocationRetrieve([WorkflowExpression] Func<string> locationId)
        {
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LocationRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LocationUpdateResponse> LocationUpdate([WorkflowExpression] Func<string> locationId, [WorkflowExpression] Func<string> bodylocationname = null, [WorkflowExpression] Func<string> bodylocationdescription = null, [WorkflowExpression] Func<string> bodylocationfacebookUrl = null, [WorkflowExpression] Func<string> bodylocationtwitterUsername = null, [WorkflowExpression] Func<string> bodylocationinstagramUsername = null, [WorkflowExpression] Func<string> bodylocationaddressaddressLine1 = null, [WorkflowExpression] Func<string> bodylocationaddressadministrativeDistrictLevel1 = null, [WorkflowExpression] Func<string> bodylocationaddresslocality = null, [WorkflowExpression] Func<string> bodylocationaddresspostalCode = null, [WorkflowExpression] Func<bodylocationbusinessHoursperiodsInputItem[]> bodylocationbusinessHoursperiods = null)
        {
            SourceExpression.Validate(locationId, nameof(locationId), required: true);
            SourceExpression.Validate(bodylocationname, nameof(bodylocationname), required: false);
            SourceExpression.Validate(bodylocationdescription, nameof(bodylocationdescription), required: false);
            SourceExpression.Validate(bodylocationfacebookUrl, nameof(bodylocationfacebookUrl), required: false);
            SourceExpression.Validate(bodylocationtwitterUsername, nameof(bodylocationtwitterUsername), required: false);
            SourceExpression.Validate(bodylocationinstagramUsername, nameof(bodylocationinstagramUsername), required: false);
            SourceExpression.Validate(bodylocationaddressaddressLine1, nameof(bodylocationaddressaddressLine1), required: false);
            SourceExpression.Validate(bodylocationaddressadministrativeDistrictLevel1, nameof(bodylocationaddressadministrativeDistrictLevel1), required: false);
            SourceExpression.Validate(bodylocationaddresslocality, nameof(bodylocationaddresslocality), required: false);
            SourceExpression.Validate(bodylocationaddresspostalCode, nameof(bodylocationaddresspostalCode), required: false);
            SourceExpression.Validate(bodylocationbusinessHoursperiods, nameof(bodylocationbusinessHoursperiods), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(locationId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationname != null)
                {
                    locationObject["name"] = SourceExpressionConverter.ConvertToken(bodylocationname);
                    locationObjectpropCount++;
                }

                if (bodylocationdescription != null)
                {
                    locationObject["description"] = SourceExpressionConverter.ConvertToken(bodylocationdescription);
                    locationObjectpropCount++;
                }

                if (bodylocationfacebookUrl != null)
                {
                    locationObject["facebook_url"] = SourceExpressionConverter.ConvertToken(bodylocationfacebookUrl);
                    locationObjectpropCount++;
                }

                if (bodylocationtwitterUsername != null)
                {
                    locationObject["twitter_username"] = SourceExpressionConverter.ConvertToken(bodylocationtwitterUsername);
                    locationObjectpropCount++;
                }

                if (bodylocationinstagramUsername != null)
                {
                    locationObject["instagram_username"] = SourceExpressionConverter.ConvertToken(bodylocationinstagramUsername);
                    locationObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodylocationaddressaddressLine1 != null)
                {
                    addressObject["address_line_1"] = SourceExpressionConverter.ConvertToken(bodylocationaddressaddressLine1);
                    addressObjectpropCount++;
                }

                if (bodylocationaddressadministrativeDistrictLevel1 != null)
                {
                    addressObject["administrative_district_level_1"] = SourceExpressionConverter.ConvertToken(bodylocationaddressadministrativeDistrictLevel1);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresslocality != null)
                {
                    addressObject["locality"] = SourceExpressionConverter.ConvertToken(bodylocationaddresslocality);
                    addressObjectpropCount++;
                }

                if (bodylocationaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodylocationaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    locationObject["address"] = addressObject;
                    locationObjectpropCount++;
                }

                var businessHoursObject = new JObject();
                var businessHoursObjectpropCount = 0;
                if (bodylocationbusinessHoursperiods != null)
                {
                    businessHoursObject["periods"] = SourceExpressionConverter.ConvertToken(bodylocationbusinessHoursperiods);
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
                return callPayload;
            }

            return new ApiConnectionAction<LocationUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCreateAccountResponse> LoyaltyCreateAccount([WorkflowExpression] Func<string> bodyloyaltyAccountmappingphoneNumber = null, [WorkflowExpression] Func<string> bodyloyaltyAccountprogramId = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            SourceExpression.Validate(bodyloyaltyAccountmappingphoneNumber, nameof(bodyloyaltyAccountmappingphoneNumber), required: false);
            SourceExpression.Validate(bodyloyaltyAccountprogramId, nameof(bodyloyaltyAccountprogramId), required: false);
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyloyaltyAccountmappingphoneNumber != null)
                {
                    mappingObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodyloyaltyAccountmappingphoneNumber);
                    mappingObjectpropCount++;
                }

                if (mappingObjectpropCount > 0)
                {
                    loyaltyAccountObject["mapping"] = mappingObject;
                    loyaltyAccountObjectpropCount++;
                }

                if (bodyloyaltyAccountprogramId != null)
                {
                    loyaltyAccountObject["program_id"] = SourceExpressionConverter.ConvertToken(bodyloyaltyAccountprogramId);
                    loyaltyAccountObjectpropCount++;
                }

                if (loyaltyAccountObjectpropCount > 0)
                {
                    body["loyalty_account"] = loyaltyAccountObject;
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyCreateAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchAccountsResponse> LoyaltySearchAccounts([WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltySearchAccountsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRetrieveAccountResponse> LoyaltyRetrieveAccount([WorkflowExpression] Func<string> accountId)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/accounts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyRetrieveAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyAccumulatePointsResponse> LoyaltyAccumulatePoints([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> bodyaccumulatePointsorderId = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodyaccumulatePointsorderId, nameof(bodyaccumulatePointsorderId), required: false);
            SourceExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/accounts/{0}/accumulate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var accumulatePointsObject = new JObject();
                var accumulatePointsObjectpropCount = 0;
                if (bodyaccumulatePointsorderId != null)
                {
                    accumulatePointsObject["order_id"] = SourceExpressionConverter.ConvertToken(bodyaccumulatePointsorderId);
                    accumulatePointsObjectpropCount++;
                }

                if (accumulatePointsObjectpropCount > 0)
                {
                    body["accumulate_points"] = accumulatePointsObject;
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyAccumulatePointsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyAdjustPointsResponse> LoyaltyAdjustPoints([WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<int> bodyadjustPointspoints = null, [WorkflowExpression] Func<string> bodyadjustPointsreason = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            SourceExpression.Validate(accountId, nameof(accountId), required: true);
            SourceExpression.Validate(bodyadjustPointspoints, nameof(bodyadjustPointspoints), required: false);
            SourceExpression.Validate(bodyadjustPointsreason, nameof(bodyadjustPointsreason), required: false);
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/accounts/{0}/adjust", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(accountId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var adjustPointsObject = new JObject();
                var adjustPointsObjectpropCount = 0;
                if (bodyadjustPointspoints != null)
                {
                    adjustPointsObject["points"] = SourceExpressionConverter.ConvertToken(bodyadjustPointspoints);
                    adjustPointsObjectpropCount++;
                }

                if (bodyadjustPointsreason != null)
                {
                    adjustPointsObject["reason"] = SourceExpressionConverter.ConvertToken(bodyadjustPointsreason);
                    adjustPointsObjectpropCount++;
                }

                if (adjustPointsObjectpropCount > 0)
                {
                    body["adjust_points"] = adjustPointsObject;
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyAdjustPointsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchEventsResponse> LoyaltySearchEvents([WorkflowExpression] Func<string> bodyqueryfilterorderFilterorderId = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(bodyqueryfilterorderFilterorderId, nameof(bodyqueryfilterorderFilterorderId), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyqueryfilterorderFilterorderId != null)
                {
                    orderFilterObject["order_id"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterorderFilterorderId);
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

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltySearchEventsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRetrieveProgramResponse> LoyaltyRetrieveProgram([WorkflowExpression] Func<string> programId)
        {
            SourceExpression.Validate(programId, nameof(programId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/programs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(programId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyRetrieveProgramResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCalculatePointsResponse> LoyaltyCalculatePoints([WorkflowExpression] Func<string> programId, [WorkflowExpression] Func<string> bodyorderId = null)
        {
            SourceExpression.Validate(programId, nameof(programId), required: true);
            SourceExpression.Validate(bodyorderId, nameof(bodyorderId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/programs/{0}/calculate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(programId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyorderId != null)
                {
                    body["order_id"] = SourceExpressionConverter.ConvertToken(bodyorderId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyCalculatePointsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCreateRewardResponse> LoyaltyCreateReward([WorkflowExpression] Func<string> bodyrewardloyaltyAccountId = null, [WorkflowExpression] Func<string> bodyrewardrewardTierId = null, [WorkflowExpression] Func<string> bodyrewardorderId = null, [WorkflowExpression] Func<string> bodyidempotencyKey = null)
        {
            SourceExpression.Validate(bodyrewardloyaltyAccountId, nameof(bodyrewardloyaltyAccountId), required: false);
            SourceExpression.Validate(bodyrewardrewardTierId, nameof(bodyrewardrewardTierId), required: false);
            SourceExpression.Validate(bodyrewardorderId, nameof(bodyrewardorderId), required: false);
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/loyalty/rewards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var rewardObject = new JObject();
                var rewardObjectpropCount = 0;
                if (bodyrewardloyaltyAccountId != null)
                {
                    rewardObject["loyalty_account_id"] = SourceExpressionConverter.ConvertToken(bodyrewardloyaltyAccountId);
                    rewardObjectpropCount++;
                }

                if (bodyrewardrewardTierId != null)
                {
                    rewardObject["reward_tier_id"] = SourceExpressionConverter.ConvertToken(bodyrewardrewardTierId);
                    rewardObjectpropCount++;
                }

                if (bodyrewardorderId != null)
                {
                    rewardObject["order_id"] = SourceExpressionConverter.ConvertToken(bodyrewardorderId);
                    rewardObjectpropCount++;
                }

                if (rewardObjectpropCount > 0)
                {
                    body["reward"] = rewardObject;
                    bodypropCount++;
                }

                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyCreateRewardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchRewardsResponse> LoyaltySearchRewards([WorkflowExpression] Func<string> bodyqueryloyaltyAccountId = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(bodyqueryloyaltyAccountId, nameof(bodyqueryloyaltyAccountId), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/loyalty/rewards/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var queryObject = new JObject();
                var queryObjectpropCount = 0;
                if (bodyqueryloyaltyAccountId != null)
                {
                    queryObject["loyalty_account_id"] = SourceExpressionConverter.ConvertToken(bodyqueryloyaltyAccountId);
                    queryObjectpropCount++;
                }

                if (queryObjectpropCount > 0)
                {
                    body["query"] = queryObject;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltySearchRewardsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRetrieveRewardResponse> LoyaltyRetrieveReward([WorkflowExpression] Func<string> rewardId)
        {
            SourceExpression.Validate(rewardId, nameof(rewardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/rewards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyRetrieveRewardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken> LoyaltyDeleteReward([WorkflowExpression] Func<string> rewardId)
        {
            SourceExpression.Validate(rewardId, nameof(rewardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/rewards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyRedeemRewardResponse> LoyaltyRedeemReward([WorkflowExpression] Func<string> rewardId, [WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodylocationId = null)
        {
            SourceExpression.Validate(rewardId, nameof(rewardId), required: true);
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/loyalty/rewards/{0}/redeem", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rewardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LoyaltyRedeemRewardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<MerchantListResponse> MerchantList([WorkflowExpression] Func<int> cursor = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/merchants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<MerchantListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<MerchantRetrieveResponse> MerchantRetrieve([WorkflowExpression] Func<string> merchantId)
        {
            SourceExpression.Validate(merchantId, nameof(merchantId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/merchants/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(merchantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MerchantRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<MobileAuthorizationCreateResponse> MobileAuthorizationCreate([WorkflowExpression] Func<string> bodylocationId = null)
        {
            SourceExpression.Validate(bodylocationId, nameof(bodylocationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mobile/authorization-code";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylocationId != null)
                {
                    body["location_id"] = SourceExpressionConverter.ConvertToken(bodylocationId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MobileAuthorizationCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<SiteListResponse> SiteList()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SiteListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<SnippetRetrieveResponse> SnippetRetrieve([WorkflowExpression] Func<string> siteId)
        {
            SourceExpression.Validate(siteId, nameof(siteId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sites/{0}/snippet", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(siteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SnippetRetrieveResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<JToken> SnippetDelete([WorkflowExpression] Func<string> siteId)
        {
            SourceExpression.Validate(siteId, nameof(siteId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sites/{0}/snippet", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(siteId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<SnippetUpsertResponse> SnippetUpsert([WorkflowExpression] Func<string> siteId, [WorkflowExpression] Func<string> bodysnippetcontent = null)
        {
            SourceExpression.Validate(siteId, nameof(siteId), required: true);
            SourceExpression.Validate(bodysnippetcontent, nameof(bodysnippetcontent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/sites/{0}/snippet", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(siteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var snippetObject = new JObject();
                var snippetObjectpropCount = 0;
                if (bodysnippetcontent != null)
                {
                    snippetObject["content"] = SourceExpressionConverter.ConvertToken(bodysnippetcontent);
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
                return callPayload;
            }

            return new ApiConnectionAction<SnippetUpsertResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamCreateMemberResponse> TeamCreateMember([WorkflowExpression] Func<string> bodyidempotencyKey = null, [WorkflowExpression] Func<string> bodyteamMemberreferenceId = null, [WorkflowExpression] Func<string> bodyteamMemberstatus = null, [WorkflowExpression] Func<string> bodyteamMembergivenName = null, [WorkflowExpression] Func<string> bodyteamMemberfamilyName = null, [WorkflowExpression] Func<string> bodyteamMemberemailAddress = null, [WorkflowExpression] Func<string> bodyteamMemberphoneNumber = null, [WorkflowExpression] Func<string[]> bodyteamMemberassignedLocationslocationIds = null, [WorkflowExpression] Func<string> bodyteamMemberassignedLocationsassignmentType = null)
        {
            SourceExpression.Validate(bodyidempotencyKey, nameof(bodyidempotencyKey), required: false);
            SourceExpression.Validate(bodyteamMemberreferenceId, nameof(bodyteamMemberreferenceId), required: false);
            SourceExpression.Validate(bodyteamMemberstatus, nameof(bodyteamMemberstatus), required: false);
            SourceExpression.Validate(bodyteamMembergivenName, nameof(bodyteamMembergivenName), required: false);
            SourceExpression.Validate(bodyteamMemberfamilyName, nameof(bodyteamMemberfamilyName), required: false);
            SourceExpression.Validate(bodyteamMemberemailAddress, nameof(bodyteamMemberemailAddress), required: false);
            SourceExpression.Validate(bodyteamMemberphoneNumber, nameof(bodyteamMemberphoneNumber), required: false);
            SourceExpression.Validate(bodyteamMemberassignedLocationslocationIds, nameof(bodyteamMemberassignedLocationslocationIds), required: false);
            SourceExpression.Validate(bodyteamMemberassignedLocationsassignmentType, nameof(bodyteamMemberassignedLocationsassignmentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/team-members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidempotencyKey != null)
                {
                    body["idempotency_key"] = SourceExpressionConverter.ConvertToken(bodyidempotencyKey);
                    bodypropCount++;
                }

                var teamMemberObject = new JObject();
                var teamMemberObjectpropCount = 0;
                if (bodyteamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodyteamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberstatus != null)
                {
                    teamMemberObject["status"] = SourceExpressionConverter.ConvertToken(bodyteamMemberstatus);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = SourceExpressionConverter.ConvertToken(bodyteamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = SourceExpressionConverter.ConvertToken(bodyteamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodyteamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (bodyteamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyteamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (bodyteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = SourceExpressionConverter.ConvertToken(bodyteamMemberassignedLocationsassignmentType);
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
                return callPayload;
            }

            return new ApiConnectionAction<TeamCreateMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamCreateBulkMembersResponse> TeamCreateBulkMembers([WorkflowExpression] Func<string> bodyteamMembersidempotencyKey1teamMembergivenName = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey1teamMemberfamilyName = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey1teamMemberemailAddress = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey1teamMemberreferenceId = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey1teamMemberphoneNumber = null, [WorkflowExpression] Func<string[]> bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey2teamMembergivenName = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey2teamMemberfamilyName = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey2teamMemberemailAddress = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey2teamMemberreferenceId = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey2teamMemberphoneNumber = null, [WorkflowExpression] Func<string> bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType = null)
        {
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMembergivenName, nameof(bodyteamMembersidempotencyKey1teamMembergivenName), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMemberfamilyName, nameof(bodyteamMembersidempotencyKey1teamMemberfamilyName), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMemberemailAddress, nameof(bodyteamMembersidempotencyKey1teamMemberemailAddress), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMemberreferenceId, nameof(bodyteamMembersidempotencyKey1teamMemberreferenceId), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMemberphoneNumber, nameof(bodyteamMembersidempotencyKey1teamMemberphoneNumber), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds, nameof(bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType, nameof(bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey2teamMembergivenName, nameof(bodyteamMembersidempotencyKey2teamMembergivenName), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey2teamMemberfamilyName, nameof(bodyteamMembersidempotencyKey2teamMemberfamilyName), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey2teamMemberemailAddress, nameof(bodyteamMembersidempotencyKey2teamMemberemailAddress), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey2teamMemberreferenceId, nameof(bodyteamMembersidempotencyKey2teamMemberreferenceId), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey2teamMemberphoneNumber, nameof(bodyteamMembersidempotencyKey2teamMemberphoneNumber), required: false);
            SourceExpression.Validate(bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType, nameof(bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyteamMembersidempotencyKey1teamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersidempotencyKey1teamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersidempotencyKey1teamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersidempotencyKey1teamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersidempotencyKey1teamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey1teamMemberassignedLocationsassignmentType);
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
                if (bodyteamMembersidempotencyKey2teamMembergivenName != null)
                {
                    teamMemberObject2["given_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey2teamMembergivenName);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersidempotencyKey2teamMemberfamilyName != null)
                {
                    teamMemberObject2["family_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey2teamMemberfamilyName);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersidempotencyKey2teamMemberemailAddress != null)
                {
                    teamMemberObject2["email_address"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey2teamMemberemailAddress);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersidempotencyKey2teamMemberreferenceId != null)
                {
                    teamMemberObject2["reference_id"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey2teamMemberreferenceId);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersidempotencyKey2teamMemberphoneNumber != null)
                {
                    teamMemberObject2["phone_number"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey2teamMemberphoneNumber);
                    teamMemberObject2propCount++;
                }

                var assignedLocationsObject2 = new JObject();
                var assignedLocationsObject2propCount = 0;
                if (bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject2["assignment_type"] = SourceExpressionConverter.ConvertToken(bodyteamMembersidempotencyKey2teamMemberassignedLocationsassignmentType);
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
                return callPayload;
            }

            return new ApiConnectionAction<TeamCreateBulkMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateBulkMembersResponse> TeamUpdateBulkMembers([WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId = null, [WorkflowExpression] Func<bool> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner = null, [WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus = null, [WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName = null, [WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName = null, [WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress = null, [WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber = null, [WorkflowExpression] Func<string[]> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds = null, [WorkflowExpression] Func<string> bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId = null, [WorkflowExpression] Func<bool> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber = null, [WorkflowExpression] Func<string> bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType = null)
        {
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds), required: false);
            SourceExpression.Validate(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType, nameof(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber), required: false);
            SourceExpression.Validate(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType, nameof(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner != null)
                {
                    teamMemberObject["is_owner"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberisOwner);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus != null)
                {
                    teamMemberObject["status"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberstatus);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = SourceExpressionConverter.ConvertToken(bodyteamMembersfpgteZNMaf0qOKA4t6PteamMemberassignedLocationsassignmentType);
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
                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId != null)
                {
                    teamMemberObject2["reference_id"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberreferenceId);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner != null)
                {
                    teamMemberObject2["is_owner"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberisOwner);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus != null)
                {
                    teamMemberObject2["status"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberstatus);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName != null)
                {
                    teamMemberObject2["given_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMembergivenName);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName != null)
                {
                    teamMemberObject2["family_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberfamilyName);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress != null)
                {
                    teamMemberObject2["email_address"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberemailAddress);
                    teamMemberObject2propCount++;
                }

                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber != null)
                {
                    teamMemberObject2["phone_number"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberphoneNumber);
                    teamMemberObject2propCount++;
                }

                var assignedLocationsObject2 = new JObject();
                var assignedLocationsObject2propCount = 0;
                if (bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject2["assignment_type"] = SourceExpressionConverter.ConvertToken(bodyteamMembersaFMwA08kRMIF3Vs0OEteamMemberassignedLocationsassignmentType);
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
                return callPayload;
            }

            return new ApiConnectionAction<TeamUpdateBulkMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamSearchResponse> TeamSearch([WorkflowExpression] Func<string[]> bodyqueryfilterlocationIds = null, [WorkflowExpression] Func<string> bodyqueryfilterstatus = null, [WorkflowExpression] Func<int> bodylimit = null)
        {
            SourceExpression.Validate(bodyqueryfilterlocationIds, nameof(bodyqueryfilterlocationIds), required: false);
            SourceExpression.Validate(bodyqueryfilterstatus, nameof(bodyqueryfilterstatus), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                if (bodyqueryfilterlocationIds != null)
                {
                    filterObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterlocationIds);
                    filterObjectpropCount++;
                }

                if (bodyqueryfilterstatus != null)
                {
                    filterObject["status"] = SourceExpressionConverter.ConvertToken(bodyqueryfilterstatus);
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

                if (bodylimit != null)
                {
                    body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TeamSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamRetrieveMemberResponse> TeamRetrieveMember([WorkflowExpression] Func<string> teamMemberId)
        {
            SourceExpression.Validate(teamMemberId, nameof(teamMemberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/team-members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamMemberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TeamRetrieveMemberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateResponse> TeamUpdate([WorkflowExpression] Func<string> teamMemberId, [WorkflowExpression] Func<string> bodyteamMemberreferenceId = null, [WorkflowExpression] Func<string> bodyteamMemberstatus = null, [WorkflowExpression] Func<string> bodyteamMembergivenName = null, [WorkflowExpression] Func<string> bodyteamMemberfamilyName = null, [WorkflowExpression] Func<string> bodyteamMemberemailAddress = null, [WorkflowExpression] Func<string> bodyteamMemberphoneNumber = null, [WorkflowExpression] Func<string[]> bodyteamMemberassignedLocationslocationIds = null, [WorkflowExpression] Func<string> bodyteamMemberassignedLocationsassignmentType = null)
        {
            SourceExpression.Validate(teamMemberId, nameof(teamMemberId), required: true);
            SourceExpression.Validate(bodyteamMemberreferenceId, nameof(bodyteamMemberreferenceId), required: false);
            SourceExpression.Validate(bodyteamMemberstatus, nameof(bodyteamMemberstatus), required: false);
            SourceExpression.Validate(bodyteamMembergivenName, nameof(bodyteamMembergivenName), required: false);
            SourceExpression.Validate(bodyteamMemberfamilyName, nameof(bodyteamMemberfamilyName), required: false);
            SourceExpression.Validate(bodyteamMemberemailAddress, nameof(bodyteamMemberemailAddress), required: false);
            SourceExpression.Validate(bodyteamMemberphoneNumber, nameof(bodyteamMemberphoneNumber), required: false);
            SourceExpression.Validate(bodyteamMemberassignedLocationslocationIds, nameof(bodyteamMemberassignedLocationslocationIds), required: false);
            SourceExpression.Validate(bodyteamMemberassignedLocationsassignmentType, nameof(bodyteamMemberassignedLocationsassignmentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/team-members/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamMemberId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var teamMemberObject = new JObject();
                var teamMemberObjectpropCount = 0;
                if (bodyteamMemberreferenceId != null)
                {
                    teamMemberObject["reference_id"] = SourceExpressionConverter.ConvertToken(bodyteamMemberreferenceId);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberstatus != null)
                {
                    teamMemberObject["status"] = SourceExpressionConverter.ConvertToken(bodyteamMemberstatus);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMembergivenName != null)
                {
                    teamMemberObject["given_name"] = SourceExpressionConverter.ConvertToken(bodyteamMembergivenName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberfamilyName != null)
                {
                    teamMemberObject["family_name"] = SourceExpressionConverter.ConvertToken(bodyteamMemberfamilyName);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberemailAddress != null)
                {
                    teamMemberObject["email_address"] = SourceExpressionConverter.ConvertToken(bodyteamMemberemailAddress);
                    teamMemberObjectpropCount++;
                }

                if (bodyteamMemberphoneNumber != null)
                {
                    teamMemberObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodyteamMemberphoneNumber);
                    teamMemberObjectpropCount++;
                }

                var assignedLocationsObject = new JObject();
                var assignedLocationsObjectpropCount = 0;
                if (bodyteamMemberassignedLocationslocationIds != null)
                {
                    assignedLocationsObject["location_ids"] = SourceExpressionConverter.ConvertToken(bodyteamMemberassignedLocationslocationIds);
                    assignedLocationsObjectpropCount++;
                }

                if (bodyteamMemberassignedLocationsassignmentType != null)
                {
                    assignedLocationsObject["assignment_type"] = SourceExpressionConverter.ConvertToken(bodyteamMemberassignedLocationsassignmentType);
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
                return callPayload;
            }

            return new ApiConnectionAction<TeamUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamRetrieveWageResponse> TeamRetrieveWage([WorkflowExpression] Func<string> teamMemberId)
        {
            SourceExpression.Validate(teamMemberId, nameof(teamMemberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/team-members/{0}/wage-setting", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamMemberId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TeamRetrieveWageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateWageResponse> TeamUpdateWage([WorkflowExpression] Func<string> teamMemberId, [WorkflowExpression] Func<bool> bodywageSettingisOvertimeExempt = null, [WorkflowExpression] Func<bodywageSettingjobAssignmentsInputItem[]> bodywageSettingjobAssignments = null)
        {
            SourceExpression.Validate(teamMemberId, nameof(teamMemberId), required: true);
            SourceExpression.Validate(bodywageSettingisOvertimeExempt, nameof(bodywageSettingisOvertimeExempt), required: false);
            SourceExpression.Validate(bodywageSettingjobAssignments, nameof(bodywageSettingjobAssignments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/team-members/{0}/wage-setting", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamMemberId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var wageSettingObject = new JObject();
                var wageSettingObjectpropCount = 0;
                if (bodywageSettingisOvertimeExempt != null)
                {
                    wageSettingObject["is_overtime_exempt"] = SourceExpressionConverter.ConvertToken(bodywageSettingisOvertimeExempt);
                    wageSettingObjectpropCount++;
                }

                if (bodywageSettingjobAssignments != null)
                {
                    wageSettingObject["job_assignments"] = SourceExpressionConverter.ConvertToken(bodywageSettingjobAssignments);
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
                return callPayload;
            }

            return new ApiConnectionAction<TeamUpdateWageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BankAccountGetV1Response> BankAccountGet([WorkflowExpression] Func<string> v1BankAccountId)
        {
            SourceExpression.Validate(v1BankAccountId, nameof(v1BankAccountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bank-accounts/by-v1-id/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(v1BankAccountId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BankAccountGetV1Response>(BuildSourceInput);
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