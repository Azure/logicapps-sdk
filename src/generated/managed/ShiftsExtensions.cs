//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shifts
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ShiftsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ScheduleResponse> GetSchedule(Expression<Func<string>> teamId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<ScheduleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ScheduleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffResponse> ListTimesOff(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_startTime = startTime == null ? null : WorkflowExpression.Compile(startTime);
            WorkflowExpression.Validate(__workflow_startTime, nameof(startTime), required: false);
            var __workflow_endTime = endTime == null ? null : WorkflowExpression.Compile(endTime);
            WorkflowExpression.Validate(__workflow_endTime, nameof(endTime), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListTimesOffResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<TimeOffResponse> CreateTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> requestuserID, Expression<Func<string>> requestvaluetimeOffReason = null, Expression<Func<string>> requestvaluestartTime = null, Expression<Func<string>> requestvalueendTime = null, Expression<Func<requestvaluethemeInput>> requestvaluetheme = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_requestuserID = requestuserID == null ? null : WorkflowExpression.Compile(requestuserID);
            WorkflowExpression.Validate(__workflow_requestuserID, nameof(requestuserID), required: true);
            var __workflow_requestvaluetimeOffReason = requestvaluetimeOffReason == null ? null : WorkflowExpression.Compile(requestvaluetimeOffReason);
            WorkflowExpression.Validate(__workflow_requestvaluetimeOffReason, nameof(requestvaluetimeOffReason), required: false);
            var __workflow_requestvaluestartTime = requestvaluestartTime == null ? null : WorkflowExpression.Compile(requestvaluestartTime);
            WorkflowExpression.Validate(__workflow_requestvaluestartTime, nameof(requestvaluestartTime), required: false);
            var __workflow_requestvalueendTime = requestvalueendTime == null ? null : WorkflowExpression.Compile(requestvalueendTime);
            WorkflowExpression.Validate(__workflow_requestvalueendTime, nameof(requestvalueendTime), required: false);
            var __workflow_requestvaluetheme = requestvaluetheme == null ? null : WorkflowExpression.Compile(requestvaluetheme);
            WorkflowExpression.Validate(__workflow_requestvaluetheme, nameof(requestvaluetheme), required: false);
            return new DeferredBodyAction<TimeOffResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var sharedTimeOffObject = new JObject();
                var sharedTimeOffObjectpropCount = 0;
                if (__workflow_requestvaluetimeOffReason != null)
                {
                    sharedTimeOffObject["timeOffReasonId"] = ExpressionConverter.ConvertO(__workflow_requestvaluetimeOffReason);
                    sharedTimeOffObjectpropCount++;
                }

                if (__workflow_requestvaluestartTime != null)
                {
                    sharedTimeOffObject["startDateTime"] = ExpressionConverter.ConvertO(__workflow_requestvaluestartTime);
                    sharedTimeOffObjectpropCount++;
                }

                if (__workflow_requestvalueendTime != null)
                {
                    sharedTimeOffObject["endDateTime"] = ExpressionConverter.ConvertO(__workflow_requestvalueendTime);
                    sharedTimeOffObjectpropCount++;
                }

                if (__workflow_requestvaluetheme != null)
                {
                    if (__workflow_requestvaluetheme != null)
                    {
                        sharedTimeOffObject["theme"] = ExpressionConverter.ConvertO(__workflow_requestvaluetheme);
                        sharedTimeOffObjectpropCount++;
                    }

                    sharedTimeOffObjectpropCount++;
                }
                else
                {
                    sharedTimeOffObject["theme"] = "white";
                    sharedTimeOffObjectpropCount++;
                }

                if (sharedTimeOffObjectpropCount > 0)
                {
                    request["sharedTimeOff"] = sharedTimeOffObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["userId"] = ExpressionConverter.ConvertO(__workflow_requestuserID);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<TimeOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffResponse> GetTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> timeOffId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_timeOffId = timeOffId == null ? null : WorkflowExpression.Compile(timeOffId);
            WorkflowExpression.Validate(__workflow_timeOffId, nameof(timeOffId), required: true);
            return new DeferredBodyAction<TimeOffResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_timeOffId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteTimeOff(Expression<Func<string>> teamId, Expression<Func<string>> timeOffId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_timeOffId = timeOffId == null ? null : WorkflowExpression.Compile(timeOffId);
            WorkflowExpression.Validate(__workflow_timeOffId, nameof(timeOffId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_timeOffId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsResponse> ListShifts(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_startTime = startTime == null ? null : WorkflowExpression.Compile(startTime);
            WorkflowExpression.Validate(__workflow_startTime, nameof(startTime), required: false);
            var __workflow_endTime = endTime == null ? null : WorkflowExpression.Compile(endTime);
            WorkflowExpression.Validate(__workflow_endTime, nameof(endTime), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListShiftsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<ShiftResponse> CreateShift(Expression<Func<string>> teamId, Expression<Func<string>> requestuserID, Expression<Func<string>> requestschedulingGroupID = null, Expression<Func<string>> requestvaluedisplayName = null, Expression<Func<string>> requestvaluenotes = null, Expression<Func<string>> requestvaluestartTime = null, Expression<Func<string>> requestvalueendTime = null, Expression<Func<requestvaluethemeInput>> requestvaluetheme = null, Expression<Func<requestvalueactivitiesInputItem[]>> requestvalueactivities = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_requestuserID = requestuserID == null ? null : WorkflowExpression.Compile(requestuserID);
            WorkflowExpression.Validate(__workflow_requestuserID, nameof(requestuserID), required: true);
            var __workflow_requestschedulingGroupID = requestschedulingGroupID == null ? null : WorkflowExpression.Compile(requestschedulingGroupID);
            WorkflowExpression.Validate(__workflow_requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            var __workflow_requestvaluedisplayName = requestvaluedisplayName == null ? null : WorkflowExpression.Compile(requestvaluedisplayName);
            WorkflowExpression.Validate(__workflow_requestvaluedisplayName, nameof(requestvaluedisplayName), required: false);
            var __workflow_requestvaluenotes = requestvaluenotes == null ? null : WorkflowExpression.Compile(requestvaluenotes);
            WorkflowExpression.Validate(__workflow_requestvaluenotes, nameof(requestvaluenotes), required: false);
            var __workflow_requestvaluestartTime = requestvaluestartTime == null ? null : WorkflowExpression.Compile(requestvaluestartTime);
            WorkflowExpression.Validate(__workflow_requestvaluestartTime, nameof(requestvaluestartTime), required: false);
            var __workflow_requestvalueendTime = requestvalueendTime == null ? null : WorkflowExpression.Compile(requestvalueendTime);
            WorkflowExpression.Validate(__workflow_requestvalueendTime, nameof(requestvalueendTime), required: false);
            var __workflow_requestvaluetheme = requestvaluetheme == null ? null : WorkflowExpression.Compile(requestvaluetheme);
            WorkflowExpression.Validate(__workflow_requestvaluetheme, nameof(requestvaluetheme), required: false);
            var __workflow_requestvalueactivities = requestvalueactivities == null ? null : WorkflowExpression.Compile(requestvalueactivities);
            WorkflowExpression.Validate(__workflow_requestvalueactivities, nameof(requestvalueactivities), required: false);
            return new DeferredBodyAction<ShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestschedulingGroupID != null)
                {
                    request["schedulingGroupId"] = ExpressionConverter.ConvertO(__workflow_requestschedulingGroupID);
                    requestpropCount++;
                }

                var sharedShiftObject = new JObject();
                var sharedShiftObjectpropCount = 0;
                if (__workflow_requestvaluedisplayName != null)
                {
                    sharedShiftObject["displayName"] = ExpressionConverter.ConvertO(__workflow_requestvaluedisplayName);
                    sharedShiftObjectpropCount++;
                }

                if (__workflow_requestvaluenotes != null)
                {
                    sharedShiftObject["notes"] = ExpressionConverter.ConvertO(__workflow_requestvaluenotes);
                    sharedShiftObjectpropCount++;
                }

                if (__workflow_requestvaluestartTime != null)
                {
                    sharedShiftObject["startDateTime"] = ExpressionConverter.ConvertO(__workflow_requestvaluestartTime);
                    sharedShiftObjectpropCount++;
                }

                if (__workflow_requestvalueendTime != null)
                {
                    sharedShiftObject["endDateTime"] = ExpressionConverter.ConvertO(__workflow_requestvalueendTime);
                    sharedShiftObjectpropCount++;
                }

                if (__workflow_requestvaluetheme != null)
                {
                    if (__workflow_requestvaluetheme != null)
                    {
                        sharedShiftObject["theme"] = ExpressionConverter.ConvertO(__workflow_requestvaluetheme);
                        sharedShiftObjectpropCount++;
                    }

                    sharedShiftObjectpropCount++;
                }
                else
                {
                    sharedShiftObject["theme"] = "white";
                    sharedShiftObjectpropCount++;
                }

                if (__workflow_requestvalueactivities != null)
                {
                    sharedShiftObject["activities"] = ExpressionConverter.ConvertO(__workflow_requestvalueactivities);
                    sharedShiftObjectpropCount++;
                }

                if (sharedShiftObjectpropCount > 0)
                {
                    request["sharedShift"] = sharedShiftObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["userId"] = ExpressionConverter.ConvertO(__workflow_requestuserID);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ShiftResponse> GetShift(Expression<Func<string>> teamId, Expression<Func<string>> shiftId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_shiftId = shiftId == null ? null : WorkflowExpression.Compile(shiftId);
            WorkflowExpression.Validate(__workflow_shiftId, nameof(shiftId), required: true);
            return new DeferredBodyAction<ShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_shiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteShift(Expression<Func<string>> teamId, Expression<Func<string>> shiftId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_shiftId = shiftId == null ? null : WorkflowExpression.Compile(shiftId);
            WorkflowExpression.Validate(__workflow_shiftId, nameof(shiftId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_shiftId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsResponse> ListOpenShifts(Expression<Func<string>> teamId, Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_startTime = startTime == null ? null : WorkflowExpression.Compile(startTime);
            WorkflowExpression.Validate(__workflow_startTime, nameof(startTime), required: false);
            var __workflow_endTime = endTime == null ? null : WorkflowExpression.Compile(endTime);
            WorkflowExpression.Validate(__workflow_endTime, nameof(endTime), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListOpenShiftsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<OpenShiftResponse> CreateOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> requestsharedOpenShiftstartTime, Expression<Func<string>> requestsharedOpenShiftendTime, Expression<Func<int>> requestsharedOpenShiftopenSlotCount, Expression<Func<string>> requestschedulingGroupID = null, Expression<Func<string>> requestsharedOpenShiftdisplayName = null, Expression<Func<string>> requestsharedOpenShiftnotes = null, Expression<Func<requestsharedOpenShiftthemeInput>> requestsharedOpenShifttheme = null, Expression<Func<requestsharedOpenShiftactivitiesInputItem[]>> requestsharedOpenShiftactivities = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_requestsharedOpenShiftstartTime = requestsharedOpenShiftstartTime == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftstartTime);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftstartTime, nameof(requestsharedOpenShiftstartTime), required: true);
            var __workflow_requestsharedOpenShiftendTime = requestsharedOpenShiftendTime == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftendTime);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftendTime, nameof(requestsharedOpenShiftendTime), required: true);
            var __workflow_requestsharedOpenShiftopenSlotCount = requestsharedOpenShiftopenSlotCount == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftopenSlotCount);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftopenSlotCount, nameof(requestsharedOpenShiftopenSlotCount), required: true);
            var __workflow_requestschedulingGroupID = requestschedulingGroupID == null ? null : WorkflowExpression.Compile(requestschedulingGroupID);
            WorkflowExpression.Validate(__workflow_requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            var __workflow_requestsharedOpenShiftdisplayName = requestsharedOpenShiftdisplayName == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftdisplayName);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftdisplayName, nameof(requestsharedOpenShiftdisplayName), required: false);
            var __workflow_requestsharedOpenShiftnotes = requestsharedOpenShiftnotes == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftnotes);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftnotes, nameof(requestsharedOpenShiftnotes), required: false);
            var __workflow_requestsharedOpenShifttheme = requestsharedOpenShifttheme == null ? null : WorkflowExpression.Compile(requestsharedOpenShifttheme);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShifttheme, nameof(requestsharedOpenShifttheme), required: false);
            var __workflow_requestsharedOpenShiftactivities = requestsharedOpenShiftactivities == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftactivities);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftactivities, nameof(requestsharedOpenShiftactivities), required: false);
            return new DeferredBodyAction<OpenShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestschedulingGroupID != null)
                {
                    request["schedulingGroupId"] = ExpressionConverter.ConvertO(__workflow_requestschedulingGroupID);
                    requestpropCount++;
                }

                var sharedOpenShiftObject = new JObject();
                var sharedOpenShiftObjectpropCount = 0;
                if (__workflow_requestsharedOpenShiftdisplayName != null)
                {
                    sharedOpenShiftObject["displayName"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftdisplayName);
                    sharedOpenShiftObjectpropCount++;
                }

                if (__workflow_requestsharedOpenShiftnotes != null)
                {
                    sharedOpenShiftObject["notes"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftnotes);
                    sharedOpenShiftObjectpropCount++;
                }

                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["startDateTime"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftstartTime);
                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["endDateTime"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftendTime);
                if (__workflow_requestsharedOpenShifttheme != null)
                {
                    if (__workflow_requestsharedOpenShifttheme != null)
                    {
                        sharedOpenShiftObject["theme"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShifttheme);
                        sharedOpenShiftObjectpropCount++;
                    }

                    sharedOpenShiftObjectpropCount++;
                }
                else
                {
                    sharedOpenShiftObject["theme"] = "white";
                    sharedOpenShiftObjectpropCount++;
                }

                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["openSlotCount"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftopenSlotCount);
                if (__workflow_requestsharedOpenShiftactivities != null)
                {
                    sharedOpenShiftObject["activities"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftactivities);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> GetOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_openShiftId = openShiftId == null ? null : WorkflowExpression.Compile(openShiftId);
            WorkflowExpression.Validate(__workflow_openShiftId, nameof(openShiftId), required: true);
            return new DeferredBodyAction<OpenShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_openShiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> UpdateOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId, Expression<Func<string>> requestsharedOpenShiftstartTime, Expression<Func<string>> requestsharedOpenShiftendTime, Expression<Func<int>> requestsharedOpenShiftopenSlotCount, Expression<Func<string>> requestschedulingGroupID = null, Expression<Func<string>> requestsharedOpenShiftdisplayName = null, Expression<Func<string>> requestsharedOpenShiftnotes = null, Expression<Func<requestsharedOpenShiftthemeInput>> requestsharedOpenShifttheme = null, Expression<Func<requestsharedOpenShiftactivitiesInputItem[]>> requestsharedOpenShiftactivities = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_openShiftId = openShiftId == null ? null : WorkflowExpression.Compile(openShiftId);
            WorkflowExpression.Validate(__workflow_openShiftId, nameof(openShiftId), required: true);
            var __workflow_requestsharedOpenShiftstartTime = requestsharedOpenShiftstartTime == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftstartTime);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftstartTime, nameof(requestsharedOpenShiftstartTime), required: true);
            var __workflow_requestsharedOpenShiftendTime = requestsharedOpenShiftendTime == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftendTime);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftendTime, nameof(requestsharedOpenShiftendTime), required: true);
            var __workflow_requestsharedOpenShiftopenSlotCount = requestsharedOpenShiftopenSlotCount == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftopenSlotCount);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftopenSlotCount, nameof(requestsharedOpenShiftopenSlotCount), required: true);
            var __workflow_requestschedulingGroupID = requestschedulingGroupID == null ? null : WorkflowExpression.Compile(requestschedulingGroupID);
            WorkflowExpression.Validate(__workflow_requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            var __workflow_requestsharedOpenShiftdisplayName = requestsharedOpenShiftdisplayName == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftdisplayName);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftdisplayName, nameof(requestsharedOpenShiftdisplayName), required: false);
            var __workflow_requestsharedOpenShiftnotes = requestsharedOpenShiftnotes == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftnotes);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftnotes, nameof(requestsharedOpenShiftnotes), required: false);
            var __workflow_requestsharedOpenShifttheme = requestsharedOpenShifttheme == null ? null : WorkflowExpression.Compile(requestsharedOpenShifttheme);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShifttheme, nameof(requestsharedOpenShifttheme), required: false);
            var __workflow_requestsharedOpenShiftactivities = requestsharedOpenShiftactivities == null ? null : WorkflowExpression.Compile(requestsharedOpenShiftactivities);
            WorkflowExpression.Validate(__workflow_requestsharedOpenShiftactivities, nameof(requestsharedOpenShiftactivities), required: false);
            return new DeferredBodyAction<OpenShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_openShiftId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestschedulingGroupID != null)
                {
                    request["schedulingGroupId"] = ExpressionConverter.ConvertO(__workflow_requestschedulingGroupID);
                    requestpropCount++;
                }

                var sharedOpenShiftObject = new JObject();
                var sharedOpenShiftObjectpropCount = 0;
                if (__workflow_requestsharedOpenShiftdisplayName != null)
                {
                    sharedOpenShiftObject["displayName"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftdisplayName);
                    sharedOpenShiftObjectpropCount++;
                }

                if (__workflow_requestsharedOpenShiftnotes != null)
                {
                    sharedOpenShiftObject["notes"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftnotes);
                    sharedOpenShiftObjectpropCount++;
                }

                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["startDateTime"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftstartTime);
                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["endDateTime"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftendTime);
                if (__workflow_requestsharedOpenShifttheme != null)
                {
                    if (__workflow_requestsharedOpenShifttheme != null)
                    {
                        sharedOpenShiftObject["theme"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShifttheme);
                        sharedOpenShiftObjectpropCount++;
                    }

                    sharedOpenShiftObjectpropCount++;
                }
                else
                {
                    sharedOpenShiftObject["theme"] = "white";
                    sharedOpenShiftObjectpropCount++;
                }

                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["openSlotCount"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftopenSlotCount);
                if (__workflow_requestsharedOpenShiftactivities != null)
                {
                    sharedOpenShiftObject["activities"] = ExpressionConverter.ConvertO(__workflow_requestsharedOpenShiftactivities);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteOpenShift(Expression<Func<string>> teamId, Expression<Func<string>> openShiftId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_openShiftId = openShiftId == null ? null : WorkflowExpression.Compile(openShiftId);
            WorkflowExpression.Validate(__workflow_openShiftId, nameof(openShiftId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_openShiftId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse> ListTimeOffReasons(Expression<Func<string>> teamId, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<GetTimeOffReasonsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffReasons", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetTimeOffReasonsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse> ListSchedulingGroups(Expression<Func<string>> teamId, Expression<Func<int>> top = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListSchedulingGroupsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ListSchedulingGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SchedulingGroupResponse> GetSchedulingGroup(Expression<Func<string>> teamId, Expression<Func<string>> schedulingGroupId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_schedulingGroupId = schedulingGroupId == null ? null : WorkflowExpression.Compile(schedulingGroupId);
            WorkflowExpression.Validate(__workflow_schedulingGroupId, nameof(schedulingGroupId), required: true);
            return new DeferredBodyAction<SchedulingGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_schedulingGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SchedulingGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse> ListTimeOffRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<ListTimeOffRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<TimeOffRequestResponse> GetTimeOffShiftRequest(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_timeOffRequestId = timeOffRequestId == null ? null : WorkflowExpression.Compile(timeOffRequestId);
            WorkflowExpression.Validate(__workflow_timeOffRequestId, nameof(timeOffRequestId), required: true);
            return new DeferredBodyAction<TimeOffRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_timeOffRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeOffRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction TimeOffRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_timeOffRequestId = timeOffRequestId == null ? null : WorkflowExpression.Compile(timeOffRequestId);
            WorkflowExpression.Validate(__workflow_timeOffRequestId, nameof(timeOffRequestId), required: true);
            var __workflow_requestmessageFromManager = requestmessageFromManager == null ? null : WorkflowExpression.Compile(requestmessageFromManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_timeOffRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction TimeOffRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> timeOffRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_timeOffRequestId = timeOffRequestId == null ? null : WorkflowExpression.Compile(timeOffRequestId);
            WorkflowExpression.Validate(__workflow_timeOffRequestId, nameof(timeOffRequestId), required: true);
            var __workflow_requestmessageFromManager = requestmessageFromManager == null ? null : WorkflowExpression.Compile(requestmessageFromManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_timeOffRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse> ListOfferShiftRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<ListOfferShiftRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<OfferShiftRequestResponse> GetOfferShiftRequest(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_offerShiftRequestId = offerShiftRequestId == null ? null : WorkflowExpression.Compile(offerShiftRequestId);
            WorkflowExpression.Validate(__workflow_offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            return new DeferredBodyAction<OfferShiftRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_offerShiftRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfferShiftRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OfferShiftRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_offerShiftRequestId = offerShiftRequestId == null ? null : WorkflowExpression.Compile(offerShiftRequestId);
            WorkflowExpression.Validate(__workflow_offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            var __workflow_requestmessageFromRecipientManager = requestmessageFromRecipientManager == null ? null : WorkflowExpression.Compile(requestmessageFromRecipientManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_offerShiftRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromRecipientManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OfferShiftRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> offerShiftRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_offerShiftRequestId = offerShiftRequestId == null ? null : WorkflowExpression.Compile(offerShiftRequestId);
            WorkflowExpression.Validate(__workflow_offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            var __workflow_requestmessageFromRecipientManager = requestmessageFromRecipientManager == null ? null : WorkflowExpression.Compile(requestmessageFromRecipientManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_offerShiftRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromRecipientManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse> ListSwapShiftsChangeRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<ListSwapShiftsChangeRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse> GetSwapShiftsChangeRequest(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_swapShiftsChangeRequestId = swapShiftsChangeRequestId == null ? null : WorkflowExpression.Compile(swapShiftsChangeRequestId);
            WorkflowExpression.Validate(__workflow_swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            return new DeferredBodyAction<SwapShiftsChangeRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SwapShiftsChangeRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction SwapShiftsChangeRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_swapShiftsChangeRequestId = swapShiftsChangeRequestId == null ? null : WorkflowExpression.Compile(swapShiftsChangeRequestId);
            WorkflowExpression.Validate(__workflow_swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            var __workflow_requestmessageFromRecipientManager = requestmessageFromRecipientManager == null ? null : WorkflowExpression.Compile(requestmessageFromRecipientManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromRecipientManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction SwapShiftsChangeRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> swapShiftsChangeRequestId, Expression<Func<string>> requestmessageFromRecipientManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_swapShiftsChangeRequestId = swapShiftsChangeRequestId == null ? null : WorkflowExpression.Compile(swapShiftsChangeRequestId);
            WorkflowExpression.Validate(__workflow_swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            var __workflow_requestmessageFromRecipientManager = requestmessageFromRecipientManager == null ? null : WorkflowExpression.Compile(requestmessageFromRecipientManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromRecipientManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse> ListOpenShiftChangeRequests(Expression<Func<string>> teamId, Expression<Func<int>> top = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<ListOpenShiftChangeRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
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
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse> GetOpenShiftChangeRequest(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_openShiftChangeRequestId = openShiftChangeRequestId == null ? null : WorkflowExpression.Compile(openShiftChangeRequestId);
            WorkflowExpression.Validate(__workflow_openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            return new DeferredBodyAction<OpenShiftChangeRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenShiftChangeRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OpenShiftChangeRequestApprove(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_openShiftChangeRequestId = openShiftChangeRequestId == null ? null : WorkflowExpression.Compile(openShiftChangeRequestId);
            WorkflowExpression.Validate(__workflow_openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            var __workflow_requestmessageFromManager = requestmessageFromManager == null ? null : WorkflowExpression.Compile(requestmessageFromManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OpenShiftChangeRequestDecline(Expression<Func<string>> teamId, Expression<Func<string>> openShiftChangeRequestId, Expression<Func<string>> requestmessageFromManager = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            var __workflow_openShiftChangeRequestId = openShiftChangeRequestId == null ? null : WorkflowExpression.Compile(openShiftChangeRequestId);
            WorkflowExpression.Validate(__workflow_openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            var __workflow_requestmessageFromManager = requestmessageFromManager == null ? null : WorkflowExpression.Compile(requestmessageFromManager);
            WorkflowExpression.Validate(__workflow_requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (__workflow_requestmessageFromManager != null)
                {
                    request["message"] = ExpressionConverter.ConvertO(__workflow_requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse> ListOpenShiftsCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<int>> top = null)
        {
            var __workflow_startTime = startTime == null ? null : WorkflowExpression.Compile(startTime);
            WorkflowExpression.Validate(__workflow_startTime, nameof(startTime), required: false);
            var __workflow_endTime = endTime == null ? null : WorkflowExpression.Compile(endTime);
            WorkflowExpression.Validate(__workflow_endTime, nameof(endTime), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListOpenShiftsCrossTeamResponse>(() =>
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
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse> ListShiftsCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> assignedToUserName = null, Expression<Func<int>> top = null)
        {
            var __workflow_startTime = startTime == null ? null : WorkflowExpression.Compile(startTime);
            WorkflowExpression.Validate(__workflow_startTime, nameof(startTime), required: false);
            var __workflow_endTime = endTime == null ? null : WorkflowExpression.Compile(endTime);
            WorkflowExpression.Validate(__workflow_endTime, nameof(endTime), required: false);
            var __workflow_assignedToUserName = assignedToUserName == null ? null : WorkflowExpression.Compile(assignedToUserName);
            WorkflowExpression.Validate(__workflow_assignedToUserName, nameof(assignedToUserName), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListShiftsCrossTeamResponse>(() =>
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
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse> ListTimesOffCrossTeam(Expression<Func<string>> startTime = null, Expression<Func<string>> endTime = null, Expression<Func<string>> assignedToUserName = null, Expression<Func<int>> top = null)
        {
            var __workflow_startTime = startTime == null ? null : WorkflowExpression.Compile(startTime);
            WorkflowExpression.Validate(__workflow_startTime, nameof(startTime), required: false);
            var __workflow_endTime = endTime == null ? null : WorkflowExpression.Compile(endTime);
            WorkflowExpression.Validate(__workflow_endTime, nameof(endTime), required: false);
            var __workflow_assignedToUserName = assignedToUserName == null ? null : WorkflowExpression.Compile(assignedToUserName);
            WorkflowExpression.Validate(__workflow_assignedToUserName, nameof(assignedToUserName), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            return new DeferredBodyAction<ListTimesOffCrossTeamResponse>(() =>
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
        public IWorkflowTrigger TriggerForOpenShiftChangeRequests(Expression<Func<string>> teamId, FlowRecurrence recurrence = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/openshiftchangerequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["notificationUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger TriggerForSwapShiftsChangeRequests(Expression<Func<string>> teamId, FlowRecurrence recurrence = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/swapshiftschangerequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["notificationUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger TriggerForOfferShiftRequests(Expression<Func<string>> teamId, FlowRecurrence recurrence = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/offershiftrequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["notificationUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger TriggerForTimeOffRequests(Expression<Func<string>> teamId, FlowRecurrence recurrence = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/timeoffrequests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["notificationUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger TriggerForShifts(Expression<Func<string>> teamId, FlowRecurrence recurrence = null)
        {
            var __workflow_teamId = teamId == null ? null : WorkflowExpression.Compile(teamId);
            WorkflowExpression.Validate(__workflow_teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/shifts", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["notificationUrl"] = "#{listCallbackUrl()}";
                requestpropCount++;
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum requestvaluethemeInput
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

    public class requestvalueactivitiesInputItem
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeOffRequestResponseAssignedToType
    {
        [EnumMember(Value = "mananger")]
        Mananger,
        [EnumMember(Value = "recipient")]
        Recipient
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
