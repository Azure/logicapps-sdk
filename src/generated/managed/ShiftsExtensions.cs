//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shifts
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShiftsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetSchedule))]
        public IBodyWorkflowAction<ScheduleResponse> GetSchedule([WorkflowExpression] Func<string> teamId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleResponse> __BuildGetSchedule(WorkflowExpression<string> teamId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredBodyAction<ScheduleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ScheduleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListTimesOff))]
        public IBodyWorkflowAction<ListTimesOffResponse> ListTimesOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimesOffResponse> __BuildListTimesOff(WorkflowExpression<string> teamId, WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListTimesOffResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ListTimesOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTimeOff))]
        public IBodyWorkflowAction<TimeOffResponse> CreateTimeOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> requestuserID, [WorkflowExpression] Func<string> requestvaluetimeOffReason = null, [WorkflowExpression] Func<string> requestvaluestartTime = null, [WorkflowExpression] Func<string> requestvalueendTime = null, [WorkflowExpression] Func<requestvaluethemeInput> requestvaluetheme = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeOffResponse> __BuildCreateTimeOff(WorkflowExpression<string> teamId, WorkflowExpression<string> requestuserID, WorkflowExpression<string> requestvaluetimeOffReason = null, WorkflowExpression<string> requestvaluestartTime = null, WorkflowExpression<string> requestvalueendTime = null, WorkflowExpression<requestvaluethemeInput> requestvaluetheme = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(requestuserID, nameof(requestuserID), required: true);
            WorkflowExpression.Validate(requestvaluetimeOffReason, nameof(requestvaluetimeOffReason), required: false);
            WorkflowExpression.Validate(requestvaluestartTime, nameof(requestvaluestartTime), required: false);
            WorkflowExpression.Validate(requestvalueendTime, nameof(requestvalueendTime), required: false);
            WorkflowExpression.Validate(requestvaluetheme, nameof(requestvaluetheme), required: false);
            return new DeferredBodyAction<TimeOffResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var sharedTimeOffObject = new JObject();
                var sharedTimeOffObjectpropCount = 0;
                if (requestvaluetimeOffReason != null)
                {
                    sharedTimeOffObject["timeOffReasonId"] = ExpressionConverter.ConvertO(requestvaluetimeOffReason);
                    sharedTimeOffObjectpropCount++;
                }

                if (requestvaluestartTime != null)
                {
                    sharedTimeOffObject["startDateTime"] = ExpressionConverter.ConvertO(requestvaluestartTime);
                    sharedTimeOffObjectpropCount++;
                }

                if (requestvalueendTime != null)
                {
                    sharedTimeOffObject["endDateTime"] = ExpressionConverter.ConvertO(requestvalueendTime);
                    sharedTimeOffObjectpropCount++;
                }

                if (requestvaluetheme != null)
                {
                    if (requestvaluetheme != null)
                    {
                        sharedTimeOffObject["theme"] = ExpressionConverter.ConvertO(requestvaluetheme);
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
                request["userId"] = ExpressionConverter.ConvertO(requestuserID);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<TimeOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeOff))]
        public IBodyWorkflowAction<TimeOffResponse> GetTimeOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeOffResponse> __BuildGetTimeOff(WorkflowExpression<string> teamId, WorkflowExpression<string> timeOffId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(timeOffId, nameof(timeOffId), required: true);
            return new DeferredBodyAction<TimeOffResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeOffResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTimeOff))]
        public IWorkflowAction DeleteTimeOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTimeOff(WorkflowExpression<string> teamId, WorkflowExpression<string> timeOffId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(timeOffId, nameof(timeOffId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListShifts))]
        public IBodyWorkflowAction<ListShiftsResponse> ListShifts([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListShiftsResponse> __BuildListShifts(WorkflowExpression<string> teamId, WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListShiftsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ListShiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildCreateShift))]
        public IBodyWorkflowAction<ShiftResponse> CreateShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> requestuserID, [WorkflowExpression] Func<string> requestschedulingGroupID = null, [WorkflowExpression] Func<string> requestvaluedisplayName = null, [WorkflowExpression] Func<string> requestvaluenotes = null, [WorkflowExpression] Func<string> requestvaluestartTime = null, [WorkflowExpression] Func<string> requestvalueendTime = null, [WorkflowExpression] Func<requestvaluethemeInput> requestvaluetheme = null, [WorkflowExpression] Func<requestvalueactivitiesInputItem[]> requestvalueactivities = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShiftResponse> __BuildCreateShift(WorkflowExpression<string> teamId, WorkflowExpression<string> requestuserID, WorkflowExpression<string> requestschedulingGroupID = null, WorkflowExpression<string> requestvaluedisplayName = null, WorkflowExpression<string> requestvaluenotes = null, WorkflowExpression<string> requestvaluestartTime = null, WorkflowExpression<string> requestvalueendTime = null, WorkflowExpression<requestvaluethemeInput> requestvaluetheme = null, WorkflowExpression<requestvalueactivitiesInputItem[]> requestvalueactivities = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(requestuserID, nameof(requestuserID), required: true);
            WorkflowExpression.Validate(requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            WorkflowExpression.Validate(requestvaluedisplayName, nameof(requestvaluedisplayName), required: false);
            WorkflowExpression.Validate(requestvaluenotes, nameof(requestvaluenotes), required: false);
            WorkflowExpression.Validate(requestvaluestartTime, nameof(requestvaluestartTime), required: false);
            WorkflowExpression.Validate(requestvalueendTime, nameof(requestvalueendTime), required: false);
            WorkflowExpression.Validate(requestvaluetheme, nameof(requestvaluetheme), required: false);
            WorkflowExpression.Validate(requestvalueactivities, nameof(requestvalueactivities), required: false);
            return new DeferredBodyAction<ShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestschedulingGroupID != null)
                {
                    request["schedulingGroupId"] = ExpressionConverter.ConvertO(requestschedulingGroupID);
                    requestpropCount++;
                }

                var sharedShiftObject = new JObject();
                var sharedShiftObjectpropCount = 0;
                if (requestvaluedisplayName != null)
                {
                    sharedShiftObject["displayName"] = ExpressionConverter.ConvertO(requestvaluedisplayName);
                    sharedShiftObjectpropCount++;
                }

                if (requestvaluenotes != null)
                {
                    sharedShiftObject["notes"] = ExpressionConverter.ConvertO(requestvaluenotes);
                    sharedShiftObjectpropCount++;
                }

                if (requestvaluestartTime != null)
                {
                    sharedShiftObject["startDateTime"] = ExpressionConverter.ConvertO(requestvaluestartTime);
                    sharedShiftObjectpropCount++;
                }

                if (requestvalueendTime != null)
                {
                    sharedShiftObject["endDateTime"] = ExpressionConverter.ConvertO(requestvalueendTime);
                    sharedShiftObjectpropCount++;
                }

                if (requestvaluetheme != null)
                {
                    if (requestvaluetheme != null)
                    {
                        sharedShiftObject["theme"] = ExpressionConverter.ConvertO(requestvaluetheme);
                        sharedShiftObjectpropCount++;
                    }

                    sharedShiftObjectpropCount++;
                }
                else
                {
                    sharedShiftObject["theme"] = "white";
                    sharedShiftObjectpropCount++;
                }

                if (requestvalueactivities != null)
                {
                    sharedShiftObject["activities"] = ExpressionConverter.ConvertO(requestvalueactivities);
                    sharedShiftObjectpropCount++;
                }

                if (sharedShiftObjectpropCount > 0)
                {
                    request["sharedShift"] = sharedShiftObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["userId"] = ExpressionConverter.ConvertO(requestuserID);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction<ShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetShift))]
        public IBodyWorkflowAction<ShiftResponse> GetShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> shiftId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShiftResponse> __BuildGetShift(WorkflowExpression<string> teamId, WorkflowExpression<string> shiftId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(shiftId, nameof(shiftId), required: true);
            return new DeferredBodyAction<ShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(shiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteShift))]
        public IWorkflowAction DeleteShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> shiftId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteShift(WorkflowExpression<string> teamId, WorkflowExpression<string> shiftId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(shiftId, nameof(shiftId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(shiftId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListOpenShifts))]
        public IBodyWorkflowAction<ListOpenShiftsResponse> ListOpenShifts([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOpenShiftsResponse> __BuildListOpenShifts(WorkflowExpression<string> teamId, WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListOpenShiftsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = ExpressionConverter.Convert(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = ExpressionConverter.Convert(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ListOpenShiftsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOpenShift))]
        public IBodyWorkflowAction<OpenShiftResponse> CreateOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> requestsharedOpenShiftstartTime, [WorkflowExpression] Func<string> requestsharedOpenShiftendTime, [WorkflowExpression] Func<int> requestsharedOpenShiftopenSlotCount, [WorkflowExpression] Func<string> requestschedulingGroupID = null, [WorkflowExpression] Func<string> requestsharedOpenShiftdisplayName = null, [WorkflowExpression] Func<string> requestsharedOpenShiftnotes = null, [WorkflowExpression] Func<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, [WorkflowExpression] Func<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftResponse> __BuildCreateOpenShift(WorkflowExpression<string> teamId, WorkflowExpression<string> requestsharedOpenShiftstartTime, WorkflowExpression<string> requestsharedOpenShiftendTime, WorkflowExpression<int> requestsharedOpenShiftopenSlotCount, WorkflowExpression<string> requestschedulingGroupID = null, WorkflowExpression<string> requestsharedOpenShiftdisplayName = null, WorkflowExpression<string> requestsharedOpenShiftnotes = null, WorkflowExpression<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, WorkflowExpression<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(requestsharedOpenShiftstartTime, nameof(requestsharedOpenShiftstartTime), required: true);
            WorkflowExpression.Validate(requestsharedOpenShiftendTime, nameof(requestsharedOpenShiftendTime), required: true);
            WorkflowExpression.Validate(requestsharedOpenShiftopenSlotCount, nameof(requestsharedOpenShiftopenSlotCount), required: true);
            WorkflowExpression.Validate(requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            WorkflowExpression.Validate(requestsharedOpenShiftdisplayName, nameof(requestsharedOpenShiftdisplayName), required: false);
            WorkflowExpression.Validate(requestsharedOpenShiftnotes, nameof(requestsharedOpenShiftnotes), required: false);
            WorkflowExpression.Validate(requestsharedOpenShifttheme, nameof(requestsharedOpenShifttheme), required: false);
            WorkflowExpression.Validate(requestsharedOpenShiftactivities, nameof(requestsharedOpenShiftactivities), required: false);
            return new DeferredBodyAction<OpenShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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
                    if (requestsharedOpenShifttheme != null)
                    {
                        sharedOpenShiftObject["theme"] = ExpressionConverter.ConvertO(requestsharedOpenShifttheme);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetOpenShift))]
        public IBodyWorkflowAction<OpenShiftResponse> GetOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftResponse> __BuildGetOpenShift(WorkflowExpression<string> teamId, WorkflowExpression<string> openShiftId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(openShiftId, nameof(openShiftId), required: true);
            return new DeferredBodyAction<OpenShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenShiftResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateOpenShift))]
        public IBodyWorkflowAction<OpenShiftResponse> UpdateOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftId, [WorkflowExpression] Func<string> requestsharedOpenShiftstartTime, [WorkflowExpression] Func<string> requestsharedOpenShiftendTime, [WorkflowExpression] Func<int> requestsharedOpenShiftopenSlotCount, [WorkflowExpression] Func<string> requestschedulingGroupID = null, [WorkflowExpression] Func<string> requestsharedOpenShiftdisplayName = null, [WorkflowExpression] Func<string> requestsharedOpenShiftnotes = null, [WorkflowExpression] Func<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, [WorkflowExpression] Func<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftResponse> __BuildUpdateOpenShift(WorkflowExpression<string> teamId, WorkflowExpression<string> openShiftId, WorkflowExpression<string> requestsharedOpenShiftstartTime, WorkflowExpression<string> requestsharedOpenShiftendTime, WorkflowExpression<int> requestsharedOpenShiftopenSlotCount, WorkflowExpression<string> requestschedulingGroupID = null, WorkflowExpression<string> requestsharedOpenShiftdisplayName = null, WorkflowExpression<string> requestsharedOpenShiftnotes = null, WorkflowExpression<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, WorkflowExpression<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(openShiftId, nameof(openShiftId), required: true);
            WorkflowExpression.Validate(requestsharedOpenShiftstartTime, nameof(requestsharedOpenShiftstartTime), required: true);
            WorkflowExpression.Validate(requestsharedOpenShiftendTime, nameof(requestsharedOpenShiftendTime), required: true);
            WorkflowExpression.Validate(requestsharedOpenShiftopenSlotCount, nameof(requestsharedOpenShiftopenSlotCount), required: true);
            WorkflowExpression.Validate(requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            WorkflowExpression.Validate(requestsharedOpenShiftdisplayName, nameof(requestsharedOpenShiftdisplayName), required: false);
            WorkflowExpression.Validate(requestsharedOpenShiftnotes, nameof(requestsharedOpenShiftnotes), required: false);
            WorkflowExpression.Validate(requestsharedOpenShifttheme, nameof(requestsharedOpenShifttheme), required: false);
            WorkflowExpression.Validate(requestsharedOpenShiftactivities, nameof(requestsharedOpenShiftactivities), required: false);
            return new DeferredBodyAction<OpenShiftResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftId, 1));
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
                    if (requestsharedOpenShifttheme != null)
                    {
                        sharedOpenShiftObject["theme"] = ExpressionConverter.ConvertO(requestsharedOpenShifttheme);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteOpenShift))]
        public IWorkflowAction DeleteOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteOpenShift(WorkflowExpression<string> teamId, WorkflowExpression<string> openShiftId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(openShiftId, nameof(openShiftId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListTimeOffReasons))]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse> ListTimeOffReasons([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse> __BuildListTimeOffReasons(WorkflowExpression<string> teamId, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<GetTimeOffReasonsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffReasons", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<GetTimeOffReasonsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListSchedulingGroups))]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse> ListSchedulingGroups([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse> __BuildListSchedulingGroups(WorkflowExpression<string> teamId, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListSchedulingGroupsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ListSchedulingGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetSchedulingGroup))]
        public IBodyWorkflowAction<SchedulingGroupResponse> GetSchedulingGroup([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> schedulingGroupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SchedulingGroupResponse> __BuildGetSchedulingGroup(WorkflowExpression<string> teamId, WorkflowExpression<string> schedulingGroupId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(schedulingGroupId, nameof(schedulingGroupId), required: true);
            return new DeferredBodyAction<SchedulingGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(schedulingGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SchedulingGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListTimeOffRequests))]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse> ListTimeOffRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse> __BuildListTimeOffRequests(WorkflowExpression<string> teamId, WorkflowExpression<int> top = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<ListTimeOffRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<ListTimeOffRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeOffShiftRequest))]
        public IBodyWorkflowAction<TimeOffRequestResponse> GetTimeOffShiftRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffRequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeOffRequestResponse> __BuildGetTimeOffShiftRequest(WorkflowExpression<string> teamId, WorkflowExpression<string> timeOffRequestId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(timeOffRequestId, nameof(timeOffRequestId), required: true);
            return new DeferredBodyAction<TimeOffRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimeOffRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildTimeOffRequestApprove))]
        public IWorkflowAction TimeOffRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTimeOffRequestApprove(WorkflowExpression<string> teamId, WorkflowExpression<string> timeOffRequestId, WorkflowExpression<string> requestmessageFromManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(timeOffRequestId, nameof(timeOffRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildTimeOffRequestDecline))]
        public IWorkflowAction TimeOffRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTimeOffRequestDecline(WorkflowExpression<string> teamId, WorkflowExpression<string> timeOffRequestId, WorkflowExpression<string> requestmessageFromManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(timeOffRequestId, nameof(timeOffRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(timeOffRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListOfferShiftRequests))]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse> ListOfferShiftRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse> __BuildListOfferShiftRequests(WorkflowExpression<string> teamId, WorkflowExpression<int> top = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<ListOfferShiftRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<ListOfferShiftRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetOfferShiftRequest))]
        public IBodyWorkflowAction<OfferShiftRequestResponse> GetOfferShiftRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> offerShiftRequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfferShiftRequestResponse> __BuildGetOfferShiftRequest(WorkflowExpression<string> teamId, WorkflowExpression<string> offerShiftRequestId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            return new DeferredBodyAction<OfferShiftRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(offerShiftRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfferShiftRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildOfferShiftRequestApprove))]
        public IWorkflowAction OfferShiftRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> offerShiftRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOfferShiftRequestApprove(WorkflowExpression<string> teamId, WorkflowExpression<string> offerShiftRequestId, WorkflowExpression<string> requestmessageFromRecipientManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(offerShiftRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildOfferShiftRequestDecline))]
        public IWorkflowAction OfferShiftRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> offerShiftRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOfferShiftRequestDecline(WorkflowExpression<string> teamId, WorkflowExpression<string> offerShiftRequestId, WorkflowExpression<string> requestmessageFromRecipientManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(offerShiftRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListSwapShiftsChangeRequests))]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse> ListSwapShiftsChangeRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse> __BuildListSwapShiftsChangeRequests(WorkflowExpression<string> teamId, WorkflowExpression<int> top = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<ListSwapShiftsChangeRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<ListSwapShiftsChangeRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetSwapShiftsChangeRequest))]
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse> GetSwapShiftsChangeRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> swapShiftsChangeRequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse> __BuildGetSwapShiftsChangeRequest(WorkflowExpression<string> teamId, WorkflowExpression<string> swapShiftsChangeRequestId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            return new DeferredBodyAction<SwapShiftsChangeRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SwapShiftsChangeRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildSwapShiftsChangeRequestApprove))]
        public IWorkflowAction SwapShiftsChangeRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> swapShiftsChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSwapShiftsChangeRequestApprove(WorkflowExpression<string> teamId, WorkflowExpression<string> swapShiftsChangeRequestId, WorkflowExpression<string> requestmessageFromRecipientManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(swapShiftsChangeRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildSwapShiftsChangeRequestDecline))]
        public IWorkflowAction SwapShiftsChangeRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> swapShiftsChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSwapShiftsChangeRequestDecline(WorkflowExpression<string> teamId, WorkflowExpression<string> swapShiftsChangeRequestId, WorkflowExpression<string> requestmessageFromRecipientManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(swapShiftsChangeRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListOpenShiftChangeRequests))]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse> ListOpenShiftChangeRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse> __BuildListOpenShiftChangeRequests(WorkflowExpression<string> teamId, WorkflowExpression<int> top = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<ListOpenShiftChangeRequestsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<ListOpenShiftChangeRequestsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildGetOpenShiftChangeRequest))]
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse> GetOpenShiftChangeRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftChangeRequestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse> __BuildGetOpenShiftChangeRequest(WorkflowExpression<string> teamId, WorkflowExpression<string> openShiftChangeRequestId)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            return new DeferredBodyAction<OpenShiftChangeRequestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenShiftChangeRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildOpenShiftChangeRequestApprove))]
        public IWorkflowAction OpenShiftChangeRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOpenShiftChangeRequestApprove(WorkflowExpression<string> teamId, WorkflowExpression<string> openShiftChangeRequestId, WorkflowExpression<string> requestmessageFromManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/approve", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftChangeRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildOpenShiftChangeRequestDecline))]
        public IWorkflowAction OpenShiftChangeRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOpenShiftChangeRequestDecline(WorkflowExpression<string> teamId, WorkflowExpression<string> openShiftChangeRequestId, WorkflowExpression<string> requestmessageFromManager = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            WorkflowExpression.Validate(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            WorkflowExpression.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/decline", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1), ExpressionConverter.ConvertWithUrlEncoding(openShiftChangeRequestId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListOpenShiftsCrossTeam))]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse> ListOpenShiftsCrossTeam([WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse> __BuildListOpenShiftsCrossTeam(WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListOpenShiftsCrossTeamResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListShiftsCrossTeam))]
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse> ListShiftsCrossTeam([WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<string> assignedToUserName = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse> __BuildListShiftsCrossTeam(WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<string> assignedToUserName = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(assignedToUserName, nameof(assignedToUserName), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListShiftsCrossTeamResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [WorkflowExpressionFactory(nameof(__BuildListTimesOffCrossTeam))]
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse> ListTimesOffCrossTeam([WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<string> assignedToUserName = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse> __BuildListTimesOffCrossTeam(WorkflowExpression<string> startTime = null, WorkflowExpression<string> endTime = null, WorkflowExpression<string> assignedToUserName = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(startTime, nameof(startTime), required: false);
            WorkflowExpression.Validate(endTime, nameof(endTime), required: false);
            WorkflowExpression.Validate(assignedToUserName, nameof(assignedToUserName), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ListTimesOffCrossTeamResponse>(() =>
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
            });
        }
    }

    public class ShiftsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildTriggerForOpenShiftChangeRequests))]
        public IWorkflowTrigger TriggerForOpenShiftChangeRequests([WorkflowExpression] Func<string> teamId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForOpenShiftChangeRequests(WorkflowExpression<string> teamId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/openshiftchangerequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildTriggerForSwapShiftsChangeRequests))]
        public IWorkflowTrigger TriggerForSwapShiftsChangeRequests([WorkflowExpression] Func<string> teamId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForSwapShiftsChangeRequests(WorkflowExpression<string> teamId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/swapshiftschangerequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildTriggerForOfferShiftRequests))]
        public IWorkflowTrigger TriggerForOfferShiftRequests([WorkflowExpression] Func<string> teamId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForOfferShiftRequests(WorkflowExpression<string> teamId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/offershiftrequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildTriggerForTimeOffRequests))]
        public IWorkflowTrigger TriggerForTimeOffRequests([WorkflowExpression] Func<string> teamId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForTimeOffRequests(WorkflowExpression<string> teamId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/timeoffrequests", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildTriggerForShifts))]
        public IWorkflowTrigger TriggerForShifts([WorkflowExpression] Func<string> teamId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForShifts(WorkflowExpression<string> teamId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(teamId, nameof(teamId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/shifts", ExpressionConverter.ConvertWithUrlEncoding(teamId, 1));
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