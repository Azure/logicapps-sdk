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
        public IBodyWorkflowAction<ScheduleResponse> GetSchedule([WorkflowExpression] Func<string> teamId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ScheduleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffResponse> ListTimesOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = SourceExpressionConverter.ConvertO(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListTimesOffResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffResponse> CreateTimeOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> requestuserId, [WorkflowExpression] Func<string> requestvaluetimeOffReason = null, [WorkflowExpression] Func<string> requestvaluestartTime = null, [WorkflowExpression] Func<string> requestvalueendTime = null, [WorkflowExpression] Func<requestvaluethemeInput> requestvaluetheme = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                var sharedTimeOffObject = new JObject();
                var sharedTimeOffObjectpropCount = 0;
                if (requestvaluetimeOffReason != null)
                {
                    sharedTimeOffObject["timeOffReasonId"] = SourceExpressionConverter.ConvertToken(requestvaluetimeOffReason);
                    sharedTimeOffObjectpropCount++;
                }

                if (requestvaluestartTime != null)
                {
                    sharedTimeOffObject["startDateTime"] = SourceExpressionConverter.ConvertToken(requestvaluestartTime);
                    sharedTimeOffObjectpropCount++;
                }

                if (requestvalueendTime != null)
                {
                    sharedTimeOffObject["endDateTime"] = SourceExpressionConverter.ConvertToken(requestvalueendTime);
                    sharedTimeOffObjectpropCount++;
                }

                if (requestvaluetheme != null)
                {
                    if (requestvaluetheme != null)
                    {
                        sharedTimeOffObject["theme"] = SourceExpressionConverter.Convert(requestvaluetheme);
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
                request["userId"] = SourceExpressionConverter.ConvertToken(requestuserId);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimeOffResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffResponse> GetTimeOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeOffId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeOffResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteTimeOff([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timesoff/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeOffId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsResponse> ListShifts([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = SourceExpressionConverter.ConvertO(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListShiftsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ShiftResponse> CreateShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> requestuserId, [WorkflowExpression] Func<string> requestschedulingGroupId = null, [WorkflowExpression] Func<string> requestvaluedisplayName = null, [WorkflowExpression] Func<string> requestvaluenotes = null, [WorkflowExpression] Func<string> requestvaluestartTime = null, [WorkflowExpression] Func<string> requestvalueendTime = null, [WorkflowExpression] Func<requestvaluethemeInput> requestvaluetheme = null, [WorkflowExpression] Func<requestvalueactivitiesInputItem[]> requestvalueactivities = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestschedulingGroupId != null)
                {
                    request["schedulingGroupId"] = SourceExpressionConverter.ConvertToken(requestschedulingGroupId);
                    requestpropCount++;
                }

                var sharedShiftObject = new JObject();
                var sharedShiftObjectpropCount = 0;
                if (requestvaluedisplayName != null)
                {
                    sharedShiftObject["displayName"] = SourceExpressionConverter.ConvertToken(requestvaluedisplayName);
                    sharedShiftObjectpropCount++;
                }

                if (requestvaluenotes != null)
                {
                    sharedShiftObject["notes"] = SourceExpressionConverter.ConvertToken(requestvaluenotes);
                    sharedShiftObjectpropCount++;
                }

                if (requestvaluestartTime != null)
                {
                    sharedShiftObject["startDateTime"] = SourceExpressionConverter.ConvertToken(requestvaluestartTime);
                    sharedShiftObjectpropCount++;
                }

                if (requestvalueendTime != null)
                {
                    sharedShiftObject["endDateTime"] = SourceExpressionConverter.ConvertToken(requestvalueendTime);
                    sharedShiftObjectpropCount++;
                }

                if (requestvaluetheme != null)
                {
                    if (requestvaluetheme != null)
                    {
                        sharedShiftObject["theme"] = SourceExpressionConverter.Convert(requestvaluetheme);
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
                    sharedShiftObject["activities"] = SourceExpressionConverter.ConvertToken(requestvalueactivities);
                    sharedShiftObjectpropCount++;
                }

                if (sharedShiftObjectpropCount > 0)
                {
                    request["sharedShift"] = sharedShiftObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["userId"] = SourceExpressionConverter.ConvertToken(requestuserId);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ShiftResponse> GetShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> shiftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(shiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> shiftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/shifts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(shiftId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsResponse> ListOpenShifts([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = SourceExpressionConverter.ConvertO(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListOpenShiftsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> CreateOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> requestsharedOpenShiftstartTime, [WorkflowExpression] Func<string> requestsharedOpenShiftendTime, [WorkflowExpression] Func<int> requestsharedOpenShiftopenSlotCount, [WorkflowExpression] Func<string> requestschedulingGroupId = null, [WorkflowExpression] Func<string> requestsharedOpenShiftdisplayName = null, [WorkflowExpression] Func<string> requestsharedOpenShiftnotes = null, [WorkflowExpression] Func<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, [WorkflowExpression] Func<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestschedulingGroupId != null)
                {
                    request["schedulingGroupId"] = SourceExpressionConverter.ConvertToken(requestschedulingGroupId);
                    requestpropCount++;
                }

                var sharedOpenShiftObject = new JObject();
                var sharedOpenShiftObjectpropCount = 0;
                if (requestsharedOpenShiftdisplayName != null)
                {
                    sharedOpenShiftObject["displayName"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftdisplayName);
                    sharedOpenShiftObjectpropCount++;
                }

                if (requestsharedOpenShiftnotes != null)
                {
                    sharedOpenShiftObject["notes"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftnotes);
                    sharedOpenShiftObjectpropCount++;
                }

                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["startDateTime"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftstartTime);
                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["endDateTime"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftendTime);
                if (requestsharedOpenShifttheme != null)
                {
                    if (requestsharedOpenShifttheme != null)
                    {
                        sharedOpenShiftObject["theme"] = SourceExpressionConverter.Convert(requestsharedOpenShifttheme);
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
                sharedOpenShiftObject["openSlotCount"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftopenSlotCount);
                if (requestsharedOpenShiftactivities != null)
                {
                    sharedOpenShiftObject["activities"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftactivities);
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
                return callPayload;
            }

            return new ApiConnectionAction<OpenShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> GetOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(openShiftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpenShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftResponse> UpdateOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftId, [WorkflowExpression] Func<string> requestsharedOpenShiftstartTime, [WorkflowExpression] Func<string> requestsharedOpenShiftendTime, [WorkflowExpression] Func<int> requestsharedOpenShiftopenSlotCount, [WorkflowExpression] Func<string> requestschedulingGroupId = null, [WorkflowExpression] Func<string> requestsharedOpenShiftdisplayName = null, [WorkflowExpression] Func<string> requestsharedOpenShiftnotes = null, [WorkflowExpression] Func<requestsharedOpenShiftthemeInput> requestsharedOpenShifttheme = null, [WorkflowExpression] Func<requestsharedOpenShiftactivitiesInputItem[]> requestsharedOpenShiftactivities = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(openShiftId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestschedulingGroupId != null)
                {
                    request["schedulingGroupId"] = SourceExpressionConverter.ConvertToken(requestschedulingGroupId);
                    requestpropCount++;
                }

                var sharedOpenShiftObject = new JObject();
                var sharedOpenShiftObjectpropCount = 0;
                if (requestsharedOpenShiftdisplayName != null)
                {
                    sharedOpenShiftObject["displayName"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftdisplayName);
                    sharedOpenShiftObjectpropCount++;
                }

                if (requestsharedOpenShiftnotes != null)
                {
                    sharedOpenShiftObject["notes"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftnotes);
                    sharedOpenShiftObjectpropCount++;
                }

                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["startDateTime"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftstartTime);
                sharedOpenShiftObjectpropCount++;
                sharedOpenShiftObject["endDateTime"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftendTime);
                if (requestsharedOpenShifttheme != null)
                {
                    if (requestsharedOpenShifttheme != null)
                    {
                        sharedOpenShiftObject["theme"] = SourceExpressionConverter.Convert(requestsharedOpenShifttheme);
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
                sharedOpenShiftObject["openSlotCount"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftopenSlotCount);
                if (requestsharedOpenShiftactivities != null)
                {
                    sharedOpenShiftObject["activities"] = SourceExpressionConverter.ConvertToken(requestsharedOpenShiftactivities);
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
                return callPayload;
            }

            return new ApiConnectionAction<OpenShiftResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction DeleteOpenShift([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShifts/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(openShiftId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<GetTimeOffReasonsResponse> ListTimeOffReasons([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffReasons", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<GetTimeOffReasonsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSchedulingGroupsResponse> ListSchedulingGroups([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListSchedulingGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SchedulingGroupResponse> GetSchedulingGroup([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> schedulingGroupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/schedulinggroups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(schedulingGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SchedulingGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimeOffRequestsResponse> ListTimeOffRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<ListTimeOffRequestsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<TimeOffRequestResponse> GetTimeOffShiftRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffRequestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeOffRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TimeOffRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction TimeOffRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/approve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeOffRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction TimeOffRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> timeOffRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/timeOffRequests/{1}/decline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(timeOffRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOfferShiftRequestsResponse> ListOfferShiftRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<ListOfferShiftRequestsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OfferShiftRequestResponse> GetOfferShiftRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> offerShiftRequestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerShiftRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OfferShiftRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OfferShiftRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> offerShiftRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/approve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerShiftRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromRecipientManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OfferShiftRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> offerShiftRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/offerShiftRequests/{1}/decline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(offerShiftRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromRecipientManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListSwapShiftsChangeRequestsResponse> ListSwapShiftsChangeRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<ListSwapShiftsChangeRequestsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<SwapShiftsChangeRequestResponse> GetSwapShiftsChangeRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> swapShiftsChangeRequestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SwapShiftsChangeRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction SwapShiftsChangeRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> swapShiftsChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/approve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromRecipientManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction SwapShiftsChangeRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> swapShiftsChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromRecipientManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/swapShiftsChangeRequests/{1}/decline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(swapShiftsChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromRecipientManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromRecipientManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftChangeRequestsResponse> ListOpenShiftChangeRequests([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<ListOpenShiftChangeRequestsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<OpenShiftChangeRequestResponse> GetOpenShiftChangeRequest([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftChangeRequestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpenShiftChangeRequestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OpenShiftChangeRequestApprove([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/approve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IWorkflowAction OpenShiftChangeRequestDecline([WorkflowExpression] Func<string> teamId, [WorkflowExpression] Func<string> openShiftChangeRequestId, [WorkflowExpression] Func<string> requestmessageFromManager = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/teams/{0}/schedule/openShiftChangeRequests/{1}/decline", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(openShiftChangeRequestId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                if (requestmessageFromManager != null)
                {
                    request["message"] = SourceExpressionConverter.ConvertToken(requestmessageFromManager);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListOpenShiftsCrossTeamResponse> ListOpenShiftsCrossTeam([WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/me/joinedTeams/getOpenShifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = SourceExpressionConverter.ConvertO(endTime);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListOpenShiftsCrossTeamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListShiftsCrossTeamResponse> ListShiftsCrossTeam([WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<string> assignedToUserName = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/me/joinedTeams/getShifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = SourceExpressionConverter.ConvertO(endTime);
                if (assignedToUserName != null)
                    callPayload.Queries["assignedToUserName"] = SourceExpressionConverter.ConvertO(assignedToUserName);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListShiftsCrossTeamResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shifts")]
        public IBodyWorkflowAction<ListTimesOffCrossTeamResponse> ListTimesOffCrossTeam([WorkflowExpression] Func<string> startTime = null, [WorkflowExpression] Func<string> endTime = null, [WorkflowExpression] Func<string> assignedToUserName = null, [WorkflowExpression] Func<int> top = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/me/joinedTeams/getTimesOff";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (startTime != null)
                    callPayload.Queries["startTime"] = SourceExpressionConverter.ConvertO(startTime);
                if (endTime != null)
                    callPayload.Queries["endTime"] = SourceExpressionConverter.ConvertO(endTime);
                if (assignedToUserName != null)
                    callPayload.Queries["assignedToUserName"] = SourceExpressionConverter.ConvertO(assignedToUserName);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ListTimesOffCrossTeamResponse>(BuildSourceInput);
        }
    }

    public class ShiftsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TriggerForOpenShiftChangeRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/openshiftchangerequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerForSwapShiftsChangeRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/swapshiftschangerequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerForOfferShiftRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/offershiftrequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerForTimeOffRequests([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/timeoffrequests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger TriggerForShifts([WorkflowExpression] Func<string> teamId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger/teams/{0}/shifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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