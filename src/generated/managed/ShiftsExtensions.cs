//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shifts
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShiftsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ScheduleResponse> GetSchedule(Expression<Func<string>> teamId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ScheduleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffResponse> ListTimesOff(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timesoff", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListTimesOffResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffResponse> GetTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> timeOffId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timesoff/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TimeOffResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> timeOffId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timesoff/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsResponse> ListShifts(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/shifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListShiftsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ShiftResponse> GetShift(Expression<Func<string>> teamId, Expression<Func<string>> shiftId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/shifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(shiftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShiftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteShift(Expression<Func<string>> teamId, Expression<Func<string>> shiftId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/shifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(shiftId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsResponse> ListOpenShifts(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListOpenShiftsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> CreateOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> requestsharedOpenShiftstartTime, Expression<Func<string>> requestsharedOpenShiftendTime, Expression<Func<int>> requestsharedOpenShiftopenSlotCount, Expression<Func<string>> requestschedulingGroupID = null, Expression<Func<string>> requestsharedOpenShiftdisplayName = null, Expression<Func<string>> requestsharedOpenShiftnotes = null, Expression<Func<requestsharedOpenShiftthemeInput>> requestsharedOpenShifttheme = null, Expression<Func<requestsharedOpenShiftactivitiesInputItem[]>> requestsharedOpenShiftactivities = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestschedulingGroupID != null)
            {
                request["schedulingGroupId"] = ExpressionConverter.ConvertO(requestschedulingGroupID);
                requestpropCount++;
            }

            var sharedOpenShiftObject = new JObject();
            var sharedOpenShiftObjectpropCount = 0;
            if (requestsharedOpenShiftdisplayName != null)
            {
                sharedOpenShiftObject["displayName"] = ExpressionConverter.ConvertO(requestsharedOpenShiftdisplayName);
                sharedOpenShiftObjectpropCount++;
            }

            if (requestsharedOpenShiftnotes != null)
            {
                sharedOpenShiftObject["notes"] = ExpressionConverter.ConvertO(requestsharedOpenShiftnotes);
                sharedOpenShiftObjectpropCount++;
            }

            sharedOpenShiftObjectpropCount++;
            sharedOpenShiftObject["startDateTime"] = ExpressionConverter.ConvertO(requestsharedOpenShiftstartTime);
            sharedOpenShiftObjectpropCount++;
            sharedOpenShiftObject["endDateTime"] = ExpressionConverter.ConvertO(requestsharedOpenShiftendTime);
            if (requestsharedOpenShifttheme != null)
            {
                sharedOpenShiftObject["theme"] = ExpressionConverter.ConvertO(requestsharedOpenShifttheme);
                sharedOpenShiftObjectpropCount++;
            }

            sharedOpenShiftObjectpropCount++;
            sharedOpenShiftObject["openSlotCount"] = ExpressionConverter.ConvertO(requestsharedOpenShiftopenSlotCount);
            if (requestsharedOpenShiftactivities != null)
            {
                sharedOpenShiftObject["activities"] = ExpressionConverter.ConvertO(requestsharedOpenShiftactivities);
                sharedOpenShiftObjectpropCount++;
            }

            if (sharedOpenShiftObjectpropCount > 0)
            {
                request["sharedOpenShift"] = sharedOpenShiftObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<OpenShiftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> GetOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpenShiftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> UpdateOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId, Expression<Func<string>> requestsharedOpenShiftstartTime, Expression<Func<string>> requestsharedOpenShiftendTime, Expression<Func<int>> requestsharedOpenShiftopenSlotCount, Expression<Func<string>> requestschedulingGroupID = null, Expression<Func<string>> requestsharedOpenShiftdisplayName = null, Expression<Func<string>> requestsharedOpenShiftnotes = null, Expression<Func<requestsharedOpenShiftthemeInput>> requestsharedOpenShifttheme = null, Expression<Func<requestsharedOpenShiftactivitiesInputItem[]>> requestsharedOpenShiftactivities = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestschedulingGroupID != null)
            {
                request["schedulingGroupId"] = ExpressionConverter.ConvertO(requestschedulingGroupID);
                requestpropCount++;
            }

            var sharedOpenShiftObject = new JObject();
            var sharedOpenShiftObjectpropCount = 0;
            if (requestsharedOpenShiftdisplayName != null)
            {
                sharedOpenShiftObject["displayName"] = ExpressionConverter.ConvertO(requestsharedOpenShiftdisplayName);
                sharedOpenShiftObjectpropCount++;
            }

            if (requestsharedOpenShiftnotes != null)
            {
                sharedOpenShiftObject["notes"] = ExpressionConverter.ConvertO(requestsharedOpenShiftnotes);
                sharedOpenShiftObjectpropCount++;
            }

            sharedOpenShiftObjectpropCount++;
            sharedOpenShiftObject["startDateTime"] = ExpressionConverter.ConvertO(requestsharedOpenShiftstartTime);
            sharedOpenShiftObjectpropCount++;
            sharedOpenShiftObject["endDateTime"] = ExpressionConverter.ConvertO(requestsharedOpenShiftendTime);
            if (requestsharedOpenShifttheme != null)
            {
                sharedOpenShiftObject["theme"] = ExpressionConverter.ConvertO(requestsharedOpenShifttheme);
                sharedOpenShiftObjectpropCount++;
            }

            sharedOpenShiftObjectpropCount++;
            sharedOpenShiftObject["openSlotCount"] = ExpressionConverter.ConvertO(requestsharedOpenShiftopenSlotCount);
            if (requestsharedOpenShiftactivities != null)
            {
                sharedOpenShiftObject["activities"] = ExpressionConverter.ConvertO(requestsharedOpenShiftactivities);
                sharedOpenShiftObjectpropCount++;
            }

            if (sharedOpenShiftObjectpropCount > 0)
            {
                request["sharedOpenShift"] = sharedOpenShiftObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<OpenShiftResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse> ListTimeOffReasons(Expression<Func<string>> teamId, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timeOffReasons", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<GetTimeOffReasonsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse> ListSchedulingGroups(Expression<Func<string>> teamId, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/schedulinggroups", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListSchedulingGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SchedulingGroupResponse> GetSchedulingGroup(Expression<Func<string>> teamId, Expression<Func<string>> schedulingGroupId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/schedulinggroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(schedulingGroupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SchedulingGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse> ListTimeOffRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timeOffRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            return new ApiConnectionAction<ListTimeOffRequestsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffRequestResponse> GetTimeOffShiftRequest(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timeOffRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffRequestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TimeOffRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction TimeOffRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction TimeOffRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse> ListOfferShiftRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/offerShiftRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            return new ApiConnectionAction<ListOfferShiftRequestsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OfferShiftRequestResponse> GetOfferShiftRequest(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(offerShiftRequestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OfferShiftRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OfferShiftRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(offerShiftRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromRecipientManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromRecipientManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OfferShiftRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(offerShiftRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromRecipientManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromRecipientManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse> ListSwapShiftsChangeRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            return new ApiConnectionAction<ListSwapShiftsChangeRequestsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse> GetSwapShiftsChangeRequest(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(swapShiftsChangeRequestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SwapShiftsChangeRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction SwapShiftsChangeRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(swapShiftsChangeRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromRecipientManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromRecipientManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction SwapShiftsChangeRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(swapShiftsChangeRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromRecipientManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromRecipientManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse> ListOpenShiftChangeRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShiftChangeRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (state != null)
                callPayload.Queries["state"] = ExpressionConverter.Convert(state);
            return new ApiConnectionAction<ListOpenShiftChangeRequestsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse> GetOpenShiftChangeRequest(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftChangeRequestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OpenShiftChangeRequestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OpenShiftChangeRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftChangeRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OpenShiftChangeRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var apiCallPath = String.Format("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftChangeRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            if (requestmessageFromManager != null)
            {
                request["message"] = ExpressionConverter.ConvertO(requestmessageFromManager);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse> ListOpenShiftsCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/beta/me/joinedTeams/getOpenShifts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListOpenShiftsCrossTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse> ListShiftsCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> assignedToUserName = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/beta/me/joinedTeams/getShifts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            if (assignedToUserName != null)
                callPayload.Queries["assignedToUserName"] = ExpressionConverter.Convert(assignedToUserName);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListShiftsCrossTeamResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse> ListTimesOffCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> assignedToUserName = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/beta/me/joinedTeams/getTimesOff";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (startTime != null)
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
            if (endTime != null)
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
            if (assignedToUserName != null)
                callPayload.Queries["assignedToUserName"] = ExpressionConverter.Convert(assignedToUserName);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ListTimesOffCrossTeamResponse>(callPayload);
        }
    }

    public class ShiftsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerForOpenShiftChangeRequests(Expression<Func<string>> teamId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/teams/{0}/openshiftchangerequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["notificationUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TriggerForSwapShiftsChangeRequests(Expression<Func<string>> teamId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/teams/{0}/swapshiftschangerequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["notificationUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TriggerForOfferShiftRequests(Expression<Func<string>> teamId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/teams/{0}/offershiftrequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["notificationUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TriggerForTimeOffRequests(Expression<Func<string>> teamId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/teams/{0}/timeoffrequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["notificationUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger TriggerForShifts(Expression<Func<string>> teamId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/teams/{0}/shifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["notificationUrl"] = "@listcallbackurl()";
            requestpropCount++;
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class ScheduleResponse
    {
        [JsonProperty("id")]
        public string ScheduleID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("userId")]
        public string AssignedToUserID { get; set; }

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
        public string TimeOffReasonID { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public Theme Theme { get; set; }
    }

    public enum Theme
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
        public string TimeOffReasonID { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("theme")]
        public Theme Theme { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("userId")]
        public string AssignedToUserID { get; set; }

        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupID { get; set; }

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
        public Theme Theme { get; set; }

        [JsonProperty("activities")]
        public ActivitiesItem[] Activities { get; set; }
    }

    public class ActivitiesItem
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
        public Theme Theme { get; set; }

        [JsonProperty("activities")]
        public ActivitiesItem[] Activities { get; set; }
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
        public string ID { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [JsonProperty("schedulingGroupId")]
        public string SchedulingGroupID { get; set; }

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
        public Theme Theme { get; set; }

        [JsonProperty("openSlotCount")]
        public int OpenSlotCount { get; set; }

        [JsonProperty("activities")]
        public ActivitiesItem[] Activities { get; set; }
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
        public Theme Theme { get; set; }

        [JsonProperty("openSlotCount")]
        public int OpenSlotCount { get; set; }

        [JsonProperty("activities")]
        public ActivitiesItem[] Activities { get; set; }
    }

    public enum requestsharedOpenShiftthemeInput
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

    public class requestsharedOpenShiftactivitiesInputItem
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
        public string TimeOffReasonID { get; set; }

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
        public string ID { get; set; }

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
        public string ID { get; set; }

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
        public string SenderID { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerID { get; set; }

        [JsonProperty("startDateTime")]
        public string StartTime { get; set; }

        [JsonProperty("endDateTime")]
        public string EndTime { get; set; }

        [JsonProperty("timeOffReasonId")]
        public string TimeOffReasonID { get; set; }
    }

    public enum TimeOffRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
    }

    public enum stateInput
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "approved")]
        Approved,
        [EnumMember(Value = "declined")]
        Declined
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
        public string ID { get; set; }

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
        public string SenderID { get; set; }

        [JsonProperty("senderShiftId")]
        public string SenderShiftID { get; set; }

        [JsonProperty("recipientActionDateTime")]
        public string ReceiverTime { get; set; }

        [JsonProperty("recipientActionMessage")]
        public string RecipientMessage { get; set; }

        [JsonProperty("recipientUserId")]
        public string RecipientID { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerID { get; set; }
    }

    public enum OfferShiftRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
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
        public string ID { get; set; }

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
        public string SenderID { get; set; }

        [JsonProperty("senderShiftId")]
        public string SenderShiftID { get; set; }

        [JsonProperty("recipientActionDateTime")]
        public string ReceiverTime { get; set; }

        [JsonProperty("recipientActionMessage")]
        public string RecipientMessage { get; set; }

        [JsonProperty("recipientUserId")]
        public string RecipientID { get; set; }

        [JsonProperty("recipientShiftId")]
        public string RecipientShiftID { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerID { get; set; }
    }

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
        public string ID { get; set; }

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
        public string SenderID { get; set; }

        [JsonProperty("managerActionDateTime")]
        public string ManagerActionTime { get; set; }

        [JsonProperty("managerActionMessage")]
        public string ManagerMessage { get; set; }

        [JsonProperty("managerUserId")]
        public string ManagerID { get; set; }

        [JsonProperty("openShiftId")]
        public string OpenShiftID { get; set; }
    }

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