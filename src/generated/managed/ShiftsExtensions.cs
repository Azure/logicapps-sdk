//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shifts
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShiftsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ScheduleResponse, ApiConnectionActionConfiguration> GetSchedule(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<ScheduleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ScheduleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffResponse, ApiConnectionActionConfiguration> ListTimesOff(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListTimesOffResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timesoff", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListTimesOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffResponse, ApiConnectionActionConfiguration> CreateTimeOff(Expression<Func<string>> teamId, Expression<Func<CreateTimeOffRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<TimeOffResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timesoff", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<TimeOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffResponse, ApiConnectionActionConfiguration> GetTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> timeOffId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_timeOffId = WorkflowExpression.Compile(timeOffId, nameof(timeOffId), required: true);
            return new DeferredBodyAction<TimeOffResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_timeOffId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> timeOffId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_timeOffId = WorkflowExpression.Compile(timeOffId, nameof(timeOffId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_timeOffId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsResponse, ApiConnectionActionConfiguration> ListShifts(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListShiftsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/shifts", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListShiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ShiftResponse, ApiConnectionActionConfiguration> CreateShift(Expression<Func<string>> teamId, Expression<Func<CreateShiftRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<ShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/shifts", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<ShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ShiftResponse, ApiConnectionActionConfiguration> GetShift(Expression<Func<string>> teamId, Expression<Func<string>> shiftId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_shiftId = WorkflowExpression.Compile(shiftId, nameof(shiftId), required: true);
            return new DeferredBodyAction<ShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_shiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteShift(Expression<Func<string>> teamId, Expression<Func<string>> shiftId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_shiftId = WorkflowExpression.Compile(shiftId, nameof(shiftId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_shiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsResponse, ApiConnectionActionConfiguration> ListOpenShifts(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListOpenShiftsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShifts", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListOpenShiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse, ApiConnectionActionConfiguration> CreateOpenShift(Expression<Func<string>> teamId, Expression<Func<CreateOpenShiftRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<OpenShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShifts", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<OpenShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse, ApiConnectionActionConfiguration> GetOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_openShiftId = WorkflowExpression.Compile(openShiftId, nameof(openShiftId), required: true);
            return new DeferredBodyAction<OpenShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_openShiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse, ApiConnectionActionConfiguration> UpdateOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId, Expression<Func<CreateOpenShiftRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_openShiftId = WorkflowExpression.Compile(openShiftId, nameof(openShiftId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredBodyAction<OpenShiftResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_openShiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction<OpenShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_openShiftId = WorkflowExpression.Compile(openShiftId, nameof(openShiftId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_openShiftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse, ApiConnectionActionConfiguration> ListTimeOffReasons(Expression<Func<string>> teamId, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetTimeOffReasonsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timeOffReasons", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetTimeOffReasonsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse, ApiConnectionActionConfiguration> ListSchedulingGroups(Expression<Func<string>> teamId, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListSchedulingGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListSchedulingGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SchedulingGroupResponse, ApiConnectionActionConfiguration> GetSchedulingGroup(Expression<Func<string>> teamId, Expression<Func<string>> schedulingGroupId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_schedulingGroupId = WorkflowExpression.Compile(schedulingGroupId, nameof(schedulingGroupId), required: true);
            return new DeferredBodyAction<SchedulingGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_schedulingGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SchedulingGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse, ApiConnectionActionConfiguration> ListTimeOffRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<StateInput>> state = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            return new DeferredBodyAction<ListTimeOffRequestsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<ListTimeOffRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffRequestResponse, ApiConnectionActionConfiguration> GetTimeOffShiftRequest(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_timeOffRequestId = WorkflowExpression.Compile(timeOffRequestId, nameof(timeOffRequestId), required: true);
            return new DeferredBodyAction<TimeOffRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_timeOffRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeOffRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TimeOffRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId, Expression<Func<OpenShiftChangeRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_timeOffRequestId = WorkflowExpression.Compile(timeOffRequestId, nameof(timeOffRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/approve", __workflow_teamId.WithUrlEncoding(1), __workflow_timeOffRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TimeOffRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId, Expression<Func<OpenShiftChangeRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_timeOffRequestId = WorkflowExpression.Compile(timeOffRequestId, nameof(timeOffRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/decline", __workflow_teamId.WithUrlEncoding(1), __workflow_timeOffRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse, ApiConnectionActionConfiguration> ListOfferShiftRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<StateInput>> state = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            return new DeferredBodyAction<ListOfferShiftRequestsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<ListOfferShiftRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OfferShiftRequestResponse, ApiConnectionActionConfiguration> GetOfferShiftRequest(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_offerShiftRequestId = WorkflowExpression.Compile(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            return new DeferredBodyAction<OfferShiftRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_offerShiftRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfferShiftRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OfferShiftRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId, Expression<Func<OfferShiftRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_offerShiftRequestId = WorkflowExpression.Compile(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/approve", __workflow_teamId.WithUrlEncoding(1), __workflow_offerShiftRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OfferShiftRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId, Expression<Func<OfferShiftRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_offerShiftRequestId = WorkflowExpression.Compile(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/decline", __workflow_teamId.WithUrlEncoding(1), __workflow_offerShiftRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse, ApiConnectionActionConfiguration> ListSwapShiftsChangeRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<StateInput>> state = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            return new DeferredBodyAction<ListSwapShiftsChangeRequestsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<ListSwapShiftsChangeRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse, ApiConnectionActionConfiguration> GetSwapShiftsChangeRequest(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_swapShiftsChangeRequestId = WorkflowExpression.Compile(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            return new DeferredBodyAction<SwapShiftsChangeRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_swapShiftsChangeRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SwapShiftsChangeRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SwapShiftsChangeRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId, Expression<Func<OfferShiftRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_swapShiftsChangeRequestId = WorkflowExpression.Compile(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/approve", __workflow_teamId.WithUrlEncoding(1), __workflow_swapShiftsChangeRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SwapShiftsChangeRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId, Expression<Func<OfferShiftRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_swapShiftsChangeRequestId = WorkflowExpression.Compile(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/decline", __workflow_teamId.WithUrlEncoding(1), __workflow_swapShiftsChangeRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse, ApiConnectionActionConfiguration> ListOpenShiftChangeRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<StateInput>> state = null)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            return new DeferredBodyAction<ListOpenShiftChangeRequestsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<ListOpenShiftChangeRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse, ApiConnectionActionConfiguration> GetOpenShiftChangeRequest(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_openShiftChangeRequestId = WorkflowExpression.Compile(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            return new DeferredBodyAction<OpenShiftChangeRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}", __workflow_teamId.WithUrlEncoding(1), __workflow_openShiftChangeRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenShiftChangeRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OpenShiftChangeRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId, Expression<Func<OpenShiftChangeRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_openShiftChangeRequestId = WorkflowExpression.Compile(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/approve", __workflow_teamId.WithUrlEncoding(1), __workflow_openShiftChangeRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OpenShiftChangeRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId, Expression<Func<OpenShiftChangeRequestApproveRequestInput>> request)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            var __workflow_openShiftChangeRequestId = WorkflowExpression.Compile(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/decline", __workflow_teamId.WithUrlEncoding(1), __workflow_openShiftChangeRequestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse, ApiConnectionActionConfiguration> ListOpenShiftsCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListOpenShiftsCrossTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/me/joinedTeams/getOpenShifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListOpenShiftsCrossTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse, ApiConnectionActionConfiguration> ListShiftsCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> assignedToUserName = null, Expression<Func<int>> top = null)
        {
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_assignedToUserName = WorkflowExpression.Compile(assignedToUserName, nameof(assignedToUserName), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListShiftsCrossTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/me/joinedTeams/getShifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_assignedToUserName != null)
                    callPayload.Queries["assignedToUserName"] = ExpressionConverter.Convert(__workflow_assignedToUserName);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListShiftsCrossTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse, ApiConnectionActionConfiguration> ListTimesOffCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> assignedToUserName = null, Expression<Func<int>> top = null)
        {
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: false);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: false);
            var __workflow_assignedToUserName = WorkflowExpression.Compile(assignedToUserName, nameof(assignedToUserName), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ListTimesOffCrossTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/me/joinedTeams/getTimesOff";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                if (__workflow_endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_assignedToUserName != null)
                    callPayload.Queries["assignedToUserName"] = ExpressionConverter.Convert(__workflow_assignedToUserName);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListTimesOffCrossTeamResponse>(callPayload);
            });
        }
    }

    public class ShiftsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerForOpenShiftChangeRequests(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/teams/{0}/openshiftchangerequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new TriggerForOfferShiftRequestsRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerForSwapShiftsChangeRequests(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/teams/{0}/swapshiftschangerequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new TriggerForOfferShiftRequestsRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerForOfferShiftRequests(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/teams/{0}/offershiftrequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new TriggerForOfferShiftRequestsRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerForTimeOffRequests(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/teams/{0}/timeoffrequests", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new TriggerForOfferShiftRequestsRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> TriggerForShifts(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = WorkflowExpression.Compile(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/teams/{0}/shifts", __workflow_teamId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new TriggerForOfferShiftRequestsRequestInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class ScheduleResponse
    {
        [JsonProperty("id")]
        public string ScheduleId { get; set; }

        [JsonProperty("timeZone")]
        public string ScheduleTimeZone { get; set; }

        [JsonProperty("provisionStatus")]
        public string ScheduleProvisionStatus { get; set; }

        [JsonProperty("provisionStatusCode")]
        public string ScheduleProvisionStatusCode { get; set; }
    }

    public class ListTimesOffResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public TimeOffResponse[] TimeOffInstancesList { get; set; }
    }

    public class TimeOffResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("userId")]
        public string AssignedToUserId { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("teamInfo")]
        public TeamInfo TeamInfo { get; set; }

        [JsonProperty("sharedTimeOff")]
        public SharedTimeOff SharedTimeOff { get; set; }

        [JsonProperty("draftTimeOff")]
        public DraftTimeOff DraftTimeOff { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class TeamInfo
    {
        [JsonProperty("teamId")]
        public string TeamId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class SharedTimeOff
    {
        [JsonProperty("timeOffReasonId")]
        public string TimeOffReasonId { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public CreateOpenShiftThemeResponse Theme { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOpenShiftThemeResponse
    {
        [EnumMember(Value = "white")]
        White,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "gray")]
        Gray,
        [EnumMember(Value = "darkBlue")]
        DarkBlue,
        [EnumMember(Value = "darkGreen")]
        DarkGreen,
        [EnumMember(Value = "darkPurple")]
        DarkPurple,
        [EnumMember(Value = "darkPink")]
        DarkPink,
        [EnumMember(Value = "darkYellow")]
        DarkYellow
    }

    public class DraftTimeOff
    {
        [JsonProperty("timeOffReasonId")]
        public string TimeOffReasonId { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public CreateOpenShiftThemeResponse Theme { get; set; }
    }

    public class CreateTimeOffRequestInput
    {
        public CreateTimeOffRequestInput(CreateTimeOffRequestInputValueType value, string userId)
        {
            this.Value = value;
            this.UserId = userId;
        }

        [JsonProperty("sharedTimeOff", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTimeOffRequestInputValueType Value { get; set; }

        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }
    }

    public class CreateTimeOffRequestInputValueType
    {
        public CreateTimeOffRequestInputValueType(string timeOffReason, string startTime, string endTime)
        {
            this.TimeOffReason = timeOffReason;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        [JsonProperty("timeOffReasonId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TimeOffReason { get; set; }

        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("theme", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOpenShiftTheme Theme { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Shifts.CreateOpenShiftTheme.White;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateOpenShiftTheme
    {
        [EnumMember(Value = "white")]
        White,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "gray")]
        Gray,
        [EnumMember(Value = "darkBlue")]
        DarkBlue,
        [EnumMember(Value = "darkGreen")]
        DarkGreen,
        [EnumMember(Value = "darkPurple")]
        DarkPurple,
        [EnumMember(Value = "darkPink")]
        DarkPink,
        [EnumMember(Value = "darkYellow")]
        DarkYellow
    }

    public class ListShiftsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public ShiftResponse[] ShiftsList { get; set; }
    }

    public class ShiftResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("userId")]
        public string AssignedToUserId { get; set; }

        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }

        [JsonProperty("schedulingGroupInfo")]
        public SchedulingGroupInfo SchedulingGroupInfo { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("teamInfo")]
        public TeamInfo TeamInfo { get; set; }

        [JsonProperty("sharedShift")]
        public SharedShift SharedShift { get; set; }

        [JsonProperty("draftShift")]
        public DraftShift DraftShift { get; set; }
    }

    public class SchedulingGroupInfo
    {
        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class SharedShift
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public CreateOpenShiftThemeResponse Theme { get; set; }

        [JsonProperty("activities")]
        public CreateOpenShiftActivitiesItemResponse[] Activities { get; set; }
    }

    public class CreateOpenShiftActivitiesItemResponse
    {
        [JsonProperty("isPaid")]
        public bool IsPaid { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class DraftShift
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public CreateOpenShiftThemeResponse Theme { get; set; }

        [JsonProperty("activities")]
        public CreateOpenShiftActivitiesItemResponse[] Activities { get; set; }
    }

    public class CreateShiftRequestInput
    {
        public CreateShiftRequestInput(CreateShiftRequestInputValueType value, string userId)
        {
            this.Value = value;
            this.UserId = userId;
        }

        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }

        [JsonProperty("sharedShift", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateShiftRequestInputValueType Value { get; set; }

        [JsonProperty("userId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }
    }

    public class CreateShiftRequestInputValueType
    {
        public CreateShiftRequestInputValueType(string startTime, string endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("theme", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOpenShiftTheme Theme { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Shifts.CreateOpenShiftTheme.White;

        [JsonProperty("activities")]
        public CreateOpenShiftActivitiesItem[] Activities { get; set; }
    }

    public class CreateOpenShiftActivitiesItem
    {
        public CreateOpenShiftActivitiesItem(string startTime, string endTime)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        [JsonProperty("isPaid")]
        public bool? IsPaid { get; set; }

        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ListOpenShiftsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public OpenShiftResponse[] OpenShiftsList { get; set; }
    }

    public class OpenShiftResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }

        [JsonProperty("schedulingGroupInfo")]
        public SchedulingGroupInfo SchedulingGroupInfo { get; set; }

        [JsonProperty("teamInfo")]
        public TeamInfo TeamInfo { get; set; }

        [JsonProperty("sharedOpenShift")]
        public SharedOpenShift SharedOpenShift { get; set; }

        [JsonProperty("draftOpenShift")]
        public DraftOpenShift DraftOpenShift { get; set; }
    }

    public class SharedOpenShift
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public CreateOpenShiftThemeResponse Theme { get; set; }

        [JsonProperty("openSlotCount")]
        public int OpenSlotCount { get; set; }

        [JsonProperty("activities")]
        public CreateOpenShiftActivitiesItemResponse[] Activities { get; set; }
    }

    public class DraftOpenShift
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public CreateOpenShiftThemeResponse Theme { get; set; }

        [JsonProperty("openSlotCount")]
        public int OpenSlotCount { get; set; }

        [JsonProperty("activities")]
        public CreateOpenShiftActivitiesItemResponse[] Activities { get; set; }
    }

    public class CreateOpenShiftRequestInput
    {
        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupId { get; set; }

        [JsonProperty("sharedOpenShift")]
        public RequestInputSharedOpenShiftType SharedOpenShift { get; set; }
    }

    public class RequestInputSharedOpenShiftType
    {
        public RequestInputSharedOpenShiftType(string startTime, string endTime, int openSlotCount)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.OpenSlotCount = openSlotCount;
        }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("startDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public string EndTime { get; set; }

        [JsonProperty("theme", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateOpenShiftTheme? Theme { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Shifts.CreateOpenShiftTheme.White;

        [JsonProperty("openSlotCount", DefaultValueHandling = DefaultValueHandling.Include)]
        public int OpenSlotCount { get; set; }

        [JsonProperty("activities")]
        public CreateOpenShiftActivitiesItem[] Activities { get; set; }
    }

    public class GetTimeOffReasonsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetTimeOffReasonsResponseArrayContainingTimeOffReasonsTypeItem[] ArrayContainingTimeOffReasons { get; set; }
    }

    public class GetTimeOffReasonsResponseArrayContainingTimeOffReasonsTypeItem
    {
        [JsonProperty("id")]
        public string TimeOffReasonId { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("iconType")]
        public string IconType { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

    public class ListSchedulingGroupsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public SchedulingGroupResponse[] SchedulingGroupsList { get; set; }
    }

    public class SchedulingGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("userIds")]
        public string[] UserIDs { get; set; }
    }

    public class ListTimeOffRequestsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public TimeOffRequestResponse[] TimeOffRequestsList { get; set; }
    }

    public class TimeOffRequestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedTime { get; set; }

        [JsonProperty("assignedTo")]
        public TimeOffRequestResponseAssignedToType AssignedTo { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("senderDateTime")]
        public string SenderTime { get; set; }

        [JsonProperty("senderMessage")]
        public string SenderMessage { get; set; }

        [JsonProperty("senderUserId")]
        public string SenderId { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerId { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("timeOffReasonId")]
        public string TimeOffReasonId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeOffRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StateInput
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "declined")]
        Declined
    }

    public class OpenShiftChangeRequestApproveRequestInput
    {
        [JsonProperty("message")]
        public string MessageFromManager { get; set; }
    }

    public class ListOfferShiftRequestsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public OfferShiftRequestResponse[] OfferShiftRequestsList { get; set; }
    }

    public class OfferShiftRequestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedTime { get; set; }

        [JsonProperty("assignedTo")]
        public OfferShiftRequestResponseAssignedToType AssignedTo { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("senderDateTime")]
        public string SenderTime { get; set; }

        [JsonProperty("senderMessage")]
        public string SenderMessage { get; set; }

        [JsonProperty("senderUserId")]
        public string SenderId { get; set; }

        [JsonProperty("senderShiftId")]
        public string SenderShiftId { get; set; }

        [JsonProperty("recipientActionDateTime")]
        public string ReceiverTime { get; set; }

        [JsonProperty("recipientActionMessage")]
        public string RecipientMessage { get; set; }

        [JsonProperty("recipientUserId")]
        public string RecipientId { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfferShiftRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
    }

    public class OfferShiftRequestApproveRequestInput
    {
        [JsonProperty("message")]
        public string MessageFromRecipientManager { get; set; }
    }

    public class ListSwapShiftsChangeRequestsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public SwapShiftsChangeRequestResponse[] SwapShiftsChangeRequestsList { get; set; }
    }

    public class SwapShiftsChangeRequestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedTime { get; set; }

        [JsonProperty("assignedTo")]
        public SwapShiftsChangeRequestResponseAssignedToType AssignedTo { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("senderDateTime")]
        public string SenderTime { get; set; }

        [JsonProperty("senderMessage")]
        public string SenderMessage { get; set; }

        [JsonProperty("senderUserId")]
        public string SenderId { get; set; }

        [JsonProperty("senderShiftId")]
        public string SenderShiftId { get; set; }

        [JsonProperty("recipientActionDateTime")]
        public string ReceiverTime { get; set; }

        [JsonProperty("recipientActionMessage")]
        public string RecipientMessage { get; set; }

        [JsonProperty("recipientUserId")]
        public string RecipientId { get; set; }

        [JsonProperty("recipientShiftId")]
        public string RecipientShiftId { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SwapShiftsChangeRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
    }

    public class ListOpenShiftChangeRequestsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public OpenShiftChangeRequestResponse[] OpenShiftChangeRequestsList { get; set; }
    }

    public class OpenShiftChangeRequestResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedTime { get; set; }

        [JsonProperty("assignedTo")]
        public OpenShiftChangeRequestResponseAssignedToType AssignedTo { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("senderDateTime")]
        public string SenderTime { get; set; }

        [JsonProperty("senderMessage")]
        public string SenderMessage { get; set; }

        [JsonProperty("senderUserId")]
        public string SenderId { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerId { get; set; }

        [JsonProperty("openShiftId")]
        public string OpenShiftId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenShiftChangeRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
    }

    public class ListOpenShiftsCrossTeamResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public OpenShiftResponse[] OpenShiftsList { get; set; }
    }

    public class ListShiftsCrossTeamResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public ShiftResponse[] ShiftsList { get; set; }
    }

    public class ListTimesOffCrossTeamResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public TimeOffResponse[] TimesOffList { get; set; }
    }

    public class TriggerForOfferShiftRequestsRequestInput
    {
        [JsonProperty("notificationUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shifts;

    public partial class WorkflowManagedActions
    {
        public ShiftsActions Shifts(string connectionId) => new ShiftsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShiftsTriggers Shifts(string connectionId) => new ShiftsTriggers(connectionId);
    }
}