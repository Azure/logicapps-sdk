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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ScheduleResponse> __BuildGetSchedule(WorkflowValue<string> teamId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimesOffResponse> __BuildListTimesOff(WorkflowValue<string> teamId, WorkflowValue<string> startTime = null, WorkflowValue<string> endTime = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(endTime, nameof(endTime), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeOffResponse> __BuildCreateTimeOff(WorkflowValue<string> teamId, WorkflowValue<string> requestuserID, WorkflowValue<string> requestvaluetimeOffReason = null, WorkflowValue<string> requestvaluestartTime = null, WorkflowValue<string> requestvalueendTime = null, WorkflowValue<requestvaluethemeInput> requestvaluetheme = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(requestuserID, nameof(requestuserID), required: true);
            WorkflowValue.Validate(requestvaluetimeOffReason, nameof(requestvaluetimeOffReason), required: false);
            WorkflowValue.Validate(requestvaluestartTime, nameof(requestvaluestartTime), required: false);
            WorkflowValue.Validate(requestvalueendTime, nameof(requestvalueendTime), required: false);
            WorkflowValue.Validate(requestvaluetheme, nameof(requestvaluetheme), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeOffResponse> __BuildGetTimeOff(WorkflowValue<string> teamId, WorkflowValue<string> timeOffId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(timeOffId, nameof(timeOffId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTimeOff(WorkflowValue<string> teamId, WorkflowValue<string> timeOffId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(timeOffId, nameof(timeOffId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListShiftsResponse> __BuildListShifts(WorkflowValue<string> teamId, WorkflowValue<string> startTime = null, WorkflowValue<string> endTime = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(endTime, nameof(endTime), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShiftResponse> __BuildCreateShift(WorkflowValue<string> teamId, WorkflowValue<string> requestuserID, WorkflowValue<string> requestschedulingGroupID = null, WorkflowValue<string> requestvaluedisplayName = null, WorkflowValue<string> requestvaluenotes = null, WorkflowValue<string> requestvaluestartTime = null, WorkflowValue<string> requestvalueendTime = null, WorkflowValue<requestvaluethemeInput> requestvaluetheme = null, WorkflowValue<requestvalueactivitiesInputItem[]> requestvalueactivities = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(requestuserID, nameof(requestuserID), required: true);
            WorkflowValue.Validate(requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            WorkflowValue.Validate(requestvaluedisplayName, nameof(requestvaluedisplayName), required: false);
            WorkflowValue.Validate(requestvaluenotes, nameof(requestvaluenotes), required: false);
            WorkflowValue.Validate(requestvaluestartTime, nameof(requestvaluestartTime), required: false);
            WorkflowValue.Validate(requestvalueendTime, nameof(requestvalueendTime), required: false);
            WorkflowValue.Validate(requestvaluetheme, nameof(requestvaluetheme), required: false);
            WorkflowValue.Validate(requestvalueactivities, nameof(requestvalueactivities), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShiftResponse> __BuildGetShift(WorkflowValue<string> teamId, WorkflowValue<string> shiftId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(shiftId, nameof(shiftId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteShift(WorkflowValue<string> teamId, WorkflowValue<string> shiftId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(shiftId, nameof(shiftId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOpenShiftsResponse> __BuildListOpenShifts(WorkflowValue<string> teamId, WorkflowValue<string> startTime = null, WorkflowValue<string> endTime = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(endTime, nameof(endTime), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftResponse> __BuildCreateOpenShift(WorkflowValue<string> teamId, WorkflowValue<string> requestsharedOpenShiftstartTime, WorkflowValue<string> requestsharedOpenShiftendTime, WorkflowValue<int> requestsharedOpenShiftopenSlotCount, WorkflowValue<string> requestschedulingGroupID = null, WorkflowValue<string> requestsharedOpenShiftdisplayName = null, WorkflowValue<string> requestsharedOpenShiftnotes = null, WorkflowValue<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, WorkflowValue<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(requestsharedOpenShiftstartTime, nameof(requestsharedOpenShiftstartTime), required: true);
            WorkflowValue.Validate(requestsharedOpenShiftendTime, nameof(requestsharedOpenShiftendTime), required: true);
            WorkflowValue.Validate(requestsharedOpenShiftopenSlotCount, nameof(requestsharedOpenShiftopenSlotCount), required: true);
            WorkflowValue.Validate(requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            WorkflowValue.Validate(requestsharedOpenShiftdisplayName, nameof(requestsharedOpenShiftdisplayName), required: false);
            WorkflowValue.Validate(requestsharedOpenShiftnotes, nameof(requestsharedOpenShiftnotes), required: false);
            WorkflowValue.Validate(requestsharedOpenShifttheme, nameof(requestsharedOpenShifttheme), required: false);
            WorkflowValue.Validate(requestsharedOpenShiftactivities, nameof(requestsharedOpenShiftactivities), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftResponse> __BuildGetOpenShift(WorkflowValue<string> teamId, WorkflowValue<string> openShiftId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(openShiftId, nameof(openShiftId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftResponse> __BuildUpdateOpenShift(WorkflowValue<string> teamId, WorkflowValue<string> openShiftId, WorkflowValue<string> requestsharedOpenShiftstartTime, WorkflowValue<string> requestsharedOpenShiftendTime, WorkflowValue<int> requestsharedOpenShiftopenSlotCount, WorkflowValue<string> requestschedulingGroupID = null, WorkflowValue<string> requestsharedOpenShiftdisplayName = null, WorkflowValue<string> requestsharedOpenShiftnotes = null, WorkflowValue<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, WorkflowValue<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(openShiftId, nameof(openShiftId), required: true);
            WorkflowValue.Validate(requestsharedOpenShiftstartTime, nameof(requestsharedOpenShiftstartTime), required: true);
            WorkflowValue.Validate(requestsharedOpenShiftendTime, nameof(requestsharedOpenShiftendTime), required: true);
            WorkflowValue.Validate(requestsharedOpenShiftopenSlotCount, nameof(requestsharedOpenShiftopenSlotCount), required: true);
            WorkflowValue.Validate(requestschedulingGroupID, nameof(requestschedulingGroupID), required: false);
            WorkflowValue.Validate(requestsharedOpenShiftdisplayName, nameof(requestsharedOpenShiftdisplayName), required: false);
            WorkflowValue.Validate(requestsharedOpenShiftnotes, nameof(requestsharedOpenShiftnotes), required: false);
            WorkflowValue.Validate(requestsharedOpenShifttheme, nameof(requestsharedOpenShifttheme), required: false);
            WorkflowValue.Validate(requestsharedOpenShiftactivities, nameof(requestsharedOpenShiftactivities), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteOpenShift(WorkflowValue<string> teamId, WorkflowValue<string> openShiftId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(openShiftId, nameof(openShiftId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse> __BuildListTimeOffReasons(WorkflowValue<string> teamId, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse> __BuildListSchedulingGroups(WorkflowValue<string> teamId, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SchedulingGroupResponse> __BuildGetSchedulingGroup(WorkflowValue<string> teamId, WorkflowValue<string> schedulingGroupId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(schedulingGroupId, nameof(schedulingGroupId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse> __BuildListTimeOffRequests(WorkflowValue<string> teamId, WorkflowValue<int> top = null, WorkflowValue<stateInput> state = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimeOffRequestResponse> __BuildGetTimeOffShiftRequest(WorkflowValue<string> teamId, WorkflowValue<string> timeOffRequestId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(timeOffRequestId, nameof(timeOffRequestId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTimeOffRequestApprove(WorkflowValue<string> teamId, WorkflowValue<string> timeOffRequestId, WorkflowValue<string> requestmessageFromManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(timeOffRequestId, nameof(timeOffRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTimeOffRequestDecline(WorkflowValue<string> teamId, WorkflowValue<string> timeOffRequestId, WorkflowValue<string> requestmessageFromManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(timeOffRequestId, nameof(timeOffRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse> __BuildListOfferShiftRequests(WorkflowValue<string> teamId, WorkflowValue<int> top = null, WorkflowValue<stateInput> state = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfferShiftRequestResponse> __BuildGetOfferShiftRequest(WorkflowValue<string> teamId, WorkflowValue<string> offerShiftRequestId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOfferShiftRequestApprove(WorkflowValue<string> teamId, WorkflowValue<string> offerShiftRequestId, WorkflowValue<string> requestmessageFromRecipientManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOfferShiftRequestDecline(WorkflowValue<string> teamId, WorkflowValue<string> offerShiftRequestId, WorkflowValue<string> requestmessageFromRecipientManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(offerShiftRequestId, nameof(offerShiftRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse> __BuildListSwapShiftsChangeRequests(WorkflowValue<string> teamId, WorkflowValue<int> top = null, WorkflowValue<stateInput> state = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse> __BuildGetSwapShiftsChangeRequest(WorkflowValue<string> teamId, WorkflowValue<string> swapShiftsChangeRequestId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSwapShiftsChangeRequestApprove(WorkflowValue<string> teamId, WorkflowValue<string> swapShiftsChangeRequestId, WorkflowValue<string> requestmessageFromRecipientManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSwapShiftsChangeRequestDecline(WorkflowValue<string> teamId, WorkflowValue<string> swapShiftsChangeRequestId, WorkflowValue<string> requestmessageFromRecipientManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(swapShiftsChangeRequestId, nameof(swapShiftsChangeRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromRecipientManager, nameof(requestmessageFromRecipientManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse> __BuildListOpenShiftChangeRequests(WorkflowValue<string> teamId, WorkflowValue<int> top = null, WorkflowValue<stateInput> state = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(state, nameof(state), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse> __BuildGetOpenShiftChangeRequest(WorkflowValue<string> teamId, WorkflowValue<string> openShiftChangeRequestId)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOpenShiftChangeRequestApprove(WorkflowValue<string> teamId, WorkflowValue<string> openShiftChangeRequestId, WorkflowValue<string> requestmessageFromManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildOpenShiftChangeRequestDecline(WorkflowValue<string> teamId, WorkflowValue<string> openShiftChangeRequestId, WorkflowValue<string> requestmessageFromManager = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
            WorkflowValue.Validate(openShiftChangeRequestId, nameof(openShiftChangeRequestId), required: true);
            WorkflowValue.Validate(requestmessageFromManager, nameof(requestmessageFromManager), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse> __BuildListOpenShiftsCrossTeam(WorkflowValue<string> startTime = null, WorkflowValue<string> endTime = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(endTime, nameof(endTime), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse> __BuildListShiftsCrossTeam(WorkflowValue<string> startTime = null, WorkflowValue<string> endTime = null, WorkflowValue<string> assignedToUserName = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(endTime, nameof(endTime), required: false);
            WorkflowValue.Validate(assignedToUserName, nameof(assignedToUserName), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse> __BuildListTimesOffCrossTeam(WorkflowValue<string> startTime = null, WorkflowValue<string> endTime = null, WorkflowValue<string> assignedToUserName = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(startTime, nameof(startTime), required: false);
            WorkflowValue.Validate(endTime, nameof(endTime), required: false);
            WorkflowValue.Validate(assignedToUserName, nameof(assignedToUserName), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
        public IWorkflowTrigger TriggerForOpenShiftChangeRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForOpenShiftChangeRequests(WorkflowValue<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerForSwapShiftsChangeRequests))]
        public IWorkflowTrigger TriggerForSwapShiftsChangeRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForSwapShiftsChangeRequests(WorkflowValue<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerForOfferShiftRequests))]
        public IWorkflowTrigger TriggerForOfferShiftRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForOfferShiftRequests(WorkflowValue<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerForTimeOffRequests))]
        public IWorkflowTrigger TriggerForTimeOffRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForTimeOffRequests(WorkflowValue<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTriggerForShifts))]
        public IWorkflowTrigger TriggerForShifts([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildTriggerForShifts(WorkflowValue<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(teamId, nameof(teamId), required: true);
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
