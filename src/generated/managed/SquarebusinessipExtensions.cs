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
        public IBodyWorkflowAction<BookingCreateResponse, ApiConnectionActionConfiguration> BookingCreate(Expression<Func<BookingCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BookingCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bookings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BookingCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BookingAvailabilityResponse, ApiConnectionActionConfiguration> BookingAvailability(Expression<Func<BookingAvailabilityBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BookingAvailabilityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bookings/availability/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<CashDrawerListShiftsResponse, ApiConnectionActionConfiguration> CashDrawerListShifts(Expression<Func<string>> locationId = null, Expression<Func<SortOrderInput>> sortOrder = null, Expression<Func<string>> beginTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null)
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
        public IBodyWorkflowAction<CheckoutCreateResponse, ApiConnectionActionConfiguration> CheckoutCreate(Expression<Func<string>> locationId, Expression<Func<CheckoutCreateBodyInput>> body)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CheckoutCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}/checkouts", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CheckoutCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<DeviceListResponse, ApiConnectionActionConfiguration> DeviceList(Expression<Func<string>> cursor = null, Expression<Func<string>> locationId = null, Expression<Func<string>> productType = null, Expression<Func<StatusInput>> status = null)
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
        public IBodyWorkflowAction<DeviceCreateResponse, ApiConnectionActionConfiguration> DeviceCreate(Expression<Func<DeviceCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeviceCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/devices/codes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<GiftCardListResponse, ApiConnectionActionConfiguration> GiftCardList(Expression<Func<string>> giftCardId = null, Expression<Func<string>> type = null, Expression<Func<string>> locationId = null, Expression<Func<string>> beginTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> limit = null, Expression<Func<string>> cursor = null, Expression<Func<SortOrderInput>> sortOrder = null)
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
        public IBodyWorkflowAction<GiftCardCreateResponse, ApiConnectionActionConfiguration> GiftCardCreate(Expression<Func<GiftCardCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GiftCardCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftCardCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveGanResponse, ApiConnectionActionConfiguration> GiftCardRetrieveGan(Expression<Func<GiftCardRetrieveGanBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftCardRetrieveGanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/from-gan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftCardRetrieveGanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardRetrieveNonceResponse, ApiConnectionActionConfiguration> GiftCardRetrieveNonce(Expression<Func<GiftCardRetrieveNonceBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GiftCardRetrieveNonceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-cards/from-nonce";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftCardRetrieveNonceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardLinkResponse, ApiConnectionActionConfiguration> GiftCardLink(Expression<Func<string>> giftCardId, Expression<Func<GiftCardLinkBodyInput>> body = null)
        {
            var __workflow_giftCardId = WorkflowExpression.Compile(giftCardId, nameof(giftCardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GiftCardLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift-cards/{0}/link-customer", __workflow_giftCardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftCardLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<GiftCardUnlinkResponse, ApiConnectionActionConfiguration> GiftCardUnlink(Expression<Func<string>> giftCardId, Expression<Func<GiftCardLinkBodyInput>> body)
        {
            var __workflow_giftCardId = WorkflowExpression.Compile(giftCardId, nameof(giftCardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftCardUnlinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift-cards/{0}/unlink-customer", __workflow_giftCardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LaborCreateBreakResponse, ApiConnectionActionConfiguration> LaborCreateBreak(Expression<Func<LaborCreateBreakBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LaborCreateBreakResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/break-types";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LaborUpdateBreakResponse, ApiConnectionActionConfiguration> LaborUpdateBreak(Expression<Func<string>> id, Expression<Func<LaborUpdateBreakBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LaborUpdateBreakResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/break-types/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LaborUpdateBreakResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborCreateShiftResponse, ApiConnectionActionConfiguration> LaborCreateShift(Expression<Func<LaborCreateShiftBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LaborCreateShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/shifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LaborCreateShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LaborSearchShiftsResponse, ApiConnectionActionConfiguration> LaborSearchShifts(Expression<Func<LaborSearchShiftsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LaborSearchShiftsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/labor/shifts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LaborUpdateShiftResponse, ApiConnectionActionConfiguration> LaborUpdateShift(Expression<Func<string>> id, Expression<Func<LaborUpdateShiftBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LaborUpdateShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/shifts/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LaborUpdateConfigResponse, ApiConnectionActionConfiguration> LaborUpdateConfig(Expression<Func<string>> id, Expression<Func<LaborUpdateConfigBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LaborUpdateConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/labor/workweek-configs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LocationCreateResponse, ApiConnectionActionConfiguration> LocationCreate(Expression<Func<LocationCreateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LocationCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LocationUpdateResponse, ApiConnectionActionConfiguration> LocationUpdate(Expression<Func<string>> locationId, Expression<Func<LocationUpdateBodyInput>> body)
        {
            var __workflow_locationId = WorkflowExpression.Compile(locationId, nameof(locationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LocationUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}", __workflow_locationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LocationUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCreateAccountResponse, ApiConnectionActionConfiguration> LoyaltyCreateAccount(Expression<Func<LoyaltyCreateAccountBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltyCreateAccountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/accounts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoyaltyCreateAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchAccountsResponse, ApiConnectionActionConfiguration> LoyaltySearchAccounts(Expression<Func<LoyaltySearchAccountsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltySearchAccountsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/accounts/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LoyaltyAccumulatePointsResponse, ApiConnectionActionConfiguration> LoyaltyAccumulatePoints(Expression<Func<string>> accountId, Expression<Func<LoyaltyAccumulatePointsBodyInput>> body)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltyAccumulatePointsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/accounts/{0}/accumulate", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoyaltyAccumulatePointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyAdjustPointsResponse, ApiConnectionActionConfiguration> LoyaltyAdjustPoints(Expression<Func<string>> accountId, Expression<Func<LoyaltyAdjustPointsBodyInput>> body = null)
        {
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LoyaltyAdjustPointsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/accounts/{0}/adjust", __workflow_accountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoyaltyAdjustPointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchEventsResponse, ApiConnectionActionConfiguration> LoyaltySearchEvents(Expression<Func<LoyaltySearchEventsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltySearchEventsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/events/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LoyaltyCalculatePointsResponse, ApiConnectionActionConfiguration> LoyaltyCalculatePoints(Expression<Func<string>> programId, Expression<Func<LoyaltyCalculatePointsBodyInput>> body)
        {
            var __workflow_programId = WorkflowExpression.Compile(programId, nameof(programId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltyCalculatePointsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/programs/{0}/calculate", __workflow_programId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoyaltyCalculatePointsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltyCreateRewardResponse, ApiConnectionActionConfiguration> LoyaltyCreateReward(Expression<Func<LoyaltyCreateRewardBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltyCreateRewardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/rewards";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoyaltyCreateRewardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<LoyaltySearchRewardsResponse, ApiConnectionActionConfiguration> LoyaltySearchRewards(Expression<Func<LoyaltySearchRewardsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltySearchRewardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/loyalty/rewards/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<LoyaltyRedeemRewardResponse, ApiConnectionActionConfiguration> LoyaltyRedeemReward(Expression<Func<string>> rewardId, Expression<Func<LoyaltyRedeemRewardBodyInput>> body)
        {
            var __workflow_rewardId = WorkflowExpression.Compile(rewardId, nameof(rewardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoyaltyRedeemRewardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/loyalty/rewards/{0}/redeem", __workflow_rewardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<MobileAuthorizationCreateResponse, ApiConnectionActionConfiguration> MobileAuthorizationCreate(Expression<Func<MobileAuthorizationCreateBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MobileAuthorizationCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mobile/authorization-code";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<SnippetUpsertResponse, ApiConnectionActionConfiguration> SnippetUpsert(Expression<Func<string>> siteId, Expression<Func<SnippetUpsertBodyInput>> body)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SnippetUpsertResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/sites/{0}/snippet", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SnippetUpsertResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamCreateMemberResponse, ApiConnectionActionConfiguration> TeamCreateMember(Expression<Func<TeamCreateMemberBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TeamCreateMemberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TeamCreateMemberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamCreateBulkMembersResponse, ApiConnectionActionConfiguration> TeamCreateBulkMembers(Expression<Func<TeamCreateBulkMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TeamCreateBulkMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members/bulk-create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TeamCreateBulkMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamUpdateBulkMembersResponse, ApiConnectionActionConfiguration> TeamUpdateBulkMembers(Expression<Func<TeamUpdateBulkMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TeamUpdateBulkMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members/bulk-update";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TeamUpdateBulkMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<TeamSearchResponse, ApiConnectionActionConfiguration> TeamSearch(Expression<Func<TeamSearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TeamSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/team-members/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<TeamUpdateResponse, ApiConnectionActionConfiguration> TeamUpdate(Expression<Func<string>> teamMemberId, Expression<Func<TeamUpdateBodyInput>> body)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TeamUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team-members/{0}", __workflow_teamMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public IBodyWorkflowAction<TeamUpdateWageResponse, ApiConnectionActionConfiguration> TeamUpdateWage(Expression<Func<string>> teamMemberId, Expression<Func<TeamUpdateWageBodyInput>> body)
        {
            var __workflow_teamMemberId = WorkflowExpression.Compile(teamMemberId, nameof(teamMemberId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TeamUpdateWageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/team-members/{0}/wage-setting", __workflow_teamMemberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TeamUpdateWageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "squarebusinessip")]
        public IBodyWorkflowAction<BankAccountGetResponse, ApiConnectionActionConfiguration> BankAccountGet(Expression<Func<string>> v1BankAccountId)
        {
            var __workflow_v1BankAccountId = WorkflowExpression.Compile(v1BankAccountId, nameof(v1BankAccountId), required: true);
            return new DeferredBodyAction<BankAccountGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bank-accounts/by-v1-id/{0}", __workflow_v1BankAccountId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BankAccountGetResponse>(callPayload);
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

    public class BookingCreateBodyInput
    {
        [JsonProperty("booking")]
        public BodyInputBookingType Booking { get; set; }
    }

    public class BodyInputBookingType
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("appointment_segments")]
        public BodyInputBookingTypeAppointmentSegmentsTypeItem[] AppointmentSegments { get; set; }
    }

    public class BodyInputBookingTypeAppointmentSegmentsTypeItem
    {
        [JsonProperty("duration_minutes")]
        public int? DurationMinutes { get; set; }

        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("service_variation_id")]
        public string ServiceVariationId { get; set; }

        [JsonProperty("service_variation_version")]
        public int? ServiceVariationVersion { get; set; }
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

    public class BookingAvailabilityBodyInput
    {
        [JsonProperty("query")]
        public BookingAvailabilityBodyInputQueryType Query { get; set; }
    }

    public class BookingAvailabilityBodyInputQueryType
    {
        [JsonProperty("filter")]
        public BookingAvailabilityBodyInputQueryTypeFilterType Filter { get; set; }
    }

    public class BookingAvailabilityBodyInputQueryTypeFilterType
    {
        [JsonProperty("start_at_range")]
        public BodyInputQueryTypeFilterTypeStartAtRangeType StartAtRange { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("segment_filters")]
        public BodyInputQueryTypeFilterTypeSegmentFiltersTypeItem[] SegmentFilters { get; set; }
    }

    public class BodyInputQueryTypeFilterTypeStartAtRangeType
    {
        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }
    }

    public class BodyInputQueryTypeFilterTypeSegmentFiltersTypeItem
    {
        [JsonProperty("service_variation_id")]
        public string ServiceVariationId { get; set; }

        [JsonProperty("team_member_id_filter")]
        public BodyInputQueryTypeFilterTypeSegmentFiltersTypeItemTeamMemberIdFilterType TeamMemberIdFilter { get; set; }
    }

    public class BodyInputQueryTypeFilterTypeSegmentFiltersTypeItemTeamMemberIdFilterType
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
    public enum SortOrderInput
    {
        [EnumMember(Value = "ASC")]
        Asc,
        [EnumMember(Value = "DESC")]
        Desc
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

    public class CheckoutCreateBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        [JsonProperty("order")]
        public BodyInputOrderType Order { get; set; }

        [JsonProperty("additional_recipients")]
        public BodyInputAdditionalRecipientsTypeItem[] AdditionalRecipients { get; set; }

        [JsonProperty("ask_for_shipping_address")]
        public bool? AskForShippingAddress { get; set; }

        [JsonProperty("merchant_support_email")]
        public string MerchantSupportEmail { get; set; }

        [JsonProperty("pre_populate_buyer_email")]
        public string PrePopulateBuyerEmail { get; set; }

        [JsonProperty("pre_populate_shipping_address")]
        public BodyInputPrePopulateShippingAddressType PrePopulateShippingAddress { get; set; }
    }

    public class BodyInputOrderType
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("order")]
        public BodyInputOrderTypeOrderType Order { get; set; }
    }

    public class BodyInputOrderTypeOrderType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("line_items")]
        public BodyInputOrderTypeOrderTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("taxes")]
        public BodyInputOrderTypeOrderTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("discounts")]
        public BodyInputOrderTypeOrderTypeDiscountsTypeItem[] Discounts { get; set; }
    }

    public class BodyInputOrderTypeOrderTypeLineItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("base_price_money")]
        public BodyInputOrderTypeOrderTypeLineItemsTypeItemBasePriceMoneyType BasePriceMoney { get; set; }

        [JsonProperty("applied_discounts")]
        public BodyInputOrderTypeOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem[] AppliedDiscounts { get; set; }

        [JsonProperty("applied_taxes")]
        public BodyInputOrderTypeOrderTypeLineItemsTypeItemAppliedTaxesTypeItem[] AppliedTaxes { get; set; }
    }

    public class BodyInputOrderTypeOrderTypeLineItemsTypeItemBasePriceMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BodyInputOrderTypeOrderTypeLineItemsTypeItemAppliedDiscountsTypeItem
    {
        [JsonProperty("discount_uid")]
        public string DiscountUid { get; set; }
    }

    public class BodyInputOrderTypeOrderTypeLineItemsTypeItemAppliedTaxesTypeItem
    {
        [JsonProperty("tax_uid")]
        public string TaxUid { get; set; }
    }

    public class BodyInputOrderTypeOrderTypeTaxesTypeItem
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

    public class BodyInputOrderTypeOrderTypeDiscountsTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("amount_money")]
        public BodyInputOrderTypeOrderTypeDiscountsTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class BodyInputOrderTypeOrderTypeDiscountsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BodyInputAdditionalRecipientsTypeItem
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("amount_money")]
        public BodyInputAdditionalRecipientsTypeItemAmountMoneyType AmountMoney { get; set; }
    }

    public class BodyInputAdditionalRecipientsTypeItemAmountMoneyType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BodyInputPrePopulateShippingAddressType
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
    public enum StatusInput
    {
        [EnumMember(Value = "UNKNOWN")]
        Unknown,
        [EnumMember(Value = "UNPAIRED")]
        Unpaired,
        [EnumMember(Value = "PAIRED")]
        Paired,
        [EnumMember(Value = "EXPIRED")]
        Expired
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

    public class DeviceCreateBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("device_code")]
        public BodyInputDeviceCodeType DeviceCode { get; set; }
    }

    public class BodyInputDeviceCodeType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }
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

    public class GiftCardCreateBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("gift_card_activity")]
        public BodyInputGiftCardActivityType GiftCardActivity { get; set; }
    }

    public class BodyInputGiftCardActivityType
    {
        [JsonProperty("gift_card_id")]
        public string GiftCardId { get; set; }

        [JsonProperty("type")]
        public BodyInputGiftCardActivityTypeTypeType? Type { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("activate_activity_details")]
        public BodyInputGiftCardActivityTypeActivateActivityDetailsType ActivateActivityDetails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGiftCardActivityTypeTypeType
    {
        [EnumMember(Value = "ACTIVATE")]
        Activate,
        [EnumMember(Value = "LOAD")]
        Load,
        [EnumMember(Value = "REDEEM")]
        Redeem,
        [EnumMember(Value = "CLEAR_BALANCE")]
        ClearBalance,
        [EnumMember(Value = "DEACTIVATE")]
        Deactivate,
        [EnumMember(Value = "ADJUST_INCREMENT")]
        AdjustIncrement,
        [EnumMember(Value = "ADJUST_DECREMENT")]
        AdjustDecrement,
        [EnumMember(Value = "REFUND")]
        Refund,
        [EnumMember(Value = "UNLINKED_ACTIVITY_REFUND")]
        UnlinkedActivityRefund,
        [EnumMember(Value = "IMPORT")]
        Import,
        [EnumMember(Value = "BLOCK")]
        Block,
        [EnumMember(Value = "UNBLOCK")]
        Unblock,
        [EnumMember(Value = "IMPORT_REVERSAL")]
        ImportReversal
    }

    public class BodyInputGiftCardActivityTypeActivateActivityDetailsType
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("line_item_uid")]
        public string LineItemUid { get; set; }
    }

    public class GiftCardRetrieveGanResponse
    {
        [JsonProperty("gift_card")]
        public GiftCardRetrieveGanResponseGiftCardType GiftCard { get; set; }
    }

    public class GiftCardRetrieveGanResponseGiftCardType
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
        public GiftCardRetrieveGanResponseGiftCardTypeBalanceMoneyType BalanceMoney { get; set; }

        [JsonProperty("gan")]
        public string Gan { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GiftCardRetrieveGanResponseGiftCardTypeBalanceMoneyType
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class GiftCardRetrieveGanBodyInput
    {
        [JsonProperty("gan")]
        public string Gan { get; set; }
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

    public class GiftCardRetrieveNonceBodyInput
    {
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
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

    public class GiftCardLinkBodyInput
    {
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
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

    public class LaborCreateBreakBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("break_type")]
        public LaborCreateBreakBodyInputBreakTypeType BreakType { get; set; }
    }

    public class LaborCreateBreakBodyInputBreakTypeType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("break_name")]
        public string BreakName { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool? IsPaid { get; set; }
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

    public class LaborUpdateBreakBodyInput
    {
        [JsonProperty("break_type")]
        public LaborUpdateBreakBodyInputBreakTypeType BreakType { get; set; }
    }

    public class LaborUpdateBreakBodyInputBreakTypeType
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("break_name")]
        public string BreakName { get; set; }

        [JsonProperty("expected_duration")]
        public string ExpectedDuration { get; set; }

        [JsonProperty("is_paid")]
        public bool? IsPaid { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }
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

    public class LaborCreateShiftBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("shift")]
        public LaborCreateShiftBodyInputShiftType Shift { get; set; }
    }

    public class LaborCreateShiftBodyInputShiftType
    {
        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("wage")]
        public BodyInputShiftTypeWageType Wage { get; set; }

        [JsonProperty("breaks")]
        public LaborCreateShiftBodyInputShiftTypeBreaksTypeItem[] Breaks { get; set; }
    }

    public class BodyInputShiftTypeWageType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hourly_rate")]
        public BodyInputShiftTypeWageTypeHourlyRateType HourlyRate { get; set; }
    }

    public class BodyInputShiftTypeWageTypeHourlyRateType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class LaborCreateShiftBodyInputShiftTypeBreaksTypeItem
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
        public bool? IsPaid { get; set; }
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

    public class LaborSearchShiftsBodyInput
    {
        [JsonProperty("query")]
        public LaborSearchShiftsBodyInputQueryType Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class LaborSearchShiftsBodyInputQueryType
    {
        [JsonProperty("filter")]
        public LaborSearchShiftsBodyInputQueryTypeFilterType Filter { get; set; }
    }

    public class LaborSearchShiftsBodyInputQueryTypeFilterType
    {
        [JsonProperty("workday")]
        public BodyInputQueryTypeFilterTypeWorkdayType Workday { get; set; }
    }

    public class BodyInputQueryTypeFilterTypeWorkdayType
    {
        [JsonProperty("date_range")]
        public BodyInputQueryTypeFilterTypeWorkdayTypeDateRangeType DateRange { get; set; }

        [JsonProperty("match_shifts_by")]
        public string MatchShiftsBy { get; set; }

        [JsonProperty("default_timezone")]
        public string DefaultTimezone { get; set; }
    }

    public class BodyInputQueryTypeFilterTypeWorkdayTypeDateRangeType
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
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

    public class LaborUpdateShiftBodyInput
    {
        [JsonProperty("shift")]
        public LaborUpdateShiftBodyInputShiftType Shift { get; set; }
    }

    public class LaborUpdateShiftBodyInputShiftType
    {
        [JsonProperty("team_member_id")]
        public string TeamMemberId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("start_at")]
        public string StartAt { get; set; }

        [JsonProperty("end_at")]
        public string EndAt { get; set; }

        [JsonProperty("wage")]
        public BodyInputShiftTypeWageType Wage { get; set; }

        [JsonProperty("breaks")]
        public LaborUpdateShiftBodyInputShiftTypeBreaksTypeItem[] Breaks { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }
    }

    public class LaborUpdateShiftBodyInputShiftTypeBreaksTypeItem
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
        public bool? IsPaid { get; set; }
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

    public class LaborUpdateConfigBodyInput
    {
        [JsonProperty("workweek_config")]
        public BodyInputWorkweekConfigType WorkweekConfig { get; set; }
    }

    public class BodyInputWorkweekConfigType
    {
        [JsonProperty("start_of_week")]
        public string StartOfWeek { get; set; }

        [JsonProperty("start_of_day_local_time")]
        public string StartOfDayLocalTime { get; set; }

        [JsonProperty("version")]
        public int? Version { get; set; }
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
        public string TwitterUserName { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUserName { get; set; }

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

    public class LocationCreateBodyInput
    {
        [JsonProperty("location")]
        public LocationCreateBodyInputLocationType Location { get; set; }
    }

    public class LocationCreateBodyInputLocationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("address")]
        public BodyInputLocationTypeAddressType Address { get; set; }
    }

    public class BodyInputLocationTypeAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("administrative_district_level_1")]
        public string AdministrativeDistrictLevel1 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
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
        public string TwitterUserName { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUserName { get; set; }

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

    public class LocationUpdateBodyInput
    {
        [JsonProperty("location")]
        public LocationUpdateBodyInputLocationType Location { get; set; }
    }

    public class LocationUpdateBodyInputLocationType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("facebook_url")]
        public string FacebookUrl { get; set; }

        [JsonProperty("twitter_username")]
        public string TwitterUserName { get; set; }

        [JsonProperty("instagram_username")]
        public string InstagramUserName { get; set; }

        [JsonProperty("address")]
        public BodyInputLocationTypeAddressType Address { get; set; }

        [JsonProperty("business_hours")]
        public BodyInputLocationTypeBusinessHoursType BusinessHours { get; set; }
    }

    public class BodyInputLocationTypeBusinessHoursType
    {
        [JsonProperty("periods")]
        public BodyInputLocationTypeBusinessHoursTypePeriodsTypeItem[] Periods { get; set; }
    }

    public class BodyInputLocationTypeBusinessHoursTypePeriodsTypeItem
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

    public class LoyaltyCreateAccountBodyInput
    {
        [JsonProperty("loyalty_account")]
        public BodyInputLoyaltyAccountType LoyaltyAccount { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }

    public class BodyInputLoyaltyAccountType
    {
        [JsonProperty("mapping")]
        public BodyInputLoyaltyAccountTypeMappingType Mapping { get; set; }

        [JsonProperty("program_id")]
        public string ProgramId { get; set; }
    }

    public class BodyInputLoyaltyAccountTypeMappingType
    {
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
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

    public class LoyaltySearchAccountsBodyInput
    {
        [JsonProperty("query")]
        public JToken Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
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

    public class LoyaltyAccumulatePointsBodyInput
    {
        [JsonProperty("accumulate_points")]
        public BodyInputAccumulatePointsType AccumulatePoints { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }

    public class BodyInputAccumulatePointsType
    {
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

    public class LoyaltyAdjustPointsBodyInput
    {
        [JsonProperty("adjust_points")]
        public BodyInputAdjustPointsType AdjustPoints { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }

    public class BodyInputAdjustPointsType
    {
        [JsonProperty("points")]
        public int? Points { get; set; }

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

    public class LoyaltySearchEventsBodyInput
    {
        [JsonProperty("query")]
        public LoyaltySearchEventsBodyInputQueryType Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class LoyaltySearchEventsBodyInputQueryType
    {
        [JsonProperty("filter")]
        public LoyaltySearchEventsBodyInputQueryTypeFilterType Filter { get; set; }
    }

    public class LoyaltySearchEventsBodyInputQueryTypeFilterType
    {
        [JsonProperty("order_filter")]
        public BodyInputQueryTypeFilterTypeOrderFilterType OrderFilter { get; set; }
    }

    public class BodyInputQueryTypeFilterTypeOrderFilterType
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
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

    public class LoyaltyCalculatePointsBodyInput
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
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

    public class LoyaltyCreateRewardBodyInput
    {
        [JsonProperty("reward")]
        public BodyInputRewardType Reward { get; set; }

        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }
    }

    public class BodyInputRewardType
    {
        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }

        [JsonProperty("reward_tier_id")]
        public string RewardTierId { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }
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

    public class LoyaltySearchRewardsBodyInput
    {
        [JsonProperty("query")]
        public LoyaltySearchRewardsBodyInputQueryType Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class LoyaltySearchRewardsBodyInputQueryType
    {
        [JsonProperty("loyalty_account_id")]
        public string LoyaltyAccountId { get; set; }
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

    public class LoyaltyRedeemRewardBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }
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

    public class MobileAuthorizationCreateBodyInput
    {
        [JsonProperty("location_id")]
        public string LocationId { get; set; }
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

    public class SnippetUpsertBodyInput
    {
        [JsonProperty("snippet")]
        public BodyInputSnippetType Snippet { get; set; }
    }

    public class BodyInputSnippetType
    {
        [JsonProperty("content")]
        public string Content { get; set; }
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

    public class TeamCreateMemberBodyInput
    {
        [JsonProperty("idempotency_key")]
        public string IdempotencyKey { get; set; }

        [JsonProperty("team_member")]
        public BodyInputTeamMemberType TeamMember { get; set; }
    }

    public class BodyInputTeamMemberType
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

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
        public BodyInputTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class BodyInputTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }
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

    public class TeamCreateBulkMembersBodyInput
    {
        [JsonProperty("team_members")]
        public TeamCreateBulkMembersBodyInputTeamMembersType TeamMembers { get; set; }
    }

    public class TeamCreateBulkMembersBodyInputTeamMembersType
    {
        [JsonProperty("idempotency-key-1")]
        public BodyInputTeamMembersTypeIdempotencyKey1Type IdempotencyKey1 { get; set; }

        [JsonProperty("idempotency-key-2")]
        public BodyInputTeamMembersTypeIdempotencyKey2Type IdempotencyKey2 { get; set; }
    }

    public class BodyInputTeamMembersTypeIdempotencyKey1Type
    {
        [JsonProperty("team_member")]
        public BodyInputTeamMembersTypeIdempotencyKey1TypeTeamMemberType TeamMember { get; set; }
    }

    public class BodyInputTeamMembersTypeIdempotencyKey1TypeTeamMemberType
    {
        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("assigned_locations")]
        public BodyInputTeamMembersTypeIdempotencyKey1TypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class BodyInputTeamMembersTypeIdempotencyKey1TypeTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }
    }

    public class BodyInputTeamMembersTypeIdempotencyKey2Type
    {
        [JsonProperty("team_member")]
        public BodyInputTeamMembersTypeIdempotencyKey2TypeTeamMemberType TeamMember { get; set; }
    }

    public class BodyInputTeamMembersTypeIdempotencyKey2TypeTeamMemberType
    {
        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("assigned_locations")]
        public BodyInputTeamMembersTypeIdempotencyKey2TypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class BodyInputTeamMembersTypeIdempotencyKey2TypeTeamMemberTypeAssignedLocationsType
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

    public class TeamUpdateBulkMembersBodyInput
    {
        [JsonProperty("team_members")]
        public TeamUpdateBulkMembersBodyInputTeamMembersType TeamMembers { get; set; }
    }

    public class TeamUpdateBulkMembersBodyInputTeamMembersType
    {
        [JsonProperty("fpgteZNMaf0qOK-a4t6P")]
        public BodyInputTeamMembersTypeFpgteZNMaf0qOka4t6PType FpgteZNMaf0qOka4t6P { get; set; }

        [JsonProperty("AFMwA08kR-MIF-3Vs0OE")]
        public BodyInputTeamMembersTypeAFMwA08kRMif3Vs0OEType AFMwA08kRMif3Vs0OE { get; set; }
    }

    public class BodyInputTeamMembersTypeFpgteZNMaf0qOka4t6PType
    {
        [JsonProperty("team_member")]
        public BodyInputTeamMembersTypeFpgteZNMaf0qOka4t6PTypeTeamMemberType TeamMember { get; set; }
    }

    public class BodyInputTeamMembersTypeFpgteZNMaf0qOka4t6PTypeTeamMemberType
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool? IsOwner { get; set; }

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
        public BodyInputTeamMembersTypeFpgteZNMaf0qOka4t6PTypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class BodyInputTeamMembersTypeFpgteZNMaf0qOka4t6PTypeTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }
    }

    public class BodyInputTeamMembersTypeAFMwA08kRMif3Vs0OEType
    {
        [JsonProperty("team_member")]
        public BodyInputTeamMembersTypeAFMwA08kRMif3Vs0OETypeTeamMemberType TeamMember { get; set; }
    }

    public class BodyInputTeamMembersTypeAFMwA08kRMif3Vs0OETypeTeamMemberType
    {
        [JsonProperty("reference_id")]
        public string ReferenceId { get; set; }

        [JsonProperty("is_owner")]
        public bool? IsOwner { get; set; }

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
        public BodyInputTeamMembersTypeAFMwA08kRMif3Vs0OETypeTeamMemberTypeAssignedLocationsType AssignedLocations { get; set; }
    }

    public class BodyInputTeamMembersTypeAFMwA08kRMif3Vs0OETypeTeamMemberTypeAssignedLocationsType
    {
        [JsonProperty("assignment_type")]
        public string AssignmentType { get; set; }
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

    public class TeamSearchBodyInput
    {
        [JsonProperty("query")]
        public TeamSearchBodyInputQueryType Query { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }
    }

    public class TeamSearchBodyInputQueryType
    {
        [JsonProperty("filter")]
        public TeamSearchBodyInputQueryTypeFilterType Filter { get; set; }
    }

    public class TeamSearchBodyInputQueryTypeFilterType
    {
        [JsonProperty("location_ids")]
        public string[] LocationIds { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
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

    public class TeamUpdateBodyInput
    {
        [JsonProperty("team_member")]
        public BodyInputTeamMemberType TeamMember { get; set; }
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

    public class TeamUpdateWageBodyInput
    {
        [JsonProperty("wage_setting")]
        public BodyInputWageSettingType WageSetting { get; set; }
    }

    public class BodyInputWageSettingType
    {
        [JsonProperty("is_overtime_exempt")]
        public bool? IsOvertimeExempt { get; set; }

        [JsonProperty("job_assignments")]
        public BodyInputWageSettingTypeJobAssignmentsTypeItem[] JobAssignments { get; set; }
    }

    public class BodyInputWageSettingTypeJobAssignmentsTypeItem
    {
        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        [JsonProperty("annual_rate")]
        public BodyInputWageSettingTypeJobAssignmentsTypeItemAnnualRateType AnnualRate { get; set; }

        [JsonProperty("weekly_hours")]
        public int? WeeklyHours { get; set; }

        [JsonProperty("hourly_rate")]
        public BodyInputWageSettingTypeJobAssignmentsTypeItemHourlyRateType HourlyRate { get; set; }
    }

    public class BodyInputWageSettingTypeJobAssignmentsTypeItemAnnualRateType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BodyInputWageSettingTypeJobAssignmentsTypeItemHourlyRateType
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class BankAccountGetResponse
    {
        [JsonProperty("bank_account")]
        public BankAccountGetResponseBankAccountType BankAccount { get; set; }
    }

    public class BankAccountGetResponseBankAccountType
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